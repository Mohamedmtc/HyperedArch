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
	/// This class is the base class for any <see cref="AdmCdeAppTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmCdeAppTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmCdeAppType, UMIS_VER2.BusinessLyer.AdmCdeAppTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeAppTypeKey key)
		{
			return Delete(transactionManager, key.AdmCdeAppTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admCdeAppTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admCdeAppTypeId)
		{
			return Delete(null, _admCdeAppTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admCdeAppTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmCdeAppType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeAppTypeKey key, int start, int pageLength)
		{
			return GetByAdmCdeAppTypeId(transactionManager, key.AdmCdeAppTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_CDE_APP_TYPE index.
		/// </summary>
		/// <param name="_admCdeAppTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeAppType GetByAdmCdeAppTypeId(System.Decimal _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(null,_admCdeAppTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_APP_TYPE index.
		/// </summary>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeAppType GetByAdmCdeAppTypeId(System.Decimal _admCdeAppTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(null, _admCdeAppTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_APP_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeAppType GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(transactionManager, _admCdeAppTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_APP_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeAppType GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal _admCdeAppTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(transactionManager, _admCdeAppTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_APP_TYPE index.
		/// </summary>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeAppType GetByAdmCdeAppTypeId(System.Decimal _admCdeAppTypeId, int start, int pageLength, out int count)
		{
			return GetByAdmCdeAppTypeId(null, _admCdeAppTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_APP_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCdeAppType GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal _admCdeAppTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmCdeAppType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmCdeAppType&gt;"/></returns>
		public static TList<AdmCdeAppType> Fill(IDataReader reader, TList<AdmCdeAppType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmCdeAppType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmCdeAppType")
					.Append("|").Append((System.Decimal)reader["ADM_CDE_APP_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmCdeAppType>(
					key.ToString(), // EntityTrackingKey
					"AdmCdeAppType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmCdeAppType();
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
					c.AdmCdeAppTypeId = (System.Decimal)reader["ADM_CDE_APP_TYPE_ID"];
					c.OriginalAdmCdeAppTypeId = c.AdmCdeAppTypeId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmCdeAppType entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmCdeAppTypeId = (System.Decimal)reader[((int)AdmCdeAppTypeColumn.AdmCdeAppTypeId - 1)];
			entity.OriginalAdmCdeAppTypeId = (System.Decimal)reader["ADM_CDE_APP_TYPE_ID"];
			entity.DescrAr = (System.String)reader[((int)AdmCdeAppTypeColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)AdmCdeAppTypeColumn.DescrEn - 1)))?null:(System.String)reader[((int)AdmCdeAppTypeColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmCdeAppType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmCdeAppTypeId = (System.Decimal)dataRow["ADM_CDE_APP_TYPE_ID"];
			entity.OriginalAdmCdeAppTypeId = (System.Decimal)dataRow["ADM_CDE_APP_TYPE_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeAppType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeAppType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmCdeAppTypeId methods when available
			
			#region AdmRatingParametersMajorsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmRatingParametersMajors>|AdmRatingParametersMajorsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmRatingParametersMajorsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmRatingParametersMajorsCollection = DataRepository.AdmRatingParametersMajorsProvider.GetByAdmCdeAppTypeId(transactionManager, entity.AdmCdeAppTypeId);

				if (deep && entity.AdmRatingParametersMajorsCollection.Count > 0)
				{
					deepHandles.Add("AdmRatingParametersMajorsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmRatingParametersMajors>) DataRepository.AdmRatingParametersMajorsProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmRatingParametersMajorsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmReqDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmReqDoc>|AdmReqDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmReqDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmReqDocCollection = DataRepository.AdmReqDocProvider.GetByAdmCdeAppTypeId(transactionManager, entity.AdmCdeAppTypeId);

				if (deep && entity.AdmReqDocCollection.Count > 0)
				{
					deepHandles.Add("AdmReqDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmReqDoc>) DataRepository.AdmReqDocProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmReqDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeAllowanceRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeAllowanceRule>|FeeAllowanceRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeAllowanceRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeAllowanceRuleCollection = DataRepository.FeeAllowanceRuleProvider.GetByAdmCdeAppTypeId(transactionManager, entity.AdmCdeAppTypeId);

				if (deep && entity.FeeAllowanceRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeAllowanceRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeAllowanceRule>) DataRepository.FeeAllowanceRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeAllowanceRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AppTypeRegStepsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AppTypeRegSteps>|AppTypeRegStepsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AppTypeRegStepsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AppTypeRegStepsCollection = DataRepository.AppTypeRegStepsProvider.GetByAdmCdeAppTypeId(transactionManager, entity.AdmCdeAppTypeId);

				if (deep && entity.AppTypeRegStepsCollection.Count > 0)
				{
					deepHandles.Add("AppTypeRegStepsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AppTypeRegSteps>) DataRepository.AppTypeRegStepsProvider.DeepLoad,
						new object[] { transactionManager, entity.AppTypeRegStepsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmPlaceExamDatetimeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPlaceExamDatetime>|AdmPlaceExamDatetimeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPlaceExamDatetimeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPlaceExamDatetimeCollection = DataRepository.AdmPlaceExamDatetimeProvider.GetByAdmCdeAppTypeId(transactionManager, entity.AdmCdeAppTypeId);

				if (deep && entity.AdmPlaceExamDatetimeCollection.Count > 0)
				{
					deepHandles.Add("AdmPlaceExamDatetimeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPlaceExamDatetime>) DataRepository.AdmPlaceExamDatetimeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPlaceExamDatetimeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppRegHistoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppRegHistoryCollection = DataRepository.AdmAppRegHistoryProvider.GetByAdmCdeAppTypeId(transactionManager, entity.AdmCdeAppTypeId);

				if (deep && entity.AdmAppRegHistoryCollection.Count > 0)
				{
					deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppRegHistory>) DataRepository.AdmAppRegHistoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudFacultyCollection = DataRepository.EdStudFacultyProvider.GetByAdmCdeAppTypeId(transactionManager, entity.AdmCdeAppTypeId);

				if (deep && entity.EdStudFacultyCollection.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmRatingParamMajorTypeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmRatingParamMajorType>|AdmRatingParamMajorTypeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmRatingParamMajorTypeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmRatingParamMajorTypeCollection = DataRepository.AdmRatingParamMajorTypeProvider.GetByAdmCdeAppTypeId(transactionManager, entity.AdmCdeAppTypeId);

				if (deep && entity.AdmRatingParamMajorTypeCollection.Count > 0)
				{
					deepHandles.Add("AdmRatingParamMajorTypeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmRatingParamMajorType>) DataRepository.AdmRatingParamMajorTypeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmRatingParamMajorTypeCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmCdeAppType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmCdeAppType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeAppType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeAppType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AdmRatingParametersMajors>
				if (CanDeepSave(entity.AdmRatingParametersMajorsCollection, "List<AdmRatingParametersMajors>|AdmRatingParametersMajorsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmRatingParametersMajors child in entity.AdmRatingParametersMajorsCollection)
					{
						if(child.AdmCdeAppTypeIdSource != null)
						{
							child.AdmCdeAppTypeId = child.AdmCdeAppTypeIdSource.AdmCdeAppTypeId;
						}
						else
						{
							child.AdmCdeAppTypeId = entity.AdmCdeAppTypeId;
						}

					}

					if (entity.AdmRatingParametersMajorsCollection.Count > 0 || entity.AdmRatingParametersMajorsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmRatingParametersMajorsProvider.Save(transactionManager, entity.AdmRatingParametersMajorsCollection);
						
						deepHandles.Add("AdmRatingParametersMajorsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmRatingParametersMajors >) DataRepository.AdmRatingParametersMajorsProvider.DeepSave,
							new object[] { transactionManager, entity.AdmRatingParametersMajorsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmReqDoc>
				if (CanDeepSave(entity.AdmReqDocCollection, "List<AdmReqDoc>|AdmReqDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmReqDoc child in entity.AdmReqDocCollection)
					{
						if(child.AdmCdeAppTypeIdSource != null)
						{
							child.AdmCdeAppTypeId = child.AdmCdeAppTypeIdSource.AdmCdeAppTypeId;
						}
						else
						{
							child.AdmCdeAppTypeId = entity.AdmCdeAppTypeId;
						}

					}

					if (entity.AdmReqDocCollection.Count > 0 || entity.AdmReqDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmReqDocProvider.Save(transactionManager, entity.AdmReqDocCollection);
						
						deepHandles.Add("AdmReqDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmReqDoc >) DataRepository.AdmReqDocProvider.DeepSave,
							new object[] { transactionManager, entity.AdmReqDocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeAllowanceRule>
				if (CanDeepSave(entity.FeeAllowanceRuleCollection, "List<FeeAllowanceRule>|FeeAllowanceRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeAllowanceRule child in entity.FeeAllowanceRuleCollection)
					{
						if(child.AdmCdeAppTypeIdSource != null)
						{
							child.AdmCdeAppTypeId = child.AdmCdeAppTypeIdSource.AdmCdeAppTypeId;
						}
						else
						{
							child.AdmCdeAppTypeId = entity.AdmCdeAppTypeId;
						}

					}

					if (entity.FeeAllowanceRuleCollection.Count > 0 || entity.FeeAllowanceRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeAllowanceRuleProvider.Save(transactionManager, entity.FeeAllowanceRuleCollection);
						
						deepHandles.Add("FeeAllowanceRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeAllowanceRule >) DataRepository.FeeAllowanceRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeAllowanceRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AppTypeRegSteps>
				if (CanDeepSave(entity.AppTypeRegStepsCollection, "List<AppTypeRegSteps>|AppTypeRegStepsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AppTypeRegSteps child in entity.AppTypeRegStepsCollection)
					{
						if(child.AdmCdeAppTypeIdSource != null)
						{
							child.AdmCdeAppTypeId = child.AdmCdeAppTypeIdSource.AdmCdeAppTypeId;
						}
						else
						{
							child.AdmCdeAppTypeId = entity.AdmCdeAppTypeId;
						}

					}

					if (entity.AppTypeRegStepsCollection.Count > 0 || entity.AppTypeRegStepsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AppTypeRegStepsProvider.Save(transactionManager, entity.AppTypeRegStepsCollection);
						
						deepHandles.Add("AppTypeRegStepsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AppTypeRegSteps >) DataRepository.AppTypeRegStepsProvider.DeepSave,
							new object[] { transactionManager, entity.AppTypeRegStepsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmPlaceExamDatetime>
				if (CanDeepSave(entity.AdmPlaceExamDatetimeCollection, "List<AdmPlaceExamDatetime>|AdmPlaceExamDatetimeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPlaceExamDatetime child in entity.AdmPlaceExamDatetimeCollection)
					{
						if(child.AdmCdeAppTypeIdSource != null)
						{
							child.AdmCdeAppTypeId = child.AdmCdeAppTypeIdSource.AdmCdeAppTypeId;
						}
						else
						{
							child.AdmCdeAppTypeId = entity.AdmCdeAppTypeId;
						}

					}

					if (entity.AdmPlaceExamDatetimeCollection.Count > 0 || entity.AdmPlaceExamDatetimeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmPlaceExamDatetimeProvider.Save(transactionManager, entity.AdmPlaceExamDatetimeCollection);
						
						deepHandles.Add("AdmPlaceExamDatetimeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmPlaceExamDatetime >) DataRepository.AdmPlaceExamDatetimeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmPlaceExamDatetimeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppRegHistory>
				if (CanDeepSave(entity.AdmAppRegHistoryCollection, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppRegHistory child in entity.AdmAppRegHistoryCollection)
					{
						if(child.AdmCdeAppTypeIdSource != null)
						{
							child.AdmCdeAppTypeId = child.AdmCdeAppTypeIdSource.AdmCdeAppTypeId;
						}
						else
						{
							child.AdmCdeAppTypeId = entity.AdmCdeAppTypeId;
						}

					}

					if (entity.AdmAppRegHistoryCollection.Count > 0 || entity.AdmAppRegHistoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryCollection);
						
						deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppRegHistory >) DataRepository.AdmAppRegHistoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deepSaveType, childTypes, innerList }
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
						if(child.AdmCdeAppTypeIdSource != null)
						{
							child.AdmCdeAppTypeId = child.AdmCdeAppTypeIdSource.AdmCdeAppTypeId;
						}
						else
						{
							child.AdmCdeAppTypeId = entity.AdmCdeAppTypeId;
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
				
	
			#region List<AdmRatingParamMajorType>
				if (CanDeepSave(entity.AdmRatingParamMajorTypeCollection, "List<AdmRatingParamMajorType>|AdmRatingParamMajorTypeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmRatingParamMajorType child in entity.AdmRatingParamMajorTypeCollection)
					{
						if(child.AdmCdeAppTypeIdSource != null)
						{
							child.AdmCdeAppTypeId = child.AdmCdeAppTypeIdSource.AdmCdeAppTypeId;
						}
						else
						{
							child.AdmCdeAppTypeId = entity.AdmCdeAppTypeId;
						}

					}

					if (entity.AdmRatingParamMajorTypeCollection.Count > 0 || entity.AdmRatingParamMajorTypeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmRatingParamMajorTypeProvider.Save(transactionManager, entity.AdmRatingParamMajorTypeCollection);
						
						deepHandles.Add("AdmRatingParamMajorTypeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmRatingParamMajorType >) DataRepository.AdmRatingParamMajorTypeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmRatingParamMajorTypeCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmCdeAppTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmCdeAppType</c>
	///</summary>
	public enum AdmCdeAppTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AdmCdeAppType</c> as OneToMany for AdmRatingParametersMajorsCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmRatingParametersMajors>))]
		AdmRatingParametersMajorsCollection,
		///<summary>
		/// Collection of <c>AdmCdeAppType</c> as OneToMany for AdmReqDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmReqDoc>))]
		AdmReqDocCollection,
		///<summary>
		/// Collection of <c>AdmCdeAppType</c> as OneToMany for FeeAllowanceRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeAllowanceRule>))]
		FeeAllowanceRuleCollection,
		///<summary>
		/// Collection of <c>AdmCdeAppType</c> as OneToMany for AppTypeRegStepsCollection
		///</summary>
		[ChildEntityType(typeof(TList<AppTypeRegSteps>))]
		AppTypeRegStepsCollection,
		///<summary>
		/// Collection of <c>AdmCdeAppType</c> as OneToMany for AdmPlaceExamDatetimeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPlaceExamDatetime>))]
		AdmPlaceExamDatetimeCollection,
		///<summary>
		/// Collection of <c>AdmCdeAppType</c> as OneToMany for AdmAppRegHistoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppRegHistory>))]
		AdmAppRegHistoryCollection,
		///<summary>
		/// Collection of <c>AdmCdeAppType</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollection,
		///<summary>
		/// Collection of <c>AdmCdeAppType</c> as OneToMany for AdmRatingParamMajorTypeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmRatingParamMajorType>))]
		AdmRatingParamMajorTypeCollection,
	}
	
	#endregion AdmCdeAppTypeChildEntityTypes
	
	#region AdmCdeAppTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmCdeAppTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeAppType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeAppTypeFilterBuilder : SqlFilterBuilder<AdmCdeAppTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeAppTypeFilterBuilder class.
		/// </summary>
		public AdmCdeAppTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeAppTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeAppTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeAppTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeAppTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeAppTypeFilterBuilder
	
	#region AdmCdeAppTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmCdeAppTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeAppType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeAppTypeParameterBuilder : ParameterizedSqlFilterBuilder<AdmCdeAppTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeAppTypeParameterBuilder class.
		/// </summary>
		public AdmCdeAppTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeAppTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeAppTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeAppTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeAppTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeAppTypeParameterBuilder
	
	#region AdmCdeAppTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmCdeAppTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeAppType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmCdeAppTypeSortBuilder : SqlSortBuilder<AdmCdeAppTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeAppTypeSqlSortBuilder class.
		/// </summary>
		public AdmCdeAppTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmCdeAppTypeSortBuilder
	
} // end namespace
