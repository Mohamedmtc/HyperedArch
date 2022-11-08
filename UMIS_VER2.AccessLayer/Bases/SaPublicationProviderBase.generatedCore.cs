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
	/// This class is the base class for any <see cref="SaPublicationProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaPublicationProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaPublication, UMIS_VER2.BusinessLyer.SaPublicationKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPublicationKey key)
		{
			return Delete(transactionManager, key.SaPublicationId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saPublicationId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saPublicationId)
		{
			return Delete(null, _saPublicationId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPublicationId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saPublicationId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0023 key.
		///		FK_AUTO_0023 Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPublication objects.</returns>
		public TList<SaPublication> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0023 key.
		///		FK_AUTO_0023 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPublication objects.</returns>
		/// <remarks></remarks>
		public TList<SaPublication> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0023 key.
		///		FK_AUTO_0023 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPublication objects.</returns>
		public TList<SaPublication> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0023 key.
		///		fkAuto0023 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPublication objects.</returns>
		public TList<SaPublication> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0023 key.
		///		fkAuto0023 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPublication objects.</returns>
		public TList<SaPublication> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0023 key.
		///		FK_AUTO_0023 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPublication objects.</returns>
		public abstract TList<SaPublication> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUBLICATION_SA_SC_RESEARCH key.
		///		FK_SA_PUBLICATION_SA_SC_RESEARCH Description: 
		/// </summary>
		/// <param name="_saScResearchId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPublication objects.</returns>
		public TList<SaPublication> GetBySaScResearchId(System.Decimal _saScResearchId)
		{
			int count = -1;
			return GetBySaScResearchId(_saScResearchId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUBLICATION_SA_SC_RESEARCH key.
		///		FK_SA_PUBLICATION_SA_SC_RESEARCH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScResearchId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPublication objects.</returns>
		/// <remarks></remarks>
		public TList<SaPublication> GetBySaScResearchId(TransactionManager transactionManager, System.Decimal _saScResearchId)
		{
			int count = -1;
			return GetBySaScResearchId(transactionManager, _saScResearchId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUBLICATION_SA_SC_RESEARCH key.
		///		FK_SA_PUBLICATION_SA_SC_RESEARCH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScResearchId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPublication objects.</returns>
		public TList<SaPublication> GetBySaScResearchId(TransactionManager transactionManager, System.Decimal _saScResearchId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaScResearchId(transactionManager, _saScResearchId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUBLICATION_SA_SC_RESEARCH key.
		///		fkSaPublicationSaScResearch Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saScResearchId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPublication objects.</returns>
		public TList<SaPublication> GetBySaScResearchId(System.Decimal _saScResearchId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaScResearchId(null, _saScResearchId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUBLICATION_SA_SC_RESEARCH key.
		///		fkSaPublicationSaScResearch Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saScResearchId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPublication objects.</returns>
		public TList<SaPublication> GetBySaScResearchId(System.Decimal _saScResearchId, int start, int pageLength,out int count)
		{
			return GetBySaScResearchId(null, _saScResearchId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUBLICATION_SA_SC_RESEARCH key.
		///		FK_SA_PUBLICATION_SA_SC_RESEARCH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScResearchId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPublication objects.</returns>
		public abstract TList<SaPublication> GetBySaScResearchId(TransactionManager transactionManager, System.Decimal _saScResearchId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaPublication Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPublicationKey key, int start, int pageLength)
		{
			return GetBySaPublicationId(transactionManager, key.SaPublicationId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_PUBLICATION index.
		/// </summary>
		/// <param name="_saPublicationId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPublication"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPublication GetBySaPublicationId(System.Decimal _saPublicationId)
		{
			int count = -1;
			return GetBySaPublicationId(null,_saPublicationId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUBLICATION index.
		/// </summary>
		/// <param name="_saPublicationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPublication"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPublication GetBySaPublicationId(System.Decimal _saPublicationId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPublicationId(null, _saPublicationId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUBLICATION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPublicationId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPublication"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPublication GetBySaPublicationId(TransactionManager transactionManager, System.Decimal _saPublicationId)
		{
			int count = -1;
			return GetBySaPublicationId(transactionManager, _saPublicationId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUBLICATION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPublicationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPublication"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPublication GetBySaPublicationId(TransactionManager transactionManager, System.Decimal _saPublicationId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPublicationId(transactionManager, _saPublicationId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUBLICATION index.
		/// </summary>
		/// <param name="_saPublicationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPublication"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPublication GetBySaPublicationId(System.Decimal _saPublicationId, int start, int pageLength, out int count)
		{
			return GetBySaPublicationId(null, _saPublicationId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUBLICATION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPublicationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPublication"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaPublication GetBySaPublicationId(TransactionManager transactionManager, System.Decimal _saPublicationId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaPublication&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaPublication&gt;"/></returns>
		public static TList<SaPublication> Fill(IDataReader reader, TList<SaPublication> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaPublication c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaPublication")
					.Append("|").Append((System.Decimal)reader["SA_PUBLICATION_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaPublication>(
					key.ToString(), // EntityTrackingKey
					"SaPublication",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaPublication();
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
					c.SaPublicationId = (System.Decimal)reader["SA_PUBLICATION_ID"];
					c.OriginalSaPublicationId = c.SaPublicationId;
					c.PubDate = (System.DateTime)reader["PUB_DATE"];
					c.PubOrg = (System.String)reader["PUB_ORG"];
					c.SaScResearchId = (System.Decimal)reader["SA_SC_RESEARCH_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaPublication"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPublication"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaPublication entity)
		{
			if (!reader.Read()) return;
			
			entity.SaPublicationId = (System.Decimal)reader[((int)SaPublicationColumn.SaPublicationId - 1)];
			entity.OriginalSaPublicationId = (System.Decimal)reader["SA_PUBLICATION_ID"];
			entity.PubDate = (System.DateTime)reader[((int)SaPublicationColumn.PubDate - 1)];
			entity.PubOrg = (System.String)reader[((int)SaPublicationColumn.PubOrg - 1)];
			entity.SaScResearchId = (System.Decimal)reader[((int)SaPublicationColumn.SaScResearchId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaPublicationColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaPublication"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPublication"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaPublication entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaPublicationId = (System.Decimal)dataRow["SA_PUBLICATION_ID"];
			entity.OriginalSaPublicationId = (System.Decimal)dataRow["SA_PUBLICATION_ID"];
			entity.PubDate = (System.DateTime)dataRow["PUB_DATE"];
			entity.PubOrg = (System.String)dataRow["PUB_ORG"];
			entity.SaScResearchId = (System.Decimal)dataRow["SA_SC_RESEARCH_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPublication"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaPublication Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPublication entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource

			#region SaScResearchIdSource	
			if (CanDeepLoad(entity, "SaScResearch|SaScResearchIdSource", deepLoadType, innerList) 
				&& entity.SaScResearchIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaScResearchId;
				SaScResearch tmpEntity = EntityManager.LocateEntity<SaScResearch>(EntityLocator.ConstructKeyFromPkItems(typeof(SaScResearch), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaScResearchIdSource = tmpEntity;
				else
					entity.SaScResearchIdSource = DataRepository.SaScResearchProvider.GetBySaScResearchId(transactionManager, entity.SaScResearchId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScResearchIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaScResearchIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaScResearchProvider.DeepLoad(transactionManager, entity.SaScResearchIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaScResearchIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaPublication object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaPublication instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaPublication Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPublication entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region SaScResearchIdSource
			if (CanDeepSave(entity, "SaScResearch|SaScResearchIdSource", deepSaveType, innerList) 
				&& entity.SaScResearchIdSource != null)
			{
				DataRepository.SaScResearchProvider.Save(transactionManager, entity.SaScResearchIdSource);
				entity.SaScResearchId = entity.SaScResearchIdSource.SaScResearchId;
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
	
	#region SaPublicationChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaPublication</c>
	///</summary>
	public enum SaPublicationChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>SaScResearch</c> at SaScResearchIdSource
		///</summary>
		[ChildEntityType(typeof(SaScResearch))]
		SaScResearch,
	}
	
	#endregion SaPublicationChildEntityTypes
	
	#region SaPublicationFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaPublicationColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPublication"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaPublicationFilterBuilder : SqlFilterBuilder<SaPublicationColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPublicationFilterBuilder class.
		/// </summary>
		public SaPublicationFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaPublicationFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaPublicationFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaPublicationFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaPublicationFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaPublicationFilterBuilder
	
	#region SaPublicationParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaPublicationColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPublication"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaPublicationParameterBuilder : ParameterizedSqlFilterBuilder<SaPublicationColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPublicationParameterBuilder class.
		/// </summary>
		public SaPublicationParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaPublicationParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaPublicationParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaPublicationParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaPublicationParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaPublicationParameterBuilder
	
	#region SaPublicationSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaPublicationColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPublication"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaPublicationSortBuilder : SqlSortBuilder<SaPublicationColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPublicationSqlSortBuilder class.
		/// </summary>
		public SaPublicationSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaPublicationSortBuilder
	
} // end namespace
