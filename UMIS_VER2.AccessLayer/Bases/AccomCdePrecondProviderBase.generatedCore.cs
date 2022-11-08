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
	/// This class is the base class for any <see cref="AccomCdePrecondProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomCdePrecondProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomCdePrecond, UMIS_VER2.BusinessLyer.AccomCdePrecondKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdePrecondKey key)
		{
			return Delete(transactionManager, key.AccomCdePrecondId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomCdePrecondId">2.6.	تحديد شروط خدمة السكن. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int16 _accomCdePrecondId)
		{
			return Delete(null, _accomCdePrecondId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdePrecondId">2.6.	تحديد شروط خدمة السكن. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int16 _accomCdePrecondId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_CDE_PRECOND_ENT_CODE_MD_TYPE key.
		///		FK_ACCOM_CDE_PRECOND_ENT_CODE_MD_TYPE Description: 
		/// </summary>
		/// <param name="_entCodeMdTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomCdePrecond objects.</returns>
		public TList<AccomCdePrecond> GetByEntCodeMdTypeId(System.Decimal? _entCodeMdTypeId)
		{
			int count = -1;
			return GetByEntCodeMdTypeId(_entCodeMdTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_CDE_PRECOND_ENT_CODE_MD_TYPE key.
		///		FK_ACCOM_CDE_PRECOND_ENT_CODE_MD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomCdePrecond objects.</returns>
		/// <remarks></remarks>
		public TList<AccomCdePrecond> GetByEntCodeMdTypeId(TransactionManager transactionManager, System.Decimal? _entCodeMdTypeId)
		{
			int count = -1;
			return GetByEntCodeMdTypeId(transactionManager, _entCodeMdTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_CDE_PRECOND_ENT_CODE_MD_TYPE key.
		///		FK_ACCOM_CDE_PRECOND_ENT_CODE_MD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomCdePrecond objects.</returns>
		public TList<AccomCdePrecond> GetByEntCodeMdTypeId(TransactionManager transactionManager, System.Decimal? _entCodeMdTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeMdTypeId(transactionManager, _entCodeMdTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_CDE_PRECOND_ENT_CODE_MD_TYPE key.
		///		fkAccomCdePrecondEntCodeMdType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomCdePrecond objects.</returns>
		public TList<AccomCdePrecond> GetByEntCodeMdTypeId(System.Decimal? _entCodeMdTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntCodeMdTypeId(null, _entCodeMdTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_CDE_PRECOND_ENT_CODE_MD_TYPE key.
		///		fkAccomCdePrecondEntCodeMdType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomCdePrecond objects.</returns>
		public TList<AccomCdePrecond> GetByEntCodeMdTypeId(System.Decimal? _entCodeMdTypeId, int start, int pageLength,out int count)
		{
			return GetByEntCodeMdTypeId(null, _entCodeMdTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_CDE_PRECOND_ENT_CODE_MD_TYPE key.
		///		FK_ACCOM_CDE_PRECOND_ENT_CODE_MD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomCdePrecond objects.</returns>
		public abstract TList<AccomCdePrecond> GetByEntCodeMdTypeId(TransactionManager transactionManager, System.Decimal? _entCodeMdTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomCdePrecond Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdePrecondKey key, int start, int pageLength)
		{
			return GetByAccomCdePrecondId(transactionManager, key.AccomCdePrecondId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_CDE_PRECOND index.
		/// </summary>
		/// <param name="_accomCdePrecondId">2.6.	تحديد شروط خدمة السكن</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdePrecond"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdePrecond GetByAccomCdePrecondId(System.Int16 _accomCdePrecondId)
		{
			int count = -1;
			return GetByAccomCdePrecondId(null,_accomCdePrecondId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_PRECOND index.
		/// </summary>
		/// <param name="_accomCdePrecondId">2.6.	تحديد شروط خدمة السكن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdePrecond"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdePrecond GetByAccomCdePrecondId(System.Int16 _accomCdePrecondId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdePrecondId(null, _accomCdePrecondId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_PRECOND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdePrecondId">2.6.	تحديد شروط خدمة السكن</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdePrecond"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdePrecond GetByAccomCdePrecondId(TransactionManager transactionManager, System.Int16 _accomCdePrecondId)
		{
			int count = -1;
			return GetByAccomCdePrecondId(transactionManager, _accomCdePrecondId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_PRECOND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdePrecondId">2.6.	تحديد شروط خدمة السكن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdePrecond"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdePrecond GetByAccomCdePrecondId(TransactionManager transactionManager, System.Int16 _accomCdePrecondId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdePrecondId(transactionManager, _accomCdePrecondId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_PRECOND index.
		/// </summary>
		/// <param name="_accomCdePrecondId">2.6.	تحديد شروط خدمة السكن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdePrecond"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdePrecond GetByAccomCdePrecondId(System.Int16 _accomCdePrecondId, int start, int pageLength, out int count)
		{
			return GetByAccomCdePrecondId(null, _accomCdePrecondId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_PRECOND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdePrecondId">2.6.	تحديد شروط خدمة السكن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdePrecond"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomCdePrecond GetByAccomCdePrecondId(TransactionManager transactionManager, System.Int16 _accomCdePrecondId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomCdePrecond&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomCdePrecond&gt;"/></returns>
		public static TList<AccomCdePrecond> Fill(IDataReader reader, TList<AccomCdePrecond> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomCdePrecond c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomCdePrecond")
					.Append("|").Append((System.Int16)reader["ACCOM_CDE_PRECOND_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomCdePrecond>(
					key.ToString(), // EntityTrackingKey
					"AccomCdePrecond",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomCdePrecond();
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
					c.AccomCdePrecondId = (System.Int16)reader["ACCOM_CDE_PRECOND_ID"];
					c.OriginalAccomCdePrecondId = c.AccomCdePrecondId;
					c.PrecondCode = Convert.IsDBNull(reader["PRECOND_CODE"]) ? null : (System.String)reader["PRECOND_CODE"];
					c.PrecondAr = Convert.IsDBNull(reader["PRECOND_AR"]) ? null : (System.String)reader["PRECOND_AR"];
					c.PrecondEn = Convert.IsDBNull(reader["PRECOND_EN"]) ? null : (System.String)reader["PRECOND_EN"];
					c.EntCodeMdTypeId = Convert.IsDBNull(reader["ENT_CODE_MD_TYPE_ID"]) ? null : (System.Decimal?)reader["ENT_CODE_MD_TYPE_ID"];
					c.TblRltdFlg = Convert.IsDBNull(reader["TBL_RLTD_FLG"]) ? null : (System.Decimal?)reader["TBL_RLTD_FLG"];
					c.TblName = Convert.IsDBNull(reader["TBL_NAME"]) ? null : (System.String)reader["TBL_NAME"];
					c.PrecondValue = Convert.IsDBNull(reader["PRECOND_VALUE"]) ? null : (System.String)reader["PRECOND_VALUE"];
					c.IsActive = Convert.IsDBNull(reader["IS_ACTIVE"]) ? null : (System.Boolean?)reader["IS_ACTIVE"];
					c.DispOrder = Convert.IsDBNull(reader["DISP_ORDER"]) ? null : (System.Decimal?)reader["DISP_ORDER"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomCdePrecond"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdePrecond"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomCdePrecond entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomCdePrecondId = (System.Int16)reader[((int)AccomCdePrecondColumn.AccomCdePrecondId - 1)];
			entity.OriginalAccomCdePrecondId = (System.Int16)reader["ACCOM_CDE_PRECOND_ID"];
			entity.PrecondCode = (reader.IsDBNull(((int)AccomCdePrecondColumn.PrecondCode - 1)))?null:(System.String)reader[((int)AccomCdePrecondColumn.PrecondCode - 1)];
			entity.PrecondAr = (reader.IsDBNull(((int)AccomCdePrecondColumn.PrecondAr - 1)))?null:(System.String)reader[((int)AccomCdePrecondColumn.PrecondAr - 1)];
			entity.PrecondEn = (reader.IsDBNull(((int)AccomCdePrecondColumn.PrecondEn - 1)))?null:(System.String)reader[((int)AccomCdePrecondColumn.PrecondEn - 1)];
			entity.EntCodeMdTypeId = (reader.IsDBNull(((int)AccomCdePrecondColumn.EntCodeMdTypeId - 1)))?null:(System.Decimal?)reader[((int)AccomCdePrecondColumn.EntCodeMdTypeId - 1)];
			entity.TblRltdFlg = (reader.IsDBNull(((int)AccomCdePrecondColumn.TblRltdFlg - 1)))?null:(System.Decimal?)reader[((int)AccomCdePrecondColumn.TblRltdFlg - 1)];
			entity.TblName = (reader.IsDBNull(((int)AccomCdePrecondColumn.TblName - 1)))?null:(System.String)reader[((int)AccomCdePrecondColumn.TblName - 1)];
			entity.PrecondValue = (reader.IsDBNull(((int)AccomCdePrecondColumn.PrecondValue - 1)))?null:(System.String)reader[((int)AccomCdePrecondColumn.PrecondValue - 1)];
			entity.IsActive = (reader.IsDBNull(((int)AccomCdePrecondColumn.IsActive - 1)))?null:(System.Boolean?)reader[((int)AccomCdePrecondColumn.IsActive - 1)];
			entity.DispOrder = (reader.IsDBNull(((int)AccomCdePrecondColumn.DispOrder - 1)))?null:(System.Decimal?)reader[((int)AccomCdePrecondColumn.DispOrder - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomCdePrecond"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdePrecond"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomCdePrecond entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomCdePrecondId = (System.Int16)dataRow["ACCOM_CDE_PRECOND_ID"];
			entity.OriginalAccomCdePrecondId = (System.Int16)dataRow["ACCOM_CDE_PRECOND_ID"];
			entity.PrecondCode = Convert.IsDBNull(dataRow["PRECOND_CODE"]) ? null : (System.String)dataRow["PRECOND_CODE"];
			entity.PrecondAr = Convert.IsDBNull(dataRow["PRECOND_AR"]) ? null : (System.String)dataRow["PRECOND_AR"];
			entity.PrecondEn = Convert.IsDBNull(dataRow["PRECOND_EN"]) ? null : (System.String)dataRow["PRECOND_EN"];
			entity.EntCodeMdTypeId = Convert.IsDBNull(dataRow["ENT_CODE_MD_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ENT_CODE_MD_TYPE_ID"];
			entity.TblRltdFlg = Convert.IsDBNull(dataRow["TBL_RLTD_FLG"]) ? null : (System.Decimal?)dataRow["TBL_RLTD_FLG"];
			entity.TblName = Convert.IsDBNull(dataRow["TBL_NAME"]) ? null : (System.String)dataRow["TBL_NAME"];
			entity.PrecondValue = Convert.IsDBNull(dataRow["PRECOND_VALUE"]) ? null : (System.String)dataRow["PRECOND_VALUE"];
			entity.IsActive = Convert.IsDBNull(dataRow["IS_ACTIVE"]) ? null : (System.Boolean?)dataRow["IS_ACTIVE"];
			entity.DispOrder = Convert.IsDBNull(dataRow["DISP_ORDER"]) ? null : (System.Decimal?)dataRow["DISP_ORDER"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdePrecond"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomCdePrecond Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdePrecond entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EntCodeMdTypeIdSource	
			if (CanDeepLoad(entity, "EntCodeMdType|EntCodeMdTypeIdSource", deepLoadType, innerList) 
				&& entity.EntCodeMdTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntCodeMdTypeId ?? 0.0m);
				EntCodeMdType tmpEntity = EntityManager.LocateEntity<EntCodeMdType>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCodeMdType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCodeMdTypeIdSource = tmpEntity;
				else
					entity.EntCodeMdTypeIdSource = DataRepository.EntCodeMdTypeProvider.GetByEntCodeMdTypeId(transactionManager, (entity.EntCodeMdTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodeMdTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCodeMdTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCodeMdTypeProvider.DeepLoad(transactionManager, entity.EntCodeMdTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCodeMdTypeIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomCdePrecond object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomCdePrecond instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomCdePrecond Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdePrecond entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EntCodeMdTypeIdSource
			if (CanDeepSave(entity, "EntCodeMdType|EntCodeMdTypeIdSource", deepSaveType, innerList) 
				&& entity.EntCodeMdTypeIdSource != null)
			{
				DataRepository.EntCodeMdTypeProvider.Save(transactionManager, entity.EntCodeMdTypeIdSource);
				entity.EntCodeMdTypeId = entity.EntCodeMdTypeIdSource.EntCodeMdTypeId;
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
	
	#region AccomCdePrecondChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomCdePrecond</c>
	///</summary>
	public enum AccomCdePrecondChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EntCodeMdType</c> at EntCodeMdTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodeMdType))]
		EntCodeMdType,
	}
	
	#endregion AccomCdePrecondChildEntityTypes
	
	#region AccomCdePrecondFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomCdePrecondColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdePrecond"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomCdePrecondFilterBuilder : SqlFilterBuilder<AccomCdePrecondColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdePrecondFilterBuilder class.
		/// </summary>
		public AccomCdePrecondFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomCdePrecondFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomCdePrecondFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomCdePrecondFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomCdePrecondFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomCdePrecondFilterBuilder
	
	#region AccomCdePrecondParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomCdePrecondColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdePrecond"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomCdePrecondParameterBuilder : ParameterizedSqlFilterBuilder<AccomCdePrecondColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdePrecondParameterBuilder class.
		/// </summary>
		public AccomCdePrecondParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomCdePrecondParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomCdePrecondParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomCdePrecondParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomCdePrecondParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomCdePrecondParameterBuilder
	
	#region AccomCdePrecondSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomCdePrecondColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdePrecond"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomCdePrecondSortBuilder : SqlSortBuilder<AccomCdePrecondColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdePrecondSqlSortBuilder class.
		/// </summary>
		public AccomCdePrecondSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomCdePrecondSortBuilder
	
} // end namespace
