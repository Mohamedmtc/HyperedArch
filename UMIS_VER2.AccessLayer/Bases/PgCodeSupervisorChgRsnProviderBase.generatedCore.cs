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
	/// This class is the base class for any <see cref="PgCodeSupervisorChgRsnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgCodeSupervisorChgRsnProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn, UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsnKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsnKey key)
		{
			return Delete(transactionManager, key.PgCodeSupervisorChgRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgCodeSupervisorChgRsnId">مسلسل سبب تعديل الاشراف. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _pgCodeSupervisorChgRsnId)
		{
			return Delete(null, _pgCodeSupervisorChgRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeSupervisorChgRsnId">مسلسل سبب تعديل الاشراف. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _pgCodeSupervisorChgRsnId);		
		
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
		public override UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsnKey key, int start, int pageLength)
		{
			return GetByPgCodeSupervisorChgRsnId(transactionManager, key.PgCodeSupervisorChgRsnId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_CODE_SUPERVISOR_CHG_RSN index.
		/// </summary>
		/// <param name="_pgCodeSupervisorChgRsnId">مسلسل سبب تعديل الاشراف</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn GetByPgCodeSupervisorChgRsnId(System.Int32 _pgCodeSupervisorChgRsnId)
		{
			int count = -1;
			return GetByPgCodeSupervisorChgRsnId(null,_pgCodeSupervisorChgRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CODE_SUPERVISOR_CHG_RSN index.
		/// </summary>
		/// <param name="_pgCodeSupervisorChgRsnId">مسلسل سبب تعديل الاشراف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn GetByPgCodeSupervisorChgRsnId(System.Int32 _pgCodeSupervisorChgRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCodeSupervisorChgRsnId(null, _pgCodeSupervisorChgRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CODE_SUPERVISOR_CHG_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeSupervisorChgRsnId">مسلسل سبب تعديل الاشراف</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn GetByPgCodeSupervisorChgRsnId(TransactionManager transactionManager, System.Int32 _pgCodeSupervisorChgRsnId)
		{
			int count = -1;
			return GetByPgCodeSupervisorChgRsnId(transactionManager, _pgCodeSupervisorChgRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CODE_SUPERVISOR_CHG_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeSupervisorChgRsnId">مسلسل سبب تعديل الاشراف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn GetByPgCodeSupervisorChgRsnId(TransactionManager transactionManager, System.Int32 _pgCodeSupervisorChgRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCodeSupervisorChgRsnId(transactionManager, _pgCodeSupervisorChgRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CODE_SUPERVISOR_CHG_RSN index.
		/// </summary>
		/// <param name="_pgCodeSupervisorChgRsnId">مسلسل سبب تعديل الاشراف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn GetByPgCodeSupervisorChgRsnId(System.Int32 _pgCodeSupervisorChgRsnId, int start, int pageLength, out int count)
		{
			return GetByPgCodeSupervisorChgRsnId(null, _pgCodeSupervisorChgRsnId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CODE_SUPERVISOR_CHG_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeSupervisorChgRsnId">مسلسل سبب تعديل الاشراف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn GetByPgCodeSupervisorChgRsnId(TransactionManager transactionManager, System.Int32 _pgCodeSupervisorChgRsnId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_PG_CODE_SUPER_CHG_RSN_AR index.
		/// </summary>
		/// <param name="_reasonDescAr">وصف سبب تعديل الاشراف عربى</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn GetByReasonDescAr(System.String _reasonDescAr)
		{
			int count = -1;
			return GetByReasonDescAr(null,_reasonDescAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CODE_SUPER_CHG_RSN_AR index.
		/// </summary>
		/// <param name="_reasonDescAr">وصف سبب تعديل الاشراف عربى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn GetByReasonDescAr(System.String _reasonDescAr, int start, int pageLength)
		{
			int count = -1;
			return GetByReasonDescAr(null, _reasonDescAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CODE_SUPER_CHG_RSN_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_reasonDescAr">وصف سبب تعديل الاشراف عربى</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn GetByReasonDescAr(TransactionManager transactionManager, System.String _reasonDescAr)
		{
			int count = -1;
			return GetByReasonDescAr(transactionManager, _reasonDescAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CODE_SUPER_CHG_RSN_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_reasonDescAr">وصف سبب تعديل الاشراف عربى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn GetByReasonDescAr(TransactionManager transactionManager, System.String _reasonDescAr, int start, int pageLength)
		{
			int count = -1;
			return GetByReasonDescAr(transactionManager, _reasonDescAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CODE_SUPER_CHG_RSN_AR index.
		/// </summary>
		/// <param name="_reasonDescAr">وصف سبب تعديل الاشراف عربى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn GetByReasonDescAr(System.String _reasonDescAr, int start, int pageLength, out int count)
		{
			return GetByReasonDescAr(null, _reasonDescAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CODE_SUPER_CHG_RSN_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_reasonDescAr">وصف سبب تعديل الاشراف عربى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn GetByReasonDescAr(TransactionManager transactionManager, System.String _reasonDescAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_PG_CODE_SUPERVISOR_CHG_RSN_EN index.
		/// </summary>
		/// <param name="_reasonDescEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn GetByReasonDescEn(System.String _reasonDescEn)
		{
			int count = -1;
			return GetByReasonDescEn(null,_reasonDescEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CODE_SUPERVISOR_CHG_RSN_EN index.
		/// </summary>
		/// <param name="_reasonDescEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn GetByReasonDescEn(System.String _reasonDescEn, int start, int pageLength)
		{
			int count = -1;
			return GetByReasonDescEn(null, _reasonDescEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CODE_SUPERVISOR_CHG_RSN_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_reasonDescEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn GetByReasonDescEn(TransactionManager transactionManager, System.String _reasonDescEn)
		{
			int count = -1;
			return GetByReasonDescEn(transactionManager, _reasonDescEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CODE_SUPERVISOR_CHG_RSN_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_reasonDescEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn GetByReasonDescEn(TransactionManager transactionManager, System.String _reasonDescEn, int start, int pageLength)
		{
			int count = -1;
			return GetByReasonDescEn(transactionManager, _reasonDescEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CODE_SUPERVISOR_CHG_RSN_EN index.
		/// </summary>
		/// <param name="_reasonDescEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn GetByReasonDescEn(System.String _reasonDescEn, int start, int pageLength, out int count)
		{
			return GetByReasonDescEn(null, _reasonDescEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CODE_SUPERVISOR_CHG_RSN_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_reasonDescEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn GetByReasonDescEn(TransactionManager transactionManager, System.String _reasonDescEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgCodeSupervisorChgRsn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgCodeSupervisorChgRsn&gt;"/></returns>
		public static TList<PgCodeSupervisorChgRsn> Fill(IDataReader reader, TList<PgCodeSupervisorChgRsn> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgCodeSupervisorChgRsn")
					.Append("|").Append((System.Int32)reader["PG_CODE_SUPERVISOR_CHG_RSN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgCodeSupervisorChgRsn>(
					key.ToString(), // EntityTrackingKey
					"PgCodeSupervisorChgRsn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn();
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
					c.PgCodeSupervisorChgRsnId = (System.Int32)reader["PG_CODE_SUPERVISOR_CHG_RSN_ID"];
					c.OriginalPgCodeSupervisorChgRsnId = c.PgCodeSupervisorChgRsnId;
					c.ReasonCode = Convert.IsDBNull(reader["REASON_CODE"]) ? null : (System.String)reader["REASON_CODE"];
					c.ReasonDescAr = (System.String)reader["REASON_DESC_AR"];
					c.ReasonDescEn = Convert.IsDBNull(reader["REASON_DESC_EN"]) ? null : (System.String)reader["REASON_DESC_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn entity)
		{
			if (!reader.Read()) return;
			
			entity.PgCodeSupervisorChgRsnId = (System.Int32)reader[((int)PgCodeSupervisorChgRsnColumn.PgCodeSupervisorChgRsnId - 1)];
			entity.OriginalPgCodeSupervisorChgRsnId = (System.Int32)reader["PG_CODE_SUPERVISOR_CHG_RSN_ID"];
			entity.ReasonCode = (reader.IsDBNull(((int)PgCodeSupervisorChgRsnColumn.ReasonCode - 1)))?null:(System.String)reader[((int)PgCodeSupervisorChgRsnColumn.ReasonCode - 1)];
			entity.ReasonDescAr = (System.String)reader[((int)PgCodeSupervisorChgRsnColumn.ReasonDescAr - 1)];
			entity.ReasonDescEn = (reader.IsDBNull(((int)PgCodeSupervisorChgRsnColumn.ReasonDescEn - 1)))?null:(System.String)reader[((int)PgCodeSupervisorChgRsnColumn.ReasonDescEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgCodeSupervisorChgRsnId = (System.Int32)dataRow["PG_CODE_SUPERVISOR_CHG_RSN_ID"];
			entity.OriginalPgCodeSupervisorChgRsnId = (System.Int32)dataRow["PG_CODE_SUPERVISOR_CHG_RSN_ID"];
			entity.ReasonCode = Convert.IsDBNull(dataRow["REASON_CODE"]) ? null : (System.String)dataRow["REASON_CODE"];
			entity.ReasonDescAr = (System.String)dataRow["REASON_DESC_AR"];
			entity.ReasonDescEn = Convert.IsDBNull(dataRow["REASON_DESC_EN"]) ? null : (System.String)dataRow["REASON_DESC_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgCodeSupervisorChgRsnId methods when available
			
			#region PgThesisStaffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStaff>|PgThesisStaffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStaffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStaffCollection = DataRepository.PgThesisStaffProvider.GetByPgCodeSupervisorChgRsnId(transactionManager, entity.PgCodeSupervisorChgRsnId);

				if (deep && entity.PgThesisStaffCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStaffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStaff>) DataRepository.PgThesisStaffProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStaffCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisCommMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisCommMember>|PgThesisCommMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisCommMemberCollection = DataRepository.PgThesisCommMemberProvider.GetByPgCodeSupervisorChgRsnId(transactionManager, entity.PgCodeSupervisorChgRsnId);

				if (deep && entity.PgThesisCommMemberCollection.Count > 0)
				{
					deepHandles.Add("PgThesisCommMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisCommMember>) DataRepository.PgThesisCommMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisCommMemberCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<PgThesisStaff>
				if (CanDeepSave(entity.PgThesisStaffCollection, "List<PgThesisStaff>|PgThesisStaffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStaff child in entity.PgThesisStaffCollection)
					{
						if(child.PgCodeSupervisorChgRsnIdSource != null)
						{
							child.PgCodeSupervisorChgRsnId = child.PgCodeSupervisorChgRsnIdSource.PgCodeSupervisorChgRsnId;
						}
						else
						{
							child.PgCodeSupervisorChgRsnId = entity.PgCodeSupervisorChgRsnId;
						}

					}

					if (entity.PgThesisStaffCollection.Count > 0 || entity.PgThesisStaffCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStaffProvider.Save(transactionManager, entity.PgThesisStaffCollection);
						
						deepHandles.Add("PgThesisStaffCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStaff >) DataRepository.PgThesisStaffProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStaffCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisCommMember>
				if (CanDeepSave(entity.PgThesisCommMemberCollection, "List<PgThesisCommMember>|PgThesisCommMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisCommMember child in entity.PgThesisCommMemberCollection)
					{
						if(child.PgCodeSupervisorChgRsnIdSource != null)
						{
							child.PgCodeSupervisorChgRsnId = child.PgCodeSupervisorChgRsnIdSource.PgCodeSupervisorChgRsnId;
						}
						else
						{
							child.PgCodeSupervisorChgRsnId = entity.PgCodeSupervisorChgRsnId;
						}

					}

					if (entity.PgThesisCommMemberCollection.Count > 0 || entity.PgThesisCommMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisCommMemberProvider.Save(transactionManager, entity.PgThesisCommMemberCollection);
						
						deepHandles.Add("PgThesisCommMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisCommMember >) DataRepository.PgThesisCommMemberProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisCommMemberCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgCodeSupervisorChgRsnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgCodeSupervisorChgRsn</c>
	///</summary>
	public enum PgCodeSupervisorChgRsnChildEntityTypes
	{
		///<summary>
		/// Collection of <c>PgCodeSupervisorChgRsn</c> as OneToMany for PgThesisStaffCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStaff>))]
		PgThesisStaffCollection,
		///<summary>
		/// Collection of <c>PgCodeSupervisorChgRsn</c> as OneToMany for PgThesisCommMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisCommMember>))]
		PgThesisCommMemberCollection,
	}
	
	#endregion PgCodeSupervisorChgRsnChildEntityTypes
	
	#region PgCodeSupervisorChgRsnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgCodeSupervisorChgRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCodeSupervisorChgRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgCodeSupervisorChgRsnFilterBuilder : SqlFilterBuilder<PgCodeSupervisorChgRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCodeSupervisorChgRsnFilterBuilder class.
		/// </summary>
		public PgCodeSupervisorChgRsnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgCodeSupervisorChgRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgCodeSupervisorChgRsnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgCodeSupervisorChgRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgCodeSupervisorChgRsnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgCodeSupervisorChgRsnFilterBuilder
	
	#region PgCodeSupervisorChgRsnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgCodeSupervisorChgRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCodeSupervisorChgRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgCodeSupervisorChgRsnParameterBuilder : ParameterizedSqlFilterBuilder<PgCodeSupervisorChgRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCodeSupervisorChgRsnParameterBuilder class.
		/// </summary>
		public PgCodeSupervisorChgRsnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgCodeSupervisorChgRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgCodeSupervisorChgRsnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgCodeSupervisorChgRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgCodeSupervisorChgRsnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgCodeSupervisorChgRsnParameterBuilder
	
	#region PgCodeSupervisorChgRsnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgCodeSupervisorChgRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCodeSupervisorChgRsn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgCodeSupervisorChgRsnSortBuilder : SqlSortBuilder<PgCodeSupervisorChgRsnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCodeSupervisorChgRsnSqlSortBuilder class.
		/// </summary>
		public PgCodeSupervisorChgRsnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgCodeSupervisorChgRsnSortBuilder
	
} // end namespace
