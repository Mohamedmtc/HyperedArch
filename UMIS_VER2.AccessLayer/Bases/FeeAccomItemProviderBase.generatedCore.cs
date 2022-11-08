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
	/// This class is the base class for any <see cref="FeeAccomItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeAccomItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeAccomItem, UMIS_VER2.BusinessLyer.FeeAccomItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeAccomItemKey key)
		{
			return Delete(transactionManager, key.FeeAccomItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeAccomItemId">لائحة مصروفات السكن  الجامعى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _feeAccomItemId)
		{
			return Delete(null, _feeAccomItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccomItemId">لائحة مصروفات السكن  الجامعى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _feeAccomItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCOM_ITEM_ED_ACAD_YEAR key.
		///		FK_FEE_ACCOM_ITEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">العام الأكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccomItem objects.</returns>
		public TList<FeeAccomItem> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCOM_ITEM_ED_ACAD_YEAR key.
		///		FK_FEE_ACCOM_ITEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الأكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccomItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeAccomItem> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCOM_ITEM_ED_ACAD_YEAR key.
		///		FK_FEE_ACCOM_ITEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الأكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccomItem objects.</returns>
		public TList<FeeAccomItem> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCOM_ITEM_ED_ACAD_YEAR key.
		///		fkFeeAccomItemEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الأكاديمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccomItem objects.</returns>
		public TList<FeeAccomItem> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCOM_ITEM_ED_ACAD_YEAR key.
		///		fkFeeAccomItemEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الأكاديمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccomItem objects.</returns>
		public TList<FeeAccomItem> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCOM_ITEM_ED_ACAD_YEAR key.
		///		FK_FEE_ACCOM_ITEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الأكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccomItem objects.</returns>
		public abstract TList<FeeAccomItem> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCOM_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_ACCOM_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="_feeCodeItemId">بند مصروف خدمة سكن -FEE_CODE_TYPE_ID=10</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccomItem objects.</returns>
		public TList<FeeAccomItem> GetByFeeCodeItemId(System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(_feeCodeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCOM_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_ACCOM_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">بند مصروف خدمة سكن -FEE_CODE_TYPE_ID=10</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccomItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeAccomItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCOM_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_ACCOM_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">بند مصروف خدمة سكن -FEE_CODE_TYPE_ID=10</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccomItem objects.</returns>
		public TList<FeeAccomItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCOM_ITEM_FEE_CODE_ITEM key.
		///		fkFeeAccomItemFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId">بند مصروف خدمة سكن -FEE_CODE_TYPE_ID=10</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccomItem objects.</returns>
		public TList<FeeAccomItem> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCOM_ITEM_FEE_CODE_ITEM key.
		///		fkFeeAccomItemFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId">بند مصروف خدمة سكن -FEE_CODE_TYPE_ID=10</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccomItem objects.</returns>
		public TList<FeeAccomItem> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCOM_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_ACCOM_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">بند مصروف خدمة سكن -FEE_CODE_TYPE_ID=10</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccomItem objects.</returns>
		public abstract TList<FeeAccomItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCOM_ITEM_GS_CODE_CURRENCY key.
		///		FK_FEE_ACCOM_ITEM_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccomItem objects.</returns>
		public TList<FeeAccomItem> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(_gsCodeCurrencyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCOM_ITEM_GS_CODE_CURRENCY key.
		///		FK_FEE_ACCOM_ITEM_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccomItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeAccomItem> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCOM_ITEM_GS_CODE_CURRENCY key.
		///		FK_FEE_ACCOM_ITEM_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccomItem objects.</returns>
		public TList<FeeAccomItem> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCOM_ITEM_GS_CODE_CURRENCY key.
		///		fkFeeAccomItemGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccomItem objects.</returns>
		public TList<FeeAccomItem> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCOM_ITEM_GS_CODE_CURRENCY key.
		///		fkFeeAccomItemGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccomItem objects.</returns>
		public TList<FeeAccomItem> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength,out int count)
		{
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCOM_ITEM_GS_CODE_CURRENCY key.
		///		FK_FEE_ACCOM_ITEM_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccomItem objects.</returns>
		public abstract TList<FeeAccomItem> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeAccomItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeAccomItemKey key, int start, int pageLength)
		{
			return GetByFeeAccomItemId(transactionManager, key.FeeAccomItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_ACCOM_ITEM index.
		/// </summary>
		/// <param name="_feeAccomItemId">لائحة مصروفات السكن  الجامعى</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccomItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccomItem GetByFeeAccomItemId(System.Int32 _feeAccomItemId)
		{
			int count = -1;
			return GetByFeeAccomItemId(null,_feeAccomItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ACCOM_ITEM index.
		/// </summary>
		/// <param name="_feeAccomItemId">لائحة مصروفات السكن  الجامعى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccomItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccomItem GetByFeeAccomItemId(System.Int32 _feeAccomItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeAccomItemId(null, _feeAccomItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ACCOM_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccomItemId">لائحة مصروفات السكن  الجامعى</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccomItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccomItem GetByFeeAccomItemId(TransactionManager transactionManager, System.Int32 _feeAccomItemId)
		{
			int count = -1;
			return GetByFeeAccomItemId(transactionManager, _feeAccomItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ACCOM_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccomItemId">لائحة مصروفات السكن  الجامعى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccomItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccomItem GetByFeeAccomItemId(TransactionManager transactionManager, System.Int32 _feeAccomItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeAccomItemId(transactionManager, _feeAccomItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ACCOM_ITEM index.
		/// </summary>
		/// <param name="_feeAccomItemId">لائحة مصروفات السكن  الجامعى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccomItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccomItem GetByFeeAccomItemId(System.Int32 _feeAccomItemId, int start, int pageLength, out int count)
		{
			return GetByFeeAccomItemId(null, _feeAccomItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ACCOM_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccomItemId">لائحة مصروفات السكن  الجامعى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccomItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeAccomItem GetByFeeAccomItemId(TransactionManager transactionManager, System.Int32 _feeAccomItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_ACCOM_ITEM index.
		/// </summary>
		/// <param name="_feeCodeItemId">بند مصروف خدمة سكن -FEE_CODE_TYPE_ID=10</param>
		/// <param name="_edAcadYearId">العام الأكاديمى</param>
		/// <param name="_inOutFlg">قيم بالسكن الجامعى أم الخارجي؟ In / out</param>
		/// <param name="_maritalFlg">حالة السكن : أعزب / متزوج</param>
		/// <param name="_airCondFlg">مكيف-  غير مكيف</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccomItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccomItem GetByFeeCodeItemIdEdAcadYearIdInOutFlgMaritalFlgAirCondFlg(System.Decimal _feeCodeItemId, System.Decimal _edAcadYearId, System.Boolean? _inOutFlg, System.Boolean? _maritalFlg, System.Boolean? _airCondFlg)
		{
			int count = -1;
			return GetByFeeCodeItemIdEdAcadYearIdInOutFlgMaritalFlgAirCondFlg(null,_feeCodeItemId, _edAcadYearId, _inOutFlg, _maritalFlg, _airCondFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ACCOM_ITEM index.
		/// </summary>
		/// <param name="_feeCodeItemId">بند مصروف خدمة سكن -FEE_CODE_TYPE_ID=10</param>
		/// <param name="_edAcadYearId">العام الأكاديمى</param>
		/// <param name="_inOutFlg">قيم بالسكن الجامعى أم الخارجي؟ In / out</param>
		/// <param name="_maritalFlg">حالة السكن : أعزب / متزوج</param>
		/// <param name="_airCondFlg">مكيف-  غير مكيف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccomItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccomItem GetByFeeCodeItemIdEdAcadYearIdInOutFlgMaritalFlgAirCondFlg(System.Decimal _feeCodeItemId, System.Decimal _edAcadYearId, System.Boolean? _inOutFlg, System.Boolean? _maritalFlg, System.Boolean? _airCondFlg, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemIdEdAcadYearIdInOutFlgMaritalFlgAirCondFlg(null, _feeCodeItemId, _edAcadYearId, _inOutFlg, _maritalFlg, _airCondFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ACCOM_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">بند مصروف خدمة سكن -FEE_CODE_TYPE_ID=10</param>
		/// <param name="_edAcadYearId">العام الأكاديمى</param>
		/// <param name="_inOutFlg">قيم بالسكن الجامعى أم الخارجي؟ In / out</param>
		/// <param name="_maritalFlg">حالة السكن : أعزب / متزوج</param>
		/// <param name="_airCondFlg">مكيف-  غير مكيف</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccomItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccomItem GetByFeeCodeItemIdEdAcadYearIdInOutFlgMaritalFlgAirCondFlg(TransactionManager transactionManager, System.Decimal _feeCodeItemId, System.Decimal _edAcadYearId, System.Boolean? _inOutFlg, System.Boolean? _maritalFlg, System.Boolean? _airCondFlg)
		{
			int count = -1;
			return GetByFeeCodeItemIdEdAcadYearIdInOutFlgMaritalFlgAirCondFlg(transactionManager, _feeCodeItemId, _edAcadYearId, _inOutFlg, _maritalFlg, _airCondFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ACCOM_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">بند مصروف خدمة سكن -FEE_CODE_TYPE_ID=10</param>
		/// <param name="_edAcadYearId">العام الأكاديمى</param>
		/// <param name="_inOutFlg">قيم بالسكن الجامعى أم الخارجي؟ In / out</param>
		/// <param name="_maritalFlg">حالة السكن : أعزب / متزوج</param>
		/// <param name="_airCondFlg">مكيف-  غير مكيف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccomItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccomItem GetByFeeCodeItemIdEdAcadYearIdInOutFlgMaritalFlgAirCondFlg(TransactionManager transactionManager, System.Decimal _feeCodeItemId, System.Decimal _edAcadYearId, System.Boolean? _inOutFlg, System.Boolean? _maritalFlg, System.Boolean? _airCondFlg, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemIdEdAcadYearIdInOutFlgMaritalFlgAirCondFlg(transactionManager, _feeCodeItemId, _edAcadYearId, _inOutFlg, _maritalFlg, _airCondFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ACCOM_ITEM index.
		/// </summary>
		/// <param name="_feeCodeItemId">بند مصروف خدمة سكن -FEE_CODE_TYPE_ID=10</param>
		/// <param name="_edAcadYearId">العام الأكاديمى</param>
		/// <param name="_inOutFlg">قيم بالسكن الجامعى أم الخارجي؟ In / out</param>
		/// <param name="_maritalFlg">حالة السكن : أعزب / متزوج</param>
		/// <param name="_airCondFlg">مكيف-  غير مكيف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccomItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccomItem GetByFeeCodeItemIdEdAcadYearIdInOutFlgMaritalFlgAirCondFlg(System.Decimal _feeCodeItemId, System.Decimal _edAcadYearId, System.Boolean? _inOutFlg, System.Boolean? _maritalFlg, System.Boolean? _airCondFlg, int start, int pageLength, out int count)
		{
			return GetByFeeCodeItemIdEdAcadYearIdInOutFlgMaritalFlgAirCondFlg(null, _feeCodeItemId, _edAcadYearId, _inOutFlg, _maritalFlg, _airCondFlg, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ACCOM_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">بند مصروف خدمة سكن -FEE_CODE_TYPE_ID=10</param>
		/// <param name="_edAcadYearId">العام الأكاديمى</param>
		/// <param name="_inOutFlg">قيم بالسكن الجامعى أم الخارجي؟ In / out</param>
		/// <param name="_maritalFlg">حالة السكن : أعزب / متزوج</param>
		/// <param name="_airCondFlg">مكيف-  غير مكيف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccomItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeAccomItem GetByFeeCodeItemIdEdAcadYearIdInOutFlgMaritalFlgAirCondFlg(TransactionManager transactionManager, System.Decimal _feeCodeItemId, System.Decimal _edAcadYearId, System.Boolean? _inOutFlg, System.Boolean? _maritalFlg, System.Boolean? _airCondFlg, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeAccomItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeAccomItem&gt;"/></returns>
		public static TList<FeeAccomItem> Fill(IDataReader reader, TList<FeeAccomItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeAccomItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeAccomItem")
					.Append("|").Append((System.Int32)reader["FEE_ACCOM_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeAccomItem>(
					key.ToString(), // EntityTrackingKey
					"FeeAccomItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeAccomItem();
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
					c.FeeAccomItemId = (System.Int32)reader["FEE_ACCOM_ITEM_ID"];
					c.OriginalFeeAccomItemId = c.FeeAccomItemId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.FeeCodeItemId = (System.Decimal)reader["FEE_CODE_ITEM_ID"];
					c.InOutFlg = Convert.IsDBNull(reader["IN_OUT_FLG"]) ? null : (System.Boolean?)reader["IN_OUT_FLG"];
					c.AirCondFlg = Convert.IsDBNull(reader["AIR_COND_FLG"]) ? null : (System.Boolean?)reader["AIR_COND_FLG"];
					c.MaritalFlg = Convert.IsDBNull(reader["MARITAL_FLG"]) ? null : (System.Boolean?)reader["MARITAL_FLG"];
					c.FeeItemValue = Convert.IsDBNull(reader["FEE_ITEM_VALUE"]) ? null : (System.Decimal?)reader["FEE_ITEM_VALUE"];
					c.GsCodeCurrencyId = (System.Decimal)reader["GS_CODE_CURRENCY_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeAccomItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeAccomItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeAccomItem entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeAccomItemId = (System.Int32)reader[((int)FeeAccomItemColumn.FeeAccomItemId - 1)];
			entity.OriginalFeeAccomItemId = (System.Int32)reader["FEE_ACCOM_ITEM_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)FeeAccomItemColumn.EdAcadYearId - 1)];
			entity.FeeCodeItemId = (System.Decimal)reader[((int)FeeAccomItemColumn.FeeCodeItemId - 1)];
			entity.InOutFlg = (reader.IsDBNull(((int)FeeAccomItemColumn.InOutFlg - 1)))?null:(System.Boolean?)reader[((int)FeeAccomItemColumn.InOutFlg - 1)];
			entity.AirCondFlg = (reader.IsDBNull(((int)FeeAccomItemColumn.AirCondFlg - 1)))?null:(System.Boolean?)reader[((int)FeeAccomItemColumn.AirCondFlg - 1)];
			entity.MaritalFlg = (reader.IsDBNull(((int)FeeAccomItemColumn.MaritalFlg - 1)))?null:(System.Boolean?)reader[((int)FeeAccomItemColumn.MaritalFlg - 1)];
			entity.FeeItemValue = (reader.IsDBNull(((int)FeeAccomItemColumn.FeeItemValue - 1)))?null:(System.Decimal?)reader[((int)FeeAccomItemColumn.FeeItemValue - 1)];
			entity.GsCodeCurrencyId = (System.Decimal)reader[((int)FeeAccomItemColumn.GsCodeCurrencyId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeAccomItemColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeAccomItemColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeAccomItemColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeAccomItemColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeAccomItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeAccomItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeAccomItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeAccomItemId = (System.Int32)dataRow["FEE_ACCOM_ITEM_ID"];
			entity.OriginalFeeAccomItemId = (System.Int32)dataRow["FEE_ACCOM_ITEM_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.FeeCodeItemId = (System.Decimal)dataRow["FEE_CODE_ITEM_ID"];
			entity.InOutFlg = Convert.IsDBNull(dataRow["IN_OUT_FLG"]) ? null : (System.Boolean?)dataRow["IN_OUT_FLG"];
			entity.AirCondFlg = Convert.IsDBNull(dataRow["AIR_COND_FLG"]) ? null : (System.Boolean?)dataRow["AIR_COND_FLG"];
			entity.MaritalFlg = Convert.IsDBNull(dataRow["MARITAL_FLG"]) ? null : (System.Boolean?)dataRow["MARITAL_FLG"];
			entity.FeeItemValue = Convert.IsDBNull(dataRow["FEE_ITEM_VALUE"]) ? null : (System.Decimal?)dataRow["FEE_ITEM_VALUE"];
			entity.GsCodeCurrencyId = (System.Decimal)dataRow["GS_CODE_CURRENCY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeAccomItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeAccomItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeAccomItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region FeeCodeItemIdSource	
			if (CanDeepLoad(entity, "FeeCodeItem|FeeCodeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCodeItemId;
				FeeCodeItem tmpEntity = EntityManager.LocateEntity<FeeCodeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeItemIdSource = tmpEntity;
				else
					entity.FeeCodeItemIdSource = DataRepository.FeeCodeItemProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeItemProvider.DeepLoad(transactionManager, entity.FeeCodeItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeItemIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeAccomItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeAccomItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeAccomItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeAccomItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region FeeCodeItemIdSource
			if (CanDeepSave(entity, "FeeCodeItem|FeeCodeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeItemIdSource != null)
			{
				DataRepository.FeeCodeItemProvider.Save(transactionManager, entity.FeeCodeItemIdSource);
				entity.FeeCodeItemId = entity.FeeCodeItemIdSource.FeeCodeItemId;
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
	
	#region FeeAccomItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeAccomItem</c>
	///</summary>
	public enum FeeAccomItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>FeeCodeItem</c> at FeeCodeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeItem))]
		FeeCodeItem,
		
		///<summary>
		/// Composite Property for <c>GsCodeCurrency</c> at GsCodeCurrencyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeCurrency))]
		GsCodeCurrency,
	}
	
	#endregion FeeAccomItemChildEntityTypes
	
	#region FeeAccomItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeAccomItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeAccomItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeAccomItemFilterBuilder : SqlFilterBuilder<FeeAccomItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeAccomItemFilterBuilder class.
		/// </summary>
		public FeeAccomItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeAccomItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeAccomItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeAccomItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeAccomItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeAccomItemFilterBuilder
	
	#region FeeAccomItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeAccomItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeAccomItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeAccomItemParameterBuilder : ParameterizedSqlFilterBuilder<FeeAccomItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeAccomItemParameterBuilder class.
		/// </summary>
		public FeeAccomItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeAccomItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeAccomItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeAccomItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeAccomItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeAccomItemParameterBuilder
	
	#region FeeAccomItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeAccomItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeAccomItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeAccomItemSortBuilder : SqlSortBuilder<FeeAccomItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeAccomItemSqlSortBuilder class.
		/// </summary>
		public FeeAccomItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeAccomItemSortBuilder
	
} // end namespace
