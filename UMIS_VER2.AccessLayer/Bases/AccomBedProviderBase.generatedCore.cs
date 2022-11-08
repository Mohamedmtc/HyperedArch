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
	/// This class is the base class for any <see cref="AccomBedProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomBedProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomBed, UMIS_VER2.BusinessLyer.AccomBedKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomBedKey key)
		{
			return Delete(transactionManager, key.AccomBedId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomBedId">سراير الغرفة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _accomBedId)
		{
			return Delete(null, _accomBedId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBedId">سراير الغرفة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _accomBedId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_BED_ACCOM_ROOM key.
		///		FK_ACCOM_BED_ACCOM_ROOM Description: 
		/// </summary>
		/// <param name="_accomRoomId">الغرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomBed objects.</returns>
		public TList<AccomBed> GetByAccomRoomId(System.Decimal _accomRoomId)
		{
			int count = -1;
			return GetByAccomRoomId(_accomRoomId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_BED_ACCOM_ROOM key.
		///		FK_ACCOM_BED_ACCOM_ROOM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomRoomId">الغرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomBed objects.</returns>
		/// <remarks></remarks>
		public TList<AccomBed> GetByAccomRoomId(TransactionManager transactionManager, System.Decimal _accomRoomId)
		{
			int count = -1;
			return GetByAccomRoomId(transactionManager, _accomRoomId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_BED_ACCOM_ROOM key.
		///		FK_ACCOM_BED_ACCOM_ROOM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomRoomId">الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomBed objects.</returns>
		public TList<AccomBed> GetByAccomRoomId(TransactionManager transactionManager, System.Decimal _accomRoomId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomRoomId(transactionManager, _accomRoomId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_BED_ACCOM_ROOM key.
		///		fkAccomBedAccomRoom Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomRoomId">الغرف</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomBed objects.</returns>
		public TList<AccomBed> GetByAccomRoomId(System.Decimal _accomRoomId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomRoomId(null, _accomRoomId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_BED_ACCOM_ROOM key.
		///		fkAccomBedAccomRoom Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomRoomId">الغرف</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomBed objects.</returns>
		public TList<AccomBed> GetByAccomRoomId(System.Decimal _accomRoomId, int start, int pageLength,out int count)
		{
			return GetByAccomRoomId(null, _accomRoomId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_BED_ACCOM_ROOM key.
		///		FK_ACCOM_BED_ACCOM_ROOM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomRoomId">الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomBed objects.</returns>
		public abstract TList<AccomBed> GetByAccomRoomId(TransactionManager transactionManager, System.Decimal _accomRoomId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomBed Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomBedKey key, int start, int pageLength)
		{
			return GetByAccomBedId(transactionManager, key.AccomBedId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_BED index.
		/// </summary>
		/// <param name="_accomBedId">سراير الغرفة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomBed"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomBed GetByAccomBedId(System.Decimal _accomBedId)
		{
			int count = -1;
			return GetByAccomBedId(null,_accomBedId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_BED index.
		/// </summary>
		/// <param name="_accomBedId">سراير الغرفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomBed"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomBed GetByAccomBedId(System.Decimal _accomBedId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomBedId(null, _accomBedId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_BED index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBedId">سراير الغرفة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomBed"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomBed GetByAccomBedId(TransactionManager transactionManager, System.Decimal _accomBedId)
		{
			int count = -1;
			return GetByAccomBedId(transactionManager, _accomBedId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_BED index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBedId">سراير الغرفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomBed"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomBed GetByAccomBedId(TransactionManager transactionManager, System.Decimal _accomBedId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomBedId(transactionManager, _accomBedId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_BED index.
		/// </summary>
		/// <param name="_accomBedId">سراير الغرفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomBed"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomBed GetByAccomBedId(System.Decimal _accomBedId, int start, int pageLength, out int count)
		{
			return GetByAccomBedId(null, _accomBedId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_BED index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBedId">سراير الغرفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomBed"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomBed GetByAccomBedId(TransactionManager transactionManager, System.Decimal _accomBedId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomBed&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomBed&gt;"/></returns>
		public static TList<AccomBed> Fill(IDataReader reader, TList<AccomBed> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomBed c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomBed")
					.Append("|").Append((System.Decimal)reader["ACCOM_BED_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomBed>(
					key.ToString(), // EntityTrackingKey
					"AccomBed",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomBed();
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
					c.AccomBedId = (System.Decimal)reader["ACCOM_BED_ID"];
					c.OriginalAccomBedId = c.AccomBedId;
					c.AccomRoomId = (System.Decimal)reader["ACCOM_ROOM_ID"];
					c.BedNo = (System.Int32)reader["BED_NO"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomBed"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomBed"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomBed entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomBedId = (System.Decimal)reader[((int)AccomBedColumn.AccomBedId - 1)];
			entity.OriginalAccomBedId = (System.Decimal)reader["ACCOM_BED_ID"];
			entity.AccomRoomId = (System.Decimal)reader[((int)AccomBedColumn.AccomRoomId - 1)];
			entity.BedNo = (System.Int32)reader[((int)AccomBedColumn.BedNo - 1)];
			entity.IsActive = (reader.IsDBNull(((int)AccomBedColumn.IsActive - 1)))?null:(System.Boolean?)reader[((int)AccomBedColumn.IsActive - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomBed"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomBed"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomBed entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomBedId = (System.Decimal)dataRow["ACCOM_BED_ID"];
			entity.OriginalAccomBedId = (System.Decimal)dataRow["ACCOM_BED_ID"];
			entity.AccomRoomId = (System.Decimal)dataRow["ACCOM_ROOM_ID"];
			entity.BedNo = (System.Int32)dataRow["BED_NO"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomBed"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomBed Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomBed entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AccomRoomIdSource	
			if (CanDeepLoad(entity, "AccomRoom|AccomRoomIdSource", deepLoadType, innerList) 
				&& entity.AccomRoomIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AccomRoomId;
				AccomRoom tmpEntity = EntityManager.LocateEntity<AccomRoom>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomRoom), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomRoomIdSource = tmpEntity;
				else
					entity.AccomRoomIdSource = DataRepository.AccomRoomProvider.GetByAccomRoomId(transactionManager, entity.AccomRoomId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomRoomIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomRoomIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomRoomProvider.DeepLoad(transactionManager, entity.AccomRoomIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomRoomIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAccomBedId methods when available
			
			#region AccomStudGuestReqDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudGuestReqDtl>|AccomStudGuestReqDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudGuestReqDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudGuestReqDtlCollection = DataRepository.AccomStudGuestReqDtlProvider.GetByAccomBedId(transactionManager, entity.AccomBedId);

				if (deep && entity.AccomStudGuestReqDtlCollection.Count > 0)
				{
					deepHandles.Add("AccomStudGuestReqDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudGuestReqDtl>) DataRepository.AccomStudGuestReqDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudGuestReqDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudBookCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudBook>|AccomStudBookCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudBookCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudBookCollection = DataRepository.AccomStudBookProvider.GetByAccomBedId(transactionManager, entity.AccomBedId);

				if (deep && entity.AccomStudBookCollection.Count > 0)
				{
					deepHandles.Add("AccomStudBookCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudBook>) DataRepository.AccomStudBookProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudBookCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomBed object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomBed instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomBed Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomBed entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AccomRoomIdSource
			if (CanDeepSave(entity, "AccomRoom|AccomRoomIdSource", deepSaveType, innerList) 
				&& entity.AccomRoomIdSource != null)
			{
				DataRepository.AccomRoomProvider.Save(transactionManager, entity.AccomRoomIdSource);
				entity.AccomRoomId = entity.AccomRoomIdSource.AccomRoomId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AccomStudGuestReqDtl>
				if (CanDeepSave(entity.AccomStudGuestReqDtlCollection, "List<AccomStudGuestReqDtl>|AccomStudGuestReqDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudGuestReqDtl child in entity.AccomStudGuestReqDtlCollection)
					{
						if(child.AccomBedIdSource != null)
						{
							child.AccomBedId = child.AccomBedIdSource.AccomBedId;
						}
						else
						{
							child.AccomBedId = entity.AccomBedId;
						}

					}

					if (entity.AccomStudGuestReqDtlCollection.Count > 0 || entity.AccomStudGuestReqDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudGuestReqDtlProvider.Save(transactionManager, entity.AccomStudGuestReqDtlCollection);
						
						deepHandles.Add("AccomStudGuestReqDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudGuestReqDtl >) DataRepository.AccomStudGuestReqDtlProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudGuestReqDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudBook>
				if (CanDeepSave(entity.AccomStudBookCollection, "List<AccomStudBook>|AccomStudBookCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudBook child in entity.AccomStudBookCollection)
					{
						if(child.AccomBedIdSource != null)
						{
							child.AccomBedId = child.AccomBedIdSource.AccomBedId;
						}
						else
						{
							child.AccomBedId = entity.AccomBedId;
						}

					}

					if (entity.AccomStudBookCollection.Count > 0 || entity.AccomStudBookCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudBookProvider.Save(transactionManager, entity.AccomStudBookCollection);
						
						deepHandles.Add("AccomStudBookCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudBook >) DataRepository.AccomStudBookProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudBookCollection, deepSaveType, childTypes, innerList }
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
	
	#region AccomBedChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomBed</c>
	///</summary>
	public enum AccomBedChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AccomRoom</c> at AccomRoomIdSource
		///</summary>
		[ChildEntityType(typeof(AccomRoom))]
		AccomRoom,
		///<summary>
		/// Collection of <c>AccomBed</c> as OneToMany for AccomStudGuestReqDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudGuestReqDtl>))]
		AccomStudGuestReqDtlCollection,
		///<summary>
		/// Collection of <c>AccomBed</c> as OneToMany for AccomStudBookCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudBook>))]
		AccomStudBookCollection,
	}
	
	#endregion AccomBedChildEntityTypes
	
	#region AccomBedFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomBedColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomBed"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomBedFilterBuilder : SqlFilterBuilder<AccomBedColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomBedFilterBuilder class.
		/// </summary>
		public AccomBedFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomBedFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomBedFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomBedFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomBedFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomBedFilterBuilder
	
	#region AccomBedParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomBedColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomBed"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomBedParameterBuilder : ParameterizedSqlFilterBuilder<AccomBedColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomBedParameterBuilder class.
		/// </summary>
		public AccomBedParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomBedParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomBedParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomBedParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomBedParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomBedParameterBuilder
	
	#region AccomBedSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomBedColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomBed"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomBedSortBuilder : SqlSortBuilder<AccomBedColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomBedSqlSortBuilder class.
		/// </summary>
		public AccomBedSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomBedSortBuilder
	
} // end namespace
