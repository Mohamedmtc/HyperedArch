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
	/// This class is the base class for any <see cref="AdmAdmissionBandProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAdmissionBandProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAdmissionBand, UMIS_VER2.BusinessLyer.AdmAdmissionBandKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAdmissionBandKey key)
		{
			return Delete(transactionManager, key.AdmAdmissionBandId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAdmissionBandId">فئات القبول. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAdmissionBandId)
		{
			return Delete(null, _admAdmissionBandId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAdmissionBandId">فئات القبول. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAdmissionBandId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmAdmissionBand Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAdmissionBandKey key, int start, int pageLength)
		{
			return GetByAdmAdmissionBandId(transactionManager, key.AdmAdmissionBandId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_ADMISSION_BAND index.
		/// </summary>
		/// <param name="_admAdmissionBandId">فئات القبول</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAdmissionBand"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAdmissionBand GetByAdmAdmissionBandId(System.Decimal _admAdmissionBandId)
		{
			int count = -1;
			return GetByAdmAdmissionBandId(null,_admAdmissionBandId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_ADMISSION_BAND index.
		/// </summary>
		/// <param name="_admAdmissionBandId">فئات القبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAdmissionBand"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAdmissionBand GetByAdmAdmissionBandId(System.Decimal _admAdmissionBandId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAdmissionBandId(null, _admAdmissionBandId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_ADMISSION_BAND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAdmissionBandId">فئات القبول</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAdmissionBand"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAdmissionBand GetByAdmAdmissionBandId(TransactionManager transactionManager, System.Decimal _admAdmissionBandId)
		{
			int count = -1;
			return GetByAdmAdmissionBandId(transactionManager, _admAdmissionBandId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_ADMISSION_BAND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAdmissionBandId">فئات القبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAdmissionBand"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAdmissionBand GetByAdmAdmissionBandId(TransactionManager transactionManager, System.Decimal _admAdmissionBandId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAdmissionBandId(transactionManager, _admAdmissionBandId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_ADMISSION_BAND index.
		/// </summary>
		/// <param name="_admAdmissionBandId">فئات القبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAdmissionBand"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAdmissionBand GetByAdmAdmissionBandId(System.Decimal _admAdmissionBandId, int start, int pageLength, out int count)
		{
			return GetByAdmAdmissionBandId(null, _admAdmissionBandId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_ADMISSION_BAND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAdmissionBandId">فئات القبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAdmissionBand"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAdmissionBand GetByAdmAdmissionBandId(TransactionManager transactionManager, System.Decimal _admAdmissionBandId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAdmissionBand&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAdmissionBand&gt;"/></returns>
		public static TList<AdmAdmissionBand> Fill(IDataReader reader, TList<AdmAdmissionBand> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAdmissionBand c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAdmissionBand")
					.Append("|").Append((System.Decimal)reader["ADM_ADMISSION_BAND_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAdmissionBand>(
					key.ToString(), // EntityTrackingKey
					"AdmAdmissionBand",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAdmissionBand();
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
					c.AdmAdmissionBandId = (System.Decimal)reader["ADM_ADMISSION_BAND_ID"];
					c.OriginalAdmAdmissionBandId = c.AdmAdmissionBandId;
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.IsHide = (System.Decimal)reader["IS_HIDE"];
					c.OrderFlg = (System.Decimal)reader["ORDER_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAdmissionBand"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAdmissionBand"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAdmissionBand entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAdmissionBandId = (System.Decimal)reader[((int)AdmAdmissionBandColumn.AdmAdmissionBandId - 1)];
			entity.OriginalAdmAdmissionBandId = (System.Decimal)reader["ADM_ADMISSION_BAND_ID"];
			entity.DescrAr = (reader.IsDBNull(((int)AdmAdmissionBandColumn.DescrAr - 1)))?null:(System.String)reader[((int)AdmAdmissionBandColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)AdmAdmissionBandColumn.DescrEn - 1)))?null:(System.String)reader[((int)AdmAdmissionBandColumn.DescrEn - 1)];
			entity.IsHide = (System.Decimal)reader[((int)AdmAdmissionBandColumn.IsHide - 1)];
			entity.OrderFlg = (System.Decimal)reader[((int)AdmAdmissionBandColumn.OrderFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAdmissionBand"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAdmissionBand"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAdmissionBand entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAdmissionBandId = (System.Decimal)dataRow["ADM_ADMISSION_BAND_ID"];
			entity.OriginalAdmAdmissionBandId = (System.Decimal)dataRow["ADM_ADMISSION_BAND_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.IsHide = (System.Decimal)dataRow["IS_HIDE"];
			entity.OrderFlg = (System.Decimal)dataRow["ORDER_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAdmissionBand"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAdmissionBand Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAdmissionBand entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmAdmissionBandId methods when available
			
			#region GsCountryNodeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCountryNode>|GsCountryNodeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryNodeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCountryNodeCollection = DataRepository.GsCountryNodeProvider.GetByAdmAdmissionBandId(transactionManager, entity.AdmAdmissionBandId);

				if (deep && entity.GsCountryNodeCollection.Count > 0)
				{
					deepHandles.Add("GsCountryNodeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCountryNode>) DataRepository.GsCountryNodeProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCountryNodeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmRatingParametersMajorsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmRatingParametersMajors>|AdmRatingParametersMajorsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmRatingParametersMajorsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmRatingParametersMajorsCollection = DataRepository.AdmRatingParametersMajorsProvider.GetByAdmAdmissionBandId(transactionManager, entity.AdmAdmissionBandId);

				if (deep && entity.AdmRatingParametersMajorsCollection.Count > 0)
				{
					deepHandles.Add("AdmRatingParametersMajorsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmRatingParametersMajors>) DataRepository.AdmRatingParametersMajorsProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmRatingParametersMajorsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppRegHistoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppRegHistoryCollection = DataRepository.AdmAppRegHistoryProvider.GetByAdmAdmissionBandId(transactionManager, entity.AdmAdmissionBandId);

				if (deep && entity.AdmAppRegHistoryCollection.Count > 0)
				{
					deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppRegHistory>) DataRepository.AdmAppRegHistoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAdmissionBand object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAdmissionBand instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAdmissionBand Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAdmissionBand entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<GsCountryNode>
				if (CanDeepSave(entity.GsCountryNodeCollection, "List<GsCountryNode>|GsCountryNodeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCountryNode child in entity.GsCountryNodeCollection)
					{
						if(child.AdmAdmissionBandIdSource != null)
						{
							child.AdmAdmissionBandId = child.AdmAdmissionBandIdSource.AdmAdmissionBandId;
						}
						else
						{
							child.AdmAdmissionBandId = entity.AdmAdmissionBandId;
						}

					}

					if (entity.GsCountryNodeCollection.Count > 0 || entity.GsCountryNodeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryNodeCollection);
						
						deepHandles.Add("GsCountryNodeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCountryNode >) DataRepository.GsCountryNodeProvider.DeepSave,
							new object[] { transactionManager, entity.GsCountryNodeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmRatingParametersMajors>
				if (CanDeepSave(entity.AdmRatingParametersMajorsCollection, "List<AdmRatingParametersMajors>|AdmRatingParametersMajorsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmRatingParametersMajors child in entity.AdmRatingParametersMajorsCollection)
					{
						if(child.AdmAdmissionBandIdSource != null)
						{
							child.AdmAdmissionBandId = child.AdmAdmissionBandIdSource.AdmAdmissionBandId;
						}
						else
						{
							child.AdmAdmissionBandId = entity.AdmAdmissionBandId;
						}

					}

					if (entity.AdmRatingParametersMajorsCollection.Count > 0 || entity.AdmRatingParametersMajorsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmRatingParametersMajorsProvider.Save(transactionManager, entity.AdmRatingParametersMajorsCollection);
						
						deepHandles.Add("AdmRatingParametersMajorsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmRatingParametersMajors >) DataRepository.AdmRatingParametersMajorsProvider.DeepSave,
							new object[] { transactionManager, entity.AdmRatingParametersMajorsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppRegHistory>
				if (CanDeepSave(entity.AdmAppRegHistoryCollection, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppRegHistory child in entity.AdmAppRegHistoryCollection)
					{
						if(child.AdmAdmissionBandIdSource != null)
						{
							child.AdmAdmissionBandId = child.AdmAdmissionBandIdSource.AdmAdmissionBandId;
						}
						else
						{
							child.AdmAdmissionBandId = entity.AdmAdmissionBandId;
						}

					}

					if (entity.AdmAppRegHistoryCollection.Count > 0 || entity.AdmAppRegHistoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryCollection);
						
						deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppRegHistory >) DataRepository.AdmAppRegHistoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmAdmissionBandChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAdmissionBand</c>
	///</summary>
	public enum AdmAdmissionBandChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AdmAdmissionBand</c> as OneToMany for GsCountryNodeCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCountryNode>))]
		GsCountryNodeCollection,
		///<summary>
		/// Collection of <c>AdmAdmissionBand</c> as OneToMany for AdmRatingParametersMajorsCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmRatingParametersMajors>))]
		AdmRatingParametersMajorsCollection,
		///<summary>
		/// Collection of <c>AdmAdmissionBand</c> as OneToMany for AdmAppRegHistoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppRegHistory>))]
		AdmAppRegHistoryCollection,
	}
	
	#endregion AdmAdmissionBandChildEntityTypes
	
	#region AdmAdmissionBandFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAdmissionBandColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAdmissionBand"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAdmissionBandFilterBuilder : SqlFilterBuilder<AdmAdmissionBandColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAdmissionBandFilterBuilder class.
		/// </summary>
		public AdmAdmissionBandFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAdmissionBandFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAdmissionBandFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAdmissionBandFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAdmissionBandFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAdmissionBandFilterBuilder
	
	#region AdmAdmissionBandParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAdmissionBandColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAdmissionBand"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAdmissionBandParameterBuilder : ParameterizedSqlFilterBuilder<AdmAdmissionBandColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAdmissionBandParameterBuilder class.
		/// </summary>
		public AdmAdmissionBandParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAdmissionBandParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAdmissionBandParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAdmissionBandParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAdmissionBandParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAdmissionBandParameterBuilder
	
	#region AdmAdmissionBandSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAdmissionBandColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAdmissionBand"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAdmissionBandSortBuilder : SqlSortBuilder<AdmAdmissionBandColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAdmissionBandSqlSortBuilder class.
		/// </summary>
		public AdmAdmissionBandSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAdmissionBandSortBuilder
	
} // end namespace
