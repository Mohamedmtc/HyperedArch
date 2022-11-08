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
	/// This class is the base class for any <see cref="ScSchdlHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScSchdlHdrProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScSchdlHdr, UMIS_VER2.BusinessLyer.ScSchdlHdrKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSchdlHdrKey key)
		{
			return Delete(transactionManager, key.ScSchdlHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scSchdlHdrId">New Group Schedule. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scSchdlHdrId)
		{
			return Delete(null, _scSchdlHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlHdrId">New Group Schedule. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scSchdlHdrId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_HDR_SC_CDE_GRP_TYPE key.
		///		FK_SC_SCHDL_HDR_SC_CDE_GRP_TYPE Description: 
		/// </summary>
		/// <param name="_scCdeGrpTypeId">مجموعة-شعبة-مقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlHdr objects.</returns>
		public TList<ScSchdlHdr> GetByScCdeGrpTypeId(System.Decimal _scCdeGrpTypeId)
		{
			int count = -1;
			return GetByScCdeGrpTypeId(_scCdeGrpTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_HDR_SC_CDE_GRP_TYPE key.
		///		FK_SC_SCHDL_HDR_SC_CDE_GRP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeGrpTypeId">مجموعة-شعبة-مقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlHdr objects.</returns>
		/// <remarks></remarks>
		public TList<ScSchdlHdr> GetByScCdeGrpTypeId(TransactionManager transactionManager, System.Decimal _scCdeGrpTypeId)
		{
			int count = -1;
			return GetByScCdeGrpTypeId(transactionManager, _scCdeGrpTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_HDR_SC_CDE_GRP_TYPE key.
		///		FK_SC_SCHDL_HDR_SC_CDE_GRP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeGrpTypeId">مجموعة-شعبة-مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlHdr objects.</returns>
		public TList<ScSchdlHdr> GetByScCdeGrpTypeId(TransactionManager transactionManager, System.Decimal _scCdeGrpTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByScCdeGrpTypeId(transactionManager, _scCdeGrpTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_HDR_SC_CDE_GRP_TYPE key.
		///		fkScSchdlHdrScCdeGrpType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scCdeGrpTypeId">مجموعة-شعبة-مقرر</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlHdr objects.</returns>
		public TList<ScSchdlHdr> GetByScCdeGrpTypeId(System.Decimal _scCdeGrpTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScCdeGrpTypeId(null, _scCdeGrpTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_HDR_SC_CDE_GRP_TYPE key.
		///		fkScSchdlHdrScCdeGrpType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scCdeGrpTypeId">مجموعة-شعبة-مقرر</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlHdr objects.</returns>
		public TList<ScSchdlHdr> GetByScCdeGrpTypeId(System.Decimal _scCdeGrpTypeId, int start, int pageLength,out int count)
		{
			return GetByScCdeGrpTypeId(null, _scCdeGrpTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_HDR_SC_CDE_GRP_TYPE key.
		///		FK_SC_SCHDL_HDR_SC_CDE_GRP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeGrpTypeId">مجموعة-شعبة-مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlHdr objects.</returns>
		public abstract TList<ScSchdlHdr> GetByScCdeGrpTypeId(TransactionManager transactionManager, System.Decimal _scCdeGrpTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_HDR_SC_GROUP_INFO key.
		///		FK_SC_SCHDL_HDR_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="_scGroupInfoId">مجموعة-شعبة-مجموعة مقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlHdr objects.</returns>
		public TList<ScSchdlHdr> GetByScGroupInfoId(System.Decimal _scGroupInfoId)
		{
			int count = -1;
			return GetByScGroupInfoId(_scGroupInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_HDR_SC_GROUP_INFO key.
		///		FK_SC_SCHDL_HDR_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoId">مجموعة-شعبة-مجموعة مقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlHdr objects.</returns>
		/// <remarks></remarks>
		public TList<ScSchdlHdr> GetByScGroupInfoId(TransactionManager transactionManager, System.Decimal _scGroupInfoId)
		{
			int count = -1;
			return GetByScGroupInfoId(transactionManager, _scGroupInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_HDR_SC_GROUP_INFO key.
		///		FK_SC_SCHDL_HDR_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoId">مجموعة-شعبة-مجموعة مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlHdr objects.</returns>
		public TList<ScSchdlHdr> GetByScGroupInfoId(TransactionManager transactionManager, System.Decimal _scGroupInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByScGroupInfoId(transactionManager, _scGroupInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_HDR_SC_GROUP_INFO key.
		///		fkScSchdlHdrScGroupInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scGroupInfoId">مجموعة-شعبة-مجموعة مقرر</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlHdr objects.</returns>
		public TList<ScSchdlHdr> GetByScGroupInfoId(System.Decimal _scGroupInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScGroupInfoId(null, _scGroupInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_HDR_SC_GROUP_INFO key.
		///		fkScSchdlHdrScGroupInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scGroupInfoId">مجموعة-شعبة-مجموعة مقرر</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlHdr objects.</returns>
		public TList<ScSchdlHdr> GetByScGroupInfoId(System.Decimal _scGroupInfoId, int start, int pageLength,out int count)
		{
			return GetByScGroupInfoId(null, _scGroupInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_HDR_SC_GROUP_INFO key.
		///		FK_SC_SCHDL_HDR_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoId">مجموعة-شعبة-مجموعة مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlHdr objects.</returns>
		public abstract TList<ScSchdlHdr> GetByScGroupInfoId(TransactionManager transactionManager, System.Decimal _scGroupInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_HDR_SC_SCHDL_PERIOD key.
		///		FK_SC_SCHDL_HDR_SC_SCHDL_PERIOD Description: 
		/// </summary>
		/// <param name="_scSchdlPeriodId">فترات الجدول-اسابيع الجدول  - فى حالة مجموعة او شعبة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlHdr objects.</returns>
		public TList<ScSchdlHdr> GetByScSchdlPeriodId(System.Decimal? _scSchdlPeriodId)
		{
			int count = -1;
			return GetByScSchdlPeriodId(_scSchdlPeriodId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_HDR_SC_SCHDL_PERIOD key.
		///		FK_SC_SCHDL_HDR_SC_SCHDL_PERIOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlPeriodId">فترات الجدول-اسابيع الجدول  - فى حالة مجموعة او شعبة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlHdr objects.</returns>
		/// <remarks></remarks>
		public TList<ScSchdlHdr> GetByScSchdlPeriodId(TransactionManager transactionManager, System.Decimal? _scSchdlPeriodId)
		{
			int count = -1;
			return GetByScSchdlPeriodId(transactionManager, _scSchdlPeriodId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_HDR_SC_SCHDL_PERIOD key.
		///		FK_SC_SCHDL_HDR_SC_SCHDL_PERIOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlPeriodId">فترات الجدول-اسابيع الجدول  - فى حالة مجموعة او شعبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlHdr objects.</returns>
		public TList<ScSchdlHdr> GetByScSchdlPeriodId(TransactionManager transactionManager, System.Decimal? _scSchdlPeriodId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSchdlPeriodId(transactionManager, _scSchdlPeriodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_HDR_SC_SCHDL_PERIOD key.
		///		fkScSchdlHdrScSchdlPeriod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSchdlPeriodId">فترات الجدول-اسابيع الجدول  - فى حالة مجموعة او شعبة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlHdr objects.</returns>
		public TList<ScSchdlHdr> GetByScSchdlPeriodId(System.Decimal? _scSchdlPeriodId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScSchdlPeriodId(null, _scSchdlPeriodId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_HDR_SC_SCHDL_PERIOD key.
		///		fkScSchdlHdrScSchdlPeriod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSchdlPeriodId">فترات الجدول-اسابيع الجدول  - فى حالة مجموعة او شعبة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlHdr objects.</returns>
		public TList<ScSchdlHdr> GetByScSchdlPeriodId(System.Decimal? _scSchdlPeriodId, int start, int pageLength,out int count)
		{
			return GetByScSchdlPeriodId(null, _scSchdlPeriodId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_HDR_SC_SCHDL_PERIOD key.
		///		FK_SC_SCHDL_HDR_SC_SCHDL_PERIOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlPeriodId">فترات الجدول-اسابيع الجدول  - فى حالة مجموعة او شعبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlHdr objects.</returns>
		public abstract TList<ScSchdlHdr> GetByScSchdlPeriodId(TransactionManager transactionManager, System.Decimal? _scSchdlPeriodId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScSchdlHdr Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSchdlHdrKey key, int start, int pageLength)
		{
			return GetByScSchdlHdrId(transactionManager, key.ScSchdlHdrId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_SCHDL_HDR index.
		/// </summary>
		/// <param name="_scSchdlHdrId">New Group Schedule</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlHdr GetByScSchdlHdrId(System.Decimal _scSchdlHdrId)
		{
			int count = -1;
			return GetByScSchdlHdrId(null,_scSchdlHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_HDR index.
		/// </summary>
		/// <param name="_scSchdlHdrId">New Group Schedule</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlHdr GetByScSchdlHdrId(System.Decimal _scSchdlHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSchdlHdrId(null, _scSchdlHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlHdrId">New Group Schedule</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlHdr GetByScSchdlHdrId(TransactionManager transactionManager, System.Decimal _scSchdlHdrId)
		{
			int count = -1;
			return GetByScSchdlHdrId(transactionManager, _scSchdlHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlHdrId">New Group Schedule</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlHdr GetByScSchdlHdrId(TransactionManager transactionManager, System.Decimal _scSchdlHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSchdlHdrId(transactionManager, _scSchdlHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_HDR index.
		/// </summary>
		/// <param name="_scSchdlHdrId">New Group Schedule</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlHdr GetByScSchdlHdrId(System.Decimal _scSchdlHdrId, int start, int pageLength, out int count)
		{
			return GetByScSchdlHdrId(null, _scSchdlHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlHdrId">New Group Schedule</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScSchdlHdr GetByScSchdlHdrId(TransactionManager transactionManager, System.Decimal _scSchdlHdrId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScSchdlHdr&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScSchdlHdr&gt;"/></returns>
		public static TList<ScSchdlHdr> Fill(IDataReader reader, TList<ScSchdlHdr> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScSchdlHdr c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScSchdlHdr")
					.Append("|").Append((System.Decimal)reader["SC_SCHDL_HDR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScSchdlHdr>(
					key.ToString(), // EntityTrackingKey
					"ScSchdlHdr",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScSchdlHdr();
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
					c.ScSchdlHdrId = (System.Decimal)reader["SC_SCHDL_HDR_ID"];
					c.OriginalScSchdlHdrId = c.ScSchdlHdrId;
					c.ScCdeGrpTypeId = (System.Decimal)reader["SC_CDE_GRP_TYPE_ID"];
					c.ScGroupInfoId = (System.Decimal)reader["SC_GROUP_INFO_ID"];
					c.SchdlTypeId = Convert.IsDBNull(reader["SCHDL_TYPE_ID"]) ? null : (System.Int32?)reader["SCHDL_TYPE_ID"];
					c.ScSchdlPeriodId = Convert.IsDBNull(reader["SC_SCHDL_PERIOD_ID"]) ? null : (System.Decimal?)reader["SC_SCHDL_PERIOD_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScSchdlHdr"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScSchdlHdr"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScSchdlHdr entity)
		{
			if (!reader.Read()) return;
			
			entity.ScSchdlHdrId = (System.Decimal)reader[((int)ScSchdlHdrColumn.ScSchdlHdrId - 1)];
			entity.OriginalScSchdlHdrId = (System.Decimal)reader["SC_SCHDL_HDR_ID"];
			entity.ScCdeGrpTypeId = (System.Decimal)reader[((int)ScSchdlHdrColumn.ScCdeGrpTypeId - 1)];
			entity.ScGroupInfoId = (System.Decimal)reader[((int)ScSchdlHdrColumn.ScGroupInfoId - 1)];
			entity.SchdlTypeId = (reader.IsDBNull(((int)ScSchdlHdrColumn.SchdlTypeId - 1)))?null:(System.Int32?)reader[((int)ScSchdlHdrColumn.SchdlTypeId - 1)];
			entity.ScSchdlPeriodId = (reader.IsDBNull(((int)ScSchdlHdrColumn.ScSchdlPeriodId - 1)))?null:(System.Decimal?)reader[((int)ScSchdlHdrColumn.ScSchdlPeriodId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScSchdlHdr"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScSchdlHdr"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScSchdlHdr entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScSchdlHdrId = (System.Decimal)dataRow["SC_SCHDL_HDR_ID"];
			entity.OriginalScSchdlHdrId = (System.Decimal)dataRow["SC_SCHDL_HDR_ID"];
			entity.ScCdeGrpTypeId = (System.Decimal)dataRow["SC_CDE_GRP_TYPE_ID"];
			entity.ScGroupInfoId = (System.Decimal)dataRow["SC_GROUP_INFO_ID"];
			entity.SchdlTypeId = Convert.IsDBNull(dataRow["SCHDL_TYPE_ID"]) ? null : (System.Int32?)dataRow["SCHDL_TYPE_ID"];
			entity.ScSchdlPeriodId = Convert.IsDBNull(dataRow["SC_SCHDL_PERIOD_ID"]) ? null : (System.Decimal?)dataRow["SC_SCHDL_PERIOD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScSchdlHdr"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScSchdlHdr Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSchdlHdr entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region ScCdeGrpTypeIdSource	
			if (CanDeepLoad(entity, "ScCdeGrpType|ScCdeGrpTypeIdSource", deepLoadType, innerList) 
				&& entity.ScCdeGrpTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScCdeGrpTypeId;
				ScCdeGrpType tmpEntity = EntityManager.LocateEntity<ScCdeGrpType>(EntityLocator.ConstructKeyFromPkItems(typeof(ScCdeGrpType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScCdeGrpTypeIdSource = tmpEntity;
				else
					entity.ScCdeGrpTypeIdSource = DataRepository.ScCdeGrpTypeProvider.GetByScCdeGrpTypeId(transactionManager, entity.ScCdeGrpTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScCdeGrpTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScCdeGrpTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScCdeGrpTypeProvider.DeepLoad(transactionManager, entity.ScCdeGrpTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScCdeGrpTypeIdSource

			#region ScGroupInfoIdSource	
			if (CanDeepLoad(entity, "ScGroupInfo|ScGroupInfoIdSource", deepLoadType, innerList) 
				&& entity.ScGroupInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScGroupInfoId;
				ScGroupInfo tmpEntity = EntityManager.LocateEntity<ScGroupInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(ScGroupInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScGroupInfoIdSource = tmpEntity;
				else
					entity.ScGroupInfoIdSource = DataRepository.ScGroupInfoProvider.GetByScGroupInfoId(transactionManager, entity.ScGroupInfoId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScGroupInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScGroupInfoProvider.DeepLoad(transactionManager, entity.ScGroupInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScGroupInfoIdSource

			#region ScSchdlPeriodIdSource	
			if (CanDeepLoad(entity, "ScSchdlPeriod|ScSchdlPeriodIdSource", deepLoadType, innerList) 
				&& entity.ScSchdlPeriodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScSchdlPeriodId ?? 0.0m);
				ScSchdlPeriod tmpEntity = EntityManager.LocateEntity<ScSchdlPeriod>(EntityLocator.ConstructKeyFromPkItems(typeof(ScSchdlPeriod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScSchdlPeriodIdSource = tmpEntity;
				else
					entity.ScSchdlPeriodIdSource = DataRepository.ScSchdlPeriodProvider.GetByScSchdlPeriodId(transactionManager, (entity.ScSchdlPeriodId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlPeriodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScSchdlPeriodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScSchdlPeriodProvider.DeepLoad(transactionManager, entity.ScSchdlPeriodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScSchdlPeriodIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByScSchdlHdrId methods when available
			
			#region ScSchdlSlotCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSchdlSlot>|ScSchdlSlotCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlSlotCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSchdlSlotCollection = DataRepository.ScSchdlSlotProvider.GetByScSchdlHdrId(transactionManager, entity.ScSchdlHdrId);

				if (deep && entity.ScSchdlSlotCollection.Count > 0)
				{
					deepHandles.Add("ScSchdlSlotCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSchdlSlot>) DataRepository.ScSchdlSlotProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSchdlSlotCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScSchdlHdr object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScSchdlHdr instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScSchdlHdr Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSchdlHdr entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region ScCdeGrpTypeIdSource
			if (CanDeepSave(entity, "ScCdeGrpType|ScCdeGrpTypeIdSource", deepSaveType, innerList) 
				&& entity.ScCdeGrpTypeIdSource != null)
			{
				DataRepository.ScCdeGrpTypeProvider.Save(transactionManager, entity.ScCdeGrpTypeIdSource);
				entity.ScCdeGrpTypeId = entity.ScCdeGrpTypeIdSource.ScCdeGrpTypeId;
			}
			#endregion 
			
			#region ScGroupInfoIdSource
			if (CanDeepSave(entity, "ScGroupInfo|ScGroupInfoIdSource", deepSaveType, innerList) 
				&& entity.ScGroupInfoIdSource != null)
			{
				DataRepository.ScGroupInfoProvider.Save(transactionManager, entity.ScGroupInfoIdSource);
				entity.ScGroupInfoId = entity.ScGroupInfoIdSource.ScGroupInfoId;
			}
			#endregion 
			
			#region ScSchdlPeriodIdSource
			if (CanDeepSave(entity, "ScSchdlPeriod|ScSchdlPeriodIdSource", deepSaveType, innerList) 
				&& entity.ScSchdlPeriodIdSource != null)
			{
				DataRepository.ScSchdlPeriodProvider.Save(transactionManager, entity.ScSchdlPeriodIdSource);
				entity.ScSchdlPeriodId = entity.ScSchdlPeriodIdSource.ScSchdlPeriodId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<ScSchdlSlot>
				if (CanDeepSave(entity.ScSchdlSlotCollection, "List<ScSchdlSlot>|ScSchdlSlotCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSchdlSlot child in entity.ScSchdlSlotCollection)
					{
						if(child.ScSchdlHdrIdSource != null)
						{
							child.ScSchdlHdrId = child.ScSchdlHdrIdSource.ScSchdlHdrId;
						}
						else
						{
							child.ScSchdlHdrId = entity.ScSchdlHdrId;
						}

					}

					if (entity.ScSchdlSlotCollection.Count > 0 || entity.ScSchdlSlotCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSchdlSlotProvider.Save(transactionManager, entity.ScSchdlSlotCollection);
						
						deepHandles.Add("ScSchdlSlotCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSchdlSlot >) DataRepository.ScSchdlSlotProvider.DeepSave,
							new object[] { transactionManager, entity.ScSchdlSlotCollection, deepSaveType, childTypes, innerList }
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
	
	#region ScSchdlHdrChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScSchdlHdr</c>
	///</summary>
	public enum ScSchdlHdrChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>ScCdeGrpType</c> at ScCdeGrpTypeIdSource
		///</summary>
		[ChildEntityType(typeof(ScCdeGrpType))]
		ScCdeGrpType,
		
		///<summary>
		/// Composite Property for <c>ScGroupInfo</c> at ScGroupInfoIdSource
		///</summary>
		[ChildEntityType(typeof(ScGroupInfo))]
		ScGroupInfo,
		
		///<summary>
		/// Composite Property for <c>ScSchdlPeriod</c> at ScSchdlPeriodIdSource
		///</summary>
		[ChildEntityType(typeof(ScSchdlPeriod))]
		ScSchdlPeriod,
		///<summary>
		/// Collection of <c>ScSchdlHdr</c> as OneToMany for ScSchdlSlotCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSchdlSlot>))]
		ScSchdlSlotCollection,
	}
	
	#endregion ScSchdlHdrChildEntityTypes
	
	#region ScSchdlHdrFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScSchdlHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScSchdlHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScSchdlHdrFilterBuilder : SqlFilterBuilder<ScSchdlHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScSchdlHdrFilterBuilder class.
		/// </summary>
		public ScSchdlHdrFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScSchdlHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScSchdlHdrFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScSchdlHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScSchdlHdrFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScSchdlHdrFilterBuilder
	
	#region ScSchdlHdrParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScSchdlHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScSchdlHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScSchdlHdrParameterBuilder : ParameterizedSqlFilterBuilder<ScSchdlHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScSchdlHdrParameterBuilder class.
		/// </summary>
		public ScSchdlHdrParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScSchdlHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScSchdlHdrParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScSchdlHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScSchdlHdrParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScSchdlHdrParameterBuilder
	
	#region ScSchdlHdrSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScSchdlHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScSchdlHdr"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScSchdlHdrSortBuilder : SqlSortBuilder<ScSchdlHdrColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScSchdlHdrSqlSortBuilder class.
		/// </summary>
		public ScSchdlHdrSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScSchdlHdrSortBuilder
	
} // end namespace
