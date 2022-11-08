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
	/// This class is the base class for any <see cref="GsCodeIdentTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeIdentTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeIdentType, UMIS_VER2.BusinessLyer.GsCodeIdentTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeIdentTypeKey key)
		{
			return Delete(transactionManager, key.GsCodeIdentTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeIdentTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeIdentTypeId)
		{
			return Delete(null, _gsCodeIdentTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeIdentTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeIdentType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeIdentTypeKey key, int start, int pageLength)
		{
			return GetByGsCodeIdentTypeId(transactionManager, key.GsCodeIdentTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_IDENT_TYPE index.
		/// </summary>
		/// <param name="_gsCodeIdentTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeIdentType GetByGsCodeIdentTypeId(System.Decimal _gsCodeIdentTypeId)
		{
			int count = -1;
			return GetByGsCodeIdentTypeId(null,_gsCodeIdentTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_IDENT_TYPE index.
		/// </summary>
		/// <param name="_gsCodeIdentTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeIdentType GetByGsCodeIdentTypeId(System.Decimal _gsCodeIdentTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeIdentTypeId(null, _gsCodeIdentTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_IDENT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeIdentType GetByGsCodeIdentTypeId(TransactionManager transactionManager, System.Decimal _gsCodeIdentTypeId)
		{
			int count = -1;
			return GetByGsCodeIdentTypeId(transactionManager, _gsCodeIdentTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_IDENT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeIdentType GetByGsCodeIdentTypeId(TransactionManager transactionManager, System.Decimal _gsCodeIdentTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeIdentTypeId(transactionManager, _gsCodeIdentTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_IDENT_TYPE index.
		/// </summary>
		/// <param name="_gsCodeIdentTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeIdentType GetByGsCodeIdentTypeId(System.Decimal _gsCodeIdentTypeId, int start, int pageLength, out int count)
		{
			return GetByGsCodeIdentTypeId(null, _gsCodeIdentTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_IDENT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeIdentType GetByGsCodeIdentTypeId(TransactionManager transactionManager, System.Decimal _gsCodeIdentTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeIdentType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeIdentType&gt;"/></returns>
		public static TList<GsCodeIdentType> Fill(IDataReader reader, TList<GsCodeIdentType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeIdentType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeIdentType")
					.Append("|").Append((System.Decimal)reader["GS_CODE_IDENT_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeIdentType>(
					key.ToString(), // EntityTrackingKey
					"GsCodeIdentType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeIdentType();
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
					c.GsCodeIdentTypeId = (System.Decimal)reader["GS_CODE_IDENT_TYPE_ID"];
					c.OriginalGsCodeIdentTypeId = c.GsCodeIdentTypeId;
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeIdentType entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeIdentTypeId = (System.Decimal)reader[((int)GsCodeIdentTypeColumn.GsCodeIdentTypeId - 1)];
			entity.OriginalGsCodeIdentTypeId = (System.Decimal)reader["GS_CODE_IDENT_TYPE_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCodeIdentTypeColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)GsCodeIdentTypeColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeIdentType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeIdentTypeId = (System.Decimal)dataRow["GS_CODE_IDENT_TYPE_ID"];
			entity.OriginalGsCodeIdentTypeId = (System.Decimal)dataRow["GS_CODE_IDENT_TYPE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeIdentType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeIdentType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeIdentTypeId methods when available
			
			#region EdStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStud>|EdStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCollection = DataRepository.EdStudProvider.GetByGsCodeIdentTypeId(transactionManager, entity.GsCodeIdentTypeId);

				if (deep && entity.EdStudCollection.Count > 0)
				{
					deepHandles.Add("EdStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStud>) DataRepository.EdStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaStfMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaStfMember>|SaStfMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaStfMemberCollection = DataRepository.SaStfMemberProvider.GetByGsCodeIdentTypeId(transactionManager, entity.GsCodeIdentTypeId);

				if (deep && entity.SaStfMemberCollection.Count > 0)
				{
					deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfMember>) DataRepository.SaStfMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgExtMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgExtMember>|PgExtMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgExtMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgExtMemberCollection = DataRepository.PgExtMemberProvider.GetByGsCodeIdentTypeId(transactionManager, entity.GsCodeIdentTypeId);

				if (deep && entity.PgExtMemberCollection.Count > 0)
				{
					deepHandles.Add("PgExtMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgExtMember>) DataRepository.PgExtMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.PgExtMemberCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeIdentType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeIdentType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeIdentType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeIdentType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStud>
				if (CanDeepSave(entity.EdStudCollection, "List<EdStud>|EdStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStud child in entity.EdStudCollection)
					{
						if(child.GsCodeIdentTypeIdSource != null)
						{
							child.GsCodeIdentTypeId = child.GsCodeIdentTypeIdSource.GsCodeIdentTypeId;
						}
						else
						{
							child.GsCodeIdentTypeId = entity.GsCodeIdentTypeId;
						}

					}

					if (entity.EdStudCollection.Count > 0 || entity.EdStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudCollection);
						
						deepHandles.Add("EdStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStud >) DataRepository.EdStudProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaStfMember>
				if (CanDeepSave(entity.SaStfMemberCollection, "List<SaStfMember>|SaStfMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaStfMember child in entity.SaStfMemberCollection)
					{
						if(child.GsCodeIdentTypeIdSource != null)
						{
							child.GsCodeIdentTypeId = child.GsCodeIdentTypeIdSource.GsCodeIdentTypeId;
						}
						else
						{
							child.GsCodeIdentTypeId = entity.GsCodeIdentTypeId;
						}

					}

					if (entity.SaStfMemberCollection.Count > 0 || entity.SaStfMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberCollection);
						
						deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaStfMember >) DataRepository.SaStfMemberProvider.DeepSave,
							new object[] { transactionManager, entity.SaStfMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgExtMember>
				if (CanDeepSave(entity.PgExtMemberCollection, "List<PgExtMember>|PgExtMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgExtMember child in entity.PgExtMemberCollection)
					{
						if(child.GsCodeIdentTypeIdSource != null)
						{
							child.GsCodeIdentTypeId = child.GsCodeIdentTypeIdSource.GsCodeIdentTypeId;
						}
						else
						{
							child.GsCodeIdentTypeId = entity.GsCodeIdentTypeId;
						}

					}

					if (entity.PgExtMemberCollection.Count > 0 || entity.PgExtMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgExtMemberProvider.Save(transactionManager, entity.PgExtMemberCollection);
						
						deepHandles.Add("PgExtMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgExtMember >) DataRepository.PgExtMemberProvider.DeepSave,
							new object[] { transactionManager, entity.PgExtMemberCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCodeIdentTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeIdentType</c>
	///</summary>
	public enum GsCodeIdentTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCodeIdentType</c> as OneToMany for EdStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStud>))]
		EdStudCollection,
		///<summary>
		/// Collection of <c>GsCodeIdentType</c> as OneToMany for SaStfMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfMember>))]
		SaStfMemberCollection,
		///<summary>
		/// Collection of <c>GsCodeIdentType</c> as OneToMany for PgExtMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgExtMember>))]
		PgExtMemberCollection,
	}
	
	#endregion GsCodeIdentTypeChildEntityTypes
	
	#region GsCodeIdentTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeIdentTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeIdentType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeIdentTypeFilterBuilder : SqlFilterBuilder<GsCodeIdentTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeIdentTypeFilterBuilder class.
		/// </summary>
		public GsCodeIdentTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeIdentTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeIdentTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeIdentTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeIdentTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeIdentTypeFilterBuilder
	
	#region GsCodeIdentTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeIdentTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeIdentType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeIdentTypeParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeIdentTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeIdentTypeParameterBuilder class.
		/// </summary>
		public GsCodeIdentTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeIdentTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeIdentTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeIdentTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeIdentTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeIdentTypeParameterBuilder
	
	#region GsCodeIdentTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeIdentTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeIdentType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeIdentTypeSortBuilder : SqlSortBuilder<GsCodeIdentTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeIdentTypeSqlSortBuilder class.
		/// </summary>
		public GsCodeIdentTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeIdentTypeSortBuilder
	
} // end namespace
