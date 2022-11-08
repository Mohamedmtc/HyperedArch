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
	/// This class is the base class for any <see cref="EdCodeQualSubjectProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeQualSubjectProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeQualSubject, UMIS_VER2.BusinessLyer.EdCodeQualSubjectKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeQualSubjectKey key)
		{
			return Delete(transactionManager, key.EdCodeQualSubjectId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeQualSubjectId">مقررات مجموعة المؤهل. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeQualSubjectId)
		{
			return Delete(null, _edCodeQualSubjectId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualSubjectId">مقررات مجموعة المؤهل. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeQualSubjectId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_SUBJECT_ED_CDE_QUAL_BRN key.
		///		FK_ED_CODE_QUAL_SUBJECT_ED_CDE_QUAL_BRN Description: 
		/// </summary>
		/// <param name="_edCodeQualBranId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualSubject objects.</returns>
		public TList<EdCodeQualSubject> GetByEdCodeQualBranId(System.Decimal? _edCodeQualBranId)
		{
			int count = -1;
			return GetByEdCodeQualBranId(_edCodeQualBranId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_SUBJECT_ED_CDE_QUAL_BRN key.
		///		FK_ED_CODE_QUAL_SUBJECT_ED_CDE_QUAL_BRN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualBranId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualSubject objects.</returns>
		/// <remarks></remarks>
		public TList<EdCodeQualSubject> GetByEdCodeQualBranId(TransactionManager transactionManager, System.Decimal? _edCodeQualBranId)
		{
			int count = -1;
			return GetByEdCodeQualBranId(transactionManager, _edCodeQualBranId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_SUBJECT_ED_CDE_QUAL_BRN key.
		///		FK_ED_CODE_QUAL_SUBJECT_ED_CDE_QUAL_BRN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualBranId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualSubject objects.</returns>
		public TList<EdCodeQualSubject> GetByEdCodeQualBranId(TransactionManager transactionManager, System.Decimal? _edCodeQualBranId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeQualBranId(transactionManager, _edCodeQualBranId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_SUBJECT_ED_CDE_QUAL_BRN key.
		///		fkEdCodeQualSubjectEdCdeQualBrn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualBranId">XXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualSubject objects.</returns>
		public TList<EdCodeQualSubject> GetByEdCodeQualBranId(System.Decimal? _edCodeQualBranId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeQualBranId(null, _edCodeQualBranId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_SUBJECT_ED_CDE_QUAL_BRN key.
		///		fkEdCodeQualSubjectEdCdeQualBrn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualBranId">XXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualSubject objects.</returns>
		public TList<EdCodeQualSubject> GetByEdCodeQualBranId(System.Decimal? _edCodeQualBranId, int start, int pageLength,out int count)
		{
			return GetByEdCodeQualBranId(null, _edCodeQualBranId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_SUBJECT_ED_CDE_QUAL_BRN key.
		///		FK_ED_CODE_QUAL_SUBJECT_ED_CDE_QUAL_BRN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualBranId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualSubject objects.</returns>
		public abstract TList<EdCodeQualSubject> GetByEdCodeQualBranId(TransactionManager transactionManager, System.Decimal? _edCodeQualBranId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_SUBJECT_ED_CODE_QUAL_GROUP key.
		///		FK_ED_CODE_QUAL_SUBJECT_ED_CODE_QUAL_GROUP Description: 
		/// </summary>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualSubject objects.</returns>
		public TList<EdCodeQualSubject> GetByEdCodeQualGroupId(System.Decimal? _edCodeQualGroupId)
		{
			int count = -1;
			return GetByEdCodeQualGroupId(_edCodeQualGroupId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_SUBJECT_ED_CODE_QUAL_GROUP key.
		///		FK_ED_CODE_QUAL_SUBJECT_ED_CODE_QUAL_GROUP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualSubject objects.</returns>
		/// <remarks></remarks>
		public TList<EdCodeQualSubject> GetByEdCodeQualGroupId(TransactionManager transactionManager, System.Decimal? _edCodeQualGroupId)
		{
			int count = -1;
			return GetByEdCodeQualGroupId(transactionManager, _edCodeQualGroupId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_SUBJECT_ED_CODE_QUAL_GROUP key.
		///		FK_ED_CODE_QUAL_SUBJECT_ED_CODE_QUAL_GROUP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualSubject objects.</returns>
		public TList<EdCodeQualSubject> GetByEdCodeQualGroupId(TransactionManager transactionManager, System.Decimal? _edCodeQualGroupId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeQualGroupId(transactionManager, _edCodeQualGroupId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_SUBJECT_ED_CODE_QUAL_GROUP key.
		///		fkEdCodeQualSubjectEdCodeQualGroup Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualSubject objects.</returns>
		public TList<EdCodeQualSubject> GetByEdCodeQualGroupId(System.Decimal? _edCodeQualGroupId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeQualGroupId(null, _edCodeQualGroupId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_SUBJECT_ED_CODE_QUAL_GROUP key.
		///		fkEdCodeQualSubjectEdCodeQualGroup Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualSubject objects.</returns>
		public TList<EdCodeQualSubject> GetByEdCodeQualGroupId(System.Decimal? _edCodeQualGroupId, int start, int pageLength,out int count)
		{
			return GetByEdCodeQualGroupId(null, _edCodeQualGroupId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_SUBJECT_ED_CODE_QUAL_GROUP key.
		///		FK_ED_CODE_QUAL_SUBJECT_ED_CODE_QUAL_GROUP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualSubject objects.</returns>
		public abstract TList<EdCodeQualSubject> GetByEdCodeQualGroupId(TransactionManager transactionManager, System.Decimal? _edCodeQualGroupId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_SUBJECT_ED_CODE_SUBJECT key.
		///		FK_ED_CODE_QUAL_SUBJECT_ED_CODE_SUBJECT Description: 
		/// </summary>
		/// <param name="_edCodeSubjectId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualSubject objects.</returns>
		public TList<EdCodeQualSubject> GetByEdCodeSubjectId(System.Int32 _edCodeSubjectId)
		{
			int count = -1;
			return GetByEdCodeSubjectId(_edCodeSubjectId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_SUBJECT_ED_CODE_SUBJECT key.
		///		FK_ED_CODE_QUAL_SUBJECT_ED_CODE_SUBJECT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSubjectId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualSubject objects.</returns>
		/// <remarks></remarks>
		public TList<EdCodeQualSubject> GetByEdCodeSubjectId(TransactionManager transactionManager, System.Int32 _edCodeSubjectId)
		{
			int count = -1;
			return GetByEdCodeSubjectId(transactionManager, _edCodeSubjectId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_SUBJECT_ED_CODE_SUBJECT key.
		///		FK_ED_CODE_QUAL_SUBJECT_ED_CODE_SUBJECT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSubjectId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualSubject objects.</returns>
		public TList<EdCodeQualSubject> GetByEdCodeSubjectId(TransactionManager transactionManager, System.Int32 _edCodeSubjectId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSubjectId(transactionManager, _edCodeSubjectId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_SUBJECT_ED_CODE_SUBJECT key.
		///		fkEdCodeQualSubjectEdCodeSubject Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSubjectId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualSubject objects.</returns>
		public TList<EdCodeQualSubject> GetByEdCodeSubjectId(System.Int32 _edCodeSubjectId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSubjectId(null, _edCodeSubjectId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_SUBJECT_ED_CODE_SUBJECT key.
		///		fkEdCodeQualSubjectEdCodeSubject Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSubjectId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualSubject objects.</returns>
		public TList<EdCodeQualSubject> GetByEdCodeSubjectId(System.Int32 _edCodeSubjectId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSubjectId(null, _edCodeSubjectId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_SUBJECT_ED_CODE_SUBJECT key.
		///		FK_ED_CODE_QUAL_SUBJECT_ED_CODE_SUBJECT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSubjectId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQualSubject objects.</returns>
		public abstract TList<EdCodeQualSubject> GetByEdCodeSubjectId(TransactionManager transactionManager, System.Int32 _edCodeSubjectId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeQualSubject Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeQualSubjectKey key, int start, int pageLength)
		{
			return GetByEdCodeQualSubjectId(transactionManager, key.EdCodeQualSubjectId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_QUAL_SUBJECT index.
		/// </summary>
		/// <param name="_edCodeQualSubjectId">مقررات مجموعة المؤهل</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQualSubject"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQualSubject GetByEdCodeQualSubjectId(System.Decimal _edCodeQualSubjectId)
		{
			int count = -1;
			return GetByEdCodeQualSubjectId(null,_edCodeQualSubjectId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_QUAL_SUBJECT index.
		/// </summary>
		/// <param name="_edCodeQualSubjectId">مقررات مجموعة المؤهل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQualSubject"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQualSubject GetByEdCodeQualSubjectId(System.Decimal _edCodeQualSubjectId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeQualSubjectId(null, _edCodeQualSubjectId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_QUAL_SUBJECT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualSubjectId">مقررات مجموعة المؤهل</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQualSubject"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQualSubject GetByEdCodeQualSubjectId(TransactionManager transactionManager, System.Decimal _edCodeQualSubjectId)
		{
			int count = -1;
			return GetByEdCodeQualSubjectId(transactionManager, _edCodeQualSubjectId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_QUAL_SUBJECT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualSubjectId">مقررات مجموعة المؤهل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQualSubject"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQualSubject GetByEdCodeQualSubjectId(TransactionManager transactionManager, System.Decimal _edCodeQualSubjectId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeQualSubjectId(transactionManager, _edCodeQualSubjectId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_QUAL_SUBJECT index.
		/// </summary>
		/// <param name="_edCodeQualSubjectId">مقررات مجموعة المؤهل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQualSubject"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQualSubject GetByEdCodeQualSubjectId(System.Decimal _edCodeQualSubjectId, int start, int pageLength, out int count)
		{
			return GetByEdCodeQualSubjectId(null, _edCodeQualSubjectId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_QUAL_SUBJECT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualSubjectId">مقررات مجموعة المؤهل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQualSubject"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeQualSubject GetByEdCodeQualSubjectId(TransactionManager transactionManager, System.Decimal _edCodeQualSubjectId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeQualSubject&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeQualSubject&gt;"/></returns>
		public static TList<EdCodeQualSubject> Fill(IDataReader reader, TList<EdCodeQualSubject> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeQualSubject c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeQualSubject")
					.Append("|").Append((System.Decimal)reader["ED_CODE_QUAL_SUBJECT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeQualSubject>(
					key.ToString(), // EntityTrackingKey
					"EdCodeQualSubject",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeQualSubject();
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
					c.EdCodeQualSubjectId = (System.Decimal)reader["ED_CODE_QUAL_SUBJECT_ID"];
					c.OriginalEdCodeQualSubjectId = c.EdCodeQualSubjectId;
					c.EdCodeQualGroupId = Convert.IsDBNull(reader["ED_CODE_QUAL_GROUP_ID"]) ? null : (System.Decimal?)reader["ED_CODE_QUAL_GROUP_ID"];
					c.EdCodeQualBranId = Convert.IsDBNull(reader["ED_CODE_QUAL_BRAN_ID"]) ? null : (System.Decimal?)reader["ED_CODE_QUAL_BRAN_ID"];
					c.EdCodeSubjectId = (System.Int32)reader["ED_CODE_SUBJECT_ID"];
					c.GradeTypeId = Convert.IsDBNull(reader["GRADE_TYPE_ID"]) ? null : (System.Int32?)reader["GRADE_TYPE_ID"];
					c.MinMark = Convert.IsDBNull(reader["MIN_MARK"]) ? null : (System.Decimal?)reader["MIN_MARK"];
					c.MaxMark = Convert.IsDBNull(reader["MAX_MARK"]) ? null : (System.Decimal?)reader["MAX_MARK"];
					c.CoefcntFlg = Convert.IsDBNull(reader["COEFCNT_FLG"]) ? null : (System.Boolean?)reader["COEFCNT_FLG"];
					c.SubjCoefcnt = Convert.IsDBNull(reader["SUBJ_COEFCNT"]) ? null : (System.Decimal?)reader["SUBJ_COEFCNT"];
					c.AddTotalFlg = Convert.IsDBNull(reader["ADD_TOTAL_FLG"]) ? null : (System.Boolean?)reader["ADD_TOTAL_FLG"];
					c.DeductTotalFlg = Convert.IsDBNull(reader["DEDUCT_TOTAL_FLG"]) ? null : (System.Boolean?)reader["DEDUCT_TOTAL_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeQualSubject"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeQualSubject"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeQualSubject entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeQualSubjectId = (System.Decimal)reader[((int)EdCodeQualSubjectColumn.EdCodeQualSubjectId - 1)];
			entity.OriginalEdCodeQualSubjectId = (System.Decimal)reader["ED_CODE_QUAL_SUBJECT_ID"];
			entity.EdCodeQualGroupId = (reader.IsDBNull(((int)EdCodeQualSubjectColumn.EdCodeQualGroupId - 1)))?null:(System.Decimal?)reader[((int)EdCodeQualSubjectColumn.EdCodeQualGroupId - 1)];
			entity.EdCodeQualBranId = (reader.IsDBNull(((int)EdCodeQualSubjectColumn.EdCodeQualBranId - 1)))?null:(System.Decimal?)reader[((int)EdCodeQualSubjectColumn.EdCodeQualBranId - 1)];
			entity.EdCodeSubjectId = (System.Int32)reader[((int)EdCodeQualSubjectColumn.EdCodeSubjectId - 1)];
			entity.GradeTypeId = (reader.IsDBNull(((int)EdCodeQualSubjectColumn.GradeTypeId - 1)))?null:(System.Int32?)reader[((int)EdCodeQualSubjectColumn.GradeTypeId - 1)];
			entity.MinMark = (reader.IsDBNull(((int)EdCodeQualSubjectColumn.MinMark - 1)))?null:(System.Decimal?)reader[((int)EdCodeQualSubjectColumn.MinMark - 1)];
			entity.MaxMark = (reader.IsDBNull(((int)EdCodeQualSubjectColumn.MaxMark - 1)))?null:(System.Decimal?)reader[((int)EdCodeQualSubjectColumn.MaxMark - 1)];
			entity.CoefcntFlg = (reader.IsDBNull(((int)EdCodeQualSubjectColumn.CoefcntFlg - 1)))?null:(System.Boolean?)reader[((int)EdCodeQualSubjectColumn.CoefcntFlg - 1)];
			entity.SubjCoefcnt = (reader.IsDBNull(((int)EdCodeQualSubjectColumn.SubjCoefcnt - 1)))?null:(System.Decimal?)reader[((int)EdCodeQualSubjectColumn.SubjCoefcnt - 1)];
			entity.AddTotalFlg = (reader.IsDBNull(((int)EdCodeQualSubjectColumn.AddTotalFlg - 1)))?null:(System.Boolean?)reader[((int)EdCodeQualSubjectColumn.AddTotalFlg - 1)];
			entity.DeductTotalFlg = (reader.IsDBNull(((int)EdCodeQualSubjectColumn.DeductTotalFlg - 1)))?null:(System.Boolean?)reader[((int)EdCodeQualSubjectColumn.DeductTotalFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeQualSubject"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeQualSubject"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeQualSubject entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeQualSubjectId = (System.Decimal)dataRow["ED_CODE_QUAL_SUBJECT_ID"];
			entity.OriginalEdCodeQualSubjectId = (System.Decimal)dataRow["ED_CODE_QUAL_SUBJECT_ID"];
			entity.EdCodeQualGroupId = Convert.IsDBNull(dataRow["ED_CODE_QUAL_GROUP_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_QUAL_GROUP_ID"];
			entity.EdCodeQualBranId = Convert.IsDBNull(dataRow["ED_CODE_QUAL_BRAN_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_QUAL_BRAN_ID"];
			entity.EdCodeSubjectId = (System.Int32)dataRow["ED_CODE_SUBJECT_ID"];
			entity.GradeTypeId = Convert.IsDBNull(dataRow["GRADE_TYPE_ID"]) ? null : (System.Int32?)dataRow["GRADE_TYPE_ID"];
			entity.MinMark = Convert.IsDBNull(dataRow["MIN_MARK"]) ? null : (System.Decimal?)dataRow["MIN_MARK"];
			entity.MaxMark = Convert.IsDBNull(dataRow["MAX_MARK"]) ? null : (System.Decimal?)dataRow["MAX_MARK"];
			entity.CoefcntFlg = Convert.IsDBNull(dataRow["COEFCNT_FLG"]) ? null : (System.Boolean?)dataRow["COEFCNT_FLG"];
			entity.SubjCoefcnt = Convert.IsDBNull(dataRow["SUBJ_COEFCNT"]) ? null : (System.Decimal?)dataRow["SUBJ_COEFCNT"];
			entity.AddTotalFlg = Convert.IsDBNull(dataRow["ADD_TOTAL_FLG"]) ? null : (System.Boolean?)dataRow["ADD_TOTAL_FLG"];
			entity.DeductTotalFlg = Convert.IsDBNull(dataRow["DEDUCT_TOTAL_FLG"]) ? null : (System.Boolean?)dataRow["DEDUCT_TOTAL_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeQualSubject"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeQualSubject Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeQualSubject entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeQualBranIdSource	
			if (CanDeepLoad(entity, "EdCdeQualBrn|EdCodeQualBranIdSource", deepLoadType, innerList) 
				&& entity.EdCodeQualBranIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeQualBranId ?? 0.0m);
				EdCdeQualBrn tmpEntity = EntityManager.LocateEntity<EdCdeQualBrn>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeQualBrn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeQualBranIdSource = tmpEntity;
				else
					entity.EdCodeQualBranIdSource = DataRepository.EdCdeQualBrnProvider.GetByEdCdeQualBrnId(transactionManager, (entity.EdCodeQualBranId ?? 0.0m));		
				
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

			#region EdCodeQualGroupIdSource	
			if (CanDeepLoad(entity, "EdCodeQualGroup|EdCodeQualGroupIdSource", deepLoadType, innerList) 
				&& entity.EdCodeQualGroupIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeQualGroupId ?? 0.0m);
				EdCodeQualGroup tmpEntity = EntityManager.LocateEntity<EdCodeQualGroup>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeQualGroup), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeQualGroupIdSource = tmpEntity;
				else
					entity.EdCodeQualGroupIdSource = DataRepository.EdCodeQualGroupProvider.GetByEdCodeQualGroupId(transactionManager, (entity.EdCodeQualGroupId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeQualGroupIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeQualGroupIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeQualGroupProvider.DeepLoad(transactionManager, entity.EdCodeQualGroupIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeQualGroupIdSource

			#region EdCodeSubjectIdSource	
			if (CanDeepLoad(entity, "EdCodeSubject|EdCodeSubjectIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSubjectIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeSubjectId;
				EdCodeSubject tmpEntity = EntityManager.LocateEntity<EdCodeSubject>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSubject), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSubjectIdSource = tmpEntity;
				else
					entity.EdCodeSubjectIdSource = DataRepository.EdCodeSubjectProvider.GetByEdCodeSubjectId(transactionManager, entity.EdCodeSubjectId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSubjectIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSubjectIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSubjectProvider.DeepLoad(transactionManager, entity.EdCodeSubjectIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSubjectIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeQualSubjectId methods when available
			
			#region EdStudQualSubjectCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQualSubject>|EdStudQualSubjectCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualSubjectCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualSubjectCollection = DataRepository.EdStudQualSubjectProvider.GetByEdCodeQualSubjectId(transactionManager, entity.EdCodeQualSubjectId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeQualSubject object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeQualSubject instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeQualSubject Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeQualSubject entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeQualBranIdSource
			if (CanDeepSave(entity, "EdCdeQualBrn|EdCodeQualBranIdSource", deepSaveType, innerList) 
				&& entity.EdCodeQualBranIdSource != null)
			{
				DataRepository.EdCdeQualBrnProvider.Save(transactionManager, entity.EdCodeQualBranIdSource);
				entity.EdCodeQualBranId = entity.EdCodeQualBranIdSource.EdCdeQualBrnId;
			}
			#endregion 
			
			#region EdCodeQualGroupIdSource
			if (CanDeepSave(entity, "EdCodeQualGroup|EdCodeQualGroupIdSource", deepSaveType, innerList) 
				&& entity.EdCodeQualGroupIdSource != null)
			{
				DataRepository.EdCodeQualGroupProvider.Save(transactionManager, entity.EdCodeQualGroupIdSource);
				entity.EdCodeQualGroupId = entity.EdCodeQualGroupIdSource.EdCodeQualGroupId;
			}
			#endregion 
			
			#region EdCodeSubjectIdSource
			if (CanDeepSave(entity, "EdCodeSubject|EdCodeSubjectIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSubjectIdSource != null)
			{
				DataRepository.EdCodeSubjectProvider.Save(transactionManager, entity.EdCodeSubjectIdSource);
				entity.EdCodeSubjectId = entity.EdCodeSubjectIdSource.EdCodeSubjectId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStudQualSubject>
				if (CanDeepSave(entity.EdStudQualSubjectCollection, "List<EdStudQualSubject>|EdStudQualSubjectCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQualSubject child in entity.EdStudQualSubjectCollection)
					{
						if(child.EdCodeQualSubjectIdSource != null)
						{
							child.EdCodeQualSubjectId = child.EdCodeQualSubjectIdSource.EdCodeQualSubjectId;
						}
						else
						{
							child.EdCodeQualSubjectId = entity.EdCodeQualSubjectId;
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
	
	#region EdCodeQualSubjectChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeQualSubject</c>
	///</summary>
	public enum EdCodeQualSubjectChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCdeQualBrn</c> at EdCodeQualBranIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeQualBrn))]
		EdCdeQualBrn,
		
		///<summary>
		/// Composite Property for <c>EdCodeQualGroup</c> at EdCodeQualGroupIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeQualGroup))]
		EdCodeQualGroup,
		
		///<summary>
		/// Composite Property for <c>EdCodeSubject</c> at EdCodeSubjectIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSubject))]
		EdCodeSubject,
		///<summary>
		/// Collection of <c>EdCodeQualSubject</c> as OneToMany for EdStudQualSubjectCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQualSubject>))]
		EdStudQualSubjectCollection,
	}
	
	#endregion EdCodeQualSubjectChildEntityTypes
	
	#region EdCodeQualSubjectFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeQualSubjectColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeQualSubject"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeQualSubjectFilterBuilder : SqlFilterBuilder<EdCodeQualSubjectColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeQualSubjectFilterBuilder class.
		/// </summary>
		public EdCodeQualSubjectFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeQualSubjectFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeQualSubjectFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeQualSubjectFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeQualSubjectFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeQualSubjectFilterBuilder
	
	#region EdCodeQualSubjectParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeQualSubjectColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeQualSubject"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeQualSubjectParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeQualSubjectColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeQualSubjectParameterBuilder class.
		/// </summary>
		public EdCodeQualSubjectParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeQualSubjectParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeQualSubjectParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeQualSubjectParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeQualSubjectParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeQualSubjectParameterBuilder
	
	#region EdCodeQualSubjectSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeQualSubjectColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeQualSubject"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeQualSubjectSortBuilder : SqlSortBuilder<EdCodeQualSubjectColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeQualSubjectSqlSortBuilder class.
		/// </summary>
		public EdCodeQualSubjectSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeQualSubjectSortBuilder
	
} // end namespace
