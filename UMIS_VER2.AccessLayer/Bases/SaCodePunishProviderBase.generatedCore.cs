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
	/// This class is the base class for any <see cref="SaCodePunishProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodePunishProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodePunish, UMIS_VER2.BusinessLyer.SaCodePunishKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodePunishKey key)
		{
			return Delete(transactionManager, key.SaCodePunishId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodePunishId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodePunishId)
		{
			return Delete(null, _saCodePunishId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodePunishId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodePunish Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodePunishKey key, int start, int pageLength)
		{
			return GetBySaCodePunishId(transactionManager, key.SaCodePunishId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SA_CODE_PUNISH2 index.
		/// </summary>
		/// <param name="_punishDescrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunish"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunish GetByPunishDescrAr(System.String _punishDescrAr)
		{
			int count = -1;
			return GetByPunishDescrAr(null,_punishDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PUNISH2 index.
		/// </summary>
		/// <param name="_punishDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunish"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunish GetByPunishDescrAr(System.String _punishDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByPunishDescrAr(null, _punishDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PUNISH2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_punishDescrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunish"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunish GetByPunishDescrAr(TransactionManager transactionManager, System.String _punishDescrAr)
		{
			int count = -1;
			return GetByPunishDescrAr(transactionManager, _punishDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PUNISH2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_punishDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunish"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunish GetByPunishDescrAr(TransactionManager transactionManager, System.String _punishDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByPunishDescrAr(transactionManager, _punishDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PUNISH2 index.
		/// </summary>
		/// <param name="_punishDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunish"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunish GetByPunishDescrAr(System.String _punishDescrAr, int start, int pageLength, out int count)
		{
			return GetByPunishDescrAr(null, _punishDescrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PUNISH2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_punishDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunish"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodePunish GetByPunishDescrAr(TransactionManager transactionManager, System.String _punishDescrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_PUNISH index.
		/// </summary>
		/// <param name="_saCodePunishId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunish"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunish GetBySaCodePunishId(System.Decimal _saCodePunishId)
		{
			int count = -1;
			return GetBySaCodePunishId(null,_saCodePunishId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PUNISH index.
		/// </summary>
		/// <param name="_saCodePunishId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunish"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunish GetBySaCodePunishId(System.Decimal _saCodePunishId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodePunishId(null, _saCodePunishId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PUNISH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunish"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunish GetBySaCodePunishId(TransactionManager transactionManager, System.Decimal _saCodePunishId)
		{
			int count = -1;
			return GetBySaCodePunishId(transactionManager, _saCodePunishId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PUNISH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunish"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunish GetBySaCodePunishId(TransactionManager transactionManager, System.Decimal _saCodePunishId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodePunishId(transactionManager, _saCodePunishId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PUNISH index.
		/// </summary>
		/// <param name="_saCodePunishId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunish"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodePunish GetBySaCodePunishId(System.Decimal _saCodePunishId, int start, int pageLength, out int count)
		{
			return GetBySaCodePunishId(null, _saCodePunishId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PUNISH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodePunish"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodePunish GetBySaCodePunishId(TransactionManager transactionManager, System.Decimal _saCodePunishId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodePunish&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodePunish&gt;"/></returns>
		public static TList<SaCodePunish> Fill(IDataReader reader, TList<SaCodePunish> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodePunish c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodePunish")
					.Append("|").Append((System.Decimal)reader["SA_CODE_PUNISH_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodePunish>(
					key.ToString(), // EntityTrackingKey
					"SaCodePunish",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodePunish();
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
					c.SaCodePunishId = (System.Decimal)reader["SA_CODE_PUNISH_ID"];
					c.OriginalSaCodePunishId = c.SaCodePunishId;
					c.PunishCode = Convert.IsDBNull(reader["PUNISH_CODE"]) ? null : (System.String)reader["PUNISH_CODE"];
					c.PunishDescrAr = (System.String)reader["PUNISH_DESCR_AR"];
					c.PunishDescrEn = Convert.IsDBNull(reader["PUNISH_DESCR_EN"]) ? null : (System.String)reader["PUNISH_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodePunish"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodePunish"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodePunish entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodePunishId = (System.Decimal)reader[((int)SaCodePunishColumn.SaCodePunishId - 1)];
			entity.OriginalSaCodePunishId = (System.Decimal)reader["SA_CODE_PUNISH_ID"];
			entity.PunishCode = (reader.IsDBNull(((int)SaCodePunishColumn.PunishCode - 1)))?null:(System.String)reader[((int)SaCodePunishColumn.PunishCode - 1)];
			entity.PunishDescrAr = (System.String)reader[((int)SaCodePunishColumn.PunishDescrAr - 1)];
			entity.PunishDescrEn = (reader.IsDBNull(((int)SaCodePunishColumn.PunishDescrEn - 1)))?null:(System.String)reader[((int)SaCodePunishColumn.PunishDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodePunish"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodePunish"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodePunish entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodePunishId = (System.Decimal)dataRow["SA_CODE_PUNISH_ID"];
			entity.OriginalSaCodePunishId = (System.Decimal)dataRow["SA_CODE_PUNISH_ID"];
			entity.PunishCode = Convert.IsDBNull(dataRow["PUNISH_CODE"]) ? null : (System.String)dataRow["PUNISH_CODE"];
			entity.PunishDescrAr = (System.String)dataRow["PUNISH_DESCR_AR"];
			entity.PunishDescrEn = Convert.IsDBNull(dataRow["PUNISH_DESCR_EN"]) ? null : (System.String)dataRow["PUNISH_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodePunish"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodePunish Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodePunish entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodePunishId methods when available
			
			#region SaPunishmentBylawsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPunishmentBylaws>|SaPunishmentBylawsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPunishmentBylawsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPunishmentBylawsCollection = DataRepository.SaPunishmentBylawsProvider.GetBySaCodePunishId(transactionManager, entity.SaCodePunishId);

				if (deep && entity.SaPunishmentBylawsCollection.Count > 0)
				{
					deepHandles.Add("SaPunishmentBylawsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPunishmentBylaws>) DataRepository.SaPunishmentBylawsProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPunishmentBylawsCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodePunish object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodePunish instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodePunish Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodePunish entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaPunishmentBylaws>
				if (CanDeepSave(entity.SaPunishmentBylawsCollection, "List<SaPunishmentBylaws>|SaPunishmentBylawsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPunishmentBylaws child in entity.SaPunishmentBylawsCollection)
					{
						if(child.SaCodePunishIdSource != null)
						{
							child.SaCodePunishId = child.SaCodePunishIdSource.SaCodePunishId;
						}
						else
						{
							child.SaCodePunishId = entity.SaCodePunishId;
						}

					}

					if (entity.SaPunishmentBylawsCollection.Count > 0 || entity.SaPunishmentBylawsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPunishmentBylawsProvider.Save(transactionManager, entity.SaPunishmentBylawsCollection);
						
						deepHandles.Add("SaPunishmentBylawsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPunishmentBylaws >) DataRepository.SaPunishmentBylawsProvider.DeepSave,
							new object[] { transactionManager, entity.SaPunishmentBylawsCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodePunishChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodePunish</c>
	///</summary>
	public enum SaCodePunishChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCodePunish</c> as OneToMany for SaPunishmentBylawsCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPunishmentBylaws>))]
		SaPunishmentBylawsCollection,
	}
	
	#endregion SaCodePunishChildEntityTypes
	
	#region SaCodePunishFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodePunishColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodePunish"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodePunishFilterBuilder : SqlFilterBuilder<SaCodePunishColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodePunishFilterBuilder class.
		/// </summary>
		public SaCodePunishFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodePunishFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodePunishFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodePunishFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodePunishFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodePunishFilterBuilder
	
	#region SaCodePunishParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodePunishColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodePunish"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodePunishParameterBuilder : ParameterizedSqlFilterBuilder<SaCodePunishColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodePunishParameterBuilder class.
		/// </summary>
		public SaCodePunishParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodePunishParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodePunishParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodePunishParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodePunishParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodePunishParameterBuilder
	
	#region SaCodePunishSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodePunishColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodePunish"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodePunishSortBuilder : SqlSortBuilder<SaCodePunishColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodePunishSqlSortBuilder class.
		/// </summary>
		public SaCodePunishSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodePunishSortBuilder
	
} // end namespace
