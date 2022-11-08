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
	/// This class is the base class for any <see cref="SaCodeCourseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeCourseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeCourse, UMIS_VER2.BusinessLyer.SaCodeCourseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeCourseKey key)
		{
			return Delete(transactionManager, key.SaCodeCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeCourseId)
		{
			return Delete(null, _saCodeCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeCourseId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeCourse Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeCourseKey key, int start, int pageLength)
		{
			return GetBySaCodeCourseId(transactionManager, key.SaCodeCourseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_COURSE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_courseTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeCourse&gt;"/> class.</returns>
		public TList<SaCodeCourse> GetByCourseTypeId(System.Decimal _courseTypeId)
		{
			int count = -1;
			return GetByCourseTypeId(null,_courseTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_COURSE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_courseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeCourse&gt;"/> class.</returns>
		public TList<SaCodeCourse> GetByCourseTypeId(System.Decimal _courseTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByCourseTypeId(null, _courseTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_COURSE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_courseTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeCourse&gt;"/> class.</returns>
		public TList<SaCodeCourse> GetByCourseTypeId(TransactionManager transactionManager, System.Decimal _courseTypeId)
		{
			int count = -1;
			return GetByCourseTypeId(transactionManager, _courseTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_COURSE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_courseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeCourse&gt;"/> class.</returns>
		public TList<SaCodeCourse> GetByCourseTypeId(TransactionManager transactionManager, System.Decimal _courseTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByCourseTypeId(transactionManager, _courseTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_COURSE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_courseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeCourse&gt;"/> class.</returns>
		public TList<SaCodeCourse> GetByCourseTypeId(System.Decimal _courseTypeId, int start, int pageLength, out int count)
		{
			return GetByCourseTypeId(null, _courseTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_COURSE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_courseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeCourse&gt;"/> class.</returns>
		public abstract TList<SaCodeCourse> GetByCourseTypeId(TransactionManager transactionManager, System.Decimal _courseTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_COURSE index.
		/// </summary>
		/// <param name="_saCodeCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCourse GetBySaCodeCourseId(System.Decimal _saCodeCourseId)
		{
			int count = -1;
			return GetBySaCodeCourseId(null,_saCodeCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COURSE index.
		/// </summary>
		/// <param name="_saCodeCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCourse GetBySaCodeCourseId(System.Decimal _saCodeCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeCourseId(null, _saCodeCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCourse GetBySaCodeCourseId(TransactionManager transactionManager, System.Decimal _saCodeCourseId)
		{
			int count = -1;
			return GetBySaCodeCourseId(transactionManager, _saCodeCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCourse GetBySaCodeCourseId(TransactionManager transactionManager, System.Decimal _saCodeCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeCourseId(transactionManager, _saCodeCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COURSE index.
		/// </summary>
		/// <param name="_saCodeCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCourse GetBySaCodeCourseId(System.Decimal _saCodeCourseId, int start, int pageLength, out int count)
		{
			return GetBySaCodeCourseId(null, _saCodeCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeCourse GetBySaCodeCourseId(TransactionManager transactionManager, System.Decimal _saCodeCourseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeCourse&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeCourse&gt;"/></returns>
		public static TList<SaCodeCourse> Fill(IDataReader reader, TList<SaCodeCourse> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeCourse c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeCourse")
					.Append("|").Append((System.Decimal)reader["SA_CODE_COURSE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeCourse>(
					key.ToString(), // EntityTrackingKey
					"SaCodeCourse",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeCourse();
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
					c.SaCodeCourseId = (System.Decimal)reader["SA_CODE_COURSE_ID"];
					c.OriginalSaCodeCourseId = c.SaCodeCourseId;
					c.CourseTypeId = (System.Decimal)reader["COURSE_TYPE_ID"];
					c.CourseDescrAr = (System.String)reader["COURSE_DESCR_AR"];
					c.CourseDescrEn = Convert.IsDBNull(reader["COURSE_DESCR_EN"]) ? null : (System.String)reader["COURSE_DESCR_EN"];
					c.CourseHrNum = Convert.IsDBNull(reader["COURSE_HR_NUM"]) ? null : (System.Decimal?)reader["COURSE_HR_NUM"];
					c.CourseCapacity = Convert.IsDBNull(reader["COURSE_CAPACITY"]) ? null : (System.Decimal?)reader["COURSE_CAPACITY"];
					c.CourseCode = (System.String)reader["COURSE_CODE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourse"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeCourse"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeCourse entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeCourseId = (System.Decimal)reader[((int)SaCodeCourseColumn.SaCodeCourseId - 1)];
			entity.OriginalSaCodeCourseId = (System.Decimal)reader["SA_CODE_COURSE_ID"];
			entity.CourseTypeId = (System.Decimal)reader[((int)SaCodeCourseColumn.CourseTypeId - 1)];
			entity.CourseDescrAr = (System.String)reader[((int)SaCodeCourseColumn.CourseDescrAr - 1)];
			entity.CourseDescrEn = (reader.IsDBNull(((int)SaCodeCourseColumn.CourseDescrEn - 1)))?null:(System.String)reader[((int)SaCodeCourseColumn.CourseDescrEn - 1)];
			entity.CourseHrNum = (reader.IsDBNull(((int)SaCodeCourseColumn.CourseHrNum - 1)))?null:(System.Decimal?)reader[((int)SaCodeCourseColumn.CourseHrNum - 1)];
			entity.CourseCapacity = (reader.IsDBNull(((int)SaCodeCourseColumn.CourseCapacity - 1)))?null:(System.Decimal?)reader[((int)SaCodeCourseColumn.CourseCapacity - 1)];
			entity.CourseCode = (System.String)reader[((int)SaCodeCourseColumn.CourseCode - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourse"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeCourse"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeCourse entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeCourseId = (System.Decimal)dataRow["SA_CODE_COURSE_ID"];
			entity.OriginalSaCodeCourseId = (System.Decimal)dataRow["SA_CODE_COURSE_ID"];
			entity.CourseTypeId = (System.Decimal)dataRow["COURSE_TYPE_ID"];
			entity.CourseDescrAr = (System.String)dataRow["COURSE_DESCR_AR"];
			entity.CourseDescrEn = Convert.IsDBNull(dataRow["COURSE_DESCR_EN"]) ? null : (System.String)dataRow["COURSE_DESCR_EN"];
			entity.CourseHrNum = Convert.IsDBNull(dataRow["COURSE_HR_NUM"]) ? null : (System.Decimal?)dataRow["COURSE_HR_NUM"];
			entity.CourseCapacity = Convert.IsDBNull(dataRow["COURSE_CAPACITY"]) ? null : (System.Decimal?)dataRow["COURSE_CAPACITY"];
			entity.CourseCode = (System.String)dataRow["COURSE_CODE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeCourse"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeCourse Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeCourse entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region CourseTypeIdSource	
			if (CanDeepLoad(entity, "SaCodeCourseType|CourseTypeIdSource", deepLoadType, innerList) 
				&& entity.CourseTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CourseTypeId;
				SaCodeCourseType tmpEntity = EntityManager.LocateEntity<SaCodeCourseType>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeCourseType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CourseTypeIdSource = tmpEntity;
				else
					entity.CourseTypeIdSource = DataRepository.SaCodeCourseTypeProvider.GetBySaCodeCourseTypeId(transactionManager, entity.CourseTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CourseTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CourseTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeCourseTypeProvider.DeepLoad(transactionManager, entity.CourseTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CourseTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeCourseId methods when available
			
			#region SaTrainingCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaTrainingCourse>|SaTrainingCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaTrainingCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaTrainingCourseCollection = DataRepository.SaTrainingCourseProvider.GetBySaCodeCourseId(transactionManager, entity.SaCodeCourseId);

				if (deep && entity.SaTrainingCourseCollection.Count > 0)
				{
					deepHandles.Add("SaTrainingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaTrainingCourse>) DataRepository.SaTrainingCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.SaTrainingCourseCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeCourse object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeCourse instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeCourse Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeCourse entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region CourseTypeIdSource
			if (CanDeepSave(entity, "SaCodeCourseType|CourseTypeIdSource", deepSaveType, innerList) 
				&& entity.CourseTypeIdSource != null)
			{
				DataRepository.SaCodeCourseTypeProvider.Save(transactionManager, entity.CourseTypeIdSource);
				entity.CourseTypeId = entity.CourseTypeIdSource.SaCodeCourseTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaTrainingCourse>
				if (CanDeepSave(entity.SaTrainingCourseCollection, "List<SaTrainingCourse>|SaTrainingCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaTrainingCourse child in entity.SaTrainingCourseCollection)
					{
						if(child.SaCodeCourseIdSource != null)
						{
							child.SaCodeCourseId = child.SaCodeCourseIdSource.SaCodeCourseId;
						}
						else
						{
							child.SaCodeCourseId = entity.SaCodeCourseId;
						}

					}

					if (entity.SaTrainingCourseCollection.Count > 0 || entity.SaTrainingCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaTrainingCourseProvider.Save(transactionManager, entity.SaTrainingCourseCollection);
						
						deepHandles.Add("SaTrainingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaTrainingCourse >) DataRepository.SaTrainingCourseProvider.DeepSave,
							new object[] { transactionManager, entity.SaTrainingCourseCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodeCourseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeCourse</c>
	///</summary>
	public enum SaCodeCourseChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeCourseType</c> at CourseTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeCourseType))]
		SaCodeCourseType,
		///<summary>
		/// Collection of <c>SaCodeCourse</c> as OneToMany for SaTrainingCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaTrainingCourse>))]
		SaTrainingCourseCollection,
	}
	
	#endregion SaCodeCourseChildEntityTypes
	
	#region SaCodeCourseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeCourseFilterBuilder : SqlFilterBuilder<SaCodeCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseFilterBuilder class.
		/// </summary>
		public SaCodeCourseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeCourseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeCourseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeCourseFilterBuilder
	
	#region SaCodeCourseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeCourseParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseParameterBuilder class.
		/// </summary>
		public SaCodeCourseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeCourseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeCourseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeCourseParameterBuilder
	
	#region SaCodeCourseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeCourse"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeCourseSortBuilder : SqlSortBuilder<SaCodeCourseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseSqlSortBuilder class.
		/// </summary>
		public SaCodeCourseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeCourseSortBuilder
	
} // end namespace
