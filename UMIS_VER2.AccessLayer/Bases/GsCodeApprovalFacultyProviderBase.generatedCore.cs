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
	/// This class is the base class for any <see cref="GsCodeApprovalFacultyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeApprovalFacultyProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty, UMIS_VER2.BusinessLyer.GsCodeApprovalFacultyKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApprovalFacultyKey key)
		{
			return Delete(transactionManager, key.GsCodeApprovalFaculty);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeApprovalFaculty">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeApprovalFaculty)
		{
			return Delete(null, _gsCodeApprovalFaculty);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalFaculty">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeApprovalFaculty);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0011 key.
		///		FK_AUTO_0011 Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId">NULL:Univ</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty objects.</returns>
		public TList<GsCodeApprovalFaculty> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0011 key.
		///		FK_AUTO_0011 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">NULL:Univ</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty objects.</returns>
		/// <remarks></remarks>
		public TList<GsCodeApprovalFaculty> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0011 key.
		///		FK_AUTO_0011 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">NULL:Univ</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty objects.</returns>
		public TList<GsCodeApprovalFaculty> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0011 key.
		///		fkAuto0011 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">NULL:Univ</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty objects.</returns>
		public TList<GsCodeApprovalFaculty> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0011 key.
		///		fkAuto0011 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">NULL:Univ</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty objects.</returns>
		public TList<GsCodeApprovalFaculty> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0011 key.
		///		FK_AUTO_0011 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">NULL:Univ</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty objects.</returns>
		public abstract TList<GsCodeApprovalFaculty> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_APPROVAL_FACULTY_GS_CODE_APPROVAL key.
		///		FK_GS_CODE_APPROVAL_FACULTY_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="_gsCodeApprovalId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty objects.</returns>
		public TList<GsCodeApprovalFaculty> GetByGsCodeApprovalId(System.Decimal _gsCodeApprovalId)
		{
			int count = -1;
			return GetByGsCodeApprovalId(_gsCodeApprovalId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_APPROVAL_FACULTY_GS_CODE_APPROVAL key.
		///		FK_GS_CODE_APPROVAL_FACULTY_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty objects.</returns>
		/// <remarks></remarks>
		public TList<GsCodeApprovalFaculty> GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId)
		{
			int count = -1;
			return GetByGsCodeApprovalId(transactionManager, _gsCodeApprovalId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_APPROVAL_FACULTY_GS_CODE_APPROVAL key.
		///		FK_GS_CODE_APPROVAL_FACULTY_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty objects.</returns>
		public TList<GsCodeApprovalFaculty> GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalId(transactionManager, _gsCodeApprovalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_APPROVAL_FACULTY_GS_CODE_APPROVAL key.
		///		fkGsCodeApprovalFacultyGsCodeApproval Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty objects.</returns>
		public TList<GsCodeApprovalFaculty> GetByGsCodeApprovalId(System.Decimal _gsCodeApprovalId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeApprovalId(null, _gsCodeApprovalId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_APPROVAL_FACULTY_GS_CODE_APPROVAL key.
		///		fkGsCodeApprovalFacultyGsCodeApproval Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty objects.</returns>
		public TList<GsCodeApprovalFaculty> GetByGsCodeApprovalId(System.Decimal _gsCodeApprovalId, int start, int pageLength,out int count)
		{
			return GetByGsCodeApprovalId(null, _gsCodeApprovalId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CODE_APPROVAL_FACULTY_GS_CODE_APPROVAL key.
		///		FK_GS_CODE_APPROVAL_FACULTY_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty objects.</returns>
		public abstract TList<GsCodeApprovalFaculty> GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApprovalFacultyKey key, int start, int pageLength)
		{
			return GetByGsCodeApprovalFaculty(transactionManager, key.GsCodeApprovalFaculty, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_APPROVAL_FUN_1 index.
		/// </summary>
		/// <param name="_gsCodeApprovalFuncId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalFaculty&gt;"/> class.</returns>
		public TList<GsCodeApprovalFaculty> GetByGsCodeApprovalFuncId(System.Decimal _gsCodeApprovalFuncId)
		{
			int count = -1;
			return GetByGsCodeApprovalFuncId(null,_gsCodeApprovalFuncId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_FUN_1 index.
		/// </summary>
		/// <param name="_gsCodeApprovalFuncId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalFaculty&gt;"/> class.</returns>
		public TList<GsCodeApprovalFaculty> GetByGsCodeApprovalFuncId(System.Decimal _gsCodeApprovalFuncId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalFuncId(null, _gsCodeApprovalFuncId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_FUN_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalFuncId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalFaculty&gt;"/> class.</returns>
		public TList<GsCodeApprovalFaculty> GetByGsCodeApprovalFuncId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalFuncId)
		{
			int count = -1;
			return GetByGsCodeApprovalFuncId(transactionManager, _gsCodeApprovalFuncId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_FUN_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalFuncId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalFaculty&gt;"/> class.</returns>
		public TList<GsCodeApprovalFaculty> GetByGsCodeApprovalFuncId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalFuncId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalFuncId(transactionManager, _gsCodeApprovalFuncId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_FUN_1 index.
		/// </summary>
		/// <param name="_gsCodeApprovalFuncId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalFaculty&gt;"/> class.</returns>
		public TList<GsCodeApprovalFaculty> GetByGsCodeApprovalFuncId(System.Decimal _gsCodeApprovalFuncId, int start, int pageLength, out int count)
		{
			return GetByGsCodeApprovalFuncId(null, _gsCodeApprovalFuncId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_FUN_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalFuncId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalFaculty&gt;"/> class.</returns>
		public abstract TList<GsCodeApprovalFaculty> GetByGsCodeApprovalFuncId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalFuncId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_APPROVAL_LIS_1 index.
		/// </summary>
		/// <param name="_gsCodeApprovalListHId">XXXX</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalFaculty&gt;"/> class.</returns>
		public TList<GsCodeApprovalFaculty> GetByGsCodeApprovalListHId(System.Decimal? _gsCodeApprovalListHId)
		{
			int count = -1;
			return GetByGsCodeApprovalListHId(null,_gsCodeApprovalListHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_LIS_1 index.
		/// </summary>
		/// <param name="_gsCodeApprovalListHId">XXXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalFaculty&gt;"/> class.</returns>
		public TList<GsCodeApprovalFaculty> GetByGsCodeApprovalListHId(System.Decimal? _gsCodeApprovalListHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalListHId(null, _gsCodeApprovalListHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_LIS_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalListHId">XXXX</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalFaculty&gt;"/> class.</returns>
		public TList<GsCodeApprovalFaculty> GetByGsCodeApprovalListHId(TransactionManager transactionManager, System.Decimal? _gsCodeApprovalListHId)
		{
			int count = -1;
			return GetByGsCodeApprovalListHId(transactionManager, _gsCodeApprovalListHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_LIS_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalListHId">XXXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalFaculty&gt;"/> class.</returns>
		public TList<GsCodeApprovalFaculty> GetByGsCodeApprovalListHId(TransactionManager transactionManager, System.Decimal? _gsCodeApprovalListHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalListHId(transactionManager, _gsCodeApprovalListHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_LIS_1 index.
		/// </summary>
		/// <param name="_gsCodeApprovalListHId">XXXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalFaculty&gt;"/> class.</returns>
		public TList<GsCodeApprovalFaculty> GetByGsCodeApprovalListHId(System.Decimal? _gsCodeApprovalListHId, int start, int pageLength, out int count)
		{
			return GetByGsCodeApprovalListHId(null, _gsCodeApprovalListHId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_LIS_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalListHId">XXXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalFaculty&gt;"/> class.</returns>
		public abstract TList<GsCodeApprovalFaculty> GetByGsCodeApprovalListHId(TransactionManager transactionManager, System.Decimal? _gsCodeApprovalListHId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_APPROVAL_FACULTY index.
		/// </summary>
		/// <param name="_gsCodeApprovalFaculty"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty GetByGsCodeApprovalFaculty(System.Decimal _gsCodeApprovalFaculty)
		{
			int count = -1;
			return GetByGsCodeApprovalFaculty(null,_gsCodeApprovalFaculty, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_FACULTY index.
		/// </summary>
		/// <param name="_gsCodeApprovalFaculty"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty GetByGsCodeApprovalFaculty(System.Decimal _gsCodeApprovalFaculty, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalFaculty(null, _gsCodeApprovalFaculty, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_FACULTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalFaculty"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty GetByGsCodeApprovalFaculty(TransactionManager transactionManager, System.Decimal _gsCodeApprovalFaculty)
		{
			int count = -1;
			return GetByGsCodeApprovalFaculty(transactionManager, _gsCodeApprovalFaculty, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_FACULTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalFaculty"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty GetByGsCodeApprovalFaculty(TransactionManager transactionManager, System.Decimal _gsCodeApprovalFaculty, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalFaculty(transactionManager, _gsCodeApprovalFaculty, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_FACULTY index.
		/// </summary>
		/// <param name="_gsCodeApprovalFaculty"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty GetByGsCodeApprovalFaculty(System.Decimal _gsCodeApprovalFaculty, int start, int pageLength, out int count)
		{
			return GetByGsCodeApprovalFaculty(null, _gsCodeApprovalFaculty, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_FACULTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalFaculty"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty GetByGsCodeApprovalFaculty(TransactionManager transactionManager, System.Decimal _gsCodeApprovalFaculty, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeApprovalFaculty&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeApprovalFaculty&gt;"/></returns>
		public static TList<GsCodeApprovalFaculty> Fill(IDataReader reader, TList<GsCodeApprovalFaculty> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeApprovalFaculty")
					.Append("|").Append((System.Decimal)reader["GS_CODE_APPROVAL_FACULTY"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeApprovalFaculty>(
					key.ToString(), // EntityTrackingKey
					"GsCodeApprovalFaculty",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty();
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
					c.GsCodeApprovalFaculty = (System.Decimal)reader["GS_CODE_APPROVAL_FACULTY"];
					c.OriginalGsCodeApprovalFaculty = c.GsCodeApprovalFaculty;
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.GsCodeApprovalFuncId = (System.Decimal)reader["GS_CODE_APPROVAL_FUNC_ID"];
					c.GsCodeApprovalListHId = Convert.IsDBNull(reader["GS_CODE_APPROVAL_LIST_H_ID"]) ? null : (System.Decimal?)reader["GS_CODE_APPROVAL_LIST_H_ID"];
					c.GsCodeApprovalId = (System.Decimal)reader["GS_CODE_APPROVAL_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeApprovalFaculty = (System.Decimal)reader[((int)GsCodeApprovalFacultyColumn.GsCodeApprovalFaculty - 1)];
			entity.OriginalGsCodeApprovalFaculty = (System.Decimal)reader["GS_CODE_APPROVAL_FACULTY"];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)GsCodeApprovalFacultyColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)GsCodeApprovalFacultyColumn.AsFacultyInfoId - 1)];
			entity.GsCodeApprovalFuncId = (System.Decimal)reader[((int)GsCodeApprovalFacultyColumn.GsCodeApprovalFuncId - 1)];
			entity.GsCodeApprovalListHId = (reader.IsDBNull(((int)GsCodeApprovalFacultyColumn.GsCodeApprovalListHId - 1)))?null:(System.Decimal?)reader[((int)GsCodeApprovalFacultyColumn.GsCodeApprovalListHId - 1)];
			entity.GsCodeApprovalId = (System.Decimal)reader[((int)GsCodeApprovalFacultyColumn.GsCodeApprovalId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeApprovalFaculty = (System.Decimal)dataRow["GS_CODE_APPROVAL_FACULTY"];
			entity.OriginalGsCodeApprovalFaculty = (System.Decimal)dataRow["GS_CODE_APPROVAL_FACULTY"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.GsCodeApprovalFuncId = (System.Decimal)dataRow["GS_CODE_APPROVAL_FUNC_ID"];
			entity.GsCodeApprovalListHId = Convert.IsDBNull(dataRow["GS_CODE_APPROVAL_LIST_H_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_APPROVAL_LIST_H_ID"];
			entity.GsCodeApprovalId = (System.Decimal)dataRow["GS_CODE_APPROVAL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsFacultyInfoId ?? 0.0m);
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, (entity.AsFacultyInfoId ?? 0.0m));		
				
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

			#region GsCodeApprovalIdSource	
			if (CanDeepLoad(entity, "GsCodeApproval|GsCodeApprovalIdSource", deepLoadType, innerList) 
				&& entity.GsCodeApprovalIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeApprovalId;
				GsCodeApproval tmpEntity = EntityManager.LocateEntity<GsCodeApproval>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeApproval), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeApprovalIdSource = tmpEntity;
				else
					entity.GsCodeApprovalIdSource = DataRepository.GsCodeApprovalProvider.GetByGsCodeApprovalId(transactionManager, entity.GsCodeApprovalId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeApprovalIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeApprovalProvider.DeepLoad(transactionManager, entity.GsCodeApprovalIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeApprovalIdSource

			#region GsCodeApprovalFuncIdSource	
			if (CanDeepLoad(entity, "GsCodeApprovalFunc|GsCodeApprovalFuncIdSource", deepLoadType, innerList) 
				&& entity.GsCodeApprovalFuncIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeApprovalFuncId;
				GsCodeApprovalFunc tmpEntity = EntityManager.LocateEntity<GsCodeApprovalFunc>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeApprovalFunc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeApprovalFuncIdSource = tmpEntity;
				else
					entity.GsCodeApprovalFuncIdSource = DataRepository.GsCodeApprovalFuncProvider.GetByGsCodeApprovalFuncId(transactionManager, entity.GsCodeApprovalFuncId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalFuncIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeApprovalFuncIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeApprovalFuncProvider.DeepLoad(transactionManager, entity.GsCodeApprovalFuncIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeApprovalFuncIdSource

			#region GsCodeApprovalListHIdSource	
			if (CanDeepLoad(entity, "GsCodeApprovalListH|GsCodeApprovalListHIdSource", deepLoadType, innerList) 
				&& entity.GsCodeApprovalListHIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeApprovalListHId ?? 0.0m);
				GsCodeApprovalListH tmpEntity = EntityManager.LocateEntity<GsCodeApprovalListH>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeApprovalListH), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeApprovalListHIdSource = tmpEntity;
				else
					entity.GsCodeApprovalListHIdSource = DataRepository.GsCodeApprovalListHProvider.GetByGsCodeApprovalListHId(transactionManager, (entity.GsCodeApprovalListHId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalListHIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeApprovalListHIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeApprovalListHProvider.DeepLoad(transactionManager, entity.GsCodeApprovalListHIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeApprovalListHIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region GsCodeApprovalIdSource
			if (CanDeepSave(entity, "GsCodeApproval|GsCodeApprovalIdSource", deepSaveType, innerList) 
				&& entity.GsCodeApprovalIdSource != null)
			{
				DataRepository.GsCodeApprovalProvider.Save(transactionManager, entity.GsCodeApprovalIdSource);
				entity.GsCodeApprovalId = entity.GsCodeApprovalIdSource.GsCodeApprovalId;
			}
			#endregion 
			
			#region GsCodeApprovalFuncIdSource
			if (CanDeepSave(entity, "GsCodeApprovalFunc|GsCodeApprovalFuncIdSource", deepSaveType, innerList) 
				&& entity.GsCodeApprovalFuncIdSource != null)
			{
				DataRepository.GsCodeApprovalFuncProvider.Save(transactionManager, entity.GsCodeApprovalFuncIdSource);
				entity.GsCodeApprovalFuncId = entity.GsCodeApprovalFuncIdSource.GsCodeApprovalFuncId;
			}
			#endregion 
			
			#region GsCodeApprovalListHIdSource
			if (CanDeepSave(entity, "GsCodeApprovalListH|GsCodeApprovalListHIdSource", deepSaveType, innerList) 
				&& entity.GsCodeApprovalListHIdSource != null)
			{
				DataRepository.GsCodeApprovalListHProvider.Save(transactionManager, entity.GsCodeApprovalListHIdSource);
				entity.GsCodeApprovalListHId = entity.GsCodeApprovalListHIdSource.GsCodeApprovalListHId;
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
	
	#region GsCodeApprovalFacultyChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeApprovalFaculty</c>
	///</summary>
	public enum GsCodeApprovalFacultyChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>GsCodeApproval</c> at GsCodeApprovalIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeApproval))]
		GsCodeApproval,
		
		///<summary>
		/// Composite Property for <c>GsCodeApprovalFunc</c> at GsCodeApprovalFuncIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeApprovalFunc))]
		GsCodeApprovalFunc,
		
		///<summary>
		/// Composite Property for <c>GsCodeApprovalListH</c> at GsCodeApprovalListHIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeApprovalListH))]
		GsCodeApprovalListH,
	}
	
	#endregion GsCodeApprovalFacultyChildEntityTypes
	
	#region GsCodeApprovalFacultyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeApprovalFacultyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeApprovalFaculty"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeApprovalFacultyFilterBuilder : SqlFilterBuilder<GsCodeApprovalFacultyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalFacultyFilterBuilder class.
		/// </summary>
		public GsCodeApprovalFacultyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalFacultyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeApprovalFacultyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalFacultyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeApprovalFacultyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeApprovalFacultyFilterBuilder
	
	#region GsCodeApprovalFacultyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeApprovalFacultyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeApprovalFaculty"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeApprovalFacultyParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeApprovalFacultyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalFacultyParameterBuilder class.
		/// </summary>
		public GsCodeApprovalFacultyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalFacultyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeApprovalFacultyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalFacultyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeApprovalFacultyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeApprovalFacultyParameterBuilder
	
	#region GsCodeApprovalFacultySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeApprovalFacultyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeApprovalFaculty"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeApprovalFacultySortBuilder : SqlSortBuilder<GsCodeApprovalFacultyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalFacultySqlSortBuilder class.
		/// </summary>
		public GsCodeApprovalFacultySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeApprovalFacultySortBuilder
	
} // end namespace
