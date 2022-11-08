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
	/// This class is the base class for any <see cref="GsCodeEducationLevelProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeEducationLevelProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeEducationLevel, UMIS_VER2.BusinessLyer.GsCodeEducationLevelKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeEducationLevelKey key)
		{
			return Delete(transactionManager, key.GsCodeEducationLevelId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeEducationLevelId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeEducationLevelId)
		{
			return Delete(null, _gsCodeEducationLevelId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeEducationLevelId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeEducationLevelId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeEducationLevel Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeEducationLevelKey key, int start, int pageLength)
		{
			return GetByGsCodeEducationLevelId(transactionManager, key.GsCodeEducationLevelId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_EDUCATION_LEVEL index.
		/// </summary>
		/// <param name="_gsCodeEducationLevelId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeEducationLevel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeEducationLevel GetByGsCodeEducationLevelId(System.Decimal _gsCodeEducationLevelId)
		{
			int count = -1;
			return GetByGsCodeEducationLevelId(null,_gsCodeEducationLevelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_EDUCATION_LEVEL index.
		/// </summary>
		/// <param name="_gsCodeEducationLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeEducationLevel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeEducationLevel GetByGsCodeEducationLevelId(System.Decimal _gsCodeEducationLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeEducationLevelId(null, _gsCodeEducationLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_EDUCATION_LEVEL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeEducationLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeEducationLevel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeEducationLevel GetByGsCodeEducationLevelId(TransactionManager transactionManager, System.Decimal _gsCodeEducationLevelId)
		{
			int count = -1;
			return GetByGsCodeEducationLevelId(transactionManager, _gsCodeEducationLevelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_EDUCATION_LEVEL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeEducationLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeEducationLevel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeEducationLevel GetByGsCodeEducationLevelId(TransactionManager transactionManager, System.Decimal _gsCodeEducationLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeEducationLevelId(transactionManager, _gsCodeEducationLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_EDUCATION_LEVEL index.
		/// </summary>
		/// <param name="_gsCodeEducationLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeEducationLevel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeEducationLevel GetByGsCodeEducationLevelId(System.Decimal _gsCodeEducationLevelId, int start, int pageLength, out int count)
		{
			return GetByGsCodeEducationLevelId(null, _gsCodeEducationLevelId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_EDUCATION_LEVEL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeEducationLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeEducationLevel"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeEducationLevel GetByGsCodeEducationLevelId(TransactionManager transactionManager, System.Decimal _gsCodeEducationLevelId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeEducationLevel&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeEducationLevel&gt;"/></returns>
		public static TList<GsCodeEducationLevel> Fill(IDataReader reader, TList<GsCodeEducationLevel> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeEducationLevel c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeEducationLevel")
					.Append("|").Append((System.Decimal)reader["GS_CODE_EDUCATION_LEVEL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeEducationLevel>(
					key.ToString(), // EntityTrackingKey
					"GsCodeEducationLevel",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeEducationLevel();
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
					c.GsCodeEducationLevelId = (System.Decimal)reader["GS_CODE_EDUCATION_LEVEL_ID"];
					c.OriginalGsCodeEducationLevelId = c.GsCodeEducationLevelId;
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeEducationLevel"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeEducationLevel"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeEducationLevel entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeEducationLevelId = (System.Decimal)reader[((int)GsCodeEducationLevelColumn.GsCodeEducationLevelId - 1)];
			entity.OriginalGsCodeEducationLevelId = (System.Decimal)reader["GS_CODE_EDUCATION_LEVEL_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCodeEducationLevelColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)GsCodeEducationLevelColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeEducationLevel"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeEducationLevel"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeEducationLevel entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeEducationLevelId = (System.Decimal)dataRow["GS_CODE_EDUCATION_LEVEL_ID"];
			entity.OriginalGsCodeEducationLevelId = (System.Decimal)dataRow["GS_CODE_EDUCATION_LEVEL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeEducationLevel"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeEducationLevel Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeEducationLevel entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeEducationLevelId methods when available
			
			#region EdGuardCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdGuard>|EdGuardCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdGuardCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdGuardCollection = DataRepository.EdGuardProvider.GetByGsCodeEducationLevelId(transactionManager, entity.GsCodeEducationLevelId);

				if (deep && entity.EdGuardCollection.Count > 0)
				{
					deepHandles.Add("EdGuardCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdGuard>) DataRepository.EdGuardProvider.DeepLoad,
						new object[] { transactionManager, entity.EdGuardCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeEducationLevel object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeEducationLevel instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeEducationLevel Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeEducationLevel entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdGuard>
				if (CanDeepSave(entity.EdGuardCollection, "List<EdGuard>|EdGuardCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdGuard child in entity.EdGuardCollection)
					{
						if(child.GsCodeEducationLevelIdSource != null)
						{
							child.GsCodeEducationLevelId = child.GsCodeEducationLevelIdSource.GsCodeEducationLevelId;
						}
						else
						{
							child.GsCodeEducationLevelId = entity.GsCodeEducationLevelId;
						}

					}

					if (entity.EdGuardCollection.Count > 0 || entity.EdGuardCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdGuardProvider.Save(transactionManager, entity.EdGuardCollection);
						
						deepHandles.Add("EdGuardCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdGuard >) DataRepository.EdGuardProvider.DeepSave,
							new object[] { transactionManager, entity.EdGuardCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCodeEducationLevelChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeEducationLevel</c>
	///</summary>
	public enum GsCodeEducationLevelChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCodeEducationLevel</c> as OneToMany for EdGuardCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdGuard>))]
		EdGuardCollection,
	}
	
	#endregion GsCodeEducationLevelChildEntityTypes
	
	#region GsCodeEducationLevelFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeEducationLevelColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeEducationLevel"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeEducationLevelFilterBuilder : SqlFilterBuilder<GsCodeEducationLevelColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeEducationLevelFilterBuilder class.
		/// </summary>
		public GsCodeEducationLevelFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeEducationLevelFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeEducationLevelFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeEducationLevelFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeEducationLevelFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeEducationLevelFilterBuilder
	
	#region GsCodeEducationLevelParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeEducationLevelColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeEducationLevel"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeEducationLevelParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeEducationLevelColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeEducationLevelParameterBuilder class.
		/// </summary>
		public GsCodeEducationLevelParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeEducationLevelParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeEducationLevelParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeEducationLevelParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeEducationLevelParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeEducationLevelParameterBuilder
	
	#region GsCodeEducationLevelSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeEducationLevelColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeEducationLevel"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeEducationLevelSortBuilder : SqlSortBuilder<GsCodeEducationLevelColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeEducationLevelSqlSortBuilder class.
		/// </summary>
		public GsCodeEducationLevelSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeEducationLevelSortBuilder
	
} // end namespace
