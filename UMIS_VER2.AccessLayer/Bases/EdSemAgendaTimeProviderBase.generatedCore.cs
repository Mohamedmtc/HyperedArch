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
	/// This class is the base class for any <see cref="EdSemAgendaTimeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdSemAgendaTimeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdSemAgendaTime, UMIS_VER2.BusinessLyer.EdSemAgendaTimeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemAgendaTimeKey key)
		{
			return Delete(transactionManager, key.EdSemAgendaTimeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edSemAgendaTimeId">XXXUOB. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edSemAgendaTimeId)
		{
			return Delete(null, _edSemAgendaTimeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemAgendaTimeId">XXXUOB. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edSemAgendaTimeId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdSemAgendaTime Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemAgendaTimeKey key, int start, int pageLength)
		{
			return GetByEdSemAgendaTimeId(transactionManager, key.EdSemAgendaTimeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_SEM_AGENDA_TIME index.
		/// </summary>
		/// <param name="_edSemAgendaTimeId">XXXUOB</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaTime"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemAgendaTime GetByEdSemAgendaTimeId(System.Decimal _edSemAgendaTimeId)
		{
			int count = -1;
			return GetByEdSemAgendaTimeId(null,_edSemAgendaTimeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_AGENDA_TIME index.
		/// </summary>
		/// <param name="_edSemAgendaTimeId">XXXUOB</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaTime"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemAgendaTime GetByEdSemAgendaTimeId(System.Decimal _edSemAgendaTimeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdSemAgendaTimeId(null, _edSemAgendaTimeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_AGENDA_TIME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemAgendaTimeId">XXXUOB</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaTime"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemAgendaTime GetByEdSemAgendaTimeId(TransactionManager transactionManager, System.Decimal _edSemAgendaTimeId)
		{
			int count = -1;
			return GetByEdSemAgendaTimeId(transactionManager, _edSemAgendaTimeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_AGENDA_TIME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemAgendaTimeId">XXXUOB</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaTime"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemAgendaTime GetByEdSemAgendaTimeId(TransactionManager transactionManager, System.Decimal _edSemAgendaTimeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdSemAgendaTimeId(transactionManager, _edSemAgendaTimeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_AGENDA_TIME index.
		/// </summary>
		/// <param name="_edSemAgendaTimeId">XXXUOB</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaTime"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemAgendaTime GetByEdSemAgendaTimeId(System.Decimal _edSemAgendaTimeId, int start, int pageLength, out int count)
		{
			return GetByEdSemAgendaTimeId(null, _edSemAgendaTimeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_AGENDA_TIME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemAgendaTimeId">XXXUOB</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaTime"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdSemAgendaTime GetByEdSemAgendaTimeId(TransactionManager transactionManager, System.Decimal _edSemAgendaTimeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdSemAgendaTime&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdSemAgendaTime&gt;"/></returns>
		public static TList<EdSemAgendaTime> Fill(IDataReader reader, TList<EdSemAgendaTime> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdSemAgendaTime c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdSemAgendaTime")
					.Append("|").Append((System.Decimal)reader["ED_SEM_AGENDA_TIME_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdSemAgendaTime>(
					key.ToString(), // EntityTrackingKey
					"EdSemAgendaTime",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdSemAgendaTime();
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
					c.EdSemAgendaTimeId = (System.Decimal)reader["ED_SEM_AGENDA_TIME_ID"];
					c.OriginalEdSemAgendaTimeId = c.EdSemAgendaTimeId;
					c.EdSemAgendaDtlId = (System.Decimal)reader["ED_SEM_AGENDA_DTL_ID"];
					c.FromTime = Convert.IsDBNull(reader["FROM_TIME"]) ? null : (System.DateTime?)reader["FROM_TIME"];
					c.ToTime = Convert.IsDBNull(reader["TO_TIME"]) ? null : (System.DateTime?)reader["TO_TIME"];
					c.NoStud = Convert.IsDBNull(reader["NO_STUD"]) ? null : (System.Decimal?)reader["NO_STUD"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaTime"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaTime"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdSemAgendaTime entity)
		{
			if (!reader.Read()) return;
			
			entity.EdSemAgendaTimeId = (System.Decimal)reader[((int)EdSemAgendaTimeColumn.EdSemAgendaTimeId - 1)];
			entity.OriginalEdSemAgendaTimeId = (System.Decimal)reader["ED_SEM_AGENDA_TIME_ID"];
			entity.EdSemAgendaDtlId = (System.Decimal)reader[((int)EdSemAgendaTimeColumn.EdSemAgendaDtlId - 1)];
			entity.FromTime = (reader.IsDBNull(((int)EdSemAgendaTimeColumn.FromTime - 1)))?null:(System.DateTime?)reader[((int)EdSemAgendaTimeColumn.FromTime - 1)];
			entity.ToTime = (reader.IsDBNull(((int)EdSemAgendaTimeColumn.ToTime - 1)))?null:(System.DateTime?)reader[((int)EdSemAgendaTimeColumn.ToTime - 1)];
			entity.NoStud = (reader.IsDBNull(((int)EdSemAgendaTimeColumn.NoStud - 1)))?null:(System.Decimal?)reader[((int)EdSemAgendaTimeColumn.NoStud - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaTime"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaTime"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdSemAgendaTime entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdSemAgendaTimeId = (System.Decimal)dataRow["ED_SEM_AGENDA_TIME_ID"];
			entity.OriginalEdSemAgendaTimeId = (System.Decimal)dataRow["ED_SEM_AGENDA_TIME_ID"];
			entity.EdSemAgendaDtlId = (System.Decimal)dataRow["ED_SEM_AGENDA_DTL_ID"];
			entity.FromTime = Convert.IsDBNull(dataRow["FROM_TIME"]) ? null : (System.DateTime?)dataRow["FROM_TIME"];
			entity.ToTime = Convert.IsDBNull(dataRow["TO_TIME"]) ? null : (System.DateTime?)dataRow["TO_TIME"];
			entity.NoStud = Convert.IsDBNull(dataRow["NO_STUD"]) ? null : (System.Decimal?)dataRow["NO_STUD"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaTime"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdSemAgendaTime Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemAgendaTime entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdSemAgendaTimeId methods when available
			
			#region EdStudRsrvRegTimeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudRsrvRegTime>|EdStudRsrvRegTimeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudRsrvRegTimeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudRsrvRegTimeCollection = DataRepository.EdStudRsrvRegTimeProvider.GetByEdSemAgendaTimeId(transactionManager, entity.EdSemAgendaTimeId);

				if (deep && entity.EdStudRsrvRegTimeCollection.Count > 0)
				{
					deepHandles.Add("EdStudRsrvRegTimeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudRsrvRegTime>) DataRepository.EdStudRsrvRegTimeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudRsrvRegTimeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdSemAgendaTime object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdSemAgendaTime instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdSemAgendaTime Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemAgendaTime entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudRsrvRegTime>
				if (CanDeepSave(entity.EdStudRsrvRegTimeCollection, "List<EdStudRsrvRegTime>|EdStudRsrvRegTimeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudRsrvRegTime child in entity.EdStudRsrvRegTimeCollection)
					{
						if(child.EdSemAgendaTimeIdSource != null)
						{
							child.EdSemAgendaTimeId = child.EdSemAgendaTimeIdSource.EdSemAgendaTimeId;
						}
						else
						{
							child.EdSemAgendaTimeId = entity.EdSemAgendaTimeId;
						}

					}

					if (entity.EdStudRsrvRegTimeCollection.Count > 0 || entity.EdStudRsrvRegTimeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudRsrvRegTimeProvider.Save(transactionManager, entity.EdStudRsrvRegTimeCollection);
						
						deepHandles.Add("EdStudRsrvRegTimeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudRsrvRegTime >) DataRepository.EdStudRsrvRegTimeProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudRsrvRegTimeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
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
	
	#region EdSemAgendaTimeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdSemAgendaTime</c>
	///</summary>
	public enum EdSemAgendaTimeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdSemAgendaTime</c> as OneToMany for EdStudRsrvRegTimeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudRsrvRegTime>))]
		EdStudRsrvRegTimeCollection,
	}
	
	#endregion EdSemAgendaTimeChildEntityTypes
	
	#region EdSemAgendaTimeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdSemAgendaTimeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdSemAgendaTime"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdSemAgendaTimeFilterBuilder : SqlFilterBuilder<EdSemAgendaTimeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaTimeFilterBuilder class.
		/// </summary>
		public EdSemAgendaTimeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaTimeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdSemAgendaTimeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaTimeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdSemAgendaTimeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdSemAgendaTimeFilterBuilder
	
	#region EdSemAgendaTimeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdSemAgendaTimeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdSemAgendaTime"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdSemAgendaTimeParameterBuilder : ParameterizedSqlFilterBuilder<EdSemAgendaTimeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaTimeParameterBuilder class.
		/// </summary>
		public EdSemAgendaTimeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaTimeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdSemAgendaTimeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaTimeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdSemAgendaTimeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdSemAgendaTimeParameterBuilder
	
	#region EdSemAgendaTimeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdSemAgendaTimeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdSemAgendaTime"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdSemAgendaTimeSortBuilder : SqlSortBuilder<EdSemAgendaTimeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaTimeSqlSortBuilder class.
		/// </summary>
		public EdSemAgendaTimeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdSemAgendaTimeSortBuilder
	
} // end namespace