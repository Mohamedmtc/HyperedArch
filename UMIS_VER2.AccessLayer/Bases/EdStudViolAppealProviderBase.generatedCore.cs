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
	/// This class is the base class for any <see cref="EdStudViolAppealProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudViolAppealProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudViolAppeal, UMIS_VER2.BusinessLyer.EdStudViolAppealKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudViolAppealKey key)
		{
			return Delete(transactionManager, key.EdStudViolAppealId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudViolAppealId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudViolAppealId)
		{
			return Delete(null, _edStudViolAppealId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolAppealId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudViolAppealId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_APPEAL_GS_CDE_PENALTY key.
		///		FK_ED_STUD_VIOL_APPEAL_GS_CDE_PENALTY Description: 
		/// </summary>
		/// <param name="_gsCdePenaltyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViolAppeal objects.</returns>
		public TList<EdStudViolAppeal> GetByGsCdePenaltyId(System.Decimal? _gsCdePenaltyId)
		{
			int count = -1;
			return GetByGsCdePenaltyId(_gsCdePenaltyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_APPEAL_GS_CDE_PENALTY key.
		///		FK_ED_STUD_VIOL_APPEAL_GS_CDE_PENALTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViolAppeal objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudViolAppeal> GetByGsCdePenaltyId(TransactionManager transactionManager, System.Decimal? _gsCdePenaltyId)
		{
			int count = -1;
			return GetByGsCdePenaltyId(transactionManager, _gsCdePenaltyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_APPEAL_GS_CDE_PENALTY key.
		///		FK_ED_STUD_VIOL_APPEAL_GS_CDE_PENALTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViolAppeal objects.</returns>
		public TList<EdStudViolAppeal> GetByGsCdePenaltyId(TransactionManager transactionManager, System.Decimal? _gsCdePenaltyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdePenaltyId(transactionManager, _gsCdePenaltyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_APPEAL_GS_CDE_PENALTY key.
		///		fkEdStudViolAppealGsCdePenalty Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViolAppeal objects.</returns>
		public TList<EdStudViolAppeal> GetByGsCdePenaltyId(System.Decimal? _gsCdePenaltyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdePenaltyId(null, _gsCdePenaltyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_APPEAL_GS_CDE_PENALTY key.
		///		fkEdStudViolAppealGsCdePenalty Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViolAppeal objects.</returns>
		public TList<EdStudViolAppeal> GetByGsCdePenaltyId(System.Decimal? _gsCdePenaltyId, int start, int pageLength,out int count)
		{
			return GetByGsCdePenaltyId(null, _gsCdePenaltyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_APPEAL_GS_CDE_PENALTY key.
		///		FK_ED_STUD_VIOL_APPEAL_GS_CDE_PENALTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViolAppeal objects.</returns>
		public abstract TList<EdStudViolAppeal> GetByGsCdePenaltyId(TransactionManager transactionManager, System.Decimal? _gsCdePenaltyId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudViolAppeal Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudViolAppealKey key, int start, int pageLength)
		{
			return GetByEdStudViolAppealId(transactionManager, key.EdStudViolAppealId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_VIOL_APPEAL index.
		/// </summary>
		/// <param name="_edStudViolAppealId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViolAppeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViolAppeal GetByEdStudViolAppealId(System.Decimal _edStudViolAppealId)
		{
			int count = -1;
			return GetByEdStudViolAppealId(null,_edStudViolAppealId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_VIOL_APPEAL index.
		/// </summary>
		/// <param name="_edStudViolAppealId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViolAppeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViolAppeal GetByEdStudViolAppealId(System.Decimal _edStudViolAppealId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudViolAppealId(null, _edStudViolAppealId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_VIOL_APPEAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolAppealId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViolAppeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViolAppeal GetByEdStudViolAppealId(TransactionManager transactionManager, System.Decimal _edStudViolAppealId)
		{
			int count = -1;
			return GetByEdStudViolAppealId(transactionManager, _edStudViolAppealId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_VIOL_APPEAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolAppealId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViolAppeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViolAppeal GetByEdStudViolAppealId(TransactionManager transactionManager, System.Decimal _edStudViolAppealId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudViolAppealId(transactionManager, _edStudViolAppealId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_VIOL_APPEAL index.
		/// </summary>
		/// <param name="_edStudViolAppealId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViolAppeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViolAppeal GetByEdStudViolAppealId(System.Decimal _edStudViolAppealId, int start, int pageLength, out int count)
		{
			return GetByEdStudViolAppealId(null, _edStudViolAppealId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_VIOL_APPEAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolAppealId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViolAppeal"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudViolAppeal GetByEdStudViolAppealId(TransactionManager transactionManager, System.Decimal _edStudViolAppealId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_VIOL_APPEAL index.
		/// </summary>
		/// <param name="_edStudViolId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViolAppeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViolAppeal GetByEdStudViolId(System.Decimal _edStudViolId)
		{
			int count = -1;
			return GetByEdStudViolId(null,_edStudViolId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_VIOL_APPEAL index.
		/// </summary>
		/// <param name="_edStudViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViolAppeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViolAppeal GetByEdStudViolId(System.Decimal _edStudViolId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudViolId(null, _edStudViolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_VIOL_APPEAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViolAppeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViolAppeal GetByEdStudViolId(TransactionManager transactionManager, System.Decimal _edStudViolId)
		{
			int count = -1;
			return GetByEdStudViolId(transactionManager, _edStudViolId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_VIOL_APPEAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViolAppeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViolAppeal GetByEdStudViolId(TransactionManager transactionManager, System.Decimal _edStudViolId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudViolId(transactionManager, _edStudViolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_VIOL_APPEAL index.
		/// </summary>
		/// <param name="_edStudViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViolAppeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViolAppeal GetByEdStudViolId(System.Decimal _edStudViolId, int start, int pageLength, out int count)
		{
			return GetByEdStudViolId(null, _edStudViolId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_VIOL_APPEAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViolAppeal"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudViolAppeal GetByEdStudViolId(TransactionManager transactionManager, System.Decimal _edStudViolId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudViolAppeal&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudViolAppeal&gt;"/></returns>
		public static TList<EdStudViolAppeal> Fill(IDataReader reader, TList<EdStudViolAppeal> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudViolAppeal c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudViolAppeal")
					.Append("|").Append((System.Decimal)reader["ED_STUD_VIOL_APPEAL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudViolAppeal>(
					key.ToString(), // EntityTrackingKey
					"EdStudViolAppeal",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudViolAppeal();
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
					c.EdStudViolAppealId = (System.Decimal)reader["ED_STUD_VIOL_APPEAL_ID"];
					c.OriginalEdStudViolAppealId = c.EdStudViolAppealId;
					c.EdStudViolId = (System.Decimal)reader["ED_STUD_VIOL_ID"];
					c.AppealDate = (System.DateTime)reader["APPEAL_DATE"];
					c.AppealDtl = Convert.IsDBNull(reader["APPEAL_DTL"]) ? null : (System.String)reader["APPEAL_DTL"];
					c.ResultTypeId = Convert.IsDBNull(reader["RESULT_TYPE_ID"]) ? null : (System.Decimal?)reader["RESULT_TYPE_ID"];
					c.GsCdePenaltyId = Convert.IsDBNull(reader["GS_CDE_PENALTY_ID"]) ? null : (System.Decimal?)reader["GS_CDE_PENALTY_ID"];
					c.GrievanceFlag = Convert.IsDBNull(reader["GRIEVANCE_FLAG"]) ? null : (System.Decimal?)reader["GRIEVANCE_FLAG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudViolAppeal"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudViolAppeal"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudViolAppeal entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudViolAppealId = (System.Decimal)reader[((int)EdStudViolAppealColumn.EdStudViolAppealId - 1)];
			entity.OriginalEdStudViolAppealId = (System.Decimal)reader["ED_STUD_VIOL_APPEAL_ID"];
			entity.EdStudViolId = (System.Decimal)reader[((int)EdStudViolAppealColumn.EdStudViolId - 1)];
			entity.AppealDate = (System.DateTime)reader[((int)EdStudViolAppealColumn.AppealDate - 1)];
			entity.AppealDtl = (reader.IsDBNull(((int)EdStudViolAppealColumn.AppealDtl - 1)))?null:(System.String)reader[((int)EdStudViolAppealColumn.AppealDtl - 1)];
			entity.ResultTypeId = (reader.IsDBNull(((int)EdStudViolAppealColumn.ResultTypeId - 1)))?null:(System.Decimal?)reader[((int)EdStudViolAppealColumn.ResultTypeId - 1)];
			entity.GsCdePenaltyId = (reader.IsDBNull(((int)EdStudViolAppealColumn.GsCdePenaltyId - 1)))?null:(System.Decimal?)reader[((int)EdStudViolAppealColumn.GsCdePenaltyId - 1)];
			entity.GrievanceFlag = (reader.IsDBNull(((int)EdStudViolAppealColumn.GrievanceFlag - 1)))?null:(System.Decimal?)reader[((int)EdStudViolAppealColumn.GrievanceFlag - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudViolAppeal"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudViolAppeal"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudViolAppeal entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudViolAppealId = (System.Decimal)dataRow["ED_STUD_VIOL_APPEAL_ID"];
			entity.OriginalEdStudViolAppealId = (System.Decimal)dataRow["ED_STUD_VIOL_APPEAL_ID"];
			entity.EdStudViolId = (System.Decimal)dataRow["ED_STUD_VIOL_ID"];
			entity.AppealDate = (System.DateTime)dataRow["APPEAL_DATE"];
			entity.AppealDtl = Convert.IsDBNull(dataRow["APPEAL_DTL"]) ? null : (System.String)dataRow["APPEAL_DTL"];
			entity.ResultTypeId = Convert.IsDBNull(dataRow["RESULT_TYPE_ID"]) ? null : (System.Decimal?)dataRow["RESULT_TYPE_ID"];
			entity.GsCdePenaltyId = Convert.IsDBNull(dataRow["GS_CDE_PENALTY_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_PENALTY_ID"];
			entity.GrievanceFlag = Convert.IsDBNull(dataRow["GRIEVANCE_FLAG"]) ? null : (System.Decimal?)dataRow["GRIEVANCE_FLAG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudViolAppeal"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudViolAppeal Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudViolAppeal entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudViolIdSource	
			if (CanDeepLoad(entity, "EdStudViol|EdStudViolIdSource", deepLoadType, innerList) 
				&& entity.EdStudViolIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudViolId;
				EdStudViol tmpEntity = EntityManager.LocateEntity<EdStudViol>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudViol), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudViolIdSource = tmpEntity;
				else
					entity.EdStudViolIdSource = DataRepository.EdStudViolProvider.GetByEdStudViolId(transactionManager, entity.EdStudViolId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudViolIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudViolProvider.DeepLoad(transactionManager, entity.EdStudViolIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudViolIdSource

			#region GsCdePenaltyIdSource	
			if (CanDeepLoad(entity, "GsCdePenalty|GsCdePenaltyIdSource", deepLoadType, innerList) 
				&& entity.GsCdePenaltyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdePenaltyId ?? 0.0m);
				GsCdePenalty tmpEntity = EntityManager.LocateEntity<GsCdePenalty>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdePenalty), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdePenaltyIdSource = tmpEntity;
				else
					entity.GsCdePenaltyIdSource = DataRepository.GsCdePenaltyProvider.GetByGsCdePenaltyId(transactionManager, (entity.GsCdePenaltyId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdePenaltyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdePenaltyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdePenaltyProvider.DeepLoad(transactionManager, entity.GsCdePenaltyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdePenaltyIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdStudViolAppealId methods when available
			
			#region GsAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAttchdDoc>|GsAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAttchdDocCollection = DataRepository.GsAttchdDocProvider.GetByEdStudViolAppealId(transactionManager, entity.EdStudViolAppealId);

				if (deep && entity.GsAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAttchdDoc>) DataRepository.GsAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudViolAppeal object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudViolAppeal instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudViolAppeal Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudViolAppeal entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudViolIdSource
			if (CanDeepSave(entity, "EdStudViol|EdStudViolIdSource", deepSaveType, innerList) 
				&& entity.EdStudViolIdSource != null)
			{
				DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolIdSource);
				entity.EdStudViolId = entity.EdStudViolIdSource.EdStudViolId;
			}
			#endregion 
			
			#region GsCdePenaltyIdSource
			if (CanDeepSave(entity, "GsCdePenalty|GsCdePenaltyIdSource", deepSaveType, innerList) 
				&& entity.GsCdePenaltyIdSource != null)
			{
				DataRepository.GsCdePenaltyProvider.Save(transactionManager, entity.GsCdePenaltyIdSource);
				entity.GsCdePenaltyId = entity.GsCdePenaltyIdSource.GsCdePenaltyId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<GsAttchdDoc>
				if (CanDeepSave(entity.GsAttchdDocCollection, "List<GsAttchdDoc>|GsAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAttchdDoc child in entity.GsAttchdDocCollection)
					{
						if(child.EdStudViolAppealIdSource != null)
						{
							child.EdStudViolAppealId = child.EdStudViolAppealIdSource.EdStudViolAppealId;
						}
						else
						{
							child.EdStudViolAppealId = entity.EdStudViolAppealId;
						}

					}

					if (entity.GsAttchdDocCollection.Count > 0 || entity.GsAttchdDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsAttchdDocProvider.Save(transactionManager, entity.GsAttchdDocCollection);
						
						deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsAttchdDoc >) DataRepository.GsAttchdDocProvider.DeepSave,
							new object[] { transactionManager, entity.GsAttchdDocCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdStudViolAppealChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudViolAppeal</c>
	///</summary>
	public enum EdStudViolAppealChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStudViol</c> at EdStudViolIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudViol))]
		EdStudViol,
		
		///<summary>
		/// Composite Property for <c>GsCdePenalty</c> at GsCdePenaltyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdePenalty))]
		GsCdePenalty,
		///<summary>
		/// Collection of <c>EdStudViolAppeal</c> as OneToMany for GsAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAttchdDoc>))]
		GsAttchdDocCollection,
	}
	
	#endregion EdStudViolAppealChildEntityTypes
	
	#region EdStudViolAppealFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudViolAppealColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudViolAppeal"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudViolAppealFilterBuilder : SqlFilterBuilder<EdStudViolAppealColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudViolAppealFilterBuilder class.
		/// </summary>
		public EdStudViolAppealFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudViolAppealFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudViolAppealFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudViolAppealFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudViolAppealFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudViolAppealFilterBuilder
	
	#region EdStudViolAppealParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudViolAppealColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudViolAppeal"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudViolAppealParameterBuilder : ParameterizedSqlFilterBuilder<EdStudViolAppealColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudViolAppealParameterBuilder class.
		/// </summary>
		public EdStudViolAppealParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudViolAppealParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudViolAppealParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudViolAppealParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudViolAppealParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudViolAppealParameterBuilder
	
	#region EdStudViolAppealSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudViolAppealColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudViolAppeal"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudViolAppealSortBuilder : SqlSortBuilder<EdStudViolAppealColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudViolAppealSqlSortBuilder class.
		/// </summary>
		public EdStudViolAppealSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudViolAppealSortBuilder
	
} // end namespace
