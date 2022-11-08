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
	/// This class is the base class for any <see cref="FeeStudYearItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudYearItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeStudYearItem, UMIS_VER2.BusinessLyer.FeeStudYearItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudYearItemKey key)
		{
			return Delete(transactionManager, key.FeeStudYearItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeStudYearItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeStudYearItemId)
		{
			return Delete(null, _feeStudYearItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudYearItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeStudYearItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_YEAR_ITEM_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_YEAR_ITEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudYearItem objects.</returns>
		public TList<FeeStudYearItem> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_YEAR_ITEM_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_YEAR_ITEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudYearItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudYearItem> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_YEAR_ITEM_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_YEAR_ITEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudYearItem objects.</returns>
		public TList<FeeStudYearItem> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_YEAR_ITEM_ED_ACAD_YEAR key.
		///		fkFeeStudYearItemEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudYearItem objects.</returns>
		public TList<FeeStudYearItem> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_YEAR_ITEM_ED_ACAD_YEAR key.
		///		fkFeeStudYearItemEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudYearItem objects.</returns>
		public TList<FeeStudYearItem> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_YEAR_ITEM_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_YEAR_ITEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudYearItem objects.</returns>
		public abstract TList<FeeStudYearItem> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_YEAR_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_STUD_YEAR_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="_feeStudFeeItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudYearItem objects.</returns>
		public TList<FeeStudYearItem> GetByFeeStudFeeItemId(System.Decimal _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(_feeStudFeeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_YEAR_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_STUD_YEAR_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudYearItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudYearItem> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_YEAR_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_STUD_YEAR_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudYearItem objects.</returns>
		public TList<FeeStudYearItem> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal _feeStudFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_YEAR_ITEM_FEE_STUD_FEE_ITEM key.
		///		fkFeeStudYearItemFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudYearItem objects.</returns>
		public TList<FeeStudYearItem> GetByFeeStudFeeItemId(System.Decimal _feeStudFeeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_YEAR_ITEM_FEE_STUD_FEE_ITEM key.
		///		fkFeeStudYearItemFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudYearItem objects.</returns>
		public TList<FeeStudYearItem> GetByFeeStudFeeItemId(System.Decimal _feeStudFeeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_YEAR_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_STUD_YEAR_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudYearItem objects.</returns>
		public abstract TList<FeeStudYearItem> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal _feeStudFeeItemId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeStudYearItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudYearItemKey key, int start, int pageLength)
		{
			return GetByFeeStudYearItemId(transactionManager, key.FeeStudYearItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_STUD_YEAR_ITEM index.
		/// </summary>
		/// <param name="_feeStudYearItemId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudYearItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudYearItem GetByFeeStudYearItemId(System.Decimal _feeStudYearItemId)
		{
			int count = -1;
			return GetByFeeStudYearItemId(null,_feeStudYearItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_YEAR_ITEM index.
		/// </summary>
		/// <param name="_feeStudYearItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudYearItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudYearItem GetByFeeStudYearItemId(System.Decimal _feeStudYearItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudYearItemId(null, _feeStudYearItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_YEAR_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudYearItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudYearItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudYearItem GetByFeeStudYearItemId(TransactionManager transactionManager, System.Decimal _feeStudYearItemId)
		{
			int count = -1;
			return GetByFeeStudYearItemId(transactionManager, _feeStudYearItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_YEAR_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudYearItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudYearItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudYearItem GetByFeeStudYearItemId(TransactionManager transactionManager, System.Decimal _feeStudYearItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudYearItemId(transactionManager, _feeStudYearItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_YEAR_ITEM index.
		/// </summary>
		/// <param name="_feeStudYearItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudYearItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudYearItem GetByFeeStudYearItemId(System.Decimal _feeStudYearItemId, int start, int pageLength, out int count)
		{
			return GetByFeeStudYearItemId(null, _feeStudYearItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_YEAR_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudYearItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudYearItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudYearItem GetByFeeStudYearItemId(TransactionManager transactionManager, System.Decimal _feeStudYearItemId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeStudYearItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeStudYearItem&gt;"/></returns>
		public static TList<FeeStudYearItem> Fill(IDataReader reader, TList<FeeStudYearItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeStudYearItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeStudYearItem")
					.Append("|").Append((System.Decimal)reader["FEE_STUD_YEAR_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeStudYearItem>(
					key.ToString(), // EntityTrackingKey
					"FeeStudYearItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeStudYearItem();
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
					c.FeeStudYearItemId = (System.Decimal)reader["FEE_STUD_YEAR_ITEM_ID"];
					c.FeeStudFeeItemId = (System.Decimal)reader["FEE_STUD_FEE_ITEM_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.ActualAmount = Convert.IsDBNull(reader["ACTUAL_AMOUNT"]) ? null : (System.Decimal?)reader["ACTUAL_AMOUNT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudYearItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudYearItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeStudYearItem entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeStudYearItemId = (System.Decimal)reader[((int)FeeStudYearItemColumn.FeeStudYearItemId - 1)];
			entity.FeeStudFeeItemId = (System.Decimal)reader[((int)FeeStudYearItemColumn.FeeStudFeeItemId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)FeeStudYearItemColumn.EdAcadYearId - 1)];
			entity.ActualAmount = (reader.IsDBNull(((int)FeeStudYearItemColumn.ActualAmount - 1)))?null:(System.Decimal?)reader[((int)FeeStudYearItemColumn.ActualAmount - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudYearItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudYearItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeStudYearItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeStudYearItemId = (System.Decimal)dataRow["FEE_STUD_YEAR_ITEM_ID"];
			entity.FeeStudFeeItemId = (System.Decimal)dataRow["FEE_STUD_FEE_ITEM_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.ActualAmount = Convert.IsDBNull(dataRow["ACTUAL_AMOUNT"]) ? null : (System.Decimal?)dataRow["ACTUAL_AMOUNT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudYearItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudYearItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudYearItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeStudYearItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeStudYearItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudYearItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudYearItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region FeeStudYearItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeStudYearItem</c>
	///</summary>
	public enum FeeStudYearItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
			
		///<summary>
		/// Composite Property for <c>FeeStudFeeItem</c> at FeeStudFeeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudFeeItem))]
		FeeStudFeeItem,
		}
	
	#endregion FeeStudYearItemChildEntityTypes
	
	#region FeeStudYearItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeStudYearItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudYearItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudYearItemFilterBuilder : SqlFilterBuilder<FeeStudYearItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudYearItemFilterBuilder class.
		/// </summary>
		public FeeStudYearItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudYearItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudYearItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudYearItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudYearItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudYearItemFilterBuilder
	
	#region FeeStudYearItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeStudYearItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudYearItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudYearItemParameterBuilder : ParameterizedSqlFilterBuilder<FeeStudYearItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudYearItemParameterBuilder class.
		/// </summary>
		public FeeStudYearItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudYearItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudYearItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudYearItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudYearItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudYearItemParameterBuilder
	
	#region FeeStudYearItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeStudYearItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudYearItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeStudYearItemSortBuilder : SqlSortBuilder<FeeStudYearItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudYearItemSqlSortBuilder class.
		/// </summary>
		public FeeStudYearItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeStudYearItemSortBuilder
	
} // end namespace
