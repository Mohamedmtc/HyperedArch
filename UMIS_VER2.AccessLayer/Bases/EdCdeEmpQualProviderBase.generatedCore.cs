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
	/// This class is the base class for any <see cref="EdCdeEmpQualProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeEmpQualProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCdeEmpQual, UMIS_VER2.BusinessLyer.EdCdeEmpQualKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeEmpQualKey key)
		{
			return Delete(transactionManager, key.EdCdeEmpQualId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCdeEmpQualId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCdeEmpQualId)
		{
			return Delete(null, _edCdeEmpQualId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeEmpQualId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCdeEmpQualId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCdeEmpQual Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeEmpQualKey key, int start, int pageLength)
		{
			return GetByEdCdeEmpQualId(transactionManager, key.EdCdeEmpQualId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CDE_EMP_QUAL index.
		/// </summary>
		/// <param name="_edCdeEmpQualId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeEmpQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeEmpQual GetByEdCdeEmpQualId(System.Decimal _edCdeEmpQualId)
		{
			int count = -1;
			return GetByEdCdeEmpQualId(null,_edCdeEmpQualId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EMP_QUAL index.
		/// </summary>
		/// <param name="_edCdeEmpQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeEmpQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeEmpQual GetByEdCdeEmpQualId(System.Decimal _edCdeEmpQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeEmpQualId(null, _edCdeEmpQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EMP_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeEmpQualId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeEmpQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeEmpQual GetByEdCdeEmpQualId(TransactionManager transactionManager, System.Decimal _edCdeEmpQualId)
		{
			int count = -1;
			return GetByEdCdeEmpQualId(transactionManager, _edCdeEmpQualId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EMP_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeEmpQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeEmpQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeEmpQual GetByEdCdeEmpQualId(TransactionManager transactionManager, System.Decimal _edCdeEmpQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeEmpQualId(transactionManager, _edCdeEmpQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EMP_QUAL index.
		/// </summary>
		/// <param name="_edCdeEmpQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeEmpQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeEmpQual GetByEdCdeEmpQualId(System.Decimal _edCdeEmpQualId, int start, int pageLength, out int count)
		{
			return GetByEdCdeEmpQualId(null, _edCdeEmpQualId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_EMP_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeEmpQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeEmpQual"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeEmpQual GetByEdCdeEmpQualId(TransactionManager transactionManager, System.Decimal _edCdeEmpQualId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCdeEmpQual&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCdeEmpQual&gt;"/></returns>
		public static TList<EdCdeEmpQual> Fill(IDataReader reader, TList<EdCdeEmpQual> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCdeEmpQual c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCdeEmpQual")
					.Append("|").Append((System.Decimal)reader["ED_CDE_EMP_QUAL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCdeEmpQual>(
					key.ToString(), // EntityTrackingKey
					"EdCdeEmpQual",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCdeEmpQual();
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
					c.EdCdeEmpQualId = (System.Decimal)reader["ED_CDE_EMP_QUAL_ID"];
					c.OriginalEdCdeEmpQualId = c.EdCdeEmpQualId;
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeEmpQual"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeEmpQual"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCdeEmpQual entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCdeEmpQualId = (System.Decimal)reader[((int)EdCdeEmpQualColumn.EdCdeEmpQualId - 1)];
			entity.OriginalEdCdeEmpQualId = (System.Decimal)reader["ED_CDE_EMP_QUAL_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCdeEmpQualColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EdCdeEmpQualColumn.DescrEn - 1)))?null:(System.String)reader[((int)EdCdeEmpQualColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeEmpQual"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeEmpQual"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCdeEmpQual entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCdeEmpQualId = (System.Decimal)dataRow["ED_CDE_EMP_QUAL_ID"];
			entity.OriginalEdCdeEmpQualId = (System.Decimal)dataRow["ED_CDE_EMP_QUAL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeEmpQual"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeEmpQual Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeEmpQual entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCdeEmpQualId methods when available
			
			#region EdEmployeeQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdEmployeeQual>|EdEmployeeQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdEmployeeQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdEmployeeQualCollection = DataRepository.EdEmployeeQualProvider.GetByEdCdeEmpQualId(transactionManager, entity.EdCdeEmpQualId);

				if (deep && entity.EdEmployeeQualCollection.Count > 0)
				{
					deepHandles.Add("EdEmployeeQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdEmployeeQual>) DataRepository.EdEmployeeQualProvider.DeepLoad,
						new object[] { transactionManager, entity.EdEmployeeQualCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCdeEmpQual object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCdeEmpQual instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeEmpQual Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeEmpQual entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdEmployeeQual>
				if (CanDeepSave(entity.EdEmployeeQualCollection, "List<EdEmployeeQual>|EdEmployeeQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdEmployeeQual child in entity.EdEmployeeQualCollection)
					{
						if(child.EdCdeEmpQualIdSource != null)
						{
							child.EdCdeEmpQualId = child.EdCdeEmpQualIdSource.EdCdeEmpQualId;
						}
						else
						{
							child.EdCdeEmpQualId = entity.EdCdeEmpQualId;
						}

					}

					if (entity.EdEmployeeQualCollection.Count > 0 || entity.EdEmployeeQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdEmployeeQualProvider.Save(transactionManager, entity.EdEmployeeQualCollection);
						
						deepHandles.Add("EdEmployeeQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdEmployeeQual >) DataRepository.EdEmployeeQualProvider.DeepSave,
							new object[] { transactionManager, entity.EdEmployeeQualCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCdeEmpQualChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCdeEmpQual</c>
	///</summary>
	public enum EdCdeEmpQualChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCdeEmpQual</c> as OneToMany for EdEmployeeQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdEmployeeQual>))]
		EdEmployeeQualCollection,
	}
	
	#endregion EdCdeEmpQualChildEntityTypes
	
	#region EdCdeEmpQualFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCdeEmpQualColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeEmpQual"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeEmpQualFilterBuilder : SqlFilterBuilder<EdCdeEmpQualColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeEmpQualFilterBuilder class.
		/// </summary>
		public EdCdeEmpQualFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeEmpQualFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeEmpQualFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeEmpQualFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeEmpQualFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeEmpQualFilterBuilder
	
	#region EdCdeEmpQualParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCdeEmpQualColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeEmpQual"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeEmpQualParameterBuilder : ParameterizedSqlFilterBuilder<EdCdeEmpQualColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeEmpQualParameterBuilder class.
		/// </summary>
		public EdCdeEmpQualParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeEmpQualParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeEmpQualParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeEmpQualParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeEmpQualParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeEmpQualParameterBuilder
	
	#region EdCdeEmpQualSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCdeEmpQualColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeEmpQual"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCdeEmpQualSortBuilder : SqlSortBuilder<EdCdeEmpQualColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeEmpQualSqlSortBuilder class.
		/// </summary>
		public EdCdeEmpQualSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCdeEmpQualSortBuilder
	
} // end namespace
