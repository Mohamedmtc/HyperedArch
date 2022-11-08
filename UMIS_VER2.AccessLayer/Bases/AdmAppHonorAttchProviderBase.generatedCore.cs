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
	/// This class is the base class for any <see cref="AdmAppHonorAttchProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppHonorAttchProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppHonorAttch, UMIS_VER2.BusinessLyer.AdmAppHonorAttchKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppHonorAttchKey key)
		{
			return Delete(transactionManager, key.AdmAppHonorAttchId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppHonorAttchId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppHonorAttchId)
		{
			return Delete(null, _admAppHonorAttchId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppHonorAttchId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppHonorAttchId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_HONOR_ATTCH_ADM_APP_HONOR key.
		///		FK_ADM_APP_HONOR_ATTCH_ADM_APP_HONOR Description: 
		/// </summary>
		/// <param name="_admAppHonorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppHonorAttch objects.</returns>
		public TList<AdmAppHonorAttch> GetByAdmAppHonorId(System.Decimal _admAppHonorId)
		{
			int count = -1;
			return GetByAdmAppHonorId(_admAppHonorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_HONOR_ATTCH_ADM_APP_HONOR key.
		///		FK_ADM_APP_HONOR_ATTCH_ADM_APP_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppHonorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppHonorAttch objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppHonorAttch> GetByAdmAppHonorId(TransactionManager transactionManager, System.Decimal _admAppHonorId)
		{
			int count = -1;
			return GetByAdmAppHonorId(transactionManager, _admAppHonorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_HONOR_ATTCH_ADM_APP_HONOR key.
		///		FK_ADM_APP_HONOR_ATTCH_ADM_APP_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppHonorAttch objects.</returns>
		public TList<AdmAppHonorAttch> GetByAdmAppHonorId(TransactionManager transactionManager, System.Decimal _admAppHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppHonorId(transactionManager, _admAppHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_HONOR_ATTCH_ADM_APP_HONOR key.
		///		fkAdmAppHonorAttchAdmAppHonor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppHonorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppHonorAttch objects.</returns>
		public TList<AdmAppHonorAttch> GetByAdmAppHonorId(System.Decimal _admAppHonorId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppHonorId(null, _admAppHonorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_HONOR_ATTCH_ADM_APP_HONOR key.
		///		fkAdmAppHonorAttchAdmAppHonor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppHonorId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppHonorAttch objects.</returns>
		public TList<AdmAppHonorAttch> GetByAdmAppHonorId(System.Decimal _admAppHonorId, int start, int pageLength,out int count)
		{
			return GetByAdmAppHonorId(null, _admAppHonorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_HONOR_ATTCH_ADM_APP_HONOR key.
		///		FK_ADM_APP_HONOR_ATTCH_ADM_APP_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppHonorAttch objects.</returns>
		public abstract TList<AdmAppHonorAttch> GetByAdmAppHonorId(TransactionManager transactionManager, System.Decimal _admAppHonorId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppHonorAttch Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppHonorAttchKey key, int start, int pageLength)
		{
			return GetByAdmAppHonorAttchId(transactionManager, key.AdmAppHonorAttchId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_HONOR_ATTCH index.
		/// </summary>
		/// <param name="_admAppHonorAttchId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppHonorAttch"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppHonorAttch GetByAdmAppHonorAttchId(System.Decimal _admAppHonorAttchId)
		{
			int count = -1;
			return GetByAdmAppHonorAttchId(null,_admAppHonorAttchId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_HONOR_ATTCH index.
		/// </summary>
		/// <param name="_admAppHonorAttchId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppHonorAttch"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppHonorAttch GetByAdmAppHonorAttchId(System.Decimal _admAppHonorAttchId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppHonorAttchId(null, _admAppHonorAttchId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_HONOR_ATTCH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppHonorAttchId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppHonorAttch"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppHonorAttch GetByAdmAppHonorAttchId(TransactionManager transactionManager, System.Decimal _admAppHonorAttchId)
		{
			int count = -1;
			return GetByAdmAppHonorAttchId(transactionManager, _admAppHonorAttchId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_HONOR_ATTCH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppHonorAttchId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppHonorAttch"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppHonorAttch GetByAdmAppHonorAttchId(TransactionManager transactionManager, System.Decimal _admAppHonorAttchId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppHonorAttchId(transactionManager, _admAppHonorAttchId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_HONOR_ATTCH index.
		/// </summary>
		/// <param name="_admAppHonorAttchId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppHonorAttch"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppHonorAttch GetByAdmAppHonorAttchId(System.Decimal _admAppHonorAttchId, int start, int pageLength, out int count)
		{
			return GetByAdmAppHonorAttchId(null, _admAppHonorAttchId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_HONOR_ATTCH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppHonorAttchId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppHonorAttch"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppHonorAttch GetByAdmAppHonorAttchId(TransactionManager transactionManager, System.Decimal _admAppHonorAttchId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppHonorAttch&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppHonorAttch&gt;"/></returns>
		public static TList<AdmAppHonorAttch> Fill(IDataReader reader, TList<AdmAppHonorAttch> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppHonorAttch c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppHonorAttch")
					.Append("|").Append((System.Decimal)reader["ADM_APP_HONOR_ATTCH_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppHonorAttch>(
					key.ToString(), // EntityTrackingKey
					"AdmAppHonorAttch",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppHonorAttch();
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
					c.AdmAppHonorAttchId = (System.Decimal)reader["ADM_APP_HONOR_ATTCH_ID"];
					c.OriginalAdmAppHonorAttchId = c.AdmAppHonorAttchId;
					c.AdmAppHonorId = (System.Decimal)reader["ADM_APP_HONOR_ID"];
					c.AttchDocPath = (System.String)reader["ATTCH_DOC_PATH"];
					c.DocNotes = Convert.IsDBNull(reader["DOC_NOTES"]) ? null : (System.String)reader["DOC_NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppHonorAttch"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppHonorAttch"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppHonorAttch entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppHonorAttchId = (System.Decimal)reader[((int)AdmAppHonorAttchColumn.AdmAppHonorAttchId - 1)];
			entity.OriginalAdmAppHonorAttchId = (System.Decimal)reader["ADM_APP_HONOR_ATTCH_ID"];
			entity.AdmAppHonorId = (System.Decimal)reader[((int)AdmAppHonorAttchColumn.AdmAppHonorId - 1)];
			entity.AttchDocPath = (System.String)reader[((int)AdmAppHonorAttchColumn.AttchDocPath - 1)];
			entity.DocNotes = (reader.IsDBNull(((int)AdmAppHonorAttchColumn.DocNotes - 1)))?null:(System.String)reader[((int)AdmAppHonorAttchColumn.DocNotes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppHonorAttch"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppHonorAttch"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppHonorAttch entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppHonorAttchId = (System.Decimal)dataRow["ADM_APP_HONOR_ATTCH_ID"];
			entity.OriginalAdmAppHonorAttchId = (System.Decimal)dataRow["ADM_APP_HONOR_ATTCH_ID"];
			entity.AdmAppHonorId = (System.Decimal)dataRow["ADM_APP_HONOR_ID"];
			entity.AttchDocPath = (System.String)dataRow["ATTCH_DOC_PATH"];
			entity.DocNotes = Convert.IsDBNull(dataRow["DOC_NOTES"]) ? null : (System.String)dataRow["DOC_NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppHonorAttch"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppHonorAttch Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppHonorAttch entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppHonorIdSource	
			if (CanDeepLoad(entity, "AdmAppHonor|AdmAppHonorIdSource", deepLoadType, innerList) 
				&& entity.AdmAppHonorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmAppHonorId;
				AdmAppHonor tmpEntity = EntityManager.LocateEntity<AdmAppHonor>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppHonor), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppHonorIdSource = tmpEntity;
				else
					entity.AdmAppHonorIdSource = DataRepository.AdmAppHonorProvider.GetByAdmAppHonorId(transactionManager, entity.AdmAppHonorId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppHonorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppHonorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppHonorProvider.DeepLoad(transactionManager, entity.AdmAppHonorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppHonorIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppHonorAttch object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppHonorAttch instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppHonorAttch Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppHonorAttch entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAppHonorIdSource
			if (CanDeepSave(entity, "AdmAppHonor|AdmAppHonorIdSource", deepSaveType, innerList) 
				&& entity.AdmAppHonorIdSource != null)
			{
				DataRepository.AdmAppHonorProvider.Save(transactionManager, entity.AdmAppHonorIdSource);
				entity.AdmAppHonorId = entity.AdmAppHonorIdSource.AdmAppHonorId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
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
	
	#region AdmAppHonorAttchChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppHonorAttch</c>
	///</summary>
	public enum AdmAppHonorAttchChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppHonor</c> at AdmAppHonorIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppHonor))]
		AdmAppHonor,
	}
	
	#endregion AdmAppHonorAttchChildEntityTypes
	
	#region AdmAppHonorAttchFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppHonorAttchColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppHonorAttch"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppHonorAttchFilterBuilder : SqlFilterBuilder<AdmAppHonorAttchColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppHonorAttchFilterBuilder class.
		/// </summary>
		public AdmAppHonorAttchFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppHonorAttchFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppHonorAttchFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppHonorAttchFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppHonorAttchFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppHonorAttchFilterBuilder
	
	#region AdmAppHonorAttchParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppHonorAttchColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppHonorAttch"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppHonorAttchParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppHonorAttchColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppHonorAttchParameterBuilder class.
		/// </summary>
		public AdmAppHonorAttchParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppHonorAttchParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppHonorAttchParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppHonorAttchParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppHonorAttchParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppHonorAttchParameterBuilder
	
	#region AdmAppHonorAttchSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppHonorAttchColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppHonorAttch"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppHonorAttchSortBuilder : SqlSortBuilder<AdmAppHonorAttchColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppHonorAttchSqlSortBuilder class.
		/// </summary>
		public AdmAppHonorAttchSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppHonorAttchSortBuilder
	
} // end namespace
