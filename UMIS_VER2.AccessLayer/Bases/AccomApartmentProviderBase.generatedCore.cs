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
	/// This class is the base class for any <see cref="AccomApartmentProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomApartmentProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomApartment, UMIS_VER2.BusinessLyer.AccomApartmentKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomApartmentKey key)
		{
			return Delete(transactionManager, key.AccomApartmentId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomApartmentId">الشقق. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _accomApartmentId)
		{
			return Delete(null, _accomApartmentId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomApartmentId">الشقق. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _accomApartmentId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_APARTMENT_ACCOM_BUILDING key.
		///		FK_ACCOM_APARTMENT_ACCOM_BUILDING Description: 
		/// </summary>
		/// <param name="_accomBuildingId">المباني</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomApartment objects.</returns>
		public TList<AccomApartment> GetByAccomBuildingId(System.Decimal _accomBuildingId)
		{
			int count = -1;
			return GetByAccomBuildingId(_accomBuildingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_APARTMENT_ACCOM_BUILDING key.
		///		FK_ACCOM_APARTMENT_ACCOM_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBuildingId">المباني</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomApartment objects.</returns>
		/// <remarks></remarks>
		public TList<AccomApartment> GetByAccomBuildingId(TransactionManager transactionManager, System.Decimal _accomBuildingId)
		{
			int count = -1;
			return GetByAccomBuildingId(transactionManager, _accomBuildingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_APARTMENT_ACCOM_BUILDING key.
		///		FK_ACCOM_APARTMENT_ACCOM_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBuildingId">المباني</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomApartment objects.</returns>
		public TList<AccomApartment> GetByAccomBuildingId(TransactionManager transactionManager, System.Decimal _accomBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomBuildingId(transactionManager, _accomBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_APARTMENT_ACCOM_BUILDING key.
		///		fkAccomApartmentAccomBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomBuildingId">المباني</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomApartment objects.</returns>
		public TList<AccomApartment> GetByAccomBuildingId(System.Decimal _accomBuildingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomBuildingId(null, _accomBuildingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_APARTMENT_ACCOM_BUILDING key.
		///		fkAccomApartmentAccomBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomBuildingId">المباني</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomApartment objects.</returns>
		public TList<AccomApartment> GetByAccomBuildingId(System.Decimal _accomBuildingId, int start, int pageLength,out int count)
		{
			return GetByAccomBuildingId(null, _accomBuildingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_APARTMENT_ACCOM_BUILDING key.
		///		FK_ACCOM_APARTMENT_ACCOM_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBuildingId">المباني</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomApartment objects.</returns>
		public abstract TList<AccomApartment> GetByAccomBuildingId(TransactionManager transactionManager, System.Decimal _accomBuildingId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomApartment Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomApartmentKey key, int start, int pageLength)
		{
			return GetByAccomApartmentId(transactionManager, key.AccomApartmentId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_APARTMENT index.
		/// </summary>
		/// <param name="_accomApartmentId">الشقق</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomApartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomApartment GetByAccomApartmentId(System.Decimal _accomApartmentId)
		{
			int count = -1;
			return GetByAccomApartmentId(null,_accomApartmentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_APARTMENT index.
		/// </summary>
		/// <param name="_accomApartmentId">الشقق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomApartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomApartment GetByAccomApartmentId(System.Decimal _accomApartmentId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomApartmentId(null, _accomApartmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_APARTMENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomApartmentId">الشقق</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomApartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomApartment GetByAccomApartmentId(TransactionManager transactionManager, System.Decimal _accomApartmentId)
		{
			int count = -1;
			return GetByAccomApartmentId(transactionManager, _accomApartmentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_APARTMENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomApartmentId">الشقق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomApartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomApartment GetByAccomApartmentId(TransactionManager transactionManager, System.Decimal _accomApartmentId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomApartmentId(transactionManager, _accomApartmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_APARTMENT index.
		/// </summary>
		/// <param name="_accomApartmentId">الشقق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomApartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomApartment GetByAccomApartmentId(System.Decimal _accomApartmentId, int start, int pageLength, out int count)
		{
			return GetByAccomApartmentId(null, _accomApartmentId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_APARTMENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomApartmentId">الشقق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomApartment"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomApartment GetByAccomApartmentId(TransactionManager transactionManager, System.Decimal _accomApartmentId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomApartment&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomApartment&gt;"/></returns>
		public static TList<AccomApartment> Fill(IDataReader reader, TList<AccomApartment> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomApartment c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomApartment")
					.Append("|").Append((System.Decimal)reader["ACCOM_APARTMENT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomApartment>(
					key.ToString(), // EntityTrackingKey
					"AccomApartment",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomApartment();
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
					c.AccomApartmentId = (System.Decimal)reader["ACCOM_APARTMENT_ID"];
					c.OriginalAccomApartmentId = c.AccomApartmentId;
					c.AccomBuildingId = (System.Decimal)reader["ACCOM_BUILDING_ID"];
					c.ApartmentCode = (System.String)reader["APARTMENT_CODE"];
					c.ApartmentAr = (System.String)reader["APARTMENT_AR"];
					c.ApartmentEn = Convert.IsDBNull(reader["APARTMENT_EN"]) ? null : (System.String)reader["APARTMENT_EN"];
					c.FloorNo = Convert.IsDBNull(reader["FLOOR_NO"]) ? null : (System.Int16?)reader["FLOOR_NO"];
					c.WingCode = Convert.IsDBNull(reader["WING_CODE"]) ? null : (System.String)reader["WING_CODE"];
					c.AirCondFlg = Convert.IsDBNull(reader["AIR_COND_FLG"]) ? null : (System.Boolean?)reader["AIR_COND_FLG"];
					c.IsActive = (System.Boolean)reader["IS_ACTIVE"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomApartment"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomApartment"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomApartment entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomApartmentId = (System.Decimal)reader[((int)AccomApartmentColumn.AccomApartmentId - 1)];
			entity.OriginalAccomApartmentId = (System.Decimal)reader["ACCOM_APARTMENT_ID"];
			entity.AccomBuildingId = (System.Decimal)reader[((int)AccomApartmentColumn.AccomBuildingId - 1)];
			entity.ApartmentCode = (System.String)reader[((int)AccomApartmentColumn.ApartmentCode - 1)];
			entity.ApartmentAr = (System.String)reader[((int)AccomApartmentColumn.ApartmentAr - 1)];
			entity.ApartmentEn = (reader.IsDBNull(((int)AccomApartmentColumn.ApartmentEn - 1)))?null:(System.String)reader[((int)AccomApartmentColumn.ApartmentEn - 1)];
			entity.FloorNo = (reader.IsDBNull(((int)AccomApartmentColumn.FloorNo - 1)))?null:(System.Int16?)reader[((int)AccomApartmentColumn.FloorNo - 1)];
			entity.WingCode = (reader.IsDBNull(((int)AccomApartmentColumn.WingCode - 1)))?null:(System.String)reader[((int)AccomApartmentColumn.WingCode - 1)];
			entity.AirCondFlg = (reader.IsDBNull(((int)AccomApartmentColumn.AirCondFlg - 1)))?null:(System.Boolean?)reader[((int)AccomApartmentColumn.AirCondFlg - 1)];
			entity.IsActive = (System.Boolean)reader[((int)AccomApartmentColumn.IsActive - 1)];
			entity.Notes = (reader.IsDBNull(((int)AccomApartmentColumn.Notes - 1)))?null:(System.String)reader[((int)AccomApartmentColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AccomApartmentColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AccomApartmentColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AccomApartmentColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AccomApartmentColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomApartment"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomApartment"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomApartment entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomApartmentId = (System.Decimal)dataRow["ACCOM_APARTMENT_ID"];
			entity.OriginalAccomApartmentId = (System.Decimal)dataRow["ACCOM_APARTMENT_ID"];
			entity.AccomBuildingId = (System.Decimal)dataRow["ACCOM_BUILDING_ID"];
			entity.ApartmentCode = (System.String)dataRow["APARTMENT_CODE"];
			entity.ApartmentAr = (System.String)dataRow["APARTMENT_AR"];
			entity.ApartmentEn = Convert.IsDBNull(dataRow["APARTMENT_EN"]) ? null : (System.String)dataRow["APARTMENT_EN"];
			entity.FloorNo = Convert.IsDBNull(dataRow["FLOOR_NO"]) ? null : (System.Int16?)dataRow["FLOOR_NO"];
			entity.WingCode = Convert.IsDBNull(dataRow["WING_CODE"]) ? null : (System.String)dataRow["WING_CODE"];
			entity.AirCondFlg = Convert.IsDBNull(dataRow["AIR_COND_FLG"]) ? null : (System.Boolean?)dataRow["AIR_COND_FLG"];
			entity.IsActive = (System.Boolean)dataRow["IS_ACTIVE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomApartment"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomApartment Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomApartment entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AccomBuildingIdSource	
			if (CanDeepLoad(entity, "AccomBuilding|AccomBuildingIdSource", deepLoadType, innerList) 
				&& entity.AccomBuildingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AccomBuildingId;
				AccomBuilding tmpEntity = EntityManager.LocateEntity<AccomBuilding>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomBuilding), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomBuildingIdSource = tmpEntity;
				else
					entity.AccomBuildingIdSource = DataRepository.AccomBuildingProvider.GetByAccomBuildingId(transactionManager, entity.AccomBuildingId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomBuildingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomBuildingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomBuildingProvider.DeepLoad(transactionManager, entity.AccomBuildingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomBuildingIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAccomApartmentId methods when available
			
			#region AccomRoomCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomRoom>|AccomRoomCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomRoomCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomRoomCollection = DataRepository.AccomRoomProvider.GetByAccomApartmentId(transactionManager, entity.AccomApartmentId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomApartment object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomApartment instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomApartment Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomApartment entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AccomBuildingIdSource
			if (CanDeepSave(entity, "AccomBuilding|AccomBuildingIdSource", deepSaveType, innerList) 
				&& entity.AccomBuildingIdSource != null)
			{
				DataRepository.AccomBuildingProvider.Save(transactionManager, entity.AccomBuildingIdSource);
				entity.AccomBuildingId = entity.AccomBuildingIdSource.AccomBuildingId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AccomRoom>
				if (CanDeepSave(entity.AccomRoomCollection, "List<AccomRoom>|AccomRoomCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomRoom child in entity.AccomRoomCollection)
					{
						if(child.AccomApartmentIdSource != null)
						{
							child.AccomApartmentId = child.AccomApartmentIdSource.AccomApartmentId;
						}
						else
						{
							child.AccomApartmentId = entity.AccomApartmentId;
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
	
	#region AccomApartmentChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomApartment</c>
	///</summary>
	public enum AccomApartmentChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AccomBuilding</c> at AccomBuildingIdSource
		///</summary>
		[ChildEntityType(typeof(AccomBuilding))]
		AccomBuilding,
		///<summary>
		/// Collection of <c>AccomApartment</c> as OneToMany for AccomRoomCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomRoom>))]
		AccomRoomCollection,
	}
	
	#endregion AccomApartmentChildEntityTypes
	
	#region AccomApartmentFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomApartmentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomApartment"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomApartmentFilterBuilder : SqlFilterBuilder<AccomApartmentColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomApartmentFilterBuilder class.
		/// </summary>
		public AccomApartmentFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomApartmentFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomApartmentFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomApartmentFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomApartmentFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomApartmentFilterBuilder
	
	#region AccomApartmentParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomApartmentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomApartment"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomApartmentParameterBuilder : ParameterizedSqlFilterBuilder<AccomApartmentColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomApartmentParameterBuilder class.
		/// </summary>
		public AccomApartmentParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomApartmentParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomApartmentParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomApartmentParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomApartmentParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomApartmentParameterBuilder
	
	#region AccomApartmentSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomApartmentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomApartment"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomApartmentSortBuilder : SqlSortBuilder<AccomApartmentColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomApartmentSqlSortBuilder class.
		/// </summary>
		public AccomApartmentSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomApartmentSortBuilder
	
} // end namespace
