﻿#region Using directives

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
	/// This class is the base class for any <see cref="TrnsCdeLineProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TrnsCdeLineProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.TrnsCdeLine, UMIS_VER2.BusinessLyer.TrnsCdeLineKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsCdeLineKey key)
		{
			return Delete(transactionManager, key.TrnsCdeLineId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_trnsCdeLineId">مسلسل الخط. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _trnsCdeLineId)
		{
			return Delete(null, _trnsCdeLineId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeLineId">مسلسل الخط. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _trnsCdeLineId);		
		
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
		public override UMIS_VER2.BusinessLyer.TrnsCdeLine Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsCdeLineKey key, int start, int pageLength)
		{
			return GetByTrnsCdeLineId(transactionManager, key.TrnsCdeLineId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_TRNS_LINE index.
		/// </summary>
		/// <param name="_trnsCdeLineId">مسلسل الخط</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeLine GetByTrnsCdeLineId(System.Decimal _trnsCdeLineId)
		{
			int count = -1;
			return GetByTrnsCdeLineId(null,_trnsCdeLineId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE index.
		/// </summary>
		/// <param name="_trnsCdeLineId">مسلسل الخط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeLine GetByTrnsCdeLineId(System.Decimal _trnsCdeLineId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsCdeLineId(null, _trnsCdeLineId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeLineId">مسلسل الخط</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeLine GetByTrnsCdeLineId(TransactionManager transactionManager, System.Decimal _trnsCdeLineId)
		{
			int count = -1;
			return GetByTrnsCdeLineId(transactionManager, _trnsCdeLineId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeLineId">مسلسل الخط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeLine GetByTrnsCdeLineId(TransactionManager transactionManager, System.Decimal _trnsCdeLineId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsCdeLineId(transactionManager, _trnsCdeLineId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE index.
		/// </summary>
		/// <param name="_trnsCdeLineId">مسلسل الخط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeLine GetByTrnsCdeLineId(System.Decimal _trnsCdeLineId, int start, int pageLength, out int count)
		{
			return GetByTrnsCdeLineId(null, _trnsCdeLineId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeLineId">مسلسل الخط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeLine"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.TrnsCdeLine GetByTrnsCdeLineId(TransactionManager transactionManager, System.Decimal _trnsCdeLineId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TrnsCdeLine&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TrnsCdeLine&gt;"/></returns>
		public static TList<TrnsCdeLine> Fill(IDataReader reader, TList<TrnsCdeLine> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.TrnsCdeLine c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TrnsCdeLine")
					.Append("|").Append((System.Decimal)reader["TRNS_CDE_LINE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<TrnsCdeLine>(
					key.ToString(), // EntityTrackingKey
					"TrnsCdeLine",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.TrnsCdeLine();
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
					c.TrnsCdeLineId = (System.Decimal)reader["TRNS_CDE_LINE_ID"];
					c.OriginalTrnsCdeLineId = c.TrnsCdeLineId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.LineNo = (System.String)reader["LINE_NO"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeLine"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsCdeLine"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.TrnsCdeLine entity)
		{
			if (!reader.Read()) return;
			
			entity.TrnsCdeLineId = (System.Decimal)reader[((int)TrnsCdeLineColumn.TrnsCdeLineId - 1)];
			entity.OriginalTrnsCdeLineId = (System.Decimal)reader["TRNS_CDE_LINE_ID"];
			entity.DescrAr = (System.String)reader[((int)TrnsCdeLineColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)TrnsCdeLineColumn.DescrEn - 1)];
			entity.LineNo = (System.String)reader[((int)TrnsCdeLineColumn.LineNo - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeLine"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsCdeLine"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.TrnsCdeLine entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.TrnsCdeLineId = (System.Decimal)dataRow["TRNS_CDE_LINE_ID"];
			entity.OriginalTrnsCdeLineId = (System.Decimal)dataRow["TRNS_CDE_LINE_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.LineNo = (System.String)dataRow["LINE_NO"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsCdeLine"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.TrnsCdeLine Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsCdeLine entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.TrnsCdeLine object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.TrnsCdeLine instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.TrnsCdeLine Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsCdeLine entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region TrnsCdeLineChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.TrnsCdeLine</c>
	///</summary>
	public enum TrnsCdeLineChildEntityTypes
	{
	}
	
	#endregion TrnsCdeLineChildEntityTypes
	
	#region TrnsCdeLineFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TrnsCdeLineColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsCdeLine"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrnsCdeLineFilterBuilder : SqlFilterBuilder<TrnsCdeLineColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsCdeLineFilterBuilder class.
		/// </summary>
		public TrnsCdeLineFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrnsCdeLineFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrnsCdeLineFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrnsCdeLineFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrnsCdeLineFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrnsCdeLineFilterBuilder
	
	#region TrnsCdeLineParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TrnsCdeLineColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsCdeLine"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrnsCdeLineParameterBuilder : ParameterizedSqlFilterBuilder<TrnsCdeLineColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsCdeLineParameterBuilder class.
		/// </summary>
		public TrnsCdeLineParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrnsCdeLineParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrnsCdeLineParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrnsCdeLineParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrnsCdeLineParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrnsCdeLineParameterBuilder
	
	#region TrnsCdeLineSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TrnsCdeLineColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsCdeLine"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TrnsCdeLineSortBuilder : SqlSortBuilder<TrnsCdeLineColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsCdeLineSqlSortBuilder class.
		/// </summary>
		public TrnsCdeLineSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TrnsCdeLineSortBuilder
	
} // end namespace
