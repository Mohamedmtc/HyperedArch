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
	/// This class is the base class for any <see cref="ScScheduleHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScScheduleHdrProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScScheduleHdr, UMIS_VER2.BusinessLyer.ScScheduleHdrKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleHdrKey key)
		{
			return Delete(transactionManager, key.ScScheduleHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scScheduleHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scScheduleHdrId)
		{
			return Delete(null, _scScheduleHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scScheduleHdrId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_HDR_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_SCHEDULE_HDR_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleHdr objects.</returns>
		public TList<ScScheduleHdr> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(_edCodeCourseTeachingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_HDR_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_SCHEDULE_HDR_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleHdr objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleHdr> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(transactionManager, _edCodeCourseTeachingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_HDR_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_SCHEDULE_HDR_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleHdr objects.</returns>
		public TList<ScScheduleHdr> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(transactionManager, _edCodeCourseTeachingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_HDR_ED_CODE_COURSE_TEACHING key.
		///		fkScScheduleHdrEdCodeCourseTeaching Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleHdr objects.</returns>
		public TList<ScScheduleHdr> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseTeachingId(null, _edCodeCourseTeachingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_HDR_ED_CODE_COURSE_TEACHING key.
		///		fkScScheduleHdrEdCodeCourseTeaching Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleHdr objects.</returns>
		public TList<ScScheduleHdr> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseTeachingId(null, _edCodeCourseTeachingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_HDR_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_SCHEDULE_HDR_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleHdr objects.</returns>
		public abstract TList<ScScheduleHdr> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_HDR_ED_COURSE_INSTANCE key.
		///		FK_SC_SCHEDULE_HDR_ED_COURSE_INSTANCE Description: 
		/// </summary>
		/// <param name="_edOfferingCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleHdr objects.</returns>
		public TList<ScScheduleHdr> GetByEdOfferingCourseId(System.Decimal _edOfferingCourseId)
		{
			int count = -1;
			return GetByEdOfferingCourseId(_edOfferingCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_HDR_ED_COURSE_INSTANCE key.
		///		FK_SC_SCHEDULE_HDR_ED_COURSE_INSTANCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleHdr objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleHdr> GetByEdOfferingCourseId(TransactionManager transactionManager, System.Decimal _edOfferingCourseId)
		{
			int count = -1;
			return GetByEdOfferingCourseId(transactionManager, _edOfferingCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_HDR_ED_COURSE_INSTANCE key.
		///		FK_SC_SCHEDULE_HDR_ED_COURSE_INSTANCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleHdr objects.</returns>
		public TList<ScScheduleHdr> GetByEdOfferingCourseId(TransactionManager transactionManager, System.Decimal _edOfferingCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdOfferingCourseId(transactionManager, _edOfferingCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_HDR_ED_COURSE_INSTANCE key.
		///		fkScScheduleHdrEdCourseInstance Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edOfferingCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleHdr objects.</returns>
		public TList<ScScheduleHdr> GetByEdOfferingCourseId(System.Decimal _edOfferingCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdOfferingCourseId(null, _edOfferingCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_HDR_ED_COURSE_INSTANCE key.
		///		fkScScheduleHdrEdCourseInstance Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edOfferingCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleHdr objects.</returns>
		public TList<ScScheduleHdr> GetByEdOfferingCourseId(System.Decimal _edOfferingCourseId, int start, int pageLength,out int count)
		{
			return GetByEdOfferingCourseId(null, _edOfferingCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_HDR_ED_COURSE_INSTANCE key.
		///		FK_SC_SCHEDULE_HDR_ED_COURSE_INSTANCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleHdr objects.</returns>
		public abstract TList<ScScheduleHdr> GetByEdOfferingCourseId(TransactionManager transactionManager, System.Decimal _edOfferingCourseId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScScheduleHdr Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleHdrKey key, int start, int pageLength)
		{
			return GetByScScheduleHdrId(transactionManager, key.ScScheduleHdrId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_SCHEDULE_HDR index.
		/// </summary>
		/// <param name="_scScheduleHdrId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleHdr GetByScScheduleHdrId(System.Decimal _scScheduleHdrId)
		{
			int count = -1;
			return GetByScScheduleHdrId(null,_scScheduleHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_HDR index.
		/// </summary>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleHdr GetByScScheduleHdrId(System.Decimal _scScheduleHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleHdrId(null, _scScheduleHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleHdr GetByScScheduleHdrId(TransactionManager transactionManager, System.Decimal _scScheduleHdrId)
		{
			int count = -1;
			return GetByScScheduleHdrId(transactionManager, _scScheduleHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleHdr GetByScScheduleHdrId(TransactionManager transactionManager, System.Decimal _scScheduleHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleHdrId(transactionManager, _scScheduleHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_HDR index.
		/// </summary>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleHdr GetByScScheduleHdrId(System.Decimal _scScheduleHdrId, int start, int pageLength, out int count)
		{
			return GetByScScheduleHdrId(null, _scScheduleHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScScheduleHdr GetByScScheduleHdrId(TransactionManager transactionManager, System.Decimal _scScheduleHdrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SC_SCHEDULE_HDR index.
		/// </summary>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="_edOfferingCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleHdr GetByEdCodeCourseTeachingIdEdOfferingCourseId(System.Decimal? _edCodeCourseTeachingId, System.Decimal _edOfferingCourseId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingIdEdOfferingCourseId(null,_edCodeCourseTeachingId, _edOfferingCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_HDR index.
		/// </summary>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="_edOfferingCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleHdr GetByEdCodeCourseTeachingIdEdOfferingCourseId(System.Decimal? _edCodeCourseTeachingId, System.Decimal _edOfferingCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingIdEdOfferingCourseId(null, _edCodeCourseTeachingId, _edOfferingCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="_edOfferingCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleHdr GetByEdCodeCourseTeachingIdEdOfferingCourseId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId, System.Decimal _edOfferingCourseId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingIdEdOfferingCourseId(transactionManager, _edCodeCourseTeachingId, _edOfferingCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="_edOfferingCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleHdr GetByEdCodeCourseTeachingIdEdOfferingCourseId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId, System.Decimal _edOfferingCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingIdEdOfferingCourseId(transactionManager, _edCodeCourseTeachingId, _edOfferingCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_HDR index.
		/// </summary>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="_edOfferingCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleHdr GetByEdCodeCourseTeachingIdEdOfferingCourseId(System.Decimal? _edCodeCourseTeachingId, System.Decimal _edOfferingCourseId, int start, int pageLength, out int count)
		{
			return GetByEdCodeCourseTeachingIdEdOfferingCourseId(null, _edCodeCourseTeachingId, _edOfferingCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="_edOfferingCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScScheduleHdr GetByEdCodeCourseTeachingIdEdOfferingCourseId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId, System.Decimal _edOfferingCourseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScScheduleHdr&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScScheduleHdr&gt;"/></returns>
		public static TList<ScScheduleHdr> Fill(IDataReader reader, TList<ScScheduleHdr> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScScheduleHdr c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScScheduleHdr")
					.Append("|").Append((System.Decimal)reader["SC_SCHEDULE_HDR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScScheduleHdr>(
					key.ToString(), // EntityTrackingKey
					"ScScheduleHdr",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScScheduleHdr();
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
					c.ScScheduleHdrId = (System.Decimal)reader["SC_SCHEDULE_HDR_ID"];
					c.OriginalScScheduleHdrId = c.ScScheduleHdrId;
					c.EdOfferingCourseId = (System.Decimal)reader["ED_OFFERING_COURSE_ID"];
					c.EdCodeCourseTeachingId = Convert.IsDBNull(reader["ED_CODE_COURSE_TEACHING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_TEACHING_ID"];
					c.NoSlots = Convert.IsDBNull(reader["NO_SLOTS"]) ? null : (System.Decimal?)reader["NO_SLOTS"];
					c.NoGroups = Convert.IsDBNull(reader["NO_GROUPS"]) ? null : (System.Decimal?)reader["NO_GROUPS"];
					c.NoStudents = Convert.IsDBNull(reader["NO_STUDENTS"]) ? null : (System.Decimal?)reader["NO_STUDENTS"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdr"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdr"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScScheduleHdr entity)
		{
			if (!reader.Read()) return;
			
			entity.ScScheduleHdrId = (System.Decimal)reader[((int)ScScheduleHdrColumn.ScScheduleHdrId - 1)];
			entity.OriginalScScheduleHdrId = (System.Decimal)reader["SC_SCHEDULE_HDR_ID"];
			entity.EdOfferingCourseId = (System.Decimal)reader[((int)ScScheduleHdrColumn.EdOfferingCourseId - 1)];
			entity.EdCodeCourseTeachingId = (reader.IsDBNull(((int)ScScheduleHdrColumn.EdCodeCourseTeachingId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleHdrColumn.EdCodeCourseTeachingId - 1)];
			entity.NoSlots = (reader.IsDBNull(((int)ScScheduleHdrColumn.NoSlots - 1)))?null:(System.Decimal?)reader[((int)ScScheduleHdrColumn.NoSlots - 1)];
			entity.NoGroups = (reader.IsDBNull(((int)ScScheduleHdrColumn.NoGroups - 1)))?null:(System.Decimal?)reader[((int)ScScheduleHdrColumn.NoGroups - 1)];
			entity.NoStudents = (reader.IsDBNull(((int)ScScheduleHdrColumn.NoStudents - 1)))?null:(System.Decimal?)reader[((int)ScScheduleHdrColumn.NoStudents - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdr"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdr"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScScheduleHdr entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScScheduleHdrId = (System.Decimal)dataRow["SC_SCHEDULE_HDR_ID"];
			entity.OriginalScScheduleHdrId = (System.Decimal)dataRow["SC_SCHEDULE_HDR_ID"];
			entity.EdOfferingCourseId = (System.Decimal)dataRow["ED_OFFERING_COURSE_ID"];
			entity.EdCodeCourseTeachingId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_TEACHING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_TEACHING_ID"];
			entity.NoSlots = Convert.IsDBNull(dataRow["NO_SLOTS"]) ? null : (System.Decimal?)dataRow["NO_SLOTS"];
			entity.NoGroups = Convert.IsDBNull(dataRow["NO_GROUPS"]) ? null : (System.Decimal?)dataRow["NO_GROUPS"];
			entity.NoStudents = Convert.IsDBNull(dataRow["NO_STUDENTS"]) ? null : (System.Decimal?)dataRow["NO_STUDENTS"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdr"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScScheduleHdr Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleHdr entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeCourseTeachingIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseTeaching|EdCodeCourseTeachingIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseTeachingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeCourseTeachingId ?? 0.0m);
				EdCodeCourseTeaching tmpEntity = EntityManager.LocateEntity<EdCodeCourseTeaching>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseTeaching), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseTeachingIdSource = tmpEntity;
				else
					entity.EdCodeCourseTeachingIdSource = DataRepository.EdCodeCourseTeachingProvider.GetByEdCodeCourseTeachingId(transactionManager, (entity.EdCodeCourseTeachingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseTeachingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseTeachingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseTeachingProvider.DeepLoad(transactionManager, entity.EdCodeCourseTeachingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseTeachingIdSource

			#region EdOfferingCourseIdSource	
			if (CanDeepLoad(entity, "EdOfferingCourse|EdOfferingCourseIdSource", deepLoadType, innerList) 
				&& entity.EdOfferingCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdOfferingCourseId;
				EdOfferingCourse tmpEntity = EntityManager.LocateEntity<EdOfferingCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdOfferingCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdOfferingCourseIdSource = tmpEntity;
				else
					entity.EdOfferingCourseIdSource = DataRepository.EdOfferingCourseProvider.GetByEdOfferingCourseId(transactionManager, entity.EdOfferingCourseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOfferingCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdOfferingCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdOfferingCourseProvider.DeepLoad(transactionManager, entity.EdOfferingCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdOfferingCourseIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByScScheduleHdrId methods when available
			
			#region ScScheduleDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleDtl>|ScScheduleDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleDtlCollection = DataRepository.ScScheduleDtlProvider.GetByScScheduleHdrId(transactionManager, entity.ScScheduleHdrId);

				if (deep && entity.ScScheduleDtlCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleDtl>) DataRepository.ScScheduleDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScScheduleHdr object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScScheduleHdr instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScScheduleHdr Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleHdr entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeCourseTeachingIdSource
			if (CanDeepSave(entity, "EdCodeCourseTeaching|EdCodeCourseTeachingIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseTeachingIdSource != null)
			{
				DataRepository.EdCodeCourseTeachingProvider.Save(transactionManager, entity.EdCodeCourseTeachingIdSource);
				entity.EdCodeCourseTeachingId = entity.EdCodeCourseTeachingIdSource.EdCodeCourseTeachingId;
			}
			#endregion 
			
			#region EdOfferingCourseIdSource
			if (CanDeepSave(entity, "EdOfferingCourse|EdOfferingCourseIdSource", deepSaveType, innerList) 
				&& entity.EdOfferingCourseIdSource != null)
			{
				DataRepository.EdOfferingCourseProvider.Save(transactionManager, entity.EdOfferingCourseIdSource);
				entity.EdOfferingCourseId = entity.EdOfferingCourseIdSource.EdOfferingCourseId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<ScScheduleDtl>
				if (CanDeepSave(entity.ScScheduleDtlCollection, "List<ScScheduleDtl>|ScScheduleDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleDtl child in entity.ScScheduleDtlCollection)
					{
						if(child.ScScheduleHdrIdSource != null)
						{
							child.ScScheduleHdrId = child.ScScheduleHdrIdSource.ScScheduleHdrId;
						}
						else
						{
							child.ScScheduleHdrId = entity.ScScheduleHdrId;
						}

					}

					if (entity.ScScheduleDtlCollection.Count > 0 || entity.ScScheduleDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleDtlProvider.Save(transactionManager, entity.ScScheduleDtlCollection);
						
						deepHandles.Add("ScScheduleDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleDtl >) DataRepository.ScScheduleDtlProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleDtlCollection, deepSaveType, childTypes, innerList }
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
	
	#region ScScheduleHdrChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScScheduleHdr</c>
	///</summary>
	public enum ScScheduleHdrChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseTeaching</c> at EdCodeCourseTeachingIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseTeaching))]
		EdCodeCourseTeaching,
		
		///<summary>
		/// Composite Property for <c>EdOfferingCourse</c> at EdOfferingCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdOfferingCourse))]
		EdOfferingCourse,
		///<summary>
		/// Collection of <c>ScScheduleHdr</c> as OneToMany for ScScheduleDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleDtl>))]
		ScScheduleDtlCollection,
	}
	
	#endregion ScScheduleHdrChildEntityTypes
	
	#region ScScheduleHdrFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScScheduleHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScScheduleHdrFilterBuilder : SqlFilterBuilder<ScScheduleHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleHdrFilterBuilder class.
		/// </summary>
		public ScScheduleHdrFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScScheduleHdrFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScScheduleHdrFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScScheduleHdrFilterBuilder
	
	#region ScScheduleHdrParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScScheduleHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScScheduleHdrParameterBuilder : ParameterizedSqlFilterBuilder<ScScheduleHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleHdrParameterBuilder class.
		/// </summary>
		public ScScheduleHdrParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScScheduleHdrParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScScheduleHdrParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScScheduleHdrParameterBuilder
	
	#region ScScheduleHdrSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScScheduleHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleHdr"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScScheduleHdrSortBuilder : SqlSortBuilder<ScScheduleHdrColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleHdrSqlSortBuilder class.
		/// </summary>
		public ScScheduleHdrSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScScheduleHdrSortBuilder
	
} // end namespace
