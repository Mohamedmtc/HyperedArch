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
	/// This class is the base class for any <see cref="GsCodeRptSignatureProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeRptSignatureProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeRptSignature, UMIS_VER2.BusinessLyer.GsCodeRptSignatureKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeRptSignatureKey key)
		{
			return Delete(transactionManager, key.GsCodeRptSignatureId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeRptSignatureId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeRptSignatureId)
		{
			return Delete(null, _gsCodeRptSignatureId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRptSignatureId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeRptSignatureId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_RPT_SIGNATURE_AS_FACULTY_INFO key.
		///		FK_GS_CODE_RPT_SIGNATURE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeRptSignature objects.</returns>
		public TList<GsCodeRptSignature> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_RPT_SIGNATURE_AS_FACULTY_INFO key.
		///		FK_GS_CODE_RPT_SIGNATURE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeRptSignature objects.</returns>
		/// <remarks></remarks>
		public TList<GsCodeRptSignature> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_RPT_SIGNATURE_AS_FACULTY_INFO key.
		///		FK_GS_CODE_RPT_SIGNATURE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeRptSignature objects.</returns>
		public TList<GsCodeRptSignature> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_RPT_SIGNATURE_AS_FACULTY_INFO key.
		///		fkGsCodeRptSignatureAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeRptSignature objects.</returns>
		public TList<GsCodeRptSignature> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_RPT_SIGNATURE_AS_FACULTY_INFO key.
		///		fkGsCodeRptSignatureAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeRptSignature objects.</returns>
		public TList<GsCodeRptSignature> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_RPT_SIGNATURE_AS_FACULTY_INFO key.
		///		FK_GS_CODE_RPT_SIGNATURE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeRptSignature objects.</returns>
		public abstract TList<GsCodeRptSignature> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeRptSignature Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeRptSignatureKey key, int start, int pageLength)
		{
			return GetByGsCodeRptSignatureId(transactionManager, key.GsCodeRptSignatureId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_RPT_SIGNATURE index.
		/// </summary>
		/// <param name="_gsCodeRptSignatureId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeRptSignature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeRptSignature GetByGsCodeRptSignatureId(System.Decimal _gsCodeRptSignatureId)
		{
			int count = -1;
			return GetByGsCodeRptSignatureId(null,_gsCodeRptSignatureId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_RPT_SIGNATURE index.
		/// </summary>
		/// <param name="_gsCodeRptSignatureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeRptSignature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeRptSignature GetByGsCodeRptSignatureId(System.Decimal _gsCodeRptSignatureId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeRptSignatureId(null, _gsCodeRptSignatureId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_RPT_SIGNATURE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRptSignatureId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeRptSignature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeRptSignature GetByGsCodeRptSignatureId(TransactionManager transactionManager, System.Decimal _gsCodeRptSignatureId)
		{
			int count = -1;
			return GetByGsCodeRptSignatureId(transactionManager, _gsCodeRptSignatureId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_RPT_SIGNATURE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRptSignatureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeRptSignature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeRptSignature GetByGsCodeRptSignatureId(TransactionManager transactionManager, System.Decimal _gsCodeRptSignatureId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeRptSignatureId(transactionManager, _gsCodeRptSignatureId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_RPT_SIGNATURE index.
		/// </summary>
		/// <param name="_gsCodeRptSignatureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeRptSignature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeRptSignature GetByGsCodeRptSignatureId(System.Decimal _gsCodeRptSignatureId, int start, int pageLength, out int count)
		{
			return GetByGsCodeRptSignatureId(null, _gsCodeRptSignatureId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_RPT_SIGNATURE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRptSignatureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeRptSignature"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeRptSignature GetByGsCodeRptSignatureId(TransactionManager transactionManager, System.Decimal _gsCodeRptSignatureId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeRptSignature&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeRptSignature&gt;"/></returns>
		public static TList<GsCodeRptSignature> Fill(IDataReader reader, TList<GsCodeRptSignature> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeRptSignature c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeRptSignature")
					.Append("|").Append((System.Decimal)reader["GS_CODE_RPT_SIGNATURE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeRptSignature>(
					key.ToString(), // EntityTrackingKey
					"GsCodeRptSignature",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeRptSignature();
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
					c.GsCodeRptSignatureId = (System.Decimal)reader["GS_CODE_RPT_SIGNATURE_ID"];
					c.OriginalGsCodeRptSignatureId = c.GsCodeRptSignatureId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.PersonNameAr = Convert.IsDBNull(reader["PERSON_NAME_AR"]) ? null : (System.String)reader["PERSON_NAME_AR"];
					c.PersonNameEn = Convert.IsDBNull(reader["PERSON_NAME_EN"]) ? null : (System.String)reader["PERSON_NAME_EN"];
					c.SigOrder = (System.Decimal)reader["SIG_ORDER"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeRptSignature"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeRptSignature"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeRptSignature entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeRptSignatureId = (System.Decimal)reader[((int)GsCodeRptSignatureColumn.GsCodeRptSignatureId - 1)];
			entity.OriginalGsCodeRptSignatureId = (System.Decimal)reader["GS_CODE_RPT_SIGNATURE_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCodeRptSignatureColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)GsCodeRptSignatureColumn.DescrEn - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)GsCodeRptSignatureColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)GsCodeRptSignatureColumn.AsFacultyInfoId - 1)];
			entity.PersonNameAr = (reader.IsDBNull(((int)GsCodeRptSignatureColumn.PersonNameAr - 1)))?null:(System.String)reader[((int)GsCodeRptSignatureColumn.PersonNameAr - 1)];
			entity.PersonNameEn = (reader.IsDBNull(((int)GsCodeRptSignatureColumn.PersonNameEn - 1)))?null:(System.String)reader[((int)GsCodeRptSignatureColumn.PersonNameEn - 1)];
			entity.SigOrder = (System.Decimal)reader[((int)GsCodeRptSignatureColumn.SigOrder - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeRptSignature"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeRptSignature"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeRptSignature entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeRptSignatureId = (System.Decimal)dataRow["GS_CODE_RPT_SIGNATURE_ID"];
			entity.OriginalGsCodeRptSignatureId = (System.Decimal)dataRow["GS_CODE_RPT_SIGNATURE_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.PersonNameAr = Convert.IsDBNull(dataRow["PERSON_NAME_AR"]) ? null : (System.String)dataRow["PERSON_NAME_AR"];
			entity.PersonNameEn = Convert.IsDBNull(dataRow["PERSON_NAME_EN"]) ? null : (System.String)dataRow["PERSON_NAME_EN"];
			entity.SigOrder = (System.Decimal)dataRow["SIG_ORDER"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeRptSignature"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeRptSignature Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeRptSignature entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsFacultyInfoId ?? 0.0m);
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, (entity.AsFacultyInfoId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeRptSignature object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeRptSignature instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeRptSignature Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeRptSignature entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
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
	
	#region GsCodeRptSignatureChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeRptSignature</c>
	///</summary>
	public enum GsCodeRptSignatureChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
	}
	
	#endregion GsCodeRptSignatureChildEntityTypes
	
	#region GsCodeRptSignatureFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeRptSignatureColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeRptSignature"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeRptSignatureFilterBuilder : SqlFilterBuilder<GsCodeRptSignatureColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeRptSignatureFilterBuilder class.
		/// </summary>
		public GsCodeRptSignatureFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeRptSignatureFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeRptSignatureFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeRptSignatureFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeRptSignatureFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeRptSignatureFilterBuilder
	
	#region GsCodeRptSignatureParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeRptSignatureColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeRptSignature"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeRptSignatureParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeRptSignatureColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeRptSignatureParameterBuilder class.
		/// </summary>
		public GsCodeRptSignatureParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeRptSignatureParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeRptSignatureParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeRptSignatureParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeRptSignatureParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeRptSignatureParameterBuilder
	
	#region GsCodeRptSignatureSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeRptSignatureColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeRptSignature"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeRptSignatureSortBuilder : SqlSortBuilder<GsCodeRptSignatureColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeRptSignatureSqlSortBuilder class.
		/// </summary>
		public GsCodeRptSignatureSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeRptSignatureSortBuilder
	
} // end namespace
