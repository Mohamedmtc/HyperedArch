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
	/// This class is the base class for any <see cref="SaCodePunishRsnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodePunishRsnProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodePunishRsn, UMIS_VER2.BusinessLyer.SaCodePunishRsnKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodePunishRsnKey key)
		{
			return Delete(transactionManager, key.SaCodePunishRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodePunishRsnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodePunishRsnId)
		{
			return Delete(null, _saCodePunishRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishRsnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodePunishRsnId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodePunishRsn Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodePunishRsnKey key, int start, int pageLength)
		{
			return GetBySaCodePunishRsnId(transactionManager, key.SaCodePunishRsnId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SA_CODE_PUNISH_RSN2 index.
		/// </summary>
		/// <param name="_punishReasonDescrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishRsn GetByPunishReasonDescrAr(System.String _punishReasonDescrAr)
		{
			int count = -1;
			return GetByPunishReasonDescrAr(null,_punishReasonDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PUNISH_RSN2 index.
		/// </summary>
		/// <param name="_punishReasonDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishRsn GetByPunishReasonDescrAr(System.String _punishReasonDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByPunishReasonDescrAr(null, _punishReasonDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PUNISH_RSN2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_punishReasonDescrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishRsn GetByPunishReasonDescrAr(TransactionManager transactionManager, System.String _punishReasonDescrAr)
		{
			int count = -1;
			return GetByPunishReasonDescrAr(transactionManager, _punishReasonDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PUNISH_RSN2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_punishReasonDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishRsn GetByPunishReasonDescrAr(TransactionManager transactionManager, System.String _punishReasonDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByPunishReasonDescrAr(transactionManager, _punishReasonDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PUNISH_RSN2 index.
		/// </summary>
		/// <param name="_punishReasonDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishRsn GetByPunishReasonDescrAr(System.String _punishReasonDescrAr, int start, int pageLength, out int count)
		{
			return GetByPunishReasonDescrAr(null, _punishReasonDescrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PUNISH_RSN2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_punishReasonDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishRsn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodePunishRsn GetByPunishReasonDescrAr(TransactionManager transactionManager, System.String _punishReasonDescrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_PUNISH_RSN index.
		/// </summary>
		/// <param name="_saCodePunishRsnId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishRsn GetBySaCodePunishRsnId(System.Decimal _saCodePunishRsnId)
		{
			int count = -1;
			return GetBySaCodePunishRsnId(null,_saCodePunishRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PUNISH_RSN index.
		/// </summary>
		/// <param name="_saCodePunishRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishRsn GetBySaCodePunishRsnId(System.Decimal _saCodePunishRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodePunishRsnId(null, _saCodePunishRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PUNISH_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishRsnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishRsn GetBySaCodePunishRsnId(TransactionManager transactionManager, System.Decimal _saCodePunishRsnId)
		{
			int count = -1;
			return GetBySaCodePunishRsnId(transactionManager, _saCodePunishRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PUNISH_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishRsn GetBySaCodePunishRsnId(TransactionManager transactionManager, System.Decimal _saCodePunishRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodePunishRsnId(transactionManager, _saCodePunishRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PUNISH_RSN index.
		/// </summary>
		/// <param name="_saCodePunishRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishRsn GetBySaCodePunishRsnId(System.Decimal _saCodePunishRsnId, int start, int pageLength, out int count)
		{
			return GetBySaCodePunishRsnId(null, _saCodePunishRsnId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PUNISH_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishRsn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodePunishRsn GetBySaCodePunishRsnId(TransactionManager transactionManager, System.Decimal _saCodePunishRsnId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodePunishRsn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodePunishRsn&gt;"/></returns>
		public static TList<SaCodePunishRsn> Fill(IDataReader reader, TList<SaCodePunishRsn> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodePunishRsn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodePunishRsn")
					.Append("|").Append((System.Decimal)reader["SA_CODE_PUNISH_RSN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodePunishRsn>(
					key.ToString(), // EntityTrackingKey
					"SaCodePunishRsn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodePunishRsn();
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
					c.SaCodePunishRsnId = (System.Decimal)reader["SA_CODE_PUNISH_RSN_ID"];
					c.OriginalSaCodePunishRsnId = c.SaCodePunishRsnId;
					c.PunishReasonCode = Convert.IsDBNull(reader["PUNISH_REASON_CODE"]) ? null : (System.String)reader["PUNISH_REASON_CODE"];
					c.PunishReasonDescrAr = (System.String)reader["PUNISH_REASON_DESCR_AR"];
					c.PunishReasonDescrEn = Convert.IsDBNull(reader["PUNISH_REASON_DESCR_EN"]) ? null : (System.String)reader["PUNISH_REASON_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishRsn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodePunishRsn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodePunishRsn entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodePunishRsnId = (System.Decimal)reader[((int)SaCodePunishRsnColumn.SaCodePunishRsnId - 1)];
			entity.OriginalSaCodePunishRsnId = (System.Decimal)reader["SA_CODE_PUNISH_RSN_ID"];
			entity.PunishReasonCode = (reader.IsDBNull(((int)SaCodePunishRsnColumn.PunishReasonCode - 1)))?null:(System.String)reader[((int)SaCodePunishRsnColumn.PunishReasonCode - 1)];
			entity.PunishReasonDescrAr = (System.String)reader[((int)SaCodePunishRsnColumn.PunishReasonDescrAr - 1)];
			entity.PunishReasonDescrEn = (reader.IsDBNull(((int)SaCodePunishRsnColumn.PunishReasonDescrEn - 1)))?null:(System.String)reader[((int)SaCodePunishRsnColumn.PunishReasonDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishRsn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodePunishRsn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodePunishRsn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodePunishRsnId = (System.Decimal)dataRow["SA_CODE_PUNISH_RSN_ID"];
			entity.OriginalSaCodePunishRsnId = (System.Decimal)dataRow["SA_CODE_PUNISH_RSN_ID"];
			entity.PunishReasonCode = Convert.IsDBNull(dataRow["PUNISH_REASON_CODE"]) ? null : (System.String)dataRow["PUNISH_REASON_CODE"];
			entity.PunishReasonDescrAr = (System.String)dataRow["PUNISH_REASON_DESCR_AR"];
			entity.PunishReasonDescrEn = Convert.IsDBNull(dataRow["PUNISH_REASON_DESCR_EN"]) ? null : (System.String)dataRow["PUNISH_REASON_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodePunishRsn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodePunishRsn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodePunishRsn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodePunishRsnId methods when available
			
			#region SaPunishmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPunishment>|SaPunishmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPunishmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPunishmentCollection = DataRepository.SaPunishmentProvider.GetBySaCodePunishRsnId(transactionManager, entity.SaCodePunishRsnId);

				if (deep && entity.SaPunishmentCollection.Count > 0)
				{
					deepHandles.Add("SaPunishmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPunishment>) DataRepository.SaPunishmentProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPunishmentCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodePunishRsn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodePunishRsn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodePunishRsn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodePunishRsn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaPunishment>
				if (CanDeepSave(entity.SaPunishmentCollection, "List<SaPunishment>|SaPunishmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPunishment child in entity.SaPunishmentCollection)
					{
						if(child.SaCodePunishRsnIdSource != null)
						{
							child.SaCodePunishRsnId = child.SaCodePunishRsnIdSource.SaCodePunishRsnId;
						}
						else
						{
							child.SaCodePunishRsnId = entity.SaCodePunishRsnId;
						}

					}

					if (entity.SaPunishmentCollection.Count > 0 || entity.SaPunishmentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPunishmentProvider.Save(transactionManager, entity.SaPunishmentCollection);
						
						deepHandles.Add("SaPunishmentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPunishment >) DataRepository.SaPunishmentProvider.DeepSave,
							new object[] { transactionManager, entity.SaPunishmentCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodePunishRsnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodePunishRsn</c>
	///</summary>
	public enum SaCodePunishRsnChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCodePunishRsn</c> as OneToMany for SaPunishmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPunishment>))]
		SaPunishmentCollection,
	}
	
	#endregion SaCodePunishRsnChildEntityTypes
	
	#region SaCodePunishRsnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodePunishRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodePunishRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodePunishRsnFilterBuilder : SqlFilterBuilder<SaCodePunishRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodePunishRsnFilterBuilder class.
		/// </summary>
		public SaCodePunishRsnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodePunishRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodePunishRsnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodePunishRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodePunishRsnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodePunishRsnFilterBuilder
	
	#region SaCodePunishRsnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodePunishRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodePunishRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodePunishRsnParameterBuilder : ParameterizedSqlFilterBuilder<SaCodePunishRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodePunishRsnParameterBuilder class.
		/// </summary>
		public SaCodePunishRsnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodePunishRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodePunishRsnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodePunishRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodePunishRsnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodePunishRsnParameterBuilder
	
	#region SaCodePunishRsnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodePunishRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodePunishRsn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodePunishRsnSortBuilder : SqlSortBuilder<SaCodePunishRsnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodePunishRsnSqlSortBuilder class.
		/// </summary>
		public SaCodePunishRsnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodePunishRsnSortBuilder
	
} // end namespace
