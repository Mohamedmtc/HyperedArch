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
	/// This class is the base class for any <see cref="CoExamCommSupervisorProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoExamCommSupervisorProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CoExamCommSupervisor, UMIS_VER2.BusinessLyer.CoExamCommSupervisorKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamCommSupervisorKey key)
		{
			return Delete(transactionManager, key.CoExamCommSupervisorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_coExamCommSupervisorId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _coExamCommSupervisorId)
		{
			return Delete(null, _coExamCommSupervisorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamCommSupervisorId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _coExamCommSupervisorId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_SUPERVISOR_CO_CONTROL_MEMBER key.
		///		FK_CO_EXAM_COMM_SUPERVISOR_CO_CONTROL_MEMBER Description: 
		/// </summary>
		/// <param name="_coControlMembersId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommSupervisor objects.</returns>
		public TList<CoExamCommSupervisor> GetByCoControlMembersId(System.Decimal _coControlMembersId)
		{
			int count = -1;
			return GetByCoControlMembersId(_coControlMembersId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_SUPERVISOR_CO_CONTROL_MEMBER key.
		///		FK_CO_EXAM_COMM_SUPERVISOR_CO_CONTROL_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlMembersId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommSupervisor objects.</returns>
		/// <remarks></remarks>
		public TList<CoExamCommSupervisor> GetByCoControlMembersId(TransactionManager transactionManager, System.Decimal _coControlMembersId)
		{
			int count = -1;
			return GetByCoControlMembersId(transactionManager, _coControlMembersId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_SUPERVISOR_CO_CONTROL_MEMBER key.
		///		FK_CO_EXAM_COMM_SUPERVISOR_CO_CONTROL_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlMembersId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommSupervisor objects.</returns>
		public TList<CoExamCommSupervisor> GetByCoControlMembersId(TransactionManager transactionManager, System.Decimal _coControlMembersId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlMembersId(transactionManager, _coControlMembersId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_SUPERVISOR_CO_CONTROL_MEMBER key.
		///		fkCoExamCommSupervisorCoControlMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coControlMembersId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommSupervisor objects.</returns>
		public TList<CoExamCommSupervisor> GetByCoControlMembersId(System.Decimal _coControlMembersId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCoControlMembersId(null, _coControlMembersId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_SUPERVISOR_CO_CONTROL_MEMBER key.
		///		fkCoExamCommSupervisorCoControlMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coControlMembersId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommSupervisor objects.</returns>
		public TList<CoExamCommSupervisor> GetByCoControlMembersId(System.Decimal _coControlMembersId, int start, int pageLength,out int count)
		{
			return GetByCoControlMembersId(null, _coControlMembersId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_SUPERVISOR_CO_CONTROL_MEMBER key.
		///		FK_CO_EXAM_COMM_SUPERVISOR_CO_CONTROL_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlMembersId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommSupervisor objects.</returns>
		public abstract TList<CoExamCommSupervisor> GetByCoControlMembersId(TransactionManager transactionManager, System.Decimal _coControlMembersId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_SUPERVISOR_CO_EXAM_SCHDL_PLACE key.
		///		FK_CO_EXAM_COMM_SUPERVISOR_CO_EXAM_SCHDL_PLACE Description: 
		/// </summary>
		/// <param name="_coExamSchdlPlaceId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommSupervisor objects.</returns>
		public TList<CoExamCommSupervisor> GetByCoExamSchdlPlaceId(System.Decimal _coExamSchdlPlaceId)
		{
			int count = -1;
			return GetByCoExamSchdlPlaceId(_coExamSchdlPlaceId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_SUPERVISOR_CO_EXAM_SCHDL_PLACE key.
		///		FK_CO_EXAM_COMM_SUPERVISOR_CO_EXAM_SCHDL_PLACE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamSchdlPlaceId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommSupervisor objects.</returns>
		/// <remarks></remarks>
		public TList<CoExamCommSupervisor> GetByCoExamSchdlPlaceId(TransactionManager transactionManager, System.Decimal _coExamSchdlPlaceId)
		{
			int count = -1;
			return GetByCoExamSchdlPlaceId(transactionManager, _coExamSchdlPlaceId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_SUPERVISOR_CO_EXAM_SCHDL_PLACE key.
		///		FK_CO_EXAM_COMM_SUPERVISOR_CO_EXAM_SCHDL_PLACE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamSchdlPlaceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommSupervisor objects.</returns>
		public TList<CoExamCommSupervisor> GetByCoExamSchdlPlaceId(TransactionManager transactionManager, System.Decimal _coExamSchdlPlaceId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoExamSchdlPlaceId(transactionManager, _coExamSchdlPlaceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_SUPERVISOR_CO_EXAM_SCHDL_PLACE key.
		///		fkCoExamCommSupervisorCoExamSchdlPlace Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coExamSchdlPlaceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommSupervisor objects.</returns>
		public TList<CoExamCommSupervisor> GetByCoExamSchdlPlaceId(System.Decimal _coExamSchdlPlaceId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCoExamSchdlPlaceId(null, _coExamSchdlPlaceId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_SUPERVISOR_CO_EXAM_SCHDL_PLACE key.
		///		fkCoExamCommSupervisorCoExamSchdlPlace Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coExamSchdlPlaceId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommSupervisor objects.</returns>
		public TList<CoExamCommSupervisor> GetByCoExamSchdlPlaceId(System.Decimal _coExamSchdlPlaceId, int start, int pageLength,out int count)
		{
			return GetByCoExamSchdlPlaceId(null, _coExamSchdlPlaceId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_SUPERVISOR_CO_EXAM_SCHDL_PLACE key.
		///		FK_CO_EXAM_COMM_SUPERVISOR_CO_EXAM_SCHDL_PLACE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamSchdlPlaceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommSupervisor objects.</returns>
		public abstract TList<CoExamCommSupervisor> GetByCoExamSchdlPlaceId(TransactionManager transactionManager, System.Decimal _coExamSchdlPlaceId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.CoExamCommSupervisor Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamCommSupervisorKey key, int start, int pageLength)
		{
			return GetByCoExamCommSupervisorId(transactionManager, key.CoExamCommSupervisorId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CO_COMMITEE_OBSERVER index.
		/// </summary>
		/// <param name="_coExamCommSupervisorId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamCommSupervisor GetByCoExamCommSupervisorId(System.Decimal _coExamCommSupervisorId)
		{
			int count = -1;
			return GetByCoExamCommSupervisorId(null,_coExamCommSupervisorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_COMMITEE_OBSERVER index.
		/// </summary>
		/// <param name="_coExamCommSupervisorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamCommSupervisor GetByCoExamCommSupervisorId(System.Decimal _coExamCommSupervisorId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoExamCommSupervisorId(null, _coExamCommSupervisorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_COMMITEE_OBSERVER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamCommSupervisorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamCommSupervisor GetByCoExamCommSupervisorId(TransactionManager transactionManager, System.Decimal _coExamCommSupervisorId)
		{
			int count = -1;
			return GetByCoExamCommSupervisorId(transactionManager, _coExamCommSupervisorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_COMMITEE_OBSERVER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamCommSupervisorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamCommSupervisor GetByCoExamCommSupervisorId(TransactionManager transactionManager, System.Decimal _coExamCommSupervisorId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoExamCommSupervisorId(transactionManager, _coExamCommSupervisorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_COMMITEE_OBSERVER index.
		/// </summary>
		/// <param name="_coExamCommSupervisorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamCommSupervisor GetByCoExamCommSupervisorId(System.Decimal _coExamCommSupervisorId, int start, int pageLength, out int count)
		{
			return GetByCoExamCommSupervisorId(null, _coExamCommSupervisorId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_COMMITEE_OBSERVER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamCommSupervisorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisor"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoExamCommSupervisor GetByCoExamCommSupervisorId(TransactionManager transactionManager, System.Decimal _coExamCommSupervisorId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoExamCommSupervisor&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoExamCommSupervisor&gt;"/></returns>
		public static TList<CoExamCommSupervisor> Fill(IDataReader reader, TList<CoExamCommSupervisor> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CoExamCommSupervisor c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoExamCommSupervisor")
					.Append("|").Append((System.Decimal)reader["CO_EXAM_COMM_SUPERVISOR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CoExamCommSupervisor>(
					key.ToString(), // EntityTrackingKey
					"CoExamCommSupervisor",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CoExamCommSupervisor();
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
					c.CoExamCommSupervisorId = (System.Decimal)reader["CO_EXAM_COMM_SUPERVISOR_ID"];
					c.OriginalCoExamCommSupervisorId = c.CoExamCommSupervisorId;
					c.CoExamSchdlPlaceId = (System.Decimal)reader["CO_EXAM_SCHDL_PLACE_ID"];
					c.CoControlMembersId = (System.Decimal)reader["CO_CONTROL_MEMBERS_ID"];
					c.HeadFlag = (System.Decimal)reader["HEAD_FLAG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisor"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisor"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CoExamCommSupervisor entity)
		{
			if (!reader.Read()) return;
			
			entity.CoExamCommSupervisorId = (System.Decimal)reader[((int)CoExamCommSupervisorColumn.CoExamCommSupervisorId - 1)];
			entity.OriginalCoExamCommSupervisorId = (System.Decimal)reader["CO_EXAM_COMM_SUPERVISOR_ID"];
			entity.CoExamSchdlPlaceId = (System.Decimal)reader[((int)CoExamCommSupervisorColumn.CoExamSchdlPlaceId - 1)];
			entity.CoControlMembersId = (System.Decimal)reader[((int)CoExamCommSupervisorColumn.CoControlMembersId - 1)];
			entity.HeadFlag = (System.Decimal)reader[((int)CoExamCommSupervisorColumn.HeadFlag - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisor"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisor"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CoExamCommSupervisor entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CoExamCommSupervisorId = (System.Decimal)dataRow["CO_EXAM_COMM_SUPERVISOR_ID"];
			entity.OriginalCoExamCommSupervisorId = (System.Decimal)dataRow["CO_EXAM_COMM_SUPERVISOR_ID"];
			entity.CoExamSchdlPlaceId = (System.Decimal)dataRow["CO_EXAM_SCHDL_PLACE_ID"];
			entity.CoControlMembersId = (System.Decimal)dataRow["CO_CONTROL_MEMBERS_ID"];
			entity.HeadFlag = (System.Decimal)dataRow["HEAD_FLAG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisor"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoExamCommSupervisor Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamCommSupervisor entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region CoControlMembersIdSource	
			if (CanDeepLoad(entity, "CoControlMember|CoControlMembersIdSource", deepLoadType, innerList) 
				&& entity.CoControlMembersIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CoControlMembersId;
				CoControlMember tmpEntity = EntityManager.LocateEntity<CoControlMember>(EntityLocator.ConstructKeyFromPkItems(typeof(CoControlMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CoControlMembersIdSource = tmpEntity;
				else
					entity.CoControlMembersIdSource = DataRepository.CoControlMemberProvider.GetByCoControlMembersId(transactionManager, entity.CoControlMembersId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlMembersIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CoControlMembersIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CoControlMemberProvider.DeepLoad(transactionManager, entity.CoControlMembersIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CoControlMembersIdSource

			#region CoExamSchdlPlaceIdSource	
			if (CanDeepLoad(entity, "CoExamSchdlPlace|CoExamSchdlPlaceIdSource", deepLoadType, innerList) 
				&& entity.CoExamSchdlPlaceIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CoExamSchdlPlaceId;
				CoExamSchdlPlace tmpEntity = EntityManager.LocateEntity<CoExamSchdlPlace>(EntityLocator.ConstructKeyFromPkItems(typeof(CoExamSchdlPlace), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CoExamSchdlPlaceIdSource = tmpEntity;
				else
					entity.CoExamSchdlPlaceIdSource = DataRepository.CoExamSchdlPlaceProvider.GetByCoExamSchdlPlaceId(transactionManager, entity.CoExamSchdlPlaceId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExamSchdlPlaceIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CoExamSchdlPlaceIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CoExamSchdlPlaceProvider.DeepLoad(transactionManager, entity.CoExamSchdlPlaceIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CoExamSchdlPlaceIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CoExamCommSupervisor object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CoExamCommSupervisor instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoExamCommSupervisor Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamCommSupervisor entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region CoControlMembersIdSource
			if (CanDeepSave(entity, "CoControlMember|CoControlMembersIdSource", deepSaveType, innerList) 
				&& entity.CoControlMembersIdSource != null)
			{
				DataRepository.CoControlMemberProvider.Save(transactionManager, entity.CoControlMembersIdSource);
				entity.CoControlMembersId = entity.CoControlMembersIdSource.CoControlMembersId;
			}
			#endregion 
			
			#region CoExamSchdlPlaceIdSource
			if (CanDeepSave(entity, "CoExamSchdlPlace|CoExamSchdlPlaceIdSource", deepSaveType, innerList) 
				&& entity.CoExamSchdlPlaceIdSource != null)
			{
				DataRepository.CoExamSchdlPlaceProvider.Save(transactionManager, entity.CoExamSchdlPlaceIdSource);
				entity.CoExamSchdlPlaceId = entity.CoExamSchdlPlaceIdSource.CoExamSchdlPlaceId;
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
	
	#region CoExamCommSupervisorChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CoExamCommSupervisor</c>
	///</summary>
	public enum CoExamCommSupervisorChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CoControlMember</c> at CoControlMembersIdSource
		///</summary>
		[ChildEntityType(typeof(CoControlMember))]
		CoControlMember,
		
		///<summary>
		/// Composite Property for <c>CoExamSchdlPlace</c> at CoExamSchdlPlaceIdSource
		///</summary>
		[ChildEntityType(typeof(CoExamSchdlPlace))]
		CoExamSchdlPlace,
	}
	
	#endregion CoExamCommSupervisorChildEntityTypes
	
	#region CoExamCommSupervisorFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoExamCommSupervisorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExamCommSupervisor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoExamCommSupervisorFilterBuilder : SqlFilterBuilder<CoExamCommSupervisorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExamCommSupervisorFilterBuilder class.
		/// </summary>
		public CoExamCommSupervisorFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoExamCommSupervisorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoExamCommSupervisorFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoExamCommSupervisorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoExamCommSupervisorFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoExamCommSupervisorFilterBuilder
	
	#region CoExamCommSupervisorParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoExamCommSupervisorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExamCommSupervisor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoExamCommSupervisorParameterBuilder : ParameterizedSqlFilterBuilder<CoExamCommSupervisorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExamCommSupervisorParameterBuilder class.
		/// </summary>
		public CoExamCommSupervisorParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoExamCommSupervisorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoExamCommSupervisorParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoExamCommSupervisorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoExamCommSupervisorParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoExamCommSupervisorParameterBuilder
	
	#region CoExamCommSupervisorSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoExamCommSupervisorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExamCommSupervisor"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoExamCommSupervisorSortBuilder : SqlSortBuilder<CoExamCommSupervisorColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExamCommSupervisorSqlSortBuilder class.
		/// </summary>
		public CoExamCommSupervisorSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoExamCommSupervisorSortBuilder
	
} // end namespace
