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
	/// This class is the base class for any <see cref="EdCdeEnrollChngRsnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeEnrollChngRsnProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn, UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsnKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsnKey key)
		{
			return Delete(transactionManager, key.EdCdeEnrollChngRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCdeEnrollChngRsnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCdeEnrollChngRsnId)
		{
			return Delete(null, _edCdeEnrollChngRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeEnrollChngRsnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCdeEnrollChngRsnId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsnKey key, int start, int pageLength)
		{
			return GetByEdCdeEnrollChngRsnId(transactionManager, key.EdCdeEnrollChngRsnId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CDE_ENROLL_CHNG_RSN index.
		/// </summary>
		/// <param name="_edCdeEnrollChngRsnId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn GetByEdCdeEnrollChngRsnId(System.Decimal _edCdeEnrollChngRsnId)
		{
			int count = -1;
			return GetByEdCdeEnrollChngRsnId(null,_edCdeEnrollChngRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_ENROLL_CHNG_RSN index.
		/// </summary>
		/// <param name="_edCdeEnrollChngRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn GetByEdCdeEnrollChngRsnId(System.Decimal _edCdeEnrollChngRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeEnrollChngRsnId(null, _edCdeEnrollChngRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_ENROLL_CHNG_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeEnrollChngRsnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn GetByEdCdeEnrollChngRsnId(TransactionManager transactionManager, System.Decimal _edCdeEnrollChngRsnId)
		{
			int count = -1;
			return GetByEdCdeEnrollChngRsnId(transactionManager, _edCdeEnrollChngRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_ENROLL_CHNG_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeEnrollChngRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn GetByEdCdeEnrollChngRsnId(TransactionManager transactionManager, System.Decimal _edCdeEnrollChngRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeEnrollChngRsnId(transactionManager, _edCdeEnrollChngRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_ENROLL_CHNG_RSN index.
		/// </summary>
		/// <param name="_edCdeEnrollChngRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn GetByEdCdeEnrollChngRsnId(System.Decimal _edCdeEnrollChngRsnId, int start, int pageLength, out int count)
		{
			return GetByEdCdeEnrollChngRsnId(null, _edCdeEnrollChngRsnId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_ENROLL_CHNG_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeEnrollChngRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn GetByEdCdeEnrollChngRsnId(TransactionManager transactionManager, System.Decimal _edCdeEnrollChngRsnId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCdeEnrollChngRsn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCdeEnrollChngRsn&gt;"/></returns>
		public static TList<EdCdeEnrollChngRsn> Fill(IDataReader reader, TList<EdCdeEnrollChngRsn> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCdeEnrollChngRsn")
					.Append("|").Append((System.Decimal)reader["ED_CDE_ENROLL_CHNG_RSN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCdeEnrollChngRsn>(
					key.ToString(), // EntityTrackingKey
					"EdCdeEnrollChngRsn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn();
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
					c.EdCdeEnrollChngRsnId = (System.Decimal)reader["ED_CDE_ENROLL_CHNG_RSN_ID"];
					c.OriginalEdCdeEnrollChngRsnId = c.EdCdeEnrollChngRsnId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.IsActive = Convert.IsDBNull(reader["IS_ACTIVE"]) ? null : (System.Boolean?)reader["IS_ACTIVE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCdeEnrollChngRsnId = (System.Decimal)reader[((int)EdCdeEnrollChngRsnColumn.EdCdeEnrollChngRsnId - 1)];
			entity.OriginalEdCdeEnrollChngRsnId = (System.Decimal)reader["ED_CDE_ENROLL_CHNG_RSN_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCdeEnrollChngRsnColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)EdCdeEnrollChngRsnColumn.DescrEn - 1)];
			entity.IsActive = (reader.IsDBNull(((int)EdCdeEnrollChngRsnColumn.IsActive - 1)))?null:(System.Boolean?)reader[((int)EdCdeEnrollChngRsnColumn.IsActive - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCdeEnrollChngRsnId = (System.Decimal)dataRow["ED_CDE_ENROLL_CHNG_RSN_ID"];
			entity.OriginalEdCdeEnrollChngRsnId = (System.Decimal)dataRow["ED_CDE_ENROLL_CHNG_RSN_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.IsActive = Convert.IsDBNull(dataRow["IS_ACTIVE"]) ? null : (System.Boolean?)dataRow["IS_ACTIVE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCdeEnrollChngRsnId methods when available
			
			#region EdStudEnrollChangeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudEnrollChange>|EdStudEnrollChangeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudEnrollChangeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudEnrollChangeCollection = DataRepository.EdStudEnrollChangeProvider.GetByEdCdeEnrollChngRsnId(transactionManager, entity.EdCdeEnrollChngRsnId);

				if (deep && entity.EdStudEnrollChangeCollection.Count > 0)
				{
					deepHandles.Add("EdStudEnrollChangeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudEnrollChange>) DataRepository.EdStudEnrollChangeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudEnrollChangeCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudEnrollChange>
				if (CanDeepSave(entity.EdStudEnrollChangeCollection, "List<EdStudEnrollChange>|EdStudEnrollChangeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudEnrollChange child in entity.EdStudEnrollChangeCollection)
					{
						if(child.EdCdeEnrollChngRsnIdSource != null)
						{
							child.EdCdeEnrollChngRsnId = child.EdCdeEnrollChngRsnIdSource.EdCdeEnrollChngRsnId;
						}
						else
						{
							child.EdCdeEnrollChngRsnId = entity.EdCdeEnrollChngRsnId;
						}

					}

					if (entity.EdStudEnrollChangeCollection.Count > 0 || entity.EdStudEnrollChangeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudEnrollChangeProvider.Save(transactionManager, entity.EdStudEnrollChangeCollection);
						
						deepHandles.Add("EdStudEnrollChangeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudEnrollChange >) DataRepository.EdStudEnrollChangeProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudEnrollChangeCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCdeEnrollChngRsnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCdeEnrollChngRsn</c>
	///</summary>
	public enum EdCdeEnrollChngRsnChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCdeEnrollChngRsn</c> as OneToMany for EdStudEnrollChangeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudEnrollChange>))]
		EdStudEnrollChangeCollection,
	}
	
	#endregion EdCdeEnrollChngRsnChildEntityTypes
	
	#region EdCdeEnrollChngRsnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCdeEnrollChngRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeEnrollChngRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeEnrollChngRsnFilterBuilder : SqlFilterBuilder<EdCdeEnrollChngRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeEnrollChngRsnFilterBuilder class.
		/// </summary>
		public EdCdeEnrollChngRsnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeEnrollChngRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeEnrollChngRsnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeEnrollChngRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeEnrollChngRsnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeEnrollChngRsnFilterBuilder
	
	#region EdCdeEnrollChngRsnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCdeEnrollChngRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeEnrollChngRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeEnrollChngRsnParameterBuilder : ParameterizedSqlFilterBuilder<EdCdeEnrollChngRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeEnrollChngRsnParameterBuilder class.
		/// </summary>
		public EdCdeEnrollChngRsnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeEnrollChngRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeEnrollChngRsnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeEnrollChngRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeEnrollChngRsnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeEnrollChngRsnParameterBuilder
	
	#region EdCdeEnrollChngRsnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCdeEnrollChngRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeEnrollChngRsn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCdeEnrollChngRsnSortBuilder : SqlSortBuilder<EdCdeEnrollChngRsnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeEnrollChngRsnSqlSortBuilder class.
		/// </summary>
		public EdCdeEnrollChngRsnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCdeEnrollChngRsnSortBuilder
	
} // end namespace
