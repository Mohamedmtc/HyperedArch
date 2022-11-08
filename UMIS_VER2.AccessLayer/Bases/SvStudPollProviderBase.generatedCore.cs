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
	/// This class is the base class for any <see cref="SvStudPollProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvStudPollProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvStudPoll, UMIS_VER2.BusinessLyer.SvStudPollKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudPollKey key)
		{
			return Delete(transactionManager, key.SvStudPollId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svStudPollId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svStudPollId)
		{
			return Delete(null, _svStudPollId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudPollId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svStudPollId);		
		
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
		public override UMIS_VER2.BusinessLyer.SvStudPoll Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudPollKey key, int start, int pageLength)
		{
			return GetBySvStudPollId(transactionManager, key.SvStudPollId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudPoll&gt;"/> class.</returns>
		public TList<SvStudPoll> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(null,_edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudPoll&gt;"/> class.</returns>
		public TList<SvStudPoll> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudPoll&gt;"/> class.</returns>
		public TList<SvStudPoll> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudPoll&gt;"/> class.</returns>
		public TList<SvStudPoll> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudPoll&gt;"/> class.</returns>
		public TList<SvStudPoll> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudPoll&gt;"/> class.</returns>
		public abstract TList<SvStudPoll> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SV_POLL_DTL_ID_1 index.
		/// </summary>
		/// <param name="_svPollDtlId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudPoll&gt;"/> class.</returns>
		public TList<SvStudPoll> GetBySvPollDtlId(System.Decimal _svPollDtlId)
		{
			int count = -1;
			return GetBySvPollDtlId(null,_svPollDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_POLL_DTL_ID_1 index.
		/// </summary>
		/// <param name="_svPollDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudPoll&gt;"/> class.</returns>
		public TList<SvStudPoll> GetBySvPollDtlId(System.Decimal _svPollDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvPollDtlId(null, _svPollDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_POLL_DTL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svPollDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudPoll&gt;"/> class.</returns>
		public TList<SvStudPoll> GetBySvPollDtlId(TransactionManager transactionManager, System.Decimal _svPollDtlId)
		{
			int count = -1;
			return GetBySvPollDtlId(transactionManager, _svPollDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_POLL_DTL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svPollDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudPoll&gt;"/> class.</returns>
		public TList<SvStudPoll> GetBySvPollDtlId(TransactionManager transactionManager, System.Decimal _svPollDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvPollDtlId(transactionManager, _svPollDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_POLL_DTL_ID_1 index.
		/// </summary>
		/// <param name="_svPollDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudPoll&gt;"/> class.</returns>
		public TList<SvStudPoll> GetBySvPollDtlId(System.Decimal _svPollDtlId, int start, int pageLength, out int count)
		{
			return GetBySvPollDtlId(null, _svPollDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_POLL_DTL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svPollDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudPoll&gt;"/> class.</returns>
		public abstract TList<SvStudPoll> GetBySvPollDtlId(TransactionManager transactionManager, System.Decimal _svPollDtlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_STUD_POLL index.
		/// </summary>
		/// <param name="_svStudPollId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudPoll"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudPoll GetBySvStudPollId(System.Decimal _svStudPollId)
		{
			int count = -1;
			return GetBySvStudPollId(null,_svStudPollId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_POLL index.
		/// </summary>
		/// <param name="_svStudPollId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudPoll"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudPoll GetBySvStudPollId(System.Decimal _svStudPollId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStudPollId(null, _svStudPollId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_POLL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudPollId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudPoll"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudPoll GetBySvStudPollId(TransactionManager transactionManager, System.Decimal _svStudPollId)
		{
			int count = -1;
			return GetBySvStudPollId(transactionManager, _svStudPollId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_POLL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudPollId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudPoll"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudPoll GetBySvStudPollId(TransactionManager transactionManager, System.Decimal _svStudPollId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStudPollId(transactionManager, _svStudPollId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_POLL index.
		/// </summary>
		/// <param name="_svStudPollId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudPoll"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudPoll GetBySvStudPollId(System.Decimal _svStudPollId, int start, int pageLength, out int count)
		{
			return GetBySvStudPollId(null, _svStudPollId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_POLL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudPollId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudPoll"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvStudPoll GetBySvStudPollId(TransactionManager transactionManager, System.Decimal _svStudPollId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvStudPoll&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvStudPoll&gt;"/></returns>
		public static TList<SvStudPoll> Fill(IDataReader reader, TList<SvStudPoll> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvStudPoll c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvStudPoll")
					.Append("|").Append((System.Decimal)reader["SV_STUD_POLL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvStudPoll>(
					key.ToString(), // EntityTrackingKey
					"SvStudPoll",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvStudPoll();
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
					c.SvStudPollId = (System.Decimal)reader["SV_STUD_POLL_ID"];
					c.OriginalSvStudPollId = c.SvStudPollId;
					c.SvPollDtlId = (System.Decimal)reader["SV_POLL_DTL_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStudPoll"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudPoll"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvStudPoll entity)
		{
			if (!reader.Read()) return;
			
			entity.SvStudPollId = (System.Decimal)reader[((int)SvStudPollColumn.SvStudPollId - 1)];
			entity.OriginalSvStudPollId = (System.Decimal)reader["SV_STUD_POLL_ID"];
			entity.SvPollDtlId = (System.Decimal)reader[((int)SvStudPollColumn.SvPollDtlId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)SvStudPollColumn.EdStudId - 1)];
			entity.Notes = (reader.IsDBNull(((int)SvStudPollColumn.Notes - 1)))?null:(System.String)reader[((int)SvStudPollColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStudPoll"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudPoll"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvStudPoll entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvStudPollId = (System.Decimal)dataRow["SV_STUD_POLL_ID"];
			entity.OriginalSvStudPollId = (System.Decimal)dataRow["SV_STUD_POLL_ID"];
			entity.SvPollDtlId = (System.Decimal)dataRow["SV_POLL_DTL_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudPoll"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStudPoll Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudPoll entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudId;
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudProvider.DeepLoad(transactionManager, entity.EdStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudIdSource

			#region SvPollDtlIdSource	
			if (CanDeepLoad(entity, "SvPollDtl|SvPollDtlIdSource", deepLoadType, innerList) 
				&& entity.SvPollDtlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvPollDtlId;
				SvPollDtl tmpEntity = EntityManager.LocateEntity<SvPollDtl>(EntityLocator.ConstructKeyFromPkItems(typeof(SvPollDtl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvPollDtlIdSource = tmpEntity;
				else
					entity.SvPollDtlIdSource = DataRepository.SvPollDtlProvider.GetBySvPollDtlId(transactionManager, entity.SvPollDtlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvPollDtlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvPollDtlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvPollDtlProvider.DeepLoad(transactionManager, entity.SvPollDtlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvPollDtlIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvStudPoll object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvStudPoll instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStudPoll Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudPoll entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region SvPollDtlIdSource
			if (CanDeepSave(entity, "SvPollDtl|SvPollDtlIdSource", deepSaveType, innerList) 
				&& entity.SvPollDtlIdSource != null)
			{
				DataRepository.SvPollDtlProvider.Save(transactionManager, entity.SvPollDtlIdSource);
				entity.SvPollDtlId = entity.SvPollDtlIdSource.SvPollDtlId;
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
	
	#region SvStudPollChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvStudPoll</c>
	///</summary>
	public enum SvStudPollChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>SvPollDtl</c> at SvPollDtlIdSource
		///</summary>
		[ChildEntityType(typeof(SvPollDtl))]
		SvPollDtl,
	}
	
	#endregion SvStudPollChildEntityTypes
	
	#region SvStudPollFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvStudPollColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudPoll"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStudPollFilterBuilder : SqlFilterBuilder<SvStudPollColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudPollFilterBuilder class.
		/// </summary>
		public SvStudPollFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStudPollFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStudPollFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStudPollFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStudPollFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStudPollFilterBuilder
	
	#region SvStudPollParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvStudPollColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudPoll"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStudPollParameterBuilder : ParameterizedSqlFilterBuilder<SvStudPollColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudPollParameterBuilder class.
		/// </summary>
		public SvStudPollParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStudPollParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStudPollParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStudPollParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStudPollParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStudPollParameterBuilder
	
	#region SvStudPollSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvStudPollColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudPoll"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvStudPollSortBuilder : SqlSortBuilder<SvStudPollColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudPollSqlSortBuilder class.
		/// </summary>
		public SvStudPollSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvStudPollSortBuilder
	
} // end namespace
