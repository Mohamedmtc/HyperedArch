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
	/// This class is the base class for any <see cref="AdmTransAcceptanceCategoryProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmTransAcceptanceCategoryProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory, UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategoryKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategoryKey key)
		{
			return Delete(transactionManager, key.AdmTransAcceptanceCategoryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admTransAcceptanceCategoryId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admTransAcceptanceCategoryId)
		{
			return Delete(null, _admTransAcceptanceCategoryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTransAcceptanceCategoryId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admTransAcceptanceCategoryId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANS_ACCEPTANCE_CATEGORY_ADM_CODE_TRANSFER_TYPE key.
		///		FK_ADM_TRANS_ACCEPTANCE_CATEGORY_ADM_CODE_TRANSFER_TYPE Description: 
		/// </summary>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory objects.</returns>
		public TList<AdmTransAcceptanceCategory> GetByAdmCodeTransferTypeId(System.Decimal _admCodeTransferTypeId)
		{
			int count = -1;
			return GetByAdmCodeTransferTypeId(_admCodeTransferTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANS_ACCEPTANCE_CATEGORY_ADM_CODE_TRANSFER_TYPE key.
		///		FK_ADM_TRANS_ACCEPTANCE_CATEGORY_ADM_CODE_TRANSFER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmTransAcceptanceCategory> GetByAdmCodeTransferTypeId(TransactionManager transactionManager, System.Decimal _admCodeTransferTypeId)
		{
			int count = -1;
			return GetByAdmCodeTransferTypeId(transactionManager, _admCodeTransferTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANS_ACCEPTANCE_CATEGORY_ADM_CODE_TRANSFER_TYPE key.
		///		FK_ADM_TRANS_ACCEPTANCE_CATEGORY_ADM_CODE_TRANSFER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory objects.</returns>
		public TList<AdmTransAcceptanceCategory> GetByAdmCodeTransferTypeId(TransactionManager transactionManager, System.Decimal _admCodeTransferTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCodeTransferTypeId(transactionManager, _admCodeTransferTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANS_ACCEPTANCE_CATEGORY_ADM_CODE_TRANSFER_TYPE key.
		///		fkAdmTransAcceptanceCategoryAdmCodeTransferType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory objects.</returns>
		public TList<AdmTransAcceptanceCategory> GetByAdmCodeTransferTypeId(System.Decimal _admCodeTransferTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCodeTransferTypeId(null, _admCodeTransferTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANS_ACCEPTANCE_CATEGORY_ADM_CODE_TRANSFER_TYPE key.
		///		fkAdmTransAcceptanceCategoryAdmCodeTransferType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory objects.</returns>
		public TList<AdmTransAcceptanceCategory> GetByAdmCodeTransferTypeId(System.Decimal _admCodeTransferTypeId, int start, int pageLength,out int count)
		{
			return GetByAdmCodeTransferTypeId(null, _admCodeTransferTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANS_ACCEPTANCE_CATEGORY_ADM_CODE_TRANSFER_TYPE key.
		///		FK_ADM_TRANS_ACCEPTANCE_CATEGORY_ADM_CODE_TRANSFER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory objects.</returns>
		public abstract TList<AdmTransAcceptanceCategory> GetByAdmCodeTransferTypeId(TransactionManager transactionManager, System.Decimal _admCodeTransferTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE key.
		///		FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory objects.</returns>
		public TList<AdmTransAcceptanceCategory> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE key.
		///		FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmTransAcceptanceCategory> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE key.
		///		FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory objects.</returns>
		public TList<AdmTransAcceptanceCategory> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE key.
		///		fkAdmTransAcceptanceCategoryAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory objects.</returns>
		public TList<AdmTransAcceptanceCategory> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE key.
		///		fkAdmTransAcceptanceCategoryAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory objects.</returns>
		public TList<AdmTransAcceptanceCategory> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE key.
		///		FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory objects.</returns>
		public abstract TList<AdmTransAcceptanceCategory> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory objects.</returns>
		public TList<AdmTransAcceptanceCategory> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmTransAcceptanceCategory> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory objects.</returns>
		public TList<AdmTransAcceptanceCategory> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS key.
		///		fkAdmTransAcceptanceCategoryAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory objects.</returns>
		public TList<AdmTransAcceptanceCategory> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS key.
		///		fkAdmTransAcceptanceCategoryAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory objects.</returns>
		public TList<AdmTransAcceptanceCategory> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_TRANS_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory objects.</returns>
		public abstract TList<AdmTransAcceptanceCategory> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategoryKey key, int start, int pageLength)
		{
			return GetByAdmTransAcceptanceCategoryId(transactionManager, key.AdmTransAcceptanceCategoryId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_TRANS_ACCEPTANCE_CATEGORY index.
		/// </summary>
		/// <param name="_admTransAcceptanceCategoryId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory GetByAdmTransAcceptanceCategoryId(System.Decimal _admTransAcceptanceCategoryId)
		{
			int count = -1;
			return GetByAdmTransAcceptanceCategoryId(null,_admTransAcceptanceCategoryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_TRANS_ACCEPTANCE_CATEGORY index.
		/// </summary>
		/// <param name="_admTransAcceptanceCategoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory GetByAdmTransAcceptanceCategoryId(System.Decimal _admTransAcceptanceCategoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmTransAcceptanceCategoryId(null, _admTransAcceptanceCategoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_TRANS_ACCEPTANCE_CATEGORY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTransAcceptanceCategoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory GetByAdmTransAcceptanceCategoryId(TransactionManager transactionManager, System.Decimal _admTransAcceptanceCategoryId)
		{
			int count = -1;
			return GetByAdmTransAcceptanceCategoryId(transactionManager, _admTransAcceptanceCategoryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_TRANS_ACCEPTANCE_CATEGORY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTransAcceptanceCategoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory GetByAdmTransAcceptanceCategoryId(TransactionManager transactionManager, System.Decimal _admTransAcceptanceCategoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmTransAcceptanceCategoryId(transactionManager, _admTransAcceptanceCategoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_TRANS_ACCEPTANCE_CATEGORY index.
		/// </summary>
		/// <param name="_admTransAcceptanceCategoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory GetByAdmTransAcceptanceCategoryId(System.Decimal _admTransAcceptanceCategoryId, int start, int pageLength, out int count)
		{
			return GetByAdmTransAcceptanceCategoryId(null, _admTransAcceptanceCategoryId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_TRANS_ACCEPTANCE_CATEGORY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTransAcceptanceCategoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory GetByAdmTransAcceptanceCategoryId(TransactionManager transactionManager, System.Decimal _admTransAcceptanceCategoryId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmTransAcceptanceCategory&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmTransAcceptanceCategory&gt;"/></returns>
		public static TList<AdmTransAcceptanceCategory> Fill(IDataReader reader, TList<AdmTransAcceptanceCategory> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmTransAcceptanceCategory")
					.Append("|").Append((System.Decimal)reader["ADM_TRANS_ACCEPTANCE_CATEGORY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmTransAcceptanceCategory>(
					key.ToString(), // EntityTrackingKey
					"AdmTransAcceptanceCategory",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory();
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
					c.AdmTransAcceptanceCategoryId = (System.Decimal)reader["ADM_TRANS_ACCEPTANCE_CATEGORY_ID"];
					c.OriginalAdmTransAcceptanceCategoryId = c.AdmTransAcceptanceCategoryId;
					c.CategoryNameEn = (System.String)reader["CATEGORY_NAME_EN"];
					c.CategoryNameAr = (System.String)reader["CATEGORY_NAME_AR"];
					c.CategoryType = (System.Decimal)reader["CATEGORY_TYPE"];
					c.CategoryValue = (System.Decimal)reader["CATEGORY_VALUE"];
					c.AbbreviationEn = (System.String)reader["ABBREVIATION_EN"];
					c.AbbreviationAr = (System.String)reader["ABBREVIATION_AR"];
					c.RegExpiration = Convert.IsDBNull(reader["REG_EXPIRATION"]) ? null : (System.String)reader["REG_EXPIRATION"];
					c.AsCodeDegreeClassId = (System.Decimal)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.AsCodeDegreeId = (System.Decimal)reader["AS_CODE_DEGREE_ID"];
					c.AdmCodeTransferTypeId = (System.Decimal)reader["ADM_CODE_TRANSFER_TYPE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmTransAcceptanceCategoryId = (System.Decimal)reader[((int)AdmTransAcceptanceCategoryColumn.AdmTransAcceptanceCategoryId - 1)];
			entity.OriginalAdmTransAcceptanceCategoryId = (System.Decimal)reader["ADM_TRANS_ACCEPTANCE_CATEGORY_ID"];
			entity.CategoryNameEn = (System.String)reader[((int)AdmTransAcceptanceCategoryColumn.CategoryNameEn - 1)];
			entity.CategoryNameAr = (System.String)reader[((int)AdmTransAcceptanceCategoryColumn.CategoryNameAr - 1)];
			entity.CategoryType = (System.Decimal)reader[((int)AdmTransAcceptanceCategoryColumn.CategoryType - 1)];
			entity.CategoryValue = (System.Decimal)reader[((int)AdmTransAcceptanceCategoryColumn.CategoryValue - 1)];
			entity.AbbreviationEn = (System.String)reader[((int)AdmTransAcceptanceCategoryColumn.AbbreviationEn - 1)];
			entity.AbbreviationAr = (System.String)reader[((int)AdmTransAcceptanceCategoryColumn.AbbreviationAr - 1)];
			entity.RegExpiration = (reader.IsDBNull(((int)AdmTransAcceptanceCategoryColumn.RegExpiration - 1)))?null:(System.String)reader[((int)AdmTransAcceptanceCategoryColumn.RegExpiration - 1)];
			entity.AsCodeDegreeClassId = (System.Decimal)reader[((int)AdmTransAcceptanceCategoryColumn.AsCodeDegreeClassId - 1)];
			entity.AsCodeDegreeId = (System.Decimal)reader[((int)AdmTransAcceptanceCategoryColumn.AsCodeDegreeId - 1)];
			entity.AdmCodeTransferTypeId = (System.Decimal)reader[((int)AdmTransAcceptanceCategoryColumn.AdmCodeTransferTypeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmTransAcceptanceCategoryId = (System.Decimal)dataRow["ADM_TRANS_ACCEPTANCE_CATEGORY_ID"];
			entity.OriginalAdmTransAcceptanceCategoryId = (System.Decimal)dataRow["ADM_TRANS_ACCEPTANCE_CATEGORY_ID"];
			entity.CategoryNameEn = (System.String)dataRow["CATEGORY_NAME_EN"];
			entity.CategoryNameAr = (System.String)dataRow["CATEGORY_NAME_AR"];
			entity.CategoryType = (System.Decimal)dataRow["CATEGORY_TYPE"];
			entity.CategoryValue = (System.Decimal)dataRow["CATEGORY_VALUE"];
			entity.AbbreviationEn = (System.String)dataRow["ABBREVIATION_EN"];
			entity.AbbreviationAr = (System.String)dataRow["ABBREVIATION_AR"];
			entity.RegExpiration = Convert.IsDBNull(dataRow["REG_EXPIRATION"]) ? null : (System.String)dataRow["REG_EXPIRATION"];
			entity.AsCodeDegreeClassId = (System.Decimal)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.AsCodeDegreeId = (System.Decimal)dataRow["AS_CODE_DEGREE_ID"];
			entity.AdmCodeTransferTypeId = (System.Decimal)dataRow["ADM_CODE_TRANSFER_TYPE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmCodeTransferTypeIdSource	
			if (CanDeepLoad(entity, "AdmCodeTransferType|AdmCodeTransferTypeIdSource", deepLoadType, innerList) 
				&& entity.AdmCodeTransferTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmCodeTransferTypeId;
				AdmCodeTransferType tmpEntity = EntityManager.LocateEntity<AdmCodeTransferType>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCodeTransferType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCodeTransferTypeIdSource = tmpEntity;
				else
					entity.AdmCodeTransferTypeIdSource = DataRepository.AdmCodeTransferTypeProvider.GetByAdmCodeTransferTypeId(transactionManager, entity.AdmCodeTransferTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCodeTransferTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCodeTransferTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCodeTransferTypeProvider.DeepLoad(transactionManager, entity.AdmCodeTransferTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCodeTransferTypeIdSource

			#region AsCodeDegreeIdSource	
			if (CanDeepLoad(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsCodeDegreeId;
				AsCodeDegree tmpEntity = EntityManager.LocateEntity<AsCodeDegree>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeIdSource = tmpEntity;
				else
					entity.AsCodeDegreeIdSource = DataRepository.AsCodeDegreeProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeProvider.DeepLoad(transactionManager, entity.AsCodeDegreeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeIdSource

			#region AsCodeDegreeClassIdSource	
			if (CanDeepLoad(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeClassIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsCodeDegreeClassId;
				AsCodeDegreeClass tmpEntity = EntityManager.LocateEntity<AsCodeDegreeClass>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegreeClass), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeClassIdSource = tmpEntity;
				else
					entity.AsCodeDegreeClassIdSource = DataRepository.AsCodeDegreeClassProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeClassIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeClassIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeClassProvider.DeepLoad(transactionManager, entity.AsCodeDegreeClassIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeClassIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmTransAcceptanceCategoryId methods when available
			
			#region AdmTransferAcceptanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmTransferAcceptance>|AdmTransferAcceptanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmTransferAcceptanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmTransferAcceptanceCollection = DataRepository.AdmTransferAcceptanceProvider.GetByAdmTransAcceptanceCategoryId(transactionManager, entity.AdmTransAcceptanceCategoryId);

				if (deep && entity.AdmTransferAcceptanceCollection.Count > 0)
				{
					deepHandles.Add("AdmTransferAcceptanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmTransferAcceptance>) DataRepository.AdmTransferAcceptanceProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmTransferAcceptanceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmIntTransferAcceptanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmIntTransferAcceptance>|AdmIntTransferAcceptanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmIntTransferAcceptanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmIntTransferAcceptanceCollection = DataRepository.AdmIntTransferAcceptanceProvider.GetByAdmTransAcceptanceCategoryId(transactionManager, entity.AdmTransAcceptanceCategoryId);

				if (deep && entity.AdmIntTransferAcceptanceCollection.Count > 0)
				{
					deepHandles.Add("AdmIntTransferAcceptanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmIntTransferAcceptance>) DataRepository.AdmIntTransferAcceptanceProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmIntTransferAcceptanceCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCodeTransferTypeIdSource
			if (CanDeepSave(entity, "AdmCodeTransferType|AdmCodeTransferTypeIdSource", deepSaveType, innerList) 
				&& entity.AdmCodeTransferTypeIdSource != null)
			{
				DataRepository.AdmCodeTransferTypeProvider.Save(transactionManager, entity.AdmCodeTransferTypeIdSource);
				entity.AdmCodeTransferTypeId = entity.AdmCodeTransferTypeIdSource.AdmCodeTransferTypeId;
			}
			#endregion 
			
			#region AsCodeDegreeIdSource
			if (CanDeepSave(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeIdSource != null)
			{
				DataRepository.AsCodeDegreeProvider.Save(transactionManager, entity.AsCodeDegreeIdSource);
				entity.AsCodeDegreeId = entity.AsCodeDegreeIdSource.AsCodeDegreeId;
			}
			#endregion 
			
			#region AsCodeDegreeClassIdSource
			if (CanDeepSave(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeClassIdSource != null)
			{
				DataRepository.AsCodeDegreeClassProvider.Save(transactionManager, entity.AsCodeDegreeClassIdSource);
				entity.AsCodeDegreeClassId = entity.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmTransferAcceptance>
				if (CanDeepSave(entity.AdmTransferAcceptanceCollection, "List<AdmTransferAcceptance>|AdmTransferAcceptanceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmTransferAcceptance child in entity.AdmTransferAcceptanceCollection)
					{
						if(child.AdmTransAcceptanceCategoryIdSource != null)
						{
							child.AdmTransAcceptanceCategoryId = child.AdmTransAcceptanceCategoryIdSource.AdmTransAcceptanceCategoryId;
						}
						else
						{
							child.AdmTransAcceptanceCategoryId = entity.AdmTransAcceptanceCategoryId;
						}

					}

					if (entity.AdmTransferAcceptanceCollection.Count > 0 || entity.AdmTransferAcceptanceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmTransferAcceptanceProvider.Save(transactionManager, entity.AdmTransferAcceptanceCollection);
						
						deepHandles.Add("AdmTransferAcceptanceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmTransferAcceptance >) DataRepository.AdmTransferAcceptanceProvider.DeepSave,
							new object[] { transactionManager, entity.AdmTransferAcceptanceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmIntTransferAcceptance>
				if (CanDeepSave(entity.AdmIntTransferAcceptanceCollection, "List<AdmIntTransferAcceptance>|AdmIntTransferAcceptanceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmIntTransferAcceptance child in entity.AdmIntTransferAcceptanceCollection)
					{
						if(child.AdmTransAcceptanceCategoryIdSource != null)
						{
							child.AdmTransAcceptanceCategoryId = child.AdmTransAcceptanceCategoryIdSource.AdmTransAcceptanceCategoryId;
						}
						else
						{
							child.AdmTransAcceptanceCategoryId = entity.AdmTransAcceptanceCategoryId;
						}

					}

					if (entity.AdmIntTransferAcceptanceCollection.Count > 0 || entity.AdmIntTransferAcceptanceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmIntTransferAcceptanceProvider.Save(transactionManager, entity.AdmIntTransferAcceptanceCollection);
						
						deepHandles.Add("AdmIntTransferAcceptanceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmIntTransferAcceptance >) DataRepository.AdmIntTransferAcceptanceProvider.DeepSave,
							new object[] { transactionManager, entity.AdmIntTransferAcceptanceCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmTransAcceptanceCategoryChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmTransAcceptanceCategory</c>
	///</summary>
	public enum AdmTransAcceptanceCategoryChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCodeTransferType</c> at AdmCodeTransferTypeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCodeTransferType))]
		AdmCodeTransferType,
		
		///<summary>
		/// Composite Property for <c>AsCodeDegree</c> at AsCodeDegreeIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegree))]
		AsCodeDegree,
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		///<summary>
		/// Collection of <c>AdmTransAcceptanceCategory</c> as OneToMany for AdmTransferAcceptanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmTransferAcceptance>))]
		AdmTransferAcceptanceCollection,
		///<summary>
		/// Collection of <c>AdmTransAcceptanceCategory</c> as OneToMany for AdmIntTransferAcceptanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmIntTransferAcceptance>))]
		AdmIntTransferAcceptanceCollection,
	}
	
	#endregion AdmTransAcceptanceCategoryChildEntityTypes
	
	#region AdmTransAcceptanceCategoryFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmTransAcceptanceCategoryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmTransAcceptanceCategory"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmTransAcceptanceCategoryFilterBuilder : SqlFilterBuilder<AdmTransAcceptanceCategoryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmTransAcceptanceCategoryFilterBuilder class.
		/// </summary>
		public AdmTransAcceptanceCategoryFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmTransAcceptanceCategoryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmTransAcceptanceCategoryFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmTransAcceptanceCategoryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmTransAcceptanceCategoryFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmTransAcceptanceCategoryFilterBuilder
	
	#region AdmTransAcceptanceCategoryParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmTransAcceptanceCategoryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmTransAcceptanceCategory"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmTransAcceptanceCategoryParameterBuilder : ParameterizedSqlFilterBuilder<AdmTransAcceptanceCategoryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmTransAcceptanceCategoryParameterBuilder class.
		/// </summary>
		public AdmTransAcceptanceCategoryParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmTransAcceptanceCategoryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmTransAcceptanceCategoryParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmTransAcceptanceCategoryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmTransAcceptanceCategoryParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmTransAcceptanceCategoryParameterBuilder
	
	#region AdmTransAcceptanceCategorySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmTransAcceptanceCategoryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmTransAcceptanceCategory"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmTransAcceptanceCategorySortBuilder : SqlSortBuilder<AdmTransAcceptanceCategoryColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmTransAcceptanceCategorySqlSortBuilder class.
		/// </summary>
		public AdmTransAcceptanceCategorySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmTransAcceptanceCategorySortBuilder
	
} // end namespace
