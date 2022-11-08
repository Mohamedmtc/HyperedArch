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
	/// This class is the base class for any <see cref="EdCdeSocialAffairProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeSocialAffairProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCdeSocialAffair, UMIS_VER2.BusinessLyer.EdCdeSocialAffairKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeSocialAffairKey key)
		{
			return Delete(transactionManager, key.EdCdeSocialAffairId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCdeSocialAffairId">نوع الشؤن الاجتماعية CSS. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _edCdeSocialAffairId)
		{
			return Delete(null, _edCdeSocialAffairId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeSocialAffairId">نوع الشؤن الاجتماعية CSS. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _edCdeSocialAffairId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCdeSocialAffair Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeSocialAffairKey key, int start, int pageLength)
		{
			return GetByEdCdeSocialAffairId(transactionManager, key.EdCdeSocialAffairId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CDE_SOCIAL_AFFAIR index.
		/// </summary>
		/// <param name="_edCdeSocialAffairId">نوع الشؤن الاجتماعية CSS</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeSocialAffair"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeSocialAffair GetByEdCdeSocialAffairId(System.Int32 _edCdeSocialAffairId)
		{
			int count = -1;
			return GetByEdCdeSocialAffairId(null,_edCdeSocialAffairId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_SOCIAL_AFFAIR index.
		/// </summary>
		/// <param name="_edCdeSocialAffairId">نوع الشؤن الاجتماعية CSS</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeSocialAffair"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeSocialAffair GetByEdCdeSocialAffairId(System.Int32 _edCdeSocialAffairId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeSocialAffairId(null, _edCdeSocialAffairId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_SOCIAL_AFFAIR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeSocialAffairId">نوع الشؤن الاجتماعية CSS</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeSocialAffair"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeSocialAffair GetByEdCdeSocialAffairId(TransactionManager transactionManager, System.Int32 _edCdeSocialAffairId)
		{
			int count = -1;
			return GetByEdCdeSocialAffairId(transactionManager, _edCdeSocialAffairId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_SOCIAL_AFFAIR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeSocialAffairId">نوع الشؤن الاجتماعية CSS</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeSocialAffair"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeSocialAffair GetByEdCdeSocialAffairId(TransactionManager transactionManager, System.Int32 _edCdeSocialAffairId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeSocialAffairId(transactionManager, _edCdeSocialAffairId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_SOCIAL_AFFAIR index.
		/// </summary>
		/// <param name="_edCdeSocialAffairId">نوع الشؤن الاجتماعية CSS</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeSocialAffair"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeSocialAffair GetByEdCdeSocialAffairId(System.Int32 _edCdeSocialAffairId, int start, int pageLength, out int count)
		{
			return GetByEdCdeSocialAffairId(null, _edCdeSocialAffairId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_SOCIAL_AFFAIR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeSocialAffairId">نوع الشؤن الاجتماعية CSS</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeSocialAffair"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeSocialAffair GetByEdCdeSocialAffairId(TransactionManager transactionManager, System.Int32 _edCdeSocialAffairId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCdeSocialAffair&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCdeSocialAffair&gt;"/></returns>
		public static TList<EdCdeSocialAffair> Fill(IDataReader reader, TList<EdCdeSocialAffair> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCdeSocialAffair c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCdeSocialAffair")
					.Append("|").Append((System.Int32)reader["ED_CDE_SOCIAL_AFFAIR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCdeSocialAffair>(
					key.ToString(), // EntityTrackingKey
					"EdCdeSocialAffair",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCdeSocialAffair();
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
					c.EdCdeSocialAffairId = (System.Int32)reader["ED_CDE_SOCIAL_AFFAIR_ID"];
					c.OriginalEdCdeSocialAffairId = c.EdCdeSocialAffairId;
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeSocialAffair"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeSocialAffair"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCdeSocialAffair entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCdeSocialAffairId = (System.Int32)reader[((int)EdCdeSocialAffairColumn.EdCdeSocialAffairId - 1)];
			entity.OriginalEdCdeSocialAffairId = (System.Int32)reader["ED_CDE_SOCIAL_AFFAIR_ID"];
			entity.DescrAr = (reader.IsDBNull(((int)EdCdeSocialAffairColumn.DescrAr - 1)))?null:(System.String)reader[((int)EdCdeSocialAffairColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EdCdeSocialAffairColumn.DescrEn - 1)))?null:(System.String)reader[((int)EdCdeSocialAffairColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeSocialAffair"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeSocialAffair"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCdeSocialAffair entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCdeSocialAffairId = (System.Int32)dataRow["ED_CDE_SOCIAL_AFFAIR_ID"];
			entity.OriginalEdCdeSocialAffairId = (System.Int32)dataRow["ED_CDE_SOCIAL_AFFAIR_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeSocialAffair"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeSocialAffair Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeSocialAffair entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCdeSocialAffairId methods when available
			
			#region AdmApplicantCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmApplicant>|AdmApplicantCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmApplicantCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmApplicantCollection = DataRepository.AdmApplicantProvider.GetByEdCdeSocialAffairId(transactionManager, entity.EdCdeSocialAffairId);

				if (deep && entity.AdmApplicantCollection.Count > 0)
				{
					deepHandles.Add("AdmApplicantCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmApplicant>) DataRepository.AdmApplicantProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmApplicantCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCdeSocialAffair object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCdeSocialAffair instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeSocialAffair Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeSocialAffair entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AdmApplicant>
				if (CanDeepSave(entity.AdmApplicantCollection, "List<AdmApplicant>|AdmApplicantCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmApplicant child in entity.AdmApplicantCollection)
					{
						if(child.EdCdeSocialAffairIdSource != null)
						{
							child.EdCdeSocialAffairId = child.EdCdeSocialAffairIdSource.EdCdeSocialAffairId;
						}
						else
						{
							child.EdCdeSocialAffairId = entity.EdCdeSocialAffairId;
						}

					}

					if (entity.AdmApplicantCollection.Count > 0 || entity.AdmApplicantCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmApplicantProvider.Save(transactionManager, entity.AdmApplicantCollection);
						
						deepHandles.Add("AdmApplicantCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmApplicant >) DataRepository.AdmApplicantProvider.DeepSave,
							new object[] { transactionManager, entity.AdmApplicantCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCdeSocialAffairChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCdeSocialAffair</c>
	///</summary>
	public enum EdCdeSocialAffairChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCdeSocialAffair</c> as OneToMany for AdmApplicantCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmApplicant>))]
		AdmApplicantCollection,
	}
	
	#endregion EdCdeSocialAffairChildEntityTypes
	
	#region EdCdeSocialAffairFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCdeSocialAffairColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeSocialAffair"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeSocialAffairFilterBuilder : SqlFilterBuilder<EdCdeSocialAffairColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeSocialAffairFilterBuilder class.
		/// </summary>
		public EdCdeSocialAffairFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeSocialAffairFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeSocialAffairFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeSocialAffairFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeSocialAffairFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeSocialAffairFilterBuilder
	
	#region EdCdeSocialAffairParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCdeSocialAffairColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeSocialAffair"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeSocialAffairParameterBuilder : ParameterizedSqlFilterBuilder<EdCdeSocialAffairColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeSocialAffairParameterBuilder class.
		/// </summary>
		public EdCdeSocialAffairParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeSocialAffairParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeSocialAffairParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeSocialAffairParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeSocialAffairParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeSocialAffairParameterBuilder
	
	#region EdCdeSocialAffairSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCdeSocialAffairColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeSocialAffair"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCdeSocialAffairSortBuilder : SqlSortBuilder<EdCdeSocialAffairColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeSocialAffairSqlSortBuilder class.
		/// </summary>
		public EdCdeSocialAffairSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCdeSocialAffairSortBuilder
	
} // end namespace
