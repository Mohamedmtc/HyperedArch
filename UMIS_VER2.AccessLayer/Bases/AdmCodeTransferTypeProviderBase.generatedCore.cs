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
	/// This class is the base class for any <see cref="AdmCodeTransferTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmCodeTransferTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmCodeTransferType, UMIS_VER2.BusinessLyer.AdmCodeTransferTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCodeTransferTypeKey key)
		{
			return Delete(transactionManager, key.AdmCodeTransferTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admCodeTransferTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admCodeTransferTypeId)
		{
			return Delete(null, _admCodeTransferTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeTransferTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admCodeTransferTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmCodeTransferType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCodeTransferTypeKey key, int start, int pageLength)
		{
			return GetByAdmCodeTransferTypeId(transactionManager, key.AdmCodeTransferTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_CODE_TRANSFER_TYPE index.
		/// </summary>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCodeTransferType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCodeTransferType GetByAdmCodeTransferTypeId(System.Decimal _admCodeTransferTypeId)
		{
			int count = -1;
			return GetByAdmCodeTransferTypeId(null,_admCodeTransferTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CODE_TRANSFER_TYPE index.
		/// </summary>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCodeTransferType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCodeTransferType GetByAdmCodeTransferTypeId(System.Decimal _admCodeTransferTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCodeTransferTypeId(null, _admCodeTransferTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CODE_TRANSFER_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCodeTransferType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCodeTransferType GetByAdmCodeTransferTypeId(TransactionManager transactionManager, System.Decimal _admCodeTransferTypeId)
		{
			int count = -1;
			return GetByAdmCodeTransferTypeId(transactionManager, _admCodeTransferTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CODE_TRANSFER_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCodeTransferType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCodeTransferType GetByAdmCodeTransferTypeId(TransactionManager transactionManager, System.Decimal _admCodeTransferTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCodeTransferTypeId(transactionManager, _admCodeTransferTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CODE_TRANSFER_TYPE index.
		/// </summary>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCodeTransferType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCodeTransferType GetByAdmCodeTransferTypeId(System.Decimal _admCodeTransferTypeId, int start, int pageLength, out int count)
		{
			return GetByAdmCodeTransferTypeId(null, _admCodeTransferTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CODE_TRANSFER_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCodeTransferType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCodeTransferType GetByAdmCodeTransferTypeId(TransactionManager transactionManager, System.Decimal _admCodeTransferTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmCodeTransferType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmCodeTransferType&gt;"/></returns>
		public static TList<AdmCodeTransferType> Fill(IDataReader reader, TList<AdmCodeTransferType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmCodeTransferType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmCodeTransferType")
					.Append("|").Append((System.Decimal)reader["ADM_CODE_TRANSFER_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmCodeTransferType>(
					key.ToString(), // EntityTrackingKey
					"AdmCodeTransferType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmCodeTransferType();
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
					c.AdmCodeTransferTypeId = (System.Decimal)reader["ADM_CODE_TRANSFER_TYPE_ID"];
					c.OriginalAdmCodeTransferTypeId = c.AdmCodeTransferTypeId;
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCodeTransferType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCodeTransferType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmCodeTransferType entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmCodeTransferTypeId = (System.Decimal)reader[((int)AdmCodeTransferTypeColumn.AdmCodeTransferTypeId - 1)];
			entity.OriginalAdmCodeTransferTypeId = (System.Decimal)reader["ADM_CODE_TRANSFER_TYPE_ID"];
			entity.DescrEn = (System.String)reader[((int)AdmCodeTransferTypeColumn.DescrEn - 1)];
			entity.DescrAr = (reader.IsDBNull(((int)AdmCodeTransferTypeColumn.DescrAr - 1)))?null:(System.String)reader[((int)AdmCodeTransferTypeColumn.DescrAr - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCodeTransferType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCodeTransferType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmCodeTransferType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmCodeTransferTypeId = (System.Decimal)dataRow["ADM_CODE_TRANSFER_TYPE_ID"];
			entity.OriginalAdmCodeTransferTypeId = (System.Decimal)dataRow["ADM_CODE_TRANSFER_TYPE_ID"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCodeTransferType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCodeTransferType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCodeTransferType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmCodeTransferTypeId methods when available
			
			#region AdmTransAcceptanceCategoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmTransAcceptanceCategory>|AdmTransAcceptanceCategoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmTransAcceptanceCategoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmTransAcceptanceCategoryCollection = DataRepository.AdmTransAcceptanceCategoryProvider.GetByAdmCodeTransferTypeId(transactionManager, entity.AdmCodeTransferTypeId);

				if (deep && entity.AdmTransAcceptanceCategoryCollection.Count > 0)
				{
					deepHandles.Add("AdmTransAcceptanceCategoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmTransAcceptanceCategory>) DataRepository.AdmTransAcceptanceCategoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmTransAcceptanceCategoryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppTransReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTransReq>|AdmAppTransReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTransReqCollection = DataRepository.AdmAppTransReqProvider.GetByAdmCodeTransferTypeId(transactionManager, entity.AdmCodeTransferTypeId);

				if (deep && entity.AdmAppTransReqCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTransReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransReq>) DataRepository.AdmAppTransReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrns>|EdStudIntTrnsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCollection = DataRepository.EdStudIntTrnsProvider.GetByAdmCodeTransferTypeId(transactionManager, entity.AdmCodeTransferTypeId);

				if (deep && entity.EdStudIntTrnsCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrns>) DataRepository.EdStudIntTrnsProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudFacultyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudFaculty>|EdStudFacultyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudFacultyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudFacultyCollection = DataRepository.EdStudFacultyProvider.GetByAdmCodeTransferTypeId(transactionManager, entity.AdmCodeTransferTypeId);

				if (deep && entity.EdStudFacultyCollection.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmCodeTransferType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmCodeTransferType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCodeTransferType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCodeTransferType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AdmTransAcceptanceCategory>
				if (CanDeepSave(entity.AdmTransAcceptanceCategoryCollection, "List<AdmTransAcceptanceCategory>|AdmTransAcceptanceCategoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmTransAcceptanceCategory child in entity.AdmTransAcceptanceCategoryCollection)
					{
						if(child.AdmCodeTransferTypeIdSource != null)
						{
							child.AdmCodeTransferTypeId = child.AdmCodeTransferTypeIdSource.AdmCodeTransferTypeId;
						}
						else
						{
							child.AdmCodeTransferTypeId = entity.AdmCodeTransferTypeId;
						}

					}

					if (entity.AdmTransAcceptanceCategoryCollection.Count > 0 || entity.AdmTransAcceptanceCategoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmTransAcceptanceCategoryProvider.Save(transactionManager, entity.AdmTransAcceptanceCategoryCollection);
						
						deepHandles.Add("AdmTransAcceptanceCategoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmTransAcceptanceCategory >) DataRepository.AdmTransAcceptanceCategoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmTransAcceptanceCategoryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppTransReq>
				if (CanDeepSave(entity.AdmAppTransReqCollection, "List<AdmAppTransReq>|AdmAppTransReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransReq child in entity.AdmAppTransReqCollection)
					{
						if(child.AdmCodeTransferTypeIdSource != null)
						{
							child.AdmCodeTransferTypeId = child.AdmCodeTransferTypeIdSource.AdmCodeTransferTypeId;
						}
						else
						{
							child.AdmCodeTransferTypeId = entity.AdmCodeTransferTypeId;
						}

					}

					if (entity.AdmAppTransReqCollection.Count > 0 || entity.AdmAppTransReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTransReqProvider.Save(transactionManager, entity.AdmAppTransReqCollection);
						
						deepHandles.Add("AdmAppTransReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTransReq >) DataRepository.AdmAppTransReqProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTransReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrns>
				if (CanDeepSave(entity.EdStudIntTrnsCollection, "List<EdStudIntTrns>|EdStudIntTrnsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrns child in entity.EdStudIntTrnsCollection)
					{
						if(child.AdmCodeTransferTypeIdSource != null)
						{
							child.AdmCodeTransferTypeId = child.AdmCodeTransferTypeIdSource.AdmCodeTransferTypeId;
						}
						else
						{
							child.AdmCodeTransferTypeId = entity.AdmCodeTransferTypeId;
						}

					}

					if (entity.EdStudIntTrnsCollection.Count > 0 || entity.EdStudIntTrnsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsProvider.Save(transactionManager, entity.EdStudIntTrnsCollection);
						
						deepHandles.Add("EdStudIntTrnsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrns >) DataRepository.EdStudIntTrnsProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudFaculty>
				if (CanDeepSave(entity.EdStudFacultyCollection, "List<EdStudFaculty>|EdStudFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudFaculty child in entity.EdStudFacultyCollection)
					{
						if(child.AdmCodeTransferTypeIdSource != null)
						{
							child.AdmCodeTransferTypeId = child.AdmCodeTransferTypeIdSource.AdmCodeTransferTypeId;
						}
						else
						{
							child.AdmCodeTransferTypeId = entity.AdmCodeTransferTypeId;
						}

					}

					if (entity.EdStudFacultyCollection.Count > 0 || entity.EdStudFacultyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudFacultyProvider.Save(transactionManager, entity.EdStudFacultyCollection);
						
						deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudFaculty >) DataRepository.EdStudFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudFacultyCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmCodeTransferTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmCodeTransferType</c>
	///</summary>
	public enum AdmCodeTransferTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AdmCodeTransferType</c> as OneToMany for AdmTransAcceptanceCategoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmTransAcceptanceCategory>))]
		AdmTransAcceptanceCategoryCollection,
		///<summary>
		/// Collection of <c>AdmCodeTransferType</c> as OneToMany for AdmAppTransReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransReq>))]
		AdmAppTransReqCollection,
		///<summary>
		/// Collection of <c>AdmCodeTransferType</c> as OneToMany for EdStudIntTrnsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrns>))]
		EdStudIntTrnsCollection,
		///<summary>
		/// Collection of <c>AdmCodeTransferType</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollection,
	}
	
	#endregion AdmCodeTransferTypeChildEntityTypes
	
	#region AdmCodeTransferTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmCodeTransferTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCodeTransferType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCodeTransferTypeFilterBuilder : SqlFilterBuilder<AdmCodeTransferTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCodeTransferTypeFilterBuilder class.
		/// </summary>
		public AdmCodeTransferTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCodeTransferTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCodeTransferTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCodeTransferTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCodeTransferTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCodeTransferTypeFilterBuilder
	
	#region AdmCodeTransferTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmCodeTransferTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCodeTransferType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCodeTransferTypeParameterBuilder : ParameterizedSqlFilterBuilder<AdmCodeTransferTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCodeTransferTypeParameterBuilder class.
		/// </summary>
		public AdmCodeTransferTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCodeTransferTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCodeTransferTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCodeTransferTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCodeTransferTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCodeTransferTypeParameterBuilder
	
	#region AdmCodeTransferTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmCodeTransferTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCodeTransferType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmCodeTransferTypeSortBuilder : SqlSortBuilder<AdmCodeTransferTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCodeTransferTypeSqlSortBuilder class.
		/// </summary>
		public AdmCodeTransferTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmCodeTransferTypeSortBuilder
	
} // end namespace
