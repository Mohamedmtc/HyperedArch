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
	/// This class is the base class for any <see cref="SaCdeAcadLoadProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCdeAcadLoadProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCdeAcadLoad, UMIS_VER2.BusinessLyer.SaCdeAcadLoadKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCdeAcadLoadKey key)
		{
			return Delete(transactionManager, key.SaCdeAcadLoadId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCdeAcadLoadId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCdeAcadLoadId)
		{
			return Delete(null, _saCdeAcadLoadId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCdeAcadLoadId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCdeAcadLoadId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_CDE_ACAD_LOAD_AS_FACULTY_INFO key.
		///		FK_SA_CDE_ACAD_LOAD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaCdeAcadLoad objects.</returns>
		public TList<SaCdeAcadLoad> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_CDE_ACAD_LOAD_AS_FACULTY_INFO key.
		///		FK_SA_CDE_ACAD_LOAD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaCdeAcadLoad objects.</returns>
		/// <remarks></remarks>
		public TList<SaCdeAcadLoad> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_CDE_ACAD_LOAD_AS_FACULTY_INFO key.
		///		FK_SA_CDE_ACAD_LOAD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaCdeAcadLoad objects.</returns>
		public TList<SaCdeAcadLoad> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_CDE_ACAD_LOAD_AS_FACULTY_INFO key.
		///		fkSaCdeAcadLoadAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaCdeAcadLoad objects.</returns>
		public TList<SaCdeAcadLoad> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_CDE_ACAD_LOAD_AS_FACULTY_INFO key.
		///		fkSaCdeAcadLoadAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaCdeAcadLoad objects.</returns>
		public TList<SaCdeAcadLoad> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_CDE_ACAD_LOAD_AS_FACULTY_INFO key.
		///		FK_SA_CDE_ACAD_LOAD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaCdeAcadLoad objects.</returns>
		public abstract TList<SaCdeAcadLoad> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_CDE_ACAD_LOAD_SA_CODE_SC_DEG key.
		///		FK_SA_CDE_ACAD_LOAD_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaCdeAcadLoad objects.</returns>
		public TList<SaCdeAcadLoad> GetBySaCodeScDegId(System.Decimal _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(_saCodeScDegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_CDE_ACAD_LOAD_SA_CODE_SC_DEG key.
		///		FK_SA_CDE_ACAD_LOAD_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaCdeAcadLoad objects.</returns>
		/// <remarks></remarks>
		public TList<SaCdeAcadLoad> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_CDE_ACAD_LOAD_SA_CODE_SC_DEG key.
		///		FK_SA_CDE_ACAD_LOAD_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaCdeAcadLoad objects.</returns>
		public TList<SaCdeAcadLoad> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_CDE_ACAD_LOAD_SA_CODE_SC_DEG key.
		///		fkSaCdeAcadLoadSaCodeScDeg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaCdeAcadLoad objects.</returns>
		public TList<SaCdeAcadLoad> GetBySaCodeScDegId(System.Decimal _saCodeScDegId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_CDE_ACAD_LOAD_SA_CODE_SC_DEG key.
		///		fkSaCdeAcadLoadSaCodeScDeg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaCdeAcadLoad objects.</returns>
		public TList<SaCdeAcadLoad> GetBySaCodeScDegId(System.Decimal _saCodeScDegId, int start, int pageLength,out int count)
		{
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_CDE_ACAD_LOAD_SA_CODE_SC_DEG key.
		///		FK_SA_CDE_ACAD_LOAD_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaCdeAcadLoad objects.</returns>
		public abstract TList<SaCdeAcadLoad> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaCdeAcadLoad Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCdeAcadLoadKey key, int start, int pageLength)
		{
			return GetBySaCdeAcadLoadId(transactionManager, key.SaCdeAcadLoadId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CDE_ACAD_LOAD index.
		/// </summary>
		/// <param name="_saCdeAcadLoadId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCdeAcadLoad"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCdeAcadLoad GetBySaCdeAcadLoadId(System.Decimal _saCdeAcadLoadId)
		{
			int count = -1;
			return GetBySaCdeAcadLoadId(null,_saCdeAcadLoadId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CDE_ACAD_LOAD index.
		/// </summary>
		/// <param name="_saCdeAcadLoadId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCdeAcadLoad"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCdeAcadLoad GetBySaCdeAcadLoadId(System.Decimal _saCdeAcadLoadId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCdeAcadLoadId(null, _saCdeAcadLoadId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CDE_ACAD_LOAD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCdeAcadLoadId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCdeAcadLoad"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCdeAcadLoad GetBySaCdeAcadLoadId(TransactionManager transactionManager, System.Decimal _saCdeAcadLoadId)
		{
			int count = -1;
			return GetBySaCdeAcadLoadId(transactionManager, _saCdeAcadLoadId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CDE_ACAD_LOAD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCdeAcadLoadId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCdeAcadLoad"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCdeAcadLoad GetBySaCdeAcadLoadId(TransactionManager transactionManager, System.Decimal _saCdeAcadLoadId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCdeAcadLoadId(transactionManager, _saCdeAcadLoadId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CDE_ACAD_LOAD index.
		/// </summary>
		/// <param name="_saCdeAcadLoadId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCdeAcadLoad"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCdeAcadLoad GetBySaCdeAcadLoadId(System.Decimal _saCdeAcadLoadId, int start, int pageLength, out int count)
		{
			return GetBySaCdeAcadLoadId(null, _saCdeAcadLoadId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CDE_ACAD_LOAD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCdeAcadLoadId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCdeAcadLoad"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCdeAcadLoad GetBySaCdeAcadLoadId(TransactionManager transactionManager, System.Decimal _saCdeAcadLoadId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCdeAcadLoad&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCdeAcadLoad&gt;"/></returns>
		public static TList<SaCdeAcadLoad> Fill(IDataReader reader, TList<SaCdeAcadLoad> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCdeAcadLoad c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCdeAcadLoad")
					.Append("|").Append((System.Decimal)reader["SA_CDE_ACAD_LOAD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCdeAcadLoad>(
					key.ToString(), // EntityTrackingKey
					"SaCdeAcadLoad",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCdeAcadLoad();
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
					c.SaCdeAcadLoadId = (System.Decimal)reader["SA_CDE_ACAD_LOAD_ID"];
					c.OriginalSaCdeAcadLoadId = c.SaCdeAcadLoadId;
					c.SaCodeScDegId = (System.Decimal)reader["SA_CODE_SC_DEG_ID"];
					c.AcdLoad = (System.Decimal)reader["ACD_LOAD"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCdeAcadLoad"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCdeAcadLoad"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCdeAcadLoad entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCdeAcadLoadId = (System.Decimal)reader[((int)SaCdeAcadLoadColumn.SaCdeAcadLoadId - 1)];
			entity.OriginalSaCdeAcadLoadId = (System.Decimal)reader["SA_CDE_ACAD_LOAD_ID"];
			entity.SaCodeScDegId = (System.Decimal)reader[((int)SaCdeAcadLoadColumn.SaCodeScDegId - 1)];
			entity.AcdLoad = (System.Decimal)reader[((int)SaCdeAcadLoadColumn.AcdLoad - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)SaCdeAcadLoadColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)SaCdeAcadLoadColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCdeAcadLoad"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCdeAcadLoad"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCdeAcadLoad entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCdeAcadLoadId = (System.Decimal)dataRow["SA_CDE_ACAD_LOAD_ID"];
			entity.OriginalSaCdeAcadLoadId = (System.Decimal)dataRow["SA_CDE_ACAD_LOAD_ID"];
			entity.SaCodeScDegId = (System.Decimal)dataRow["SA_CODE_SC_DEG_ID"];
			entity.AcdLoad = (System.Decimal)dataRow["ACD_LOAD"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCdeAcadLoad"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCdeAcadLoad Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCdeAcadLoad entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsFacultyInfoId ?? 0.0m);
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, (entity.AsFacultyInfoId ?? 0.0m));		
				
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

			#region SaCodeScDegIdSource	
			if (CanDeepLoad(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepLoadType, innerList) 
				&& entity.SaCodeScDegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeScDegId;
				SaCodeScDeg tmpEntity = EntityManager.LocateEntity<SaCodeScDeg>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeScDeg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeScDegIdSource = tmpEntity;
				else
					entity.SaCodeScDegIdSource = DataRepository.SaCodeScDegProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeScDegIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeScDegIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeScDegProvider.DeepLoad(transactionManager, entity.SaCodeScDegIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeScDegIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCdeAcadLoad object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCdeAcadLoad instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCdeAcadLoad Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCdeAcadLoad entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region SaCodeScDegIdSource
			if (CanDeepSave(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepSaveType, innerList) 
				&& entity.SaCodeScDegIdSource != null)
			{
				DataRepository.SaCodeScDegProvider.Save(transactionManager, entity.SaCodeScDegIdSource);
				entity.SaCodeScDegId = entity.SaCodeScDegIdSource.SaCodeScDegId;
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
	
	#region SaCdeAcadLoadChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCdeAcadLoad</c>
	///</summary>
	public enum SaCdeAcadLoadChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>SaCodeScDeg</c> at SaCodeScDegIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeScDeg))]
		SaCodeScDeg,
	}
	
	#endregion SaCdeAcadLoadChildEntityTypes
	
	#region SaCdeAcadLoadFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCdeAcadLoadColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCdeAcadLoad"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCdeAcadLoadFilterBuilder : SqlFilterBuilder<SaCdeAcadLoadColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCdeAcadLoadFilterBuilder class.
		/// </summary>
		public SaCdeAcadLoadFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCdeAcadLoadFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCdeAcadLoadFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCdeAcadLoadFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCdeAcadLoadFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCdeAcadLoadFilterBuilder
	
	#region SaCdeAcadLoadParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCdeAcadLoadColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCdeAcadLoad"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCdeAcadLoadParameterBuilder : ParameterizedSqlFilterBuilder<SaCdeAcadLoadColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCdeAcadLoadParameterBuilder class.
		/// </summary>
		public SaCdeAcadLoadParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCdeAcadLoadParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCdeAcadLoadParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCdeAcadLoadParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCdeAcadLoadParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCdeAcadLoadParameterBuilder
	
	#region SaCdeAcadLoadSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCdeAcadLoadColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCdeAcadLoad"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCdeAcadLoadSortBuilder : SqlSortBuilder<SaCdeAcadLoadColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCdeAcadLoadSqlSortBuilder class.
		/// </summary>
		public SaCdeAcadLoadSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCdeAcadLoadSortBuilder
	
} // end namespace
