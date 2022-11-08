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
	/// This class is the base class for any <see cref="SysServiceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SysServiceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SysService, UMIS_VER2.BusinessLyer.SysServiceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SysServiceKey key)
		{
			return Delete(transactionManager, key.SysServiceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_sysServiceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _sysServiceId)
		{
			return Delete(null, _sysServiceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysServiceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _sysServiceId);		
		
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
		public override UMIS_VER2.BusinessLyer.SysService Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SysServiceKey key, int start, int pageLength)
		{
			return GetBySysServiceId(transactionManager, key.SysServiceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SYS_SERVICE index.
		/// </summary>
		/// <param name="_sysServiceId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysService"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysService GetBySysServiceId(System.Int32 _sysServiceId)
		{
			int count = -1;
			return GetBySysServiceId(null,_sysServiceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_SERVICE index.
		/// </summary>
		/// <param name="_sysServiceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysService"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysService GetBySysServiceId(System.Int32 _sysServiceId, int start, int pageLength)
		{
			int count = -1;
			return GetBySysServiceId(null, _sysServiceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_SERVICE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysServiceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysService"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysService GetBySysServiceId(TransactionManager transactionManager, System.Int32 _sysServiceId)
		{
			int count = -1;
			return GetBySysServiceId(transactionManager, _sysServiceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_SERVICE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysServiceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysService"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysService GetBySysServiceId(TransactionManager transactionManager, System.Int32 _sysServiceId, int start, int pageLength)
		{
			int count = -1;
			return GetBySysServiceId(transactionManager, _sysServiceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_SERVICE index.
		/// </summary>
		/// <param name="_sysServiceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysService"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysService GetBySysServiceId(System.Int32 _sysServiceId, int start, int pageLength, out int count)
		{
			return GetBySysServiceId(null, _sysServiceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_SERVICE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysServiceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysService"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SysService GetBySysServiceId(TransactionManager transactionManager, System.Int32 _sysServiceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SysService&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SysService&gt;"/></returns>
		public static TList<SysService> Fill(IDataReader reader, TList<SysService> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SysService c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SysService")
					.Append("|").Append((System.Int32)reader["SYS_SERVICE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SysService>(
					key.ToString(), // EntityTrackingKey
					"SysService",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SysService();
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
					c.SysServiceId = (System.Int32)reader["SYS_SERVICE_ID"];
					c.ServiceNameAr = Convert.IsDBNull(reader["SERVICE_NAME_AR"]) ? null : (System.String)reader["SERVICE_NAME_AR"];
					c.ServiceNameEn = Convert.IsDBNull(reader["SERVICE_NAME_EN"]) ? null : (System.String)reader["SERVICE_NAME_EN"];
					c.ServiceUrl = Convert.IsDBNull(reader["SERVICE_URL"]) ? null : (System.String)reader["SERVICE_URL"];
					c.ActiveFlg = Convert.IsDBNull(reader["ACTIVE_FLG"]) ? null : (System.Boolean?)reader["ACTIVE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SysService"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SysService"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SysService entity)
		{
			if (!reader.Read()) return;
			
			entity.SysServiceId = (System.Int32)reader[((int)SysServiceColumn.SysServiceId - 1)];
			entity.ServiceNameAr = (reader.IsDBNull(((int)SysServiceColumn.ServiceNameAr - 1)))?null:(System.String)reader[((int)SysServiceColumn.ServiceNameAr - 1)];
			entity.ServiceNameEn = (reader.IsDBNull(((int)SysServiceColumn.ServiceNameEn - 1)))?null:(System.String)reader[((int)SysServiceColumn.ServiceNameEn - 1)];
			entity.ServiceUrl = (reader.IsDBNull(((int)SysServiceColumn.ServiceUrl - 1)))?null:(System.String)reader[((int)SysServiceColumn.ServiceUrl - 1)];
			entity.ActiveFlg = (reader.IsDBNull(((int)SysServiceColumn.ActiveFlg - 1)))?null:(System.Boolean?)reader[((int)SysServiceColumn.ActiveFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SysService"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SysService"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SysService entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SysServiceId = (System.Int32)dataRow["SYS_SERVICE_ID"];
			entity.ServiceNameAr = Convert.IsDBNull(dataRow["SERVICE_NAME_AR"]) ? null : (System.String)dataRow["SERVICE_NAME_AR"];
			entity.ServiceNameEn = Convert.IsDBNull(dataRow["SERVICE_NAME_EN"]) ? null : (System.String)dataRow["SERVICE_NAME_EN"];
			entity.ServiceUrl = Convert.IsDBNull(dataRow["SERVICE_URL"]) ? null : (System.String)dataRow["SERVICE_URL"];
			entity.ActiveFlg = Convert.IsDBNull(dataRow["ACTIVE_FLG"]) ? null : (System.Boolean?)dataRow["ACTIVE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SysService"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SysService Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SysService entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySysServiceId methods when available
			
			#region SysFormCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SysForm>|SysFormCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SysFormCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SysFormCollection = DataRepository.SysFormProvider.GetBySysServiceId(transactionManager, entity.SysServiceId);

				if (deep && entity.SysFormCollection.Count > 0)
				{
					deepHandles.Add("SysFormCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SysForm>) DataRepository.SysFormProvider.DeepLoad,
						new object[] { transactionManager, entity.SysFormCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SysService object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SysService instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SysService Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SysService entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SysForm>
				if (CanDeepSave(entity.SysFormCollection, "List<SysForm>|SysFormCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SysForm child in entity.SysFormCollection)
					{
						if(child.SysServiceIdSource != null)
						{
							child.SysServiceId = child.SysServiceIdSource.SysServiceId;
						}
						else
						{
							child.SysServiceId = entity.SysServiceId;
						}

					}

					if (entity.SysFormCollection.Count > 0 || entity.SysFormCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SysFormProvider.Save(transactionManager, entity.SysFormCollection);
						
						deepHandles.Add("SysFormCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SysForm >) DataRepository.SysFormProvider.DeepSave,
							new object[] { transactionManager, entity.SysFormCollection, deepSaveType, childTypes, innerList }
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
	
	#region SysServiceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SysService</c>
	///</summary>
	public enum SysServiceChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SysService</c> as OneToMany for SysFormCollection
		///</summary>
		[ChildEntityType(typeof(TList<SysForm>))]
		SysFormCollection,
	}
	
	#endregion SysServiceChildEntityTypes
	
	#region SysServiceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SysServiceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SysService"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SysServiceFilterBuilder : SqlFilterBuilder<SysServiceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SysServiceFilterBuilder class.
		/// </summary>
		public SysServiceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SysServiceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SysServiceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SysServiceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SysServiceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SysServiceFilterBuilder
	
	#region SysServiceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SysServiceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SysService"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SysServiceParameterBuilder : ParameterizedSqlFilterBuilder<SysServiceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SysServiceParameterBuilder class.
		/// </summary>
		public SysServiceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SysServiceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SysServiceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SysServiceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SysServiceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SysServiceParameterBuilder
	
	#region SysServiceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SysServiceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SysService"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SysServiceSortBuilder : SqlSortBuilder<SysServiceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SysServiceSqlSortBuilder class.
		/// </summary>
		public SysServiceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SysServiceSortBuilder
	
} // end namespace
