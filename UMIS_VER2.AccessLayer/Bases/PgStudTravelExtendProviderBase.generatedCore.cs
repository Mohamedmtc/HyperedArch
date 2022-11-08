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
	/// This class is the base class for any <see cref="PgStudTravelExtendProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgStudTravelExtendProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgStudTravelExtend, UMIS_VER2.BusinessLyer.PgStudTravelExtendKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStudTravelExtendKey key)
		{
			return Delete(transactionManager, key.PgStudTravelExtendId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgStudTravelExtendId)
		{
			return Delete(null, _pgStudTravelExtendId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgStudTravelExtendId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_EXTEND_PG_STUD_TRAVEL key.
		///		FK_PG_STUD_TRAVEL_EXTEND_PG_STUD_TRAVEL Description: 
		/// </summary>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravelExtend objects.</returns>
		public TList<PgStudTravelExtend> GetByPgStudTravelId(System.Decimal _pgStudTravelId)
		{
			int count = -1;
			return GetByPgStudTravelId(_pgStudTravelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_EXTEND_PG_STUD_TRAVEL key.
		///		FK_PG_STUD_TRAVEL_EXTEND_PG_STUD_TRAVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravelExtend objects.</returns>
		/// <remarks></remarks>
		public TList<PgStudTravelExtend> GetByPgStudTravelId(TransactionManager transactionManager, System.Decimal _pgStudTravelId)
		{
			int count = -1;
			return GetByPgStudTravelId(transactionManager, _pgStudTravelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_EXTEND_PG_STUD_TRAVEL key.
		///		FK_PG_STUD_TRAVEL_EXTEND_PG_STUD_TRAVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravelExtend objects.</returns>
		public TList<PgStudTravelExtend> GetByPgStudTravelId(TransactionManager transactionManager, System.Decimal _pgStudTravelId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgStudTravelId(transactionManager, _pgStudTravelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_EXTEND_PG_STUD_TRAVEL key.
		///		fkPgStudTravelExtendPgStudTravel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravelExtend objects.</returns>
		public TList<PgStudTravelExtend> GetByPgStudTravelId(System.Decimal _pgStudTravelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgStudTravelId(null, _pgStudTravelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_EXTEND_PG_STUD_TRAVEL key.
		///		fkPgStudTravelExtendPgStudTravel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravelExtend objects.</returns>
		public TList<PgStudTravelExtend> GetByPgStudTravelId(System.Decimal _pgStudTravelId, int start, int pageLength,out int count)
		{
			return GetByPgStudTravelId(null, _pgStudTravelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_EXTEND_PG_STUD_TRAVEL key.
		///		FK_PG_STUD_TRAVEL_EXTEND_PG_STUD_TRAVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravelExtend objects.</returns>
		public abstract TList<PgStudTravelExtend> GetByPgStudTravelId(TransactionManager transactionManager, System.Decimal _pgStudTravelId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgStudTravelExtend Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStudTravelExtendKey key, int start, int pageLength)
		{
			return GetByPgStudTravelExtendId(transactionManager, key.PgStudTravelExtendId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_STUD_TRAVEL_EXTEND index.
		/// </summary>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudTravelExtend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudTravelExtend GetByPgStudTravelExtendId(System.Decimal _pgStudTravelExtendId)
		{
			int count = -1;
			return GetByPgStudTravelExtendId(null,_pgStudTravelExtendId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_TRAVEL_EXTEND index.
		/// </summary>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudTravelExtend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudTravelExtend GetByPgStudTravelExtendId(System.Decimal _pgStudTravelExtendId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgStudTravelExtendId(null, _pgStudTravelExtendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_TRAVEL_EXTEND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudTravelExtend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudTravelExtend GetByPgStudTravelExtendId(TransactionManager transactionManager, System.Decimal _pgStudTravelExtendId)
		{
			int count = -1;
			return GetByPgStudTravelExtendId(transactionManager, _pgStudTravelExtendId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_TRAVEL_EXTEND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudTravelExtend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudTravelExtend GetByPgStudTravelExtendId(TransactionManager transactionManager, System.Decimal _pgStudTravelExtendId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgStudTravelExtendId(transactionManager, _pgStudTravelExtendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_TRAVEL_EXTEND index.
		/// </summary>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudTravelExtend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudTravelExtend GetByPgStudTravelExtendId(System.Decimal _pgStudTravelExtendId, int start, int pageLength, out int count)
		{
			return GetByPgStudTravelExtendId(null, _pgStudTravelExtendId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_TRAVEL_EXTEND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudTravelExtend"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgStudTravelExtend GetByPgStudTravelExtendId(TransactionManager transactionManager, System.Decimal _pgStudTravelExtendId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgStudTravelExtend&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgStudTravelExtend&gt;"/></returns>
		public static TList<PgStudTravelExtend> Fill(IDataReader reader, TList<PgStudTravelExtend> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgStudTravelExtend c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgStudTravelExtend")
					.Append("|").Append((System.Decimal)reader["PG_STUD_TRAVEL_EXTEND_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgStudTravelExtend>(
					key.ToString(), // EntityTrackingKey
					"PgStudTravelExtend",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgStudTravelExtend();
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
					c.PgStudTravelExtendId = (System.Decimal)reader["PG_STUD_TRAVEL_EXTEND_ID"];
					c.OriginalPgStudTravelExtendId = c.PgStudTravelExtendId;
					c.PgStudTravelId = (System.Decimal)reader["PG_STUD_TRAVEL_ID"];
					c.ExtendFrom = Convert.IsDBNull(reader["EXTEND_FROM"]) ? null : (System.DateTime?)reader["EXTEND_FROM"];
					c.ExtendTo = Convert.IsDBNull(reader["EXTEND_TO"]) ? null : (System.DateTime?)reader["EXTEND_TO"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgStudTravelExtend"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgStudTravelExtend"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgStudTravelExtend entity)
		{
			if (!reader.Read()) return;
			
			entity.PgStudTravelExtendId = (System.Decimal)reader[((int)PgStudTravelExtendColumn.PgStudTravelExtendId - 1)];
			entity.OriginalPgStudTravelExtendId = (System.Decimal)reader["PG_STUD_TRAVEL_EXTEND_ID"];
			entity.PgStudTravelId = (System.Decimal)reader[((int)PgStudTravelExtendColumn.PgStudTravelId - 1)];
			entity.ExtendFrom = (reader.IsDBNull(((int)PgStudTravelExtendColumn.ExtendFrom - 1)))?null:(System.DateTime?)reader[((int)PgStudTravelExtendColumn.ExtendFrom - 1)];
			entity.ExtendTo = (reader.IsDBNull(((int)PgStudTravelExtendColumn.ExtendTo - 1)))?null:(System.DateTime?)reader[((int)PgStudTravelExtendColumn.ExtendTo - 1)];
			entity.Notes = (reader.IsDBNull(((int)PgStudTravelExtendColumn.Notes - 1)))?null:(System.String)reader[((int)PgStudTravelExtendColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgStudTravelExtendColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgStudTravelExtendColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgStudTravelExtendColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgStudTravelExtendColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgStudTravelExtend"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgStudTravelExtend"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgStudTravelExtend entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgStudTravelExtendId = (System.Decimal)dataRow["PG_STUD_TRAVEL_EXTEND_ID"];
			entity.OriginalPgStudTravelExtendId = (System.Decimal)dataRow["PG_STUD_TRAVEL_EXTEND_ID"];
			entity.PgStudTravelId = (System.Decimal)dataRow["PG_STUD_TRAVEL_ID"];
			entity.ExtendFrom = Convert.IsDBNull(dataRow["EXTEND_FROM"]) ? null : (System.DateTime?)dataRow["EXTEND_FROM"];
			entity.ExtendTo = Convert.IsDBNull(dataRow["EXTEND_TO"]) ? null : (System.DateTime?)dataRow["EXTEND_TO"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgStudTravelExtend"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgStudTravelExtend Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStudTravelExtend entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region PgStudTravelIdSource	
			if (CanDeepLoad(entity, "PgStudTravel|PgStudTravelIdSource", deepLoadType, innerList) 
				&& entity.PgStudTravelIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgStudTravelId;
				PgStudTravel tmpEntity = EntityManager.LocateEntity<PgStudTravel>(EntityLocator.ConstructKeyFromPkItems(typeof(PgStudTravel), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgStudTravelIdSource = tmpEntity;
				else
					entity.PgStudTravelIdSource = DataRepository.PgStudTravelProvider.GetByPgStudTravelId(transactionManager, entity.PgStudTravelId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStudTravelIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgStudTravelIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgStudTravelProvider.DeepLoad(transactionManager, entity.PgStudTravelIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgStudTravelIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgStudTravelExtendId methods when available
			
			#region PgThesisStudApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudApproveCollection = DataRepository.PgThesisStudApproveProvider.GetByPgStudTravelExtendId(transactionManager, entity.PgStudTravelExtendId);

				if (deep && entity.PgThesisStudApproveCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStudApprove>) DataRepository.PgThesisStudApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgAttchdDoc>|PgAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgAttchdDocCollection = DataRepository.PgAttchdDocProvider.GetByPgStudTravelExtendId(transactionManager, entity.PgStudTravelExtendId);

				if (deep && entity.PgAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("PgAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgAttchdDoc>) DataRepository.PgAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.PgAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgStudTravelExtend object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgStudTravelExtend instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgStudTravelExtend Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStudTravelExtend entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region PgStudTravelIdSource
			if (CanDeepSave(entity, "PgStudTravel|PgStudTravelIdSource", deepSaveType, innerList) 
				&& entity.PgStudTravelIdSource != null)
			{
				DataRepository.PgStudTravelProvider.Save(transactionManager, entity.PgStudTravelIdSource);
				entity.PgStudTravelId = entity.PgStudTravelIdSource.PgStudTravelId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<PgThesisStudApprove>
				if (CanDeepSave(entity.PgThesisStudApproveCollection, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStudApprove child in entity.PgThesisStudApproveCollection)
					{
						if(child.PgStudTravelExtendIdSource != null)
						{
							child.PgStudTravelExtendId = child.PgStudTravelExtendIdSource.PgStudTravelExtendId;
						}
						else
						{
							child.PgStudTravelExtendId = entity.PgStudTravelExtendId;
						}

					}

					if (entity.PgThesisStudApproveCollection.Count > 0 || entity.PgThesisStudApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudApproveProvider.Save(transactionManager, entity.PgThesisStudApproveCollection);
						
						deepHandles.Add("PgThesisStudApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStudApprove >) DataRepository.PgThesisStudApproveProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgAttchdDoc>
				if (CanDeepSave(entity.PgAttchdDocCollection, "List<PgAttchdDoc>|PgAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgAttchdDoc child in entity.PgAttchdDocCollection)
					{
						if(child.PgStudTravelExtendIdSource != null)
						{
							child.PgStudTravelExtendId = child.PgStudTravelExtendIdSource.PgStudTravelExtendId;
						}
						else
						{
							child.PgStudTravelExtendId = entity.PgStudTravelExtendId;
						}

					}

					if (entity.PgAttchdDocCollection.Count > 0 || entity.PgAttchdDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgAttchdDocProvider.Save(transactionManager, entity.PgAttchdDocCollection);
						
						deepHandles.Add("PgAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgAttchdDoc >) DataRepository.PgAttchdDocProvider.DeepSave,
							new object[] { transactionManager, entity.PgAttchdDocCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgStudTravelExtendChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgStudTravelExtend</c>
	///</summary>
	public enum PgStudTravelExtendChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>PgStudTravel</c> at PgStudTravelIdSource
		///</summary>
		[ChildEntityType(typeof(PgStudTravel))]
		PgStudTravel,
		///<summary>
		/// Collection of <c>PgStudTravelExtend</c> as OneToMany for PgThesisStudApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStudApprove>))]
		PgThesisStudApproveCollection,
		///<summary>
		/// Collection of <c>PgStudTravelExtend</c> as OneToMany for PgAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgAttchdDoc>))]
		PgAttchdDocCollection,
	}
	
	#endregion PgStudTravelExtendChildEntityTypes
	
	#region PgStudTravelExtendFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgStudTravelExtendColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgStudTravelExtend"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgStudTravelExtendFilterBuilder : SqlFilterBuilder<PgStudTravelExtendColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgStudTravelExtendFilterBuilder class.
		/// </summary>
		public PgStudTravelExtendFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgStudTravelExtendFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgStudTravelExtendFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgStudTravelExtendFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgStudTravelExtendFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgStudTravelExtendFilterBuilder
	
	#region PgStudTravelExtendParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgStudTravelExtendColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgStudTravelExtend"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgStudTravelExtendParameterBuilder : ParameterizedSqlFilterBuilder<PgStudTravelExtendColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgStudTravelExtendParameterBuilder class.
		/// </summary>
		public PgStudTravelExtendParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgStudTravelExtendParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgStudTravelExtendParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgStudTravelExtendParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgStudTravelExtendParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgStudTravelExtendParameterBuilder
	
	#region PgStudTravelExtendSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgStudTravelExtendColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgStudTravelExtend"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgStudTravelExtendSortBuilder : SqlSortBuilder<PgStudTravelExtendColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgStudTravelExtendSqlSortBuilder class.
		/// </summary>
		public PgStudTravelExtendSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgStudTravelExtendSortBuilder
	
} // end namespace
