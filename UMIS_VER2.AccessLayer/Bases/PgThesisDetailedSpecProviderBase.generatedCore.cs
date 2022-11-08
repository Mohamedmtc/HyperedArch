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
	/// This class is the base class for any <see cref="PgThesisDetailedSpecProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisDetailedSpecProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisDetailedSpec, UMIS_VER2.BusinessLyer.PgThesisDetailedSpecKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisDetailedSpecKey key)
		{
			return Delete(transactionManager, key.PgThesisDetailedSpecId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisDetailedSpecId">xxx. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisDetailedSpecId)
		{
			return Delete(null, _pgThesisDetailedSpecId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisDetailedSpecId">xxx. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisDetailedSpecId);		
		
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
		public override UMIS_VER2.BusinessLyer.PgThesisDetailedSpec Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisDetailedSpecKey key, int start, int pageLength)
		{
			return GetByPgThesisDetailedSpecId(transactionManager, key.PgThesisDetailedSpecId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_PG_THESIS_GENERAL_SP_1 index.
		/// </summary>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;PgThesisDetailedSpec&gt;"/> class.</returns>
		public TList<PgThesisDetailedSpec> GetByPgThesisGeneralSpecId(System.Decimal _pgThesisGeneralSpecId)
		{
			int count = -1;
			return GetByPgThesisGeneralSpecId(null,_pgThesisGeneralSpecId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_PG_THESIS_GENERAL_SP_1 index.
		/// </summary>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;PgThesisDetailedSpec&gt;"/> class.</returns>
		public TList<PgThesisDetailedSpec> GetByPgThesisGeneralSpecId(System.Decimal _pgThesisGeneralSpecId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisGeneralSpecId(null, _pgThesisGeneralSpecId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_PG_THESIS_GENERAL_SP_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;PgThesisDetailedSpec&gt;"/> class.</returns>
		public TList<PgThesisDetailedSpec> GetByPgThesisGeneralSpecId(TransactionManager transactionManager, System.Decimal _pgThesisGeneralSpecId)
		{
			int count = -1;
			return GetByPgThesisGeneralSpecId(transactionManager, _pgThesisGeneralSpecId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_PG_THESIS_GENERAL_SP_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;PgThesisDetailedSpec&gt;"/> class.</returns>
		public TList<PgThesisDetailedSpec> GetByPgThesisGeneralSpecId(TransactionManager transactionManager, System.Decimal _pgThesisGeneralSpecId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisGeneralSpecId(transactionManager, _pgThesisGeneralSpecId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_PG_THESIS_GENERAL_SP_1 index.
		/// </summary>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;PgThesisDetailedSpec&gt;"/> class.</returns>
		public TList<PgThesisDetailedSpec> GetByPgThesisGeneralSpecId(System.Decimal _pgThesisGeneralSpecId, int start, int pageLength, out int count)
		{
			return GetByPgThesisGeneralSpecId(null, _pgThesisGeneralSpecId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_PG_THESIS_GENERAL_SP_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;PgThesisDetailedSpec&gt;"/> class.</returns>
		public abstract TList<PgThesisDetailedSpec> GetByPgThesisGeneralSpecId(TransactionManager transactionManager, System.Decimal _pgThesisGeneralSpecId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_DETAILED_SPEC index.
		/// </summary>
		/// <param name="_pgThesisDetailedSpecId">xxx</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisDetailedSpec"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisDetailedSpec GetByPgThesisDetailedSpecId(System.Decimal _pgThesisDetailedSpecId)
		{
			int count = -1;
			return GetByPgThesisDetailedSpecId(null,_pgThesisDetailedSpecId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_DETAILED_SPEC index.
		/// </summary>
		/// <param name="_pgThesisDetailedSpecId">xxx</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisDetailedSpec"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisDetailedSpec GetByPgThesisDetailedSpecId(System.Decimal _pgThesisDetailedSpecId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisDetailedSpecId(null, _pgThesisDetailedSpecId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_DETAILED_SPEC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisDetailedSpecId">xxx</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisDetailedSpec"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisDetailedSpec GetByPgThesisDetailedSpecId(TransactionManager transactionManager, System.Decimal _pgThesisDetailedSpecId)
		{
			int count = -1;
			return GetByPgThesisDetailedSpecId(transactionManager, _pgThesisDetailedSpecId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_DETAILED_SPEC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisDetailedSpecId">xxx</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisDetailedSpec"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisDetailedSpec GetByPgThesisDetailedSpecId(TransactionManager transactionManager, System.Decimal _pgThesisDetailedSpecId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisDetailedSpecId(transactionManager, _pgThesisDetailedSpecId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_DETAILED_SPEC index.
		/// </summary>
		/// <param name="_pgThesisDetailedSpecId">xxx</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisDetailedSpec"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisDetailedSpec GetByPgThesisDetailedSpecId(System.Decimal _pgThesisDetailedSpecId, int start, int pageLength, out int count)
		{
			return GetByPgThesisDetailedSpecId(null, _pgThesisDetailedSpecId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_DETAILED_SPEC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisDetailedSpecId">xxx</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisDetailedSpec"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisDetailedSpec GetByPgThesisDetailedSpecId(TransactionManager transactionManager, System.Decimal _pgThesisDetailedSpecId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisDetailedSpec&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisDetailedSpec&gt;"/></returns>
		public static TList<PgThesisDetailedSpec> Fill(IDataReader reader, TList<PgThesisDetailedSpec> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgThesisDetailedSpec c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisDetailedSpec")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_DETAILED_SPEC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisDetailedSpec>(
					key.ToString(), // EntityTrackingKey
					"PgThesisDetailedSpec",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisDetailedSpec();
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
					c.PgThesisDetailedSpecId = (System.Decimal)reader["PG_THESIS_DETAILED_SPEC_ID"];
					c.OriginalPgThesisDetailedSpecId = c.PgThesisDetailedSpecId;
					c.PgThesisGeneralSpecId = (System.Decimal)reader["PG_THESIS_GENERAL_SPEC_ID"];
					c.DetailedSpecCode = Convert.IsDBNull(reader["DETAILED_SPEC_CODE"]) ? null : (System.String)reader["DETAILED_SPEC_CODE"];
					c.DetailedSpecDescAr = (System.String)reader["DETAILED_SPEC_DESC_AR"];
					c.DetailedSpecDescEn = Convert.IsDBNull(reader["DETAILED_SPEC_DESC_EN"]) ? null : (System.String)reader["DETAILED_SPEC_DESC_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisDetailedSpec"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisDetailedSpec"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisDetailedSpec entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisDetailedSpecId = (System.Decimal)reader[((int)PgThesisDetailedSpecColumn.PgThesisDetailedSpecId - 1)];
			entity.OriginalPgThesisDetailedSpecId = (System.Decimal)reader["PG_THESIS_DETAILED_SPEC_ID"];
			entity.PgThesisGeneralSpecId = (System.Decimal)reader[((int)PgThesisDetailedSpecColumn.PgThesisGeneralSpecId - 1)];
			entity.DetailedSpecCode = (reader.IsDBNull(((int)PgThesisDetailedSpecColumn.DetailedSpecCode - 1)))?null:(System.String)reader[((int)PgThesisDetailedSpecColumn.DetailedSpecCode - 1)];
			entity.DetailedSpecDescAr = (System.String)reader[((int)PgThesisDetailedSpecColumn.DetailedSpecDescAr - 1)];
			entity.DetailedSpecDescEn = (reader.IsDBNull(((int)PgThesisDetailedSpecColumn.DetailedSpecDescEn - 1)))?null:(System.String)reader[((int)PgThesisDetailedSpecColumn.DetailedSpecDescEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisDetailedSpec"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisDetailedSpec"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisDetailedSpec entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisDetailedSpecId = (System.Decimal)dataRow["PG_THESIS_DETAILED_SPEC_ID"];
			entity.OriginalPgThesisDetailedSpecId = (System.Decimal)dataRow["PG_THESIS_DETAILED_SPEC_ID"];
			entity.PgThesisGeneralSpecId = (System.Decimal)dataRow["PG_THESIS_GENERAL_SPEC_ID"];
			entity.DetailedSpecCode = Convert.IsDBNull(dataRow["DETAILED_SPEC_CODE"]) ? null : (System.String)dataRow["DETAILED_SPEC_CODE"];
			entity.DetailedSpecDescAr = (System.String)dataRow["DETAILED_SPEC_DESC_AR"];
			entity.DetailedSpecDescEn = Convert.IsDBNull(dataRow["DETAILED_SPEC_DESC_EN"]) ? null : (System.String)dataRow["DETAILED_SPEC_DESC_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisDetailedSpec"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisDetailedSpec Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisDetailedSpec entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region PgThesisGeneralSpecIdSource	
			if (CanDeepLoad(entity, "PgThesisGeneralSpec|PgThesisGeneralSpecIdSource", deepLoadType, innerList) 
				&& entity.PgThesisGeneralSpecIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgThesisGeneralSpecId;
				PgThesisGeneralSpec tmpEntity = EntityManager.LocateEntity<PgThesisGeneralSpec>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisGeneralSpec), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisGeneralSpecIdSource = tmpEntity;
				else
					entity.PgThesisGeneralSpecIdSource = DataRepository.PgThesisGeneralSpecProvider.GetByPgThesisGeneralSpecId(transactionManager, entity.PgThesisGeneralSpecId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisGeneralSpecIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisGeneralSpecIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisGeneralSpecProvider.DeepLoad(transactionManager, entity.PgThesisGeneralSpecIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisGeneralSpecIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgThesisDetailedSpecId methods when available
			
			#region SaStfMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaStfMember>|SaStfMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaStfMemberCollection = DataRepository.SaStfMemberProvider.GetByPgThesisDetailedSpecId(transactionManager, entity.PgThesisDetailedSpecId);

				if (deep && entity.SaStfMemberCollection.Count > 0)
				{
					deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfMember>) DataRepository.SaStfMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaScQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaScQual>|SaScQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaScQualCollection = DataRepository.SaScQualProvider.GetByPgThesisDetailedSpecId(transactionManager, entity.PgThesisDetailedSpecId);

				if (deep && entity.SaScQualCollection.Count > 0)
				{
					deepHandles.Add("SaScQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaScQual>) DataRepository.SaScQualProvider.DeepLoad,
						new object[] { transactionManager, entity.SaScQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaEmploymentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaEmployment>|SaEmploymentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaEmploymentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaEmploymentCollection = DataRepository.SaEmploymentProvider.GetByPgThesisDetailedSpecId(transactionManager, entity.PgThesisDetailedSpecId);

				if (deep && entity.SaEmploymentCollection.Count > 0)
				{
					deepHandles.Add("SaEmploymentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaEmployment>) DataRepository.SaEmploymentProvider.DeepLoad,
						new object[] { transactionManager, entity.SaEmploymentCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisDetailedSpec object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisDetailedSpec instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisDetailedSpec Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisDetailedSpec entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region PgThesisGeneralSpecIdSource
			if (CanDeepSave(entity, "PgThesisGeneralSpec|PgThesisGeneralSpecIdSource", deepSaveType, innerList) 
				&& entity.PgThesisGeneralSpecIdSource != null)
			{
				DataRepository.PgThesisGeneralSpecProvider.Save(transactionManager, entity.PgThesisGeneralSpecIdSource);
				entity.PgThesisGeneralSpecId = entity.PgThesisGeneralSpecIdSource.PgThesisGeneralSpecId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaStfMember>
				if (CanDeepSave(entity.SaStfMemberCollection, "List<SaStfMember>|SaStfMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaStfMember child in entity.SaStfMemberCollection)
					{
						if(child.PgThesisDetailedSpecIdSource != null)
						{
							child.PgThesisDetailedSpecId = child.PgThesisDetailedSpecIdSource.PgThesisDetailedSpecId;
						}
						else
						{
							child.PgThesisDetailedSpecId = entity.PgThesisDetailedSpecId;
						}

					}

					if (entity.SaStfMemberCollection.Count > 0 || entity.SaStfMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberCollection);
						
						deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaStfMember >) DataRepository.SaStfMemberProvider.DeepSave,
							new object[] { transactionManager, entity.SaStfMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaScQual>
				if (CanDeepSave(entity.SaScQualCollection, "List<SaScQual>|SaScQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaScQual child in entity.SaScQualCollection)
					{
						if(child.PgThesisDetailedSpecIdSource != null)
						{
							child.PgThesisDetailedSpecId = child.PgThesisDetailedSpecIdSource.PgThesisDetailedSpecId;
						}
						else
						{
							child.PgThesisDetailedSpecId = entity.PgThesisDetailedSpecId;
						}

					}

					if (entity.SaScQualCollection.Count > 0 || entity.SaScQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaScQualProvider.Save(transactionManager, entity.SaScQualCollection);
						
						deepHandles.Add("SaScQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaScQual >) DataRepository.SaScQualProvider.DeepSave,
							new object[] { transactionManager, entity.SaScQualCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaEmployment>
				if (CanDeepSave(entity.SaEmploymentCollection, "List<SaEmployment>|SaEmploymentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaEmployment child in entity.SaEmploymentCollection)
					{
						if(child.PgThesisDetailedSpecIdSource != null)
						{
							child.PgThesisDetailedSpecId = child.PgThesisDetailedSpecIdSource.PgThesisDetailedSpecId;
						}
						else
						{
							child.PgThesisDetailedSpecId = entity.PgThesisDetailedSpecId;
						}

					}

					if (entity.SaEmploymentCollection.Count > 0 || entity.SaEmploymentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaEmploymentProvider.Save(transactionManager, entity.SaEmploymentCollection);
						
						deepHandles.Add("SaEmploymentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaEmployment >) DataRepository.SaEmploymentProvider.DeepSave,
							new object[] { transactionManager, entity.SaEmploymentCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgThesisDetailedSpecChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisDetailedSpec</c>
	///</summary>
	public enum PgThesisDetailedSpecChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>PgThesisGeneralSpec</c> at PgThesisGeneralSpecIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisGeneralSpec))]
		PgThesisGeneralSpec,
		///<summary>
		/// Collection of <c>PgThesisDetailedSpec</c> as OneToMany for SaStfMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfMember>))]
		SaStfMemberCollection,
		///<summary>
		/// Collection of <c>PgThesisDetailedSpec</c> as OneToMany for SaScQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaScQual>))]
		SaScQualCollection,
		///<summary>
		/// Collection of <c>PgThesisDetailedSpec</c> as OneToMany for SaEmploymentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaEmployment>))]
		SaEmploymentCollection,
	}
	
	#endregion PgThesisDetailedSpecChildEntityTypes
	
	#region PgThesisDetailedSpecFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisDetailedSpecColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisDetailedSpec"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisDetailedSpecFilterBuilder : SqlFilterBuilder<PgThesisDetailedSpecColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisDetailedSpecFilterBuilder class.
		/// </summary>
		public PgThesisDetailedSpecFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisDetailedSpecFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisDetailedSpecFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisDetailedSpecFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisDetailedSpecFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisDetailedSpecFilterBuilder
	
	#region PgThesisDetailedSpecParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisDetailedSpecColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisDetailedSpec"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisDetailedSpecParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisDetailedSpecColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisDetailedSpecParameterBuilder class.
		/// </summary>
		public PgThesisDetailedSpecParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisDetailedSpecParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisDetailedSpecParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisDetailedSpecParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisDetailedSpecParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisDetailedSpecParameterBuilder
	
	#region PgThesisDetailedSpecSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisDetailedSpecColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisDetailedSpec"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisDetailedSpecSortBuilder : SqlSortBuilder<PgThesisDetailedSpecColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisDetailedSpecSqlSortBuilder class.
		/// </summary>
		public PgThesisDetailedSpecSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisDetailedSpecSortBuilder
	
} // end namespace
