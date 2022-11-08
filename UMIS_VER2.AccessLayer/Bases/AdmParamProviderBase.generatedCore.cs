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
	/// This class is the base class for any <see cref="AdmParamProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmParamProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmParam, UMIS_VER2.BusinessLyer.AdmParamKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmParamKey key)
		{
			return Delete(transactionManager, key.AdmParamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admParamId">Tabs Dynamic. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admParamId)
		{
			return Delete(null, _admParamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admParamId">Tabs Dynamic. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admParamId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmParam Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmParamKey key, int start, int pageLength)
		{
			return GetByAdmParamId(transactionManager, key.AdmParamId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_PARAM index.
		/// </summary>
		/// <param name="_admParamId">Tabs Dynamic</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmParam GetByAdmParamId(System.Decimal _admParamId)
		{
			int count = -1;
			return GetByAdmParamId(null,_admParamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PARAM index.
		/// </summary>
		/// <param name="_admParamId">Tabs Dynamic</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmParam GetByAdmParamId(System.Decimal _admParamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmParamId(null, _admParamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PARAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admParamId">Tabs Dynamic</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmParam GetByAdmParamId(TransactionManager transactionManager, System.Decimal _admParamId)
		{
			int count = -1;
			return GetByAdmParamId(transactionManager, _admParamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PARAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admParamId">Tabs Dynamic</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmParam GetByAdmParamId(TransactionManager transactionManager, System.Decimal _admParamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmParamId(transactionManager, _admParamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PARAM index.
		/// </summary>
		/// <param name="_admParamId">Tabs Dynamic</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmParam GetByAdmParamId(System.Decimal _admParamId, int start, int pageLength, out int count)
		{
			return GetByAdmParamId(null, _admParamId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PARAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admParamId">Tabs Dynamic</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmParam"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmParam GetByAdmParamId(TransactionManager transactionManager, System.Decimal _admParamId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmParam&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmParam&gt;"/></returns>
		public static TList<AdmParam> Fill(IDataReader reader, TList<AdmParam> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmParam c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmParam")
					.Append("|").Append((System.Decimal)reader["ADM_PARAM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmParam>(
					key.ToString(), // EntityTrackingKey
					"AdmParam",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmParam();
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
					c.AdmParamId = (System.Decimal)reader["ADM_PARAM_ID"];
					c.OriginalAdmParamId = c.AdmParamId;
					c.EnumId = Convert.IsDBNull(reader["ENUM_ID"]) ? null : (System.Int32?)reader["ENUM_ID"];
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.PrmValue = (System.String)reader["PRM_VALUE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmParam"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmParam"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmParam entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmParamId = (System.Decimal)reader[((int)AdmParamColumn.AdmParamId - 1)];
			entity.OriginalAdmParamId = (System.Decimal)reader["ADM_PARAM_ID"];
			entity.EnumId = (reader.IsDBNull(((int)AdmParamColumn.EnumId - 1)))?null:(System.Int32?)reader[((int)AdmParamColumn.EnumId - 1)];
			entity.DescrAr = (System.String)reader[((int)AdmParamColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)AdmParamColumn.DescrEn - 1)];
			entity.PrmValue = (System.String)reader[((int)AdmParamColumn.PrmValue - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmParamColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmParamColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmParamColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmParamColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmParam"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmParam"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmParam entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmParamId = (System.Decimal)dataRow["ADM_PARAM_ID"];
			entity.OriginalAdmParamId = (System.Decimal)dataRow["ADM_PARAM_ID"];
			entity.EnumId = Convert.IsDBNull(dataRow["ENUM_ID"]) ? null : (System.Int32?)dataRow["ENUM_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.PrmValue = (System.String)dataRow["PRM_VALUE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmParam"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmParam Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmParam entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmParam object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmParam instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmParam Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmParam entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region AdmParamChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmParam</c>
	///</summary>
	public enum AdmParamChildEntityTypes
	{
	}
	
	#endregion AdmParamChildEntityTypes
	
	#region AdmParamFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmParamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmParam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmParamFilterBuilder : SqlFilterBuilder<AdmParamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmParamFilterBuilder class.
		/// </summary>
		public AdmParamFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmParamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmParamFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmParamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmParamFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmParamFilterBuilder
	
	#region AdmParamParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmParamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmParam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmParamParameterBuilder : ParameterizedSqlFilterBuilder<AdmParamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmParamParameterBuilder class.
		/// </summary>
		public AdmParamParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmParamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmParamParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmParamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmParamParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmParamParameterBuilder
	
	#region AdmParamSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmParamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmParam"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmParamSortBuilder : SqlSortBuilder<AdmParamColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmParamSqlSortBuilder class.
		/// </summary>
		public AdmParamSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmParamSortBuilder
	
} // end namespace
