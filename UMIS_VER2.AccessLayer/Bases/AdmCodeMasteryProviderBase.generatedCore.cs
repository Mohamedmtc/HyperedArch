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
	/// This class is the base class for any <see cref="AdmCodeMasteryProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmCodeMasteryProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmCodeMastery, UMIS_VER2.BusinessLyer.AdmCodeMasteryKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCodeMasteryKey key)
		{
			return Delete(transactionManager, key.AdmCodeMasteryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admCodeMasteryId">Language Master. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admCodeMasteryId)
		{
			return Delete(null, _admCodeMasteryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeMasteryId">Language Master. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admCodeMasteryId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmCodeMastery Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCodeMasteryKey key, int start, int pageLength)
		{
			return GetByAdmCodeMasteryId(transactionManager, key.AdmCodeMasteryId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_CODE_MASTERY index.
		/// </summary>
		/// <param name="_admCodeMasteryId">Language Master</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCodeMastery"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCodeMastery GetByAdmCodeMasteryId(System.Decimal _admCodeMasteryId)
		{
			int count = -1;
			return GetByAdmCodeMasteryId(null,_admCodeMasteryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CODE_MASTERY index.
		/// </summary>
		/// <param name="_admCodeMasteryId">Language Master</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCodeMastery"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCodeMastery GetByAdmCodeMasteryId(System.Decimal _admCodeMasteryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCodeMasteryId(null, _admCodeMasteryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CODE_MASTERY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeMasteryId">Language Master</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCodeMastery"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCodeMastery GetByAdmCodeMasteryId(TransactionManager transactionManager, System.Decimal _admCodeMasteryId)
		{
			int count = -1;
			return GetByAdmCodeMasteryId(transactionManager, _admCodeMasteryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CODE_MASTERY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeMasteryId">Language Master</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCodeMastery"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCodeMastery GetByAdmCodeMasteryId(TransactionManager transactionManager, System.Decimal _admCodeMasteryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCodeMasteryId(transactionManager, _admCodeMasteryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CODE_MASTERY index.
		/// </summary>
		/// <param name="_admCodeMasteryId">Language Master</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCodeMastery"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCodeMastery GetByAdmCodeMasteryId(System.Decimal _admCodeMasteryId, int start, int pageLength, out int count)
		{
			return GetByAdmCodeMasteryId(null, _admCodeMasteryId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CODE_MASTERY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeMasteryId">Language Master</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCodeMastery"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCodeMastery GetByAdmCodeMasteryId(TransactionManager transactionManager, System.Decimal _admCodeMasteryId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmCodeMastery&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmCodeMastery&gt;"/></returns>
		public static TList<AdmCodeMastery> Fill(IDataReader reader, TList<AdmCodeMastery> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmCodeMastery c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmCodeMastery")
					.Append("|").Append((System.Decimal)reader["ADM_CODE_MASTERY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmCodeMastery>(
					key.ToString(), // EntityTrackingKey
					"AdmCodeMastery",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmCodeMastery();
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
					c.AdmCodeMasteryId = (System.Decimal)reader["ADM_CODE_MASTERY_ID"];
					c.OriginalAdmCodeMasteryId = c.AdmCodeMasteryId;
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCodeMastery"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCodeMastery"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmCodeMastery entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmCodeMasteryId = (System.Decimal)reader[((int)AdmCodeMasteryColumn.AdmCodeMasteryId - 1)];
			entity.OriginalAdmCodeMasteryId = (System.Decimal)reader["ADM_CODE_MASTERY_ID"];
			entity.DescAr = (reader.IsDBNull(((int)AdmCodeMasteryColumn.DescAr - 1)))?null:(System.String)reader[((int)AdmCodeMasteryColumn.DescAr - 1)];
			entity.DescEn = (reader.IsDBNull(((int)AdmCodeMasteryColumn.DescEn - 1)))?null:(System.String)reader[((int)AdmCodeMasteryColumn.DescEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCodeMastery"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCodeMastery"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmCodeMastery entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmCodeMasteryId = (System.Decimal)dataRow["ADM_CODE_MASTERY_ID"];
			entity.OriginalAdmCodeMasteryId = (System.Decimal)dataRow["ADM_CODE_MASTERY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCodeMastery"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCodeMastery Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCodeMastery entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmCodeMasteryId methods when available
			
			#region AdmAppLanguagesDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppLanguagesDtl>|AdmAppLanguagesDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppLanguagesDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppLanguagesDtlCollection = DataRepository.AdmAppLanguagesDtlProvider.GetByAdmCodeMasteryId(transactionManager, entity.AdmCodeMasteryId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmCodeMastery object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmCodeMastery instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCodeMastery Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCodeMastery entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
						if(child.AdmCodeMasteryIdSource != null)
						{
							child.AdmCodeMasteryId = child.AdmCodeMasteryIdSource.AdmCodeMasteryId;
						}
						else
						{
							child.AdmCodeMasteryId = entity.AdmCodeMasteryId;
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
	
	#region AdmCodeMasteryChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmCodeMastery</c>
	///</summary>
	public enum AdmCodeMasteryChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AdmCodeMastery</c> as OneToMany for AdmAppLanguagesDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppLanguagesDtl>))]
		AdmAppLanguagesDtlCollection,
	}
	
	#endregion AdmCodeMasteryChildEntityTypes
	
	#region AdmCodeMasteryFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmCodeMasteryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCodeMastery"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCodeMasteryFilterBuilder : SqlFilterBuilder<AdmCodeMasteryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCodeMasteryFilterBuilder class.
		/// </summary>
		public AdmCodeMasteryFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCodeMasteryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCodeMasteryFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCodeMasteryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCodeMasteryFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCodeMasteryFilterBuilder
	
	#region AdmCodeMasteryParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmCodeMasteryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCodeMastery"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCodeMasteryParameterBuilder : ParameterizedSqlFilterBuilder<AdmCodeMasteryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCodeMasteryParameterBuilder class.
		/// </summary>
		public AdmCodeMasteryParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCodeMasteryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCodeMasteryParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCodeMasteryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCodeMasteryParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCodeMasteryParameterBuilder
	
	#region AdmCodeMasterySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmCodeMasteryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCodeMastery"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmCodeMasterySortBuilder : SqlSortBuilder<AdmCodeMasteryColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCodeMasterySqlSortBuilder class.
		/// </summary>
		public AdmCodeMasterySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmCodeMasterySortBuilder
	
} // end namespace
