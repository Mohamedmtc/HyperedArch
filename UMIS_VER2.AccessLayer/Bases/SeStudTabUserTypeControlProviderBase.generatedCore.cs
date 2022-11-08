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
	/// This class is the base class for any <see cref="SeStudTabUserTypeControlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeStudTabUserTypeControlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl, UMIS_VER2.BusinessLyer.SeStudTabUserTypeControlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeStudTabUserTypeControlKey key)
		{
			return Delete(transactionManager, key.SeStudTabUserTypeControlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seStudTabUserTypeControlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seStudTabUserTypeControlId)
		{
			return Delete(null, _seStudTabUserTypeControlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seStudTabUserTypeControlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seStudTabUserTypeControlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_CODE_USER_TYPE key.
		///		FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="_seCodeUserTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl objects.</returns>
		public TList<SeStudTabUserTypeControl> GetBySeCodeUserTypeId(System.Decimal _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(_seCodeUserTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_CODE_USER_TYPE key.
		///		FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl objects.</returns>
		/// <remarks></remarks>
		public TList<SeStudTabUserTypeControl> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_CODE_USER_TYPE key.
		///		FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl objects.</returns>
		public TList<SeStudTabUserTypeControl> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_CODE_USER_TYPE key.
		///		fkSeStudTabUserTypeControlSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl objects.</returns>
		public TList<SeStudTabUserTypeControl> GetBySeCodeUserTypeId(System.Decimal _seCodeUserTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_CODE_USER_TYPE key.
		///		fkSeStudTabUserTypeControlSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl objects.</returns>
		public TList<SeStudTabUserTypeControl> GetBySeCodeUserTypeId(System.Decimal _seCodeUserTypeId, int start, int pageLength,out int count)
		{
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_CODE_USER_TYPE key.
		///		FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl objects.</returns>
		public abstract TList<SeStudTabUserTypeControl> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_STUD_TAB_CONTROL key.
		///		FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_STUD_TAB_CONTROL Description: 
		/// </summary>
		/// <param name="_seStudTabControlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl objects.</returns>
		public TList<SeStudTabUserTypeControl> GetBySeStudTabControlId(System.Decimal _seStudTabControlId)
		{
			int count = -1;
			return GetBySeStudTabControlId(_seStudTabControlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_STUD_TAB_CONTROL key.
		///		FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_STUD_TAB_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seStudTabControlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl objects.</returns>
		/// <remarks></remarks>
		public TList<SeStudTabUserTypeControl> GetBySeStudTabControlId(TransactionManager transactionManager, System.Decimal _seStudTabControlId)
		{
			int count = -1;
			return GetBySeStudTabControlId(transactionManager, _seStudTabControlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_STUD_TAB_CONTROL key.
		///		FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_STUD_TAB_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seStudTabControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl objects.</returns>
		public TList<SeStudTabUserTypeControl> GetBySeStudTabControlId(TransactionManager transactionManager, System.Decimal _seStudTabControlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeStudTabControlId(transactionManager, _seStudTabControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_STUD_TAB_CONTROL key.
		///		fkSeStudTabUserTypeControlSeStudTabControl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seStudTabControlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl objects.</returns>
		public TList<SeStudTabUserTypeControl> GetBySeStudTabControlId(System.Decimal _seStudTabControlId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeStudTabControlId(null, _seStudTabControlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_STUD_TAB_CONTROL key.
		///		fkSeStudTabUserTypeControlSeStudTabControl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seStudTabControlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl objects.</returns>
		public TList<SeStudTabUserTypeControl> GetBySeStudTabControlId(System.Decimal _seStudTabControlId, int start, int pageLength,out int count)
		{
			return GetBySeStudTabControlId(null, _seStudTabControlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_STUD_TAB_CONTROL key.
		///		FK_SE_STUD_TAB_USER_TYPE_CONTROL_SE_STUD_TAB_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seStudTabControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl objects.</returns>
		public abstract TList<SeStudTabUserTypeControl> GetBySeStudTabControlId(TransactionManager transactionManager, System.Decimal _seStudTabControlId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeStudTabUserTypeControlKey key, int start, int pageLength)
		{
			return GetBySeStudTabUserTypeControlId(transactionManager, key.SeStudTabUserTypeControlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_STUD_TAB_USER_TYPE_CONTROL index.
		/// </summary>
		/// <param name="_seStudTabUserTypeControlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl GetBySeStudTabUserTypeControlId(System.Decimal _seStudTabUserTypeControlId)
		{
			int count = -1;
			return GetBySeStudTabUserTypeControlId(null,_seStudTabUserTypeControlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_STUD_TAB_USER_TYPE_CONTROL index.
		/// </summary>
		/// <param name="_seStudTabUserTypeControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl GetBySeStudTabUserTypeControlId(System.Decimal _seStudTabUserTypeControlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeStudTabUserTypeControlId(null, _seStudTabUserTypeControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_STUD_TAB_USER_TYPE_CONTROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seStudTabUserTypeControlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl GetBySeStudTabUserTypeControlId(TransactionManager transactionManager, System.Decimal _seStudTabUserTypeControlId)
		{
			int count = -1;
			return GetBySeStudTabUserTypeControlId(transactionManager, _seStudTabUserTypeControlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_STUD_TAB_USER_TYPE_CONTROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seStudTabUserTypeControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl GetBySeStudTabUserTypeControlId(TransactionManager transactionManager, System.Decimal _seStudTabUserTypeControlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeStudTabUserTypeControlId(transactionManager, _seStudTabUserTypeControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_STUD_TAB_USER_TYPE_CONTROL index.
		/// </summary>
		/// <param name="_seStudTabUserTypeControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl GetBySeStudTabUserTypeControlId(System.Decimal _seStudTabUserTypeControlId, int start, int pageLength, out int count)
		{
			return GetBySeStudTabUserTypeControlId(null, _seStudTabUserTypeControlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_STUD_TAB_USER_TYPE_CONTROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seStudTabUserTypeControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl GetBySeStudTabUserTypeControlId(TransactionManager transactionManager, System.Decimal _seStudTabUserTypeControlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeStudTabUserTypeControl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeStudTabUserTypeControl&gt;"/></returns>
		public static TList<SeStudTabUserTypeControl> Fill(IDataReader reader, TList<SeStudTabUserTypeControl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeStudTabUserTypeControl")
					.Append("|").Append((System.Decimal)reader["SE_STUD_TAB_USER_TYPE_CONTROL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeStudTabUserTypeControl>(
					key.ToString(), // EntityTrackingKey
					"SeStudTabUserTypeControl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl();
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
					c.SeStudTabUserTypeControlId = (System.Decimal)reader["SE_STUD_TAB_USER_TYPE_CONTROL_ID"];
					c.OriginalSeStudTabUserTypeControlId = c.SeStudTabUserTypeControlId;
					c.SeCodeUserTypeId = (System.Decimal)reader["SE_CODE_USER_TYPE_ID"];
					c.SeStudTabControlId = (System.Decimal)reader["SE_STUD_TAB_CONTROL_ID"];
					c.ViewFlg = Convert.IsDBNull(reader["VIEW_FLG"]) ? null : (System.Boolean?)reader["VIEW_FLG"];
					c.EditFlg = Convert.IsDBNull(reader["EDIT_FLG"]) ? null : (System.Boolean?)reader["EDIT_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl entity)
		{
			if (!reader.Read()) return;
			
			entity.SeStudTabUserTypeControlId = (System.Decimal)reader[((int)SeStudTabUserTypeControlColumn.SeStudTabUserTypeControlId - 1)];
			entity.OriginalSeStudTabUserTypeControlId = (System.Decimal)reader["SE_STUD_TAB_USER_TYPE_CONTROL_ID"];
			entity.SeCodeUserTypeId = (System.Decimal)reader[((int)SeStudTabUserTypeControlColumn.SeCodeUserTypeId - 1)];
			entity.SeStudTabControlId = (System.Decimal)reader[((int)SeStudTabUserTypeControlColumn.SeStudTabControlId - 1)];
			entity.ViewFlg = (reader.IsDBNull(((int)SeStudTabUserTypeControlColumn.ViewFlg - 1)))?null:(System.Boolean?)reader[((int)SeStudTabUserTypeControlColumn.ViewFlg - 1)];
			entity.EditFlg = (reader.IsDBNull(((int)SeStudTabUserTypeControlColumn.EditFlg - 1)))?null:(System.Boolean?)reader[((int)SeStudTabUserTypeControlColumn.EditFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeStudTabUserTypeControlId = (System.Decimal)dataRow["SE_STUD_TAB_USER_TYPE_CONTROL_ID"];
			entity.OriginalSeStudTabUserTypeControlId = (System.Decimal)dataRow["SE_STUD_TAB_USER_TYPE_CONTROL_ID"];
			entity.SeCodeUserTypeId = (System.Decimal)dataRow["SE_CODE_USER_TYPE_ID"];
			entity.SeStudTabControlId = (System.Decimal)dataRow["SE_STUD_TAB_CONTROL_ID"];
			entity.ViewFlg = Convert.IsDBNull(dataRow["VIEW_FLG"]) ? null : (System.Boolean?)dataRow["VIEW_FLG"];
			entity.EditFlg = Convert.IsDBNull(dataRow["EDIT_FLG"]) ? null : (System.Boolean?)dataRow["EDIT_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SeCodeUserTypeIdSource	
			if (CanDeepLoad(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepLoadType, innerList) 
				&& entity.SeCodeUserTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeCodeUserTypeId;
				SeCodeUserType tmpEntity = EntityManager.LocateEntity<SeCodeUserType>(EntityLocator.ConstructKeyFromPkItems(typeof(SeCodeUserType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeCodeUserTypeIdSource = tmpEntity;
				else
					entity.SeCodeUserTypeIdSource = DataRepository.SeCodeUserTypeProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeCodeUserTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeCodeUserTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeCodeUserTypeProvider.DeepLoad(transactionManager, entity.SeCodeUserTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeCodeUserTypeIdSource

			#region SeStudTabControlIdSource	
			if (CanDeepLoad(entity, "SeStudTabControl|SeStudTabControlIdSource", deepLoadType, innerList) 
				&& entity.SeStudTabControlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeStudTabControlId;
				SeStudTabControl tmpEntity = EntityManager.LocateEntity<SeStudTabControl>(EntityLocator.ConstructKeyFromPkItems(typeof(SeStudTabControl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeStudTabControlIdSource = tmpEntity;
				else
					entity.SeStudTabControlIdSource = DataRepository.SeStudTabControlProvider.GetBySeStudTabControlId(transactionManager, entity.SeStudTabControlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeStudTabControlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeStudTabControlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeStudTabControlProvider.DeepLoad(transactionManager, entity.SeStudTabControlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeStudTabControlIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SeCodeUserTypeIdSource
			if (CanDeepSave(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepSaveType, innerList) 
				&& entity.SeCodeUserTypeIdSource != null)
			{
				DataRepository.SeCodeUserTypeProvider.Save(transactionManager, entity.SeCodeUserTypeIdSource);
				entity.SeCodeUserTypeId = entity.SeCodeUserTypeIdSource.SeCodeUserTypeId;
			}
			#endregion 
			
			#region SeStudTabControlIdSource
			if (CanDeepSave(entity, "SeStudTabControl|SeStudTabControlIdSource", deepSaveType, innerList) 
				&& entity.SeStudTabControlIdSource != null)
			{
				DataRepository.SeStudTabControlProvider.Save(transactionManager, entity.SeStudTabControlIdSource);
				entity.SeStudTabControlId = entity.SeStudTabControlIdSource.SeStudTabControlId;
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
	
	#region SeStudTabUserTypeControlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeStudTabUserTypeControl</c>
	///</summary>
	public enum SeStudTabUserTypeControlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SeCodeUserType</c> at SeCodeUserTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SeCodeUserType))]
		SeCodeUserType,
		
		///<summary>
		/// Composite Property for <c>SeStudTabControl</c> at SeStudTabControlIdSource
		///</summary>
		[ChildEntityType(typeof(SeStudTabControl))]
		SeStudTabControl,
	}
	
	#endregion SeStudTabUserTypeControlChildEntityTypes
	
	#region SeStudTabUserTypeControlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeStudTabUserTypeControlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeStudTabUserTypeControl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeStudTabUserTypeControlFilterBuilder : SqlFilterBuilder<SeStudTabUserTypeControlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeStudTabUserTypeControlFilterBuilder class.
		/// </summary>
		public SeStudTabUserTypeControlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeStudTabUserTypeControlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeStudTabUserTypeControlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeStudTabUserTypeControlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeStudTabUserTypeControlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeStudTabUserTypeControlFilterBuilder
	
	#region SeStudTabUserTypeControlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeStudTabUserTypeControlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeStudTabUserTypeControl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeStudTabUserTypeControlParameterBuilder : ParameterizedSqlFilterBuilder<SeStudTabUserTypeControlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeStudTabUserTypeControlParameterBuilder class.
		/// </summary>
		public SeStudTabUserTypeControlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeStudTabUserTypeControlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeStudTabUserTypeControlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeStudTabUserTypeControlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeStudTabUserTypeControlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeStudTabUserTypeControlParameterBuilder
	
	#region SeStudTabUserTypeControlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeStudTabUserTypeControlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeStudTabUserTypeControl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeStudTabUserTypeControlSortBuilder : SqlSortBuilder<SeStudTabUserTypeControlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeStudTabUserTypeControlSqlSortBuilder class.
		/// </summary>
		public SeStudTabUserTypeControlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeStudTabUserTypeControlSortBuilder
	
} // end namespace
