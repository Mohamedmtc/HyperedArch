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
	/// This class is the base class for any <see cref="PgCdeConfTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgCdeConfTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgCdeConfType, UMIS_VER2.BusinessLyer.PgCdeConfTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeConfTypeKey key)
		{
			return Delete(transactionManager, key.PgCdeConfTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgCdeConfTypeId">حالة  المؤتمر. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _pgCdeConfTypeId)
		{
			return Delete(null, _pgCdeConfTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeConfTypeId">حالة  المؤتمر. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _pgCdeConfTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.PgCdeConfType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeConfTypeKey key, int start, int pageLength)
		{
			return GetByPgCdeConfTypeId(transactionManager, key.PgCdeConfTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_CDE_CONF_TYPE index.
		/// </summary>
		/// <param name="_pgCdeConfTypeId">حالة  المؤتمر</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeConfType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeConfType GetByPgCdeConfTypeId(System.Int32 _pgCdeConfTypeId)
		{
			int count = -1;
			return GetByPgCdeConfTypeId(null,_pgCdeConfTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CDE_CONF_TYPE index.
		/// </summary>
		/// <param name="_pgCdeConfTypeId">حالة  المؤتمر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeConfType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeConfType GetByPgCdeConfTypeId(System.Int32 _pgCdeConfTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCdeConfTypeId(null, _pgCdeConfTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CDE_CONF_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeConfTypeId">حالة  المؤتمر</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeConfType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeConfType GetByPgCdeConfTypeId(TransactionManager transactionManager, System.Int32 _pgCdeConfTypeId)
		{
			int count = -1;
			return GetByPgCdeConfTypeId(transactionManager, _pgCdeConfTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CDE_CONF_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeConfTypeId">حالة  المؤتمر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeConfType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeConfType GetByPgCdeConfTypeId(TransactionManager transactionManager, System.Int32 _pgCdeConfTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCdeConfTypeId(transactionManager, _pgCdeConfTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CDE_CONF_TYPE index.
		/// </summary>
		/// <param name="_pgCdeConfTypeId">حالة  المؤتمر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeConfType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeConfType GetByPgCdeConfTypeId(System.Int32 _pgCdeConfTypeId, int start, int pageLength, out int count)
		{
			return GetByPgCdeConfTypeId(null, _pgCdeConfTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CDE_CONF_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeConfTypeId">حالة  المؤتمر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeConfType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgCdeConfType GetByPgCdeConfTypeId(TransactionManager transactionManager, System.Int32 _pgCdeConfTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgCdeConfType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgCdeConfType&gt;"/></returns>
		public static TList<PgCdeConfType> Fill(IDataReader reader, TList<PgCdeConfType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgCdeConfType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgCdeConfType")
					.Append("|").Append((System.Int32)reader["PG_CDE_CONF_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgCdeConfType>(
					key.ToString(), // EntityTrackingKey
					"PgCdeConfType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgCdeConfType();
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
					c.PgCdeConfTypeId = (System.Int32)reader["PG_CDE_CONF_TYPE_ID"];
					c.OriginalPgCdeConfTypeId = c.PgCdeConfTypeId;
					c.ConfTypeAr = (System.String)reader["CONF_TYPE_AR"];
					c.ConfTypeEn = (System.String)reader["CONF_TYPE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgCdeConfType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCdeConfType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgCdeConfType entity)
		{
			if (!reader.Read()) return;
			
			entity.PgCdeConfTypeId = (System.Int32)reader[((int)PgCdeConfTypeColumn.PgCdeConfTypeId - 1)];
			entity.OriginalPgCdeConfTypeId = (System.Int32)reader["PG_CDE_CONF_TYPE_ID"];
			entity.ConfTypeAr = (System.String)reader[((int)PgCdeConfTypeColumn.ConfTypeAr - 1)];
			entity.ConfTypeEn = (System.String)reader[((int)PgCdeConfTypeColumn.ConfTypeEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgCdeConfType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCdeConfType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgCdeConfType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgCdeConfTypeId = (System.Int32)dataRow["PG_CDE_CONF_TYPE_ID"];
			entity.OriginalPgCdeConfTypeId = (System.Int32)dataRow["PG_CDE_CONF_TYPE_ID"];
			entity.ConfTypeAr = (System.String)dataRow["CONF_TYPE_AR"];
			entity.ConfTypeEn = (System.String)dataRow["CONF_TYPE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCdeConfType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgCdeConfType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeConfType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgCdeConfTypeId methods when available
			
			#region PgStudConferenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgStudConference>|PgStudConferenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStudConferenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgStudConferenceCollection = DataRepository.PgStudConferenceProvider.GetByPgCdeConfTypeId(transactionManager, entity.PgCdeConfTypeId);

				if (deep && entity.PgStudConferenceCollection.Count > 0)
				{
					deepHandles.Add("PgStudConferenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgStudConference>) DataRepository.PgStudConferenceProvider.DeepLoad,
						new object[] { transactionManager, entity.PgStudConferenceCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgCdeConfType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgCdeConfType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgCdeConfType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeConfType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<PgStudConference>
				if (CanDeepSave(entity.PgStudConferenceCollection, "List<PgStudConference>|PgStudConferenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgStudConference child in entity.PgStudConferenceCollection)
					{
						if(child.PgCdeConfTypeIdSource != null)
						{
							child.PgCdeConfTypeId = child.PgCdeConfTypeIdSource.PgCdeConfTypeId;
						}
						else
						{
							child.PgCdeConfTypeId = entity.PgCdeConfTypeId;
						}

					}

					if (entity.PgStudConferenceCollection.Count > 0 || entity.PgStudConferenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgStudConferenceProvider.Save(transactionManager, entity.PgStudConferenceCollection);
						
						deepHandles.Add("PgStudConferenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgStudConference >) DataRepository.PgStudConferenceProvider.DeepSave,
							new object[] { transactionManager, entity.PgStudConferenceCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgCdeConfTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgCdeConfType</c>
	///</summary>
	public enum PgCdeConfTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>PgCdeConfType</c> as OneToMany for PgStudConferenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgStudConference>))]
		PgStudConferenceCollection,
	}
	
	#endregion PgCdeConfTypeChildEntityTypes
	
	#region PgCdeConfTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgCdeConfTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCdeConfType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgCdeConfTypeFilterBuilder : SqlFilterBuilder<PgCdeConfTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCdeConfTypeFilterBuilder class.
		/// </summary>
		public PgCdeConfTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgCdeConfTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgCdeConfTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgCdeConfTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgCdeConfTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgCdeConfTypeFilterBuilder
	
	#region PgCdeConfTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgCdeConfTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCdeConfType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgCdeConfTypeParameterBuilder : ParameterizedSqlFilterBuilder<PgCdeConfTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCdeConfTypeParameterBuilder class.
		/// </summary>
		public PgCdeConfTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgCdeConfTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgCdeConfTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgCdeConfTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgCdeConfTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgCdeConfTypeParameterBuilder
	
	#region PgCdeConfTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgCdeConfTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCdeConfType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgCdeConfTypeSortBuilder : SqlSortBuilder<PgCdeConfTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCdeConfTypeSqlSortBuilder class.
		/// </summary>
		public PgCdeConfTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgCdeConfTypeSortBuilder
	
} // end namespace
