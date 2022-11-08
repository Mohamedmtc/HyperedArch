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
	/// This class is the base class for any <see cref="EdCodeTransCourseTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeTransCourseTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeTransCourseType, UMIS_VER2.BusinessLyer.EdCodeTransCourseTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeTransCourseTypeKey key)
		{
			return Delete(transactionManager, key.EdCodeTransCourseTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeTransCourseTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeTransCourseTypeId)
		{
			return Delete(null, _edCodeTransCourseTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeTransCourseTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeTransCourseTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeTransCourseType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeTransCourseTypeKey key, int start, int pageLength)
		{
			return GetByEdCodeTransCourseTypeId(transactionManager, key.EdCodeTransCourseTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_TRANS_COURSE_TYPE index.
		/// </summary>
		/// <param name="_edCodeTransCourseTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeTransCourseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeTransCourseType GetByEdCodeTransCourseTypeId(System.Decimal _edCodeTransCourseTypeId)
		{
			int count = -1;
			return GetByEdCodeTransCourseTypeId(null,_edCodeTransCourseTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_TRANS_COURSE_TYPE index.
		/// </summary>
		/// <param name="_edCodeTransCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeTransCourseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeTransCourseType GetByEdCodeTransCourseTypeId(System.Decimal _edCodeTransCourseTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeTransCourseTypeId(null, _edCodeTransCourseTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_TRANS_COURSE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeTransCourseTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeTransCourseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeTransCourseType GetByEdCodeTransCourseTypeId(TransactionManager transactionManager, System.Decimal _edCodeTransCourseTypeId)
		{
			int count = -1;
			return GetByEdCodeTransCourseTypeId(transactionManager, _edCodeTransCourseTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_TRANS_COURSE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeTransCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeTransCourseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeTransCourseType GetByEdCodeTransCourseTypeId(TransactionManager transactionManager, System.Decimal _edCodeTransCourseTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeTransCourseTypeId(transactionManager, _edCodeTransCourseTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_TRANS_COURSE_TYPE index.
		/// </summary>
		/// <param name="_edCodeTransCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeTransCourseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeTransCourseType GetByEdCodeTransCourseTypeId(System.Decimal _edCodeTransCourseTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCodeTransCourseTypeId(null, _edCodeTransCourseTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_TRANS_COURSE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeTransCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeTransCourseType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeTransCourseType GetByEdCodeTransCourseTypeId(TransactionManager transactionManager, System.Decimal _edCodeTransCourseTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeTransCourseType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeTransCourseType&gt;"/></returns>
		public static TList<EdCodeTransCourseType> Fill(IDataReader reader, TList<EdCodeTransCourseType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeTransCourseType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeTransCourseType")
					.Append("|").Append((System.Decimal)reader["ED_CODE_TRANS_COURSE_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeTransCourseType>(
					key.ToString(), // EntityTrackingKey
					"EdCodeTransCourseType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeTransCourseType();
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
					c.EdCodeTransCourseTypeId = (System.Decimal)reader["ED_CODE_TRANS_COURSE_TYPE_ID"];
					c.OriginalEdCodeTransCourseTypeId = c.EdCodeTransCourseTypeId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeTransCourseType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeTransCourseType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeTransCourseType entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeTransCourseTypeId = (System.Decimal)reader[((int)EdCodeTransCourseTypeColumn.EdCodeTransCourseTypeId - 1)];
			entity.OriginalEdCodeTransCourseTypeId = (System.Decimal)reader["ED_CODE_TRANS_COURSE_TYPE_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCodeTransCourseTypeColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EdCodeTransCourseTypeColumn.DescrEn - 1)))?null:(System.String)reader[((int)EdCodeTransCourseTypeColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeTransCourseType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeTransCourseType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeTransCourseType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeTransCourseTypeId = (System.Decimal)dataRow["ED_CODE_TRANS_COURSE_TYPE_ID"];
			entity.OriginalEdCodeTransCourseTypeId = (System.Decimal)dataRow["ED_CODE_TRANS_COURSE_TYPE_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeTransCourseType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeTransCourseType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeTransCourseType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeTransCourseTypeId methods when available
			
			#region AdmAppTransToCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTransToCourse>|AdmAppTransToCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransToCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTransToCourseCollection = DataRepository.AdmAppTransToCourseProvider.GetByEdCodeTransCourseTypeId(transactionManager, entity.EdCodeTransCourseTypeId);

				if (deep && entity.AdmAppTransToCourseCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTransToCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransToCourse>) DataRepository.AdmAppTransToCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransToCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCourseToCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsCourseTo>|EdStudIntTrnsCourseToCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCourseToCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCourseToCollection = DataRepository.EdStudIntTrnsCourseToProvider.GetByEdCodeTransCourseTypeId(transactionManager, entity.EdCodeTransCourseTypeId);

				if (deep && entity.EdStudIntTrnsCourseToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseTo>) DataRepository.EdStudIntTrnsCourseToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeTransCourseType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeTransCourseType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeTransCourseType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeTransCourseType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AdmAppTransToCourse>
				if (CanDeepSave(entity.AdmAppTransToCourseCollection, "List<AdmAppTransToCourse>|AdmAppTransToCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransToCourse child in entity.AdmAppTransToCourseCollection)
					{
						if(child.EdCodeTransCourseTypeIdSource != null)
						{
							child.EdCodeTransCourseTypeId = child.EdCodeTransCourseTypeIdSource.EdCodeTransCourseTypeId;
						}
						else
						{
							child.EdCodeTransCourseTypeId = entity.EdCodeTransCourseTypeId;
						}

					}

					if (entity.AdmAppTransToCourseCollection.Count > 0 || entity.AdmAppTransToCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTransToCourseProvider.Save(transactionManager, entity.AdmAppTransToCourseCollection);
						
						deepHandles.Add("AdmAppTransToCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTransToCourse >) DataRepository.AdmAppTransToCourseProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTransToCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsCourseTo>
				if (CanDeepSave(entity.EdStudIntTrnsCourseToCollection, "List<EdStudIntTrnsCourseTo>|EdStudIntTrnsCourseToCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsCourseTo child in entity.EdStudIntTrnsCourseToCollection)
					{
						if(child.EdCodeTransCourseTypeIdSource != null)
						{
							child.EdCodeTransCourseTypeId = child.EdCodeTransCourseTypeIdSource.EdCodeTransCourseTypeId;
						}
						else
						{
							child.EdCodeTransCourseTypeId = entity.EdCodeTransCourseTypeId;
						}

					}

					if (entity.EdStudIntTrnsCourseToCollection.Count > 0 || entity.EdStudIntTrnsCourseToCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsCourseToProvider.Save(transactionManager, entity.EdStudIntTrnsCourseToCollection);
						
						deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsCourseTo >) DataRepository.EdStudIntTrnsCourseToProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeTransCourseTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeTransCourseType</c>
	///</summary>
	public enum EdCodeTransCourseTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCodeTransCourseType</c> as OneToMany for AdmAppTransToCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransToCourse>))]
		AdmAppTransToCourseCollection,
		///<summary>
		/// Collection of <c>EdCodeTransCourseType</c> as OneToMany for EdStudIntTrnsCourseToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseTo>))]
		EdStudIntTrnsCourseToCollection,
	}
	
	#endregion EdCodeTransCourseTypeChildEntityTypes
	
	#region EdCodeTransCourseTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeTransCourseTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeTransCourseType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeTransCourseTypeFilterBuilder : SqlFilterBuilder<EdCodeTransCourseTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeTransCourseTypeFilterBuilder class.
		/// </summary>
		public EdCodeTransCourseTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeTransCourseTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeTransCourseTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeTransCourseTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeTransCourseTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeTransCourseTypeFilterBuilder
	
	#region EdCodeTransCourseTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeTransCourseTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeTransCourseType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeTransCourseTypeParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeTransCourseTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeTransCourseTypeParameterBuilder class.
		/// </summary>
		public EdCodeTransCourseTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeTransCourseTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeTransCourseTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeTransCourseTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeTransCourseTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeTransCourseTypeParameterBuilder
	
	#region EdCodeTransCourseTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeTransCourseTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeTransCourseType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeTransCourseTypeSortBuilder : SqlSortBuilder<EdCodeTransCourseTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeTransCourseTypeSqlSortBuilder class.
		/// </summary>
		public EdCodeTransCourseTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeTransCourseTypeSortBuilder
	
} // end namespace
