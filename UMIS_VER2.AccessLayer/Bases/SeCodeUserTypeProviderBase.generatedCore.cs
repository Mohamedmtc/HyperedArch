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
	/// This class is the base class for any <see cref="SeCodeUserTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeCodeUserTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeCodeUserType, UMIS_VER2.BusinessLyer.SeCodeUserTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeCodeUserTypeKey key)
		{
			return Delete(transactionManager, key.SeCodeUserTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seCodeUserTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seCodeUserTypeId)
		{
			return Delete(null, _seCodeUserTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.SeCodeUserType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeCodeUserTypeKey key, int start, int pageLength)
		{
			return GetBySeCodeUserTypeId(transactionManager, key.SeCodeUserTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_CODE_USER_TYPE index.
		/// </summary>
		/// <param name="_seCodeUserTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserType GetBySeCodeUserTypeId(System.Decimal _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(null,_seCodeUserTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CODE_USER_TYPE index.
		/// </summary>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserType GetBySeCodeUserTypeId(System.Decimal _seCodeUserTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CODE_USER_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserType GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CODE_USER_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserType GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CODE_USER_TYPE index.
		/// </summary>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserType GetBySeCodeUserTypeId(System.Decimal _seCodeUserTypeId, int start, int pageLength, out int count)
		{
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CODE_USER_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeCodeUserType GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SE_CODE_USER_TYPE index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="_descrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserType GetByDescrArDescrEn(System.String _descrAr, System.String _descrEn)
		{
			int count = -1;
			return GetByDescrArDescrEn(null,_descrAr, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_CODE_USER_TYPE index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserType GetByDescrArDescrEn(System.String _descrAr, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrArDescrEn(null, _descrAr, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_CODE_USER_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="_descrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserType GetByDescrArDescrEn(TransactionManager transactionManager, System.String _descrAr, System.String _descrEn)
		{
			int count = -1;
			return GetByDescrArDescrEn(transactionManager, _descrAr, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_CODE_USER_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserType GetByDescrArDescrEn(TransactionManager transactionManager, System.String _descrAr, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrArDescrEn(transactionManager, _descrAr, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_CODE_USER_TYPE index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeUserType GetByDescrArDescrEn(System.String _descrAr, System.String _descrEn, int start, int pageLength, out int count)
		{
			return GetByDescrArDescrEn(null, _descrAr, _descrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_CODE_USER_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeCodeUserType GetByDescrArDescrEn(TransactionManager transactionManager, System.String _descrAr, System.String _descrEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeCodeUserType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeCodeUserType&gt;"/></returns>
		public static TList<SeCodeUserType> Fill(IDataReader reader, TList<SeCodeUserType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeCodeUserType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeCodeUserType")
					.Append("|").Append((System.Decimal)reader["SE_CODE_USER_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeCodeUserType>(
					key.ToString(), // EntityTrackingKey
					"SeCodeUserType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeCodeUserType();
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
					c.SeCodeUserTypeId = (System.Decimal)reader["SE_CODE_USER_TYPE_ID"];
					c.OriginalSeCodeUserTypeId = c.SeCodeUserTypeId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeCodeUserType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeCodeUserType entity)
		{
			if (!reader.Read()) return;
			
			entity.SeCodeUserTypeId = (System.Decimal)reader[((int)SeCodeUserTypeColumn.SeCodeUserTypeId - 1)];
			entity.OriginalSeCodeUserTypeId = (System.Decimal)reader["SE_CODE_USER_TYPE_ID"];
			entity.DescrAr = (System.String)reader[((int)SeCodeUserTypeColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)SeCodeUserTypeColumn.DescrEn - 1)))?null:(System.String)reader[((int)SeCodeUserTypeColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeCodeUserType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeCodeUserType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeCodeUserType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeCodeUserTypeId = (System.Decimal)dataRow["SE_CODE_USER_TYPE_ID"];
			entity.OriginalSeCodeUserTypeId = (System.Decimal)dataRow["SE_CODE_USER_TYPE_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeCodeUserType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeCodeUserType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeCodeUserType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySeCodeUserTypeId methods when available
			
			#region SvMessageSendPrvCollectionGetBySeCodeUserTypeFromId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvMessageSendPrv>|SvMessageSendPrvCollectionGetBySeCodeUserTypeFromId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvMessageSendPrvCollectionGetBySeCodeUserTypeFromId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvMessageSendPrvCollectionGetBySeCodeUserTypeFromId = DataRepository.SvMessageSendPrvProvider.GetBySeCodeUserTypeFromId(transactionManager, entity.SeCodeUserTypeId);

				if (deep && entity.SvMessageSendPrvCollectionGetBySeCodeUserTypeFromId.Count > 0)
				{
					deepHandles.Add("SvMessageSendPrvCollectionGetBySeCodeUserTypeFromId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvMessageSendPrv>) DataRepository.SvMessageSendPrvProvider.DeepLoad,
						new object[] { transactionManager, entity.SvMessageSendPrvCollectionGetBySeCodeUserTypeFromId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvAutoMsgTmpltCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvAutoMsgTmplt>|SvAutoMsgTmpltCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvAutoMsgTmpltCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvAutoMsgTmpltCollection = DataRepository.SvAutoMsgTmpltProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeId);

				if (deep && entity.SvAutoMsgTmpltCollection.Count > 0)
				{
					deepHandles.Add("SvAutoMsgTmpltCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvAutoMsgTmplt>) DataRepository.SvAutoMsgTmpltProvider.DeepLoad,
						new object[] { transactionManager, entity.SvAutoMsgTmpltCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeStudTabUserTypeControlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeStudTabUserTypeControl>|SeStudTabUserTypeControlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeStudTabUserTypeControlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeStudTabUserTypeControlCollection = DataRepository.SeStudTabUserTypeControlProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeId);

				if (deep && entity.SeStudTabUserTypeControlCollection.Count > 0)
				{
					deepHandles.Add("SeStudTabUserTypeControlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeStudTabUserTypeControl>) DataRepository.SeStudTabUserTypeControlProvider.DeepLoad,
						new object[] { transactionManager, entity.SeStudTabUserTypeControlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region WfCrsRsltApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<WfCrsRsltApprove>|WfCrsRsltApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'WfCrsRsltApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.WfCrsRsltApproveCollection = DataRepository.WfCrsRsltApproveProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeId);

				if (deep && entity.WfCrsRsltApproveCollection.Count > 0)
				{
					deepHandles.Add("WfCrsRsltApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<WfCrsRsltApprove>) DataRepository.WfCrsRsltApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.WfCrsRsltApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvCdeMsgParamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvCdeMsgParam>|SvCdeMsgParamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCdeMsgParamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvCdeMsgParamCollection = DataRepository.SvCdeMsgParamProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeId);

				if (deep && entity.SvCdeMsgParamCollection.Count > 0)
				{
					deepHandles.Add("SvCdeMsgParamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvCdeMsgParam>) DataRepository.SvCdeMsgParamProvider.DeepLoad,
						new object[] { transactionManager, entity.SvCdeMsgParamCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvUserTaskCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvUserTask>|SvUserTaskCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvUserTaskCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvUserTaskCollection = DataRepository.SvUserTaskProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeId);

				if (deep && entity.SvUserTaskCollection.Count > 0)
				{
					deepHandles.Add("SvUserTaskCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvUserTask>) DataRepository.SvUserTaskProvider.DeepLoad,
						new object[] { transactionManager, entity.SvUserTaskCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseGrdChngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseGrdChngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseGrdChngCollection = DataRepository.EdStudCourseGrdChngProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeId);

				if (deep && entity.EdStudCourseGrdChngCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseGrdChngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseGrdChng>) DataRepository.EdStudCourseGrdChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseGrdChngCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUser>|SeUserCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserCollection = DataRepository.SeUserProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeId);

				if (deep && entity.SeUserCollection.Count > 0)
				{
					deepHandles.Add("SeUserCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUser>) DataRepository.SeUserProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeAccntCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeAccnt>|SeAccntCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeAccntCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeAccntCollection = DataRepository.SeAccntProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeId);

				if (deep && entity.SeAccntCollection.Count > 0)
				{
					deepHandles.Add("SeAccntCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeAccnt>) DataRepository.SeAccntProvider.DeepLoad,
						new object[] { transactionManager, entity.SeAccntCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCdeClrncItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCdeClrncItem>|GsCdeClrncItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeClrncItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCdeClrncItemCollection = DataRepository.GsCdeClrncItemProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeId);

				if (deep && entity.GsCdeClrncItemCollection.Count > 0)
				{
					deepHandles.Add("GsCdeClrncItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCdeClrncItem>) DataRepository.GsCdeClrncItemProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCdeClrncItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeModuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeModule>|SeModuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeModuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeModuleCollection = DataRepository.SeModuleProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeId);

				if (deep && entity.SeModuleCollection.Count > 0)
				{
					deepHandles.Add("SeModuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeModule>) DataRepository.SeModuleProvider.DeepLoad,
						new object[] { transactionManager, entity.SeModuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudNoteCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudNote>|EdStudNoteCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudNoteCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudNoteCollection = DataRepository.EdStudNoteProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeId);

				if (deep && entity.EdStudNoteCollection.Count > 0)
				{
					deepHandles.Add("EdStudNoteCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudNote>) DataRepository.EdStudNoteProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudNoteCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCodeApprovalCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCodeApproval>|GsCodeApprovalCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCodeApprovalCollection = DataRepository.GsCodeApprovalProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeId);

				if (deep && entity.GsCodeApprovalCollection.Count > 0)
				{
					deepHandles.Add("GsCodeApprovalCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCodeApproval>) DataRepository.GsCodeApprovalProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCodeApprovalCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomWfRequestApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomWfRequestApprove>|AccomWfRequestApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomWfRequestApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomWfRequestApproveCollection = DataRepository.AccomWfRequestApproveProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeId);

				if (deep && entity.AccomWfRequestApproveCollection.Count > 0)
				{
					deepHandles.Add("AccomWfRequestApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomWfRequestApprove>) DataRepository.AccomWfRequestApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomWfRequestApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvMessageSendPrvCollectionGetBySeCodeUserTypeToId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvMessageSendPrv>|SvMessageSendPrvCollectionGetBySeCodeUserTypeToId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvMessageSendPrvCollectionGetBySeCodeUserTypeToId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvMessageSendPrvCollectionGetBySeCodeUserTypeToId = DataRepository.SvMessageSendPrvProvider.GetBySeCodeUserTypeToId(transactionManager, entity.SeCodeUserTypeId);

				if (deep && entity.SvMessageSendPrvCollectionGetBySeCodeUserTypeToId.Count > 0)
				{
					deepHandles.Add("SvMessageSendPrvCollectionGetBySeCodeUserTypeToId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvMessageSendPrv>) DataRepository.SvMessageSendPrvProvider.DeepLoad,
						new object[] { transactionManager, entity.SvMessageSendPrvCollectionGetBySeCodeUserTypeToId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCodeSemActvityCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCodeSemActvity>|EdCodeSemActvityCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemActvityCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCodeSemActvityCollection = DataRepository.EdCodeSemActvityProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeId);

				if (deep && entity.EdCodeSemActvityCollection.Count > 0)
				{
					deepHandles.Add("EdCodeSemActvityCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCodeSemActvity>) DataRepository.EdCodeSemActvityProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCodeSemActvityCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeCodeUserType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeCodeUserType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeCodeUserType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeCodeUserType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SvMessageSendPrv>
				if (CanDeepSave(entity.SvMessageSendPrvCollectionGetBySeCodeUserTypeFromId, "List<SvMessageSendPrv>|SvMessageSendPrvCollectionGetBySeCodeUserTypeFromId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvMessageSendPrv child in entity.SvMessageSendPrvCollectionGetBySeCodeUserTypeFromId)
					{
						if(child.SeCodeUserTypeFromIdSource != null)
						{
							child.SeCodeUserTypeFromId = child.SeCodeUserTypeFromIdSource.SeCodeUserTypeId;
						}
						else
						{
							child.SeCodeUserTypeFromId = entity.SeCodeUserTypeId;
						}

					}

					if (entity.SvMessageSendPrvCollectionGetBySeCodeUserTypeFromId.Count > 0 || entity.SvMessageSendPrvCollectionGetBySeCodeUserTypeFromId.DeletedItems.Count > 0)
					{
						//DataRepository.SvMessageSendPrvProvider.Save(transactionManager, entity.SvMessageSendPrvCollectionGetBySeCodeUserTypeFromId);
						
						deepHandles.Add("SvMessageSendPrvCollectionGetBySeCodeUserTypeFromId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvMessageSendPrv >) DataRepository.SvMessageSendPrvProvider.DeepSave,
							new object[] { transactionManager, entity.SvMessageSendPrvCollectionGetBySeCodeUserTypeFromId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvAutoMsgTmplt>
				if (CanDeepSave(entity.SvAutoMsgTmpltCollection, "List<SvAutoMsgTmplt>|SvAutoMsgTmpltCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvAutoMsgTmplt child in entity.SvAutoMsgTmpltCollection)
					{
						if(child.SeCodeUserTypeIdSource != null)
						{
							child.SeCodeUserTypeId = child.SeCodeUserTypeIdSource.SeCodeUserTypeId;
						}
						else
						{
							child.SeCodeUserTypeId = entity.SeCodeUserTypeId;
						}

					}

					if (entity.SvAutoMsgTmpltCollection.Count > 0 || entity.SvAutoMsgTmpltCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvAutoMsgTmpltProvider.Save(transactionManager, entity.SvAutoMsgTmpltCollection);
						
						deepHandles.Add("SvAutoMsgTmpltCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvAutoMsgTmplt >) DataRepository.SvAutoMsgTmpltProvider.DeepSave,
							new object[] { transactionManager, entity.SvAutoMsgTmpltCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeStudTabUserTypeControl>
				if (CanDeepSave(entity.SeStudTabUserTypeControlCollection, "List<SeStudTabUserTypeControl>|SeStudTabUserTypeControlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeStudTabUserTypeControl child in entity.SeStudTabUserTypeControlCollection)
					{
						if(child.SeCodeUserTypeIdSource != null)
						{
							child.SeCodeUserTypeId = child.SeCodeUserTypeIdSource.SeCodeUserTypeId;
						}
						else
						{
							child.SeCodeUserTypeId = entity.SeCodeUserTypeId;
						}

					}

					if (entity.SeStudTabUserTypeControlCollection.Count > 0 || entity.SeStudTabUserTypeControlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeStudTabUserTypeControlProvider.Save(transactionManager, entity.SeStudTabUserTypeControlCollection);
						
						deepHandles.Add("SeStudTabUserTypeControlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeStudTabUserTypeControl >) DataRepository.SeStudTabUserTypeControlProvider.DeepSave,
							new object[] { transactionManager, entity.SeStudTabUserTypeControlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<WfCrsRsltApprove>
				if (CanDeepSave(entity.WfCrsRsltApproveCollection, "List<WfCrsRsltApprove>|WfCrsRsltApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(WfCrsRsltApprove child in entity.WfCrsRsltApproveCollection)
					{
						if(child.SeCodeUserTypeIdSource != null)
						{
							child.SeCodeUserTypeId = child.SeCodeUserTypeIdSource.SeCodeUserTypeId;
						}
						else
						{
							child.SeCodeUserTypeId = entity.SeCodeUserTypeId;
						}

					}

					if (entity.WfCrsRsltApproveCollection.Count > 0 || entity.WfCrsRsltApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.WfCrsRsltApproveProvider.Save(transactionManager, entity.WfCrsRsltApproveCollection);
						
						deepHandles.Add("WfCrsRsltApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< WfCrsRsltApprove >) DataRepository.WfCrsRsltApproveProvider.DeepSave,
							new object[] { transactionManager, entity.WfCrsRsltApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvCdeMsgParam>
				if (CanDeepSave(entity.SvCdeMsgParamCollection, "List<SvCdeMsgParam>|SvCdeMsgParamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvCdeMsgParam child in entity.SvCdeMsgParamCollection)
					{
						if(child.SeCodeUserTypeIdSource != null)
						{
							child.SeCodeUserTypeId = child.SeCodeUserTypeIdSource.SeCodeUserTypeId;
						}
						else
						{
							child.SeCodeUserTypeId = entity.SeCodeUserTypeId;
						}

					}

					if (entity.SvCdeMsgParamCollection.Count > 0 || entity.SvCdeMsgParamCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvCdeMsgParamProvider.Save(transactionManager, entity.SvCdeMsgParamCollection);
						
						deepHandles.Add("SvCdeMsgParamCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvCdeMsgParam >) DataRepository.SvCdeMsgParamProvider.DeepSave,
							new object[] { transactionManager, entity.SvCdeMsgParamCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvUserTask>
				if (CanDeepSave(entity.SvUserTaskCollection, "List<SvUserTask>|SvUserTaskCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvUserTask child in entity.SvUserTaskCollection)
					{
						if(child.SeCodeUserTypeIdSource != null)
						{
							child.SeCodeUserTypeId = child.SeCodeUserTypeIdSource.SeCodeUserTypeId;
						}
						else
						{
							child.SeCodeUserTypeId = entity.SeCodeUserTypeId;
						}

					}

					if (entity.SvUserTaskCollection.Count > 0 || entity.SvUserTaskCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvUserTaskProvider.Save(transactionManager, entity.SvUserTaskCollection);
						
						deepHandles.Add("SvUserTaskCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvUserTask >) DataRepository.SvUserTaskProvider.DeepSave,
							new object[] { transactionManager, entity.SvUserTaskCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseGrdChng>
				if (CanDeepSave(entity.EdStudCourseGrdChngCollection, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseGrdChng child in entity.EdStudCourseGrdChngCollection)
					{
						if(child.SeCodeUserTypeIdSource != null)
						{
							child.SeCodeUserTypeId = child.SeCodeUserTypeIdSource.SeCodeUserTypeId;
						}
						else
						{
							child.SeCodeUserTypeId = entity.SeCodeUserTypeId;
						}

					}

					if (entity.EdStudCourseGrdChngCollection.Count > 0 || entity.EdStudCourseGrdChngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseGrdChngProvider.Save(transactionManager, entity.EdStudCourseGrdChngCollection);
						
						deepHandles.Add("EdStudCourseGrdChngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseGrdChng >) DataRepository.EdStudCourseGrdChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseGrdChngCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeUser>
				if (CanDeepSave(entity.SeUserCollection, "List<SeUser>|SeUserCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUser child in entity.SeUserCollection)
					{
						if(child.SeCodeUserTypeIdSource != null)
						{
							child.SeCodeUserTypeId = child.SeCodeUserTypeIdSource.SeCodeUserTypeId;
						}
						else
						{
							child.SeCodeUserTypeId = entity.SeCodeUserTypeId;
						}

					}

					if (entity.SeUserCollection.Count > 0 || entity.SeUserCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserCollection);
						
						deepHandles.Add("SeUserCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUser >) DataRepository.SeUserProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeAccnt>
				if (CanDeepSave(entity.SeAccntCollection, "List<SeAccnt>|SeAccntCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeAccnt child in entity.SeAccntCollection)
					{
						if(child.SeCodeUserTypeIdSource != null)
						{
							child.SeCodeUserTypeId = child.SeCodeUserTypeIdSource.SeCodeUserTypeId;
						}
						else
						{
							child.SeCodeUserTypeId = entity.SeCodeUserTypeId;
						}

					}

					if (entity.SeAccntCollection.Count > 0 || entity.SeAccntCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeAccntProvider.Save(transactionManager, entity.SeAccntCollection);
						
						deepHandles.Add("SeAccntCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeAccnt >) DataRepository.SeAccntProvider.DeepSave,
							new object[] { transactionManager, entity.SeAccntCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCdeClrncItem>
				if (CanDeepSave(entity.GsCdeClrncItemCollection, "List<GsCdeClrncItem>|GsCdeClrncItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCdeClrncItem child in entity.GsCdeClrncItemCollection)
					{
						if(child.SeCodeUserTypeIdSource != null)
						{
							child.SeCodeUserTypeId = child.SeCodeUserTypeIdSource.SeCodeUserTypeId;
						}
						else
						{
							child.SeCodeUserTypeId = entity.SeCodeUserTypeId;
						}

					}

					if (entity.GsCdeClrncItemCollection.Count > 0 || entity.GsCdeClrncItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCdeClrncItemProvider.Save(transactionManager, entity.GsCdeClrncItemCollection);
						
						deepHandles.Add("GsCdeClrncItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCdeClrncItem >) DataRepository.GsCdeClrncItemProvider.DeepSave,
							new object[] { transactionManager, entity.GsCdeClrncItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeModule>
				if (CanDeepSave(entity.SeModuleCollection, "List<SeModule>|SeModuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeModule child in entity.SeModuleCollection)
					{
						if(child.SeCodeUserTypeIdSource != null)
						{
							child.SeCodeUserTypeId = child.SeCodeUserTypeIdSource.SeCodeUserTypeId;
						}
						else
						{
							child.SeCodeUserTypeId = entity.SeCodeUserTypeId;
						}

					}

					if (entity.SeModuleCollection.Count > 0 || entity.SeModuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeModuleProvider.Save(transactionManager, entity.SeModuleCollection);
						
						deepHandles.Add("SeModuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeModule >) DataRepository.SeModuleProvider.DeepSave,
							new object[] { transactionManager, entity.SeModuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudNote>
				if (CanDeepSave(entity.EdStudNoteCollection, "List<EdStudNote>|EdStudNoteCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudNote child in entity.EdStudNoteCollection)
					{
						if(child.SeCodeUserTypeIdSource != null)
						{
							child.SeCodeUserTypeId = child.SeCodeUserTypeIdSource.SeCodeUserTypeId;
						}
						else
						{
							child.SeCodeUserTypeId = entity.SeCodeUserTypeId;
						}

					}

					if (entity.EdStudNoteCollection.Count > 0 || entity.EdStudNoteCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudNoteProvider.Save(transactionManager, entity.EdStudNoteCollection);
						
						deepHandles.Add("EdStudNoteCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudNote >) DataRepository.EdStudNoteProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudNoteCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCodeApproval>
				if (CanDeepSave(entity.GsCodeApprovalCollection, "List<GsCodeApproval>|GsCodeApprovalCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCodeApproval child in entity.GsCodeApprovalCollection)
					{
						if(child.SeCodeUserTypeIdSource != null)
						{
							child.SeCodeUserTypeId = child.SeCodeUserTypeIdSource.SeCodeUserTypeId;
						}
						else
						{
							child.SeCodeUserTypeId = entity.SeCodeUserTypeId;
						}

					}

					if (entity.GsCodeApprovalCollection.Count > 0 || entity.GsCodeApprovalCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCodeApprovalProvider.Save(transactionManager, entity.GsCodeApprovalCollection);
						
						deepHandles.Add("GsCodeApprovalCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCodeApproval >) DataRepository.GsCodeApprovalProvider.DeepSave,
							new object[] { transactionManager, entity.GsCodeApprovalCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomWfRequestApprove>
				if (CanDeepSave(entity.AccomWfRequestApproveCollection, "List<AccomWfRequestApprove>|AccomWfRequestApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomWfRequestApprove child in entity.AccomWfRequestApproveCollection)
					{
						if(child.SeCodeUserTypeIdSource != null)
						{
							child.SeCodeUserTypeId = child.SeCodeUserTypeIdSource.SeCodeUserTypeId;
						}
						else
						{
							child.SeCodeUserTypeId = entity.SeCodeUserTypeId;
						}

					}

					if (entity.AccomWfRequestApproveCollection.Count > 0 || entity.AccomWfRequestApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomWfRequestApproveProvider.Save(transactionManager, entity.AccomWfRequestApproveCollection);
						
						deepHandles.Add("AccomWfRequestApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomWfRequestApprove >) DataRepository.AccomWfRequestApproveProvider.DeepSave,
							new object[] { transactionManager, entity.AccomWfRequestApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvMessageSendPrv>
				if (CanDeepSave(entity.SvMessageSendPrvCollectionGetBySeCodeUserTypeToId, "List<SvMessageSendPrv>|SvMessageSendPrvCollectionGetBySeCodeUserTypeToId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvMessageSendPrv child in entity.SvMessageSendPrvCollectionGetBySeCodeUserTypeToId)
					{
						if(child.SeCodeUserTypeToIdSource != null)
						{
							child.SeCodeUserTypeToId = child.SeCodeUserTypeToIdSource.SeCodeUserTypeId;
						}
						else
						{
							child.SeCodeUserTypeToId = entity.SeCodeUserTypeId;
						}

					}

					if (entity.SvMessageSendPrvCollectionGetBySeCodeUserTypeToId.Count > 0 || entity.SvMessageSendPrvCollectionGetBySeCodeUserTypeToId.DeletedItems.Count > 0)
					{
						//DataRepository.SvMessageSendPrvProvider.Save(transactionManager, entity.SvMessageSendPrvCollectionGetBySeCodeUserTypeToId);
						
						deepHandles.Add("SvMessageSendPrvCollectionGetBySeCodeUserTypeToId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvMessageSendPrv >) DataRepository.SvMessageSendPrvProvider.DeepSave,
							new object[] { transactionManager, entity.SvMessageSendPrvCollectionGetBySeCodeUserTypeToId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCodeSemActvity>
				if (CanDeepSave(entity.EdCodeSemActvityCollection, "List<EdCodeSemActvity>|EdCodeSemActvityCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCodeSemActvity child in entity.EdCodeSemActvityCollection)
					{
						if(child.SeCodeUserTypeIdSource != null)
						{
							child.SeCodeUserTypeId = child.SeCodeUserTypeIdSource.SeCodeUserTypeId;
						}
						else
						{
							child.SeCodeUserTypeId = entity.SeCodeUserTypeId;
						}

					}

					if (entity.EdCodeSemActvityCollection.Count > 0 || entity.EdCodeSemActvityCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCodeSemActvityProvider.Save(transactionManager, entity.EdCodeSemActvityCollection);
						
						deepHandles.Add("EdCodeSemActvityCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCodeSemActvity >) DataRepository.EdCodeSemActvityProvider.DeepSave,
							new object[] { transactionManager, entity.EdCodeSemActvityCollection, deepSaveType, childTypes, innerList }
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
	
	#region SeCodeUserTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeCodeUserType</c>
	///</summary>
	public enum SeCodeUserTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SeCodeUserType</c> as OneToMany for SvMessageSendPrvCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvMessageSendPrv>))]
		SvMessageSendPrvCollectionGetBySeCodeUserTypeFromId,
		///<summary>
		/// Collection of <c>SeCodeUserType</c> as OneToMany for SvAutoMsgTmpltCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvAutoMsgTmplt>))]
		SvAutoMsgTmpltCollection,
		///<summary>
		/// Collection of <c>SeCodeUserType</c> as OneToMany for SeStudTabUserTypeControlCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeStudTabUserTypeControl>))]
		SeStudTabUserTypeControlCollection,
		///<summary>
		/// Collection of <c>SeCodeUserType</c> as OneToMany for WfCrsRsltApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<WfCrsRsltApprove>))]
		WfCrsRsltApproveCollection,
		///<summary>
		/// Collection of <c>SeCodeUserType</c> as OneToMany for SvCdeMsgParamCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvCdeMsgParam>))]
		SvCdeMsgParamCollection,
		///<summary>
		/// Collection of <c>SeCodeUserType</c> as OneToMany for SvUserTaskCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvUserTask>))]
		SvUserTaskCollection,
		///<summary>
		/// Collection of <c>SeCodeUserType</c> as OneToMany for EdStudCourseGrdChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseGrdChng>))]
		EdStudCourseGrdChngCollection,
		///<summary>
		/// Collection of <c>SeCodeUserType</c> as OneToMany for SeUserCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUser>))]
		SeUserCollection,
		///<summary>
		/// Collection of <c>SeCodeUserType</c> as OneToMany for SeAccntCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeAccnt>))]
		SeAccntCollection,
		///<summary>
		/// Collection of <c>SeCodeUserType</c> as OneToMany for GsCdeClrncItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCdeClrncItem>))]
		GsCdeClrncItemCollection,
		///<summary>
		/// Collection of <c>SeCodeUserType</c> as OneToMany for SeModuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeModule>))]
		SeModuleCollection,
		///<summary>
		/// Collection of <c>SeCodeUserType</c> as OneToMany for EdStudNoteCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudNote>))]
		EdStudNoteCollection,
		///<summary>
		/// Collection of <c>SeCodeUserType</c> as OneToMany for GsCodeApprovalCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCodeApproval>))]
		GsCodeApprovalCollection,
		///<summary>
		/// Collection of <c>SeCodeUserType</c> as OneToMany for AccomWfRequestApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomWfRequestApprove>))]
		AccomWfRequestApproveCollection,
		///<summary>
		/// Collection of <c>SeCodeUserType</c> as OneToMany for SvMessageSendPrvCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvMessageSendPrv>))]
		SvMessageSendPrvCollectionGetBySeCodeUserTypeToId,
		///<summary>
		/// Collection of <c>SeCodeUserType</c> as OneToMany for EdCodeSemActvityCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCodeSemActvity>))]
		EdCodeSemActvityCollection,
	}
	
	#endregion SeCodeUserTypeChildEntityTypes
	
	#region SeCodeUserTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeCodeUserTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeCodeUserType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeCodeUserTypeFilterBuilder : SqlFilterBuilder<SeCodeUserTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeCodeUserTypeFilterBuilder class.
		/// </summary>
		public SeCodeUserTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeCodeUserTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeCodeUserTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeCodeUserTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeCodeUserTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeCodeUserTypeFilterBuilder
	
	#region SeCodeUserTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeCodeUserTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeCodeUserType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeCodeUserTypeParameterBuilder : ParameterizedSqlFilterBuilder<SeCodeUserTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeCodeUserTypeParameterBuilder class.
		/// </summary>
		public SeCodeUserTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeCodeUserTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeCodeUserTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeCodeUserTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeCodeUserTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeCodeUserTypeParameterBuilder
	
	#region SeCodeUserTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeCodeUserTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeCodeUserType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeCodeUserTypeSortBuilder : SqlSortBuilder<SeCodeUserTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeCodeUserTypeSqlSortBuilder class.
		/// </summary>
		public SeCodeUserTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeCodeUserTypeSortBuilder
	
} // end namespace
