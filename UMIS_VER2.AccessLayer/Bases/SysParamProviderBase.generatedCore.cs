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
	/// This class is the base class for any <see cref="SysParamProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SysParamProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SysParam, UMIS_VER2.BusinessLyer.SysParamKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SysParamKey key)
		{
			return Delete(transactionManager, key.SysParamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_sysParamId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _sysParamId)
		{
			return Delete(null, _sysParamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysParamId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _sysParamId);		
		
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
		public override UMIS_VER2.BusinessLyer.SysParam Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SysParamKey key, int start, int pageLength)
		{
			return GetBySysParamId(transactionManager, key.SysParamId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SYS_PARAM index.
		/// </summary>
		/// <param name="_sysParamId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysParam GetBySysParamId(System.Decimal _sysParamId)
		{
			int count = -1;
			return GetBySysParamId(null,_sysParamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_PARAM index.
		/// </summary>
		/// <param name="_sysParamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysParam GetBySysParamId(System.Decimal _sysParamId, int start, int pageLength)
		{
			int count = -1;
			return GetBySysParamId(null, _sysParamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_PARAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysParamId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysParam GetBySysParamId(TransactionManager transactionManager, System.Decimal _sysParamId)
		{
			int count = -1;
			return GetBySysParamId(transactionManager, _sysParamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_PARAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysParamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysParam GetBySysParamId(TransactionManager transactionManager, System.Decimal _sysParamId, int start, int pageLength)
		{
			int count = -1;
			return GetBySysParamId(transactionManager, _sysParamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_PARAM index.
		/// </summary>
		/// <param name="_sysParamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysParam GetBySysParamId(System.Decimal _sysParamId, int start, int pageLength, out int count)
		{
			return GetBySysParamId(null, _sysParamId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_PARAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysParamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysParam"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SysParam GetBySysParamId(TransactionManager transactionManager, System.Decimal _sysParamId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SysParam&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SysParam&gt;"/></returns>
		public static TList<SysParam> Fill(IDataReader reader, TList<SysParam> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SysParam c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SysParam")
					.Append("|").Append((System.Decimal)reader["SYS_PARAM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SysParam>(
					key.ToString(), // EntityTrackingKey
					"SysParam",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SysParam();
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
					c.SysParamId = (System.Decimal)reader["SYS_PARAM_ID"];
					c.OriginalSysParamId = c.SysParamId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.PrmValue = (System.String)reader["PRM_VALUE"];
					c.HideFlg = Convert.IsDBNull(reader["HIDE_FLG"]) ? null : (System.Decimal?)reader["HIDE_FLG"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.OrderValue = Convert.IsDBNull(reader["ORDER_VALUE"]) ? null : (System.Decimal?)reader["ORDER_VALUE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SysParam"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SysParam"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SysParam entity)
		{
			if (!reader.Read()) return;
			
			entity.SysParamId = (System.Decimal)reader[((int)SysParamColumn.SysParamId - 1)];
			entity.OriginalSysParamId = (System.Decimal)reader["SYS_PARAM_ID"];
			entity.DescrAr = (System.String)reader[((int)SysParamColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)SysParamColumn.DescrEn - 1)];
			entity.PrmValue = (System.String)reader[((int)SysParamColumn.PrmValue - 1)];
			entity.HideFlg = (reader.IsDBNull(((int)SysParamColumn.HideFlg - 1)))?null:(System.Decimal?)reader[((int)SysParamColumn.HideFlg - 1)];
			entity.Notes = (reader.IsDBNull(((int)SysParamColumn.Notes - 1)))?null:(System.String)reader[((int)SysParamColumn.Notes - 1)];
			entity.OrderValue = (reader.IsDBNull(((int)SysParamColumn.OrderValue - 1)))?null:(System.Decimal?)reader[((int)SysParamColumn.OrderValue - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SysParam"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SysParam"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SysParam entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SysParamId = (System.Decimal)dataRow["SYS_PARAM_ID"];
			entity.OriginalSysParamId = (System.Decimal)dataRow["SYS_PARAM_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.PrmValue = (System.String)dataRow["PRM_VALUE"];
			entity.HideFlg = Convert.IsDBNull(dataRow["HIDE_FLG"]) ? null : (System.Decimal?)dataRow["HIDE_FLG"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.OrderValue = Convert.IsDBNull(dataRow["ORDER_VALUE"]) ? null : (System.Decimal?)dataRow["ORDER_VALUE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SysParam"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SysParam Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SysParam entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SysParam object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SysParam instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SysParam Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SysParam entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region SysParamChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SysParam</c>
	///</summary>
	public enum SysParamChildEntityTypes
	{
	}
	
	#endregion SysParamChildEntityTypes
	
	#region SysParamFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SysParamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SysParam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SysParamFilterBuilder : SqlFilterBuilder<SysParamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SysParamFilterBuilder class.
		/// </summary>
		public SysParamFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SysParamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SysParamFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SysParamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SysParamFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SysParamFilterBuilder
	
	#region SysParamParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SysParamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SysParam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SysParamParameterBuilder : ParameterizedSqlFilterBuilder<SysParamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SysParamParameterBuilder class.
		/// </summary>
		public SysParamParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SysParamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SysParamParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SysParamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SysParamParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SysParamParameterBuilder
	
	#region SysParamSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SysParamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SysParam"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SysParamSortBuilder : SqlSortBuilder<SysParamColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SysParamSqlSortBuilder class.
		/// </summary>
		public SysParamSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SysParamSortBuilder
	
} // end namespace
