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
	/// This class is the base class for any <see cref="SaCodeTrainingFlgProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeTrainingFlgProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeTrainingFlg, UMIS_VER2.BusinessLyer.SaCodeTrainingFlgKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeTrainingFlgKey key)
		{
			return Delete(transactionManager, key.SaCodeTrainingFlgId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeTrainingFlgId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeTrainingFlgId)
		{
			return Delete(null, _saCodeTrainingFlgId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeTrainingFlgId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeTrainingFlgId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeTrainingFlg Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeTrainingFlgKey key, int start, int pageLength)
		{
			return GetBySaCodeTrainingFlgId(transactionManager, key.SaCodeTrainingFlgId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_TRAINING_FLG index.
		/// </summary>
		/// <param name="_saCodeTrainingFlgId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingFlg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeTrainingFlg GetBySaCodeTrainingFlgId(System.Decimal _saCodeTrainingFlgId)
		{
			int count = -1;
			return GetBySaCodeTrainingFlgId(null,_saCodeTrainingFlgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_TRAINING_FLG index.
		/// </summary>
		/// <param name="_saCodeTrainingFlgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingFlg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeTrainingFlg GetBySaCodeTrainingFlgId(System.Decimal _saCodeTrainingFlgId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeTrainingFlgId(null, _saCodeTrainingFlgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_TRAINING_FLG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeTrainingFlgId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingFlg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeTrainingFlg GetBySaCodeTrainingFlgId(TransactionManager transactionManager, System.Decimal _saCodeTrainingFlgId)
		{
			int count = -1;
			return GetBySaCodeTrainingFlgId(transactionManager, _saCodeTrainingFlgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_TRAINING_FLG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeTrainingFlgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingFlg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeTrainingFlg GetBySaCodeTrainingFlgId(TransactionManager transactionManager, System.Decimal _saCodeTrainingFlgId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeTrainingFlgId(transactionManager, _saCodeTrainingFlgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_TRAINING_FLG index.
		/// </summary>
		/// <param name="_saCodeTrainingFlgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingFlg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeTrainingFlg GetBySaCodeTrainingFlgId(System.Decimal _saCodeTrainingFlgId, int start, int pageLength, out int count)
		{
			return GetBySaCodeTrainingFlgId(null, _saCodeTrainingFlgId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_TRAINING_FLG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeTrainingFlgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingFlg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeTrainingFlg GetBySaCodeTrainingFlgId(TransactionManager transactionManager, System.Decimal _saCodeTrainingFlgId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeTrainingFlg&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeTrainingFlg&gt;"/></returns>
		public static TList<SaCodeTrainingFlg> Fill(IDataReader reader, TList<SaCodeTrainingFlg> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeTrainingFlg c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeTrainingFlg")
					.Append("|").Append((System.Decimal)reader["SA_CODE_TRAINING_FLG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeTrainingFlg>(
					key.ToString(), // EntityTrackingKey
					"SaCodeTrainingFlg",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeTrainingFlg();
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
					c.SaCodeTrainingFlgId = (System.Decimal)reader["SA_CODE_TRAINING_FLG_ID"];
					c.OriginalSaCodeTrainingFlgId = c.SaCodeTrainingFlgId;
					c.TrainingFlg = (System.String)reader["TRAINING_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingFlg"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingFlg"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeTrainingFlg entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeTrainingFlgId = (System.Decimal)reader[((int)SaCodeTrainingFlgColumn.SaCodeTrainingFlgId - 1)];
			entity.OriginalSaCodeTrainingFlgId = (System.Decimal)reader["SA_CODE_TRAINING_FLG_ID"];
			entity.TrainingFlg = (System.String)reader[((int)SaCodeTrainingFlgColumn.TrainingFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingFlg"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingFlg"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeTrainingFlg entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeTrainingFlgId = (System.Decimal)dataRow["SA_CODE_TRAINING_FLG_ID"];
			entity.OriginalSaCodeTrainingFlgId = (System.Decimal)dataRow["SA_CODE_TRAINING_FLG_ID"];
			entity.TrainingFlg = (System.String)dataRow["TRAINING_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingFlg"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeTrainingFlg Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeTrainingFlg entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeTrainingFlgId methods when available
			
			#region SaTrainingCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaTrainingCourse>|SaTrainingCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaTrainingCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaTrainingCourseCollection = DataRepository.SaTrainingCourseProvider.GetBySaCodeTrainingFlgId(transactionManager, entity.SaCodeTrainingFlgId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeTrainingFlg object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeTrainingFlg instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeTrainingFlg Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeTrainingFlg entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
						if(child.SaCodeTrainingFlgIdSource != null)
						{
							child.SaCodeTrainingFlgId = child.SaCodeTrainingFlgIdSource.SaCodeTrainingFlgId;
						}
						else
						{
							child.SaCodeTrainingFlgId = entity.SaCodeTrainingFlgId;
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
	
	#region SaCodeTrainingFlgChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeTrainingFlg</c>
	///</summary>
	public enum SaCodeTrainingFlgChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCodeTrainingFlg</c> as OneToMany for SaTrainingCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaTrainingCourse>))]
		SaTrainingCourseCollection,
	}
	
	#endregion SaCodeTrainingFlgChildEntityTypes
	
	#region SaCodeTrainingFlgFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeTrainingFlgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeTrainingFlg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeTrainingFlgFilterBuilder : SqlFilterBuilder<SaCodeTrainingFlgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeTrainingFlgFilterBuilder class.
		/// </summary>
		public SaCodeTrainingFlgFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeTrainingFlgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeTrainingFlgFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeTrainingFlgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeTrainingFlgFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeTrainingFlgFilterBuilder
	
	#region SaCodeTrainingFlgParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeTrainingFlgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeTrainingFlg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeTrainingFlgParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeTrainingFlgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeTrainingFlgParameterBuilder class.
		/// </summary>
		public SaCodeTrainingFlgParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeTrainingFlgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeTrainingFlgParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeTrainingFlgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeTrainingFlgParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeTrainingFlgParameterBuilder
	
	#region SaCodeTrainingFlgSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeTrainingFlgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeTrainingFlg"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeTrainingFlgSortBuilder : SqlSortBuilder<SaCodeTrainingFlgColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeTrainingFlgSqlSortBuilder class.
		/// </summary>
		public SaCodeTrainingFlgSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeTrainingFlgSortBuilder
	
} // end namespace
