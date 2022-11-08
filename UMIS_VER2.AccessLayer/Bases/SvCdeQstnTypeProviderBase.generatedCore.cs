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
	/// This class is the base class for any <see cref="SvCdeQstnTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvCdeQstnTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvCdeQstnType, UMIS_VER2.BusinessLyer.SvCdeQstnTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeQstnTypeKey key)
		{
			return Delete(transactionManager, key.SvCdeQstnTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svCdeQstnTypeId">radio, check box, free text. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _svCdeQstnTypeId)
		{
			return Delete(null, _svCdeQstnTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeQstnTypeId">radio, check box, free text. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _svCdeQstnTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.SvCdeQstnType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeQstnTypeKey key, int start, int pageLength)
		{
			return GetBySvCdeQstnTypeId(transactionManager, key.SvCdeQstnTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_CDE_QSTN_TYPE index.
		/// </summary>
		/// <param name="_svCdeQstnTypeId">radio, check box, free text</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeQstnType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeQstnType GetBySvCdeQstnTypeId(System.Int32 _svCdeQstnTypeId)
		{
			int count = -1;
			return GetBySvCdeQstnTypeId(null,_svCdeQstnTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_QSTN_TYPE index.
		/// </summary>
		/// <param name="_svCdeQstnTypeId">radio, check box, free text</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeQstnType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeQstnType GetBySvCdeQstnTypeId(System.Int32 _svCdeQstnTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeQstnTypeId(null, _svCdeQstnTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_QSTN_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeQstnTypeId">radio, check box, free text</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeQstnType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeQstnType GetBySvCdeQstnTypeId(TransactionManager transactionManager, System.Int32 _svCdeQstnTypeId)
		{
			int count = -1;
			return GetBySvCdeQstnTypeId(transactionManager, _svCdeQstnTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_QSTN_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeQstnTypeId">radio, check box, free text</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeQstnType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeQstnType GetBySvCdeQstnTypeId(TransactionManager transactionManager, System.Int32 _svCdeQstnTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeQstnTypeId(transactionManager, _svCdeQstnTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_QSTN_TYPE index.
		/// </summary>
		/// <param name="_svCdeQstnTypeId">radio, check box, free text</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeQstnType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeQstnType GetBySvCdeQstnTypeId(System.Int32 _svCdeQstnTypeId, int start, int pageLength, out int count)
		{
			return GetBySvCdeQstnTypeId(null, _svCdeQstnTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_QSTN_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeQstnTypeId">radio, check box, free text</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeQstnType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCdeQstnType GetBySvCdeQstnTypeId(TransactionManager transactionManager, System.Int32 _svCdeQstnTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvCdeQstnType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvCdeQstnType&gt;"/></returns>
		public static TList<SvCdeQstnType> Fill(IDataReader reader, TList<SvCdeQstnType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvCdeQstnType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvCdeQstnType")
					.Append("|").Append((System.Int32)reader["SV_CDE_QSTN_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvCdeQstnType>(
					key.ToString(), // EntityTrackingKey
					"SvCdeQstnType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvCdeQstnType();
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
					c.SvCdeQstnTypeId = (System.Int32)reader["SV_CDE_QSTN_TYPE_ID"];
					c.OriginalSvCdeQstnTypeId = c.SvCdeQstnTypeId;
					c.QstnTypeAr = (System.String)reader["QSTN_TYPE_AR"];
					c.QstnTypeEn = (System.String)reader["QSTN_TYPE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeQstnType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeQstnType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvCdeQstnType entity)
		{
			if (!reader.Read()) return;
			
			entity.SvCdeQstnTypeId = (System.Int32)reader[((int)SvCdeQstnTypeColumn.SvCdeQstnTypeId - 1)];
			entity.OriginalSvCdeQstnTypeId = (System.Int32)reader["SV_CDE_QSTN_TYPE_ID"];
			entity.QstnTypeAr = (System.String)reader[((int)SvCdeQstnTypeColumn.QstnTypeAr - 1)];
			entity.QstnTypeEn = (System.String)reader[((int)SvCdeQstnTypeColumn.QstnTypeEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeQstnType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeQstnType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvCdeQstnType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvCdeQstnTypeId = (System.Int32)dataRow["SV_CDE_QSTN_TYPE_ID"];
			entity.OriginalSvCdeQstnTypeId = (System.Int32)dataRow["SV_CDE_QSTN_TYPE_ID"];
			entity.QstnTypeAr = (System.String)dataRow["QSTN_TYPE_AR"];
			entity.QstnTypeEn = (System.String)dataRow["QSTN_TYPE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeQstnType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeQstnType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeQstnType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvCdeQstnTypeId methods when available
			
			#region SvSrvyQstnCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvSrvyQstn>|SvSrvyQstnCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvSrvyQstnCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvSrvyQstnCollection = DataRepository.SvSrvyQstnProvider.GetBySvCdeQstnTypeId(transactionManager, entity.SvCdeQstnTypeId);

				if (deep && entity.SvSrvyQstnCollection.Count > 0)
				{
					deepHandles.Add("SvSrvyQstnCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvSrvyQstn>) DataRepository.SvSrvyQstnProvider.DeepLoad,
						new object[] { transactionManager, entity.SvSrvyQstnCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvCdeQstnType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvCdeQstnType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeQstnType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeQstnType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SvSrvyQstn>
				if (CanDeepSave(entity.SvSrvyQstnCollection, "List<SvSrvyQstn>|SvSrvyQstnCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvSrvyQstn child in entity.SvSrvyQstnCollection)
					{
						if(child.SvCdeQstnTypeIdSource != null)
						{
							child.SvCdeQstnTypeId = child.SvCdeQstnTypeIdSource.SvCdeQstnTypeId;
						}
						else
						{
							child.SvCdeQstnTypeId = entity.SvCdeQstnTypeId;
						}

					}

					if (entity.SvSrvyQstnCollection.Count > 0 || entity.SvSrvyQstnCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvSrvyQstnProvider.Save(transactionManager, entity.SvSrvyQstnCollection);
						
						deepHandles.Add("SvSrvyQstnCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvSrvyQstn >) DataRepository.SvSrvyQstnProvider.DeepSave,
							new object[] { transactionManager, entity.SvSrvyQstnCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvCdeQstnTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvCdeQstnType</c>
	///</summary>
	public enum SvCdeQstnTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SvCdeQstnType</c> as OneToMany for SvSrvyQstnCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvSrvyQstn>))]
		SvSrvyQstnCollection,
	}
	
	#endregion SvCdeQstnTypeChildEntityTypes
	
	#region SvCdeQstnTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvCdeQstnTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeQstnType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeQstnTypeFilterBuilder : SqlFilterBuilder<SvCdeQstnTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeQstnTypeFilterBuilder class.
		/// </summary>
		public SvCdeQstnTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeQstnTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeQstnTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeQstnTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeQstnTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeQstnTypeFilterBuilder
	
	#region SvCdeQstnTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvCdeQstnTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeQstnType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeQstnTypeParameterBuilder : ParameterizedSqlFilterBuilder<SvCdeQstnTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeQstnTypeParameterBuilder class.
		/// </summary>
		public SvCdeQstnTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeQstnTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeQstnTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeQstnTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeQstnTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeQstnTypeParameterBuilder
	
	#region SvCdeQstnTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvCdeQstnTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeQstnType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvCdeQstnTypeSortBuilder : SqlSortBuilder<SvCdeQstnTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeQstnTypeSqlSortBuilder class.
		/// </summary>
		public SvCdeQstnTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvCdeQstnTypeSortBuilder
	
} // end namespace