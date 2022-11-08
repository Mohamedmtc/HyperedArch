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
	/// This class is the base class for any <see cref="SaCodeDocTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeDocTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeDocType, UMIS_VER2.BusinessLyer.SaCodeDocTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeDocTypeKey key)
		{
			return Delete(transactionManager, key.SaCodeDocTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeDocTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeDocTypeId)
		{
			return Delete(null, _saCodeDocTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeDocTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeDocTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeDocType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeDocTypeKey key, int start, int pageLength)
		{
			return GetBySaCodeDocTypeId(transactionManager, key.SaCodeDocTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SA_CODE_FILE_TYPE2 index.
		/// </summary>
		/// <param name="_typeDescrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDocType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDocType GetByTypeDescrAr(System.String _typeDescrAr)
		{
			int count = -1;
			return GetByTypeDescrAr(null,_typeDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_FILE_TYPE2 index.
		/// </summary>
		/// <param name="_typeDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDocType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDocType GetByTypeDescrAr(System.String _typeDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByTypeDescrAr(null, _typeDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_FILE_TYPE2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_typeDescrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDocType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDocType GetByTypeDescrAr(TransactionManager transactionManager, System.String _typeDescrAr)
		{
			int count = -1;
			return GetByTypeDescrAr(transactionManager, _typeDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_FILE_TYPE2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_typeDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDocType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDocType GetByTypeDescrAr(TransactionManager transactionManager, System.String _typeDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByTypeDescrAr(transactionManager, _typeDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_FILE_TYPE2 index.
		/// </summary>
		/// <param name="_typeDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDocType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDocType GetByTypeDescrAr(System.String _typeDescrAr, int start, int pageLength, out int count)
		{
			return GetByTypeDescrAr(null, _typeDescrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_FILE_TYPE2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_typeDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDocType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeDocType GetByTypeDescrAr(TransactionManager transactionManager, System.String _typeDescrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_DOC_TYPE index.
		/// </summary>
		/// <param name="_saCodeDocTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDocType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDocType GetBySaCodeDocTypeId(System.Decimal _saCodeDocTypeId)
		{
			int count = -1;
			return GetBySaCodeDocTypeId(null,_saCodeDocTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_DOC_TYPE index.
		/// </summary>
		/// <param name="_saCodeDocTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDocType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDocType GetBySaCodeDocTypeId(System.Decimal _saCodeDocTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeDocTypeId(null, _saCodeDocTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_DOC_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeDocTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDocType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDocType GetBySaCodeDocTypeId(TransactionManager transactionManager, System.Decimal _saCodeDocTypeId)
		{
			int count = -1;
			return GetBySaCodeDocTypeId(transactionManager, _saCodeDocTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_DOC_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeDocTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDocType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDocType GetBySaCodeDocTypeId(TransactionManager transactionManager, System.Decimal _saCodeDocTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeDocTypeId(transactionManager, _saCodeDocTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_DOC_TYPE index.
		/// </summary>
		/// <param name="_saCodeDocTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDocType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDocType GetBySaCodeDocTypeId(System.Decimal _saCodeDocTypeId, int start, int pageLength, out int count)
		{
			return GetBySaCodeDocTypeId(null, _saCodeDocTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_DOC_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeDocTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDocType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeDocType GetBySaCodeDocTypeId(TransactionManager transactionManager, System.Decimal _saCodeDocTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeDocType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeDocType&gt;"/></returns>
		public static TList<SaCodeDocType> Fill(IDataReader reader, TList<SaCodeDocType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeDocType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeDocType")
					.Append("|").Append((System.Decimal)reader["SA_CODE_DOC_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeDocType>(
					key.ToString(), // EntityTrackingKey
					"SaCodeDocType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeDocType();
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
					c.SaCodeDocTypeId = (System.Decimal)reader["SA_CODE_DOC_TYPE_ID"];
					c.OriginalSaCodeDocTypeId = c.SaCodeDocTypeId;
					c.TypeCode = Convert.IsDBNull(reader["TYPE_CODE"]) ? null : (System.String)reader["TYPE_CODE"];
					c.TypeDescrAr = (System.String)reader["TYPE_DESCR_AR"];
					c.TypeDescrEn = Convert.IsDBNull(reader["TYPE_DESCR_EN"]) ? null : (System.String)reader["TYPE_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeDocType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeDocType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeDocType entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeDocTypeId = (System.Decimal)reader[((int)SaCodeDocTypeColumn.SaCodeDocTypeId - 1)];
			entity.OriginalSaCodeDocTypeId = (System.Decimal)reader["SA_CODE_DOC_TYPE_ID"];
			entity.TypeCode = (reader.IsDBNull(((int)SaCodeDocTypeColumn.TypeCode - 1)))?null:(System.String)reader[((int)SaCodeDocTypeColumn.TypeCode - 1)];
			entity.TypeDescrAr = (System.String)reader[((int)SaCodeDocTypeColumn.TypeDescrAr - 1)];
			entity.TypeDescrEn = (reader.IsDBNull(((int)SaCodeDocTypeColumn.TypeDescrEn - 1)))?null:(System.String)reader[((int)SaCodeDocTypeColumn.TypeDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeDocType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeDocType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeDocType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeDocTypeId = (System.Decimal)dataRow["SA_CODE_DOC_TYPE_ID"];
			entity.OriginalSaCodeDocTypeId = (System.Decimal)dataRow["SA_CODE_DOC_TYPE_ID"];
			entity.TypeCode = Convert.IsDBNull(dataRow["TYPE_CODE"]) ? null : (System.String)dataRow["TYPE_CODE"];
			entity.TypeDescrAr = (System.String)dataRow["TYPE_DESCR_AR"];
			entity.TypeDescrEn = Convert.IsDBNull(dataRow["TYPE_DESCR_EN"]) ? null : (System.String)dataRow["TYPE_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeDocType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeDocType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeDocType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeDocTypeId methods when available
			
			#region SaCodeDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaCodeDoc>|SaCodeDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaCodeDocCollection = DataRepository.SaCodeDocProvider.GetBySaCodeDocTypeId(transactionManager, entity.SaCodeDocTypeId);

				if (deep && entity.SaCodeDocCollection.Count > 0)
				{
					deepHandles.Add("SaCodeDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaCodeDoc>) DataRepository.SaCodeDocProvider.DeepLoad,
						new object[] { transactionManager, entity.SaCodeDocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeDocType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeDocType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeDocType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeDocType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaCodeDoc>
				if (CanDeepSave(entity.SaCodeDocCollection, "List<SaCodeDoc>|SaCodeDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaCodeDoc child in entity.SaCodeDocCollection)
					{
						if(child.SaCodeDocTypeIdSource != null)
						{
							child.SaCodeDocTypeId = child.SaCodeDocTypeIdSource.SaCodeDocTypeId;
						}
						else
						{
							child.SaCodeDocTypeId = entity.SaCodeDocTypeId;
						}

					}

					if (entity.SaCodeDocCollection.Count > 0 || entity.SaCodeDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaCodeDocProvider.Save(transactionManager, entity.SaCodeDocCollection);
						
						deepHandles.Add("SaCodeDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaCodeDoc >) DataRepository.SaCodeDocProvider.DeepSave,
							new object[] { transactionManager, entity.SaCodeDocCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodeDocTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeDocType</c>
	///</summary>
	public enum SaCodeDocTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCodeDocType</c> as OneToMany for SaCodeDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaCodeDoc>))]
		SaCodeDocCollection,
	}
	
	#endregion SaCodeDocTypeChildEntityTypes
	
	#region SaCodeDocTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeDocTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeDocType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeDocTypeFilterBuilder : SqlFilterBuilder<SaCodeDocTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeDocTypeFilterBuilder class.
		/// </summary>
		public SaCodeDocTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeDocTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeDocTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeDocTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeDocTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeDocTypeFilterBuilder
	
	#region SaCodeDocTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeDocTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeDocType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeDocTypeParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeDocTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeDocTypeParameterBuilder class.
		/// </summary>
		public SaCodeDocTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeDocTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeDocTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeDocTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeDocTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeDocTypeParameterBuilder
	
	#region SaCodeDocTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeDocTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeDocType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeDocTypeSortBuilder : SqlSortBuilder<SaCodeDocTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeDocTypeSqlSortBuilder class.
		/// </summary>
		public SaCodeDocTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeDocTypeSortBuilder
	
} // end namespace
