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
	/// This class is the base class for any <see cref="ScDaySlotProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScDaySlotProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScDaySlot, UMIS_VER2.BusinessLyer.ScDaySlotKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScDaySlotKey key)
		{
			return Delete(transactionManager, key.ScDaySlotId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scDaySlotId">XX not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scDaySlotId)
		{
			return Delete(null, _scDaySlotId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scDaySlotId">XX not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scDaySlotId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_DAY_SLOT_GS_CODE_WEEK_DAY key.
		///		FK_SC_DAY_SLOT_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScDaySlot objects.</returns>
		public TList<ScDaySlot> GetByGsCodeWeekDayId(System.Decimal _gsCodeWeekDayId)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(_gsCodeWeekDayId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_DAY_SLOT_GS_CODE_WEEK_DAY key.
		///		FK_SC_DAY_SLOT_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScDaySlot objects.</returns>
		/// <remarks></remarks>
		public TList<ScDaySlot> GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal _gsCodeWeekDayId)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(transactionManager, _gsCodeWeekDayId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_DAY_SLOT_GS_CODE_WEEK_DAY key.
		///		FK_SC_DAY_SLOT_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScDaySlot objects.</returns>
		public TList<ScDaySlot> GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal _gsCodeWeekDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(transactionManager, _gsCodeWeekDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_DAY_SLOT_GS_CODE_WEEK_DAY key.
		///		fkScDaySlotGsCodeWeekDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScDaySlot objects.</returns>
		public TList<ScDaySlot> GetByGsCodeWeekDayId(System.Decimal _gsCodeWeekDayId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeWeekDayId(null, _gsCodeWeekDayId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_DAY_SLOT_GS_CODE_WEEK_DAY key.
		///		fkScDaySlotGsCodeWeekDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScDaySlot objects.</returns>
		public TList<ScDaySlot> GetByGsCodeWeekDayId(System.Decimal _gsCodeWeekDayId, int start, int pageLength,out int count)
		{
			return GetByGsCodeWeekDayId(null, _gsCodeWeekDayId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_DAY_SLOT_GS_CODE_WEEK_DAY key.
		///		FK_SC_DAY_SLOT_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScDaySlot objects.</returns>
		public abstract TList<ScDaySlot> GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal _gsCodeWeekDayId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScDaySlot Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScDaySlotKey key, int start, int pageLength)
		{
			return GetByScDaySlotId(transactionManager, key.ScDaySlotId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_DAY_SLOT index.
		/// </summary>
		/// <param name="_scDaySlotId">XX not used</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScDaySlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScDaySlot GetByScDaySlotId(System.Decimal _scDaySlotId)
		{
			int count = -1;
			return GetByScDaySlotId(null,_scDaySlotId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_DAY_SLOT index.
		/// </summary>
		/// <param name="_scDaySlotId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScDaySlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScDaySlot GetByScDaySlotId(System.Decimal _scDaySlotId, int start, int pageLength)
		{
			int count = -1;
			return GetByScDaySlotId(null, _scDaySlotId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_DAY_SLOT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scDaySlotId">XX not used</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScDaySlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScDaySlot GetByScDaySlotId(TransactionManager transactionManager, System.Decimal _scDaySlotId)
		{
			int count = -1;
			return GetByScDaySlotId(transactionManager, _scDaySlotId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_DAY_SLOT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scDaySlotId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScDaySlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScDaySlot GetByScDaySlotId(TransactionManager transactionManager, System.Decimal _scDaySlotId, int start, int pageLength)
		{
			int count = -1;
			return GetByScDaySlotId(transactionManager, _scDaySlotId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_DAY_SLOT index.
		/// </summary>
		/// <param name="_scDaySlotId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScDaySlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScDaySlot GetByScDaySlotId(System.Decimal _scDaySlotId, int start, int pageLength, out int count)
		{
			return GetByScDaySlotId(null, _scDaySlotId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_DAY_SLOT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scDaySlotId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScDaySlot"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScDaySlot GetByScDaySlotId(TransactionManager transactionManager, System.Decimal _scDaySlotId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScDaySlot&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScDaySlot&gt;"/></returns>
		public static TList<ScDaySlot> Fill(IDataReader reader, TList<ScDaySlot> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScDaySlot c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScDaySlot")
					.Append("|").Append((System.Decimal)reader["SC_DAY_SLOT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScDaySlot>(
					key.ToString(), // EntityTrackingKey
					"ScDaySlot",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScDaySlot();
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
					c.ScDaySlotId = (System.Decimal)reader["SC_DAY_SLOT_ID"];
					c.OriginalScDaySlotId = c.ScDaySlotId;
					c.GsCodeWeekDayId = (System.Decimal)reader["GS_CODE_WEEK_DAY_ID"];
					c.ToTime = (System.DateTime)reader["TO_TIME"];
					c.FromTime = (System.DateTime)reader["FROM_TIME"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScDaySlot"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScDaySlot"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScDaySlot entity)
		{
			if (!reader.Read()) return;
			
			entity.ScDaySlotId = (System.Decimal)reader[((int)ScDaySlotColumn.ScDaySlotId - 1)];
			entity.OriginalScDaySlotId = (System.Decimal)reader["SC_DAY_SLOT_ID"];
			entity.GsCodeWeekDayId = (System.Decimal)reader[((int)ScDaySlotColumn.GsCodeWeekDayId - 1)];
			entity.ToTime = (System.DateTime)reader[((int)ScDaySlotColumn.ToTime - 1)];
			entity.FromTime = (System.DateTime)reader[((int)ScDaySlotColumn.FromTime - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScDaySlot"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScDaySlot"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScDaySlot entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScDaySlotId = (System.Decimal)dataRow["SC_DAY_SLOT_ID"];
			entity.OriginalScDaySlotId = (System.Decimal)dataRow["SC_DAY_SLOT_ID"];
			entity.GsCodeWeekDayId = (System.Decimal)dataRow["GS_CODE_WEEK_DAY_ID"];
			entity.ToTime = (System.DateTime)dataRow["TO_TIME"];
			entity.FromTime = (System.DateTime)dataRow["FROM_TIME"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScDaySlot"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScDaySlot Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScDaySlot entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCodeWeekDayIdSource	
			if (CanDeepLoad(entity, "GsCodeWeekDay|GsCodeWeekDayIdSource", deepLoadType, innerList) 
				&& entity.GsCodeWeekDayIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeWeekDayId;
				GsCodeWeekDay tmpEntity = EntityManager.LocateEntity<GsCodeWeekDay>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeWeekDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeWeekDayIdSource = tmpEntity;
				else
					entity.GsCodeWeekDayIdSource = DataRepository.GsCodeWeekDayProvider.GetByGsCodeWeekDayId(transactionManager, entity.GsCodeWeekDayId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeWeekDayIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeWeekDayIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeWeekDayProvider.DeepLoad(transactionManager, entity.GsCodeWeekDayIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeWeekDayIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScDaySlot object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScDaySlot instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScDaySlot Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScDaySlot entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCodeWeekDayIdSource
			if (CanDeepSave(entity, "GsCodeWeekDay|GsCodeWeekDayIdSource", deepSaveType, innerList) 
				&& entity.GsCodeWeekDayIdSource != null)
			{
				DataRepository.GsCodeWeekDayProvider.Save(transactionManager, entity.GsCodeWeekDayIdSource);
				entity.GsCodeWeekDayId = entity.GsCodeWeekDayIdSource.GsCodeWeekDayId;
			}
			#endregion 
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
	
	#region ScDaySlotChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScDaySlot</c>
	///</summary>
	public enum ScDaySlotChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCodeWeekDay</c> at GsCodeWeekDayIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeWeekDay))]
		GsCodeWeekDay,
	}
	
	#endregion ScDaySlotChildEntityTypes
	
	#region ScDaySlotFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScDaySlotColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScDaySlot"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScDaySlotFilterBuilder : SqlFilterBuilder<ScDaySlotColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScDaySlotFilterBuilder class.
		/// </summary>
		public ScDaySlotFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScDaySlotFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScDaySlotFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScDaySlotFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScDaySlotFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScDaySlotFilterBuilder
	
	#region ScDaySlotParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScDaySlotColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScDaySlot"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScDaySlotParameterBuilder : ParameterizedSqlFilterBuilder<ScDaySlotColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScDaySlotParameterBuilder class.
		/// </summary>
		public ScDaySlotParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScDaySlotParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScDaySlotParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScDaySlotParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScDaySlotParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScDaySlotParameterBuilder
	
	#region ScDaySlotSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScDaySlotColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScDaySlot"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScDaySlotSortBuilder : SqlSortBuilder<ScDaySlotColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScDaySlotSqlSortBuilder class.
		/// </summary>
		public ScDaySlotSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScDaySlotSortBuilder
	
} // end namespace
