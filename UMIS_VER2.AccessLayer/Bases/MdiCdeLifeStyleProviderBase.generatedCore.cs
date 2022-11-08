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
	/// This class is the base class for any <see cref="MdiCdeLifeStyleProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MdiCdeLifeStyleProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MdiCdeLifeStyle, UMIS_VER2.BusinessLyer.MdiCdeLifeStyleKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeLifeStyleKey key)
		{
			return Delete(transactionManager, key.MdiCdeLifeStyleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mdiCdeLifeStyleId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mdiCdeLifeStyleId)
		{
			return Delete(null, _mdiCdeLifeStyleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeLifeStyleId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mdiCdeLifeStyleId);		
		
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
		public override UMIS_VER2.BusinessLyer.MdiCdeLifeStyle Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeLifeStyleKey key, int start, int pageLength)
		{
			return GetByMdiCdeLifeStyleId(transactionManager, key.MdiCdeLifeStyleId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MDI_CDE_LIFE_STYLE index.
		/// </summary>
		/// <param name="_mdiCdeLifeStyleId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeLifeStyle GetByMdiCdeLifeStyleId(System.Decimal _mdiCdeLifeStyleId)
		{
			int count = -1;
			return GetByMdiCdeLifeStyleId(null,_mdiCdeLifeStyleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_LIFE_STYLE index.
		/// </summary>
		/// <param name="_mdiCdeLifeStyleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeLifeStyle GetByMdiCdeLifeStyleId(System.Decimal _mdiCdeLifeStyleId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeLifeStyleId(null, _mdiCdeLifeStyleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_LIFE_STYLE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeLifeStyleId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeLifeStyle GetByMdiCdeLifeStyleId(TransactionManager transactionManager, System.Decimal _mdiCdeLifeStyleId)
		{
			int count = -1;
			return GetByMdiCdeLifeStyleId(transactionManager, _mdiCdeLifeStyleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_LIFE_STYLE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeLifeStyleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeLifeStyle GetByMdiCdeLifeStyleId(TransactionManager transactionManager, System.Decimal _mdiCdeLifeStyleId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeLifeStyleId(transactionManager, _mdiCdeLifeStyleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_LIFE_STYLE index.
		/// </summary>
		/// <param name="_mdiCdeLifeStyleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeLifeStyle GetByMdiCdeLifeStyleId(System.Decimal _mdiCdeLifeStyleId, int start, int pageLength, out int count)
		{
			return GetByMdiCdeLifeStyleId(null, _mdiCdeLifeStyleId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_LIFE_STYLE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeLifeStyleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeLifeStyle GetByMdiCdeLifeStyleId(TransactionManager transactionManager, System.Decimal _mdiCdeLifeStyleId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_CDE_LIFE_STYLE_AR index.
		/// </summary>
		/// <param name="_lifeStyleAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeLifeStyle GetByLifeStyleAr(System.String _lifeStyleAr)
		{
			int count = -1;
			return GetByLifeStyleAr(null,_lifeStyleAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_LIFE_STYLE_AR index.
		/// </summary>
		/// <param name="_lifeStyleAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeLifeStyle GetByLifeStyleAr(System.String _lifeStyleAr, int start, int pageLength)
		{
			int count = -1;
			return GetByLifeStyleAr(null, _lifeStyleAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_LIFE_STYLE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_lifeStyleAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeLifeStyle GetByLifeStyleAr(TransactionManager transactionManager, System.String _lifeStyleAr)
		{
			int count = -1;
			return GetByLifeStyleAr(transactionManager, _lifeStyleAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_LIFE_STYLE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_lifeStyleAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeLifeStyle GetByLifeStyleAr(TransactionManager transactionManager, System.String _lifeStyleAr, int start, int pageLength)
		{
			int count = -1;
			return GetByLifeStyleAr(transactionManager, _lifeStyleAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_LIFE_STYLE_AR index.
		/// </summary>
		/// <param name="_lifeStyleAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeLifeStyle GetByLifeStyleAr(System.String _lifeStyleAr, int start, int pageLength, out int count)
		{
			return GetByLifeStyleAr(null, _lifeStyleAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_LIFE_STYLE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_lifeStyleAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeLifeStyle GetByLifeStyleAr(TransactionManager transactionManager, System.String _lifeStyleAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_CDE_LIFE_STYLE_EN index.
		/// </summary>
		/// <param name="_lifeStyleEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeLifeStyle GetByLifeStyleEn(System.String _lifeStyleEn)
		{
			int count = -1;
			return GetByLifeStyleEn(null,_lifeStyleEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_LIFE_STYLE_EN index.
		/// </summary>
		/// <param name="_lifeStyleEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeLifeStyle GetByLifeStyleEn(System.String _lifeStyleEn, int start, int pageLength)
		{
			int count = -1;
			return GetByLifeStyleEn(null, _lifeStyleEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_LIFE_STYLE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_lifeStyleEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeLifeStyle GetByLifeStyleEn(TransactionManager transactionManager, System.String _lifeStyleEn)
		{
			int count = -1;
			return GetByLifeStyleEn(transactionManager, _lifeStyleEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_LIFE_STYLE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_lifeStyleEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeLifeStyle GetByLifeStyleEn(TransactionManager transactionManager, System.String _lifeStyleEn, int start, int pageLength)
		{
			int count = -1;
			return GetByLifeStyleEn(transactionManager, _lifeStyleEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_LIFE_STYLE_EN index.
		/// </summary>
		/// <param name="_lifeStyleEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeLifeStyle GetByLifeStyleEn(System.String _lifeStyleEn, int start, int pageLength, out int count)
		{
			return GetByLifeStyleEn(null, _lifeStyleEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_LIFE_STYLE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_lifeStyleEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeLifeStyle GetByLifeStyleEn(TransactionManager transactionManager, System.String _lifeStyleEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MdiCdeLifeStyle&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MdiCdeLifeStyle&gt;"/></returns>
		public static TList<MdiCdeLifeStyle> Fill(IDataReader reader, TList<MdiCdeLifeStyle> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MdiCdeLifeStyle c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MdiCdeLifeStyle")
					.Append("|").Append((System.Decimal)reader["MDI_CDE_LIFE_STYLE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MdiCdeLifeStyle>(
					key.ToString(), // EntityTrackingKey
					"MdiCdeLifeStyle",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MdiCdeLifeStyle();
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
					c.MdiCdeLifeStyleId = (System.Decimal)reader["MDI_CDE_LIFE_STYLE_ID"];
					c.OriginalMdiCdeLifeStyleId = c.MdiCdeLifeStyleId;
					c.LifeStyleAr = (System.String)reader["LIFE_STYLE_AR"];
					c.LifeStyleEn = (System.String)reader["LIFE_STYLE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MdiCdeLifeStyle entity)
		{
			if (!reader.Read()) return;
			
			entity.MdiCdeLifeStyleId = (System.Decimal)reader[((int)MdiCdeLifeStyleColumn.MdiCdeLifeStyleId - 1)];
			entity.OriginalMdiCdeLifeStyleId = (System.Decimal)reader["MDI_CDE_LIFE_STYLE_ID"];
			entity.LifeStyleAr = (System.String)reader[((int)MdiCdeLifeStyleColumn.LifeStyleAr - 1)];
			entity.LifeStyleEn = (System.String)reader[((int)MdiCdeLifeStyleColumn.LifeStyleEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MdiCdeLifeStyle entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MdiCdeLifeStyleId = (System.Decimal)dataRow["MDI_CDE_LIFE_STYLE_ID"];
			entity.OriginalMdiCdeLifeStyleId = (System.Decimal)dataRow["MDI_CDE_LIFE_STYLE_ID"];
			entity.LifeStyleAr = (System.String)dataRow["LIFE_STYLE_AR"];
			entity.LifeStyleEn = (System.String)dataRow["LIFE_STYLE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeLifeStyle"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiCdeLifeStyle Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeLifeStyle entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMdiCdeLifeStyleId methods when available
			
			#region MdiStudLifeStyleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudLifeStyle>|MdiStudLifeStyleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudLifeStyleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudLifeStyleCollection = DataRepository.MdiStudLifeStyleProvider.GetByMdiCdeLifeStyleId(transactionManager, entity.MdiCdeLifeStyleId);

				if (deep && entity.MdiStudLifeStyleCollection.Count > 0)
				{
					deepHandles.Add("MdiStudLifeStyleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudLifeStyle>) DataRepository.MdiStudLifeStyleProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudLifeStyleCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MdiCdeLifeStyle object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MdiCdeLifeStyle instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiCdeLifeStyle Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeLifeStyle entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<MdiStudLifeStyle>
				if (CanDeepSave(entity.MdiStudLifeStyleCollection, "List<MdiStudLifeStyle>|MdiStudLifeStyleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudLifeStyle child in entity.MdiStudLifeStyleCollection)
					{
						if(child.MdiCdeLifeStyleIdSource != null)
						{
							child.MdiCdeLifeStyleId = child.MdiCdeLifeStyleIdSource.MdiCdeLifeStyleId;
						}
						else
						{
							child.MdiCdeLifeStyleId = entity.MdiCdeLifeStyleId;
						}

					}

					if (entity.MdiStudLifeStyleCollection.Count > 0 || entity.MdiStudLifeStyleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudLifeStyleProvider.Save(transactionManager, entity.MdiStudLifeStyleCollection);
						
						deepHandles.Add("MdiStudLifeStyleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudLifeStyle >) DataRepository.MdiStudLifeStyleProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudLifeStyleCollection, deepSaveType, childTypes, innerList }
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
	
	#region MdiCdeLifeStyleChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MdiCdeLifeStyle</c>
	///</summary>
	public enum MdiCdeLifeStyleChildEntityTypes
	{
		///<summary>
		/// Collection of <c>MdiCdeLifeStyle</c> as OneToMany for MdiStudLifeStyleCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudLifeStyle>))]
		MdiStudLifeStyleCollection,
	}
	
	#endregion MdiCdeLifeStyleChildEntityTypes
	
	#region MdiCdeLifeStyleFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MdiCdeLifeStyleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeLifeStyle"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiCdeLifeStyleFilterBuilder : SqlFilterBuilder<MdiCdeLifeStyleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeLifeStyleFilterBuilder class.
		/// </summary>
		public MdiCdeLifeStyleFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeLifeStyleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiCdeLifeStyleFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeLifeStyleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiCdeLifeStyleFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiCdeLifeStyleFilterBuilder
	
	#region MdiCdeLifeStyleParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MdiCdeLifeStyleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeLifeStyle"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiCdeLifeStyleParameterBuilder : ParameterizedSqlFilterBuilder<MdiCdeLifeStyleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeLifeStyleParameterBuilder class.
		/// </summary>
		public MdiCdeLifeStyleParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeLifeStyleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiCdeLifeStyleParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeLifeStyleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiCdeLifeStyleParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiCdeLifeStyleParameterBuilder
	
	#region MdiCdeLifeStyleSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MdiCdeLifeStyleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeLifeStyle"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MdiCdeLifeStyleSortBuilder : SqlSortBuilder<MdiCdeLifeStyleColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeLifeStyleSqlSortBuilder class.
		/// </summary>
		public MdiCdeLifeStyleSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MdiCdeLifeStyleSortBuilder
	
} // end namespace
