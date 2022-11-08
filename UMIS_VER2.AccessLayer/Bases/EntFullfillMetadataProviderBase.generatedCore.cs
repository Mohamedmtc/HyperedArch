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
	/// This class is the base class for any <see cref="EntFullfillMetadataProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntFullfillMetadataProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntFullfillMetadata, UMIS_VER2.BusinessLyer.EntFullfillMetadataKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntFullfillMetadataKey key)
		{
			return Delete(transactionManager, key.EntFullfillMdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entFullfillMdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entFullfillMdId)
		{
			return Delete(null, _entFullfillMdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entFullfillMdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entFullfillMdId);		
		
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
		public override UMIS_VER2.BusinessLyer.EntFullfillMetadata Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntFullfillMetadataKey key, int start, int pageLength)
		{
			return GetByEntFullfillMdId(transactionManager, key.EntFullfillMdId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMetadata&gt;"/> class.</returns>
		public TList<EntFullfillMetadata> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(null,_entCodeEntityTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMetadata&gt;"/> class.</returns>
		public TList<EntFullfillMetadata> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(null, _entCodeEntityTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMetadata&gt;"/> class.</returns>
		public TList<EntFullfillMetadata> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(transactionManager, _entCodeEntityTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMetadata&gt;"/> class.</returns>
		public TList<EntFullfillMetadata> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(transactionManager, _entCodeEntityTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMetadata&gt;"/> class.</returns>
		public TList<EntFullfillMetadata> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count)
		{
			return GetByEntCodeEntityTypeId(null, _entCodeEntityTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMetadata&gt;"/> class.</returns>
		public abstract TList<EntFullfillMetadata> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_CODE_FULLFILL_MD_1 index.
		/// </summary>
		/// <param name="_entCodeFullfillMdId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMetadata&gt;"/> class.</returns>
		public TList<EntFullfillMetadata> GetByEntCodeFullfillMdId(System.Decimal _entCodeFullfillMdId)
		{
			int count = -1;
			return GetByEntCodeFullfillMdId(null,_entCodeFullfillMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_FULLFILL_MD_1 index.
		/// </summary>
		/// <param name="_entCodeFullfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMetadata&gt;"/> class.</returns>
		public TList<EntFullfillMetadata> GetByEntCodeFullfillMdId(System.Decimal _entCodeFullfillMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeFullfillMdId(null, _entCodeFullfillMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_FULLFILL_MD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeFullfillMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMetadata&gt;"/> class.</returns>
		public TList<EntFullfillMetadata> GetByEntCodeFullfillMdId(TransactionManager transactionManager, System.Decimal _entCodeFullfillMdId)
		{
			int count = -1;
			return GetByEntCodeFullfillMdId(transactionManager, _entCodeFullfillMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_FULLFILL_MD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeFullfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMetadata&gt;"/> class.</returns>
		public TList<EntFullfillMetadata> GetByEntCodeFullfillMdId(TransactionManager transactionManager, System.Decimal _entCodeFullfillMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeFullfillMdId(transactionManager, _entCodeFullfillMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_FULLFILL_MD_1 index.
		/// </summary>
		/// <param name="_entCodeFullfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMetadata&gt;"/> class.</returns>
		public TList<EntFullfillMetadata> GetByEntCodeFullfillMdId(System.Decimal _entCodeFullfillMdId, int start, int pageLength, out int count)
		{
			return GetByEntCodeFullfillMdId(null, _entCodeFullfillMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_FULLFILL_MD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeFullfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMetadata&gt;"/> class.</returns>
		public abstract TList<EntFullfillMetadata> GetByEntCodeFullfillMdId(TransactionManager transactionManager, System.Decimal _entCodeFullfillMdId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_FULLFILL_METADATA index.
		/// </summary>
		/// <param name="_entFullfillMdId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMetadata GetByEntFullfillMdId(System.Decimal _entFullfillMdId)
		{
			int count = -1;
			return GetByEntFullfillMdId(null,_entFullfillMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_FULLFILL_METADATA index.
		/// </summary>
		/// <param name="_entFullfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMetadata GetByEntFullfillMdId(System.Decimal _entFullfillMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntFullfillMdId(null, _entFullfillMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_FULLFILL_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entFullfillMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMetadata GetByEntFullfillMdId(TransactionManager transactionManager, System.Decimal _entFullfillMdId)
		{
			int count = -1;
			return GetByEntFullfillMdId(transactionManager, _entFullfillMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_FULLFILL_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entFullfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMetadata GetByEntFullfillMdId(TransactionManager transactionManager, System.Decimal _entFullfillMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntFullfillMdId(transactionManager, _entFullfillMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_FULLFILL_METADATA index.
		/// </summary>
		/// <param name="_entFullfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMetadata GetByEntFullfillMdId(System.Decimal _entFullfillMdId, int start, int pageLength, out int count)
		{
			return GetByEntFullfillMdId(null, _entFullfillMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_FULLFILL_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entFullfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMetadata"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntFullfillMetadata GetByEntFullfillMdId(TransactionManager transactionManager, System.Decimal _entFullfillMdId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_FULLFILL_METADATA index.
		/// </summary>
		/// <param name="_entCodeFullfillMdId"></param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMetadata GetByEntCodeFullfillMdIdEntCodeEntityTypeId(System.Decimal _entCodeFullfillMdId, System.Decimal _entCodeEntityTypeId)
		{
			int count = -1;
			return GetByEntCodeFullfillMdIdEntCodeEntityTypeId(null,_entCodeFullfillMdId, _entCodeEntityTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_FULLFILL_METADATA index.
		/// </summary>
		/// <param name="_entCodeFullfillMdId"></param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMetadata GetByEntCodeFullfillMdIdEntCodeEntityTypeId(System.Decimal _entCodeFullfillMdId, System.Decimal _entCodeEntityTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeFullfillMdIdEntCodeEntityTypeId(null, _entCodeFullfillMdId, _entCodeEntityTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_FULLFILL_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeFullfillMdId"></param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMetadata GetByEntCodeFullfillMdIdEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeFullfillMdId, System.Decimal _entCodeEntityTypeId)
		{
			int count = -1;
			return GetByEntCodeFullfillMdIdEntCodeEntityTypeId(transactionManager, _entCodeFullfillMdId, _entCodeEntityTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_FULLFILL_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeFullfillMdId"></param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMetadata GetByEntCodeFullfillMdIdEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeFullfillMdId, System.Decimal _entCodeEntityTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeFullfillMdIdEntCodeEntityTypeId(transactionManager, _entCodeFullfillMdId, _entCodeEntityTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_FULLFILL_METADATA index.
		/// </summary>
		/// <param name="_entCodeFullfillMdId"></param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMetadata GetByEntCodeFullfillMdIdEntCodeEntityTypeId(System.Decimal _entCodeFullfillMdId, System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count)
		{
			return GetByEntCodeFullfillMdIdEntCodeEntityTypeId(null, _entCodeFullfillMdId, _entCodeEntityTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_FULLFILL_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeFullfillMdId"></param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMetadata"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntFullfillMetadata GetByEntCodeFullfillMdIdEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeFullfillMdId, System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntFullfillMetadata&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntFullfillMetadata&gt;"/></returns>
		public static TList<EntFullfillMetadata> Fill(IDataReader reader, TList<EntFullfillMetadata> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntFullfillMetadata c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntFullfillMetadata")
					.Append("|").Append((System.Decimal)reader["ENT_FULLFILL_MD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntFullfillMetadata>(
					key.ToString(), // EntityTrackingKey
					"EntFullfillMetadata",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntFullfillMetadata();
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
					c.EntCodeFullfillMdId = (System.Decimal)reader["ENT_CODE_FULLFILL_MD_ID"];
					c.EntCodeEntityTypeId = (System.Decimal)reader["ENT_CODE_ENTITY_TYPE_ID"];
					c.EntFullfillMdId = (System.Decimal)reader["ENT_FULLFILL_MD_ID"];
					c.OriginalEntFullfillMdId = c.EntFullfillMdId;
					c.ObligFlg = Convert.IsDBNull(reader["OBLIG_FLG"]) ? null : (System.Decimal?)reader["OBLIG_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMetadata"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntFullfillMetadata"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntFullfillMetadata entity)
		{
			if (!reader.Read()) return;
			
			entity.EntCodeFullfillMdId = (System.Decimal)reader[((int)EntFullfillMetadataColumn.EntCodeFullfillMdId - 1)];
			entity.EntCodeEntityTypeId = (System.Decimal)reader[((int)EntFullfillMetadataColumn.EntCodeEntityTypeId - 1)];
			entity.EntFullfillMdId = (System.Decimal)reader[((int)EntFullfillMetadataColumn.EntFullfillMdId - 1)];
			entity.OriginalEntFullfillMdId = (System.Decimal)reader["ENT_FULLFILL_MD_ID"];
			entity.ObligFlg = (reader.IsDBNull(((int)EntFullfillMetadataColumn.ObligFlg - 1)))?null:(System.Decimal?)reader[((int)EntFullfillMetadataColumn.ObligFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMetadata"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntFullfillMetadata"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntFullfillMetadata entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntCodeFullfillMdId = (System.Decimal)dataRow["ENT_CODE_FULLFILL_MD_ID"];
			entity.EntCodeEntityTypeId = (System.Decimal)dataRow["ENT_CODE_ENTITY_TYPE_ID"];
			entity.EntFullfillMdId = (System.Decimal)dataRow["ENT_FULLFILL_MD_ID"];
			entity.OriginalEntFullfillMdId = (System.Decimal)dataRow["ENT_FULLFILL_MD_ID"];
			entity.ObligFlg = Convert.IsDBNull(dataRow["OBLIG_FLG"]) ? null : (System.Decimal?)dataRow["OBLIG_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntFullfillMetadata"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntFullfillMetadata Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntFullfillMetadata entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EntCodeEntityTypeIdSource	
			if (CanDeepLoad(entity, "EntCodeEntityType|EntCodeEntityTypeIdSource", deepLoadType, innerList) 
				&& entity.EntCodeEntityTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntCodeEntityTypeId;
				EntCodeEntityType tmpEntity = EntityManager.LocateEntity<EntCodeEntityType>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCodeEntityType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCodeEntityTypeIdSource = tmpEntity;
				else
					entity.EntCodeEntityTypeIdSource = DataRepository.EntCodeEntityTypeProvider.GetByEntCodeEntityTypeId(transactionManager, entity.EntCodeEntityTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodeEntityTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCodeEntityTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCodeEntityTypeProvider.DeepLoad(transactionManager, entity.EntCodeEntityTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCodeEntityTypeIdSource

			#region EntCodeFullfillMdIdSource	
			if (CanDeepLoad(entity, "EntCodeFullfillMetadata|EntCodeFullfillMdIdSource", deepLoadType, innerList) 
				&& entity.EntCodeFullfillMdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntCodeFullfillMdId;
				EntCodeFullfillMetadata tmpEntity = EntityManager.LocateEntity<EntCodeFullfillMetadata>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCodeFullfillMetadata), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCodeFullfillMdIdSource = tmpEntity;
				else
					entity.EntCodeFullfillMdIdSource = DataRepository.EntCodeFullfillMetadataProvider.GetByEntCodeFuulfillMdId(transactionManager, entity.EntCodeFullfillMdId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodeFullfillMdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCodeFullfillMdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCodeFullfillMetadataProvider.DeepLoad(transactionManager, entity.EntCodeFullfillMdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCodeFullfillMdIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntFullfillMdId methods when available
			
			#region EntFullfillMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntFullfillMdData>|EntFullfillMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntFullfillMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntFullfillMdDataCollection = DataRepository.EntFullfillMdDataProvider.GetByEntFullfillMdId(transactionManager, entity.EntFullfillMdId);

				if (deep && entity.EntFullfillMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntFullfillMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntFullfillMdData>) DataRepository.EntFullfillMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntFullfillMdDataCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntFullfillMetadata object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntFullfillMetadata instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntFullfillMetadata Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntFullfillMetadata entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EntCodeEntityTypeIdSource
			if (CanDeepSave(entity, "EntCodeEntityType|EntCodeEntityTypeIdSource", deepSaveType, innerList) 
				&& entity.EntCodeEntityTypeIdSource != null)
			{
				DataRepository.EntCodeEntityTypeProvider.Save(transactionManager, entity.EntCodeEntityTypeIdSource);
				entity.EntCodeEntityTypeId = entity.EntCodeEntityTypeIdSource.EntCodeEntityTypeId;
			}
			#endregion 
			
			#region EntCodeFullfillMdIdSource
			if (CanDeepSave(entity, "EntCodeFullfillMetadata|EntCodeFullfillMdIdSource", deepSaveType, innerList) 
				&& entity.EntCodeFullfillMdIdSource != null)
			{
				DataRepository.EntCodeFullfillMetadataProvider.Save(transactionManager, entity.EntCodeFullfillMdIdSource);
				entity.EntCodeFullfillMdId = entity.EntCodeFullfillMdIdSource.EntCodeFuulfillMdId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EntFullfillMdData>
				if (CanDeepSave(entity.EntFullfillMdDataCollection, "List<EntFullfillMdData>|EntFullfillMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntFullfillMdData child in entity.EntFullfillMdDataCollection)
					{
						if(child.EntFullfillMdIdSource != null)
						{
							child.EntFullfillMdId = child.EntFullfillMdIdSource.EntFullfillMdId;
						}
						else
						{
							child.EntFullfillMdId = entity.EntFullfillMdId;
						}

					}

					if (entity.EntFullfillMdDataCollection.Count > 0 || entity.EntFullfillMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntFullfillMdDataProvider.Save(transactionManager, entity.EntFullfillMdDataCollection);
						
						deepHandles.Add("EntFullfillMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntFullfillMdData >) DataRepository.EntFullfillMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntFullfillMdDataCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntFullfillMetadataChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntFullfillMetadata</c>
	///</summary>
	public enum EntFullfillMetadataChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EntCodeEntityType</c> at EntCodeEntityTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodeEntityType))]
		EntCodeEntityType,
		
		///<summary>
		/// Composite Property for <c>EntCodeFullfillMetadata</c> at EntCodeFullfillMdIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodeFullfillMetadata))]
		EntCodeFullfillMetadata,
		///<summary>
		/// Collection of <c>EntFullfillMetadata</c> as OneToMany for EntFullfillMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntFullfillMdData>))]
		EntFullfillMdDataCollection,
	}
	
	#endregion EntFullfillMetadataChildEntityTypes
	
	#region EntFullfillMetadataFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntFullfillMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntFullfillMetadata"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntFullfillMetadataFilterBuilder : SqlFilterBuilder<EntFullfillMetadataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntFullfillMetadataFilterBuilder class.
		/// </summary>
		public EntFullfillMetadataFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntFullfillMetadataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntFullfillMetadataFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntFullfillMetadataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntFullfillMetadataFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntFullfillMetadataFilterBuilder
	
	#region EntFullfillMetadataParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntFullfillMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntFullfillMetadata"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntFullfillMetadataParameterBuilder : ParameterizedSqlFilterBuilder<EntFullfillMetadataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntFullfillMetadataParameterBuilder class.
		/// </summary>
		public EntFullfillMetadataParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntFullfillMetadataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntFullfillMetadataParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntFullfillMetadataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntFullfillMetadataParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntFullfillMetadataParameterBuilder
	
	#region EntFullfillMetadataSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntFullfillMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntFullfillMetadata"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntFullfillMetadataSortBuilder : SqlSortBuilder<EntFullfillMetadataColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntFullfillMetadataSqlSortBuilder class.
		/// </summary>
		public EntFullfillMetadataSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntFullfillMetadataSortBuilder
	
} // end namespace
