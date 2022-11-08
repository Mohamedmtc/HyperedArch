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
	/// This class is the base class for any <see cref="FeeCdeInvocStatusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeCdeInvocStatusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeCdeInvocStatus, UMIS_VER2.BusinessLyer.FeeCdeInvocStatusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeInvocStatusKey key)
		{
			return Delete(transactionManager, key.FeeCdeInvocStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeCdeInvocStatusId">new-review-paied-cancel. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _feeCdeInvocStatusId)
		{
			return Delete(null, _feeCdeInvocStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeInvocStatusId">new-review-paied-cancel. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _feeCdeInvocStatusId);		
		
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
		public override UMIS_VER2.BusinessLyer.FeeCdeInvocStatus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeInvocStatusKey key, int start, int pageLength)
		{
			return GetByFeeCdeInvocStatusId(transactionManager, key.FeeCdeInvocStatusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_CDE_INVOC_STATUS index.
		/// </summary>
		/// <param name="_feeCdeInvocStatusId">new-review-paied-cancel</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeInvocStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeInvocStatus GetByFeeCdeInvocStatusId(System.Int32 _feeCdeInvocStatusId)
		{
			int count = -1;
			return GetByFeeCdeInvocStatusId(null,_feeCdeInvocStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_INVOC_STATUS index.
		/// </summary>
		/// <param name="_feeCdeInvocStatusId">new-review-paied-cancel</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeInvocStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeInvocStatus GetByFeeCdeInvocStatusId(System.Int32 _feeCdeInvocStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeInvocStatusId(null, _feeCdeInvocStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_INVOC_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeInvocStatusId">new-review-paied-cancel</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeInvocStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeInvocStatus GetByFeeCdeInvocStatusId(TransactionManager transactionManager, System.Int32 _feeCdeInvocStatusId)
		{
			int count = -1;
			return GetByFeeCdeInvocStatusId(transactionManager, _feeCdeInvocStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_INVOC_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeInvocStatusId">new-review-paied-cancel</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeInvocStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeInvocStatus GetByFeeCdeInvocStatusId(TransactionManager transactionManager, System.Int32 _feeCdeInvocStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeInvocStatusId(transactionManager, _feeCdeInvocStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_INVOC_STATUS index.
		/// </summary>
		/// <param name="_feeCdeInvocStatusId">new-review-paied-cancel</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeInvocStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeInvocStatus GetByFeeCdeInvocStatusId(System.Int32 _feeCdeInvocStatusId, int start, int pageLength, out int count)
		{
			return GetByFeeCdeInvocStatusId(null, _feeCdeInvocStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_INVOC_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeInvocStatusId">new-review-paied-cancel</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeInvocStatus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCdeInvocStatus GetByFeeCdeInvocStatusId(TransactionManager transactionManager, System.Int32 _feeCdeInvocStatusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeCdeInvocStatus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeCdeInvocStatus&gt;"/></returns>
		public static TList<FeeCdeInvocStatus> Fill(IDataReader reader, TList<FeeCdeInvocStatus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeCdeInvocStatus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeCdeInvocStatus")
					.Append("|").Append((System.Int32)reader["FEE_CDE_INVOC_STATUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeCdeInvocStatus>(
					key.ToString(), // EntityTrackingKey
					"FeeCdeInvocStatus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeCdeInvocStatus();
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
					c.FeeCdeInvocStatusId = (System.Int32)reader["FEE_CDE_INVOC_STATUS_ID"];
					c.OriginalFeeCdeInvocStatusId = c.FeeCdeInvocStatusId;
					c.InvocStatusAr = (System.String)reader["INVOC_STATUS_AR"];
					c.InvocStatusEn = (System.String)reader["INVOC_STATUS_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeInvocStatus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeInvocStatus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeCdeInvocStatus entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeCdeInvocStatusId = (System.Int32)reader[((int)FeeCdeInvocStatusColumn.FeeCdeInvocStatusId - 1)];
			entity.OriginalFeeCdeInvocStatusId = (System.Int32)reader["FEE_CDE_INVOC_STATUS_ID"];
			entity.InvocStatusAr = (System.String)reader[((int)FeeCdeInvocStatusColumn.InvocStatusAr - 1)];
			entity.InvocStatusEn = (System.String)reader[((int)FeeCdeInvocStatusColumn.InvocStatusEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeInvocStatus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeInvocStatus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeCdeInvocStatus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeCdeInvocStatusId = (System.Int32)dataRow["FEE_CDE_INVOC_STATUS_ID"];
			entity.OriginalFeeCdeInvocStatusId = (System.Int32)dataRow["FEE_CDE_INVOC_STATUS_ID"];
			entity.InvocStatusAr = (System.String)dataRow["INVOC_STATUS_AR"];
			entity.InvocStatusEn = (System.String)dataRow["INVOC_STATUS_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeInvocStatus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeInvocStatus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeInvocStatus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeCdeInvocStatusId methods when available
			
			#region FeeInvoiceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeInvoice>|FeeInvoiceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeInvoiceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeInvoiceCollection = DataRepository.FeeInvoiceProvider.GetByFeeCdeInvocStatusId(transactionManager, entity.FeeCdeInvocStatusId);

				if (deep && entity.FeeInvoiceCollection.Count > 0)
				{
					deepHandles.Add("FeeInvoiceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeInvoice>) DataRepository.FeeInvoiceProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeInvoiceCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeCdeInvocStatus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeCdeInvocStatus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeInvocStatus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeInvocStatus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<FeeInvoice>
				if (CanDeepSave(entity.FeeInvoiceCollection, "List<FeeInvoice>|FeeInvoiceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeInvoice child in entity.FeeInvoiceCollection)
					{
						if(child.FeeCdeInvocStatusIdSource != null)
						{
							child.FeeCdeInvocStatusId = child.FeeCdeInvocStatusIdSource.FeeCdeInvocStatusId;
						}
						else
						{
							child.FeeCdeInvocStatusId = entity.FeeCdeInvocStatusId;
						}

					}

					if (entity.FeeInvoiceCollection.Count > 0 || entity.FeeInvoiceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeInvoiceProvider.Save(transactionManager, entity.FeeInvoiceCollection);
						
						deepHandles.Add("FeeInvoiceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeInvoice >) DataRepository.FeeInvoiceProvider.DeepSave,
							new object[] { transactionManager, entity.FeeInvoiceCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeCdeInvocStatusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeCdeInvocStatus</c>
	///</summary>
	public enum FeeCdeInvocStatusChildEntityTypes
	{
		///<summary>
		/// Collection of <c>FeeCdeInvocStatus</c> as OneToMany for FeeInvoiceCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeInvoice>))]
		FeeInvoiceCollection,
	}
	
	#endregion FeeCdeInvocStatusChildEntityTypes
	
	#region FeeCdeInvocStatusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeCdeInvocStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeInvocStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeInvocStatusFilterBuilder : SqlFilterBuilder<FeeCdeInvocStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeInvocStatusFilterBuilder class.
		/// </summary>
		public FeeCdeInvocStatusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeInvocStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeInvocStatusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeInvocStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeInvocStatusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeInvocStatusFilterBuilder
	
	#region FeeCdeInvocStatusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeCdeInvocStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeInvocStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeInvocStatusParameterBuilder : ParameterizedSqlFilterBuilder<FeeCdeInvocStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeInvocStatusParameterBuilder class.
		/// </summary>
		public FeeCdeInvocStatusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeInvocStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeInvocStatusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeInvocStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeInvocStatusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeInvocStatusParameterBuilder
	
	#region FeeCdeInvocStatusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeCdeInvocStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeInvocStatus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeCdeInvocStatusSortBuilder : SqlSortBuilder<FeeCdeInvocStatusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeInvocStatusSqlSortBuilder class.
		/// </summary>
		public FeeCdeInvocStatusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeCdeInvocStatusSortBuilder
	
} // end namespace
