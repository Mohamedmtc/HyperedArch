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
	/// This class is the base class for any <see cref="SaVacationRenewProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaVacationRenewProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaVacationRenew, UMIS_VER2.BusinessLyer.SaVacationRenewKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationRenewKey key)
		{
			return Delete(transactionManager, key.SaVacationRenewId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saVacationRenewId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saVacationRenewId)
		{
			return Delete(null, _saVacationRenewId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationRenewId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saVacationRenewId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0031 key.
		///		FK_AUTO_0031 Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRenew objects.</returns>
		public TList<SaVacationRenew> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0031 key.
		///		FK_AUTO_0031 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRenew objects.</returns>
		/// <remarks></remarks>
		public TList<SaVacationRenew> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0031 key.
		///		FK_AUTO_0031 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRenew objects.</returns>
		public TList<SaVacationRenew> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0031 key.
		///		fkAuto0031 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRenew objects.</returns>
		public TList<SaVacationRenew> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0031 key.
		///		fkAuto0031 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRenew objects.</returns>
		public TList<SaVacationRenew> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0031 key.
		///		FK_AUTO_0031 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRenew objects.</returns>
		public abstract TList<SaVacationRenew> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_RENEW_GS_APPROVAL_H key.
		///		FK_SA_VACATION_RENEW_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="_gsApprovalHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRenew objects.</returns>
		public TList<SaVacationRenew> GetByGsApprovalHId(System.Decimal? _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(_gsApprovalHId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_RENEW_GS_APPROVAL_H key.
		///		FK_SA_VACATION_RENEW_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRenew objects.</returns>
		/// <remarks></remarks>
		public TList<SaVacationRenew> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal? _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_RENEW_GS_APPROVAL_H key.
		///		FK_SA_VACATION_RENEW_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRenew objects.</returns>
		public TList<SaVacationRenew> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal? _gsApprovalHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_RENEW_GS_APPROVAL_H key.
		///		fkSaVacationRenewGsApprovalH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsApprovalHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRenew objects.</returns>
		public TList<SaVacationRenew> GetByGsApprovalHId(System.Decimal? _gsApprovalHId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_RENEW_GS_APPROVAL_H key.
		///		fkSaVacationRenewGsApprovalH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRenew objects.</returns>
		public TList<SaVacationRenew> GetByGsApprovalHId(System.Decimal? _gsApprovalHId, int start, int pageLength,out int count)
		{
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_RENEW_GS_APPROVAL_H key.
		///		FK_SA_VACATION_RENEW_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRenew objects.</returns>
		public abstract TList<SaVacationRenew> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal? _gsApprovalHId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_RENEW_SA_VACATION key.
		///		FK_SA_VACATION_RENEW_SA_VACATION Description: 
		/// </summary>
		/// <param name="_saVacationId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRenew objects.</returns>
		public TList<SaVacationRenew> GetBySaVacationId(System.Decimal _saVacationId)
		{
			int count = -1;
			return GetBySaVacationId(_saVacationId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_RENEW_SA_VACATION key.
		///		FK_SA_VACATION_RENEW_SA_VACATION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRenew objects.</returns>
		/// <remarks></remarks>
		public TList<SaVacationRenew> GetBySaVacationId(TransactionManager transactionManager, System.Decimal _saVacationId)
		{
			int count = -1;
			return GetBySaVacationId(transactionManager, _saVacationId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_RENEW_SA_VACATION key.
		///		FK_SA_VACATION_RENEW_SA_VACATION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRenew objects.</returns>
		public TList<SaVacationRenew> GetBySaVacationId(TransactionManager transactionManager, System.Decimal _saVacationId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaVacationId(transactionManager, _saVacationId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_RENEW_SA_VACATION key.
		///		fkSaVacationRenewSaVacation Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saVacationId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRenew objects.</returns>
		public TList<SaVacationRenew> GetBySaVacationId(System.Decimal _saVacationId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaVacationId(null, _saVacationId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_RENEW_SA_VACATION key.
		///		fkSaVacationRenewSaVacation Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saVacationId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRenew objects.</returns>
		public TList<SaVacationRenew> GetBySaVacationId(System.Decimal _saVacationId, int start, int pageLength,out int count)
		{
			return GetBySaVacationId(null, _saVacationId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_RENEW_SA_VACATION key.
		///		FK_SA_VACATION_RENEW_SA_VACATION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationRenew objects.</returns>
		public abstract TList<SaVacationRenew> GetBySaVacationId(TransactionManager transactionManager, System.Decimal _saVacationId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaVacationRenew Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationRenewKey key, int start, int pageLength)
		{
			return GetBySaVacationRenewId(transactionManager, key.SaVacationRenewId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_VACATION_RENEW index.
		/// </summary>
		/// <param name="_saVacationRenewId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationRenew"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationRenew GetBySaVacationRenewId(System.Decimal _saVacationRenewId)
		{
			int count = -1;
			return GetBySaVacationRenewId(null,_saVacationRenewId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_RENEW index.
		/// </summary>
		/// <param name="_saVacationRenewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationRenew"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationRenew GetBySaVacationRenewId(System.Decimal _saVacationRenewId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaVacationRenewId(null, _saVacationRenewId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_RENEW index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationRenewId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationRenew"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationRenew GetBySaVacationRenewId(TransactionManager transactionManager, System.Decimal _saVacationRenewId)
		{
			int count = -1;
			return GetBySaVacationRenewId(transactionManager, _saVacationRenewId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_RENEW index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationRenewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationRenew"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationRenew GetBySaVacationRenewId(TransactionManager transactionManager, System.Decimal _saVacationRenewId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaVacationRenewId(transactionManager, _saVacationRenewId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_RENEW index.
		/// </summary>
		/// <param name="_saVacationRenewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationRenew"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationRenew GetBySaVacationRenewId(System.Decimal _saVacationRenewId, int start, int pageLength, out int count)
		{
			return GetBySaVacationRenewId(null, _saVacationRenewId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_RENEW index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationRenewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationRenew"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaVacationRenew GetBySaVacationRenewId(TransactionManager transactionManager, System.Decimal _saVacationRenewId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaVacationRenew&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaVacationRenew&gt;"/></returns>
		public static TList<SaVacationRenew> Fill(IDataReader reader, TList<SaVacationRenew> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaVacationRenew c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaVacationRenew")
					.Append("|").Append((System.Decimal)reader["SA_VACATION_RENEW_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaVacationRenew>(
					key.ToString(), // EntityTrackingKey
					"SaVacationRenew",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaVacationRenew();
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
					c.SaVacationRenewId = (System.Decimal)reader["SA_VACATION_RENEW_ID"];
					c.OriginalSaVacationRenewId = c.SaVacationRenewId;
					c.StartDate = (System.DateTime)reader["START_DATE"];
					c.EndDate = (System.DateTime)reader["END_DATE"];
					c.DecisionNum = Convert.IsDBNull(reader["DECISION_NUM"]) ? null : (System.String)reader["DECISION_NUM"];
					c.DecisionDate = Convert.IsDBNull(reader["DECISION_DATE"]) ? null : (System.DateTime?)reader["DECISION_DATE"];
					c.VacationDiscontinued = Convert.IsDBNull(reader["VACATION_DISCONTINUED"]) ? null : (System.Decimal?)reader["VACATION_DISCONTINUED"];
					c.ReturnDate = Convert.IsDBNull(reader["RETURN_DATE"]) ? null : (System.DateTime?)reader["RETURN_DATE"];
					c.VacationLocation = Convert.IsDBNull(reader["VACATION_LOCATION"]) ? null : (System.String)reader["VACATION_LOCATION"];
					c.Comments = Convert.IsDBNull(reader["COMMENTS"]) ? null : (System.String)reader["COMMENTS"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.SaVacationId = (System.Decimal)reader["SA_VACATION_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.GsApprovalHId = Convert.IsDBNull(reader["GS_APPROVAL_H_ID"]) ? null : (System.Decimal?)reader["GS_APPROVAL_H_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaVacationRenew"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaVacationRenew"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaVacationRenew entity)
		{
			if (!reader.Read()) return;
			
			entity.SaVacationRenewId = (System.Decimal)reader[((int)SaVacationRenewColumn.SaVacationRenewId - 1)];
			entity.OriginalSaVacationRenewId = (System.Decimal)reader["SA_VACATION_RENEW_ID"];
			entity.StartDate = (System.DateTime)reader[((int)SaVacationRenewColumn.StartDate - 1)];
			entity.EndDate = (System.DateTime)reader[((int)SaVacationRenewColumn.EndDate - 1)];
			entity.DecisionNum = (reader.IsDBNull(((int)SaVacationRenewColumn.DecisionNum - 1)))?null:(System.String)reader[((int)SaVacationRenewColumn.DecisionNum - 1)];
			entity.DecisionDate = (reader.IsDBNull(((int)SaVacationRenewColumn.DecisionDate - 1)))?null:(System.DateTime?)reader[((int)SaVacationRenewColumn.DecisionDate - 1)];
			entity.VacationDiscontinued = (reader.IsDBNull(((int)SaVacationRenewColumn.VacationDiscontinued - 1)))?null:(System.Decimal?)reader[((int)SaVacationRenewColumn.VacationDiscontinued - 1)];
			entity.ReturnDate = (reader.IsDBNull(((int)SaVacationRenewColumn.ReturnDate - 1)))?null:(System.DateTime?)reader[((int)SaVacationRenewColumn.ReturnDate - 1)];
			entity.VacationLocation = (reader.IsDBNull(((int)SaVacationRenewColumn.VacationLocation - 1)))?null:(System.String)reader[((int)SaVacationRenewColumn.VacationLocation - 1)];
			entity.Comments = (reader.IsDBNull(((int)SaVacationRenewColumn.Comments - 1)))?null:(System.String)reader[((int)SaVacationRenewColumn.Comments - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)SaVacationRenewColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)SaVacationRenewColumn.GsCountryNodeId - 1)];
			entity.SaVacationId = (System.Decimal)reader[((int)SaVacationRenewColumn.SaVacationId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaVacationRenewColumn.AsFacultyInfoId - 1)];
			entity.GsApprovalHId = (reader.IsDBNull(((int)SaVacationRenewColumn.GsApprovalHId - 1)))?null:(System.Decimal?)reader[((int)SaVacationRenewColumn.GsApprovalHId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaVacationRenew"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaVacationRenew"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaVacationRenew entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaVacationRenewId = (System.Decimal)dataRow["SA_VACATION_RENEW_ID"];
			entity.OriginalSaVacationRenewId = (System.Decimal)dataRow["SA_VACATION_RENEW_ID"];
			entity.StartDate = (System.DateTime)dataRow["START_DATE"];
			entity.EndDate = (System.DateTime)dataRow["END_DATE"];
			entity.DecisionNum = Convert.IsDBNull(dataRow["DECISION_NUM"]) ? null : (System.String)dataRow["DECISION_NUM"];
			entity.DecisionDate = Convert.IsDBNull(dataRow["DECISION_DATE"]) ? null : (System.DateTime?)dataRow["DECISION_DATE"];
			entity.VacationDiscontinued = Convert.IsDBNull(dataRow["VACATION_DISCONTINUED"]) ? null : (System.Decimal?)dataRow["VACATION_DISCONTINUED"];
			entity.ReturnDate = Convert.IsDBNull(dataRow["RETURN_DATE"]) ? null : (System.DateTime?)dataRow["RETURN_DATE"];
			entity.VacationLocation = Convert.IsDBNull(dataRow["VACATION_LOCATION"]) ? null : (System.String)dataRow["VACATION_LOCATION"];
			entity.Comments = Convert.IsDBNull(dataRow["COMMENTS"]) ? null : (System.String)dataRow["COMMENTS"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.SaVacationId = (System.Decimal)dataRow["SA_VACATION_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.GsApprovalHId = Convert.IsDBNull(dataRow["GS_APPROVAL_H_ID"]) ? null : (System.Decimal?)dataRow["GS_APPROVAL_H_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaVacationRenew"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaVacationRenew Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationRenew entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource

			#region GsApprovalHIdSource	
			if (CanDeepLoad(entity, "GsApprovalH|GsApprovalHIdSource", deepLoadType, innerList) 
				&& entity.GsApprovalHIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsApprovalHId ?? 0.0m);
				GsApprovalH tmpEntity = EntityManager.LocateEntity<GsApprovalH>(EntityLocator.ConstructKeyFromPkItems(typeof(GsApprovalH), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsApprovalHIdSource = tmpEntity;
				else
					entity.GsApprovalHIdSource = DataRepository.GsApprovalHProvider.GetByGsApprovalHId(transactionManager, (entity.GsApprovalHId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsApprovalHIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsApprovalHIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsApprovalHProvider.DeepLoad(transactionManager, entity.GsApprovalHIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsApprovalHIdSource

			#region SaVacationIdSource	
			if (CanDeepLoad(entity, "SaVacation|SaVacationIdSource", deepLoadType, innerList) 
				&& entity.SaVacationIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaVacationId;
				SaVacation tmpEntity = EntityManager.LocateEntity<SaVacation>(EntityLocator.ConstructKeyFromPkItems(typeof(SaVacation), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaVacationIdSource = tmpEntity;
				else
					entity.SaVacationIdSource = DataRepository.SaVacationProvider.GetBySaVacationId(transactionManager, entity.SaVacationId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaVacationIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaVacationProvider.DeepLoad(transactionManager, entity.SaVacationIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaVacationIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaVacationRenew object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaVacationRenew instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaVacationRenew Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationRenew entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region GsApprovalHIdSource
			if (CanDeepSave(entity, "GsApprovalH|GsApprovalHIdSource", deepSaveType, innerList) 
				&& entity.GsApprovalHIdSource != null)
			{
				DataRepository.GsApprovalHProvider.Save(transactionManager, entity.GsApprovalHIdSource);
				entity.GsApprovalHId = entity.GsApprovalHIdSource.GsApprovalHId;
			}
			#endregion 
			
			#region SaVacationIdSource
			if (CanDeepSave(entity, "SaVacation|SaVacationIdSource", deepSaveType, innerList) 
				&& entity.SaVacationIdSource != null)
			{
				DataRepository.SaVacationProvider.Save(transactionManager, entity.SaVacationIdSource);
				entity.SaVacationId = entity.SaVacationIdSource.SaVacationId;
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
	
	#region SaVacationRenewChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaVacationRenew</c>
	///</summary>
	public enum SaVacationRenewChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>GsApprovalH</c> at GsApprovalHIdSource
		///</summary>
		[ChildEntityType(typeof(GsApprovalH))]
		GsApprovalH,
		
		///<summary>
		/// Composite Property for <c>SaVacation</c> at SaVacationIdSource
		///</summary>
		[ChildEntityType(typeof(SaVacation))]
		SaVacation,
	}
	
	#endregion SaVacationRenewChildEntityTypes
	
	#region SaVacationRenewFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaVacationRenewColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaVacationRenew"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaVacationRenewFilterBuilder : SqlFilterBuilder<SaVacationRenewColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaVacationRenewFilterBuilder class.
		/// </summary>
		public SaVacationRenewFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaVacationRenewFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaVacationRenewFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaVacationRenewFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaVacationRenewFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaVacationRenewFilterBuilder
	
	#region SaVacationRenewParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaVacationRenewColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaVacationRenew"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaVacationRenewParameterBuilder : ParameterizedSqlFilterBuilder<SaVacationRenewColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaVacationRenewParameterBuilder class.
		/// </summary>
		public SaVacationRenewParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaVacationRenewParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaVacationRenewParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaVacationRenewParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaVacationRenewParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaVacationRenewParameterBuilder
	
	#region SaVacationRenewSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaVacationRenewColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaVacationRenew"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaVacationRenewSortBuilder : SqlSortBuilder<SaVacationRenewColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaVacationRenewSqlSortBuilder class.
		/// </summary>
		public SaVacationRenewSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaVacationRenewSortBuilder
	
} // end namespace
