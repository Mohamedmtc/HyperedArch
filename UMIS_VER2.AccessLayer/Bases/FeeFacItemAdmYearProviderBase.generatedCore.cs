﻿#region Using directives

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
	/// This class is the base class for any <see cref="FeeFacItemAdmYearProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeFacItemAdmYearProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeFacItemAdmYear, UMIS_VER2.BusinessLyer.FeeFacItemAdmYearKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFacItemAdmYearKey key)
		{
			return Delete(transactionManager, key.FeeFacItemAdmYearId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeFacItemAdmYearId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeFacItemAdmYearId)
		{
			return Delete(null, _feeFacItemAdmYearId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacItemAdmYearId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeFacItemAdmYearId);		
		
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
		public override UMIS_VER2.BusinessLyer.FeeFacItemAdmYear Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFacItemAdmYearKey key, int start, int pageLength)
		{
			return GetByFeeFacItemAdmYearId(transactionManager, key.FeeFacItemAdmYearId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacItemAdmYear&gt;"/> class.</returns>
		public TList<FeeFacItemAdmYear> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(null,_edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacItemAdmYear&gt;"/> class.</returns>
		public TList<FeeFacItemAdmYear> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacItemAdmYear&gt;"/> class.</returns>
		public TList<FeeFacItemAdmYear> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacItemAdmYear&gt;"/> class.</returns>
		public TList<FeeFacItemAdmYear> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacItemAdmYear&gt;"/> class.</returns>
		public TList<FeeFacItemAdmYear> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacItemAdmYear&gt;"/> class.</returns>
		public abstract TList<FeeFacItemAdmYear> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_FEE_FACULTY_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_feeFacultyItemId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacItemAdmYear&gt;"/> class.</returns>
		public TList<FeeFacItemAdmYear> GetByFeeFacultyItemId(System.Decimal _feeFacultyItemId)
		{
			int count = -1;
			return GetByFeeFacultyItemId(null,_feeFacultyItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacItemAdmYear&gt;"/> class.</returns>
		public TList<FeeFacItemAdmYear> GetByFeeFacultyItemId(System.Decimal _feeFacultyItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFacultyItemId(null, _feeFacultyItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacItemAdmYear&gt;"/> class.</returns>
		public TList<FeeFacItemAdmYear> GetByFeeFacultyItemId(TransactionManager transactionManager, System.Decimal _feeFacultyItemId)
		{
			int count = -1;
			return GetByFeeFacultyItemId(transactionManager, _feeFacultyItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacItemAdmYear&gt;"/> class.</returns>
		public TList<FeeFacItemAdmYear> GetByFeeFacultyItemId(TransactionManager transactionManager, System.Decimal _feeFacultyItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFacultyItemId(transactionManager, _feeFacultyItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacItemAdmYear&gt;"/> class.</returns>
		public TList<FeeFacItemAdmYear> GetByFeeFacultyItemId(System.Decimal _feeFacultyItemId, int start, int pageLength, out int count)
		{
			return GetByFeeFacultyItemId(null, _feeFacultyItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacItemAdmYear&gt;"/> class.</returns>
		public abstract TList<FeeFacItemAdmYear> GetByFeeFacultyItemId(TransactionManager transactionManager, System.Decimal _feeFacultyItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_FAC_ITEM_ADM_YEAR index.
		/// </summary>
		/// <param name="_feeFacItemAdmYearId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacItemAdmYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacItemAdmYear GetByFeeFacItemAdmYearId(System.Decimal _feeFacItemAdmYearId)
		{
			int count = -1;
			return GetByFeeFacItemAdmYearId(null,_feeFacItemAdmYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FAC_ITEM_ADM_YEAR index.
		/// </summary>
		/// <param name="_feeFacItemAdmYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacItemAdmYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacItemAdmYear GetByFeeFacItemAdmYearId(System.Decimal _feeFacItemAdmYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFacItemAdmYearId(null, _feeFacItemAdmYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FAC_ITEM_ADM_YEAR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacItemAdmYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacItemAdmYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacItemAdmYear GetByFeeFacItemAdmYearId(TransactionManager transactionManager, System.Decimal _feeFacItemAdmYearId)
		{
			int count = -1;
			return GetByFeeFacItemAdmYearId(transactionManager, _feeFacItemAdmYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FAC_ITEM_ADM_YEAR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacItemAdmYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacItemAdmYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacItemAdmYear GetByFeeFacItemAdmYearId(TransactionManager transactionManager, System.Decimal _feeFacItemAdmYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFacItemAdmYearId(transactionManager, _feeFacItemAdmYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FAC_ITEM_ADM_YEAR index.
		/// </summary>
		/// <param name="_feeFacItemAdmYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacItemAdmYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacItemAdmYear GetByFeeFacItemAdmYearId(System.Decimal _feeFacItemAdmYearId, int start, int pageLength, out int count)
		{
			return GetByFeeFacItemAdmYearId(null, _feeFacItemAdmYearId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FAC_ITEM_ADM_YEAR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacItemAdmYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacItemAdmYear"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeFacItemAdmYear GetByFeeFacItemAdmYearId(TransactionManager transactionManager, System.Decimal _feeFacItemAdmYearId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeFacItemAdmYear&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeFacItemAdmYear&gt;"/></returns>
		public static TList<FeeFacItemAdmYear> Fill(IDataReader reader, TList<FeeFacItemAdmYear> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeFacItemAdmYear c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeFacItemAdmYear")
					.Append("|").Append((System.Decimal)reader["FEE_FAC_ITEM_ADM_YEAR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeFacItemAdmYear>(
					key.ToString(), // EntityTrackingKey
					"FeeFacItemAdmYear",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeFacItemAdmYear();
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
					c.FeeFacItemAdmYearId = (System.Decimal)reader["FEE_FAC_ITEM_ADM_YEAR_ID"];
					c.OriginalFeeFacItemAdmYearId = c.FeeFacItemAdmYearId;
					c.FeeFacultyItemId = (System.Decimal)reader["FEE_FACULTY_ITEM_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.FeeItemValue = (System.Decimal)reader["FEE_ITEM_VALUE"];
					c.Instlmnt1 = Convert.IsDBNull(reader["INSTLMNT_1"]) ? null : (System.Decimal?)reader["INSTLMNT_1"];
					c.Instlmnt2 = Convert.IsDBNull(reader["INSTLMNT_2"]) ? null : (System.Decimal?)reader["INSTLMNT_2"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeFacItemAdmYear"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeFacItemAdmYear"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeFacItemAdmYear entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeFacItemAdmYearId = (System.Decimal)reader[((int)FeeFacItemAdmYearColumn.FeeFacItemAdmYearId - 1)];
			entity.OriginalFeeFacItemAdmYearId = (System.Decimal)reader["FEE_FAC_ITEM_ADM_YEAR_ID"];
			entity.FeeFacultyItemId = (System.Decimal)reader[((int)FeeFacItemAdmYearColumn.FeeFacultyItemId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)FeeFacItemAdmYearColumn.EdAcadYearId - 1)];
			entity.FeeItemValue = (System.Decimal)reader[((int)FeeFacItemAdmYearColumn.FeeItemValue - 1)];
			entity.Instlmnt1 = (reader.IsDBNull(((int)FeeFacItemAdmYearColumn.Instlmnt1 - 1)))?null:(System.Decimal?)reader[((int)FeeFacItemAdmYearColumn.Instlmnt1 - 1)];
			entity.Instlmnt2 = (reader.IsDBNull(((int)FeeFacItemAdmYearColumn.Instlmnt2 - 1)))?null:(System.Decimal?)reader[((int)FeeFacItemAdmYearColumn.Instlmnt2 - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeFacItemAdmYear"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeFacItemAdmYear"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeFacItemAdmYear entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeFacItemAdmYearId = (System.Decimal)dataRow["FEE_FAC_ITEM_ADM_YEAR_ID"];
			entity.OriginalFeeFacItemAdmYearId = (System.Decimal)dataRow["FEE_FAC_ITEM_ADM_YEAR_ID"];
			entity.FeeFacultyItemId = (System.Decimal)dataRow["FEE_FACULTY_ITEM_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.FeeItemValue = (System.Decimal)dataRow["FEE_ITEM_VALUE"];
			entity.Instlmnt1 = Convert.IsDBNull(dataRow["INSTLMNT_1"]) ? null : (System.Decimal?)dataRow["INSTLMNT_1"];
			entity.Instlmnt2 = Convert.IsDBNull(dataRow["INSTLMNT_2"]) ? null : (System.Decimal?)dataRow["INSTLMNT_2"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeFacItemAdmYear"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeFacItemAdmYear Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFacItemAdmYear entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdAcadYearId;
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearIdSource

			#region FeeFacultyItemIdSource	
			if (CanDeepLoad(entity, "FeeFacultyItem|FeeFacultyItemIdSource", deepLoadType, innerList) 
				&& entity.FeeFacultyItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeFacultyItemId;
				FeeFacultyItem tmpEntity = EntityManager.LocateEntity<FeeFacultyItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeFacultyItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeFacultyItemIdSource = tmpEntity;
				else
					entity.FeeFacultyItemIdSource = DataRepository.FeeFacultyItemProvider.GetByFeeFacultyItemId(transactionManager, entity.FeeFacultyItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeFacultyItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeFacultyItemProvider.DeepLoad(transactionManager, entity.FeeFacultyItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeFacultyItemIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeFacItemAdmYear object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeFacItemAdmYear instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeFacItemAdmYear Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFacItemAdmYear entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region FeeFacultyItemIdSource
			if (CanDeepSave(entity, "FeeFacultyItem|FeeFacultyItemIdSource", deepSaveType, innerList) 
				&& entity.FeeFacultyItemIdSource != null)
			{
				DataRepository.FeeFacultyItemProvider.Save(transactionManager, entity.FeeFacultyItemIdSource);
				entity.FeeFacultyItemId = entity.FeeFacultyItemIdSource.FeeFacultyItemId;
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
	
	#region FeeFacItemAdmYearChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeFacItemAdmYear</c>
	///</summary>
	public enum FeeFacItemAdmYearChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>FeeFacultyItem</c> at FeeFacultyItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeFacultyItem))]
		FeeFacultyItem,
	}
	
	#endregion FeeFacItemAdmYearChildEntityTypes
	
	#region FeeFacItemAdmYearFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeFacItemAdmYearColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeFacItemAdmYear"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeFacItemAdmYearFilterBuilder : SqlFilterBuilder<FeeFacItemAdmYearColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeFacItemAdmYearFilterBuilder class.
		/// </summary>
		public FeeFacItemAdmYearFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeFacItemAdmYearFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeFacItemAdmYearFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeFacItemAdmYearFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeFacItemAdmYearFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeFacItemAdmYearFilterBuilder
	
	#region FeeFacItemAdmYearParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeFacItemAdmYearColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeFacItemAdmYear"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeFacItemAdmYearParameterBuilder : ParameterizedSqlFilterBuilder<FeeFacItemAdmYearColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeFacItemAdmYearParameterBuilder class.
		/// </summary>
		public FeeFacItemAdmYearParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeFacItemAdmYearParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeFacItemAdmYearParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeFacItemAdmYearParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeFacItemAdmYearParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeFacItemAdmYearParameterBuilder
	
	#region FeeFacItemAdmYearSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeFacItemAdmYearColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeFacItemAdmYear"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeFacItemAdmYearSortBuilder : SqlSortBuilder<FeeFacItemAdmYearColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeFacItemAdmYearSqlSortBuilder class.
		/// </summary>
		public FeeFacItemAdmYearSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeFacItemAdmYearSortBuilder
	
} // end namespace
