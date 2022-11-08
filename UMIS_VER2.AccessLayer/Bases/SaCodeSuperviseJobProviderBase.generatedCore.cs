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
	/// This class is the base class for any <see cref="SaCodeSuperviseJobProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeSuperviseJobProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeSuperviseJob, UMIS_VER2.BusinessLyer.SaCodeSuperviseJobKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeSuperviseJobKey key)
		{
			return Delete(transactionManager, key.SaCodeSuperviseJobId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeSuperviseJobId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeSuperviseJobId)
		{
			return Delete(null, _saCodeSuperviseJobId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSuperviseJobId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeSuperviseJobId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeSuperviseJob Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeSuperviseJobKey key, int start, int pageLength)
		{
			return GetBySaCodeSuperviseJobId(transactionManager, key.SaCodeSuperviseJobId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SA_CODE_SUPERVISE_JOB2 index.
		/// </summary>
		/// <param name="_jobDescrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeSuperviseJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeSuperviseJob GetByJobDescrAr(System.String _jobDescrAr)
		{
			int count = -1;
			return GetByJobDescrAr(null,_jobDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_SUPERVISE_JOB2 index.
		/// </summary>
		/// <param name="_jobDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeSuperviseJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeSuperviseJob GetByJobDescrAr(System.String _jobDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByJobDescrAr(null, _jobDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_SUPERVISE_JOB2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_jobDescrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeSuperviseJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeSuperviseJob GetByJobDescrAr(TransactionManager transactionManager, System.String _jobDescrAr)
		{
			int count = -1;
			return GetByJobDescrAr(transactionManager, _jobDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_SUPERVISE_JOB2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_jobDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeSuperviseJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeSuperviseJob GetByJobDescrAr(TransactionManager transactionManager, System.String _jobDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByJobDescrAr(transactionManager, _jobDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_SUPERVISE_JOB2 index.
		/// </summary>
		/// <param name="_jobDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeSuperviseJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeSuperviseJob GetByJobDescrAr(System.String _jobDescrAr, int start, int pageLength, out int count)
		{
			return GetByJobDescrAr(null, _jobDescrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_SUPERVISE_JOB2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_jobDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeSuperviseJob"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeSuperviseJob GetByJobDescrAr(TransactionManager transactionManager, System.String _jobDescrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_3322 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeSuperviseJob&gt;"/> class.</returns>
		public TList<SaCodeSuperviseJob> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_3322 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeSuperviseJob&gt;"/> class.</returns>
		public TList<SaCodeSuperviseJob> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_3322 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeSuperviseJob&gt;"/> class.</returns>
		public TList<SaCodeSuperviseJob> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_3322 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeSuperviseJob&gt;"/> class.</returns>
		public TList<SaCodeSuperviseJob> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_3322 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeSuperviseJob&gt;"/> class.</returns>
		public TList<SaCodeSuperviseJob> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_3322 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeSuperviseJob&gt;"/> class.</returns>
		public abstract TList<SaCodeSuperviseJob> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_SUPERVISE_JOB index.
		/// </summary>
		/// <param name="_saCodeSuperviseJobId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeSuperviseJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeSuperviseJob GetBySaCodeSuperviseJobId(System.Decimal _saCodeSuperviseJobId)
		{
			int count = -1;
			return GetBySaCodeSuperviseJobId(null,_saCodeSuperviseJobId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SUPERVISE_JOB index.
		/// </summary>
		/// <param name="_saCodeSuperviseJobId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeSuperviseJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeSuperviseJob GetBySaCodeSuperviseJobId(System.Decimal _saCodeSuperviseJobId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeSuperviseJobId(null, _saCodeSuperviseJobId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SUPERVISE_JOB index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSuperviseJobId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeSuperviseJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeSuperviseJob GetBySaCodeSuperviseJobId(TransactionManager transactionManager, System.Decimal _saCodeSuperviseJobId)
		{
			int count = -1;
			return GetBySaCodeSuperviseJobId(transactionManager, _saCodeSuperviseJobId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SUPERVISE_JOB index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSuperviseJobId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeSuperviseJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeSuperviseJob GetBySaCodeSuperviseJobId(TransactionManager transactionManager, System.Decimal _saCodeSuperviseJobId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeSuperviseJobId(transactionManager, _saCodeSuperviseJobId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SUPERVISE_JOB index.
		/// </summary>
		/// <param name="_saCodeSuperviseJobId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeSuperviseJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeSuperviseJob GetBySaCodeSuperviseJobId(System.Decimal _saCodeSuperviseJobId, int start, int pageLength, out int count)
		{
			return GetBySaCodeSuperviseJobId(null, _saCodeSuperviseJobId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SUPERVISE_JOB index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSuperviseJobId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeSuperviseJob"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeSuperviseJob GetBySaCodeSuperviseJobId(TransactionManager transactionManager, System.Decimal _saCodeSuperviseJobId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeSuperviseJob&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeSuperviseJob&gt;"/></returns>
		public static TList<SaCodeSuperviseJob> Fill(IDataReader reader, TList<SaCodeSuperviseJob> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeSuperviseJob c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeSuperviseJob")
					.Append("|").Append((System.Decimal)reader["SA_CODE_SUPERVISE_JOB_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeSuperviseJob>(
					key.ToString(), // EntityTrackingKey
					"SaCodeSuperviseJob",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeSuperviseJob();
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
					c.SaCodeSuperviseJobId = (System.Decimal)reader["SA_CODE_SUPERVISE_JOB_ID"];
					c.OriginalSaCodeSuperviseJobId = c.SaCodeSuperviseJobId;
					c.JobCode = Convert.IsDBNull(reader["JOB_CODE"]) ? null : (System.String)reader["JOB_CODE"];
					c.IsSupervising = (System.Decimal)reader["IS_SUPERVISING"];
					c.JobDescrAr = (System.String)reader["JOB_DESCR_AR"];
					c.JobDescrEn = Convert.IsDBNull(reader["JOB_DESCR_EN"]) ? null : (System.String)reader["JOB_DESCR_EN"];
					c.JobPeriod = Convert.IsDBNull(reader["JOB_PERIOD"]) ? null : (System.Decimal?)reader["JOB_PERIOD"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeSuperviseJob"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeSuperviseJob"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeSuperviseJob entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeSuperviseJobId = (System.Decimal)reader[((int)SaCodeSuperviseJobColumn.SaCodeSuperviseJobId - 1)];
			entity.OriginalSaCodeSuperviseJobId = (System.Decimal)reader["SA_CODE_SUPERVISE_JOB_ID"];
			entity.JobCode = (reader.IsDBNull(((int)SaCodeSuperviseJobColumn.JobCode - 1)))?null:(System.String)reader[((int)SaCodeSuperviseJobColumn.JobCode - 1)];
			entity.IsSupervising = (System.Decimal)reader[((int)SaCodeSuperviseJobColumn.IsSupervising - 1)];
			entity.JobDescrAr = (System.String)reader[((int)SaCodeSuperviseJobColumn.JobDescrAr - 1)];
			entity.JobDescrEn = (reader.IsDBNull(((int)SaCodeSuperviseJobColumn.JobDescrEn - 1)))?null:(System.String)reader[((int)SaCodeSuperviseJobColumn.JobDescrEn - 1)];
			entity.JobPeriod = (reader.IsDBNull(((int)SaCodeSuperviseJobColumn.JobPeriod - 1)))?null:(System.Decimal?)reader[((int)SaCodeSuperviseJobColumn.JobPeriod - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaCodeSuperviseJobColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeSuperviseJob"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeSuperviseJob"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeSuperviseJob entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeSuperviseJobId = (System.Decimal)dataRow["SA_CODE_SUPERVISE_JOB_ID"];
			entity.OriginalSaCodeSuperviseJobId = (System.Decimal)dataRow["SA_CODE_SUPERVISE_JOB_ID"];
			entity.JobCode = Convert.IsDBNull(dataRow["JOB_CODE"]) ? null : (System.String)dataRow["JOB_CODE"];
			entity.IsSupervising = (System.Decimal)dataRow["IS_SUPERVISING"];
			entity.JobDescrAr = (System.String)dataRow["JOB_DESCR_AR"];
			entity.JobDescrEn = Convert.IsDBNull(dataRow["JOB_DESCR_EN"]) ? null : (System.String)dataRow["JOB_DESCR_EN"];
			entity.JobPeriod = Convert.IsDBNull(dataRow["JOB_PERIOD"]) ? null : (System.Decimal?)dataRow["JOB_PERIOD"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeSuperviseJob"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeSuperviseJob Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeSuperviseJob entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeSuperviseJobId methods when available
			
			#region SaSupervisingJobsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaSupervisingJobs>|SaSupervisingJobsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaSupervisingJobsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaSupervisingJobsCollection = DataRepository.SaSupervisingJobsProvider.GetBySaCodeSuperviseJobId(transactionManager, entity.SaCodeSuperviseJobId);

				if (deep && entity.SaSupervisingJobsCollection.Count > 0)
				{
					deepHandles.Add("SaSupervisingJobsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaSupervisingJobs>) DataRepository.SaSupervisingJobsProvider.DeepLoad,
						new object[] { transactionManager, entity.SaSupervisingJobsCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeSuperviseJob object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeSuperviseJob instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeSuperviseJob Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeSuperviseJob entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaSupervisingJobs>
				if (CanDeepSave(entity.SaSupervisingJobsCollection, "List<SaSupervisingJobs>|SaSupervisingJobsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaSupervisingJobs child in entity.SaSupervisingJobsCollection)
					{
						if(child.SaCodeSuperviseJobIdSource != null)
						{
							child.SaCodeSuperviseJobId = child.SaCodeSuperviseJobIdSource.SaCodeSuperviseJobId;
						}
						else
						{
							child.SaCodeSuperviseJobId = entity.SaCodeSuperviseJobId;
						}

					}

					if (entity.SaSupervisingJobsCollection.Count > 0 || entity.SaSupervisingJobsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaSupervisingJobsProvider.Save(transactionManager, entity.SaSupervisingJobsCollection);
						
						deepHandles.Add("SaSupervisingJobsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaSupervisingJobs >) DataRepository.SaSupervisingJobsProvider.DeepSave,
							new object[] { transactionManager, entity.SaSupervisingJobsCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodeSuperviseJobChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeSuperviseJob</c>
	///</summary>
	public enum SaCodeSuperviseJobChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		///<summary>
		/// Collection of <c>SaCodeSuperviseJob</c> as OneToMany for SaSupervisingJobsCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaSupervisingJobs>))]
		SaSupervisingJobsCollection,
	}
	
	#endregion SaCodeSuperviseJobChildEntityTypes
	
	#region SaCodeSuperviseJobFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeSuperviseJobColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeSuperviseJob"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeSuperviseJobFilterBuilder : SqlFilterBuilder<SaCodeSuperviseJobColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeSuperviseJobFilterBuilder class.
		/// </summary>
		public SaCodeSuperviseJobFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeSuperviseJobFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeSuperviseJobFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeSuperviseJobFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeSuperviseJobFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeSuperviseJobFilterBuilder
	
	#region SaCodeSuperviseJobParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeSuperviseJobColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeSuperviseJob"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeSuperviseJobParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeSuperviseJobColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeSuperviseJobParameterBuilder class.
		/// </summary>
		public SaCodeSuperviseJobParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeSuperviseJobParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeSuperviseJobParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeSuperviseJobParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeSuperviseJobParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeSuperviseJobParameterBuilder
	
	#region SaCodeSuperviseJobSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeSuperviseJobColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeSuperviseJob"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeSuperviseJobSortBuilder : SqlSortBuilder<SaCodeSuperviseJobColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeSuperviseJobSqlSortBuilder class.
		/// </summary>
		public SaCodeSuperviseJobSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeSuperviseJobSortBuilder
	
} // end namespace
