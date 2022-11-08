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
	/// This class is the base class for any <see cref="EdCourseOrientProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCourseOrientProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCourseOrient, UMIS_VER2.BusinessLyer.EdCourseOrientKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseOrientKey key)
		{
			return Delete(transactionManager, key.EdCourseOrientId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCourseOrientId">XXX. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCourseOrientId)
		{
			return Delete(null, _edCourseOrientId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOrientId">XXX. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCourseOrientId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ORIENT_ED_COURSE key.
		///		FK_ED_COURSE_ORIENT_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOrient objects.</returns>
		public TList<EdCourseOrient> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ORIENT_ED_COURSE key.
		///		FK_ED_COURSE_ORIENT_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOrient objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseOrient> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ORIENT_ED_COURSE key.
		///		FK_ED_COURSE_ORIENT_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOrient objects.</returns>
		public TList<EdCourseOrient> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ORIENT_ED_COURSE key.
		///		fkEdCourseOrientEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOrient objects.</returns>
		public TList<EdCourseOrient> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ORIENT_ED_COURSE key.
		///		fkEdCourseOrientEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOrient objects.</returns>
		public TList<EdCourseOrient> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ORIENT_ED_COURSE key.
		///		FK_ED_COURSE_ORIENT_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOrient objects.</returns>
		public abstract TList<EdCourseOrient> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ORIENT_ENTITY_MAIN key.
		///		FK_ED_COURSE_ORIENT_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId">ENT_CDE_PKG_TYPE_ID=5</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOrient objects.</returns>
		public TList<EdCourseOrient> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ORIENT_ENTITY_MAIN key.
		///		FK_ED_COURSE_ORIENT_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">ENT_CDE_PKG_TYPE_ID=5</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOrient objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseOrient> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ORIENT_ENTITY_MAIN key.
		///		FK_ED_COURSE_ORIENT_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">ENT_CDE_PKG_TYPE_ID=5</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOrient objects.</returns>
		public TList<EdCourseOrient> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ORIENT_ENTITY_MAIN key.
		///		fkEdCourseOrientEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">ENT_CDE_PKG_TYPE_ID=5</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOrient objects.</returns>
		public TList<EdCourseOrient> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ORIENT_ENTITY_MAIN key.
		///		fkEdCourseOrientEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">ENT_CDE_PKG_TYPE_ID=5</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOrient objects.</returns>
		public TList<EdCourseOrient> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ORIENT_ENTITY_MAIN key.
		///		FK_ED_COURSE_ORIENT_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">ENT_CDE_PKG_TYPE_ID=5</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOrient objects.</returns>
		public abstract TList<EdCourseOrient> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdCourseOrient Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseOrientKey key, int start, int pageLength)
		{
			return GetByEdCourseOrientId(transactionManager, key.EdCourseOrientId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_COURSE_ORIENT index.
		/// </summary>
		/// <param name="_edCourseOrientId">XXX</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseOrient"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseOrient GetByEdCourseOrientId(System.Decimal _edCourseOrientId)
		{
			int count = -1;
			return GetByEdCourseOrientId(null,_edCourseOrientId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_ORIENT index.
		/// </summary>
		/// <param name="_edCourseOrientId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseOrient"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseOrient GetByEdCourseOrientId(System.Decimal _edCourseOrientId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseOrientId(null, _edCourseOrientId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_ORIENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOrientId">XXX</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseOrient"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseOrient GetByEdCourseOrientId(TransactionManager transactionManager, System.Decimal _edCourseOrientId)
		{
			int count = -1;
			return GetByEdCourseOrientId(transactionManager, _edCourseOrientId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_ORIENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOrientId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseOrient"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseOrient GetByEdCourseOrientId(TransactionManager transactionManager, System.Decimal _edCourseOrientId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseOrientId(transactionManager, _edCourseOrientId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_ORIENT index.
		/// </summary>
		/// <param name="_edCourseOrientId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseOrient"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseOrient GetByEdCourseOrientId(System.Decimal _edCourseOrientId, int start, int pageLength, out int count)
		{
			return GetByEdCourseOrientId(null, _edCourseOrientId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_ORIENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOrientId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseOrient"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCourseOrient GetByEdCourseOrientId(TransactionManager transactionManager, System.Decimal _edCourseOrientId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCourseOrient&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCourseOrient&gt;"/></returns>
		public static TList<EdCourseOrient> Fill(IDataReader reader, TList<EdCourseOrient> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCourseOrient c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCourseOrient")
					.Append("|").Append((System.Decimal)reader["ED_COURSE_ORIENT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCourseOrient>(
					key.ToString(), // EntityTrackingKey
					"EdCourseOrient",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCourseOrient();
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
					c.EdCourseOrientId = (System.Decimal)reader["ED_COURSE_ORIENT_ID"];
					c.OriginalEdCourseOrientId = c.EdCourseOrientId;
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseOrient"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseOrient"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCourseOrient entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCourseOrientId = (System.Decimal)reader[((int)EdCourseOrientColumn.EdCourseOrientId - 1)];
			entity.OriginalEdCourseOrientId = (System.Decimal)reader["ED_COURSE_ORIENT_ID"];
			entity.EntMainId = (System.Decimal)reader[((int)EdCourseOrientColumn.EntMainId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)EdCourseOrientColumn.EdCourseId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseOrient"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseOrient"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCourseOrient entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCourseOrientId = (System.Decimal)dataRow["ED_COURSE_ORIENT_ID"];
			entity.OriginalEdCourseOrientId = (System.Decimal)dataRow["ED_COURSE_ORIENT_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseOrient"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseOrient Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseOrient entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseIdSource

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntMainId;
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, entity.EntMainId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCourseOrient object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCourseOrient instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseOrient Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseOrient entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
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
	
	#region EdCourseOrientChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCourseOrient</c>
	///</summary>
	public enum EdCourseOrientChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
	}
	
	#endregion EdCourseOrientChildEntityTypes
	
	#region EdCourseOrientFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCourseOrientColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseOrient"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseOrientFilterBuilder : SqlFilterBuilder<EdCourseOrientColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseOrientFilterBuilder class.
		/// </summary>
		public EdCourseOrientFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseOrientFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseOrientFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseOrientFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseOrientFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseOrientFilterBuilder
	
	#region EdCourseOrientParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCourseOrientColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseOrient"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseOrientParameterBuilder : ParameterizedSqlFilterBuilder<EdCourseOrientColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseOrientParameterBuilder class.
		/// </summary>
		public EdCourseOrientParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseOrientParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseOrientParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseOrientParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseOrientParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseOrientParameterBuilder
	
	#region EdCourseOrientSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCourseOrientColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseOrient"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCourseOrientSortBuilder : SqlSortBuilder<EdCourseOrientColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseOrientSqlSortBuilder class.
		/// </summary>
		public EdCourseOrientSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCourseOrientSortBuilder
	
} // end namespace
