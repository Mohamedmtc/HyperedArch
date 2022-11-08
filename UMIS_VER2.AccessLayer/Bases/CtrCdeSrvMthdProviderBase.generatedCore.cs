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
	/// This class is the base class for any <see cref="CtrCdeSrvMthdProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrCdeSrvMthdProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CtrCdeSrvMthd, UMIS_VER2.BusinessLyer.CtrCdeSrvMthdKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeSrvMthdKey key)
		{
			return Delete(transactionManager, key.CtrCdeSrvMthdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_ctrCdeSrvMthdId">انواع تقديم الطعام. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _ctrCdeSrvMthdId)
		{
			return Delete(null, _ctrCdeSrvMthdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeSrvMthdId">انواع تقديم الطعام. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _ctrCdeSrvMthdId);		
		
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
		public override UMIS_VER2.BusinessLyer.CtrCdeSrvMthd Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeSrvMthdKey key, int start, int pageLength)
		{
			return GetByCtrCdeSrvMthdId(transactionManager, key.CtrCdeSrvMthdId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CTR_CDE_SRV_MTHD index.
		/// </summary>
		/// <param name="_ctrCdeSrvMthdId">انواع تقديم الطعام</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvMthd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeSrvMthd GetByCtrCdeSrvMthdId(System.Decimal _ctrCdeSrvMthdId)
		{
			int count = -1;
			return GetByCtrCdeSrvMthdId(null,_ctrCdeSrvMthdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_SRV_MTHD index.
		/// </summary>
		/// <param name="_ctrCdeSrvMthdId">انواع تقديم الطعام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvMthd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeSrvMthd GetByCtrCdeSrvMthdId(System.Decimal _ctrCdeSrvMthdId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeSrvMthdId(null, _ctrCdeSrvMthdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_SRV_MTHD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeSrvMthdId">انواع تقديم الطعام</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvMthd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeSrvMthd GetByCtrCdeSrvMthdId(TransactionManager transactionManager, System.Decimal _ctrCdeSrvMthdId)
		{
			int count = -1;
			return GetByCtrCdeSrvMthdId(transactionManager, _ctrCdeSrvMthdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_SRV_MTHD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeSrvMthdId">انواع تقديم الطعام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvMthd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeSrvMthd GetByCtrCdeSrvMthdId(TransactionManager transactionManager, System.Decimal _ctrCdeSrvMthdId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeSrvMthdId(transactionManager, _ctrCdeSrvMthdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_SRV_MTHD index.
		/// </summary>
		/// <param name="_ctrCdeSrvMthdId">انواع تقديم الطعام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvMthd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeSrvMthd GetByCtrCdeSrvMthdId(System.Decimal _ctrCdeSrvMthdId, int start, int pageLength, out int count)
		{
			return GetByCtrCdeSrvMthdId(null, _ctrCdeSrvMthdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_SRV_MTHD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeSrvMthdId">انواع تقديم الطعام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvMthd"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrCdeSrvMthd GetByCtrCdeSrvMthdId(TransactionManager transactionManager, System.Decimal _ctrCdeSrvMthdId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CtrCdeSrvMthd&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CtrCdeSrvMthd&gt;"/></returns>
		public static TList<CtrCdeSrvMthd> Fill(IDataReader reader, TList<CtrCdeSrvMthd> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CtrCdeSrvMthd c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CtrCdeSrvMthd")
					.Append("|").Append((System.Decimal)reader["CTR_CDE_SRV_MTHD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CtrCdeSrvMthd>(
					key.ToString(), // EntityTrackingKey
					"CtrCdeSrvMthd",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CtrCdeSrvMthd();
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
					c.CtrCdeSrvMthdId = (System.Decimal)reader["CTR_CDE_SRV_MTHD_ID"];
					c.OriginalCtrCdeSrvMthdId = c.CtrCdeSrvMthdId;
					c.SrvMthdAr = (System.String)reader["SRV_MTHD_AR"];
					c.SrvMthdEn = (System.String)reader["SRV_MTHD_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvMthd"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvMthd"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CtrCdeSrvMthd entity)
		{
			if (!reader.Read()) return;
			
			entity.CtrCdeSrvMthdId = (System.Decimal)reader[((int)CtrCdeSrvMthdColumn.CtrCdeSrvMthdId - 1)];
			entity.OriginalCtrCdeSrvMthdId = (System.Decimal)reader["CTR_CDE_SRV_MTHD_ID"];
			entity.SrvMthdAr = (System.String)reader[((int)CtrCdeSrvMthdColumn.SrvMthdAr - 1)];
			entity.SrvMthdEn = (System.String)reader[((int)CtrCdeSrvMthdColumn.SrvMthdEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvMthd"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvMthd"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CtrCdeSrvMthd entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CtrCdeSrvMthdId = (System.Decimal)dataRow["CTR_CDE_SRV_MTHD_ID"];
			entity.OriginalCtrCdeSrvMthdId = (System.Decimal)dataRow["CTR_CDE_SRV_MTHD_ID"];
			entity.SrvMthdAr = (System.String)dataRow["SRV_MTHD_AR"];
			entity.SrvMthdEn = (System.String)dataRow["SRV_MTHD_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvMthd"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrCdeSrvMthd Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeSrvMthd entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByCtrCdeSrvMthdId methods when available
			
			#region CtrCdeMealItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrCdeMealItem>|CtrCdeMealItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrCdeMealItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrCdeMealItemCollection = DataRepository.CtrCdeMealItemProvider.GetByCtrCdeSrvMthdId(transactionManager, entity.CtrCdeSrvMthdId);

				if (deep && entity.CtrCdeMealItemCollection.Count > 0)
				{
					deepHandles.Add("CtrCdeMealItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrCdeMealItem>) DataRepository.CtrCdeMealItemProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrCdeMealItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CtrCdeSrvMthd object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CtrCdeSrvMthd instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrCdeSrvMthd Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeSrvMthd entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<CtrCdeMealItem>
				if (CanDeepSave(entity.CtrCdeMealItemCollection, "List<CtrCdeMealItem>|CtrCdeMealItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrCdeMealItem child in entity.CtrCdeMealItemCollection)
					{
						if(child.CtrCdeSrvMthdIdSource != null)
						{
							child.CtrCdeSrvMthdId = child.CtrCdeSrvMthdIdSource.CtrCdeSrvMthdId;
						}
						else
						{
							child.CtrCdeSrvMthdId = entity.CtrCdeSrvMthdId;
						}

					}

					if (entity.CtrCdeMealItemCollection.Count > 0 || entity.CtrCdeMealItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrCdeMealItemProvider.Save(transactionManager, entity.CtrCdeMealItemCollection);
						
						deepHandles.Add("CtrCdeMealItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrCdeMealItem >) DataRepository.CtrCdeMealItemProvider.DeepSave,
							new object[] { transactionManager, entity.CtrCdeMealItemCollection, deepSaveType, childTypes, innerList }
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
	
	#region CtrCdeSrvMthdChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CtrCdeSrvMthd</c>
	///</summary>
	public enum CtrCdeSrvMthdChildEntityTypes
	{
		///<summary>
		/// Collection of <c>CtrCdeSrvMthd</c> as OneToMany for CtrCdeMealItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrCdeMealItem>))]
		CtrCdeMealItemCollection,
	}
	
	#endregion CtrCdeSrvMthdChildEntityTypes
	
	#region CtrCdeSrvMthdFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CtrCdeSrvMthdColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeSrvMthd"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrCdeSrvMthdFilterBuilder : SqlFilterBuilder<CtrCdeSrvMthdColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeSrvMthdFilterBuilder class.
		/// </summary>
		public CtrCdeSrvMthdFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeSrvMthdFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrCdeSrvMthdFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeSrvMthdFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrCdeSrvMthdFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrCdeSrvMthdFilterBuilder
	
	#region CtrCdeSrvMthdParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CtrCdeSrvMthdColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeSrvMthd"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrCdeSrvMthdParameterBuilder : ParameterizedSqlFilterBuilder<CtrCdeSrvMthdColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeSrvMthdParameterBuilder class.
		/// </summary>
		public CtrCdeSrvMthdParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeSrvMthdParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrCdeSrvMthdParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeSrvMthdParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrCdeSrvMthdParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrCdeSrvMthdParameterBuilder
	
	#region CtrCdeSrvMthdSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CtrCdeSrvMthdColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeSrvMthd"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CtrCdeSrvMthdSortBuilder : SqlSortBuilder<CtrCdeSrvMthdColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeSrvMthdSqlSortBuilder class.
		/// </summary>
		public CtrCdeSrvMthdSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CtrCdeSrvMthdSortBuilder
	
} // end namespace
