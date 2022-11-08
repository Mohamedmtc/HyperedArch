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
	/// This class is the base class for any <see cref="SvCdeSrvyTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvCdeSrvyTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvCdeSrvyType, UMIS_VER2.BusinessLyer.SvCdeSrvyTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeSrvyTypeKey key)
		{
			return Delete(transactionManager, key.SvCdeSrvyTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svCdeSrvyTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _svCdeSrvyTypeId)
		{
			return Delete(null, _svCdeSrvyTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeSrvyTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _svCdeSrvyTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.SvCdeSrvyType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeSrvyTypeKey key, int start, int pageLength)
		{
			return GetBySvCdeSrvyTypeId(transactionManager, key.SvCdeSrvyTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_CDE_SRVY_TYPE index.
		/// </summary>
		/// <param name="_svCdeSrvyTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeSrvyType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeSrvyType GetBySvCdeSrvyTypeId(System.Int32 _svCdeSrvyTypeId)
		{
			int count = -1;
			return GetBySvCdeSrvyTypeId(null,_svCdeSrvyTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_SRVY_TYPE index.
		/// </summary>
		/// <param name="_svCdeSrvyTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeSrvyType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeSrvyType GetBySvCdeSrvyTypeId(System.Int32 _svCdeSrvyTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeSrvyTypeId(null, _svCdeSrvyTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_SRVY_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeSrvyTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeSrvyType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeSrvyType GetBySvCdeSrvyTypeId(TransactionManager transactionManager, System.Int32 _svCdeSrvyTypeId)
		{
			int count = -1;
			return GetBySvCdeSrvyTypeId(transactionManager, _svCdeSrvyTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_SRVY_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeSrvyTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeSrvyType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeSrvyType GetBySvCdeSrvyTypeId(TransactionManager transactionManager, System.Int32 _svCdeSrvyTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeSrvyTypeId(transactionManager, _svCdeSrvyTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_SRVY_TYPE index.
		/// </summary>
		/// <param name="_svCdeSrvyTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeSrvyType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeSrvyType GetBySvCdeSrvyTypeId(System.Int32 _svCdeSrvyTypeId, int start, int pageLength, out int count)
		{
			return GetBySvCdeSrvyTypeId(null, _svCdeSrvyTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_SRVY_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeSrvyTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeSrvyType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCdeSrvyType GetBySvCdeSrvyTypeId(TransactionManager transactionManager, System.Int32 _svCdeSrvyTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvCdeSrvyType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvCdeSrvyType&gt;"/></returns>
		public static TList<SvCdeSrvyType> Fill(IDataReader reader, TList<SvCdeSrvyType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvCdeSrvyType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvCdeSrvyType")
					.Append("|").Append((System.Int32)reader["SV_CDE_SRVY_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvCdeSrvyType>(
					key.ToString(), // EntityTrackingKey
					"SvCdeSrvyType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvCdeSrvyType();
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
					c.SvCdeSrvyTypeId = (System.Int32)reader["SV_CDE_SRVY_TYPE_ID"];
					c.OriginalSvCdeSrvyTypeId = c.SvCdeSrvyTypeId;
					c.SrvyTypeAr = Convert.IsDBNull(reader["SRVY_TYPE_AR"]) ? null : (System.String)reader["SRVY_TYPE_AR"];
					c.SrvyTypeEn = Convert.IsDBNull(reader["SRVY_TYPE_EN"]) ? null : (System.String)reader["SRVY_TYPE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeSrvyType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeSrvyType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvCdeSrvyType entity)
		{
			if (!reader.Read()) return;
			
			entity.SvCdeSrvyTypeId = (System.Int32)reader[((int)SvCdeSrvyTypeColumn.SvCdeSrvyTypeId - 1)];
			entity.OriginalSvCdeSrvyTypeId = (System.Int32)reader["SV_CDE_SRVY_TYPE_ID"];
			entity.SrvyTypeAr = (reader.IsDBNull(((int)SvCdeSrvyTypeColumn.SrvyTypeAr - 1)))?null:(System.String)reader[((int)SvCdeSrvyTypeColumn.SrvyTypeAr - 1)];
			entity.SrvyTypeEn = (reader.IsDBNull(((int)SvCdeSrvyTypeColumn.SrvyTypeEn - 1)))?null:(System.String)reader[((int)SvCdeSrvyTypeColumn.SrvyTypeEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeSrvyType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeSrvyType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvCdeSrvyType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvCdeSrvyTypeId = (System.Int32)dataRow["SV_CDE_SRVY_TYPE_ID"];
			entity.OriginalSvCdeSrvyTypeId = (System.Int32)dataRow["SV_CDE_SRVY_TYPE_ID"];
			entity.SrvyTypeAr = Convert.IsDBNull(dataRow["SRVY_TYPE_AR"]) ? null : (System.String)dataRow["SRVY_TYPE_AR"];
			entity.SrvyTypeEn = Convert.IsDBNull(dataRow["SRVY_TYPE_EN"]) ? null : (System.String)dataRow["SRVY_TYPE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeSrvyType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeSrvyType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeSrvyType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvCdeSrvyTypeId methods when available
			
			#region SvSrvyHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvSrvyHdr>|SvSrvyHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvSrvyHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvSrvyHdrCollection = DataRepository.SvSrvyHdrProvider.GetBySvCdeSrvyTypeId(transactionManager, entity.SvCdeSrvyTypeId);

				if (deep && entity.SvSrvyHdrCollection.Count > 0)
				{
					deepHandles.Add("SvSrvyHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvSrvyHdr>) DataRepository.SvSrvyHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.SvSrvyHdrCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvCdeSrvyType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvCdeSrvyType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeSrvyType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeSrvyType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SvSrvyHdr>
				if (CanDeepSave(entity.SvSrvyHdrCollection, "List<SvSrvyHdr>|SvSrvyHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvSrvyHdr child in entity.SvSrvyHdrCollection)
					{
						if(child.SvCdeSrvyTypeIdSource != null)
						{
							child.SvCdeSrvyTypeId = child.SvCdeSrvyTypeIdSource.SvCdeSrvyTypeId;
						}
						else
						{
							child.SvCdeSrvyTypeId = entity.SvCdeSrvyTypeId;
						}

					}

					if (entity.SvSrvyHdrCollection.Count > 0 || entity.SvSrvyHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvSrvyHdrProvider.Save(transactionManager, entity.SvSrvyHdrCollection);
						
						deepHandles.Add("SvSrvyHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvSrvyHdr >) DataRepository.SvSrvyHdrProvider.DeepSave,
							new object[] { transactionManager, entity.SvSrvyHdrCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvCdeSrvyTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvCdeSrvyType</c>
	///</summary>
	public enum SvCdeSrvyTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SvCdeSrvyType</c> as OneToMany for SvSrvyHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvSrvyHdr>))]
		SvSrvyHdrCollection,
	}
	
	#endregion SvCdeSrvyTypeChildEntityTypes
	
	#region SvCdeSrvyTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvCdeSrvyTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeSrvyType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeSrvyTypeFilterBuilder : SqlFilterBuilder<SvCdeSrvyTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeSrvyTypeFilterBuilder class.
		/// </summary>
		public SvCdeSrvyTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeSrvyTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeSrvyTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeSrvyTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeSrvyTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeSrvyTypeFilterBuilder
	
	#region SvCdeSrvyTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvCdeSrvyTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeSrvyType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeSrvyTypeParameterBuilder : ParameterizedSqlFilterBuilder<SvCdeSrvyTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeSrvyTypeParameterBuilder class.
		/// </summary>
		public SvCdeSrvyTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeSrvyTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeSrvyTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeSrvyTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeSrvyTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeSrvyTypeParameterBuilder
	
	#region SvCdeSrvyTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvCdeSrvyTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeSrvyType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvCdeSrvyTypeSortBuilder : SqlSortBuilder<SvCdeSrvyTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeSrvyTypeSqlSortBuilder class.
		/// </summary>
		public SvCdeSrvyTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvCdeSrvyTypeSortBuilder
	
} // end namespace
