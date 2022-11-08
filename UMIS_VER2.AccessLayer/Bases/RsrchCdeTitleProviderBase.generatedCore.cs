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
	/// This class is the base class for any <see cref="RsrchCdeTitleProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class RsrchCdeTitleProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.RsrchCdeTitle, UMIS_VER2.BusinessLyer.RsrchCdeTitleKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchCdeTitleKey key)
		{
			return Delete(transactionManager, key.RsrchCdeTitleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_rsrchCdeTitleId">ادخال عناوين الابحاث المنجزة مسبقا. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _rsrchCdeTitleId)
		{
			return Delete(null, _rsrchCdeTitleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchCdeTitleId">ادخال عناوين الابحاث المنجزة مسبقا. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _rsrchCdeTitleId);		
		
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
		public override UMIS_VER2.BusinessLyer.RsrchCdeTitle Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchCdeTitleKey key, int start, int pageLength)
		{
			return GetByRsrchCdeTitleId(transactionManager, key.RsrchCdeTitleId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_RSRCH_CDE_TITLE index.
		/// </summary>
		/// <param name="_rsrchCdeTitleId">ادخال عناوين الابحاث المنجزة مسبقا</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchCdeTitle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchCdeTitle GetByRsrchCdeTitleId(System.Decimal _rsrchCdeTitleId)
		{
			int count = -1;
			return GetByRsrchCdeTitleId(null,_rsrchCdeTitleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_CDE_TITLE index.
		/// </summary>
		/// <param name="_rsrchCdeTitleId">ادخال عناوين الابحاث المنجزة مسبقا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchCdeTitle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchCdeTitle GetByRsrchCdeTitleId(System.Decimal _rsrchCdeTitleId, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchCdeTitleId(null, _rsrchCdeTitleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_CDE_TITLE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchCdeTitleId">ادخال عناوين الابحاث المنجزة مسبقا</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchCdeTitle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchCdeTitle GetByRsrchCdeTitleId(TransactionManager transactionManager, System.Decimal _rsrchCdeTitleId)
		{
			int count = -1;
			return GetByRsrchCdeTitleId(transactionManager, _rsrchCdeTitleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_CDE_TITLE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchCdeTitleId">ادخال عناوين الابحاث المنجزة مسبقا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchCdeTitle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchCdeTitle GetByRsrchCdeTitleId(TransactionManager transactionManager, System.Decimal _rsrchCdeTitleId, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchCdeTitleId(transactionManager, _rsrchCdeTitleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_CDE_TITLE index.
		/// </summary>
		/// <param name="_rsrchCdeTitleId">ادخال عناوين الابحاث المنجزة مسبقا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchCdeTitle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchCdeTitle GetByRsrchCdeTitleId(System.Decimal _rsrchCdeTitleId, int start, int pageLength, out int count)
		{
			return GetByRsrchCdeTitleId(null, _rsrchCdeTitleId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_CDE_TITLE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchCdeTitleId">ادخال عناوين الابحاث المنجزة مسبقا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchCdeTitle"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.RsrchCdeTitle GetByRsrchCdeTitleId(TransactionManager transactionManager, System.Decimal _rsrchCdeTitleId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;RsrchCdeTitle&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;RsrchCdeTitle&gt;"/></returns>
		public static TList<RsrchCdeTitle> Fill(IDataReader reader, TList<RsrchCdeTitle> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.RsrchCdeTitle c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("RsrchCdeTitle")
					.Append("|").Append((System.Decimal)reader["RSRCH_CDE_TITLE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<RsrchCdeTitle>(
					key.ToString(), // EntityTrackingKey
					"RsrchCdeTitle",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.RsrchCdeTitle();
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
					c.RsrchCdeTitleId = (System.Decimal)reader["RSRCH_CDE_TITLE_ID"];
					c.OriginalRsrchCdeTitleId = c.RsrchCdeTitleId;
					c.RsrchTitleAr = (System.String)reader["RSRCH_TITLE_AR"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.RsrchCdeTitle"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.RsrchCdeTitle"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.RsrchCdeTitle entity)
		{
			if (!reader.Read()) return;
			
			entity.RsrchCdeTitleId = (System.Decimal)reader[((int)RsrchCdeTitleColumn.RsrchCdeTitleId - 1)];
			entity.OriginalRsrchCdeTitleId = (System.Decimal)reader["RSRCH_CDE_TITLE_ID"];
			entity.RsrchTitleAr = (System.String)reader[((int)RsrchCdeTitleColumn.RsrchTitleAr - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.RsrchCdeTitle"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.RsrchCdeTitle"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.RsrchCdeTitle entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.RsrchCdeTitleId = (System.Decimal)dataRow["RSRCH_CDE_TITLE_ID"];
			entity.OriginalRsrchCdeTitleId = (System.Decimal)dataRow["RSRCH_CDE_TITLE_ID"];
			entity.RsrchTitleAr = (System.String)dataRow["RSRCH_TITLE_AR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.RsrchCdeTitle"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.RsrchCdeTitle Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchCdeTitle entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.RsrchCdeTitle object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.RsrchCdeTitle instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.RsrchCdeTitle Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchCdeTitle entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region RsrchCdeTitleChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.RsrchCdeTitle</c>
	///</summary>
	public enum RsrchCdeTitleChildEntityTypes
	{
	}
	
	#endregion RsrchCdeTitleChildEntityTypes
	
	#region RsrchCdeTitleFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;RsrchCdeTitleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="RsrchCdeTitle"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class RsrchCdeTitleFilterBuilder : SqlFilterBuilder<RsrchCdeTitleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RsrchCdeTitleFilterBuilder class.
		/// </summary>
		public RsrchCdeTitleFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the RsrchCdeTitleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public RsrchCdeTitleFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the RsrchCdeTitleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public RsrchCdeTitleFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion RsrchCdeTitleFilterBuilder
	
	#region RsrchCdeTitleParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;RsrchCdeTitleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="RsrchCdeTitle"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class RsrchCdeTitleParameterBuilder : ParameterizedSqlFilterBuilder<RsrchCdeTitleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RsrchCdeTitleParameterBuilder class.
		/// </summary>
		public RsrchCdeTitleParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the RsrchCdeTitleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public RsrchCdeTitleParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the RsrchCdeTitleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public RsrchCdeTitleParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion RsrchCdeTitleParameterBuilder
	
	#region RsrchCdeTitleSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;RsrchCdeTitleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="RsrchCdeTitle"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class RsrchCdeTitleSortBuilder : SqlSortBuilder<RsrchCdeTitleColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RsrchCdeTitleSqlSortBuilder class.
		/// </summary>
		public RsrchCdeTitleSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion RsrchCdeTitleSortBuilder
	
} // end namespace
