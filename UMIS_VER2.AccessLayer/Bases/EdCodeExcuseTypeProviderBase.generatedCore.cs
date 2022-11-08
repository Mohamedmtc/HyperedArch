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
	/// This class is the base class for any <see cref="EdCodeExcuseTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeExcuseTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeExcuseType, UMIS_VER2.BusinessLyer.EdCodeExcuseTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeExcuseTypeKey key)
		{
			return Delete(transactionManager, key.EdCodeExcuseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeExcuseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeExcuseId)
		{
			return Delete(null, _edCodeExcuseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeExcuseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeExcuseId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeExcuseType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeExcuseTypeKey key, int start, int pageLength)
		{
			return GetByEdCodeExcuseId(transactionManager, key.EdCodeExcuseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_EXCUSE index.
		/// </summary>
		/// <param name="_edCodeExcuseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeExcuseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeExcuseType GetByEdCodeExcuseId(System.Decimal _edCodeExcuseId)
		{
			int count = -1;
			return GetByEdCodeExcuseId(null,_edCodeExcuseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_EXCUSE index.
		/// </summary>
		/// <param name="_edCodeExcuseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeExcuseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeExcuseType GetByEdCodeExcuseId(System.Decimal _edCodeExcuseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeExcuseId(null, _edCodeExcuseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_EXCUSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeExcuseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeExcuseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeExcuseType GetByEdCodeExcuseId(TransactionManager transactionManager, System.Decimal _edCodeExcuseId)
		{
			int count = -1;
			return GetByEdCodeExcuseId(transactionManager, _edCodeExcuseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_EXCUSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeExcuseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeExcuseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeExcuseType GetByEdCodeExcuseId(TransactionManager transactionManager, System.Decimal _edCodeExcuseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeExcuseId(transactionManager, _edCodeExcuseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_EXCUSE index.
		/// </summary>
		/// <param name="_edCodeExcuseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeExcuseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeExcuseType GetByEdCodeExcuseId(System.Decimal _edCodeExcuseId, int start, int pageLength, out int count)
		{
			return GetByEdCodeExcuseId(null, _edCodeExcuseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_EXCUSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeExcuseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeExcuseType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeExcuseType GetByEdCodeExcuseId(TransactionManager transactionManager, System.Decimal _edCodeExcuseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeExcuseType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeExcuseType&gt;"/></returns>
		public static TList<EdCodeExcuseType> Fill(IDataReader reader, TList<EdCodeExcuseType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeExcuseType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeExcuseType")
					.Append("|").Append((System.Decimal)reader["ED_CODE_EXCUSE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeExcuseType>(
					key.ToString(), // EntityTrackingKey
					"EdCodeExcuseType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeExcuseType();
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
					c.EdCodeExcuseId = (System.Decimal)reader["ED_CODE_EXCUSE_ID"];
					c.OriginalEdCodeExcuseId = c.EdCodeExcuseId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.ExcuseCode = Convert.IsDBNull(reader["EXCUSE_CODE"]) ? null : (System.String)reader["EXCUSE_CODE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeExcuseType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeExcuseType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeExcuseType entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeExcuseId = (System.Decimal)reader[((int)EdCodeExcuseTypeColumn.EdCodeExcuseId - 1)];
			entity.OriginalEdCodeExcuseId = (System.Decimal)reader["ED_CODE_EXCUSE_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCodeExcuseTypeColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EdCodeExcuseTypeColumn.DescrEn - 1)))?null:(System.String)reader[((int)EdCodeExcuseTypeColumn.DescrEn - 1)];
			entity.ExcuseCode = (reader.IsDBNull(((int)EdCodeExcuseTypeColumn.ExcuseCode - 1)))?null:(System.String)reader[((int)EdCodeExcuseTypeColumn.ExcuseCode - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeExcuseType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeExcuseType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeExcuseType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeExcuseId = (System.Decimal)dataRow["ED_CODE_EXCUSE_ID"];
			entity.OriginalEdCodeExcuseId = (System.Decimal)dataRow["ED_CODE_EXCUSE_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.ExcuseCode = Convert.IsDBNull(dataRow["EXCUSE_CODE"]) ? null : (System.String)dataRow["EXCUSE_CODE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeExcuseType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeExcuseType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeExcuseType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeExcuseId methods when available
			
			#region EntPolicyExcuseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyExcuse>|EntPolicyExcuseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyExcuseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyExcuseCollection = DataRepository.EntPolicyExcuseProvider.GetByEdCodeExcuseTypeId(transactionManager, entity.EdCodeExcuseId);

				if (deep && entity.EntPolicyExcuseCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyExcuse>) DataRepository.EntPolicyExcuseProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyExcuseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExcuseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExcuse>|EdStudExcuseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExcuseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExcuseCollection = DataRepository.EdStudExcuseProvider.GetByEdCodeExcuseTypeId(transactionManager, entity.EdCodeExcuseId);

				if (deep && entity.EdStudExcuseCollection.Count > 0)
				{
					deepHandles.Add("EdStudExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExcuse>) DataRepository.EdStudExcuseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExcuseCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeExcuseType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeExcuseType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeExcuseType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeExcuseType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EntPolicyExcuse>
				if (CanDeepSave(entity.EntPolicyExcuseCollection, "List<EntPolicyExcuse>|EntPolicyExcuseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyExcuse child in entity.EntPolicyExcuseCollection)
					{
						if(child.EdCodeExcuseTypeIdSource != null)
						{
							child.EdCodeExcuseTypeId = child.EdCodeExcuseTypeIdSource.EdCodeExcuseId;
						}
						else
						{
							child.EdCodeExcuseTypeId = entity.EdCodeExcuseId;
						}

					}

					if (entity.EntPolicyExcuseCollection.Count > 0 || entity.EntPolicyExcuseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyExcuseProvider.Save(transactionManager, entity.EntPolicyExcuseCollection);
						
						deepHandles.Add("EntPolicyExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyExcuse >) DataRepository.EntPolicyExcuseProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyExcuseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudExcuse>
				if (CanDeepSave(entity.EdStudExcuseCollection, "List<EdStudExcuse>|EdStudExcuseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExcuse child in entity.EdStudExcuseCollection)
					{
						if(child.EdCodeExcuseTypeIdSource != null)
						{
							child.EdCodeExcuseTypeId = child.EdCodeExcuseTypeIdSource.EdCodeExcuseId;
						}
						else
						{
							child.EdCodeExcuseTypeId = entity.EdCodeExcuseId;
						}

					}

					if (entity.EdStudExcuseCollection.Count > 0 || entity.EdStudExcuseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExcuseProvider.Save(transactionManager, entity.EdStudExcuseCollection);
						
						deepHandles.Add("EdStudExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExcuse >) DataRepository.EdStudExcuseProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExcuseCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeExcuseTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeExcuseType</c>
	///</summary>
	public enum EdCodeExcuseTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCodeExcuseType</c> as OneToMany for EntPolicyExcuseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyExcuse>))]
		EntPolicyExcuseCollection,
		///<summary>
		/// Collection of <c>EdCodeExcuseType</c> as OneToMany for EdStudExcuseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExcuse>))]
		EdStudExcuseCollection,
	}
	
	#endregion EdCodeExcuseTypeChildEntityTypes
	
	#region EdCodeExcuseTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeExcuseTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeExcuseType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeExcuseTypeFilterBuilder : SqlFilterBuilder<EdCodeExcuseTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeExcuseTypeFilterBuilder class.
		/// </summary>
		public EdCodeExcuseTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeExcuseTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeExcuseTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeExcuseTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeExcuseTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeExcuseTypeFilterBuilder
	
	#region EdCodeExcuseTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeExcuseTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeExcuseType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeExcuseTypeParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeExcuseTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeExcuseTypeParameterBuilder class.
		/// </summary>
		public EdCodeExcuseTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeExcuseTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeExcuseTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeExcuseTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeExcuseTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeExcuseTypeParameterBuilder
	
	#region EdCodeExcuseTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeExcuseTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeExcuseType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeExcuseTypeSortBuilder : SqlSortBuilder<EdCodeExcuseTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeExcuseTypeSqlSortBuilder class.
		/// </summary>
		public EdCodeExcuseTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeExcuseTypeSortBuilder
	
} // end namespace
