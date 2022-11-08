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
	/// This class is the base class for any <see cref="AdmSkillTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmSkillTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmSkillType, UMIS_VER2.BusinessLyer.AdmSkillTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmSkillTypeKey key)
		{
			return Delete(transactionManager, key.AdmSkillTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admSkillTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admSkillTypeId)
		{
			return Delete(null, _admSkillTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admSkillTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admSkillTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmSkillType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmSkillTypeKey key, int start, int pageLength)
		{
			return GetByAdmSkillTypeId(transactionManager, key.AdmSkillTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_SKILL_TYPE index.
		/// </summary>
		/// <param name="_admSkillTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmSkillType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmSkillType GetByAdmSkillTypeId(System.Decimal _admSkillTypeId)
		{
			int count = -1;
			return GetByAdmSkillTypeId(null,_admSkillTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_SKILL_TYPE index.
		/// </summary>
		/// <param name="_admSkillTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmSkillType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmSkillType GetByAdmSkillTypeId(System.Decimal _admSkillTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmSkillTypeId(null, _admSkillTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_SKILL_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admSkillTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmSkillType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmSkillType GetByAdmSkillTypeId(TransactionManager transactionManager, System.Decimal _admSkillTypeId)
		{
			int count = -1;
			return GetByAdmSkillTypeId(transactionManager, _admSkillTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_SKILL_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admSkillTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmSkillType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmSkillType GetByAdmSkillTypeId(TransactionManager transactionManager, System.Decimal _admSkillTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmSkillTypeId(transactionManager, _admSkillTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_SKILL_TYPE index.
		/// </summary>
		/// <param name="_admSkillTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmSkillType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmSkillType GetByAdmSkillTypeId(System.Decimal _admSkillTypeId, int start, int pageLength, out int count)
		{
			return GetByAdmSkillTypeId(null, _admSkillTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_SKILL_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admSkillTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmSkillType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmSkillType GetByAdmSkillTypeId(TransactionManager transactionManager, System.Decimal _admSkillTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmSkillType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmSkillType&gt;"/></returns>
		public static TList<AdmSkillType> Fill(IDataReader reader, TList<AdmSkillType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmSkillType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmSkillType")
					.Append("|").Append((System.Decimal)reader["ADM_SKILL_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmSkillType>(
					key.ToString(), // EntityTrackingKey
					"AdmSkillType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmSkillType();
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
					c.AdmSkillTypeId = (System.Decimal)reader["ADM_SKILL_TYPE_ID"];
					c.OriginalAdmSkillTypeId = c.AdmSkillTypeId;
					c.DescAr = Convert.IsDBNull(reader["DESC_AR"]) ? null : (System.String)reader["DESC_AR"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmSkillType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmSkillType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmSkillType entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmSkillTypeId = (System.Decimal)reader[((int)AdmSkillTypeColumn.AdmSkillTypeId - 1)];
			entity.OriginalAdmSkillTypeId = (System.Decimal)reader["ADM_SKILL_TYPE_ID"];
			entity.DescAr = (reader.IsDBNull(((int)AdmSkillTypeColumn.DescAr - 1)))?null:(System.String)reader[((int)AdmSkillTypeColumn.DescAr - 1)];
			entity.DescEn = (reader.IsDBNull(((int)AdmSkillTypeColumn.DescEn - 1)))?null:(System.String)reader[((int)AdmSkillTypeColumn.DescEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmSkillType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmSkillType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmSkillType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmSkillTypeId = (System.Decimal)dataRow["ADM_SKILL_TYPE_ID"];
			entity.OriginalAdmSkillTypeId = (System.Decimal)dataRow["ADM_SKILL_TYPE_ID"];
			entity.DescAr = Convert.IsDBNull(dataRow["DESC_AR"]) ? null : (System.String)dataRow["DESC_AR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmSkillType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmSkillType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmSkillType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmSkillTypeId methods when available
			
			#region AdmAppLanguagesDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppLanguagesDtl>|AdmAppLanguagesDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppLanguagesDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppLanguagesDtlCollection = DataRepository.AdmAppLanguagesDtlProvider.GetByAdmSkillTypeId(transactionManager, entity.AdmSkillTypeId);

				if (deep && entity.AdmAppLanguagesDtlCollection.Count > 0)
				{
					deepHandles.Add("AdmAppLanguagesDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppLanguagesDtl>) DataRepository.AdmAppLanguagesDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppLanguagesDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmSkillType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmSkillType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmSkillType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmSkillType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AdmAppLanguagesDtl>
				if (CanDeepSave(entity.AdmAppLanguagesDtlCollection, "List<AdmAppLanguagesDtl>|AdmAppLanguagesDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppLanguagesDtl child in entity.AdmAppLanguagesDtlCollection)
					{
						if(child.AdmSkillTypeIdSource != null)
						{
							child.AdmSkillTypeId = child.AdmSkillTypeIdSource.AdmSkillTypeId;
						}
						else
						{
							child.AdmSkillTypeId = entity.AdmSkillTypeId;
						}

					}

					if (entity.AdmAppLanguagesDtlCollection.Count > 0 || entity.AdmAppLanguagesDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppLanguagesDtlProvider.Save(transactionManager, entity.AdmAppLanguagesDtlCollection);
						
						deepHandles.Add("AdmAppLanguagesDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppLanguagesDtl >) DataRepository.AdmAppLanguagesDtlProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppLanguagesDtlCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmSkillTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmSkillType</c>
	///</summary>
	public enum AdmSkillTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AdmSkillType</c> as OneToMany for AdmAppLanguagesDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppLanguagesDtl>))]
		AdmAppLanguagesDtlCollection,
	}
	
	#endregion AdmSkillTypeChildEntityTypes
	
	#region AdmSkillTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmSkillTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmSkillType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmSkillTypeFilterBuilder : SqlFilterBuilder<AdmSkillTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmSkillTypeFilterBuilder class.
		/// </summary>
		public AdmSkillTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmSkillTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmSkillTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmSkillTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmSkillTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmSkillTypeFilterBuilder
	
	#region AdmSkillTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmSkillTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmSkillType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmSkillTypeParameterBuilder : ParameterizedSqlFilterBuilder<AdmSkillTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmSkillTypeParameterBuilder class.
		/// </summary>
		public AdmSkillTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmSkillTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmSkillTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmSkillTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmSkillTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmSkillTypeParameterBuilder
	
	#region AdmSkillTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmSkillTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmSkillType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmSkillTypeSortBuilder : SqlSortBuilder<AdmSkillTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmSkillTypeSqlSortBuilder class.
		/// </summary>
		public AdmSkillTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmSkillTypeSortBuilder
	
} // end namespace
