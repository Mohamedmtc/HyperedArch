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
	/// This class is the base class for any <see cref="FeeCdeFundProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeCdeFundProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeCdeFund, UMIS_VER2.BusinessLyer.FeeCdeFundKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeFundKey key)
		{
			return Delete(transactionManager, key.FeeCdeFundId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeCdeFundId">Fund Codes Rules. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _feeCdeFundId)
		{
			return Delete(null, _feeCdeFundId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeFundId">Fund Codes Rules. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _feeCdeFundId);		
		
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
		public override UMIS_VER2.BusinessLyer.FeeCdeFund Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeFundKey key, int start, int pageLength)
		{
			return GetByFeeCdeFundId(transactionManager, key.FeeCdeFundId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_CDE_FUND index.
		/// </summary>
		/// <param name="_feeCdeFundId">Fund Codes Rules</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeFund"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeFund GetByFeeCdeFundId(System.Int32 _feeCdeFundId)
		{
			int count = -1;
			return GetByFeeCdeFundId(null,_feeCdeFundId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_FUND index.
		/// </summary>
		/// <param name="_feeCdeFundId">Fund Codes Rules</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeFund"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeFund GetByFeeCdeFundId(System.Int32 _feeCdeFundId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeFundId(null, _feeCdeFundId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_FUND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeFundId">Fund Codes Rules</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeFund"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeFund GetByFeeCdeFundId(TransactionManager transactionManager, System.Int32 _feeCdeFundId)
		{
			int count = -1;
			return GetByFeeCdeFundId(transactionManager, _feeCdeFundId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_FUND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeFundId">Fund Codes Rules</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeFund"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeFund GetByFeeCdeFundId(TransactionManager transactionManager, System.Int32 _feeCdeFundId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeFundId(transactionManager, _feeCdeFundId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_FUND index.
		/// </summary>
		/// <param name="_feeCdeFundId">Fund Codes Rules</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeFund"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeFund GetByFeeCdeFundId(System.Int32 _feeCdeFundId, int start, int pageLength, out int count)
		{
			return GetByFeeCdeFundId(null, _feeCdeFundId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_FUND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeFundId">Fund Codes Rules</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeFund"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCdeFund GetByFeeCdeFundId(TransactionManager transactionManager, System.Int32 _feeCdeFundId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeCdeFund&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeCdeFund&gt;"/></returns>
		public static TList<FeeCdeFund> Fill(IDataReader reader, TList<FeeCdeFund> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeCdeFund c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeCdeFund")
					.Append("|").Append((System.Int32)reader["FEE_CDE_FUND_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeCdeFund>(
					key.ToString(), // EntityTrackingKey
					"FeeCdeFund",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeCdeFund();
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
					c.FeeCdeFundId = (System.Int32)reader["FEE_CDE_FUND_ID"];
					c.OriginalFeeCdeFundId = c.FeeCdeFundId;
					c.FundAr = (System.String)reader["FUND_AR"];
					c.FundEn = (System.String)reader["FUND_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeFund"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeFund"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeCdeFund entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeCdeFundId = (System.Int32)reader[((int)FeeCdeFundColumn.FeeCdeFundId - 1)];
			entity.OriginalFeeCdeFundId = (System.Int32)reader["FEE_CDE_FUND_ID"];
			entity.FundAr = (System.String)reader[((int)FeeCdeFundColumn.FundAr - 1)];
			entity.FundEn = (System.String)reader[((int)FeeCdeFundColumn.FundEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeFund"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeFund"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeCdeFund entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeCdeFundId = (System.Int32)dataRow["FEE_CDE_FUND_ID"];
			entity.OriginalFeeCdeFundId = (System.Int32)dataRow["FEE_CDE_FUND_ID"];
			entity.FundAr = (System.String)dataRow["FUND_AR"];
			entity.FundEn = (System.String)dataRow["FUND_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeFund"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeFund Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeFund entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeCdeFundId methods when available
			
			#region FeeFundRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFundRule>|FeeFundRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFundRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFundRuleCollection = DataRepository.FeeFundRuleProvider.GetByFeeCdeFundId(transactionManager, entity.FeeCdeFundId);

				if (deep && entity.FeeFundRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeFundRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFundRule>) DataRepository.FeeFundRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFundRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudFundCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudFund>|FeeStudFundCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFundCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudFundCollection = DataRepository.FeeStudFundProvider.GetByFeeCdeFundId(transactionManager, entity.FeeCdeFundId);

				if (deep && entity.FeeStudFundCollection.Count > 0)
				{
					deepHandles.Add("FeeStudFundCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudFund>) DataRepository.FeeStudFundProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudFundCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeCdeFund object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeCdeFund instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeFund Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeFund entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<FeeFundRule>
				if (CanDeepSave(entity.FeeFundRuleCollection, "List<FeeFundRule>|FeeFundRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFundRule child in entity.FeeFundRuleCollection)
					{
						if(child.FeeCdeFundIdSource != null)
						{
							child.FeeCdeFundId = child.FeeCdeFundIdSource.FeeCdeFundId;
						}
						else
						{
							child.FeeCdeFundId = entity.FeeCdeFundId;
						}

					}

					if (entity.FeeFundRuleCollection.Count > 0 || entity.FeeFundRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFundRuleProvider.Save(transactionManager, entity.FeeFundRuleCollection);
						
						deepHandles.Add("FeeFundRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFundRule >) DataRepository.FeeFundRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFundRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudFund>
				if (CanDeepSave(entity.FeeStudFundCollection, "List<FeeStudFund>|FeeStudFundCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudFund child in entity.FeeStudFundCollection)
					{
						if(child.FeeCdeFundIdSource != null)
						{
							child.FeeCdeFundId = child.FeeCdeFundIdSource.FeeCdeFundId;
						}
						else
						{
							child.FeeCdeFundId = entity.FeeCdeFundId;
						}

					}

					if (entity.FeeStudFundCollection.Count > 0 || entity.FeeStudFundCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudFundProvider.Save(transactionManager, entity.FeeStudFundCollection);
						
						deepHandles.Add("FeeStudFundCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudFund >) DataRepository.FeeStudFundProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudFundCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeCdeFundChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeCdeFund</c>
	///</summary>
	public enum FeeCdeFundChildEntityTypes
	{
		///<summary>
		/// Collection of <c>FeeCdeFund</c> as OneToMany for FeeFundRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFundRule>))]
		FeeFundRuleCollection,
		///<summary>
		/// Collection of <c>FeeCdeFund</c> as OneToMany for FeeStudFundCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudFund>))]
		FeeStudFundCollection,
	}
	
	#endregion FeeCdeFundChildEntityTypes
	
	#region FeeCdeFundFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeCdeFundColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeFund"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeFundFilterBuilder : SqlFilterBuilder<FeeCdeFundColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeFundFilterBuilder class.
		/// </summary>
		public FeeCdeFundFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeFundFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeFundFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeFundFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeFundFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeFundFilterBuilder
	
	#region FeeCdeFundParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeCdeFundColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeFund"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeFundParameterBuilder : ParameterizedSqlFilterBuilder<FeeCdeFundColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeFundParameterBuilder class.
		/// </summary>
		public FeeCdeFundParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeFundParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeFundParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeFundParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeFundParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeFundParameterBuilder
	
	#region FeeCdeFundSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeCdeFundColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeFund"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeCdeFundSortBuilder : SqlSortBuilder<FeeCdeFundColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeFundSqlSortBuilder class.
		/// </summary>
		public FeeCdeFundSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeCdeFundSortBuilder
	
} // end namespace
