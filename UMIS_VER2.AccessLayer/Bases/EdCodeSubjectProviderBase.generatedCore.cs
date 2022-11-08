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
	/// This class is the base class for any <see cref="EdCodeSubjectProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeSubjectProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeSubject, UMIS_VER2.BusinessLyer.EdCodeSubjectKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeSubjectKey key)
		{
			return Delete(transactionManager, key.EdCodeSubjectId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeSubjectId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _edCodeSubjectId)
		{
			return Delete(null, _edCodeSubjectId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSubjectId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _edCodeSubjectId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeSubject Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeSubjectKey key, int start, int pageLength)
		{
			return GetByEdCodeSubjectId(transactionManager, key.EdCodeSubjectId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_SUBJECT index.
		/// </summary>
		/// <param name="_edCodeSubjectId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSubject"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSubject GetByEdCodeSubjectId(System.Int32 _edCodeSubjectId)
		{
			int count = -1;
			return GetByEdCodeSubjectId(null,_edCodeSubjectId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SUBJECT index.
		/// </summary>
		/// <param name="_edCodeSubjectId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSubject"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSubject GetByEdCodeSubjectId(System.Int32 _edCodeSubjectId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSubjectId(null, _edCodeSubjectId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SUBJECT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSubjectId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSubject"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSubject GetByEdCodeSubjectId(TransactionManager transactionManager, System.Int32 _edCodeSubjectId)
		{
			int count = -1;
			return GetByEdCodeSubjectId(transactionManager, _edCodeSubjectId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SUBJECT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSubjectId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSubject"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSubject GetByEdCodeSubjectId(TransactionManager transactionManager, System.Int32 _edCodeSubjectId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSubjectId(transactionManager, _edCodeSubjectId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SUBJECT index.
		/// </summary>
		/// <param name="_edCodeSubjectId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSubject"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSubject GetByEdCodeSubjectId(System.Int32 _edCodeSubjectId, int start, int pageLength, out int count)
		{
			return GetByEdCodeSubjectId(null, _edCodeSubjectId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SUBJECT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSubjectId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSubject"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeSubject GetByEdCodeSubjectId(TransactionManager transactionManager, System.Int32 _edCodeSubjectId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeSubject&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeSubject&gt;"/></returns>
		public static TList<EdCodeSubject> Fill(IDataReader reader, TList<EdCodeSubject> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeSubject c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeSubject")
					.Append("|").Append((System.Int32)reader["ED_CODE_SUBJECT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeSubject>(
					key.ToString(), // EntityTrackingKey
					"EdCodeSubject",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeSubject();
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
					c.EdCodeSubjectId = (System.Int32)reader["ED_CODE_SUBJECT_ID"];
					c.OriginalEdCodeSubjectId = c.EdCodeSubjectId;
					c.SubjCode = Convert.IsDBNull(reader["SUBJ_CODE"]) ? null : (System.String)reader["SUBJ_CODE"];
					c.SubjAr = (System.String)reader["SUBJ_AR"];
					c.SubjEn = (System.String)reader["SUBJ_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeSubject"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeSubject"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeSubject entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeSubjectId = (System.Int32)reader[((int)EdCodeSubjectColumn.EdCodeSubjectId - 1)];
			entity.OriginalEdCodeSubjectId = (System.Int32)reader["ED_CODE_SUBJECT_ID"];
			entity.SubjCode = (reader.IsDBNull(((int)EdCodeSubjectColumn.SubjCode - 1)))?null:(System.String)reader[((int)EdCodeSubjectColumn.SubjCode - 1)];
			entity.SubjAr = (System.String)reader[((int)EdCodeSubjectColumn.SubjAr - 1)];
			entity.SubjEn = (System.String)reader[((int)EdCodeSubjectColumn.SubjEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeSubject"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeSubject"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeSubject entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeSubjectId = (System.Int32)dataRow["ED_CODE_SUBJECT_ID"];
			entity.OriginalEdCodeSubjectId = (System.Int32)dataRow["ED_CODE_SUBJECT_ID"];
			entity.SubjCode = Convert.IsDBNull(dataRow["SUBJ_CODE"]) ? null : (System.String)dataRow["SUBJ_CODE"];
			entity.SubjAr = (System.String)dataRow["SUBJ_AR"];
			entity.SubjEn = (System.String)dataRow["SUBJ_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeSubject"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeSubject Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeSubject entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeSubjectId methods when available
			
			#region EdCodeQualSubjectCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCodeQualSubject>|EdCodeQualSubjectCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeQualSubjectCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCodeQualSubjectCollection = DataRepository.EdCodeQualSubjectProvider.GetByEdCodeSubjectId(transactionManager, entity.EdCodeSubjectId);

				if (deep && entity.EdCodeQualSubjectCollection.Count > 0)
				{
					deepHandles.Add("EdCodeQualSubjectCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCodeQualSubject>) DataRepository.EdCodeQualSubjectProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCodeQualSubjectCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeSubject object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeSubject instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeSubject Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeSubject entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdCodeQualSubject>
				if (CanDeepSave(entity.EdCodeQualSubjectCollection, "List<EdCodeQualSubject>|EdCodeQualSubjectCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCodeQualSubject child in entity.EdCodeQualSubjectCollection)
					{
						if(child.EdCodeSubjectIdSource != null)
						{
							child.EdCodeSubjectId = child.EdCodeSubjectIdSource.EdCodeSubjectId;
						}
						else
						{
							child.EdCodeSubjectId = entity.EdCodeSubjectId;
						}

					}

					if (entity.EdCodeQualSubjectCollection.Count > 0 || entity.EdCodeQualSubjectCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCodeQualSubjectProvider.Save(transactionManager, entity.EdCodeQualSubjectCollection);
						
						deepHandles.Add("EdCodeQualSubjectCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCodeQualSubject >) DataRepository.EdCodeQualSubjectProvider.DeepSave,
							new object[] { transactionManager, entity.EdCodeQualSubjectCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeSubjectChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeSubject</c>
	///</summary>
	public enum EdCodeSubjectChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCodeSubject</c> as OneToMany for EdCodeQualSubjectCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCodeQualSubject>))]
		EdCodeQualSubjectCollection,
	}
	
	#endregion EdCodeSubjectChildEntityTypes
	
	#region EdCodeSubjectFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeSubjectColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeSubject"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeSubjectFilterBuilder : SqlFilterBuilder<EdCodeSubjectColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeSubjectFilterBuilder class.
		/// </summary>
		public EdCodeSubjectFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeSubjectFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeSubjectFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeSubjectFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeSubjectFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeSubjectFilterBuilder
	
	#region EdCodeSubjectParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeSubjectColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeSubject"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeSubjectParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeSubjectColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeSubjectParameterBuilder class.
		/// </summary>
		public EdCodeSubjectParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeSubjectParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeSubjectParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeSubjectParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeSubjectParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeSubjectParameterBuilder
	
	#region EdCodeSubjectSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeSubjectColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeSubject"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeSubjectSortBuilder : SqlSortBuilder<EdCodeSubjectColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeSubjectSqlSortBuilder class.
		/// </summary>
		public EdCodeSubjectSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeSubjectSortBuilder
	
} // end namespace
