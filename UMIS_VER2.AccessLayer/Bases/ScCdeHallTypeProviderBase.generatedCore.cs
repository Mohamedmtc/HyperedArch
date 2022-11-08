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
	/// This class is the base class for any <see cref="ScCdeHallTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScCdeHallTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScCdeHallType, UMIS_VER2.BusinessLyer.ScCdeHallTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScCdeHallTypeKey key)
		{
			return Delete(transactionManager, key.ScCdeHallTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scCdeHallTypeId">نوع القاعة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scCdeHallTypeId)
		{
			return Delete(null, _scCdeHallTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeHallTypeId">نوع القاعة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scCdeHallTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.ScCdeHallType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScCdeHallTypeKey key, int start, int pageLength)
		{
			return GetByScCdeHallTypeId(transactionManager, key.ScCdeHallTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_Table_1 index.
		/// </summary>
		/// <param name="_scCdeHallTypeId">نوع القاعة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallType GetByScCdeHallTypeId(System.Decimal _scCdeHallTypeId)
		{
			int count = -1;
			return GetByScCdeHallTypeId(null,_scCdeHallTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Table_1 index.
		/// </summary>
		/// <param name="_scCdeHallTypeId">نوع القاعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallType GetByScCdeHallTypeId(System.Decimal _scCdeHallTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByScCdeHallTypeId(null, _scCdeHallTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Table_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeHallTypeId">نوع القاعة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallType GetByScCdeHallTypeId(TransactionManager transactionManager, System.Decimal _scCdeHallTypeId)
		{
			int count = -1;
			return GetByScCdeHallTypeId(transactionManager, _scCdeHallTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Table_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeHallTypeId">نوع القاعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallType GetByScCdeHallTypeId(TransactionManager transactionManager, System.Decimal _scCdeHallTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByScCdeHallTypeId(transactionManager, _scCdeHallTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Table_1 index.
		/// </summary>
		/// <param name="_scCdeHallTypeId">نوع القاعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallType GetByScCdeHallTypeId(System.Decimal _scCdeHallTypeId, int start, int pageLength, out int count)
		{
			return GetByScCdeHallTypeId(null, _scCdeHallTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Table_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeHallTypeId">نوع القاعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScCdeHallType GetByScCdeHallTypeId(TransactionManager transactionManager, System.Decimal _scCdeHallTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_HALL_TYPE_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallType GetByDescrAr(System.String _descrAr)
		{
			int count = -1;
			return GetByDescrAr(null,_descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_TYPE_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallType GetByDescrAr(System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrAr(null, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_TYPE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallType GetByDescrAr(TransactionManager transactionManager, System.String _descrAr)
		{
			int count = -1;
			return GetByDescrAr(transactionManager, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_TYPE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallType GetByDescrAr(TransactionManager transactionManager, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrAr(transactionManager, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_TYPE_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallType GetByDescrAr(System.String _descrAr, int start, int pageLength, out int count)
		{
			return GetByDescrAr(null, _descrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_TYPE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScCdeHallType GetByDescrAr(TransactionManager transactionManager, System.String _descrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_HALL_TYPE_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallType GetByDescrEn(System.String _descrEn)
		{
			int count = -1;
			return GetByDescrEn(null,_descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_TYPE_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallType GetByDescrEn(System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrEn(null, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_TYPE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallType GetByDescrEn(TransactionManager transactionManager, System.String _descrEn)
		{
			int count = -1;
			return GetByDescrEn(transactionManager, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_TYPE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallType GetByDescrEn(TransactionManager transactionManager, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrEn(transactionManager, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_TYPE_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallType GetByDescrEn(System.String _descrEn, int start, int pageLength, out int count)
		{
			return GetByDescrEn(null, _descrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_TYPE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScCdeHallType GetByDescrEn(TransactionManager transactionManager, System.String _descrEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScCdeHallType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScCdeHallType&gt;"/></returns>
		public static TList<ScCdeHallType> Fill(IDataReader reader, TList<ScCdeHallType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScCdeHallType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScCdeHallType")
					.Append("|").Append((System.Decimal)reader["SC_CDE_HALL_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScCdeHallType>(
					key.ToString(), // EntityTrackingKey
					"ScCdeHallType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScCdeHallType();
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
					c.ScCdeHallTypeId = (System.Decimal)reader["SC_CDE_HALL_TYPE_ID"];
					c.OriginalScCdeHallTypeId = c.ScCdeHallTypeId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScCdeHallType entity)
		{
			if (!reader.Read()) return;
			
			entity.ScCdeHallTypeId = (System.Decimal)reader[((int)ScCdeHallTypeColumn.ScCdeHallTypeId - 1)];
			entity.OriginalScCdeHallTypeId = (System.Decimal)reader["SC_CDE_HALL_TYPE_ID"];
			entity.DescrAr = (System.String)reader[((int)ScCdeHallTypeColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)ScCdeHallTypeColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScCdeHallType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScCdeHallTypeId = (System.Decimal)dataRow["SC_CDE_HALL_TYPE_ID"];
			entity.OriginalScCdeHallTypeId = (System.Decimal)dataRow["SC_CDE_HALL_TYPE_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScCdeHallType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScCdeHallType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScCdeHallType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByScCdeHallTypeId methods when available
			
			#region ScHallCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScHall>|ScHallCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScHallCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScHallCollection = DataRepository.ScHallProvider.GetByScCdeHallTypeId(transactionManager, entity.ScCdeHallTypeId);

				if (deep && entity.ScHallCollection.Count > 0)
				{
					deepHandles.Add("ScHallCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScHall>) DataRepository.ScHallProvider.DeepLoad,
						new object[] { transactionManager, entity.ScHallCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScCdeHallType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScCdeHallType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScCdeHallType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScCdeHallType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<ScHall>
				if (CanDeepSave(entity.ScHallCollection, "List<ScHall>|ScHallCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScHall child in entity.ScHallCollection)
					{
						if(child.ScCdeHallTypeIdSource != null)
						{
							child.ScCdeHallTypeId = child.ScCdeHallTypeIdSource.ScCdeHallTypeId;
						}
						else
						{
							child.ScCdeHallTypeId = entity.ScCdeHallTypeId;
						}

					}

					if (entity.ScHallCollection.Count > 0 || entity.ScHallCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScHallProvider.Save(transactionManager, entity.ScHallCollection);
						
						deepHandles.Add("ScHallCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScHall >) DataRepository.ScHallProvider.DeepSave,
							new object[] { transactionManager, entity.ScHallCollection, deepSaveType, childTypes, innerList }
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
	
	#region ScCdeHallTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScCdeHallType</c>
	///</summary>
	public enum ScCdeHallTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>ScCdeHallType</c> as OneToMany for ScHallCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScHall>))]
		ScHallCollection,
	}
	
	#endregion ScCdeHallTypeChildEntityTypes
	
	#region ScCdeHallTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScCdeHallTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScCdeHallType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScCdeHallTypeFilterBuilder : SqlFilterBuilder<ScCdeHallTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScCdeHallTypeFilterBuilder class.
		/// </summary>
		public ScCdeHallTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScCdeHallTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScCdeHallTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScCdeHallTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScCdeHallTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScCdeHallTypeFilterBuilder
	
	#region ScCdeHallTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScCdeHallTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScCdeHallType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScCdeHallTypeParameterBuilder : ParameterizedSqlFilterBuilder<ScCdeHallTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScCdeHallTypeParameterBuilder class.
		/// </summary>
		public ScCdeHallTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScCdeHallTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScCdeHallTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScCdeHallTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScCdeHallTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScCdeHallTypeParameterBuilder
	
	#region ScCdeHallTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScCdeHallTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScCdeHallType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScCdeHallTypeSortBuilder : SqlSortBuilder<ScCdeHallTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScCdeHallTypeSqlSortBuilder class.
		/// </summary>
		public ScCdeHallTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScCdeHallTypeSortBuilder
	
} // end namespace
