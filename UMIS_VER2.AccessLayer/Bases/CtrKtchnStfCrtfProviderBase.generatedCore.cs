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
	/// This class is the base class for any <see cref="CtrKtchnStfCrtfProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrKtchnStfCrtfProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf, UMIS_VER2.BusinessLyer.CtrKtchnStfCrtfKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrKtchnStfCrtfKey key)
		{
			return Delete(transactionManager, key.CtrKtchnStfCrtfId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_ctrKtchnStfCrtfId">شهادات صحية للعاملين بالمطبخ. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _ctrKtchnStfCrtfId)
		{
			return Delete(null, _ctrKtchnStfCrtfId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrKtchnStfCrtfId">شهادات صحية للعاملين بالمطبخ. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _ctrKtchnStfCrtfId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_KTCHN_STF_CRTF_ERP_EMP key.
		///		FK_CTR_KTCHN_STF_CRTF_ERP_EMP Description: 
		/// </summary>
		/// <param name="_erpEmpId">[ERP Integration]</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf objects.</returns>
		public TList<CtrKtchnStfCrtf> GetByErpEmpId(System.Decimal _erpEmpId)
		{
			int count = -1;
			return GetByErpEmpId(_erpEmpId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_KTCHN_STF_CRTF_ERP_EMP key.
		///		FK_CTR_KTCHN_STF_CRTF_ERP_EMP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpEmpId">[ERP Integration]</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf objects.</returns>
		/// <remarks></remarks>
		public TList<CtrKtchnStfCrtf> GetByErpEmpId(TransactionManager transactionManager, System.Decimal _erpEmpId)
		{
			int count = -1;
			return GetByErpEmpId(transactionManager, _erpEmpId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_KTCHN_STF_CRTF_ERP_EMP key.
		///		FK_CTR_KTCHN_STF_CRTF_ERP_EMP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpEmpId">[ERP Integration]</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf objects.</returns>
		public TList<CtrKtchnStfCrtf> GetByErpEmpId(TransactionManager transactionManager, System.Decimal _erpEmpId, int start, int pageLength)
		{
			int count = -1;
			return GetByErpEmpId(transactionManager, _erpEmpId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_KTCHN_STF_CRTF_ERP_EMP key.
		///		fkCtrKtchnStfCrtfErpEmp Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_erpEmpId">[ERP Integration]</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf objects.</returns>
		public TList<CtrKtchnStfCrtf> GetByErpEmpId(System.Decimal _erpEmpId, int start, int pageLength)
		{
			int count =  -1;
			return GetByErpEmpId(null, _erpEmpId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_KTCHN_STF_CRTF_ERP_EMP key.
		///		fkCtrKtchnStfCrtfErpEmp Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_erpEmpId">[ERP Integration]</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf objects.</returns>
		public TList<CtrKtchnStfCrtf> GetByErpEmpId(System.Decimal _erpEmpId, int start, int pageLength,out int count)
		{
			return GetByErpEmpId(null, _erpEmpId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_KTCHN_STF_CRTF_ERP_EMP key.
		///		FK_CTR_KTCHN_STF_CRTF_ERP_EMP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpEmpId">[ERP Integration]</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf objects.</returns>
		public abstract TList<CtrKtchnStfCrtf> GetByErpEmpId(TransactionManager transactionManager, System.Decimal _erpEmpId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrKtchnStfCrtfKey key, int start, int pageLength)
		{
			return GetByCtrKtchnStfCrtfId(transactionManager, key.CtrKtchnStfCrtfId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CTR_KTCHN_STF_CRTF index.
		/// </summary>
		/// <param name="_ctrKtchnStfCrtfId">شهادات صحية للعاملين بالمطبخ</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf GetByCtrKtchnStfCrtfId(System.Decimal _ctrKtchnStfCrtfId)
		{
			int count = -1;
			return GetByCtrKtchnStfCrtfId(null,_ctrKtchnStfCrtfId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_KTCHN_STF_CRTF index.
		/// </summary>
		/// <param name="_ctrKtchnStfCrtfId">شهادات صحية للعاملين بالمطبخ</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf GetByCtrKtchnStfCrtfId(System.Decimal _ctrKtchnStfCrtfId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrKtchnStfCrtfId(null, _ctrKtchnStfCrtfId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_KTCHN_STF_CRTF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrKtchnStfCrtfId">شهادات صحية للعاملين بالمطبخ</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf GetByCtrKtchnStfCrtfId(TransactionManager transactionManager, System.Decimal _ctrKtchnStfCrtfId)
		{
			int count = -1;
			return GetByCtrKtchnStfCrtfId(transactionManager, _ctrKtchnStfCrtfId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_KTCHN_STF_CRTF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrKtchnStfCrtfId">شهادات صحية للعاملين بالمطبخ</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf GetByCtrKtchnStfCrtfId(TransactionManager transactionManager, System.Decimal _ctrKtchnStfCrtfId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrKtchnStfCrtfId(transactionManager, _ctrKtchnStfCrtfId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_KTCHN_STF_CRTF index.
		/// </summary>
		/// <param name="_ctrKtchnStfCrtfId">شهادات صحية للعاملين بالمطبخ</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf GetByCtrKtchnStfCrtfId(System.Decimal _ctrKtchnStfCrtfId, int start, int pageLength, out int count)
		{
			return GetByCtrKtchnStfCrtfId(null, _ctrKtchnStfCrtfId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_KTCHN_STF_CRTF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrKtchnStfCrtfId">شهادات صحية للعاملين بالمطبخ</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf GetByCtrKtchnStfCrtfId(TransactionManager transactionManager, System.Decimal _ctrKtchnStfCrtfId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CtrKtchnStfCrtf&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CtrKtchnStfCrtf&gt;"/></returns>
		public static TList<CtrKtchnStfCrtf> Fill(IDataReader reader, TList<CtrKtchnStfCrtf> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CtrKtchnStfCrtf")
					.Append("|").Append((System.Decimal)reader["CTR_KTCHN_STF_CRTF_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CtrKtchnStfCrtf>(
					key.ToString(), // EntityTrackingKey
					"CtrKtchnStfCrtf",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf();
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
					c.CtrKtchnStfCrtfId = (System.Decimal)reader["CTR_KTCHN_STF_CRTF_ID"];
					c.OriginalCtrKtchnStfCrtfId = c.CtrKtchnStfCrtfId;
					c.ErpEmpId = (System.Decimal)reader["ERP_EMP_ID"];
					c.CrtfNumber = Convert.IsDBNull(reader["CRTF_NUMBER"]) ? null : (System.String)reader["CRTF_NUMBER"];
					c.CrtfIssueDt = Convert.IsDBNull(reader["CRTF_ISSUE_DT"]) ? null : (System.DateTime?)reader["CRTF_ISSUE_DT"];
					c.CrtfExpDt = Convert.IsDBNull(reader["CRTF_EXP_DT"]) ? null : (System.DateTime?)reader["CRTF_EXP_DT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf entity)
		{
			if (!reader.Read()) return;
			
			entity.CtrKtchnStfCrtfId = (System.Decimal)reader[((int)CtrKtchnStfCrtfColumn.CtrKtchnStfCrtfId - 1)];
			entity.OriginalCtrKtchnStfCrtfId = (System.Decimal)reader["CTR_KTCHN_STF_CRTF_ID"];
			entity.ErpEmpId = (System.Decimal)reader[((int)CtrKtchnStfCrtfColumn.ErpEmpId - 1)];
			entity.CrtfNumber = (reader.IsDBNull(((int)CtrKtchnStfCrtfColumn.CrtfNumber - 1)))?null:(System.String)reader[((int)CtrKtchnStfCrtfColumn.CrtfNumber - 1)];
			entity.CrtfIssueDt = (reader.IsDBNull(((int)CtrKtchnStfCrtfColumn.CrtfIssueDt - 1)))?null:(System.DateTime?)reader[((int)CtrKtchnStfCrtfColumn.CrtfIssueDt - 1)];
			entity.CrtfExpDt = (reader.IsDBNull(((int)CtrKtchnStfCrtfColumn.CrtfExpDt - 1)))?null:(System.DateTime?)reader[((int)CtrKtchnStfCrtfColumn.CrtfExpDt - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CtrKtchnStfCrtfId = (System.Decimal)dataRow["CTR_KTCHN_STF_CRTF_ID"];
			entity.OriginalCtrKtchnStfCrtfId = (System.Decimal)dataRow["CTR_KTCHN_STF_CRTF_ID"];
			entity.ErpEmpId = (System.Decimal)dataRow["ERP_EMP_ID"];
			entity.CrtfNumber = Convert.IsDBNull(dataRow["CRTF_NUMBER"]) ? null : (System.String)dataRow["CRTF_NUMBER"];
			entity.CrtfIssueDt = Convert.IsDBNull(dataRow["CRTF_ISSUE_DT"]) ? null : (System.DateTime?)dataRow["CRTF_ISSUE_DT"];
			entity.CrtfExpDt = Convert.IsDBNull(dataRow["CRTF_EXP_DT"]) ? null : (System.DateTime?)dataRow["CRTF_EXP_DT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region ErpEmpIdSource	
			if (CanDeepLoad(entity, "ErpEmp|ErpEmpIdSource", deepLoadType, innerList) 
				&& entity.ErpEmpIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ErpEmpId;
				ErpEmp tmpEntity = EntityManager.LocateEntity<ErpEmp>(EntityLocator.ConstructKeyFromPkItems(typeof(ErpEmp), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ErpEmpIdSource = tmpEntity;
				else
					entity.ErpEmpIdSource = DataRepository.ErpEmpProvider.GetByErpEmpId(transactionManager, entity.ErpEmpId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ErpEmpIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ErpEmpIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ErpEmpProvider.DeepLoad(transactionManager, entity.ErpEmpIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ErpEmpIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region ErpEmpIdSource
			if (CanDeepSave(entity, "ErpEmp|ErpEmpIdSource", deepSaveType, innerList) 
				&& entity.ErpEmpIdSource != null)
			{
				DataRepository.ErpEmpProvider.Save(transactionManager, entity.ErpEmpIdSource);
				entity.ErpEmpId = entity.ErpEmpIdSource.ErpEmpId;
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
	
	#region CtrKtchnStfCrtfChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CtrKtchnStfCrtf</c>
	///</summary>
	public enum CtrKtchnStfCrtfChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>ErpEmp</c> at ErpEmpIdSource
		///</summary>
		[ChildEntityType(typeof(ErpEmp))]
		ErpEmp,
	}
	
	#endregion CtrKtchnStfCrtfChildEntityTypes
	
	#region CtrKtchnStfCrtfFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CtrKtchnStfCrtfColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrKtchnStfCrtf"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrKtchnStfCrtfFilterBuilder : SqlFilterBuilder<CtrKtchnStfCrtfColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrKtchnStfCrtfFilterBuilder class.
		/// </summary>
		public CtrKtchnStfCrtfFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrKtchnStfCrtfFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrKtchnStfCrtfFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrKtchnStfCrtfFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrKtchnStfCrtfFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrKtchnStfCrtfFilterBuilder
	
	#region CtrKtchnStfCrtfParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CtrKtchnStfCrtfColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrKtchnStfCrtf"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrKtchnStfCrtfParameterBuilder : ParameterizedSqlFilterBuilder<CtrKtchnStfCrtfColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrKtchnStfCrtfParameterBuilder class.
		/// </summary>
		public CtrKtchnStfCrtfParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrKtchnStfCrtfParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrKtchnStfCrtfParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrKtchnStfCrtfParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrKtchnStfCrtfParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrKtchnStfCrtfParameterBuilder
	
	#region CtrKtchnStfCrtfSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CtrKtchnStfCrtfColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrKtchnStfCrtf"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CtrKtchnStfCrtfSortBuilder : SqlSortBuilder<CtrKtchnStfCrtfColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrKtchnStfCrtfSqlSortBuilder class.
		/// </summary>
		public CtrKtchnStfCrtfSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CtrKtchnStfCrtfSortBuilder
	
} // end namespace
