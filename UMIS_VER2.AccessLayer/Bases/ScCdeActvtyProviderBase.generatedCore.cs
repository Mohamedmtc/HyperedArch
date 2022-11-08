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
	/// This class is the base class for any <see cref="ScCdeActvtyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScCdeActvtyProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScCdeActvty, UMIS_VER2.BusinessLyer.ScCdeActvtyKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScCdeActvtyKey key)
		{
			return Delete(transactionManager, key.ScCdeActvtyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scCdeActvtyId">الانشطة بالجدول الدراسي. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scCdeActvtyId)
		{
			return Delete(null, _scCdeActvtyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeActvtyId">الانشطة بالجدول الدراسي. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scCdeActvtyId);		
		
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
		public override UMIS_VER2.BusinessLyer.ScCdeActvty Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScCdeActvtyKey key, int start, int pageLength)
		{
			return GetByScCdeActvtyId(transactionManager, key.ScCdeActvtyId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_CDE_ACTVTY index.
		/// </summary>
		/// <param name="_scCdeActvtyId">الانشطة بالجدول الدراسي</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeActvty GetByScCdeActvtyId(System.Decimal _scCdeActvtyId)
		{
			int count = -1;
			return GetByScCdeActvtyId(null,_scCdeActvtyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_ACTVTY index.
		/// </summary>
		/// <param name="_scCdeActvtyId">الانشطة بالجدول الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeActvty GetByScCdeActvtyId(System.Decimal _scCdeActvtyId, int start, int pageLength)
		{
			int count = -1;
			return GetByScCdeActvtyId(null, _scCdeActvtyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_ACTVTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeActvtyId">الانشطة بالجدول الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeActvty GetByScCdeActvtyId(TransactionManager transactionManager, System.Decimal _scCdeActvtyId)
		{
			int count = -1;
			return GetByScCdeActvtyId(transactionManager, _scCdeActvtyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_ACTVTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeActvtyId">الانشطة بالجدول الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeActvty GetByScCdeActvtyId(TransactionManager transactionManager, System.Decimal _scCdeActvtyId, int start, int pageLength)
		{
			int count = -1;
			return GetByScCdeActvtyId(transactionManager, _scCdeActvtyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_ACTVTY index.
		/// </summary>
		/// <param name="_scCdeActvtyId">الانشطة بالجدول الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeActvty GetByScCdeActvtyId(System.Decimal _scCdeActvtyId, int start, int pageLength, out int count)
		{
			return GetByScCdeActvtyId(null, _scCdeActvtyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_ACTVTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeActvtyId">الانشطة بالجدول الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScCdeActvty GetByScCdeActvtyId(TransactionManager transactionManager, System.Decimal _scCdeActvtyId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SC_CDE_ACTVTY_AR index.
		/// </summary>
		/// <param name="_actvtyAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeActvty GetByActvtyAr(System.String _actvtyAr)
		{
			int count = -1;
			return GetByActvtyAr(null,_actvtyAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_CDE_ACTVTY_AR index.
		/// </summary>
		/// <param name="_actvtyAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeActvty GetByActvtyAr(System.String _actvtyAr, int start, int pageLength)
		{
			int count = -1;
			return GetByActvtyAr(null, _actvtyAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_CDE_ACTVTY_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_actvtyAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeActvty GetByActvtyAr(TransactionManager transactionManager, System.String _actvtyAr)
		{
			int count = -1;
			return GetByActvtyAr(transactionManager, _actvtyAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_CDE_ACTVTY_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_actvtyAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeActvty GetByActvtyAr(TransactionManager transactionManager, System.String _actvtyAr, int start, int pageLength)
		{
			int count = -1;
			return GetByActvtyAr(transactionManager, _actvtyAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_CDE_ACTVTY_AR index.
		/// </summary>
		/// <param name="_actvtyAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeActvty GetByActvtyAr(System.String _actvtyAr, int start, int pageLength, out int count)
		{
			return GetByActvtyAr(null, _actvtyAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_CDE_ACTVTY_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_actvtyAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScCdeActvty GetByActvtyAr(TransactionManager transactionManager, System.String _actvtyAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SC_CDE_ACTVTY_EN index.
		/// </summary>
		/// <param name="_actvtyEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeActvty GetByActvtyEn(System.String _actvtyEn)
		{
			int count = -1;
			return GetByActvtyEn(null,_actvtyEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_CDE_ACTVTY_EN index.
		/// </summary>
		/// <param name="_actvtyEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeActvty GetByActvtyEn(System.String _actvtyEn, int start, int pageLength)
		{
			int count = -1;
			return GetByActvtyEn(null, _actvtyEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_CDE_ACTVTY_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_actvtyEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeActvty GetByActvtyEn(TransactionManager transactionManager, System.String _actvtyEn)
		{
			int count = -1;
			return GetByActvtyEn(transactionManager, _actvtyEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_CDE_ACTVTY_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_actvtyEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeActvty GetByActvtyEn(TransactionManager transactionManager, System.String _actvtyEn, int start, int pageLength)
		{
			int count = -1;
			return GetByActvtyEn(transactionManager, _actvtyEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_CDE_ACTVTY_EN index.
		/// </summary>
		/// <param name="_actvtyEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScCdeActvty GetByActvtyEn(System.String _actvtyEn, int start, int pageLength, out int count)
		{
			return GetByActvtyEn(null, _actvtyEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_CDE_ACTVTY_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_actvtyEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScCdeActvty GetByActvtyEn(TransactionManager transactionManager, System.String _actvtyEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScCdeActvty&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScCdeActvty&gt;"/></returns>
		public static TList<ScCdeActvty> Fill(IDataReader reader, TList<ScCdeActvty> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScCdeActvty c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScCdeActvty")
					.Append("|").Append((System.Decimal)reader["SC_CDE_ACTVTY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScCdeActvty>(
					key.ToString(), // EntityTrackingKey
					"ScCdeActvty",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScCdeActvty();
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
					c.ScCdeActvtyId = (System.Decimal)reader["SC_CDE_ACTVTY_ID"];
					c.OriginalScCdeActvtyId = c.ScCdeActvtyId;
					c.ActvtyAr = (System.String)reader["ACTVTY_AR"];
					c.ActvtyEn = (System.String)reader["ACTVTY_EN"];
					c.ActiveFlg = (System.Decimal)reader["ACTIVE_FLG"];
					c.LastDate = (System.DateTime)reader["LAST_DATE"];
					c.SeUserId = (System.Decimal)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScCdeActvty entity)
		{
			if (!reader.Read()) return;
			
			entity.ScCdeActvtyId = (System.Decimal)reader[((int)ScCdeActvtyColumn.ScCdeActvtyId - 1)];
			entity.OriginalScCdeActvtyId = (System.Decimal)reader["SC_CDE_ACTVTY_ID"];
			entity.ActvtyAr = (System.String)reader[((int)ScCdeActvtyColumn.ActvtyAr - 1)];
			entity.ActvtyEn = (System.String)reader[((int)ScCdeActvtyColumn.ActvtyEn - 1)];
			entity.ActiveFlg = (System.Decimal)reader[((int)ScCdeActvtyColumn.ActiveFlg - 1)];
			entity.LastDate = (System.DateTime)reader[((int)ScCdeActvtyColumn.LastDate - 1)];
			entity.SeUserId = (System.Decimal)reader[((int)ScCdeActvtyColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScCdeActvty entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScCdeActvtyId = (System.Decimal)dataRow["SC_CDE_ACTVTY_ID"];
			entity.OriginalScCdeActvtyId = (System.Decimal)dataRow["SC_CDE_ACTVTY_ID"];
			entity.ActvtyAr = (System.String)dataRow["ACTVTY_AR"];
			entity.ActvtyEn = (System.String)dataRow["ACTVTY_EN"];
			entity.ActiveFlg = (System.Decimal)dataRow["ACTIVE_FLG"];
			entity.LastDate = (System.DateTime)dataRow["LAST_DATE"];
			entity.SeUserId = (System.Decimal)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScCdeActvty"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScCdeActvty Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScCdeActvty entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByScCdeActvtyId methods when available
			
			#region ScSchdlSlotCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSchdlSlot>|ScSchdlSlotCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlSlotCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSchdlSlotCollection = DataRepository.ScSchdlSlotProvider.GetByScCdeActvtyId(transactionManager, entity.ScCdeActvtyId);

				if (deep && entity.ScSchdlSlotCollection.Count > 0)
				{
					deepHandles.Add("ScSchdlSlotCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSchdlSlot>) DataRepository.ScSchdlSlotProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSchdlSlotCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScCdeActvty object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScCdeActvty instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScCdeActvty Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScCdeActvty entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<ScSchdlSlot>
				if (CanDeepSave(entity.ScSchdlSlotCollection, "List<ScSchdlSlot>|ScSchdlSlotCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSchdlSlot child in entity.ScSchdlSlotCollection)
					{
						if(child.ScCdeActvtyIdSource != null)
						{
							child.ScCdeActvtyId = child.ScCdeActvtyIdSource.ScCdeActvtyId;
						}
						else
						{
							child.ScCdeActvtyId = entity.ScCdeActvtyId;
						}

					}

					if (entity.ScSchdlSlotCollection.Count > 0 || entity.ScSchdlSlotCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSchdlSlotProvider.Save(transactionManager, entity.ScSchdlSlotCollection);
						
						deepHandles.Add("ScSchdlSlotCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSchdlSlot >) DataRepository.ScSchdlSlotProvider.DeepSave,
							new object[] { transactionManager, entity.ScSchdlSlotCollection, deepSaveType, childTypes, innerList }
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
	
	#region ScCdeActvtyChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScCdeActvty</c>
	///</summary>
	public enum ScCdeActvtyChildEntityTypes
	{
		///<summary>
		/// Collection of <c>ScCdeActvty</c> as OneToMany for ScSchdlSlotCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSchdlSlot>))]
		ScSchdlSlotCollection,
	}
	
	#endregion ScCdeActvtyChildEntityTypes
	
	#region ScCdeActvtyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScCdeActvtyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScCdeActvty"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScCdeActvtyFilterBuilder : SqlFilterBuilder<ScCdeActvtyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScCdeActvtyFilterBuilder class.
		/// </summary>
		public ScCdeActvtyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScCdeActvtyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScCdeActvtyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScCdeActvtyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScCdeActvtyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScCdeActvtyFilterBuilder
	
	#region ScCdeActvtyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScCdeActvtyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScCdeActvty"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScCdeActvtyParameterBuilder : ParameterizedSqlFilterBuilder<ScCdeActvtyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScCdeActvtyParameterBuilder class.
		/// </summary>
		public ScCdeActvtyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScCdeActvtyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScCdeActvtyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScCdeActvtyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScCdeActvtyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScCdeActvtyParameterBuilder
	
	#region ScCdeActvtySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScCdeActvtyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScCdeActvty"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScCdeActvtySortBuilder : SqlSortBuilder<ScCdeActvtyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScCdeActvtySqlSortBuilder class.
		/// </summary>
		public ScCdeActvtySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScCdeActvtySortBuilder
	
} // end namespace
