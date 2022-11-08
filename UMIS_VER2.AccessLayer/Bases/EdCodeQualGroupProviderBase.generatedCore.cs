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
	/// This class is the base class for any <see cref="EdCodeQualGroupProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeQualGroupProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeQualGroup, UMIS_VER2.BusinessLyer.EdCodeQualGroupKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeQualGroupKey key)
		{
			return Delete(transactionManager, key.EdCodeQualGroupId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeQualGroupId)
		{
			return Delete(null, _edCodeQualGroupId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeQualGroupId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_GROUP_ADM_CDE_EXAM_GRDNG key.
		///		FK_ED_CODE_QUAL_GROUP_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="_admCdeExamMinGrdngId">اقل تقدير نجاح</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualGroup objects.</returns>
		public TList<EdCodeQualGroup> GetByAdmCdeExamMinGrdngId(System.Decimal? _admCdeExamMinGrdngId)
		{
			int count = -1;
			return GetByAdmCdeExamMinGrdngId(_admCdeExamMinGrdngId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_GROUP_ADM_CDE_EXAM_GRDNG key.
		///		FK_ED_CODE_QUAL_GROUP_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamMinGrdngId">اقل تقدير نجاح</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualGroup objects.</returns>
		/// <remarks></remarks>
		public TList<EdCodeQualGroup> GetByAdmCdeExamMinGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamMinGrdngId)
		{
			int count = -1;
			return GetByAdmCdeExamMinGrdngId(transactionManager, _admCdeExamMinGrdngId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_GROUP_ADM_CDE_EXAM_GRDNG key.
		///		FK_ED_CODE_QUAL_GROUP_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamMinGrdngId">اقل تقدير نجاح</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualGroup objects.</returns>
		public TList<EdCodeQualGroup> GetByAdmCdeExamMinGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamMinGrdngId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeExamMinGrdngId(transactionManager, _admCdeExamMinGrdngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_GROUP_ADM_CDE_EXAM_GRDNG key.
		///		fkEdCodeQualGroupAdmCdeExamGrdng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeExamMinGrdngId">اقل تقدير نجاح</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualGroup objects.</returns>
		public TList<EdCodeQualGroup> GetByAdmCdeExamMinGrdngId(System.Decimal? _admCdeExamMinGrdngId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeExamMinGrdngId(null, _admCdeExamMinGrdngId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_GROUP_ADM_CDE_EXAM_GRDNG key.
		///		fkEdCodeQualGroupAdmCdeExamGrdng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeExamMinGrdngId">اقل تقدير نجاح</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualGroup objects.</returns>
		public TList<EdCodeQualGroup> GetByAdmCdeExamMinGrdngId(System.Decimal? _admCdeExamMinGrdngId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeExamMinGrdngId(null, _admCdeExamMinGrdngId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_GROUP_ADM_CDE_EXAM_GRDNG key.
		///		FK_ED_CODE_QUAL_GROUP_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamMinGrdngId">اقل تقدير نجاح</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualGroup objects.</returns>
		public abstract TList<EdCodeQualGroup> GetByAdmCdeExamMinGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamMinGrdngId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_GROUP_ADM_EXAM_GRDNG_PKG key.
		///		FK_ED_CODE_QUAL_GROUP_ADM_EXAM_GRDNG_PKG Description: 
		/// </summary>
		/// <param name="_admExamGrdngPkgId">IG Group Grdng Pkg OL AS AL</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualGroup objects.</returns>
		public TList<EdCodeQualGroup> GetByAdmExamGrdngPkgId(System.Decimal? _admExamGrdngPkgId)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgId(_admExamGrdngPkgId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_GROUP_ADM_EXAM_GRDNG_PKG key.
		///		FK_ED_CODE_QUAL_GROUP_ADM_EXAM_GRDNG_PKG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgId">IG Group Grdng Pkg OL AS AL</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualGroup objects.</returns>
		/// <remarks></remarks>
		public TList<EdCodeQualGroup> GetByAdmExamGrdngPkgId(TransactionManager transactionManager, System.Decimal? _admExamGrdngPkgId)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgId(transactionManager, _admExamGrdngPkgId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_GROUP_ADM_EXAM_GRDNG_PKG key.
		///		FK_ED_CODE_QUAL_GROUP_ADM_EXAM_GRDNG_PKG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgId">IG Group Grdng Pkg OL AS AL</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualGroup objects.</returns>
		public TList<EdCodeQualGroup> GetByAdmExamGrdngPkgId(TransactionManager transactionManager, System.Decimal? _admExamGrdngPkgId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgId(transactionManager, _admExamGrdngPkgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_GROUP_ADM_EXAM_GRDNG_PKG key.
		///		fkEdCodeQualGroupAdmExamGrdngPkg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admExamGrdngPkgId">IG Group Grdng Pkg OL AS AL</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualGroup objects.</returns>
		public TList<EdCodeQualGroup> GetByAdmExamGrdngPkgId(System.Decimal? _admExamGrdngPkgId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmExamGrdngPkgId(null, _admExamGrdngPkgId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_GROUP_ADM_EXAM_GRDNG_PKG key.
		///		fkEdCodeQualGroupAdmExamGrdngPkg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admExamGrdngPkgId">IG Group Grdng Pkg OL AS AL</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualGroup objects.</returns>
		public TList<EdCodeQualGroup> GetByAdmExamGrdngPkgId(System.Decimal? _admExamGrdngPkgId, int start, int pageLength,out int count)
		{
			return GetByAdmExamGrdngPkgId(null, _admExamGrdngPkgId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_GROUP_ADM_EXAM_GRDNG_PKG key.
		///		FK_ED_CODE_QUAL_GROUP_ADM_EXAM_GRDNG_PKG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgId">IG Group Grdng Pkg OL AS AL</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualGroup objects.</returns>
		public abstract TList<EdCodeQualGroup> GetByAdmExamGrdngPkgId(TransactionManager transactionManager, System.Decimal? _admExamGrdngPkgId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_GROUP_ED_CDE_QUAL_BRN key.
		///		FK_ED_CODE_QUAL_GROUP_ED_CDE_QUAL_BRN Description: 
		/// </summary>
		/// <param name="_edCodeQualBranId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualGroup objects.</returns>
		public TList<EdCodeQualGroup> GetByEdCodeQualBranId(System.Decimal _edCodeQualBranId)
		{
			int count = -1;
			return GetByEdCodeQualBranId(_edCodeQualBranId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_GROUP_ED_CDE_QUAL_BRN key.
		///		FK_ED_CODE_QUAL_GROUP_ED_CDE_QUAL_BRN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualBranId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualGroup objects.</returns>
		/// <remarks></remarks>
		public TList<EdCodeQualGroup> GetByEdCodeQualBranId(TransactionManager transactionManager, System.Decimal _edCodeQualBranId)
		{
			int count = -1;
			return GetByEdCodeQualBranId(transactionManager, _edCodeQualBranId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_GROUP_ED_CDE_QUAL_BRN key.
		///		FK_ED_CODE_QUAL_GROUP_ED_CDE_QUAL_BRN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualBranId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualGroup objects.</returns>
		public TList<EdCodeQualGroup> GetByEdCodeQualBranId(TransactionManager transactionManager, System.Decimal _edCodeQualBranId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeQualBranId(transactionManager, _edCodeQualBranId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_GROUP_ED_CDE_QUAL_BRN key.
		///		fkEdCodeQualGroupEdCdeQualBrn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualBranId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualGroup objects.</returns>
		public TList<EdCodeQualGroup> GetByEdCodeQualBranId(System.Decimal _edCodeQualBranId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeQualBranId(null, _edCodeQualBranId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_GROUP_ED_CDE_QUAL_BRN key.
		///		fkEdCodeQualGroupEdCdeQualBrn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualBranId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualGroup objects.</returns>
		public TList<EdCodeQualGroup> GetByEdCodeQualBranId(System.Decimal _edCodeQualBranId, int start, int pageLength,out int count)
		{
			return GetByEdCodeQualBranId(null, _edCodeQualBranId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_GROUP_ED_CDE_QUAL_BRN key.
		///		FK_ED_CODE_QUAL_GROUP_ED_CDE_QUAL_BRN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualBranId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualGroup objects.</returns>
		public abstract TList<EdCodeQualGroup> GetByEdCodeQualBranId(TransactionManager transactionManager, System.Decimal _edCodeQualBranId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeQualGroup Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeQualGroupKey key, int start, int pageLength)
		{
			return GetByEdCodeQualGroupId(transactionManager, key.EdCodeQualGroupId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_QUAL_GROUP index.
		/// </summary>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQualGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQualGroup GetByEdCodeQualGroupId(System.Decimal _edCodeQualGroupId)
		{
			int count = -1;
			return GetByEdCodeQualGroupId(null,_edCodeQualGroupId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_QUAL_GROUP index.
		/// </summary>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQualGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQualGroup GetByEdCodeQualGroupId(System.Decimal _edCodeQualGroupId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeQualGroupId(null, _edCodeQualGroupId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_QUAL_GROUP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQualGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQualGroup GetByEdCodeQualGroupId(TransactionManager transactionManager, System.Decimal _edCodeQualGroupId)
		{
			int count = -1;
			return GetByEdCodeQualGroupId(transactionManager, _edCodeQualGroupId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_QUAL_GROUP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQualGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQualGroup GetByEdCodeQualGroupId(TransactionManager transactionManager, System.Decimal _edCodeQualGroupId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeQualGroupId(transactionManager, _edCodeQualGroupId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_QUAL_GROUP index.
		/// </summary>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQualGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQualGroup GetByEdCodeQualGroupId(System.Decimal _edCodeQualGroupId, int start, int pageLength, out int count)
		{
			return GetByEdCodeQualGroupId(null, _edCodeQualGroupId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_QUAL_GROUP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQualGroup"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeQualGroup GetByEdCodeQualGroupId(TransactionManager transactionManager, System.Decimal _edCodeQualGroupId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeQualGroup&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeQualGroup&gt;"/></returns>
		public static TList<EdCodeQualGroup> Fill(IDataReader reader, TList<EdCodeQualGroup> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeQualGroup c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeQualGroup")
					.Append("|").Append((System.Decimal)reader["ED_CODE_QUAL_GROUP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeQualGroup>(
					key.ToString(), // EntityTrackingKey
					"EdCodeQualGroup",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeQualGroup();
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
					c.EdCodeQualGroupId = (System.Decimal)reader["ED_CODE_QUAL_GROUP_ID"];
					c.OriginalEdCodeQualGroupId = c.EdCodeQualGroupId;
					c.EdCodeQualBranId = (System.Decimal)reader["ED_CODE_QUAL_BRAN_ID"];
					c.QualGrpAr = Convert.IsDBNull(reader["QUAL_GRP_AR"]) ? null : (System.String)reader["QUAL_GRP_AR"];
					c.QualGrpEn = Convert.IsDBNull(reader["QUAL_GRP_EN"]) ? null : (System.String)reader["QUAL_GRP_EN"];
					c.MinPrcnt = Convert.IsDBNull(reader["MIN_PRCNT"]) ? null : (System.Decimal?)reader["MIN_PRCNT"];
					c.GrpPrcnt = Convert.IsDBNull(reader["GRP_PRCNT"]) ? null : (System.Decimal?)reader["GRP_PRCNT"];
					c.GradeTypeId = Convert.IsDBNull(reader["GRADE_TYPE_ID"]) ? null : (System.Int32?)reader["GRADE_TYPE_ID"];
					c.AdmExamGrdngPkgId = Convert.IsDBNull(reader["ADM_EXAM_GRDNG_PKG_ID"]) ? null : (System.Decimal?)reader["ADM_EXAM_GRDNG_PKG_ID"];
					c.AdmCdeExamMinGrdngId = Convert.IsDBNull(reader["ADM_CDE_EXAM_MIN_GRDNG_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_EXAM_MIN_GRDNG_ID"];
					c.MinCrsCount = Convert.IsDBNull(reader["MIN_CRS_COUNT"]) ? null : (System.Int32?)reader["MIN_CRS_COUNT"];
					c.MaxCrsCount = Convert.IsDBNull(reader["MAX_CRS_COUNT"]) ? null : (System.Int32?)reader["MAX_CRS_COUNT"];
					c.GrpMaxMark = Convert.IsDBNull(reader["GRP_MAX_MARK"]) ? null : (System.Int32?)reader["GRP_MAX_MARK"];
					c.EditFlg = Convert.IsDBNull(reader["EDIT_FLG"]) ? null : (System.Boolean?)reader["EDIT_FLG"];
					c.QualGroupEquation = Convert.IsDBNull(reader["QUAL_GROUP_EQUATION"]) ? null : (System.String)reader["QUAL_GROUP_EQUATION"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeQualGroup"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeQualGroup"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeQualGroup entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeQualGroupId = (System.Decimal)reader[((int)EdCodeQualGroupColumn.EdCodeQualGroupId - 1)];
			entity.OriginalEdCodeQualGroupId = (System.Decimal)reader["ED_CODE_QUAL_GROUP_ID"];
			entity.EdCodeQualBranId = (System.Decimal)reader[((int)EdCodeQualGroupColumn.EdCodeQualBranId - 1)];
			entity.QualGrpAr = (reader.IsDBNull(((int)EdCodeQualGroupColumn.QualGrpAr - 1)))?null:(System.String)reader[((int)EdCodeQualGroupColumn.QualGrpAr - 1)];
			entity.QualGrpEn = (reader.IsDBNull(((int)EdCodeQualGroupColumn.QualGrpEn - 1)))?null:(System.String)reader[((int)EdCodeQualGroupColumn.QualGrpEn - 1)];
			entity.MinPrcnt = (reader.IsDBNull(((int)EdCodeQualGroupColumn.MinPrcnt - 1)))?null:(System.Decimal?)reader[((int)EdCodeQualGroupColumn.MinPrcnt - 1)];
			entity.GrpPrcnt = (reader.IsDBNull(((int)EdCodeQualGroupColumn.GrpPrcnt - 1)))?null:(System.Decimal?)reader[((int)EdCodeQualGroupColumn.GrpPrcnt - 1)];
			entity.GradeTypeId = (reader.IsDBNull(((int)EdCodeQualGroupColumn.GradeTypeId - 1)))?null:(System.Int32?)reader[((int)EdCodeQualGroupColumn.GradeTypeId - 1)];
			entity.AdmExamGrdngPkgId = (reader.IsDBNull(((int)EdCodeQualGroupColumn.AdmExamGrdngPkgId - 1)))?null:(System.Decimal?)reader[((int)EdCodeQualGroupColumn.AdmExamGrdngPkgId - 1)];
			entity.AdmCdeExamMinGrdngId = (reader.IsDBNull(((int)EdCodeQualGroupColumn.AdmCdeExamMinGrdngId - 1)))?null:(System.Decimal?)reader[((int)EdCodeQualGroupColumn.AdmCdeExamMinGrdngId - 1)];
			entity.MinCrsCount = (reader.IsDBNull(((int)EdCodeQualGroupColumn.MinCrsCount - 1)))?null:(System.Int32?)reader[((int)EdCodeQualGroupColumn.MinCrsCount - 1)];
			entity.MaxCrsCount = (reader.IsDBNull(((int)EdCodeQualGroupColumn.MaxCrsCount - 1)))?null:(System.Int32?)reader[((int)EdCodeQualGroupColumn.MaxCrsCount - 1)];
			entity.GrpMaxMark = (reader.IsDBNull(((int)EdCodeQualGroupColumn.GrpMaxMark - 1)))?null:(System.Int32?)reader[((int)EdCodeQualGroupColumn.GrpMaxMark - 1)];
			entity.EditFlg = (reader.IsDBNull(((int)EdCodeQualGroupColumn.EditFlg - 1)))?null:(System.Boolean?)reader[((int)EdCodeQualGroupColumn.EditFlg - 1)];
			entity.QualGroupEquation = (reader.IsDBNull(((int)EdCodeQualGroupColumn.QualGroupEquation - 1)))?null:(System.String)reader[((int)EdCodeQualGroupColumn.QualGroupEquation - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeQualGroup"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeQualGroup"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeQualGroup entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeQualGroupId = (System.Decimal)dataRow["ED_CODE_QUAL_GROUP_ID"];
			entity.OriginalEdCodeQualGroupId = (System.Decimal)dataRow["ED_CODE_QUAL_GROUP_ID"];
			entity.EdCodeQualBranId = (System.Decimal)dataRow["ED_CODE_QUAL_BRAN_ID"];
			entity.QualGrpAr = Convert.IsDBNull(dataRow["QUAL_GRP_AR"]) ? null : (System.String)dataRow["QUAL_GRP_AR"];
			entity.QualGrpEn = Convert.IsDBNull(dataRow["QUAL_GRP_EN"]) ? null : (System.String)dataRow["QUAL_GRP_EN"];
			entity.MinPrcnt = Convert.IsDBNull(dataRow["MIN_PRCNT"]) ? null : (System.Decimal?)dataRow["MIN_PRCNT"];
			entity.GrpPrcnt = Convert.IsDBNull(dataRow["GRP_PRCNT"]) ? null : (System.Decimal?)dataRow["GRP_PRCNT"];
			entity.GradeTypeId = Convert.IsDBNull(dataRow["GRADE_TYPE_ID"]) ? null : (System.Int32?)dataRow["GRADE_TYPE_ID"];
			entity.AdmExamGrdngPkgId = Convert.IsDBNull(dataRow["ADM_EXAM_GRDNG_PKG_ID"]) ? null : (System.Decimal?)dataRow["ADM_EXAM_GRDNG_PKG_ID"];
			entity.AdmCdeExamMinGrdngId = Convert.IsDBNull(dataRow["ADM_CDE_EXAM_MIN_GRDNG_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_EXAM_MIN_GRDNG_ID"];
			entity.MinCrsCount = Convert.IsDBNull(dataRow["MIN_CRS_COUNT"]) ? null : (System.Int32?)dataRow["MIN_CRS_COUNT"];
			entity.MaxCrsCount = Convert.IsDBNull(dataRow["MAX_CRS_COUNT"]) ? null : (System.Int32?)dataRow["MAX_CRS_COUNT"];
			entity.GrpMaxMark = Convert.IsDBNull(dataRow["GRP_MAX_MARK"]) ? null : (System.Int32?)dataRow["GRP_MAX_MARK"];
			entity.EditFlg = Convert.IsDBNull(dataRow["EDIT_FLG"]) ? null : (System.Boolean?)dataRow["EDIT_FLG"];
			entity.QualGroupEquation = Convert.IsDBNull(dataRow["QUAL_GROUP_EQUATION"]) ? null : (System.String)dataRow["QUAL_GROUP_EQUATION"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeQualGroup"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeQualGroup Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeQualGroup entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmCdeExamMinGrdngIdSource	
			if (CanDeepLoad(entity, "AdmCdeExamGrdng|AdmCdeExamMinGrdngIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeExamMinGrdngIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeExamMinGrdngId ?? 0.0m);
				AdmCdeExamGrdng tmpEntity = EntityManager.LocateEntity<AdmCdeExamGrdng>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeExamGrdng), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeExamMinGrdngIdSource = tmpEntity;
				else
					entity.AdmCdeExamMinGrdngIdSource = DataRepository.AdmCdeExamGrdngProvider.GetByAdmCdeExamGrdngId(transactionManager, (entity.AdmCdeExamMinGrdngId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeExamMinGrdngIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeExamMinGrdngIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeExamGrdngProvider.DeepLoad(transactionManager, entity.AdmCdeExamMinGrdngIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeExamMinGrdngIdSource

			#region AdmExamGrdngPkgIdSource	
			if (CanDeepLoad(entity, "AdmExamGrdngPkg|AdmExamGrdngPkgIdSource", deepLoadType, innerList) 
				&& entity.AdmExamGrdngPkgIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmExamGrdngPkgId ?? 0.0m);
				AdmExamGrdngPkg tmpEntity = EntityManager.LocateEntity<AdmExamGrdngPkg>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmExamGrdngPkg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmExamGrdngPkgIdSource = tmpEntity;
				else
					entity.AdmExamGrdngPkgIdSource = DataRepository.AdmExamGrdngPkgProvider.GetByAdmExamGrdngPkgId(transactionManager, (entity.AdmExamGrdngPkgId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmExamGrdngPkgIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmExamGrdngPkgIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmExamGrdngPkgProvider.DeepLoad(transactionManager, entity.AdmExamGrdngPkgIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmExamGrdngPkgIdSource

			#region EdCodeQualBranIdSource	
			if (CanDeepLoad(entity, "EdCdeQualBrn|EdCodeQualBranIdSource", deepLoadType, innerList) 
				&& entity.EdCodeQualBranIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeQualBranId;
				EdCdeQualBrn tmpEntity = EntityManager.LocateEntity<EdCdeQualBrn>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeQualBrn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeQualBranIdSource = tmpEntity;
				else
					entity.EdCodeQualBranIdSource = DataRepository.EdCdeQualBrnProvider.GetByEdCdeQualBrnId(transactionManager, entity.EdCodeQualBranId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeQualBranIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeQualBranIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeQualBrnProvider.DeepLoad(transactionManager, entity.EdCodeQualBranIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeQualBranIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeQualGroupId methods when available
			
			#region EdCodeQualSubjectCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCodeQualSubject>|EdCodeQualSubjectCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeQualSubjectCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCodeQualSubjectCollection = DataRepository.EdCodeQualSubjectProvider.GetByEdCodeQualGroupId(transactionManager, entity.EdCodeQualGroupId);

				if (deep && entity.EdCodeQualSubjectCollection.Count > 0)
				{
					deepHandles.Add("EdCodeQualSubjectCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCodeQualSubject>) DataRepository.EdCodeQualSubjectProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCodeQualSubjectCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudQualGroupCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQualGroup>|EdStudQualGroupCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualGroupCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualGroupCollection = DataRepository.EdStudQualGroupProvider.GetByEdCodeQualGroupId(transactionManager, entity.EdCodeQualGroupId);

				if (deep && entity.EdStudQualGroupCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualGroupCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQualGroup>) DataRepository.EdStudQualGroupProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualGroupCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudQualSubjectCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQualSubject>|EdStudQualSubjectCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualSubjectCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualSubjectCollection = DataRepository.EdStudQualSubjectProvider.GetByEdCodeQualGroupId(transactionManager, entity.EdCodeQualGroupId);

				if (deep && entity.EdStudQualSubjectCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualSubjectCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQualSubject>) DataRepository.EdStudQualSubjectProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualSubjectCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeQualGroup object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeQualGroup instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeQualGroup Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeQualGroup entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCdeExamMinGrdngIdSource
			if (CanDeepSave(entity, "AdmCdeExamGrdng|AdmCdeExamMinGrdngIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeExamMinGrdngIdSource != null)
			{
				DataRepository.AdmCdeExamGrdngProvider.Save(transactionManager, entity.AdmCdeExamMinGrdngIdSource);
				entity.AdmCdeExamMinGrdngId = entity.AdmCdeExamMinGrdngIdSource.AdmCdeExamGrdngId;
			}
			#endregion 
			
			#region AdmExamGrdngPkgIdSource
			if (CanDeepSave(entity, "AdmExamGrdngPkg|AdmExamGrdngPkgIdSource", deepSaveType, innerList) 
				&& entity.AdmExamGrdngPkgIdSource != null)
			{
				DataRepository.AdmExamGrdngPkgProvider.Save(transactionManager, entity.AdmExamGrdngPkgIdSource);
				entity.AdmExamGrdngPkgId = entity.AdmExamGrdngPkgIdSource.AdmExamGrdngPkgId;
			}
			#endregion 
			
			#region EdCodeQualBranIdSource
			if (CanDeepSave(entity, "EdCdeQualBrn|EdCodeQualBranIdSource", deepSaveType, innerList) 
				&& entity.EdCodeQualBranIdSource != null)
			{
				DataRepository.EdCdeQualBrnProvider.Save(transactionManager, entity.EdCodeQualBranIdSource);
				entity.EdCodeQualBranId = entity.EdCodeQualBranIdSource.EdCdeQualBrnId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdCodeQualSubject>
				if (CanDeepSave(entity.EdCodeQualSubjectCollection, "List<EdCodeQualSubject>|EdCodeQualSubjectCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCodeQualSubject child in entity.EdCodeQualSubjectCollection)
					{
						if(child.EdCodeQualGroupIdSource != null)
						{
							child.EdCodeQualGroupId = child.EdCodeQualGroupIdSource.EdCodeQualGroupId;
						}
						else
						{
							child.EdCodeQualGroupId = entity.EdCodeQualGroupId;
						}

					}

					if (entity.EdCodeQualSubjectCollection.Count > 0 || entity.EdCodeQualSubjectCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCodeQualSubjectProvider.Save(transactionManager, entity.EdCodeQualSubjectCollection);
						
						deepHandles.Add("EdCodeQualSubjectCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCodeQualSubject >) DataRepository.EdCodeQualSubjectProvider.DeepSave,
							new object[] { transactionManager, entity.EdCodeQualSubjectCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudQualGroup>
				if (CanDeepSave(entity.EdStudQualGroupCollection, "List<EdStudQualGroup>|EdStudQualGroupCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQualGroup child in entity.EdStudQualGroupCollection)
					{
						if(child.EdCodeQualGroupIdSource != null)
						{
							child.EdCodeQualGroupId = child.EdCodeQualGroupIdSource.EdCodeQualGroupId;
						}
						else
						{
							child.EdCodeQualGroupId = entity.EdCodeQualGroupId;
						}

					}

					if (entity.EdStudQualGroupCollection.Count > 0 || entity.EdStudQualGroupCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudQualGroupProvider.Save(transactionManager, entity.EdStudQualGroupCollection);
						
						deepHandles.Add("EdStudQualGroupCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudQualGroup >) DataRepository.EdStudQualGroupProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudQualGroupCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudQualSubject>
				if (CanDeepSave(entity.EdStudQualSubjectCollection, "List<EdStudQualSubject>|EdStudQualSubjectCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQualSubject child in entity.EdStudQualSubjectCollection)
					{
						if(child.EdCodeQualGroupIdSource != null)
						{
							child.EdCodeQualGroupId = child.EdCodeQualGroupIdSource.EdCodeQualGroupId;
						}
						else
						{
							child.EdCodeQualGroupId = entity.EdCodeQualGroupId;
						}

					}

					if (entity.EdStudQualSubjectCollection.Count > 0 || entity.EdStudQualSubjectCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudQualSubjectProvider.Save(transactionManager, entity.EdStudQualSubjectCollection);
						
						deepHandles.Add("EdStudQualSubjectCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudQualSubject >) DataRepository.EdStudQualSubjectProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudQualSubjectCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeQualGroupChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeQualGroup</c>
	///</summary>
	public enum EdCodeQualGroupChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCdeExamGrdng</c> at AdmCdeExamMinGrdngIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeExamGrdng))]
		AdmCdeExamGrdng,
		
		///<summary>
		/// Composite Property for <c>AdmExamGrdngPkg</c> at AdmExamGrdngPkgIdSource
		///</summary>
		[ChildEntityType(typeof(AdmExamGrdngPkg))]
		AdmExamGrdngPkg,
		
		///<summary>
		/// Composite Property for <c>EdCdeQualBrn</c> at EdCodeQualBranIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeQualBrn))]
		EdCdeQualBrn,
		///<summary>
		/// Collection of <c>EdCodeQualGroup</c> as OneToMany for EdCodeQualSubjectCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCodeQualSubject>))]
		EdCodeQualSubjectCollection,
		///<summary>
		/// Collection of <c>EdCodeQualGroup</c> as OneToMany for EdStudQualGroupCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQualGroup>))]
		EdStudQualGroupCollection,
		///<summary>
		/// Collection of <c>EdCodeQualGroup</c> as OneToMany for EdStudQualSubjectCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQualSubject>))]
		EdStudQualSubjectCollection,
	}
	
	#endregion EdCodeQualGroupChildEntityTypes
	
	#region EdCodeQualGroupFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeQualGroupColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeQualGroup"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeQualGroupFilterBuilder : SqlFilterBuilder<EdCodeQualGroupColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeQualGroupFilterBuilder class.
		/// </summary>
		public EdCodeQualGroupFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeQualGroupFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeQualGroupFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeQualGroupFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeQualGroupFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeQualGroupFilterBuilder
	
	#region EdCodeQualGroupParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeQualGroupColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeQualGroup"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeQualGroupParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeQualGroupColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeQualGroupParameterBuilder class.
		/// </summary>
		public EdCodeQualGroupParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeQualGroupParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeQualGroupParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeQualGroupParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeQualGroupParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeQualGroupParameterBuilder
	
	#region EdCodeQualGroupSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeQualGroupColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeQualGroup"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeQualGroupSortBuilder : SqlSortBuilder<EdCodeQualGroupColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeQualGroupSqlSortBuilder class.
		/// </summary>
		public EdCodeQualGroupSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeQualGroupSortBuilder
	
} // end namespace
