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
	/// This class is the base class for any <see cref="SvCdeCompReplyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvCdeCompReplyProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvCdeCompReply, UMIS_VER2.BusinessLyer.SvCdeCompReplyKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeCompReplyKey key)
		{
			return Delete(transactionManager, key.SvCdeCompReplyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svCdeCompReplyId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svCdeCompReplyId)
		{
			return Delete(null, _svCdeCompReplyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompReplyId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svCdeCompReplyId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_COMP_REPLY_SV_CDE_COMP_TYPE key.
		///		FK_SV_CDE_COMP_REPLY_SV_CDE_COMP_TYPE Description: 
		/// </summary>
		/// <param name="_svCdeCompTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeCompReply objects.</returns>
		public TList<SvCdeCompReply> GetBySvCdeCompTypeId(System.Decimal? _svCdeCompTypeId)
		{
			int count = -1;
			return GetBySvCdeCompTypeId(_svCdeCompTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_COMP_REPLY_SV_CDE_COMP_TYPE key.
		///		FK_SV_CDE_COMP_REPLY_SV_CDE_COMP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeCompReply objects.</returns>
		/// <remarks></remarks>
		public TList<SvCdeCompReply> GetBySvCdeCompTypeId(TransactionManager transactionManager, System.Decimal? _svCdeCompTypeId)
		{
			int count = -1;
			return GetBySvCdeCompTypeId(transactionManager, _svCdeCompTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_COMP_REPLY_SV_CDE_COMP_TYPE key.
		///		FK_SV_CDE_COMP_REPLY_SV_CDE_COMP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeCompReply objects.</returns>
		public TList<SvCdeCompReply> GetBySvCdeCompTypeId(TransactionManager transactionManager, System.Decimal? _svCdeCompTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeCompTypeId(transactionManager, _svCdeCompTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_COMP_REPLY_SV_CDE_COMP_TYPE key.
		///		fkSvCdeCompReplySvCdeCompType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeCompTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeCompReply objects.</returns>
		public TList<SvCdeCompReply> GetBySvCdeCompTypeId(System.Decimal? _svCdeCompTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCdeCompTypeId(null, _svCdeCompTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_COMP_REPLY_SV_CDE_COMP_TYPE key.
		///		fkSvCdeCompReplySvCdeCompType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeCompTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeCompReply objects.</returns>
		public TList<SvCdeCompReply> GetBySvCdeCompTypeId(System.Decimal? _svCdeCompTypeId, int start, int pageLength,out int count)
		{
			return GetBySvCdeCompTypeId(null, _svCdeCompTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_COMP_REPLY_SV_CDE_COMP_TYPE key.
		///		FK_SV_CDE_COMP_REPLY_SV_CDE_COMP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeCompReply objects.</returns>
		public abstract TList<SvCdeCompReply> GetBySvCdeCompTypeId(TransactionManager transactionManager, System.Decimal? _svCdeCompTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvCdeCompReply Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeCompReplyKey key, int start, int pageLength)
		{
			return GetBySvCdeCompReplyId(transactionManager, key.SvCdeCompReplyId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_CDE_COMP_REPLY index.
		/// </summary>
		/// <param name="_svCdeCompReplyId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompReply"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompReply GetBySvCdeCompReplyId(System.Decimal _svCdeCompReplyId)
		{
			int count = -1;
			return GetBySvCdeCompReplyId(null,_svCdeCompReplyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_COMP_REPLY index.
		/// </summary>
		/// <param name="_svCdeCompReplyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompReply"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompReply GetBySvCdeCompReplyId(System.Decimal _svCdeCompReplyId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeCompReplyId(null, _svCdeCompReplyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_COMP_REPLY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompReplyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompReply"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompReply GetBySvCdeCompReplyId(TransactionManager transactionManager, System.Decimal _svCdeCompReplyId)
		{
			int count = -1;
			return GetBySvCdeCompReplyId(transactionManager, _svCdeCompReplyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_COMP_REPLY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompReplyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompReply"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompReply GetBySvCdeCompReplyId(TransactionManager transactionManager, System.Decimal _svCdeCompReplyId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeCompReplyId(transactionManager, _svCdeCompReplyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_COMP_REPLY index.
		/// </summary>
		/// <param name="_svCdeCompReplyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompReply"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompReply GetBySvCdeCompReplyId(System.Decimal _svCdeCompReplyId, int start, int pageLength, out int count)
		{
			return GetBySvCdeCompReplyId(null, _svCdeCompReplyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_COMP_REPLY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompReplyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompReply"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCdeCompReply GetBySvCdeCompReplyId(TransactionManager transactionManager, System.Decimal _svCdeCompReplyId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvCdeCompReply&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvCdeCompReply&gt;"/></returns>
		public static TList<SvCdeCompReply> Fill(IDataReader reader, TList<SvCdeCompReply> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvCdeCompReply c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvCdeCompReply")
					.Append("|").Append((System.Decimal)reader["SV_CDE_COMP_REPLY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvCdeCompReply>(
					key.ToString(), // EntityTrackingKey
					"SvCdeCompReply",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvCdeCompReply();
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
					c.SvCdeCompReplyId = (System.Decimal)reader["SV_CDE_COMP_REPLY_ID"];
					c.OriginalSvCdeCompReplyId = c.SvCdeCompReplyId;
					c.RepTmpltAr = (System.String)reader["REP_TMPLT_AR"];
					c.RepTmpltEn = (System.String)reader["REP_TMPLT_EN"];
					c.SvCdeCompTypeId = Convert.IsDBNull(reader["SV_CDE_COMP_TYPE_ID"]) ? null : (System.Decimal?)reader["SV_CDE_COMP_TYPE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompReply"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeCompReply"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvCdeCompReply entity)
		{
			if (!reader.Read()) return;
			
			entity.SvCdeCompReplyId = (System.Decimal)reader[((int)SvCdeCompReplyColumn.SvCdeCompReplyId - 1)];
			entity.OriginalSvCdeCompReplyId = (System.Decimal)reader["SV_CDE_COMP_REPLY_ID"];
			entity.RepTmpltAr = (System.String)reader[((int)SvCdeCompReplyColumn.RepTmpltAr - 1)];
			entity.RepTmpltEn = (System.String)reader[((int)SvCdeCompReplyColumn.RepTmpltEn - 1)];
			entity.SvCdeCompTypeId = (reader.IsDBNull(((int)SvCdeCompReplyColumn.SvCdeCompTypeId - 1)))?null:(System.Decimal?)reader[((int)SvCdeCompReplyColumn.SvCdeCompTypeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompReply"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeCompReply"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvCdeCompReply entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvCdeCompReplyId = (System.Decimal)dataRow["SV_CDE_COMP_REPLY_ID"];
			entity.OriginalSvCdeCompReplyId = (System.Decimal)dataRow["SV_CDE_COMP_REPLY_ID"];
			entity.RepTmpltAr = (System.String)dataRow["REP_TMPLT_AR"];
			entity.RepTmpltEn = (System.String)dataRow["REP_TMPLT_EN"];
			entity.SvCdeCompTypeId = Convert.IsDBNull(dataRow["SV_CDE_COMP_TYPE_ID"]) ? null : (System.Decimal?)dataRow["SV_CDE_COMP_TYPE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeCompReply"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeCompReply Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeCompReply entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SvCdeCompTypeIdSource	
			if (CanDeepLoad(entity, "SvCdeCompType|SvCdeCompTypeIdSource", deepLoadType, innerList) 
				&& entity.SvCdeCompTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SvCdeCompTypeId ?? 0.0m);
				SvCdeCompType tmpEntity = EntityManager.LocateEntity<SvCdeCompType>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCdeCompType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCdeCompTypeIdSource = tmpEntity;
				else
					entity.SvCdeCompTypeIdSource = DataRepository.SvCdeCompTypeProvider.GetBySvCdeCompTypeId(transactionManager, (entity.SvCdeCompTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCdeCompTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCdeCompTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCdeCompTypeProvider.DeepLoad(transactionManager, entity.SvCdeCompTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCdeCompTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvCdeCompReplyId methods when available
			
			#region SvStudCompCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudComp>|SvStudCompCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudCompCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudCompCollection = DataRepository.SvStudCompProvider.GetBySvCdeCompReplyId(transactionManager, entity.SvCdeCompReplyId);

				if (deep && entity.SvStudCompCollection.Count > 0)
				{
					deepHandles.Add("SvStudCompCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudComp>) DataRepository.SvStudCompProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudCompCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvCdeCompReply object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvCdeCompReply instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeCompReply Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeCompReply entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SvCdeCompTypeIdSource
			if (CanDeepSave(entity, "SvCdeCompType|SvCdeCompTypeIdSource", deepSaveType, innerList) 
				&& entity.SvCdeCompTypeIdSource != null)
			{
				DataRepository.SvCdeCompTypeProvider.Save(transactionManager, entity.SvCdeCompTypeIdSource);
				entity.SvCdeCompTypeId = entity.SvCdeCompTypeIdSource.SvCdeCompTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SvStudComp>
				if (CanDeepSave(entity.SvStudCompCollection, "List<SvStudComp>|SvStudCompCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudComp child in entity.SvStudCompCollection)
					{
						if(child.SvCdeCompReplyIdSource != null)
						{
							child.SvCdeCompReplyId = child.SvCdeCompReplyIdSource.SvCdeCompReplyId;
						}
						else
						{
							child.SvCdeCompReplyId = entity.SvCdeCompReplyId;
						}

					}

					if (entity.SvStudCompCollection.Count > 0 || entity.SvStudCompCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudCompProvider.Save(transactionManager, entity.SvStudCompCollection);
						
						deepHandles.Add("SvStudCompCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudComp >) DataRepository.SvStudCompProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudCompCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvCdeCompReplyChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvCdeCompReply</c>
	///</summary>
	public enum SvCdeCompReplyChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SvCdeCompType</c> at SvCdeCompTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SvCdeCompType))]
		SvCdeCompType,
		///<summary>
		/// Collection of <c>SvCdeCompReply</c> as OneToMany for SvStudCompCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudComp>))]
		SvStudCompCollection,
	}
	
	#endregion SvCdeCompReplyChildEntityTypes
	
	#region SvCdeCompReplyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvCdeCompReplyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeCompReply"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeCompReplyFilterBuilder : SqlFilterBuilder<SvCdeCompReplyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeCompReplyFilterBuilder class.
		/// </summary>
		public SvCdeCompReplyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeCompReplyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeCompReplyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeCompReplyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeCompReplyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeCompReplyFilterBuilder
	
	#region SvCdeCompReplyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvCdeCompReplyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeCompReply"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeCompReplyParameterBuilder : ParameterizedSqlFilterBuilder<SvCdeCompReplyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeCompReplyParameterBuilder class.
		/// </summary>
		public SvCdeCompReplyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeCompReplyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeCompReplyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeCompReplyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeCompReplyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeCompReplyParameterBuilder
	
	#region SvCdeCompReplySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvCdeCompReplyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeCompReply"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvCdeCompReplySortBuilder : SqlSortBuilder<SvCdeCompReplyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeCompReplySqlSortBuilder class.
		/// </summary>
		public SvCdeCompReplySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvCdeCompReplySortBuilder
	
} // end namespace
