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
	/// This class is the base class for any <see cref="MltCdeOrgTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MltCdeOrgTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MltCdeOrgType, UMIS_VER2.BusinessLyer.MltCdeOrgTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltCdeOrgTypeKey key)
		{
			return Delete(transactionManager, key.MltCdeOrgTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mltCdeOrgTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mltCdeOrgTypeId)
		{
			return Delete(null, _mltCdeOrgTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeOrgTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mltCdeOrgTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.MltCdeOrgType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltCdeOrgTypeKey key, int start, int pageLength)
		{
			return GetByMltCdeOrgTypeId(transactionManager, key.MltCdeOrgTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MLT_CDE_ORG_TYPE index.
		/// </summary>
		/// <param name="_mltCdeOrgTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeOrgType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeOrgType GetByMltCdeOrgTypeId(System.Decimal _mltCdeOrgTypeId)
		{
			int count = -1;
			return GetByMltCdeOrgTypeId(null,_mltCdeOrgTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_ORG_TYPE index.
		/// </summary>
		/// <param name="_mltCdeOrgTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeOrgType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeOrgType GetByMltCdeOrgTypeId(System.Decimal _mltCdeOrgTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltCdeOrgTypeId(null, _mltCdeOrgTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_ORG_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeOrgTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeOrgType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeOrgType GetByMltCdeOrgTypeId(TransactionManager transactionManager, System.Decimal _mltCdeOrgTypeId)
		{
			int count = -1;
			return GetByMltCdeOrgTypeId(transactionManager, _mltCdeOrgTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_ORG_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeOrgTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeOrgType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeOrgType GetByMltCdeOrgTypeId(TransactionManager transactionManager, System.Decimal _mltCdeOrgTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltCdeOrgTypeId(transactionManager, _mltCdeOrgTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_ORG_TYPE index.
		/// </summary>
		/// <param name="_mltCdeOrgTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeOrgType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeOrgType GetByMltCdeOrgTypeId(System.Decimal _mltCdeOrgTypeId, int start, int pageLength, out int count)
		{
			return GetByMltCdeOrgTypeId(null, _mltCdeOrgTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_ORG_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeOrgTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeOrgType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MltCdeOrgType GetByMltCdeOrgTypeId(TransactionManager transactionManager, System.Decimal _mltCdeOrgTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MltCdeOrgType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MltCdeOrgType&gt;"/></returns>
		public static TList<MltCdeOrgType> Fill(IDataReader reader, TList<MltCdeOrgType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MltCdeOrgType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MltCdeOrgType")
					.Append("|").Append((System.Decimal)reader["MLT_CDE_ORG_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MltCdeOrgType>(
					key.ToString(), // EntityTrackingKey
					"MltCdeOrgType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MltCdeOrgType();
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
					c.MltCdeOrgTypeId = (System.Decimal)reader["MLT_CDE_ORG_TYPE_ID"];
					c.OriginalMltCdeOrgTypeId = c.MltCdeOrgTypeId;
					c.OrgTypeAr = (System.String)reader["ORG_TYPE_AR"];
					c.OrgTypeEn = (System.String)reader["ORG_TYPE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltCdeOrgType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltCdeOrgType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MltCdeOrgType entity)
		{
			if (!reader.Read()) return;
			
			entity.MltCdeOrgTypeId = (System.Decimal)reader[((int)MltCdeOrgTypeColumn.MltCdeOrgTypeId - 1)];
			entity.OriginalMltCdeOrgTypeId = (System.Decimal)reader["MLT_CDE_ORG_TYPE_ID"];
			entity.OrgTypeAr = (System.String)reader[((int)MltCdeOrgTypeColumn.OrgTypeAr - 1)];
			entity.OrgTypeEn = (System.String)reader[((int)MltCdeOrgTypeColumn.OrgTypeEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltCdeOrgType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltCdeOrgType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MltCdeOrgType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MltCdeOrgTypeId = (System.Decimal)dataRow["MLT_CDE_ORG_TYPE_ID"];
			entity.OriginalMltCdeOrgTypeId = (System.Decimal)dataRow["MLT_CDE_ORG_TYPE_ID"];
			entity.OrgTypeAr = (System.String)dataRow["ORG_TYPE_AR"];
			entity.OrgTypeEn = (System.String)dataRow["ORG_TYPE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltCdeOrgType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltCdeOrgType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltCdeOrgType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMltCdeOrgTypeId methods when available
			
			#region MltOrgTreeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltOrgTree>|MltOrgTreeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltOrgTreeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltOrgTreeCollection = DataRepository.MltOrgTreeProvider.GetByMltCdeOrgTypeId(transactionManager, entity.MltCdeOrgTypeId);

				if (deep && entity.MltOrgTreeCollection.Count > 0)
				{
					deepHandles.Add("MltOrgTreeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltOrgTree>) DataRepository.MltOrgTreeProvider.DeepLoad,
						new object[] { transactionManager, entity.MltOrgTreeCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MltCdeOrgType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MltCdeOrgType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltCdeOrgType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltCdeOrgType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<MltOrgTree>
				if (CanDeepSave(entity.MltOrgTreeCollection, "List<MltOrgTree>|MltOrgTreeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltOrgTree child in entity.MltOrgTreeCollection)
					{
						if(child.MltCdeOrgTypeIdSource != null)
						{
							child.MltCdeOrgTypeId = child.MltCdeOrgTypeIdSource.MltCdeOrgTypeId;
						}
						else
						{
							child.MltCdeOrgTypeId = entity.MltCdeOrgTypeId;
						}

					}

					if (entity.MltOrgTreeCollection.Count > 0 || entity.MltOrgTreeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltOrgTreeProvider.Save(transactionManager, entity.MltOrgTreeCollection);
						
						deepHandles.Add("MltOrgTreeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltOrgTree >) DataRepository.MltOrgTreeProvider.DeepSave,
							new object[] { transactionManager, entity.MltOrgTreeCollection, deepSaveType, childTypes, innerList }
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
	
	#region MltCdeOrgTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MltCdeOrgType</c>
	///</summary>
	public enum MltCdeOrgTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>MltCdeOrgType</c> as OneToMany for MltOrgTreeCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltOrgTree>))]
		MltOrgTreeCollection,
	}
	
	#endregion MltCdeOrgTypeChildEntityTypes
	
	#region MltCdeOrgTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MltCdeOrgTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltCdeOrgType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltCdeOrgTypeFilterBuilder : SqlFilterBuilder<MltCdeOrgTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltCdeOrgTypeFilterBuilder class.
		/// </summary>
		public MltCdeOrgTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltCdeOrgTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltCdeOrgTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltCdeOrgTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltCdeOrgTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltCdeOrgTypeFilterBuilder
	
	#region MltCdeOrgTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MltCdeOrgTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltCdeOrgType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltCdeOrgTypeParameterBuilder : ParameterizedSqlFilterBuilder<MltCdeOrgTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltCdeOrgTypeParameterBuilder class.
		/// </summary>
		public MltCdeOrgTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltCdeOrgTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltCdeOrgTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltCdeOrgTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltCdeOrgTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltCdeOrgTypeParameterBuilder
	
	#region MltCdeOrgTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MltCdeOrgTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltCdeOrgType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MltCdeOrgTypeSortBuilder : SqlSortBuilder<MltCdeOrgTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltCdeOrgTypeSqlSortBuilder class.
		/// </summary>
		public MltCdeOrgTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MltCdeOrgTypeSortBuilder
	
} // end namespace
