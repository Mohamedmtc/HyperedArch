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
	/// This class is the base class for any <see cref="FeeCdeBondItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeCdeBondItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeCdeBondItem, UMIS_VER2.BusinessLyer.FeeCdeBondItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeBondItemKey key)
		{
			return Delete(transactionManager, key.FeeCdeBondItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeCdeBondItemId">تعريف بنود السندات. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _feeCdeBondItemId)
		{
			return Delete(null, _feeCdeBondItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeBondItemId">تعريف بنود السندات. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _feeCdeBondItemId);		
		
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
		public override UMIS_VER2.BusinessLyer.FeeCdeBondItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeBondItemKey key, int start, int pageLength)
		{
			return GetByFeeCdeBondItemId(transactionManager, key.FeeCdeBondItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_CDE_BOND_ITEM index.
		/// </summary>
		/// <param name="_feeCdeBondItemId">تعريف بنود السندات</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByFeeCdeBondItemId(System.Int32 _feeCdeBondItemId)
		{
			int count = -1;
			return GetByFeeCdeBondItemId(null,_feeCdeBondItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_BOND_ITEM index.
		/// </summary>
		/// <param name="_feeCdeBondItemId">تعريف بنود السندات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByFeeCdeBondItemId(System.Int32 _feeCdeBondItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeBondItemId(null, _feeCdeBondItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_BOND_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeBondItemId">تعريف بنود السندات</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByFeeCdeBondItemId(TransactionManager transactionManager, System.Int32 _feeCdeBondItemId)
		{
			int count = -1;
			return GetByFeeCdeBondItemId(transactionManager, _feeCdeBondItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_BOND_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeBondItemId">تعريف بنود السندات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByFeeCdeBondItemId(TransactionManager transactionManager, System.Int32 _feeCdeBondItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeBondItemId(transactionManager, _feeCdeBondItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_BOND_ITEM index.
		/// </summary>
		/// <param name="_feeCdeBondItemId">تعريف بنود السندات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByFeeCdeBondItemId(System.Int32 _feeCdeBondItemId, int start, int pageLength, out int count)
		{
			return GetByFeeCdeBondItemId(null, _feeCdeBondItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_BOND_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeBondItemId">تعريف بنود السندات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByFeeCdeBondItemId(TransactionManager transactionManager, System.Int32 _feeCdeBondItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_CDE_BOND_ITEM_ACC index.
		/// </summary>
		/// <param name="_accountNo">رقم الحساب</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByAccountNo(System.String _accountNo)
		{
			int count = -1;
			return GetByAccountNo(null,_accountNo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BOND_ITEM_ACC index.
		/// </summary>
		/// <param name="_accountNo">رقم الحساب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByAccountNo(System.String _accountNo, int start, int pageLength)
		{
			int count = -1;
			return GetByAccountNo(null, _accountNo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BOND_ITEM_ACC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accountNo">رقم الحساب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByAccountNo(TransactionManager transactionManager, System.String _accountNo)
		{
			int count = -1;
			return GetByAccountNo(transactionManager, _accountNo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BOND_ITEM_ACC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accountNo">رقم الحساب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByAccountNo(TransactionManager transactionManager, System.String _accountNo, int start, int pageLength)
		{
			int count = -1;
			return GetByAccountNo(transactionManager, _accountNo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BOND_ITEM_ACC index.
		/// </summary>
		/// <param name="_accountNo">رقم الحساب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByAccountNo(System.String _accountNo, int start, int pageLength, out int count)
		{
			return GetByAccountNo(null, _accountNo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BOND_ITEM_ACC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accountNo">رقم الحساب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByAccountNo(TransactionManager transactionManager, System.String _accountNo, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_CDE_BOND_ITEM_AR index.
		/// </summary>
		/// <param name="_bondItemAr">اسم البند</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByBondItemAr(System.String _bondItemAr)
		{
			int count = -1;
			return GetByBondItemAr(null,_bondItemAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BOND_ITEM_AR index.
		/// </summary>
		/// <param name="_bondItemAr">اسم البند</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByBondItemAr(System.String _bondItemAr, int start, int pageLength)
		{
			int count = -1;
			return GetByBondItemAr(null, _bondItemAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BOND_ITEM_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_bondItemAr">اسم البند</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByBondItemAr(TransactionManager transactionManager, System.String _bondItemAr)
		{
			int count = -1;
			return GetByBondItemAr(transactionManager, _bondItemAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BOND_ITEM_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_bondItemAr">اسم البند</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByBondItemAr(TransactionManager transactionManager, System.String _bondItemAr, int start, int pageLength)
		{
			int count = -1;
			return GetByBondItemAr(transactionManager, _bondItemAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BOND_ITEM_AR index.
		/// </summary>
		/// <param name="_bondItemAr">اسم البند</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByBondItemAr(System.String _bondItemAr, int start, int pageLength, out int count)
		{
			return GetByBondItemAr(null, _bondItemAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BOND_ITEM_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_bondItemAr">اسم البند</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByBondItemAr(TransactionManager transactionManager, System.String _bondItemAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_CDE_BOND_ITEM_EN index.
		/// </summary>
		/// <param name="_bondItemEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByBondItemEn(System.String _bondItemEn)
		{
			int count = -1;
			return GetByBondItemEn(null,_bondItemEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BOND_ITEM_EN index.
		/// </summary>
		/// <param name="_bondItemEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByBondItemEn(System.String _bondItemEn, int start, int pageLength)
		{
			int count = -1;
			return GetByBondItemEn(null, _bondItemEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BOND_ITEM_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_bondItemEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByBondItemEn(TransactionManager transactionManager, System.String _bondItemEn)
		{
			int count = -1;
			return GetByBondItemEn(transactionManager, _bondItemEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BOND_ITEM_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_bondItemEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByBondItemEn(TransactionManager transactionManager, System.String _bondItemEn, int start, int pageLength)
		{
			int count = -1;
			return GetByBondItemEn(transactionManager, _bondItemEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BOND_ITEM_EN index.
		/// </summary>
		/// <param name="_bondItemEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByBondItemEn(System.String _bondItemEn, int start, int pageLength, out int count)
		{
			return GetByBondItemEn(null, _bondItemEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BOND_ITEM_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_bondItemEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCdeBondItem GetByBondItemEn(TransactionManager transactionManager, System.String _bondItemEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeCdeBondItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeCdeBondItem&gt;"/></returns>
		public static TList<FeeCdeBondItem> Fill(IDataReader reader, TList<FeeCdeBondItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeCdeBondItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeCdeBondItem")
					.Append("|").Append((System.Int32)reader["FEE_CDE_BOND_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeCdeBondItem>(
					key.ToString(), // EntityTrackingKey
					"FeeCdeBondItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeCdeBondItem();
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
					c.FeeCdeBondItemId = (System.Int32)reader["FEE_CDE_BOND_ITEM_ID"];
					c.OriginalFeeCdeBondItemId = c.FeeCdeBondItemId;
					c.BondItemAr = Convert.IsDBNull(reader["BOND_ITEM_AR"]) ? null : (System.String)reader["BOND_ITEM_AR"];
					c.BondItemEn = Convert.IsDBNull(reader["BOND_ITEM_EN"]) ? null : (System.String)reader["BOND_ITEM_EN"];
					c.AccountNo = Convert.IsDBNull(reader["ACCOUNT_NO"]) ? null : (System.String)reader["ACCOUNT_NO"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeCdeBondItem entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeCdeBondItemId = (System.Int32)reader[((int)FeeCdeBondItemColumn.FeeCdeBondItemId - 1)];
			entity.OriginalFeeCdeBondItemId = (System.Int32)reader["FEE_CDE_BOND_ITEM_ID"];
			entity.BondItemAr = (reader.IsDBNull(((int)FeeCdeBondItemColumn.BondItemAr - 1)))?null:(System.String)reader[((int)FeeCdeBondItemColumn.BondItemAr - 1)];
			entity.BondItemEn = (reader.IsDBNull(((int)FeeCdeBondItemColumn.BondItemEn - 1)))?null:(System.String)reader[((int)FeeCdeBondItemColumn.BondItemEn - 1)];
			entity.AccountNo = (reader.IsDBNull(((int)FeeCdeBondItemColumn.AccountNo - 1)))?null:(System.String)reader[((int)FeeCdeBondItemColumn.AccountNo - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeCdeBondItemColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeCdeBondItemColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeCdeBondItemColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeCdeBondItemColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeCdeBondItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeCdeBondItemId = (System.Int32)dataRow["FEE_CDE_BOND_ITEM_ID"];
			entity.OriginalFeeCdeBondItemId = (System.Int32)dataRow["FEE_CDE_BOND_ITEM_ID"];
			entity.BondItemAr = Convert.IsDBNull(dataRow["BOND_ITEM_AR"]) ? null : (System.String)dataRow["BOND_ITEM_AR"];
			entity.BondItemEn = Convert.IsDBNull(dataRow["BOND_ITEM_EN"]) ? null : (System.String)dataRow["BOND_ITEM_EN"];
			entity.AccountNo = Convert.IsDBNull(dataRow["ACCOUNT_NO"]) ? null : (System.String)dataRow["ACCOUNT_NO"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeBondItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeBondItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeBondItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeCdeBondItemId methods when available
			
			#region FeeTreasuryItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeTreasuryItem>|FeeTreasuryItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeTreasuryItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeTreasuryItemCollection = DataRepository.FeeTreasuryItemProvider.GetByFeeCdeBondItemId(transactionManager, entity.FeeCdeBondItemId);

				if (deep && entity.FeeTreasuryItemCollection.Count > 0)
				{
					deepHandles.Add("FeeTreasuryItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeTreasuryItem>) DataRepository.FeeTreasuryItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeTreasuryItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeUserBondReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeUserBondReq>|FeeUserBondReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeUserBondReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeUserBondReqCollection = DataRepository.FeeUserBondReqProvider.GetByFeeCdeBondItemId(transactionManager, entity.FeeCdeBondItemId);

				if (deep && entity.FeeUserBondReqCollection.Count > 0)
				{
					deepHandles.Add("FeeUserBondReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeUserBondReq>) DataRepository.FeeUserBondReqProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeUserBondReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeUserFundReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeUserFundReq>|FeeUserFundReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeUserFundReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeUserFundReqCollection = DataRepository.FeeUserFundReqProvider.GetByFeeCdeBondItemId(transactionManager, entity.FeeCdeBondItemId);

				if (deep && entity.FeeUserFundReqCollection.Count > 0)
				{
					deepHandles.Add("FeeUserFundReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeUserFundReq>) DataRepository.FeeUserFundReqProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeUserFundReqCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeCdeBondItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeCdeBondItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeBondItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeBondItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<FeeTreasuryItem>
				if (CanDeepSave(entity.FeeTreasuryItemCollection, "List<FeeTreasuryItem>|FeeTreasuryItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeTreasuryItem child in entity.FeeTreasuryItemCollection)
					{
						if(child.FeeCdeBondItemIdSource != null)
						{
							child.FeeCdeBondItemId = child.FeeCdeBondItemIdSource.FeeCdeBondItemId;
						}
						else
						{
							child.FeeCdeBondItemId = entity.FeeCdeBondItemId;
						}

					}

					if (entity.FeeTreasuryItemCollection.Count > 0 || entity.FeeTreasuryItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeTreasuryItemProvider.Save(transactionManager, entity.FeeTreasuryItemCollection);
						
						deepHandles.Add("FeeTreasuryItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeTreasuryItem >) DataRepository.FeeTreasuryItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeTreasuryItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeUserBondReq>
				if (CanDeepSave(entity.FeeUserBondReqCollection, "List<FeeUserBondReq>|FeeUserBondReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeUserBondReq child in entity.FeeUserBondReqCollection)
					{
						if(child.FeeCdeBondItemIdSource != null)
						{
							child.FeeCdeBondItemId = child.FeeCdeBondItemIdSource.FeeCdeBondItemId;
						}
						else
						{
							child.FeeCdeBondItemId = entity.FeeCdeBondItemId;
						}

					}

					if (entity.FeeUserBondReqCollection.Count > 0 || entity.FeeUserBondReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeUserBondReqProvider.Save(transactionManager, entity.FeeUserBondReqCollection);
						
						deepHandles.Add("FeeUserBondReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeUserBondReq >) DataRepository.FeeUserBondReqProvider.DeepSave,
							new object[] { transactionManager, entity.FeeUserBondReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeUserFundReq>
				if (CanDeepSave(entity.FeeUserFundReqCollection, "List<FeeUserFundReq>|FeeUserFundReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeUserFundReq child in entity.FeeUserFundReqCollection)
					{
						if(child.FeeCdeBondItemIdSource != null)
						{
							child.FeeCdeBondItemId = child.FeeCdeBondItemIdSource.FeeCdeBondItemId;
						}
						else
						{
							child.FeeCdeBondItemId = entity.FeeCdeBondItemId;
						}

					}

					if (entity.FeeUserFundReqCollection.Count > 0 || entity.FeeUserFundReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeUserFundReqProvider.Save(transactionManager, entity.FeeUserFundReqCollection);
						
						deepHandles.Add("FeeUserFundReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeUserFundReq >) DataRepository.FeeUserFundReqProvider.DeepSave,
							new object[] { transactionManager, entity.FeeUserFundReqCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeCdeBondItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeCdeBondItem</c>
	///</summary>
	public enum FeeCdeBondItemChildEntityTypes
	{
		///<summary>
		/// Collection of <c>FeeCdeBondItem</c> as OneToMany for FeeTreasuryItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeTreasuryItem>))]
		FeeTreasuryItemCollection,
		///<summary>
		/// Collection of <c>FeeCdeBondItem</c> as OneToMany for FeeUserBondReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeUserBondReq>))]
		FeeUserBondReqCollection,
		///<summary>
		/// Collection of <c>FeeCdeBondItem</c> as OneToMany for FeeUserFundReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeUserFundReq>))]
		FeeUserFundReqCollection,
	}
	
	#endregion FeeCdeBondItemChildEntityTypes
	
	#region FeeCdeBondItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeCdeBondItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeBondItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeBondItemFilterBuilder : SqlFilterBuilder<FeeCdeBondItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeBondItemFilterBuilder class.
		/// </summary>
		public FeeCdeBondItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeBondItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeBondItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeBondItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeBondItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeBondItemFilterBuilder
	
	#region FeeCdeBondItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeCdeBondItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeBondItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeBondItemParameterBuilder : ParameterizedSqlFilterBuilder<FeeCdeBondItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeBondItemParameterBuilder class.
		/// </summary>
		public FeeCdeBondItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeBondItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeBondItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeBondItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeBondItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeBondItemParameterBuilder
	
	#region FeeCdeBondItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeCdeBondItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeBondItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeCdeBondItemSortBuilder : SqlSortBuilder<FeeCdeBondItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeBondItemSqlSortBuilder class.
		/// </summary>
		public FeeCdeBondItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeCdeBondItemSortBuilder
	
} // end namespace
