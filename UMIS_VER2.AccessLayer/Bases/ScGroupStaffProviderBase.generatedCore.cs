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
	/// This class is the base class for any <see cref="ScGroupStaffProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScGroupStaffProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScGroupStaff, UMIS_VER2.BusinessLyer.ScGroupStaffKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScGroupStaffKey key)
		{
			return Delete(transactionManager, key.ScGroupStaffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scGroupStaffId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scGroupStaffId)
		{
			return Delete(null, _scGroupStaffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupStaffId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scGroupStaffId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_STAFF_SA_STF_MEMBER key.
		///		FK_SC_GROUP_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMamberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupStaff objects.</returns>
		public TList<ScGroupStaff> GetBySaStfMamberId(System.Decimal _saStfMamberId)
		{
			int count = -1;
			return GetBySaStfMamberId(_saStfMamberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_STAFF_SA_STF_MEMBER key.
		///		FK_SC_GROUP_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMamberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupStaff objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupStaff> GetBySaStfMamberId(TransactionManager transactionManager, System.Decimal _saStfMamberId)
		{
			int count = -1;
			return GetBySaStfMamberId(transactionManager, _saStfMamberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_STAFF_SA_STF_MEMBER key.
		///		FK_SC_GROUP_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMamberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupStaff objects.</returns>
		public TList<ScGroupStaff> GetBySaStfMamberId(TransactionManager transactionManager, System.Decimal _saStfMamberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMamberId(transactionManager, _saStfMamberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_STAFF_SA_STF_MEMBER key.
		///		fkScGroupStaffSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMamberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupStaff objects.</returns>
		public TList<ScGroupStaff> GetBySaStfMamberId(System.Decimal _saStfMamberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMamberId(null, _saStfMamberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_STAFF_SA_STF_MEMBER key.
		///		fkScGroupStaffSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMamberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupStaff objects.</returns>
		public TList<ScGroupStaff> GetBySaStfMamberId(System.Decimal _saStfMamberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMamberId(null, _saStfMamberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_STAFF_SA_STF_MEMBER key.
		///		FK_SC_GROUP_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMamberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupStaff objects.</returns>
		public abstract TList<ScGroupStaff> GetBySaStfMamberId(TransactionManager transactionManager, System.Decimal _saStfMamberId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_STAFF_SC_GROUP_DAY key.
		///		FK_SC_GROUP_STAFF_SC_GROUP_DAY Description: 
		/// </summary>
		/// <param name="_scGroupDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupStaff objects.</returns>
		public TList<ScGroupStaff> GetByScGroupDayId(System.Decimal _scGroupDayId)
		{
			int count = -1;
			return GetByScGroupDayId(_scGroupDayId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_STAFF_SC_GROUP_DAY key.
		///		FK_SC_GROUP_STAFF_SC_GROUP_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupStaff objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupStaff> GetByScGroupDayId(TransactionManager transactionManager, System.Decimal _scGroupDayId)
		{
			int count = -1;
			return GetByScGroupDayId(transactionManager, _scGroupDayId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_STAFF_SC_GROUP_DAY key.
		///		FK_SC_GROUP_STAFF_SC_GROUP_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupStaff objects.</returns>
		public TList<ScGroupStaff> GetByScGroupDayId(TransactionManager transactionManager, System.Decimal _scGroupDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByScGroupDayId(transactionManager, _scGroupDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_STAFF_SC_GROUP_DAY key.
		///		fkScGroupStaffScGroupDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scGroupDayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupStaff objects.</returns>
		public TList<ScGroupStaff> GetByScGroupDayId(System.Decimal _scGroupDayId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScGroupDayId(null, _scGroupDayId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_STAFF_SC_GROUP_DAY key.
		///		fkScGroupStaffScGroupDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scGroupDayId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupStaff objects.</returns>
		public TList<ScGroupStaff> GetByScGroupDayId(System.Decimal _scGroupDayId, int start, int pageLength,out int count)
		{
			return GetByScGroupDayId(null, _scGroupDayId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_STAFF_SC_GROUP_DAY key.
		///		FK_SC_GROUP_STAFF_SC_GROUP_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupStaff objects.</returns>
		public abstract TList<ScGroupStaff> GetByScGroupDayId(TransactionManager transactionManager, System.Decimal _scGroupDayId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScGroupStaff Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScGroupStaffKey key, int start, int pageLength)
		{
			return GetByScGroupStaffId(transactionManager, key.ScGroupStaffId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_GROUP_STAFF index.
		/// </summary>
		/// <param name="_scGroupStaffId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupStaff GetByScGroupStaffId(System.Decimal _scGroupStaffId)
		{
			int count = -1;
			return GetByScGroupStaffId(null,_scGroupStaffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_GROUP_STAFF index.
		/// </summary>
		/// <param name="_scGroupStaffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupStaff GetByScGroupStaffId(System.Decimal _scGroupStaffId, int start, int pageLength)
		{
			int count = -1;
			return GetByScGroupStaffId(null, _scGroupStaffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_GROUP_STAFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupStaffId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupStaff GetByScGroupStaffId(TransactionManager transactionManager, System.Decimal _scGroupStaffId)
		{
			int count = -1;
			return GetByScGroupStaffId(transactionManager, _scGroupStaffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_GROUP_STAFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupStaffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupStaff GetByScGroupStaffId(TransactionManager transactionManager, System.Decimal _scGroupStaffId, int start, int pageLength)
		{
			int count = -1;
			return GetByScGroupStaffId(transactionManager, _scGroupStaffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_GROUP_STAFF index.
		/// </summary>
		/// <param name="_scGroupStaffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupStaff GetByScGroupStaffId(System.Decimal _scGroupStaffId, int start, int pageLength, out int count)
		{
			return GetByScGroupStaffId(null, _scGroupStaffId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_GROUP_STAFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupStaffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupStaff"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScGroupStaff GetByScGroupStaffId(TransactionManager transactionManager, System.Decimal _scGroupStaffId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScGroupStaff&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScGroupStaff&gt;"/></returns>
		public static TList<ScGroupStaff> Fill(IDataReader reader, TList<ScGroupStaff> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScGroupStaff c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScGroupStaff")
					.Append("|").Append((System.Decimal)reader["SC_GROUP_STAFF_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScGroupStaff>(
					key.ToString(), // EntityTrackingKey
					"ScGroupStaff",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScGroupStaff();
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
					c.ScGroupStaffId = (System.Decimal)reader["SC_GROUP_STAFF_ID"];
					c.OriginalScGroupStaffId = c.ScGroupStaffId;
					c.ScGroupDayId = (System.Decimal)reader["SC_GROUP_DAY_ID"];
					c.SaStfMamberId = (System.Decimal)reader["SA_STF_MAMBER_ID"];
					c.StfRoleFlg = Convert.IsDBNull(reader["STF_ROLE_FLG"]) ? null : (System.Decimal?)reader["STF_ROLE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScGroupStaff"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScGroupStaff"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScGroupStaff entity)
		{
			if (!reader.Read()) return;
			
			entity.ScGroupStaffId = (System.Decimal)reader[((int)ScGroupStaffColumn.ScGroupStaffId - 1)];
			entity.OriginalScGroupStaffId = (System.Decimal)reader["SC_GROUP_STAFF_ID"];
			entity.ScGroupDayId = (System.Decimal)reader[((int)ScGroupStaffColumn.ScGroupDayId - 1)];
			entity.SaStfMamberId = (System.Decimal)reader[((int)ScGroupStaffColumn.SaStfMamberId - 1)];
			entity.StfRoleFlg = (reader.IsDBNull(((int)ScGroupStaffColumn.StfRoleFlg - 1)))?null:(System.Decimal?)reader[((int)ScGroupStaffColumn.StfRoleFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScGroupStaff"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScGroupStaff"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScGroupStaff entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScGroupStaffId = (System.Decimal)dataRow["SC_GROUP_STAFF_ID"];
			entity.OriginalScGroupStaffId = (System.Decimal)dataRow["SC_GROUP_STAFF_ID"];
			entity.ScGroupDayId = (System.Decimal)dataRow["SC_GROUP_DAY_ID"];
			entity.SaStfMamberId = (System.Decimal)dataRow["SA_STF_MAMBER_ID"];
			entity.StfRoleFlg = Convert.IsDBNull(dataRow["STF_ROLE_FLG"]) ? null : (System.Decimal?)dataRow["STF_ROLE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScGroupStaff"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScGroupStaff Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScGroupStaff entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaStfMamberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMamberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMamberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaStfMamberId;
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMamberIdSource = tmpEntity;
				else
					entity.SaStfMamberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMamberId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMamberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMamberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMamberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMamberIdSource

			#region ScGroupDayIdSource	
			if (CanDeepLoad(entity, "ScGroupDay|ScGroupDayIdSource", deepLoadType, innerList) 
				&& entity.ScGroupDayIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScGroupDayId;
				ScGroupDay tmpEntity = EntityManager.LocateEntity<ScGroupDay>(EntityLocator.ConstructKeyFromPkItems(typeof(ScGroupDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScGroupDayIdSource = tmpEntity;
				else
					entity.ScGroupDayIdSource = DataRepository.ScGroupDayProvider.GetByScGroupDayId(transactionManager, entity.ScGroupDayId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupDayIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScGroupDayIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScGroupDayProvider.DeepLoad(transactionManager, entity.ScGroupDayIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScGroupDayIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScGroupStaff object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScGroupStaff instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScGroupStaff Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScGroupStaff entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaStfMamberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMamberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMamberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMamberIdSource);
				entity.SaStfMamberId = entity.SaStfMamberIdSource.SaStfMemberId;
			}
			#endregion 
			
			#region ScGroupDayIdSource
			if (CanDeepSave(entity, "ScGroupDay|ScGroupDayIdSource", deepSaveType, innerList) 
				&& entity.ScGroupDayIdSource != null)
			{
				DataRepository.ScGroupDayProvider.Save(transactionManager, entity.ScGroupDayIdSource);
				entity.ScGroupDayId = entity.ScGroupDayIdSource.ScGroupDayId;
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
	
	#region ScGroupStaffChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScGroupStaff</c>
	///</summary>
	public enum ScGroupStaffChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMamberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>ScGroupDay</c> at ScGroupDayIdSource
		///</summary>
		[ChildEntityType(typeof(ScGroupDay))]
		ScGroupDay,
	}
	
	#endregion ScGroupStaffChildEntityTypes
	
	#region ScGroupStaffFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScGroupStaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScGroupStaff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScGroupStaffFilterBuilder : SqlFilterBuilder<ScGroupStaffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScGroupStaffFilterBuilder class.
		/// </summary>
		public ScGroupStaffFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScGroupStaffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScGroupStaffFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScGroupStaffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScGroupStaffFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScGroupStaffFilterBuilder
	
	#region ScGroupStaffParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScGroupStaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScGroupStaff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScGroupStaffParameterBuilder : ParameterizedSqlFilterBuilder<ScGroupStaffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScGroupStaffParameterBuilder class.
		/// </summary>
		public ScGroupStaffParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScGroupStaffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScGroupStaffParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScGroupStaffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScGroupStaffParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScGroupStaffParameterBuilder
	
	#region ScGroupStaffSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScGroupStaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScGroupStaff"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScGroupStaffSortBuilder : SqlSortBuilder<ScGroupStaffColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScGroupStaffSqlSortBuilder class.
		/// </summary>
		public ScGroupStaffSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScGroupStaffSortBuilder
	
} // end namespace
