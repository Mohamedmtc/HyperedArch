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
	/// This class is the base class for any <see cref="FeeItemPaymentWaysProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeItemPaymentWaysProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeItemPaymentWays, UMIS_VER2.BusinessLyer.FeeItemPaymentWaysKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeItemPaymentWaysKey key)
		{
			return Delete(transactionManager, key.FeeItemPaymentWayId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeItemPaymentWayId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeItemPaymentWayId)
		{
			return Delete(null, _feeItemPaymentWayId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeItemPaymentWayId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeItemPaymentWayId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Fee_Item_Payment_Ways_FEE_CDE_BANK_ACCNT key.
		///		FK_Fee_Item_Payment_Ways_FEE_CDE_BANK_ACCNT Description: 
		/// </summary>
		/// <param name="_feeCdeBankAccntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemPaymentWays objects.</returns>
		public TList<FeeItemPaymentWays> GetByFeeCdeBankAccntId(System.Decimal _feeCdeBankAccntId)
		{
			int count = -1;
			return GetByFeeCdeBankAccntId(_feeCdeBankAccntId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Fee_Item_Payment_Ways_FEE_CDE_BANK_ACCNT key.
		///		FK_Fee_Item_Payment_Ways_FEE_CDE_BANK_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeBankAccntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemPaymentWays objects.</returns>
		/// <remarks></remarks>
		public TList<FeeItemPaymentWays> GetByFeeCdeBankAccntId(TransactionManager transactionManager, System.Decimal _feeCdeBankAccntId)
		{
			int count = -1;
			return GetByFeeCdeBankAccntId(transactionManager, _feeCdeBankAccntId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_Fee_Item_Payment_Ways_FEE_CDE_BANK_ACCNT key.
		///		FK_Fee_Item_Payment_Ways_FEE_CDE_BANK_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeBankAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemPaymentWays objects.</returns>
		public TList<FeeItemPaymentWays> GetByFeeCdeBankAccntId(TransactionManager transactionManager, System.Decimal _feeCdeBankAccntId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeBankAccntId(transactionManager, _feeCdeBankAccntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Fee_Item_Payment_Ways_FEE_CDE_BANK_ACCNT key.
		///		fkFeeItemPaymentWaysFeeCdeBankAccnt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeBankAccntId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemPaymentWays objects.</returns>
		public TList<FeeItemPaymentWays> GetByFeeCdeBankAccntId(System.Decimal _feeCdeBankAccntId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCdeBankAccntId(null, _feeCdeBankAccntId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Fee_Item_Payment_Ways_FEE_CDE_BANK_ACCNT key.
		///		fkFeeItemPaymentWaysFeeCdeBankAccnt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeBankAccntId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemPaymentWays objects.</returns>
		public TList<FeeItemPaymentWays> GetByFeeCdeBankAccntId(System.Decimal _feeCdeBankAccntId, int start, int pageLength,out int count)
		{
			return GetByFeeCdeBankAccntId(null, _feeCdeBankAccntId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Fee_Item_Payment_Ways_FEE_CDE_BANK_ACCNT key.
		///		FK_Fee_Item_Payment_Ways_FEE_CDE_BANK_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeBankAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemPaymentWays objects.</returns>
		public abstract TList<FeeItemPaymentWays> GetByFeeCdeBankAccntId(TransactionManager transactionManager, System.Decimal _feeCdeBankAccntId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Fee_Item_Payment_Ways_FEE_FACULTY_ITEM key.
		///		FK_Fee_Item_Payment_Ways_FEE_FACULTY_ITEM Description: 
		/// </summary>
		/// <param name="_feeFacultyItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemPaymentWays objects.</returns>
		public TList<FeeItemPaymentWays> GetByFeeFacultyItemId(System.Decimal _feeFacultyItemId)
		{
			int count = -1;
			return GetByFeeFacultyItemId(_feeFacultyItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Fee_Item_Payment_Ways_FEE_FACULTY_ITEM key.
		///		FK_Fee_Item_Payment_Ways_FEE_FACULTY_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemPaymentWays objects.</returns>
		/// <remarks></remarks>
		public TList<FeeItemPaymentWays> GetByFeeFacultyItemId(TransactionManager transactionManager, System.Decimal _feeFacultyItemId)
		{
			int count = -1;
			return GetByFeeFacultyItemId(transactionManager, _feeFacultyItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_Fee_Item_Payment_Ways_FEE_FACULTY_ITEM key.
		///		FK_Fee_Item_Payment_Ways_FEE_FACULTY_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemPaymentWays objects.</returns>
		public TList<FeeItemPaymentWays> GetByFeeFacultyItemId(TransactionManager transactionManager, System.Decimal _feeFacultyItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFacultyItemId(transactionManager, _feeFacultyItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Fee_Item_Payment_Ways_FEE_FACULTY_ITEM key.
		///		fkFeeItemPaymentWaysFeeFacultyItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeFacultyItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemPaymentWays objects.</returns>
		public TList<FeeItemPaymentWays> GetByFeeFacultyItemId(System.Decimal _feeFacultyItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeFacultyItemId(null, _feeFacultyItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Fee_Item_Payment_Ways_FEE_FACULTY_ITEM key.
		///		fkFeeItemPaymentWaysFeeFacultyItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemPaymentWays objects.</returns>
		public TList<FeeItemPaymentWays> GetByFeeFacultyItemId(System.Decimal _feeFacultyItemId, int start, int pageLength,out int count)
		{
			return GetByFeeFacultyItemId(null, _feeFacultyItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Fee_Item_Payment_Ways_FEE_FACULTY_ITEM key.
		///		FK_Fee_Item_Payment_Ways_FEE_FACULTY_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemPaymentWays objects.</returns>
		public abstract TList<FeeItemPaymentWays> GetByFeeFacultyItemId(TransactionManager transactionManager, System.Decimal _feeFacultyItemId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeItemPaymentWays Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeItemPaymentWaysKey key, int start, int pageLength)
		{
			return GetByFeeItemPaymentWayId(transactionManager, key.FeeItemPaymentWayId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_Fee_Item_Payment_Ways index.
		/// </summary>
		/// <param name="_feeItemPaymentWayId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeItemPaymentWays"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeItemPaymentWays GetByFeeItemPaymentWayId(System.Decimal _feeItemPaymentWayId)
		{
			int count = -1;
			return GetByFeeItemPaymentWayId(null,_feeItemPaymentWayId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Fee_Item_Payment_Ways index.
		/// </summary>
		/// <param name="_feeItemPaymentWayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeItemPaymentWays"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeItemPaymentWays GetByFeeItemPaymentWayId(System.Decimal _feeItemPaymentWayId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeItemPaymentWayId(null, _feeItemPaymentWayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Fee_Item_Payment_Ways index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeItemPaymentWayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeItemPaymentWays"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeItemPaymentWays GetByFeeItemPaymentWayId(TransactionManager transactionManager, System.Decimal _feeItemPaymentWayId)
		{
			int count = -1;
			return GetByFeeItemPaymentWayId(transactionManager, _feeItemPaymentWayId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Fee_Item_Payment_Ways index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeItemPaymentWayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeItemPaymentWays"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeItemPaymentWays GetByFeeItemPaymentWayId(TransactionManager transactionManager, System.Decimal _feeItemPaymentWayId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeItemPaymentWayId(transactionManager, _feeItemPaymentWayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Fee_Item_Payment_Ways index.
		/// </summary>
		/// <param name="_feeItemPaymentWayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeItemPaymentWays"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeItemPaymentWays GetByFeeItemPaymentWayId(System.Decimal _feeItemPaymentWayId, int start, int pageLength, out int count)
		{
			return GetByFeeItemPaymentWayId(null, _feeItemPaymentWayId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Fee_Item_Payment_Ways index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeItemPaymentWayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeItemPaymentWays"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeItemPaymentWays GetByFeeItemPaymentWayId(TransactionManager transactionManager, System.Decimal _feeItemPaymentWayId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeItemPaymentWays&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeItemPaymentWays&gt;"/></returns>
		public static TList<FeeItemPaymentWays> Fill(IDataReader reader, TList<FeeItemPaymentWays> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeItemPaymentWays c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeItemPaymentWays")
					.Append("|").Append((System.Decimal)reader["Fee_Item_Payment_Way_Id"]).ToString();
					c = EntityManager.LocateOrCreate<FeeItemPaymentWays>(
					key.ToString(), // EntityTrackingKey
					"FeeItemPaymentWays",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeItemPaymentWays();
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
					c.FeeItemPaymentWayId = (System.Decimal)reader["Fee_Item_Payment_Way_Id"];
					c.OriginalFeeItemPaymentWayId = c.FeeItemPaymentWayId;
					c.FeeFacultyItemId = (System.Decimal)reader["FEE_FACULTY_ITEM_ID"];
					c.FeeCdeBankAccntId = (System.Decimal)reader["FEE_CDE_BANK_ACCNT_ID"];
					c.IsPercentage = Convert.IsDBNull(reader["Is_Percentage"]) ? null : (System.Boolean?)reader["Is_Percentage"];
					c.ItemValue = Convert.IsDBNull(reader["Item_Value"]) ? null : (System.Decimal?)reader["Item_Value"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeItemPaymentWays"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeItemPaymentWays"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeItemPaymentWays entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeItemPaymentWayId = (System.Decimal)reader[((int)FeeItemPaymentWaysColumn.FeeItemPaymentWayId - 1)];
			entity.OriginalFeeItemPaymentWayId = (System.Decimal)reader["Fee_Item_Payment_Way_Id"];
			entity.FeeFacultyItemId = (System.Decimal)reader[((int)FeeItemPaymentWaysColumn.FeeFacultyItemId - 1)];
			entity.FeeCdeBankAccntId = (System.Decimal)reader[((int)FeeItemPaymentWaysColumn.FeeCdeBankAccntId - 1)];
			entity.IsPercentage = (reader.IsDBNull(((int)FeeItemPaymentWaysColumn.IsPercentage - 1)))?null:(System.Boolean?)reader[((int)FeeItemPaymentWaysColumn.IsPercentage - 1)];
			entity.ItemValue = (reader.IsDBNull(((int)FeeItemPaymentWaysColumn.ItemValue - 1)))?null:(System.Decimal?)reader[((int)FeeItemPaymentWaysColumn.ItemValue - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeItemPaymentWays"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeItemPaymentWays"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeItemPaymentWays entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeItemPaymentWayId = (System.Decimal)dataRow["Fee_Item_Payment_Way_Id"];
			entity.OriginalFeeItemPaymentWayId = (System.Decimal)dataRow["Fee_Item_Payment_Way_Id"];
			entity.FeeFacultyItemId = (System.Decimal)dataRow["FEE_FACULTY_ITEM_ID"];
			entity.FeeCdeBankAccntId = (System.Decimal)dataRow["FEE_CDE_BANK_ACCNT_ID"];
			entity.IsPercentage = Convert.IsDBNull(dataRow["Is_Percentage"]) ? null : (System.Boolean?)dataRow["Is_Percentage"];
			entity.ItemValue = Convert.IsDBNull(dataRow["Item_Value"]) ? null : (System.Decimal?)dataRow["Item_Value"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeItemPaymentWays"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeItemPaymentWays Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeItemPaymentWays entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region FeeCdeBankAccntIdSource	
			if (CanDeepLoad(entity, "FeeCdeBankAccnt|FeeCdeBankAccntIdSource", deepLoadType, innerList) 
				&& entity.FeeCdeBankAccntIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCdeBankAccntId;
				FeeCdeBankAccnt tmpEntity = EntityManager.LocateEntity<FeeCdeBankAccnt>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCdeBankAccnt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCdeBankAccntIdSource = tmpEntity;
				else
					entity.FeeCdeBankAccntIdSource = DataRepository.FeeCdeBankAccntProvider.GetByFeeCdeBankAccntId(transactionManager, entity.FeeCdeBankAccntId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeBankAccntIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCdeBankAccntIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCdeBankAccntProvider.DeepLoad(transactionManager, entity.FeeCdeBankAccntIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCdeBankAccntIdSource

			#region FeeFacultyItemIdSource	
			if (CanDeepLoad(entity, "FeeFacultyItem|FeeFacultyItemIdSource", deepLoadType, innerList) 
				&& entity.FeeFacultyItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeFacultyItemId;
				FeeFacultyItem tmpEntity = EntityManager.LocateEntity<FeeFacultyItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeFacultyItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeFacultyItemIdSource = tmpEntity;
				else
					entity.FeeFacultyItemIdSource = DataRepository.FeeFacultyItemProvider.GetByFeeFacultyItemId(transactionManager, entity.FeeFacultyItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeFacultyItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeFacultyItemProvider.DeepLoad(transactionManager, entity.FeeFacultyItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeFacultyItemIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeItemPaymentWays object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeItemPaymentWays instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeItemPaymentWays Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeItemPaymentWays entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region FeeCdeBankAccntIdSource
			if (CanDeepSave(entity, "FeeCdeBankAccnt|FeeCdeBankAccntIdSource", deepSaveType, innerList) 
				&& entity.FeeCdeBankAccntIdSource != null)
			{
				DataRepository.FeeCdeBankAccntProvider.Save(transactionManager, entity.FeeCdeBankAccntIdSource);
				entity.FeeCdeBankAccntId = entity.FeeCdeBankAccntIdSource.FeeCdeBankAccntId;
			}
			#endregion 
			
			#region FeeFacultyItemIdSource
			if (CanDeepSave(entity, "FeeFacultyItem|FeeFacultyItemIdSource", deepSaveType, innerList) 
				&& entity.FeeFacultyItemIdSource != null)
			{
				DataRepository.FeeFacultyItemProvider.Save(transactionManager, entity.FeeFacultyItemIdSource);
				entity.FeeFacultyItemId = entity.FeeFacultyItemIdSource.FeeFacultyItemId;
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
	
	#region FeeItemPaymentWaysChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeItemPaymentWays</c>
	///</summary>
	public enum FeeItemPaymentWaysChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>FeeCdeBankAccnt</c> at FeeCdeBankAccntIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCdeBankAccnt))]
		FeeCdeBankAccnt,
		
		///<summary>
		/// Composite Property for <c>FeeFacultyItem</c> at FeeFacultyItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeFacultyItem))]
		FeeFacultyItem,
	}
	
	#endregion FeeItemPaymentWaysChildEntityTypes
	
	#region FeeItemPaymentWaysFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeItemPaymentWaysColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeItemPaymentWays"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeItemPaymentWaysFilterBuilder : SqlFilterBuilder<FeeItemPaymentWaysColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeItemPaymentWaysFilterBuilder class.
		/// </summary>
		public FeeItemPaymentWaysFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeItemPaymentWaysFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeItemPaymentWaysFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeItemPaymentWaysFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeItemPaymentWaysFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeItemPaymentWaysFilterBuilder
	
	#region FeeItemPaymentWaysParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeItemPaymentWaysColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeItemPaymentWays"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeItemPaymentWaysParameterBuilder : ParameterizedSqlFilterBuilder<FeeItemPaymentWaysColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeItemPaymentWaysParameterBuilder class.
		/// </summary>
		public FeeItemPaymentWaysParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeItemPaymentWaysParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeItemPaymentWaysParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeItemPaymentWaysParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeItemPaymentWaysParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeItemPaymentWaysParameterBuilder
	
	#region FeeItemPaymentWaysSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeItemPaymentWaysColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeItemPaymentWays"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeItemPaymentWaysSortBuilder : SqlSortBuilder<FeeItemPaymentWaysColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeItemPaymentWaysSqlSortBuilder class.
		/// </summary>
		public FeeItemPaymentWaysSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeItemPaymentWaysSortBuilder
	
} // end namespace
