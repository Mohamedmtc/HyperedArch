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
	/// This class is the base class for any <see cref="PgOfferingTopicProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgOfferingTopicProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgOfferingTopic, UMIS_VER2.BusinessLyer.PgOfferingTopicKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgOfferingTopicKey key)
		{
			return Delete(transactionManager, key.PgOfferingTopicId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgOfferingTopicId">مواضيع البحث المطروحة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _pgOfferingTopicId)
		{
			return Delete(null, _pgOfferingTopicId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgOfferingTopicId">مواضيع البحث المطروحة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _pgOfferingTopicId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_OFFERING_TOPIC_PG_OFFERING key.
		///		FK_PG_OFFERING_TOPIC_PG_OFFERING Description: 
		/// </summary>
		/// <param name="_pgOfferingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgOfferingTopic objects.</returns>
		public TList<PgOfferingTopic> GetByPgOfferingId(System.Int32 _pgOfferingId)
		{
			int count = -1;
			return GetByPgOfferingId(_pgOfferingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_OFFERING_TOPIC_PG_OFFERING key.
		///		FK_PG_OFFERING_TOPIC_PG_OFFERING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgOfferingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgOfferingTopic objects.</returns>
		/// <remarks></remarks>
		public TList<PgOfferingTopic> GetByPgOfferingId(TransactionManager transactionManager, System.Int32 _pgOfferingId)
		{
			int count = -1;
			return GetByPgOfferingId(transactionManager, _pgOfferingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_OFFERING_TOPIC_PG_OFFERING key.
		///		FK_PG_OFFERING_TOPIC_PG_OFFERING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgOfferingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgOfferingTopic objects.</returns>
		public TList<PgOfferingTopic> GetByPgOfferingId(TransactionManager transactionManager, System.Int32 _pgOfferingId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgOfferingId(transactionManager, _pgOfferingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_OFFERING_TOPIC_PG_OFFERING key.
		///		fkPgOfferingTopicPgOffering Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgOfferingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgOfferingTopic objects.</returns>
		public TList<PgOfferingTopic> GetByPgOfferingId(System.Int32 _pgOfferingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgOfferingId(null, _pgOfferingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_OFFERING_TOPIC_PG_OFFERING key.
		///		fkPgOfferingTopicPgOffering Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgOfferingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgOfferingTopic objects.</returns>
		public TList<PgOfferingTopic> GetByPgOfferingId(System.Int32 _pgOfferingId, int start, int pageLength,out int count)
		{
			return GetByPgOfferingId(null, _pgOfferingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_OFFERING_TOPIC_PG_OFFERING key.
		///		FK_PG_OFFERING_TOPIC_PG_OFFERING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgOfferingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgOfferingTopic objects.</returns>
		public abstract TList<PgOfferingTopic> GetByPgOfferingId(TransactionManager transactionManager, System.Int32 _pgOfferingId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgOfferingTopic Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgOfferingTopicKey key, int start, int pageLength)
		{
			return GetByPgOfferingTopicId(transactionManager, key.PgOfferingTopicId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_OFFERING_TOPIC index.
		/// </summary>
		/// <param name="_pgOfferingTopicId">مواضيع البحث المطروحة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgOfferingTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgOfferingTopic GetByPgOfferingTopicId(System.Int32 _pgOfferingTopicId)
		{
			int count = -1;
			return GetByPgOfferingTopicId(null,_pgOfferingTopicId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_OFFERING_TOPIC index.
		/// </summary>
		/// <param name="_pgOfferingTopicId">مواضيع البحث المطروحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgOfferingTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgOfferingTopic GetByPgOfferingTopicId(System.Int32 _pgOfferingTopicId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgOfferingTopicId(null, _pgOfferingTopicId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_OFFERING_TOPIC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgOfferingTopicId">مواضيع البحث المطروحة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgOfferingTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgOfferingTopic GetByPgOfferingTopicId(TransactionManager transactionManager, System.Int32 _pgOfferingTopicId)
		{
			int count = -1;
			return GetByPgOfferingTopicId(transactionManager, _pgOfferingTopicId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_OFFERING_TOPIC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgOfferingTopicId">مواضيع البحث المطروحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgOfferingTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgOfferingTopic GetByPgOfferingTopicId(TransactionManager transactionManager, System.Int32 _pgOfferingTopicId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgOfferingTopicId(transactionManager, _pgOfferingTopicId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_OFFERING_TOPIC index.
		/// </summary>
		/// <param name="_pgOfferingTopicId">مواضيع البحث المطروحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgOfferingTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgOfferingTopic GetByPgOfferingTopicId(System.Int32 _pgOfferingTopicId, int start, int pageLength, out int count)
		{
			return GetByPgOfferingTopicId(null, _pgOfferingTopicId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_OFFERING_TOPIC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgOfferingTopicId">مواضيع البحث المطروحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgOfferingTopic"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgOfferingTopic GetByPgOfferingTopicId(TransactionManager transactionManager, System.Int32 _pgOfferingTopicId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgOfferingTopic&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgOfferingTopic&gt;"/></returns>
		public static TList<PgOfferingTopic> Fill(IDataReader reader, TList<PgOfferingTopic> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgOfferingTopic c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgOfferingTopic")
					.Append("|").Append((System.Int32)reader["PG_OFFERING_TOPIC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgOfferingTopic>(
					key.ToString(), // EntityTrackingKey
					"PgOfferingTopic",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgOfferingTopic();
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
					c.PgOfferingTopicId = (System.Int32)reader["PG_OFFERING_TOPIC_ID"];
					c.OriginalPgOfferingTopicId = c.PgOfferingTopicId;
					c.PgOfferingId = (System.Int32)reader["PG_OFFERING_ID"];
					c.TopicAr = Convert.IsDBNull(reader["TOPIC_AR"]) ? null : (System.String)reader["TOPIC_AR"];
					c.TopicEn = Convert.IsDBNull(reader["TOPIC_EN"]) ? null : (System.String)reader["TOPIC_EN"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgOfferingTopic"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgOfferingTopic"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgOfferingTopic entity)
		{
			if (!reader.Read()) return;
			
			entity.PgOfferingTopicId = (System.Int32)reader[((int)PgOfferingTopicColumn.PgOfferingTopicId - 1)];
			entity.OriginalPgOfferingTopicId = (System.Int32)reader["PG_OFFERING_TOPIC_ID"];
			entity.PgOfferingId = (System.Int32)reader[((int)PgOfferingTopicColumn.PgOfferingId - 1)];
			entity.TopicAr = (reader.IsDBNull(((int)PgOfferingTopicColumn.TopicAr - 1)))?null:(System.String)reader[((int)PgOfferingTopicColumn.TopicAr - 1)];
			entity.TopicEn = (reader.IsDBNull(((int)PgOfferingTopicColumn.TopicEn - 1)))?null:(System.String)reader[((int)PgOfferingTopicColumn.TopicEn - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgOfferingTopicColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgOfferingTopicColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgOfferingTopicColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgOfferingTopicColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgOfferingTopic"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgOfferingTopic"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgOfferingTopic entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgOfferingTopicId = (System.Int32)dataRow["PG_OFFERING_TOPIC_ID"];
			entity.OriginalPgOfferingTopicId = (System.Int32)dataRow["PG_OFFERING_TOPIC_ID"];
			entity.PgOfferingId = (System.Int32)dataRow["PG_OFFERING_ID"];
			entity.TopicAr = Convert.IsDBNull(dataRow["TOPIC_AR"]) ? null : (System.String)dataRow["TOPIC_AR"];
			entity.TopicEn = Convert.IsDBNull(dataRow["TOPIC_EN"]) ? null : (System.String)dataRow["TOPIC_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgOfferingTopic"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgOfferingTopic Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgOfferingTopic entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region PgOfferingIdSource	
			if (CanDeepLoad(entity, "PgOffering|PgOfferingIdSource", deepLoadType, innerList) 
				&& entity.PgOfferingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgOfferingId;
				PgOffering tmpEntity = EntityManager.LocateEntity<PgOffering>(EntityLocator.ConstructKeyFromPkItems(typeof(PgOffering), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgOfferingIdSource = tmpEntity;
				else
					entity.PgOfferingIdSource = DataRepository.PgOfferingProvider.GetByPgOfferingId(transactionManager, entity.PgOfferingId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgOfferingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgOfferingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgOfferingProvider.DeepLoad(transactionManager, entity.PgOfferingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgOfferingIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgOfferingTopicId methods when available
			
			#region AdmAppTopicCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTopic>|AdmAppTopicCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTopicCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTopicCollection = DataRepository.AdmAppTopicProvider.GetByPgOfferingTopicId(transactionManager, entity.PgOfferingTopicId);

				if (deep && entity.AdmAppTopicCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTopicCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTopic>) DataRepository.AdmAppTopicProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTopicCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStudTopicCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStudTopic>|PgThesisStudTopicCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudTopicCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudTopicCollection = DataRepository.PgThesisStudTopicProvider.GetByPgOfferingTopicId(transactionManager, entity.PgOfferingTopicId);

				if (deep && entity.PgThesisStudTopicCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudTopicCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStudTopic>) DataRepository.PgThesisStudTopicProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudTopicCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStud>|PgThesisStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudCollection = DataRepository.PgThesisStudProvider.GetByPgOfferingTopicId(transactionManager, entity.PgOfferingTopicId);

				if (deep && entity.PgThesisStudCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStud>) DataRepository.PgThesisStudProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgOfferingTopic object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgOfferingTopic instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgOfferingTopic Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgOfferingTopic entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region PgOfferingIdSource
			if (CanDeepSave(entity, "PgOffering|PgOfferingIdSource", deepSaveType, innerList) 
				&& entity.PgOfferingIdSource != null)
			{
				DataRepository.PgOfferingProvider.Save(transactionManager, entity.PgOfferingIdSource);
				entity.PgOfferingId = entity.PgOfferingIdSource.PgOfferingId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmAppTopic>
				if (CanDeepSave(entity.AdmAppTopicCollection, "List<AdmAppTopic>|AdmAppTopicCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTopic child in entity.AdmAppTopicCollection)
					{
						if(child.PgOfferingTopicIdSource != null)
						{
							child.PgOfferingTopicId = child.PgOfferingTopicIdSource.PgOfferingTopicId;
						}
						else
						{
							child.PgOfferingTopicId = entity.PgOfferingTopicId;
						}

					}

					if (entity.AdmAppTopicCollection.Count > 0 || entity.AdmAppTopicCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTopicProvider.Save(transactionManager, entity.AdmAppTopicCollection);
						
						deepHandles.Add("AdmAppTopicCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTopic >) DataRepository.AdmAppTopicProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTopicCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStudTopic>
				if (CanDeepSave(entity.PgThesisStudTopicCollection, "List<PgThesisStudTopic>|PgThesisStudTopicCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStudTopic child in entity.PgThesisStudTopicCollection)
					{
						if(child.PgOfferingTopicIdSource != null)
						{
							child.PgOfferingTopicId = child.PgOfferingTopicIdSource.PgOfferingTopicId;
						}
						else
						{
							child.PgOfferingTopicId = entity.PgOfferingTopicId;
						}

					}

					if (entity.PgThesisStudTopicCollection.Count > 0 || entity.PgThesisStudTopicCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudTopicProvider.Save(transactionManager, entity.PgThesisStudTopicCollection);
						
						deepHandles.Add("PgThesisStudTopicCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStudTopic >) DataRepository.PgThesisStudTopicProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudTopicCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStud>
				if (CanDeepSave(entity.PgThesisStudCollection, "List<PgThesisStud>|PgThesisStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStud child in entity.PgThesisStudCollection)
					{
						if(child.PgOfferingTopicIdSource != null)
						{
							child.PgOfferingTopicId = child.PgOfferingTopicIdSource.PgOfferingTopicId;
						}
						else
						{
							child.PgOfferingTopicId = entity.PgOfferingTopicId;
						}

					}

					if (entity.PgThesisStudCollection.Count > 0 || entity.PgThesisStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudProvider.Save(transactionManager, entity.PgThesisStudCollection);
						
						deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStud >) DataRepository.PgThesisStudProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgOfferingTopicChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgOfferingTopic</c>
	///</summary>
	public enum PgOfferingTopicChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>PgOffering</c> at PgOfferingIdSource
		///</summary>
		[ChildEntityType(typeof(PgOffering))]
		PgOffering,
		///<summary>
		/// Collection of <c>PgOfferingTopic</c> as OneToMany for AdmAppTopicCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTopic>))]
		AdmAppTopicCollection,
		///<summary>
		/// Collection of <c>PgOfferingTopic</c> as OneToMany for PgThesisStudTopicCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStudTopic>))]
		PgThesisStudTopicCollection,
		///<summary>
		/// Collection of <c>PgOfferingTopic</c> as OneToMany for PgThesisStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStud>))]
		PgThesisStudCollection,
	}
	
	#endregion PgOfferingTopicChildEntityTypes
	
	#region PgOfferingTopicFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgOfferingTopicColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgOfferingTopic"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgOfferingTopicFilterBuilder : SqlFilterBuilder<PgOfferingTopicColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgOfferingTopicFilterBuilder class.
		/// </summary>
		public PgOfferingTopicFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgOfferingTopicFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgOfferingTopicFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgOfferingTopicFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgOfferingTopicFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgOfferingTopicFilterBuilder
	
	#region PgOfferingTopicParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgOfferingTopicColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgOfferingTopic"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgOfferingTopicParameterBuilder : ParameterizedSqlFilterBuilder<PgOfferingTopicColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgOfferingTopicParameterBuilder class.
		/// </summary>
		public PgOfferingTopicParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgOfferingTopicParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgOfferingTopicParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgOfferingTopicParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgOfferingTopicParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgOfferingTopicParameterBuilder
	
	#region PgOfferingTopicSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgOfferingTopicColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgOfferingTopic"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgOfferingTopicSortBuilder : SqlSortBuilder<PgOfferingTopicColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgOfferingTopicSqlSortBuilder class.
		/// </summary>
		public PgOfferingTopicSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgOfferingTopicSortBuilder
	
} // end namespace
