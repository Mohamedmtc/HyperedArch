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
	/// This class is the base class for any <see cref="AdmAppSponsorProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppSponsorProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppSponsor, UMIS_VER2.BusinessLyer.AdmAppSponsorKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppSponsorKey key)
		{
			return Delete(transactionManager, key.AdmAppSponsorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppSponsorId">If sponsor Jaika EJUST. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppSponsorId)
		{
			return Delete(null, _admAppSponsorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppSponsorId">If sponsor Jaika EJUST. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppSponsorId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SPONSOR_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_SPONSOR_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSponsor objects.</returns>
		public TList<AdmAppSponsor> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SPONSOR_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_SPONSOR_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSponsor objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppSponsor> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SPONSOR_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_SPONSOR_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSponsor objects.</returns>
		public TList<AdmAppSponsor> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SPONSOR_ADM_APP_REG_HISTORY key.
		///		fkAdmAppSponsorAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSponsor objects.</returns>
		public TList<AdmAppSponsor> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SPONSOR_ADM_APP_REG_HISTORY key.
		///		fkAdmAppSponsorAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSponsor objects.</returns>
		public TList<AdmAppSponsor> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SPONSOR_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_SPONSOR_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSponsor objects.</returns>
		public abstract TList<AdmAppSponsor> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppSponsor Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppSponsorKey key, int start, int pageLength)
		{
			return GetByAdmAppSponsorId(transactionManager, key.AdmAppSponsorId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_SPONSOR index.
		/// </summary>
		/// <param name="_admAppSponsorId">If sponsor Jaika EJUST</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppSponsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppSponsor GetByAdmAppSponsorId(System.Decimal _admAppSponsorId)
		{
			int count = -1;
			return GetByAdmAppSponsorId(null,_admAppSponsorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_SPONSOR index.
		/// </summary>
		/// <param name="_admAppSponsorId">If sponsor Jaika EJUST</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppSponsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppSponsor GetByAdmAppSponsorId(System.Decimal _admAppSponsorId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppSponsorId(null, _admAppSponsorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_SPONSOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppSponsorId">If sponsor Jaika EJUST</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppSponsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppSponsor GetByAdmAppSponsorId(TransactionManager transactionManager, System.Decimal _admAppSponsorId)
		{
			int count = -1;
			return GetByAdmAppSponsorId(transactionManager, _admAppSponsorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_SPONSOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppSponsorId">If sponsor Jaika EJUST</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppSponsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppSponsor GetByAdmAppSponsorId(TransactionManager transactionManager, System.Decimal _admAppSponsorId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppSponsorId(transactionManager, _admAppSponsorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_SPONSOR index.
		/// </summary>
		/// <param name="_admAppSponsorId">If sponsor Jaika EJUST</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppSponsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppSponsor GetByAdmAppSponsorId(System.Decimal _admAppSponsorId, int start, int pageLength, out int count)
		{
			return GetByAdmAppSponsorId(null, _admAppSponsorId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_SPONSOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppSponsorId">If sponsor Jaika EJUST</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppSponsor"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppSponsor GetByAdmAppSponsorId(TransactionManager transactionManager, System.Decimal _admAppSponsorId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppSponsor&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppSponsor&gt;"/></returns>
		public static TList<AdmAppSponsor> Fill(IDataReader reader, TList<AdmAppSponsor> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppSponsor c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppSponsor")
					.Append("|").Append((System.Decimal)reader["ADM_APP_SPONSOR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppSponsor>(
					key.ToString(), // EntityTrackingKey
					"AdmAppSponsor",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppSponsor();
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
					c.AdmAppSponsorId = (System.Decimal)reader["ADM_APP_SPONSOR_ID"];
					c.OriginalAdmAppSponsorId = c.AdmAppSponsorId;
					c.AdmAppRegHistoryId = (System.Decimal)reader["ADM_APP_REG_HISTORY_ID"];
					c.OfficeName = Convert.IsDBNull(reader["OFFICE_NAME"]) ? null : (System.String)reader["OFFICE_NAME"];
					c.PersonName = Convert.IsDBNull(reader["PERSON_NAME"]) ? null : (System.String)reader["PERSON_NAME"];
					c.PesonEmail = Convert.IsDBNull(reader["PESON_EMAIL"]) ? null : (System.String)reader["PESON_EMAIL"];
					c.TermcondFlg = Convert.IsDBNull(reader["TERMCOND_FLG"]) ? null : (System.Boolean?)reader["TERMCOND_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppSponsor"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppSponsor"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppSponsor entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppSponsorId = (System.Decimal)reader[((int)AdmAppSponsorColumn.AdmAppSponsorId - 1)];
			entity.OriginalAdmAppSponsorId = (System.Decimal)reader["ADM_APP_SPONSOR_ID"];
			entity.AdmAppRegHistoryId = (System.Decimal)reader[((int)AdmAppSponsorColumn.AdmAppRegHistoryId - 1)];
			entity.OfficeName = (reader.IsDBNull(((int)AdmAppSponsorColumn.OfficeName - 1)))?null:(System.String)reader[((int)AdmAppSponsorColumn.OfficeName - 1)];
			entity.PersonName = (reader.IsDBNull(((int)AdmAppSponsorColumn.PersonName - 1)))?null:(System.String)reader[((int)AdmAppSponsorColumn.PersonName - 1)];
			entity.PesonEmail = (reader.IsDBNull(((int)AdmAppSponsorColumn.PesonEmail - 1)))?null:(System.String)reader[((int)AdmAppSponsorColumn.PesonEmail - 1)];
			entity.TermcondFlg = (reader.IsDBNull(((int)AdmAppSponsorColumn.TermcondFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppSponsorColumn.TermcondFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppSponsor"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppSponsor"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppSponsor entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppSponsorId = (System.Decimal)dataRow["ADM_APP_SPONSOR_ID"];
			entity.OriginalAdmAppSponsorId = (System.Decimal)dataRow["ADM_APP_SPONSOR_ID"];
			entity.AdmAppRegHistoryId = (System.Decimal)dataRow["ADM_APP_REG_HISTORY_ID"];
			entity.OfficeName = Convert.IsDBNull(dataRow["OFFICE_NAME"]) ? null : (System.String)dataRow["OFFICE_NAME"];
			entity.PersonName = Convert.IsDBNull(dataRow["PERSON_NAME"]) ? null : (System.String)dataRow["PERSON_NAME"];
			entity.PesonEmail = Convert.IsDBNull(dataRow["PESON_EMAIL"]) ? null : (System.String)dataRow["PESON_EMAIL"];
			entity.TermcondFlg = Convert.IsDBNull(dataRow["TERMCOND_FLG"]) ? null : (System.Boolean?)dataRow["TERMCOND_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppSponsor"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppSponsor Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppSponsor entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppRegHistoryIdSource	
			if (CanDeepLoad(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepLoadType, innerList) 
				&& entity.AdmAppRegHistoryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmAppRegHistoryId;
				AdmAppRegHistory tmpEntity = EntityManager.LocateEntity<AdmAppRegHistory>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppRegHistory), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppRegHistoryIdSource = tmpEntity;
				else
					entity.AdmAppRegHistoryIdSource = DataRepository.AdmAppRegHistoryProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppRegHistoryIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppRegHistoryProvider.DeepLoad(transactionManager, entity.AdmAppRegHistoryIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppRegHistoryIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppSponsor object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppSponsor instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppSponsor Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppSponsor entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAppRegHistoryIdSource
			if (CanDeepSave(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepSaveType, innerList) 
				&& entity.AdmAppRegHistoryIdSource != null)
			{
				DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryIdSource);
				entity.AdmAppRegHistoryId = entity.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
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
	
	#region AdmAppSponsorChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppSponsor</c>
	///</summary>
	public enum AdmAppSponsorChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppRegHistory</c> at AdmAppRegHistoryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppRegHistory))]
		AdmAppRegHistory,
	}
	
	#endregion AdmAppSponsorChildEntityTypes
	
	#region AdmAppSponsorFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppSponsorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppSponsor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppSponsorFilterBuilder : SqlFilterBuilder<AdmAppSponsorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppSponsorFilterBuilder class.
		/// </summary>
		public AdmAppSponsorFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppSponsorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppSponsorFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppSponsorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppSponsorFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppSponsorFilterBuilder
	
	#region AdmAppSponsorParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppSponsorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppSponsor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppSponsorParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppSponsorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppSponsorParameterBuilder class.
		/// </summary>
		public AdmAppSponsorParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppSponsorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppSponsorParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppSponsorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppSponsorParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppSponsorParameterBuilder
	
	#region AdmAppSponsorSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppSponsorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppSponsor"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppSponsorSortBuilder : SqlSortBuilder<AdmAppSponsorColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppSponsorSqlSortBuilder class.
		/// </summary>
		public AdmAppSponsorSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppSponsorSortBuilder
	
} // end namespace
