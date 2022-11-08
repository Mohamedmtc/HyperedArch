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
	/// This class is the base class for any <see cref="FeeTreasuryReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeTreasuryReqProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeTreasuryReq, UMIS_VER2.BusinessLyer.FeeTreasuryReqKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeTreasuryReqKey key)
		{
			return Delete(transactionManager, key.FeeTreasuryReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeTreasuryReqId">طلبات الاستعاضه  للخزنة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeTreasuryReqId)
		{
			return Delete(null, _feeTreasuryReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeTreasuryReqId">طلبات الاستعاضه  للخزنة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeTreasuryReqId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_REQ_ED_ACAD_YEAR key.
		///		FK_FEE_TREASURY_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasuryReq objects.</returns>
		public TList<FeeTreasuryReq> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_REQ_ED_ACAD_YEAR key.
		///		FK_FEE_TREASURY_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasuryReq objects.</returns>
		/// <remarks></remarks>
		public TList<FeeTreasuryReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_REQ_ED_ACAD_YEAR key.
		///		FK_FEE_TREASURY_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasuryReq objects.</returns>
		public TList<FeeTreasuryReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_REQ_ED_ACAD_YEAR key.
		///		fkFeeTreasuryReqEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasuryReq objects.</returns>
		public TList<FeeTreasuryReq> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_REQ_ED_ACAD_YEAR key.
		///		fkFeeTreasuryReqEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasuryReq objects.</returns>
		public TList<FeeTreasuryReq> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_REQ_ED_ACAD_YEAR key.
		///		FK_FEE_TREASURY_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasuryReq objects.</returns>
		public abstract TList<FeeTreasuryReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeTreasuryReq Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeTreasuryReqKey key, int start, int pageLength)
		{
			return GetByFeeTreasuryReqId(transactionManager, key.FeeTreasuryReqId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_TREASURY_REQ index.
		/// </summary>
		/// <param name="_feeTreasuryReqId">طلبات الاستعاضه  للخزنة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeTreasuryReq GetByFeeTreasuryReqId(System.Decimal _feeTreasuryReqId)
		{
			int count = -1;
			return GetByFeeTreasuryReqId(null,_feeTreasuryReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_TREASURY_REQ index.
		/// </summary>
		/// <param name="_feeTreasuryReqId">طلبات الاستعاضه  للخزنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeTreasuryReq GetByFeeTreasuryReqId(System.Decimal _feeTreasuryReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeTreasuryReqId(null, _feeTreasuryReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_TREASURY_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeTreasuryReqId">طلبات الاستعاضه  للخزنة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeTreasuryReq GetByFeeTreasuryReqId(TransactionManager transactionManager, System.Decimal _feeTreasuryReqId)
		{
			int count = -1;
			return GetByFeeTreasuryReqId(transactionManager, _feeTreasuryReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_TREASURY_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeTreasuryReqId">طلبات الاستعاضه  للخزنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeTreasuryReq GetByFeeTreasuryReqId(TransactionManager transactionManager, System.Decimal _feeTreasuryReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeTreasuryReqId(transactionManager, _feeTreasuryReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_TREASURY_REQ index.
		/// </summary>
		/// <param name="_feeTreasuryReqId">طلبات الاستعاضه  للخزنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeTreasuryReq GetByFeeTreasuryReqId(System.Decimal _feeTreasuryReqId, int start, int pageLength, out int count)
		{
			return GetByFeeTreasuryReqId(null, _feeTreasuryReqId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_TREASURY_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeTreasuryReqId">طلبات الاستعاضه  للخزنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryReq"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeTreasuryReq GetByFeeTreasuryReqId(TransactionManager transactionManager, System.Decimal _feeTreasuryReqId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeTreasuryReq&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeTreasuryReq&gt;"/></returns>
		public static TList<FeeTreasuryReq> Fill(IDataReader reader, TList<FeeTreasuryReq> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeTreasuryReq c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeTreasuryReq")
					.Append("|").Append((System.Decimal)reader["FEE_TREASURY_REQ_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeTreasuryReq>(
					key.ToString(), // EntityTrackingKey
					"FeeTreasuryReq",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeTreasuryReq();
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
					c.FeeTreasuryReqId = (System.Decimal)reader["FEE_TREASURY_REQ_ID"];
					c.OriginalFeeTreasuryReqId = c.FeeTreasuryReqId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.ReqDate = (System.DateTime)reader["REQ_DATE"];
					c.ReqAmount = Convert.IsDBNull(reader["REQ_AMOUNT"]) ? null : (System.Decimal?)reader["REQ_AMOUNT"];
					c.RemainAmount = Convert.IsDBNull(reader["REMAIN_AMOUNT"]) ? null : (System.Decimal?)reader["REMAIN_AMOUNT"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Int32?)reader["APPROVE_FLG"];
					c.ApproveDate = Convert.IsDBNull(reader["APPROVE_DATE"]) ? null : (System.DateTime?)reader["APPROVE_DATE"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryReq"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryReq"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeTreasuryReq entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeTreasuryReqId = (System.Decimal)reader[((int)FeeTreasuryReqColumn.FeeTreasuryReqId - 1)];
			entity.OriginalFeeTreasuryReqId = (System.Decimal)reader["FEE_TREASURY_REQ_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)FeeTreasuryReqColumn.EdAcadYearId - 1)];
			entity.ReqDate = (System.DateTime)reader[((int)FeeTreasuryReqColumn.ReqDate - 1)];
			entity.ReqAmount = (reader.IsDBNull(((int)FeeTreasuryReqColumn.ReqAmount - 1)))?null:(System.Decimal?)reader[((int)FeeTreasuryReqColumn.ReqAmount - 1)];
			entity.RemainAmount = (reader.IsDBNull(((int)FeeTreasuryReqColumn.RemainAmount - 1)))?null:(System.Decimal?)reader[((int)FeeTreasuryReqColumn.RemainAmount - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)FeeTreasuryReqColumn.ApproveFlg - 1)))?null:(System.Int32?)reader[((int)FeeTreasuryReqColumn.ApproveFlg - 1)];
			entity.ApproveDate = (reader.IsDBNull(((int)FeeTreasuryReqColumn.ApproveDate - 1)))?null:(System.DateTime?)reader[((int)FeeTreasuryReqColumn.ApproveDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeTreasuryReqColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeTreasuryReqColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeTreasuryReqColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeTreasuryReqColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryReq"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryReq"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeTreasuryReq entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeTreasuryReqId = (System.Decimal)dataRow["FEE_TREASURY_REQ_ID"];
			entity.OriginalFeeTreasuryReqId = (System.Decimal)dataRow["FEE_TREASURY_REQ_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.ReqDate = (System.DateTime)dataRow["REQ_DATE"];
			entity.ReqAmount = Convert.IsDBNull(dataRow["REQ_AMOUNT"]) ? null : (System.Decimal?)dataRow["REQ_AMOUNT"];
			entity.RemainAmount = Convert.IsDBNull(dataRow["REMAIN_AMOUNT"]) ? null : (System.Decimal?)dataRow["REMAIN_AMOUNT"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Int32?)dataRow["APPROVE_FLG"];
			entity.ApproveDate = Convert.IsDBNull(dataRow["APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["APPROVE_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryReq"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeTreasuryReq Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeTreasuryReq entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdAcadYearId;
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeTreasuryReqId methods when available
			
			#region FeeTreasuryItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeTreasuryItem>|FeeTreasuryItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeTreasuryItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeTreasuryItemCollection = DataRepository.FeeTreasuryItemProvider.GetByFeeTreasuryReqId(transactionManager, entity.FeeTreasuryReqId);

				if (deep && entity.FeeTreasuryItemCollection.Count > 0)
				{
					deepHandles.Add("FeeTreasuryItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeTreasuryItem>) DataRepository.FeeTreasuryItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeTreasuryItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeTreasuryReq object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeTreasuryReq instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeTreasuryReq Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeTreasuryReq entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<FeeTreasuryItem>
				if (CanDeepSave(entity.FeeTreasuryItemCollection, "List<FeeTreasuryItem>|FeeTreasuryItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeTreasuryItem child in entity.FeeTreasuryItemCollection)
					{
						if(child.FeeTreasuryReqIdSource != null)
						{
							child.FeeTreasuryReqId = child.FeeTreasuryReqIdSource.FeeTreasuryReqId;
						}
						else
						{
							child.FeeTreasuryReqId = entity.FeeTreasuryReqId;
						}

					}

					if (entity.FeeTreasuryItemCollection.Count > 0 || entity.FeeTreasuryItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeTreasuryItemProvider.Save(transactionManager, entity.FeeTreasuryItemCollection);
						
						deepHandles.Add("FeeTreasuryItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeTreasuryItem >) DataRepository.FeeTreasuryItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeTreasuryItemCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeTreasuryReqChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeTreasuryReq</c>
	///</summary>
	public enum FeeTreasuryReqChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		///<summary>
		/// Collection of <c>FeeTreasuryReq</c> as OneToMany for FeeTreasuryItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeTreasuryItem>))]
		FeeTreasuryItemCollection,
	}
	
	#endregion FeeTreasuryReqChildEntityTypes
	
	#region FeeTreasuryReqFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeTreasuryReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeTreasuryReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeTreasuryReqFilterBuilder : SqlFilterBuilder<FeeTreasuryReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryReqFilterBuilder class.
		/// </summary>
		public FeeTreasuryReqFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeTreasuryReqFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeTreasuryReqFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeTreasuryReqFilterBuilder
	
	#region FeeTreasuryReqParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeTreasuryReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeTreasuryReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeTreasuryReqParameterBuilder : ParameterizedSqlFilterBuilder<FeeTreasuryReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryReqParameterBuilder class.
		/// </summary>
		public FeeTreasuryReqParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeTreasuryReqParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeTreasuryReqParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeTreasuryReqParameterBuilder
	
	#region FeeTreasuryReqSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeTreasuryReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeTreasuryReq"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeTreasuryReqSortBuilder : SqlSortBuilder<FeeTreasuryReqColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryReqSqlSortBuilder class.
		/// </summary>
		public FeeTreasuryReqSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeTreasuryReqSortBuilder
	
} // end namespace
