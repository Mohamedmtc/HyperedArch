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
	/// This class is the base class for any <see cref="CoScheduleDetailProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoScheduleDetailProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CoScheduleDetail, UMIS_VER2.BusinessLyer.CoScheduleDetailKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoScheduleDetailKey key)
		{
			return Delete(transactionManager, key.CoScheduleDetailId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_coScheduleDetailId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _coScheduleDetailId)
		{
			return Delete(null, _coScheduleDetailId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coScheduleDetailId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _coScheduleDetailId);		
		
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
		public override UMIS_VER2.BusinessLyer.CoScheduleDetail Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoScheduleDetailKey key, int start, int pageLength)
		{
			return GetByCoScheduleDetailId(transactionManager, key.CoScheduleDetailId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoScheduleDetail&gt;"/> class.</returns>
		public TList<CoScheduleDetail> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoScheduleDetail&gt;"/> class.</returns>
		public TList<CoScheduleDetail> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoScheduleDetail&gt;"/> class.</returns>
		public TList<CoScheduleDetail> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoScheduleDetail&gt;"/> class.</returns>
		public TList<CoScheduleDetail> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoScheduleDetail&gt;"/> class.</returns>
		public TList<CoScheduleDetail> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoScheduleDetail&gt;"/> class.</returns>
		public abstract TList<CoScheduleDetail> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CO_SCHEDULE_DETAIL index.
		/// </summary>
		/// <param name="_coScheduleDetailId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoScheduleDetail"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoScheduleDetail GetByCoScheduleDetailId(System.Decimal _coScheduleDetailId)
		{
			int count = -1;
			return GetByCoScheduleDetailId(null,_coScheduleDetailId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_SCHEDULE_DETAIL index.
		/// </summary>
		/// <param name="_coScheduleDetailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoScheduleDetail"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoScheduleDetail GetByCoScheduleDetailId(System.Decimal _coScheduleDetailId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoScheduleDetailId(null, _coScheduleDetailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_SCHEDULE_DETAIL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coScheduleDetailId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoScheduleDetail"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoScheduleDetail GetByCoScheduleDetailId(TransactionManager transactionManager, System.Decimal _coScheduleDetailId)
		{
			int count = -1;
			return GetByCoScheduleDetailId(transactionManager, _coScheduleDetailId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_SCHEDULE_DETAIL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coScheduleDetailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoScheduleDetail"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoScheduleDetail GetByCoScheduleDetailId(TransactionManager transactionManager, System.Decimal _coScheduleDetailId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoScheduleDetailId(transactionManager, _coScheduleDetailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_SCHEDULE_DETAIL index.
		/// </summary>
		/// <param name="_coScheduleDetailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoScheduleDetail"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoScheduleDetail GetByCoScheduleDetailId(System.Decimal _coScheduleDetailId, int start, int pageLength, out int count)
		{
			return GetByCoScheduleDetailId(null, _coScheduleDetailId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_SCHEDULE_DETAIL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coScheduleDetailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoScheduleDetail"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoScheduleDetail GetByCoScheduleDetailId(TransactionManager transactionManager, System.Decimal _coScheduleDetailId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoScheduleDetail&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoScheduleDetail&gt;"/></returns>
		public static TList<CoScheduleDetail> Fill(IDataReader reader, TList<CoScheduleDetail> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CoScheduleDetail c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoScheduleDetail")
					.Append("|").Append((System.Decimal)reader["CO_SCHEDULE_DETAIL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CoScheduleDetail>(
					key.ToString(), // EntityTrackingKey
					"CoScheduleDetail",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CoScheduleDetail();
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
					c.CoScheduleDetailId = (System.Decimal)reader["CO_SCHEDULE_DETAIL_ID"];
					c.OriginalCoScheduleDetailId = c.CoScheduleDetailId;
					c.CoExamScheduleId = (System.Decimal)reader["CO_EXAM_SCHEDULE_ID"];
					c.EdSubjectAssessId = (System.Decimal)reader["ED_SUBJECT_ASSESS_ID"];
					c.ExamDate = (System.DateTime)reader["EXAM_DATE"];
					c.StartFrom = (System.DateTime)reader["START_FROM"];
					c.CoCodeExamShiftId = (System.Decimal)reader["CO_CODE_EXAM_SHIFT_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoScheduleDetail"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoScheduleDetail"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CoScheduleDetail entity)
		{
			if (!reader.Read()) return;
			
			entity.CoScheduleDetailId = (System.Decimal)reader[((int)CoScheduleDetailColumn.CoScheduleDetailId - 1)];
			entity.OriginalCoScheduleDetailId = (System.Decimal)reader["CO_SCHEDULE_DETAIL_ID"];
			entity.CoExamScheduleId = (System.Decimal)reader[((int)CoScheduleDetailColumn.CoExamScheduleId - 1)];
			entity.EdSubjectAssessId = (System.Decimal)reader[((int)CoScheduleDetailColumn.EdSubjectAssessId - 1)];
			entity.ExamDate = (System.DateTime)reader[((int)CoScheduleDetailColumn.ExamDate - 1)];
			entity.StartFrom = (System.DateTime)reader[((int)CoScheduleDetailColumn.StartFrom - 1)];
			entity.CoCodeExamShiftId = (System.Decimal)reader[((int)CoScheduleDetailColumn.CoCodeExamShiftId - 1)];
			entity.QDeliveryFlag = (reader.IsDBNull(((int)CoScheduleDetailColumn.QDeliveryFlag - 1)))?null:(System.Decimal?)reader[((int)CoScheduleDetailColumn.QDeliveryFlag - 1)];
			entity.QPapperNo = (reader.IsDBNull(((int)CoScheduleDetailColumn.QPapperNo - 1)))?null:(System.Decimal?)reader[((int)CoScheduleDetailColumn.QPapperNo - 1)];
			entity.DelivaryDate = (reader.IsDBNull(((int)CoScheduleDetailColumn.DelivaryDate - 1)))?null:(System.DateTime?)reader[((int)CoScheduleDetailColumn.DelivaryDate - 1)];
			entity.CoControlDelegMemId = (reader.IsDBNull(((int)CoScheduleDetailColumn.CoControlDelegMemId - 1)))?null:(System.Decimal?)reader[((int)CoScheduleDetailColumn.CoControlDelegMemId - 1)];
			entity.DelivaryCommittee = (reader.IsDBNull(((int)CoScheduleDetailColumn.DelivaryCommittee - 1)))?null:(System.String)reader[((int)CoScheduleDetailColumn.DelivaryCommittee - 1)];
			entity.Notes = (reader.IsDBNull(((int)CoScheduleDetailColumn.Notes - 1)))?null:(System.String)reader[((int)CoScheduleDetailColumn.Notes - 1)];
			entity.AnsSheetDelFlag = (reader.IsDBNull(((int)CoScheduleDetailColumn.AnsSheetDelFlag - 1)))?null:(System.Decimal?)reader[((int)CoScheduleDetailColumn.AnsSheetDelFlag - 1)];
			entity.AnsSheetsNo = (reader.IsDBNull(((int)CoScheduleDetailColumn.AnsSheetsNo - 1)))?null:(System.Decimal?)reader[((int)CoScheduleDetailColumn.AnsSheetsNo - 1)];
			entity.CoControlMembersId = (reader.IsDBNull(((int)CoScheduleDetailColumn.CoControlMembersId - 1)))?null:(System.Decimal?)reader[((int)CoScheduleDetailColumn.CoControlMembersId - 1)];
			entity.AnsSheetDeldate = (reader.IsDBNull(((int)CoScheduleDetailColumn.AnsSheetDeldate - 1)))?null:(System.DateTime?)reader[((int)CoScheduleDetailColumn.AnsSheetDeldate - 1)];
			entity.ADeliveryCommittee = (reader.IsDBNull(((int)CoScheduleDetailColumn.ADeliveryCommittee - 1)))?null:(System.String)reader[((int)CoScheduleDetailColumn.ADeliveryCommittee - 1)];
			entity.Note = (reader.IsDBNull(((int)CoScheduleDetailColumn.Note - 1)))?null:(System.String)reader[((int)CoScheduleDetailColumn.Note - 1)];
			entity.CorrectionEndFlag = (System.Decimal)reader[((int)CoScheduleDetailColumn.CorrectionEndFlag - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)CoScheduleDetailColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoScheduleDetail"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoScheduleDetail"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CoScheduleDetail entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CoScheduleDetailId = (System.Decimal)dataRow["CO_SCHEDULE_DETAIL_ID"];
			entity.OriginalCoScheduleDetailId = (System.Decimal)dataRow["CO_SCHEDULE_DETAIL_ID"];
			entity.CoExamScheduleId = (System.Decimal)dataRow["CO_EXAM_SCHEDULE_ID"];
			entity.EdSubjectAssessId = (System.Decimal)dataRow["ED_SUBJECT_ASSESS_ID"];
			entity.ExamDate = (System.DateTime)dataRow["EXAM_DATE"];
			entity.StartFrom = (System.DateTime)dataRow["START_FROM"];
			entity.CoCodeExamShiftId = (System.Decimal)dataRow["CO_CODE_EXAM_SHIFT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoScheduleDetail"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoScheduleDetail Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoScheduleDetail entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CoScheduleDetail object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CoScheduleDetail instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoScheduleDetail Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoScheduleDetail entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region CoScheduleDetailChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CoScheduleDetail</c>
	///</summary>
	public enum CoScheduleDetailChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
	}
	
	#endregion CoScheduleDetailChildEntityTypes
	
	#region CoScheduleDetailFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoScheduleDetailColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoScheduleDetail"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoScheduleDetailFilterBuilder : SqlFilterBuilder<CoScheduleDetailColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoScheduleDetailFilterBuilder class.
		/// </summary>
		public CoScheduleDetailFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoScheduleDetailFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoScheduleDetailFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoScheduleDetailFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoScheduleDetailFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoScheduleDetailFilterBuilder
	
	#region CoScheduleDetailParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoScheduleDetailColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoScheduleDetail"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoScheduleDetailParameterBuilder : ParameterizedSqlFilterBuilder<CoScheduleDetailColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoScheduleDetailParameterBuilder class.
		/// </summary>
		public CoScheduleDetailParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoScheduleDetailParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoScheduleDetailParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoScheduleDetailParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoScheduleDetailParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoScheduleDetailParameterBuilder
	
	#region CoScheduleDetailSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoScheduleDetailColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoScheduleDetail"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoScheduleDetailSortBuilder : SqlSortBuilder<CoScheduleDetailColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoScheduleDetailSqlSortBuilder class.
		/// </summary>
		public CoScheduleDetailSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoScheduleDetailSortBuilder
	
} // end namespace
