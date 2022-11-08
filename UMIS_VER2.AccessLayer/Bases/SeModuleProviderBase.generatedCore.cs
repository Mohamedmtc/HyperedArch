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
	/// This class is the base class for any <see cref="SeModuleProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeModuleProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeModule, UMIS_VER2.BusinessLyer.SeModuleKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeModuleKey key)
		{
			return Delete(transactionManager, key.SeModuleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seModuleId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seModuleId)
		{
			return Delete(null, _seModuleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seModuleId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seModuleId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_MODULE_SE_CODE_USER_TYPE key.
		///		FK_SE_MODULE_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="_seCodeUserTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeModule objects.</returns>
		public TList<SeModule> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(_seCodeUserTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_MODULE_SE_CODE_USER_TYPE key.
		///		FK_SE_MODULE_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeModule objects.</returns>
		/// <remarks></remarks>
		public TList<SeModule> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_MODULE_SE_CODE_USER_TYPE key.
		///		FK_SE_MODULE_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeModule objects.</returns>
		public TList<SeModule> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_MODULE_SE_CODE_USER_TYPE key.
		///		fkSeModuleSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeModule objects.</returns>
		public TList<SeModule> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_MODULE_SE_CODE_USER_TYPE key.
		///		fkSeModuleSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeModule objects.</returns>
		public TList<SeModule> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId, int start, int pageLength,out int count)
		{
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_MODULE_SE_CODE_USER_TYPE key.
		///		FK_SE_MODULE_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeModule objects.</returns>
		public abstract TList<SeModule> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SeModule Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeModuleKey key, int start, int pageLength)
		{
			return GetBySeModuleId(transactionManager, key.SeModuleId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_MODULE_SHORT_NAME index.
		/// </summary>
		/// <param name="_shortcutName"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeModule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeModule GetByShortcutName(System.String _shortcutName)
		{
			int count = -1;
			return GetByShortcutName(null,_shortcutName, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_MODULE_SHORT_NAME index.
		/// </summary>
		/// <param name="_shortcutName"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeModule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeModule GetByShortcutName(System.String _shortcutName, int start, int pageLength)
		{
			int count = -1;
			return GetByShortcutName(null, _shortcutName, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_MODULE_SHORT_NAME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_shortcutName"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeModule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeModule GetByShortcutName(TransactionManager transactionManager, System.String _shortcutName)
		{
			int count = -1;
			return GetByShortcutName(transactionManager, _shortcutName, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_MODULE_SHORT_NAME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_shortcutName"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeModule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeModule GetByShortcutName(TransactionManager transactionManager, System.String _shortcutName, int start, int pageLength)
		{
			int count = -1;
			return GetByShortcutName(transactionManager, _shortcutName, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_MODULE_SHORT_NAME index.
		/// </summary>
		/// <param name="_shortcutName"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeModule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeModule GetByShortcutName(System.String _shortcutName, int start, int pageLength, out int count)
		{
			return GetByShortcutName(null, _shortcutName, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_MODULE_SHORT_NAME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_shortcutName"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeModule"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeModule GetByShortcutName(TransactionManager transactionManager, System.String _shortcutName, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SE_HIGHER_MODULE_ID_1 index.
		/// </summary>
		/// <param name="_seHigherModuleId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeModule&gt;"/> class.</returns>
		public TList<SeModule> GetBySeHigherModuleId(System.Decimal? _seHigherModuleId)
		{
			int count = -1;
			return GetBySeHigherModuleId(null,_seHigherModuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_HIGHER_MODULE_ID_1 index.
		/// </summary>
		/// <param name="_seHigherModuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeModule&gt;"/> class.</returns>
		public TList<SeModule> GetBySeHigherModuleId(System.Decimal? _seHigherModuleId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeHigherModuleId(null, _seHigherModuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_HIGHER_MODULE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seHigherModuleId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeModule&gt;"/> class.</returns>
		public TList<SeModule> GetBySeHigherModuleId(TransactionManager transactionManager, System.Decimal? _seHigherModuleId)
		{
			int count = -1;
			return GetBySeHigherModuleId(transactionManager, _seHigherModuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_HIGHER_MODULE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seHigherModuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeModule&gt;"/> class.</returns>
		public TList<SeModule> GetBySeHigherModuleId(TransactionManager transactionManager, System.Decimal? _seHigherModuleId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeHigherModuleId(transactionManager, _seHigherModuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_HIGHER_MODULE_ID_1 index.
		/// </summary>
		/// <param name="_seHigherModuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeModule&gt;"/> class.</returns>
		public TList<SeModule> GetBySeHigherModuleId(System.Decimal? _seHigherModuleId, int start, int pageLength, out int count)
		{
			return GetBySeHigherModuleId(null, _seHigherModuleId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_HIGHER_MODULE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seHigherModuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeModule&gt;"/> class.</returns>
		public abstract TList<SeModule> GetBySeHigherModuleId(TransactionManager transactionManager, System.Decimal? _seHigherModuleId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_MODULE index.
		/// </summary>
		/// <param name="_seModuleId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeModule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeModule GetBySeModuleId(System.Decimal _seModuleId)
		{
			int count = -1;
			return GetBySeModuleId(null,_seModuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_MODULE index.
		/// </summary>
		/// <param name="_seModuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeModule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeModule GetBySeModuleId(System.Decimal _seModuleId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeModuleId(null, _seModuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_MODULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seModuleId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeModule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeModule GetBySeModuleId(TransactionManager transactionManager, System.Decimal _seModuleId)
		{
			int count = -1;
			return GetBySeModuleId(transactionManager, _seModuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_MODULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seModuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeModule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeModule GetBySeModuleId(TransactionManager transactionManager, System.Decimal _seModuleId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeModuleId(transactionManager, _seModuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_MODULE index.
		/// </summary>
		/// <param name="_seModuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeModule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeModule GetBySeModuleId(System.Decimal _seModuleId, int start, int pageLength, out int count)
		{
			return GetBySeModuleId(null, _seModuleId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_MODULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seModuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeModule"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeModule GetBySeModuleId(TransactionManager transactionManager, System.Decimal _seModuleId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeModule&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeModule&gt;"/></returns>
		public static TList<SeModule> Fill(IDataReader reader, TList<SeModule> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeModule c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeModule")
					.Append("|").Append((System.Decimal)reader["SE_MODULE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeModule>(
					key.ToString(), // EntityTrackingKey
					"SeModule",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeModule();
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
					c.SeModuleId = (System.Decimal)reader["SE_MODULE_ID"];
					c.OriginalSeModuleId = c.SeModuleId;
					c.DescAr = (System.String)reader["DESC_AR"];
					c.ShortcutName = (System.String)reader["SHORTCUT_NAME"];
					c.SeHigherModuleId = Convert.IsDBNull(reader["SE_HIGHER_MODULE_ID"]) ? null : (System.Decimal?)reader["SE_HIGHER_MODULE_ID"];
					c.DescEn = Convert.IsDBNull(reader["DESC_EN"]) ? null : (System.String)reader["DESC_EN"];
					c.SeCodeUserTypeId = Convert.IsDBNull(reader["SE_CODE_USER_TYPE_ID"]) ? null : (System.Decimal?)reader["SE_CODE_USER_TYPE_ID"];
					c.OrderFlg = Convert.IsDBNull(reader["ORDER_FLG"]) ? null : (System.Decimal?)reader["ORDER_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeModule"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeModule"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeModule entity)
		{
			if (!reader.Read()) return;
			
			entity.SeModuleId = (System.Decimal)reader[((int)SeModuleColumn.SeModuleId - 1)];
			entity.OriginalSeModuleId = (System.Decimal)reader["SE_MODULE_ID"];
			entity.DescAr = (System.String)reader[((int)SeModuleColumn.DescAr - 1)];
			entity.ShortcutName = (System.String)reader[((int)SeModuleColumn.ShortcutName - 1)];
			entity.SeHigherModuleId = (reader.IsDBNull(((int)SeModuleColumn.SeHigherModuleId - 1)))?null:(System.Decimal?)reader[((int)SeModuleColumn.SeHigherModuleId - 1)];
			entity.DescEn = (reader.IsDBNull(((int)SeModuleColumn.DescEn - 1)))?null:(System.String)reader[((int)SeModuleColumn.DescEn - 1)];
			entity.SeCodeUserTypeId = (reader.IsDBNull(((int)SeModuleColumn.SeCodeUserTypeId - 1)))?null:(System.Decimal?)reader[((int)SeModuleColumn.SeCodeUserTypeId - 1)];
			entity.OrderFlg = (reader.IsDBNull(((int)SeModuleColumn.OrderFlg - 1)))?null:(System.Decimal?)reader[((int)SeModuleColumn.OrderFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeModule"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeModule"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeModule entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeModuleId = (System.Decimal)dataRow["SE_MODULE_ID"];
			entity.OriginalSeModuleId = (System.Decimal)dataRow["SE_MODULE_ID"];
			entity.DescAr = (System.String)dataRow["DESC_AR"];
			entity.ShortcutName = (System.String)dataRow["SHORTCUT_NAME"];
			entity.SeHigherModuleId = Convert.IsDBNull(dataRow["SE_HIGHER_MODULE_ID"]) ? null : (System.Decimal?)dataRow["SE_HIGHER_MODULE_ID"];
			entity.DescEn = Convert.IsDBNull(dataRow["DESC_EN"]) ? null : (System.String)dataRow["DESC_EN"];
			entity.SeCodeUserTypeId = Convert.IsDBNull(dataRow["SE_CODE_USER_TYPE_ID"]) ? null : (System.Decimal?)dataRow["SE_CODE_USER_TYPE_ID"];
			entity.OrderFlg = Convert.IsDBNull(dataRow["ORDER_FLG"]) ? null : (System.Decimal?)dataRow["ORDER_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeModule"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeModule Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeModule entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SeCodeUserTypeIdSource	
			if (CanDeepLoad(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepLoadType, innerList) 
				&& entity.SeCodeUserTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeCodeUserTypeId ?? 0.0m);
				SeCodeUserType tmpEntity = EntityManager.LocateEntity<SeCodeUserType>(EntityLocator.ConstructKeyFromPkItems(typeof(SeCodeUserType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeCodeUserTypeIdSource = tmpEntity;
				else
					entity.SeCodeUserTypeIdSource = DataRepository.SeCodeUserTypeProvider.GetBySeCodeUserTypeId(transactionManager, (entity.SeCodeUserTypeId ?? 0.0m));		
				
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

			#region SeHigherModuleIdSource	
			if (CanDeepLoad(entity, "SeModule|SeHigherModuleIdSource", deepLoadType, innerList) 
				&& entity.SeHigherModuleIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeHigherModuleId ?? 0.0m);
				SeModule tmpEntity = EntityManager.LocateEntity<SeModule>(EntityLocator.ConstructKeyFromPkItems(typeof(SeModule), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeHigherModuleIdSource = tmpEntity;
				else
					entity.SeHigherModuleIdSource = DataRepository.SeModuleProvider.GetBySeModuleId(transactionManager, (entity.SeHigherModuleId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeHigherModuleIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeHigherModuleIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeModuleProvider.DeepLoad(transactionManager, entity.SeHigherModuleIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeHigherModuleIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySeModuleId methods when available
			
			#region SeModuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeModule>|SeModuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeModuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeModuleCollection = DataRepository.SeModuleProvider.GetBySeHigherModuleId(transactionManager, entity.SeModuleId);

				if (deep && entity.SeModuleCollection.Count > 0)
				{
					deepHandles.Add("SeModuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeModule>) DataRepository.SeModuleProvider.DeepLoad,
						new object[] { transactionManager, entity.SeModuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeFormCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeForm>|SeFormCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeFormCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeFormCollection = DataRepository.SeFormProvider.GetBySeModuleId(transactionManager, entity.SeModuleId);

				if (deep && entity.SeFormCollection.Count > 0)
				{
					deepHandles.Add("SeFormCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeForm>) DataRepository.SeFormProvider.DeepLoad,
						new object[] { transactionManager, entity.SeFormCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeModule object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeModule instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeModule Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeModule entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region SeHigherModuleIdSource
			if (CanDeepSave(entity, "SeModule|SeHigherModuleIdSource", deepSaveType, innerList) 
				&& entity.SeHigherModuleIdSource != null)
			{
				DataRepository.SeModuleProvider.Save(transactionManager, entity.SeHigherModuleIdSource);
				entity.SeHigherModuleId = entity.SeHigherModuleIdSource.SeModuleId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SeModule>
				if (CanDeepSave(entity.SeModuleCollection, "List<SeModule>|SeModuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeModule child in entity.SeModuleCollection)
					{
						if(child.SeHigherModuleIdSource != null)
						{
							child.SeHigherModuleId = child.SeHigherModuleIdSource.SeModuleId;
						}
						else
						{
							child.SeHigherModuleId = entity.SeModuleId;
						}

					}

					if (entity.SeModuleCollection.Count > 0 || entity.SeModuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeModuleProvider.Save(transactionManager, entity.SeModuleCollection);
						
						deepHandles.Add("SeModuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeModule >) DataRepository.SeModuleProvider.DeepSave,
							new object[] { transactionManager, entity.SeModuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeForm>
				if (CanDeepSave(entity.SeFormCollection, "List<SeForm>|SeFormCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeForm child in entity.SeFormCollection)
					{
						if(child.SeModuleIdSource != null)
						{
							child.SeModuleId = child.SeModuleIdSource.SeModuleId;
						}
						else
						{
							child.SeModuleId = entity.SeModuleId;
						}

					}

					if (entity.SeFormCollection.Count > 0 || entity.SeFormCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeFormProvider.Save(transactionManager, entity.SeFormCollection);
						
						deepHandles.Add("SeFormCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeForm >) DataRepository.SeFormProvider.DeepSave,
							new object[] { transactionManager, entity.SeFormCollection, deepSaveType, childTypes, innerList }
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
	
	#region SeModuleChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeModule</c>
	///</summary>
	public enum SeModuleChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SeCodeUserType</c> at SeCodeUserTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SeCodeUserType))]
		SeCodeUserType,
		
		///<summary>
		/// Composite Property for <c>SeModule</c> at SeHigherModuleIdSource
		///</summary>
		[ChildEntityType(typeof(SeModule))]
		SeModule,
		///<summary>
		/// Collection of <c>SeModule</c> as OneToMany for SeModuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeModule>))]
		SeModuleCollection,
		///<summary>
		/// Collection of <c>SeModule</c> as OneToMany for SeFormCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeForm>))]
		SeFormCollection,
	}
	
	#endregion SeModuleChildEntityTypes
	
	#region SeModuleFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeModuleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeModule"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeModuleFilterBuilder : SqlFilterBuilder<SeModuleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeModuleFilterBuilder class.
		/// </summary>
		public SeModuleFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeModuleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeModuleFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeModuleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeModuleFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeModuleFilterBuilder
	
	#region SeModuleParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeModuleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeModule"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeModuleParameterBuilder : ParameterizedSqlFilterBuilder<SeModuleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeModuleParameterBuilder class.
		/// </summary>
		public SeModuleParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeModuleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeModuleParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeModuleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeModuleParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeModuleParameterBuilder
	
	#region SeModuleSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeModuleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeModule"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeModuleSortBuilder : SqlSortBuilder<SeModuleColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeModuleSqlSortBuilder class.
		/// </summary>
		public SeModuleSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeModuleSortBuilder
	
} // end namespace
