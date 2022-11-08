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
	/// This class is the base class for any <see cref="SvCdeMsgParamProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvCdeMsgParamProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvCdeMsgParam, UMIS_VER2.BusinessLyer.SvCdeMsgParamKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeMsgParamKey key)
		{
			return Delete(transactionManager, key.SvCdeMsgParamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svCdeMsgParamId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _svCdeMsgParamId)
		{
			return Delete(null, _svCdeMsgParamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeMsgParamId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _svCdeMsgParamId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_MSG_PARAM_SE_CODE_USER_TYPE key.
		///		FK_SV_CDE_MSG_PARAM_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="_seCodeUserTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeMsgParam objects.</returns>
		public TList<SvCdeMsgParam> GetBySeCodeUserTypeId(System.Decimal _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(_seCodeUserTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_MSG_PARAM_SE_CODE_USER_TYPE key.
		///		FK_SV_CDE_MSG_PARAM_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeMsgParam objects.</returns>
		/// <remarks></remarks>
		public TList<SvCdeMsgParam> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_MSG_PARAM_SE_CODE_USER_TYPE key.
		///		FK_SV_CDE_MSG_PARAM_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeMsgParam objects.</returns>
		public TList<SvCdeMsgParam> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_MSG_PARAM_SE_CODE_USER_TYPE key.
		///		fkSvCdeMsgParamSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeMsgParam objects.</returns>
		public TList<SvCdeMsgParam> GetBySeCodeUserTypeId(System.Decimal _seCodeUserTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_MSG_PARAM_SE_CODE_USER_TYPE key.
		///		fkSvCdeMsgParamSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeMsgParam objects.</returns>
		public TList<SvCdeMsgParam> GetBySeCodeUserTypeId(System.Decimal _seCodeUserTypeId, int start, int pageLength,out int count)
		{
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_MSG_PARAM_SE_CODE_USER_TYPE key.
		///		FK_SV_CDE_MSG_PARAM_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeMsgParam objects.</returns>
		public abstract TList<SvCdeMsgParam> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvCdeMsgParam Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeMsgParamKey key, int start, int pageLength)
		{
			return GetBySvCdeMsgParamId(transactionManager, key.SvCdeMsgParamId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_CDE_MSG_PARAM index.
		/// </summary>
		/// <param name="_svCdeMsgParamId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeMsgParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeMsgParam GetBySvCdeMsgParamId(System.Int32 _svCdeMsgParamId)
		{
			int count = -1;
			return GetBySvCdeMsgParamId(null,_svCdeMsgParamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_MSG_PARAM index.
		/// </summary>
		/// <param name="_svCdeMsgParamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeMsgParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeMsgParam GetBySvCdeMsgParamId(System.Int32 _svCdeMsgParamId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeMsgParamId(null, _svCdeMsgParamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_MSG_PARAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeMsgParamId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeMsgParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeMsgParam GetBySvCdeMsgParamId(TransactionManager transactionManager, System.Int32 _svCdeMsgParamId)
		{
			int count = -1;
			return GetBySvCdeMsgParamId(transactionManager, _svCdeMsgParamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_MSG_PARAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeMsgParamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeMsgParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeMsgParam GetBySvCdeMsgParamId(TransactionManager transactionManager, System.Int32 _svCdeMsgParamId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeMsgParamId(transactionManager, _svCdeMsgParamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_MSG_PARAM index.
		/// </summary>
		/// <param name="_svCdeMsgParamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeMsgParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeMsgParam GetBySvCdeMsgParamId(System.Int32 _svCdeMsgParamId, int start, int pageLength, out int count)
		{
			return GetBySvCdeMsgParamId(null, _svCdeMsgParamId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_MSG_PARAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeMsgParamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeMsgParam"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCdeMsgParam GetBySvCdeMsgParamId(TransactionManager transactionManager, System.Int32 _svCdeMsgParamId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvCdeMsgParam&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvCdeMsgParam&gt;"/></returns>
		public static TList<SvCdeMsgParam> Fill(IDataReader reader, TList<SvCdeMsgParam> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvCdeMsgParam c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvCdeMsgParam")
					.Append("|").Append((System.Int32)reader["SV_CDE_MSG_PARAM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvCdeMsgParam>(
					key.ToString(), // EntityTrackingKey
					"SvCdeMsgParam",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvCdeMsgParam();
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
					c.SvCdeMsgParamId = (System.Int32)reader["SV_CDE_MSG_PARAM_ID"];
					c.OriginalSvCdeMsgParamId = c.SvCdeMsgParamId;
					c.SeCodeUserTypeId = (System.Decimal)reader["SE_CODE_USER_TYPE_ID"];
					c.ParamName = (System.String)reader["PARAM_NAME"];
					c.FieldName = (System.String)reader["FIELD_NAME"];
					c.TypeFlg = Convert.IsDBNull(reader["TYPE_FLG"]) ? null : (System.Boolean?)reader["TYPE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeMsgParam"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeMsgParam"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvCdeMsgParam entity)
		{
			if (!reader.Read()) return;
			
			entity.SvCdeMsgParamId = (System.Int32)reader[((int)SvCdeMsgParamColumn.SvCdeMsgParamId - 1)];
			entity.OriginalSvCdeMsgParamId = (System.Int32)reader["SV_CDE_MSG_PARAM_ID"];
			entity.SeCodeUserTypeId = (System.Decimal)reader[((int)SvCdeMsgParamColumn.SeCodeUserTypeId - 1)];
			entity.ParamName = (System.String)reader[((int)SvCdeMsgParamColumn.ParamName - 1)];
			entity.FieldName = (System.String)reader[((int)SvCdeMsgParamColumn.FieldName - 1)];
			entity.TypeFlg = (reader.IsDBNull(((int)SvCdeMsgParamColumn.TypeFlg - 1)))?null:(System.Boolean?)reader[((int)SvCdeMsgParamColumn.TypeFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeMsgParam"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeMsgParam"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvCdeMsgParam entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvCdeMsgParamId = (System.Int32)dataRow["SV_CDE_MSG_PARAM_ID"];
			entity.OriginalSvCdeMsgParamId = (System.Int32)dataRow["SV_CDE_MSG_PARAM_ID"];
			entity.SeCodeUserTypeId = (System.Decimal)dataRow["SE_CODE_USER_TYPE_ID"];
			entity.ParamName = (System.String)dataRow["PARAM_NAME"];
			entity.FieldName = (System.String)dataRow["FIELD_NAME"];
			entity.TypeFlg = Convert.IsDBNull(dataRow["TYPE_FLG"]) ? null : (System.Boolean?)dataRow["TYPE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeMsgParam"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeMsgParam Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeMsgParam entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SeCodeUserTypeIdSource	
			if (CanDeepLoad(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepLoadType, innerList) 
				&& entity.SeCodeUserTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeCodeUserTypeId;
				SeCodeUserType tmpEntity = EntityManager.LocateEntity<SeCodeUserType>(EntityLocator.ConstructKeyFromPkItems(typeof(SeCodeUserType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeCodeUserTypeIdSource = tmpEntity;
				else
					entity.SeCodeUserTypeIdSource = DataRepository.SeCodeUserTypeProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeId);		
				
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
			// Deep load child collections  - Call GetBySvCdeMsgParamId methods when available
			
			#region SvMsgTmpltParamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvMsgTmpltParam>|SvMsgTmpltParamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvMsgTmpltParamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvMsgTmpltParamCollection = DataRepository.SvMsgTmpltParamProvider.GetBySvCdeMsgParamId(transactionManager, entity.SvCdeMsgParamId);

				if (deep && entity.SvMsgTmpltParamCollection.Count > 0)
				{
					deepHandles.Add("SvMsgTmpltParamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvMsgTmpltParam>) DataRepository.SvMsgTmpltParamProvider.DeepLoad,
						new object[] { transactionManager, entity.SvMsgTmpltParamCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvCdeMsgParam object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvCdeMsgParam instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeMsgParam Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeMsgParam entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SvMsgTmpltParam>
				if (CanDeepSave(entity.SvMsgTmpltParamCollection, "List<SvMsgTmpltParam>|SvMsgTmpltParamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvMsgTmpltParam child in entity.SvMsgTmpltParamCollection)
					{
						if(child.SvCdeMsgParamIdSource != null)
						{
							child.SvCdeMsgParamId = child.SvCdeMsgParamIdSource.SvCdeMsgParamId;
						}
						else
						{
							child.SvCdeMsgParamId = entity.SvCdeMsgParamId;
						}

					}

					if (entity.SvMsgTmpltParamCollection.Count > 0 || entity.SvMsgTmpltParamCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvMsgTmpltParamProvider.Save(transactionManager, entity.SvMsgTmpltParamCollection);
						
						deepHandles.Add("SvMsgTmpltParamCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvMsgTmpltParam >) DataRepository.SvMsgTmpltParamProvider.DeepSave,
							new object[] { transactionManager, entity.SvMsgTmpltParamCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvCdeMsgParamChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvCdeMsgParam</c>
	///</summary>
	public enum SvCdeMsgParamChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SeCodeUserType</c> at SeCodeUserTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SeCodeUserType))]
		SeCodeUserType,
		///<summary>
		/// Collection of <c>SvCdeMsgParam</c> as OneToMany for SvMsgTmpltParamCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvMsgTmpltParam>))]
		SvMsgTmpltParamCollection,
	}
	
	#endregion SvCdeMsgParamChildEntityTypes
	
	#region SvCdeMsgParamFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvCdeMsgParamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeMsgParam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeMsgParamFilterBuilder : SqlFilterBuilder<SvCdeMsgParamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeMsgParamFilterBuilder class.
		/// </summary>
		public SvCdeMsgParamFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeMsgParamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeMsgParamFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeMsgParamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeMsgParamFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeMsgParamFilterBuilder
	
	#region SvCdeMsgParamParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvCdeMsgParamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeMsgParam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeMsgParamParameterBuilder : ParameterizedSqlFilterBuilder<SvCdeMsgParamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeMsgParamParameterBuilder class.
		/// </summary>
		public SvCdeMsgParamParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeMsgParamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeMsgParamParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeMsgParamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeMsgParamParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeMsgParamParameterBuilder
	
	#region SvCdeMsgParamSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvCdeMsgParamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeMsgParam"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvCdeMsgParamSortBuilder : SqlSortBuilder<SvCdeMsgParamColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeMsgParamSqlSortBuilder class.
		/// </summary>
		public SvCdeMsgParamSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvCdeMsgParamSortBuilder
	
} // end namespace
