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
	/// This class is the base class for any <see cref="FeeStudDiscFeeItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudDiscFeeItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem, UMIS_VER2.BusinessLyer.FeeStudDiscFeeItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDiscFeeItemKey key)
		{
			return Delete(transactionManager, key.FeeStudDiscFeeItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeStudDiscFeeItemId">التخفيضات على بنود محملة على الطالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeStudDiscFeeItemId)
		{
			return Delete(null, _feeStudDiscFeeItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscFeeItemId">التخفيضات على بنود محملة على الطالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeStudDiscFeeItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_FEE_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_STUD_DISC_FEE_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="_feeCodeItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem objects.</returns>
		public TList<FeeStudDiscFeeItem> GetByFeeCodeItemId(System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(_feeCodeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_FEE_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_STUD_DISC_FEE_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudDiscFeeItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_FEE_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_STUD_DISC_FEE_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem objects.</returns>
		public TList<FeeStudDiscFeeItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_FEE_ITEM_FEE_CODE_ITEM key.
		///		fkFeeStudDiscFeeItemFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem objects.</returns>
		public TList<FeeStudDiscFeeItem> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_FEE_ITEM_FEE_CODE_ITEM key.
		///		fkFeeStudDiscFeeItemFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem objects.</returns>
		public TList<FeeStudDiscFeeItem> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_FEE_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_STUD_DISC_FEE_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem objects.</returns>
		public abstract TList<FeeStudDiscFeeItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_DISC key.
		///		FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="_feeStudDiscId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem objects.</returns>
		public TList<FeeStudDiscFeeItem> GetByFeeStudDiscId(System.Decimal _feeStudDiscId)
		{
			int count = -1;
			return GetByFeeStudDiscId(_feeStudDiscId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_DISC key.
		///		FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudDiscFeeItem> GetByFeeStudDiscId(TransactionManager transactionManager, System.Decimal _feeStudDiscId)
		{
			int count = -1;
			return GetByFeeStudDiscId(transactionManager, _feeStudDiscId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_DISC key.
		///		FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem objects.</returns>
		public TList<FeeStudDiscFeeItem> GetByFeeStudDiscId(TransactionManager transactionManager, System.Decimal _feeStudDiscId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudDiscId(transactionManager, _feeStudDiscId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_DISC key.
		///		fkFeeStudDiscFeeItemFeeStudDisc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudDiscId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem objects.</returns>
		public TList<FeeStudDiscFeeItem> GetByFeeStudDiscId(System.Decimal _feeStudDiscId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudDiscId(null, _feeStudDiscId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_DISC key.
		///		fkFeeStudDiscFeeItemFeeStudDisc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudDiscId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem objects.</returns>
		public TList<FeeStudDiscFeeItem> GetByFeeStudDiscId(System.Decimal _feeStudDiscId, int start, int pageLength,out int count)
		{
			return GetByFeeStudDiscId(null, _feeStudDiscId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_DISC key.
		///		FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem objects.</returns>
		public abstract TList<FeeStudDiscFeeItem> GetByFeeStudDiscId(TransactionManager transactionManager, System.Decimal _feeStudDiscId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem objects.</returns>
		public TList<FeeStudDiscFeeItem> GetByFeeStudFeeItemId(System.Decimal _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(_feeStudFeeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudDiscFeeItem> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem objects.</returns>
		public TList<FeeStudDiscFeeItem> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal _feeStudFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_FEE_ITEM key.
		///		fkFeeStudDiscFeeItemFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem objects.</returns>
		public TList<FeeStudDiscFeeItem> GetByFeeStudFeeItemId(System.Decimal _feeStudFeeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_FEE_ITEM key.
		///		fkFeeStudDiscFeeItemFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem objects.</returns>
		public TList<FeeStudDiscFeeItem> GetByFeeStudFeeItemId(System.Decimal _feeStudFeeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_STUD_DISC_FEE_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem objects.</returns>
		public abstract TList<FeeStudDiscFeeItem> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal _feeStudFeeItemId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDiscFeeItemKey key, int start, int pageLength)
		{
			return GetByFeeStudDiscFeeItemId(transactionManager, key.FeeStudDiscFeeItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_STUD_DISC_FEE_ITEM index.
		/// </summary>
		/// <param name="_feeStudDiscFeeItemId">التخفيضات على بنود محملة على الطالب</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem GetByFeeStudDiscFeeItemId(System.Decimal _feeStudDiscFeeItemId)
		{
			int count = -1;
			return GetByFeeStudDiscFeeItemId(null,_feeStudDiscFeeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_FEE_ITEM index.
		/// </summary>
		/// <param name="_feeStudDiscFeeItemId">التخفيضات على بنود محملة على الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem GetByFeeStudDiscFeeItemId(System.Decimal _feeStudDiscFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudDiscFeeItemId(null, _feeStudDiscFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_FEE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscFeeItemId">التخفيضات على بنود محملة على الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem GetByFeeStudDiscFeeItemId(TransactionManager transactionManager, System.Decimal _feeStudDiscFeeItemId)
		{
			int count = -1;
			return GetByFeeStudDiscFeeItemId(transactionManager, _feeStudDiscFeeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_FEE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscFeeItemId">التخفيضات على بنود محملة على الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem GetByFeeStudDiscFeeItemId(TransactionManager transactionManager, System.Decimal _feeStudDiscFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudDiscFeeItemId(transactionManager, _feeStudDiscFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_FEE_ITEM index.
		/// </summary>
		/// <param name="_feeStudDiscFeeItemId">التخفيضات على بنود محملة على الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem GetByFeeStudDiscFeeItemId(System.Decimal _feeStudDiscFeeItemId, int start, int pageLength, out int count)
		{
			return GetByFeeStudDiscFeeItemId(null, _feeStudDiscFeeItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_FEE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscFeeItemId">التخفيضات على بنود محملة على الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem GetByFeeStudDiscFeeItemId(TransactionManager transactionManager, System.Decimal _feeStudDiscFeeItemId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeStudDiscFeeItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeStudDiscFeeItem&gt;"/></returns>
		public static TList<FeeStudDiscFeeItem> Fill(IDataReader reader, TList<FeeStudDiscFeeItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeStudDiscFeeItem")
					.Append("|").Append((System.Decimal)reader["FEE_STUD_DISC_FEE_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeStudDiscFeeItem>(
					key.ToString(), // EntityTrackingKey
					"FeeStudDiscFeeItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem();
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
					c.FeeStudDiscFeeItemId = (System.Decimal)reader["FEE_STUD_DISC_FEE_ITEM_ID"];
					c.OriginalFeeStudDiscFeeItemId = c.FeeStudDiscFeeItemId;
					c.FeeStudDiscId = (System.Decimal)reader["FEE_STUD_DISC_ID"];
					c.FeeStudFeeItemId = (System.Decimal)reader["FEE_STUD_FEE_ITEM_ID"];
					c.FeeCodeItemId = (System.Decimal)reader["FEE_CODE_ITEM_ID"];
					c.DiscAmnt = Convert.IsDBNull(reader["DISC_AMNT"]) ? null : (System.Decimal?)reader["DISC_AMNT"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.BalanceValue = Convert.IsDBNull(reader["BALANCE_VALUE"]) ? null : (System.Decimal?)reader["BALANCE_VALUE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeStudDiscFeeItemId = (System.Decimal)reader[((int)FeeStudDiscFeeItemColumn.FeeStudDiscFeeItemId - 1)];
			entity.OriginalFeeStudDiscFeeItemId = (System.Decimal)reader["FEE_STUD_DISC_FEE_ITEM_ID"];
			entity.FeeStudDiscId = (System.Decimal)reader[((int)FeeStudDiscFeeItemColumn.FeeStudDiscId - 1)];
			entity.FeeStudFeeItemId = (System.Decimal)reader[((int)FeeStudDiscFeeItemColumn.FeeStudFeeItemId - 1)];
			entity.FeeCodeItemId = (System.Decimal)reader[((int)FeeStudDiscFeeItemColumn.FeeCodeItemId - 1)];
			entity.DiscAmnt = (reader.IsDBNull(((int)FeeStudDiscFeeItemColumn.DiscAmnt - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscFeeItemColumn.DiscAmnt - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeStudDiscFeeItemColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscFeeItemColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeStudDiscFeeItemColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudDiscFeeItemColumn.LastDate - 1)];
			entity.BalanceValue = (reader.IsDBNull(((int)FeeStudDiscFeeItemColumn.BalanceValue - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscFeeItemColumn.BalanceValue - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeStudDiscFeeItemId = (System.Decimal)dataRow["FEE_STUD_DISC_FEE_ITEM_ID"];
			entity.OriginalFeeStudDiscFeeItemId = (System.Decimal)dataRow["FEE_STUD_DISC_FEE_ITEM_ID"];
			entity.FeeStudDiscId = (System.Decimal)dataRow["FEE_STUD_DISC_ID"];
			entity.FeeStudFeeItemId = (System.Decimal)dataRow["FEE_STUD_FEE_ITEM_ID"];
			entity.FeeCodeItemId = (System.Decimal)dataRow["FEE_CODE_ITEM_ID"];
			entity.DiscAmnt = Convert.IsDBNull(dataRow["DISC_AMNT"]) ? null : (System.Decimal?)dataRow["DISC_AMNT"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.BalanceValue = Convert.IsDBNull(dataRow["BALANCE_VALUE"]) ? null : (System.Decimal?)dataRow["BALANCE_VALUE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region FeeStudDiscIdSource	
			if (CanDeepLoad(entity, "FeeStudDisc|FeeStudDiscIdSource", deepLoadType, innerList) 
				&& entity.FeeStudDiscIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeStudDiscId;
				FeeStudDisc tmpEntity = EntityManager.LocateEntity<FeeStudDisc>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudDisc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudDiscIdSource = tmpEntity;
				else
					entity.FeeStudDiscIdSource = DataRepository.FeeStudDiscProvider.GetByFeeStudDiscId(transactionManager, entity.FeeStudDiscId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudDiscIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudDiscIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudDiscProvider.DeepLoad(transactionManager, entity.FeeStudDiscIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudDiscIdSource

			#region FeeStudFeeItemIdSource	
			if (CanDeepLoad(entity, "FeeStudFeeItem|FeeStudFeeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeStudFeeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeStudFeeItemId;
				FeeStudFeeItem tmpEntity = EntityManager.LocateEntity<FeeStudFeeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudFeeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudFeeItemIdSource = tmpEntity;
				else
					entity.FeeStudFeeItemIdSource = DataRepository.FeeStudFeeItemProvider.GetByFeeStudFeeItemId(transactionManager, entity.FeeStudFeeItemId);		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region FeeCodeItemIdSource
			if (CanDeepSave(entity, "FeeCodeItem|FeeCodeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeItemIdSource != null)
			{
				DataRepository.FeeCodeItemProvider.Save(transactionManager, entity.FeeCodeItemIdSource);
				entity.FeeCodeItemId = entity.FeeCodeItemIdSource.FeeCodeItemId;
			}
			#endregion 
			
			#region FeeStudDiscIdSource
			if (CanDeepSave(entity, "FeeStudDisc|FeeStudDiscIdSource", deepSaveType, innerList) 
				&& entity.FeeStudDiscIdSource != null)
			{
				DataRepository.FeeStudDiscProvider.Save(transactionManager, entity.FeeStudDiscIdSource);
				entity.FeeStudDiscId = entity.FeeStudDiscIdSource.FeeStudDiscId;
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
	
	#region FeeStudDiscFeeItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeStudDiscFeeItem</c>
	///</summary>
	public enum FeeStudDiscFeeItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>FeeCodeItem</c> at FeeCodeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeItem))]
		FeeCodeItem,
		
		///<summary>
		/// Composite Property for <c>FeeStudDisc</c> at FeeStudDiscIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudDisc))]
		FeeStudDisc,
		
		///<summary>
		/// Composite Property for <c>FeeStudFeeItem</c> at FeeStudFeeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudFeeItem))]
		FeeStudFeeItem,
	}
	
	#endregion FeeStudDiscFeeItemChildEntityTypes
	
	#region FeeStudDiscFeeItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeStudDiscFeeItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudDiscFeeItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudDiscFeeItemFilterBuilder : SqlFilterBuilder<FeeStudDiscFeeItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscFeeItemFilterBuilder class.
		/// </summary>
		public FeeStudDiscFeeItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscFeeItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudDiscFeeItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscFeeItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudDiscFeeItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudDiscFeeItemFilterBuilder
	
	#region FeeStudDiscFeeItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeStudDiscFeeItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudDiscFeeItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudDiscFeeItemParameterBuilder : ParameterizedSqlFilterBuilder<FeeStudDiscFeeItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscFeeItemParameterBuilder class.
		/// </summary>
		public FeeStudDiscFeeItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscFeeItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudDiscFeeItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscFeeItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudDiscFeeItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudDiscFeeItemParameterBuilder
	
	#region FeeStudDiscFeeItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeStudDiscFeeItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudDiscFeeItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeStudDiscFeeItemSortBuilder : SqlSortBuilder<FeeStudDiscFeeItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscFeeItemSqlSortBuilder class.
		/// </summary>
		public FeeStudDiscFeeItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeStudDiscFeeItemSortBuilder
	
} // end namespace
