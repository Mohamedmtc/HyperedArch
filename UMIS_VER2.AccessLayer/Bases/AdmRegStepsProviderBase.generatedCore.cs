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
	/// This class is the base class for any <see cref="AdmRegStepsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmRegStepsProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmRegSteps, UMIS_VER2.BusinessLyer.AdmRegStepsKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRegStepsKey key)
		{
			return Delete(transactionManager, key.AdmRegStepsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admRegStepsId">Application Form Tabs. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admRegStepsId)
		{
			return Delete(null, _admRegStepsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRegStepsId">Application Form Tabs. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admRegStepsId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmRegSteps Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRegStepsKey key, int start, int pageLength)
		{
			return GetByAdmRegStepsId(transactionManager, key.AdmRegStepsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_REG_STEPS index.
		/// </summary>
		/// <param name="_admRegStepsId">Application Form Tabs</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRegSteps"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRegSteps GetByAdmRegStepsId(System.Decimal _admRegStepsId)
		{
			int count = -1;
			return GetByAdmRegStepsId(null,_admRegStepsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_REG_STEPS index.
		/// </summary>
		/// <param name="_admRegStepsId">Application Form Tabs</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRegSteps"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRegSteps GetByAdmRegStepsId(System.Decimal _admRegStepsId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmRegStepsId(null, _admRegStepsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_REG_STEPS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRegStepsId">Application Form Tabs</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRegSteps"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRegSteps GetByAdmRegStepsId(TransactionManager transactionManager, System.Decimal _admRegStepsId)
		{
			int count = -1;
			return GetByAdmRegStepsId(transactionManager, _admRegStepsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_REG_STEPS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRegStepsId">Application Form Tabs</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRegSteps"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRegSteps GetByAdmRegStepsId(TransactionManager transactionManager, System.Decimal _admRegStepsId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmRegStepsId(transactionManager, _admRegStepsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_REG_STEPS index.
		/// </summary>
		/// <param name="_admRegStepsId">Application Form Tabs</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRegSteps"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRegSteps GetByAdmRegStepsId(System.Decimal _admRegStepsId, int start, int pageLength, out int count)
		{
			return GetByAdmRegStepsId(null, _admRegStepsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_REG_STEPS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRegStepsId">Application Form Tabs</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRegSteps"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmRegSteps GetByAdmRegStepsId(TransactionManager transactionManager, System.Decimal _admRegStepsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmRegSteps&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmRegSteps&gt;"/></returns>
		public static TList<AdmRegSteps> Fill(IDataReader reader, TList<AdmRegSteps> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmRegSteps c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmRegSteps")
					.Append("|").Append((System.Decimal)reader["ADM_REG_STEPS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmRegSteps>(
					key.ToString(), // EntityTrackingKey
					"AdmRegSteps",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmRegSteps();
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
					c.AdmRegStepsId = (System.Decimal)reader["ADM_REG_STEPS_ID"];
					c.OriginalAdmRegStepsId = c.AdmRegStepsId;
					c.StepNo = Convert.IsDBNull(reader["STEP_NO"]) ? null : (System.Decimal?)reader["STEP_NO"];
					c.StepTitleAr = Convert.IsDBNull(reader["STEP_TITLE_AR"]) ? null : (System.String)reader["STEP_TITLE_AR"];
					c.StepTitleEn = Convert.IsDBNull(reader["STEP_TITLE_EN"]) ? null : (System.String)reader["STEP_TITLE_EN"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.ControlId = Convert.IsDBNull(reader["CONTROL_ID"]) ? null : (System.String)reader["CONTROL_ID"];
					c.EnumId = Convert.IsDBNull(reader["ENUM_ID"]) ? null : (System.Int32?)reader["ENUM_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmRegSteps"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmRegSteps"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmRegSteps entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmRegStepsId = (System.Decimal)reader[((int)AdmRegStepsColumn.AdmRegStepsId - 1)];
			entity.OriginalAdmRegStepsId = (System.Decimal)reader["ADM_REG_STEPS_ID"];
			entity.StepNo = (reader.IsDBNull(((int)AdmRegStepsColumn.StepNo - 1)))?null:(System.Decimal?)reader[((int)AdmRegStepsColumn.StepNo - 1)];
			entity.StepTitleAr = (reader.IsDBNull(((int)AdmRegStepsColumn.StepTitleAr - 1)))?null:(System.String)reader[((int)AdmRegStepsColumn.StepTitleAr - 1)];
			entity.StepTitleEn = (reader.IsDBNull(((int)AdmRegStepsColumn.StepTitleEn - 1)))?null:(System.String)reader[((int)AdmRegStepsColumn.StepTitleEn - 1)];
			entity.Notes = (reader.IsDBNull(((int)AdmRegStepsColumn.Notes - 1)))?null:(System.String)reader[((int)AdmRegStepsColumn.Notes - 1)];
			entity.ControlId = (reader.IsDBNull(((int)AdmRegStepsColumn.ControlId - 1)))?null:(System.String)reader[((int)AdmRegStepsColumn.ControlId - 1)];
			entity.EnumId = (reader.IsDBNull(((int)AdmRegStepsColumn.EnumId - 1)))?null:(System.Int32?)reader[((int)AdmRegStepsColumn.EnumId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmRegSteps"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmRegSteps"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmRegSteps entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmRegStepsId = (System.Decimal)dataRow["ADM_REG_STEPS_ID"];
			entity.OriginalAdmRegStepsId = (System.Decimal)dataRow["ADM_REG_STEPS_ID"];
			entity.StepNo = Convert.IsDBNull(dataRow["STEP_NO"]) ? null : (System.Decimal?)dataRow["STEP_NO"];
			entity.StepTitleAr = Convert.IsDBNull(dataRow["STEP_TITLE_AR"]) ? null : (System.String)dataRow["STEP_TITLE_AR"];
			entity.StepTitleEn = Convert.IsDBNull(dataRow["STEP_TITLE_EN"]) ? null : (System.String)dataRow["STEP_TITLE_EN"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.ControlId = Convert.IsDBNull(dataRow["CONTROL_ID"]) ? null : (System.String)dataRow["CONTROL_ID"];
			entity.EnumId = Convert.IsDBNull(dataRow["ENUM_ID"]) ? null : (System.Int32?)dataRow["ENUM_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmRegSteps"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmRegSteps Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRegSteps entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmRegStepsId methods when available
			
			#region EdCdeQualCatCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCdeQualCat>|EdCdeQualCatCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeQualCatCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCdeQualCatCollection = DataRepository.EdCdeQualCatProvider.GetByAdmRegStepsId(transactionManager, entity.AdmRegStepsId);

				if (deep && entity.EdCdeQualCatCollection.Count > 0)
				{
					deepHandles.Add("EdCdeQualCatCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCdeQualCat>) DataRepository.EdCdeQualCatProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCdeQualCatCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AppTypeRegStepsCollection = DataRepository.AppTypeRegStepsProvider.GetByAdmRegStepsId(transactionManager, entity.AdmRegStepsId);

				if (deep && entity.AppTypeRegStepsCollection.Count > 0)
				{
					deepHandles.Add("AppTypeRegStepsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AppTypeRegSteps>) DataRepository.AppTypeRegStepsProvider.DeepLoad,
						new object[] { transactionManager, entity.AppTypeRegStepsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmRegStepPayOnlineCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmRegStepPayOnline>|AdmRegStepPayOnlineCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmRegStepPayOnlineCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmRegStepPayOnlineCollection = DataRepository.AdmRegStepPayOnlineProvider.GetByAdmRegStepsId(transactionManager, entity.AdmRegStepsId);

				if (deep && entity.AdmRegStepPayOnlineCollection.Count > 0)
				{
					deepHandles.Add("AdmRegStepPayOnlineCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmRegStepPayOnline>) DataRepository.AdmRegStepPayOnlineProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmRegStepPayOnlineCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmRegSteps object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmRegSteps instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmRegSteps Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRegSteps entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdCdeQualCat>
				if (CanDeepSave(entity.EdCdeQualCatCollection, "List<EdCdeQualCat>|EdCdeQualCatCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCdeQualCat child in entity.EdCdeQualCatCollection)
					{
						if(child.AdmRegStepsIdSource != null)
						{
							child.AdmRegStepsId = child.AdmRegStepsIdSource.AdmRegStepsId;
						}
						else
						{
							child.AdmRegStepsId = entity.AdmRegStepsId;
						}

					}

					if (entity.EdCdeQualCatCollection.Count > 0 || entity.EdCdeQualCatCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCdeQualCatProvider.Save(transactionManager, entity.EdCdeQualCatCollection);
						
						deepHandles.Add("EdCdeQualCatCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCdeQualCat >) DataRepository.EdCdeQualCatProvider.DeepSave,
							new object[] { transactionManager, entity.EdCdeQualCatCollection, deepSaveType, childTypes, innerList }
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
						if(child.AdmRegStepsIdSource != null)
						{
							child.AdmRegStepsId = child.AdmRegStepsIdSource.AdmRegStepsId;
						}
						else
						{
							child.AdmRegStepsId = entity.AdmRegStepsId;
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
				
	
			#region List<AdmRegStepPayOnline>
				if (CanDeepSave(entity.AdmRegStepPayOnlineCollection, "List<AdmRegStepPayOnline>|AdmRegStepPayOnlineCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmRegStepPayOnline child in entity.AdmRegStepPayOnlineCollection)
					{
						if(child.AdmRegStepsIdSource != null)
						{
							child.AdmRegStepsId = child.AdmRegStepsIdSource.AdmRegStepsId;
						}
						else
						{
							child.AdmRegStepsId = entity.AdmRegStepsId;
						}

					}

					if (entity.AdmRegStepPayOnlineCollection.Count > 0 || entity.AdmRegStepPayOnlineCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmRegStepPayOnlineProvider.Save(transactionManager, entity.AdmRegStepPayOnlineCollection);
						
						deepHandles.Add("AdmRegStepPayOnlineCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmRegStepPayOnline >) DataRepository.AdmRegStepPayOnlineProvider.DeepSave,
							new object[] { transactionManager, entity.AdmRegStepPayOnlineCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmRegStepsChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmRegSteps</c>
	///</summary>
	public enum AdmRegStepsChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AdmRegSteps</c> as OneToMany for EdCdeQualCatCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCdeQualCat>))]
		EdCdeQualCatCollection,
		///<summary>
		/// Collection of <c>AdmRegSteps</c> as OneToMany for AppTypeRegStepsCollection
		///</summary>
		[ChildEntityType(typeof(TList<AppTypeRegSteps>))]
		AppTypeRegStepsCollection,
		///<summary>
		/// Collection of <c>AdmRegSteps</c> as OneToMany for AdmRegStepPayOnlineCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmRegStepPayOnline>))]
		AdmRegStepPayOnlineCollection,
	}
	
	#endregion AdmRegStepsChildEntityTypes
	
	#region AdmRegStepsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmRegStepsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmRegSteps"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmRegStepsFilterBuilder : SqlFilterBuilder<AdmRegStepsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmRegStepsFilterBuilder class.
		/// </summary>
		public AdmRegStepsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmRegStepsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmRegStepsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmRegStepsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmRegStepsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmRegStepsFilterBuilder
	
	#region AdmRegStepsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmRegStepsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmRegSteps"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmRegStepsParameterBuilder : ParameterizedSqlFilterBuilder<AdmRegStepsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmRegStepsParameterBuilder class.
		/// </summary>
		public AdmRegStepsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmRegStepsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmRegStepsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmRegStepsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmRegStepsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmRegStepsParameterBuilder
	
	#region AdmRegStepsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmRegStepsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmRegSteps"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmRegStepsSortBuilder : SqlSortBuilder<AdmRegStepsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmRegStepsSqlSortBuilder class.
		/// </summary>
		public AdmRegStepsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmRegStepsSortBuilder
	
} // end namespace
