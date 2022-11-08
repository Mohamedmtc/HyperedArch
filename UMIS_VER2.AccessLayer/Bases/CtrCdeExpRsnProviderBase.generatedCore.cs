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
	/// This class is the base class for any <see cref="CtrCdeExpRsnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrCdeExpRsnProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CtrCdeExpRsn, UMIS_VER2.BusinessLyer.CtrCdeExpRsnKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeExpRsnKey key)
		{
			return Delete(transactionManager, key.CtrCdeExpRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_ctrCdeExpRsnId">سبب الحالة الخاصة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _ctrCdeExpRsnId)
		{
			return Delete(null, _ctrCdeExpRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeExpRsnId">سبب الحالة الخاصة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _ctrCdeExpRsnId);		
		
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
		public override UMIS_VER2.BusinessLyer.CtrCdeExpRsn Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeExpRsnKey key, int start, int pageLength)
		{
			return GetByCtrCdeExpRsnId(transactionManager, key.CtrCdeExpRsnId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CTR_CDE_EXP_RSN index.
		/// </summary>
		/// <param name="_ctrCdeExpRsnId">سبب الحالة الخاصة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeExpRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeExpRsn GetByCtrCdeExpRsnId(System.Decimal _ctrCdeExpRsnId)
		{
			int count = -1;
			return GetByCtrCdeExpRsnId(null,_ctrCdeExpRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_EXP_RSN index.
		/// </summary>
		/// <param name="_ctrCdeExpRsnId">سبب الحالة الخاصة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeExpRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeExpRsn GetByCtrCdeExpRsnId(System.Decimal _ctrCdeExpRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeExpRsnId(null, _ctrCdeExpRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_EXP_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeExpRsnId">سبب الحالة الخاصة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeExpRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeExpRsn GetByCtrCdeExpRsnId(TransactionManager transactionManager, System.Decimal _ctrCdeExpRsnId)
		{
			int count = -1;
			return GetByCtrCdeExpRsnId(transactionManager, _ctrCdeExpRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_EXP_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeExpRsnId">سبب الحالة الخاصة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeExpRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeExpRsn GetByCtrCdeExpRsnId(TransactionManager transactionManager, System.Decimal _ctrCdeExpRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeExpRsnId(transactionManager, _ctrCdeExpRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_EXP_RSN index.
		/// </summary>
		/// <param name="_ctrCdeExpRsnId">سبب الحالة الخاصة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeExpRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeExpRsn GetByCtrCdeExpRsnId(System.Decimal _ctrCdeExpRsnId, int start, int pageLength, out int count)
		{
			return GetByCtrCdeExpRsnId(null, _ctrCdeExpRsnId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_EXP_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeExpRsnId">سبب الحالة الخاصة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeExpRsn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrCdeExpRsn GetByCtrCdeExpRsnId(TransactionManager transactionManager, System.Decimal _ctrCdeExpRsnId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CtrCdeExpRsn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CtrCdeExpRsn&gt;"/></returns>
		public static TList<CtrCdeExpRsn> Fill(IDataReader reader, TList<CtrCdeExpRsn> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CtrCdeExpRsn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CtrCdeExpRsn")
					.Append("|").Append((System.Decimal)reader["CTR_CDE_EXP_RSN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CtrCdeExpRsn>(
					key.ToString(), // EntityTrackingKey
					"CtrCdeExpRsn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CtrCdeExpRsn();
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
					c.CtrCdeExpRsnId = (System.Decimal)reader["CTR_CDE_EXP_RSN_ID"];
					c.OriginalCtrCdeExpRsnId = c.CtrCdeExpRsnId;
					c.ExpRsnAr = (System.String)reader["EXP_RSN_AR"];
					c.ExpRsnEn = (System.String)reader["EXP_RSN_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrCdeExpRsn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeExpRsn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CtrCdeExpRsn entity)
		{
			if (!reader.Read()) return;
			
			entity.CtrCdeExpRsnId = (System.Decimal)reader[((int)CtrCdeExpRsnColumn.CtrCdeExpRsnId - 1)];
			entity.OriginalCtrCdeExpRsnId = (System.Decimal)reader["CTR_CDE_EXP_RSN_ID"];
			entity.ExpRsnAr = (System.String)reader[((int)CtrCdeExpRsnColumn.ExpRsnAr - 1)];
			entity.ExpRsnEn = (System.String)reader[((int)CtrCdeExpRsnColumn.ExpRsnEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrCdeExpRsn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeExpRsn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CtrCdeExpRsn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CtrCdeExpRsnId = (System.Decimal)dataRow["CTR_CDE_EXP_RSN_ID"];
			entity.OriginalCtrCdeExpRsnId = (System.Decimal)dataRow["CTR_CDE_EXP_RSN_ID"];
			entity.ExpRsnAr = (System.String)dataRow["EXP_RSN_AR"];
			entity.ExpRsnEn = (System.String)dataRow["EXP_RSN_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeExpRsn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrCdeExpRsn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeExpRsn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByCtrCdeExpRsnId methods when available
			
			#region CtrStudExpCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrStudExp>|CtrStudExpCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrStudExpCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrStudExpCollection = DataRepository.CtrStudExpProvider.GetByCtrCdeExpRsnId(transactionManager, entity.CtrCdeExpRsnId);

				if (deep && entity.CtrStudExpCollection.Count > 0)
				{
					deepHandles.Add("CtrStudExpCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrStudExp>) DataRepository.CtrStudExpProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrStudExpCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CtrCdeExpRsn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CtrCdeExpRsn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrCdeExpRsn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeExpRsn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<CtrStudExp>
				if (CanDeepSave(entity.CtrStudExpCollection, "List<CtrStudExp>|CtrStudExpCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrStudExp child in entity.CtrStudExpCollection)
					{
						if(child.CtrCdeExpRsnIdSource != null)
						{
							child.CtrCdeExpRsnId = child.CtrCdeExpRsnIdSource.CtrCdeExpRsnId;
						}
						else
						{
							child.CtrCdeExpRsnId = entity.CtrCdeExpRsnId;
						}

					}

					if (entity.CtrStudExpCollection.Count > 0 || entity.CtrStudExpCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrStudExpProvider.Save(transactionManager, entity.CtrStudExpCollection);
						
						deepHandles.Add("CtrStudExpCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrStudExp >) DataRepository.CtrStudExpProvider.DeepSave,
							new object[] { transactionManager, entity.CtrStudExpCollection, deepSaveType, childTypes, innerList }
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
	
	#region CtrCdeExpRsnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CtrCdeExpRsn</c>
	///</summary>
	public enum CtrCdeExpRsnChildEntityTypes
	{
		///<summary>
		/// Collection of <c>CtrCdeExpRsn</c> as OneToMany for CtrStudExpCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrStudExp>))]
		CtrStudExpCollection,
	}
	
	#endregion CtrCdeExpRsnChildEntityTypes
	
	#region CtrCdeExpRsnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CtrCdeExpRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeExpRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrCdeExpRsnFilterBuilder : SqlFilterBuilder<CtrCdeExpRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeExpRsnFilterBuilder class.
		/// </summary>
		public CtrCdeExpRsnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeExpRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrCdeExpRsnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeExpRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrCdeExpRsnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrCdeExpRsnFilterBuilder
	
	#region CtrCdeExpRsnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CtrCdeExpRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeExpRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrCdeExpRsnParameterBuilder : ParameterizedSqlFilterBuilder<CtrCdeExpRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeExpRsnParameterBuilder class.
		/// </summary>
		public CtrCdeExpRsnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeExpRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrCdeExpRsnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeExpRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrCdeExpRsnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrCdeExpRsnParameterBuilder
	
	#region CtrCdeExpRsnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CtrCdeExpRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeExpRsn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CtrCdeExpRsnSortBuilder : SqlSortBuilder<CtrCdeExpRsnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeExpRsnSqlSortBuilder class.
		/// </summary>
		public CtrCdeExpRsnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CtrCdeExpRsnSortBuilder
	
} // end namespace
