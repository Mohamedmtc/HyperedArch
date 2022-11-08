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
	/// This class is the base class for any <see cref="MdiCdeSignCatProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MdiCdeSignCatProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MdiCdeSignCat, UMIS_VER2.BusinessLyer.MdiCdeSignCatKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeSignCatKey key)
		{
			return Delete(transactionManager, key.MdiCdeSignCatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mdiCdeSignCatId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mdiCdeSignCatId)
		{
			return Delete(null, _mdiCdeSignCatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignCatId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mdiCdeSignCatId);		
		
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
		public override UMIS_VER2.BusinessLyer.MdiCdeSignCat Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeSignCatKey key, int start, int pageLength)
		{
			return GetByMdiCdeSignCatId(transactionManager, key.MdiCdeSignCatId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MDI_CDE_SIGN_CAT index.
		/// </summary>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSignCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSignCat GetByMdiCdeSignCatId(System.Decimal _mdiCdeSignCatId)
		{
			int count = -1;
			return GetByMdiCdeSignCatId(null,_mdiCdeSignCatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_SIGN_CAT index.
		/// </summary>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSignCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSignCat GetByMdiCdeSignCatId(System.Decimal _mdiCdeSignCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeSignCatId(null, _mdiCdeSignCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_SIGN_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSignCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSignCat GetByMdiCdeSignCatId(TransactionManager transactionManager, System.Decimal _mdiCdeSignCatId)
		{
			int count = -1;
			return GetByMdiCdeSignCatId(transactionManager, _mdiCdeSignCatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_SIGN_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSignCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSignCat GetByMdiCdeSignCatId(TransactionManager transactionManager, System.Decimal _mdiCdeSignCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeSignCatId(transactionManager, _mdiCdeSignCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_SIGN_CAT index.
		/// </summary>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSignCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSignCat GetByMdiCdeSignCatId(System.Decimal _mdiCdeSignCatId, int start, int pageLength, out int count)
		{
			return GetByMdiCdeSignCatId(null, _mdiCdeSignCatId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_SIGN_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSignCat"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeSignCat GetByMdiCdeSignCatId(TransactionManager transactionManager, System.Decimal _mdiCdeSignCatId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MdiCdeSignCat&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MdiCdeSignCat&gt;"/></returns>
		public static TList<MdiCdeSignCat> Fill(IDataReader reader, TList<MdiCdeSignCat> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MdiCdeSignCat c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MdiCdeSignCat")
					.Append("|").Append((System.Decimal)reader["MDI_CDE_SIGN_CAT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MdiCdeSignCat>(
					key.ToString(), // EntityTrackingKey
					"MdiCdeSignCat",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MdiCdeSignCat();
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
					c.MdiCdeSignCatId = (System.Decimal)reader["MDI_CDE_SIGN_CAT_ID"];
					c.OriginalMdiCdeSignCatId = c.MdiCdeSignCatId;
					c.SignCatAr = (System.String)reader["SIGN_CAT_AR"];
					c.SignCatEn = (System.String)reader["SIGN_CAT_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSignCat"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeSignCat"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MdiCdeSignCat entity)
		{
			if (!reader.Read()) return;
			
			entity.MdiCdeSignCatId = (System.Decimal)reader[((int)MdiCdeSignCatColumn.MdiCdeSignCatId - 1)];
			entity.OriginalMdiCdeSignCatId = (System.Decimal)reader["MDI_CDE_SIGN_CAT_ID"];
			entity.SignCatAr = (System.String)reader[((int)MdiCdeSignCatColumn.SignCatAr - 1)];
			entity.SignCatEn = (System.String)reader[((int)MdiCdeSignCatColumn.SignCatEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSignCat"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeSignCat"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MdiCdeSignCat entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MdiCdeSignCatId = (System.Decimal)dataRow["MDI_CDE_SIGN_CAT_ID"];
			entity.OriginalMdiCdeSignCatId = (System.Decimal)dataRow["MDI_CDE_SIGN_CAT_ID"];
			entity.SignCatAr = (System.String)dataRow["SIGN_CAT_AR"];
			entity.SignCatEn = (System.String)dataRow["SIGN_CAT_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeSignCat"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiCdeSignCat Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeSignCat entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMdiCdeSignCatId methods when available
			
			#region MdiCdeSignCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiCdeSign>|MdiCdeSignCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiCdeSignCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiCdeSignCollection = DataRepository.MdiCdeSignProvider.GetByMdiCdeSignCatId(transactionManager, entity.MdiCdeSignCatId);

				if (deep && entity.MdiCdeSignCollection.Count > 0)
				{
					deepHandles.Add("MdiCdeSignCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiCdeSign>) DataRepository.MdiCdeSignProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiCdeSignCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MdiCdeSignCat object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MdiCdeSignCat instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiCdeSignCat Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeSignCat entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<MdiCdeSign>
				if (CanDeepSave(entity.MdiCdeSignCollection, "List<MdiCdeSign>|MdiCdeSignCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiCdeSign child in entity.MdiCdeSignCollection)
					{
						if(child.MdiCdeSignCatIdSource != null)
						{
							child.MdiCdeSignCatId = child.MdiCdeSignCatIdSource.MdiCdeSignCatId;
						}
						else
						{
							child.MdiCdeSignCatId = entity.MdiCdeSignCatId;
						}

					}

					if (entity.MdiCdeSignCollection.Count > 0 || entity.MdiCdeSignCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiCdeSignProvider.Save(transactionManager, entity.MdiCdeSignCollection);
						
						deepHandles.Add("MdiCdeSignCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiCdeSign >) DataRepository.MdiCdeSignProvider.DeepSave,
							new object[] { transactionManager, entity.MdiCdeSignCollection, deepSaveType, childTypes, innerList }
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
	
	#region MdiCdeSignCatChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MdiCdeSignCat</c>
	///</summary>
	public enum MdiCdeSignCatChildEntityTypes
	{
		///<summary>
		/// Collection of <c>MdiCdeSignCat</c> as OneToMany for MdiCdeSignCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiCdeSign>))]
		MdiCdeSignCollection,
	}
	
	#endregion MdiCdeSignCatChildEntityTypes
	
	#region MdiCdeSignCatFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MdiCdeSignCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeSignCat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiCdeSignCatFilterBuilder : SqlFilterBuilder<MdiCdeSignCatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeSignCatFilterBuilder class.
		/// </summary>
		public MdiCdeSignCatFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeSignCatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiCdeSignCatFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeSignCatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiCdeSignCatFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiCdeSignCatFilterBuilder
	
	#region MdiCdeSignCatParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MdiCdeSignCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeSignCat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiCdeSignCatParameterBuilder : ParameterizedSqlFilterBuilder<MdiCdeSignCatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeSignCatParameterBuilder class.
		/// </summary>
		public MdiCdeSignCatParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeSignCatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiCdeSignCatParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeSignCatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiCdeSignCatParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiCdeSignCatParameterBuilder
	
	#region MdiCdeSignCatSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MdiCdeSignCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeSignCat"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MdiCdeSignCatSortBuilder : SqlSortBuilder<MdiCdeSignCatColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeSignCatSqlSortBuilder class.
		/// </summary>
		public MdiCdeSignCatSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MdiCdeSignCatSortBuilder
	
} // end namespace
