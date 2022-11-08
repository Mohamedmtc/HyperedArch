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
	/// This class is the base class for any <see cref="ScCdeHallEquipProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScCdeHallEquipProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScCdeHallEquip, UMIS_VER2.BusinessLyer.ScCdeHallEquipKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScCdeHallEquipKey key)
		{
			return Delete(transactionManager, key.ScCdeHallEquipId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scCdeHallEquipId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scCdeHallEquipId)
		{
			return Delete(null, _scCdeHallEquipId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeHallEquipId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scCdeHallEquipId);		
		
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
		public override UMIS_VER2.BusinessLyer.ScCdeHallEquip Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScCdeHallEquipKey key, int start, int pageLength)
		{
			return GetByScCdeHallEquipId(transactionManager, key.ScCdeHallEquipId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_CDE_HALL_EQUIP index.
		/// </summary>
		/// <param name="_scCdeHallEquipId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallEquip GetByScCdeHallEquipId(System.Decimal _scCdeHallEquipId)
		{
			int count = -1;
			return GetByScCdeHallEquipId(null,_scCdeHallEquipId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_HALL_EQUIP index.
		/// </summary>
		/// <param name="_scCdeHallEquipId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallEquip GetByScCdeHallEquipId(System.Decimal _scCdeHallEquipId, int start, int pageLength)
		{
			int count = -1;
			return GetByScCdeHallEquipId(null, _scCdeHallEquipId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_HALL_EQUIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeHallEquipId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallEquip GetByScCdeHallEquipId(TransactionManager transactionManager, System.Decimal _scCdeHallEquipId)
		{
			int count = -1;
			return GetByScCdeHallEquipId(transactionManager, _scCdeHallEquipId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_HALL_EQUIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeHallEquipId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallEquip GetByScCdeHallEquipId(TransactionManager transactionManager, System.Decimal _scCdeHallEquipId, int start, int pageLength)
		{
			int count = -1;
			return GetByScCdeHallEquipId(transactionManager, _scCdeHallEquipId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_HALL_EQUIP index.
		/// </summary>
		/// <param name="_scCdeHallEquipId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallEquip GetByScCdeHallEquipId(System.Decimal _scCdeHallEquipId, int start, int pageLength, out int count)
		{
			return GetByScCdeHallEquipId(null, _scCdeHallEquipId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_HALL_EQUIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeHallEquipId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScCdeHallEquip GetByScCdeHallEquipId(TransactionManager transactionManager, System.Decimal _scCdeHallEquipId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_HALL_EQUIP_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallEquip GetByDescrAr(System.String _descrAr)
		{
			int count = -1;
			return GetByDescrAr(null,_descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_EQUIP_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallEquip GetByDescrAr(System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrAr(null, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_EQUIP_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallEquip GetByDescrAr(TransactionManager transactionManager, System.String _descrAr)
		{
			int count = -1;
			return GetByDescrAr(transactionManager, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_EQUIP_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallEquip GetByDescrAr(TransactionManager transactionManager, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrAr(transactionManager, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_EQUIP_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallEquip GetByDescrAr(System.String _descrAr, int start, int pageLength, out int count)
		{
			return GetByDescrAr(null, _descrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_EQUIP_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScCdeHallEquip GetByDescrAr(TransactionManager transactionManager, System.String _descrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_HALL_EQUIP_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallEquip GetByDescrEn(System.String _descrEn)
		{
			int count = -1;
			return GetByDescrEn(null,_descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_EQUIP_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallEquip GetByDescrEn(System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrEn(null, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_EQUIP_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallEquip GetByDescrEn(TransactionManager transactionManager, System.String _descrEn)
		{
			int count = -1;
			return GetByDescrEn(transactionManager, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_EQUIP_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallEquip GetByDescrEn(TransactionManager transactionManager, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrEn(transactionManager, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_EQUIP_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeHallEquip GetByDescrEn(System.String _descrEn, int start, int pageLength, out int count)
		{
			return GetByDescrEn(null, _descrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_EQUIP_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScCdeHallEquip GetByDescrEn(TransactionManager transactionManager, System.String _descrEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScCdeHallEquip&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScCdeHallEquip&gt;"/></returns>
		public static TList<ScCdeHallEquip> Fill(IDataReader reader, TList<ScCdeHallEquip> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScCdeHallEquip c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScCdeHallEquip")
					.Append("|").Append((System.Decimal)reader["SC_CDE_HALL_EQUIP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScCdeHallEquip>(
					key.ToString(), // EntityTrackingKey
					"ScCdeHallEquip",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScCdeHallEquip();
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
					c.ScCdeHallEquipId = (System.Decimal)reader["SC_CDE_HALL_EQUIP_ID"];
					c.OriginalScCdeHallEquipId = c.ScCdeHallEquipId;
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScCdeHallEquip entity)
		{
			if (!reader.Read()) return;
			
			entity.ScCdeHallEquipId = (System.Decimal)reader[((int)ScCdeHallEquipColumn.ScCdeHallEquipId - 1)];
			entity.OriginalScCdeHallEquipId = (System.Decimal)reader["SC_CDE_HALL_EQUIP_ID"];
			entity.DescrAr = (System.String)reader[((int)ScCdeHallEquipColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)ScCdeHallEquipColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScCdeHallEquip entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScCdeHallEquipId = (System.Decimal)dataRow["SC_CDE_HALL_EQUIP_ID"];
			entity.OriginalScCdeHallEquipId = (System.Decimal)dataRow["SC_CDE_HALL_EQUIP_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScCdeHallEquip"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScCdeHallEquip Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScCdeHallEquip entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByScCdeHallEquipId methods when available
			
			#region ScHallEquipCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScHallEquip>|ScHallEquipCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScHallEquipCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScHallEquipCollection = DataRepository.ScHallEquipProvider.GetByScCdeHallEquipId(transactionManager, entity.ScCdeHallEquipId);

				if (deep && entity.ScHallEquipCollection.Count > 0)
				{
					deepHandles.Add("ScHallEquipCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScHallEquip>) DataRepository.ScHallEquipProvider.DeepLoad,
						new object[] { transactionManager, entity.ScHallEquipCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScCdeHallEquip object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScCdeHallEquip instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScCdeHallEquip Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScCdeHallEquip entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<ScHallEquip>
				if (CanDeepSave(entity.ScHallEquipCollection, "List<ScHallEquip>|ScHallEquipCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScHallEquip child in entity.ScHallEquipCollection)
					{
						if(child.ScCdeHallEquipIdSource != null)
						{
							child.ScCdeHallEquipId = child.ScCdeHallEquipIdSource.ScCdeHallEquipId;
						}
						else
						{
							child.ScCdeHallEquipId = entity.ScCdeHallEquipId;
						}

					}

					if (entity.ScHallEquipCollection.Count > 0 || entity.ScHallEquipCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScHallEquipProvider.Save(transactionManager, entity.ScHallEquipCollection);
						
						deepHandles.Add("ScHallEquipCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScHallEquip >) DataRepository.ScHallEquipProvider.DeepSave,
							new object[] { transactionManager, entity.ScHallEquipCollection, deepSaveType, childTypes, innerList }
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
	
	#region ScCdeHallEquipChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScCdeHallEquip</c>
	///</summary>
	public enum ScCdeHallEquipChildEntityTypes
	{
		///<summary>
		/// Collection of <c>ScCdeHallEquip</c> as OneToMany for ScHallEquipCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScHallEquip>))]
		ScHallEquipCollection,
	}
	
	#endregion ScCdeHallEquipChildEntityTypes
	
	#region ScCdeHallEquipFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScCdeHallEquipColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScCdeHallEquip"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScCdeHallEquipFilterBuilder : SqlFilterBuilder<ScCdeHallEquipColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScCdeHallEquipFilterBuilder class.
		/// </summary>
		public ScCdeHallEquipFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScCdeHallEquipFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScCdeHallEquipFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScCdeHallEquipFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScCdeHallEquipFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScCdeHallEquipFilterBuilder
	
	#region ScCdeHallEquipParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScCdeHallEquipColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScCdeHallEquip"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScCdeHallEquipParameterBuilder : ParameterizedSqlFilterBuilder<ScCdeHallEquipColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScCdeHallEquipParameterBuilder class.
		/// </summary>
		public ScCdeHallEquipParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScCdeHallEquipParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScCdeHallEquipParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScCdeHallEquipParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScCdeHallEquipParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScCdeHallEquipParameterBuilder
	
	#region ScCdeHallEquipSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScCdeHallEquipColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScCdeHallEquip"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScCdeHallEquipSortBuilder : SqlSortBuilder<ScCdeHallEquipColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScCdeHallEquipSqlSortBuilder class.
		/// </summary>
		public ScCdeHallEquipSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScCdeHallEquipSortBuilder
	
} // end namespace
