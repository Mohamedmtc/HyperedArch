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
	/// This class is the base class for any <see cref="EdCodeStateStatusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeStateStatusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeStateStatus, UMIS_VER2.BusinessLyer.EdCodeStateStatusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeStateStatusKey key)
		{
			return Delete(transactionManager, key.EdCodeStateStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeStateStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeStateStatusId)
		{
			return Delete(null, _edCodeStateStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStateStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeStateStatusId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeStateStatus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeStateStatusKey key, int start, int pageLength)
		{
			return GetByEdCodeStateStatusId(transactionManager, key.EdCodeStateStatusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_STATE_STATUS index.
		/// </summary>
		/// <param name="_edCodeStateStatusId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStateStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStateStatus GetByEdCodeStateStatusId(System.Decimal _edCodeStateStatusId)
		{
			int count = -1;
			return GetByEdCodeStateStatusId(null,_edCodeStateStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_STATE_STATUS index.
		/// </summary>
		/// <param name="_edCodeStateStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStateStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStateStatus GetByEdCodeStateStatusId(System.Decimal _edCodeStateStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStateStatusId(null, _edCodeStateStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_STATE_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStateStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStateStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStateStatus GetByEdCodeStateStatusId(TransactionManager transactionManager, System.Decimal _edCodeStateStatusId)
		{
			int count = -1;
			return GetByEdCodeStateStatusId(transactionManager, _edCodeStateStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_STATE_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStateStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStateStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStateStatus GetByEdCodeStateStatusId(TransactionManager transactionManager, System.Decimal _edCodeStateStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStateStatusId(transactionManager, _edCodeStateStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_STATE_STATUS index.
		/// </summary>
		/// <param name="_edCodeStateStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStateStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStateStatus GetByEdCodeStateStatusId(System.Decimal _edCodeStateStatusId, int start, int pageLength, out int count)
		{
			return GetByEdCodeStateStatusId(null, _edCodeStateStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_STATE_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStateStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStateStatus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeStateStatus GetByEdCodeStateStatusId(TransactionManager transactionManager, System.Decimal _edCodeStateStatusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeStateStatus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeStateStatus&gt;"/></returns>
		public static TList<EdCodeStateStatus> Fill(IDataReader reader, TList<EdCodeStateStatus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeStateStatus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeStateStatus")
					.Append("|").Append((System.Decimal)reader["ED_CODE_STATE_STATUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeStateStatus>(
					key.ToString(), // EntityTrackingKey
					"EdCodeStateStatus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeStateStatus();
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
					c.EdCodeStateStatusId = (System.Decimal)reader["ED_CODE_STATE_STATUS_ID"];
					c.OriginalEdCodeStateStatusId = c.EdCodeStateStatusId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeStateStatus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeStateStatus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeStateStatus entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeStateStatusId = (System.Decimal)reader[((int)EdCodeStateStatusColumn.EdCodeStateStatusId - 1)];
			entity.OriginalEdCodeStateStatusId = (System.Decimal)reader["ED_CODE_STATE_STATUS_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCodeStateStatusColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)EdCodeStateStatusColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeStateStatus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeStateStatus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeStateStatus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeStateStatusId = (System.Decimal)dataRow["ED_CODE_STATE_STATUS_ID"];
			entity.OriginalEdCodeStateStatusId = (System.Decimal)dataRow["ED_CODE_STATE_STATUS_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeStateStatus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeStateStatus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeStateStatus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeStateStatusId methods when available
			
			#region EdStudIntTrnsStateToCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsStateTo>|EdStudIntTrnsStateToCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsStateToCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsStateToCollection = DataRepository.EdStudIntTrnsStateToProvider.GetByEdCodeStateStatusId(transactionManager, entity.EdCodeStateStatusId);

				if (deep && entity.EdStudIntTrnsStateToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsStateToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsStateTo>) DataRepository.EdStudIntTrnsStateToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsStateToCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudStateCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudState>|EdStudStateCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudStateCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudStateCollection = DataRepository.EdStudStateProvider.GetByEdCodeStateStatusId(transactionManager, entity.EdCodeStateStatusId);

				if (deep && entity.EdStudStateCollection.Count > 0)
				{
					deepHandles.Add("EdStudStateCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudState>) DataRepository.EdStudStateProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudStateCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudStateTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudStateTemp>|EdStudStateTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudStateTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudStateTempCollection = DataRepository.EdStudStateTempProvider.GetByEdCodeStateStatusId(transactionManager, entity.EdCodeStateStatusId);

				if (deep && entity.EdStudStateTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudStateTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudStateTemp>) DataRepository.EdStudStateTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudStateTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsStateFromCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsStateFrom>|EdStudIntTrnsStateFromCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsStateFromCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsStateFromCollection = DataRepository.EdStudIntTrnsStateFromProvider.GetByEdCodeStateStatusId(transactionManager, entity.EdCodeStateStatusId);

				if (deep && entity.EdStudIntTrnsStateFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsStateFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsStateFrom>) DataRepository.EdStudIntTrnsStateFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsStateFromCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeStateStatus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeStateStatus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeStateStatus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeStateStatus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudIntTrnsStateTo>
				if (CanDeepSave(entity.EdStudIntTrnsStateToCollection, "List<EdStudIntTrnsStateTo>|EdStudIntTrnsStateToCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsStateTo child in entity.EdStudIntTrnsStateToCollection)
					{
						if(child.EdCodeStateStatusIdSource != null)
						{
							child.EdCodeStateStatusId = child.EdCodeStateStatusIdSource.EdCodeStateStatusId;
						}
						else
						{
							child.EdCodeStateStatusId = entity.EdCodeStateStatusId;
						}

					}

					if (entity.EdStudIntTrnsStateToCollection.Count > 0 || entity.EdStudIntTrnsStateToCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsStateToProvider.Save(transactionManager, entity.EdStudIntTrnsStateToCollection);
						
						deepHandles.Add("EdStudIntTrnsStateToCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsStateTo >) DataRepository.EdStudIntTrnsStateToProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsStateToCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudState>
				if (CanDeepSave(entity.EdStudStateCollection, "List<EdStudState>|EdStudStateCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudState child in entity.EdStudStateCollection)
					{
						if(child.EdCodeStateStatusIdSource != null)
						{
							child.EdCodeStateStatusId = child.EdCodeStateStatusIdSource.EdCodeStateStatusId;
						}
						else
						{
							child.EdCodeStateStatusId = entity.EdCodeStateStatusId;
						}

					}

					if (entity.EdStudStateCollection.Count > 0 || entity.EdStudStateCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudStateProvider.Save(transactionManager, entity.EdStudStateCollection);
						
						deepHandles.Add("EdStudStateCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudState >) DataRepository.EdStudStateProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudStateCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudStateTemp>
				if (CanDeepSave(entity.EdStudStateTempCollection, "List<EdStudStateTemp>|EdStudStateTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudStateTemp child in entity.EdStudStateTempCollection)
					{
						if(child.EdCodeStateStatusIdSource != null)
						{
							child.EdCodeStateStatusId = child.EdCodeStateStatusIdSource.EdCodeStateStatusId;
						}
						else
						{
							child.EdCodeStateStatusId = entity.EdCodeStateStatusId;
						}

					}

					if (entity.EdStudStateTempCollection.Count > 0 || entity.EdStudStateTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudStateTempProvider.Save(transactionManager, entity.EdStudStateTempCollection);
						
						deepHandles.Add("EdStudStateTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudStateTemp >) DataRepository.EdStudStateTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudStateTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsStateFrom>
				if (CanDeepSave(entity.EdStudIntTrnsStateFromCollection, "List<EdStudIntTrnsStateFrom>|EdStudIntTrnsStateFromCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsStateFrom child in entity.EdStudIntTrnsStateFromCollection)
					{
						if(child.EdCodeStateStatusIdSource != null)
						{
							child.EdCodeStateStatusId = child.EdCodeStateStatusIdSource.EdCodeStateStatusId;
						}
						else
						{
							child.EdCodeStateStatusId = entity.EdCodeStateStatusId;
						}

					}

					if (entity.EdStudIntTrnsStateFromCollection.Count > 0 || entity.EdStudIntTrnsStateFromCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsStateFromProvider.Save(transactionManager, entity.EdStudIntTrnsStateFromCollection);
						
						deepHandles.Add("EdStudIntTrnsStateFromCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsStateFrom >) DataRepository.EdStudIntTrnsStateFromProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsStateFromCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeStateStatusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeStateStatus</c>
	///</summary>
	public enum EdCodeStateStatusChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCodeStateStatus</c> as OneToMany for EdStudIntTrnsStateToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsStateTo>))]
		EdStudIntTrnsStateToCollection,
		///<summary>
		/// Collection of <c>EdCodeStateStatus</c> as OneToMany for EdStudStateCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudState>))]
		EdStudStateCollection,
		///<summary>
		/// Collection of <c>EdCodeStateStatus</c> as OneToMany for EdStudStateTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudStateTemp>))]
		EdStudStateTempCollection,
		///<summary>
		/// Collection of <c>EdCodeStateStatus</c> as OneToMany for EdStudIntTrnsStateFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsStateFrom>))]
		EdStudIntTrnsStateFromCollection,
	}
	
	#endregion EdCodeStateStatusChildEntityTypes
	
	#region EdCodeStateStatusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeStateStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeStateStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeStateStatusFilterBuilder : SqlFilterBuilder<EdCodeStateStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeStateStatusFilterBuilder class.
		/// </summary>
		public EdCodeStateStatusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeStateStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeStateStatusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeStateStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeStateStatusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeStateStatusFilterBuilder
	
	#region EdCodeStateStatusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeStateStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeStateStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeStateStatusParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeStateStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeStateStatusParameterBuilder class.
		/// </summary>
		public EdCodeStateStatusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeStateStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeStateStatusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeStateStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeStateStatusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeStateStatusParameterBuilder
	
	#region EdCodeStateStatusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeStateStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeStateStatus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeStateStatusSortBuilder : SqlSortBuilder<EdCodeStateStatusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeStateStatusSqlSortBuilder class.
		/// </summary>
		public EdCodeStateStatusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeStateStatusSortBuilder
	
} // end namespace
