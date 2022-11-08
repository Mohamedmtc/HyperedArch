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
	/// This class is the base class for any <see cref="CoExamPaperProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoExamPaperProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CoExamPaper, UMIS_VER2.BusinessLyer.CoExamPaperKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamPaperKey key)
		{
			return Delete(transactionManager, key.CoExamPaperId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_coExamPaperId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _coExamPaperId)
		{
			return Delete(null, _coExamPaperId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamPaperId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _coExamPaperId);		
		
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
		public override UMIS_VER2.BusinessLyer.CoExamPaper Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamPaperKey key, int start, int pageLength)
		{
			return GetByCoExamPaperId(transactionManager, key.CoExamPaperId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExamPaper&gt;"/> class.</returns>
		public TList<CoExamPaper> GetByCoControlId(System.Decimal? _coControlId)
		{
			int count = -1;
			return GetByCoControlId(null,_coControlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExamPaper&gt;"/> class.</returns>
		public TList<CoExamPaper> GetByCoControlId(System.Decimal? _coControlId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlId(null, _coControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExamPaper&gt;"/> class.</returns>
		public TList<CoExamPaper> GetByCoControlId(TransactionManager transactionManager, System.Decimal? _coControlId)
		{
			int count = -1;
			return GetByCoControlId(transactionManager, _coControlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExamPaper&gt;"/> class.</returns>
		public TList<CoExamPaper> GetByCoControlId(TransactionManager transactionManager, System.Decimal? _coControlId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlId(transactionManager, _coControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExamPaper&gt;"/> class.</returns>
		public TList<CoExamPaper> GetByCoControlId(System.Decimal? _coControlId, int start, int pageLength, out int count)
		{
			return GetByCoControlId(null, _coControlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExamPaper&gt;"/> class.</returns>
		public abstract TList<CoExamPaper> GetByCoControlId(TransactionManager transactionManager, System.Decimal? _coControlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CO_EXAM_PAPER index.
		/// </summary>
		/// <param name="_coExamPaperId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamPaper"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamPaper GetByCoExamPaperId(System.Decimal _coExamPaperId)
		{
			int count = -1;
			return GetByCoExamPaperId(null,_coExamPaperId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_PAPER index.
		/// </summary>
		/// <param name="_coExamPaperId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamPaper"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamPaper GetByCoExamPaperId(System.Decimal _coExamPaperId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoExamPaperId(null, _coExamPaperId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_PAPER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamPaperId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamPaper"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamPaper GetByCoExamPaperId(TransactionManager transactionManager, System.Decimal _coExamPaperId)
		{
			int count = -1;
			return GetByCoExamPaperId(transactionManager, _coExamPaperId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_PAPER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamPaperId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamPaper"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamPaper GetByCoExamPaperId(TransactionManager transactionManager, System.Decimal _coExamPaperId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoExamPaperId(transactionManager, _coExamPaperId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_PAPER index.
		/// </summary>
		/// <param name="_coExamPaperId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamPaper"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamPaper GetByCoExamPaperId(System.Decimal _coExamPaperId, int start, int pageLength, out int count)
		{
			return GetByCoExamPaperId(null, _coExamPaperId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_PAPER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamPaperId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamPaper"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoExamPaper GetByCoExamPaperId(TransactionManager transactionManager, System.Decimal _coExamPaperId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoExamPaper&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoExamPaper&gt;"/></returns>
		public static TList<CoExamPaper> Fill(IDataReader reader, TList<CoExamPaper> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CoExamPaper c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoExamPaper")
					.Append("|").Append((System.Decimal)reader["CO_EXAM_PAPER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CoExamPaper>(
					key.ToString(), // EntityTrackingKey
					"CoExamPaper",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CoExamPaper();
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
					c.CoExamPaperId = (System.Decimal)reader["CO_EXAM_PAPER_ID"];
					c.OriginalCoExamPaperId = c.CoExamPaperId;
					c.CoControlId = Convert.IsDBNull(reader["CO_CONTROL_ID"]) ? null : (System.Decimal?)reader["CO_CONTROL_ID"];
					c.QDeliveryFlag = Convert.IsDBNull(reader["Q_DELIVERY_FLAG"]) ? null : (System.Decimal?)reader["Q_DELIVERY_FLAG"];
					c.QPapperNo = Convert.IsDBNull(reader["Q_PAPPER_NO"]) ? null : (System.Decimal?)reader["Q_PAPPER_NO"];
					c.DelivaryDate = Convert.IsDBNull(reader["DELIVARY_DATE"]) ? null : (System.DateTime?)reader["DELIVARY_DATE"];
					c.CoControlDelegMemId = Convert.IsDBNull(reader["CO_CONTROL_DELEG_MEM_ID"]) ? null : (System.Decimal?)reader["CO_CONTROL_DELEG_MEM_ID"];
					c.DelivaryCommittee = Convert.IsDBNull(reader["DELIVARY_COMMITTEE"]) ? null : (System.String)reader["DELIVARY_COMMITTEE"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.AnsSheetDelFlag = Convert.IsDBNull(reader["ANS_SHEET_DEL_FLAG"]) ? null : (System.Decimal?)reader["ANS_SHEET_DEL_FLAG"];
					c.AnsSheetsNo = Convert.IsDBNull(reader["ANS_SHEETS_NO"]) ? null : (System.Decimal?)reader["ANS_SHEETS_NO"];
					c.CoControlMembersId = Convert.IsDBNull(reader["CO_CONTROL_MEMBERS_ID"]) ? null : (System.Decimal?)reader["CO_CONTROL_MEMBERS_ID"];
					c.AnsSheetDeldate = Convert.IsDBNull(reader["ANS_SHEET_DELDATE"]) ? null : (System.DateTime?)reader["ANS_SHEET_DELDATE"];
					c.ADeliveryCommittee = Convert.IsDBNull(reader["A_DELIVERY_COMMITTEE"]) ? null : (System.String)reader["A_DELIVERY_COMMITTEE"];
					c.Note = Convert.IsDBNull(reader["NOTE"]) ? null : (System.String)reader["NOTE"];
					c.CorrectionEndFlag = (System.Decimal)reader["CORRECTION_END_FLAG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoExamPaper"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExamPaper"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CoExamPaper entity)
		{
			if (!reader.Read()) return;
			
			entity.CoExamPaperId = (System.Decimal)reader[((int)CoExamPaperColumn.CoExamPaperId - 1)];
			entity.OriginalCoExamPaperId = (System.Decimal)reader["CO_EXAM_PAPER_ID"];
			entity.CoControlId = (reader.IsDBNull(((int)CoExamPaperColumn.CoControlId - 1)))?null:(System.Decimal?)reader[((int)CoExamPaperColumn.CoControlId - 1)];
			entity.QDeliveryFlag = (reader.IsDBNull(((int)CoExamPaperColumn.QDeliveryFlag - 1)))?null:(System.Decimal?)reader[((int)CoExamPaperColumn.QDeliveryFlag - 1)];
			entity.QPapperNo = (reader.IsDBNull(((int)CoExamPaperColumn.QPapperNo - 1)))?null:(System.Decimal?)reader[((int)CoExamPaperColumn.QPapperNo - 1)];
			entity.DelivaryDate = (reader.IsDBNull(((int)CoExamPaperColumn.DelivaryDate - 1)))?null:(System.DateTime?)reader[((int)CoExamPaperColumn.DelivaryDate - 1)];
			entity.CoControlDelegMemId = (reader.IsDBNull(((int)CoExamPaperColumn.CoControlDelegMemId - 1)))?null:(System.Decimal?)reader[((int)CoExamPaperColumn.CoControlDelegMemId - 1)];
			entity.DelivaryCommittee = (reader.IsDBNull(((int)CoExamPaperColumn.DelivaryCommittee - 1)))?null:(System.String)reader[((int)CoExamPaperColumn.DelivaryCommittee - 1)];
			entity.Notes = (reader.IsDBNull(((int)CoExamPaperColumn.Notes - 1)))?null:(System.String)reader[((int)CoExamPaperColumn.Notes - 1)];
			entity.AnsSheetDelFlag = (reader.IsDBNull(((int)CoExamPaperColumn.AnsSheetDelFlag - 1)))?null:(System.Decimal?)reader[((int)CoExamPaperColumn.AnsSheetDelFlag - 1)];
			entity.AnsSheetsNo = (reader.IsDBNull(((int)CoExamPaperColumn.AnsSheetsNo - 1)))?null:(System.Decimal?)reader[((int)CoExamPaperColumn.AnsSheetsNo - 1)];
			entity.CoControlMembersId = (reader.IsDBNull(((int)CoExamPaperColumn.CoControlMembersId - 1)))?null:(System.Decimal?)reader[((int)CoExamPaperColumn.CoControlMembersId - 1)];
			entity.AnsSheetDeldate = (reader.IsDBNull(((int)CoExamPaperColumn.AnsSheetDeldate - 1)))?null:(System.DateTime?)reader[((int)CoExamPaperColumn.AnsSheetDeldate - 1)];
			entity.ADeliveryCommittee = (reader.IsDBNull(((int)CoExamPaperColumn.ADeliveryCommittee - 1)))?null:(System.String)reader[((int)CoExamPaperColumn.ADeliveryCommittee - 1)];
			entity.Note = (reader.IsDBNull(((int)CoExamPaperColumn.Note - 1)))?null:(System.String)reader[((int)CoExamPaperColumn.Note - 1)];
			entity.CorrectionEndFlag = (System.Decimal)reader[((int)CoExamPaperColumn.CorrectionEndFlag - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoExamPaper"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExamPaper"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CoExamPaper entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CoExamPaperId = (System.Decimal)dataRow["CO_EXAM_PAPER_ID"];
			entity.OriginalCoExamPaperId = (System.Decimal)dataRow["CO_EXAM_PAPER_ID"];
			entity.CoControlId = Convert.IsDBNull(dataRow["CO_CONTROL_ID"]) ? null : (System.Decimal?)dataRow["CO_CONTROL_ID"];
			entity.QDeliveryFlag = Convert.IsDBNull(dataRow["Q_DELIVERY_FLAG"]) ? null : (System.Decimal?)dataRow["Q_DELIVERY_FLAG"];
			entity.QPapperNo = Convert.IsDBNull(dataRow["Q_PAPPER_NO"]) ? null : (System.Decimal?)dataRow["Q_PAPPER_NO"];
			entity.DelivaryDate = Convert.IsDBNull(dataRow["DELIVARY_DATE"]) ? null : (System.DateTime?)dataRow["DELIVARY_DATE"];
			entity.CoControlDelegMemId = Convert.IsDBNull(dataRow["CO_CONTROL_DELEG_MEM_ID"]) ? null : (System.Decimal?)dataRow["CO_CONTROL_DELEG_MEM_ID"];
			entity.DelivaryCommittee = Convert.IsDBNull(dataRow["DELIVARY_COMMITTEE"]) ? null : (System.String)dataRow["DELIVARY_COMMITTEE"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.AnsSheetDelFlag = Convert.IsDBNull(dataRow["ANS_SHEET_DEL_FLAG"]) ? null : (System.Decimal?)dataRow["ANS_SHEET_DEL_FLAG"];
			entity.AnsSheetsNo = Convert.IsDBNull(dataRow["ANS_SHEETS_NO"]) ? null : (System.Decimal?)dataRow["ANS_SHEETS_NO"];
			entity.CoControlMembersId = Convert.IsDBNull(dataRow["CO_CONTROL_MEMBERS_ID"]) ? null : (System.Decimal?)dataRow["CO_CONTROL_MEMBERS_ID"];
			entity.AnsSheetDeldate = Convert.IsDBNull(dataRow["ANS_SHEET_DELDATE"]) ? null : (System.DateTime?)dataRow["ANS_SHEET_DELDATE"];
			entity.ADeliveryCommittee = Convert.IsDBNull(dataRow["A_DELIVERY_COMMITTEE"]) ? null : (System.String)dataRow["A_DELIVERY_COMMITTEE"];
			entity.Note = Convert.IsDBNull(dataRow["NOTE"]) ? null : (System.String)dataRow["NOTE"];
			entity.CorrectionEndFlag = (System.Decimal)dataRow["CORRECTION_END_FLAG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExamPaper"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoExamPaper Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamPaper entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region CoControlIdSource	
			if (CanDeepLoad(entity, "CoControl|CoControlIdSource", deepLoadType, innerList) 
				&& entity.CoControlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.CoControlId ?? 0.0m);
				CoControl tmpEntity = EntityManager.LocateEntity<CoControl>(EntityLocator.ConstructKeyFromPkItems(typeof(CoControl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CoControlIdSource = tmpEntity;
				else
					entity.CoControlIdSource = DataRepository.CoControlProvider.GetByCoControlId(transactionManager, (entity.CoControlId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CoControlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CoControlProvider.DeepLoad(transactionManager, entity.CoControlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CoControlIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CoExamPaper object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CoExamPaper instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoExamPaper Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamPaper entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region CoControlIdSource
			if (CanDeepSave(entity, "CoControl|CoControlIdSource", deepSaveType, innerList) 
				&& entity.CoControlIdSource != null)
			{
				DataRepository.CoControlProvider.Save(transactionManager, entity.CoControlIdSource);
				entity.CoControlId = entity.CoControlIdSource.CoControlId;
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
	
	#region CoExamPaperChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CoExamPaper</c>
	///</summary>
	public enum CoExamPaperChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CoControl</c> at CoControlIdSource
		///</summary>
		[ChildEntityType(typeof(CoControl))]
		CoControl,
	}
	
	#endregion CoExamPaperChildEntityTypes
	
	#region CoExamPaperFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoExamPaperColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExamPaper"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoExamPaperFilterBuilder : SqlFilterBuilder<CoExamPaperColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExamPaperFilterBuilder class.
		/// </summary>
		public CoExamPaperFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoExamPaperFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoExamPaperFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoExamPaperFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoExamPaperFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoExamPaperFilterBuilder
	
	#region CoExamPaperParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoExamPaperColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExamPaper"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoExamPaperParameterBuilder : ParameterizedSqlFilterBuilder<CoExamPaperColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExamPaperParameterBuilder class.
		/// </summary>
		public CoExamPaperParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoExamPaperParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoExamPaperParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoExamPaperParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoExamPaperParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoExamPaperParameterBuilder
	
	#region CoExamPaperSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoExamPaperColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExamPaper"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoExamPaperSortBuilder : SqlSortBuilder<CoExamPaperColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExamPaperSqlSortBuilder class.
		/// </summary>
		public CoExamPaperSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoExamPaperSortBuilder
	
} // end namespace
