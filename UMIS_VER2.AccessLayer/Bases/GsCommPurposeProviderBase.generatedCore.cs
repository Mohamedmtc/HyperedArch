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
	/// This class is the base class for any <see cref="GsCommPurposeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCommPurposeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCommPurpose, UMIS_VER2.BusinessLyer.GsCommPurposeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCommPurposeKey key)
		{
			return Delete(transactionManager, key.GsCommPurposeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCommPurposeId">XX not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCommPurposeId)
		{
			return Delete(null, _gsCommPurposeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommPurposeId">XX not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCommPurposeId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCommPurpose Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCommPurposeKey key, int start, int pageLength)
		{
			return GetByGsCommPurposeId(transactionManager, key.GsCommPurposeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_COMM_PURPOSE index.
		/// </summary>
		/// <param name="_gsCommPurposeId">XX not used</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommPurpose"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommPurpose GetByGsCommPurposeId(System.Decimal _gsCommPurposeId)
		{
			int count = -1;
			return GetByGsCommPurposeId(null,_gsCommPurposeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_PURPOSE index.
		/// </summary>
		/// <param name="_gsCommPurposeId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommPurpose"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommPurpose GetByGsCommPurposeId(System.Decimal _gsCommPurposeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommPurposeId(null, _gsCommPurposeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_PURPOSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommPurposeId">XX not used</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommPurpose"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommPurpose GetByGsCommPurposeId(TransactionManager transactionManager, System.Decimal _gsCommPurposeId)
		{
			int count = -1;
			return GetByGsCommPurposeId(transactionManager, _gsCommPurposeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_PURPOSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommPurposeId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommPurpose"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommPurpose GetByGsCommPurposeId(TransactionManager transactionManager, System.Decimal _gsCommPurposeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommPurposeId(transactionManager, _gsCommPurposeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_PURPOSE index.
		/// </summary>
		/// <param name="_gsCommPurposeId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommPurpose"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommPurpose GetByGsCommPurposeId(System.Decimal _gsCommPurposeId, int start, int pageLength, out int count)
		{
			return GetByGsCommPurposeId(null, _gsCommPurposeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_PURPOSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommPurposeId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommPurpose"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCommPurpose GetByGsCommPurposeId(TransactionManager transactionManager, System.Decimal _gsCommPurposeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCommPurpose&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCommPurpose&gt;"/></returns>
		public static TList<GsCommPurpose> Fill(IDataReader reader, TList<GsCommPurpose> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCommPurpose c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCommPurpose")
					.Append("|").Append((System.Decimal)reader["GS_COMM_PURPOSE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCommPurpose>(
					key.ToString(), // EntityTrackingKey
					"GsCommPurpose",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCommPurpose();
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
					c.GsCommPurposeId = (System.Decimal)reader["GS_COMM_PURPOSE_ID"];
					c.OriginalGsCommPurposeId = c.GsCommPurposeId;
					c.PurposeDescAr = (System.String)reader["PURPOSE_DESC_AR"];
					c.PurposeDescEn = (System.String)reader["PURPOSE_DESC_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCommPurpose"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCommPurpose"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCommPurpose entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCommPurposeId = (System.Decimal)reader[((int)GsCommPurposeColumn.GsCommPurposeId - 1)];
			entity.OriginalGsCommPurposeId = (System.Decimal)reader["GS_COMM_PURPOSE_ID"];
			entity.PurposeDescAr = (System.String)reader[((int)GsCommPurposeColumn.PurposeDescAr - 1)];
			entity.PurposeDescEn = (System.String)reader[((int)GsCommPurposeColumn.PurposeDescEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCommPurpose"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCommPurpose"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCommPurpose entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCommPurposeId = (System.Decimal)dataRow["GS_COMM_PURPOSE_ID"];
			entity.OriginalGsCommPurposeId = (System.Decimal)dataRow["GS_COMM_PURPOSE_ID"];
			entity.PurposeDescAr = (System.String)dataRow["PURPOSE_DESC_AR"];
			entity.PurposeDescEn = (System.String)dataRow["PURPOSE_DESC_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCommPurpose"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCommPurpose Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCommPurpose entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCommPurposeId methods when available
			
			#region GsCommCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsComm>|GsCommCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCommCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCommCollection = DataRepository.GsCommProvider.GetByGsCommPurposeId(transactionManager, entity.GsCommPurposeId);

				if (deep && entity.GsCommCollection.Count > 0)
				{
					deepHandles.Add("GsCommCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsComm>) DataRepository.GsCommProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCommCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCommPurpose object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCommPurpose instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCommPurpose Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCommPurpose entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<GsComm>
				if (CanDeepSave(entity.GsCommCollection, "List<GsComm>|GsCommCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsComm child in entity.GsCommCollection)
					{
						if(child.GsCommPurposeIdSource != null)
						{
							child.GsCommPurposeId = child.GsCommPurposeIdSource.GsCommPurposeId;
						}
						else
						{
							child.GsCommPurposeId = entity.GsCommPurposeId;
						}

					}

					if (entity.GsCommCollection.Count > 0 || entity.GsCommCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCommProvider.Save(transactionManager, entity.GsCommCollection);
						
						deepHandles.Add("GsCommCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsComm >) DataRepository.GsCommProvider.DeepSave,
							new object[] { transactionManager, entity.GsCommCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCommPurposeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCommPurpose</c>
	///</summary>
	public enum GsCommPurposeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCommPurpose</c> as OneToMany for GsCommCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsComm>))]
		GsCommCollection,
	}
	
	#endregion GsCommPurposeChildEntityTypes
	
	#region GsCommPurposeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCommPurposeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCommPurpose"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCommPurposeFilterBuilder : SqlFilterBuilder<GsCommPurposeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCommPurposeFilterBuilder class.
		/// </summary>
		public GsCommPurposeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCommPurposeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCommPurposeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCommPurposeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCommPurposeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCommPurposeFilterBuilder
	
	#region GsCommPurposeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCommPurposeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCommPurpose"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCommPurposeParameterBuilder : ParameterizedSqlFilterBuilder<GsCommPurposeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCommPurposeParameterBuilder class.
		/// </summary>
		public GsCommPurposeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCommPurposeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCommPurposeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCommPurposeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCommPurposeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCommPurposeParameterBuilder
	
	#region GsCommPurposeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCommPurposeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCommPurpose"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCommPurposeSortBuilder : SqlSortBuilder<GsCommPurposeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCommPurposeSqlSortBuilder class.
		/// </summary>
		public GsCommPurposeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCommPurposeSortBuilder
	
} // end namespace
