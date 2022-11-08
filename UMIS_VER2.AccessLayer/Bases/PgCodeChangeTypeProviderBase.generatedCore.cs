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
	/// This class is the base class for any <see cref="PgCodeChangeTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgCodeChangeTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgCodeChangeType, UMIS_VER2.BusinessLyer.PgCodeChangeTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCodeChangeTypeKey key)
		{
			return Delete(transactionManager, key.PgCodeChangeTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgCodeChangeTypeId">مسلسل نوع التغيير. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _pgCodeChangeTypeId)
		{
			return Delete(null, _pgCodeChangeTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeChangeTypeId">مسلسل نوع التغيير. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _pgCodeChangeTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.PgCodeChangeType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCodeChangeTypeKey key, int start, int pageLength)
		{
			return GetByPgCodeChangeTypeId(transactionManager, key.PgCodeChangeTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_CODE_CHANGE_TYPE index.
		/// </summary>
		/// <param name="_pgCodeChangeTypeId">مسلسل نوع التغيير</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeChangeType GetByPgCodeChangeTypeId(System.Int32 _pgCodeChangeTypeId)
		{
			int count = -1;
			return GetByPgCodeChangeTypeId(null,_pgCodeChangeTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CODE_CHANGE_TYPE index.
		/// </summary>
		/// <param name="_pgCodeChangeTypeId">مسلسل نوع التغيير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeChangeType GetByPgCodeChangeTypeId(System.Int32 _pgCodeChangeTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCodeChangeTypeId(null, _pgCodeChangeTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CODE_CHANGE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeChangeTypeId">مسلسل نوع التغيير</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeChangeType GetByPgCodeChangeTypeId(TransactionManager transactionManager, System.Int32 _pgCodeChangeTypeId)
		{
			int count = -1;
			return GetByPgCodeChangeTypeId(transactionManager, _pgCodeChangeTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CODE_CHANGE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeChangeTypeId">مسلسل نوع التغيير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeChangeType GetByPgCodeChangeTypeId(TransactionManager transactionManager, System.Int32 _pgCodeChangeTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCodeChangeTypeId(transactionManager, _pgCodeChangeTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CODE_CHANGE_TYPE index.
		/// </summary>
		/// <param name="_pgCodeChangeTypeId">مسلسل نوع التغيير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeChangeType GetByPgCodeChangeTypeId(System.Int32 _pgCodeChangeTypeId, int start, int pageLength, out int count)
		{
			return GetByPgCodeChangeTypeId(null, _pgCodeChangeTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CODE_CHANGE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeChangeTypeId">مسلسل نوع التغيير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgCodeChangeType GetByPgCodeChangeTypeId(TransactionManager transactionManager, System.Int32 _pgCodeChangeTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_PG_CHNG_TYPE_DESC_AR index.
		/// </summary>
		/// <param name="_changeTypeAr">وصف نوع التغيير</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeChangeType GetByChangeTypeAr(System.String _changeTypeAr)
		{
			int count = -1;
			return GetByChangeTypeAr(null,_changeTypeAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CHNG_TYPE_DESC_AR index.
		/// </summary>
		/// <param name="_changeTypeAr">وصف نوع التغيير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeChangeType GetByChangeTypeAr(System.String _changeTypeAr, int start, int pageLength)
		{
			int count = -1;
			return GetByChangeTypeAr(null, _changeTypeAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CHNG_TYPE_DESC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_changeTypeAr">وصف نوع التغيير</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeChangeType GetByChangeTypeAr(TransactionManager transactionManager, System.String _changeTypeAr)
		{
			int count = -1;
			return GetByChangeTypeAr(transactionManager, _changeTypeAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CHNG_TYPE_DESC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_changeTypeAr">وصف نوع التغيير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeChangeType GetByChangeTypeAr(TransactionManager transactionManager, System.String _changeTypeAr, int start, int pageLength)
		{
			int count = -1;
			return GetByChangeTypeAr(transactionManager, _changeTypeAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CHNG_TYPE_DESC_AR index.
		/// </summary>
		/// <param name="_changeTypeAr">وصف نوع التغيير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeChangeType GetByChangeTypeAr(System.String _changeTypeAr, int start, int pageLength, out int count)
		{
			return GetByChangeTypeAr(null, _changeTypeAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CHNG_TYPE_DESC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_changeTypeAr">وصف نوع التغيير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgCodeChangeType GetByChangeTypeAr(TransactionManager transactionManager, System.String _changeTypeAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_PG_CODE_CHANGE_TYPE_EN index.
		/// </summary>
		/// <param name="_changeTypeEn">وصف نوع التغيير</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeChangeType GetByChangeTypeEn(System.String _changeTypeEn)
		{
			int count = -1;
			return GetByChangeTypeEn(null,_changeTypeEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CODE_CHANGE_TYPE_EN index.
		/// </summary>
		/// <param name="_changeTypeEn">وصف نوع التغيير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeChangeType GetByChangeTypeEn(System.String _changeTypeEn, int start, int pageLength)
		{
			int count = -1;
			return GetByChangeTypeEn(null, _changeTypeEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CODE_CHANGE_TYPE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_changeTypeEn">وصف نوع التغيير</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeChangeType GetByChangeTypeEn(TransactionManager transactionManager, System.String _changeTypeEn)
		{
			int count = -1;
			return GetByChangeTypeEn(transactionManager, _changeTypeEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CODE_CHANGE_TYPE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_changeTypeEn">وصف نوع التغيير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeChangeType GetByChangeTypeEn(TransactionManager transactionManager, System.String _changeTypeEn, int start, int pageLength)
		{
			int count = -1;
			return GetByChangeTypeEn(transactionManager, _changeTypeEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CODE_CHANGE_TYPE_EN index.
		/// </summary>
		/// <param name="_changeTypeEn">وصف نوع التغيير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCodeChangeType GetByChangeTypeEn(System.String _changeTypeEn, int start, int pageLength, out int count)
		{
			return GetByChangeTypeEn(null, _changeTypeEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_CODE_CHANGE_TYPE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_changeTypeEn">وصف نوع التغيير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgCodeChangeType GetByChangeTypeEn(TransactionManager transactionManager, System.String _changeTypeEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgCodeChangeType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgCodeChangeType&gt;"/></returns>
		public static TList<PgCodeChangeType> Fill(IDataReader reader, TList<PgCodeChangeType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgCodeChangeType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgCodeChangeType")
					.Append("|").Append((System.Int32)reader["PG_CODE_CHANGE_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgCodeChangeType>(
					key.ToString(), // EntityTrackingKey
					"PgCodeChangeType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgCodeChangeType();
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
					c.PgCodeChangeTypeId = (System.Int32)reader["PG_CODE_CHANGE_TYPE_ID"];
					c.OriginalPgCodeChangeTypeId = c.PgCodeChangeTypeId;
					c.ChangeTypeCode = Convert.IsDBNull(reader["CHANGE_TYPE_CODE"]) ? null : (System.String)reader["CHANGE_TYPE_CODE"];
					c.ChangeTypeAr = (System.String)reader["CHANGE_TYPE_AR"];
					c.ChangeTypeEn = Convert.IsDBNull(reader["CHANGE_TYPE_EN"]) ? null : (System.String)reader["CHANGE_TYPE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgCodeChangeType entity)
		{
			if (!reader.Read()) return;
			
			entity.PgCodeChangeTypeId = (System.Int32)reader[((int)PgCodeChangeTypeColumn.PgCodeChangeTypeId - 1)];
			entity.OriginalPgCodeChangeTypeId = (System.Int32)reader["PG_CODE_CHANGE_TYPE_ID"];
			entity.ChangeTypeCode = (reader.IsDBNull(((int)PgCodeChangeTypeColumn.ChangeTypeCode - 1)))?null:(System.String)reader[((int)PgCodeChangeTypeColumn.ChangeTypeCode - 1)];
			entity.ChangeTypeAr = (System.String)reader[((int)PgCodeChangeTypeColumn.ChangeTypeAr - 1)];
			entity.ChangeTypeEn = (reader.IsDBNull(((int)PgCodeChangeTypeColumn.ChangeTypeEn - 1)))?null:(System.String)reader[((int)PgCodeChangeTypeColumn.ChangeTypeEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgCodeChangeType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgCodeChangeTypeId = (System.Int32)dataRow["PG_CODE_CHANGE_TYPE_ID"];
			entity.OriginalPgCodeChangeTypeId = (System.Int32)dataRow["PG_CODE_CHANGE_TYPE_ID"];
			entity.ChangeTypeCode = Convert.IsDBNull(dataRow["CHANGE_TYPE_CODE"]) ? null : (System.String)dataRow["CHANGE_TYPE_CODE"];
			entity.ChangeTypeAr = (System.String)dataRow["CHANGE_TYPE_AR"];
			entity.ChangeTypeEn = Convert.IsDBNull(dataRow["CHANGE_TYPE_EN"]) ? null : (System.String)dataRow["CHANGE_TYPE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCodeChangeType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgCodeChangeType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCodeChangeType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgCodeChangeTypeId methods when available
			
			#region PgThesisStudTopicCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStudTopic>|PgThesisStudTopicCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudTopicCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudTopicCollection = DataRepository.PgThesisStudTopicProvider.GetByPgCodeChangeTypeId(transactionManager, entity.PgCodeChangeTypeId);

				if (deep && entity.PgThesisStudTopicCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudTopicCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStudTopic>) DataRepository.PgThesisStudTopicProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudTopicCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgCodeChangeType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgCodeChangeType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgCodeChangeType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCodeChangeType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<PgThesisStudTopic>
				if (CanDeepSave(entity.PgThesisStudTopicCollection, "List<PgThesisStudTopic>|PgThesisStudTopicCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStudTopic child in entity.PgThesisStudTopicCollection)
					{
						if(child.PgCodeChangeTypeIdSource != null)
						{
							child.PgCodeChangeTypeId = child.PgCodeChangeTypeIdSource.PgCodeChangeTypeId;
						}
						else
						{
							child.PgCodeChangeTypeId = entity.PgCodeChangeTypeId;
						}

					}

					if (entity.PgThesisStudTopicCollection.Count > 0 || entity.PgThesisStudTopicCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudTopicProvider.Save(transactionManager, entity.PgThesisStudTopicCollection);
						
						deepHandles.Add("PgThesisStudTopicCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStudTopic >) DataRepository.PgThesisStudTopicProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudTopicCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgCodeChangeTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgCodeChangeType</c>
	///</summary>
	public enum PgCodeChangeTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>PgCodeChangeType</c> as OneToMany for PgThesisStudTopicCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStudTopic>))]
		PgThesisStudTopicCollection,
	}
	
	#endregion PgCodeChangeTypeChildEntityTypes
	
	#region PgCodeChangeTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgCodeChangeTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCodeChangeType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgCodeChangeTypeFilterBuilder : SqlFilterBuilder<PgCodeChangeTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCodeChangeTypeFilterBuilder class.
		/// </summary>
		public PgCodeChangeTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgCodeChangeTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgCodeChangeTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgCodeChangeTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgCodeChangeTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgCodeChangeTypeFilterBuilder
	
	#region PgCodeChangeTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgCodeChangeTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCodeChangeType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgCodeChangeTypeParameterBuilder : ParameterizedSqlFilterBuilder<PgCodeChangeTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCodeChangeTypeParameterBuilder class.
		/// </summary>
		public PgCodeChangeTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgCodeChangeTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgCodeChangeTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgCodeChangeTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgCodeChangeTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgCodeChangeTypeParameterBuilder
	
	#region PgCodeChangeTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgCodeChangeTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCodeChangeType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgCodeChangeTypeSortBuilder : SqlSortBuilder<PgCodeChangeTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCodeChangeTypeSqlSortBuilder class.
		/// </summary>
		public PgCodeChangeTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgCodeChangeTypeSortBuilder
	
} // end namespace
