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
	/// This class is the base class for any <see cref="EdAcadPlanDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdAcadPlanDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdAcadPlanDtl, UMIS_VER2.BusinessLyer.EdAcadPlanDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadPlanDtlKey key)
		{
			return Delete(transactionManager, key.EdAcadPlanDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edAcadPlanDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edAcadPlanDtlId)
		{
			return Delete(null, _edAcadPlanDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edAcadPlanDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ED_ACAD_PLAN_HDR key.
		///		FK_ED_ACAD_PLAN_DTL_ED_ACAD_PLAN_HDR Description: 
		/// </summary>
		/// <param name="_edAcadPlanHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public TList<EdAcadPlanDtl> GetByEdAcadPlanHdrId(System.Decimal _edAcadPlanHdrId)
		{
			int count = -1;
			return GetByEdAcadPlanHdrId(_edAcadPlanHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ED_ACAD_PLAN_HDR key.
		///		FK_ED_ACAD_PLAN_DTL_ED_ACAD_PLAN_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EdAcadPlanDtl> GetByEdAcadPlanHdrId(TransactionManager transactionManager, System.Decimal _edAcadPlanHdrId)
		{
			int count = -1;
			return GetByEdAcadPlanHdrId(transactionManager, _edAcadPlanHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ED_ACAD_PLAN_HDR key.
		///		FK_ED_ACAD_PLAN_DTL_ED_ACAD_PLAN_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public TList<EdAcadPlanDtl> GetByEdAcadPlanHdrId(TransactionManager transactionManager, System.Decimal _edAcadPlanHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadPlanHdrId(transactionManager, _edAcadPlanHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ED_ACAD_PLAN_HDR key.
		///		fkEdAcadPlanDtlEdAcadPlanHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadPlanHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public TList<EdAcadPlanDtl> GetByEdAcadPlanHdrId(System.Decimal _edAcadPlanHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadPlanHdrId(null, _edAcadPlanHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ED_ACAD_PLAN_HDR key.
		///		fkEdAcadPlanDtlEdAcadPlanHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadPlanHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public TList<EdAcadPlanDtl> GetByEdAcadPlanHdrId(System.Decimal _edAcadPlanHdrId, int start, int pageLength,out int count)
		{
			return GetByEdAcadPlanHdrId(null, _edAcadPlanHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ED_ACAD_PLAN_HDR key.
		///		FK_ED_ACAD_PLAN_DTL_ED_ACAD_PLAN_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public abstract TList<EdAcadPlanDtl> GetByEdAcadPlanHdrId(TransactionManager transactionManager, System.Decimal _edAcadPlanHdrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ED_COURSE key.
		///		FK_ED_ACAD_PLAN_DTL_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public TList<EdAcadPlanDtl> GetByEdCourseId(System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ED_COURSE key.
		///		FK_ED_ACAD_PLAN_DTL_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EdAcadPlanDtl> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ED_COURSE key.
		///		FK_ED_ACAD_PLAN_DTL_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public TList<EdAcadPlanDtl> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ED_COURSE key.
		///		fkEdAcadPlanDtlEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public TList<EdAcadPlanDtl> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ED_COURSE key.
		///		fkEdAcadPlanDtlEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public TList<EdAcadPlanDtl> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ED_COURSE key.
		///		FK_ED_ACAD_PLAN_DTL_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public abstract TList<EdAcadPlanDtl> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ED_COURSE_EXP_HDR key.
		///		FK_ED_ACAD_PLAN_DTL_ED_COURSE_EXP_HDR Description: 
		/// </summary>
		/// <param name="_edCourseExpHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public TList<EdAcadPlanDtl> GetByEdCourseExpHdrId(System.Decimal? _edCourseExpHdrId)
		{
			int count = -1;
			return GetByEdCourseExpHdrId(_edCourseExpHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ED_COURSE_EXP_HDR key.
		///		FK_ED_ACAD_PLAN_DTL_ED_COURSE_EXP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EdAcadPlanDtl> GetByEdCourseExpHdrId(TransactionManager transactionManager, System.Decimal? _edCourseExpHdrId)
		{
			int count = -1;
			return GetByEdCourseExpHdrId(transactionManager, _edCourseExpHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ED_COURSE_EXP_HDR key.
		///		FK_ED_ACAD_PLAN_DTL_ED_COURSE_EXP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public TList<EdAcadPlanDtl> GetByEdCourseExpHdrId(TransactionManager transactionManager, System.Decimal? _edCourseExpHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseExpHdrId(transactionManager, _edCourseExpHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ED_COURSE_EXP_HDR key.
		///		fkEdAcadPlanDtlEdCourseExpHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public TList<EdAcadPlanDtl> GetByEdCourseExpHdrId(System.Decimal? _edCourseExpHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseExpHdrId(null, _edCourseExpHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ED_COURSE_EXP_HDR key.
		///		fkEdAcadPlanDtlEdCourseExpHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public TList<EdAcadPlanDtl> GetByEdCourseExpHdrId(System.Decimal? _edCourseExpHdrId, int start, int pageLength,out int count)
		{
			return GetByEdCourseExpHdrId(null, _edCourseExpHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ED_COURSE_EXP_HDR key.
		///		FK_ED_ACAD_PLAN_DTL_ED_COURSE_EXP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public abstract TList<EdAcadPlanDtl> GetByEdCourseExpHdrId(TransactionManager transactionManager, System.Decimal? _edCourseExpHdrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ENT_COURSE_PKG_HDR key.
		///		FK_ED_ACAD_PLAN_DTL_ENT_COURSE_PKG_HDR Description: 
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public TList<EdAcadPlanDtl> GetByEntCoursePkgHdrId(System.Decimal? _entCoursePkgHdrId)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(_entCoursePkgHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ENT_COURSE_PKG_HDR key.
		///		FK_ED_ACAD_PLAN_DTL_ENT_COURSE_PKG_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EdAcadPlanDtl> GetByEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal? _entCoursePkgHdrId)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(transactionManager, _entCoursePkgHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ENT_COURSE_PKG_HDR key.
		///		FK_ED_ACAD_PLAN_DTL_ENT_COURSE_PKG_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public TList<EdAcadPlanDtl> GetByEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal? _entCoursePkgHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(transactionManager, _entCoursePkgHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ENT_COURSE_PKG_HDR key.
		///		fkEdAcadPlanDtlEntCoursePkgHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public TList<EdAcadPlanDtl> GetByEntCoursePkgHdrId(System.Decimal? _entCoursePkgHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntCoursePkgHdrId(null, _entCoursePkgHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ENT_COURSE_PKG_HDR key.
		///		fkEdAcadPlanDtlEntCoursePkgHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public TList<EdAcadPlanDtl> GetByEntCoursePkgHdrId(System.Decimal? _entCoursePkgHdrId, int start, int pageLength,out int count)
		{
			return GetByEntCoursePkgHdrId(null, _entCoursePkgHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_DTL_ENT_COURSE_PKG_HDR key.
		///		FK_ED_ACAD_PLAN_DTL_ENT_COURSE_PKG_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanDtl objects.</returns>
		public abstract TList<EdAcadPlanDtl> GetByEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal? _entCoursePkgHdrId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdAcadPlanDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadPlanDtlKey key, int start, int pageLength)
		{
			return GetByEdAcadPlanDtlId(transactionManager, key.EdAcadPlanDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_ACAD_PLAN_DTL index.
		/// </summary>
		/// <param name="_edAcadPlanDtlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlanDtl GetByEdAcadPlanDtlId(System.Decimal _edAcadPlanDtlId)
		{
			int count = -1;
			return GetByEdAcadPlanDtlId(null,_edAcadPlanDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_PLAN_DTL index.
		/// </summary>
		/// <param name="_edAcadPlanDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlanDtl GetByEdAcadPlanDtlId(System.Decimal _edAcadPlanDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadPlanDtlId(null, _edAcadPlanDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_PLAN_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlanDtl GetByEdAcadPlanDtlId(TransactionManager transactionManager, System.Decimal _edAcadPlanDtlId)
		{
			int count = -1;
			return GetByEdAcadPlanDtlId(transactionManager, _edAcadPlanDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_PLAN_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlanDtl GetByEdAcadPlanDtlId(TransactionManager transactionManager, System.Decimal _edAcadPlanDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadPlanDtlId(transactionManager, _edAcadPlanDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_PLAN_DTL index.
		/// </summary>
		/// <param name="_edAcadPlanDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlanDtl GetByEdAcadPlanDtlId(System.Decimal _edAcadPlanDtlId, int start, int pageLength, out int count)
		{
			return GetByEdAcadPlanDtlId(null, _edAcadPlanDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_PLAN_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdAcadPlanDtl GetByEdAcadPlanDtlId(TransactionManager transactionManager, System.Decimal _edAcadPlanDtlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_ACAD_PLAN_DTL index.
		/// </summary>
		/// <param name="_edAcadPlanHdrId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_crsExp"></param>
		/// <param name="_crsExpNameAr"></param>
		/// <param name="_crsExpNameEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlanDtl GetByEdAcadPlanHdrIdEdCourseIdCrsExpCrsExpNameArCrsExpNameEn(System.Decimal _edAcadPlanHdrId, System.Decimal? _edCourseId, System.String _crsExp, System.String _crsExpNameAr, System.String _crsExpNameEn)
		{
			int count = -1;
			return GetByEdAcadPlanHdrIdEdCourseIdCrsExpCrsExpNameArCrsExpNameEn(null,_edAcadPlanHdrId, _edCourseId, _crsExp, _crsExpNameAr, _crsExpNameEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACAD_PLAN_DTL index.
		/// </summary>
		/// <param name="_edAcadPlanHdrId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_crsExp"></param>
		/// <param name="_crsExpNameAr"></param>
		/// <param name="_crsExpNameEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlanDtl GetByEdAcadPlanHdrIdEdCourseIdCrsExpCrsExpNameArCrsExpNameEn(System.Decimal _edAcadPlanHdrId, System.Decimal? _edCourseId, System.String _crsExp, System.String _crsExpNameAr, System.String _crsExpNameEn, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadPlanHdrIdEdCourseIdCrsExpCrsExpNameArCrsExpNameEn(null, _edAcadPlanHdrId, _edCourseId, _crsExp, _crsExpNameAr, _crsExpNameEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACAD_PLAN_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanHdrId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_crsExp"></param>
		/// <param name="_crsExpNameAr"></param>
		/// <param name="_crsExpNameEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlanDtl GetByEdAcadPlanHdrIdEdCourseIdCrsExpCrsExpNameArCrsExpNameEn(TransactionManager transactionManager, System.Decimal _edAcadPlanHdrId, System.Decimal? _edCourseId, System.String _crsExp, System.String _crsExpNameAr, System.String _crsExpNameEn)
		{
			int count = -1;
			return GetByEdAcadPlanHdrIdEdCourseIdCrsExpCrsExpNameArCrsExpNameEn(transactionManager, _edAcadPlanHdrId, _edCourseId, _crsExp, _crsExpNameAr, _crsExpNameEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACAD_PLAN_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanHdrId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_crsExp"></param>
		/// <param name="_crsExpNameAr"></param>
		/// <param name="_crsExpNameEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlanDtl GetByEdAcadPlanHdrIdEdCourseIdCrsExpCrsExpNameArCrsExpNameEn(TransactionManager transactionManager, System.Decimal _edAcadPlanHdrId, System.Decimal? _edCourseId, System.String _crsExp, System.String _crsExpNameAr, System.String _crsExpNameEn, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadPlanHdrIdEdCourseIdCrsExpCrsExpNameArCrsExpNameEn(transactionManager, _edAcadPlanHdrId, _edCourseId, _crsExp, _crsExpNameAr, _crsExpNameEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACAD_PLAN_DTL index.
		/// </summary>
		/// <param name="_edAcadPlanHdrId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_crsExp"></param>
		/// <param name="_crsExpNameAr"></param>
		/// <param name="_crsExpNameEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlanDtl GetByEdAcadPlanHdrIdEdCourseIdCrsExpCrsExpNameArCrsExpNameEn(System.Decimal _edAcadPlanHdrId, System.Decimal? _edCourseId, System.String _crsExp, System.String _crsExpNameAr, System.String _crsExpNameEn, int start, int pageLength, out int count)
		{
			return GetByEdAcadPlanHdrIdEdCourseIdCrsExpCrsExpNameArCrsExpNameEn(null, _edAcadPlanHdrId, _edCourseId, _crsExp, _crsExpNameAr, _crsExpNameEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACAD_PLAN_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanHdrId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_crsExp"></param>
		/// <param name="_crsExpNameAr"></param>
		/// <param name="_crsExpNameEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdAcadPlanDtl GetByEdAcadPlanHdrIdEdCourseIdCrsExpCrsExpNameArCrsExpNameEn(TransactionManager transactionManager, System.Decimal _edAcadPlanHdrId, System.Decimal? _edCourseId, System.String _crsExp, System.String _crsExpNameAr, System.String _crsExpNameEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdAcadPlanDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdAcadPlanDtl&gt;"/></returns>
		public static TList<EdAcadPlanDtl> Fill(IDataReader reader, TList<EdAcadPlanDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdAcadPlanDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdAcadPlanDtl")
					.Append("|").Append((System.Decimal)reader["ED_ACAD_PLAN_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdAcadPlanDtl>(
					key.ToString(), // EntityTrackingKey
					"EdAcadPlanDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdAcadPlanDtl();
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
					c.EdAcadPlanDtlId = (System.Decimal)reader["ED_ACAD_PLAN_DTL_ID"];
					c.OriginalEdAcadPlanDtlId = c.EdAcadPlanDtlId;
					c.EdAcadPlanHdrId = (System.Decimal)reader["ED_ACAD_PLAN_HDR_ID"];
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.CrsExpFlg = Convert.IsDBNull(reader["CRS_EXP_FLG"]) ? null : (System.Decimal?)reader["CRS_EXP_FLG"];
					c.CrsExp = Convert.IsDBNull(reader["CRS_EXP"]) ? null : (System.String)reader["CRS_EXP"];
					c.CrsExpNameAr = Convert.IsDBNull(reader["CRS_EXP_NAME_AR"]) ? null : (System.String)reader["CRS_EXP_NAME_AR"];
					c.CrsExpNameEn = Convert.IsDBNull(reader["CRS_EXP_NAME_EN"]) ? null : (System.String)reader["CRS_EXP_NAME_EN"];
					c.EdCourseExpHdrId = Convert.IsDBNull(reader["ED_COURSE_EXP_HDR_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_EXP_HDR_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.CreditHours = Convert.IsDBNull(reader["CREDIT_HOURS"]) ? null : (System.Decimal?)reader["CREDIT_HOURS"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdAcadPlanDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.EdAcadPlanDtlId = (System.Decimal)reader[((int)EdAcadPlanDtlColumn.EdAcadPlanDtlId - 1)];
			entity.OriginalEdAcadPlanDtlId = (System.Decimal)reader["ED_ACAD_PLAN_DTL_ID"];
			entity.EdAcadPlanHdrId = (System.Decimal)reader[((int)EdAcadPlanDtlColumn.EdAcadPlanHdrId - 1)];
			entity.EdCourseId = (reader.IsDBNull(((int)EdAcadPlanDtlColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)EdAcadPlanDtlColumn.EdCourseId - 1)];
			entity.CrsExpFlg = (reader.IsDBNull(((int)EdAcadPlanDtlColumn.CrsExpFlg - 1)))?null:(System.Decimal?)reader[((int)EdAcadPlanDtlColumn.CrsExpFlg - 1)];
			entity.CrsExp = (reader.IsDBNull(((int)EdAcadPlanDtlColumn.CrsExp - 1)))?null:(System.String)reader[((int)EdAcadPlanDtlColumn.CrsExp - 1)];
			entity.CrsExpNameAr = (reader.IsDBNull(((int)EdAcadPlanDtlColumn.CrsExpNameAr - 1)))?null:(System.String)reader[((int)EdAcadPlanDtlColumn.CrsExpNameAr - 1)];
			entity.CrsExpNameEn = (reader.IsDBNull(((int)EdAcadPlanDtlColumn.CrsExpNameEn - 1)))?null:(System.String)reader[((int)EdAcadPlanDtlColumn.CrsExpNameEn - 1)];
			entity.EdCourseExpHdrId = (reader.IsDBNull(((int)EdAcadPlanDtlColumn.EdCourseExpHdrId - 1)))?null:(System.Decimal?)reader[((int)EdAcadPlanDtlColumn.EdCourseExpHdrId - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdAcadPlanDtlColumn.Notes - 1)))?null:(System.String)reader[((int)EdAcadPlanDtlColumn.Notes - 1)];
			entity.CreditHours = (reader.IsDBNull(((int)EdAcadPlanDtlColumn.CreditHours - 1)))?null:(System.Decimal?)reader[((int)EdAcadPlanDtlColumn.CreditHours - 1)];
			entity.EntCoursePkgHdrId = (reader.IsDBNull(((int)EdAcadPlanDtlColumn.EntCoursePkgHdrId - 1)))?null:(System.Decimal?)reader[((int)EdAcadPlanDtlColumn.EntCoursePkgHdrId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdAcadPlanDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdAcadPlanDtlId = (System.Decimal)dataRow["ED_ACAD_PLAN_DTL_ID"];
			entity.OriginalEdAcadPlanDtlId = (System.Decimal)dataRow["ED_ACAD_PLAN_DTL_ID"];
			entity.EdAcadPlanHdrId = (System.Decimal)dataRow["ED_ACAD_PLAN_HDR_ID"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.CrsExpFlg = Convert.IsDBNull(dataRow["CRS_EXP_FLG"]) ? null : (System.Decimal?)dataRow["CRS_EXP_FLG"];
			entity.CrsExp = Convert.IsDBNull(dataRow["CRS_EXP"]) ? null : (System.String)dataRow["CRS_EXP"];
			entity.CrsExpNameAr = Convert.IsDBNull(dataRow["CRS_EXP_NAME_AR"]) ? null : (System.String)dataRow["CRS_EXP_NAME_AR"];
			entity.CrsExpNameEn = Convert.IsDBNull(dataRow["CRS_EXP_NAME_EN"]) ? null : (System.String)dataRow["CRS_EXP_NAME_EN"];
			entity.EdCourseExpHdrId = Convert.IsDBNull(dataRow["ED_COURSE_EXP_HDR_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_EXP_HDR_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.CreditHours = Convert.IsDBNull(dataRow["CREDIT_HOURS"]) ? null : (System.Decimal?)dataRow["CREDIT_HOURS"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdAcadPlanDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadPlanDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadPlanHdrIdSource	
			if (CanDeepLoad(entity, "EdAcadPlanHdr|EdAcadPlanHdrIdSource", deepLoadType, innerList) 
				&& entity.EdAcadPlanHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdAcadPlanHdrId;
				EdAcadPlanHdr tmpEntity = EntityManager.LocateEntity<EdAcadPlanHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadPlanHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadPlanHdrIdSource = tmpEntity;
				else
					entity.EdAcadPlanHdrIdSource = DataRepository.EdAcadPlanHdrProvider.GetByEdAcadPlanHdrId(transactionManager, entity.EdAcadPlanHdrId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadPlanHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadPlanHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadPlanHdrProvider.DeepLoad(transactionManager, entity.EdAcadPlanHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadPlanHdrIdSource

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCourseId ?? 0.0m);
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, (entity.EdCourseId ?? 0.0m));		
				
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

			#region EdCourseExpHdrIdSource	
			if (CanDeepLoad(entity, "EdCourseExpHdr|EdCourseExpHdrIdSource", deepLoadType, innerList) 
				&& entity.EdCourseExpHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCourseExpHdrId ?? 0.0m);
				EdCourseExpHdr tmpEntity = EntityManager.LocateEntity<EdCourseExpHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourseExpHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseExpHdrIdSource = tmpEntity;
				else
					entity.EdCourseExpHdrIdSource = DataRepository.EdCourseExpHdrProvider.GetByEdCourseExpHdrId(transactionManager, (entity.EdCourseExpHdrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseExpHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseExpHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseExpHdrProvider.DeepLoad(transactionManager, entity.EdCourseExpHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseExpHdrIdSource

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdAcadPlanDtlId methods when available
			
			#region EdStudCourseRegCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegCollection = DataRepository.EdStudCourseRegProvider.GetByEdAcadPlanDtlId(transactionManager, entity.EdAcadPlanDtlId);

				if (deep && entity.EdStudCourseRegCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseReg>) DataRepository.EdStudCourseRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdAcadPlanDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdAcadPlanDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdAcadPlanDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadPlanDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdAcadPlanHdrIdSource
			if (CanDeepSave(entity, "EdAcadPlanHdr|EdAcadPlanHdrIdSource", deepSaveType, innerList) 
				&& entity.EdAcadPlanHdrIdSource != null)
			{
				DataRepository.EdAcadPlanHdrProvider.Save(transactionManager, entity.EdAcadPlanHdrIdSource);
				entity.EdAcadPlanHdrId = entity.EdAcadPlanHdrIdSource.EdAcadPlanHdrId;
			}
			#endregion 
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region EdCourseExpHdrIdSource
			if (CanDeepSave(entity, "EdCourseExpHdr|EdCourseExpHdrIdSource", deepSaveType, innerList) 
				&& entity.EdCourseExpHdrIdSource != null)
			{
				DataRepository.EdCourseExpHdrProvider.Save(transactionManager, entity.EdCourseExpHdrIdSource);
				entity.EdCourseExpHdrId = entity.EdCourseExpHdrIdSource.EdCourseExpHdrId;
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStudCourseReg>
				if (CanDeepSave(entity.EdStudCourseRegCollection, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseReg child in entity.EdStudCourseRegCollection)
					{
						if(child.EdAcadPlanDtlIdSource != null)
						{
							child.EdAcadPlanDtlId = child.EdAcadPlanDtlIdSource.EdAcadPlanDtlId;
						}
						else
						{
							child.EdAcadPlanDtlId = entity.EdAcadPlanDtlId;
						}

					}

					if (entity.EdStudCourseRegCollection.Count > 0 || entity.EdStudCourseRegCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegCollection);
						
						deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseReg >) DataRepository.EdStudCourseRegProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdAcadPlanDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdAcadPlanDtl</c>
	///</summary>
	public enum EdAcadPlanDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadPlanHdr</c> at EdAcadPlanHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadPlanHdr))]
		EdAcadPlanHdr,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EdCourseExpHdr</c> at EdCourseExpHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourseExpHdr))]
		EdCourseExpHdr,
		
		///<summary>
		/// Composite Property for <c>EntCoursePkgHdr</c> at EntCoursePkgHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EntCoursePkgHdr))]
		EntCoursePkgHdr,
		///<summary>
		/// Collection of <c>EdAcadPlanDtl</c> as OneToMany for EdStudCourseRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseReg>))]
		EdStudCourseRegCollection,
	}
	
	#endregion EdAcadPlanDtlChildEntityTypes
	
	#region EdAcadPlanDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdAcadPlanDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdAcadPlanDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdAcadPlanDtlFilterBuilder : SqlFilterBuilder<EdAcadPlanDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanDtlFilterBuilder class.
		/// </summary>
		public EdAcadPlanDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdAcadPlanDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdAcadPlanDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdAcadPlanDtlFilterBuilder
	
	#region EdAcadPlanDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdAcadPlanDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdAcadPlanDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdAcadPlanDtlParameterBuilder : ParameterizedSqlFilterBuilder<EdAcadPlanDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanDtlParameterBuilder class.
		/// </summary>
		public EdAcadPlanDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdAcadPlanDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdAcadPlanDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdAcadPlanDtlParameterBuilder
	
	#region EdAcadPlanDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdAcadPlanDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdAcadPlanDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdAcadPlanDtlSortBuilder : SqlSortBuilder<EdAcadPlanDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanDtlSqlSortBuilder class.
		/// </summary>
		public EdAcadPlanDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdAcadPlanDtlSortBuilder
	
} // end namespace
