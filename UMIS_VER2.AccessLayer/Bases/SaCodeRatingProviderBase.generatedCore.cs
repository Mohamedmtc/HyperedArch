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
	/// This class is the base class for any <see cref="SaCodeRatingProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeRatingProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeRating, UMIS_VER2.BusinessLyer.SaCodeRatingKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeRatingKey key)
		{
			return Delete(transactionManager, key.SaCodeRatingId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeRatingId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeRatingId)
		{
			return Delete(null, _saCodeRatingId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeRatingId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeRatingId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
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
		public override UMIS_VER2.BusinessLyer.SaCodeRating Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeRatingKey key, int start, int pageLength)
		{
			return GetBySaCodeRatingId(transactionManager, key.SaCodeRatingId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SA_CODE_RATING index.
		/// </summary>
		/// <param name="_ratingDescrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeRating"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeRating GetByRatingDescrAr(System.String _ratingDescrAr)
		{
			int count = -1;
			return GetByRatingDescrAr(null,_ratingDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_RATING index.
		/// </summary>
		/// <param name="_ratingDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeRating"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeRating GetByRatingDescrAr(System.String _ratingDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByRatingDescrAr(null, _ratingDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_RATING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ratingDescrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeRating"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeRating GetByRatingDescrAr(TransactionManager transactionManager, System.String _ratingDescrAr)
		{
			int count = -1;
			return GetByRatingDescrAr(transactionManager, _ratingDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_RATING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ratingDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeRating"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeRating GetByRatingDescrAr(TransactionManager transactionManager, System.String _ratingDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByRatingDescrAr(transactionManager, _ratingDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_RATING index.
		/// </summary>
		/// <param name="_ratingDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeRating"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeRating GetByRatingDescrAr(System.String _ratingDescrAr, int start, int pageLength, out int count)
		{
			return GetByRatingDescrAr(null, _ratingDescrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_RATING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ratingDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeRating"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeRating GetByRatingDescrAr(TransactionManager transactionManager, System.String _ratingDescrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SA_CODE_RATING_EN index.
		/// </summary>
		/// <param name="_saCodeRatingId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeRating"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeRating GetBySaCodeRatingId(System.Decimal _saCodeRatingId)
		{
			int count = -1;
			return GetBySaCodeRatingId(null,_saCodeRatingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_RATING_EN index.
		/// </summary>
		/// <param name="_saCodeRatingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeRating"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeRating GetBySaCodeRatingId(System.Decimal _saCodeRatingId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeRatingId(null, _saCodeRatingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_RATING_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeRatingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeRating"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeRating GetBySaCodeRatingId(TransactionManager transactionManager, System.Decimal _saCodeRatingId)
		{
			int count = -1;
			return GetBySaCodeRatingId(transactionManager, _saCodeRatingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_RATING_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeRatingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeRating"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeRating GetBySaCodeRatingId(TransactionManager transactionManager, System.Decimal _saCodeRatingId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeRatingId(transactionManager, _saCodeRatingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_RATING_EN index.
		/// </summary>
		/// <param name="_saCodeRatingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeRating"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeRating GetBySaCodeRatingId(System.Decimal _saCodeRatingId, int start, int pageLength, out int count)
		{
			return GetBySaCodeRatingId(null, _saCodeRatingId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_RATING_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeRatingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeRating"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeRating GetBySaCodeRatingId(TransactionManager transactionManager, System.Decimal _saCodeRatingId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeRating&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeRating&gt;"/></returns>
		public static TList<SaCodeRating> Fill(IDataReader reader, TList<SaCodeRating> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeRating c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeRating")
					.Append("|").Append((System.Decimal)reader["SA_CODE_RATING_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeRating>(
					key.ToString(), // EntityTrackingKey
					"SaCodeRating",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeRating();
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
					c.SaCodeRatingId = (System.Decimal)reader["SA_CODE_RATING_ID"];
					c.OriginalSaCodeRatingId = c.SaCodeRatingId;
					c.RatingDescrAr = (System.String)reader["RATING_DESCR_AR"];
					c.RatingDescrEn = (System.String)reader["RATING_DESCR_EN"];
					c.RatingSymbolAr = Convert.IsDBNull(reader["RATING_SYMBOL_AR"]) ? null : (System.String)reader["RATING_SYMBOL_AR"];
					c.RatingSymbolEn = Convert.IsDBNull(reader["RATING_SYMBOL_EN"]) ? null : (System.String)reader["RATING_SYMBOL_EN"];
					c.RatingOrder = (System.Decimal)reader["RATING_ORDER"];
					c.RatingCode = Convert.IsDBNull(reader["RATING_CODE"]) ? null : (System.String)reader["RATING_CODE"];
					c.IsFailing = (System.Decimal)reader["IS_FAILING"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeRating"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeRating"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeRating entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeRatingId = (System.Decimal)reader[((int)SaCodeRatingColumn.SaCodeRatingId - 1)];
			entity.OriginalSaCodeRatingId = (System.Decimal)reader["SA_CODE_RATING_ID"];
			entity.RatingDescrAr = (System.String)reader[((int)SaCodeRatingColumn.RatingDescrAr - 1)];
			entity.RatingDescrEn = (System.String)reader[((int)SaCodeRatingColumn.RatingDescrEn - 1)];
			entity.RatingSymbolAr = (reader.IsDBNull(((int)SaCodeRatingColumn.RatingSymbolAr - 1)))?null:(System.String)reader[((int)SaCodeRatingColumn.RatingSymbolAr - 1)];
			entity.RatingSymbolEn = (reader.IsDBNull(((int)SaCodeRatingColumn.RatingSymbolEn - 1)))?null:(System.String)reader[((int)SaCodeRatingColumn.RatingSymbolEn - 1)];
			entity.RatingOrder = (System.Decimal)reader[((int)SaCodeRatingColumn.RatingOrder - 1)];
			entity.RatingCode = (reader.IsDBNull(((int)SaCodeRatingColumn.RatingCode - 1)))?null:(System.String)reader[((int)SaCodeRatingColumn.RatingCode - 1)];
			entity.IsFailing = (System.Decimal)reader[((int)SaCodeRatingColumn.IsFailing - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeRating"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeRating"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeRating entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeRatingId = (System.Decimal)dataRow["SA_CODE_RATING_ID"];
			entity.OriginalSaCodeRatingId = (System.Decimal)dataRow["SA_CODE_RATING_ID"];
			entity.RatingDescrAr = (System.String)dataRow["RATING_DESCR_AR"];
			entity.RatingDescrEn = (System.String)dataRow["RATING_DESCR_EN"];
			entity.RatingSymbolAr = Convert.IsDBNull(dataRow["RATING_SYMBOL_AR"]) ? null : (System.String)dataRow["RATING_SYMBOL_AR"];
			entity.RatingSymbolEn = Convert.IsDBNull(dataRow["RATING_SYMBOL_EN"]) ? null : (System.String)dataRow["RATING_SYMBOL_EN"];
			entity.RatingOrder = (System.Decimal)dataRow["RATING_ORDER"];
			entity.RatingCode = Convert.IsDBNull(dataRow["RATING_CODE"]) ? null : (System.String)dataRow["RATING_CODE"];
			entity.IsFailing = (System.Decimal)dataRow["IS_FAILING"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeRating"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeRating Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeRating entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeRatingId methods when available
			
			#region SaScQualCollectionGetBySaCodeRatingId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaScQual>|SaScQualCollectionGetBySaCodeRatingId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScQualCollectionGetBySaCodeRatingId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaScQualCollectionGetBySaCodeRatingId = DataRepository.SaScQualProvider.GetBySaCodeRatingId(transactionManager, entity.SaCodeRatingId);

				if (deep && entity.SaScQualCollectionGetBySaCodeRatingId.Count > 0)
				{
					deepHandles.Add("SaScQualCollectionGetBySaCodeRatingId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaScQual>) DataRepository.SaScQualProvider.DeepLoad,
						new object[] { transactionManager, entity.SaScQualCollectionGetBySaCodeRatingId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaScQualCollectionGetBySaCodeRatingId2
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaScQual>|SaScQualCollectionGetBySaCodeRatingId2", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScQualCollectionGetBySaCodeRatingId2' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaScQualCollectionGetBySaCodeRatingId2 = DataRepository.SaScQualProvider.GetBySaCodeRatingId2(transactionManager, entity.SaCodeRatingId);

				if (deep && entity.SaScQualCollectionGetBySaCodeRatingId2.Count > 0)
				{
					deepHandles.Add("SaScQualCollectionGetBySaCodeRatingId2",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaScQual>) DataRepository.SaScQualProvider.DeepLoad,
						new object[] { transactionManager, entity.SaScQualCollectionGetBySaCodeRatingId2, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeRating object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeRating instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeRating Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeRating entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaScQual>
				if (CanDeepSave(entity.SaScQualCollectionGetBySaCodeRatingId, "List<SaScQual>|SaScQualCollectionGetBySaCodeRatingId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaScQual child in entity.SaScQualCollectionGetBySaCodeRatingId)
					{
						if(child.SaCodeRatingIdSource != null)
						{
							child.SaCodeRatingId = child.SaCodeRatingIdSource.SaCodeRatingId;
						}
						else
						{
							child.SaCodeRatingId = entity.SaCodeRatingId;
						}

					}

					if (entity.SaScQualCollectionGetBySaCodeRatingId.Count > 0 || entity.SaScQualCollectionGetBySaCodeRatingId.DeletedItems.Count > 0)
					{
						//DataRepository.SaScQualProvider.Save(transactionManager, entity.SaScQualCollectionGetBySaCodeRatingId);
						
						deepHandles.Add("SaScQualCollectionGetBySaCodeRatingId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaScQual >) DataRepository.SaScQualProvider.DeepSave,
							new object[] { transactionManager, entity.SaScQualCollectionGetBySaCodeRatingId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaScQual>
				if (CanDeepSave(entity.SaScQualCollectionGetBySaCodeRatingId2, "List<SaScQual>|SaScQualCollectionGetBySaCodeRatingId2", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaScQual child in entity.SaScQualCollectionGetBySaCodeRatingId2)
					{
						if(child.SaCodeRatingId2Source != null)
						{
							child.SaCodeRatingId2 = child.SaCodeRatingId2Source.SaCodeRatingId;
						}
						else
						{
							child.SaCodeRatingId2 = entity.SaCodeRatingId;
						}

					}

					if (entity.SaScQualCollectionGetBySaCodeRatingId2.Count > 0 || entity.SaScQualCollectionGetBySaCodeRatingId2.DeletedItems.Count > 0)
					{
						//DataRepository.SaScQualProvider.Save(transactionManager, entity.SaScQualCollectionGetBySaCodeRatingId2);
						
						deepHandles.Add("SaScQualCollectionGetBySaCodeRatingId2",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaScQual >) DataRepository.SaScQualProvider.DeepSave,
							new object[] { transactionManager, entity.SaScQualCollectionGetBySaCodeRatingId2, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
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
	
	#region SaCodeRatingChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeRating</c>
	///</summary>
	public enum SaCodeRatingChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCodeRating</c> as OneToMany for SaScQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaScQual>))]
		SaScQualCollectionGetBySaCodeRatingId,
		///<summary>
		/// Collection of <c>SaCodeRating</c> as OneToMany for SaScQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaScQual>))]
		SaScQualCollectionGetBySaCodeRatingId2,
	}
	
	#endregion SaCodeRatingChildEntityTypes
	
	#region SaCodeRatingFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeRatingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeRating"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeRatingFilterBuilder : SqlFilterBuilder<SaCodeRatingColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeRatingFilterBuilder class.
		/// </summary>
		public SaCodeRatingFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeRatingFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeRatingFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeRatingFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeRatingFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeRatingFilterBuilder
	
	#region SaCodeRatingParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeRatingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeRating"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeRatingParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeRatingColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeRatingParameterBuilder class.
		/// </summary>
		public SaCodeRatingParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeRatingParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeRatingParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeRatingParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeRatingParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeRatingParameterBuilder
	
	#region SaCodeRatingSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeRatingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeRating"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeRatingSortBuilder : SqlSortBuilder<SaCodeRatingColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeRatingSqlSortBuilder class.
		/// </summary>
		public SaCodeRatingSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeRatingSortBuilder
	
} // end namespace
