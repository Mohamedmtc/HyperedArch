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
	/// This class is the base class for any <see cref="SaCodePunishingAuthorityProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodePunishingAuthorityProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodePunishingAuthority, UMIS_VER2.BusinessLyer.SaCodePunishingAuthorityKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodePunishingAuthorityKey key)
		{
			return Delete(transactionManager, key.SaCodePunishingAuthorityId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodePunishingAuthorityId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodePunishingAuthorityId)
		{
			return Delete(null, _saCodePunishingAuthorityId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishingAuthorityId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodePunishingAuthorityId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodePunishingAuthority Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodePunishingAuthorityKey key, int start, int pageLength)
		{
			return GetBySaCodePunishingAuthorityId(transactionManager, key.SaCodePunishingAuthorityId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SA_CODE_PUNISH_AUTH index.
		/// </summary>
		/// <param name="_pAuthDescrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishingAuthority"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishingAuthority GetByPAuthDescrAr(System.String _pAuthDescrAr)
		{
			int count = -1;
			return GetByPAuthDescrAr(null,_pAuthDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PUNISH_AUTH index.
		/// </summary>
		/// <param name="_pAuthDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishingAuthority"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishingAuthority GetByPAuthDescrAr(System.String _pAuthDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByPAuthDescrAr(null, _pAuthDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PUNISH_AUTH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pAuthDescrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishingAuthority"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishingAuthority GetByPAuthDescrAr(TransactionManager transactionManager, System.String _pAuthDescrAr)
		{
			int count = -1;
			return GetByPAuthDescrAr(transactionManager, _pAuthDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PUNISH_AUTH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pAuthDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishingAuthority"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishingAuthority GetByPAuthDescrAr(TransactionManager transactionManager, System.String _pAuthDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByPAuthDescrAr(transactionManager, _pAuthDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PUNISH_AUTH index.
		/// </summary>
		/// <param name="_pAuthDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishingAuthority"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishingAuthority GetByPAuthDescrAr(System.String _pAuthDescrAr, int start, int pageLength, out int count)
		{
			return GetByPAuthDescrAr(null, _pAuthDescrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PUNISH_AUTH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pAuthDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishingAuthority"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodePunishingAuthority GetByPAuthDescrAr(TransactionManager transactionManager, System.String _pAuthDescrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_PUNISHING_AUTHORITY index.
		/// </summary>
		/// <param name="_saCodePunishingAuthorityId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishingAuthority"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishingAuthority GetBySaCodePunishingAuthorityId(System.Decimal _saCodePunishingAuthorityId)
		{
			int count = -1;
			return GetBySaCodePunishingAuthorityId(null,_saCodePunishingAuthorityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PUNISHING_AUTHORITY index.
		/// </summary>
		/// <param name="_saCodePunishingAuthorityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishingAuthority"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishingAuthority GetBySaCodePunishingAuthorityId(System.Decimal _saCodePunishingAuthorityId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodePunishingAuthorityId(null, _saCodePunishingAuthorityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PUNISHING_AUTHORITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishingAuthorityId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishingAuthority"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishingAuthority GetBySaCodePunishingAuthorityId(TransactionManager transactionManager, System.Decimal _saCodePunishingAuthorityId)
		{
			int count = -1;
			return GetBySaCodePunishingAuthorityId(transactionManager, _saCodePunishingAuthorityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PUNISHING_AUTHORITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishingAuthorityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishingAuthority"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishingAuthority GetBySaCodePunishingAuthorityId(TransactionManager transactionManager, System.Decimal _saCodePunishingAuthorityId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodePunishingAuthorityId(transactionManager, _saCodePunishingAuthorityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PUNISHING_AUTHORITY index.
		/// </summary>
		/// <param name="_saCodePunishingAuthorityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishingAuthority"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunishingAuthority GetBySaCodePunishingAuthorityId(System.Decimal _saCodePunishingAuthorityId, int start, int pageLength, out int count)
		{
			return GetBySaCodePunishingAuthorityId(null, _saCodePunishingAuthorityId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PUNISHING_AUTHORITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishingAuthorityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishingAuthority"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodePunishingAuthority GetBySaCodePunishingAuthorityId(TransactionManager transactionManager, System.Decimal _saCodePunishingAuthorityId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodePunishingAuthority&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodePunishingAuthority&gt;"/></returns>
		public static TList<SaCodePunishingAuthority> Fill(IDataReader reader, TList<SaCodePunishingAuthority> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodePunishingAuthority c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodePunishingAuthority")
					.Append("|").Append((System.Decimal)reader["SA_CODE_PUNISHING_AUTHORITY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodePunishingAuthority>(
					key.ToString(), // EntityTrackingKey
					"SaCodePunishingAuthority",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodePunishingAuthority();
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
					c.SaCodePunishingAuthorityId = (System.Decimal)reader["SA_CODE_PUNISHING_AUTHORITY_ID"];
					c.OriginalSaCodePunishingAuthorityId = c.SaCodePunishingAuthorityId;
					c.PAuthCode = Convert.IsDBNull(reader["P_AUTH_CODE"]) ? null : (System.String)reader["P_AUTH_CODE"];
					c.PAuthDescrAr = (System.String)reader["P_AUTH_DESCR_AR"];
					c.PAuthDescrEn = Convert.IsDBNull(reader["P_AUTH_DESCR_EN"]) ? null : (System.String)reader["P_AUTH_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishingAuthority"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodePunishingAuthority"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodePunishingAuthority entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodePunishingAuthorityId = (System.Decimal)reader[((int)SaCodePunishingAuthorityColumn.SaCodePunishingAuthorityId - 1)];
			entity.OriginalSaCodePunishingAuthorityId = (System.Decimal)reader["SA_CODE_PUNISHING_AUTHORITY_ID"];
			entity.PAuthCode = (reader.IsDBNull(((int)SaCodePunishingAuthorityColumn.PAuthCode - 1)))?null:(System.String)reader[((int)SaCodePunishingAuthorityColumn.PAuthCode - 1)];
			entity.PAuthDescrAr = (System.String)reader[((int)SaCodePunishingAuthorityColumn.PAuthDescrAr - 1)];
			entity.PAuthDescrEn = (reader.IsDBNull(((int)SaCodePunishingAuthorityColumn.PAuthDescrEn - 1)))?null:(System.String)reader[((int)SaCodePunishingAuthorityColumn.PAuthDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodePunishingAuthority"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodePunishingAuthority"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodePunishingAuthority entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodePunishingAuthorityId = (System.Decimal)dataRow["SA_CODE_PUNISHING_AUTHORITY_ID"];
			entity.OriginalSaCodePunishingAuthorityId = (System.Decimal)dataRow["SA_CODE_PUNISHING_AUTHORITY_ID"];
			entity.PAuthCode = Convert.IsDBNull(dataRow["P_AUTH_CODE"]) ? null : (System.String)dataRow["P_AUTH_CODE"];
			entity.PAuthDescrAr = (System.String)dataRow["P_AUTH_DESCR_AR"];
			entity.PAuthDescrEn = Convert.IsDBNull(dataRow["P_AUTH_DESCR_EN"]) ? null : (System.String)dataRow["P_AUTH_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodePunishingAuthority"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodePunishingAuthority Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodePunishingAuthority entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodePunishingAuthorityId methods when available
			
			#region SaPunishBylawAuthCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPunishBylawAuth>|SaPunishBylawAuthCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPunishBylawAuthCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPunishBylawAuthCollection = DataRepository.SaPunishBylawAuthProvider.GetBySaCodePunishingAuthorityId(transactionManager, entity.SaCodePunishingAuthorityId);

				if (deep && entity.SaPunishBylawAuthCollection.Count > 0)
				{
					deepHandles.Add("SaPunishBylawAuthCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPunishBylawAuth>) DataRepository.SaPunishBylawAuthProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPunishBylawAuthCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodePunishingAuthority object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodePunishingAuthority instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodePunishingAuthority Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodePunishingAuthority entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaPunishBylawAuth>
				if (CanDeepSave(entity.SaPunishBylawAuthCollection, "List<SaPunishBylawAuth>|SaPunishBylawAuthCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPunishBylawAuth child in entity.SaPunishBylawAuthCollection)
					{
						if(child.SaCodePunishingAuthorityIdSource != null)
						{
							child.SaCodePunishingAuthorityId = child.SaCodePunishingAuthorityIdSource.SaCodePunishingAuthorityId;
						}
						else
						{
							child.SaCodePunishingAuthorityId = entity.SaCodePunishingAuthorityId;
						}

					}

					if (entity.SaPunishBylawAuthCollection.Count > 0 || entity.SaPunishBylawAuthCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPunishBylawAuthProvider.Save(transactionManager, entity.SaPunishBylawAuthCollection);
						
						deepHandles.Add("SaPunishBylawAuthCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPunishBylawAuth >) DataRepository.SaPunishBylawAuthProvider.DeepSave,
							new object[] { transactionManager, entity.SaPunishBylawAuthCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodePunishingAuthorityChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodePunishingAuthority</c>
	///</summary>
	public enum SaCodePunishingAuthorityChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCodePunishingAuthority</c> as OneToMany for SaPunishBylawAuthCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPunishBylawAuth>))]
		SaPunishBylawAuthCollection,
	}
	
	#endregion SaCodePunishingAuthorityChildEntityTypes
	
	#region SaCodePunishingAuthorityFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodePunishingAuthorityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodePunishingAuthority"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodePunishingAuthorityFilterBuilder : SqlFilterBuilder<SaCodePunishingAuthorityColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodePunishingAuthorityFilterBuilder class.
		/// </summary>
		public SaCodePunishingAuthorityFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodePunishingAuthorityFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodePunishingAuthorityFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodePunishingAuthorityFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodePunishingAuthorityFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodePunishingAuthorityFilterBuilder
	
	#region SaCodePunishingAuthorityParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodePunishingAuthorityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodePunishingAuthority"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodePunishingAuthorityParameterBuilder : ParameterizedSqlFilterBuilder<SaCodePunishingAuthorityColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodePunishingAuthorityParameterBuilder class.
		/// </summary>
		public SaCodePunishingAuthorityParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodePunishingAuthorityParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodePunishingAuthorityParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodePunishingAuthorityParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodePunishingAuthorityParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodePunishingAuthorityParameterBuilder
	
	#region SaCodePunishingAuthoritySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodePunishingAuthorityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodePunishingAuthority"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodePunishingAuthoritySortBuilder : SqlSortBuilder<SaCodePunishingAuthorityColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodePunishingAuthoritySqlSortBuilder class.
		/// </summary>
		public SaCodePunishingAuthoritySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodePunishingAuthoritySortBuilder
	
} // end namespace
