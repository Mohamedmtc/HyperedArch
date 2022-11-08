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
	/// This class is the base class for any <see cref="GsCdeClrncReasonProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeClrncReasonProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeClrncReason, UMIS_VER2.BusinessLyer.GsCdeClrncReasonKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeClrncReasonKey key)
		{
			return Delete(transactionManager, key.GsCdeClrncReasonId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeClrncReasonId">سبب اخلاء الطرف. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeClrncReasonId)
		{
			return Delete(null, _gsCdeClrncReasonId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncReasonId">سبب اخلاء الطرف. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeClrncReasonId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeClrncReason Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeClrncReasonKey key, int start, int pageLength)
		{
			return GetByGsCdeClrncReasonId(transactionManager, key.GsCdeClrncReasonId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_DISCH_REASON index.
		/// </summary>
		/// <param name="_gsCdeClrncReasonId">سبب اخلاء الطرف</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncReason"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeClrncReason GetByGsCdeClrncReasonId(System.Decimal _gsCdeClrncReasonId)
		{
			int count = -1;
			return GetByGsCdeClrncReasonId(null,_gsCdeClrncReasonId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_DISCH_REASON index.
		/// </summary>
		/// <param name="_gsCdeClrncReasonId">سبب اخلاء الطرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncReason"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeClrncReason GetByGsCdeClrncReasonId(System.Decimal _gsCdeClrncReasonId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeClrncReasonId(null, _gsCdeClrncReasonId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_DISCH_REASON index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncReasonId">سبب اخلاء الطرف</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncReason"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeClrncReason GetByGsCdeClrncReasonId(TransactionManager transactionManager, System.Decimal _gsCdeClrncReasonId)
		{
			int count = -1;
			return GetByGsCdeClrncReasonId(transactionManager, _gsCdeClrncReasonId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_DISCH_REASON index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncReasonId">سبب اخلاء الطرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncReason"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeClrncReason GetByGsCdeClrncReasonId(TransactionManager transactionManager, System.Decimal _gsCdeClrncReasonId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeClrncReasonId(transactionManager, _gsCdeClrncReasonId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_DISCH_REASON index.
		/// </summary>
		/// <param name="_gsCdeClrncReasonId">سبب اخلاء الطرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncReason"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeClrncReason GetByGsCdeClrncReasonId(System.Decimal _gsCdeClrncReasonId, int start, int pageLength, out int count)
		{
			return GetByGsCdeClrncReasonId(null, _gsCdeClrncReasonId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_DISCH_REASON index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncReasonId">سبب اخلاء الطرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncReason"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeClrncReason GetByGsCdeClrncReasonId(TransactionManager transactionManager, System.Decimal _gsCdeClrncReasonId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeClrncReason&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeClrncReason&gt;"/></returns>
		public static TList<GsCdeClrncReason> Fill(IDataReader reader, TList<GsCdeClrncReason> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeClrncReason c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeClrncReason")
					.Append("|").Append((System.Decimal)reader["GS_CDE_CLRNC_REASON_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeClrncReason>(
					key.ToString(), // EntityTrackingKey
					"GsCdeClrncReason",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeClrncReason();
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
					c.GsCdeClrncReasonId = (System.Decimal)reader["GS_CDE_CLRNC_REASON_ID"];
					c.OriginalGsCdeClrncReasonId = c.GsCdeClrncReasonId;
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncReason"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncReason"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeClrncReason entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeClrncReasonId = (System.Decimal)reader[((int)GsCdeClrncReasonColumn.GsCdeClrncReasonId - 1)];
			entity.OriginalGsCdeClrncReasonId = (System.Decimal)reader["GS_CDE_CLRNC_REASON_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCdeClrncReasonColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)GsCdeClrncReasonColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncReason"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncReason"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeClrncReason entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeClrncReasonId = (System.Decimal)dataRow["GS_CDE_CLRNC_REASON_ID"];
			entity.OriginalGsCdeClrncReasonId = (System.Decimal)dataRow["GS_CDE_CLRNC_REASON_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncReason"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeClrncReason Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeClrncReason entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdeClrncReasonId methods when available
			
			#region EdStudClrncReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudClrncReq>|EdStudClrncReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudClrncReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudClrncReqCollection = DataRepository.EdStudClrncReqProvider.GetByGsCdeClrncReasonId(transactionManager, entity.GsCdeClrncReasonId);

				if (deep && entity.EdStudClrncReqCollection.Count > 0)
				{
					deepHandles.Add("EdStudClrncReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudClrncReq>) DataRepository.EdStudClrncReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudClrncReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCdeClrncItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCdeClrncItem>|GsCdeClrncItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeClrncItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCdeClrncItemCollection = DataRepository.GsCdeClrncItemProvider.GetByGsCdeClrncReasonId(transactionManager, entity.GsCdeClrncReasonId);

				if (deep && entity.GsCdeClrncItemCollection.Count > 0)
				{
					deepHandles.Add("GsCdeClrncItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCdeClrncItem>) DataRepository.GsCdeClrncItemProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCdeClrncItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeClrncReason object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeClrncReason instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeClrncReason Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeClrncReason entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudClrncReq>
				if (CanDeepSave(entity.EdStudClrncReqCollection, "List<EdStudClrncReq>|EdStudClrncReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudClrncReq child in entity.EdStudClrncReqCollection)
					{
						if(child.GsCdeClrncReasonIdSource != null)
						{
							child.GsCdeClrncReasonId = child.GsCdeClrncReasonIdSource.GsCdeClrncReasonId;
						}
						else
						{
							child.GsCdeClrncReasonId = entity.GsCdeClrncReasonId;
						}

					}

					if (entity.EdStudClrncReqCollection.Count > 0 || entity.EdStudClrncReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudClrncReqProvider.Save(transactionManager, entity.EdStudClrncReqCollection);
						
						deepHandles.Add("EdStudClrncReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudClrncReq >) DataRepository.EdStudClrncReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudClrncReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCdeClrncItem>
				if (CanDeepSave(entity.GsCdeClrncItemCollection, "List<GsCdeClrncItem>|GsCdeClrncItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCdeClrncItem child in entity.GsCdeClrncItemCollection)
					{
						if(child.GsCdeClrncReasonIdSource != null)
						{
							child.GsCdeClrncReasonId = child.GsCdeClrncReasonIdSource.GsCdeClrncReasonId;
						}
						else
						{
							child.GsCdeClrncReasonId = entity.GsCdeClrncReasonId;
						}

					}

					if (entity.GsCdeClrncItemCollection.Count > 0 || entity.GsCdeClrncItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCdeClrncItemProvider.Save(transactionManager, entity.GsCdeClrncItemCollection);
						
						deepHandles.Add("GsCdeClrncItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCdeClrncItem >) DataRepository.GsCdeClrncItemProvider.DeepSave,
							new object[] { transactionManager, entity.GsCdeClrncItemCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCdeClrncReasonChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeClrncReason</c>
	///</summary>
	public enum GsCdeClrncReasonChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCdeClrncReason</c> as OneToMany for EdStudClrncReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudClrncReq>))]
		EdStudClrncReqCollection,
		///<summary>
		/// Collection of <c>GsCdeClrncReason</c> as OneToMany for GsCdeClrncItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCdeClrncItem>))]
		GsCdeClrncItemCollection,
	}
	
	#endregion GsCdeClrncReasonChildEntityTypes
	
	#region GsCdeClrncReasonFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeClrncReasonColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeClrncReason"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeClrncReasonFilterBuilder : SqlFilterBuilder<GsCdeClrncReasonColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncReasonFilterBuilder class.
		/// </summary>
		public GsCdeClrncReasonFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncReasonFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeClrncReasonFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncReasonFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeClrncReasonFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeClrncReasonFilterBuilder
	
	#region GsCdeClrncReasonParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeClrncReasonColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeClrncReason"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeClrncReasonParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeClrncReasonColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncReasonParameterBuilder class.
		/// </summary>
		public GsCdeClrncReasonParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncReasonParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeClrncReasonParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncReasonParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeClrncReasonParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeClrncReasonParameterBuilder
	
	#region GsCdeClrncReasonSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeClrncReasonColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeClrncReason"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeClrncReasonSortBuilder : SqlSortBuilder<GsCdeClrncReasonColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncReasonSqlSortBuilder class.
		/// </summary>
		public GsCdeClrncReasonSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeClrncReasonSortBuilder
	
} // end namespace
