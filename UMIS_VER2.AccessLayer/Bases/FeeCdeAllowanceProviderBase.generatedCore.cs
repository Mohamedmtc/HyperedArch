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
	/// This class is the base class for any <see cref="FeeCdeAllowanceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeCdeAllowanceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeCdeAllowance, UMIS_VER2.BusinessLyer.FeeCdeAllowanceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeAllowanceKey key)
		{
			return Delete(transactionManager, key.FeeCdeAllowanceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _feeCdeAllowanceId)
		{
			return Delete(null, _feeCdeAllowanceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _feeCdeAllowanceId);		
		
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
		public override UMIS_VER2.BusinessLyer.FeeCdeAllowance Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeAllowanceKey key, int start, int pageLength)
		{
			return GetByFeeCdeAllowanceId(transactionManager, key.FeeCdeAllowanceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_CDE_ALLOWANCE index.
		/// </summary>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeAllowance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeAllowance GetByFeeCdeAllowanceId(System.Int32 _feeCdeAllowanceId)
		{
			int count = -1;
			return GetByFeeCdeAllowanceId(null,_feeCdeAllowanceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_ALLOWANCE index.
		/// </summary>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeAllowance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeAllowance GetByFeeCdeAllowanceId(System.Int32 _feeCdeAllowanceId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeAllowanceId(null, _feeCdeAllowanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_ALLOWANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeAllowance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeAllowance GetByFeeCdeAllowanceId(TransactionManager transactionManager, System.Int32 _feeCdeAllowanceId)
		{
			int count = -1;
			return GetByFeeCdeAllowanceId(transactionManager, _feeCdeAllowanceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_ALLOWANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeAllowance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeAllowance GetByFeeCdeAllowanceId(TransactionManager transactionManager, System.Int32 _feeCdeAllowanceId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeAllowanceId(transactionManager, _feeCdeAllowanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_ALLOWANCE index.
		/// </summary>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeAllowance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeAllowance GetByFeeCdeAllowanceId(System.Int32 _feeCdeAllowanceId, int start, int pageLength, out int count)
		{
			return GetByFeeCdeAllowanceId(null, _feeCdeAllowanceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_ALLOWANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeAllowance"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCdeAllowance GetByFeeCdeAllowanceId(TransactionManager transactionManager, System.Int32 _feeCdeAllowanceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeCdeAllowance&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeCdeAllowance&gt;"/></returns>
		public static TList<FeeCdeAllowance> Fill(IDataReader reader, TList<FeeCdeAllowance> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeCdeAllowance c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeCdeAllowance")
					.Append("|").Append((System.Int32)reader["FEE_CDE_ALLOWANCE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeCdeAllowance>(
					key.ToString(), // EntityTrackingKey
					"FeeCdeAllowance",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeCdeAllowance();
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
					c.FeeCdeAllowanceId = (System.Int32)reader["FEE_CDE_ALLOWANCE_ID"];
					c.OriginalFeeCdeAllowanceId = c.FeeCdeAllowanceId;
					c.AllowanceAr = Convert.IsDBNull(reader["ALLOWANCE_AR"]) ? null : (System.String)reader["ALLOWANCE_AR"];
					c.AllowanceEn = Convert.IsDBNull(reader["ALLOWANCE_EN"]) ? null : (System.String)reader["ALLOWANCE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeAllowance"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeAllowance"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeCdeAllowance entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeCdeAllowanceId = (System.Int32)reader[((int)FeeCdeAllowanceColumn.FeeCdeAllowanceId - 1)];
			entity.OriginalFeeCdeAllowanceId = (System.Int32)reader["FEE_CDE_ALLOWANCE_ID"];
			entity.AllowanceAr = (reader.IsDBNull(((int)FeeCdeAllowanceColumn.AllowanceAr - 1)))?null:(System.String)reader[((int)FeeCdeAllowanceColumn.AllowanceAr - 1)];
			entity.AllowanceEn = (reader.IsDBNull(((int)FeeCdeAllowanceColumn.AllowanceEn - 1)))?null:(System.String)reader[((int)FeeCdeAllowanceColumn.AllowanceEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeAllowance"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeAllowance"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeCdeAllowance entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeCdeAllowanceId = (System.Int32)dataRow["FEE_CDE_ALLOWANCE_ID"];
			entity.OriginalFeeCdeAllowanceId = (System.Int32)dataRow["FEE_CDE_ALLOWANCE_ID"];
			entity.AllowanceAr = Convert.IsDBNull(dataRow["ALLOWANCE_AR"]) ? null : (System.String)dataRow["ALLOWANCE_AR"];
			entity.AllowanceEn = Convert.IsDBNull(dataRow["ALLOWANCE_EN"]) ? null : (System.String)dataRow["ALLOWANCE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeAllowance"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeAllowance Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeAllowance entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeCdeAllowanceId methods when available
			
			#region FeeAllowanceRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeAllowanceRule>|FeeAllowanceRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeAllowanceRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeAllowanceRuleCollection = DataRepository.FeeAllowanceRuleProvider.GetByFeeCdeAllowanceId(transactionManager, entity.FeeCdeAllowanceId);

				if (deep && entity.FeeAllowanceRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeAllowanceRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeAllowanceRule>) DataRepository.FeeAllowanceRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeAllowanceRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudAllowanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudAllowance>|FeeStudAllowanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudAllowanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudAllowanceCollection = DataRepository.FeeStudAllowanceProvider.GetByFeeCdeAllowanceId(transactionManager, entity.FeeCdeAllowanceId);

				if (deep && entity.FeeStudAllowanceCollection.Count > 0)
				{
					deepHandles.Add("FeeStudAllowanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudAllowance>) DataRepository.FeeStudAllowanceProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudAllowanceCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeCdeAllowance object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeCdeAllowance instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeAllowance Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeAllowance entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<FeeAllowanceRule>
				if (CanDeepSave(entity.FeeAllowanceRuleCollection, "List<FeeAllowanceRule>|FeeAllowanceRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeAllowanceRule child in entity.FeeAllowanceRuleCollection)
					{
						if(child.FeeCdeAllowanceIdSource != null)
						{
							child.FeeCdeAllowanceId = child.FeeCdeAllowanceIdSource.FeeCdeAllowanceId;
						}
						else
						{
							child.FeeCdeAllowanceId = entity.FeeCdeAllowanceId;
						}

					}

					if (entity.FeeAllowanceRuleCollection.Count > 0 || entity.FeeAllowanceRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeAllowanceRuleProvider.Save(transactionManager, entity.FeeAllowanceRuleCollection);
						
						deepHandles.Add("FeeAllowanceRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeAllowanceRule >) DataRepository.FeeAllowanceRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeAllowanceRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudAllowance>
				if (CanDeepSave(entity.FeeStudAllowanceCollection, "List<FeeStudAllowance>|FeeStudAllowanceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudAllowance child in entity.FeeStudAllowanceCollection)
					{
						if(child.FeeCdeAllowanceIdSource != null)
						{
							child.FeeCdeAllowanceId = child.FeeCdeAllowanceIdSource.FeeCdeAllowanceId;
						}
						else
						{
							child.FeeCdeAllowanceId = entity.FeeCdeAllowanceId;
						}

					}

					if (entity.FeeStudAllowanceCollection.Count > 0 || entity.FeeStudAllowanceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudAllowanceProvider.Save(transactionManager, entity.FeeStudAllowanceCollection);
						
						deepHandles.Add("FeeStudAllowanceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudAllowance >) DataRepository.FeeStudAllowanceProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudAllowanceCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeCdeAllowanceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeCdeAllowance</c>
	///</summary>
	public enum FeeCdeAllowanceChildEntityTypes
	{
		///<summary>
		/// Collection of <c>FeeCdeAllowance</c> as OneToMany for FeeAllowanceRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeAllowanceRule>))]
		FeeAllowanceRuleCollection,
		///<summary>
		/// Collection of <c>FeeCdeAllowance</c> as OneToMany for FeeStudAllowanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudAllowance>))]
		FeeStudAllowanceCollection,
	}
	
	#endregion FeeCdeAllowanceChildEntityTypes
	
	#region FeeCdeAllowanceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeCdeAllowanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeAllowance"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeAllowanceFilterBuilder : SqlFilterBuilder<FeeCdeAllowanceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeAllowanceFilterBuilder class.
		/// </summary>
		public FeeCdeAllowanceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeAllowanceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeAllowanceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeAllowanceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeAllowanceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeAllowanceFilterBuilder
	
	#region FeeCdeAllowanceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeCdeAllowanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeAllowance"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeAllowanceParameterBuilder : ParameterizedSqlFilterBuilder<FeeCdeAllowanceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeAllowanceParameterBuilder class.
		/// </summary>
		public FeeCdeAllowanceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeAllowanceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeAllowanceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeAllowanceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeAllowanceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeAllowanceParameterBuilder
	
	#region FeeCdeAllowanceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeCdeAllowanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeAllowance"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeCdeAllowanceSortBuilder : SqlSortBuilder<FeeCdeAllowanceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeAllowanceSqlSortBuilder class.
		/// </summary>
		public FeeCdeAllowanceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeCdeAllowanceSortBuilder
	
} // end namespace
