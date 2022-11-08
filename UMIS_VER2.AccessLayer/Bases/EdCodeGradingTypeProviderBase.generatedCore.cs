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
	/// This class is the base class for any <see cref="EdCodeGradingTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeGradingTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeGradingType, UMIS_VER2.BusinessLyer.EdCodeGradingTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeGradingTypeKey key)
		{
			return Delete(transactionManager, key.EdCodeGradingTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeGradingTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeGradingTypeId)
		{
			return Delete(null, _edCodeGradingTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeGradingTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeGradingType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeGradingTypeKey key, int start, int pageLength)
		{
			return GetByEdCodeGradingTypeId(transactionManager, key.EdCodeGradingTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_MARKING_SCHEME_TYPE index.
		/// </summary>
		/// <param name="_edCodeGradingTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeGradingType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeGradingType GetByEdCodeGradingTypeId(System.Decimal _edCodeGradingTypeId)
		{
			int count = -1;
			return GetByEdCodeGradingTypeId(null,_edCodeGradingTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_MARKING_SCHEME_TYPE index.
		/// </summary>
		/// <param name="_edCodeGradingTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeGradingType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeGradingType GetByEdCodeGradingTypeId(System.Decimal _edCodeGradingTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingTypeId(null, _edCodeGradingTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_MARKING_SCHEME_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeGradingType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeGradingType GetByEdCodeGradingTypeId(TransactionManager transactionManager, System.Decimal _edCodeGradingTypeId)
		{
			int count = -1;
			return GetByEdCodeGradingTypeId(transactionManager, _edCodeGradingTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_MARKING_SCHEME_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeGradingType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeGradingType GetByEdCodeGradingTypeId(TransactionManager transactionManager, System.Decimal _edCodeGradingTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingTypeId(transactionManager, _edCodeGradingTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_MARKING_SCHEME_TYPE index.
		/// </summary>
		/// <param name="_edCodeGradingTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeGradingType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeGradingType GetByEdCodeGradingTypeId(System.Decimal _edCodeGradingTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCodeGradingTypeId(null, _edCodeGradingTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_MARKING_SCHEME_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeGradingType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeGradingType GetByEdCodeGradingTypeId(TransactionManager transactionManager, System.Decimal _edCodeGradingTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeGradingType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeGradingType&gt;"/></returns>
		public static TList<EdCodeGradingType> Fill(IDataReader reader, TList<EdCodeGradingType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeGradingType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeGradingType")
					.Append("|").Append((System.Decimal)reader["ED_CODE_GRADING_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeGradingType>(
					key.ToString(), // EntityTrackingKey
					"EdCodeGradingType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeGradingType();
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
					c.EdCodeGradingTypeId = (System.Decimal)reader["ED_CODE_GRADING_TYPE_ID"];
					c.OriginalEdCodeGradingTypeId = c.EdCodeGradingTypeId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeGradingType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeGradingType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeGradingType entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeGradingTypeId = (System.Decimal)reader[((int)EdCodeGradingTypeColumn.EdCodeGradingTypeId - 1)];
			entity.OriginalEdCodeGradingTypeId = (System.Decimal)reader["ED_CODE_GRADING_TYPE_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCodeGradingTypeColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EdCodeGradingTypeColumn.DescrEn - 1)))?null:(System.String)reader[((int)EdCodeGradingTypeColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeGradingType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeGradingType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeGradingType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeGradingTypeId = (System.Decimal)dataRow["ED_CODE_GRADING_TYPE_ID"];
			entity.OriginalEdCodeGradingTypeId = (System.Decimal)dataRow["ED_CODE_GRADING_TYPE_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeGradingType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeGradingType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeGradingType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeGradingTypeId methods when available
			
			#region EntPolicyGradingHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyGradingHdr>|EntPolicyGradingHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyGradingHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyGradingHdrCollection = DataRepository.EntPolicyGradingHdrProvider.GetByEdCodeGradingTypeId(transactionManager, entity.EdCodeGradingTypeId);

				if (deep && entity.EntPolicyGradingHdrCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyGradingHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyGradingHdr>) DataRepository.EntPolicyGradingHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyGradingHdrCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeGradingType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeGradingType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeGradingType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeGradingType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EntPolicyGradingHdr>
				if (CanDeepSave(entity.EntPolicyGradingHdrCollection, "List<EntPolicyGradingHdr>|EntPolicyGradingHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyGradingHdr child in entity.EntPolicyGradingHdrCollection)
					{
						if(child.EdCodeGradingTypeIdSource != null)
						{
							child.EdCodeGradingTypeId = child.EdCodeGradingTypeIdSource.EdCodeGradingTypeId;
						}
						else
						{
							child.EdCodeGradingTypeId = entity.EdCodeGradingTypeId;
						}

					}

					if (entity.EntPolicyGradingHdrCollection.Count > 0 || entity.EntPolicyGradingHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyGradingHdrProvider.Save(transactionManager, entity.EntPolicyGradingHdrCollection);
						
						deepHandles.Add("EntPolicyGradingHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyGradingHdr >) DataRepository.EntPolicyGradingHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyGradingHdrCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeGradingTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeGradingType</c>
	///</summary>
	public enum EdCodeGradingTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCodeGradingType</c> as OneToMany for EntPolicyGradingHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyGradingHdr>))]
		EntPolicyGradingHdrCollection,
	}
	
	#endregion EdCodeGradingTypeChildEntityTypes
	
	#region EdCodeGradingTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeGradingTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeGradingType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeGradingTypeFilterBuilder : SqlFilterBuilder<EdCodeGradingTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeGradingTypeFilterBuilder class.
		/// </summary>
		public EdCodeGradingTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeGradingTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeGradingTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeGradingTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeGradingTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeGradingTypeFilterBuilder
	
	#region EdCodeGradingTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeGradingTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeGradingType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeGradingTypeParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeGradingTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeGradingTypeParameterBuilder class.
		/// </summary>
		public EdCodeGradingTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeGradingTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeGradingTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeGradingTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeGradingTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeGradingTypeParameterBuilder
	
	#region EdCodeGradingTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeGradingTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeGradingType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeGradingTypeSortBuilder : SqlSortBuilder<EdCodeGradingTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeGradingTypeSqlSortBuilder class.
		/// </summary>
		public EdCodeGradingTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeGradingTypeSortBuilder
	
} // end namespace
