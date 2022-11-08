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
	/// This class is the base class for any <see cref="EntPolicyAssessGrpHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyAssessGrpHdrProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr, UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdrKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdrKey key)
		{
			return Delete(transactionManager, key.EntPolicyAssessGrpHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolicyAssessGrpHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _entPolicyAssessGrpHdrId)
		{
			return Delete(null, _entPolicyAssessGrpHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessGrpHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _entPolicyAssessGrpHdrId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_HDR_ENT_POLICY_ASSESS_HDR key.
		///		FK_ENT_POLICY_ASSESS_GRP_HDR_ENT_POLICY_ASSESS_HDR Description: 
		/// </summary>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr objects.</returns>
		public TList<EntPolicyAssessGrpHdr> GetByEntPolicyAssessHdrId(System.Decimal _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(_entPolicyAssessHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_HDR_ENT_POLICY_ASSESS_HDR key.
		///		FK_ENT_POLICY_ASSESS_GRP_HDR_ENT_POLICY_ASSESS_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyAssessGrpHdr> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(transactionManager, _entPolicyAssessHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_HDR_ENT_POLICY_ASSESS_HDR key.
		///		FK_ENT_POLICY_ASSESS_GRP_HDR_ENT_POLICY_ASSESS_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr objects.</returns>
		public TList<EntPolicyAssessGrpHdr> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(transactionManager, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_HDR_ENT_POLICY_ASSESS_HDR key.
		///		fkEntPolicyAssessGrpHdrEntPolicyAssessHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr objects.</returns>
		public TList<EntPolicyAssessGrpHdr> GetByEntPolicyAssessHdrId(System.Decimal _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntPolicyAssessHdrId(null, _entPolicyAssessHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_HDR_ENT_POLICY_ASSESS_HDR key.
		///		fkEntPolicyAssessGrpHdrEntPolicyAssessHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr objects.</returns>
		public TList<EntPolicyAssessGrpHdr> GetByEntPolicyAssessHdrId(System.Decimal _entPolicyAssessHdrId, int start, int pageLength,out int count)
		{
			return GetByEntPolicyAssessHdrId(null, _entPolicyAssessHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_HDR_ENT_POLICY_ASSESS_HDR key.
		///		FK_ENT_POLICY_ASSESS_GRP_HDR_ENT_POLICY_ASSESS_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr objects.</returns>
		public abstract TList<EntPolicyAssessGrpHdr> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal _entPolicyAssessHdrId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdrKey key, int start, int pageLength)
		{
			return GetByEntPolicyAssessGrpHdrId(transactionManager, key.EntPolicyAssessGrpHdrId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_POLICY_ASSESS_GRP_HDR index.
		/// </summary>
		/// <param name="_entPolicyAssessGrpHdrId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr GetByEntPolicyAssessGrpHdrId(System.Int32 _entPolicyAssessGrpHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessGrpHdrId(null,_entPolicyAssessGrpHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS_GRP_HDR index.
		/// </summary>
		/// <param name="_entPolicyAssessGrpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr GetByEntPolicyAssessGrpHdrId(System.Int32 _entPolicyAssessGrpHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessGrpHdrId(null, _entPolicyAssessGrpHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS_GRP_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessGrpHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr GetByEntPolicyAssessGrpHdrId(TransactionManager transactionManager, System.Int32 _entPolicyAssessGrpHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessGrpHdrId(transactionManager, _entPolicyAssessGrpHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS_GRP_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessGrpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr GetByEntPolicyAssessGrpHdrId(TransactionManager transactionManager, System.Int32 _entPolicyAssessGrpHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessGrpHdrId(transactionManager, _entPolicyAssessGrpHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS_GRP_HDR index.
		/// </summary>
		/// <param name="_entPolicyAssessGrpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr GetByEntPolicyAssessGrpHdrId(System.Int32 _entPolicyAssessGrpHdrId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyAssessGrpHdrId(null, _entPolicyAssessGrpHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS_GRP_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessGrpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr GetByEntPolicyAssessGrpHdrId(TransactionManager transactionManager, System.Int32 _entPolicyAssessGrpHdrId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolicyAssessGrpHdr&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolicyAssessGrpHdr&gt;"/></returns>
		public static TList<EntPolicyAssessGrpHdr> Fill(IDataReader reader, TList<EntPolicyAssessGrpHdr> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolicyAssessGrpHdr")
					.Append("|").Append((System.Int32)reader["ENT_POLICY_ASSESS_GRP_HDR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolicyAssessGrpHdr>(
					key.ToString(), // EntityTrackingKey
					"EntPolicyAssessGrpHdr",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr();
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
					c.EntPolicyAssessGrpHdrId = (System.Int32)reader["ENT_POLICY_ASSESS_GRP_HDR_ID"];
					c.OriginalEntPolicyAssessGrpHdrId = c.EntPolicyAssessGrpHdrId;
					c.EntPolicyAssessHdrId = (System.Decimal)reader["ENT_POLICY_ASSESS_HDR_ID"];
					c.GrpDescrAr = Convert.IsDBNull(reader["GRP_DESCR_AR"]) ? null : (System.String)reader["GRP_DESCR_AR"];
					c.GrpDescrEn = Convert.IsDBNull(reader["GRP_DESCR_EN"]) ? null : (System.String)reader["GRP_DESCR_EN"];
					c.MinMark = Convert.IsDBNull(reader["MIN_MARK"]) ? null : (System.Decimal?)reader["MIN_MARK"];
					c.MaxMark = Convert.IsDBNull(reader["MAX_MARK"]) ? null : (System.Decimal?)reader["MAX_MARK"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolicyAssessGrpHdrId = (System.Int32)reader[((int)EntPolicyAssessGrpHdrColumn.EntPolicyAssessGrpHdrId - 1)];
			entity.OriginalEntPolicyAssessGrpHdrId = (System.Int32)reader["ENT_POLICY_ASSESS_GRP_HDR_ID"];
			entity.EntPolicyAssessHdrId = (System.Decimal)reader[((int)EntPolicyAssessGrpHdrColumn.EntPolicyAssessHdrId - 1)];
			entity.GrpDescrAr = (reader.IsDBNull(((int)EntPolicyAssessGrpHdrColumn.GrpDescrAr - 1)))?null:(System.String)reader[((int)EntPolicyAssessGrpHdrColumn.GrpDescrAr - 1)];
			entity.GrpDescrEn = (reader.IsDBNull(((int)EntPolicyAssessGrpHdrColumn.GrpDescrEn - 1)))?null:(System.String)reader[((int)EntPolicyAssessGrpHdrColumn.GrpDescrEn - 1)];
			entity.MinMark = (reader.IsDBNull(((int)EntPolicyAssessGrpHdrColumn.MinMark - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAssessGrpHdrColumn.MinMark - 1)];
			entity.MaxMark = (reader.IsDBNull(((int)EntPolicyAssessGrpHdrColumn.MaxMark - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAssessGrpHdrColumn.MaxMark - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolicyAssessGrpHdrId = (System.Int32)dataRow["ENT_POLICY_ASSESS_GRP_HDR_ID"];
			entity.OriginalEntPolicyAssessGrpHdrId = (System.Int32)dataRow["ENT_POLICY_ASSESS_GRP_HDR_ID"];
			entity.EntPolicyAssessHdrId = (System.Decimal)dataRow["ENT_POLICY_ASSESS_HDR_ID"];
			entity.GrpDescrAr = Convert.IsDBNull(dataRow["GRP_DESCR_AR"]) ? null : (System.String)dataRow["GRP_DESCR_AR"];
			entity.GrpDescrEn = Convert.IsDBNull(dataRow["GRP_DESCR_EN"]) ? null : (System.String)dataRow["GRP_DESCR_EN"];
			entity.MinMark = Convert.IsDBNull(dataRow["MIN_MARK"]) ? null : (System.Decimal?)dataRow["MIN_MARK"];
			entity.MaxMark = Convert.IsDBNull(dataRow["MAX_MARK"]) ? null : (System.Decimal?)dataRow["MAX_MARK"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EntPolicyAssessHdrIdSource	
			if (CanDeepLoad(entity, "EntPolicyAssessHdr|EntPolicyAssessHdrIdSource", deepLoadType, innerList) 
				&& entity.EntPolicyAssessHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntPolicyAssessHdrId;
				EntPolicyAssessHdr tmpEntity = EntityManager.LocateEntity<EntPolicyAssessHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EntPolicyAssessHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntPolicyAssessHdrIdSource = tmpEntity;
				else
					entity.EntPolicyAssessHdrIdSource = DataRepository.EntPolicyAssessHdrProvider.GetByEntPolicyAssessHdrId(transactionManager, entity.EntPolicyAssessHdrId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAssessHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntPolicyAssessHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntPolicyAssessHdrProvider.DeepLoad(transactionManager, entity.EntPolicyAssessHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntPolicyAssessHdrIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntPolicyAssessGrpHdrId methods when available
			
			#region EntPolicyAssessGrpDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyAssessGrpDtl>|EntPolicyAssessGrpDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAssessGrpDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyAssessGrpDtlCollection = DataRepository.EntPolicyAssessGrpDtlProvider.GetByEntPolicyAssessGrpHdrId(transactionManager, entity.EntPolicyAssessGrpHdrId);

				if (deep && entity.EntPolicyAssessGrpDtlCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyAssessGrpDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyAssessGrpDtl>) DataRepository.EntPolicyAssessGrpDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyAssessGrpDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EntPolicyAssessHdrIdSource
			if (CanDeepSave(entity, "EntPolicyAssessHdr|EntPolicyAssessHdrIdSource", deepSaveType, innerList) 
				&& entity.EntPolicyAssessHdrIdSource != null)
			{
				DataRepository.EntPolicyAssessHdrProvider.Save(transactionManager, entity.EntPolicyAssessHdrIdSource);
				entity.EntPolicyAssessHdrId = entity.EntPolicyAssessHdrIdSource.EntPolicyAssessHdrId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EntPolicyAssessGrpDtl>
				if (CanDeepSave(entity.EntPolicyAssessGrpDtlCollection, "List<EntPolicyAssessGrpDtl>|EntPolicyAssessGrpDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyAssessGrpDtl child in entity.EntPolicyAssessGrpDtlCollection)
					{
						if(child.EntPolicyAssessGrpHdrIdSource != null)
						{
							child.EntPolicyAssessGrpHdrId = child.EntPolicyAssessGrpHdrIdSource.EntPolicyAssessGrpHdrId;
						}
						else
						{
							child.EntPolicyAssessGrpHdrId = entity.EntPolicyAssessGrpHdrId;
						}

					}

					if (entity.EntPolicyAssessGrpDtlCollection.Count > 0 || entity.EntPolicyAssessGrpDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyAssessGrpDtlProvider.Save(transactionManager, entity.EntPolicyAssessGrpDtlCollection);
						
						deepHandles.Add("EntPolicyAssessGrpDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyAssessGrpDtl >) DataRepository.EntPolicyAssessGrpDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyAssessGrpDtlCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntPolicyAssessGrpHdrChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr</c>
	///</summary>
	public enum EntPolicyAssessGrpHdrChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EntPolicyAssessHdr</c> at EntPolicyAssessHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EntPolicyAssessHdr))]
		EntPolicyAssessHdr,
		///<summary>
		/// Collection of <c>EntPolicyAssessGrpHdr</c> as OneToMany for EntPolicyAssessGrpDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyAssessGrpDtl>))]
		EntPolicyAssessGrpDtlCollection,
	}
	
	#endregion EntPolicyAssessGrpHdrChildEntityTypes
	
	#region EntPolicyAssessGrpHdrFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolicyAssessGrpHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyAssessGrpHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyAssessGrpHdrFilterBuilder : SqlFilterBuilder<EntPolicyAssessGrpHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessGrpHdrFilterBuilder class.
		/// </summary>
		public EntPolicyAssessGrpHdrFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessGrpHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyAssessGrpHdrFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessGrpHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyAssessGrpHdrFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyAssessGrpHdrFilterBuilder
	
	#region EntPolicyAssessGrpHdrParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolicyAssessGrpHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyAssessGrpHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyAssessGrpHdrParameterBuilder : ParameterizedSqlFilterBuilder<EntPolicyAssessGrpHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessGrpHdrParameterBuilder class.
		/// </summary>
		public EntPolicyAssessGrpHdrParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessGrpHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyAssessGrpHdrParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessGrpHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyAssessGrpHdrParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyAssessGrpHdrParameterBuilder
	
	#region EntPolicyAssessGrpHdrSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolicyAssessGrpHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyAssessGrpHdr"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolicyAssessGrpHdrSortBuilder : SqlSortBuilder<EntPolicyAssessGrpHdrColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessGrpHdrSqlSortBuilder class.
		/// </summary>
		public EntPolicyAssessGrpHdrSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolicyAssessGrpHdrSortBuilder
	
} // end namespace
