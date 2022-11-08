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
	/// This class is the base class for any <see cref="EdStudSemesterGroupProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudSemesterGroupProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudSemesterGroup, UMIS_VER2.BusinessLyer.EdStudSemesterGroupKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSemesterGroupKey key)
		{
			return Delete(transactionManager, key.EdStudSemesterGroupId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudSemesterGroupId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudSemesterGroupId)
		{
			return Delete(null, _edStudSemesterGroupId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterGroupId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudSemesterGroupId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_GROUP_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_SEMESTER_GROUP_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterGroup objects.</returns>
		public TList<EdStudSemesterGroup> GetByEdStudSemesterId(System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(_edStudSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_GROUP_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_SEMESTER_GROUP_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterGroup objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemesterGroup> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_GROUP_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_SEMESTER_GROUP_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterGroup objects.</returns>
		public TList<EdStudSemesterGroup> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_GROUP_ED_STUD_SEMESTER key.
		///		fkEdStudSemesterGroupEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterGroup objects.</returns>
		public TList<EdStudSemesterGroup> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_GROUP_ED_STUD_SEMESTER key.
		///		fkEdStudSemesterGroupEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterGroup objects.</returns>
		public TList<EdStudSemesterGroup> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_GROUP_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_SEMESTER_GROUP_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterGroup objects.</returns>
		public abstract TList<EdStudSemesterGroup> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_GROUP_SC_SECTION_GROUP_HDR key.
		///		FK_ED_STUD_SEMESTER_GROUP_SC_SECTION_GROUP_HDR Description: 
		/// </summary>
		/// <param name="_scSectionGroupHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterGroup objects.</returns>
		public TList<EdStudSemesterGroup> GetByScSectionGroupHdrId(System.Decimal _scSectionGroupHdrId)
		{
			int count = -1;
			return GetByScSectionGroupHdrId(_scSectionGroupHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_GROUP_SC_SECTION_GROUP_HDR key.
		///		FK_ED_STUD_SEMESTER_GROUP_SC_SECTION_GROUP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSectionGroupHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterGroup objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemesterGroup> GetByScSectionGroupHdrId(TransactionManager transactionManager, System.Decimal _scSectionGroupHdrId)
		{
			int count = -1;
			return GetByScSectionGroupHdrId(transactionManager, _scSectionGroupHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_GROUP_SC_SECTION_GROUP_HDR key.
		///		FK_ED_STUD_SEMESTER_GROUP_SC_SECTION_GROUP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSectionGroupHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterGroup objects.</returns>
		public TList<EdStudSemesterGroup> GetByScSectionGroupHdrId(TransactionManager transactionManager, System.Decimal _scSectionGroupHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSectionGroupHdrId(transactionManager, _scSectionGroupHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_GROUP_SC_SECTION_GROUP_HDR key.
		///		fkEdStudSemesterGroupScSectionGroupHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSectionGroupHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterGroup objects.</returns>
		public TList<EdStudSemesterGroup> GetByScSectionGroupHdrId(System.Decimal _scSectionGroupHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScSectionGroupHdrId(null, _scSectionGroupHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_GROUP_SC_SECTION_GROUP_HDR key.
		///		fkEdStudSemesterGroupScSectionGroupHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSectionGroupHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterGroup objects.</returns>
		public TList<EdStudSemesterGroup> GetByScSectionGroupHdrId(System.Decimal _scSectionGroupHdrId, int start, int pageLength,out int count)
		{
			return GetByScSectionGroupHdrId(null, _scSectionGroupHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_GROUP_SC_SECTION_GROUP_HDR key.
		///		FK_ED_STUD_SEMESTER_GROUP_SC_SECTION_GROUP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSectionGroupHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterGroup objects.</returns>
		public abstract TList<EdStudSemesterGroup> GetByScSectionGroupHdrId(TransactionManager transactionManager, System.Decimal _scSectionGroupHdrId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudSemesterGroup Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSemesterGroupKey key, int start, int pageLength)
		{
			return GetByEdStudSemesterGroupId(transactionManager, key.EdStudSemesterGroupId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_SEMESTER_GROUP index.
		/// </summary>
		/// <param name="_edStudSemesterGroupId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterGroup GetByEdStudSemesterGroupId(System.Decimal _edStudSemesterGroupId)
		{
			int count = -1;
			return GetByEdStudSemesterGroupId(null,_edStudSemesterGroupId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER_GROUP index.
		/// </summary>
		/// <param name="_edStudSemesterGroupId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterGroup GetByEdStudSemesterGroupId(System.Decimal _edStudSemesterGroupId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterGroupId(null, _edStudSemesterGroupId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER_GROUP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterGroupId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterGroup GetByEdStudSemesterGroupId(TransactionManager transactionManager, System.Decimal _edStudSemesterGroupId)
		{
			int count = -1;
			return GetByEdStudSemesterGroupId(transactionManager, _edStudSemesterGroupId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER_GROUP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterGroupId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterGroup GetByEdStudSemesterGroupId(TransactionManager transactionManager, System.Decimal _edStudSemesterGroupId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterGroupId(transactionManager, _edStudSemesterGroupId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER_GROUP index.
		/// </summary>
		/// <param name="_edStudSemesterGroupId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterGroup GetByEdStudSemesterGroupId(System.Decimal _edStudSemesterGroupId, int start, int pageLength, out int count)
		{
			return GetByEdStudSemesterGroupId(null, _edStudSemesterGroupId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER_GROUP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterGroupId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterGroup"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudSemesterGroup GetByEdStudSemesterGroupId(TransactionManager transactionManager, System.Decimal _edStudSemesterGroupId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudSemesterGroup&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudSemesterGroup&gt;"/></returns>
		public static TList<EdStudSemesterGroup> Fill(IDataReader reader, TList<EdStudSemesterGroup> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudSemesterGroup c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudSemesterGroup")
					.Append("|").Append((System.Decimal)reader["ED_STUD_SEMESTER_GROUP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudSemesterGroup>(
					key.ToString(), // EntityTrackingKey
					"EdStudSemesterGroup",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudSemesterGroup();
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
					c.EdStudSemesterGroupId = (System.Decimal)reader["ED_STUD_SEMESTER_GROUP_ID"];
					c.OriginalEdStudSemesterGroupId = c.EdStudSemesterGroupId;
					c.EdStudSemesterId = (System.Decimal)reader["ED_STUD_SEMESTER_ID"];
					c.ScSectionGroupHdrId = (System.Decimal)reader["SC_SECTION_GROUP_HDR_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterGroup"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterGroup"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudSemesterGroup entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudSemesterGroupId = (System.Decimal)reader[((int)EdStudSemesterGroupColumn.EdStudSemesterGroupId - 1)];
			entity.OriginalEdStudSemesterGroupId = (System.Decimal)reader["ED_STUD_SEMESTER_GROUP_ID"];
			entity.EdStudSemesterId = (System.Decimal)reader[((int)EdStudSemesterGroupColumn.EdStudSemesterId - 1)];
			entity.ScSectionGroupHdrId = (System.Decimal)reader[((int)EdStudSemesterGroupColumn.ScSectionGroupHdrId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterGroup"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterGroup"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudSemesterGroup entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudSemesterGroupId = (System.Decimal)dataRow["ED_STUD_SEMESTER_GROUP_ID"];
			entity.OriginalEdStudSemesterGroupId = (System.Decimal)dataRow["ED_STUD_SEMESTER_GROUP_ID"];
			entity.EdStudSemesterId = (System.Decimal)dataRow["ED_STUD_SEMESTER_ID"];
			entity.ScSectionGroupHdrId = (System.Decimal)dataRow["SC_SECTION_GROUP_HDR_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterGroup"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudSemesterGroup Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSemesterGroup entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudSemesterIdSource	
			if (CanDeepLoad(entity, "EdStudSemester|EdStudSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdStudSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudSemesterId;
				EdStudSemester tmpEntity = EntityManager.LocateEntity<EdStudSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudSemesterIdSource = tmpEntity;
				else
					entity.EdStudSemesterIdSource = DataRepository.EdStudSemesterProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudSemesterProvider.DeepLoad(transactionManager, entity.EdStudSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudSemesterIdSource

			#region ScSectionGroupHdrIdSource	
			if (CanDeepLoad(entity, "ScSectionGroupHdr|ScSectionGroupHdrIdSource", deepLoadType, innerList) 
				&& entity.ScSectionGroupHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScSectionGroupHdrId;
				ScSectionGroupHdr tmpEntity = EntityManager.LocateEntity<ScSectionGroupHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(ScSectionGroupHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScSectionGroupHdrIdSource = tmpEntity;
				else
					entity.ScSectionGroupHdrIdSource = DataRepository.ScSectionGroupHdrProvider.GetByScSectionGroupHdrId(transactionManager, entity.ScSectionGroupHdrId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSectionGroupHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScSectionGroupHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScSectionGroupHdrProvider.DeepLoad(transactionManager, entity.ScSectionGroupHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScSectionGroupHdrIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudSemesterGroup object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudSemesterGroup instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudSemesterGroup Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSemesterGroup entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudSemesterIdSource
			if (CanDeepSave(entity, "EdStudSemester|EdStudSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdStudSemesterIdSource != null)
			{
				DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterIdSource);
				entity.EdStudSemesterId = entity.EdStudSemesterIdSource.EdStudSemesterId;
			}
			#endregion 
			
			#region ScSectionGroupHdrIdSource
			if (CanDeepSave(entity, "ScSectionGroupHdr|ScSectionGroupHdrIdSource", deepSaveType, innerList) 
				&& entity.ScSectionGroupHdrIdSource != null)
			{
				DataRepository.ScSectionGroupHdrProvider.Save(transactionManager, entity.ScSectionGroupHdrIdSource);
				entity.ScSectionGroupHdrId = entity.ScSectionGroupHdrIdSource.ScSectionGroupHdrId;
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
	
	#region EdStudSemesterGroupChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudSemesterGroup</c>
	///</summary>
	public enum EdStudSemesterGroupChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStudSemester</c> at EdStudSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudSemester))]
		EdStudSemester,
		
		///<summary>
		/// Composite Property for <c>ScSectionGroupHdr</c> at ScSectionGroupHdrIdSource
		///</summary>
		[ChildEntityType(typeof(ScSectionGroupHdr))]
		ScSectionGroupHdr,
	}
	
	#endregion EdStudSemesterGroupChildEntityTypes
	
	#region EdStudSemesterGroupFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudSemesterGroupColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudSemesterGroup"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudSemesterGroupFilterBuilder : SqlFilterBuilder<EdStudSemesterGroupColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterGroupFilterBuilder class.
		/// </summary>
		public EdStudSemesterGroupFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterGroupFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudSemesterGroupFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterGroupFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudSemesterGroupFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudSemesterGroupFilterBuilder
	
	#region EdStudSemesterGroupParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudSemesterGroupColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudSemesterGroup"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudSemesterGroupParameterBuilder : ParameterizedSqlFilterBuilder<EdStudSemesterGroupColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterGroupParameterBuilder class.
		/// </summary>
		public EdStudSemesterGroupParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterGroupParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudSemesterGroupParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterGroupParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudSemesterGroupParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudSemesterGroupParameterBuilder
	
	#region EdStudSemesterGroupSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudSemesterGroupColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudSemesterGroup"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudSemesterGroupSortBuilder : SqlSortBuilder<EdStudSemesterGroupColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterGroupSqlSortBuilder class.
		/// </summary>
		public EdStudSemesterGroupSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudSemesterGroupSortBuilder
	
} // end namespace
