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
	/// This class is the base class for any <see cref="EntCodePolicyMetadataProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntCodePolicyMetadataProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntCodePolicyMetadata, UMIS_VER2.BusinessLyer.EntCodePolicyMetadataKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodePolicyMetadataKey key)
		{
			return Delete(transactionManager, key.EntCodePolicyMdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entCodePolicyMdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entCodePolicyMdId)
		{
			return Delete(null, _entCodePolicyMdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePolicyMdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entCodePolicyMdId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_POLICY_METADATA_ED_CODE_MD_TYPE key.
		///		FK_ENT_CODE_POLICY_METADATA_ED_CODE_MD_TYPE Description: 
		/// </summary>
		/// <param name="_entCodeMdTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodePolicyMetadata objects.</returns>
		public TList<EntCodePolicyMetadata> GetByEntCodeMdTypeId(System.Decimal _entCodeMdTypeId)
		{
			int count = -1;
			return GetByEntCodeMdTypeId(_entCodeMdTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_POLICY_METADATA_ED_CODE_MD_TYPE key.
		///		FK_ENT_CODE_POLICY_METADATA_ED_CODE_MD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodePolicyMetadata objects.</returns>
		/// <remarks></remarks>
		public TList<EntCodePolicyMetadata> GetByEntCodeMdTypeId(TransactionManager transactionManager, System.Decimal _entCodeMdTypeId)
		{
			int count = -1;
			return GetByEntCodeMdTypeId(transactionManager, _entCodeMdTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_POLICY_METADATA_ED_CODE_MD_TYPE key.
		///		FK_ENT_CODE_POLICY_METADATA_ED_CODE_MD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodePolicyMetadata objects.</returns>
		public TList<EntCodePolicyMetadata> GetByEntCodeMdTypeId(TransactionManager transactionManager, System.Decimal _entCodeMdTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeMdTypeId(transactionManager, _entCodeMdTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_POLICY_METADATA_ED_CODE_MD_TYPE key.
		///		fkEntCodePolicyMetadataEdCodeMdType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodePolicyMetadata objects.</returns>
		public TList<EntCodePolicyMetadata> GetByEntCodeMdTypeId(System.Decimal _entCodeMdTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntCodeMdTypeId(null, _entCodeMdTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_POLICY_METADATA_ED_CODE_MD_TYPE key.
		///		fkEntCodePolicyMetadataEdCodeMdType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodePolicyMetadata objects.</returns>
		public TList<EntCodePolicyMetadata> GetByEntCodeMdTypeId(System.Decimal _entCodeMdTypeId, int start, int pageLength,out int count)
		{
			return GetByEntCodeMdTypeId(null, _entCodeMdTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_POLICY_METADATA_ED_CODE_MD_TYPE key.
		///		FK_ENT_CODE_POLICY_METADATA_ED_CODE_MD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodePolicyMetadata objects.</returns>
		public abstract TList<EntCodePolicyMetadata> GetByEntCodeMdTypeId(TransactionManager transactionManager, System.Decimal _entCodeMdTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_POLICY_METADATA_ED_CODE_STUDY_METHOD key.
		///		FK_ENT_CODE_POLICY_METADATA_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodePolicyMetadata objects.</returns>
		public TList<EntCodePolicyMetadata> GetByEdCodeStudyMethodId(System.Decimal? _edCodeStudyMethodId)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(_edCodeStudyMethodId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_POLICY_METADATA_ED_CODE_STUDY_METHOD key.
		///		FK_ENT_CODE_POLICY_METADATA_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodePolicyMetadata objects.</returns>
		/// <remarks></remarks>
		public TList<EntCodePolicyMetadata> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(transactionManager, _edCodeStudyMethodId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_POLICY_METADATA_ED_CODE_STUDY_METHOD key.
		///		FK_ENT_CODE_POLICY_METADATA_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodePolicyMetadata objects.</returns>
		public TList<EntCodePolicyMetadata> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(transactionManager, _edCodeStudyMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_POLICY_METADATA_ED_CODE_STUDY_METHOD key.
		///		fkEntCodePolicyMetadataEdCodeStudyMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodePolicyMetadata objects.</returns>
		public TList<EntCodePolicyMetadata> GetByEdCodeStudyMethodId(System.Decimal? _edCodeStudyMethodId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeStudyMethodId(null, _edCodeStudyMethodId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_POLICY_METADATA_ED_CODE_STUDY_METHOD key.
		///		fkEntCodePolicyMetadataEdCodeStudyMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodePolicyMetadata objects.</returns>
		public TList<EntCodePolicyMetadata> GetByEdCodeStudyMethodId(System.Decimal? _edCodeStudyMethodId, int start, int pageLength,out int count)
		{
			return GetByEdCodeStudyMethodId(null, _edCodeStudyMethodId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_POLICY_METADATA_ED_CODE_STUDY_METHOD key.
		///		FK_ENT_CODE_POLICY_METADATA_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodePolicyMetadata objects.</returns>
		public abstract TList<EntCodePolicyMetadata> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_POLICY_METADATA_ENT_CODE_POLICY_CAT key.
		///		FK_ENT_CODE_POLICY_METADATA_ENT_CODE_POLICY_CAT Description: 
		/// </summary>
		/// <param name="_entCodePolicyCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodePolicyMetadata objects.</returns>
		public TList<EntCodePolicyMetadata> GetByEntCodePolicyCatId(System.Decimal? _entCodePolicyCatId)
		{
			int count = -1;
			return GetByEntCodePolicyCatId(_entCodePolicyCatId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_POLICY_METADATA_ENT_CODE_POLICY_CAT key.
		///		FK_ENT_CODE_POLICY_METADATA_ENT_CODE_POLICY_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePolicyCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodePolicyMetadata objects.</returns>
		/// <remarks></remarks>
		public TList<EntCodePolicyMetadata> GetByEntCodePolicyCatId(TransactionManager transactionManager, System.Decimal? _entCodePolicyCatId)
		{
			int count = -1;
			return GetByEntCodePolicyCatId(transactionManager, _entCodePolicyCatId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_POLICY_METADATA_ENT_CODE_POLICY_CAT key.
		///		FK_ENT_CODE_POLICY_METADATA_ENT_CODE_POLICY_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePolicyCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodePolicyMetadata objects.</returns>
		public TList<EntCodePolicyMetadata> GetByEntCodePolicyCatId(TransactionManager transactionManager, System.Decimal? _entCodePolicyCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodePolicyCatId(transactionManager, _entCodePolicyCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_POLICY_METADATA_ENT_CODE_POLICY_CAT key.
		///		fkEntCodePolicyMetadataEntCodePolicyCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCodePolicyCatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodePolicyMetadata objects.</returns>
		public TList<EntCodePolicyMetadata> GetByEntCodePolicyCatId(System.Decimal? _entCodePolicyCatId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntCodePolicyCatId(null, _entCodePolicyCatId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_POLICY_METADATA_ENT_CODE_POLICY_CAT key.
		///		fkEntCodePolicyMetadataEntCodePolicyCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCodePolicyCatId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodePolicyMetadata objects.</returns>
		public TList<EntCodePolicyMetadata> GetByEntCodePolicyCatId(System.Decimal? _entCodePolicyCatId, int start, int pageLength,out int count)
		{
			return GetByEntCodePolicyCatId(null, _entCodePolicyCatId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_POLICY_METADATA_ENT_CODE_POLICY_CAT key.
		///		FK_ENT_CODE_POLICY_METADATA_ENT_CODE_POLICY_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePolicyCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodePolicyMetadata objects.</returns>
		public abstract TList<EntCodePolicyMetadata> GetByEntCodePolicyCatId(TransactionManager transactionManager, System.Decimal? _entCodePolicyCatId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntCodePolicyMetadata Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodePolicyMetadataKey key, int start, int pageLength)
		{
			return GetByEntCodePolicyMdId(transactionManager, key.EntCodePolicyMdId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_POLICIES_METADATA index.
		/// </summary>
		/// <param name="_entCodePolicyMdId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodePolicyMetadata GetByEntCodePolicyMdId(System.Decimal _entCodePolicyMdId)
		{
			int count = -1;
			return GetByEntCodePolicyMdId(null,_entCodePolicyMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_POLICIES_METADATA index.
		/// </summary>
		/// <param name="_entCodePolicyMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodePolicyMetadata GetByEntCodePolicyMdId(System.Decimal _entCodePolicyMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodePolicyMdId(null, _entCodePolicyMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_POLICIES_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePolicyMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodePolicyMetadata GetByEntCodePolicyMdId(TransactionManager transactionManager, System.Decimal _entCodePolicyMdId)
		{
			int count = -1;
			return GetByEntCodePolicyMdId(transactionManager, _entCodePolicyMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_POLICIES_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePolicyMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodePolicyMetadata GetByEntCodePolicyMdId(TransactionManager transactionManager, System.Decimal _entCodePolicyMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodePolicyMdId(transactionManager, _entCodePolicyMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_POLICIES_METADATA index.
		/// </summary>
		/// <param name="_entCodePolicyMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodePolicyMetadata GetByEntCodePolicyMdId(System.Decimal _entCodePolicyMdId, int start, int pageLength, out int count)
		{
			return GetByEntCodePolicyMdId(null, _entCodePolicyMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_POLICIES_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePolicyMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyMetadata"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntCodePolicyMetadata GetByEntCodePolicyMdId(TransactionManager transactionManager, System.Decimal _entCodePolicyMdId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntCodePolicyMetadata&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntCodePolicyMetadata&gt;"/></returns>
		public static TList<EntCodePolicyMetadata> Fill(IDataReader reader, TList<EntCodePolicyMetadata> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntCodePolicyMetadata c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntCodePolicyMetadata")
					.Append("|").Append((System.Decimal)reader["ENT_CODE_POLICY_MD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntCodePolicyMetadata>(
					key.ToString(), // EntityTrackingKey
					"EntCodePolicyMetadata",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntCodePolicyMetadata();
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
					c.EntCodePolicyMdId = (System.Decimal)reader["ENT_CODE_POLICY_MD_ID"];
					c.OriginalEntCodePolicyMdId = c.EntCodePolicyMdId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.TblRltdFlg = (System.Decimal)reader["TBL_RLTD_FLG"];
					c.TblName = Convert.IsDBNull(reader["TBL_NAME"]) ? null : (System.String)reader["TBL_NAME"];
					c.SpChkName = Convert.IsDBNull(reader["SP_CHK_NAME"]) ? null : (System.String)reader["SP_CHK_NAME"];
					c.EntCodeMdTypeId = (System.Decimal)reader["ENT_CODE_MD_TYPE_ID"];
					c.EntCodePolicyCatId = Convert.IsDBNull(reader["ENT_CODE_POLICY_CAT_ID"]) ? null : (System.Decimal?)reader["ENT_CODE_POLICY_CAT_ID"];
					c.EdCodeStudyMethodId = Convert.IsDBNull(reader["ED_CODE_STUDY_METHOD_ID"]) ? null : (System.Decimal?)reader["ED_CODE_STUDY_METHOD_ID"];
					c.DispOrder = Convert.IsDBNull(reader["DISP_ORDER"]) ? null : (System.Decimal?)reader["DISP_ORDER"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyMetadata"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyMetadata"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntCodePolicyMetadata entity)
		{
			if (!reader.Read()) return;
			
			entity.EntCodePolicyMdId = (System.Decimal)reader[((int)EntCodePolicyMetadataColumn.EntCodePolicyMdId - 1)];
			entity.OriginalEntCodePolicyMdId = (System.Decimal)reader["ENT_CODE_POLICY_MD_ID"];
			entity.DescrAr = (System.String)reader[((int)EntCodePolicyMetadataColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EntCodePolicyMetadataColumn.DescrEn - 1)))?null:(System.String)reader[((int)EntCodePolicyMetadataColumn.DescrEn - 1)];
			entity.TblRltdFlg = (System.Decimal)reader[((int)EntCodePolicyMetadataColumn.TblRltdFlg - 1)];
			entity.TblName = (reader.IsDBNull(((int)EntCodePolicyMetadataColumn.TblName - 1)))?null:(System.String)reader[((int)EntCodePolicyMetadataColumn.TblName - 1)];
			entity.SpChkName = (reader.IsDBNull(((int)EntCodePolicyMetadataColumn.SpChkName - 1)))?null:(System.String)reader[((int)EntCodePolicyMetadataColumn.SpChkName - 1)];
			entity.EntCodeMdTypeId = (System.Decimal)reader[((int)EntCodePolicyMetadataColumn.EntCodeMdTypeId - 1)];
			entity.EntCodePolicyCatId = (reader.IsDBNull(((int)EntCodePolicyMetadataColumn.EntCodePolicyCatId - 1)))?null:(System.Decimal?)reader[((int)EntCodePolicyMetadataColumn.EntCodePolicyCatId - 1)];
			entity.EdCodeStudyMethodId = (reader.IsDBNull(((int)EntCodePolicyMetadataColumn.EdCodeStudyMethodId - 1)))?null:(System.Decimal?)reader[((int)EntCodePolicyMetadataColumn.EdCodeStudyMethodId - 1)];
			entity.DispOrder = (reader.IsDBNull(((int)EntCodePolicyMetadataColumn.DispOrder - 1)))?null:(System.Decimal?)reader[((int)EntCodePolicyMetadataColumn.DispOrder - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyMetadata"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyMetadata"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntCodePolicyMetadata entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntCodePolicyMdId = (System.Decimal)dataRow["ENT_CODE_POLICY_MD_ID"];
			entity.OriginalEntCodePolicyMdId = (System.Decimal)dataRow["ENT_CODE_POLICY_MD_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.TblRltdFlg = (System.Decimal)dataRow["TBL_RLTD_FLG"];
			entity.TblName = Convert.IsDBNull(dataRow["TBL_NAME"]) ? null : (System.String)dataRow["TBL_NAME"];
			entity.SpChkName = Convert.IsDBNull(dataRow["SP_CHK_NAME"]) ? null : (System.String)dataRow["SP_CHK_NAME"];
			entity.EntCodeMdTypeId = (System.Decimal)dataRow["ENT_CODE_MD_TYPE_ID"];
			entity.EntCodePolicyCatId = Convert.IsDBNull(dataRow["ENT_CODE_POLICY_CAT_ID"]) ? null : (System.Decimal?)dataRow["ENT_CODE_POLICY_CAT_ID"];
			entity.EdCodeStudyMethodId = Convert.IsDBNull(dataRow["ED_CODE_STUDY_METHOD_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_STUDY_METHOD_ID"];
			entity.DispOrder = Convert.IsDBNull(dataRow["DISP_ORDER"]) ? null : (System.Decimal?)dataRow["DISP_ORDER"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyMetadata"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCodePolicyMetadata Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodePolicyMetadata entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EntCodeMdTypeIdSource	
			if (CanDeepLoad(entity, "EntCodeMdType|EntCodeMdTypeIdSource", deepLoadType, innerList) 
				&& entity.EntCodeMdTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntCodeMdTypeId;
				EntCodeMdType tmpEntity = EntityManager.LocateEntity<EntCodeMdType>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCodeMdType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCodeMdTypeIdSource = tmpEntity;
				else
					entity.EntCodeMdTypeIdSource = DataRepository.EntCodeMdTypeProvider.GetByEntCodeMdTypeId(transactionManager, entity.EntCodeMdTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodeMdTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCodeMdTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCodeMdTypeProvider.DeepLoad(transactionManager, entity.EntCodeMdTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCodeMdTypeIdSource

			#region EdCodeStudyMethodIdSource	
			if (CanDeepLoad(entity, "EdCodeStudyMethod|EdCodeStudyMethodIdSource", deepLoadType, innerList) 
				&& entity.EdCodeStudyMethodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeStudyMethodId ?? 0.0m);
				EdCodeStudyMethod tmpEntity = EntityManager.LocateEntity<EdCodeStudyMethod>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeStudyMethod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeStudyMethodIdSource = tmpEntity;
				else
					entity.EdCodeStudyMethodIdSource = DataRepository.EdCodeStudyMethodProvider.GetByEdCodeStudyMethodId(transactionManager, (entity.EdCodeStudyMethodId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeStudyMethodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeStudyMethodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeStudyMethodProvider.DeepLoad(transactionManager, entity.EdCodeStudyMethodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeStudyMethodIdSource

			#region EntCodePolicyCatIdSource	
			if (CanDeepLoad(entity, "EntCodePolicyCat|EntCodePolicyCatIdSource", deepLoadType, innerList) 
				&& entity.EntCodePolicyCatIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntCodePolicyCatId ?? 0.0m);
				EntCodePolicyCat tmpEntity = EntityManager.LocateEntity<EntCodePolicyCat>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCodePolicyCat), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCodePolicyCatIdSource = tmpEntity;
				else
					entity.EntCodePolicyCatIdSource = DataRepository.EntCodePolicyCatProvider.GetByEntCodePolicyCatId(transactionManager, (entity.EntCodePolicyCatId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodePolicyCatIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCodePolicyCatIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCodePolicyCatProvider.DeepLoad(transactionManager, entity.EntCodePolicyCatIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCodePolicyCatIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntCodePolicyMdId methods when available
			
			#region EntPolicyMetadataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyMetadata>|EntPolicyMetadataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyMetadataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyMetadataCollection = DataRepository.EntPolicyMetadataProvider.GetByEntCodePolicyMdId(transactionManager, entity.EntCodePolicyMdId);

				if (deep && entity.EntPolicyMetadataCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyMetadata>) DataRepository.EntPolicyMetadataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyMetadataCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntCodePolicyMetadata object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntCodePolicyMetadata instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCodePolicyMetadata Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodePolicyMetadata entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EntCodeMdTypeIdSource
			if (CanDeepSave(entity, "EntCodeMdType|EntCodeMdTypeIdSource", deepSaveType, innerList) 
				&& entity.EntCodeMdTypeIdSource != null)
			{
				DataRepository.EntCodeMdTypeProvider.Save(transactionManager, entity.EntCodeMdTypeIdSource);
				entity.EntCodeMdTypeId = entity.EntCodeMdTypeIdSource.EntCodeMdTypeId;
			}
			#endregion 
			
			#region EdCodeStudyMethodIdSource
			if (CanDeepSave(entity, "EdCodeStudyMethod|EdCodeStudyMethodIdSource", deepSaveType, innerList) 
				&& entity.EdCodeStudyMethodIdSource != null)
			{
				DataRepository.EdCodeStudyMethodProvider.Save(transactionManager, entity.EdCodeStudyMethodIdSource);
				entity.EdCodeStudyMethodId = entity.EdCodeStudyMethodIdSource.EdCodeStudyMethodId;
			}
			#endregion 
			
			#region EntCodePolicyCatIdSource
			if (CanDeepSave(entity, "EntCodePolicyCat|EntCodePolicyCatIdSource", deepSaveType, innerList) 
				&& entity.EntCodePolicyCatIdSource != null)
			{
				DataRepository.EntCodePolicyCatProvider.Save(transactionManager, entity.EntCodePolicyCatIdSource);
				entity.EntCodePolicyCatId = entity.EntCodePolicyCatIdSource.EntCodePolicyCatId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EntPolicyMetadata>
				if (CanDeepSave(entity.EntPolicyMetadataCollection, "List<EntPolicyMetadata>|EntPolicyMetadataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyMetadata child in entity.EntPolicyMetadataCollection)
					{
						if(child.EntCodePolicyMdIdSource != null)
						{
							child.EntCodePolicyMdId = child.EntCodePolicyMdIdSource.EntCodePolicyMdId;
						}
						else
						{
							child.EntCodePolicyMdId = entity.EntCodePolicyMdId;
						}

					}

					if (entity.EntPolicyMetadataCollection.Count > 0 || entity.EntPolicyMetadataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyMetadataProvider.Save(transactionManager, entity.EntPolicyMetadataCollection);
						
						deepHandles.Add("EntPolicyMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyMetadata >) DataRepository.EntPolicyMetadataProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyMetadataCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntCodePolicyMetadataChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntCodePolicyMetadata</c>
	///</summary>
	public enum EntCodePolicyMetadataChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EntCodeMdType</c> at EntCodeMdTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodeMdType))]
		EntCodeMdType,
		
		///<summary>
		/// Composite Property for <c>EdCodeStudyMethod</c> at EdCodeStudyMethodIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeStudyMethod))]
		EdCodeStudyMethod,
		
		///<summary>
		/// Composite Property for <c>EntCodePolicyCat</c> at EntCodePolicyCatIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodePolicyCat))]
		EntCodePolicyCat,
		///<summary>
		/// Collection of <c>EntCodePolicyMetadata</c> as OneToMany for EntPolicyMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyMetadata>))]
		EntPolicyMetadataCollection,
	}
	
	#endregion EntCodePolicyMetadataChildEntityTypes
	
	#region EntCodePolicyMetadataFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntCodePolicyMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCodePolicyMetadata"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCodePolicyMetadataFilterBuilder : SqlFilterBuilder<EntCodePolicyMetadataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCodePolicyMetadataFilterBuilder class.
		/// </summary>
		public EntCodePolicyMetadataFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCodePolicyMetadataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCodePolicyMetadataFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCodePolicyMetadataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCodePolicyMetadataFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCodePolicyMetadataFilterBuilder
	
	#region EntCodePolicyMetadataParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntCodePolicyMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCodePolicyMetadata"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCodePolicyMetadataParameterBuilder : ParameterizedSqlFilterBuilder<EntCodePolicyMetadataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCodePolicyMetadataParameterBuilder class.
		/// </summary>
		public EntCodePolicyMetadataParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCodePolicyMetadataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCodePolicyMetadataParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCodePolicyMetadataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCodePolicyMetadataParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCodePolicyMetadataParameterBuilder
	
	#region EntCodePolicyMetadataSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntCodePolicyMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCodePolicyMetadata"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntCodePolicyMetadataSortBuilder : SqlSortBuilder<EntCodePolicyMetadataColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCodePolicyMetadataSqlSortBuilder class.
		/// </summary>
		public EntCodePolicyMetadataSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntCodePolicyMetadataSortBuilder
	
} // end namespace
