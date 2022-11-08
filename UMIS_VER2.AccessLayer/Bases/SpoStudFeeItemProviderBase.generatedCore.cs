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
	/// This class is the base class for any <see cref="SpoStudFeeItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SpoStudFeeItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SpoStudFeeItem, UMIS_VER2.BusinessLyer.SpoStudFeeItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoStudFeeItemKey key)
		{
			return Delete(transactionManager, key.SpoStudFeeItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_spoStudFeeItemId">XXFEE_STUD_DISC_FEE_ITEM. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _spoStudFeeItemId)
		{
			return Delete(null, _spoStudFeeItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoStudFeeItemId">XXFEE_STUD_DISC_FEE_ITEM. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _spoStudFeeItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_STUD_FEE_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_SPO_STUD_FEE_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoStudFeeItem objects.</returns>
		public TList<SpoStudFeeItem> GetByFeeStudFeeItemId(System.Decimal _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(_feeStudFeeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_STUD_FEE_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_SPO_STUD_FEE_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoStudFeeItem objects.</returns>
		/// <remarks></remarks>
		public TList<SpoStudFeeItem> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_STUD_FEE_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_SPO_STUD_FEE_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoStudFeeItem objects.</returns>
		public TList<SpoStudFeeItem> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal _feeStudFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_STUD_FEE_ITEM_FEE_STUD_FEE_ITEM key.
		///		fkSpoStudFeeItemFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoStudFeeItem objects.</returns>
		public TList<SpoStudFeeItem> GetByFeeStudFeeItemId(System.Decimal _feeStudFeeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_STUD_FEE_ITEM_FEE_STUD_FEE_ITEM key.
		///		fkSpoStudFeeItemFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoStudFeeItem objects.</returns>
		public TList<SpoStudFeeItem> GetByFeeStudFeeItemId(System.Decimal _feeStudFeeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_STUD_FEE_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_SPO_STUD_FEE_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoStudFeeItem objects.</returns>
		public abstract TList<SpoStudFeeItem> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal _feeStudFeeItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_STUD_FEE_ITEM_SPO_SPONSOR_STUD key.
		///		FK_SPO_STUD_FEE_ITEM_SPO_SPONSOR_STUD Description: 
		/// </summary>
		/// <param name="_spoSponsorStudId">kU</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoStudFeeItem objects.</returns>
		public TList<SpoStudFeeItem> GetBySpoSponsorStudId(System.Decimal _spoSponsorStudId)
		{
			int count = -1;
			return GetBySpoSponsorStudId(_spoSponsorStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_STUD_FEE_ITEM_SPO_SPONSOR_STUD key.
		///		FK_SPO_STUD_FEE_ITEM_SPO_SPONSOR_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorStudId">kU</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoStudFeeItem objects.</returns>
		/// <remarks></remarks>
		public TList<SpoStudFeeItem> GetBySpoSponsorStudId(TransactionManager transactionManager, System.Decimal _spoSponsorStudId)
		{
			int count = -1;
			return GetBySpoSponsorStudId(transactionManager, _spoSponsorStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_STUD_FEE_ITEM_SPO_SPONSOR_STUD key.
		///		FK_SPO_STUD_FEE_ITEM_SPO_SPONSOR_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorStudId">kU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoStudFeeItem objects.</returns>
		public TList<SpoStudFeeItem> GetBySpoSponsorStudId(TransactionManager transactionManager, System.Decimal _spoSponsorStudId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorStudId(transactionManager, _spoSponsorStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_STUD_FEE_ITEM_SPO_SPONSOR_STUD key.
		///		fkSpoStudFeeItemSpoSponsorStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorStudId">kU</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoStudFeeItem objects.</returns>
		public TList<SpoStudFeeItem> GetBySpoSponsorStudId(System.Decimal _spoSponsorStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorStudId(null, _spoSponsorStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_STUD_FEE_ITEM_SPO_SPONSOR_STUD key.
		///		fkSpoStudFeeItemSpoSponsorStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorStudId">kU</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoStudFeeItem objects.</returns>
		public TList<SpoStudFeeItem> GetBySpoSponsorStudId(System.Decimal _spoSponsorStudId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorStudId(null, _spoSponsorStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_STUD_FEE_ITEM_SPO_SPONSOR_STUD key.
		///		FK_SPO_STUD_FEE_ITEM_SPO_SPONSOR_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorStudId">kU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoStudFeeItem objects.</returns>
		public abstract TList<SpoStudFeeItem> GetBySpoSponsorStudId(TransactionManager transactionManager, System.Decimal _spoSponsorStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SpoStudFeeItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoStudFeeItemKey key, int start, int pageLength)
		{
			return GetBySpoStudFeeItemId(transactionManager, key.SpoStudFeeItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SPO_STUD_FEE_ITEM index.
		/// </summary>
		/// <param name="_spoStudFeeItemId">XXFEE_STUD_DISC_FEE_ITEM</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoStudFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoStudFeeItem GetBySpoStudFeeItemId(System.Decimal _spoStudFeeItemId)
		{
			int count = -1;
			return GetBySpoStudFeeItemId(null,_spoStudFeeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_STUD_FEE_ITEM index.
		/// </summary>
		/// <param name="_spoStudFeeItemId">XXFEE_STUD_DISC_FEE_ITEM</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoStudFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoStudFeeItem GetBySpoStudFeeItemId(System.Decimal _spoStudFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoStudFeeItemId(null, _spoStudFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_STUD_FEE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoStudFeeItemId">XXFEE_STUD_DISC_FEE_ITEM</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoStudFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoStudFeeItem GetBySpoStudFeeItemId(TransactionManager transactionManager, System.Decimal _spoStudFeeItemId)
		{
			int count = -1;
			return GetBySpoStudFeeItemId(transactionManager, _spoStudFeeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_STUD_FEE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoStudFeeItemId">XXFEE_STUD_DISC_FEE_ITEM</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoStudFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoStudFeeItem GetBySpoStudFeeItemId(TransactionManager transactionManager, System.Decimal _spoStudFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoStudFeeItemId(transactionManager, _spoStudFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_STUD_FEE_ITEM index.
		/// </summary>
		/// <param name="_spoStudFeeItemId">XXFEE_STUD_DISC_FEE_ITEM</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoStudFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoStudFeeItem GetBySpoStudFeeItemId(System.Decimal _spoStudFeeItemId, int start, int pageLength, out int count)
		{
			return GetBySpoStudFeeItemId(null, _spoStudFeeItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_STUD_FEE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoStudFeeItemId">XXFEE_STUD_DISC_FEE_ITEM</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoStudFeeItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SpoStudFeeItem GetBySpoStudFeeItemId(TransactionManager transactionManager, System.Decimal _spoStudFeeItemId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SpoStudFeeItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SpoStudFeeItem&gt;"/></returns>
		public static TList<SpoStudFeeItem> Fill(IDataReader reader, TList<SpoStudFeeItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SpoStudFeeItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SpoStudFeeItem")
					.Append("|").Append((System.Decimal)reader["SPO_STUD_FEE_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SpoStudFeeItem>(
					key.ToString(), // EntityTrackingKey
					"SpoStudFeeItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SpoStudFeeItem();
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
					c.SpoStudFeeItemId = (System.Decimal)reader["SPO_STUD_FEE_ITEM_ID"];
					c.OriginalSpoStudFeeItemId = c.SpoStudFeeItemId;
					c.SpoSponsorStudId = (System.Decimal)reader["SPO_SPONSOR_STUD_ID"];
					c.FeeStudFeeItemId = (System.Decimal)reader["FEE_STUD_FEE_ITEM_ID"];
					c.SpoFeeAmnt = (System.Decimal)reader["SPO_FEE_AMNT"];
					c.SpoRemainAmnt = (System.Decimal)reader["SPO_REMAIN_AMNT"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoStudFeeItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoStudFeeItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SpoStudFeeItem entity)
		{
			if (!reader.Read()) return;
			
			entity.SpoStudFeeItemId = (System.Decimal)reader[((int)SpoStudFeeItemColumn.SpoStudFeeItemId - 1)];
			entity.OriginalSpoStudFeeItemId = (System.Decimal)reader["SPO_STUD_FEE_ITEM_ID"];
			entity.SpoSponsorStudId = (System.Decimal)reader[((int)SpoStudFeeItemColumn.SpoSponsorStudId - 1)];
			entity.FeeStudFeeItemId = (System.Decimal)reader[((int)SpoStudFeeItemColumn.FeeStudFeeItemId - 1)];
			entity.SpoFeeAmnt = (System.Decimal)reader[((int)SpoStudFeeItemColumn.SpoFeeAmnt - 1)];
			entity.SpoRemainAmnt = (System.Decimal)reader[((int)SpoStudFeeItemColumn.SpoRemainAmnt - 1)];
			entity.Notes = (reader.IsDBNull(((int)SpoStudFeeItemColumn.Notes - 1)))?null:(System.String)reader[((int)SpoStudFeeItemColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)SpoStudFeeItemColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)SpoStudFeeItemColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SpoStudFeeItemColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SpoStudFeeItemColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoStudFeeItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoStudFeeItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SpoStudFeeItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SpoStudFeeItemId = (System.Decimal)dataRow["SPO_STUD_FEE_ITEM_ID"];
			entity.OriginalSpoStudFeeItemId = (System.Decimal)dataRow["SPO_STUD_FEE_ITEM_ID"];
			entity.SpoSponsorStudId = (System.Decimal)dataRow["SPO_SPONSOR_STUD_ID"];
			entity.FeeStudFeeItemId = (System.Decimal)dataRow["FEE_STUD_FEE_ITEM_ID"];
			entity.SpoFeeAmnt = (System.Decimal)dataRow["SPO_FEE_AMNT"];
			entity.SpoRemainAmnt = (System.Decimal)dataRow["SPO_REMAIN_AMNT"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoStudFeeItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoStudFeeItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoStudFeeItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region FeeStudFeeItemIdSource	
			if (CanDeepLoad(entity, "FeeStudFeeItem|FeeStudFeeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeStudFeeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeStudFeeItemId;
				FeeStudFeeItem tmpEntity = EntityManager.LocateEntity<FeeStudFeeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudFeeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudFeeItemIdSource = tmpEntity;
				else
					entity.FeeStudFeeItemIdSource = DataRepository.FeeStudFeeItemProvider.GetByFeeStudFeeItemId(transactionManager, entity.FeeStudFeeItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFeeItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudFeeItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudFeeItemProvider.DeepLoad(transactionManager, entity.FeeStudFeeItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudFeeItemIdSource

			#region SpoSponsorStudIdSource	
			if (CanDeepLoad(entity, "SpoSponsorStud|SpoSponsorStudIdSource", deepLoadType, innerList) 
				&& entity.SpoSponsorStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SpoSponsorStudId;
				SpoSponsorStud tmpEntity = EntityManager.LocateEntity<SpoSponsorStud>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoSponsorStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoSponsorStudIdSource = tmpEntity;
				else
					entity.SpoSponsorStudIdSource = DataRepository.SpoSponsorStudProvider.GetBySpoSponsorStudId(transactionManager, entity.SpoSponsorStudId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SpoSponsorStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SpoSponsorStudProvider.DeepLoad(transactionManager, entity.SpoSponsorStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SpoSponsorStudIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SpoStudFeeItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SpoStudFeeItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoStudFeeItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoStudFeeItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region FeeStudFeeItemIdSource
			if (CanDeepSave(entity, "FeeStudFeeItem|FeeStudFeeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeStudFeeItemIdSource != null)
			{
				DataRepository.FeeStudFeeItemProvider.Save(transactionManager, entity.FeeStudFeeItemIdSource);
				entity.FeeStudFeeItemId = entity.FeeStudFeeItemIdSource.FeeStudFeeItemId;
			}
			#endregion 
			
			#region SpoSponsorStudIdSource
			if (CanDeepSave(entity, "SpoSponsorStud|SpoSponsorStudIdSource", deepSaveType, innerList) 
				&& entity.SpoSponsorStudIdSource != null)
			{
				DataRepository.SpoSponsorStudProvider.Save(transactionManager, entity.SpoSponsorStudIdSource);
				entity.SpoSponsorStudId = entity.SpoSponsorStudIdSource.SpoSponsorStudId;
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
	
	#region SpoStudFeeItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SpoStudFeeItem</c>
	///</summary>
	public enum SpoStudFeeItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>FeeStudFeeItem</c> at FeeStudFeeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudFeeItem))]
		FeeStudFeeItem,
		
		///<summary>
		/// Composite Property for <c>SpoSponsorStud</c> at SpoSponsorStudIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsorStud))]
		SpoSponsorStud,
	}
	
	#endregion SpoStudFeeItemChildEntityTypes
	
	#region SpoStudFeeItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SpoStudFeeItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoStudFeeItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoStudFeeItemFilterBuilder : SqlFilterBuilder<SpoStudFeeItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoStudFeeItemFilterBuilder class.
		/// </summary>
		public SpoStudFeeItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoStudFeeItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoStudFeeItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoStudFeeItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoStudFeeItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoStudFeeItemFilterBuilder
	
	#region SpoStudFeeItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SpoStudFeeItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoStudFeeItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoStudFeeItemParameterBuilder : ParameterizedSqlFilterBuilder<SpoStudFeeItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoStudFeeItemParameterBuilder class.
		/// </summary>
		public SpoStudFeeItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoStudFeeItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoStudFeeItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoStudFeeItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoStudFeeItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoStudFeeItemParameterBuilder
	
	#region SpoStudFeeItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SpoStudFeeItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoStudFeeItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SpoStudFeeItemSortBuilder : SqlSortBuilder<SpoStudFeeItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoStudFeeItemSqlSortBuilder class.
		/// </summary>
		public SpoStudFeeItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SpoStudFeeItemSortBuilder
	
} // end namespace
