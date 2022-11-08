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
	/// This class is the base class for any <see cref="EdCodeSemActvityProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeSemActvityProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeSemActvity, UMIS_VER2.BusinessLyer.EdCodeSemActvityKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeSemActvityKey key)
		{
			return Delete(transactionManager, key.EdCodeSemActvityId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeSemActvityId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeSemActvityId)
		{
			return Delete(null, _edCodeSemActvityId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemActvityId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeSemActvityId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_SEM_ACTVITY_SE_CODE_USER_TYPE key.
		///		FK_ED_CODE_SEM_ACTVITY_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="_seCodeUserTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeSemActvity objects.</returns>
		public TList<EdCodeSemActvity> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(_seCodeUserTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_SEM_ACTVITY_SE_CODE_USER_TYPE key.
		///		FK_ED_CODE_SEM_ACTVITY_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeSemActvity objects.</returns>
		/// <remarks></remarks>
		public TList<EdCodeSemActvity> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_SEM_ACTVITY_SE_CODE_USER_TYPE key.
		///		FK_ED_CODE_SEM_ACTVITY_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeSemActvity objects.</returns>
		public TList<EdCodeSemActvity> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_SEM_ACTVITY_SE_CODE_USER_TYPE key.
		///		fkEdCodeSemActvitySeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeSemActvity objects.</returns>
		public TList<EdCodeSemActvity> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_SEM_ACTVITY_SE_CODE_USER_TYPE key.
		///		fkEdCodeSemActvitySeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeSemActvity objects.</returns>
		public TList<EdCodeSemActvity> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId, int start, int pageLength,out int count)
		{
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_SEM_ACTVITY_SE_CODE_USER_TYPE key.
		///		FK_ED_CODE_SEM_ACTVITY_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeSemActvity objects.</returns>
		public abstract TList<EdCodeSemActvity> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeSemActvity Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeSemActvityKey key, int start, int pageLength)
		{
			return GetByEdCodeSemActvityId(transactionManager, key.EdCodeSemActvityId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_SEM_ACTVITY index.
		/// </summary>
		/// <param name="_edCodeSemActvityId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemActvity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSemActvity GetByEdCodeSemActvityId(System.Decimal _edCodeSemActvityId)
		{
			int count = -1;
			return GetByEdCodeSemActvityId(null,_edCodeSemActvityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SEM_ACTVITY index.
		/// </summary>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemActvity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSemActvity GetByEdCodeSemActvityId(System.Decimal _edCodeSemActvityId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemActvityId(null, _edCodeSemActvityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SEM_ACTVITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemActvity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSemActvity GetByEdCodeSemActvityId(TransactionManager transactionManager, System.Decimal _edCodeSemActvityId)
		{
			int count = -1;
			return GetByEdCodeSemActvityId(transactionManager, _edCodeSemActvityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SEM_ACTVITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemActvity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSemActvity GetByEdCodeSemActvityId(TransactionManager transactionManager, System.Decimal _edCodeSemActvityId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemActvityId(transactionManager, _edCodeSemActvityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SEM_ACTVITY index.
		/// </summary>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemActvity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSemActvity GetByEdCodeSemActvityId(System.Decimal _edCodeSemActvityId, int start, int pageLength, out int count)
		{
			return GetByEdCodeSemActvityId(null, _edCodeSemActvityId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SEM_ACTVITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemActvity"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeSemActvity GetByEdCodeSemActvityId(TransactionManager transactionManager, System.Decimal _edCodeSemActvityId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeSemActvity&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeSemActvity&gt;"/></returns>
		public static TList<EdCodeSemActvity> Fill(IDataReader reader, TList<EdCodeSemActvity> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeSemActvity c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeSemActvity")
					.Append("|").Append((System.Decimal)reader["ED_CODE_SEM_ACTVITY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeSemActvity>(
					key.ToString(), // EntityTrackingKey
					"EdCodeSemActvity",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeSemActvity();
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
					c.EdCodeSemActvityId = (System.Decimal)reader["ED_CODE_SEM_ACTVITY_ID"];
					c.OriginalEdCodeSemActvityId = c.EdCodeSemActvityId;
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.ActvOrder = Convert.IsDBNull(reader["ACTV_ORDER"]) ? null : (System.Int32?)reader["ACTV_ORDER"];
					c.HideFlg = Convert.IsDBNull(reader["HIDE_FLG"]) ? null : (System.Int32?)reader["HIDE_FLG"];
					c.ConstFlg = (System.Boolean)reader["CONST_FLG"];
					c.SeCodeUserTypeId = Convert.IsDBNull(reader["SE_CODE_USER_TYPE_ID"]) ? null : (System.Decimal?)reader["SE_CODE_USER_TYPE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemActvity"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeSemActvity"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeSemActvity entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeSemActvityId = (System.Decimal)reader[((int)EdCodeSemActvityColumn.EdCodeSemActvityId - 1)];
			entity.OriginalEdCodeSemActvityId = (System.Decimal)reader["ED_CODE_SEM_ACTVITY_ID"];
			entity.DescrAr = (reader.IsDBNull(((int)EdCodeSemActvityColumn.DescrAr - 1)))?null:(System.String)reader[((int)EdCodeSemActvityColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EdCodeSemActvityColumn.DescrEn - 1)))?null:(System.String)reader[((int)EdCodeSemActvityColumn.DescrEn - 1)];
			entity.ActvOrder = (reader.IsDBNull(((int)EdCodeSemActvityColumn.ActvOrder - 1)))?null:(System.Int32?)reader[((int)EdCodeSemActvityColumn.ActvOrder - 1)];
			entity.HideFlg = (reader.IsDBNull(((int)EdCodeSemActvityColumn.HideFlg - 1)))?null:(System.Int32?)reader[((int)EdCodeSemActvityColumn.HideFlg - 1)];
			entity.ConstFlg = (System.Boolean)reader[((int)EdCodeSemActvityColumn.ConstFlg - 1)];
			entity.SeCodeUserTypeId = (reader.IsDBNull(((int)EdCodeSemActvityColumn.SeCodeUserTypeId - 1)))?null:(System.Decimal?)reader[((int)EdCodeSemActvityColumn.SeCodeUserTypeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemActvity"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeSemActvity"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeSemActvity entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeSemActvityId = (System.Decimal)dataRow["ED_CODE_SEM_ACTVITY_ID"];
			entity.OriginalEdCodeSemActvityId = (System.Decimal)dataRow["ED_CODE_SEM_ACTVITY_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.ActvOrder = Convert.IsDBNull(dataRow["ACTV_ORDER"]) ? null : (System.Int32?)dataRow["ACTV_ORDER"];
			entity.HideFlg = Convert.IsDBNull(dataRow["HIDE_FLG"]) ? null : (System.Int32?)dataRow["HIDE_FLG"];
			entity.ConstFlg = (System.Boolean)dataRow["CONST_FLG"];
			entity.SeCodeUserTypeId = Convert.IsDBNull(dataRow["SE_CODE_USER_TYPE_ID"]) ? null : (System.Decimal?)dataRow["SE_CODE_USER_TYPE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeSemActvity"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeSemActvity Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeSemActvity entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SeCodeUserTypeIdSource	
			if (CanDeepLoad(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepLoadType, innerList) 
				&& entity.SeCodeUserTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeCodeUserTypeId ?? 0.0m);
				SeCodeUserType tmpEntity = EntityManager.LocateEntity<SeCodeUserType>(EntityLocator.ConstructKeyFromPkItems(typeof(SeCodeUserType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeCodeUserTypeIdSource = tmpEntity;
				else
					entity.SeCodeUserTypeIdSource = DataRepository.SeCodeUserTypeProvider.GetBySeCodeUserTypeId(transactionManager, (entity.SeCodeUserTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeCodeUserTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeCodeUserTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeCodeUserTypeProvider.DeepLoad(transactionManager, entity.SeCodeUserTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeCodeUserTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeSemActvityId methods when available
			
			#region FeeSemesterAgendaCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeSemesterAgenda>|FeeSemesterAgendaCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeSemesterAgendaCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeSemesterAgendaCollection = DataRepository.FeeSemesterAgendaProvider.GetByEdCodeSemActvityId(transactionManager, entity.EdCodeSemActvityId);

				if (deep && entity.FeeSemesterAgendaCollection.Count > 0)
				{
					deepHandles.Add("FeeSemesterAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeSemesterAgenda>) DataRepository.FeeSemesterAgendaProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeSemesterAgendaCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeStudFeeItemCollection = DataRepository.FeeStudFeeItemProvider.GetByEdCodeSemActvityId(transactionManager, entity.EdCodeSemActvityId);

				if (deep && entity.FeeStudFeeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudFeeItem>) DataRepository.FeeStudFeeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudFeeItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdSemesterAgendaCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdSemesterAgenda>|EdSemesterAgendaCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemesterAgendaCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdSemesterAgendaCollection = DataRepository.EdSemesterAgendaProvider.GetByEdCodeSemActvityId(transactionManager, entity.EdCodeSemActvityId);

				if (deep && entity.EdSemesterAgendaCollection.Count > 0)
				{
					deepHandles.Add("EdSemesterAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemesterAgenda>) DataRepository.EdSemesterAgendaProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemesterAgendaCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeSemActvity object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeSemActvity instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeSemActvity Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeSemActvity entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SeCodeUserTypeIdSource
			if (CanDeepSave(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepSaveType, innerList) 
				&& entity.SeCodeUserTypeIdSource != null)
			{
				DataRepository.SeCodeUserTypeProvider.Save(transactionManager, entity.SeCodeUserTypeIdSource);
				entity.SeCodeUserTypeId = entity.SeCodeUserTypeIdSource.SeCodeUserTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<FeeSemesterAgenda>
				if (CanDeepSave(entity.FeeSemesterAgendaCollection, "List<FeeSemesterAgenda>|FeeSemesterAgendaCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeSemesterAgenda child in entity.FeeSemesterAgendaCollection)
					{
						if(child.EdCodeSemActvityIdSource != null)
						{
							child.EdCodeSemActvityId = child.EdCodeSemActvityIdSource.EdCodeSemActvityId;
						}
						else
						{
							child.EdCodeSemActvityId = entity.EdCodeSemActvityId;
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
				
	
			#region List<FeeStudFeeItem>
				if (CanDeepSave(entity.FeeStudFeeItemCollection, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudFeeItem child in entity.FeeStudFeeItemCollection)
					{
						if(child.EdCodeSemActvityIdSource != null)
						{
							child.EdCodeSemActvityId = child.EdCodeSemActvityIdSource.EdCodeSemActvityId;
						}
						else
						{
							child.EdCodeSemActvityId = entity.EdCodeSemActvityId;
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
				
	
			#region List<EdSemesterAgenda>
				if (CanDeepSave(entity.EdSemesterAgendaCollection, "List<EdSemesterAgenda>|EdSemesterAgendaCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdSemesterAgenda child in entity.EdSemesterAgendaCollection)
					{
						if(child.EdCodeSemActvityIdSource != null)
						{
							child.EdCodeSemActvityId = child.EdCodeSemActvityIdSource.EdCodeSemActvityId;
						}
						else
						{
							child.EdCodeSemActvityId = entity.EdCodeSemActvityId;
						}

					}

					if (entity.EdSemesterAgendaCollection.Count > 0 || entity.EdSemesterAgendaCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdSemesterAgendaProvider.Save(transactionManager, entity.EdSemesterAgendaCollection);
						
						deepHandles.Add("EdSemesterAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdSemesterAgenda >) DataRepository.EdSemesterAgendaProvider.DeepSave,
							new object[] { transactionManager, entity.EdSemesterAgendaCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeSemActvityChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeSemActvity</c>
	///</summary>
	public enum EdCodeSemActvityChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SeCodeUserType</c> at SeCodeUserTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SeCodeUserType))]
		SeCodeUserType,
		///<summary>
		/// Collection of <c>EdCodeSemActvity</c> as OneToMany for FeeSemesterAgendaCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeSemesterAgenda>))]
		FeeSemesterAgendaCollection,
		///<summary>
		/// Collection of <c>EdCodeSemActvity</c> as OneToMany for FeeStudFeeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudFeeItem>))]
		FeeStudFeeItemCollection,
		///<summary>
		/// Collection of <c>EdCodeSemActvity</c> as OneToMany for EdSemesterAgendaCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemesterAgenda>))]
		EdSemesterAgendaCollection,
	}
	
	#endregion EdCodeSemActvityChildEntityTypes
	
	#region EdCodeSemActvityFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeSemActvityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeSemActvity"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeSemActvityFilterBuilder : SqlFilterBuilder<EdCodeSemActvityColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeSemActvityFilterBuilder class.
		/// </summary>
		public EdCodeSemActvityFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeSemActvityFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeSemActvityFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeSemActvityFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeSemActvityFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeSemActvityFilterBuilder
	
	#region EdCodeSemActvityParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeSemActvityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeSemActvity"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeSemActvityParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeSemActvityColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeSemActvityParameterBuilder class.
		/// </summary>
		public EdCodeSemActvityParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeSemActvityParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeSemActvityParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeSemActvityParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeSemActvityParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeSemActvityParameterBuilder
	
	#region EdCodeSemActvitySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeSemActvityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeSemActvity"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeSemActvitySortBuilder : SqlSortBuilder<EdCodeSemActvityColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeSemActvitySqlSortBuilder class.
		/// </summary>
		public EdCodeSemActvitySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeSemActvitySortBuilder
	
} // end namespace
