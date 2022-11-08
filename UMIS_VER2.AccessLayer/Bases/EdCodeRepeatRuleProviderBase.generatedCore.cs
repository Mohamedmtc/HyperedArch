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
	/// This class is the base class for any <see cref="EdCodeRepeatRuleProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeRepeatRuleProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeRepeatRule, UMIS_VER2.BusinessLyer.EdCodeRepeatRuleKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeRepeatRuleKey key)
		{
			return Delete(transactionManager, key.EdCodeRepeatRuleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeRepeatRuleId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeRepeatRuleId)
		{
			return Delete(null, _edCodeRepeatRuleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeRepeatRuleId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeRepeatRuleId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeRepeatRule Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeRepeatRuleKey key, int start, int pageLength)
		{
			return GetByEdCodeRepeatRuleId(transactionManager, key.EdCodeRepeatRuleId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_REPEAT_RULE index.
		/// </summary>
		/// <param name="_edCodeRepeatRuleId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeRepeatRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeRepeatRule GetByEdCodeRepeatRuleId(System.Decimal _edCodeRepeatRuleId)
		{
			int count = -1;
			return GetByEdCodeRepeatRuleId(null,_edCodeRepeatRuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_REPEAT_RULE index.
		/// </summary>
		/// <param name="_edCodeRepeatRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeRepeatRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeRepeatRule GetByEdCodeRepeatRuleId(System.Decimal _edCodeRepeatRuleId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeRepeatRuleId(null, _edCodeRepeatRuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_REPEAT_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeRepeatRuleId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeRepeatRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeRepeatRule GetByEdCodeRepeatRuleId(TransactionManager transactionManager, System.Decimal _edCodeRepeatRuleId)
		{
			int count = -1;
			return GetByEdCodeRepeatRuleId(transactionManager, _edCodeRepeatRuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_REPEAT_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeRepeatRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeRepeatRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeRepeatRule GetByEdCodeRepeatRuleId(TransactionManager transactionManager, System.Decimal _edCodeRepeatRuleId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeRepeatRuleId(transactionManager, _edCodeRepeatRuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_REPEAT_RULE index.
		/// </summary>
		/// <param name="_edCodeRepeatRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeRepeatRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeRepeatRule GetByEdCodeRepeatRuleId(System.Decimal _edCodeRepeatRuleId, int start, int pageLength, out int count)
		{
			return GetByEdCodeRepeatRuleId(null, _edCodeRepeatRuleId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_REPEAT_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeRepeatRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeRepeatRule"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeRepeatRule GetByEdCodeRepeatRuleId(TransactionManager transactionManager, System.Decimal _edCodeRepeatRuleId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeRepeatRule&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeRepeatRule&gt;"/></returns>
		public static TList<EdCodeRepeatRule> Fill(IDataReader reader, TList<EdCodeRepeatRule> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeRepeatRule c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeRepeatRule")
					.Append("|").Append((System.Decimal)reader["ED_CODE_REPEAT_RULE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeRepeatRule>(
					key.ToString(), // EntityTrackingKey
					"EdCodeRepeatRule",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeRepeatRule();
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
					c.EdCodeRepeatRuleId = (System.Decimal)reader["ED_CODE_REPEAT_RULE_ID"];
					c.OriginalEdCodeRepeatRuleId = c.EdCodeRepeatRuleId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.RepeatFlg = Convert.IsDBNull(reader["REPEAT_FLG"]) ? null : (System.Decimal?)reader["REPEAT_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeRepeatRule"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeRepeatRule"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeRepeatRule entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeRepeatRuleId = (System.Decimal)reader[((int)EdCodeRepeatRuleColumn.EdCodeRepeatRuleId - 1)];
			entity.OriginalEdCodeRepeatRuleId = (System.Decimal)reader["ED_CODE_REPEAT_RULE_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCodeRepeatRuleColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)EdCodeRepeatRuleColumn.DescrEn - 1)];
			entity.RepeatFlg = (reader.IsDBNull(((int)EdCodeRepeatRuleColumn.RepeatFlg - 1)))?null:(System.Decimal?)reader[((int)EdCodeRepeatRuleColumn.RepeatFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeRepeatRule"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeRepeatRule"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeRepeatRule entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeRepeatRuleId = (System.Decimal)dataRow["ED_CODE_REPEAT_RULE_ID"];
			entity.OriginalEdCodeRepeatRuleId = (System.Decimal)dataRow["ED_CODE_REPEAT_RULE_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.RepeatFlg = Convert.IsDBNull(dataRow["REPEAT_FLG"]) ? null : (System.Decimal?)dataRow["REPEAT_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeRepeatRule"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeRepeatRule Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeRepeatRule entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeRepeatRuleId methods when available
			
			#region EntPolicyCourseRepeatCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyCourseRepeat>|EntPolicyCourseRepeatCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyCourseRepeatCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyCourseRepeatCollection = DataRepository.EntPolicyCourseRepeatProvider.GetByEdCodeRepeatRuleId(transactionManager, entity.EdCodeRepeatRuleId);

				if (deep && entity.EntPolicyCourseRepeatCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyCourseRepeatCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyCourseRepeat>) DataRepository.EntPolicyCourseRepeatProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyCourseRepeatCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeRepeatRule object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeRepeatRule instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeRepeatRule Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeRepeatRule entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EntPolicyCourseRepeat>
				if (CanDeepSave(entity.EntPolicyCourseRepeatCollection, "List<EntPolicyCourseRepeat>|EntPolicyCourseRepeatCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyCourseRepeat child in entity.EntPolicyCourseRepeatCollection)
					{
						if(child.EdCodeRepeatRuleIdSource != null)
						{
							child.EdCodeRepeatRuleId = child.EdCodeRepeatRuleIdSource.EdCodeRepeatRuleId;
						}
						else
						{
							child.EdCodeRepeatRuleId = entity.EdCodeRepeatRuleId;
						}

					}

					if (entity.EntPolicyCourseRepeatCollection.Count > 0 || entity.EntPolicyCourseRepeatCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyCourseRepeatProvider.Save(transactionManager, entity.EntPolicyCourseRepeatCollection);
						
						deepHandles.Add("EntPolicyCourseRepeatCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyCourseRepeat >) DataRepository.EntPolicyCourseRepeatProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyCourseRepeatCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeRepeatRuleChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeRepeatRule</c>
	///</summary>
	public enum EdCodeRepeatRuleChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCodeRepeatRule</c> as OneToMany for EntPolicyCourseRepeatCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyCourseRepeat>))]
		EntPolicyCourseRepeatCollection,
	}
	
	#endregion EdCodeRepeatRuleChildEntityTypes
	
	#region EdCodeRepeatRuleFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeRepeatRuleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeRepeatRule"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeRepeatRuleFilterBuilder : SqlFilterBuilder<EdCodeRepeatRuleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeRepeatRuleFilterBuilder class.
		/// </summary>
		public EdCodeRepeatRuleFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeRepeatRuleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeRepeatRuleFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeRepeatRuleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeRepeatRuleFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeRepeatRuleFilterBuilder
	
	#region EdCodeRepeatRuleParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeRepeatRuleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeRepeatRule"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeRepeatRuleParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeRepeatRuleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeRepeatRuleParameterBuilder class.
		/// </summary>
		public EdCodeRepeatRuleParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeRepeatRuleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeRepeatRuleParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeRepeatRuleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeRepeatRuleParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeRepeatRuleParameterBuilder
	
	#region EdCodeRepeatRuleSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeRepeatRuleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeRepeatRule"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeRepeatRuleSortBuilder : SqlSortBuilder<EdCodeRepeatRuleColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeRepeatRuleSqlSortBuilder class.
		/// </summary>
		public EdCodeRepeatRuleSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeRepeatRuleSortBuilder
	
} // end namespace
