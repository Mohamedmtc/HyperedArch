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
	/// This class is the base class for any <see cref="EdCdeCourseChngRsnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeCourseChngRsnProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn, UMIS_VER2.BusinessLyer.EdCdeCourseChngRsnKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeCourseChngRsnKey key)
		{
			return Delete(transactionManager, key.EdCdeCourseChngRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCdeCourseChngRsnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCdeCourseChngRsnId)
		{
			return Delete(null, _edCdeCourseChngRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeCourseChngRsnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCdeCourseChngRsnId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeCourseChngRsnKey key, int start, int pageLength)
		{
			return GetByEdCdeCourseChngRsnId(transactionManager, key.EdCdeCourseChngRsnId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CDE_DROP_RSN index.
		/// </summary>
		/// <param name="_edCdeCourseChngRsnId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn GetByEdCdeCourseChngRsnId(System.Decimal _edCdeCourseChngRsnId)
		{
			int count = -1;
			return GetByEdCdeCourseChngRsnId(null,_edCdeCourseChngRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_DROP_RSN index.
		/// </summary>
		/// <param name="_edCdeCourseChngRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn GetByEdCdeCourseChngRsnId(System.Decimal _edCdeCourseChngRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeCourseChngRsnId(null, _edCdeCourseChngRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_DROP_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeCourseChngRsnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn GetByEdCdeCourseChngRsnId(TransactionManager transactionManager, System.Decimal _edCdeCourseChngRsnId)
		{
			int count = -1;
			return GetByEdCdeCourseChngRsnId(transactionManager, _edCdeCourseChngRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_DROP_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeCourseChngRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn GetByEdCdeCourseChngRsnId(TransactionManager transactionManager, System.Decimal _edCdeCourseChngRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeCourseChngRsnId(transactionManager, _edCdeCourseChngRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_DROP_RSN index.
		/// </summary>
		/// <param name="_edCdeCourseChngRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn GetByEdCdeCourseChngRsnId(System.Decimal _edCdeCourseChngRsnId, int start, int pageLength, out int count)
		{
			return GetByEdCdeCourseChngRsnId(null, _edCdeCourseChngRsnId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_DROP_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeCourseChngRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn GetByEdCdeCourseChngRsnId(TransactionManager transactionManager, System.Decimal _edCdeCourseChngRsnId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCdeCourseChngRsn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCdeCourseChngRsn&gt;"/></returns>
		public static TList<EdCdeCourseChngRsn> Fill(IDataReader reader, TList<EdCdeCourseChngRsn> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCdeCourseChngRsn")
					.Append("|").Append((System.Decimal)reader["ED_CDE_COURSE_CHNG_RSN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCdeCourseChngRsn>(
					key.ToString(), // EntityTrackingKey
					"EdCdeCourseChngRsn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn();
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
					c.EdCdeCourseChngRsnId = (System.Decimal)reader["ED_CDE_COURSE_CHNG_RSN_ID"];
					c.OriginalEdCdeCourseChngRsnId = c.EdCdeCourseChngRsnId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCdeCourseChngRsnId = (System.Decimal)reader[((int)EdCdeCourseChngRsnColumn.EdCdeCourseChngRsnId - 1)];
			entity.OriginalEdCdeCourseChngRsnId = (System.Decimal)reader["ED_CDE_COURSE_CHNG_RSN_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCdeCourseChngRsnColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)EdCdeCourseChngRsnColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCdeCourseChngRsnId = (System.Decimal)dataRow["ED_CDE_COURSE_CHNG_RSN_ID"];
			entity.OriginalEdCdeCourseChngRsnId = (System.Decimal)dataRow["ED_CDE_COURSE_CHNG_RSN_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCdeCourseChngRsnId methods when available
			
			#region EdStudCourseChngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseChng>|EdStudCourseChngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseChngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseChngCollection = DataRepository.EdStudCourseChngProvider.GetByEdCdeCourseChngRsnId(transactionManager, entity.EdCdeCourseChngRsnId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudCourseChng>
				if (CanDeepSave(entity.EdStudCourseChngCollection, "List<EdStudCourseChng>|EdStudCourseChngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseChng child in entity.EdStudCourseChngCollection)
					{
						if(child.EdCdeCourseChngRsnIdSource != null)
						{
							child.EdCdeCourseChngRsnId = child.EdCdeCourseChngRsnIdSource.EdCdeCourseChngRsnId;
						}
						else
						{
							child.EdCdeCourseChngRsnId = entity.EdCdeCourseChngRsnId;
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
	
	#region EdCdeCourseChngRsnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCdeCourseChngRsn</c>
	///</summary>
	public enum EdCdeCourseChngRsnChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCdeCourseChngRsn</c> as OneToMany for EdStudCourseChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseChng>))]
		EdStudCourseChngCollection,
	}
	
	#endregion EdCdeCourseChngRsnChildEntityTypes
	
	#region EdCdeCourseChngRsnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCdeCourseChngRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeCourseChngRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeCourseChngRsnFilterBuilder : SqlFilterBuilder<EdCdeCourseChngRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeCourseChngRsnFilterBuilder class.
		/// </summary>
		public EdCdeCourseChngRsnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeCourseChngRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeCourseChngRsnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeCourseChngRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeCourseChngRsnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeCourseChngRsnFilterBuilder
	
	#region EdCdeCourseChngRsnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCdeCourseChngRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeCourseChngRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeCourseChngRsnParameterBuilder : ParameterizedSqlFilterBuilder<EdCdeCourseChngRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeCourseChngRsnParameterBuilder class.
		/// </summary>
		public EdCdeCourseChngRsnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeCourseChngRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeCourseChngRsnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeCourseChngRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeCourseChngRsnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeCourseChngRsnParameterBuilder
	
	#region EdCdeCourseChngRsnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCdeCourseChngRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeCourseChngRsn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCdeCourseChngRsnSortBuilder : SqlSortBuilder<EdCdeCourseChngRsnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeCourseChngRsnSqlSortBuilder class.
		/// </summary>
		public EdCdeCourseChngRsnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCdeCourseChngRsnSortBuilder
	
} // end namespace
