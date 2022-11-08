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
	/// This class is the base class for any <see cref="CtrCdeOutRsnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrCdeOutRsnProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CtrCdeOutRsn, UMIS_VER2.BusinessLyer.CtrCdeOutRsnKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeOutRsnKey key)
		{
			return Delete(transactionManager, key.CtrCdeOutRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_ctrCdeOutRsnId">سبب خروج من التغذية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _ctrCdeOutRsnId)
		{
			return Delete(null, _ctrCdeOutRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeOutRsnId">سبب خروج من التغذية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _ctrCdeOutRsnId);		
		
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
		public override UMIS_VER2.BusinessLyer.CtrCdeOutRsn Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeOutRsnKey key, int start, int pageLength)
		{
			return GetByCtrCdeOutRsnId(transactionManager, key.CtrCdeOutRsnId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CTR_CDE_OUT_RSN index.
		/// </summary>
		/// <param name="_ctrCdeOutRsnId">سبب خروج من التغذية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeOutRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeOutRsn GetByCtrCdeOutRsnId(System.Decimal _ctrCdeOutRsnId)
		{
			int count = -1;
			return GetByCtrCdeOutRsnId(null,_ctrCdeOutRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_OUT_RSN index.
		/// </summary>
		/// <param name="_ctrCdeOutRsnId">سبب خروج من التغذية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeOutRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeOutRsn GetByCtrCdeOutRsnId(System.Decimal _ctrCdeOutRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeOutRsnId(null, _ctrCdeOutRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_OUT_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeOutRsnId">سبب خروج من التغذية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeOutRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeOutRsn GetByCtrCdeOutRsnId(TransactionManager transactionManager, System.Decimal _ctrCdeOutRsnId)
		{
			int count = -1;
			return GetByCtrCdeOutRsnId(transactionManager, _ctrCdeOutRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_OUT_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeOutRsnId">سبب خروج من التغذية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeOutRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeOutRsn GetByCtrCdeOutRsnId(TransactionManager transactionManager, System.Decimal _ctrCdeOutRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeOutRsnId(transactionManager, _ctrCdeOutRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_OUT_RSN index.
		/// </summary>
		/// <param name="_ctrCdeOutRsnId">سبب خروج من التغذية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeOutRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeOutRsn GetByCtrCdeOutRsnId(System.Decimal _ctrCdeOutRsnId, int start, int pageLength, out int count)
		{
			return GetByCtrCdeOutRsnId(null, _ctrCdeOutRsnId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_OUT_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeOutRsnId">سبب خروج من التغذية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeOutRsn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrCdeOutRsn GetByCtrCdeOutRsnId(TransactionManager transactionManager, System.Decimal _ctrCdeOutRsnId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CtrCdeOutRsn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CtrCdeOutRsn&gt;"/></returns>
		public static TList<CtrCdeOutRsn> Fill(IDataReader reader, TList<CtrCdeOutRsn> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CtrCdeOutRsn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CtrCdeOutRsn")
					.Append("|").Append((System.Decimal)reader["CTR_CDE_OUT_RSN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CtrCdeOutRsn>(
					key.ToString(), // EntityTrackingKey
					"CtrCdeOutRsn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CtrCdeOutRsn();
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
					c.CtrCdeOutRsnId = (System.Decimal)reader["CTR_CDE_OUT_RSN_ID"];
					c.OriginalCtrCdeOutRsnId = c.CtrCdeOutRsnId;
					c.OutRsnAr = (System.String)reader["OUT_RSN_AR"];
					c.OutRsnEn = (System.String)reader["OUT_RSN_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrCdeOutRsn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeOutRsn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CtrCdeOutRsn entity)
		{
			if (!reader.Read()) return;
			
			entity.CtrCdeOutRsnId = (System.Decimal)reader[((int)CtrCdeOutRsnColumn.CtrCdeOutRsnId - 1)];
			entity.OriginalCtrCdeOutRsnId = (System.Decimal)reader["CTR_CDE_OUT_RSN_ID"];
			entity.OutRsnAr = (System.String)reader[((int)CtrCdeOutRsnColumn.OutRsnAr - 1)];
			entity.OutRsnEn = (System.String)reader[((int)CtrCdeOutRsnColumn.OutRsnEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrCdeOutRsn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeOutRsn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CtrCdeOutRsn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CtrCdeOutRsnId = (System.Decimal)dataRow["CTR_CDE_OUT_RSN_ID"];
			entity.OriginalCtrCdeOutRsnId = (System.Decimal)dataRow["CTR_CDE_OUT_RSN_ID"];
			entity.OutRsnAr = (System.String)dataRow["OUT_RSN_AR"];
			entity.OutRsnEn = (System.String)dataRow["OUT_RSN_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeOutRsn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrCdeOutRsn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeOutRsn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByCtrCdeOutRsnId methods when available
			
			#region CtrStudOutCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrStudOut>|CtrStudOutCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrStudOutCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrStudOutCollection = DataRepository.CtrStudOutProvider.GetByCtrCdeOutRsnId(transactionManager, entity.CtrCdeOutRsnId);

				if (deep && entity.CtrStudOutCollection.Count > 0)
				{
					deepHandles.Add("CtrStudOutCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrStudOut>) DataRepository.CtrStudOutProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrStudOutCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CtrCdeOutRsn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CtrCdeOutRsn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrCdeOutRsn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeOutRsn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<CtrStudOut>
				if (CanDeepSave(entity.CtrStudOutCollection, "List<CtrStudOut>|CtrStudOutCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrStudOut child in entity.CtrStudOutCollection)
					{
						if(child.CtrCdeOutRsnIdSource != null)
						{
							child.CtrCdeOutRsnId = child.CtrCdeOutRsnIdSource.CtrCdeOutRsnId;
						}
						else
						{
							child.CtrCdeOutRsnId = entity.CtrCdeOutRsnId;
						}

					}

					if (entity.CtrStudOutCollection.Count > 0 || entity.CtrStudOutCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrStudOutProvider.Save(transactionManager, entity.CtrStudOutCollection);
						
						deepHandles.Add("CtrStudOutCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrStudOut >) DataRepository.CtrStudOutProvider.DeepSave,
							new object[] { transactionManager, entity.CtrStudOutCollection, deepSaveType, childTypes, innerList }
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
	
	#region CtrCdeOutRsnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CtrCdeOutRsn</c>
	///</summary>
	public enum CtrCdeOutRsnChildEntityTypes
	{
		///<summary>
		/// Collection of <c>CtrCdeOutRsn</c> as OneToMany for CtrStudOutCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrStudOut>))]
		CtrStudOutCollection,
	}
	
	#endregion CtrCdeOutRsnChildEntityTypes
	
	#region CtrCdeOutRsnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CtrCdeOutRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeOutRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrCdeOutRsnFilterBuilder : SqlFilterBuilder<CtrCdeOutRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeOutRsnFilterBuilder class.
		/// </summary>
		public CtrCdeOutRsnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeOutRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrCdeOutRsnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeOutRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrCdeOutRsnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrCdeOutRsnFilterBuilder
	
	#region CtrCdeOutRsnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CtrCdeOutRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeOutRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrCdeOutRsnParameterBuilder : ParameterizedSqlFilterBuilder<CtrCdeOutRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeOutRsnParameterBuilder class.
		/// </summary>
		public CtrCdeOutRsnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeOutRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrCdeOutRsnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeOutRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrCdeOutRsnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrCdeOutRsnParameterBuilder
	
	#region CtrCdeOutRsnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CtrCdeOutRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeOutRsn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CtrCdeOutRsnSortBuilder : SqlSortBuilder<CtrCdeOutRsnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeOutRsnSqlSortBuilder class.
		/// </summary>
		public CtrCdeOutRsnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CtrCdeOutRsnSortBuilder
	
} // end namespace
