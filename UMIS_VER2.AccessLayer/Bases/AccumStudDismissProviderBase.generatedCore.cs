﻿#region Using directives

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
	/// This class is the base class for any <see cref="AccumStudDismissProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccumStudDismissProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccumStudDismiss, UMIS_VER2.BusinessLyer.AccumStudDismissKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccumStudDismissKey key)
		{
			return Delete(transactionManager, key.AccumStudDismissId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accumStudDismissId">فصل/اخراج الطلاب من السكن الداخلي. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _accumStudDismissId)
		{
			return Delete(null, _accumStudDismissId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accumStudDismissId">فصل/اخراج الطلاب من السكن الداخلي. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _accumStudDismissId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCUM_STUD_DISMISS_ACCOM_STUD_BOOK key.
		///		FK_ACCUM_STUD_DISMISS_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccumStudDismiss objects.</returns>
		public TList<AccumStudDismiss> GetByAccomStudBookId(System.Decimal _accomStudBookId)
		{
			int count = -1;
			return GetByAccomStudBookId(_accomStudBookId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCUM_STUD_DISMISS_ACCOM_STUD_BOOK key.
		///		FK_ACCUM_STUD_DISMISS_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccumStudDismiss objects.</returns>
		/// <remarks></remarks>
		public TList<AccumStudDismiss> GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId)
		{
			int count = -1;
			return GetByAccomStudBookId(transactionManager, _accomStudBookId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCUM_STUD_DISMISS_ACCOM_STUD_BOOK key.
		///		FK_ACCUM_STUD_DISMISS_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccumStudDismiss objects.</returns>
		public TList<AccumStudDismiss> GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudBookId(transactionManager, _accomStudBookId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCUM_STUD_DISMISS_ACCOM_STUD_BOOK key.
		///		fkAccumStudDismissAccomStudBook Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccumStudDismiss objects.</returns>
		public TList<AccumStudDismiss> GetByAccomStudBookId(System.Decimal _accomStudBookId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomStudBookId(null, _accomStudBookId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCUM_STUD_DISMISS_ACCOM_STUD_BOOK key.
		///		fkAccumStudDismissAccomStudBook Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccumStudDismiss objects.</returns>
		public TList<AccumStudDismiss> GetByAccomStudBookId(System.Decimal _accomStudBookId, int start, int pageLength,out int count)
		{
			return GetByAccomStudBookId(null, _accomStudBookId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCUM_STUD_DISMISS_ACCOM_STUD_BOOK key.
		///		FK_ACCUM_STUD_DISMISS_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccumStudDismiss objects.</returns>
		public abstract TList<AccumStudDismiss> GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccumStudDismiss Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccumStudDismissKey key, int start, int pageLength)
		{
			return GetByAccumStudDismissId(transactionManager, key.AccumStudDismissId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCUM_STUD_DISMISS index.
		/// </summary>
		/// <param name="_accumStudDismissId">فصل/اخراج الطلاب من السكن الداخلي</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccumStudDismiss"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccumStudDismiss GetByAccumStudDismissId(System.Decimal _accumStudDismissId)
		{
			int count = -1;
			return GetByAccumStudDismissId(null,_accumStudDismissId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCUM_STUD_DISMISS index.
		/// </summary>
		/// <param name="_accumStudDismissId">فصل/اخراج الطلاب من السكن الداخلي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccumStudDismiss"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccumStudDismiss GetByAccumStudDismissId(System.Decimal _accumStudDismissId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccumStudDismissId(null, _accumStudDismissId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCUM_STUD_DISMISS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accumStudDismissId">فصل/اخراج الطلاب من السكن الداخلي</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccumStudDismiss"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccumStudDismiss GetByAccumStudDismissId(TransactionManager transactionManager, System.Decimal _accumStudDismissId)
		{
			int count = -1;
			return GetByAccumStudDismissId(transactionManager, _accumStudDismissId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCUM_STUD_DISMISS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accumStudDismissId">فصل/اخراج الطلاب من السكن الداخلي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccumStudDismiss"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccumStudDismiss GetByAccumStudDismissId(TransactionManager transactionManager, System.Decimal _accumStudDismissId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccumStudDismissId(transactionManager, _accumStudDismissId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCUM_STUD_DISMISS index.
		/// </summary>
		/// <param name="_accumStudDismissId">فصل/اخراج الطلاب من السكن الداخلي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccumStudDismiss"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccumStudDismiss GetByAccumStudDismissId(System.Decimal _accumStudDismissId, int start, int pageLength, out int count)
		{
			return GetByAccumStudDismissId(null, _accumStudDismissId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCUM_STUD_DISMISS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accumStudDismissId">فصل/اخراج الطلاب من السكن الداخلي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccumStudDismiss"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccumStudDismiss GetByAccumStudDismissId(TransactionManager transactionManager, System.Decimal _accumStudDismissId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccumStudDismiss&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccumStudDismiss&gt;"/></returns>
		public static TList<AccumStudDismiss> Fill(IDataReader reader, TList<AccumStudDismiss> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccumStudDismiss c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccumStudDismiss")
					.Append("|").Append((System.Decimal)reader["ACCUM_STUD_DISMISS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccumStudDismiss>(
					key.ToString(), // EntityTrackingKey
					"AccumStudDismiss",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccumStudDismiss();
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
					c.AccumStudDismissId = (System.Decimal)reader["ACCUM_STUD_DISMISS_ID"];
					c.OriginalAccumStudDismissId = c.AccumStudDismissId;
					c.AccomStudBookId = (System.Decimal)reader["ACCOM_STUD_BOOK_ID"];
					c.AccomCdeBookStatusId = (System.Int32)reader["ACCOM_CDE_BOOK_STATUS_ID"];
					c.FromDate = Convert.IsDBNull(reader["FROM_DATE"]) ? null : (System.DateTime?)reader["FROM_DATE"];
					c.ToDate = Convert.IsDBNull(reader["TO_DATE"]) ? null : (System.DateTime?)reader["TO_DATE"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.ApproveFlg = (System.Int32)reader["APPROVE_FLG"];
					c.ApproveDate = Convert.IsDBNull(reader["APPROVE_DATE"]) ? null : (System.DateTime?)reader["APPROVE_DATE"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccumStudDismiss"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccumStudDismiss"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccumStudDismiss entity)
		{
			if (!reader.Read()) return;
			
			entity.AccumStudDismissId = (System.Decimal)reader[((int)AccumStudDismissColumn.AccumStudDismissId - 1)];
			entity.OriginalAccumStudDismissId = (System.Decimal)reader["ACCUM_STUD_DISMISS_ID"];
			entity.AccomStudBookId = (System.Decimal)reader[((int)AccumStudDismissColumn.AccomStudBookId - 1)];
			entity.AccomCdeBookStatusId = (System.Int32)reader[((int)AccumStudDismissColumn.AccomCdeBookStatusId - 1)];
			entity.FromDate = (reader.IsDBNull(((int)AccumStudDismissColumn.FromDate - 1)))?null:(System.DateTime?)reader[((int)AccumStudDismissColumn.FromDate - 1)];
			entity.ToDate = (reader.IsDBNull(((int)AccumStudDismissColumn.ToDate - 1)))?null:(System.DateTime?)reader[((int)AccumStudDismissColumn.ToDate - 1)];
			entity.Notes = (reader.IsDBNull(((int)AccumStudDismissColumn.Notes - 1)))?null:(System.String)reader[((int)AccumStudDismissColumn.Notes - 1)];
			entity.ApproveFlg = (System.Int32)reader[((int)AccumStudDismissColumn.ApproveFlg - 1)];
			entity.ApproveDate = (reader.IsDBNull(((int)AccumStudDismissColumn.ApproveDate - 1)))?null:(System.DateTime?)reader[((int)AccumStudDismissColumn.ApproveDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AccumStudDismissColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AccumStudDismissColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AccumStudDismissColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AccumStudDismissColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccumStudDismiss"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccumStudDismiss"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccumStudDismiss entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccumStudDismissId = (System.Decimal)dataRow["ACCUM_STUD_DISMISS_ID"];
			entity.OriginalAccumStudDismissId = (System.Decimal)dataRow["ACCUM_STUD_DISMISS_ID"];
			entity.AccomStudBookId = (System.Decimal)dataRow["ACCOM_STUD_BOOK_ID"];
			entity.AccomCdeBookStatusId = (System.Int32)dataRow["ACCOM_CDE_BOOK_STATUS_ID"];
			entity.FromDate = Convert.IsDBNull(dataRow["FROM_DATE"]) ? null : (System.DateTime?)dataRow["FROM_DATE"];
			entity.ToDate = Convert.IsDBNull(dataRow["TO_DATE"]) ? null : (System.DateTime?)dataRow["TO_DATE"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.ApproveFlg = (System.Int32)dataRow["APPROVE_FLG"];
			entity.ApproveDate = Convert.IsDBNull(dataRow["APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["APPROVE_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccumStudDismiss"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccumStudDismiss Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccumStudDismiss entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AccomStudBookIdSource	
			if (CanDeepLoad(entity, "AccomStudBook|AccomStudBookIdSource", deepLoadType, innerList) 
				&& entity.AccomStudBookIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AccomStudBookId;
				AccomStudBook tmpEntity = EntityManager.LocateEntity<AccomStudBook>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomStudBook), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomStudBookIdSource = tmpEntity;
				else
					entity.AccomStudBookIdSource = DataRepository.AccomStudBookProvider.GetByAccomStudBookId(transactionManager, entity.AccomStudBookId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudBookIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomStudBookIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomStudBookProvider.DeepLoad(transactionManager, entity.AccomStudBookIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomStudBookIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccumStudDismiss object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccumStudDismiss instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccumStudDismiss Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccumStudDismiss entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AccomStudBookIdSource
			if (CanDeepSave(entity, "AccomStudBook|AccomStudBookIdSource", deepSaveType, innerList) 
				&& entity.AccomStudBookIdSource != null)
			{
				DataRepository.AccomStudBookProvider.Save(transactionManager, entity.AccomStudBookIdSource);
				entity.AccomStudBookId = entity.AccomStudBookIdSource.AccomStudBookId;
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
	
	#region AccumStudDismissChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccumStudDismiss</c>
	///</summary>
	public enum AccumStudDismissChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AccomStudBook</c> at AccomStudBookIdSource
		///</summary>
		[ChildEntityType(typeof(AccomStudBook))]
		AccomStudBook,
	}
	
	#endregion AccumStudDismissChildEntityTypes
	
	#region AccumStudDismissFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccumStudDismissColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccumStudDismiss"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccumStudDismissFilterBuilder : SqlFilterBuilder<AccumStudDismissColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccumStudDismissFilterBuilder class.
		/// </summary>
		public AccumStudDismissFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccumStudDismissFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccumStudDismissFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccumStudDismissFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccumStudDismissFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccumStudDismissFilterBuilder
	
	#region AccumStudDismissParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccumStudDismissColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccumStudDismiss"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccumStudDismissParameterBuilder : ParameterizedSqlFilterBuilder<AccumStudDismissColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccumStudDismissParameterBuilder class.
		/// </summary>
		public AccumStudDismissParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccumStudDismissParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccumStudDismissParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccumStudDismissParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccumStudDismissParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccumStudDismissParameterBuilder
	
	#region AccumStudDismissSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccumStudDismissColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccumStudDismiss"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccumStudDismissSortBuilder : SqlSortBuilder<AccumStudDismissColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccumStudDismissSqlSortBuilder class.
		/// </summary>
		public AccumStudDismissSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccumStudDismissSortBuilder
	
} // end namespace