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
	/// This class is the base class for any <see cref="AdmAcceptanceCategoryProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAcceptanceCategoryProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAcceptanceCategory, UMIS_VER2.BusinessLyer.AdmAcceptanceCategoryKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAcceptanceCategoryKey key)
		{
			return Delete(transactionManager, key.AdmAcceptanceCategoryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAcceptanceCategoryId">شروط وقواعد. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAcceptanceCategoryId)
		{
			return Delete(null, _admAcceptanceCategoryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAcceptanceCategoryId">شروط وقواعد. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAcceptanceCategoryId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE key.
		///		FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAcceptanceCategory objects.</returns>
		public TList<AdmAcceptanceCategory> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE key.
		///		FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAcceptanceCategory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAcceptanceCategory> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE key.
		///		FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAcceptanceCategory objects.</returns>
		public TList<AdmAcceptanceCategory> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE key.
		///		fkAdmAcceptanceCategoryAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAcceptanceCategory objects.</returns>
		public TList<AdmAcceptanceCategory> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE key.
		///		fkAdmAcceptanceCategoryAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAcceptanceCategory objects.</returns>
		public TList<AdmAcceptanceCategory> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE key.
		///		FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAcceptanceCategory objects.</returns>
		public abstract TList<AdmAcceptanceCategory> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAcceptanceCategory objects.</returns>
		public TList<AdmAcceptanceCategory> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAcceptanceCategory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAcceptanceCategory> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAcceptanceCategory objects.</returns>
		public TList<AdmAcceptanceCategory> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS key.
		///		fkAdmAcceptanceCategoryAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAcceptanceCategory objects.</returns>
		public TList<AdmAcceptanceCategory> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS key.
		///		fkAdmAcceptanceCategoryAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAcceptanceCategory objects.</returns>
		public TList<AdmAcceptanceCategory> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_ACCEPTANCE_CATEGORY_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAcceptanceCategory objects.</returns>
		public abstract TList<AdmAcceptanceCategory> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ACCEPTANCE_CATEGORY_AS_FACULTY_INFO key.
		///		FK_ADM_ACCEPTANCE_CATEGORY_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId">جامعة-كلية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAcceptanceCategory objects.</returns>
		public TList<AdmAcceptanceCategory> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ACCEPTANCE_CATEGORY_AS_FACULTY_INFO key.
		///		FK_ADM_ACCEPTANCE_CATEGORY_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">جامعة-كلية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAcceptanceCategory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAcceptanceCategory> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ACCEPTANCE_CATEGORY_AS_FACULTY_INFO key.
		///		FK_ADM_ACCEPTANCE_CATEGORY_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">جامعة-كلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAcceptanceCategory objects.</returns>
		public TList<AdmAcceptanceCategory> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ACCEPTANCE_CATEGORY_AS_FACULTY_INFO key.
		///		fkAdmAcceptanceCategoryAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">جامعة-كلية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAcceptanceCategory objects.</returns>
		public TList<AdmAcceptanceCategory> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ACCEPTANCE_CATEGORY_AS_FACULTY_INFO key.
		///		fkAdmAcceptanceCategoryAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">جامعة-كلية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAcceptanceCategory objects.</returns>
		public TList<AdmAcceptanceCategory> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ACCEPTANCE_CATEGORY_AS_FACULTY_INFO key.
		///		FK_ADM_ACCEPTANCE_CATEGORY_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">جامعة-كلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAcceptanceCategory objects.</returns>
		public abstract TList<AdmAcceptanceCategory> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAcceptanceCategory Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAcceptanceCategoryKey key, int start, int pageLength)
		{
			return GetByAdmAcceptanceCategoryId(transactionManager, key.AdmAcceptanceCategoryId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_ACCEPTANCE_CATEGORY index.
		/// </summary>
		/// <param name="_admAcceptanceCategoryId">شروط وقواعد</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAcceptanceCategory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAcceptanceCategory GetByAdmAcceptanceCategoryId(System.Decimal _admAcceptanceCategoryId)
		{
			int count = -1;
			return GetByAdmAcceptanceCategoryId(null,_admAcceptanceCategoryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_ACCEPTANCE_CATEGORY index.
		/// </summary>
		/// <param name="_admAcceptanceCategoryId">شروط وقواعد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAcceptanceCategory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAcceptanceCategory GetByAdmAcceptanceCategoryId(System.Decimal _admAcceptanceCategoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAcceptanceCategoryId(null, _admAcceptanceCategoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_ACCEPTANCE_CATEGORY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAcceptanceCategoryId">شروط وقواعد</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAcceptanceCategory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAcceptanceCategory GetByAdmAcceptanceCategoryId(TransactionManager transactionManager, System.Decimal _admAcceptanceCategoryId)
		{
			int count = -1;
			return GetByAdmAcceptanceCategoryId(transactionManager, _admAcceptanceCategoryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_ACCEPTANCE_CATEGORY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAcceptanceCategoryId">شروط وقواعد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAcceptanceCategory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAcceptanceCategory GetByAdmAcceptanceCategoryId(TransactionManager transactionManager, System.Decimal _admAcceptanceCategoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAcceptanceCategoryId(transactionManager, _admAcceptanceCategoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_ACCEPTANCE_CATEGORY index.
		/// </summary>
		/// <param name="_admAcceptanceCategoryId">شروط وقواعد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAcceptanceCategory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAcceptanceCategory GetByAdmAcceptanceCategoryId(System.Decimal _admAcceptanceCategoryId, int start, int pageLength, out int count)
		{
			return GetByAdmAcceptanceCategoryId(null, _admAcceptanceCategoryId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_ACCEPTANCE_CATEGORY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAcceptanceCategoryId">شروط وقواعد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAcceptanceCategory"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAcceptanceCategory GetByAdmAcceptanceCategoryId(TransactionManager transactionManager, System.Decimal _admAcceptanceCategoryId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAcceptanceCategory&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAcceptanceCategory&gt;"/></returns>
		public static TList<AdmAcceptanceCategory> Fill(IDataReader reader, TList<AdmAcceptanceCategory> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAcceptanceCategory c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAcceptanceCategory")
					.Append("|").Append((System.Decimal)reader["ADM_ACCEPTANCE_CATEGORY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAcceptanceCategory>(
					key.ToString(), // EntityTrackingKey
					"AdmAcceptanceCategory",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAcceptanceCategory();
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
					c.AdmAcceptanceCategoryId = (System.Decimal)reader["ADM_ACCEPTANCE_CATEGORY_ID"];
					c.OriginalAdmAcceptanceCategoryId = c.AdmAcceptanceCategoryId;
					c.CategoryNameEn = (System.String)reader["CATEGORY_NAME_EN"];
					c.CategoryNameAr = (System.String)reader["CATEGORY_NAME_AR"];
					c.CategoryType = (System.Decimal)reader["CATEGORY_TYPE"];
					c.CategoryValue = (System.Decimal)reader["CATEGORY_VALUE"];
					c.AbbreviationEn = (System.String)reader["ABBREVIATION_EN"];
					c.AbbreviationAr = (System.String)reader["ABBREVIATION_AR"];
					c.OrientationFlg = Convert.IsDBNull(reader["ORIENTATION_FLG"]) ? null : (System.Decimal?)reader["ORIENTATION_FLG"];
					c.RegExpiration = Convert.IsDBNull(reader["REG_EXPIRATION"]) ? null : (System.String)reader["REG_EXPIRATION"];
					c.AsCodeDegreeClassId = (System.Decimal)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.GsCdeOperator = Convert.IsDBNull(reader["GS_CDE_OPERATOR"]) ? null : (System.String)reader["GS_CDE_OPERATOR"];
					c.ExamLoadFlg = Convert.IsDBNull(reader["EXAM_LOAD_FLG"]) ? null : (System.Boolean?)reader["EXAM_LOAD_FLG"];
					c.CatTypeId = Convert.IsDBNull(reader["CAT_TYPE_ID"]) ? null : (System.Decimal?)reader["CAT_TYPE_ID"];
					c.EnumId = Convert.IsDBNull(reader["ENUM_ID"]) ? null : (System.Int16?)reader["ENUM_ID"];
					c.ShowFlg = Convert.IsDBNull(reader["SHOW_FLG"]) ? null : (System.Boolean?)reader["SHOW_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAcceptanceCategory"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAcceptanceCategory"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAcceptanceCategory entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAcceptanceCategoryId = (System.Decimal)reader[((int)AdmAcceptanceCategoryColumn.AdmAcceptanceCategoryId - 1)];
			entity.OriginalAdmAcceptanceCategoryId = (System.Decimal)reader["ADM_ACCEPTANCE_CATEGORY_ID"];
			entity.CategoryNameEn = (System.String)reader[((int)AdmAcceptanceCategoryColumn.CategoryNameEn - 1)];
			entity.CategoryNameAr = (System.String)reader[((int)AdmAcceptanceCategoryColumn.CategoryNameAr - 1)];
			entity.CategoryType = (System.Decimal)reader[((int)AdmAcceptanceCategoryColumn.CategoryType - 1)];
			entity.CategoryValue = (System.Decimal)reader[((int)AdmAcceptanceCategoryColumn.CategoryValue - 1)];
			entity.AbbreviationEn = (System.String)reader[((int)AdmAcceptanceCategoryColumn.AbbreviationEn - 1)];
			entity.AbbreviationAr = (System.String)reader[((int)AdmAcceptanceCategoryColumn.AbbreviationAr - 1)];
			entity.OrientationFlg = (reader.IsDBNull(((int)AdmAcceptanceCategoryColumn.OrientationFlg - 1)))?null:(System.Decimal?)reader[((int)AdmAcceptanceCategoryColumn.OrientationFlg - 1)];
			entity.RegExpiration = (reader.IsDBNull(((int)AdmAcceptanceCategoryColumn.RegExpiration - 1)))?null:(System.String)reader[((int)AdmAcceptanceCategoryColumn.RegExpiration - 1)];
			entity.AsCodeDegreeClassId = (System.Decimal)reader[((int)AdmAcceptanceCategoryColumn.AsCodeDegreeClassId - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)AdmAcceptanceCategoryColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)AdmAcceptanceCategoryColumn.AsCodeDegreeId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)AdmAcceptanceCategoryColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)AdmAcceptanceCategoryColumn.AsFacultyInfoId - 1)];
			entity.GsCdeOperator = (reader.IsDBNull(((int)AdmAcceptanceCategoryColumn.GsCdeOperator - 1)))?null:(System.String)reader[((int)AdmAcceptanceCategoryColumn.GsCdeOperator - 1)];
			entity.ExamLoadFlg = (reader.IsDBNull(((int)AdmAcceptanceCategoryColumn.ExamLoadFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAcceptanceCategoryColumn.ExamLoadFlg - 1)];
			entity.CatTypeId = (reader.IsDBNull(((int)AdmAcceptanceCategoryColumn.CatTypeId - 1)))?null:(System.Decimal?)reader[((int)AdmAcceptanceCategoryColumn.CatTypeId - 1)];
			entity.EnumId = (reader.IsDBNull(((int)AdmAcceptanceCategoryColumn.EnumId - 1)))?null:(System.Int16?)reader[((int)AdmAcceptanceCategoryColumn.EnumId - 1)];
			entity.ShowFlg = (reader.IsDBNull(((int)AdmAcceptanceCategoryColumn.ShowFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAcceptanceCategoryColumn.ShowFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAcceptanceCategory"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAcceptanceCategory"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAcceptanceCategory entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAcceptanceCategoryId = (System.Decimal)dataRow["ADM_ACCEPTANCE_CATEGORY_ID"];
			entity.OriginalAdmAcceptanceCategoryId = (System.Decimal)dataRow["ADM_ACCEPTANCE_CATEGORY_ID"];
			entity.CategoryNameEn = (System.String)dataRow["CATEGORY_NAME_EN"];
			entity.CategoryNameAr = (System.String)dataRow["CATEGORY_NAME_AR"];
			entity.CategoryType = (System.Decimal)dataRow["CATEGORY_TYPE"];
			entity.CategoryValue = (System.Decimal)dataRow["CATEGORY_VALUE"];
			entity.AbbreviationEn = (System.String)dataRow["ABBREVIATION_EN"];
			entity.AbbreviationAr = (System.String)dataRow["ABBREVIATION_AR"];
			entity.OrientationFlg = Convert.IsDBNull(dataRow["ORIENTATION_FLG"]) ? null : (System.Decimal?)dataRow["ORIENTATION_FLG"];
			entity.RegExpiration = Convert.IsDBNull(dataRow["REG_EXPIRATION"]) ? null : (System.String)dataRow["REG_EXPIRATION"];
			entity.AsCodeDegreeClassId = (System.Decimal)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.GsCdeOperator = Convert.IsDBNull(dataRow["GS_CDE_OPERATOR"]) ? null : (System.String)dataRow["GS_CDE_OPERATOR"];
			entity.ExamLoadFlg = Convert.IsDBNull(dataRow["EXAM_LOAD_FLG"]) ? null : (System.Boolean?)dataRow["EXAM_LOAD_FLG"];
			entity.CatTypeId = Convert.IsDBNull(dataRow["CAT_TYPE_ID"]) ? null : (System.Decimal?)dataRow["CAT_TYPE_ID"];
			entity.EnumId = Convert.IsDBNull(dataRow["ENUM_ID"]) ? null : (System.Int16?)dataRow["ENUM_ID"];
			entity.ShowFlg = Convert.IsDBNull(dataRow["SHOW_FLG"]) ? null : (System.Boolean?)dataRow["SHOW_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAcceptanceCategory"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAcceptanceCategory Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAcceptanceCategory entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsCodeDegreeIdSource	
			if (CanDeepLoad(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeId ?? 0.0m);
				AsCodeDegree tmpEntity = EntityManager.LocateEntity<AsCodeDegree>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeIdSource = tmpEntity;
				else
					entity.AsCodeDegreeIdSource = DataRepository.AsCodeDegreeProvider.GetByAsCodeDegreeId(transactionManager, (entity.AsCodeDegreeId ?? 0.0m));		
				
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
			// Deep load child collections  - Call GetByAdmAcceptanceCategoryId methods when available
			
			#region AdmApplicantAcceptanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmApplicantAcceptance>|AdmApplicantAcceptanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmApplicantAcceptanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmApplicantAcceptanceCollection = DataRepository.AdmApplicantAcceptanceProvider.GetByAdmAcceptanceCategoryId(transactionManager, entity.AdmAcceptanceCategoryId);

				if (deep && entity.AdmApplicantAcceptanceCollection.Count > 0)
				{
					deepHandles.Add("AdmApplicantAcceptanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmApplicantAcceptance>) DataRepository.AdmApplicantAcceptanceProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmApplicantAcceptanceCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAcceptanceCategory object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAcceptanceCategory instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAcceptanceCategory Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAcceptanceCategory entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
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
	
			#region List<AdmApplicantAcceptance>
				if (CanDeepSave(entity.AdmApplicantAcceptanceCollection, "List<AdmApplicantAcceptance>|AdmApplicantAcceptanceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmApplicantAcceptance child in entity.AdmApplicantAcceptanceCollection)
					{
						if(child.AdmAcceptanceCategoryIdSource != null)
						{
							child.AdmAcceptanceCategoryId = child.AdmAcceptanceCategoryIdSource.AdmAcceptanceCategoryId;
						}
						else
						{
							child.AdmAcceptanceCategoryId = entity.AdmAcceptanceCategoryId;
						}

					}

					if (entity.AdmApplicantAcceptanceCollection.Count > 0 || entity.AdmApplicantAcceptanceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmApplicantAcceptanceProvider.Save(transactionManager, entity.AdmApplicantAcceptanceCollection);
						
						deepHandles.Add("AdmApplicantAcceptanceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmApplicantAcceptance >) DataRepository.AdmApplicantAcceptanceProvider.DeepSave,
							new object[] { transactionManager, entity.AdmApplicantAcceptanceCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmAcceptanceCategoryChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAcceptanceCategory</c>
	///</summary>
	public enum AdmAcceptanceCategoryChildEntityTypes
	{
		
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
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		///<summary>
		/// Collection of <c>AdmAcceptanceCategory</c> as OneToMany for AdmApplicantAcceptanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmApplicantAcceptance>))]
		AdmApplicantAcceptanceCollection,
	}
	
	#endregion AdmAcceptanceCategoryChildEntityTypes
	
	#region AdmAcceptanceCategoryFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAcceptanceCategoryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAcceptanceCategory"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAcceptanceCategoryFilterBuilder : SqlFilterBuilder<AdmAcceptanceCategoryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAcceptanceCategoryFilterBuilder class.
		/// </summary>
		public AdmAcceptanceCategoryFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAcceptanceCategoryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAcceptanceCategoryFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAcceptanceCategoryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAcceptanceCategoryFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAcceptanceCategoryFilterBuilder
	
	#region AdmAcceptanceCategoryParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAcceptanceCategoryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAcceptanceCategory"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAcceptanceCategoryParameterBuilder : ParameterizedSqlFilterBuilder<AdmAcceptanceCategoryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAcceptanceCategoryParameterBuilder class.
		/// </summary>
		public AdmAcceptanceCategoryParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAcceptanceCategoryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAcceptanceCategoryParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAcceptanceCategoryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAcceptanceCategoryParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAcceptanceCategoryParameterBuilder
	
	#region AdmAcceptanceCategorySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAcceptanceCategoryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAcceptanceCategory"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAcceptanceCategorySortBuilder : SqlSortBuilder<AdmAcceptanceCategoryColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAcceptanceCategorySqlSortBuilder class.
		/// </summary>
		public AdmAcceptanceCategorySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAcceptanceCategorySortBuilder
	
} // end namespace
