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
	/// This class is the base class for any <see cref="EdCdeGrdChngRsnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeGrdChngRsnProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn, UMIS_VER2.BusinessLyer.EdCdeGrdChngRsnKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeGrdChngRsnKey key)
		{
			return Delete(transactionManager, key.EdCdeGrdChngRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCdeGrdChngRsnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCdeGrdChngRsnId)
		{
			return Delete(null, _edCdeGrdChngRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeGrdChngRsnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCdeGrdChngRsnId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeGrdChngRsnKey key, int start, int pageLength)
		{
			return GetByEdCdeGrdChngRsnId(transactionManager, key.EdCdeGrdChngRsnId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CDE_GRD_CHNG_RSN index.
		/// </summary>
		/// <param name="_edCdeGrdChngRsnId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn GetByEdCdeGrdChngRsnId(System.Decimal _edCdeGrdChngRsnId)
		{
			int count = -1;
			return GetByEdCdeGrdChngRsnId(null,_edCdeGrdChngRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_GRD_CHNG_RSN index.
		/// </summary>
		/// <param name="_edCdeGrdChngRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn GetByEdCdeGrdChngRsnId(System.Decimal _edCdeGrdChngRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeGrdChngRsnId(null, _edCdeGrdChngRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_GRD_CHNG_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeGrdChngRsnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn GetByEdCdeGrdChngRsnId(TransactionManager transactionManager, System.Decimal _edCdeGrdChngRsnId)
		{
			int count = -1;
			return GetByEdCdeGrdChngRsnId(transactionManager, _edCdeGrdChngRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_GRD_CHNG_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeGrdChngRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn GetByEdCdeGrdChngRsnId(TransactionManager transactionManager, System.Decimal _edCdeGrdChngRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeGrdChngRsnId(transactionManager, _edCdeGrdChngRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_GRD_CHNG_RSN index.
		/// </summary>
		/// <param name="_edCdeGrdChngRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn GetByEdCdeGrdChngRsnId(System.Decimal _edCdeGrdChngRsnId, int start, int pageLength, out int count)
		{
			return GetByEdCdeGrdChngRsnId(null, _edCdeGrdChngRsnId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_GRD_CHNG_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeGrdChngRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn GetByEdCdeGrdChngRsnId(TransactionManager transactionManager, System.Decimal _edCdeGrdChngRsnId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCdeGrdChngRsn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCdeGrdChngRsn&gt;"/></returns>
		public static TList<EdCdeGrdChngRsn> Fill(IDataReader reader, TList<EdCdeGrdChngRsn> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCdeGrdChngRsn")
					.Append("|").Append((System.Decimal)reader["ED_CDE_GRD_CHNG_RSN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCdeGrdChngRsn>(
					key.ToString(), // EntityTrackingKey
					"EdCdeGrdChngRsn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn();
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
					c.EdCdeGrdChngRsnId = (System.Decimal)reader["ED_CDE_GRD_CHNG_RSN_ID"];
					c.OriginalEdCdeGrdChngRsnId = c.EdCdeGrdChngRsnId;
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCdeGrdChngRsnId = (System.Decimal)reader[((int)EdCdeGrdChngRsnColumn.EdCdeGrdChngRsnId - 1)];
			entity.OriginalEdCdeGrdChngRsnId = (System.Decimal)reader["ED_CDE_GRD_CHNG_RSN_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCdeGrdChngRsnColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)EdCdeGrdChngRsnColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCdeGrdChngRsnId = (System.Decimal)dataRow["ED_CDE_GRD_CHNG_RSN_ID"];
			entity.OriginalEdCdeGrdChngRsnId = (System.Decimal)dataRow["ED_CDE_GRD_CHNG_RSN_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCdeGrdChngRsnId methods when available
			
			#region EdStudCourseGrdChngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseGrdChngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseGrdChngCollection = DataRepository.EdStudCourseGrdChngProvider.GetByEdCdeGrdChngRsnId(transactionManager, entity.EdCdeGrdChngRsnId);

				if (deep && entity.EdStudCourseGrdChngCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseGrdChngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseGrdChng>) DataRepository.EdStudCourseGrdChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseGrdChngCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudCourseGrdChng>
				if (CanDeepSave(entity.EdStudCourseGrdChngCollection, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseGrdChng child in entity.EdStudCourseGrdChngCollection)
					{
						if(child.EdCdeGrdChngRsnIdSource != null)
						{
							child.EdCdeGrdChngRsnId = child.EdCdeGrdChngRsnIdSource.EdCdeGrdChngRsnId;
						}
						else
						{
							child.EdCdeGrdChngRsnId = entity.EdCdeGrdChngRsnId;
						}

					}

					if (entity.EdStudCourseGrdChngCollection.Count > 0 || entity.EdStudCourseGrdChngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseGrdChngProvider.Save(transactionManager, entity.EdStudCourseGrdChngCollection);
						
						deepHandles.Add("EdStudCourseGrdChngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseGrdChng >) DataRepository.EdStudCourseGrdChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseGrdChngCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCdeGrdChngRsnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCdeGrdChngRsn</c>
	///</summary>
	public enum EdCdeGrdChngRsnChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCdeGrdChngRsn</c> as OneToMany for EdStudCourseGrdChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseGrdChng>))]
		EdStudCourseGrdChngCollection,
	}
	
	#endregion EdCdeGrdChngRsnChildEntityTypes
	
	#region EdCdeGrdChngRsnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCdeGrdChngRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeGrdChngRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeGrdChngRsnFilterBuilder : SqlFilterBuilder<EdCdeGrdChngRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeGrdChngRsnFilterBuilder class.
		/// </summary>
		public EdCdeGrdChngRsnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeGrdChngRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeGrdChngRsnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeGrdChngRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeGrdChngRsnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeGrdChngRsnFilterBuilder
	
	#region EdCdeGrdChngRsnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCdeGrdChngRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeGrdChngRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeGrdChngRsnParameterBuilder : ParameterizedSqlFilterBuilder<EdCdeGrdChngRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeGrdChngRsnParameterBuilder class.
		/// </summary>
		public EdCdeGrdChngRsnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeGrdChngRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeGrdChngRsnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeGrdChngRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeGrdChngRsnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeGrdChngRsnParameterBuilder
	
	#region EdCdeGrdChngRsnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCdeGrdChngRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeGrdChngRsn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCdeGrdChngRsnSortBuilder : SqlSortBuilder<EdCdeGrdChngRsnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeGrdChngRsnSqlSortBuilder class.
		/// </summary>
		public EdCdeGrdChngRsnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCdeGrdChngRsnSortBuilder
	
} // end namespace
