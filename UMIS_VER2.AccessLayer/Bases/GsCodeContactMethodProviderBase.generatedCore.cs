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
	/// This class is the base class for any <see cref="GsCodeContactMethodProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeContactMethodProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeContactMethod, UMIS_VER2.BusinessLyer.GsCodeContactMethodKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeContactMethodKey key)
		{
			return Delete(transactionManager, key.GsCodeContactMethodId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeContactMethodId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeContactMethodId)
		{
			return Delete(null, _gsCodeContactMethodId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeContactMethodId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeContactMethodId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeContactMethod Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeContactMethodKey key, int start, int pageLength)
		{
			return GetByGsCodeContactMethodId(transactionManager, key.GsCodeContactMethodId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_CONTACT_METHOD index.
		/// </summary>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeContactMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeContactMethod GetByGsCodeContactMethodId(System.Decimal _gsCodeContactMethodId)
		{
			int count = -1;
			return GetByGsCodeContactMethodId(null,_gsCodeContactMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_CONTACT_METHOD index.
		/// </summary>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeContactMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeContactMethod GetByGsCodeContactMethodId(System.Decimal _gsCodeContactMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeContactMethodId(null, _gsCodeContactMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_CONTACT_METHOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeContactMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeContactMethod GetByGsCodeContactMethodId(TransactionManager transactionManager, System.Decimal _gsCodeContactMethodId)
		{
			int count = -1;
			return GetByGsCodeContactMethodId(transactionManager, _gsCodeContactMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_CONTACT_METHOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeContactMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeContactMethod GetByGsCodeContactMethodId(TransactionManager transactionManager, System.Decimal _gsCodeContactMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeContactMethodId(transactionManager, _gsCodeContactMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_CONTACT_METHOD index.
		/// </summary>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeContactMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeContactMethod GetByGsCodeContactMethodId(System.Decimal _gsCodeContactMethodId, int start, int pageLength, out int count)
		{
			return GetByGsCodeContactMethodId(null, _gsCodeContactMethodId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_CONTACT_METHOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeContactMethod"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeContactMethod GetByGsCodeContactMethodId(TransactionManager transactionManager, System.Decimal _gsCodeContactMethodId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeContactMethod&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeContactMethod&gt;"/></returns>
		public static TList<GsCodeContactMethod> Fill(IDataReader reader, TList<GsCodeContactMethod> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeContactMethod c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeContactMethod")
					.Append("|").Append((System.Decimal)reader["GS_CODE_CONTACT_METHOD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeContactMethod>(
					key.ToString(), // EntityTrackingKey
					"GsCodeContactMethod",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeContactMethod();
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
					c.GsCodeContactMethodId = (System.Decimal)reader["GS_CODE_CONTACT_METHOD_ID"];
					c.OriginalGsCodeContactMethodId = c.GsCodeContactMethodId;
					c.MethodDescrAr = (System.String)reader["METHOD_DESCR_AR"];
					c.MethodDescrEn = Convert.IsDBNull(reader["METHOD_DESCR_EN"]) ? null : (System.String)reader["METHOD_DESCR_EN"];
					c.MethodCode = Convert.IsDBNull(reader["METHOD_CODE"]) ? null : (System.String)reader["METHOD_CODE"];
					c.MethodType = Convert.IsDBNull(reader["METHOD_TYPE"]) ? null : (System.Decimal?)reader["METHOD_TYPE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeContactMethod"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeContactMethod"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeContactMethod entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeContactMethodId = (System.Decimal)reader[((int)GsCodeContactMethodColumn.GsCodeContactMethodId - 1)];
			entity.OriginalGsCodeContactMethodId = (System.Decimal)reader["GS_CODE_CONTACT_METHOD_ID"];
			entity.MethodDescrAr = (System.String)reader[((int)GsCodeContactMethodColumn.MethodDescrAr - 1)];
			entity.MethodDescrEn = (reader.IsDBNull(((int)GsCodeContactMethodColumn.MethodDescrEn - 1)))?null:(System.String)reader[((int)GsCodeContactMethodColumn.MethodDescrEn - 1)];
			entity.MethodCode = (reader.IsDBNull(((int)GsCodeContactMethodColumn.MethodCode - 1)))?null:(System.String)reader[((int)GsCodeContactMethodColumn.MethodCode - 1)];
			entity.MethodType = (reader.IsDBNull(((int)GsCodeContactMethodColumn.MethodType - 1)))?null:(System.Decimal?)reader[((int)GsCodeContactMethodColumn.MethodType - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeContactMethod"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeContactMethod"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeContactMethod entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeContactMethodId = (System.Decimal)dataRow["GS_CODE_CONTACT_METHOD_ID"];
			entity.OriginalGsCodeContactMethodId = (System.Decimal)dataRow["GS_CODE_CONTACT_METHOD_ID"];
			entity.MethodDescrAr = (System.String)dataRow["METHOD_DESCR_AR"];
			entity.MethodDescrEn = Convert.IsDBNull(dataRow["METHOD_DESCR_EN"]) ? null : (System.String)dataRow["METHOD_DESCR_EN"];
			entity.MethodCode = Convert.IsDBNull(dataRow["METHOD_CODE"]) ? null : (System.String)dataRow["METHOD_CODE"];
			entity.MethodType = Convert.IsDBNull(dataRow["METHOD_TYPE"]) ? null : (System.Decimal?)dataRow["METHOD_TYPE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeContactMethod"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeContactMethod Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeContactMethod entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeContactMethodId methods when available
			
			#region GsContactMethodDCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsContactMethodD>|GsContactMethodDCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsContactMethodDCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsContactMethodDCollection = DataRepository.GsContactMethodDProvider.GetByGsCodeContactMethodId(transactionManager, entity.GsCodeContactMethodId);

				if (deep && entity.GsContactMethodDCollection.Count > 0)
				{
					deepHandles.Add("GsContactMethodDCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsContactMethodD>) DataRepository.GsContactMethodDProvider.DeepLoad,
						new object[] { transactionManager, entity.GsContactMethodDCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudContactMethodCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudContactMethod>|EdStudContactMethodCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudContactMethodCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudContactMethodCollection = DataRepository.EdStudContactMethodProvider.GetByGsCodeContactMethodId(transactionManager, entity.GsCodeContactMethodId);

				if (deep && entity.EdStudContactMethodCollection.Count > 0)
				{
					deepHandles.Add("EdStudContactMethodCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudContactMethod>) DataRepository.EdStudContactMethodProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudContactMethodCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoContactCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoContact>|SpoContactCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoContactCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoContactCollection = DataRepository.SpoContactProvider.GetByGsCodeContactMethodId(transactionManager, entity.GsCodeContactMethodId);

				if (deep && entity.SpoContactCollection.Count > 0)
				{
					deepHandles.Add("SpoContactCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoContact>) DataRepository.SpoContactProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoContactCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeContactMethod object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeContactMethod instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeContactMethod Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeContactMethod entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<GsContactMethodD>
				if (CanDeepSave(entity.GsContactMethodDCollection, "List<GsContactMethodD>|GsContactMethodDCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsContactMethodD child in entity.GsContactMethodDCollection)
					{
						if(child.GsCodeContactMethodIdSource != null)
						{
							child.GsCodeContactMethodId = child.GsCodeContactMethodIdSource.GsCodeContactMethodId;
						}
						else
						{
							child.GsCodeContactMethodId = entity.GsCodeContactMethodId;
						}

					}

					if (entity.GsContactMethodDCollection.Count > 0 || entity.GsContactMethodDCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsContactMethodDProvider.Save(transactionManager, entity.GsContactMethodDCollection);
						
						deepHandles.Add("GsContactMethodDCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsContactMethodD >) DataRepository.GsContactMethodDProvider.DeepSave,
							new object[] { transactionManager, entity.GsContactMethodDCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudContactMethod>
				if (CanDeepSave(entity.EdStudContactMethodCollection, "List<EdStudContactMethod>|EdStudContactMethodCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudContactMethod child in entity.EdStudContactMethodCollection)
					{
						if(child.GsCodeContactMethodIdSource != null)
						{
							child.GsCodeContactMethodId = child.GsCodeContactMethodIdSource.GsCodeContactMethodId;
						}
						else
						{
							child.GsCodeContactMethodId = entity.GsCodeContactMethodId;
						}

					}

					if (entity.EdStudContactMethodCollection.Count > 0 || entity.EdStudContactMethodCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudContactMethodProvider.Save(transactionManager, entity.EdStudContactMethodCollection);
						
						deepHandles.Add("EdStudContactMethodCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudContactMethod >) DataRepository.EdStudContactMethodProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudContactMethodCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoContact>
				if (CanDeepSave(entity.SpoContactCollection, "List<SpoContact>|SpoContactCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoContact child in entity.SpoContactCollection)
					{
						if(child.GsCodeContactMethodIdSource != null)
						{
							child.GsCodeContactMethodId = child.GsCodeContactMethodIdSource.GsCodeContactMethodId;
						}
						else
						{
							child.GsCodeContactMethodId = entity.GsCodeContactMethodId;
						}

					}

					if (entity.SpoContactCollection.Count > 0 || entity.SpoContactCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoContactProvider.Save(transactionManager, entity.SpoContactCollection);
						
						deepHandles.Add("SpoContactCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoContact >) DataRepository.SpoContactProvider.DeepSave,
							new object[] { transactionManager, entity.SpoContactCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCodeContactMethodChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeContactMethod</c>
	///</summary>
	public enum GsCodeContactMethodChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCodeContactMethod</c> as OneToMany for GsContactMethodDCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsContactMethodD>))]
		GsContactMethodDCollection,
		///<summary>
		/// Collection of <c>GsCodeContactMethod</c> as OneToMany for EdStudContactMethodCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudContactMethod>))]
		EdStudContactMethodCollection,
		///<summary>
		/// Collection of <c>GsCodeContactMethod</c> as OneToMany for SpoContactCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoContact>))]
		SpoContactCollection,
	}
	
	#endregion GsCodeContactMethodChildEntityTypes
	
	#region GsCodeContactMethodFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeContactMethodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeContactMethod"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeContactMethodFilterBuilder : SqlFilterBuilder<GsCodeContactMethodColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeContactMethodFilterBuilder class.
		/// </summary>
		public GsCodeContactMethodFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeContactMethodFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeContactMethodFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeContactMethodFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeContactMethodFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeContactMethodFilterBuilder
	
	#region GsCodeContactMethodParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeContactMethodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeContactMethod"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeContactMethodParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeContactMethodColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeContactMethodParameterBuilder class.
		/// </summary>
		public GsCodeContactMethodParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeContactMethodParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeContactMethodParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeContactMethodParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeContactMethodParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeContactMethodParameterBuilder
	
	#region GsCodeContactMethodSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeContactMethodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeContactMethod"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeContactMethodSortBuilder : SqlSortBuilder<GsCodeContactMethodColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeContactMethodSqlSortBuilder class.
		/// </summary>
		public GsCodeContactMethodSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeContactMethodSortBuilder
	
} // end namespace
