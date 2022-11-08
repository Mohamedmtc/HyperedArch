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
	/// This class is the base class for any <see cref="ScHallEquipProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScHallEquipProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScHallEquip, UMIS_VER2.BusinessLyer.ScHallEquipKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScHallEquipKey key)
		{
			return Delete(transactionManager, key.ScHallEquipId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scHallEquipId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scHallEquipId)
		{
			return Delete(null, _scHallEquipId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallEquipId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scHallEquipId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_EQUIP_SC_CDE_HALL_EQUIP key.
		///		FK_SC_HALL_EQUIP_SC_CDE_HALL_EQUIP Description: 
		/// </summary>
		/// <param name="_scCdeHallEquipId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallEquip objects.</returns>
		public TList<ScHallEquip> GetByScCdeHallEquipId(System.Decimal _scCdeHallEquipId)
		{
			int count = -1;
			return GetByScCdeHallEquipId(_scCdeHallEquipId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_EQUIP_SC_CDE_HALL_EQUIP key.
		///		FK_SC_HALL_EQUIP_SC_CDE_HALL_EQUIP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeHallEquipId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallEquip objects.</returns>
		/// <remarks></remarks>
		public TList<ScHallEquip> GetByScCdeHallEquipId(TransactionManager transactionManager, System.Decimal _scCdeHallEquipId)
		{
			int count = -1;
			return GetByScCdeHallEquipId(transactionManager, _scCdeHallEquipId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_EQUIP_SC_CDE_HALL_EQUIP key.
		///		FK_SC_HALL_EQUIP_SC_CDE_HALL_EQUIP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeHallEquipId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallEquip objects.</returns>
		public TList<ScHallEquip> GetByScCdeHallEquipId(TransactionManager transactionManager, System.Decimal _scCdeHallEquipId, int start, int pageLength)
		{
			int count = -1;
			return GetByScCdeHallEquipId(transactionManager, _scCdeHallEquipId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_EQUIP_SC_CDE_HALL_EQUIP key.
		///		fkScHallEquipScCdeHallEquip Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scCdeHallEquipId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallEquip objects.</returns>
		public TList<ScHallEquip> GetByScCdeHallEquipId(System.Decimal _scCdeHallEquipId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScCdeHallEquipId(null, _scCdeHallEquipId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_EQUIP_SC_CDE_HALL_EQUIP key.
		///		fkScHallEquipScCdeHallEquip Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scCdeHallEquipId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallEquip objects.</returns>
		public TList<ScHallEquip> GetByScCdeHallEquipId(System.Decimal _scCdeHallEquipId, int start, int pageLength,out int count)
		{
			return GetByScCdeHallEquipId(null, _scCdeHallEquipId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_EQUIP_SC_CDE_HALL_EQUIP key.
		///		FK_SC_HALL_EQUIP_SC_CDE_HALL_EQUIP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeHallEquipId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallEquip objects.</returns>
		public abstract TList<ScHallEquip> GetByScCdeHallEquipId(TransactionManager transactionManager, System.Decimal _scCdeHallEquipId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_EQUIP_SC_HALL key.
		///		FK_SC_HALL_EQUIP_SC_HALL Description: 
		/// </summary>
		/// <param name="_scHallId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallEquip objects.</returns>
		public TList<ScHallEquip> GetByScHallId(System.Decimal _scHallId)
		{
			int count = -1;
			return GetByScHallId(_scHallId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_EQUIP_SC_HALL key.
		///		FK_SC_HALL_EQUIP_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallEquip objects.</returns>
		/// <remarks></remarks>
		public TList<ScHallEquip> GetByScHallId(TransactionManager transactionManager, System.Decimal _scHallId)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_EQUIP_SC_HALL key.
		///		FK_SC_HALL_EQUIP_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallEquip objects.</returns>
		public TList<ScHallEquip> GetByScHallId(TransactionManager transactionManager, System.Decimal _scHallId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_EQUIP_SC_HALL key.
		///		fkScHallEquipScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallEquip objects.</returns>
		public TList<ScHallEquip> GetByScHallId(System.Decimal _scHallId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScHallId(null, _scHallId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_EQUIP_SC_HALL key.
		///		fkScHallEquipScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallEquip objects.</returns>
		public TList<ScHallEquip> GetByScHallId(System.Decimal _scHallId, int start, int pageLength,out int count)
		{
			return GetByScHallId(null, _scHallId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_EQUIP_SC_HALL key.
		///		FK_SC_HALL_EQUIP_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallEquip objects.</returns>
		public abstract TList<ScHallEquip> GetByScHallId(TransactionManager transactionManager, System.Decimal _scHallId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScHallEquip Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScHallEquipKey key, int start, int pageLength)
		{
			return GetByScHallEquipId(transactionManager, key.ScHallEquipId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_HALL_EQUIP index.
		/// </summary>
		/// <param name="_scHallEquipId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHallEquip GetByScHallEquipId(System.Decimal _scHallEquipId)
		{
			int count = -1;
			return GetByScHallEquipId(null,_scHallEquipId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_HALL_EQUIP index.
		/// </summary>
		/// <param name="_scHallEquipId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHallEquip GetByScHallEquipId(System.Decimal _scHallEquipId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallEquipId(null, _scHallEquipId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_HALL_EQUIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallEquipId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHallEquip GetByScHallEquipId(TransactionManager transactionManager, System.Decimal _scHallEquipId)
		{
			int count = -1;
			return GetByScHallEquipId(transactionManager, _scHallEquipId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_HALL_EQUIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallEquipId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHallEquip GetByScHallEquipId(TransactionManager transactionManager, System.Decimal _scHallEquipId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallEquipId(transactionManager, _scHallEquipId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_HALL_EQUIP index.
		/// </summary>
		/// <param name="_scHallEquipId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHallEquip GetByScHallEquipId(System.Decimal _scHallEquipId, int start, int pageLength, out int count)
		{
			return GetByScHallEquipId(null, _scHallEquipId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_HALL_EQUIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallEquipId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHallEquip"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScHallEquip GetByScHallEquipId(TransactionManager transactionManager, System.Decimal _scHallEquipId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_HALL_EQUIP index.
		/// </summary>
		/// <param name="_scHallId"></param>
		/// <param name="_scCdeHallEquipId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHallEquip GetByScHallIdScCdeHallEquipId(System.Decimal _scHallId, System.Decimal _scCdeHallEquipId)
		{
			int count = -1;
			return GetByScHallIdScCdeHallEquipId(null,_scHallId, _scCdeHallEquipId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_EQUIP index.
		/// </summary>
		/// <param name="_scHallId"></param>
		/// <param name="_scCdeHallEquipId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHallEquip GetByScHallIdScCdeHallEquipId(System.Decimal _scHallId, System.Decimal _scCdeHallEquipId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallIdScCdeHallEquipId(null, _scHallId, _scCdeHallEquipId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_EQUIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <param name="_scCdeHallEquipId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHallEquip GetByScHallIdScCdeHallEquipId(TransactionManager transactionManager, System.Decimal _scHallId, System.Decimal _scCdeHallEquipId)
		{
			int count = -1;
			return GetByScHallIdScCdeHallEquipId(transactionManager, _scHallId, _scCdeHallEquipId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_EQUIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <param name="_scCdeHallEquipId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHallEquip GetByScHallIdScCdeHallEquipId(TransactionManager transactionManager, System.Decimal _scHallId, System.Decimal _scCdeHallEquipId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallIdScCdeHallEquipId(transactionManager, _scHallId, _scCdeHallEquipId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_EQUIP index.
		/// </summary>
		/// <param name="_scHallId"></param>
		/// <param name="_scCdeHallEquipId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHallEquip"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHallEquip GetByScHallIdScCdeHallEquipId(System.Decimal _scHallId, System.Decimal _scCdeHallEquipId, int start, int pageLength, out int count)
		{
			return GetByScHallIdScCdeHallEquipId(null, _scHallId, _scCdeHallEquipId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_HALL_EQUIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <param name="_scCdeHallEquipId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHallEquip"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScHallEquip GetByScHallIdScCdeHallEquipId(TransactionManager transactionManager, System.Decimal _scHallId, System.Decimal _scCdeHallEquipId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScHallEquip&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScHallEquip&gt;"/></returns>
		public static TList<ScHallEquip> Fill(IDataReader reader, TList<ScHallEquip> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScHallEquip c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScHallEquip")
					.Append("|").Append((System.Decimal)reader["SC_HALL_EQUIP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScHallEquip>(
					key.ToString(), // EntityTrackingKey
					"ScHallEquip",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScHallEquip();
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
					c.ScHallEquipId = (System.Decimal)reader["SC_HALL_EQUIP_ID"];
					c.OriginalScHallEquipId = c.ScHallEquipId;
					c.ScHallId = (System.Decimal)reader["SC_HALL_ID"];
					c.ScCdeHallEquipId = (System.Decimal)reader["SC_CDE_HALL_EQUIP_ID"];
					c.Count = (System.Decimal)reader["COUNT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScHallEquip"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScHallEquip"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScHallEquip entity)
		{
			if (!reader.Read()) return;
			
			entity.ScHallEquipId = (System.Decimal)reader[((int)ScHallEquipColumn.ScHallEquipId - 1)];
			entity.OriginalScHallEquipId = (System.Decimal)reader["SC_HALL_EQUIP_ID"];
			entity.ScHallId = (System.Decimal)reader[((int)ScHallEquipColumn.ScHallId - 1)];
			entity.ScCdeHallEquipId = (System.Decimal)reader[((int)ScHallEquipColumn.ScCdeHallEquipId - 1)];
			entity.Count = (System.Decimal)reader[((int)ScHallEquipColumn.Count - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScHallEquip"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScHallEquip"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScHallEquip entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScHallEquipId = (System.Decimal)dataRow["SC_HALL_EQUIP_ID"];
			entity.OriginalScHallEquipId = (System.Decimal)dataRow["SC_HALL_EQUIP_ID"];
			entity.ScHallId = (System.Decimal)dataRow["SC_HALL_ID"];
			entity.ScCdeHallEquipId = (System.Decimal)dataRow["SC_CDE_HALL_EQUIP_ID"];
			entity.Count = (System.Decimal)dataRow["COUNT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScHallEquip"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScHallEquip Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScHallEquip entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region ScCdeHallEquipIdSource	
			if (CanDeepLoad(entity, "ScCdeHallEquip|ScCdeHallEquipIdSource", deepLoadType, innerList) 
				&& entity.ScCdeHallEquipIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScCdeHallEquipId;
				ScCdeHallEquip tmpEntity = EntityManager.LocateEntity<ScCdeHallEquip>(EntityLocator.ConstructKeyFromPkItems(typeof(ScCdeHallEquip), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScCdeHallEquipIdSource = tmpEntity;
				else
					entity.ScCdeHallEquipIdSource = DataRepository.ScCdeHallEquipProvider.GetByScCdeHallEquipId(transactionManager, entity.ScCdeHallEquipId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScCdeHallEquipIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScCdeHallEquipIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScCdeHallEquipProvider.DeepLoad(transactionManager, entity.ScCdeHallEquipIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScCdeHallEquipIdSource

			#region ScHallIdSource	
			if (CanDeepLoad(entity, "ScHall|ScHallIdSource", deepLoadType, innerList) 
				&& entity.ScHallIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScHallId;
				ScHall tmpEntity = EntityManager.LocateEntity<ScHall>(EntityLocator.ConstructKeyFromPkItems(typeof(ScHall), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScHallIdSource = tmpEntity;
				else
					entity.ScHallIdSource = DataRepository.ScHallProvider.GetByScHallId(transactionManager, entity.ScHallId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScHallIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScHallIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScHallProvider.DeepLoad(transactionManager, entity.ScHallIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScHallIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScHallEquip object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScHallEquip instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScHallEquip Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScHallEquip entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region ScCdeHallEquipIdSource
			if (CanDeepSave(entity, "ScCdeHallEquip|ScCdeHallEquipIdSource", deepSaveType, innerList) 
				&& entity.ScCdeHallEquipIdSource != null)
			{
				DataRepository.ScCdeHallEquipProvider.Save(transactionManager, entity.ScCdeHallEquipIdSource);
				entity.ScCdeHallEquipId = entity.ScCdeHallEquipIdSource.ScCdeHallEquipId;
			}
			#endregion 
			
			#region ScHallIdSource
			if (CanDeepSave(entity, "ScHall|ScHallIdSource", deepSaveType, innerList) 
				&& entity.ScHallIdSource != null)
			{
				DataRepository.ScHallProvider.Save(transactionManager, entity.ScHallIdSource);
				entity.ScHallId = entity.ScHallIdSource.ScHallId;
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
	
	#region ScHallEquipChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScHallEquip</c>
	///</summary>
	public enum ScHallEquipChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>ScCdeHallEquip</c> at ScCdeHallEquipIdSource
		///</summary>
		[ChildEntityType(typeof(ScCdeHallEquip))]
		ScCdeHallEquip,
		
		///<summary>
		/// Composite Property for <c>ScHall</c> at ScHallIdSource
		///</summary>
		[ChildEntityType(typeof(ScHall))]
		ScHall,
	}
	
	#endregion ScHallEquipChildEntityTypes
	
	#region ScHallEquipFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScHallEquipColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScHallEquip"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScHallEquipFilterBuilder : SqlFilterBuilder<ScHallEquipColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScHallEquipFilterBuilder class.
		/// </summary>
		public ScHallEquipFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScHallEquipFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScHallEquipFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScHallEquipFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScHallEquipFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScHallEquipFilterBuilder
	
	#region ScHallEquipParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScHallEquipColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScHallEquip"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScHallEquipParameterBuilder : ParameterizedSqlFilterBuilder<ScHallEquipColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScHallEquipParameterBuilder class.
		/// </summary>
		public ScHallEquipParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScHallEquipParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScHallEquipParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScHallEquipParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScHallEquipParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScHallEquipParameterBuilder
	
	#region ScHallEquipSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScHallEquipColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScHallEquip"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScHallEquipSortBuilder : SqlSortBuilder<ScHallEquipColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScHallEquipSqlSortBuilder class.
		/// </summary>
		public ScHallEquipSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScHallEquipSortBuilder
	
} // end namespace
