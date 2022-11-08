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
	/// This class is the base class for any <see cref="IntegUserAdLogHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class IntegUserAdLogHdrProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.IntegUserAdLogHdr, UMIS_VER2.BusinessLyer.IntegUserAdLogHdrKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegUserAdLogHdrKey key)
		{
			return Delete(transactionManager, key.IntegUserAdLogHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_integUserAdLogHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _integUserAdLogHdrId)
		{
			return Delete(null, _integUserAdLogHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integUserAdLogHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _integUserAdLogHdrId);		
		
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
		public override UMIS_VER2.BusinessLyer.IntegUserAdLogHdr Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegUserAdLogHdrKey key, int start, int pageLength)
		{
			return GetByIntegUserAdLogHdrId(transactionManager, key.IntegUserAdLogHdrId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_INTEG_USER_AD_LOG_HDR index.
		/// </summary>
		/// <param name="_integUserAdLogHdrId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegUserAdLogHdr GetByIntegUserAdLogHdrId(System.Decimal _integUserAdLogHdrId)
		{
			int count = -1;
			return GetByIntegUserAdLogHdrId(null,_integUserAdLogHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_USER_AD_LOG_HDR index.
		/// </summary>
		/// <param name="_integUserAdLogHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegUserAdLogHdr GetByIntegUserAdLogHdrId(System.Decimal _integUserAdLogHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegUserAdLogHdrId(null, _integUserAdLogHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_USER_AD_LOG_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integUserAdLogHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegUserAdLogHdr GetByIntegUserAdLogHdrId(TransactionManager transactionManager, System.Decimal _integUserAdLogHdrId)
		{
			int count = -1;
			return GetByIntegUserAdLogHdrId(transactionManager, _integUserAdLogHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_USER_AD_LOG_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integUserAdLogHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegUserAdLogHdr GetByIntegUserAdLogHdrId(TransactionManager transactionManager, System.Decimal _integUserAdLogHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegUserAdLogHdrId(transactionManager, _integUserAdLogHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_USER_AD_LOG_HDR index.
		/// </summary>
		/// <param name="_integUserAdLogHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegUserAdLogHdr GetByIntegUserAdLogHdrId(System.Decimal _integUserAdLogHdrId, int start, int pageLength, out int count)
		{
			return GetByIntegUserAdLogHdrId(null, _integUserAdLogHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_USER_AD_LOG_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integUserAdLogHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.IntegUserAdLogHdr GetByIntegUserAdLogHdrId(TransactionManager transactionManager, System.Decimal _integUserAdLogHdrId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;IntegUserAdLogHdr&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;IntegUserAdLogHdr&gt;"/></returns>
		public static TList<IntegUserAdLogHdr> Fill(IDataReader reader, TList<IntegUserAdLogHdr> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.IntegUserAdLogHdr c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("IntegUserAdLogHdr")
					.Append("|").Append((System.Decimal)reader["INTEG_USER_AD_LOG_HDR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<IntegUserAdLogHdr>(
					key.ToString(), // EntityTrackingKey
					"IntegUserAdLogHdr",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.IntegUserAdLogHdr();
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
					c.IntegUserAdLogHdrId = (System.Decimal)reader["INTEG_USER_AD_LOG_HDR_ID"];
					c.OriginalIntegUserAdLogHdrId = c.IntegUserAdLogHdrId;
					c.IterationNum = Convert.IsDBNull(reader["ITERATION_NUM"]) ? null : (System.Int32?)reader["ITERATION_NUM"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogHdr"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogHdr"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.IntegUserAdLogHdr entity)
		{
			if (!reader.Read()) return;
			
			entity.IntegUserAdLogHdrId = (System.Decimal)reader[((int)IntegUserAdLogHdrColumn.IntegUserAdLogHdrId - 1)];
			entity.OriginalIntegUserAdLogHdrId = (System.Decimal)reader["INTEG_USER_AD_LOG_HDR_ID"];
			entity.IterationNum = (reader.IsDBNull(((int)IntegUserAdLogHdrColumn.IterationNum - 1)))?null:(System.Int32?)reader[((int)IntegUserAdLogHdrColumn.IterationNum - 1)];
			entity.LastDate = (reader.IsDBNull(((int)IntegUserAdLogHdrColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)IntegUserAdLogHdrColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)IntegUserAdLogHdrColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)IntegUserAdLogHdrColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogHdr"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogHdr"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.IntegUserAdLogHdr entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.IntegUserAdLogHdrId = (System.Decimal)dataRow["INTEG_USER_AD_LOG_HDR_ID"];
			entity.OriginalIntegUserAdLogHdrId = (System.Decimal)dataRow["INTEG_USER_AD_LOG_HDR_ID"];
			entity.IterationNum = Convert.IsDBNull(dataRow["ITERATION_NUM"]) ? null : (System.Int32?)dataRow["ITERATION_NUM"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogHdr"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegUserAdLogHdr Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegUserAdLogHdr entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByIntegUserAdLogHdrId methods when available
			
			#region IntegUserAdLogDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<IntegUserAdLogDtl>|IntegUserAdLogDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'IntegUserAdLogDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.IntegUserAdLogDtlCollection = DataRepository.IntegUserAdLogDtlProvider.GetByIntegUserAdLogHdrId(transactionManager, entity.IntegUserAdLogHdrId);

				if (deep && entity.IntegUserAdLogDtlCollection.Count > 0)
				{
					deepHandles.Add("IntegUserAdLogDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<IntegUserAdLogDtl>) DataRepository.IntegUserAdLogDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.IntegUserAdLogDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.IntegUserAdLogHdr object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.IntegUserAdLogHdr instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegUserAdLogHdr Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegUserAdLogHdr entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<IntegUserAdLogDtl>
				if (CanDeepSave(entity.IntegUserAdLogDtlCollection, "List<IntegUserAdLogDtl>|IntegUserAdLogDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(IntegUserAdLogDtl child in entity.IntegUserAdLogDtlCollection)
					{
						if(child.IntegUserAdLogHdrIdSource != null)
						{
							child.IntegUserAdLogHdrId = child.IntegUserAdLogHdrIdSource.IntegUserAdLogHdrId;
						}
						else
						{
							child.IntegUserAdLogHdrId = entity.IntegUserAdLogHdrId;
						}

					}

					if (entity.IntegUserAdLogDtlCollection.Count > 0 || entity.IntegUserAdLogDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.IntegUserAdLogDtlProvider.Save(transactionManager, entity.IntegUserAdLogDtlCollection);
						
						deepHandles.Add("IntegUserAdLogDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< IntegUserAdLogDtl >) DataRepository.IntegUserAdLogDtlProvider.DeepSave,
							new object[] { transactionManager, entity.IntegUserAdLogDtlCollection, deepSaveType, childTypes, innerList }
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
	
	#region IntegUserAdLogHdrChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.IntegUserAdLogHdr</c>
	///</summary>
	public enum IntegUserAdLogHdrChildEntityTypes
	{
		///<summary>
		/// Collection of <c>IntegUserAdLogHdr</c> as OneToMany for IntegUserAdLogDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<IntegUserAdLogDtl>))]
		IntegUserAdLogDtlCollection,
	}
	
	#endregion IntegUserAdLogHdrChildEntityTypes
	
	#region IntegUserAdLogHdrFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;IntegUserAdLogHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegUserAdLogHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegUserAdLogHdrFilterBuilder : SqlFilterBuilder<IntegUserAdLogHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegUserAdLogHdrFilterBuilder class.
		/// </summary>
		public IntegUserAdLogHdrFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegUserAdLogHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegUserAdLogHdrFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegUserAdLogHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegUserAdLogHdrFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegUserAdLogHdrFilterBuilder
	
	#region IntegUserAdLogHdrParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;IntegUserAdLogHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegUserAdLogHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegUserAdLogHdrParameterBuilder : ParameterizedSqlFilterBuilder<IntegUserAdLogHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegUserAdLogHdrParameterBuilder class.
		/// </summary>
		public IntegUserAdLogHdrParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegUserAdLogHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegUserAdLogHdrParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegUserAdLogHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegUserAdLogHdrParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegUserAdLogHdrParameterBuilder
	
	#region IntegUserAdLogHdrSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;IntegUserAdLogHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegUserAdLogHdr"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class IntegUserAdLogHdrSortBuilder : SqlSortBuilder<IntegUserAdLogHdrColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegUserAdLogHdrSqlSortBuilder class.
		/// </summary>
		public IntegUserAdLogHdrSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion IntegUserAdLogHdrSortBuilder
	
} // end namespace
