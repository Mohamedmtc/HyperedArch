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
	/// This class is the base class for any <see cref="EdStudDisabilityProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudDisabilityProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudDisability, UMIS_VER2.BusinessLyer.EdStudDisabilityKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudDisabilityKey key)
		{
			return Delete(transactionManager, key.EdStudDisabilityId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudDisabilityId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudDisabilityId)
		{
			return Delete(null, _edStudDisabilityId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudDisabilityId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudDisabilityId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdStudDisability Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudDisabilityKey key, int start, int pageLength)
		{
			return GetByEdStudDisabilityId(transactionManager, key.EdStudDisabilityId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_DISABILITY index.
		/// </summary>
		/// <param name="_edStudDisabilityId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudDisability"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudDisability GetByEdStudDisabilityId(System.Decimal _edStudDisabilityId)
		{
			int count = -1;
			return GetByEdStudDisabilityId(null,_edStudDisabilityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_DISABILITY index.
		/// </summary>
		/// <param name="_edStudDisabilityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudDisability"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudDisability GetByEdStudDisabilityId(System.Decimal _edStudDisabilityId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudDisabilityId(null, _edStudDisabilityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_DISABILITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudDisabilityId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudDisability"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudDisability GetByEdStudDisabilityId(TransactionManager transactionManager, System.Decimal _edStudDisabilityId)
		{
			int count = -1;
			return GetByEdStudDisabilityId(transactionManager, _edStudDisabilityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_DISABILITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudDisabilityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudDisability"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudDisability GetByEdStudDisabilityId(TransactionManager transactionManager, System.Decimal _edStudDisabilityId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudDisabilityId(transactionManager, _edStudDisabilityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_DISABILITY index.
		/// </summary>
		/// <param name="_edStudDisabilityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudDisability"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudDisability GetByEdStudDisabilityId(System.Decimal _edStudDisabilityId, int start, int pageLength, out int count)
		{
			return GetByEdStudDisabilityId(null, _edStudDisabilityId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_DISABILITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudDisabilityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudDisability"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudDisability GetByEdStudDisabilityId(TransactionManager transactionManager, System.Decimal _edStudDisabilityId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudDisability&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudDisability&gt;"/></returns>
		public static TList<EdStudDisability> Fill(IDataReader reader, TList<EdStudDisability> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudDisability c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudDisability")
					.Append("|").Append((System.Decimal)reader["ED_STUD_DISABILITY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudDisability>(
					key.ToString(), // EntityTrackingKey
					"EdStudDisability",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudDisability();
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
					c.EdStudDisabilityId = (System.Decimal)reader["ED_STUD_DISABILITY_ID"];
					c.OriginalEdStudDisabilityId = c.EdStudDisabilityId;
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudDisability"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudDisability"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudDisability entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudDisabilityId = (System.Decimal)reader[((int)EdStudDisabilityColumn.EdStudDisabilityId - 1)];
			entity.OriginalEdStudDisabilityId = (System.Decimal)reader["ED_STUD_DISABILITY_ID"];
			entity.DescrAr = (System.String)reader[((int)EdStudDisabilityColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)EdStudDisabilityColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudDisability"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudDisability"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudDisability entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudDisabilityId = (System.Decimal)dataRow["ED_STUD_DISABILITY_ID"];
			entity.OriginalEdStudDisabilityId = (System.Decimal)dataRow["ED_STUD_DISABILITY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudDisability"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudDisability Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudDisability entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdStudDisabilityId methods when available
			
			#region AdmAppDisabilityCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppDisability>|AdmAppDisabilityCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppDisabilityCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppDisabilityCollection = DataRepository.AdmAppDisabilityProvider.GetByEdStudDisabilityId(transactionManager, entity.EdStudDisabilityId);

				if (deep && entity.AdmAppDisabilityCollection.Count > 0)
				{
					deepHandles.Add("AdmAppDisabilityCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppDisability>) DataRepository.AdmAppDisabilityProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppDisabilityCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudDisability object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudDisability instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudDisability Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudDisability entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AdmAppDisability>
				if (CanDeepSave(entity.AdmAppDisabilityCollection, "List<AdmAppDisability>|AdmAppDisabilityCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppDisability child in entity.AdmAppDisabilityCollection)
					{
						if(child.EdStudDisabilityIdSource != null)
						{
							child.EdStudDisabilityId = child.EdStudDisabilityIdSource.EdStudDisabilityId;
						}
						else
						{
							child.EdStudDisabilityId = entity.EdStudDisabilityId;
						}

					}

					if (entity.AdmAppDisabilityCollection.Count > 0 || entity.AdmAppDisabilityCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppDisabilityProvider.Save(transactionManager, entity.AdmAppDisabilityCollection);
						
						deepHandles.Add("AdmAppDisabilityCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppDisability >) DataRepository.AdmAppDisabilityProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppDisabilityCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdStudDisabilityChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudDisability</c>
	///</summary>
	public enum EdStudDisabilityChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdStudDisability</c> as OneToMany for AdmAppDisabilityCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppDisability>))]
		AdmAppDisabilityCollection,
	}
	
	#endregion EdStudDisabilityChildEntityTypes
	
	#region EdStudDisabilityFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudDisabilityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudDisability"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudDisabilityFilterBuilder : SqlFilterBuilder<EdStudDisabilityColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudDisabilityFilterBuilder class.
		/// </summary>
		public EdStudDisabilityFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudDisabilityFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudDisabilityFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudDisabilityFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudDisabilityFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudDisabilityFilterBuilder
	
	#region EdStudDisabilityParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudDisabilityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudDisability"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudDisabilityParameterBuilder : ParameterizedSqlFilterBuilder<EdStudDisabilityColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudDisabilityParameterBuilder class.
		/// </summary>
		public EdStudDisabilityParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudDisabilityParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudDisabilityParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudDisabilityParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudDisabilityParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudDisabilityParameterBuilder
	
	#region EdStudDisabilitySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudDisabilityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudDisability"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudDisabilitySortBuilder : SqlSortBuilder<EdStudDisabilityColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudDisabilitySqlSortBuilder class.
		/// </summary>
		public EdStudDisabilitySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudDisabilitySortBuilder
	
} // end namespace
