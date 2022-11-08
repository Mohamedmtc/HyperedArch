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
	/// This class is the base class for any <see cref="AdmCdeQualStatusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmCdeQualStatusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmCdeQualStatus, UMIS_VER2.BusinessLyer.AdmCdeQualStatusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeQualStatusKey key)
		{
			return Delete(transactionManager, key.AdmCdeQualStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admCdeQualStatusId">EJUST. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _admCdeQualStatusId)
		{
			return Delete(null, _admCdeQualStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeQualStatusId">EJUST. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _admCdeQualStatusId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmCdeQualStatus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeQualStatusKey key, int start, int pageLength)
		{
			return GetByAdmCdeQualStatusId(transactionManager, key.AdmCdeQualStatusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_CDE_QUAL_STATUS index.
		/// </summary>
		/// <param name="_admCdeQualStatusId">EJUST</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeQualStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeQualStatus GetByAdmCdeQualStatusId(System.Int32 _admCdeQualStatusId)
		{
			int count = -1;
			return GetByAdmCdeQualStatusId(null,_admCdeQualStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_QUAL_STATUS index.
		/// </summary>
		/// <param name="_admCdeQualStatusId">EJUST</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeQualStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeQualStatus GetByAdmCdeQualStatusId(System.Int32 _admCdeQualStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeQualStatusId(null, _admCdeQualStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_QUAL_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeQualStatusId">EJUST</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeQualStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeQualStatus GetByAdmCdeQualStatusId(TransactionManager transactionManager, System.Int32 _admCdeQualStatusId)
		{
			int count = -1;
			return GetByAdmCdeQualStatusId(transactionManager, _admCdeQualStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_QUAL_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeQualStatusId">EJUST</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeQualStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeQualStatus GetByAdmCdeQualStatusId(TransactionManager transactionManager, System.Int32 _admCdeQualStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeQualStatusId(transactionManager, _admCdeQualStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_QUAL_STATUS index.
		/// </summary>
		/// <param name="_admCdeQualStatusId">EJUST</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeQualStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeQualStatus GetByAdmCdeQualStatusId(System.Int32 _admCdeQualStatusId, int start, int pageLength, out int count)
		{
			return GetByAdmCdeQualStatusId(null, _admCdeQualStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_QUAL_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeQualStatusId">EJUST</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeQualStatus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCdeQualStatus GetByAdmCdeQualStatusId(TransactionManager transactionManager, System.Int32 _admCdeQualStatusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmCdeQualStatus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmCdeQualStatus&gt;"/></returns>
		public static TList<AdmCdeQualStatus> Fill(IDataReader reader, TList<AdmCdeQualStatus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmCdeQualStatus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmCdeQualStatus")
					.Append("|").Append((System.Int32)reader["ADM_CDE_QUAL_STATUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmCdeQualStatus>(
					key.ToString(), // EntityTrackingKey
					"AdmCdeQualStatus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmCdeQualStatus();
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
					c.AdmCdeQualStatusId = (System.Int32)reader["ADM_CDE_QUAL_STATUS_ID"];
					c.OriginalAdmCdeQualStatusId = c.AdmCdeQualStatusId;
					c.QualStatusEn = Convert.IsDBNull(reader["QUAL_STATUS_EN"]) ? null : (System.String)reader["QUAL_STATUS_EN"];
					c.QualStatusAr = Convert.IsDBNull(reader["QUAL_STATUS_AR"]) ? null : (System.String)reader["QUAL_STATUS_AR"];
					c.DefaultFlg = Convert.IsDBNull(reader["DEFAULT_FLG"]) ? null : (System.Boolean?)reader["DEFAULT_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeQualStatus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeQualStatus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmCdeQualStatus entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmCdeQualStatusId = (System.Int32)reader[((int)AdmCdeQualStatusColumn.AdmCdeQualStatusId - 1)];
			entity.OriginalAdmCdeQualStatusId = (System.Int32)reader["ADM_CDE_QUAL_STATUS_ID"];
			entity.QualStatusEn = (reader.IsDBNull(((int)AdmCdeQualStatusColumn.QualStatusEn - 1)))?null:(System.String)reader[((int)AdmCdeQualStatusColumn.QualStatusEn - 1)];
			entity.QualStatusAr = (reader.IsDBNull(((int)AdmCdeQualStatusColumn.QualStatusAr - 1)))?null:(System.String)reader[((int)AdmCdeQualStatusColumn.QualStatusAr - 1)];
			entity.DefaultFlg = (reader.IsDBNull(((int)AdmCdeQualStatusColumn.DefaultFlg - 1)))?null:(System.Boolean?)reader[((int)AdmCdeQualStatusColumn.DefaultFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeQualStatus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeQualStatus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmCdeQualStatus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmCdeQualStatusId = (System.Int32)dataRow["ADM_CDE_QUAL_STATUS_ID"];
			entity.OriginalAdmCdeQualStatusId = (System.Int32)dataRow["ADM_CDE_QUAL_STATUS_ID"];
			entity.QualStatusEn = Convert.IsDBNull(dataRow["QUAL_STATUS_EN"]) ? null : (System.String)dataRow["QUAL_STATUS_EN"];
			entity.QualStatusAr = Convert.IsDBNull(dataRow["QUAL_STATUS_AR"]) ? null : (System.String)dataRow["QUAL_STATUS_AR"];
			entity.DefaultFlg = Convert.IsDBNull(dataRow["DEFAULT_FLG"]) ? null : (System.Boolean?)dataRow["DEFAULT_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeQualStatus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeQualStatus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeQualStatus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmCdeQualStatusId methods when available
			
			#region EdStudQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQual>|EdStudQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualCollection = DataRepository.EdStudQualProvider.GetByAdmCdeQualStatusId(transactionManager, entity.AdmCdeQualStatusId);

				if (deep && entity.EdStudQualCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQual>) DataRepository.EdStudQualProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmCdeQualStatus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmCdeQualStatus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeQualStatus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeQualStatus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudQual>
				if (CanDeepSave(entity.EdStudQualCollection, "List<EdStudQual>|EdStudQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQual child in entity.EdStudQualCollection)
					{
						if(child.AdmCdeQualStatusIdSource != null)
						{
							child.AdmCdeQualStatusId = child.AdmCdeQualStatusIdSource.AdmCdeQualStatusId;
						}
						else
						{
							child.AdmCdeQualStatusId = entity.AdmCdeQualStatusId;
						}

					}

					if (entity.EdStudQualCollection.Count > 0 || entity.EdStudQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudQualProvider.Save(transactionManager, entity.EdStudQualCollection);
						
						deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudQual >) DataRepository.EdStudQualProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudQualCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmCdeQualStatusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmCdeQualStatus</c>
	///</summary>
	public enum AdmCdeQualStatusChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AdmCdeQualStatus</c> as OneToMany for EdStudQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQual>))]
		EdStudQualCollection,
	}
	
	#endregion AdmCdeQualStatusChildEntityTypes
	
	#region AdmCdeQualStatusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmCdeQualStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeQualStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeQualStatusFilterBuilder : SqlFilterBuilder<AdmCdeQualStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeQualStatusFilterBuilder class.
		/// </summary>
		public AdmCdeQualStatusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeQualStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeQualStatusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeQualStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeQualStatusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeQualStatusFilterBuilder
	
	#region AdmCdeQualStatusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmCdeQualStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeQualStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeQualStatusParameterBuilder : ParameterizedSqlFilterBuilder<AdmCdeQualStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeQualStatusParameterBuilder class.
		/// </summary>
		public AdmCdeQualStatusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeQualStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeQualStatusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeQualStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeQualStatusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeQualStatusParameterBuilder
	
	#region AdmCdeQualStatusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmCdeQualStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeQualStatus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmCdeQualStatusSortBuilder : SqlSortBuilder<AdmCdeQualStatusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeQualStatusSqlSortBuilder class.
		/// </summary>
		public AdmCdeQualStatusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmCdeQualStatusSortBuilder
	
} // end namespace
