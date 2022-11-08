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
	/// This class is the base class for any <see cref="AccomCdeBookStatusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomCdeBookStatusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomCdeBookStatus, UMIS_VER2.BusinessLyer.AccomCdeBookStatusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeBookStatusKey key)
		{
			return Delete(transactionManager, key.AccomCdeBookStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomCdeBookStatusId">حالة حجز الغرفة-السرير. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _accomCdeBookStatusId)
		{
			return Delete(null, _accomCdeBookStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeBookStatusId">حالة حجز الغرفة-السرير. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _accomCdeBookStatusId);		
		
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
		public override UMIS_VER2.BusinessLyer.AccomCdeBookStatus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeBookStatusKey key, int start, int pageLength)
		{
			return GetByAccomCdeBookStatusId(transactionManager, key.AccomCdeBookStatusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_CDE_BOOK_STATUS index.
		/// </summary>
		/// <param name="_accomCdeBookStatusId">حالة حجز الغرفة-السرير</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeBookStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeBookStatus GetByAccomCdeBookStatusId(System.Int32 _accomCdeBookStatusId)
		{
			int count = -1;
			return GetByAccomCdeBookStatusId(null,_accomCdeBookStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_BOOK_STATUS index.
		/// </summary>
		/// <param name="_accomCdeBookStatusId">حالة حجز الغرفة-السرير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeBookStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeBookStatus GetByAccomCdeBookStatusId(System.Int32 _accomCdeBookStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdeBookStatusId(null, _accomCdeBookStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_BOOK_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeBookStatusId">حالة حجز الغرفة-السرير</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeBookStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeBookStatus GetByAccomCdeBookStatusId(TransactionManager transactionManager, System.Int32 _accomCdeBookStatusId)
		{
			int count = -1;
			return GetByAccomCdeBookStatusId(transactionManager, _accomCdeBookStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_BOOK_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeBookStatusId">حالة حجز الغرفة-السرير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeBookStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeBookStatus GetByAccomCdeBookStatusId(TransactionManager transactionManager, System.Int32 _accomCdeBookStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdeBookStatusId(transactionManager, _accomCdeBookStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_BOOK_STATUS index.
		/// </summary>
		/// <param name="_accomCdeBookStatusId">حالة حجز الغرفة-السرير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeBookStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeBookStatus GetByAccomCdeBookStatusId(System.Int32 _accomCdeBookStatusId, int start, int pageLength, out int count)
		{
			return GetByAccomCdeBookStatusId(null, _accomCdeBookStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_BOOK_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeBookStatusId">حالة حجز الغرفة-السرير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeBookStatus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomCdeBookStatus GetByAccomCdeBookStatusId(TransactionManager transactionManager, System.Int32 _accomCdeBookStatusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomCdeBookStatus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomCdeBookStatus&gt;"/></returns>
		public static TList<AccomCdeBookStatus> Fill(IDataReader reader, TList<AccomCdeBookStatus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomCdeBookStatus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomCdeBookStatus")
					.Append("|").Append((System.Int32)reader["ACCOM_CDE_BOOK_STATUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomCdeBookStatus>(
					key.ToString(), // EntityTrackingKey
					"AccomCdeBookStatus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomCdeBookStatus();
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
					c.AccomCdeBookStatusId = (System.Int32)reader["ACCOM_CDE_BOOK_STATUS_ID"];
					c.OriginalAccomCdeBookStatusId = c.AccomCdeBookStatusId;
					c.BookStatusAr = Convert.IsDBNull(reader["BOOK_STATUS_AR"]) ? null : (System.String)reader["BOOK_STATUS_AR"];
					c.BookStatusEn = Convert.IsDBNull(reader["BOOK_STATUS_EN"]) ? null : (System.String)reader["BOOK_STATUS_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomCdeBookStatus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdeBookStatus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomCdeBookStatus entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomCdeBookStatusId = (System.Int32)reader[((int)AccomCdeBookStatusColumn.AccomCdeBookStatusId - 1)];
			entity.OriginalAccomCdeBookStatusId = (System.Int32)reader["ACCOM_CDE_BOOK_STATUS_ID"];
			entity.BookStatusAr = (reader.IsDBNull(((int)AccomCdeBookStatusColumn.BookStatusAr - 1)))?null:(System.String)reader[((int)AccomCdeBookStatusColumn.BookStatusAr - 1)];
			entity.BookStatusEn = (reader.IsDBNull(((int)AccomCdeBookStatusColumn.BookStatusEn - 1)))?null:(System.String)reader[((int)AccomCdeBookStatusColumn.BookStatusEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomCdeBookStatus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdeBookStatus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomCdeBookStatus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomCdeBookStatusId = (System.Int32)dataRow["ACCOM_CDE_BOOK_STATUS_ID"];
			entity.OriginalAccomCdeBookStatusId = (System.Int32)dataRow["ACCOM_CDE_BOOK_STATUS_ID"];
			entity.BookStatusAr = Convert.IsDBNull(dataRow["BOOK_STATUS_AR"]) ? null : (System.String)dataRow["BOOK_STATUS_AR"];
			entity.BookStatusEn = Convert.IsDBNull(dataRow["BOOK_STATUS_EN"]) ? null : (System.String)dataRow["BOOK_STATUS_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdeBookStatus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomCdeBookStatus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeBookStatus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAccomCdeBookStatusId methods when available
			
			#region AccomStudBookCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudBook>|AccomStudBookCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudBookCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudBookCollection = DataRepository.AccomStudBookProvider.GetByAccomCdeBookStatusId(transactionManager, entity.AccomCdeBookStatusId);

				if (deep && entity.AccomStudBookCollection.Count > 0)
				{
					deepHandles.Add("AccomStudBookCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudBook>) DataRepository.AccomStudBookProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudBookCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudDismissCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudDismiss>|AccomStudDismissCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudDismissCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudDismissCollection = DataRepository.AccomStudDismissProvider.GetByAccomCdeBookStatusId(transactionManager, entity.AccomCdeBookStatusId);

				if (deep && entity.AccomStudDismissCollection.Count > 0)
				{
					deepHandles.Add("AccomStudDismissCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudDismiss>) DataRepository.AccomStudDismissProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudDismissCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomCdeBookStatus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomCdeBookStatus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomCdeBookStatus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeBookStatus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AccomStudBook>
				if (CanDeepSave(entity.AccomStudBookCollection, "List<AccomStudBook>|AccomStudBookCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudBook child in entity.AccomStudBookCollection)
					{
						if(child.AccomCdeBookStatusIdSource != null)
						{
							child.AccomCdeBookStatusId = child.AccomCdeBookStatusIdSource.AccomCdeBookStatusId;
						}
						else
						{
							child.AccomCdeBookStatusId = entity.AccomCdeBookStatusId;
						}

					}

					if (entity.AccomStudBookCollection.Count > 0 || entity.AccomStudBookCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudBookProvider.Save(transactionManager, entity.AccomStudBookCollection);
						
						deepHandles.Add("AccomStudBookCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudBook >) DataRepository.AccomStudBookProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudBookCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudDismiss>
				if (CanDeepSave(entity.AccomStudDismissCollection, "List<AccomStudDismiss>|AccomStudDismissCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudDismiss child in entity.AccomStudDismissCollection)
					{
						if(child.AccomCdeBookStatusIdSource != null)
						{
							child.AccomCdeBookStatusId = child.AccomCdeBookStatusIdSource.AccomCdeBookStatusId;
						}
						else
						{
							child.AccomCdeBookStatusId = entity.AccomCdeBookStatusId;
						}

					}

					if (entity.AccomStudDismissCollection.Count > 0 || entity.AccomStudDismissCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudDismissProvider.Save(transactionManager, entity.AccomStudDismissCollection);
						
						deepHandles.Add("AccomStudDismissCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudDismiss >) DataRepository.AccomStudDismissProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudDismissCollection, deepSaveType, childTypes, innerList }
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
	
	#region AccomCdeBookStatusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomCdeBookStatus</c>
	///</summary>
	public enum AccomCdeBookStatusChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AccomCdeBookStatus</c> as OneToMany for AccomStudBookCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudBook>))]
		AccomStudBookCollection,
		///<summary>
		/// Collection of <c>AccomCdeBookStatus</c> as OneToMany for AccomStudDismissCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudDismiss>))]
		AccomStudDismissCollection,
	}
	
	#endregion AccomCdeBookStatusChildEntityTypes
	
	#region AccomCdeBookStatusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomCdeBookStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdeBookStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomCdeBookStatusFilterBuilder : SqlFilterBuilder<AccomCdeBookStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdeBookStatusFilterBuilder class.
		/// </summary>
		public AccomCdeBookStatusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeBookStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomCdeBookStatusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeBookStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomCdeBookStatusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomCdeBookStatusFilterBuilder
	
	#region AccomCdeBookStatusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomCdeBookStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdeBookStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomCdeBookStatusParameterBuilder : ParameterizedSqlFilterBuilder<AccomCdeBookStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdeBookStatusParameterBuilder class.
		/// </summary>
		public AccomCdeBookStatusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeBookStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomCdeBookStatusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeBookStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomCdeBookStatusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomCdeBookStatusParameterBuilder
	
	#region AccomCdeBookStatusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomCdeBookStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdeBookStatus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomCdeBookStatusSortBuilder : SqlSortBuilder<AccomCdeBookStatusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdeBookStatusSqlSortBuilder class.
		/// </summary>
		public AccomCdeBookStatusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomCdeBookStatusSortBuilder
	
} // end namespace
