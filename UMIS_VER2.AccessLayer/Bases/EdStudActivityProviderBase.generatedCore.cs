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
	/// This class is the base class for any <see cref="EdStudActivityProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudActivityProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudActivity, UMIS_VER2.BusinessLyer.EdStudActivityKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudActivityKey key)
		{
			return Delete(transactionManager, key.EdStudActvityId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudActvityId">انشطة الطالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudActvityId)
		{
			return Delete(null, _edStudActvityId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudActvityId">انشطة الطالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudActvityId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTIVITY_ADM_APPLICANT key.
		///		FK_ED_STUD_ACTIVITY_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActivity objects.</returns>
		public TList<EdStudActivity> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTIVITY_ADM_APPLICANT key.
		///		FK_ED_STUD_ACTIVITY_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActivity objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudActivity> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTIVITY_ADM_APPLICANT key.
		///		FK_ED_STUD_ACTIVITY_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActivity objects.</returns>
		public TList<EdStudActivity> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTIVITY_ADM_APPLICANT key.
		///		fkEdStudActivityAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActivity objects.</returns>
		public TList<EdStudActivity> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTIVITY_ADM_APPLICANT key.
		///		fkEdStudActivityAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActivity objects.</returns>
		public TList<EdStudActivity> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTIVITY_ADM_APPLICANT key.
		///		FK_ED_STUD_ACTIVITY_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActivity objects.</returns>
		public abstract TList<EdStudActivity> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTIVITY_GS_CDE_ACTVTY_TYPE key.
		///		FK_ED_STUD_ACTIVITY_GS_CDE_ACTVTY_TYPE Description: 
		/// </summary>
		/// <param name="_gsCdeActvtyTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActivity objects.</returns>
		public TList<EdStudActivity> GetByGsCdeActvtyTypeId(System.Int32? _gsCdeActvtyTypeId)
		{
			int count = -1;
			return GetByGsCdeActvtyTypeId(_gsCdeActvtyTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTIVITY_GS_CDE_ACTVTY_TYPE key.
		///		FK_ED_STUD_ACTIVITY_GS_CDE_ACTVTY_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeActvtyTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActivity objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudActivity> GetByGsCdeActvtyTypeId(TransactionManager transactionManager, System.Int32? _gsCdeActvtyTypeId)
		{
			int count = -1;
			return GetByGsCdeActvtyTypeId(transactionManager, _gsCdeActvtyTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTIVITY_GS_CDE_ACTVTY_TYPE key.
		///		FK_ED_STUD_ACTIVITY_GS_CDE_ACTVTY_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeActvtyTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActivity objects.</returns>
		public TList<EdStudActivity> GetByGsCdeActvtyTypeId(TransactionManager transactionManager, System.Int32? _gsCdeActvtyTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeActvtyTypeId(transactionManager, _gsCdeActvtyTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTIVITY_GS_CDE_ACTVTY_TYPE key.
		///		fkEdStudActivityGsCdeActvtyType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeActvtyTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActivity objects.</returns>
		public TList<EdStudActivity> GetByGsCdeActvtyTypeId(System.Int32? _gsCdeActvtyTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeActvtyTypeId(null, _gsCdeActvtyTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTIVITY_GS_CDE_ACTVTY_TYPE key.
		///		fkEdStudActivityGsCdeActvtyType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeActvtyTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActivity objects.</returns>
		public TList<EdStudActivity> GetByGsCdeActvtyTypeId(System.Int32? _gsCdeActvtyTypeId, int start, int pageLength,out int count)
		{
			return GetByGsCdeActvtyTypeId(null, _gsCdeActvtyTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTIVITY_GS_CDE_ACTVTY_TYPE key.
		///		FK_ED_STUD_ACTIVITY_GS_CDE_ACTVTY_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeActvtyTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActivity objects.</returns>
		public abstract TList<EdStudActivity> GetByGsCdeActvtyTypeId(TransactionManager transactionManager, System.Int32? _gsCdeActvtyTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_HOBBY_ED_STUD key.
		///		FK_ED_STUD_HOBBY_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActivity objects.</returns>
		public TList<EdStudActivity> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_HOBBY_ED_STUD key.
		///		FK_ED_STUD_HOBBY_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActivity objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudActivity> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_HOBBY_ED_STUD key.
		///		FK_ED_STUD_HOBBY_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActivity objects.</returns>
		public TList<EdStudActivity> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_HOBBY_ED_STUD key.
		///		fkEdStudHobbyEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActivity objects.</returns>
		public TList<EdStudActivity> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_HOBBY_ED_STUD key.
		///		fkEdStudHobbyEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActivity objects.</returns>
		public TList<EdStudActivity> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_HOBBY_ED_STUD key.
		///		FK_ED_STUD_HOBBY_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActivity objects.</returns>
		public abstract TList<EdStudActivity> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudActivity Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudActivityKey key, int start, int pageLength)
		{
			return GetByEdStudActvityId(transactionManager, key.EdStudActvityId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_HOBBY index.
		/// </summary>
		/// <param name="_edStudActvityId">انشطة الطالب</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudActivity GetByEdStudActvityId(System.Decimal _edStudActvityId)
		{
			int count = -1;
			return GetByEdStudActvityId(null,_edStudActvityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_HOBBY index.
		/// </summary>
		/// <param name="_edStudActvityId">انشطة الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudActivity GetByEdStudActvityId(System.Decimal _edStudActvityId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudActvityId(null, _edStudActvityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_HOBBY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudActvityId">انشطة الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudActivity GetByEdStudActvityId(TransactionManager transactionManager, System.Decimal _edStudActvityId)
		{
			int count = -1;
			return GetByEdStudActvityId(transactionManager, _edStudActvityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_HOBBY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudActvityId">انشطة الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudActivity GetByEdStudActvityId(TransactionManager transactionManager, System.Decimal _edStudActvityId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudActvityId(transactionManager, _edStudActvityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_HOBBY index.
		/// </summary>
		/// <param name="_edStudActvityId">انشطة الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudActivity GetByEdStudActvityId(System.Decimal _edStudActvityId, int start, int pageLength, out int count)
		{
			return GetByEdStudActvityId(null, _edStudActvityId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_HOBBY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudActvityId">انشطة الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudActivity"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudActivity GetByEdStudActvityId(TransactionManager transactionManager, System.Decimal _edStudActvityId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudActivity&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudActivity&gt;"/></returns>
		public static TList<EdStudActivity> Fill(IDataReader reader, TList<EdStudActivity> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudActivity c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudActivity")
					.Append("|").Append((System.Decimal)reader["ED_STUD_ACTVITY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudActivity>(
					key.ToString(), // EntityTrackingKey
					"EdStudActivity",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudActivity();
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
					c.EdStudActvityId = (System.Decimal)reader["ED_STUD_ACTVITY_ID"];
					c.OriginalEdStudActvityId = c.EdStudActvityId;
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.ActType = Convert.IsDBNull(reader["ACT_TYPE"]) ? null : (System.Decimal?)reader["ACT_TYPE"];
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.GsCdeActvtyTypeId = Convert.IsDBNull(reader["GS_CDE_ACTVTY_TYPE_ID"]) ? null : (System.Int32?)reader["GS_CDE_ACTVTY_TYPE_ID"];
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudActivity"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudActivity"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudActivity entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudActvityId = (System.Decimal)reader[((int)EdStudActivityColumn.EdStudActvityId - 1)];
			entity.OriginalEdStudActvityId = (System.Decimal)reader["ED_STUD_ACTVITY_ID"];
			entity.EdStudId = (reader.IsDBNull(((int)EdStudActivityColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)EdStudActivityColumn.EdStudId - 1)];
			entity.ActType = (reader.IsDBNull(((int)EdStudActivityColumn.ActType - 1)))?null:(System.Decimal?)reader[((int)EdStudActivityColumn.ActType - 1)];
			entity.DescrAr = (System.String)reader[((int)EdStudActivityColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)EdStudActivityColumn.DescrEn - 1)];
			entity.GsCdeActvtyTypeId = (reader.IsDBNull(((int)EdStudActivityColumn.GsCdeActvtyTypeId - 1)))?null:(System.Int32?)reader[((int)EdStudActivityColumn.GsCdeActvtyTypeId - 1)];
			entity.AdmApplicantId = (reader.IsDBNull(((int)EdStudActivityColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)EdStudActivityColumn.AdmApplicantId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudActivityColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudActivityColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudActivityColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudActivityColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudActivity"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudActivity"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudActivity entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudActvityId = (System.Decimal)dataRow["ED_STUD_ACTVITY_ID"];
			entity.OriginalEdStudActvityId = (System.Decimal)dataRow["ED_STUD_ACTVITY_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.ActType = Convert.IsDBNull(dataRow["ACT_TYPE"]) ? null : (System.Decimal?)dataRow["ACT_TYPE"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.GsCdeActvtyTypeId = Convert.IsDBNull(dataRow["GS_CDE_ACTVTY_TYPE_ID"]) ? null : (System.Int32?)dataRow["GS_CDE_ACTVTY_TYPE_ID"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudActivity"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudActivity Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudActivity entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmApplicantIdSource	
			if (CanDeepLoad(entity, "AdmApplicant|AdmApplicantIdSource", deepLoadType, innerList) 
				&& entity.AdmApplicantIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmApplicantId ?? 0.0m);
				AdmApplicant tmpEntity = EntityManager.LocateEntity<AdmApplicant>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmApplicant), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmApplicantIdSource = tmpEntity;
				else
					entity.AdmApplicantIdSource = DataRepository.AdmApplicantProvider.GetByAdmApplicantId(transactionManager, (entity.AdmApplicantId ?? 0.0m));		
				
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

			#region GsCdeActvtyTypeIdSource	
			if (CanDeepLoad(entity, "GsCdeActvtyType|GsCdeActvtyTypeIdSource", deepLoadType, innerList) 
				&& entity.GsCdeActvtyTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeActvtyTypeId ?? (int)0);
				GsCdeActvtyType tmpEntity = EntityManager.LocateEntity<GsCdeActvtyType>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeActvtyType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeActvtyTypeIdSource = tmpEntity;
				else
					entity.GsCdeActvtyTypeIdSource = DataRepository.GsCdeActvtyTypeProvider.GetByGsCdeActvtyTypeId(transactionManager, (entity.GsCdeActvtyTypeId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeActvtyTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeActvtyTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeActvtyTypeProvider.DeepLoad(transactionManager, entity.GsCdeActvtyTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeActvtyTypeIdSource

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudId ?? 0.0m);
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, (entity.EdStudId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudProvider.DeepLoad(transactionManager, entity.EdStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudActivity object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudActivity instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudActivity Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudActivity entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmApplicantIdSource
			if (CanDeepSave(entity, "AdmApplicant|AdmApplicantIdSource", deepSaveType, innerList) 
				&& entity.AdmApplicantIdSource != null)
			{
				DataRepository.AdmApplicantProvider.Save(transactionManager, entity.AdmApplicantIdSource);
				entity.AdmApplicantId = entity.AdmApplicantIdSource.AdmApplicantId;
			}
			#endregion 
			
			#region GsCdeActvtyTypeIdSource
			if (CanDeepSave(entity, "GsCdeActvtyType|GsCdeActvtyTypeIdSource", deepSaveType, innerList) 
				&& entity.GsCdeActvtyTypeIdSource != null)
			{
				DataRepository.GsCdeActvtyTypeProvider.Save(transactionManager, entity.GsCdeActvtyTypeIdSource);
				entity.GsCdeActvtyTypeId = entity.GsCdeActvtyTypeIdSource.GsCdeActvtyTypeId;
			}
			#endregion 
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
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
	
	#region EdStudActivityChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudActivity</c>
	///</summary>
	public enum EdStudActivityChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>GsCdeActvtyType</c> at GsCdeActvtyTypeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeActvtyType))]
		GsCdeActvtyType,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
	}
	
	#endregion EdStudActivityChildEntityTypes
	
	#region EdStudActivityFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudActivityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudActivity"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudActivityFilterBuilder : SqlFilterBuilder<EdStudActivityColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudActivityFilterBuilder class.
		/// </summary>
		public EdStudActivityFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudActivityFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudActivityFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudActivityFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudActivityFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudActivityFilterBuilder
	
	#region EdStudActivityParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudActivityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudActivity"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudActivityParameterBuilder : ParameterizedSqlFilterBuilder<EdStudActivityColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudActivityParameterBuilder class.
		/// </summary>
		public EdStudActivityParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudActivityParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudActivityParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudActivityParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudActivityParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudActivityParameterBuilder
	
	#region EdStudActivitySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudActivityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudActivity"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudActivitySortBuilder : SqlSortBuilder<EdStudActivityColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudActivitySqlSortBuilder class.
		/// </summary>
		public EdStudActivitySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudActivitySortBuilder
	
} // end namespace
