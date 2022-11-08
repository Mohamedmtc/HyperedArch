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
	/// This class is the base class for any <see cref="ScCdeGrpTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScCdeGrpTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScCdeGrpType, UMIS_VER2.BusinessLyer.ScCdeGrpTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScCdeGrpTypeKey key)
		{
			return Delete(transactionManager, key.ScCdeGrpTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scCdeGrpTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scCdeGrpTypeId)
		{
			return Delete(null, _scCdeGrpTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeGrpTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scCdeGrpTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.ScCdeGrpType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScCdeGrpTypeKey key, int start, int pageLength)
		{
			return GetByScCdeGrpTypeId(transactionManager, key.ScCdeGrpTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_CDE_GRP_TYPE index.
		/// </summary>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeGrpType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeGrpType GetByScCdeGrpTypeId(System.Decimal _scCdeGrpTypeId)
		{
			int count = -1;
			return GetByScCdeGrpTypeId(null,_scCdeGrpTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_GRP_TYPE index.
		/// </summary>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeGrpType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeGrpType GetByScCdeGrpTypeId(System.Decimal _scCdeGrpTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByScCdeGrpTypeId(null, _scCdeGrpTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_GRP_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeGrpType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeGrpType GetByScCdeGrpTypeId(TransactionManager transactionManager, System.Decimal _scCdeGrpTypeId)
		{
			int count = -1;
			return GetByScCdeGrpTypeId(transactionManager, _scCdeGrpTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_GRP_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeGrpType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeGrpType GetByScCdeGrpTypeId(TransactionManager transactionManager, System.Decimal _scCdeGrpTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByScCdeGrpTypeId(transactionManager, _scCdeGrpTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_GRP_TYPE index.
		/// </summary>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeGrpType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeGrpType GetByScCdeGrpTypeId(System.Decimal _scCdeGrpTypeId, int start, int pageLength, out int count)
		{
			return GetByScCdeGrpTypeId(null, _scCdeGrpTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_GRP_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeGrpType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScCdeGrpType GetByScCdeGrpTypeId(TransactionManager transactionManager, System.Decimal _scCdeGrpTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScCdeGrpType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScCdeGrpType&gt;"/></returns>
		public static TList<ScCdeGrpType> Fill(IDataReader reader, TList<ScCdeGrpType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScCdeGrpType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScCdeGrpType")
					.Append("|").Append((System.Decimal)reader["SC_CDE_GRP_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScCdeGrpType>(
					key.ToString(), // EntityTrackingKey
					"ScCdeGrpType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScCdeGrpType();
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
					c.ScCdeGrpTypeId = (System.Decimal)reader["SC_CDE_GRP_TYPE_ID"];
					c.OriginalScCdeGrpTypeId = c.ScCdeGrpTypeId;
					c.GrpTypeAr = (System.String)reader["GRP_TYPE_AR"];
					c.GrpTypeEn = (System.String)reader["GRP_TYPE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScCdeGrpType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScCdeGrpType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScCdeGrpType entity)
		{
			if (!reader.Read()) return;
			
			entity.ScCdeGrpTypeId = (System.Decimal)reader[((int)ScCdeGrpTypeColumn.ScCdeGrpTypeId - 1)];
			entity.OriginalScCdeGrpTypeId = (System.Decimal)reader["SC_CDE_GRP_TYPE_ID"];
			entity.GrpTypeAr = (System.String)reader[((int)ScCdeGrpTypeColumn.GrpTypeAr - 1)];
			entity.GrpTypeEn = (System.String)reader[((int)ScCdeGrpTypeColumn.GrpTypeEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScCdeGrpType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScCdeGrpType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScCdeGrpType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScCdeGrpTypeId = (System.Decimal)dataRow["SC_CDE_GRP_TYPE_ID"];
			entity.OriginalScCdeGrpTypeId = (System.Decimal)dataRow["SC_CDE_GRP_TYPE_ID"];
			entity.GrpTypeAr = (System.String)dataRow["GRP_TYPE_AR"];
			entity.GrpTypeEn = (System.String)dataRow["GRP_TYPE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScCdeGrpType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScCdeGrpType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScCdeGrpType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByScCdeGrpTypeId methods when available
			
			#region ScSchdlHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSchdlHdr>|ScSchdlHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSchdlHdrCollection = DataRepository.ScSchdlHdrProvider.GetByScCdeGrpTypeId(transactionManager, entity.ScCdeGrpTypeId);

				if (deep && entity.ScSchdlHdrCollection.Count > 0)
				{
					deepHandles.Add("ScSchdlHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSchdlHdr>) DataRepository.ScSchdlHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSchdlHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScGroupInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScGroupInfo>|ScGroupInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScGroupInfoCollection = DataRepository.ScGroupInfoProvider.GetByScCdeGrpTypeId(transactionManager, entity.ScCdeGrpTypeId);

				if (deep && entity.ScGroupInfoCollection.Count > 0)
				{
					deepHandles.Add("ScGroupInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupInfo>) DataRepository.ScGroupInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupInfoCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScCdeGrpType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScCdeGrpType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScCdeGrpType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScCdeGrpType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<ScSchdlHdr>
				if (CanDeepSave(entity.ScSchdlHdrCollection, "List<ScSchdlHdr>|ScSchdlHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSchdlHdr child in entity.ScSchdlHdrCollection)
					{
						if(child.ScCdeGrpTypeIdSource != null)
						{
							child.ScCdeGrpTypeId = child.ScCdeGrpTypeIdSource.ScCdeGrpTypeId;
						}
						else
						{
							child.ScCdeGrpTypeId = entity.ScCdeGrpTypeId;
						}

					}

					if (entity.ScSchdlHdrCollection.Count > 0 || entity.ScSchdlHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSchdlHdrProvider.Save(transactionManager, entity.ScSchdlHdrCollection);
						
						deepHandles.Add("ScSchdlHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSchdlHdr >) DataRepository.ScSchdlHdrProvider.DeepSave,
							new object[] { transactionManager, entity.ScSchdlHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScGroupInfo>
				if (CanDeepSave(entity.ScGroupInfoCollection, "List<ScGroupInfo>|ScGroupInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScGroupInfo child in entity.ScGroupInfoCollection)
					{
						if(child.ScCdeGrpTypeIdSource != null)
						{
							child.ScCdeGrpTypeId = child.ScCdeGrpTypeIdSource.ScCdeGrpTypeId;
						}
						else
						{
							child.ScCdeGrpTypeId = entity.ScCdeGrpTypeId;
						}

					}

					if (entity.ScGroupInfoCollection.Count > 0 || entity.ScGroupInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScGroupInfoProvider.Save(transactionManager, entity.ScGroupInfoCollection);
						
						deepHandles.Add("ScGroupInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScGroupInfo >) DataRepository.ScGroupInfoProvider.DeepSave,
							new object[] { transactionManager, entity.ScGroupInfoCollection, deepSaveType, childTypes, innerList }
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
	
	#region ScCdeGrpTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScCdeGrpType</c>
	///</summary>
	public enum ScCdeGrpTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>ScCdeGrpType</c> as OneToMany for ScSchdlHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSchdlHdr>))]
		ScSchdlHdrCollection,
		///<summary>
		/// Collection of <c>ScCdeGrpType</c> as OneToMany for ScGroupInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupInfo>))]
		ScGroupInfoCollection,
	}
	
	#endregion ScCdeGrpTypeChildEntityTypes
	
	#region ScCdeGrpTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScCdeGrpTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScCdeGrpType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScCdeGrpTypeFilterBuilder : SqlFilterBuilder<ScCdeGrpTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScCdeGrpTypeFilterBuilder class.
		/// </summary>
		public ScCdeGrpTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScCdeGrpTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScCdeGrpTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScCdeGrpTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScCdeGrpTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScCdeGrpTypeFilterBuilder
	
	#region ScCdeGrpTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScCdeGrpTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScCdeGrpType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScCdeGrpTypeParameterBuilder : ParameterizedSqlFilterBuilder<ScCdeGrpTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScCdeGrpTypeParameterBuilder class.
		/// </summary>
		public ScCdeGrpTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScCdeGrpTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScCdeGrpTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScCdeGrpTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScCdeGrpTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScCdeGrpTypeParameterBuilder
	
	#region ScCdeGrpTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScCdeGrpTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScCdeGrpType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScCdeGrpTypeSortBuilder : SqlSortBuilder<ScCdeGrpTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScCdeGrpTypeSqlSortBuilder class.
		/// </summary>
		public ScCdeGrpTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScCdeGrpTypeSortBuilder
	
} // end namespace
