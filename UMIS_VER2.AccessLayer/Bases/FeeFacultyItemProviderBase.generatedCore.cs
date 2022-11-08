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
	/// This class is the base class for any <see cref="FeeFacultyItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeFacultyItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeFacultyItem, UMIS_VER2.BusinessLyer.FeeFacultyItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFacultyItemKey key)
		{
			return Delete(transactionManager, key.FeeFacultyItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeFacultyItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeFacultyItemId)
		{
			return Delete(null, _feeFacultyItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeFacultyItemId);		
		
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
		public override UMIS_VER2.BusinessLyer.FeeFacultyItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFacultyItemKey key, int start, int pageLength)
		{
			return GetByFeeFacultyItemId(transactionManager, key.FeeFacultyItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_FEE_CODE_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_feeCodeItemId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyItem&gt;"/> class.</returns>
		public TList<FeeFacultyItem> GetByFeeCodeItemId(System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(null,_feeCodeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyItem&gt;"/> class.</returns>
		public TList<FeeFacultyItem> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyItem&gt;"/> class.</returns>
		public TList<FeeFacultyItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyItem&gt;"/> class.</returns>
		public TList<FeeFacultyItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyItem&gt;"/> class.</returns>
		public TList<FeeFacultyItem> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength, out int count)
		{
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyItem&gt;"/> class.</returns>
		public abstract TList<FeeFacultyItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_FEE_FACULTY_RULE_ID_1 index.
		/// </summary>
		/// <param name="_feeFacultyRuleId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyItem&gt;"/> class.</returns>
		public TList<FeeFacultyItem> GetByFeeFacultyRuleId(System.Decimal _feeFacultyRuleId)
		{
			int count = -1;
			return GetByFeeFacultyRuleId(null,_feeFacultyRuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_RULE_ID_1 index.
		/// </summary>
		/// <param name="_feeFacultyRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyItem&gt;"/> class.</returns>
		public TList<FeeFacultyItem> GetByFeeFacultyRuleId(System.Decimal _feeFacultyRuleId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFacultyRuleId(null, _feeFacultyRuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_RULE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyItem&gt;"/> class.</returns>
		public TList<FeeFacultyItem> GetByFeeFacultyRuleId(TransactionManager transactionManager, System.Decimal _feeFacultyRuleId)
		{
			int count = -1;
			return GetByFeeFacultyRuleId(transactionManager, _feeFacultyRuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_RULE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyItem&gt;"/> class.</returns>
		public TList<FeeFacultyItem> GetByFeeFacultyRuleId(TransactionManager transactionManager, System.Decimal _feeFacultyRuleId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFacultyRuleId(transactionManager, _feeFacultyRuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_RULE_ID_1 index.
		/// </summary>
		/// <param name="_feeFacultyRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyItem&gt;"/> class.</returns>
		public TList<FeeFacultyItem> GetByFeeFacultyRuleId(System.Decimal _feeFacultyRuleId, int start, int pageLength, out int count)
		{
			return GetByFeeFacultyRuleId(null, _feeFacultyRuleId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_RULE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyItem&gt;"/> class.</returns>
		public abstract TList<FeeFacultyItem> GetByFeeFacultyRuleId(TransactionManager transactionManager, System.Decimal _feeFacultyRuleId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_FAC_ITEM index.
		/// </summary>
		/// <param name="_feeFacultyItemId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacultyItem GetByFeeFacultyItemId(System.Decimal _feeFacultyItemId)
		{
			int count = -1;
			return GetByFeeFacultyItemId(null,_feeFacultyItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FAC_ITEM index.
		/// </summary>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacultyItem GetByFeeFacultyItemId(System.Decimal _feeFacultyItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFacultyItemId(null, _feeFacultyItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FAC_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacultyItem GetByFeeFacultyItemId(TransactionManager transactionManager, System.Decimal _feeFacultyItemId)
		{
			int count = -1;
			return GetByFeeFacultyItemId(transactionManager, _feeFacultyItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FAC_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacultyItem GetByFeeFacultyItemId(TransactionManager transactionManager, System.Decimal _feeFacultyItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFacultyItemId(transactionManager, _feeFacultyItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FAC_ITEM index.
		/// </summary>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacultyItem GetByFeeFacultyItemId(System.Decimal _feeFacultyItemId, int start, int pageLength, out int count)
		{
			return GetByFeeFacultyItemId(null, _feeFacultyItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FAC_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeFacultyItem GetByFeeFacultyItemId(TransactionManager transactionManager, System.Decimal _feeFacultyItemId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeFacultyItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeFacultyItem&gt;"/></returns>
		public static TList<FeeFacultyItem> Fill(IDataReader reader, TList<FeeFacultyItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeFacultyItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeFacultyItem")
					.Append("|").Append((System.Decimal)reader["FEE_FACULTY_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeFacultyItem>(
					key.ToString(), // EntityTrackingKey
					"FeeFacultyItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeFacultyItem();
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
					c.FeeFacultyItemId = (System.Decimal)reader["FEE_FACULTY_ITEM_ID"];
					c.OriginalFeeFacultyItemId = c.FeeFacultyItemId;
					c.FeeFacultyRuleId = (System.Decimal)reader["FEE_FACULTY_RULE_ID"];
					c.FeeCodeItemId = (System.Decimal)reader["FEE_CODE_ITEM_ID"];
					c.FeeItemValue = Convert.IsDBNull(reader["FEE_ITEM_VALUE"]) ? null : (System.Decimal?)reader["FEE_ITEM_VALUE"];
					c.ItemOrder = (System.Decimal)reader["ITEM_ORDER"];
					c.StartDate = Convert.IsDBNull(reader["START_DATE"]) ? null : (System.DateTime?)reader["START_DATE"];
					c.EndDate = Convert.IsDBNull(reader["END_DATE"]) ? null : (System.DateTime?)reader["END_DATE"];
					c.AllCourseFlg = (System.Decimal)reader["ALL_COURSE_FLG"];
					c.RefundFlg = (System.Decimal)reader["REFUND_FLG"];
					c.DiscFlg = (System.Decimal)reader["DISC_FLG"];
					c.AdmYearFlg = (System.Decimal)reader["ADM_YEAR_FLG"];
					c.NewComerFlg = Convert.IsDBNull(reader["NEW_COMER_FLG"]) ? null : (System.Decimal?)reader["NEW_COMER_FLG"];
					c.CoursesFlg = Convert.IsDBNull(reader["COURSES_FLG"]) ? null : (System.Decimal?)reader["COURSES_FLG"];
					c.InstallmentFlg = Convert.IsDBNull(reader["INSTALLMENT_FLG"]) ? null : (System.Decimal?)reader["INSTALLMENT_FLG"];
					c.CloseFlg = (System.Decimal)reader["CLOSE_FLG"];
					c.ChOrTotalFlg = (System.Decimal)reader["CH_OR_TOTAL_FLG"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.MaxCh = Convert.IsDBNull(reader["MAX_CH"]) ? null : (System.Int32?)reader["MAX_CH"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeFacultyItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeFacultyItem entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeFacultyItemId = (System.Decimal)reader[((int)FeeFacultyItemColumn.FeeFacultyItemId - 1)];
			entity.OriginalFeeFacultyItemId = (System.Decimal)reader["FEE_FACULTY_ITEM_ID"];
			entity.FeeFacultyRuleId = (System.Decimal)reader[((int)FeeFacultyItemColumn.FeeFacultyRuleId - 1)];
			entity.FeeCodeItemId = (System.Decimal)reader[((int)FeeFacultyItemColumn.FeeCodeItemId - 1)];
			entity.FeeItemValue = (reader.IsDBNull(((int)FeeFacultyItemColumn.FeeItemValue - 1)))?null:(System.Decimal?)reader[((int)FeeFacultyItemColumn.FeeItemValue - 1)];
			entity.ItemOrder = (System.Decimal)reader[((int)FeeFacultyItemColumn.ItemOrder - 1)];
			entity.StartDate = (reader.IsDBNull(((int)FeeFacultyItemColumn.StartDate - 1)))?null:(System.DateTime?)reader[((int)FeeFacultyItemColumn.StartDate - 1)];
			entity.EndDate = (reader.IsDBNull(((int)FeeFacultyItemColumn.EndDate - 1)))?null:(System.DateTime?)reader[((int)FeeFacultyItemColumn.EndDate - 1)];
			entity.AllCourseFlg = (System.Decimal)reader[((int)FeeFacultyItemColumn.AllCourseFlg - 1)];
			entity.RefundFlg = (System.Decimal)reader[((int)FeeFacultyItemColumn.RefundFlg - 1)];
			entity.DiscFlg = (System.Decimal)reader[((int)FeeFacultyItemColumn.DiscFlg - 1)];
			entity.AdmYearFlg = (System.Decimal)reader[((int)FeeFacultyItemColumn.AdmYearFlg - 1)];
			entity.NewComerFlg = (reader.IsDBNull(((int)FeeFacultyItemColumn.NewComerFlg - 1)))?null:(System.Decimal?)reader[((int)FeeFacultyItemColumn.NewComerFlg - 1)];
			entity.CoursesFlg = (reader.IsDBNull(((int)FeeFacultyItemColumn.CoursesFlg - 1)))?null:(System.Decimal?)reader[((int)FeeFacultyItemColumn.CoursesFlg - 1)];
			entity.InstallmentFlg = (reader.IsDBNull(((int)FeeFacultyItemColumn.InstallmentFlg - 1)))?null:(System.Decimal?)reader[((int)FeeFacultyItemColumn.InstallmentFlg - 1)];
			entity.CloseFlg = (System.Decimal)reader[((int)FeeFacultyItemColumn.CloseFlg - 1)];
			entity.ChOrTotalFlg = (System.Decimal)reader[((int)FeeFacultyItemColumn.ChOrTotalFlg - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeFacultyItemColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeFacultyItemColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeFacultyItemColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeFacultyItemColumn.SeUserId - 1)];
			entity.MaxCh = (reader.IsDBNull(((int)FeeFacultyItemColumn.MaxCh - 1)))?null:(System.Int32?)reader[((int)FeeFacultyItemColumn.MaxCh - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeFacultyItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeFacultyItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeFacultyItemId = (System.Decimal)dataRow["FEE_FACULTY_ITEM_ID"];
			entity.OriginalFeeFacultyItemId = (System.Decimal)dataRow["FEE_FACULTY_ITEM_ID"];
			entity.FeeFacultyRuleId = (System.Decimal)dataRow["FEE_FACULTY_RULE_ID"];
			entity.FeeCodeItemId = (System.Decimal)dataRow["FEE_CODE_ITEM_ID"];
			entity.FeeItemValue = Convert.IsDBNull(dataRow["FEE_ITEM_VALUE"]) ? null : (System.Decimal?)dataRow["FEE_ITEM_VALUE"];
			entity.ItemOrder = (System.Decimal)dataRow["ITEM_ORDER"];
			entity.StartDate = Convert.IsDBNull(dataRow["START_DATE"]) ? null : (System.DateTime?)dataRow["START_DATE"];
			entity.EndDate = Convert.IsDBNull(dataRow["END_DATE"]) ? null : (System.DateTime?)dataRow["END_DATE"];
			entity.AllCourseFlg = (System.Decimal)dataRow["ALL_COURSE_FLG"];
			entity.RefundFlg = (System.Decimal)dataRow["REFUND_FLG"];
			entity.DiscFlg = (System.Decimal)dataRow["DISC_FLG"];
			entity.AdmYearFlg = (System.Decimal)dataRow["ADM_YEAR_FLG"];
			entity.NewComerFlg = Convert.IsDBNull(dataRow["NEW_COMER_FLG"]) ? null : (System.Decimal?)dataRow["NEW_COMER_FLG"];
			entity.CoursesFlg = Convert.IsDBNull(dataRow["COURSES_FLG"]) ? null : (System.Decimal?)dataRow["COURSES_FLG"];
			entity.InstallmentFlg = Convert.IsDBNull(dataRow["INSTALLMENT_FLG"]) ? null : (System.Decimal?)dataRow["INSTALLMENT_FLG"];
			entity.CloseFlg = (System.Decimal)dataRow["CLOSE_FLG"];
			entity.ChOrTotalFlg = (System.Decimal)dataRow["CH_OR_TOTAL_FLG"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.MaxCh = Convert.IsDBNull(dataRow["MAX_CH"]) ? null : (System.Int32?)dataRow["MAX_CH"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeFacultyItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeFacultyItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFacultyItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region FeeCodeItemIdSource	
			if (CanDeepLoad(entity, "FeeCodeItem|FeeCodeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCodeItemId;
				FeeCodeItem tmpEntity = EntityManager.LocateEntity<FeeCodeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeItemIdSource = tmpEntity;
				else
					entity.FeeCodeItemIdSource = DataRepository.FeeCodeItemProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeItemProvider.DeepLoad(transactionManager, entity.FeeCodeItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeItemIdSource

			#region FeeFacultyRuleIdSource	
			if (CanDeepLoad(entity, "FeeFacultyRule|FeeFacultyRuleIdSource", deepLoadType, innerList) 
				&& entity.FeeFacultyRuleIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeFacultyRuleId;
				FeeFacultyRule tmpEntity = EntityManager.LocateEntity<FeeFacultyRule>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeFacultyRule), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeFacultyRuleIdSource = tmpEntity;
				else
					entity.FeeFacultyRuleIdSource = DataRepository.FeeFacultyRuleProvider.GetByFeeFacultyRuleId(transactionManager, entity.FeeFacultyRuleId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyRuleIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeFacultyRuleIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeFacultyRuleProvider.DeepLoad(transactionManager, entity.FeeFacultyRuleIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeFacultyRuleIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeFacultyItemId methods when available
			
			#region FeeStudFeeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFeeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudFeeItemCollection = DataRepository.FeeStudFeeItemProvider.GetByFeeFacultyItemId(transactionManager, entity.FeeFacultyItemId);

				if (deep && entity.FeeStudFeeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudFeeItem>) DataRepository.FeeStudFeeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudFeeItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeItemPaymentWaysCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeItemPaymentWays>|FeeItemPaymentWaysCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeItemPaymentWaysCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeItemPaymentWaysCollection = DataRepository.FeeItemPaymentWaysProvider.GetByFeeFacultyItemId(transactionManager, entity.FeeFacultyItemId);

				if (deep && entity.FeeItemPaymentWaysCollection.Count > 0)
				{
					deepHandles.Add("FeeItemPaymentWaysCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeItemPaymentWays>) DataRepository.FeeItemPaymentWaysProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeItemPaymentWaysCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFacItemAdmYearCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFacItemAdmYear>|FeeFacItemAdmYearCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacItemAdmYearCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFacItemAdmYearCollection = DataRepository.FeeFacItemAdmYearProvider.GetByFeeFacultyItemId(transactionManager, entity.FeeFacultyItemId);

				if (deep && entity.FeeFacItemAdmYearCollection.Count > 0)
				{
					deepHandles.Add("FeeFacItemAdmYearCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacItemAdmYear>) DataRepository.FeeFacItemAdmYearProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacItemAdmYearCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeCourseExpCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeCourseExp>|FeeCourseExpCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCourseExpCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeCourseExpCollection = DataRepository.FeeCourseExpProvider.GetByFeeFacultyItemId(transactionManager, entity.FeeFacultyItemId);

				if (deep && entity.FeeCourseExpCollection.Count > 0)
				{
					deepHandles.Add("FeeCourseExpCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeCourseExp>) DataRepository.FeeCourseExpProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeCourseExpCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeFacultyItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeFacultyItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeFacultyItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFacultyItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region FeeCodeItemIdSource
			if (CanDeepSave(entity, "FeeCodeItem|FeeCodeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeItemIdSource != null)
			{
				DataRepository.FeeCodeItemProvider.Save(transactionManager, entity.FeeCodeItemIdSource);
				entity.FeeCodeItemId = entity.FeeCodeItemIdSource.FeeCodeItemId;
			}
			#endregion 
			
			#region FeeFacultyRuleIdSource
			if (CanDeepSave(entity, "FeeFacultyRule|FeeFacultyRuleIdSource", deepSaveType, innerList) 
				&& entity.FeeFacultyRuleIdSource != null)
			{
				DataRepository.FeeFacultyRuleProvider.Save(transactionManager, entity.FeeFacultyRuleIdSource);
				entity.FeeFacultyRuleId = entity.FeeFacultyRuleIdSource.FeeFacultyRuleId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<FeeStudFeeItem>
				if (CanDeepSave(entity.FeeStudFeeItemCollection, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudFeeItem child in entity.FeeStudFeeItemCollection)
					{
						if(child.FeeFacultyItemIdSource != null)
						{
							child.FeeFacultyItemId = child.FeeFacultyItemIdSource.FeeFacultyItemId;
						}
						else
						{
							child.FeeFacultyItemId = entity.FeeFacultyItemId;
						}

					}

					if (entity.FeeStudFeeItemCollection.Count > 0 || entity.FeeStudFeeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudFeeItemProvider.Save(transactionManager, entity.FeeStudFeeItemCollection);
						
						deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudFeeItem >) DataRepository.FeeStudFeeItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudFeeItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeItemPaymentWays>
				if (CanDeepSave(entity.FeeItemPaymentWaysCollection, "List<FeeItemPaymentWays>|FeeItemPaymentWaysCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeItemPaymentWays child in entity.FeeItemPaymentWaysCollection)
					{
						if(child.FeeFacultyItemIdSource != null)
						{
							child.FeeFacultyItemId = child.FeeFacultyItemIdSource.FeeFacultyItemId;
						}
						else
						{
							child.FeeFacultyItemId = entity.FeeFacultyItemId;
						}

					}

					if (entity.FeeItemPaymentWaysCollection.Count > 0 || entity.FeeItemPaymentWaysCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeItemPaymentWaysProvider.Save(transactionManager, entity.FeeItemPaymentWaysCollection);
						
						deepHandles.Add("FeeItemPaymentWaysCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeItemPaymentWays >) DataRepository.FeeItemPaymentWaysProvider.DeepSave,
							new object[] { transactionManager, entity.FeeItemPaymentWaysCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFacItemAdmYear>
				if (CanDeepSave(entity.FeeFacItemAdmYearCollection, "List<FeeFacItemAdmYear>|FeeFacItemAdmYearCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFacItemAdmYear child in entity.FeeFacItemAdmYearCollection)
					{
						if(child.FeeFacultyItemIdSource != null)
						{
							child.FeeFacultyItemId = child.FeeFacultyItemIdSource.FeeFacultyItemId;
						}
						else
						{
							child.FeeFacultyItemId = entity.FeeFacultyItemId;
						}

					}

					if (entity.FeeFacItemAdmYearCollection.Count > 0 || entity.FeeFacItemAdmYearCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFacItemAdmYearProvider.Save(transactionManager, entity.FeeFacItemAdmYearCollection);
						
						deepHandles.Add("FeeFacItemAdmYearCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFacItemAdmYear >) DataRepository.FeeFacItemAdmYearProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFacItemAdmYearCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeCourseExp>
				if (CanDeepSave(entity.FeeCourseExpCollection, "List<FeeCourseExp>|FeeCourseExpCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeCourseExp child in entity.FeeCourseExpCollection)
					{
						if(child.FeeFacultyItemIdSource != null)
						{
							child.FeeFacultyItemId = child.FeeFacultyItemIdSource.FeeFacultyItemId;
						}
						else
						{
							child.FeeFacultyItemId = entity.FeeFacultyItemId;
						}

					}

					if (entity.FeeCourseExpCollection.Count > 0 || entity.FeeCourseExpCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeCourseExpProvider.Save(transactionManager, entity.FeeCourseExpCollection);
						
						deepHandles.Add("FeeCourseExpCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeCourseExp >) DataRepository.FeeCourseExpProvider.DeepSave,
							new object[] { transactionManager, entity.FeeCourseExpCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeFacultyItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeFacultyItem</c>
	///</summary>
	public enum FeeFacultyItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>FeeCodeItem</c> at FeeCodeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeItem))]
		FeeCodeItem,
		
		///<summary>
		/// Composite Property for <c>FeeFacultyRule</c> at FeeFacultyRuleIdSource
		///</summary>
		[ChildEntityType(typeof(FeeFacultyRule))]
		FeeFacultyRule,
		///<summary>
		/// Collection of <c>FeeFacultyItem</c> as OneToMany for FeeStudFeeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudFeeItem>))]
		FeeStudFeeItemCollection,
		///<summary>
		/// Collection of <c>FeeFacultyItem</c> as OneToMany for FeeItemPaymentWaysCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeItemPaymentWays>))]
		FeeItemPaymentWaysCollection,
		///<summary>
		/// Collection of <c>FeeFacultyItem</c> as OneToMany for FeeFacItemAdmYearCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacItemAdmYear>))]
		FeeFacItemAdmYearCollection,
		///<summary>
		/// Collection of <c>FeeFacultyItem</c> as OneToMany for FeeCourseExpCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeCourseExp>))]
		FeeCourseExpCollection,
	}
	
	#endregion FeeFacultyItemChildEntityTypes
	
	#region FeeFacultyItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeFacultyItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeFacultyItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeFacultyItemFilterBuilder : SqlFilterBuilder<FeeFacultyItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeFacultyItemFilterBuilder class.
		/// </summary>
		public FeeFacultyItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeFacultyItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeFacultyItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeFacultyItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeFacultyItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeFacultyItemFilterBuilder
	
	#region FeeFacultyItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeFacultyItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeFacultyItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeFacultyItemParameterBuilder : ParameterizedSqlFilterBuilder<FeeFacultyItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeFacultyItemParameterBuilder class.
		/// </summary>
		public FeeFacultyItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeFacultyItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeFacultyItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeFacultyItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeFacultyItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeFacultyItemParameterBuilder
	
	#region FeeFacultyItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeFacultyItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeFacultyItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeFacultyItemSortBuilder : SqlSortBuilder<FeeFacultyItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeFacultyItemSqlSortBuilder class.
		/// </summary>
		public FeeFacultyItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeFacultyItemSortBuilder
	
} // end namespace
