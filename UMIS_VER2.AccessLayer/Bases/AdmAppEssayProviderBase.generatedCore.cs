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
	/// This class is the base class for any <see cref="AdmAppEssayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppEssayProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppEssay, UMIS_VER2.BusinessLyer.AdmAppEssayKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppEssayKey key)
		{
			return Delete(transactionManager, key.AdmAppEssayId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppEssayId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _admAppEssayId)
		{
			return Delete(null, _admAppEssayId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppEssayId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _admAppEssayId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ESSAY_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_ESSAY_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppEssay objects.</returns>
		public TList<AdmAppEssay> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ESSAY_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_ESSAY_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppEssay objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppEssay> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ESSAY_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_ESSAY_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppEssay objects.</returns>
		public TList<AdmAppEssay> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ESSAY_ADM_APP_REG_HISTORY key.
		///		fkAdmAppEssayAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppEssay objects.</returns>
		public TList<AdmAppEssay> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ESSAY_ADM_APP_REG_HISTORY key.
		///		fkAdmAppEssayAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppEssay objects.</returns>
		public TList<AdmAppEssay> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ESSAY_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_ESSAY_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppEssay objects.</returns>
		public abstract TList<AdmAppEssay> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ESSAY_ADM_APPLICANT key.
		///		FK_ADM_APP_ESSAY_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppEssay objects.</returns>
		public TList<AdmAppEssay> GetByAdmApplicantId(System.Decimal _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ESSAY_ADM_APPLICANT key.
		///		FK_ADM_APP_ESSAY_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppEssay objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppEssay> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ESSAY_ADM_APPLICANT key.
		///		FK_ADM_APP_ESSAY_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppEssay objects.</returns>
		public TList<AdmAppEssay> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ESSAY_ADM_APPLICANT key.
		///		fkAdmAppEssayAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppEssay objects.</returns>
		public TList<AdmAppEssay> GetByAdmApplicantId(System.Decimal _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ESSAY_ADM_APPLICANT key.
		///		fkAdmAppEssayAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppEssay objects.</returns>
		public TList<AdmAppEssay> GetByAdmApplicantId(System.Decimal _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ESSAY_ADM_APPLICANT key.
		///		FK_ADM_APP_ESSAY_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppEssay objects.</returns>
		public abstract TList<AdmAppEssay> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ESSAY_ADM_CDE_ESSAY_OPTION key.
		///		FK_ADM_APP_ESSAY_ADM_CDE_ESSAY_OPTION Description: 
		/// </summary>
		/// <param name="_admCdeEssayOptionId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppEssay objects.</returns>
		public TList<AdmAppEssay> GetByAdmCdeEssayOptionId(System.Int32 _admCdeEssayOptionId)
		{
			int count = -1;
			return GetByAdmCdeEssayOptionId(_admCdeEssayOptionId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ESSAY_ADM_CDE_ESSAY_OPTION key.
		///		FK_ADM_APP_ESSAY_ADM_CDE_ESSAY_OPTION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeEssayOptionId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppEssay objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppEssay> GetByAdmCdeEssayOptionId(TransactionManager transactionManager, System.Int32 _admCdeEssayOptionId)
		{
			int count = -1;
			return GetByAdmCdeEssayOptionId(transactionManager, _admCdeEssayOptionId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ESSAY_ADM_CDE_ESSAY_OPTION key.
		///		FK_ADM_APP_ESSAY_ADM_CDE_ESSAY_OPTION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeEssayOptionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppEssay objects.</returns>
		public TList<AdmAppEssay> GetByAdmCdeEssayOptionId(TransactionManager transactionManager, System.Int32 _admCdeEssayOptionId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeEssayOptionId(transactionManager, _admCdeEssayOptionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ESSAY_ADM_CDE_ESSAY_OPTION key.
		///		fkAdmAppEssayAdmCdeEssayOption Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeEssayOptionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppEssay objects.</returns>
		public TList<AdmAppEssay> GetByAdmCdeEssayOptionId(System.Int32 _admCdeEssayOptionId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeEssayOptionId(null, _admCdeEssayOptionId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ESSAY_ADM_CDE_ESSAY_OPTION key.
		///		fkAdmAppEssayAdmCdeEssayOption Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeEssayOptionId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppEssay objects.</returns>
		public TList<AdmAppEssay> GetByAdmCdeEssayOptionId(System.Int32 _admCdeEssayOptionId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeEssayOptionId(null, _admCdeEssayOptionId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_ESSAY_ADM_CDE_ESSAY_OPTION key.
		///		FK_ADM_APP_ESSAY_ADM_CDE_ESSAY_OPTION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeEssayOptionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppEssay objects.</returns>
		public abstract TList<AdmAppEssay> GetByAdmCdeEssayOptionId(TransactionManager transactionManager, System.Int32 _admCdeEssayOptionId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppEssay Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppEssayKey key, int start, int pageLength)
		{
			return GetByAdmAppEssayId(transactionManager, key.AdmAppEssayId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_ESSAY index.
		/// </summary>
		/// <param name="_admAppEssayId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppEssay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppEssay GetByAdmAppEssayId(System.Int32 _admAppEssayId)
		{
			int count = -1;
			return GetByAdmAppEssayId(null,_admAppEssayId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_ESSAY index.
		/// </summary>
		/// <param name="_admAppEssayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppEssay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppEssay GetByAdmAppEssayId(System.Int32 _admAppEssayId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppEssayId(null, _admAppEssayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_ESSAY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppEssayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppEssay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppEssay GetByAdmAppEssayId(TransactionManager transactionManager, System.Int32 _admAppEssayId)
		{
			int count = -1;
			return GetByAdmAppEssayId(transactionManager, _admAppEssayId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_ESSAY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppEssayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppEssay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppEssay GetByAdmAppEssayId(TransactionManager transactionManager, System.Int32 _admAppEssayId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppEssayId(transactionManager, _admAppEssayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_ESSAY index.
		/// </summary>
		/// <param name="_admAppEssayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppEssay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppEssay GetByAdmAppEssayId(System.Int32 _admAppEssayId, int start, int pageLength, out int count)
		{
			return GetByAdmAppEssayId(null, _admAppEssayId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_ESSAY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppEssayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppEssay"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppEssay GetByAdmAppEssayId(TransactionManager transactionManager, System.Int32 _admAppEssayId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppEssay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppEssay&gt;"/></returns>
		public static TList<AdmAppEssay> Fill(IDataReader reader, TList<AdmAppEssay> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppEssay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppEssay")
					.Append("|").Append((System.Int32)reader["ADM_APP_ESSAY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppEssay>(
					key.ToString(), // EntityTrackingKey
					"AdmAppEssay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppEssay();
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
					c.AdmAppEssayId = (System.Int32)reader["ADM_APP_ESSAY_ID"];
					c.OriginalAdmAppEssayId = c.AdmAppEssayId;
					c.AdmCdeEssayOptionId = (System.Int32)reader["ADM_CDE_ESSAY_OPTION_ID"];
					c.EssayTitle = Convert.IsDBNull(reader["ESSAY_TITLE"]) ? null : (System.String)reader["ESSAY_TITLE"];
					c.EssayTopic = (System.String)reader["ESSAY_TOPIC"];
					c.AdmAppRegHistoryId = (System.Decimal)reader["ADM_APP_REG_HISTORY_ID"];
					c.AdmApplicantId = (System.Decimal)reader["ADM_APPLICANT_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppEssay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppEssay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppEssay entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppEssayId = (System.Int32)reader[((int)AdmAppEssayColumn.AdmAppEssayId - 1)];
			entity.OriginalAdmAppEssayId = (System.Int32)reader["ADM_APP_ESSAY_ID"];
			entity.AdmCdeEssayOptionId = (System.Int32)reader[((int)AdmAppEssayColumn.AdmCdeEssayOptionId - 1)];
			entity.EssayTitle = (reader.IsDBNull(((int)AdmAppEssayColumn.EssayTitle - 1)))?null:(System.String)reader[((int)AdmAppEssayColumn.EssayTitle - 1)];
			entity.EssayTopic = (System.String)reader[((int)AdmAppEssayColumn.EssayTopic - 1)];
			entity.AdmAppRegHistoryId = (System.Decimal)reader[((int)AdmAppEssayColumn.AdmAppRegHistoryId - 1)];
			entity.AdmApplicantId = (System.Decimal)reader[((int)AdmAppEssayColumn.AdmApplicantId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppEssay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppEssay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppEssay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppEssayId = (System.Int32)dataRow["ADM_APP_ESSAY_ID"];
			entity.OriginalAdmAppEssayId = (System.Int32)dataRow["ADM_APP_ESSAY_ID"];
			entity.AdmCdeEssayOptionId = (System.Int32)dataRow["ADM_CDE_ESSAY_OPTION_ID"];
			entity.EssayTitle = Convert.IsDBNull(dataRow["ESSAY_TITLE"]) ? null : (System.String)dataRow["ESSAY_TITLE"];
			entity.EssayTopic = (System.String)dataRow["ESSAY_TOPIC"];
			entity.AdmAppRegHistoryId = (System.Decimal)dataRow["ADM_APP_REG_HISTORY_ID"];
			entity.AdmApplicantId = (System.Decimal)dataRow["ADM_APPLICANT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppEssay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppEssay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppEssay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region AdmCdeEssayOptionIdSource	
			if (CanDeepLoad(entity, "AdmCdeEssayOption|AdmCdeEssayOptionIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeEssayOptionIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmCdeEssayOptionId;
				AdmCdeEssayOption tmpEntity = EntityManager.LocateEntity<AdmCdeEssayOption>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeEssayOption), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeEssayOptionIdSource = tmpEntity;
				else
					entity.AdmCdeEssayOptionIdSource = DataRepository.AdmCdeEssayOptionProvider.GetByAdmCdeEssayOptionId(transactionManager, entity.AdmCdeEssayOptionId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeEssayOptionIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeEssayOptionIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeEssayOptionProvider.DeepLoad(transactionManager, entity.AdmCdeEssayOptionIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeEssayOptionIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppEssay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppEssay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppEssay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppEssay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region AdmCdeEssayOptionIdSource
			if (CanDeepSave(entity, "AdmCdeEssayOption|AdmCdeEssayOptionIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeEssayOptionIdSource != null)
			{
				DataRepository.AdmCdeEssayOptionProvider.Save(transactionManager, entity.AdmCdeEssayOptionIdSource);
				entity.AdmCdeEssayOptionId = entity.AdmCdeEssayOptionIdSource.AdmCdeEssayOptionId;
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
	
	#region AdmAppEssayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppEssay</c>
	///</summary>
	public enum AdmAppEssayChildEntityTypes
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
		/// Composite Property for <c>AdmCdeEssayOption</c> at AdmCdeEssayOptionIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeEssayOption))]
		AdmCdeEssayOption,
	}
	
	#endregion AdmAppEssayChildEntityTypes
	
	#region AdmAppEssayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppEssayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppEssay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppEssayFilterBuilder : SqlFilterBuilder<AdmAppEssayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppEssayFilterBuilder class.
		/// </summary>
		public AdmAppEssayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppEssayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppEssayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppEssayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppEssayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppEssayFilterBuilder
	
	#region AdmAppEssayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppEssayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppEssay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppEssayParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppEssayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppEssayParameterBuilder class.
		/// </summary>
		public AdmAppEssayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppEssayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppEssayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppEssayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppEssayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppEssayParameterBuilder
	
	#region AdmAppEssaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppEssayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppEssay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppEssaySortBuilder : SqlSortBuilder<AdmAppEssayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppEssaySqlSortBuilder class.
		/// </summary>
		public AdmAppEssaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppEssaySortBuilder
	
} // end namespace
