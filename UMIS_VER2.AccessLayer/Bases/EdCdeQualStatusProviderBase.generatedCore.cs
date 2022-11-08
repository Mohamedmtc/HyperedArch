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
	/// This class is the base class for any <see cref="EdCdeQualStatusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeQualStatusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCdeQualStatus, UMIS_VER2.BusinessLyer.EdCdeQualStatusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeQualStatusKey key)
		{
			return Delete(transactionManager, key.EdCdeQualStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCdeQualStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _edCdeQualStatusId)
		{
			return Delete(null, _edCdeQualStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _edCdeQualStatusId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCdeQualStatus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeQualStatusKey key, int start, int pageLength)
		{
			return GetByEdCdeQualStatusId(transactionManager, key.EdCdeQualStatusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CDE_QUAL_STATUS index.
		/// </summary>
		/// <param name="_edCdeQualStatusId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualStatus GetByEdCdeQualStatusId(System.Int32 _edCdeQualStatusId)
		{
			int count = -1;
			return GetByEdCdeQualStatusId(null,_edCdeQualStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_STATUS index.
		/// </summary>
		/// <param name="_edCdeQualStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualStatus GetByEdCdeQualStatusId(System.Int32 _edCdeQualStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeQualStatusId(null, _edCdeQualStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualStatus GetByEdCdeQualStatusId(TransactionManager transactionManager, System.Int32 _edCdeQualStatusId)
		{
			int count = -1;
			return GetByEdCdeQualStatusId(transactionManager, _edCdeQualStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualStatus GetByEdCdeQualStatusId(TransactionManager transactionManager, System.Int32 _edCdeQualStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeQualStatusId(transactionManager, _edCdeQualStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_STATUS index.
		/// </summary>
		/// <param name="_edCdeQualStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualStatus GetByEdCdeQualStatusId(System.Int32 _edCdeQualStatusId, int start, int pageLength, out int count)
		{
			return GetByEdCdeQualStatusId(null, _edCdeQualStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualStatus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeQualStatus GetByEdCdeQualStatusId(TransactionManager transactionManager, System.Int32 _edCdeQualStatusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCdeQualStatus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCdeQualStatus&gt;"/></returns>
		public static TList<EdCdeQualStatus> Fill(IDataReader reader, TList<EdCdeQualStatus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCdeQualStatus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCdeQualStatus")
					.Append("|").Append((System.Int32)reader["ED_CDE_QUAL_STATUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCdeQualStatus>(
					key.ToString(), // EntityTrackingKey
					"EdCdeQualStatus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCdeQualStatus();
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
					c.EdCdeQualStatusId = (System.Int32)reader["ED_CDE_QUAL_STATUS_ID"];
					c.OriginalEdCdeQualStatusId = c.EdCdeQualStatusId;
					c.QualStatusAr = Convert.IsDBNull(reader["QUAL_STATUS_AR"]) ? null : (System.String)reader["QUAL_STATUS_AR"];
					c.QualStatusEn = Convert.IsDBNull(reader["QUAL_STATUS_EN"]) ? null : (System.String)reader["QUAL_STATUS_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualStatus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeQualStatus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCdeQualStatus entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCdeQualStatusId = (System.Int32)reader[((int)EdCdeQualStatusColumn.EdCdeQualStatusId - 1)];
			entity.OriginalEdCdeQualStatusId = (System.Int32)reader["ED_CDE_QUAL_STATUS_ID"];
			entity.QualStatusAr = (reader.IsDBNull(((int)EdCdeQualStatusColumn.QualStatusAr - 1)))?null:(System.String)reader[((int)EdCdeQualStatusColumn.QualStatusAr - 1)];
			entity.QualStatusEn = (reader.IsDBNull(((int)EdCdeQualStatusColumn.QualStatusEn - 1)))?null:(System.String)reader[((int)EdCdeQualStatusColumn.QualStatusEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualStatus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeQualStatus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCdeQualStatus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCdeQualStatusId = (System.Int32)dataRow["ED_CDE_QUAL_STATUS_ID"];
			entity.OriginalEdCdeQualStatusId = (System.Int32)dataRow["ED_CDE_QUAL_STATUS_ID"];
			entity.QualStatusAr = Convert.IsDBNull(dataRow["QUAL_STATUS_AR"]) ? null : (System.String)dataRow["QUAL_STATUS_AR"];
			entity.QualStatusEn = Convert.IsDBNull(dataRow["QUAL_STATUS_EN"]) ? null : (System.String)dataRow["QUAL_STATUS_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeQualStatus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeQualStatus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeQualStatus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCdeQualStatusId methods when available
			
			#region EdStudQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQual>|EdStudQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualCollection = DataRepository.EdStudQualProvider.GetByEdCdeQualStatusId(transactionManager, entity.EdCdeQualStatusId);

				if (deep && entity.EdStudQualCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQual>) DataRepository.EdStudQualProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCdeQualStatus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCdeQualStatus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeQualStatus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeQualStatus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudQual>
				if (CanDeepSave(entity.EdStudQualCollection, "List<EdStudQual>|EdStudQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQual child in entity.EdStudQualCollection)
					{
						if(child.EdCdeQualStatusIdSource != null)
						{
							child.EdCdeQualStatusId = child.EdCdeQualStatusIdSource.EdCdeQualStatusId;
						}
						else
						{
							child.EdCdeQualStatusId = entity.EdCdeQualStatusId;
						}

					}

					if (entity.EdStudQualCollection.Count > 0 || entity.EdStudQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudQualProvider.Save(transactionManager, entity.EdStudQualCollection);
						
						deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudQual >) DataRepository.EdStudQualProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudQualCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCdeQualStatusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCdeQualStatus</c>
	///</summary>
	public enum EdCdeQualStatusChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCdeQualStatus</c> as OneToMany for EdStudQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQual>))]
		EdStudQualCollection,
	}
	
	#endregion EdCdeQualStatusChildEntityTypes
	
	#region EdCdeQualStatusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCdeQualStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeQualStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeQualStatusFilterBuilder : SqlFilterBuilder<EdCdeQualStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeQualStatusFilterBuilder class.
		/// </summary>
		public EdCdeQualStatusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeQualStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeQualStatusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeQualStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeQualStatusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeQualStatusFilterBuilder
	
	#region EdCdeQualStatusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCdeQualStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeQualStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeQualStatusParameterBuilder : ParameterizedSqlFilterBuilder<EdCdeQualStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeQualStatusParameterBuilder class.
		/// </summary>
		public EdCdeQualStatusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeQualStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeQualStatusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeQualStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeQualStatusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeQualStatusParameterBuilder
	
	#region EdCdeQualStatusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCdeQualStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeQualStatus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCdeQualStatusSortBuilder : SqlSortBuilder<EdCdeQualStatusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeQualStatusSqlSortBuilder class.
		/// </summary>
		public EdCdeQualStatusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCdeQualStatusSortBuilder
	
} // end namespace
