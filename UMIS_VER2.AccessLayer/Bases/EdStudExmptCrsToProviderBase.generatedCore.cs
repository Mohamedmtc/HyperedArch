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
	/// This class is the base class for any <see cref="EdStudExmptCrsToProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudExmptCrsToProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudExmptCrsTo, UMIS_VER2.BusinessLyer.EdStudExmptCrsToKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExmptCrsToKey key)
		{
			return Delete(transactionManager, key.EdStudExmptCrsToId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudExmptCrsToId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudExmptCrsToId)
		{
			return Delete(null, _edStudExmptCrsToId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptCrsToId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudExmptCrsToId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_TO_ED_COURSE key.
		///		FK_ED_STUD_EXMPT_CRS_TO_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsTo objects.</returns>
		public TList<EdStudExmptCrsTo> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_TO_ED_COURSE key.
		///		FK_ED_STUD_EXMPT_CRS_TO_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudExmptCrsTo> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_TO_ED_COURSE key.
		///		FK_ED_STUD_EXMPT_CRS_TO_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsTo objects.</returns>
		public TList<EdStudExmptCrsTo> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_TO_ED_COURSE key.
		///		fkEdStudExmptCrsToEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsTo objects.</returns>
		public TList<EdStudExmptCrsTo> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_TO_ED_COURSE key.
		///		fkEdStudExmptCrsToEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsTo objects.</returns>
		public TList<EdStudExmptCrsTo> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_TO_ED_COURSE key.
		///		FK_ED_STUD_EXMPT_CRS_TO_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsTo objects.</returns>
		public abstract TList<EdStudExmptCrsTo> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_TO_ED_STUD_EXMPT_REQ key.
		///		FK_ED_STUD_EXMPT_CRS_TO_ED_STUD_EXMPT_REQ Description: 
		/// </summary>
		/// <param name="_edStudExmptReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsTo objects.</returns>
		public TList<EdStudExmptCrsTo> GetByEdStudExmptReqId(System.Decimal _edStudExmptReqId)
		{
			int count = -1;
			return GetByEdStudExmptReqId(_edStudExmptReqId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_TO_ED_STUD_EXMPT_REQ key.
		///		FK_ED_STUD_EXMPT_CRS_TO_ED_STUD_EXMPT_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudExmptCrsTo> GetByEdStudExmptReqId(TransactionManager transactionManager, System.Decimal _edStudExmptReqId)
		{
			int count = -1;
			return GetByEdStudExmptReqId(transactionManager, _edStudExmptReqId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_TO_ED_STUD_EXMPT_REQ key.
		///		FK_ED_STUD_EXMPT_CRS_TO_ED_STUD_EXMPT_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsTo objects.</returns>
		public TList<EdStudExmptCrsTo> GetByEdStudExmptReqId(TransactionManager transactionManager, System.Decimal _edStudExmptReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExmptReqId(transactionManager, _edStudExmptReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_TO_ED_STUD_EXMPT_REQ key.
		///		fkEdStudExmptCrsToEdStudExmptReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudExmptReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsTo objects.</returns>
		public TList<EdStudExmptCrsTo> GetByEdStudExmptReqId(System.Decimal _edStudExmptReqId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudExmptReqId(null, _edStudExmptReqId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_TO_ED_STUD_EXMPT_REQ key.
		///		fkEdStudExmptCrsToEdStudExmptReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudExmptReqId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsTo objects.</returns>
		public TList<EdStudExmptCrsTo> GetByEdStudExmptReqId(System.Decimal _edStudExmptReqId, int start, int pageLength,out int count)
		{
			return GetByEdStudExmptReqId(null, _edStudExmptReqId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_TO_ED_STUD_EXMPT_REQ key.
		///		FK_ED_STUD_EXMPT_CRS_TO_ED_STUD_EXMPT_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsTo objects.</returns>
		public abstract TList<EdStudExmptCrsTo> GetByEdStudExmptReqId(TransactionManager transactionManager, System.Decimal _edStudExmptReqId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudExmptCrsTo Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExmptCrsToKey key, int start, int pageLength)
		{
			return GetByEdStudExmptCrsToId(transactionManager, key.EdStudExmptCrsToId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_EXMPT_CRS_TO index.
		/// </summary>
		/// <param name="_edStudExmptCrsToId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptCrsTo GetByEdStudExmptCrsToId(System.Decimal _edStudExmptCrsToId)
		{
			int count = -1;
			return GetByEdStudExmptCrsToId(null,_edStudExmptCrsToId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_CRS_TO index.
		/// </summary>
		/// <param name="_edStudExmptCrsToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptCrsTo GetByEdStudExmptCrsToId(System.Decimal _edStudExmptCrsToId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExmptCrsToId(null, _edStudExmptCrsToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_CRS_TO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptCrsToId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptCrsTo GetByEdStudExmptCrsToId(TransactionManager transactionManager, System.Decimal _edStudExmptCrsToId)
		{
			int count = -1;
			return GetByEdStudExmptCrsToId(transactionManager, _edStudExmptCrsToId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_CRS_TO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptCrsToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptCrsTo GetByEdStudExmptCrsToId(TransactionManager transactionManager, System.Decimal _edStudExmptCrsToId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExmptCrsToId(transactionManager, _edStudExmptCrsToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_CRS_TO index.
		/// </summary>
		/// <param name="_edStudExmptCrsToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptCrsTo GetByEdStudExmptCrsToId(System.Decimal _edStudExmptCrsToId, int start, int pageLength, out int count)
		{
			return GetByEdStudExmptCrsToId(null, _edStudExmptCrsToId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_CRS_TO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptCrsToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsTo"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudExmptCrsTo GetByEdStudExmptCrsToId(TransactionManager transactionManager, System.Decimal _edStudExmptCrsToId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudExmptCrsTo&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudExmptCrsTo&gt;"/></returns>
		public static TList<EdStudExmptCrsTo> Fill(IDataReader reader, TList<EdStudExmptCrsTo> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudExmptCrsTo c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudExmptCrsTo")
					.Append("|").Append((System.Decimal)reader["ED_STUD_EXMPT_CRS_TO_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudExmptCrsTo>(
					key.ToString(), // EntityTrackingKey
					"EdStudExmptCrsTo",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudExmptCrsTo();
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
					c.EdStudExmptCrsToId = (System.Decimal)reader["ED_STUD_EXMPT_CRS_TO_ID"];
					c.OriginalEdStudExmptCrsToId = c.EdStudExmptCrsToId;
					c.EdStudExmptReqId = (System.Decimal)reader["ED_STUD_EXMPT_REQ_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsTo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsTo"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudExmptCrsTo entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudExmptCrsToId = (System.Decimal)reader[((int)EdStudExmptCrsToColumn.EdStudExmptCrsToId - 1)];
			entity.OriginalEdStudExmptCrsToId = (System.Decimal)reader["ED_STUD_EXMPT_CRS_TO_ID"];
			entity.EdStudExmptReqId = (System.Decimal)reader[((int)EdStudExmptCrsToColumn.EdStudExmptReqId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)EdStudExmptCrsToColumn.EdCourseId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsTo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsTo"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudExmptCrsTo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudExmptCrsToId = (System.Decimal)dataRow["ED_STUD_EXMPT_CRS_TO_ID"];
			entity.OriginalEdStudExmptCrsToId = (System.Decimal)dataRow["ED_STUD_EXMPT_CRS_TO_ID"];
			entity.EdStudExmptReqId = (System.Decimal)dataRow["ED_STUD_EXMPT_REQ_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsTo"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudExmptCrsTo Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExmptCrsTo entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseIdSource

			#region EdStudExmptReqIdSource	
			if (CanDeepLoad(entity, "EdStudExmptReq|EdStudExmptReqIdSource", deepLoadType, innerList) 
				&& entity.EdStudExmptReqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudExmptReqId;
				EdStudExmptReq tmpEntity = EntityManager.LocateEntity<EdStudExmptReq>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudExmptReq), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudExmptReqIdSource = tmpEntity;
				else
					entity.EdStudExmptReqIdSource = DataRepository.EdStudExmptReqProvider.GetByEdStudExmptReqId(transactionManager, entity.EdStudExmptReqId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExmptReqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudExmptReqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudExmptReqProvider.DeepLoad(transactionManager, entity.EdStudExmptReqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudExmptReqIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudExmptCrsTo object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudExmptCrsTo instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudExmptCrsTo Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExmptCrsTo entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region EdStudExmptReqIdSource
			if (CanDeepSave(entity, "EdStudExmptReq|EdStudExmptReqIdSource", deepSaveType, innerList) 
				&& entity.EdStudExmptReqIdSource != null)
			{
				DataRepository.EdStudExmptReqProvider.Save(transactionManager, entity.EdStudExmptReqIdSource);
				entity.EdStudExmptReqId = entity.EdStudExmptReqIdSource.EdStudExmptReqId;
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
	
	#region EdStudExmptCrsToChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudExmptCrsTo</c>
	///</summary>
	public enum EdStudExmptCrsToChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EdStudExmptReq</c> at EdStudExmptReqIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudExmptReq))]
		EdStudExmptReq,
	}
	
	#endregion EdStudExmptCrsToChildEntityTypes
	
	#region EdStudExmptCrsToFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudExmptCrsToColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudExmptCrsTo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudExmptCrsToFilterBuilder : SqlFilterBuilder<EdStudExmptCrsToColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudExmptCrsToFilterBuilder class.
		/// </summary>
		public EdStudExmptCrsToFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudExmptCrsToFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudExmptCrsToFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudExmptCrsToFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudExmptCrsToFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudExmptCrsToFilterBuilder
	
	#region EdStudExmptCrsToParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudExmptCrsToColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudExmptCrsTo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudExmptCrsToParameterBuilder : ParameterizedSqlFilterBuilder<EdStudExmptCrsToColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudExmptCrsToParameterBuilder class.
		/// </summary>
		public EdStudExmptCrsToParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudExmptCrsToParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudExmptCrsToParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudExmptCrsToParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudExmptCrsToParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudExmptCrsToParameterBuilder
	
	#region EdStudExmptCrsToSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudExmptCrsToColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudExmptCrsTo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudExmptCrsToSortBuilder : SqlSortBuilder<EdStudExmptCrsToColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudExmptCrsToSqlSortBuilder class.
		/// </summary>
		public EdStudExmptCrsToSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudExmptCrsToSortBuilder
	
} // end namespace
