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
	/// This class is the base class for any <see cref="SpoSponsorTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SpoSponsorTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SpoSponsorType, UMIS_VER2.BusinessLyer.SpoSponsorTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorTypeKey key)
		{
			return Delete(transactionManager, key.SpoSponsorTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_spoSponsorTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _spoSponsorTypeId)
		{
			return Delete(null, _spoSponsorTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _spoSponsorTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.SpoSponsorType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorTypeKey key, int start, int pageLength)
		{
			return GetBySpoSponsorTypeId(transactionManager, key.SpoSponsorTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SPO_SPONSER_Type index.
		/// </summary>
		/// <param name="_spoSponsorTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorType GetBySpoSponsorTypeId(System.Decimal _spoSponsorTypeId)
		{
			int count = -1;
			return GetBySpoSponsorTypeId(null,_spoSponsorTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSER_Type index.
		/// </summary>
		/// <param name="_spoSponsorTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorType GetBySpoSponsorTypeId(System.Decimal _spoSponsorTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorTypeId(null, _spoSponsorTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSER_Type index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorType GetBySpoSponsorTypeId(TransactionManager transactionManager, System.Decimal _spoSponsorTypeId)
		{
			int count = -1;
			return GetBySpoSponsorTypeId(transactionManager, _spoSponsorTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSER_Type index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorType GetBySpoSponsorTypeId(TransactionManager transactionManager, System.Decimal _spoSponsorTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorTypeId(transactionManager, _spoSponsorTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSER_Type index.
		/// </summary>
		/// <param name="_spoSponsorTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorType GetBySpoSponsorTypeId(System.Decimal _spoSponsorTypeId, int start, int pageLength, out int count)
		{
			return GetBySpoSponsorTypeId(null, _spoSponsorTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSER_Type index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SpoSponsorType GetBySpoSponsorTypeId(TransactionManager transactionManager, System.Decimal _spoSponsorTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SpoSponsorType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SpoSponsorType&gt;"/></returns>
		public static TList<SpoSponsorType> Fill(IDataReader reader, TList<SpoSponsorType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SpoSponsorType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SpoSponsorType")
					.Append("|").Append((System.Decimal)reader["SPO_SPONSOR_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SpoSponsorType>(
					key.ToString(), // EntityTrackingKey
					"SpoSponsorType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SpoSponsorType();
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
					c.SpoSponsorTypeId = (System.Decimal)reader["SPO_SPONSOR_TYPE_ID"];
					c.OriginalSpoSponsorTypeId = c.SpoSponsorTypeId;
					c.NameAr = Convert.IsDBNull(reader["NAME_AR"]) ? null : (System.String)reader["NAME_AR"];
					c.NameEn = Convert.IsDBNull(reader["NAME_EN"]) ? null : (System.String)reader["NAME_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsorType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SpoSponsorType entity)
		{
			if (!reader.Read()) return;
			
			entity.SpoSponsorTypeId = (System.Decimal)reader[((int)SpoSponsorTypeColumn.SpoSponsorTypeId - 1)];
			entity.OriginalSpoSponsorTypeId = (System.Decimal)reader["SPO_SPONSOR_TYPE_ID"];
			entity.NameAr = (reader.IsDBNull(((int)SpoSponsorTypeColumn.NameAr - 1)))?null:(System.String)reader[((int)SpoSponsorTypeColumn.NameAr - 1)];
			entity.NameEn = (reader.IsDBNull(((int)SpoSponsorTypeColumn.NameEn - 1)))?null:(System.String)reader[((int)SpoSponsorTypeColumn.NameEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsorType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SpoSponsorType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SpoSponsorTypeId = (System.Decimal)dataRow["SPO_SPONSOR_TYPE_ID"];
			entity.OriginalSpoSponsorTypeId = (System.Decimal)dataRow["SPO_SPONSOR_TYPE_ID"];
			entity.NameAr = Convert.IsDBNull(dataRow["NAME_AR"]) ? null : (System.String)dataRow["NAME_AR"];
			entity.NameEn = Convert.IsDBNull(dataRow["NAME_EN"]) ? null : (System.String)dataRow["NAME_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsorType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoSponsorType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySpoSponsorTypeId methods when available
			
			#region AdmReqDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmReqDoc>|AdmReqDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmReqDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmReqDocCollection = DataRepository.AdmReqDocProvider.GetBySpoSponsorTypeId(transactionManager, entity.SpoSponsorTypeId);

				if (deep && entity.AdmReqDocCollection.Count > 0)
				{
					deepHandles.Add("AdmReqDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmReqDoc>) DataRepository.AdmReqDocProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmReqDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsor>|SpoSponsorCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorCollection = DataRepository.SpoSponsorProvider.GetBySpoSponserTypeId(transactionManager, entity.SpoSponsorTypeId);

				if (deep && entity.SpoSponsorCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsor>) DataRepository.SpoSponsorProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppRegHistoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppRegHistoryCollection = DataRepository.AdmAppRegHistoryProvider.GetBySpoSponsorTypeId(transactionManager, entity.SpoSponsorTypeId);

				if (deep && entity.AdmAppRegHistoryCollection.Count > 0)
				{
					deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppRegHistory>) DataRepository.AdmAppRegHistoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SpoSponsorType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SpoSponsorType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoSponsorType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AdmReqDoc>
				if (CanDeepSave(entity.AdmReqDocCollection, "List<AdmReqDoc>|AdmReqDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmReqDoc child in entity.AdmReqDocCollection)
					{
						if(child.SpoSponsorTypeIdSource != null)
						{
							child.SpoSponsorTypeId = child.SpoSponsorTypeIdSource.SpoSponsorTypeId;
						}
						else
						{
							child.SpoSponsorTypeId = entity.SpoSponsorTypeId;
						}

					}

					if (entity.AdmReqDocCollection.Count > 0 || entity.AdmReqDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmReqDocProvider.Save(transactionManager, entity.AdmReqDocCollection);
						
						deepHandles.Add("AdmReqDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmReqDoc >) DataRepository.AdmReqDocProvider.DeepSave,
							new object[] { transactionManager, entity.AdmReqDocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsor>
				if (CanDeepSave(entity.SpoSponsorCollection, "List<SpoSponsor>|SpoSponsorCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsor child in entity.SpoSponsorCollection)
					{
						if(child.SpoSponserTypeIdSource != null)
						{
							child.SpoSponserTypeId = child.SpoSponserTypeIdSource.SpoSponsorTypeId;
						}
						else
						{
							child.SpoSponserTypeId = entity.SpoSponsorTypeId;
						}

					}

					if (entity.SpoSponsorCollection.Count > 0 || entity.SpoSponsorCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorProvider.Save(transactionManager, entity.SpoSponsorCollection);
						
						deepHandles.Add("SpoSponsorCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsor >) DataRepository.SpoSponsorProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppRegHistory>
				if (CanDeepSave(entity.AdmAppRegHistoryCollection, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppRegHistory child in entity.AdmAppRegHistoryCollection)
					{
						if(child.SpoSponsorTypeIdSource != null)
						{
							child.SpoSponsorTypeId = child.SpoSponsorTypeIdSource.SpoSponsorTypeId;
						}
						else
						{
							child.SpoSponsorTypeId = entity.SpoSponsorTypeId;
						}

					}

					if (entity.AdmAppRegHistoryCollection.Count > 0 || entity.AdmAppRegHistoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryCollection);
						
						deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppRegHistory >) DataRepository.AdmAppRegHistoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deepSaveType, childTypes, innerList }
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
	
	#region SpoSponsorTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SpoSponsorType</c>
	///</summary>
	public enum SpoSponsorTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SpoSponsorType</c> as OneToMany for AdmReqDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmReqDoc>))]
		AdmReqDocCollection,
		///<summary>
		/// Collection of <c>SpoSponsorType</c> as OneToMany for SpoSponsorCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsor>))]
		SpoSponsorCollection,
		///<summary>
		/// Collection of <c>SpoSponsorType</c> as OneToMany for AdmAppRegHistoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppRegHistory>))]
		AdmAppRegHistoryCollection,
	}
	
	#endregion SpoSponsorTypeChildEntityTypes
	
	#region SpoSponsorTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SpoSponsorTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsorType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoSponsorTypeFilterBuilder : SqlFilterBuilder<SpoSponsorTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorTypeFilterBuilder class.
		/// </summary>
		public SpoSponsorTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoSponsorTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoSponsorTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoSponsorTypeFilterBuilder
	
	#region SpoSponsorTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SpoSponsorTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsorType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoSponsorTypeParameterBuilder : ParameterizedSqlFilterBuilder<SpoSponsorTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorTypeParameterBuilder class.
		/// </summary>
		public SpoSponsorTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoSponsorTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoSponsorTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoSponsorTypeParameterBuilder
	
	#region SpoSponsorTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SpoSponsorTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsorType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SpoSponsorTypeSortBuilder : SqlSortBuilder<SpoSponsorTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorTypeSqlSortBuilder class.
		/// </summary>
		public SpoSponsorTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SpoSponsorTypeSortBuilder
	
} // end namespace
