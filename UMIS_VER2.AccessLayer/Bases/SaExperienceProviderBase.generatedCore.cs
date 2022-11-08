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
	/// This class is the base class for any <see cref="SaExperienceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaExperienceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaExperience, UMIS_VER2.BusinessLyer.SaExperienceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaExperienceKey key)
		{
			return Delete(transactionManager, key.SaExperienceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saExperienceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saExperienceId)
		{
			return Delete(null, _saExperienceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saExperienceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saExperienceId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaExperience Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaExperienceKey key, int start, int pageLength)
		{
			return GetBySaExperienceId(transactionManager, key.SaExperienceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public abstract TList<SaExperience> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_NODE_ID_1 index.
		/// </summary>
		/// <param name="_asNodeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetByAsNodeId(System.Decimal? _asNodeId)
		{
			int count = -1;
			return GetByAsNodeId(null,_asNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_NODE_ID_1 index.
		/// </summary>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetByAsNodeId(System.Decimal? _asNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsNodeId(null, _asNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetByAsNodeId(TransactionManager transactionManager, System.Decimal? _asNodeId)
		{
			int count = -1;
			return GetByAsNodeId(transactionManager, _asNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetByAsNodeId(TransactionManager transactionManager, System.Decimal? _asNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsNodeId(transactionManager, _asNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_NODE_ID_1 index.
		/// </summary>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetByAsNodeId(System.Decimal? _asNodeId, int start, int pageLength, out int count)
		{
			return GetByAsNodeId(null, _asNodeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public abstract TList<SaExperience> GetByAsNodeId(TransactionManager transactionManager, System.Decimal? _asNodeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(null,_gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId, int start, int pageLength, out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public abstract TList<SaExperience> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_CODE_EXPERIENCE_I_1 index.
		/// </summary>
		/// <param name="_saCodeExperienceId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetBySaCodeExperienceId(System.Decimal _saCodeExperienceId)
		{
			int count = -1;
			return GetBySaCodeExperienceId(null,_saCodeExperienceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_EXPERIENCE_I_1 index.
		/// </summary>
		/// <param name="_saCodeExperienceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetBySaCodeExperienceId(System.Decimal _saCodeExperienceId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeExperienceId(null, _saCodeExperienceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_EXPERIENCE_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeExperienceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetBySaCodeExperienceId(TransactionManager transactionManager, System.Decimal _saCodeExperienceId)
		{
			int count = -1;
			return GetBySaCodeExperienceId(transactionManager, _saCodeExperienceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_EXPERIENCE_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeExperienceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetBySaCodeExperienceId(TransactionManager transactionManager, System.Decimal _saCodeExperienceId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeExperienceId(transactionManager, _saCodeExperienceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_EXPERIENCE_I_1 index.
		/// </summary>
		/// <param name="_saCodeExperienceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetBySaCodeExperienceId(System.Decimal _saCodeExperienceId, int start, int pageLength, out int count)
		{
			return GetBySaCodeExperienceId(null, _saCodeExperienceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_EXPERIENCE_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeExperienceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public abstract TList<SaExperience> GetBySaCodeExperienceId(TransactionManager transactionManager, System.Decimal _saCodeExperienceId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_CODE_ORG_ID_1 index.
		/// </summary>
		/// <param name="_saCodeOrgId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetBySaCodeOrgId(System.Decimal? _saCodeOrgId)
		{
			int count = -1;
			return GetBySaCodeOrgId(null,_saCodeOrgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_ORG_ID_1 index.
		/// </summary>
		/// <param name="_saCodeOrgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetBySaCodeOrgId(System.Decimal? _saCodeOrgId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeOrgId(null, _saCodeOrgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_ORG_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeOrgId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetBySaCodeOrgId(TransactionManager transactionManager, System.Decimal? _saCodeOrgId)
		{
			int count = -1;
			return GetBySaCodeOrgId(transactionManager, _saCodeOrgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_ORG_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeOrgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetBySaCodeOrgId(TransactionManager transactionManager, System.Decimal? _saCodeOrgId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeOrgId(transactionManager, _saCodeOrgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_ORG_ID_1 index.
		/// </summary>
		/// <param name="_saCodeOrgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetBySaCodeOrgId(System.Decimal? _saCodeOrgId, int start, int pageLength, out int count)
		{
			return GetBySaCodeOrgId(null, _saCodeOrgId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_ORG_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeOrgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public abstract TList<SaExperience> GetBySaCodeOrgId(TransactionManager transactionManager, System.Decimal? _saCodeOrgId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetBySaStfMemberId(System.Decimal _saStfMemberId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public TList<SaExperience> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExperience&gt;"/> class.</returns>
		public abstract TList<SaExperience> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_EXPERIENCE index.
		/// </summary>
		/// <param name="_saExperienceId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaExperience"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaExperience GetBySaExperienceId(System.Decimal _saExperienceId)
		{
			int count = -1;
			return GetBySaExperienceId(null,_saExperienceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_EXPERIENCE index.
		/// </summary>
		/// <param name="_saExperienceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaExperience"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaExperience GetBySaExperienceId(System.Decimal _saExperienceId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaExperienceId(null, _saExperienceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_EXPERIENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saExperienceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaExperience"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaExperience GetBySaExperienceId(TransactionManager transactionManager, System.Decimal _saExperienceId)
		{
			int count = -1;
			return GetBySaExperienceId(transactionManager, _saExperienceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_EXPERIENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saExperienceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaExperience"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaExperience GetBySaExperienceId(TransactionManager transactionManager, System.Decimal _saExperienceId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaExperienceId(transactionManager, _saExperienceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_EXPERIENCE index.
		/// </summary>
		/// <param name="_saExperienceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaExperience"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaExperience GetBySaExperienceId(System.Decimal _saExperienceId, int start, int pageLength, out int count)
		{
			return GetBySaExperienceId(null, _saExperienceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_EXPERIENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saExperienceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaExperience"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaExperience GetBySaExperienceId(TransactionManager transactionManager, System.Decimal _saExperienceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaExperience&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaExperience&gt;"/></returns>
		public static TList<SaExperience> Fill(IDataReader reader, TList<SaExperience> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaExperience c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaExperience")
					.Append("|").Append((System.Decimal)reader["SA_EXPERIENCE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaExperience>(
					key.ToString(), // EntityTrackingKey
					"SaExperience",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaExperience();
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
					c.SaExperienceId = (System.Decimal)reader["SA_EXPERIENCE_ID"];
					c.OriginalSaExperienceId = c.SaExperienceId;
					c.ExpFrom = (System.DateTime)reader["EXP_FROM"];
					c.ExpTo = Convert.IsDBNull(reader["EXP_TO"]) ? null : (System.DateTime?)reader["EXP_TO"];
					c.IsOrgUni = (System.Decimal)reader["IS_ORG_UNI"];
					c.Comments = Convert.IsDBNull(reader["COMMENTS"]) ? null : (System.String)reader["COMMENTS"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.SaCodeExperienceId = (System.Decimal)reader["SA_CODE_EXPERIENCE_ID"];
					c.GsCountryNodeId = (System.Decimal)reader["GS_COUNTRY_NODE_ID"];
					c.AsNodeId = Convert.IsDBNull(reader["AS_NODE_ID"]) ? null : (System.Decimal?)reader["AS_NODE_ID"];
					c.SaCodeOrgId = Convert.IsDBNull(reader["SA_CODE_ORG_ID"]) ? null : (System.Decimal?)reader["SA_CODE_ORG_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaExperience"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaExperience"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaExperience entity)
		{
			if (!reader.Read()) return;
			
			entity.SaExperienceId = (System.Decimal)reader[((int)SaExperienceColumn.SaExperienceId - 1)];
			entity.OriginalSaExperienceId = (System.Decimal)reader["SA_EXPERIENCE_ID"];
			entity.ExpFrom = (System.DateTime)reader[((int)SaExperienceColumn.ExpFrom - 1)];
			entity.ExpTo = (reader.IsDBNull(((int)SaExperienceColumn.ExpTo - 1)))?null:(System.DateTime?)reader[((int)SaExperienceColumn.ExpTo - 1)];
			entity.IsOrgUni = (System.Decimal)reader[((int)SaExperienceColumn.IsOrgUni - 1)];
			entity.Comments = (reader.IsDBNull(((int)SaExperienceColumn.Comments - 1)))?null:(System.String)reader[((int)SaExperienceColumn.Comments - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaExperienceColumn.SaStfMemberId - 1)];
			entity.SaCodeExperienceId = (System.Decimal)reader[((int)SaExperienceColumn.SaCodeExperienceId - 1)];
			entity.GsCountryNodeId = (System.Decimal)reader[((int)SaExperienceColumn.GsCountryNodeId - 1)];
			entity.AsNodeId = (reader.IsDBNull(((int)SaExperienceColumn.AsNodeId - 1)))?null:(System.Decimal?)reader[((int)SaExperienceColumn.AsNodeId - 1)];
			entity.SaCodeOrgId = (reader.IsDBNull(((int)SaExperienceColumn.SaCodeOrgId - 1)))?null:(System.Decimal?)reader[((int)SaExperienceColumn.SaCodeOrgId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaExperienceColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaExperience"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaExperience"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaExperience entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaExperienceId = (System.Decimal)dataRow["SA_EXPERIENCE_ID"];
			entity.OriginalSaExperienceId = (System.Decimal)dataRow["SA_EXPERIENCE_ID"];
			entity.ExpFrom = (System.DateTime)dataRow["EXP_FROM"];
			entity.ExpTo = Convert.IsDBNull(dataRow["EXP_TO"]) ? null : (System.DateTime?)dataRow["EXP_TO"];
			entity.IsOrgUni = (System.Decimal)dataRow["IS_ORG_UNI"];
			entity.Comments = Convert.IsDBNull(dataRow["COMMENTS"]) ? null : (System.String)dataRow["COMMENTS"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.SaCodeExperienceId = (System.Decimal)dataRow["SA_CODE_EXPERIENCE_ID"];
			entity.GsCountryNodeId = (System.Decimal)dataRow["GS_COUNTRY_NODE_ID"];
			entity.AsNodeId = Convert.IsDBNull(dataRow["AS_NODE_ID"]) ? null : (System.Decimal?)dataRow["AS_NODE_ID"];
			entity.SaCodeOrgId = Convert.IsDBNull(dataRow["SA_CODE_ORG_ID"]) ? null : (System.Decimal?)dataRow["SA_CODE_ORG_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaExperience"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaExperience Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaExperience entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaCodeExperienceIdSource	
			if (CanDeepLoad(entity, "SaCodeExperience|SaCodeExperienceIdSource", deepLoadType, innerList) 
				&& entity.SaCodeExperienceIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeExperienceId;
				SaCodeExperience tmpEntity = EntityManager.LocateEntity<SaCodeExperience>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeExperience), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeExperienceIdSource = tmpEntity;
				else
					entity.SaCodeExperienceIdSource = DataRepository.SaCodeExperienceProvider.GetBySaCodeExperienceId(transactionManager, entity.SaCodeExperienceId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeExperienceIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeExperienceIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeExperienceProvider.DeepLoad(transactionManager, entity.SaCodeExperienceIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeExperienceIdSource

			#region SaCodeOrgIdSource	
			if (CanDeepLoad(entity, "SaCodeOrg|SaCodeOrgIdSource", deepLoadType, innerList) 
				&& entity.SaCodeOrgIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaCodeOrgId ?? 0.0m);
				SaCodeOrg tmpEntity = EntityManager.LocateEntity<SaCodeOrg>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeOrg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeOrgIdSource = tmpEntity;
				else
					entity.SaCodeOrgIdSource = DataRepository.SaCodeOrgProvider.GetBySaCodeOrgId(transactionManager, (entity.SaCodeOrgId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeOrgIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeOrgIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeOrgProvider.DeepLoad(transactionManager, entity.SaCodeOrgIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeOrgIdSource

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

			#region AsNodeIdSource	
			if (CanDeepLoad(entity, "EntityMain|AsNodeIdSource", deepLoadType, innerList) 
				&& entity.AsNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsNodeId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsNodeIdSource = tmpEntity;
				else
					entity.AsNodeIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.AsNodeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.AsNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsNodeIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaExperience object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaExperience instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaExperience Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaExperience entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaCodeExperienceIdSource
			if (CanDeepSave(entity, "SaCodeExperience|SaCodeExperienceIdSource", deepSaveType, innerList) 
				&& entity.SaCodeExperienceIdSource != null)
			{
				DataRepository.SaCodeExperienceProvider.Save(transactionManager, entity.SaCodeExperienceIdSource);
				entity.SaCodeExperienceId = entity.SaCodeExperienceIdSource.SaCodeExperienceId;
			}
			#endregion 
			
			#region SaCodeOrgIdSource
			if (CanDeepSave(entity, "SaCodeOrg|SaCodeOrgIdSource", deepSaveType, innerList) 
				&& entity.SaCodeOrgIdSource != null)
			{
				DataRepository.SaCodeOrgProvider.Save(transactionManager, entity.SaCodeOrgIdSource);
				entity.SaCodeOrgId = entity.SaCodeOrgIdSource.SaCodeOrgId;
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
			
			#region AsNodeIdSource
			if (CanDeepSave(entity, "EntityMain|AsNodeIdSource", deepSaveType, innerList) 
				&& entity.AsNodeIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.AsNodeIdSource);
				entity.AsNodeId = entity.AsNodeIdSource.EntMainId;
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
	
	#region SaExperienceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaExperience</c>
	///</summary>
	public enum SaExperienceChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeExperience</c> at SaCodeExperienceIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeExperience))]
		SaCodeExperience,
		
		///<summary>
		/// Composite Property for <c>SaCodeOrg</c> at SaCodeOrgIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeOrg))]
		SaCodeOrg,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at AsNodeIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion SaExperienceChildEntityTypes
	
	#region SaExperienceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaExperienceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaExperience"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaExperienceFilterBuilder : SqlFilterBuilder<SaExperienceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaExperienceFilterBuilder class.
		/// </summary>
		public SaExperienceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaExperienceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaExperienceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaExperienceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaExperienceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaExperienceFilterBuilder
	
	#region SaExperienceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaExperienceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaExperience"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaExperienceParameterBuilder : ParameterizedSqlFilterBuilder<SaExperienceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaExperienceParameterBuilder class.
		/// </summary>
		public SaExperienceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaExperienceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaExperienceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaExperienceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaExperienceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaExperienceParameterBuilder
	
	#region SaExperienceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaExperienceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaExperience"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaExperienceSortBuilder : SqlSortBuilder<SaExperienceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaExperienceSqlSortBuilder class.
		/// </summary>
		public SaExperienceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaExperienceSortBuilder
	
} // end namespace
