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
	/// This class is the base class for any <see cref="SaCodeCourseTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeCourseTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeCourseType, UMIS_VER2.BusinessLyer.SaCodeCourseTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeCourseTypeKey key)
		{
			return Delete(transactionManager, key.SaCodeCourseTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeCourseTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeCourseTypeId)
		{
			return Delete(null, _saCodeCourseTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCourseTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeCourseTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeCourseType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeCourseTypeKey key, int start, int pageLength)
		{
			return GetBySaCodeCourseTypeId(transactionManager, key.SaCodeCourseTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_COURSE_TYPE index.
		/// </summary>
		/// <param name="_saCodeCourseTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCourseType GetBySaCodeCourseTypeId(System.Decimal _saCodeCourseTypeId)
		{
			int count = -1;
			return GetBySaCodeCourseTypeId(null,_saCodeCourseTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COURSE_TYPE index.
		/// </summary>
		/// <param name="_saCodeCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCourseType GetBySaCodeCourseTypeId(System.Decimal _saCodeCourseTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeCourseTypeId(null, _saCodeCourseTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COURSE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCourseTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCourseType GetBySaCodeCourseTypeId(TransactionManager transactionManager, System.Decimal _saCodeCourseTypeId)
		{
			int count = -1;
			return GetBySaCodeCourseTypeId(transactionManager, _saCodeCourseTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COURSE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCourseType GetBySaCodeCourseTypeId(TransactionManager transactionManager, System.Decimal _saCodeCourseTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeCourseTypeId(transactionManager, _saCodeCourseTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COURSE_TYPE index.
		/// </summary>
		/// <param name="_saCodeCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCourseType GetBySaCodeCourseTypeId(System.Decimal _saCodeCourseTypeId, int start, int pageLength, out int count)
		{
			return GetBySaCodeCourseTypeId(null, _saCodeCourseTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COURSE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeCourseType GetBySaCodeCourseTypeId(TransactionManager transactionManager, System.Decimal _saCodeCourseTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeCourseType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeCourseType&gt;"/></returns>
		public static TList<SaCodeCourseType> Fill(IDataReader reader, TList<SaCodeCourseType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeCourseType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeCourseType")
					.Append("|").Append((System.Decimal)reader["SA_CODE_COURSE_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeCourseType>(
					key.ToString(), // EntityTrackingKey
					"SaCodeCourseType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeCourseType();
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
					c.SaCodeCourseTypeId = (System.Decimal)reader["SA_CODE_COURSE_TYPE_ID"];
					c.OriginalSaCodeCourseTypeId = c.SaCodeCourseTypeId;
					c.CourseTypeCode = (System.String)reader["COURSE_TYPE_CODE"];
					c.CourseTypeDescr = (System.String)reader["COURSE_TYPE_DESCR"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeCourseType entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeCourseTypeId = (System.Decimal)reader[((int)SaCodeCourseTypeColumn.SaCodeCourseTypeId - 1)];
			entity.OriginalSaCodeCourseTypeId = (System.Decimal)reader["SA_CODE_COURSE_TYPE_ID"];
			entity.CourseTypeCode = (System.String)reader[((int)SaCodeCourseTypeColumn.CourseTypeCode - 1)];
			entity.CourseTypeDescr = (System.String)reader[((int)SaCodeCourseTypeColumn.CourseTypeDescr - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeCourseType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeCourseTypeId = (System.Decimal)dataRow["SA_CODE_COURSE_TYPE_ID"];
			entity.OriginalSaCodeCourseTypeId = (System.Decimal)dataRow["SA_CODE_COURSE_TYPE_ID"];
			entity.CourseTypeCode = (System.String)dataRow["COURSE_TYPE_CODE"];
			entity.CourseTypeDescr = (System.String)dataRow["COURSE_TYPE_DESCR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeCourseType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeCourseType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeCourseTypeId methods when available
			
			#region SaCodeCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaCodeCourse>|SaCodeCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaCodeCourseCollection = DataRepository.SaCodeCourseProvider.GetByCourseTypeId(transactionManager, entity.SaCodeCourseTypeId);

				if (deep && entity.SaCodeCourseCollection.Count > 0)
				{
					deepHandles.Add("SaCodeCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaCodeCourse>) DataRepository.SaCodeCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.SaCodeCourseCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeCourseType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeCourseType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeCourseType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeCourseType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaCodeCourse>
				if (CanDeepSave(entity.SaCodeCourseCollection, "List<SaCodeCourse>|SaCodeCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaCodeCourse child in entity.SaCodeCourseCollection)
					{
						if(child.CourseTypeIdSource != null)
						{
							child.CourseTypeId = child.CourseTypeIdSource.SaCodeCourseTypeId;
						}
						else
						{
							child.CourseTypeId = entity.SaCodeCourseTypeId;
						}

					}

					if (entity.SaCodeCourseCollection.Count > 0 || entity.SaCodeCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaCodeCourseProvider.Save(transactionManager, entity.SaCodeCourseCollection);
						
						deepHandles.Add("SaCodeCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaCodeCourse >) DataRepository.SaCodeCourseProvider.DeepSave,
							new object[] { transactionManager, entity.SaCodeCourseCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodeCourseTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeCourseType</c>
	///</summary>
	public enum SaCodeCourseTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCodeCourseType</c> as OneToMany for SaCodeCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaCodeCourse>))]
		SaCodeCourseCollection,
	}
	
	#endregion SaCodeCourseTypeChildEntityTypes
	
	#region SaCodeCourseTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeCourseTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeCourseType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeCourseTypeFilterBuilder : SqlFilterBuilder<SaCodeCourseTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseTypeFilterBuilder class.
		/// </summary>
		public SaCodeCourseTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeCourseTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeCourseTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeCourseTypeFilterBuilder
	
	#region SaCodeCourseTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeCourseTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeCourseType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeCourseTypeParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeCourseTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseTypeParameterBuilder class.
		/// </summary>
		public SaCodeCourseTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeCourseTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeCourseTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeCourseTypeParameterBuilder
	
	#region SaCodeCourseTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeCourseTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeCourseType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeCourseTypeSortBuilder : SqlSortBuilder<SaCodeCourseTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseTypeSqlSortBuilder class.
		/// </summary>
		public SaCodeCourseTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeCourseTypeSortBuilder
	
} // end namespace
