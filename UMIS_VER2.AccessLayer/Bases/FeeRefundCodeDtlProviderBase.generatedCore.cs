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
	/// This class is the base class for any <see cref="FeeRefundCodeDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeRefundCodeDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeRefundCodeDtl, UMIS_VER2.BusinessLyer.FeeRefundCodeDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeRefundCodeDtlKey key)
		{
			return Delete(transactionManager, key.FeeRefundCodeDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeRefundCodeDtlId">تفاصيل لائحة الاسترداد. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeRefundCodeDtlId)
		{
			return Delete(null, _feeRefundCodeDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefundCodeDtlId">تفاصيل لائحة الاسترداد. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeRefundCodeDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_ADM_CDE_FEE key.
		///		FK_FEE_REFUND_CODE_DTL_ADM_CDE_FEE Description: 
		/// </summary>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByAdmCdeFeeId(System.Decimal? _admCdeFeeId)
		{
			int count = -1;
			return GetByAdmCdeFeeId(_admCdeFeeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_ADM_CDE_FEE key.
		///		FK_FEE_REFUND_CODE_DTL_ADM_CDE_FEE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		/// <remarks></remarks>
		public TList<FeeRefundCodeDtl> GetByAdmCdeFeeId(TransactionManager transactionManager, System.Decimal? _admCdeFeeId)
		{
			int count = -1;
			return GetByAdmCdeFeeId(transactionManager, _admCdeFeeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_ADM_CDE_FEE key.
		///		FK_FEE_REFUND_CODE_DTL_ADM_CDE_FEE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByAdmCdeFeeId(TransactionManager transactionManager, System.Decimal? _admCdeFeeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeFeeId(transactionManager, _admCdeFeeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_ADM_CDE_FEE key.
		///		fkFeeRefundCodeDtlAdmCdeFee Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByAdmCdeFeeId(System.Decimal? _admCdeFeeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeFeeId(null, _admCdeFeeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_ADM_CDE_FEE key.
		///		fkFeeRefundCodeDtlAdmCdeFee Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByAdmCdeFeeId(System.Decimal? _admCdeFeeId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeFeeId(null, _admCdeFeeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_ADM_CDE_FEE key.
		///		FK_FEE_REFUND_CODE_DTL_ADM_CDE_FEE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public abstract TList<FeeRefundCodeDtl> GetByAdmCdeFeeId(TransactionManager transactionManager, System.Decimal? _admCdeFeeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM key.
		///		FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="_feeCodeItemId">البند المسترد</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByFeeCodeItemId(System.Decimal? _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(_feeCodeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM key.
		///		FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">البند المسترد</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		/// <remarks></remarks>
		public TList<FeeRefundCodeDtl> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal? _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM key.
		///		FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">البند المسترد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal? _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM key.
		///		fkFeeRefundCodeDtlFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId">البند المسترد</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByFeeCodeItemId(System.Decimal? _feeCodeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM key.
		///		fkFeeRefundCodeDtlFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId">البند المسترد</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByFeeCodeItemId(System.Decimal? _feeCodeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM key.
		///		FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">البند المسترد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public abstract TList<FeeRefundCodeDtl> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal? _feeCodeItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM1 key.
		///		FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM1 Description: 
		/// </summary>
		/// <param name="_feeCodeItemRltId">البند المرتبط -لايمكن اضافته بمفرده- يتم التعامل بمجموع البند والبند المرتبط وتطبيق النسبة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByFeeCodeItemRltId(System.Decimal? _feeCodeItemRltId)
		{
			int count = -1;
			return GetByFeeCodeItemRltId(_feeCodeItemRltId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM1 key.
		///		FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemRltId">البند المرتبط -لايمكن اضافته بمفرده- يتم التعامل بمجموع البند والبند المرتبط وتطبيق النسبة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		/// <remarks></remarks>
		public TList<FeeRefundCodeDtl> GetByFeeCodeItemRltId(TransactionManager transactionManager, System.Decimal? _feeCodeItemRltId)
		{
			int count = -1;
			return GetByFeeCodeItemRltId(transactionManager, _feeCodeItemRltId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM1 key.
		///		FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemRltId">البند المرتبط -لايمكن اضافته بمفرده- يتم التعامل بمجموع البند والبند المرتبط وتطبيق النسبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByFeeCodeItemRltId(TransactionManager transactionManager, System.Decimal? _feeCodeItemRltId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemRltId(transactionManager, _feeCodeItemRltId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM1 key.
		///		fkFeeRefundCodeDtlFeeCodeItem1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemRltId">البند المرتبط -لايمكن اضافته بمفرده- يتم التعامل بمجموع البند والبند المرتبط وتطبيق النسبة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByFeeCodeItemRltId(System.Decimal? _feeCodeItemRltId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeItemRltId(null, _feeCodeItemRltId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM1 key.
		///		fkFeeRefundCodeDtlFeeCodeItem1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemRltId">البند المرتبط -لايمكن اضافته بمفرده- يتم التعامل بمجموع البند والبند المرتبط وتطبيق النسبة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByFeeCodeItemRltId(System.Decimal? _feeCodeItemRltId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeItemRltId(null, _feeCodeItemRltId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM1 key.
		///		FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemRltId">البند المرتبط -لايمكن اضافته بمفرده- يتم التعامل بمجموع البند والبند المرتبط وتطبيق النسبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public abstract TList<FeeRefundCodeDtl> GetByFeeCodeItemRltId(TransactionManager transactionManager, System.Decimal? _feeCodeItemRltId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM2 key.
		///		FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM2 Description: 
		/// </summary>
		/// <param name="_feeCodeItemPnftId">البند المرحل  عليه</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByFeeCodeItemPnftId(System.Decimal? _feeCodeItemPnftId)
		{
			int count = -1;
			return GetByFeeCodeItemPnftId(_feeCodeItemPnftId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM2 key.
		///		FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemPnftId">البند المرحل  عليه</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		/// <remarks></remarks>
		public TList<FeeRefundCodeDtl> GetByFeeCodeItemPnftId(TransactionManager transactionManager, System.Decimal? _feeCodeItemPnftId)
		{
			int count = -1;
			return GetByFeeCodeItemPnftId(transactionManager, _feeCodeItemPnftId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM2 key.
		///		FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemPnftId">البند المرحل  عليه</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByFeeCodeItemPnftId(TransactionManager transactionManager, System.Decimal? _feeCodeItemPnftId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemPnftId(transactionManager, _feeCodeItemPnftId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM2 key.
		///		fkFeeRefundCodeDtlFeeCodeItem2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemPnftId">البند المرحل  عليه</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByFeeCodeItemPnftId(System.Decimal? _feeCodeItemPnftId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeItemPnftId(null, _feeCodeItemPnftId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM2 key.
		///		fkFeeRefundCodeDtlFeeCodeItem2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemPnftId">البند المرحل  عليه</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByFeeCodeItemPnftId(System.Decimal? _feeCodeItemPnftId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeItemPnftId(null, _feeCodeItemPnftId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM2 key.
		///		FK_FEE_REFUND_CODE_DTL_FEE_CODE_ITEM2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemPnftId">البند المرحل  عليه</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public abstract TList<FeeRefundCodeDtl> GetByFeeCodeItemPnftId(TransactionManager transactionManager, System.Decimal? _feeCodeItemPnftId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_REFUND_CODE key.
		///		FK_FEE_REFUND_CODE_DTL_FEE_REFUND_CODE Description: 
		/// </summary>
		/// <param name="_feeRefundCodeId">RFND_ID لائحة الاسترداد</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByFeeRefundCodeId(System.Decimal _feeRefundCodeId)
		{
			int count = -1;
			return GetByFeeRefundCodeId(_feeRefundCodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_REFUND_CODE key.
		///		FK_FEE_REFUND_CODE_DTL_FEE_REFUND_CODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefundCodeId">RFND_ID لائحة الاسترداد</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		/// <remarks></remarks>
		public TList<FeeRefundCodeDtl> GetByFeeRefundCodeId(TransactionManager transactionManager, System.Decimal _feeRefundCodeId)
		{
			int count = -1;
			return GetByFeeRefundCodeId(transactionManager, _feeRefundCodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_REFUND_CODE key.
		///		FK_FEE_REFUND_CODE_DTL_FEE_REFUND_CODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefundCodeId">RFND_ID لائحة الاسترداد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByFeeRefundCodeId(TransactionManager transactionManager, System.Decimal _feeRefundCodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeRefundCodeId(transactionManager, _feeRefundCodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_REFUND_CODE key.
		///		fkFeeRefundCodeDtlFeeRefundCode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeRefundCodeId">RFND_ID لائحة الاسترداد</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByFeeRefundCodeId(System.Decimal _feeRefundCodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeRefundCodeId(null, _feeRefundCodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_REFUND_CODE key.
		///		fkFeeRefundCodeDtlFeeRefundCode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeRefundCodeId">RFND_ID لائحة الاسترداد</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public TList<FeeRefundCodeDtl> GetByFeeRefundCodeId(System.Decimal _feeRefundCodeId, int start, int pageLength,out int count)
		{
			return GetByFeeRefundCodeId(null, _feeRefundCodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_DTL_FEE_REFUND_CODE key.
		///		FK_FEE_REFUND_CODE_DTL_FEE_REFUND_CODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefundCodeId">RFND_ID لائحة الاسترداد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCodeDtl objects.</returns>
		public abstract TList<FeeRefundCodeDtl> GetByFeeRefundCodeId(TransactionManager transactionManager, System.Decimal _feeRefundCodeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeRefundCodeDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeRefundCodeDtlKey key, int start, int pageLength)
		{
			return GetByFeeRefundCodeDtlId(transactionManager, key.FeeRefundCodeDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_REFUND_CODE_DTL index.
		/// </summary>
		/// <param name="_feeRefundCodeDtlId">تفاصيل لائحة الاسترداد</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefundCodeDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefundCodeDtl GetByFeeRefundCodeDtlId(System.Decimal _feeRefundCodeDtlId)
		{
			int count = -1;
			return GetByFeeRefundCodeDtlId(null,_feeRefundCodeDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_REFUND_CODE_DTL index.
		/// </summary>
		/// <param name="_feeRefundCodeDtlId">تفاصيل لائحة الاسترداد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefundCodeDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefundCodeDtl GetByFeeRefundCodeDtlId(System.Decimal _feeRefundCodeDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeRefundCodeDtlId(null, _feeRefundCodeDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_REFUND_CODE_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefundCodeDtlId">تفاصيل لائحة الاسترداد</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefundCodeDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefundCodeDtl GetByFeeRefundCodeDtlId(TransactionManager transactionManager, System.Decimal _feeRefundCodeDtlId)
		{
			int count = -1;
			return GetByFeeRefundCodeDtlId(transactionManager, _feeRefundCodeDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_REFUND_CODE_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefundCodeDtlId">تفاصيل لائحة الاسترداد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefundCodeDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefundCodeDtl GetByFeeRefundCodeDtlId(TransactionManager transactionManager, System.Decimal _feeRefundCodeDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeRefundCodeDtlId(transactionManager, _feeRefundCodeDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_REFUND_CODE_DTL index.
		/// </summary>
		/// <param name="_feeRefundCodeDtlId">تفاصيل لائحة الاسترداد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefundCodeDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefundCodeDtl GetByFeeRefundCodeDtlId(System.Decimal _feeRefundCodeDtlId, int start, int pageLength, out int count)
		{
			return GetByFeeRefundCodeDtlId(null, _feeRefundCodeDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_REFUND_CODE_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefundCodeDtlId">تفاصيل لائحة الاسترداد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefundCodeDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeRefundCodeDtl GetByFeeRefundCodeDtlId(TransactionManager transactionManager, System.Decimal _feeRefundCodeDtlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeRefundCodeDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeRefundCodeDtl&gt;"/></returns>
		public static TList<FeeRefundCodeDtl> Fill(IDataReader reader, TList<FeeRefundCodeDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeRefundCodeDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeRefundCodeDtl")
					.Append("|").Append((System.Decimal)reader["FEE_REFUND_CODE_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeRefundCodeDtl>(
					key.ToString(), // EntityTrackingKey
					"FeeRefundCodeDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeRefundCodeDtl();
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
					c.FeeRefundCodeDtlId = (System.Decimal)reader["FEE_REFUND_CODE_DTL_ID"];
					c.OriginalFeeRefundCodeDtlId = c.FeeRefundCodeDtlId;
					c.FeeRefundCodeId = (System.Decimal)reader["FEE_REFUND_CODE_ID"];
					c.FeeCodeItemId = Convert.IsDBNull(reader["FEE_CODE_ITEM_ID"]) ? null : (System.Decimal?)reader["FEE_CODE_ITEM_ID"];
					c.AdmCdeFeeId = Convert.IsDBNull(reader["ADM_CDE_FEE_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_FEE_ID"];
					c.DueDate = Convert.IsDBNull(reader["DUE_DATE"]) ? null : (System.DateTime?)reader["DUE_DATE"];
					c.RfndPrcnt = (System.Decimal)reader["RFND_PRCNT"];
					c.FeeCodeItemRltId = Convert.IsDBNull(reader["FEE_CODE_ITEM_RLT_ID"]) ? null : (System.Decimal?)reader["FEE_CODE_ITEM_RLT_ID"];
					c.FeeCodeItemPnftId = Convert.IsDBNull(reader["FEE_CODE_ITEM_PNFT_ID"]) ? null : (System.Decimal?)reader["FEE_CODE_ITEM_PNFT_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeRefundCodeDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeRefundCodeDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeRefundCodeDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeRefundCodeDtlId = (System.Decimal)reader[((int)FeeRefundCodeDtlColumn.FeeRefundCodeDtlId - 1)];
			entity.OriginalFeeRefundCodeDtlId = (System.Decimal)reader["FEE_REFUND_CODE_DTL_ID"];
			entity.FeeRefundCodeId = (System.Decimal)reader[((int)FeeRefundCodeDtlColumn.FeeRefundCodeId - 1)];
			entity.FeeCodeItemId = (reader.IsDBNull(((int)FeeRefundCodeDtlColumn.FeeCodeItemId - 1)))?null:(System.Decimal?)reader[((int)FeeRefundCodeDtlColumn.FeeCodeItemId - 1)];
			entity.AdmCdeFeeId = (reader.IsDBNull(((int)FeeRefundCodeDtlColumn.AdmCdeFeeId - 1)))?null:(System.Decimal?)reader[((int)FeeRefundCodeDtlColumn.AdmCdeFeeId - 1)];
			entity.DueDate = (reader.IsDBNull(((int)FeeRefundCodeDtlColumn.DueDate - 1)))?null:(System.DateTime?)reader[((int)FeeRefundCodeDtlColumn.DueDate - 1)];
			entity.RfndPrcnt = (System.Decimal)reader[((int)FeeRefundCodeDtlColumn.RfndPrcnt - 1)];
			entity.FeeCodeItemRltId = (reader.IsDBNull(((int)FeeRefundCodeDtlColumn.FeeCodeItemRltId - 1)))?null:(System.Decimal?)reader[((int)FeeRefundCodeDtlColumn.FeeCodeItemRltId - 1)];
			entity.FeeCodeItemPnftId = (reader.IsDBNull(((int)FeeRefundCodeDtlColumn.FeeCodeItemPnftId - 1)))?null:(System.Decimal?)reader[((int)FeeRefundCodeDtlColumn.FeeCodeItemPnftId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeRefundCodeDtlColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeRefundCodeDtlColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeRefundCodeDtlColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeRefundCodeDtlColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeRefundCodeDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeRefundCodeDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeRefundCodeDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeRefundCodeDtlId = (System.Decimal)dataRow["FEE_REFUND_CODE_DTL_ID"];
			entity.OriginalFeeRefundCodeDtlId = (System.Decimal)dataRow["FEE_REFUND_CODE_DTL_ID"];
			entity.FeeRefundCodeId = (System.Decimal)dataRow["FEE_REFUND_CODE_ID"];
			entity.FeeCodeItemId = Convert.IsDBNull(dataRow["FEE_CODE_ITEM_ID"]) ? null : (System.Decimal?)dataRow["FEE_CODE_ITEM_ID"];
			entity.AdmCdeFeeId = Convert.IsDBNull(dataRow["ADM_CDE_FEE_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_FEE_ID"];
			entity.DueDate = Convert.IsDBNull(dataRow["DUE_DATE"]) ? null : (System.DateTime?)dataRow["DUE_DATE"];
			entity.RfndPrcnt = (System.Decimal)dataRow["RFND_PRCNT"];
			entity.FeeCodeItemRltId = Convert.IsDBNull(dataRow["FEE_CODE_ITEM_RLT_ID"]) ? null : (System.Decimal?)dataRow["FEE_CODE_ITEM_RLT_ID"];
			entity.FeeCodeItemPnftId = Convert.IsDBNull(dataRow["FEE_CODE_ITEM_PNFT_ID"]) ? null : (System.Decimal?)dataRow["FEE_CODE_ITEM_PNFT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeRefundCodeDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeRefundCodeDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeRefundCodeDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmCdeFeeIdSource	
			if (CanDeepLoad(entity, "AdmCdeFee|AdmCdeFeeIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeFeeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeFeeId ?? 0.0m);
				AdmCdeFee tmpEntity = EntityManager.LocateEntity<AdmCdeFee>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeFee), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeFeeIdSource = tmpEntity;
				else
					entity.AdmCdeFeeIdSource = DataRepository.AdmCdeFeeProvider.GetByAdmCdeFeeId(transactionManager, (entity.AdmCdeFeeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeFeeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeFeeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeFeeProvider.DeepLoad(transactionManager, entity.AdmCdeFeeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeFeeIdSource

			#region FeeCodeItemIdSource	
			if (CanDeepLoad(entity, "FeeCodeItem|FeeCodeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCodeItemId ?? 0.0m);
				FeeCodeItem tmpEntity = EntityManager.LocateEntity<FeeCodeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeItemIdSource = tmpEntity;
				else
					entity.FeeCodeItemIdSource = DataRepository.FeeCodeItemProvider.GetByFeeCodeItemId(transactionManager, (entity.FeeCodeItemId ?? 0.0m));		
				
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

			#region FeeCodeItemRltIdSource	
			if (CanDeepLoad(entity, "FeeCodeItem|FeeCodeItemRltIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeItemRltIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCodeItemRltId ?? 0.0m);
				FeeCodeItem tmpEntity = EntityManager.LocateEntity<FeeCodeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeItemRltIdSource = tmpEntity;
				else
					entity.FeeCodeItemRltIdSource = DataRepository.FeeCodeItemProvider.GetByFeeCodeItemId(transactionManager, (entity.FeeCodeItemRltId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeItemRltIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeItemRltIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeItemProvider.DeepLoad(transactionManager, entity.FeeCodeItemRltIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeItemRltIdSource

			#region FeeCodeItemPnftIdSource	
			if (CanDeepLoad(entity, "FeeCodeItem|FeeCodeItemPnftIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeItemPnftIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCodeItemPnftId ?? 0.0m);
				FeeCodeItem tmpEntity = EntityManager.LocateEntity<FeeCodeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeItemPnftIdSource = tmpEntity;
				else
					entity.FeeCodeItemPnftIdSource = DataRepository.FeeCodeItemProvider.GetByFeeCodeItemId(transactionManager, (entity.FeeCodeItemPnftId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeItemPnftIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeItemPnftIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeItemProvider.DeepLoad(transactionManager, entity.FeeCodeItemPnftIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeItemPnftIdSource

			#region FeeRefundCodeIdSource	
			if (CanDeepLoad(entity, "FeeRefundCode|FeeRefundCodeIdSource", deepLoadType, innerList) 
				&& entity.FeeRefundCodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeRefundCodeId;
				FeeRefundCode tmpEntity = EntityManager.LocateEntity<FeeRefundCode>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeRefundCode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeRefundCodeIdSource = tmpEntity;
				else
					entity.FeeRefundCodeIdSource = DataRepository.FeeRefundCodeProvider.GetByFeeRefundCodeId(transactionManager, entity.FeeRefundCodeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefundCodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeRefundCodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeRefundCodeProvider.DeepLoad(transactionManager, entity.FeeRefundCodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeRefundCodeIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeRefundCodeDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeRefundCodeDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeRefundCodeDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeRefundCodeDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCdeFeeIdSource
			if (CanDeepSave(entity, "AdmCdeFee|AdmCdeFeeIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeFeeIdSource != null)
			{
				DataRepository.AdmCdeFeeProvider.Save(transactionManager, entity.AdmCdeFeeIdSource);
				entity.AdmCdeFeeId = entity.AdmCdeFeeIdSource.AdmCdeFeeId;
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
			
			#region FeeCodeItemRltIdSource
			if (CanDeepSave(entity, "FeeCodeItem|FeeCodeItemRltIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeItemRltIdSource != null)
			{
				DataRepository.FeeCodeItemProvider.Save(transactionManager, entity.FeeCodeItemRltIdSource);
				entity.FeeCodeItemRltId = entity.FeeCodeItemRltIdSource.FeeCodeItemId;
			}
			#endregion 
			
			#region FeeCodeItemPnftIdSource
			if (CanDeepSave(entity, "FeeCodeItem|FeeCodeItemPnftIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeItemPnftIdSource != null)
			{
				DataRepository.FeeCodeItemProvider.Save(transactionManager, entity.FeeCodeItemPnftIdSource);
				entity.FeeCodeItemPnftId = entity.FeeCodeItemPnftIdSource.FeeCodeItemId;
			}
			#endregion 
			
			#region FeeRefundCodeIdSource
			if (CanDeepSave(entity, "FeeRefundCode|FeeRefundCodeIdSource", deepSaveType, innerList) 
				&& entity.FeeRefundCodeIdSource != null)
			{
				DataRepository.FeeRefundCodeProvider.Save(transactionManager, entity.FeeRefundCodeIdSource);
				entity.FeeRefundCodeId = entity.FeeRefundCodeIdSource.FeeRefundCodeId;
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
	
	#region FeeRefundCodeDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeRefundCodeDtl</c>
	///</summary>
	public enum FeeRefundCodeDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCdeFee</c> at AdmCdeFeeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeFee))]
		AdmCdeFee,
		
		///<summary>
		/// Composite Property for <c>FeeCodeItem</c> at FeeCodeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeItem))]
		FeeCodeItem,
		
		///<summary>
		/// Composite Property for <c>FeeRefundCode</c> at FeeRefundCodeIdSource
		///</summary>
		[ChildEntityType(typeof(FeeRefundCode))]
		FeeRefundCode,
	}
	
	#endregion FeeRefundCodeDtlChildEntityTypes
	
	#region FeeRefundCodeDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeRefundCodeDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeRefundCodeDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeRefundCodeDtlFilterBuilder : SqlFilterBuilder<FeeRefundCodeDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeRefundCodeDtlFilterBuilder class.
		/// </summary>
		public FeeRefundCodeDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeRefundCodeDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeRefundCodeDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeRefundCodeDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeRefundCodeDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeRefundCodeDtlFilterBuilder
	
	#region FeeRefundCodeDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeRefundCodeDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeRefundCodeDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeRefundCodeDtlParameterBuilder : ParameterizedSqlFilterBuilder<FeeRefundCodeDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeRefundCodeDtlParameterBuilder class.
		/// </summary>
		public FeeRefundCodeDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeRefundCodeDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeRefundCodeDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeRefundCodeDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeRefundCodeDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeRefundCodeDtlParameterBuilder
	
	#region FeeRefundCodeDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeRefundCodeDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeRefundCodeDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeRefundCodeDtlSortBuilder : SqlSortBuilder<FeeRefundCodeDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeRefundCodeDtlSqlSortBuilder class.
		/// </summary>
		public FeeRefundCodeDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeRefundCodeDtlSortBuilder
	
} // end namespace
