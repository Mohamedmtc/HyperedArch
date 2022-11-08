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
	/// This class is the base class for any <see cref="AccomCdeWarnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomCdeWarnProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomCdeWarn, UMIS_VER2.BusinessLyer.AccomCdeWarnKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeWarnKey key)
		{
			return Delete(transactionManager, key.AccomCdeWarnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomCdeWarnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _accomCdeWarnId)
		{
			return Delete(null, _accomCdeWarnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeWarnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _accomCdeWarnId);		
		
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
		public override UMIS_VER2.BusinessLyer.AccomCdeWarn Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeWarnKey key, int start, int pageLength)
		{
			return GetByAccomCdeWarnId(transactionManager, key.AccomCdeWarnId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_CDE_WARN index.
		/// </summary>
		/// <param name="_accomCdeWarnId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeWarn GetByAccomCdeWarnId(System.Int32 _accomCdeWarnId)
		{
			int count = -1;
			return GetByAccomCdeWarnId(null,_accomCdeWarnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_WARN index.
		/// </summary>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeWarn GetByAccomCdeWarnId(System.Int32 _accomCdeWarnId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdeWarnId(null, _accomCdeWarnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_WARN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeWarnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeWarn GetByAccomCdeWarnId(TransactionManager transactionManager, System.Int32 _accomCdeWarnId)
		{
			int count = -1;
			return GetByAccomCdeWarnId(transactionManager, _accomCdeWarnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_WARN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeWarn GetByAccomCdeWarnId(TransactionManager transactionManager, System.Int32 _accomCdeWarnId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdeWarnId(transactionManager, _accomCdeWarnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_WARN index.
		/// </summary>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeWarn GetByAccomCdeWarnId(System.Int32 _accomCdeWarnId, int start, int pageLength, out int count)
		{
			return GetByAccomCdeWarnId(null, _accomCdeWarnId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_WARN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeWarn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomCdeWarn GetByAccomCdeWarnId(TransactionManager transactionManager, System.Int32 _accomCdeWarnId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomCdeWarn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomCdeWarn&gt;"/></returns>
		public static TList<AccomCdeWarn> Fill(IDataReader reader, TList<AccomCdeWarn> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomCdeWarn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomCdeWarn")
					.Append("|").Append((System.Int32)reader["ACCOM_CDE_WARN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomCdeWarn>(
					key.ToString(), // EntityTrackingKey
					"AccomCdeWarn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomCdeWarn();
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
					c.AccomCdeWarnId = (System.Int32)reader["ACCOM_CDE_WARN_ID"];
					c.OriginalAccomCdeWarnId = c.AccomCdeWarnId;
					c.WarnAr = Convert.IsDBNull(reader["WARN_AR"]) ? null : (System.String)reader["WARN_AR"];
					c.WarnEn = Convert.IsDBNull(reader["WARN_EN"]) ? null : (System.String)reader["WARN_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomCdeWarn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdeWarn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomCdeWarn entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomCdeWarnId = (System.Int32)reader[((int)AccomCdeWarnColumn.AccomCdeWarnId - 1)];
			entity.OriginalAccomCdeWarnId = (System.Int32)reader["ACCOM_CDE_WARN_ID"];
			entity.WarnAr = (reader.IsDBNull(((int)AccomCdeWarnColumn.WarnAr - 1)))?null:(System.String)reader[((int)AccomCdeWarnColumn.WarnAr - 1)];
			entity.WarnEn = (reader.IsDBNull(((int)AccomCdeWarnColumn.WarnEn - 1)))?null:(System.String)reader[((int)AccomCdeWarnColumn.WarnEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomCdeWarn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdeWarn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomCdeWarn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomCdeWarnId = (System.Int32)dataRow["ACCOM_CDE_WARN_ID"];
			entity.OriginalAccomCdeWarnId = (System.Int32)dataRow["ACCOM_CDE_WARN_ID"];
			entity.WarnAr = Convert.IsDBNull(dataRow["WARN_AR"]) ? null : (System.String)dataRow["WARN_AR"];
			entity.WarnEn = Convert.IsDBNull(dataRow["WARN_EN"]) ? null : (System.String)dataRow["WARN_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdeWarn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomCdeWarn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeWarn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAccomCdeWarnId methods when available
			
			#region AccomPolcyAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomPolcyAbsence>|AccomPolcyAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomPolcyAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomPolcyAbsenceCollection = DataRepository.AccomPolcyAbsenceProvider.GetByAccomCdeWarnId(transactionManager, entity.AccomCdeWarnId);

				if (deep && entity.AccomPolcyAbsenceCollection.Count > 0)
				{
					deepHandles.Add("AccomPolcyAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomPolcyAbsence>) DataRepository.AccomPolcyAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomPolcyAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudAbsenceWarnCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudAbsenceWarn>|AccomStudAbsenceWarnCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudAbsenceWarnCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudAbsenceWarnCollection = DataRepository.AccomStudAbsenceWarnProvider.GetByAccomCdeWarnId(transactionManager, entity.AccomCdeWarnId);

				if (deep && entity.AccomStudAbsenceWarnCollection.Count > 0)
				{
					deepHandles.Add("AccomStudAbsenceWarnCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudAbsenceWarn>) DataRepository.AccomStudAbsenceWarnProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudAbsenceWarnCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomCdeWarn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomCdeWarn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomCdeWarn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeWarn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AccomPolcyAbsence>
				if (CanDeepSave(entity.AccomPolcyAbsenceCollection, "List<AccomPolcyAbsence>|AccomPolcyAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomPolcyAbsence child in entity.AccomPolcyAbsenceCollection)
					{
						if(child.AccomCdeWarnIdSource != null)
						{
							child.AccomCdeWarnId = child.AccomCdeWarnIdSource.AccomCdeWarnId;
						}
						else
						{
							child.AccomCdeWarnId = entity.AccomCdeWarnId;
						}

					}

					if (entity.AccomPolcyAbsenceCollection.Count > 0 || entity.AccomPolcyAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomPolcyAbsenceProvider.Save(transactionManager, entity.AccomPolcyAbsenceCollection);
						
						deepHandles.Add("AccomPolcyAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomPolcyAbsence >) DataRepository.AccomPolcyAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.AccomPolcyAbsenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudAbsenceWarn>
				if (CanDeepSave(entity.AccomStudAbsenceWarnCollection, "List<AccomStudAbsenceWarn>|AccomStudAbsenceWarnCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudAbsenceWarn child in entity.AccomStudAbsenceWarnCollection)
					{
						if(child.AccomCdeWarnIdSource != null)
						{
							child.AccomCdeWarnId = child.AccomCdeWarnIdSource.AccomCdeWarnId;
						}
						else
						{
							child.AccomCdeWarnId = entity.AccomCdeWarnId;
						}

					}

					if (entity.AccomStudAbsenceWarnCollection.Count > 0 || entity.AccomStudAbsenceWarnCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudAbsenceWarnProvider.Save(transactionManager, entity.AccomStudAbsenceWarnCollection);
						
						deepHandles.Add("AccomStudAbsenceWarnCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudAbsenceWarn >) DataRepository.AccomStudAbsenceWarnProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudAbsenceWarnCollection, deepSaveType, childTypes, innerList }
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
	
	#region AccomCdeWarnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomCdeWarn</c>
	///</summary>
	public enum AccomCdeWarnChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AccomCdeWarn</c> as OneToMany for AccomPolcyAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomPolcyAbsence>))]
		AccomPolcyAbsenceCollection,
		///<summary>
		/// Collection of <c>AccomCdeWarn</c> as OneToMany for AccomStudAbsenceWarnCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudAbsenceWarn>))]
		AccomStudAbsenceWarnCollection,
	}
	
	#endregion AccomCdeWarnChildEntityTypes
	
	#region AccomCdeWarnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomCdeWarnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdeWarn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomCdeWarnFilterBuilder : SqlFilterBuilder<AccomCdeWarnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdeWarnFilterBuilder class.
		/// </summary>
		public AccomCdeWarnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeWarnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomCdeWarnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeWarnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomCdeWarnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomCdeWarnFilterBuilder
	
	#region AccomCdeWarnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomCdeWarnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdeWarn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomCdeWarnParameterBuilder : ParameterizedSqlFilterBuilder<AccomCdeWarnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdeWarnParameterBuilder class.
		/// </summary>
		public AccomCdeWarnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeWarnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomCdeWarnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeWarnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomCdeWarnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomCdeWarnParameterBuilder
	
	#region AccomCdeWarnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomCdeWarnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdeWarn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomCdeWarnSortBuilder : SqlSortBuilder<AccomCdeWarnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdeWarnSqlSortBuilder class.
		/// </summary>
		public AccomCdeWarnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomCdeWarnSortBuilder
	
} // end namespace
