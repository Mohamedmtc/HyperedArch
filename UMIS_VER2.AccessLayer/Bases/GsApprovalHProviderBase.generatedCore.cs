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
	/// This class is the base class for any <see cref="GsApprovalHProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsApprovalHProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsApprovalH, UMIS_VER2.BusinessLyer.GsApprovalHKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsApprovalHKey key)
		{
			return Delete(transactionManager, key.GsApprovalHId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsApprovalHId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsApprovalHId)
		{
			return Delete(null, _gsApprovalHId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsApprovalHId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000f key.
		///		FK_AUTO_000f Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsApprovalH objects.</returns>
		public TList<GsApprovalH> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000f key.
		///		FK_AUTO_000f Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsApprovalH objects.</returns>
		/// <remarks></remarks>
		public TList<GsApprovalH> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000f key.
		///		FK_AUTO_000f Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsApprovalH objects.</returns>
		public TList<GsApprovalH> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000f key.
		///		fkAuto000f Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsApprovalH objects.</returns>
		public TList<GsApprovalH> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000f key.
		///		fkAuto000f Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsApprovalH objects.</returns>
		public TList<GsApprovalH> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000f key.
		///		FK_AUTO_000f Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsApprovalH objects.</returns>
		public abstract TList<GsApprovalH> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsApprovalH Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsApprovalHKey key, int start, int pageLength)
		{
			return GetByGsApprovalHId(transactionManager, key.GsApprovalHId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_APPROVAL_H index.
		/// </summary>
		/// <param name="_gsApprovalHId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsApprovalH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsApprovalH GetByGsApprovalHId(System.Decimal _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(null,_gsApprovalHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_APPROVAL_H index.
		/// </summary>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsApprovalH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsApprovalH GetByGsApprovalHId(System.Decimal _gsApprovalHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_APPROVAL_H index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsApprovalH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsApprovalH GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_APPROVAL_H index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsApprovalH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsApprovalH GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal _gsApprovalHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_APPROVAL_H index.
		/// </summary>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsApprovalH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsApprovalH GetByGsApprovalHId(System.Decimal _gsApprovalHId, int start, int pageLength, out int count)
		{
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_APPROVAL_H index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsApprovalH"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsApprovalH GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal _gsApprovalHId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsApprovalH&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsApprovalH&gt;"/></returns>
		public static TList<GsApprovalH> Fill(IDataReader reader, TList<GsApprovalH> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsApprovalH c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsApprovalH")
					.Append("|").Append((System.Decimal)reader["GS_APPROVAL_H_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsApprovalH>(
					key.ToString(), // EntityTrackingKey
					"GsApprovalH",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsApprovalH();
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
					c.GsApprovalHId = (System.Decimal)reader["GS_APPROVAL_H_ID"];
					c.OriginalGsApprovalHId = c.GsApprovalHId;
					c.HeaderDescrAr = Convert.IsDBNull(reader["HEADER_DESCR_AR"]) ? null : (System.String)reader["HEADER_DESCR_AR"];
					c.HeaderDescrEn = Convert.IsDBNull(reader["HEADER_DESCR_EN"]) ? null : (System.String)reader["HEADER_DESCR_EN"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsApprovalH"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsApprovalH"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsApprovalH entity)
		{
			if (!reader.Read()) return;
			
			entity.GsApprovalHId = (System.Decimal)reader[((int)GsApprovalHColumn.GsApprovalHId - 1)];
			entity.OriginalGsApprovalHId = (System.Decimal)reader["GS_APPROVAL_H_ID"];
			entity.HeaderDescrAr = (reader.IsDBNull(((int)GsApprovalHColumn.HeaderDescrAr - 1)))?null:(System.String)reader[((int)GsApprovalHColumn.HeaderDescrAr - 1)];
			entity.HeaderDescrEn = (reader.IsDBNull(((int)GsApprovalHColumn.HeaderDescrEn - 1)))?null:(System.String)reader[((int)GsApprovalHColumn.HeaderDescrEn - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)GsApprovalHColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsApprovalH"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsApprovalH"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsApprovalH entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsApprovalHId = (System.Decimal)dataRow["GS_APPROVAL_H_ID"];
			entity.OriginalGsApprovalHId = (System.Decimal)dataRow["GS_APPROVAL_H_ID"];
			entity.HeaderDescrAr = Convert.IsDBNull(dataRow["HEADER_DESCR_AR"]) ? null : (System.String)dataRow["HEADER_DESCR_AR"];
			entity.HeaderDescrEn = Convert.IsDBNull(dataRow["HEADER_DESCR_EN"]) ? null : (System.String)dataRow["HEADER_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsApprovalH"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsApprovalH Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsApprovalH entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsApprovalHId methods when available
			
			#region SaPromotionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPromotion>|SaPromotionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPromotionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPromotionCollection = DataRepository.SaPromotionProvider.GetByGsApprovalHId(transactionManager, entity.GsApprovalHId);

				if (deep && entity.SaPromotionCollection.Count > 0)
				{
					deepHandles.Add("SaPromotionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPromotion>) DataRepository.SaPromotionProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPromotionCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaScResearchCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaScResearch>|SaScResearchCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScResearchCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaScResearchCollection = DataRepository.SaScResearchProvider.GetByGsApprovalHId(transactionManager, entity.GsApprovalHId);

				if (deep && entity.SaScResearchCollection.Count > 0)
				{
					deepHandles.Add("SaScResearchCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaScResearch>) DataRepository.SaScResearchProvider.DeepLoad,
						new object[] { transactionManager, entity.SaScResearchCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaPunishmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPunishment>|SaPunishmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPunishmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPunishmentCollection = DataRepository.SaPunishmentProvider.GetByGsApprovalHId(transactionManager, entity.GsApprovalHId);

				if (deep && entity.SaPunishmentCollection.Count > 0)
				{
					deepHandles.Add("SaPunishmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPunishment>) DataRepository.SaPunishmentProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPunishmentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaVacationCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaVacation>|SaVacationCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaVacationCollection = DataRepository.SaVacationProvider.GetByGsApprovalHId(transactionManager, entity.GsApprovalHId);

				if (deep && entity.SaVacationCollection.Count > 0)
				{
					deepHandles.Add("SaVacationCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaVacation>) DataRepository.SaVacationProvider.DeepLoad,
						new object[] { transactionManager, entity.SaVacationCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaTransferCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaTransfer>|SaTransferCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaTransferCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaTransferCollection = DataRepository.SaTransferProvider.GetByGsApprovalHId(transactionManager, entity.GsApprovalHId);

				if (deep && entity.SaTransferCollection.Count > 0)
				{
					deepHandles.Add("SaTransferCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaTransfer>) DataRepository.SaTransferProvider.DeepLoad,
						new object[] { transactionManager, entity.SaTransferCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaEmploymentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaEmployment>|SaEmploymentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaEmploymentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaEmploymentCollection = DataRepository.SaEmploymentProvider.GetByGsApprovalHId(transactionManager, entity.GsApprovalHId);

				if (deep && entity.SaEmploymentCollection.Count > 0)
				{
					deepHandles.Add("SaEmploymentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaEmployment>) DataRepository.SaEmploymentProvider.DeepLoad,
						new object[] { transactionManager, entity.SaEmploymentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsApprovalDCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsApprovalD>|GsApprovalDCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsApprovalDCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsApprovalDCollection = DataRepository.GsApprovalDProvider.GetByGsApprovalHId(transactionManager, entity.GsApprovalHId);

				if (deep && entity.GsApprovalDCollection.Count > 0)
				{
					deepHandles.Add("GsApprovalDCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsApprovalD>) DataRepository.GsApprovalDProvider.DeepLoad,
						new object[] { transactionManager, entity.GsApprovalDCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaServTerminCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaServTermin>|SaServTerminCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaServTerminCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaServTerminCollection = DataRepository.SaServTerminProvider.GetByGsApprovalHId(transactionManager, entity.GsApprovalHId);

				if (deep && entity.SaServTerminCollection.Count > 0)
				{
					deepHandles.Add("SaServTerminCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaServTermin>) DataRepository.SaServTerminProvider.DeepLoad,
						new object[] { transactionManager, entity.SaServTerminCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaRaiseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaRaise>|SaRaiseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaRaiseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaRaiseCollection = DataRepository.SaRaiseProvider.GetByGsApprovalHId(transactionManager, entity.GsApprovalHId);

				if (deep && entity.SaRaiseCollection.Count > 0)
				{
					deepHandles.Add("SaRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaRaise>) DataRepository.SaRaiseProvider.DeepLoad,
						new object[] { transactionManager, entity.SaRaiseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaVacationRenewCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaVacationRenew>|SaVacationRenewCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationRenewCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaVacationRenewCollection = DataRepository.SaVacationRenewProvider.GetByGsApprovalHId(transactionManager, entity.GsApprovalHId);

				if (deep && entity.SaVacationRenewCollection.Count > 0)
				{
					deepHandles.Add("SaVacationRenewCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaVacationRenew>) DataRepository.SaVacationRenewProvider.DeepLoad,
						new object[] { transactionManager, entity.SaVacationRenewCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsApprovalH object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsApprovalH instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsApprovalH Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsApprovalH entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaPromotion>
				if (CanDeepSave(entity.SaPromotionCollection, "List<SaPromotion>|SaPromotionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPromotion child in entity.SaPromotionCollection)
					{
						if(child.GsApprovalHIdSource != null)
						{
							child.GsApprovalHId = child.GsApprovalHIdSource.GsApprovalHId;
						}
						else
						{
							child.GsApprovalHId = entity.GsApprovalHId;
						}

					}

					if (entity.SaPromotionCollection.Count > 0 || entity.SaPromotionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPromotionProvider.Save(transactionManager, entity.SaPromotionCollection);
						
						deepHandles.Add("SaPromotionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPromotion >) DataRepository.SaPromotionProvider.DeepSave,
							new object[] { transactionManager, entity.SaPromotionCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaScResearch>
				if (CanDeepSave(entity.SaScResearchCollection, "List<SaScResearch>|SaScResearchCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaScResearch child in entity.SaScResearchCollection)
					{
						if(child.GsApprovalHIdSource != null)
						{
							child.GsApprovalHId = child.GsApprovalHIdSource.GsApprovalHId;
						}
						else
						{
							child.GsApprovalHId = entity.GsApprovalHId;
						}

					}

					if (entity.SaScResearchCollection.Count > 0 || entity.SaScResearchCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaScResearchProvider.Save(transactionManager, entity.SaScResearchCollection);
						
						deepHandles.Add("SaScResearchCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaScResearch >) DataRepository.SaScResearchProvider.DeepSave,
							new object[] { transactionManager, entity.SaScResearchCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaPunishment>
				if (CanDeepSave(entity.SaPunishmentCollection, "List<SaPunishment>|SaPunishmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPunishment child in entity.SaPunishmentCollection)
					{
						if(child.GsApprovalHIdSource != null)
						{
							child.GsApprovalHId = child.GsApprovalHIdSource.GsApprovalHId;
						}
						else
						{
							child.GsApprovalHId = entity.GsApprovalHId;
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
				
	
			#region List<SaVacation>
				if (CanDeepSave(entity.SaVacationCollection, "List<SaVacation>|SaVacationCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaVacation child in entity.SaVacationCollection)
					{
						if(child.GsApprovalHIdSource != null)
						{
							child.GsApprovalHId = child.GsApprovalHIdSource.GsApprovalHId;
						}
						else
						{
							child.GsApprovalHId = entity.GsApprovalHId;
						}

					}

					if (entity.SaVacationCollection.Count > 0 || entity.SaVacationCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaVacationProvider.Save(transactionManager, entity.SaVacationCollection);
						
						deepHandles.Add("SaVacationCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaVacation >) DataRepository.SaVacationProvider.DeepSave,
							new object[] { transactionManager, entity.SaVacationCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaTransfer>
				if (CanDeepSave(entity.SaTransferCollection, "List<SaTransfer>|SaTransferCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaTransfer child in entity.SaTransferCollection)
					{
						if(child.GsApprovalHIdSource != null)
						{
							child.GsApprovalHId = child.GsApprovalHIdSource.GsApprovalHId;
						}
						else
						{
							child.GsApprovalHId = entity.GsApprovalHId;
						}

					}

					if (entity.SaTransferCollection.Count > 0 || entity.SaTransferCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaTransferProvider.Save(transactionManager, entity.SaTransferCollection);
						
						deepHandles.Add("SaTransferCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaTransfer >) DataRepository.SaTransferProvider.DeepSave,
							new object[] { transactionManager, entity.SaTransferCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaEmployment>
				if (CanDeepSave(entity.SaEmploymentCollection, "List<SaEmployment>|SaEmploymentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaEmployment child in entity.SaEmploymentCollection)
					{
						if(child.GsApprovalHIdSource != null)
						{
							child.GsApprovalHId = child.GsApprovalHIdSource.GsApprovalHId;
						}
						else
						{
							child.GsApprovalHId = entity.GsApprovalHId;
						}

					}

					if (entity.SaEmploymentCollection.Count > 0 || entity.SaEmploymentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaEmploymentProvider.Save(transactionManager, entity.SaEmploymentCollection);
						
						deepHandles.Add("SaEmploymentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaEmployment >) DataRepository.SaEmploymentProvider.DeepSave,
							new object[] { transactionManager, entity.SaEmploymentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsApprovalD>
				if (CanDeepSave(entity.GsApprovalDCollection, "List<GsApprovalD>|GsApprovalDCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsApprovalD child in entity.GsApprovalDCollection)
					{
						if(child.GsApprovalHIdSource != null)
						{
							child.GsApprovalHId = child.GsApprovalHIdSource.GsApprovalHId;
						}
						else
						{
							child.GsApprovalHId = entity.GsApprovalHId;
						}

					}

					if (entity.GsApprovalDCollection.Count > 0 || entity.GsApprovalDCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsApprovalDProvider.Save(transactionManager, entity.GsApprovalDCollection);
						
						deepHandles.Add("GsApprovalDCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsApprovalD >) DataRepository.GsApprovalDProvider.DeepSave,
							new object[] { transactionManager, entity.GsApprovalDCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaServTermin>
				if (CanDeepSave(entity.SaServTerminCollection, "List<SaServTermin>|SaServTerminCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaServTermin child in entity.SaServTerminCollection)
					{
						if(child.GsApprovalHIdSource != null)
						{
							child.GsApprovalHId = child.GsApprovalHIdSource.GsApprovalHId;
						}
						else
						{
							child.GsApprovalHId = entity.GsApprovalHId;
						}

					}

					if (entity.SaServTerminCollection.Count > 0 || entity.SaServTerminCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaServTerminProvider.Save(transactionManager, entity.SaServTerminCollection);
						
						deepHandles.Add("SaServTerminCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaServTermin >) DataRepository.SaServTerminProvider.DeepSave,
							new object[] { transactionManager, entity.SaServTerminCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaRaise>
				if (CanDeepSave(entity.SaRaiseCollection, "List<SaRaise>|SaRaiseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaRaise child in entity.SaRaiseCollection)
					{
						if(child.GsApprovalHIdSource != null)
						{
							child.GsApprovalHId = child.GsApprovalHIdSource.GsApprovalHId;
						}
						else
						{
							child.GsApprovalHId = entity.GsApprovalHId;
						}

					}

					if (entity.SaRaiseCollection.Count > 0 || entity.SaRaiseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaRaiseProvider.Save(transactionManager, entity.SaRaiseCollection);
						
						deepHandles.Add("SaRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaRaise >) DataRepository.SaRaiseProvider.DeepSave,
							new object[] { transactionManager, entity.SaRaiseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaVacationRenew>
				if (CanDeepSave(entity.SaVacationRenewCollection, "List<SaVacationRenew>|SaVacationRenewCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaVacationRenew child in entity.SaVacationRenewCollection)
					{
						if(child.GsApprovalHIdSource != null)
						{
							child.GsApprovalHId = child.GsApprovalHIdSource.GsApprovalHId;
						}
						else
						{
							child.GsApprovalHId = entity.GsApprovalHId;
						}

					}

					if (entity.SaVacationRenewCollection.Count > 0 || entity.SaVacationRenewCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaVacationRenewProvider.Save(transactionManager, entity.SaVacationRenewCollection);
						
						deepHandles.Add("SaVacationRenewCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaVacationRenew >) DataRepository.SaVacationRenewProvider.DeepSave,
							new object[] { transactionManager, entity.SaVacationRenewCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsApprovalHChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsApprovalH</c>
	///</summary>
	public enum GsApprovalHChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		///<summary>
		/// Collection of <c>GsApprovalH</c> as OneToMany for SaPromotionCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPromotion>))]
		SaPromotionCollection,
		///<summary>
		/// Collection of <c>GsApprovalH</c> as OneToMany for SaScResearchCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaScResearch>))]
		SaScResearchCollection,
		///<summary>
		/// Collection of <c>GsApprovalH</c> as OneToMany for SaPunishmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPunishment>))]
		SaPunishmentCollection,
		///<summary>
		/// Collection of <c>GsApprovalH</c> as OneToMany for SaVacationCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaVacation>))]
		SaVacationCollection,
		///<summary>
		/// Collection of <c>GsApprovalH</c> as OneToMany for SaTransferCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaTransfer>))]
		SaTransferCollection,
		///<summary>
		/// Collection of <c>GsApprovalH</c> as OneToMany for SaEmploymentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaEmployment>))]
		SaEmploymentCollection,
		///<summary>
		/// Collection of <c>GsApprovalH</c> as OneToMany for GsApprovalDCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsApprovalD>))]
		GsApprovalDCollection,
		///<summary>
		/// Collection of <c>GsApprovalH</c> as OneToMany for SaServTerminCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaServTermin>))]
		SaServTerminCollection,
		///<summary>
		/// Collection of <c>GsApprovalH</c> as OneToMany for SaRaiseCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaRaise>))]
		SaRaiseCollection,
		///<summary>
		/// Collection of <c>GsApprovalH</c> as OneToMany for SaVacationRenewCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaVacationRenew>))]
		SaVacationRenewCollection,
	}
	
	#endregion GsApprovalHChildEntityTypes
	
	#region GsApprovalHFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsApprovalHColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsApprovalH"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsApprovalHFilterBuilder : SqlFilterBuilder<GsApprovalHColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsApprovalHFilterBuilder class.
		/// </summary>
		public GsApprovalHFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsApprovalHFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsApprovalHFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsApprovalHFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsApprovalHFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsApprovalHFilterBuilder
	
	#region GsApprovalHParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsApprovalHColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsApprovalH"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsApprovalHParameterBuilder : ParameterizedSqlFilterBuilder<GsApprovalHColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsApprovalHParameterBuilder class.
		/// </summary>
		public GsApprovalHParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsApprovalHParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsApprovalHParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsApprovalHParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsApprovalHParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsApprovalHParameterBuilder
	
	#region GsApprovalHSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsApprovalHColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsApprovalH"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsApprovalHSortBuilder : SqlSortBuilder<GsApprovalHColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsApprovalHSqlSortBuilder class.
		/// </summary>
		public GsApprovalHSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsApprovalHSortBuilder
	
} // end namespace
