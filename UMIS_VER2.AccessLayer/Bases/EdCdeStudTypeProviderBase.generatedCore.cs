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
	/// This class is the base class for any <see cref="EdCdeStudTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeStudTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCdeStudType, UMIS_VER2.BusinessLyer.EdCdeStudTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeStudTypeKey key)
		{
			return Delete(transactionManager, key.EdCdeStudTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCdeStudTypeId">burimi student type. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _edCdeStudTypeId)
		{
			return Delete(null, _edCdeStudTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeStudTypeId">burimi student type. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _edCdeStudTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCdeStudType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeStudTypeKey key, int start, int pageLength)
		{
			return GetByEdCdeStudTypeId(transactionManager, key.EdCdeStudTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CDE_STUD_TYPE index.
		/// </summary>
		/// <param name="_edCdeStudTypeId">burimi student type</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeStudType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeStudType GetByEdCdeStudTypeId(System.Int32 _edCdeStudTypeId)
		{
			int count = -1;
			return GetByEdCdeStudTypeId(null,_edCdeStudTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_STUD_TYPE index.
		/// </summary>
		/// <param name="_edCdeStudTypeId">burimi student type</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeStudType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeStudType GetByEdCdeStudTypeId(System.Int32 _edCdeStudTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeStudTypeId(null, _edCdeStudTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_STUD_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeStudTypeId">burimi student type</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeStudType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeStudType GetByEdCdeStudTypeId(TransactionManager transactionManager, System.Int32 _edCdeStudTypeId)
		{
			int count = -1;
			return GetByEdCdeStudTypeId(transactionManager, _edCdeStudTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_STUD_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeStudTypeId">burimi student type</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeStudType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeStudType GetByEdCdeStudTypeId(TransactionManager transactionManager, System.Int32 _edCdeStudTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeStudTypeId(transactionManager, _edCdeStudTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_STUD_TYPE index.
		/// </summary>
		/// <param name="_edCdeStudTypeId">burimi student type</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeStudType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeStudType GetByEdCdeStudTypeId(System.Int32 _edCdeStudTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCdeStudTypeId(null, _edCdeStudTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_STUD_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeStudTypeId">burimi student type</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeStudType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeStudType GetByEdCdeStudTypeId(TransactionManager transactionManager, System.Int32 _edCdeStudTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCdeStudType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCdeStudType&gt;"/></returns>
		public static TList<EdCdeStudType> Fill(IDataReader reader, TList<EdCdeStudType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCdeStudType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCdeStudType")
					.Append("|").Append((System.Int32)reader["ED_CDE_STUD_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCdeStudType>(
					key.ToString(), // EntityTrackingKey
					"EdCdeStudType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCdeStudType();
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
					c.EdCdeStudTypeId = (System.Int32)reader["ED_CDE_STUD_TYPE_ID"];
					c.OriginalEdCdeStudTypeId = c.EdCdeStudTypeId;
					c.StudTypeAr = Convert.IsDBNull(reader["STUD_TYPE_AR"]) ? null : (System.String)reader["STUD_TYPE_AR"];
					c.StudTypeEn = Convert.IsDBNull(reader["STUD_TYPE_EN"]) ? null : (System.String)reader["STUD_TYPE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeStudType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeStudType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCdeStudType entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCdeStudTypeId = (System.Int32)reader[((int)EdCdeStudTypeColumn.EdCdeStudTypeId - 1)];
			entity.OriginalEdCdeStudTypeId = (System.Int32)reader["ED_CDE_STUD_TYPE_ID"];
			entity.StudTypeAr = (reader.IsDBNull(((int)EdCdeStudTypeColumn.StudTypeAr - 1)))?null:(System.String)reader[((int)EdCdeStudTypeColumn.StudTypeAr - 1)];
			entity.StudTypeEn = (reader.IsDBNull(((int)EdCdeStudTypeColumn.StudTypeEn - 1)))?null:(System.String)reader[((int)EdCdeStudTypeColumn.StudTypeEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeStudType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeStudType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCdeStudType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCdeStudTypeId = (System.Int32)dataRow["ED_CDE_STUD_TYPE_ID"];
			entity.OriginalEdCdeStudTypeId = (System.Int32)dataRow["ED_CDE_STUD_TYPE_ID"];
			entity.StudTypeAr = Convert.IsDBNull(dataRow["STUD_TYPE_AR"]) ? null : (System.String)dataRow["STUD_TYPE_AR"];
			entity.StudTypeEn = Convert.IsDBNull(dataRow["STUD_TYPE_EN"]) ? null : (System.String)dataRow["STUD_TYPE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeStudType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeStudType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeStudType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCdeStudTypeId methods when available
			
			#region SpoSponsorOfferExtCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorOfferExt>|SpoSponsorOfferExtCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorOfferExtCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorOfferExtCollection = DataRepository.SpoSponsorOfferExtProvider.GetByEdCdeStudTypeId(transactionManager, entity.EdCdeStudTypeId);

				if (deep && entity.SpoSponsorOfferExtCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorOfferExtCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorOfferExt>) DataRepository.SpoSponsorOfferExtProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorOfferExtCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFacultyRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFacultyRuleCollection = DataRepository.FeeFacultyRuleProvider.GetByEdCdeStudTypeId(transactionManager, entity.EdCdeStudTypeId);

				if (deep && entity.FeeFacultyRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacultyRule>) DataRepository.FeeFacultyRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacultyRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemester>|EdStudSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterCollection = DataRepository.EdStudSemesterProvider.GetByEdCdeStudTypeId(transactionManager, entity.EdCdeStudTypeId);

				if (deep && entity.EdStudSemesterCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemester>) DataRepository.EdStudSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCdeStudType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCdeStudType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeStudType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeStudType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SpoSponsorOfferExt>
				if (CanDeepSave(entity.SpoSponsorOfferExtCollection, "List<SpoSponsorOfferExt>|SpoSponsorOfferExtCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorOfferExt child in entity.SpoSponsorOfferExtCollection)
					{
						if(child.EdCdeStudTypeIdSource != null)
						{
							child.EdCdeStudTypeId = child.EdCdeStudTypeIdSource.EdCdeStudTypeId;
						}
						else
						{
							child.EdCdeStudTypeId = entity.EdCdeStudTypeId;
						}

					}

					if (entity.SpoSponsorOfferExtCollection.Count > 0 || entity.SpoSponsorOfferExtCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorOfferExtProvider.Save(transactionManager, entity.SpoSponsorOfferExtCollection);
						
						deepHandles.Add("SpoSponsorOfferExtCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorOfferExt >) DataRepository.SpoSponsorOfferExtProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorOfferExtCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFacultyRule>
				if (CanDeepSave(entity.FeeFacultyRuleCollection, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFacultyRule child in entity.FeeFacultyRuleCollection)
					{
						if(child.EdCdeStudTypeIdSource != null)
						{
							child.EdCdeStudTypeId = child.EdCdeStudTypeIdSource.EdCdeStudTypeId;
						}
						else
						{
							child.EdCdeStudTypeId = entity.EdCdeStudTypeId;
						}

					}

					if (entity.FeeFacultyRuleCollection.Count > 0 || entity.FeeFacultyRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFacultyRuleProvider.Save(transactionManager, entity.FeeFacultyRuleCollection);
						
						deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFacultyRule >) DataRepository.FeeFacultyRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFacultyRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemester>
				if (CanDeepSave(entity.EdStudSemesterCollection, "List<EdStudSemester>|EdStudSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemester child in entity.EdStudSemesterCollection)
					{
						if(child.EdCdeStudTypeIdSource != null)
						{
							child.EdCdeStudTypeId = child.EdCdeStudTypeIdSource.EdCdeStudTypeId;
						}
						else
						{
							child.EdCdeStudTypeId = entity.EdCdeStudTypeId;
						}

					}

					if (entity.EdStudSemesterCollection.Count > 0 || entity.EdStudSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterCollection);
						
						deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemester >) DataRepository.EdStudSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCdeStudTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCdeStudType</c>
	///</summary>
	public enum EdCdeStudTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCdeStudType</c> as OneToMany for SpoSponsorOfferExtCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorOfferExt>))]
		SpoSponsorOfferExtCollection,
		///<summary>
		/// Collection of <c>EdCdeStudType</c> as OneToMany for FeeFacultyRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacultyRule>))]
		FeeFacultyRuleCollection,
		///<summary>
		/// Collection of <c>EdCdeStudType</c> as OneToMany for EdStudSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemester>))]
		EdStudSemesterCollection,
	}
	
	#endregion EdCdeStudTypeChildEntityTypes
	
	#region EdCdeStudTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCdeStudTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeStudType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeStudTypeFilterBuilder : SqlFilterBuilder<EdCdeStudTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeStudTypeFilterBuilder class.
		/// </summary>
		public EdCdeStudTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeStudTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeStudTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeStudTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeStudTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeStudTypeFilterBuilder
	
	#region EdCdeStudTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCdeStudTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeStudType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeStudTypeParameterBuilder : ParameterizedSqlFilterBuilder<EdCdeStudTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeStudTypeParameterBuilder class.
		/// </summary>
		public EdCdeStudTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeStudTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeStudTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeStudTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeStudTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeStudTypeParameterBuilder
	
	#region EdCdeStudTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCdeStudTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeStudType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCdeStudTypeSortBuilder : SqlSortBuilder<EdCdeStudTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeStudTypeSqlSortBuilder class.
		/// </summary>
		public EdCdeStudTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCdeStudTypeSortBuilder
	
} // end namespace
