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
	/// This class is the base class for any <see cref="TrnsCdeDrvrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TrnsCdeDrvrProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.TrnsCdeDrvr, UMIS_VER2.BusinessLyer.TrnsCdeDrvrKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsCdeDrvrKey key)
		{
			return Delete(transactionManager, key.TrnsCdeDrvrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_trnsCdeDrvrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _trnsCdeDrvrId)
		{
			return Delete(null, _trnsCdeDrvrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeDrvrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _trnsCdeDrvrId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_CDE_DRVR_GS_COUNTRY_NODE key.
		///		FK_TRNS_CDE_DRVR_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsCdeDrvr objects.</returns>
		public TList<TrnsCdeDrvr> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_CDE_DRVR_GS_COUNTRY_NODE key.
		///		FK_TRNS_CDE_DRVR_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsCdeDrvr objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsCdeDrvr> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_CDE_DRVR_GS_COUNTRY_NODE key.
		///		FK_TRNS_CDE_DRVR_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsCdeDrvr objects.</returns>
		public TList<TrnsCdeDrvr> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_CDE_DRVR_GS_COUNTRY_NODE key.
		///		fkTrnsCdeDrvrGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsCdeDrvr objects.</returns>
		public TList<TrnsCdeDrvr> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_CDE_DRVR_GS_COUNTRY_NODE key.
		///		fkTrnsCdeDrvrGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsCdeDrvr objects.</returns>
		public TList<TrnsCdeDrvr> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_CDE_DRVR_GS_COUNTRY_NODE key.
		///		FK_TRNS_CDE_DRVR_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsCdeDrvr objects.</returns>
		public abstract TList<TrnsCdeDrvr> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.TrnsCdeDrvr Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsCdeDrvrKey key, int start, int pageLength)
		{
			return GetByTrnsCdeDrvrId(transactionManager, key.TrnsCdeDrvrId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_TRNS_CDE_DRVR index.
		/// </summary>
		/// <param name="_trnsCdeDrvrId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeDrvr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeDrvr GetByTrnsCdeDrvrId(System.Decimal _trnsCdeDrvrId)
		{
			int count = -1;
			return GetByTrnsCdeDrvrId(null,_trnsCdeDrvrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_CDE_DRVR index.
		/// </summary>
		/// <param name="_trnsCdeDrvrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeDrvr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeDrvr GetByTrnsCdeDrvrId(System.Decimal _trnsCdeDrvrId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsCdeDrvrId(null, _trnsCdeDrvrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_CDE_DRVR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeDrvrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeDrvr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeDrvr GetByTrnsCdeDrvrId(TransactionManager transactionManager, System.Decimal _trnsCdeDrvrId)
		{
			int count = -1;
			return GetByTrnsCdeDrvrId(transactionManager, _trnsCdeDrvrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_CDE_DRVR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeDrvrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeDrvr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeDrvr GetByTrnsCdeDrvrId(TransactionManager transactionManager, System.Decimal _trnsCdeDrvrId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsCdeDrvrId(transactionManager, _trnsCdeDrvrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_CDE_DRVR index.
		/// </summary>
		/// <param name="_trnsCdeDrvrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeDrvr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeDrvr GetByTrnsCdeDrvrId(System.Decimal _trnsCdeDrvrId, int start, int pageLength, out int count)
		{
			return GetByTrnsCdeDrvrId(null, _trnsCdeDrvrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_CDE_DRVR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeDrvrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeDrvr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.TrnsCdeDrvr GetByTrnsCdeDrvrId(TransactionManager transactionManager, System.Decimal _trnsCdeDrvrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_TRNS_CDE_DRVR index.
		/// </summary>
		/// <param name="_nationalNum"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeDrvr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeDrvr GetByNationalNum(System.String _nationalNum)
		{
			int count = -1;
			return GetByNationalNum(null,_nationalNum, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_DRVR index.
		/// </summary>
		/// <param name="_nationalNum"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeDrvr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeDrvr GetByNationalNum(System.String _nationalNum, int start, int pageLength)
		{
			int count = -1;
			return GetByNationalNum(null, _nationalNum, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_DRVR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nationalNum"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeDrvr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeDrvr GetByNationalNum(TransactionManager transactionManager, System.String _nationalNum)
		{
			int count = -1;
			return GetByNationalNum(transactionManager, _nationalNum, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_DRVR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nationalNum"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeDrvr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeDrvr GetByNationalNum(TransactionManager transactionManager, System.String _nationalNum, int start, int pageLength)
		{
			int count = -1;
			return GetByNationalNum(transactionManager, _nationalNum, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_DRVR index.
		/// </summary>
		/// <param name="_nationalNum"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeDrvr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeDrvr GetByNationalNum(System.String _nationalNum, int start, int pageLength, out int count)
		{
			return GetByNationalNum(null, _nationalNum, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_DRVR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nationalNum"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeDrvr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.TrnsCdeDrvr GetByNationalNum(TransactionManager transactionManager, System.String _nationalNum, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TrnsCdeDrvr&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TrnsCdeDrvr&gt;"/></returns>
		public static TList<TrnsCdeDrvr> Fill(IDataReader reader, TList<TrnsCdeDrvr> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.TrnsCdeDrvr c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TrnsCdeDrvr")
					.Append("|").Append((System.Decimal)reader["TRNS_CDE_DRVR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<TrnsCdeDrvr>(
					key.ToString(), // EntityTrackingKey
					"TrnsCdeDrvr",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.TrnsCdeDrvr();
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
					c.TrnsCdeDrvrId = (System.Decimal)reader["TRNS_CDE_DRVR_ID"];
					c.OriginalTrnsCdeDrvrId = c.TrnsCdeDrvrId;
					c.FullNameAr = (System.String)reader["FULL_NAME_AR"];
					c.FullNameEn = (System.String)reader["FULL_NAME_EN"];
					c.BirthDate = Convert.IsDBNull(reader["BIRTH_DATE"]) ? null : (System.DateTime?)reader["BIRTH_DATE"];
					c.NationalNum = Convert.IsDBNull(reader["NATIONAL_NUM"]) ? null : (System.String)reader["NATIONAL_NUM"];
					c.IsActive = (System.Decimal)reader["IS_ACTIVE"];
					c.PhoneNo = Convert.IsDBNull(reader["PHONE_NO"]) ? null : (System.String)reader["PHONE_NO"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeDrvr"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsCdeDrvr"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.TrnsCdeDrvr entity)
		{
			if (!reader.Read()) return;
			
			entity.TrnsCdeDrvrId = (System.Decimal)reader[((int)TrnsCdeDrvrColumn.TrnsCdeDrvrId - 1)];
			entity.OriginalTrnsCdeDrvrId = (System.Decimal)reader["TRNS_CDE_DRVR_ID"];
			entity.FullNameAr = (System.String)reader[((int)TrnsCdeDrvrColumn.FullNameAr - 1)];
			entity.FullNameEn = (System.String)reader[((int)TrnsCdeDrvrColumn.FullNameEn - 1)];
			entity.BirthDate = (reader.IsDBNull(((int)TrnsCdeDrvrColumn.BirthDate - 1)))?null:(System.DateTime?)reader[((int)TrnsCdeDrvrColumn.BirthDate - 1)];
			entity.NationalNum = (reader.IsDBNull(((int)TrnsCdeDrvrColumn.NationalNum - 1)))?null:(System.String)reader[((int)TrnsCdeDrvrColumn.NationalNum - 1)];
			entity.IsActive = (System.Decimal)reader[((int)TrnsCdeDrvrColumn.IsActive - 1)];
			entity.PhoneNo = (reader.IsDBNull(((int)TrnsCdeDrvrColumn.PhoneNo - 1)))?null:(System.String)reader[((int)TrnsCdeDrvrColumn.PhoneNo - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)TrnsCdeDrvrColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)TrnsCdeDrvrColumn.GsCountryNodeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeDrvr"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsCdeDrvr"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.TrnsCdeDrvr entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.TrnsCdeDrvrId = (System.Decimal)dataRow["TRNS_CDE_DRVR_ID"];
			entity.OriginalTrnsCdeDrvrId = (System.Decimal)dataRow["TRNS_CDE_DRVR_ID"];
			entity.FullNameAr = (System.String)dataRow["FULL_NAME_AR"];
			entity.FullNameEn = (System.String)dataRow["FULL_NAME_EN"];
			entity.BirthDate = Convert.IsDBNull(dataRow["BIRTH_DATE"]) ? null : (System.DateTime?)dataRow["BIRTH_DATE"];
			entity.NationalNum = Convert.IsDBNull(dataRow["NATIONAL_NUM"]) ? null : (System.String)dataRow["NATIONAL_NUM"];
			entity.IsActive = (System.Decimal)dataRow["IS_ACTIVE"];
			entity.PhoneNo = Convert.IsDBNull(dataRow["PHONE_NO"]) ? null : (System.String)dataRow["PHONE_NO"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsCdeDrvr"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.TrnsCdeDrvr Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsCdeDrvr entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCountryNodeIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|GsCountryNodeIdSource", deepLoadType, innerList) 
				&& entity.GsCountryNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCountryNodeId ?? 0.0m);
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCountryNodeIdSource = tmpEntity;
				else
					entity.GsCountryNodeIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, (entity.GsCountryNodeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCountryNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCountryNodeProvider.DeepLoad(transactionManager, entity.GsCountryNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCountryNodeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByTrnsCdeDrvrId methods when available
			
			#region TrnsLineCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsLine>|TrnsLineCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsLineCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsLineCollection = DataRepository.TrnsLineProvider.GetByTrnsCdeDrvrId(transactionManager, entity.TrnsCdeDrvrId);

				if (deep && entity.TrnsLineCollection.Count > 0)
				{
					deepHandles.Add("TrnsLineCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsLine>) DataRepository.TrnsLineProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsLineCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.TrnsCdeDrvr object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.TrnsCdeDrvr instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.TrnsCdeDrvr Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsCdeDrvr entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCountryNodeIdSource
			if (CanDeepSave(entity, "GsCountryNode|GsCountryNodeIdSource", deepSaveType, innerList) 
				&& entity.GsCountryNodeIdSource != null)
			{
				DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryNodeIdSource);
				entity.GsCountryNodeId = entity.GsCountryNodeIdSource.GsCountryNodeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<TrnsLine>
				if (CanDeepSave(entity.TrnsLineCollection, "List<TrnsLine>|TrnsLineCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsLine child in entity.TrnsLineCollection)
					{
						if(child.TrnsCdeDrvrIdSource != null)
						{
							child.TrnsCdeDrvrId = child.TrnsCdeDrvrIdSource.TrnsCdeDrvrId;
						}
						else
						{
							child.TrnsCdeDrvrId = entity.TrnsCdeDrvrId;
						}

					}

					if (entity.TrnsLineCollection.Count > 0 || entity.TrnsLineCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsLineProvider.Save(transactionManager, entity.TrnsLineCollection);
						
						deepHandles.Add("TrnsLineCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsLine >) DataRepository.TrnsLineProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsLineCollection, deepSaveType, childTypes, innerList }
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
	
	#region TrnsCdeDrvrChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.TrnsCdeDrvr</c>
	///</summary>
	public enum TrnsCdeDrvrChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		///<summary>
		/// Collection of <c>TrnsCdeDrvr</c> as OneToMany for TrnsLineCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsLine>))]
		TrnsLineCollection,
	}
	
	#endregion TrnsCdeDrvrChildEntityTypes
	
	#region TrnsCdeDrvrFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TrnsCdeDrvrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsCdeDrvr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrnsCdeDrvrFilterBuilder : SqlFilterBuilder<TrnsCdeDrvrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsCdeDrvrFilterBuilder class.
		/// </summary>
		public TrnsCdeDrvrFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrnsCdeDrvrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrnsCdeDrvrFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrnsCdeDrvrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrnsCdeDrvrFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrnsCdeDrvrFilterBuilder
	
	#region TrnsCdeDrvrParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TrnsCdeDrvrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsCdeDrvr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrnsCdeDrvrParameterBuilder : ParameterizedSqlFilterBuilder<TrnsCdeDrvrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsCdeDrvrParameterBuilder class.
		/// </summary>
		public TrnsCdeDrvrParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrnsCdeDrvrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrnsCdeDrvrParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrnsCdeDrvrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrnsCdeDrvrParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrnsCdeDrvrParameterBuilder
	
	#region TrnsCdeDrvrSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TrnsCdeDrvrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsCdeDrvr"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TrnsCdeDrvrSortBuilder : SqlSortBuilder<TrnsCdeDrvrColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsCdeDrvrSqlSortBuilder class.
		/// </summary>
		public TrnsCdeDrvrSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TrnsCdeDrvrSortBuilder
	
} // end namespace
