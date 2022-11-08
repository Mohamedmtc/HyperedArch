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
	/// This class is the base class for any <see cref="AdmAppGuardianProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppGuardianProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppGuardian, UMIS_VER2.BusinessLyer.AdmAppGuardianKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppGuardianKey key)
		{
			return Delete(transactionManager, key.AdmAppGuardianId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppGuardianId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppGuardianId)
		{
			return Delete(null, _admAppGuardianId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppGuardianId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppGuardianId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_GUARDIAN_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_GUARDIAN_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppGuardian objects.</returns>
		public TList<AdmAppGuardian> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_GUARDIAN_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_GUARDIAN_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppGuardian objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppGuardian> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_GUARDIAN_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_GUARDIAN_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppGuardian objects.</returns>
		public TList<AdmAppGuardian> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_GUARDIAN_ADM_APP_REG_HISTORY key.
		///		fkAdmAppGuardianAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppGuardian objects.</returns>
		public TList<AdmAppGuardian> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_GUARDIAN_ADM_APP_REG_HISTORY key.
		///		fkAdmAppGuardianAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppGuardian objects.</returns>
		public TList<AdmAppGuardian> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_GUARDIAN_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_GUARDIAN_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppGuardian objects.</returns>
		public abstract TList<AdmAppGuardian> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppGuardian Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppGuardianKey key, int start, int pageLength)
		{
			return GetByAdmAppGuardianId(transactionManager, key.AdmAppGuardianId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppGuardian&gt;"/> class.</returns>
		public TList<AdmAppGuardian> GetByAdmApplicantId(System.Decimal _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(null,_admApplicantId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppGuardian&gt;"/> class.</returns>
		public TList<AdmAppGuardian> GetByAdmApplicantId(System.Decimal _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppGuardian&gt;"/> class.</returns>
		public TList<AdmAppGuardian> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppGuardian&gt;"/> class.</returns>
		public TList<AdmAppGuardian> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppGuardian&gt;"/> class.</returns>
		public TList<AdmAppGuardian> GetByAdmApplicantId(System.Decimal _admApplicantId, int start, int pageLength, out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppGuardian&gt;"/> class.</returns>
		public abstract TList<AdmAppGuardian> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_RELATION_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeRelationId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppGuardian&gt;"/> class.</returns>
		public TList<AdmAppGuardian> GetByGsCodeRelationId(System.Decimal _gsCodeRelationId)
		{
			int count = -1;
			return GetByGsCodeRelationId(null,_gsCodeRelationId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_RELATION_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeRelationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppGuardian&gt;"/> class.</returns>
		public TList<AdmAppGuardian> GetByGsCodeRelationId(System.Decimal _gsCodeRelationId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeRelationId(null, _gsCodeRelationId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_RELATION_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRelationId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppGuardian&gt;"/> class.</returns>
		public TList<AdmAppGuardian> GetByGsCodeRelationId(TransactionManager transactionManager, System.Decimal _gsCodeRelationId)
		{
			int count = -1;
			return GetByGsCodeRelationId(transactionManager, _gsCodeRelationId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_RELATION_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRelationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppGuardian&gt;"/> class.</returns>
		public TList<AdmAppGuardian> GetByGsCodeRelationId(TransactionManager transactionManager, System.Decimal _gsCodeRelationId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeRelationId(transactionManager, _gsCodeRelationId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_RELATION_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeRelationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppGuardian&gt;"/> class.</returns>
		public TList<AdmAppGuardian> GetByGsCodeRelationId(System.Decimal _gsCodeRelationId, int start, int pageLength, out int count)
		{
			return GetByGsCodeRelationId(null, _gsCodeRelationId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_RELATION_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRelationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppGuardian&gt;"/> class.</returns>
		public abstract TList<AdmAppGuardian> GetByGsCodeRelationId(TransactionManager transactionManager, System.Decimal _gsCodeRelationId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_GUARDIAN index.
		/// </summary>
		/// <param name="_admAppGuardianId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppGuardian"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppGuardian GetByAdmAppGuardianId(System.Decimal _admAppGuardianId)
		{
			int count = -1;
			return GetByAdmAppGuardianId(null,_admAppGuardianId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_GUARDIAN index.
		/// </summary>
		/// <param name="_admAppGuardianId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppGuardian"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppGuardian GetByAdmAppGuardianId(System.Decimal _admAppGuardianId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppGuardianId(null, _admAppGuardianId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_GUARDIAN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppGuardianId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppGuardian"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppGuardian GetByAdmAppGuardianId(TransactionManager transactionManager, System.Decimal _admAppGuardianId)
		{
			int count = -1;
			return GetByAdmAppGuardianId(transactionManager, _admAppGuardianId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_GUARDIAN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppGuardianId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppGuardian"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppGuardian GetByAdmAppGuardianId(TransactionManager transactionManager, System.Decimal _admAppGuardianId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppGuardianId(transactionManager, _admAppGuardianId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_GUARDIAN index.
		/// </summary>
		/// <param name="_admAppGuardianId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppGuardian"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppGuardian GetByAdmAppGuardianId(System.Decimal _admAppGuardianId, int start, int pageLength, out int count)
		{
			return GetByAdmAppGuardianId(null, _admAppGuardianId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_GUARDIAN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppGuardianId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppGuardian"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppGuardian GetByAdmAppGuardianId(TransactionManager transactionManager, System.Decimal _admAppGuardianId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppGuardian&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppGuardian&gt;"/></returns>
		public static TList<AdmAppGuardian> Fill(IDataReader reader, TList<AdmAppGuardian> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppGuardian c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppGuardian")
					.Append("|").Append((System.Decimal)reader["ADM_APP_GUARDIAN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppGuardian>(
					key.ToString(), // EntityTrackingKey
					"AdmAppGuardian",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppGuardian();
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
					c.AdmAppGuardianId = (System.Decimal)reader["ADM_APP_GUARDIAN_ID"];
					c.OriginalAdmAppGuardianId = c.AdmAppGuardianId;
					c.AdmApplicantId = (System.Decimal)reader["ADM_APPLICANT_ID"];
					c.GsCodeRelationId = (System.Decimal)reader["GS_CODE_RELATION_ID"];
					c.FullName = Convert.IsDBNull(reader["FULL_NAME"]) ? null : (System.String)reader["FULL_NAME"];
					c.JobTitle = Convert.IsDBNull(reader["JOB_TITLE"]) ? null : (System.String)reader["JOB_TITLE"];
					c.PermAddr = Convert.IsDBNull(reader["PERM_ADDR"]) ? null : (System.String)reader["PERM_ADDR"];
					c.EMail = Convert.IsDBNull(reader["E_MAIL"]) ? null : (System.String)reader["E_MAIL"];
					c.PhoneNum = Convert.IsDBNull(reader["PHONE_NUM"]) ? null : (System.String)reader["PHONE_NUM"];
					c.MobileNum = Convert.IsDBNull(reader["MOBILE_NUM"]) ? null : (System.String)reader["MOBILE_NUM"];
					c.MonthIncome = Convert.IsDBNull(reader["MONTH_INCOME"]) ? null : (System.Decimal?)reader["MONTH_INCOME"];
					c.StaffFlg = (System.Decimal)reader["STAFF_FLG"];
					c.MainFlg = (System.Decimal)reader["MAIN_FLG"];
					c.AdmAppRegHistoryId = Convert.IsDBNull(reader["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)reader["ADM_APP_REG_HISTORY_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppGuardian"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppGuardian"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppGuardian entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppGuardianId = (System.Decimal)reader[((int)AdmAppGuardianColumn.AdmAppGuardianId - 1)];
			entity.OriginalAdmAppGuardianId = (System.Decimal)reader["ADM_APP_GUARDIAN_ID"];
			entity.AdmApplicantId = (System.Decimal)reader[((int)AdmAppGuardianColumn.AdmApplicantId - 1)];
			entity.GsCodeRelationId = (System.Decimal)reader[((int)AdmAppGuardianColumn.GsCodeRelationId - 1)];
			entity.FullName = (reader.IsDBNull(((int)AdmAppGuardianColumn.FullName - 1)))?null:(System.String)reader[((int)AdmAppGuardianColumn.FullName - 1)];
			entity.JobTitle = (reader.IsDBNull(((int)AdmAppGuardianColumn.JobTitle - 1)))?null:(System.String)reader[((int)AdmAppGuardianColumn.JobTitle - 1)];
			entity.PermAddr = (reader.IsDBNull(((int)AdmAppGuardianColumn.PermAddr - 1)))?null:(System.String)reader[((int)AdmAppGuardianColumn.PermAddr - 1)];
			entity.EMail = (reader.IsDBNull(((int)AdmAppGuardianColumn.EMail - 1)))?null:(System.String)reader[((int)AdmAppGuardianColumn.EMail - 1)];
			entity.PhoneNum = (reader.IsDBNull(((int)AdmAppGuardianColumn.PhoneNum - 1)))?null:(System.String)reader[((int)AdmAppGuardianColumn.PhoneNum - 1)];
			entity.MobileNum = (reader.IsDBNull(((int)AdmAppGuardianColumn.MobileNum - 1)))?null:(System.String)reader[((int)AdmAppGuardianColumn.MobileNum - 1)];
			entity.MonthIncome = (reader.IsDBNull(((int)AdmAppGuardianColumn.MonthIncome - 1)))?null:(System.Decimal?)reader[((int)AdmAppGuardianColumn.MonthIncome - 1)];
			entity.StaffFlg = (System.Decimal)reader[((int)AdmAppGuardianColumn.StaffFlg - 1)];
			entity.MainFlg = (System.Decimal)reader[((int)AdmAppGuardianColumn.MainFlg - 1)];
			entity.AdmAppRegHistoryId = (reader.IsDBNull(((int)AdmAppGuardianColumn.AdmAppRegHistoryId - 1)))?null:(System.Decimal?)reader[((int)AdmAppGuardianColumn.AdmAppRegHistoryId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmAppGuardianColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmAppGuardianColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmAppGuardianColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppGuardianColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppGuardian"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppGuardian"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppGuardian entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppGuardianId = (System.Decimal)dataRow["ADM_APP_GUARDIAN_ID"];
			entity.OriginalAdmAppGuardianId = (System.Decimal)dataRow["ADM_APP_GUARDIAN_ID"];
			entity.AdmApplicantId = (System.Decimal)dataRow["ADM_APPLICANT_ID"];
			entity.GsCodeRelationId = (System.Decimal)dataRow["GS_CODE_RELATION_ID"];
			entity.FullName = Convert.IsDBNull(dataRow["FULL_NAME"]) ? null : (System.String)dataRow["FULL_NAME"];
			entity.JobTitle = Convert.IsDBNull(dataRow["JOB_TITLE"]) ? null : (System.String)dataRow["JOB_TITLE"];
			entity.PermAddr = Convert.IsDBNull(dataRow["PERM_ADDR"]) ? null : (System.String)dataRow["PERM_ADDR"];
			entity.EMail = Convert.IsDBNull(dataRow["E_MAIL"]) ? null : (System.String)dataRow["E_MAIL"];
			entity.PhoneNum = Convert.IsDBNull(dataRow["PHONE_NUM"]) ? null : (System.String)dataRow["PHONE_NUM"];
			entity.MobileNum = Convert.IsDBNull(dataRow["MOBILE_NUM"]) ? null : (System.String)dataRow["MOBILE_NUM"];
			entity.MonthIncome = Convert.IsDBNull(dataRow["MONTH_INCOME"]) ? null : (System.Decimal?)dataRow["MONTH_INCOME"];
			entity.StaffFlg = (System.Decimal)dataRow["STAFF_FLG"];
			entity.MainFlg = (System.Decimal)dataRow["MAIN_FLG"];
			entity.AdmAppRegHistoryId = Convert.IsDBNull(dataRow["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_REG_HISTORY_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppGuardian"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppGuardian Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppGuardian entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppRegHistoryIdSource	
			if (CanDeepLoad(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepLoadType, innerList) 
				&& entity.AdmAppRegHistoryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmAppRegHistoryId ?? 0.0m);
				AdmAppRegHistory tmpEntity = EntityManager.LocateEntity<AdmAppRegHistory>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppRegHistory), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppRegHistoryIdSource = tmpEntity;
				else
					entity.AdmAppRegHistoryIdSource = DataRepository.AdmAppRegHistoryProvider.GetByAdmAppRegHistoryId(transactionManager, (entity.AdmAppRegHistoryId ?? 0.0m));		
				
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

			#region AdmApplicantIdSource	
			if (CanDeepLoad(entity, "AdmApplicant|AdmApplicantIdSource", deepLoadType, innerList) 
				&& entity.AdmApplicantIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmApplicantId;
				AdmApplicant tmpEntity = EntityManager.LocateEntity<AdmApplicant>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmApplicant), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmApplicantIdSource = tmpEntity;
				else
					entity.AdmApplicantIdSource = DataRepository.AdmApplicantProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmApplicantIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmApplicantIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmApplicantProvider.DeepLoad(transactionManager, entity.AdmApplicantIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmApplicantIdSource

			#region GsCodeRelationIdSource	
			if (CanDeepLoad(entity, "GsCodeKinship|GsCodeRelationIdSource", deepLoadType, innerList) 
				&& entity.GsCodeRelationIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeRelationId;
				GsCodeKinship tmpEntity = EntityManager.LocateEntity<GsCodeKinship>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeKinship), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeRelationIdSource = tmpEntity;
				else
					entity.GsCodeRelationIdSource = DataRepository.GsCodeKinshipProvider.GetByGsCodeRelationId(transactionManager, entity.GsCodeRelationId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeRelationIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeRelationIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeKinshipProvider.DeepLoad(transactionManager, entity.GsCodeRelationIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeRelationIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppGuardian object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppGuardian instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppGuardian Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppGuardian entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region AdmApplicantIdSource
			if (CanDeepSave(entity, "AdmApplicant|AdmApplicantIdSource", deepSaveType, innerList) 
				&& entity.AdmApplicantIdSource != null)
			{
				DataRepository.AdmApplicantProvider.Save(transactionManager, entity.AdmApplicantIdSource);
				entity.AdmApplicantId = entity.AdmApplicantIdSource.AdmApplicantId;
			}
			#endregion 
			
			#region GsCodeRelationIdSource
			if (CanDeepSave(entity, "GsCodeKinship|GsCodeRelationIdSource", deepSaveType, innerList) 
				&& entity.GsCodeRelationIdSource != null)
			{
				DataRepository.GsCodeKinshipProvider.Save(transactionManager, entity.GsCodeRelationIdSource);
				entity.GsCodeRelationId = entity.GsCodeRelationIdSource.GsCodeRelationId;
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
	
	#region AdmAppGuardianChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppGuardian</c>
	///</summary>
	public enum AdmAppGuardianChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppRegHistory</c> at AdmAppRegHistoryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppRegHistory))]
		AdmAppRegHistory,
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>GsCodeKinship</c> at GsCodeRelationIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeKinship))]
		GsCodeKinship,
	}
	
	#endregion AdmAppGuardianChildEntityTypes
	
	#region AdmAppGuardianFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppGuardianColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppGuardian"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppGuardianFilterBuilder : SqlFilterBuilder<AdmAppGuardianColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppGuardianFilterBuilder class.
		/// </summary>
		public AdmAppGuardianFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppGuardianFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppGuardianFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppGuardianFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppGuardianFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppGuardianFilterBuilder
	
	#region AdmAppGuardianParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppGuardianColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppGuardian"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppGuardianParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppGuardianColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppGuardianParameterBuilder class.
		/// </summary>
		public AdmAppGuardianParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppGuardianParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppGuardianParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppGuardianParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppGuardianParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppGuardianParameterBuilder
	
	#region AdmAppGuardianSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppGuardianColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppGuardian"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppGuardianSortBuilder : SqlSortBuilder<AdmAppGuardianColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppGuardianSqlSortBuilder class.
		/// </summary>
		public AdmAppGuardianSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppGuardianSortBuilder
	
} // end namespace
