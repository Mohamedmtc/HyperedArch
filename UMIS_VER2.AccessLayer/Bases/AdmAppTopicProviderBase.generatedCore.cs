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
	/// This class is the base class for any <see cref="AdmAppTopicProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppTopicProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppTopic, UMIS_VER2.BusinessLyer.AdmAppTopicKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTopicKey key)
		{
			return Delete(transactionManager, key.AdmAppTopicId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppTopicId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppTopicId)
		{
			return Delete(null, _admAppTopicId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTopicId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppTopicId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TOPIC_ADM_APP_PREF key.
		///		FK_ADM_APP_TOPIC_ADM_APP_PREF Description: 
		/// </summary>
		/// <param name="_admAppPrefId">Pref_Number_Min &Pref_Number_Max>1</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTopic objects.</returns>
		public TList<AdmAppTopic> GetByAdmAppPrefId(System.Decimal _admAppPrefId)
		{
			int count = -1;
			return GetByAdmAppPrefId(_admAppPrefId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TOPIC_ADM_APP_PREF key.
		///		FK_ADM_APP_TOPIC_ADM_APP_PREF Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppPrefId">Pref_Number_Min &Pref_Number_Max>1</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTopic objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppTopic> GetByAdmAppPrefId(TransactionManager transactionManager, System.Decimal _admAppPrefId)
		{
			int count = -1;
			return GetByAdmAppPrefId(transactionManager, _admAppPrefId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TOPIC_ADM_APP_PREF key.
		///		FK_ADM_APP_TOPIC_ADM_APP_PREF Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppPrefId">Pref_Number_Min &Pref_Number_Max>1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTopic objects.</returns>
		public TList<AdmAppTopic> GetByAdmAppPrefId(TransactionManager transactionManager, System.Decimal _admAppPrefId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppPrefId(transactionManager, _admAppPrefId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TOPIC_ADM_APP_PREF key.
		///		fkAdmAppTopicAdmAppPref Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppPrefId">Pref_Number_Min &Pref_Number_Max>1</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTopic objects.</returns>
		public TList<AdmAppTopic> GetByAdmAppPrefId(System.Decimal _admAppPrefId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppPrefId(null, _admAppPrefId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TOPIC_ADM_APP_PREF key.
		///		fkAdmAppTopicAdmAppPref Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppPrefId">Pref_Number_Min &Pref_Number_Max>1</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTopic objects.</returns>
		public TList<AdmAppTopic> GetByAdmAppPrefId(System.Decimal _admAppPrefId, int start, int pageLength,out int count)
		{
			return GetByAdmAppPrefId(null, _admAppPrefId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TOPIC_ADM_APP_PREF key.
		///		FK_ADM_APP_TOPIC_ADM_APP_PREF Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppPrefId">Pref_Number_Min &Pref_Number_Max>1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTopic objects.</returns>
		public abstract TList<AdmAppTopic> GetByAdmAppPrefId(TransactionManager transactionManager, System.Decimal _admAppPrefId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TOPIC_PG_OFFERING_TOPIC key.
		///		FK_ADM_APP_TOPIC_PG_OFFERING_TOPIC Description: 
		/// </summary>
		/// <param name="_pgOfferingTopicId">مواضيع البحث المطروحة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTopic objects.</returns>
		public TList<AdmAppTopic> GetByPgOfferingTopicId(System.Int32 _pgOfferingTopicId)
		{
			int count = -1;
			return GetByPgOfferingTopicId(_pgOfferingTopicId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TOPIC_PG_OFFERING_TOPIC key.
		///		FK_ADM_APP_TOPIC_PG_OFFERING_TOPIC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgOfferingTopicId">مواضيع البحث المطروحة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTopic objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppTopic> GetByPgOfferingTopicId(TransactionManager transactionManager, System.Int32 _pgOfferingTopicId)
		{
			int count = -1;
			return GetByPgOfferingTopicId(transactionManager, _pgOfferingTopicId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TOPIC_PG_OFFERING_TOPIC key.
		///		FK_ADM_APP_TOPIC_PG_OFFERING_TOPIC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgOfferingTopicId">مواضيع البحث المطروحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTopic objects.</returns>
		public TList<AdmAppTopic> GetByPgOfferingTopicId(TransactionManager transactionManager, System.Int32 _pgOfferingTopicId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgOfferingTopicId(transactionManager, _pgOfferingTopicId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TOPIC_PG_OFFERING_TOPIC key.
		///		fkAdmAppTopicPgOfferingTopic Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgOfferingTopicId">مواضيع البحث المطروحة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTopic objects.</returns>
		public TList<AdmAppTopic> GetByPgOfferingTopicId(System.Int32 _pgOfferingTopicId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgOfferingTopicId(null, _pgOfferingTopicId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TOPIC_PG_OFFERING_TOPIC key.
		///		fkAdmAppTopicPgOfferingTopic Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgOfferingTopicId">مواضيع البحث المطروحة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTopic objects.</returns>
		public TList<AdmAppTopic> GetByPgOfferingTopicId(System.Int32 _pgOfferingTopicId, int start, int pageLength,out int count)
		{
			return GetByPgOfferingTopicId(null, _pgOfferingTopicId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TOPIC_PG_OFFERING_TOPIC key.
		///		FK_ADM_APP_TOPIC_PG_OFFERING_TOPIC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgOfferingTopicId">مواضيع البحث المطروحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTopic objects.</returns>
		public abstract TList<AdmAppTopic> GetByPgOfferingTopicId(TransactionManager transactionManager, System.Int32 _pgOfferingTopicId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppTopic Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTopicKey key, int start, int pageLength)
		{
			return GetByAdmAppTopicId(transactionManager, key.AdmAppTopicId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_TOPIC index.
		/// </summary>
		/// <param name="_admAppTopicId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTopic GetByAdmAppTopicId(System.Decimal _admAppTopicId)
		{
			int count = -1;
			return GetByAdmAppTopicId(null,_admAppTopicId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TOPIC index.
		/// </summary>
		/// <param name="_admAppTopicId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTopic GetByAdmAppTopicId(System.Decimal _admAppTopicId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTopicId(null, _admAppTopicId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TOPIC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTopicId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTopic GetByAdmAppTopicId(TransactionManager transactionManager, System.Decimal _admAppTopicId)
		{
			int count = -1;
			return GetByAdmAppTopicId(transactionManager, _admAppTopicId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TOPIC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTopicId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTopic GetByAdmAppTopicId(TransactionManager transactionManager, System.Decimal _admAppTopicId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTopicId(transactionManager, _admAppTopicId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TOPIC index.
		/// </summary>
		/// <param name="_admAppTopicId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTopic GetByAdmAppTopicId(System.Decimal _admAppTopicId, int start, int pageLength, out int count)
		{
			return GetByAdmAppTopicId(null, _admAppTopicId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TOPIC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTopicId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTopic"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppTopic GetByAdmAppTopicId(TransactionManager transactionManager, System.Decimal _admAppTopicId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppTopic&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppTopic&gt;"/></returns>
		public static TList<AdmAppTopic> Fill(IDataReader reader, TList<AdmAppTopic> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppTopic c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppTopic")
					.Append("|").Append((System.Decimal)reader["ADM_APP_TOPIC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppTopic>(
					key.ToString(), // EntityTrackingKey
					"AdmAppTopic",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppTopic();
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
					c.AdmAppTopicId = (System.Decimal)reader["ADM_APP_TOPIC_ID"];
					c.OriginalAdmAppTopicId = c.AdmAppTopicId;
					c.AdmAppPrefId = (System.Decimal)reader["ADM_APP_PREF_ID"];
					c.PgOfferingTopicId = (System.Int32)reader["PG_OFFERING_TOPIC_ID"];
					c.TopicOrder = (System.Decimal)reader["TOPIC_ORDER"];
					c.ApproveFlg = (System.Decimal)reader["APPROVE_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppTopic"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppTopic"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppTopic entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppTopicId = (System.Decimal)reader[((int)AdmAppTopicColumn.AdmAppTopicId - 1)];
			entity.OriginalAdmAppTopicId = (System.Decimal)reader["ADM_APP_TOPIC_ID"];
			entity.AdmAppPrefId = (System.Decimal)reader[((int)AdmAppTopicColumn.AdmAppPrefId - 1)];
			entity.PgOfferingTopicId = (System.Int32)reader[((int)AdmAppTopicColumn.PgOfferingTopicId - 1)];
			entity.TopicOrder = (System.Decimal)reader[((int)AdmAppTopicColumn.TopicOrder - 1)];
			entity.ApproveFlg = (System.Decimal)reader[((int)AdmAppTopicColumn.ApproveFlg - 1)];
			entity.Notes = (reader.IsDBNull(((int)AdmAppTopicColumn.Notes - 1)))?null:(System.String)reader[((int)AdmAppTopicColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmAppTopicColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmAppTopicColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmAppTopicColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppTopicColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppTopic"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppTopic"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppTopic entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppTopicId = (System.Decimal)dataRow["ADM_APP_TOPIC_ID"];
			entity.OriginalAdmAppTopicId = (System.Decimal)dataRow["ADM_APP_TOPIC_ID"];
			entity.AdmAppPrefId = (System.Decimal)dataRow["ADM_APP_PREF_ID"];
			entity.PgOfferingTopicId = (System.Int32)dataRow["PG_OFFERING_TOPIC_ID"];
			entity.TopicOrder = (System.Decimal)dataRow["TOPIC_ORDER"];
			entity.ApproveFlg = (System.Decimal)dataRow["APPROVE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppTopic"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppTopic Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTopic entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppPrefIdSource	
			if (CanDeepLoad(entity, "AdmAppPref|AdmAppPrefIdSource", deepLoadType, innerList) 
				&& entity.AdmAppPrefIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmAppPrefId;
				AdmAppPref tmpEntity = EntityManager.LocateEntity<AdmAppPref>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppPref), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppPrefIdSource = tmpEntity;
				else
					entity.AdmAppPrefIdSource = DataRepository.AdmAppPrefProvider.GetByAdmAppPrefId(transactionManager, entity.AdmAppPrefId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppPrefIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppPrefIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppPrefProvider.DeepLoad(transactionManager, entity.AdmAppPrefIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppPrefIdSource

			#region PgOfferingTopicIdSource	
			if (CanDeepLoad(entity, "PgOfferingTopic|PgOfferingTopicIdSource", deepLoadType, innerList) 
				&& entity.PgOfferingTopicIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgOfferingTopicId;
				PgOfferingTopic tmpEntity = EntityManager.LocateEntity<PgOfferingTopic>(EntityLocator.ConstructKeyFromPkItems(typeof(PgOfferingTopic), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgOfferingTopicIdSource = tmpEntity;
				else
					entity.PgOfferingTopicIdSource = DataRepository.PgOfferingTopicProvider.GetByPgOfferingTopicId(transactionManager, entity.PgOfferingTopicId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgOfferingTopicIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgOfferingTopicIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgOfferingTopicProvider.DeepLoad(transactionManager, entity.PgOfferingTopicIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgOfferingTopicIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppTopic object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppTopic instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppTopic Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTopic entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAppPrefIdSource
			if (CanDeepSave(entity, "AdmAppPref|AdmAppPrefIdSource", deepSaveType, innerList) 
				&& entity.AdmAppPrefIdSource != null)
			{
				DataRepository.AdmAppPrefProvider.Save(transactionManager, entity.AdmAppPrefIdSource);
				entity.AdmAppPrefId = entity.AdmAppPrefIdSource.AdmAppPrefId;
			}
			#endregion 
			
			#region PgOfferingTopicIdSource
			if (CanDeepSave(entity, "PgOfferingTopic|PgOfferingTopicIdSource", deepSaveType, innerList) 
				&& entity.PgOfferingTopicIdSource != null)
			{
				DataRepository.PgOfferingTopicProvider.Save(transactionManager, entity.PgOfferingTopicIdSource);
				entity.PgOfferingTopicId = entity.PgOfferingTopicIdSource.PgOfferingTopicId;
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
	
	#region AdmAppTopicChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppTopic</c>
	///</summary>
	public enum AdmAppTopicChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppPref</c> at AdmAppPrefIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppPref))]
		AdmAppPref,
		
		///<summary>
		/// Composite Property for <c>PgOfferingTopic</c> at PgOfferingTopicIdSource
		///</summary>
		[ChildEntityType(typeof(PgOfferingTopic))]
		PgOfferingTopic,
	}
	
	#endregion AdmAppTopicChildEntityTypes
	
	#region AdmAppTopicFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppTopicColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppTopic"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppTopicFilterBuilder : SqlFilterBuilder<AdmAppTopicColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppTopicFilterBuilder class.
		/// </summary>
		public AdmAppTopicFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTopicFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppTopicFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTopicFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppTopicFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppTopicFilterBuilder
	
	#region AdmAppTopicParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppTopicColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppTopic"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppTopicParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppTopicColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppTopicParameterBuilder class.
		/// </summary>
		public AdmAppTopicParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTopicParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppTopicParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTopicParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppTopicParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppTopicParameterBuilder
	
	#region AdmAppTopicSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppTopicColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppTopic"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppTopicSortBuilder : SqlSortBuilder<AdmAppTopicColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppTopicSqlSortBuilder class.
		/// </summary>
		public AdmAppTopicSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppTopicSortBuilder
	
} // end namespace
