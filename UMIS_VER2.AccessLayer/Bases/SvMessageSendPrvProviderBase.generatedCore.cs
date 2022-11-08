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
	/// This class is the base class for any <see cref="SvMessageSendPrvProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvMessageSendPrvProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvMessageSendPrv, UMIS_VER2.BusinessLyer.SvMessageSendPrvKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvMessageSendPrvKey key)
		{
			return Delete(transactionManager, key.SvMessageSendPrvId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svMessageSendPrvId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svMessageSendPrvId)
		{
			return Delete(null, _svMessageSendPrvId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svMessageSendPrvId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svMessageSendPrvId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_FROM key.
		///		FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_FROM Description: 
		/// </summary>
		/// <param name="_seCodeUserTypeFromId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessageSendPrv objects.</returns>
		public TList<SvMessageSendPrv> GetBySeCodeUserTypeFromId(System.Decimal _seCodeUserTypeFromId)
		{
			int count = -1;
			return GetBySeCodeUserTypeFromId(_seCodeUserTypeFromId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_FROM key.
		///		FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_FROM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeFromId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessageSendPrv objects.</returns>
		/// <remarks></remarks>
		public TList<SvMessageSendPrv> GetBySeCodeUserTypeFromId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeFromId)
		{
			int count = -1;
			return GetBySeCodeUserTypeFromId(transactionManager, _seCodeUserTypeFromId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_FROM key.
		///		FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_FROM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeFromId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessageSendPrv objects.</returns>
		public TList<SvMessageSendPrv> GetBySeCodeUserTypeFromId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeFromId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserTypeFromId(transactionManager, _seCodeUserTypeFromId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_FROM key.
		///		fkSvMessageSendPrvSeCodeUserTypeFrom Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeFromId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessageSendPrv objects.</returns>
		public TList<SvMessageSendPrv> GetBySeCodeUserTypeFromId(System.Decimal _seCodeUserTypeFromId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeCodeUserTypeFromId(null, _seCodeUserTypeFromId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_FROM key.
		///		fkSvMessageSendPrvSeCodeUserTypeFrom Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeFromId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessageSendPrv objects.</returns>
		public TList<SvMessageSendPrv> GetBySeCodeUserTypeFromId(System.Decimal _seCodeUserTypeFromId, int start, int pageLength,out int count)
		{
			return GetBySeCodeUserTypeFromId(null, _seCodeUserTypeFromId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_FROM key.
		///		FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_FROM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeFromId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessageSendPrv objects.</returns>
		public abstract TList<SvMessageSendPrv> GetBySeCodeUserTypeFromId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeFromId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_TO key.
		///		FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_TO Description: 
		/// </summary>
		/// <param name="_seCodeUserTypeToId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessageSendPrv objects.</returns>
		public TList<SvMessageSendPrv> GetBySeCodeUserTypeToId(System.Decimal _seCodeUserTypeToId)
		{
			int count = -1;
			return GetBySeCodeUserTypeToId(_seCodeUserTypeToId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_TO key.
		///		FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_TO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeToId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessageSendPrv objects.</returns>
		/// <remarks></remarks>
		public TList<SvMessageSendPrv> GetBySeCodeUserTypeToId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeToId)
		{
			int count = -1;
			return GetBySeCodeUserTypeToId(transactionManager, _seCodeUserTypeToId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_TO key.
		///		FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_TO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessageSendPrv objects.</returns>
		public TList<SvMessageSendPrv> GetBySeCodeUserTypeToId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeToId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserTypeToId(transactionManager, _seCodeUserTypeToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_TO key.
		///		fkSvMessageSendPrvSeCodeUserTypeTo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeToId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessageSendPrv objects.</returns>
		public TList<SvMessageSendPrv> GetBySeCodeUserTypeToId(System.Decimal _seCodeUserTypeToId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeCodeUserTypeToId(null, _seCodeUserTypeToId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_TO key.
		///		fkSvMessageSendPrvSeCodeUserTypeTo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeToId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessageSendPrv objects.</returns>
		public TList<SvMessageSendPrv> GetBySeCodeUserTypeToId(System.Decimal _seCodeUserTypeToId, int start, int pageLength,out int count)
		{
			return GetBySeCodeUserTypeToId(null, _seCodeUserTypeToId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_TO key.
		///		FK_SV_MESSAGE_SEND_PRV_SE_CODE_USER_TYPE_TO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessageSendPrv objects.</returns>
		public abstract TList<SvMessageSendPrv> GetBySeCodeUserTypeToId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeToId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvMessageSendPrv Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvMessageSendPrvKey key, int start, int pageLength)
		{
			return GetBySvMessageSendPrvId(transactionManager, key.SvMessageSendPrvId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_MESSAGE_SEND_PRV index.
		/// </summary>
		/// <param name="_svMessageSendPrvId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvMessageSendPrv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvMessageSendPrv GetBySvMessageSendPrvId(System.Decimal _svMessageSendPrvId)
		{
			int count = -1;
			return GetBySvMessageSendPrvId(null,_svMessageSendPrvId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_MESSAGE_SEND_PRV index.
		/// </summary>
		/// <param name="_svMessageSendPrvId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvMessageSendPrv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvMessageSendPrv GetBySvMessageSendPrvId(System.Decimal _svMessageSendPrvId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvMessageSendPrvId(null, _svMessageSendPrvId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_MESSAGE_SEND_PRV index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svMessageSendPrvId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvMessageSendPrv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvMessageSendPrv GetBySvMessageSendPrvId(TransactionManager transactionManager, System.Decimal _svMessageSendPrvId)
		{
			int count = -1;
			return GetBySvMessageSendPrvId(transactionManager, _svMessageSendPrvId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_MESSAGE_SEND_PRV index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svMessageSendPrvId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvMessageSendPrv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvMessageSendPrv GetBySvMessageSendPrvId(TransactionManager transactionManager, System.Decimal _svMessageSendPrvId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvMessageSendPrvId(transactionManager, _svMessageSendPrvId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_MESSAGE_SEND_PRV index.
		/// </summary>
		/// <param name="_svMessageSendPrvId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvMessageSendPrv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvMessageSendPrv GetBySvMessageSendPrvId(System.Decimal _svMessageSendPrvId, int start, int pageLength, out int count)
		{
			return GetBySvMessageSendPrvId(null, _svMessageSendPrvId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_MESSAGE_SEND_PRV index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svMessageSendPrvId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvMessageSendPrv"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvMessageSendPrv GetBySvMessageSendPrvId(TransactionManager transactionManager, System.Decimal _svMessageSendPrvId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvMessageSendPrv&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvMessageSendPrv&gt;"/></returns>
		public static TList<SvMessageSendPrv> Fill(IDataReader reader, TList<SvMessageSendPrv> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvMessageSendPrv c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvMessageSendPrv")
					.Append("|").Append((System.Decimal)reader["SV_MESSAGE_SEND_PRV_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvMessageSendPrv>(
					key.ToString(), // EntityTrackingKey
					"SvMessageSendPrv",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvMessageSendPrv();
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
					c.SvMessageSendPrvId = (System.Decimal)reader["SV_MESSAGE_SEND_PRV_ID"];
					c.OriginalSvMessageSendPrvId = c.SvMessageSendPrvId;
					c.SeCodeUserTypeFromId = (System.Decimal)reader["SE_CODE_USER_TYPE_FROM_ID"];
					c.SeCodeUserTypeToId = (System.Decimal)reader["SE_CODE_USER_TYPE_TO_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvMessageSendPrv"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvMessageSendPrv"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvMessageSendPrv entity)
		{
			if (!reader.Read()) return;
			
			entity.SvMessageSendPrvId = (System.Decimal)reader[((int)SvMessageSendPrvColumn.SvMessageSendPrvId - 1)];
			entity.OriginalSvMessageSendPrvId = (System.Decimal)reader["SV_MESSAGE_SEND_PRV_ID"];
			entity.SeCodeUserTypeFromId = (System.Decimal)reader[((int)SvMessageSendPrvColumn.SeCodeUserTypeFromId - 1)];
			entity.SeCodeUserTypeToId = (System.Decimal)reader[((int)SvMessageSendPrvColumn.SeCodeUserTypeToId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvMessageSendPrv"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvMessageSendPrv"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvMessageSendPrv entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvMessageSendPrvId = (System.Decimal)dataRow["SV_MESSAGE_SEND_PRV_ID"];
			entity.OriginalSvMessageSendPrvId = (System.Decimal)dataRow["SV_MESSAGE_SEND_PRV_ID"];
			entity.SeCodeUserTypeFromId = (System.Decimal)dataRow["SE_CODE_USER_TYPE_FROM_ID"];
			entity.SeCodeUserTypeToId = (System.Decimal)dataRow["SE_CODE_USER_TYPE_TO_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvMessageSendPrv"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvMessageSendPrv Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvMessageSendPrv entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SeCodeUserTypeFromIdSource	
			if (CanDeepLoad(entity, "SeCodeUserType|SeCodeUserTypeFromIdSource", deepLoadType, innerList) 
				&& entity.SeCodeUserTypeFromIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeCodeUserTypeFromId;
				SeCodeUserType tmpEntity = EntityManager.LocateEntity<SeCodeUserType>(EntityLocator.ConstructKeyFromPkItems(typeof(SeCodeUserType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeCodeUserTypeFromIdSource = tmpEntity;
				else
					entity.SeCodeUserTypeFromIdSource = DataRepository.SeCodeUserTypeProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeFromId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeCodeUserTypeFromIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeCodeUserTypeFromIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeCodeUserTypeProvider.DeepLoad(transactionManager, entity.SeCodeUserTypeFromIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeCodeUserTypeFromIdSource

			#region SeCodeUserTypeToIdSource	
			if (CanDeepLoad(entity, "SeCodeUserType|SeCodeUserTypeToIdSource", deepLoadType, innerList) 
				&& entity.SeCodeUserTypeToIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeCodeUserTypeToId;
				SeCodeUserType tmpEntity = EntityManager.LocateEntity<SeCodeUserType>(EntityLocator.ConstructKeyFromPkItems(typeof(SeCodeUserType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeCodeUserTypeToIdSource = tmpEntity;
				else
					entity.SeCodeUserTypeToIdSource = DataRepository.SeCodeUserTypeProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeToId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeCodeUserTypeToIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeCodeUserTypeToIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeCodeUserTypeProvider.DeepLoad(transactionManager, entity.SeCodeUserTypeToIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeCodeUserTypeToIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvMessageSendPrv object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvMessageSendPrv instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvMessageSendPrv Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvMessageSendPrv entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SeCodeUserTypeFromIdSource
			if (CanDeepSave(entity, "SeCodeUserType|SeCodeUserTypeFromIdSource", deepSaveType, innerList) 
				&& entity.SeCodeUserTypeFromIdSource != null)
			{
				DataRepository.SeCodeUserTypeProvider.Save(transactionManager, entity.SeCodeUserTypeFromIdSource);
				entity.SeCodeUserTypeFromId = entity.SeCodeUserTypeFromIdSource.SeCodeUserTypeId;
			}
			#endregion 
			
			#region SeCodeUserTypeToIdSource
			if (CanDeepSave(entity, "SeCodeUserType|SeCodeUserTypeToIdSource", deepSaveType, innerList) 
				&& entity.SeCodeUserTypeToIdSource != null)
			{
				DataRepository.SeCodeUserTypeProvider.Save(transactionManager, entity.SeCodeUserTypeToIdSource);
				entity.SeCodeUserTypeToId = entity.SeCodeUserTypeToIdSource.SeCodeUserTypeId;
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
	
	#region SvMessageSendPrvChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvMessageSendPrv</c>
	///</summary>
	public enum SvMessageSendPrvChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SeCodeUserType</c> at SeCodeUserTypeFromIdSource
		///</summary>
		[ChildEntityType(typeof(SeCodeUserType))]
		SeCodeUserType,
	}
	
	#endregion SvMessageSendPrvChildEntityTypes
	
	#region SvMessageSendPrvFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvMessageSendPrvColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvMessageSendPrv"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvMessageSendPrvFilterBuilder : SqlFilterBuilder<SvMessageSendPrvColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvMessageSendPrvFilterBuilder class.
		/// </summary>
		public SvMessageSendPrvFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvMessageSendPrvFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvMessageSendPrvFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvMessageSendPrvFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvMessageSendPrvFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvMessageSendPrvFilterBuilder
	
	#region SvMessageSendPrvParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvMessageSendPrvColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvMessageSendPrv"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvMessageSendPrvParameterBuilder : ParameterizedSqlFilterBuilder<SvMessageSendPrvColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvMessageSendPrvParameterBuilder class.
		/// </summary>
		public SvMessageSendPrvParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvMessageSendPrvParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvMessageSendPrvParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvMessageSendPrvParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvMessageSendPrvParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvMessageSendPrvParameterBuilder
	
	#region SvMessageSendPrvSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvMessageSendPrvColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvMessageSendPrv"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvMessageSendPrvSortBuilder : SqlSortBuilder<SvMessageSendPrvColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvMessageSendPrvSqlSortBuilder class.
		/// </summary>
		public SvMessageSendPrvSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvMessageSendPrvSortBuilder
	
} // end namespace
