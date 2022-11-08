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
	/// This class is the base class for any <see cref="EntCodeFullfillMetadataProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntCodeFullfillMetadataProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata, UMIS_VER2.BusinessLyer.EntCodeFullfillMetadataKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeFullfillMetadataKey key)
		{
			return Delete(transactionManager, key.EntCodeFuulfillMdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entCodeFuulfillMdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entCodeFuulfillMdId)
		{
			return Delete(null, _entCodeFuulfillMdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeFuulfillMdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entCodeFuulfillMdId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_FULLFILL_METADATA_AS_CODE_DEGREE_CLASS key.
		///		FK_ENT_CODE_FULLFILL_METADATA_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata objects.</returns>
		public TList<EntCodeFullfillMetadata> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_FULLFILL_METADATA_AS_CODE_DEGREE_CLASS key.
		///		FK_ENT_CODE_FULLFILL_METADATA_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata objects.</returns>
		/// <remarks></remarks>
		public TList<EntCodeFullfillMetadata> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_FULLFILL_METADATA_AS_CODE_DEGREE_CLASS key.
		///		FK_ENT_CODE_FULLFILL_METADATA_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata objects.</returns>
		public TList<EntCodeFullfillMetadata> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_FULLFILL_METADATA_AS_CODE_DEGREE_CLASS key.
		///		fkEntCodeFullfillMetadataAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata objects.</returns>
		public TList<EntCodeFullfillMetadata> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_FULLFILL_METADATA_AS_CODE_DEGREE_CLASS key.
		///		fkEntCodeFullfillMetadataAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata objects.</returns>
		public TList<EntCodeFullfillMetadata> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_FULLFILL_METADATA_AS_CODE_DEGREE_CLASS key.
		///		FK_ENT_CODE_FULLFILL_METADATA_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata objects.</returns>
		public abstract TList<EntCodeFullfillMetadata> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_MD_TYPE key.
		///		FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_MD_TYPE Description: 
		/// </summary>
		/// <param name="_entCodeMdTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata objects.</returns>
		public TList<EntCodeFullfillMetadata> GetByEntCodeMdTypeId(System.Decimal _entCodeMdTypeId)
		{
			int count = -1;
			return GetByEntCodeMdTypeId(_entCodeMdTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_MD_TYPE key.
		///		FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_MD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata objects.</returns>
		/// <remarks></remarks>
		public TList<EntCodeFullfillMetadata> GetByEntCodeMdTypeId(TransactionManager transactionManager, System.Decimal _entCodeMdTypeId)
		{
			int count = -1;
			return GetByEntCodeMdTypeId(transactionManager, _entCodeMdTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_MD_TYPE key.
		///		FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_MD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata objects.</returns>
		public TList<EntCodeFullfillMetadata> GetByEntCodeMdTypeId(TransactionManager transactionManager, System.Decimal _entCodeMdTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeMdTypeId(transactionManager, _entCodeMdTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_MD_TYPE key.
		///		fkEntCodeFullfillMetadataEdCodeMdType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata objects.</returns>
		public TList<EntCodeFullfillMetadata> GetByEntCodeMdTypeId(System.Decimal _entCodeMdTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntCodeMdTypeId(null, _entCodeMdTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_MD_TYPE key.
		///		fkEntCodeFullfillMetadataEdCodeMdType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata objects.</returns>
		public TList<EntCodeFullfillMetadata> GetByEntCodeMdTypeId(System.Decimal _entCodeMdTypeId, int start, int pageLength,out int count)
		{
			return GetByEntCodeMdTypeId(null, _entCodeMdTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_MD_TYPE key.
		///		FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_MD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata objects.</returns>
		public abstract TList<EntCodeFullfillMetadata> GetByEntCodeMdTypeId(TransactionManager transactionManager, System.Decimal _entCodeMdTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_STUDY_METHOD key.
		///		FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata objects.</returns>
		public TList<EntCodeFullfillMetadata> GetByEdCodeStudyMethodId(System.Decimal? _edCodeStudyMethodId)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(_edCodeStudyMethodId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_STUDY_METHOD key.
		///		FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata objects.</returns>
		/// <remarks></remarks>
		public TList<EntCodeFullfillMetadata> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(transactionManager, _edCodeStudyMethodId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_STUDY_METHOD key.
		///		FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata objects.</returns>
		public TList<EntCodeFullfillMetadata> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(transactionManager, _edCodeStudyMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_STUDY_METHOD key.
		///		fkEntCodeFullfillMetadataEdCodeStudyMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata objects.</returns>
		public TList<EntCodeFullfillMetadata> GetByEdCodeStudyMethodId(System.Decimal? _edCodeStudyMethodId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeStudyMethodId(null, _edCodeStudyMethodId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_STUDY_METHOD key.
		///		fkEntCodeFullfillMetadataEdCodeStudyMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata objects.</returns>
		public TList<EntCodeFullfillMetadata> GetByEdCodeStudyMethodId(System.Decimal? _edCodeStudyMethodId, int start, int pageLength,out int count)
		{
			return GetByEdCodeStudyMethodId(null, _edCodeStudyMethodId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_STUDY_METHOD key.
		///		FK_ENT_CODE_FULLFILL_METADATA_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata objects.</returns>
		public abstract TList<EntCodeFullfillMetadata> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeFullfillMetadataKey key, int start, int pageLength)
		{
			return GetByEntCodeFuulfillMdId(transactionManager, key.EntCodeFuulfillMdId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FULLFILL_REQ_METADATA index.
		/// </summary>
		/// <param name="_entCodeFuulfillMdId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata GetByEntCodeFuulfillMdId(System.Decimal _entCodeFuulfillMdId)
		{
			int count = -1;
			return GetByEntCodeFuulfillMdId(null,_entCodeFuulfillMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FULLFILL_REQ_METADATA index.
		/// </summary>
		/// <param name="_entCodeFuulfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata GetByEntCodeFuulfillMdId(System.Decimal _entCodeFuulfillMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeFuulfillMdId(null, _entCodeFuulfillMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FULLFILL_REQ_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeFuulfillMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata GetByEntCodeFuulfillMdId(TransactionManager transactionManager, System.Decimal _entCodeFuulfillMdId)
		{
			int count = -1;
			return GetByEntCodeFuulfillMdId(transactionManager, _entCodeFuulfillMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FULLFILL_REQ_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeFuulfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata GetByEntCodeFuulfillMdId(TransactionManager transactionManager, System.Decimal _entCodeFuulfillMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeFuulfillMdId(transactionManager, _entCodeFuulfillMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FULLFILL_REQ_METADATA index.
		/// </summary>
		/// <param name="_entCodeFuulfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata GetByEntCodeFuulfillMdId(System.Decimal _entCodeFuulfillMdId, int start, int pageLength, out int count)
		{
			return GetByEntCodeFuulfillMdId(null, _entCodeFuulfillMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FULLFILL_REQ_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeFuulfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata GetByEntCodeFuulfillMdId(TransactionManager transactionManager, System.Decimal _entCodeFuulfillMdId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntCodeFullfillMetadata&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntCodeFullfillMetadata&gt;"/></returns>
		public static TList<EntCodeFullfillMetadata> Fill(IDataReader reader, TList<EntCodeFullfillMetadata> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntCodeFullfillMetadata")
					.Append("|").Append((System.Decimal)reader["ENT_CODE_FUULFILL_MD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntCodeFullfillMetadata>(
					key.ToString(), // EntityTrackingKey
					"EntCodeFullfillMetadata",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata();
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
					c.EntCodeFuulfillMdId = (System.Decimal)reader["ENT_CODE_FUULFILL_MD_ID"];
					c.OriginalEntCodeFuulfillMdId = c.EntCodeFuulfillMdId;
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.TblRltdFlg = (System.Decimal)reader["TBL_RLTD_FLG"];
					c.TblName = Convert.IsDBNull(reader["TBL_NAME"]) ? null : (System.String)reader["TBL_NAME"];
					c.SpChkName = Convert.IsDBNull(reader["SP_CHK_NAME"]) ? null : (System.String)reader["SP_CHK_NAME"];
					c.EntCodeMdTypeId = (System.Decimal)reader["ENT_CODE_MD_TYPE_ID"];
					c.EdCodeStudyMethodId = Convert.IsDBNull(reader["ED_CODE_STUDY_METHOD_ID"]) ? null : (System.Decimal?)reader["ED_CODE_STUDY_METHOD_ID"];
					c.DispOrder = Convert.IsDBNull(reader["DISP_ORDER"]) ? null : (System.Decimal?)reader["DISP_ORDER"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata entity)
		{
			if (!reader.Read()) return;
			
			entity.EntCodeFuulfillMdId = (System.Decimal)reader[((int)EntCodeFullfillMetadataColumn.EntCodeFuulfillMdId - 1)];
			entity.OriginalEntCodeFuulfillMdId = (System.Decimal)reader["ENT_CODE_FUULFILL_MD_ID"];
			entity.DescrAr = (reader.IsDBNull(((int)EntCodeFullfillMetadataColumn.DescrAr - 1)))?null:(System.String)reader[((int)EntCodeFullfillMetadataColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EntCodeFullfillMetadataColumn.DescrEn - 1)))?null:(System.String)reader[((int)EntCodeFullfillMetadataColumn.DescrEn - 1)];
			entity.TblRltdFlg = (System.Decimal)reader[((int)EntCodeFullfillMetadataColumn.TblRltdFlg - 1)];
			entity.TblName = (reader.IsDBNull(((int)EntCodeFullfillMetadataColumn.TblName - 1)))?null:(System.String)reader[((int)EntCodeFullfillMetadataColumn.TblName - 1)];
			entity.SpChkName = (reader.IsDBNull(((int)EntCodeFullfillMetadataColumn.SpChkName - 1)))?null:(System.String)reader[((int)EntCodeFullfillMetadataColumn.SpChkName - 1)];
			entity.EntCodeMdTypeId = (System.Decimal)reader[((int)EntCodeFullfillMetadataColumn.EntCodeMdTypeId - 1)];
			entity.EdCodeStudyMethodId = (reader.IsDBNull(((int)EntCodeFullfillMetadataColumn.EdCodeStudyMethodId - 1)))?null:(System.Decimal?)reader[((int)EntCodeFullfillMetadataColumn.EdCodeStudyMethodId - 1)];
			entity.DispOrder = (reader.IsDBNull(((int)EntCodeFullfillMetadataColumn.DispOrder - 1)))?null:(System.Decimal?)reader[((int)EntCodeFullfillMetadataColumn.DispOrder - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)EntCodeFullfillMetadataColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)EntCodeFullfillMetadataColumn.AsCodeDegreeClassId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntCodeFuulfillMdId = (System.Decimal)dataRow["ENT_CODE_FUULFILL_MD_ID"];
			entity.OriginalEntCodeFuulfillMdId = (System.Decimal)dataRow["ENT_CODE_FUULFILL_MD_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.TblRltdFlg = (System.Decimal)dataRow["TBL_RLTD_FLG"];
			entity.TblName = Convert.IsDBNull(dataRow["TBL_NAME"]) ? null : (System.String)dataRow["TBL_NAME"];
			entity.SpChkName = Convert.IsDBNull(dataRow["SP_CHK_NAME"]) ? null : (System.String)dataRow["SP_CHK_NAME"];
			entity.EntCodeMdTypeId = (System.Decimal)dataRow["ENT_CODE_MD_TYPE_ID"];
			entity.EdCodeStudyMethodId = Convert.IsDBNull(dataRow["ED_CODE_STUDY_METHOD_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_STUDY_METHOD_ID"];
			entity.DispOrder = Convert.IsDBNull(dataRow["DISP_ORDER"]) ? null : (System.Decimal?)dataRow["DISP_ORDER"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsCodeDegreeClassIdSource	
			if (CanDeepLoad(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeClassIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeClassId ?? 0.0m);
				AsCodeDegreeClass tmpEntity = EntityManager.LocateEntity<AsCodeDegreeClass>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegreeClass), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeClassIdSource = tmpEntity;
				else
					entity.AsCodeDegreeClassIdSource = DataRepository.AsCodeDegreeClassProvider.GetByAsCodeDegreeClassId(transactionManager, (entity.AsCodeDegreeClassId ?? 0.0m));		
				
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntCodeFuulfillMdId methods when available
			
			#region EntFullfillMetadataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntFullfillMetadata>|EntFullfillMetadataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntFullfillMetadataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntFullfillMetadataCollection = DataRepository.EntFullfillMetadataProvider.GetByEntCodeFullfillMdId(transactionManager, entity.EntCodeFuulfillMdId);

				if (deep && entity.EntFullfillMetadataCollection.Count > 0)
				{
					deepHandles.Add("EntFullfillMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntFullfillMetadata>) DataRepository.EntFullfillMetadataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntFullfillMetadataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCourseMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCourseMdData>|EntCourseMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCourseMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCourseMdDataCollection = DataRepository.EntCourseMdDataProvider.GetByEntCodeFullfillMdId(transactionManager, entity.EntCodeFuulfillMdId);

				if (deep && entity.EntCourseMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntCourseMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCourseMdData>) DataRepository.EntCourseMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCourseMdDataCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsCodeDegreeClassIdSource
			if (CanDeepSave(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeClassIdSource != null)
			{
				DataRepository.AsCodeDegreeClassProvider.Save(transactionManager, entity.AsCodeDegreeClassIdSource);
				entity.AsCodeDegreeClassId = entity.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
			}
			#endregion 
			
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EntFullfillMetadata>
				if (CanDeepSave(entity.EntFullfillMetadataCollection, "List<EntFullfillMetadata>|EntFullfillMetadataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntFullfillMetadata child in entity.EntFullfillMetadataCollection)
					{
						if(child.EntCodeFullfillMdIdSource != null)
						{
							child.EntCodeFullfillMdId = child.EntCodeFullfillMdIdSource.EntCodeFuulfillMdId;
						}
						else
						{
							child.EntCodeFullfillMdId = entity.EntCodeFuulfillMdId;
						}

					}

					if (entity.EntFullfillMetadataCollection.Count > 0 || entity.EntFullfillMetadataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntFullfillMetadataProvider.Save(transactionManager, entity.EntFullfillMetadataCollection);
						
						deepHandles.Add("EntFullfillMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntFullfillMetadata >) DataRepository.EntFullfillMetadataProvider.DeepSave,
							new object[] { transactionManager, entity.EntFullfillMetadataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCourseMdData>
				if (CanDeepSave(entity.EntCourseMdDataCollection, "List<EntCourseMdData>|EntCourseMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCourseMdData child in entity.EntCourseMdDataCollection)
					{
						if(child.EntCodeFullfillMdIdSource != null)
						{
							child.EntCodeFullfillMdId = child.EntCodeFullfillMdIdSource.EntCodeFuulfillMdId;
						}
						else
						{
							child.EntCodeFullfillMdId = entity.EntCodeFuulfillMdId;
						}

					}

					if (entity.EntCourseMdDataCollection.Count > 0 || entity.EntCourseMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntCourseMdDataProvider.Save(transactionManager, entity.EntCourseMdDataCollection);
						
						deepHandles.Add("EntCourseMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCourseMdData >) DataRepository.EntCourseMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntCourseMdDataCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntCodeFullfillMetadataChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntCodeFullfillMetadata</c>
	///</summary>
	public enum EntCodeFullfillMetadataChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		
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
		/// Collection of <c>EntCodeFullfillMetadata</c> as OneToMany for EntFullfillMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntFullfillMetadata>))]
		EntFullfillMetadataCollection,
		///<summary>
		/// Collection of <c>EntCodeFullfillMetadata</c> as OneToMany for EntCourseMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCourseMdData>))]
		EntCourseMdDataCollection,
	}
	
	#endregion EntCodeFullfillMetadataChildEntityTypes
	
	#region EntCodeFullfillMetadataFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntCodeFullfillMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCodeFullfillMetadata"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCodeFullfillMetadataFilterBuilder : SqlFilterBuilder<EntCodeFullfillMetadataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCodeFullfillMetadataFilterBuilder class.
		/// </summary>
		public EntCodeFullfillMetadataFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCodeFullfillMetadataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCodeFullfillMetadataFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCodeFullfillMetadataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCodeFullfillMetadataFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCodeFullfillMetadataFilterBuilder
	
	#region EntCodeFullfillMetadataParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntCodeFullfillMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCodeFullfillMetadata"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCodeFullfillMetadataParameterBuilder : ParameterizedSqlFilterBuilder<EntCodeFullfillMetadataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCodeFullfillMetadataParameterBuilder class.
		/// </summary>
		public EntCodeFullfillMetadataParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCodeFullfillMetadataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCodeFullfillMetadataParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCodeFullfillMetadataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCodeFullfillMetadataParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCodeFullfillMetadataParameterBuilder
	
	#region EntCodeFullfillMetadataSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntCodeFullfillMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCodeFullfillMetadata"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntCodeFullfillMetadataSortBuilder : SqlSortBuilder<EntCodeFullfillMetadataColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCodeFullfillMetadataSqlSortBuilder class.
		/// </summary>
		public EntCodeFullfillMetadataSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntCodeFullfillMetadataSortBuilder
	
} // end namespace
