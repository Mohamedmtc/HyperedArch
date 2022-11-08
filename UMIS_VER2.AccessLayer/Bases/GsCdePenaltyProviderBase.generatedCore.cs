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
	/// This class is the base class for any <see cref="GsCdePenaltyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdePenaltyProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdePenalty, UMIS_VER2.BusinessLyer.GsCdePenaltyKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdePenaltyKey key)
		{
			return Delete(transactionManager, key.GsCdePenaltyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdePenaltyId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdePenaltyId)
		{
			return Delete(null, _gsCdePenaltyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdePenaltyId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCdePenalty Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdePenaltyKey key, int start, int pageLength)
		{
			return GetByGsCdePenaltyId(transactionManager, key.GsCdePenaltyId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_PENALTY index.
		/// </summary>
		/// <param name="_gsCdePenaltyId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdePenalty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdePenalty GetByGsCdePenaltyId(System.Decimal _gsCdePenaltyId)
		{
			int count = -1;
			return GetByGsCdePenaltyId(null,_gsCdePenaltyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_PENALTY index.
		/// </summary>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdePenalty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdePenalty GetByGsCdePenaltyId(System.Decimal _gsCdePenaltyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdePenaltyId(null, _gsCdePenaltyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_PENALTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdePenalty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdePenalty GetByGsCdePenaltyId(TransactionManager transactionManager, System.Decimal _gsCdePenaltyId)
		{
			int count = -1;
			return GetByGsCdePenaltyId(transactionManager, _gsCdePenaltyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_PENALTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdePenalty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdePenalty GetByGsCdePenaltyId(TransactionManager transactionManager, System.Decimal _gsCdePenaltyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdePenaltyId(transactionManager, _gsCdePenaltyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_PENALTY index.
		/// </summary>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdePenalty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdePenalty GetByGsCdePenaltyId(System.Decimal _gsCdePenaltyId, int start, int pageLength, out int count)
		{
			return GetByGsCdePenaltyId(null, _gsCdePenaltyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_PENALTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdePenalty"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdePenalty GetByGsCdePenaltyId(TransactionManager transactionManager, System.Decimal _gsCdePenaltyId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdePenalty&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdePenalty&gt;"/></returns>
		public static TList<GsCdePenalty> Fill(IDataReader reader, TList<GsCdePenalty> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdePenalty c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdePenalty")
					.Append("|").Append((System.Decimal)reader["GS_CDE_PENALTY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdePenalty>(
					key.ToString(), // EntityTrackingKey
					"GsCdePenalty",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdePenalty();
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
					c.GsCdePenaltyId = (System.Decimal)reader["GS_CDE_PENALTY_ID"];
					c.OriginalGsCdePenaltyId = c.GsCdePenaltyId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.AppealPeriodDys = Convert.IsDBNull(reader["APPEAL_PERIOD_DYS"]) ? null : (System.Decimal?)reader["APPEAL_PERIOD_DYS"];
					c.DropPeriodMnth = Convert.IsDBNull(reader["DROP_PERIOD_MNTH"]) ? null : (System.Decimal?)reader["DROP_PERIOD_MNTH"];
					c.CheatingFlg = Convert.IsDBNull(reader["CHEATING_FLG"]) ? null : (System.Decimal?)reader["CHEATING_FLG"];
					c.FacDeanPrivFlg = Convert.IsDBNull(reader["FAC_DEAN_PRIV_FLG"]) ? null : (System.Decimal?)reader["FAC_DEAN_PRIV_FLG"];
					c.FacPunishCommPrivFlg = Convert.IsDBNull(reader["FAC_PUNISH_COMM_PRIV_FLG"]) ? null : (System.Decimal?)reader["FAC_PUNISH_COMM_PRIV_FLG"];
					c.FacStaffPrivFlg = Convert.IsDBNull(reader["FAC_STAFF_PRIV_FLG"]) ? null : (System.Decimal?)reader["FAC_STAFF_PRIV_FLG"];
					c.FacStudDeanPrivFlg = Convert.IsDBNull(reader["FAC_STUD_DEAN_PRIV_FLG"]) ? null : (System.Decimal?)reader["FAC_STUD_DEAN_PRIV_FLG"];
					c.PenaltyRelatedFlg = Convert.IsDBNull(reader["PENALTY_RELATED_FLG"]) ? null : (System.Decimal?)reader["PENALTY_RELATED_FLG"];
					c.PnltyPeriodFlg = Convert.IsDBNull(reader["PNLTY_PERIOD_FLG"]) ? null : (System.Boolean?)reader["PNLTY_PERIOD_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdePenalty"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdePenalty"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdePenalty entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdePenaltyId = (System.Decimal)reader[((int)GsCdePenaltyColumn.GsCdePenaltyId - 1)];
			entity.OriginalGsCdePenaltyId = (System.Decimal)reader["GS_CDE_PENALTY_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCdePenaltyColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)GsCdePenaltyColumn.DescrEn - 1)];
			entity.AppealPeriodDys = (reader.IsDBNull(((int)GsCdePenaltyColumn.AppealPeriodDys - 1)))?null:(System.Decimal?)reader[((int)GsCdePenaltyColumn.AppealPeriodDys - 1)];
			entity.DropPeriodMnth = (reader.IsDBNull(((int)GsCdePenaltyColumn.DropPeriodMnth - 1)))?null:(System.Decimal?)reader[((int)GsCdePenaltyColumn.DropPeriodMnth - 1)];
			entity.CheatingFlg = (reader.IsDBNull(((int)GsCdePenaltyColumn.CheatingFlg - 1)))?null:(System.Decimal?)reader[((int)GsCdePenaltyColumn.CheatingFlg - 1)];
			entity.FacDeanPrivFlg = (reader.IsDBNull(((int)GsCdePenaltyColumn.FacDeanPrivFlg - 1)))?null:(System.Decimal?)reader[((int)GsCdePenaltyColumn.FacDeanPrivFlg - 1)];
			entity.FacPunishCommPrivFlg = (reader.IsDBNull(((int)GsCdePenaltyColumn.FacPunishCommPrivFlg - 1)))?null:(System.Decimal?)reader[((int)GsCdePenaltyColumn.FacPunishCommPrivFlg - 1)];
			entity.FacStaffPrivFlg = (reader.IsDBNull(((int)GsCdePenaltyColumn.FacStaffPrivFlg - 1)))?null:(System.Decimal?)reader[((int)GsCdePenaltyColumn.FacStaffPrivFlg - 1)];
			entity.FacStudDeanPrivFlg = (reader.IsDBNull(((int)GsCdePenaltyColumn.FacStudDeanPrivFlg - 1)))?null:(System.Decimal?)reader[((int)GsCdePenaltyColumn.FacStudDeanPrivFlg - 1)];
			entity.PenaltyRelatedFlg = (reader.IsDBNull(((int)GsCdePenaltyColumn.PenaltyRelatedFlg - 1)))?null:(System.Decimal?)reader[((int)GsCdePenaltyColumn.PenaltyRelatedFlg - 1)];
			entity.PnltyPeriodFlg = (reader.IsDBNull(((int)GsCdePenaltyColumn.PnltyPeriodFlg - 1)))?null:(System.Boolean?)reader[((int)GsCdePenaltyColumn.PnltyPeriodFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdePenalty"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdePenalty"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdePenalty entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdePenaltyId = (System.Decimal)dataRow["GS_CDE_PENALTY_ID"];
			entity.OriginalGsCdePenaltyId = (System.Decimal)dataRow["GS_CDE_PENALTY_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.AppealPeriodDys = Convert.IsDBNull(dataRow["APPEAL_PERIOD_DYS"]) ? null : (System.Decimal?)dataRow["APPEAL_PERIOD_DYS"];
			entity.DropPeriodMnth = Convert.IsDBNull(dataRow["DROP_PERIOD_MNTH"]) ? null : (System.Decimal?)dataRow["DROP_PERIOD_MNTH"];
			entity.CheatingFlg = Convert.IsDBNull(dataRow["CHEATING_FLG"]) ? null : (System.Decimal?)dataRow["CHEATING_FLG"];
			entity.FacDeanPrivFlg = Convert.IsDBNull(dataRow["FAC_DEAN_PRIV_FLG"]) ? null : (System.Decimal?)dataRow["FAC_DEAN_PRIV_FLG"];
			entity.FacPunishCommPrivFlg = Convert.IsDBNull(dataRow["FAC_PUNISH_COMM_PRIV_FLG"]) ? null : (System.Decimal?)dataRow["FAC_PUNISH_COMM_PRIV_FLG"];
			entity.FacStaffPrivFlg = Convert.IsDBNull(dataRow["FAC_STAFF_PRIV_FLG"]) ? null : (System.Decimal?)dataRow["FAC_STAFF_PRIV_FLG"];
			entity.FacStudDeanPrivFlg = Convert.IsDBNull(dataRow["FAC_STUD_DEAN_PRIV_FLG"]) ? null : (System.Decimal?)dataRow["FAC_STUD_DEAN_PRIV_FLG"];
			entity.PenaltyRelatedFlg = Convert.IsDBNull(dataRow["PENALTY_RELATED_FLG"]) ? null : (System.Decimal?)dataRow["PENALTY_RELATED_FLG"];
			entity.PnltyPeriodFlg = Convert.IsDBNull(dataRow["PNLTY_PERIOD_FLG"]) ? null : (System.Boolean?)dataRow["PNLTY_PERIOD_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdePenalty"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdePenalty Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdePenalty entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdePenaltyId methods when available
			
			#region EdStudViolCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudViol>|EdStudViolCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudViolCollection = DataRepository.EdStudViolProvider.GetByGsCdePenaltyId(transactionManager, entity.GsCdePenaltyId);

				if (deep && entity.EdStudViolCollection.Count > 0)
				{
					deepHandles.Add("EdStudViolCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudViol>) DataRepository.EdStudViolProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudViolCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCdeApprovalPnltyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCdeApprovalPnlty>|GsCdeApprovalPnltyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeApprovalPnltyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCdeApprovalPnltyCollection = DataRepository.GsCdeApprovalPnltyProvider.GetByGsCdePenaltyId(transactionManager, entity.GsCdePenaltyId);

				if (deep && entity.GsCdeApprovalPnltyCollection.Count > 0)
				{
					deepHandles.Add("GsCdeApprovalPnltyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCdeApprovalPnlty>) DataRepository.GsCdeApprovalPnltyProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCdeApprovalPnltyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudViolAppealCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudViolAppeal>|EdStudViolAppealCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolAppealCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudViolAppealCollection = DataRepository.EdStudViolAppealProvider.GetByGsCdePenaltyId(transactionManager, entity.GsCdePenaltyId);

				if (deep && entity.EdStudViolAppealCollection.Count > 0)
				{
					deepHandles.Add("EdStudViolAppealCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudViolAppeal>) DataRepository.EdStudViolAppealProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudViolAppealCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdePenalty object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdePenalty instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdePenalty Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdePenalty entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudViol>
				if (CanDeepSave(entity.EdStudViolCollection, "List<EdStudViol>|EdStudViolCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudViol child in entity.EdStudViolCollection)
					{
						if(child.GsCdePenaltyIdSource != null)
						{
							child.GsCdePenaltyId = child.GsCdePenaltyIdSource.GsCdePenaltyId;
						}
						else
						{
							child.GsCdePenaltyId = entity.GsCdePenaltyId;
						}

					}

					if (entity.EdStudViolCollection.Count > 0 || entity.EdStudViolCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolCollection);
						
						deepHandles.Add("EdStudViolCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudViol >) DataRepository.EdStudViolProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudViolCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCdeApprovalPnlty>
				if (CanDeepSave(entity.GsCdeApprovalPnltyCollection, "List<GsCdeApprovalPnlty>|GsCdeApprovalPnltyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCdeApprovalPnlty child in entity.GsCdeApprovalPnltyCollection)
					{
						if(child.GsCdePenaltyIdSource != null)
						{
							child.GsCdePenaltyId = child.GsCdePenaltyIdSource.GsCdePenaltyId;
						}
						else
						{
							child.GsCdePenaltyId = entity.GsCdePenaltyId;
						}

					}

					if (entity.GsCdeApprovalPnltyCollection.Count > 0 || entity.GsCdeApprovalPnltyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCdeApprovalPnltyProvider.Save(transactionManager, entity.GsCdeApprovalPnltyCollection);
						
						deepHandles.Add("GsCdeApprovalPnltyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCdeApprovalPnlty >) DataRepository.GsCdeApprovalPnltyProvider.DeepSave,
							new object[] { transactionManager, entity.GsCdeApprovalPnltyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudViolAppeal>
				if (CanDeepSave(entity.EdStudViolAppealCollection, "List<EdStudViolAppeal>|EdStudViolAppealCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudViolAppeal child in entity.EdStudViolAppealCollection)
					{
						if(child.GsCdePenaltyIdSource != null)
						{
							child.GsCdePenaltyId = child.GsCdePenaltyIdSource.GsCdePenaltyId;
						}
						else
						{
							child.GsCdePenaltyId = entity.GsCdePenaltyId;
						}

					}

					if (entity.EdStudViolAppealCollection.Count > 0 || entity.EdStudViolAppealCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudViolAppealProvider.Save(transactionManager, entity.EdStudViolAppealCollection);
						
						deepHandles.Add("EdStudViolAppealCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudViolAppeal >) DataRepository.EdStudViolAppealProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudViolAppealCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCdePenaltyChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdePenalty</c>
	///</summary>
	public enum GsCdePenaltyChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCdePenalty</c> as OneToMany for EdStudViolCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudViol>))]
		EdStudViolCollection,
		///<summary>
		/// Collection of <c>GsCdePenalty</c> as OneToMany for GsCdeApprovalPnltyCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCdeApprovalPnlty>))]
		GsCdeApprovalPnltyCollection,
		///<summary>
		/// Collection of <c>GsCdePenalty</c> as OneToMany for EdStudViolAppealCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudViolAppeal>))]
		EdStudViolAppealCollection,
	}
	
	#endregion GsCdePenaltyChildEntityTypes
	
	#region GsCdePenaltyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdePenaltyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdePenalty"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdePenaltyFilterBuilder : SqlFilterBuilder<GsCdePenaltyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdePenaltyFilterBuilder class.
		/// </summary>
		public GsCdePenaltyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdePenaltyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdePenaltyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdePenaltyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdePenaltyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdePenaltyFilterBuilder
	
	#region GsCdePenaltyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdePenaltyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdePenalty"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdePenaltyParameterBuilder : ParameterizedSqlFilterBuilder<GsCdePenaltyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdePenaltyParameterBuilder class.
		/// </summary>
		public GsCdePenaltyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdePenaltyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdePenaltyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdePenaltyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdePenaltyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdePenaltyParameterBuilder
	
	#region GsCdePenaltySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdePenaltyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdePenalty"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdePenaltySortBuilder : SqlSortBuilder<GsCdePenaltyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdePenaltySqlSortBuilder class.
		/// </summary>
		public GsCdePenaltySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdePenaltySortBuilder
	
} // end namespace
