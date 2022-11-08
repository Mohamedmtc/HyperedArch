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
	/// This class is the base class for any <see cref="EdCodeLoadTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeLoadTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeLoadType, UMIS_VER2.BusinessLyer.EdCodeLoadTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeLoadTypeKey key)
		{
			return Delete(transactionManager, key.EdCodeLoadTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeLoadTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeLoadTypeId)
		{
			return Delete(null, _edCodeLoadTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLoadTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeLoadTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeLoadType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeLoadTypeKey key, int start, int pageLength)
		{
			return GetByEdCodeLoadTypeId(transactionManager, key.EdCodeLoadTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_LOAD_TYPE index.
		/// </summary>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeLoadType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeLoadType GetByEdCodeLoadTypeId(System.Decimal _edCodeLoadTypeId)
		{
			int count = -1;
			return GetByEdCodeLoadTypeId(null,_edCodeLoadTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_LOAD_TYPE index.
		/// </summary>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeLoadType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeLoadType GetByEdCodeLoadTypeId(System.Decimal _edCodeLoadTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLoadTypeId(null, _edCodeLoadTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_LOAD_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeLoadType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeLoadType GetByEdCodeLoadTypeId(TransactionManager transactionManager, System.Decimal _edCodeLoadTypeId)
		{
			int count = -1;
			return GetByEdCodeLoadTypeId(transactionManager, _edCodeLoadTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_LOAD_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeLoadType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeLoadType GetByEdCodeLoadTypeId(TransactionManager transactionManager, System.Decimal _edCodeLoadTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLoadTypeId(transactionManager, _edCodeLoadTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_LOAD_TYPE index.
		/// </summary>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeLoadType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeLoadType GetByEdCodeLoadTypeId(System.Decimal _edCodeLoadTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCodeLoadTypeId(null, _edCodeLoadTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_LOAD_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeLoadType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeLoadType GetByEdCodeLoadTypeId(TransactionManager transactionManager, System.Decimal _edCodeLoadTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeLoadType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeLoadType&gt;"/></returns>
		public static TList<EdCodeLoadType> Fill(IDataReader reader, TList<EdCodeLoadType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeLoadType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeLoadType")
					.Append("|").Append((System.Decimal)reader["ED_CODE_LOAD_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeLoadType>(
					key.ToString(), // EntityTrackingKey
					"EdCodeLoadType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeLoadType();
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
					c.EdCodeLoadTypeId = (System.Decimal)reader["ED_CODE_LOAD_TYPE_ID"];
					c.OriginalEdCodeLoadTypeId = c.EdCodeLoadTypeId;
					c.LoadDescrAr = (System.String)reader["LOAD_DESCR_AR"];
					c.LoadDescrEn = (System.String)reader["LOAD_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeLoadType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeLoadType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeLoadType entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeLoadTypeId = (System.Decimal)reader[((int)EdCodeLoadTypeColumn.EdCodeLoadTypeId - 1)];
			entity.OriginalEdCodeLoadTypeId = (System.Decimal)reader["ED_CODE_LOAD_TYPE_ID"];
			entity.LoadDescrAr = (System.String)reader[((int)EdCodeLoadTypeColumn.LoadDescrAr - 1)];
			entity.LoadDescrEn = (System.String)reader[((int)EdCodeLoadTypeColumn.LoadDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeLoadType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeLoadType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeLoadType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeLoadTypeId = (System.Decimal)dataRow["ED_CODE_LOAD_TYPE_ID"];
			entity.OriginalEdCodeLoadTypeId = (System.Decimal)dataRow["ED_CODE_LOAD_TYPE_ID"];
			entity.LoadDescrAr = (System.String)dataRow["LOAD_DESCR_AR"];
			entity.LoadDescrEn = (System.String)dataRow["LOAD_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeLoadType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeLoadType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeLoadType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeLoadTypeId methods when available
			
			#region EntPolcyGrdngHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolcyGrdngHdr>|EntPolcyGrdngHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolcyGrdngHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolcyGrdngHdrCollection = DataRepository.EntPolcyGrdngHdrProvider.GetByEdCodeLoadTypeId(transactionManager, entity.EdCodeLoadTypeId);

				if (deep && entity.EntPolcyGrdngHdrCollection.Count > 0)
				{
					deepHandles.Add("EntPolcyGrdngHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolcyGrdngHdr>) DataRepository.EntPolcyGrdngHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolcyGrdngHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyLoadCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyLoad>|EntPolicyLoadCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyLoadCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyLoadCollection = DataRepository.EntPolicyLoadProvider.GetByEdCodeLoadTypeId(transactionManager, entity.EdCodeLoadTypeId);

				if (deep && entity.EntPolicyLoadCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyLoadCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyLoad>) DataRepository.EntPolicyLoadProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyLoadCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterTempCollection = DataRepository.EdStudSemesterTempProvider.GetByEdCodeLoadTypeId(transactionManager, entity.EdCodeLoadTypeId);

				if (deep && entity.EdStudSemesterTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemesterTemp>) DataRepository.EdStudSemesterTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemester>|EdStudSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterCollection = DataRepository.EdStudSemesterProvider.GetByEdCodeLoadTypeId(transactionManager, entity.EdCodeLoadTypeId);

				if (deep && entity.EdStudSemesterCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemester>) DataRepository.EdStudSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeLoadType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeLoadType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeLoadType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeLoadType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EntPolcyGrdngHdr>
				if (CanDeepSave(entity.EntPolcyGrdngHdrCollection, "List<EntPolcyGrdngHdr>|EntPolcyGrdngHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolcyGrdngHdr child in entity.EntPolcyGrdngHdrCollection)
					{
						if(child.EdCodeLoadTypeIdSource != null)
						{
							child.EdCodeLoadTypeId = child.EdCodeLoadTypeIdSource.EdCodeLoadTypeId;
						}
						else
						{
							child.EdCodeLoadTypeId = entity.EdCodeLoadTypeId;
						}

					}

					if (entity.EntPolcyGrdngHdrCollection.Count > 0 || entity.EntPolcyGrdngHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolcyGrdngHdrProvider.Save(transactionManager, entity.EntPolcyGrdngHdrCollection);
						
						deepHandles.Add("EntPolcyGrdngHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolcyGrdngHdr >) DataRepository.EntPolcyGrdngHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolcyGrdngHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyLoad>
				if (CanDeepSave(entity.EntPolicyLoadCollection, "List<EntPolicyLoad>|EntPolicyLoadCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyLoad child in entity.EntPolicyLoadCollection)
					{
						if(child.EdCodeLoadTypeIdSource != null)
						{
							child.EdCodeLoadTypeId = child.EdCodeLoadTypeIdSource.EdCodeLoadTypeId;
						}
						else
						{
							child.EdCodeLoadTypeId = entity.EdCodeLoadTypeId;
						}

					}

					if (entity.EntPolicyLoadCollection.Count > 0 || entity.EntPolicyLoadCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyLoadProvider.Save(transactionManager, entity.EntPolicyLoadCollection);
						
						deepHandles.Add("EntPolicyLoadCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyLoad >) DataRepository.EntPolicyLoadProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyLoadCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemesterTemp>
				if (CanDeepSave(entity.EdStudSemesterTempCollection, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemesterTemp child in entity.EdStudSemesterTempCollection)
					{
						if(child.EdCodeLoadTypeIdSource != null)
						{
							child.EdCodeLoadTypeId = child.EdCodeLoadTypeIdSource.EdCodeLoadTypeId;
						}
						else
						{
							child.EdCodeLoadTypeId = entity.EdCodeLoadTypeId;
						}

					}

					if (entity.EdStudSemesterTempCollection.Count > 0 || entity.EdStudSemesterTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterTempProvider.Save(transactionManager, entity.EdStudSemesterTempCollection);
						
						deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemesterTemp >) DataRepository.EdStudSemesterTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemester>
				if (CanDeepSave(entity.EdStudSemesterCollection, "List<EdStudSemester>|EdStudSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemester child in entity.EdStudSemesterCollection)
					{
						if(child.EdCodeLoadTypeIdSource != null)
						{
							child.EdCodeLoadTypeId = child.EdCodeLoadTypeIdSource.EdCodeLoadTypeId;
						}
						else
						{
							child.EdCodeLoadTypeId = entity.EdCodeLoadTypeId;
						}

					}

					if (entity.EdStudSemesterCollection.Count > 0 || entity.EdStudSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterCollection);
						
						deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemester >) DataRepository.EdStudSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeLoadTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeLoadType</c>
	///</summary>
	public enum EdCodeLoadTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCodeLoadType</c> as OneToMany for EntPolcyGrdngHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolcyGrdngHdr>))]
		EntPolcyGrdngHdrCollection,
		///<summary>
		/// Collection of <c>EdCodeLoadType</c> as OneToMany for EntPolicyLoadCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyLoad>))]
		EntPolicyLoadCollection,
		///<summary>
		/// Collection of <c>EdCodeLoadType</c> as OneToMany for EdStudSemesterTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemesterTemp>))]
		EdStudSemesterTempCollection,
		///<summary>
		/// Collection of <c>EdCodeLoadType</c> as OneToMany for EdStudSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemester>))]
		EdStudSemesterCollection,
	}
	
	#endregion EdCodeLoadTypeChildEntityTypes
	
	#region EdCodeLoadTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeLoadTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeLoadType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeLoadTypeFilterBuilder : SqlFilterBuilder<EdCodeLoadTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeLoadTypeFilterBuilder class.
		/// </summary>
		public EdCodeLoadTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeLoadTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeLoadTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeLoadTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeLoadTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeLoadTypeFilterBuilder
	
	#region EdCodeLoadTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeLoadTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeLoadType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeLoadTypeParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeLoadTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeLoadTypeParameterBuilder class.
		/// </summary>
		public EdCodeLoadTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeLoadTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeLoadTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeLoadTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeLoadTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeLoadTypeParameterBuilder
	
	#region EdCodeLoadTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeLoadTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeLoadType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeLoadTypeSortBuilder : SqlSortBuilder<EdCodeLoadTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeLoadTypeSqlSortBuilder class.
		/// </summary>
		public EdCodeLoadTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeLoadTypeSortBuilder
	
} // end namespace
