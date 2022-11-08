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
	/// This class is the base class for any <see cref="SaStfDocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaStfDocProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaStfDoc, UMIS_VER2.BusinessLyer.SaStfDocKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaStfDocKey key)
		{
			return Delete(transactionManager, key.SaStfDocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saStfDocId">staff files-documents. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saStfDocId)
		{
			return Delete(null, _saStfDocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfDocId">staff files-documents. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saStfDocId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_DOC_SA_CODE_DOC key.
		///		FK_SA_STF_DOC_SA_CODE_DOC Description: 
		/// </summary>
		/// <param name="_saCodeDocId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfDoc objects.</returns>
		public TList<SaStfDoc> GetBySaCodeDocId(System.Decimal _saCodeDocId)
		{
			int count = -1;
			return GetBySaCodeDocId(_saCodeDocId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_DOC_SA_CODE_DOC key.
		///		FK_SA_STF_DOC_SA_CODE_DOC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeDocId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfDoc objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfDoc> GetBySaCodeDocId(TransactionManager transactionManager, System.Decimal _saCodeDocId)
		{
			int count = -1;
			return GetBySaCodeDocId(transactionManager, _saCodeDocId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_DOC_SA_CODE_DOC key.
		///		FK_SA_STF_DOC_SA_CODE_DOC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfDoc objects.</returns>
		public TList<SaStfDoc> GetBySaCodeDocId(TransactionManager transactionManager, System.Decimal _saCodeDocId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeDocId(transactionManager, _saCodeDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_DOC_SA_CODE_DOC key.
		///		fkSaStfDocSaCodeDoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeDocId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfDoc objects.</returns>
		public TList<SaStfDoc> GetBySaCodeDocId(System.Decimal _saCodeDocId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeDocId(null, _saCodeDocId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_DOC_SA_CODE_DOC key.
		///		fkSaStfDocSaCodeDoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeDocId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfDoc objects.</returns>
		public TList<SaStfDoc> GetBySaCodeDocId(System.Decimal _saCodeDocId, int start, int pageLength,out int count)
		{
			return GetBySaCodeDocId(null, _saCodeDocId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_DOC_SA_CODE_DOC key.
		///		FK_SA_STF_DOC_SA_CODE_DOC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfDoc objects.</returns>
		public abstract TList<SaStfDoc> GetBySaCodeDocId(TransactionManager transactionManager, System.Decimal _saCodeDocId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_DOC_SA_STF_MEMBER key.
		///		FK_SA_STF_DOC_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfDoc objects.</returns>
		public TList<SaStfDoc> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_DOC_SA_STF_MEMBER key.
		///		FK_SA_STF_DOC_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfDoc objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfDoc> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_DOC_SA_STF_MEMBER key.
		///		FK_SA_STF_DOC_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfDoc objects.</returns>
		public TList<SaStfDoc> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_DOC_SA_STF_MEMBER key.
		///		fkSaStfDocSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfDoc objects.</returns>
		public TList<SaStfDoc> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_DOC_SA_STF_MEMBER key.
		///		fkSaStfDocSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfDoc objects.</returns>
		public TList<SaStfDoc> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_DOC_SA_STF_MEMBER key.
		///		FK_SA_STF_DOC_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfDoc objects.</returns>
		public abstract TList<SaStfDoc> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaStfDoc Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaStfDocKey key, int start, int pageLength)
		{
			return GetBySaStfDocId(transactionManager, key.SaStfDocId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_STF_DOC index.
		/// </summary>
		/// <param name="_saStfDocId">staff files-documents</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfDoc GetBySaStfDocId(System.Decimal _saStfDocId)
		{
			int count = -1;
			return GetBySaStfDocId(null,_saStfDocId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_STF_DOC index.
		/// </summary>
		/// <param name="_saStfDocId">staff files-documents</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfDoc GetBySaStfDocId(System.Decimal _saStfDocId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfDocId(null, _saStfDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_STF_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfDocId">staff files-documents</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfDoc GetBySaStfDocId(TransactionManager transactionManager, System.Decimal _saStfDocId)
		{
			int count = -1;
			return GetBySaStfDocId(transactionManager, _saStfDocId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_STF_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfDocId">staff files-documents</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfDoc GetBySaStfDocId(TransactionManager transactionManager, System.Decimal _saStfDocId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfDocId(transactionManager, _saStfDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_STF_DOC index.
		/// </summary>
		/// <param name="_saStfDocId">staff files-documents</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfDoc GetBySaStfDocId(System.Decimal _saStfDocId, int start, int pageLength, out int count)
		{
			return GetBySaStfDocId(null, _saStfDocId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_STF_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfDocId">staff files-documents</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfDoc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaStfDoc GetBySaStfDocId(TransactionManager transactionManager, System.Decimal _saStfDocId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaStfDoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaStfDoc&gt;"/></returns>
		public static TList<SaStfDoc> Fill(IDataReader reader, TList<SaStfDoc> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaStfDoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaStfDoc")
					.Append("|").Append((System.Decimal)reader["SA_STF_DOC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaStfDoc>(
					key.ToString(), // EntityTrackingKey
					"SaStfDoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaStfDoc();
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
					c.SaStfDocId = (System.Decimal)reader["SA_STF_DOC_ID"];
					c.OriginalSaStfDocId = c.SaStfDocId;
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.SaCodeDocId = (System.Decimal)reader["SA_CODE_DOC_ID"];
					c.AttchdDocPath = (System.String)reader["ATTCHD_DOC_PATH"];
					c.DocNotes = Convert.IsDBNull(reader["DOC_NOTES"]) ? null : (System.String)reader["DOC_NOTES"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaStfDoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaStfDoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaStfDoc entity)
		{
			if (!reader.Read()) return;
			
			entity.SaStfDocId = (System.Decimal)reader[((int)SaStfDocColumn.SaStfDocId - 1)];
			entity.OriginalSaStfDocId = (System.Decimal)reader["SA_STF_DOC_ID"];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaStfDocColumn.SaStfMemberId - 1)];
			entity.SaCodeDocId = (System.Decimal)reader[((int)SaStfDocColumn.SaCodeDocId - 1)];
			entity.AttchdDocPath = (System.String)reader[((int)SaStfDocColumn.AttchdDocPath - 1)];
			entity.DocNotes = (reader.IsDBNull(((int)SaStfDocColumn.DocNotes - 1)))?null:(System.String)reader[((int)SaStfDocColumn.DocNotes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)SaStfDocColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)SaStfDocColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SaStfDocColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SaStfDocColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaStfDoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaStfDoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaStfDoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaStfDocId = (System.Decimal)dataRow["SA_STF_DOC_ID"];
			entity.OriginalSaStfDocId = (System.Decimal)dataRow["SA_STF_DOC_ID"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.SaCodeDocId = (System.Decimal)dataRow["SA_CODE_DOC_ID"];
			entity.AttchdDocPath = (System.String)dataRow["ATTCHD_DOC_PATH"];
			entity.DocNotes = Convert.IsDBNull(dataRow["DOC_NOTES"]) ? null : (System.String)dataRow["DOC_NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaStfDoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaStfDoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaStfDoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaCodeDocIdSource	
			if (CanDeepLoad(entity, "SaCodeDoc|SaCodeDocIdSource", deepLoadType, innerList) 
				&& entity.SaCodeDocIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeDocId;
				SaCodeDoc tmpEntity = EntityManager.LocateEntity<SaCodeDoc>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeDoc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeDocIdSource = tmpEntity;
				else
					entity.SaCodeDocIdSource = DataRepository.SaCodeDocProvider.GetBySaCodeDocId(transactionManager, entity.SaCodeDocId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeDocIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeDocIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeDocProvider.DeepLoad(transactionManager, entity.SaCodeDocIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeDocIdSource

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaStfMemberId;
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemberIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaStfDoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaStfDoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaStfDoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaStfDoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaCodeDocIdSource
			if (CanDeepSave(entity, "SaCodeDoc|SaCodeDocIdSource", deepSaveType, innerList) 
				&& entity.SaCodeDocIdSource != null)
			{
				DataRepository.SaCodeDocProvider.Save(transactionManager, entity.SaCodeDocIdSource);
				entity.SaCodeDocId = entity.SaCodeDocIdSource.SaCodeDocId;
			}
			#endregion 
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
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
	
	#region SaStfDocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaStfDoc</c>
	///</summary>
	public enum SaStfDocChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeDoc</c> at SaCodeDocIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeDoc))]
		SaCodeDoc,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion SaStfDocChildEntityTypes
	
	#region SaStfDocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaStfDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaStfDoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaStfDocFilterBuilder : SqlFilterBuilder<SaStfDocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaStfDocFilterBuilder class.
		/// </summary>
		public SaStfDocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaStfDocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaStfDocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaStfDocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaStfDocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaStfDocFilterBuilder
	
	#region SaStfDocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaStfDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaStfDoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaStfDocParameterBuilder : ParameterizedSqlFilterBuilder<SaStfDocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaStfDocParameterBuilder class.
		/// </summary>
		public SaStfDocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaStfDocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaStfDocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaStfDocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaStfDocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaStfDocParameterBuilder
	
	#region SaStfDocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaStfDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaStfDoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaStfDocSortBuilder : SqlSortBuilder<SaStfDocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaStfDocSqlSortBuilder class.
		/// </summary>
		public SaStfDocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaStfDocSortBuilder
	
} // end namespace
