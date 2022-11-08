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
	/// This class is the base class for any <see cref="AlmJobProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AlmJobProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AlmJob, UMIS_VER2.BusinessLyer.AlmJobKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AlmJobKey key)
		{
			return Delete(transactionManager, key.AlmJobId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_almJobId">XXXبيانات وظيفة خريج ADM_APP_WORK. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _almJobId)
		{
			return Delete(null, _almJobId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_almJobId">XXXبيانات وظيفة خريج ADM_APP_WORK. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _almJobId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ALM_JOB_ED_STUD key.
		///		FK_ALM_JOB_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AlmJob objects.</returns>
		public TList<AlmJob> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ALM_JOB_ED_STUD key.
		///		FK_ALM_JOB_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AlmJob objects.</returns>
		/// <remarks></remarks>
		public TList<AlmJob> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ALM_JOB_ED_STUD key.
		///		FK_ALM_JOB_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AlmJob objects.</returns>
		public TList<AlmJob> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ALM_JOB_ED_STUD key.
		///		fkAlmJobEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AlmJob objects.</returns>
		public TList<AlmJob> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ALM_JOB_ED_STUD key.
		///		fkAlmJobEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AlmJob objects.</returns>
		public TList<AlmJob> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ALM_JOB_ED_STUD key.
		///		FK_ALM_JOB_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AlmJob objects.</returns>
		public abstract TList<AlmJob> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ALM_JOB_GS_COUNTRY_NODE key.
		///		FK_ALM_JOB_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId">البلد- المحافظة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AlmJob objects.</returns>
		public TList<AlmJob> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ALM_JOB_GS_COUNTRY_NODE key.
		///		FK_ALM_JOB_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">البلد- المحافظة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AlmJob objects.</returns>
		/// <remarks></remarks>
		public TList<AlmJob> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ALM_JOB_GS_COUNTRY_NODE key.
		///		FK_ALM_JOB_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">البلد- المحافظة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AlmJob objects.</returns>
		public TList<AlmJob> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ALM_JOB_GS_COUNTRY_NODE key.
		///		fkAlmJobGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">البلد- المحافظة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AlmJob objects.</returns>
		public TList<AlmJob> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ALM_JOB_GS_COUNTRY_NODE key.
		///		fkAlmJobGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">البلد- المحافظة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AlmJob objects.</returns>
		public TList<AlmJob> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ALM_JOB_GS_COUNTRY_NODE key.
		///		FK_ALM_JOB_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">البلد- المحافظة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AlmJob objects.</returns>
		public abstract TList<AlmJob> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AlmJob Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AlmJobKey key, int start, int pageLength)
		{
			return GetByAlmJobId(transactionManager, key.AlmJobId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ALM_JOB index.
		/// </summary>
		/// <param name="_almJobId">XXXبيانات وظيفة خريج ADM_APP_WORK</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AlmJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AlmJob GetByAlmJobId(System.Decimal _almJobId)
		{
			int count = -1;
			return GetByAlmJobId(null,_almJobId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ALM_JOB index.
		/// </summary>
		/// <param name="_almJobId">XXXبيانات وظيفة خريج ADM_APP_WORK</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AlmJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AlmJob GetByAlmJobId(System.Decimal _almJobId, int start, int pageLength)
		{
			int count = -1;
			return GetByAlmJobId(null, _almJobId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ALM_JOB index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_almJobId">XXXبيانات وظيفة خريج ADM_APP_WORK</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AlmJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AlmJob GetByAlmJobId(TransactionManager transactionManager, System.Decimal _almJobId)
		{
			int count = -1;
			return GetByAlmJobId(transactionManager, _almJobId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ALM_JOB index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_almJobId">XXXبيانات وظيفة خريج ADM_APP_WORK</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AlmJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AlmJob GetByAlmJobId(TransactionManager transactionManager, System.Decimal _almJobId, int start, int pageLength)
		{
			int count = -1;
			return GetByAlmJobId(transactionManager, _almJobId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ALM_JOB index.
		/// </summary>
		/// <param name="_almJobId">XXXبيانات وظيفة خريج ADM_APP_WORK</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AlmJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AlmJob GetByAlmJobId(System.Decimal _almJobId, int start, int pageLength, out int count)
		{
			return GetByAlmJobId(null, _almJobId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ALM_JOB index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_almJobId">XXXبيانات وظيفة خريج ADM_APP_WORK</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AlmJob"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AlmJob GetByAlmJobId(TransactionManager transactionManager, System.Decimal _almJobId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AlmJob&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AlmJob&gt;"/></returns>
		public static TList<AlmJob> Fill(IDataReader reader, TList<AlmJob> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AlmJob c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AlmJob")
					.Append("|").Append((System.Decimal)reader["ALM_JOB_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AlmJob>(
					key.ToString(), // EntityTrackingKey
					"AlmJob",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AlmJob();
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
					c.AlmJobId = (System.Decimal)reader["ALM_JOB_ID"];
					c.OriginalAlmJobId = c.AlmJobId;
					c.FromDate = Convert.IsDBNull(reader["FROM_DATE"]) ? null : (System.DateTime?)reader["FROM_DATE"];
					c.ToDate = Convert.IsDBNull(reader["TO_DATE"]) ? null : (System.DateTime?)reader["TO_DATE"];
					c.JobTitle = Convert.IsDBNull(reader["JOB_TITLE"]) ? null : (System.String)reader["JOB_TITLE"];
					c.WorkPlace = Convert.IsDBNull(reader["WORK_PLACE"]) ? null : (System.String)reader["WORK_PLACE"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.PhoneNo = Convert.IsDBNull(reader["PHONE_NO"]) ? null : (System.Decimal?)reader["PHONE_NO"];
					c.MobNo = Convert.IsDBNull(reader["MOB_NO"]) ? null : (System.Decimal?)reader["MOB_NO"];
					c.EMail = Convert.IsDBNull(reader["E_MAIL"]) ? null : (System.String)reader["E_MAIL"];
					c.WebSite = Convert.IsDBNull(reader["WEB_SITE"]) ? null : (System.String)reader["WEB_SITE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AlmJob"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AlmJob"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AlmJob entity)
		{
			if (!reader.Read()) return;
			
			entity.AlmJobId = (System.Decimal)reader[((int)AlmJobColumn.AlmJobId - 1)];
			entity.OriginalAlmJobId = (System.Decimal)reader["ALM_JOB_ID"];
			entity.FromDate = (reader.IsDBNull(((int)AlmJobColumn.FromDate - 1)))?null:(System.DateTime?)reader[((int)AlmJobColumn.FromDate - 1)];
			entity.ToDate = (reader.IsDBNull(((int)AlmJobColumn.ToDate - 1)))?null:(System.DateTime?)reader[((int)AlmJobColumn.ToDate - 1)];
			entity.JobTitle = (reader.IsDBNull(((int)AlmJobColumn.JobTitle - 1)))?null:(System.String)reader[((int)AlmJobColumn.JobTitle - 1)];
			entity.WorkPlace = (reader.IsDBNull(((int)AlmJobColumn.WorkPlace - 1)))?null:(System.String)reader[((int)AlmJobColumn.WorkPlace - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)AlmJobColumn.EdStudId - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)AlmJobColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)AlmJobColumn.GsCountryNodeId - 1)];
			entity.PhoneNo = (reader.IsDBNull(((int)AlmJobColumn.PhoneNo - 1)))?null:(System.Decimal?)reader[((int)AlmJobColumn.PhoneNo - 1)];
			entity.MobNo = (reader.IsDBNull(((int)AlmJobColumn.MobNo - 1)))?null:(System.Decimal?)reader[((int)AlmJobColumn.MobNo - 1)];
			entity.EMail = (reader.IsDBNull(((int)AlmJobColumn.EMail - 1)))?null:(System.String)reader[((int)AlmJobColumn.EMail - 1)];
			entity.WebSite = (reader.IsDBNull(((int)AlmJobColumn.WebSite - 1)))?null:(System.String)reader[((int)AlmJobColumn.WebSite - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AlmJob"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AlmJob"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AlmJob entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AlmJobId = (System.Decimal)dataRow["ALM_JOB_ID"];
			entity.OriginalAlmJobId = (System.Decimal)dataRow["ALM_JOB_ID"];
			entity.FromDate = Convert.IsDBNull(dataRow["FROM_DATE"]) ? null : (System.DateTime?)dataRow["FROM_DATE"];
			entity.ToDate = Convert.IsDBNull(dataRow["TO_DATE"]) ? null : (System.DateTime?)dataRow["TO_DATE"];
			entity.JobTitle = Convert.IsDBNull(dataRow["JOB_TITLE"]) ? null : (System.String)dataRow["JOB_TITLE"];
			entity.WorkPlace = Convert.IsDBNull(dataRow["WORK_PLACE"]) ? null : (System.String)dataRow["WORK_PLACE"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.PhoneNo = Convert.IsDBNull(dataRow["PHONE_NO"]) ? null : (System.Decimal?)dataRow["PHONE_NO"];
			entity.MobNo = Convert.IsDBNull(dataRow["MOB_NO"]) ? null : (System.Decimal?)dataRow["MOB_NO"];
			entity.EMail = Convert.IsDBNull(dataRow["E_MAIL"]) ? null : (System.String)dataRow["E_MAIL"];
			entity.WebSite = Convert.IsDBNull(dataRow["WEB_SITE"]) ? null : (System.String)dataRow["WEB_SITE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AlmJob"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AlmJob Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AlmJob entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudId;
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudProvider.DeepLoad(transactionManager, entity.EdStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AlmJob object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AlmJob instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AlmJob Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AlmJob entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
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
	
	#region AlmJobChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AlmJob</c>
	///</summary>
	public enum AlmJobChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
	}
	
	#endregion AlmJobChildEntityTypes
	
	#region AlmJobFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AlmJobColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AlmJob"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AlmJobFilterBuilder : SqlFilterBuilder<AlmJobColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AlmJobFilterBuilder class.
		/// </summary>
		public AlmJobFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AlmJobFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AlmJobFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AlmJobFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AlmJobFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AlmJobFilterBuilder
	
	#region AlmJobParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AlmJobColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AlmJob"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AlmJobParameterBuilder : ParameterizedSqlFilterBuilder<AlmJobColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AlmJobParameterBuilder class.
		/// </summary>
		public AlmJobParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AlmJobParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AlmJobParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AlmJobParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AlmJobParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AlmJobParameterBuilder
	
	#region AlmJobSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AlmJobColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AlmJob"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AlmJobSortBuilder : SqlSortBuilder<AlmJobColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AlmJobSqlSortBuilder class.
		/// </summary>
		public AlmJobSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AlmJobSortBuilder
	
} // end namespace
