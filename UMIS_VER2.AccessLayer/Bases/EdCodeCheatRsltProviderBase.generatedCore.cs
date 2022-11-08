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
	/// This class is the base class for any <see cref="EdCodeCheatRsltProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeCheatRsltProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeCheatRslt, UMIS_VER2.BusinessLyer.EdCodeCheatRsltKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCheatRsltKey key)
		{
			return Delete(transactionManager, key.EdCodeCheatRsltId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeCheatRsltId">أكواد نتيجة واقعة غش. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _edCodeCheatRsltId)
		{
			return Delete(null, _edCodeCheatRsltId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCheatRsltId">أكواد نتيجة واقعة غش. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _edCodeCheatRsltId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeCheatRslt Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCheatRsltKey key, int start, int pageLength)
		{
			return GetByEdCodeCheatRsltId(transactionManager, key.EdCodeCheatRsltId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_CHEAT_RSLT index.
		/// </summary>
		/// <param name="_edCodeCheatRsltId">أكواد نتيجة واقعة غش</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCheatRslt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCheatRslt GetByEdCodeCheatRsltId(System.Int32 _edCodeCheatRsltId)
		{
			int count = -1;
			return GetByEdCodeCheatRsltId(null,_edCodeCheatRsltId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_CHEAT_RSLT index.
		/// </summary>
		/// <param name="_edCodeCheatRsltId">أكواد نتيجة واقعة غش</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCheatRslt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCheatRslt GetByEdCodeCheatRsltId(System.Int32 _edCodeCheatRsltId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCheatRsltId(null, _edCodeCheatRsltId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_CHEAT_RSLT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCheatRsltId">أكواد نتيجة واقعة غش</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCheatRslt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCheatRslt GetByEdCodeCheatRsltId(TransactionManager transactionManager, System.Int32 _edCodeCheatRsltId)
		{
			int count = -1;
			return GetByEdCodeCheatRsltId(transactionManager, _edCodeCheatRsltId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_CHEAT_RSLT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCheatRsltId">أكواد نتيجة واقعة غش</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCheatRslt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCheatRslt GetByEdCodeCheatRsltId(TransactionManager transactionManager, System.Int32 _edCodeCheatRsltId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCheatRsltId(transactionManager, _edCodeCheatRsltId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_CHEAT_RSLT index.
		/// </summary>
		/// <param name="_edCodeCheatRsltId">أكواد نتيجة واقعة غش</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCheatRslt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCheatRslt GetByEdCodeCheatRsltId(System.Int32 _edCodeCheatRsltId, int start, int pageLength, out int count)
		{
			return GetByEdCodeCheatRsltId(null, _edCodeCheatRsltId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_CHEAT_RSLT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCheatRsltId">أكواد نتيجة واقعة غش</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCheatRslt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeCheatRslt GetByEdCodeCheatRsltId(TransactionManager transactionManager, System.Int32 _edCodeCheatRsltId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeCheatRslt&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeCheatRslt&gt;"/></returns>
		public static TList<EdCodeCheatRslt> Fill(IDataReader reader, TList<EdCodeCheatRslt> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeCheatRslt c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeCheatRslt")
					.Append("|").Append((System.Int32)reader["ED_CODE_CHEAT_RSLT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeCheatRslt>(
					key.ToString(), // EntityTrackingKey
					"EdCodeCheatRslt",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeCheatRslt();
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
					c.EdCodeCheatRsltId = (System.Int32)reader["ED_CODE_CHEAT_RSLT_ID"];
					c.OriginalEdCodeCheatRsltId = c.EdCodeCheatRsltId;
					c.CheatRsltAr = (System.String)reader["CHEAT_RSLT_AR"];
					c.CheatRsltEn = (System.String)reader["CHEAT_RSLT_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeCheatRslt"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCheatRslt"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeCheatRslt entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeCheatRsltId = (System.Int32)reader[((int)EdCodeCheatRsltColumn.EdCodeCheatRsltId - 1)];
			entity.OriginalEdCodeCheatRsltId = (System.Int32)reader["ED_CODE_CHEAT_RSLT_ID"];
			entity.CheatRsltAr = (System.String)reader[((int)EdCodeCheatRsltColumn.CheatRsltAr - 1)];
			entity.CheatRsltEn = (System.String)reader[((int)EdCodeCheatRsltColumn.CheatRsltEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeCheatRslt"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCheatRslt"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeCheatRslt entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeCheatRsltId = (System.Int32)dataRow["ED_CODE_CHEAT_RSLT_ID"];
			entity.OriginalEdCodeCheatRsltId = (System.Int32)dataRow["ED_CODE_CHEAT_RSLT_ID"];
			entity.CheatRsltAr = (System.String)dataRow["CHEAT_RSLT_AR"];
			entity.CheatRsltEn = (System.String)dataRow["CHEAT_RSLT_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCheatRslt"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeCheatRslt Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCheatRslt entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeCheatRsltId methods when available
			
			#region EdStudCheatExecCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCheatExec>|EdStudCheatExecCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCheatExecCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCheatExecCollection = DataRepository.EdStudCheatExecProvider.GetByEdCodeCheatRsltId(transactionManager, entity.EdCodeCheatRsltId);

				if (deep && entity.EdStudCheatExecCollection.Count > 0)
				{
					deepHandles.Add("EdStudCheatExecCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCheatExec>) DataRepository.EdStudCheatExecProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCheatExecCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeCheatRslt object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeCheatRslt instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeCheatRslt Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCheatRslt entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudCheatExec>
				if (CanDeepSave(entity.EdStudCheatExecCollection, "List<EdStudCheatExec>|EdStudCheatExecCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCheatExec child in entity.EdStudCheatExecCollection)
					{
						if(child.EdCodeCheatRsltIdSource != null)
						{
							child.EdCodeCheatRsltId = child.EdCodeCheatRsltIdSource.EdCodeCheatRsltId;
						}
						else
						{
							child.EdCodeCheatRsltId = entity.EdCodeCheatRsltId;
						}

					}

					if (entity.EdStudCheatExecCollection.Count > 0 || entity.EdStudCheatExecCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCheatExecProvider.Save(transactionManager, entity.EdStudCheatExecCollection);
						
						deepHandles.Add("EdStudCheatExecCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCheatExec >) DataRepository.EdStudCheatExecProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCheatExecCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeCheatRsltChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeCheatRslt</c>
	///</summary>
	public enum EdCodeCheatRsltChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCodeCheatRslt</c> as OneToMany for EdStudCheatExecCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCheatExec>))]
		EdStudCheatExecCollection,
	}
	
	#endregion EdCodeCheatRsltChildEntityTypes
	
	#region EdCodeCheatRsltFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeCheatRsltColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCheatRslt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeCheatRsltFilterBuilder : SqlFilterBuilder<EdCodeCheatRsltColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCheatRsltFilterBuilder class.
		/// </summary>
		public EdCodeCheatRsltFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCheatRsltFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeCheatRsltFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCheatRsltFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeCheatRsltFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeCheatRsltFilterBuilder
	
	#region EdCodeCheatRsltParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeCheatRsltColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCheatRslt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeCheatRsltParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeCheatRsltColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCheatRsltParameterBuilder class.
		/// </summary>
		public EdCodeCheatRsltParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCheatRsltParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeCheatRsltParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCheatRsltParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeCheatRsltParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeCheatRsltParameterBuilder
	
	#region EdCodeCheatRsltSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeCheatRsltColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCheatRslt"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeCheatRsltSortBuilder : SqlSortBuilder<EdCodeCheatRsltColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCheatRsltSqlSortBuilder class.
		/// </summary>
		public EdCodeCheatRsltSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeCheatRsltSortBuilder
	
} // end namespace
