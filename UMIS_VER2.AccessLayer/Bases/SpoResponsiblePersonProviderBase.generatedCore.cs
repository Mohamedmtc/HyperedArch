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
	/// This class is the base class for any <see cref="SpoResponsiblePersonProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SpoResponsiblePersonProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SpoResponsiblePerson, UMIS_VER2.BusinessLyer.SpoResponsiblePersonKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoResponsiblePersonKey key)
		{
			return Delete(transactionManager, key.SpoResponsiblePersonId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_spoResponsiblePersonId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _spoResponsiblePersonId)
		{
			return Delete(null, _spoResponsiblePersonId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoResponsiblePersonId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _spoResponsiblePersonId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_RESPONSIBLE_PERSON_SPO_SPONSOR key.
		///		FK_SPO_RESPONSIBLE_PERSON_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="_spoSponsorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoResponsiblePerson objects.</returns>
		public TList<SpoResponsiblePerson> GetBySpoSponsorId(System.Decimal? _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(_spoSponsorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_RESPONSIBLE_PERSON_SPO_SPONSOR key.
		///		FK_SPO_RESPONSIBLE_PERSON_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoResponsiblePerson objects.</returns>
		/// <remarks></remarks>
		public TList<SpoResponsiblePerson> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_RESPONSIBLE_PERSON_SPO_SPONSOR key.
		///		FK_SPO_RESPONSIBLE_PERSON_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoResponsiblePerson objects.</returns>
		public TList<SpoResponsiblePerson> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_RESPONSIBLE_PERSON_SPO_SPONSOR key.
		///		fkSpoResponsiblePersonSpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoResponsiblePerson objects.</returns>
		public TList<SpoResponsiblePerson> GetBySpoSponsorId(System.Decimal? _spoSponsorId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_RESPONSIBLE_PERSON_SPO_SPONSOR key.
		///		fkSpoResponsiblePersonSpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoResponsiblePerson objects.</returns>
		public TList<SpoResponsiblePerson> GetBySpoSponsorId(System.Decimal? _spoSponsorId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_RESPONSIBLE_PERSON_SPO_SPONSOR key.
		///		FK_SPO_RESPONSIBLE_PERSON_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoResponsiblePerson objects.</returns>
		public abstract TList<SpoResponsiblePerson> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SpoResponsiblePerson Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoResponsiblePersonKey key, int start, int pageLength)
		{
			return GetBySpoResponsiblePersonId(transactionManager, key.SpoResponsiblePersonId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SPO_RESPONSIBLE_PERSON index.
		/// </summary>
		/// <param name="_spoResponsiblePersonId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoResponsiblePerson"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoResponsiblePerson GetBySpoResponsiblePersonId(System.Decimal _spoResponsiblePersonId)
		{
			int count = -1;
			return GetBySpoResponsiblePersonId(null,_spoResponsiblePersonId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_RESPONSIBLE_PERSON index.
		/// </summary>
		/// <param name="_spoResponsiblePersonId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoResponsiblePerson"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoResponsiblePerson GetBySpoResponsiblePersonId(System.Decimal _spoResponsiblePersonId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoResponsiblePersonId(null, _spoResponsiblePersonId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_RESPONSIBLE_PERSON index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoResponsiblePersonId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoResponsiblePerson"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoResponsiblePerson GetBySpoResponsiblePersonId(TransactionManager transactionManager, System.Decimal _spoResponsiblePersonId)
		{
			int count = -1;
			return GetBySpoResponsiblePersonId(transactionManager, _spoResponsiblePersonId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_RESPONSIBLE_PERSON index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoResponsiblePersonId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoResponsiblePerson"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoResponsiblePerson GetBySpoResponsiblePersonId(TransactionManager transactionManager, System.Decimal _spoResponsiblePersonId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoResponsiblePersonId(transactionManager, _spoResponsiblePersonId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_RESPONSIBLE_PERSON index.
		/// </summary>
		/// <param name="_spoResponsiblePersonId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoResponsiblePerson"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoResponsiblePerson GetBySpoResponsiblePersonId(System.Decimal _spoResponsiblePersonId, int start, int pageLength, out int count)
		{
			return GetBySpoResponsiblePersonId(null, _spoResponsiblePersonId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_RESPONSIBLE_PERSON index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoResponsiblePersonId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoResponsiblePerson"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SpoResponsiblePerson GetBySpoResponsiblePersonId(TransactionManager transactionManager, System.Decimal _spoResponsiblePersonId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SpoResponsiblePerson&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SpoResponsiblePerson&gt;"/></returns>
		public static TList<SpoResponsiblePerson> Fill(IDataReader reader, TList<SpoResponsiblePerson> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SpoResponsiblePerson c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SpoResponsiblePerson")
					.Append("|").Append((System.Decimal)reader["SPO_RESPONSIBLE_PERSON_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SpoResponsiblePerson>(
					key.ToString(), // EntityTrackingKey
					"SpoResponsiblePerson",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SpoResponsiblePerson();
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
					c.SpoResponsiblePersonId = (System.Decimal)reader["SPO_RESPONSIBLE_PERSON_ID"];
					c.OriginalSpoResponsiblePersonId = c.SpoResponsiblePersonId;
					c.SpoSponsorId = Convert.IsDBNull(reader["SPO_SPONSOR_ID"]) ? null : (System.Decimal?)reader["SPO_SPONSOR_ID"];
					c.Name = Convert.IsDBNull(reader["Name"]) ? null : (System.String)reader["Name"];
					c.Position = Convert.IsDBNull(reader["Position"]) ? null : (System.String)reader["Position"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoResponsiblePerson"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoResponsiblePerson"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SpoResponsiblePerson entity)
		{
			if (!reader.Read()) return;
			
			entity.SpoResponsiblePersonId = (System.Decimal)reader[((int)SpoResponsiblePersonColumn.SpoResponsiblePersonId - 1)];
			entity.OriginalSpoResponsiblePersonId = (System.Decimal)reader["SPO_RESPONSIBLE_PERSON_ID"];
			entity.SpoSponsorId = (reader.IsDBNull(((int)SpoResponsiblePersonColumn.SpoSponsorId - 1)))?null:(System.Decimal?)reader[((int)SpoResponsiblePersonColumn.SpoSponsorId - 1)];
			entity.Name = (reader.IsDBNull(((int)SpoResponsiblePersonColumn.Name - 1)))?null:(System.String)reader[((int)SpoResponsiblePersonColumn.Name - 1)];
			entity.Position = (reader.IsDBNull(((int)SpoResponsiblePersonColumn.Position - 1)))?null:(System.String)reader[((int)SpoResponsiblePersonColumn.Position - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoResponsiblePerson"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoResponsiblePerson"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SpoResponsiblePerson entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SpoResponsiblePersonId = (System.Decimal)dataRow["SPO_RESPONSIBLE_PERSON_ID"];
			entity.OriginalSpoResponsiblePersonId = (System.Decimal)dataRow["SPO_RESPONSIBLE_PERSON_ID"];
			entity.SpoSponsorId = Convert.IsDBNull(dataRow["SPO_SPONSOR_ID"]) ? null : (System.Decimal?)dataRow["SPO_SPONSOR_ID"];
			entity.Name = Convert.IsDBNull(dataRow["Name"]) ? null : (System.String)dataRow["Name"];
			entity.Position = Convert.IsDBNull(dataRow["Position"]) ? null : (System.String)dataRow["Position"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoResponsiblePerson"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoResponsiblePerson Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoResponsiblePerson entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SpoSponsorIdSource	
			if (CanDeepLoad(entity, "SpoSponsor|SpoSponsorIdSource", deepLoadType, innerList) 
				&& entity.SpoSponsorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SpoSponsorId ?? 0.0m);
				SpoSponsor tmpEntity = EntityManager.LocateEntity<SpoSponsor>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoSponsor), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoSponsorIdSource = tmpEntity;
				else
					entity.SpoSponsorIdSource = DataRepository.SpoSponsorProvider.GetBySpoSponsorId(transactionManager, (entity.SpoSponsorId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SpoSponsorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SpoSponsorProvider.DeepLoad(transactionManager, entity.SpoSponsorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SpoSponsorIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySpoResponsiblePersonId methods when available
			
			#region SpoContactCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoContact>|SpoContactCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoContactCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoContactCollection = DataRepository.SpoContactProvider.GetBySpoResponsiblePersonId(transactionManager, entity.SpoResponsiblePersonId);

				if (deep && entity.SpoContactCollection.Count > 0)
				{
					deepHandles.Add("SpoContactCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoContact>) DataRepository.SpoContactProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoContactCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SpoResponsiblePerson object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SpoResponsiblePerson instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoResponsiblePerson Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoResponsiblePerson entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SpoSponsorIdSource
			if (CanDeepSave(entity, "SpoSponsor|SpoSponsorIdSource", deepSaveType, innerList) 
				&& entity.SpoSponsorIdSource != null)
			{
				DataRepository.SpoSponsorProvider.Save(transactionManager, entity.SpoSponsorIdSource);
				entity.SpoSponsorId = entity.SpoSponsorIdSource.SpoSponsorId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SpoContact>
				if (CanDeepSave(entity.SpoContactCollection, "List<SpoContact>|SpoContactCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoContact child in entity.SpoContactCollection)
					{
						if(child.SpoResponsiblePersonIdSource != null)
						{
							child.SpoResponsiblePersonId = child.SpoResponsiblePersonIdSource.SpoResponsiblePersonId;
						}
						else
						{
							child.SpoResponsiblePersonId = entity.SpoResponsiblePersonId;
						}

					}

					if (entity.SpoContactCollection.Count > 0 || entity.SpoContactCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoContactProvider.Save(transactionManager, entity.SpoContactCollection);
						
						deepHandles.Add("SpoContactCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoContact >) DataRepository.SpoContactProvider.DeepSave,
							new object[] { transactionManager, entity.SpoContactCollection, deepSaveType, childTypes, innerList }
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
	
	#region SpoResponsiblePersonChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SpoResponsiblePerson</c>
	///</summary>
	public enum SpoResponsiblePersonChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SpoSponsor</c> at SpoSponsorIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsor))]
		SpoSponsor,
		///<summary>
		/// Collection of <c>SpoResponsiblePerson</c> as OneToMany for SpoContactCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoContact>))]
		SpoContactCollection,
	}
	
	#endregion SpoResponsiblePersonChildEntityTypes
	
	#region SpoResponsiblePersonFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SpoResponsiblePersonColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoResponsiblePerson"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoResponsiblePersonFilterBuilder : SqlFilterBuilder<SpoResponsiblePersonColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoResponsiblePersonFilterBuilder class.
		/// </summary>
		public SpoResponsiblePersonFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoResponsiblePersonFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoResponsiblePersonFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoResponsiblePersonFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoResponsiblePersonFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoResponsiblePersonFilterBuilder
	
	#region SpoResponsiblePersonParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SpoResponsiblePersonColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoResponsiblePerson"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoResponsiblePersonParameterBuilder : ParameterizedSqlFilterBuilder<SpoResponsiblePersonColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoResponsiblePersonParameterBuilder class.
		/// </summary>
		public SpoResponsiblePersonParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoResponsiblePersonParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoResponsiblePersonParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoResponsiblePersonParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoResponsiblePersonParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoResponsiblePersonParameterBuilder
	
	#region SpoResponsiblePersonSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SpoResponsiblePersonColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoResponsiblePerson"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SpoResponsiblePersonSortBuilder : SqlSortBuilder<SpoResponsiblePersonColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoResponsiblePersonSqlSortBuilder class.
		/// </summary>
		public SpoResponsiblePersonSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SpoResponsiblePersonSortBuilder
	
} // end namespace
