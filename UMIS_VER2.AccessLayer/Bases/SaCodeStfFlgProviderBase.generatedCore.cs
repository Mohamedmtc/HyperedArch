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
	/// This class is the base class for any <see cref="SaCodeStfFlgProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeStfFlgProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeStfFlg, UMIS_VER2.BusinessLyer.SaCodeStfFlgKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeStfFlgKey key)
		{
			return Delete(transactionManager, key.SaStfFlgId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saStfFlgId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saStfFlgId)
		{
			return Delete(null, _saStfFlgId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfFlgId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saStfFlgId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeStfFlg Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeStfFlgKey key, int start, int pageLength)
		{
			return GetBySaStfFlgId(transactionManager, key.SaStfFlgId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_STF_FLG index.
		/// </summary>
		/// <param name="_saStfFlgId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeStfFlg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeStfFlg GetBySaStfFlgId(System.Decimal _saStfFlgId)
		{
			int count = -1;
			return GetBySaStfFlgId(null,_saStfFlgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_STF_FLG index.
		/// </summary>
		/// <param name="_saStfFlgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeStfFlg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeStfFlg GetBySaStfFlgId(System.Decimal _saStfFlgId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfFlgId(null, _saStfFlgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_STF_FLG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfFlgId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeStfFlg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeStfFlg GetBySaStfFlgId(TransactionManager transactionManager, System.Decimal _saStfFlgId)
		{
			int count = -1;
			return GetBySaStfFlgId(transactionManager, _saStfFlgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_STF_FLG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfFlgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeStfFlg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeStfFlg GetBySaStfFlgId(TransactionManager transactionManager, System.Decimal _saStfFlgId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfFlgId(transactionManager, _saStfFlgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_STF_FLG index.
		/// </summary>
		/// <param name="_saStfFlgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeStfFlg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeStfFlg GetBySaStfFlgId(System.Decimal _saStfFlgId, int start, int pageLength, out int count)
		{
			return GetBySaStfFlgId(null, _saStfFlgId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_STF_FLG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfFlgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeStfFlg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeStfFlg GetBySaStfFlgId(TransactionManager transactionManager, System.Decimal _saStfFlgId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeStfFlg&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeStfFlg&gt;"/></returns>
		public static TList<SaCodeStfFlg> Fill(IDataReader reader, TList<SaCodeStfFlg> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeStfFlg c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeStfFlg")
					.Append("|").Append((System.Decimal)reader["SA_STF_FLG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeStfFlg>(
					key.ToString(), // EntityTrackingKey
					"SaCodeStfFlg",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeStfFlg();
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
					c.SaStfFlgId = (System.Decimal)reader["SA_STF_FLG_ID"];
					c.OriginalSaStfFlgId = c.SaStfFlgId;
					c.StfFlgDescAr = (System.String)reader["STF_FLG_DESC_AR"];
					c.StfFlgDescEn = Convert.IsDBNull(reader["STF_FLG_DESC_EN"]) ? null : (System.String)reader["STF_FLG_DESC_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeStfFlg"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeStfFlg"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeStfFlg entity)
		{
			if (!reader.Read()) return;
			
			entity.SaStfFlgId = (System.Decimal)reader[((int)SaCodeStfFlgColumn.SaStfFlgId - 1)];
			entity.OriginalSaStfFlgId = (System.Decimal)reader["SA_STF_FLG_ID"];
			entity.StfFlgDescAr = (System.String)reader[((int)SaCodeStfFlgColumn.StfFlgDescAr - 1)];
			entity.StfFlgDescEn = (reader.IsDBNull(((int)SaCodeStfFlgColumn.StfFlgDescEn - 1)))?null:(System.String)reader[((int)SaCodeStfFlgColumn.StfFlgDescEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeStfFlg"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeStfFlg"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeStfFlg entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaStfFlgId = (System.Decimal)dataRow["SA_STF_FLG_ID"];
			entity.OriginalSaStfFlgId = (System.Decimal)dataRow["SA_STF_FLG_ID"];
			entity.StfFlgDescAr = (System.String)dataRow["STF_FLG_DESC_AR"];
			entity.StfFlgDescEn = Convert.IsDBNull(dataRow["STF_FLG_DESC_EN"]) ? null : (System.String)dataRow["STF_FLG_DESC_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeStfFlg"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeStfFlg Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeStfFlg entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeStfFlg object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeStfFlg instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeStfFlg Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeStfFlg entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region SaCodeStfFlgChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeStfFlg</c>
	///</summary>
	public enum SaCodeStfFlgChildEntityTypes
	{
	}
	
	#endregion SaCodeStfFlgChildEntityTypes
	
	#region SaCodeStfFlgFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeStfFlgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeStfFlg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeStfFlgFilterBuilder : SqlFilterBuilder<SaCodeStfFlgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeStfFlgFilterBuilder class.
		/// </summary>
		public SaCodeStfFlgFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeStfFlgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeStfFlgFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeStfFlgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeStfFlgFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeStfFlgFilterBuilder
	
	#region SaCodeStfFlgParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeStfFlgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeStfFlg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeStfFlgParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeStfFlgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeStfFlgParameterBuilder class.
		/// </summary>
		public SaCodeStfFlgParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeStfFlgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeStfFlgParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeStfFlgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeStfFlgParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeStfFlgParameterBuilder
	
	#region SaCodeStfFlgSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeStfFlgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeStfFlg"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeStfFlgSortBuilder : SqlSortBuilder<SaCodeStfFlgColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeStfFlgSqlSortBuilder class.
		/// </summary>
		public SaCodeStfFlgSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeStfFlgSortBuilder
	
} // end namespace
