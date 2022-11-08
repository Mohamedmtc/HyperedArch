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
	/// This class is the base class for any <see cref="GsCdeSportTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeSportTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeSportType, UMIS_VER2.BusinessLyer.GsCdeSportTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeSportTypeKey key)
		{
			return Delete(transactionManager, key.GsCdeSportTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeSportTypeId">كود نوع اللعبة الرياضة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeSportTypeId)
		{
			return Delete(null, _gsCdeSportTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSportTypeId">كود نوع اللعبة الرياضة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeSportTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeSportType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeSportTypeKey key, int start, int pageLength)
		{
			return GetByGsCdeSportTypeId(transactionManager, key.GsCdeSportTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_SPORT_TYPE index.
		/// </summary>
		/// <param name="_gsCdeSportTypeId">كود نوع اللعبة الرياضة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSportType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSportType GetByGsCdeSportTypeId(System.Decimal _gsCdeSportTypeId)
		{
			int count = -1;
			return GetByGsCdeSportTypeId(null,_gsCdeSportTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_SPORT_TYPE index.
		/// </summary>
		/// <param name="_gsCdeSportTypeId">كود نوع اللعبة الرياضة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSportType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSportType GetByGsCdeSportTypeId(System.Decimal _gsCdeSportTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeSportTypeId(null, _gsCdeSportTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_SPORT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSportTypeId">كود نوع اللعبة الرياضة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSportType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSportType GetByGsCdeSportTypeId(TransactionManager transactionManager, System.Decimal _gsCdeSportTypeId)
		{
			int count = -1;
			return GetByGsCdeSportTypeId(transactionManager, _gsCdeSportTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_SPORT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSportTypeId">كود نوع اللعبة الرياضة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSportType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSportType GetByGsCdeSportTypeId(TransactionManager transactionManager, System.Decimal _gsCdeSportTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeSportTypeId(transactionManager, _gsCdeSportTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_SPORT_TYPE index.
		/// </summary>
		/// <param name="_gsCdeSportTypeId">كود نوع اللعبة الرياضة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSportType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSportType GetByGsCdeSportTypeId(System.Decimal _gsCdeSportTypeId, int start, int pageLength, out int count)
		{
			return GetByGsCdeSportTypeId(null, _gsCdeSportTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_SPORT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSportTypeId">كود نوع اللعبة الرياضة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSportType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeSportType GetByGsCdeSportTypeId(TransactionManager transactionManager, System.Decimal _gsCdeSportTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_CDE_SPORT_TYPE index.
		/// </summary>
		/// <param name="_sportTypeAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSportType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSportType GetBySportTypeAr(System.String _sportTypeAr)
		{
			int count = -1;
			return GetBySportTypeAr(null,_sportTypeAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_SPORT_TYPE index.
		/// </summary>
		/// <param name="_sportTypeAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSportType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSportType GetBySportTypeAr(System.String _sportTypeAr, int start, int pageLength)
		{
			int count = -1;
			return GetBySportTypeAr(null, _sportTypeAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_SPORT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sportTypeAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSportType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSportType GetBySportTypeAr(TransactionManager transactionManager, System.String _sportTypeAr)
		{
			int count = -1;
			return GetBySportTypeAr(transactionManager, _sportTypeAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_SPORT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sportTypeAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSportType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSportType GetBySportTypeAr(TransactionManager transactionManager, System.String _sportTypeAr, int start, int pageLength)
		{
			int count = -1;
			return GetBySportTypeAr(transactionManager, _sportTypeAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_SPORT_TYPE index.
		/// </summary>
		/// <param name="_sportTypeAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSportType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSportType GetBySportTypeAr(System.String _sportTypeAr, int start, int pageLength, out int count)
		{
			return GetBySportTypeAr(null, _sportTypeAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_SPORT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sportTypeAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSportType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeSportType GetBySportTypeAr(TransactionManager transactionManager, System.String _sportTypeAr, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeSportType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeSportType&gt;"/></returns>
		public static TList<GsCdeSportType> Fill(IDataReader reader, TList<GsCdeSportType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeSportType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeSportType")
					.Append("|").Append((System.Decimal)reader["GS_CDE_SPORT_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeSportType>(
					key.ToString(), // EntityTrackingKey
					"GsCdeSportType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeSportType();
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
					c.GsCdeSportTypeId = (System.Decimal)reader["GS_CDE_SPORT_TYPE_ID"];
					c.OriginalGsCdeSportTypeId = c.GsCdeSportTypeId;
					c.SportTypeAr = (System.String)reader["SPORT_TYPE_AR"];
					c.SportTypeEn = Convert.IsDBNull(reader["SPORT_TYPE_EN"]) ? null : (System.String)reader["SPORT_TYPE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeSportType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeSportType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeSportType entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeSportTypeId = (System.Decimal)reader[((int)GsCdeSportTypeColumn.GsCdeSportTypeId - 1)];
			entity.OriginalGsCdeSportTypeId = (System.Decimal)reader["GS_CDE_SPORT_TYPE_ID"];
			entity.SportTypeAr = (System.String)reader[((int)GsCdeSportTypeColumn.SportTypeAr - 1)];
			entity.SportTypeEn = (reader.IsDBNull(((int)GsCdeSportTypeColumn.SportTypeEn - 1)))?null:(System.String)reader[((int)GsCdeSportTypeColumn.SportTypeEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeSportType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeSportType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeSportType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeSportTypeId = (System.Decimal)dataRow["GS_CDE_SPORT_TYPE_ID"];
			entity.OriginalGsCdeSportTypeId = (System.Decimal)dataRow["GS_CDE_SPORT_TYPE_ID"];
			entity.SportTypeAr = (System.String)dataRow["SPORT_TYPE_AR"];
			entity.SportTypeEn = Convert.IsDBNull(dataRow["SPORT_TYPE_EN"]) ? null : (System.String)dataRow["SPORT_TYPE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeSportType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeSportType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeSportType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdeSportTypeId methods when available
			
			#region EdStudSportCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSport>|EdStudSportCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSportCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSportCollection = DataRepository.EdStudSportProvider.GetByGsCdeSportTypeId(transactionManager, entity.GsCdeSportTypeId);

				if (deep && entity.EdStudSportCollection.Count > 0)
				{
					deepHandles.Add("EdStudSportCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSport>) DataRepository.EdStudSportProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSportCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeSportType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeSportType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeSportType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeSportType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudSport>
				if (CanDeepSave(entity.EdStudSportCollection, "List<EdStudSport>|EdStudSportCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSport child in entity.EdStudSportCollection)
					{
						if(child.GsCdeSportTypeIdSource != null)
						{
							child.GsCdeSportTypeId = child.GsCdeSportTypeIdSource.GsCdeSportTypeId;
						}
						else
						{
							child.GsCdeSportTypeId = entity.GsCdeSportTypeId;
						}

					}

					if (entity.EdStudSportCollection.Count > 0 || entity.EdStudSportCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSportProvider.Save(transactionManager, entity.EdStudSportCollection);
						
						deepHandles.Add("EdStudSportCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSport >) DataRepository.EdStudSportProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSportCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCdeSportTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeSportType</c>
	///</summary>
	public enum GsCdeSportTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCdeSportType</c> as OneToMany for EdStudSportCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSport>))]
		EdStudSportCollection,
	}
	
	#endregion GsCdeSportTypeChildEntityTypes
	
	#region GsCdeSportTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeSportTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeSportType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeSportTypeFilterBuilder : SqlFilterBuilder<GsCdeSportTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeSportTypeFilterBuilder class.
		/// </summary>
		public GsCdeSportTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeSportTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeSportTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeSportTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeSportTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeSportTypeFilterBuilder
	
	#region GsCdeSportTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeSportTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeSportType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeSportTypeParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeSportTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeSportTypeParameterBuilder class.
		/// </summary>
		public GsCdeSportTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeSportTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeSportTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeSportTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeSportTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeSportTypeParameterBuilder
	
	#region GsCdeSportTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeSportTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeSportType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeSportTypeSortBuilder : SqlSortBuilder<GsCdeSportTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeSportTypeSqlSortBuilder class.
		/// </summary>
		public GsCdeSportTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeSportTypeSortBuilder
	
} // end namespace
