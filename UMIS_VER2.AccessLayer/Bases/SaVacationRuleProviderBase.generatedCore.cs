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
	/// This class is the base class for any <see cref="SaVacationRuleProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaVacationRuleProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaVacationRule, UMIS_VER2.BusinessLyer.SaVacationRuleKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationRuleKey key)
		{
			return Delete(transactionManager, key.SaVacationRuleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saVacationRuleId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saVacationRuleId)
		{
			return Delete(null, _saVacationRuleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationRuleId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saVacationRuleId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0531 key.
		///		FK_AUTO_0531 Description: 
		/// </summary>
		/// <param name="_saVacationBylawsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRule objects.</returns>
		public TList<SaVacationRule> GetBySaVacationBylawsId(System.Decimal _saVacationBylawsId)
		{
			int count = -1;
			return GetBySaVacationBylawsId(_saVacationBylawsId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0531 key.
		///		FK_AUTO_0531 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBylawsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRule objects.</returns>
		/// <remarks></remarks>
		public TList<SaVacationRule> GetBySaVacationBylawsId(TransactionManager transactionManager, System.Decimal _saVacationBylawsId)
		{
			int count = -1;
			return GetBySaVacationBylawsId(transactionManager, _saVacationBylawsId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0531 key.
		///		FK_AUTO_0531 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBylawsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRule objects.</returns>
		public TList<SaVacationRule> GetBySaVacationBylawsId(TransactionManager transactionManager, System.Decimal _saVacationBylawsId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaVacationBylawsId(transactionManager, _saVacationBylawsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0531 key.
		///		fkAuto0531 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saVacationBylawsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRule objects.</returns>
		public TList<SaVacationRule> GetBySaVacationBylawsId(System.Decimal _saVacationBylawsId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaVacationBylawsId(null, _saVacationBylawsId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0531 key.
		///		fkAuto0531 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saVacationBylawsId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRule objects.</returns>
		public TList<SaVacationRule> GetBySaVacationBylawsId(System.Decimal _saVacationBylawsId, int start, int pageLength,out int count)
		{
			return GetBySaVacationBylawsId(null, _saVacationBylawsId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0531 key.
		///		FK_AUTO_0531 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBylawsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRule objects.</returns>
		public abstract TList<SaVacationRule> GetBySaVacationBylawsId(TransactionManager transactionManager, System.Decimal _saVacationBylawsId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaVacationRule Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationRuleKey key, int start, int pageLength)
		{
			return GetBySaVacationRuleId(transactionManager, key.SaVacationRuleId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_VACATION_RULE index.
		/// </summary>
		/// <param name="_saVacationRuleId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationRule GetBySaVacationRuleId(System.Decimal _saVacationRuleId)
		{
			int count = -1;
			return GetBySaVacationRuleId(null,_saVacationRuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_RULE index.
		/// </summary>
		/// <param name="_saVacationRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationRule GetBySaVacationRuleId(System.Decimal _saVacationRuleId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaVacationRuleId(null, _saVacationRuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationRuleId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationRule GetBySaVacationRuleId(TransactionManager transactionManager, System.Decimal _saVacationRuleId)
		{
			int count = -1;
			return GetBySaVacationRuleId(transactionManager, _saVacationRuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationRule GetBySaVacationRuleId(TransactionManager transactionManager, System.Decimal _saVacationRuleId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaVacationRuleId(transactionManager, _saVacationRuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_RULE index.
		/// </summary>
		/// <param name="_saVacationRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationRule GetBySaVacationRuleId(System.Decimal _saVacationRuleId, int start, int pageLength, out int count)
		{
			return GetBySaVacationRuleId(null, _saVacationRuleId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationRule"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaVacationRule GetBySaVacationRuleId(TransactionManager transactionManager, System.Decimal _saVacationRuleId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaVacationRule&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaVacationRule&gt;"/></returns>
		public static TList<SaVacationRule> Fill(IDataReader reader, TList<SaVacationRule> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaVacationRule c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaVacationRule")
					.Append("|").Append((System.Decimal)reader["SA_VACATION_RULE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaVacationRule>(
					key.ToString(), // EntityTrackingKey
					"SaVacationRule",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaVacationRule();
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
					c.SaVacationRuleId = (System.Decimal)reader["SA_VACATION_RULE_ID"];
					c.OriginalSaVacationRuleId = c.SaVacationRuleId;
					c.VacationRuleCode = (System.String)reader["VACATION_RULE_CODE"];
					c.EmpPeriodFrom = Convert.IsDBNull(reader["EMP_PERIOD_FROM"]) ? null : (System.Decimal?)reader["EMP_PERIOD_FROM"];
					c.EmpPeriodTo = Convert.IsDBNull(reader["EMP_PERIOD_TO"]) ? null : (System.Decimal?)reader["EMP_PERIOD_TO"];
					c.AgeFrom = Convert.IsDBNull(reader["AGE_FROM"]) ? null : (System.Decimal?)reader["AGE_FROM"];
					c.AgeTo = Convert.IsDBNull(reader["AGE_TO"]) ? null : (System.Decimal?)reader["AGE_TO"];
					c.BalanceAmount = (System.Decimal)reader["BALANCE_AMOUNT"];
					c.SaVacationBylawsId = (System.Decimal)reader["SA_VACATION_BYLAWS_ID"];
					c.SaVacAgeFlag = (System.Decimal)reader["SA_VAC_AGE_FLAG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaVacationRule"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaVacationRule"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaVacationRule entity)
		{
			if (!reader.Read()) return;
			
			entity.SaVacationRuleId = (System.Decimal)reader[((int)SaVacationRuleColumn.SaVacationRuleId - 1)];
			entity.OriginalSaVacationRuleId = (System.Decimal)reader["SA_VACATION_RULE_ID"];
			entity.VacationRuleCode = (System.String)reader[((int)SaVacationRuleColumn.VacationRuleCode - 1)];
			entity.EmpPeriodFrom = (reader.IsDBNull(((int)SaVacationRuleColumn.EmpPeriodFrom - 1)))?null:(System.Decimal?)reader[((int)SaVacationRuleColumn.EmpPeriodFrom - 1)];
			entity.EmpPeriodTo = (reader.IsDBNull(((int)SaVacationRuleColumn.EmpPeriodTo - 1)))?null:(System.Decimal?)reader[((int)SaVacationRuleColumn.EmpPeriodTo - 1)];
			entity.AgeFrom = (reader.IsDBNull(((int)SaVacationRuleColumn.AgeFrom - 1)))?null:(System.Decimal?)reader[((int)SaVacationRuleColumn.AgeFrom - 1)];
			entity.AgeTo = (reader.IsDBNull(((int)SaVacationRuleColumn.AgeTo - 1)))?null:(System.Decimal?)reader[((int)SaVacationRuleColumn.AgeTo - 1)];
			entity.BalanceAmount = (System.Decimal)reader[((int)SaVacationRuleColumn.BalanceAmount - 1)];
			entity.SaVacationBylawsId = (System.Decimal)reader[((int)SaVacationRuleColumn.SaVacationBylawsId - 1)];
			entity.SaVacAgeFlag = (System.Decimal)reader[((int)SaVacationRuleColumn.SaVacAgeFlag - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaVacationRule"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaVacationRule"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaVacationRule entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaVacationRuleId = (System.Decimal)dataRow["SA_VACATION_RULE_ID"];
			entity.OriginalSaVacationRuleId = (System.Decimal)dataRow["SA_VACATION_RULE_ID"];
			entity.VacationRuleCode = (System.String)dataRow["VACATION_RULE_CODE"];
			entity.EmpPeriodFrom = Convert.IsDBNull(dataRow["EMP_PERIOD_FROM"]) ? null : (System.Decimal?)dataRow["EMP_PERIOD_FROM"];
			entity.EmpPeriodTo = Convert.IsDBNull(dataRow["EMP_PERIOD_TO"]) ? null : (System.Decimal?)dataRow["EMP_PERIOD_TO"];
			entity.AgeFrom = Convert.IsDBNull(dataRow["AGE_FROM"]) ? null : (System.Decimal?)dataRow["AGE_FROM"];
			entity.AgeTo = Convert.IsDBNull(dataRow["AGE_TO"]) ? null : (System.Decimal?)dataRow["AGE_TO"];
			entity.BalanceAmount = (System.Decimal)dataRow["BALANCE_AMOUNT"];
			entity.SaVacationBylawsId = (System.Decimal)dataRow["SA_VACATION_BYLAWS_ID"];
			entity.SaVacAgeFlag = (System.Decimal)dataRow["SA_VAC_AGE_FLAG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaVacationRule"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaVacationRule Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationRule entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaVacationBylawsIdSource	
			if (CanDeepLoad(entity, "SaVacationBylaws|SaVacationBylawsIdSource", deepLoadType, innerList) 
				&& entity.SaVacationBylawsIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaVacationBylawsId;
				SaVacationBylaws tmpEntity = EntityManager.LocateEntity<SaVacationBylaws>(EntityLocator.ConstructKeyFromPkItems(typeof(SaVacationBylaws), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaVacationBylawsIdSource = tmpEntity;
				else
					entity.SaVacationBylawsIdSource = DataRepository.SaVacationBylawsProvider.GetBySaVacationBylawsId(transactionManager, entity.SaVacationBylawsId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationBylawsIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaVacationBylawsIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaVacationBylawsProvider.DeepLoad(transactionManager, entity.SaVacationBylawsIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaVacationBylawsIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaVacationRule object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaVacationRule instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaVacationRule Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationRule entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaVacationBylawsIdSource
			if (CanDeepSave(entity, "SaVacationBylaws|SaVacationBylawsIdSource", deepSaveType, innerList) 
				&& entity.SaVacationBylawsIdSource != null)
			{
				DataRepository.SaVacationBylawsProvider.Save(transactionManager, entity.SaVacationBylawsIdSource);
				entity.SaVacationBylawsId = entity.SaVacationBylawsIdSource.SaVacationBylawsId;
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
	
	#region SaVacationRuleChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaVacationRule</c>
	///</summary>
	public enum SaVacationRuleChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaVacationBylaws</c> at SaVacationBylawsIdSource
		///</summary>
		[ChildEntityType(typeof(SaVacationBylaws))]
		SaVacationBylaws,
	}
	
	#endregion SaVacationRuleChildEntityTypes
	
	#region SaVacationRuleFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaVacationRuleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaVacationRule"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaVacationRuleFilterBuilder : SqlFilterBuilder<SaVacationRuleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaVacationRuleFilterBuilder class.
		/// </summary>
		public SaVacationRuleFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaVacationRuleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaVacationRuleFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaVacationRuleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaVacationRuleFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaVacationRuleFilterBuilder
	
	#region SaVacationRuleParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaVacationRuleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaVacationRule"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaVacationRuleParameterBuilder : ParameterizedSqlFilterBuilder<SaVacationRuleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaVacationRuleParameterBuilder class.
		/// </summary>
		public SaVacationRuleParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaVacationRuleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaVacationRuleParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaVacationRuleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaVacationRuleParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaVacationRuleParameterBuilder
	
	#region SaVacationRuleSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaVacationRuleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaVacationRule"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaVacationRuleSortBuilder : SqlSortBuilder<SaVacationRuleColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaVacationRuleSqlSortBuilder class.
		/// </summary>
		public SaVacationRuleSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaVacationRuleSortBuilder
	
} // end namespace
