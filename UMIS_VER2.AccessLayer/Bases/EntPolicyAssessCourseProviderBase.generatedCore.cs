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
	/// This class is the base class for any <see cref="EntPolicyAssessCourseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyAssessCourseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolicyAssessCourse, UMIS_VER2.BusinessLyer.EntPolicyAssessCourseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAssessCourseKey key)
		{
			return Delete(transactionManager, key.EntPolicyAssessCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolicyAssessCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPolicyAssessCourseId)
		{
			return Delete(null, _entPolicyAssessCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPolicyAssessCourseId);		
		
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
		public override UMIS_VER2.BusinessLyer.EntPolicyAssessCourse Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAssessCourseKey key, int start, int pageLength)
		{
			return GetByEntPolicyAssessCourseId(transactionManager, key.EntPolicyAssessCourseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAssessCourse&gt;"/> class.</returns>
		public TList<EntPolicyAssessCourse> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(null,_edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAssessCourse&gt;"/> class.</returns>
		public TList<EntPolicyAssessCourse> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAssessCourse&gt;"/> class.</returns>
		public TList<EntPolicyAssessCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAssessCourse&gt;"/> class.</returns>
		public TList<EntPolicyAssessCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAssessCourse&gt;"/> class.</returns>
		public TList<EntPolicyAssessCourse> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength, out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAssessCourse&gt;"/> class.</returns>
		public abstract TList<EntPolicyAssessCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_COURSE_PKG_HDR_I_1 index.
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAssessCourse&gt;"/> class.</returns>
		public TList<EntPolicyAssessCourse> GetByEntCoursePkgHdrId(System.Decimal? _entCoursePkgHdrId)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(null,_entCoursePkgHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_COURSE_PKG_HDR_I_1 index.
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAssessCourse&gt;"/> class.</returns>
		public TList<EntPolicyAssessCourse> GetByEntCoursePkgHdrId(System.Decimal? _entCoursePkgHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(null, _entCoursePkgHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_COURSE_PKG_HDR_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAssessCourse&gt;"/> class.</returns>
		public TList<EntPolicyAssessCourse> GetByEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal? _entCoursePkgHdrId)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(transactionManager, _entCoursePkgHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_COURSE_PKG_HDR_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAssessCourse&gt;"/> class.</returns>
		public TList<EntPolicyAssessCourse> GetByEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal? _entCoursePkgHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(transactionManager, _entCoursePkgHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_COURSE_PKG_HDR_I_1 index.
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAssessCourse&gt;"/> class.</returns>
		public TList<EntPolicyAssessCourse> GetByEntCoursePkgHdrId(System.Decimal? _entCoursePkgHdrId, int start, int pageLength, out int count)
		{
			return GetByEntCoursePkgHdrId(null, _entCoursePkgHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_COURSE_PKG_HDR_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAssessCourse&gt;"/> class.</returns>
		public abstract TList<EntPolicyAssessCourse> GetByEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal? _entCoursePkgHdrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_POLICY_ASSESS_HD_1 index.
		/// </summary>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAssessCourse&gt;"/> class.</returns>
		public TList<EntPolicyAssessCourse> GetByEntPolicyAssessHdrId(System.Decimal _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(null,_entPolicyAssessHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_ASSESS_HD_1 index.
		/// </summary>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAssessCourse&gt;"/> class.</returns>
		public TList<EntPolicyAssessCourse> GetByEntPolicyAssessHdrId(System.Decimal _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(null, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_ASSESS_HD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAssessCourse&gt;"/> class.</returns>
		public TList<EntPolicyAssessCourse> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(transactionManager, _entPolicyAssessHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_ASSESS_HD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAssessCourse&gt;"/> class.</returns>
		public TList<EntPolicyAssessCourse> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(transactionManager, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_ASSESS_HD_1 index.
		/// </summary>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAssessCourse&gt;"/> class.</returns>
		public TList<EntPolicyAssessCourse> GetByEntPolicyAssessHdrId(System.Decimal _entPolicyAssessHdrId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyAssessHdrId(null, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_ASSESS_HD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAssessCourse&gt;"/> class.</returns>
		public abstract TList<EntPolicyAssessCourse> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal _entPolicyAssessHdrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_POLICY_ASSESS_COURSE index.
		/// </summary>
		/// <param name="_entPolicyAssessCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessCourse GetByEntPolicyAssessCourseId(System.Decimal _entPolicyAssessCourseId)
		{
			int count = -1;
			return GetByEntPolicyAssessCourseId(null,_entPolicyAssessCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS_COURSE index.
		/// </summary>
		/// <param name="_entPolicyAssessCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessCourse GetByEntPolicyAssessCourseId(System.Decimal _entPolicyAssessCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessCourseId(null, _entPolicyAssessCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessCourse GetByEntPolicyAssessCourseId(TransactionManager transactionManager, System.Decimal _entPolicyAssessCourseId)
		{
			int count = -1;
			return GetByEntPolicyAssessCourseId(transactionManager, _entPolicyAssessCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessCourse GetByEntPolicyAssessCourseId(TransactionManager transactionManager, System.Decimal _entPolicyAssessCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessCourseId(transactionManager, _entPolicyAssessCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS_COURSE index.
		/// </summary>
		/// <param name="_entPolicyAssessCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessCourse GetByEntPolicyAssessCourseId(System.Decimal _entPolicyAssessCourseId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyAssessCourseId(null, _entPolicyAssessCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyAssessCourse GetByEntPolicyAssessCourseId(TransactionManager transactionManager, System.Decimal _entPolicyAssessCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_POLICY_ASSESS_COURSE index.
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessCourse GetByEntCoursePkgHdrIdEdCourseIdEntPolicyAssessHdrId(System.Decimal? _entCoursePkgHdrId, System.Decimal _edCourseId, System.Decimal _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEntCoursePkgHdrIdEdCourseIdEntPolicyAssessHdrId(null,_entCoursePkgHdrId, _edCourseId, _entPolicyAssessHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_COURSE index.
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessCourse GetByEntCoursePkgHdrIdEdCourseIdEntPolicyAssessHdrId(System.Decimal? _entCoursePkgHdrId, System.Decimal _edCourseId, System.Decimal _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgHdrIdEdCourseIdEntPolicyAssessHdrId(null, _entCoursePkgHdrId, _edCourseId, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessCourse GetByEntCoursePkgHdrIdEdCourseIdEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal? _entCoursePkgHdrId, System.Decimal _edCourseId, System.Decimal _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEntCoursePkgHdrIdEdCourseIdEntPolicyAssessHdrId(transactionManager, _entCoursePkgHdrId, _edCourseId, _entPolicyAssessHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessCourse GetByEntCoursePkgHdrIdEdCourseIdEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal? _entCoursePkgHdrId, System.Decimal _edCourseId, System.Decimal _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgHdrIdEdCourseIdEntPolicyAssessHdrId(transactionManager, _entCoursePkgHdrId, _edCourseId, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_COURSE index.
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessCourse GetByEntCoursePkgHdrIdEdCourseIdEntPolicyAssessHdrId(System.Decimal? _entCoursePkgHdrId, System.Decimal _edCourseId, System.Decimal _entPolicyAssessHdrId, int start, int pageLength, out int count)
		{
			return GetByEntCoursePkgHdrIdEdCourseIdEntPolicyAssessHdrId(null, _entCoursePkgHdrId, _edCourseId, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyAssessCourse GetByEntCoursePkgHdrIdEdCourseIdEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal? _entCoursePkgHdrId, System.Decimal _edCourseId, System.Decimal _entPolicyAssessHdrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_POLICY_ASSESS_COURSE_ENT index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessCourse GetByEdCourseIdEntPolicyAssessHdrId(System.Decimal _edCourseId, System.Decimal _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEdCourseIdEntPolicyAssessHdrId(null,_edCourseId, _entPolicyAssessHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_COURSE_ENT index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessCourse GetByEdCourseIdEntPolicyAssessHdrId(System.Decimal _edCourseId, System.Decimal _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseIdEntPolicyAssessHdrId(null, _edCourseId, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_COURSE_ENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessCourse GetByEdCourseIdEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal _edCourseId, System.Decimal _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEdCourseIdEntPolicyAssessHdrId(transactionManager, _edCourseId, _entPolicyAssessHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_COURSE_ENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessCourse GetByEdCourseIdEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal _edCourseId, System.Decimal _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseIdEntPolicyAssessHdrId(transactionManager, _edCourseId, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_COURSE_ENT index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessCourse GetByEdCourseIdEntPolicyAssessHdrId(System.Decimal _edCourseId, System.Decimal _entPolicyAssessHdrId, int start, int pageLength, out int count)
		{
			return GetByEdCourseIdEntPolicyAssessHdrId(null, _edCourseId, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ASSESS_COURSE_ENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyAssessCourse GetByEdCourseIdEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal _edCourseId, System.Decimal _entPolicyAssessHdrId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolicyAssessCourse&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolicyAssessCourse&gt;"/></returns>
		public static TList<EntPolicyAssessCourse> Fill(IDataReader reader, TList<EntPolicyAssessCourse> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolicyAssessCourse c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolicyAssessCourse")
					.Append("|").Append((System.Decimal)reader["ENT_POLICY_ASSESS_COURSE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolicyAssessCourse>(
					key.ToString(), // EntityTrackingKey
					"EntPolicyAssessCourse",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolicyAssessCourse();
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
					c.EntPolicyAssessCourseId = (System.Decimal)reader["ENT_POLICY_ASSESS_COURSE_ID"];
					c.OriginalEntPolicyAssessCourseId = c.EntPolicyAssessCourseId;
					c.EntPolicyAssessHdrId = (System.Decimal)reader["ENT_POLICY_ASSESS_HDR_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.EntCoursePkgHdrId = Convert.IsDBNull(reader["ENT_COURSE_PKG_HDR_ID"]) ? null : (System.Decimal?)reader["ENT_COURSE_PKG_HDR_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolicyAssessCourse entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolicyAssessCourseId = (System.Decimal)reader[((int)EntPolicyAssessCourseColumn.EntPolicyAssessCourseId - 1)];
			entity.OriginalEntPolicyAssessCourseId = (System.Decimal)reader["ENT_POLICY_ASSESS_COURSE_ID"];
			entity.EntPolicyAssessHdrId = (System.Decimal)reader[((int)EntPolicyAssessCourseColumn.EntPolicyAssessHdrId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)EntPolicyAssessCourseColumn.EdCourseId - 1)];
			entity.EntCoursePkgHdrId = (reader.IsDBNull(((int)EntPolicyAssessCourseColumn.EntCoursePkgHdrId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAssessCourseColumn.EntCoursePkgHdrId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolicyAssessCourse entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolicyAssessCourseId = (System.Decimal)dataRow["ENT_POLICY_ASSESS_COURSE_ID"];
			entity.OriginalEntPolicyAssessCourseId = (System.Decimal)dataRow["ENT_POLICY_ASSESS_COURSE_ID"];
			entity.EntPolicyAssessHdrId = (System.Decimal)dataRow["ENT_POLICY_ASSESS_HDR_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.EntCoursePkgHdrId = Convert.IsDBNull(dataRow["ENT_COURSE_PKG_HDR_ID"]) ? null : (System.Decimal?)dataRow["ENT_COURSE_PKG_HDR_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessCourse"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyAssessCourse Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAssessCourse entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseIdSource

			#region EntCoursePkgHdrIdSource	
			if (CanDeepLoad(entity, "EntCoursePkgHdr|EntCoursePkgHdrIdSource", deepLoadType, innerList) 
				&& entity.EntCoursePkgHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntCoursePkgHdrId ?? 0.0m);
				EntCoursePkgHdr tmpEntity = EntityManager.LocateEntity<EntCoursePkgHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCoursePkgHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCoursePkgHdrIdSource = tmpEntity;
				else
					entity.EntCoursePkgHdrIdSource = DataRepository.EntCoursePkgHdrProvider.GetByEntCoursePkgHdrId(transactionManager, (entity.EntCoursePkgHdrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCoursePkgHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCoursePkgHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCoursePkgHdrProvider.DeepLoad(transactionManager, entity.EntCoursePkgHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCoursePkgHdrIdSource

			#region EntPolicyAssessHdrIdSource	
			if (CanDeepLoad(entity, "EntPolicyAssessHdr|EntPolicyAssessHdrIdSource", deepLoadType, innerList) 
				&& entity.EntPolicyAssessHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntPolicyAssessHdrId;
				EntPolicyAssessHdr tmpEntity = EntityManager.LocateEntity<EntPolicyAssessHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EntPolicyAssessHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntPolicyAssessHdrIdSource = tmpEntity;
				else
					entity.EntPolicyAssessHdrIdSource = DataRepository.EntPolicyAssessHdrProvider.GetByEntPolicyAssessHdrId(transactionManager, entity.EntPolicyAssessHdrId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAssessHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntPolicyAssessHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntPolicyAssessHdrProvider.DeepLoad(transactionManager, entity.EntPolicyAssessHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntPolicyAssessHdrIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolicyAssessCourse object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicyAssessCourse instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyAssessCourse Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAssessCourse entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region EntCoursePkgHdrIdSource
			if (CanDeepSave(entity, "EntCoursePkgHdr|EntCoursePkgHdrIdSource", deepSaveType, innerList) 
				&& entity.EntCoursePkgHdrIdSource != null)
			{
				DataRepository.EntCoursePkgHdrProvider.Save(transactionManager, entity.EntCoursePkgHdrIdSource);
				entity.EntCoursePkgHdrId = entity.EntCoursePkgHdrIdSource.EntCoursePkgHdrId;
			}
			#endregion 
			
			#region EntPolicyAssessHdrIdSource
			if (CanDeepSave(entity, "EntPolicyAssessHdr|EntPolicyAssessHdrIdSource", deepSaveType, innerList) 
				&& entity.EntPolicyAssessHdrIdSource != null)
			{
				DataRepository.EntPolicyAssessHdrProvider.Save(transactionManager, entity.EntPolicyAssessHdrIdSource);
				entity.EntPolicyAssessHdrId = entity.EntPolicyAssessHdrIdSource.EntPolicyAssessHdrId;
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
	
	#region EntPolicyAssessCourseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolicyAssessCourse</c>
	///</summary>
	public enum EntPolicyAssessCourseChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EntCoursePkgHdr</c> at EntCoursePkgHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EntCoursePkgHdr))]
		EntCoursePkgHdr,
		
		///<summary>
		/// Composite Property for <c>EntPolicyAssessHdr</c> at EntPolicyAssessHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EntPolicyAssessHdr))]
		EntPolicyAssessHdr,
	}
	
	#endregion EntPolicyAssessCourseChildEntityTypes
	
	#region EntPolicyAssessCourseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolicyAssessCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyAssessCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyAssessCourseFilterBuilder : SqlFilterBuilder<EntPolicyAssessCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessCourseFilterBuilder class.
		/// </summary>
		public EntPolicyAssessCourseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyAssessCourseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyAssessCourseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyAssessCourseFilterBuilder
	
	#region EntPolicyAssessCourseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolicyAssessCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyAssessCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyAssessCourseParameterBuilder : ParameterizedSqlFilterBuilder<EntPolicyAssessCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessCourseParameterBuilder class.
		/// </summary>
		public EntPolicyAssessCourseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyAssessCourseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyAssessCourseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyAssessCourseParameterBuilder
	
	#region EntPolicyAssessCourseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolicyAssessCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyAssessCourse"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolicyAssessCourseSortBuilder : SqlSortBuilder<EntPolicyAssessCourseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessCourseSqlSortBuilder class.
		/// </summary>
		public EntPolicyAssessCourseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolicyAssessCourseSortBuilder
	
} // end namespace
