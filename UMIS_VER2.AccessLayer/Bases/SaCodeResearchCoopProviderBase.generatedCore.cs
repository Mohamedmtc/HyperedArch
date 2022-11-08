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
	/// This class is the base class for any <see cref="SaCodeResearchCoopProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeResearchCoopProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeResearchCoop, UMIS_VER2.BusinessLyer.SaCodeResearchCoopKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeResearchCoopKey key)
		{
			return Delete(transactionManager, key.SaCodeResearchCooperId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeResearchCooperId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeResearchCooperId)
		{
			return Delete(null, _saCodeResearchCooperId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeResearchCooperId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeResearchCooperId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeResearchCoop Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeResearchCoopKey key, int start, int pageLength)
		{
			return GetBySaCodeResearchCooperId(transactionManager, key.SaCodeResearchCooperId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_RESEARCH_COOP index.
		/// </summary>
		/// <param name="_saCodeResearchCooperId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeResearchCoop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeResearchCoop GetBySaCodeResearchCooperId(System.Decimal _saCodeResearchCooperId)
		{
			int count = -1;
			return GetBySaCodeResearchCooperId(null,_saCodeResearchCooperId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_RESEARCH_COOP index.
		/// </summary>
		/// <param name="_saCodeResearchCooperId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeResearchCoop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeResearchCoop GetBySaCodeResearchCooperId(System.Decimal _saCodeResearchCooperId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeResearchCooperId(null, _saCodeResearchCooperId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_RESEARCH_COOP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeResearchCooperId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeResearchCoop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeResearchCoop GetBySaCodeResearchCooperId(TransactionManager transactionManager, System.Decimal _saCodeResearchCooperId)
		{
			int count = -1;
			return GetBySaCodeResearchCooperId(transactionManager, _saCodeResearchCooperId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_RESEARCH_COOP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeResearchCooperId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeResearchCoop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeResearchCoop GetBySaCodeResearchCooperId(TransactionManager transactionManager, System.Decimal _saCodeResearchCooperId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeResearchCooperId(transactionManager, _saCodeResearchCooperId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_RESEARCH_COOP index.
		/// </summary>
		/// <param name="_saCodeResearchCooperId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeResearchCoop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeResearchCoop GetBySaCodeResearchCooperId(System.Decimal _saCodeResearchCooperId, int start, int pageLength, out int count)
		{
			return GetBySaCodeResearchCooperId(null, _saCodeResearchCooperId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_RESEARCH_COOP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeResearchCooperId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeResearchCoop"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeResearchCoop GetBySaCodeResearchCooperId(TransactionManager transactionManager, System.Decimal _saCodeResearchCooperId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeResearchCoop&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeResearchCoop&gt;"/></returns>
		public static TList<SaCodeResearchCoop> Fill(IDataReader reader, TList<SaCodeResearchCoop> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeResearchCoop c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeResearchCoop")
					.Append("|").Append((System.Decimal)reader["SA_CODE_RESEARCH_COOPER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeResearchCoop>(
					key.ToString(), // EntityTrackingKey
					"SaCodeResearchCoop",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeResearchCoop();
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
					c.SaCodeResearchCooperId = (System.Decimal)reader["SA_CODE_RESEARCH_COOPER_ID"];
					c.OriginalSaCodeResearchCooperId = c.SaCodeResearchCooperId;
					c.CooperationDescr = (System.String)reader["COOPERATION_DESCR"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeResearchCoop"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeResearchCoop"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeResearchCoop entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeResearchCooperId = (System.Decimal)reader[((int)SaCodeResearchCoopColumn.SaCodeResearchCooperId - 1)];
			entity.OriginalSaCodeResearchCooperId = (System.Decimal)reader["SA_CODE_RESEARCH_COOPER_ID"];
			entity.CooperationDescr = (System.String)reader[((int)SaCodeResearchCoopColumn.CooperationDescr - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeResearchCoop"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeResearchCoop"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeResearchCoop entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeResearchCooperId = (System.Decimal)dataRow["SA_CODE_RESEARCH_COOPER_ID"];
			entity.OriginalSaCodeResearchCooperId = (System.Decimal)dataRow["SA_CODE_RESEARCH_COOPER_ID"];
			entity.CooperationDescr = (System.String)dataRow["COOPERATION_DESCR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeResearchCoop"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeResearchCoop Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeResearchCoop entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeResearchCooperId methods when available
			
			#region SaResearchTeamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaResearchTeam>|SaResearchTeamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaResearchTeamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaResearchTeamCollection = DataRepository.SaResearchTeamProvider.GetBySaCodeResearchCoopId(transactionManager, entity.SaCodeResearchCooperId);

				if (deep && entity.SaResearchTeamCollection.Count > 0)
				{
					deepHandles.Add("SaResearchTeamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaResearchTeam>) DataRepository.SaResearchTeamProvider.DeepLoad,
						new object[] { transactionManager, entity.SaResearchTeamCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeResearchCoop object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeResearchCoop instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeResearchCoop Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeResearchCoop entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaResearchTeam>
				if (CanDeepSave(entity.SaResearchTeamCollection, "List<SaResearchTeam>|SaResearchTeamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaResearchTeam child in entity.SaResearchTeamCollection)
					{
						if(child.SaCodeResearchCoopIdSource != null)
						{
							child.SaCodeResearchCoopId = child.SaCodeResearchCoopIdSource.SaCodeResearchCooperId;
						}
						else
						{
							child.SaCodeResearchCoopId = entity.SaCodeResearchCooperId;
						}

					}

					if (entity.SaResearchTeamCollection.Count > 0 || entity.SaResearchTeamCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaResearchTeamProvider.Save(transactionManager, entity.SaResearchTeamCollection);
						
						deepHandles.Add("SaResearchTeamCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaResearchTeam >) DataRepository.SaResearchTeamProvider.DeepSave,
							new object[] { transactionManager, entity.SaResearchTeamCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodeResearchCoopChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeResearchCoop</c>
	///</summary>
	public enum SaCodeResearchCoopChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCodeResearchCoop</c> as OneToMany for SaResearchTeamCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaResearchTeam>))]
		SaResearchTeamCollection,
	}
	
	#endregion SaCodeResearchCoopChildEntityTypes
	
	#region SaCodeResearchCoopFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeResearchCoopColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeResearchCoop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeResearchCoopFilterBuilder : SqlFilterBuilder<SaCodeResearchCoopColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeResearchCoopFilterBuilder class.
		/// </summary>
		public SaCodeResearchCoopFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeResearchCoopFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeResearchCoopFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeResearchCoopFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeResearchCoopFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeResearchCoopFilterBuilder
	
	#region SaCodeResearchCoopParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeResearchCoopColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeResearchCoop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeResearchCoopParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeResearchCoopColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeResearchCoopParameterBuilder class.
		/// </summary>
		public SaCodeResearchCoopParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeResearchCoopParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeResearchCoopParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeResearchCoopParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeResearchCoopParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeResearchCoopParameterBuilder
	
	#region SaCodeResearchCoopSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeResearchCoopColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeResearchCoop"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeResearchCoopSortBuilder : SqlSortBuilder<SaCodeResearchCoopColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeResearchCoopSqlSortBuilder class.
		/// </summary>
		public SaCodeResearchCoopSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeResearchCoopSortBuilder
	
} // end namespace
