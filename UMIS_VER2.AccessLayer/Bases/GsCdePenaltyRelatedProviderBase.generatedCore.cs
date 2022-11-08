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
	/// This class is the base class for any <see cref="GsCdePenaltyRelatedProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdePenaltyRelatedProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdePenaltyRelated, UMIS_VER2.BusinessLyer.GsCdePenaltyRelatedKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdePenaltyRelatedKey key)
		{
			return Delete(transactionManager, key.GsCdePenaltyRelatedId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdePenaltyRelatedId">XXX. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdePenaltyRelatedId)
		{
			return Delete(null, _gsCdePenaltyRelatedId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyRelatedId">XXX. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdePenaltyRelatedId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCdePenaltyRelated Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdePenaltyRelatedKey key, int start, int pageLength)
		{
			return GetByGsCdePenaltyRelatedId(transactionManager, key.GsCdePenaltyRelatedId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_PENALTY_RELATED index.
		/// </summary>
		/// <param name="_gsCdePenaltyRelatedId">XXX</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdePenaltyRelated"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdePenaltyRelated GetByGsCdePenaltyRelatedId(System.Decimal _gsCdePenaltyRelatedId)
		{
			int count = -1;
			return GetByGsCdePenaltyRelatedId(null,_gsCdePenaltyRelatedId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_PENALTY_RELATED index.
		/// </summary>
		/// <param name="_gsCdePenaltyRelatedId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdePenaltyRelated"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdePenaltyRelated GetByGsCdePenaltyRelatedId(System.Decimal _gsCdePenaltyRelatedId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdePenaltyRelatedId(null, _gsCdePenaltyRelatedId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_PENALTY_RELATED index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyRelatedId">XXX</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdePenaltyRelated"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdePenaltyRelated GetByGsCdePenaltyRelatedId(TransactionManager transactionManager, System.Decimal _gsCdePenaltyRelatedId)
		{
			int count = -1;
			return GetByGsCdePenaltyRelatedId(transactionManager, _gsCdePenaltyRelatedId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_PENALTY_RELATED index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyRelatedId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdePenaltyRelated"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdePenaltyRelated GetByGsCdePenaltyRelatedId(TransactionManager transactionManager, System.Decimal _gsCdePenaltyRelatedId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdePenaltyRelatedId(transactionManager, _gsCdePenaltyRelatedId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_PENALTY_RELATED index.
		/// </summary>
		/// <param name="_gsCdePenaltyRelatedId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdePenaltyRelated"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdePenaltyRelated GetByGsCdePenaltyRelatedId(System.Decimal _gsCdePenaltyRelatedId, int start, int pageLength, out int count)
		{
			return GetByGsCdePenaltyRelatedId(null, _gsCdePenaltyRelatedId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_PENALTY_RELATED index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyRelatedId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdePenaltyRelated"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdePenaltyRelated GetByGsCdePenaltyRelatedId(TransactionManager transactionManager, System.Decimal _gsCdePenaltyRelatedId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdePenaltyRelated&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdePenaltyRelated&gt;"/></returns>
		public static TList<GsCdePenaltyRelated> Fill(IDataReader reader, TList<GsCdePenaltyRelated> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdePenaltyRelated c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdePenaltyRelated")
					.Append("|").Append((System.Decimal)reader["GS_CDE_PENALTY_RELATED_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdePenaltyRelated>(
					key.ToString(), // EntityTrackingKey
					"GsCdePenaltyRelated",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdePenaltyRelated();
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
					c.GsCdePenaltyRelatedId = (System.Decimal)reader["GS_CDE_PENALTY_RELATED_ID"];
					c.OriginalGsCdePenaltyRelatedId = c.GsCdePenaltyRelatedId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdePenaltyRelated"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdePenaltyRelated"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdePenaltyRelated entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdePenaltyRelatedId = (System.Decimal)reader[((int)GsCdePenaltyRelatedColumn.GsCdePenaltyRelatedId - 1)];
			entity.OriginalGsCdePenaltyRelatedId = (System.Decimal)reader["GS_CDE_PENALTY_RELATED_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCdePenaltyRelatedColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)GsCdePenaltyRelatedColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdePenaltyRelated"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdePenaltyRelated"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdePenaltyRelated entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdePenaltyRelatedId = (System.Decimal)dataRow["GS_CDE_PENALTY_RELATED_ID"];
			entity.OriginalGsCdePenaltyRelatedId = (System.Decimal)dataRow["GS_CDE_PENALTY_RELATED_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdePenaltyRelated"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdePenaltyRelated Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdePenaltyRelated entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdePenaltyRelated object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdePenaltyRelated instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdePenaltyRelated Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdePenaltyRelated entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GsCdePenaltyRelatedChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdePenaltyRelated</c>
	///</summary>
	public enum GsCdePenaltyRelatedChildEntityTypes
	{
	}
	
	#endregion GsCdePenaltyRelatedChildEntityTypes
	
	#region GsCdePenaltyRelatedFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdePenaltyRelatedColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdePenaltyRelated"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdePenaltyRelatedFilterBuilder : SqlFilterBuilder<GsCdePenaltyRelatedColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdePenaltyRelatedFilterBuilder class.
		/// </summary>
		public GsCdePenaltyRelatedFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdePenaltyRelatedFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdePenaltyRelatedFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdePenaltyRelatedFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdePenaltyRelatedFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdePenaltyRelatedFilterBuilder
	
	#region GsCdePenaltyRelatedParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdePenaltyRelatedColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdePenaltyRelated"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdePenaltyRelatedParameterBuilder : ParameterizedSqlFilterBuilder<GsCdePenaltyRelatedColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdePenaltyRelatedParameterBuilder class.
		/// </summary>
		public GsCdePenaltyRelatedParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdePenaltyRelatedParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdePenaltyRelatedParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdePenaltyRelatedParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdePenaltyRelatedParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdePenaltyRelatedParameterBuilder
	
	#region GsCdePenaltyRelatedSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdePenaltyRelatedColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdePenaltyRelated"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdePenaltyRelatedSortBuilder : SqlSortBuilder<GsCdePenaltyRelatedColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdePenaltyRelatedSqlSortBuilder class.
		/// </summary>
		public GsCdePenaltyRelatedSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdePenaltyRelatedSortBuilder
	
} // end namespace
