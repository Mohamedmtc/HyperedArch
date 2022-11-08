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
	/// This class is the base class for any <see cref="FeeCdeSchshipCatProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeCdeSchshipCatProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeCdeSchshipCat, UMIS_VER2.BusinessLyer.FeeCdeSchshipCatKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeSchshipCatKey key)
		{
			return Delete(transactionManager, key.FeeCdeSchshipCatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeCdeSchshipCatId">انواع منح-تخفيض تطبق اتوماتيك. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _feeCdeSchshipCatId)
		{
			return Delete(null, _feeCdeSchshipCatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeSchshipCatId">انواع منح-تخفيض تطبق اتوماتيك. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _feeCdeSchshipCatId);		
		
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
		public override UMIS_VER2.BusinessLyer.FeeCdeSchshipCat Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeSchshipCatKey key, int start, int pageLength)
		{
			return GetByFeeCdeSchshipCatId(transactionManager, key.FeeCdeSchshipCatId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_CDE_SCHSHIP_CAT index.
		/// </summary>
		/// <param name="_feeCdeSchshipCatId">انواع منح-تخفيض تطبق اتوماتيك</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeSchshipCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeSchshipCat GetByFeeCdeSchshipCatId(System.Int32 _feeCdeSchshipCatId)
		{
			int count = -1;
			return GetByFeeCdeSchshipCatId(null,_feeCdeSchshipCatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_SCHSHIP_CAT index.
		/// </summary>
		/// <param name="_feeCdeSchshipCatId">انواع منح-تخفيض تطبق اتوماتيك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeSchshipCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeSchshipCat GetByFeeCdeSchshipCatId(System.Int32 _feeCdeSchshipCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeSchshipCatId(null, _feeCdeSchshipCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_SCHSHIP_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeSchshipCatId">انواع منح-تخفيض تطبق اتوماتيك</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeSchshipCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeSchshipCat GetByFeeCdeSchshipCatId(TransactionManager transactionManager, System.Int32 _feeCdeSchshipCatId)
		{
			int count = -1;
			return GetByFeeCdeSchshipCatId(transactionManager, _feeCdeSchshipCatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_SCHSHIP_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeSchshipCatId">انواع منح-تخفيض تطبق اتوماتيك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeSchshipCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeSchshipCat GetByFeeCdeSchshipCatId(TransactionManager transactionManager, System.Int32 _feeCdeSchshipCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeSchshipCatId(transactionManager, _feeCdeSchshipCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_SCHSHIP_CAT index.
		/// </summary>
		/// <param name="_feeCdeSchshipCatId">انواع منح-تخفيض تطبق اتوماتيك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeSchshipCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeSchshipCat GetByFeeCdeSchshipCatId(System.Int32 _feeCdeSchshipCatId, int start, int pageLength, out int count)
		{
			return GetByFeeCdeSchshipCatId(null, _feeCdeSchshipCatId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_SCHSHIP_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeSchshipCatId">انواع منح-تخفيض تطبق اتوماتيك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeSchshipCat"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCdeSchshipCat GetByFeeCdeSchshipCatId(TransactionManager transactionManager, System.Int32 _feeCdeSchshipCatId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeCdeSchshipCat&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeCdeSchshipCat&gt;"/></returns>
		public static TList<FeeCdeSchshipCat> Fill(IDataReader reader, TList<FeeCdeSchshipCat> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeCdeSchshipCat c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeCdeSchshipCat")
					.Append("|").Append((System.Int32)reader["FEE_CDE_SCHSHIP_CAT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeCdeSchshipCat>(
					key.ToString(), // EntityTrackingKey
					"FeeCdeSchshipCat",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeCdeSchshipCat();
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
					c.FeeCdeSchshipCatId = (System.Int32)reader["FEE_CDE_SCHSHIP_CAT_ID"];
					c.OriginalFeeCdeSchshipCatId = c.FeeCdeSchshipCatId;
					c.SchshipCatAr = Convert.IsDBNull(reader["SCHSHIP_CAT_AR"]) ? null : (System.String)reader["SCHSHIP_CAT_AR"];
					c.SchshipCatEn = Convert.IsDBNull(reader["SCHSHIP_CAT_EN"]) ? null : (System.String)reader["SCHSHIP_CAT_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeSchshipCat"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeSchshipCat"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeCdeSchshipCat entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeCdeSchshipCatId = (System.Int32)reader[((int)FeeCdeSchshipCatColumn.FeeCdeSchshipCatId - 1)];
			entity.OriginalFeeCdeSchshipCatId = (System.Int32)reader["FEE_CDE_SCHSHIP_CAT_ID"];
			entity.SchshipCatAr = (reader.IsDBNull(((int)FeeCdeSchshipCatColumn.SchshipCatAr - 1)))?null:(System.String)reader[((int)FeeCdeSchshipCatColumn.SchshipCatAr - 1)];
			entity.SchshipCatEn = (reader.IsDBNull(((int)FeeCdeSchshipCatColumn.SchshipCatEn - 1)))?null:(System.String)reader[((int)FeeCdeSchshipCatColumn.SchshipCatEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeSchshipCat"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeSchshipCat"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeCdeSchshipCat entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeCdeSchshipCatId = (System.Int32)dataRow["FEE_CDE_SCHSHIP_CAT_ID"];
			entity.OriginalFeeCdeSchshipCatId = (System.Int32)dataRow["FEE_CDE_SCHSHIP_CAT_ID"];
			entity.SchshipCatAr = Convert.IsDBNull(dataRow["SCHSHIP_CAT_AR"]) ? null : (System.String)dataRow["SCHSHIP_CAT_AR"];
			entity.SchshipCatEn = Convert.IsDBNull(dataRow["SCHSHIP_CAT_EN"]) ? null : (System.String)dataRow["SCHSHIP_CAT_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeSchshipCat"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeSchshipCat Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeSchshipCat entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeCdeSchshipCatId methods when available
			
			#region FeeCdeDiscTypeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeCdeDiscType>|FeeCdeDiscTypeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeDiscTypeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeCdeDiscTypeCollection = DataRepository.FeeCdeDiscTypeProvider.GetByFeeCdeSchshipCatId(transactionManager, entity.FeeCdeSchshipCatId);

				if (deep && entity.FeeCdeDiscTypeCollection.Count > 0)
				{
					deepHandles.Add("FeeCdeDiscTypeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeCdeDiscType>) DataRepository.FeeCdeDiscTypeProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeCdeDiscTypeCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeCdeSchshipCat object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeCdeSchshipCat instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeSchshipCat Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeSchshipCat entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<FeeCdeDiscType>
				if (CanDeepSave(entity.FeeCdeDiscTypeCollection, "List<FeeCdeDiscType>|FeeCdeDiscTypeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeCdeDiscType child in entity.FeeCdeDiscTypeCollection)
					{
						if(child.FeeCdeSchshipCatIdSource != null)
						{
							child.FeeCdeSchshipCatId = child.FeeCdeSchshipCatIdSource.FeeCdeSchshipCatId;
						}
						else
						{
							child.FeeCdeSchshipCatId = entity.FeeCdeSchshipCatId;
						}

					}

					if (entity.FeeCdeDiscTypeCollection.Count > 0 || entity.FeeCdeDiscTypeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeCdeDiscTypeProvider.Save(transactionManager, entity.FeeCdeDiscTypeCollection);
						
						deepHandles.Add("FeeCdeDiscTypeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeCdeDiscType >) DataRepository.FeeCdeDiscTypeProvider.DeepSave,
							new object[] { transactionManager, entity.FeeCdeDiscTypeCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeCdeSchshipCatChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeCdeSchshipCat</c>
	///</summary>
	public enum FeeCdeSchshipCatChildEntityTypes
	{
		///<summary>
		/// Collection of <c>FeeCdeSchshipCat</c> as OneToMany for FeeCdeDiscTypeCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeCdeDiscType>))]
		FeeCdeDiscTypeCollection,
	}
	
	#endregion FeeCdeSchshipCatChildEntityTypes
	
	#region FeeCdeSchshipCatFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeCdeSchshipCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeSchshipCat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeSchshipCatFilterBuilder : SqlFilterBuilder<FeeCdeSchshipCatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeSchshipCatFilterBuilder class.
		/// </summary>
		public FeeCdeSchshipCatFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeSchshipCatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeSchshipCatFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeSchshipCatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeSchshipCatFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeSchshipCatFilterBuilder
	
	#region FeeCdeSchshipCatParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeCdeSchshipCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeSchshipCat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeSchshipCatParameterBuilder : ParameterizedSqlFilterBuilder<FeeCdeSchshipCatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeSchshipCatParameterBuilder class.
		/// </summary>
		public FeeCdeSchshipCatParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeSchshipCatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeSchshipCatParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeSchshipCatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeSchshipCatParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeSchshipCatParameterBuilder
	
	#region FeeCdeSchshipCatSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeCdeSchshipCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeSchshipCat"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeCdeSchshipCatSortBuilder : SqlSortBuilder<FeeCdeSchshipCatColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeSchshipCatSqlSortBuilder class.
		/// </summary>
		public FeeCdeSchshipCatSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeCdeSchshipCatSortBuilder
	
} // end namespace
