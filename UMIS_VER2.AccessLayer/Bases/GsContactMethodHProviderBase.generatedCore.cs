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
	/// This class is the base class for any <see cref="GsContactMethodHProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsContactMethodHProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsContactMethodH, UMIS_VER2.BusinessLyer.GsContactMethodHKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsContactMethodHKey key)
		{
			return Delete(transactionManager, key.GsContactMethodHId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsContactMethodHId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsContactMethodHId)
		{
			return Delete(null, _gsContactMethodHId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsContactMethodHId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsContactMethodHId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsContactMethodH Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsContactMethodHKey key, int start, int pageLength)
		{
			return GetByGsContactMethodHId(transactionManager, key.GsContactMethodHId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CONTACT_METHOD_H index.
		/// </summary>
		/// <param name="_gsContactMethodHId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsContactMethodH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsContactMethodH GetByGsContactMethodHId(System.Decimal _gsContactMethodHId)
		{
			int count = -1;
			return GetByGsContactMethodHId(null,_gsContactMethodHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CONTACT_METHOD_H index.
		/// </summary>
		/// <param name="_gsContactMethodHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsContactMethodH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsContactMethodH GetByGsContactMethodHId(System.Decimal _gsContactMethodHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsContactMethodHId(null, _gsContactMethodHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CONTACT_METHOD_H index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsContactMethodHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsContactMethodH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsContactMethodH GetByGsContactMethodHId(TransactionManager transactionManager, System.Decimal _gsContactMethodHId)
		{
			int count = -1;
			return GetByGsContactMethodHId(transactionManager, _gsContactMethodHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CONTACT_METHOD_H index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsContactMethodHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsContactMethodH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsContactMethodH GetByGsContactMethodHId(TransactionManager transactionManager, System.Decimal _gsContactMethodHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsContactMethodHId(transactionManager, _gsContactMethodHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CONTACT_METHOD_H index.
		/// </summary>
		/// <param name="_gsContactMethodHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsContactMethodH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsContactMethodH GetByGsContactMethodHId(System.Decimal _gsContactMethodHId, int start, int pageLength, out int count)
		{
			return GetByGsContactMethodHId(null, _gsContactMethodHId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CONTACT_METHOD_H index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsContactMethodHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsContactMethodH"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsContactMethodH GetByGsContactMethodHId(TransactionManager transactionManager, System.Decimal _gsContactMethodHId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsContactMethodH&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsContactMethodH&gt;"/></returns>
		public static TList<GsContactMethodH> Fill(IDataReader reader, TList<GsContactMethodH> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsContactMethodH c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsContactMethodH")
					.Append("|").Append((System.Decimal)reader["GS_CONTACT_METHOD_H_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsContactMethodH>(
					key.ToString(), // EntityTrackingKey
					"GsContactMethodH",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsContactMethodH();
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
					c.GsContactMethodHId = (System.Decimal)reader["GS_CONTACT_METHOD_H_ID"];
					c.OriginalGsContactMethodHId = c.GsContactMethodHId;
					c.HeaderDescrAr = Convert.IsDBNull(reader["HEADER_DESCR_AR"]) ? null : (System.String)reader["HEADER_DESCR_AR"];
					c.HeaderDescrEn = Convert.IsDBNull(reader["HEADER_DESCR_EN"]) ? null : (System.String)reader["HEADER_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsContactMethodH"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsContactMethodH"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsContactMethodH entity)
		{
			if (!reader.Read()) return;
			
			entity.GsContactMethodHId = (System.Decimal)reader[((int)GsContactMethodHColumn.GsContactMethodHId - 1)];
			entity.OriginalGsContactMethodHId = (System.Decimal)reader["GS_CONTACT_METHOD_H_ID"];
			entity.HeaderDescrAr = (reader.IsDBNull(((int)GsContactMethodHColumn.HeaderDescrAr - 1)))?null:(System.String)reader[((int)GsContactMethodHColumn.HeaderDescrAr - 1)];
			entity.HeaderDescrEn = (reader.IsDBNull(((int)GsContactMethodHColumn.HeaderDescrEn - 1)))?null:(System.String)reader[((int)GsContactMethodHColumn.HeaderDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsContactMethodH"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsContactMethodH"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsContactMethodH entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsContactMethodHId = (System.Decimal)dataRow["GS_CONTACT_METHOD_H_ID"];
			entity.OriginalGsContactMethodHId = (System.Decimal)dataRow["GS_CONTACT_METHOD_H_ID"];
			entity.HeaderDescrAr = Convert.IsDBNull(dataRow["HEADER_DESCR_AR"]) ? null : (System.String)dataRow["HEADER_DESCR_AR"];
			entity.HeaderDescrEn = Convert.IsDBNull(dataRow["HEADER_DESCR_EN"]) ? null : (System.String)dataRow["HEADER_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsContactMethodH"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsContactMethodH Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsContactMethodH entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsContactMethodHId methods when available
			
			#region GsContactMethodDCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsContactMethodD>|GsContactMethodDCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsContactMethodDCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsContactMethodDCollection = DataRepository.GsContactMethodDProvider.GetByGsContactMethodHId(transactionManager, entity.GsContactMethodHId);

				if (deep && entity.GsContactMethodDCollection.Count > 0)
				{
					deepHandles.Add("GsContactMethodDCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsContactMethodD>) DataRepository.GsContactMethodDProvider.DeepLoad,
						new object[] { transactionManager, entity.GsContactMethodDCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SaStfMemberCollection = DataRepository.SaStfMemberProvider.GetByGsContactMethodHId(transactionManager, entity.GsContactMethodHId);

				if (deep && entity.SaStfMemberCollection.Count > 0)
				{
					deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfMember>) DataRepository.SaStfMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaCodeOrgCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaCodeOrg>|SaCodeOrgCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeOrgCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaCodeOrgCollection = DataRepository.SaCodeOrgProvider.GetByGsContactMethodHId(transactionManager, entity.GsContactMethodHId);

				if (deep && entity.SaCodeOrgCollection.Count > 0)
				{
					deepHandles.Add("SaCodeOrgCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaCodeOrg>) DataRepository.SaCodeOrgProvider.DeepLoad,
						new object[] { transactionManager, entity.SaCodeOrgCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaCodeTrainingOrgCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaCodeTrainingOrg>|SaCodeTrainingOrgCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeTrainingOrgCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaCodeTrainingOrgCollection = DataRepository.SaCodeTrainingOrgProvider.GetByGsContactMethodHId(transactionManager, entity.GsContactMethodHId);

				if (deep && entity.SaCodeTrainingOrgCollection.Count > 0)
				{
					deepHandles.Add("SaCodeTrainingOrgCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaCodeTrainingOrg>) DataRepository.SaCodeTrainingOrgProvider.DeepLoad,
						new object[] { transactionManager, entity.SaCodeTrainingOrgCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsContactMethodH object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsContactMethodH instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsContactMethodH Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsContactMethodH entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
						if(child.GsContactMethodHIdSource != null)
						{
							child.GsContactMethodHId = child.GsContactMethodHIdSource.GsContactMethodHId;
						}
						else
						{
							child.GsContactMethodHId = entity.GsContactMethodHId;
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
				
	
			#region List<SaStfMember>
				if (CanDeepSave(entity.SaStfMemberCollection, "List<SaStfMember>|SaStfMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaStfMember child in entity.SaStfMemberCollection)
					{
						if(child.GsContactMethodHIdSource != null)
						{
							child.GsContactMethodHId = child.GsContactMethodHIdSource.GsContactMethodHId;
						}
						else
						{
							child.GsContactMethodHId = entity.GsContactMethodHId;
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
				
	
			#region List<SaCodeOrg>
				if (CanDeepSave(entity.SaCodeOrgCollection, "List<SaCodeOrg>|SaCodeOrgCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaCodeOrg child in entity.SaCodeOrgCollection)
					{
						if(child.GsContactMethodHIdSource != null)
						{
							child.GsContactMethodHId = child.GsContactMethodHIdSource.GsContactMethodHId;
						}
						else
						{
							child.GsContactMethodHId = entity.GsContactMethodHId;
						}

					}

					if (entity.SaCodeOrgCollection.Count > 0 || entity.SaCodeOrgCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaCodeOrgProvider.Save(transactionManager, entity.SaCodeOrgCollection);
						
						deepHandles.Add("SaCodeOrgCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaCodeOrg >) DataRepository.SaCodeOrgProvider.DeepSave,
							new object[] { transactionManager, entity.SaCodeOrgCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaCodeTrainingOrg>
				if (CanDeepSave(entity.SaCodeTrainingOrgCollection, "List<SaCodeTrainingOrg>|SaCodeTrainingOrgCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaCodeTrainingOrg child in entity.SaCodeTrainingOrgCollection)
					{
						if(child.GsContactMethodHIdSource != null)
						{
							child.GsContactMethodHId = child.GsContactMethodHIdSource.GsContactMethodHId;
						}
						else
						{
							child.GsContactMethodHId = entity.GsContactMethodHId;
						}

					}

					if (entity.SaCodeTrainingOrgCollection.Count > 0 || entity.SaCodeTrainingOrgCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaCodeTrainingOrgProvider.Save(transactionManager, entity.SaCodeTrainingOrgCollection);
						
						deepHandles.Add("SaCodeTrainingOrgCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaCodeTrainingOrg >) DataRepository.SaCodeTrainingOrgProvider.DeepSave,
							new object[] { transactionManager, entity.SaCodeTrainingOrgCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsContactMethodHChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsContactMethodH</c>
	///</summary>
	public enum GsContactMethodHChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsContactMethodH</c> as OneToMany for GsContactMethodDCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsContactMethodD>))]
		GsContactMethodDCollection,
		///<summary>
		/// Collection of <c>GsContactMethodH</c> as OneToMany for SaStfMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfMember>))]
		SaStfMemberCollection,
		///<summary>
		/// Collection of <c>GsContactMethodH</c> as OneToMany for SaCodeOrgCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaCodeOrg>))]
		SaCodeOrgCollection,
		///<summary>
		/// Collection of <c>GsContactMethodH</c> as OneToMany for SaCodeTrainingOrgCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaCodeTrainingOrg>))]
		SaCodeTrainingOrgCollection,
	}
	
	#endregion GsContactMethodHChildEntityTypes
	
	#region GsContactMethodHFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsContactMethodHColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsContactMethodH"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsContactMethodHFilterBuilder : SqlFilterBuilder<GsContactMethodHColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsContactMethodHFilterBuilder class.
		/// </summary>
		public GsContactMethodHFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsContactMethodHFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsContactMethodHFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsContactMethodHFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsContactMethodHFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsContactMethodHFilterBuilder
	
	#region GsContactMethodHParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsContactMethodHColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsContactMethodH"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsContactMethodHParameterBuilder : ParameterizedSqlFilterBuilder<GsContactMethodHColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsContactMethodHParameterBuilder class.
		/// </summary>
		public GsContactMethodHParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsContactMethodHParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsContactMethodHParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsContactMethodHParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsContactMethodHParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsContactMethodHParameterBuilder
	
	#region GsContactMethodHSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsContactMethodHColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsContactMethodH"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsContactMethodHSortBuilder : SqlSortBuilder<GsContactMethodHColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsContactMethodHSqlSortBuilder class.
		/// </summary>
		public GsContactMethodHSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsContactMethodHSortBuilder
	
} // end namespace
