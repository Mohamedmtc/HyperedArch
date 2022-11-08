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
	/// This class is the base class for any <see cref="SeControlTechTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeControlTechTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeControlTechType, UMIS_VER2.BusinessLyer.SeControlTechTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeControlTechTypeKey key)
		{
			return Delete(transactionManager, key.SeControlTechTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seControlTechTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seControlTechTypeId)
		{
			return Delete(null, _seControlTechTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seControlTechTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seControlTechTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.SeControlTechType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeControlTechTypeKey key, int start, int pageLength)
		{
			return GetBySeControlTechTypeId(transactionManager, key.SeControlTechTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_CONTROL_TYPE_T_DESC_AR index.
		/// </summary>
		/// <param name="_descEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeControlTechType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeControlTechType GetByDescEn(System.String _descEn)
		{
			int count = -1;
			return GetByDescEn(null,_descEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_CONTROL_TYPE_T_DESC_AR index.
		/// </summary>
		/// <param name="_descEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeControlTechType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeControlTechType GetByDescEn(System.String _descEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescEn(null, _descEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_CONTROL_TYPE_T_DESC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeControlTechType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeControlTechType GetByDescEn(TransactionManager transactionManager, System.String _descEn)
		{
			int count = -1;
			return GetByDescEn(transactionManager, _descEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_CONTROL_TYPE_T_DESC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeControlTechType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeControlTechType GetByDescEn(TransactionManager transactionManager, System.String _descEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescEn(transactionManager, _descEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_CONTROL_TYPE_T_DESC_AR index.
		/// </summary>
		/// <param name="_descEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeControlTechType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeControlTechType GetByDescEn(System.String _descEn, int start, int pageLength, out int count)
		{
			return GetByDescEn(null, _descEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_CONTROL_TYPE_T_DESC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeControlTechType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeControlTechType GetByDescEn(TransactionManager transactionManager, System.String _descEn, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_CONTROL_TECH_TYPE index.
		/// </summary>
		/// <param name="_seControlTechTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeControlTechType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeControlTechType GetBySeControlTechTypeId(System.Decimal _seControlTechTypeId)
		{
			int count = -1;
			return GetBySeControlTechTypeId(null,_seControlTechTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CONTROL_TECH_TYPE index.
		/// </summary>
		/// <param name="_seControlTechTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeControlTechType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeControlTechType GetBySeControlTechTypeId(System.Decimal _seControlTechTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeControlTechTypeId(null, _seControlTechTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CONTROL_TECH_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seControlTechTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeControlTechType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeControlTechType GetBySeControlTechTypeId(TransactionManager transactionManager, System.Decimal _seControlTechTypeId)
		{
			int count = -1;
			return GetBySeControlTechTypeId(transactionManager, _seControlTechTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CONTROL_TECH_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seControlTechTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeControlTechType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeControlTechType GetBySeControlTechTypeId(TransactionManager transactionManager, System.Decimal _seControlTechTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeControlTechTypeId(transactionManager, _seControlTechTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CONTROL_TECH_TYPE index.
		/// </summary>
		/// <param name="_seControlTechTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeControlTechType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeControlTechType GetBySeControlTechTypeId(System.Decimal _seControlTechTypeId, int start, int pageLength, out int count)
		{
			return GetBySeControlTechTypeId(null, _seControlTechTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CONTROL_TECH_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seControlTechTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeControlTechType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeControlTechType GetBySeControlTechTypeId(TransactionManager transactionManager, System.Decimal _seControlTechTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeControlTechType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeControlTechType&gt;"/></returns>
		public static TList<SeControlTechType> Fill(IDataReader reader, TList<SeControlTechType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeControlTechType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeControlTechType")
					.Append("|").Append((System.Decimal)reader["SE_CONTROL_TECH_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeControlTechType>(
					key.ToString(), // EntityTrackingKey
					"SeControlTechType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeControlTechType();
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
					c.SeControlTechTypeId = (System.Decimal)reader["SE_CONTROL_TECH_TYPE_ID"];
					c.DescEn = (System.String)reader["DESC_EN"];
					c.DescAr = Convert.IsDBNull(reader["DESC_AR"]) ? null : (System.String)reader["DESC_AR"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeControlTechType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeControlTechType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeControlTechType entity)
		{
			if (!reader.Read()) return;
			
			entity.SeControlTechTypeId = (System.Decimal)reader[((int)SeControlTechTypeColumn.SeControlTechTypeId - 1)];
			entity.DescEn = (System.String)reader[((int)SeControlTechTypeColumn.DescEn - 1)];
			entity.DescAr = (reader.IsDBNull(((int)SeControlTechTypeColumn.DescAr - 1)))?null:(System.String)reader[((int)SeControlTechTypeColumn.DescAr - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeControlTechType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeControlTechType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeControlTechType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeControlTechTypeId = (System.Decimal)dataRow["SE_CONTROL_TECH_TYPE_ID"];
			entity.DescEn = (System.String)dataRow["DESC_EN"];
			entity.DescAr = Convert.IsDBNull(dataRow["DESC_AR"]) ? null : (System.String)dataRow["DESC_AR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeControlTechType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeControlTechType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeControlTechType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySeControlTechTypeId methods when available
			
			#region SysFormControlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SysFormControl>|SysFormControlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SysFormControlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SysFormControlCollection = DataRepository.SysFormControlProvider.GetBySeControlTechTypeId(transactionManager, entity.SeControlTechTypeId);

				if (deep && entity.SysFormControlCollection.Count > 0)
				{
					deepHandles.Add("SysFormControlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SysFormControl>) DataRepository.SysFormControlProvider.DeepLoad,
						new object[] { transactionManager, entity.SysFormControlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeFormControlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeFormControl>|SeFormControlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeFormControlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeFormControlCollection = DataRepository.SeFormControlProvider.GetBySeControlTechTypeId(transactionManager, entity.SeControlTechTypeId);

				if (deep && entity.SeFormControlCollection.Count > 0)
				{
					deepHandles.Add("SeFormControlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeFormControl>) DataRepository.SeFormControlProvider.DeepLoad,
						new object[] { transactionManager, entity.SeFormControlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeControlTechType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeControlTechType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeControlTechType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeControlTechType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SysFormControl>
				if (CanDeepSave(entity.SysFormControlCollection, "List<SysFormControl>|SysFormControlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SysFormControl child in entity.SysFormControlCollection)
					{
						if(child.SeControlTechTypeIdSource != null)
						{
							child.SeControlTechTypeId = child.SeControlTechTypeIdSource.SeControlTechTypeId;
						}
						else
						{
							child.SeControlTechTypeId = entity.SeControlTechTypeId;
						}

					}

					if (entity.SysFormControlCollection.Count > 0 || entity.SysFormControlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SysFormControlProvider.Save(transactionManager, entity.SysFormControlCollection);
						
						deepHandles.Add("SysFormControlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SysFormControl >) DataRepository.SysFormControlProvider.DeepSave,
							new object[] { transactionManager, entity.SysFormControlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeFormControl>
				if (CanDeepSave(entity.SeFormControlCollection, "List<SeFormControl>|SeFormControlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeFormControl child in entity.SeFormControlCollection)
					{
						if(child.SeControlTechTypeIdSource != null)
						{
							child.SeControlTechTypeId = child.SeControlTechTypeIdSource.SeControlTechTypeId;
						}
						else
						{
							child.SeControlTechTypeId = entity.SeControlTechTypeId;
						}

					}

					if (entity.SeFormControlCollection.Count > 0 || entity.SeFormControlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeFormControlProvider.Save(transactionManager, entity.SeFormControlCollection);
						
						deepHandles.Add("SeFormControlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeFormControl >) DataRepository.SeFormControlProvider.DeepSave,
							new object[] { transactionManager, entity.SeFormControlCollection, deepSaveType, childTypes, innerList }
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
	
	#region SeControlTechTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeControlTechType</c>
	///</summary>
	public enum SeControlTechTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SeControlTechType</c> as OneToMany for SysFormControlCollection
		///</summary>
		[ChildEntityType(typeof(TList<SysFormControl>))]
		SysFormControlCollection,
		///<summary>
		/// Collection of <c>SeControlTechType</c> as OneToMany for SeFormControlCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeFormControl>))]
		SeFormControlCollection,
	}
	
	#endregion SeControlTechTypeChildEntityTypes
	
	#region SeControlTechTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeControlTechTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeControlTechType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeControlTechTypeFilterBuilder : SqlFilterBuilder<SeControlTechTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeControlTechTypeFilterBuilder class.
		/// </summary>
		public SeControlTechTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeControlTechTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeControlTechTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeControlTechTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeControlTechTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeControlTechTypeFilterBuilder
	
	#region SeControlTechTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeControlTechTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeControlTechType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeControlTechTypeParameterBuilder : ParameterizedSqlFilterBuilder<SeControlTechTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeControlTechTypeParameterBuilder class.
		/// </summary>
		public SeControlTechTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeControlTechTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeControlTechTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeControlTechTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeControlTechTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeControlTechTypeParameterBuilder
	
	#region SeControlTechTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeControlTechTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeControlTechType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeControlTechTypeSortBuilder : SqlSortBuilder<SeControlTechTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeControlTechTypeSqlSortBuilder class.
		/// </summary>
		public SeControlTechTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeControlTechTypeSortBuilder
	
} // end namespace
