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
	/// This class is the base class for any <see cref="SaCodeVacationTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeVacationTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeVacationType, UMIS_VER2.BusinessLyer.SaCodeVacationTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeVacationTypeKey key)
		{
			return Delete(transactionManager, key.SaCodeVacationTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeVacationTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeVacationTypeId)
		{
			return Delete(null, _saCodeVacationTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeVacationTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeVacationTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeVacationType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeVacationTypeKey key, int start, int pageLength)
		{
			return GetBySaCodeVacationTypeId(transactionManager, key.SaCodeVacationTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_VACATION_TYPE index.
		/// </summary>
		/// <param name="_saCodeVacationTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeVacationType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeVacationType GetBySaCodeVacationTypeId(System.Decimal _saCodeVacationTypeId)
		{
			int count = -1;
			return GetBySaCodeVacationTypeId(null,_saCodeVacationTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_VACATION_TYPE index.
		/// </summary>
		/// <param name="_saCodeVacationTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeVacationType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeVacationType GetBySaCodeVacationTypeId(System.Decimal _saCodeVacationTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeVacationTypeId(null, _saCodeVacationTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_VACATION_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeVacationTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeVacationType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeVacationType GetBySaCodeVacationTypeId(TransactionManager transactionManager, System.Decimal _saCodeVacationTypeId)
		{
			int count = -1;
			return GetBySaCodeVacationTypeId(transactionManager, _saCodeVacationTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_VACATION_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeVacationTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeVacationType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeVacationType GetBySaCodeVacationTypeId(TransactionManager transactionManager, System.Decimal _saCodeVacationTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeVacationTypeId(transactionManager, _saCodeVacationTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_VACATION_TYPE index.
		/// </summary>
		/// <param name="_saCodeVacationTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeVacationType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeVacationType GetBySaCodeVacationTypeId(System.Decimal _saCodeVacationTypeId, int start, int pageLength, out int count)
		{
			return GetBySaCodeVacationTypeId(null, _saCodeVacationTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_VACATION_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeVacationTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeVacationType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeVacationType GetBySaCodeVacationTypeId(TransactionManager transactionManager, System.Decimal _saCodeVacationTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeVacationType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeVacationType&gt;"/></returns>
		public static TList<SaCodeVacationType> Fill(IDataReader reader, TList<SaCodeVacationType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeVacationType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeVacationType")
					.Append("|").Append((System.Decimal)reader["SA_CODE_VACATION_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeVacationType>(
					key.ToString(), // EntityTrackingKey
					"SaCodeVacationType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeVacationType();
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
					c.SaCodeVacationTypeId = (System.Decimal)reader["SA_CODE_VACATION_TYPE_ID"];
					c.OriginalSaCodeVacationTypeId = c.SaCodeVacationTypeId;
					c.VacationTypeCode = Convert.IsDBNull(reader["VACATION_TYPE_CODE"]) ? null : (System.String)reader["VACATION_TYPE_CODE"];
					c.VacationTypeDescrAr = (System.String)reader["VACATION_TYPE_DESCR_AR"];
					c.VacationTypeDescrEn = Convert.IsDBNull(reader["VACATION_TYPE_DESCR_EN"]) ? null : (System.String)reader["VACATION_TYPE_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeVacationType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeVacationType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeVacationType entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeVacationTypeId = (System.Decimal)reader[((int)SaCodeVacationTypeColumn.SaCodeVacationTypeId - 1)];
			entity.OriginalSaCodeVacationTypeId = (System.Decimal)reader["SA_CODE_VACATION_TYPE_ID"];
			entity.VacationTypeCode = (reader.IsDBNull(((int)SaCodeVacationTypeColumn.VacationTypeCode - 1)))?null:(System.String)reader[((int)SaCodeVacationTypeColumn.VacationTypeCode - 1)];
			entity.VacationTypeDescrAr = (System.String)reader[((int)SaCodeVacationTypeColumn.VacationTypeDescrAr - 1)];
			entity.VacationTypeDescrEn = (reader.IsDBNull(((int)SaCodeVacationTypeColumn.VacationTypeDescrEn - 1)))?null:(System.String)reader[((int)SaCodeVacationTypeColumn.VacationTypeDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeVacationType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeVacationType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeVacationType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeVacationTypeId = (System.Decimal)dataRow["SA_CODE_VACATION_TYPE_ID"];
			entity.OriginalSaCodeVacationTypeId = (System.Decimal)dataRow["SA_CODE_VACATION_TYPE_ID"];
			entity.VacationTypeCode = Convert.IsDBNull(dataRow["VACATION_TYPE_CODE"]) ? null : (System.String)dataRow["VACATION_TYPE_CODE"];
			entity.VacationTypeDescrAr = (System.String)dataRow["VACATION_TYPE_DESCR_AR"];
			entity.VacationTypeDescrEn = Convert.IsDBNull(dataRow["VACATION_TYPE_DESCR_EN"]) ? null : (System.String)dataRow["VACATION_TYPE_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeVacationType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeVacationType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeVacationType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeVacationTypeId methods when available
			
			#region SaVacationBylawsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaVacationBylaws>|SaVacationBylawsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationBylawsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaVacationBylawsCollection = DataRepository.SaVacationBylawsProvider.GetBySaCodeVacationTypeId(transactionManager, entity.SaCodeVacationTypeId);

				if (deep && entity.SaVacationBylawsCollection.Count > 0)
				{
					deepHandles.Add("SaVacationBylawsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaVacationBylaws>) DataRepository.SaVacationBylawsProvider.DeepLoad,
						new object[] { transactionManager, entity.SaVacationBylawsCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeVacationType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeVacationType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeVacationType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeVacationType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaVacationBylaws>
				if (CanDeepSave(entity.SaVacationBylawsCollection, "List<SaVacationBylaws>|SaVacationBylawsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaVacationBylaws child in entity.SaVacationBylawsCollection)
					{
						if(child.SaCodeVacationTypeIdSource != null)
						{
							child.SaCodeVacationTypeId = child.SaCodeVacationTypeIdSource.SaCodeVacationTypeId;
						}
						else
						{
							child.SaCodeVacationTypeId = entity.SaCodeVacationTypeId;
						}

					}

					if (entity.SaVacationBylawsCollection.Count > 0 || entity.SaVacationBylawsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaVacationBylawsProvider.Save(transactionManager, entity.SaVacationBylawsCollection);
						
						deepHandles.Add("SaVacationBylawsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaVacationBylaws >) DataRepository.SaVacationBylawsProvider.DeepSave,
							new object[] { transactionManager, entity.SaVacationBylawsCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodeVacationTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeVacationType</c>
	///</summary>
	public enum SaCodeVacationTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCodeVacationType</c> as OneToMany for SaVacationBylawsCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaVacationBylaws>))]
		SaVacationBylawsCollection,
	}
	
	#endregion SaCodeVacationTypeChildEntityTypes
	
	#region SaCodeVacationTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeVacationTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeVacationType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeVacationTypeFilterBuilder : SqlFilterBuilder<SaCodeVacationTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeVacationTypeFilterBuilder class.
		/// </summary>
		public SaCodeVacationTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeVacationTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeVacationTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeVacationTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeVacationTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeVacationTypeFilterBuilder
	
	#region SaCodeVacationTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeVacationTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeVacationType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeVacationTypeParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeVacationTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeVacationTypeParameterBuilder class.
		/// </summary>
		public SaCodeVacationTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeVacationTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeVacationTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeVacationTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeVacationTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeVacationTypeParameterBuilder
	
	#region SaCodeVacationTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeVacationTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeVacationType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeVacationTypeSortBuilder : SqlSortBuilder<SaCodeVacationTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeVacationTypeSqlSortBuilder class.
		/// </summary>
		public SaCodeVacationTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeVacationTypeSortBuilder
	
} // end namespace
