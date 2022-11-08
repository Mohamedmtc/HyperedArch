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
	/// This class is the base class for any <see cref="AdmAppProcStepsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppProcStepsProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppProcSteps, UMIS_VER2.BusinessLyer.AdmAppProcStepsKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppProcStepsKey key)
		{
			return Delete(transactionManager, key.AdmAppProcStepsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppProcStepsId">Tab review -notes. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppProcStepsId)
		{
			return Delete(null, _admAppProcStepsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppProcStepsId">Tab review -notes. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppProcStepsId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PROC_STEPS_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_PROC_STEPS_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppProcSteps objects.</returns>
		public TList<AdmAppProcSteps> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PROC_STEPS_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_PROC_STEPS_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppProcSteps objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppProcSteps> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PROC_STEPS_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_PROC_STEPS_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppProcSteps objects.</returns>
		public TList<AdmAppProcSteps> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PROC_STEPS_ADM_APP_REG_HISTORY key.
		///		fkAdmAppProcStepsAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppProcSteps objects.</returns>
		public TList<AdmAppProcSteps> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PROC_STEPS_ADM_APP_REG_HISTORY key.
		///		fkAdmAppProcStepsAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppProcSteps objects.</returns>
		public TList<AdmAppProcSteps> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PROC_STEPS_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_PROC_STEPS_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppProcSteps objects.</returns>
		public abstract TList<AdmAppProcSteps> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PROC_STEPS_ADM_APPLICANTS key.
		///		FK_ADM_APP_PROC_STEPS_ADM_APPLICANTS Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppProcSteps objects.</returns>
		public TList<AdmAppProcSteps> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PROC_STEPS_ADM_APPLICANTS key.
		///		FK_ADM_APP_PROC_STEPS_ADM_APPLICANTS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppProcSteps objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppProcSteps> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PROC_STEPS_ADM_APPLICANTS key.
		///		FK_ADM_APP_PROC_STEPS_ADM_APPLICANTS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppProcSteps objects.</returns>
		public TList<AdmAppProcSteps> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PROC_STEPS_ADM_APPLICANTS key.
		///		fkAdmAppProcStepsAdmApplicants Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppProcSteps objects.</returns>
		public TList<AdmAppProcSteps> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PROC_STEPS_ADM_APPLICANTS key.
		///		fkAdmAppProcStepsAdmApplicants Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppProcSteps objects.</returns>
		public TList<AdmAppProcSteps> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PROC_STEPS_ADM_APPLICANTS key.
		///		FK_ADM_APP_PROC_STEPS_ADM_APPLICANTS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppProcSteps objects.</returns>
		public abstract TList<AdmAppProcSteps> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PROC_STEPS_APP_TYPE_REG_STEPS key.
		///		FK_ADM_APP_PROC_STEPS_APP_TYPE_REG_STEPS Description: 
		/// </summary>
		/// <param name="_appTypeRegStepsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppProcSteps objects.</returns>
		public TList<AdmAppProcSteps> GetByAppTypeRegStepsId(System.Decimal? _appTypeRegStepsId)
		{
			int count = -1;
			return GetByAppTypeRegStepsId(_appTypeRegStepsId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PROC_STEPS_APP_TYPE_REG_STEPS key.
		///		FK_ADM_APP_PROC_STEPS_APP_TYPE_REG_STEPS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_appTypeRegStepsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppProcSteps objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppProcSteps> GetByAppTypeRegStepsId(TransactionManager transactionManager, System.Decimal? _appTypeRegStepsId)
		{
			int count = -1;
			return GetByAppTypeRegStepsId(transactionManager, _appTypeRegStepsId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PROC_STEPS_APP_TYPE_REG_STEPS key.
		///		FK_ADM_APP_PROC_STEPS_APP_TYPE_REG_STEPS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_appTypeRegStepsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppProcSteps objects.</returns>
		public TList<AdmAppProcSteps> GetByAppTypeRegStepsId(TransactionManager transactionManager, System.Decimal? _appTypeRegStepsId, int start, int pageLength)
		{
			int count = -1;
			return GetByAppTypeRegStepsId(transactionManager, _appTypeRegStepsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PROC_STEPS_APP_TYPE_REG_STEPS key.
		///		fkAdmAppProcStepsAppTypeRegSteps Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_appTypeRegStepsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppProcSteps objects.</returns>
		public TList<AdmAppProcSteps> GetByAppTypeRegStepsId(System.Decimal? _appTypeRegStepsId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAppTypeRegStepsId(null, _appTypeRegStepsId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PROC_STEPS_APP_TYPE_REG_STEPS key.
		///		fkAdmAppProcStepsAppTypeRegSteps Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_appTypeRegStepsId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppProcSteps objects.</returns>
		public TList<AdmAppProcSteps> GetByAppTypeRegStepsId(System.Decimal? _appTypeRegStepsId, int start, int pageLength,out int count)
		{
			return GetByAppTypeRegStepsId(null, _appTypeRegStepsId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PROC_STEPS_APP_TYPE_REG_STEPS key.
		///		FK_ADM_APP_PROC_STEPS_APP_TYPE_REG_STEPS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_appTypeRegStepsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppProcSteps objects.</returns>
		public abstract TList<AdmAppProcSteps> GetByAppTypeRegStepsId(TransactionManager transactionManager, System.Decimal? _appTypeRegStepsId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppProcSteps Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppProcStepsKey key, int start, int pageLength)
		{
			return GetByAdmAppProcStepsId(transactionManager, key.AdmAppProcStepsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_PROC_STEPS index.
		/// </summary>
		/// <param name="_admAppProcStepsId">Tab review -notes</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppProcSteps"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppProcSteps GetByAdmAppProcStepsId(System.Decimal _admAppProcStepsId)
		{
			int count = -1;
			return GetByAdmAppProcStepsId(null,_admAppProcStepsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_PROC_STEPS index.
		/// </summary>
		/// <param name="_admAppProcStepsId">Tab review -notes</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppProcSteps"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppProcSteps GetByAdmAppProcStepsId(System.Decimal _admAppProcStepsId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppProcStepsId(null, _admAppProcStepsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_PROC_STEPS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppProcStepsId">Tab review -notes</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppProcSteps"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppProcSteps GetByAdmAppProcStepsId(TransactionManager transactionManager, System.Decimal _admAppProcStepsId)
		{
			int count = -1;
			return GetByAdmAppProcStepsId(transactionManager, _admAppProcStepsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_PROC_STEPS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppProcStepsId">Tab review -notes</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppProcSteps"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppProcSteps GetByAdmAppProcStepsId(TransactionManager transactionManager, System.Decimal _admAppProcStepsId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppProcStepsId(transactionManager, _admAppProcStepsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_PROC_STEPS index.
		/// </summary>
		/// <param name="_admAppProcStepsId">Tab review -notes</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppProcSteps"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppProcSteps GetByAdmAppProcStepsId(System.Decimal _admAppProcStepsId, int start, int pageLength, out int count)
		{
			return GetByAdmAppProcStepsId(null, _admAppProcStepsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_PROC_STEPS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppProcStepsId">Tab review -notes</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppProcSteps"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppProcSteps GetByAdmAppProcStepsId(TransactionManager transactionManager, System.Decimal _admAppProcStepsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppProcSteps&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppProcSteps&gt;"/></returns>
		public static TList<AdmAppProcSteps> Fill(IDataReader reader, TList<AdmAppProcSteps> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppProcSteps c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppProcSteps")
					.Append("|").Append((System.Decimal)reader["ADM_APP_PROC_STEPS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppProcSteps>(
					key.ToString(), // EntityTrackingKey
					"AdmAppProcSteps",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppProcSteps();
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
					c.AdmAppProcStepsId = (System.Decimal)reader["ADM_APP_PROC_STEPS_ID"];
					c.OriginalAdmAppProcStepsId = c.AdmAppProcStepsId;
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
					c.AppTypeRegStepsId = Convert.IsDBNull(reader["APP_TYPE_REG_STEPS_ID"]) ? null : (System.Decimal?)reader["APP_TYPE_REG_STEPS_ID"];
					c.StepStatusFlg = Convert.IsDBNull(reader["STEP_STATUS_FLG"]) ? null : (System.Decimal?)reader["STEP_STATUS_FLG"];
					c.AdmAppRegHistoryId = Convert.IsDBNull(reader["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)reader["ADM_APP_REG_HISTORY_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppProcSteps"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppProcSteps"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppProcSteps entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppProcStepsId = (System.Decimal)reader[((int)AdmAppProcStepsColumn.AdmAppProcStepsId - 1)];
			entity.OriginalAdmAppProcStepsId = (System.Decimal)reader["ADM_APP_PROC_STEPS_ID"];
			entity.AdmApplicantId = (reader.IsDBNull(((int)AdmAppProcStepsColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)AdmAppProcStepsColumn.AdmApplicantId - 1)];
			entity.AppTypeRegStepsId = (reader.IsDBNull(((int)AdmAppProcStepsColumn.AppTypeRegStepsId - 1)))?null:(System.Decimal?)reader[((int)AdmAppProcStepsColumn.AppTypeRegStepsId - 1)];
			entity.StepStatusFlg = (reader.IsDBNull(((int)AdmAppProcStepsColumn.StepStatusFlg - 1)))?null:(System.Decimal?)reader[((int)AdmAppProcStepsColumn.StepStatusFlg - 1)];
			entity.AdmAppRegHistoryId = (reader.IsDBNull(((int)AdmAppProcStepsColumn.AdmAppRegHistoryId - 1)))?null:(System.Decimal?)reader[((int)AdmAppProcStepsColumn.AdmAppRegHistoryId - 1)];
			entity.Notes = (reader.IsDBNull(((int)AdmAppProcStepsColumn.Notes - 1)))?null:(System.String)reader[((int)AdmAppProcStepsColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmAppProcStepsColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmAppProcStepsColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmAppProcStepsColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppProcStepsColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppProcSteps"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppProcSteps"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppProcSteps entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppProcStepsId = (System.Decimal)dataRow["ADM_APP_PROC_STEPS_ID"];
			entity.OriginalAdmAppProcStepsId = (System.Decimal)dataRow["ADM_APP_PROC_STEPS_ID"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.AppTypeRegStepsId = Convert.IsDBNull(dataRow["APP_TYPE_REG_STEPS_ID"]) ? null : (System.Decimal?)dataRow["APP_TYPE_REG_STEPS_ID"];
			entity.StepStatusFlg = Convert.IsDBNull(dataRow["STEP_STATUS_FLG"]) ? null : (System.Decimal?)dataRow["STEP_STATUS_FLG"];
			entity.AdmAppRegHistoryId = Convert.IsDBNull(dataRow["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_REG_HISTORY_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppProcSteps"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppProcSteps Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppProcSteps entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppRegHistoryIdSource	
			if (CanDeepLoad(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepLoadType, innerList) 
				&& entity.AdmAppRegHistoryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmAppRegHistoryId ?? 0.0m);
				AdmAppRegHistory tmpEntity = EntityManager.LocateEntity<AdmAppRegHistory>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppRegHistory), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppRegHistoryIdSource = tmpEntity;
				else
					entity.AdmAppRegHistoryIdSource = DataRepository.AdmAppRegHistoryProvider.GetByAdmAppRegHistoryId(transactionManager, (entity.AdmAppRegHistoryId ?? 0.0m));		
				
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

			#region AppTypeRegStepsIdSource	
			if (CanDeepLoad(entity, "AppTypeRegSteps|AppTypeRegStepsIdSource", deepLoadType, innerList) 
				&& entity.AppTypeRegStepsIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AppTypeRegStepsId ?? 0.0m);
				AppTypeRegSteps tmpEntity = EntityManager.LocateEntity<AppTypeRegSteps>(EntityLocator.ConstructKeyFromPkItems(typeof(AppTypeRegSteps), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AppTypeRegStepsIdSource = tmpEntity;
				else
					entity.AppTypeRegStepsIdSource = DataRepository.AppTypeRegStepsProvider.GetByAppTypeRegStepsId(transactionManager, (entity.AppTypeRegStepsId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AppTypeRegStepsIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AppTypeRegStepsIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AppTypeRegStepsProvider.DeepLoad(transactionManager, entity.AppTypeRegStepsIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AppTypeRegStepsIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppProcSteps object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppProcSteps instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppProcSteps Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppProcSteps entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region AppTypeRegStepsIdSource
			if (CanDeepSave(entity, "AppTypeRegSteps|AppTypeRegStepsIdSource", deepSaveType, innerList) 
				&& entity.AppTypeRegStepsIdSource != null)
			{
				DataRepository.AppTypeRegStepsProvider.Save(transactionManager, entity.AppTypeRegStepsIdSource);
				entity.AppTypeRegStepsId = entity.AppTypeRegStepsIdSource.AppTypeRegStepsId;
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
	
	#region AdmAppProcStepsChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppProcSteps</c>
	///</summary>
	public enum AdmAppProcStepsChildEntityTypes
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
		/// Composite Property for <c>AppTypeRegSteps</c> at AppTypeRegStepsIdSource
		///</summary>
		[ChildEntityType(typeof(AppTypeRegSteps))]
		AppTypeRegSteps,
	}
	
	#endregion AdmAppProcStepsChildEntityTypes
	
	#region AdmAppProcStepsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppProcStepsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppProcSteps"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppProcStepsFilterBuilder : SqlFilterBuilder<AdmAppProcStepsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppProcStepsFilterBuilder class.
		/// </summary>
		public AdmAppProcStepsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppProcStepsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppProcStepsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppProcStepsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppProcStepsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppProcStepsFilterBuilder
	
	#region AdmAppProcStepsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppProcStepsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppProcSteps"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppProcStepsParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppProcStepsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppProcStepsParameterBuilder class.
		/// </summary>
		public AdmAppProcStepsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppProcStepsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppProcStepsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppProcStepsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppProcStepsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppProcStepsParameterBuilder
	
	#region AdmAppProcStepsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppProcStepsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppProcSteps"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppProcStepsSortBuilder : SqlSortBuilder<AdmAppProcStepsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppProcStepsSqlSortBuilder class.
		/// </summary>
		public AdmAppProcStepsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppProcStepsSortBuilder
	
} // end namespace
