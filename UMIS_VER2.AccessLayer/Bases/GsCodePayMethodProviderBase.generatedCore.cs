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
	/// This class is the base class for any <see cref="GsCodePayMethodProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodePayMethodProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodePayMethod, UMIS_VER2.BusinessLyer.GsCodePayMethodKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodePayMethodKey key)
		{
			return Delete(transactionManager, key.GsCodePayMethodId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodePayMethodId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodePayMethodId)
		{
			return Delete(null, _gsCodePayMethodId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodePayMethodId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodePayMethod Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodePayMethodKey key, int start, int pageLength)
		{
			return GetByGsCodePayMethodId(transactionManager, key.GsCodePayMethodId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_PAY_METHOD index.
		/// </summary>
		/// <param name="_gsCodePayMethodId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodePayMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodePayMethod GetByGsCodePayMethodId(System.Decimal _gsCodePayMethodId)
		{
			int count = -1;
			return GetByGsCodePayMethodId(null,_gsCodePayMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_PAY_METHOD index.
		/// </summary>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodePayMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodePayMethod GetByGsCodePayMethodId(System.Decimal _gsCodePayMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePayMethodId(null, _gsCodePayMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_PAY_METHOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodePayMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodePayMethod GetByGsCodePayMethodId(TransactionManager transactionManager, System.Decimal _gsCodePayMethodId)
		{
			int count = -1;
			return GetByGsCodePayMethodId(transactionManager, _gsCodePayMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_PAY_METHOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodePayMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodePayMethod GetByGsCodePayMethodId(TransactionManager transactionManager, System.Decimal _gsCodePayMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePayMethodId(transactionManager, _gsCodePayMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_PAY_METHOD index.
		/// </summary>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodePayMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodePayMethod GetByGsCodePayMethodId(System.Decimal _gsCodePayMethodId, int start, int pageLength, out int count)
		{
			return GetByGsCodePayMethodId(null, _gsCodePayMethodId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_PAY_METHOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodePayMethod"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodePayMethod GetByGsCodePayMethodId(TransactionManager transactionManager, System.Decimal _gsCodePayMethodId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodePayMethod&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodePayMethod&gt;"/></returns>
		public static TList<GsCodePayMethod> Fill(IDataReader reader, TList<GsCodePayMethod> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodePayMethod c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodePayMethod")
					.Append("|").Append((System.Decimal)reader["GS_CODE_PAY_METHOD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodePayMethod>(
					key.ToString(), // EntityTrackingKey
					"GsCodePayMethod",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodePayMethod();
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
					c.GsCodePayMethodId = (System.Decimal)reader["GS_CODE_PAY_METHOD_ID"];
					c.OriginalGsCodePayMethodId = c.GsCodePayMethodId;
					c.MethodDescrAr = (System.String)reader["METHOD_DESCR_AR"];
					c.MethodDescrEn = Convert.IsDBNull(reader["METHOD_DESCR_EN"]) ? null : (System.String)reader["METHOD_DESCR_EN"];
					c.MethodCode = Convert.IsDBNull(reader["METHOD_CODE"]) ? null : (System.String)reader["METHOD_CODE"];
					c.NoReceiptNumFlg = Convert.IsDBNull(reader["NO_RECEIPT_NUM_FLG"]) ? null : (System.Boolean?)reader["NO_RECEIPT_NUM_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodePayMethod"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodePayMethod"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodePayMethod entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodePayMethodId = (System.Decimal)reader[((int)GsCodePayMethodColumn.GsCodePayMethodId - 1)];
			entity.OriginalGsCodePayMethodId = (System.Decimal)reader["GS_CODE_PAY_METHOD_ID"];
			entity.MethodDescrAr = (System.String)reader[((int)GsCodePayMethodColumn.MethodDescrAr - 1)];
			entity.MethodDescrEn = (reader.IsDBNull(((int)GsCodePayMethodColumn.MethodDescrEn - 1)))?null:(System.String)reader[((int)GsCodePayMethodColumn.MethodDescrEn - 1)];
			entity.MethodCode = (reader.IsDBNull(((int)GsCodePayMethodColumn.MethodCode - 1)))?null:(System.String)reader[((int)GsCodePayMethodColumn.MethodCode - 1)];
			entity.NoReceiptNumFlg = (reader.IsDBNull(((int)GsCodePayMethodColumn.NoReceiptNumFlg - 1)))?null:(System.Boolean?)reader[((int)GsCodePayMethodColumn.NoReceiptNumFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodePayMethod"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodePayMethod"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodePayMethod entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodePayMethodId = (System.Decimal)dataRow["GS_CODE_PAY_METHOD_ID"];
			entity.OriginalGsCodePayMethodId = (System.Decimal)dataRow["GS_CODE_PAY_METHOD_ID"];
			entity.MethodDescrAr = (System.String)dataRow["METHOD_DESCR_AR"];
			entity.MethodDescrEn = Convert.IsDBNull(dataRow["METHOD_DESCR_EN"]) ? null : (System.String)dataRow["METHOD_DESCR_EN"];
			entity.MethodCode = Convert.IsDBNull(dataRow["METHOD_CODE"]) ? null : (System.String)dataRow["METHOD_CODE"];
			entity.NoReceiptNumFlg = Convert.IsDBNull(dataRow["NO_RECEIPT_NUM_FLG"]) ? null : (System.Boolean?)dataRow["NO_RECEIPT_NUM_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodePayMethod"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodePayMethod Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodePayMethod entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodePayMethodId methods when available
			
			#region AdmAppFeesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppFees>|AdmAppFeesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppFeesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppFeesCollection = DataRepository.AdmAppFeesProvider.GetByGsCodePayMethodId(transactionManager, entity.GsCodePayMethodId);

				if (deep && entity.AdmAppFeesCollection.Count > 0)
				{
					deepHandles.Add("AdmAppFeesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppFees>) DataRepository.AdmAppFeesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppFeesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudVoucherPayMthodCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucherPayMthod>|FeeStudVoucherPayMthodCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherPayMthodCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherPayMthodCollection = DataRepository.FeeStudVoucherPayMthodProvider.GetByGsCodePayMethodId(transactionManager, entity.GsCodePayMethodId);

				if (deep && entity.FeeStudVoucherPayMthodCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherPayMthodCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucherPayMthod>) DataRepository.FeeStudVoucherPayMthodProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherPayMthodCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudVoucherCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucher>|FeeStudVoucherCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherCollection = DataRepository.FeeStudVoucherProvider.GetByGsCodePayMethodId(transactionManager, entity.GsCodePayMethodId);

				if (deep && entity.FeeStudVoucherCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucher>) DataRepository.FeeStudVoucherProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCodePayMthdTypeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCodePayMthdType>|GsCodePayMthdTypeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodePayMthdTypeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCodePayMthdTypeCollection = DataRepository.GsCodePayMthdTypeProvider.GetByGsCodePayMethodId(transactionManager, entity.GsCodePayMethodId);

				if (deep && entity.GsCodePayMthdTypeCollection.Count > 0)
				{
					deepHandles.Add("GsCodePayMthdTypeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCodePayMthdType>) DataRepository.GsCodePayMthdTypeProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCodePayMthdTypeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmRegStepPayOnlineCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmRegStepPayOnline>|AdmRegStepPayOnlineCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmRegStepPayOnlineCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmRegStepPayOnlineCollection = DataRepository.AdmRegStepPayOnlineProvider.GetByGsCodePayMethodId(transactionManager, entity.GsCodePayMethodId);

				if (deep && entity.AdmRegStepPayOnlineCollection.Count > 0)
				{
					deepHandles.Add("AdmRegStepPayOnlineCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmRegStepPayOnline>) DataRepository.AdmRegStepPayOnlineProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmRegStepPayOnlineCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodePayMethod object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodePayMethod instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodePayMethod Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodePayMethod entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AdmAppFees>
				if (CanDeepSave(entity.AdmAppFeesCollection, "List<AdmAppFees>|AdmAppFeesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppFees child in entity.AdmAppFeesCollection)
					{
						if(child.GsCodePayMethodIdSource != null)
						{
							child.GsCodePayMethodId = child.GsCodePayMethodIdSource.GsCodePayMethodId;
						}
						else
						{
							child.GsCodePayMethodId = entity.GsCodePayMethodId;
						}

					}

					if (entity.AdmAppFeesCollection.Count > 0 || entity.AdmAppFeesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppFeesProvider.Save(transactionManager, entity.AdmAppFeesCollection);
						
						deepHandles.Add("AdmAppFeesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppFees >) DataRepository.AdmAppFeesProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppFeesCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudVoucherPayMthod>
				if (CanDeepSave(entity.FeeStudVoucherPayMthodCollection, "List<FeeStudVoucherPayMthod>|FeeStudVoucherPayMthodCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucherPayMthod child in entity.FeeStudVoucherPayMthodCollection)
					{
						if(child.GsCodePayMethodIdSource != null)
						{
							child.GsCodePayMethodId = child.GsCodePayMethodIdSource.GsCodePayMethodId;
						}
						else
						{
							child.GsCodePayMethodId = entity.GsCodePayMethodId;
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
				
	
			#region List<FeeStudVoucher>
				if (CanDeepSave(entity.FeeStudVoucherCollection, "List<FeeStudVoucher>|FeeStudVoucherCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucher child in entity.FeeStudVoucherCollection)
					{
						if(child.GsCodePayMethodIdSource != null)
						{
							child.GsCodePayMethodId = child.GsCodePayMethodIdSource.GsCodePayMethodId;
						}
						else
						{
							child.GsCodePayMethodId = entity.GsCodePayMethodId;
						}

					}

					if (entity.FeeStudVoucherCollection.Count > 0 || entity.FeeStudVoucherCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudVoucherProvider.Save(transactionManager, entity.FeeStudVoucherCollection);
						
						deepHandles.Add("FeeStudVoucherCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudVoucher >) DataRepository.FeeStudVoucherProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudVoucherCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCodePayMthdType>
				if (CanDeepSave(entity.GsCodePayMthdTypeCollection, "List<GsCodePayMthdType>|GsCodePayMthdTypeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCodePayMthdType child in entity.GsCodePayMthdTypeCollection)
					{
						if(child.GsCodePayMethodIdSource != null)
						{
							child.GsCodePayMethodId = child.GsCodePayMethodIdSource.GsCodePayMethodId;
						}
						else
						{
							child.GsCodePayMethodId = entity.GsCodePayMethodId;
						}

					}

					if (entity.GsCodePayMthdTypeCollection.Count > 0 || entity.GsCodePayMthdTypeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCodePayMthdTypeProvider.Save(transactionManager, entity.GsCodePayMthdTypeCollection);
						
						deepHandles.Add("GsCodePayMthdTypeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCodePayMthdType >) DataRepository.GsCodePayMthdTypeProvider.DeepSave,
							new object[] { transactionManager, entity.GsCodePayMthdTypeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmRegStepPayOnline>
				if (CanDeepSave(entity.AdmRegStepPayOnlineCollection, "List<AdmRegStepPayOnline>|AdmRegStepPayOnlineCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmRegStepPayOnline child in entity.AdmRegStepPayOnlineCollection)
					{
						if(child.GsCodePayMethodIdSource != null)
						{
							child.GsCodePayMethodId = child.GsCodePayMethodIdSource.GsCodePayMethodId;
						}
						else
						{
							child.GsCodePayMethodId = entity.GsCodePayMethodId;
						}

					}

					if (entity.AdmRegStepPayOnlineCollection.Count > 0 || entity.AdmRegStepPayOnlineCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmRegStepPayOnlineProvider.Save(transactionManager, entity.AdmRegStepPayOnlineCollection);
						
						deepHandles.Add("AdmRegStepPayOnlineCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmRegStepPayOnline >) DataRepository.AdmRegStepPayOnlineProvider.DeepSave,
							new object[] { transactionManager, entity.AdmRegStepPayOnlineCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCodePayMethodChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodePayMethod</c>
	///</summary>
	public enum GsCodePayMethodChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCodePayMethod</c> as OneToMany for AdmAppFeesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppFees>))]
		AdmAppFeesCollection,
		///<summary>
		/// Collection of <c>GsCodePayMethod</c> as OneToMany for FeeStudVoucherPayMthodCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucherPayMthod>))]
		FeeStudVoucherPayMthodCollection,
		///<summary>
		/// Collection of <c>GsCodePayMethod</c> as OneToMany for FeeStudVoucherCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucher>))]
		FeeStudVoucherCollection,
		///<summary>
		/// Collection of <c>GsCodePayMethod</c> as OneToMany for GsCodePayMthdTypeCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCodePayMthdType>))]
		GsCodePayMthdTypeCollection,
		///<summary>
		/// Collection of <c>GsCodePayMethod</c> as OneToMany for AdmRegStepPayOnlineCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmRegStepPayOnline>))]
		AdmRegStepPayOnlineCollection,
	}
	
	#endregion GsCodePayMethodChildEntityTypes
	
	#region GsCodePayMethodFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodePayMethodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodePayMethod"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodePayMethodFilterBuilder : SqlFilterBuilder<GsCodePayMethodColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodePayMethodFilterBuilder class.
		/// </summary>
		public GsCodePayMethodFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodePayMethodFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodePayMethodFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodePayMethodFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodePayMethodFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodePayMethodFilterBuilder
	
	#region GsCodePayMethodParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodePayMethodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodePayMethod"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodePayMethodParameterBuilder : ParameterizedSqlFilterBuilder<GsCodePayMethodColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodePayMethodParameterBuilder class.
		/// </summary>
		public GsCodePayMethodParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodePayMethodParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodePayMethodParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodePayMethodParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodePayMethodParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodePayMethodParameterBuilder
	
	#region GsCodePayMethodSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodePayMethodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodePayMethod"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodePayMethodSortBuilder : SqlSortBuilder<GsCodePayMethodColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodePayMethodSqlSortBuilder class.
		/// </summary>
		public GsCodePayMethodSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodePayMethodSortBuilder
	
} // end namespace
