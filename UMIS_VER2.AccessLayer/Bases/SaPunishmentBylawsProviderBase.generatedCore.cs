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
	/// This class is the base class for any <see cref="SaPunishmentBylawsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaPunishmentBylawsProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaPunishmentBylaws, UMIS_VER2.BusinessLyer.SaPunishmentBylawsKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPunishmentBylawsKey key)
		{
			return Delete(transactionManager, key.SaPunishmentBylawsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saPunishmentBylawsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saPunishmentBylawsId)
		{
			return Delete(null, _saPunishmentBylawsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPunishmentBylawsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saPunishmentBylawsId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_034b key.
		///		FK_AUTO_034b Description: 
		/// </summary>
		/// <param name="_staffFlag"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishmentBylaws objects.</returns>
		public TList<SaPunishmentBylaws> GetByStaffFlag(System.Decimal _staffFlag)
		{
			int count = -1;
			return GetByStaffFlag(_staffFlag, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_034b key.
		///		FK_AUTO_034b Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_staffFlag"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishmentBylaws objects.</returns>
		/// <remarks></remarks>
		public TList<SaPunishmentBylaws> GetByStaffFlag(TransactionManager transactionManager, System.Decimal _staffFlag)
		{
			int count = -1;
			return GetByStaffFlag(transactionManager, _staffFlag, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_034b key.
		///		FK_AUTO_034b Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_staffFlag"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishmentBylaws objects.</returns>
		public TList<SaPunishmentBylaws> GetByStaffFlag(TransactionManager transactionManager, System.Decimal _staffFlag, int start, int pageLength)
		{
			int count = -1;
			return GetByStaffFlag(transactionManager, _staffFlag, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_034b key.
		///		fkAuto034b Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_staffFlag"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishmentBylaws objects.</returns>
		public TList<SaPunishmentBylaws> GetByStaffFlag(System.Decimal _staffFlag, int start, int pageLength)
		{
			int count =  -1;
			return GetByStaffFlag(null, _staffFlag, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_034b key.
		///		fkAuto034b Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_staffFlag"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishmentBylaws objects.</returns>
		public TList<SaPunishmentBylaws> GetByStaffFlag(System.Decimal _staffFlag, int start, int pageLength,out int count)
		{
			return GetByStaffFlag(null, _staffFlag, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_034b key.
		///		FK_AUTO_034b Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_staffFlag"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishmentBylaws objects.</returns>
		public abstract TList<SaPunishmentBylaws> GetByStaffFlag(TransactionManager transactionManager, System.Decimal _staffFlag, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_BYLAWS_SA_CODE_PUNISH key.
		///		FK_SA_PUNISHMENT_BYLAWS_SA_CODE_PUNISH Description: 
		/// </summary>
		/// <param name="_saCodePunishId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishmentBylaws objects.</returns>
		public TList<SaPunishmentBylaws> GetBySaCodePunishId(System.Decimal _saCodePunishId)
		{
			int count = -1;
			return GetBySaCodePunishId(_saCodePunishId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_BYLAWS_SA_CODE_PUNISH key.
		///		FK_SA_PUNISHMENT_BYLAWS_SA_CODE_PUNISH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishmentBylaws objects.</returns>
		/// <remarks></remarks>
		public TList<SaPunishmentBylaws> GetBySaCodePunishId(TransactionManager transactionManager, System.Decimal _saCodePunishId)
		{
			int count = -1;
			return GetBySaCodePunishId(transactionManager, _saCodePunishId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_BYLAWS_SA_CODE_PUNISH key.
		///		FK_SA_PUNISHMENT_BYLAWS_SA_CODE_PUNISH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishmentBylaws objects.</returns>
		public TList<SaPunishmentBylaws> GetBySaCodePunishId(TransactionManager transactionManager, System.Decimal _saCodePunishId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodePunishId(transactionManager, _saCodePunishId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_BYLAWS_SA_CODE_PUNISH key.
		///		fkSaPunishmentBylawsSaCodePunish Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodePunishId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishmentBylaws objects.</returns>
		public TList<SaPunishmentBylaws> GetBySaCodePunishId(System.Decimal _saCodePunishId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodePunishId(null, _saCodePunishId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_BYLAWS_SA_CODE_PUNISH key.
		///		fkSaPunishmentBylawsSaCodePunish Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodePunishId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishmentBylaws objects.</returns>
		public TList<SaPunishmentBylaws> GetBySaCodePunishId(System.Decimal _saCodePunishId, int start, int pageLength,out int count)
		{
			return GetBySaCodePunishId(null, _saCodePunishId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_BYLAWS_SA_CODE_PUNISH key.
		///		FK_SA_PUNISHMENT_BYLAWS_SA_CODE_PUNISH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishmentBylaws objects.</returns>
		public abstract TList<SaPunishmentBylaws> GetBySaCodePunishId(TransactionManager transactionManager, System.Decimal _saCodePunishId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaPunishmentBylaws Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPunishmentBylawsKey key, int start, int pageLength)
		{
			return GetBySaPunishmentBylawsId(transactionManager, key.SaPunishmentBylawsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_PUNISHMENT_BYLAWS index.
		/// </summary>
		/// <param name="_saPunishmentBylawsId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPunishmentBylaws"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPunishmentBylaws GetBySaPunishmentBylawsId(System.Decimal _saPunishmentBylawsId)
		{
			int count = -1;
			return GetBySaPunishmentBylawsId(null,_saPunishmentBylawsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUNISHMENT_BYLAWS index.
		/// </summary>
		/// <param name="_saPunishmentBylawsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPunishmentBylaws"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPunishmentBylaws GetBySaPunishmentBylawsId(System.Decimal _saPunishmentBylawsId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPunishmentBylawsId(null, _saPunishmentBylawsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUNISHMENT_BYLAWS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPunishmentBylawsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPunishmentBylaws"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPunishmentBylaws GetBySaPunishmentBylawsId(TransactionManager transactionManager, System.Decimal _saPunishmentBylawsId)
		{
			int count = -1;
			return GetBySaPunishmentBylawsId(transactionManager, _saPunishmentBylawsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUNISHMENT_BYLAWS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPunishmentBylawsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPunishmentBylaws"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPunishmentBylaws GetBySaPunishmentBylawsId(TransactionManager transactionManager, System.Decimal _saPunishmentBylawsId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPunishmentBylawsId(transactionManager, _saPunishmentBylawsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUNISHMENT_BYLAWS index.
		/// </summary>
		/// <param name="_saPunishmentBylawsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPunishmentBylaws"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPunishmentBylaws GetBySaPunishmentBylawsId(System.Decimal _saPunishmentBylawsId, int start, int pageLength, out int count)
		{
			return GetBySaPunishmentBylawsId(null, _saPunishmentBylawsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUNISHMENT_BYLAWS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPunishmentBylawsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPunishmentBylaws"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaPunishmentBylaws GetBySaPunishmentBylawsId(TransactionManager transactionManager, System.Decimal _saPunishmentBylawsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaPunishmentBylaws&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaPunishmentBylaws&gt;"/></returns>
		public static TList<SaPunishmentBylaws> Fill(IDataReader reader, TList<SaPunishmentBylaws> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaPunishmentBylaws c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaPunishmentBylaws")
					.Append("|").Append((System.Decimal)reader["SA_PUNISHMENT_BYLAWS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaPunishmentBylaws>(
					key.ToString(), // EntityTrackingKey
					"SaPunishmentBylaws",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaPunishmentBylaws();
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
					c.SaPunishmentBylawsId = (System.Decimal)reader["SA_PUNISHMENT_BYLAWS_ID"];
					c.OriginalSaPunishmentBylawsId = c.SaPunishmentBylawsId;
					c.PromoPreventPeriod = (System.Decimal)reader["PROMO_PREVENT_PERIOD"];
					c.PunishErasePeriod = (System.Decimal)reader["PUNISH_ERASE_PERIOD"];
					c.SaCodePunishId = (System.Decimal)reader["SA_CODE_PUNISH_ID"];
					c.StaffFlag = (System.Decimal)reader["STAFF_FLAG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaPunishmentBylaws"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPunishmentBylaws"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaPunishmentBylaws entity)
		{
			if (!reader.Read()) return;
			
			entity.SaPunishmentBylawsId = (System.Decimal)reader[((int)SaPunishmentBylawsColumn.SaPunishmentBylawsId - 1)];
			entity.OriginalSaPunishmentBylawsId = (System.Decimal)reader["SA_PUNISHMENT_BYLAWS_ID"];
			entity.PromoPreventPeriod = (System.Decimal)reader[((int)SaPunishmentBylawsColumn.PromoPreventPeriod - 1)];
			entity.PunishErasePeriod = (System.Decimal)reader[((int)SaPunishmentBylawsColumn.PunishErasePeriod - 1)];
			entity.SaCodePunishId = (System.Decimal)reader[((int)SaPunishmentBylawsColumn.SaCodePunishId - 1)];
			entity.StaffFlag = (System.Decimal)reader[((int)SaPunishmentBylawsColumn.StaffFlag - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaPunishmentBylaws"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPunishmentBylaws"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaPunishmentBylaws entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaPunishmentBylawsId = (System.Decimal)dataRow["SA_PUNISHMENT_BYLAWS_ID"];
			entity.OriginalSaPunishmentBylawsId = (System.Decimal)dataRow["SA_PUNISHMENT_BYLAWS_ID"];
			entity.PromoPreventPeriod = (System.Decimal)dataRow["PROMO_PREVENT_PERIOD"];
			entity.PunishErasePeriod = (System.Decimal)dataRow["PUNISH_ERASE_PERIOD"];
			entity.SaCodePunishId = (System.Decimal)dataRow["SA_CODE_PUNISH_ID"];
			entity.StaffFlag = (System.Decimal)dataRow["STAFF_FLAG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPunishmentBylaws"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaPunishmentBylaws Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPunishmentBylaws entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region StaffFlagSource	
			if (CanDeepLoad(entity, "SaCodeStaffType|StaffFlagSource", deepLoadType, innerList) 
				&& entity.StaffFlagSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.StaffFlag;
				SaCodeStaffType tmpEntity = EntityManager.LocateEntity<SaCodeStaffType>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeStaffType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.StaffFlagSource = tmpEntity;
				else
					entity.StaffFlagSource = DataRepository.SaCodeStaffTypeProvider.GetByStaffFlag(transactionManager, entity.StaffFlag);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'StaffFlagSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.StaffFlagSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeStaffTypeProvider.DeepLoad(transactionManager, entity.StaffFlagSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion StaffFlagSource

			#region SaCodePunishIdSource	
			if (CanDeepLoad(entity, "SaCodePunish|SaCodePunishIdSource", deepLoadType, innerList) 
				&& entity.SaCodePunishIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodePunishId;
				SaCodePunish tmpEntity = EntityManager.LocateEntity<SaCodePunish>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodePunish), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodePunishIdSource = tmpEntity;
				else
					entity.SaCodePunishIdSource = DataRepository.SaCodePunishProvider.GetBySaCodePunishId(transactionManager, entity.SaCodePunishId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodePunishIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodePunishIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodePunishProvider.DeepLoad(transactionManager, entity.SaCodePunishIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodePunishIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaPunishmentBylawsId methods when available
			
			#region SaPunishBylawAuthCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPunishBylawAuth>|SaPunishBylawAuthCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPunishBylawAuthCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPunishBylawAuthCollection = DataRepository.SaPunishBylawAuthProvider.GetBySaPunishmentBylawsId(transactionManager, entity.SaPunishmentBylawsId);

				if (deep && entity.SaPunishBylawAuthCollection.Count > 0)
				{
					deepHandles.Add("SaPunishBylawAuthCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPunishBylawAuth>) DataRepository.SaPunishBylawAuthProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPunishBylawAuthCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaPunishmentBylaws object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaPunishmentBylaws instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaPunishmentBylaws Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPunishmentBylaws entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region StaffFlagSource
			if (CanDeepSave(entity, "SaCodeStaffType|StaffFlagSource", deepSaveType, innerList) 
				&& entity.StaffFlagSource != null)
			{
				DataRepository.SaCodeStaffTypeProvider.Save(transactionManager, entity.StaffFlagSource);
				entity.StaffFlag = entity.StaffFlagSource.StaffFlag;
			}
			#endregion 
			
			#region SaCodePunishIdSource
			if (CanDeepSave(entity, "SaCodePunish|SaCodePunishIdSource", deepSaveType, innerList) 
				&& entity.SaCodePunishIdSource != null)
			{
				DataRepository.SaCodePunishProvider.Save(transactionManager, entity.SaCodePunishIdSource);
				entity.SaCodePunishId = entity.SaCodePunishIdSource.SaCodePunishId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaPunishBylawAuth>
				if (CanDeepSave(entity.SaPunishBylawAuthCollection, "List<SaPunishBylawAuth>|SaPunishBylawAuthCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPunishBylawAuth child in entity.SaPunishBylawAuthCollection)
					{
						if(child.SaPunishmentBylawsIdSource != null)
						{
							child.SaPunishmentBylawsId = child.SaPunishmentBylawsIdSource.SaPunishmentBylawsId;
						}
						else
						{
							child.SaPunishmentBylawsId = entity.SaPunishmentBylawsId;
						}

					}

					if (entity.SaPunishBylawAuthCollection.Count > 0 || entity.SaPunishBylawAuthCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPunishBylawAuthProvider.Save(transactionManager, entity.SaPunishBylawAuthCollection);
						
						deepHandles.Add("SaPunishBylawAuthCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPunishBylawAuth >) DataRepository.SaPunishBylawAuthProvider.DeepSave,
							new object[] { transactionManager, entity.SaPunishBylawAuthCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaPunishmentBylawsChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaPunishmentBylaws</c>
	///</summary>
	public enum SaPunishmentBylawsChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeStaffType</c> at StaffFlagSource
		///</summary>
		[ChildEntityType(typeof(SaCodeStaffType))]
		SaCodeStaffType,
		
		///<summary>
		/// Composite Property for <c>SaCodePunish</c> at SaCodePunishIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodePunish))]
		SaCodePunish,
		///<summary>
		/// Collection of <c>SaPunishmentBylaws</c> as OneToMany for SaPunishBylawAuthCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPunishBylawAuth>))]
		SaPunishBylawAuthCollection,
	}
	
	#endregion SaPunishmentBylawsChildEntityTypes
	
	#region SaPunishmentBylawsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaPunishmentBylawsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPunishmentBylaws"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaPunishmentBylawsFilterBuilder : SqlFilterBuilder<SaPunishmentBylawsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPunishmentBylawsFilterBuilder class.
		/// </summary>
		public SaPunishmentBylawsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaPunishmentBylawsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaPunishmentBylawsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaPunishmentBylawsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaPunishmentBylawsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaPunishmentBylawsFilterBuilder
	
	#region SaPunishmentBylawsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaPunishmentBylawsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPunishmentBylaws"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaPunishmentBylawsParameterBuilder : ParameterizedSqlFilterBuilder<SaPunishmentBylawsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPunishmentBylawsParameterBuilder class.
		/// </summary>
		public SaPunishmentBylawsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaPunishmentBylawsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaPunishmentBylawsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaPunishmentBylawsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaPunishmentBylawsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaPunishmentBylawsParameterBuilder
	
	#region SaPunishmentBylawsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaPunishmentBylawsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPunishmentBylaws"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaPunishmentBylawsSortBuilder : SqlSortBuilder<SaPunishmentBylawsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPunishmentBylawsSqlSortBuilder class.
		/// </summary>
		public SaPunishmentBylawsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaPunishmentBylawsSortBuilder
	
} // end namespace
