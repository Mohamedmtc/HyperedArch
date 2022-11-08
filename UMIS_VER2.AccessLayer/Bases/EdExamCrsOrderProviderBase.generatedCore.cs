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
	/// This class is the base class for any <see cref="EdExamCrsOrderProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdExamCrsOrderProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdExamCrsOrder, UMIS_VER2.BusinessLyer.EdExamCrsOrderKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdExamCrsOrderKey key)
		{
			return Delete(transactionManager, key.EdExamCrsOrderId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edExamCrsOrderId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edExamCrsOrderId)
		{
			return Delete(null, _edExamCrsOrderId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamCrsOrderId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edExamCrsOrderId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_CRS_ORDER_ED_COURSE key.
		///		FK_ED_EXAM_CRS_ORDER_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamCrsOrder objects.</returns>
		public TList<EdExamCrsOrder> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_CRS_ORDER_ED_COURSE key.
		///		FK_ED_EXAM_CRS_ORDER_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamCrsOrder objects.</returns>
		/// <remarks></remarks>
		public TList<EdExamCrsOrder> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_CRS_ORDER_ED_COURSE key.
		///		FK_ED_EXAM_CRS_ORDER_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamCrsOrder objects.</returns>
		public TList<EdExamCrsOrder> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_CRS_ORDER_ED_COURSE key.
		///		fkEdExamCrsOrderEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamCrsOrder objects.</returns>
		public TList<EdExamCrsOrder> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_CRS_ORDER_ED_COURSE key.
		///		fkEdExamCrsOrderEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamCrsOrder objects.</returns>
		public TList<EdExamCrsOrder> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_CRS_ORDER_ED_COURSE key.
		///		FK_ED_EXAM_CRS_ORDER_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamCrsOrder objects.</returns>
		public abstract TList<EdExamCrsOrder> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdExamCrsOrder Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdExamCrsOrderKey key, int start, int pageLength)
		{
			return GetByEdExamCrsOrderId(transactionManager, key.EdExamCrsOrderId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_EXAM_CRS_ORDER index.
		/// </summary>
		/// <param name="_edExamCrsOrderId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamCrsOrder"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamCrsOrder GetByEdExamCrsOrderId(System.Decimal _edExamCrsOrderId)
		{
			int count = -1;
			return GetByEdExamCrsOrderId(null,_edExamCrsOrderId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM_CRS_ORDER index.
		/// </summary>
		/// <param name="_edExamCrsOrderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamCrsOrder"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamCrsOrder GetByEdExamCrsOrderId(System.Decimal _edExamCrsOrderId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdExamCrsOrderId(null, _edExamCrsOrderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM_CRS_ORDER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamCrsOrderId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamCrsOrder"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamCrsOrder GetByEdExamCrsOrderId(TransactionManager transactionManager, System.Decimal _edExamCrsOrderId)
		{
			int count = -1;
			return GetByEdExamCrsOrderId(transactionManager, _edExamCrsOrderId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM_CRS_ORDER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamCrsOrderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamCrsOrder"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamCrsOrder GetByEdExamCrsOrderId(TransactionManager transactionManager, System.Decimal _edExamCrsOrderId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdExamCrsOrderId(transactionManager, _edExamCrsOrderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM_CRS_ORDER index.
		/// </summary>
		/// <param name="_edExamCrsOrderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamCrsOrder"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamCrsOrder GetByEdExamCrsOrderId(System.Decimal _edExamCrsOrderId, int start, int pageLength, out int count)
		{
			return GetByEdExamCrsOrderId(null, _edExamCrsOrderId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM_CRS_ORDER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamCrsOrderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamCrsOrder"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdExamCrsOrder GetByEdExamCrsOrderId(TransactionManager transactionManager, System.Decimal _edExamCrsOrderId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdExamCrsOrder&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdExamCrsOrder&gt;"/></returns>
		public static TList<EdExamCrsOrder> Fill(IDataReader reader, TList<EdExamCrsOrder> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdExamCrsOrder c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdExamCrsOrder")
					.Append("|").Append((System.Decimal)reader["ED_EXAM_CRS_ORDER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdExamCrsOrder>(
					key.ToString(), // EntityTrackingKey
					"EdExamCrsOrder",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdExamCrsOrder();
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
					c.EdExamCrsOrderId = (System.Decimal)reader["ED_EXAM_CRS_ORDER_ID"];
					c.OriginalEdExamCrsOrderId = c.EdExamCrsOrderId;
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.DayOrder = Convert.IsDBNull(reader["DAY_ORDER"]) ? null : (System.Int32?)reader["DAY_ORDER"];
					c.FromTime = Convert.IsDBNull(reader["FROM_TIME"]) ? null : (System.DateTime?)reader["FROM_TIME"];
					c.ToTime = Convert.IsDBNull(reader["TO_TIME"]) ? null : (System.DateTime?)reader["TO_TIME"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdExamCrsOrder"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdExamCrsOrder"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdExamCrsOrder entity)
		{
			if (!reader.Read()) return;
			
			entity.EdExamCrsOrderId = (System.Decimal)reader[((int)EdExamCrsOrderColumn.EdExamCrsOrderId - 1)];
			entity.OriginalEdExamCrsOrderId = (System.Decimal)reader["ED_EXAM_CRS_ORDER_ID"];
			entity.EdCourseId = (System.Decimal)reader[((int)EdExamCrsOrderColumn.EdCourseId - 1)];
			entity.DayOrder = (reader.IsDBNull(((int)EdExamCrsOrderColumn.DayOrder - 1)))?null:(System.Int32?)reader[((int)EdExamCrsOrderColumn.DayOrder - 1)];
			entity.FromTime = (reader.IsDBNull(((int)EdExamCrsOrderColumn.FromTime - 1)))?null:(System.DateTime?)reader[((int)EdExamCrsOrderColumn.FromTime - 1)];
			entity.ToTime = (reader.IsDBNull(((int)EdExamCrsOrderColumn.ToTime - 1)))?null:(System.DateTime?)reader[((int)EdExamCrsOrderColumn.ToTime - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdExamCrsOrderColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdExamCrsOrderColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdExamCrsOrderColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdExamCrsOrderColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdExamCrsOrder"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdExamCrsOrder"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdExamCrsOrder entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdExamCrsOrderId = (System.Decimal)dataRow["ED_EXAM_CRS_ORDER_ID"];
			entity.OriginalEdExamCrsOrderId = (System.Decimal)dataRow["ED_EXAM_CRS_ORDER_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.DayOrder = Convert.IsDBNull(dataRow["DAY_ORDER"]) ? null : (System.Int32?)dataRow["DAY_ORDER"];
			entity.FromTime = Convert.IsDBNull(dataRow["FROM_TIME"]) ? null : (System.DateTime?)dataRow["FROM_TIME"];
			entity.ToTime = Convert.IsDBNull(dataRow["TO_TIME"]) ? null : (System.DateTime?)dataRow["TO_TIME"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdExamCrsOrder"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdExamCrsOrder Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdExamCrsOrder entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdExamCrsOrder object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdExamCrsOrder instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdExamCrsOrder Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdExamCrsOrder entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
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
	
	#region EdExamCrsOrderChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdExamCrsOrder</c>
	///</summary>
	public enum EdExamCrsOrderChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
	}
	
	#endregion EdExamCrsOrderChildEntityTypes
	
	#region EdExamCrsOrderFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdExamCrsOrderColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdExamCrsOrder"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdExamCrsOrderFilterBuilder : SqlFilterBuilder<EdExamCrsOrderColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdExamCrsOrderFilterBuilder class.
		/// </summary>
		public EdExamCrsOrderFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdExamCrsOrderFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdExamCrsOrderFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdExamCrsOrderFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdExamCrsOrderFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdExamCrsOrderFilterBuilder
	
	#region EdExamCrsOrderParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdExamCrsOrderColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdExamCrsOrder"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdExamCrsOrderParameterBuilder : ParameterizedSqlFilterBuilder<EdExamCrsOrderColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdExamCrsOrderParameterBuilder class.
		/// </summary>
		public EdExamCrsOrderParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdExamCrsOrderParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdExamCrsOrderParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdExamCrsOrderParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdExamCrsOrderParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdExamCrsOrderParameterBuilder
	
	#region EdExamCrsOrderSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdExamCrsOrderColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdExamCrsOrder"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdExamCrsOrderSortBuilder : SqlSortBuilder<EdExamCrsOrderColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdExamCrsOrderSqlSortBuilder class.
		/// </summary>
		public EdExamCrsOrderSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdExamCrsOrderSortBuilder
	
} // end namespace
