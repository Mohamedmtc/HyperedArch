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
	/// This class is the base class for any <see cref="SeUserAccntControlDiffProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeUserAccntControlDiffProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeUserAccntControlDiff, UMIS_VER2.BusinessLyer.SeUserAccntControlDiffKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserAccntControlDiffKey key)
		{
			return Delete(transactionManager, key.SeUserAccntControlDiffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seUserAccntControlDiffId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seUserAccntControlDiffId)
		{
			return Delete(null, _seUserAccntControlDiffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntControlDiffId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seUserAccntControlDiffId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL key.
		///		FK_SE_USER_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL Description: 
		/// </summary>
		/// <param name="_seFormControlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntControlDiff objects.</returns>
		public TList<SeUserAccntControlDiff> GetBySeFormControlId(System.Decimal _seFormControlId)
		{
			int count = -1;
			return GetBySeFormControlId(_seFormControlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL key.
		///		FK_SE_USER_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormControlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntControlDiff objects.</returns>
		/// <remarks></remarks>
		public TList<SeUserAccntControlDiff> GetBySeFormControlId(TransactionManager transactionManager, System.Decimal _seFormControlId)
		{
			int count = -1;
			return GetBySeFormControlId(transactionManager, _seFormControlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL key.
		///		FK_SE_USER_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntControlDiff objects.</returns>
		public TList<SeUserAccntControlDiff> GetBySeFormControlId(TransactionManager transactionManager, System.Decimal _seFormControlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormControlId(transactionManager, _seFormControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL key.
		///		fkSeUserAccntControlDiffSeFormControl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormControlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntControlDiff objects.</returns>
		public TList<SeUserAccntControlDiff> GetBySeFormControlId(System.Decimal _seFormControlId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeFormControlId(null, _seFormControlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL key.
		///		fkSeUserAccntControlDiffSeFormControl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormControlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntControlDiff objects.</returns>
		public TList<SeUserAccntControlDiff> GetBySeFormControlId(System.Decimal _seFormControlId, int start, int pageLength,out int count)
		{
			return GetBySeFormControlId(null, _seFormControlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL key.
		///		FK_SE_USER_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntControlDiff objects.</returns>
		public abstract TList<SeUserAccntControlDiff> GetBySeFormControlId(TransactionManager transactionManager, System.Decimal _seFormControlId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_CONTROL_DIFF_SE_USER_ACCNT key.
		///		FK_SE_USER_ACCNT_CONTROL_DIFF_SE_USER_ACCNT Description: 
		/// </summary>
		/// <param name="_seUserAccountId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntControlDiff objects.</returns>
		public TList<SeUserAccntControlDiff> GetBySeUserAccountId(System.Decimal _seUserAccountId)
		{
			int count = -1;
			return GetBySeUserAccountId(_seUserAccountId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_CONTROL_DIFF_SE_USER_ACCNT key.
		///		FK_SE_USER_ACCNT_CONTROL_DIFF_SE_USER_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccountId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntControlDiff objects.</returns>
		/// <remarks></remarks>
		public TList<SeUserAccntControlDiff> GetBySeUserAccountId(TransactionManager transactionManager, System.Decimal _seUserAccountId)
		{
			int count = -1;
			return GetBySeUserAccountId(transactionManager, _seUserAccountId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_CONTROL_DIFF_SE_USER_ACCNT key.
		///		FK_SE_USER_ACCNT_CONTROL_DIFF_SE_USER_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntControlDiff objects.</returns>
		public TList<SeUserAccntControlDiff> GetBySeUserAccountId(TransactionManager transactionManager, System.Decimal _seUserAccountId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserAccountId(transactionManager, _seUserAccountId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_CONTROL_DIFF_SE_USER_ACCNT key.
		///		fkSeUserAccntControlDiffSeUserAccnt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserAccountId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntControlDiff objects.</returns>
		public TList<SeUserAccntControlDiff> GetBySeUserAccountId(System.Decimal _seUserAccountId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserAccountId(null, _seUserAccountId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_CONTROL_DIFF_SE_USER_ACCNT key.
		///		fkSeUserAccntControlDiffSeUserAccnt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserAccountId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntControlDiff objects.</returns>
		public TList<SeUserAccntControlDiff> GetBySeUserAccountId(System.Decimal _seUserAccountId, int start, int pageLength,out int count)
		{
			return GetBySeUserAccountId(null, _seUserAccountId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_CONTROL_DIFF_SE_USER_ACCNT key.
		///		FK_SE_USER_ACCNT_CONTROL_DIFF_SE_USER_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccntControlDiff objects.</returns>
		public abstract TList<SeUserAccntControlDiff> GetBySeUserAccountId(TransactionManager transactionManager, System.Decimal _seUserAccountId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SeUserAccntControlDiff Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserAccntControlDiffKey key, int start, int pageLength)
		{
			return GetBySeUserAccntControlDiffId(transactionManager, key.SeUserAccntControlDiffId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_USER_ACCNT_CONTROL_DIFF index.
		/// </summary>
		/// <param name="_seUserAccntControlDiffId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntControlDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntControlDiff GetBySeUserAccntControlDiffId(System.Decimal _seUserAccntControlDiffId)
		{
			int count = -1;
			return GetBySeUserAccntControlDiffId(null,_seUserAccntControlDiffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT_CONTROL_DIFF index.
		/// </summary>
		/// <param name="_seUserAccntControlDiffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntControlDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntControlDiff GetBySeUserAccntControlDiffId(System.Decimal _seUserAccntControlDiffId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserAccntControlDiffId(null, _seUserAccntControlDiffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT_CONTROL_DIFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntControlDiffId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntControlDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntControlDiff GetBySeUserAccntControlDiffId(TransactionManager transactionManager, System.Decimal _seUserAccntControlDiffId)
		{
			int count = -1;
			return GetBySeUserAccntControlDiffId(transactionManager, _seUserAccntControlDiffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT_CONTROL_DIFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntControlDiffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntControlDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntControlDiff GetBySeUserAccntControlDiffId(TransactionManager transactionManager, System.Decimal _seUserAccntControlDiffId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserAccntControlDiffId(transactionManager, _seUserAccntControlDiffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT_CONTROL_DIFF index.
		/// </summary>
		/// <param name="_seUserAccntControlDiffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntControlDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntControlDiff GetBySeUserAccntControlDiffId(System.Decimal _seUserAccntControlDiffId, int start, int pageLength, out int count)
		{
			return GetBySeUserAccntControlDiffId(null, _seUserAccntControlDiffId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT_CONTROL_DIFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntControlDiffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntControlDiff"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeUserAccntControlDiff GetBySeUserAccntControlDiffId(TransactionManager transactionManager, System.Decimal _seUserAccntControlDiffId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeUserAccntControlDiff&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeUserAccntControlDiff&gt;"/></returns>
		public static TList<SeUserAccntControlDiff> Fill(IDataReader reader, TList<SeUserAccntControlDiff> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeUserAccntControlDiff c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeUserAccntControlDiff")
					.Append("|").Append((System.Decimal)reader["SE_USER_ACCNT_CONTROL_DIFF_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeUserAccntControlDiff>(
					key.ToString(), // EntityTrackingKey
					"SeUserAccntControlDiff",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeUserAccntControlDiff();
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
					c.SeUserAccntControlDiffId = (System.Decimal)reader["SE_USER_ACCNT_CONTROL_DIFF_ID"];
					c.OriginalSeUserAccntControlDiffId = c.SeUserAccntControlDiffId;
					c.SeUserAccountId = (System.Decimal)reader["SE_USER_ACCOUNT_ID"];
					c.SeFormControlId = (System.Decimal)reader["SE_FORM_CONTROL_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntControlDiff"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeUserAccntControlDiff"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeUserAccntControlDiff entity)
		{
			if (!reader.Read()) return;
			
			entity.SeUserAccntControlDiffId = (System.Decimal)reader[((int)SeUserAccntControlDiffColumn.SeUserAccntControlDiffId - 1)];
			entity.OriginalSeUserAccntControlDiffId = (System.Decimal)reader["SE_USER_ACCNT_CONTROL_DIFF_ID"];
			entity.SeUserAccountId = (System.Decimal)reader[((int)SeUserAccntControlDiffColumn.SeUserAccountId - 1)];
			entity.SeFormControlId = (System.Decimal)reader[((int)SeUserAccntControlDiffColumn.SeFormControlId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntControlDiff"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeUserAccntControlDiff"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeUserAccntControlDiff entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeUserAccntControlDiffId = (System.Decimal)dataRow["SE_USER_ACCNT_CONTROL_DIFF_ID"];
			entity.OriginalSeUserAccntControlDiffId = (System.Decimal)dataRow["SE_USER_ACCNT_CONTROL_DIFF_ID"];
			entity.SeUserAccountId = (System.Decimal)dataRow["SE_USER_ACCOUNT_ID"];
			entity.SeFormControlId = (System.Decimal)dataRow["SE_FORM_CONTROL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeUserAccntControlDiff"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeUserAccntControlDiff Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserAccntControlDiff entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SeFormControlIdSource	
			if (CanDeepLoad(entity, "SeFormControl|SeFormControlIdSource", deepLoadType, innerList) 
				&& entity.SeFormControlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeFormControlId;
				SeFormControl tmpEntity = EntityManager.LocateEntity<SeFormControl>(EntityLocator.ConstructKeyFromPkItems(typeof(SeFormControl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeFormControlIdSource = tmpEntity;
				else
					entity.SeFormControlIdSource = DataRepository.SeFormControlProvider.GetBySeFormControlId(transactionManager, entity.SeFormControlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeFormControlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeFormControlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeFormControlProvider.DeepLoad(transactionManager, entity.SeFormControlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeFormControlIdSource

			#region SeUserAccountIdSource	
			if (CanDeepLoad(entity, "SeUserAccnt|SeUserAccountIdSource", deepLoadType, innerList) 
				&& entity.SeUserAccountIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeUserAccountId;
				SeUserAccnt tmpEntity = EntityManager.LocateEntity<SeUserAccnt>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUserAccnt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserAccountIdSource = tmpEntity;
				else
					entity.SeUserAccountIdSource = DataRepository.SeUserAccntProvider.GetBySeUserAccntId(transactionManager, entity.SeUserAccountId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserAccountIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserAccountIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserAccntProvider.DeepLoad(transactionManager, entity.SeUserAccountIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserAccountIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeUserAccntControlDiff object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeUserAccntControlDiff instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeUserAccntControlDiff Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserAccntControlDiff entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SeFormControlIdSource
			if (CanDeepSave(entity, "SeFormControl|SeFormControlIdSource", deepSaveType, innerList) 
				&& entity.SeFormControlIdSource != null)
			{
				DataRepository.SeFormControlProvider.Save(transactionManager, entity.SeFormControlIdSource);
				entity.SeFormControlId = entity.SeFormControlIdSource.SeFormControlId;
			}
			#endregion 
			
			#region SeUserAccountIdSource
			if (CanDeepSave(entity, "SeUserAccnt|SeUserAccountIdSource", deepSaveType, innerList) 
				&& entity.SeUserAccountIdSource != null)
			{
				DataRepository.SeUserAccntProvider.Save(transactionManager, entity.SeUserAccountIdSource);
				entity.SeUserAccountId = entity.SeUserAccountIdSource.SeUserAccntId;
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
	
	#region SeUserAccntControlDiffChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeUserAccntControlDiff</c>
	///</summary>
	public enum SeUserAccntControlDiffChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SeFormControl</c> at SeFormControlIdSource
		///</summary>
		[ChildEntityType(typeof(SeFormControl))]
		SeFormControl,
		
		///<summary>
		/// Composite Property for <c>SeUserAccnt</c> at SeUserAccountIdSource
		///</summary>
		[ChildEntityType(typeof(SeUserAccnt))]
		SeUserAccnt,
	}
	
	#endregion SeUserAccntControlDiffChildEntityTypes
	
	#region SeUserAccntControlDiffFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeUserAccntControlDiffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeUserAccntControlDiff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeUserAccntControlDiffFilterBuilder : SqlFilterBuilder<SeUserAccntControlDiffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeUserAccntControlDiffFilterBuilder class.
		/// </summary>
		public SeUserAccntControlDiffFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeUserAccntControlDiffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeUserAccntControlDiffFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeUserAccntControlDiffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeUserAccntControlDiffFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeUserAccntControlDiffFilterBuilder
	
	#region SeUserAccntControlDiffParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeUserAccntControlDiffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeUserAccntControlDiff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeUserAccntControlDiffParameterBuilder : ParameterizedSqlFilterBuilder<SeUserAccntControlDiffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeUserAccntControlDiffParameterBuilder class.
		/// </summary>
		public SeUserAccntControlDiffParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeUserAccntControlDiffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeUserAccntControlDiffParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeUserAccntControlDiffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeUserAccntControlDiffParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeUserAccntControlDiffParameterBuilder
	
	#region SeUserAccntControlDiffSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeUserAccntControlDiffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeUserAccntControlDiff"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeUserAccntControlDiffSortBuilder : SqlSortBuilder<SeUserAccntControlDiffColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeUserAccntControlDiffSqlSortBuilder class.
		/// </summary>
		public SeUserAccntControlDiffSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeUserAccntControlDiffSortBuilder
	
} // end namespace
