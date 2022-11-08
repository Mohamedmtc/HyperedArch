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
	/// This class is the base class for any <see cref="PgCodeRsrchStrategyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgCodeRsrchStrategyProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy, UMIS_VER2.BusinessLyer.PgCodeRsrchStrategyKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCodeRsrchStrategyKey key)
		{
			return Delete(transactionManager, key.PgCodeResearchStrategyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgCodeResearchStrategyId">XX not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgCodeResearchStrategyId)
		{
			return Delete(null, _pgCodeResearchStrategyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeResearchStrategyId">XX not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgCodeResearchStrategyId);		
		
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
		public override UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCodeRsrchStrategyKey key, int start, int pageLength)
		{
			return GetByPgCodeResearchStrategyId(transactionManager, key.PgCodeResearchStrategyId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_CODE_RSRCH_STRATEGY index.
		/// </summary>
		/// <param name="_pgCodeResearchStrategyId">XX not used</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy GetByPgCodeResearchStrategyId(System.Decimal _pgCodeResearchStrategyId)
		{
			int count = -1;
			return GetByPgCodeResearchStrategyId(null,_pgCodeResearchStrategyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CODE_RSRCH_STRATEGY index.
		/// </summary>
		/// <param name="_pgCodeResearchStrategyId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy GetByPgCodeResearchStrategyId(System.Decimal _pgCodeResearchStrategyId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCodeResearchStrategyId(null, _pgCodeResearchStrategyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CODE_RSRCH_STRATEGY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeResearchStrategyId">XX not used</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy GetByPgCodeResearchStrategyId(TransactionManager transactionManager, System.Decimal _pgCodeResearchStrategyId)
		{
			int count = -1;
			return GetByPgCodeResearchStrategyId(transactionManager, _pgCodeResearchStrategyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CODE_RSRCH_STRATEGY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeResearchStrategyId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy GetByPgCodeResearchStrategyId(TransactionManager transactionManager, System.Decimal _pgCodeResearchStrategyId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCodeResearchStrategyId(transactionManager, _pgCodeResearchStrategyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CODE_RSRCH_STRATEGY index.
		/// </summary>
		/// <param name="_pgCodeResearchStrategyId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy GetByPgCodeResearchStrategyId(System.Decimal _pgCodeResearchStrategyId, int start, int pageLength, out int count)
		{
			return GetByPgCodeResearchStrategyId(null, _pgCodeResearchStrategyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CODE_RSRCH_STRATEGY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeResearchStrategyId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy GetByPgCodeResearchStrategyId(TransactionManager transactionManager, System.Decimal _pgCodeResearchStrategyId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgCodeRsrchStrategy&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgCodeRsrchStrategy&gt;"/></returns>
		public static TList<PgCodeRsrchStrategy> Fill(IDataReader reader, TList<PgCodeRsrchStrategy> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgCodeRsrchStrategy")
					.Append("|").Append((System.Decimal)reader["PG_CODE_RESEARCH_STRATEGY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgCodeRsrchStrategy>(
					key.ToString(), // EntityTrackingKey
					"PgCodeRsrchStrategy",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy();
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
					c.PgCodeResearchStrategyId = (System.Decimal)reader["PG_CODE_RESEARCH_STRATEGY_ID"];
					c.OriginalPgCodeResearchStrategyId = c.PgCodeResearchStrategyId;
					c.ResearchStrategyCode = Convert.IsDBNull(reader["RESEARCH_STRATEGY_CODE"]) ? null : (System.String)reader["RESEARCH_STRATEGY_CODE"];
					c.ResearchStrategyDescAr = (System.String)reader["RESEARCH_STRATEGY_DESC_AR"];
					c.ResearchStrategyDescEn = Convert.IsDBNull(reader["RESEARCH_STRATEGY_DESC_EN"]) ? null : (System.String)reader["RESEARCH_STRATEGY_DESC_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy entity)
		{
			if (!reader.Read()) return;
			
			entity.PgCodeResearchStrategyId = (System.Decimal)reader[((int)PgCodeRsrchStrategyColumn.PgCodeResearchStrategyId - 1)];
			entity.OriginalPgCodeResearchStrategyId = (System.Decimal)reader["PG_CODE_RESEARCH_STRATEGY_ID"];
			entity.ResearchStrategyCode = (reader.IsDBNull(((int)PgCodeRsrchStrategyColumn.ResearchStrategyCode - 1)))?null:(System.String)reader[((int)PgCodeRsrchStrategyColumn.ResearchStrategyCode - 1)];
			entity.ResearchStrategyDescAr = (System.String)reader[((int)PgCodeRsrchStrategyColumn.ResearchStrategyDescAr - 1)];
			entity.ResearchStrategyDescEn = (reader.IsDBNull(((int)PgCodeRsrchStrategyColumn.ResearchStrategyDescEn - 1)))?null:(System.String)reader[((int)PgCodeRsrchStrategyColumn.ResearchStrategyDescEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgCodeResearchStrategyId = (System.Decimal)dataRow["PG_CODE_RESEARCH_STRATEGY_ID"];
			entity.OriginalPgCodeResearchStrategyId = (System.Decimal)dataRow["PG_CODE_RESEARCH_STRATEGY_ID"];
			entity.ResearchStrategyCode = Convert.IsDBNull(dataRow["RESEARCH_STRATEGY_CODE"]) ? null : (System.String)dataRow["RESEARCH_STRATEGY_CODE"];
			entity.ResearchStrategyDescAr = (System.String)dataRow["RESEARCH_STRATEGY_DESC_AR"];
			entity.ResearchStrategyDescEn = Convert.IsDBNull(dataRow["RESEARCH_STRATEGY_DESC_EN"]) ? null : (System.String)dataRow["RESEARCH_STRATEGY_DESC_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgCodeResearchStrategyId methods when available
			
			#region PgSubjectDefinitionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgSubjectDefinition>|PgSubjectDefinitionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgSubjectDefinitionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgSubjectDefinitionCollection = DataRepository.PgSubjectDefinitionProvider.GetByPgCodeResearchStrategyId(transactionManager, entity.PgCodeResearchStrategyId);

				if (deep && entity.PgSubjectDefinitionCollection.Count > 0)
				{
					deepHandles.Add("PgSubjectDefinitionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgSubjectDefinition>) DataRepository.PgSubjectDefinitionProvider.DeepLoad,
						new object[] { transactionManager, entity.PgSubjectDefinitionCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<PgSubjectDefinition>
				if (CanDeepSave(entity.PgSubjectDefinitionCollection, "List<PgSubjectDefinition>|PgSubjectDefinitionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgSubjectDefinition child in entity.PgSubjectDefinitionCollection)
					{
						if(child.PgCodeResearchStrategyIdSource != null)
						{
							child.PgCodeResearchStrategyId = child.PgCodeResearchStrategyIdSource.PgCodeResearchStrategyId;
						}
						else
						{
							child.PgCodeResearchStrategyId = entity.PgCodeResearchStrategyId;
						}

					}

					if (entity.PgSubjectDefinitionCollection.Count > 0 || entity.PgSubjectDefinitionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgSubjectDefinitionProvider.Save(transactionManager, entity.PgSubjectDefinitionCollection);
						
						deepHandles.Add("PgSubjectDefinitionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgSubjectDefinition >) DataRepository.PgSubjectDefinitionProvider.DeepSave,
							new object[] { transactionManager, entity.PgSubjectDefinitionCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgCodeRsrchStrategyChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgCodeRsrchStrategy</c>
	///</summary>
	public enum PgCodeRsrchStrategyChildEntityTypes
	{
		///<summary>
		/// Collection of <c>PgCodeRsrchStrategy</c> as OneToMany for PgSubjectDefinitionCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgSubjectDefinition>))]
		PgSubjectDefinitionCollection,
	}
	
	#endregion PgCodeRsrchStrategyChildEntityTypes
	
	#region PgCodeRsrchStrategyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgCodeRsrchStrategyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCodeRsrchStrategy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgCodeRsrchStrategyFilterBuilder : SqlFilterBuilder<PgCodeRsrchStrategyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCodeRsrchStrategyFilterBuilder class.
		/// </summary>
		public PgCodeRsrchStrategyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgCodeRsrchStrategyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgCodeRsrchStrategyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgCodeRsrchStrategyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgCodeRsrchStrategyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgCodeRsrchStrategyFilterBuilder
	
	#region PgCodeRsrchStrategyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgCodeRsrchStrategyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCodeRsrchStrategy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgCodeRsrchStrategyParameterBuilder : ParameterizedSqlFilterBuilder<PgCodeRsrchStrategyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCodeRsrchStrategyParameterBuilder class.
		/// </summary>
		public PgCodeRsrchStrategyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgCodeRsrchStrategyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgCodeRsrchStrategyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgCodeRsrchStrategyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgCodeRsrchStrategyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgCodeRsrchStrategyParameterBuilder
	
	#region PgCodeRsrchStrategySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgCodeRsrchStrategyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCodeRsrchStrategy"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgCodeRsrchStrategySortBuilder : SqlSortBuilder<PgCodeRsrchStrategyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCodeRsrchStrategySqlSortBuilder class.
		/// </summary>
		public PgCodeRsrchStrategySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgCodeRsrchStrategySortBuilder
	
} // end namespace
