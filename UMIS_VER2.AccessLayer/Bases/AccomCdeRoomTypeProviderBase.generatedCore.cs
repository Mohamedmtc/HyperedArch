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
	/// This class is the base class for any <see cref="AccomCdeRoomTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomCdeRoomTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomCdeRoomType, UMIS_VER2.BusinessLyer.AccomCdeRoomTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeRoomTypeKey key)
		{
			return Delete(transactionManager, key.AccomCdeRoomTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _accomCdeRoomTypeId)
		{
			return Delete(null, _accomCdeRoomTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _accomCdeRoomTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.AccomCdeRoomType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeRoomTypeKey key, int start, int pageLength)
		{
			return GetByAccomCdeRoomTypeId(transactionManager, key.AccomCdeRoomTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_CDE_ROOM_TYPE index.
		/// </summary>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeRoomType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeRoomType GetByAccomCdeRoomTypeId(System.Int32 _accomCdeRoomTypeId)
		{
			int count = -1;
			return GetByAccomCdeRoomTypeId(null,_accomCdeRoomTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_ROOM_TYPE index.
		/// </summary>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeRoomType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeRoomType GetByAccomCdeRoomTypeId(System.Int32 _accomCdeRoomTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdeRoomTypeId(null, _accomCdeRoomTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_ROOM_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeRoomType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeRoomType GetByAccomCdeRoomTypeId(TransactionManager transactionManager, System.Int32 _accomCdeRoomTypeId)
		{
			int count = -1;
			return GetByAccomCdeRoomTypeId(transactionManager, _accomCdeRoomTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_ROOM_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeRoomType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeRoomType GetByAccomCdeRoomTypeId(TransactionManager transactionManager, System.Int32 _accomCdeRoomTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdeRoomTypeId(transactionManager, _accomCdeRoomTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_ROOM_TYPE index.
		/// </summary>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeRoomType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeRoomType GetByAccomCdeRoomTypeId(System.Int32 _accomCdeRoomTypeId, int start, int pageLength, out int count)
		{
			return GetByAccomCdeRoomTypeId(null, _accomCdeRoomTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_ROOM_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeRoomType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomCdeRoomType GetByAccomCdeRoomTypeId(TransactionManager transactionManager, System.Int32 _accomCdeRoomTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomCdeRoomType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomCdeRoomType&gt;"/></returns>
		public static TList<AccomCdeRoomType> Fill(IDataReader reader, TList<AccomCdeRoomType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomCdeRoomType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomCdeRoomType")
					.Append("|").Append((System.Int32)reader["ACCOM_CDE_ROOM_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomCdeRoomType>(
					key.ToString(), // EntityTrackingKey
					"AccomCdeRoomType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomCdeRoomType();
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
					c.AccomCdeRoomTypeId = (System.Int32)reader["ACCOM_CDE_ROOM_TYPE_ID"];
					c.OriginalAccomCdeRoomTypeId = c.AccomCdeRoomTypeId;
					c.RoomTypeAr = Convert.IsDBNull(reader["ROOM_TYPE_AR"]) ? null : (System.String)reader["ROOM_TYPE_AR"];
					c.RoomTypeEn = Convert.IsDBNull(reader["ROOM_TYPE_EN"]) ? null : (System.String)reader["ROOM_TYPE_EN"];
					c.BedCount = Convert.IsDBNull(reader["BED_COUNT"]) ? null : (System.Int32?)reader["BED_COUNT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomCdeRoomType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdeRoomType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomCdeRoomType entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomCdeRoomTypeId = (System.Int32)reader[((int)AccomCdeRoomTypeColumn.AccomCdeRoomTypeId - 1)];
			entity.OriginalAccomCdeRoomTypeId = (System.Int32)reader["ACCOM_CDE_ROOM_TYPE_ID"];
			entity.RoomTypeAr = (reader.IsDBNull(((int)AccomCdeRoomTypeColumn.RoomTypeAr - 1)))?null:(System.String)reader[((int)AccomCdeRoomTypeColumn.RoomTypeAr - 1)];
			entity.RoomTypeEn = (reader.IsDBNull(((int)AccomCdeRoomTypeColumn.RoomTypeEn - 1)))?null:(System.String)reader[((int)AccomCdeRoomTypeColumn.RoomTypeEn - 1)];
			entity.BedCount = (reader.IsDBNull(((int)AccomCdeRoomTypeColumn.BedCount - 1)))?null:(System.Int32?)reader[((int)AccomCdeRoomTypeColumn.BedCount - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomCdeRoomType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdeRoomType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomCdeRoomType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomCdeRoomTypeId = (System.Int32)dataRow["ACCOM_CDE_ROOM_TYPE_ID"];
			entity.OriginalAccomCdeRoomTypeId = (System.Int32)dataRow["ACCOM_CDE_ROOM_TYPE_ID"];
			entity.RoomTypeAr = Convert.IsDBNull(dataRow["ROOM_TYPE_AR"]) ? null : (System.String)dataRow["ROOM_TYPE_AR"];
			entity.RoomTypeEn = Convert.IsDBNull(dataRow["ROOM_TYPE_EN"]) ? null : (System.String)dataRow["ROOM_TYPE_EN"];
			entity.BedCount = Convert.IsDBNull(dataRow["BED_COUNT"]) ? null : (System.Int32?)dataRow["BED_COUNT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdeRoomType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomCdeRoomType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeRoomType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAccomCdeRoomTypeId methods when available
			
			#region AccomRoomCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomRoom>|AccomRoomCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomRoomCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomRoomCollection = DataRepository.AccomRoomProvider.GetByAccomCdeRoomTypeId(transactionManager, entity.AccomCdeRoomTypeId);

				if (deep && entity.AccomRoomCollection.Count > 0)
				{
					deepHandles.Add("AccomRoomCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomRoom>) DataRepository.AccomRoomProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomRoomCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudReq>|AccomStudReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudReqCollection = DataRepository.AccomStudReqProvider.GetByAccomCdeRoomTypeId(transactionManager, entity.AccomCdeRoomTypeId);

				if (deep && entity.AccomStudReqCollection.Count > 0)
				{
					deepHandles.Add("AccomStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudReq>) DataRepository.AccomStudReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudReqCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomCdeRoomType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomCdeRoomType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomCdeRoomType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeRoomType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AccomRoom>
				if (CanDeepSave(entity.AccomRoomCollection, "List<AccomRoom>|AccomRoomCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomRoom child in entity.AccomRoomCollection)
					{
						if(child.AccomCdeRoomTypeIdSource != null)
						{
							child.AccomCdeRoomTypeId = child.AccomCdeRoomTypeIdSource.AccomCdeRoomTypeId;
						}
						else
						{
							child.AccomCdeRoomTypeId = entity.AccomCdeRoomTypeId;
						}

					}

					if (entity.AccomRoomCollection.Count > 0 || entity.AccomRoomCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomRoomProvider.Save(transactionManager, entity.AccomRoomCollection);
						
						deepHandles.Add("AccomRoomCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomRoom >) DataRepository.AccomRoomProvider.DeepSave,
							new object[] { transactionManager, entity.AccomRoomCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudReq>
				if (CanDeepSave(entity.AccomStudReqCollection, "List<AccomStudReq>|AccomStudReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudReq child in entity.AccomStudReqCollection)
					{
						if(child.AccomCdeRoomTypeIdSource != null)
						{
							child.AccomCdeRoomTypeId = child.AccomCdeRoomTypeIdSource.AccomCdeRoomTypeId;
						}
						else
						{
							child.AccomCdeRoomTypeId = entity.AccomCdeRoomTypeId;
						}

					}

					if (entity.AccomStudReqCollection.Count > 0 || entity.AccomStudReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudReqProvider.Save(transactionManager, entity.AccomStudReqCollection);
						
						deepHandles.Add("AccomStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudReq >) DataRepository.AccomStudReqProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudReqCollection, deepSaveType, childTypes, innerList }
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
	
	#region AccomCdeRoomTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomCdeRoomType</c>
	///</summary>
	public enum AccomCdeRoomTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AccomCdeRoomType</c> as OneToMany for AccomRoomCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomRoom>))]
		AccomRoomCollection,
		///<summary>
		/// Collection of <c>AccomCdeRoomType</c> as OneToMany for AccomStudReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudReq>))]
		AccomStudReqCollection,
	}
	
	#endregion AccomCdeRoomTypeChildEntityTypes
	
	#region AccomCdeRoomTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomCdeRoomTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdeRoomType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomCdeRoomTypeFilterBuilder : SqlFilterBuilder<AccomCdeRoomTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdeRoomTypeFilterBuilder class.
		/// </summary>
		public AccomCdeRoomTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeRoomTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomCdeRoomTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeRoomTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomCdeRoomTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomCdeRoomTypeFilterBuilder
	
	#region AccomCdeRoomTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomCdeRoomTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdeRoomType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomCdeRoomTypeParameterBuilder : ParameterizedSqlFilterBuilder<AccomCdeRoomTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdeRoomTypeParameterBuilder class.
		/// </summary>
		public AccomCdeRoomTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeRoomTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomCdeRoomTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeRoomTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomCdeRoomTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomCdeRoomTypeParameterBuilder
	
	#region AccomCdeRoomTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomCdeRoomTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdeRoomType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomCdeRoomTypeSortBuilder : SqlSortBuilder<AccomCdeRoomTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdeRoomTypeSqlSortBuilder class.
		/// </summary>
		public AccomCdeRoomTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomCdeRoomTypeSortBuilder
	
} // end namespace
