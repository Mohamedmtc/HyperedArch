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
	/// This class is the base class for any <see cref="MltCdeStudDegreeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MltCdeStudDegreeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MltCdeStudDegree, UMIS_VER2.BusinessLyer.MltCdeStudDegreeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltCdeStudDegreeKey key)
		{
			return Delete(transactionManager, key.MltCdeDegreeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mltCdeDegreeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mltCdeDegreeId)
		{
			return Delete(null, _mltCdeDegreeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeDegreeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mltCdeDegreeId);		
		
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
		public override UMIS_VER2.BusinessLyer.MltCdeStudDegree Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltCdeStudDegreeKey key, int start, int pageLength)
		{
			return GetByMltCdeDegreeId(transactionManager, key.MltCdeDegreeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MLT_CDE_DEGREE index.
		/// </summary>
		/// <param name="_mltCdeDegreeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeStudDegree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeStudDegree GetByMltCdeDegreeId(System.Decimal _mltCdeDegreeId)
		{
			int count = -1;
			return GetByMltCdeDegreeId(null,_mltCdeDegreeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_DEGREE index.
		/// </summary>
		/// <param name="_mltCdeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeStudDegree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeStudDegree GetByMltCdeDegreeId(System.Decimal _mltCdeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltCdeDegreeId(null, _mltCdeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_DEGREE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeStudDegree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeStudDegree GetByMltCdeDegreeId(TransactionManager transactionManager, System.Decimal _mltCdeDegreeId)
		{
			int count = -1;
			return GetByMltCdeDegreeId(transactionManager, _mltCdeDegreeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_DEGREE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeStudDegree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeStudDegree GetByMltCdeDegreeId(TransactionManager transactionManager, System.Decimal _mltCdeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltCdeDegreeId(transactionManager, _mltCdeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_DEGREE index.
		/// </summary>
		/// <param name="_mltCdeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeStudDegree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeStudDegree GetByMltCdeDegreeId(System.Decimal _mltCdeDegreeId, int start, int pageLength, out int count)
		{
			return GetByMltCdeDegreeId(null, _mltCdeDegreeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_DEGREE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeStudDegree"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MltCdeStudDegree GetByMltCdeDegreeId(TransactionManager transactionManager, System.Decimal _mltCdeDegreeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MltCdeStudDegree&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MltCdeStudDegree&gt;"/></returns>
		public static TList<MltCdeStudDegree> Fill(IDataReader reader, TList<MltCdeStudDegree> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MltCdeStudDegree c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MltCdeStudDegree")
					.Append("|").Append((System.Decimal)reader["MLT_CDE_DEGREE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MltCdeStudDegree>(
					key.ToString(), // EntityTrackingKey
					"MltCdeStudDegree",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MltCdeStudDegree();
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
					c.MltCdeDegreeId = (System.Decimal)reader["MLT_CDE_DEGREE_ID"];
					c.OriginalMltCdeDegreeId = c.MltCdeDegreeId;
					c.DgrAr = (System.String)reader["DGR_AR"];
					c.DgrEn = (System.String)reader["DGR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltCdeStudDegree"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltCdeStudDegree"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MltCdeStudDegree entity)
		{
			if (!reader.Read()) return;
			
			entity.MltCdeDegreeId = (System.Decimal)reader[((int)MltCdeStudDegreeColumn.MltCdeDegreeId - 1)];
			entity.OriginalMltCdeDegreeId = (System.Decimal)reader["MLT_CDE_DEGREE_ID"];
			entity.DgrAr = (System.String)reader[((int)MltCdeStudDegreeColumn.DgrAr - 1)];
			entity.DgrEn = (System.String)reader[((int)MltCdeStudDegreeColumn.DgrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltCdeStudDegree"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltCdeStudDegree"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MltCdeStudDegree entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MltCdeDegreeId = (System.Decimal)dataRow["MLT_CDE_DEGREE_ID"];
			entity.OriginalMltCdeDegreeId = (System.Decimal)dataRow["MLT_CDE_DEGREE_ID"];
			entity.DgrAr = (System.String)dataRow["DGR_AR"];
			entity.DgrEn = (System.String)dataRow["DGR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltCdeStudDegree"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltCdeStudDegree Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltCdeStudDegree entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMltCdeDegreeId methods when available
			
			#region MltStudInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltStudInfo>|MltStudInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltStudInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltStudInfoCollection = DataRepository.MltStudInfoProvider.GetByMltCdeDegreeId(transactionManager, entity.MltCdeDegreeId);

				if (deep && entity.MltStudInfoCollection.Count > 0)
				{
					deepHandles.Add("MltStudInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltStudInfo>) DataRepository.MltStudInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.MltStudInfoCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MltCdeStudDegree object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MltCdeStudDegree instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltCdeStudDegree Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltCdeStudDegree entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<MltStudInfo>
				if (CanDeepSave(entity.MltStudInfoCollection, "List<MltStudInfo>|MltStudInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltStudInfo child in entity.MltStudInfoCollection)
					{
						if(child.MltCdeDegreeIdSource != null)
						{
							child.MltCdeDegreeId = child.MltCdeDegreeIdSource.MltCdeDegreeId;
						}
						else
						{
							child.MltCdeDegreeId = entity.MltCdeDegreeId;
						}

					}

					if (entity.MltStudInfoCollection.Count > 0 || entity.MltStudInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltStudInfoProvider.Save(transactionManager, entity.MltStudInfoCollection);
						
						deepHandles.Add("MltStudInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltStudInfo >) DataRepository.MltStudInfoProvider.DeepSave,
							new object[] { transactionManager, entity.MltStudInfoCollection, deepSaveType, childTypes, innerList }
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
	
	#region MltCdeStudDegreeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MltCdeStudDegree</c>
	///</summary>
	public enum MltCdeStudDegreeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>MltCdeStudDegree</c> as OneToMany for MltStudInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltStudInfo>))]
		MltStudInfoCollection,
	}
	
	#endregion MltCdeStudDegreeChildEntityTypes
	
	#region MltCdeStudDegreeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MltCdeStudDegreeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltCdeStudDegree"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltCdeStudDegreeFilterBuilder : SqlFilterBuilder<MltCdeStudDegreeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltCdeStudDegreeFilterBuilder class.
		/// </summary>
		public MltCdeStudDegreeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltCdeStudDegreeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltCdeStudDegreeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltCdeStudDegreeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltCdeStudDegreeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltCdeStudDegreeFilterBuilder
	
	#region MltCdeStudDegreeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MltCdeStudDegreeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltCdeStudDegree"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltCdeStudDegreeParameterBuilder : ParameterizedSqlFilterBuilder<MltCdeStudDegreeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltCdeStudDegreeParameterBuilder class.
		/// </summary>
		public MltCdeStudDegreeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltCdeStudDegreeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltCdeStudDegreeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltCdeStudDegreeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltCdeStudDegreeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltCdeStudDegreeParameterBuilder
	
	#region MltCdeStudDegreeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MltCdeStudDegreeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltCdeStudDegree"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MltCdeStudDegreeSortBuilder : SqlSortBuilder<MltCdeStudDegreeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltCdeStudDegreeSqlSortBuilder class.
		/// </summary>
		public MltCdeStudDegreeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MltCdeStudDegreeSortBuilder
	
} // end namespace
