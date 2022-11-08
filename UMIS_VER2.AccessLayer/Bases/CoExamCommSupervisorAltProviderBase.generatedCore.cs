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
	/// This class is the base class for any <see cref="CoExamCommSupervisorAltProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoExamCommSupervisorAltProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt, UMIS_VER2.BusinessLyer.CoExamCommSupervisorAltKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamCommSupervisorAltKey key)
		{
			return Delete(transactionManager, key.CoExamCommSupervisorAltId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_coExamCommSupervisorAltId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _coExamCommSupervisorAltId)
		{
			return Delete(null, _coExamCommSupervisorAltId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamCommSupervisorAltId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _coExamCommSupervisorAltId);		
		
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
		public override UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamCommSupervisorAltKey key, int start, int pageLength)
		{
			return GetByCoExamCommSupervisorAltId(transactionManager, key.CoExamCommSupervisorAltId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExamCommSupervisorAlt&gt;"/> class.</returns>
		public TList<CoExamCommSupervisorAlt> GetByCoControlId(System.Decimal _coControlId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExamCommSupervisorAlt&gt;"/> class.</returns>
		public TList<CoExamCommSupervisorAlt> GetByCoControlId(System.Decimal _coControlId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExamCommSupervisorAlt&gt;"/> class.</returns>
		public TList<CoExamCommSupervisorAlt> GetByCoControlId(TransactionManager transactionManager, System.Decimal _coControlId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExamCommSupervisorAlt&gt;"/> class.</returns>
		public TList<CoExamCommSupervisorAlt> GetByCoControlId(TransactionManager transactionManager, System.Decimal _coControlId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExamCommSupervisorAlt&gt;"/> class.</returns>
		public TList<CoExamCommSupervisorAlt> GetByCoControlId(System.Decimal _coControlId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExamCommSupervisorAlt&gt;"/> class.</returns>
		public abstract TList<CoExamCommSupervisorAlt> GetByCoControlId(TransactionManager transactionManager, System.Decimal _coControlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_CO_CONTROL_MEMBERS_I_1 index.
		/// </summary>
		/// <param name="_coControlMembersId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExamCommSupervisorAlt&gt;"/> class.</returns>
		public TList<CoExamCommSupervisorAlt> GetByCoControlMembersId(System.Decimal _coControlMembersId)
		{
			int count = -1;
			return GetByCoControlMembersId(null,_coControlMembersId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_MEMBERS_I_1 index.
		/// </summary>
		/// <param name="_coControlMembersId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExamCommSupervisorAlt&gt;"/> class.</returns>
		public TList<CoExamCommSupervisorAlt> GetByCoControlMembersId(System.Decimal _coControlMembersId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlMembersId(null, _coControlMembersId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_MEMBERS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlMembersId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExamCommSupervisorAlt&gt;"/> class.</returns>
		public TList<CoExamCommSupervisorAlt> GetByCoControlMembersId(TransactionManager transactionManager, System.Decimal _coControlMembersId)
		{
			int count = -1;
			return GetByCoControlMembersId(transactionManager, _coControlMembersId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_MEMBERS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlMembersId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExamCommSupervisorAlt&gt;"/> class.</returns>
		public TList<CoExamCommSupervisorAlt> GetByCoControlMembersId(TransactionManager transactionManager, System.Decimal _coControlMembersId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlMembersId(transactionManager, _coControlMembersId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_MEMBERS_I_1 index.
		/// </summary>
		/// <param name="_coControlMembersId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExamCommSupervisorAlt&gt;"/> class.</returns>
		public TList<CoExamCommSupervisorAlt> GetByCoControlMembersId(System.Decimal _coControlMembersId, int start, int pageLength, out int count)
		{
			return GetByCoControlMembersId(null, _coControlMembersId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_MEMBERS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlMembersId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExamCommSupervisorAlt&gt;"/> class.</returns>
		public abstract TList<CoExamCommSupervisorAlt> GetByCoControlMembersId(TransactionManager transactionManager, System.Decimal _coControlMembersId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CO_EXAM_COMM_SUPERVISOR_ALT index.
		/// </summary>
		/// <param name="_coExamCommSupervisorAltId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt GetByCoExamCommSupervisorAltId(System.Decimal _coExamCommSupervisorAltId)
		{
			int count = -1;
			return GetByCoExamCommSupervisorAltId(null,_coExamCommSupervisorAltId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_COMM_SUPERVISOR_ALT index.
		/// </summary>
		/// <param name="_coExamCommSupervisorAltId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt GetByCoExamCommSupervisorAltId(System.Decimal _coExamCommSupervisorAltId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoExamCommSupervisorAltId(null, _coExamCommSupervisorAltId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_COMM_SUPERVISOR_ALT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamCommSupervisorAltId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt GetByCoExamCommSupervisorAltId(TransactionManager transactionManager, System.Decimal _coExamCommSupervisorAltId)
		{
			int count = -1;
			return GetByCoExamCommSupervisorAltId(transactionManager, _coExamCommSupervisorAltId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_COMM_SUPERVISOR_ALT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamCommSupervisorAltId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt GetByCoExamCommSupervisorAltId(TransactionManager transactionManager, System.Decimal _coExamCommSupervisorAltId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoExamCommSupervisorAltId(transactionManager, _coExamCommSupervisorAltId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_COMM_SUPERVISOR_ALT index.
		/// </summary>
		/// <param name="_coExamCommSupervisorAltId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt GetByCoExamCommSupervisorAltId(System.Decimal _coExamCommSupervisorAltId, int start, int pageLength, out int count)
		{
			return GetByCoExamCommSupervisorAltId(null, _coExamCommSupervisorAltId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_COMM_SUPERVISOR_ALT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamCommSupervisorAltId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt GetByCoExamCommSupervisorAltId(TransactionManager transactionManager, System.Decimal _coExamCommSupervisorAltId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoExamCommSupervisorAlt&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoExamCommSupervisorAlt&gt;"/></returns>
		public static TList<CoExamCommSupervisorAlt> Fill(IDataReader reader, TList<CoExamCommSupervisorAlt> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoExamCommSupervisorAlt")
					.Append("|").Append((System.Decimal)reader["CO_EXAM_COMM_SUPERVISOR_ALT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CoExamCommSupervisorAlt>(
					key.ToString(), // EntityTrackingKey
					"CoExamCommSupervisorAlt",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt();
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
					c.CoExamCommSupervisorAltId = (System.Decimal)reader["CO_EXAM_COMM_SUPERVISOR_ALT_ID"];
					c.OriginalCoExamCommSupervisorAltId = c.CoExamCommSupervisorAltId;
					c.CoControlId = (System.Decimal)reader["CO_CONTROL_ID"];
					c.CoControlMembersId = (System.Decimal)reader["CO_CONTROL_MEMBERS_ID"];
					c.AltDate = (System.DateTime)reader["ALT_DATE"];
					c.AltTimeFrom = (System.DateTime)reader["ALT_TIME_FROM"];
					c.AltTimeTo = (System.DateTime)reader["ALT_TIME_TO"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt entity)
		{
			if (!reader.Read()) return;
			
			entity.CoExamCommSupervisorAltId = (System.Decimal)reader[((int)CoExamCommSupervisorAltColumn.CoExamCommSupervisorAltId - 1)];
			entity.OriginalCoExamCommSupervisorAltId = (System.Decimal)reader["CO_EXAM_COMM_SUPERVISOR_ALT_ID"];
			entity.CoControlId = (System.Decimal)reader[((int)CoExamCommSupervisorAltColumn.CoControlId - 1)];
			entity.CoControlMembersId = (System.Decimal)reader[((int)CoExamCommSupervisorAltColumn.CoControlMembersId - 1)];
			entity.AltDate = (System.DateTime)reader[((int)CoExamCommSupervisorAltColumn.AltDate - 1)];
			entity.AltTimeFrom = (System.DateTime)reader[((int)CoExamCommSupervisorAltColumn.AltTimeFrom - 1)];
			entity.AltTimeTo = (System.DateTime)reader[((int)CoExamCommSupervisorAltColumn.AltTimeTo - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CoExamCommSupervisorAltId = (System.Decimal)dataRow["CO_EXAM_COMM_SUPERVISOR_ALT_ID"];
			entity.OriginalCoExamCommSupervisorAltId = (System.Decimal)dataRow["CO_EXAM_COMM_SUPERVISOR_ALT_ID"];
			entity.CoControlId = (System.Decimal)dataRow["CO_CONTROL_ID"];
			entity.CoControlMembersId = (System.Decimal)dataRow["CO_CONTROL_MEMBERS_ID"];
			entity.AltDate = (System.DateTime)dataRow["ALT_DATE"];
			entity.AltTimeFrom = (System.DateTime)dataRow["ALT_TIME_FROM"];
			entity.AltTimeTo = (System.DateTime)dataRow["ALT_TIME_TO"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region CoControlIdSource	
			if (CanDeepLoad(entity, "CoControl|CoControlIdSource", deepLoadType, innerList) 
				&& entity.CoControlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CoControlId;
				CoControl tmpEntity = EntityManager.LocateEntity<CoControl>(EntityLocator.ConstructKeyFromPkItems(typeof(CoControl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CoControlIdSource = tmpEntity;
				else
					entity.CoControlIdSource = DataRepository.CoControlProvider.GetByCoControlId(transactionManager, entity.CoControlId);		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region CoControlMembersIdSource
			if (CanDeepSave(entity, "CoControlMember|CoControlMembersIdSource", deepSaveType, innerList) 
				&& entity.CoControlMembersIdSource != null)
			{
				DataRepository.CoControlMemberProvider.Save(transactionManager, entity.CoControlMembersIdSource);
				entity.CoControlMembersId = entity.CoControlMembersIdSource.CoControlMembersId;
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
	
	#region CoExamCommSupervisorAltChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CoExamCommSupervisorAlt</c>
	///</summary>
	public enum CoExamCommSupervisorAltChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CoControl</c> at CoControlIdSource
		///</summary>
		[ChildEntityType(typeof(CoControl))]
		CoControl,
		
		///<summary>
		/// Composite Property for <c>CoControlMember</c> at CoControlMembersIdSource
		///</summary>
		[ChildEntityType(typeof(CoControlMember))]
		CoControlMember,
	}
	
	#endregion CoExamCommSupervisorAltChildEntityTypes
	
	#region CoExamCommSupervisorAltFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoExamCommSupervisorAltColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExamCommSupervisorAlt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoExamCommSupervisorAltFilterBuilder : SqlFilterBuilder<CoExamCommSupervisorAltColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExamCommSupervisorAltFilterBuilder class.
		/// </summary>
		public CoExamCommSupervisorAltFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoExamCommSupervisorAltFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoExamCommSupervisorAltFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoExamCommSupervisorAltFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoExamCommSupervisorAltFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoExamCommSupervisorAltFilterBuilder
	
	#region CoExamCommSupervisorAltParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoExamCommSupervisorAltColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExamCommSupervisorAlt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoExamCommSupervisorAltParameterBuilder : ParameterizedSqlFilterBuilder<CoExamCommSupervisorAltColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExamCommSupervisorAltParameterBuilder class.
		/// </summary>
		public CoExamCommSupervisorAltParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoExamCommSupervisorAltParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoExamCommSupervisorAltParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoExamCommSupervisorAltParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoExamCommSupervisorAltParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoExamCommSupervisorAltParameterBuilder
	
	#region CoExamCommSupervisorAltSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoExamCommSupervisorAltColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExamCommSupervisorAlt"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoExamCommSupervisorAltSortBuilder : SqlSortBuilder<CoExamCommSupervisorAltColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExamCommSupervisorAltSqlSortBuilder class.
		/// </summary>
		public CoExamCommSupervisorAltSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoExamCommSupervisorAltSortBuilder
	
} // end namespace
