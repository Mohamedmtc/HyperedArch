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
	/// This class is the base class for any <see cref="EdStudExecuseReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudExecuseReqProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudExecuseReq, UMIS_VER2.BusinessLyer.EdStudExecuseReqKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExecuseReqKey key)
		{
			return Delete(transactionManager, key.EdStudExecuseReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudExecuseReqId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudExecuseReqId)
		{
			return Delete(null, _edStudExecuseReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExecuseReqId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudExecuseReqId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_ACAD_YEAR key.
		///		FK_ED_STUD_EXECUSE_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_ACAD_YEAR key.
		///		FK_ED_STUD_EXECUSE_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudExecuseReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_ACAD_YEAR key.
		///		FK_ED_STUD_EXECUSE_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_ACAD_YEAR key.
		///		fkEdStudExecuseReqEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_ACAD_YEAR key.
		///		fkEdStudExecuseReqEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_ACAD_YEAR key.
		///		FK_ED_STUD_EXECUSE_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public abstract TList<EdStudExecuseReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_CDE_EXECUSE_RSN key.
		///		FK_ED_STUD_EXECUSE_REQ_ED_CDE_EXECUSE_RSN Description: 
		/// </summary>
		/// <param name="_edCdeExecuseRsnId">سبب غياب عن حضور جدول اكاديمى- تدريب فى حالة بعذر فقط</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByEdCdeExecuseRsnId(System.Int32 _edCdeExecuseRsnId)
		{
			int count = -1;
			return GetByEdCdeExecuseRsnId(_edCdeExecuseRsnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_CDE_EXECUSE_RSN key.
		///		FK_ED_STUD_EXECUSE_REQ_ED_CDE_EXECUSE_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExecuseRsnId">سبب غياب عن حضور جدول اكاديمى- تدريب فى حالة بعذر فقط</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudExecuseReq> GetByEdCdeExecuseRsnId(TransactionManager transactionManager, System.Int32 _edCdeExecuseRsnId)
		{
			int count = -1;
			return GetByEdCdeExecuseRsnId(transactionManager, _edCdeExecuseRsnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_CDE_EXECUSE_RSN key.
		///		FK_ED_STUD_EXECUSE_REQ_ED_CDE_EXECUSE_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExecuseRsnId">سبب غياب عن حضور جدول اكاديمى- تدريب فى حالة بعذر فقط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByEdCdeExecuseRsnId(TransactionManager transactionManager, System.Int32 _edCdeExecuseRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExecuseRsnId(transactionManager, _edCdeExecuseRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_CDE_EXECUSE_RSN key.
		///		fkEdStudExecuseReqEdCdeExecuseRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExecuseRsnId">سبب غياب عن حضور جدول اكاديمى- تدريب فى حالة بعذر فقط</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByEdCdeExecuseRsnId(System.Int32 _edCdeExecuseRsnId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeExecuseRsnId(null, _edCdeExecuseRsnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_CDE_EXECUSE_RSN key.
		///		fkEdStudExecuseReqEdCdeExecuseRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExecuseRsnId">سبب غياب عن حضور جدول اكاديمى- تدريب فى حالة بعذر فقط</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByEdCdeExecuseRsnId(System.Int32 _edCdeExecuseRsnId, int start, int pageLength,out int count)
		{
			return GetByEdCdeExecuseRsnId(null, _edCdeExecuseRsnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_CDE_EXECUSE_RSN key.
		///		FK_ED_STUD_EXECUSE_REQ_ED_CDE_EXECUSE_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExecuseRsnId">سبب غياب عن حضور جدول اكاديمى- تدريب فى حالة بعذر فقط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public abstract TList<EdStudExecuseReq> GetByEdCdeExecuseRsnId(TransactionManager transactionManager, System.Int32 _edCdeExecuseRsnId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_EXECUSE_REQ_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_EXECUSE_REQ_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudExecuseReq> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_EXECUSE_REQ_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_CODE_SEMESTER key.
		///		fkEdStudExecuseReqEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_CODE_SEMESTER key.
		///		fkEdStudExecuseReqEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_EXECUSE_REQ_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public abstract TList<EdStudExecuseReq> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_STUD key.
		///		FK_ED_STUD_EXECUSE_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_STUD key.
		///		FK_ED_STUD_EXECUSE_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudExecuseReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_STUD key.
		///		FK_ED_STUD_EXECUSE_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_STUD key.
		///		fkEdStudExecuseReqEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_STUD key.
		///		fkEdStudExecuseReqEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_ED_STUD key.
		///		FK_ED_STUD_EXECUSE_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public abstract TList<EdStudExecuseReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ED_STUD_EXECUSE_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(_gsCodeReqStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ED_STUD_EXECUSE_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudExecuseReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ED_STUD_EXECUSE_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_GS_CODE_REQ_STATUS key.
		///		fkEdStudExecuseReqGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_GS_CODE_REQ_STATUS key.
		///		fkEdStudExecuseReqGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public TList<EdStudExecuseReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength,out int count)
		{
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXECUSE_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ED_STUD_EXECUSE_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExecuseReq objects.</returns>
		public abstract TList<EdStudExecuseReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudExecuseReq Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExecuseReqKey key, int start, int pageLength)
		{
			return GetByEdStudExecuseReqId(transactionManager, key.EdStudExecuseReqId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_EXECUSE_REQ index.
		/// </summary>
		/// <param name="_edStudExecuseReqId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExecuseReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExecuseReq GetByEdStudExecuseReqId(System.Decimal _edStudExecuseReqId)
		{
			int count = -1;
			return GetByEdStudExecuseReqId(null,_edStudExecuseReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXECUSE_REQ index.
		/// </summary>
		/// <param name="_edStudExecuseReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExecuseReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExecuseReq GetByEdStudExecuseReqId(System.Decimal _edStudExecuseReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExecuseReqId(null, _edStudExecuseReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXECUSE_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExecuseReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExecuseReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExecuseReq GetByEdStudExecuseReqId(TransactionManager transactionManager, System.Decimal _edStudExecuseReqId)
		{
			int count = -1;
			return GetByEdStudExecuseReqId(transactionManager, _edStudExecuseReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXECUSE_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExecuseReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExecuseReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExecuseReq GetByEdStudExecuseReqId(TransactionManager transactionManager, System.Decimal _edStudExecuseReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExecuseReqId(transactionManager, _edStudExecuseReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXECUSE_REQ index.
		/// </summary>
		/// <param name="_edStudExecuseReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExecuseReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExecuseReq GetByEdStudExecuseReqId(System.Decimal _edStudExecuseReqId, int start, int pageLength, out int count)
		{
			return GetByEdStudExecuseReqId(null, _edStudExecuseReqId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXECUSE_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExecuseReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExecuseReq"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudExecuseReq GetByEdStudExecuseReqId(TransactionManager transactionManager, System.Decimal _edStudExecuseReqId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_EXECUSE_REQ index.
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="_fromDate">استلام</param>
		/// <param name="_toDate">اخلاء</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExecuseReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExecuseReq GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFromDateToDate(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.DateTime _fromDate, System.DateTime _toDate)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFromDateToDate(null,_edStudId, _edAcadYearId, _edCodeSemesterId, _fromDate, _toDate, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_EXECUSE_REQ index.
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="_fromDate">استلام</param>
		/// <param name="_toDate">اخلاء</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExecuseReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExecuseReq GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFromDateToDate(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.DateTime _fromDate, System.DateTime _toDate, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFromDateToDate(null, _edStudId, _edAcadYearId, _edCodeSemesterId, _fromDate, _toDate, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_EXECUSE_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="_fromDate">استلام</param>
		/// <param name="_toDate">اخلاء</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExecuseReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExecuseReq GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFromDateToDate(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.DateTime _fromDate, System.DateTime _toDate)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFromDateToDate(transactionManager, _edStudId, _edAcadYearId, _edCodeSemesterId, _fromDate, _toDate, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_EXECUSE_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="_fromDate">استلام</param>
		/// <param name="_toDate">اخلاء</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExecuseReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExecuseReq GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFromDateToDate(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.DateTime _fromDate, System.DateTime _toDate, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFromDateToDate(transactionManager, _edStudId, _edAcadYearId, _edCodeSemesterId, _fromDate, _toDate, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_EXECUSE_REQ index.
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="_fromDate">استلام</param>
		/// <param name="_toDate">اخلاء</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExecuseReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExecuseReq GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFromDateToDate(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.DateTime _fromDate, System.DateTime _toDate, int start, int pageLength, out int count)
		{
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFromDateToDate(null, _edStudId, _edAcadYearId, _edCodeSemesterId, _fromDate, _toDate, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_EXECUSE_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="_fromDate">استلام</param>
		/// <param name="_toDate">اخلاء</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExecuseReq"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudExecuseReq GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFromDateToDate(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.DateTime _fromDate, System.DateTime _toDate, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudExecuseReq&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudExecuseReq&gt;"/></returns>
		public static TList<EdStudExecuseReq> Fill(IDataReader reader, TList<EdStudExecuseReq> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudExecuseReq c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudExecuseReq")
					.Append("|").Append((System.Decimal)reader["ED_STUD_EXECUSE_REQ_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudExecuseReq>(
					key.ToString(), // EntityTrackingKey
					"EdStudExecuseReq",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudExecuseReq();
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
					c.EdStudExecuseReqId = (System.Decimal)reader["ED_STUD_EXECUSE_REQ_ID"];
					c.OriginalEdStudExecuseReqId = c.EdStudExecuseReqId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.ReqDate = (System.DateTime)reader["REQ_DATE"];
					c.GsCodeReqStatusId = (System.Decimal)reader["GS_CODE_REQ_STATUS_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Int32?)reader["APPROVE_FLG"];
					c.ApproveDate = Convert.IsDBNull(reader["APPROVE_DATE"]) ? null : (System.DateTime?)reader["APPROVE_DATE"];
					c.AttchdDocPath = Convert.IsDBNull(reader["ATTCHD_DOC_PATH"]) ? null : (System.String)reader["ATTCHD_DOC_PATH"];
					c.FromDate = (System.DateTime)reader["FROM_DATE"];
					c.ToDate = (System.DateTime)reader["TO_DATE"];
					c.EdCdeExecuseRsnId = (System.Int32)reader["ED_CDE_EXECUSE_RSN_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudExecuseReq"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudExecuseReq"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudExecuseReq entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudExecuseReqId = (System.Decimal)reader[((int)EdStudExecuseReqColumn.EdStudExecuseReqId - 1)];
			entity.OriginalEdStudExecuseReqId = (System.Decimal)reader["ED_STUD_EXECUSE_REQ_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)EdStudExecuseReqColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)EdStudExecuseReqColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)EdStudExecuseReqColumn.EdCodeSemesterId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)EdStudExecuseReqColumn.EdStudId - 1)];
			entity.ReqDate = (System.DateTime)reader[((int)EdStudExecuseReqColumn.ReqDate - 1)];
			entity.GsCodeReqStatusId = (System.Decimal)reader[((int)EdStudExecuseReqColumn.GsCodeReqStatusId - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdStudExecuseReqColumn.Notes - 1)))?null:(System.String)reader[((int)EdStudExecuseReqColumn.Notes - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)EdStudExecuseReqColumn.ApproveFlg - 1)))?null:(System.Int32?)reader[((int)EdStudExecuseReqColumn.ApproveFlg - 1)];
			entity.ApproveDate = (reader.IsDBNull(((int)EdStudExecuseReqColumn.ApproveDate - 1)))?null:(System.DateTime?)reader[((int)EdStudExecuseReqColumn.ApproveDate - 1)];
			entity.AttchdDocPath = (reader.IsDBNull(((int)EdStudExecuseReqColumn.AttchdDocPath - 1)))?null:(System.String)reader[((int)EdStudExecuseReqColumn.AttchdDocPath - 1)];
			entity.FromDate = (System.DateTime)reader[((int)EdStudExecuseReqColumn.FromDate - 1)];
			entity.ToDate = (System.DateTime)reader[((int)EdStudExecuseReqColumn.ToDate - 1)];
			entity.EdCdeExecuseRsnId = (System.Int32)reader[((int)EdStudExecuseReqColumn.EdCdeExecuseRsnId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudExecuseReqColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudExecuseReqColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudExecuseReqColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudExecuseReqColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudExecuseReq"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudExecuseReq"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudExecuseReq entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudExecuseReqId = (System.Decimal)dataRow["ED_STUD_EXECUSE_REQ_ID"];
			entity.OriginalEdStudExecuseReqId = (System.Decimal)dataRow["ED_STUD_EXECUSE_REQ_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.ReqDate = (System.DateTime)dataRow["REQ_DATE"];
			entity.GsCodeReqStatusId = (System.Decimal)dataRow["GS_CODE_REQ_STATUS_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Int32?)dataRow["APPROVE_FLG"];
			entity.ApproveDate = Convert.IsDBNull(dataRow["APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["APPROVE_DATE"];
			entity.AttchdDocPath = Convert.IsDBNull(dataRow["ATTCHD_DOC_PATH"]) ? null : (System.String)dataRow["ATTCHD_DOC_PATH"];
			entity.FromDate = (System.DateTime)dataRow["FROM_DATE"];
			entity.ToDate = (System.DateTime)dataRow["TO_DATE"];
			entity.EdCdeExecuseRsnId = (System.Int32)dataRow["ED_CDE_EXECUSE_RSN_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudExecuseReq"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudExecuseReq Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExecuseReq entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdAcadYearId;
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearIdSource

			#region EdCdeExecuseRsnIdSource	
			if (CanDeepLoad(entity, "EdCdeExecuseRsn|EdCdeExecuseRsnIdSource", deepLoadType, innerList) 
				&& entity.EdCdeExecuseRsnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCdeExecuseRsnId;
				EdCdeExecuseRsn tmpEntity = EntityManager.LocateEntity<EdCdeExecuseRsn>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeExecuseRsn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeExecuseRsnIdSource = tmpEntity;
				else
					entity.EdCdeExecuseRsnIdSource = DataRepository.EdCdeExecuseRsnProvider.GetByEdCdeExecuseRsnId(transactionManager, entity.EdCdeExecuseRsnId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeExecuseRsnIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeExecuseRsnIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeExecuseRsnProvider.DeepLoad(transactionManager, entity.EdCdeExecuseRsnIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeExecuseRsnIdSource

			#region EdCodeSemesterIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemesterId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdCodeSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterIdSource

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudId;
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudProvider.DeepLoad(transactionManager, entity.EdStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudIdSource

			#region GsCodeReqStatusIdSource	
			if (CanDeepLoad(entity, "GsCodeReqStatus|GsCodeReqStatusIdSource", deepLoadType, innerList) 
				&& entity.GsCodeReqStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeReqStatusId;
				GsCodeReqStatus tmpEntity = EntityManager.LocateEntity<GsCodeReqStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeReqStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeReqStatusIdSource = tmpEntity;
				else
					entity.GsCodeReqStatusIdSource = DataRepository.GsCodeReqStatusProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeReqStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeReqStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeReqStatusProvider.DeepLoad(transactionManager, entity.GsCodeReqStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeReqStatusIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudExecuseReq object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudExecuseReq instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudExecuseReq Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExecuseReq entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EdCdeExecuseRsnIdSource
			if (CanDeepSave(entity, "EdCdeExecuseRsn|EdCdeExecuseRsnIdSource", deepSaveType, innerList) 
				&& entity.EdCdeExecuseRsnIdSource != null)
			{
				DataRepository.EdCdeExecuseRsnProvider.Save(transactionManager, entity.EdCdeExecuseRsnIdSource);
				entity.EdCdeExecuseRsnId = entity.EdCdeExecuseRsnIdSource.EdCdeExecuseRsnId;
			}
			#endregion 
			
			#region EdCodeSemesterIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterIdSource);
				entity.EdCodeSemesterId = entity.EdCodeSemesterIdSource.EdCodeSemesterId;
			}
			#endregion 
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region GsCodeReqStatusIdSource
			if (CanDeepSave(entity, "GsCodeReqStatus|GsCodeReqStatusIdSource", deepSaveType, innerList) 
				&& entity.GsCodeReqStatusIdSource != null)
			{
				DataRepository.GsCodeReqStatusProvider.Save(transactionManager, entity.GsCodeReqStatusIdSource);
				entity.GsCodeReqStatusId = entity.GsCodeReqStatusIdSource.GsCodeReqStatusId;
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
	
	#region EdStudExecuseReqChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudExecuseReq</c>
	///</summary>
	public enum EdStudExecuseReqChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCdeExecuseRsn</c> at EdCdeExecuseRsnIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeExecuseRsn))]
		EdCdeExecuseRsn,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>GsCodeReqStatus</c> at GsCodeReqStatusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeReqStatus))]
		GsCodeReqStatus,
	}
	
	#endregion EdStudExecuseReqChildEntityTypes
	
	#region EdStudExecuseReqFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudExecuseReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudExecuseReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudExecuseReqFilterBuilder : SqlFilterBuilder<EdStudExecuseReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudExecuseReqFilterBuilder class.
		/// </summary>
		public EdStudExecuseReqFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudExecuseReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudExecuseReqFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudExecuseReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudExecuseReqFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudExecuseReqFilterBuilder
	
	#region EdStudExecuseReqParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudExecuseReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudExecuseReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudExecuseReqParameterBuilder : ParameterizedSqlFilterBuilder<EdStudExecuseReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudExecuseReqParameterBuilder class.
		/// </summary>
		public EdStudExecuseReqParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudExecuseReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudExecuseReqParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudExecuseReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudExecuseReqParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudExecuseReqParameterBuilder
	
	#region EdStudExecuseReqSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudExecuseReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudExecuseReq"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudExecuseReqSortBuilder : SqlSortBuilder<EdStudExecuseReqColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudExecuseReqSqlSortBuilder class.
		/// </summary>
		public EdStudExecuseReqSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudExecuseReqSortBuilder
	
} // end namespace
