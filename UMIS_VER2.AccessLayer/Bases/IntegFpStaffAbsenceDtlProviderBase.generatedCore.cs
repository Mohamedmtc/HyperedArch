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
	/// This class is the base class for any <see cref="IntegFpStaffAbsenceDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class IntegFpStaffAbsenceDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl, UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtlKey key)
		{
			return Delete(transactionManager, key.IntegFpStaffAbsenceDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_integFpStaffAbsenceDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _integFpStaffAbsenceDtlId)
		{
			return Delete(null, _integFpStaffAbsenceDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integFpStaffAbsenceDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _integFpStaffAbsenceDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_FP_STAFF_ABSENCE_DTL_INTEG_FP_STAFF_ABSENCE key.
		///		FK_INTEG_FP_STAFF_ABSENCE_DTL_INTEG_FP_STAFF_ABSENCE Description: 
		/// </summary>
		/// <param name="_integFpStaffAbsenceId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl objects.</returns>
		public TList<IntegFpStaffAbsenceDtl> GetByIntegFpStaffAbsenceId(System.Decimal _integFpStaffAbsenceId)
		{
			int count = -1;
			return GetByIntegFpStaffAbsenceId(_integFpStaffAbsenceId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_FP_STAFF_ABSENCE_DTL_INTEG_FP_STAFF_ABSENCE key.
		///		FK_INTEG_FP_STAFF_ABSENCE_DTL_INTEG_FP_STAFF_ABSENCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integFpStaffAbsenceId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl objects.</returns>
		/// <remarks></remarks>
		public TList<IntegFpStaffAbsenceDtl> GetByIntegFpStaffAbsenceId(TransactionManager transactionManager, System.Decimal _integFpStaffAbsenceId)
		{
			int count = -1;
			return GetByIntegFpStaffAbsenceId(transactionManager, _integFpStaffAbsenceId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_FP_STAFF_ABSENCE_DTL_INTEG_FP_STAFF_ABSENCE key.
		///		FK_INTEG_FP_STAFF_ABSENCE_DTL_INTEG_FP_STAFF_ABSENCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integFpStaffAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl objects.</returns>
		public TList<IntegFpStaffAbsenceDtl> GetByIntegFpStaffAbsenceId(TransactionManager transactionManager, System.Decimal _integFpStaffAbsenceId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegFpStaffAbsenceId(transactionManager, _integFpStaffAbsenceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_FP_STAFF_ABSENCE_DTL_INTEG_FP_STAFF_ABSENCE key.
		///		fkIntegFpStaffAbsenceDtlIntegFpStaffAbsence Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_integFpStaffAbsenceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl objects.</returns>
		public TList<IntegFpStaffAbsenceDtl> GetByIntegFpStaffAbsenceId(System.Decimal _integFpStaffAbsenceId, int start, int pageLength)
		{
			int count =  -1;
			return GetByIntegFpStaffAbsenceId(null, _integFpStaffAbsenceId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_FP_STAFF_ABSENCE_DTL_INTEG_FP_STAFF_ABSENCE key.
		///		fkIntegFpStaffAbsenceDtlIntegFpStaffAbsence Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_integFpStaffAbsenceId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl objects.</returns>
		public TList<IntegFpStaffAbsenceDtl> GetByIntegFpStaffAbsenceId(System.Decimal _integFpStaffAbsenceId, int start, int pageLength,out int count)
		{
			return GetByIntegFpStaffAbsenceId(null, _integFpStaffAbsenceId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_FP_STAFF_ABSENCE_DTL_INTEG_FP_STAFF_ABSENCE key.
		///		FK_INTEG_FP_STAFF_ABSENCE_DTL_INTEG_FP_STAFF_ABSENCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integFpStaffAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl objects.</returns>
		public abstract TList<IntegFpStaffAbsenceDtl> GetByIntegFpStaffAbsenceId(TransactionManager transactionManager, System.Decimal _integFpStaffAbsenceId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtlKey key, int start, int pageLength)
		{
			return GetByIntegFpStaffAbsenceDtlId(transactionManager, key.IntegFpStaffAbsenceDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__INTEG_FP__7E6CE28E6974F4B9 index.
		/// </summary>
		/// <param name="_integFpStaffAbsenceDtlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl GetByIntegFpStaffAbsenceDtlId(System.Decimal _integFpStaffAbsenceDtlId)
		{
			int count = -1;
			return GetByIntegFpStaffAbsenceDtlId(null,_integFpStaffAbsenceDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__INTEG_FP__7E6CE28E6974F4B9 index.
		/// </summary>
		/// <param name="_integFpStaffAbsenceDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl GetByIntegFpStaffAbsenceDtlId(System.Decimal _integFpStaffAbsenceDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegFpStaffAbsenceDtlId(null, _integFpStaffAbsenceDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__INTEG_FP__7E6CE28E6974F4B9 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integFpStaffAbsenceDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl GetByIntegFpStaffAbsenceDtlId(TransactionManager transactionManager, System.Decimal _integFpStaffAbsenceDtlId)
		{
			int count = -1;
			return GetByIntegFpStaffAbsenceDtlId(transactionManager, _integFpStaffAbsenceDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__INTEG_FP__7E6CE28E6974F4B9 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integFpStaffAbsenceDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl GetByIntegFpStaffAbsenceDtlId(TransactionManager transactionManager, System.Decimal _integFpStaffAbsenceDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegFpStaffAbsenceDtlId(transactionManager, _integFpStaffAbsenceDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__INTEG_FP__7E6CE28E6974F4B9 index.
		/// </summary>
		/// <param name="_integFpStaffAbsenceDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl GetByIntegFpStaffAbsenceDtlId(System.Decimal _integFpStaffAbsenceDtlId, int start, int pageLength, out int count)
		{
			return GetByIntegFpStaffAbsenceDtlId(null, _integFpStaffAbsenceDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__INTEG_FP__7E6CE28E6974F4B9 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integFpStaffAbsenceDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl GetByIntegFpStaffAbsenceDtlId(TransactionManager transactionManager, System.Decimal _integFpStaffAbsenceDtlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;IntegFpStaffAbsenceDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;IntegFpStaffAbsenceDtl&gt;"/></returns>
		public static TList<IntegFpStaffAbsenceDtl> Fill(IDataReader reader, TList<IntegFpStaffAbsenceDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("IntegFpStaffAbsenceDtl")
					.Append("|").Append((System.Decimal)reader["INTEG_FP_STAFF_ABSENCE_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<IntegFpStaffAbsenceDtl>(
					key.ToString(), // EntityTrackingKey
					"IntegFpStaffAbsenceDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl();
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
					c.IntegFpStaffAbsenceDtlId = (System.Decimal)reader["INTEG_FP_STAFF_ABSENCE_DTL_ID"];
					c.IntegFpStaffAbsenceId = (System.Decimal)reader["INTEG_FP_STAFF_ABSENCE_ID"];
					c.ScSchdlSlotId = Convert.IsDBNull(reader["SC_SCHDL_SLOT_ID"]) ? null : (System.Decimal?)reader["SC_SCHDL_SLOT_ID"];
					c.ScScheduleDtlDayId = Convert.IsDBNull(reader["SC_SCHEDULE_DTL_DAY_ID"]) ? null : (System.Decimal?)reader["SC_SCHEDULE_DTL_DAY_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.IntegFpStaffAbsenceDtlId = (System.Decimal)reader[((int)IntegFpStaffAbsenceDtlColumn.IntegFpStaffAbsenceDtlId - 1)];
			entity.IntegFpStaffAbsenceId = (System.Decimal)reader[((int)IntegFpStaffAbsenceDtlColumn.IntegFpStaffAbsenceId - 1)];
			entity.ScSchdlSlotId = (reader.IsDBNull(((int)IntegFpStaffAbsenceDtlColumn.ScSchdlSlotId - 1)))?null:(System.Decimal?)reader[((int)IntegFpStaffAbsenceDtlColumn.ScSchdlSlotId - 1)];
			entity.ScScheduleDtlDayId = (reader.IsDBNull(((int)IntegFpStaffAbsenceDtlColumn.ScScheduleDtlDayId - 1)))?null:(System.Decimal?)reader[((int)IntegFpStaffAbsenceDtlColumn.ScScheduleDtlDayId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.IntegFpStaffAbsenceDtlId = (System.Decimal)dataRow["INTEG_FP_STAFF_ABSENCE_DTL_ID"];
			entity.IntegFpStaffAbsenceId = (System.Decimal)dataRow["INTEG_FP_STAFF_ABSENCE_ID"];
			entity.ScSchdlSlotId = Convert.IsDBNull(dataRow["SC_SCHDL_SLOT_ID"]) ? null : (System.Decimal?)dataRow["SC_SCHDL_SLOT_ID"];
			entity.ScScheduleDtlDayId = Convert.IsDBNull(dataRow["SC_SCHEDULE_DTL_DAY_ID"]) ? null : (System.Decimal?)dataRow["SC_SCHEDULE_DTL_DAY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region IntegFpStaffAbsenceIdSource	
			if (CanDeepLoad(entity, "IntegFpStaffAbsence|IntegFpStaffAbsenceIdSource", deepLoadType, innerList) 
				&& entity.IntegFpStaffAbsenceIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.IntegFpStaffAbsenceId;
				IntegFpStaffAbsence tmpEntity = EntityManager.LocateEntity<IntegFpStaffAbsence>(EntityLocator.ConstructKeyFromPkItems(typeof(IntegFpStaffAbsence), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.IntegFpStaffAbsenceIdSource = tmpEntity;
				else
					entity.IntegFpStaffAbsenceIdSource = DataRepository.IntegFpStaffAbsenceProvider.GetByIntegFpStaffAbsenceId(transactionManager, entity.IntegFpStaffAbsenceId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'IntegFpStaffAbsenceIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.IntegFpStaffAbsenceIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.IntegFpStaffAbsenceProvider.DeepLoad(transactionManager, entity.IntegFpStaffAbsenceIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion IntegFpStaffAbsenceIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region IntegFpStaffAbsenceIdSource
			if (CanDeepSave(entity, "IntegFpStaffAbsence|IntegFpStaffAbsenceIdSource", deepSaveType, innerList) 
				&& entity.IntegFpStaffAbsenceIdSource != null)
			{
				DataRepository.IntegFpStaffAbsenceProvider.Save(transactionManager, entity.IntegFpStaffAbsenceIdSource);
				entity.IntegFpStaffAbsenceId = entity.IntegFpStaffAbsenceIdSource.IntegFpStaffAbsenceId;
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
	
	#region IntegFpStaffAbsenceDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceDtl</c>
	///</summary>
	public enum IntegFpStaffAbsenceDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>IntegFpStaffAbsence</c> at IntegFpStaffAbsenceIdSource
		///</summary>
		[ChildEntityType(typeof(IntegFpStaffAbsence))]
		IntegFpStaffAbsence,
	}
	
	#endregion IntegFpStaffAbsenceDtlChildEntityTypes
	
	#region IntegFpStaffAbsenceDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;IntegFpStaffAbsenceDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegFpStaffAbsenceDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegFpStaffAbsenceDtlFilterBuilder : SqlFilterBuilder<IntegFpStaffAbsenceDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegFpStaffAbsenceDtlFilterBuilder class.
		/// </summary>
		public IntegFpStaffAbsenceDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegFpStaffAbsenceDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegFpStaffAbsenceDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegFpStaffAbsenceDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegFpStaffAbsenceDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegFpStaffAbsenceDtlFilterBuilder
	
	#region IntegFpStaffAbsenceDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;IntegFpStaffAbsenceDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegFpStaffAbsenceDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegFpStaffAbsenceDtlParameterBuilder : ParameterizedSqlFilterBuilder<IntegFpStaffAbsenceDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegFpStaffAbsenceDtlParameterBuilder class.
		/// </summary>
		public IntegFpStaffAbsenceDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegFpStaffAbsenceDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegFpStaffAbsenceDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegFpStaffAbsenceDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegFpStaffAbsenceDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegFpStaffAbsenceDtlParameterBuilder
	
	#region IntegFpStaffAbsenceDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;IntegFpStaffAbsenceDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegFpStaffAbsenceDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class IntegFpStaffAbsenceDtlSortBuilder : SqlSortBuilder<IntegFpStaffAbsenceDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegFpStaffAbsenceDtlSqlSortBuilder class.
		/// </summary>
		public IntegFpStaffAbsenceDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion IntegFpStaffAbsenceDtlSortBuilder
	
} // end namespace
