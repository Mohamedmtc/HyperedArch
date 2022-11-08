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
	/// This class is the base class for any <see cref="AdmAppMediaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppMediaProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppMedia, UMIS_VER2.BusinessLyer.AdmAppMediaKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppMediaKey key)
		{
			return Delete(transactionManager, key.AdmAppMediaId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppMediaId">طريقة التعرف على الجامعة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppMediaId)
		{
			return Delete(null, _admAppMediaId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppMediaId">طريقة التعرف على الجامعة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppMediaId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_MEDIA_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_MEDIA_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppMedia objects.</returns>
		public TList<AdmAppMedia> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_MEDIA_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_MEDIA_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppMedia objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppMedia> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_MEDIA_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_MEDIA_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppMedia objects.</returns>
		public TList<AdmAppMedia> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_MEDIA_ADM_APP_REG_HISTORY key.
		///		fkAdmAppMediaAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppMedia objects.</returns>
		public TList<AdmAppMedia> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_MEDIA_ADM_APP_REG_HISTORY key.
		///		fkAdmAppMediaAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppMedia objects.</returns>
		public TList<AdmAppMedia> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_MEDIA_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_MEDIA_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppMedia objects.</returns>
		public abstract TList<AdmAppMedia> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_MEDIA_ADM_APPLICANT key.
		///		FK_ADM_APP_MEDIA_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppMedia objects.</returns>
		public TList<AdmAppMedia> GetByAdmApplicantId(System.Decimal _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_MEDIA_ADM_APPLICANT key.
		///		FK_ADM_APP_MEDIA_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppMedia objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppMedia> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_MEDIA_ADM_APPLICANT key.
		///		FK_ADM_APP_MEDIA_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppMedia objects.</returns>
		public TList<AdmAppMedia> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_MEDIA_ADM_APPLICANT key.
		///		fkAdmAppMediaAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppMedia objects.</returns>
		public TList<AdmAppMedia> GetByAdmApplicantId(System.Decimal _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_MEDIA_ADM_APPLICANT key.
		///		fkAdmAppMediaAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppMedia objects.</returns>
		public TList<AdmAppMedia> GetByAdmApplicantId(System.Decimal _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_MEDIA_ADM_APPLICANT key.
		///		FK_ADM_APP_MEDIA_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppMedia objects.</returns>
		public abstract TList<AdmAppMedia> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_MEDIA_ADM_CDE_MEDIA key.
		///		FK_ADM_APP_MEDIA_ADM_CDE_MEDIA Description: 
		/// </summary>
		/// <param name="_admCdeMediaId">طريقة التعرف على الجامعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppMedia objects.</returns>
		public TList<AdmAppMedia> GetByAdmCdeMediaId(System.Int32 _admCdeMediaId)
		{
			int count = -1;
			return GetByAdmCdeMediaId(_admCdeMediaId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_MEDIA_ADM_CDE_MEDIA key.
		///		FK_ADM_APP_MEDIA_ADM_CDE_MEDIA Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeMediaId">طريقة التعرف على الجامعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppMedia objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppMedia> GetByAdmCdeMediaId(TransactionManager transactionManager, System.Int32 _admCdeMediaId)
		{
			int count = -1;
			return GetByAdmCdeMediaId(transactionManager, _admCdeMediaId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_MEDIA_ADM_CDE_MEDIA key.
		///		FK_ADM_APP_MEDIA_ADM_CDE_MEDIA Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeMediaId">طريقة التعرف على الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppMedia objects.</returns>
		public TList<AdmAppMedia> GetByAdmCdeMediaId(TransactionManager transactionManager, System.Int32 _admCdeMediaId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeMediaId(transactionManager, _admCdeMediaId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_MEDIA_ADM_CDE_MEDIA key.
		///		fkAdmAppMediaAdmCdeMedia Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeMediaId">طريقة التعرف على الجامعة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppMedia objects.</returns>
		public TList<AdmAppMedia> GetByAdmCdeMediaId(System.Int32 _admCdeMediaId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeMediaId(null, _admCdeMediaId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_MEDIA_ADM_CDE_MEDIA key.
		///		fkAdmAppMediaAdmCdeMedia Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeMediaId">طريقة التعرف على الجامعة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppMedia objects.</returns>
		public TList<AdmAppMedia> GetByAdmCdeMediaId(System.Int32 _admCdeMediaId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeMediaId(null, _admCdeMediaId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_MEDIA_ADM_CDE_MEDIA key.
		///		FK_ADM_APP_MEDIA_ADM_CDE_MEDIA Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeMediaId">طريقة التعرف على الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppMedia objects.</returns>
		public abstract TList<AdmAppMedia> GetByAdmCdeMediaId(TransactionManager transactionManager, System.Int32 _admCdeMediaId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppMedia Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppMediaKey key, int start, int pageLength)
		{
			return GetByAdmAppMediaId(transactionManager, key.AdmAppMediaId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_MEDIA index.
		/// </summary>
		/// <param name="_admAppMediaId">طريقة التعرف على الجامعة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppMedia"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppMedia GetByAdmAppMediaId(System.Decimal _admAppMediaId)
		{
			int count = -1;
			return GetByAdmAppMediaId(null,_admAppMediaId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_MEDIA index.
		/// </summary>
		/// <param name="_admAppMediaId">طريقة التعرف على الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppMedia"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppMedia GetByAdmAppMediaId(System.Decimal _admAppMediaId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppMediaId(null, _admAppMediaId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_MEDIA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppMediaId">طريقة التعرف على الجامعة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppMedia"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppMedia GetByAdmAppMediaId(TransactionManager transactionManager, System.Decimal _admAppMediaId)
		{
			int count = -1;
			return GetByAdmAppMediaId(transactionManager, _admAppMediaId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_MEDIA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppMediaId">طريقة التعرف على الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppMedia"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppMedia GetByAdmAppMediaId(TransactionManager transactionManager, System.Decimal _admAppMediaId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppMediaId(transactionManager, _admAppMediaId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_MEDIA index.
		/// </summary>
		/// <param name="_admAppMediaId">طريقة التعرف على الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppMedia"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppMedia GetByAdmAppMediaId(System.Decimal _admAppMediaId, int start, int pageLength, out int count)
		{
			return GetByAdmAppMediaId(null, _admAppMediaId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_MEDIA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppMediaId">طريقة التعرف على الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppMedia"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppMedia GetByAdmAppMediaId(TransactionManager transactionManager, System.Decimal _admAppMediaId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppMedia&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppMedia&gt;"/></returns>
		public static TList<AdmAppMedia> Fill(IDataReader reader, TList<AdmAppMedia> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppMedia c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppMedia")
					.Append("|").Append((System.Decimal)reader["ADM_APP_MEDIA_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppMedia>(
					key.ToString(), // EntityTrackingKey
					"AdmAppMedia",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppMedia();
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
					c.AdmAppMediaId = (System.Decimal)reader["ADM_APP_MEDIA_ID"];
					c.OriginalAdmAppMediaId = c.AdmAppMediaId;
					c.AdmApplicantId = (System.Decimal)reader["ADM_APPLICANT_ID"];
					c.AdmCdeMediaId = (System.Int32)reader["ADM_CDE_MEDIA_ID"];
					c.MediaNotes = Convert.IsDBNull(reader["MEDIA_NOTES"]) ? null : (System.String)reader["MEDIA_NOTES"];
					c.AdmAppRegHistoryId = Convert.IsDBNull(reader["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)reader["ADM_APP_REG_HISTORY_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppMedia"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppMedia"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppMedia entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppMediaId = (System.Decimal)reader[((int)AdmAppMediaColumn.AdmAppMediaId - 1)];
			entity.OriginalAdmAppMediaId = (System.Decimal)reader["ADM_APP_MEDIA_ID"];
			entity.AdmApplicantId = (System.Decimal)reader[((int)AdmAppMediaColumn.AdmApplicantId - 1)];
			entity.AdmCdeMediaId = (System.Int32)reader[((int)AdmAppMediaColumn.AdmCdeMediaId - 1)];
			entity.MediaNotes = (reader.IsDBNull(((int)AdmAppMediaColumn.MediaNotes - 1)))?null:(System.String)reader[((int)AdmAppMediaColumn.MediaNotes - 1)];
			entity.AdmAppRegHistoryId = (reader.IsDBNull(((int)AdmAppMediaColumn.AdmAppRegHistoryId - 1)))?null:(System.Decimal?)reader[((int)AdmAppMediaColumn.AdmAppRegHistoryId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppMedia"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppMedia"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppMedia entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppMediaId = (System.Decimal)dataRow["ADM_APP_MEDIA_ID"];
			entity.OriginalAdmAppMediaId = (System.Decimal)dataRow["ADM_APP_MEDIA_ID"];
			entity.AdmApplicantId = (System.Decimal)dataRow["ADM_APPLICANT_ID"];
			entity.AdmCdeMediaId = (System.Int32)dataRow["ADM_CDE_MEDIA_ID"];
			entity.MediaNotes = Convert.IsDBNull(dataRow["MEDIA_NOTES"]) ? null : (System.String)dataRow["MEDIA_NOTES"];
			entity.AdmAppRegHistoryId = Convert.IsDBNull(dataRow["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_REG_HISTORY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppMedia"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppMedia Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppMedia entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region AdmCdeMediaIdSource	
			if (CanDeepLoad(entity, "AdmCdeMedia|AdmCdeMediaIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeMediaIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmCdeMediaId;
				AdmCdeMedia tmpEntity = EntityManager.LocateEntity<AdmCdeMedia>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeMedia), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeMediaIdSource = tmpEntity;
				else
					entity.AdmCdeMediaIdSource = DataRepository.AdmCdeMediaProvider.GetByAdmCdeMediaId(transactionManager, entity.AdmCdeMediaId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeMediaIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeMediaIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeMediaProvider.DeepLoad(transactionManager, entity.AdmCdeMediaIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeMediaIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppMedia object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppMedia instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppMedia Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppMedia entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region AdmCdeMediaIdSource
			if (CanDeepSave(entity, "AdmCdeMedia|AdmCdeMediaIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeMediaIdSource != null)
			{
				DataRepository.AdmCdeMediaProvider.Save(transactionManager, entity.AdmCdeMediaIdSource);
				entity.AdmCdeMediaId = entity.AdmCdeMediaIdSource.AdmCdeMediaId;
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
	
	#region AdmAppMediaChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppMedia</c>
	///</summary>
	public enum AdmAppMediaChildEntityTypes
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
		/// Composite Property for <c>AdmCdeMedia</c> at AdmCdeMediaIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeMedia))]
		AdmCdeMedia,
	}
	
	#endregion AdmAppMediaChildEntityTypes
	
	#region AdmAppMediaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppMediaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppMedia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppMediaFilterBuilder : SqlFilterBuilder<AdmAppMediaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppMediaFilterBuilder class.
		/// </summary>
		public AdmAppMediaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppMediaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppMediaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppMediaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppMediaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppMediaFilterBuilder
	
	#region AdmAppMediaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppMediaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppMedia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppMediaParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppMediaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppMediaParameterBuilder class.
		/// </summary>
		public AdmAppMediaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppMediaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppMediaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppMediaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppMediaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppMediaParameterBuilder
	
	#region AdmAppMediaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppMediaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppMedia"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppMediaSortBuilder : SqlSortBuilder<AdmAppMediaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppMediaSqlSortBuilder class.
		/// </summary>
		public AdmAppMediaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppMediaSortBuilder
	
} // end namespace
