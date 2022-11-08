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
	/// This class is the base class for any <see cref="GsCodeCNodeNatureProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeCNodeNatureProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeCNodeNature, UMIS_VER2.BusinessLyer.GsCodeCNodeNatureKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeCNodeNatureKey key)
		{
			return Delete(transactionManager, key.GsCodeCNodeNatureId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeCNodeNatureId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeCNodeNatureId)
		{
			return Delete(null, _gsCodeCNodeNatureId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCNodeNatureId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeCNodeNatureId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeCNodeNature Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeCNodeNatureKey key, int start, int pageLength)
		{
			return GetByGsCodeCNodeNatureId(transactionManager, key.GsCodeCNodeNatureId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_C_NODE_NATURE index.
		/// </summary>
		/// <param name="_gsCodeCNodeNatureId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeCNodeNature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeCNodeNature GetByGsCodeCNodeNatureId(System.Decimal _gsCodeCNodeNatureId)
		{
			int count = -1;
			return GetByGsCodeCNodeNatureId(null,_gsCodeCNodeNatureId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_C_NODE_NATURE index.
		/// </summary>
		/// <param name="_gsCodeCNodeNatureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeCNodeNature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeCNodeNature GetByGsCodeCNodeNatureId(System.Decimal _gsCodeCNodeNatureId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCNodeNatureId(null, _gsCodeCNodeNatureId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_C_NODE_NATURE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCNodeNatureId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeCNodeNature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeCNodeNature GetByGsCodeCNodeNatureId(TransactionManager transactionManager, System.Decimal _gsCodeCNodeNatureId)
		{
			int count = -1;
			return GetByGsCodeCNodeNatureId(transactionManager, _gsCodeCNodeNatureId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_C_NODE_NATURE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCNodeNatureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeCNodeNature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeCNodeNature GetByGsCodeCNodeNatureId(TransactionManager transactionManager, System.Decimal _gsCodeCNodeNatureId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCNodeNatureId(transactionManager, _gsCodeCNodeNatureId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_C_NODE_NATURE index.
		/// </summary>
		/// <param name="_gsCodeCNodeNatureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeCNodeNature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeCNodeNature GetByGsCodeCNodeNatureId(System.Decimal _gsCodeCNodeNatureId, int start, int pageLength, out int count)
		{
			return GetByGsCodeCNodeNatureId(null, _gsCodeCNodeNatureId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_C_NODE_NATURE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCNodeNatureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeCNodeNature"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeCNodeNature GetByGsCodeCNodeNatureId(TransactionManager transactionManager, System.Decimal _gsCodeCNodeNatureId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeCNodeNature&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeCNodeNature&gt;"/></returns>
		public static TList<GsCodeCNodeNature> Fill(IDataReader reader, TList<GsCodeCNodeNature> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeCNodeNature c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeCNodeNature")
					.Append("|").Append((System.Decimal)reader["GS_CODE_C_NODE_NATURE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeCNodeNature>(
					key.ToString(), // EntityTrackingKey
					"GsCodeCNodeNature",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeCNodeNature();
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
					c.GsCodeCNodeNatureId = (System.Decimal)reader["GS_CODE_C_NODE_NATURE_ID"];
					c.OriginalGsCodeCNodeNatureId = c.GsCodeCNodeNatureId;
					c.NatureDescrAr = (System.String)reader["NATURE_DESCR_AR"];
					c.NatureDescrEn = Convert.IsDBNull(reader["NATURE_DESCR_EN"]) ? null : (System.String)reader["NATURE_DESCR_EN"];
					c.NatureCode = Convert.IsDBNull(reader["NATURE_CODE"]) ? null : (System.String)reader["NATURE_CODE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeCNodeNature"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeCNodeNature"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeCNodeNature entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeCNodeNatureId = (System.Decimal)reader[((int)GsCodeCNodeNatureColumn.GsCodeCNodeNatureId - 1)];
			entity.OriginalGsCodeCNodeNatureId = (System.Decimal)reader["GS_CODE_C_NODE_NATURE_ID"];
			entity.NatureDescrAr = (System.String)reader[((int)GsCodeCNodeNatureColumn.NatureDescrAr - 1)];
			entity.NatureDescrEn = (reader.IsDBNull(((int)GsCodeCNodeNatureColumn.NatureDescrEn - 1)))?null:(System.String)reader[((int)GsCodeCNodeNatureColumn.NatureDescrEn - 1)];
			entity.NatureCode = (reader.IsDBNull(((int)GsCodeCNodeNatureColumn.NatureCode - 1)))?null:(System.String)reader[((int)GsCodeCNodeNatureColumn.NatureCode - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeCNodeNature"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeCNodeNature"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeCNodeNature entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeCNodeNatureId = (System.Decimal)dataRow["GS_CODE_C_NODE_NATURE_ID"];
			entity.OriginalGsCodeCNodeNatureId = (System.Decimal)dataRow["GS_CODE_C_NODE_NATURE_ID"];
			entity.NatureDescrAr = (System.String)dataRow["NATURE_DESCR_AR"];
			entity.NatureDescrEn = Convert.IsDBNull(dataRow["NATURE_DESCR_EN"]) ? null : (System.String)dataRow["NATURE_DESCR_EN"];
			entity.NatureCode = Convert.IsDBNull(dataRow["NATURE_CODE"]) ? null : (System.String)dataRow["NATURE_CODE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeCNodeNature"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeCNodeNature Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeCNodeNature entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeCNodeNatureId methods when available
			
			#region GsCountryNodeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCountryNode>|GsCountryNodeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryNodeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCountryNodeCollection = DataRepository.GsCountryNodeProvider.GetByGsCodeCNodeNatureId(transactionManager, entity.GsCodeCNodeNatureId);

				if (deep && entity.GsCountryNodeCollection.Count > 0)
				{
					deepHandles.Add("GsCountryNodeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCountryNode>) DataRepository.GsCountryNodeProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCountryNodeCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeCNodeNature object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeCNodeNature instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeCNodeNature Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeCNodeNature entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<GsCountryNode>
				if (CanDeepSave(entity.GsCountryNodeCollection, "List<GsCountryNode>|GsCountryNodeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCountryNode child in entity.GsCountryNodeCollection)
					{
						if(child.GsCodeCNodeNatureIdSource != null)
						{
							child.GsCodeCNodeNatureId = child.GsCodeCNodeNatureIdSource.GsCodeCNodeNatureId;
						}
						else
						{
							child.GsCodeCNodeNatureId = entity.GsCodeCNodeNatureId;
						}

					}

					if (entity.GsCountryNodeCollection.Count > 0 || entity.GsCountryNodeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryNodeCollection);
						
						deepHandles.Add("GsCountryNodeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCountryNode >) DataRepository.GsCountryNodeProvider.DeepSave,
							new object[] { transactionManager, entity.GsCountryNodeCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCodeCNodeNatureChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeCNodeNature</c>
	///</summary>
	public enum GsCodeCNodeNatureChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCodeCNodeNature</c> as OneToMany for GsCountryNodeCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCountryNode>))]
		GsCountryNodeCollection,
	}
	
	#endregion GsCodeCNodeNatureChildEntityTypes
	
	#region GsCodeCNodeNatureFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeCNodeNatureColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeCNodeNature"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeCNodeNatureFilterBuilder : SqlFilterBuilder<GsCodeCNodeNatureColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeCNodeNatureFilterBuilder class.
		/// </summary>
		public GsCodeCNodeNatureFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeCNodeNatureFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeCNodeNatureFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeCNodeNatureFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeCNodeNatureFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeCNodeNatureFilterBuilder
	
	#region GsCodeCNodeNatureParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeCNodeNatureColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeCNodeNature"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeCNodeNatureParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeCNodeNatureColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeCNodeNatureParameterBuilder class.
		/// </summary>
		public GsCodeCNodeNatureParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeCNodeNatureParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeCNodeNatureParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeCNodeNatureParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeCNodeNatureParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeCNodeNatureParameterBuilder
	
	#region GsCodeCNodeNatureSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeCNodeNatureColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeCNodeNature"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeCNodeNatureSortBuilder : SqlSortBuilder<GsCodeCNodeNatureColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeCNodeNatureSqlSortBuilder class.
		/// </summary>
		public GsCodeCNodeNatureSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeCNodeNatureSortBuilder
	
} // end namespace
