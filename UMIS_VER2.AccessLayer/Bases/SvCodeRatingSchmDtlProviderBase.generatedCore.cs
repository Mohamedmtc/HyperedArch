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
	/// This class is the base class for any <see cref="SvCodeRatingSchmDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvCodeRatingSchmDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl, UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtlKey key)
		{
			return Delete(transactionManager, key.SvCodeRatingSchmDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svCodeRatingSchmDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svCodeRatingSchmDtlId)
		{
			return Delete(null, _svCodeRatingSchmDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmDtlId);		
		
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
		public override UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtlKey key, int start, int pageLength)
		{
			return GetBySvCodeRatingSchmDtlId(transactionManager, key.SvCodeRatingSchmDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SV_CODE_RATING_SCHM__1 index.
		/// </summary>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCodeRatingSchmDtl&gt;"/> class.</returns>
		public TList<SvCodeRatingSchmDtl> GetBySvCodeRatingSchmId(System.Decimal _svCodeRatingSchmId)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(null,_svCodeRatingSchmId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_RATING_SCHM__1 index.
		/// </summary>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCodeRatingSchmDtl&gt;"/> class.</returns>
		public TList<SvCodeRatingSchmDtl> GetBySvCodeRatingSchmId(System.Decimal _svCodeRatingSchmId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(null, _svCodeRatingSchmId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_RATING_SCHM__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCodeRatingSchmDtl&gt;"/> class.</returns>
		public TList<SvCodeRatingSchmDtl> GetBySvCodeRatingSchmId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmId)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(transactionManager, _svCodeRatingSchmId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_RATING_SCHM__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCodeRatingSchmDtl&gt;"/> class.</returns>
		public TList<SvCodeRatingSchmDtl> GetBySvCodeRatingSchmId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(transactionManager, _svCodeRatingSchmId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_RATING_SCHM__1 index.
		/// </summary>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCodeRatingSchmDtl&gt;"/> class.</returns>
		public TList<SvCodeRatingSchmDtl> GetBySvCodeRatingSchmId(System.Decimal _svCodeRatingSchmId, int start, int pageLength, out int count)
		{
			return GetBySvCodeRatingSchmId(null, _svCodeRatingSchmId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_RATING_SCHM__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCodeRatingSchmDtl&gt;"/> class.</returns>
		public abstract TList<SvCodeRatingSchmDtl> GetBySvCodeRatingSchmId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_CODE_RATING_SCHM_DTL index.
		/// </summary>
		/// <param name="_svCodeRatingSchmDtlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl GetBySvCodeRatingSchmDtlId(System.Decimal _svCodeRatingSchmDtlId)
		{
			int count = -1;
			return GetBySvCodeRatingSchmDtlId(null,_svCodeRatingSchmDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CODE_RATING_SCHM_DTL index.
		/// </summary>
		/// <param name="_svCodeRatingSchmDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl GetBySvCodeRatingSchmDtlId(System.Decimal _svCodeRatingSchmDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeRatingSchmDtlId(null, _svCodeRatingSchmDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CODE_RATING_SCHM_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl GetBySvCodeRatingSchmDtlId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmDtlId)
		{
			int count = -1;
			return GetBySvCodeRatingSchmDtlId(transactionManager, _svCodeRatingSchmDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CODE_RATING_SCHM_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl GetBySvCodeRatingSchmDtlId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeRatingSchmDtlId(transactionManager, _svCodeRatingSchmDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CODE_RATING_SCHM_DTL index.
		/// </summary>
		/// <param name="_svCodeRatingSchmDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl GetBySvCodeRatingSchmDtlId(System.Decimal _svCodeRatingSchmDtlId, int start, int pageLength, out int count)
		{
			return GetBySvCodeRatingSchmDtlId(null, _svCodeRatingSchmDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CODE_RATING_SCHM_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl GetBySvCodeRatingSchmDtlId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmDtlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvCodeRatingSchmDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvCodeRatingSchmDtl&gt;"/></returns>
		public static TList<SvCodeRatingSchmDtl> Fill(IDataReader reader, TList<SvCodeRatingSchmDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvCodeRatingSchmDtl")
					.Append("|").Append((System.Decimal)reader["SV_CODE_RATING_SCHM_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvCodeRatingSchmDtl>(
					key.ToString(), // EntityTrackingKey
					"SvCodeRatingSchmDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl();
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
					c.SvCodeRatingSchmDtlId = (System.Decimal)reader["SV_CODE_RATING_SCHM_DTL_ID"];
					c.OriginalSvCodeRatingSchmDtlId = c.SvCodeRatingSchmDtlId;
					c.SvCodeRatingSchmId = (System.Decimal)reader["SV_CODE_RATING_SCHM_ID"];
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.Ordr = Convert.IsDBNull(reader["ORDR"]) ? null : (System.Decimal?)reader["ORDR"];
					c.Rank = Convert.IsDBNull(reader["RANK"]) ? null : (System.Decimal?)reader["RANK"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.SvCodeRatingSchmDtlId = (System.Decimal)reader[((int)SvCodeRatingSchmDtlColumn.SvCodeRatingSchmDtlId - 1)];
			entity.OriginalSvCodeRatingSchmDtlId = (System.Decimal)reader["SV_CODE_RATING_SCHM_DTL_ID"];
			entity.SvCodeRatingSchmId = (System.Decimal)reader[((int)SvCodeRatingSchmDtlColumn.SvCodeRatingSchmId - 1)];
			entity.DescrAr = (System.String)reader[((int)SvCodeRatingSchmDtlColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)SvCodeRatingSchmDtlColumn.DescrEn - 1)];
			entity.Ordr = (reader.IsDBNull(((int)SvCodeRatingSchmDtlColumn.Ordr - 1)))?null:(System.Decimal?)reader[((int)SvCodeRatingSchmDtlColumn.Ordr - 1)];
			entity.Rank = (reader.IsDBNull(((int)SvCodeRatingSchmDtlColumn.Rank - 1)))?null:(System.Decimal?)reader[((int)SvCodeRatingSchmDtlColumn.Rank - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvCodeRatingSchmDtlId = (System.Decimal)dataRow["SV_CODE_RATING_SCHM_DTL_ID"];
			entity.OriginalSvCodeRatingSchmDtlId = (System.Decimal)dataRow["SV_CODE_RATING_SCHM_DTL_ID"];
			entity.SvCodeRatingSchmId = (System.Decimal)dataRow["SV_CODE_RATING_SCHM_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.Ordr = Convert.IsDBNull(dataRow["ORDR"]) ? null : (System.Decimal?)dataRow["ORDR"];
			entity.Rank = Convert.IsDBNull(dataRow["RANK"]) ? null : (System.Decimal?)dataRow["RANK"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SvCodeRatingSchmIdSource	
			if (CanDeepLoad(entity, "SvCodeRatingSchm|SvCodeRatingSchmIdSource", deepLoadType, innerList) 
				&& entity.SvCodeRatingSchmIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvCodeRatingSchmId;
				SvCodeRatingSchm tmpEntity = EntityManager.LocateEntity<SvCodeRatingSchm>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCodeRatingSchm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCodeRatingSchmIdSource = tmpEntity;
				else
					entity.SvCodeRatingSchmIdSource = DataRepository.SvCodeRatingSchmProvider.GetBySvCodeRatingSchmId(transactionManager, entity.SvCodeRatingSchmId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCodeRatingSchmIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCodeRatingSchmIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCodeRatingSchmProvider.DeepLoad(transactionManager, entity.SvCodeRatingSchmIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCodeRatingSchmIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvCodeRatingSchmDtlId methods when available
			
			#region SvStudStaffEvalCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudStaffEval>|SvStudStaffEvalCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudStaffEvalCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudStaffEvalCollection = DataRepository.SvStudStaffEvalProvider.GetBySvCodeRatingSchmDtlId(transactionManager, entity.SvCodeRatingSchmDtlId);

				if (deep && entity.SvStudStaffEvalCollection.Count > 0)
				{
					deepHandles.Add("SvStudStaffEvalCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudStaffEval>) DataRepository.SvStudStaffEvalProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudStaffEvalCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudCourseEvalCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudCourseEval>|SvStudCourseEvalCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudCourseEvalCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudCourseEvalCollection = DataRepository.SvStudCourseEvalProvider.GetBySvCodeRatingSchmDtlId(transactionManager, entity.SvCodeRatingSchmDtlId);

				if (deep && entity.SvStudCourseEvalCollection.Count > 0)
				{
					deepHandles.Add("SvStudCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudCourseEval>) DataRepository.SvStudCourseEvalProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudCourseEvalCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SvCodeRatingSchmIdSource
			if (CanDeepSave(entity, "SvCodeRatingSchm|SvCodeRatingSchmIdSource", deepSaveType, innerList) 
				&& entity.SvCodeRatingSchmIdSource != null)
			{
				DataRepository.SvCodeRatingSchmProvider.Save(transactionManager, entity.SvCodeRatingSchmIdSource);
				entity.SvCodeRatingSchmId = entity.SvCodeRatingSchmIdSource.SvCodeRatingSchmId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SvStudStaffEval>
				if (CanDeepSave(entity.SvStudStaffEvalCollection, "List<SvStudStaffEval>|SvStudStaffEvalCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudStaffEval child in entity.SvStudStaffEvalCollection)
					{
						if(child.SvCodeRatingSchmDtlIdSource != null)
						{
							child.SvCodeRatingSchmDtlId = child.SvCodeRatingSchmDtlIdSource.SvCodeRatingSchmDtlId;
						}
						else
						{
							child.SvCodeRatingSchmDtlId = entity.SvCodeRatingSchmDtlId;
						}

					}

					if (entity.SvStudStaffEvalCollection.Count > 0 || entity.SvStudStaffEvalCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudStaffEvalProvider.Save(transactionManager, entity.SvStudStaffEvalCollection);
						
						deepHandles.Add("SvStudStaffEvalCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudStaffEval >) DataRepository.SvStudStaffEvalProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudStaffEvalCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudCourseEval>
				if (CanDeepSave(entity.SvStudCourseEvalCollection, "List<SvStudCourseEval>|SvStudCourseEvalCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudCourseEval child in entity.SvStudCourseEvalCollection)
					{
						if(child.SvCodeRatingSchmDtlIdSource != null)
						{
							child.SvCodeRatingSchmDtlId = child.SvCodeRatingSchmDtlIdSource.SvCodeRatingSchmDtlId;
						}
						else
						{
							child.SvCodeRatingSchmDtlId = entity.SvCodeRatingSchmDtlId;
						}

					}

					if (entity.SvStudCourseEvalCollection.Count > 0 || entity.SvStudCourseEvalCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudCourseEvalProvider.Save(transactionManager, entity.SvStudCourseEvalCollection);
						
						deepHandles.Add("SvStudCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudCourseEval >) DataRepository.SvStudCourseEvalProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudCourseEvalCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvCodeRatingSchmDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvCodeRatingSchmDtl</c>
	///</summary>
	public enum SvCodeRatingSchmDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SvCodeRatingSchm</c> at SvCodeRatingSchmIdSource
		///</summary>
		[ChildEntityType(typeof(SvCodeRatingSchm))]
		SvCodeRatingSchm,
		///<summary>
		/// Collection of <c>SvCodeRatingSchmDtl</c> as OneToMany for SvStudStaffEvalCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudStaffEval>))]
		SvStudStaffEvalCollection,
		///<summary>
		/// Collection of <c>SvCodeRatingSchmDtl</c> as OneToMany for SvStudCourseEvalCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudCourseEval>))]
		SvStudCourseEvalCollection,
	}
	
	#endregion SvCodeRatingSchmDtlChildEntityTypes
	
	#region SvCodeRatingSchmDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvCodeRatingSchmDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCodeRatingSchmDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCodeRatingSchmDtlFilterBuilder : SqlFilterBuilder<SvCodeRatingSchmDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCodeRatingSchmDtlFilterBuilder class.
		/// </summary>
		public SvCodeRatingSchmDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCodeRatingSchmDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCodeRatingSchmDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCodeRatingSchmDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCodeRatingSchmDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCodeRatingSchmDtlFilterBuilder
	
	#region SvCodeRatingSchmDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvCodeRatingSchmDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCodeRatingSchmDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCodeRatingSchmDtlParameterBuilder : ParameterizedSqlFilterBuilder<SvCodeRatingSchmDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCodeRatingSchmDtlParameterBuilder class.
		/// </summary>
		public SvCodeRatingSchmDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCodeRatingSchmDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCodeRatingSchmDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCodeRatingSchmDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCodeRatingSchmDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCodeRatingSchmDtlParameterBuilder
	
	#region SvCodeRatingSchmDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvCodeRatingSchmDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCodeRatingSchmDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvCodeRatingSchmDtlSortBuilder : SqlSortBuilder<SvCodeRatingSchmDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCodeRatingSchmDtlSqlSortBuilder class.
		/// </summary>
		public SvCodeRatingSchmDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvCodeRatingSchmDtlSortBuilder
	
} // end namespace
