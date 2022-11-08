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
	/// This class is the base class for any <see cref="AdmCdeEssayOptionProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmCdeEssayOptionProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmCdeEssayOption, UMIS_VER2.BusinessLyer.AdmCdeEssayOptionKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeEssayOptionKey key)
		{
			return Delete(transactionManager, key.AdmCdeEssayOptionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admCdeEssayOptionId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _admCdeEssayOptionId)
		{
			return Delete(null, _admCdeEssayOptionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeEssayOptionId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _admCdeEssayOptionId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmCdeEssayOption Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeEssayOptionKey key, int start, int pageLength)
		{
			return GetByAdmCdeEssayOptionId(transactionManager, key.AdmCdeEssayOptionId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_CDE_ESSAY_OPTION index.
		/// </summary>
		/// <param name="_admCdeEssayOptionId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeEssayOption"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeEssayOption GetByAdmCdeEssayOptionId(System.Int32 _admCdeEssayOptionId)
		{
			int count = -1;
			return GetByAdmCdeEssayOptionId(null,_admCdeEssayOptionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_ESSAY_OPTION index.
		/// </summary>
		/// <param name="_admCdeEssayOptionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeEssayOption"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeEssayOption GetByAdmCdeEssayOptionId(System.Int32 _admCdeEssayOptionId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeEssayOptionId(null, _admCdeEssayOptionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_ESSAY_OPTION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeEssayOptionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeEssayOption"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeEssayOption GetByAdmCdeEssayOptionId(TransactionManager transactionManager, System.Int32 _admCdeEssayOptionId)
		{
			int count = -1;
			return GetByAdmCdeEssayOptionId(transactionManager, _admCdeEssayOptionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_ESSAY_OPTION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeEssayOptionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeEssayOption"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeEssayOption GetByAdmCdeEssayOptionId(TransactionManager transactionManager, System.Int32 _admCdeEssayOptionId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeEssayOptionId(transactionManager, _admCdeEssayOptionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_ESSAY_OPTION index.
		/// </summary>
		/// <param name="_admCdeEssayOptionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeEssayOption"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeEssayOption GetByAdmCdeEssayOptionId(System.Int32 _admCdeEssayOptionId, int start, int pageLength, out int count)
		{
			return GetByAdmCdeEssayOptionId(null, _admCdeEssayOptionId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_ESSAY_OPTION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeEssayOptionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeEssayOption"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCdeEssayOption GetByAdmCdeEssayOptionId(TransactionManager transactionManager, System.Int32 _admCdeEssayOptionId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmCdeEssayOption&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmCdeEssayOption&gt;"/></returns>
		public static TList<AdmCdeEssayOption> Fill(IDataReader reader, TList<AdmCdeEssayOption> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmCdeEssayOption c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmCdeEssayOption")
					.Append("|").Append((System.Int32)reader["ADM_CDE_ESSAY_OPTION_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmCdeEssayOption>(
					key.ToString(), // EntityTrackingKey
					"AdmCdeEssayOption",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmCdeEssayOption();
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
					c.AdmCdeEssayOptionId = (System.Int32)reader["ADM_CDE_ESSAY_OPTION_ID"];
					c.OriginalAdmCdeEssayOptionId = c.AdmCdeEssayOptionId;
					c.EssayOptionEn = Convert.IsDBNull(reader["ESSAY_OPTION_EN"]) ? null : (System.String)reader["ESSAY_OPTION_EN"];
					c.TitleFlg = Convert.IsDBNull(reader["TITLE_FLG"]) ? null : (System.Boolean?)reader["TITLE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeEssayOption"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeEssayOption"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmCdeEssayOption entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmCdeEssayOptionId = (System.Int32)reader[((int)AdmCdeEssayOptionColumn.AdmCdeEssayOptionId - 1)];
			entity.OriginalAdmCdeEssayOptionId = (System.Int32)reader["ADM_CDE_ESSAY_OPTION_ID"];
			entity.EssayOptionEn = (reader.IsDBNull(((int)AdmCdeEssayOptionColumn.EssayOptionEn - 1)))?null:(System.String)reader[((int)AdmCdeEssayOptionColumn.EssayOptionEn - 1)];
			entity.TitleFlg = (reader.IsDBNull(((int)AdmCdeEssayOptionColumn.TitleFlg - 1)))?null:(System.Boolean?)reader[((int)AdmCdeEssayOptionColumn.TitleFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeEssayOption"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeEssayOption"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmCdeEssayOption entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmCdeEssayOptionId = (System.Int32)dataRow["ADM_CDE_ESSAY_OPTION_ID"];
			entity.OriginalAdmCdeEssayOptionId = (System.Int32)dataRow["ADM_CDE_ESSAY_OPTION_ID"];
			entity.EssayOptionEn = Convert.IsDBNull(dataRow["ESSAY_OPTION_EN"]) ? null : (System.String)dataRow["ESSAY_OPTION_EN"];
			entity.TitleFlg = Convert.IsDBNull(dataRow["TITLE_FLG"]) ? null : (System.Boolean?)dataRow["TITLE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeEssayOption"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeEssayOption Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeEssayOption entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmCdeEssayOptionId methods when available
			
			#region AdmAppEssayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppEssay>|AdmAppEssayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppEssayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppEssayCollection = DataRepository.AdmAppEssayProvider.GetByAdmCdeEssayOptionId(transactionManager, entity.AdmCdeEssayOptionId);

				if (deep && entity.AdmAppEssayCollection.Count > 0)
				{
					deepHandles.Add("AdmAppEssayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppEssay>) DataRepository.AdmAppEssayProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppEssayCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmCdeEssayOption object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmCdeEssayOption instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeEssayOption Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeEssayOption entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AdmAppEssay>
				if (CanDeepSave(entity.AdmAppEssayCollection, "List<AdmAppEssay>|AdmAppEssayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppEssay child in entity.AdmAppEssayCollection)
					{
						if(child.AdmCdeEssayOptionIdSource != null)
						{
							child.AdmCdeEssayOptionId = child.AdmCdeEssayOptionIdSource.AdmCdeEssayOptionId;
						}
						else
						{
							child.AdmCdeEssayOptionId = entity.AdmCdeEssayOptionId;
						}

					}

					if (entity.AdmAppEssayCollection.Count > 0 || entity.AdmAppEssayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppEssayProvider.Save(transactionManager, entity.AdmAppEssayCollection);
						
						deepHandles.Add("AdmAppEssayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppEssay >) DataRepository.AdmAppEssayProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppEssayCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmCdeEssayOptionChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmCdeEssayOption</c>
	///</summary>
	public enum AdmCdeEssayOptionChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AdmCdeEssayOption</c> as OneToMany for AdmAppEssayCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppEssay>))]
		AdmAppEssayCollection,
	}
	
	#endregion AdmCdeEssayOptionChildEntityTypes
	
	#region AdmCdeEssayOptionFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmCdeEssayOptionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeEssayOption"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeEssayOptionFilterBuilder : SqlFilterBuilder<AdmCdeEssayOptionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeEssayOptionFilterBuilder class.
		/// </summary>
		public AdmCdeEssayOptionFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeEssayOptionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeEssayOptionFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeEssayOptionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeEssayOptionFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeEssayOptionFilterBuilder
	
	#region AdmCdeEssayOptionParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmCdeEssayOptionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeEssayOption"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeEssayOptionParameterBuilder : ParameterizedSqlFilterBuilder<AdmCdeEssayOptionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeEssayOptionParameterBuilder class.
		/// </summary>
		public AdmCdeEssayOptionParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeEssayOptionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeEssayOptionParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeEssayOptionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeEssayOptionParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeEssayOptionParameterBuilder
	
	#region AdmCdeEssayOptionSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmCdeEssayOptionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeEssayOption"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmCdeEssayOptionSortBuilder : SqlSortBuilder<AdmCdeEssayOptionColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeEssayOptionSqlSortBuilder class.
		/// </summary>
		public AdmCdeEssayOptionSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmCdeEssayOptionSortBuilder
	
} // end namespace
