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
	/// This class is the base class for any <see cref="CoSupervisorStudCountProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoSupervisorStudCountProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CoSupervisorStudCount, UMIS_VER2.BusinessLyer.CoSupervisorStudCountKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoSupervisorStudCountKey key)
		{
			return Delete(transactionManager, key.CoSupervisorStudCountId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_coSupervisorStudCountId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _coSupervisorStudCountId)
		{
			return Delete(null, _coSupervisorStudCountId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coSupervisorStudCountId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _coSupervisorStudCountId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_SUPERVISOR_STUD_COUNT_CO_CONTROL key.
		///		FK_CO_SUPERVISOR_STUD_COUNT_CO_CONTROL Description: 
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoSupervisorStudCount objects.</returns>
		public TList<CoSupervisorStudCount> GetByCoControlId(System.Decimal _coControlId)
		{
			int count = -1;
			return GetByCoControlId(_coControlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_SUPERVISOR_STUD_COUNT_CO_CONTROL key.
		///		FK_CO_SUPERVISOR_STUD_COUNT_CO_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoSupervisorStudCount objects.</returns>
		/// <remarks></remarks>
		public TList<CoSupervisorStudCount> GetByCoControlId(TransactionManager transactionManager, System.Decimal _coControlId)
		{
			int count = -1;
			return GetByCoControlId(transactionManager, _coControlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_SUPERVISOR_STUD_COUNT_CO_CONTROL key.
		///		FK_CO_SUPERVISOR_STUD_COUNT_CO_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoSupervisorStudCount objects.</returns>
		public TList<CoSupervisorStudCount> GetByCoControlId(TransactionManager transactionManager, System.Decimal _coControlId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlId(transactionManager, _coControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_SUPERVISOR_STUD_COUNT_CO_CONTROL key.
		///		fkCoSupervisorStudCountCoControl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coControlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoSupervisorStudCount objects.</returns>
		public TList<CoSupervisorStudCount> GetByCoControlId(System.Decimal _coControlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCoControlId(null, _coControlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_SUPERVISOR_STUD_COUNT_CO_CONTROL key.
		///		fkCoSupervisorStudCountCoControl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coControlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoSupervisorStudCount objects.</returns>
		public TList<CoSupervisorStudCount> GetByCoControlId(System.Decimal _coControlId, int start, int pageLength,out int count)
		{
			return GetByCoControlId(null, _coControlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_SUPERVISOR_STUD_COUNT_CO_CONTROL key.
		///		FK_CO_SUPERVISOR_STUD_COUNT_CO_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoSupervisorStudCount objects.</returns>
		public abstract TList<CoSupervisorStudCount> GetByCoControlId(TransactionManager transactionManager, System.Decimal _coControlId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.CoSupervisorStudCount Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoSupervisorStudCountKey key, int start, int pageLength)
		{
			return GetByCoSupervisorStudCountId(transactionManager, key.CoSupervisorStudCountId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CO_SUPERVISOR_COUNNT_RULE index.
		/// </summary>
		/// <param name="_coSupervisorStudCountId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoSupervisorStudCount"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoSupervisorStudCount GetByCoSupervisorStudCountId(System.Decimal _coSupervisorStudCountId)
		{
			int count = -1;
			return GetByCoSupervisorStudCountId(null,_coSupervisorStudCountId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_SUPERVISOR_COUNNT_RULE index.
		/// </summary>
		/// <param name="_coSupervisorStudCountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoSupervisorStudCount"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoSupervisorStudCount GetByCoSupervisorStudCountId(System.Decimal _coSupervisorStudCountId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoSupervisorStudCountId(null, _coSupervisorStudCountId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_SUPERVISOR_COUNNT_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coSupervisorStudCountId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoSupervisorStudCount"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoSupervisorStudCount GetByCoSupervisorStudCountId(TransactionManager transactionManager, System.Decimal _coSupervisorStudCountId)
		{
			int count = -1;
			return GetByCoSupervisorStudCountId(transactionManager, _coSupervisorStudCountId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_SUPERVISOR_COUNNT_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coSupervisorStudCountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoSupervisorStudCount"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoSupervisorStudCount GetByCoSupervisorStudCountId(TransactionManager transactionManager, System.Decimal _coSupervisorStudCountId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoSupervisorStudCountId(transactionManager, _coSupervisorStudCountId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_SUPERVISOR_COUNNT_RULE index.
		/// </summary>
		/// <param name="_coSupervisorStudCountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoSupervisorStudCount"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoSupervisorStudCount GetByCoSupervisorStudCountId(System.Decimal _coSupervisorStudCountId, int start, int pageLength, out int count)
		{
			return GetByCoSupervisorStudCountId(null, _coSupervisorStudCountId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_SUPERVISOR_COUNNT_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coSupervisorStudCountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoSupervisorStudCount"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoSupervisorStudCount GetByCoSupervisorStudCountId(TransactionManager transactionManager, System.Decimal _coSupervisorStudCountId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_CO_SUPERVISOR_STUD_COUNT index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <param name="_studCount"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoSupervisorStudCount"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoSupervisorStudCount GetByCoControlIdStudCount(System.Decimal _coControlId, System.Decimal? _studCount)
		{
			int count = -1;
			return GetByCoControlIdStudCount(null,_coControlId, _studCount, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_SUPERVISOR_STUD_COUNT index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <param name="_studCount"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoSupervisorStudCount"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoSupervisorStudCount GetByCoControlIdStudCount(System.Decimal _coControlId, System.Decimal? _studCount, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlIdStudCount(null, _coControlId, _studCount, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_SUPERVISOR_STUD_COUNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="_studCount"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoSupervisorStudCount"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoSupervisorStudCount GetByCoControlIdStudCount(TransactionManager transactionManager, System.Decimal _coControlId, System.Decimal? _studCount)
		{
			int count = -1;
			return GetByCoControlIdStudCount(transactionManager, _coControlId, _studCount, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_SUPERVISOR_STUD_COUNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="_studCount"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoSupervisorStudCount"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoSupervisorStudCount GetByCoControlIdStudCount(TransactionManager transactionManager, System.Decimal _coControlId, System.Decimal? _studCount, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlIdStudCount(transactionManager, _coControlId, _studCount, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_SUPERVISOR_STUD_COUNT index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <param name="_studCount"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoSupervisorStudCount"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoSupervisorStudCount GetByCoControlIdStudCount(System.Decimal _coControlId, System.Decimal? _studCount, int start, int pageLength, out int count)
		{
			return GetByCoControlIdStudCount(null, _coControlId, _studCount, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_SUPERVISOR_STUD_COUNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="_studCount"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoSupervisorStudCount"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoSupervisorStudCount GetByCoControlIdStudCount(TransactionManager transactionManager, System.Decimal _coControlId, System.Decimal? _studCount, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoSupervisorStudCount&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoSupervisorStudCount&gt;"/></returns>
		public static TList<CoSupervisorStudCount> Fill(IDataReader reader, TList<CoSupervisorStudCount> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CoSupervisorStudCount c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoSupervisorStudCount")
					.Append("|").Append((System.Decimal)reader["CO_SUPERVISOR_STUD_COUNT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CoSupervisorStudCount>(
					key.ToString(), // EntityTrackingKey
					"CoSupervisorStudCount",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CoSupervisorStudCount();
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
					c.CoSupervisorStudCountId = (System.Decimal)reader["CO_SUPERVISOR_STUD_COUNT_ID"];
					c.OriginalCoSupervisorStudCountId = c.CoSupervisorStudCountId;
					c.CoControlId = (System.Decimal)reader["CO_CONTROL_ID"];
					c.StudCount = Convert.IsDBNull(reader["STUD_COUNT"]) ? null : (System.Decimal?)reader["STUD_COUNT"];
					c.SupervisorCount = Convert.IsDBNull(reader["SUPERVISOR_COUNT"]) ? null : (System.Decimal?)reader["SUPERVISOR_COUNT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoSupervisorStudCount"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoSupervisorStudCount"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CoSupervisorStudCount entity)
		{
			if (!reader.Read()) return;
			
			entity.CoSupervisorStudCountId = (System.Decimal)reader[((int)CoSupervisorStudCountColumn.CoSupervisorStudCountId - 1)];
			entity.OriginalCoSupervisorStudCountId = (System.Decimal)reader["CO_SUPERVISOR_STUD_COUNT_ID"];
			entity.CoControlId = (System.Decimal)reader[((int)CoSupervisorStudCountColumn.CoControlId - 1)];
			entity.StudCount = (reader.IsDBNull(((int)CoSupervisorStudCountColumn.StudCount - 1)))?null:(System.Decimal?)reader[((int)CoSupervisorStudCountColumn.StudCount - 1)];
			entity.SupervisorCount = (reader.IsDBNull(((int)CoSupervisorStudCountColumn.SupervisorCount - 1)))?null:(System.Decimal?)reader[((int)CoSupervisorStudCountColumn.SupervisorCount - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoSupervisorStudCount"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoSupervisorStudCount"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CoSupervisorStudCount entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CoSupervisorStudCountId = (System.Decimal)dataRow["CO_SUPERVISOR_STUD_COUNT_ID"];
			entity.OriginalCoSupervisorStudCountId = (System.Decimal)dataRow["CO_SUPERVISOR_STUD_COUNT_ID"];
			entity.CoControlId = (System.Decimal)dataRow["CO_CONTROL_ID"];
			entity.StudCount = Convert.IsDBNull(dataRow["STUD_COUNT"]) ? null : (System.Decimal?)dataRow["STUD_COUNT"];
			entity.SupervisorCount = Convert.IsDBNull(dataRow["SUPERVISOR_COUNT"]) ? null : (System.Decimal?)dataRow["SUPERVISOR_COUNT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoSupervisorStudCount"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoSupervisorStudCount Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoSupervisorStudCount entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region CoSupervisorStudCountIdSource	
			if (CanDeepLoad(entity, "CoSupervisorStudCount|CoSupervisorStudCountIdSource", deepLoadType, innerList) 
				&& entity.CoSupervisorStudCountIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CoSupervisorStudCountId;
				CoSupervisorStudCount tmpEntity = EntityManager.LocateEntity<CoSupervisorStudCount>(EntityLocator.ConstructKeyFromPkItems(typeof(CoSupervisorStudCount), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CoSupervisorStudCountIdSource = tmpEntity;
				else
					entity.CoSupervisorStudCountIdSource = DataRepository.CoSupervisorStudCountProvider.GetByCoSupervisorStudCountId(transactionManager, entity.CoSupervisorStudCountId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoSupervisorStudCountIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CoSupervisorStudCountIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CoSupervisorStudCountProvider.DeepLoad(transactionManager, entity.CoSupervisorStudCountIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CoSupervisorStudCountIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByCoSupervisorStudCountId methods when available
			
			#region CoSupervisorStudCount
			// RelationshipType.OneToOne
			if (CanDeepLoad(entity, "CoSupervisorStudCount|CoSupervisorStudCount", deepLoadType, innerList))
			{
				entity.CoSupervisorStudCount = DataRepository.CoSupervisorStudCountProvider.GetByCoSupervisorStudCountId(transactionManager, entity.CoSupervisorStudCountId);
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoSupervisorStudCount' loaded. key " + entity.EntityTrackingKey);
				#endif 

				if (deep && entity.CoSupervisorStudCount != null)
				{
					deepHandles.Add("CoSupervisorStudCount",
						new KeyValuePair<Delegate, object>((DeepLoadSingleHandle< CoSupervisorStudCount >) DataRepository.CoSupervisorStudCountProvider.DeepLoad,
						new object[] { transactionManager, entity.CoSupervisorStudCount, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CoSupervisorStudCount object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CoSupervisorStudCount instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoSupervisorStudCount Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoSupervisorStudCount entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region CoSupervisorStudCountIdSource
			if (CanDeepSave(entity, "CoSupervisorStudCount|CoSupervisorStudCountIdSource", deepSaveType, innerList) 
				&& entity.CoSupervisorStudCountIdSource != null)
			{
				DataRepository.CoSupervisorStudCountProvider.Save(transactionManager, entity.CoSupervisorStudCountIdSource);
				entity.CoSupervisorStudCountId = entity.CoSupervisorStudCountIdSource.CoSupervisorStudCountId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();

			#region CoSupervisorStudCount
			if (CanDeepSave(entity.CoSupervisorStudCount, "CoSupervisorStudCount|CoSupervisorStudCount", deepSaveType, innerList))
			{

				if (entity.CoSupervisorStudCount != null)
				{
					// update each child parent id with the real parent id (mostly used on insert)

					entity.CoSupervisorStudCount.CoSupervisorStudCountId = entity.CoSupervisorStudCountId;
					//DataRepository.CoSupervisorStudCountProvider.Save(transactionManager, entity.CoSupervisorStudCount);
					deepHandles.Add("CoSupervisorStudCount",
						new KeyValuePair<Delegate, object>((DeepSaveSingleHandle< CoSupervisorStudCount >) DataRepository.CoSupervisorStudCountProvider.DeepSave,
						new object[] { transactionManager, entity.CoSupervisorStudCount, deepSaveType, childTypes, innerList }
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
	
	#region CoSupervisorStudCountChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CoSupervisorStudCount</c>
	///</summary>
	public enum CoSupervisorStudCountChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CoControl</c> at CoControlIdSource
		///</summary>
		[ChildEntityType(typeof(CoControl))]
		CoControl,
		
		///<summary>
		/// Composite Property for <c>CoSupervisorStudCount</c> at CoSupervisorStudCountIdSource
		///</summary>
		[ChildEntityType(typeof(CoSupervisorStudCount))]
		CoSupervisorStudCount,
	}
	
	#endregion CoSupervisorStudCountChildEntityTypes
	
	#region CoSupervisorStudCountFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoSupervisorStudCountColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoSupervisorStudCount"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoSupervisorStudCountFilterBuilder : SqlFilterBuilder<CoSupervisorStudCountColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoSupervisorStudCountFilterBuilder class.
		/// </summary>
		public CoSupervisorStudCountFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoSupervisorStudCountFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoSupervisorStudCountFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoSupervisorStudCountFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoSupervisorStudCountFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoSupervisorStudCountFilterBuilder
	
	#region CoSupervisorStudCountParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoSupervisorStudCountColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoSupervisorStudCount"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoSupervisorStudCountParameterBuilder : ParameterizedSqlFilterBuilder<CoSupervisorStudCountColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoSupervisorStudCountParameterBuilder class.
		/// </summary>
		public CoSupervisorStudCountParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoSupervisorStudCountParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoSupervisorStudCountParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoSupervisorStudCountParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoSupervisorStudCountParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoSupervisorStudCountParameterBuilder
	
	#region CoSupervisorStudCountSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoSupervisorStudCountColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoSupervisorStudCount"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoSupervisorStudCountSortBuilder : SqlSortBuilder<CoSupervisorStudCountColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoSupervisorStudCountSqlSortBuilder class.
		/// </summary>
		public CoSupervisorStudCountSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoSupervisorStudCountSortBuilder
	
} // end namespace
