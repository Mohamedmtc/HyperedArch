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
	/// This class is the base class for any <see cref="GsCommDuttyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCommDuttyProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCommDutty, UMIS_VER2.BusinessLyer.GsCommDuttyKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCommDuttyKey key)
		{
			return Delete(transactionManager, key.GsCommDuttyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCommDuttyId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCommDuttyId)
		{
			return Delete(null, _gsCommDuttyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommDuttyId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCommDuttyId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_DUTTY_GS_COMM key.
		///		FK_GS_COMM_DUTTY_GS_COMM Description: 
		/// </summary>
		/// <param name="_gsCommId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommDutty objects.</returns>
		public TList<GsCommDutty> GetByGsCommId(System.Decimal _gsCommId)
		{
			int count = -1;
			return GetByGsCommId(_gsCommId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_DUTTY_GS_COMM key.
		///		FK_GS_COMM_DUTTY_GS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommDutty objects.</returns>
		/// <remarks></remarks>
		public TList<GsCommDutty> GetByGsCommId(TransactionManager transactionManager, System.Decimal _gsCommId)
		{
			int count = -1;
			return GetByGsCommId(transactionManager, _gsCommId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_DUTTY_GS_COMM key.
		///		FK_GS_COMM_DUTTY_GS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommDutty objects.</returns>
		public TList<GsCommDutty> GetByGsCommId(TransactionManager transactionManager, System.Decimal _gsCommId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommId(transactionManager, _gsCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_DUTTY_GS_COMM key.
		///		fkGsCommDuttyGsComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCommId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommDutty objects.</returns>
		public TList<GsCommDutty> GetByGsCommId(System.Decimal _gsCommId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCommId(null, _gsCommId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_DUTTY_GS_COMM key.
		///		fkGsCommDuttyGsComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCommId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommDutty objects.</returns>
		public TList<GsCommDutty> GetByGsCommId(System.Decimal _gsCommId, int start, int pageLength,out int count)
		{
			return GetByGsCommId(null, _gsCommId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_DUTTY_GS_COMM key.
		///		FK_GS_COMM_DUTTY_GS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommDutty objects.</returns>
		public abstract TList<GsCommDutty> GetByGsCommId(TransactionManager transactionManager, System.Decimal _gsCommId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsCommDutty Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCommDuttyKey key, int start, int pageLength)
		{
			return GetByGsCommDuttyId(transactionManager, key.GsCommDuttyId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_COMM_DUTTY index.
		/// </summary>
		/// <param name="_gsCommDuttyId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommDutty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommDutty GetByGsCommDuttyId(System.Decimal _gsCommDuttyId)
		{
			int count = -1;
			return GetByGsCommDuttyId(null,_gsCommDuttyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_DUTTY index.
		/// </summary>
		/// <param name="_gsCommDuttyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommDutty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommDutty GetByGsCommDuttyId(System.Decimal _gsCommDuttyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommDuttyId(null, _gsCommDuttyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_DUTTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommDuttyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommDutty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommDutty GetByGsCommDuttyId(TransactionManager transactionManager, System.Decimal _gsCommDuttyId)
		{
			int count = -1;
			return GetByGsCommDuttyId(transactionManager, _gsCommDuttyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_DUTTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommDuttyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommDutty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommDutty GetByGsCommDuttyId(TransactionManager transactionManager, System.Decimal _gsCommDuttyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommDuttyId(transactionManager, _gsCommDuttyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_DUTTY index.
		/// </summary>
		/// <param name="_gsCommDuttyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommDutty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommDutty GetByGsCommDuttyId(System.Decimal _gsCommDuttyId, int start, int pageLength, out int count)
		{
			return GetByGsCommDuttyId(null, _gsCommDuttyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_DUTTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommDuttyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommDutty"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCommDutty GetByGsCommDuttyId(TransactionManager transactionManager, System.Decimal _gsCommDuttyId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_COMM_DUTTY_DESC index.
		/// </summary>
		/// <param name="_gsCommId"></param>
		/// <param name="_duttyDesc"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommDutty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommDutty GetByGsCommIdDuttyDesc(System.Decimal _gsCommId, System.String _duttyDesc)
		{
			int count = -1;
			return GetByGsCommIdDuttyDesc(null,_gsCommId, _duttyDesc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COMM_DUTTY_DESC index.
		/// </summary>
		/// <param name="_gsCommId"></param>
		/// <param name="_duttyDesc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommDutty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommDutty GetByGsCommIdDuttyDesc(System.Decimal _gsCommId, System.String _duttyDesc, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommIdDuttyDesc(null, _gsCommId, _duttyDesc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COMM_DUTTY_DESC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId"></param>
		/// <param name="_duttyDesc"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommDutty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommDutty GetByGsCommIdDuttyDesc(TransactionManager transactionManager, System.Decimal _gsCommId, System.String _duttyDesc)
		{
			int count = -1;
			return GetByGsCommIdDuttyDesc(transactionManager, _gsCommId, _duttyDesc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COMM_DUTTY_DESC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId"></param>
		/// <param name="_duttyDesc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommDutty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommDutty GetByGsCommIdDuttyDesc(TransactionManager transactionManager, System.Decimal _gsCommId, System.String _duttyDesc, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommIdDuttyDesc(transactionManager, _gsCommId, _duttyDesc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COMM_DUTTY_DESC index.
		/// </summary>
		/// <param name="_gsCommId"></param>
		/// <param name="_duttyDesc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommDutty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommDutty GetByGsCommIdDuttyDesc(System.Decimal _gsCommId, System.String _duttyDesc, int start, int pageLength, out int count)
		{
			return GetByGsCommIdDuttyDesc(null, _gsCommId, _duttyDesc, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COMM_DUTTY_DESC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId"></param>
		/// <param name="_duttyDesc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommDutty"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCommDutty GetByGsCommIdDuttyDesc(TransactionManager transactionManager, System.Decimal _gsCommId, System.String _duttyDesc, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCommDutty&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCommDutty&gt;"/></returns>
		public static TList<GsCommDutty> Fill(IDataReader reader, TList<GsCommDutty> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCommDutty c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCommDutty")
					.Append("|").Append((System.Decimal)reader["GS_COMM_DUTTY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCommDutty>(
					key.ToString(), // EntityTrackingKey
					"GsCommDutty",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCommDutty();
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
					c.GsCommDuttyId = (System.Decimal)reader["GS_COMM_DUTTY_ID"];
					c.OriginalGsCommDuttyId = c.GsCommDuttyId;
					c.GsCommId = (System.Decimal)reader["GS_COMM_ID"];
					c.DuttyDesc = (System.String)reader["DUTTY_DESC"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCommDutty"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCommDutty"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCommDutty entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCommDuttyId = (System.Decimal)reader[((int)GsCommDuttyColumn.GsCommDuttyId - 1)];
			entity.OriginalGsCommDuttyId = (System.Decimal)reader["GS_COMM_DUTTY_ID"];
			entity.GsCommId = (System.Decimal)reader[((int)GsCommDuttyColumn.GsCommId - 1)];
			entity.DuttyDesc = (System.String)reader[((int)GsCommDuttyColumn.DuttyDesc - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCommDutty"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCommDutty"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCommDutty entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCommDuttyId = (System.Decimal)dataRow["GS_COMM_DUTTY_ID"];
			entity.OriginalGsCommDuttyId = (System.Decimal)dataRow["GS_COMM_DUTTY_ID"];
			entity.GsCommId = (System.Decimal)dataRow["GS_COMM_ID"];
			entity.DuttyDesc = (System.String)dataRow["DUTTY_DESC"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCommDutty"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCommDutty Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCommDutty entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCommDutty object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCommDutty instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCommDutty Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCommDutty entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GsCommDuttyChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCommDutty</c>
	///</summary>
	public enum GsCommDuttyChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsComm</c> at GsCommIdSource
		///</summary>
		[ChildEntityType(typeof(GsComm))]
		GsComm,
	}
	
	#endregion GsCommDuttyChildEntityTypes
	
	#region GsCommDuttyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCommDuttyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCommDutty"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCommDuttyFilterBuilder : SqlFilterBuilder<GsCommDuttyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCommDuttyFilterBuilder class.
		/// </summary>
		public GsCommDuttyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCommDuttyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCommDuttyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCommDuttyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCommDuttyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCommDuttyFilterBuilder
	
	#region GsCommDuttyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCommDuttyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCommDutty"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCommDuttyParameterBuilder : ParameterizedSqlFilterBuilder<GsCommDuttyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCommDuttyParameterBuilder class.
		/// </summary>
		public GsCommDuttyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCommDuttyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCommDuttyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCommDuttyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCommDuttyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCommDuttyParameterBuilder
	
	#region GsCommDuttySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCommDuttyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCommDutty"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCommDuttySortBuilder : SqlSortBuilder<GsCommDuttyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCommDuttySqlSortBuilder class.
		/// </summary>
		public GsCommDuttySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCommDuttySortBuilder
	
} // end namespace
