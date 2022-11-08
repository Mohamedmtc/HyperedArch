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
	/// This class is the base class for any <see cref="EdCodeCourseChngProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeCourseChngProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeCourseChng, UMIS_VER2.BusinessLyer.EdCodeCourseChngKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseChngKey key)
		{
			return Delete(transactionManager, key.EdCodeCourseChngId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeCourseChngId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeCourseChngId)
		{
			return Delete(null, _edCodeCourseChngId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseChngId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeCourseChngId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeCourseChng Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseChngKey key, int start, int pageLength)
		{
			return GetByEdCodeCourseChngId(transactionManager, key.EdCodeCourseChngId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_CR_SUBJ_EDIT index.
		/// </summary>
		/// <param name="_edCodeCourseChngId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseChng GetByEdCodeCourseChngId(System.Decimal _edCodeCourseChngId)
		{
			int count = -1;
			return GetByEdCodeCourseChngId(null,_edCodeCourseChngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_CR_SUBJ_EDIT index.
		/// </summary>
		/// <param name="_edCodeCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseChng GetByEdCodeCourseChngId(System.Decimal _edCodeCourseChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseChngId(null, _edCodeCourseChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_CR_SUBJ_EDIT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseChngId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseChng GetByEdCodeCourseChngId(TransactionManager transactionManager, System.Decimal _edCodeCourseChngId)
		{
			int count = -1;
			return GetByEdCodeCourseChngId(transactionManager, _edCodeCourseChngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_CR_SUBJ_EDIT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseChng GetByEdCodeCourseChngId(TransactionManager transactionManager, System.Decimal _edCodeCourseChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseChngId(transactionManager, _edCodeCourseChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_CR_SUBJ_EDIT index.
		/// </summary>
		/// <param name="_edCodeCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseChng GetByEdCodeCourseChngId(System.Decimal _edCodeCourseChngId, int start, int pageLength, out int count)
		{
			return GetByEdCodeCourseChngId(null, _edCodeCourseChngId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_CR_SUBJ_EDIT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseChng"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeCourseChng GetByEdCodeCourseChngId(TransactionManager transactionManager, System.Decimal _edCodeCourseChngId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeCourseChng&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeCourseChng&gt;"/></returns>
		public static TList<EdCodeCourseChng> Fill(IDataReader reader, TList<EdCodeCourseChng> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeCourseChng c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeCourseChng")
					.Append("|").Append((System.Decimal)reader["ED_CODE_COURSE_CHNG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeCourseChng>(
					key.ToString(), // EntityTrackingKey
					"EdCodeCourseChng",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeCourseChng();
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
					c.EdCodeCourseChngId = (System.Decimal)reader["ED_CODE_COURSE_CHNG_ID"];
					c.OriginalEdCodeCourseChngId = c.EdCodeCourseChngId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.Symbol = Convert.IsDBNull(reader["SYMBOL"]) ? null : (System.String)reader["SYMBOL"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseChng"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseChng"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeCourseChng entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeCourseChngId = (System.Decimal)reader[((int)EdCodeCourseChngColumn.EdCodeCourseChngId - 1)];
			entity.OriginalEdCodeCourseChngId = (System.Decimal)reader["ED_CODE_COURSE_CHNG_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCodeCourseChngColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EdCodeCourseChngColumn.DescrEn - 1)))?null:(System.String)reader[((int)EdCodeCourseChngColumn.DescrEn - 1)];
			entity.Symbol = (reader.IsDBNull(((int)EdCodeCourseChngColumn.Symbol - 1)))?null:(System.String)reader[((int)EdCodeCourseChngColumn.Symbol - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseChng"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseChng"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeCourseChng entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeCourseChngId = (System.Decimal)dataRow["ED_CODE_COURSE_CHNG_ID"];
			entity.OriginalEdCodeCourseChngId = (System.Decimal)dataRow["ED_CODE_COURSE_CHNG_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.Symbol = Convert.IsDBNull(dataRow["SYMBOL"]) ? null : (System.String)dataRow["SYMBOL"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseChng"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeCourseChng Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseChng entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeCourseChngId methods when available
			
			#region EntPolicyCourseChngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyCourseChng>|EntPolicyCourseChngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyCourseChngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyCourseChngCollection = DataRepository.EntPolicyCourseChngProvider.GetByEdCodeCourseChngId(transactionManager, entity.EdCodeCourseChngId);

				if (deep && entity.EntPolicyCourseChngCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyCourseChngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyCourseChng>) DataRepository.EntPolicyCourseChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyCourseChngCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseChngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseChng>|EdStudCourseChngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseChngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseChngCollection = DataRepository.EdStudCourseChngProvider.GetByEdCodeCourseChngId(transactionManager, entity.EdCodeCourseChngId);

				if (deep && entity.EdStudCourseChngCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseChngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseChng>) DataRepository.EdStudCourseChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseChngCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeCourseChng object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeCourseChng instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeCourseChng Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseChng entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EntPolicyCourseChng>
				if (CanDeepSave(entity.EntPolicyCourseChngCollection, "List<EntPolicyCourseChng>|EntPolicyCourseChngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyCourseChng child in entity.EntPolicyCourseChngCollection)
					{
						if(child.EdCodeCourseChngIdSource != null)
						{
							child.EdCodeCourseChngId = child.EdCodeCourseChngIdSource.EdCodeCourseChngId;
						}
						else
						{
							child.EdCodeCourseChngId = entity.EdCodeCourseChngId;
						}

					}

					if (entity.EntPolicyCourseChngCollection.Count > 0 || entity.EntPolicyCourseChngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyCourseChngProvider.Save(transactionManager, entity.EntPolicyCourseChngCollection);
						
						deepHandles.Add("EntPolicyCourseChngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyCourseChng >) DataRepository.EntPolicyCourseChngProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyCourseChngCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseChng>
				if (CanDeepSave(entity.EdStudCourseChngCollection, "List<EdStudCourseChng>|EdStudCourseChngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseChng child in entity.EdStudCourseChngCollection)
					{
						if(child.EdCodeCourseChngIdSource != null)
						{
							child.EdCodeCourseChngId = child.EdCodeCourseChngIdSource.EdCodeCourseChngId;
						}
						else
						{
							child.EdCodeCourseChngId = entity.EdCodeCourseChngId;
						}

					}

					if (entity.EdStudCourseChngCollection.Count > 0 || entity.EdStudCourseChngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseChngProvider.Save(transactionManager, entity.EdStudCourseChngCollection);
						
						deepHandles.Add("EdStudCourseChngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseChng >) DataRepository.EdStudCourseChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseChngCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeCourseChngChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeCourseChng</c>
	///</summary>
	public enum EdCodeCourseChngChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCodeCourseChng</c> as OneToMany for EntPolicyCourseChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyCourseChng>))]
		EntPolicyCourseChngCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseChng</c> as OneToMany for EdStudCourseChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseChng>))]
		EdStudCourseChngCollection,
	}
	
	#endregion EdCodeCourseChngChildEntityTypes
	
	#region EdCodeCourseChngFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeCourseChngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCourseChng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeCourseChngFilterBuilder : SqlFilterBuilder<EdCodeCourseChngColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseChngFilterBuilder class.
		/// </summary>
		public EdCodeCourseChngFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseChngFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeCourseChngFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseChngFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeCourseChngFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeCourseChngFilterBuilder
	
	#region EdCodeCourseChngParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeCourseChngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCourseChng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeCourseChngParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeCourseChngColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseChngParameterBuilder class.
		/// </summary>
		public EdCodeCourseChngParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseChngParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeCourseChngParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseChngParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeCourseChngParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeCourseChngParameterBuilder
	
	#region EdCodeCourseChngSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeCourseChngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCourseChng"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeCourseChngSortBuilder : SqlSortBuilder<EdCodeCourseChngColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseChngSqlSortBuilder class.
		/// </summary>
		public EdCodeCourseChngSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeCourseChngSortBuilder
	
} // end namespace
