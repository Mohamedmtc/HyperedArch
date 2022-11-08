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
	/// This class is the base class for any <see cref="EdCdeExecuseRsnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeExecuseRsnProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCdeExecuseRsn, UMIS_VER2.BusinessLyer.EdCdeExecuseRsnKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeExecuseRsnKey key)
		{
			return Delete(transactionManager, key.EdCdeExecuseRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCdeExecuseRsnId">سبب غياب عن حضور جدول اكاديمى- تدريب فى حالة بعذر فقط. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _edCdeExecuseRsnId)
		{
			return Delete(null, _edCdeExecuseRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExecuseRsnId">سبب غياب عن حضور جدول اكاديمى- تدريب فى حالة بعذر فقط. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _edCdeExecuseRsnId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCdeExecuseRsn Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeExecuseRsnKey key, int start, int pageLength)
		{
			return GetByEdCdeExecuseRsnId(transactionManager, key.EdCdeExecuseRsnId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CDE_EXECUSE_RSN index.
		/// </summary>
		/// <param name="_edCdeExecuseRsnId">سبب غياب عن حضور جدول اكاديمى- تدريب فى حالة بعذر فقط</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExecuseRsn GetByEdCdeExecuseRsnId(System.Int32 _edCdeExecuseRsnId)
		{
			int count = -1;
			return GetByEdCdeExecuseRsnId(null,_edCdeExecuseRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EXECUSE_RSN index.
		/// </summary>
		/// <param name="_edCdeExecuseRsnId">سبب غياب عن حضور جدول اكاديمى- تدريب فى حالة بعذر فقط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExecuseRsn GetByEdCdeExecuseRsnId(System.Int32 _edCdeExecuseRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExecuseRsnId(null, _edCdeExecuseRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EXECUSE_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExecuseRsnId">سبب غياب عن حضور جدول اكاديمى- تدريب فى حالة بعذر فقط</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExecuseRsn GetByEdCdeExecuseRsnId(TransactionManager transactionManager, System.Int32 _edCdeExecuseRsnId)
		{
			int count = -1;
			return GetByEdCdeExecuseRsnId(transactionManager, _edCdeExecuseRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EXECUSE_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExecuseRsnId">سبب غياب عن حضور جدول اكاديمى- تدريب فى حالة بعذر فقط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExecuseRsn GetByEdCdeExecuseRsnId(TransactionManager transactionManager, System.Int32 _edCdeExecuseRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExecuseRsnId(transactionManager, _edCdeExecuseRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EXECUSE_RSN index.
		/// </summary>
		/// <param name="_edCdeExecuseRsnId">سبب غياب عن حضور جدول اكاديمى- تدريب فى حالة بعذر فقط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExecuseRsn GetByEdCdeExecuseRsnId(System.Int32 _edCdeExecuseRsnId, int start, int pageLength, out int count)
		{
			return GetByEdCdeExecuseRsnId(null, _edCdeExecuseRsnId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EXECUSE_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExecuseRsnId">سبب غياب عن حضور جدول اكاديمى- تدريب فى حالة بعذر فقط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeExecuseRsn GetByEdCdeExecuseRsnId(TransactionManager transactionManager, System.Int32 _edCdeExecuseRsnId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_CDE_EXECUSE_RSN_AR index.
		/// </summary>
		/// <param name="_excRsnAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExecuseRsn GetByExcRsnAr(System.String _excRsnAr)
		{
			int count = -1;
			return GetByExcRsnAr(null,_excRsnAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CDE_EXECUSE_RSN_AR index.
		/// </summary>
		/// <param name="_excRsnAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExecuseRsn GetByExcRsnAr(System.String _excRsnAr, int start, int pageLength)
		{
			int count = -1;
			return GetByExcRsnAr(null, _excRsnAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CDE_EXECUSE_RSN_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_excRsnAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExecuseRsn GetByExcRsnAr(TransactionManager transactionManager, System.String _excRsnAr)
		{
			int count = -1;
			return GetByExcRsnAr(transactionManager, _excRsnAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CDE_EXECUSE_RSN_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_excRsnAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExecuseRsn GetByExcRsnAr(TransactionManager transactionManager, System.String _excRsnAr, int start, int pageLength)
		{
			int count = -1;
			return GetByExcRsnAr(transactionManager, _excRsnAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CDE_EXECUSE_RSN_AR index.
		/// </summary>
		/// <param name="_excRsnAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExecuseRsn GetByExcRsnAr(System.String _excRsnAr, int start, int pageLength, out int count)
		{
			return GetByExcRsnAr(null, _excRsnAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CDE_EXECUSE_RSN_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_excRsnAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeExecuseRsn GetByExcRsnAr(TransactionManager transactionManager, System.String _excRsnAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_CDE_EXECUSE_RSN_EN index.
		/// </summary>
		/// <param name="_excRsnEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExecuseRsn GetByExcRsnEn(System.String _excRsnEn)
		{
			int count = -1;
			return GetByExcRsnEn(null,_excRsnEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CDE_EXECUSE_RSN_EN index.
		/// </summary>
		/// <param name="_excRsnEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExecuseRsn GetByExcRsnEn(System.String _excRsnEn, int start, int pageLength)
		{
			int count = -1;
			return GetByExcRsnEn(null, _excRsnEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CDE_EXECUSE_RSN_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_excRsnEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExecuseRsn GetByExcRsnEn(TransactionManager transactionManager, System.String _excRsnEn)
		{
			int count = -1;
			return GetByExcRsnEn(transactionManager, _excRsnEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CDE_EXECUSE_RSN_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_excRsnEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExecuseRsn GetByExcRsnEn(TransactionManager transactionManager, System.String _excRsnEn, int start, int pageLength)
		{
			int count = -1;
			return GetByExcRsnEn(transactionManager, _excRsnEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CDE_EXECUSE_RSN_EN index.
		/// </summary>
		/// <param name="_excRsnEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExecuseRsn GetByExcRsnEn(System.String _excRsnEn, int start, int pageLength, out int count)
		{
			return GetByExcRsnEn(null, _excRsnEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CDE_EXECUSE_RSN_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_excRsnEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeExecuseRsn GetByExcRsnEn(TransactionManager transactionManager, System.String _excRsnEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCdeExecuseRsn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCdeExecuseRsn&gt;"/></returns>
		public static TList<EdCdeExecuseRsn> Fill(IDataReader reader, TList<EdCdeExecuseRsn> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCdeExecuseRsn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCdeExecuseRsn")
					.Append("|").Append((System.Int32)reader["ED_CDE_EXECUSE_RSN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCdeExecuseRsn>(
					key.ToString(), // EntityTrackingKey
					"EdCdeExecuseRsn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCdeExecuseRsn();
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
					c.EdCdeExecuseRsnId = (System.Int32)reader["ED_CDE_EXECUSE_RSN_ID"];
					c.OriginalEdCdeExecuseRsnId = c.EdCdeExecuseRsnId;
					c.ExcRsnAr = (System.String)reader["EXC_RSN_AR"];
					c.ExcRsnEn = (System.String)reader["EXC_RSN_EN"];
					c.IsActive = Convert.IsDBNull(reader["IS_ACTIVE"]) ? null : (System.Boolean?)reader["IS_ACTIVE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCdeExecuseRsn entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCdeExecuseRsnId = (System.Int32)reader[((int)EdCdeExecuseRsnColumn.EdCdeExecuseRsnId - 1)];
			entity.OriginalEdCdeExecuseRsnId = (System.Int32)reader["ED_CDE_EXECUSE_RSN_ID"];
			entity.ExcRsnAr = (System.String)reader[((int)EdCdeExecuseRsnColumn.ExcRsnAr - 1)];
			entity.ExcRsnEn = (System.String)reader[((int)EdCdeExecuseRsnColumn.ExcRsnEn - 1)];
			entity.IsActive = (reader.IsDBNull(((int)EdCdeExecuseRsnColumn.IsActive - 1)))?null:(System.Boolean?)reader[((int)EdCdeExecuseRsnColumn.IsActive - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCdeExecuseRsn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCdeExecuseRsnId = (System.Int32)dataRow["ED_CDE_EXECUSE_RSN_ID"];
			entity.OriginalEdCdeExecuseRsnId = (System.Int32)dataRow["ED_CDE_EXECUSE_RSN_ID"];
			entity.ExcRsnAr = (System.String)dataRow["EXC_RSN_AR"];
			entity.ExcRsnEn = (System.String)dataRow["EXC_RSN_EN"];
			entity.IsActive = Convert.IsDBNull(dataRow["IS_ACTIVE"]) ? null : (System.Boolean?)dataRow["IS_ACTIVE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeExecuseRsn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeExecuseRsn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeExecuseRsn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCdeExecuseRsnId methods when available
			
			#region EdExamStudAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdExamStudAbsence>|EdExamStudAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamStudAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdExamStudAbsenceCollection = DataRepository.EdExamStudAbsenceProvider.GetByEdCdeExecuseRsnId(transactionManager, entity.EdCdeExecuseRsnId);

				if (deep && entity.EdExamStudAbsenceCollection.Count > 0)
				{
					deepHandles.Add("EdExamStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdExamStudAbsence>) DataRepository.EdExamStudAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.EdExamStudAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExecuseReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExecuseReq>|EdStudExecuseReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExecuseReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExecuseReqCollection = DataRepository.EdStudExecuseReqProvider.GetByEdCdeExecuseRsnId(transactionManager, entity.EdCdeExecuseRsnId);

				if (deep && entity.EdStudExecuseReqCollection.Count > 0)
				{
					deepHandles.Add("EdStudExecuseReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExecuseReq>) DataRepository.EdStudExecuseReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExecuseReqCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCdeExecuseRsn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCdeExecuseRsn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeExecuseRsn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeExecuseRsn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdExamStudAbsence>
				if (CanDeepSave(entity.EdExamStudAbsenceCollection, "List<EdExamStudAbsence>|EdExamStudAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdExamStudAbsence child in entity.EdExamStudAbsenceCollection)
					{
						if(child.EdCdeExecuseRsnIdSource != null)
						{
							child.EdCdeExecuseRsnId = child.EdCdeExecuseRsnIdSource.EdCdeExecuseRsnId;
						}
						else
						{
							child.EdCdeExecuseRsnId = entity.EdCdeExecuseRsnId;
						}

					}

					if (entity.EdExamStudAbsenceCollection.Count > 0 || entity.EdExamStudAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdExamStudAbsenceProvider.Save(transactionManager, entity.EdExamStudAbsenceCollection);
						
						deepHandles.Add("EdExamStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdExamStudAbsence >) DataRepository.EdExamStudAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.EdExamStudAbsenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudExecuseReq>
				if (CanDeepSave(entity.EdStudExecuseReqCollection, "List<EdStudExecuseReq>|EdStudExecuseReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExecuseReq child in entity.EdStudExecuseReqCollection)
					{
						if(child.EdCdeExecuseRsnIdSource != null)
						{
							child.EdCdeExecuseRsnId = child.EdCdeExecuseRsnIdSource.EdCdeExecuseRsnId;
						}
						else
						{
							child.EdCdeExecuseRsnId = entity.EdCdeExecuseRsnId;
						}

					}

					if (entity.EdStudExecuseReqCollection.Count > 0 || entity.EdStudExecuseReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExecuseReqProvider.Save(transactionManager, entity.EdStudExecuseReqCollection);
						
						deepHandles.Add("EdStudExecuseReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExecuseReq >) DataRepository.EdStudExecuseReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExecuseReqCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCdeExecuseRsnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCdeExecuseRsn</c>
	///</summary>
	public enum EdCdeExecuseRsnChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCdeExecuseRsn</c> as OneToMany for EdExamStudAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdExamStudAbsence>))]
		EdExamStudAbsenceCollection,
		///<summary>
		/// Collection of <c>EdCdeExecuseRsn</c> as OneToMany for EdStudExecuseReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExecuseReq>))]
		EdStudExecuseReqCollection,
	}
	
	#endregion EdCdeExecuseRsnChildEntityTypes
	
	#region EdCdeExecuseRsnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCdeExecuseRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeExecuseRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeExecuseRsnFilterBuilder : SqlFilterBuilder<EdCdeExecuseRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeExecuseRsnFilterBuilder class.
		/// </summary>
		public EdCdeExecuseRsnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeExecuseRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeExecuseRsnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeExecuseRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeExecuseRsnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeExecuseRsnFilterBuilder
	
	#region EdCdeExecuseRsnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCdeExecuseRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeExecuseRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeExecuseRsnParameterBuilder : ParameterizedSqlFilterBuilder<EdCdeExecuseRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeExecuseRsnParameterBuilder class.
		/// </summary>
		public EdCdeExecuseRsnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeExecuseRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeExecuseRsnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeExecuseRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeExecuseRsnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeExecuseRsnParameterBuilder
	
	#region EdCdeExecuseRsnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCdeExecuseRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeExecuseRsn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCdeExecuseRsnSortBuilder : SqlSortBuilder<EdCdeExecuseRsnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeExecuseRsnSqlSortBuilder class.
		/// </summary>
		public EdCdeExecuseRsnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCdeExecuseRsnSortBuilder
	
} // end namespace
