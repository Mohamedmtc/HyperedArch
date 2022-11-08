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
	/// This class is the base class for any <see cref="GsCommRecomProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCommRecomProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCommRecom, UMIS_VER2.BusinessLyer.GsCommRecomKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCommRecomKey key)
		{
			return Delete(transactionManager, key.GsCommRecomId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCommRecomId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCommRecomId)
		{
			return Delete(null, _gsCommRecomId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommRecomId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCommRecomId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_RECOM_GS_COMM key.
		///		FK_GS_COMM_RECOM_GS_COMM Description: 
		/// </summary>
		/// <param name="_gsCommId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommRecom objects.</returns>
		public TList<GsCommRecom> GetByGsCommId(System.Decimal _gsCommId)
		{
			int count = -1;
			return GetByGsCommId(_gsCommId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_RECOM_GS_COMM key.
		///		FK_GS_COMM_RECOM_GS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommRecom objects.</returns>
		/// <remarks></remarks>
		public TList<GsCommRecom> GetByGsCommId(TransactionManager transactionManager, System.Decimal _gsCommId)
		{
			int count = -1;
			return GetByGsCommId(transactionManager, _gsCommId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_RECOM_GS_COMM key.
		///		FK_GS_COMM_RECOM_GS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommRecom objects.</returns>
		public TList<GsCommRecom> GetByGsCommId(TransactionManager transactionManager, System.Decimal _gsCommId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommId(transactionManager, _gsCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_RECOM_GS_COMM key.
		///		fkGsCommRecomGsComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCommId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommRecom objects.</returns>
		public TList<GsCommRecom> GetByGsCommId(System.Decimal _gsCommId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCommId(null, _gsCommId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_RECOM_GS_COMM key.
		///		fkGsCommRecomGsComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCommId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommRecom objects.</returns>
		public TList<GsCommRecom> GetByGsCommId(System.Decimal _gsCommId, int start, int pageLength,out int count)
		{
			return GetByGsCommId(null, _gsCommId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_RECOM_GS_COMM key.
		///		FK_GS_COMM_RECOM_GS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommRecom objects.</returns>
		public abstract TList<GsCommRecom> GetByGsCommId(TransactionManager transactionManager, System.Decimal _gsCommId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsCommRecom Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCommRecomKey key, int start, int pageLength)
		{
			return GetByGsCommRecomId(transactionManager, key.GsCommRecomId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_COMM_RECOM index.
		/// </summary>
		/// <param name="_recomDesc"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommRecom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommRecom GetByRecomDesc(System.String _recomDesc)
		{
			int count = -1;
			return GetByRecomDesc(null,_recomDesc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COMM_RECOM index.
		/// </summary>
		/// <param name="_recomDesc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommRecom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommRecom GetByRecomDesc(System.String _recomDesc, int start, int pageLength)
		{
			int count = -1;
			return GetByRecomDesc(null, _recomDesc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COMM_RECOM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_recomDesc"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommRecom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommRecom GetByRecomDesc(TransactionManager transactionManager, System.String _recomDesc)
		{
			int count = -1;
			return GetByRecomDesc(transactionManager, _recomDesc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COMM_RECOM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_recomDesc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommRecom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommRecom GetByRecomDesc(TransactionManager transactionManager, System.String _recomDesc, int start, int pageLength)
		{
			int count = -1;
			return GetByRecomDesc(transactionManager, _recomDesc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COMM_RECOM index.
		/// </summary>
		/// <param name="_recomDesc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommRecom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommRecom GetByRecomDesc(System.String _recomDesc, int start, int pageLength, out int count)
		{
			return GetByRecomDesc(null, _recomDesc, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COMM_RECOM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_recomDesc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommRecom"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCommRecom GetByRecomDesc(TransactionManager transactionManager, System.String _recomDesc, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_COMM_RECOM index.
		/// </summary>
		/// <param name="_gsCommRecomId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommRecom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommRecom GetByGsCommRecomId(System.Decimal _gsCommRecomId)
		{
			int count = -1;
			return GetByGsCommRecomId(null,_gsCommRecomId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_RECOM index.
		/// </summary>
		/// <param name="_gsCommRecomId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommRecom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommRecom GetByGsCommRecomId(System.Decimal _gsCommRecomId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommRecomId(null, _gsCommRecomId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_RECOM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommRecomId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommRecom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommRecom GetByGsCommRecomId(TransactionManager transactionManager, System.Decimal _gsCommRecomId)
		{
			int count = -1;
			return GetByGsCommRecomId(transactionManager, _gsCommRecomId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_RECOM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommRecomId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommRecom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommRecom GetByGsCommRecomId(TransactionManager transactionManager, System.Decimal _gsCommRecomId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommRecomId(transactionManager, _gsCommRecomId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_RECOM index.
		/// </summary>
		/// <param name="_gsCommRecomId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommRecom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommRecom GetByGsCommRecomId(System.Decimal _gsCommRecomId, int start, int pageLength, out int count)
		{
			return GetByGsCommRecomId(null, _gsCommRecomId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_RECOM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommRecomId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommRecom"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCommRecom GetByGsCommRecomId(TransactionManager transactionManager, System.Decimal _gsCommRecomId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCommRecom&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCommRecom&gt;"/></returns>
		public static TList<GsCommRecom> Fill(IDataReader reader, TList<GsCommRecom> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCommRecom c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCommRecom")
					.Append("|").Append((System.Decimal)reader["GS_COMM_RECOM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCommRecom>(
					key.ToString(), // EntityTrackingKey
					"GsCommRecom",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCommRecom();
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
					c.GsCommRecomId = (System.Decimal)reader["GS_COMM_RECOM_ID"];
					c.OriginalGsCommRecomId = c.GsCommRecomId;
					c.GsCommId = (System.Decimal)reader["GS_COMM_ID"];
					c.RecomDesc = (System.String)reader["RECOM_DESC"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCommRecom"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCommRecom"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCommRecom entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCommRecomId = (System.Decimal)reader[((int)GsCommRecomColumn.GsCommRecomId - 1)];
			entity.OriginalGsCommRecomId = (System.Decimal)reader["GS_COMM_RECOM_ID"];
			entity.GsCommId = (System.Decimal)reader[((int)GsCommRecomColumn.GsCommId - 1)];
			entity.RecomDesc = (System.String)reader[((int)GsCommRecomColumn.RecomDesc - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCommRecom"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCommRecom"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCommRecom entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCommRecomId = (System.Decimal)dataRow["GS_COMM_RECOM_ID"];
			entity.OriginalGsCommRecomId = (System.Decimal)dataRow["GS_COMM_RECOM_ID"];
			entity.GsCommId = (System.Decimal)dataRow["GS_COMM_ID"];
			entity.RecomDesc = (System.String)dataRow["RECOM_DESC"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCommRecom"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCommRecom Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCommRecom entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCommIdSource	
			if (CanDeepLoad(entity, "GsComm|GsCommIdSource", deepLoadType, innerList) 
				&& entity.GsCommIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCommId;
				GsComm tmpEntity = EntityManager.LocateEntity<GsComm>(EntityLocator.ConstructKeyFromPkItems(typeof(GsComm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCommIdSource = tmpEntity;
				else
					entity.GsCommIdSource = DataRepository.GsCommProvider.GetByGsCommId(transactionManager, entity.GsCommId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCommIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCommIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCommProvider.DeepLoad(transactionManager, entity.GsCommIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCommIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCommRecom object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCommRecom instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCommRecom Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCommRecom entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCommIdSource
			if (CanDeepSave(entity, "GsComm|GsCommIdSource", deepSaveType, innerList) 
				&& entity.GsCommIdSource != null)
			{
				DataRepository.GsCommProvider.Save(transactionManager, entity.GsCommIdSource);
				entity.GsCommId = entity.GsCommIdSource.GsCommId;
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
	
	#region GsCommRecomChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCommRecom</c>
	///</summary>
	public enum GsCommRecomChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsComm</c> at GsCommIdSource
		///</summary>
		[ChildEntityType(typeof(GsComm))]
		GsComm,
	}
	
	#endregion GsCommRecomChildEntityTypes
	
	#region GsCommRecomFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCommRecomColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCommRecom"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCommRecomFilterBuilder : SqlFilterBuilder<GsCommRecomColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCommRecomFilterBuilder class.
		/// </summary>
		public GsCommRecomFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCommRecomFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCommRecomFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCommRecomFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCommRecomFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCommRecomFilterBuilder
	
	#region GsCommRecomParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCommRecomColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCommRecom"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCommRecomParameterBuilder : ParameterizedSqlFilterBuilder<GsCommRecomColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCommRecomParameterBuilder class.
		/// </summary>
		public GsCommRecomParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCommRecomParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCommRecomParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCommRecomParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCommRecomParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCommRecomParameterBuilder
	
	#region GsCommRecomSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCommRecomColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCommRecom"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCommRecomSortBuilder : SqlSortBuilder<GsCommRecomColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCommRecomSqlSortBuilder class.
		/// </summary>
		public GsCommRecomSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCommRecomSortBuilder
	
} // end namespace
