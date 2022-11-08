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
	/// This class is the base class for any <see cref="AdmRegStepPayOnlineProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmRegStepPayOnlineProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmRegStepPayOnline, UMIS_VER2.BusinessLyer.AdmRegStepPayOnlineKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRegStepPayOnlineKey key)
		{
			return Delete(transactionManager, key.AdmRegStepPayOnlineId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admRegStepPayOnlineId">INTEG PAY ONLINE. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _admRegStepPayOnlineId)
		{
			return Delete(null, _admRegStepPayOnlineId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRegStepPayOnlineId">INTEG PAY ONLINE. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _admRegStepPayOnlineId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REG_STEP_PAY_ONLINE_ADM_REG_STEPS key.
		///		FK_ADM_REG_STEP_PAY_ONLINE_ADM_REG_STEPS Description: 
		/// </summary>
		/// <param name="_admRegStepsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRegStepPayOnline objects.</returns>
		public TList<AdmRegStepPayOnline> GetByAdmRegStepsId(System.Decimal _admRegStepsId)
		{
			int count = -1;
			return GetByAdmRegStepsId(_admRegStepsId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REG_STEP_PAY_ONLINE_ADM_REG_STEPS key.
		///		FK_ADM_REG_STEP_PAY_ONLINE_ADM_REG_STEPS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRegStepsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRegStepPayOnline objects.</returns>
		/// <remarks></remarks>
		public TList<AdmRegStepPayOnline> GetByAdmRegStepsId(TransactionManager transactionManager, System.Decimal _admRegStepsId)
		{
			int count = -1;
			return GetByAdmRegStepsId(transactionManager, _admRegStepsId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REG_STEP_PAY_ONLINE_ADM_REG_STEPS key.
		///		FK_ADM_REG_STEP_PAY_ONLINE_ADM_REG_STEPS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRegStepsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRegStepPayOnline objects.</returns>
		public TList<AdmRegStepPayOnline> GetByAdmRegStepsId(TransactionManager transactionManager, System.Decimal _admRegStepsId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmRegStepsId(transactionManager, _admRegStepsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REG_STEP_PAY_ONLINE_ADM_REG_STEPS key.
		///		fkAdmRegStepPayOnlineAdmRegSteps Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admRegStepsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRegStepPayOnline objects.</returns>
		public TList<AdmRegStepPayOnline> GetByAdmRegStepsId(System.Decimal _admRegStepsId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmRegStepsId(null, _admRegStepsId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REG_STEP_PAY_ONLINE_ADM_REG_STEPS key.
		///		fkAdmRegStepPayOnlineAdmRegSteps Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admRegStepsId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRegStepPayOnline objects.</returns>
		public TList<AdmRegStepPayOnline> GetByAdmRegStepsId(System.Decimal _admRegStepsId, int start, int pageLength,out int count)
		{
			return GetByAdmRegStepsId(null, _admRegStepsId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REG_STEP_PAY_ONLINE_ADM_REG_STEPS key.
		///		FK_ADM_REG_STEP_PAY_ONLINE_ADM_REG_STEPS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRegStepsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRegStepPayOnline objects.</returns>
		public abstract TList<AdmRegStepPayOnline> GetByAdmRegStepsId(TransactionManager transactionManager, System.Decimal _admRegStepsId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REG_STEP_PAY_ONLINE_FEE_CODE_BANKS key.
		///		FK_ADM_REG_STEP_PAY_ONLINE_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="_feeCodeBankId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRegStepPayOnline objects.</returns>
		public TList<AdmRegStepPayOnline> GetByFeeCodeBankId(System.Decimal? _feeCodeBankId)
		{
			int count = -1;
			return GetByFeeCodeBankId(_feeCodeBankId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REG_STEP_PAY_ONLINE_FEE_CODE_BANKS key.
		///		FK_ADM_REG_STEP_PAY_ONLINE_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRegStepPayOnline objects.</returns>
		/// <remarks></remarks>
		public TList<AdmRegStepPayOnline> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal? _feeCodeBankId)
		{
			int count = -1;
			return GetByFeeCodeBankId(transactionManager, _feeCodeBankId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REG_STEP_PAY_ONLINE_FEE_CODE_BANKS key.
		///		FK_ADM_REG_STEP_PAY_ONLINE_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRegStepPayOnline objects.</returns>
		public TList<AdmRegStepPayOnline> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal? _feeCodeBankId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeBankId(transactionManager, _feeCodeBankId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REG_STEP_PAY_ONLINE_FEE_CODE_BANKS key.
		///		fkAdmRegStepPayOnlineFeeCodeBanks Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeBankId">XX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRegStepPayOnline objects.</returns>
		public TList<AdmRegStepPayOnline> GetByFeeCodeBankId(System.Decimal? _feeCodeBankId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeBankId(null, _feeCodeBankId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REG_STEP_PAY_ONLINE_FEE_CODE_BANKS key.
		///		fkAdmRegStepPayOnlineFeeCodeBanks Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeBankId">XX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRegStepPayOnline objects.</returns>
		public TList<AdmRegStepPayOnline> GetByFeeCodeBankId(System.Decimal? _feeCodeBankId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeBankId(null, _feeCodeBankId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REG_STEP_PAY_ONLINE_FEE_CODE_BANKS key.
		///		FK_ADM_REG_STEP_PAY_ONLINE_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRegStepPayOnline objects.</returns>
		public abstract TList<AdmRegStepPayOnline> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal? _feeCodeBankId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REG_STEP_PAY_ONLINE_GS_CODE_PAY_METHOD key.
		///		FK_ADM_REG_STEP_PAY_ONLINE_GS_CODE_PAY_METHOD Description: 
		/// </summary>
		/// <param name="_gsCodePayMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRegStepPayOnline objects.</returns>
		public TList<AdmRegStepPayOnline> GetByGsCodePayMethodId(System.Decimal _gsCodePayMethodId)
		{
			int count = -1;
			return GetByGsCodePayMethodId(_gsCodePayMethodId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REG_STEP_PAY_ONLINE_GS_CODE_PAY_METHOD key.
		///		FK_ADM_REG_STEP_PAY_ONLINE_GS_CODE_PAY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRegStepPayOnline objects.</returns>
		/// <remarks></remarks>
		public TList<AdmRegStepPayOnline> GetByGsCodePayMethodId(TransactionManager transactionManager, System.Decimal _gsCodePayMethodId)
		{
			int count = -1;
			return GetByGsCodePayMethodId(transactionManager, _gsCodePayMethodId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REG_STEP_PAY_ONLINE_GS_CODE_PAY_METHOD key.
		///		FK_ADM_REG_STEP_PAY_ONLINE_GS_CODE_PAY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRegStepPayOnline objects.</returns>
		public TList<AdmRegStepPayOnline> GetByGsCodePayMethodId(TransactionManager transactionManager, System.Decimal _gsCodePayMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePayMethodId(transactionManager, _gsCodePayMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REG_STEP_PAY_ONLINE_GS_CODE_PAY_METHOD key.
		///		fkAdmRegStepPayOnlineGsCodePayMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRegStepPayOnline objects.</returns>
		public TList<AdmRegStepPayOnline> GetByGsCodePayMethodId(System.Decimal _gsCodePayMethodId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodePayMethodId(null, _gsCodePayMethodId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REG_STEP_PAY_ONLINE_GS_CODE_PAY_METHOD key.
		///		fkAdmRegStepPayOnlineGsCodePayMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRegStepPayOnline objects.</returns>
		public TList<AdmRegStepPayOnline> GetByGsCodePayMethodId(System.Decimal _gsCodePayMethodId, int start, int pageLength,out int count)
		{
			return GetByGsCodePayMethodId(null, _gsCodePayMethodId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REG_STEP_PAY_ONLINE_GS_CODE_PAY_METHOD key.
		///		FK_ADM_REG_STEP_PAY_ONLINE_GS_CODE_PAY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRegStepPayOnline objects.</returns>
		public abstract TList<AdmRegStepPayOnline> GetByGsCodePayMethodId(TransactionManager transactionManager, System.Decimal _gsCodePayMethodId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmRegStepPayOnline Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRegStepPayOnlineKey key, int start, int pageLength)
		{
			return GetByAdmRegStepPayOnlineId(transactionManager, key.AdmRegStepPayOnlineId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_REG_STEP_PAY_ONLINE index.
		/// </summary>
		/// <param name="_admRegStepPayOnlineId">INTEG PAY ONLINE</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRegStepPayOnline"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRegStepPayOnline GetByAdmRegStepPayOnlineId(System.Int32 _admRegStepPayOnlineId)
		{
			int count = -1;
			return GetByAdmRegStepPayOnlineId(null,_admRegStepPayOnlineId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_REG_STEP_PAY_ONLINE index.
		/// </summary>
		/// <param name="_admRegStepPayOnlineId">INTEG PAY ONLINE</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRegStepPayOnline"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRegStepPayOnline GetByAdmRegStepPayOnlineId(System.Int32 _admRegStepPayOnlineId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmRegStepPayOnlineId(null, _admRegStepPayOnlineId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_REG_STEP_PAY_ONLINE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRegStepPayOnlineId">INTEG PAY ONLINE</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRegStepPayOnline"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRegStepPayOnline GetByAdmRegStepPayOnlineId(TransactionManager transactionManager, System.Int32 _admRegStepPayOnlineId)
		{
			int count = -1;
			return GetByAdmRegStepPayOnlineId(transactionManager, _admRegStepPayOnlineId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_REG_STEP_PAY_ONLINE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRegStepPayOnlineId">INTEG PAY ONLINE</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRegStepPayOnline"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRegStepPayOnline GetByAdmRegStepPayOnlineId(TransactionManager transactionManager, System.Int32 _admRegStepPayOnlineId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmRegStepPayOnlineId(transactionManager, _admRegStepPayOnlineId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_REG_STEP_PAY_ONLINE index.
		/// </summary>
		/// <param name="_admRegStepPayOnlineId">INTEG PAY ONLINE</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRegStepPayOnline"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRegStepPayOnline GetByAdmRegStepPayOnlineId(System.Int32 _admRegStepPayOnlineId, int start, int pageLength, out int count)
		{
			return GetByAdmRegStepPayOnlineId(null, _admRegStepPayOnlineId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_REG_STEP_PAY_ONLINE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRegStepPayOnlineId">INTEG PAY ONLINE</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRegStepPayOnline"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmRegStepPayOnline GetByAdmRegStepPayOnlineId(TransactionManager transactionManager, System.Int32 _admRegStepPayOnlineId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmRegStepPayOnline&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmRegStepPayOnline&gt;"/></returns>
		public static TList<AdmRegStepPayOnline> Fill(IDataReader reader, TList<AdmRegStepPayOnline> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmRegStepPayOnline c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmRegStepPayOnline")
					.Append("|").Append((System.Int32)reader["ADM_REG_STEP_PAY_ONLINE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmRegStepPayOnline>(
					key.ToString(), // EntityTrackingKey
					"AdmRegStepPayOnline",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmRegStepPayOnline();
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
					c.AdmRegStepPayOnlineId = (System.Int32)reader["ADM_REG_STEP_PAY_ONLINE_ID"];
					c.OriginalAdmRegStepPayOnlineId = c.AdmRegStepPayOnlineId;
					c.AdmRegStepsId = (System.Decimal)reader["ADM_REG_STEPS_ID"];
					c.GsCodePayMethodId = (System.Decimal)reader["GS_CODE_PAY_METHOD_ID"];
					c.FeeCodeBankId = Convert.IsDBNull(reader["FEE_CODE_BANK_ID"]) ? null : (System.Decimal?)reader["FEE_CODE_BANK_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmRegStepPayOnline"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmRegStepPayOnline"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmRegStepPayOnline entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmRegStepPayOnlineId = (System.Int32)reader[((int)AdmRegStepPayOnlineColumn.AdmRegStepPayOnlineId - 1)];
			entity.OriginalAdmRegStepPayOnlineId = (System.Int32)reader["ADM_REG_STEP_PAY_ONLINE_ID"];
			entity.AdmRegStepsId = (System.Decimal)reader[((int)AdmRegStepPayOnlineColumn.AdmRegStepsId - 1)];
			entity.GsCodePayMethodId = (System.Decimal)reader[((int)AdmRegStepPayOnlineColumn.GsCodePayMethodId - 1)];
			entity.FeeCodeBankId = (reader.IsDBNull(((int)AdmRegStepPayOnlineColumn.FeeCodeBankId - 1)))?null:(System.Decimal?)reader[((int)AdmRegStepPayOnlineColumn.FeeCodeBankId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmRegStepPayOnline"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmRegStepPayOnline"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmRegStepPayOnline entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmRegStepPayOnlineId = (System.Int32)dataRow["ADM_REG_STEP_PAY_ONLINE_ID"];
			entity.OriginalAdmRegStepPayOnlineId = (System.Int32)dataRow["ADM_REG_STEP_PAY_ONLINE_ID"];
			entity.AdmRegStepsId = (System.Decimal)dataRow["ADM_REG_STEPS_ID"];
			entity.GsCodePayMethodId = (System.Decimal)dataRow["GS_CODE_PAY_METHOD_ID"];
			entity.FeeCodeBankId = Convert.IsDBNull(dataRow["FEE_CODE_BANK_ID"]) ? null : (System.Decimal?)dataRow["FEE_CODE_BANK_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmRegStepPayOnline"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmRegStepPayOnline Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRegStepPayOnline entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmRegStepsIdSource	
			if (CanDeepLoad(entity, "AdmRegSteps|AdmRegStepsIdSource", deepLoadType, innerList) 
				&& entity.AdmRegStepsIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmRegStepsId;
				AdmRegSteps tmpEntity = EntityManager.LocateEntity<AdmRegSteps>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmRegSteps), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmRegStepsIdSource = tmpEntity;
				else
					entity.AdmRegStepsIdSource = DataRepository.AdmRegStepsProvider.GetByAdmRegStepsId(transactionManager, entity.AdmRegStepsId);		
				
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

			#region FeeCodeBankIdSource	
			if (CanDeepLoad(entity, "FeeCodeBanks|FeeCodeBankIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeBankIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCodeBankId ?? 0.0m);
				FeeCodeBanks tmpEntity = EntityManager.LocateEntity<FeeCodeBanks>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeBanks), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeBankIdSource = tmpEntity;
				else
					entity.FeeCodeBankIdSource = DataRepository.FeeCodeBanksProvider.GetByFeeCodeBankId(transactionManager, (entity.FeeCodeBankId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeBankIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeBankIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeBanksProvider.DeepLoad(transactionManager, entity.FeeCodeBankIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeBankIdSource

			#region GsCodePayMethodIdSource	
			if (CanDeepLoad(entity, "GsCodePayMethod|GsCodePayMethodIdSource", deepLoadType, innerList) 
				&& entity.GsCodePayMethodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodePayMethodId;
				GsCodePayMethod tmpEntity = EntityManager.LocateEntity<GsCodePayMethod>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodePayMethod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodePayMethodIdSource = tmpEntity;
				else
					entity.GsCodePayMethodIdSource = DataRepository.GsCodePayMethodProvider.GetByGsCodePayMethodId(transactionManager, entity.GsCodePayMethodId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodePayMethodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodePayMethodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodePayMethodProvider.DeepLoad(transactionManager, entity.GsCodePayMethodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodePayMethodIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmRegStepPayOnline object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmRegStepPayOnline instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmRegStepPayOnline Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRegStepPayOnline entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmRegStepsIdSource
			if (CanDeepSave(entity, "AdmRegSteps|AdmRegStepsIdSource", deepSaveType, innerList) 
				&& entity.AdmRegStepsIdSource != null)
			{
				DataRepository.AdmRegStepsProvider.Save(transactionManager, entity.AdmRegStepsIdSource);
				entity.AdmRegStepsId = entity.AdmRegStepsIdSource.AdmRegStepsId;
			}
			#endregion 
			
			#region FeeCodeBankIdSource
			if (CanDeepSave(entity, "FeeCodeBanks|FeeCodeBankIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeBankIdSource != null)
			{
				DataRepository.FeeCodeBanksProvider.Save(transactionManager, entity.FeeCodeBankIdSource);
				entity.FeeCodeBankId = entity.FeeCodeBankIdSource.FeeCodeBankId;
			}
			#endregion 
			
			#region GsCodePayMethodIdSource
			if (CanDeepSave(entity, "GsCodePayMethod|GsCodePayMethodIdSource", deepSaveType, innerList) 
				&& entity.GsCodePayMethodIdSource != null)
			{
				DataRepository.GsCodePayMethodProvider.Save(transactionManager, entity.GsCodePayMethodIdSource);
				entity.GsCodePayMethodId = entity.GsCodePayMethodIdSource.GsCodePayMethodId;
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
	
	#region AdmRegStepPayOnlineChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmRegStepPayOnline</c>
	///</summary>
	public enum AdmRegStepPayOnlineChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmRegSteps</c> at AdmRegStepsIdSource
		///</summary>
		[ChildEntityType(typeof(AdmRegSteps))]
		AdmRegSteps,
		
		///<summary>
		/// Composite Property for <c>FeeCodeBanks</c> at FeeCodeBankIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeBanks))]
		FeeCodeBanks,
		
		///<summary>
		/// Composite Property for <c>GsCodePayMethod</c> at GsCodePayMethodIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodePayMethod))]
		GsCodePayMethod,
	}
	
	#endregion AdmRegStepPayOnlineChildEntityTypes
	
	#region AdmRegStepPayOnlineFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmRegStepPayOnlineColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmRegStepPayOnline"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmRegStepPayOnlineFilterBuilder : SqlFilterBuilder<AdmRegStepPayOnlineColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmRegStepPayOnlineFilterBuilder class.
		/// </summary>
		public AdmRegStepPayOnlineFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmRegStepPayOnlineFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmRegStepPayOnlineFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmRegStepPayOnlineFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmRegStepPayOnlineFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmRegStepPayOnlineFilterBuilder
	
	#region AdmRegStepPayOnlineParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmRegStepPayOnlineColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmRegStepPayOnline"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmRegStepPayOnlineParameterBuilder : ParameterizedSqlFilterBuilder<AdmRegStepPayOnlineColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmRegStepPayOnlineParameterBuilder class.
		/// </summary>
		public AdmRegStepPayOnlineParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmRegStepPayOnlineParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmRegStepPayOnlineParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmRegStepPayOnlineParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmRegStepPayOnlineParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmRegStepPayOnlineParameterBuilder
	
	#region AdmRegStepPayOnlineSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmRegStepPayOnlineColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmRegStepPayOnline"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmRegStepPayOnlineSortBuilder : SqlSortBuilder<AdmRegStepPayOnlineColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmRegStepPayOnlineSqlSortBuilder class.
		/// </summary>
		public AdmRegStepPayOnlineSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmRegStepPayOnlineSortBuilder
	
} // end namespace
