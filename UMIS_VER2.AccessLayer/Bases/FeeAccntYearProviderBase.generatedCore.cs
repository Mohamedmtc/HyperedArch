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
	/// This class is the base class for any <see cref="FeeAccntYearProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeAccntYearProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeAccntYear, UMIS_VER2.BusinessLyer.FeeAccntYearKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeAccntYearKey key)
		{
			return Delete(transactionManager, key.FeeAccntYearId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeAccntYearId">السنوات المالية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeAccntYearId)
		{
			return Delete(null, _feeAccntYearId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccntYearId">السنوات المالية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeAccntYearId);		
		
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
		public override UMIS_VER2.BusinessLyer.FeeAccntYear Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeAccntYearKey key, int start, int pageLength)
		{
			return GetByFeeAccntYearId(transactionManager, key.FeeAccntYearId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_ACCNT_YEAR index.
		/// </summary>
		/// <param name="_feeAccntYearId">السنوات المالية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYear GetByFeeAccntYearId(System.Decimal _feeAccntYearId)
		{
			int count = -1;
			return GetByFeeAccntYearId(null,_feeAccntYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ACCNT_YEAR index.
		/// </summary>
		/// <param name="_feeAccntYearId">السنوات المالية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYear GetByFeeAccntYearId(System.Decimal _feeAccntYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeAccntYearId(null, _feeAccntYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ACCNT_YEAR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccntYearId">السنوات المالية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYear GetByFeeAccntYearId(TransactionManager transactionManager, System.Decimal _feeAccntYearId)
		{
			int count = -1;
			return GetByFeeAccntYearId(transactionManager, _feeAccntYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ACCNT_YEAR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccntYearId">السنوات المالية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYear GetByFeeAccntYearId(TransactionManager transactionManager, System.Decimal _feeAccntYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeAccntYearId(transactionManager, _feeAccntYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ACCNT_YEAR index.
		/// </summary>
		/// <param name="_feeAccntYearId">السنوات المالية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYear GetByFeeAccntYearId(System.Decimal _feeAccntYearId, int start, int pageLength, out int count)
		{
			return GetByFeeAccntYearId(null, _feeAccntYearId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ACCNT_YEAR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccntYearId">السنوات المالية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYear"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeAccntYear GetByFeeAccntYearId(TransactionManager transactionManager, System.Decimal _feeAccntYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_ACCNT_YEAR index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYear GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(null,_edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ACCNT_YEAR index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYear GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ACCNT_YEAR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYear GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ACCNT_YEAR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYear GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ACCNT_YEAR index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYear GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ACCNT_YEAR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYear"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeAccntYear GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeAccntYear&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeAccntYear&gt;"/></returns>
		public static TList<FeeAccntYear> Fill(IDataReader reader, TList<FeeAccntYear> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeAccntYear c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeAccntYear")
					.Append("|").Append((System.Decimal)reader["FEE_ACCNT_YEAR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeAccntYear>(
					key.ToString(), // EntityTrackingKey
					"FeeAccntYear",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeAccntYear();
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
					c.FeeAccntYearId = (System.Decimal)reader["FEE_ACCNT_YEAR_ID"];
					c.OriginalFeeAccntYearId = c.FeeAccntYearId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.YearFromDt = (System.DateTime)reader["YEAR_FROM_DT"];
					c.YearToDt = (System.DateTime)reader["YEAR_TO_DT"];
					c.YearNote = Convert.IsDBNull(reader["YEAR_NOTE"]) ? null : (System.String)reader["YEAR_NOTE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYear"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeAccntYear"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeAccntYear entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeAccntYearId = (System.Decimal)reader[((int)FeeAccntYearColumn.FeeAccntYearId - 1)];
			entity.OriginalFeeAccntYearId = (System.Decimal)reader["FEE_ACCNT_YEAR_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)FeeAccntYearColumn.EdAcadYearId - 1)];
			entity.YearFromDt = (System.DateTime)reader[((int)FeeAccntYearColumn.YearFromDt - 1)];
			entity.YearToDt = (System.DateTime)reader[((int)FeeAccntYearColumn.YearToDt - 1)];
			entity.YearNote = (reader.IsDBNull(((int)FeeAccntYearColumn.YearNote - 1)))?null:(System.String)reader[((int)FeeAccntYearColumn.YearNote - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYear"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeAccntYear"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeAccntYear entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeAccntYearId = (System.Decimal)dataRow["FEE_ACCNT_YEAR_ID"];
			entity.OriginalFeeAccntYearId = (System.Decimal)dataRow["FEE_ACCNT_YEAR_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.YearFromDt = (System.DateTime)dataRow["YEAR_FROM_DT"];
			entity.YearToDt = (System.DateTime)dataRow["YEAR_TO_DT"];
			entity.YearNote = Convert.IsDBNull(dataRow["YEAR_NOTE"]) ? null : (System.String)dataRow["YEAR_NOTE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeAccntYear"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeAccntYear Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeAccntYear entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdAcadYearId;
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeAccntYearId methods when available
			
			#region FeeAccntYearPeriodCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeAccntYearPeriod>|FeeAccntYearPeriodCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeAccntYearPeriodCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeAccntYearPeriodCollection = DataRepository.FeeAccntYearPeriodProvider.GetByFeeAccntYearId(transactionManager, entity.FeeAccntYearId);

				if (deep && entity.FeeAccntYearPeriodCollection.Count > 0)
				{
					deepHandles.Add("FeeAccntYearPeriodCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeAccntYearPeriod>) DataRepository.FeeAccntYearPeriodProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeAccntYearPeriodCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeAccntYear object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeAccntYear instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeAccntYear Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeAccntYear entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<FeeAccntYearPeriod>
				if (CanDeepSave(entity.FeeAccntYearPeriodCollection, "List<FeeAccntYearPeriod>|FeeAccntYearPeriodCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeAccntYearPeriod child in entity.FeeAccntYearPeriodCollection)
					{
						if(child.FeeAccntYearIdSource != null)
						{
							child.FeeAccntYearId = child.FeeAccntYearIdSource.FeeAccntYearId;
						}
						else
						{
							child.FeeAccntYearId = entity.FeeAccntYearId;
						}

					}

					if (entity.FeeAccntYearPeriodCollection.Count > 0 || entity.FeeAccntYearPeriodCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeAccntYearPeriodProvider.Save(transactionManager, entity.FeeAccntYearPeriodCollection);
						
						deepHandles.Add("FeeAccntYearPeriodCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeAccntYearPeriod >) DataRepository.FeeAccntYearPeriodProvider.DeepSave,
							new object[] { transactionManager, entity.FeeAccntYearPeriodCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeAccntYearChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeAccntYear</c>
	///</summary>
	public enum FeeAccntYearChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		///<summary>
		/// Collection of <c>FeeAccntYear</c> as OneToMany for FeeAccntYearPeriodCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeAccntYearPeriod>))]
		FeeAccntYearPeriodCollection,
	}
	
	#endregion FeeAccntYearChildEntityTypes
	
	#region FeeAccntYearFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeAccntYearColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeAccntYear"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeAccntYearFilterBuilder : SqlFilterBuilder<FeeAccntYearColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeAccntYearFilterBuilder class.
		/// </summary>
		public FeeAccntYearFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeAccntYearFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeAccntYearFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeAccntYearFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeAccntYearFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeAccntYearFilterBuilder
	
	#region FeeAccntYearParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeAccntYearColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeAccntYear"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeAccntYearParameterBuilder : ParameterizedSqlFilterBuilder<FeeAccntYearColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeAccntYearParameterBuilder class.
		/// </summary>
		public FeeAccntYearParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeAccntYearParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeAccntYearParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeAccntYearParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeAccntYearParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeAccntYearParameterBuilder
	
	#region FeeAccntYearSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeAccntYearColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeAccntYear"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeAccntYearSortBuilder : SqlSortBuilder<FeeAccntYearColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeAccntYearSqlSortBuilder class.
		/// </summary>
		public FeeAccntYearSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeAccntYearSortBuilder
	
} // end namespace
