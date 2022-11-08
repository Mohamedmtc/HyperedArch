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
	/// This class is the base class for any <see cref="SaCodeCommMemberTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeCommMemberTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeCommMemberType, UMIS_VER2.BusinessLyer.SaCodeCommMemberTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeCommMemberTypeKey key)
		{
			return Delete(transactionManager, key.SaCodeCommMemberTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeCommMemberTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeCommMemberTypeId)
		{
			return Delete(null, _saCodeCommMemberTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCommMemberTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeCommMemberTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeCommMemberType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeCommMemberTypeKey key, int start, int pageLength)
		{
			return GetBySaCodeCommMemberTypeId(transactionManager, key.SaCodeCommMemberTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_COMM_MEMBER_TYPE index.
		/// </summary>
		/// <param name="_saCodeCommMemberTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCommMemberType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCommMemberType GetBySaCodeCommMemberTypeId(System.Decimal _saCodeCommMemberTypeId)
		{
			int count = -1;
			return GetBySaCodeCommMemberTypeId(null,_saCodeCommMemberTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COMM_MEMBER_TYPE index.
		/// </summary>
		/// <param name="_saCodeCommMemberTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCommMemberType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCommMemberType GetBySaCodeCommMemberTypeId(System.Decimal _saCodeCommMemberTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeCommMemberTypeId(null, _saCodeCommMemberTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COMM_MEMBER_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCommMemberTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCommMemberType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCommMemberType GetBySaCodeCommMemberTypeId(TransactionManager transactionManager, System.Decimal _saCodeCommMemberTypeId)
		{
			int count = -1;
			return GetBySaCodeCommMemberTypeId(transactionManager, _saCodeCommMemberTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COMM_MEMBER_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCommMemberTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCommMemberType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCommMemberType GetBySaCodeCommMemberTypeId(TransactionManager transactionManager, System.Decimal _saCodeCommMemberTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeCommMemberTypeId(transactionManager, _saCodeCommMemberTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COMM_MEMBER_TYPE index.
		/// </summary>
		/// <param name="_saCodeCommMemberTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCommMemberType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeCommMemberType GetBySaCodeCommMemberTypeId(System.Decimal _saCodeCommMemberTypeId, int start, int pageLength, out int count)
		{
			return GetBySaCodeCommMemberTypeId(null, _saCodeCommMemberTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_COMM_MEMBER_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCommMemberTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeCommMemberType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeCommMemberType GetBySaCodeCommMemberTypeId(TransactionManager transactionManager, System.Decimal _saCodeCommMemberTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeCommMemberType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeCommMemberType&gt;"/></returns>
		public static TList<SaCodeCommMemberType> Fill(IDataReader reader, TList<SaCodeCommMemberType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeCommMemberType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeCommMemberType")
					.Append("|").Append((System.Decimal)reader["SA_CODE_COMM_MEMBER_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeCommMemberType>(
					key.ToString(), // EntityTrackingKey
					"SaCodeCommMemberType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeCommMemberType();
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
					c.SaCodeCommMemberTypeId = (System.Decimal)reader["SA_CODE_COMM_MEMBER_TYPE_ID"];
					c.OriginalSaCodeCommMemberTypeId = c.SaCodeCommMemberTypeId;
					c.CommMemberTypeDescrAr = Convert.IsDBNull(reader["COMM_MEMBER_TYPE_DESCR_AR"]) ? null : (System.String)reader["COMM_MEMBER_TYPE_DESCR_AR"];
					c.CommMemberTypeDescrEn = (System.String)reader["COMM_MEMBER_TYPE_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeCommMemberType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeCommMemberType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeCommMemberType entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeCommMemberTypeId = (System.Decimal)reader[((int)SaCodeCommMemberTypeColumn.SaCodeCommMemberTypeId - 1)];
			entity.OriginalSaCodeCommMemberTypeId = (System.Decimal)reader["SA_CODE_COMM_MEMBER_TYPE_ID"];
			entity.CommMemberTypeDescrAr = (reader.IsDBNull(((int)SaCodeCommMemberTypeColumn.CommMemberTypeDescrAr - 1)))?null:(System.String)reader[((int)SaCodeCommMemberTypeColumn.CommMemberTypeDescrAr - 1)];
			entity.CommMemberTypeDescrEn = (System.String)reader[((int)SaCodeCommMemberTypeColumn.CommMemberTypeDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeCommMemberType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeCommMemberType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeCommMemberType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeCommMemberTypeId = (System.Decimal)dataRow["SA_CODE_COMM_MEMBER_TYPE_ID"];
			entity.OriginalSaCodeCommMemberTypeId = (System.Decimal)dataRow["SA_CODE_COMM_MEMBER_TYPE_ID"];
			entity.CommMemberTypeDescrAr = Convert.IsDBNull(dataRow["COMM_MEMBER_TYPE_DESCR_AR"]) ? null : (System.String)dataRow["COMM_MEMBER_TYPE_DESCR_AR"];
			entity.CommMemberTypeDescrEn = (System.String)dataRow["COMM_MEMBER_TYPE_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeCommMemberType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeCommMemberType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeCommMemberType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeCommMemberTypeId methods when available
			
			#region SaCommMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaCommMember>|SaCommMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCommMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaCommMemberCollection = DataRepository.SaCommMemberProvider.GetBySaCodeCommMemberTypeId(transactionManager, entity.SaCodeCommMemberTypeId);

				if (deep && entity.SaCommMemberCollection.Count > 0)
				{
					deepHandles.Add("SaCommMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaCommMember>) DataRepository.SaCommMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.SaCommMemberCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeCommMemberType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeCommMemberType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeCommMemberType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeCommMemberType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaCommMember>
				if (CanDeepSave(entity.SaCommMemberCollection, "List<SaCommMember>|SaCommMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaCommMember child in entity.SaCommMemberCollection)
					{
						if(child.SaCodeCommMemberTypeIdSource != null)
						{
							child.SaCodeCommMemberTypeId = child.SaCodeCommMemberTypeIdSource.SaCodeCommMemberTypeId;
						}
						else
						{
							child.SaCodeCommMemberTypeId = entity.SaCodeCommMemberTypeId;
						}

					}

					if (entity.SaCommMemberCollection.Count > 0 || entity.SaCommMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaCommMemberProvider.Save(transactionManager, entity.SaCommMemberCollection);
						
						deepHandles.Add("SaCommMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaCommMember >) DataRepository.SaCommMemberProvider.DeepSave,
							new object[] { transactionManager, entity.SaCommMemberCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodeCommMemberTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeCommMemberType</c>
	///</summary>
	public enum SaCodeCommMemberTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCodeCommMemberType</c> as OneToMany for SaCommMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaCommMember>))]
		SaCommMemberCollection,
	}
	
	#endregion SaCodeCommMemberTypeChildEntityTypes
	
	#region SaCodeCommMemberTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeCommMemberTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeCommMemberType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeCommMemberTypeFilterBuilder : SqlFilterBuilder<SaCodeCommMemberTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeCommMemberTypeFilterBuilder class.
		/// </summary>
		public SaCodeCommMemberTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeCommMemberTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeCommMemberTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeCommMemberTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeCommMemberTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeCommMemberTypeFilterBuilder
	
	#region SaCodeCommMemberTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeCommMemberTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeCommMemberType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeCommMemberTypeParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeCommMemberTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeCommMemberTypeParameterBuilder class.
		/// </summary>
		public SaCodeCommMemberTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeCommMemberTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeCommMemberTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeCommMemberTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeCommMemberTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeCommMemberTypeParameterBuilder
	
	#region SaCodeCommMemberTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeCommMemberTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeCommMemberType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeCommMemberTypeSortBuilder : SqlSortBuilder<SaCodeCommMemberTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeCommMemberTypeSqlSortBuilder class.
		/// </summary>
		public SaCodeCommMemberTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeCommMemberTypeSortBuilder
	
} // end namespace
