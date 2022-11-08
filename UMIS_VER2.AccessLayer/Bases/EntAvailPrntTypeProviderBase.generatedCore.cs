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
	/// This class is the base class for any <see cref="EntAvailPrntTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntAvailPrntTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntAvailPrntType, UMIS_VER2.BusinessLyer.EntAvailPrntTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntAvailPrntTypeKey key)
		{
			return Delete(transactionManager, key.EntAvailPrntTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entAvailPrntTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entAvailPrntTypeId)
		{
			return Delete(null, _entAvailPrntTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entAvailPrntTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entAvailPrntTypeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_AVAIL_PRNT_TYPE_ENTITY_TYPE1 key.
		///		FK_ENT_AVAIL_PRNT_TYPE_ENTITY_TYPE1 Description: 
		/// </summary>
		/// <param name="_entCodeEntityTypePrntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntAvailPrntType objects.</returns>
		public TList<EntAvailPrntType> GetByEntCodeEntityTypePrntId(System.Decimal _entCodeEntityTypePrntId)
		{
			int count = -1;
			return GetByEntCodeEntityTypePrntId(_entCodeEntityTypePrntId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_AVAIL_PRNT_TYPE_ENTITY_TYPE1 key.
		///		FK_ENT_AVAIL_PRNT_TYPE_ENTITY_TYPE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypePrntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntAvailPrntType objects.</returns>
		/// <remarks></remarks>
		public TList<EntAvailPrntType> GetByEntCodeEntityTypePrntId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypePrntId)
		{
			int count = -1;
			return GetByEntCodeEntityTypePrntId(transactionManager, _entCodeEntityTypePrntId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_AVAIL_PRNT_TYPE_ENTITY_TYPE1 key.
		///		FK_ENT_AVAIL_PRNT_TYPE_ENTITY_TYPE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypePrntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntAvailPrntType objects.</returns>
		public TList<EntAvailPrntType> GetByEntCodeEntityTypePrntId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypePrntId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeEntityTypePrntId(transactionManager, _entCodeEntityTypePrntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_AVAIL_PRNT_TYPE_ENTITY_TYPE1 key.
		///		fkEntAvailPrntTypeEntityType1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCodeEntityTypePrntId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntAvailPrntType objects.</returns>
		public TList<EntAvailPrntType> GetByEntCodeEntityTypePrntId(System.Decimal _entCodeEntityTypePrntId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntCodeEntityTypePrntId(null, _entCodeEntityTypePrntId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_AVAIL_PRNT_TYPE_ENTITY_TYPE1 key.
		///		fkEntAvailPrntTypeEntityType1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCodeEntityTypePrntId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntAvailPrntType objects.</returns>
		public TList<EntAvailPrntType> GetByEntCodeEntityTypePrntId(System.Decimal _entCodeEntityTypePrntId, int start, int pageLength,out int count)
		{
			return GetByEntCodeEntityTypePrntId(null, _entCodeEntityTypePrntId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_AVAIL_PRNT_TYPE_ENTITY_TYPE1 key.
		///		FK_ENT_AVAIL_PRNT_TYPE_ENTITY_TYPE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypePrntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntAvailPrntType objects.</returns>
		public abstract TList<EntAvailPrntType> GetByEntCodeEntityTypePrntId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypePrntId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntAvailPrntType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntAvailPrntTypeKey key, int start, int pageLength)
		{
			return GetByEntAvailPrntTypeId(transactionManager, key.EntAvailPrntTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntAvailPrntType&gt;"/> class.</returns>
		public TList<EntAvailPrntType> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntAvailPrntType&gt;"/> class.</returns>
		public TList<EntAvailPrntType> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntAvailPrntType&gt;"/> class.</returns>
		public TList<EntAvailPrntType> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntAvailPrntType&gt;"/> class.</returns>
		public TList<EntAvailPrntType> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntAvailPrntType&gt;"/> class.</returns>
		public TList<EntAvailPrntType> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntAvailPrntType&gt;"/> class.</returns>
		public abstract TList<EntAvailPrntType> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_AVAIL_PRNT_TYPE index.
		/// </summary>
		/// <param name="_entAvailPrntTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntAvailPrntType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntAvailPrntType GetByEntAvailPrntTypeId(System.Decimal _entAvailPrntTypeId)
		{
			int count = -1;
			return GetByEntAvailPrntTypeId(null,_entAvailPrntTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_AVAIL_PRNT_TYPE index.
		/// </summary>
		/// <param name="_entAvailPrntTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntAvailPrntType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntAvailPrntType GetByEntAvailPrntTypeId(System.Decimal _entAvailPrntTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntAvailPrntTypeId(null, _entAvailPrntTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_AVAIL_PRNT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entAvailPrntTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntAvailPrntType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntAvailPrntType GetByEntAvailPrntTypeId(TransactionManager transactionManager, System.Decimal _entAvailPrntTypeId)
		{
			int count = -1;
			return GetByEntAvailPrntTypeId(transactionManager, _entAvailPrntTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_AVAIL_PRNT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entAvailPrntTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntAvailPrntType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntAvailPrntType GetByEntAvailPrntTypeId(TransactionManager transactionManager, System.Decimal _entAvailPrntTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntAvailPrntTypeId(transactionManager, _entAvailPrntTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_AVAIL_PRNT_TYPE index.
		/// </summary>
		/// <param name="_entAvailPrntTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntAvailPrntType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntAvailPrntType GetByEntAvailPrntTypeId(System.Decimal _entAvailPrntTypeId, int start, int pageLength, out int count)
		{
			return GetByEntAvailPrntTypeId(null, _entAvailPrntTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_AVAIL_PRNT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entAvailPrntTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntAvailPrntType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntAvailPrntType GetByEntAvailPrntTypeId(TransactionManager transactionManager, System.Decimal _entAvailPrntTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_AVAIL_PRNT_TYPE index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="_entCodeEntityTypePrntId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntAvailPrntType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntAvailPrntType GetByEntCodeEntityTypeIdEntCodeEntityTypePrntId(System.Decimal _entCodeEntityTypeId, System.Decimal _entCodeEntityTypePrntId)
		{
			int count = -1;
			return GetByEntCodeEntityTypeIdEntCodeEntityTypePrntId(null,_entCodeEntityTypeId, _entCodeEntityTypePrntId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_AVAIL_PRNT_TYPE index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="_entCodeEntityTypePrntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntAvailPrntType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntAvailPrntType GetByEntCodeEntityTypeIdEntCodeEntityTypePrntId(System.Decimal _entCodeEntityTypeId, System.Decimal _entCodeEntityTypePrntId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeEntityTypeIdEntCodeEntityTypePrntId(null, _entCodeEntityTypeId, _entCodeEntityTypePrntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_AVAIL_PRNT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="_entCodeEntityTypePrntId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntAvailPrntType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntAvailPrntType GetByEntCodeEntityTypeIdEntCodeEntityTypePrntId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, System.Decimal _entCodeEntityTypePrntId)
		{
			int count = -1;
			return GetByEntCodeEntityTypeIdEntCodeEntityTypePrntId(transactionManager, _entCodeEntityTypeId, _entCodeEntityTypePrntId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_AVAIL_PRNT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="_entCodeEntityTypePrntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntAvailPrntType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntAvailPrntType GetByEntCodeEntityTypeIdEntCodeEntityTypePrntId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, System.Decimal _entCodeEntityTypePrntId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeEntityTypeIdEntCodeEntityTypePrntId(transactionManager, _entCodeEntityTypeId, _entCodeEntityTypePrntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_AVAIL_PRNT_TYPE index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="_entCodeEntityTypePrntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntAvailPrntType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntAvailPrntType GetByEntCodeEntityTypeIdEntCodeEntityTypePrntId(System.Decimal _entCodeEntityTypeId, System.Decimal _entCodeEntityTypePrntId, int start, int pageLength, out int count)
		{
			return GetByEntCodeEntityTypeIdEntCodeEntityTypePrntId(null, _entCodeEntityTypeId, _entCodeEntityTypePrntId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_AVAIL_PRNT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="_entCodeEntityTypePrntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntAvailPrntType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntAvailPrntType GetByEntCodeEntityTypeIdEntCodeEntityTypePrntId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, System.Decimal _entCodeEntityTypePrntId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntAvailPrntType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntAvailPrntType&gt;"/></returns>
		public static TList<EntAvailPrntType> Fill(IDataReader reader, TList<EntAvailPrntType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntAvailPrntType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntAvailPrntType")
					.Append("|").Append((System.Decimal)reader["ENT_AVAIL_PRNT_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntAvailPrntType>(
					key.ToString(), // EntityTrackingKey
					"EntAvailPrntType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntAvailPrntType();
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
					c.EntAvailPrntTypeId = (System.Decimal)reader["ENT_AVAIL_PRNT_TYPE_ID"];
					c.OriginalEntAvailPrntTypeId = c.EntAvailPrntTypeId;
					c.EntCodeEntityTypeId = (System.Decimal)reader["ENT_CODE_ENTITY_TYPE_ID"];
					c.EntCodeEntityTypePrntId = (System.Decimal)reader["ENT_CODE_ENTITY_TYPE_PRNT_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntAvailPrntType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntAvailPrntType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntAvailPrntType entity)
		{
			if (!reader.Read()) return;
			
			entity.EntAvailPrntTypeId = (System.Decimal)reader[((int)EntAvailPrntTypeColumn.EntAvailPrntTypeId - 1)];
			entity.OriginalEntAvailPrntTypeId = (System.Decimal)reader["ENT_AVAIL_PRNT_TYPE_ID"];
			entity.EntCodeEntityTypeId = (System.Decimal)reader[((int)EntAvailPrntTypeColumn.EntCodeEntityTypeId - 1)];
			entity.EntCodeEntityTypePrntId = (System.Decimal)reader[((int)EntAvailPrntTypeColumn.EntCodeEntityTypePrntId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntAvailPrntType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntAvailPrntType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntAvailPrntType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntAvailPrntTypeId = (System.Decimal)dataRow["ENT_AVAIL_PRNT_TYPE_ID"];
			entity.OriginalEntAvailPrntTypeId = (System.Decimal)dataRow["ENT_AVAIL_PRNT_TYPE_ID"];
			entity.EntCodeEntityTypeId = (System.Decimal)dataRow["ENT_CODE_ENTITY_TYPE_ID"];
			entity.EntCodeEntityTypePrntId = (System.Decimal)dataRow["ENT_CODE_ENTITY_TYPE_PRNT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntAvailPrntType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntAvailPrntType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntAvailPrntType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EntCodeEntityTypePrntIdSource	
			if (CanDeepLoad(entity, "EntCodeEntityType|EntCodeEntityTypePrntIdSource", deepLoadType, innerList) 
				&& entity.EntCodeEntityTypePrntIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntCodeEntityTypePrntId;
				EntCodeEntityType tmpEntity = EntityManager.LocateEntity<EntCodeEntityType>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCodeEntityType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCodeEntityTypePrntIdSource = tmpEntity;
				else
					entity.EntCodeEntityTypePrntIdSource = DataRepository.EntCodeEntityTypeProvider.GetByEntCodeEntityTypeId(transactionManager, entity.EntCodeEntityTypePrntId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodeEntityTypePrntIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCodeEntityTypePrntIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCodeEntityTypeProvider.DeepLoad(transactionManager, entity.EntCodeEntityTypePrntIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCodeEntityTypePrntIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntAvailPrntType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntAvailPrntType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntAvailPrntType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntAvailPrntType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EntCodeEntityTypePrntIdSource
			if (CanDeepSave(entity, "EntCodeEntityType|EntCodeEntityTypePrntIdSource", deepSaveType, innerList) 
				&& entity.EntCodeEntityTypePrntIdSource != null)
			{
				DataRepository.EntCodeEntityTypeProvider.Save(transactionManager, entity.EntCodeEntityTypePrntIdSource);
				entity.EntCodeEntityTypePrntId = entity.EntCodeEntityTypePrntIdSource.EntCodeEntityTypeId;
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
	
	#region EntAvailPrntTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntAvailPrntType</c>
	///</summary>
	public enum EntAvailPrntTypeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EntCodeEntityType</c> at EntCodeEntityTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodeEntityType))]
		EntCodeEntityType,
	}
	
	#endregion EntAvailPrntTypeChildEntityTypes
	
	#region EntAvailPrntTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntAvailPrntTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntAvailPrntType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntAvailPrntTypeFilterBuilder : SqlFilterBuilder<EntAvailPrntTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntAvailPrntTypeFilterBuilder class.
		/// </summary>
		public EntAvailPrntTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntAvailPrntTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntAvailPrntTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntAvailPrntTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntAvailPrntTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntAvailPrntTypeFilterBuilder
	
	#region EntAvailPrntTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntAvailPrntTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntAvailPrntType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntAvailPrntTypeParameterBuilder : ParameterizedSqlFilterBuilder<EntAvailPrntTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntAvailPrntTypeParameterBuilder class.
		/// </summary>
		public EntAvailPrntTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntAvailPrntTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntAvailPrntTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntAvailPrntTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntAvailPrntTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntAvailPrntTypeParameterBuilder
	
	#region EntAvailPrntTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntAvailPrntTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntAvailPrntType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntAvailPrntTypeSortBuilder : SqlSortBuilder<EntAvailPrntTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntAvailPrntTypeSqlSortBuilder class.
		/// </summary>
		public EntAvailPrntTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntAvailPrntTypeSortBuilder
	
} // end namespace
