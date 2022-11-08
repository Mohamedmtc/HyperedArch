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
	/// This class is the base class for any <see cref="EdCdeQualPhaseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeQualPhaseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCdeQualPhase, UMIS_VER2.BusinessLyer.EdCdeQualPhaseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeQualPhaseKey key)
		{
			return Delete(transactionManager, key.EdCdeQualPhase);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCdeQualPhase">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCdeQualPhase)
		{
			return Delete(null, _edCdeQualPhase);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualPhase">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCdeQualPhase);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCdeQualPhase Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeQualPhaseKey key, int start, int pageLength)
		{
			return GetByEdCdeQualPhase(transactionManager, key.EdCdeQualPhase, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CDE_QUAL_PHASE index.
		/// </summary>
		/// <param name="_edCdeQualPhase"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualPhase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualPhase GetByEdCdeQualPhase(System.Decimal _edCdeQualPhase)
		{
			int count = -1;
			return GetByEdCdeQualPhase(null,_edCdeQualPhase, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_PHASE index.
		/// </summary>
		/// <param name="_edCdeQualPhase"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualPhase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualPhase GetByEdCdeQualPhase(System.Decimal _edCdeQualPhase, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeQualPhase(null, _edCdeQualPhase, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_PHASE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualPhase"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualPhase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualPhase GetByEdCdeQualPhase(TransactionManager transactionManager, System.Decimal _edCdeQualPhase)
		{
			int count = -1;
			return GetByEdCdeQualPhase(transactionManager, _edCdeQualPhase, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_PHASE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualPhase"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualPhase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualPhase GetByEdCdeQualPhase(TransactionManager transactionManager, System.Decimal _edCdeQualPhase, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeQualPhase(transactionManager, _edCdeQualPhase, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_PHASE index.
		/// </summary>
		/// <param name="_edCdeQualPhase"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualPhase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualPhase GetByEdCdeQualPhase(System.Decimal _edCdeQualPhase, int start, int pageLength, out int count)
		{
			return GetByEdCdeQualPhase(null, _edCdeQualPhase, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_PHASE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualPhase"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualPhase"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeQualPhase GetByEdCdeQualPhase(TransactionManager transactionManager, System.Decimal _edCdeQualPhase, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCdeQualPhase&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCdeQualPhase&gt;"/></returns>
		public static TList<EdCdeQualPhase> Fill(IDataReader reader, TList<EdCdeQualPhase> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCdeQualPhase c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCdeQualPhase")
					.Append("|").Append((System.Decimal)reader["ED_CDE_QUAL_PHASE"]).ToString();
					c = EntityManager.LocateOrCreate<EdCdeQualPhase>(
					key.ToString(), // EntityTrackingKey
					"EdCdeQualPhase",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCdeQualPhase();
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
					c.EdCdeQualPhase = (System.Decimal)reader["ED_CDE_QUAL_PHASE"];
					c.OriginalEdCdeQualPhase = c.EdCdeQualPhase;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.Ordr = (System.Int16)reader["ORDR"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualPhase"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeQualPhase"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCdeQualPhase entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCdeQualPhase = (System.Decimal)reader[((int)EdCdeQualPhaseColumn.EdCdeQualPhase - 1)];
			entity.OriginalEdCdeQualPhase = (System.Decimal)reader["ED_CDE_QUAL_PHASE"];
			entity.DescrAr = (System.String)reader[((int)EdCdeQualPhaseColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)EdCdeQualPhaseColumn.DescrEn - 1)];
			entity.Ordr = (System.Int16)reader[((int)EdCdeQualPhaseColumn.Ordr - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualPhase"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeQualPhase"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCdeQualPhase entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCdeQualPhase = (System.Decimal)dataRow["ED_CDE_QUAL_PHASE"];
			entity.OriginalEdCdeQualPhase = (System.Decimal)dataRow["ED_CDE_QUAL_PHASE"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.Ordr = (System.Int16)dataRow["ORDR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeQualPhase"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeQualPhase Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeQualPhase entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCdeQualPhase methods when available
			
			#region EdStudQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQual>|EdStudQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualCollection = DataRepository.EdStudQualProvider.GetByEdCdeQualPhase(transactionManager, entity.EdCdeQualPhase);

				if (deep && entity.EdStudQualCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQual>) DataRepository.EdStudQualProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmParamMajorPhaseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmParamMajorPhase>|AdmParamMajorPhaseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmParamMajorPhaseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmParamMajorPhaseCollection = DataRepository.AdmParamMajorPhaseProvider.GetByEdCdeQualPhaseId(transactionManager, entity.EdCdeQualPhase);

				if (deep && entity.AdmParamMajorPhaseCollection.Count > 0)
				{
					deepHandles.Add("AdmParamMajorPhaseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmParamMajorPhase>) DataRepository.AdmParamMajorPhaseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmParamMajorPhaseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudFacultyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudFaculty>|EdStudFacultyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudFacultyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudFacultyCollection = DataRepository.EdStudFacultyProvider.GetByEdCdeQualPhase(transactionManager, entity.EdCdeQualPhase);

				if (deep && entity.EdStudFacultyCollection.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCdeQualPhase object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCdeQualPhase instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeQualPhase Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeQualPhase entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
						if(child.EdCdeQualPhaseSource != null)
						{
							child.EdCdeQualPhase = child.EdCdeQualPhaseSource.EdCdeQualPhase;
						}
						else
						{
							child.EdCdeQualPhase = entity.EdCdeQualPhase;
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
				
	
			#region List<AdmParamMajorPhase>
				if (CanDeepSave(entity.AdmParamMajorPhaseCollection, "List<AdmParamMajorPhase>|AdmParamMajorPhaseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmParamMajorPhase child in entity.AdmParamMajorPhaseCollection)
					{
						if(child.EdCdeQualPhaseIdSource != null)
						{
							child.EdCdeQualPhaseId = child.EdCdeQualPhaseIdSource.EdCdeQualPhase;
						}
						else
						{
							child.EdCdeQualPhaseId = entity.EdCdeQualPhase;
						}

					}

					if (entity.AdmParamMajorPhaseCollection.Count > 0 || entity.AdmParamMajorPhaseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmParamMajorPhaseProvider.Save(transactionManager, entity.AdmParamMajorPhaseCollection);
						
						deepHandles.Add("AdmParamMajorPhaseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmParamMajorPhase >) DataRepository.AdmParamMajorPhaseProvider.DeepSave,
							new object[] { transactionManager, entity.AdmParamMajorPhaseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudFaculty>
				if (CanDeepSave(entity.EdStudFacultyCollection, "List<EdStudFaculty>|EdStudFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudFaculty child in entity.EdStudFacultyCollection)
					{
						if(child.EdCdeQualPhaseSource != null)
						{
							child.EdCdeQualPhase = child.EdCdeQualPhaseSource.EdCdeQualPhase;
						}
						else
						{
							child.EdCdeQualPhase = entity.EdCdeQualPhase;
						}

					}

					if (entity.EdStudFacultyCollection.Count > 0 || entity.EdStudFacultyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudFacultyProvider.Save(transactionManager, entity.EdStudFacultyCollection);
						
						deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudFaculty >) DataRepository.EdStudFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudFacultyCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCdeQualPhaseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCdeQualPhase</c>
	///</summary>
	public enum EdCdeQualPhaseChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCdeQualPhase</c> as OneToMany for EdStudQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQual>))]
		EdStudQualCollection,
		///<summary>
		/// Collection of <c>EdCdeQualPhase</c> as OneToMany for AdmParamMajorPhaseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmParamMajorPhase>))]
		AdmParamMajorPhaseCollection,
		///<summary>
		/// Collection of <c>EdCdeQualPhase</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollection,
	}
	
	#endregion EdCdeQualPhaseChildEntityTypes
	
	#region EdCdeQualPhaseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCdeQualPhaseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeQualPhase"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeQualPhaseFilterBuilder : SqlFilterBuilder<EdCdeQualPhaseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeQualPhaseFilterBuilder class.
		/// </summary>
		public EdCdeQualPhaseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeQualPhaseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeQualPhaseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeQualPhaseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeQualPhaseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeQualPhaseFilterBuilder
	
	#region EdCdeQualPhaseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCdeQualPhaseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeQualPhase"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeQualPhaseParameterBuilder : ParameterizedSqlFilterBuilder<EdCdeQualPhaseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeQualPhaseParameterBuilder class.
		/// </summary>
		public EdCdeQualPhaseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeQualPhaseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeQualPhaseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeQualPhaseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeQualPhaseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeQualPhaseParameterBuilder
	
	#region EdCdeQualPhaseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCdeQualPhaseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeQualPhase"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCdeQualPhaseSortBuilder : SqlSortBuilder<EdCdeQualPhaseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeQualPhaseSqlSortBuilder class.
		/// </summary>
		public EdCdeQualPhaseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCdeQualPhaseSortBuilder
	
} // end namespace
