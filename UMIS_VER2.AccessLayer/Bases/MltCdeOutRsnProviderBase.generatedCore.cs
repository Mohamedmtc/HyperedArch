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
	/// This class is the base class for any <see cref="MltCdeOutRsnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MltCdeOutRsnProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MltCdeOutRsn, UMIS_VER2.BusinessLyer.MltCdeOutRsnKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltCdeOutRsnKey key)
		{
			return Delete(transactionManager, key.MltCdeOutRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mltCdeOutRsnId">اكواد بيان الخوارج. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _mltCdeOutRsnId)
		{
			return Delete(null, _mltCdeOutRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeOutRsnId">اكواد بيان الخوارج. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _mltCdeOutRsnId);		
		
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
		public override UMIS_VER2.BusinessLyer.MltCdeOutRsn Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltCdeOutRsnKey key, int start, int pageLength)
		{
			return GetByMltCdeOutRsnId(transactionManager, key.MltCdeOutRsnId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MLT_CDE_OUT_RSN index.
		/// </summary>
		/// <param name="_mltCdeOutRsnId">اكواد بيان الخوارج</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeOutRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeOutRsn GetByMltCdeOutRsnId(System.Int32 _mltCdeOutRsnId)
		{
			int count = -1;
			return GetByMltCdeOutRsnId(null,_mltCdeOutRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_OUT_RSN index.
		/// </summary>
		/// <param name="_mltCdeOutRsnId">اكواد بيان الخوارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeOutRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeOutRsn GetByMltCdeOutRsnId(System.Int32 _mltCdeOutRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltCdeOutRsnId(null, _mltCdeOutRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_OUT_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeOutRsnId">اكواد بيان الخوارج</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeOutRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeOutRsn GetByMltCdeOutRsnId(TransactionManager transactionManager, System.Int32 _mltCdeOutRsnId)
		{
			int count = -1;
			return GetByMltCdeOutRsnId(transactionManager, _mltCdeOutRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_OUT_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeOutRsnId">اكواد بيان الخوارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeOutRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeOutRsn GetByMltCdeOutRsnId(TransactionManager transactionManager, System.Int32 _mltCdeOutRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltCdeOutRsnId(transactionManager, _mltCdeOutRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_OUT_RSN index.
		/// </summary>
		/// <param name="_mltCdeOutRsnId">اكواد بيان الخوارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeOutRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeOutRsn GetByMltCdeOutRsnId(System.Int32 _mltCdeOutRsnId, int start, int pageLength, out int count)
		{
			return GetByMltCdeOutRsnId(null, _mltCdeOutRsnId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_OUT_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeOutRsnId">اكواد بيان الخوارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeOutRsn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MltCdeOutRsn GetByMltCdeOutRsnId(TransactionManager transactionManager, System.Int32 _mltCdeOutRsnId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MltCdeOutRsn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MltCdeOutRsn&gt;"/></returns>
		public static TList<MltCdeOutRsn> Fill(IDataReader reader, TList<MltCdeOutRsn> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MltCdeOutRsn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MltCdeOutRsn")
					.Append("|").Append((System.Int32)reader["MLT_CDE_OUT_RSN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MltCdeOutRsn>(
					key.ToString(), // EntityTrackingKey
					"MltCdeOutRsn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MltCdeOutRsn();
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
					c.MltCdeOutRsnId = (System.Int32)reader["MLT_CDE_OUT_RSN_ID"];
					c.OriginalMltCdeOutRsnId = c.MltCdeOutRsnId;
					c.OutRsnAr = Convert.IsDBNull(reader["OUT_RSN_AR"]) ? null : (System.String)reader["OUT_RSN_AR"];
					c.OutRsnEn = Convert.IsDBNull(reader["OUT_RSN_EN"]) ? null : (System.String)reader["OUT_RSN_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltCdeOutRsn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltCdeOutRsn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MltCdeOutRsn entity)
		{
			if (!reader.Read()) return;
			
			entity.MltCdeOutRsnId = (System.Int32)reader[((int)MltCdeOutRsnColumn.MltCdeOutRsnId - 1)];
			entity.OriginalMltCdeOutRsnId = (System.Int32)reader["MLT_CDE_OUT_RSN_ID"];
			entity.OutRsnAr = (reader.IsDBNull(((int)MltCdeOutRsnColumn.OutRsnAr - 1)))?null:(System.String)reader[((int)MltCdeOutRsnColumn.OutRsnAr - 1)];
			entity.OutRsnEn = (reader.IsDBNull(((int)MltCdeOutRsnColumn.OutRsnEn - 1)))?null:(System.String)reader[((int)MltCdeOutRsnColumn.OutRsnEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltCdeOutRsn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltCdeOutRsn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MltCdeOutRsn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MltCdeOutRsnId = (System.Int32)dataRow["MLT_CDE_OUT_RSN_ID"];
			entity.OriginalMltCdeOutRsnId = (System.Int32)dataRow["MLT_CDE_OUT_RSN_ID"];
			entity.OutRsnAr = Convert.IsDBNull(dataRow["OUT_RSN_AR"]) ? null : (System.String)dataRow["OUT_RSN_AR"];
			entity.OutRsnEn = Convert.IsDBNull(dataRow["OUT_RSN_EN"]) ? null : (System.String)dataRow["OUT_RSN_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltCdeOutRsn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltCdeOutRsn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltCdeOutRsn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMltCdeOutRsnId methods when available
			
			#region MltRptDayOutCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltRptDayOut>|MltRptDayOutCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltRptDayOutCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltRptDayOutCollection = DataRepository.MltRptDayOutProvider.GetByMltCdeOutRsnId(transactionManager, entity.MltCdeOutRsnId);

				if (deep && entity.MltRptDayOutCollection.Count > 0)
				{
					deepHandles.Add("MltRptDayOutCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltRptDayOut>) DataRepository.MltRptDayOutProvider.DeepLoad,
						new object[] { transactionManager, entity.MltRptDayOutCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MltCdeOutRsn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MltCdeOutRsn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltCdeOutRsn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltCdeOutRsn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<MltRptDayOut>
				if (CanDeepSave(entity.MltRptDayOutCollection, "List<MltRptDayOut>|MltRptDayOutCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltRptDayOut child in entity.MltRptDayOutCollection)
					{
						if(child.MltCdeOutRsnIdSource != null)
						{
							child.MltCdeOutRsnId = child.MltCdeOutRsnIdSource.MltCdeOutRsnId;
						}
						else
						{
							child.MltCdeOutRsnId = entity.MltCdeOutRsnId;
						}

					}

					if (entity.MltRptDayOutCollection.Count > 0 || entity.MltRptDayOutCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltRptDayOutProvider.Save(transactionManager, entity.MltRptDayOutCollection);
						
						deepHandles.Add("MltRptDayOutCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltRptDayOut >) DataRepository.MltRptDayOutProvider.DeepSave,
							new object[] { transactionManager, entity.MltRptDayOutCollection, deepSaveType, childTypes, innerList }
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
	
	#region MltCdeOutRsnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MltCdeOutRsn</c>
	///</summary>
	public enum MltCdeOutRsnChildEntityTypes
	{
		///<summary>
		/// Collection of <c>MltCdeOutRsn</c> as OneToMany for MltRptDayOutCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltRptDayOut>))]
		MltRptDayOutCollection,
	}
	
	#endregion MltCdeOutRsnChildEntityTypes
	
	#region MltCdeOutRsnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MltCdeOutRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltCdeOutRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltCdeOutRsnFilterBuilder : SqlFilterBuilder<MltCdeOutRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltCdeOutRsnFilterBuilder class.
		/// </summary>
		public MltCdeOutRsnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltCdeOutRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltCdeOutRsnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltCdeOutRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltCdeOutRsnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltCdeOutRsnFilterBuilder
	
	#region MltCdeOutRsnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MltCdeOutRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltCdeOutRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltCdeOutRsnParameterBuilder : ParameterizedSqlFilterBuilder<MltCdeOutRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltCdeOutRsnParameterBuilder class.
		/// </summary>
		public MltCdeOutRsnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltCdeOutRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltCdeOutRsnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltCdeOutRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltCdeOutRsnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltCdeOutRsnParameterBuilder
	
	#region MltCdeOutRsnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MltCdeOutRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltCdeOutRsn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MltCdeOutRsnSortBuilder : SqlSortBuilder<MltCdeOutRsnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltCdeOutRsnSqlSortBuilder class.
		/// </summary>
		public MltCdeOutRsnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MltCdeOutRsnSortBuilder
	
} // end namespace
