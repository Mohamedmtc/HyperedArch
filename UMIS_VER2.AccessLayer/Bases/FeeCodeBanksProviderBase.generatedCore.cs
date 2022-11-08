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
	/// This class is the base class for any <see cref="FeeCodeBanksProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeCodeBanksProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeCodeBanks, UMIS_VER2.BusinessLyer.FeeCodeBanksKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCodeBanksKey key)
		{
			return Delete(transactionManager, key.FeeCodeBankId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeCodeBankId">اكواد  البنوك. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeCodeBankId)
		{
			return Delete(null, _feeCodeBankId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">اكواد  البنوك. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeCodeBankId);		
		
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
		public override UMIS_VER2.BusinessLyer.FeeCodeBanks Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCodeBanksKey key, int start, int pageLength)
		{
			return GetByFeeCodeBankId(transactionManager, key.FeeCodeBankId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_CODE_BANKS index.
		/// </summary>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeBanks"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeBanks GetByFeeCodeBankId(System.Decimal _feeCodeBankId)
		{
			int count = -1;
			return GetByFeeCodeBankId(null,_feeCodeBankId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CODE_BANKS index.
		/// </summary>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeBanks"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeBanks GetByFeeCodeBankId(System.Decimal _feeCodeBankId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeBankId(null, _feeCodeBankId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CODE_BANKS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeBanks"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeBanks GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal _feeCodeBankId)
		{
			int count = -1;
			return GetByFeeCodeBankId(transactionManager, _feeCodeBankId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CODE_BANKS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeBanks"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeBanks GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal _feeCodeBankId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeBankId(transactionManager, _feeCodeBankId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CODE_BANKS index.
		/// </summary>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeBanks"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeBanks GetByFeeCodeBankId(System.Decimal _feeCodeBankId, int start, int pageLength, out int count)
		{
			return GetByFeeCodeBankId(null, _feeCodeBankId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CODE_BANKS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeBanks"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCodeBanks GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal _feeCodeBankId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeCodeBanks&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeCodeBanks&gt;"/></returns>
		public static TList<FeeCodeBanks> Fill(IDataReader reader, TList<FeeCodeBanks> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeCodeBanks c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeCodeBanks")
					.Append("|").Append((System.Decimal)reader["FEE_CODE_BANK_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeCodeBanks>(
					key.ToString(), // EntityTrackingKey
					"FeeCodeBanks",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeCodeBanks();
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
					c.FeeCodeBankId = (System.Decimal)reader["FEE_CODE_BANK_ID"];
					c.OriginalFeeCodeBankId = c.FeeCodeBankId;
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.BankAddress = Convert.IsDBNull(reader["BANK_ADDRESS"]) ? null : (System.String)reader["BANK_ADDRESS"];
					c.SwiftCode = Convert.IsDBNull(reader["SWIFT_CODE"]) ? null : (System.String)reader["SWIFT_CODE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.DfultFlg = Convert.IsDBNull(reader["DFULT_FLG"]) ? null : (System.Boolean?)reader["DFULT_FLG"];
					c.TrnsCommPrcnt = Convert.IsDBNull(reader["TRNS_COMM_PRCNT"]) ? null : (System.Decimal?)reader["TRNS_COMM_PRCNT"];
					c.TrnsCommValue = Convert.IsDBNull(reader["TRNS_COMM_VALUE"]) ? null : (System.Decimal?)reader["TRNS_COMM_VALUE"];
					c.BankCode = Convert.IsDBNull(reader["BANK_CODE"]) ? null : (System.String)reader["BANK_CODE"];
					c.IsVisible = Convert.IsDBNull(reader["Is_Visible"]) ? null : (System.Boolean?)reader["Is_Visible"];
					c.PayPermissionDate = Convert.IsDBNull(reader["PAY_PERMISSION_Date"]) ? null : (System.DateTime?)reader["PAY_PERMISSION_Date"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCodeBanks"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCodeBanks"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeCodeBanks entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeCodeBankId = (System.Decimal)reader[((int)FeeCodeBanksColumn.FeeCodeBankId - 1)];
			entity.OriginalFeeCodeBankId = (System.Decimal)reader["FEE_CODE_BANK_ID"];
			entity.DescrAr = (reader.IsDBNull(((int)FeeCodeBanksColumn.DescrAr - 1)))?null:(System.String)reader[((int)FeeCodeBanksColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)FeeCodeBanksColumn.DescrEn - 1)))?null:(System.String)reader[((int)FeeCodeBanksColumn.DescrEn - 1)];
			entity.BankAddress = (reader.IsDBNull(((int)FeeCodeBanksColumn.BankAddress - 1)))?null:(System.String)reader[((int)FeeCodeBanksColumn.BankAddress - 1)];
			entity.SwiftCode = (reader.IsDBNull(((int)FeeCodeBanksColumn.SwiftCode - 1)))?null:(System.String)reader[((int)FeeCodeBanksColumn.SwiftCode - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeCodeBanksColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeCodeBanksColumn.SeUserId - 1)];
			entity.DfultFlg = (reader.IsDBNull(((int)FeeCodeBanksColumn.DfultFlg - 1)))?null:(System.Boolean?)reader[((int)FeeCodeBanksColumn.DfultFlg - 1)];
			entity.TrnsCommPrcnt = (reader.IsDBNull(((int)FeeCodeBanksColumn.TrnsCommPrcnt - 1)))?null:(System.Decimal?)reader[((int)FeeCodeBanksColumn.TrnsCommPrcnt - 1)];
			entity.TrnsCommValue = (reader.IsDBNull(((int)FeeCodeBanksColumn.TrnsCommValue - 1)))?null:(System.Decimal?)reader[((int)FeeCodeBanksColumn.TrnsCommValue - 1)];
			entity.BankCode = (reader.IsDBNull(((int)FeeCodeBanksColumn.BankCode - 1)))?null:(System.String)reader[((int)FeeCodeBanksColumn.BankCode - 1)];
			entity.IsVisible = (reader.IsDBNull(((int)FeeCodeBanksColumn.IsVisible - 1)))?null:(System.Boolean?)reader[((int)FeeCodeBanksColumn.IsVisible - 1)];
			entity.PayPermissionDate = (reader.IsDBNull(((int)FeeCodeBanksColumn.PayPermissionDate - 1)))?null:(System.DateTime?)reader[((int)FeeCodeBanksColumn.PayPermissionDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCodeBanks"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCodeBanks"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeCodeBanks entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeCodeBankId = (System.Decimal)dataRow["FEE_CODE_BANK_ID"];
			entity.OriginalFeeCodeBankId = (System.Decimal)dataRow["FEE_CODE_BANK_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.BankAddress = Convert.IsDBNull(dataRow["BANK_ADDRESS"]) ? null : (System.String)dataRow["BANK_ADDRESS"];
			entity.SwiftCode = Convert.IsDBNull(dataRow["SWIFT_CODE"]) ? null : (System.String)dataRow["SWIFT_CODE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.DfultFlg = Convert.IsDBNull(dataRow["DFULT_FLG"]) ? null : (System.Boolean?)dataRow["DFULT_FLG"];
			entity.TrnsCommPrcnt = Convert.IsDBNull(dataRow["TRNS_COMM_PRCNT"]) ? null : (System.Decimal?)dataRow["TRNS_COMM_PRCNT"];
			entity.TrnsCommValue = Convert.IsDBNull(dataRow["TRNS_COMM_VALUE"]) ? null : (System.Decimal?)dataRow["TRNS_COMM_VALUE"];
			entity.BankCode = Convert.IsDBNull(dataRow["BANK_CODE"]) ? null : (System.String)dataRow["BANK_CODE"];
			entity.IsVisible = Convert.IsDBNull(dataRow["Is_Visible"]) ? null : (System.Boolean?)dataRow["Is_Visible"];
			entity.PayPermissionDate = Convert.IsDBNull(dataRow["PAY_PERMISSION_Date"]) ? null : (System.DateTime?)dataRow["PAY_PERMISSION_Date"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCodeBanks"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCodeBanks Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCodeBanks entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeCodeBankId methods when available
			
			#region FeeYearPrdBankCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeYearPrdBank>|FeeYearPrdBankCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeYearPrdBankCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeYearPrdBankCollection = DataRepository.FeeYearPrdBankProvider.GetByFeeCodeBankId(transactionManager, entity.FeeCodeBankId);

				if (deep && entity.FeeYearPrdBankCollection.Count > 0)
				{
					deepHandles.Add("FeeYearPrdBankCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeYearPrdBank>) DataRepository.FeeYearPrdBankProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeYearPrdBankCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppFeesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppFees>|AdmAppFeesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppFeesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppFeesCollection = DataRepository.AdmAppFeesProvider.GetByFeeCodeBankId(transactionManager, entity.FeeCodeBankId);

				if (deep && entity.AdmAppFeesCollection.Count > 0)
				{
					deepHandles.Add("AdmAppFeesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppFees>) DataRepository.AdmAppFeesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppFeesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudBankCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudBank>|FeeStudBankCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudBankCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudBankCollection = DataRepository.FeeStudBankProvider.GetByFeeCodeBankId(transactionManager, entity.FeeCodeBankId);

				if (deep && entity.FeeStudBankCollection.Count > 0)
				{
					deepHandles.Add("FeeStudBankCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudBank>) DataRepository.FeeStudBankProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudBankCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmRegStepPayOnlineCollection = DataRepository.AdmRegStepPayOnlineProvider.GetByFeeCodeBankId(transactionManager, entity.FeeCodeBankId);

				if (deep && entity.AdmRegStepPayOnlineCollection.Count > 0)
				{
					deepHandles.Add("AdmRegStepPayOnlineCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmRegStepPayOnline>) DataRepository.AdmRegStepPayOnlineProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmRegStepPayOnlineCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeStudVoucherCollection = DataRepository.FeeStudVoucherProvider.GetByFeeCodeBankId(transactionManager, entity.FeeCodeBankId);

				if (deep && entity.FeeStudVoucherCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucher>) DataRepository.FeeStudVoucherProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeRefndStdReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeRefndStdReq>|FeeRefndStdReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefndStdReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeRefndStdReqCollection = DataRepository.FeeRefndStdReqProvider.GetByFeeCodeBankId(transactionManager, entity.FeeCodeBankId);

				if (deep && entity.FeeRefndStdReqCollection.Count > 0)
				{
					deepHandles.Add("FeeRefndStdReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefndStdReq>) DataRepository.FeeRefndStdReqProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefndStdReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeCdeBankAccntCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeCdeBankAccnt>|FeeCdeBankAccntCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeBankAccntCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeCdeBankAccntCollection = DataRepository.FeeCdeBankAccntProvider.GetByFeeCodeBankId(transactionManager, entity.FeeCodeBankId);

				if (deep && entity.FeeCdeBankAccntCollection.Count > 0)
				{
					deepHandles.Add("FeeCdeBankAccntCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeCdeBankAccnt>) DataRepository.FeeCdeBankAccntProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeCdeBankAccntCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeStudVoucherPayMthodCollection = DataRepository.FeeStudVoucherPayMthodProvider.GetByFeeCodeBankId(transactionManager, entity.FeeCodeBankId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeCodeBanks object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeCodeBanks instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCodeBanks Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCodeBanks entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<FeeYearPrdBank>
				if (CanDeepSave(entity.FeeYearPrdBankCollection, "List<FeeYearPrdBank>|FeeYearPrdBankCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeYearPrdBank child in entity.FeeYearPrdBankCollection)
					{
						if(child.FeeCodeBankIdSource != null)
						{
							child.FeeCodeBankId = child.FeeCodeBankIdSource.FeeCodeBankId;
						}
						else
						{
							child.FeeCodeBankId = entity.FeeCodeBankId;
						}

					}

					if (entity.FeeYearPrdBankCollection.Count > 0 || entity.FeeYearPrdBankCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeYearPrdBankProvider.Save(transactionManager, entity.FeeYearPrdBankCollection);
						
						deepHandles.Add("FeeYearPrdBankCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeYearPrdBank >) DataRepository.FeeYearPrdBankProvider.DeepSave,
							new object[] { transactionManager, entity.FeeYearPrdBankCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppFees>
				if (CanDeepSave(entity.AdmAppFeesCollection, "List<AdmAppFees>|AdmAppFeesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppFees child in entity.AdmAppFeesCollection)
					{
						if(child.FeeCodeBankIdSource != null)
						{
							child.FeeCodeBankId = child.FeeCodeBankIdSource.FeeCodeBankId;
						}
						else
						{
							child.FeeCodeBankId = entity.FeeCodeBankId;
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
				
	
			#region List<FeeStudBank>
				if (CanDeepSave(entity.FeeStudBankCollection, "List<FeeStudBank>|FeeStudBankCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudBank child in entity.FeeStudBankCollection)
					{
						if(child.FeeCodeBankIdSource != null)
						{
							child.FeeCodeBankId = child.FeeCodeBankIdSource.FeeCodeBankId;
						}
						else
						{
							child.FeeCodeBankId = entity.FeeCodeBankId;
						}

					}

					if (entity.FeeStudBankCollection.Count > 0 || entity.FeeStudBankCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudBankProvider.Save(transactionManager, entity.FeeStudBankCollection);
						
						deepHandles.Add("FeeStudBankCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudBank >) DataRepository.FeeStudBankProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudBankCollection, deepSaveType, childTypes, innerList }
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
						if(child.FeeCodeBankIdSource != null)
						{
							child.FeeCodeBankId = child.FeeCodeBankIdSource.FeeCodeBankId;
						}
						else
						{
							child.FeeCodeBankId = entity.FeeCodeBankId;
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
				
	
			#region List<FeeStudVoucher>
				if (CanDeepSave(entity.FeeStudVoucherCollection, "List<FeeStudVoucher>|FeeStudVoucherCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucher child in entity.FeeStudVoucherCollection)
					{
						if(child.FeeCodeBankIdSource != null)
						{
							child.FeeCodeBankId = child.FeeCodeBankIdSource.FeeCodeBankId;
						}
						else
						{
							child.FeeCodeBankId = entity.FeeCodeBankId;
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
				
	
			#region List<FeeRefndStdReq>
				if (CanDeepSave(entity.FeeRefndStdReqCollection, "List<FeeRefndStdReq>|FeeRefndStdReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeRefndStdReq child in entity.FeeRefndStdReqCollection)
					{
						if(child.FeeCodeBankIdSource != null)
						{
							child.FeeCodeBankId = child.FeeCodeBankIdSource.FeeCodeBankId;
						}
						else
						{
							child.FeeCodeBankId = entity.FeeCodeBankId;
						}

					}

					if (entity.FeeRefndStdReqCollection.Count > 0 || entity.FeeRefndStdReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeRefndStdReqProvider.Save(transactionManager, entity.FeeRefndStdReqCollection);
						
						deepHandles.Add("FeeRefndStdReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeRefndStdReq >) DataRepository.FeeRefndStdReqProvider.DeepSave,
							new object[] { transactionManager, entity.FeeRefndStdReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeCdeBankAccnt>
				if (CanDeepSave(entity.FeeCdeBankAccntCollection, "List<FeeCdeBankAccnt>|FeeCdeBankAccntCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeCdeBankAccnt child in entity.FeeCdeBankAccntCollection)
					{
						if(child.FeeCodeBankIdSource != null)
						{
							child.FeeCodeBankId = child.FeeCodeBankIdSource.FeeCodeBankId;
						}
						else
						{
							child.FeeCodeBankId = entity.FeeCodeBankId;
						}

					}

					if (entity.FeeCdeBankAccntCollection.Count > 0 || entity.FeeCdeBankAccntCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeCdeBankAccntProvider.Save(transactionManager, entity.FeeCdeBankAccntCollection);
						
						deepHandles.Add("FeeCdeBankAccntCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeCdeBankAccnt >) DataRepository.FeeCdeBankAccntProvider.DeepSave,
							new object[] { transactionManager, entity.FeeCdeBankAccntCollection, deepSaveType, childTypes, innerList }
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
						if(child.FeeCodeBankIdSource != null)
						{
							child.FeeCodeBankId = child.FeeCodeBankIdSource.FeeCodeBankId;
						}
						else
						{
							child.FeeCodeBankId = entity.FeeCodeBankId;
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
	
	#region FeeCodeBanksChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeCodeBanks</c>
	///</summary>
	public enum FeeCodeBanksChildEntityTypes
	{
		///<summary>
		/// Collection of <c>FeeCodeBanks</c> as OneToMany for FeeYearPrdBankCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeYearPrdBank>))]
		FeeYearPrdBankCollection,
		///<summary>
		/// Collection of <c>FeeCodeBanks</c> as OneToMany for AdmAppFeesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppFees>))]
		AdmAppFeesCollection,
		///<summary>
		/// Collection of <c>FeeCodeBanks</c> as OneToMany for FeeStudBankCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudBank>))]
		FeeStudBankCollection,
		///<summary>
		/// Collection of <c>FeeCodeBanks</c> as OneToMany for AdmRegStepPayOnlineCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmRegStepPayOnline>))]
		AdmRegStepPayOnlineCollection,
		///<summary>
		/// Collection of <c>FeeCodeBanks</c> as OneToMany for FeeStudVoucherCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucher>))]
		FeeStudVoucherCollection,
		///<summary>
		/// Collection of <c>FeeCodeBanks</c> as OneToMany for FeeRefndStdReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefndStdReq>))]
		FeeRefndStdReqCollection,
		///<summary>
		/// Collection of <c>FeeCodeBanks</c> as OneToMany for FeeCdeBankAccntCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeCdeBankAccnt>))]
		FeeCdeBankAccntCollection,
		///<summary>
		/// Collection of <c>FeeCodeBanks</c> as OneToMany for FeeStudVoucherPayMthodCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucherPayMthod>))]
		FeeStudVoucherPayMthodCollection,
	}
	
	#endregion FeeCodeBanksChildEntityTypes
	
	#region FeeCodeBanksFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeCodeBanksColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCodeBanks"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCodeBanksFilterBuilder : SqlFilterBuilder<FeeCodeBanksColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCodeBanksFilterBuilder class.
		/// </summary>
		public FeeCodeBanksFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCodeBanksFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCodeBanksFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCodeBanksFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCodeBanksFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCodeBanksFilterBuilder
	
	#region FeeCodeBanksParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeCodeBanksColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCodeBanks"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCodeBanksParameterBuilder : ParameterizedSqlFilterBuilder<FeeCodeBanksColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCodeBanksParameterBuilder class.
		/// </summary>
		public FeeCodeBanksParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCodeBanksParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCodeBanksParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCodeBanksParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCodeBanksParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCodeBanksParameterBuilder
	
	#region FeeCodeBanksSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeCodeBanksColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCodeBanks"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeCodeBanksSortBuilder : SqlSortBuilder<FeeCodeBanksColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCodeBanksSqlSortBuilder class.
		/// </summary>
		public FeeCodeBanksSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeCodeBanksSortBuilder
	
} // end namespace
