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
	/// This class is the base class for any <see cref="EdCdeSchoolGradeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeSchoolGradeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCdeSchoolGrade, UMIS_VER2.BusinessLyer.EdCdeSchoolGradeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeSchoolGradeKey key)
		{
			return Delete(transactionManager, key.EdCdeSchoolGradeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCdeSchoolGradeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _edCdeSchoolGradeId)
		{
			return Delete(null, _edCdeSchoolGradeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeSchoolGradeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _edCdeSchoolGradeId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCdeSchoolGrade Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeSchoolGradeKey key, int start, int pageLength)
		{
			return GetByEdCdeSchoolGradeId(transactionManager, key.EdCdeSchoolGradeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CDE_SCHOOL_GRADE index.
		/// </summary>
		/// <param name="_edCdeSchoolGradeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeSchoolGrade"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeSchoolGrade GetByEdCdeSchoolGradeId(System.Int32 _edCdeSchoolGradeId)
		{
			int count = -1;
			return GetByEdCdeSchoolGradeId(null,_edCdeSchoolGradeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_SCHOOL_GRADE index.
		/// </summary>
		/// <param name="_edCdeSchoolGradeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeSchoolGrade"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeSchoolGrade GetByEdCdeSchoolGradeId(System.Int32 _edCdeSchoolGradeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeSchoolGradeId(null, _edCdeSchoolGradeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_SCHOOL_GRADE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeSchoolGradeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeSchoolGrade"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeSchoolGrade GetByEdCdeSchoolGradeId(TransactionManager transactionManager, System.Int32 _edCdeSchoolGradeId)
		{
			int count = -1;
			return GetByEdCdeSchoolGradeId(transactionManager, _edCdeSchoolGradeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_SCHOOL_GRADE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeSchoolGradeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeSchoolGrade"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeSchoolGrade GetByEdCdeSchoolGradeId(TransactionManager transactionManager, System.Int32 _edCdeSchoolGradeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeSchoolGradeId(transactionManager, _edCdeSchoolGradeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_SCHOOL_GRADE index.
		/// </summary>
		/// <param name="_edCdeSchoolGradeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeSchoolGrade"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeSchoolGrade GetByEdCdeSchoolGradeId(System.Int32 _edCdeSchoolGradeId, int start, int pageLength, out int count)
		{
			return GetByEdCdeSchoolGradeId(null, _edCdeSchoolGradeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_SCHOOL_GRADE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeSchoolGradeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeSchoolGrade"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeSchoolGrade GetByEdCdeSchoolGradeId(TransactionManager transactionManager, System.Int32 _edCdeSchoolGradeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCdeSchoolGrade&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCdeSchoolGrade&gt;"/></returns>
		public static TList<EdCdeSchoolGrade> Fill(IDataReader reader, TList<EdCdeSchoolGrade> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCdeSchoolGrade c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCdeSchoolGrade")
					.Append("|").Append((System.Int32)reader["ED_CDE_SCHOOL_GRADE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCdeSchoolGrade>(
					key.ToString(), // EntityTrackingKey
					"EdCdeSchoolGrade",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCdeSchoolGrade();
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
					c.EdCdeSchoolGradeId = (System.Int32)reader["ED_CDE_SCHOOL_GRADE_ID"];
					c.OriginalEdCdeSchoolGradeId = c.EdCdeSchoolGradeId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeSchoolGrade"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeSchoolGrade"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCdeSchoolGrade entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCdeSchoolGradeId = (System.Int32)reader[((int)EdCdeSchoolGradeColumn.EdCdeSchoolGradeId - 1)];
			entity.OriginalEdCdeSchoolGradeId = (System.Int32)reader["ED_CDE_SCHOOL_GRADE_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCdeSchoolGradeColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EdCdeSchoolGradeColumn.DescrEn - 1)))?null:(System.String)reader[((int)EdCdeSchoolGradeColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeSchoolGrade"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeSchoolGrade"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCdeSchoolGrade entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCdeSchoolGradeId = (System.Int32)dataRow["ED_CDE_SCHOOL_GRADE_ID"];
			entity.OriginalEdCdeSchoolGradeId = (System.Int32)dataRow["ED_CDE_SCHOOL_GRADE_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeSchoolGrade"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeSchoolGrade Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeSchoolGrade entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCdeSchoolGradeId methods when available
			
			#region EdStudQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQual>|EdStudQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualCollection = DataRepository.EdStudQualProvider.GetByEdCdeSchoolGradeId(transactionManager, entity.EdCdeSchoolGradeId);

				if (deep && entity.EdStudQualCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQual>) DataRepository.EdStudQualProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCdeSchoolGrade object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCdeSchoolGrade instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeSchoolGrade Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeSchoolGrade entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudQual>
				if (CanDeepSave(entity.EdStudQualCollection, "List<EdStudQual>|EdStudQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQual child in entity.EdStudQualCollection)
					{
						if(child.EdCdeSchoolGradeIdSource != null)
						{
							child.EdCdeSchoolGradeId = child.EdCdeSchoolGradeIdSource.EdCdeSchoolGradeId;
						}
						else
						{
							child.EdCdeSchoolGradeId = entity.EdCdeSchoolGradeId;
						}

					}

					if (entity.EdStudQualCollection.Count > 0 || entity.EdStudQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudQualProvider.Save(transactionManager, entity.EdStudQualCollection);
						
						deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudQual >) DataRepository.EdStudQualProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudQualCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCdeSchoolGradeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCdeSchoolGrade</c>
	///</summary>
	public enum EdCdeSchoolGradeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCdeSchoolGrade</c> as OneToMany for EdStudQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQual>))]
		EdStudQualCollection,
	}
	
	#endregion EdCdeSchoolGradeChildEntityTypes
	
	#region EdCdeSchoolGradeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCdeSchoolGradeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeSchoolGrade"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeSchoolGradeFilterBuilder : SqlFilterBuilder<EdCdeSchoolGradeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeSchoolGradeFilterBuilder class.
		/// </summary>
		public EdCdeSchoolGradeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeSchoolGradeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeSchoolGradeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeSchoolGradeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeSchoolGradeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeSchoolGradeFilterBuilder
	
	#region EdCdeSchoolGradeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCdeSchoolGradeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeSchoolGrade"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeSchoolGradeParameterBuilder : ParameterizedSqlFilterBuilder<EdCdeSchoolGradeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeSchoolGradeParameterBuilder class.
		/// </summary>
		public EdCdeSchoolGradeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeSchoolGradeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeSchoolGradeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeSchoolGradeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeSchoolGradeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeSchoolGradeParameterBuilder
	
	#region EdCdeSchoolGradeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCdeSchoolGradeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeSchoolGrade"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCdeSchoolGradeSortBuilder : SqlSortBuilder<EdCdeSchoolGradeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeSchoolGradeSqlSortBuilder class.
		/// </summary>
		public EdCdeSchoolGradeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCdeSchoolGradeSortBuilder
	
} // end namespace
