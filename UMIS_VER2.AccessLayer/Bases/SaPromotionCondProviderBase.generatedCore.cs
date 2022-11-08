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
	/// This class is the base class for any <see cref="SaPromotionCondProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaPromotionCondProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaPromotionCond, UMIS_VER2.BusinessLyer.SaPromotionCondKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPromotionCondKey key)
		{
			return Delete(transactionManager, key.SaPromotionCondId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saPromotionCondId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saPromotionCondId)
		{
			return Delete(null, _saPromotionCondId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionCondId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saPromotionCondId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_COND_SA_CODE_SC_DEG key.
		///		FK_SA_PROMOTION_COND_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCond objects.</returns>
		public TList<SaPromotionCond> GetBySaCodeScDegId(System.Decimal _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(_saCodeScDegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_COND_SA_CODE_SC_DEG key.
		///		FK_SA_PROMOTION_COND_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCond objects.</returns>
		/// <remarks></remarks>
		public TList<SaPromotionCond> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_COND_SA_CODE_SC_DEG key.
		///		FK_SA_PROMOTION_COND_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCond objects.</returns>
		public TList<SaPromotionCond> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_COND_SA_CODE_SC_DEG key.
		///		fkSaPromotionCondSaCodeScDeg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCond objects.</returns>
		public TList<SaPromotionCond> GetBySaCodeScDegId(System.Decimal _saCodeScDegId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_COND_SA_CODE_SC_DEG key.
		///		fkSaPromotionCondSaCodeScDeg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCond objects.</returns>
		public TList<SaPromotionCond> GetBySaCodeScDegId(System.Decimal _saCodeScDegId, int start, int pageLength,out int count)
		{
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_COND_SA_CODE_SC_DEG key.
		///		FK_SA_PROMOTION_COND_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCond objects.</returns>
		public abstract TList<SaPromotionCond> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaPromotionCond Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPromotionCondKey key, int start, int pageLength)
		{
			return GetBySaPromotionCondId(transactionManager, key.SaPromotionCondId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_PROMOTION_COND index.
		/// </summary>
		/// <param name="_saPromotionCondId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotionCond"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotionCond GetBySaPromotionCondId(System.Decimal _saPromotionCondId)
		{
			int count = -1;
			return GetBySaPromotionCondId(null,_saPromotionCondId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION_COND index.
		/// </summary>
		/// <param name="_saPromotionCondId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotionCond"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotionCond GetBySaPromotionCondId(System.Decimal _saPromotionCondId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPromotionCondId(null, _saPromotionCondId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION_COND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionCondId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotionCond"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotionCond GetBySaPromotionCondId(TransactionManager transactionManager, System.Decimal _saPromotionCondId)
		{
			int count = -1;
			return GetBySaPromotionCondId(transactionManager, _saPromotionCondId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION_COND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionCondId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotionCond"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotionCond GetBySaPromotionCondId(TransactionManager transactionManager, System.Decimal _saPromotionCondId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPromotionCondId(transactionManager, _saPromotionCondId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION_COND index.
		/// </summary>
		/// <param name="_saPromotionCondId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotionCond"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotionCond GetBySaPromotionCondId(System.Decimal _saPromotionCondId, int start, int pageLength, out int count)
		{
			return GetBySaPromotionCondId(null, _saPromotionCondId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION_COND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionCondId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotionCond"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaPromotionCond GetBySaPromotionCondId(TransactionManager transactionManager, System.Decimal _saPromotionCondId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaPromotionCond&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaPromotionCond&gt;"/></returns>
		public static TList<SaPromotionCond> Fill(IDataReader reader, TList<SaPromotionCond> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaPromotionCond c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaPromotionCond")
					.Append("|").Append((System.Decimal)reader["SA_PROMOTION_COND_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaPromotionCond>(
					key.ToString(), // EntityTrackingKey
					"SaPromotionCond",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaPromotionCond();
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
					c.SaPromotionCondId = (System.Decimal)reader["SA_PROMOTION_COND_ID"];
					c.OriginalSaPromotionCondId = c.SaPromotionCondId;
					c.CondCode = Convert.IsDBNull(reader["COND_CODE"]) ? null : (System.Decimal?)reader["COND_CODE"];
					c.CondDescr = (System.String)reader["COND_DESCR"];
					c.SaCodeScDegId = (System.Decimal)reader["SA_CODE_SC_DEG_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaPromotionCond"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPromotionCond"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaPromotionCond entity)
		{
			if (!reader.Read()) return;
			
			entity.SaPromotionCondId = (System.Decimal)reader[((int)SaPromotionCondColumn.SaPromotionCondId - 1)];
			entity.OriginalSaPromotionCondId = (System.Decimal)reader["SA_PROMOTION_COND_ID"];
			entity.CondCode = (reader.IsDBNull(((int)SaPromotionCondColumn.CondCode - 1)))?null:(System.Decimal?)reader[((int)SaPromotionCondColumn.CondCode - 1)];
			entity.CondDescr = (System.String)reader[((int)SaPromotionCondColumn.CondDescr - 1)];
			entity.SaCodeScDegId = (System.Decimal)reader[((int)SaPromotionCondColumn.SaCodeScDegId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaPromotionCond"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPromotionCond"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaPromotionCond entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaPromotionCondId = (System.Decimal)dataRow["SA_PROMOTION_COND_ID"];
			entity.OriginalSaPromotionCondId = (System.Decimal)dataRow["SA_PROMOTION_COND_ID"];
			entity.CondCode = Convert.IsDBNull(dataRow["COND_CODE"]) ? null : (System.Decimal?)dataRow["COND_CODE"];
			entity.CondDescr = (System.String)dataRow["COND_DESCR"];
			entity.SaCodeScDegId = (System.Decimal)dataRow["SA_CODE_SC_DEG_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPromotionCond"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaPromotionCond Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPromotionCond entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaCodeScDegIdSource	
			if (CanDeepLoad(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepLoadType, innerList) 
				&& entity.SaCodeScDegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeScDegId;
				SaCodeScDeg tmpEntity = EntityManager.LocateEntity<SaCodeScDeg>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeScDeg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeScDegIdSource = tmpEntity;
				else
					entity.SaCodeScDegIdSource = DataRepository.SaCodeScDegProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeScDegIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeScDegIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeScDegProvider.DeepLoad(transactionManager, entity.SaCodeScDegIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeScDegIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaPromotionCondId methods when available
			
			#region SaPromotionCondStsfCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPromotionCondStsf>|SaPromotionCondStsfCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPromotionCondStsfCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPromotionCondStsfCollection = DataRepository.SaPromotionCondStsfProvider.GetBySaPromotionCondId(transactionManager, entity.SaPromotionCondId);

				if (deep && entity.SaPromotionCondStsfCollection.Count > 0)
				{
					deepHandles.Add("SaPromotionCondStsfCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPromotionCondStsf>) DataRepository.SaPromotionCondStsfProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPromotionCondStsfCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaPromotionCond object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaPromotionCond instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaPromotionCond Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPromotionCond entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaCodeScDegIdSource
			if (CanDeepSave(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepSaveType, innerList) 
				&& entity.SaCodeScDegIdSource != null)
			{
				DataRepository.SaCodeScDegProvider.Save(transactionManager, entity.SaCodeScDegIdSource);
				entity.SaCodeScDegId = entity.SaCodeScDegIdSource.SaCodeScDegId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaPromotionCondStsf>
				if (CanDeepSave(entity.SaPromotionCondStsfCollection, "List<SaPromotionCondStsf>|SaPromotionCondStsfCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPromotionCondStsf child in entity.SaPromotionCondStsfCollection)
					{
						if(child.SaPromotionCondIdSource != null)
						{
							child.SaPromotionCondId = child.SaPromotionCondIdSource.SaPromotionCondId;
						}
						else
						{
							child.SaPromotionCondId = entity.SaPromotionCondId;
						}

					}

					if (entity.SaPromotionCondStsfCollection.Count > 0 || entity.SaPromotionCondStsfCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPromotionCondStsfProvider.Save(transactionManager, entity.SaPromotionCondStsfCollection);
						
						deepHandles.Add("SaPromotionCondStsfCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPromotionCondStsf >) DataRepository.SaPromotionCondStsfProvider.DeepSave,
							new object[] { transactionManager, entity.SaPromotionCondStsfCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaPromotionCondChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaPromotionCond</c>
	///</summary>
	public enum SaPromotionCondChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeScDeg</c> at SaCodeScDegIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeScDeg))]
		SaCodeScDeg,
		///<summary>
		/// Collection of <c>SaPromotionCond</c> as OneToMany for SaPromotionCondStsfCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPromotionCondStsf>))]
		SaPromotionCondStsfCollection,
	}
	
	#endregion SaPromotionCondChildEntityTypes
	
	#region SaPromotionCondFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaPromotionCondColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPromotionCond"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaPromotionCondFilterBuilder : SqlFilterBuilder<SaPromotionCondColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPromotionCondFilterBuilder class.
		/// </summary>
		public SaPromotionCondFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaPromotionCondFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaPromotionCondFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaPromotionCondFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaPromotionCondFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaPromotionCondFilterBuilder
	
	#region SaPromotionCondParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaPromotionCondColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPromotionCond"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaPromotionCondParameterBuilder : ParameterizedSqlFilterBuilder<SaPromotionCondColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPromotionCondParameterBuilder class.
		/// </summary>
		public SaPromotionCondParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaPromotionCondParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaPromotionCondParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaPromotionCondParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaPromotionCondParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaPromotionCondParameterBuilder
	
	#region SaPromotionCondSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaPromotionCondColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPromotionCond"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaPromotionCondSortBuilder : SqlSortBuilder<SaPromotionCondColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPromotionCondSqlSortBuilder class.
		/// </summary>
		public SaPromotionCondSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaPromotionCondSortBuilder
	
} // end namespace
