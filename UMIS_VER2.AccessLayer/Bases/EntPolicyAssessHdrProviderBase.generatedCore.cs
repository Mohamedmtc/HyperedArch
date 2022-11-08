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
	/// This class is the base class for any <see cref="EntPolicyAssessHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyAssessHdrProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolicyAssessHdr, UMIS_VER2.BusinessLyer.EntPolicyAssessHdrKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAssessHdrKey key)
		{
			return Delete(transactionManager, key.EntPolicyAssessHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolicyAssessHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPolicyAssessHdrId)
		{
			return Delete(null, _entPolicyAssessHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPolicyAssessHdrId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ED_BYLAW key.
		///		FK_ENT_POLICY_ASSESS_HDR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
		public TList<EntPolicyAssessHdr> GetByEdBylawId(System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(_edBylawId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ED_BYLAW key.
		///		FK_ENT_POLICY_ASSESS_HDR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyAssessHdr> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ED_BYLAW key.
		///		FK_ENT_POLICY_ASSESS_HDR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
		public TList<EntPolicyAssessHdr> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ED_BYLAW key.
		///		fkEntPolicyAssessHdrEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
		public TList<EntPolicyAssessHdr> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdBylawId(null, _edBylawId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ED_BYLAW key.
		///		fkEntPolicyAssessHdrEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
		public TList<EntPolicyAssessHdr> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength,out int count)
		{
			return GetByEdBylawId(null, _edBylawId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ED_BYLAW key.
		///		FK_ENT_POLICY_ASSESS_HDR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
		public abstract TList<EntPolicyAssessHdr> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPolicyAssessHdr Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAssessHdrKey key, int start, int pageLength)
		{
			return GetByEntPolicyAssessHdrId(transactionManager, key.EntPolicyAssessHdrId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_POLICY_ASSESS index.
		/// </summary>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessHdr GetByEntPolicyAssessHdrId(System.Decimal _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(null,_entPolicyAssessHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS index.
		/// </summary>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessHdr GetByEntPolicyAssessHdrId(System.Decimal _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(null, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessHdr GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(transactionManager, _entPolicyAssessHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessHdr GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(transactionManager, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS index.
		/// </summary>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessHdr GetByEntPolicyAssessHdrId(System.Decimal _entPolicyAssessHdrId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyAssessHdrId(null, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyAssessHdr GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal _entPolicyAssessHdrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_POLICY_ASSESS_HDR_AR index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_descrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessHdr GetByEdBylawIdDescrAr(System.Decimal? _edBylawId, System.String _descrAr)
		{
			int count = -1;
			return GetByEdBylawIdDescrAr(null,_edBylawId, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_HDR_AR index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessHdr GetByEdBylawIdDescrAr(System.Decimal? _edBylawId, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawIdDescrAr(null, _edBylawId, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_HDR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_descrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessHdr GetByEdBylawIdDescrAr(TransactionManager transactionManager, System.Decimal? _edBylawId, System.String _descrAr)
		{
			int count = -1;
			return GetByEdBylawIdDescrAr(transactionManager, _edBylawId, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_HDR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessHdr GetByEdBylawIdDescrAr(TransactionManager transactionManager, System.Decimal? _edBylawId, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawIdDescrAr(transactionManager, _edBylawId, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_HDR_AR index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessHdr GetByEdBylawIdDescrAr(System.Decimal? _edBylawId, System.String _descrAr, int start, int pageLength, out int count)
		{
			return GetByEdBylawIdDescrAr(null, _edBylawId, _descrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_HDR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyAssessHdr GetByEdBylawIdDescrAr(TransactionManager transactionManager, System.Decimal? _edBylawId, System.String _descrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_POLICY_ASSESS_HDR_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessHdr GetByDescrEnEdBylawId(System.String _descrEn, System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByDescrEnEdBylawId(null,_descrEn, _edBylawId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_HDR_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessHdr GetByDescrEnEdBylawId(System.String _descrEn, System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrEnEdBylawId(null, _descrEn, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_HDR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="_edBylawId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessHdr GetByDescrEnEdBylawId(TransactionManager transactionManager, System.String _descrEn, System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByDescrEnEdBylawId(transactionManager, _descrEn, _edBylawId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_HDR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessHdr GetByDescrEnEdBylawId(TransactionManager transactionManager, System.String _descrEn, System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrEnEdBylawId(transactionManager, _descrEn, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_HDR_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessHdr GetByDescrEnEdBylawId(System.String _descrEn, System.Decimal? _edBylawId, int start, int pageLength, out int count)
		{
			return GetByDescrEnEdBylawId(null, _descrEn, _edBylawId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_HDR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyAssessHdr GetByDescrEnEdBylawId(TransactionManager transactionManager, System.String _descrEn, System.Decimal? _edBylawId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolicyAssessHdr&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolicyAssessHdr&gt;"/></returns>
		public static TList<EntPolicyAssessHdr> Fill(IDataReader reader, TList<EntPolicyAssessHdr> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolicyAssessHdr c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolicyAssessHdr")
					.Append("|").Append((System.Decimal)reader["ENT_POLICY_ASSESS_HDR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolicyAssessHdr>(
					key.ToString(), // EntityTrackingKey
					"EntPolicyAssessHdr",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolicyAssessHdr();
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
					c.EntPolicyAssessHdrId = (System.Decimal)reader["ENT_POLICY_ASSESS_HDR_ID"];
					c.OriginalEntPolicyAssessHdrId = c.EntPolicyAssessHdrId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.IsGeneral = Convert.IsDBNull(reader["IS_GENERAL"]) ? null : (System.Decimal?)reader["IS_GENERAL"];
					c.EdBylawId = Convert.IsDBNull(reader["ED_BYLAW_ID"]) ? null : (System.Decimal?)reader["ED_BYLAW_ID"];
					c.CourseMaxDeg = Convert.IsDBNull(reader["COURSE_MAX_DEG"]) ? null : (System.Decimal?)reader["COURSE_MAX_DEG"];
					c.CourseMinDeg = Convert.IsDBNull(reader["COURSE_MIN_DEG"]) ? null : (System.Decimal?)reader["COURSE_MIN_DEG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolicyAssessHdr entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolicyAssessHdrId = (System.Decimal)reader[((int)EntPolicyAssessHdrColumn.EntPolicyAssessHdrId - 1)];
			entity.OriginalEntPolicyAssessHdrId = (System.Decimal)reader["ENT_POLICY_ASSESS_HDR_ID"];
			entity.DescrAr = (System.String)reader[((int)EntPolicyAssessHdrColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)EntPolicyAssessHdrColumn.DescrEn - 1)];
			entity.IsGeneral = (reader.IsDBNull(((int)EntPolicyAssessHdrColumn.IsGeneral - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAssessHdrColumn.IsGeneral - 1)];
			entity.EdBylawId = (reader.IsDBNull(((int)EntPolicyAssessHdrColumn.EdBylawId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAssessHdrColumn.EdBylawId - 1)];
			entity.CourseMaxDeg = (reader.IsDBNull(((int)EntPolicyAssessHdrColumn.CourseMaxDeg - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAssessHdrColumn.CourseMaxDeg - 1)];
			entity.CourseMinDeg = (reader.IsDBNull(((int)EntPolicyAssessHdrColumn.CourseMinDeg - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAssessHdrColumn.CourseMinDeg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolicyAssessHdr entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolicyAssessHdrId = (System.Decimal)dataRow["ENT_POLICY_ASSESS_HDR_ID"];
			entity.OriginalEntPolicyAssessHdrId = (System.Decimal)dataRow["ENT_POLICY_ASSESS_HDR_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.IsGeneral = Convert.IsDBNull(dataRow["IS_GENERAL"]) ? null : (System.Decimal?)dataRow["IS_GENERAL"];
			entity.EdBylawId = Convert.IsDBNull(dataRow["ED_BYLAW_ID"]) ? null : (System.Decimal?)dataRow["ED_BYLAW_ID"];
			entity.CourseMaxDeg = Convert.IsDBNull(dataRow["COURSE_MAX_DEG"]) ? null : (System.Decimal?)dataRow["COURSE_MAX_DEG"];
			entity.CourseMinDeg = Convert.IsDBNull(dataRow["COURSE_MIN_DEG"]) ? null : (System.Decimal?)dataRow["COURSE_MIN_DEG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessHdr"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyAssessHdr Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAssessHdr entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdBylawIdSource	
			if (CanDeepLoad(entity, "EdBylaw|EdBylawIdSource", deepLoadType, innerList) 
				&& entity.EdBylawIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdBylawId ?? 0.0m);
				EdBylaw tmpEntity = EntityManager.LocateEntity<EdBylaw>(EntityLocator.ConstructKeyFromPkItems(typeof(EdBylaw), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdBylawIdSource = tmpEntity;
				else
					entity.EdBylawIdSource = DataRepository.EdBylawProvider.GetByEdBylawId(transactionManager, (entity.EdBylawId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBylawIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdBylawIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdBylawProvider.DeepLoad(transactionManager, entity.EdBylawIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdBylawIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntPolicyAssessHdrId methods when available
			
			#region EntPolicyAssessDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyAssessDtl>|EntPolicyAssessDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAssessDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyAssessDtlCollection = DataRepository.EntPolicyAssessDtlProvider.GetByEntPolicyAssessHdrId(transactionManager, entity.EntPolicyAssessHdrId);

				if (deep && entity.EntPolicyAssessDtlCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyAssessDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyAssessDtl>) DataRepository.EntPolicyAssessDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyAssessDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoCrsRsltRaiseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoCrsRsltRaise>|CoCrsRsltRaiseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoCrsRsltRaiseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoCrsRsltRaiseCollection = DataRepository.CoCrsRsltRaiseProvider.GetByEntPolicyAssessHdrId(transactionManager, entity.EntPolicyAssessHdrId);

				if (deep && entity.CoCrsRsltRaiseCollection.Count > 0)
				{
					deepHandles.Add("CoCrsRsltRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoCrsRsltRaise>) DataRepository.CoCrsRsltRaiseProvider.DeepLoad,
						new object[] { transactionManager, entity.CoCrsRsltRaiseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCourseFromCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsCourseFrom>|EdStudIntTrnsCourseFromCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCourseFromCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCourseFromCollection = DataRepository.EdStudIntTrnsCourseFromProvider.GetByEntPolicyAssessHdrId(transactionManager, entity.EntPolicyAssessHdrId);

				if (deep && entity.EdStudIntTrnsCourseFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseFrom>) DataRepository.EdStudIntTrnsCourseFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseFromCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegCollection = DataRepository.EdStudCourseRegProvider.GetByEntPolicyAssessHdrId(transactionManager, entity.EntPolicyAssessHdrId);

				if (deep && entity.EdStudCourseRegCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseReg>) DataRepository.EdStudCourseRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyAssessGrpHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyAssessGrpHdr>|EntPolicyAssessGrpHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAssessGrpHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyAssessGrpHdrCollection = DataRepository.EntPolicyAssessGrpHdrProvider.GetByEntPolicyAssessHdrId(transactionManager, entity.EntPolicyAssessHdrId);

				if (deep && entity.EntPolicyAssessGrpHdrCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyAssessGrpHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyAssessGrpHdr>) DataRepository.EntPolicyAssessGrpHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyAssessGrpHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegAssessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegAssess>|EdStudCourseRegAssessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegAssessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegAssessCollection = DataRepository.EdStudCourseRegAssessProvider.GetByEntPolicyAssessHdrId(transactionManager, entity.EntPolicyAssessHdrId);

				if (deep && entity.EdStudCourseRegAssessCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegAssessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegAssess>) DataRepository.EdStudCourseRegAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegAssessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegTemp>|EdStudCourseRegTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegTempCollection = DataRepository.EdStudCourseRegTempProvider.GetByEntPolicyAssessHdrId(transactionManager, entity.EntPolicyAssessHdrId);

				if (deep && entity.EdStudCourseRegTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegTemp>) DataRepository.EdStudCourseRegTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCourseToCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsCourseTo>|EdStudIntTrnsCourseToCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCourseToCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCourseToCollection = DataRepository.EdStudIntTrnsCourseToProvider.GetByEntPolicyAssessHdrId(transactionManager, entity.EntPolicyAssessHdrId);

				if (deep && entity.EdStudIntTrnsCourseToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseTo>) DataRepository.EdStudIntTrnsCourseToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyAssessCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyAssessCourse>|EntPolicyAssessCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAssessCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyAssessCourseCollection = DataRepository.EntPolicyAssessCourseProvider.GetByEntPolicyAssessHdrId(transactionManager, entity.EntPolicyAssessHdrId);

				if (deep && entity.EntPolicyAssessCourseCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyAssessCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyAssessCourse>) DataRepository.EntPolicyAssessCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyAssessCourseCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolicyAssessHdr object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicyAssessHdr instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyAssessHdr Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAssessHdr entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdBylawIdSource
			if (CanDeepSave(entity, "EdBylaw|EdBylawIdSource", deepSaveType, innerList) 
				&& entity.EdBylawIdSource != null)
			{
				DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawIdSource);
				entity.EdBylawId = entity.EdBylawIdSource.EdBylawId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EntPolicyAssessDtl>
				if (CanDeepSave(entity.EntPolicyAssessDtlCollection, "List<EntPolicyAssessDtl>|EntPolicyAssessDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyAssessDtl child in entity.EntPolicyAssessDtlCollection)
					{
						if(child.EntPolicyAssessHdrIdSource != null)
						{
							child.EntPolicyAssessHdrId = child.EntPolicyAssessHdrIdSource.EntPolicyAssessHdrId;
						}
						else
						{
							child.EntPolicyAssessHdrId = entity.EntPolicyAssessHdrId;
						}

					}

					if (entity.EntPolicyAssessDtlCollection.Count > 0 || entity.EntPolicyAssessDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyAssessDtlProvider.Save(transactionManager, entity.EntPolicyAssessDtlCollection);
						
						deepHandles.Add("EntPolicyAssessDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyAssessDtl >) DataRepository.EntPolicyAssessDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyAssessDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoCrsRsltRaise>
				if (CanDeepSave(entity.CoCrsRsltRaiseCollection, "List<CoCrsRsltRaise>|CoCrsRsltRaiseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoCrsRsltRaise child in entity.CoCrsRsltRaiseCollection)
					{
						if(child.EntPolicyAssessHdrIdSource != null)
						{
							child.EntPolicyAssessHdrId = child.EntPolicyAssessHdrIdSource.EntPolicyAssessHdrId;
						}
						else
						{
							child.EntPolicyAssessHdrId = entity.EntPolicyAssessHdrId;
						}

					}

					if (entity.CoCrsRsltRaiseCollection.Count > 0 || entity.CoCrsRsltRaiseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoCrsRsltRaiseProvider.Save(transactionManager, entity.CoCrsRsltRaiseCollection);
						
						deepHandles.Add("CoCrsRsltRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoCrsRsltRaise >) DataRepository.CoCrsRsltRaiseProvider.DeepSave,
							new object[] { transactionManager, entity.CoCrsRsltRaiseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsCourseFrom>
				if (CanDeepSave(entity.EdStudIntTrnsCourseFromCollection, "List<EdStudIntTrnsCourseFrom>|EdStudIntTrnsCourseFromCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsCourseFrom child in entity.EdStudIntTrnsCourseFromCollection)
					{
						if(child.EntPolicyAssessHdrIdSource != null)
						{
							child.EntPolicyAssessHdrId = child.EntPolicyAssessHdrIdSource.EntPolicyAssessHdrId;
						}
						else
						{
							child.EntPolicyAssessHdrId = entity.EntPolicyAssessHdrId;
						}

					}

					if (entity.EdStudIntTrnsCourseFromCollection.Count > 0 || entity.EdStudIntTrnsCourseFromCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsCourseFromProvider.Save(transactionManager, entity.EdStudIntTrnsCourseFromCollection);
						
						deepHandles.Add("EdStudIntTrnsCourseFromCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsCourseFrom >) DataRepository.EdStudIntTrnsCourseFromProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCourseFromCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseReg>
				if (CanDeepSave(entity.EdStudCourseRegCollection, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseReg child in entity.EdStudCourseRegCollection)
					{
						if(child.EntPolicyAssessHdrIdSource != null)
						{
							child.EntPolicyAssessHdrId = child.EntPolicyAssessHdrIdSource.EntPolicyAssessHdrId;
						}
						else
						{
							child.EntPolicyAssessHdrId = entity.EntPolicyAssessHdrId;
						}

					}

					if (entity.EdStudCourseRegCollection.Count > 0 || entity.EdStudCourseRegCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegCollection);
						
						deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseReg >) DataRepository.EdStudCourseRegProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyAssessGrpHdr>
				if (CanDeepSave(entity.EntPolicyAssessGrpHdrCollection, "List<EntPolicyAssessGrpHdr>|EntPolicyAssessGrpHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyAssessGrpHdr child in entity.EntPolicyAssessGrpHdrCollection)
					{
						if(child.EntPolicyAssessHdrIdSource != null)
						{
							child.EntPolicyAssessHdrId = child.EntPolicyAssessHdrIdSource.EntPolicyAssessHdrId;
						}
						else
						{
							child.EntPolicyAssessHdrId = entity.EntPolicyAssessHdrId;
						}

					}

					if (entity.EntPolicyAssessGrpHdrCollection.Count > 0 || entity.EntPolicyAssessGrpHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyAssessGrpHdrProvider.Save(transactionManager, entity.EntPolicyAssessGrpHdrCollection);
						
						deepHandles.Add("EntPolicyAssessGrpHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyAssessGrpHdr >) DataRepository.EntPolicyAssessGrpHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyAssessGrpHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegAssess>
				if (CanDeepSave(entity.EdStudCourseRegAssessCollection, "List<EdStudCourseRegAssess>|EdStudCourseRegAssessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegAssess child in entity.EdStudCourseRegAssessCollection)
					{
						if(child.EntPolicyAssessHdrIdSource != null)
						{
							child.EntPolicyAssessHdrId = child.EntPolicyAssessHdrIdSource.EntPolicyAssessHdrId;
						}
						else
						{
							child.EntPolicyAssessHdrId = entity.EntPolicyAssessHdrId;
						}

					}

					if (entity.EdStudCourseRegAssessCollection.Count > 0 || entity.EdStudCourseRegAssessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegAssessProvider.Save(transactionManager, entity.EdStudCourseRegAssessCollection);
						
						deepHandles.Add("EdStudCourseRegAssessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegAssess >) DataRepository.EdStudCourseRegAssessProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegAssessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegTemp>
				if (CanDeepSave(entity.EdStudCourseRegTempCollection, "List<EdStudCourseRegTemp>|EdStudCourseRegTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegTemp child in entity.EdStudCourseRegTempCollection)
					{
						if(child.EntPolicyAssessHdrIdSource != null)
						{
							child.EntPolicyAssessHdrId = child.EntPolicyAssessHdrIdSource.EntPolicyAssessHdrId;
						}
						else
						{
							child.EntPolicyAssessHdrId = entity.EntPolicyAssessHdrId;
						}

					}

					if (entity.EdStudCourseRegTempCollection.Count > 0 || entity.EdStudCourseRegTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegTempProvider.Save(transactionManager, entity.EdStudCourseRegTempCollection);
						
						deepHandles.Add("EdStudCourseRegTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegTemp >) DataRepository.EdStudCourseRegTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsCourseTo>
				if (CanDeepSave(entity.EdStudIntTrnsCourseToCollection, "List<EdStudIntTrnsCourseTo>|EdStudIntTrnsCourseToCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsCourseTo child in entity.EdStudIntTrnsCourseToCollection)
					{
						if(child.EntPolicyAssessHdrIdSource != null)
						{
							child.EntPolicyAssessHdrId = child.EntPolicyAssessHdrIdSource.EntPolicyAssessHdrId;
						}
						else
						{
							child.EntPolicyAssessHdrId = entity.EntPolicyAssessHdrId;
						}

					}

					if (entity.EdStudIntTrnsCourseToCollection.Count > 0 || entity.EdStudIntTrnsCourseToCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsCourseToProvider.Save(transactionManager, entity.EdStudIntTrnsCourseToCollection);
						
						deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsCourseTo >) DataRepository.EdStudIntTrnsCourseToProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyAssessCourse>
				if (CanDeepSave(entity.EntPolicyAssessCourseCollection, "List<EntPolicyAssessCourse>|EntPolicyAssessCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyAssessCourse child in entity.EntPolicyAssessCourseCollection)
					{
						if(child.EntPolicyAssessHdrIdSource != null)
						{
							child.EntPolicyAssessHdrId = child.EntPolicyAssessHdrIdSource.EntPolicyAssessHdrId;
						}
						else
						{
							child.EntPolicyAssessHdrId = entity.EntPolicyAssessHdrId;
						}

					}

					if (entity.EntPolicyAssessCourseCollection.Count > 0 || entity.EntPolicyAssessCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyAssessCourseProvider.Save(transactionManager, entity.EntPolicyAssessCourseCollection);
						
						deepHandles.Add("EntPolicyAssessCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyAssessCourse >) DataRepository.EntPolicyAssessCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyAssessCourseCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntPolicyAssessHdrChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolicyAssessHdr</c>
	///</summary>
	public enum EntPolicyAssessHdrChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdBylaw</c> at EdBylawIdSource
		///</summary>
		[ChildEntityType(typeof(EdBylaw))]
		EdBylaw,
		///<summary>
		/// Collection of <c>EntPolicyAssessHdr</c> as OneToMany for EntPolicyAssessDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyAssessDtl>))]
		EntPolicyAssessDtlCollection,
		///<summary>
		/// Collection of <c>EntPolicyAssessHdr</c> as OneToMany for CoCrsRsltRaiseCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoCrsRsltRaise>))]
		CoCrsRsltRaiseCollection,
		///<summary>
		/// Collection of <c>EntPolicyAssessHdr</c> as OneToMany for EdStudIntTrnsCourseFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseFrom>))]
		EdStudIntTrnsCourseFromCollection,
		///<summary>
		/// Collection of <c>EntPolicyAssessHdr</c> as OneToMany for EdStudCourseRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseReg>))]
		EdStudCourseRegCollection,
		///<summary>
		/// Collection of <c>EntPolicyAssessHdr</c> as OneToMany for EntPolicyAssessGrpHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyAssessGrpHdr>))]
		EntPolicyAssessGrpHdrCollection,
		///<summary>
		/// Collection of <c>EntPolicyAssessHdr</c> as OneToMany for EdStudCourseRegAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegAssess>))]
		EdStudCourseRegAssessCollection,
		///<summary>
		/// Collection of <c>EntPolicyAssessHdr</c> as OneToMany for EdStudCourseRegTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegTemp>))]
		EdStudCourseRegTempCollection,
		///<summary>
		/// Collection of <c>EntPolicyAssessHdr</c> as OneToMany for EdStudIntTrnsCourseToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseTo>))]
		EdStudIntTrnsCourseToCollection,
		///<summary>
		/// Collection of <c>EntPolicyAssessHdr</c> as OneToMany for EntPolicyAssessCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyAssessCourse>))]
		EntPolicyAssessCourseCollection,
	}
	
	#endregion EntPolicyAssessHdrChildEntityTypes
	
	#region EntPolicyAssessHdrFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolicyAssessHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyAssessHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyAssessHdrFilterBuilder : SqlFilterBuilder<EntPolicyAssessHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessHdrFilterBuilder class.
		/// </summary>
		public EntPolicyAssessHdrFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyAssessHdrFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyAssessHdrFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyAssessHdrFilterBuilder
	
	#region EntPolicyAssessHdrParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolicyAssessHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyAssessHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyAssessHdrParameterBuilder : ParameterizedSqlFilterBuilder<EntPolicyAssessHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessHdrParameterBuilder class.
		/// </summary>
		public EntPolicyAssessHdrParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyAssessHdrParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyAssessHdrParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyAssessHdrParameterBuilder
	
	#region EntPolicyAssessHdrSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolicyAssessHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyAssessHdr"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolicyAssessHdrSortBuilder : SqlSortBuilder<EntPolicyAssessHdrColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessHdrSqlSortBuilder class.
		/// </summary>
		public EntPolicyAssessHdrSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolicyAssessHdrSortBuilder
	
} // end namespace
