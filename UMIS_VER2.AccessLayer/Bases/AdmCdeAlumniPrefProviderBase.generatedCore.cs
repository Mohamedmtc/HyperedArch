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
	/// This class is the base class for any <see cref="AdmCdeAlumniPrefProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmCdeAlumniPrefProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmCdeAlumniPref, UMIS_VER2.BusinessLyer.AdmCdeAlumniPrefKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeAlumniPrefKey key)
		{
			return Delete(transactionManager, key.AdmCdeAlumniPrefId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admCdeAlumniPrefId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _admCdeAlumniPrefId)
		{
			return Delete(null, _admCdeAlumniPrefId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAlumniPrefId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _admCdeAlumniPrefId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmCdeAlumniPref Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeAlumniPrefKey key, int start, int pageLength)
		{
			return GetByAdmCdeAlumniPrefId(transactionManager, key.AdmCdeAlumniPrefId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_CDE_ALUMNI_PREF index.
		/// </summary>
		/// <param name="_admCdeAlumniPrefId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAlumniPref"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeAlumniPref GetByAdmCdeAlumniPrefId(System.Int32 _admCdeAlumniPrefId)
		{
			int count = -1;
			return GetByAdmCdeAlumniPrefId(null,_admCdeAlumniPrefId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_ALUMNI_PREF index.
		/// </summary>
		/// <param name="_admCdeAlumniPrefId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAlumniPref"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeAlumniPref GetByAdmCdeAlumniPrefId(System.Int32 _admCdeAlumniPrefId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeAlumniPrefId(null, _admCdeAlumniPrefId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_ALUMNI_PREF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAlumniPrefId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAlumniPref"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeAlumniPref GetByAdmCdeAlumniPrefId(TransactionManager transactionManager, System.Int32 _admCdeAlumniPrefId)
		{
			int count = -1;
			return GetByAdmCdeAlumniPrefId(transactionManager, _admCdeAlumniPrefId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_ALUMNI_PREF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAlumniPrefId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAlumniPref"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeAlumniPref GetByAdmCdeAlumniPrefId(TransactionManager transactionManager, System.Int32 _admCdeAlumniPrefId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeAlumniPrefId(transactionManager, _admCdeAlumniPrefId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_ALUMNI_PREF index.
		/// </summary>
		/// <param name="_admCdeAlumniPrefId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAlumniPref"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeAlumniPref GetByAdmCdeAlumniPrefId(System.Int32 _admCdeAlumniPrefId, int start, int pageLength, out int count)
		{
			return GetByAdmCdeAlumniPrefId(null, _admCdeAlumniPrefId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_ALUMNI_PREF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAlumniPrefId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAlumniPref"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCdeAlumniPref GetByAdmCdeAlumniPrefId(TransactionManager transactionManager, System.Int32 _admCdeAlumniPrefId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmCdeAlumniPref&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmCdeAlumniPref&gt;"/></returns>
		public static TList<AdmCdeAlumniPref> Fill(IDataReader reader, TList<AdmCdeAlumniPref> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmCdeAlumniPref c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmCdeAlumniPref")
					.Append("|").Append((System.Int32)reader["ADM_CDE_ALUMNI_PREF_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmCdeAlumniPref>(
					key.ToString(), // EntityTrackingKey
					"AdmCdeAlumniPref",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmCdeAlumniPref();
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
					c.AdmCdeAlumniPrefId = (System.Int32)reader["ADM_CDE_ALUMNI_PREF_ID"];
					c.OriginalAdmCdeAlumniPrefId = c.AdmCdeAlumniPrefId;
					c.AlumniPrefAr = Convert.IsDBNull(reader["ALUMNI_PREF_AR"]) ? null : (System.String)reader["ALUMNI_PREF_AR"];
					c.AlumniPrefEn = Convert.IsDBNull(reader["ALUMNI_PREF_EN"]) ? null : (System.String)reader["ALUMNI_PREF_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAlumniPref"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeAlumniPref"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmCdeAlumniPref entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmCdeAlumniPrefId = (System.Int32)reader[((int)AdmCdeAlumniPrefColumn.AdmCdeAlumniPrefId - 1)];
			entity.OriginalAdmCdeAlumniPrefId = (System.Int32)reader["ADM_CDE_ALUMNI_PREF_ID"];
			entity.AlumniPrefAr = (reader.IsDBNull(((int)AdmCdeAlumniPrefColumn.AlumniPrefAr - 1)))?null:(System.String)reader[((int)AdmCdeAlumniPrefColumn.AlumniPrefAr - 1)];
			entity.AlumniPrefEn = (reader.IsDBNull(((int)AdmCdeAlumniPrefColumn.AlumniPrefEn - 1)))?null:(System.String)reader[((int)AdmCdeAlumniPrefColumn.AlumniPrefEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAlumniPref"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeAlumniPref"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmCdeAlumniPref entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmCdeAlumniPrefId = (System.Int32)dataRow["ADM_CDE_ALUMNI_PREF_ID"];
			entity.OriginalAdmCdeAlumniPrefId = (System.Int32)dataRow["ADM_CDE_ALUMNI_PREF_ID"];
			entity.AlumniPrefAr = Convert.IsDBNull(dataRow["ALUMNI_PREF_AR"]) ? null : (System.String)dataRow["ALUMNI_PREF_AR"];
			entity.AlumniPrefEn = Convert.IsDBNull(dataRow["ALUMNI_PREF_EN"]) ? null : (System.String)dataRow["ALUMNI_PREF_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeAlumniPref"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeAlumniPref Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeAlumniPref entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmCdeAlumniPrefId methods when available
			
			#region AdmAppAlumniPrefCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppAlumniPref>|AdmAppAlumniPrefCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppAlumniPrefCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppAlumniPrefCollection = DataRepository.AdmAppAlumniPrefProvider.GetByAdmCdeAlumniPrefId(transactionManager, entity.AdmCdeAlumniPrefId);

				if (deep && entity.AdmAppAlumniPrefCollection.Count > 0)
				{
					deepHandles.Add("AdmAppAlumniPrefCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppAlumniPref>) DataRepository.AdmAppAlumniPrefProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppAlumniPrefCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmCdeAlumniPref object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmCdeAlumniPref instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeAlumniPref Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeAlumniPref entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AdmAppAlumniPref>
				if (CanDeepSave(entity.AdmAppAlumniPrefCollection, "List<AdmAppAlumniPref>|AdmAppAlumniPrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppAlumniPref child in entity.AdmAppAlumniPrefCollection)
					{
						if(child.AdmCdeAlumniPrefIdSource != null)
						{
							child.AdmCdeAlumniPrefId = child.AdmCdeAlumniPrefIdSource.AdmCdeAlumniPrefId;
						}
						else
						{
							child.AdmCdeAlumniPrefId = entity.AdmCdeAlumniPrefId;
						}

					}

					if (entity.AdmAppAlumniPrefCollection.Count > 0 || entity.AdmAppAlumniPrefCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppAlumniPrefProvider.Save(transactionManager, entity.AdmAppAlumniPrefCollection);
						
						deepHandles.Add("AdmAppAlumniPrefCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppAlumniPref >) DataRepository.AdmAppAlumniPrefProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppAlumniPrefCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmCdeAlumniPrefChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmCdeAlumniPref</c>
	///</summary>
	public enum AdmCdeAlumniPrefChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AdmCdeAlumniPref</c> as OneToMany for AdmAppAlumniPrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppAlumniPref>))]
		AdmAppAlumniPrefCollection,
	}
	
	#endregion AdmCdeAlumniPrefChildEntityTypes
	
	#region AdmCdeAlumniPrefFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmCdeAlumniPrefColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeAlumniPref"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeAlumniPrefFilterBuilder : SqlFilterBuilder<AdmCdeAlumniPrefColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeAlumniPrefFilterBuilder class.
		/// </summary>
		public AdmCdeAlumniPrefFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeAlumniPrefFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeAlumniPrefFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeAlumniPrefFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeAlumniPrefFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeAlumniPrefFilterBuilder
	
	#region AdmCdeAlumniPrefParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmCdeAlumniPrefColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeAlumniPref"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeAlumniPrefParameterBuilder : ParameterizedSqlFilterBuilder<AdmCdeAlumniPrefColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeAlumniPrefParameterBuilder class.
		/// </summary>
		public AdmCdeAlumniPrefParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeAlumniPrefParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeAlumniPrefParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeAlumniPrefParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeAlumniPrefParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeAlumniPrefParameterBuilder
	
	#region AdmCdeAlumniPrefSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmCdeAlumniPrefColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeAlumniPref"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmCdeAlumniPrefSortBuilder : SqlSortBuilder<AdmCdeAlumniPrefColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeAlumniPrefSqlSortBuilder class.
		/// </summary>
		public AdmCdeAlumniPrefSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmCdeAlumniPrefSortBuilder
	
} // end namespace
