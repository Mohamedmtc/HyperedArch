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
	/// This class is the base class for any <see cref="EdStudRsrvRegTimeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudRsrvRegTimeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudRsrvRegTime, UMIS_VER2.BusinessLyer.EdStudRsrvRegTimeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudRsrvRegTimeKey key)
		{
			return Delete(transactionManager, key.EdStudRsrvRegTimeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudRsrvRegTimeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudRsrvRegTimeId)
		{
			return Delete(null, _edStudRsrvRegTimeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudRsrvRegTimeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudRsrvRegTimeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_RSRV_REG_TIME_ED_SEM_AGENDA_TIME key.
		///		FK_ED_STUD_RSRV_REG_TIME_ED_SEM_AGENDA_TIME Description: 
		/// </summary>
		/// <param name="_edSemAgendaTimeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudRsrvRegTime objects.</returns>
		public TList<EdStudRsrvRegTime> GetByEdSemAgendaTimeId(System.Decimal _edSemAgendaTimeId)
		{
			int count = -1;
			return GetByEdSemAgendaTimeId(_edSemAgendaTimeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_RSRV_REG_TIME_ED_SEM_AGENDA_TIME key.
		///		FK_ED_STUD_RSRV_REG_TIME_ED_SEM_AGENDA_TIME Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemAgendaTimeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudRsrvRegTime objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudRsrvRegTime> GetByEdSemAgendaTimeId(TransactionManager transactionManager, System.Decimal _edSemAgendaTimeId)
		{
			int count = -1;
			return GetByEdSemAgendaTimeId(transactionManager, _edSemAgendaTimeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_RSRV_REG_TIME_ED_SEM_AGENDA_TIME key.
		///		FK_ED_STUD_RSRV_REG_TIME_ED_SEM_AGENDA_TIME Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemAgendaTimeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudRsrvRegTime objects.</returns>
		public TList<EdStudRsrvRegTime> GetByEdSemAgendaTimeId(TransactionManager transactionManager, System.Decimal _edSemAgendaTimeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdSemAgendaTimeId(transactionManager, _edSemAgendaTimeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_RSRV_REG_TIME_ED_SEM_AGENDA_TIME key.
		///		fkEdStudRsrvRegTimeEdSemAgendaTime Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edSemAgendaTimeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudRsrvRegTime objects.</returns>
		public TList<EdStudRsrvRegTime> GetByEdSemAgendaTimeId(System.Decimal _edSemAgendaTimeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdSemAgendaTimeId(null, _edSemAgendaTimeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_RSRV_REG_TIME_ED_SEM_AGENDA_TIME key.
		///		fkEdStudRsrvRegTimeEdSemAgendaTime Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edSemAgendaTimeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudRsrvRegTime objects.</returns>
		public TList<EdStudRsrvRegTime> GetByEdSemAgendaTimeId(System.Decimal _edSemAgendaTimeId, int start, int pageLength,out int count)
		{
			return GetByEdSemAgendaTimeId(null, _edSemAgendaTimeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_RSRV_REG_TIME_ED_SEM_AGENDA_TIME key.
		///		FK_ED_STUD_RSRV_REG_TIME_ED_SEM_AGENDA_TIME Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemAgendaTimeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudRsrvRegTime objects.</returns>
		public abstract TList<EdStudRsrvRegTime> GetByEdSemAgendaTimeId(TransactionManager transactionManager, System.Decimal _edSemAgendaTimeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_RSRV_REG_TIME_ED_STUD key.
		///		FK_ED_STUD_RSRV_REG_TIME_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudRsrvRegTime objects.</returns>
		public TList<EdStudRsrvRegTime> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_RSRV_REG_TIME_ED_STUD key.
		///		FK_ED_STUD_RSRV_REG_TIME_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudRsrvRegTime objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudRsrvRegTime> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_RSRV_REG_TIME_ED_STUD key.
		///		FK_ED_STUD_RSRV_REG_TIME_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudRsrvRegTime objects.</returns>
		public TList<EdStudRsrvRegTime> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_RSRV_REG_TIME_ED_STUD key.
		///		fkEdStudRsrvRegTimeEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudRsrvRegTime objects.</returns>
		public TList<EdStudRsrvRegTime> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_RSRV_REG_TIME_ED_STUD key.
		///		fkEdStudRsrvRegTimeEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudRsrvRegTime objects.</returns>
		public TList<EdStudRsrvRegTime> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_RSRV_REG_TIME_ED_STUD key.
		///		FK_ED_STUD_RSRV_REG_TIME_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudRsrvRegTime objects.</returns>
		public abstract TList<EdStudRsrvRegTime> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudRsrvRegTime Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudRsrvRegTimeKey key, int start, int pageLength)
		{
			return GetByEdStudRsrvRegTimeId(transactionManager, key.EdStudRsrvRegTimeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_RSRV_REG_TIME index.
		/// </summary>
		/// <param name="_edStudRsrvRegTimeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudRsrvRegTime"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudRsrvRegTime GetByEdStudRsrvRegTimeId(System.Decimal _edStudRsrvRegTimeId)
		{
			int count = -1;
			return GetByEdStudRsrvRegTimeId(null,_edStudRsrvRegTimeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_RSRV_REG_TIME index.
		/// </summary>
		/// <param name="_edStudRsrvRegTimeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudRsrvRegTime"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudRsrvRegTime GetByEdStudRsrvRegTimeId(System.Decimal _edStudRsrvRegTimeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudRsrvRegTimeId(null, _edStudRsrvRegTimeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_RSRV_REG_TIME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudRsrvRegTimeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudRsrvRegTime"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudRsrvRegTime GetByEdStudRsrvRegTimeId(TransactionManager transactionManager, System.Decimal _edStudRsrvRegTimeId)
		{
			int count = -1;
			return GetByEdStudRsrvRegTimeId(transactionManager, _edStudRsrvRegTimeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_RSRV_REG_TIME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudRsrvRegTimeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudRsrvRegTime"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudRsrvRegTime GetByEdStudRsrvRegTimeId(TransactionManager transactionManager, System.Decimal _edStudRsrvRegTimeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudRsrvRegTimeId(transactionManager, _edStudRsrvRegTimeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_RSRV_REG_TIME index.
		/// </summary>
		/// <param name="_edStudRsrvRegTimeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudRsrvRegTime"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudRsrvRegTime GetByEdStudRsrvRegTimeId(System.Decimal _edStudRsrvRegTimeId, int start, int pageLength, out int count)
		{
			return GetByEdStudRsrvRegTimeId(null, _edStudRsrvRegTimeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_RSRV_REG_TIME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudRsrvRegTimeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudRsrvRegTime"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudRsrvRegTime GetByEdStudRsrvRegTimeId(TransactionManager transactionManager, System.Decimal _edStudRsrvRegTimeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudRsrvRegTime&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudRsrvRegTime&gt;"/></returns>
		public static TList<EdStudRsrvRegTime> Fill(IDataReader reader, TList<EdStudRsrvRegTime> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudRsrvRegTime c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudRsrvRegTime")
					.Append("|").Append((System.Decimal)reader["ED_STUD_RSRV_REG_TIME_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudRsrvRegTime>(
					key.ToString(), // EntityTrackingKey
					"EdStudRsrvRegTime",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudRsrvRegTime();
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
					c.EdStudRsrvRegTimeId = (System.Decimal)reader["ED_STUD_RSRV_REG_TIME_ID"];
					c.OriginalEdStudRsrvRegTimeId = c.EdStudRsrvRegTimeId;
					c.EdSemAgendaTimeId = (System.Decimal)reader["ED_SEM_AGENDA_TIME_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudRsrvRegTime"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudRsrvRegTime"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudRsrvRegTime entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudRsrvRegTimeId = (System.Decimal)reader[((int)EdStudRsrvRegTimeColumn.EdStudRsrvRegTimeId - 1)];
			entity.OriginalEdStudRsrvRegTimeId = (System.Decimal)reader["ED_STUD_RSRV_REG_TIME_ID"];
			entity.EdSemAgendaTimeId = (System.Decimal)reader[((int)EdStudRsrvRegTimeColumn.EdSemAgendaTimeId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)EdStudRsrvRegTimeColumn.EdStudId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudRsrvRegTime"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudRsrvRegTime"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudRsrvRegTime entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudRsrvRegTimeId = (System.Decimal)dataRow["ED_STUD_RSRV_REG_TIME_ID"];
			entity.OriginalEdStudRsrvRegTimeId = (System.Decimal)dataRow["ED_STUD_RSRV_REG_TIME_ID"];
			entity.EdSemAgendaTimeId = (System.Decimal)dataRow["ED_SEM_AGENDA_TIME_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudRsrvRegTime"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudRsrvRegTime Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudRsrvRegTime entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdSemAgendaTimeIdSource	
			if (CanDeepLoad(entity, "EdSemAgendaTime|EdSemAgendaTimeIdSource", deepLoadType, innerList) 
				&& entity.EdSemAgendaTimeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdSemAgendaTimeId;
				EdSemAgendaTime tmpEntity = EntityManager.LocateEntity<EdSemAgendaTime>(EntityLocator.ConstructKeyFromPkItems(typeof(EdSemAgendaTime), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdSemAgendaTimeIdSource = tmpEntity;
				else
					entity.EdSemAgendaTimeIdSource = DataRepository.EdSemAgendaTimeProvider.GetByEdSemAgendaTimeId(transactionManager, entity.EdSemAgendaTimeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemAgendaTimeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdSemAgendaTimeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdSemAgendaTimeProvider.DeepLoad(transactionManager, entity.EdSemAgendaTimeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdSemAgendaTimeIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudRsrvRegTime object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudRsrvRegTime instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudRsrvRegTime Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudRsrvRegTime entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdSemAgendaTimeIdSource
			if (CanDeepSave(entity, "EdSemAgendaTime|EdSemAgendaTimeIdSource", deepSaveType, innerList) 
				&& entity.EdSemAgendaTimeIdSource != null)
			{
				DataRepository.EdSemAgendaTimeProvider.Save(transactionManager, entity.EdSemAgendaTimeIdSource);
				entity.EdSemAgendaTimeId = entity.EdSemAgendaTimeIdSource.EdSemAgendaTimeId;
			}
			#endregion 
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
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
	
	#region EdStudRsrvRegTimeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudRsrvRegTime</c>
	///</summary>
	public enum EdStudRsrvRegTimeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdSemAgendaTime</c> at EdSemAgendaTimeIdSource
		///</summary>
		[ChildEntityType(typeof(EdSemAgendaTime))]
		EdSemAgendaTime,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
	}
	
	#endregion EdStudRsrvRegTimeChildEntityTypes
	
	#region EdStudRsrvRegTimeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudRsrvRegTimeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudRsrvRegTime"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudRsrvRegTimeFilterBuilder : SqlFilterBuilder<EdStudRsrvRegTimeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudRsrvRegTimeFilterBuilder class.
		/// </summary>
		public EdStudRsrvRegTimeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudRsrvRegTimeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudRsrvRegTimeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudRsrvRegTimeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudRsrvRegTimeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudRsrvRegTimeFilterBuilder
	
	#region EdStudRsrvRegTimeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudRsrvRegTimeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudRsrvRegTime"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudRsrvRegTimeParameterBuilder : ParameterizedSqlFilterBuilder<EdStudRsrvRegTimeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudRsrvRegTimeParameterBuilder class.
		/// </summary>
		public EdStudRsrvRegTimeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudRsrvRegTimeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudRsrvRegTimeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudRsrvRegTimeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudRsrvRegTimeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudRsrvRegTimeParameterBuilder
	
	#region EdStudRsrvRegTimeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudRsrvRegTimeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudRsrvRegTime"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudRsrvRegTimeSortBuilder : SqlSortBuilder<EdStudRsrvRegTimeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudRsrvRegTimeSqlSortBuilder class.
		/// </summary>
		public EdStudRsrvRegTimeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudRsrvRegTimeSortBuilder
	
} // end namespace
