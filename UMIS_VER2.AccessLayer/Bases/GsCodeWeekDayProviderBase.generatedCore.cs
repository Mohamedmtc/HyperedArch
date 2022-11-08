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
	/// This class is the base class for any <see cref="GsCodeWeekDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeWeekDayProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeWeekDay, UMIS_VER2.BusinessLyer.GsCodeWeekDayKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeWeekDayKey key)
		{
			return Delete(transactionManager, key.GsCodeWeekDayId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeWeekDayId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeWeekDayId)
		{
			return Delete(null, _gsCodeWeekDayId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeWeekDayId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeWeekDay Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeWeekDayKey key, int start, int pageLength)
		{
			return GetByGsCodeWeekDayId(transactionManager, key.GsCodeWeekDayId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_WEEK_DAY index.
		/// </summary>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeWeekDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeWeekDay GetByGsCodeWeekDayId(System.Decimal _gsCodeWeekDayId)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(null,_gsCodeWeekDayId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_WEEK_DAY index.
		/// </summary>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeWeekDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeWeekDay GetByGsCodeWeekDayId(System.Decimal _gsCodeWeekDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(null, _gsCodeWeekDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_WEEK_DAY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeWeekDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeWeekDay GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal _gsCodeWeekDayId)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(transactionManager, _gsCodeWeekDayId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_WEEK_DAY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeWeekDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeWeekDay GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal _gsCodeWeekDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(transactionManager, _gsCodeWeekDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_WEEK_DAY index.
		/// </summary>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeWeekDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeWeekDay GetByGsCodeWeekDayId(System.Decimal _gsCodeWeekDayId, int start, int pageLength, out int count)
		{
			return GetByGsCodeWeekDayId(null, _gsCodeWeekDayId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_WEEK_DAY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeWeekDay"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeWeekDay GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal _gsCodeWeekDayId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeWeekDay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeWeekDay&gt;"/></returns>
		public static TList<GsCodeWeekDay> Fill(IDataReader reader, TList<GsCodeWeekDay> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeWeekDay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeWeekDay")
					.Append("|").Append((System.Decimal)reader["GS_CODE_WEEK_DAY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeWeekDay>(
					key.ToString(), // EntityTrackingKey
					"GsCodeWeekDay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeWeekDay();
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
					c.GsCodeWeekDayId = (System.Decimal)reader["GS_CODE_WEEK_DAY_ID"];
					c.OriginalGsCodeWeekDayId = c.GsCodeWeekDayId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.DayOrder = Convert.IsDBNull(reader["DAY_ORDER"]) ? null : (System.Decimal?)reader["DAY_ORDER"];
					c.Symbol = Convert.IsDBNull(reader["SYMBOL"]) ? null : (System.String)reader["SYMBOL"];
					c.OffFlg = (System.Decimal)reader["OFF_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeWeekDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeWeekDay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeWeekDay entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeWeekDayId = (System.Decimal)reader[((int)GsCodeWeekDayColumn.GsCodeWeekDayId - 1)];
			entity.OriginalGsCodeWeekDayId = (System.Decimal)reader["GS_CODE_WEEK_DAY_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCodeWeekDayColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)GsCodeWeekDayColumn.DescrEn - 1)))?null:(System.String)reader[((int)GsCodeWeekDayColumn.DescrEn - 1)];
			entity.DayOrder = (reader.IsDBNull(((int)GsCodeWeekDayColumn.DayOrder - 1)))?null:(System.Decimal?)reader[((int)GsCodeWeekDayColumn.DayOrder - 1)];
			entity.Symbol = (reader.IsDBNull(((int)GsCodeWeekDayColumn.Symbol - 1)))?null:(System.String)reader[((int)GsCodeWeekDayColumn.Symbol - 1)];
			entity.OffFlg = (System.Decimal)reader[((int)GsCodeWeekDayColumn.OffFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeWeekDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeWeekDay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeWeekDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeWeekDayId = (System.Decimal)dataRow["GS_CODE_WEEK_DAY_ID"];
			entity.OriginalGsCodeWeekDayId = (System.Decimal)dataRow["GS_CODE_WEEK_DAY_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.DayOrder = Convert.IsDBNull(dataRow["DAY_ORDER"]) ? null : (System.Decimal?)dataRow["DAY_ORDER"];
			entity.Symbol = Convert.IsDBNull(dataRow["SYMBOL"]) ? null : (System.String)dataRow["SYMBOL"];
			entity.OffFlg = (System.Decimal)dataRow["OFF_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeWeekDay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeWeekDay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeWeekDay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeWeekDayId methods when available
			
			#region SaOfficeHourCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaOfficeHour>|SaOfficeHourCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaOfficeHourCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaOfficeHourCollection = DataRepository.SaOfficeHourProvider.GetByGsCodeWeekDayId(transactionManager, entity.GsCodeWeekDayId);

				if (deep && entity.SaOfficeHourCollection.Count > 0)
				{
					deepHandles.Add("SaOfficeHourCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaOfficeHour>) DataRepository.SaOfficeHourProvider.DeepLoad,
						new object[] { transactionManager, entity.SaOfficeHourCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSchdlSlotCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSchdlSlot>|ScSchdlSlotCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlSlotCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSchdlSlotCollection = DataRepository.ScSchdlSlotProvider.GetByGsCodeWeekDayId(transactionManager, entity.GsCodeWeekDayId);

				if (deep && entity.ScSchdlSlotCollection.Count > 0)
				{
					deepHandles.Add("ScSchdlSlotCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSchdlSlot>) DataRepository.ScSchdlSlotProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSchdlSlotCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScTchngDayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScTchngDay>|ScTchngDayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScTchngDayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScTchngDayCollection = DataRepository.ScTchngDayProvider.GetByGsCodeWeekDayId(transactionManager, entity.GsCodeWeekDayId);

				if (deep && entity.ScTchngDayCollection.Count > 0)
				{
					deepHandles.Add("ScTchngDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScTchngDay>) DataRepository.ScTchngDayProvider.DeepLoad,
						new object[] { transactionManager, entity.ScTchngDayCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAbsence>|EdStudAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAbsenceCollection = DataRepository.EdStudAbsenceProvider.GetByScGroupDayId(transactionManager, entity.GsCodeWeekDayId);

				if (deep && entity.EdStudAbsenceCollection.Count > 0)
				{
					deepHandles.Add("EdStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAbsence>) DataRepository.EdStudAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudFeedReqDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudFeedReqDtl>|AccomStudFeedReqDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudFeedReqDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudFeedReqDtlCollection = DataRepository.AccomStudFeedReqDtlProvider.GetByGsCodeWeekDayId(transactionManager, entity.GsCodeWeekDayId);

				if (deep && entity.AccomStudFeedReqDtlCollection.Count > 0)
				{
					deepHandles.Add("AccomStudFeedReqDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudFeedReqDtl>) DataRepository.AccomStudFeedReqDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudFeedReqDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScTchngSlotCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScTchngSlot>|ScTchngSlotCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScTchngSlotCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScTchngSlotCollection = DataRepository.ScTchngSlotProvider.GetByGsCodeWeekDayId(transactionManager, entity.GsCodeWeekDayId);

				if (deep && entity.ScTchngSlotCollection.Count > 0)
				{
					deepHandles.Add("ScTchngSlotCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScTchngSlot>) DataRepository.ScTchngSlotProvider.DeepLoad,
						new object[] { transactionManager, entity.ScTchngSlotCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScScheduleDtlDayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleDtlDay>|ScScheduleDtlDayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlDayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleDtlDayCollection = DataRepository.ScScheduleDtlDayProvider.GetByGsCodeWeekDayId(transactionManager, entity.GsCodeWeekDayId);

				if (deep && entity.ScScheduleDtlDayCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleDtlDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleDtlDay>) DataRepository.ScScheduleDtlDayProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleDtlDayCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScDaySlotCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScDaySlot>|ScDaySlotCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScDaySlotCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScDaySlotCollection = DataRepository.ScDaySlotProvider.GetByGsCodeWeekDayId(transactionManager, entity.GsCodeWeekDayId);

				if (deep && entity.ScDaySlotCollection.Count > 0)
				{
					deepHandles.Add("ScDaySlotCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScDaySlot>) DataRepository.ScDaySlotProvider.DeepLoad,
						new object[] { transactionManager, entity.ScDaySlotCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeWeekDay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeWeekDay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeWeekDay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeWeekDay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaOfficeHour>
				if (CanDeepSave(entity.SaOfficeHourCollection, "List<SaOfficeHour>|SaOfficeHourCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaOfficeHour child in entity.SaOfficeHourCollection)
					{
						if(child.GsCodeWeekDayIdSource != null)
						{
							child.GsCodeWeekDayId = child.GsCodeWeekDayIdSource.GsCodeWeekDayId;
						}
						else
						{
							child.GsCodeWeekDayId = entity.GsCodeWeekDayId;
						}

					}

					if (entity.SaOfficeHourCollection.Count > 0 || entity.SaOfficeHourCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaOfficeHourProvider.Save(transactionManager, entity.SaOfficeHourCollection);
						
						deepHandles.Add("SaOfficeHourCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaOfficeHour >) DataRepository.SaOfficeHourProvider.DeepSave,
							new object[] { transactionManager, entity.SaOfficeHourCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSchdlSlot>
				if (CanDeepSave(entity.ScSchdlSlotCollection, "List<ScSchdlSlot>|ScSchdlSlotCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSchdlSlot child in entity.ScSchdlSlotCollection)
					{
						if(child.GsCodeWeekDayIdSource != null)
						{
							child.GsCodeWeekDayId = child.GsCodeWeekDayIdSource.GsCodeWeekDayId;
						}
						else
						{
							child.GsCodeWeekDayId = entity.GsCodeWeekDayId;
						}

					}

					if (entity.ScSchdlSlotCollection.Count > 0 || entity.ScSchdlSlotCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSchdlSlotProvider.Save(transactionManager, entity.ScSchdlSlotCollection);
						
						deepHandles.Add("ScSchdlSlotCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSchdlSlot >) DataRepository.ScSchdlSlotProvider.DeepSave,
							new object[] { transactionManager, entity.ScSchdlSlotCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScTchngDay>
				if (CanDeepSave(entity.ScTchngDayCollection, "List<ScTchngDay>|ScTchngDayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScTchngDay child in entity.ScTchngDayCollection)
					{
						if(child.GsCodeWeekDayIdSource != null)
						{
							child.GsCodeWeekDayId = child.GsCodeWeekDayIdSource.GsCodeWeekDayId;
						}
						else
						{
							child.GsCodeWeekDayId = entity.GsCodeWeekDayId;
						}

					}

					if (entity.ScTchngDayCollection.Count > 0 || entity.ScTchngDayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScTchngDayProvider.Save(transactionManager, entity.ScTchngDayCollection);
						
						deepHandles.Add("ScTchngDayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScTchngDay >) DataRepository.ScTchngDayProvider.DeepSave,
							new object[] { transactionManager, entity.ScTchngDayCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAbsence>
				if (CanDeepSave(entity.EdStudAbsenceCollection, "List<EdStudAbsence>|EdStudAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAbsence child in entity.EdStudAbsenceCollection)
					{
						if(child.ScGroupDayIdSource != null)
						{
							child.ScGroupDayId = child.ScGroupDayIdSource.GsCodeWeekDayId;
						}
						else
						{
							child.ScGroupDayId = entity.GsCodeWeekDayId;
						}

					}

					if (entity.EdStudAbsenceCollection.Count > 0 || entity.EdStudAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAbsenceProvider.Save(transactionManager, entity.EdStudAbsenceCollection);
						
						deepHandles.Add("EdStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAbsence >) DataRepository.EdStudAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAbsenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudFeedReqDtl>
				if (CanDeepSave(entity.AccomStudFeedReqDtlCollection, "List<AccomStudFeedReqDtl>|AccomStudFeedReqDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudFeedReqDtl child in entity.AccomStudFeedReqDtlCollection)
					{
						if(child.GsCodeWeekDayIdSource != null)
						{
							child.GsCodeWeekDayId = child.GsCodeWeekDayIdSource.GsCodeWeekDayId;
						}
						else
						{
							child.GsCodeWeekDayId = entity.GsCodeWeekDayId;
						}

					}

					if (entity.AccomStudFeedReqDtlCollection.Count > 0 || entity.AccomStudFeedReqDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudFeedReqDtlProvider.Save(transactionManager, entity.AccomStudFeedReqDtlCollection);
						
						deepHandles.Add("AccomStudFeedReqDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudFeedReqDtl >) DataRepository.AccomStudFeedReqDtlProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudFeedReqDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScTchngSlot>
				if (CanDeepSave(entity.ScTchngSlotCollection, "List<ScTchngSlot>|ScTchngSlotCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScTchngSlot child in entity.ScTchngSlotCollection)
					{
						if(child.GsCodeWeekDayIdSource != null)
						{
							child.GsCodeWeekDayId = child.GsCodeWeekDayIdSource.GsCodeWeekDayId;
						}
						else
						{
							child.GsCodeWeekDayId = entity.GsCodeWeekDayId;
						}

					}

					if (entity.ScTchngSlotCollection.Count > 0 || entity.ScTchngSlotCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScTchngSlotProvider.Save(transactionManager, entity.ScTchngSlotCollection);
						
						deepHandles.Add("ScTchngSlotCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScTchngSlot >) DataRepository.ScTchngSlotProvider.DeepSave,
							new object[] { transactionManager, entity.ScTchngSlotCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScScheduleDtlDay>
				if (CanDeepSave(entity.ScScheduleDtlDayCollection, "List<ScScheduleDtlDay>|ScScheduleDtlDayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleDtlDay child in entity.ScScheduleDtlDayCollection)
					{
						if(child.GsCodeWeekDayIdSource != null)
						{
							child.GsCodeWeekDayId = child.GsCodeWeekDayIdSource.GsCodeWeekDayId;
						}
						else
						{
							child.GsCodeWeekDayId = entity.GsCodeWeekDayId;
						}

					}

					if (entity.ScScheduleDtlDayCollection.Count > 0 || entity.ScScheduleDtlDayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleDtlDayProvider.Save(transactionManager, entity.ScScheduleDtlDayCollection);
						
						deepHandles.Add("ScScheduleDtlDayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleDtlDay >) DataRepository.ScScheduleDtlDayProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleDtlDayCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScDaySlot>
				if (CanDeepSave(entity.ScDaySlotCollection, "List<ScDaySlot>|ScDaySlotCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScDaySlot child in entity.ScDaySlotCollection)
					{
						if(child.GsCodeWeekDayIdSource != null)
						{
							child.GsCodeWeekDayId = child.GsCodeWeekDayIdSource.GsCodeWeekDayId;
						}
						else
						{
							child.GsCodeWeekDayId = entity.GsCodeWeekDayId;
						}

					}

					if (entity.ScDaySlotCollection.Count > 0 || entity.ScDaySlotCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScDaySlotProvider.Save(transactionManager, entity.ScDaySlotCollection);
						
						deepHandles.Add("ScDaySlotCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScDaySlot >) DataRepository.ScDaySlotProvider.DeepSave,
							new object[] { transactionManager, entity.ScDaySlotCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCodeWeekDayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeWeekDay</c>
	///</summary>
	public enum GsCodeWeekDayChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCodeWeekDay</c> as OneToMany for SaOfficeHourCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaOfficeHour>))]
		SaOfficeHourCollection,
		///<summary>
		/// Collection of <c>GsCodeWeekDay</c> as OneToMany for ScSchdlSlotCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSchdlSlot>))]
		ScSchdlSlotCollection,
		///<summary>
		/// Collection of <c>GsCodeWeekDay</c> as OneToMany for ScTchngDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScTchngDay>))]
		ScTchngDayCollection,
		///<summary>
		/// Collection of <c>GsCodeWeekDay</c> as OneToMany for EdStudAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAbsence>))]
		EdStudAbsenceCollection,
		///<summary>
		/// Collection of <c>GsCodeWeekDay</c> as OneToMany for AccomStudFeedReqDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudFeedReqDtl>))]
		AccomStudFeedReqDtlCollection,
		///<summary>
		/// Collection of <c>GsCodeWeekDay</c> as OneToMany for ScTchngSlotCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScTchngSlot>))]
		ScTchngSlotCollection,
		///<summary>
		/// Collection of <c>GsCodeWeekDay</c> as OneToMany for ScScheduleDtlDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleDtlDay>))]
		ScScheduleDtlDayCollection,
		///<summary>
		/// Collection of <c>GsCodeWeekDay</c> as OneToMany for ScDaySlotCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScDaySlot>))]
		ScDaySlotCollection,
	}
	
	#endregion GsCodeWeekDayChildEntityTypes
	
	#region GsCodeWeekDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeWeekDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeWeekDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeWeekDayFilterBuilder : SqlFilterBuilder<GsCodeWeekDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeWeekDayFilterBuilder class.
		/// </summary>
		public GsCodeWeekDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeWeekDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeWeekDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeWeekDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeWeekDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeWeekDayFilterBuilder
	
	#region GsCodeWeekDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeWeekDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeWeekDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeWeekDayParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeWeekDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeWeekDayParameterBuilder class.
		/// </summary>
		public GsCodeWeekDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeWeekDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeWeekDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeWeekDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeWeekDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeWeekDayParameterBuilder
	
	#region GsCodeWeekDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeWeekDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeWeekDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeWeekDaySortBuilder : SqlSortBuilder<GsCodeWeekDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeWeekDaySqlSortBuilder class.
		/// </summary>
		public GsCodeWeekDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeWeekDaySortBuilder
	
} // end namespace
