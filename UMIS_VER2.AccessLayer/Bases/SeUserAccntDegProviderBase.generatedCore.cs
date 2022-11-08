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
	/// This class is the base class for any <see cref="SeUserAccntDegProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeUserAccntDegProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeUserAccntDeg, UMIS_VER2.BusinessLyer.SeUserAccntDegKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserAccntDegKey key)
		{
			return Delete(transactionManager, key.SeUserAccntDegId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seUserAccntDegId">degree related with account not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seUserAccntDegId)
		{
			return Delete(null, _seUserAccntDegId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntDegId">degree related with account not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seUserAccntDegId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_DEG_AS_CODE_DEGREE key.
		///		FK_SE_USER_ACCNT_DEG_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntDeg objects.</returns>
		public TList<SeUserAccntDeg> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_DEG_AS_CODE_DEGREE key.
		///		FK_SE_USER_ACCNT_DEG_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntDeg objects.</returns>
		/// <remarks></remarks>
		public TList<SeUserAccntDeg> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_DEG_AS_CODE_DEGREE key.
		///		FK_SE_USER_ACCNT_DEG_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntDeg objects.</returns>
		public TList<SeUserAccntDeg> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_DEG_AS_CODE_DEGREE key.
		///		fkSeUserAccntDegAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntDeg objects.</returns>
		public TList<SeUserAccntDeg> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_DEG_AS_CODE_DEGREE key.
		///		fkSeUserAccntDegAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntDeg objects.</returns>
		public TList<SeUserAccntDeg> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_DEG_AS_CODE_DEGREE key.
		///		FK_SE_USER_ACCNT_DEG_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntDeg objects.</returns>
		public abstract TList<SeUserAccntDeg> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_DEG_SE_USER_ACCNT key.
		///		FK_SE_USER_ACCNT_DEG_SE_USER_ACCNT Description: 
		/// </summary>
		/// <param name="_seUserAccntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntDeg objects.</returns>
		public TList<SeUserAccntDeg> GetBySeUserAccntId(System.Decimal _seUserAccntId)
		{
			int count = -1;
			return GetBySeUserAccntId(_seUserAccntId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_DEG_SE_USER_ACCNT key.
		///		FK_SE_USER_ACCNT_DEG_SE_USER_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntDeg objects.</returns>
		/// <remarks></remarks>
		public TList<SeUserAccntDeg> GetBySeUserAccntId(TransactionManager transactionManager, System.Decimal _seUserAccntId)
		{
			int count = -1;
			return GetBySeUserAccntId(transactionManager, _seUserAccntId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_DEG_SE_USER_ACCNT key.
		///		FK_SE_USER_ACCNT_DEG_SE_USER_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntDeg objects.</returns>
		public TList<SeUserAccntDeg> GetBySeUserAccntId(TransactionManager transactionManager, System.Decimal _seUserAccntId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserAccntId(transactionManager, _seUserAccntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_DEG_SE_USER_ACCNT key.
		///		fkSeUserAccntDegSeUserAccnt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserAccntId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntDeg objects.</returns>
		public TList<SeUserAccntDeg> GetBySeUserAccntId(System.Decimal _seUserAccntId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserAccntId(null, _seUserAccntId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_DEG_SE_USER_ACCNT key.
		///		fkSeUserAccntDegSeUserAccnt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserAccntId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntDeg objects.</returns>
		public TList<SeUserAccntDeg> GetBySeUserAccntId(System.Decimal _seUserAccntId, int start, int pageLength,out int count)
		{
			return GetBySeUserAccntId(null, _seUserAccntId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_DEG_SE_USER_ACCNT key.
		///		FK_SE_USER_ACCNT_DEG_SE_USER_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntDeg objects.</returns>
		public abstract TList<SeUserAccntDeg> GetBySeUserAccntId(TransactionManager transactionManager, System.Decimal _seUserAccntId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SeUserAccntDeg Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserAccntDegKey key, int start, int pageLength)
		{
			return GetBySeUserAccntDegId(transactionManager, key.SeUserAccntDegId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_USER_ACCNT_DEG index.
		/// </summary>
		/// <param name="_seUserAccntDegId">degree related with account not used</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntDeg GetBySeUserAccntDegId(System.Decimal _seUserAccntDegId)
		{
			int count = -1;
			return GetBySeUserAccntDegId(null,_seUserAccntDegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT_DEG index.
		/// </summary>
		/// <param name="_seUserAccntDegId">degree related with account not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntDeg GetBySeUserAccntDegId(System.Decimal _seUserAccntDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserAccntDegId(null, _seUserAccntDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT_DEG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntDegId">degree related with account not used</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntDeg GetBySeUserAccntDegId(TransactionManager transactionManager, System.Decimal _seUserAccntDegId)
		{
			int count = -1;
			return GetBySeUserAccntDegId(transactionManager, _seUserAccntDegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT_DEG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntDegId">degree related with account not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntDeg GetBySeUserAccntDegId(TransactionManager transactionManager, System.Decimal _seUserAccntDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserAccntDegId(transactionManager, _seUserAccntDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT_DEG index.
		/// </summary>
		/// <param name="_seUserAccntDegId">degree related with account not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntDeg GetBySeUserAccntDegId(System.Decimal _seUserAccntDegId, int start, int pageLength, out int count)
		{
			return GetBySeUserAccntDegId(null, _seUserAccntDegId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT_DEG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntDegId">degree related with account not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntDeg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeUserAccntDeg GetBySeUserAccntDegId(TransactionManager transactionManager, System.Decimal _seUserAccntDegId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeUserAccntDeg&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeUserAccntDeg&gt;"/></returns>
		public static TList<SeUserAccntDeg> Fill(IDataReader reader, TList<SeUserAccntDeg> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeUserAccntDeg c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeUserAccntDeg")
					.Append("|").Append((System.Decimal)reader["SE_USER_ACCNT_DEG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeUserAccntDeg>(
					key.ToString(), // EntityTrackingKey
					"SeUserAccntDeg",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeUserAccntDeg();
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
					c.SeUserAccntDegId = (System.Decimal)reader["SE_USER_ACCNT_DEG_ID"];
					c.OriginalSeUserAccntDegId = c.SeUserAccntDegId;
					c.SeUserAccntId = (System.Decimal)reader["SE_USER_ACCNT_ID"];
					c.AsCodeDegreeId = (System.Decimal)reader["AS_CODE_DEGREE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntDeg"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeUserAccntDeg"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeUserAccntDeg entity)
		{
			if (!reader.Read()) return;
			
			entity.SeUserAccntDegId = (System.Decimal)reader[((int)SeUserAccntDegColumn.SeUserAccntDegId - 1)];
			entity.OriginalSeUserAccntDegId = (System.Decimal)reader["SE_USER_ACCNT_DEG_ID"];
			entity.SeUserAccntId = (System.Decimal)reader[((int)SeUserAccntDegColumn.SeUserAccntId - 1)];
			entity.AsCodeDegreeId = (System.Decimal)reader[((int)SeUserAccntDegColumn.AsCodeDegreeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntDeg"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeUserAccntDeg"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeUserAccntDeg entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeUserAccntDegId = (System.Decimal)dataRow["SE_USER_ACCNT_DEG_ID"];
			entity.OriginalSeUserAccntDegId = (System.Decimal)dataRow["SE_USER_ACCNT_DEG_ID"];
			entity.SeUserAccntId = (System.Decimal)dataRow["SE_USER_ACCNT_ID"];
			entity.AsCodeDegreeId = (System.Decimal)dataRow["AS_CODE_DEGREE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeUserAccntDeg"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeUserAccntDeg Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserAccntDeg entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsCodeDegreeIdSource	
			if (CanDeepLoad(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsCodeDegreeId;
				AsCodeDegree tmpEntity = EntityManager.LocateEntity<AsCodeDegree>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeIdSource = tmpEntity;
				else
					entity.AsCodeDegreeIdSource = DataRepository.AsCodeDegreeProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeProvider.DeepLoad(transactionManager, entity.AsCodeDegreeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeIdSource

			#region SeUserAccntIdSource	
			if (CanDeepLoad(entity, "SeUserAccnt|SeUserAccntIdSource", deepLoadType, innerList) 
				&& entity.SeUserAccntIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeUserAccntId;
				SeUserAccnt tmpEntity = EntityManager.LocateEntity<SeUserAccnt>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUserAccnt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserAccntIdSource = tmpEntity;
				else
					entity.SeUserAccntIdSource = DataRepository.SeUserAccntProvider.GetBySeUserAccntId(transactionManager, entity.SeUserAccntId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserAccntIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserAccntIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserAccntProvider.DeepLoad(transactionManager, entity.SeUserAccntIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserAccntIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeUserAccntDeg object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeUserAccntDeg instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeUserAccntDeg Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserAccntDeg entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsCodeDegreeIdSource
			if (CanDeepSave(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeIdSource != null)
			{
				DataRepository.AsCodeDegreeProvider.Save(transactionManager, entity.AsCodeDegreeIdSource);
				entity.AsCodeDegreeId = entity.AsCodeDegreeIdSource.AsCodeDegreeId;
			}
			#endregion 
			
			#region SeUserAccntIdSource
			if (CanDeepSave(entity, "SeUserAccnt|SeUserAccntIdSource", deepSaveType, innerList) 
				&& entity.SeUserAccntIdSource != null)
			{
				DataRepository.SeUserAccntProvider.Save(transactionManager, entity.SeUserAccntIdSource);
				entity.SeUserAccntId = entity.SeUserAccntIdSource.SeUserAccntId;
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
	
	#region SeUserAccntDegChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeUserAccntDeg</c>
	///</summary>
	public enum SeUserAccntDegChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsCodeDegree</c> at AsCodeDegreeIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegree))]
		AsCodeDegree,
		
		///<summary>
		/// Composite Property for <c>SeUserAccnt</c> at SeUserAccntIdSource
		///</summary>
		[ChildEntityType(typeof(SeUserAccnt))]
		SeUserAccnt,
	}
	
	#endregion SeUserAccntDegChildEntityTypes
	
	#region SeUserAccntDegFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeUserAccntDegColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeUserAccntDeg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeUserAccntDegFilterBuilder : SqlFilterBuilder<SeUserAccntDegColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeUserAccntDegFilterBuilder class.
		/// </summary>
		public SeUserAccntDegFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeUserAccntDegFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeUserAccntDegFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeUserAccntDegFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeUserAccntDegFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeUserAccntDegFilterBuilder
	
	#region SeUserAccntDegParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeUserAccntDegColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeUserAccntDeg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeUserAccntDegParameterBuilder : ParameterizedSqlFilterBuilder<SeUserAccntDegColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeUserAccntDegParameterBuilder class.
		/// </summary>
		public SeUserAccntDegParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeUserAccntDegParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeUserAccntDegParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeUserAccntDegParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeUserAccntDegParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeUserAccntDegParameterBuilder
	
	#region SeUserAccntDegSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeUserAccntDegColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeUserAccntDeg"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeUserAccntDegSortBuilder : SqlSortBuilder<SeUserAccntDegColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeUserAccntDegSqlSortBuilder class.
		/// </summary>
		public SeUserAccntDegSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeUserAccntDegSortBuilder
	
} // end namespace
