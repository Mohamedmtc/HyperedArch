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
	/// This class is the base class for any <see cref="SysFormControlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SysFormControlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SysFormControl, UMIS_VER2.BusinessLyer.SysFormControlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SysFormControlKey key)
		{
			return Delete(transactionManager, key.SysFormControlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_sysFormControlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _sysFormControlId)
		{
			return Delete(null, _sysFormControlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysFormControlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _sysFormControlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SYS_FORM_CONTROL_SE_CONTROL_TECH_TYPE key.
		///		FK_SYS_FORM_CONTROL_SE_CONTROL_TECH_TYPE Description: 
		/// </summary>
		/// <param name="_seControlTechTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SysFormControl objects.</returns>
		public TList<SysFormControl> GetBySeControlTechTypeId(System.Decimal _seControlTechTypeId)
		{
			int count = -1;
			return GetBySeControlTechTypeId(_seControlTechTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SYS_FORM_CONTROL_SE_CONTROL_TECH_TYPE key.
		///		FK_SYS_FORM_CONTROL_SE_CONTROL_TECH_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seControlTechTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SysFormControl objects.</returns>
		/// <remarks></remarks>
		public TList<SysFormControl> GetBySeControlTechTypeId(TransactionManager transactionManager, System.Decimal _seControlTechTypeId)
		{
			int count = -1;
			return GetBySeControlTechTypeId(transactionManager, _seControlTechTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SYS_FORM_CONTROL_SE_CONTROL_TECH_TYPE key.
		///		FK_SYS_FORM_CONTROL_SE_CONTROL_TECH_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seControlTechTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SysFormControl objects.</returns>
		public TList<SysFormControl> GetBySeControlTechTypeId(TransactionManager transactionManager, System.Decimal _seControlTechTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeControlTechTypeId(transactionManager, _seControlTechTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SYS_FORM_CONTROL_SE_CONTROL_TECH_TYPE key.
		///		fkSysFormControlSeControlTechType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seControlTechTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SysFormControl objects.</returns>
		public TList<SysFormControl> GetBySeControlTechTypeId(System.Decimal _seControlTechTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeControlTechTypeId(null, _seControlTechTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SYS_FORM_CONTROL_SE_CONTROL_TECH_TYPE key.
		///		fkSysFormControlSeControlTechType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seControlTechTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SysFormControl objects.</returns>
		public TList<SysFormControl> GetBySeControlTechTypeId(System.Decimal _seControlTechTypeId, int start, int pageLength,out int count)
		{
			return GetBySeControlTechTypeId(null, _seControlTechTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SYS_FORM_CONTROL_SE_CONTROL_TECH_TYPE key.
		///		FK_SYS_FORM_CONTROL_SE_CONTROL_TECH_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seControlTechTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SysFormControl objects.</returns>
		public abstract TList<SysFormControl> GetBySeControlTechTypeId(TransactionManager transactionManager, System.Decimal _seControlTechTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SYS_FORM_CONTROL_SYS_FORM key.
		///		FK_SYS_FORM_CONTROL_SYS_FORM Description: 
		/// </summary>
		/// <param name="_sysFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SysFormControl objects.</returns>
		public TList<SysFormControl> GetBySysFormId(System.Int32 _sysFormId)
		{
			int count = -1;
			return GetBySysFormId(_sysFormId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SYS_FORM_CONTROL_SYS_FORM key.
		///		FK_SYS_FORM_CONTROL_SYS_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SysFormControl objects.</returns>
		/// <remarks></remarks>
		public TList<SysFormControl> GetBySysFormId(TransactionManager transactionManager, System.Int32 _sysFormId)
		{
			int count = -1;
			return GetBySysFormId(transactionManager, _sysFormId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SYS_FORM_CONTROL_SYS_FORM key.
		///		FK_SYS_FORM_CONTROL_SYS_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SysFormControl objects.</returns>
		public TList<SysFormControl> GetBySysFormId(TransactionManager transactionManager, System.Int32 _sysFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySysFormId(transactionManager, _sysFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SYS_FORM_CONTROL_SYS_FORM key.
		///		fkSysFormControlSysForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_sysFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SysFormControl objects.</returns>
		public TList<SysFormControl> GetBySysFormId(System.Int32 _sysFormId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySysFormId(null, _sysFormId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SYS_FORM_CONTROL_SYS_FORM key.
		///		fkSysFormControlSysForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_sysFormId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SysFormControl objects.</returns>
		public TList<SysFormControl> GetBySysFormId(System.Int32 _sysFormId, int start, int pageLength,out int count)
		{
			return GetBySysFormId(null, _sysFormId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SYS_FORM_CONTROL_SYS_FORM key.
		///		FK_SYS_FORM_CONTROL_SYS_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SysFormControl objects.</returns>
		public abstract TList<SysFormControl> GetBySysFormId(TransactionManager transactionManager, System.Int32 _sysFormId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SysFormControl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SysFormControlKey key, int start, int pageLength)
		{
			return GetBySysFormControlId(transactionManager, key.SysFormControlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SYS_FORM_CONTROL index.
		/// </summary>
		/// <param name="_sysFormControlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysFormControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysFormControl GetBySysFormControlId(System.Int32 _sysFormControlId)
		{
			int count = -1;
			return GetBySysFormControlId(null,_sysFormControlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_FORM_CONTROL index.
		/// </summary>
		/// <param name="_sysFormControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysFormControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysFormControl GetBySysFormControlId(System.Int32 _sysFormControlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySysFormControlId(null, _sysFormControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_FORM_CONTROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysFormControlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysFormControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysFormControl GetBySysFormControlId(TransactionManager transactionManager, System.Int32 _sysFormControlId)
		{
			int count = -1;
			return GetBySysFormControlId(transactionManager, _sysFormControlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_FORM_CONTROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysFormControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysFormControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysFormControl GetBySysFormControlId(TransactionManager transactionManager, System.Int32 _sysFormControlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySysFormControlId(transactionManager, _sysFormControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_FORM_CONTROL index.
		/// </summary>
		/// <param name="_sysFormControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysFormControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SysFormControl GetBySysFormControlId(System.Int32 _sysFormControlId, int start, int pageLength, out int count)
		{
			return GetBySysFormControlId(null, _sysFormControlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYS_FORM_CONTROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_sysFormControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SysFormControl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SysFormControl GetBySysFormControlId(TransactionManager transactionManager, System.Int32 _sysFormControlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SysFormControl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SysFormControl&gt;"/></returns>
		public static TList<SysFormControl> Fill(IDataReader reader, TList<SysFormControl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SysFormControl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SysFormControl")
					.Append("|").Append((System.Int32)reader["SYS_FORM_CONTROL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SysFormControl>(
					key.ToString(), // EntityTrackingKey
					"SysFormControl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SysFormControl();
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
					c.SysFormControlId = (System.Int32)reader["SYS_FORM_CONTROL_ID"];
					c.SysFormId = (System.Int32)reader["SYS_FORM_ID"];
					c.ControlCode = (System.String)reader["CONTROL_CODE"];
					c.ControlNameAr = (System.String)reader["CONTROL_NAME_AR"];
					c.ControlNameEn = (System.String)reader["CONTROL_NAME_EN"];
					c.SeControlTechTypeId = (System.Decimal)reader["SE_CONTROL_TECH_TYPE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SysFormControl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SysFormControl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SysFormControl entity)
		{
			if (!reader.Read()) return;
			
			entity.SysFormControlId = (System.Int32)reader[((int)SysFormControlColumn.SysFormControlId - 1)];
			entity.SysFormId = (System.Int32)reader[((int)SysFormControlColumn.SysFormId - 1)];
			entity.ControlCode = (System.String)reader[((int)SysFormControlColumn.ControlCode - 1)];
			entity.ControlNameAr = (System.String)reader[((int)SysFormControlColumn.ControlNameAr - 1)];
			entity.ControlNameEn = (System.String)reader[((int)SysFormControlColumn.ControlNameEn - 1)];
			entity.SeControlTechTypeId = (System.Decimal)reader[((int)SysFormControlColumn.SeControlTechTypeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SysFormControl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SysFormControl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SysFormControl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SysFormControlId = (System.Int32)dataRow["SYS_FORM_CONTROL_ID"];
			entity.SysFormId = (System.Int32)dataRow["SYS_FORM_ID"];
			entity.ControlCode = (System.String)dataRow["CONTROL_CODE"];
			entity.ControlNameAr = (System.String)dataRow["CONTROL_NAME_AR"];
			entity.ControlNameEn = (System.String)dataRow["CONTROL_NAME_EN"];
			entity.SeControlTechTypeId = (System.Decimal)dataRow["SE_CONTROL_TECH_TYPE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SysFormControl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SysFormControl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SysFormControl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SeControlTechTypeIdSource	
			if (CanDeepLoad(entity, "SeControlTechType|SeControlTechTypeIdSource", deepLoadType, innerList) 
				&& entity.SeControlTechTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeControlTechTypeId;
				SeControlTechType tmpEntity = EntityManager.LocateEntity<SeControlTechType>(EntityLocator.ConstructKeyFromPkItems(typeof(SeControlTechType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeControlTechTypeIdSource = tmpEntity;
				else
					entity.SeControlTechTypeIdSource = DataRepository.SeControlTechTypeProvider.GetBySeControlTechTypeId(transactionManager, entity.SeControlTechTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeControlTechTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeControlTechTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeControlTechTypeProvider.DeepLoad(transactionManager, entity.SeControlTechTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeControlTechTypeIdSource

			#region SysFormIdSource	
			if (CanDeepLoad(entity, "SysForm|SysFormIdSource", deepLoadType, innerList) 
				&& entity.SysFormIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SysFormId;
				SysForm tmpEntity = EntityManager.LocateEntity<SysForm>(EntityLocator.ConstructKeyFromPkItems(typeof(SysForm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SysFormIdSource = tmpEntity;
				else
					entity.SysFormIdSource = DataRepository.SysFormProvider.GetBySysFormId(transactionManager, entity.SysFormId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SysFormIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SysFormIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SysFormProvider.DeepLoad(transactionManager, entity.SysFormIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SysFormIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SysFormControl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SysFormControl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SysFormControl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SysFormControl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SeControlTechTypeIdSource
			if (CanDeepSave(entity, "SeControlTechType|SeControlTechTypeIdSource", deepSaveType, innerList) 
				&& entity.SeControlTechTypeIdSource != null)
			{
				DataRepository.SeControlTechTypeProvider.Save(transactionManager, entity.SeControlTechTypeIdSource);
				entity.SeControlTechTypeId = entity.SeControlTechTypeIdSource.SeControlTechTypeId;
			}
			#endregion 
			
			#region SysFormIdSource
			if (CanDeepSave(entity, "SysForm|SysFormIdSource", deepSaveType, innerList) 
				&& entity.SysFormIdSource != null)
			{
				DataRepository.SysFormProvider.Save(transactionManager, entity.SysFormIdSource);
				entity.SysFormId = entity.SysFormIdSource.SysFormId;
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
	
	#region SysFormControlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SysFormControl</c>
	///</summary>
	public enum SysFormControlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SeControlTechType</c> at SeControlTechTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SeControlTechType))]
		SeControlTechType,
		
		///<summary>
		/// Composite Property for <c>SysForm</c> at SysFormIdSource
		///</summary>
		[ChildEntityType(typeof(SysForm))]
		SysForm,
	}
	
	#endregion SysFormControlChildEntityTypes
	
	#region SysFormControlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SysFormControlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SysFormControl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SysFormControlFilterBuilder : SqlFilterBuilder<SysFormControlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SysFormControlFilterBuilder class.
		/// </summary>
		public SysFormControlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SysFormControlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SysFormControlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SysFormControlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SysFormControlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SysFormControlFilterBuilder
	
	#region SysFormControlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SysFormControlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SysFormControl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SysFormControlParameterBuilder : ParameterizedSqlFilterBuilder<SysFormControlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SysFormControlParameterBuilder class.
		/// </summary>
		public SysFormControlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SysFormControlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SysFormControlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SysFormControlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SysFormControlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SysFormControlParameterBuilder
	
	#region SysFormControlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SysFormControlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SysFormControl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SysFormControlSortBuilder : SqlSortBuilder<SysFormControlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SysFormControlSqlSortBuilder class.
		/// </summary>
		public SysFormControlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SysFormControlSortBuilder
	
} // end namespace
