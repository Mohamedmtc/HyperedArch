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
	/// This class is the base class for any <see cref="SeVersionProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeVersionProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeVersion, UMIS_VER2.BusinessLyer.SeVersionKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeVersionKey key)
		{
			return Delete(transactionManager, key.SeVersionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seVersionId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seVersionId)
		{
			return Delete(null, _seVersionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seVersionId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seVersionId);		
		
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
		public override UMIS_VER2.BusinessLyer.SeVersion Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeVersionKey key, int start, int pageLength)
		{
			return GetBySeVersionId(transactionManager, key.SeVersionId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SE_CODE_CHANGE_TYPE__1 index.
		/// </summary>
		/// <param name="_seCodeChangeTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeVersion&gt;"/> class.</returns>
		public TList<SeVersion> GetBySeCodeChangeTypeId(System.Decimal _seCodeChangeTypeId)
		{
			int count = -1;
			return GetBySeCodeChangeTypeId(null,_seCodeChangeTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CODE_CHANGE_TYPE__1 index.
		/// </summary>
		/// <param name="_seCodeChangeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeVersion&gt;"/> class.</returns>
		public TList<SeVersion> GetBySeCodeChangeTypeId(System.Decimal _seCodeChangeTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeChangeTypeId(null, _seCodeChangeTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CODE_CHANGE_TYPE__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeChangeTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeVersion&gt;"/> class.</returns>
		public TList<SeVersion> GetBySeCodeChangeTypeId(TransactionManager transactionManager, System.Decimal _seCodeChangeTypeId)
		{
			int count = -1;
			return GetBySeCodeChangeTypeId(transactionManager, _seCodeChangeTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CODE_CHANGE_TYPE__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeChangeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeVersion&gt;"/> class.</returns>
		public TList<SeVersion> GetBySeCodeChangeTypeId(TransactionManager transactionManager, System.Decimal _seCodeChangeTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeChangeTypeId(transactionManager, _seCodeChangeTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CODE_CHANGE_TYPE__1 index.
		/// </summary>
		/// <param name="_seCodeChangeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeVersion&gt;"/> class.</returns>
		public TList<SeVersion> GetBySeCodeChangeTypeId(System.Decimal _seCodeChangeTypeId, int start, int pageLength, out int count)
		{
			return GetBySeCodeChangeTypeId(null, _seCodeChangeTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CODE_CHANGE_TYPE__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeChangeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeVersion&gt;"/> class.</returns>
		public abstract TList<SeVersion> GetBySeCodeChangeTypeId(TransactionManager transactionManager, System.Decimal _seCodeChangeTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_VERSION index.
		/// </summary>
		/// <param name="_seVersionId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeVersion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeVersion GetBySeVersionId(System.Decimal _seVersionId)
		{
			int count = -1;
			return GetBySeVersionId(null,_seVersionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_VERSION index.
		/// </summary>
		/// <param name="_seVersionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeVersion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeVersion GetBySeVersionId(System.Decimal _seVersionId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeVersionId(null, _seVersionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_VERSION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seVersionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeVersion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeVersion GetBySeVersionId(TransactionManager transactionManager, System.Decimal _seVersionId)
		{
			int count = -1;
			return GetBySeVersionId(transactionManager, _seVersionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_VERSION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seVersionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeVersion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeVersion GetBySeVersionId(TransactionManager transactionManager, System.Decimal _seVersionId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeVersionId(transactionManager, _seVersionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_VERSION index.
		/// </summary>
		/// <param name="_seVersionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeVersion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeVersion GetBySeVersionId(System.Decimal _seVersionId, int start, int pageLength, out int count)
		{
			return GetBySeVersionId(null, _seVersionId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_VERSION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seVersionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeVersion"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeVersion GetBySeVersionId(TransactionManager transactionManager, System.Decimal _seVersionId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeVersion&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeVersion&gt;"/></returns>
		public static TList<SeVersion> Fill(IDataReader reader, TList<SeVersion> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeVersion c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeVersion")
					.Append("|").Append((System.Decimal)reader["SE_Version_Id"]).ToString();
					c = EntityManager.LocateOrCreate<SeVersion>(
					key.ToString(), // EntityTrackingKey
					"SeVersion",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeVersion();
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
					c.SeVersionId = (System.Decimal)reader["SE_Version_Id"];
					c.VersionName = (System.String)reader["Version_Name"];
					c.ChangeDate = (System.DateTime)reader["Change_Date"];
					c.SeCodeChangeTypeId = (System.Decimal)reader["SE_CODE_CHANGE_TYPE_ID"];
					c.HotfixName = Convert.IsDBNull(reader["HOTFIX_NAME"]) ? null : (System.String)reader["HOTFIX_NAME"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeVersion"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeVersion"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeVersion entity)
		{
			if (!reader.Read()) return;
			
			entity.SeVersionId = (System.Decimal)reader[((int)SeVersionColumn.SeVersionId - 1)];
			entity.VersionName = (System.String)reader[((int)SeVersionColumn.VersionName - 1)];
			entity.ChangeDate = (System.DateTime)reader[((int)SeVersionColumn.ChangeDate - 1)];
			entity.SeCodeChangeTypeId = (System.Decimal)reader[((int)SeVersionColumn.SeCodeChangeTypeId - 1)];
			entity.HotfixName = (reader.IsDBNull(((int)SeVersionColumn.HotfixName - 1)))?null:(System.String)reader[((int)SeVersionColumn.HotfixName - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeVersion"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeVersion"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeVersion entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeVersionId = (System.Decimal)dataRow["SE_Version_Id"];
			entity.VersionName = (System.String)dataRow["Version_Name"];
			entity.ChangeDate = (System.DateTime)dataRow["Change_Date"];
			entity.SeCodeChangeTypeId = (System.Decimal)dataRow["SE_CODE_CHANGE_TYPE_ID"];
			entity.HotfixName = Convert.IsDBNull(dataRow["HOTFIX_NAME"]) ? null : (System.String)dataRow["HOTFIX_NAME"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeVersion"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeVersion Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeVersion entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SeCodeChangeTypeIdSource	
			if (CanDeepLoad(entity, "SeCodeChangeType|SeCodeChangeTypeIdSource", deepLoadType, innerList) 
				&& entity.SeCodeChangeTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeCodeChangeTypeId;
				SeCodeChangeType tmpEntity = EntityManager.LocateEntity<SeCodeChangeType>(EntityLocator.ConstructKeyFromPkItems(typeof(SeCodeChangeType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeCodeChangeTypeIdSource = tmpEntity;
				else
					entity.SeCodeChangeTypeIdSource = DataRepository.SeCodeChangeTypeProvider.GetBySeCodeChangeTypeId(transactionManager, entity.SeCodeChangeTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeCodeChangeTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeCodeChangeTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeCodeChangeTypeProvider.DeepLoad(transactionManager, entity.SeCodeChangeTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeCodeChangeTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeVersion object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeVersion instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeVersion Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeVersion entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SeCodeChangeTypeIdSource
			if (CanDeepSave(entity, "SeCodeChangeType|SeCodeChangeTypeIdSource", deepSaveType, innerList) 
				&& entity.SeCodeChangeTypeIdSource != null)
			{
				DataRepository.SeCodeChangeTypeProvider.Save(transactionManager, entity.SeCodeChangeTypeIdSource);
				entity.SeCodeChangeTypeId = entity.SeCodeChangeTypeIdSource.SeCodeChangeTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
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
	
	#region SeVersionChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeVersion</c>
	///</summary>
	public enum SeVersionChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SeCodeChangeType</c> at SeCodeChangeTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SeCodeChangeType))]
		SeCodeChangeType,
	}
	
	#endregion SeVersionChildEntityTypes
	
	#region SeVersionFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeVersionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeVersion"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeVersionFilterBuilder : SqlFilterBuilder<SeVersionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeVersionFilterBuilder class.
		/// </summary>
		public SeVersionFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeVersionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeVersionFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeVersionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeVersionFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeVersionFilterBuilder
	
	#region SeVersionParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeVersionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeVersion"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeVersionParameterBuilder : ParameterizedSqlFilterBuilder<SeVersionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeVersionParameterBuilder class.
		/// </summary>
		public SeVersionParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeVersionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeVersionParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeVersionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeVersionParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeVersionParameterBuilder
	
	#region SeVersionSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeVersionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeVersion"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeVersionSortBuilder : SqlSortBuilder<SeVersionColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeVersionSqlSortBuilder class.
		/// </summary>
		public SeVersionSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeVersionSortBuilder
	
} // end namespace
