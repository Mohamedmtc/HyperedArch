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
	/// This class is the base class for any <see cref="GsCodeApprovalFuncProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeApprovalFuncProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeApprovalFunc, UMIS_VER2.BusinessLyer.GsCodeApprovalFuncKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApprovalFuncKey key)
		{
			return Delete(transactionManager, key.GsCodeApprovalFuncId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeApprovalFuncId">PG Function Approve. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeApprovalFuncId)
		{
			return Delete(null, _gsCodeApprovalFuncId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalFuncId">PG Function Approve. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeApprovalFuncId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_APPROVAL_FUNC_GS_CODE_SYS key.
		///		FK_GS_CODE_APPROVAL_FUNC_GS_CODE_SYS Description: 
		/// </summary>
		/// <param name="_gsCodeSysId">Currently Used in PG Fuctions</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApprovalFunc objects.</returns>
		public TList<GsCodeApprovalFunc> GetByGsCodeSysId(System.Decimal? _gsCodeSysId)
		{
			int count = -1;
			return GetByGsCodeSysId(_gsCodeSysId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_APPROVAL_FUNC_GS_CODE_SYS key.
		///		FK_GS_CODE_APPROVAL_FUNC_GS_CODE_SYS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeSysId">Currently Used in PG Fuctions</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApprovalFunc objects.</returns>
		/// <remarks></remarks>
		public TList<GsCodeApprovalFunc> GetByGsCodeSysId(TransactionManager transactionManager, System.Decimal? _gsCodeSysId)
		{
			int count = -1;
			return GetByGsCodeSysId(transactionManager, _gsCodeSysId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_APPROVAL_FUNC_GS_CODE_SYS key.
		///		FK_GS_CODE_APPROVAL_FUNC_GS_CODE_SYS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeSysId">Currently Used in PG Fuctions</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApprovalFunc objects.</returns>
		public TList<GsCodeApprovalFunc> GetByGsCodeSysId(TransactionManager transactionManager, System.Decimal? _gsCodeSysId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeSysId(transactionManager, _gsCodeSysId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_APPROVAL_FUNC_GS_CODE_SYS key.
		///		fkGsCodeApprovalFuncGsCodeSys Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeSysId">Currently Used in PG Fuctions</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApprovalFunc objects.</returns>
		public TList<GsCodeApprovalFunc> GetByGsCodeSysId(System.Decimal? _gsCodeSysId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeSysId(null, _gsCodeSysId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_APPROVAL_FUNC_GS_CODE_SYS key.
		///		fkGsCodeApprovalFuncGsCodeSys Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeSysId">Currently Used in PG Fuctions</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApprovalFunc objects.</returns>
		public TList<GsCodeApprovalFunc> GetByGsCodeSysId(System.Decimal? _gsCodeSysId, int start, int pageLength,out int count)
		{
			return GetByGsCodeSysId(null, _gsCodeSysId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_APPROVAL_FUNC_GS_CODE_SYS key.
		///		FK_GS_CODE_APPROVAL_FUNC_GS_CODE_SYS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeSysId">Currently Used in PG Fuctions</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApprovalFunc objects.</returns>
		public abstract TList<GsCodeApprovalFunc> GetByGsCodeSysId(TransactionManager transactionManager, System.Decimal? _gsCodeSysId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeApprovalFunc Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApprovalFuncKey key, int start, int pageLength)
		{
			return GetByGsCodeApprovalFuncId(transactionManager, key.GsCodeApprovalFuncId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_APPROVAL_FUNC index.
		/// </summary>
		/// <param name="_gsCodeApprovalFuncId">PG Function Approve</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFunc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalFunc GetByGsCodeApprovalFuncId(System.Decimal _gsCodeApprovalFuncId)
		{
			int count = -1;
			return GetByGsCodeApprovalFuncId(null,_gsCodeApprovalFuncId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_FUNC index.
		/// </summary>
		/// <param name="_gsCodeApprovalFuncId">PG Function Approve</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFunc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalFunc GetByGsCodeApprovalFuncId(System.Decimal _gsCodeApprovalFuncId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalFuncId(null, _gsCodeApprovalFuncId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_FUNC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalFuncId">PG Function Approve</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFunc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalFunc GetByGsCodeApprovalFuncId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalFuncId)
		{
			int count = -1;
			return GetByGsCodeApprovalFuncId(transactionManager, _gsCodeApprovalFuncId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_FUNC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalFuncId">PG Function Approve</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFunc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalFunc GetByGsCodeApprovalFuncId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalFuncId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalFuncId(transactionManager, _gsCodeApprovalFuncId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_FUNC index.
		/// </summary>
		/// <param name="_gsCodeApprovalFuncId">PG Function Approve</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFunc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalFunc GetByGsCodeApprovalFuncId(System.Decimal _gsCodeApprovalFuncId, int start, int pageLength, out int count)
		{
			return GetByGsCodeApprovalFuncId(null, _gsCodeApprovalFuncId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_FUNC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalFuncId">PG Function Approve</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFunc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeApprovalFunc GetByGsCodeApprovalFuncId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalFuncId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeApprovalFunc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeApprovalFunc&gt;"/></returns>
		public static TList<GsCodeApprovalFunc> Fill(IDataReader reader, TList<GsCodeApprovalFunc> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeApprovalFunc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeApprovalFunc")
					.Append("|").Append((System.Decimal)reader["GS_CODE_APPROVAL_FUNC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeApprovalFunc>(
					key.ToString(), // EntityTrackingKey
					"GsCodeApprovalFunc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeApprovalFunc();
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
					c.GsCodeApprovalFuncId = (System.Decimal)reader["GS_CODE_APPROVAL_FUNC_ID"];
					c.OriginalGsCodeApprovalFuncId = c.GsCodeApprovalFuncId;
					c.FuncDescrAr = (System.String)reader["FUNC_DESCR_AR"];
					c.FuncDescrEn = Convert.IsDBNull(reader["FUNC_DESCR_EN"]) ? null : (System.String)reader["FUNC_DESCR_EN"];
					c.GsCodeSysId = Convert.IsDBNull(reader["GS_CODE_SYS_ID"]) ? null : (System.Decimal?)reader["GS_CODE_SYS_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFunc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFunc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeApprovalFunc entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeApprovalFuncId = (System.Decimal)reader[((int)GsCodeApprovalFuncColumn.GsCodeApprovalFuncId - 1)];
			entity.OriginalGsCodeApprovalFuncId = (System.Decimal)reader["GS_CODE_APPROVAL_FUNC_ID"];
			entity.FuncDescrAr = (System.String)reader[((int)GsCodeApprovalFuncColumn.FuncDescrAr - 1)];
			entity.FuncDescrEn = (reader.IsDBNull(((int)GsCodeApprovalFuncColumn.FuncDescrEn - 1)))?null:(System.String)reader[((int)GsCodeApprovalFuncColumn.FuncDescrEn - 1)];
			entity.GsCodeSysId = (reader.IsDBNull(((int)GsCodeApprovalFuncColumn.GsCodeSysId - 1)))?null:(System.Decimal?)reader[((int)GsCodeApprovalFuncColumn.GsCodeSysId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFunc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFunc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeApprovalFunc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeApprovalFuncId = (System.Decimal)dataRow["GS_CODE_APPROVAL_FUNC_ID"];
			entity.OriginalGsCodeApprovalFuncId = (System.Decimal)dataRow["GS_CODE_APPROVAL_FUNC_ID"];
			entity.FuncDescrAr = (System.String)dataRow["FUNC_DESCR_AR"];
			entity.FuncDescrEn = Convert.IsDBNull(dataRow["FUNC_DESCR_EN"]) ? null : (System.String)dataRow["FUNC_DESCR_EN"];
			entity.GsCodeSysId = Convert.IsDBNull(dataRow["GS_CODE_SYS_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_SYS_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFunc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeApprovalFunc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApprovalFunc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCodeSysIdSource	
			if (CanDeepLoad(entity, "GsCodeSys|GsCodeSysIdSource", deepLoadType, innerList) 
				&& entity.GsCodeSysIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeSysId ?? 0.0m);
				GsCodeSys tmpEntity = EntityManager.LocateEntity<GsCodeSys>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeSys), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeSysIdSource = tmpEntity;
				else
					entity.GsCodeSysIdSource = DataRepository.GsCodeSysProvider.GetByGsCodeSysId(transactionManager, (entity.GsCodeSysId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeSysIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeSysIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeSysProvider.DeepLoad(transactionManager, entity.GsCodeSysIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeSysIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeApprovalFuncId methods when available
			
			#region GsCodeApprovalFacultyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCodeApprovalFaculty>|GsCodeApprovalFacultyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalFacultyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCodeApprovalFacultyCollection = DataRepository.GsCodeApprovalFacultyProvider.GetByGsCodeApprovalFuncId(transactionManager, entity.GsCodeApprovalFuncId);

				if (deep && entity.GsCodeApprovalFacultyCollection.Count > 0)
				{
					deepHandles.Add("GsCodeApprovalFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCodeApprovalFaculty>) DataRepository.GsCodeApprovalFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCodeApprovalFacultyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStudApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudApproveCollection = DataRepository.PgThesisStudApproveProvider.GetByGsCodeApprovalFuncId(transactionManager, entity.GsCodeApprovalFuncId);

				if (deep && entity.PgThesisStudApproveCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStudApprove>) DataRepository.PgThesisStudApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgAttchdDoc>|PgAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgAttchdDocCollection = DataRepository.PgAttchdDocProvider.GetByGsCodeApprovalFuncId(transactionManager, entity.GsCodeApprovalFuncId);

				if (deep && entity.PgAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("PgAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgAttchdDoc>) DataRepository.PgAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.PgAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeApprovalFunc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeApprovalFunc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeApprovalFunc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApprovalFunc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCodeSysIdSource
			if (CanDeepSave(entity, "GsCodeSys|GsCodeSysIdSource", deepSaveType, innerList) 
				&& entity.GsCodeSysIdSource != null)
			{
				DataRepository.GsCodeSysProvider.Save(transactionManager, entity.GsCodeSysIdSource);
				entity.GsCodeSysId = entity.GsCodeSysIdSource.GsCodeSysId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<GsCodeApprovalFaculty>
				if (CanDeepSave(entity.GsCodeApprovalFacultyCollection, "List<GsCodeApprovalFaculty>|GsCodeApprovalFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCodeApprovalFaculty child in entity.GsCodeApprovalFacultyCollection)
					{
						if(child.GsCodeApprovalFuncIdSource != null)
						{
							child.GsCodeApprovalFuncId = child.GsCodeApprovalFuncIdSource.GsCodeApprovalFuncId;
						}
						else
						{
							child.GsCodeApprovalFuncId = entity.GsCodeApprovalFuncId;
						}

					}

					if (entity.GsCodeApprovalFacultyCollection.Count > 0 || entity.GsCodeApprovalFacultyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCodeApprovalFacultyProvider.Save(transactionManager, entity.GsCodeApprovalFacultyCollection);
						
						deepHandles.Add("GsCodeApprovalFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCodeApprovalFaculty >) DataRepository.GsCodeApprovalFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.GsCodeApprovalFacultyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStudApprove>
				if (CanDeepSave(entity.PgThesisStudApproveCollection, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStudApprove child in entity.PgThesisStudApproveCollection)
					{
						if(child.GsCodeApprovalFuncIdSource != null)
						{
							child.GsCodeApprovalFuncId = child.GsCodeApprovalFuncIdSource.GsCodeApprovalFuncId;
						}
						else
						{
							child.GsCodeApprovalFuncId = entity.GsCodeApprovalFuncId;
						}

					}

					if (entity.PgThesisStudApproveCollection.Count > 0 || entity.PgThesisStudApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudApproveProvider.Save(transactionManager, entity.PgThesisStudApproveCollection);
						
						deepHandles.Add("PgThesisStudApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStudApprove >) DataRepository.PgThesisStudApproveProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgAttchdDoc>
				if (CanDeepSave(entity.PgAttchdDocCollection, "List<PgAttchdDoc>|PgAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgAttchdDoc child in entity.PgAttchdDocCollection)
					{
						if(child.GsCodeApprovalFuncIdSource != null)
						{
							child.GsCodeApprovalFuncId = child.GsCodeApprovalFuncIdSource.GsCodeApprovalFuncId;
						}
						else
						{
							child.GsCodeApprovalFuncId = entity.GsCodeApprovalFuncId;
						}

					}

					if (entity.PgAttchdDocCollection.Count > 0 || entity.PgAttchdDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgAttchdDocProvider.Save(transactionManager, entity.PgAttchdDocCollection);
						
						deepHandles.Add("PgAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgAttchdDoc >) DataRepository.PgAttchdDocProvider.DeepSave,
							new object[] { transactionManager, entity.PgAttchdDocCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCodeApprovalFuncChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeApprovalFunc</c>
	///</summary>
	public enum GsCodeApprovalFuncChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCodeSys</c> at GsCodeSysIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeSys))]
		GsCodeSys,
		///<summary>
		/// Collection of <c>GsCodeApprovalFunc</c> as OneToMany for GsCodeApprovalFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCodeApprovalFaculty>))]
		GsCodeApprovalFacultyCollection,
		///<summary>
		/// Collection of <c>GsCodeApprovalFunc</c> as OneToMany for PgThesisStudApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStudApprove>))]
		PgThesisStudApproveCollection,
		///<summary>
		/// Collection of <c>GsCodeApprovalFunc</c> as OneToMany for PgAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgAttchdDoc>))]
		PgAttchdDocCollection,
	}
	
	#endregion GsCodeApprovalFuncChildEntityTypes
	
	#region GsCodeApprovalFuncFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeApprovalFuncColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeApprovalFunc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeApprovalFuncFilterBuilder : SqlFilterBuilder<GsCodeApprovalFuncColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalFuncFilterBuilder class.
		/// </summary>
		public GsCodeApprovalFuncFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalFuncFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeApprovalFuncFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalFuncFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeApprovalFuncFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeApprovalFuncFilterBuilder
	
	#region GsCodeApprovalFuncParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeApprovalFuncColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeApprovalFunc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeApprovalFuncParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeApprovalFuncColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalFuncParameterBuilder class.
		/// </summary>
		public GsCodeApprovalFuncParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalFuncParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeApprovalFuncParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalFuncParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeApprovalFuncParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeApprovalFuncParameterBuilder
	
	#region GsCodeApprovalFuncSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeApprovalFuncColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeApprovalFunc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeApprovalFuncSortBuilder : SqlSortBuilder<GsCodeApprovalFuncColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalFuncSqlSortBuilder class.
		/// </summary>
		public GsCodeApprovalFuncSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeApprovalFuncSortBuilder
	
} // end namespace
