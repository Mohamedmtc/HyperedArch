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
	/// This class is the base class for any <see cref="AdmTansikAppCodesProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmTansikAppCodesProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmTansikAppCodes, UMIS_VER2.BusinessLyer.AdmTansikAppCodesKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTansikAppCodesKey key)
		{
			return Delete(transactionManager, key.AdmTansikAppCodesId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admTansikAppCodesId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admTansikAppCodesId)
		{
			return Delete(null, _admTansikAppCodesId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTansikAppCodesId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admTansikAppCodesId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_App_Codes_ADM_APP_REG_HISTORY key.
		///		FK_ADM_Tansik_App_Codes_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikAppCodes objects.</returns>
		public TList<AdmTansikAppCodes> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_App_Codes_ADM_APP_REG_HISTORY key.
		///		FK_ADM_Tansik_App_Codes_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikAppCodes objects.</returns>
		/// <remarks></remarks>
		public TList<AdmTansikAppCodes> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_App_Codes_ADM_APP_REG_HISTORY key.
		///		FK_ADM_Tansik_App_Codes_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikAppCodes objects.</returns>
		public TList<AdmTansikAppCodes> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_App_Codes_ADM_APP_REG_HISTORY key.
		///		fkAdmTansikAppCodesAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikAppCodes objects.</returns>
		public TList<AdmTansikAppCodes> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_App_Codes_ADM_APP_REG_HISTORY key.
		///		fkAdmTansikAppCodesAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikAppCodes objects.</returns>
		public TList<AdmTansikAppCodes> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_App_Codes_ADM_APP_REG_HISTORY key.
		///		FK_ADM_Tansik_App_Codes_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikAppCodes objects.</returns>
		public abstract TList<AdmTansikAppCodes> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_App_Codes_ADM_Tansik_Codes key.
		///		FK_ADM_Tansik_App_Codes_ADM_Tansik_Codes Description: 
		/// </summary>
		/// <param name="_admTansikCodesId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikAppCodes objects.</returns>
		public TList<AdmTansikAppCodes> GetByAdmTansikCodesId(System.Decimal _admTansikCodesId)
		{
			int count = -1;
			return GetByAdmTansikCodesId(_admTansikCodesId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_App_Codes_ADM_Tansik_Codes key.
		///		FK_ADM_Tansik_App_Codes_ADM_Tansik_Codes Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTansikCodesId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikAppCodes objects.</returns>
		/// <remarks></remarks>
		public TList<AdmTansikAppCodes> GetByAdmTansikCodesId(TransactionManager transactionManager, System.Decimal _admTansikCodesId)
		{
			int count = -1;
			return GetByAdmTansikCodesId(transactionManager, _admTansikCodesId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_App_Codes_ADM_Tansik_Codes key.
		///		FK_ADM_Tansik_App_Codes_ADM_Tansik_Codes Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTansikCodesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikAppCodes objects.</returns>
		public TList<AdmTansikAppCodes> GetByAdmTansikCodesId(TransactionManager transactionManager, System.Decimal _admTansikCodesId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmTansikCodesId(transactionManager, _admTansikCodesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_App_Codes_ADM_Tansik_Codes key.
		///		fkAdmTansikAppCodesAdmTansikCodes Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admTansikCodesId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikAppCodes objects.</returns>
		public TList<AdmTansikAppCodes> GetByAdmTansikCodesId(System.Decimal _admTansikCodesId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmTansikCodesId(null, _admTansikCodesId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_App_Codes_ADM_Tansik_Codes key.
		///		fkAdmTansikAppCodesAdmTansikCodes Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admTansikCodesId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikAppCodes objects.</returns>
		public TList<AdmTansikAppCodes> GetByAdmTansikCodesId(System.Decimal _admTansikCodesId, int start, int pageLength,out int count)
		{
			return GetByAdmTansikCodesId(null, _admTansikCodesId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_App_Codes_ADM_Tansik_Codes key.
		///		FK_ADM_Tansik_App_Codes_ADM_Tansik_Codes Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTansikCodesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikAppCodes objects.</returns>
		public abstract TList<AdmTansikAppCodes> GetByAdmTansikCodesId(TransactionManager transactionManager, System.Decimal _admTansikCodesId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_App_Codes_SE_USER key.
		///		FK_ADM_Tansik_App_Codes_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikAppCodes objects.</returns>
		public TList<AdmTansikAppCodes> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_App_Codes_SE_USER key.
		///		FK_ADM_Tansik_App_Codes_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikAppCodes objects.</returns>
		/// <remarks></remarks>
		public TList<AdmTansikAppCodes> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_App_Codes_SE_USER key.
		///		FK_ADM_Tansik_App_Codes_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikAppCodes objects.</returns>
		public TList<AdmTansikAppCodes> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_App_Codes_SE_USER key.
		///		fkAdmTansikAppCodesSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikAppCodes objects.</returns>
		public TList<AdmTansikAppCodes> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_App_Codes_SE_USER key.
		///		fkAdmTansikAppCodesSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikAppCodes objects.</returns>
		public TList<AdmTansikAppCodes> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_App_Codes_SE_USER key.
		///		FK_ADM_Tansik_App_Codes_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikAppCodes objects.</returns>
		public abstract TList<AdmTansikAppCodes> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmTansikAppCodes Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTansikAppCodesKey key, int start, int pageLength)
		{
			return GetByAdmTansikAppCodesId(transactionManager, key.AdmTansikAppCodesId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_Tansik_App_Codes index.
		/// </summary>
		/// <param name="_admTansikAppCodesId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTansikAppCodes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTansikAppCodes GetByAdmTansikAppCodesId(System.Decimal _admTansikAppCodesId)
		{
			int count = -1;
			return GetByAdmTansikAppCodesId(null,_admTansikAppCodesId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_Tansik_App_Codes index.
		/// </summary>
		/// <param name="_admTansikAppCodesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTansikAppCodes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTansikAppCodes GetByAdmTansikAppCodesId(System.Decimal _admTansikAppCodesId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmTansikAppCodesId(null, _admTansikAppCodesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_Tansik_App_Codes index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTansikAppCodesId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTansikAppCodes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTansikAppCodes GetByAdmTansikAppCodesId(TransactionManager transactionManager, System.Decimal _admTansikAppCodesId)
		{
			int count = -1;
			return GetByAdmTansikAppCodesId(transactionManager, _admTansikAppCodesId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_Tansik_App_Codes index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTansikAppCodesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTansikAppCodes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTansikAppCodes GetByAdmTansikAppCodesId(TransactionManager transactionManager, System.Decimal _admTansikAppCodesId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmTansikAppCodesId(transactionManager, _admTansikAppCodesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_Tansik_App_Codes index.
		/// </summary>
		/// <param name="_admTansikAppCodesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTansikAppCodes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTansikAppCodes GetByAdmTansikAppCodesId(System.Decimal _admTansikAppCodesId, int start, int pageLength, out int count)
		{
			return GetByAdmTansikAppCodesId(null, _admTansikAppCodesId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_Tansik_App_Codes index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTansikAppCodesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTansikAppCodes"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmTansikAppCodes GetByAdmTansikAppCodesId(TransactionManager transactionManager, System.Decimal _admTansikAppCodesId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmTansikAppCodes&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmTansikAppCodes&gt;"/></returns>
		public static TList<AdmTansikAppCodes> Fill(IDataReader reader, TList<AdmTansikAppCodes> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmTansikAppCodes c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmTansikAppCodes")
					.Append("|").Append((System.Decimal)reader["ADM_Tansik_App_Codes_Id"]).ToString();
					c = EntityManager.LocateOrCreate<AdmTansikAppCodes>(
					key.ToString(), // EntityTrackingKey
					"AdmTansikAppCodes",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmTansikAppCodes();
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
					c.AdmTansikAppCodesId = (System.Decimal)reader["ADM_Tansik_App_Codes_Id"];
					c.OriginalAdmTansikAppCodesId = c.AdmTansikAppCodesId;
					c.AdmAppRegHistoryId = (System.Decimal)reader["ADM_APP_REG_HISTORY_ID"];
					c.AdmTansikCodesId = (System.Decimal)reader["ADM_Tansik_Codes_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmTansikAppCodes"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmTansikAppCodes"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmTansikAppCodes entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmTansikAppCodesId = (System.Decimal)reader[((int)AdmTansikAppCodesColumn.AdmTansikAppCodesId - 1)];
			entity.OriginalAdmTansikAppCodesId = (System.Decimal)reader["ADM_Tansik_App_Codes_Id"];
			entity.AdmAppRegHistoryId = (System.Decimal)reader[((int)AdmTansikAppCodesColumn.AdmAppRegHistoryId - 1)];
			entity.AdmTansikCodesId = (System.Decimal)reader[((int)AdmTansikAppCodesColumn.AdmTansikCodesId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmTansikAppCodesColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmTansikAppCodesColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmTansikAppCodesColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmTansikAppCodesColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmTansikAppCodes"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmTansikAppCodes"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmTansikAppCodes entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmTansikAppCodesId = (System.Decimal)dataRow["ADM_Tansik_App_Codes_Id"];
			entity.OriginalAdmTansikAppCodesId = (System.Decimal)dataRow["ADM_Tansik_App_Codes_Id"];
			entity.AdmAppRegHistoryId = (System.Decimal)dataRow["ADM_APP_REG_HISTORY_ID"];
			entity.AdmTansikCodesId = (System.Decimal)dataRow["ADM_Tansik_Codes_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmTansikAppCodes"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmTansikAppCodes Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTansikAppCodes entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region AdmTansikCodesIdSource	
			if (CanDeepLoad(entity, "AdmTansikCodes|AdmTansikCodesIdSource", deepLoadType, innerList) 
				&& entity.AdmTansikCodesIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmTansikCodesId;
				AdmTansikCodes tmpEntity = EntityManager.LocateEntity<AdmTansikCodes>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmTansikCodes), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmTansikCodesIdSource = tmpEntity;
				else
					entity.AdmTansikCodesIdSource = DataRepository.AdmTansikCodesProvider.GetByAdmTansikCodesId(transactionManager, entity.AdmTansikCodesId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmTansikCodesIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmTansikCodesIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmTansikCodesProvider.DeepLoad(transactionManager, entity.AdmTansikCodesIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmTansikCodesIdSource

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmTansikAppCodes object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmTansikAppCodes instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmTansikAppCodes Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTansikAppCodes entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region AdmTansikCodesIdSource
			if (CanDeepSave(entity, "AdmTansikCodes|AdmTansikCodesIdSource", deepSaveType, innerList) 
				&& entity.AdmTansikCodesIdSource != null)
			{
				DataRepository.AdmTansikCodesProvider.Save(transactionManager, entity.AdmTansikCodesIdSource);
				entity.AdmTansikCodesId = entity.AdmTansikCodesIdSource.AdmTansikCodesId;
			}
			#endregion 
			
			#region SeUserIdSource
			if (CanDeepSave(entity, "SeUser|SeUserIdSource", deepSaveType, innerList) 
				&& entity.SeUserIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserIdSource);
				entity.SeUserId = entity.SeUserIdSource.SeUserId;
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
	
	#region AdmTansikAppCodesChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmTansikAppCodes</c>
	///</summary>
	public enum AdmTansikAppCodesChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppRegHistory</c> at AdmAppRegHistoryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppRegHistory))]
		AdmAppRegHistory,
		
		///<summary>
		/// Composite Property for <c>AdmTansikCodes</c> at AdmTansikCodesIdSource
		///</summary>
		[ChildEntityType(typeof(AdmTansikCodes))]
		AdmTansikCodes,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
	}
	
	#endregion AdmTansikAppCodesChildEntityTypes
	
	#region AdmTansikAppCodesFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmTansikAppCodesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmTansikAppCodes"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmTansikAppCodesFilterBuilder : SqlFilterBuilder<AdmTansikAppCodesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmTansikAppCodesFilterBuilder class.
		/// </summary>
		public AdmTansikAppCodesFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmTansikAppCodesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmTansikAppCodesFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmTansikAppCodesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmTansikAppCodesFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmTansikAppCodesFilterBuilder
	
	#region AdmTansikAppCodesParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmTansikAppCodesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmTansikAppCodes"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmTansikAppCodesParameterBuilder : ParameterizedSqlFilterBuilder<AdmTansikAppCodesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmTansikAppCodesParameterBuilder class.
		/// </summary>
		public AdmTansikAppCodesParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmTansikAppCodesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmTansikAppCodesParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmTansikAppCodesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmTansikAppCodesParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmTansikAppCodesParameterBuilder
	
	#region AdmTansikAppCodesSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmTansikAppCodesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmTansikAppCodes"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmTansikAppCodesSortBuilder : SqlSortBuilder<AdmTansikAppCodesColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmTansikAppCodesSqlSortBuilder class.
		/// </summary>
		public AdmTansikAppCodesSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmTansikAppCodesSortBuilder
	
} // end namespace
