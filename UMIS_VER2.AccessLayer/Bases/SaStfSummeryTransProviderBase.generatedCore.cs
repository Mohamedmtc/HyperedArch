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
	/// This class is the base class for any <see cref="SaStfSummeryTransProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaStfSummeryTransProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaStfSummeryTrans, UMIS_VER2.BusinessLyer.SaStfSummeryTransKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaStfSummeryTransKey key)
		{
			return Delete(transactionManager, key.SaStfSummeryTransId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saStfSummeryTransId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saStfSummeryTransId)
		{
			return Delete(null, _saStfSummeryTransId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfSummeryTransId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saStfSummeryTransId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002c key.
		///		FK_AUTO_002c Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfSummeryTrans objects.</returns>
		public TList<SaStfSummeryTrans> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002c key.
		///		FK_AUTO_002c Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfSummeryTrans objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfSummeryTrans> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002c key.
		///		FK_AUTO_002c Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfSummeryTrans objects.</returns>
		public TList<SaStfSummeryTrans> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002c key.
		///		fkAuto002c Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfSummeryTrans objects.</returns>
		public TList<SaStfSummeryTrans> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002c key.
		///		fkAuto002c Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfSummeryTrans objects.</returns>
		public TList<SaStfSummeryTrans> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002c key.
		///		FK_AUTO_002c Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfSummeryTrans objects.</returns>
		public abstract TList<SaStfSummeryTrans> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_036c key.
		///		FK_AUTO_036c Description: 
		/// </summary>
		/// <param name="_saCodeSummeryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfSummeryTrans objects.</returns>
		public TList<SaStfSummeryTrans> GetBySaCodeSummeryId(System.Decimal _saCodeSummeryId)
		{
			int count = -1;
			return GetBySaCodeSummeryId(_saCodeSummeryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_036c key.
		///		FK_AUTO_036c Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSummeryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfSummeryTrans objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfSummeryTrans> GetBySaCodeSummeryId(TransactionManager transactionManager, System.Decimal _saCodeSummeryId)
		{
			int count = -1;
			return GetBySaCodeSummeryId(transactionManager, _saCodeSummeryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_036c key.
		///		FK_AUTO_036c Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSummeryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfSummeryTrans objects.</returns>
		public TList<SaStfSummeryTrans> GetBySaCodeSummeryId(TransactionManager transactionManager, System.Decimal _saCodeSummeryId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeSummeryId(transactionManager, _saCodeSummeryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_036c key.
		///		fkAuto036c Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeSummeryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfSummeryTrans objects.</returns>
		public TList<SaStfSummeryTrans> GetBySaCodeSummeryId(System.Decimal _saCodeSummeryId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeSummeryId(null, _saCodeSummeryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_036c key.
		///		fkAuto036c Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeSummeryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfSummeryTrans objects.</returns>
		public TList<SaStfSummeryTrans> GetBySaCodeSummeryId(System.Decimal _saCodeSummeryId, int start, int pageLength,out int count)
		{
			return GetBySaCodeSummeryId(null, _saCodeSummeryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_036c key.
		///		FK_AUTO_036c Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSummeryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfSummeryTrans objects.</returns>
		public abstract TList<SaStfSummeryTrans> GetBySaCodeSummeryId(TransactionManager transactionManager, System.Decimal _saCodeSummeryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_SUMMERY_TRANS_SA_CODE_JOB_STATUS key.
		///		FK_SA_STF_SUMMERY_TRANS_SA_CODE_JOB_STATUS Description: 
		/// </summary>
		/// <param name="_saCodeJobStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfSummeryTrans objects.</returns>
		public TList<SaStfSummeryTrans> GetBySaCodeJobStatusId(System.Decimal _saCodeJobStatusId)
		{
			int count = -1;
			return GetBySaCodeJobStatusId(_saCodeJobStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_SUMMERY_TRANS_SA_CODE_JOB_STATUS key.
		///		FK_SA_STF_SUMMERY_TRANS_SA_CODE_JOB_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfSummeryTrans objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfSummeryTrans> GetBySaCodeJobStatusId(TransactionManager transactionManager, System.Decimal _saCodeJobStatusId)
		{
			int count = -1;
			return GetBySaCodeJobStatusId(transactionManager, _saCodeJobStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_SUMMERY_TRANS_SA_CODE_JOB_STATUS key.
		///		FK_SA_STF_SUMMERY_TRANS_SA_CODE_JOB_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfSummeryTrans objects.</returns>
		public TList<SaStfSummeryTrans> GetBySaCodeJobStatusId(TransactionManager transactionManager, System.Decimal _saCodeJobStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeJobStatusId(transactionManager, _saCodeJobStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_SUMMERY_TRANS_SA_CODE_JOB_STATUS key.
		///		fkSaStfSummeryTransSaCodeJobStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfSummeryTrans objects.</returns>
		public TList<SaStfSummeryTrans> GetBySaCodeJobStatusId(System.Decimal _saCodeJobStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeJobStatusId(null, _saCodeJobStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_SUMMERY_TRANS_SA_CODE_JOB_STATUS key.
		///		fkSaStfSummeryTransSaCodeJobStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfSummeryTrans objects.</returns>
		public TList<SaStfSummeryTrans> GetBySaCodeJobStatusId(System.Decimal _saCodeJobStatusId, int start, int pageLength,out int count)
		{
			return GetBySaCodeJobStatusId(null, _saCodeJobStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_SUMMERY_TRANS_SA_CODE_JOB_STATUS key.
		///		FK_SA_STF_SUMMERY_TRANS_SA_CODE_JOB_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfSummeryTrans objects.</returns>
		public abstract TList<SaStfSummeryTrans> GetBySaCodeJobStatusId(TransactionManager transactionManager, System.Decimal _saCodeJobStatusId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaStfSummeryTrans Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaStfSummeryTransKey key, int start, int pageLength)
		{
			return GetBySaStfSummeryTransId(transactionManager, key.SaStfSummeryTransId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_STF_SUMMERY_TRANS index.
		/// </summary>
		/// <param name="_saStfSummeryTransId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfSummeryTrans"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfSummeryTrans GetBySaStfSummeryTransId(System.Decimal _saStfSummeryTransId)
		{
			int count = -1;
			return GetBySaStfSummeryTransId(null,_saStfSummeryTransId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_STF_SUMMERY_TRANS index.
		/// </summary>
		/// <param name="_saStfSummeryTransId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfSummeryTrans"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfSummeryTrans GetBySaStfSummeryTransId(System.Decimal _saStfSummeryTransId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfSummeryTransId(null, _saStfSummeryTransId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_STF_SUMMERY_TRANS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfSummeryTransId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfSummeryTrans"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfSummeryTrans GetBySaStfSummeryTransId(TransactionManager transactionManager, System.Decimal _saStfSummeryTransId)
		{
			int count = -1;
			return GetBySaStfSummeryTransId(transactionManager, _saStfSummeryTransId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_STF_SUMMERY_TRANS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfSummeryTransId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfSummeryTrans"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfSummeryTrans GetBySaStfSummeryTransId(TransactionManager transactionManager, System.Decimal _saStfSummeryTransId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfSummeryTransId(transactionManager, _saStfSummeryTransId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_STF_SUMMERY_TRANS index.
		/// </summary>
		/// <param name="_saStfSummeryTransId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfSummeryTrans"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfSummeryTrans GetBySaStfSummeryTransId(System.Decimal _saStfSummeryTransId, int start, int pageLength, out int count)
		{
			return GetBySaStfSummeryTransId(null, _saStfSummeryTransId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_STF_SUMMERY_TRANS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfSummeryTransId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfSummeryTrans"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaStfSummeryTrans GetBySaStfSummeryTransId(TransactionManager transactionManager, System.Decimal _saStfSummeryTransId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaStfSummeryTrans&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaStfSummeryTrans&gt;"/></returns>
		public static TList<SaStfSummeryTrans> Fill(IDataReader reader, TList<SaStfSummeryTrans> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaStfSummeryTrans c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaStfSummeryTrans")
					.Append("|").Append((System.Decimal)reader["SA_STF_SUMMERY_TRANS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaStfSummeryTrans>(
					key.ToString(), // EntityTrackingKey
					"SaStfSummeryTrans",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaStfSummeryTrans();
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
					c.SaStfSummeryTransId = (System.Decimal)reader["SA_STF_SUMMERY_TRANS_ID"];
					c.OriginalSaStfSummeryTransId = c.SaStfSummeryTransId;
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.SaCodeSummeryId = (System.Decimal)reader["SA_CODE_SUMMERY_ID"];
					c.SaCodeJobStatusId = (System.Decimal)reader["SA_CODE_JOB_STATUS_ID"];
					c.FromDate = (System.DateTime)reader["FROM_DATE"];
					c.ToDate = Convert.IsDBNull(reader["TO_DATE"]) ? null : (System.DateTime?)reader["TO_DATE"];
					c.ExtendedToDate = Convert.IsDBNull(reader["EXTENDED_TO_DATE"]) ? null : (System.DateTime?)reader["EXTENDED_TO_DATE"];
					c.ActEndDate = Convert.IsDBNull(reader["ACT_END_DATE"]) ? null : (System.DateTime?)reader["ACT_END_DATE"];
					c.TransactionId = (System.Decimal)reader["TRANSACTION_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaStfSummeryTrans"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaStfSummeryTrans"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaStfSummeryTrans entity)
		{
			if (!reader.Read()) return;
			
			entity.SaStfSummeryTransId = (System.Decimal)reader[((int)SaStfSummeryTransColumn.SaStfSummeryTransId - 1)];
			entity.OriginalSaStfSummeryTransId = (System.Decimal)reader["SA_STF_SUMMERY_TRANS_ID"];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaStfSummeryTransColumn.SaStfMemberId - 1)];
			entity.SaCodeSummeryId = (System.Decimal)reader[((int)SaStfSummeryTransColumn.SaCodeSummeryId - 1)];
			entity.SaCodeJobStatusId = (System.Decimal)reader[((int)SaStfSummeryTransColumn.SaCodeJobStatusId - 1)];
			entity.FromDate = (System.DateTime)reader[((int)SaStfSummeryTransColumn.FromDate - 1)];
			entity.ToDate = (reader.IsDBNull(((int)SaStfSummeryTransColumn.ToDate - 1)))?null:(System.DateTime?)reader[((int)SaStfSummeryTransColumn.ToDate - 1)];
			entity.ExtendedToDate = (reader.IsDBNull(((int)SaStfSummeryTransColumn.ExtendedToDate - 1)))?null:(System.DateTime?)reader[((int)SaStfSummeryTransColumn.ExtendedToDate - 1)];
			entity.ActEndDate = (reader.IsDBNull(((int)SaStfSummeryTransColumn.ActEndDate - 1)))?null:(System.DateTime?)reader[((int)SaStfSummeryTransColumn.ActEndDate - 1)];
			entity.TransactionId = (System.Decimal)reader[((int)SaStfSummeryTransColumn.TransactionId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaStfSummeryTrans"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaStfSummeryTrans"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaStfSummeryTrans entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaStfSummeryTransId = (System.Decimal)dataRow["SA_STF_SUMMERY_TRANS_ID"];
			entity.OriginalSaStfSummeryTransId = (System.Decimal)dataRow["SA_STF_SUMMERY_TRANS_ID"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.SaCodeSummeryId = (System.Decimal)dataRow["SA_CODE_SUMMERY_ID"];
			entity.SaCodeJobStatusId = (System.Decimal)dataRow["SA_CODE_JOB_STATUS_ID"];
			entity.FromDate = (System.DateTime)dataRow["FROM_DATE"];
			entity.ToDate = Convert.IsDBNull(dataRow["TO_DATE"]) ? null : (System.DateTime?)dataRow["TO_DATE"];
			entity.ExtendedToDate = Convert.IsDBNull(dataRow["EXTENDED_TO_DATE"]) ? null : (System.DateTime?)dataRow["EXTENDED_TO_DATE"];
			entity.ActEndDate = Convert.IsDBNull(dataRow["ACT_END_DATE"]) ? null : (System.DateTime?)dataRow["ACT_END_DATE"];
			entity.TransactionId = (System.Decimal)dataRow["TRANSACTION_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaStfSummeryTrans"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaStfSummeryTrans Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaStfSummeryTrans entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaStfMemberId;
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemberIdSource

			#region SaCodeSummeryIdSource	
			if (CanDeepLoad(entity, "SaCodeSummery|SaCodeSummeryIdSource", deepLoadType, innerList) 
				&& entity.SaCodeSummeryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeSummeryId;
				SaCodeSummery tmpEntity = EntityManager.LocateEntity<SaCodeSummery>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeSummery), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeSummeryIdSource = tmpEntity;
				else
					entity.SaCodeSummeryIdSource = DataRepository.SaCodeSummeryProvider.GetBySaCodeSummeryId(transactionManager, entity.SaCodeSummeryId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeSummeryIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeSummeryIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeSummeryProvider.DeepLoad(transactionManager, entity.SaCodeSummeryIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeSummeryIdSource

			#region SaCodeJobStatusIdSource	
			if (CanDeepLoad(entity, "SaCodeJobStatus|SaCodeJobStatusIdSource", deepLoadType, innerList) 
				&& entity.SaCodeJobStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeJobStatusId;
				SaCodeJobStatus tmpEntity = EntityManager.LocateEntity<SaCodeJobStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeJobStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeJobStatusIdSource = tmpEntity;
				else
					entity.SaCodeJobStatusIdSource = DataRepository.SaCodeJobStatusProvider.GetBySaCodeJobStatusId(transactionManager, entity.SaCodeJobStatusId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeJobStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeJobStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeJobStatusProvider.DeepLoad(transactionManager, entity.SaCodeJobStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeJobStatusIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaStfSummeryTrans object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaStfSummeryTrans instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaStfSummeryTrans Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaStfSummeryTrans entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
			}
			#endregion 
			
			#region SaCodeSummeryIdSource
			if (CanDeepSave(entity, "SaCodeSummery|SaCodeSummeryIdSource", deepSaveType, innerList) 
				&& entity.SaCodeSummeryIdSource != null)
			{
				DataRepository.SaCodeSummeryProvider.Save(transactionManager, entity.SaCodeSummeryIdSource);
				entity.SaCodeSummeryId = entity.SaCodeSummeryIdSource.SaCodeSummeryId;
			}
			#endregion 
			
			#region SaCodeJobStatusIdSource
			if (CanDeepSave(entity, "SaCodeJobStatus|SaCodeJobStatusIdSource", deepSaveType, innerList) 
				&& entity.SaCodeJobStatusIdSource != null)
			{
				DataRepository.SaCodeJobStatusProvider.Save(transactionManager, entity.SaCodeJobStatusIdSource);
				entity.SaCodeJobStatusId = entity.SaCodeJobStatusIdSource.SaCodeJobStatusId;
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
	
	#region SaStfSummeryTransChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaStfSummeryTrans</c>
	///</summary>
	public enum SaStfSummeryTransChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>SaCodeSummery</c> at SaCodeSummeryIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeSummery))]
		SaCodeSummery,
		
		///<summary>
		/// Composite Property for <c>SaCodeJobStatus</c> at SaCodeJobStatusIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeJobStatus))]
		SaCodeJobStatus,
	}
	
	#endregion SaStfSummeryTransChildEntityTypes
	
	#region SaStfSummeryTransFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaStfSummeryTransColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaStfSummeryTrans"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaStfSummeryTransFilterBuilder : SqlFilterBuilder<SaStfSummeryTransColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaStfSummeryTransFilterBuilder class.
		/// </summary>
		public SaStfSummeryTransFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaStfSummeryTransFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaStfSummeryTransFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaStfSummeryTransFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaStfSummeryTransFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaStfSummeryTransFilterBuilder
	
	#region SaStfSummeryTransParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaStfSummeryTransColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaStfSummeryTrans"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaStfSummeryTransParameterBuilder : ParameterizedSqlFilterBuilder<SaStfSummeryTransColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaStfSummeryTransParameterBuilder class.
		/// </summary>
		public SaStfSummeryTransParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaStfSummeryTransParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaStfSummeryTransParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaStfSummeryTransParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaStfSummeryTransParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaStfSummeryTransParameterBuilder
	
	#region SaStfSummeryTransSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaStfSummeryTransColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaStfSummeryTrans"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaStfSummeryTransSortBuilder : SqlSortBuilder<SaStfSummeryTransColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaStfSummeryTransSqlSortBuilder class.
		/// </summary>
		public SaStfSummeryTransSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaStfSummeryTransSortBuilder
	
} // end namespace
