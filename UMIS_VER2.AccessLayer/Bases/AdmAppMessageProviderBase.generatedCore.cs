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
	/// This class is the base class for any <see cref="AdmAppMessageProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppMessageProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppMessage, UMIS_VER2.BusinessLyer.AdmAppMessageKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppMessageKey key)
		{
			return Delete(transactionManager, key.AdmAppMessageId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppMessageId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppMessageId)
		{
			return Delete(null, _admAppMessageId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppMessageId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppMessageId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppMessage Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppMessageKey key, int start, int pageLength)
		{
			return GetByAdmAppMessageId(transactionManager, key.AdmAppMessageId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_MESSAGE index.
		/// </summary>
		/// <param name="_admAppMessageId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppMessage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppMessage GetByAdmAppMessageId(System.Decimal _admAppMessageId)
		{
			int count = -1;
			return GetByAdmAppMessageId(null,_admAppMessageId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_MESSAGE index.
		/// </summary>
		/// <param name="_admAppMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppMessage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppMessage GetByAdmAppMessageId(System.Decimal _admAppMessageId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppMessageId(null, _admAppMessageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_MESSAGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppMessageId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppMessage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppMessage GetByAdmAppMessageId(TransactionManager transactionManager, System.Decimal _admAppMessageId)
		{
			int count = -1;
			return GetByAdmAppMessageId(transactionManager, _admAppMessageId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_MESSAGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppMessage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppMessage GetByAdmAppMessageId(TransactionManager transactionManager, System.Decimal _admAppMessageId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppMessageId(transactionManager, _admAppMessageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_MESSAGE index.
		/// </summary>
		/// <param name="_admAppMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppMessage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppMessage GetByAdmAppMessageId(System.Decimal _admAppMessageId, int start, int pageLength, out int count)
		{
			return GetByAdmAppMessageId(null, _admAppMessageId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_MESSAGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppMessage"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppMessage GetByAdmAppMessageId(TransactionManager transactionManager, System.Decimal _admAppMessageId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppMessage&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppMessage&gt;"/></returns>
		public static TList<AdmAppMessage> Fill(IDataReader reader, TList<AdmAppMessage> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppMessage c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppMessage")
					.Append("|").Append((System.Decimal)reader["ADM_APP_MESSAGE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppMessage>(
					key.ToString(), // EntityTrackingKey
					"AdmAppMessage",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppMessage();
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
					c.AdmAppMessageId = (System.Decimal)reader["ADM_APP_MESSAGE_ID"];
					c.OriginalAdmAppMessageId = c.AdmAppMessageId;
					c.MsgSubj = (System.String)reader["MSG_SUBJ"];
					c.MsgBody = (System.String)reader["MSG_BODY"];
					c.MsgDate = (System.DateTime)reader["MSG_DATE"];
					c.FailFlg = (System.Decimal)reader["FAIL_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppMessage"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppMessage"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppMessage entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppMessageId = (System.Decimal)reader[((int)AdmAppMessageColumn.AdmAppMessageId - 1)];
			entity.OriginalAdmAppMessageId = (System.Decimal)reader["ADM_APP_MESSAGE_ID"];
			entity.MsgSubj = (System.String)reader[((int)AdmAppMessageColumn.MsgSubj - 1)];
			entity.MsgBody = (System.String)reader[((int)AdmAppMessageColumn.MsgBody - 1)];
			entity.MsgDate = (System.DateTime)reader[((int)AdmAppMessageColumn.MsgDate - 1)];
			entity.FailFlg = (System.Decimal)reader[((int)AdmAppMessageColumn.FailFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppMessage"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppMessage"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppMessage entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppMessageId = (System.Decimal)dataRow["ADM_APP_MESSAGE_ID"];
			entity.OriginalAdmAppMessageId = (System.Decimal)dataRow["ADM_APP_MESSAGE_ID"];
			entity.MsgSubj = (System.String)dataRow["MSG_SUBJ"];
			entity.MsgBody = (System.String)dataRow["MSG_BODY"];
			entity.MsgDate = (System.DateTime)dataRow["MSG_DATE"];
			entity.FailFlg = (System.Decimal)dataRow["FAIL_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppMessage"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppMessage Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppMessage entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmAppMessageId methods when available
			
			#region AdmOutboxCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmOutbox>|AdmOutboxCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmOutboxCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmOutboxCollection = DataRepository.AdmOutboxProvider.GetByAdmAppMessageId(transactionManager, entity.AdmAppMessageId);

				if (deep && entity.AdmOutboxCollection.Count > 0)
				{
					deepHandles.Add("AdmOutboxCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmOutbox>) DataRepository.AdmOutboxProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmOutboxCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmInboxCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmInbox>|AdmInboxCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmInboxCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmInboxCollection = DataRepository.AdmInboxProvider.GetByAdmAppMessageId(transactionManager, entity.AdmAppMessageId);

				if (deep && entity.AdmInboxCollection.Count > 0)
				{
					deepHandles.Add("AdmInboxCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmInbox>) DataRepository.AdmInboxProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmInboxCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppMessage object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppMessage instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppMessage Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppMessage entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AdmOutbox>
				if (CanDeepSave(entity.AdmOutboxCollection, "List<AdmOutbox>|AdmOutboxCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmOutbox child in entity.AdmOutboxCollection)
					{
						if(child.AdmAppMessageIdSource != null)
						{
							child.AdmAppMessageId = child.AdmAppMessageIdSource.AdmAppMessageId;
						}
						else
						{
							child.AdmAppMessageId = entity.AdmAppMessageId;
						}

					}

					if (entity.AdmOutboxCollection.Count > 0 || entity.AdmOutboxCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmOutboxProvider.Save(transactionManager, entity.AdmOutboxCollection);
						
						deepHandles.Add("AdmOutboxCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmOutbox >) DataRepository.AdmOutboxProvider.DeepSave,
							new object[] { transactionManager, entity.AdmOutboxCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmInbox>
				if (CanDeepSave(entity.AdmInboxCollection, "List<AdmInbox>|AdmInboxCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmInbox child in entity.AdmInboxCollection)
					{
						if(child.AdmAppMessageIdSource != null)
						{
							child.AdmAppMessageId = child.AdmAppMessageIdSource.AdmAppMessageId;
						}
						else
						{
							child.AdmAppMessageId = entity.AdmAppMessageId;
						}

					}

					if (entity.AdmInboxCollection.Count > 0 || entity.AdmInboxCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmInboxProvider.Save(transactionManager, entity.AdmInboxCollection);
						
						deepHandles.Add("AdmInboxCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmInbox >) DataRepository.AdmInboxProvider.DeepSave,
							new object[] { transactionManager, entity.AdmInboxCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmAppMessageChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppMessage</c>
	///</summary>
	public enum AdmAppMessageChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AdmAppMessage</c> as OneToMany for AdmOutboxCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmOutbox>))]
		AdmOutboxCollection,
		///<summary>
		/// Collection of <c>AdmAppMessage</c> as OneToMany for AdmInboxCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmInbox>))]
		AdmInboxCollection,
	}
	
	#endregion AdmAppMessageChildEntityTypes
	
	#region AdmAppMessageFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppMessageColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppMessage"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppMessageFilterBuilder : SqlFilterBuilder<AdmAppMessageColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppMessageFilterBuilder class.
		/// </summary>
		public AdmAppMessageFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppMessageFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppMessageFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppMessageFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppMessageFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppMessageFilterBuilder
	
	#region AdmAppMessageParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppMessageColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppMessage"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppMessageParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppMessageColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppMessageParameterBuilder class.
		/// </summary>
		public AdmAppMessageParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppMessageParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppMessageParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppMessageParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppMessageParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppMessageParameterBuilder
	
	#region AdmAppMessageSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppMessageColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppMessage"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppMessageSortBuilder : SqlSortBuilder<AdmAppMessageColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppMessageSqlSortBuilder class.
		/// </summary>
		public AdmAppMessageSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppMessageSortBuilder
	
} // end namespace
