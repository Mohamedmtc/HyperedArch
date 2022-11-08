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
	/// This class is the base class for any <see cref="SaCodeJobActivityPlaceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeJobActivityPlaceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace, UMIS_VER2.BusinessLyer.SaCodeJobActivityPlaceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeJobActivityPlaceKey key)
		{
			return Delete(transactionManager, key.SaCodeJobActivityPlaceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeJobActivityPlaceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeJobActivityPlaceId)
		{
			return Delete(null, _saCodeJobActivityPlaceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobActivityPlaceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeJobActivityPlaceId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeJobActivityPlaceKey key, int start, int pageLength)
		{
			return GetBySaCodeJobActivityPlaceId(transactionManager, key.SaCodeJobActivityPlaceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SA_JOB_ACT_PLACE2 index.
		/// </summary>
		/// <param name="_placeDescrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace GetByPlaceDescrAr(System.String _placeDescrAr)
		{
			int count = -1;
			return GetByPlaceDescrAr(null,_placeDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_JOB_ACT_PLACE2 index.
		/// </summary>
		/// <param name="_placeDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace GetByPlaceDescrAr(System.String _placeDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByPlaceDescrAr(null, _placeDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_JOB_ACT_PLACE2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_placeDescrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace GetByPlaceDescrAr(TransactionManager transactionManager, System.String _placeDescrAr)
		{
			int count = -1;
			return GetByPlaceDescrAr(transactionManager, _placeDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_JOB_ACT_PLACE2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_placeDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace GetByPlaceDescrAr(TransactionManager transactionManager, System.String _placeDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByPlaceDescrAr(transactionManager, _placeDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_JOB_ACT_PLACE2 index.
		/// </summary>
		/// <param name="_placeDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace GetByPlaceDescrAr(System.String _placeDescrAr, int start, int pageLength, out int count)
		{
			return GetByPlaceDescrAr(null, _placeDescrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_JOB_ACT_PLACE2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_placeDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace GetByPlaceDescrAr(TransactionManager transactionManager, System.String _placeDescrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_JOB_ACTIVITY_PLACE index.
		/// </summary>
		/// <param name="_saCodeJobActivityPlaceId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace GetBySaCodeJobActivityPlaceId(System.Decimal _saCodeJobActivityPlaceId)
		{
			int count = -1;
			return GetBySaCodeJobActivityPlaceId(null,_saCodeJobActivityPlaceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_ACTIVITY_PLACE index.
		/// </summary>
		/// <param name="_saCodeJobActivityPlaceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace GetBySaCodeJobActivityPlaceId(System.Decimal _saCodeJobActivityPlaceId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeJobActivityPlaceId(null, _saCodeJobActivityPlaceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_ACTIVITY_PLACE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobActivityPlaceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace GetBySaCodeJobActivityPlaceId(TransactionManager transactionManager, System.Decimal _saCodeJobActivityPlaceId)
		{
			int count = -1;
			return GetBySaCodeJobActivityPlaceId(transactionManager, _saCodeJobActivityPlaceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_ACTIVITY_PLACE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobActivityPlaceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace GetBySaCodeJobActivityPlaceId(TransactionManager transactionManager, System.Decimal _saCodeJobActivityPlaceId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeJobActivityPlaceId(transactionManager, _saCodeJobActivityPlaceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_ACTIVITY_PLACE index.
		/// </summary>
		/// <param name="_saCodeJobActivityPlaceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace GetBySaCodeJobActivityPlaceId(System.Decimal _saCodeJobActivityPlaceId, int start, int pageLength, out int count)
		{
			return GetBySaCodeJobActivityPlaceId(null, _saCodeJobActivityPlaceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_ACTIVITY_PLACE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobActivityPlaceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace GetBySaCodeJobActivityPlaceId(TransactionManager transactionManager, System.Decimal _saCodeJobActivityPlaceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeJobActivityPlace&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeJobActivityPlace&gt;"/></returns>
		public static TList<SaCodeJobActivityPlace> Fill(IDataReader reader, TList<SaCodeJobActivityPlace> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeJobActivityPlace")
					.Append("|").Append((System.Decimal)reader["SA_CODE_JOB_ACTIVITY_PLACE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeJobActivityPlace>(
					key.ToString(), // EntityTrackingKey
					"SaCodeJobActivityPlace",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace();
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
					c.SaCodeJobActivityPlaceId = (System.Decimal)reader["SA_CODE_JOB_ACTIVITY_PLACE_ID"];
					c.OriginalSaCodeJobActivityPlaceId = c.SaCodeJobActivityPlaceId;
					c.PlaceCode = Convert.IsDBNull(reader["PLACE_CODE"]) ? null : (System.String)reader["PLACE_CODE"];
					c.PlaceDescrAr = (System.String)reader["PLACE_DESCR_AR"];
					c.PlaceDescrEn = Convert.IsDBNull(reader["PLACE_DESCR_EN"]) ? null : (System.String)reader["PLACE_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeJobActivityPlaceId = (System.Decimal)reader[((int)SaCodeJobActivityPlaceColumn.SaCodeJobActivityPlaceId - 1)];
			entity.OriginalSaCodeJobActivityPlaceId = (System.Decimal)reader["SA_CODE_JOB_ACTIVITY_PLACE_ID"];
			entity.PlaceCode = (reader.IsDBNull(((int)SaCodeJobActivityPlaceColumn.PlaceCode - 1)))?null:(System.String)reader[((int)SaCodeJobActivityPlaceColumn.PlaceCode - 1)];
			entity.PlaceDescrAr = (System.String)reader[((int)SaCodeJobActivityPlaceColumn.PlaceDescrAr - 1)];
			entity.PlaceDescrEn = (reader.IsDBNull(((int)SaCodeJobActivityPlaceColumn.PlaceDescrEn - 1)))?null:(System.String)reader[((int)SaCodeJobActivityPlaceColumn.PlaceDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeJobActivityPlaceId = (System.Decimal)dataRow["SA_CODE_JOB_ACTIVITY_PLACE_ID"];
			entity.OriginalSaCodeJobActivityPlaceId = (System.Decimal)dataRow["SA_CODE_JOB_ACTIVITY_PLACE_ID"];
			entity.PlaceCode = Convert.IsDBNull(dataRow["PLACE_CODE"]) ? null : (System.String)dataRow["PLACE_CODE"];
			entity.PlaceDescrAr = (System.String)dataRow["PLACE_DESCR_AR"];
			entity.PlaceDescrEn = Convert.IsDBNull(dataRow["PLACE_DESCR_EN"]) ? null : (System.String)dataRow["PLACE_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeJobActivityPlaceId methods when available
			
			#region SaJobActivityCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaJobActivity>|SaJobActivityCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaJobActivityCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaJobActivityCollection = DataRepository.SaJobActivityProvider.GetBySaCodeJobActivityPlaceId(transactionManager, entity.SaCodeJobActivityPlaceId);

				if (deep && entity.SaJobActivityCollection.Count > 0)
				{
					deepHandles.Add("SaJobActivityCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaJobActivity>) DataRepository.SaJobActivityProvider.DeepLoad,
						new object[] { transactionManager, entity.SaJobActivityCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaJobActivity>
				if (CanDeepSave(entity.SaJobActivityCollection, "List<SaJobActivity>|SaJobActivityCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaJobActivity child in entity.SaJobActivityCollection)
					{
						if(child.SaCodeJobActivityPlaceIdSource != null)
						{
							child.SaCodeJobActivityPlaceId = child.SaCodeJobActivityPlaceIdSource.SaCodeJobActivityPlaceId;
						}
						else
						{
							child.SaCodeJobActivityPlaceId = entity.SaCodeJobActivityPlaceId;
						}

					}

					if (entity.SaJobActivityCollection.Count > 0 || entity.SaJobActivityCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaJobActivityProvider.Save(transactionManager, entity.SaJobActivityCollection);
						
						deepHandles.Add("SaJobActivityCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaJobActivity >) DataRepository.SaJobActivityProvider.DeepSave,
							new object[] { transactionManager, entity.SaJobActivityCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodeJobActivityPlaceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeJobActivityPlace</c>
	///</summary>
	public enum SaCodeJobActivityPlaceChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCodeJobActivityPlace</c> as OneToMany for SaJobActivityCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaJobActivity>))]
		SaJobActivityCollection,
	}
	
	#endregion SaCodeJobActivityPlaceChildEntityTypes
	
	#region SaCodeJobActivityPlaceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeJobActivityPlaceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeJobActivityPlace"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeJobActivityPlaceFilterBuilder : SqlFilterBuilder<SaCodeJobActivityPlaceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeJobActivityPlaceFilterBuilder class.
		/// </summary>
		public SaCodeJobActivityPlaceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeJobActivityPlaceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeJobActivityPlaceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeJobActivityPlaceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeJobActivityPlaceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeJobActivityPlaceFilterBuilder
	
	#region SaCodeJobActivityPlaceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeJobActivityPlaceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeJobActivityPlace"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeJobActivityPlaceParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeJobActivityPlaceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeJobActivityPlaceParameterBuilder class.
		/// </summary>
		public SaCodeJobActivityPlaceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeJobActivityPlaceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeJobActivityPlaceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeJobActivityPlaceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeJobActivityPlaceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeJobActivityPlaceParameterBuilder
	
	#region SaCodeJobActivityPlaceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeJobActivityPlaceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeJobActivityPlace"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeJobActivityPlaceSortBuilder : SqlSortBuilder<SaCodeJobActivityPlaceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeJobActivityPlaceSqlSortBuilder class.
		/// </summary>
		public SaCodeJobActivityPlaceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeJobActivityPlaceSortBuilder
	
} // end namespace
