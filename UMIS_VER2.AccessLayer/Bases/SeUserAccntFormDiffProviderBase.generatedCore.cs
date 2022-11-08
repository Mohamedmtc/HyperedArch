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
	/// This class is the base class for any <see cref="SeUserAccntFormDiffProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeUserAccntFormDiffProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeUserAccntFormDiff, UMIS_VER2.BusinessLyer.SeUserAccntFormDiffKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserAccntFormDiffKey key)
		{
			return Delete(transactionManager, key.SeUserAccntFormDiffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seUserAccntFormDiffId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seUserAccntFormDiffId)
		{
			return Delete(null, _seUserAccntFormDiffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntFormDiffId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seUserAccntFormDiffId);		
		
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
		public override UMIS_VER2.BusinessLyer.SeUserAccntFormDiff Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserAccntFormDiffKey key, int start, int pageLength)
		{
			return GetBySeUserAccntFormDiffId(transactionManager, key.SeUserAccntFormDiffId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SE_USER_ACCNT_FORM index.
		/// </summary>
		/// <param name="_seUserAccountId"></param>
		/// <param name="_seFormId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntFormDiff GetBySeUserAccountIdSeFormId(System.Decimal _seUserAccountId, System.Decimal _seFormId)
		{
			int count = -1;
			return GetBySeUserAccountIdSeFormId(null,_seUserAccountId, _seFormId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_USER_ACCNT_FORM index.
		/// </summary>
		/// <param name="_seUserAccountId"></param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntFormDiff GetBySeUserAccountIdSeFormId(System.Decimal _seUserAccountId, System.Decimal _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserAccountIdSeFormId(null, _seUserAccountId, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_USER_ACCNT_FORM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccountId"></param>
		/// <param name="_seFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntFormDiff GetBySeUserAccountIdSeFormId(TransactionManager transactionManager, System.Decimal _seUserAccountId, System.Decimal _seFormId)
		{
			int count = -1;
			return GetBySeUserAccountIdSeFormId(transactionManager, _seUserAccountId, _seFormId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_USER_ACCNT_FORM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccountId"></param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntFormDiff GetBySeUserAccountIdSeFormId(TransactionManager transactionManager, System.Decimal _seUserAccountId, System.Decimal _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserAccountIdSeFormId(transactionManager, _seUserAccountId, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_USER_ACCNT_FORM index.
		/// </summary>
		/// <param name="_seUserAccountId"></param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntFormDiff GetBySeUserAccountIdSeFormId(System.Decimal _seUserAccountId, System.Decimal _seFormId, int start, int pageLength, out int count)
		{
			return GetBySeUserAccountIdSeFormId(null, _seUserAccountId, _seFormId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_USER_ACCNT_FORM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccountId"></param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntFormDiff"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeUserAccntFormDiff GetBySeUserAccountIdSeFormId(TransactionManager transactionManager, System.Decimal _seUserAccountId, System.Decimal _seFormId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SE_FORM_ID_1 index.
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccntFormDiff&gt;"/> class.</returns>
		public TList<SeUserAccntFormDiff> GetBySeFormId(System.Decimal _seFormId)
		{
			int count = -1;
			return GetBySeFormId(null,_seFormId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_FORM_ID_1 index.
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccntFormDiff&gt;"/> class.</returns>
		public TList<SeUserAccntFormDiff> GetBySeFormId(System.Decimal _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormId(null, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_FORM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccntFormDiff&gt;"/> class.</returns>
		public TList<SeUserAccntFormDiff> GetBySeFormId(TransactionManager transactionManager, System.Decimal _seFormId)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_FORM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccntFormDiff&gt;"/> class.</returns>
		public TList<SeUserAccntFormDiff> GetBySeFormId(TransactionManager transactionManager, System.Decimal _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_FORM_ID_1 index.
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccntFormDiff&gt;"/> class.</returns>
		public TList<SeUserAccntFormDiff> GetBySeFormId(System.Decimal _seFormId, int start, int pageLength, out int count)
		{
			return GetBySeFormId(null, _seFormId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_FORM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccntFormDiff&gt;"/> class.</returns>
		public abstract TList<SeUserAccntFormDiff> GetBySeFormId(TransactionManager transactionManager, System.Decimal _seFormId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SE_USER_ACCOUNT_ID_1 index.
		/// </summary>
		/// <param name="_seUserAccountId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccntFormDiff&gt;"/> class.</returns>
		public TList<SeUserAccntFormDiff> GetBySeUserAccountId(System.Decimal _seUserAccountId)
		{
			int count = -1;
			return GetBySeUserAccountId(null,_seUserAccountId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ACCOUNT_ID_1 index.
		/// </summary>
		/// <param name="_seUserAccountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccntFormDiff&gt;"/> class.</returns>
		public TList<SeUserAccntFormDiff> GetBySeUserAccountId(System.Decimal _seUserAccountId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserAccountId(null, _seUserAccountId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ACCOUNT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccountId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccntFormDiff&gt;"/> class.</returns>
		public TList<SeUserAccntFormDiff> GetBySeUserAccountId(TransactionManager transactionManager, System.Decimal _seUserAccountId)
		{
			int count = -1;
			return GetBySeUserAccountId(transactionManager, _seUserAccountId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ACCOUNT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccntFormDiff&gt;"/> class.</returns>
		public TList<SeUserAccntFormDiff> GetBySeUserAccountId(TransactionManager transactionManager, System.Decimal _seUserAccountId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserAccountId(transactionManager, _seUserAccountId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ACCOUNT_ID_1 index.
		/// </summary>
		/// <param name="_seUserAccountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccntFormDiff&gt;"/> class.</returns>
		public TList<SeUserAccntFormDiff> GetBySeUserAccountId(System.Decimal _seUserAccountId, int start, int pageLength, out int count)
		{
			return GetBySeUserAccountId(null, _seUserAccountId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ACCOUNT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccntFormDiff&gt;"/> class.</returns>
		public abstract TList<SeUserAccntFormDiff> GetBySeUserAccountId(TransactionManager transactionManager, System.Decimal _seUserAccountId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_USER_ACCNT_FORM_DIFF index.
		/// </summary>
		/// <param name="_seUserAccntFormDiffId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntFormDiff GetBySeUserAccntFormDiffId(System.Decimal _seUserAccntFormDiffId)
		{
			int count = -1;
			return GetBySeUserAccntFormDiffId(null,_seUserAccntFormDiffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT_FORM_DIFF index.
		/// </summary>
		/// <param name="_seUserAccntFormDiffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntFormDiff GetBySeUserAccntFormDiffId(System.Decimal _seUserAccntFormDiffId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserAccntFormDiffId(null, _seUserAccntFormDiffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT_FORM_DIFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntFormDiffId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntFormDiff GetBySeUserAccntFormDiffId(TransactionManager transactionManager, System.Decimal _seUserAccntFormDiffId)
		{
			int count = -1;
			return GetBySeUserAccntFormDiffId(transactionManager, _seUserAccntFormDiffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT_FORM_DIFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntFormDiffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntFormDiff GetBySeUserAccntFormDiffId(TransactionManager transactionManager, System.Decimal _seUserAccntFormDiffId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserAccntFormDiffId(transactionManager, _seUserAccntFormDiffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT_FORM_DIFF index.
		/// </summary>
		/// <param name="_seUserAccntFormDiffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccntFormDiff GetBySeUserAccntFormDiffId(System.Decimal _seUserAccntFormDiffId, int start, int pageLength, out int count)
		{
			return GetBySeUserAccntFormDiffId(null, _seUserAccntFormDiffId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT_FORM_DIFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntFormDiffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntFormDiff"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeUserAccntFormDiff GetBySeUserAccntFormDiffId(TransactionManager transactionManager, System.Decimal _seUserAccntFormDiffId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeUserAccntFormDiff&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeUserAccntFormDiff&gt;"/></returns>
		public static TList<SeUserAccntFormDiff> Fill(IDataReader reader, TList<SeUserAccntFormDiff> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeUserAccntFormDiff c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeUserAccntFormDiff")
					.Append("|").Append((System.Decimal)reader["SE_USER_ACCNT_FORM_DIFF_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeUserAccntFormDiff>(
					key.ToString(), // EntityTrackingKey
					"SeUserAccntFormDiff",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeUserAccntFormDiff();
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
					c.SeUserAccntFormDiffId = (System.Decimal)reader["SE_USER_ACCNT_FORM_DIFF_ID"];
					c.OriginalSeUserAccntFormDiffId = c.SeUserAccntFormDiffId;
					c.SeUserAccountId = (System.Decimal)reader["SE_USER_ACCOUNT_ID"];
					c.SeFormId = (System.Decimal)reader["SE_FORM_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntFormDiff"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeUserAccntFormDiff"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeUserAccntFormDiff entity)
		{
			if (!reader.Read()) return;
			
			entity.SeUserAccntFormDiffId = (System.Decimal)reader[((int)SeUserAccntFormDiffColumn.SeUserAccntFormDiffId - 1)];
			entity.OriginalSeUserAccntFormDiffId = (System.Decimal)reader["SE_USER_ACCNT_FORM_DIFF_ID"];
			entity.SeUserAccountId = (System.Decimal)reader[((int)SeUserAccntFormDiffColumn.SeUserAccountId - 1)];
			entity.SeFormId = (System.Decimal)reader[((int)SeUserAccntFormDiffColumn.SeFormId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SeUserAccntFormDiffColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SeUserAccntFormDiffColumn.LastDate - 1)];
			entity.SeUserLstId = (reader.IsDBNull(((int)SeUserAccntFormDiffColumn.SeUserLstId - 1)))?null:(System.Decimal?)reader[((int)SeUserAccntFormDiffColumn.SeUserLstId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeUserAccntFormDiff"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeUserAccntFormDiff"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeUserAccntFormDiff entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeUserAccntFormDiffId = (System.Decimal)dataRow["SE_USER_ACCNT_FORM_DIFF_ID"];
			entity.OriginalSeUserAccntFormDiffId = (System.Decimal)dataRow["SE_USER_ACCNT_FORM_DIFF_ID"];
			entity.SeUserAccountId = (System.Decimal)dataRow["SE_USER_ACCOUNT_ID"];
			entity.SeFormId = (System.Decimal)dataRow["SE_FORM_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeUserAccntFormDiff"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeUserAccntFormDiff Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserAccntFormDiff entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SeFormIdSource	
			if (CanDeepLoad(entity, "SeForm|SeFormIdSource", deepLoadType, innerList) 
				&& entity.SeFormIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeFormId;
				SeForm tmpEntity = EntityManager.LocateEntity<SeForm>(EntityLocator.ConstructKeyFromPkItems(typeof(SeForm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeFormIdSource = tmpEntity;
				else
					entity.SeFormIdSource = DataRepository.SeFormProvider.GetBySeFormId(transactionManager, entity.SeFormId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeFormIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeFormIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeFormProvider.DeepLoad(transactionManager, entity.SeFormIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeFormIdSource

			#region SeUserAccountIdSource	
			if (CanDeepLoad(entity, "SeUserAccnt|SeUserAccountIdSource", deepLoadType, innerList) 
				&& entity.SeUserAccountIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeUserAccountId;
				SeUserAccnt tmpEntity = EntityManager.LocateEntity<SeUserAccnt>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUserAccnt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserAccountIdSource = tmpEntity;
				else
					entity.SeUserAccountIdSource = DataRepository.SeUserAccntProvider.GetBySeUserAccntId(transactionManager, entity.SeUserAccountId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserAccountIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserAccountIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserAccntProvider.DeepLoad(transactionManager, entity.SeUserAccountIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserAccountIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeUserAccntFormDiff object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeUserAccntFormDiff instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeUserAccntFormDiff Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserAccntFormDiff entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SeFormIdSource
			if (CanDeepSave(entity, "SeForm|SeFormIdSource", deepSaveType, innerList) 
				&& entity.SeFormIdSource != null)
			{
				DataRepository.SeFormProvider.Save(transactionManager, entity.SeFormIdSource);
				entity.SeFormId = entity.SeFormIdSource.SeFormId;
			}
			#endregion 
			
			#region SeUserAccountIdSource
			if (CanDeepSave(entity, "SeUserAccnt|SeUserAccountIdSource", deepSaveType, innerList) 
				&& entity.SeUserAccountIdSource != null)
			{
				DataRepository.SeUserAccntProvider.Save(transactionManager, entity.SeUserAccountIdSource);
				entity.SeUserAccountId = entity.SeUserAccountIdSource.SeUserAccntId;
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
	
	#region SeUserAccntFormDiffChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeUserAccntFormDiff</c>
	///</summary>
	public enum SeUserAccntFormDiffChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SeForm</c> at SeFormIdSource
		///</summary>
		[ChildEntityType(typeof(SeForm))]
		SeForm,
		
		///<summary>
		/// Composite Property for <c>SeUserAccnt</c> at SeUserAccountIdSource
		///</summary>
		[ChildEntityType(typeof(SeUserAccnt))]
		SeUserAccnt,
	}
	
	#endregion SeUserAccntFormDiffChildEntityTypes
	
	#region SeUserAccntFormDiffFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeUserAccntFormDiffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeUserAccntFormDiff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeUserAccntFormDiffFilterBuilder : SqlFilterBuilder<SeUserAccntFormDiffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeUserAccntFormDiffFilterBuilder class.
		/// </summary>
		public SeUserAccntFormDiffFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeUserAccntFormDiffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeUserAccntFormDiffFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeUserAccntFormDiffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeUserAccntFormDiffFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeUserAccntFormDiffFilterBuilder
	
	#region SeUserAccntFormDiffParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeUserAccntFormDiffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeUserAccntFormDiff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeUserAccntFormDiffParameterBuilder : ParameterizedSqlFilterBuilder<SeUserAccntFormDiffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeUserAccntFormDiffParameterBuilder class.
		/// </summary>
		public SeUserAccntFormDiffParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeUserAccntFormDiffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeUserAccntFormDiffParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeUserAccntFormDiffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeUserAccntFormDiffParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeUserAccntFormDiffParameterBuilder
	
	#region SeUserAccntFormDiffSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeUserAccntFormDiffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeUserAccntFormDiff"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeUserAccntFormDiffSortBuilder : SqlSortBuilder<SeUserAccntFormDiffColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeUserAccntFormDiffSqlSortBuilder class.
		/// </summary>
		public SeUserAccntFormDiffSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeUserAccntFormDiffSortBuilder
	
} // end namespace
