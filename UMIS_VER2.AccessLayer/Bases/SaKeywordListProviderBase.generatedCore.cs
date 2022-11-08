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
	/// This class is the base class for any <see cref="SaKeywordListProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaKeywordListProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaKeywordList, UMIS_VER2.BusinessLyer.SaKeywordListKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaKeywordListKey key)
		{
			return Delete(transactionManager, key.SaKeywordListId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saKeywordListId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saKeywordListId)
		{
			return Delete(null, _saKeywordListId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saKeywordListId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saKeywordListId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaKeywordList Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaKeywordListKey key, int start, int pageLength)
		{
			return GetBySaKeywordListId(transactionManager, key.SaKeywordListId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_KEYWORD_LIST index.
		/// </summary>
		/// <param name="_saKeywordListId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaKeywordList"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaKeywordList GetBySaKeywordListId(System.Decimal _saKeywordListId)
		{
			int count = -1;
			return GetBySaKeywordListId(null,_saKeywordListId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_KEYWORD_LIST index.
		/// </summary>
		/// <param name="_saKeywordListId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaKeywordList"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaKeywordList GetBySaKeywordListId(System.Decimal _saKeywordListId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaKeywordListId(null, _saKeywordListId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_KEYWORD_LIST index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saKeywordListId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaKeywordList"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaKeywordList GetBySaKeywordListId(TransactionManager transactionManager, System.Decimal _saKeywordListId)
		{
			int count = -1;
			return GetBySaKeywordListId(transactionManager, _saKeywordListId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_KEYWORD_LIST index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saKeywordListId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaKeywordList"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaKeywordList GetBySaKeywordListId(TransactionManager transactionManager, System.Decimal _saKeywordListId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaKeywordListId(transactionManager, _saKeywordListId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_KEYWORD_LIST index.
		/// </summary>
		/// <param name="_saKeywordListId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaKeywordList"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaKeywordList GetBySaKeywordListId(System.Decimal _saKeywordListId, int start, int pageLength, out int count)
		{
			return GetBySaKeywordListId(null, _saKeywordListId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_KEYWORD_LIST index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saKeywordListId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaKeywordList"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaKeywordList GetBySaKeywordListId(TransactionManager transactionManager, System.Decimal _saKeywordListId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaKeywordList&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaKeywordList&gt;"/></returns>
		public static TList<SaKeywordList> Fill(IDataReader reader, TList<SaKeywordList> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaKeywordList c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaKeywordList")
					.Append("|").Append((System.Decimal)reader["SA_KEYWORD_LIST_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaKeywordList>(
					key.ToString(), // EntityTrackingKey
					"SaKeywordList",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaKeywordList();
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
					c.SaKeywordListId = (System.Decimal)reader["SA_KEYWORD_LIST_ID"];
					c.OriginalSaKeywordListId = c.SaKeywordListId;
					c.WordAr = (System.String)reader["WORD_AR"];
					c.WordEn = (System.String)reader["WORD_EN"];
					c.WordArDisplay = (System.String)reader["WORD_AR_DISPLAY"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaKeywordList"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaKeywordList"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaKeywordList entity)
		{
			if (!reader.Read()) return;
			
			entity.SaKeywordListId = (System.Decimal)reader[((int)SaKeywordListColumn.SaKeywordListId - 1)];
			entity.OriginalSaKeywordListId = (System.Decimal)reader["SA_KEYWORD_LIST_ID"];
			entity.WordAr = (System.String)reader[((int)SaKeywordListColumn.WordAr - 1)];
			entity.WordEn = (System.String)reader[((int)SaKeywordListColumn.WordEn - 1)];
			entity.WordArDisplay = (System.String)reader[((int)SaKeywordListColumn.WordArDisplay - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaKeywordList"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaKeywordList"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaKeywordList entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaKeywordListId = (System.Decimal)dataRow["SA_KEYWORD_LIST_ID"];
			entity.OriginalSaKeywordListId = (System.Decimal)dataRow["SA_KEYWORD_LIST_ID"];
			entity.WordAr = (System.String)dataRow["WORD_AR"];
			entity.WordEn = (System.String)dataRow["WORD_EN"];
			entity.WordArDisplay = (System.String)dataRow["WORD_AR_DISPLAY"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaKeywordList"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaKeywordList Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaKeywordList entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaKeywordList object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaKeywordList instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaKeywordList Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaKeywordList entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region SaKeywordListChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaKeywordList</c>
	///</summary>
	public enum SaKeywordListChildEntityTypes
	{
	}
	
	#endregion SaKeywordListChildEntityTypes
	
	#region SaKeywordListFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaKeywordListColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaKeywordList"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaKeywordListFilterBuilder : SqlFilterBuilder<SaKeywordListColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaKeywordListFilterBuilder class.
		/// </summary>
		public SaKeywordListFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaKeywordListFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaKeywordListFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaKeywordListFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaKeywordListFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaKeywordListFilterBuilder
	
	#region SaKeywordListParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaKeywordListColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaKeywordList"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaKeywordListParameterBuilder : ParameterizedSqlFilterBuilder<SaKeywordListColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaKeywordListParameterBuilder class.
		/// </summary>
		public SaKeywordListParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaKeywordListParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaKeywordListParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaKeywordListParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaKeywordListParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaKeywordListParameterBuilder
	
	#region SaKeywordListSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaKeywordListColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaKeywordList"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaKeywordListSortBuilder : SqlSortBuilder<SaKeywordListColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaKeywordListSqlSortBuilder class.
		/// </summary>
		public SaKeywordListSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaKeywordListSortBuilder
	
} // end namespace
