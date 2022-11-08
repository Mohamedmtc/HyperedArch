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
	/// This class is the base class for any <see cref="GsCodeSysProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeSysProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeSys, UMIS_VER2.BusinessLyer.GsCodeSysKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeSysKey key)
		{
			return Delete(transactionManager, key.GsCodeSysId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeSysId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeSysId)
		{
			return Delete(null, _gsCodeSysId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeSysId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeSysId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeSys Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeSysKey key, int start, int pageLength)
		{
			return GetByGsCodeSysId(transactionManager, key.GsCodeSysId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_SYS index.
		/// </summary>
		/// <param name="_gsCodeSysId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeSys"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeSys GetByGsCodeSysId(System.Decimal _gsCodeSysId)
		{
			int count = -1;
			return GetByGsCodeSysId(null,_gsCodeSysId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_SYS index.
		/// </summary>
		/// <param name="_gsCodeSysId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeSys"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeSys GetByGsCodeSysId(System.Decimal _gsCodeSysId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeSysId(null, _gsCodeSysId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_SYS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeSysId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeSys"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeSys GetByGsCodeSysId(TransactionManager transactionManager, System.Decimal _gsCodeSysId)
		{
			int count = -1;
			return GetByGsCodeSysId(transactionManager, _gsCodeSysId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_SYS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeSysId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeSys"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeSys GetByGsCodeSysId(TransactionManager transactionManager, System.Decimal _gsCodeSysId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeSysId(transactionManager, _gsCodeSysId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_SYS index.
		/// </summary>
		/// <param name="_gsCodeSysId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeSys"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeSys GetByGsCodeSysId(System.Decimal _gsCodeSysId, int start, int pageLength, out int count)
		{
			return GetByGsCodeSysId(null, _gsCodeSysId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_SYS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeSysId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeSys"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeSys GetByGsCodeSysId(TransactionManager transactionManager, System.Decimal _gsCodeSysId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeSys&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeSys&gt;"/></returns>
		public static TList<GsCodeSys> Fill(IDataReader reader, TList<GsCodeSys> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeSys c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeSys")
					.Append("|").Append((System.Decimal)reader["GS_CODE_SYS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeSys>(
					key.ToString(), // EntityTrackingKey
					"GsCodeSys",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeSys();
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
					c.GsCodeSysId = (System.Decimal)reader["GS_CODE_SYS_ID"];
					c.OriginalGsCodeSysId = c.GsCodeSysId;
					c.SysDescrAr = (System.String)reader["SYS_DESCR_AR"];
					c.SysDescrEn = Convert.IsDBNull(reader["SYS_DESCR_EN"]) ? null : (System.String)reader["SYS_DESCR_EN"];
					c.SysCode = Convert.IsDBNull(reader["SYS_CODE"]) ? null : (System.String)reader["SYS_CODE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeSys"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeSys"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeSys entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeSysId = (System.Decimal)reader[((int)GsCodeSysColumn.GsCodeSysId - 1)];
			entity.OriginalGsCodeSysId = (System.Decimal)reader["GS_CODE_SYS_ID"];
			entity.SysDescrAr = (System.String)reader[((int)GsCodeSysColumn.SysDescrAr - 1)];
			entity.SysDescrEn = (reader.IsDBNull(((int)GsCodeSysColumn.SysDescrEn - 1)))?null:(System.String)reader[((int)GsCodeSysColumn.SysDescrEn - 1)];
			entity.SysCode = (reader.IsDBNull(((int)GsCodeSysColumn.SysCode - 1)))?null:(System.String)reader[((int)GsCodeSysColumn.SysCode - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeSys"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeSys"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeSys entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeSysId = (System.Decimal)dataRow["GS_CODE_SYS_ID"];
			entity.OriginalGsCodeSysId = (System.Decimal)dataRow["GS_CODE_SYS_ID"];
			entity.SysDescrAr = (System.String)dataRow["SYS_DESCR_AR"];
			entity.SysDescrEn = Convert.IsDBNull(dataRow["SYS_DESCR_EN"]) ? null : (System.String)dataRow["SYS_DESCR_EN"];
			entity.SysCode = Convert.IsDBNull(dataRow["SYS_CODE"]) ? null : (System.String)dataRow["SYS_CODE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeSys"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeSys Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeSys entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeSysId methods when available
			
			#region GsCodeApprovalFuncCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCodeApprovalFunc>|GsCodeApprovalFuncCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalFuncCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCodeApprovalFuncCollection = DataRepository.GsCodeApprovalFuncProvider.GetByGsCodeSysId(transactionManager, entity.GsCodeSysId);

				if (deep && entity.GsCodeApprovalFuncCollection.Count > 0)
				{
					deepHandles.Add("GsCodeApprovalFuncCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCodeApprovalFunc>) DataRepository.GsCodeApprovalFuncProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCodeApprovalFuncCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeSys object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeSys instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeSys Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeSys entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<GsCodeApprovalFunc>
				if (CanDeepSave(entity.GsCodeApprovalFuncCollection, "List<GsCodeApprovalFunc>|GsCodeApprovalFuncCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCodeApprovalFunc child in entity.GsCodeApprovalFuncCollection)
					{
						if(child.GsCodeSysIdSource != null)
						{
							child.GsCodeSysId = child.GsCodeSysIdSource.GsCodeSysId;
						}
						else
						{
							child.GsCodeSysId = entity.GsCodeSysId;
						}

					}

					if (entity.GsCodeApprovalFuncCollection.Count > 0 || entity.GsCodeApprovalFuncCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCodeApprovalFuncProvider.Save(transactionManager, entity.GsCodeApprovalFuncCollection);
						
						deepHandles.Add("GsCodeApprovalFuncCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCodeApprovalFunc >) DataRepository.GsCodeApprovalFuncProvider.DeepSave,
							new object[] { transactionManager, entity.GsCodeApprovalFuncCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCodeSysChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeSys</c>
	///</summary>
	public enum GsCodeSysChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCodeSys</c> as OneToMany for GsCodeApprovalFuncCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCodeApprovalFunc>))]
		GsCodeApprovalFuncCollection,
	}
	
	#endregion GsCodeSysChildEntityTypes
	
	#region GsCodeSysFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeSysColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeSys"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeSysFilterBuilder : SqlFilterBuilder<GsCodeSysColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeSysFilterBuilder class.
		/// </summary>
		public GsCodeSysFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeSysFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeSysFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeSysFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeSysFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeSysFilterBuilder
	
	#region GsCodeSysParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeSysColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeSys"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeSysParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeSysColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeSysParameterBuilder class.
		/// </summary>
		public GsCodeSysParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeSysParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeSysParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeSysParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeSysParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeSysParameterBuilder
	
	#region GsCodeSysSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeSysColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeSys"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeSysSortBuilder : SqlSortBuilder<GsCodeSysColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeSysSqlSortBuilder class.
		/// </summary>
		public GsCodeSysSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeSysSortBuilder
	
} // end namespace
