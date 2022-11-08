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
	/// This class is the base class for any <see cref="GsCodeKinshipProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeKinshipProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeKinship, UMIS_VER2.BusinessLyer.GsCodeKinshipKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeKinshipKey key)
		{
			return Delete(transactionManager, key.GsCodeRelationId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeRelationId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeRelationId)
		{
			return Delete(null, _gsCodeRelationId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRelationId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeRelationId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeKinship Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeKinshipKey key, int start, int pageLength)
		{
			return GetByGsCodeRelationId(transactionManager, key.GsCodeRelationId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_KINSHIP index.
		/// </summary>
		/// <param name="_gsCodeRelationId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeKinship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeKinship GetByGsCodeRelationId(System.Decimal _gsCodeRelationId)
		{
			int count = -1;
			return GetByGsCodeRelationId(null,_gsCodeRelationId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_KINSHIP index.
		/// </summary>
		/// <param name="_gsCodeRelationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeKinship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeKinship GetByGsCodeRelationId(System.Decimal _gsCodeRelationId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeRelationId(null, _gsCodeRelationId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_KINSHIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRelationId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeKinship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeKinship GetByGsCodeRelationId(TransactionManager transactionManager, System.Decimal _gsCodeRelationId)
		{
			int count = -1;
			return GetByGsCodeRelationId(transactionManager, _gsCodeRelationId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_KINSHIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRelationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeKinship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeKinship GetByGsCodeRelationId(TransactionManager transactionManager, System.Decimal _gsCodeRelationId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeRelationId(transactionManager, _gsCodeRelationId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_KINSHIP index.
		/// </summary>
		/// <param name="_gsCodeRelationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeKinship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeKinship GetByGsCodeRelationId(System.Decimal _gsCodeRelationId, int start, int pageLength, out int count)
		{
			return GetByGsCodeRelationId(null, _gsCodeRelationId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_KINSHIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRelationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeKinship"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeKinship GetByGsCodeRelationId(TransactionManager transactionManager, System.Decimal _gsCodeRelationId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeKinship&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeKinship&gt;"/></returns>
		public static TList<GsCodeKinship> Fill(IDataReader reader, TList<GsCodeKinship> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeKinship c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeKinship")
					.Append("|").Append((System.Decimal)reader["GS_CODE_RELATION_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeKinship>(
					key.ToString(), // EntityTrackingKey
					"GsCodeKinship",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeKinship();
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
					c.GsCodeRelationId = (System.Decimal)reader["GS_CODE_RELATION_ID"];
					c.OriginalGsCodeRelationId = c.GsCodeRelationId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.EnumId = Convert.IsDBNull(reader["ENUM_ID"]) ? null : (System.Int32?)reader["ENUM_ID"];
					c.Code = Convert.IsDBNull(reader["CODE"]) ? null : (System.String)reader["CODE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeKinship"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeKinship"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeKinship entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeRelationId = (System.Decimal)reader[((int)GsCodeKinshipColumn.GsCodeRelationId - 1)];
			entity.OriginalGsCodeRelationId = (System.Decimal)reader["GS_CODE_RELATION_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCodeKinshipColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)GsCodeKinshipColumn.DescrEn - 1)))?null:(System.String)reader[((int)GsCodeKinshipColumn.DescrEn - 1)];
			entity.EnumId = (reader.IsDBNull(((int)GsCodeKinshipColumn.EnumId - 1)))?null:(System.Int32?)reader[((int)GsCodeKinshipColumn.EnumId - 1)];
			entity.Code = (reader.IsDBNull(((int)GsCodeKinshipColumn.Code - 1)))?null:(System.String)reader[((int)GsCodeKinshipColumn.Code - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeKinship"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeKinship"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeKinship entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeRelationId = (System.Decimal)dataRow["GS_CODE_RELATION_ID"];
			entity.OriginalGsCodeRelationId = (System.Decimal)dataRow["GS_CODE_RELATION_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.EnumId = Convert.IsDBNull(dataRow["ENUM_ID"]) ? null : (System.Int32?)dataRow["ENUM_ID"];
			entity.Code = Convert.IsDBNull(dataRow["CODE"]) ? null : (System.String)dataRow["CODE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeKinship"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeKinship Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeKinship entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeRelationId methods when available
			
			#region AccomStudResponsibleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudResponsible>|AccomStudResponsibleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudResponsibleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudResponsibleCollection = DataRepository.AccomStudResponsibleProvider.GetByGsCodeRelationId(transactionManager, entity.GsCodeRelationId);

				if (deep && entity.AccomStudResponsibleCollection.Count > 0)
				{
					deepHandles.Add("AccomStudResponsibleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudResponsible>) DataRepository.AccomStudResponsibleProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudResponsibleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudGuardCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudGuard>|EdStudGuardCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudGuardCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudGuardCollection = DataRepository.EdStudGuardProvider.GetByGsCodeRelationId(transactionManager, entity.GsCodeRelationId);

				if (deep && entity.EdStudGuardCollection.Count > 0)
				{
					deepHandles.Add("EdStudGuardCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGuard>) DataRepository.EdStudGuardProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGuardCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppGuardianCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppGuardian>|AdmAppGuardianCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppGuardianCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppGuardianCollection = DataRepository.AdmAppGuardianProvider.GetByGsCodeRelationId(transactionManager, entity.GsCodeRelationId);

				if (deep && entity.AdmAppGuardianCollection.Count > 0)
				{
					deepHandles.Add("AdmAppGuardianCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppGuardian>) DataRepository.AdmAppGuardianProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppGuardianCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MdiStudFamHstryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudFamHstry>|MdiStudFamHstryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudFamHstryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudFamHstryCollection = DataRepository.MdiStudFamHstryProvider.GetByGsCodeRelationId(transactionManager, entity.GsCodeRelationId);

				if (deep && entity.MdiStudFamHstryCollection.Count > 0)
				{
					deepHandles.Add("MdiStudFamHstryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudFamHstry>) DataRepository.MdiStudFamHstryProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudFamHstryCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeKinship object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeKinship instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeKinship Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeKinship entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AccomStudResponsible>
				if (CanDeepSave(entity.AccomStudResponsibleCollection, "List<AccomStudResponsible>|AccomStudResponsibleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudResponsible child in entity.AccomStudResponsibleCollection)
					{
						if(child.GsCodeRelationIdSource != null)
						{
							child.GsCodeRelationId = child.GsCodeRelationIdSource.GsCodeRelationId;
						}
						else
						{
							child.GsCodeRelationId = entity.GsCodeRelationId;
						}

					}

					if (entity.AccomStudResponsibleCollection.Count > 0 || entity.AccomStudResponsibleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudResponsibleProvider.Save(transactionManager, entity.AccomStudResponsibleCollection);
						
						deepHandles.Add("AccomStudResponsibleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudResponsible >) DataRepository.AccomStudResponsibleProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudResponsibleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudGuard>
				if (CanDeepSave(entity.EdStudGuardCollection, "List<EdStudGuard>|EdStudGuardCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudGuard child in entity.EdStudGuardCollection)
					{
						if(child.GsCodeRelationIdSource != null)
						{
							child.GsCodeRelationId = child.GsCodeRelationIdSource.GsCodeRelationId;
						}
						else
						{
							child.GsCodeRelationId = entity.GsCodeRelationId;
						}

					}

					if (entity.EdStudGuardCollection.Count > 0 || entity.EdStudGuardCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudGuardProvider.Save(transactionManager, entity.EdStudGuardCollection);
						
						deepHandles.Add("EdStudGuardCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudGuard >) DataRepository.EdStudGuardProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudGuardCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppGuardian>
				if (CanDeepSave(entity.AdmAppGuardianCollection, "List<AdmAppGuardian>|AdmAppGuardianCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppGuardian child in entity.AdmAppGuardianCollection)
					{
						if(child.GsCodeRelationIdSource != null)
						{
							child.GsCodeRelationId = child.GsCodeRelationIdSource.GsCodeRelationId;
						}
						else
						{
							child.GsCodeRelationId = entity.GsCodeRelationId;
						}

					}

					if (entity.AdmAppGuardianCollection.Count > 0 || entity.AdmAppGuardianCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppGuardianProvider.Save(transactionManager, entity.AdmAppGuardianCollection);
						
						deepHandles.Add("AdmAppGuardianCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppGuardian >) DataRepository.AdmAppGuardianProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppGuardianCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MdiStudFamHstry>
				if (CanDeepSave(entity.MdiStudFamHstryCollection, "List<MdiStudFamHstry>|MdiStudFamHstryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudFamHstry child in entity.MdiStudFamHstryCollection)
					{
						if(child.GsCodeRelationIdSource != null)
						{
							child.GsCodeRelationId = child.GsCodeRelationIdSource.GsCodeRelationId;
						}
						else
						{
							child.GsCodeRelationId = entity.GsCodeRelationId;
						}

					}

					if (entity.MdiStudFamHstryCollection.Count > 0 || entity.MdiStudFamHstryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudFamHstryProvider.Save(transactionManager, entity.MdiStudFamHstryCollection);
						
						deepHandles.Add("MdiStudFamHstryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudFamHstry >) DataRepository.MdiStudFamHstryProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudFamHstryCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCodeKinshipChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeKinship</c>
	///</summary>
	public enum GsCodeKinshipChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCodeKinship</c> as OneToMany for AccomStudResponsibleCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudResponsible>))]
		AccomStudResponsibleCollection,
		///<summary>
		/// Collection of <c>GsCodeKinship</c> as OneToMany for EdStudGuardCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGuard>))]
		EdStudGuardCollection,
		///<summary>
		/// Collection of <c>GsCodeKinship</c> as OneToMany for AdmAppGuardianCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppGuardian>))]
		AdmAppGuardianCollection,
		///<summary>
		/// Collection of <c>GsCodeKinship</c> as OneToMany for MdiStudFamHstryCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudFamHstry>))]
		MdiStudFamHstryCollection,
	}
	
	#endregion GsCodeKinshipChildEntityTypes
	
	#region GsCodeKinshipFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeKinshipColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeKinship"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeKinshipFilterBuilder : SqlFilterBuilder<GsCodeKinshipColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeKinshipFilterBuilder class.
		/// </summary>
		public GsCodeKinshipFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeKinshipFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeKinshipFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeKinshipFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeKinshipFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeKinshipFilterBuilder
	
	#region GsCodeKinshipParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeKinshipColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeKinship"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeKinshipParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeKinshipColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeKinshipParameterBuilder class.
		/// </summary>
		public GsCodeKinshipParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeKinshipParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeKinshipParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeKinshipParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeKinshipParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeKinshipParameterBuilder
	
	#region GsCodeKinshipSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeKinshipColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeKinship"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeKinshipSortBuilder : SqlSortBuilder<GsCodeKinshipColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeKinshipSqlSortBuilder class.
		/// </summary>
		public GsCodeKinshipSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeKinshipSortBuilder
	
} // end namespace
