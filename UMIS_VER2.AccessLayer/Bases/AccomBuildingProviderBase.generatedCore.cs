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
	/// This class is the base class for any <see cref="AccomBuildingProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomBuildingProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomBuilding, UMIS_VER2.BusinessLyer.AccomBuildingKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomBuildingKey key)
		{
			return Delete(transactionManager, key.AccomBuildingId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomBuildingId">المباني. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _accomBuildingId)
		{
			return Delete(null, _accomBuildingId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBuildingId">المباني. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _accomBuildingId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_BUILDING_GS_CODE_GENDER key.
		///		FK_ACCOM_BUILDING_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="_gsCodeGenderId">نوع  طلاب المبني</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomBuilding objects.</returns>
		public TList<AccomBuilding> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(_gsCodeGenderId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_BUILDING_GS_CODE_GENDER key.
		///		FK_ACCOM_BUILDING_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId">نوع  طلاب المبني</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomBuilding objects.</returns>
		/// <remarks></remarks>
		public TList<AccomBuilding> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_BUILDING_GS_CODE_GENDER key.
		///		FK_ACCOM_BUILDING_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId">نوع  طلاب المبني</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomBuilding objects.</returns>
		public TList<AccomBuilding> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_BUILDING_GS_CODE_GENDER key.
		///		fkAccomBuildingGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId">نوع  طلاب المبني</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomBuilding objects.</returns>
		public TList<AccomBuilding> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_BUILDING_GS_CODE_GENDER key.
		///		fkAccomBuildingGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId">نوع  طلاب المبني</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomBuilding objects.</returns>
		public TList<AccomBuilding> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength,out int count)
		{
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_BUILDING_GS_CODE_GENDER key.
		///		FK_ACCOM_BUILDING_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId">نوع  طلاب المبني</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomBuilding objects.</returns>
		public abstract TList<AccomBuilding> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomBuilding Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomBuildingKey key, int start, int pageLength)
		{
			return GetByAccomBuildingId(transactionManager, key.AccomBuildingId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_BUILDING index.
		/// </summary>
		/// <param name="_accomBuildingId">المباني</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomBuilding GetByAccomBuildingId(System.Decimal _accomBuildingId)
		{
			int count = -1;
			return GetByAccomBuildingId(null,_accomBuildingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_BUILDING index.
		/// </summary>
		/// <param name="_accomBuildingId">المباني</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomBuilding GetByAccomBuildingId(System.Decimal _accomBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomBuildingId(null, _accomBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_BUILDING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBuildingId">المباني</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomBuilding GetByAccomBuildingId(TransactionManager transactionManager, System.Decimal _accomBuildingId)
		{
			int count = -1;
			return GetByAccomBuildingId(transactionManager, _accomBuildingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_BUILDING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBuildingId">المباني</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomBuilding GetByAccomBuildingId(TransactionManager transactionManager, System.Decimal _accomBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomBuildingId(transactionManager, _accomBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_BUILDING index.
		/// </summary>
		/// <param name="_accomBuildingId">المباني</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomBuilding GetByAccomBuildingId(System.Decimal _accomBuildingId, int start, int pageLength, out int count)
		{
			return GetByAccomBuildingId(null, _accomBuildingId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_BUILDING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBuildingId">المباني</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomBuilding"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomBuilding GetByAccomBuildingId(TransactionManager transactionManager, System.Decimal _accomBuildingId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomBuilding&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomBuilding&gt;"/></returns>
		public static TList<AccomBuilding> Fill(IDataReader reader, TList<AccomBuilding> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomBuilding c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomBuilding")
					.Append("|").Append((System.Decimal)reader["ACCOM_BUILDING_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomBuilding>(
					key.ToString(), // EntityTrackingKey
					"AccomBuilding",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomBuilding();
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
					c.AccomBuildingId = (System.Decimal)reader["ACCOM_BUILDING_ID"];
					c.OriginalAccomBuildingId = c.AccomBuildingId;
					c.BuildingCode = (System.String)reader["BUILDING_CODE"];
					c.BuildingAr = (System.String)reader["BUILDING_AR"];
					c.BuildingEn = Convert.IsDBNull(reader["BUILDING_EN"]) ? null : (System.String)reader["BUILDING_EN"];
					c.GsCodeGenderId = Convert.IsDBNull(reader["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)reader["GS_CODE_GENDER_ID"];
					c.OutFlg = Convert.IsDBNull(reader["OUT_FLG"]) ? null : (System.Boolean?)reader["OUT_FLG"];
					c.FloorCount = Convert.IsDBNull(reader["FLOOR_COUNT"]) ? null : (System.Int16?)reader["FLOOR_COUNT"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomBuilding"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomBuilding"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomBuilding entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomBuildingId = (System.Decimal)reader[((int)AccomBuildingColumn.AccomBuildingId - 1)];
			entity.OriginalAccomBuildingId = (System.Decimal)reader["ACCOM_BUILDING_ID"];
			entity.BuildingCode = (System.String)reader[((int)AccomBuildingColumn.BuildingCode - 1)];
			entity.BuildingAr = (System.String)reader[((int)AccomBuildingColumn.BuildingAr - 1)];
			entity.BuildingEn = (reader.IsDBNull(((int)AccomBuildingColumn.BuildingEn - 1)))?null:(System.String)reader[((int)AccomBuildingColumn.BuildingEn - 1)];
			entity.GsCodeGenderId = (reader.IsDBNull(((int)AccomBuildingColumn.GsCodeGenderId - 1)))?null:(System.Decimal?)reader[((int)AccomBuildingColumn.GsCodeGenderId - 1)];
			entity.OutFlg = (reader.IsDBNull(((int)AccomBuildingColumn.OutFlg - 1)))?null:(System.Boolean?)reader[((int)AccomBuildingColumn.OutFlg - 1)];
			entity.FloorCount = (reader.IsDBNull(((int)AccomBuildingColumn.FloorCount - 1)))?null:(System.Int16?)reader[((int)AccomBuildingColumn.FloorCount - 1)];
			entity.Notes = (reader.IsDBNull(((int)AccomBuildingColumn.Notes - 1)))?null:(System.String)reader[((int)AccomBuildingColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AccomBuildingColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AccomBuildingColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AccomBuildingColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AccomBuildingColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomBuilding"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomBuilding"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomBuilding entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomBuildingId = (System.Decimal)dataRow["ACCOM_BUILDING_ID"];
			entity.OriginalAccomBuildingId = (System.Decimal)dataRow["ACCOM_BUILDING_ID"];
			entity.BuildingCode = (System.String)dataRow["BUILDING_CODE"];
			entity.BuildingAr = (System.String)dataRow["BUILDING_AR"];
			entity.BuildingEn = Convert.IsDBNull(dataRow["BUILDING_EN"]) ? null : (System.String)dataRow["BUILDING_EN"];
			entity.GsCodeGenderId = Convert.IsDBNull(dataRow["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_GENDER_ID"];
			entity.OutFlg = Convert.IsDBNull(dataRow["OUT_FLG"]) ? null : (System.Boolean?)dataRow["OUT_FLG"];
			entity.FloorCount = Convert.IsDBNull(dataRow["FLOOR_COUNT"]) ? null : (System.Int16?)dataRow["FLOOR_COUNT"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomBuilding"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomBuilding Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomBuilding entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCodeGenderIdSource	
			if (CanDeepLoad(entity, "GsCodeGender|GsCodeGenderIdSource", deepLoadType, innerList) 
				&& entity.GsCodeGenderIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeGenderId ?? 0.0m);
				GsCodeGender tmpEntity = EntityManager.LocateEntity<GsCodeGender>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeGender), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeGenderIdSource = tmpEntity;
				else
					entity.GsCodeGenderIdSource = DataRepository.GsCodeGenderProvider.GetByGsCodeGenderId(transactionManager, (entity.GsCodeGenderId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeGenderIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeGenderIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeGenderProvider.DeepLoad(transactionManager, entity.GsCodeGenderIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeGenderIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAccomBuildingId methods when available
			
			#region AccomApartmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomApartment>|AccomApartmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomApartmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomApartmentCollection = DataRepository.AccomApartmentProvider.GetByAccomBuildingId(transactionManager, entity.AccomBuildingId);

				if (deep && entity.AccomApartmentCollection.Count > 0)
				{
					deepHandles.Add("AccomApartmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomApartment>) DataRepository.AccomApartmentProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomApartmentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomRoomCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomRoom>|AccomRoomCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomRoomCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomRoomCollection = DataRepository.AccomRoomProvider.GetByAccomBuildingId(transactionManager, entity.AccomBuildingId);

				if (deep && entity.AccomRoomCollection.Count > 0)
				{
					deepHandles.Add("AccomRoomCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomRoom>) DataRepository.AccomRoomProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomRoomCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomBuilding object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomBuilding instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomBuilding Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomBuilding entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCodeGenderIdSource
			if (CanDeepSave(entity, "GsCodeGender|GsCodeGenderIdSource", deepSaveType, innerList) 
				&& entity.GsCodeGenderIdSource != null)
			{
				DataRepository.GsCodeGenderProvider.Save(transactionManager, entity.GsCodeGenderIdSource);
				entity.GsCodeGenderId = entity.GsCodeGenderIdSource.GsCodeGenderId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AccomApartment>
				if (CanDeepSave(entity.AccomApartmentCollection, "List<AccomApartment>|AccomApartmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomApartment child in entity.AccomApartmentCollection)
					{
						if(child.AccomBuildingIdSource != null)
						{
							child.AccomBuildingId = child.AccomBuildingIdSource.AccomBuildingId;
						}
						else
						{
							child.AccomBuildingId = entity.AccomBuildingId;
						}

					}

					if (entity.AccomApartmentCollection.Count > 0 || entity.AccomApartmentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomApartmentProvider.Save(transactionManager, entity.AccomApartmentCollection);
						
						deepHandles.Add("AccomApartmentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomApartment >) DataRepository.AccomApartmentProvider.DeepSave,
							new object[] { transactionManager, entity.AccomApartmentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomRoom>
				if (CanDeepSave(entity.AccomRoomCollection, "List<AccomRoom>|AccomRoomCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomRoom child in entity.AccomRoomCollection)
					{
						if(child.AccomBuildingIdSource != null)
						{
							child.AccomBuildingId = child.AccomBuildingIdSource.AccomBuildingId;
						}
						else
						{
							child.AccomBuildingId = entity.AccomBuildingId;
						}

					}

					if (entity.AccomRoomCollection.Count > 0 || entity.AccomRoomCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomRoomProvider.Save(transactionManager, entity.AccomRoomCollection);
						
						deepHandles.Add("AccomRoomCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomRoom >) DataRepository.AccomRoomProvider.DeepSave,
							new object[] { transactionManager, entity.AccomRoomCollection, deepSaveType, childTypes, innerList }
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
	
	#region AccomBuildingChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomBuilding</c>
	///</summary>
	public enum AccomBuildingChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCodeGender</c> at GsCodeGenderIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeGender))]
		GsCodeGender,
		///<summary>
		/// Collection of <c>AccomBuilding</c> as OneToMany for AccomApartmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomApartment>))]
		AccomApartmentCollection,
		///<summary>
		/// Collection of <c>AccomBuilding</c> as OneToMany for AccomRoomCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomRoom>))]
		AccomRoomCollection,
	}
	
	#endregion AccomBuildingChildEntityTypes
	
	#region AccomBuildingFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomBuildingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomBuilding"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomBuildingFilterBuilder : SqlFilterBuilder<AccomBuildingColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomBuildingFilterBuilder class.
		/// </summary>
		public AccomBuildingFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomBuildingFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomBuildingFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomBuildingFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomBuildingFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomBuildingFilterBuilder
	
	#region AccomBuildingParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomBuildingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomBuilding"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomBuildingParameterBuilder : ParameterizedSqlFilterBuilder<AccomBuildingColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomBuildingParameterBuilder class.
		/// </summary>
		public AccomBuildingParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomBuildingParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomBuildingParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomBuildingParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomBuildingParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomBuildingParameterBuilder
	
	#region AccomBuildingSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomBuildingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomBuilding"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomBuildingSortBuilder : SqlSortBuilder<AccomBuildingColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomBuildingSqlSortBuilder class.
		/// </summary>
		public AccomBuildingSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomBuildingSortBuilder
	
} // end namespace
