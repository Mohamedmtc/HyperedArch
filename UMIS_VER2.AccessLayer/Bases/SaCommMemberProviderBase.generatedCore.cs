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
	/// This class is the base class for any <see cref="SaCommMemberProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCommMemberProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCommMember, UMIS_VER2.BusinessLyer.SaCommMemberKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCommMemberKey key)
		{
			return Delete(transactionManager, key.SaCommMemberId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCommMemberId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCommMemberId)
		{
			return Delete(null, _saCommMemberId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCommMemberId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCommMemberId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
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
		public override UMIS_VER2.BusinessLyer.SaCommMember Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCommMemberKey key, int start, int pageLength)
		{
			return GetBySaCommMemberId(transactionManager, key.SaCommMemberId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_CODE_COMM_MEMBER__1 index.
		/// </summary>
		/// <param name="_saCodeCommMemberTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaCodeCommMemberTypeId(System.Decimal _saCodeCommMemberTypeId)
		{
			int count = -1;
			return GetBySaCodeCommMemberTypeId(null,_saCodeCommMemberTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_COMM_MEMBER__1 index.
		/// </summary>
		/// <param name="_saCodeCommMemberTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaCodeCommMemberTypeId(System.Decimal _saCodeCommMemberTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeCommMemberTypeId(null, _saCodeCommMemberTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_COMM_MEMBER__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCommMemberTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaCodeCommMemberTypeId(TransactionManager transactionManager, System.Decimal _saCodeCommMemberTypeId)
		{
			int count = -1;
			return GetBySaCodeCommMemberTypeId(transactionManager, _saCodeCommMemberTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_COMM_MEMBER__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCommMemberTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaCodeCommMemberTypeId(TransactionManager transactionManager, System.Decimal _saCodeCommMemberTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeCommMemberTypeId(transactionManager, _saCodeCommMemberTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_COMM_MEMBER__1 index.
		/// </summary>
		/// <param name="_saCodeCommMemberTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaCodeCommMemberTypeId(System.Decimal _saCodeCommMemberTypeId, int start, int pageLength, out int count)
		{
			return GetBySaCodeCommMemberTypeId(null, _saCodeCommMemberTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_COMM_MEMBER__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCommMemberTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public abstract TList<SaCommMember> GetBySaCodeCommMemberTypeId(TransactionManager transactionManager, System.Decimal _saCodeCommMemberTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(null,_saCodeScDegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId, int start, int pageLength, out int count)
		{
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public abstract TList<SaCommMember> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_SC_COMM_ID_1 index.
		/// </summary>
		/// <param name="_saScCommId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaScCommId(System.Decimal _saScCommId)
		{
			int count = -1;
			return GetBySaScCommId(null,_saScCommId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_SC_COMM_ID_1 index.
		/// </summary>
		/// <param name="_saScCommId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaScCommId(System.Decimal _saScCommId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaScCommId(null, _saScCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_SC_COMM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaScCommId(TransactionManager transactionManager, System.Decimal _saScCommId)
		{
			int count = -1;
			return GetBySaScCommId(transactionManager, _saScCommId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_SC_COMM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaScCommId(TransactionManager transactionManager, System.Decimal _saScCommId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaScCommId(transactionManager, _saScCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_SC_COMM_ID_1 index.
		/// </summary>
		/// <param name="_saScCommId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaScCommId(System.Decimal _saScCommId, int start, int pageLength, out int count)
		{
			return GetBySaScCommId(null, _saScCommId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_SC_COMM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public abstract TList<SaCommMember> GetBySaScCommId(TransactionManager transactionManager, System.Decimal _saScCommId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaStfMemberId(System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(null,_saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public TList<SaCommMember> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength, out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCommMember&gt;"/> class.</returns>
		public abstract TList<SaCommMember> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_COMM_MEMBER index.
		/// </summary>
		/// <param name="_saCommMemberId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCommMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCommMember GetBySaCommMemberId(System.Decimal _saCommMemberId)
		{
			int count = -1;
			return GetBySaCommMemberId(null,_saCommMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_COMM_MEMBER index.
		/// </summary>
		/// <param name="_saCommMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCommMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCommMember GetBySaCommMemberId(System.Decimal _saCommMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCommMemberId(null, _saCommMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_COMM_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCommMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCommMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCommMember GetBySaCommMemberId(TransactionManager transactionManager, System.Decimal _saCommMemberId)
		{
			int count = -1;
			return GetBySaCommMemberId(transactionManager, _saCommMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_COMM_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCommMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCommMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCommMember GetBySaCommMemberId(TransactionManager transactionManager, System.Decimal _saCommMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCommMemberId(transactionManager, _saCommMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_COMM_MEMBER index.
		/// </summary>
		/// <param name="_saCommMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCommMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCommMember GetBySaCommMemberId(System.Decimal _saCommMemberId, int start, int pageLength, out int count)
		{
			return GetBySaCommMemberId(null, _saCommMemberId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_COMM_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCommMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCommMember"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCommMember GetBySaCommMemberId(TransactionManager transactionManager, System.Decimal _saCommMemberId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCommMember&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCommMember&gt;"/></returns>
		public static TList<SaCommMember> Fill(IDataReader reader, TList<SaCommMember> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCommMember c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCommMember")
					.Append("|").Append((System.Decimal)reader["SA_COMM_MEMBER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCommMember>(
					key.ToString(), // EntityTrackingKey
					"SaCommMember",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCommMember();
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
					c.SaCommMemberId = (System.Decimal)reader["SA_COMM_MEMBER_ID"];
					c.OriginalSaCommMemberId = c.SaCommMemberId;
					c.MemberFlag = (System.Decimal)reader["MEMBER_FLAG"];
					c.SaScCommId = (System.Decimal)reader["SA_SC_COMM_ID"];
					c.SaCodeCommMemberTypeId = (System.Decimal)reader["SA_CODE_COMM_MEMBER_TYPE_ID"];
					c.SaStfMemberId = Convert.IsDBNull(reader["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEMBER_ID"];
					c.ComMemberName = Convert.IsDBNull(reader["COM_MEMBER_NAME"]) ? null : (System.String)reader["COM_MEMBER_NAME"];
					c.SaCodeScDegId = Convert.IsDBNull(reader["SA_CODE_SC_DEG_ID"]) ? null : (System.Decimal?)reader["SA_CODE_SC_DEG_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCommMember"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCommMember"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCommMember entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCommMemberId = (System.Decimal)reader[((int)SaCommMemberColumn.SaCommMemberId - 1)];
			entity.OriginalSaCommMemberId = (System.Decimal)reader["SA_COMM_MEMBER_ID"];
			entity.MemberFlag = (System.Decimal)reader[((int)SaCommMemberColumn.MemberFlag - 1)];
			entity.SaScCommId = (System.Decimal)reader[((int)SaCommMemberColumn.SaScCommId - 1)];
			entity.SaCodeCommMemberTypeId = (System.Decimal)reader[((int)SaCommMemberColumn.SaCodeCommMemberTypeId - 1)];
			entity.SaStfMemberId = (reader.IsDBNull(((int)SaCommMemberColumn.SaStfMemberId - 1)))?null:(System.Decimal?)reader[((int)SaCommMemberColumn.SaStfMemberId - 1)];
			entity.ComMemberName = (reader.IsDBNull(((int)SaCommMemberColumn.ComMemberName - 1)))?null:(System.String)reader[((int)SaCommMemberColumn.ComMemberName - 1)];
			entity.SaCodeScDegId = (reader.IsDBNull(((int)SaCommMemberColumn.SaCodeScDegId - 1)))?null:(System.Decimal?)reader[((int)SaCommMemberColumn.SaCodeScDegId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCommMember"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCommMember"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCommMember entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCommMemberId = (System.Decimal)dataRow["SA_COMM_MEMBER_ID"];
			entity.OriginalSaCommMemberId = (System.Decimal)dataRow["SA_COMM_MEMBER_ID"];
			entity.MemberFlag = (System.Decimal)dataRow["MEMBER_FLAG"];
			entity.SaScCommId = (System.Decimal)dataRow["SA_SC_COMM_ID"];
			entity.SaCodeCommMemberTypeId = (System.Decimal)dataRow["SA_CODE_COMM_MEMBER_TYPE_ID"];
			entity.SaStfMemberId = Convert.IsDBNull(dataRow["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEMBER_ID"];
			entity.ComMemberName = Convert.IsDBNull(dataRow["COM_MEMBER_NAME"]) ? null : (System.String)dataRow["COM_MEMBER_NAME"];
			entity.SaCodeScDegId = Convert.IsDBNull(dataRow["SA_CODE_SC_DEG_ID"]) ? null : (System.Decimal?)dataRow["SA_CODE_SC_DEG_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCommMember"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCommMember Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCommMember entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaCodeCommMemberTypeIdSource	
			if (CanDeepLoad(entity, "SaCodeCommMemberType|SaCodeCommMemberTypeIdSource", deepLoadType, innerList) 
				&& entity.SaCodeCommMemberTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeCommMemberTypeId;
				SaCodeCommMemberType tmpEntity = EntityManager.LocateEntity<SaCodeCommMemberType>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeCommMemberType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeCommMemberTypeIdSource = tmpEntity;
				else
					entity.SaCodeCommMemberTypeIdSource = DataRepository.SaCodeCommMemberTypeProvider.GetBySaCodeCommMemberTypeId(transactionManager, entity.SaCodeCommMemberTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeCommMemberTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeCommMemberTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeCommMemberTypeProvider.DeepLoad(transactionManager, entity.SaCodeCommMemberTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeCommMemberTypeIdSource

			#region SaCodeScDegIdSource	
			if (CanDeepLoad(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepLoadType, innerList) 
				&& entity.SaCodeScDegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaCodeScDegId ?? 0.0m);
				SaCodeScDeg tmpEntity = EntityManager.LocateEntity<SaCodeScDeg>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeScDeg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeScDegIdSource = tmpEntity;
				else
					entity.SaCodeScDegIdSource = DataRepository.SaCodeScDegProvider.GetBySaCodeScDegId(transactionManager, (entity.SaCodeScDegId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeScDegIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeScDegIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeScDegProvider.DeepLoad(transactionManager, entity.SaCodeScDegIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeScDegIdSource

			#region SaScCommIdSource	
			if (CanDeepLoad(entity, "SaScComm|SaScCommIdSource", deepLoadType, innerList) 
				&& entity.SaScCommIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaScCommId;
				SaScComm tmpEntity = EntityManager.LocateEntity<SaScComm>(EntityLocator.ConstructKeyFromPkItems(typeof(SaScComm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaScCommIdSource = tmpEntity;
				else
					entity.SaScCommIdSource = DataRepository.SaScCommProvider.GetBySaScCommId(transactionManager, entity.SaScCommId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScCommIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaScCommIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaScCommProvider.DeepLoad(transactionManager, entity.SaScCommIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaScCommIdSource

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaStfMemberId ?? 0.0m);
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, (entity.SaStfMemberId ?? 0.0m));		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCommMember object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCommMember instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCommMember Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCommMember entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaCodeCommMemberTypeIdSource
			if (CanDeepSave(entity, "SaCodeCommMemberType|SaCodeCommMemberTypeIdSource", deepSaveType, innerList) 
				&& entity.SaCodeCommMemberTypeIdSource != null)
			{
				DataRepository.SaCodeCommMemberTypeProvider.Save(transactionManager, entity.SaCodeCommMemberTypeIdSource);
				entity.SaCodeCommMemberTypeId = entity.SaCodeCommMemberTypeIdSource.SaCodeCommMemberTypeId;
			}
			#endregion 
			
			#region SaCodeScDegIdSource
			if (CanDeepSave(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepSaveType, innerList) 
				&& entity.SaCodeScDegIdSource != null)
			{
				DataRepository.SaCodeScDegProvider.Save(transactionManager, entity.SaCodeScDegIdSource);
				entity.SaCodeScDegId = entity.SaCodeScDegIdSource.SaCodeScDegId;
			}
			#endregion 
			
			#region SaScCommIdSource
			if (CanDeepSave(entity, "SaScComm|SaScCommIdSource", deepSaveType, innerList) 
				&& entity.SaScCommIdSource != null)
			{
				DataRepository.SaScCommProvider.Save(transactionManager, entity.SaScCommIdSource);
				entity.SaScCommId = entity.SaScCommIdSource.SaScCommId;
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
	
	#region SaCommMemberChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCommMember</c>
	///</summary>
	public enum SaCommMemberChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeCommMemberType</c> at SaCodeCommMemberTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeCommMemberType))]
		SaCodeCommMemberType,
		
		///<summary>
		/// Composite Property for <c>SaCodeScDeg</c> at SaCodeScDegIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeScDeg))]
		SaCodeScDeg,
		
		///<summary>
		/// Composite Property for <c>SaScComm</c> at SaScCommIdSource
		///</summary>
		[ChildEntityType(typeof(SaScComm))]
		SaScComm,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion SaCommMemberChildEntityTypes
	
	#region SaCommMemberFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCommMemberColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCommMember"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCommMemberFilterBuilder : SqlFilterBuilder<SaCommMemberColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCommMemberFilterBuilder class.
		/// </summary>
		public SaCommMemberFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCommMemberFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCommMemberFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCommMemberFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCommMemberFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCommMemberFilterBuilder
	
	#region SaCommMemberParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCommMemberColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCommMember"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCommMemberParameterBuilder : ParameterizedSqlFilterBuilder<SaCommMemberColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCommMemberParameterBuilder class.
		/// </summary>
		public SaCommMemberParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCommMemberParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCommMemberParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCommMemberParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCommMemberParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCommMemberParameterBuilder
	
	#region SaCommMemberSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCommMemberColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCommMember"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCommMemberSortBuilder : SqlSortBuilder<SaCommMemberColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCommMemberSqlSortBuilder class.
		/// </summary>
		public SaCommMemberSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCommMemberSortBuilder
	
} // end namespace
