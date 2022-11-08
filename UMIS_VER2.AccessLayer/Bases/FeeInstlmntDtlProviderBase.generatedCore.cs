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
	/// This class is the base class for any <see cref="FeeInstlmntDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeInstlmntDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeInstlmntDtl, UMIS_VER2.BusinessLyer.FeeInstlmntDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeInstlmntDtlKey key)
		{
			return Delete(transactionManager, key.FeeInstlmntDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeInstlmntDtlId">مواعيد سددا الاقساط. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeInstlmntDtlId)
		{
			return Delete(null, _feeInstlmntDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInstlmntDtlId">مواعيد سددا الاقساط. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeInstlmntDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INSTLMNT_DTL_FEE_INSTLMNT_RULE key.
		///		FK_FEE_INSTLMNT_DTL_FEE_INSTLMNT_RULE Description: 
		/// </summary>
		/// <param name="_feeInstlmntRuleId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInstlmntDtl objects.</returns>
		public TList<FeeInstlmntDtl> GetByFeeInstlmntRuleId(System.Decimal _feeInstlmntRuleId)
		{
			int count = -1;
			return GetByFeeInstlmntRuleId(_feeInstlmntRuleId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INSTLMNT_DTL_FEE_INSTLMNT_RULE key.
		///		FK_FEE_INSTLMNT_DTL_FEE_INSTLMNT_RULE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInstlmntRuleId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInstlmntDtl objects.</returns>
		/// <remarks></remarks>
		public TList<FeeInstlmntDtl> GetByFeeInstlmntRuleId(TransactionManager transactionManager, System.Decimal _feeInstlmntRuleId)
		{
			int count = -1;
			return GetByFeeInstlmntRuleId(transactionManager, _feeInstlmntRuleId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INSTLMNT_DTL_FEE_INSTLMNT_RULE key.
		///		FK_FEE_INSTLMNT_DTL_FEE_INSTLMNT_RULE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInstlmntRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInstlmntDtl objects.</returns>
		public TList<FeeInstlmntDtl> GetByFeeInstlmntRuleId(TransactionManager transactionManager, System.Decimal _feeInstlmntRuleId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeInstlmntRuleId(transactionManager, _feeInstlmntRuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INSTLMNT_DTL_FEE_INSTLMNT_RULE key.
		///		fkFeeInstlmntDtlFeeInstlmntRule Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeInstlmntRuleId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInstlmntDtl objects.</returns>
		public TList<FeeInstlmntDtl> GetByFeeInstlmntRuleId(System.Decimal _feeInstlmntRuleId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeInstlmntRuleId(null, _feeInstlmntRuleId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INSTLMNT_DTL_FEE_INSTLMNT_RULE key.
		///		fkFeeInstlmntDtlFeeInstlmntRule Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeInstlmntRuleId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInstlmntDtl objects.</returns>
		public TList<FeeInstlmntDtl> GetByFeeInstlmntRuleId(System.Decimal _feeInstlmntRuleId, int start, int pageLength,out int count)
		{
			return GetByFeeInstlmntRuleId(null, _feeInstlmntRuleId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INSTLMNT_DTL_FEE_INSTLMNT_RULE key.
		///		FK_FEE_INSTLMNT_DTL_FEE_INSTLMNT_RULE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInstlmntRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInstlmntDtl objects.</returns>
		public abstract TList<FeeInstlmntDtl> GetByFeeInstlmntRuleId(TransactionManager transactionManager, System.Decimal _feeInstlmntRuleId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeInstlmntDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeInstlmntDtlKey key, int start, int pageLength)
		{
			return GetByFeeInstlmntDtlId(transactionManager, key.FeeInstlmntDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_INSTLMNT_DTL index.
		/// </summary>
		/// <param name="_feeInstlmntDtlId">مواعيد سددا الاقساط</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeInstlmntDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeInstlmntDtl GetByFeeInstlmntDtlId(System.Decimal _feeInstlmntDtlId)
		{
			int count = -1;
			return GetByFeeInstlmntDtlId(null,_feeInstlmntDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_INSTLMNT_DTL index.
		/// </summary>
		/// <param name="_feeInstlmntDtlId">مواعيد سددا الاقساط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeInstlmntDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeInstlmntDtl GetByFeeInstlmntDtlId(System.Decimal _feeInstlmntDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeInstlmntDtlId(null, _feeInstlmntDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_INSTLMNT_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInstlmntDtlId">مواعيد سددا الاقساط</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeInstlmntDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeInstlmntDtl GetByFeeInstlmntDtlId(TransactionManager transactionManager, System.Decimal _feeInstlmntDtlId)
		{
			int count = -1;
			return GetByFeeInstlmntDtlId(transactionManager, _feeInstlmntDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_INSTLMNT_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInstlmntDtlId">مواعيد سددا الاقساط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeInstlmntDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeInstlmntDtl GetByFeeInstlmntDtlId(TransactionManager transactionManager, System.Decimal _feeInstlmntDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeInstlmntDtlId(transactionManager, _feeInstlmntDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_INSTLMNT_DTL index.
		/// </summary>
		/// <param name="_feeInstlmntDtlId">مواعيد سددا الاقساط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeInstlmntDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeInstlmntDtl GetByFeeInstlmntDtlId(System.Decimal _feeInstlmntDtlId, int start, int pageLength, out int count)
		{
			return GetByFeeInstlmntDtlId(null, _feeInstlmntDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_INSTLMNT_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInstlmntDtlId">مواعيد سددا الاقساط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeInstlmntDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeInstlmntDtl GetByFeeInstlmntDtlId(TransactionManager transactionManager, System.Decimal _feeInstlmntDtlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeInstlmntDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeInstlmntDtl&gt;"/></returns>
		public static TList<FeeInstlmntDtl> Fill(IDataReader reader, TList<FeeInstlmntDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeInstlmntDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeInstlmntDtl")
					.Append("|").Append((System.Decimal)reader["FEE_INSTLMNT_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeInstlmntDtl>(
					key.ToString(), // EntityTrackingKey
					"FeeInstlmntDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeInstlmntDtl();
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
					c.FeeInstlmntDtlId = (System.Decimal)reader["FEE_INSTLMNT_DTL_ID"];
					c.OriginalFeeInstlmntDtlId = c.FeeInstlmntDtlId;
					c.FeeInstlmntRuleId = (System.Decimal)reader["FEE_INSTLMNT_RULE_ID"];
					c.InstlmntPrcnt = (System.Decimal)reader["INSTLMNT_PRCNT"];
					c.InstlmntDueDate = (System.DateTime)reader["INSTLMNT_DUE_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeInstlmntDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeInstlmntDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeInstlmntDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeInstlmntDtlId = (System.Decimal)reader[((int)FeeInstlmntDtlColumn.FeeInstlmntDtlId - 1)];
			entity.OriginalFeeInstlmntDtlId = (System.Decimal)reader["FEE_INSTLMNT_DTL_ID"];
			entity.FeeInstlmntRuleId = (System.Decimal)reader[((int)FeeInstlmntDtlColumn.FeeInstlmntRuleId - 1)];
			entity.InstlmntPrcnt = (System.Decimal)reader[((int)FeeInstlmntDtlColumn.InstlmntPrcnt - 1)];
			entity.InstlmntDueDate = (System.DateTime)reader[((int)FeeInstlmntDtlColumn.InstlmntDueDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeInstlmntDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeInstlmntDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeInstlmntDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeInstlmntDtlId = (System.Decimal)dataRow["FEE_INSTLMNT_DTL_ID"];
			entity.OriginalFeeInstlmntDtlId = (System.Decimal)dataRow["FEE_INSTLMNT_DTL_ID"];
			entity.FeeInstlmntRuleId = (System.Decimal)dataRow["FEE_INSTLMNT_RULE_ID"];
			entity.InstlmntPrcnt = (System.Decimal)dataRow["INSTLMNT_PRCNT"];
			entity.InstlmntDueDate = (System.DateTime)dataRow["INSTLMNT_DUE_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeInstlmntDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeInstlmntDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeInstlmntDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region FeeInstlmntRuleIdSource	
			if (CanDeepLoad(entity, "FeeInstlmntRule|FeeInstlmntRuleIdSource", deepLoadType, innerList) 
				&& entity.FeeInstlmntRuleIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeInstlmntRuleId;
				FeeInstlmntRule tmpEntity = EntityManager.LocateEntity<FeeInstlmntRule>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeInstlmntRule), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeInstlmntRuleIdSource = tmpEntity;
				else
					entity.FeeInstlmntRuleIdSource = DataRepository.FeeInstlmntRuleProvider.GetByFeeInstlmntRuleId(transactionManager, entity.FeeInstlmntRuleId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeInstlmntRuleIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeInstlmntRuleIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeInstlmntRuleProvider.DeepLoad(transactionManager, entity.FeeInstlmntRuleIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeInstlmntRuleIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeInstlmntDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeInstlmntDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeInstlmntDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeInstlmntDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region FeeInstlmntRuleIdSource
			if (CanDeepSave(entity, "FeeInstlmntRule|FeeInstlmntRuleIdSource", deepSaveType, innerList) 
				&& entity.FeeInstlmntRuleIdSource != null)
			{
				DataRepository.FeeInstlmntRuleProvider.Save(transactionManager, entity.FeeInstlmntRuleIdSource);
				entity.FeeInstlmntRuleId = entity.FeeInstlmntRuleIdSource.FeeInstlmntRuleId;
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
	
	#region FeeInstlmntDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeInstlmntDtl</c>
	///</summary>
	public enum FeeInstlmntDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>FeeInstlmntRule</c> at FeeInstlmntRuleIdSource
		///</summary>
		[ChildEntityType(typeof(FeeInstlmntRule))]
		FeeInstlmntRule,
	}
	
	#endregion FeeInstlmntDtlChildEntityTypes
	
	#region FeeInstlmntDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeInstlmntDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeInstlmntDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeInstlmntDtlFilterBuilder : SqlFilterBuilder<FeeInstlmntDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeInstlmntDtlFilterBuilder class.
		/// </summary>
		public FeeInstlmntDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeInstlmntDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeInstlmntDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeInstlmntDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeInstlmntDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeInstlmntDtlFilterBuilder
	
	#region FeeInstlmntDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeInstlmntDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeInstlmntDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeInstlmntDtlParameterBuilder : ParameterizedSqlFilterBuilder<FeeInstlmntDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeInstlmntDtlParameterBuilder class.
		/// </summary>
		public FeeInstlmntDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeInstlmntDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeInstlmntDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeInstlmntDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeInstlmntDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeInstlmntDtlParameterBuilder
	
	#region FeeInstlmntDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeInstlmntDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeInstlmntDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeInstlmntDtlSortBuilder : SqlSortBuilder<FeeInstlmntDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeInstlmntDtlSqlSortBuilder class.
		/// </summary>
		public FeeInstlmntDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeInstlmntDtlSortBuilder
	
} // end namespace
