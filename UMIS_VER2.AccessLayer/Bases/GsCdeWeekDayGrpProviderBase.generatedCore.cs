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
	/// This class is the base class for any <see cref="GsCdeWeekDayGrpProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeWeekDayGrpProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp, UMIS_VER2.BusinessLyer.GsCdeWeekDayGrpKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeWeekDayGrpKey key)
		{
			return Delete(transactionManager, key.GsCdeWeekDayGrpId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeWeekDayGrpId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeWeekDayGrpId)
		{
			return Delete(null, _gsCdeWeekDayGrpId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeWeekDayGrpId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeWeekDayGrpId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeWeekDayGrpKey key, int start, int pageLength)
		{
			return GetByGsCdeWeekDayGrpId(transactionManager, key.GsCdeWeekDayGrpId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_WEEK_DAY_GRP index.
		/// </summary>
		/// <param name="_gsCdeWeekDayGrpId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp GetByGsCdeWeekDayGrpId(System.Decimal _gsCdeWeekDayGrpId)
		{
			int count = -1;
			return GetByGsCdeWeekDayGrpId(null,_gsCdeWeekDayGrpId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_WEEK_DAY_GRP index.
		/// </summary>
		/// <param name="_gsCdeWeekDayGrpId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp GetByGsCdeWeekDayGrpId(System.Decimal _gsCdeWeekDayGrpId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeWeekDayGrpId(null, _gsCdeWeekDayGrpId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_WEEK_DAY_GRP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeWeekDayGrpId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp GetByGsCdeWeekDayGrpId(TransactionManager transactionManager, System.Decimal _gsCdeWeekDayGrpId)
		{
			int count = -1;
			return GetByGsCdeWeekDayGrpId(transactionManager, _gsCdeWeekDayGrpId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_WEEK_DAY_GRP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeWeekDayGrpId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp GetByGsCdeWeekDayGrpId(TransactionManager transactionManager, System.Decimal _gsCdeWeekDayGrpId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeWeekDayGrpId(transactionManager, _gsCdeWeekDayGrpId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_WEEK_DAY_GRP index.
		/// </summary>
		/// <param name="_gsCdeWeekDayGrpId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp GetByGsCdeWeekDayGrpId(System.Decimal _gsCdeWeekDayGrpId, int start, int pageLength, out int count)
		{
			return GetByGsCdeWeekDayGrpId(null, _gsCdeWeekDayGrpId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_WEEK_DAY_GRP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeWeekDayGrpId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp GetByGsCdeWeekDayGrpId(TransactionManager transactionManager, System.Decimal _gsCdeWeekDayGrpId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_CDE_WEEK_DAY_GRP index.
		/// </summary>
		/// <param name="_grpSr"></param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp GetByGrpSrGsCodeWeekDayId(System.Decimal _grpSr, System.Decimal _gsCodeWeekDayId)
		{
			int count = -1;
			return GetByGrpSrGsCodeWeekDayId(null,_grpSr, _gsCodeWeekDayId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_WEEK_DAY_GRP index.
		/// </summary>
		/// <param name="_grpSr"></param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp GetByGrpSrGsCodeWeekDayId(System.Decimal _grpSr, System.Decimal _gsCodeWeekDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByGrpSrGsCodeWeekDayId(null, _grpSr, _gsCodeWeekDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_WEEK_DAY_GRP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_grpSr"></param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp GetByGrpSrGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal _grpSr, System.Decimal _gsCodeWeekDayId)
		{
			int count = -1;
			return GetByGrpSrGsCodeWeekDayId(transactionManager, _grpSr, _gsCodeWeekDayId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_WEEK_DAY_GRP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_grpSr"></param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp GetByGrpSrGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal _grpSr, System.Decimal _gsCodeWeekDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByGrpSrGsCodeWeekDayId(transactionManager, _grpSr, _gsCodeWeekDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_WEEK_DAY_GRP index.
		/// </summary>
		/// <param name="_grpSr"></param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp GetByGrpSrGsCodeWeekDayId(System.Decimal _grpSr, System.Decimal _gsCodeWeekDayId, int start, int pageLength, out int count)
		{
			return GetByGrpSrGsCodeWeekDayId(null, _grpSr, _gsCodeWeekDayId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_WEEK_DAY_GRP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_grpSr"></param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp GetByGrpSrGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal _grpSr, System.Decimal _gsCodeWeekDayId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeWeekDayGrp&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeWeekDayGrp&gt;"/></returns>
		public static TList<GsCdeWeekDayGrp> Fill(IDataReader reader, TList<GsCdeWeekDayGrp> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeWeekDayGrp")
					.Append("|").Append((System.Decimal)reader["GS_CDE_WEEK_DAY_GRP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeWeekDayGrp>(
					key.ToString(), // EntityTrackingKey
					"GsCdeWeekDayGrp",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp();
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
					c.GsCdeWeekDayGrpId = (System.Decimal)reader["GS_CDE_WEEK_DAY_GRP_ID"];
					c.OriginalGsCdeWeekDayGrpId = c.GsCdeWeekDayGrpId;
					c.GrpSr = (System.Decimal)reader["GRP_SR"];
					c.GsCodeWeekDayId = (System.Decimal)reader["GS_CODE_WEEK_DAY_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeWeekDayGrpId = (System.Decimal)reader[((int)GsCdeWeekDayGrpColumn.GsCdeWeekDayGrpId - 1)];
			entity.OriginalGsCdeWeekDayGrpId = (System.Decimal)reader["GS_CDE_WEEK_DAY_GRP_ID"];
			entity.GrpSr = (System.Decimal)reader[((int)GsCdeWeekDayGrpColumn.GrpSr - 1)];
			entity.GsCodeWeekDayId = (System.Decimal)reader[((int)GsCdeWeekDayGrpColumn.GsCodeWeekDayId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeWeekDayGrpId = (System.Decimal)dataRow["GS_CDE_WEEK_DAY_GRP_ID"];
			entity.OriginalGsCdeWeekDayGrpId = (System.Decimal)dataRow["GS_CDE_WEEK_DAY_GRP_ID"];
			entity.GrpSr = (System.Decimal)dataRow["GRP_SR"];
			entity.GsCodeWeekDayId = (System.Decimal)dataRow["GS_CODE_WEEK_DAY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GsCdeWeekDayGrpChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeWeekDayGrp</c>
	///</summary>
	public enum GsCdeWeekDayGrpChildEntityTypes
	{
	}
	
	#endregion GsCdeWeekDayGrpChildEntityTypes
	
	#region GsCdeWeekDayGrpFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeWeekDayGrpColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeWeekDayGrp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeWeekDayGrpFilterBuilder : SqlFilterBuilder<GsCdeWeekDayGrpColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeWeekDayGrpFilterBuilder class.
		/// </summary>
		public GsCdeWeekDayGrpFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeWeekDayGrpFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeWeekDayGrpFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeWeekDayGrpFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeWeekDayGrpFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeWeekDayGrpFilterBuilder
	
	#region GsCdeWeekDayGrpParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeWeekDayGrpColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeWeekDayGrp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeWeekDayGrpParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeWeekDayGrpColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeWeekDayGrpParameterBuilder class.
		/// </summary>
		public GsCdeWeekDayGrpParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeWeekDayGrpParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeWeekDayGrpParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeWeekDayGrpParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeWeekDayGrpParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeWeekDayGrpParameterBuilder
	
	#region GsCdeWeekDayGrpSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeWeekDayGrpColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeWeekDayGrp"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeWeekDayGrpSortBuilder : SqlSortBuilder<GsCdeWeekDayGrpColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeWeekDayGrpSqlSortBuilder class.
		/// </summary>
		public GsCdeWeekDayGrpSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeWeekDayGrpSortBuilder
	
} // end namespace
