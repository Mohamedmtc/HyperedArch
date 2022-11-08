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
	/// This class is the base class for any <see cref="SysFormProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SysFormProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SysForm, UMIS_VER2.BusinessLyer.SysFormKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SysFormKey key)
		{
			return Delete(transactionManager, key.SysFormId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_sysFormId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _sysFormId)
		{
			return Delete(null, _sysFormId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysFormId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _sysFormId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SYS_FORM_SYS_SERVICE key.
		///		FK_SYS_FORM_SYS_SERVICE Description: 
		/// </summary>
		/// <param name="_sysServiceId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SysForm objects.</returns>
		public TList<SysForm> GetBySysServiceId(System.Int32 _sysServiceId)
		{
			int count = -1;
			return GetBySysServiceId(_sysServiceId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SYS_FORM_SYS_SERVICE key.
		///		FK_SYS_FORM_SYS_SERVICE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysServiceId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SysForm objects.</returns>
		/// <remarks></remarks>
		public TList<SysForm> GetBySysServiceId(TransactionManager transactionManager, System.Int32 _sysServiceId)
		{
			int count = -1;
			return GetBySysServiceId(transactionManager, _sysServiceId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SYS_FORM_SYS_SERVICE key.
		///		FK_SYS_FORM_SYS_SERVICE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysServiceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SysForm objects.</returns>
		public TList<SysForm> GetBySysServiceId(TransactionManager transactionManager, System.Int32 _sysServiceId, int start, int pageLength)
		{
			int count = -1;
			return GetBySysServiceId(transactionManager, _sysServiceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SYS_FORM_SYS_SERVICE key.
		///		fkSysFormSysService Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_sysServiceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SysForm objects.</returns>
		public TList<SysForm> GetBySysServiceId(System.Int32 _sysServiceId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySysServiceId(null, _sysServiceId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SYS_FORM_SYS_SERVICE key.
		///		fkSysFormSysService Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_sysServiceId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SysForm objects.</returns>
		public TList<SysForm> GetBySysServiceId(System.Int32 _sysServiceId, int start, int pageLength,out int count)
		{
			return GetBySysServiceId(null, _sysServiceId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SYS_FORM_SYS_SERVICE key.
		///		FK_SYS_FORM_SYS_SERVICE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysServiceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SysForm objects.</returns>
		public abstract TList<SysForm> GetBySysServiceId(TransactionManager transactionManager, System.Int32 _sysServiceId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SysForm Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SysFormKey key, int start, int pageLength)
		{
			return GetBySysFormId(transactionManager, key.SysFormId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SYS_FORM index.
		/// </summary>
		/// <param name="_sysFormId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysForm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysForm GetBySysFormId(System.Int32 _sysFormId)
		{
			int count = -1;
			return GetBySysFormId(null,_sysFormId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_FORM index.
		/// </summary>
		/// <param name="_sysFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysForm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysForm GetBySysFormId(System.Int32 _sysFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySysFormId(null, _sysFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_FORM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysForm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysForm GetBySysFormId(TransactionManager transactionManager, System.Int32 _sysFormId)
		{
			int count = -1;
			return GetBySysFormId(transactionManager, _sysFormId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_FORM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysForm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysForm GetBySysFormId(TransactionManager transactionManager, System.Int32 _sysFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySysFormId(transactionManager, _sysFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_FORM index.
		/// </summary>
		/// <param name="_sysFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysForm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysForm GetBySysFormId(System.Int32 _sysFormId, int start, int pageLength, out int count)
		{
			return GetBySysFormId(null, _sysFormId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_FORM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysForm"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SysForm GetBySysFormId(TransactionManager transactionManager, System.Int32 _sysFormId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SysForm&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SysForm&gt;"/></returns>
		public static TList<SysForm> Fill(IDataReader reader, TList<SysForm> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SysForm c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SysForm")
					.Append("|").Append((System.Int32)reader["SYS_FORM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SysForm>(
					key.ToString(), // EntityTrackingKey
					"SysForm",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SysForm();
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
					c.SysFormId = (System.Int32)reader["SYS_FORM_ID"];
					c.SysServiceId = (System.Int32)reader["SYS_SERVICE_ID"];
					c.FormCode = (System.String)reader["FORM_CODE"];
					c.FormNameAr = (System.String)reader["FORM_NAME_AR"];
					c.FormNameEn = (System.String)reader["FORM_NAME_EN"];
					c.FormUrl = (System.String)reader["FORM_URL"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SysForm"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SysForm"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SysForm entity)
		{
			if (!reader.Read()) return;
			
			entity.SysFormId = (System.Int32)reader[((int)SysFormColumn.SysFormId - 1)];
			entity.SysServiceId = (System.Int32)reader[((int)SysFormColumn.SysServiceId - 1)];
			entity.FormCode = (System.String)reader[((int)SysFormColumn.FormCode - 1)];
			entity.FormNameAr = (System.String)reader[((int)SysFormColumn.FormNameAr - 1)];
			entity.FormNameEn = (System.String)reader[((int)SysFormColumn.FormNameEn - 1)];
			entity.FormUrl = (System.String)reader[((int)SysFormColumn.FormUrl - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SysForm"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SysForm"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SysForm entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SysFormId = (System.Int32)dataRow["SYS_FORM_ID"];
			entity.SysServiceId = (System.Int32)dataRow["SYS_SERVICE_ID"];
			entity.FormCode = (System.String)dataRow["FORM_CODE"];
			entity.FormNameAr = (System.String)dataRow["FORM_NAME_AR"];
			entity.FormNameEn = (System.String)dataRow["FORM_NAME_EN"];
			entity.FormUrl = (System.String)dataRow["FORM_URL"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SysForm"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SysForm Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SysForm entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SysServiceIdSource	
			if (CanDeepLoad(entity, "SysService|SysServiceIdSource", deepLoadType, innerList) 
				&& entity.SysServiceIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SysServiceId;
				SysService tmpEntity = EntityManager.LocateEntity<SysService>(EntityLocator.ConstructKeyFromPkItems(typeof(SysService), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SysServiceIdSource = tmpEntity;
				else
					entity.SysServiceIdSource = DataRepository.SysServiceProvider.GetBySysServiceId(transactionManager, entity.SysServiceId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SysServiceIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SysServiceIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SysServiceProvider.DeepLoad(transactionManager, entity.SysServiceIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SysServiceIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySysFormId methods when available
			
			#region SysFormControlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SysFormControl>|SysFormControlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SysFormControlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SysFormControlCollection = DataRepository.SysFormControlProvider.GetBySysFormId(transactionManager, entity.SysFormId);

				if (deep && entity.SysFormControlCollection.Count > 0)
				{
					deepHandles.Add("SysFormControlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SysFormControl>) DataRepository.SysFormControlProvider.DeepLoad,
						new object[] { transactionManager, entity.SysFormControlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SysForm object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SysForm instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SysForm Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SysForm entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SysServiceIdSource
			if (CanDeepSave(entity, "SysService|SysServiceIdSource", deepSaveType, innerList) 
				&& entity.SysServiceIdSource != null)
			{
				DataRepository.SysServiceProvider.Save(transactionManager, entity.SysServiceIdSource);
				entity.SysServiceId = entity.SysServiceIdSource.SysServiceId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SysFormControl>
				if (CanDeepSave(entity.SysFormControlCollection, "List<SysFormControl>|SysFormControlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SysFormControl child in entity.SysFormControlCollection)
					{
						if(child.SysFormIdSource != null)
						{
							child.SysFormId = child.SysFormIdSource.SysFormId;
						}
						else
						{
							child.SysFormId = entity.SysFormId;
						}

					}

					if (entity.SysFormControlCollection.Count > 0 || entity.SysFormControlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SysFormControlProvider.Save(transactionManager, entity.SysFormControlCollection);
						
						deepHandles.Add("SysFormControlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SysFormControl >) DataRepository.SysFormControlProvider.DeepSave,
							new object[] { transactionManager, entity.SysFormControlCollection, deepSaveType, childTypes, innerList }
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
	
	#region SysFormChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SysForm</c>
	///</summary>
	public enum SysFormChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SysService</c> at SysServiceIdSource
		///</summary>
		[ChildEntityType(typeof(SysService))]
		SysService,
		///<summary>
		/// Collection of <c>SysForm</c> as OneToMany for SysFormControlCollection
		///</summary>
		[ChildEntityType(typeof(TList<SysFormControl>))]
		SysFormControlCollection,
	}
	
	#endregion SysFormChildEntityTypes
	
	#region SysFormFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SysFormColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SysForm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SysFormFilterBuilder : SqlFilterBuilder<SysFormColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SysFormFilterBuilder class.
		/// </summary>
		public SysFormFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SysFormFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SysFormFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SysFormFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SysFormFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SysFormFilterBuilder
	
	#region SysFormParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SysFormColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SysForm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SysFormParameterBuilder : ParameterizedSqlFilterBuilder<SysFormColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SysFormParameterBuilder class.
		/// </summary>
		public SysFormParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SysFormParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SysFormParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SysFormParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SysFormParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SysFormParameterBuilder
	
	#region SysFormSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SysFormColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SysForm"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SysFormSortBuilder : SqlSortBuilder<SysFormColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SysFormSqlSortBuilder class.
		/// </summary>
		public SysFormSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SysFormSortBuilder
	
} // end namespace
