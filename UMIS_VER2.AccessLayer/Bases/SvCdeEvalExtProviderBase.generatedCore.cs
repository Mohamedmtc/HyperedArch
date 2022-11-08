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
	/// This class is the base class for any <see cref="SvCdeEvalExtProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvCdeEvalExtProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvCdeEvalExt, UMIS_VER2.BusinessLyer.SvCdeEvalExtKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeEvalExtKey key)
		{
			return Delete(transactionManager, key.SvCdeEvalExtId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svCdeEvalExtId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _svCdeEvalExtId)
		{
			return Delete(null, _svCdeEvalExtId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalExtId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _svCdeEvalExtId);		
		
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
		public override UMIS_VER2.BusinessLyer.SvCdeEvalExt Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeEvalExtKey key, int start, int pageLength)
		{
			return GetBySvCdeEvalExtId(transactionManager, key.SvCdeEvalExtId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_CDE_EVAL_EXT index.
		/// </summary>
		/// <param name="_svCdeEvalExtId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeEvalExt GetBySvCdeEvalExtId(System.Int32 _svCdeEvalExtId)
		{
			int count = -1;
			return GetBySvCdeEvalExtId(null,_svCdeEvalExtId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_EVAL_EXT index.
		/// </summary>
		/// <param name="_svCdeEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeEvalExt GetBySvCdeEvalExtId(System.Int32 _svCdeEvalExtId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeEvalExtId(null, _svCdeEvalExtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_EVAL_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalExtId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeEvalExt GetBySvCdeEvalExtId(TransactionManager transactionManager, System.Int32 _svCdeEvalExtId)
		{
			int count = -1;
			return GetBySvCdeEvalExtId(transactionManager, _svCdeEvalExtId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_EVAL_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeEvalExt GetBySvCdeEvalExtId(TransactionManager transactionManager, System.Int32 _svCdeEvalExtId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeEvalExtId(transactionManager, _svCdeEvalExtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_EVAL_EXT index.
		/// </summary>
		/// <param name="_svCdeEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeEvalExt GetBySvCdeEvalExtId(System.Int32 _svCdeEvalExtId, int start, int pageLength, out int count)
		{
			return GetBySvCdeEvalExtId(null, _svCdeEvalExtId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_EVAL_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalExt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCdeEvalExt GetBySvCdeEvalExtId(TransactionManager transactionManager, System.Int32 _svCdeEvalExtId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvCdeEvalExt&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvCdeEvalExt&gt;"/></returns>
		public static TList<SvCdeEvalExt> Fill(IDataReader reader, TList<SvCdeEvalExt> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvCdeEvalExt c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvCdeEvalExt")
					.Append("|").Append((System.Int32)reader["SV_CDE_EVAL_EXT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvCdeEvalExt>(
					key.ToString(), // EntityTrackingKey
					"SvCdeEvalExt",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvCdeEvalExt();
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
					c.SvCdeEvalExtId = (System.Int32)reader["SV_CDE_EVAL_EXT_ID"];
					c.OriginalSvCdeEvalExtId = c.SvCdeEvalExtId;
					c.TypeFlg = Convert.IsDBNull(reader["TYPE_FLG"]) ? null : (System.Int32?)reader["TYPE_FLG"];
					c.EvalExtAr = (System.String)reader["EVAL_EXT_AR"];
					c.EvalExtEn = Convert.IsDBNull(reader["EVAL_EXT_EN"]) ? null : (System.String)reader["EVAL_EXT_EN"];
					c.IsActive = (System.Boolean)reader["IS_ACTIVE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalExt"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalExt"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvCdeEvalExt entity)
		{
			if (!reader.Read()) return;
			
			entity.SvCdeEvalExtId = (System.Int32)reader[((int)SvCdeEvalExtColumn.SvCdeEvalExtId - 1)];
			entity.OriginalSvCdeEvalExtId = (System.Int32)reader["SV_CDE_EVAL_EXT_ID"];
			entity.TypeFlg = (reader.IsDBNull(((int)SvCdeEvalExtColumn.TypeFlg - 1)))?null:(System.Int32?)reader[((int)SvCdeEvalExtColumn.TypeFlg - 1)];
			entity.EvalExtAr = (System.String)reader[((int)SvCdeEvalExtColumn.EvalExtAr - 1)];
			entity.EvalExtEn = (reader.IsDBNull(((int)SvCdeEvalExtColumn.EvalExtEn - 1)))?null:(System.String)reader[((int)SvCdeEvalExtColumn.EvalExtEn - 1)];
			entity.IsActive = (System.Boolean)reader[((int)SvCdeEvalExtColumn.IsActive - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalExt"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalExt"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvCdeEvalExt entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvCdeEvalExtId = (System.Int32)dataRow["SV_CDE_EVAL_EXT_ID"];
			entity.OriginalSvCdeEvalExtId = (System.Int32)dataRow["SV_CDE_EVAL_EXT_ID"];
			entity.TypeFlg = Convert.IsDBNull(dataRow["TYPE_FLG"]) ? null : (System.Int32?)dataRow["TYPE_FLG"];
			entity.EvalExtAr = (System.String)dataRow["EVAL_EXT_AR"];
			entity.EvalExtEn = Convert.IsDBNull(dataRow["EVAL_EXT_EN"]) ? null : (System.String)dataRow["EVAL_EXT_EN"];
			entity.IsActive = (System.Boolean)dataRow["IS_ACTIVE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeEvalExt"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeEvalExt Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeEvalExt entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvCdeEvalExtId methods when available
			
			#region SvCourseEvalExtCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvCourseEvalExt>|SvCourseEvalExtCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCourseEvalExtCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvCourseEvalExtCollection = DataRepository.SvCourseEvalExtProvider.GetBySvCdeEvalExtId(transactionManager, entity.SvCdeEvalExtId);

				if (deep && entity.SvCourseEvalExtCollection.Count > 0)
				{
					deepHandles.Add("SvCourseEvalExtCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvCourseEvalExt>) DataRepository.SvCourseEvalExtProvider.DeepLoad,
						new object[] { transactionManager, entity.SvCourseEvalExtCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStaffEvalExtCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStaffEvalExt>|SvStaffEvalExtCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffEvalExtCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStaffEvalExtCollection = DataRepository.SvStaffEvalExtProvider.GetBySvCdeEvalExtId(transactionManager, entity.SvCdeEvalExtId);

				if (deep && entity.SvStaffEvalExtCollection.Count > 0)
				{
					deepHandles.Add("SvStaffEvalExtCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStaffEvalExt>) DataRepository.SvStaffEvalExtProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStaffEvalExtCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvCdeEvalExt object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvCdeEvalExt instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeEvalExt Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeEvalExt entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SvCourseEvalExt>
				if (CanDeepSave(entity.SvCourseEvalExtCollection, "List<SvCourseEvalExt>|SvCourseEvalExtCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvCourseEvalExt child in entity.SvCourseEvalExtCollection)
					{
						if(child.SvCdeEvalExtIdSource != null)
						{
							child.SvCdeEvalExtId = child.SvCdeEvalExtIdSource.SvCdeEvalExtId;
						}
						else
						{
							child.SvCdeEvalExtId = entity.SvCdeEvalExtId;
						}

					}

					if (entity.SvCourseEvalExtCollection.Count > 0 || entity.SvCourseEvalExtCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvCourseEvalExtProvider.Save(transactionManager, entity.SvCourseEvalExtCollection);
						
						deepHandles.Add("SvCourseEvalExtCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvCourseEvalExt >) DataRepository.SvCourseEvalExtProvider.DeepSave,
							new object[] { transactionManager, entity.SvCourseEvalExtCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStaffEvalExt>
				if (CanDeepSave(entity.SvStaffEvalExtCollection, "List<SvStaffEvalExt>|SvStaffEvalExtCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStaffEvalExt child in entity.SvStaffEvalExtCollection)
					{
						if(child.SvCdeEvalExtIdSource != null)
						{
							child.SvCdeEvalExtId = child.SvCdeEvalExtIdSource.SvCdeEvalExtId;
						}
						else
						{
							child.SvCdeEvalExtId = entity.SvCdeEvalExtId;
						}

					}

					if (entity.SvStaffEvalExtCollection.Count > 0 || entity.SvStaffEvalExtCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStaffEvalExtProvider.Save(transactionManager, entity.SvStaffEvalExtCollection);
						
						deepHandles.Add("SvStaffEvalExtCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStaffEvalExt >) DataRepository.SvStaffEvalExtProvider.DeepSave,
							new object[] { transactionManager, entity.SvStaffEvalExtCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvCdeEvalExtChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvCdeEvalExt</c>
	///</summary>
	public enum SvCdeEvalExtChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SvCdeEvalExt</c> as OneToMany for SvCourseEvalExtCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvCourseEvalExt>))]
		SvCourseEvalExtCollection,
		///<summary>
		/// Collection of <c>SvCdeEvalExt</c> as OneToMany for SvStaffEvalExtCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStaffEvalExt>))]
		SvStaffEvalExtCollection,
	}
	
	#endregion SvCdeEvalExtChildEntityTypes
	
	#region SvCdeEvalExtFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvCdeEvalExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeEvalExt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeEvalExtFilterBuilder : SqlFilterBuilder<SvCdeEvalExtColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeEvalExtFilterBuilder class.
		/// </summary>
		public SvCdeEvalExtFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeEvalExtFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeEvalExtFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeEvalExtFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeEvalExtFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeEvalExtFilterBuilder
	
	#region SvCdeEvalExtParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvCdeEvalExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeEvalExt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeEvalExtParameterBuilder : ParameterizedSqlFilterBuilder<SvCdeEvalExtColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeEvalExtParameterBuilder class.
		/// </summary>
		public SvCdeEvalExtParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeEvalExtParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeEvalExtParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeEvalExtParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeEvalExtParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeEvalExtParameterBuilder
	
	#region SvCdeEvalExtSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvCdeEvalExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeEvalExt"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvCdeEvalExtSortBuilder : SqlSortBuilder<SvCdeEvalExtColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeEvalExtSqlSortBuilder class.
		/// </summary>
		public SvCdeEvalExtSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvCdeEvalExtSortBuilder
	
} // end namespace
