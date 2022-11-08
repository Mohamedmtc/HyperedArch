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
	/// This class is the base class for any <see cref="GsContactMethodDProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsContactMethodDProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsContactMethodD, UMIS_VER2.BusinessLyer.GsContactMethodDKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsContactMethodDKey key)
		{
			return Delete(transactionManager, key.GsContactMethodDId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsContactMethodDId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsContactMethodDId)
		{
			return Delete(null, _gsContactMethodDId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsContactMethodDId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsContactMethodDId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsContactMethodD Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsContactMethodDKey key, int start, int pageLength)
		{
			return GetByGsContactMethodDId(transactionManager, key.GsContactMethodDId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_CONTACT_METH_1 index.
		/// </summary>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsContactMethodD&gt;"/> class.</returns>
		public TList<GsContactMethodD> GetByGsCodeContactMethodId(System.Decimal _gsCodeContactMethodId)
		{
			int count = -1;
			return GetByGsCodeContactMethodId(null,_gsCodeContactMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CONTACT_METH_1 index.
		/// </summary>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsContactMethodD&gt;"/> class.</returns>
		public TList<GsContactMethodD> GetByGsCodeContactMethodId(System.Decimal _gsCodeContactMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeContactMethodId(null, _gsCodeContactMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CONTACT_METH_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsContactMethodD&gt;"/> class.</returns>
		public TList<GsContactMethodD> GetByGsCodeContactMethodId(TransactionManager transactionManager, System.Decimal _gsCodeContactMethodId)
		{
			int count = -1;
			return GetByGsCodeContactMethodId(transactionManager, _gsCodeContactMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CONTACT_METH_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsContactMethodD&gt;"/> class.</returns>
		public TList<GsContactMethodD> GetByGsCodeContactMethodId(TransactionManager transactionManager, System.Decimal _gsCodeContactMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeContactMethodId(transactionManager, _gsCodeContactMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CONTACT_METH_1 index.
		/// </summary>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsContactMethodD&gt;"/> class.</returns>
		public TList<GsContactMethodD> GetByGsCodeContactMethodId(System.Decimal _gsCodeContactMethodId, int start, int pageLength, out int count)
		{
			return GetByGsCodeContactMethodId(null, _gsCodeContactMethodId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CONTACT_METH_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsContactMethodD&gt;"/> class.</returns>
		public abstract TList<GsContactMethodD> GetByGsCodeContactMethodId(TransactionManager transactionManager, System.Decimal _gsCodeContactMethodId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CONTACT_METHOD_H__1 index.
		/// </summary>
		/// <param name="_gsContactMethodHId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsContactMethodD&gt;"/> class.</returns>
		public TList<GsContactMethodD> GetByGsContactMethodHId(System.Decimal _gsContactMethodHId)
		{
			int count = -1;
			return GetByGsContactMethodHId(null,_gsContactMethodHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CONTACT_METHOD_H__1 index.
		/// </summary>
		/// <param name="_gsContactMethodHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsContactMethodD&gt;"/> class.</returns>
		public TList<GsContactMethodD> GetByGsContactMethodHId(System.Decimal _gsContactMethodHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsContactMethodHId(null, _gsContactMethodHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CONTACT_METHOD_H__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsContactMethodHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsContactMethodD&gt;"/> class.</returns>
		public TList<GsContactMethodD> GetByGsContactMethodHId(TransactionManager transactionManager, System.Decimal _gsContactMethodHId)
		{
			int count = -1;
			return GetByGsContactMethodHId(transactionManager, _gsContactMethodHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CONTACT_METHOD_H__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsContactMethodHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsContactMethodD&gt;"/> class.</returns>
		public TList<GsContactMethodD> GetByGsContactMethodHId(TransactionManager transactionManager, System.Decimal _gsContactMethodHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsContactMethodHId(transactionManager, _gsContactMethodHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CONTACT_METHOD_H__1 index.
		/// </summary>
		/// <param name="_gsContactMethodHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsContactMethodD&gt;"/> class.</returns>
		public TList<GsContactMethodD> GetByGsContactMethodHId(System.Decimal _gsContactMethodHId, int start, int pageLength, out int count)
		{
			return GetByGsContactMethodHId(null, _gsContactMethodHId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CONTACT_METHOD_H__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsContactMethodHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsContactMethodD&gt;"/> class.</returns>
		public abstract TList<GsContactMethodD> GetByGsContactMethodHId(TransactionManager transactionManager, System.Decimal _gsContactMethodHId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CONTACT_METHOD_D index.
		/// </summary>
		/// <param name="_gsContactMethodDId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsContactMethodD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsContactMethodD GetByGsContactMethodDId(System.Decimal _gsContactMethodDId)
		{
			int count = -1;
			return GetByGsContactMethodDId(null,_gsContactMethodDId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CONTACT_METHOD_D index.
		/// </summary>
		/// <param name="_gsContactMethodDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsContactMethodD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsContactMethodD GetByGsContactMethodDId(System.Decimal _gsContactMethodDId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsContactMethodDId(null, _gsContactMethodDId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CONTACT_METHOD_D index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsContactMethodDId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsContactMethodD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsContactMethodD GetByGsContactMethodDId(TransactionManager transactionManager, System.Decimal _gsContactMethodDId)
		{
			int count = -1;
			return GetByGsContactMethodDId(transactionManager, _gsContactMethodDId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CONTACT_METHOD_D index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsContactMethodDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsContactMethodD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsContactMethodD GetByGsContactMethodDId(TransactionManager transactionManager, System.Decimal _gsContactMethodDId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsContactMethodDId(transactionManager, _gsContactMethodDId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CONTACT_METHOD_D index.
		/// </summary>
		/// <param name="_gsContactMethodDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsContactMethodD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsContactMethodD GetByGsContactMethodDId(System.Decimal _gsContactMethodDId, int start, int pageLength, out int count)
		{
			return GetByGsContactMethodDId(null, _gsContactMethodDId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CONTACT_METHOD_D index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsContactMethodDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsContactMethodD"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsContactMethodD GetByGsContactMethodDId(TransactionManager transactionManager, System.Decimal _gsContactMethodDId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsContactMethodD&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsContactMethodD&gt;"/></returns>
		public static TList<GsContactMethodD> Fill(IDataReader reader, TList<GsContactMethodD> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsContactMethodD c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsContactMethodD")
					.Append("|").Append((System.Decimal)reader["GS_CONTACT_METHOD_D_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsContactMethodD>(
					key.ToString(), // EntityTrackingKey
					"GsContactMethodD",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsContactMethodD();
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
					c.GsContactMethodDId = (System.Decimal)reader["GS_CONTACT_METHOD_D_ID"];
					c.OriginalGsContactMethodDId = c.GsContactMethodDId;
					c.GsContactMethodHId = (System.Decimal)reader["GS_CONTACT_METHOD_H_ID"];
					c.GsCodeContactMethodId = (System.Decimal)reader["GS_CODE_CONTACT_METHOD_ID"];
					c.MethodDescr = (System.String)reader["METHOD_DESCR"];
					c.MethodNotes = Convert.IsDBNull(reader["METHOD_NOTES"]) ? null : (System.String)reader["METHOD_NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsContactMethodD"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsContactMethodD"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsContactMethodD entity)
		{
			if (!reader.Read()) return;
			
			entity.GsContactMethodDId = (System.Decimal)reader[((int)GsContactMethodDColumn.GsContactMethodDId - 1)];
			entity.OriginalGsContactMethodDId = (System.Decimal)reader["GS_CONTACT_METHOD_D_ID"];
			entity.GsContactMethodHId = (System.Decimal)reader[((int)GsContactMethodDColumn.GsContactMethodHId - 1)];
			entity.GsCodeContactMethodId = (System.Decimal)reader[((int)GsContactMethodDColumn.GsCodeContactMethodId - 1)];
			entity.MethodDescr = (System.String)reader[((int)GsContactMethodDColumn.MethodDescr - 1)];
			entity.MethodNotes = (reader.IsDBNull(((int)GsContactMethodDColumn.MethodNotes - 1)))?null:(System.String)reader[((int)GsContactMethodDColumn.MethodNotes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsContactMethodD"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsContactMethodD"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsContactMethodD entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsContactMethodDId = (System.Decimal)dataRow["GS_CONTACT_METHOD_D_ID"];
			entity.OriginalGsContactMethodDId = (System.Decimal)dataRow["GS_CONTACT_METHOD_D_ID"];
			entity.GsContactMethodHId = (System.Decimal)dataRow["GS_CONTACT_METHOD_H_ID"];
			entity.GsCodeContactMethodId = (System.Decimal)dataRow["GS_CODE_CONTACT_METHOD_ID"];
			entity.MethodDescr = (System.String)dataRow["METHOD_DESCR"];
			entity.MethodNotes = Convert.IsDBNull(dataRow["METHOD_NOTES"]) ? null : (System.String)dataRow["METHOD_NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsContactMethodD"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsContactMethodD Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsContactMethodD entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsContactMethodHIdSource	
			if (CanDeepLoad(entity, "GsContactMethodH|GsContactMethodHIdSource", deepLoadType, innerList) 
				&& entity.GsContactMethodHIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsContactMethodHId;
				GsContactMethodH tmpEntity = EntityManager.LocateEntity<GsContactMethodH>(EntityLocator.ConstructKeyFromPkItems(typeof(GsContactMethodH), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsContactMethodHIdSource = tmpEntity;
				else
					entity.GsContactMethodHIdSource = DataRepository.GsContactMethodHProvider.GetByGsContactMethodHId(transactionManager, entity.GsContactMethodHId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsContactMethodHIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsContactMethodHIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsContactMethodHProvider.DeepLoad(transactionManager, entity.GsContactMethodHIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsContactMethodHIdSource

			#region GsCodeContactMethodIdSource	
			if (CanDeepLoad(entity, "GsCodeContactMethod|GsCodeContactMethodIdSource", deepLoadType, innerList) 
				&& entity.GsCodeContactMethodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeContactMethodId;
				GsCodeContactMethod tmpEntity = EntityManager.LocateEntity<GsCodeContactMethod>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeContactMethod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeContactMethodIdSource = tmpEntity;
				else
					entity.GsCodeContactMethodIdSource = DataRepository.GsCodeContactMethodProvider.GetByGsCodeContactMethodId(transactionManager, entity.GsCodeContactMethodId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeContactMethodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeContactMethodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeContactMethodProvider.DeepLoad(transactionManager, entity.GsCodeContactMethodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeContactMethodIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsContactMethodD object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsContactMethodD instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsContactMethodD Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsContactMethodD entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsContactMethodHIdSource
			if (CanDeepSave(entity, "GsContactMethodH|GsContactMethodHIdSource", deepSaveType, innerList) 
				&& entity.GsContactMethodHIdSource != null)
			{
				DataRepository.GsContactMethodHProvider.Save(transactionManager, entity.GsContactMethodHIdSource);
				entity.GsContactMethodHId = entity.GsContactMethodHIdSource.GsContactMethodHId;
			}
			#endregion 
			
			#region GsCodeContactMethodIdSource
			if (CanDeepSave(entity, "GsCodeContactMethod|GsCodeContactMethodIdSource", deepSaveType, innerList) 
				&& entity.GsCodeContactMethodIdSource != null)
			{
				DataRepository.GsCodeContactMethodProvider.Save(transactionManager, entity.GsCodeContactMethodIdSource);
				entity.GsCodeContactMethodId = entity.GsCodeContactMethodIdSource.GsCodeContactMethodId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
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
	
	#region GsContactMethodDChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsContactMethodD</c>
	///</summary>
	public enum GsContactMethodDChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsContactMethodH</c> at GsContactMethodHIdSource
		///</summary>
		[ChildEntityType(typeof(GsContactMethodH))]
		GsContactMethodH,
		
		///<summary>
		/// Composite Property for <c>GsCodeContactMethod</c> at GsCodeContactMethodIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeContactMethod))]
		GsCodeContactMethod,
	}
	
	#endregion GsContactMethodDChildEntityTypes
	
	#region GsContactMethodDFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsContactMethodDColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsContactMethodD"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsContactMethodDFilterBuilder : SqlFilterBuilder<GsContactMethodDColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsContactMethodDFilterBuilder class.
		/// </summary>
		public GsContactMethodDFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsContactMethodDFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsContactMethodDFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsContactMethodDFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsContactMethodDFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsContactMethodDFilterBuilder
	
	#region GsContactMethodDParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsContactMethodDColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsContactMethodD"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsContactMethodDParameterBuilder : ParameterizedSqlFilterBuilder<GsContactMethodDColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsContactMethodDParameterBuilder class.
		/// </summary>
		public GsContactMethodDParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsContactMethodDParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsContactMethodDParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsContactMethodDParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsContactMethodDParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsContactMethodDParameterBuilder
	
	#region GsContactMethodDSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsContactMethodDColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsContactMethodD"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsContactMethodDSortBuilder : SqlSortBuilder<GsContactMethodDColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsContactMethodDSqlSortBuilder class.
		/// </summary>
		public GsContactMethodDSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsContactMethodDSortBuilder
	
} // end namespace
