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
	/// This class is the base class for any <see cref="FeeCdeTrsryProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeCdeTrsryProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeCdeTrsry, UMIS_VER2.BusinessLyer.FeeCdeTrsryKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeTrsryKey key)
		{
			return Delete(transactionManager, key.FeeCdeTrsryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeCdeTrsryId">اكواد بنود الخزنة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _feeCdeTrsryId)
		{
			return Delete(null, _feeCdeTrsryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeTrsryId">اكواد بنود الخزنة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _feeCdeTrsryId);		
		
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
		public override UMIS_VER2.BusinessLyer.FeeCdeTrsry Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeTrsryKey key, int start, int pageLength)
		{
			return GetByFeeCdeTrsryId(transactionManager, key.FeeCdeTrsryId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_CDE_TRSRY index.
		/// </summary>
		/// <param name="_feeCdeTrsryId">اكواد بنود الخزنة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrsry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeTrsry GetByFeeCdeTrsryId(System.Int32 _feeCdeTrsryId)
		{
			int count = -1;
			return GetByFeeCdeTrsryId(null,_feeCdeTrsryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_TRSRY index.
		/// </summary>
		/// <param name="_feeCdeTrsryId">اكواد بنود الخزنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrsry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeTrsry GetByFeeCdeTrsryId(System.Int32 _feeCdeTrsryId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeTrsryId(null, _feeCdeTrsryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_TRSRY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeTrsryId">اكواد بنود الخزنة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrsry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeTrsry GetByFeeCdeTrsryId(TransactionManager transactionManager, System.Int32 _feeCdeTrsryId)
		{
			int count = -1;
			return GetByFeeCdeTrsryId(transactionManager, _feeCdeTrsryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_TRSRY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeTrsryId">اكواد بنود الخزنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrsry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeTrsry GetByFeeCdeTrsryId(TransactionManager transactionManager, System.Int32 _feeCdeTrsryId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeTrsryId(transactionManager, _feeCdeTrsryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_TRSRY index.
		/// </summary>
		/// <param name="_feeCdeTrsryId">اكواد بنود الخزنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrsry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeTrsry GetByFeeCdeTrsryId(System.Int32 _feeCdeTrsryId, int start, int pageLength, out int count)
		{
			return GetByFeeCdeTrsryId(null, _feeCdeTrsryId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_TRSRY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeTrsryId">اكواد بنود الخزنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrsry"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCdeTrsry GetByFeeCdeTrsryId(TransactionManager transactionManager, System.Int32 _feeCdeTrsryId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeCdeTrsry&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeCdeTrsry&gt;"/></returns>
		public static TList<FeeCdeTrsry> Fill(IDataReader reader, TList<FeeCdeTrsry> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeCdeTrsry c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeCdeTrsry")
					.Append("|").Append((System.Int32)reader["FEE_CDE_TRSRY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeCdeTrsry>(
					key.ToString(), // EntityTrackingKey
					"FeeCdeTrsry",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeCdeTrsry();
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
					c.FeeCdeTrsryId = (System.Int32)reader["FEE_CDE_TRSRY_ID"];
					c.OriginalFeeCdeTrsryId = c.FeeCdeTrsryId;
					c.TrsryAr = (System.String)reader["TRSRY_AR"];
					c.TrsryEn = Convert.IsDBNull(reader["TRSRY_EN"]) ? null : (System.String)reader["TRSRY_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrsry"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrsry"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeCdeTrsry entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeCdeTrsryId = (System.Int32)reader[((int)FeeCdeTrsryColumn.FeeCdeTrsryId - 1)];
			entity.OriginalFeeCdeTrsryId = (System.Int32)reader["FEE_CDE_TRSRY_ID"];
			entity.TrsryAr = (System.String)reader[((int)FeeCdeTrsryColumn.TrsryAr - 1)];
			entity.TrsryEn = (reader.IsDBNull(((int)FeeCdeTrsryColumn.TrsryEn - 1)))?null:(System.String)reader[((int)FeeCdeTrsryColumn.TrsryEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrsry"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrsry"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeCdeTrsry entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeCdeTrsryId = (System.Int32)dataRow["FEE_CDE_TRSRY_ID"];
			entity.OriginalFeeCdeTrsryId = (System.Int32)dataRow["FEE_CDE_TRSRY_ID"];
			entity.TrsryAr = (System.String)dataRow["TRSRY_AR"];
			entity.TrsryEn = Convert.IsDBNull(dataRow["TRSRY_EN"]) ? null : (System.String)dataRow["TRSRY_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrsry"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeTrsry Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeTrsry entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeCdeTrsryId methods when available
			
			#region FeeTreasuryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeTreasury>|FeeTreasuryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeTreasuryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeTreasuryCollection = DataRepository.FeeTreasuryProvider.GetByFeeCdeTrsryId(transactionManager, entity.FeeCdeTrsryId);

				if (deep && entity.FeeTreasuryCollection.Count > 0)
				{
					deepHandles.Add("FeeTreasuryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeTreasury>) DataRepository.FeeTreasuryProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeTreasuryCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeCdeTrsry object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeCdeTrsry instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeTrsry Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeTrsry entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<FeeTreasury>
				if (CanDeepSave(entity.FeeTreasuryCollection, "List<FeeTreasury>|FeeTreasuryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeTreasury child in entity.FeeTreasuryCollection)
					{
						if(child.FeeCdeTrsryIdSource != null)
						{
							child.FeeCdeTrsryId = child.FeeCdeTrsryIdSource.FeeCdeTrsryId;
						}
						else
						{
							child.FeeCdeTrsryId = entity.FeeCdeTrsryId;
						}

					}

					if (entity.FeeTreasuryCollection.Count > 0 || entity.FeeTreasuryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeTreasuryProvider.Save(transactionManager, entity.FeeTreasuryCollection);
						
						deepHandles.Add("FeeTreasuryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeTreasury >) DataRepository.FeeTreasuryProvider.DeepSave,
							new object[] { transactionManager, entity.FeeTreasuryCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeCdeTrsryChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeCdeTrsry</c>
	///</summary>
	public enum FeeCdeTrsryChildEntityTypes
	{
		///<summary>
		/// Collection of <c>FeeCdeTrsry</c> as OneToMany for FeeTreasuryCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeTreasury>))]
		FeeTreasuryCollection,
	}
	
	#endregion FeeCdeTrsryChildEntityTypes
	
	#region FeeCdeTrsryFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeCdeTrsryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeTrsry"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeTrsryFilterBuilder : SqlFilterBuilder<FeeCdeTrsryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeTrsryFilterBuilder class.
		/// </summary>
		public FeeCdeTrsryFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeTrsryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeTrsryFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeTrsryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeTrsryFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeTrsryFilterBuilder
	
	#region FeeCdeTrsryParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeCdeTrsryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeTrsry"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeTrsryParameterBuilder : ParameterizedSqlFilterBuilder<FeeCdeTrsryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeTrsryParameterBuilder class.
		/// </summary>
		public FeeCdeTrsryParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeTrsryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeTrsryParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeTrsryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeTrsryParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeTrsryParameterBuilder
	
	#region FeeCdeTrsrySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeCdeTrsryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeTrsry"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeCdeTrsrySortBuilder : SqlSortBuilder<FeeCdeTrsryColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeTrsrySqlSortBuilder class.
		/// </summary>
		public FeeCdeTrsrySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeCdeTrsrySortBuilder
	
} // end namespace
