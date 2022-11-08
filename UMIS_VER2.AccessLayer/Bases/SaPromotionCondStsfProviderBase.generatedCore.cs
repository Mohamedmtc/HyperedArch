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
	/// This class is the base class for any <see cref="SaPromotionCondStsfProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaPromotionCondStsfProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaPromotionCondStsf, UMIS_VER2.BusinessLyer.SaPromotionCondStsfKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPromotionCondStsfKey key)
		{
			return Delete(transactionManager, key.SaPromotionCondStsfId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saPromotionCondStsfId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saPromotionCondStsfId)
		{
			return Delete(null, _saPromotionCondStsfId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionCondStsfId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saPromotionCondStsfId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0475 key.
		///		FK_AUTO_0475 Description: 
		/// </summary>
		/// <param name="_saPromotionRequestId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCondStsf objects.</returns>
		public TList<SaPromotionCondStsf> GetBySaPromotionRequestId(System.Decimal _saPromotionRequestId)
		{
			int count = -1;
			return GetBySaPromotionRequestId(_saPromotionRequestId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0475 key.
		///		FK_AUTO_0475 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionRequestId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCondStsf objects.</returns>
		/// <remarks></remarks>
		public TList<SaPromotionCondStsf> GetBySaPromotionRequestId(TransactionManager transactionManager, System.Decimal _saPromotionRequestId)
		{
			int count = -1;
			return GetBySaPromotionRequestId(transactionManager, _saPromotionRequestId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0475 key.
		///		FK_AUTO_0475 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCondStsf objects.</returns>
		public TList<SaPromotionCondStsf> GetBySaPromotionRequestId(TransactionManager transactionManager, System.Decimal _saPromotionRequestId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPromotionRequestId(transactionManager, _saPromotionRequestId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0475 key.
		///		fkAuto0475 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saPromotionRequestId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCondStsf objects.</returns>
		public TList<SaPromotionCondStsf> GetBySaPromotionRequestId(System.Decimal _saPromotionRequestId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaPromotionRequestId(null, _saPromotionRequestId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0475 key.
		///		fkAuto0475 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saPromotionRequestId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCondStsf objects.</returns>
		public TList<SaPromotionCondStsf> GetBySaPromotionRequestId(System.Decimal _saPromotionRequestId, int start, int pageLength,out int count)
		{
			return GetBySaPromotionRequestId(null, _saPromotionRequestId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0475 key.
		///		FK_AUTO_0475 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCondStsf objects.</returns>
		public abstract TList<SaPromotionCondStsf> GetBySaPromotionRequestId(TransactionManager transactionManager, System.Decimal _saPromotionRequestId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_COND_STSF_AS_FACULTY_INFO key.
		///		FK_SA_PROMOTION_COND_STSF_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCondStsf objects.</returns>
		public TList<SaPromotionCondStsf> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_COND_STSF_AS_FACULTY_INFO key.
		///		FK_SA_PROMOTION_COND_STSF_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCondStsf objects.</returns>
		/// <remarks></remarks>
		public TList<SaPromotionCondStsf> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_COND_STSF_AS_FACULTY_INFO key.
		///		FK_SA_PROMOTION_COND_STSF_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCondStsf objects.</returns>
		public TList<SaPromotionCondStsf> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_COND_STSF_AS_FACULTY_INFO key.
		///		fkSaPromotionCondStsfAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCondStsf objects.</returns>
		public TList<SaPromotionCondStsf> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_COND_STSF_AS_FACULTY_INFO key.
		///		fkSaPromotionCondStsfAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCondStsf objects.</returns>
		public TList<SaPromotionCondStsf> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_COND_STSF_AS_FACULTY_INFO key.
		///		FK_SA_PROMOTION_COND_STSF_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCondStsf objects.</returns>
		public abstract TList<SaPromotionCondStsf> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_COND_STSF_SA_PROMOTION_COND key.
		///		FK_SA_PROMOTION_COND_STSF_SA_PROMOTION_COND Description: 
		/// </summary>
		/// <param name="_saPromotionCondId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCondStsf objects.</returns>
		public TList<SaPromotionCondStsf> GetBySaPromotionCondId(System.Decimal _saPromotionCondId)
		{
			int count = -1;
			return GetBySaPromotionCondId(_saPromotionCondId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_COND_STSF_SA_PROMOTION_COND key.
		///		FK_SA_PROMOTION_COND_STSF_SA_PROMOTION_COND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionCondId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCondStsf objects.</returns>
		/// <remarks></remarks>
		public TList<SaPromotionCondStsf> GetBySaPromotionCondId(TransactionManager transactionManager, System.Decimal _saPromotionCondId)
		{
			int count = -1;
			return GetBySaPromotionCondId(transactionManager, _saPromotionCondId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_COND_STSF_SA_PROMOTION_COND key.
		///		FK_SA_PROMOTION_COND_STSF_SA_PROMOTION_COND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionCondId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCondStsf objects.</returns>
		public TList<SaPromotionCondStsf> GetBySaPromotionCondId(TransactionManager transactionManager, System.Decimal _saPromotionCondId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPromotionCondId(transactionManager, _saPromotionCondId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_COND_STSF_SA_PROMOTION_COND key.
		///		fkSaPromotionCondStsfSaPromotionCond Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saPromotionCondId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCondStsf objects.</returns>
		public TList<SaPromotionCondStsf> GetBySaPromotionCondId(System.Decimal _saPromotionCondId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaPromotionCondId(null, _saPromotionCondId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_COND_STSF_SA_PROMOTION_COND key.
		///		fkSaPromotionCondStsfSaPromotionCond Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saPromotionCondId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCondStsf objects.</returns>
		public TList<SaPromotionCondStsf> GetBySaPromotionCondId(System.Decimal _saPromotionCondId, int start, int pageLength,out int count)
		{
			return GetBySaPromotionCondId(null, _saPromotionCondId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_COND_STSF_SA_PROMOTION_COND key.
		///		FK_SA_PROMOTION_COND_STSF_SA_PROMOTION_COND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionCondId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionCondStsf objects.</returns>
		public abstract TList<SaPromotionCondStsf> GetBySaPromotionCondId(TransactionManager transactionManager, System.Decimal _saPromotionCondId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaPromotionCondStsf Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPromotionCondStsfKey key, int start, int pageLength)
		{
			return GetBySaPromotionCondStsfId(transactionManager, key.SaPromotionCondStsfId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_PROMOTION_COND_STSF index.
		/// </summary>
		/// <param name="_saPromotionCondStsfId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotionCondStsf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotionCondStsf GetBySaPromotionCondStsfId(System.Decimal _saPromotionCondStsfId)
		{
			int count = -1;
			return GetBySaPromotionCondStsfId(null,_saPromotionCondStsfId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION_COND_STSF index.
		/// </summary>
		/// <param name="_saPromotionCondStsfId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotionCondStsf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotionCondStsf GetBySaPromotionCondStsfId(System.Decimal _saPromotionCondStsfId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPromotionCondStsfId(null, _saPromotionCondStsfId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION_COND_STSF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionCondStsfId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotionCondStsf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotionCondStsf GetBySaPromotionCondStsfId(TransactionManager transactionManager, System.Decimal _saPromotionCondStsfId)
		{
			int count = -1;
			return GetBySaPromotionCondStsfId(transactionManager, _saPromotionCondStsfId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION_COND_STSF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionCondStsfId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotionCondStsf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotionCondStsf GetBySaPromotionCondStsfId(TransactionManager transactionManager, System.Decimal _saPromotionCondStsfId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPromotionCondStsfId(transactionManager, _saPromotionCondStsfId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION_COND_STSF index.
		/// </summary>
		/// <param name="_saPromotionCondStsfId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotionCondStsf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotionCondStsf GetBySaPromotionCondStsfId(System.Decimal _saPromotionCondStsfId, int start, int pageLength, out int count)
		{
			return GetBySaPromotionCondStsfId(null, _saPromotionCondStsfId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION_COND_STSF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionCondStsfId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotionCondStsf"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaPromotionCondStsf GetBySaPromotionCondStsfId(TransactionManager transactionManager, System.Decimal _saPromotionCondStsfId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaPromotionCondStsf&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaPromotionCondStsf&gt;"/></returns>
		public static TList<SaPromotionCondStsf> Fill(IDataReader reader, TList<SaPromotionCondStsf> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaPromotionCondStsf c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaPromotionCondStsf")
					.Append("|").Append((System.Decimal)reader["SA_PROMOTION_COND_STSF_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaPromotionCondStsf>(
					key.ToString(), // EntityTrackingKey
					"SaPromotionCondStsf",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaPromotionCondStsf();
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
					c.SaPromotionCondStsfId = (System.Decimal)reader["SA_PROMOTION_COND_STSF_ID"];
					c.OriginalSaPromotionCondStsfId = c.SaPromotionCondStsfId;
					c.IsSatisfied = (System.Decimal)reader["IS_SATISFIED"];
					c.SaPromotionCondId = (System.Decimal)reader["SA_PROMOTION_COND_ID"];
					c.SaPromotionRequestId = (System.Decimal)reader["SA_PROMOTION_REQUEST_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.Comments = Convert.IsDBNull(reader["COMMENTS"]) ? null : (System.String)reader["COMMENTS"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaPromotionCondStsf"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPromotionCondStsf"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaPromotionCondStsf entity)
		{
			if (!reader.Read()) return;
			
			entity.SaPromotionCondStsfId = (System.Decimal)reader[((int)SaPromotionCondStsfColumn.SaPromotionCondStsfId - 1)];
			entity.OriginalSaPromotionCondStsfId = (System.Decimal)reader["SA_PROMOTION_COND_STSF_ID"];
			entity.IsSatisfied = (System.Decimal)reader[((int)SaPromotionCondStsfColumn.IsSatisfied - 1)];
			entity.SaPromotionCondId = (System.Decimal)reader[((int)SaPromotionCondStsfColumn.SaPromotionCondId - 1)];
			entity.SaPromotionRequestId = (System.Decimal)reader[((int)SaPromotionCondStsfColumn.SaPromotionRequestId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaPromotionCondStsfColumn.AsFacultyInfoId - 1)];
			entity.Comments = (reader.IsDBNull(((int)SaPromotionCondStsfColumn.Comments - 1)))?null:(System.String)reader[((int)SaPromotionCondStsfColumn.Comments - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaPromotionCondStsf"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPromotionCondStsf"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaPromotionCondStsf entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaPromotionCondStsfId = (System.Decimal)dataRow["SA_PROMOTION_COND_STSF_ID"];
			entity.OriginalSaPromotionCondStsfId = (System.Decimal)dataRow["SA_PROMOTION_COND_STSF_ID"];
			entity.IsSatisfied = (System.Decimal)dataRow["IS_SATISFIED"];
			entity.SaPromotionCondId = (System.Decimal)dataRow["SA_PROMOTION_COND_ID"];
			entity.SaPromotionRequestId = (System.Decimal)dataRow["SA_PROMOTION_REQUEST_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.Comments = Convert.IsDBNull(dataRow["COMMENTS"]) ? null : (System.String)dataRow["COMMENTS"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPromotionCondStsf"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaPromotionCondStsf Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPromotionCondStsf entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaPromotionRequestIdSource	
			if (CanDeepLoad(entity, "SaPromotionRequest|SaPromotionRequestIdSource", deepLoadType, innerList) 
				&& entity.SaPromotionRequestIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaPromotionRequestId;
				SaPromotionRequest tmpEntity = EntityManager.LocateEntity<SaPromotionRequest>(EntityLocator.ConstructKeyFromPkItems(typeof(SaPromotionRequest), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaPromotionRequestIdSource = tmpEntity;
				else
					entity.SaPromotionRequestIdSource = DataRepository.SaPromotionRequestProvider.GetBySaPromotionRequestId(transactionManager, entity.SaPromotionRequestId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPromotionRequestIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaPromotionRequestIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaPromotionRequestProvider.DeepLoad(transactionManager, entity.SaPromotionRequestIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaPromotionRequestIdSource

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

			#region SaPromotionCondIdSource	
			if (CanDeepLoad(entity, "SaPromotionCond|SaPromotionCondIdSource", deepLoadType, innerList) 
				&& entity.SaPromotionCondIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaPromotionCondId;
				SaPromotionCond tmpEntity = EntityManager.LocateEntity<SaPromotionCond>(EntityLocator.ConstructKeyFromPkItems(typeof(SaPromotionCond), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaPromotionCondIdSource = tmpEntity;
				else
					entity.SaPromotionCondIdSource = DataRepository.SaPromotionCondProvider.GetBySaPromotionCondId(transactionManager, entity.SaPromotionCondId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPromotionCondIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaPromotionCondIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaPromotionCondProvider.DeepLoad(transactionManager, entity.SaPromotionCondIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaPromotionCondIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaPromotionCondStsf object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaPromotionCondStsf instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaPromotionCondStsf Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPromotionCondStsf entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaPromotionRequestIdSource
			if (CanDeepSave(entity, "SaPromotionRequest|SaPromotionRequestIdSource", deepSaveType, innerList) 
				&& entity.SaPromotionRequestIdSource != null)
			{
				DataRepository.SaPromotionRequestProvider.Save(transactionManager, entity.SaPromotionRequestIdSource);
				entity.SaPromotionRequestId = entity.SaPromotionRequestIdSource.SaPromotionRequestId;
			}
			#endregion 
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region SaPromotionCondIdSource
			if (CanDeepSave(entity, "SaPromotionCond|SaPromotionCondIdSource", deepSaveType, innerList) 
				&& entity.SaPromotionCondIdSource != null)
			{
				DataRepository.SaPromotionCondProvider.Save(transactionManager, entity.SaPromotionCondIdSource);
				entity.SaPromotionCondId = entity.SaPromotionCondIdSource.SaPromotionCondId;
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
	
	#region SaPromotionCondStsfChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaPromotionCondStsf</c>
	///</summary>
	public enum SaPromotionCondStsfChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaPromotionRequest</c> at SaPromotionRequestIdSource
		///</summary>
		[ChildEntityType(typeof(SaPromotionRequest))]
		SaPromotionRequest,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>SaPromotionCond</c> at SaPromotionCondIdSource
		///</summary>
		[ChildEntityType(typeof(SaPromotionCond))]
		SaPromotionCond,
	}
	
	#endregion SaPromotionCondStsfChildEntityTypes
	
	#region SaPromotionCondStsfFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaPromotionCondStsfColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPromotionCondStsf"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaPromotionCondStsfFilterBuilder : SqlFilterBuilder<SaPromotionCondStsfColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPromotionCondStsfFilterBuilder class.
		/// </summary>
		public SaPromotionCondStsfFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaPromotionCondStsfFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaPromotionCondStsfFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaPromotionCondStsfFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaPromotionCondStsfFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaPromotionCondStsfFilterBuilder
	
	#region SaPromotionCondStsfParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaPromotionCondStsfColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPromotionCondStsf"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaPromotionCondStsfParameterBuilder : ParameterizedSqlFilterBuilder<SaPromotionCondStsfColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPromotionCondStsfParameterBuilder class.
		/// </summary>
		public SaPromotionCondStsfParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaPromotionCondStsfParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaPromotionCondStsfParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaPromotionCondStsfParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaPromotionCondStsfParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaPromotionCondStsfParameterBuilder
	
	#region SaPromotionCondStsfSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaPromotionCondStsfColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPromotionCondStsf"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaPromotionCondStsfSortBuilder : SqlSortBuilder<SaPromotionCondStsfColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPromotionCondStsfSqlSortBuilder class.
		/// </summary>
		public SaPromotionCondStsfSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaPromotionCondStsfSortBuilder
	
} // end namespace
