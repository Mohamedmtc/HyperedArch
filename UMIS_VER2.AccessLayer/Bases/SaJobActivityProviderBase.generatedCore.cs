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
	/// This class is the base class for any <see cref="SaJobActivityProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaJobActivityProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaJobActivity, UMIS_VER2.BusinessLyer.SaJobActivityKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaJobActivityKey key)
		{
			return Delete(transactionManager, key.SaJobActivityId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saJobActivityId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saJobActivityId)
		{
			return Delete(null, _saJobActivityId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobActivityId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saJobActivityId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0465 key.
		///		FK_AUTO_0465 Description: 
		/// </summary>
		/// <param name="_saCodeJobActivityPlaceId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobActivity objects.</returns>
		public TList<SaJobActivity> GetBySaCodeJobActivityPlaceId(System.Decimal _saCodeJobActivityPlaceId)
		{
			int count = -1;
			return GetBySaCodeJobActivityPlaceId(_saCodeJobActivityPlaceId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0465 key.
		///		FK_AUTO_0465 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobActivityPlaceId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobActivity objects.</returns>
		/// <remarks></remarks>
		public TList<SaJobActivity> GetBySaCodeJobActivityPlaceId(TransactionManager transactionManager, System.Decimal _saCodeJobActivityPlaceId)
		{
			int count = -1;
			return GetBySaCodeJobActivityPlaceId(transactionManager, _saCodeJobActivityPlaceId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0465 key.
		///		FK_AUTO_0465 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobActivityPlaceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobActivity objects.</returns>
		public TList<SaJobActivity> GetBySaCodeJobActivityPlaceId(TransactionManager transactionManager, System.Decimal _saCodeJobActivityPlaceId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeJobActivityPlaceId(transactionManager, _saCodeJobActivityPlaceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0465 key.
		///		fkAuto0465 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeJobActivityPlaceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobActivity objects.</returns>
		public TList<SaJobActivity> GetBySaCodeJobActivityPlaceId(System.Decimal _saCodeJobActivityPlaceId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeJobActivityPlaceId(null, _saCodeJobActivityPlaceId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0465 key.
		///		fkAuto0465 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeJobActivityPlaceId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobActivity objects.</returns>
		public TList<SaJobActivity> GetBySaCodeJobActivityPlaceId(System.Decimal _saCodeJobActivityPlaceId, int start, int pageLength,out int count)
		{
			return GetBySaCodeJobActivityPlaceId(null, _saCodeJobActivityPlaceId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0465 key.
		///		FK_AUTO_0465 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobActivityPlaceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobActivity objects.</returns>
		public abstract TList<SaJobActivity> GetBySaCodeJobActivityPlaceId(TransactionManager transactionManager, System.Decimal _saCodeJobActivityPlaceId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_ACTIVITY_SA_STF_MEMBER key.
		///		FK_SA_JOB_ACTIVITY_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobActivity objects.</returns>
		public TList<SaJobActivity> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_ACTIVITY_SA_STF_MEMBER key.
		///		FK_SA_JOB_ACTIVITY_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobActivity objects.</returns>
		/// <remarks></remarks>
		public TList<SaJobActivity> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_ACTIVITY_SA_STF_MEMBER key.
		///		FK_SA_JOB_ACTIVITY_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobActivity objects.</returns>
		public TList<SaJobActivity> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_ACTIVITY_SA_STF_MEMBER key.
		///		fkSaJobActivitySaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobActivity objects.</returns>
		public TList<SaJobActivity> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_ACTIVITY_SA_STF_MEMBER key.
		///		fkSaJobActivitySaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobActivity objects.</returns>
		public TList<SaJobActivity> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_ACTIVITY_SA_STF_MEMBER key.
		///		FK_SA_JOB_ACTIVITY_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobActivity objects.</returns>
		public abstract TList<SaJobActivity> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaJobActivity Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaJobActivityKey key, int start, int pageLength)
		{
			return GetBySaJobActivityId(transactionManager, key.SaJobActivityId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaJobActivity&gt;"/> class.</returns>
		public TList<SaJobActivity> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaJobActivity&gt;"/> class.</returns>
		public TList<SaJobActivity> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaJobActivity&gt;"/> class.</returns>
		public TList<SaJobActivity> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaJobActivity&gt;"/> class.</returns>
		public TList<SaJobActivity> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaJobActivity&gt;"/> class.</returns>
		public TList<SaJobActivity> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaJobActivity&gt;"/> class.</returns>
		public abstract TList<SaJobActivity> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_CODE_JOB_ACTIVITY_1 index.
		/// </summary>
		/// <param name="_saCodeJobActivityId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaJobActivity&gt;"/> class.</returns>
		public TList<SaJobActivity> GetBySaCodeJobActivityId(System.Decimal _saCodeJobActivityId)
		{
			int count = -1;
			return GetBySaCodeJobActivityId(null,_saCodeJobActivityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_JOB_ACTIVITY_1 index.
		/// </summary>
		/// <param name="_saCodeJobActivityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaJobActivity&gt;"/> class.</returns>
		public TList<SaJobActivity> GetBySaCodeJobActivityId(System.Decimal _saCodeJobActivityId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeJobActivityId(null, _saCodeJobActivityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_JOB_ACTIVITY_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobActivityId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaJobActivity&gt;"/> class.</returns>
		public TList<SaJobActivity> GetBySaCodeJobActivityId(TransactionManager transactionManager, System.Decimal _saCodeJobActivityId)
		{
			int count = -1;
			return GetBySaCodeJobActivityId(transactionManager, _saCodeJobActivityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_JOB_ACTIVITY_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobActivityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaJobActivity&gt;"/> class.</returns>
		public TList<SaJobActivity> GetBySaCodeJobActivityId(TransactionManager transactionManager, System.Decimal _saCodeJobActivityId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeJobActivityId(transactionManager, _saCodeJobActivityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_JOB_ACTIVITY_1 index.
		/// </summary>
		/// <param name="_saCodeJobActivityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaJobActivity&gt;"/> class.</returns>
		public TList<SaJobActivity> GetBySaCodeJobActivityId(System.Decimal _saCodeJobActivityId, int start, int pageLength, out int count)
		{
			return GetBySaCodeJobActivityId(null, _saCodeJobActivityId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_JOB_ACTIVITY_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobActivityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaJobActivity&gt;"/> class.</returns>
		public abstract TList<SaJobActivity> GetBySaCodeJobActivityId(TransactionManager transactionManager, System.Decimal _saCodeJobActivityId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_JOB_ACTIVITY index.
		/// </summary>
		/// <param name="_saJobActivityId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaJobActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaJobActivity GetBySaJobActivityId(System.Decimal _saJobActivityId)
		{
			int count = -1;
			return GetBySaJobActivityId(null,_saJobActivityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_JOB_ACTIVITY index.
		/// </summary>
		/// <param name="_saJobActivityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaJobActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaJobActivity GetBySaJobActivityId(System.Decimal _saJobActivityId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaJobActivityId(null, _saJobActivityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_JOB_ACTIVITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobActivityId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaJobActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaJobActivity GetBySaJobActivityId(TransactionManager transactionManager, System.Decimal _saJobActivityId)
		{
			int count = -1;
			return GetBySaJobActivityId(transactionManager, _saJobActivityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_JOB_ACTIVITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobActivityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaJobActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaJobActivity GetBySaJobActivityId(TransactionManager transactionManager, System.Decimal _saJobActivityId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaJobActivityId(transactionManager, _saJobActivityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_JOB_ACTIVITY index.
		/// </summary>
		/// <param name="_saJobActivityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaJobActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaJobActivity GetBySaJobActivityId(System.Decimal _saJobActivityId, int start, int pageLength, out int count)
		{
			return GetBySaJobActivityId(null, _saJobActivityId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_JOB_ACTIVITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobActivityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaJobActivity"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaJobActivity GetBySaJobActivityId(TransactionManager transactionManager, System.Decimal _saJobActivityId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaJobActivity&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaJobActivity&gt;"/></returns>
		public static TList<SaJobActivity> Fill(IDataReader reader, TList<SaJobActivity> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaJobActivity c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaJobActivity")
					.Append("|").Append((System.Decimal)reader["SA_JOB_ACTIVITY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaJobActivity>(
					key.ToString(), // EntityTrackingKey
					"SaJobActivity",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaJobActivity();
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
					c.SaJobActivityId = (System.Decimal)reader["SA_JOB_ACTIVITY_ID"];
					c.OriginalSaJobActivityId = c.SaJobActivityId;
					c.MembershipNum = Convert.IsDBNull(reader["MEMBERSHIP_NUM"]) ? null : (System.String)reader["MEMBERSHIP_NUM"];
					c.JoinDate = (System.DateTime)reader["JOIN_DATE"];
					c.SaCodeJobActivityId = (System.Decimal)reader["SA_CODE_JOB_ACTIVITY_ID"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.SaCodeJobActivityPlaceId = (System.Decimal)reader["SA_CODE_JOB_ACTIVITY_PLACE_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaJobActivity"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaJobActivity"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaJobActivity entity)
		{
			if (!reader.Read()) return;
			
			entity.SaJobActivityId = (System.Decimal)reader[((int)SaJobActivityColumn.SaJobActivityId - 1)];
			entity.OriginalSaJobActivityId = (System.Decimal)reader["SA_JOB_ACTIVITY_ID"];
			entity.MembershipNum = (reader.IsDBNull(((int)SaJobActivityColumn.MembershipNum - 1)))?null:(System.String)reader[((int)SaJobActivityColumn.MembershipNum - 1)];
			entity.JoinDate = (System.DateTime)reader[((int)SaJobActivityColumn.JoinDate - 1)];
			entity.SaCodeJobActivityId = (System.Decimal)reader[((int)SaJobActivityColumn.SaCodeJobActivityId - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaJobActivityColumn.SaStfMemberId - 1)];
			entity.SaCodeJobActivityPlaceId = (System.Decimal)reader[((int)SaJobActivityColumn.SaCodeJobActivityPlaceId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaJobActivityColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaJobActivity"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaJobActivity"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaJobActivity entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaJobActivityId = (System.Decimal)dataRow["SA_JOB_ACTIVITY_ID"];
			entity.OriginalSaJobActivityId = (System.Decimal)dataRow["SA_JOB_ACTIVITY_ID"];
			entity.MembershipNum = Convert.IsDBNull(dataRow["MEMBERSHIP_NUM"]) ? null : (System.String)dataRow["MEMBERSHIP_NUM"];
			entity.JoinDate = (System.DateTime)dataRow["JOIN_DATE"];
			entity.SaCodeJobActivityId = (System.Decimal)dataRow["SA_CODE_JOB_ACTIVITY_ID"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.SaCodeJobActivityPlaceId = (System.Decimal)dataRow["SA_CODE_JOB_ACTIVITY_PLACE_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaJobActivity"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaJobActivity Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaJobActivity entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaCodeJobActivityPlaceIdSource	
			if (CanDeepLoad(entity, "SaCodeJobActivityPlace|SaCodeJobActivityPlaceIdSource", deepLoadType, innerList) 
				&& entity.SaCodeJobActivityPlaceIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeJobActivityPlaceId;
				SaCodeJobActivityPlace tmpEntity = EntityManager.LocateEntity<SaCodeJobActivityPlace>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeJobActivityPlace), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeJobActivityPlaceIdSource = tmpEntity;
				else
					entity.SaCodeJobActivityPlaceIdSource = DataRepository.SaCodeJobActivityPlaceProvider.GetBySaCodeJobActivityPlaceId(transactionManager, entity.SaCodeJobActivityPlaceId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeJobActivityPlaceIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeJobActivityPlaceIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeJobActivityPlaceProvider.DeepLoad(transactionManager, entity.SaCodeJobActivityPlaceIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeJobActivityPlaceIdSource

			#region SaCodeJobActivityIdSource	
			if (CanDeepLoad(entity, "SaCodeJobActivity|SaCodeJobActivityIdSource", deepLoadType, innerList) 
				&& entity.SaCodeJobActivityIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeJobActivityId;
				SaCodeJobActivity tmpEntity = EntityManager.LocateEntity<SaCodeJobActivity>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeJobActivity), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeJobActivityIdSource = tmpEntity;
				else
					entity.SaCodeJobActivityIdSource = DataRepository.SaCodeJobActivityProvider.GetBySaCodeJobActivityId(transactionManager, entity.SaCodeJobActivityId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeJobActivityIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeJobActivityIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeJobActivityProvider.DeepLoad(transactionManager, entity.SaCodeJobActivityIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeJobActivityIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaJobActivity object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaJobActivity instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaJobActivity Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaJobActivity entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaCodeJobActivityPlaceIdSource
			if (CanDeepSave(entity, "SaCodeJobActivityPlace|SaCodeJobActivityPlaceIdSource", deepSaveType, innerList) 
				&& entity.SaCodeJobActivityPlaceIdSource != null)
			{
				DataRepository.SaCodeJobActivityPlaceProvider.Save(transactionManager, entity.SaCodeJobActivityPlaceIdSource);
				entity.SaCodeJobActivityPlaceId = entity.SaCodeJobActivityPlaceIdSource.SaCodeJobActivityPlaceId;
			}
			#endregion 
			
			#region SaCodeJobActivityIdSource
			if (CanDeepSave(entity, "SaCodeJobActivity|SaCodeJobActivityIdSource", deepSaveType, innerList) 
				&& entity.SaCodeJobActivityIdSource != null)
			{
				DataRepository.SaCodeJobActivityProvider.Save(transactionManager, entity.SaCodeJobActivityIdSource);
				entity.SaCodeJobActivityId = entity.SaCodeJobActivityIdSource.SaCodeJobActivityId;
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
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
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
	
	#region SaJobActivityChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaJobActivity</c>
	///</summary>
	public enum SaJobActivityChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeJobActivityPlace</c> at SaCodeJobActivityPlaceIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeJobActivityPlace))]
		SaCodeJobActivityPlace,
		
		///<summary>
		/// Composite Property for <c>SaCodeJobActivity</c> at SaCodeJobActivityIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeJobActivity))]
		SaCodeJobActivity,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion SaJobActivityChildEntityTypes
	
	#region SaJobActivityFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaJobActivityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaJobActivity"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaJobActivityFilterBuilder : SqlFilterBuilder<SaJobActivityColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaJobActivityFilterBuilder class.
		/// </summary>
		public SaJobActivityFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaJobActivityFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaJobActivityFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaJobActivityFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaJobActivityFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaJobActivityFilterBuilder
	
	#region SaJobActivityParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaJobActivityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaJobActivity"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaJobActivityParameterBuilder : ParameterizedSqlFilterBuilder<SaJobActivityColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaJobActivityParameterBuilder class.
		/// </summary>
		public SaJobActivityParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaJobActivityParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaJobActivityParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaJobActivityParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaJobActivityParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaJobActivityParameterBuilder
	
	#region SaJobActivitySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaJobActivityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaJobActivity"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaJobActivitySortBuilder : SqlSortBuilder<SaJobActivityColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaJobActivitySqlSortBuilder class.
		/// </summary>
		public SaJobActivitySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaJobActivitySortBuilder
	
} // end namespace
