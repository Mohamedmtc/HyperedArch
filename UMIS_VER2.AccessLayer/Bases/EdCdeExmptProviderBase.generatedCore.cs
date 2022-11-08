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
	/// This class is the base class for any <see cref="EdCdeExmptProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeExmptProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCdeExmpt, UMIS_VER2.BusinessLyer.EdCdeExmptKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeExmptKey key)
		{
			return Delete(transactionManager, key.EdCdeExmptId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCdeExmptId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _edCdeExmptId)
		{
			return Delete(null, _edCdeExmptId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExmptId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _edCdeExmptId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCdeExmpt Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeExmptKey key, int start, int pageLength)
		{
			return GetByEdCdeExmptId(transactionManager, key.EdCdeExmptId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CDE_EXMPT index.
		/// </summary>
		/// <param name="_edCdeExmptId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExmpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExmpt GetByEdCdeExmptId(System.Int32 _edCdeExmptId)
		{
			int count = -1;
			return GetByEdCdeExmptId(null,_edCdeExmptId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EXMPT index.
		/// </summary>
		/// <param name="_edCdeExmptId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExmpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExmpt GetByEdCdeExmptId(System.Int32 _edCdeExmptId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExmptId(null, _edCdeExmptId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EXMPT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExmptId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExmpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExmpt GetByEdCdeExmptId(TransactionManager transactionManager, System.Int32 _edCdeExmptId)
		{
			int count = -1;
			return GetByEdCdeExmptId(transactionManager, _edCdeExmptId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EXMPT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExmptId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExmpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExmpt GetByEdCdeExmptId(TransactionManager transactionManager, System.Int32 _edCdeExmptId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExmptId(transactionManager, _edCdeExmptId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EXMPT index.
		/// </summary>
		/// <param name="_edCdeExmptId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExmpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExmpt GetByEdCdeExmptId(System.Int32 _edCdeExmptId, int start, int pageLength, out int count)
		{
			return GetByEdCdeExmptId(null, _edCdeExmptId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EXMPT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExmptId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExmpt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeExmpt GetByEdCdeExmptId(TransactionManager transactionManager, System.Int32 _edCdeExmptId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCdeExmpt&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCdeExmpt&gt;"/></returns>
		public static TList<EdCdeExmpt> Fill(IDataReader reader, TList<EdCdeExmpt> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCdeExmpt c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCdeExmpt")
					.Append("|").Append((System.Int32)reader["ED_CDE_EXMPT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCdeExmpt>(
					key.ToString(), // EntityTrackingKey
					"EdCdeExmpt",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCdeExmpt();
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
					c.EdCdeExmptId = (System.Int32)reader["ED_CDE_EXMPT_ID"];
					c.OriginalEdCdeExmptId = c.EdCdeExmptId;
					c.ExmptAr = (System.String)reader["EXMPT_AR"];
					c.ExmptEn = (System.String)reader["EXMPT_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeExmpt"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeExmpt"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCdeExmpt entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCdeExmptId = (System.Int32)reader[((int)EdCdeExmptColumn.EdCdeExmptId - 1)];
			entity.OriginalEdCdeExmptId = (System.Int32)reader["ED_CDE_EXMPT_ID"];
			entity.ExmptAr = (System.String)reader[((int)EdCdeExmptColumn.ExmptAr - 1)];
			entity.ExmptEn = (System.String)reader[((int)EdCdeExmptColumn.ExmptEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeExmpt"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeExmpt"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCdeExmpt entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCdeExmptId = (System.Int32)dataRow["ED_CDE_EXMPT_ID"];
			entity.OriginalEdCdeExmptId = (System.Int32)dataRow["ED_CDE_EXMPT_ID"];
			entity.ExmptAr = (System.String)dataRow["EXMPT_AR"];
			entity.ExmptEn = (System.String)dataRow["EXMPT_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeExmpt"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeExmpt Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeExmpt entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCdeExmptId methods when available
			
			#region EdStudExmptReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExmptReq>|EdStudExmptReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExmptReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExmptReqCollection = DataRepository.EdStudExmptReqProvider.GetByEdCdeExmptId(transactionManager, entity.EdCdeExmptId);

				if (deep && entity.EdStudExmptReqCollection.Count > 0)
				{
					deepHandles.Add("EdStudExmptReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExmptReq>) DataRepository.EdStudExmptReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExmptReqCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCdeExmpt object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCdeExmpt instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeExmpt Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeExmpt entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudExmptReq>
				if (CanDeepSave(entity.EdStudExmptReqCollection, "List<EdStudExmptReq>|EdStudExmptReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExmptReq child in entity.EdStudExmptReqCollection)
					{
						if(child.EdCdeExmptIdSource != null)
						{
							child.EdCdeExmptId = child.EdCdeExmptIdSource.EdCdeExmptId;
						}
						else
						{
							child.EdCdeExmptId = entity.EdCdeExmptId;
						}

					}

					if (entity.EdStudExmptReqCollection.Count > 0 || entity.EdStudExmptReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExmptReqProvider.Save(transactionManager, entity.EdStudExmptReqCollection);
						
						deepHandles.Add("EdStudExmptReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExmptReq >) DataRepository.EdStudExmptReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExmptReqCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCdeExmptChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCdeExmpt</c>
	///</summary>
	public enum EdCdeExmptChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCdeExmpt</c> as OneToMany for EdStudExmptReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExmptReq>))]
		EdStudExmptReqCollection,
	}
	
	#endregion EdCdeExmptChildEntityTypes
	
	#region EdCdeExmptFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCdeExmptColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeExmpt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeExmptFilterBuilder : SqlFilterBuilder<EdCdeExmptColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeExmptFilterBuilder class.
		/// </summary>
		public EdCdeExmptFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeExmptFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeExmptFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeExmptFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeExmptFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeExmptFilterBuilder
	
	#region EdCdeExmptParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCdeExmptColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeExmpt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeExmptParameterBuilder : ParameterizedSqlFilterBuilder<EdCdeExmptColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeExmptParameterBuilder class.
		/// </summary>
		public EdCdeExmptParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeExmptParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeExmptParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeExmptParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeExmptParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeExmptParameterBuilder
	
	#region EdCdeExmptSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCdeExmptColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeExmpt"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCdeExmptSortBuilder : SqlSortBuilder<EdCdeExmptColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeExmptSqlSortBuilder class.
		/// </summary>
		public EdCdeExmptSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCdeExmptSortBuilder
	
} // end namespace
