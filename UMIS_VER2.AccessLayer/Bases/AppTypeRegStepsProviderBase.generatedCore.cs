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
	/// This class is the base class for any <see cref="AppTypeRegStepsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AppTypeRegStepsProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AppTypeRegSteps, UMIS_VER2.BusinessLyer.AppTypeRegStepsKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AppTypeRegStepsKey key)
		{
			return Delete(transactionManager, key.AppTypeRegStepsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_appTypeRegStepsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _appTypeRegStepsId)
		{
			return Delete(null, _appTypeRegStepsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_appTypeRegStepsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _appTypeRegStepsId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_APP_TYPE_REG_STEPS_ADM_CDE_APP_TYPE key.
		///		FK_APP_TYPE_REG_STEPS_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="_admCdeAppTypeId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AppTypeRegSteps objects.</returns>
		public TList<AppTypeRegSteps> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(_admCdeAppTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_APP_TYPE_REG_STEPS_ADM_CDE_APP_TYPE key.
		///		FK_APP_TYPE_REG_STEPS_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AppTypeRegSteps objects.</returns>
		/// <remarks></remarks>
		public TList<AppTypeRegSteps> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(transactionManager, _admCdeAppTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_APP_TYPE_REG_STEPS_ADM_CDE_APP_TYPE key.
		///		FK_APP_TYPE_REG_STEPS_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AppTypeRegSteps objects.</returns>
		public TList<AppTypeRegSteps> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(transactionManager, _admCdeAppTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_APP_TYPE_REG_STEPS_ADM_CDE_APP_TYPE key.
		///		fkAppTypeRegStepsAdmCdeAppType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeAppTypeId">XXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AppTypeRegSteps objects.</returns>
		public TList<AppTypeRegSteps> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeAppTypeId(null, _admCdeAppTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_APP_TYPE_REG_STEPS_ADM_CDE_APP_TYPE key.
		///		fkAppTypeRegStepsAdmCdeAppType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeAppTypeId">XXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AppTypeRegSteps objects.</returns>
		public TList<AppTypeRegSteps> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeAppTypeId(null, _admCdeAppTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_APP_TYPE_REG_STEPS_ADM_CDE_APP_TYPE key.
		///		FK_APP_TYPE_REG_STEPS_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AppTypeRegSteps objects.</returns>
		public abstract TList<AppTypeRegSteps> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_APP_TYPE_REG_STEPS_ADM_REG_STEPS key.
		///		FK_APP_TYPE_REG_STEPS_ADM_REG_STEPS Description: 
		/// </summary>
		/// <param name="_admRegStepsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AppTypeRegSteps objects.</returns>
		public TList<AppTypeRegSteps> GetByAdmRegStepsId(System.Decimal? _admRegStepsId)
		{
			int count = -1;
			return GetByAdmRegStepsId(_admRegStepsId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_APP_TYPE_REG_STEPS_ADM_REG_STEPS key.
		///		FK_APP_TYPE_REG_STEPS_ADM_REG_STEPS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRegStepsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AppTypeRegSteps objects.</returns>
		/// <remarks></remarks>
		public TList<AppTypeRegSteps> GetByAdmRegStepsId(TransactionManager transactionManager, System.Decimal? _admRegStepsId)
		{
			int count = -1;
			return GetByAdmRegStepsId(transactionManager, _admRegStepsId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_APP_TYPE_REG_STEPS_ADM_REG_STEPS key.
		///		FK_APP_TYPE_REG_STEPS_ADM_REG_STEPS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRegStepsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AppTypeRegSteps objects.</returns>
		public TList<AppTypeRegSteps> GetByAdmRegStepsId(TransactionManager transactionManager, System.Decimal? _admRegStepsId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmRegStepsId(transactionManager, _admRegStepsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_APP_TYPE_REG_STEPS_ADM_REG_STEPS key.
		///		fkAppTypeRegStepsAdmRegSteps Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admRegStepsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AppTypeRegSteps objects.</returns>
		public TList<AppTypeRegSteps> GetByAdmRegStepsId(System.Decimal? _admRegStepsId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmRegStepsId(null, _admRegStepsId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_APP_TYPE_REG_STEPS_ADM_REG_STEPS key.
		///		fkAppTypeRegStepsAdmRegSteps Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admRegStepsId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AppTypeRegSteps objects.</returns>
		public TList<AppTypeRegSteps> GetByAdmRegStepsId(System.Decimal? _admRegStepsId, int start, int pageLength,out int count)
		{
			return GetByAdmRegStepsId(null, _admRegStepsId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_APP_TYPE_REG_STEPS_ADM_REG_STEPS key.
		///		FK_APP_TYPE_REG_STEPS_ADM_REG_STEPS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRegStepsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AppTypeRegSteps objects.</returns>
		public abstract TList<AppTypeRegSteps> GetByAdmRegStepsId(TransactionManager transactionManager, System.Decimal? _admRegStepsId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_APP_TYPE_REG_STEPS_AS_CODE_DEGREE_CLASS key.
		///		FK_APP_TYPE_REG_STEPS_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AppTypeRegSteps objects.</returns>
		public TList<AppTypeRegSteps> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_APP_TYPE_REG_STEPS_AS_CODE_DEGREE_CLASS key.
		///		FK_APP_TYPE_REG_STEPS_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AppTypeRegSteps objects.</returns>
		/// <remarks></remarks>
		public TList<AppTypeRegSteps> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_APP_TYPE_REG_STEPS_AS_CODE_DEGREE_CLASS key.
		///		FK_APP_TYPE_REG_STEPS_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AppTypeRegSteps objects.</returns>
		public TList<AppTypeRegSteps> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_APP_TYPE_REG_STEPS_AS_CODE_DEGREE_CLASS key.
		///		fkAppTypeRegStepsAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AppTypeRegSteps objects.</returns>
		public TList<AppTypeRegSteps> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_APP_TYPE_REG_STEPS_AS_CODE_DEGREE_CLASS key.
		///		fkAppTypeRegStepsAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AppTypeRegSteps objects.</returns>
		public TList<AppTypeRegSteps> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_APP_TYPE_REG_STEPS_AS_CODE_DEGREE_CLASS key.
		///		FK_APP_TYPE_REG_STEPS_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AppTypeRegSteps objects.</returns>
		public abstract TList<AppTypeRegSteps> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AppTypeRegSteps Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AppTypeRegStepsKey key, int start, int pageLength)
		{
			return GetByAppTypeRegStepsId(transactionManager, key.AppTypeRegStepsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_APP_TYPE_REG_STEPS index.
		/// </summary>
		/// <param name="_appTypeRegStepsId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AppTypeRegSteps"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AppTypeRegSteps GetByAppTypeRegStepsId(System.Decimal _appTypeRegStepsId)
		{
			int count = -1;
			return GetByAppTypeRegStepsId(null,_appTypeRegStepsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_APP_TYPE_REG_STEPS index.
		/// </summary>
		/// <param name="_appTypeRegStepsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AppTypeRegSteps"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AppTypeRegSteps GetByAppTypeRegStepsId(System.Decimal _appTypeRegStepsId, int start, int pageLength)
		{
			int count = -1;
			return GetByAppTypeRegStepsId(null, _appTypeRegStepsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_APP_TYPE_REG_STEPS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_appTypeRegStepsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AppTypeRegSteps"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AppTypeRegSteps GetByAppTypeRegStepsId(TransactionManager transactionManager, System.Decimal _appTypeRegStepsId)
		{
			int count = -1;
			return GetByAppTypeRegStepsId(transactionManager, _appTypeRegStepsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_APP_TYPE_REG_STEPS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_appTypeRegStepsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AppTypeRegSteps"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AppTypeRegSteps GetByAppTypeRegStepsId(TransactionManager transactionManager, System.Decimal _appTypeRegStepsId, int start, int pageLength)
		{
			int count = -1;
			return GetByAppTypeRegStepsId(transactionManager, _appTypeRegStepsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_APP_TYPE_REG_STEPS index.
		/// </summary>
		/// <param name="_appTypeRegStepsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AppTypeRegSteps"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AppTypeRegSteps GetByAppTypeRegStepsId(System.Decimal _appTypeRegStepsId, int start, int pageLength, out int count)
		{
			return GetByAppTypeRegStepsId(null, _appTypeRegStepsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_APP_TYPE_REG_STEPS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_appTypeRegStepsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AppTypeRegSteps"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AppTypeRegSteps GetByAppTypeRegStepsId(TransactionManager transactionManager, System.Decimal _appTypeRegStepsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AppTypeRegSteps&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AppTypeRegSteps&gt;"/></returns>
		public static TList<AppTypeRegSteps> Fill(IDataReader reader, TList<AppTypeRegSteps> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AppTypeRegSteps c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AppTypeRegSteps")
					.Append("|").Append((System.Decimal)reader["APP_TYPE_REG_STEPS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AppTypeRegSteps>(
					key.ToString(), // EntityTrackingKey
					"AppTypeRegSteps",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AppTypeRegSteps();
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
					c.AppTypeRegStepsId = (System.Decimal)reader["APP_TYPE_REG_STEPS_ID"];
					c.OriginalAppTypeRegStepsId = c.AppTypeRegStepsId;
					c.AdmRegStepsId = Convert.IsDBNull(reader["ADM_REG_STEPS_ID"]) ? null : (System.Decimal?)reader["ADM_REG_STEPS_ID"];
					c.AsCodeDegreeClassId = (System.Decimal)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.MandatoryFlg = Convert.IsDBNull(reader["MANDATORY_FLG"]) ? null : (System.Boolean?)reader["MANDATORY_FLG"];
					c.TransFlg = Convert.IsDBNull(reader["TRANS_FLG"]) ? null : (System.Boolean?)reader["TRANS_FLG"];
					c.PayFlg = Convert.IsDBNull(reader["PAY_FLG"]) ? null : (System.Boolean?)reader["PAY_FLG"];
					c.ApplicantFlg = Convert.IsDBNull(reader["APPLICANT_FLG"]) ? null : (System.Boolean?)reader["APPLICANT_FLG"];
					c.OfficerFlg = Convert.IsDBNull(reader["OFFICER_FLG"]) ? null : (System.Boolean?)reader["OFFICER_FLG"];
					c.ReviewFlg = Convert.IsDBNull(reader["REVIEW_FLG"]) ? null : (System.Boolean?)reader["REVIEW_FLG"];
					c.ReviewDescrEn = Convert.IsDBNull(reader["REVIEW_DESCR_EN"]) ? null : (System.String)reader["REVIEW_DESCR_EN"];
					c.AdmCdeAppTypeId = Convert.IsDBNull(reader["ADM_CDE_APP_TYPE_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_APP_TYPE_ID"];
					c.PayOnlineFlg = Convert.IsDBNull(reader["PAY_ONLINE_FLG"]) ? null : (System.Boolean?)reader["PAY_ONLINE_FLG"];
					c.QuickFlg = Convert.IsDBNull(reader["QUICK_FLG"]) ? null : (System.Boolean?)reader["QUICK_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AppTypeRegSteps"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AppTypeRegSteps"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AppTypeRegSteps entity)
		{
			if (!reader.Read()) return;
			
			entity.AppTypeRegStepsId = (System.Decimal)reader[((int)AppTypeRegStepsColumn.AppTypeRegStepsId - 1)];
			entity.OriginalAppTypeRegStepsId = (System.Decimal)reader["APP_TYPE_REG_STEPS_ID"];
			entity.AdmRegStepsId = (reader.IsDBNull(((int)AppTypeRegStepsColumn.AdmRegStepsId - 1)))?null:(System.Decimal?)reader[((int)AppTypeRegStepsColumn.AdmRegStepsId - 1)];
			entity.AsCodeDegreeClassId = (System.Decimal)reader[((int)AppTypeRegStepsColumn.AsCodeDegreeClassId - 1)];
			entity.MandatoryFlg = (reader.IsDBNull(((int)AppTypeRegStepsColumn.MandatoryFlg - 1)))?null:(System.Boolean?)reader[((int)AppTypeRegStepsColumn.MandatoryFlg - 1)];
			entity.TransFlg = (reader.IsDBNull(((int)AppTypeRegStepsColumn.TransFlg - 1)))?null:(System.Boolean?)reader[((int)AppTypeRegStepsColumn.TransFlg - 1)];
			entity.PayFlg = (reader.IsDBNull(((int)AppTypeRegStepsColumn.PayFlg - 1)))?null:(System.Boolean?)reader[((int)AppTypeRegStepsColumn.PayFlg - 1)];
			entity.ApplicantFlg = (reader.IsDBNull(((int)AppTypeRegStepsColumn.ApplicantFlg - 1)))?null:(System.Boolean?)reader[((int)AppTypeRegStepsColumn.ApplicantFlg - 1)];
			entity.OfficerFlg = (reader.IsDBNull(((int)AppTypeRegStepsColumn.OfficerFlg - 1)))?null:(System.Boolean?)reader[((int)AppTypeRegStepsColumn.OfficerFlg - 1)];
			entity.ReviewFlg = (reader.IsDBNull(((int)AppTypeRegStepsColumn.ReviewFlg - 1)))?null:(System.Boolean?)reader[((int)AppTypeRegStepsColumn.ReviewFlg - 1)];
			entity.ReviewDescrEn = (reader.IsDBNull(((int)AppTypeRegStepsColumn.ReviewDescrEn - 1)))?null:(System.String)reader[((int)AppTypeRegStepsColumn.ReviewDescrEn - 1)];
			entity.AdmCdeAppTypeId = (reader.IsDBNull(((int)AppTypeRegStepsColumn.AdmCdeAppTypeId - 1)))?null:(System.Decimal?)reader[((int)AppTypeRegStepsColumn.AdmCdeAppTypeId - 1)];
			entity.PayOnlineFlg = (reader.IsDBNull(((int)AppTypeRegStepsColumn.PayOnlineFlg - 1)))?null:(System.Boolean?)reader[((int)AppTypeRegStepsColumn.PayOnlineFlg - 1)];
			entity.QuickFlg = (reader.IsDBNull(((int)AppTypeRegStepsColumn.QuickFlg - 1)))?null:(System.Boolean?)reader[((int)AppTypeRegStepsColumn.QuickFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AppTypeRegSteps"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AppTypeRegSteps"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AppTypeRegSteps entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AppTypeRegStepsId = (System.Decimal)dataRow["APP_TYPE_REG_STEPS_ID"];
			entity.OriginalAppTypeRegStepsId = (System.Decimal)dataRow["APP_TYPE_REG_STEPS_ID"];
			entity.AdmRegStepsId = Convert.IsDBNull(dataRow["ADM_REG_STEPS_ID"]) ? null : (System.Decimal?)dataRow["ADM_REG_STEPS_ID"];
			entity.AsCodeDegreeClassId = (System.Decimal)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.MandatoryFlg = Convert.IsDBNull(dataRow["MANDATORY_FLG"]) ? null : (System.Boolean?)dataRow["MANDATORY_FLG"];
			entity.TransFlg = Convert.IsDBNull(dataRow["TRANS_FLG"]) ? null : (System.Boolean?)dataRow["TRANS_FLG"];
			entity.PayFlg = Convert.IsDBNull(dataRow["PAY_FLG"]) ? null : (System.Boolean?)dataRow["PAY_FLG"];
			entity.ApplicantFlg = Convert.IsDBNull(dataRow["APPLICANT_FLG"]) ? null : (System.Boolean?)dataRow["APPLICANT_FLG"];
			entity.OfficerFlg = Convert.IsDBNull(dataRow["OFFICER_FLG"]) ? null : (System.Boolean?)dataRow["OFFICER_FLG"];
			entity.ReviewFlg = Convert.IsDBNull(dataRow["REVIEW_FLG"]) ? null : (System.Boolean?)dataRow["REVIEW_FLG"];
			entity.ReviewDescrEn = Convert.IsDBNull(dataRow["REVIEW_DESCR_EN"]) ? null : (System.String)dataRow["REVIEW_DESCR_EN"];
			entity.AdmCdeAppTypeId = Convert.IsDBNull(dataRow["ADM_CDE_APP_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_APP_TYPE_ID"];
			entity.PayOnlineFlg = Convert.IsDBNull(dataRow["PAY_ONLINE_FLG"]) ? null : (System.Boolean?)dataRow["PAY_ONLINE_FLG"];
			entity.QuickFlg = Convert.IsDBNull(dataRow["QUICK_FLG"]) ? null : (System.Boolean?)dataRow["QUICK_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AppTypeRegSteps"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AppTypeRegSteps Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AppTypeRegSteps entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmCdeAppTypeIdSource	
			if (CanDeepLoad(entity, "AdmCdeAppType|AdmCdeAppTypeIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeAppTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeAppTypeId ?? 0.0m);
				AdmCdeAppType tmpEntity = EntityManager.LocateEntity<AdmCdeAppType>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeAppType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeAppTypeIdSource = tmpEntity;
				else
					entity.AdmCdeAppTypeIdSource = DataRepository.AdmCdeAppTypeProvider.GetByAdmCdeAppTypeId(transactionManager, (entity.AdmCdeAppTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeAppTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeAppTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeAppTypeProvider.DeepLoad(transactionManager, entity.AdmCdeAppTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeAppTypeIdSource

			#region AdmRegStepsIdSource	
			if (CanDeepLoad(entity, "AdmRegSteps|AdmRegStepsIdSource", deepLoadType, innerList) 
				&& entity.AdmRegStepsIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmRegStepsId ?? 0.0m);
				AdmRegSteps tmpEntity = EntityManager.LocateEntity<AdmRegSteps>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmRegSteps), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmRegStepsIdSource = tmpEntity;
				else
					entity.AdmRegStepsIdSource = DataRepository.AdmRegStepsProvider.GetByAdmRegStepsId(transactionManager, (entity.AdmRegStepsId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmRegStepsIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmRegStepsIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmRegStepsProvider.DeepLoad(transactionManager, entity.AdmRegStepsIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmRegStepsIdSource

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
			// Deep load child collections  - Call GetByAppTypeRegStepsId methods when available
			
			#region AdmAppProcStepsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppProcSteps>|AdmAppProcStepsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppProcStepsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppProcStepsCollection = DataRepository.AdmAppProcStepsProvider.GetByAppTypeRegStepsId(transactionManager, entity.AppTypeRegStepsId);

				if (deep && entity.AdmAppProcStepsCollection.Count > 0)
				{
					deepHandles.Add("AdmAppProcStepsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppProcSteps>) DataRepository.AdmAppProcStepsProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppProcStepsCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AppTypeRegSteps object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AppTypeRegSteps instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AppTypeRegSteps Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AppTypeRegSteps entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCdeAppTypeIdSource
			if (CanDeepSave(entity, "AdmCdeAppType|AdmCdeAppTypeIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeAppTypeIdSource != null)
			{
				DataRepository.AdmCdeAppTypeProvider.Save(transactionManager, entity.AdmCdeAppTypeIdSource);
				entity.AdmCdeAppTypeId = entity.AdmCdeAppTypeIdSource.AdmCdeAppTypeId;
			}
			#endregion 
			
			#region AdmRegStepsIdSource
			if (CanDeepSave(entity, "AdmRegSteps|AdmRegStepsIdSource", deepSaveType, innerList) 
				&& entity.AdmRegStepsIdSource != null)
			{
				DataRepository.AdmRegStepsProvider.Save(transactionManager, entity.AdmRegStepsIdSource);
				entity.AdmRegStepsId = entity.AdmRegStepsIdSource.AdmRegStepsId;
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
	
			#region List<AdmAppProcSteps>
				if (CanDeepSave(entity.AdmAppProcStepsCollection, "List<AdmAppProcSteps>|AdmAppProcStepsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppProcSteps child in entity.AdmAppProcStepsCollection)
					{
						if(child.AppTypeRegStepsIdSource != null)
						{
							child.AppTypeRegStepsId = child.AppTypeRegStepsIdSource.AppTypeRegStepsId;
						}
						else
						{
							child.AppTypeRegStepsId = entity.AppTypeRegStepsId;
						}

					}

					if (entity.AdmAppProcStepsCollection.Count > 0 || entity.AdmAppProcStepsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppProcStepsProvider.Save(transactionManager, entity.AdmAppProcStepsCollection);
						
						deepHandles.Add("AdmAppProcStepsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppProcSteps >) DataRepository.AdmAppProcStepsProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppProcStepsCollection, deepSaveType, childTypes, innerList }
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
	
	#region AppTypeRegStepsChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AppTypeRegSteps</c>
	///</summary>
	public enum AppTypeRegStepsChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCdeAppType</c> at AdmCdeAppTypeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeAppType))]
		AdmCdeAppType,
		
		///<summary>
		/// Composite Property for <c>AdmRegSteps</c> at AdmRegStepsIdSource
		///</summary>
		[ChildEntityType(typeof(AdmRegSteps))]
		AdmRegSteps,
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		///<summary>
		/// Collection of <c>AppTypeRegSteps</c> as OneToMany for AdmAppProcStepsCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppProcSteps>))]
		AdmAppProcStepsCollection,
	}
	
	#endregion AppTypeRegStepsChildEntityTypes
	
	#region AppTypeRegStepsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AppTypeRegStepsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AppTypeRegSteps"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AppTypeRegStepsFilterBuilder : SqlFilterBuilder<AppTypeRegStepsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AppTypeRegStepsFilterBuilder class.
		/// </summary>
		public AppTypeRegStepsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AppTypeRegStepsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AppTypeRegStepsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AppTypeRegStepsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AppTypeRegStepsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AppTypeRegStepsFilterBuilder
	
	#region AppTypeRegStepsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AppTypeRegStepsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AppTypeRegSteps"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AppTypeRegStepsParameterBuilder : ParameterizedSqlFilterBuilder<AppTypeRegStepsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AppTypeRegStepsParameterBuilder class.
		/// </summary>
		public AppTypeRegStepsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AppTypeRegStepsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AppTypeRegStepsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AppTypeRegStepsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AppTypeRegStepsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AppTypeRegStepsParameterBuilder
	
	#region AppTypeRegStepsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AppTypeRegStepsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AppTypeRegSteps"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AppTypeRegStepsSortBuilder : SqlSortBuilder<AppTypeRegStepsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AppTypeRegStepsSqlSortBuilder class.
		/// </summary>
		public AppTypeRegStepsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AppTypeRegStepsSortBuilder
	
} // end namespace
