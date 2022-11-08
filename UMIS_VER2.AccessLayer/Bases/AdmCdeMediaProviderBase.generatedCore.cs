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
	/// This class is the base class for any <see cref="AdmCdeMediaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmCdeMediaProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmCdeMedia, UMIS_VER2.BusinessLyer.AdmCdeMediaKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeMediaKey key)
		{
			return Delete(transactionManager, key.AdmCdeMediaId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admCdeMediaId">طريقة التعرف على الجامعة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _admCdeMediaId)
		{
			return Delete(null, _admCdeMediaId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeMediaId">طريقة التعرف على الجامعة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _admCdeMediaId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmCdeMedia Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeMediaKey key, int start, int pageLength)
		{
			return GetByAdmCdeMediaId(transactionManager, key.AdmCdeMediaId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_CDE_MEDIA index.
		/// </summary>
		/// <param name="_admCdeMediaId">طريقة التعرف على الجامعة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeMedia"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeMedia GetByAdmCdeMediaId(System.Int32 _admCdeMediaId)
		{
			int count = -1;
			return GetByAdmCdeMediaId(null,_admCdeMediaId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_MEDIA index.
		/// </summary>
		/// <param name="_admCdeMediaId">طريقة التعرف على الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeMedia"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeMedia GetByAdmCdeMediaId(System.Int32 _admCdeMediaId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeMediaId(null, _admCdeMediaId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_MEDIA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeMediaId">طريقة التعرف على الجامعة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeMedia"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeMedia GetByAdmCdeMediaId(TransactionManager transactionManager, System.Int32 _admCdeMediaId)
		{
			int count = -1;
			return GetByAdmCdeMediaId(transactionManager, _admCdeMediaId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_MEDIA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeMediaId">طريقة التعرف على الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeMedia"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeMedia GetByAdmCdeMediaId(TransactionManager transactionManager, System.Int32 _admCdeMediaId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeMediaId(transactionManager, _admCdeMediaId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_MEDIA index.
		/// </summary>
		/// <param name="_admCdeMediaId">طريقة التعرف على الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeMedia"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeMedia GetByAdmCdeMediaId(System.Int32 _admCdeMediaId, int start, int pageLength, out int count)
		{
			return GetByAdmCdeMediaId(null, _admCdeMediaId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_MEDIA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeMediaId">طريقة التعرف على الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeMedia"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCdeMedia GetByAdmCdeMediaId(TransactionManager transactionManager, System.Int32 _admCdeMediaId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmCdeMedia&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmCdeMedia&gt;"/></returns>
		public static TList<AdmCdeMedia> Fill(IDataReader reader, TList<AdmCdeMedia> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmCdeMedia c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmCdeMedia")
					.Append("|").Append((System.Int32)reader["ADM_CDE_MEDIA_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmCdeMedia>(
					key.ToString(), // EntityTrackingKey
					"AdmCdeMedia",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmCdeMedia();
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
					c.AdmCdeMediaId = (System.Int32)reader["ADM_CDE_MEDIA_ID"];
					c.OriginalAdmCdeMediaId = c.AdmCdeMediaId;
					c.MediaAr = Convert.IsDBNull(reader["MEDIA_AR"]) ? null : (System.String)reader["MEDIA_AR"];
					c.MediaEn = Convert.IsDBNull(reader["MEDIA_EN"]) ? null : (System.String)reader["MEDIA_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeMedia"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeMedia"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmCdeMedia entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmCdeMediaId = (System.Int32)reader[((int)AdmCdeMediaColumn.AdmCdeMediaId - 1)];
			entity.OriginalAdmCdeMediaId = (System.Int32)reader["ADM_CDE_MEDIA_ID"];
			entity.MediaAr = (reader.IsDBNull(((int)AdmCdeMediaColumn.MediaAr - 1)))?null:(System.String)reader[((int)AdmCdeMediaColumn.MediaAr - 1)];
			entity.MediaEn = (reader.IsDBNull(((int)AdmCdeMediaColumn.MediaEn - 1)))?null:(System.String)reader[((int)AdmCdeMediaColumn.MediaEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeMedia"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeMedia"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmCdeMedia entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmCdeMediaId = (System.Int32)dataRow["ADM_CDE_MEDIA_ID"];
			entity.OriginalAdmCdeMediaId = (System.Int32)dataRow["ADM_CDE_MEDIA_ID"];
			entity.MediaAr = Convert.IsDBNull(dataRow["MEDIA_AR"]) ? null : (System.String)dataRow["MEDIA_AR"];
			entity.MediaEn = Convert.IsDBNull(dataRow["MEDIA_EN"]) ? null : (System.String)dataRow["MEDIA_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeMedia"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeMedia Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeMedia entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmCdeMediaId methods when available
			
			#region AdmAppMediaCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppMedia>|AdmAppMediaCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppMediaCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppMediaCollection = DataRepository.AdmAppMediaProvider.GetByAdmCdeMediaId(transactionManager, entity.AdmCdeMediaId);

				if (deep && entity.AdmAppMediaCollection.Count > 0)
				{
					deepHandles.Add("AdmAppMediaCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppMedia>) DataRepository.AdmAppMediaProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppMediaCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmCdeMedia object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmCdeMedia instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeMedia Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeMedia entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AdmAppMedia>
				if (CanDeepSave(entity.AdmAppMediaCollection, "List<AdmAppMedia>|AdmAppMediaCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppMedia child in entity.AdmAppMediaCollection)
					{
						if(child.AdmCdeMediaIdSource != null)
						{
							child.AdmCdeMediaId = child.AdmCdeMediaIdSource.AdmCdeMediaId;
						}
						else
						{
							child.AdmCdeMediaId = entity.AdmCdeMediaId;
						}

					}

					if (entity.AdmAppMediaCollection.Count > 0 || entity.AdmAppMediaCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppMediaProvider.Save(transactionManager, entity.AdmAppMediaCollection);
						
						deepHandles.Add("AdmAppMediaCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppMedia >) DataRepository.AdmAppMediaProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppMediaCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmCdeMediaChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmCdeMedia</c>
	///</summary>
	public enum AdmCdeMediaChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AdmCdeMedia</c> as OneToMany for AdmAppMediaCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppMedia>))]
		AdmAppMediaCollection,
	}
	
	#endregion AdmCdeMediaChildEntityTypes
	
	#region AdmCdeMediaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmCdeMediaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeMedia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeMediaFilterBuilder : SqlFilterBuilder<AdmCdeMediaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeMediaFilterBuilder class.
		/// </summary>
		public AdmCdeMediaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeMediaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeMediaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeMediaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeMediaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeMediaFilterBuilder
	
	#region AdmCdeMediaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmCdeMediaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeMedia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeMediaParameterBuilder : ParameterizedSqlFilterBuilder<AdmCdeMediaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeMediaParameterBuilder class.
		/// </summary>
		public AdmCdeMediaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeMediaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeMediaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeMediaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeMediaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeMediaParameterBuilder
	
	#region AdmCdeMediaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmCdeMediaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeMedia"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmCdeMediaSortBuilder : SqlSortBuilder<AdmCdeMediaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeMediaSqlSortBuilder class.
		/// </summary>
		public AdmCdeMediaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmCdeMediaSortBuilder
	
} // end namespace
