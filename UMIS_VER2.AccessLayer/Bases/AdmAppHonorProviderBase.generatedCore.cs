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
	/// This class is the base class for any <see cref="AdmAppHonorProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppHonorProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppHonor, UMIS_VER2.BusinessLyer.AdmAppHonorKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppHonorKey key)
		{
			return Delete(transactionManager, key.AdmAppHonorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppHonorId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppHonorId)
		{
			return Delete(null, _admAppHonorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppHonorId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppHonorId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_HONOR_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_HONOR_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppHonor objects.</returns>
		public TList<AdmAppHonor> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_HONOR_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_HONOR_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppHonor objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppHonor> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_HONOR_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_HONOR_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppHonor objects.</returns>
		public TList<AdmAppHonor> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_HONOR_ADM_APP_REG_HISTORY key.
		///		fkAdmAppHonorAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppHonor objects.</returns>
		public TList<AdmAppHonor> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_HONOR_ADM_APP_REG_HISTORY key.
		///		fkAdmAppHonorAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppHonor objects.</returns>
		public TList<AdmAppHonor> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_HONOR_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_HONOR_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppHonor objects.</returns>
		public abstract TList<AdmAppHonor> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_HONOR_ADM_APPLICANT key.
		///		FK_ADM_APP_HONOR_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppHonor objects.</returns>
		public TList<AdmAppHonor> GetByAdmApplicantId(System.Decimal _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_HONOR_ADM_APPLICANT key.
		///		FK_ADM_APP_HONOR_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppHonor objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppHonor> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_HONOR_ADM_APPLICANT key.
		///		FK_ADM_APP_HONOR_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppHonor objects.</returns>
		public TList<AdmAppHonor> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_HONOR_ADM_APPLICANT key.
		///		fkAdmAppHonorAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppHonor objects.</returns>
		public TList<AdmAppHonor> GetByAdmApplicantId(System.Decimal _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_HONOR_ADM_APPLICANT key.
		///		fkAdmAppHonorAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppHonor objects.</returns>
		public TList<AdmAppHonor> GetByAdmApplicantId(System.Decimal _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_HONOR_ADM_APPLICANT key.
		///		FK_ADM_APP_HONOR_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppHonor objects.</returns>
		public abstract TList<AdmAppHonor> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppHonor Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppHonorKey key, int start, int pageLength)
		{
			return GetByAdmAppHonorId(transactionManager, key.AdmAppHonorId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_HONOR index.
		/// </summary>
		/// <param name="_admAppHonorId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppHonor GetByAdmAppHonorId(System.Decimal _admAppHonorId)
		{
			int count = -1;
			return GetByAdmAppHonorId(null,_admAppHonorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_HONOR index.
		/// </summary>
		/// <param name="_admAppHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppHonor GetByAdmAppHonorId(System.Decimal _admAppHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppHonorId(null, _admAppHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_HONOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppHonorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppHonor GetByAdmAppHonorId(TransactionManager transactionManager, System.Decimal _admAppHonorId)
		{
			int count = -1;
			return GetByAdmAppHonorId(transactionManager, _admAppHonorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_HONOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppHonor GetByAdmAppHonorId(TransactionManager transactionManager, System.Decimal _admAppHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppHonorId(transactionManager, _admAppHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_HONOR index.
		/// </summary>
		/// <param name="_admAppHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppHonor GetByAdmAppHonorId(System.Decimal _admAppHonorId, int start, int pageLength, out int count)
		{
			return GetByAdmAppHonorId(null, _admAppHonorId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_HONOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppHonor"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppHonor GetByAdmAppHonorId(TransactionManager transactionManager, System.Decimal _admAppHonorId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppHonor&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppHonor&gt;"/></returns>
		public static TList<AdmAppHonor> Fill(IDataReader reader, TList<AdmAppHonor> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppHonor c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppHonor")
					.Append("|").Append((System.Decimal)reader["ADM_APP_HONOR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppHonor>(
					key.ToString(), // EntityTrackingKey
					"AdmAppHonor",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppHonor();
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
					c.AdmAppHonorId = (System.Decimal)reader["ADM_APP_HONOR_ID"];
					c.OriginalAdmAppHonorId = c.AdmAppHonorId;
					c.AdmApplicantId = (System.Decimal)reader["ADM_APPLICANT_ID"];
					c.ActvtyDescEn = Convert.IsDBNull(reader["ACTVTY_DESC_EN"]) ? null : (System.String)reader["ACTVTY_DESC_EN"];
					c.HonorDescEn = Convert.IsDBNull(reader["HONOR_DESC_EN"]) ? null : (System.String)reader["HONOR_DESC_EN"];
					c.HonorDate = Convert.IsDBNull(reader["HONOR_DATE"]) ? null : (System.DateTime?)reader["HONOR_DATE"];
					c.AdmAppRegHistoryId = Convert.IsDBNull(reader["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)reader["ADM_APP_REG_HISTORY_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppHonor"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppHonor"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppHonor entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppHonorId = (System.Decimal)reader[((int)AdmAppHonorColumn.AdmAppHonorId - 1)];
			entity.OriginalAdmAppHonorId = (System.Decimal)reader["ADM_APP_HONOR_ID"];
			entity.AdmApplicantId = (System.Decimal)reader[((int)AdmAppHonorColumn.AdmApplicantId - 1)];
			entity.ActvtyDescEn = (reader.IsDBNull(((int)AdmAppHonorColumn.ActvtyDescEn - 1)))?null:(System.String)reader[((int)AdmAppHonorColumn.ActvtyDescEn - 1)];
			entity.HonorDescEn = (reader.IsDBNull(((int)AdmAppHonorColumn.HonorDescEn - 1)))?null:(System.String)reader[((int)AdmAppHonorColumn.HonorDescEn - 1)];
			entity.HonorDate = (reader.IsDBNull(((int)AdmAppHonorColumn.HonorDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppHonorColumn.HonorDate - 1)];
			entity.AdmAppRegHistoryId = (reader.IsDBNull(((int)AdmAppHonorColumn.AdmAppRegHistoryId - 1)))?null:(System.Decimal?)reader[((int)AdmAppHonorColumn.AdmAppRegHistoryId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppHonor"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppHonor"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppHonor entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppHonorId = (System.Decimal)dataRow["ADM_APP_HONOR_ID"];
			entity.OriginalAdmAppHonorId = (System.Decimal)dataRow["ADM_APP_HONOR_ID"];
			entity.AdmApplicantId = (System.Decimal)dataRow["ADM_APPLICANT_ID"];
			entity.ActvtyDescEn = Convert.IsDBNull(dataRow["ACTVTY_DESC_EN"]) ? null : (System.String)dataRow["ACTVTY_DESC_EN"];
			entity.HonorDescEn = Convert.IsDBNull(dataRow["HONOR_DESC_EN"]) ? null : (System.String)dataRow["HONOR_DESC_EN"];
			entity.HonorDate = Convert.IsDBNull(dataRow["HONOR_DATE"]) ? null : (System.DateTime?)dataRow["HONOR_DATE"];
			entity.AdmAppRegHistoryId = Convert.IsDBNull(dataRow["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_REG_HISTORY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppHonor"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppHonor Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppHonor entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppRegHistoryIdSource	
			if (CanDeepLoad(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepLoadType, innerList) 
				&& entity.AdmAppRegHistoryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmAppRegHistoryId ?? 0.0m);
				AdmAppRegHistory tmpEntity = EntityManager.LocateEntity<AdmAppRegHistory>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppRegHistory), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppRegHistoryIdSource = tmpEntity;
				else
					entity.AdmAppRegHistoryIdSource = DataRepository.AdmAppRegHistoryProvider.GetByAdmAppRegHistoryId(transactionManager, (entity.AdmAppRegHistoryId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppRegHistoryIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppRegHistoryProvider.DeepLoad(transactionManager, entity.AdmAppRegHistoryIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppRegHistoryIdSource

			#region AdmApplicantIdSource	
			if (CanDeepLoad(entity, "AdmApplicant|AdmApplicantIdSource", deepLoadType, innerList) 
				&& entity.AdmApplicantIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmApplicantId;
				AdmApplicant tmpEntity = EntityManager.LocateEntity<AdmApplicant>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmApplicant), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmApplicantIdSource = tmpEntity;
				else
					entity.AdmApplicantIdSource = DataRepository.AdmApplicantProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmApplicantIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmApplicantIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmApplicantProvider.DeepLoad(transactionManager, entity.AdmApplicantIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmApplicantIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmAppHonorId methods when available
			
			#region GsAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAttchdDoc>|GsAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAttchdDocCollection = DataRepository.GsAttchdDocProvider.GetByAdmAppHonorId(transactionManager, entity.AdmAppHonorId);

				if (deep && entity.GsAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAttchdDoc>) DataRepository.GsAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppHonor object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppHonor instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppHonor Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppHonor entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAppRegHistoryIdSource
			if (CanDeepSave(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepSaveType, innerList) 
				&& entity.AdmAppRegHistoryIdSource != null)
			{
				DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryIdSource);
				entity.AdmAppRegHistoryId = entity.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
			}
			#endregion 
			
			#region AdmApplicantIdSource
			if (CanDeepSave(entity, "AdmApplicant|AdmApplicantIdSource", deepSaveType, innerList) 
				&& entity.AdmApplicantIdSource != null)
			{
				DataRepository.AdmApplicantProvider.Save(transactionManager, entity.AdmApplicantIdSource);
				entity.AdmApplicantId = entity.AdmApplicantIdSource.AdmApplicantId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<GsAttchdDoc>
				if (CanDeepSave(entity.GsAttchdDocCollection, "List<GsAttchdDoc>|GsAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAttchdDoc child in entity.GsAttchdDocCollection)
					{
						if(child.AdmAppHonorIdSource != null)
						{
							child.AdmAppHonorId = child.AdmAppHonorIdSource.AdmAppHonorId;
						}
						else
						{
							child.AdmAppHonorId = entity.AdmAppHonorId;
						}

					}

					if (entity.GsAttchdDocCollection.Count > 0 || entity.GsAttchdDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsAttchdDocProvider.Save(transactionManager, entity.GsAttchdDocCollection);
						
						deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsAttchdDoc >) DataRepository.GsAttchdDocProvider.DeepSave,
							new object[] { transactionManager, entity.GsAttchdDocCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmAppHonorChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppHonor</c>
	///</summary>
	public enum AdmAppHonorChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppRegHistory</c> at AdmAppRegHistoryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppRegHistory))]
		AdmAppRegHistory,
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		///<summary>
		/// Collection of <c>AdmAppHonor</c> as OneToMany for GsAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAttchdDoc>))]
		GsAttchdDocCollection,
	}
	
	#endregion AdmAppHonorChildEntityTypes
	
	#region AdmAppHonorFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppHonorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppHonor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppHonorFilterBuilder : SqlFilterBuilder<AdmAppHonorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppHonorFilterBuilder class.
		/// </summary>
		public AdmAppHonorFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppHonorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppHonorFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppHonorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppHonorFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppHonorFilterBuilder
	
	#region AdmAppHonorParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppHonorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppHonor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppHonorParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppHonorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppHonorParameterBuilder class.
		/// </summary>
		public AdmAppHonorParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppHonorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppHonorParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppHonorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppHonorParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppHonorParameterBuilder
	
	#region AdmAppHonorSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppHonorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppHonor"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppHonorSortBuilder : SqlSortBuilder<AdmAppHonorColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppHonorSqlSortBuilder class.
		/// </summary>
		public AdmAppHonorSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppHonorSortBuilder
	
} // end namespace