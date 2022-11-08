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
	/// This class is the base class for any <see cref="SvCodeRatingSchmProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvCodeRatingSchmProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvCodeRatingSchm, UMIS_VER2.BusinessLyer.SvCodeRatingSchmKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCodeRatingSchmKey key)
		{
			return Delete(transactionManager, key.SvCodeRatingSchmId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svCodeRatingSchmId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svCodeRatingSchmId)
		{
			return Delete(null, _svCodeRatingSchmId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmId);		
		
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
		public override UMIS_VER2.BusinessLyer.SvCodeRatingSchm Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCodeRatingSchmKey key, int start, int pageLength)
		{
			return GetBySvCodeRatingSchmId(transactionManager, key.SvCodeRatingSchmId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_CODE_RATING_SCHM index.
		/// </summary>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeRatingSchm GetBySvCodeRatingSchmId(System.Decimal _svCodeRatingSchmId)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(null,_svCodeRatingSchmId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CODE_RATING_SCHM index.
		/// </summary>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeRatingSchm GetBySvCodeRatingSchmId(System.Decimal _svCodeRatingSchmId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(null, _svCodeRatingSchmId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CODE_RATING_SCHM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeRatingSchm GetBySvCodeRatingSchmId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmId)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(transactionManager, _svCodeRatingSchmId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CODE_RATING_SCHM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeRatingSchm GetBySvCodeRatingSchmId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(transactionManager, _svCodeRatingSchmId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CODE_RATING_SCHM index.
		/// </summary>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeRatingSchm GetBySvCodeRatingSchmId(System.Decimal _svCodeRatingSchmId, int start, int pageLength, out int count)
		{
			return GetBySvCodeRatingSchmId(null, _svCodeRatingSchmId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CODE_RATING_SCHM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchm"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCodeRatingSchm GetBySvCodeRatingSchmId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvCodeRatingSchm&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvCodeRatingSchm&gt;"/></returns>
		public static TList<SvCodeRatingSchm> Fill(IDataReader reader, TList<SvCodeRatingSchm> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvCodeRatingSchm c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvCodeRatingSchm")
					.Append("|").Append((System.Decimal)reader["SV_CODE_RATING_SCHM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvCodeRatingSchm>(
					key.ToString(), // EntityTrackingKey
					"SvCodeRatingSchm",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvCodeRatingSchm();
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
					c.SvCodeRatingSchmId = (System.Decimal)reader["SV_CODE_RATING_SCHM_ID"];
					c.OriginalSvCodeRatingSchmId = c.SvCodeRatingSchmId;
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchm"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchm"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvCodeRatingSchm entity)
		{
			if (!reader.Read()) return;
			
			entity.SvCodeRatingSchmId = (System.Decimal)reader[((int)SvCodeRatingSchmColumn.SvCodeRatingSchmId - 1)];
			entity.OriginalSvCodeRatingSchmId = (System.Decimal)reader["SV_CODE_RATING_SCHM_ID"];
			entity.DescrEn = (System.String)reader[((int)SvCodeRatingSchmColumn.DescrEn - 1)];
			entity.DescrAr = (System.String)reader[((int)SvCodeRatingSchmColumn.DescrAr - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchm"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchm"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvCodeRatingSchm entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvCodeRatingSchmId = (System.Decimal)dataRow["SV_CODE_RATING_SCHM_ID"];
			entity.OriginalSvCodeRatingSchmId = (System.Decimal)dataRow["SV_CODE_RATING_SCHM_ID"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchm"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCodeRatingSchm Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCodeRatingSchm entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvCodeRatingSchmId methods when available
			
			#region SvStaffEvlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStaffEvl>|SvStaffEvlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffEvlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStaffEvlCollection = DataRepository.SvStaffEvlProvider.GetBySvCodeRatingSchmId(transactionManager, entity.SvCodeRatingSchmId);

				if (deep && entity.SvStaffEvlCollection.Count > 0)
				{
					deepHandles.Add("SvStaffEvlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStaffEvl>) DataRepository.SvStaffEvlProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStaffEvlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvCourseEvalItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvCourseEvalItem>|SvCourseEvalItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCourseEvalItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvCourseEvalItemCollection = DataRepository.SvCourseEvalItemProvider.GetBySvCodeRatingSchmId(transactionManager, entity.SvCodeRatingSchmId);

				if (deep && entity.SvCourseEvalItemCollection.Count > 0)
				{
					deepHandles.Add("SvCourseEvalItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvCourseEvalItem>) DataRepository.SvCourseEvalItemProvider.DeepLoad,
						new object[] { transactionManager, entity.SvCourseEvalItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStaffEvalItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStaffEvalItem>|SvStaffEvalItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffEvalItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStaffEvalItemCollection = DataRepository.SvStaffEvalItemProvider.GetBySvCodeRatingSchmId(transactionManager, entity.SvCodeRatingSchmId);

				if (deep && entity.SvStaffEvalItemCollection.Count > 0)
				{
					deepHandles.Add("SvStaffEvalItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStaffEvalItem>) DataRepository.SvStaffEvalItemProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStaffEvalItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvCourseEvalCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvCourseEval>|SvCourseEvalCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCourseEvalCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvCourseEvalCollection = DataRepository.SvCourseEvalProvider.GetBySvCodeRatingSchmId(transactionManager, entity.SvCodeRatingSchmId);

				if (deep && entity.SvCourseEvalCollection.Count > 0)
				{
					deepHandles.Add("SvCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvCourseEval>) DataRepository.SvCourseEvalProvider.DeepLoad,
						new object[] { transactionManager, entity.SvCourseEvalCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvCodeRatingSchmDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvCodeRatingSchmDtl>|SvCodeRatingSchmDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCodeRatingSchmDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvCodeRatingSchmDtlCollection = DataRepository.SvCodeRatingSchmDtlProvider.GetBySvCodeRatingSchmId(transactionManager, entity.SvCodeRatingSchmId);

				if (deep && entity.SvCodeRatingSchmDtlCollection.Count > 0)
				{
					deepHandles.Add("SvCodeRatingSchmDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvCodeRatingSchmDtl>) DataRepository.SvCodeRatingSchmDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.SvCodeRatingSchmDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvCodeRatingSchm object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvCodeRatingSchm instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCodeRatingSchm Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCodeRatingSchm entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SvStaffEvl>
				if (CanDeepSave(entity.SvStaffEvlCollection, "List<SvStaffEvl>|SvStaffEvlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStaffEvl child in entity.SvStaffEvlCollection)
					{
						if(child.SvCodeRatingSchmIdSource != null)
						{
							child.SvCodeRatingSchmId = child.SvCodeRatingSchmIdSource.SvCodeRatingSchmId;
						}
						else
						{
							child.SvCodeRatingSchmId = entity.SvCodeRatingSchmId;
						}

					}

					if (entity.SvStaffEvlCollection.Count > 0 || entity.SvStaffEvlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStaffEvlProvider.Save(transactionManager, entity.SvStaffEvlCollection);
						
						deepHandles.Add("SvStaffEvlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStaffEvl >) DataRepository.SvStaffEvlProvider.DeepSave,
							new object[] { transactionManager, entity.SvStaffEvlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvCourseEvalItem>
				if (CanDeepSave(entity.SvCourseEvalItemCollection, "List<SvCourseEvalItem>|SvCourseEvalItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvCourseEvalItem child in entity.SvCourseEvalItemCollection)
					{
						if(child.SvCodeRatingSchmIdSource != null)
						{
							child.SvCodeRatingSchmId = child.SvCodeRatingSchmIdSource.SvCodeRatingSchmId;
						}
						else
						{
							child.SvCodeRatingSchmId = entity.SvCodeRatingSchmId;
						}

					}

					if (entity.SvCourseEvalItemCollection.Count > 0 || entity.SvCourseEvalItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvCourseEvalItemProvider.Save(transactionManager, entity.SvCourseEvalItemCollection);
						
						deepHandles.Add("SvCourseEvalItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvCourseEvalItem >) DataRepository.SvCourseEvalItemProvider.DeepSave,
							new object[] { transactionManager, entity.SvCourseEvalItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStaffEvalItem>
				if (CanDeepSave(entity.SvStaffEvalItemCollection, "List<SvStaffEvalItem>|SvStaffEvalItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStaffEvalItem child in entity.SvStaffEvalItemCollection)
					{
						if(child.SvCodeRatingSchmIdSource != null)
						{
							child.SvCodeRatingSchmId = child.SvCodeRatingSchmIdSource.SvCodeRatingSchmId;
						}
						else
						{
							child.SvCodeRatingSchmId = entity.SvCodeRatingSchmId;
						}

					}

					if (entity.SvStaffEvalItemCollection.Count > 0 || entity.SvStaffEvalItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStaffEvalItemProvider.Save(transactionManager, entity.SvStaffEvalItemCollection);
						
						deepHandles.Add("SvStaffEvalItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStaffEvalItem >) DataRepository.SvStaffEvalItemProvider.DeepSave,
							new object[] { transactionManager, entity.SvStaffEvalItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvCourseEval>
				if (CanDeepSave(entity.SvCourseEvalCollection, "List<SvCourseEval>|SvCourseEvalCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvCourseEval child in entity.SvCourseEvalCollection)
					{
						if(child.SvCodeRatingSchmIdSource != null)
						{
							child.SvCodeRatingSchmId = child.SvCodeRatingSchmIdSource.SvCodeRatingSchmId;
						}
						else
						{
							child.SvCodeRatingSchmId = entity.SvCodeRatingSchmId;
						}

					}

					if (entity.SvCourseEvalCollection.Count > 0 || entity.SvCourseEvalCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvCourseEvalProvider.Save(transactionManager, entity.SvCourseEvalCollection);
						
						deepHandles.Add("SvCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvCourseEval >) DataRepository.SvCourseEvalProvider.DeepSave,
							new object[] { transactionManager, entity.SvCourseEvalCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvCodeRatingSchmDtl>
				if (CanDeepSave(entity.SvCodeRatingSchmDtlCollection, "List<SvCodeRatingSchmDtl>|SvCodeRatingSchmDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvCodeRatingSchmDtl child in entity.SvCodeRatingSchmDtlCollection)
					{
						if(child.SvCodeRatingSchmIdSource != null)
						{
							child.SvCodeRatingSchmId = child.SvCodeRatingSchmIdSource.SvCodeRatingSchmId;
						}
						else
						{
							child.SvCodeRatingSchmId = entity.SvCodeRatingSchmId;
						}

					}

					if (entity.SvCodeRatingSchmDtlCollection.Count > 0 || entity.SvCodeRatingSchmDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvCodeRatingSchmDtlProvider.Save(transactionManager, entity.SvCodeRatingSchmDtlCollection);
						
						deepHandles.Add("SvCodeRatingSchmDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvCodeRatingSchmDtl >) DataRepository.SvCodeRatingSchmDtlProvider.DeepSave,
							new object[] { transactionManager, entity.SvCodeRatingSchmDtlCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvCodeRatingSchmChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvCodeRatingSchm</c>
	///</summary>
	public enum SvCodeRatingSchmChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SvCodeRatingSchm</c> as OneToMany for SvStaffEvlCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStaffEvl>))]
		SvStaffEvlCollection,
		///<summary>
		/// Collection of <c>SvCodeRatingSchm</c> as OneToMany for SvCourseEvalItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvCourseEvalItem>))]
		SvCourseEvalItemCollection,
		///<summary>
		/// Collection of <c>SvCodeRatingSchm</c> as OneToMany for SvStaffEvalItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStaffEvalItem>))]
		SvStaffEvalItemCollection,
		///<summary>
		/// Collection of <c>SvCodeRatingSchm</c> as OneToMany for SvCourseEvalCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvCourseEval>))]
		SvCourseEvalCollection,
		///<summary>
		/// Collection of <c>SvCodeRatingSchm</c> as OneToMany for SvCodeRatingSchmDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvCodeRatingSchmDtl>))]
		SvCodeRatingSchmDtlCollection,
	}
	
	#endregion SvCodeRatingSchmChildEntityTypes
	
	#region SvCodeRatingSchmFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvCodeRatingSchmColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCodeRatingSchm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCodeRatingSchmFilterBuilder : SqlFilterBuilder<SvCodeRatingSchmColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCodeRatingSchmFilterBuilder class.
		/// </summary>
		public SvCodeRatingSchmFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCodeRatingSchmFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCodeRatingSchmFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCodeRatingSchmFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCodeRatingSchmFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCodeRatingSchmFilterBuilder
	
	#region SvCodeRatingSchmParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvCodeRatingSchmColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCodeRatingSchm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCodeRatingSchmParameterBuilder : ParameterizedSqlFilterBuilder<SvCodeRatingSchmColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCodeRatingSchmParameterBuilder class.
		/// </summary>
		public SvCodeRatingSchmParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCodeRatingSchmParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCodeRatingSchmParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCodeRatingSchmParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCodeRatingSchmParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCodeRatingSchmParameterBuilder
	
	#region SvCodeRatingSchmSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvCodeRatingSchmColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCodeRatingSchm"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvCodeRatingSchmSortBuilder : SqlSortBuilder<SvCodeRatingSchmColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCodeRatingSchmSqlSortBuilder class.
		/// </summary>
		public SvCodeRatingSchmSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvCodeRatingSchmSortBuilder
	
} // end namespace
