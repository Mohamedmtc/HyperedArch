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
	/// This class is the base class for any <see cref="PgCdeThesisStatusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgCdeThesisStatusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgCdeThesisStatus, UMIS_VER2.BusinessLyer.PgCdeThesisStatusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeThesisStatusKey key)
		{
			return Delete(transactionManager, key.PgCdeThesisStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgCdeThesisStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _pgCdeThesisStatusId)
		{
			return Delete(null, _pgCdeThesisStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeThesisStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _pgCdeThesisStatusId);		
		
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
		public override UMIS_VER2.BusinessLyer.PgCdeThesisStatus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeThesisStatusKey key, int start, int pageLength)
		{
			return GetByPgCdeThesisStatusId(transactionManager, key.PgCdeThesisStatusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_CDE_THESIS_STATUS index.
		/// </summary>
		/// <param name="_pgCdeThesisStatusId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeThesisStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeThesisStatus GetByPgCdeThesisStatusId(System.Int32 _pgCdeThesisStatusId)
		{
			int count = -1;
			return GetByPgCdeThesisStatusId(null,_pgCdeThesisStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CDE_THESIS_STATUS index.
		/// </summary>
		/// <param name="_pgCdeThesisStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeThesisStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeThesisStatus GetByPgCdeThesisStatusId(System.Int32 _pgCdeThesisStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCdeThesisStatusId(null, _pgCdeThesisStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CDE_THESIS_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeThesisStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeThesisStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeThesisStatus GetByPgCdeThesisStatusId(TransactionManager transactionManager, System.Int32 _pgCdeThesisStatusId)
		{
			int count = -1;
			return GetByPgCdeThesisStatusId(transactionManager, _pgCdeThesisStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CDE_THESIS_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeThesisStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeThesisStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeThesisStatus GetByPgCdeThesisStatusId(TransactionManager transactionManager, System.Int32 _pgCdeThesisStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCdeThesisStatusId(transactionManager, _pgCdeThesisStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CDE_THESIS_STATUS index.
		/// </summary>
		/// <param name="_pgCdeThesisStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeThesisStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeThesisStatus GetByPgCdeThesisStatusId(System.Int32 _pgCdeThesisStatusId, int start, int pageLength, out int count)
		{
			return GetByPgCdeThesisStatusId(null, _pgCdeThesisStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CDE_THESIS_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeThesisStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeThesisStatus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgCdeThesisStatus GetByPgCdeThesisStatusId(TransactionManager transactionManager, System.Int32 _pgCdeThesisStatusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgCdeThesisStatus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgCdeThesisStatus&gt;"/></returns>
		public static TList<PgCdeThesisStatus> Fill(IDataReader reader, TList<PgCdeThesisStatus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgCdeThesisStatus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgCdeThesisStatus")
					.Append("|").Append((System.Int32)reader["PG_CDE_THESIS_STATUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgCdeThesisStatus>(
					key.ToString(), // EntityTrackingKey
					"PgCdeThesisStatus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgCdeThesisStatus();
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
					c.PgCdeThesisStatusId = (System.Int32)reader["PG_CDE_THESIS_STATUS_ID"];
					c.OriginalPgCdeThesisStatusId = c.PgCdeThesisStatusId;
					c.StatusAr = (System.String)reader["STATUS_AR"];
					c.StatusEn = (System.String)reader["STATUS_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgCdeThesisStatus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCdeThesisStatus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgCdeThesisStatus entity)
		{
			if (!reader.Read()) return;
			
			entity.PgCdeThesisStatusId = (System.Int32)reader[((int)PgCdeThesisStatusColumn.PgCdeThesisStatusId - 1)];
			entity.OriginalPgCdeThesisStatusId = (System.Int32)reader["PG_CDE_THESIS_STATUS_ID"];
			entity.StatusAr = (System.String)reader[((int)PgCdeThesisStatusColumn.StatusAr - 1)];
			entity.StatusEn = (System.String)reader[((int)PgCdeThesisStatusColumn.StatusEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgCdeThesisStatus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCdeThesisStatus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgCdeThesisStatus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgCdeThesisStatusId = (System.Int32)dataRow["PG_CDE_THESIS_STATUS_ID"];
			entity.OriginalPgCdeThesisStatusId = (System.Int32)dataRow["PG_CDE_THESIS_STATUS_ID"];
			entity.StatusAr = (System.String)dataRow["STATUS_AR"];
			entity.StatusEn = (System.String)dataRow["STATUS_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCdeThesisStatus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgCdeThesisStatus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeThesisStatus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgCdeThesisStatusId methods when available
			
			#region PgThesisStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStud>|PgThesisStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudCollection = DataRepository.PgThesisStudProvider.GetByPgCdeThesisStatusId(transactionManager, entity.PgCdeThesisStatusId);

				if (deep && entity.PgThesisStudCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStud>) DataRepository.PgThesisStudProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgCdeThesisStatus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgCdeThesisStatus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgCdeThesisStatus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeThesisStatus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<PgThesisStud>
				if (CanDeepSave(entity.PgThesisStudCollection, "List<PgThesisStud>|PgThesisStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStud child in entity.PgThesisStudCollection)
					{
						if(child.PgCdeThesisStatusIdSource != null)
						{
							child.PgCdeThesisStatusId = child.PgCdeThesisStatusIdSource.PgCdeThesisStatusId;
						}
						else
						{
							child.PgCdeThesisStatusId = entity.PgCdeThesisStatusId;
						}

					}

					if (entity.PgThesisStudCollection.Count > 0 || entity.PgThesisStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudProvider.Save(transactionManager, entity.PgThesisStudCollection);
						
						deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStud >) DataRepository.PgThesisStudProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgCdeThesisStatusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgCdeThesisStatus</c>
	///</summary>
	public enum PgCdeThesisStatusChildEntityTypes
	{
		///<summary>
		/// Collection of <c>PgCdeThesisStatus</c> as OneToMany for PgThesisStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStud>))]
		PgThesisStudCollection,
	}
	
	#endregion PgCdeThesisStatusChildEntityTypes
	
	#region PgCdeThesisStatusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgCdeThesisStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCdeThesisStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgCdeThesisStatusFilterBuilder : SqlFilterBuilder<PgCdeThesisStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCdeThesisStatusFilterBuilder class.
		/// </summary>
		public PgCdeThesisStatusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgCdeThesisStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgCdeThesisStatusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgCdeThesisStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgCdeThesisStatusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgCdeThesisStatusFilterBuilder
	
	#region PgCdeThesisStatusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgCdeThesisStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCdeThesisStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgCdeThesisStatusParameterBuilder : ParameterizedSqlFilterBuilder<PgCdeThesisStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCdeThesisStatusParameterBuilder class.
		/// </summary>
		public PgCdeThesisStatusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgCdeThesisStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgCdeThesisStatusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgCdeThesisStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgCdeThesisStatusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgCdeThesisStatusParameterBuilder
	
	#region PgCdeThesisStatusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgCdeThesisStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCdeThesisStatus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgCdeThesisStatusSortBuilder : SqlSortBuilder<PgCdeThesisStatusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCdeThesisStatusSqlSortBuilder class.
		/// </summary>
		public PgCdeThesisStatusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgCdeThesisStatusSortBuilder
	
} // end namespace
