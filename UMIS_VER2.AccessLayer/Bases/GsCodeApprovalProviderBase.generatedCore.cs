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
	/// This class is the base class for any <see cref="GsCodeApprovalProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeApprovalProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeApproval, UMIS_VER2.BusinessLyer.GsCodeApprovalKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApprovalKey key)
		{
			return Delete(transactionManager, key.GsCodeApprovalId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeApprovalId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeApprovalId)
		{
			return Delete(null, _gsCodeApprovalId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0010 key.
		///		FK_AUTO_0010 Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApproval objects.</returns>
		public TList<GsCodeApproval> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0010 key.
		///		FK_AUTO_0010 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApproval objects.</returns>
		/// <remarks></remarks>
		public TList<GsCodeApproval> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0010 key.
		///		FK_AUTO_0010 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApproval objects.</returns>
		public TList<GsCodeApproval> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0010 key.
		///		fkAuto0010 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApproval objects.</returns>
		public TList<GsCodeApproval> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0010 key.
		///		fkAuto0010 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApproval objects.</returns>
		public TList<GsCodeApproval> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0010 key.
		///		FK_AUTO_0010 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApproval objects.</returns>
		public abstract TList<GsCodeApproval> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_APPROVAL_SE_CODE_USER_TYPE key.
		///		FK_GS_CODE_APPROVAL_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="_seCodeUserTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApproval objects.</returns>
		public TList<GsCodeApproval> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(_seCodeUserTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_APPROVAL_SE_CODE_USER_TYPE key.
		///		FK_GS_CODE_APPROVAL_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApproval objects.</returns>
		/// <remarks></remarks>
		public TList<GsCodeApproval> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_APPROVAL_SE_CODE_USER_TYPE key.
		///		FK_GS_CODE_APPROVAL_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApproval objects.</returns>
		public TList<GsCodeApproval> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_APPROVAL_SE_CODE_USER_TYPE key.
		///		fkGsCodeApprovalSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApproval objects.</returns>
		public TList<GsCodeApproval> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_APPROVAL_SE_CODE_USER_TYPE key.
		///		fkGsCodeApprovalSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApproval objects.</returns>
		public TList<GsCodeApproval> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId, int start, int pageLength,out int count)
		{
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_APPROVAL_SE_CODE_USER_TYPE key.
		///		FK_GS_CODE_APPROVAL_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApproval objects.</returns>
		public abstract TList<GsCodeApproval> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeApproval Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApprovalKey key, int start, int pageLength)
		{
			return GetByGsCodeApprovalId(transactionManager, key.GsCodeApprovalId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_APPROVAL index.
		/// </summary>
		/// <param name="_gsCodeApprovalId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApproval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApproval GetByGsCodeApprovalId(System.Decimal _gsCodeApprovalId)
		{
			int count = -1;
			return GetByGsCodeApprovalId(null,_gsCodeApprovalId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL index.
		/// </summary>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApproval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApproval GetByGsCodeApprovalId(System.Decimal _gsCodeApprovalId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalId(null, _gsCodeApprovalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApproval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApproval GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId)
		{
			int count = -1;
			return GetByGsCodeApprovalId(transactionManager, _gsCodeApprovalId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApproval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApproval GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalId(transactionManager, _gsCodeApprovalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL index.
		/// </summary>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApproval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApproval GetByGsCodeApprovalId(System.Decimal _gsCodeApprovalId, int start, int pageLength, out int count)
		{
			return GetByGsCodeApprovalId(null, _gsCodeApprovalId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApproval"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeApproval GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeApproval&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeApproval&gt;"/></returns>
		public static TList<GsCodeApproval> Fill(IDataReader reader, TList<GsCodeApproval> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeApproval c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeApproval")
					.Append("|").Append((System.Decimal)reader["GS_CODE_APPROVAL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeApproval>(
					key.ToString(), // EntityTrackingKey
					"GsCodeApproval",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeApproval();
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
					c.GsCodeApprovalId = (System.Decimal)reader["GS_CODE_APPROVAL_ID"];
					c.OriginalGsCodeApprovalId = c.GsCodeApprovalId;
					c.ApprovalDescrAr = (System.String)reader["APPROVAL_DESCR_AR"];
					c.ApprovalDescrEn = Convert.IsDBNull(reader["APPROVAL_DESCR_EN"]) ? null : (System.String)reader["APPROVAL_DESCR_EN"];
					c.ApprovalCode = Convert.IsDBNull(reader["APPROVAL_CODE"]) ? null : (System.String)reader["APPROVAL_CODE"];
					c.IsDelegationRequired = (System.Decimal)reader["IS_DELEGATION_REQUIRED"];
					c.HasResolution = (System.Decimal)reader["HAS_RESOLUTION"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.ApprovalOrader = (System.Decimal)reader["APPROVAL_ORADER"];
					c.SeCodeUserTypeId = Convert.IsDBNull(reader["SE_CODE_USER_TYPE_ID"]) ? null : (System.Decimal?)reader["SE_CODE_USER_TYPE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeApproval"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeApproval"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeApproval entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeApprovalId = (System.Decimal)reader[((int)GsCodeApprovalColumn.GsCodeApprovalId - 1)];
			entity.OriginalGsCodeApprovalId = (System.Decimal)reader["GS_CODE_APPROVAL_ID"];
			entity.ApprovalDescrAr = (System.String)reader[((int)GsCodeApprovalColumn.ApprovalDescrAr - 1)];
			entity.ApprovalDescrEn = (reader.IsDBNull(((int)GsCodeApprovalColumn.ApprovalDescrEn - 1)))?null:(System.String)reader[((int)GsCodeApprovalColumn.ApprovalDescrEn - 1)];
			entity.ApprovalCode = (reader.IsDBNull(((int)GsCodeApprovalColumn.ApprovalCode - 1)))?null:(System.String)reader[((int)GsCodeApprovalColumn.ApprovalCode - 1)];
			entity.IsDelegationRequired = (System.Decimal)reader[((int)GsCodeApprovalColumn.IsDelegationRequired - 1)];
			entity.HasResolution = (System.Decimal)reader[((int)GsCodeApprovalColumn.HasResolution - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)GsCodeApprovalColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)GsCodeApprovalColumn.AsFacultyInfoId - 1)];
			entity.ApprovalOrader = (System.Decimal)reader[((int)GsCodeApprovalColumn.ApprovalOrader - 1)];
			entity.SeCodeUserTypeId = (reader.IsDBNull(((int)GsCodeApprovalColumn.SeCodeUserTypeId - 1)))?null:(System.Decimal?)reader[((int)GsCodeApprovalColumn.SeCodeUserTypeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeApproval"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeApproval"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeApproval entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeApprovalId = (System.Decimal)dataRow["GS_CODE_APPROVAL_ID"];
			entity.OriginalGsCodeApprovalId = (System.Decimal)dataRow["GS_CODE_APPROVAL_ID"];
			entity.ApprovalDescrAr = (System.String)dataRow["APPROVAL_DESCR_AR"];
			entity.ApprovalDescrEn = Convert.IsDBNull(dataRow["APPROVAL_DESCR_EN"]) ? null : (System.String)dataRow["APPROVAL_DESCR_EN"];
			entity.ApprovalCode = Convert.IsDBNull(dataRow["APPROVAL_CODE"]) ? null : (System.String)dataRow["APPROVAL_CODE"];
			entity.IsDelegationRequired = (System.Decimal)dataRow["IS_DELEGATION_REQUIRED"];
			entity.HasResolution = (System.Decimal)dataRow["HAS_RESOLUTION"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.ApprovalOrader = (System.Decimal)dataRow["APPROVAL_ORADER"];
			entity.SeCodeUserTypeId = Convert.IsDBNull(dataRow["SE_CODE_USER_TYPE_ID"]) ? null : (System.Decimal?)dataRow["SE_CODE_USER_TYPE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeApproval"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeApproval Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApproval entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region SeCodeUserTypeIdSource	
			if (CanDeepLoad(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepLoadType, innerList) 
				&& entity.SeCodeUserTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeCodeUserTypeId ?? 0.0m);
				SeCodeUserType tmpEntity = EntityManager.LocateEntity<SeCodeUserType>(EntityLocator.ConstructKeyFromPkItems(typeof(SeCodeUserType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeCodeUserTypeIdSource = tmpEntity;
				else
					entity.SeCodeUserTypeIdSource = DataRepository.SeCodeUserTypeProvider.GetBySeCodeUserTypeId(transactionManager, (entity.SeCodeUserTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeCodeUserTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeCodeUserTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeCodeUserTypeProvider.DeepLoad(transactionManager, entity.SeCodeUserTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeCodeUserTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeApprovalId methods when available
			
			#region PgThesisStudApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudApproveCollection = DataRepository.PgThesisStudApproveProvider.GetByGsCodeApprovalId(transactionManager, entity.GsCodeApprovalId);

				if (deep && entity.PgThesisStudApproveCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStudApprove>) DataRepository.PgThesisStudApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudViolCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudViol>|EdStudViolCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudViolCollection = DataRepository.EdStudViolProvider.GetByGsCodeApprovalId(transactionManager, entity.GsCodeApprovalId);

				if (deep && entity.EdStudViolCollection.Count > 0)
				{
					deepHandles.Add("EdStudViolCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudViol>) DataRepository.EdStudViolProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudViolCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCdeApprovalPnltyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCdeApprovalPnlty>|GsCdeApprovalPnltyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeApprovalPnltyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCdeApprovalPnltyCollection = DataRepository.GsCdeApprovalPnltyProvider.GetByGsCodeApprovalId(transactionManager, entity.GsCodeApprovalId);

				if (deep && entity.GsCdeApprovalPnltyCollection.Count > 0)
				{
					deepHandles.Add("GsCdeApprovalPnltyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCdeApprovalPnlty>) DataRepository.GsCdeApprovalPnltyProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCdeApprovalPnltyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCodeApprovalListDCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCodeApprovalListD>|GsCodeApprovalListDCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalListDCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCodeApprovalListDCollection = DataRepository.GsCodeApprovalListDProvider.GetByGsCodeApprovalId(transactionManager, entity.GsCodeApprovalId);

				if (deep && entity.GsCodeApprovalListDCollection.Count > 0)
				{
					deepHandles.Add("GsCodeApprovalListDCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCodeApprovalListD>) DataRepository.GsCodeApprovalListDProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCodeApprovalListDCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisCommApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisCommApprove>|PgThesisCommApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisCommApproveCollection = DataRepository.PgThesisCommApproveProvider.GetByGsCodeApprovalId(transactionManager, entity.GsCodeApprovalId);

				if (deep && entity.PgThesisCommApproveCollection.Count > 0)
				{
					deepHandles.Add("PgThesisCommApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisCommApprove>) DataRepository.PgThesisCommApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisCommApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisSupervisorCommApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisSupervisorCommApprove>|PgThesisSupervisorCommApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisSupervisorCommApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisSupervisorCommApproveCollection = DataRepository.PgThesisSupervisorCommApproveProvider.GetByGsCodeApprovalId(transactionManager, entity.GsCodeApprovalId);

				if (deep && entity.PgThesisSupervisorCommApproveCollection.Count > 0)
				{
					deepHandles.Add("PgThesisSupervisorCommApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisSupervisorCommApprove>) DataRepository.PgThesisSupervisorCommApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisSupervisorCommApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCodeApprovalFacultyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCodeApprovalFaculty>|GsCodeApprovalFacultyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalFacultyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCodeApprovalFacultyCollection = DataRepository.GsCodeApprovalFacultyProvider.GetByGsCodeApprovalId(transactionManager, entity.GsCodeApprovalId);

				if (deep && entity.GsCodeApprovalFacultyCollection.Count > 0)
				{
					deepHandles.Add("GsCodeApprovalFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCodeApprovalFaculty>) DataRepository.GsCodeApprovalFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCodeApprovalFacultyCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeApproval object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeApproval instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeApproval Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApproval entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region SeCodeUserTypeIdSource
			if (CanDeepSave(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepSaveType, innerList) 
				&& entity.SeCodeUserTypeIdSource != null)
			{
				DataRepository.SeCodeUserTypeProvider.Save(transactionManager, entity.SeCodeUserTypeIdSource);
				entity.SeCodeUserTypeId = entity.SeCodeUserTypeIdSource.SeCodeUserTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<PgThesisStudApprove>
				if (CanDeepSave(entity.PgThesisStudApproveCollection, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStudApprove child in entity.PgThesisStudApproveCollection)
					{
						if(child.GsCodeApprovalIdSource != null)
						{
							child.GsCodeApprovalId = child.GsCodeApprovalIdSource.GsCodeApprovalId;
						}
						else
						{
							child.GsCodeApprovalId = entity.GsCodeApprovalId;
						}

					}

					if (entity.PgThesisStudApproveCollection.Count > 0 || entity.PgThesisStudApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudApproveProvider.Save(transactionManager, entity.PgThesisStudApproveCollection);
						
						deepHandles.Add("PgThesisStudApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStudApprove >) DataRepository.PgThesisStudApproveProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudViol>
				if (CanDeepSave(entity.EdStudViolCollection, "List<EdStudViol>|EdStudViolCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudViol child in entity.EdStudViolCollection)
					{
						if(child.GsCodeApprovalIdSource != null)
						{
							child.GsCodeApprovalId = child.GsCodeApprovalIdSource.GsCodeApprovalId;
						}
						else
						{
							child.GsCodeApprovalId = entity.GsCodeApprovalId;
						}

					}

					if (entity.EdStudViolCollection.Count > 0 || entity.EdStudViolCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolCollection);
						
						deepHandles.Add("EdStudViolCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudViol >) DataRepository.EdStudViolProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudViolCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCdeApprovalPnlty>
				if (CanDeepSave(entity.GsCdeApprovalPnltyCollection, "List<GsCdeApprovalPnlty>|GsCdeApprovalPnltyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCdeApprovalPnlty child in entity.GsCdeApprovalPnltyCollection)
					{
						if(child.GsCodeApprovalIdSource != null)
						{
							child.GsCodeApprovalId = child.GsCodeApprovalIdSource.GsCodeApprovalId;
						}
						else
						{
							child.GsCodeApprovalId = entity.GsCodeApprovalId;
						}

					}

					if (entity.GsCdeApprovalPnltyCollection.Count > 0 || entity.GsCdeApprovalPnltyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCdeApprovalPnltyProvider.Save(transactionManager, entity.GsCdeApprovalPnltyCollection);
						
						deepHandles.Add("GsCdeApprovalPnltyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCdeApprovalPnlty >) DataRepository.GsCdeApprovalPnltyProvider.DeepSave,
							new object[] { transactionManager, entity.GsCdeApprovalPnltyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCodeApprovalListD>
				if (CanDeepSave(entity.GsCodeApprovalListDCollection, "List<GsCodeApprovalListD>|GsCodeApprovalListDCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCodeApprovalListD child in entity.GsCodeApprovalListDCollection)
					{
						if(child.GsCodeApprovalIdSource != null)
						{
							child.GsCodeApprovalId = child.GsCodeApprovalIdSource.GsCodeApprovalId;
						}
						else
						{
							child.GsCodeApprovalId = entity.GsCodeApprovalId;
						}

					}

					if (entity.GsCodeApprovalListDCollection.Count > 0 || entity.GsCodeApprovalListDCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCodeApprovalListDProvider.Save(transactionManager, entity.GsCodeApprovalListDCollection);
						
						deepHandles.Add("GsCodeApprovalListDCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCodeApprovalListD >) DataRepository.GsCodeApprovalListDProvider.DeepSave,
							new object[] { transactionManager, entity.GsCodeApprovalListDCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisCommApprove>
				if (CanDeepSave(entity.PgThesisCommApproveCollection, "List<PgThesisCommApprove>|PgThesisCommApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisCommApprove child in entity.PgThesisCommApproveCollection)
					{
						if(child.GsCodeApprovalIdSource != null)
						{
							child.GsCodeApprovalId = child.GsCodeApprovalIdSource.GsCodeApprovalId;
						}
						else
						{
							child.GsCodeApprovalId = entity.GsCodeApprovalId;
						}

					}

					if (entity.PgThesisCommApproveCollection.Count > 0 || entity.PgThesisCommApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisCommApproveProvider.Save(transactionManager, entity.PgThesisCommApproveCollection);
						
						deepHandles.Add("PgThesisCommApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisCommApprove >) DataRepository.PgThesisCommApproveProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisCommApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisSupervisorCommApprove>
				if (CanDeepSave(entity.PgThesisSupervisorCommApproveCollection, "List<PgThesisSupervisorCommApprove>|PgThesisSupervisorCommApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisSupervisorCommApprove child in entity.PgThesisSupervisorCommApproveCollection)
					{
						if(child.GsCodeApprovalIdSource != null)
						{
							child.GsCodeApprovalId = child.GsCodeApprovalIdSource.GsCodeApprovalId;
						}
						else
						{
							child.GsCodeApprovalId = entity.GsCodeApprovalId;
						}

					}

					if (entity.PgThesisSupervisorCommApproveCollection.Count > 0 || entity.PgThesisSupervisorCommApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisSupervisorCommApproveProvider.Save(transactionManager, entity.PgThesisSupervisorCommApproveCollection);
						
						deepHandles.Add("PgThesisSupervisorCommApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisSupervisorCommApprove >) DataRepository.PgThesisSupervisorCommApproveProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisSupervisorCommApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCodeApprovalFaculty>
				if (CanDeepSave(entity.GsCodeApprovalFacultyCollection, "List<GsCodeApprovalFaculty>|GsCodeApprovalFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCodeApprovalFaculty child in entity.GsCodeApprovalFacultyCollection)
					{
						if(child.GsCodeApprovalIdSource != null)
						{
							child.GsCodeApprovalId = child.GsCodeApprovalIdSource.GsCodeApprovalId;
						}
						else
						{
							child.GsCodeApprovalId = entity.GsCodeApprovalId;
						}

					}

					if (entity.GsCodeApprovalFacultyCollection.Count > 0 || entity.GsCodeApprovalFacultyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCodeApprovalFacultyProvider.Save(transactionManager, entity.GsCodeApprovalFacultyCollection);
						
						deepHandles.Add("GsCodeApprovalFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCodeApprovalFaculty >) DataRepository.GsCodeApprovalFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.GsCodeApprovalFacultyCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCodeApprovalChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeApproval</c>
	///</summary>
	public enum GsCodeApprovalChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>SeCodeUserType</c> at SeCodeUserTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SeCodeUserType))]
		SeCodeUserType,
		///<summary>
		/// Collection of <c>GsCodeApproval</c> as OneToMany for PgThesisStudApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStudApprove>))]
		PgThesisStudApproveCollection,
		///<summary>
		/// Collection of <c>GsCodeApproval</c> as OneToMany for EdStudViolCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudViol>))]
		EdStudViolCollection,
		///<summary>
		/// Collection of <c>GsCodeApproval</c> as OneToMany for GsCdeApprovalPnltyCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCdeApprovalPnlty>))]
		GsCdeApprovalPnltyCollection,
		///<summary>
		/// Collection of <c>GsCodeApproval</c> as OneToMany for GsCodeApprovalListDCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCodeApprovalListD>))]
		GsCodeApprovalListDCollection,
		///<summary>
		/// Collection of <c>GsCodeApproval</c> as OneToMany for PgThesisCommApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisCommApprove>))]
		PgThesisCommApproveCollection,
		///<summary>
		/// Collection of <c>GsCodeApproval</c> as OneToMany for PgThesisSupervisorCommApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisSupervisorCommApprove>))]
		PgThesisSupervisorCommApproveCollection,
		///<summary>
		/// Collection of <c>GsCodeApproval</c> as OneToMany for GsCodeApprovalFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCodeApprovalFaculty>))]
		GsCodeApprovalFacultyCollection,
	}
	
	#endregion GsCodeApprovalChildEntityTypes
	
	#region GsCodeApprovalFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeApprovalColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeApproval"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeApprovalFilterBuilder : SqlFilterBuilder<GsCodeApprovalColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalFilterBuilder class.
		/// </summary>
		public GsCodeApprovalFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeApprovalFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeApprovalFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeApprovalFilterBuilder
	
	#region GsCodeApprovalParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeApprovalColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeApproval"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeApprovalParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeApprovalColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalParameterBuilder class.
		/// </summary>
		public GsCodeApprovalParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeApprovalParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeApprovalParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeApprovalParameterBuilder
	
	#region GsCodeApprovalSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeApprovalColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeApproval"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeApprovalSortBuilder : SqlSortBuilder<GsCodeApprovalColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalSqlSortBuilder class.
		/// </summary>
		public GsCodeApprovalSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeApprovalSortBuilder
	
} // end namespace
