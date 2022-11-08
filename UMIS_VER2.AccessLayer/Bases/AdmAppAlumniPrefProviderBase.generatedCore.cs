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
	/// This class is the base class for any <see cref="AdmAppAlumniPrefProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppAlumniPrefProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppAlumniPref, UMIS_VER2.BusinessLyer.AdmAppAlumniPrefKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppAlumniPrefKey key)
		{
			return Delete(transactionManager, key.AdmAppAlumniPrefId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppAlumniPrefId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppAlumniPrefId)
		{
			return Delete(null, _admAppAlumniPrefId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppAlumniPrefId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppAlumniPrefId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ALUMNI_PREF_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_ALUMNI_PREF_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppAlumniPref objects.</returns>
		public TList<AdmAppAlumniPref> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ALUMNI_PREF_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_ALUMNI_PREF_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppAlumniPref objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppAlumniPref> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ALUMNI_PREF_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_ALUMNI_PREF_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppAlumniPref objects.</returns>
		public TList<AdmAppAlumniPref> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ALUMNI_PREF_ADM_APP_REG_HISTORY key.
		///		fkAdmAppAlumniPrefAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppAlumniPref objects.</returns>
		public TList<AdmAppAlumniPref> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ALUMNI_PREF_ADM_APP_REG_HISTORY key.
		///		fkAdmAppAlumniPrefAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppAlumniPref objects.</returns>
		public TList<AdmAppAlumniPref> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ALUMNI_PREF_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_ALUMNI_PREF_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppAlumniPref objects.</returns>
		public abstract TList<AdmAppAlumniPref> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ALUMNI_PREF_ADM_CDE_ALUMNI_PREF key.
		///		FK_ADM_APP_ALUMNI_PREF_ADM_CDE_ALUMNI_PREF Description: 
		/// </summary>
		/// <param name="_admCdeAlumniPrefId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppAlumniPref objects.</returns>
		public TList<AdmAppAlumniPref> GetByAdmCdeAlumniPrefId(System.Int32 _admCdeAlumniPrefId)
		{
			int count = -1;
			return GetByAdmCdeAlumniPrefId(_admCdeAlumniPrefId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ALUMNI_PREF_ADM_CDE_ALUMNI_PREF key.
		///		FK_ADM_APP_ALUMNI_PREF_ADM_CDE_ALUMNI_PREF Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAlumniPrefId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppAlumniPref objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppAlumniPref> GetByAdmCdeAlumniPrefId(TransactionManager transactionManager, System.Int32 _admCdeAlumniPrefId)
		{
			int count = -1;
			return GetByAdmCdeAlumniPrefId(transactionManager, _admCdeAlumniPrefId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ALUMNI_PREF_ADM_CDE_ALUMNI_PREF key.
		///		FK_ADM_APP_ALUMNI_PREF_ADM_CDE_ALUMNI_PREF Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAlumniPrefId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppAlumniPref objects.</returns>
		public TList<AdmAppAlumniPref> GetByAdmCdeAlumniPrefId(TransactionManager transactionManager, System.Int32 _admCdeAlumniPrefId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeAlumniPrefId(transactionManager, _admCdeAlumniPrefId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ALUMNI_PREF_ADM_CDE_ALUMNI_PREF key.
		///		fkAdmAppAlumniPrefAdmCdeAlumniPref Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeAlumniPrefId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppAlumniPref objects.</returns>
		public TList<AdmAppAlumniPref> GetByAdmCdeAlumniPrefId(System.Int32 _admCdeAlumniPrefId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeAlumniPrefId(null, _admCdeAlumniPrefId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ALUMNI_PREF_ADM_CDE_ALUMNI_PREF key.
		///		fkAdmAppAlumniPrefAdmCdeAlumniPref Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeAlumniPrefId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppAlumniPref objects.</returns>
		public TList<AdmAppAlumniPref> GetByAdmCdeAlumniPrefId(System.Int32 _admCdeAlumniPrefId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeAlumniPrefId(null, _admCdeAlumniPrefId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ALUMNI_PREF_ADM_CDE_ALUMNI_PREF key.
		///		FK_ADM_APP_ALUMNI_PREF_ADM_CDE_ALUMNI_PREF Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAlumniPrefId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppAlumniPref objects.</returns>
		public abstract TList<AdmAppAlumniPref> GetByAdmCdeAlumniPrefId(TransactionManager transactionManager, System.Int32 _admCdeAlumniPrefId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppAlumniPref Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppAlumniPrefKey key, int start, int pageLength)
		{
			return GetByAdmAppAlumniPrefId(transactionManager, key.AdmAppAlumniPrefId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_ALUMNI_PREF index.
		/// </summary>
		/// <param name="_admAppAlumniPrefId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppAlumniPref"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppAlumniPref GetByAdmAppAlumniPrefId(System.Decimal _admAppAlumniPrefId)
		{
			int count = -1;
			return GetByAdmAppAlumniPrefId(null,_admAppAlumniPrefId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_ALUMNI_PREF index.
		/// </summary>
		/// <param name="_admAppAlumniPrefId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppAlumniPref"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppAlumniPref GetByAdmAppAlumniPrefId(System.Decimal _admAppAlumniPrefId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppAlumniPrefId(null, _admAppAlumniPrefId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_ALUMNI_PREF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppAlumniPrefId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppAlumniPref"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppAlumniPref GetByAdmAppAlumniPrefId(TransactionManager transactionManager, System.Decimal _admAppAlumniPrefId)
		{
			int count = -1;
			return GetByAdmAppAlumniPrefId(transactionManager, _admAppAlumniPrefId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_ALUMNI_PREF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppAlumniPrefId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppAlumniPref"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppAlumniPref GetByAdmAppAlumniPrefId(TransactionManager transactionManager, System.Decimal _admAppAlumniPrefId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppAlumniPrefId(transactionManager, _admAppAlumniPrefId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_ALUMNI_PREF index.
		/// </summary>
		/// <param name="_admAppAlumniPrefId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppAlumniPref"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppAlumniPref GetByAdmAppAlumniPrefId(System.Decimal _admAppAlumniPrefId, int start, int pageLength, out int count)
		{
			return GetByAdmAppAlumniPrefId(null, _admAppAlumniPrefId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_ALUMNI_PREF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppAlumniPrefId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppAlumniPref"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppAlumniPref GetByAdmAppAlumniPrefId(TransactionManager transactionManager, System.Decimal _admAppAlumniPrefId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppAlumniPref&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppAlumniPref&gt;"/></returns>
		public static TList<AdmAppAlumniPref> Fill(IDataReader reader, TList<AdmAppAlumniPref> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppAlumniPref c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppAlumniPref")
					.Append("|").Append((System.Decimal)reader["ADM_APP_ALUMNI_PREF_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppAlumniPref>(
					key.ToString(), // EntityTrackingKey
					"AdmAppAlumniPref",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppAlumniPref();
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
					c.AdmAppAlumniPrefId = (System.Decimal)reader["ADM_APP_ALUMNI_PREF_ID"];
					c.OriginalAdmAppAlumniPrefId = c.AdmAppAlumniPrefId;
					c.AdmAppRegHistoryId = (System.Decimal)reader["ADM_APP_REG_HISTORY_ID"];
					c.AdmCdeAlumniPrefId = (System.Int32)reader["ADM_CDE_ALUMNI_PREF_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppAlumniPref"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppAlumniPref"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppAlumniPref entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppAlumniPrefId = (System.Decimal)reader[((int)AdmAppAlumniPrefColumn.AdmAppAlumniPrefId - 1)];
			entity.OriginalAdmAppAlumniPrefId = (System.Decimal)reader["ADM_APP_ALUMNI_PREF_ID"];
			entity.AdmAppRegHistoryId = (System.Decimal)reader[((int)AdmAppAlumniPrefColumn.AdmAppRegHistoryId - 1)];
			entity.AdmCdeAlumniPrefId = (System.Int32)reader[((int)AdmAppAlumniPrefColumn.AdmCdeAlumniPrefId - 1)];
			entity.Notes = (reader.IsDBNull(((int)AdmAppAlumniPrefColumn.Notes - 1)))?null:(System.String)reader[((int)AdmAppAlumniPrefColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppAlumniPref"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppAlumniPref"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppAlumniPref entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppAlumniPrefId = (System.Decimal)dataRow["ADM_APP_ALUMNI_PREF_ID"];
			entity.OriginalAdmAppAlumniPrefId = (System.Decimal)dataRow["ADM_APP_ALUMNI_PREF_ID"];
			entity.AdmAppRegHistoryId = (System.Decimal)dataRow["ADM_APP_REG_HISTORY_ID"];
			entity.AdmCdeAlumniPrefId = (System.Int32)dataRow["ADM_CDE_ALUMNI_PREF_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppAlumniPref"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppAlumniPref Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppAlumniPref entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppRegHistoryIdSource	
			if (CanDeepLoad(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepLoadType, innerList) 
				&& entity.AdmAppRegHistoryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmAppRegHistoryId;
				AdmAppRegHistory tmpEntity = EntityManager.LocateEntity<AdmAppRegHistory>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppRegHistory), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppRegHistoryIdSource = tmpEntity;
				else
					entity.AdmAppRegHistoryIdSource = DataRepository.AdmAppRegHistoryProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);		
				
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

			#region AdmCdeAlumniPrefIdSource	
			if (CanDeepLoad(entity, "AdmCdeAlumniPref|AdmCdeAlumniPrefIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeAlumniPrefIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmCdeAlumniPrefId;
				AdmCdeAlumniPref tmpEntity = EntityManager.LocateEntity<AdmCdeAlumniPref>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeAlumniPref), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeAlumniPrefIdSource = tmpEntity;
				else
					entity.AdmCdeAlumniPrefIdSource = DataRepository.AdmCdeAlumniPrefProvider.GetByAdmCdeAlumniPrefId(transactionManager, entity.AdmCdeAlumniPrefId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeAlumniPrefIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeAlumniPrefIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeAlumniPrefProvider.DeepLoad(transactionManager, entity.AdmCdeAlumniPrefIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeAlumniPrefIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppAlumniPref object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppAlumniPref instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppAlumniPref Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppAlumniPref entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region AdmCdeAlumniPrefIdSource
			if (CanDeepSave(entity, "AdmCdeAlumniPref|AdmCdeAlumniPrefIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeAlumniPrefIdSource != null)
			{
				DataRepository.AdmCdeAlumniPrefProvider.Save(transactionManager, entity.AdmCdeAlumniPrefIdSource);
				entity.AdmCdeAlumniPrefId = entity.AdmCdeAlumniPrefIdSource.AdmCdeAlumniPrefId;
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
	
	#region AdmAppAlumniPrefChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppAlumniPref</c>
	///</summary>
	public enum AdmAppAlumniPrefChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppRegHistory</c> at AdmAppRegHistoryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppRegHistory))]
		AdmAppRegHistory,
		
		///<summary>
		/// Composite Property for <c>AdmCdeAlumniPref</c> at AdmCdeAlumniPrefIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeAlumniPref))]
		AdmCdeAlumniPref,
	}
	
	#endregion AdmAppAlumniPrefChildEntityTypes
	
	#region AdmAppAlumniPrefFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppAlumniPrefColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppAlumniPref"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppAlumniPrefFilterBuilder : SqlFilterBuilder<AdmAppAlumniPrefColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppAlumniPrefFilterBuilder class.
		/// </summary>
		public AdmAppAlumniPrefFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppAlumniPrefFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppAlumniPrefFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppAlumniPrefFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppAlumniPrefFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppAlumniPrefFilterBuilder
	
	#region AdmAppAlumniPrefParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppAlumniPrefColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppAlumniPref"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppAlumniPrefParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppAlumniPrefColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppAlumniPrefParameterBuilder class.
		/// </summary>
		public AdmAppAlumniPrefParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppAlumniPrefParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppAlumniPrefParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppAlumniPrefParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppAlumniPrefParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppAlumniPrefParameterBuilder
	
	#region AdmAppAlumniPrefSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppAlumniPrefColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppAlumniPref"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppAlumniPrefSortBuilder : SqlSortBuilder<AdmAppAlumniPrefColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppAlumniPrefSqlSortBuilder class.
		/// </summary>
		public AdmAppAlumniPrefSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppAlumniPrefSortBuilder
	
} // end namespace
