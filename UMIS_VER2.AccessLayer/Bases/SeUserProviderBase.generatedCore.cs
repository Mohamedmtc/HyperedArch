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
	/// This class is the base class for any <see cref="SeUserProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeUserProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeUser, UMIS_VER2.BusinessLyer.SeUserKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserKey key)
		{
			return Delete(transactionManager, key.SeUserId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seUserId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seUserId)
		{
			return Delete(null, _seUserId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seUserId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ERP_ORG_TREE key.
		///		FK_SE_USER_ERP_ORG_TREE Description: 
		/// </summary>
		/// <param name="_erpOrgTreeId">XXnot usedXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUser objects.</returns>
		public TList<SeUser> GetByErpOrgTreeId(System.Decimal? _erpOrgTreeId)
		{
			int count = -1;
			return GetByErpOrgTreeId(_erpOrgTreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ERP_ORG_TREE key.
		///		FK_SE_USER_ERP_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeId">XXnot usedXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUser objects.</returns>
		/// <remarks></remarks>
		public TList<SeUser> GetByErpOrgTreeId(TransactionManager transactionManager, System.Decimal? _erpOrgTreeId)
		{
			int count = -1;
			return GetByErpOrgTreeId(transactionManager, _erpOrgTreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ERP_ORG_TREE key.
		///		FK_SE_USER_ERP_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeId">XXnot usedXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUser objects.</returns>
		public TList<SeUser> GetByErpOrgTreeId(TransactionManager transactionManager, System.Decimal? _erpOrgTreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByErpOrgTreeId(transactionManager, _erpOrgTreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ERP_ORG_TREE key.
		///		fkSeUserErpOrgTree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_erpOrgTreeId">XXnot usedXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUser objects.</returns>
		public TList<SeUser> GetByErpOrgTreeId(System.Decimal? _erpOrgTreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByErpOrgTreeId(null, _erpOrgTreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ERP_ORG_TREE key.
		///		fkSeUserErpOrgTree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_erpOrgTreeId">XXnot usedXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUser objects.</returns>
		public TList<SeUser> GetByErpOrgTreeId(System.Decimal? _erpOrgTreeId, int start, int pageLength,out int count)
		{
			return GetByErpOrgTreeId(null, _erpOrgTreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ERP_ORG_TREE key.
		///		FK_SE_USER_ERP_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeId">XXnot usedXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUser objects.</returns>
		public abstract TList<SeUser> GetByErpOrgTreeId(TransactionManager transactionManager, System.Decimal? _erpOrgTreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_SE_CODE_USER_TYPE key.
		///		FK_SE_USER_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="_seCodeUserTypeId">Default User Type</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUser objects.</returns>
		public TList<SeUser> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(_seCodeUserTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_SE_CODE_USER_TYPE key.
		///		FK_SE_USER_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId">Default User Type</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUser objects.</returns>
		/// <remarks></remarks>
		public TList<SeUser> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_SE_CODE_USER_TYPE key.
		///		FK_SE_USER_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId">Default User Type</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUser objects.</returns>
		public TList<SeUser> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_SE_CODE_USER_TYPE key.
		///		fkSeUserSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId">Default User Type</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUser objects.</returns>
		public TList<SeUser> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_SE_CODE_USER_TYPE key.
		///		fkSeUserSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId">Default User Type</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUser objects.</returns>
		public TList<SeUser> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId, int start, int pageLength,out int count)
		{
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_SE_CODE_USER_TYPE key.
		///		FK_SE_USER_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId">Default User Type</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUser objects.</returns>
		public abstract TList<SeUser> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SeUser Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserKey key, int start, int pageLength)
		{
			return GetBySeUserId(transactionManager, key.SeUserId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_CREATOR_USER_ID_1 index.
		/// </summary>
		/// <param name="_creatorUserId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUser&gt;"/> class.</returns>
		public TList<SeUser> GetByCreatorUserId(System.Decimal? _creatorUserId)
		{
			int count = -1;
			return GetByCreatorUserId(null,_creatorUserId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CREATOR_USER_ID_1 index.
		/// </summary>
		/// <param name="_creatorUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUser&gt;"/> class.</returns>
		public TList<SeUser> GetByCreatorUserId(System.Decimal? _creatorUserId, int start, int pageLength)
		{
			int count = -1;
			return GetByCreatorUserId(null, _creatorUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CREATOR_USER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_creatorUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUser&gt;"/> class.</returns>
		public TList<SeUser> GetByCreatorUserId(TransactionManager transactionManager, System.Decimal? _creatorUserId)
		{
			int count = -1;
			return GetByCreatorUserId(transactionManager, _creatorUserId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CREATOR_USER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_creatorUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUser&gt;"/> class.</returns>
		public TList<SeUser> GetByCreatorUserId(TransactionManager transactionManager, System.Decimal? _creatorUserId, int start, int pageLength)
		{
			int count = -1;
			return GetByCreatorUserId(transactionManager, _creatorUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CREATOR_USER_ID_1 index.
		/// </summary>
		/// <param name="_creatorUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUser&gt;"/> class.</returns>
		public TList<SeUser> GetByCreatorUserId(System.Decimal? _creatorUserId, int start, int pageLength, out int count)
		{
			return GetByCreatorUserId(null, _creatorUserId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CREATOR_USER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_creatorUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUser&gt;"/> class.</returns>
		public abstract TList<SeUser> GetByCreatorUserId(TransactionManager transactionManager, System.Decimal? _creatorUserId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SE_CODE_USER_JOB_ID_1 index.
		/// </summary>
		/// <param name="_seCodeUserJobId">XXX</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUser&gt;"/> class.</returns>
		public TList<SeUser> GetBySeCodeUserJobId(System.Decimal? _seCodeUserJobId)
		{
			int count = -1;
			return GetBySeCodeUserJobId(null,_seCodeUserJobId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CODE_USER_JOB_ID_1 index.
		/// </summary>
		/// <param name="_seCodeUserJobId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUser&gt;"/> class.</returns>
		public TList<SeUser> GetBySeCodeUserJobId(System.Decimal? _seCodeUserJobId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserJobId(null, _seCodeUserJobId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CODE_USER_JOB_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserJobId">XXX</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUser&gt;"/> class.</returns>
		public TList<SeUser> GetBySeCodeUserJobId(TransactionManager transactionManager, System.Decimal? _seCodeUserJobId)
		{
			int count = -1;
			return GetBySeCodeUserJobId(transactionManager, _seCodeUserJobId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CODE_USER_JOB_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserJobId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUser&gt;"/> class.</returns>
		public TList<SeUser> GetBySeCodeUserJobId(TransactionManager transactionManager, System.Decimal? _seCodeUserJobId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserJobId(transactionManager, _seCodeUserJobId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CODE_USER_JOB_ID_1 index.
		/// </summary>
		/// <param name="_seCodeUserJobId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUser&gt;"/> class.</returns>
		public TList<SeUser> GetBySeCodeUserJobId(System.Decimal? _seCodeUserJobId, int start, int pageLength, out int count)
		{
			return GetBySeCodeUserJobId(null, _seCodeUserJobId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CODE_USER_JOB_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserJobId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUser&gt;"/> class.</returns>
		public abstract TList<SeUser> GetBySeCodeUserJobId(TransactionManager transactionManager, System.Decimal? _seCodeUserJobId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SE_CODE_USER_PLACE_I_1 index.
		/// </summary>
		/// <param name="_seCodeUserPlaceId">XXX</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUser&gt;"/> class.</returns>
		public TList<SeUser> GetBySeCodeUserPlaceId(System.Decimal? _seCodeUserPlaceId)
		{
			int count = -1;
			return GetBySeCodeUserPlaceId(null,_seCodeUserPlaceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CODE_USER_PLACE_I_1 index.
		/// </summary>
		/// <param name="_seCodeUserPlaceId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUser&gt;"/> class.</returns>
		public TList<SeUser> GetBySeCodeUserPlaceId(System.Decimal? _seCodeUserPlaceId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserPlaceId(null, _seCodeUserPlaceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CODE_USER_PLACE_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserPlaceId">XXX</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUser&gt;"/> class.</returns>
		public TList<SeUser> GetBySeCodeUserPlaceId(TransactionManager transactionManager, System.Decimal? _seCodeUserPlaceId)
		{
			int count = -1;
			return GetBySeCodeUserPlaceId(transactionManager, _seCodeUserPlaceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CODE_USER_PLACE_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserPlaceId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUser&gt;"/> class.</returns>
		public TList<SeUser> GetBySeCodeUserPlaceId(TransactionManager transactionManager, System.Decimal? _seCodeUserPlaceId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserPlaceId(transactionManager, _seCodeUserPlaceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CODE_USER_PLACE_I_1 index.
		/// </summary>
		/// <param name="_seCodeUserPlaceId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUser&gt;"/> class.</returns>
		public TList<SeUser> GetBySeCodeUserPlaceId(System.Decimal? _seCodeUserPlaceId, int start, int pageLength, out int count)
		{
			return GetBySeCodeUserPlaceId(null, _seCodeUserPlaceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CODE_USER_PLACE_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserPlaceId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUser&gt;"/> class.</returns>
		public abstract TList<SeUser> GetBySeCodeUserPlaceId(TransactionManager transactionManager, System.Decimal? _seCodeUserPlaceId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_USER index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUser"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUser GetBySeUserId(System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(null,_seUserId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUser"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUser GetBySeUserId(System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUser"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUser GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUser"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUser GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUser"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUser GetBySeUserId(System.Decimal _seUserId, int start, int pageLength, out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUser"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeUser GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeUser&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeUser&gt;"/></returns>
		public static TList<SeUser> Fill(IDataReader reader, TList<SeUser> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeUser c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeUser")
					.Append("|").Append((System.Decimal)reader["SE_USER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeUser>(
					key.ToString(), // EntityTrackingKey
					"SeUser",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeUser();
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
					c.SeUserId = (System.Decimal)reader["SE_USER_ID"];
					c.OriginalSeUserId = c.SeUserId;
					c.SeCodeUserJobId = Convert.IsDBNull(reader["SE_CODE_USER_JOB_ID"]) ? null : (System.Decimal?)reader["SE_CODE_USER_JOB_ID"];
					c.SeCodeUserPlaceId = Convert.IsDBNull(reader["SE_CODE_USER_PLACE_ID"]) ? null : (System.Decimal?)reader["SE_CODE_USER_PLACE_ID"];
					c.UserNameEn = (System.String)reader["USER_NAME_EN"];
					c.UserNameAr = Convert.IsDBNull(reader["USER_NAME_AR"]) ? null : (System.String)reader["USER_NAME_AR"];
					c.PwdExpireDate = Convert.IsDBNull(reader["PWD_EXPIRE_DATE"]) ? null : (System.DateTime?)reader["PWD_EXPIRE_DATE"];
					c.SecurityQuestion = (System.String)reader["SECURITY_QUESTION"];
					c.SequrityAns = (System.String)reader["SEQURITY_ANS"];
					c.CreatorUserId = Convert.IsDBNull(reader["CREATOR_USER_ID"]) ? null : (System.Decimal?)reader["CREATOR_USER_ID"];
					c.CreationDate = (System.DateTime)reader["CREATION_DATE"];
					c.LastLoginDate = Convert.IsDBNull(reader["LAST_LOGIN_DATE"]) ? null : (System.DateTime?)reader["LAST_LOGIN_DATE"];
					c.Status = (System.Decimal)reader["STATUS"];
					c.FailedAttemptsNum = (System.Decimal)reader["FAILED_ATTEMPTS_NUM"];
					c.ValidateMachine = Convert.IsDBNull(reader["VALIDATE_MACHINE"]) ? null : (System.Decimal?)reader["VALIDATE_MACHINE"];
					c.Ip = Convert.IsDBNull(reader["IP"]) ? null : (System.String)reader["IP"];
					c.Mac = Convert.IsDBNull(reader["MAC"]) ? null : (System.String)reader["MAC"];
					c.IsLogin = Convert.IsDBNull(reader["IS_LOGIN"]) ? null : (System.Decimal?)reader["IS_LOGIN"];
					c.Email = Convert.IsDBNull(reader["Email"]) ? null : (System.String)reader["Email"];
					c.AdUserName = (System.String)reader["AD_USER_NAME"];
					c.AdUserGuid = Convert.IsDBNull(reader["AD_USER_GUID"]) ? null : (System.String)reader["AD_USER_GUID"];
					c.SeCodeUserTypeId = Convert.IsDBNull(reader["SE_CODE_USER_TYPE_ID"]) ? null : (System.Decimal?)reader["SE_CODE_USER_TYPE_ID"];
					c.UserTableId = Convert.IsDBNull(reader["USER_TABLE_ID"]) ? null : (System.Decimal?)reader["USER_TABLE_ID"];
					c.ErpOrgTreeId = Convert.IsDBNull(reader["ERP_ORG_TREE_ID"]) ? null : (System.Decimal?)reader["ERP_ORG_TREE_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserLstId = Convert.IsDBNull(reader["SE_USER_LST_ID"]) ? null : (System.Decimal?)reader["SE_USER_LST_ID"];
					c.ForgetPasswordCode = Convert.IsDBNull(reader["ForgetPasswordCode"]) ? null : (System.String)reader["ForgetPasswordCode"];
					c.ForgetPasswordCodeValidUntil = Convert.IsDBNull(reader["ForgetPasswordCodeValidUntil"]) ? null : (System.DateTime?)reader["ForgetPasswordCodeValidUntil"];
					c.EnumId = Convert.IsDBNull(reader["ENUM_ID"]) ? null : (System.Int32?)reader["ENUM_ID"];
					c.UserMobile = Convert.IsDBNull(reader["USER_MOBILE"]) ? null : (System.String)reader["USER_MOBILE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeUser"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeUser"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeUser entity)
		{
			if (!reader.Read()) return;
			
			entity.SeUserId = (System.Decimal)reader[((int)SeUserColumn.SeUserId - 1)];
			entity.OriginalSeUserId = (System.Decimal)reader["SE_USER_ID"];
			entity.SeCodeUserJobId = (reader.IsDBNull(((int)SeUserColumn.SeCodeUserJobId - 1)))?null:(System.Decimal?)reader[((int)SeUserColumn.SeCodeUserJobId - 1)];
			entity.SeCodeUserPlaceId = (reader.IsDBNull(((int)SeUserColumn.SeCodeUserPlaceId - 1)))?null:(System.Decimal?)reader[((int)SeUserColumn.SeCodeUserPlaceId - 1)];
			entity.UserNameEn = (System.String)reader[((int)SeUserColumn.UserNameEn - 1)];
			entity.UserNameAr = (reader.IsDBNull(((int)SeUserColumn.UserNameAr - 1)))?null:(System.String)reader[((int)SeUserColumn.UserNameAr - 1)];
			entity.PwdExpireDate = (reader.IsDBNull(((int)SeUserColumn.PwdExpireDate - 1)))?null:(System.DateTime?)reader[((int)SeUserColumn.PwdExpireDate - 1)];
			entity.SecurityQuestion = (System.String)reader[((int)SeUserColumn.SecurityQuestion - 1)];
			entity.SequrityAns = (System.String)reader[((int)SeUserColumn.SequrityAns - 1)];
			entity.CreatorUserId = (reader.IsDBNull(((int)SeUserColumn.CreatorUserId - 1)))?null:(System.Decimal?)reader[((int)SeUserColumn.CreatorUserId - 1)];
			entity.CreationDate = (System.DateTime)reader[((int)SeUserColumn.CreationDate - 1)];
			entity.LastLoginDate = (reader.IsDBNull(((int)SeUserColumn.LastLoginDate - 1)))?null:(System.DateTime?)reader[((int)SeUserColumn.LastLoginDate - 1)];
			entity.Status = (System.Decimal)reader[((int)SeUserColumn.Status - 1)];
			entity.FailedAttemptsNum = (System.Decimal)reader[((int)SeUserColumn.FailedAttemptsNum - 1)];
			entity.ValidateMachine = (reader.IsDBNull(((int)SeUserColumn.ValidateMachine - 1)))?null:(System.Decimal?)reader[((int)SeUserColumn.ValidateMachine - 1)];
			entity.Ip = (reader.IsDBNull(((int)SeUserColumn.Ip - 1)))?null:(System.String)reader[((int)SeUserColumn.Ip - 1)];
			entity.Mac = (reader.IsDBNull(((int)SeUserColumn.Mac - 1)))?null:(System.String)reader[((int)SeUserColumn.Mac - 1)];
			entity.IsLogin = (reader.IsDBNull(((int)SeUserColumn.IsLogin - 1)))?null:(System.Decimal?)reader[((int)SeUserColumn.IsLogin - 1)];
			entity.Email = (reader.IsDBNull(((int)SeUserColumn.Email - 1)))?null:(System.String)reader[((int)SeUserColumn.Email - 1)];
			entity.AdUserName = (System.String)reader[((int)SeUserColumn.AdUserName - 1)];
			entity.AdUserGuid = (reader.IsDBNull(((int)SeUserColumn.AdUserGuid - 1)))?null:(System.String)reader[((int)SeUserColumn.AdUserGuid - 1)];
			entity.SeCodeUserTypeId = (reader.IsDBNull(((int)SeUserColumn.SeCodeUserTypeId - 1)))?null:(System.Decimal?)reader[((int)SeUserColumn.SeCodeUserTypeId - 1)];
			entity.UserTableId = (reader.IsDBNull(((int)SeUserColumn.UserTableId - 1)))?null:(System.Decimal?)reader[((int)SeUserColumn.UserTableId - 1)];
			entity.ErpOrgTreeId = (reader.IsDBNull(((int)SeUserColumn.ErpOrgTreeId - 1)))?null:(System.Decimal?)reader[((int)SeUserColumn.ErpOrgTreeId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SeUserColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SeUserColumn.LastDate - 1)];
			entity.SeUserLstId = (reader.IsDBNull(((int)SeUserColumn.SeUserLstId - 1)))?null:(System.Decimal?)reader[((int)SeUserColumn.SeUserLstId - 1)];
			entity.ForgetPasswordCode = (reader.IsDBNull(((int)SeUserColumn.ForgetPasswordCode - 1)))?null:(System.String)reader[((int)SeUserColumn.ForgetPasswordCode - 1)];
			entity.ForgetPasswordCodeValidUntil = (reader.IsDBNull(((int)SeUserColumn.ForgetPasswordCodeValidUntil - 1)))?null:(System.DateTime?)reader[((int)SeUserColumn.ForgetPasswordCodeValidUntil - 1)];
			entity.EnumId = (reader.IsDBNull(((int)SeUserColumn.EnumId - 1)))?null:(System.Int32?)reader[((int)SeUserColumn.EnumId - 1)];
			entity.UserMobile = (reader.IsDBNull(((int)SeUserColumn.UserMobile - 1)))?null:(System.String)reader[((int)SeUserColumn.UserMobile - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeUser"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeUser"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeUser entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeUserId = (System.Decimal)dataRow["SE_USER_ID"];
			entity.OriginalSeUserId = (System.Decimal)dataRow["SE_USER_ID"];
			entity.SeCodeUserJobId = Convert.IsDBNull(dataRow["SE_CODE_USER_JOB_ID"]) ? null : (System.Decimal?)dataRow["SE_CODE_USER_JOB_ID"];
			entity.SeCodeUserPlaceId = Convert.IsDBNull(dataRow["SE_CODE_USER_PLACE_ID"]) ? null : (System.Decimal?)dataRow["SE_CODE_USER_PLACE_ID"];
			entity.UserNameEn = (System.String)dataRow["USER_NAME_EN"];
			entity.UserNameAr = Convert.IsDBNull(dataRow["USER_NAME_AR"]) ? null : (System.String)dataRow["USER_NAME_AR"];
			entity.PwdExpireDate = Convert.IsDBNull(dataRow["PWD_EXPIRE_DATE"]) ? null : (System.DateTime?)dataRow["PWD_EXPIRE_DATE"];
			entity.SecurityQuestion = (System.String)dataRow["SECURITY_QUESTION"];
			entity.SequrityAns = (System.String)dataRow["SEQURITY_ANS"];
			entity.CreatorUserId = Convert.IsDBNull(dataRow["CREATOR_USER_ID"]) ? null : (System.Decimal?)dataRow["CREATOR_USER_ID"];
			entity.CreationDate = (System.DateTime)dataRow["CREATION_DATE"];
			entity.LastLoginDate = Convert.IsDBNull(dataRow["LAST_LOGIN_DATE"]) ? null : (System.DateTime?)dataRow["LAST_LOGIN_DATE"];
			entity.Status = (System.Decimal)dataRow["STATUS"];
			entity.FailedAttemptsNum = (System.Decimal)dataRow["FAILED_ATTEMPTS_NUM"];
			entity.ValidateMachine = Convert.IsDBNull(dataRow["VALIDATE_MACHINE"]) ? null : (System.Decimal?)dataRow["VALIDATE_MACHINE"];
			entity.Ip = Convert.IsDBNull(dataRow["IP"]) ? null : (System.String)dataRow["IP"];
			entity.Mac = Convert.IsDBNull(dataRow["MAC"]) ? null : (System.String)dataRow["MAC"];
			entity.IsLogin = Convert.IsDBNull(dataRow["IS_LOGIN"]) ? null : (System.Decimal?)dataRow["IS_LOGIN"];
			entity.Email = Convert.IsDBNull(dataRow["Email"]) ? null : (System.String)dataRow["Email"];
			entity.AdUserName = (System.String)dataRow["AD_USER_NAME"];
			entity.AdUserGuid = Convert.IsDBNull(dataRow["AD_USER_GUID"]) ? null : (System.String)dataRow["AD_USER_GUID"];
			entity.SeCodeUserTypeId = Convert.IsDBNull(dataRow["SE_CODE_USER_TYPE_ID"]) ? null : (System.Decimal?)dataRow["SE_CODE_USER_TYPE_ID"];
			entity.UserTableId = Convert.IsDBNull(dataRow["USER_TABLE_ID"]) ? null : (System.Decimal?)dataRow["USER_TABLE_ID"];
			entity.ErpOrgTreeId = Convert.IsDBNull(dataRow["ERP_ORG_TREE_ID"]) ? null : (System.Decimal?)dataRow["ERP_ORG_TREE_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserLstId = Convert.IsDBNull(dataRow["SE_USER_LST_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_LST_ID"];
			entity.ForgetPasswordCode = Convert.IsDBNull(dataRow["ForgetPasswordCode"]) ? null : (System.String)dataRow["ForgetPasswordCode"];
			entity.ForgetPasswordCodeValidUntil = Convert.IsDBNull(dataRow["ForgetPasswordCodeValidUntil"]) ? null : (System.DateTime?)dataRow["ForgetPasswordCodeValidUntil"];
			entity.EnumId = Convert.IsDBNull(dataRow["ENUM_ID"]) ? null : (System.Int32?)dataRow["ENUM_ID"];
			entity.UserMobile = Convert.IsDBNull(dataRow["USER_MOBILE"]) ? null : (System.String)dataRow["USER_MOBILE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeUser"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeUser Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUser entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region ErpOrgTreeIdSource	
			if (CanDeepLoad(entity, "ErpOrgTree|ErpOrgTreeIdSource", deepLoadType, innerList) 
				&& entity.ErpOrgTreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ErpOrgTreeId ?? 0.0m);
				ErpOrgTree tmpEntity = EntityManager.LocateEntity<ErpOrgTree>(EntityLocator.ConstructKeyFromPkItems(typeof(ErpOrgTree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ErpOrgTreeIdSource = tmpEntity;
				else
					entity.ErpOrgTreeIdSource = DataRepository.ErpOrgTreeProvider.GetByErpOrgTreeId(transactionManager, (entity.ErpOrgTreeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ErpOrgTreeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ErpOrgTreeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ErpOrgTreeProvider.DeepLoad(transactionManager, entity.ErpOrgTreeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ErpOrgTreeIdSource

			#region SeCodeUserJobIdSource	
			if (CanDeepLoad(entity, "SeCodeUserJob|SeCodeUserJobIdSource", deepLoadType, innerList) 
				&& entity.SeCodeUserJobIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeCodeUserJobId ?? 0.0m);
				SeCodeUserJob tmpEntity = EntityManager.LocateEntity<SeCodeUserJob>(EntityLocator.ConstructKeyFromPkItems(typeof(SeCodeUserJob), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeCodeUserJobIdSource = tmpEntity;
				else
					entity.SeCodeUserJobIdSource = DataRepository.SeCodeUserJobProvider.GetBySeCodeUserJobId(transactionManager, (entity.SeCodeUserJobId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeCodeUserJobIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeCodeUserJobIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeCodeUserJobProvider.DeepLoad(transactionManager, entity.SeCodeUserJobIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeCodeUserJobIdSource

			#region SeCodeUserPlaceIdSource	
			if (CanDeepLoad(entity, "SeCodeUserPlace|SeCodeUserPlaceIdSource", deepLoadType, innerList) 
				&& entity.SeCodeUserPlaceIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeCodeUserPlaceId ?? 0.0m);
				SeCodeUserPlace tmpEntity = EntityManager.LocateEntity<SeCodeUserPlace>(EntityLocator.ConstructKeyFromPkItems(typeof(SeCodeUserPlace), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeCodeUserPlaceIdSource = tmpEntity;
				else
					entity.SeCodeUserPlaceIdSource = DataRepository.SeCodeUserPlaceProvider.GetBySeCodeUserPlaceId(transactionManager, (entity.SeCodeUserPlaceId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeCodeUserPlaceIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeCodeUserPlaceIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeCodeUserPlaceProvider.DeepLoad(transactionManager, entity.SeCodeUserPlaceIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeCodeUserPlaceIdSource

			#region SeCodeUserTypeIdSource	
			if (CanDeepLoad(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepLoadType, innerList) 
				&& entity.SeCodeUserTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeCodeUserTypeId ?? 0.0m);
				SeCodeUserType tmpEntity = EntityManager.LocateEntity<SeCodeUserType>(EntityLocator.ConstructKeyFromPkItems(typeof(SeCodeUserType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeCodeUserTypeIdSource = tmpEntity;
				else
					entity.SeCodeUserTypeIdSource = DataRepository.SeCodeUserTypeProvider.GetBySeCodeUserTypeId(transactionManager, (entity.SeCodeUserTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeCodeUserTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeCodeUserTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeCodeUserTypeProvider.DeepLoad(transactionManager, entity.SeCodeUserTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeCodeUserTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySeUserId methods when available
			
			#region TrnsStudCarStkrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsStudCarStkr>|TrnsStudCarStkrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsStudCarStkrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsStudCarStkrCollection = DataRepository.TrnsStudCarStkrProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.TrnsStudCarStkrCollection.Count > 0)
				{
					deepHandles.Add("TrnsStudCarStkrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsStudCarStkr>) DataRepository.TrnsStudCarStkrProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsStudCarStkrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudVoucherItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucherItem>|FeeStudVoucherItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherItemCollection = DataRepository.FeeStudVoucherItemProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.FeeStudVoucherItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucherItem>) DataRepository.FeeStudVoucherItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region WfCrsRsltApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<WfCrsRsltApprove>|WfCrsRsltApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'WfCrsRsltApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.WfCrsRsltApproveCollection = DataRepository.WfCrsRsltApproveProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.WfCrsRsltApproveCollection.Count > 0)
				{
					deepHandles.Add("WfCrsRsltApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<WfCrsRsltApprove>) DataRepository.WfCrsRsltApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.WfCrsRsltApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvCourseEvalCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvCourseEval>|SvCourseEvalCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCourseEvalCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvCourseEvalCollection = DataRepository.SvCourseEvalProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.SvCourseEvalCollection.Count > 0)
				{
					deepHandles.Add("SvCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvCourseEval>) DataRepository.SvCourseEvalProvider.DeepLoad,
						new object[] { transactionManager, entity.SvCourseEvalCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvUserTaskCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvUserTask>|SvUserTaskCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvUserTaskCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvUserTaskCollection = DataRepository.SvUserTaskProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.SvUserTaskCollection.Count > 0)
				{
					deepHandles.Add("SvUserTaskCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvUserTask>) DataRepository.SvUserTaskProvider.DeepLoad,
						new object[] { transactionManager, entity.SvUserTaskCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomWfRequestApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomWfRequestApprove>|AccomWfRequestApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomWfRequestApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomWfRequestApproveCollection = DataRepository.AccomWfRequestApproveProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.AccomWfRequestApproveCollection.Count > 0)
				{
					deepHandles.Add("AccomWfRequestApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomWfRequestApprove>) DataRepository.AccomWfRequestApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomWfRequestApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdOfferingCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdOfferingCourse>|EdOfferingCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOfferingCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdOfferingCourseCollection = DataRepository.EdOfferingCourseProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.EdOfferingCourseCollection.Count > 0)
				{
					deepHandles.Add("EdOfferingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOfferingCourse>) DataRepository.EdOfferingCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOfferingCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmInboxCollectionGetByInMsgUserTo
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmInbox>|AdmInboxCollectionGetByInMsgUserTo", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmInboxCollectionGetByInMsgUserTo' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmInboxCollectionGetByInMsgUserTo = DataRepository.AdmInboxProvider.GetByInMsgUserTo(transactionManager, entity.SeUserId);

				if (deep && entity.AdmInboxCollectionGetByInMsgUserTo.Count > 0)
				{
					deepHandles.Add("AdmInboxCollectionGetByInMsgUserTo",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmInbox>) DataRepository.AdmInboxProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmInboxCollectionGetByInMsgUserTo, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseOutcomesTopicsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseOutcomesTopics>|EdCourseOutcomesTopicsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseOutcomesTopicsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseOutcomesTopicsCollection = DataRepository.EdCourseOutcomesTopicsProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.EdCourseOutcomesTopicsCollection.Count > 0)
				{
					deepHandles.Add("EdCourseOutcomesTopicsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseOutcomesTopics>) DataRepository.EdCourseOutcomesTopicsProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseOutcomesTopicsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudGuardCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudGuard>|EdStudGuardCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudGuardCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudGuardCollection = DataRepository.EdStudGuardProvider.GetBySeUserPrntId(transactionManager, entity.SeUserId);

				if (deep && entity.EdStudGuardCollection.Count > 0)
				{
					deepHandles.Add("EdStudGuardCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGuard>) DataRepository.EdStudGuardProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGuardCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStaffEvlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStaffEvl>|SvStaffEvlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffEvlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStaffEvlCollection = DataRepository.SvStaffEvlProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.SvStaffEvlCollection.Count > 0)
				{
					deepHandles.Add("SvStaffEvlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStaffEvl>) DataRepository.SvStaffEvlProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStaffEvlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoControlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoControl>|CoControlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoControlCollection = DataRepository.CoControlProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.CoControlCollection.Count > 0)
				{
					deepHandles.Add("CoControlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoControl>) DataRepository.CoControlProvider.DeepLoad,
						new object[] { transactionManager, entity.CoControlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppFeesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppFees>|AdmAppFeesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppFeesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppFeesCollection = DataRepository.AdmAppFeesProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.AdmAppFeesCollection.Count > 0)
				{
					deepHandles.Add("AdmAppFeesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppFees>) DataRepository.AdmAppFeesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppFeesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdAcadPlanCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAcadPlan>|EdAcadPlanCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadPlanCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAcadPlanCollection = DataRepository.EdAcadPlanProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.EdAcadPlanCollection.Count > 0)
				{
					deepHandles.Add("EdAcadPlanCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcadPlan>) DataRepository.EdAcadPlanProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcadPlanCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoCrsRsltRaiseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoCrsRsltRaise>|CoCrsRsltRaiseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoCrsRsltRaiseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoCrsRsltRaiseCollection = DataRepository.CoCrsRsltRaiseProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.CoCrsRsltRaiseCollection.Count > 0)
				{
					deepHandles.Add("CoCrsRsltRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoCrsRsltRaise>) DataRepository.CoCrsRsltRaiseProvider.DeepLoad,
						new object[] { transactionManager, entity.CoCrsRsltRaiseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudLatenessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudLateness>|EdStudLatenessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudLatenessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudLatenessCollection = DataRepository.EdStudLatenessProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.EdStudLatenessCollection.Count > 0)
				{
					deepHandles.Add("EdStudLatenessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudLateness>) DataRepository.EdStudLatenessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudLatenessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvSrvyHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvSrvyHdr>|SvSrvyHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvSrvyHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvSrvyHdrCollection = DataRepository.SvSrvyHdrProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.SvSrvyHdrCollection.Count > 0)
				{
					deepHandles.Add("SvSrvyHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvSrvyHdr>) DataRepository.SvSrvyHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.SvSrvyHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvUserRefreshTokenCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvUserRefreshToken>|SvUserRefreshTokenCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvUserRefreshTokenCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvUserRefreshTokenCollection = DataRepository.SvUserRefreshTokenProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.SvUserRefreshTokenCollection.Count > 0)
				{
					deepHandles.Add("SvUserRefreshTokenCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvUserRefreshToken>) DataRepository.SvUserRefreshTokenProvider.DeepLoad,
						new object[] { transactionManager, entity.SvUserRefreshTokenCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudFeeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFeeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudFeeItemCollection = DataRepository.FeeStudFeeItemProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.FeeStudFeeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudFeeItem>) DataRepository.FeeStudFeeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudFeeItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmTansikMajorsCodesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmTansikMajorsCodes>|AdmTansikMajorsCodesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmTansikMajorsCodesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmTansikMajorsCodesCollection = DataRepository.AdmTansikMajorsCodesProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.AdmTansikMajorsCodesCollection.Count > 0)
				{
					deepHandles.Add("AdmTansikMajorsCodesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmTansikMajorsCodes>) DataRepository.AdmTansikMajorsCodesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmTansikMajorsCodesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudLockerReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudLockerReq>|SvStudLockerReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudLockerReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudLockerReqCollection = DataRepository.SvStudLockerReqProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.SvStudLockerReqCollection.Count > 0)
				{
					deepHandles.Add("SvStudLockerReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudLockerReq>) DataRepository.SvStudLockerReqProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudLockerReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudNoteCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudNote>|EdStudNoteCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudNoteCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudNoteCollection = DataRepository.EdStudNoteProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.EdStudNoteCollection.Count > 0)
				{
					deepHandles.Add("EdStudNoteCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudNote>) DataRepository.EdStudNoteProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudNoteCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAcadWarnCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAcadWarn>|EdStudAcadWarnCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAcadWarnCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAcadWarnCollection = DataRepository.EdStudAcadWarnProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.EdStudAcadWarnCollection.Count > 0)
				{
					deepHandles.Add("EdStudAcadWarnCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAcadWarn>) DataRepository.EdStudAcadWarnProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAcadWarnCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserAccntCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserAccnt>|SeUserAccntCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserAccntCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserAccntCollection = DataRepository.SeUserAccntProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.SeUserAccntCollection.Count > 0)
				{
					deepHandles.Add("SeUserAccntCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserAccnt>) DataRepository.SeUserAccntProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserAccntCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudEnrollChangeCollectionGetBySeUserInsrtId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudEnrollChange>|EdStudEnrollChangeCollectionGetBySeUserInsrtId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudEnrollChangeCollectionGetBySeUserInsrtId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudEnrollChangeCollectionGetBySeUserInsrtId = DataRepository.EdStudEnrollChangeProvider.GetBySeUserInsrtId(transactionManager, entity.SeUserId);

				if (deep && entity.EdStudEnrollChangeCollectionGetBySeUserInsrtId.Count > 0)
				{
					deepHandles.Add("EdStudEnrollChangeCollectionGetBySeUserInsrtId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudEnrollChange>) DataRepository.EdStudEnrollChangeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudEnrollChangeCollectionGetBySeUserInsrtId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseChngCollectionGetBySeUserId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseChng>|EdStudCourseChngCollectionGetBySeUserId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseChngCollectionGetBySeUserId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseChngCollectionGetBySeUserId = DataRepository.EdStudCourseChngProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.EdStudCourseChngCollectionGetBySeUserId.Count > 0)
				{
					deepHandles.Add("EdStudCourseChngCollectionGetBySeUserId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseChng>) DataRepository.EdStudCourseChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseChngCollectionGetBySeUserId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdOfferingCollectionGetByCrsSchdDeanApprvUsrId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdOffering>|EdOfferingCollectionGetByCrsSchdDeanApprvUsrId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOfferingCollectionGetByCrsSchdDeanApprvUsrId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdOfferingCollectionGetByCrsSchdDeanApprvUsrId = DataRepository.EdOfferingProvider.GetByCrsSchdDeanApprvUsrId(transactionManager, entity.SeUserId);

				if (deep && entity.EdOfferingCollectionGetByCrsSchdDeanApprvUsrId.Count > 0)
				{
					deepHandles.Add("EdOfferingCollectionGetByCrsSchdDeanApprvUsrId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOffering>) DataRepository.EdOfferingProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOfferingCollectionGetByCrsSchdDeanApprvUsrId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CtrStudExpCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrStudExp>|CtrStudExpCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrStudExpCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrStudExpCollection = DataRepository.CtrStudExpProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.CtrStudExpCollection.Count > 0)
				{
					deepHandles.Add("CtrStudExpCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrStudExp>) DataRepository.CtrStudExpProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrStudExpCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvPollHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvPollHdr>|SvPollHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvPollHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvPollHdrCollection = DataRepository.SvPollHdrProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.SvPollHdrCollection.Count > 0)
				{
					deepHandles.Add("SvPollHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvPollHdr>) DataRepository.SvPollHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.SvPollHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseGrdChngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseGrdChngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseGrdChngCollection = DataRepository.EdStudCourseGrdChngProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.EdStudCourseGrdChngCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseGrdChngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseGrdChng>) DataRepository.EdStudCourseGrdChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseGrdChngCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdBylawCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdBylaw>|EdBylawCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBylawCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdBylawCollection = DataRepository.EdBylawProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.EdBylawCollection.Count > 0)
				{
					deepHandles.Add("EdBylawCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdBylaw>) DataRepository.EdBylawProvider.DeepLoad,
						new object[] { transactionManager, entity.EdBylawCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmInboxCollectionGetByInMsgUserFrom
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmInbox>|AdmInboxCollectionGetByInMsgUserFrom", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmInboxCollectionGetByInMsgUserFrom' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmInboxCollectionGetByInMsgUserFrom = DataRepository.AdmInboxProvider.GetByInMsgUserFrom(transactionManager, entity.SeUserId);

				if (deep && entity.AdmInboxCollectionGetByInMsgUserFrom.Count > 0)
				{
					deepHandles.Add("AdmInboxCollectionGetByInMsgUserFrom",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmInbox>) DataRepository.AdmInboxProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmInboxCollectionGetByInMsgUserFrom, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAbsFwCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAbsFw>|EdStudAbsFwCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAbsFwCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAbsFwCollection = DataRepository.EdStudAbsFwProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.EdStudAbsFwCollection.Count > 0)
				{
					deepHandles.Add("EdStudAbsFwCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAbsFw>) DataRepository.EdStudAbsFwProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAbsFwCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeItemTrnsBlncCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeItemTrnsBlnc>|FeeItemTrnsBlncCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeItemTrnsBlncCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeItemTrnsBlncCollection = DataRepository.FeeItemTrnsBlncProvider.GetBySeUserTrnsId(transactionManager, entity.SeUserId);

				if (deep && entity.FeeItemTrnsBlncCollection.Count > 0)
				{
					deepHandles.Add("FeeItemTrnsBlncCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeItemTrnsBlnc>) DataRepository.FeeItemTrnsBlncProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeItemTrnsBlncCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdOutcomeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdOutcome>|EdOutcomeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOutcomeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdOutcomeCollection = DataRepository.EdOutcomeProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.EdOutcomeCollection.Count > 0)
				{
					deepHandles.Add("EdOutcomeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOutcome>) DataRepository.EdOutcomeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOutcomeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdOfferingCollectionGetByExmSchdHodApprvUsrId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdOffering>|EdOfferingCollectionGetByExmSchdHodApprvUsrId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOfferingCollectionGetByExmSchdHodApprvUsrId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdOfferingCollectionGetByExmSchdHodApprvUsrId = DataRepository.EdOfferingProvider.GetByExmSchdHodApprvUsrId(transactionManager, entity.SeUserId);

				if (deep && entity.EdOfferingCollectionGetByExmSchdHodApprvUsrId.Count > 0)
				{
					deepHandles.Add("EdOfferingCollectionGetByExmSchdHodApprvUsrId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOffering>) DataRepository.EdOfferingProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOfferingCollectionGetByExmSchdHodApprvUsrId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudVoucherCollectionGetBySeUserCnclId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucher>|FeeStudVoucherCollectionGetBySeUserCnclId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherCollectionGetBySeUserCnclId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherCollectionGetBySeUserCnclId = DataRepository.FeeStudVoucherProvider.GetBySeUserCnclId(transactionManager, entity.SeUserId);

				if (deep && entity.FeeStudVoucherCollectionGetBySeUserCnclId.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherCollectionGetBySeUserCnclId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucher>) DataRepository.FeeStudVoucherProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherCollectionGetBySeUserCnclId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseChngCollectionGetBySeUserInsrtId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseChng>|EdStudCourseChngCollectionGetBySeUserInsrtId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseChngCollectionGetBySeUserInsrtId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseChngCollectionGetBySeUserInsrtId = DataRepository.EdStudCourseChngProvider.GetBySeUserInsrtId(transactionManager, entity.SeUserId);

				if (deep && entity.EdStudCourseChngCollectionGetBySeUserInsrtId.Count > 0)
				{
					deepHandles.Add("EdStudCourseChngCollectionGetBySeUserInsrtId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseChng>) DataRepository.EdStudCourseChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseChngCollectionGetBySeUserInsrtId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CtrStudOutCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrStudOut>|CtrStudOutCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrStudOutCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrStudOutCollection = DataRepository.CtrStudOutProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.CtrStudOutCollection.Count > 0)
				{
					deepHandles.Add("CtrStudOutCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrStudOut>) DataRepository.CtrStudOutProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrStudOutCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScScheduleDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleDtl>|ScScheduleDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleDtlCollection = DataRepository.ScScheduleDtlProvider.GetBySeUserRsultApproveId(transactionManager, entity.SeUserId);

				if (deep && entity.ScScheduleDtlCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleDtl>) DataRepository.ScScheduleDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoContRoomMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoContRoomMember>|CoContRoomMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoContRoomMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoContRoomMemberCollection = DataRepository.CoContRoomMemberProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.CoContRoomMemberCollection.Count > 0)
				{
					deepHandles.Add("CoContRoomMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoContRoomMember>) DataRepository.CoContRoomMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.CoContRoomMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRplcCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRplc>|EdStudCourseRplcCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRplcCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRplcCollection = DataRepository.EdStudCourseRplcProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.EdStudCourseRplcCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRplcCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRplc>) DataRepository.EdStudCourseRplcProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRplcCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegCollectionGetBySeUserId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseReg>|EdStudCourseRegCollectionGetBySeUserId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegCollectionGetBySeUserId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegCollectionGetBySeUserId = DataRepository.EdStudCourseRegProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.EdStudCourseRegCollectionGetBySeUserId.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegCollectionGetBySeUserId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseReg>) DataRepository.EdStudCourseRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegCollectionGetBySeUserId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppRegHistoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppRegHistoryCollection = DataRepository.AdmAppRegHistoryProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.AdmAppRegHistoryCollection.Count > 0)
				{
					deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppRegHistory>) DataRepository.AdmAppRegHistoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region UsrTopLinkCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<UsrTopLink>|UsrTopLinkCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'UsrTopLinkCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.UsrTopLinkCollection = DataRepository.UsrTopLinkProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.UsrTopLinkCollection.Count > 0)
				{
					deepHandles.Add("UsrTopLinkCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<UsrTopLink>) DataRepository.UsrTopLinkProvider.DeepLoad,
						new object[] { transactionManager, entity.UsrTopLinkCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdOfferingCollectionGetByCrsSchdHodApprvUsrId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdOffering>|EdOfferingCollectionGetByCrsSchdHodApprvUsrId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOfferingCollectionGetByCrsSchdHodApprvUsrId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdOfferingCollectionGetByCrsSchdHodApprvUsrId = DataRepository.EdOfferingProvider.GetByCrsSchdHodApprvUsrId(transactionManager, entity.SeUserId);

				if (deep && entity.EdOfferingCollectionGetByCrsSchdHodApprvUsrId.Count > 0)
				{
					deepHandles.Add("EdOfferingCollectionGetByCrsSchdHodApprvUsrId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOffering>) DataRepository.EdOfferingProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOfferingCollectionGetByCrsSchdHodApprvUsrId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegCollectionGetBySeUserApproveId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseReg>|EdStudCourseRegCollectionGetBySeUserApproveId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegCollectionGetBySeUserApproveId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegCollectionGetBySeUserApproveId = DataRepository.EdStudCourseRegProvider.GetBySeUserApproveId(transactionManager, entity.SeUserId);

				if (deep && entity.EdStudCourseRegCollectionGetBySeUserApproveId.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegCollectionGetBySeUserApproveId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseReg>) DataRepository.EdStudCourseRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegCollectionGetBySeUserApproveId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserCrsAssessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserCrsAssess>|SeUserCrsAssessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserCrsAssessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserCrsAssessCollection = DataRepository.SeUserCrsAssessProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.SeUserCrsAssessCollection.Count > 0)
				{
					deepHandles.Add("SeUserCrsAssessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserCrsAssess>) DataRepository.SeUserCrsAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserCrsAssessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvUserMobTokenCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvUserMobToken>|SvUserMobTokenCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvUserMobTokenCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvUserMobTokenCollection = DataRepository.SvUserMobTokenProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.SvUserMobTokenCollection.Count > 0)
				{
					deepHandles.Add("SvUserMobTokenCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvUserMobToken>) DataRepository.SvUserMobTokenProvider.DeepLoad,
						new object[] { transactionManager, entity.SvUserMobTokenCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeApplicationLogCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeApplicationLog>|SeApplicationLogCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeApplicationLogCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeApplicationLogCollection = DataRepository.SeApplicationLogProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.SeApplicationLogCollection.Count > 0)
				{
					deepHandles.Add("SeApplicationLogCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeApplicationLog>) DataRepository.SeApplicationLogProvider.DeepLoad,
						new object[] { transactionManager, entity.SeApplicationLogCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseOutcomesDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseOutcomesDtl>|EdCourseOutcomesDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseOutcomesDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseOutcomesDtlCollection = DataRepository.EdCourseOutcomesDtlProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.EdCourseOutcomesDtlCollection.Count > 0)
				{
					deepHandles.Add("EdCourseOutcomesDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseOutcomesDtl>) DataRepository.EdCourseOutcomesDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseOutcomesDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmOutboxCollectionGetByOutMsgUserFrom
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmOutbox>|AdmOutboxCollectionGetByOutMsgUserFrom", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmOutboxCollectionGetByOutMsgUserFrom' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmOutboxCollectionGetByOutMsgUserFrom = DataRepository.AdmOutboxProvider.GetByOutMsgUserFrom(transactionManager, entity.SeUserId);

				if (deep && entity.AdmOutboxCollectionGetByOutMsgUserFrom.Count > 0)
				{
					deepHandles.Add("AdmOutboxCollectionGetByOutMsgUserFrom",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmOutbox>) DataRepository.AdmOutboxProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmOutboxCollectionGetByOutMsgUserFrom, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdResultApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdResultApprove>|EdResultApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdResultApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdResultApproveCollection = DataRepository.EdResultApproveProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.EdResultApproveCollection.Count > 0)
				{
					deepHandles.Add("EdResultApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdResultApprove>) DataRepository.EdResultApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.EdResultApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudEnrollChangeCollectionGetBySeUserId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudEnrollChange>|EdStudEnrollChangeCollectionGetBySeUserId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudEnrollChangeCollectionGetBySeUserId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudEnrollChangeCollectionGetBySeUserId = DataRepository.EdStudEnrollChangeProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.EdStudEnrollChangeCollectionGetBySeUserId.Count > 0)
				{
					deepHandles.Add("EdStudEnrollChangeCollectionGetBySeUserId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudEnrollChange>) DataRepository.EdStudEnrollChangeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudEnrollChangeCollectionGetBySeUserId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudVoucherCollectionGetBySeUserId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucher>|FeeStudVoucherCollectionGetBySeUserId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherCollectionGetBySeUserId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherCollectionGetBySeUserId = DataRepository.FeeStudVoucherProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.FeeStudVoucherCollectionGetBySeUserId.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherCollectionGetBySeUserId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucher>) DataRepository.FeeStudVoucherProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherCollectionGetBySeUserId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmTansikAppCodesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmTansikAppCodes>|AdmTansikAppCodesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmTansikAppCodesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmTansikAppCodesCollection = DataRepository.AdmTansikAppCodesProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.AdmTansikAppCodesCollection.Count > 0)
				{
					deepHandles.Add("AdmTansikAppCodesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmTansikAppCodes>) DataRepository.AdmTansikAppCodesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmTansikAppCodesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdOfferingCollectionGetByExmSchdDeanApprvUsrId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdOffering>|EdOfferingCollectionGetByExmSchdDeanApprvUsrId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOfferingCollectionGetByExmSchdDeanApprvUsrId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdOfferingCollectionGetByExmSchdDeanApprvUsrId = DataRepository.EdOfferingProvider.GetByExmSchdDeanApprvUsrId(transactionManager, entity.SeUserId);

				if (deep && entity.EdOfferingCollectionGetByExmSchdDeanApprvUsrId.Count > 0)
				{
					deepHandles.Add("EdOfferingCollectionGetByExmSchdDeanApprvUsrId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOffering>) DataRepository.EdOfferingProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOfferingCollectionGetByExmSchdDeanApprvUsrId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmTansikCodesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmTansikCodes>|AdmTansikCodesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmTansikCodesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmTansikCodesCollection = DataRepository.AdmTansikCodesProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.AdmTansikCodesCollection.Count > 0)
				{
					deepHandles.Add("AdmTansikCodesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmTansikCodes>) DataRepository.AdmTansikCodesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmTansikCodesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudCompCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudComp>|SvStudCompCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudCompCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudCompCollection = DataRepository.SvStudCompProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.SvStudCompCollection.Count > 0)
				{
					deepHandles.Add("SvStudCompCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudComp>) DataRepository.SvStudCompProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudCompCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExcuseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExcuse>|EdStudExcuseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExcuseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExcuseCollection = DataRepository.EdStudExcuseProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.EdStudExcuseCollection.Count > 0)
				{
					deepHandles.Add("EdStudExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExcuse>) DataRepository.EdStudExcuseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExcuseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFineDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFineDtl>|FeeFineDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFineDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFineDtlCollection = DataRepository.FeeFineDtlProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.FeeFineDtlCollection.Count > 0)
				{
					deepHandles.Add("FeeFineDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFineDtl>) DataRepository.FeeFineDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFineDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegAssessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegAssess>|EdStudCourseRegAssessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegAssessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegAssessCollection = DataRepository.EdStudCourseRegAssessProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.EdStudCourseRegAssessCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegAssessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegAssess>) DataRepository.EdStudCourseRegAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegAssessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmOutboxCollectionGetByOutMsgUserTo
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmOutbox>|AdmOutboxCollectionGetByOutMsgUserTo", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmOutboxCollectionGetByOutMsgUserTo' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmOutboxCollectionGetByOutMsgUserTo = DataRepository.AdmOutboxProvider.GetByOutMsgUserTo(transactionManager, entity.SeUserId);

				if (deep && entity.AdmOutboxCollectionGetByOutMsgUserTo.Count > 0)
				{
					deepHandles.Add("AdmOutboxCollectionGetByOutMsgUserTo",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmOutbox>) DataRepository.AdmOutboxProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmOutboxCollectionGetByOutMsgUserTo, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeBlockTransCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeBlockTrans>|SeBlockTransCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeBlockTransCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeBlockTransCollection = DataRepository.SeBlockTransProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.SeBlockTransCollection.Count > 0)
				{
					deepHandles.Add("SeBlockTransCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeBlockTrans>) DataRepository.SeBlockTransProvider.DeepLoad,
						new object[] { transactionManager, entity.SeBlockTransCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region IntegUserAdLogDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<IntegUserAdLogDtl>|IntegUserAdLogDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'IntegUserAdLogDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.IntegUserAdLogDtlCollection = DataRepository.IntegUserAdLogDtlProvider.GetBySeUserId(transactionManager, entity.SeUserId);

				if (deep && entity.IntegUserAdLogDtlCollection.Count > 0)
				{
					deepHandles.Add("IntegUserAdLogDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<IntegUserAdLogDtl>) DataRepository.IntegUserAdLogDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.IntegUserAdLogDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeUser object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeUser instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeUser Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUser entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region ErpOrgTreeIdSource
			if (CanDeepSave(entity, "ErpOrgTree|ErpOrgTreeIdSource", deepSaveType, innerList) 
				&& entity.ErpOrgTreeIdSource != null)
			{
				DataRepository.ErpOrgTreeProvider.Save(transactionManager, entity.ErpOrgTreeIdSource);
				entity.ErpOrgTreeId = entity.ErpOrgTreeIdSource.ErpOrgTreeId;
			}
			#endregion 
			
			#region SeCodeUserJobIdSource
			if (CanDeepSave(entity, "SeCodeUserJob|SeCodeUserJobIdSource", deepSaveType, innerList) 
				&& entity.SeCodeUserJobIdSource != null)
			{
				DataRepository.SeCodeUserJobProvider.Save(transactionManager, entity.SeCodeUserJobIdSource);
				entity.SeCodeUserJobId = entity.SeCodeUserJobIdSource.SeCodeUserJobId;
			}
			#endregion 
			
			#region SeCodeUserPlaceIdSource
			if (CanDeepSave(entity, "SeCodeUserPlace|SeCodeUserPlaceIdSource", deepSaveType, innerList) 
				&& entity.SeCodeUserPlaceIdSource != null)
			{
				DataRepository.SeCodeUserPlaceProvider.Save(transactionManager, entity.SeCodeUserPlaceIdSource);
				entity.SeCodeUserPlaceId = entity.SeCodeUserPlaceIdSource.SeCodeUserPlaceId;
			}
			#endregion 
			
			#region SeCodeUserTypeIdSource
			if (CanDeepSave(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepSaveType, innerList) 
				&& entity.SeCodeUserTypeIdSource != null)
			{
				DataRepository.SeCodeUserTypeProvider.Save(transactionManager, entity.SeCodeUserTypeIdSource);
				entity.SeCodeUserTypeId = entity.SeCodeUserTypeIdSource.SeCodeUserTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<TrnsStudCarStkr>
				if (CanDeepSave(entity.TrnsStudCarStkrCollection, "List<TrnsStudCarStkr>|TrnsStudCarStkrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsStudCarStkr child in entity.TrnsStudCarStkrCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.TrnsStudCarStkrCollection.Count > 0 || entity.TrnsStudCarStkrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsStudCarStkrProvider.Save(transactionManager, entity.TrnsStudCarStkrCollection);
						
						deepHandles.Add("TrnsStudCarStkrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsStudCarStkr >) DataRepository.TrnsStudCarStkrProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsStudCarStkrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudVoucherItem>
				if (CanDeepSave(entity.FeeStudVoucherItemCollection, "List<FeeStudVoucherItem>|FeeStudVoucherItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucherItem child in entity.FeeStudVoucherItemCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.FeeStudVoucherItemCollection.Count > 0 || entity.FeeStudVoucherItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudVoucherItemProvider.Save(transactionManager, entity.FeeStudVoucherItemCollection);
						
						deepHandles.Add("FeeStudVoucherItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudVoucherItem >) DataRepository.FeeStudVoucherItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudVoucherItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<WfCrsRsltApprove>
				if (CanDeepSave(entity.WfCrsRsltApproveCollection, "List<WfCrsRsltApprove>|WfCrsRsltApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(WfCrsRsltApprove child in entity.WfCrsRsltApproveCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.WfCrsRsltApproveCollection.Count > 0 || entity.WfCrsRsltApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.WfCrsRsltApproveProvider.Save(transactionManager, entity.WfCrsRsltApproveCollection);
						
						deepHandles.Add("WfCrsRsltApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< WfCrsRsltApprove >) DataRepository.WfCrsRsltApproveProvider.DeepSave,
							new object[] { transactionManager, entity.WfCrsRsltApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvCourseEval>
				if (CanDeepSave(entity.SvCourseEvalCollection, "List<SvCourseEval>|SvCourseEvalCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvCourseEval child in entity.SvCourseEvalCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.SvCourseEvalCollection.Count > 0 || entity.SvCourseEvalCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvCourseEvalProvider.Save(transactionManager, entity.SvCourseEvalCollection);
						
						deepHandles.Add("SvCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvCourseEval >) DataRepository.SvCourseEvalProvider.DeepSave,
							new object[] { transactionManager, entity.SvCourseEvalCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvUserTask>
				if (CanDeepSave(entity.SvUserTaskCollection, "List<SvUserTask>|SvUserTaskCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvUserTask child in entity.SvUserTaskCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.SvUserTaskCollection.Count > 0 || entity.SvUserTaskCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvUserTaskProvider.Save(transactionManager, entity.SvUserTaskCollection);
						
						deepHandles.Add("SvUserTaskCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvUserTask >) DataRepository.SvUserTaskProvider.DeepSave,
							new object[] { transactionManager, entity.SvUserTaskCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomWfRequestApprove>
				if (CanDeepSave(entity.AccomWfRequestApproveCollection, "List<AccomWfRequestApprove>|AccomWfRequestApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomWfRequestApprove child in entity.AccomWfRequestApproveCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.AccomWfRequestApproveCollection.Count > 0 || entity.AccomWfRequestApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomWfRequestApproveProvider.Save(transactionManager, entity.AccomWfRequestApproveCollection);
						
						deepHandles.Add("AccomWfRequestApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomWfRequestApprove >) DataRepository.AccomWfRequestApproveProvider.DeepSave,
							new object[] { transactionManager, entity.AccomWfRequestApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdOfferingCourse>
				if (CanDeepSave(entity.EdOfferingCourseCollection, "List<EdOfferingCourse>|EdOfferingCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdOfferingCourse child in entity.EdOfferingCourseCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.EdOfferingCourseCollection.Count > 0 || entity.EdOfferingCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdOfferingCourseProvider.Save(transactionManager, entity.EdOfferingCourseCollection);
						
						deepHandles.Add("EdOfferingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdOfferingCourse >) DataRepository.EdOfferingCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EdOfferingCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmInbox>
				if (CanDeepSave(entity.AdmInboxCollectionGetByInMsgUserTo, "List<AdmInbox>|AdmInboxCollectionGetByInMsgUserTo", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmInbox child in entity.AdmInboxCollectionGetByInMsgUserTo)
					{
						if(child.InMsgUserToSource != null)
						{
							child.InMsgUserTo = child.InMsgUserToSource.SeUserId;
						}
						else
						{
							child.InMsgUserTo = entity.SeUserId;
						}

					}

					if (entity.AdmInboxCollectionGetByInMsgUserTo.Count > 0 || entity.AdmInboxCollectionGetByInMsgUserTo.DeletedItems.Count > 0)
					{
						//DataRepository.AdmInboxProvider.Save(transactionManager, entity.AdmInboxCollectionGetByInMsgUserTo);
						
						deepHandles.Add("AdmInboxCollectionGetByInMsgUserTo",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmInbox >) DataRepository.AdmInboxProvider.DeepSave,
							new object[] { transactionManager, entity.AdmInboxCollectionGetByInMsgUserTo, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseOutcomesTopics>
				if (CanDeepSave(entity.EdCourseOutcomesTopicsCollection, "List<EdCourseOutcomesTopics>|EdCourseOutcomesTopicsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseOutcomesTopics child in entity.EdCourseOutcomesTopicsCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.EdCourseOutcomesTopicsCollection.Count > 0 || entity.EdCourseOutcomesTopicsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseOutcomesTopicsProvider.Save(transactionManager, entity.EdCourseOutcomesTopicsCollection);
						
						deepHandles.Add("EdCourseOutcomesTopicsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseOutcomesTopics >) DataRepository.EdCourseOutcomesTopicsProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseOutcomesTopicsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudGuard>
				if (CanDeepSave(entity.EdStudGuardCollection, "List<EdStudGuard>|EdStudGuardCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudGuard child in entity.EdStudGuardCollection)
					{
						if(child.SeUserPrntIdSource != null)
						{
							child.SeUserPrntId = child.SeUserPrntIdSource.SeUserId;
						}
						else
						{
							child.SeUserPrntId = entity.SeUserId;
						}

					}

					if (entity.EdStudGuardCollection.Count > 0 || entity.EdStudGuardCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudGuardProvider.Save(transactionManager, entity.EdStudGuardCollection);
						
						deepHandles.Add("EdStudGuardCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudGuard >) DataRepository.EdStudGuardProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudGuardCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStaffEvl>
				if (CanDeepSave(entity.SvStaffEvlCollection, "List<SvStaffEvl>|SvStaffEvlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStaffEvl child in entity.SvStaffEvlCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.SvStaffEvlCollection.Count > 0 || entity.SvStaffEvlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStaffEvlProvider.Save(transactionManager, entity.SvStaffEvlCollection);
						
						deepHandles.Add("SvStaffEvlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStaffEvl >) DataRepository.SvStaffEvlProvider.DeepSave,
							new object[] { transactionManager, entity.SvStaffEvlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoControl>
				if (CanDeepSave(entity.CoControlCollection, "List<CoControl>|CoControlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoControl child in entity.CoControlCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.CoControlCollection.Count > 0 || entity.CoControlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoControlProvider.Save(transactionManager, entity.CoControlCollection);
						
						deepHandles.Add("CoControlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoControl >) DataRepository.CoControlProvider.DeepSave,
							new object[] { transactionManager, entity.CoControlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppFees>
				if (CanDeepSave(entity.AdmAppFeesCollection, "List<AdmAppFees>|AdmAppFeesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppFees child in entity.AdmAppFeesCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.AdmAppFeesCollection.Count > 0 || entity.AdmAppFeesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppFeesProvider.Save(transactionManager, entity.AdmAppFeesCollection);
						
						deepHandles.Add("AdmAppFeesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppFees >) DataRepository.AdmAppFeesProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppFeesCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdAcadPlan>
				if (CanDeepSave(entity.EdAcadPlanCollection, "List<EdAcadPlan>|EdAcadPlanCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAcadPlan child in entity.EdAcadPlanCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.EdAcadPlanCollection.Count > 0 || entity.EdAcadPlanCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdAcadPlanProvider.Save(transactionManager, entity.EdAcadPlanCollection);
						
						deepHandles.Add("EdAcadPlanCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdAcadPlan >) DataRepository.EdAcadPlanProvider.DeepSave,
							new object[] { transactionManager, entity.EdAcadPlanCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoCrsRsltRaise>
				if (CanDeepSave(entity.CoCrsRsltRaiseCollection, "List<CoCrsRsltRaise>|CoCrsRsltRaiseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoCrsRsltRaise child in entity.CoCrsRsltRaiseCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.CoCrsRsltRaiseCollection.Count > 0 || entity.CoCrsRsltRaiseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoCrsRsltRaiseProvider.Save(transactionManager, entity.CoCrsRsltRaiseCollection);
						
						deepHandles.Add("CoCrsRsltRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoCrsRsltRaise >) DataRepository.CoCrsRsltRaiseProvider.DeepSave,
							new object[] { transactionManager, entity.CoCrsRsltRaiseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudLateness>
				if (CanDeepSave(entity.EdStudLatenessCollection, "List<EdStudLateness>|EdStudLatenessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudLateness child in entity.EdStudLatenessCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.EdStudLatenessCollection.Count > 0 || entity.EdStudLatenessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudLatenessProvider.Save(transactionManager, entity.EdStudLatenessCollection);
						
						deepHandles.Add("EdStudLatenessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudLateness >) DataRepository.EdStudLatenessProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudLatenessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvSrvyHdr>
				if (CanDeepSave(entity.SvSrvyHdrCollection, "List<SvSrvyHdr>|SvSrvyHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvSrvyHdr child in entity.SvSrvyHdrCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.SvSrvyHdrCollection.Count > 0 || entity.SvSrvyHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvSrvyHdrProvider.Save(transactionManager, entity.SvSrvyHdrCollection);
						
						deepHandles.Add("SvSrvyHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvSrvyHdr >) DataRepository.SvSrvyHdrProvider.DeepSave,
							new object[] { transactionManager, entity.SvSrvyHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvUserRefreshToken>
				if (CanDeepSave(entity.SvUserRefreshTokenCollection, "List<SvUserRefreshToken>|SvUserRefreshTokenCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvUserRefreshToken child in entity.SvUserRefreshTokenCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.SvUserRefreshTokenCollection.Count > 0 || entity.SvUserRefreshTokenCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvUserRefreshTokenProvider.Save(transactionManager, entity.SvUserRefreshTokenCollection);
						
						deepHandles.Add("SvUserRefreshTokenCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvUserRefreshToken >) DataRepository.SvUserRefreshTokenProvider.DeepSave,
							new object[] { transactionManager, entity.SvUserRefreshTokenCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudFeeItem>
				if (CanDeepSave(entity.FeeStudFeeItemCollection, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudFeeItem child in entity.FeeStudFeeItemCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.FeeStudFeeItemCollection.Count > 0 || entity.FeeStudFeeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudFeeItemProvider.Save(transactionManager, entity.FeeStudFeeItemCollection);
						
						deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudFeeItem >) DataRepository.FeeStudFeeItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudFeeItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmTansikMajorsCodes>
				if (CanDeepSave(entity.AdmTansikMajorsCodesCollection, "List<AdmTansikMajorsCodes>|AdmTansikMajorsCodesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmTansikMajorsCodes child in entity.AdmTansikMajorsCodesCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.AdmTansikMajorsCodesCollection.Count > 0 || entity.AdmTansikMajorsCodesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmTansikMajorsCodesProvider.Save(transactionManager, entity.AdmTansikMajorsCodesCollection);
						
						deepHandles.Add("AdmTansikMajorsCodesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmTansikMajorsCodes >) DataRepository.AdmTansikMajorsCodesProvider.DeepSave,
							new object[] { transactionManager, entity.AdmTansikMajorsCodesCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudLockerReq>
				if (CanDeepSave(entity.SvStudLockerReqCollection, "List<SvStudLockerReq>|SvStudLockerReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudLockerReq child in entity.SvStudLockerReqCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.SvStudLockerReqCollection.Count > 0 || entity.SvStudLockerReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudLockerReqProvider.Save(transactionManager, entity.SvStudLockerReqCollection);
						
						deepHandles.Add("SvStudLockerReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudLockerReq >) DataRepository.SvStudLockerReqProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudLockerReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudNote>
				if (CanDeepSave(entity.EdStudNoteCollection, "List<EdStudNote>|EdStudNoteCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudNote child in entity.EdStudNoteCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.EdStudNoteCollection.Count > 0 || entity.EdStudNoteCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudNoteProvider.Save(transactionManager, entity.EdStudNoteCollection);
						
						deepHandles.Add("EdStudNoteCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudNote >) DataRepository.EdStudNoteProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudNoteCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAcadWarn>
				if (CanDeepSave(entity.EdStudAcadWarnCollection, "List<EdStudAcadWarn>|EdStudAcadWarnCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAcadWarn child in entity.EdStudAcadWarnCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.EdStudAcadWarnCollection.Count > 0 || entity.EdStudAcadWarnCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAcadWarnProvider.Save(transactionManager, entity.EdStudAcadWarnCollection);
						
						deepHandles.Add("EdStudAcadWarnCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAcadWarn >) DataRepository.EdStudAcadWarnProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAcadWarnCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeUserAccnt>
				if (CanDeepSave(entity.SeUserAccntCollection, "List<SeUserAccnt>|SeUserAccntCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserAccnt child in entity.SeUserAccntCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.SeUserAccntCollection.Count > 0 || entity.SeUserAccntCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserAccntProvider.Save(transactionManager, entity.SeUserAccntCollection);
						
						deepHandles.Add("SeUserAccntCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserAccnt >) DataRepository.SeUserAccntProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserAccntCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudEnrollChange>
				if (CanDeepSave(entity.EdStudEnrollChangeCollectionGetBySeUserInsrtId, "List<EdStudEnrollChange>|EdStudEnrollChangeCollectionGetBySeUserInsrtId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudEnrollChange child in entity.EdStudEnrollChangeCollectionGetBySeUserInsrtId)
					{
						if(child.SeUserInsrtIdSource != null)
						{
							child.SeUserInsrtId = child.SeUserInsrtIdSource.SeUserId;
						}
						else
						{
							child.SeUserInsrtId = entity.SeUserId;
						}

					}

					if (entity.EdStudEnrollChangeCollectionGetBySeUserInsrtId.Count > 0 || entity.EdStudEnrollChangeCollectionGetBySeUserInsrtId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudEnrollChangeProvider.Save(transactionManager, entity.EdStudEnrollChangeCollectionGetBySeUserInsrtId);
						
						deepHandles.Add("EdStudEnrollChangeCollectionGetBySeUserInsrtId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudEnrollChange >) DataRepository.EdStudEnrollChangeProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudEnrollChangeCollectionGetBySeUserInsrtId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseChng>
				if (CanDeepSave(entity.EdStudCourseChngCollectionGetBySeUserId, "List<EdStudCourseChng>|EdStudCourseChngCollectionGetBySeUserId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseChng child in entity.EdStudCourseChngCollectionGetBySeUserId)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.EdStudCourseChngCollectionGetBySeUserId.Count > 0 || entity.EdStudCourseChngCollectionGetBySeUserId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseChngProvider.Save(transactionManager, entity.EdStudCourseChngCollectionGetBySeUserId);
						
						deepHandles.Add("EdStudCourseChngCollectionGetBySeUserId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseChng >) DataRepository.EdStudCourseChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseChngCollectionGetBySeUserId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdOffering>
				if (CanDeepSave(entity.EdOfferingCollectionGetByCrsSchdDeanApprvUsrId, "List<EdOffering>|EdOfferingCollectionGetByCrsSchdDeanApprvUsrId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdOffering child in entity.EdOfferingCollectionGetByCrsSchdDeanApprvUsrId)
					{
						if(child.CrsSchdDeanApprvUsrIdSource != null)
						{
							child.CrsSchdDeanApprvUsrId = child.CrsSchdDeanApprvUsrIdSource.SeUserId;
						}
						else
						{
							child.CrsSchdDeanApprvUsrId = entity.SeUserId;
						}

					}

					if (entity.EdOfferingCollectionGetByCrsSchdDeanApprvUsrId.Count > 0 || entity.EdOfferingCollectionGetByCrsSchdDeanApprvUsrId.DeletedItems.Count > 0)
					{
						//DataRepository.EdOfferingProvider.Save(transactionManager, entity.EdOfferingCollectionGetByCrsSchdDeanApprvUsrId);
						
						deepHandles.Add("EdOfferingCollectionGetByCrsSchdDeanApprvUsrId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdOffering >) DataRepository.EdOfferingProvider.DeepSave,
							new object[] { transactionManager, entity.EdOfferingCollectionGetByCrsSchdDeanApprvUsrId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CtrStudExp>
				if (CanDeepSave(entity.CtrStudExpCollection, "List<CtrStudExp>|CtrStudExpCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrStudExp child in entity.CtrStudExpCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.CtrStudExpCollection.Count > 0 || entity.CtrStudExpCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrStudExpProvider.Save(transactionManager, entity.CtrStudExpCollection);
						
						deepHandles.Add("CtrStudExpCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrStudExp >) DataRepository.CtrStudExpProvider.DeepSave,
							new object[] { transactionManager, entity.CtrStudExpCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvPollHdr>
				if (CanDeepSave(entity.SvPollHdrCollection, "List<SvPollHdr>|SvPollHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvPollHdr child in entity.SvPollHdrCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.SvPollHdrCollection.Count > 0 || entity.SvPollHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvPollHdrProvider.Save(transactionManager, entity.SvPollHdrCollection);
						
						deepHandles.Add("SvPollHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvPollHdr >) DataRepository.SvPollHdrProvider.DeepSave,
							new object[] { transactionManager, entity.SvPollHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseGrdChng>
				if (CanDeepSave(entity.EdStudCourseGrdChngCollection, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseGrdChng child in entity.EdStudCourseGrdChngCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.EdStudCourseGrdChngCollection.Count > 0 || entity.EdStudCourseGrdChngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseGrdChngProvider.Save(transactionManager, entity.EdStudCourseGrdChngCollection);
						
						deepHandles.Add("EdStudCourseGrdChngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseGrdChng >) DataRepository.EdStudCourseGrdChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseGrdChngCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdBylaw>
				if (CanDeepSave(entity.EdBylawCollection, "List<EdBylaw>|EdBylawCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdBylaw child in entity.EdBylawCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.EdBylawCollection.Count > 0 || entity.EdBylawCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawCollection);
						
						deepHandles.Add("EdBylawCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdBylaw >) DataRepository.EdBylawProvider.DeepSave,
							new object[] { transactionManager, entity.EdBylawCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmInbox>
				if (CanDeepSave(entity.AdmInboxCollectionGetByInMsgUserFrom, "List<AdmInbox>|AdmInboxCollectionGetByInMsgUserFrom", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmInbox child in entity.AdmInboxCollectionGetByInMsgUserFrom)
					{
						if(child.InMsgUserFromSource != null)
						{
							child.InMsgUserFrom = child.InMsgUserFromSource.SeUserId;
						}
						else
						{
							child.InMsgUserFrom = entity.SeUserId;
						}

					}

					if (entity.AdmInboxCollectionGetByInMsgUserFrom.Count > 0 || entity.AdmInboxCollectionGetByInMsgUserFrom.DeletedItems.Count > 0)
					{
						//DataRepository.AdmInboxProvider.Save(transactionManager, entity.AdmInboxCollectionGetByInMsgUserFrom);
						
						deepHandles.Add("AdmInboxCollectionGetByInMsgUserFrom",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmInbox >) DataRepository.AdmInboxProvider.DeepSave,
							new object[] { transactionManager, entity.AdmInboxCollectionGetByInMsgUserFrom, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAbsFw>
				if (CanDeepSave(entity.EdStudAbsFwCollection, "List<EdStudAbsFw>|EdStudAbsFwCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAbsFw child in entity.EdStudAbsFwCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.EdStudAbsFwCollection.Count > 0 || entity.EdStudAbsFwCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAbsFwProvider.Save(transactionManager, entity.EdStudAbsFwCollection);
						
						deepHandles.Add("EdStudAbsFwCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAbsFw >) DataRepository.EdStudAbsFwProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAbsFwCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeItemTrnsBlnc>
				if (CanDeepSave(entity.FeeItemTrnsBlncCollection, "List<FeeItemTrnsBlnc>|FeeItemTrnsBlncCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeItemTrnsBlnc child in entity.FeeItemTrnsBlncCollection)
					{
						if(child.SeUserTrnsIdSource != null)
						{
							child.SeUserTrnsId = child.SeUserTrnsIdSource.SeUserId;
						}
						else
						{
							child.SeUserTrnsId = entity.SeUserId;
						}

					}

					if (entity.FeeItemTrnsBlncCollection.Count > 0 || entity.FeeItemTrnsBlncCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeItemTrnsBlncProvider.Save(transactionManager, entity.FeeItemTrnsBlncCollection);
						
						deepHandles.Add("FeeItemTrnsBlncCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeItemTrnsBlnc >) DataRepository.FeeItemTrnsBlncProvider.DeepSave,
							new object[] { transactionManager, entity.FeeItemTrnsBlncCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdOutcome>
				if (CanDeepSave(entity.EdOutcomeCollection, "List<EdOutcome>|EdOutcomeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdOutcome child in entity.EdOutcomeCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.EdOutcomeCollection.Count > 0 || entity.EdOutcomeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdOutcomeProvider.Save(transactionManager, entity.EdOutcomeCollection);
						
						deepHandles.Add("EdOutcomeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdOutcome >) DataRepository.EdOutcomeProvider.DeepSave,
							new object[] { transactionManager, entity.EdOutcomeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdOffering>
				if (CanDeepSave(entity.EdOfferingCollectionGetByExmSchdHodApprvUsrId, "List<EdOffering>|EdOfferingCollectionGetByExmSchdHodApprvUsrId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdOffering child in entity.EdOfferingCollectionGetByExmSchdHodApprvUsrId)
					{
						if(child.ExmSchdHodApprvUsrIdSource != null)
						{
							child.ExmSchdHodApprvUsrId = child.ExmSchdHodApprvUsrIdSource.SeUserId;
						}
						else
						{
							child.ExmSchdHodApprvUsrId = entity.SeUserId;
						}

					}

					if (entity.EdOfferingCollectionGetByExmSchdHodApprvUsrId.Count > 0 || entity.EdOfferingCollectionGetByExmSchdHodApprvUsrId.DeletedItems.Count > 0)
					{
						//DataRepository.EdOfferingProvider.Save(transactionManager, entity.EdOfferingCollectionGetByExmSchdHodApprvUsrId);
						
						deepHandles.Add("EdOfferingCollectionGetByExmSchdHodApprvUsrId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdOffering >) DataRepository.EdOfferingProvider.DeepSave,
							new object[] { transactionManager, entity.EdOfferingCollectionGetByExmSchdHodApprvUsrId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudVoucher>
				if (CanDeepSave(entity.FeeStudVoucherCollectionGetBySeUserCnclId, "List<FeeStudVoucher>|FeeStudVoucherCollectionGetBySeUserCnclId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucher child in entity.FeeStudVoucherCollectionGetBySeUserCnclId)
					{
						if(child.SeUserCnclIdSource != null)
						{
							child.SeUserCnclId = child.SeUserCnclIdSource.SeUserId;
						}
						else
						{
							child.SeUserCnclId = entity.SeUserId;
						}

					}

					if (entity.FeeStudVoucherCollectionGetBySeUserCnclId.Count > 0 || entity.FeeStudVoucherCollectionGetBySeUserCnclId.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudVoucherProvider.Save(transactionManager, entity.FeeStudVoucherCollectionGetBySeUserCnclId);
						
						deepHandles.Add("FeeStudVoucherCollectionGetBySeUserCnclId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudVoucher >) DataRepository.FeeStudVoucherProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudVoucherCollectionGetBySeUserCnclId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseChng>
				if (CanDeepSave(entity.EdStudCourseChngCollectionGetBySeUserInsrtId, "List<EdStudCourseChng>|EdStudCourseChngCollectionGetBySeUserInsrtId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseChng child in entity.EdStudCourseChngCollectionGetBySeUserInsrtId)
					{
						if(child.SeUserInsrtIdSource != null)
						{
							child.SeUserInsrtId = child.SeUserInsrtIdSource.SeUserId;
						}
						else
						{
							child.SeUserInsrtId = entity.SeUserId;
						}

					}

					if (entity.EdStudCourseChngCollectionGetBySeUserInsrtId.Count > 0 || entity.EdStudCourseChngCollectionGetBySeUserInsrtId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseChngProvider.Save(transactionManager, entity.EdStudCourseChngCollectionGetBySeUserInsrtId);
						
						deepHandles.Add("EdStudCourseChngCollectionGetBySeUserInsrtId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseChng >) DataRepository.EdStudCourseChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseChngCollectionGetBySeUserInsrtId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CtrStudOut>
				if (CanDeepSave(entity.CtrStudOutCollection, "List<CtrStudOut>|CtrStudOutCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrStudOut child in entity.CtrStudOutCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.CtrStudOutCollection.Count > 0 || entity.CtrStudOutCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrStudOutProvider.Save(transactionManager, entity.CtrStudOutCollection);
						
						deepHandles.Add("CtrStudOutCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrStudOut >) DataRepository.CtrStudOutProvider.DeepSave,
							new object[] { transactionManager, entity.CtrStudOutCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScScheduleDtl>
				if (CanDeepSave(entity.ScScheduleDtlCollection, "List<ScScheduleDtl>|ScScheduleDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleDtl child in entity.ScScheduleDtlCollection)
					{
						if(child.SeUserRsultApproveIdSource != null)
						{
							child.SeUserRsultApproveId = child.SeUserRsultApproveIdSource.SeUserId;
						}
						else
						{
							child.SeUserRsultApproveId = entity.SeUserId;
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
				
	
			#region List<CoContRoomMember>
				if (CanDeepSave(entity.CoContRoomMemberCollection, "List<CoContRoomMember>|CoContRoomMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoContRoomMember child in entity.CoContRoomMemberCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.CoContRoomMemberCollection.Count > 0 || entity.CoContRoomMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoContRoomMemberProvider.Save(transactionManager, entity.CoContRoomMemberCollection);
						
						deepHandles.Add("CoContRoomMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoContRoomMember >) DataRepository.CoContRoomMemberProvider.DeepSave,
							new object[] { transactionManager, entity.CoContRoomMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRplc>
				if (CanDeepSave(entity.EdStudCourseRplcCollection, "List<EdStudCourseRplc>|EdStudCourseRplcCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRplc child in entity.EdStudCourseRplcCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.EdStudCourseRplcCollection.Count > 0 || entity.EdStudCourseRplcCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRplcProvider.Save(transactionManager, entity.EdStudCourseRplcCollection);
						
						deepHandles.Add("EdStudCourseRplcCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRplc >) DataRepository.EdStudCourseRplcProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRplcCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseReg>
				if (CanDeepSave(entity.EdStudCourseRegCollectionGetBySeUserId, "List<EdStudCourseReg>|EdStudCourseRegCollectionGetBySeUserId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseReg child in entity.EdStudCourseRegCollectionGetBySeUserId)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.EdStudCourseRegCollectionGetBySeUserId.Count > 0 || entity.EdStudCourseRegCollectionGetBySeUserId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegCollectionGetBySeUserId);
						
						deepHandles.Add("EdStudCourseRegCollectionGetBySeUserId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseReg >) DataRepository.EdStudCourseRegProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegCollectionGetBySeUserId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppRegHistory>
				if (CanDeepSave(entity.AdmAppRegHistoryCollection, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppRegHistory child in entity.AdmAppRegHistoryCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.AdmAppRegHistoryCollection.Count > 0 || entity.AdmAppRegHistoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryCollection);
						
						deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppRegHistory >) DataRepository.AdmAppRegHistoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<UsrTopLink>
				if (CanDeepSave(entity.UsrTopLinkCollection, "List<UsrTopLink>|UsrTopLinkCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(UsrTopLink child in entity.UsrTopLinkCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.UsrTopLinkCollection.Count > 0 || entity.UsrTopLinkCollection.DeletedItems.Count > 0)
					{
						//DataRepository.UsrTopLinkProvider.Save(transactionManager, entity.UsrTopLinkCollection);
						
						deepHandles.Add("UsrTopLinkCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< UsrTopLink >) DataRepository.UsrTopLinkProvider.DeepSave,
							new object[] { transactionManager, entity.UsrTopLinkCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdOffering>
				if (CanDeepSave(entity.EdOfferingCollectionGetByCrsSchdHodApprvUsrId, "List<EdOffering>|EdOfferingCollectionGetByCrsSchdHodApprvUsrId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdOffering child in entity.EdOfferingCollectionGetByCrsSchdHodApprvUsrId)
					{
						if(child.CrsSchdHodApprvUsrIdSource != null)
						{
							child.CrsSchdHodApprvUsrId = child.CrsSchdHodApprvUsrIdSource.SeUserId;
						}
						else
						{
							child.CrsSchdHodApprvUsrId = entity.SeUserId;
						}

					}

					if (entity.EdOfferingCollectionGetByCrsSchdHodApprvUsrId.Count > 0 || entity.EdOfferingCollectionGetByCrsSchdHodApprvUsrId.DeletedItems.Count > 0)
					{
						//DataRepository.EdOfferingProvider.Save(transactionManager, entity.EdOfferingCollectionGetByCrsSchdHodApprvUsrId);
						
						deepHandles.Add("EdOfferingCollectionGetByCrsSchdHodApprvUsrId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdOffering >) DataRepository.EdOfferingProvider.DeepSave,
							new object[] { transactionManager, entity.EdOfferingCollectionGetByCrsSchdHodApprvUsrId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseReg>
				if (CanDeepSave(entity.EdStudCourseRegCollectionGetBySeUserApproveId, "List<EdStudCourseReg>|EdStudCourseRegCollectionGetBySeUserApproveId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseReg child in entity.EdStudCourseRegCollectionGetBySeUserApproveId)
					{
						if(child.SeUserApproveIdSource != null)
						{
							child.SeUserApproveId = child.SeUserApproveIdSource.SeUserId;
						}
						else
						{
							child.SeUserApproveId = entity.SeUserId;
						}

					}

					if (entity.EdStudCourseRegCollectionGetBySeUserApproveId.Count > 0 || entity.EdStudCourseRegCollectionGetBySeUserApproveId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegCollectionGetBySeUserApproveId);
						
						deepHandles.Add("EdStudCourseRegCollectionGetBySeUserApproveId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseReg >) DataRepository.EdStudCourseRegProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegCollectionGetBySeUserApproveId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeUserCrsAssess>
				if (CanDeepSave(entity.SeUserCrsAssessCollection, "List<SeUserCrsAssess>|SeUserCrsAssessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserCrsAssess child in entity.SeUserCrsAssessCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.SeUserCrsAssessCollection.Count > 0 || entity.SeUserCrsAssessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserCrsAssessProvider.Save(transactionManager, entity.SeUserCrsAssessCollection);
						
						deepHandles.Add("SeUserCrsAssessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserCrsAssess >) DataRepository.SeUserCrsAssessProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserCrsAssessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvUserMobToken>
				if (CanDeepSave(entity.SvUserMobTokenCollection, "List<SvUserMobToken>|SvUserMobTokenCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvUserMobToken child in entity.SvUserMobTokenCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.SvUserMobTokenCollection.Count > 0 || entity.SvUserMobTokenCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvUserMobTokenProvider.Save(transactionManager, entity.SvUserMobTokenCollection);
						
						deepHandles.Add("SvUserMobTokenCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvUserMobToken >) DataRepository.SvUserMobTokenProvider.DeepSave,
							new object[] { transactionManager, entity.SvUserMobTokenCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeApplicationLog>
				if (CanDeepSave(entity.SeApplicationLogCollection, "List<SeApplicationLog>|SeApplicationLogCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeApplicationLog child in entity.SeApplicationLogCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.SeApplicationLogCollection.Count > 0 || entity.SeApplicationLogCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeApplicationLogProvider.Save(transactionManager, entity.SeApplicationLogCollection);
						
						deepHandles.Add("SeApplicationLogCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeApplicationLog >) DataRepository.SeApplicationLogProvider.DeepSave,
							new object[] { transactionManager, entity.SeApplicationLogCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseOutcomesDtl>
				if (CanDeepSave(entity.EdCourseOutcomesDtlCollection, "List<EdCourseOutcomesDtl>|EdCourseOutcomesDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseOutcomesDtl child in entity.EdCourseOutcomesDtlCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.EdCourseOutcomesDtlCollection.Count > 0 || entity.EdCourseOutcomesDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseOutcomesDtlProvider.Save(transactionManager, entity.EdCourseOutcomesDtlCollection);
						
						deepHandles.Add("EdCourseOutcomesDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseOutcomesDtl >) DataRepository.EdCourseOutcomesDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseOutcomesDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmOutbox>
				if (CanDeepSave(entity.AdmOutboxCollectionGetByOutMsgUserFrom, "List<AdmOutbox>|AdmOutboxCollectionGetByOutMsgUserFrom", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmOutbox child in entity.AdmOutboxCollectionGetByOutMsgUserFrom)
					{
						if(child.OutMsgUserFromSource != null)
						{
							child.OutMsgUserFrom = child.OutMsgUserFromSource.SeUserId;
						}
						else
						{
							child.OutMsgUserFrom = entity.SeUserId;
						}

					}

					if (entity.AdmOutboxCollectionGetByOutMsgUserFrom.Count > 0 || entity.AdmOutboxCollectionGetByOutMsgUserFrom.DeletedItems.Count > 0)
					{
						//DataRepository.AdmOutboxProvider.Save(transactionManager, entity.AdmOutboxCollectionGetByOutMsgUserFrom);
						
						deepHandles.Add("AdmOutboxCollectionGetByOutMsgUserFrom",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmOutbox >) DataRepository.AdmOutboxProvider.DeepSave,
							new object[] { transactionManager, entity.AdmOutboxCollectionGetByOutMsgUserFrom, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdResultApprove>
				if (CanDeepSave(entity.EdResultApproveCollection, "List<EdResultApprove>|EdResultApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdResultApprove child in entity.EdResultApproveCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.EdResultApproveCollection.Count > 0 || entity.EdResultApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdResultApproveProvider.Save(transactionManager, entity.EdResultApproveCollection);
						
						deepHandles.Add("EdResultApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdResultApprove >) DataRepository.EdResultApproveProvider.DeepSave,
							new object[] { transactionManager, entity.EdResultApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudEnrollChange>
				if (CanDeepSave(entity.EdStudEnrollChangeCollectionGetBySeUserId, "List<EdStudEnrollChange>|EdStudEnrollChangeCollectionGetBySeUserId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudEnrollChange child in entity.EdStudEnrollChangeCollectionGetBySeUserId)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.EdStudEnrollChangeCollectionGetBySeUserId.Count > 0 || entity.EdStudEnrollChangeCollectionGetBySeUserId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudEnrollChangeProvider.Save(transactionManager, entity.EdStudEnrollChangeCollectionGetBySeUserId);
						
						deepHandles.Add("EdStudEnrollChangeCollectionGetBySeUserId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudEnrollChange >) DataRepository.EdStudEnrollChangeProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudEnrollChangeCollectionGetBySeUserId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudVoucher>
				if (CanDeepSave(entity.FeeStudVoucherCollectionGetBySeUserId, "List<FeeStudVoucher>|FeeStudVoucherCollectionGetBySeUserId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucher child in entity.FeeStudVoucherCollectionGetBySeUserId)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.FeeStudVoucherCollectionGetBySeUserId.Count > 0 || entity.FeeStudVoucherCollectionGetBySeUserId.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudVoucherProvider.Save(transactionManager, entity.FeeStudVoucherCollectionGetBySeUserId);
						
						deepHandles.Add("FeeStudVoucherCollectionGetBySeUserId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudVoucher >) DataRepository.FeeStudVoucherProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudVoucherCollectionGetBySeUserId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmTansikAppCodes>
				if (CanDeepSave(entity.AdmTansikAppCodesCollection, "List<AdmTansikAppCodes>|AdmTansikAppCodesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmTansikAppCodes child in entity.AdmTansikAppCodesCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.AdmTansikAppCodesCollection.Count > 0 || entity.AdmTansikAppCodesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmTansikAppCodesProvider.Save(transactionManager, entity.AdmTansikAppCodesCollection);
						
						deepHandles.Add("AdmTansikAppCodesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmTansikAppCodes >) DataRepository.AdmTansikAppCodesProvider.DeepSave,
							new object[] { transactionManager, entity.AdmTansikAppCodesCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdOffering>
				if (CanDeepSave(entity.EdOfferingCollectionGetByExmSchdDeanApprvUsrId, "List<EdOffering>|EdOfferingCollectionGetByExmSchdDeanApprvUsrId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdOffering child in entity.EdOfferingCollectionGetByExmSchdDeanApprvUsrId)
					{
						if(child.ExmSchdDeanApprvUsrIdSource != null)
						{
							child.ExmSchdDeanApprvUsrId = child.ExmSchdDeanApprvUsrIdSource.SeUserId;
						}
						else
						{
							child.ExmSchdDeanApprvUsrId = entity.SeUserId;
						}

					}

					if (entity.EdOfferingCollectionGetByExmSchdDeanApprvUsrId.Count > 0 || entity.EdOfferingCollectionGetByExmSchdDeanApprvUsrId.DeletedItems.Count > 0)
					{
						//DataRepository.EdOfferingProvider.Save(transactionManager, entity.EdOfferingCollectionGetByExmSchdDeanApprvUsrId);
						
						deepHandles.Add("EdOfferingCollectionGetByExmSchdDeanApprvUsrId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdOffering >) DataRepository.EdOfferingProvider.DeepSave,
							new object[] { transactionManager, entity.EdOfferingCollectionGetByExmSchdDeanApprvUsrId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmTansikCodes>
				if (CanDeepSave(entity.AdmTansikCodesCollection, "List<AdmTansikCodes>|AdmTansikCodesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmTansikCodes child in entity.AdmTansikCodesCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.AdmTansikCodesCollection.Count > 0 || entity.AdmTansikCodesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmTansikCodesProvider.Save(transactionManager, entity.AdmTansikCodesCollection);
						
						deepHandles.Add("AdmTansikCodesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmTansikCodes >) DataRepository.AdmTansikCodesProvider.DeepSave,
							new object[] { transactionManager, entity.AdmTansikCodesCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudComp>
				if (CanDeepSave(entity.SvStudCompCollection, "List<SvStudComp>|SvStudCompCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudComp child in entity.SvStudCompCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.SvStudCompCollection.Count > 0 || entity.SvStudCompCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudCompProvider.Save(transactionManager, entity.SvStudCompCollection);
						
						deepHandles.Add("SvStudCompCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudComp >) DataRepository.SvStudCompProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudCompCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudExcuse>
				if (CanDeepSave(entity.EdStudExcuseCollection, "List<EdStudExcuse>|EdStudExcuseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExcuse child in entity.EdStudExcuseCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.EdStudExcuseCollection.Count > 0 || entity.EdStudExcuseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExcuseProvider.Save(transactionManager, entity.EdStudExcuseCollection);
						
						deepHandles.Add("EdStudExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExcuse >) DataRepository.EdStudExcuseProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExcuseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFineDtl>
				if (CanDeepSave(entity.FeeFineDtlCollection, "List<FeeFineDtl>|FeeFineDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFineDtl child in entity.FeeFineDtlCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.FeeFineDtlCollection.Count > 0 || entity.FeeFineDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFineDtlProvider.Save(transactionManager, entity.FeeFineDtlCollection);
						
						deepHandles.Add("FeeFineDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFineDtl >) DataRepository.FeeFineDtlProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFineDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegAssess>
				if (CanDeepSave(entity.EdStudCourseRegAssessCollection, "List<EdStudCourseRegAssess>|EdStudCourseRegAssessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegAssess child in entity.EdStudCourseRegAssessCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.EdStudCourseRegAssessCollection.Count > 0 || entity.EdStudCourseRegAssessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegAssessProvider.Save(transactionManager, entity.EdStudCourseRegAssessCollection);
						
						deepHandles.Add("EdStudCourseRegAssessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegAssess >) DataRepository.EdStudCourseRegAssessProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegAssessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmOutbox>
				if (CanDeepSave(entity.AdmOutboxCollectionGetByOutMsgUserTo, "List<AdmOutbox>|AdmOutboxCollectionGetByOutMsgUserTo", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmOutbox child in entity.AdmOutboxCollectionGetByOutMsgUserTo)
					{
						if(child.OutMsgUserToSource != null)
						{
							child.OutMsgUserTo = child.OutMsgUserToSource.SeUserId;
						}
						else
						{
							child.OutMsgUserTo = entity.SeUserId;
						}

					}

					if (entity.AdmOutboxCollectionGetByOutMsgUserTo.Count > 0 || entity.AdmOutboxCollectionGetByOutMsgUserTo.DeletedItems.Count > 0)
					{
						//DataRepository.AdmOutboxProvider.Save(transactionManager, entity.AdmOutboxCollectionGetByOutMsgUserTo);
						
						deepHandles.Add("AdmOutboxCollectionGetByOutMsgUserTo",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmOutbox >) DataRepository.AdmOutboxProvider.DeepSave,
							new object[] { transactionManager, entity.AdmOutboxCollectionGetByOutMsgUserTo, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeBlockTrans>
				if (CanDeepSave(entity.SeBlockTransCollection, "List<SeBlockTrans>|SeBlockTransCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeBlockTrans child in entity.SeBlockTransCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.SeBlockTransCollection.Count > 0 || entity.SeBlockTransCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeBlockTransProvider.Save(transactionManager, entity.SeBlockTransCollection);
						
						deepHandles.Add("SeBlockTransCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeBlockTrans >) DataRepository.SeBlockTransProvider.DeepSave,
							new object[] { transactionManager, entity.SeBlockTransCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<IntegUserAdLogDtl>
				if (CanDeepSave(entity.IntegUserAdLogDtlCollection, "List<IntegUserAdLogDtl>|IntegUserAdLogDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(IntegUserAdLogDtl child in entity.IntegUserAdLogDtlCollection)
					{
						if(child.SeUserIdSource != null)
						{
							child.SeUserId = child.SeUserIdSource.SeUserId;
						}
						else
						{
							child.SeUserId = entity.SeUserId;
						}

					}

					if (entity.IntegUserAdLogDtlCollection.Count > 0 || entity.IntegUserAdLogDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.IntegUserAdLogDtlProvider.Save(transactionManager, entity.IntegUserAdLogDtlCollection);
						
						deepHandles.Add("IntegUserAdLogDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< IntegUserAdLogDtl >) DataRepository.IntegUserAdLogDtlProvider.DeepSave,
							new object[] { transactionManager, entity.IntegUserAdLogDtlCollection, deepSaveType, childTypes, innerList }
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
	
	#region SeUserChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeUser</c>
	///</summary>
	public enum SeUserChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>ErpOrgTree</c> at ErpOrgTreeIdSource
		///</summary>
		[ChildEntityType(typeof(ErpOrgTree))]
		ErpOrgTree,
		
		///<summary>
		/// Composite Property for <c>SeCodeUserJob</c> at SeCodeUserJobIdSource
		///</summary>
		[ChildEntityType(typeof(SeCodeUserJob))]
		SeCodeUserJob,
		
		///<summary>
		/// Composite Property for <c>SeCodeUserPlace</c> at SeCodeUserPlaceIdSource
		///</summary>
		[ChildEntityType(typeof(SeCodeUserPlace))]
		SeCodeUserPlace,
		
		///<summary>
		/// Composite Property for <c>SeCodeUserType</c> at SeCodeUserTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SeCodeUserType))]
		SeCodeUserType,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for TrnsStudCarStkrCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsStudCarStkr>))]
		TrnsStudCarStkrCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for FeeStudVoucherItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucherItem>))]
		FeeStudVoucherItemCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for WfCrsRsltApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<WfCrsRsltApprove>))]
		WfCrsRsltApproveCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for SvCourseEvalCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvCourseEval>))]
		SvCourseEvalCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for SvUserTaskCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvUserTask>))]
		SvUserTaskCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for AccomWfRequestApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomWfRequestApprove>))]
		AccomWfRequestApproveCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdOfferingCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOfferingCourse>))]
		EdOfferingCourseCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for AdmInboxCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmInbox>))]
		AdmInboxCollectionGetByInMsgUserTo,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdCourseOutcomesTopicsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseOutcomesTopics>))]
		EdCourseOutcomesTopicsCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdStudGuardCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGuard>))]
		EdStudGuardCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for SvStaffEvlCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStaffEvl>))]
		SvStaffEvlCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for CoControlCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoControl>))]
		CoControlCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for AdmAppFeesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppFees>))]
		AdmAppFeesCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdAcadPlanCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcadPlan>))]
		EdAcadPlanCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for CoCrsRsltRaiseCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoCrsRsltRaise>))]
		CoCrsRsltRaiseCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdStudLatenessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudLateness>))]
		EdStudLatenessCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for SvSrvyHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvSrvyHdr>))]
		SvSrvyHdrCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for SvUserRefreshTokenCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvUserRefreshToken>))]
		SvUserRefreshTokenCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for FeeStudFeeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudFeeItem>))]
		FeeStudFeeItemCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for AdmTansikMajorsCodesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmTansikMajorsCodes>))]
		AdmTansikMajorsCodesCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for SvStudLockerReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudLockerReq>))]
		SvStudLockerReqCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdStudNoteCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudNote>))]
		EdStudNoteCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdStudAcadWarnCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAcadWarn>))]
		EdStudAcadWarnCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for SeUserAccntCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserAccnt>))]
		SeUserAccntCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdStudEnrollChangeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudEnrollChange>))]
		EdStudEnrollChangeCollectionGetBySeUserInsrtId,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdStudCourseChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseChng>))]
		EdStudCourseChngCollectionGetBySeUserId,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdOfferingCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOffering>))]
		EdOfferingCollectionGetByCrsSchdDeanApprvUsrId,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for CtrStudExpCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrStudExp>))]
		CtrStudExpCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for SvPollHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvPollHdr>))]
		SvPollHdrCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdStudCourseGrdChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseGrdChng>))]
		EdStudCourseGrdChngCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdBylawCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdBylaw>))]
		EdBylawCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for AdmInboxCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmInbox>))]
		AdmInboxCollectionGetByInMsgUserFrom,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdStudAbsFwCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAbsFw>))]
		EdStudAbsFwCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for FeeItemTrnsBlncCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeItemTrnsBlnc>))]
		FeeItemTrnsBlncCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdOutcomeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOutcome>))]
		EdOutcomeCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdOfferingCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOffering>))]
		EdOfferingCollectionGetByExmSchdHodApprvUsrId,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for FeeStudVoucherCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucher>))]
		FeeStudVoucherCollectionGetBySeUserCnclId,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdStudCourseChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseChng>))]
		EdStudCourseChngCollectionGetBySeUserInsrtId,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for CtrStudOutCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrStudOut>))]
		CtrStudOutCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for ScScheduleDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleDtl>))]
		ScScheduleDtlCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for CoContRoomMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoContRoomMember>))]
		CoContRoomMemberCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdStudCourseRplcCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRplc>))]
		EdStudCourseRplcCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdStudCourseRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseReg>))]
		EdStudCourseRegCollectionGetBySeUserId,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for AdmAppRegHistoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppRegHistory>))]
		AdmAppRegHistoryCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for UsrTopLinkCollection
		///</summary>
		[ChildEntityType(typeof(TList<UsrTopLink>))]
		UsrTopLinkCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdOfferingCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOffering>))]
		EdOfferingCollectionGetByCrsSchdHodApprvUsrId,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdStudCourseRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseReg>))]
		EdStudCourseRegCollectionGetBySeUserApproveId,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for SeUserCrsAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserCrsAssess>))]
		SeUserCrsAssessCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for SvUserMobTokenCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvUserMobToken>))]
		SvUserMobTokenCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for SeApplicationLogCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeApplicationLog>))]
		SeApplicationLogCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdCourseOutcomesDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseOutcomesDtl>))]
		EdCourseOutcomesDtlCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for AdmOutboxCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmOutbox>))]
		AdmOutboxCollectionGetByOutMsgUserFrom,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdResultApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdResultApprove>))]
		EdResultApproveCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdStudEnrollChangeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudEnrollChange>))]
		EdStudEnrollChangeCollectionGetBySeUserId,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for FeeStudVoucherCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucher>))]
		FeeStudVoucherCollectionGetBySeUserId,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for AdmTansikAppCodesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmTansikAppCodes>))]
		AdmTansikAppCodesCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdOfferingCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOffering>))]
		EdOfferingCollectionGetByExmSchdDeanApprvUsrId,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for AdmTansikCodesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmTansikCodes>))]
		AdmTansikCodesCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for SvStudCompCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudComp>))]
		SvStudCompCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdStudExcuseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExcuse>))]
		EdStudExcuseCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for FeeFineDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFineDtl>))]
		FeeFineDtlCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for EdStudCourseRegAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegAssess>))]
		EdStudCourseRegAssessCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for AdmOutboxCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmOutbox>))]
		AdmOutboxCollectionGetByOutMsgUserTo,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for SeBlockTransCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeBlockTrans>))]
		SeBlockTransCollection,
		///<summary>
		/// Collection of <c>SeUser</c> as OneToMany for IntegUserAdLogDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<IntegUserAdLogDtl>))]
		IntegUserAdLogDtlCollection,
	}
	
	#endregion SeUserChildEntityTypes
	
	#region SeUserFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeUserColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeUser"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeUserFilterBuilder : SqlFilterBuilder<SeUserColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeUserFilterBuilder class.
		/// </summary>
		public SeUserFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeUserFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeUserFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeUserFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeUserFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeUserFilterBuilder
	
	#region SeUserParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeUserColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeUser"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeUserParameterBuilder : ParameterizedSqlFilterBuilder<SeUserColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeUserParameterBuilder class.
		/// </summary>
		public SeUserParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeUserParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeUserParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeUserParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeUserParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeUserParameterBuilder
	
	#region SeUserSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeUserColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeUser"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeUserSortBuilder : SqlSortBuilder<SeUserColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeUserSqlSortBuilder class.
		/// </summary>
		public SeUserSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeUserSortBuilder
	
} // end namespace
