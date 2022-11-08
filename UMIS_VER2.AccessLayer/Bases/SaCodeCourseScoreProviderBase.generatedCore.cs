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
	/// This class is the base class for any <see cref="SaCodeCourseScoreProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeCourseScoreProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeCourseScore, UMIS_VER2.BusinessLyer.SaCodeCourseScoreKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeCourseScoreKey key)
		{
			return Delete(transactionManager, key.SaCodeCourseScoreId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeCourseScoreId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeCourseScoreId)
		{
			return Delete(null, _saCodeCourseScoreId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCourseScoreId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeCourseScoreId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeCourseScore Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeCourseScoreKey key, int start, int pageLength)
		{
			return GetBySaCodeCourseScoreId(transactionManager, key.SaCodeCourseScoreId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_COURSE_SCORE index.
		/// </summary>
		/// <param name="_saCodeCourseScoreId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseScore"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCourseScore GetBySaCodeCourseScoreId(System.Decimal _saCodeCourseScoreId)
		{
			int count = -1;
			return GetBySaCodeCourseScoreId(null,_saCodeCourseScoreId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COURSE_SCORE index.
		/// </summary>
		/// <param name="_saCodeCourseScoreId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseScore"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCourseScore GetBySaCodeCourseScoreId(System.Decimal _saCodeCourseScoreId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeCourseScoreId(null, _saCodeCourseScoreId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COURSE_SCORE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCourseScoreId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseScore"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCourseScore GetBySaCodeCourseScoreId(TransactionManager transactionManager, System.Decimal _saCodeCourseScoreId)
		{
			int count = -1;
			return GetBySaCodeCourseScoreId(transactionManager, _saCodeCourseScoreId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COURSE_SCORE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCourseScoreId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseScore"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCourseScore GetBySaCodeCourseScoreId(TransactionManager transactionManager, System.Decimal _saCodeCourseScoreId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeCourseScoreId(transactionManager, _saCodeCourseScoreId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COURSE_SCORE index.
		/// </summary>
		/// <param name="_saCodeCourseScoreId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseScore"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCourseScore GetBySaCodeCourseScoreId(System.Decimal _saCodeCourseScoreId, int start, int pageLength, out int count)
		{
			return GetBySaCodeCourseScoreId(null, _saCodeCourseScoreId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COURSE_SCORE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCourseScoreId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseScore"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeCourseScore GetBySaCodeCourseScoreId(TransactionManager transactionManager, System.Decimal _saCodeCourseScoreId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeCourseScore&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeCourseScore&gt;"/></returns>
		public static TList<SaCodeCourseScore> Fill(IDataReader reader, TList<SaCodeCourseScore> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeCourseScore c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeCourseScore")
					.Append("|").Append((System.Decimal)reader["SA_CODE_COURSE_SCORE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeCourseScore>(
					key.ToString(), // EntityTrackingKey
					"SaCodeCourseScore",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeCourseScore();
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
					c.SaCodeCourseScoreId = (System.Decimal)reader["SA_CODE_COURSE_SCORE_ID"];
					c.OriginalSaCodeCourseScoreId = c.SaCodeCourseScoreId;
					c.ScoreCode = Convert.IsDBNull(reader["SCORE_CODE"]) ? null : (System.String)reader["SCORE_CODE"];
					c.ScoreDescrAr = (System.String)reader["SCORE_DESCR_AR"];
					c.ScoreDescrEn = Convert.IsDBNull(reader["SCORE_DESCR_EN"]) ? null : (System.String)reader["SCORE_DESCR_EN"];
					c.ScoreFrom = (System.Decimal)reader["SCORE_FROM"];
					c.ScoreTo = (System.Decimal)reader["SCORE_TO"];
					c.PassFail = (System.Decimal)reader["PASS_FAIL"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseScore"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseScore"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeCourseScore entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeCourseScoreId = (System.Decimal)reader[((int)SaCodeCourseScoreColumn.SaCodeCourseScoreId - 1)];
			entity.OriginalSaCodeCourseScoreId = (System.Decimal)reader["SA_CODE_COURSE_SCORE_ID"];
			entity.ScoreCode = (reader.IsDBNull(((int)SaCodeCourseScoreColumn.ScoreCode - 1)))?null:(System.String)reader[((int)SaCodeCourseScoreColumn.ScoreCode - 1)];
			entity.ScoreDescrAr = (System.String)reader[((int)SaCodeCourseScoreColumn.ScoreDescrAr - 1)];
			entity.ScoreDescrEn = (reader.IsDBNull(((int)SaCodeCourseScoreColumn.ScoreDescrEn - 1)))?null:(System.String)reader[((int)SaCodeCourseScoreColumn.ScoreDescrEn - 1)];
			entity.ScoreFrom = (System.Decimal)reader[((int)SaCodeCourseScoreColumn.ScoreFrom - 1)];
			entity.ScoreTo = (System.Decimal)reader[((int)SaCodeCourseScoreColumn.ScoreTo - 1)];
			entity.PassFail = (System.Decimal)reader[((int)SaCodeCourseScoreColumn.PassFail - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseScore"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseScore"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeCourseScore entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeCourseScoreId = (System.Decimal)dataRow["SA_CODE_COURSE_SCORE_ID"];
			entity.OriginalSaCodeCourseScoreId = (System.Decimal)dataRow["SA_CODE_COURSE_SCORE_ID"];
			entity.ScoreCode = Convert.IsDBNull(dataRow["SCORE_CODE"]) ? null : (System.String)dataRow["SCORE_CODE"];
			entity.ScoreDescrAr = (System.String)dataRow["SCORE_DESCR_AR"];
			entity.ScoreDescrEn = Convert.IsDBNull(dataRow["SCORE_DESCR_EN"]) ? null : (System.String)dataRow["SCORE_DESCR_EN"];
			entity.ScoreFrom = (System.Decimal)dataRow["SCORE_FROM"];
			entity.ScoreTo = (System.Decimal)dataRow["SCORE_TO"];
			entity.PassFail = (System.Decimal)dataRow["PASS_FAIL"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeCourseScore"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeCourseScore Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeCourseScore entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeCourseScoreId methods when available
			
			#region SaTrainingCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaTrainingCourse>|SaTrainingCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaTrainingCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaTrainingCourseCollection = DataRepository.SaTrainingCourseProvider.GetBySaCodeCourseScoreId(transactionManager, entity.SaCodeCourseScoreId);

				if (deep && entity.SaTrainingCourseCollection.Count > 0)
				{
					deepHandles.Add("SaTrainingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaTrainingCourse>) DataRepository.SaTrainingCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.SaTrainingCourseCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeCourseScore object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeCourseScore instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeCourseScore Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeCourseScore entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaTrainingCourse>
				if (CanDeepSave(entity.SaTrainingCourseCollection, "List<SaTrainingCourse>|SaTrainingCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaTrainingCourse child in entity.SaTrainingCourseCollection)
					{
						if(child.SaCodeCourseScoreIdSource != null)
						{
							child.SaCodeCourseScoreId = child.SaCodeCourseScoreIdSource.SaCodeCourseScoreId;
						}
						else
						{
							child.SaCodeCourseScoreId = entity.SaCodeCourseScoreId;
						}

					}

					if (entity.SaTrainingCourseCollection.Count > 0 || entity.SaTrainingCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaTrainingCourseProvider.Save(transactionManager, entity.SaTrainingCourseCollection);
						
						deepHandles.Add("SaTrainingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaTrainingCourse >) DataRepository.SaTrainingCourseProvider.DeepSave,
							new object[] { transactionManager, entity.SaTrainingCourseCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodeCourseScoreChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeCourseScore</c>
	///</summary>
	public enum SaCodeCourseScoreChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCodeCourseScore</c> as OneToMany for SaTrainingCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaTrainingCourse>))]
		SaTrainingCourseCollection,
	}
	
	#endregion SaCodeCourseScoreChildEntityTypes
	
	#region SaCodeCourseScoreFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeCourseScoreColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeCourseScore"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeCourseScoreFilterBuilder : SqlFilterBuilder<SaCodeCourseScoreColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseScoreFilterBuilder class.
		/// </summary>
		public SaCodeCourseScoreFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseScoreFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeCourseScoreFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseScoreFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeCourseScoreFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeCourseScoreFilterBuilder
	
	#region SaCodeCourseScoreParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeCourseScoreColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeCourseScore"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeCourseScoreParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeCourseScoreColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseScoreParameterBuilder class.
		/// </summary>
		public SaCodeCourseScoreParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseScoreParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeCourseScoreParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseScoreParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeCourseScoreParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeCourseScoreParameterBuilder
	
	#region SaCodeCourseScoreSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeCourseScoreColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeCourseScore"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeCourseScoreSortBuilder : SqlSortBuilder<SaCodeCourseScoreColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeCourseScoreSqlSortBuilder class.
		/// </summary>
		public SaCodeCourseScoreSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeCourseScoreSortBuilder
	
} // end namespace
