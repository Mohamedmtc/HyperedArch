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
	/// This class is the base class for any <see cref="SeCodeUserPlaceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeCodeUserPlaceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeCodeUserPlace, UMIS_VER2.BusinessLyer.SeCodeUserPlaceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeCodeUserPlaceKey key)
		{
			return Delete(transactionManager, key.SeCodeUserPlaceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seCodeUserPlaceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seCodeUserPlaceId)
		{
			return Delete(null, _seCodeUserPlaceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserPlaceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seCodeUserPlaceId);		
		
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
		public override UMIS_VER2.BusinessLyer.SeCodeUserPlace Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeCodeUserPlaceKey key, int start, int pageLength)
		{
			return GetBySeCodeUserPlaceId(transactionManager, key.SeCodeUserPlaceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SE_USER_PLACE_DESC_AR index.
		/// </summary>
		/// <param name="_descAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserPlace GetByDescAr(System.String _descAr)
		{
			int count = -1;
			return GetByDescAr(null,_descAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_USER_PLACE_DESC_AR index.
		/// </summary>
		/// <param name="_descAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserPlace GetByDescAr(System.String _descAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescAr(null, _descAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_USER_PLACE_DESC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserPlace GetByDescAr(TransactionManager transactionManager, System.String _descAr)
		{
			int count = -1;
			return GetByDescAr(transactionManager, _descAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_USER_PLACE_DESC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserPlace GetByDescAr(TransactionManager transactionManager, System.String _descAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescAr(transactionManager, _descAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_USER_PLACE_DESC_AR index.
		/// </summary>
		/// <param name="_descAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserPlace GetByDescAr(System.String _descAr, int start, int pageLength, out int count)
		{
			return GetByDescAr(null, _descAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_USER_PLACE_DESC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserPlace"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeCodeUserPlace GetByDescAr(TransactionManager transactionManager, System.String _descAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_CODE_USER_PLACE index.
		/// </summary>
		/// <param name="_seCodeUserPlaceId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserPlace GetBySeCodeUserPlaceId(System.Decimal _seCodeUserPlaceId)
		{
			int count = -1;
			return GetBySeCodeUserPlaceId(null,_seCodeUserPlaceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CODE_USER_PLACE index.
		/// </summary>
		/// <param name="_seCodeUserPlaceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserPlace GetBySeCodeUserPlaceId(System.Decimal _seCodeUserPlaceId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserPlaceId(null, _seCodeUserPlaceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CODE_USER_PLACE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserPlaceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserPlace GetBySeCodeUserPlaceId(TransactionManager transactionManager, System.Decimal _seCodeUserPlaceId)
		{
			int count = -1;
			return GetBySeCodeUserPlaceId(transactionManager, _seCodeUserPlaceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CODE_USER_PLACE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserPlaceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserPlace GetBySeCodeUserPlaceId(TransactionManager transactionManager, System.Decimal _seCodeUserPlaceId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserPlaceId(transactionManager, _seCodeUserPlaceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CODE_USER_PLACE index.
		/// </summary>
		/// <param name="_seCodeUserPlaceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserPlace GetBySeCodeUserPlaceId(System.Decimal _seCodeUserPlaceId, int start, int pageLength, out int count)
		{
			return GetBySeCodeUserPlaceId(null, _seCodeUserPlaceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CODE_USER_PLACE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserPlaceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserPlace"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeCodeUserPlace GetBySeCodeUserPlaceId(TransactionManager transactionManager, System.Decimal _seCodeUserPlaceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeCodeUserPlace&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeCodeUserPlace&gt;"/></returns>
		public static TList<SeCodeUserPlace> Fill(IDataReader reader, TList<SeCodeUserPlace> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeCodeUserPlace c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeCodeUserPlace")
					.Append("|").Append((System.Decimal)reader["SE_CODE_USER_PLACE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeCodeUserPlace>(
					key.ToString(), // EntityTrackingKey
					"SeCodeUserPlace",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeCodeUserPlace();
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
					c.SeCodeUserPlaceId = (System.Decimal)reader["SE_CODE_USER_PLACE_ID"];
					c.OriginalSeCodeUserPlaceId = c.SeCodeUserPlaceId;
					c.DescAr = (System.String)reader["DESC_AR"];
					c.DescEn = Convert.IsDBNull(reader["DESC_EN"]) ? null : (System.String)reader["DESC_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserPlace"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeCodeUserPlace"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeCodeUserPlace entity)
		{
			if (!reader.Read()) return;
			
			entity.SeCodeUserPlaceId = (System.Decimal)reader[((int)SeCodeUserPlaceColumn.SeCodeUserPlaceId - 1)];
			entity.OriginalSeCodeUserPlaceId = (System.Decimal)reader["SE_CODE_USER_PLACE_ID"];
			entity.DescAr = (System.String)reader[((int)SeCodeUserPlaceColumn.DescAr - 1)];
			entity.DescEn = (reader.IsDBNull(((int)SeCodeUserPlaceColumn.DescEn - 1)))?null:(System.String)reader[((int)SeCodeUserPlaceColumn.DescEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserPlace"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeCodeUserPlace"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeCodeUserPlace entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeCodeUserPlaceId = (System.Decimal)dataRow["SE_CODE_USER_PLACE_ID"];
			entity.OriginalSeCodeUserPlaceId = (System.Decimal)dataRow["SE_CODE_USER_PLACE_ID"];
			entity.DescAr = (System.String)dataRow["DESC_AR"];
			entity.DescEn = Convert.IsDBNull(dataRow["DESC_EN"]) ? null : (System.String)dataRow["DESC_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeCodeUserPlace"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeCodeUserPlace Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeCodeUserPlace entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySeCodeUserPlaceId methods when available
			
			#region SeUserCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUser>|SeUserCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserCollection = DataRepository.SeUserProvider.GetBySeCodeUserPlaceId(transactionManager, entity.SeCodeUserPlaceId);

				if (deep && entity.SeUserCollection.Count > 0)
				{
					deepHandles.Add("SeUserCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUser>) DataRepository.SeUserProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeCodeUserPlace object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeCodeUserPlace instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeCodeUserPlace Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeCodeUserPlace entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SeUser>
				if (CanDeepSave(entity.SeUserCollection, "List<SeUser>|SeUserCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUser child in entity.SeUserCollection)
					{
						if(child.SeCodeUserPlaceIdSource != null)
						{
							child.SeCodeUserPlaceId = child.SeCodeUserPlaceIdSource.SeCodeUserPlaceId;
						}
						else
						{
							child.SeCodeUserPlaceId = entity.SeCodeUserPlaceId;
						}

					}

					if (entity.SeUserCollection.Count > 0 || entity.SeUserCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserCollection);
						
						deepHandles.Add("SeUserCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUser >) DataRepository.SeUserProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserCollection, deepSaveType, childTypes, innerList }
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
	
	#region SeCodeUserPlaceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeCodeUserPlace</c>
	///</summary>
	public enum SeCodeUserPlaceChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SeCodeUserPlace</c> as OneToMany for SeUserCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUser>))]
		SeUserCollection,
	}
	
	#endregion SeCodeUserPlaceChildEntityTypes
	
	#region SeCodeUserPlaceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeCodeUserPlaceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeCodeUserPlace"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeCodeUserPlaceFilterBuilder : SqlFilterBuilder<SeCodeUserPlaceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeCodeUserPlaceFilterBuilder class.
		/// </summary>
		public SeCodeUserPlaceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeCodeUserPlaceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeCodeUserPlaceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeCodeUserPlaceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeCodeUserPlaceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeCodeUserPlaceFilterBuilder
	
	#region SeCodeUserPlaceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeCodeUserPlaceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeCodeUserPlace"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeCodeUserPlaceParameterBuilder : ParameterizedSqlFilterBuilder<SeCodeUserPlaceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeCodeUserPlaceParameterBuilder class.
		/// </summary>
		public SeCodeUserPlaceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeCodeUserPlaceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeCodeUserPlaceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeCodeUserPlaceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeCodeUserPlaceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeCodeUserPlaceParameterBuilder
	
	#region SeCodeUserPlaceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeCodeUserPlaceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeCodeUserPlace"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeCodeUserPlaceSortBuilder : SqlSortBuilder<SeCodeUserPlaceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeCodeUserPlaceSqlSortBuilder class.
		/// </summary>
		public SeCodeUserPlaceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeCodeUserPlaceSortBuilder
	
} // end namespace
