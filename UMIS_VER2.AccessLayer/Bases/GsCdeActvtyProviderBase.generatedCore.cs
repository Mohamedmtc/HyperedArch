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
	/// This class is the base class for any <see cref="GsCdeActvtyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeActvtyProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeActvty, UMIS_VER2.BusinessLyer.GsCdeActvtyKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeActvtyKey key)
		{
			return Delete(transactionManager, key.GsCdeActvtyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeActvtyId">اكواد الانشطة اللاصفية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _gsCdeActvtyId)
		{
			return Delete(null, _gsCdeActvtyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeActvtyId">اكواد الانشطة اللاصفية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _gsCdeActvtyId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_ACTVTY_GS_CDE_ACTVTY_TYPE key.
		///		FK_GS_CDE_ACTVTY_GS_CDE_ACTVTY_TYPE Description: 
		/// </summary>
		/// <param name="_gsCdeActvtyTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeActvty objects.</returns>
		public TList<GsCdeActvty> GetByGsCdeActvtyTypeId(System.Int32? _gsCdeActvtyTypeId)
		{
			int count = -1;
			return GetByGsCdeActvtyTypeId(_gsCdeActvtyTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_ACTVTY_GS_CDE_ACTVTY_TYPE key.
		///		FK_GS_CDE_ACTVTY_GS_CDE_ACTVTY_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeActvtyTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeActvty objects.</returns>
		/// <remarks></remarks>
		public TList<GsCdeActvty> GetByGsCdeActvtyTypeId(TransactionManager transactionManager, System.Int32? _gsCdeActvtyTypeId)
		{
			int count = -1;
			return GetByGsCdeActvtyTypeId(transactionManager, _gsCdeActvtyTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_ACTVTY_GS_CDE_ACTVTY_TYPE key.
		///		FK_GS_CDE_ACTVTY_GS_CDE_ACTVTY_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeActvtyTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeActvty objects.</returns>
		public TList<GsCdeActvty> GetByGsCdeActvtyTypeId(TransactionManager transactionManager, System.Int32? _gsCdeActvtyTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeActvtyTypeId(transactionManager, _gsCdeActvtyTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_ACTVTY_GS_CDE_ACTVTY_TYPE key.
		///		fkGsCdeActvtyGsCdeActvtyType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeActvtyTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeActvty objects.</returns>
		public TList<GsCdeActvty> GetByGsCdeActvtyTypeId(System.Int32? _gsCdeActvtyTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeActvtyTypeId(null, _gsCdeActvtyTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_ACTVTY_GS_CDE_ACTVTY_TYPE key.
		///		fkGsCdeActvtyGsCdeActvtyType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeActvtyTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeActvty objects.</returns>
		public TList<GsCdeActvty> GetByGsCdeActvtyTypeId(System.Int32? _gsCdeActvtyTypeId, int start, int pageLength,out int count)
		{
			return GetByGsCdeActvtyTypeId(null, _gsCdeActvtyTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_ACTVTY_GS_CDE_ACTVTY_TYPE key.
		///		FK_GS_CDE_ACTVTY_GS_CDE_ACTVTY_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeActvtyTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeActvty objects.</returns>
		public abstract TList<GsCdeActvty> GetByGsCdeActvtyTypeId(TransactionManager transactionManager, System.Int32? _gsCdeActvtyTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeActvty Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeActvtyKey key, int start, int pageLength)
		{
			return GetByGsCdeActvtyId(transactionManager, key.GsCdeActvtyId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_ACTVTY index.
		/// </summary>
		/// <param name="_gsCdeActvtyId">اكواد الانشطة اللاصفية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeActvty GetByGsCdeActvtyId(System.Int32 _gsCdeActvtyId)
		{
			int count = -1;
			return GetByGsCdeActvtyId(null,_gsCdeActvtyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_ACTVTY index.
		/// </summary>
		/// <param name="_gsCdeActvtyId">اكواد الانشطة اللاصفية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeActvty GetByGsCdeActvtyId(System.Int32 _gsCdeActvtyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeActvtyId(null, _gsCdeActvtyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_ACTVTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeActvtyId">اكواد الانشطة اللاصفية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeActvty GetByGsCdeActvtyId(TransactionManager transactionManager, System.Int32 _gsCdeActvtyId)
		{
			int count = -1;
			return GetByGsCdeActvtyId(transactionManager, _gsCdeActvtyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_ACTVTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeActvtyId">اكواد الانشطة اللاصفية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeActvty GetByGsCdeActvtyId(TransactionManager transactionManager, System.Int32 _gsCdeActvtyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeActvtyId(transactionManager, _gsCdeActvtyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_ACTVTY index.
		/// </summary>
		/// <param name="_gsCdeActvtyId">اكواد الانشطة اللاصفية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeActvty GetByGsCdeActvtyId(System.Int32 _gsCdeActvtyId, int start, int pageLength, out int count)
		{
			return GetByGsCdeActvtyId(null, _gsCdeActvtyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_ACTVTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeActvtyId">اكواد الانشطة اللاصفية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeActvty"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeActvty GetByGsCdeActvtyId(TransactionManager transactionManager, System.Int32 _gsCdeActvtyId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeActvty&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeActvty&gt;"/></returns>
		public static TList<GsCdeActvty> Fill(IDataReader reader, TList<GsCdeActvty> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeActvty c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeActvty")
					.Append("|").Append((System.Int32)reader["GS_CDE_ACTVTY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeActvty>(
					key.ToString(), // EntityTrackingKey
					"GsCdeActvty",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeActvty();
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
					c.GsCdeActvtyId = (System.Int32)reader["GS_CDE_ACTVTY_ID"];
					c.OriginalGsCdeActvtyId = c.GsCdeActvtyId;
					c.GsCdeActvtyTypeId = Convert.IsDBNull(reader["GS_CDE_ACTVTY_TYPE_ID"]) ? null : (System.Int32?)reader["GS_CDE_ACTVTY_TYPE_ID"];
					c.ActvtyAr = (System.String)reader["ACTVTY_AR"];
					c.ActvtyEn = (System.String)reader["ACTVTY_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeActvty"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeActvty"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeActvty entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeActvtyId = (System.Int32)reader[((int)GsCdeActvtyColumn.GsCdeActvtyId - 1)];
			entity.OriginalGsCdeActvtyId = (System.Int32)reader["GS_CDE_ACTVTY_ID"];
			entity.GsCdeActvtyTypeId = (reader.IsDBNull(((int)GsCdeActvtyColumn.GsCdeActvtyTypeId - 1)))?null:(System.Int32?)reader[((int)GsCdeActvtyColumn.GsCdeActvtyTypeId - 1)];
			entity.ActvtyAr = (System.String)reader[((int)GsCdeActvtyColumn.ActvtyAr - 1)];
			entity.ActvtyEn = (System.String)reader[((int)GsCdeActvtyColumn.ActvtyEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeActvty"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeActvty"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeActvty entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeActvtyId = (System.Int32)dataRow["GS_CDE_ACTVTY_ID"];
			entity.OriginalGsCdeActvtyId = (System.Int32)dataRow["GS_CDE_ACTVTY_ID"];
			entity.GsCdeActvtyTypeId = Convert.IsDBNull(dataRow["GS_CDE_ACTVTY_TYPE_ID"]) ? null : (System.Int32?)dataRow["GS_CDE_ACTVTY_TYPE_ID"];
			entity.ActvtyAr = (System.String)dataRow["ACTVTY_AR"];
			entity.ActvtyEn = (System.String)dataRow["ACTVTY_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeActvty"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeActvty Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeActvty entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCdeActvtyTypeIdSource	
			if (CanDeepLoad(entity, "GsCdeActvtyType|GsCdeActvtyTypeIdSource", deepLoadType, innerList) 
				&& entity.GsCdeActvtyTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeActvtyTypeId ?? (int)0);
				GsCdeActvtyType tmpEntity = EntityManager.LocateEntity<GsCdeActvtyType>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeActvtyType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeActvtyTypeIdSource = tmpEntity;
				else
					entity.GsCdeActvtyTypeIdSource = DataRepository.GsCdeActvtyTypeProvider.GetByGsCdeActvtyTypeId(transactionManager, (entity.GsCdeActvtyTypeId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeActvtyTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeActvtyTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeActvtyTypeProvider.DeepLoad(transactionManager, entity.GsCdeActvtyTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeActvtyTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdeActvtyId methods when available
			
			#region EdStudActvtyRegCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudActvtyReg>|EdStudActvtyRegCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudActvtyRegCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudActvtyRegCollection = DataRepository.EdStudActvtyRegProvider.GetByGsCdeActvtyId(transactionManager, entity.GsCdeActvtyId);

				if (deep && entity.EdStudActvtyRegCollection.Count > 0)
				{
					deepHandles.Add("EdStudActvtyRegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudActvtyReg>) DataRepository.EdStudActvtyRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudActvtyRegCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeActvty object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeActvty instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeActvty Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeActvty entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCdeActvtyTypeIdSource
			if (CanDeepSave(entity, "GsCdeActvtyType|GsCdeActvtyTypeIdSource", deepSaveType, innerList) 
				&& entity.GsCdeActvtyTypeIdSource != null)
			{
				DataRepository.GsCdeActvtyTypeProvider.Save(transactionManager, entity.GsCdeActvtyTypeIdSource);
				entity.GsCdeActvtyTypeId = entity.GsCdeActvtyTypeIdSource.GsCdeActvtyTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStudActvtyReg>
				if (CanDeepSave(entity.EdStudActvtyRegCollection, "List<EdStudActvtyReg>|EdStudActvtyRegCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudActvtyReg child in entity.EdStudActvtyRegCollection)
					{
						if(child.GsCdeActvtyIdSource != null)
						{
							child.GsCdeActvtyId = child.GsCdeActvtyIdSource.GsCdeActvtyId;
						}
						else
						{
							child.GsCdeActvtyId = entity.GsCdeActvtyId;
						}

					}

					if (entity.EdStudActvtyRegCollection.Count > 0 || entity.EdStudActvtyRegCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudActvtyRegProvider.Save(transactionManager, entity.EdStudActvtyRegCollection);
						
						deepHandles.Add("EdStudActvtyRegCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudActvtyReg >) DataRepository.EdStudActvtyRegProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudActvtyRegCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCdeActvtyChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeActvty</c>
	///</summary>
	public enum GsCdeActvtyChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCdeActvtyType</c> at GsCdeActvtyTypeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeActvtyType))]
		GsCdeActvtyType,
		///<summary>
		/// Collection of <c>GsCdeActvty</c> as OneToMany for EdStudActvtyRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudActvtyReg>))]
		EdStudActvtyRegCollection,
	}
	
	#endregion GsCdeActvtyChildEntityTypes
	
	#region GsCdeActvtyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeActvtyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeActvty"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeActvtyFilterBuilder : SqlFilterBuilder<GsCdeActvtyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeActvtyFilterBuilder class.
		/// </summary>
		public GsCdeActvtyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeActvtyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeActvtyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeActvtyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeActvtyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeActvtyFilterBuilder
	
	#region GsCdeActvtyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeActvtyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeActvty"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeActvtyParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeActvtyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeActvtyParameterBuilder class.
		/// </summary>
		public GsCdeActvtyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeActvtyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeActvtyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeActvtyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeActvtyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeActvtyParameterBuilder
	
	#region GsCdeActvtySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeActvtyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeActvty"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeActvtySortBuilder : SqlSortBuilder<GsCdeActvtyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeActvtySqlSortBuilder class.
		/// </summary>
		public GsCdeActvtySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeActvtySortBuilder
	
} // end namespace
