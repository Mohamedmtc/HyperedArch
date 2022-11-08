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
	/// This class is the base class for any <see cref="SaCodeServTerminRsnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeServTerminRsnProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeServTerminRsn, UMIS_VER2.BusinessLyer.SaCodeServTerminRsnKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeServTerminRsnKey key)
		{
			return Delete(transactionManager, key.SaCodeServTerminRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeServTerminRsnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeServTerminRsnId)
		{
			return Delete(null, _saCodeServTerminRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeServTerminRsnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeServTerminRsnId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeServTerminRsn Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeServTerminRsnKey key, int start, int pageLength)
		{
			return GetBySaCodeServTerminRsnId(transactionManager, key.SaCodeServTerminRsnId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_SERV_TERMIN_RSN index.
		/// </summary>
		/// <param name="_saCodeServTerminRsnId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeServTerminRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeServTerminRsn GetBySaCodeServTerminRsnId(System.Decimal _saCodeServTerminRsnId)
		{
			int count = -1;
			return GetBySaCodeServTerminRsnId(null,_saCodeServTerminRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SERV_TERMIN_RSN index.
		/// </summary>
		/// <param name="_saCodeServTerminRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeServTerminRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeServTerminRsn GetBySaCodeServTerminRsnId(System.Decimal _saCodeServTerminRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeServTerminRsnId(null, _saCodeServTerminRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SERV_TERMIN_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeServTerminRsnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeServTerminRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeServTerminRsn GetBySaCodeServTerminRsnId(TransactionManager transactionManager, System.Decimal _saCodeServTerminRsnId)
		{
			int count = -1;
			return GetBySaCodeServTerminRsnId(transactionManager, _saCodeServTerminRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SERV_TERMIN_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeServTerminRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeServTerminRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeServTerminRsn GetBySaCodeServTerminRsnId(TransactionManager transactionManager, System.Decimal _saCodeServTerminRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeServTerminRsnId(transactionManager, _saCodeServTerminRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SERV_TERMIN_RSN index.
		/// </summary>
		/// <param name="_saCodeServTerminRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeServTerminRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeServTerminRsn GetBySaCodeServTerminRsnId(System.Decimal _saCodeServTerminRsnId, int start, int pageLength, out int count)
		{
			return GetBySaCodeServTerminRsnId(null, _saCodeServTerminRsnId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SERV_TERMIN_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeServTerminRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeServTerminRsn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeServTerminRsn GetBySaCodeServTerminRsnId(TransactionManager transactionManager, System.Decimal _saCodeServTerminRsnId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeServTerminRsn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeServTerminRsn&gt;"/></returns>
		public static TList<SaCodeServTerminRsn> Fill(IDataReader reader, TList<SaCodeServTerminRsn> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeServTerminRsn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeServTerminRsn")
					.Append("|").Append((System.Decimal)reader["SA_CODE_SERV_TERMIN_RSN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeServTerminRsn>(
					key.ToString(), // EntityTrackingKey
					"SaCodeServTerminRsn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeServTerminRsn();
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
					c.SaCodeServTerminRsnId = (System.Decimal)reader["SA_CODE_SERV_TERMIN_RSN_ID"];
					c.OriginalSaCodeServTerminRsnId = c.SaCodeServTerminRsnId;
					c.ServTerminReasonCode = Convert.IsDBNull(reader["SERV_TERMIN_REASON_CODE"]) ? null : (System.String)reader["SERV_TERMIN_REASON_CODE"];
					c.ServTerminReasonDescrAr = (System.String)reader["SERV_TERMIN_REASON_DESCR_AR"];
					c.ServTerminReasonDescrEn = Convert.IsDBNull(reader["SERV_TERMIN_REASON_DESCR_EN"]) ? null : (System.String)reader["SERV_TERMIN_REASON_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeServTerminRsn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeServTerminRsn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeServTerminRsn entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeServTerminRsnId = (System.Decimal)reader[((int)SaCodeServTerminRsnColumn.SaCodeServTerminRsnId - 1)];
			entity.OriginalSaCodeServTerminRsnId = (System.Decimal)reader["SA_CODE_SERV_TERMIN_RSN_ID"];
			entity.ServTerminReasonCode = (reader.IsDBNull(((int)SaCodeServTerminRsnColumn.ServTerminReasonCode - 1)))?null:(System.String)reader[((int)SaCodeServTerminRsnColumn.ServTerminReasonCode - 1)];
			entity.ServTerminReasonDescrAr = (System.String)reader[((int)SaCodeServTerminRsnColumn.ServTerminReasonDescrAr - 1)];
			entity.ServTerminReasonDescrEn = (reader.IsDBNull(((int)SaCodeServTerminRsnColumn.ServTerminReasonDescrEn - 1)))?null:(System.String)reader[((int)SaCodeServTerminRsnColumn.ServTerminReasonDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeServTerminRsn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeServTerminRsn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeServTerminRsn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeServTerminRsnId = (System.Decimal)dataRow["SA_CODE_SERV_TERMIN_RSN_ID"];
			entity.OriginalSaCodeServTerminRsnId = (System.Decimal)dataRow["SA_CODE_SERV_TERMIN_RSN_ID"];
			entity.ServTerminReasonCode = Convert.IsDBNull(dataRow["SERV_TERMIN_REASON_CODE"]) ? null : (System.String)dataRow["SERV_TERMIN_REASON_CODE"];
			entity.ServTerminReasonDescrAr = (System.String)dataRow["SERV_TERMIN_REASON_DESCR_AR"];
			entity.ServTerminReasonDescrEn = Convert.IsDBNull(dataRow["SERV_TERMIN_REASON_DESCR_EN"]) ? null : (System.String)dataRow["SERV_TERMIN_REASON_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeServTerminRsn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeServTerminRsn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeServTerminRsn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeServTerminRsnId methods when available
			
			#region SaServTerminCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaServTermin>|SaServTerminCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaServTerminCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaServTerminCollection = DataRepository.SaServTerminProvider.GetBySaCodeServTerminRsnId(transactionManager, entity.SaCodeServTerminRsnId);

				if (deep && entity.SaServTerminCollection.Count > 0)
				{
					deepHandles.Add("SaServTerminCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaServTermin>) DataRepository.SaServTerminProvider.DeepLoad,
						new object[] { transactionManager, entity.SaServTerminCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeServTerminRsn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeServTerminRsn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeServTerminRsn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeServTerminRsn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaServTermin>
				if (CanDeepSave(entity.SaServTerminCollection, "List<SaServTermin>|SaServTerminCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaServTermin child in entity.SaServTerminCollection)
					{
						if(child.SaCodeServTerminRsnIdSource != null)
						{
							child.SaCodeServTerminRsnId = child.SaCodeServTerminRsnIdSource.SaCodeServTerminRsnId;
						}
						else
						{
							child.SaCodeServTerminRsnId = entity.SaCodeServTerminRsnId;
						}

					}

					if (entity.SaServTerminCollection.Count > 0 || entity.SaServTerminCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaServTerminProvider.Save(transactionManager, entity.SaServTerminCollection);
						
						deepHandles.Add("SaServTerminCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaServTermin >) DataRepository.SaServTerminProvider.DeepSave,
							new object[] { transactionManager, entity.SaServTerminCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodeServTerminRsnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeServTerminRsn</c>
	///</summary>
	public enum SaCodeServTerminRsnChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCodeServTerminRsn</c> as OneToMany for SaServTerminCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaServTermin>))]
		SaServTerminCollection,
	}
	
	#endregion SaCodeServTerminRsnChildEntityTypes
	
	#region SaCodeServTerminRsnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeServTerminRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeServTerminRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeServTerminRsnFilterBuilder : SqlFilterBuilder<SaCodeServTerminRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeServTerminRsnFilterBuilder class.
		/// </summary>
		public SaCodeServTerminRsnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeServTerminRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeServTerminRsnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeServTerminRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeServTerminRsnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeServTerminRsnFilterBuilder
	
	#region SaCodeServTerminRsnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeServTerminRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeServTerminRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeServTerminRsnParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeServTerminRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeServTerminRsnParameterBuilder class.
		/// </summary>
		public SaCodeServTerminRsnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeServTerminRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeServTerminRsnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeServTerminRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeServTerminRsnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeServTerminRsnParameterBuilder
	
	#region SaCodeServTerminRsnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeServTerminRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeServTerminRsn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeServTerminRsnSortBuilder : SqlSortBuilder<SaCodeServTerminRsnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeServTerminRsnSqlSortBuilder class.
		/// </summary>
		public SaCodeServTerminRsnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeServTerminRsnSortBuilder
	
} // end namespace
