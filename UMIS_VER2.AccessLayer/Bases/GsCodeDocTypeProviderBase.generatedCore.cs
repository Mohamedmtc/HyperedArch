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
	/// This class is the base class for any <see cref="GsCodeDocTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeDocTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeDocType, UMIS_VER2.BusinessLyer.GsCodeDocTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeDocTypeKey key)
		{
			return Delete(transactionManager, key.GsCodeDocTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeDocTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeDocTypeId)
		{
			return Delete(null, _gsCodeDocTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeDocTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeDocTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeDocType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeDocTypeKey key, int start, int pageLength)
		{
			return GetByGsCodeDocTypeId(transactionManager, key.GsCodeDocTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_DOC_TYPE_1 index.
		/// </summary>
		/// <param name="_gsCodeDocTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeDocType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeDocType GetByGsCodeDocTypeId(System.Decimal _gsCodeDocTypeId)
		{
			int count = -1;
			return GetByGsCodeDocTypeId(null,_gsCodeDocTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_DOC_TYPE_1 index.
		/// </summary>
		/// <param name="_gsCodeDocTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeDocType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeDocType GetByGsCodeDocTypeId(System.Decimal _gsCodeDocTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeDocTypeId(null, _gsCodeDocTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_DOC_TYPE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeDocTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeDocType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeDocType GetByGsCodeDocTypeId(TransactionManager transactionManager, System.Decimal _gsCodeDocTypeId)
		{
			int count = -1;
			return GetByGsCodeDocTypeId(transactionManager, _gsCodeDocTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_DOC_TYPE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeDocTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeDocType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeDocType GetByGsCodeDocTypeId(TransactionManager transactionManager, System.Decimal _gsCodeDocTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeDocTypeId(transactionManager, _gsCodeDocTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_DOC_TYPE_1 index.
		/// </summary>
		/// <param name="_gsCodeDocTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeDocType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeDocType GetByGsCodeDocTypeId(System.Decimal _gsCodeDocTypeId, int start, int pageLength, out int count)
		{
			return GetByGsCodeDocTypeId(null, _gsCodeDocTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_DOC_TYPE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeDocTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeDocType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeDocType GetByGsCodeDocTypeId(TransactionManager transactionManager, System.Decimal _gsCodeDocTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeDocType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeDocType&gt;"/></returns>
		public static TList<GsCodeDocType> Fill(IDataReader reader, TList<GsCodeDocType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeDocType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeDocType")
					.Append("|").Append((System.Decimal)reader["GS_CODE_DOC_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeDocType>(
					key.ToString(), // EntityTrackingKey
					"GsCodeDocType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeDocType();
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
					c.GsCodeDocTypeId = (System.Decimal)reader["GS_CODE_DOC_TYPE_ID"];
					c.OriginalGsCodeDocTypeId = c.GsCodeDocTypeId;
					c.DocDescrAr = Convert.IsDBNull(reader["DOC_DESCR_AR"]) ? null : (System.String)reader["DOC_DESCR_AR"];
					c.DocDescrEn = Convert.IsDBNull(reader["DOC_DESCR_EN"]) ? null : (System.String)reader["DOC_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeDocType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeDocType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeDocType entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeDocTypeId = (System.Decimal)reader[((int)GsCodeDocTypeColumn.GsCodeDocTypeId - 1)];
			entity.OriginalGsCodeDocTypeId = (System.Decimal)reader["GS_CODE_DOC_TYPE_ID"];
			entity.DocDescrAr = (reader.IsDBNull(((int)GsCodeDocTypeColumn.DocDescrAr - 1)))?null:(System.String)reader[((int)GsCodeDocTypeColumn.DocDescrAr - 1)];
			entity.DocDescrEn = (reader.IsDBNull(((int)GsCodeDocTypeColumn.DocDescrEn - 1)))?null:(System.String)reader[((int)GsCodeDocTypeColumn.DocDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeDocType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeDocType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeDocType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeDocTypeId = (System.Decimal)dataRow["GS_CODE_DOC_TYPE_ID"];
			entity.OriginalGsCodeDocTypeId = (System.Decimal)dataRow["GS_CODE_DOC_TYPE_ID"];
			entity.DocDescrAr = Convert.IsDBNull(dataRow["DOC_DESCR_AR"]) ? null : (System.String)dataRow["DOC_DESCR_AR"];
			entity.DocDescrEn = Convert.IsDBNull(dataRow["DOC_DESCR_EN"]) ? null : (System.String)dataRow["DOC_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeDocType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeDocType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeDocType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeDocTypeId methods when available
			
			#region GsCdeDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCdeDoc>|GsCdeDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCdeDocCollection = DataRepository.GsCdeDocProvider.GetByGsCodeDocTypeId(transactionManager, entity.GsCodeDocTypeId);

				if (deep && entity.GsCdeDocCollection.Count > 0)
				{
					deepHandles.Add("GsCdeDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCdeDoc>) DataRepository.GsCdeDocProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCdeDocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeDocType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeDocType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeDocType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeDocType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<GsCdeDoc>
				if (CanDeepSave(entity.GsCdeDocCollection, "List<GsCdeDoc>|GsCdeDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCdeDoc child in entity.GsCdeDocCollection)
					{
						if(child.GsCodeDocTypeIdSource != null)
						{
							child.GsCodeDocTypeId = child.GsCodeDocTypeIdSource.GsCodeDocTypeId;
						}
						else
						{
							child.GsCodeDocTypeId = entity.GsCodeDocTypeId;
						}

					}

					if (entity.GsCdeDocCollection.Count > 0 || entity.GsCdeDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCdeDocProvider.Save(transactionManager, entity.GsCdeDocCollection);
						
						deepHandles.Add("GsCdeDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCdeDoc >) DataRepository.GsCdeDocProvider.DeepSave,
							new object[] { transactionManager, entity.GsCdeDocCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCodeDocTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeDocType</c>
	///</summary>
	public enum GsCodeDocTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCodeDocType</c> as OneToMany for GsCdeDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCdeDoc>))]
		GsCdeDocCollection,
	}
	
	#endregion GsCodeDocTypeChildEntityTypes
	
	#region GsCodeDocTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeDocTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeDocType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeDocTypeFilterBuilder : SqlFilterBuilder<GsCodeDocTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeDocTypeFilterBuilder class.
		/// </summary>
		public GsCodeDocTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeDocTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeDocTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeDocTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeDocTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeDocTypeFilterBuilder
	
	#region GsCodeDocTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeDocTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeDocType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeDocTypeParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeDocTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeDocTypeParameterBuilder class.
		/// </summary>
		public GsCodeDocTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeDocTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeDocTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeDocTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeDocTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeDocTypeParameterBuilder
	
	#region GsCodeDocTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeDocTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeDocType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeDocTypeSortBuilder : SqlSortBuilder<GsCodeDocTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeDocTypeSqlSortBuilder class.
		/// </summary>
		public GsCodeDocTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeDocTypeSortBuilder
	
} // end namespace
