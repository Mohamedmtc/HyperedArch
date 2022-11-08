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
	/// This class is the base class for any <see cref="PgSubjectDefinitionProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgSubjectDefinitionProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgSubjectDefinition, UMIS_VER2.BusinessLyer.PgSubjectDefinitionKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgSubjectDefinitionKey key)
		{
			return Delete(transactionManager, key.PgSubjectDefinitionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgSubjectDefinitionId">XX not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgSubjectDefinitionId)
		{
			return Delete(null, _pgSubjectDefinitionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgSubjectDefinitionId">XX not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgSubjectDefinitionId);		
		
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
		public override UMIS_VER2.BusinessLyer.PgSubjectDefinition Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgSubjectDefinitionKey key, int start, int pageLength)
		{
			return GetByPgSubjectDefinitionId(transactionManager, key.PgSubjectDefinitionId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_PG_SUBJECT_DEFINITION index.
		/// </summary>
		/// <param name="_asNodeId"></param>
		/// <param name="_subjectDefAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgSubjectDefinition"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgSubjectDefinition GetByAsNodeIdSubjectDefAr(System.Decimal _asNodeId, System.String _subjectDefAr)
		{
			int count = -1;
			return GetByAsNodeIdSubjectDefAr(null,_asNodeId, _subjectDefAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_PG_SUBJECT_DEFINITION index.
		/// </summary>
		/// <param name="_asNodeId"></param>
		/// <param name="_subjectDefAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgSubjectDefinition"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgSubjectDefinition GetByAsNodeIdSubjectDefAr(System.Decimal _asNodeId, System.String _subjectDefAr, int start, int pageLength)
		{
			int count = -1;
			return GetByAsNodeIdSubjectDefAr(null, _asNodeId, _subjectDefAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_PG_SUBJECT_DEFINITION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <param name="_subjectDefAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgSubjectDefinition"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgSubjectDefinition GetByAsNodeIdSubjectDefAr(TransactionManager transactionManager, System.Decimal _asNodeId, System.String _subjectDefAr)
		{
			int count = -1;
			return GetByAsNodeIdSubjectDefAr(transactionManager, _asNodeId, _subjectDefAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_PG_SUBJECT_DEFINITION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <param name="_subjectDefAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgSubjectDefinition"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgSubjectDefinition GetByAsNodeIdSubjectDefAr(TransactionManager transactionManager, System.Decimal _asNodeId, System.String _subjectDefAr, int start, int pageLength)
		{
			int count = -1;
			return GetByAsNodeIdSubjectDefAr(transactionManager, _asNodeId, _subjectDefAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_PG_SUBJECT_DEFINITION index.
		/// </summary>
		/// <param name="_asNodeId"></param>
		/// <param name="_subjectDefAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgSubjectDefinition"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgSubjectDefinition GetByAsNodeIdSubjectDefAr(System.Decimal _asNodeId, System.String _subjectDefAr, int start, int pageLength, out int count)
		{
			return GetByAsNodeIdSubjectDefAr(null, _asNodeId, _subjectDefAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_PG_SUBJECT_DEFINITION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <param name="_subjectDefAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgSubjectDefinition"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgSubjectDefinition GetByAsNodeIdSubjectDefAr(TransactionManager transactionManager, System.Decimal _asNodeId, System.String _subjectDefAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_PG_CODE_RESEARCH_STR_1 index.
		/// </summary>
		/// <param name="_pgCodeResearchStrategyId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;PgSubjectDefinition&gt;"/> class.</returns>
		public TList<PgSubjectDefinition> GetByPgCodeResearchStrategyId(System.Decimal _pgCodeResearchStrategyId)
		{
			int count = -1;
			return GetByPgCodeResearchStrategyId(null,_pgCodeResearchStrategyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_PG_CODE_RESEARCH_STR_1 index.
		/// </summary>
		/// <param name="_pgCodeResearchStrategyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;PgSubjectDefinition&gt;"/> class.</returns>
		public TList<PgSubjectDefinition> GetByPgCodeResearchStrategyId(System.Decimal _pgCodeResearchStrategyId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCodeResearchStrategyId(null, _pgCodeResearchStrategyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_PG_CODE_RESEARCH_STR_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeResearchStrategyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;PgSubjectDefinition&gt;"/> class.</returns>
		public TList<PgSubjectDefinition> GetByPgCodeResearchStrategyId(TransactionManager transactionManager, System.Decimal _pgCodeResearchStrategyId)
		{
			int count = -1;
			return GetByPgCodeResearchStrategyId(transactionManager, _pgCodeResearchStrategyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_PG_CODE_RESEARCH_STR_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeResearchStrategyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;PgSubjectDefinition&gt;"/> class.</returns>
		public TList<PgSubjectDefinition> GetByPgCodeResearchStrategyId(TransactionManager transactionManager, System.Decimal _pgCodeResearchStrategyId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCodeResearchStrategyId(transactionManager, _pgCodeResearchStrategyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_PG_CODE_RESEARCH_STR_1 index.
		/// </summary>
		/// <param name="_pgCodeResearchStrategyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;PgSubjectDefinition&gt;"/> class.</returns>
		public TList<PgSubjectDefinition> GetByPgCodeResearchStrategyId(System.Decimal _pgCodeResearchStrategyId, int start, int pageLength, out int count)
		{
			return GetByPgCodeResearchStrategyId(null, _pgCodeResearchStrategyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_PG_CODE_RESEARCH_STR_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeResearchStrategyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;PgSubjectDefinition&gt;"/> class.</returns>
		public abstract TList<PgSubjectDefinition> GetByPgCodeResearchStrategyId(TransactionManager transactionManager, System.Decimal _pgCodeResearchStrategyId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_SUBJECT_DEFINITION index.
		/// </summary>
		/// <param name="_pgSubjectDefinitionId">XX not used</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgSubjectDefinition"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgSubjectDefinition GetByPgSubjectDefinitionId(System.Decimal _pgSubjectDefinitionId)
		{
			int count = -1;
			return GetByPgSubjectDefinitionId(null,_pgSubjectDefinitionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_SUBJECT_DEFINITION index.
		/// </summary>
		/// <param name="_pgSubjectDefinitionId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgSubjectDefinition"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgSubjectDefinition GetByPgSubjectDefinitionId(System.Decimal _pgSubjectDefinitionId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgSubjectDefinitionId(null, _pgSubjectDefinitionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_SUBJECT_DEFINITION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgSubjectDefinitionId">XX not used</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgSubjectDefinition"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgSubjectDefinition GetByPgSubjectDefinitionId(TransactionManager transactionManager, System.Decimal _pgSubjectDefinitionId)
		{
			int count = -1;
			return GetByPgSubjectDefinitionId(transactionManager, _pgSubjectDefinitionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_SUBJECT_DEFINITION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgSubjectDefinitionId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgSubjectDefinition"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgSubjectDefinition GetByPgSubjectDefinitionId(TransactionManager transactionManager, System.Decimal _pgSubjectDefinitionId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgSubjectDefinitionId(transactionManager, _pgSubjectDefinitionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_SUBJECT_DEFINITION index.
		/// </summary>
		/// <param name="_pgSubjectDefinitionId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgSubjectDefinition"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgSubjectDefinition GetByPgSubjectDefinitionId(System.Decimal _pgSubjectDefinitionId, int start, int pageLength, out int count)
		{
			return GetByPgSubjectDefinitionId(null, _pgSubjectDefinitionId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_SUBJECT_DEFINITION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgSubjectDefinitionId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgSubjectDefinition"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgSubjectDefinition GetByPgSubjectDefinitionId(TransactionManager transactionManager, System.Decimal _pgSubjectDefinitionId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgSubjectDefinition&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgSubjectDefinition&gt;"/></returns>
		public static TList<PgSubjectDefinition> Fill(IDataReader reader, TList<PgSubjectDefinition> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgSubjectDefinition c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgSubjectDefinition")
					.Append("|").Append((System.Decimal)reader["PG_SUBJECT_DEFINITION_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgSubjectDefinition>(
					key.ToString(), // EntityTrackingKey
					"PgSubjectDefinition",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgSubjectDefinition();
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
					c.PgSubjectDefinitionId = (System.Decimal)reader["PG_SUBJECT_DEFINITION_ID"];
					c.OriginalPgSubjectDefinitionId = c.PgSubjectDefinitionId;
					c.AsNodeId = (System.Decimal)reader["AS_NODE_ID"];
					c.SubjectDefCode = Convert.IsDBNull(reader["SUBJECT_DEF_CODE"]) ? null : (System.String)reader["SUBJECT_DEF_CODE"];
					c.SubjectDefAr = (System.String)reader["SUBJECT_DEF_AR"];
					c.SubjectDefEn = Convert.IsDBNull(reader["SUBJECT_DEF_EN"]) ? null : (System.String)reader["SUBJECT_DEF_EN"];
					c.PgCodeResearchStrategyId = (System.Decimal)reader["PG_CODE_RESEARCH_STRATEGY_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgSubjectDefinition"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgSubjectDefinition"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgSubjectDefinition entity)
		{
			if (!reader.Read()) return;
			
			entity.PgSubjectDefinitionId = (System.Decimal)reader[((int)PgSubjectDefinitionColumn.PgSubjectDefinitionId - 1)];
			entity.OriginalPgSubjectDefinitionId = (System.Decimal)reader["PG_SUBJECT_DEFINITION_ID"];
			entity.AsNodeId = (System.Decimal)reader[((int)PgSubjectDefinitionColumn.AsNodeId - 1)];
			entity.SubjectDefCode = (reader.IsDBNull(((int)PgSubjectDefinitionColumn.SubjectDefCode - 1)))?null:(System.String)reader[((int)PgSubjectDefinitionColumn.SubjectDefCode - 1)];
			entity.SubjectDefAr = (System.String)reader[((int)PgSubjectDefinitionColumn.SubjectDefAr - 1)];
			entity.SubjectDefEn = (reader.IsDBNull(((int)PgSubjectDefinitionColumn.SubjectDefEn - 1)))?null:(System.String)reader[((int)PgSubjectDefinitionColumn.SubjectDefEn - 1)];
			entity.PgCodeResearchStrategyId = (System.Decimal)reader[((int)PgSubjectDefinitionColumn.PgCodeResearchStrategyId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgSubjectDefinition"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgSubjectDefinition"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgSubjectDefinition entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgSubjectDefinitionId = (System.Decimal)dataRow["PG_SUBJECT_DEFINITION_ID"];
			entity.OriginalPgSubjectDefinitionId = (System.Decimal)dataRow["PG_SUBJECT_DEFINITION_ID"];
			entity.AsNodeId = (System.Decimal)dataRow["AS_NODE_ID"];
			entity.SubjectDefCode = Convert.IsDBNull(dataRow["SUBJECT_DEF_CODE"]) ? null : (System.String)dataRow["SUBJECT_DEF_CODE"];
			entity.SubjectDefAr = (System.String)dataRow["SUBJECT_DEF_AR"];
			entity.SubjectDefEn = Convert.IsDBNull(dataRow["SUBJECT_DEF_EN"]) ? null : (System.String)dataRow["SUBJECT_DEF_EN"];
			entity.PgCodeResearchStrategyId = (System.Decimal)dataRow["PG_CODE_RESEARCH_STRATEGY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgSubjectDefinition"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgSubjectDefinition Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgSubjectDefinition entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region PgCodeResearchStrategyIdSource	
			if (CanDeepLoad(entity, "PgCodeRsrchStrategy|PgCodeResearchStrategyIdSource", deepLoadType, innerList) 
				&& entity.PgCodeResearchStrategyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgCodeResearchStrategyId;
				PgCodeRsrchStrategy tmpEntity = EntityManager.LocateEntity<PgCodeRsrchStrategy>(EntityLocator.ConstructKeyFromPkItems(typeof(PgCodeRsrchStrategy), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgCodeResearchStrategyIdSource = tmpEntity;
				else
					entity.PgCodeResearchStrategyIdSource = DataRepository.PgCodeRsrchStrategyProvider.GetByPgCodeResearchStrategyId(transactionManager, entity.PgCodeResearchStrategyId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgCodeResearchStrategyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgCodeResearchStrategyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgCodeRsrchStrategyProvider.DeepLoad(transactionManager, entity.PgCodeResearchStrategyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgCodeResearchStrategyIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgSubjectDefinition object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgSubjectDefinition instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgSubjectDefinition Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgSubjectDefinition entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region PgCodeResearchStrategyIdSource
			if (CanDeepSave(entity, "PgCodeRsrchStrategy|PgCodeResearchStrategyIdSource", deepSaveType, innerList) 
				&& entity.PgCodeResearchStrategyIdSource != null)
			{
				DataRepository.PgCodeRsrchStrategyProvider.Save(transactionManager, entity.PgCodeResearchStrategyIdSource);
				entity.PgCodeResearchStrategyId = entity.PgCodeResearchStrategyIdSource.PgCodeResearchStrategyId;
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
	
	#region PgSubjectDefinitionChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgSubjectDefinition</c>
	///</summary>
	public enum PgSubjectDefinitionChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>PgCodeRsrchStrategy</c> at PgCodeResearchStrategyIdSource
		///</summary>
		[ChildEntityType(typeof(PgCodeRsrchStrategy))]
		PgCodeRsrchStrategy,
	}
	
	#endregion PgSubjectDefinitionChildEntityTypes
	
	#region PgSubjectDefinitionFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgSubjectDefinitionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgSubjectDefinition"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgSubjectDefinitionFilterBuilder : SqlFilterBuilder<PgSubjectDefinitionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgSubjectDefinitionFilterBuilder class.
		/// </summary>
		public PgSubjectDefinitionFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgSubjectDefinitionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgSubjectDefinitionFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgSubjectDefinitionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgSubjectDefinitionFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgSubjectDefinitionFilterBuilder
	
	#region PgSubjectDefinitionParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgSubjectDefinitionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgSubjectDefinition"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgSubjectDefinitionParameterBuilder : ParameterizedSqlFilterBuilder<PgSubjectDefinitionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgSubjectDefinitionParameterBuilder class.
		/// </summary>
		public PgSubjectDefinitionParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgSubjectDefinitionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgSubjectDefinitionParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgSubjectDefinitionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgSubjectDefinitionParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgSubjectDefinitionParameterBuilder
	
	#region PgSubjectDefinitionSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgSubjectDefinitionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgSubjectDefinition"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgSubjectDefinitionSortBuilder : SqlSortBuilder<PgSubjectDefinitionColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgSubjectDefinitionSqlSortBuilder class.
		/// </summary>
		public PgSubjectDefinitionSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgSubjectDefinitionSortBuilder
	
} // end namespace
