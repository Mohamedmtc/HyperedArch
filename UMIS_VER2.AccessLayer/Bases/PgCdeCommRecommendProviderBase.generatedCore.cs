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
	/// This class is the base class for any <see cref="PgCdeCommRecommendProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgCdeCommRecommendProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgCdeCommRecommend, UMIS_VER2.BusinessLyer.PgCdeCommRecommendKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeCommRecommendKey key)
		{
			return Delete(transactionManager, key.PgCdeCommRecommendId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgCdeCommRecommendId">مسلسل توصيات لجنة الحكم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgCdeCommRecommendId)
		{
			return Delete(null, _pgCdeCommRecommendId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeCommRecommendId">مسلسل توصيات لجنة الحكم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgCdeCommRecommendId);		
		
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
		public override UMIS_VER2.BusinessLyer.PgCdeCommRecommend Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeCommRecommendKey key, int start, int pageLength)
		{
			return GetByPgCdeCommRecommendId(transactionManager, key.PgCdeCommRecommendId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_PG_CDE_COMM_RECOMMEND_AR index.
		/// </summary>
		/// <param name="_pgCdeCommRecommendId">مسلسل توصيات لجنة الحكم</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeCommRecommend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeCommRecommend GetByPgCdeCommRecommendId(System.Decimal _pgCdeCommRecommendId)
		{
			int count = -1;
			return GetByPgCdeCommRecommendId(null,_pgCdeCommRecommendId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_PG_CDE_COMM_RECOMMEND_AR index.
		/// </summary>
		/// <param name="_pgCdeCommRecommendId">مسلسل توصيات لجنة الحكم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeCommRecommend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeCommRecommend GetByPgCdeCommRecommendId(System.Decimal _pgCdeCommRecommendId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCdeCommRecommendId(null, _pgCdeCommRecommendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_PG_CDE_COMM_RECOMMEND_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeCommRecommendId">مسلسل توصيات لجنة الحكم</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeCommRecommend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeCommRecommend GetByPgCdeCommRecommendId(TransactionManager transactionManager, System.Decimal _pgCdeCommRecommendId)
		{
			int count = -1;
			return GetByPgCdeCommRecommendId(transactionManager, _pgCdeCommRecommendId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_PG_CDE_COMM_RECOMMEND_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeCommRecommendId">مسلسل توصيات لجنة الحكم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeCommRecommend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeCommRecommend GetByPgCdeCommRecommendId(TransactionManager transactionManager, System.Decimal _pgCdeCommRecommendId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCdeCommRecommendId(transactionManager, _pgCdeCommRecommendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_PG_CDE_COMM_RECOMMEND_AR index.
		/// </summary>
		/// <param name="_pgCdeCommRecommendId">مسلسل توصيات لجنة الحكم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeCommRecommend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeCommRecommend GetByPgCdeCommRecommendId(System.Decimal _pgCdeCommRecommendId, int start, int pageLength, out int count)
		{
			return GetByPgCdeCommRecommendId(null, _pgCdeCommRecommendId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_PG_CDE_COMM_RECOMMEND_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeCommRecommendId">مسلسل توصيات لجنة الحكم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeCommRecommend"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgCdeCommRecommend GetByPgCdeCommRecommendId(TransactionManager transactionManager, System.Decimal _pgCdeCommRecommendId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgCdeCommRecommend&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgCdeCommRecommend&gt;"/></returns>
		public static TList<PgCdeCommRecommend> Fill(IDataReader reader, TList<PgCdeCommRecommend> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgCdeCommRecommend c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgCdeCommRecommend")
					.Append("|").Append((System.Decimal)reader["PG_CDE_COMM_RECOMMEND_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgCdeCommRecommend>(
					key.ToString(), // EntityTrackingKey
					"PgCdeCommRecommend",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgCdeCommRecommend();
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
					c.PgCdeCommRecommendId = (System.Decimal)reader["PG_CDE_COMM_RECOMMEND_ID"];
					c.OriginalPgCdeCommRecommendId = c.PgCdeCommRecommendId;
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgCdeCommRecommend"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCdeCommRecommend"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgCdeCommRecommend entity)
		{
			if (!reader.Read()) return;
			
			entity.PgCdeCommRecommendId = (System.Decimal)reader[((int)PgCdeCommRecommendColumn.PgCdeCommRecommendId - 1)];
			entity.OriginalPgCdeCommRecommendId = (System.Decimal)reader["PG_CDE_COMM_RECOMMEND_ID"];
			entity.RecommendAr = (System.String)reader[((int)PgCdeCommRecommendColumn.RecommendAr - 1)];
			entity.RecommendEn = (reader.IsDBNull(((int)PgCdeCommRecommendColumn.RecommendEn - 1)))?null:(System.String)reader[((int)PgCdeCommRecommendColumn.RecommendEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgCdeCommRecommend"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCdeCommRecommend"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgCdeCommRecommend entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgCdeCommRecommendId = (System.Decimal)dataRow["PG_CDE_COMM_RECOMMEND_ID"];
			entity.OriginalPgCdeCommRecommendId = (System.Decimal)dataRow["PG_CDE_COMM_RECOMMEND_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCdeCommRecommend"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgCdeCommRecommend Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeCommRecommend entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgCdeCommRecommendId methods when available
			
			#region PgThesisCommRecommendCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisCommRecommend>|PgThesisCommRecommendCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommRecommendCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisCommRecommendCollection = DataRepository.PgThesisCommRecommendProvider.GetByPgCdeCommRecommendId(transactionManager, entity.PgCdeCommRecommendId);

				if (deep && entity.PgThesisCommRecommendCollection.Count > 0)
				{
					deepHandles.Add("PgThesisCommRecommendCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisCommRecommend>) DataRepository.PgThesisCommRecommendProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisCommRecommendCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgCdeCommRecommend object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgCdeCommRecommend instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgCdeCommRecommend Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeCommRecommend entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<PgThesisCommRecommend>
				if (CanDeepSave(entity.PgThesisCommRecommendCollection, "List<PgThesisCommRecommend>|PgThesisCommRecommendCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisCommRecommend child in entity.PgThesisCommRecommendCollection)
					{
						if(child.PgCdeCommRecommendIdSource != null)
						{
							child.PgCdeCommRecommendId = child.PgCdeCommRecommendIdSource.PgCdeCommRecommendId;
						}
						else
						{
							child.PgCdeCommRecommendId = entity.PgCdeCommRecommendId;
						}

					}

					if (entity.PgThesisCommRecommendCollection.Count > 0 || entity.PgThesisCommRecommendCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisCommRecommendProvider.Save(transactionManager, entity.PgThesisCommRecommendCollection);
						
						deepHandles.Add("PgThesisCommRecommendCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisCommRecommend >) DataRepository.PgThesisCommRecommendProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisCommRecommendCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgCdeCommRecommendChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgCdeCommRecommend</c>
	///</summary>
	public enum PgCdeCommRecommendChildEntityTypes
	{
		///<summary>
		/// Collection of <c>PgCdeCommRecommend</c> as OneToMany for PgThesisCommRecommendCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisCommRecommend>))]
		PgThesisCommRecommendCollection,
	}
	
	#endregion PgCdeCommRecommendChildEntityTypes
	
	#region PgCdeCommRecommendFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgCdeCommRecommendColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCdeCommRecommend"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgCdeCommRecommendFilterBuilder : SqlFilterBuilder<PgCdeCommRecommendColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCdeCommRecommendFilterBuilder class.
		/// </summary>
		public PgCdeCommRecommendFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgCdeCommRecommendFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgCdeCommRecommendFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgCdeCommRecommendFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgCdeCommRecommendFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgCdeCommRecommendFilterBuilder
	
	#region PgCdeCommRecommendParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgCdeCommRecommendColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCdeCommRecommend"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgCdeCommRecommendParameterBuilder : ParameterizedSqlFilterBuilder<PgCdeCommRecommendColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCdeCommRecommendParameterBuilder class.
		/// </summary>
		public PgCdeCommRecommendParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgCdeCommRecommendParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgCdeCommRecommendParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgCdeCommRecommendParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgCdeCommRecommendParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgCdeCommRecommendParameterBuilder
	
	#region PgCdeCommRecommendSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgCdeCommRecommendColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCdeCommRecommend"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgCdeCommRecommendSortBuilder : SqlSortBuilder<PgCdeCommRecommendColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCdeCommRecommendSqlSortBuilder class.
		/// </summary>
		public PgCdeCommRecommendSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgCdeCommRecommendSortBuilder
	
} // end namespace
