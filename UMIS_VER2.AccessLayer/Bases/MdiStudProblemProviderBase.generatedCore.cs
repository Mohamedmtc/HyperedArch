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
	/// This class is the base class for any <see cref="MdiStudProblemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MdiStudProblemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MdiStudProblem, UMIS_VER2.BusinessLyer.MdiStudProblemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudProblemKey key)
		{
			return Delete(transactionManager, key.MdiStudProblemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mdiStudProblemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mdiStudProblemId)
		{
			return Delete(null, _mdiStudProblemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudProblemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mdiStudProblemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_PROBLEM_ED_STUD key.
		///		FK_MDI_STUD_PROBLEM_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudProblem objects.</returns>
		public TList<MdiStudProblem> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_PROBLEM_ED_STUD key.
		///		FK_MDI_STUD_PROBLEM_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudProblem objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudProblem> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_PROBLEM_ED_STUD key.
		///		FK_MDI_STUD_PROBLEM_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudProblem objects.</returns>
		public TList<MdiStudProblem> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_PROBLEM_ED_STUD key.
		///		fkMdiStudProblemEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudProblem objects.</returns>
		public TList<MdiStudProblem> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_PROBLEM_ED_STUD key.
		///		fkMdiStudProblemEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudProblem objects.</returns>
		public TList<MdiStudProblem> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_PROBLEM_ED_STUD key.
		///		FK_MDI_STUD_PROBLEM_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudProblem objects.</returns>
		public abstract TList<MdiStudProblem> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_PROBLEM_MDI_CDE_PROBLEM key.
		///		FK_MDI_STUD_PROBLEM_MDI_CDE_PROBLEM Description: 
		/// </summary>
		/// <param name="_mdiCdeProblemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudProblem objects.</returns>
		public TList<MdiStudProblem> GetByMdiCdeProblemId(System.Decimal _mdiCdeProblemId)
		{
			int count = -1;
			return GetByMdiCdeProblemId(_mdiCdeProblemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_PROBLEM_MDI_CDE_PROBLEM key.
		///		FK_MDI_STUD_PROBLEM_MDI_CDE_PROBLEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeProblemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudProblem objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudProblem> GetByMdiCdeProblemId(TransactionManager transactionManager, System.Decimal _mdiCdeProblemId)
		{
			int count = -1;
			return GetByMdiCdeProblemId(transactionManager, _mdiCdeProblemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_PROBLEM_MDI_CDE_PROBLEM key.
		///		FK_MDI_STUD_PROBLEM_MDI_CDE_PROBLEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeProblemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudProblem objects.</returns>
		public TList<MdiStudProblem> GetByMdiCdeProblemId(TransactionManager transactionManager, System.Decimal _mdiCdeProblemId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeProblemId(transactionManager, _mdiCdeProblemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_PROBLEM_MDI_CDE_PROBLEM key.
		///		fkMdiStudProblemMdiCdeProblem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiCdeProblemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudProblem objects.</returns>
		public TList<MdiStudProblem> GetByMdiCdeProblemId(System.Decimal _mdiCdeProblemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMdiCdeProblemId(null, _mdiCdeProblemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_PROBLEM_MDI_CDE_PROBLEM key.
		///		fkMdiStudProblemMdiCdeProblem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiCdeProblemId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudProblem objects.</returns>
		public TList<MdiStudProblem> GetByMdiCdeProblemId(System.Decimal _mdiCdeProblemId, int start, int pageLength,out int count)
		{
			return GetByMdiCdeProblemId(null, _mdiCdeProblemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_PROBLEM_MDI_CDE_PROBLEM key.
		///		FK_MDI_STUD_PROBLEM_MDI_CDE_PROBLEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeProblemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudProblem objects.</returns>
		public abstract TList<MdiStudProblem> GetByMdiCdeProblemId(TransactionManager transactionManager, System.Decimal _mdiCdeProblemId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.MdiStudProblem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudProblemKey key, int start, int pageLength)
		{
			return GetByMdiStudProblemId(transactionManager, key.MdiStudProblemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MDI_STUD_PROBLEM index.
		/// </summary>
		/// <param name="_mdiStudProblemId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudProblem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudProblem GetByMdiStudProblemId(System.Decimal _mdiStudProblemId)
		{
			int count = -1;
			return GetByMdiStudProblemId(null,_mdiStudProblemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_PROBLEM index.
		/// </summary>
		/// <param name="_mdiStudProblemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudProblem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudProblem GetByMdiStudProblemId(System.Decimal _mdiStudProblemId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudProblemId(null, _mdiStudProblemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_PROBLEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudProblemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudProblem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudProblem GetByMdiStudProblemId(TransactionManager transactionManager, System.Decimal _mdiStudProblemId)
		{
			int count = -1;
			return GetByMdiStudProblemId(transactionManager, _mdiStudProblemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_PROBLEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudProblemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudProblem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudProblem GetByMdiStudProblemId(TransactionManager transactionManager, System.Decimal _mdiStudProblemId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudProblemId(transactionManager, _mdiStudProblemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_PROBLEM index.
		/// </summary>
		/// <param name="_mdiStudProblemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudProblem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudProblem GetByMdiStudProblemId(System.Decimal _mdiStudProblemId, int start, int pageLength, out int count)
		{
			return GetByMdiStudProblemId(null, _mdiStudProblemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_PROBLEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudProblemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudProblem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiStudProblem GetByMdiStudProblemId(TransactionManager transactionManager, System.Decimal _mdiStudProblemId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MdiStudProblem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MdiStudProblem&gt;"/></returns>
		public static TList<MdiStudProblem> Fill(IDataReader reader, TList<MdiStudProblem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MdiStudProblem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MdiStudProblem")
					.Append("|").Append((System.Decimal)reader["MDI_STUD_PROBLEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MdiStudProblem>(
					key.ToString(), // EntityTrackingKey
					"MdiStudProblem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MdiStudProblem();
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
					c.MdiStudProblemId = (System.Decimal)reader["MDI_STUD_PROBLEM_ID"];
					c.OriginalMdiStudProblemId = c.MdiStudProblemId;
					c.MdiCdeProblemId = (System.Decimal)reader["MDI_CDE_PROBLEM_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.PrblmDate = (System.DateTime)reader["PRBLM_DATE"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiStudProblem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudProblem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MdiStudProblem entity)
		{
			if (!reader.Read()) return;
			
			entity.MdiStudProblemId = (System.Decimal)reader[((int)MdiStudProblemColumn.MdiStudProblemId - 1)];
			entity.OriginalMdiStudProblemId = (System.Decimal)reader["MDI_STUD_PROBLEM_ID"];
			entity.MdiCdeProblemId = (System.Decimal)reader[((int)MdiStudProblemColumn.MdiCdeProblemId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)MdiStudProblemColumn.EdStudId - 1)];
			entity.PrblmDate = (System.DateTime)reader[((int)MdiStudProblemColumn.PrblmDate - 1)];
			entity.Notes = (reader.IsDBNull(((int)MdiStudProblemColumn.Notes - 1)))?null:(System.String)reader[((int)MdiStudProblemColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiStudProblem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudProblem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MdiStudProblem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MdiStudProblemId = (System.Decimal)dataRow["MDI_STUD_PROBLEM_ID"];
			entity.OriginalMdiStudProblemId = (System.Decimal)dataRow["MDI_STUD_PROBLEM_ID"];
			entity.MdiCdeProblemId = (System.Decimal)dataRow["MDI_CDE_PROBLEM_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.PrblmDate = (System.DateTime)dataRow["PRBLM_DATE"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudProblem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiStudProblem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudProblem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region MdiCdeProblemIdSource	
			if (CanDeepLoad(entity, "MdiCdeProblem|MdiCdeProblemIdSource", deepLoadType, innerList) 
				&& entity.MdiCdeProblemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MdiCdeProblemId;
				MdiCdeProblem tmpEntity = EntityManager.LocateEntity<MdiCdeProblem>(EntityLocator.ConstructKeyFromPkItems(typeof(MdiCdeProblem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MdiCdeProblemIdSource = tmpEntity;
				else
					entity.MdiCdeProblemIdSource = DataRepository.MdiCdeProblemProvider.GetByMdiCdeProblemId(transactionManager, entity.MdiCdeProblemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiCdeProblemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MdiCdeProblemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MdiCdeProblemProvider.DeepLoad(transactionManager, entity.MdiCdeProblemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MdiCdeProblemIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MdiStudProblem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MdiStudProblem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiStudProblem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudProblem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region MdiCdeProblemIdSource
			if (CanDeepSave(entity, "MdiCdeProblem|MdiCdeProblemIdSource", deepSaveType, innerList) 
				&& entity.MdiCdeProblemIdSource != null)
			{
				DataRepository.MdiCdeProblemProvider.Save(transactionManager, entity.MdiCdeProblemIdSource);
				entity.MdiCdeProblemId = entity.MdiCdeProblemIdSource.MdiCdeProblemId;
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
	
	#region MdiStudProblemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MdiStudProblem</c>
	///</summary>
	public enum MdiStudProblemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>MdiCdeProblem</c> at MdiCdeProblemIdSource
		///</summary>
		[ChildEntityType(typeof(MdiCdeProblem))]
		MdiCdeProblem,
	}
	
	#endregion MdiStudProblemChildEntityTypes
	
	#region MdiStudProblemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MdiStudProblemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudProblem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiStudProblemFilterBuilder : SqlFilterBuilder<MdiStudProblemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudProblemFilterBuilder class.
		/// </summary>
		public MdiStudProblemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiStudProblemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiStudProblemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiStudProblemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiStudProblemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiStudProblemFilterBuilder
	
	#region MdiStudProblemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MdiStudProblemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudProblem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiStudProblemParameterBuilder : ParameterizedSqlFilterBuilder<MdiStudProblemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudProblemParameterBuilder class.
		/// </summary>
		public MdiStudProblemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiStudProblemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiStudProblemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiStudProblemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiStudProblemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiStudProblemParameterBuilder
	
	#region MdiStudProblemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MdiStudProblemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudProblem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MdiStudProblemSortBuilder : SqlSortBuilder<MdiStudProblemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudProblemSqlSortBuilder class.
		/// </summary>
		public MdiStudProblemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MdiStudProblemSortBuilder
	
} // end namespace
