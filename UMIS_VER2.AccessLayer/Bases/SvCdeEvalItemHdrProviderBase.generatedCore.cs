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
	/// This class is the base class for any <see cref="SvCdeEvalItemHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvCdeEvalItemHdrProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr, UMIS_VER2.BusinessLyer.SvCdeEvalItemHdrKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeEvalItemHdrKey key)
		{
			return Delete(transactionManager, key.SvCdeEvalItemHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svCdeEvalItemHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _svCdeEvalItemHdrId)
		{
			return Delete(null, _svCdeEvalItemHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalItemHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _svCdeEvalItemHdrId);		
		
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
		public override UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeEvalItemHdrKey key, int start, int pageLength)
		{
			return GetBySvCdeEvalItemHdrId(transactionManager, key.SvCdeEvalItemHdrId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_CDE_EVAL_ITEM_HDR index.
		/// </summary>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr GetBySvCdeEvalItemHdrId(System.Int32 _svCdeEvalItemHdrId)
		{
			int count = -1;
			return GetBySvCdeEvalItemHdrId(null,_svCdeEvalItemHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_EVAL_ITEM_HDR index.
		/// </summary>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr GetBySvCdeEvalItemHdrId(System.Int32 _svCdeEvalItemHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeEvalItemHdrId(null, _svCdeEvalItemHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_EVAL_ITEM_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr GetBySvCdeEvalItemHdrId(TransactionManager transactionManager, System.Int32 _svCdeEvalItemHdrId)
		{
			int count = -1;
			return GetBySvCdeEvalItemHdrId(transactionManager, _svCdeEvalItemHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_EVAL_ITEM_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr GetBySvCdeEvalItemHdrId(TransactionManager transactionManager, System.Int32 _svCdeEvalItemHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeEvalItemHdrId(transactionManager, _svCdeEvalItemHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_EVAL_ITEM_HDR index.
		/// </summary>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr GetBySvCdeEvalItemHdrId(System.Int32 _svCdeEvalItemHdrId, int start, int pageLength, out int count)
		{
			return GetBySvCdeEvalItemHdrId(null, _svCdeEvalItemHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_EVAL_ITEM_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr GetBySvCdeEvalItemHdrId(TransactionManager transactionManager, System.Int32 _svCdeEvalItemHdrId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvCdeEvalItemHdr&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvCdeEvalItemHdr&gt;"/></returns>
		public static TList<SvCdeEvalItemHdr> Fill(IDataReader reader, TList<SvCdeEvalItemHdr> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvCdeEvalItemHdr")
					.Append("|").Append((System.Int32)reader["SV_CDE_EVAL_ITEM_HDR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvCdeEvalItemHdr>(
					key.ToString(), // EntityTrackingKey
					"SvCdeEvalItemHdr",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr();
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
					c.SvCdeEvalItemHdrId = (System.Int32)reader["SV_CDE_EVAL_ITEM_HDR_ID"];
					c.OriginalSvCdeEvalItemHdrId = c.SvCdeEvalItemHdrId;
					c.HdrAr = (System.String)reader["HDR_AR"];
					c.HdrEn = (System.String)reader["HDR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr entity)
		{
			if (!reader.Read()) return;
			
			entity.SvCdeEvalItemHdrId = (System.Int32)reader[((int)SvCdeEvalItemHdrColumn.SvCdeEvalItemHdrId - 1)];
			entity.OriginalSvCdeEvalItemHdrId = (System.Int32)reader["SV_CDE_EVAL_ITEM_HDR_ID"];
			entity.HdrAr = (System.String)reader[((int)SvCdeEvalItemHdrColumn.HdrAr - 1)];
			entity.HdrEn = (System.String)reader[((int)SvCdeEvalItemHdrColumn.HdrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvCdeEvalItemHdrId = (System.Int32)dataRow["SV_CDE_EVAL_ITEM_HDR_ID"];
			entity.OriginalSvCdeEvalItemHdrId = (System.Int32)dataRow["SV_CDE_EVAL_ITEM_HDR_ID"];
			entity.HdrAr = (System.String)dataRow["HDR_AR"];
			entity.HdrEn = (System.String)dataRow["HDR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvCdeEvalItemHdrId methods when available
			
			#region SvCodeEvalItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvCodeEvalItem>|SvCodeEvalItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCodeEvalItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvCodeEvalItemCollection = DataRepository.SvCodeEvalItemProvider.GetBySvCdeEvalItemHdrId(transactionManager, entity.SvCdeEvalItemHdrId);

				if (deep && entity.SvCodeEvalItemCollection.Count > 0)
				{
					deepHandles.Add("SvCodeEvalItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvCodeEvalItem>) DataRepository.SvCodeEvalItemProvider.DeepLoad,
						new object[] { transactionManager, entity.SvCodeEvalItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SvCodeEvalItem>
				if (CanDeepSave(entity.SvCodeEvalItemCollection, "List<SvCodeEvalItem>|SvCodeEvalItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvCodeEvalItem child in entity.SvCodeEvalItemCollection)
					{
						if(child.SvCdeEvalItemHdrIdSource != null)
						{
							child.SvCdeEvalItemHdrId = child.SvCdeEvalItemHdrIdSource.SvCdeEvalItemHdrId;
						}
						else
						{
							child.SvCdeEvalItemHdrId = entity.SvCdeEvalItemHdrId;
						}

					}

					if (entity.SvCodeEvalItemCollection.Count > 0 || entity.SvCodeEvalItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvCodeEvalItemProvider.Save(transactionManager, entity.SvCodeEvalItemCollection);
						
						deepHandles.Add("SvCodeEvalItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvCodeEvalItem >) DataRepository.SvCodeEvalItemProvider.DeepSave,
							new object[] { transactionManager, entity.SvCodeEvalItemCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvCdeEvalItemHdrChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvCdeEvalItemHdr</c>
	///</summary>
	public enum SvCdeEvalItemHdrChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SvCdeEvalItemHdr</c> as OneToMany for SvCodeEvalItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvCodeEvalItem>))]
		SvCodeEvalItemCollection,
	}
	
	#endregion SvCdeEvalItemHdrChildEntityTypes
	
	#region SvCdeEvalItemHdrFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvCdeEvalItemHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeEvalItemHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeEvalItemHdrFilterBuilder : SqlFilterBuilder<SvCdeEvalItemHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeEvalItemHdrFilterBuilder class.
		/// </summary>
		public SvCdeEvalItemHdrFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeEvalItemHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeEvalItemHdrFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeEvalItemHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeEvalItemHdrFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeEvalItemHdrFilterBuilder
	
	#region SvCdeEvalItemHdrParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvCdeEvalItemHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeEvalItemHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeEvalItemHdrParameterBuilder : ParameterizedSqlFilterBuilder<SvCdeEvalItemHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeEvalItemHdrParameterBuilder class.
		/// </summary>
		public SvCdeEvalItemHdrParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeEvalItemHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeEvalItemHdrParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeEvalItemHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeEvalItemHdrParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeEvalItemHdrParameterBuilder
	
	#region SvCdeEvalItemHdrSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvCdeEvalItemHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeEvalItemHdr"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvCdeEvalItemHdrSortBuilder : SqlSortBuilder<SvCdeEvalItemHdrColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeEvalItemHdrSqlSortBuilder class.
		/// </summary>
		public SvCdeEvalItemHdrSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvCdeEvalItemHdrSortBuilder
	
} // end namespace
