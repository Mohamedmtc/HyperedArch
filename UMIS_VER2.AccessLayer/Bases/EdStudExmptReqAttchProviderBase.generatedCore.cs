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
	/// This class is the base class for any <see cref="EdStudExmptReqAttchProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudExmptReqAttchProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudExmptReqAttch, UMIS_VER2.BusinessLyer.EdStudExmptReqAttchKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExmptReqAttchKey key)
		{
			return Delete(transactionManager, key.EdStudExmptReqAttchId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudExmptReqAttchId">Relevant Attachment. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudExmptReqAttchId)
		{
			return Delete(null, _edStudExmptReqAttchId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptReqAttchId">Relevant Attachment. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudExmptReqAttchId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ATTCH_ED_STUD_EXMPT_REQ key.
		///		FK_ED_STUD_EXMPT_REQ_ATTCH_ED_STUD_EXMPT_REQ Description: 
		/// </summary>
		/// <param name="_edStudExmptReqId">طلبات الاعفاء</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReqAttch objects.</returns>
		public TList<EdStudExmptReqAttch> GetByEdStudExmptReqId(System.Decimal _edStudExmptReqId)
		{
			int count = -1;
			return GetByEdStudExmptReqId(_edStudExmptReqId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ATTCH_ED_STUD_EXMPT_REQ key.
		///		FK_ED_STUD_EXMPT_REQ_ATTCH_ED_STUD_EXMPT_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptReqId">طلبات الاعفاء</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReqAttch objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudExmptReqAttch> GetByEdStudExmptReqId(TransactionManager transactionManager, System.Decimal _edStudExmptReqId)
		{
			int count = -1;
			return GetByEdStudExmptReqId(transactionManager, _edStudExmptReqId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ATTCH_ED_STUD_EXMPT_REQ key.
		///		FK_ED_STUD_EXMPT_REQ_ATTCH_ED_STUD_EXMPT_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptReqId">طلبات الاعفاء</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReqAttch objects.</returns>
		public TList<EdStudExmptReqAttch> GetByEdStudExmptReqId(TransactionManager transactionManager, System.Decimal _edStudExmptReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExmptReqId(transactionManager, _edStudExmptReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ATTCH_ED_STUD_EXMPT_REQ key.
		///		fkEdStudExmptReqAttchEdStudExmptReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudExmptReqId">طلبات الاعفاء</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReqAttch objects.</returns>
		public TList<EdStudExmptReqAttch> GetByEdStudExmptReqId(System.Decimal _edStudExmptReqId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudExmptReqId(null, _edStudExmptReqId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ATTCH_ED_STUD_EXMPT_REQ key.
		///		fkEdStudExmptReqAttchEdStudExmptReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudExmptReqId">طلبات الاعفاء</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReqAttch objects.</returns>
		public TList<EdStudExmptReqAttch> GetByEdStudExmptReqId(System.Decimal _edStudExmptReqId, int start, int pageLength,out int count)
		{
			return GetByEdStudExmptReqId(null, _edStudExmptReqId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ATTCH_ED_STUD_EXMPT_REQ key.
		///		FK_ED_STUD_EXMPT_REQ_ATTCH_ED_STUD_EXMPT_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptReqId">طلبات الاعفاء</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReqAttch objects.</returns>
		public abstract TList<EdStudExmptReqAttch> GetByEdStudExmptReqId(TransactionManager transactionManager, System.Decimal _edStudExmptReqId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudExmptReqAttch Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExmptReqAttchKey key, int start, int pageLength)
		{
			return GetByEdStudExmptReqAttchId(transactionManager, key.EdStudExmptReqAttchId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_EXMPT_REQ_ATTCH index.
		/// </summary>
		/// <param name="_edStudExmptReqAttchId">Relevant Attachment</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReqAttch"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptReqAttch GetByEdStudExmptReqAttchId(System.Decimal _edStudExmptReqAttchId)
		{
			int count = -1;
			return GetByEdStudExmptReqAttchId(null,_edStudExmptReqAttchId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_REQ_ATTCH index.
		/// </summary>
		/// <param name="_edStudExmptReqAttchId">Relevant Attachment</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReqAttch"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptReqAttch GetByEdStudExmptReqAttchId(System.Decimal _edStudExmptReqAttchId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExmptReqAttchId(null, _edStudExmptReqAttchId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_REQ_ATTCH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptReqAttchId">Relevant Attachment</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReqAttch"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptReqAttch GetByEdStudExmptReqAttchId(TransactionManager transactionManager, System.Decimal _edStudExmptReqAttchId)
		{
			int count = -1;
			return GetByEdStudExmptReqAttchId(transactionManager, _edStudExmptReqAttchId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_REQ_ATTCH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptReqAttchId">Relevant Attachment</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReqAttch"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptReqAttch GetByEdStudExmptReqAttchId(TransactionManager transactionManager, System.Decimal _edStudExmptReqAttchId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExmptReqAttchId(transactionManager, _edStudExmptReqAttchId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_REQ_ATTCH index.
		/// </summary>
		/// <param name="_edStudExmptReqAttchId">Relevant Attachment</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReqAttch"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptReqAttch GetByEdStudExmptReqAttchId(System.Decimal _edStudExmptReqAttchId, int start, int pageLength, out int count)
		{
			return GetByEdStudExmptReqAttchId(null, _edStudExmptReqAttchId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_REQ_ATTCH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptReqAttchId">Relevant Attachment</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReqAttch"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudExmptReqAttch GetByEdStudExmptReqAttchId(TransactionManager transactionManager, System.Decimal _edStudExmptReqAttchId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudExmptReqAttch&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudExmptReqAttch&gt;"/></returns>
		public static TList<EdStudExmptReqAttch> Fill(IDataReader reader, TList<EdStudExmptReqAttch> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudExmptReqAttch c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudExmptReqAttch")
					.Append("|").Append((System.Decimal)reader["ED_STUD_EXMPT_REQ_ATTCH_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudExmptReqAttch>(
					key.ToString(), // EntityTrackingKey
					"EdStudExmptReqAttch",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudExmptReqAttch();
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
					c.EdStudExmptReqAttchId = (System.Decimal)reader["ED_STUD_EXMPT_REQ_ATTCH_ID"];
					c.OriginalEdStudExmptReqAttchId = c.EdStudExmptReqAttchId;
					c.EdStudExmptReqId = (System.Decimal)reader["ED_STUD_EXMPT_REQ_ID"];
					c.AttchdDocPath = (System.String)reader["ATTCHD_DOC_PATH"];
					c.AttchdDocTitleEn = Convert.IsDBNull(reader["ATTCHD_DOC_TITLE_EN"]) ? null : (System.String)reader["ATTCHD_DOC_TITLE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReqAttch"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReqAttch"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudExmptReqAttch entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudExmptReqAttchId = (System.Decimal)reader[((int)EdStudExmptReqAttchColumn.EdStudExmptReqAttchId - 1)];
			entity.OriginalEdStudExmptReqAttchId = (System.Decimal)reader["ED_STUD_EXMPT_REQ_ATTCH_ID"];
			entity.EdStudExmptReqId = (System.Decimal)reader[((int)EdStudExmptReqAttchColumn.EdStudExmptReqId - 1)];
			entity.AttchdDocPath = (System.String)reader[((int)EdStudExmptReqAttchColumn.AttchdDocPath - 1)];
			entity.AttchdDocTitleEn = (reader.IsDBNull(((int)EdStudExmptReqAttchColumn.AttchdDocTitleEn - 1)))?null:(System.String)reader[((int)EdStudExmptReqAttchColumn.AttchdDocTitleEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReqAttch"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReqAttch"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudExmptReqAttch entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudExmptReqAttchId = (System.Decimal)dataRow["ED_STUD_EXMPT_REQ_ATTCH_ID"];
			entity.OriginalEdStudExmptReqAttchId = (System.Decimal)dataRow["ED_STUD_EXMPT_REQ_ATTCH_ID"];
			entity.EdStudExmptReqId = (System.Decimal)dataRow["ED_STUD_EXMPT_REQ_ID"];
			entity.AttchdDocPath = (System.String)dataRow["ATTCHD_DOC_PATH"];
			entity.AttchdDocTitleEn = Convert.IsDBNull(dataRow["ATTCHD_DOC_TITLE_EN"]) ? null : (System.String)dataRow["ATTCHD_DOC_TITLE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReqAttch"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudExmptReqAttch Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExmptReqAttch entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudExmptReqAttch object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudExmptReqAttch instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudExmptReqAttch Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExmptReqAttch entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
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
	
	#region EdStudExmptReqAttchChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudExmptReqAttch</c>
	///</summary>
	public enum EdStudExmptReqAttchChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStudExmptReq</c> at EdStudExmptReqIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudExmptReq))]
		EdStudExmptReq,
	}
	
	#endregion EdStudExmptReqAttchChildEntityTypes
	
	#region EdStudExmptReqAttchFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudExmptReqAttchColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudExmptReqAttch"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudExmptReqAttchFilterBuilder : SqlFilterBuilder<EdStudExmptReqAttchColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudExmptReqAttchFilterBuilder class.
		/// </summary>
		public EdStudExmptReqAttchFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudExmptReqAttchFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudExmptReqAttchFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudExmptReqAttchFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudExmptReqAttchFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudExmptReqAttchFilterBuilder
	
	#region EdStudExmptReqAttchParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudExmptReqAttchColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudExmptReqAttch"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudExmptReqAttchParameterBuilder : ParameterizedSqlFilterBuilder<EdStudExmptReqAttchColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudExmptReqAttchParameterBuilder class.
		/// </summary>
		public EdStudExmptReqAttchParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudExmptReqAttchParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudExmptReqAttchParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudExmptReqAttchParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudExmptReqAttchParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudExmptReqAttchParameterBuilder
	
	#region EdStudExmptReqAttchSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudExmptReqAttchColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudExmptReqAttch"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudExmptReqAttchSortBuilder : SqlSortBuilder<EdStudExmptReqAttchColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudExmptReqAttchSqlSortBuilder class.
		/// </summary>
		public EdStudExmptReqAttchSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudExmptReqAttchSortBuilder
	
} // end namespace
