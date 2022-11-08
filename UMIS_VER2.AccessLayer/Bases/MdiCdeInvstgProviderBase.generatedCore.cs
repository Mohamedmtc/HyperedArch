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
	/// This class is the base class for any <see cref="MdiCdeInvstgProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MdiCdeInvstgProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MdiCdeInvstg, UMIS_VER2.BusinessLyer.MdiCdeInvstgKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeInvstgKey key)
		{
			return Delete(transactionManager, key.MdiCdeInvstgId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mdiCdeInvstgId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mdiCdeInvstgId)
		{
			return Delete(null, _mdiCdeInvstgId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeInvstgId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mdiCdeInvstgId);		
		
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
		public override UMIS_VER2.BusinessLyer.MdiCdeInvstg Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeInvstgKey key, int start, int pageLength)
		{
			return GetByMdiCdeInvstgId(transactionManager, key.MdiCdeInvstgId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MDI_CDE_INVSTG index.
		/// </summary>
		/// <param name="_mdiCdeInvstgId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeInvstg GetByMdiCdeInvstgId(System.Decimal _mdiCdeInvstgId)
		{
			int count = -1;
			return GetByMdiCdeInvstgId(null,_mdiCdeInvstgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_INVSTG index.
		/// </summary>
		/// <param name="_mdiCdeInvstgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeInvstg GetByMdiCdeInvstgId(System.Decimal _mdiCdeInvstgId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeInvstgId(null, _mdiCdeInvstgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_INVSTG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeInvstgId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeInvstg GetByMdiCdeInvstgId(TransactionManager transactionManager, System.Decimal _mdiCdeInvstgId)
		{
			int count = -1;
			return GetByMdiCdeInvstgId(transactionManager, _mdiCdeInvstgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_INVSTG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeInvstgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeInvstg GetByMdiCdeInvstgId(TransactionManager transactionManager, System.Decimal _mdiCdeInvstgId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeInvstgId(transactionManager, _mdiCdeInvstgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_INVSTG index.
		/// </summary>
		/// <param name="_mdiCdeInvstgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeInvstg GetByMdiCdeInvstgId(System.Decimal _mdiCdeInvstgId, int start, int pageLength, out int count)
		{
			return GetByMdiCdeInvstgId(null, _mdiCdeInvstgId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_INVSTG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeInvstgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeInvstg GetByMdiCdeInvstgId(TransactionManager transactionManager, System.Decimal _mdiCdeInvstgId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_CDE_INVSTG_AR index.
		/// </summary>
		/// <param name="_invstgAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeInvstg GetByInvstgAr(System.String _invstgAr)
		{
			int count = -1;
			return GetByInvstgAr(null,_invstgAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_INVSTG_AR index.
		/// </summary>
		/// <param name="_invstgAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeInvstg GetByInvstgAr(System.String _invstgAr, int start, int pageLength)
		{
			int count = -1;
			return GetByInvstgAr(null, _invstgAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_INVSTG_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_invstgAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeInvstg GetByInvstgAr(TransactionManager transactionManager, System.String _invstgAr)
		{
			int count = -1;
			return GetByInvstgAr(transactionManager, _invstgAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_INVSTG_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_invstgAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeInvstg GetByInvstgAr(TransactionManager transactionManager, System.String _invstgAr, int start, int pageLength)
		{
			int count = -1;
			return GetByInvstgAr(transactionManager, _invstgAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_INVSTG_AR index.
		/// </summary>
		/// <param name="_invstgAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeInvstg GetByInvstgAr(System.String _invstgAr, int start, int pageLength, out int count)
		{
			return GetByInvstgAr(null, _invstgAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_INVSTG_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_invstgAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeInvstg GetByInvstgAr(TransactionManager transactionManager, System.String _invstgAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_CDE_INVSTG_EN index.
		/// </summary>
		/// <param name="_invstgEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeInvstg GetByInvstgEn(System.String _invstgEn)
		{
			int count = -1;
			return GetByInvstgEn(null,_invstgEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_INVSTG_EN index.
		/// </summary>
		/// <param name="_invstgEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeInvstg GetByInvstgEn(System.String _invstgEn, int start, int pageLength)
		{
			int count = -1;
			return GetByInvstgEn(null, _invstgEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_INVSTG_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_invstgEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeInvstg GetByInvstgEn(TransactionManager transactionManager, System.String _invstgEn)
		{
			int count = -1;
			return GetByInvstgEn(transactionManager, _invstgEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_INVSTG_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_invstgEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeInvstg GetByInvstgEn(TransactionManager transactionManager, System.String _invstgEn, int start, int pageLength)
		{
			int count = -1;
			return GetByInvstgEn(transactionManager, _invstgEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_INVSTG_EN index.
		/// </summary>
		/// <param name="_invstgEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeInvstg GetByInvstgEn(System.String _invstgEn, int start, int pageLength, out int count)
		{
			return GetByInvstgEn(null, _invstgEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_INVSTG_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_invstgEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeInvstg GetByInvstgEn(TransactionManager transactionManager, System.String _invstgEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MdiCdeInvstg&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MdiCdeInvstg&gt;"/></returns>
		public static TList<MdiCdeInvstg> Fill(IDataReader reader, TList<MdiCdeInvstg> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MdiCdeInvstg c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MdiCdeInvstg")
					.Append("|").Append((System.Decimal)reader["MDI_CDE_INVSTG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MdiCdeInvstg>(
					key.ToString(), // EntityTrackingKey
					"MdiCdeInvstg",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MdiCdeInvstg();
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
					c.MdiCdeInvstgId = (System.Decimal)reader["MDI_CDE_INVSTG_ID"];
					c.OriginalMdiCdeInvstgId = c.MdiCdeInvstgId;
					c.InvstgAr = (System.String)reader["INVSTG_AR"];
					c.InvstgEn = (System.String)reader["INVSTG_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MdiCdeInvstg entity)
		{
			if (!reader.Read()) return;
			
			entity.MdiCdeInvstgId = (System.Decimal)reader[((int)MdiCdeInvstgColumn.MdiCdeInvstgId - 1)];
			entity.OriginalMdiCdeInvstgId = (System.Decimal)reader["MDI_CDE_INVSTG_ID"];
			entity.InvstgAr = (System.String)reader[((int)MdiCdeInvstgColumn.InvstgAr - 1)];
			entity.InvstgEn = (System.String)reader[((int)MdiCdeInvstgColumn.InvstgEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MdiCdeInvstg entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MdiCdeInvstgId = (System.Decimal)dataRow["MDI_CDE_INVSTG_ID"];
			entity.OriginalMdiCdeInvstgId = (System.Decimal)dataRow["MDI_CDE_INVSTG_ID"];
			entity.InvstgAr = (System.String)dataRow["INVSTG_AR"];
			entity.InvstgEn = (System.String)dataRow["INVSTG_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeInvstg"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiCdeInvstg Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeInvstg entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMdiCdeInvstgId methods when available
			
			#region MdiStudInvstgCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudInvstg>|MdiStudInvstgCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudInvstgCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudInvstgCollection = DataRepository.MdiStudInvstgProvider.GetByMdiCdeInvstgId(transactionManager, entity.MdiCdeInvstgId);

				if (deep && entity.MdiStudInvstgCollection.Count > 0)
				{
					deepHandles.Add("MdiStudInvstgCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudInvstg>) DataRepository.MdiStudInvstgProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudInvstgCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MdiCdeInvstg object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MdiCdeInvstg instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiCdeInvstg Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeInvstg entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<MdiStudInvstg>
				if (CanDeepSave(entity.MdiStudInvstgCollection, "List<MdiStudInvstg>|MdiStudInvstgCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudInvstg child in entity.MdiStudInvstgCollection)
					{
						if(child.MdiCdeInvstgIdSource != null)
						{
							child.MdiCdeInvstgId = child.MdiCdeInvstgIdSource.MdiCdeInvstgId;
						}
						else
						{
							child.MdiCdeInvstgId = entity.MdiCdeInvstgId;
						}

					}

					if (entity.MdiStudInvstgCollection.Count > 0 || entity.MdiStudInvstgCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudInvstgProvider.Save(transactionManager, entity.MdiStudInvstgCollection);
						
						deepHandles.Add("MdiStudInvstgCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudInvstg >) DataRepository.MdiStudInvstgProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudInvstgCollection, deepSaveType, childTypes, innerList }
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
	
	#region MdiCdeInvstgChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MdiCdeInvstg</c>
	///</summary>
	public enum MdiCdeInvstgChildEntityTypes
	{
		///<summary>
		/// Collection of <c>MdiCdeInvstg</c> as OneToMany for MdiStudInvstgCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudInvstg>))]
		MdiStudInvstgCollection,
	}
	
	#endregion MdiCdeInvstgChildEntityTypes
	
	#region MdiCdeInvstgFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MdiCdeInvstgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeInvstg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiCdeInvstgFilterBuilder : SqlFilterBuilder<MdiCdeInvstgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeInvstgFilterBuilder class.
		/// </summary>
		public MdiCdeInvstgFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeInvstgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiCdeInvstgFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeInvstgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiCdeInvstgFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiCdeInvstgFilterBuilder
	
	#region MdiCdeInvstgParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MdiCdeInvstgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeInvstg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiCdeInvstgParameterBuilder : ParameterizedSqlFilterBuilder<MdiCdeInvstgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeInvstgParameterBuilder class.
		/// </summary>
		public MdiCdeInvstgParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeInvstgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiCdeInvstgParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeInvstgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiCdeInvstgParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiCdeInvstgParameterBuilder
	
	#region MdiCdeInvstgSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MdiCdeInvstgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeInvstg"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MdiCdeInvstgSortBuilder : SqlSortBuilder<MdiCdeInvstgColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeInvstgSqlSortBuilder class.
		/// </summary>
		public MdiCdeInvstgSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MdiCdeInvstgSortBuilder
	
} // end namespace
