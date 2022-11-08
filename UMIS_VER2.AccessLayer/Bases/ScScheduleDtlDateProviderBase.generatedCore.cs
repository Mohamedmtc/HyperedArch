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
	/// This class is the base class for any <see cref="ScScheduleDtlDateProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScScheduleDtlDateProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScScheduleDtlDate, UMIS_VER2.BusinessLyer.ScScheduleDtlDateKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtlDateKey key)
		{
			return Delete(transactionManager, key.ScScheduleDtlDateId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scScheduleDtlDateId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scScheduleDtlDateId)
		{
			return Delete(null, _scScheduleDtlDateId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDateId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scScheduleDtlDateId);		
		
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
		public override UMIS_VER2.BusinessLyer.ScScheduleDtlDate Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtlDateKey key, int start, int pageLength)
		{
			return GetByScScheduleDtlDateId(transactionManager, key.ScScheduleDtlDateId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_SCHEDULE_DTL_Date index.
		/// </summary>
		/// <param name="_scScheduleDtlDateId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDate"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDate GetByScScheduleDtlDateId(System.Decimal _scScheduleDtlDateId)
		{
			int count = -1;
			return GetByScScheduleDtlDateId(null,_scScheduleDtlDateId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_Date index.
		/// </summary>
		/// <param name="_scScheduleDtlDateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDate"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDate GetByScScheduleDtlDateId(System.Decimal _scScheduleDtlDateId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlDateId(null, _scScheduleDtlDateId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_Date index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDateId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDate"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDate GetByScScheduleDtlDateId(TransactionManager transactionManager, System.Decimal _scScheduleDtlDateId)
		{
			int count = -1;
			return GetByScScheduleDtlDateId(transactionManager, _scScheduleDtlDateId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_Date index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDate"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDate GetByScScheduleDtlDateId(TransactionManager transactionManager, System.Decimal _scScheduleDtlDateId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlDateId(transactionManager, _scScheduleDtlDateId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_Date index.
		/// </summary>
		/// <param name="_scScheduleDtlDateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDate"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDate GetByScScheduleDtlDateId(System.Decimal _scScheduleDtlDateId, int start, int pageLength, out int count)
		{
			return GetByScScheduleDtlDateId(null, _scScheduleDtlDateId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_Date index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDate"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScScheduleDtlDate GetByScScheduleDtlDateId(TransactionManager transactionManager, System.Decimal _scScheduleDtlDateId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SC_SCHEDULE_DTL_Date index.
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDate"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDate GetByScScheduleDtlIdFromDateToDate(System.Decimal _scScheduleDtlId, System.DateTime? _fromDate, System.DateTime? _toDate)
		{
			int count = -1;
			return GetByScScheduleDtlIdFromDateToDate(null,_scScheduleDtlId, _fromDate, _toDate, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_Date index.
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDate"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDate GetByScScheduleDtlIdFromDateToDate(System.Decimal _scScheduleDtlId, System.DateTime? _fromDate, System.DateTime? _toDate, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlIdFromDateToDate(null, _scScheduleDtlId, _fromDate, _toDate, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_Date index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDate"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDate GetByScScheduleDtlIdFromDateToDate(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, System.DateTime? _fromDate, System.DateTime? _toDate)
		{
			int count = -1;
			return GetByScScheduleDtlIdFromDateToDate(transactionManager, _scScheduleDtlId, _fromDate, _toDate, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_Date index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDate"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDate GetByScScheduleDtlIdFromDateToDate(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, System.DateTime? _fromDate, System.DateTime? _toDate, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlIdFromDateToDate(transactionManager, _scScheduleDtlId, _fromDate, _toDate, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_Date index.
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDate"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDate GetByScScheduleDtlIdFromDateToDate(System.Decimal _scScheduleDtlId, System.DateTime? _fromDate, System.DateTime? _toDate, int start, int pageLength, out int count)
		{
			return GetByScScheduleDtlIdFromDateToDate(null, _scScheduleDtlId, _fromDate, _toDate, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_Date index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDate"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScScheduleDtlDate GetByScScheduleDtlIdFromDateToDate(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, System.DateTime? _fromDate, System.DateTime? _toDate, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScScheduleDtlDate&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScScheduleDtlDate&gt;"/></returns>
		public static TList<ScScheduleDtlDate> Fill(IDataReader reader, TList<ScScheduleDtlDate> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScScheduleDtlDate c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScScheduleDtlDate")
					.Append("|").Append((System.Decimal)reader["SC_SCHEDULE_DTL_Date_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScScheduleDtlDate>(
					key.ToString(), // EntityTrackingKey
					"ScScheduleDtlDate",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScScheduleDtlDate();
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
					c.ScScheduleDtlDateId = (System.Decimal)reader["SC_SCHEDULE_DTL_Date_ID"];
					c.OriginalScScheduleDtlDateId = c.ScScheduleDtlDateId;
					c.ScScheduleDtlId = (System.Decimal)reader["SC_SCHEDULE_DTL_ID"];
					c.FromDate = Convert.IsDBNull(reader["FROM_DATE"]) ? null : (System.DateTime?)reader["FROM_DATE"];
					c.ToDate = Convert.IsDBNull(reader["TO_DATE"]) ? null : (System.DateTime?)reader["TO_DATE"];
					c.SerialNo = Convert.IsDBNull(reader["Serial_NO"]) ? null : (System.String)reader["Serial_NO"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDate"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDate"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScScheduleDtlDate entity)
		{
			if (!reader.Read()) return;
			
			entity.ScScheduleDtlDateId = (System.Decimal)reader[((int)ScScheduleDtlDateColumn.ScScheduleDtlDateId - 1)];
			entity.OriginalScScheduleDtlDateId = (System.Decimal)reader["SC_SCHEDULE_DTL_Date_ID"];
			entity.ScScheduleDtlId = (System.Decimal)reader[((int)ScScheduleDtlDateColumn.ScScheduleDtlId - 1)];
			entity.FromDate = (reader.IsDBNull(((int)ScScheduleDtlDateColumn.FromDate - 1)))?null:(System.DateTime?)reader[((int)ScScheduleDtlDateColumn.FromDate - 1)];
			entity.ToDate = (reader.IsDBNull(((int)ScScheduleDtlDateColumn.ToDate - 1)))?null:(System.DateTime?)reader[((int)ScScheduleDtlDateColumn.ToDate - 1)];
			entity.SerialNo = (reader.IsDBNull(((int)ScScheduleDtlDateColumn.SerialNo - 1)))?null:(System.String)reader[((int)ScScheduleDtlDateColumn.SerialNo - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)ScScheduleDtlDateColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlDateColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)ScScheduleDtlDateColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)ScScheduleDtlDateColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDate"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDate"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScScheduleDtlDate entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScScheduleDtlDateId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_Date_ID"];
			entity.OriginalScScheduleDtlDateId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_Date_ID"];
			entity.ScScheduleDtlId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_ID"];
			entity.FromDate = Convert.IsDBNull(dataRow["FROM_DATE"]) ? null : (System.DateTime?)dataRow["FROM_DATE"];
			entity.ToDate = Convert.IsDBNull(dataRow["TO_DATE"]) ? null : (System.DateTime?)dataRow["TO_DATE"];
			entity.SerialNo = Convert.IsDBNull(dataRow["Serial_NO"]) ? null : (System.String)dataRow["Serial_NO"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDate"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScScheduleDtlDate Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtlDate entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScScheduleDtlDate object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScScheduleDtlDate instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScScheduleDtlDate Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtlDate entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ScScheduleDtlDateChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScScheduleDtlDate</c>
	///</summary>
	public enum ScScheduleDtlDateChildEntityTypes
	{
	}
	
	#endregion ScScheduleDtlDateChildEntityTypes
	
	#region ScScheduleDtlDateFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScScheduleDtlDateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleDtlDate"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScScheduleDtlDateFilterBuilder : SqlFilterBuilder<ScScheduleDtlDateColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDateFilterBuilder class.
		/// </summary>
		public ScScheduleDtlDateFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDateFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScScheduleDtlDateFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDateFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScScheduleDtlDateFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScScheduleDtlDateFilterBuilder
	
	#region ScScheduleDtlDateParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScScheduleDtlDateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleDtlDate"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScScheduleDtlDateParameterBuilder : ParameterizedSqlFilterBuilder<ScScheduleDtlDateColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDateParameterBuilder class.
		/// </summary>
		public ScScheduleDtlDateParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDateParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScScheduleDtlDateParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDateParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScScheduleDtlDateParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScScheduleDtlDateParameterBuilder
	
	#region ScScheduleDtlDateSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScScheduleDtlDateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleDtlDate"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScScheduleDtlDateSortBuilder : SqlSortBuilder<ScScheduleDtlDateColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDateSqlSortBuilder class.
		/// </summary>
		public ScScheduleDtlDateSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScScheduleDtlDateSortBuilder
	
} // end namespace
