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
	/// This class is the base class for any <see cref="GsCodeCurrencyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeCurrencyProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeCurrency, UMIS_VER2.BusinessLyer.GsCodeCurrencyKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeCurrencyKey key)
		{
			return Delete(transactionManager, key.GsCodeCurrencyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeCurrencyId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeCurrencyId)
		{
			return Delete(null, _gsCodeCurrencyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeCurrency Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeCurrencyKey key, int start, int pageLength)
		{
			return GetByGsCodeCurrencyId(transactionManager, key.GsCodeCurrencyId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_CURRENCY_AR index.
		/// </summary>
		/// <param name="_currencyDescrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeCurrency"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeCurrency GetByCurrencyDescrAr(System.String _currencyDescrAr)
		{
			int count = -1;
			return GetByCurrencyDescrAr(null,_currencyDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_CURRENCY_AR index.
		/// </summary>
		/// <param name="_currencyDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeCurrency"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeCurrency GetByCurrencyDescrAr(System.String _currencyDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByCurrencyDescrAr(null, _currencyDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_CURRENCY_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_currencyDescrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeCurrency"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeCurrency GetByCurrencyDescrAr(TransactionManager transactionManager, System.String _currencyDescrAr)
		{
			int count = -1;
			return GetByCurrencyDescrAr(transactionManager, _currencyDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_CURRENCY_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_currencyDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeCurrency"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeCurrency GetByCurrencyDescrAr(TransactionManager transactionManager, System.String _currencyDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByCurrencyDescrAr(transactionManager, _currencyDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_CURRENCY_AR index.
		/// </summary>
		/// <param name="_currencyDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeCurrency"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeCurrency GetByCurrencyDescrAr(System.String _currencyDescrAr, int start, int pageLength, out int count)
		{
			return GetByCurrencyDescrAr(null, _currencyDescrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_CURRENCY_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_currencyDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeCurrency"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeCurrency GetByCurrencyDescrAr(TransactionManager transactionManager, System.String _currencyDescrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_CURRENCY index.
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeCurrency"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeCurrency GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(null,_gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_CURRENCY index.
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeCurrency"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeCurrency GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_CURRENCY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeCurrency"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeCurrency GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_CURRENCY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeCurrency"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeCurrency GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_CURRENCY index.
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeCurrency"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeCurrency GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count)
		{
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_CURRENCY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeCurrency"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeCurrency GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeCurrency&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeCurrency&gt;"/></returns>
		public static TList<GsCodeCurrency> Fill(IDataReader reader, TList<GsCodeCurrency> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeCurrency c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeCurrency")
					.Append("|").Append((System.Decimal)reader["GS_CODE_CURRENCY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeCurrency>(
					key.ToString(), // EntityTrackingKey
					"GsCodeCurrency",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeCurrency();
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
					c.GsCodeCurrencyId = (System.Decimal)reader["GS_CODE_CURRENCY_ID"];
					c.OriginalGsCodeCurrencyId = c.GsCodeCurrencyId;
					c.CurrencyDescrAr = (System.String)reader["CURRENCY_DESCR_AR"];
					c.CurrencyDescrEn = Convert.IsDBNull(reader["CURRENCY_DESCR_EN"]) ? null : (System.String)reader["CURRENCY_DESCR_EN"];
					c.CurrencyCode = Convert.IsDBNull(reader["CURRENCY_CODE"]) ? null : (System.String)reader["CURRENCY_CODE"];
					c.IsCurrencyLocal = (System.Decimal)reader["IS_CURRENCY_LOCAL"];
					c.FractionDescrAr = Convert.IsDBNull(reader["FRACTION_DESCR_AR"]) ? null : (System.String)reader["FRACTION_DESCR_AR"];
					c.FractionDescrEn = Convert.IsDBNull(reader["FRACTION_DESCR_EN"]) ? null : (System.String)reader["FRACTION_DESCR_EN"];
					c.FractionValue = Convert.IsDBNull(reader["FRACTION_VALUE"]) ? null : (System.Int32?)reader["FRACTION_VALUE"];
					c.ExchangeRate = Convert.IsDBNull(reader["EXCHANGE_RATE"]) ? null : (System.Decimal?)reader["EXCHANGE_RATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeCurrency"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeCurrency"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeCurrency entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeCurrencyId = (System.Decimal)reader[((int)GsCodeCurrencyColumn.GsCodeCurrencyId - 1)];
			entity.OriginalGsCodeCurrencyId = (System.Decimal)reader["GS_CODE_CURRENCY_ID"];
			entity.CurrencyDescrAr = (System.String)reader[((int)GsCodeCurrencyColumn.CurrencyDescrAr - 1)];
			entity.CurrencyDescrEn = (reader.IsDBNull(((int)GsCodeCurrencyColumn.CurrencyDescrEn - 1)))?null:(System.String)reader[((int)GsCodeCurrencyColumn.CurrencyDescrEn - 1)];
			entity.CurrencyCode = (reader.IsDBNull(((int)GsCodeCurrencyColumn.CurrencyCode - 1)))?null:(System.String)reader[((int)GsCodeCurrencyColumn.CurrencyCode - 1)];
			entity.IsCurrencyLocal = (System.Decimal)reader[((int)GsCodeCurrencyColumn.IsCurrencyLocal - 1)];
			entity.FractionDescrAr = (reader.IsDBNull(((int)GsCodeCurrencyColumn.FractionDescrAr - 1)))?null:(System.String)reader[((int)GsCodeCurrencyColumn.FractionDescrAr - 1)];
			entity.FractionDescrEn = (reader.IsDBNull(((int)GsCodeCurrencyColumn.FractionDescrEn - 1)))?null:(System.String)reader[((int)GsCodeCurrencyColumn.FractionDescrEn - 1)];
			entity.FractionValue = (reader.IsDBNull(((int)GsCodeCurrencyColumn.FractionValue - 1)))?null:(System.Int32?)reader[((int)GsCodeCurrencyColumn.FractionValue - 1)];
			entity.ExchangeRate = (reader.IsDBNull(((int)GsCodeCurrencyColumn.ExchangeRate - 1)))?null:(System.Decimal?)reader[((int)GsCodeCurrencyColumn.ExchangeRate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeCurrency"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeCurrency"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeCurrency entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeCurrencyId = (System.Decimal)dataRow["GS_CODE_CURRENCY_ID"];
			entity.OriginalGsCodeCurrencyId = (System.Decimal)dataRow["GS_CODE_CURRENCY_ID"];
			entity.CurrencyDescrAr = (System.String)dataRow["CURRENCY_DESCR_AR"];
			entity.CurrencyDescrEn = Convert.IsDBNull(dataRow["CURRENCY_DESCR_EN"]) ? null : (System.String)dataRow["CURRENCY_DESCR_EN"];
			entity.CurrencyCode = Convert.IsDBNull(dataRow["CURRENCY_CODE"]) ? null : (System.String)dataRow["CURRENCY_CODE"];
			entity.IsCurrencyLocal = (System.Decimal)dataRow["IS_CURRENCY_LOCAL"];
			entity.FractionDescrAr = Convert.IsDBNull(dataRow["FRACTION_DESCR_AR"]) ? null : (System.String)dataRow["FRACTION_DESCR_AR"];
			entity.FractionDescrEn = Convert.IsDBNull(dataRow["FRACTION_DESCR_EN"]) ? null : (System.String)dataRow["FRACTION_DESCR_EN"];
			entity.FractionValue = Convert.IsDBNull(dataRow["FRACTION_VALUE"]) ? null : (System.Int32?)dataRow["FRACTION_VALUE"];
			entity.ExchangeRate = Convert.IsDBNull(dataRow["EXCHANGE_RATE"]) ? null : (System.Decimal?)dataRow["EXCHANGE_RATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeCurrency"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeCurrency Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeCurrency entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeCurrencyId methods when available
			
			#region FeeInvoiceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeInvoice>|FeeInvoiceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeInvoiceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeInvoiceCollection = DataRepository.FeeInvoiceProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.FeeInvoiceCollection.Count > 0)
				{
					deepHandles.Add("FeeInvoiceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeInvoice>) DataRepository.FeeInvoiceProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeInvoiceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeUserFundReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeUserFundReq>|FeeUserFundReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeUserFundReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeUserFundReqCollection = DataRepository.FeeUserFundReqProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.FeeUserFundReqCollection.Count > 0)
				{
					deepHandles.Add("FeeUserFundReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeUserFundReq>) DataRepository.FeeUserFundReqProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeUserFundReqCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SpoSponsorOfferCollection = DataRepository.SpoSponsorOfferProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.SpoSponsorOfferCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorOfferCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorOffer>) DataRepository.SpoSponsorOfferProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorOfferCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeCdeBankAccntCollection = DataRepository.FeeCdeBankAccntProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.FeeCdeBankAccntCollection.Count > 0)
				{
					deepHandles.Add("FeeCdeBankAccntCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeCdeBankAccnt>) DataRepository.FeeCdeBankAccntProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeCdeBankAccntCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCdeFeeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCdeFee>|AdmCdeFeeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeFeeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCdeFeeCollection = DataRepository.AdmCdeFeeProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.AdmCdeFeeCollection.Count > 0)
				{
					deepHandles.Add("AdmCdeFeeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCdeFee>) DataRepository.AdmCdeFeeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCdeFeeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudInstallmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudInstallment>|FeeStudInstallmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudInstallmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudInstallmentCollection = DataRepository.FeeStudInstallmentProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.FeeStudInstallmentCollection.Count > 0)
				{
					deepHandles.Add("FeeStudInstallmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudInstallment>) DataRepository.FeeStudInstallmentProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudInstallmentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFacultyRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFacultyRuleCollection = DataRepository.FeeFacultyRuleProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.FeeFacultyRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacultyRule>) DataRepository.FeeFacultyRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacultyRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudAllowanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudAllowance>|FeeStudAllowanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudAllowanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudAllowanceCollection = DataRepository.FeeStudAllowanceProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.FeeStudAllowanceCollection.Count > 0)
				{
					deepHandles.Add("FeeStudAllowanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudAllowance>) DataRepository.FeeStudAllowanceProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudAllowanceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeAllowanceRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeAllowanceRule>|FeeAllowanceRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeAllowanceRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeAllowanceRuleCollection = DataRepository.FeeAllowanceRuleProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.FeeAllowanceRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeAllowanceRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeAllowanceRule>) DataRepository.FeeAllowanceRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeAllowanceRuleCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeRefndStdReqCollection = DataRepository.FeeRefndStdReqProvider.GetByCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.FeeRefndStdReqCollection.Count > 0)
				{
					deepHandles.Add("FeeRefndStdReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefndStdReq>) DataRepository.FeeRefndStdReqProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefndStdReqCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeStudFeeItemCollection = DataRepository.FeeStudFeeItemProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.FeeStudFeeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudFeeItem>) DataRepository.FeeStudFeeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudFeeItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeUserBondReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeUserBondReq>|FeeUserBondReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeUserBondReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeUserBondReqCollection = DataRepository.FeeUserBondReqProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.FeeUserBondReqCollection.Count > 0)
				{
					deepHandles.Add("FeeUserBondReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeUserBondReq>) DataRepository.FeeUserBondReqProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeUserBondReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCountryNodeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCountryNode>|GsCountryNodeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryNodeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCountryNodeCollection = DataRepository.GsCountryNodeProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.GsCountryNodeCollection.Count > 0)
				{
					deepHandles.Add("GsCountryNodeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCountryNode>) DataRepository.GsCountryNodeProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCountryNodeCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeStudVoucherCollection = DataRepository.FeeStudVoucherProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.FeeStudVoucherCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucher>) DataRepository.FeeStudVoucherProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmAppFeesCollection = DataRepository.AdmAppFeesProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.AdmAppFeesCollection.Count > 0)
				{
					deepHandles.Add("AdmAppFeesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppFees>) DataRepository.AdmAppFeesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppFeesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeSemesterAgendaCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeSemesterAgenda>|FeeSemesterAgendaCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeSemesterAgendaCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeSemesterAgendaCollection = DataRepository.FeeSemesterAgendaProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.FeeSemesterAgendaCollection.Count > 0)
				{
					deepHandles.Add("FeeSemesterAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeSemesterAgenda>) DataRepository.FeeSemesterAgendaProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeSemesterAgendaCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaTrainingCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaTrainingCourse>|SaTrainingCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaTrainingCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaTrainingCourseCollection = DataRepository.SaTrainingCourseProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.SaTrainingCourseCollection.Count > 0)
				{
					deepHandles.Add("SaTrainingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaTrainingCourse>) DataRepository.SaTrainingCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.SaTrainingCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudReq>|AccomStudReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudReqCollection = DataRepository.AccomStudReqProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.AccomStudReqCollection.Count > 0)
				{
					deepHandles.Add("AccomStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudReq>) DataRepository.AccomStudReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeAccomItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeAccomItem>|FeeAccomItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeAccomItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeAccomItemCollection = DataRepository.FeeAccomItemProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);

				if (deep && entity.FeeAccomItemCollection.Count > 0)
				{
					deepHandles.Add("FeeAccomItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeAccomItem>) DataRepository.FeeAccomItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeAccomItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeCurrency object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeCurrency instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeCurrency Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeCurrency entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<FeeInvoice>
				if (CanDeepSave(entity.FeeInvoiceCollection, "List<FeeInvoice>|FeeInvoiceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeInvoice child in entity.FeeInvoiceCollection)
					{
						if(child.GsCodeCurrencyIdSource != null)
						{
							child.GsCodeCurrencyId = child.GsCodeCurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.GsCodeCurrencyId = entity.GsCodeCurrencyId;
						}

					}

					if (entity.FeeInvoiceCollection.Count > 0 || entity.FeeInvoiceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeInvoiceProvider.Save(transactionManager, entity.FeeInvoiceCollection);
						
						deepHandles.Add("FeeInvoiceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeInvoice >) DataRepository.FeeInvoiceProvider.DeepSave,
							new object[] { transactionManager, entity.FeeInvoiceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeUserFundReq>
				if (CanDeepSave(entity.FeeUserFundReqCollection, "List<FeeUserFundReq>|FeeUserFundReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeUserFundReq child in entity.FeeUserFundReqCollection)
					{
						if(child.GsCodeCurrencyIdSource != null)
						{
							child.GsCodeCurrencyId = child.GsCodeCurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.GsCodeCurrencyId = entity.GsCodeCurrencyId;
						}

					}

					if (entity.FeeUserFundReqCollection.Count > 0 || entity.FeeUserFundReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeUserFundReqProvider.Save(transactionManager, entity.FeeUserFundReqCollection);
						
						deepHandles.Add("FeeUserFundReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeUserFundReq >) DataRepository.FeeUserFundReqProvider.DeepSave,
							new object[] { transactionManager, entity.FeeUserFundReqCollection, deepSaveType, childTypes, innerList }
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
						if(child.GsCodeCurrencyIdSource != null)
						{
							child.GsCodeCurrencyId = child.GsCodeCurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.GsCodeCurrencyId = entity.GsCodeCurrencyId;
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
				
	
			#region List<FeeCdeBankAccnt>
				if (CanDeepSave(entity.FeeCdeBankAccntCollection, "List<FeeCdeBankAccnt>|FeeCdeBankAccntCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeCdeBankAccnt child in entity.FeeCdeBankAccntCollection)
					{
						if(child.GsCodeCurrencyIdSource != null)
						{
							child.GsCodeCurrencyId = child.GsCodeCurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.GsCodeCurrencyId = entity.GsCodeCurrencyId;
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
				
	
			#region List<AdmCdeFee>
				if (CanDeepSave(entity.AdmCdeFeeCollection, "List<AdmCdeFee>|AdmCdeFeeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCdeFee child in entity.AdmCdeFeeCollection)
					{
						if(child.GsCodeCurrencyIdSource != null)
						{
							child.GsCodeCurrencyId = child.GsCodeCurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.GsCodeCurrencyId = entity.GsCodeCurrencyId;
						}

					}

					if (entity.AdmCdeFeeCollection.Count > 0 || entity.AdmCdeFeeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCdeFeeProvider.Save(transactionManager, entity.AdmCdeFeeCollection);
						
						deepHandles.Add("AdmCdeFeeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCdeFee >) DataRepository.AdmCdeFeeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCdeFeeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudInstallment>
				if (CanDeepSave(entity.FeeStudInstallmentCollection, "List<FeeStudInstallment>|FeeStudInstallmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudInstallment child in entity.FeeStudInstallmentCollection)
					{
						if(child.GsCodeCurrencyIdSource != null)
						{
							child.GsCodeCurrencyId = child.GsCodeCurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.GsCodeCurrencyId = entity.GsCodeCurrencyId;
						}

					}

					if (entity.FeeStudInstallmentCollection.Count > 0 || entity.FeeStudInstallmentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudInstallmentProvider.Save(transactionManager, entity.FeeStudInstallmentCollection);
						
						deepHandles.Add("FeeStudInstallmentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudInstallment >) DataRepository.FeeStudInstallmentProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudInstallmentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFacultyRule>
				if (CanDeepSave(entity.FeeFacultyRuleCollection, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFacultyRule child in entity.FeeFacultyRuleCollection)
					{
						if(child.GsCodeCurrencyIdSource != null)
						{
							child.GsCodeCurrencyId = child.GsCodeCurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.GsCodeCurrencyId = entity.GsCodeCurrencyId;
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
				
	
			#region List<FeeStudAllowance>
				if (CanDeepSave(entity.FeeStudAllowanceCollection, "List<FeeStudAllowance>|FeeStudAllowanceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudAllowance child in entity.FeeStudAllowanceCollection)
					{
						if(child.GsCodeCurrencyIdSource != null)
						{
							child.GsCodeCurrencyId = child.GsCodeCurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.GsCodeCurrencyId = entity.GsCodeCurrencyId;
						}

					}

					if (entity.FeeStudAllowanceCollection.Count > 0 || entity.FeeStudAllowanceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudAllowanceProvider.Save(transactionManager, entity.FeeStudAllowanceCollection);
						
						deepHandles.Add("FeeStudAllowanceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudAllowance >) DataRepository.FeeStudAllowanceProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudAllowanceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeAllowanceRule>
				if (CanDeepSave(entity.FeeAllowanceRuleCollection, "List<FeeAllowanceRule>|FeeAllowanceRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeAllowanceRule child in entity.FeeAllowanceRuleCollection)
					{
						if(child.GsCodeCurrencyIdSource != null)
						{
							child.GsCodeCurrencyId = child.GsCodeCurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.GsCodeCurrencyId = entity.GsCodeCurrencyId;
						}

					}

					if (entity.FeeAllowanceRuleCollection.Count > 0 || entity.FeeAllowanceRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeAllowanceRuleProvider.Save(transactionManager, entity.FeeAllowanceRuleCollection);
						
						deepHandles.Add("FeeAllowanceRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeAllowanceRule >) DataRepository.FeeAllowanceRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeAllowanceRuleCollection, deepSaveType, childTypes, innerList }
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
						if(child.CurrencyIdSource != null)
						{
							child.CurrencyId = child.CurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.CurrencyId = entity.GsCodeCurrencyId;
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
				
	
			#region List<FeeStudFeeItem>
				if (CanDeepSave(entity.FeeStudFeeItemCollection, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudFeeItem child in entity.FeeStudFeeItemCollection)
					{
						if(child.GsCodeCurrencyIdSource != null)
						{
							child.GsCodeCurrencyId = child.GsCodeCurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.GsCodeCurrencyId = entity.GsCodeCurrencyId;
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
				
	
			#region List<FeeUserBondReq>
				if (CanDeepSave(entity.FeeUserBondReqCollection, "List<FeeUserBondReq>|FeeUserBondReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeUserBondReq child in entity.FeeUserBondReqCollection)
					{
						if(child.GsCodeCurrencyIdSource != null)
						{
							child.GsCodeCurrencyId = child.GsCodeCurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.GsCodeCurrencyId = entity.GsCodeCurrencyId;
						}

					}

					if (entity.FeeUserBondReqCollection.Count > 0 || entity.FeeUserBondReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeUserBondReqProvider.Save(transactionManager, entity.FeeUserBondReqCollection);
						
						deepHandles.Add("FeeUserBondReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeUserBondReq >) DataRepository.FeeUserBondReqProvider.DeepSave,
							new object[] { transactionManager, entity.FeeUserBondReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCountryNode>
				if (CanDeepSave(entity.GsCountryNodeCollection, "List<GsCountryNode>|GsCountryNodeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCountryNode child in entity.GsCountryNodeCollection)
					{
						if(child.GsCodeCurrencyIdSource != null)
						{
							child.GsCodeCurrencyId = child.GsCodeCurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.GsCodeCurrencyId = entity.GsCodeCurrencyId;
						}

					}

					if (entity.GsCountryNodeCollection.Count > 0 || entity.GsCountryNodeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryNodeCollection);
						
						deepHandles.Add("GsCountryNodeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCountryNode >) DataRepository.GsCountryNodeProvider.DeepSave,
							new object[] { transactionManager, entity.GsCountryNodeCollection, deepSaveType, childTypes, innerList }
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
						if(child.GsCodeCurrencyIdSource != null)
						{
							child.GsCodeCurrencyId = child.GsCodeCurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.GsCodeCurrencyId = entity.GsCodeCurrencyId;
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
				
	
			#region List<AdmAppFees>
				if (CanDeepSave(entity.AdmAppFeesCollection, "List<AdmAppFees>|AdmAppFeesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppFees child in entity.AdmAppFeesCollection)
					{
						if(child.GsCodeCurrencyIdSource != null)
						{
							child.GsCodeCurrencyId = child.GsCodeCurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.GsCodeCurrencyId = entity.GsCodeCurrencyId;
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
				
	
			#region List<FeeSemesterAgenda>
				if (CanDeepSave(entity.FeeSemesterAgendaCollection, "List<FeeSemesterAgenda>|FeeSemesterAgendaCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeSemesterAgenda child in entity.FeeSemesterAgendaCollection)
					{
						if(child.GsCodeCurrencyIdSource != null)
						{
							child.GsCodeCurrencyId = child.GsCodeCurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.GsCodeCurrencyId = entity.GsCodeCurrencyId;
						}

					}

					if (entity.FeeSemesterAgendaCollection.Count > 0 || entity.FeeSemesterAgendaCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeSemesterAgendaProvider.Save(transactionManager, entity.FeeSemesterAgendaCollection);
						
						deepHandles.Add("FeeSemesterAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeSemesterAgenda >) DataRepository.FeeSemesterAgendaProvider.DeepSave,
							new object[] { transactionManager, entity.FeeSemesterAgendaCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaTrainingCourse>
				if (CanDeepSave(entity.SaTrainingCourseCollection, "List<SaTrainingCourse>|SaTrainingCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaTrainingCourse child in entity.SaTrainingCourseCollection)
					{
						if(child.GsCodeCurrencyIdSource != null)
						{
							child.GsCodeCurrencyId = child.GsCodeCurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.GsCodeCurrencyId = entity.GsCodeCurrencyId;
						}

					}

					if (entity.SaTrainingCourseCollection.Count > 0 || entity.SaTrainingCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaTrainingCourseProvider.Save(transactionManager, entity.SaTrainingCourseCollection);
						
						deepHandles.Add("SaTrainingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaTrainingCourse >) DataRepository.SaTrainingCourseProvider.DeepSave,
							new object[] { transactionManager, entity.SaTrainingCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudReq>
				if (CanDeepSave(entity.AccomStudReqCollection, "List<AccomStudReq>|AccomStudReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudReq child in entity.AccomStudReqCollection)
					{
						if(child.GsCodeCurrencyIdSource != null)
						{
							child.GsCodeCurrencyId = child.GsCodeCurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.GsCodeCurrencyId = entity.GsCodeCurrencyId;
						}

					}

					if (entity.AccomStudReqCollection.Count > 0 || entity.AccomStudReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudReqProvider.Save(transactionManager, entity.AccomStudReqCollection);
						
						deepHandles.Add("AccomStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudReq >) DataRepository.AccomStudReqProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeAccomItem>
				if (CanDeepSave(entity.FeeAccomItemCollection, "List<FeeAccomItem>|FeeAccomItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeAccomItem child in entity.FeeAccomItemCollection)
					{
						if(child.GsCodeCurrencyIdSource != null)
						{
							child.GsCodeCurrencyId = child.GsCodeCurrencyIdSource.GsCodeCurrencyId;
						}
						else
						{
							child.GsCodeCurrencyId = entity.GsCodeCurrencyId;
						}

					}

					if (entity.FeeAccomItemCollection.Count > 0 || entity.FeeAccomItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeAccomItemProvider.Save(transactionManager, entity.FeeAccomItemCollection);
						
						deepHandles.Add("FeeAccomItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeAccomItem >) DataRepository.FeeAccomItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeAccomItemCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCodeCurrencyChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeCurrency</c>
	///</summary>
	public enum GsCodeCurrencyChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for FeeInvoiceCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeInvoice>))]
		FeeInvoiceCollection,
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for FeeUserFundReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeUserFundReq>))]
		FeeUserFundReqCollection,
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for SpoSponsorOfferCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorOffer>))]
		SpoSponsorOfferCollection,
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for FeeCdeBankAccntCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeCdeBankAccnt>))]
		FeeCdeBankAccntCollection,
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for AdmCdeFeeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCdeFee>))]
		AdmCdeFeeCollection,
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for FeeStudInstallmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudInstallment>))]
		FeeStudInstallmentCollection,
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for FeeFacultyRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacultyRule>))]
		FeeFacultyRuleCollection,
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for FeeStudAllowanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudAllowance>))]
		FeeStudAllowanceCollection,
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for FeeAllowanceRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeAllowanceRule>))]
		FeeAllowanceRuleCollection,
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for FeeRefndStdReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefndStdReq>))]
		FeeRefndStdReqCollection,
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for FeeStudFeeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudFeeItem>))]
		FeeStudFeeItemCollection,
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for FeeUserBondReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeUserBondReq>))]
		FeeUserBondReqCollection,
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for GsCountryNodeCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCountryNode>))]
		GsCountryNodeCollection,
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for FeeStudVoucherCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucher>))]
		FeeStudVoucherCollection,
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for AdmAppFeesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppFees>))]
		AdmAppFeesCollection,
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for FeeSemesterAgendaCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeSemesterAgenda>))]
		FeeSemesterAgendaCollection,
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for SaTrainingCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaTrainingCourse>))]
		SaTrainingCourseCollection,
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for AccomStudReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudReq>))]
		AccomStudReqCollection,
		///<summary>
		/// Collection of <c>GsCodeCurrency</c> as OneToMany for FeeAccomItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeAccomItem>))]
		FeeAccomItemCollection,
	}
	
	#endregion GsCodeCurrencyChildEntityTypes
	
	#region GsCodeCurrencyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeCurrencyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeCurrency"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeCurrencyFilterBuilder : SqlFilterBuilder<GsCodeCurrencyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeCurrencyFilterBuilder class.
		/// </summary>
		public GsCodeCurrencyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeCurrencyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeCurrencyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeCurrencyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeCurrencyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeCurrencyFilterBuilder
	
	#region GsCodeCurrencyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeCurrencyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeCurrency"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeCurrencyParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeCurrencyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeCurrencyParameterBuilder class.
		/// </summary>
		public GsCodeCurrencyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeCurrencyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeCurrencyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeCurrencyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeCurrencyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeCurrencyParameterBuilder
	
	#region GsCodeCurrencySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeCurrencyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeCurrency"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeCurrencySortBuilder : SqlSortBuilder<GsCodeCurrencyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeCurrencySqlSortBuilder class.
		/// </summary>
		public GsCodeCurrencySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeCurrencySortBuilder
	
} // end namespace
