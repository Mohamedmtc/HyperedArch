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
	/// This class is the base class for any <see cref="StaticViNotesProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class StaticViNotesProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.StaticViNotes, UMIS_VER2.BusinessLyer.StaticViNotesKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.StaticViNotesKey key)
		{
			return Delete(transactionManager, key.StaticViNotesId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_staticViNotesId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _staticViNotesId)
		{
			return Delete(null, _staticViNotesId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_staticViNotesId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _staticViNotesId);		
		
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
		public override UMIS_VER2.BusinessLyer.StaticViNotes Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.StaticViNotesKey key, int start, int pageLength)
		{
			return GetByStaticViNotesId(transactionManager, key.StaticViNotesId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_STATIC_VI_NOTES index.
		/// </summary>
		/// <param name="_staticViNotesId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.StaticViNotes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.StaticViNotes GetByStaticViNotesId(System.Decimal _staticViNotesId)
		{
			int count = -1;
			return GetByStaticViNotesId(null,_staticViNotesId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STATIC_VI_NOTES index.
		/// </summary>
		/// <param name="_staticViNotesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.StaticViNotes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.StaticViNotes GetByStaticViNotesId(System.Decimal _staticViNotesId, int start, int pageLength)
		{
			int count = -1;
			return GetByStaticViNotesId(null, _staticViNotesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STATIC_VI_NOTES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_staticViNotesId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.StaticViNotes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.StaticViNotes GetByStaticViNotesId(TransactionManager transactionManager, System.Decimal _staticViNotesId)
		{
			int count = -1;
			return GetByStaticViNotesId(transactionManager, _staticViNotesId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STATIC_VI_NOTES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_staticViNotesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.StaticViNotes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.StaticViNotes GetByStaticViNotesId(TransactionManager transactionManager, System.Decimal _staticViNotesId, int start, int pageLength)
		{
			int count = -1;
			return GetByStaticViNotesId(transactionManager, _staticViNotesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STATIC_VI_NOTES index.
		/// </summary>
		/// <param name="_staticViNotesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.StaticViNotes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.StaticViNotes GetByStaticViNotesId(System.Decimal _staticViNotesId, int start, int pageLength, out int count)
		{
			return GetByStaticViNotesId(null, _staticViNotesId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STATIC_VI_NOTES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_staticViNotesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.StaticViNotes"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.StaticViNotes GetByStaticViNotesId(TransactionManager transactionManager, System.Decimal _staticViNotesId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;StaticViNotes&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;StaticViNotes&gt;"/></returns>
		public static TList<StaticViNotes> Fill(IDataReader reader, TList<StaticViNotes> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.StaticViNotes c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("StaticViNotes")
					.Append("|").Append((System.Decimal)reader["STATIC_VI_NOTES_ID"]).ToString();
					c = EntityManager.LocateOrCreate<StaticViNotes>(
					key.ToString(), // EntityTrackingKey
					"StaticViNotes",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.StaticViNotes();
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
					c.StaticViNotesId = (System.Decimal)reader["STATIC_VI_NOTES_ID"];
					c.OriginalStaticViNotesId = c.StaticViNotesId;
					c.NoteAr = Convert.IsDBNull(reader["NOTE_AR"]) ? null : (System.String)reader["NOTE_AR"];
					c.NoteEn = Convert.IsDBNull(reader["NOTE_EN"]) ? null : (System.String)reader["NOTE_EN"];
					c.DelFlg = Convert.IsDBNull(reader["DEL_FLG"]) ? null : (System.Decimal?)reader["DEL_FLG"];
					c.SortingIndex = Convert.IsDBNull(reader["SORTING_INDEX"]) ? null : (System.Decimal?)reader["SORTING_INDEX"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.StaticViNotes"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.StaticViNotes"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.StaticViNotes entity)
		{
			if (!reader.Read()) return;
			
			entity.StaticViNotesId = (System.Decimal)reader[((int)StaticViNotesColumn.StaticViNotesId - 1)];
			entity.OriginalStaticViNotesId = (System.Decimal)reader["STATIC_VI_NOTES_ID"];
			entity.NoteAr = (reader.IsDBNull(((int)StaticViNotesColumn.NoteAr - 1)))?null:(System.String)reader[((int)StaticViNotesColumn.NoteAr - 1)];
			entity.NoteEn = (reader.IsDBNull(((int)StaticViNotesColumn.NoteEn - 1)))?null:(System.String)reader[((int)StaticViNotesColumn.NoteEn - 1)];
			entity.DelFlg = (reader.IsDBNull(((int)StaticViNotesColumn.DelFlg - 1)))?null:(System.Decimal?)reader[((int)StaticViNotesColumn.DelFlg - 1)];
			entity.SortingIndex = (reader.IsDBNull(((int)StaticViNotesColumn.SortingIndex - 1)))?null:(System.Decimal?)reader[((int)StaticViNotesColumn.SortingIndex - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.StaticViNotes"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.StaticViNotes"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.StaticViNotes entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.StaticViNotesId = (System.Decimal)dataRow["STATIC_VI_NOTES_ID"];
			entity.OriginalStaticViNotesId = (System.Decimal)dataRow["STATIC_VI_NOTES_ID"];
			entity.NoteAr = Convert.IsDBNull(dataRow["NOTE_AR"]) ? null : (System.String)dataRow["NOTE_AR"];
			entity.NoteEn = Convert.IsDBNull(dataRow["NOTE_EN"]) ? null : (System.String)dataRow["NOTE_EN"];
			entity.DelFlg = Convert.IsDBNull(dataRow["DEL_FLG"]) ? null : (System.Decimal?)dataRow["DEL_FLG"];
			entity.SortingIndex = Convert.IsDBNull(dataRow["SORTING_INDEX"]) ? null : (System.Decimal?)dataRow["SORTING_INDEX"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.StaticViNotes"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.StaticViNotes Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.StaticViNotes entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.StaticViNotes object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.StaticViNotes instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.StaticViNotes Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.StaticViNotes entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region StaticViNotesChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.StaticViNotes</c>
	///</summary>
	public enum StaticViNotesChildEntityTypes
	{
	}
	
	#endregion StaticViNotesChildEntityTypes
	
	#region StaticViNotesFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;StaticViNotesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="StaticViNotes"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class StaticViNotesFilterBuilder : SqlFilterBuilder<StaticViNotesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StaticViNotesFilterBuilder class.
		/// </summary>
		public StaticViNotesFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the StaticViNotesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public StaticViNotesFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the StaticViNotesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public StaticViNotesFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion StaticViNotesFilterBuilder
	
	#region StaticViNotesParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;StaticViNotesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="StaticViNotes"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class StaticViNotesParameterBuilder : ParameterizedSqlFilterBuilder<StaticViNotesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StaticViNotesParameterBuilder class.
		/// </summary>
		public StaticViNotesParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the StaticViNotesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public StaticViNotesParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the StaticViNotesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public StaticViNotesParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion StaticViNotesParameterBuilder
	
	#region StaticViNotesSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;StaticViNotesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="StaticViNotes"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class StaticViNotesSortBuilder : SqlSortBuilder<StaticViNotesColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StaticViNotesSqlSortBuilder class.
		/// </summary>
		public StaticViNotesSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion StaticViNotesSortBuilder
	
} // end namespace
