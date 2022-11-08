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
	/// This class is the base class for any <see cref="GsCodePayMthdTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodePayMthdTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodePayMthdType, UMIS_VER2.BusinessLyer.GsCodePayMthdTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodePayMthdTypeKey key)
		{
			return Delete(transactionManager, key.GsCodePayMthdTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodePayMthdTypeId">KU. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _gsCodePayMthdTypeId)
		{
			return Delete(null, _gsCodePayMthdTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMthdTypeId">KU. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _gsCodePayMthdTypeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_PAY_MTHD_TYPE_GS_CODE_PAY_METHOD key.
		///		FK_GS_CODE_PAY_MTHD_TYPE_GS_CODE_PAY_METHOD Description: 
		/// </summary>
		/// <param name="_gsCodePayMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodePayMthdType objects.</returns>
		public TList<GsCodePayMthdType> GetByGsCodePayMethodId(System.Decimal _gsCodePayMethodId)
		{
			int count = -1;
			return GetByGsCodePayMethodId(_gsCodePayMethodId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_PAY_MTHD_TYPE_GS_CODE_PAY_METHOD key.
		///		FK_GS_CODE_PAY_MTHD_TYPE_GS_CODE_PAY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodePayMthdType objects.</returns>
		/// <remarks></remarks>
		public TList<GsCodePayMthdType> GetByGsCodePayMethodId(TransactionManager transactionManager, System.Decimal _gsCodePayMethodId)
		{
			int count = -1;
			return GetByGsCodePayMethodId(transactionManager, _gsCodePayMethodId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_PAY_MTHD_TYPE_GS_CODE_PAY_METHOD key.
		///		FK_GS_CODE_PAY_MTHD_TYPE_GS_CODE_PAY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodePayMthdType objects.</returns>
		public TList<GsCodePayMthdType> GetByGsCodePayMethodId(TransactionManager transactionManager, System.Decimal _gsCodePayMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePayMethodId(transactionManager, _gsCodePayMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_PAY_MTHD_TYPE_GS_CODE_PAY_METHOD key.
		///		fkGsCodePayMthdTypeGsCodePayMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodePayMthdType objects.</returns>
		public TList<GsCodePayMthdType> GetByGsCodePayMethodId(System.Decimal _gsCodePayMethodId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodePayMethodId(null, _gsCodePayMethodId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_PAY_MTHD_TYPE_GS_CODE_PAY_METHOD key.
		///		fkGsCodePayMthdTypeGsCodePayMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodePayMthdType objects.</returns>
		public TList<GsCodePayMthdType> GetByGsCodePayMethodId(System.Decimal _gsCodePayMethodId, int start, int pageLength,out int count)
		{
			return GetByGsCodePayMethodId(null, _gsCodePayMethodId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_PAY_MTHD_TYPE_GS_CODE_PAY_METHOD key.
		///		FK_GS_CODE_PAY_MTHD_TYPE_GS_CODE_PAY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodePayMthdType objects.</returns>
		public abstract TList<GsCodePayMthdType> GetByGsCodePayMethodId(TransactionManager transactionManager, System.Decimal _gsCodePayMethodId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsCodePayMthdType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodePayMthdTypeKey key, int start, int pageLength)
		{
			return GetByGsCodePayMthdTypeId(transactionManager, key.GsCodePayMthdTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_PAY_MTHD_TYPE index.
		/// </summary>
		/// <param name="_gsCodePayMthdTypeId">KU</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodePayMthdType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodePayMthdType GetByGsCodePayMthdTypeId(System.Int32 _gsCodePayMthdTypeId)
		{
			int count = -1;
			return GetByGsCodePayMthdTypeId(null,_gsCodePayMthdTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_PAY_MTHD_TYPE index.
		/// </summary>
		/// <param name="_gsCodePayMthdTypeId">KU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodePayMthdType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodePayMthdType GetByGsCodePayMthdTypeId(System.Int32 _gsCodePayMthdTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePayMthdTypeId(null, _gsCodePayMthdTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_PAY_MTHD_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMthdTypeId">KU</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodePayMthdType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodePayMthdType GetByGsCodePayMthdTypeId(TransactionManager transactionManager, System.Int32 _gsCodePayMthdTypeId)
		{
			int count = -1;
			return GetByGsCodePayMthdTypeId(transactionManager, _gsCodePayMthdTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_PAY_MTHD_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMthdTypeId">KU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodePayMthdType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodePayMthdType GetByGsCodePayMthdTypeId(TransactionManager transactionManager, System.Int32 _gsCodePayMthdTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePayMthdTypeId(transactionManager, _gsCodePayMthdTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_PAY_MTHD_TYPE index.
		/// </summary>
		/// <param name="_gsCodePayMthdTypeId">KU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodePayMthdType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodePayMthdType GetByGsCodePayMthdTypeId(System.Int32 _gsCodePayMthdTypeId, int start, int pageLength, out int count)
		{
			return GetByGsCodePayMthdTypeId(null, _gsCodePayMthdTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_PAY_MTHD_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMthdTypeId">KU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodePayMthdType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodePayMthdType GetByGsCodePayMthdTypeId(TransactionManager transactionManager, System.Int32 _gsCodePayMthdTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodePayMthdType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodePayMthdType&gt;"/></returns>
		public static TList<GsCodePayMthdType> Fill(IDataReader reader, TList<GsCodePayMthdType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodePayMthdType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodePayMthdType")
					.Append("|").Append((System.Int32)reader["GS_CODE_PAY_MTHD_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodePayMthdType>(
					key.ToString(), // EntityTrackingKey
					"GsCodePayMthdType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodePayMthdType();
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
					c.GsCodePayMthdTypeId = (System.Int32)reader["GS_CODE_PAY_MTHD_TYPE_ID"];
					c.OriginalGsCodePayMthdTypeId = c.GsCodePayMthdTypeId;
					c.GsCodePayMethodId = (System.Decimal)reader["GS_CODE_PAY_METHOD_ID"];
					c.PayMthdTypeAr = Convert.IsDBNull(reader["PAY_MTHD_TYPE_AR"]) ? null : (System.String)reader["PAY_MTHD_TYPE_AR"];
					c.PayMthdTypeEn = Convert.IsDBNull(reader["PAY_MTHD_TYPE_EN"]) ? null : (System.String)reader["PAY_MTHD_TYPE_EN"];
					c.AccNo = Convert.IsDBNull(reader["ACC_NO"]) ? null : (System.String)reader["ACC_NO"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodePayMthdType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodePayMthdType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodePayMthdType entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodePayMthdTypeId = (System.Int32)reader[((int)GsCodePayMthdTypeColumn.GsCodePayMthdTypeId - 1)];
			entity.OriginalGsCodePayMthdTypeId = (System.Int32)reader["GS_CODE_PAY_MTHD_TYPE_ID"];
			entity.GsCodePayMethodId = (System.Decimal)reader[((int)GsCodePayMthdTypeColumn.GsCodePayMethodId - 1)];
			entity.PayMthdTypeAr = (reader.IsDBNull(((int)GsCodePayMthdTypeColumn.PayMthdTypeAr - 1)))?null:(System.String)reader[((int)GsCodePayMthdTypeColumn.PayMthdTypeAr - 1)];
			entity.PayMthdTypeEn = (reader.IsDBNull(((int)GsCodePayMthdTypeColumn.PayMthdTypeEn - 1)))?null:(System.String)reader[((int)GsCodePayMthdTypeColumn.PayMthdTypeEn - 1)];
			entity.AccNo = (reader.IsDBNull(((int)GsCodePayMthdTypeColumn.AccNo - 1)))?null:(System.String)reader[((int)GsCodePayMthdTypeColumn.AccNo - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodePayMthdType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodePayMthdType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodePayMthdType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodePayMthdTypeId = (System.Int32)dataRow["GS_CODE_PAY_MTHD_TYPE_ID"];
			entity.OriginalGsCodePayMthdTypeId = (System.Int32)dataRow["GS_CODE_PAY_MTHD_TYPE_ID"];
			entity.GsCodePayMethodId = (System.Decimal)dataRow["GS_CODE_PAY_METHOD_ID"];
			entity.PayMthdTypeAr = Convert.IsDBNull(dataRow["PAY_MTHD_TYPE_AR"]) ? null : (System.String)dataRow["PAY_MTHD_TYPE_AR"];
			entity.PayMthdTypeEn = Convert.IsDBNull(dataRow["PAY_MTHD_TYPE_EN"]) ? null : (System.String)dataRow["PAY_MTHD_TYPE_EN"];
			entity.AccNo = Convert.IsDBNull(dataRow["ACC_NO"]) ? null : (System.String)dataRow["ACC_NO"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodePayMthdType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodePayMthdType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodePayMthdType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCodePayMethodIdSource	
			if (CanDeepLoad(entity, "GsCodePayMethod|GsCodePayMethodIdSource", deepLoadType, innerList) 
				&& entity.GsCodePayMethodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodePayMethodId;
				GsCodePayMethod tmpEntity = EntityManager.LocateEntity<GsCodePayMethod>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodePayMethod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodePayMethodIdSource = tmpEntity;
				else
					entity.GsCodePayMethodIdSource = DataRepository.GsCodePayMethodProvider.GetByGsCodePayMethodId(transactionManager, entity.GsCodePayMethodId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodePayMethodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodePayMethodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodePayMethodProvider.DeepLoad(transactionManager, entity.GsCodePayMethodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodePayMethodIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodePayMthdTypeId methods when available
			
			#region FeeStudVoucherPayMthodCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucherPayMthod>|FeeStudVoucherPayMthodCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherPayMthodCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherPayMthodCollection = DataRepository.FeeStudVoucherPayMthodProvider.GetByGsCodePayMthdTypeId(transactionManager, entity.GsCodePayMthdTypeId);

				if (deep && entity.FeeStudVoucherPayMthodCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherPayMthodCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucherPayMthod>) DataRepository.FeeStudVoucherPayMthodProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherPayMthodCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodePayMthdType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodePayMthdType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodePayMthdType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodePayMthdType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCodePayMethodIdSource
			if (CanDeepSave(entity, "GsCodePayMethod|GsCodePayMethodIdSource", deepSaveType, innerList) 
				&& entity.GsCodePayMethodIdSource != null)
			{
				DataRepository.GsCodePayMethodProvider.Save(transactionManager, entity.GsCodePayMethodIdSource);
				entity.GsCodePayMethodId = entity.GsCodePayMethodIdSource.GsCodePayMethodId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<FeeStudVoucherPayMthod>
				if (CanDeepSave(entity.FeeStudVoucherPayMthodCollection, "List<FeeStudVoucherPayMthod>|FeeStudVoucherPayMthodCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucherPayMthod child in entity.FeeStudVoucherPayMthodCollection)
					{
						if(child.GsCodePayMthdTypeIdSource != null)
						{
							child.GsCodePayMthdTypeId = child.GsCodePayMthdTypeIdSource.GsCodePayMthdTypeId;
						}
						else
						{
							child.GsCodePayMthdTypeId = entity.GsCodePayMthdTypeId;
						}

					}

					if (entity.FeeStudVoucherPayMthodCollection.Count > 0 || entity.FeeStudVoucherPayMthodCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudVoucherPayMthodProvider.Save(transactionManager, entity.FeeStudVoucherPayMthodCollection);
						
						deepHandles.Add("FeeStudVoucherPayMthodCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudVoucherPayMthod >) DataRepository.FeeStudVoucherPayMthodProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudVoucherPayMthodCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCodePayMthdTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodePayMthdType</c>
	///</summary>
	public enum GsCodePayMthdTypeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCodePayMethod</c> at GsCodePayMethodIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodePayMethod))]
		GsCodePayMethod,
		///<summary>
		/// Collection of <c>GsCodePayMthdType</c> as OneToMany for FeeStudVoucherPayMthodCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucherPayMthod>))]
		FeeStudVoucherPayMthodCollection,
	}
	
	#endregion GsCodePayMthdTypeChildEntityTypes
	
	#region GsCodePayMthdTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodePayMthdTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodePayMthdType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodePayMthdTypeFilterBuilder : SqlFilterBuilder<GsCodePayMthdTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodePayMthdTypeFilterBuilder class.
		/// </summary>
		public GsCodePayMthdTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodePayMthdTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodePayMthdTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodePayMthdTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodePayMthdTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodePayMthdTypeFilterBuilder
	
	#region GsCodePayMthdTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodePayMthdTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodePayMthdType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodePayMthdTypeParameterBuilder : ParameterizedSqlFilterBuilder<GsCodePayMthdTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodePayMthdTypeParameterBuilder class.
		/// </summary>
		public GsCodePayMthdTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodePayMthdTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodePayMthdTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodePayMthdTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodePayMthdTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodePayMthdTypeParameterBuilder
	
	#region GsCodePayMthdTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodePayMthdTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodePayMthdType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodePayMthdTypeSortBuilder : SqlSortBuilder<GsCodePayMthdTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodePayMthdTypeSqlSortBuilder class.
		/// </summary>
		public GsCodePayMthdTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodePayMthdTypeSortBuilder
	
} // end namespace
