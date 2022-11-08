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
	/// This class is the base class for any <see cref="SvCdeDeviceTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvCdeDeviceTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvCdeDeviceType, UMIS_VER2.BusinessLyer.SvCdeDeviceTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeDeviceTypeKey key)
		{
			return Delete(transactionManager, key.SvCdeDeviceTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svCdeDeviceTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _svCdeDeviceTypeId)
		{
			return Delete(null, _svCdeDeviceTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeDeviceTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _svCdeDeviceTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.SvCdeDeviceType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeDeviceTypeKey key, int start, int pageLength)
		{
			return GetBySvCdeDeviceTypeId(transactionManager, key.SvCdeDeviceTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_CDE_DEVICE_TYPE index.
		/// </summary>
		/// <param name="_svCdeDeviceTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeDeviceType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeDeviceType GetBySvCdeDeviceTypeId(System.Int32 _svCdeDeviceTypeId)
		{
			int count = -1;
			return GetBySvCdeDeviceTypeId(null,_svCdeDeviceTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_DEVICE_TYPE index.
		/// </summary>
		/// <param name="_svCdeDeviceTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeDeviceType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeDeviceType GetBySvCdeDeviceTypeId(System.Int32 _svCdeDeviceTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeDeviceTypeId(null, _svCdeDeviceTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_DEVICE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeDeviceTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeDeviceType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeDeviceType GetBySvCdeDeviceTypeId(TransactionManager transactionManager, System.Int32 _svCdeDeviceTypeId)
		{
			int count = -1;
			return GetBySvCdeDeviceTypeId(transactionManager, _svCdeDeviceTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_DEVICE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeDeviceTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeDeviceType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeDeviceType GetBySvCdeDeviceTypeId(TransactionManager transactionManager, System.Int32 _svCdeDeviceTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeDeviceTypeId(transactionManager, _svCdeDeviceTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_DEVICE_TYPE index.
		/// </summary>
		/// <param name="_svCdeDeviceTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeDeviceType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeDeviceType GetBySvCdeDeviceTypeId(System.Int32 _svCdeDeviceTypeId, int start, int pageLength, out int count)
		{
			return GetBySvCdeDeviceTypeId(null, _svCdeDeviceTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_DEVICE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeDeviceTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeDeviceType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCdeDeviceType GetBySvCdeDeviceTypeId(TransactionManager transactionManager, System.Int32 _svCdeDeviceTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvCdeDeviceType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvCdeDeviceType&gt;"/></returns>
		public static TList<SvCdeDeviceType> Fill(IDataReader reader, TList<SvCdeDeviceType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvCdeDeviceType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvCdeDeviceType")
					.Append("|").Append((System.Int32)reader["SV_CDE_DEVICE_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvCdeDeviceType>(
					key.ToString(), // EntityTrackingKey
					"SvCdeDeviceType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvCdeDeviceType();
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
					c.SvCdeDeviceTypeId = (System.Int32)reader["SV_CDE_DEVICE_TYPE_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeDeviceType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeDeviceType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvCdeDeviceType entity)
		{
			if (!reader.Read()) return;
			
			entity.SvCdeDeviceTypeId = (System.Int32)reader[((int)SvCdeDeviceTypeColumn.SvCdeDeviceTypeId - 1)];
			entity.DescrAr = (System.String)reader[((int)SvCdeDeviceTypeColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)SvCdeDeviceTypeColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeDeviceType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeDeviceType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvCdeDeviceType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvCdeDeviceTypeId = (System.Int32)dataRow["SV_CDE_DEVICE_TYPE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeDeviceType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeDeviceType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeDeviceType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvCdeDeviceTypeId methods when available
			
			#region SvUserMobTokenCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvUserMobToken>|SvUserMobTokenCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvUserMobTokenCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvUserMobTokenCollection = DataRepository.SvUserMobTokenProvider.GetBySvCdeDeviceTypeId(transactionManager, entity.SvCdeDeviceTypeId);

				if (deep && entity.SvUserMobTokenCollection.Count > 0)
				{
					deepHandles.Add("SvUserMobTokenCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvUserMobToken>) DataRepository.SvUserMobTokenProvider.DeepLoad,
						new object[] { transactionManager, entity.SvUserMobTokenCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvCdeDeviceType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvCdeDeviceType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeDeviceType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeDeviceType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SvUserMobToken>
				if (CanDeepSave(entity.SvUserMobTokenCollection, "List<SvUserMobToken>|SvUserMobTokenCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvUserMobToken child in entity.SvUserMobTokenCollection)
					{
						if(child.SvCdeDeviceTypeIdSource != null)
						{
							child.SvCdeDeviceTypeId = child.SvCdeDeviceTypeIdSource.SvCdeDeviceTypeId;
						}
						else
						{
							child.SvCdeDeviceTypeId = entity.SvCdeDeviceTypeId;
						}

					}

					if (entity.SvUserMobTokenCollection.Count > 0 || entity.SvUserMobTokenCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvUserMobTokenProvider.Save(transactionManager, entity.SvUserMobTokenCollection);
						
						deepHandles.Add("SvUserMobTokenCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvUserMobToken >) DataRepository.SvUserMobTokenProvider.DeepSave,
							new object[] { transactionManager, entity.SvUserMobTokenCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvCdeDeviceTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvCdeDeviceType</c>
	///</summary>
	public enum SvCdeDeviceTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SvCdeDeviceType</c> as OneToMany for SvUserMobTokenCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvUserMobToken>))]
		SvUserMobTokenCollection,
	}
	
	#endregion SvCdeDeviceTypeChildEntityTypes
	
	#region SvCdeDeviceTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvCdeDeviceTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeDeviceType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeDeviceTypeFilterBuilder : SqlFilterBuilder<SvCdeDeviceTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeDeviceTypeFilterBuilder class.
		/// </summary>
		public SvCdeDeviceTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeDeviceTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeDeviceTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeDeviceTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeDeviceTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeDeviceTypeFilterBuilder
	
	#region SvCdeDeviceTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvCdeDeviceTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeDeviceType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeDeviceTypeParameterBuilder : ParameterizedSqlFilterBuilder<SvCdeDeviceTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeDeviceTypeParameterBuilder class.
		/// </summary>
		public SvCdeDeviceTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeDeviceTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeDeviceTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeDeviceTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeDeviceTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeDeviceTypeParameterBuilder
	
	#region SvCdeDeviceTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvCdeDeviceTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeDeviceType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvCdeDeviceTypeSortBuilder : SqlSortBuilder<SvCdeDeviceTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeDeviceTypeSqlSortBuilder class.
		/// </summary>
		public SvCdeDeviceTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvCdeDeviceTypeSortBuilder
	
} // end namespace
