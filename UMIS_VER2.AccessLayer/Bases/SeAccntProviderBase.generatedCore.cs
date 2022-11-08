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
	/// This class is the base class for any <see cref="SeAccntProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeAccntProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeAccnt, UMIS_VER2.BusinessLyer.SeAccntKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeAccntKey key)
		{
			return Delete(transactionManager, key.SeAccntId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seAccntId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seAccntId)
		{
			return Delete(null, _seAccntId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seAccntId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_SE_CODE_USER_TYPE key.
		///		FK_SE_ACCNT_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="_seCodeUserTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccnt objects.</returns>
		public TList<SeAccnt> GetBySeCodeUserTypeId(System.Decimal _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(_seCodeUserTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_SE_CODE_USER_TYPE key.
		///		FK_SE_ACCNT_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccnt objects.</returns>
		/// <remarks></remarks>
		public TList<SeAccnt> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_SE_CODE_USER_TYPE key.
		///		FK_SE_ACCNT_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccnt objects.</returns>
		public TList<SeAccnt> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_SE_CODE_USER_TYPE key.
		///		fkSeAccntSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccnt objects.</returns>
		public TList<SeAccnt> GetBySeCodeUserTypeId(System.Decimal _seCodeUserTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_SE_CODE_USER_TYPE key.
		///		fkSeAccntSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccnt objects.</returns>
		public TList<SeAccnt> GetBySeCodeUserTypeId(System.Decimal _seCodeUserTypeId, int start, int pageLength,out int count)
		{
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_SE_CODE_USER_TYPE key.
		///		FK_SE_ACCNT_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccnt objects.</returns>
		public abstract TList<SeAccnt> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SeAccnt Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeAccntKey key, int start, int pageLength)
		{
			return GetBySeAccntId(transactionManager, key.SeAccntId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SE_ACCNT_DESC_AR index.
		/// </summary>
		/// <param name="_descAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccnt GetByDescAr(System.String _descAr)
		{
			int count = -1;
			return GetByDescAr(null,_descAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_ACCNT_DESC_AR index.
		/// </summary>
		/// <param name="_descAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccnt GetByDescAr(System.String _descAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescAr(null, _descAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_ACCNT_DESC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccnt GetByDescAr(TransactionManager transactionManager, System.String _descAr)
		{
			int count = -1;
			return GetByDescAr(transactionManager, _descAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_ACCNT_DESC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccnt GetByDescAr(TransactionManager transactionManager, System.String _descAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescAr(transactionManager, _descAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_ACCNT_DESC_AR index.
		/// </summary>
		/// <param name="_descAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccnt GetByDescAr(System.String _descAr, int start, int pageLength, out int count)
		{
			return GetByDescAr(null, _descAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_ACCNT_DESC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeAccnt GetByDescAr(TransactionManager transactionManager, System.String _descAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_ACCNT index.
		/// </summary>
		/// <param name="_seAccntId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccnt GetBySeAccntId(System.Decimal _seAccntId)
		{
			int count = -1;
			return GetBySeAccntId(null,_seAccntId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_ACCNT index.
		/// </summary>
		/// <param name="_seAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccnt GetBySeAccntId(System.Decimal _seAccntId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeAccntId(null, _seAccntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_ACCNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccnt GetBySeAccntId(TransactionManager transactionManager, System.Decimal _seAccntId)
		{
			int count = -1;
			return GetBySeAccntId(transactionManager, _seAccntId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_ACCNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccnt GetBySeAccntId(TransactionManager transactionManager, System.Decimal _seAccntId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeAccntId(transactionManager, _seAccntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_ACCNT index.
		/// </summary>
		/// <param name="_seAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccnt GetBySeAccntId(System.Decimal _seAccntId, int start, int pageLength, out int count)
		{
			return GetBySeAccntId(null, _seAccntId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_ACCNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeAccnt GetBySeAccntId(TransactionManager transactionManager, System.Decimal _seAccntId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeAccnt&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeAccnt&gt;"/></returns>
		public static TList<SeAccnt> Fill(IDataReader reader, TList<SeAccnt> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeAccnt c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeAccnt")
					.Append("|").Append((System.Decimal)reader["SE_ACCNT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeAccnt>(
					key.ToString(), // EntityTrackingKey
					"SeAccnt",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeAccnt();
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
					c.SeAccntId = (System.Decimal)reader["SE_ACCNT_ID"];
					c.OriginalSeAccntId = c.SeAccntId;
					c.DescAr = (System.String)reader["DESC_AR"];
					c.DescEn = Convert.IsDBNull(reader["DESC_EN"]) ? null : (System.String)reader["DESC_EN"];
					c.TemplateFlg = Convert.IsDBNull(reader["TEMPLATE_FLG"]) ? null : (System.Decimal?)reader["TEMPLATE_FLG"];
					c.AdAccntGuid = (System.String)reader["AD_ACCNT_GUID"];
					c.AdAccntName = (System.String)reader["AD_ACCNT_NAME"];
					c.SeCodeUserTypeId = (System.Decimal)reader["SE_CODE_USER_TYPE_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserLstId = Convert.IsDBNull(reader["SE_USER_LST_ID"]) ? null : (System.Decimal?)reader["SE_USER_LST_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeAccnt entity)
		{
			if (!reader.Read()) return;
			
			entity.SeAccntId = (System.Decimal)reader[((int)SeAccntColumn.SeAccntId - 1)];
			entity.OriginalSeAccntId = (System.Decimal)reader["SE_ACCNT_ID"];
			entity.DescAr = (System.String)reader[((int)SeAccntColumn.DescAr - 1)];
			entity.DescEn = (reader.IsDBNull(((int)SeAccntColumn.DescEn - 1)))?null:(System.String)reader[((int)SeAccntColumn.DescEn - 1)];
			entity.TemplateFlg = (reader.IsDBNull(((int)SeAccntColumn.TemplateFlg - 1)))?null:(System.Decimal?)reader[((int)SeAccntColumn.TemplateFlg - 1)];
			entity.AdAccntGuid = (System.String)reader[((int)SeAccntColumn.AdAccntGuid - 1)];
			entity.AdAccntName = (System.String)reader[((int)SeAccntColumn.AdAccntName - 1)];
			entity.SeCodeUserTypeId = (System.Decimal)reader[((int)SeAccntColumn.SeCodeUserTypeId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SeAccntColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SeAccntColumn.LastDate - 1)];
			entity.SeUserLstId = (reader.IsDBNull(((int)SeAccntColumn.SeUserLstId - 1)))?null:(System.Decimal?)reader[((int)SeAccntColumn.SeUserLstId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeAccnt entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeAccntId = (System.Decimal)dataRow["SE_ACCNT_ID"];
			entity.OriginalSeAccntId = (System.Decimal)dataRow["SE_ACCNT_ID"];
			entity.DescAr = (System.String)dataRow["DESC_AR"];
			entity.DescEn = Convert.IsDBNull(dataRow["DESC_EN"]) ? null : (System.String)dataRow["DESC_EN"];
			entity.TemplateFlg = Convert.IsDBNull(dataRow["TEMPLATE_FLG"]) ? null : (System.Decimal?)dataRow["TEMPLATE_FLG"];
			entity.AdAccntGuid = (System.String)dataRow["AD_ACCNT_GUID"];
			entity.AdAccntName = (System.String)dataRow["AD_ACCNT_NAME"];
			entity.SeCodeUserTypeId = (System.Decimal)dataRow["SE_CODE_USER_TYPE_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserLstId = Convert.IsDBNull(dataRow["SE_USER_LST_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_LST_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeAccnt Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeAccnt entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySeAccntId methods when available
			
			#region SeUserAccntCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserAccnt>|SeUserAccntCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserAccntCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserAccntCollection = DataRepository.SeUserAccntProvider.GetBySeAccountId(transactionManager, entity.SeAccntId);

				if (deep && entity.SeUserAccntCollection.Count > 0)
				{
					deepHandles.Add("SeUserAccntCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserAccnt>) DataRepository.SeUserAccntProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserAccntCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeApplicationLogCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeApplicationLog>|SeApplicationLogCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeApplicationLogCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeApplicationLogCollection = DataRepository.SeApplicationLogProvider.GetBySeAccntId(transactionManager, entity.SeAccntId);

				if (deep && entity.SeApplicationLogCollection.Count > 0)
				{
					deepHandles.Add("SeApplicationLogCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeApplicationLog>) DataRepository.SeApplicationLogProvider.DeepLoad,
						new object[] { transactionManager, entity.SeApplicationLogCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeAccntControlDiffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeAccntControlDiff>|SeAccntControlDiffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeAccntControlDiffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeAccntControlDiffCollection = DataRepository.SeAccntControlDiffProvider.GetBySeAccntId(transactionManager, entity.SeAccntId);

				if (deep && entity.SeAccntControlDiffCollection.Count > 0)
				{
					deepHandles.Add("SeAccntControlDiffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeAccntControlDiff>) DataRepository.SeAccntControlDiffProvider.DeepLoad,
						new object[] { transactionManager, entity.SeAccntControlDiffCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeAccntFormDiffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeAccntFormDiff>|SeAccntFormDiffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeAccntFormDiffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeAccntFormDiffCollection = DataRepository.SeAccntFormDiffProvider.GetBySeAccntId(transactionManager, entity.SeAccntId);

				if (deep && entity.SeAccntFormDiffCollection.Count > 0)
				{
					deepHandles.Add("SeAccntFormDiffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeAccntFormDiff>) DataRepository.SeAccntFormDiffProvider.DeepLoad,
						new object[] { transactionManager, entity.SeAccntFormDiffCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region UsrTopLinkCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<UsrTopLink>|UsrTopLinkCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'UsrTopLinkCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.UsrTopLinkCollection = DataRepository.UsrTopLinkProvider.GetBySeAccntId(transactionManager, entity.SeAccntId);

				if (deep && entity.UsrTopLinkCollection.Count > 0)
				{
					deepHandles.Add("UsrTopLinkCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<UsrTopLink>) DataRepository.UsrTopLinkProvider.DeepLoad,
						new object[] { transactionManager, entity.UsrTopLinkCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeAccnt object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeAccnt instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeAccnt Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeAccnt entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SeUserAccnt>
				if (CanDeepSave(entity.SeUserAccntCollection, "List<SeUserAccnt>|SeUserAccntCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserAccnt child in entity.SeUserAccntCollection)
					{
						if(child.SeAccountIdSource != null)
						{
							child.SeAccountId = child.SeAccountIdSource.SeAccntId;
						}
						else
						{
							child.SeAccountId = entity.SeAccntId;
						}

					}

					if (entity.SeUserAccntCollection.Count > 0 || entity.SeUserAccntCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserAccntProvider.Save(transactionManager, entity.SeUserAccntCollection);
						
						deepHandles.Add("SeUserAccntCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserAccnt >) DataRepository.SeUserAccntProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserAccntCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeApplicationLog>
				if (CanDeepSave(entity.SeApplicationLogCollection, "List<SeApplicationLog>|SeApplicationLogCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeApplicationLog child in entity.SeApplicationLogCollection)
					{
						if(child.SeAccntIdSource != null)
						{
							child.SeAccntId = child.SeAccntIdSource.SeAccntId;
						}
						else
						{
							child.SeAccntId = entity.SeAccntId;
						}

					}

					if (entity.SeApplicationLogCollection.Count > 0 || entity.SeApplicationLogCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeApplicationLogProvider.Save(transactionManager, entity.SeApplicationLogCollection);
						
						deepHandles.Add("SeApplicationLogCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeApplicationLog >) DataRepository.SeApplicationLogProvider.DeepSave,
							new object[] { transactionManager, entity.SeApplicationLogCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeAccntControlDiff>
				if (CanDeepSave(entity.SeAccntControlDiffCollection, "List<SeAccntControlDiff>|SeAccntControlDiffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeAccntControlDiff child in entity.SeAccntControlDiffCollection)
					{
						if(child.SeAccntIdSource != null)
						{
							child.SeAccntId = child.SeAccntIdSource.SeAccntId;
						}
						else
						{
							child.SeAccntId = entity.SeAccntId;
						}

					}

					if (entity.SeAccntControlDiffCollection.Count > 0 || entity.SeAccntControlDiffCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeAccntControlDiffProvider.Save(transactionManager, entity.SeAccntControlDiffCollection);
						
						deepHandles.Add("SeAccntControlDiffCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeAccntControlDiff >) DataRepository.SeAccntControlDiffProvider.DeepSave,
							new object[] { transactionManager, entity.SeAccntControlDiffCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeAccntFormDiff>
				if (CanDeepSave(entity.SeAccntFormDiffCollection, "List<SeAccntFormDiff>|SeAccntFormDiffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeAccntFormDiff child in entity.SeAccntFormDiffCollection)
					{
						if(child.SeAccntIdSource != null)
						{
							child.SeAccntId = child.SeAccntIdSource.SeAccntId;
						}
						else
						{
							child.SeAccntId = entity.SeAccntId;
						}

					}

					if (entity.SeAccntFormDiffCollection.Count > 0 || entity.SeAccntFormDiffCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeAccntFormDiffProvider.Save(transactionManager, entity.SeAccntFormDiffCollection);
						
						deepHandles.Add("SeAccntFormDiffCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeAccntFormDiff >) DataRepository.SeAccntFormDiffProvider.DeepSave,
							new object[] { transactionManager, entity.SeAccntFormDiffCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<UsrTopLink>
				if (CanDeepSave(entity.UsrTopLinkCollection, "List<UsrTopLink>|UsrTopLinkCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(UsrTopLink child in entity.UsrTopLinkCollection)
					{
						if(child.SeAccntIdSource != null)
						{
							child.SeAccntId = child.SeAccntIdSource.SeAccntId;
						}
						else
						{
							child.SeAccntId = entity.SeAccntId;
						}

					}

					if (entity.UsrTopLinkCollection.Count > 0 || entity.UsrTopLinkCollection.DeletedItems.Count > 0)
					{
						//DataRepository.UsrTopLinkProvider.Save(transactionManager, entity.UsrTopLinkCollection);
						
						deepHandles.Add("UsrTopLinkCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< UsrTopLink >) DataRepository.UsrTopLinkProvider.DeepSave,
							new object[] { transactionManager, entity.UsrTopLinkCollection, deepSaveType, childTypes, innerList }
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
	
	#region SeAccntChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeAccnt</c>
	///</summary>
	public enum SeAccntChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SeCodeUserType</c> at SeCodeUserTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SeCodeUserType))]
		SeCodeUserType,
		///<summary>
		/// Collection of <c>SeAccnt</c> as OneToMany for SeUserAccntCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserAccnt>))]
		SeUserAccntCollection,
		///<summary>
		/// Collection of <c>SeAccnt</c> as OneToMany for SeApplicationLogCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeApplicationLog>))]
		SeApplicationLogCollection,
		///<summary>
		/// Collection of <c>SeAccnt</c> as OneToMany for SeAccntControlDiffCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeAccntControlDiff>))]
		SeAccntControlDiffCollection,
		///<summary>
		/// Collection of <c>SeAccnt</c> as OneToMany for SeAccntFormDiffCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeAccntFormDiff>))]
		SeAccntFormDiffCollection,
		///<summary>
		/// Collection of <c>SeAccnt</c> as OneToMany for UsrTopLinkCollection
		///</summary>
		[ChildEntityType(typeof(TList<UsrTopLink>))]
		UsrTopLinkCollection,
	}
	
	#endregion SeAccntChildEntityTypes
	
	#region SeAccntFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeAccntColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeAccnt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeAccntFilterBuilder : SqlFilterBuilder<SeAccntColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeAccntFilterBuilder class.
		/// </summary>
		public SeAccntFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeAccntFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeAccntFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeAccntFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeAccntFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeAccntFilterBuilder
	
	#region SeAccntParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeAccntColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeAccnt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeAccntParameterBuilder : ParameterizedSqlFilterBuilder<SeAccntColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeAccntParameterBuilder class.
		/// </summary>
		public SeAccntParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeAccntParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeAccntParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeAccntParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeAccntParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeAccntParameterBuilder
	
	#region SeAccntSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeAccntColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeAccnt"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeAccntSortBuilder : SqlSortBuilder<SeAccntColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeAccntSqlSortBuilder class.
		/// </summary>
		public SeAccntSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeAccntSortBuilder
	
} // end namespace
