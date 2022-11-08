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
	/// This class is the base class for any <see cref="GsCodeApprovalListHProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeApprovalListHProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeApprovalListH, UMIS_VER2.BusinessLyer.GsCodeApprovalListHKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApprovalListHKey key)
		{
			return Delete(transactionManager, key.GsCodeApprovalListHId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeApprovalListHId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeApprovalListHId)
		{
			return Delete(null, _gsCodeApprovalListHId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalListHId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeApprovalListHId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeApprovalListH Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApprovalListHKey key, int start, int pageLength)
		{
			return GetByGsCodeApprovalListHId(transactionManager, key.GsCodeApprovalListHId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_APPROVAL_LIST_H index.
		/// </summary>
		/// <param name="_gsCodeApprovalListHId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalListH GetByGsCodeApprovalListHId(System.Decimal _gsCodeApprovalListHId)
		{
			int count = -1;
			return GetByGsCodeApprovalListHId(null,_gsCodeApprovalListHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_LIST_H index.
		/// </summary>
		/// <param name="_gsCodeApprovalListHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalListH GetByGsCodeApprovalListHId(System.Decimal _gsCodeApprovalListHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalListHId(null, _gsCodeApprovalListHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_LIST_H index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalListHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalListH GetByGsCodeApprovalListHId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalListHId)
		{
			int count = -1;
			return GetByGsCodeApprovalListHId(transactionManager, _gsCodeApprovalListHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_LIST_H index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalListHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalListH GetByGsCodeApprovalListHId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalListHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalListHId(transactionManager, _gsCodeApprovalListHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_LIST_H index.
		/// </summary>
		/// <param name="_gsCodeApprovalListHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalListH GetByGsCodeApprovalListHId(System.Decimal _gsCodeApprovalListHId, int start, int pageLength, out int count)
		{
			return GetByGsCodeApprovalListHId(null, _gsCodeApprovalListHId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_LIST_H index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalListHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListH"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeApprovalListH GetByGsCodeApprovalListHId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalListHId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeApprovalListH&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeApprovalListH&gt;"/></returns>
		public static TList<GsCodeApprovalListH> Fill(IDataReader reader, TList<GsCodeApprovalListH> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeApprovalListH c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeApprovalListH")
					.Append("|").Append((System.Decimal)reader["GS_CODE_APPROVAL_LIST_H_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeApprovalListH>(
					key.ToString(), // EntityTrackingKey
					"GsCodeApprovalListH",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeApprovalListH();
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
					c.GsCodeApprovalListHId = (System.Decimal)reader["GS_CODE_APPROVAL_LIST_H_ID"];
					c.OriginalGsCodeApprovalListHId = c.GsCodeApprovalListHId;
					c.HeaderDescrAr = (System.String)reader["HEADER_DESCR_AR"];
					c.HeaderDescrEn = Convert.IsDBNull(reader["HEADER_DESCR_EN"]) ? null : (System.String)reader["HEADER_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListH"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListH"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeApprovalListH entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeApprovalListHId = (System.Decimal)reader[((int)GsCodeApprovalListHColumn.GsCodeApprovalListHId - 1)];
			entity.OriginalGsCodeApprovalListHId = (System.Decimal)reader["GS_CODE_APPROVAL_LIST_H_ID"];
			entity.HeaderDescrAr = (System.String)reader[((int)GsCodeApprovalListHColumn.HeaderDescrAr - 1)];
			entity.HeaderDescrEn = (reader.IsDBNull(((int)GsCodeApprovalListHColumn.HeaderDescrEn - 1)))?null:(System.String)reader[((int)GsCodeApprovalListHColumn.HeaderDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListH"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListH"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeApprovalListH entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeApprovalListHId = (System.Decimal)dataRow["GS_CODE_APPROVAL_LIST_H_ID"];
			entity.OriginalGsCodeApprovalListHId = (System.Decimal)dataRow["GS_CODE_APPROVAL_LIST_H_ID"];
			entity.HeaderDescrAr = (System.String)dataRow["HEADER_DESCR_AR"];
			entity.HeaderDescrEn = Convert.IsDBNull(dataRow["HEADER_DESCR_EN"]) ? null : (System.String)dataRow["HEADER_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListH"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeApprovalListH Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApprovalListH entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeApprovalListHId methods when available
			
			#region GsCodeApprovalListDCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCodeApprovalListD>|GsCodeApprovalListDCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalListDCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCodeApprovalListDCollection = DataRepository.GsCodeApprovalListDProvider.GetByGsCodeApprovalListHId(transactionManager, entity.GsCodeApprovalListHId);

				if (deep && entity.GsCodeApprovalListDCollection.Count > 0)
				{
					deepHandles.Add("GsCodeApprovalListDCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCodeApprovalListD>) DataRepository.GsCodeApprovalListDProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCodeApprovalListDCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCodeApprovalFacultyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCodeApprovalFaculty>|GsCodeApprovalFacultyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalFacultyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCodeApprovalFacultyCollection = DataRepository.GsCodeApprovalFacultyProvider.GetByGsCodeApprovalListHId(transactionManager, entity.GsCodeApprovalListHId);

				if (deep && entity.GsCodeApprovalFacultyCollection.Count > 0)
				{
					deepHandles.Add("GsCodeApprovalFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCodeApprovalFaculty>) DataRepository.GsCodeApprovalFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCodeApprovalFacultyCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeApprovalListH object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeApprovalListH instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeApprovalListH Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApprovalListH entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<GsCodeApprovalListD>
				if (CanDeepSave(entity.GsCodeApprovalListDCollection, "List<GsCodeApprovalListD>|GsCodeApprovalListDCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCodeApprovalListD child in entity.GsCodeApprovalListDCollection)
					{
						if(child.GsCodeApprovalListHIdSource != null)
						{
							child.GsCodeApprovalListHId = child.GsCodeApprovalListHIdSource.GsCodeApprovalListHId;
						}
						else
						{
							child.GsCodeApprovalListHId = entity.GsCodeApprovalListHId;
						}

					}

					if (entity.GsCodeApprovalListDCollection.Count > 0 || entity.GsCodeApprovalListDCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCodeApprovalListDProvider.Save(transactionManager, entity.GsCodeApprovalListDCollection);
						
						deepHandles.Add("GsCodeApprovalListDCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCodeApprovalListD >) DataRepository.GsCodeApprovalListDProvider.DeepSave,
							new object[] { transactionManager, entity.GsCodeApprovalListDCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCodeApprovalFaculty>
				if (CanDeepSave(entity.GsCodeApprovalFacultyCollection, "List<GsCodeApprovalFaculty>|GsCodeApprovalFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCodeApprovalFaculty child in entity.GsCodeApprovalFacultyCollection)
					{
						if(child.GsCodeApprovalListHIdSource != null)
						{
							child.GsCodeApprovalListHId = child.GsCodeApprovalListHIdSource.GsCodeApprovalListHId;
						}
						else
						{
							child.GsCodeApprovalListHId = entity.GsCodeApprovalListHId;
						}

					}

					if (entity.GsCodeApprovalFacultyCollection.Count > 0 || entity.GsCodeApprovalFacultyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCodeApprovalFacultyProvider.Save(transactionManager, entity.GsCodeApprovalFacultyCollection);
						
						deepHandles.Add("GsCodeApprovalFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCodeApprovalFaculty >) DataRepository.GsCodeApprovalFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.GsCodeApprovalFacultyCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCodeApprovalListHChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeApprovalListH</c>
	///</summary>
	public enum GsCodeApprovalListHChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCodeApprovalListH</c> as OneToMany for GsCodeApprovalListDCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCodeApprovalListD>))]
		GsCodeApprovalListDCollection,
		///<summary>
		/// Collection of <c>GsCodeApprovalListH</c> as OneToMany for GsCodeApprovalFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCodeApprovalFaculty>))]
		GsCodeApprovalFacultyCollection,
	}
	
	#endregion GsCodeApprovalListHChildEntityTypes
	
	#region GsCodeApprovalListHFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeApprovalListHColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeApprovalListH"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeApprovalListHFilterBuilder : SqlFilterBuilder<GsCodeApprovalListHColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalListHFilterBuilder class.
		/// </summary>
		public GsCodeApprovalListHFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalListHFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeApprovalListHFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalListHFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeApprovalListHFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeApprovalListHFilterBuilder
	
	#region GsCodeApprovalListHParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeApprovalListHColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeApprovalListH"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeApprovalListHParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeApprovalListHColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalListHParameterBuilder class.
		/// </summary>
		public GsCodeApprovalListHParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalListHParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeApprovalListHParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalListHParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeApprovalListHParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeApprovalListHParameterBuilder
	
	#region GsCodeApprovalListHSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeApprovalListHColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeApprovalListH"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeApprovalListHSortBuilder : SqlSortBuilder<GsCodeApprovalListHColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalListHSqlSortBuilder class.
		/// </summary>
		public GsCodeApprovalListHSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeApprovalListHSortBuilder
	
} // end namespace
