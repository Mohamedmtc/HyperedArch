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
	/// This class is the base class for any <see cref="EdAbsenceApproveProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdAbsenceApproveProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdAbsenceApprove, UMIS_VER2.BusinessLyer.EdAbsenceApproveKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAbsenceApproveKey key)
		{
			return Delete(transactionManager, key.EdAbsenceApproveId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edAbsenceApproveId">اعتماد يوم غياب لسكشن. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edAbsenceApproveId)
		{
			return Delete(null, _edAbsenceApproveId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAbsenceApproveId">اعتماد يوم غياب لسكشن. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edAbsenceApproveId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ABSENCE_APPROVE_SC_SCHEDULE_DTL_DAY key.
		///		FK_ED_ABSENCE_APPROVE_SC_SCHEDULE_DTL_DAY Description: 
		/// </summary>
		/// <param name="_scScheduleDtlDayId">سكشن-يوم-محاضرة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAbsenceApprove objects.</returns>
		public TList<EdAbsenceApprove> GetByScScheduleDtlDayId(System.Decimal? _scScheduleDtlDayId)
		{
			int count = -1;
			return GetByScScheduleDtlDayId(_scScheduleDtlDayId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ABSENCE_APPROVE_SC_SCHEDULE_DTL_DAY key.
		///		FK_ED_ABSENCE_APPROVE_SC_SCHEDULE_DTL_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayId">سكشن-يوم-محاضرة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAbsenceApprove objects.</returns>
		/// <remarks></remarks>
		public TList<EdAbsenceApprove> GetByScScheduleDtlDayId(TransactionManager transactionManager, System.Decimal? _scScheduleDtlDayId)
		{
			int count = -1;
			return GetByScScheduleDtlDayId(transactionManager, _scScheduleDtlDayId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ABSENCE_APPROVE_SC_SCHEDULE_DTL_DAY key.
		///		FK_ED_ABSENCE_APPROVE_SC_SCHEDULE_DTL_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayId">سكشن-يوم-محاضرة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAbsenceApprove objects.</returns>
		public TList<EdAbsenceApprove> GetByScScheduleDtlDayId(TransactionManager transactionManager, System.Decimal? _scScheduleDtlDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlDayId(transactionManager, _scScheduleDtlDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ABSENCE_APPROVE_SC_SCHEDULE_DTL_DAY key.
		///		fkEdAbsenceApproveScScheduleDtlDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlDayId">سكشن-يوم-محاضرة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAbsenceApprove objects.</returns>
		public TList<EdAbsenceApprove> GetByScScheduleDtlDayId(System.Decimal? _scScheduleDtlDayId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScScheduleDtlDayId(null, _scScheduleDtlDayId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ABSENCE_APPROVE_SC_SCHEDULE_DTL_DAY key.
		///		fkEdAbsenceApproveScScheduleDtlDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlDayId">سكشن-يوم-محاضرة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAbsenceApprove objects.</returns>
		public TList<EdAbsenceApprove> GetByScScheduleDtlDayId(System.Decimal? _scScheduleDtlDayId, int start, int pageLength,out int count)
		{
			return GetByScScheduleDtlDayId(null, _scScheduleDtlDayId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ABSENCE_APPROVE_SC_SCHEDULE_DTL_DAY key.
		///		FK_ED_ABSENCE_APPROVE_SC_SCHEDULE_DTL_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayId">سكشن-يوم-محاضرة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAbsenceApprove objects.</returns>
		public abstract TList<EdAbsenceApprove> GetByScScheduleDtlDayId(TransactionManager transactionManager, System.Decimal? _scScheduleDtlDayId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdAbsenceApprove Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAbsenceApproveKey key, int start, int pageLength)
		{
			return GetByEdAbsenceApproveId(transactionManager, key.EdAbsenceApproveId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_ABSENCE_APPROVE index.
		/// </summary>
		/// <param name="_edAbsenceApproveId">اعتماد يوم غياب لسكشن</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAbsenceApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAbsenceApprove GetByEdAbsenceApproveId(System.Decimal _edAbsenceApproveId)
		{
			int count = -1;
			return GetByEdAbsenceApproveId(null,_edAbsenceApproveId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ABSENCE_APPROVE index.
		/// </summary>
		/// <param name="_edAbsenceApproveId">اعتماد يوم غياب لسكشن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAbsenceApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAbsenceApprove GetByEdAbsenceApproveId(System.Decimal _edAbsenceApproveId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAbsenceApproveId(null, _edAbsenceApproveId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ABSENCE_APPROVE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAbsenceApproveId">اعتماد يوم غياب لسكشن</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAbsenceApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAbsenceApprove GetByEdAbsenceApproveId(TransactionManager transactionManager, System.Decimal _edAbsenceApproveId)
		{
			int count = -1;
			return GetByEdAbsenceApproveId(transactionManager, _edAbsenceApproveId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ABSENCE_APPROVE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAbsenceApproveId">اعتماد يوم غياب لسكشن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAbsenceApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAbsenceApprove GetByEdAbsenceApproveId(TransactionManager transactionManager, System.Decimal _edAbsenceApproveId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAbsenceApproveId(transactionManager, _edAbsenceApproveId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ABSENCE_APPROVE index.
		/// </summary>
		/// <param name="_edAbsenceApproveId">اعتماد يوم غياب لسكشن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAbsenceApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAbsenceApprove GetByEdAbsenceApproveId(System.Decimal _edAbsenceApproveId, int start, int pageLength, out int count)
		{
			return GetByEdAbsenceApproveId(null, _edAbsenceApproveId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ABSENCE_APPROVE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAbsenceApproveId">اعتماد يوم غياب لسكشن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAbsenceApprove"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdAbsenceApprove GetByEdAbsenceApproveId(TransactionManager transactionManager, System.Decimal _edAbsenceApproveId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdAbsenceApprove&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdAbsenceApprove&gt;"/></returns>
		public static TList<EdAbsenceApprove> Fill(IDataReader reader, TList<EdAbsenceApprove> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdAbsenceApprove c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdAbsenceApprove")
					.Append("|").Append((System.Decimal)reader["ED_ABSENCE_APPROVE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdAbsenceApprove>(
					key.ToString(), // EntityTrackingKey
					"EdAbsenceApprove",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdAbsenceApprove();
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
					c.EdAbsenceApproveId = (System.Decimal)reader["ED_ABSENCE_APPROVE_ID"];
					c.OriginalEdAbsenceApproveId = c.EdAbsenceApproveId;
					c.ScScheduleDtlDayId = Convert.IsDBNull(reader["SC_SCHEDULE_DTL_DAY_ID"]) ? null : (System.Decimal?)reader["SC_SCHEDULE_DTL_DAY_ID"];
					c.AbsDate = (System.DateTime)reader["ABS_DATE"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Boolean?)reader["APPROVE_FLG"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdAbsenceApprove"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdAbsenceApprove"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdAbsenceApprove entity)
		{
			if (!reader.Read()) return;
			
			entity.EdAbsenceApproveId = (System.Decimal)reader[((int)EdAbsenceApproveColumn.EdAbsenceApproveId - 1)];
			entity.OriginalEdAbsenceApproveId = (System.Decimal)reader["ED_ABSENCE_APPROVE_ID"];
			entity.ScScheduleDtlDayId = (reader.IsDBNull(((int)EdAbsenceApproveColumn.ScScheduleDtlDayId - 1)))?null:(System.Decimal?)reader[((int)EdAbsenceApproveColumn.ScScheduleDtlDayId - 1)];
			entity.AbsDate = (System.DateTime)reader[((int)EdAbsenceApproveColumn.AbsDate - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)EdAbsenceApproveColumn.ApproveFlg - 1)))?null:(System.Boolean?)reader[((int)EdAbsenceApproveColumn.ApproveFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdAbsenceApproveColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdAbsenceApproveColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdAbsenceApproveColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdAbsenceApproveColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdAbsenceApprove"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdAbsenceApprove"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdAbsenceApprove entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdAbsenceApproveId = (System.Decimal)dataRow["ED_ABSENCE_APPROVE_ID"];
			entity.OriginalEdAbsenceApproveId = (System.Decimal)dataRow["ED_ABSENCE_APPROVE_ID"];
			entity.ScScheduleDtlDayId = Convert.IsDBNull(dataRow["SC_SCHEDULE_DTL_DAY_ID"]) ? null : (System.Decimal?)dataRow["SC_SCHEDULE_DTL_DAY_ID"];
			entity.AbsDate = (System.DateTime)dataRow["ABS_DATE"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Boolean?)dataRow["APPROVE_FLG"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdAbsenceApprove"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdAbsenceApprove Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAbsenceApprove entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region ScScheduleDtlDayIdSource	
			if (CanDeepLoad(entity, "ScScheduleDtlDay|ScScheduleDtlDayIdSource", deepLoadType, innerList) 
				&& entity.ScScheduleDtlDayIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScScheduleDtlDayId ?? 0.0m);
				ScScheduleDtlDay tmpEntity = EntityManager.LocateEntity<ScScheduleDtlDay>(EntityLocator.ConstructKeyFromPkItems(typeof(ScScheduleDtlDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScScheduleDtlDayIdSource = tmpEntity;
				else
					entity.ScScheduleDtlDayIdSource = DataRepository.ScScheduleDtlDayProvider.GetByScScheduleDtlDayId(transactionManager, (entity.ScScheduleDtlDayId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlDayIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScScheduleDtlDayIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScScheduleDtlDayProvider.DeepLoad(transactionManager, entity.ScScheduleDtlDayIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScScheduleDtlDayIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdAbsenceApprove object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdAbsenceApprove instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdAbsenceApprove Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAbsenceApprove entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region ScScheduleDtlDayIdSource
			if (CanDeepSave(entity, "ScScheduleDtlDay|ScScheduleDtlDayIdSource", deepSaveType, innerList) 
				&& entity.ScScheduleDtlDayIdSource != null)
			{
				DataRepository.ScScheduleDtlDayProvider.Save(transactionManager, entity.ScScheduleDtlDayIdSource);
				entity.ScScheduleDtlDayId = entity.ScScheduleDtlDayIdSource.ScScheduleDtlDayId;
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
	
	#region EdAbsenceApproveChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdAbsenceApprove</c>
	///</summary>
	public enum EdAbsenceApproveChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>ScScheduleDtlDay</c> at ScScheduleDtlDayIdSource
		///</summary>
		[ChildEntityType(typeof(ScScheduleDtlDay))]
		ScScheduleDtlDay,
	}
	
	#endregion EdAbsenceApproveChildEntityTypes
	
	#region EdAbsenceApproveFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdAbsenceApproveColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdAbsenceApprove"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdAbsenceApproveFilterBuilder : SqlFilterBuilder<EdAbsenceApproveColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdAbsenceApproveFilterBuilder class.
		/// </summary>
		public EdAbsenceApproveFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdAbsenceApproveFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdAbsenceApproveFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdAbsenceApproveFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdAbsenceApproveFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdAbsenceApproveFilterBuilder
	
	#region EdAbsenceApproveParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdAbsenceApproveColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdAbsenceApprove"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdAbsenceApproveParameterBuilder : ParameterizedSqlFilterBuilder<EdAbsenceApproveColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdAbsenceApproveParameterBuilder class.
		/// </summary>
		public EdAbsenceApproveParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdAbsenceApproveParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdAbsenceApproveParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdAbsenceApproveParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdAbsenceApproveParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdAbsenceApproveParameterBuilder
	
	#region EdAbsenceApproveSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdAbsenceApproveColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdAbsenceApprove"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdAbsenceApproveSortBuilder : SqlSortBuilder<EdAbsenceApproveColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdAbsenceApproveSqlSortBuilder class.
		/// </summary>
		public EdAbsenceApproveSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdAbsenceApproveSortBuilder
	
} // end namespace
