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
	/// This class is the base class for any <see cref="EdCdeAcadWarnTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeAcadWarnTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCdeAcadWarnType, UMIS_VER2.BusinessLyer.EdCdeAcadWarnTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeAcadWarnTypeKey key)
		{
			return Delete(transactionManager, key.EdCdeAcadWarnTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCdeAcadWarnTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCdeAcadWarnTypeId)
		{
			return Delete(null, _edCdeAcadWarnTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeAcadWarnTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCdeAcadWarnTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCdeAcadWarnType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeAcadWarnTypeKey key, int start, int pageLength)
		{
			return GetByEdCdeAcadWarnTypeId(transactionManager, key.EdCdeAcadWarnTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CDE_ACAD_WARN_TYPE index.
		/// </summary>
		/// <param name="_edCdeAcadWarnTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeAcadWarnType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeAcadWarnType GetByEdCdeAcadWarnTypeId(System.Decimal _edCdeAcadWarnTypeId)
		{
			int count = -1;
			return GetByEdCdeAcadWarnTypeId(null,_edCdeAcadWarnTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_ACAD_WARN_TYPE index.
		/// </summary>
		/// <param name="_edCdeAcadWarnTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeAcadWarnType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeAcadWarnType GetByEdCdeAcadWarnTypeId(System.Decimal _edCdeAcadWarnTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeAcadWarnTypeId(null, _edCdeAcadWarnTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_ACAD_WARN_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeAcadWarnTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeAcadWarnType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeAcadWarnType GetByEdCdeAcadWarnTypeId(TransactionManager transactionManager, System.Decimal _edCdeAcadWarnTypeId)
		{
			int count = -1;
			return GetByEdCdeAcadWarnTypeId(transactionManager, _edCdeAcadWarnTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_ACAD_WARN_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeAcadWarnTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeAcadWarnType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeAcadWarnType GetByEdCdeAcadWarnTypeId(TransactionManager transactionManager, System.Decimal _edCdeAcadWarnTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeAcadWarnTypeId(transactionManager, _edCdeAcadWarnTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_ACAD_WARN_TYPE index.
		/// </summary>
		/// <param name="_edCdeAcadWarnTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeAcadWarnType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeAcadWarnType GetByEdCdeAcadWarnTypeId(System.Decimal _edCdeAcadWarnTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCdeAcadWarnTypeId(null, _edCdeAcadWarnTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_ACAD_WARN_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeAcadWarnTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeAcadWarnType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeAcadWarnType GetByEdCdeAcadWarnTypeId(TransactionManager transactionManager, System.Decimal _edCdeAcadWarnTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCdeAcadWarnType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCdeAcadWarnType&gt;"/></returns>
		public static TList<EdCdeAcadWarnType> Fill(IDataReader reader, TList<EdCdeAcadWarnType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCdeAcadWarnType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCdeAcadWarnType")
					.Append("|").Append((System.Decimal)reader["ED_CDE_ACAD_WARN_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCdeAcadWarnType>(
					key.ToString(), // EntityTrackingKey
					"EdCdeAcadWarnType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCdeAcadWarnType();
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
					c.EdCdeAcadWarnTypeId = (System.Decimal)reader["ED_CDE_ACAD_WARN_TYPE_ID"];
					c.OriginalEdCdeAcadWarnTypeId = c.EdCdeAcadWarnTypeId;
					c.AcadWarnCode = (System.String)reader["ACAD_WARN_CODE"];
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.AcadWarnOrder = (System.Decimal)reader["ACAD_WARN_ORDER"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeAcadWarnType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeAcadWarnType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCdeAcadWarnType entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCdeAcadWarnTypeId = (System.Decimal)reader[((int)EdCdeAcadWarnTypeColumn.EdCdeAcadWarnTypeId - 1)];
			entity.OriginalEdCdeAcadWarnTypeId = (System.Decimal)reader["ED_CDE_ACAD_WARN_TYPE_ID"];
			entity.AcadWarnCode = (System.String)reader[((int)EdCdeAcadWarnTypeColumn.AcadWarnCode - 1)];
			entity.DescrAr = (System.String)reader[((int)EdCdeAcadWarnTypeColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)EdCdeAcadWarnTypeColumn.DescrEn - 1)];
			entity.AcadWarnOrder = (System.Decimal)reader[((int)EdCdeAcadWarnTypeColumn.AcadWarnOrder - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeAcadWarnType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeAcadWarnType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCdeAcadWarnType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCdeAcadWarnTypeId = (System.Decimal)dataRow["ED_CDE_ACAD_WARN_TYPE_ID"];
			entity.OriginalEdCdeAcadWarnTypeId = (System.Decimal)dataRow["ED_CDE_ACAD_WARN_TYPE_ID"];
			entity.AcadWarnCode = (System.String)dataRow["ACAD_WARN_CODE"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.AcadWarnOrder = (System.Decimal)dataRow["ACAD_WARN_ORDER"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeAcadWarnType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeAcadWarnType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeAcadWarnType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCdeAcadWarnTypeId methods when available
			
			#region EntPlcyAcadWarnDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPlcyAcadWarnDtl>|EntPlcyAcadWarnDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPlcyAcadWarnDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPlcyAcadWarnDtlCollection = DataRepository.EntPlcyAcadWarnDtlProvider.GetByEdCdeAcadWarnTypeId(transactionManager, entity.EdCdeAcadWarnTypeId);

				if (deep && entity.EntPlcyAcadWarnDtlCollection.Count > 0)
				{
					deepHandles.Add("EntPlcyAcadWarnDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPlcyAcadWarnDtl>) DataRepository.EntPlcyAcadWarnDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPlcyAcadWarnDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterTempCollection = DataRepository.EdStudSemesterTempProvider.GetByEdCdeAcadWarnTypeId(transactionManager, entity.EdCdeAcadWarnTypeId);

				if (deep && entity.EdStudSemesterTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemesterTemp>) DataRepository.EdStudSemesterTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemester>|EdStudSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterCollection = DataRepository.EdStudSemesterProvider.GetByEdCdeAcadWarnTypeId(transactionManager, entity.EdCdeAcadWarnTypeId);

				if (deep && entity.EdStudSemesterCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemester>) DataRepository.EdStudSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCdeAcadWarnType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCdeAcadWarnType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeAcadWarnType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeAcadWarnType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EntPlcyAcadWarnDtl>
				if (CanDeepSave(entity.EntPlcyAcadWarnDtlCollection, "List<EntPlcyAcadWarnDtl>|EntPlcyAcadWarnDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPlcyAcadWarnDtl child in entity.EntPlcyAcadWarnDtlCollection)
					{
						if(child.EdCdeAcadWarnTypeIdSource != null)
						{
							child.EdCdeAcadWarnTypeId = child.EdCdeAcadWarnTypeIdSource.EdCdeAcadWarnTypeId;
						}
						else
						{
							child.EdCdeAcadWarnTypeId = entity.EdCdeAcadWarnTypeId;
						}

					}

					if (entity.EntPlcyAcadWarnDtlCollection.Count > 0 || entity.EntPlcyAcadWarnDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPlcyAcadWarnDtlProvider.Save(transactionManager, entity.EntPlcyAcadWarnDtlCollection);
						
						deepHandles.Add("EntPlcyAcadWarnDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPlcyAcadWarnDtl >) DataRepository.EntPlcyAcadWarnDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EntPlcyAcadWarnDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemesterTemp>
				if (CanDeepSave(entity.EdStudSemesterTempCollection, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemesterTemp child in entity.EdStudSemesterTempCollection)
					{
						if(child.EdCdeAcadWarnTypeIdSource != null)
						{
							child.EdCdeAcadWarnTypeId = child.EdCdeAcadWarnTypeIdSource.EdCdeAcadWarnTypeId;
						}
						else
						{
							child.EdCdeAcadWarnTypeId = entity.EdCdeAcadWarnTypeId;
						}

					}

					if (entity.EdStudSemesterTempCollection.Count > 0 || entity.EdStudSemesterTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterTempProvider.Save(transactionManager, entity.EdStudSemesterTempCollection);
						
						deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemesterTemp >) DataRepository.EdStudSemesterTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemester>
				if (CanDeepSave(entity.EdStudSemesterCollection, "List<EdStudSemester>|EdStudSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemester child in entity.EdStudSemesterCollection)
					{
						if(child.EdCdeAcadWarnTypeIdSource != null)
						{
							child.EdCdeAcadWarnTypeId = child.EdCdeAcadWarnTypeIdSource.EdCdeAcadWarnTypeId;
						}
						else
						{
							child.EdCdeAcadWarnTypeId = entity.EdCdeAcadWarnTypeId;
						}

					}

					if (entity.EdStudSemesterCollection.Count > 0 || entity.EdStudSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterCollection);
						
						deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemester >) DataRepository.EdStudSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCdeAcadWarnTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCdeAcadWarnType</c>
	///</summary>
	public enum EdCdeAcadWarnTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCdeAcadWarnType</c> as OneToMany for EntPlcyAcadWarnDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPlcyAcadWarnDtl>))]
		EntPlcyAcadWarnDtlCollection,
		///<summary>
		/// Collection of <c>EdCdeAcadWarnType</c> as OneToMany for EdStudSemesterTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemesterTemp>))]
		EdStudSemesterTempCollection,
		///<summary>
		/// Collection of <c>EdCdeAcadWarnType</c> as OneToMany for EdStudSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemester>))]
		EdStudSemesterCollection,
	}
	
	#endregion EdCdeAcadWarnTypeChildEntityTypes
	
	#region EdCdeAcadWarnTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCdeAcadWarnTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeAcadWarnType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeAcadWarnTypeFilterBuilder : SqlFilterBuilder<EdCdeAcadWarnTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeAcadWarnTypeFilterBuilder class.
		/// </summary>
		public EdCdeAcadWarnTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeAcadWarnTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeAcadWarnTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeAcadWarnTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeAcadWarnTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeAcadWarnTypeFilterBuilder
	
	#region EdCdeAcadWarnTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCdeAcadWarnTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeAcadWarnType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeAcadWarnTypeParameterBuilder : ParameterizedSqlFilterBuilder<EdCdeAcadWarnTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeAcadWarnTypeParameterBuilder class.
		/// </summary>
		public EdCdeAcadWarnTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeAcadWarnTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeAcadWarnTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeAcadWarnTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeAcadWarnTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeAcadWarnTypeParameterBuilder
	
	#region EdCdeAcadWarnTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCdeAcadWarnTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeAcadWarnType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCdeAcadWarnTypeSortBuilder : SqlSortBuilder<EdCdeAcadWarnTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeAcadWarnTypeSqlSortBuilder class.
		/// </summary>
		public EdCdeAcadWarnTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCdeAcadWarnTypeSortBuilder
	
} // end namespace
