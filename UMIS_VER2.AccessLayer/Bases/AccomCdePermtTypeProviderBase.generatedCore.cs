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
	/// This class is the base class for any <see cref="AccomCdePermtTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomCdePermtTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomCdePermtType, UMIS_VER2.BusinessLyer.AccomCdePermtTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdePermtTypeKey key)
		{
			return Delete(transactionManager, key.AccomCdePermtTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomCdePermtTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _accomCdePermtTypeId)
		{
			return Delete(null, _accomCdePermtTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdePermtTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _accomCdePermtTypeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_CDE_PERMT_TYPE_GS_CODE_GENDER key.
		///		FK_ACCOM_CDE_PERMT_TYPE_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomCdePermtType objects.</returns>
		public TList<AccomCdePermtType> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(_gsCodeGenderId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_CDE_PERMT_TYPE_GS_CODE_GENDER key.
		///		FK_ACCOM_CDE_PERMT_TYPE_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomCdePermtType objects.</returns>
		/// <remarks></remarks>
		public TList<AccomCdePermtType> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_CDE_PERMT_TYPE_GS_CODE_GENDER key.
		///		FK_ACCOM_CDE_PERMT_TYPE_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomCdePermtType objects.</returns>
		public TList<AccomCdePermtType> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_CDE_PERMT_TYPE_GS_CODE_GENDER key.
		///		fkAccomCdePermtTypeGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomCdePermtType objects.</returns>
		public TList<AccomCdePermtType> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_CDE_PERMT_TYPE_GS_CODE_GENDER key.
		///		fkAccomCdePermtTypeGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomCdePermtType objects.</returns>
		public TList<AccomCdePermtType> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength,out int count)
		{
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_CDE_PERMT_TYPE_GS_CODE_GENDER key.
		///		FK_ACCOM_CDE_PERMT_TYPE_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomCdePermtType objects.</returns>
		public abstract TList<AccomCdePermtType> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomCdePermtType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdePermtTypeKey key, int start, int pageLength)
		{
			return GetByAccomCdePermtTypeId(transactionManager, key.AccomCdePermtTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_CDE_PERMT_TYPE index.
		/// </summary>
		/// <param name="_accomCdePermtTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdePermtType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdePermtType GetByAccomCdePermtTypeId(System.Int32 _accomCdePermtTypeId)
		{
			int count = -1;
			return GetByAccomCdePermtTypeId(null,_accomCdePermtTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_PERMT_TYPE index.
		/// </summary>
		/// <param name="_accomCdePermtTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdePermtType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdePermtType GetByAccomCdePermtTypeId(System.Int32 _accomCdePermtTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdePermtTypeId(null, _accomCdePermtTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_PERMT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdePermtTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdePermtType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdePermtType GetByAccomCdePermtTypeId(TransactionManager transactionManager, System.Int32 _accomCdePermtTypeId)
		{
			int count = -1;
			return GetByAccomCdePermtTypeId(transactionManager, _accomCdePermtTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_PERMT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdePermtTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdePermtType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdePermtType GetByAccomCdePermtTypeId(TransactionManager transactionManager, System.Int32 _accomCdePermtTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdePermtTypeId(transactionManager, _accomCdePermtTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_PERMT_TYPE index.
		/// </summary>
		/// <param name="_accomCdePermtTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdePermtType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdePermtType GetByAccomCdePermtTypeId(System.Int32 _accomCdePermtTypeId, int start, int pageLength, out int count)
		{
			return GetByAccomCdePermtTypeId(null, _accomCdePermtTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_PERMT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdePermtTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdePermtType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomCdePermtType GetByAccomCdePermtTypeId(TransactionManager transactionManager, System.Int32 _accomCdePermtTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomCdePermtType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomCdePermtType&gt;"/></returns>
		public static TList<AccomCdePermtType> Fill(IDataReader reader, TList<AccomCdePermtType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomCdePermtType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomCdePermtType")
					.Append("|").Append((System.Int32)reader["ACCOM_CDE_PERMT_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomCdePermtType>(
					key.ToString(), // EntityTrackingKey
					"AccomCdePermtType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomCdePermtType();
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
					c.AccomCdePermtTypeId = (System.Int32)reader["ACCOM_CDE_PERMT_TYPE_ID"];
					c.OriginalAccomCdePermtTypeId = c.AccomCdePermtTypeId;
					c.PermtTypeAr = Convert.IsDBNull(reader["PERMT_TYPE_AR"]) ? null : (System.String)reader["PERMT_TYPE_AR"];
					c.PermtTypeEn = Convert.IsDBNull(reader["PERMT_TYPE_EN"]) ? null : (System.String)reader["PERMT_TYPE_EN"];
					c.GsCodeGenderId = Convert.IsDBNull(reader["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)reader["GS_CODE_GENDER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomCdePermtType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdePermtType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomCdePermtType entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomCdePermtTypeId = (System.Int32)reader[((int)AccomCdePermtTypeColumn.AccomCdePermtTypeId - 1)];
			entity.OriginalAccomCdePermtTypeId = (System.Int32)reader["ACCOM_CDE_PERMT_TYPE_ID"];
			entity.PermtTypeAr = (reader.IsDBNull(((int)AccomCdePermtTypeColumn.PermtTypeAr - 1)))?null:(System.String)reader[((int)AccomCdePermtTypeColumn.PermtTypeAr - 1)];
			entity.PermtTypeEn = (reader.IsDBNull(((int)AccomCdePermtTypeColumn.PermtTypeEn - 1)))?null:(System.String)reader[((int)AccomCdePermtTypeColumn.PermtTypeEn - 1)];
			entity.GsCodeGenderId = (reader.IsDBNull(((int)AccomCdePermtTypeColumn.GsCodeGenderId - 1)))?null:(System.Decimal?)reader[((int)AccomCdePermtTypeColumn.GsCodeGenderId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomCdePermtType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdePermtType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomCdePermtType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomCdePermtTypeId = (System.Int32)dataRow["ACCOM_CDE_PERMT_TYPE_ID"];
			entity.OriginalAccomCdePermtTypeId = (System.Int32)dataRow["ACCOM_CDE_PERMT_TYPE_ID"];
			entity.PermtTypeAr = Convert.IsDBNull(dataRow["PERMT_TYPE_AR"]) ? null : (System.String)dataRow["PERMT_TYPE_AR"];
			entity.PermtTypeEn = Convert.IsDBNull(dataRow["PERMT_TYPE_EN"]) ? null : (System.String)dataRow["PERMT_TYPE_EN"];
			entity.GsCodeGenderId = Convert.IsDBNull(dataRow["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_GENDER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdePermtType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomCdePermtType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdePermtType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
			// Deep load child collections  - Call GetByAccomCdePermtTypeId methods when available
			
			#region AccomStudPermtReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudPermtReq>|AccomStudPermtReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudPermtReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudPermtReqCollection = DataRepository.AccomStudPermtReqProvider.GetByAccomCdePermtTypeId(transactionManager, entity.AccomCdePermtTypeId);

				if (deep && entity.AccomStudPermtReqCollection.Count > 0)
				{
					deepHandles.Add("AccomStudPermtReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudPermtReq>) DataRepository.AccomStudPermtReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudPermtReqCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomCdePermtType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomCdePermtType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomCdePermtType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdePermtType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AccomStudPermtReq>
				if (CanDeepSave(entity.AccomStudPermtReqCollection, "List<AccomStudPermtReq>|AccomStudPermtReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudPermtReq child in entity.AccomStudPermtReqCollection)
					{
						if(child.AccomCdePermtTypeIdSource != null)
						{
							child.AccomCdePermtTypeId = child.AccomCdePermtTypeIdSource.AccomCdePermtTypeId;
						}
						else
						{
							child.AccomCdePermtTypeId = entity.AccomCdePermtTypeId;
						}

					}

					if (entity.AccomStudPermtReqCollection.Count > 0 || entity.AccomStudPermtReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudPermtReqProvider.Save(transactionManager, entity.AccomStudPermtReqCollection);
						
						deepHandles.Add("AccomStudPermtReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudPermtReq >) DataRepository.AccomStudPermtReqProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudPermtReqCollection, deepSaveType, childTypes, innerList }
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
	
	#region AccomCdePermtTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomCdePermtType</c>
	///</summary>
	public enum AccomCdePermtTypeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCodeGender</c> at GsCodeGenderIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeGender))]
		GsCodeGender,
		///<summary>
		/// Collection of <c>AccomCdePermtType</c> as OneToMany for AccomStudPermtReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudPermtReq>))]
		AccomStudPermtReqCollection,
	}
	
	#endregion AccomCdePermtTypeChildEntityTypes
	
	#region AccomCdePermtTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomCdePermtTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdePermtType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomCdePermtTypeFilterBuilder : SqlFilterBuilder<AccomCdePermtTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdePermtTypeFilterBuilder class.
		/// </summary>
		public AccomCdePermtTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomCdePermtTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomCdePermtTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomCdePermtTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomCdePermtTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomCdePermtTypeFilterBuilder
	
	#region AccomCdePermtTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomCdePermtTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdePermtType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomCdePermtTypeParameterBuilder : ParameterizedSqlFilterBuilder<AccomCdePermtTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdePermtTypeParameterBuilder class.
		/// </summary>
		public AccomCdePermtTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomCdePermtTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomCdePermtTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomCdePermtTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomCdePermtTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomCdePermtTypeParameterBuilder
	
	#region AccomCdePermtTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomCdePermtTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdePermtType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomCdePermtTypeSortBuilder : SqlSortBuilder<AccomCdePermtTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdePermtTypeSqlSortBuilder class.
		/// </summary>
		public AccomCdePermtTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomCdePermtTypeSortBuilder
	
} // end namespace
