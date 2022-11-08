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
	/// This class is the base class for any <see cref="SpoOfferContinueProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SpoOfferContinueProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SpoOfferContinue, UMIS_VER2.BusinessLyer.SpoOfferContinueKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoOfferContinueKey key)
		{
			return Delete(transactionManager, key.SpoSponsorContinueId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_spoSponsorContinueId">شروط استمرار الكفالة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _spoSponsorContinueId)
		{
			return Delete(null, _spoSponsorContinueId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorContinueId">شروط استمرار الكفالة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _spoSponsorContinueId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_CONTINUE_SPO_SPONSOR_OFFER key.
		///		FK_SPO_OFFER_CONTINUE_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="_spoSponsorOfferId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferContinue objects.</returns>
		public TList<SpoOfferContinue> GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(_spoSponsorOfferId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_CONTINUE_SPO_SPONSOR_OFFER key.
		///		FK_SPO_OFFER_CONTINUE_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferContinue objects.</returns>
		/// <remarks></remarks>
		public TList<SpoOfferContinue> GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(transactionManager, _spoSponsorOfferId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_CONTINUE_SPO_SPONSOR_OFFER key.
		///		FK_SPO_OFFER_CONTINUE_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferContinue objects.</returns>
		public TList<SpoOfferContinue> GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(transactionManager, _spoSponsorOfferId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_CONTINUE_SPO_SPONSOR_OFFER key.
		///		fkSpoOfferContinueSpoSponsorOffer Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferContinue objects.</returns>
		public TList<SpoOfferContinue> GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorOfferId(null, _spoSponsorOfferId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_CONTINUE_SPO_SPONSOR_OFFER key.
		///		fkSpoOfferContinueSpoSponsorOffer Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferContinue objects.</returns>
		public TList<SpoOfferContinue> GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorOfferId(null, _spoSponsorOfferId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_CONTINUE_SPO_SPONSOR_OFFER key.
		///		FK_SPO_OFFER_CONTINUE_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferContinue objects.</returns>
		public abstract TList<SpoOfferContinue> GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SpoOfferContinue Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoOfferContinueKey key, int start, int pageLength)
		{
			return GetBySpoSponsorContinueId(transactionManager, key.SpoSponsorContinueId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SPO_OFFER_CONTINUE index.
		/// </summary>
		/// <param name="_spoSponsorContinueId">شروط استمرار الكفالة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoOfferContinue"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoOfferContinue GetBySpoSponsorContinueId(System.Decimal _spoSponsorContinueId)
		{
			int count = -1;
			return GetBySpoSponsorContinueId(null,_spoSponsorContinueId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_OFFER_CONTINUE index.
		/// </summary>
		/// <param name="_spoSponsorContinueId">شروط استمرار الكفالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoOfferContinue"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoOfferContinue GetBySpoSponsorContinueId(System.Decimal _spoSponsorContinueId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorContinueId(null, _spoSponsorContinueId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_OFFER_CONTINUE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorContinueId">شروط استمرار الكفالة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoOfferContinue"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoOfferContinue GetBySpoSponsorContinueId(TransactionManager transactionManager, System.Decimal _spoSponsorContinueId)
		{
			int count = -1;
			return GetBySpoSponsorContinueId(transactionManager, _spoSponsorContinueId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_OFFER_CONTINUE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorContinueId">شروط استمرار الكفالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoOfferContinue"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoOfferContinue GetBySpoSponsorContinueId(TransactionManager transactionManager, System.Decimal _spoSponsorContinueId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorContinueId(transactionManager, _spoSponsorContinueId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_OFFER_CONTINUE index.
		/// </summary>
		/// <param name="_spoSponsorContinueId">شروط استمرار الكفالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoOfferContinue"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoOfferContinue GetBySpoSponsorContinueId(System.Decimal _spoSponsorContinueId, int start, int pageLength, out int count)
		{
			return GetBySpoSponsorContinueId(null, _spoSponsorContinueId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_OFFER_CONTINUE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorContinueId">شروط استمرار الكفالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoOfferContinue"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SpoOfferContinue GetBySpoSponsorContinueId(TransactionManager transactionManager, System.Decimal _spoSponsorContinueId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SpoOfferContinue&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SpoOfferContinue&gt;"/></returns>
		public static TList<SpoOfferContinue> Fill(IDataReader reader, TList<SpoOfferContinue> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SpoOfferContinue c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SpoOfferContinue")
					.Append("|").Append((System.Decimal)reader["SPO_SPONSOR_CONTINUE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SpoOfferContinue>(
					key.ToString(), // EntityTrackingKey
					"SpoOfferContinue",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SpoOfferContinue();
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
					c.SpoSponsorContinueId = (System.Decimal)reader["SPO_SPONSOR_CONTINUE_ID"];
					c.OriginalSpoSponsorContinueId = c.SpoSponsorContinueId;
					c.SpoSponsorOfferId = (System.Decimal)reader["SPO_SPONSOR_OFFER_ID"];
					c.AccumGpaFrom = Convert.IsDBNull(reader["ACCUM_GPA_FROM"]) ? null : (System.Decimal?)reader["ACCUM_GPA_FROM"];
					c.AccumGpaTo = Convert.IsDBNull(reader["ACCUM_GPA_TO"]) ? null : (System.Decimal?)reader["ACCUM_GPA_TO"];
					c.AccumChFrom = Convert.IsDBNull(reader["ACCUM_CH_FROM"]) ? null : (System.Decimal?)reader["ACCUM_CH_FROM"];
					c.AccumChTo = Convert.IsDBNull(reader["ACCUM_CH_TO"]) ? null : (System.Decimal?)reader["ACCUM_CH_TO"];
					c.ActvtyFlg = Convert.IsDBNull(reader["ACTVTY_FLG"]) ? null : (System.Boolean?)reader["ACTVTY_FLG"];
					c.FailCrsFlg = Convert.IsDBNull(reader["FAIL_CRS_FLG"]) ? null : (System.Boolean?)reader["FAIL_CRS_FLG"];
					c.SpoPercent = Convert.IsDBNull(reader["SPO_PERCENT"]) ? null : (System.Decimal?)reader["SPO_PERCENT"];
					c.SpoAmount = Convert.IsDBNull(reader["SPO_AMOUNT"]) ? null : (System.Decimal?)reader["SPO_AMOUNT"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoOfferContinue"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoOfferContinue"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SpoOfferContinue entity)
		{
			if (!reader.Read()) return;
			
			entity.SpoSponsorContinueId = (System.Decimal)reader[((int)SpoOfferContinueColumn.SpoSponsorContinueId - 1)];
			entity.OriginalSpoSponsorContinueId = (System.Decimal)reader["SPO_SPONSOR_CONTINUE_ID"];
			entity.SpoSponsorOfferId = (System.Decimal)reader[((int)SpoOfferContinueColumn.SpoSponsorOfferId - 1)];
			entity.AccumGpaFrom = (reader.IsDBNull(((int)SpoOfferContinueColumn.AccumGpaFrom - 1)))?null:(System.Decimal?)reader[((int)SpoOfferContinueColumn.AccumGpaFrom - 1)];
			entity.AccumGpaTo = (reader.IsDBNull(((int)SpoOfferContinueColumn.AccumGpaTo - 1)))?null:(System.Decimal?)reader[((int)SpoOfferContinueColumn.AccumGpaTo - 1)];
			entity.AccumChFrom = (reader.IsDBNull(((int)SpoOfferContinueColumn.AccumChFrom - 1)))?null:(System.Decimal?)reader[((int)SpoOfferContinueColumn.AccumChFrom - 1)];
			entity.AccumChTo = (reader.IsDBNull(((int)SpoOfferContinueColumn.AccumChTo - 1)))?null:(System.Decimal?)reader[((int)SpoOfferContinueColumn.AccumChTo - 1)];
			entity.ActvtyFlg = (reader.IsDBNull(((int)SpoOfferContinueColumn.ActvtyFlg - 1)))?null:(System.Boolean?)reader[((int)SpoOfferContinueColumn.ActvtyFlg - 1)];
			entity.FailCrsFlg = (reader.IsDBNull(((int)SpoOfferContinueColumn.FailCrsFlg - 1)))?null:(System.Boolean?)reader[((int)SpoOfferContinueColumn.FailCrsFlg - 1)];
			entity.SpoPercent = (reader.IsDBNull(((int)SpoOfferContinueColumn.SpoPercent - 1)))?null:(System.Decimal?)reader[((int)SpoOfferContinueColumn.SpoPercent - 1)];
			entity.SpoAmount = (reader.IsDBNull(((int)SpoOfferContinueColumn.SpoAmount - 1)))?null:(System.Decimal?)reader[((int)SpoOfferContinueColumn.SpoAmount - 1)];
			entity.Notes = (reader.IsDBNull(((int)SpoOfferContinueColumn.Notes - 1)))?null:(System.String)reader[((int)SpoOfferContinueColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)SpoOfferContinueColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)SpoOfferContinueColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SpoOfferContinueColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SpoOfferContinueColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoOfferContinue"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoOfferContinue"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SpoOfferContinue entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SpoSponsorContinueId = (System.Decimal)dataRow["SPO_SPONSOR_CONTINUE_ID"];
			entity.OriginalSpoSponsorContinueId = (System.Decimal)dataRow["SPO_SPONSOR_CONTINUE_ID"];
			entity.SpoSponsorOfferId = (System.Decimal)dataRow["SPO_SPONSOR_OFFER_ID"];
			entity.AccumGpaFrom = Convert.IsDBNull(dataRow["ACCUM_GPA_FROM"]) ? null : (System.Decimal?)dataRow["ACCUM_GPA_FROM"];
			entity.AccumGpaTo = Convert.IsDBNull(dataRow["ACCUM_GPA_TO"]) ? null : (System.Decimal?)dataRow["ACCUM_GPA_TO"];
			entity.AccumChFrom = Convert.IsDBNull(dataRow["ACCUM_CH_FROM"]) ? null : (System.Decimal?)dataRow["ACCUM_CH_FROM"];
			entity.AccumChTo = Convert.IsDBNull(dataRow["ACCUM_CH_TO"]) ? null : (System.Decimal?)dataRow["ACCUM_CH_TO"];
			entity.ActvtyFlg = Convert.IsDBNull(dataRow["ACTVTY_FLG"]) ? null : (System.Boolean?)dataRow["ACTVTY_FLG"];
			entity.FailCrsFlg = Convert.IsDBNull(dataRow["FAIL_CRS_FLG"]) ? null : (System.Boolean?)dataRow["FAIL_CRS_FLG"];
			entity.SpoPercent = Convert.IsDBNull(dataRow["SPO_PERCENT"]) ? null : (System.Decimal?)dataRow["SPO_PERCENT"];
			entity.SpoAmount = Convert.IsDBNull(dataRow["SPO_AMOUNT"]) ? null : (System.Decimal?)dataRow["SPO_AMOUNT"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoOfferContinue"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoOfferContinue Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoOfferContinue entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SpoSponsorOfferIdSource	
			if (CanDeepLoad(entity, "SpoSponsorOffer|SpoSponsorOfferIdSource", deepLoadType, innerList) 
				&& entity.SpoSponsorOfferIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SpoSponsorOfferId;
				SpoSponsorOffer tmpEntity = EntityManager.LocateEntity<SpoSponsorOffer>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoSponsorOffer), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoSponsorOfferIdSource = tmpEntity;
				else
					entity.SpoSponsorOfferIdSource = DataRepository.SpoSponsorOfferProvider.GetBySpoSponsorOfferId(transactionManager, entity.SpoSponsorOfferId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorOfferIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SpoSponsorOfferIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SpoSponsorOfferProvider.DeepLoad(transactionManager, entity.SpoSponsorOfferIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SpoSponsorOfferIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SpoOfferContinue object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SpoOfferContinue instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoOfferContinue Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoOfferContinue entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SpoSponsorOfferIdSource
			if (CanDeepSave(entity, "SpoSponsorOffer|SpoSponsorOfferIdSource", deepSaveType, innerList) 
				&& entity.SpoSponsorOfferIdSource != null)
			{
				DataRepository.SpoSponsorOfferProvider.Save(transactionManager, entity.SpoSponsorOfferIdSource);
				entity.SpoSponsorOfferId = entity.SpoSponsorOfferIdSource.SpoSponsorOfferId;
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
	
	#region SpoOfferContinueChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SpoOfferContinue</c>
	///</summary>
	public enum SpoOfferContinueChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SpoSponsorOffer</c> at SpoSponsorOfferIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsorOffer))]
		SpoSponsorOffer,
	}
	
	#endregion SpoOfferContinueChildEntityTypes
	
	#region SpoOfferContinueFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SpoOfferContinueColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoOfferContinue"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoOfferContinueFilterBuilder : SqlFilterBuilder<SpoOfferContinueColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoOfferContinueFilterBuilder class.
		/// </summary>
		public SpoOfferContinueFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoOfferContinueFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoOfferContinueFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoOfferContinueFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoOfferContinueFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoOfferContinueFilterBuilder
	
	#region SpoOfferContinueParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SpoOfferContinueColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoOfferContinue"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoOfferContinueParameterBuilder : ParameterizedSqlFilterBuilder<SpoOfferContinueColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoOfferContinueParameterBuilder class.
		/// </summary>
		public SpoOfferContinueParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoOfferContinueParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoOfferContinueParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoOfferContinueParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoOfferContinueParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoOfferContinueParameterBuilder
	
	#region SpoOfferContinueSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SpoOfferContinueColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoOfferContinue"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SpoOfferContinueSortBuilder : SqlSortBuilder<SpoOfferContinueColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoOfferContinueSqlSortBuilder class.
		/// </summary>
		public SpoOfferContinueSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SpoOfferContinueSortBuilder
	
} // end namespace
