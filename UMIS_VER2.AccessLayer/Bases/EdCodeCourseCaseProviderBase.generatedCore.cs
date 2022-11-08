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
	/// This class is the base class for any <see cref="EdCodeCourseCaseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeCourseCaseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeCourseCase, UMIS_VER2.BusinessLyer.EdCodeCourseCaseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseCaseKey key)
		{
			return Delete(transactionManager, key.EdCodeCourseCaseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeCourseCaseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _edCodeCourseCaseId)
		{
			return Delete(null, _edCodeCourseCaseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseCaseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _edCodeCourseCaseId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeCourseCase Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseCaseKey key, int start, int pageLength)
		{
			return GetByEdCodeCourseCaseId(transactionManager, key.EdCodeCourseCaseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_COURSE_CASE index.
		/// </summary>
		/// <param name="_edCodeCourseCaseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseCase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseCase GetByEdCodeCourseCaseId(System.Int32 _edCodeCourseCaseId)
		{
			int count = -1;
			return GetByEdCodeCourseCaseId(null,_edCodeCourseCaseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_COURSE_CASE index.
		/// </summary>
		/// <param name="_edCodeCourseCaseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseCase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseCase GetByEdCodeCourseCaseId(System.Int32 _edCodeCourseCaseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseCaseId(null, _edCodeCourseCaseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_COURSE_CASE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseCaseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseCase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseCase GetByEdCodeCourseCaseId(TransactionManager transactionManager, System.Int32 _edCodeCourseCaseId)
		{
			int count = -1;
			return GetByEdCodeCourseCaseId(transactionManager, _edCodeCourseCaseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_COURSE_CASE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseCaseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseCase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseCase GetByEdCodeCourseCaseId(TransactionManager transactionManager, System.Int32 _edCodeCourseCaseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseCaseId(transactionManager, _edCodeCourseCaseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_COURSE_CASE index.
		/// </summary>
		/// <param name="_edCodeCourseCaseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseCase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseCase GetByEdCodeCourseCaseId(System.Int32 _edCodeCourseCaseId, int start, int pageLength, out int count)
		{
			return GetByEdCodeCourseCaseId(null, _edCodeCourseCaseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_COURSE_CASE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseCaseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseCase"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeCourseCase GetByEdCodeCourseCaseId(TransactionManager transactionManager, System.Int32 _edCodeCourseCaseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeCourseCase&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeCourseCase&gt;"/></returns>
		public static TList<EdCodeCourseCase> Fill(IDataReader reader, TList<EdCodeCourseCase> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeCourseCase c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeCourseCase")
					.Append("|").Append((System.Int32)reader["ED_CODE_COURSE_CASE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeCourseCase>(
					key.ToString(), // EntityTrackingKey
					"EdCodeCourseCase",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeCourseCase();
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
					c.EdCodeCourseCaseId = (System.Int32)reader["ED_CODE_COURSE_CASE_ID"];
					c.OriginalEdCodeCourseCaseId = c.EdCodeCourseCaseId;
					c.CrsCaseAr = (System.String)reader["CRS_CASE_AR"];
					c.CrsCaseEn = Convert.IsDBNull(reader["CRS_CASE_EN"]) ? null : (System.String)reader["CRS_CASE_EN"];
					c.CrsCaseCode = Convert.IsDBNull(reader["CRS_CASE_CODE"]) ? null : (System.String)reader["CRS_CASE_CODE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseCase"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseCase"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeCourseCase entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeCourseCaseId = (System.Int32)reader[((int)EdCodeCourseCaseColumn.EdCodeCourseCaseId - 1)];
			entity.OriginalEdCodeCourseCaseId = (System.Int32)reader["ED_CODE_COURSE_CASE_ID"];
			entity.CrsCaseAr = (System.String)reader[((int)EdCodeCourseCaseColumn.CrsCaseAr - 1)];
			entity.CrsCaseEn = (reader.IsDBNull(((int)EdCodeCourseCaseColumn.CrsCaseEn - 1)))?null:(System.String)reader[((int)EdCodeCourseCaseColumn.CrsCaseEn - 1)];
			entity.CrsCaseCode = (reader.IsDBNull(((int)EdCodeCourseCaseColumn.CrsCaseCode - 1)))?null:(System.String)reader[((int)EdCodeCourseCaseColumn.CrsCaseCode - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseCase"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseCase"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeCourseCase entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeCourseCaseId = (System.Int32)dataRow["ED_CODE_COURSE_CASE_ID"];
			entity.OriginalEdCodeCourseCaseId = (System.Int32)dataRow["ED_CODE_COURSE_CASE_ID"];
			entity.CrsCaseAr = (System.String)dataRow["CRS_CASE_AR"];
			entity.CrsCaseEn = Convert.IsDBNull(dataRow["CRS_CASE_EN"]) ? null : (System.String)dataRow["CRS_CASE_EN"];
			entity.CrsCaseCode = Convert.IsDBNull(dataRow["CRS_CASE_CODE"]) ? null : (System.String)dataRow["CRS_CASE_CODE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseCase"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeCourseCase Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseCase entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeCourseCaseId methods when available
			
			#region EdStudCourseRegCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegCollection = DataRepository.EdStudCourseRegProvider.GetByEdCodeCourseCaseId(transactionManager, entity.EdCodeCourseCaseId);

				if (deep && entity.EdStudCourseRegCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseReg>) DataRepository.EdStudCourseRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeCourseCase object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeCourseCase instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeCourseCase Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseCase entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudCourseReg>
				if (CanDeepSave(entity.EdStudCourseRegCollection, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseReg child in entity.EdStudCourseRegCollection)
					{
						if(child.EdCodeCourseCaseIdSource != null)
						{
							child.EdCodeCourseCaseId = child.EdCodeCourseCaseIdSource.EdCodeCourseCaseId;
						}
						else
						{
							child.EdCodeCourseCaseId = entity.EdCodeCourseCaseId;
						}

					}

					if (entity.EdStudCourseRegCollection.Count > 0 || entity.EdStudCourseRegCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegCollection);
						
						deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseReg >) DataRepository.EdStudCourseRegProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeCourseCaseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeCourseCase</c>
	///</summary>
	public enum EdCodeCourseCaseChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCodeCourseCase</c> as OneToMany for EdStudCourseRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseReg>))]
		EdStudCourseRegCollection,
	}
	
	#endregion EdCodeCourseCaseChildEntityTypes
	
	#region EdCodeCourseCaseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeCourseCaseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCourseCase"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeCourseCaseFilterBuilder : SqlFilterBuilder<EdCodeCourseCaseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseCaseFilterBuilder class.
		/// </summary>
		public EdCodeCourseCaseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseCaseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeCourseCaseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseCaseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeCourseCaseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeCourseCaseFilterBuilder
	
	#region EdCodeCourseCaseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeCourseCaseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCourseCase"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeCourseCaseParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeCourseCaseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseCaseParameterBuilder class.
		/// </summary>
		public EdCodeCourseCaseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseCaseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeCourseCaseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseCaseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeCourseCaseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeCourseCaseParameterBuilder
	
	#region EdCodeCourseCaseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeCourseCaseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCourseCase"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeCourseCaseSortBuilder : SqlSortBuilder<EdCodeCourseCaseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseCaseSqlSortBuilder class.
		/// </summary>
		public EdCodeCourseCaseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeCourseCaseSortBuilder
	
} // end namespace
