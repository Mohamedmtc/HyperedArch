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
	/// This class is the base class for any <see cref="FeeRefndStdDetProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeRefndStdDetProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeRefndStdDet, UMIS_VER2.BusinessLyer.FeeRefndStdDetKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeRefndStdDetKey key)
		{
			return Delete(transactionManager, key.FeeRefndStdDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeRefndStdDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeRefndStdDtlId)
		{
			return Delete(null, _feeRefndStdDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefndStdDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeRefndStdDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFND_STD_DET_ADM_APP_FEES key.
		///		FK_FEE_REFND_STD_DET_ADM_APP_FEES Description: 
		/// </summary>
		/// <param name="_admAppFeesId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public TList<FeeRefndStdDet> GetByAdmAppFeesId(System.Decimal? _admAppFeesId)
		{
			int count = -1;
			return GetByAdmAppFeesId(_admAppFeesId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFND_STD_DET_ADM_APP_FEES key.
		///		FK_FEE_REFND_STD_DET_ADM_APP_FEES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppFeesId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		/// <remarks></remarks>
		public TList<FeeRefndStdDet> GetByAdmAppFeesId(TransactionManager transactionManager, System.Decimal? _admAppFeesId)
		{
			int count = -1;
			return GetByAdmAppFeesId(transactionManager, _admAppFeesId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFND_STD_DET_ADM_APP_FEES key.
		///		FK_FEE_REFND_STD_DET_ADM_APP_FEES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppFeesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public TList<FeeRefndStdDet> GetByAdmAppFeesId(TransactionManager transactionManager, System.Decimal? _admAppFeesId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppFeesId(transactionManager, _admAppFeesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFND_STD_DET_ADM_APP_FEES key.
		///		fkFeeRefndStdDetAdmAppFees Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppFeesId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public TList<FeeRefndStdDet> GetByAdmAppFeesId(System.Decimal? _admAppFeesId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppFeesId(null, _admAppFeesId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFND_STD_DET_ADM_APP_FEES key.
		///		fkFeeRefndStdDetAdmAppFees Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppFeesId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public TList<FeeRefndStdDet> GetByAdmAppFeesId(System.Decimal? _admAppFeesId, int start, int pageLength,out int count)
		{
			return GetByAdmAppFeesId(null, _admAppFeesId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFND_STD_DET_ADM_APP_FEES key.
		///		FK_FEE_REFND_STD_DET_ADM_APP_FEES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppFeesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public abstract TList<FeeRefndStdDet> GetByAdmAppFeesId(TransactionManager transactionManager, System.Decimal? _admAppFeesId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_STUD_REQ_DET_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_REFUND_STUD_REQ_DET_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="_feeStudFeeItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public TList<FeeRefndStdDet> GetByFeeStudFeeItemId(System.Decimal? _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(_feeStudFeeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_STUD_REQ_DET_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_REFUND_STUD_REQ_DET_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		/// <remarks></remarks>
		public TList<FeeRefndStdDet> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal? _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_STUD_REQ_DET_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_REFUND_STUD_REQ_DET_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public TList<FeeRefndStdDet> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal? _feeStudFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_STUD_REQ_DET_FEE_STUD_FEE_ITEM key.
		///		fkFeeRefundStudReqDetFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public TList<FeeRefndStdDet> GetByFeeStudFeeItemId(System.Decimal? _feeStudFeeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_STUD_REQ_DET_FEE_STUD_FEE_ITEM key.
		///		fkFeeRefundStudReqDetFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public TList<FeeRefndStdDet> GetByFeeStudFeeItemId(System.Decimal? _feeStudFeeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_STUD_REQ_DET_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_REFUND_STUD_REQ_DET_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public abstract TList<FeeRefndStdDet> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal? _feeStudFeeItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_REFUND_STUD_REQ_DET_REFUND_CODE key.
		///		FK_REFUND_STUD_REQ_DET_REFUND_CODE Description: 
		/// </summary>
		/// <param name="_feeRefundCodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public TList<FeeRefndStdDet> GetByFeeRefundCodeId(System.Decimal? _feeRefundCodeId)
		{
			int count = -1;
			return GetByFeeRefundCodeId(_feeRefundCodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_REFUND_STUD_REQ_DET_REFUND_CODE key.
		///		FK_REFUND_STUD_REQ_DET_REFUND_CODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefundCodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		/// <remarks></remarks>
		public TList<FeeRefndStdDet> GetByFeeRefundCodeId(TransactionManager transactionManager, System.Decimal? _feeRefundCodeId)
		{
			int count = -1;
			return GetByFeeRefundCodeId(transactionManager, _feeRefundCodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_REFUND_STUD_REQ_DET_REFUND_CODE key.
		///		FK_REFUND_STUD_REQ_DET_REFUND_CODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefundCodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public TList<FeeRefndStdDet> GetByFeeRefundCodeId(TransactionManager transactionManager, System.Decimal? _feeRefundCodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeRefundCodeId(transactionManager, _feeRefundCodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_REFUND_STUD_REQ_DET_REFUND_CODE key.
		///		fkRefundStudReqDetRefundCode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeRefundCodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public TList<FeeRefndStdDet> GetByFeeRefundCodeId(System.Decimal? _feeRefundCodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeRefundCodeId(null, _feeRefundCodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_REFUND_STUD_REQ_DET_REFUND_CODE key.
		///		fkRefundStudReqDetRefundCode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeRefundCodeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public TList<FeeRefndStdDet> GetByFeeRefundCodeId(System.Decimal? _feeRefundCodeId, int start, int pageLength,out int count)
		{
			return GetByFeeRefundCodeId(null, _feeRefundCodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_REFUND_STUD_REQ_DET_REFUND_CODE key.
		///		FK_REFUND_STUD_REQ_DET_REFUND_CODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefundCodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public abstract TList<FeeRefndStdDet> GetByFeeRefundCodeId(TransactionManager transactionManager, System.Decimal? _feeRefundCodeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_REFUND_STUD_REQ_DET_REFUND_STUD_REQ_MASTER key.
		///		FK_REFUND_STUD_REQ_DET_REFUND_STUD_REQ_MASTER Description: 
		/// </summary>
		/// <param name="_feeRefndStdReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public TList<FeeRefndStdDet> GetByFeeRefndStdReqId(System.Decimal _feeRefndStdReqId)
		{
			int count = -1;
			return GetByFeeRefndStdReqId(_feeRefndStdReqId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_REFUND_STUD_REQ_DET_REFUND_STUD_REQ_MASTER key.
		///		FK_REFUND_STUD_REQ_DET_REFUND_STUD_REQ_MASTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefndStdReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		/// <remarks></remarks>
		public TList<FeeRefndStdDet> GetByFeeRefndStdReqId(TransactionManager transactionManager, System.Decimal _feeRefndStdReqId)
		{
			int count = -1;
			return GetByFeeRefndStdReqId(transactionManager, _feeRefndStdReqId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_REFUND_STUD_REQ_DET_REFUND_STUD_REQ_MASTER key.
		///		FK_REFUND_STUD_REQ_DET_REFUND_STUD_REQ_MASTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefndStdReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public TList<FeeRefndStdDet> GetByFeeRefndStdReqId(TransactionManager transactionManager, System.Decimal _feeRefndStdReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeRefndStdReqId(transactionManager, _feeRefndStdReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_REFUND_STUD_REQ_DET_REFUND_STUD_REQ_MASTER key.
		///		fkRefundStudReqDetRefundStudReqMaster Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeRefndStdReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public TList<FeeRefndStdDet> GetByFeeRefndStdReqId(System.Decimal _feeRefndStdReqId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeRefndStdReqId(null, _feeRefndStdReqId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_REFUND_STUD_REQ_DET_REFUND_STUD_REQ_MASTER key.
		///		fkRefundStudReqDetRefundStudReqMaster Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeRefndStdReqId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public TList<FeeRefndStdDet> GetByFeeRefndStdReqId(System.Decimal _feeRefndStdReqId, int start, int pageLength,out int count)
		{
			return GetByFeeRefndStdReqId(null, _feeRefndStdReqId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_REFUND_STUD_REQ_DET_REFUND_STUD_REQ_MASTER key.
		///		FK_REFUND_STUD_REQ_DET_REFUND_STUD_REQ_MASTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefndStdReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdDet objects.</returns>
		public abstract TList<FeeRefndStdDet> GetByFeeRefndStdReqId(TransactionManager transactionManager, System.Decimal _feeRefndStdReqId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeRefndStdDet Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeRefndStdDetKey key, int start, int pageLength)
		{
			return GetByFeeRefndStdDtlId(transactionManager, key.FeeRefndStdDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_FEE_REFND_STD_DET index.
		/// </summary>
		/// <param name="_feeRefndStdReqId"></param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdDet"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdDet GetByFeeRefndStdReqIdFeeStudFeeItemId(System.Decimal _feeRefndStdReqId, System.Decimal? _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeRefndStdReqIdFeeStudFeeItemId(null,_feeRefndStdReqId, _feeStudFeeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_REFND_STD_DET index.
		/// </summary>
		/// <param name="_feeRefndStdReqId"></param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdDet"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdDet GetByFeeRefndStdReqIdFeeStudFeeItemId(System.Decimal _feeRefndStdReqId, System.Decimal? _feeStudFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeRefndStdReqIdFeeStudFeeItemId(null, _feeRefndStdReqId, _feeStudFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_REFND_STD_DET index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefndStdReqId"></param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdDet"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdDet GetByFeeRefndStdReqIdFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal _feeRefndStdReqId, System.Decimal? _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeRefndStdReqIdFeeStudFeeItemId(transactionManager, _feeRefndStdReqId, _feeStudFeeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_REFND_STD_DET index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefndStdReqId"></param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdDet"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdDet GetByFeeRefndStdReqIdFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal _feeRefndStdReqId, System.Decimal? _feeStudFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeRefndStdReqIdFeeStudFeeItemId(transactionManager, _feeRefndStdReqId, _feeStudFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_REFND_STD_DET index.
		/// </summary>
		/// <param name="_feeRefndStdReqId"></param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdDet"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdDet GetByFeeRefndStdReqIdFeeStudFeeItemId(System.Decimal _feeRefndStdReqId, System.Decimal? _feeStudFeeItemId, int start, int pageLength, out int count)
		{
			return GetByFeeRefndStdReqIdFeeStudFeeItemId(null, _feeRefndStdReqId, _feeStudFeeItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_REFND_STD_DET index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefndStdReqId"></param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdDet"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeRefndStdDet GetByFeeRefndStdReqIdFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal _feeRefndStdReqId, System.Decimal? _feeStudFeeItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_REFUND_STUD_REQ_DET index.
		/// </summary>
		/// <param name="_feeRefndStdDtlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdDet"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdDet GetByFeeRefndStdDtlId(System.Decimal _feeRefndStdDtlId)
		{
			int count = -1;
			return GetByFeeRefndStdDtlId(null,_feeRefndStdDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_REFUND_STUD_REQ_DET index.
		/// </summary>
		/// <param name="_feeRefndStdDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdDet"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdDet GetByFeeRefndStdDtlId(System.Decimal _feeRefndStdDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeRefndStdDtlId(null, _feeRefndStdDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_REFUND_STUD_REQ_DET index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefndStdDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdDet"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdDet GetByFeeRefndStdDtlId(TransactionManager transactionManager, System.Decimal _feeRefndStdDtlId)
		{
			int count = -1;
			return GetByFeeRefndStdDtlId(transactionManager, _feeRefndStdDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_REFUND_STUD_REQ_DET index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefndStdDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdDet"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdDet GetByFeeRefndStdDtlId(TransactionManager transactionManager, System.Decimal _feeRefndStdDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeRefndStdDtlId(transactionManager, _feeRefndStdDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_REFUND_STUD_REQ_DET index.
		/// </summary>
		/// <param name="_feeRefndStdDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdDet"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdDet GetByFeeRefndStdDtlId(System.Decimal _feeRefndStdDtlId, int start, int pageLength, out int count)
		{
			return GetByFeeRefndStdDtlId(null, _feeRefndStdDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_REFUND_STUD_REQ_DET index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefndStdDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdDet"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeRefndStdDet GetByFeeRefndStdDtlId(TransactionManager transactionManager, System.Decimal _feeRefndStdDtlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeRefndStdDet&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeRefndStdDet&gt;"/></returns>
		public static TList<FeeRefndStdDet> Fill(IDataReader reader, TList<FeeRefndStdDet> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeRefndStdDet c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeRefndStdDet")
					.Append("|").Append((System.Decimal)reader["FEE_REFND_STD_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeRefndStdDet>(
					key.ToString(), // EntityTrackingKey
					"FeeRefndStdDet",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeRefndStdDet();
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
					c.FeeRefndStdDtlId = (System.Decimal)reader["FEE_REFND_STD_DTL_ID"];
					c.OriginalFeeRefndStdDtlId = c.FeeRefndStdDtlId;
					c.FeeRefndStdReqId = (System.Decimal)reader["FEE_REFND_STD_REQ_ID"];
					c.FeeRefundCodeId = Convert.IsDBNull(reader["FEE_REFUND_CODE_ID"]) ? null : (System.Decimal?)reader["FEE_REFUND_CODE_ID"];
					c.RfndValue = (System.Decimal)reader["RFND_VALUE"];
					c.FeeStudFeeItemId = Convert.IsDBNull(reader["FEE_STUD_FEE_ITEM_ID"]) ? null : (System.Decimal?)reader["FEE_STUD_FEE_ITEM_ID"];
					c.AdmAppFeesId = Convert.IsDBNull(reader["ADM_APP_FEES_ID"]) ? null : (System.Decimal?)reader["ADM_APP_FEES_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdDet"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdDet"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeRefndStdDet entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeRefndStdDtlId = (System.Decimal)reader[((int)FeeRefndStdDetColumn.FeeRefndStdDtlId - 1)];
			entity.OriginalFeeRefndStdDtlId = (System.Decimal)reader["FEE_REFND_STD_DTL_ID"];
			entity.FeeRefndStdReqId = (System.Decimal)reader[((int)FeeRefndStdDetColumn.FeeRefndStdReqId - 1)];
			entity.FeeRefundCodeId = (reader.IsDBNull(((int)FeeRefndStdDetColumn.FeeRefundCodeId - 1)))?null:(System.Decimal?)reader[((int)FeeRefndStdDetColumn.FeeRefundCodeId - 1)];
			entity.RfndValue = (System.Decimal)reader[((int)FeeRefndStdDetColumn.RfndValue - 1)];
			entity.FeeStudFeeItemId = (reader.IsDBNull(((int)FeeRefndStdDetColumn.FeeStudFeeItemId - 1)))?null:(System.Decimal?)reader[((int)FeeRefndStdDetColumn.FeeStudFeeItemId - 1)];
			entity.AdmAppFeesId = (reader.IsDBNull(((int)FeeRefndStdDetColumn.AdmAppFeesId - 1)))?null:(System.Decimal?)reader[((int)FeeRefndStdDetColumn.AdmAppFeesId - 1)];
			entity.Notes = (reader.IsDBNull(((int)FeeRefndStdDetColumn.Notes - 1)))?null:(System.String)reader[((int)FeeRefndStdDetColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeRefndStdDetColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeRefndStdDetColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeRefndStdDetColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeRefndStdDetColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdDet"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdDet"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeRefndStdDet entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeRefndStdDtlId = (System.Decimal)dataRow["FEE_REFND_STD_DTL_ID"];
			entity.OriginalFeeRefndStdDtlId = (System.Decimal)dataRow["FEE_REFND_STD_DTL_ID"];
			entity.FeeRefndStdReqId = (System.Decimal)dataRow["FEE_REFND_STD_REQ_ID"];
			entity.FeeRefundCodeId = Convert.IsDBNull(dataRow["FEE_REFUND_CODE_ID"]) ? null : (System.Decimal?)dataRow["FEE_REFUND_CODE_ID"];
			entity.RfndValue = (System.Decimal)dataRow["RFND_VALUE"];
			entity.FeeStudFeeItemId = Convert.IsDBNull(dataRow["FEE_STUD_FEE_ITEM_ID"]) ? null : (System.Decimal?)dataRow["FEE_STUD_FEE_ITEM_ID"];
			entity.AdmAppFeesId = Convert.IsDBNull(dataRow["ADM_APP_FEES_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_FEES_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdDet"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeRefndStdDet Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeRefndStdDet entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppFeesIdSource	
			if (CanDeepLoad(entity, "AdmAppFees|AdmAppFeesIdSource", deepLoadType, innerList) 
				&& entity.AdmAppFeesIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmAppFeesId ?? 0.0m);
				AdmAppFees tmpEntity = EntityManager.LocateEntity<AdmAppFees>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppFees), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppFeesIdSource = tmpEntity;
				else
					entity.AdmAppFeesIdSource = DataRepository.AdmAppFeesProvider.GetByAdmAppFeesId(transactionManager, (entity.AdmAppFeesId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppFeesIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppFeesIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppFeesProvider.DeepLoad(transactionManager, entity.AdmAppFeesIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppFeesIdSource

			#region FeeStudFeeItemIdSource	
			if (CanDeepLoad(entity, "FeeStudFeeItem|FeeStudFeeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeStudFeeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeStudFeeItemId ?? 0.0m);
				FeeStudFeeItem tmpEntity = EntityManager.LocateEntity<FeeStudFeeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudFeeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudFeeItemIdSource = tmpEntity;
				else
					entity.FeeStudFeeItemIdSource = DataRepository.FeeStudFeeItemProvider.GetByFeeStudFeeItemId(transactionManager, (entity.FeeStudFeeItemId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFeeItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudFeeItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudFeeItemProvider.DeepLoad(transactionManager, entity.FeeStudFeeItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudFeeItemIdSource

			#region FeeRefundCodeIdSource	
			if (CanDeepLoad(entity, "FeeRefundCode|FeeRefundCodeIdSource", deepLoadType, innerList) 
				&& entity.FeeRefundCodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeRefundCodeId ?? 0.0m);
				FeeRefundCode tmpEntity = EntityManager.LocateEntity<FeeRefundCode>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeRefundCode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeRefundCodeIdSource = tmpEntity;
				else
					entity.FeeRefundCodeIdSource = DataRepository.FeeRefundCodeProvider.GetByFeeRefundCodeId(transactionManager, (entity.FeeRefundCodeId ?? 0.0m));		
				
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

			#region FeeRefndStdReqIdSource	
			if (CanDeepLoad(entity, "FeeRefndStdReq|FeeRefndStdReqIdSource", deepLoadType, innerList) 
				&& entity.FeeRefndStdReqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeRefndStdReqId;
				FeeRefndStdReq tmpEntity = EntityManager.LocateEntity<FeeRefndStdReq>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeRefndStdReq), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeRefndStdReqIdSource = tmpEntity;
				else
					entity.FeeRefndStdReqIdSource = DataRepository.FeeRefndStdReqProvider.GetByFeeRefndStdReqId(transactionManager, entity.FeeRefndStdReqId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefndStdReqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeRefndStdReqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeRefndStdReqProvider.DeepLoad(transactionManager, entity.FeeRefndStdReqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeRefndStdReqIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeRefndStdDet object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeRefndStdDet instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeRefndStdDet Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeRefndStdDet entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAppFeesIdSource
			if (CanDeepSave(entity, "AdmAppFees|AdmAppFeesIdSource", deepSaveType, innerList) 
				&& entity.AdmAppFeesIdSource != null)
			{
				DataRepository.AdmAppFeesProvider.Save(transactionManager, entity.AdmAppFeesIdSource);
				entity.AdmAppFeesId = entity.AdmAppFeesIdSource.AdmAppFeesId;
			}
			#endregion 
			
			#region FeeStudFeeItemIdSource
			if (CanDeepSave(entity, "FeeStudFeeItem|FeeStudFeeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeStudFeeItemIdSource != null)
			{
				DataRepository.FeeStudFeeItemProvider.Save(transactionManager, entity.FeeStudFeeItemIdSource);
				entity.FeeStudFeeItemId = entity.FeeStudFeeItemIdSource.FeeStudFeeItemId;
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
			
			#region FeeRefndStdReqIdSource
			if (CanDeepSave(entity, "FeeRefndStdReq|FeeRefndStdReqIdSource", deepSaveType, innerList) 
				&& entity.FeeRefndStdReqIdSource != null)
			{
				DataRepository.FeeRefndStdReqProvider.Save(transactionManager, entity.FeeRefndStdReqIdSource);
				entity.FeeRefndStdReqId = entity.FeeRefndStdReqIdSource.FeeRefndStdReqId;
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
	
	#region FeeRefndStdDetChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeRefndStdDet</c>
	///</summary>
	public enum FeeRefndStdDetChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppFees</c> at AdmAppFeesIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppFees))]
		AdmAppFees,
		
		///<summary>
		/// Composite Property for <c>FeeStudFeeItem</c> at FeeStudFeeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudFeeItem))]
		FeeStudFeeItem,
		
		///<summary>
		/// Composite Property for <c>FeeRefundCode</c> at FeeRefundCodeIdSource
		///</summary>
		[ChildEntityType(typeof(FeeRefundCode))]
		FeeRefundCode,
		
		///<summary>
		/// Composite Property for <c>FeeRefndStdReq</c> at FeeRefndStdReqIdSource
		///</summary>
		[ChildEntityType(typeof(FeeRefndStdReq))]
		FeeRefndStdReq,
	}
	
	#endregion FeeRefndStdDetChildEntityTypes
	
	#region FeeRefndStdDetFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeRefndStdDetColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeRefndStdDet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeRefndStdDetFilterBuilder : SqlFilterBuilder<FeeRefndStdDetColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeRefndStdDetFilterBuilder class.
		/// </summary>
		public FeeRefndStdDetFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeRefndStdDetFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeRefndStdDetFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeRefndStdDetFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeRefndStdDetFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeRefndStdDetFilterBuilder
	
	#region FeeRefndStdDetParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeRefndStdDetColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeRefndStdDet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeRefndStdDetParameterBuilder : ParameterizedSqlFilterBuilder<FeeRefndStdDetColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeRefndStdDetParameterBuilder class.
		/// </summary>
		public FeeRefndStdDetParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeRefndStdDetParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeRefndStdDetParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeRefndStdDetParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeRefndStdDetParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeRefndStdDetParameterBuilder
	
	#region FeeRefndStdDetSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeRefndStdDetColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeRefndStdDet"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeRefndStdDetSortBuilder : SqlSortBuilder<FeeRefndStdDetColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeRefndStdDetSqlSortBuilder class.
		/// </summary>
		public FeeRefndStdDetSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeRefndStdDetSortBuilder
	
} // end namespace
