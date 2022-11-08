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
	/// This class is the base class for any <see cref="GsCdeBloodProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeBloodProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeBlood, UMIS_VER2.BusinessLyer.GsCdeBloodKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeBloodKey key)
		{
			return Delete(transactionManager, key.GsCdeBloodId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeBloodId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeBloodId)
		{
			return Delete(null, _gsCdeBloodId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeBloodId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeBloodId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeBlood Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeBloodKey key, int start, int pageLength)
		{
			return GetByGsCdeBloodId(transactionManager, key.GsCdeBloodId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_BLOOD index.
		/// </summary>
		/// <param name="_gsCdeBloodId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeBlood"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeBlood GetByGsCdeBloodId(System.Decimal _gsCdeBloodId)
		{
			int count = -1;
			return GetByGsCdeBloodId(null,_gsCdeBloodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_BLOOD index.
		/// </summary>
		/// <param name="_gsCdeBloodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeBlood"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeBlood GetByGsCdeBloodId(System.Decimal _gsCdeBloodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeBloodId(null, _gsCdeBloodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_BLOOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeBloodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeBlood"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeBlood GetByGsCdeBloodId(TransactionManager transactionManager, System.Decimal _gsCdeBloodId)
		{
			int count = -1;
			return GetByGsCdeBloodId(transactionManager, _gsCdeBloodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_BLOOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeBloodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeBlood"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeBlood GetByGsCdeBloodId(TransactionManager transactionManager, System.Decimal _gsCdeBloodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeBloodId(transactionManager, _gsCdeBloodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_BLOOD index.
		/// </summary>
		/// <param name="_gsCdeBloodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeBlood"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeBlood GetByGsCdeBloodId(System.Decimal _gsCdeBloodId, int start, int pageLength, out int count)
		{
			return GetByGsCdeBloodId(null, _gsCdeBloodId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_BLOOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeBloodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeBlood"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeBlood GetByGsCdeBloodId(TransactionManager transactionManager, System.Decimal _gsCdeBloodId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeBlood&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeBlood&gt;"/></returns>
		public static TList<GsCdeBlood> Fill(IDataReader reader, TList<GsCdeBlood> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeBlood c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeBlood")
					.Append("|").Append((System.Decimal)reader["GS_CDE_BLOOD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeBlood>(
					key.ToString(), // EntityTrackingKey
					"GsCdeBlood",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeBlood();
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
					c.GsCdeBloodId = (System.Decimal)reader["GS_CDE_BLOOD_ID"];
					c.OriginalGsCdeBloodId = c.GsCdeBloodId;
					c.BloodCode = (System.String)reader["BLOOD_CODE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeBlood"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeBlood"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeBlood entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeBloodId = (System.Decimal)reader[((int)GsCdeBloodColumn.GsCdeBloodId - 1)];
			entity.OriginalGsCdeBloodId = (System.Decimal)reader["GS_CDE_BLOOD_ID"];
			entity.BloodCode = (System.String)reader[((int)GsCdeBloodColumn.BloodCode - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeBlood"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeBlood"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeBlood entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeBloodId = (System.Decimal)dataRow["GS_CDE_BLOOD_ID"];
			entity.OriginalGsCdeBloodId = (System.Decimal)dataRow["GS_CDE_BLOOD_ID"];
			entity.BloodCode = (System.String)dataRow["BLOOD_CODE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeBlood"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeBlood Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeBlood entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdeBloodId methods when available
			
			#region EdStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStud>|EdStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCollection = DataRepository.EdStudProvider.GetByGsCdeBloodId(transactionManager, entity.GsCdeBloodId);

				if (deep && entity.EdStudCollection.Count > 0)
				{
					deepHandles.Add("EdStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStud>) DataRepository.EdStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeBlood object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeBlood instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeBlood Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeBlood entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStud>
				if (CanDeepSave(entity.EdStudCollection, "List<EdStud>|EdStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStud child in entity.EdStudCollection)
					{
						if(child.GsCdeBloodIdSource != null)
						{
							child.GsCdeBloodId = child.GsCdeBloodIdSource.GsCdeBloodId;
						}
						else
						{
							child.GsCdeBloodId = entity.GsCdeBloodId;
						}

					}

					if (entity.EdStudCollection.Count > 0 || entity.EdStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudCollection);
						
						deepHandles.Add("EdStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStud >) DataRepository.EdStudProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCdeBloodChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeBlood</c>
	///</summary>
	public enum GsCdeBloodChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCdeBlood</c> as OneToMany for EdStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStud>))]
		EdStudCollection,
	}
	
	#endregion GsCdeBloodChildEntityTypes
	
	#region GsCdeBloodFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeBloodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeBlood"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeBloodFilterBuilder : SqlFilterBuilder<GsCdeBloodColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeBloodFilterBuilder class.
		/// </summary>
		public GsCdeBloodFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeBloodFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeBloodFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeBloodFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeBloodFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeBloodFilterBuilder
	
	#region GsCdeBloodParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeBloodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeBlood"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeBloodParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeBloodColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeBloodParameterBuilder class.
		/// </summary>
		public GsCdeBloodParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeBloodParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeBloodParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeBloodParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeBloodParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeBloodParameterBuilder
	
	#region GsCdeBloodSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeBloodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeBlood"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeBloodSortBuilder : SqlSortBuilder<GsCdeBloodColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeBloodSqlSortBuilder class.
		/// </summary>
		public GsCdeBloodSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeBloodSortBuilder
	
} // end namespace
