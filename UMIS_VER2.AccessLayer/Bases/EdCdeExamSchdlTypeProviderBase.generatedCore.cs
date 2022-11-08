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
	/// This class is the base class for any <see cref="EdCdeExamSchdlTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeExamSchdlTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCdeExamSchdlType, UMIS_VER2.BusinessLyer.EdCdeExamSchdlTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeExamSchdlTypeKey key)
		{
			return Delete(transactionManager, key.EdCdeExamSchdlTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCdeExamSchdlTypeId">نوع الامتحان في الجدول :مقالي ،اختياري. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCdeExamSchdlTypeId)
		{
			return Delete(null, _edCdeExamSchdlTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamSchdlTypeId">نوع الامتحان في الجدول :مقالي ،اختياري. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCdeExamSchdlTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCdeExamSchdlType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeExamSchdlTypeKey key, int start, int pageLength)
		{
			return GetByEdCdeExamSchdlTypeId(transactionManager, key.EdCdeExamSchdlTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CDE_EXAMSCHDL_TYPE index.
		/// </summary>
		/// <param name="_edCdeExamSchdlTypeId">نوع الامتحان في الجدول :مقالي ،اختياري</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExamSchdlType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExamSchdlType GetByEdCdeExamSchdlTypeId(System.Decimal _edCdeExamSchdlTypeId)
		{
			int count = -1;
			return GetByEdCdeExamSchdlTypeId(null,_edCdeExamSchdlTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EXAMSCHDL_TYPE index.
		/// </summary>
		/// <param name="_edCdeExamSchdlTypeId">نوع الامتحان في الجدول :مقالي ،اختياري</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExamSchdlType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExamSchdlType GetByEdCdeExamSchdlTypeId(System.Decimal _edCdeExamSchdlTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExamSchdlTypeId(null, _edCdeExamSchdlTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EXAMSCHDL_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamSchdlTypeId">نوع الامتحان في الجدول :مقالي ،اختياري</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExamSchdlType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExamSchdlType GetByEdCdeExamSchdlTypeId(TransactionManager transactionManager, System.Decimal _edCdeExamSchdlTypeId)
		{
			int count = -1;
			return GetByEdCdeExamSchdlTypeId(transactionManager, _edCdeExamSchdlTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EXAMSCHDL_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamSchdlTypeId">نوع الامتحان في الجدول :مقالي ،اختياري</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExamSchdlType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExamSchdlType GetByEdCdeExamSchdlTypeId(TransactionManager transactionManager, System.Decimal _edCdeExamSchdlTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExamSchdlTypeId(transactionManager, _edCdeExamSchdlTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EXAMSCHDL_TYPE index.
		/// </summary>
		/// <param name="_edCdeExamSchdlTypeId">نوع الامتحان في الجدول :مقالي ،اختياري</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExamSchdlType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExamSchdlType GetByEdCdeExamSchdlTypeId(System.Decimal _edCdeExamSchdlTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCdeExamSchdlTypeId(null, _edCdeExamSchdlTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EXAMSCHDL_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamSchdlTypeId">نوع الامتحان في الجدول :مقالي ،اختياري</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExamSchdlType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeExamSchdlType GetByEdCdeExamSchdlTypeId(TransactionManager transactionManager, System.Decimal _edCdeExamSchdlTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCdeExamSchdlType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCdeExamSchdlType&gt;"/></returns>
		public static TList<EdCdeExamSchdlType> Fill(IDataReader reader, TList<EdCdeExamSchdlType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCdeExamSchdlType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCdeExamSchdlType")
					.Append("|").Append((System.Decimal)reader["ED_CDE_EXAM_SCHDL_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCdeExamSchdlType>(
					key.ToString(), // EntityTrackingKey
					"EdCdeExamSchdlType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCdeExamSchdlType();
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
					c.EdCdeExamSchdlTypeId = (System.Decimal)reader["ED_CDE_EXAM_SCHDL_TYPE_ID"];
					c.OriginalEdCdeExamSchdlTypeId = c.EdCdeExamSchdlTypeId;
					c.ExamSchdlTypeAr = (System.String)reader["EXAM_SCHDL_TYPE_AR"];
					c.ExamSchdlTypeEn = (System.String)reader["EXAM_SCHDL_TYPE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeExamSchdlType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeExamSchdlType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCdeExamSchdlType entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCdeExamSchdlTypeId = (System.Decimal)reader[((int)EdCdeExamSchdlTypeColumn.EdCdeExamSchdlTypeId - 1)];
			entity.OriginalEdCdeExamSchdlTypeId = (System.Decimal)reader["ED_CDE_EXAM_SCHDL_TYPE_ID"];
			entity.ExamSchdlTypeAr = (System.String)reader[((int)EdCdeExamSchdlTypeColumn.ExamSchdlTypeAr - 1)];
			entity.ExamSchdlTypeEn = (System.String)reader[((int)EdCdeExamSchdlTypeColumn.ExamSchdlTypeEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeExamSchdlType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeExamSchdlType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCdeExamSchdlType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCdeExamSchdlTypeId = (System.Decimal)dataRow["ED_CDE_EXAM_SCHDL_TYPE_ID"];
			entity.OriginalEdCdeExamSchdlTypeId = (System.Decimal)dataRow["ED_CDE_EXAM_SCHDL_TYPE_ID"];
			entity.ExamSchdlTypeAr = (System.String)dataRow["EXAM_SCHDL_TYPE_AR"];
			entity.ExamSchdlTypeEn = (System.String)dataRow["EXAM_SCHDL_TYPE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeExamSchdlType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeExamSchdlType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeExamSchdlType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCdeExamSchdlTypeId methods when available
			
			#region EdExamSchdlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdExamSchdl>|EdExamSchdlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamSchdlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdExamSchdlCollection = DataRepository.EdExamSchdlProvider.GetByEdCdeExamSchdlTypeId(transactionManager, entity.EdCdeExamSchdlTypeId);

				if (deep && entity.EdExamSchdlCollection.Count > 0)
				{
					deepHandles.Add("EdExamSchdlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdExamSchdl>) DataRepository.EdExamSchdlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdExamSchdlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCdeExamSchdlType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCdeExamSchdlType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeExamSchdlType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeExamSchdlType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdExamSchdl>
				if (CanDeepSave(entity.EdExamSchdlCollection, "List<EdExamSchdl>|EdExamSchdlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdExamSchdl child in entity.EdExamSchdlCollection)
					{
						if(child.EdCdeExamSchdlTypeIdSource != null)
						{
							child.EdCdeExamSchdlTypeId = child.EdCdeExamSchdlTypeIdSource.EdCdeExamSchdlTypeId;
						}
						else
						{
							child.EdCdeExamSchdlTypeId = entity.EdCdeExamSchdlTypeId;
						}

					}

					if (entity.EdExamSchdlCollection.Count > 0 || entity.EdExamSchdlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdExamSchdlProvider.Save(transactionManager, entity.EdExamSchdlCollection);
						
						deepHandles.Add("EdExamSchdlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdExamSchdl >) DataRepository.EdExamSchdlProvider.DeepSave,
							new object[] { transactionManager, entity.EdExamSchdlCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCdeExamSchdlTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCdeExamSchdlType</c>
	///</summary>
	public enum EdCdeExamSchdlTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCdeExamSchdlType</c> as OneToMany for EdExamSchdlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdExamSchdl>))]
		EdExamSchdlCollection,
	}
	
	#endregion EdCdeExamSchdlTypeChildEntityTypes
	
	#region EdCdeExamSchdlTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCdeExamSchdlTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeExamSchdlType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeExamSchdlTypeFilterBuilder : SqlFilterBuilder<EdCdeExamSchdlTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeExamSchdlTypeFilterBuilder class.
		/// </summary>
		public EdCdeExamSchdlTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeExamSchdlTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeExamSchdlTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeExamSchdlTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeExamSchdlTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeExamSchdlTypeFilterBuilder
	
	#region EdCdeExamSchdlTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCdeExamSchdlTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeExamSchdlType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeExamSchdlTypeParameterBuilder : ParameterizedSqlFilterBuilder<EdCdeExamSchdlTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeExamSchdlTypeParameterBuilder class.
		/// </summary>
		public EdCdeExamSchdlTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeExamSchdlTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeExamSchdlTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeExamSchdlTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeExamSchdlTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeExamSchdlTypeParameterBuilder
	
	#region EdCdeExamSchdlTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCdeExamSchdlTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeExamSchdlType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCdeExamSchdlTypeSortBuilder : SqlSortBuilder<EdCdeExamSchdlTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeExamSchdlTypeSqlSortBuilder class.
		/// </summary>
		public EdCdeExamSchdlTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCdeExamSchdlTypeSortBuilder
	
} // end namespace
