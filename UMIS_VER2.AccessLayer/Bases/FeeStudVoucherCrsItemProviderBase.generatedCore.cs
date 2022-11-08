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
	/// This class is the base class for any <see cref="FeeStudVoucherCrsItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudVoucherCrsItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem, UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItemKey key)
		{
			return Delete(transactionManager, key.FeeStudVoucherCrsItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeStudVoucherCrsItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeStudVoucherCrsItemId)
		{
			return Delete(null, _feeStudVoucherCrsItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherCrsItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeStudVoucherCrsItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_CRS_ITEM_ED_COURSE key.
		///		FK_FEE_STUD_VOUCHER_CRS_ITEM_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId">Modify :Register-add-delete-drop</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem objects.</returns>
		public TList<FeeStudVoucherCrsItem> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_CRS_ITEM_ED_COURSE key.
		///		FK_FEE_STUD_VOUCHER_CRS_ITEM_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">Modify :Register-add-delete-drop</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudVoucherCrsItem> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_CRS_ITEM_ED_COURSE key.
		///		FK_FEE_STUD_VOUCHER_CRS_ITEM_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">Modify :Register-add-delete-drop</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem objects.</returns>
		public TList<FeeStudVoucherCrsItem> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_CRS_ITEM_ED_COURSE key.
		///		fkFeeStudVoucherCrsItemEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">Modify :Register-add-delete-drop</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem objects.</returns>
		public TList<FeeStudVoucherCrsItem> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_CRS_ITEM_ED_COURSE key.
		///		fkFeeStudVoucherCrsItemEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">Modify :Register-add-delete-drop</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem objects.</returns>
		public TList<FeeStudVoucherCrsItem> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_CRS_ITEM_ED_COURSE key.
		///		FK_FEE_STUD_VOUCHER_CRS_ITEM_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">Modify :Register-add-delete-drop</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem objects.</returns>
		public abstract TList<FeeStudVoucherCrsItem> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_INVOICE_ITEM key.
		///		FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_INVOICE_ITEM Description: 
		/// </summary>
		/// <param name="_feeInvoiceItemId">بنود الفاتورة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem objects.</returns>
		public TList<FeeStudVoucherCrsItem> GetByFeeInvoiceItemId(System.Decimal? _feeInvoiceItemId)
		{
			int count = -1;
			return GetByFeeInvoiceItemId(_feeInvoiceItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_INVOICE_ITEM key.
		///		FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_INVOICE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceItemId">بنود الفاتورة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudVoucherCrsItem> GetByFeeInvoiceItemId(TransactionManager transactionManager, System.Decimal? _feeInvoiceItemId)
		{
			int count = -1;
			return GetByFeeInvoiceItemId(transactionManager, _feeInvoiceItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_INVOICE_ITEM key.
		///		FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_INVOICE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceItemId">بنود الفاتورة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem objects.</returns>
		public TList<FeeStudVoucherCrsItem> GetByFeeInvoiceItemId(TransactionManager transactionManager, System.Decimal? _feeInvoiceItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeInvoiceItemId(transactionManager, _feeInvoiceItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_INVOICE_ITEM key.
		///		fkFeeStudVoucherCrsItemFeeInvoiceItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeInvoiceItemId">بنود الفاتورة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem objects.</returns>
		public TList<FeeStudVoucherCrsItem> GetByFeeInvoiceItemId(System.Decimal? _feeInvoiceItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeInvoiceItemId(null, _feeInvoiceItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_INVOICE_ITEM key.
		///		fkFeeStudVoucherCrsItemFeeInvoiceItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeInvoiceItemId">بنود الفاتورة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem objects.</returns>
		public TList<FeeStudVoucherCrsItem> GetByFeeInvoiceItemId(System.Decimal? _feeInvoiceItemId, int start, int pageLength,out int count)
		{
			return GetByFeeInvoiceItemId(null, _feeInvoiceItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_INVOICE_ITEM key.
		///		FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_INVOICE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceItemId">بنود الفاتورة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem objects.</returns>
		public abstract TList<FeeStudVoucherCrsItem> GetByFeeInvoiceItemId(TransactionManager transactionManager, System.Decimal? _feeInvoiceItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_STUD_VOUCHER_ITEM key.
		///		FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_STUD_VOUCHER_ITEM Description: 
		/// </summary>
		/// <param name="_feeStudVoucherItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem objects.</returns>
		public TList<FeeStudVoucherCrsItem> GetByFeeStudVoucherItemId(System.Decimal? _feeStudVoucherItemId)
		{
			int count = -1;
			return GetByFeeStudVoucherItemId(_feeStudVoucherItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_STUD_VOUCHER_ITEM key.
		///		FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_STUD_VOUCHER_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudVoucherCrsItem> GetByFeeStudVoucherItemId(TransactionManager transactionManager, System.Decimal? _feeStudVoucherItemId)
		{
			int count = -1;
			return GetByFeeStudVoucherItemId(transactionManager, _feeStudVoucherItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_STUD_VOUCHER_ITEM key.
		///		FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_STUD_VOUCHER_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem objects.</returns>
		public TList<FeeStudVoucherCrsItem> GetByFeeStudVoucherItemId(TransactionManager transactionManager, System.Decimal? _feeStudVoucherItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherItemId(transactionManager, _feeStudVoucherItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_STUD_VOUCHER_ITEM key.
		///		fkFeeStudVoucherCrsItemFeeStudVoucherItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudVoucherItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem objects.</returns>
		public TList<FeeStudVoucherCrsItem> GetByFeeStudVoucherItemId(System.Decimal? _feeStudVoucherItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudVoucherItemId(null, _feeStudVoucherItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_STUD_VOUCHER_ITEM key.
		///		fkFeeStudVoucherCrsItemFeeStudVoucherItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudVoucherItemId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem objects.</returns>
		public TList<FeeStudVoucherCrsItem> GetByFeeStudVoucherItemId(System.Decimal? _feeStudVoucherItemId, int start, int pageLength,out int count)
		{
			return GetByFeeStudVoucherItemId(null, _feeStudVoucherItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_STUD_VOUCHER_ITEM key.
		///		FK_FEE_STUD_VOUCHER_CRS_ITEM_FEE_STUD_VOUCHER_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem objects.</returns>
		public abstract TList<FeeStudVoucherCrsItem> GetByFeeStudVoucherItemId(TransactionManager transactionManager, System.Decimal? _feeStudVoucherItemId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItemKey key, int start, int pageLength)
		{
			return GetByFeeStudVoucherCrsItemId(transactionManager, key.FeeStudVoucherCrsItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_STUD_VOUCHER_CRS_ITEM index.
		/// </summary>
		/// <param name="_feeStudVoucherCrsItemId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem GetByFeeStudVoucherCrsItemId(System.Decimal _feeStudVoucherCrsItemId)
		{
			int count = -1;
			return GetByFeeStudVoucherCrsItemId(null,_feeStudVoucherCrsItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER_CRS_ITEM index.
		/// </summary>
		/// <param name="_feeStudVoucherCrsItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem GetByFeeStudVoucherCrsItemId(System.Decimal _feeStudVoucherCrsItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherCrsItemId(null, _feeStudVoucherCrsItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER_CRS_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherCrsItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem GetByFeeStudVoucherCrsItemId(TransactionManager transactionManager, System.Decimal _feeStudVoucherCrsItemId)
		{
			int count = -1;
			return GetByFeeStudVoucherCrsItemId(transactionManager, _feeStudVoucherCrsItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER_CRS_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherCrsItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem GetByFeeStudVoucherCrsItemId(TransactionManager transactionManager, System.Decimal _feeStudVoucherCrsItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherCrsItemId(transactionManager, _feeStudVoucherCrsItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER_CRS_ITEM index.
		/// </summary>
		/// <param name="_feeStudVoucherCrsItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem GetByFeeStudVoucherCrsItemId(System.Decimal _feeStudVoucherCrsItemId, int start, int pageLength, out int count)
		{
			return GetByFeeStudVoucherCrsItemId(null, _feeStudVoucherCrsItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER_CRS_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherCrsItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem GetByFeeStudVoucherCrsItemId(TransactionManager transactionManager, System.Decimal _feeStudVoucherCrsItemId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeStudVoucherCrsItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeStudVoucherCrsItem&gt;"/></returns>
		public static TList<FeeStudVoucherCrsItem> Fill(IDataReader reader, TList<FeeStudVoucherCrsItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeStudVoucherCrsItem")
					.Append("|").Append((System.Decimal)reader["FEE_STUD_VOUCHER_CRS_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeStudVoucherCrsItem>(
					key.ToString(), // EntityTrackingKey
					"FeeStudVoucherCrsItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem();
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
					c.FeeStudVoucherCrsItemId = (System.Decimal)reader["FEE_STUD_VOUCHER_CRS_ITEM_ID"];
					c.OriginalFeeStudVoucherCrsItemId = c.FeeStudVoucherCrsItemId;
					c.FeeStudVoucherItemId = Convert.IsDBNull(reader["FEE_STUD_VOUCHER_ITEM_ID"]) ? null : (System.Decimal?)reader["FEE_STUD_VOUCHER_ITEM_ID"];
					c.FeeInvoiceItemId = Convert.IsDBNull(reader["FEE_INVOICE_ITEM_ID"]) ? null : (System.Decimal?)reader["FEE_INVOICE_ITEM_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.CrsPayAmnt = (System.Decimal)reader["CRS_PAY_AMNT"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeStudVoucherCrsItemId = (System.Decimal)reader[((int)FeeStudVoucherCrsItemColumn.FeeStudVoucherCrsItemId - 1)];
			entity.OriginalFeeStudVoucherCrsItemId = (System.Decimal)reader["FEE_STUD_VOUCHER_CRS_ITEM_ID"];
			entity.FeeStudVoucherItemId = (reader.IsDBNull(((int)FeeStudVoucherCrsItemColumn.FeeStudVoucherItemId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherCrsItemColumn.FeeStudVoucherItemId - 1)];
			entity.FeeInvoiceItemId = (reader.IsDBNull(((int)FeeStudVoucherCrsItemColumn.FeeInvoiceItemId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherCrsItemColumn.FeeInvoiceItemId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)FeeStudVoucherCrsItemColumn.EdCourseId - 1)];
			entity.CrsPayAmnt = (System.Decimal)reader[((int)FeeStudVoucherCrsItemColumn.CrsPayAmnt - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeStudVoucherCrsItemColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherCrsItemColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeStudVoucherCrsItemColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudVoucherCrsItemColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeStudVoucherCrsItemId = (System.Decimal)dataRow["FEE_STUD_VOUCHER_CRS_ITEM_ID"];
			entity.OriginalFeeStudVoucherCrsItemId = (System.Decimal)dataRow["FEE_STUD_VOUCHER_CRS_ITEM_ID"];
			entity.FeeStudVoucherItemId = Convert.IsDBNull(dataRow["FEE_STUD_VOUCHER_ITEM_ID"]) ? null : (System.Decimal?)dataRow["FEE_STUD_VOUCHER_ITEM_ID"];
			entity.FeeInvoiceItemId = Convert.IsDBNull(dataRow["FEE_INVOICE_ITEM_ID"]) ? null : (System.Decimal?)dataRow["FEE_INVOICE_ITEM_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.CrsPayAmnt = (System.Decimal)dataRow["CRS_PAY_AMNT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseIdSource

			#region FeeInvoiceItemIdSource	
			if (CanDeepLoad(entity, "FeeInvoiceItem|FeeInvoiceItemIdSource", deepLoadType, innerList) 
				&& entity.FeeInvoiceItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeInvoiceItemId ?? 0.0m);
				FeeInvoiceItem tmpEntity = EntityManager.LocateEntity<FeeInvoiceItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeInvoiceItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeInvoiceItemIdSource = tmpEntity;
				else
					entity.FeeInvoiceItemIdSource = DataRepository.FeeInvoiceItemProvider.GetByFeeInvoiceItemId(transactionManager, (entity.FeeInvoiceItemId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeInvoiceItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeInvoiceItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeInvoiceItemProvider.DeepLoad(transactionManager, entity.FeeInvoiceItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeInvoiceItemIdSource

			#region FeeStudVoucherItemIdSource	
			if (CanDeepLoad(entity, "FeeStudVoucherItem|FeeStudVoucherItemIdSource", deepLoadType, innerList) 
				&& entity.FeeStudVoucherItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeStudVoucherItemId ?? 0.0m);
				FeeStudVoucherItem tmpEntity = EntityManager.LocateEntity<FeeStudVoucherItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudVoucherItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudVoucherItemIdSource = tmpEntity;
				else
					entity.FeeStudVoucherItemIdSource = DataRepository.FeeStudVoucherItemProvider.GetByFeeStudVoucherItemId(transactionManager, (entity.FeeStudVoucherItemId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudVoucherItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudVoucherItemProvider.DeepLoad(transactionManager, entity.FeeStudVoucherItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudVoucherItemIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region FeeInvoiceItemIdSource
			if (CanDeepSave(entity, "FeeInvoiceItem|FeeInvoiceItemIdSource", deepSaveType, innerList) 
				&& entity.FeeInvoiceItemIdSource != null)
			{
				DataRepository.FeeInvoiceItemProvider.Save(transactionManager, entity.FeeInvoiceItemIdSource);
				entity.FeeInvoiceItemId = entity.FeeInvoiceItemIdSource.FeeInvoiceItemId;
			}
			#endregion 
			
			#region FeeStudVoucherItemIdSource
			if (CanDeepSave(entity, "FeeStudVoucherItem|FeeStudVoucherItemIdSource", deepSaveType, innerList) 
				&& entity.FeeStudVoucherItemIdSource != null)
			{
				DataRepository.FeeStudVoucherItemProvider.Save(transactionManager, entity.FeeStudVoucherItemIdSource);
				entity.FeeStudVoucherItemId = entity.FeeStudVoucherItemIdSource.FeeStudVoucherItemId;
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
	
	#region FeeStudVoucherCrsItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeStudVoucherCrsItem</c>
	///</summary>
	public enum FeeStudVoucherCrsItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>FeeInvoiceItem</c> at FeeInvoiceItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeInvoiceItem))]
		FeeInvoiceItem,
		
		///<summary>
		/// Composite Property for <c>FeeStudVoucherItem</c> at FeeStudVoucherItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudVoucherItem))]
		FeeStudVoucherItem,
	}
	
	#endregion FeeStudVoucherCrsItemChildEntityTypes
	
	#region FeeStudVoucherCrsItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeStudVoucherCrsItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudVoucherCrsItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudVoucherCrsItemFilterBuilder : SqlFilterBuilder<FeeStudVoucherCrsItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherCrsItemFilterBuilder class.
		/// </summary>
		public FeeStudVoucherCrsItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherCrsItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudVoucherCrsItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherCrsItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudVoucherCrsItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudVoucherCrsItemFilterBuilder
	
	#region FeeStudVoucherCrsItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeStudVoucherCrsItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudVoucherCrsItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudVoucherCrsItemParameterBuilder : ParameterizedSqlFilterBuilder<FeeStudVoucherCrsItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherCrsItemParameterBuilder class.
		/// </summary>
		public FeeStudVoucherCrsItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherCrsItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudVoucherCrsItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherCrsItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudVoucherCrsItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudVoucherCrsItemParameterBuilder
	
	#region FeeStudVoucherCrsItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeStudVoucherCrsItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudVoucherCrsItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeStudVoucherCrsItemSortBuilder : SqlSortBuilder<FeeStudVoucherCrsItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherCrsItemSqlSortBuilder class.
		/// </summary>
		public FeeStudVoucherCrsItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeStudVoucherCrsItemSortBuilder
	
} // end namespace
