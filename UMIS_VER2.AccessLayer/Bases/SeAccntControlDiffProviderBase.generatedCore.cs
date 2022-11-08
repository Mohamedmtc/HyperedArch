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
	/// This class is the base class for any <see cref="SeAccntControlDiffProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeAccntControlDiffProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeAccntControlDiff, UMIS_VER2.BusinessLyer.SeAccntControlDiffKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeAccntControlDiffKey key)
		{
			return Delete(transactionManager, key.SeAccntControlDiffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seAccntControlDiffId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seAccntControlDiffId)
		{
			return Delete(null, _seAccntControlDiffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntControlDiffId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seAccntControlDiffId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_CONTROL_DIFF_SE_ACCNT key.
		///		FK_SE_ACCNT_CONTROL_DIFF_SE_ACCNT Description: 
		/// </summary>
		/// <param name="_seAccntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntControlDiff objects.</returns>
		public TList<SeAccntControlDiff> GetBySeAccntId(System.Decimal _seAccntId)
		{
			int count = -1;
			return GetBySeAccntId(_seAccntId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_CONTROL_DIFF_SE_ACCNT key.
		///		FK_SE_ACCNT_CONTROL_DIFF_SE_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntControlDiff objects.</returns>
		/// <remarks></remarks>
		public TList<SeAccntControlDiff> GetBySeAccntId(TransactionManager transactionManager, System.Decimal _seAccntId)
		{
			int count = -1;
			return GetBySeAccntId(transactionManager, _seAccntId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_CONTROL_DIFF_SE_ACCNT key.
		///		FK_SE_ACCNT_CONTROL_DIFF_SE_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntControlDiff objects.</returns>
		public TList<SeAccntControlDiff> GetBySeAccntId(TransactionManager transactionManager, System.Decimal _seAccntId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeAccntId(transactionManager, _seAccntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_CONTROL_DIFF_SE_ACCNT key.
		///		fkSeAccntControlDiffSeAccnt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seAccntId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntControlDiff objects.</returns>
		public TList<SeAccntControlDiff> GetBySeAccntId(System.Decimal _seAccntId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeAccntId(null, _seAccntId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_CONTROL_DIFF_SE_ACCNT key.
		///		fkSeAccntControlDiffSeAccnt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seAccntId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntControlDiff objects.</returns>
		public TList<SeAccntControlDiff> GetBySeAccntId(System.Decimal _seAccntId, int start, int pageLength,out int count)
		{
			return GetBySeAccntId(null, _seAccntId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_CONTROL_DIFF_SE_ACCNT key.
		///		FK_SE_ACCNT_CONTROL_DIFF_SE_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntControlDiff objects.</returns>
		public abstract TList<SeAccntControlDiff> GetBySeAccntId(TransactionManager transactionManager, System.Decimal _seAccntId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL key.
		///		FK_SE_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL Description: 
		/// </summary>
		/// <param name="_seFormControlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntControlDiff objects.</returns>
		public TList<SeAccntControlDiff> GetBySeFormControlId(System.Decimal _seFormControlId)
		{
			int count = -1;
			return GetBySeFormControlId(_seFormControlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL key.
		///		FK_SE_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormControlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntControlDiff objects.</returns>
		/// <remarks></remarks>
		public TList<SeAccntControlDiff> GetBySeFormControlId(TransactionManager transactionManager, System.Decimal _seFormControlId)
		{
			int count = -1;
			return GetBySeFormControlId(transactionManager, _seFormControlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL key.
		///		FK_SE_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntControlDiff objects.</returns>
		public TList<SeAccntControlDiff> GetBySeFormControlId(TransactionManager transactionManager, System.Decimal _seFormControlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormControlId(transactionManager, _seFormControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL key.
		///		fkSeAccntControlDiffSeFormControl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormControlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntControlDiff objects.</returns>
		public TList<SeAccntControlDiff> GetBySeFormControlId(System.Decimal _seFormControlId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeFormControlId(null, _seFormControlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL key.
		///		fkSeAccntControlDiffSeFormControl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormControlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntControlDiff objects.</returns>
		public TList<SeAccntControlDiff> GetBySeFormControlId(System.Decimal _seFormControlId, int start, int pageLength,out int count)
		{
			return GetBySeFormControlId(null, _seFormControlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL key.
		///		FK_SE_ACCNT_CONTROL_DIFF_SE_FORM_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntControlDiff objects.</returns>
		public abstract TList<SeAccntControlDiff> GetBySeFormControlId(TransactionManager transactionManager, System.Decimal _seFormControlId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SeAccntControlDiff Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeAccntControlDiffKey key, int start, int pageLength)
		{
			return GetBySeAccntControlDiffId(transactionManager, key.SeAccntControlDiffId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_ACCNT_CONTROL_DIFF index.
		/// </summary>
		/// <param name="_seAccntControlDiffId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccntControlDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccntControlDiff GetBySeAccntControlDiffId(System.Decimal _seAccntControlDiffId)
		{
			int count = -1;
			return GetBySeAccntControlDiffId(null,_seAccntControlDiffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_ACCNT_CONTROL_DIFF index.
		/// </summary>
		/// <param name="_seAccntControlDiffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccntControlDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccntControlDiff GetBySeAccntControlDiffId(System.Decimal _seAccntControlDiffId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeAccntControlDiffId(null, _seAccntControlDiffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_ACCNT_CONTROL_DIFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntControlDiffId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccntControlDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccntControlDiff GetBySeAccntControlDiffId(TransactionManager transactionManager, System.Decimal _seAccntControlDiffId)
		{
			int count = -1;
			return GetBySeAccntControlDiffId(transactionManager, _seAccntControlDiffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_ACCNT_CONTROL_DIFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntControlDiffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccntControlDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccntControlDiff GetBySeAccntControlDiffId(TransactionManager transactionManager, System.Decimal _seAccntControlDiffId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeAccntControlDiffId(transactionManager, _seAccntControlDiffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_ACCNT_CONTROL_DIFF index.
		/// </summary>
		/// <param name="_seAccntControlDiffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccntControlDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccntControlDiff GetBySeAccntControlDiffId(System.Decimal _seAccntControlDiffId, int start, int pageLength, out int count)
		{
			return GetBySeAccntControlDiffId(null, _seAccntControlDiffId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_ACCNT_CONTROL_DIFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntControlDiffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccntControlDiff"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeAccntControlDiff GetBySeAccntControlDiffId(TransactionManager transactionManager, System.Decimal _seAccntControlDiffId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeAccntControlDiff&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeAccntControlDiff&gt;"/></returns>
		public static TList<SeAccntControlDiff> Fill(IDataReader reader, TList<SeAccntControlDiff> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeAccntControlDiff c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeAccntControlDiff")
					.Append("|").Append((System.Decimal)reader["SE_ACCNT_CONTROL_DIFF_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeAccntControlDiff>(
					key.ToString(), // EntityTrackingKey
					"SeAccntControlDiff",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeAccntControlDiff();
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
					c.SeAccntControlDiffId = (System.Decimal)reader["SE_ACCNT_CONTROL_DIFF_ID"];
					c.OriginalSeAccntControlDiffId = c.SeAccntControlDiffId;
					c.SeAccntId = (System.Decimal)reader["SE_ACCNT_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeAccntControlDiff"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeAccntControlDiff"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeAccntControlDiff entity)
		{
			if (!reader.Read()) return;
			
			entity.SeAccntControlDiffId = (System.Decimal)reader[((int)SeAccntControlDiffColumn.SeAccntControlDiffId - 1)];
			entity.OriginalSeAccntControlDiffId = (System.Decimal)reader["SE_ACCNT_CONTROL_DIFF_ID"];
			entity.SeAccntId = (System.Decimal)reader[((int)SeAccntControlDiffColumn.SeAccntId - 1)];
			entity.SeFormControlId = (System.Decimal)reader[((int)SeAccntControlDiffColumn.SeFormControlId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeAccntControlDiff"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeAccntControlDiff"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeAccntControlDiff entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeAccntControlDiffId = (System.Decimal)dataRow["SE_ACCNT_CONTROL_DIFF_ID"];
			entity.OriginalSeAccntControlDiffId = (System.Decimal)dataRow["SE_ACCNT_CONTROL_DIFF_ID"];
			entity.SeAccntId = (System.Decimal)dataRow["SE_ACCNT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeAccntControlDiff"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeAccntControlDiff Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeAccntControlDiff entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SeAccntIdSource	
			if (CanDeepLoad(entity, "SeAccnt|SeAccntIdSource", deepLoadType, innerList) 
				&& entity.SeAccntIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeAccntId;
				SeAccnt tmpEntity = EntityManager.LocateEntity<SeAccnt>(EntityLocator.ConstructKeyFromPkItems(typeof(SeAccnt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeAccntIdSource = tmpEntity;
				else
					entity.SeAccntIdSource = DataRepository.SeAccntProvider.GetBySeAccntId(transactionManager, entity.SeAccntId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeAccntIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeAccntIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeAccntProvider.DeepLoad(transactionManager, entity.SeAccntIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeAccntIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeAccntControlDiff object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeAccntControlDiff instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeAccntControlDiff Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeAccntControlDiff entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SeAccntIdSource
			if (CanDeepSave(entity, "SeAccnt|SeAccntIdSource", deepSaveType, innerList) 
				&& entity.SeAccntIdSource != null)
			{
				DataRepository.SeAccntProvider.Save(transactionManager, entity.SeAccntIdSource);
				entity.SeAccntId = entity.SeAccntIdSource.SeAccntId;
			}
			#endregion 
			
			#region SeFormControlIdSource
			if (CanDeepSave(entity, "SeFormControl|SeFormControlIdSource", deepSaveType, innerList) 
				&& entity.SeFormControlIdSource != null)
			{
				DataRepository.SeFormControlProvider.Save(transactionManager, entity.SeFormControlIdSource);
				entity.SeFormControlId = entity.SeFormControlIdSource.SeFormControlId;
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
	
	#region SeAccntControlDiffChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeAccntControlDiff</c>
	///</summary>
	public enum SeAccntControlDiffChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SeAccnt</c> at SeAccntIdSource
		///</summary>
		[ChildEntityType(typeof(SeAccnt))]
		SeAccnt,
		
		///<summary>
		/// Composite Property for <c>SeFormControl</c> at SeFormControlIdSource
		///</summary>
		[ChildEntityType(typeof(SeFormControl))]
		SeFormControl,
	}
	
	#endregion SeAccntControlDiffChildEntityTypes
	
	#region SeAccntControlDiffFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeAccntControlDiffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeAccntControlDiff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeAccntControlDiffFilterBuilder : SqlFilterBuilder<SeAccntControlDiffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeAccntControlDiffFilterBuilder class.
		/// </summary>
		public SeAccntControlDiffFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeAccntControlDiffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeAccntControlDiffFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeAccntControlDiffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeAccntControlDiffFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeAccntControlDiffFilterBuilder
	
	#region SeAccntControlDiffParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeAccntControlDiffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeAccntControlDiff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeAccntControlDiffParameterBuilder : ParameterizedSqlFilterBuilder<SeAccntControlDiffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeAccntControlDiffParameterBuilder class.
		/// </summary>
		public SeAccntControlDiffParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeAccntControlDiffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeAccntControlDiffParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeAccntControlDiffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeAccntControlDiffParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeAccntControlDiffParameterBuilder
	
	#region SeAccntControlDiffSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeAccntControlDiffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeAccntControlDiff"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeAccntControlDiffSortBuilder : SqlSortBuilder<SeAccntControlDiffColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeAccntControlDiffSqlSortBuilder class.
		/// </summary>
		public SeAccntControlDiffSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeAccntControlDiffSortBuilder
	
} // end namespace
