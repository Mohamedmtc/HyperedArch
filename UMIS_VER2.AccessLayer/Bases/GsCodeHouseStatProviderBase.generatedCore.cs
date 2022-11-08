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
	/// This class is the base class for any <see cref="GsCodeHouseStatProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeHouseStatProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeHouseStat, UMIS_VER2.BusinessLyer.GsCodeHouseStatKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeHouseStatKey key)
		{
			return Delete(transactionManager, key.GsCodeHouseStatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeHouseStatId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeHouseStatId)
		{
			return Delete(null, _gsCodeHouseStatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeHouseStatId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeHouseStatId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeHouseStat Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeHouseStatKey key, int start, int pageLength)
		{
			return GetByGsCodeHouseStatId(transactionManager, key.GsCodeHouseStatId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HOUSE_STAT index.
		/// </summary>
		/// <param name="_gsCodeHouseStatId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeHouseStat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeHouseStat GetByGsCodeHouseStatId(System.Decimal _gsCodeHouseStatId)
		{
			int count = -1;
			return GetByGsCodeHouseStatId(null,_gsCodeHouseStatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HOUSE_STAT index.
		/// </summary>
		/// <param name="_gsCodeHouseStatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeHouseStat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeHouseStat GetByGsCodeHouseStatId(System.Decimal _gsCodeHouseStatId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeHouseStatId(null, _gsCodeHouseStatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HOUSE_STAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeHouseStatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeHouseStat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeHouseStat GetByGsCodeHouseStatId(TransactionManager transactionManager, System.Decimal _gsCodeHouseStatId)
		{
			int count = -1;
			return GetByGsCodeHouseStatId(transactionManager, _gsCodeHouseStatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HOUSE_STAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeHouseStatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeHouseStat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeHouseStat GetByGsCodeHouseStatId(TransactionManager transactionManager, System.Decimal _gsCodeHouseStatId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeHouseStatId(transactionManager, _gsCodeHouseStatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HOUSE_STAT index.
		/// </summary>
		/// <param name="_gsCodeHouseStatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeHouseStat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeHouseStat GetByGsCodeHouseStatId(System.Decimal _gsCodeHouseStatId, int start, int pageLength, out int count)
		{
			return GetByGsCodeHouseStatId(null, _gsCodeHouseStatId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HOUSE_STAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeHouseStatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeHouseStat"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeHouseStat GetByGsCodeHouseStatId(TransactionManager transactionManager, System.Decimal _gsCodeHouseStatId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeHouseStat&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeHouseStat&gt;"/></returns>
		public static TList<GsCodeHouseStat> Fill(IDataReader reader, TList<GsCodeHouseStat> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeHouseStat c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeHouseStat")
					.Append("|").Append((System.Decimal)reader["GS_CODE_HOUSE_STAT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeHouseStat>(
					key.ToString(), // EntityTrackingKey
					"GsCodeHouseStat",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeHouseStat();
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
					c.GsCodeHouseStatId = (System.Decimal)reader["GS_CODE_HOUSE_STAT_ID"];
					c.OriginalGsCodeHouseStatId = c.GsCodeHouseStatId;
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeHouseStat"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeHouseStat"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeHouseStat entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeHouseStatId = (System.Decimal)reader[((int)GsCodeHouseStatColumn.GsCodeHouseStatId - 1)];
			entity.OriginalGsCodeHouseStatId = (System.Decimal)reader["GS_CODE_HOUSE_STAT_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCodeHouseStatColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)GsCodeHouseStatColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeHouseStat"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeHouseStat"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeHouseStat entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeHouseStatId = (System.Decimal)dataRow["GS_CODE_HOUSE_STAT_ID"];
			entity.OriginalGsCodeHouseStatId = (System.Decimal)dataRow["GS_CODE_HOUSE_STAT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeHouseStat"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeHouseStat Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeHouseStat entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeHouseStat object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeHouseStat instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeHouseStat Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeHouseStat entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GsCodeHouseStatChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeHouseStat</c>
	///</summary>
	public enum GsCodeHouseStatChildEntityTypes
	{
	}
	
	#endregion GsCodeHouseStatChildEntityTypes
	
	#region GsCodeHouseStatFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeHouseStatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeHouseStat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeHouseStatFilterBuilder : SqlFilterBuilder<GsCodeHouseStatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeHouseStatFilterBuilder class.
		/// </summary>
		public GsCodeHouseStatFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeHouseStatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeHouseStatFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeHouseStatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeHouseStatFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeHouseStatFilterBuilder
	
	#region GsCodeHouseStatParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeHouseStatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeHouseStat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeHouseStatParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeHouseStatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeHouseStatParameterBuilder class.
		/// </summary>
		public GsCodeHouseStatParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeHouseStatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeHouseStatParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeHouseStatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeHouseStatParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeHouseStatParameterBuilder
	
	#region GsCodeHouseStatSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeHouseStatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeHouseStat"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeHouseStatSortBuilder : SqlSortBuilder<GsCodeHouseStatColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeHouseStatSqlSortBuilder class.
		/// </summary>
		public GsCodeHouseStatSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeHouseStatSortBuilder
	
} // end namespace
