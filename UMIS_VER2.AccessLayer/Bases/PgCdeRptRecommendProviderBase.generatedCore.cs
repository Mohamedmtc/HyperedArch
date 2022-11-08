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
	/// This class is the base class for any <see cref="PgCdeRptRecommendProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgCdeRptRecommendProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgCdeRptRecommend, UMIS_VER2.BusinessLyer.PgCdeRptRecommendKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeRptRecommendKey key)
		{
			return Delete(transactionManager, key.PgCdeRptRecommendId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgCdeRptRecommendId">مسلسل توصيات التقرير. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgCdeRptRecommendId)
		{
			return Delete(null, _pgCdeRptRecommendId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeRptRecommendId">مسلسل توصيات التقرير. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgCdeRptRecommendId);		
		
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
		public override UMIS_VER2.BusinessLyer.PgCdeRptRecommend Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeRptRecommendKey key, int start, int pageLength)
		{
			return GetByPgCdeRptRecommendId(transactionManager, key.PgCdeRptRecommendId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_PG_CDE_RPT_RECOMMEND_AR index.
		/// </summary>
		/// <param name="_pgCdeRptRecommendId">مسلسل توصيات التقرير</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeRptRecommend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeRptRecommend GetByPgCdeRptRecommendId(System.Decimal _pgCdeRptRecommendId)
		{
			int count = -1;
			return GetByPgCdeRptRecommendId(null,_pgCdeRptRecommendId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_PG_CDE_RPT_RECOMMEND_AR index.
		/// </summary>
		/// <param name="_pgCdeRptRecommendId">مسلسل توصيات التقرير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeRptRecommend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeRptRecommend GetByPgCdeRptRecommendId(System.Decimal _pgCdeRptRecommendId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCdeRptRecommendId(null, _pgCdeRptRecommendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_PG_CDE_RPT_RECOMMEND_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeRptRecommendId">مسلسل توصيات التقرير</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeRptRecommend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeRptRecommend GetByPgCdeRptRecommendId(TransactionManager transactionManager, System.Decimal _pgCdeRptRecommendId)
		{
			int count = -1;
			return GetByPgCdeRptRecommendId(transactionManager, _pgCdeRptRecommendId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_PG_CDE_RPT_RECOMMEND_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeRptRecommendId">مسلسل توصيات التقرير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeRptRecommend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeRptRecommend GetByPgCdeRptRecommendId(TransactionManager transactionManager, System.Decimal _pgCdeRptRecommendId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCdeRptRecommendId(transactionManager, _pgCdeRptRecommendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_PG_CDE_RPT_RECOMMEND_AR index.
		/// </summary>
		/// <param name="_pgCdeRptRecommendId">مسلسل توصيات التقرير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeRptRecommend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeRptRecommend GetByPgCdeRptRecommendId(System.Decimal _pgCdeRptRecommendId, int start, int pageLength, out int count)
		{
			return GetByPgCdeRptRecommendId(null, _pgCdeRptRecommendId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_PG_CDE_RPT_RECOMMEND_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeRptRecommendId">مسلسل توصيات التقرير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeRptRecommend"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgCdeRptRecommend GetByPgCdeRptRecommendId(TransactionManager transactionManager, System.Decimal _pgCdeRptRecommendId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgCdeRptRecommend&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgCdeRptRecommend&gt;"/></returns>
		public static TList<PgCdeRptRecommend> Fill(IDataReader reader, TList<PgCdeRptRecommend> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgCdeRptRecommend c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgCdeRptRecommend")
					.Append("|").Append((System.Decimal)reader["PG_CDE_RPT_RECOMMEND_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgCdeRptRecommend>(
					key.ToString(), // EntityTrackingKey
					"PgCdeRptRecommend",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgCdeRptRecommend();
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
					c.PgCdeRptRecommendId = (System.Decimal)reader["PG_CDE_RPT_RECOMMEND_ID"];
					c.OriginalPgCdeRptRecommendId = c.PgCdeRptRecommendId;
					c.RecommendAr = (System.String)reader["RECOMMEND_AR"];
					c.RecommendEn = Convert.IsDBNull(reader["RECOMMEND_EN"]) ? null : (System.String)reader["RECOMMEND_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgCdeRptRecommend"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCdeRptRecommend"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgCdeRptRecommend entity)
		{
			if (!reader.Read()) return;
			
			entity.PgCdeRptRecommendId = (System.Decimal)reader[((int)PgCdeRptRecommendColumn.PgCdeRptRecommendId - 1)];
			entity.OriginalPgCdeRptRecommendId = (System.Decimal)reader["PG_CDE_RPT_RECOMMEND_ID"];
			entity.RecommendAr = (System.String)reader[((int)PgCdeRptRecommendColumn.RecommendAr - 1)];
			entity.RecommendEn = (reader.IsDBNull(((int)PgCdeRptRecommendColumn.RecommendEn - 1)))?null:(System.String)reader[((int)PgCdeRptRecommendColumn.RecommendEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgCdeRptRecommend"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCdeRptRecommend"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgCdeRptRecommend entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgCdeRptRecommendId = (System.Decimal)dataRow["PG_CDE_RPT_RECOMMEND_ID"];
			entity.OriginalPgCdeRptRecommendId = (System.Decimal)dataRow["PG_CDE_RPT_RECOMMEND_ID"];
			entity.RecommendAr = (System.String)dataRow["RECOMMEND_AR"];
			entity.RecommendEn = Convert.IsDBNull(dataRow["RECOMMEND_EN"]) ? null : (System.String)dataRow["RECOMMEND_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCdeRptRecommend"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgCdeRptRecommend Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeRptRecommend entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgCdeRptRecommendId methods when available
			
			#region PgThesisSupervisorRptCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisSupervisorRpt>|PgThesisSupervisorRptCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisSupervisorRptCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisSupervisorRptCollection = DataRepository.PgThesisSupervisorRptProvider.GetByPgCdeRptRecommendId(transactionManager, entity.PgCdeRptRecommendId);

				if (deep && entity.PgThesisSupervisorRptCollection.Count > 0)
				{
					deepHandles.Add("PgThesisSupervisorRptCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisSupervisorRpt>) DataRepository.PgThesisSupervisorRptProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisSupervisorRptCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgCdeRptRecommend object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgCdeRptRecommend instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgCdeRptRecommend Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeRptRecommend entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<PgThesisSupervisorRpt>
				if (CanDeepSave(entity.PgThesisSupervisorRptCollection, "List<PgThesisSupervisorRpt>|PgThesisSupervisorRptCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisSupervisorRpt child in entity.PgThesisSupervisorRptCollection)
					{
						if(child.PgCdeRptRecommendIdSource != null)
						{
							child.PgCdeRptRecommendId = child.PgCdeRptRecommendIdSource.PgCdeRptRecommendId;
						}
						else
						{
							child.PgCdeRptRecommendId = entity.PgCdeRptRecommendId;
						}

					}

					if (entity.PgThesisSupervisorRptCollection.Count > 0 || entity.PgThesisSupervisorRptCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisSupervisorRptProvider.Save(transactionManager, entity.PgThesisSupervisorRptCollection);
						
						deepHandles.Add("PgThesisSupervisorRptCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisSupervisorRpt >) DataRepository.PgThesisSupervisorRptProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisSupervisorRptCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgCdeRptRecommendChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgCdeRptRecommend</c>
	///</summary>
	public enum PgCdeRptRecommendChildEntityTypes
	{
		///<summary>
		/// Collection of <c>PgCdeRptRecommend</c> as OneToMany for PgThesisSupervisorRptCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisSupervisorRpt>))]
		PgThesisSupervisorRptCollection,
	}
	
	#endregion PgCdeRptRecommendChildEntityTypes
	
	#region PgCdeRptRecommendFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgCdeRptRecommendColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCdeRptRecommend"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgCdeRptRecommendFilterBuilder : SqlFilterBuilder<PgCdeRptRecommendColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCdeRptRecommendFilterBuilder class.
		/// </summary>
		public PgCdeRptRecommendFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgCdeRptRecommendFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgCdeRptRecommendFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgCdeRptRecommendFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgCdeRptRecommendFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgCdeRptRecommendFilterBuilder
	
	#region PgCdeRptRecommendParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgCdeRptRecommendColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCdeRptRecommend"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgCdeRptRecommendParameterBuilder : ParameterizedSqlFilterBuilder<PgCdeRptRecommendColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCdeRptRecommendParameterBuilder class.
		/// </summary>
		public PgCdeRptRecommendParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgCdeRptRecommendParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgCdeRptRecommendParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgCdeRptRecommendParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgCdeRptRecommendParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgCdeRptRecommendParameterBuilder
	
	#region PgCdeRptRecommendSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgCdeRptRecommendColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCdeRptRecommend"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgCdeRptRecommendSortBuilder : SqlSortBuilder<PgCdeRptRecommendColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCdeRptRecommendSqlSortBuilder class.
		/// </summary>
		public PgCdeRptRecommendSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgCdeRptRecommendSortBuilder
	
} // end namespace
