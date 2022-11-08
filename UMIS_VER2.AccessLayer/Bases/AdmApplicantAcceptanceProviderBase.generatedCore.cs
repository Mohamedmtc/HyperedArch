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
	/// This class is the base class for any <see cref="AdmApplicantAcceptanceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmApplicantAcceptanceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmApplicantAcceptance, UMIS_VER2.BusinessLyer.AdmApplicantAcceptanceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmApplicantAcceptanceKey key)
		{
			return Delete(transactionManager, key.AdmApplicantacceptanceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admApplicantacceptanceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admApplicantacceptanceId)
		{
			return Delete(null, _admApplicantacceptanceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantacceptanceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admApplicantacceptanceId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_ACCEPTANCE_ADM_ACCEPTANCE_CATEGORY key.
		///		FK_ADM_APPLICANT_ACCEPTANCE_ADM_ACCEPTANCE_CATEGORY Description: 
		/// </summary>
		/// <param name="_admAcceptanceCategoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicantAcceptance objects.</returns>
		public TList<AdmApplicantAcceptance> GetByAdmAcceptanceCategoryId(System.Decimal _admAcceptanceCategoryId)
		{
			int count = -1;
			return GetByAdmAcceptanceCategoryId(_admAcceptanceCategoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_ACCEPTANCE_ADM_ACCEPTANCE_CATEGORY key.
		///		FK_ADM_APPLICANT_ACCEPTANCE_ADM_ACCEPTANCE_CATEGORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAcceptanceCategoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicantAcceptance objects.</returns>
		/// <remarks></remarks>
		public TList<AdmApplicantAcceptance> GetByAdmAcceptanceCategoryId(TransactionManager transactionManager, System.Decimal _admAcceptanceCategoryId)
		{
			int count = -1;
			return GetByAdmAcceptanceCategoryId(transactionManager, _admAcceptanceCategoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_ACCEPTANCE_ADM_ACCEPTANCE_CATEGORY key.
		///		FK_ADM_APPLICANT_ACCEPTANCE_ADM_ACCEPTANCE_CATEGORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAcceptanceCategoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicantAcceptance objects.</returns>
		public TList<AdmApplicantAcceptance> GetByAdmAcceptanceCategoryId(TransactionManager transactionManager, System.Decimal _admAcceptanceCategoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAcceptanceCategoryId(transactionManager, _admAcceptanceCategoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_ACCEPTANCE_ADM_ACCEPTANCE_CATEGORY key.
		///		fkAdmApplicantAcceptanceAdmAcceptanceCategory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAcceptanceCategoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicantAcceptance objects.</returns>
		public TList<AdmApplicantAcceptance> GetByAdmAcceptanceCategoryId(System.Decimal _admAcceptanceCategoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAcceptanceCategoryId(null, _admAcceptanceCategoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_ACCEPTANCE_ADM_ACCEPTANCE_CATEGORY key.
		///		fkAdmApplicantAcceptanceAdmAcceptanceCategory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAcceptanceCategoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicantAcceptance objects.</returns>
		public TList<AdmApplicantAcceptance> GetByAdmAcceptanceCategoryId(System.Decimal _admAcceptanceCategoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAcceptanceCategoryId(null, _admAcceptanceCategoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_ACCEPTANCE_ADM_ACCEPTANCE_CATEGORY key.
		///		FK_ADM_APPLICANT_ACCEPTANCE_ADM_ACCEPTANCE_CATEGORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAcceptanceCategoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicantAcceptance objects.</returns>
		public abstract TList<AdmApplicantAcceptance> GetByAdmAcceptanceCategoryId(TransactionManager transactionManager, System.Decimal _admAcceptanceCategoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_ACCEPTANCE_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APPLICANT_ACCEPTANCE_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicantAcceptance objects.</returns>
		public TList<AdmApplicantAcceptance> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_ACCEPTANCE_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APPLICANT_ACCEPTANCE_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicantAcceptance objects.</returns>
		/// <remarks></remarks>
		public TList<AdmApplicantAcceptance> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_ACCEPTANCE_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APPLICANT_ACCEPTANCE_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicantAcceptance objects.</returns>
		public TList<AdmApplicantAcceptance> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_ACCEPTANCE_ADM_APP_REG_HISTORY key.
		///		fkAdmApplicantAcceptanceAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicantAcceptance objects.</returns>
		public TList<AdmApplicantAcceptance> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_ACCEPTANCE_ADM_APP_REG_HISTORY key.
		///		fkAdmApplicantAcceptanceAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicantAcceptance objects.</returns>
		public TList<AdmApplicantAcceptance> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_ACCEPTANCE_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APPLICANT_ACCEPTANCE_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicantAcceptance objects.</returns>
		public abstract TList<AdmApplicantAcceptance> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmApplicantAcceptance Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmApplicantAcceptanceKey key, int start, int pageLength)
		{
			return GetByAdmApplicantacceptanceId(transactionManager, key.AdmApplicantacceptanceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key _dta_index_ADM_APPLICANT_ACCEPTANCE_6_1795132715__K4_K2_1_3 index.
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_admAcceptanceCategoryId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicantAcceptance&gt;"/> class.</returns>
		public TList<AdmApplicantAcceptance> GetByAdmAppRegHistoryIdAdmAcceptanceCategoryId(System.Decimal _admAppRegHistoryId, System.Decimal _admAcceptanceCategoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryIdAdmAcceptanceCategoryId(null,_admAppRegHistoryId, _admAcceptanceCategoryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the _dta_index_ADM_APPLICANT_ACCEPTANCE_6_1795132715__K4_K2_1_3 index.
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_admAcceptanceCategoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicantAcceptance&gt;"/> class.</returns>
		public TList<AdmApplicantAcceptance> GetByAdmAppRegHistoryIdAdmAcceptanceCategoryId(System.Decimal _admAppRegHistoryId, System.Decimal _admAcceptanceCategoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryIdAdmAcceptanceCategoryId(null, _admAppRegHistoryId, _admAcceptanceCategoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the _dta_index_ADM_APPLICANT_ACCEPTANCE_6_1795132715__K4_K2_1_3 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_admAcceptanceCategoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicantAcceptance&gt;"/> class.</returns>
		public TList<AdmApplicantAcceptance> GetByAdmAppRegHistoryIdAdmAcceptanceCategoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, System.Decimal _admAcceptanceCategoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryIdAdmAcceptanceCategoryId(transactionManager, _admAppRegHistoryId, _admAcceptanceCategoryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the _dta_index_ADM_APPLICANT_ACCEPTANCE_6_1795132715__K4_K2_1_3 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_admAcceptanceCategoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicantAcceptance&gt;"/> class.</returns>
		public TList<AdmApplicantAcceptance> GetByAdmAppRegHistoryIdAdmAcceptanceCategoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, System.Decimal _admAcceptanceCategoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryIdAdmAcceptanceCategoryId(transactionManager, _admAppRegHistoryId, _admAcceptanceCategoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the _dta_index_ADM_APPLICANT_ACCEPTANCE_6_1795132715__K4_K2_1_3 index.
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_admAcceptanceCategoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicantAcceptance&gt;"/> class.</returns>
		public TList<AdmApplicantAcceptance> GetByAdmAppRegHistoryIdAdmAcceptanceCategoryId(System.Decimal _admAppRegHistoryId, System.Decimal _admAcceptanceCategoryId, int start, int pageLength, out int count)
		{
			return GetByAdmAppRegHistoryIdAdmAcceptanceCategoryId(null, _admAppRegHistoryId, _admAcceptanceCategoryId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the _dta_index_ADM_APPLICANT_ACCEPTANCE_6_1795132715__K4_K2_1_3 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_admAcceptanceCategoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicantAcceptance&gt;"/> class.</returns>
		public abstract TList<AdmApplicantAcceptance> GetByAdmAppRegHistoryIdAdmAcceptanceCategoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, System.Decimal _admAcceptanceCategoryId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APPLICANT_ACCEPTANCE index.
		/// </summary>
		/// <param name="_admApplicantacceptanceId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmApplicantAcceptance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmApplicantAcceptance GetByAdmApplicantacceptanceId(System.Decimal _admApplicantacceptanceId)
		{
			int count = -1;
			return GetByAdmApplicantacceptanceId(null,_admApplicantacceptanceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APPLICANT_ACCEPTANCE index.
		/// </summary>
		/// <param name="_admApplicantacceptanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmApplicantAcceptance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmApplicantAcceptance GetByAdmApplicantacceptanceId(System.Decimal _admApplicantacceptanceId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantacceptanceId(null, _admApplicantacceptanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APPLICANT_ACCEPTANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantacceptanceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmApplicantAcceptance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmApplicantAcceptance GetByAdmApplicantacceptanceId(TransactionManager transactionManager, System.Decimal _admApplicantacceptanceId)
		{
			int count = -1;
			return GetByAdmApplicantacceptanceId(transactionManager, _admApplicantacceptanceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APPLICANT_ACCEPTANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantacceptanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmApplicantAcceptance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmApplicantAcceptance GetByAdmApplicantacceptanceId(TransactionManager transactionManager, System.Decimal _admApplicantacceptanceId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantacceptanceId(transactionManager, _admApplicantacceptanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APPLICANT_ACCEPTANCE index.
		/// </summary>
		/// <param name="_admApplicantacceptanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmApplicantAcceptance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmApplicantAcceptance GetByAdmApplicantacceptanceId(System.Decimal _admApplicantacceptanceId, int start, int pageLength, out int count)
		{
			return GetByAdmApplicantacceptanceId(null, _admApplicantacceptanceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APPLICANT_ACCEPTANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantacceptanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmApplicantAcceptance"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmApplicantAcceptance GetByAdmApplicantacceptanceId(TransactionManager transactionManager, System.Decimal _admApplicantacceptanceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmApplicantAcceptance&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmApplicantAcceptance&gt;"/></returns>
		public static TList<AdmApplicantAcceptance> Fill(IDataReader reader, TList<AdmApplicantAcceptance> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmApplicantAcceptance c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmApplicantAcceptance")
					.Append("|").Append((System.Decimal)reader["ADM_APPLICANTACCEPTANCE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmApplicantAcceptance>(
					key.ToString(), // EntityTrackingKey
					"AdmApplicantAcceptance",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmApplicantAcceptance();
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
					c.AdmApplicantacceptanceId = (System.Decimal)reader["ADM_APPLICANTACCEPTANCE_ID"];
					c.OriginalAdmApplicantacceptanceId = c.AdmApplicantacceptanceId;
					c.AdmAcceptanceCategoryId = (System.Decimal)reader["ADM_ACCEPTANCE_CATEGORY_ID"];
					c.AcceptanceFlg = Convert.IsDBNull(reader["ACCEPTANCE_FLG"]) ? null : (System.Decimal?)reader["ACCEPTANCE_FLG"];
					c.AdmAppRegHistoryId = (System.Decimal)reader["ADM_APP_REG_HISTORY_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmApplicantAcceptance"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmApplicantAcceptance"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmApplicantAcceptance entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmApplicantacceptanceId = (System.Decimal)reader[((int)AdmApplicantAcceptanceColumn.AdmApplicantacceptanceId - 1)];
			entity.OriginalAdmApplicantacceptanceId = (System.Decimal)reader["ADM_APPLICANTACCEPTANCE_ID"];
			entity.AdmAcceptanceCategoryId = (System.Decimal)reader[((int)AdmApplicantAcceptanceColumn.AdmAcceptanceCategoryId - 1)];
			entity.AcceptanceFlg = (reader.IsDBNull(((int)AdmApplicantAcceptanceColumn.AcceptanceFlg - 1)))?null:(System.Decimal?)reader[((int)AdmApplicantAcceptanceColumn.AcceptanceFlg - 1)];
			entity.AdmAppRegHistoryId = (System.Decimal)reader[((int)AdmApplicantAcceptanceColumn.AdmAppRegHistoryId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmApplicantAcceptanceColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmApplicantAcceptanceColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmApplicantAcceptance"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmApplicantAcceptance"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmApplicantAcceptance entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmApplicantacceptanceId = (System.Decimal)dataRow["ADM_APPLICANTACCEPTANCE_ID"];
			entity.OriginalAdmApplicantacceptanceId = (System.Decimal)dataRow["ADM_APPLICANTACCEPTANCE_ID"];
			entity.AdmAcceptanceCategoryId = (System.Decimal)dataRow["ADM_ACCEPTANCE_CATEGORY_ID"];
			entity.AcceptanceFlg = Convert.IsDBNull(dataRow["ACCEPTANCE_FLG"]) ? null : (System.Decimal?)dataRow["ACCEPTANCE_FLG"];
			entity.AdmAppRegHistoryId = (System.Decimal)dataRow["ADM_APP_REG_HISTORY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmApplicantAcceptance"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmApplicantAcceptance Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmApplicantAcceptance entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAcceptanceCategoryIdSource	
			if (CanDeepLoad(entity, "AdmAcceptanceCategory|AdmAcceptanceCategoryIdSource", deepLoadType, innerList) 
				&& entity.AdmAcceptanceCategoryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmAcceptanceCategoryId;
				AdmAcceptanceCategory tmpEntity = EntityManager.LocateEntity<AdmAcceptanceCategory>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAcceptanceCategory), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAcceptanceCategoryIdSource = tmpEntity;
				else
					entity.AdmAcceptanceCategoryIdSource = DataRepository.AdmAcceptanceCategoryProvider.GetByAdmAcceptanceCategoryId(transactionManager, entity.AdmAcceptanceCategoryId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAcceptanceCategoryIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAcceptanceCategoryIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAcceptanceCategoryProvider.DeepLoad(transactionManager, entity.AdmAcceptanceCategoryIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAcceptanceCategoryIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmApplicantAcceptance object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmApplicantAcceptance instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmApplicantAcceptance Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmApplicantAcceptance entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAcceptanceCategoryIdSource
			if (CanDeepSave(entity, "AdmAcceptanceCategory|AdmAcceptanceCategoryIdSource", deepSaveType, innerList) 
				&& entity.AdmAcceptanceCategoryIdSource != null)
			{
				DataRepository.AdmAcceptanceCategoryProvider.Save(transactionManager, entity.AdmAcceptanceCategoryIdSource);
				entity.AdmAcceptanceCategoryId = entity.AdmAcceptanceCategoryIdSource.AdmAcceptanceCategoryId;
			}
			#endregion 
			
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
	
	#region AdmApplicantAcceptanceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmApplicantAcceptance</c>
	///</summary>
	public enum AdmApplicantAcceptanceChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAcceptanceCategory</c> at AdmAcceptanceCategoryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAcceptanceCategory))]
		AdmAcceptanceCategory,
		
		///<summary>
		/// Composite Property for <c>AdmAppRegHistory</c> at AdmAppRegHistoryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppRegHistory))]
		AdmAppRegHistory,
	}
	
	#endregion AdmApplicantAcceptanceChildEntityTypes
	
	#region AdmApplicantAcceptanceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmApplicantAcceptanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmApplicantAcceptance"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmApplicantAcceptanceFilterBuilder : SqlFilterBuilder<AdmApplicantAcceptanceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmApplicantAcceptanceFilterBuilder class.
		/// </summary>
		public AdmApplicantAcceptanceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmApplicantAcceptanceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmApplicantAcceptanceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmApplicantAcceptanceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmApplicantAcceptanceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmApplicantAcceptanceFilterBuilder
	
	#region AdmApplicantAcceptanceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmApplicantAcceptanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmApplicantAcceptance"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmApplicantAcceptanceParameterBuilder : ParameterizedSqlFilterBuilder<AdmApplicantAcceptanceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmApplicantAcceptanceParameterBuilder class.
		/// </summary>
		public AdmApplicantAcceptanceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmApplicantAcceptanceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmApplicantAcceptanceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmApplicantAcceptanceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmApplicantAcceptanceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmApplicantAcceptanceParameterBuilder
	
	#region AdmApplicantAcceptanceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmApplicantAcceptanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmApplicantAcceptance"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmApplicantAcceptanceSortBuilder : SqlSortBuilder<AdmApplicantAcceptanceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmApplicantAcceptanceSqlSortBuilder class.
		/// </summary>
		public AdmApplicantAcceptanceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmApplicantAcceptanceSortBuilder
	
} // end namespace
