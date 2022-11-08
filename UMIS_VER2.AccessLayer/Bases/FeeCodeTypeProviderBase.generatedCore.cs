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
	/// This class is the base class for any <see cref="FeeCodeTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeCodeTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeCodeType, UMIS_VER2.BusinessLyer.FeeCodeTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCodeTypeKey key)
		{
			return Delete(transactionManager, key.FeeCodeTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeCodeTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeCodeTypeId)
		{
			return Delete(null, _feeCodeTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeCodeTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.FeeCodeType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCodeTypeKey key, int start, int pageLength)
		{
			return GetByFeeCodeTypeId(transactionManager, key.FeeCodeTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_CODE_TYPE index.
		/// </summary>
		/// <param name="_feeCodeTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeType GetByFeeCodeTypeId(System.Decimal _feeCodeTypeId)
		{
			int count = -1;
			return GetByFeeCodeTypeId(null,_feeCodeTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CODE_TYPE index.
		/// </summary>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeType GetByFeeCodeTypeId(System.Decimal _feeCodeTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeTypeId(null, _feeCodeTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CODE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeType GetByFeeCodeTypeId(TransactionManager transactionManager, System.Decimal _feeCodeTypeId)
		{
			int count = -1;
			return GetByFeeCodeTypeId(transactionManager, _feeCodeTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CODE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeType GetByFeeCodeTypeId(TransactionManager transactionManager, System.Decimal _feeCodeTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeTypeId(transactionManager, _feeCodeTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CODE_TYPE index.
		/// </summary>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeType GetByFeeCodeTypeId(System.Decimal _feeCodeTypeId, int start, int pageLength, out int count)
		{
			return GetByFeeCodeTypeId(null, _feeCodeTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CODE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCodeType GetByFeeCodeTypeId(TransactionManager transactionManager, System.Decimal _feeCodeTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeCodeType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeCodeType&gt;"/></returns>
		public static TList<FeeCodeType> Fill(IDataReader reader, TList<FeeCodeType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeCodeType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeCodeType")
					.Append("|").Append((System.Decimal)reader["FEE_CODE_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeCodeType>(
					key.ToString(), // EntityTrackingKey
					"FeeCodeType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeCodeType();
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
					c.FeeCodeTypeId = (System.Decimal)reader["FEE_CODE_TYPE_ID"];
					c.OriginalFeeCodeTypeId = c.FeeCodeTypeId;
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCodeType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCodeType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeCodeType entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeCodeTypeId = (System.Decimal)reader[((int)FeeCodeTypeColumn.FeeCodeTypeId - 1)];
			entity.OriginalFeeCodeTypeId = (System.Decimal)reader["FEE_CODE_TYPE_ID"];
			entity.DescrAr = (reader.IsDBNull(((int)FeeCodeTypeColumn.DescrAr - 1)))?null:(System.String)reader[((int)FeeCodeTypeColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)FeeCodeTypeColumn.DescrEn - 1)))?null:(System.String)reader[((int)FeeCodeTypeColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCodeType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCodeType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeCodeType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeCodeTypeId = (System.Decimal)dataRow["FEE_CODE_TYPE_ID"];
			entity.OriginalFeeCodeTypeId = (System.Decimal)dataRow["FEE_CODE_TYPE_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCodeType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCodeType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCodeType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeCodeTypeId methods when available
			
			#region FeeFacultyRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFacultyRuleCollection = DataRepository.FeeFacultyRuleProvider.GetByFeeCodeTypeId(transactionManager, entity.FeeCodeTypeId);

				if (deep && entity.FeeFacultyRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacultyRule>) DataRepository.FeeFacultyRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacultyRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeCodeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeCodeItem>|FeeCodeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeCodeItemCollection = DataRepository.FeeCodeItemProvider.GetByFeeCodeTypeId(transactionManager, entity.FeeCodeTypeId);

				if (deep && entity.FeeCodeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeCodeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeCodeItem>) DataRepository.FeeCodeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeCodeItemCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeStudVoucherCollection = DataRepository.FeeStudVoucherProvider.GetByFeeCodeTypeId(transactionManager, entity.FeeCodeTypeId);

				if (deep && entity.FeeStudVoucherCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucher>) DataRepository.FeeStudVoucherProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorOfferCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorOffer>|SpoSponsorOfferCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorOfferCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorOfferCollection = DataRepository.SpoSponsorOfferProvider.GetByFeeCodeTypeId(transactionManager, entity.FeeCodeTypeId);

				if (deep && entity.SpoSponsorOfferCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorOfferCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorOffer>) DataRepository.SpoSponsorOfferProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorOfferCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudFeeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFeeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudFeeItemCollection = DataRepository.FeeStudFeeItemProvider.GetByFeeCodeTypeId(transactionManager, entity.FeeCodeTypeId);

				if (deep && entity.FeeStudFeeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudFeeItem>) DataRepository.FeeStudFeeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudFeeItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeCodeType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeCodeType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCodeType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCodeType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<FeeFacultyRule>
				if (CanDeepSave(entity.FeeFacultyRuleCollection, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFacultyRule child in entity.FeeFacultyRuleCollection)
					{
						if(child.FeeCodeTypeIdSource != null)
						{
							child.FeeCodeTypeId = child.FeeCodeTypeIdSource.FeeCodeTypeId;
						}
						else
						{
							child.FeeCodeTypeId = entity.FeeCodeTypeId;
						}

					}

					if (entity.FeeFacultyRuleCollection.Count > 0 || entity.FeeFacultyRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFacultyRuleProvider.Save(transactionManager, entity.FeeFacultyRuleCollection);
						
						deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFacultyRule >) DataRepository.FeeFacultyRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFacultyRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeCodeItem>
				if (CanDeepSave(entity.FeeCodeItemCollection, "List<FeeCodeItem>|FeeCodeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeCodeItem child in entity.FeeCodeItemCollection)
					{
						if(child.FeeCodeTypeIdSource != null)
						{
							child.FeeCodeTypeId = child.FeeCodeTypeIdSource.FeeCodeTypeId;
						}
						else
						{
							child.FeeCodeTypeId = entity.FeeCodeTypeId;
						}

					}

					if (entity.FeeCodeItemCollection.Count > 0 || entity.FeeCodeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeCodeItemProvider.Save(transactionManager, entity.FeeCodeItemCollection);
						
						deepHandles.Add("FeeCodeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeCodeItem >) DataRepository.FeeCodeItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeCodeItemCollection, deepSaveType, childTypes, innerList }
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
						if(child.FeeCodeTypeIdSource != null)
						{
							child.FeeCodeTypeId = child.FeeCodeTypeIdSource.FeeCodeTypeId;
						}
						else
						{
							child.FeeCodeTypeId = entity.FeeCodeTypeId;
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
				
	
			#region List<SpoSponsorOffer>
				if (CanDeepSave(entity.SpoSponsorOfferCollection, "List<SpoSponsorOffer>|SpoSponsorOfferCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorOffer child in entity.SpoSponsorOfferCollection)
					{
						if(child.FeeCodeTypeIdSource != null)
						{
							child.FeeCodeTypeId = child.FeeCodeTypeIdSource.FeeCodeTypeId;
						}
						else
						{
							child.FeeCodeTypeId = entity.FeeCodeTypeId;
						}

					}

					if (entity.SpoSponsorOfferCollection.Count > 0 || entity.SpoSponsorOfferCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorOfferProvider.Save(transactionManager, entity.SpoSponsorOfferCollection);
						
						deepHandles.Add("SpoSponsorOfferCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorOffer >) DataRepository.SpoSponsorOfferProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorOfferCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudFeeItem>
				if (CanDeepSave(entity.FeeStudFeeItemCollection, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudFeeItem child in entity.FeeStudFeeItemCollection)
					{
						if(child.FeeCodeTypeIdSource != null)
						{
							child.FeeCodeTypeId = child.FeeCodeTypeIdSource.FeeCodeTypeId;
						}
						else
						{
							child.FeeCodeTypeId = entity.FeeCodeTypeId;
						}

					}

					if (entity.FeeStudFeeItemCollection.Count > 0 || entity.FeeStudFeeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudFeeItemProvider.Save(transactionManager, entity.FeeStudFeeItemCollection);
						
						deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudFeeItem >) DataRepository.FeeStudFeeItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudFeeItemCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeCodeTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeCodeType</c>
	///</summary>
	public enum FeeCodeTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>FeeCodeType</c> as OneToMany for FeeFacultyRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacultyRule>))]
		FeeFacultyRuleCollection,
		///<summary>
		/// Collection of <c>FeeCodeType</c> as OneToMany for FeeCodeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeCodeItem>))]
		FeeCodeItemCollection,
		///<summary>
		/// Collection of <c>FeeCodeType</c> as OneToMany for FeeStudVoucherCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucher>))]
		FeeStudVoucherCollection,
		///<summary>
		/// Collection of <c>FeeCodeType</c> as OneToMany for SpoSponsorOfferCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorOffer>))]
		SpoSponsorOfferCollection,
		///<summary>
		/// Collection of <c>FeeCodeType</c> as OneToMany for FeeStudFeeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudFeeItem>))]
		FeeStudFeeItemCollection,
	}
	
	#endregion FeeCodeTypeChildEntityTypes
	
	#region FeeCodeTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeCodeTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCodeType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCodeTypeFilterBuilder : SqlFilterBuilder<FeeCodeTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCodeTypeFilterBuilder class.
		/// </summary>
		public FeeCodeTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCodeTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCodeTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCodeTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCodeTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCodeTypeFilterBuilder
	
	#region FeeCodeTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeCodeTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCodeType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCodeTypeParameterBuilder : ParameterizedSqlFilterBuilder<FeeCodeTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCodeTypeParameterBuilder class.
		/// </summary>
		public FeeCodeTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCodeTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCodeTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCodeTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCodeTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCodeTypeParameterBuilder
	
	#region FeeCodeTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeCodeTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCodeType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeCodeTypeSortBuilder : SqlSortBuilder<FeeCodeTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCodeTypeSqlSortBuilder class.
		/// </summary>
		public FeeCodeTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeCodeTypeSortBuilder
	
} // end namespace
