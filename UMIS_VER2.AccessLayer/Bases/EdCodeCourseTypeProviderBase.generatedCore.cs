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
	/// This class is the base class for any <see cref="EdCodeCourseTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeCourseTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeCourseType, UMIS_VER2.BusinessLyer.EdCodeCourseTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseTypeKey key)
		{
			return Delete(transactionManager, key.EdCodeCourseTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeCourseTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _edCodeCourseTypeId)
		{
			return Delete(null, _edCodeCourseTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _edCodeCourseTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeCourseType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseTypeKey key, int start, int pageLength)
		{
			return GetByEdCodeCourseTypeId(transactionManager, key.EdCodeCourseTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_COURSE_TYPE index.
		/// </summary>
		/// <param name="_edCodeCourseTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseType GetByEdCodeCourseTypeId(System.Int32 _edCodeCourseTypeId)
		{
			int count = -1;
			return GetByEdCodeCourseTypeId(null,_edCodeCourseTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_COURSE_TYPE index.
		/// </summary>
		/// <param name="_edCodeCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseType GetByEdCodeCourseTypeId(System.Int32 _edCodeCourseTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseTypeId(null, _edCodeCourseTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_COURSE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseType GetByEdCodeCourseTypeId(TransactionManager transactionManager, System.Int32 _edCodeCourseTypeId)
		{
			int count = -1;
			return GetByEdCodeCourseTypeId(transactionManager, _edCodeCourseTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_COURSE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseType GetByEdCodeCourseTypeId(TransactionManager transactionManager, System.Int32 _edCodeCourseTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseTypeId(transactionManager, _edCodeCourseTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_COURSE_TYPE index.
		/// </summary>
		/// <param name="_edCodeCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseType GetByEdCodeCourseTypeId(System.Int32 _edCodeCourseTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCodeCourseTypeId(null, _edCodeCourseTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_COURSE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeCourseType GetByEdCodeCourseTypeId(TransactionManager transactionManager, System.Int32 _edCodeCourseTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeCourseType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeCourseType&gt;"/></returns>
		public static TList<EdCodeCourseType> Fill(IDataReader reader, TList<EdCodeCourseType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeCourseType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeCourseType")
					.Append("|").Append((System.Int32)reader["ED_CODE_COURSE_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeCourseType>(
					key.ToString(), // EntityTrackingKey
					"EdCodeCourseType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeCourseType();
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
					c.EdCodeCourseTypeId = (System.Int32)reader["ED_CODE_COURSE_TYPE_ID"];
					c.OriginalEdCodeCourseTypeId = c.EdCodeCourseTypeId;
					c.CourseTypeAr = Convert.IsDBNull(reader["COURSE_TYPE_AR"]) ? null : (System.String)reader["COURSE_TYPE_AR"];
					c.CourseTypeAr1 = Convert.IsDBNull(reader["COURSE_TYPE_AR1"]) ? null : (System.String)reader["COURSE_TYPE_AR1"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeCourseType entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeCourseTypeId = (System.Int32)reader[((int)EdCodeCourseTypeColumn.EdCodeCourseTypeId - 1)];
			entity.OriginalEdCodeCourseTypeId = (System.Int32)reader["ED_CODE_COURSE_TYPE_ID"];
			entity.CourseTypeAr = (reader.IsDBNull(((int)EdCodeCourseTypeColumn.CourseTypeAr - 1)))?null:(System.String)reader[((int)EdCodeCourseTypeColumn.CourseTypeAr - 1)];
			entity.CourseTypeAr1 = (reader.IsDBNull(((int)EdCodeCourseTypeColumn.CourseTypeAr1 - 1)))?null:(System.String)reader[((int)EdCodeCourseTypeColumn.CourseTypeAr1 - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeCourseType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeCourseTypeId = (System.Int32)dataRow["ED_CODE_COURSE_TYPE_ID"];
			entity.OriginalEdCodeCourseTypeId = (System.Int32)dataRow["ED_CODE_COURSE_TYPE_ID"];
			entity.CourseTypeAr = Convert.IsDBNull(dataRow["COURSE_TYPE_AR"]) ? null : (System.String)dataRow["COURSE_TYPE_AR"];
			entity.CourseTypeAr1 = Convert.IsDBNull(dataRow["COURSE_TYPE_AR1"]) ? null : (System.String)dataRow["COURSE_TYPE_AR1"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeCourseType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeCourseTypeId methods when available
			
			#region EdCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourse>|EdCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseCollection = DataRepository.EdCourseProvider.GetByEdCodeCourseTypeId(transactionManager, entity.EdCodeCourseTypeId);

				if (deep && entity.EdCourseCollection.Count > 0)
				{
					deepHandles.Add("EdCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourse>) DataRepository.EdCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeCourseType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeCourseType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeCourseType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdCourse>
				if (CanDeepSave(entity.EdCourseCollection, "List<EdCourse>|EdCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourse child in entity.EdCourseCollection)
					{
						if(child.EdCodeCourseTypeIdSource != null)
						{
							child.EdCodeCourseTypeId = child.EdCodeCourseTypeIdSource.EdCodeCourseTypeId;
						}
						else
						{
							child.EdCodeCourseTypeId = entity.EdCodeCourseTypeId;
						}

					}

					if (entity.EdCourseCollection.Count > 0 || entity.EdCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseCollection);
						
						deepHandles.Add("EdCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourse >) DataRepository.EdCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeCourseTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeCourseType</c>
	///</summary>
	public enum EdCodeCourseTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCodeCourseType</c> as OneToMany for EdCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourse>))]
		EdCourseCollection,
	}
	
	#endregion EdCodeCourseTypeChildEntityTypes
	
	#region EdCodeCourseTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeCourseTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCourseType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeCourseTypeFilterBuilder : SqlFilterBuilder<EdCodeCourseTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseTypeFilterBuilder class.
		/// </summary>
		public EdCodeCourseTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeCourseTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeCourseTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeCourseTypeFilterBuilder
	
	#region EdCodeCourseTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeCourseTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCourseType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeCourseTypeParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeCourseTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseTypeParameterBuilder class.
		/// </summary>
		public EdCodeCourseTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeCourseTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeCourseTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeCourseTypeParameterBuilder
	
	#region EdCodeCourseTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeCourseTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCourseType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeCourseTypeSortBuilder : SqlSortBuilder<EdCodeCourseTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseTypeSqlSortBuilder class.
		/// </summary>
		public EdCodeCourseTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeCourseTypeSortBuilder
	
} // end namespace
