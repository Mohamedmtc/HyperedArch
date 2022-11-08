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
	/// This class is the base class for any <see cref="AdmCdeCourseCompProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmCdeCourseCompProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmCdeCourseComp, UMIS_VER2.BusinessLyer.AdmCdeCourseCompKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeCourseCompKey key)
		{
			return Delete(transactionManager, key.AdmCdeCourseCompId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admCdeCourseCompId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admCdeCourseCompId)
		{
			return Delete(null, _admCdeCourseCompId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeCourseCompId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admCdeCourseCompId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmCdeCourseComp Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeCourseCompKey key, int start, int pageLength)
		{
			return GetByAdmCdeCourseCompId(transactionManager, key.AdmCdeCourseCompId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_CDE_COURSE_COMP index.
		/// </summary>
		/// <param name="_admCdeCourseCompId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeCourseComp GetByAdmCdeCourseCompId(System.Decimal _admCdeCourseCompId)
		{
			int count = -1;
			return GetByAdmCdeCourseCompId(null,_admCdeCourseCompId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_COURSE_COMP index.
		/// </summary>
		/// <param name="_admCdeCourseCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeCourseComp GetByAdmCdeCourseCompId(System.Decimal _admCdeCourseCompId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeCourseCompId(null, _admCdeCourseCompId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_COURSE_COMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeCourseCompId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeCourseComp GetByAdmCdeCourseCompId(TransactionManager transactionManager, System.Decimal _admCdeCourseCompId)
		{
			int count = -1;
			return GetByAdmCdeCourseCompId(transactionManager, _admCdeCourseCompId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_COURSE_COMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeCourseCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeCourseComp GetByAdmCdeCourseCompId(TransactionManager transactionManager, System.Decimal _admCdeCourseCompId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeCourseCompId(transactionManager, _admCdeCourseCompId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_COURSE_COMP index.
		/// </summary>
		/// <param name="_admCdeCourseCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeCourseComp GetByAdmCdeCourseCompId(System.Decimal _admCdeCourseCompId, int start, int pageLength, out int count)
		{
			return GetByAdmCdeCourseCompId(null, _admCdeCourseCompId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_COURSE_COMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeCourseCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeCourseComp"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCdeCourseComp GetByAdmCdeCourseCompId(TransactionManager transactionManager, System.Decimal _admCdeCourseCompId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmCdeCourseComp&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmCdeCourseComp&gt;"/></returns>
		public static TList<AdmCdeCourseComp> Fill(IDataReader reader, TList<AdmCdeCourseComp> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmCdeCourseComp c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmCdeCourseComp")
					.Append("|").Append((System.Decimal)reader["ADM_CDE_COURSE_COMP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmCdeCourseComp>(
					key.ToString(), // EntityTrackingKey
					"AdmCdeCourseComp",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmCdeCourseComp();
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
					c.AdmCdeCourseCompId = (System.Decimal)reader["ADM_CDE_COURSE_COMP_ID"];
					c.OriginalAdmCdeCourseCompId = c.AdmCdeCourseCompId;
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeCourseComp"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeCourseComp"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmCdeCourseComp entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmCdeCourseCompId = (System.Decimal)reader[((int)AdmCdeCourseCompColumn.AdmCdeCourseCompId - 1)];
			entity.OriginalAdmCdeCourseCompId = (System.Decimal)reader["ADM_CDE_COURSE_COMP_ID"];
			entity.DescrAr = (System.String)reader[((int)AdmCdeCourseCompColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)AdmCdeCourseCompColumn.DescrEn - 1)))?null:(System.String)reader[((int)AdmCdeCourseCompColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeCourseComp"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeCourseComp"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmCdeCourseComp entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmCdeCourseCompId = (System.Decimal)dataRow["ADM_CDE_COURSE_COMP_ID"];
			entity.OriginalAdmCdeCourseCompId = (System.Decimal)dataRow["ADM_CDE_COURSE_COMP_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeCourseComp"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeCourseComp Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeCourseComp entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmCdeCourseCompId methods when available
			
			#region EdStudCourseCompCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseComp>|EdStudCourseCompCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseCompCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseCompCollection = DataRepository.EdStudCourseCompProvider.GetByAdmCdeCourseCompId(transactionManager, entity.AdmCdeCourseCompId);

				if (deep && entity.EdStudCourseCompCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseCompCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseComp>) DataRepository.EdStudCourseCompProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseCompCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppCourseCompCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppCourseComp>|AdmAppCourseCompCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppCourseCompCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppCourseCompCollection = DataRepository.AdmAppCourseCompProvider.GetByAdmCdeCourseCompId(transactionManager, entity.AdmCdeCourseCompId);

				if (deep && entity.AdmAppCourseCompCollection.Count > 0)
				{
					deepHandles.Add("AdmAppCourseCompCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppCourseComp>) DataRepository.AdmAppCourseCompProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppCourseCompCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmCdeCourseComp object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmCdeCourseComp instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeCourseComp Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeCourseComp entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudCourseComp>
				if (CanDeepSave(entity.EdStudCourseCompCollection, "List<EdStudCourseComp>|EdStudCourseCompCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseComp child in entity.EdStudCourseCompCollection)
					{
						if(child.AdmCdeCourseCompIdSource != null)
						{
							child.AdmCdeCourseCompId = child.AdmCdeCourseCompIdSource.AdmCdeCourseCompId;
						}
						else
						{
							child.AdmCdeCourseCompId = entity.AdmCdeCourseCompId;
						}

					}

					if (entity.EdStudCourseCompCollection.Count > 0 || entity.EdStudCourseCompCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseCompProvider.Save(transactionManager, entity.EdStudCourseCompCollection);
						
						deepHandles.Add("EdStudCourseCompCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseComp >) DataRepository.EdStudCourseCompProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseCompCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppCourseComp>
				if (CanDeepSave(entity.AdmAppCourseCompCollection, "List<AdmAppCourseComp>|AdmAppCourseCompCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppCourseComp child in entity.AdmAppCourseCompCollection)
					{
						if(child.AdmCdeCourseCompIdSource != null)
						{
							child.AdmCdeCourseCompId = child.AdmCdeCourseCompIdSource.AdmCdeCourseCompId;
						}
						else
						{
							child.AdmCdeCourseCompId = entity.AdmCdeCourseCompId;
						}

					}

					if (entity.AdmAppCourseCompCollection.Count > 0 || entity.AdmAppCourseCompCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppCourseCompProvider.Save(transactionManager, entity.AdmAppCourseCompCollection);
						
						deepHandles.Add("AdmAppCourseCompCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppCourseComp >) DataRepository.AdmAppCourseCompProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppCourseCompCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmCdeCourseCompChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmCdeCourseComp</c>
	///</summary>
	public enum AdmCdeCourseCompChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AdmCdeCourseComp</c> as OneToMany for EdStudCourseCompCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseComp>))]
		EdStudCourseCompCollection,
		///<summary>
		/// Collection of <c>AdmCdeCourseComp</c> as OneToMany for AdmAppCourseCompCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppCourseComp>))]
		AdmAppCourseCompCollection,
	}
	
	#endregion AdmCdeCourseCompChildEntityTypes
	
	#region AdmCdeCourseCompFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmCdeCourseCompColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeCourseComp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeCourseCompFilterBuilder : SqlFilterBuilder<AdmCdeCourseCompColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeCourseCompFilterBuilder class.
		/// </summary>
		public AdmCdeCourseCompFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeCourseCompFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeCourseCompFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeCourseCompFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeCourseCompFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeCourseCompFilterBuilder
	
	#region AdmCdeCourseCompParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmCdeCourseCompColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeCourseComp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeCourseCompParameterBuilder : ParameterizedSqlFilterBuilder<AdmCdeCourseCompColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeCourseCompParameterBuilder class.
		/// </summary>
		public AdmCdeCourseCompParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeCourseCompParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeCourseCompParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeCourseCompParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeCourseCompParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeCourseCompParameterBuilder
	
	#region AdmCdeCourseCompSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmCdeCourseCompColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeCourseComp"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmCdeCourseCompSortBuilder : SqlSortBuilder<AdmCdeCourseCompColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeCourseCompSqlSortBuilder class.
		/// </summary>
		public AdmCdeCourseCompSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmCdeCourseCompSortBuilder
	
} // end namespace
