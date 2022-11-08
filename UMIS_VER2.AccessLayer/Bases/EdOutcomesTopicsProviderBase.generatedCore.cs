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
	/// This class is the base class for any <see cref="EdOutcomesTopicsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdOutcomesTopicsProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdOutcomesTopics, UMIS_VER2.BusinessLyer.EdOutcomesTopicsKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdOutcomesTopicsKey key)
		{
			return Delete(transactionManager, key.EdOutcomesTopicsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edOutcomesTopicsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edOutcomesTopicsId)
		{
			return Delete(null, _edOutcomesTopicsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOutcomesTopicsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edOutcomesTopicsId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdOutcomesTopics Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdOutcomesTopicsKey key, int start, int pageLength)
		{
			return GetByEdOutcomesTopicsId(transactionManager, key.EdOutcomesTopicsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_Outcomes_Topics index.
		/// </summary>
		/// <param name="_edOutcomesTopicsId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOutcomesTopics"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOutcomesTopics GetByEdOutcomesTopicsId(System.Decimal _edOutcomesTopicsId)
		{
			int count = -1;
			return GetByEdOutcomesTopicsId(null,_edOutcomesTopicsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_Outcomes_Topics index.
		/// </summary>
		/// <param name="_edOutcomesTopicsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOutcomesTopics"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOutcomesTopics GetByEdOutcomesTopicsId(System.Decimal _edOutcomesTopicsId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdOutcomesTopicsId(null, _edOutcomesTopicsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_Outcomes_Topics index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOutcomesTopicsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOutcomesTopics"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOutcomesTopics GetByEdOutcomesTopicsId(TransactionManager transactionManager, System.Decimal _edOutcomesTopicsId)
		{
			int count = -1;
			return GetByEdOutcomesTopicsId(transactionManager, _edOutcomesTopicsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_Outcomes_Topics index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOutcomesTopicsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOutcomesTopics"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOutcomesTopics GetByEdOutcomesTopicsId(TransactionManager transactionManager, System.Decimal _edOutcomesTopicsId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdOutcomesTopicsId(transactionManager, _edOutcomesTopicsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_Outcomes_Topics index.
		/// </summary>
		/// <param name="_edOutcomesTopicsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOutcomesTopics"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOutcomesTopics GetByEdOutcomesTopicsId(System.Decimal _edOutcomesTopicsId, int start, int pageLength, out int count)
		{
			return GetByEdOutcomesTopicsId(null, _edOutcomesTopicsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_Outcomes_Topics index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOutcomesTopicsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOutcomesTopics"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdOutcomesTopics GetByEdOutcomesTopicsId(TransactionManager transactionManager, System.Decimal _edOutcomesTopicsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdOutcomesTopics&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdOutcomesTopics&gt;"/></returns>
		public static TList<EdOutcomesTopics> Fill(IDataReader reader, TList<EdOutcomesTopics> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdOutcomesTopics c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdOutcomesTopics")
					.Append("|").Append((System.Decimal)reader["ED_Outcomes_Topics_Id"]).ToString();
					c = EntityManager.LocateOrCreate<EdOutcomesTopics>(
					key.ToString(), // EntityTrackingKey
					"EdOutcomesTopics",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdOutcomesTopics();
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
					c.EdOutcomesTopicsId = (System.Decimal)reader["ED_Outcomes_Topics_Id"];
					c.OriginalEdOutcomesTopicsId = c.EdOutcomesTopicsId;
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.IsActive = Convert.IsDBNull(reader["Is_Active"]) ? null : (System.Boolean?)reader["Is_Active"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdOutcomesTopics"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdOutcomesTopics"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdOutcomesTopics entity)
		{
			if (!reader.Read()) return;
			
			entity.EdOutcomesTopicsId = (System.Decimal)reader[((int)EdOutcomesTopicsColumn.EdOutcomesTopicsId - 1)];
			entity.OriginalEdOutcomesTopicsId = (System.Decimal)reader["ED_Outcomes_Topics_Id"];
			entity.DescrAr = (reader.IsDBNull(((int)EdOutcomesTopicsColumn.DescrAr - 1)))?null:(System.String)reader[((int)EdOutcomesTopicsColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EdOutcomesTopicsColumn.DescrEn - 1)))?null:(System.String)reader[((int)EdOutcomesTopicsColumn.DescrEn - 1)];
			entity.IsActive = (reader.IsDBNull(((int)EdOutcomesTopicsColumn.IsActive - 1)))?null:(System.Boolean?)reader[((int)EdOutcomesTopicsColumn.IsActive - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdOutcomesTopics"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdOutcomesTopics"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdOutcomesTopics entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdOutcomesTopicsId = (System.Decimal)dataRow["ED_Outcomes_Topics_Id"];
			entity.OriginalEdOutcomesTopicsId = (System.Decimal)dataRow["ED_Outcomes_Topics_Id"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.IsActive = Convert.IsDBNull(dataRow["Is_Active"]) ? null : (System.Boolean?)dataRow["Is_Active"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdOutcomesTopics"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdOutcomesTopics Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdOutcomesTopics entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdOutcomesTopicsId methods when available
			
			#region EdCourseOutcomesTopicsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseOutcomesTopics>|EdCourseOutcomesTopicsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseOutcomesTopicsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseOutcomesTopicsCollection = DataRepository.EdCourseOutcomesTopicsProvider.GetByEdOutcomesTopicsId(transactionManager, entity.EdOutcomesTopicsId);

				if (deep && entity.EdCourseOutcomesTopicsCollection.Count > 0)
				{
					deepHandles.Add("EdCourseOutcomesTopicsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseOutcomesTopics>) DataRepository.EdCourseOutcomesTopicsProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseOutcomesTopicsCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdOutcomesTopics object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdOutcomesTopics instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdOutcomesTopics Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdOutcomesTopics entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdCourseOutcomesTopics>
				if (CanDeepSave(entity.EdCourseOutcomesTopicsCollection, "List<EdCourseOutcomesTopics>|EdCourseOutcomesTopicsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseOutcomesTopics child in entity.EdCourseOutcomesTopicsCollection)
					{
						if(child.EdOutcomesTopicsIdSource != null)
						{
							child.EdOutcomesTopicsId = child.EdOutcomesTopicsIdSource.EdOutcomesTopicsId;
						}
						else
						{
							child.EdOutcomesTopicsId = entity.EdOutcomesTopicsId;
						}

					}

					if (entity.EdCourseOutcomesTopicsCollection.Count > 0 || entity.EdCourseOutcomesTopicsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseOutcomesTopicsProvider.Save(transactionManager, entity.EdCourseOutcomesTopicsCollection);
						
						deepHandles.Add("EdCourseOutcomesTopicsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseOutcomesTopics >) DataRepository.EdCourseOutcomesTopicsProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseOutcomesTopicsCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdOutcomesTopicsChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdOutcomesTopics</c>
	///</summary>
	public enum EdOutcomesTopicsChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdOutcomesTopics</c> as OneToMany for EdCourseOutcomesTopicsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseOutcomesTopics>))]
		EdCourseOutcomesTopicsCollection,
	}
	
	#endregion EdOutcomesTopicsChildEntityTypes
	
	#region EdOutcomesTopicsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdOutcomesTopicsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdOutcomesTopics"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdOutcomesTopicsFilterBuilder : SqlFilterBuilder<EdOutcomesTopicsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdOutcomesTopicsFilterBuilder class.
		/// </summary>
		public EdOutcomesTopicsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdOutcomesTopicsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdOutcomesTopicsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdOutcomesTopicsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdOutcomesTopicsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdOutcomesTopicsFilterBuilder
	
	#region EdOutcomesTopicsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdOutcomesTopicsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdOutcomesTopics"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdOutcomesTopicsParameterBuilder : ParameterizedSqlFilterBuilder<EdOutcomesTopicsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdOutcomesTopicsParameterBuilder class.
		/// </summary>
		public EdOutcomesTopicsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdOutcomesTopicsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdOutcomesTopicsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdOutcomesTopicsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdOutcomesTopicsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdOutcomesTopicsParameterBuilder
	
	#region EdOutcomesTopicsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdOutcomesTopicsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdOutcomesTopics"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdOutcomesTopicsSortBuilder : SqlSortBuilder<EdOutcomesTopicsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdOutcomesTopicsSqlSortBuilder class.
		/// </summary>
		public EdOutcomesTopicsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdOutcomesTopicsSortBuilder
	
} // end namespace
