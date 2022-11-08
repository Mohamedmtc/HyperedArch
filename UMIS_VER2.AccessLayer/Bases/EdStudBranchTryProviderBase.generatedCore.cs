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
	/// This class is the base class for any <see cref="EdStudBranchTryProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudBranchTryProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudBranchTry, UMIS_VER2.BusinessLyer.EdStudBranchTryKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudBranchTryKey key)
		{
			return Delete(transactionManager, key.EdStudBranchTryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudBranchTryId">مسلسل داخل النظام. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudBranchTryId)
		{
			return Delete(null, _edStudBranchTryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudBranchTryId">مسلسل داخل النظام. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudBranchTryId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdStudBranchTry Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudBranchTryKey key, int start, int pageLength)
		{
			return GetByEdStudBranchTryId(transactionManager, key.EdStudBranchTryId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_BRANCH_TRY index.
		/// </summary>
		/// <param name="_edStudBranchTryId">مسلسل داخل النظام</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudBranchTry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudBranchTry GetByEdStudBranchTryId(System.Decimal _edStudBranchTryId)
		{
			int count = -1;
			return GetByEdStudBranchTryId(null,_edStudBranchTryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_BRANCH_TRY index.
		/// </summary>
		/// <param name="_edStudBranchTryId">مسلسل داخل النظام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudBranchTry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudBranchTry GetByEdStudBranchTryId(System.Decimal _edStudBranchTryId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudBranchTryId(null, _edStudBranchTryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_BRANCH_TRY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudBranchTryId">مسلسل داخل النظام</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudBranchTry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudBranchTry GetByEdStudBranchTryId(TransactionManager transactionManager, System.Decimal _edStudBranchTryId)
		{
			int count = -1;
			return GetByEdStudBranchTryId(transactionManager, _edStudBranchTryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_BRANCH_TRY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudBranchTryId">مسلسل داخل النظام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudBranchTry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudBranchTry GetByEdStudBranchTryId(TransactionManager transactionManager, System.Decimal _edStudBranchTryId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudBranchTryId(transactionManager, _edStudBranchTryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_BRANCH_TRY index.
		/// </summary>
		/// <param name="_edStudBranchTryId">مسلسل داخل النظام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudBranchTry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudBranchTry GetByEdStudBranchTryId(System.Decimal _edStudBranchTryId, int start, int pageLength, out int count)
		{
			return GetByEdStudBranchTryId(null, _edStudBranchTryId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_BRANCH_TRY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudBranchTryId">مسلسل داخل النظام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudBranchTry"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudBranchTry GetByEdStudBranchTryId(TransactionManager transactionManager, System.Decimal _edStudBranchTryId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudBranchTry&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudBranchTry&gt;"/></returns>
		public static TList<EdStudBranchTry> Fill(IDataReader reader, TList<EdStudBranchTry> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudBranchTry c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudBranchTry")
					.Append("|").Append((System.Decimal)reader["ED_STUD_BRANCH_TRY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudBranchTry>(
					key.ToString(), // EntityTrackingKey
					"EdStudBranchTry",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudBranchTry();
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
					c.EdStudBranchTryId = (System.Decimal)reader["ED_STUD_BRANCH_TRY_ID"];
					c.OriginalEdStudBranchTryId = c.EdStudBranchTryId;
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.EdStudSemesterId = (System.Decimal)reader["ED_STUD_SEMESTER_ID"];
					c.StudRank = Convert.IsDBNull(reader["STUD_RANK"]) ? null : (System.Decimal?)reader["STUD_RANK"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudBranchTry"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudBranchTry"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudBranchTry entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudBranchTryId = (System.Decimal)reader[((int)EdStudBranchTryColumn.EdStudBranchTryId - 1)];
			entity.OriginalEdStudBranchTryId = (System.Decimal)reader["ED_STUD_BRANCH_TRY_ID"];
			entity.EntMainId = (System.Decimal)reader[((int)EdStudBranchTryColumn.EntMainId - 1)];
			entity.EdStudSemesterId = (System.Decimal)reader[((int)EdStudBranchTryColumn.EdStudSemesterId - 1)];
			entity.StudRank = (reader.IsDBNull(((int)EdStudBranchTryColumn.StudRank - 1)))?null:(System.Decimal?)reader[((int)EdStudBranchTryColumn.StudRank - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)EdStudBranchTryColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudBranchTry"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudBranchTry"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudBranchTry entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudBranchTryId = (System.Decimal)dataRow["ED_STUD_BRANCH_TRY_ID"];
			entity.OriginalEdStudBranchTryId = (System.Decimal)dataRow["ED_STUD_BRANCH_TRY_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.EdStudSemesterId = (System.Decimal)dataRow["ED_STUD_SEMESTER_ID"];
			entity.StudRank = Convert.IsDBNull(dataRow["STUD_RANK"]) ? null : (System.Decimal?)dataRow["STUD_RANK"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudBranchTry"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudBranchTry Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudBranchTry entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudBranchTry object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudBranchTry instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudBranchTry Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudBranchTry entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region EdStudBranchTryChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudBranchTry</c>
	///</summary>
	public enum EdStudBranchTryChildEntityTypes
	{
	}
	
	#endregion EdStudBranchTryChildEntityTypes
	
	#region EdStudBranchTryFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudBranchTryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudBranchTry"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudBranchTryFilterBuilder : SqlFilterBuilder<EdStudBranchTryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudBranchTryFilterBuilder class.
		/// </summary>
		public EdStudBranchTryFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudBranchTryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudBranchTryFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudBranchTryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudBranchTryFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudBranchTryFilterBuilder
	
	#region EdStudBranchTryParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudBranchTryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudBranchTry"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudBranchTryParameterBuilder : ParameterizedSqlFilterBuilder<EdStudBranchTryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudBranchTryParameterBuilder class.
		/// </summary>
		public EdStudBranchTryParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudBranchTryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudBranchTryParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudBranchTryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudBranchTryParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudBranchTryParameterBuilder
	
	#region EdStudBranchTrySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudBranchTryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudBranchTry"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudBranchTrySortBuilder : SqlSortBuilder<EdStudBranchTryColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudBranchTrySqlSortBuilder class.
		/// </summary>
		public EdStudBranchTrySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudBranchTrySortBuilder
	
} // end namespace
