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
	/// This class is the base class for any <see cref="EdStudExmptReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudExmptReqProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudExmptReq, UMIS_VER2.BusinessLyer.EdStudExmptReqKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExmptReqKey key)
		{
			return Delete(transactionManager, key.EdStudExmptReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudExmptReqId">طلبات الاعفاء. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudExmptReqId)
		{
			return Delete(null, _edStudExmptReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptReqId">طلبات الاعفاء. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudExmptReqId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_ACAD_YEAR key.
		///		FK_ED_STUD_EXMPT_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_ACAD_YEAR key.
		///		FK_ED_STUD_EXMPT_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudExmptReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_ACAD_YEAR key.
		///		FK_ED_STUD_EXMPT_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_ACAD_YEAR key.
		///		fkEdStudExmptReqEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_ACAD_YEAR key.
		///		fkEdStudExmptReqEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_ACAD_YEAR key.
		///		FK_ED_STUD_EXMPT_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public abstract TList<EdStudExmptReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_CDE_EXMPT key.
		///		FK_ED_STUD_EXMPT_REQ_ED_CDE_EXMPT Description: 
		/// </summary>
		/// <param name="_edCdeExmptId">نوع الاعفاء:credittransferRPL-crosscredit-trainingcourse</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByEdCdeExmptId(System.Int32 _edCdeExmptId)
		{
			int count = -1;
			return GetByEdCdeExmptId(_edCdeExmptId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_CDE_EXMPT key.
		///		FK_ED_STUD_EXMPT_REQ_ED_CDE_EXMPT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExmptId">نوع الاعفاء:credittransferRPL-crosscredit-trainingcourse</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudExmptReq> GetByEdCdeExmptId(TransactionManager transactionManager, System.Int32 _edCdeExmptId)
		{
			int count = -1;
			return GetByEdCdeExmptId(transactionManager, _edCdeExmptId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_CDE_EXMPT key.
		///		FK_ED_STUD_EXMPT_REQ_ED_CDE_EXMPT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExmptId">نوع الاعفاء:credittransferRPL-crosscredit-trainingcourse</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByEdCdeExmptId(TransactionManager transactionManager, System.Int32 _edCdeExmptId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExmptId(transactionManager, _edCdeExmptId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_CDE_EXMPT key.
		///		fkEdStudExmptReqEdCdeExmpt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExmptId">نوع الاعفاء:credittransferRPL-crosscredit-trainingcourse</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByEdCdeExmptId(System.Int32 _edCdeExmptId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeExmptId(null, _edCdeExmptId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_CDE_EXMPT key.
		///		fkEdStudExmptReqEdCdeExmpt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExmptId">نوع الاعفاء:credittransferRPL-crosscredit-trainingcourse</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByEdCdeExmptId(System.Int32 _edCdeExmptId, int start, int pageLength,out int count)
		{
			return GetByEdCdeExmptId(null, _edCdeExmptId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_CDE_EXMPT key.
		///		FK_ED_STUD_EXMPT_REQ_ED_CDE_EXMPT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExmptId">نوع الاعفاء:credittransferRPL-crosscredit-trainingcourse</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public abstract TList<EdStudExmptReq> GetByEdCdeExmptId(TransactionManager transactionManager, System.Int32 _edCdeExmptId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_EXMPT_REQ_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_EXMPT_REQ_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudExmptReq> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_EXMPT_REQ_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_CODE_SEMESTER key.
		///		fkEdStudExmptReqEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_CODE_SEMESTER key.
		///		fkEdStudExmptReqEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_EXMPT_REQ_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public abstract TList<EdStudExmptReq> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_STUD key.
		///		FK_ED_STUD_EXMPT_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_STUD key.
		///		FK_ED_STUD_EXMPT_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudExmptReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_STUD key.
		///		FK_ED_STUD_EXMPT_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_STUD key.
		///		fkEdStudExmptReqEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_STUD key.
		///		fkEdStudExmptReqEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_ED_STUD key.
		///		FK_ED_STUD_EXMPT_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public abstract TList<EdStudExmptReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ED_STUD_EXMPT_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="_gsCodeReqStatusId">حالة الطلب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(_gsCodeReqStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ED_STUD_EXMPT_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudExmptReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ED_STUD_EXMPT_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_GS_CODE_REQ_STATUS key.
		///		fkEdStudExmptReqGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_GS_CODE_REQ_STATUS key.
		///		fkEdStudExmptReqGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public TList<EdStudExmptReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength,out int count)
		{
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ED_STUD_EXMPT_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptReq objects.</returns>
		public abstract TList<EdStudExmptReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudExmptReq Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExmptReqKey key, int start, int pageLength)
		{
			return GetByEdStudExmptReqId(transactionManager, key.EdStudExmptReqId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_EXMPT_REQ index.
		/// </summary>
		/// <param name="_edStudExmptReqId">طلبات الاعفاء</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptReq GetByEdStudExmptReqId(System.Decimal _edStudExmptReqId)
		{
			int count = -1;
			return GetByEdStudExmptReqId(null,_edStudExmptReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_REQ index.
		/// </summary>
		/// <param name="_edStudExmptReqId">طلبات الاعفاء</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptReq GetByEdStudExmptReqId(System.Decimal _edStudExmptReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExmptReqId(null, _edStudExmptReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptReqId">طلبات الاعفاء</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptReq GetByEdStudExmptReqId(TransactionManager transactionManager, System.Decimal _edStudExmptReqId)
		{
			int count = -1;
			return GetByEdStudExmptReqId(transactionManager, _edStudExmptReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptReqId">طلبات الاعفاء</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptReq GetByEdStudExmptReqId(TransactionManager transactionManager, System.Decimal _edStudExmptReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExmptReqId(transactionManager, _edStudExmptReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_REQ index.
		/// </summary>
		/// <param name="_edStudExmptReqId">طلبات الاعفاء</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptReq GetByEdStudExmptReqId(System.Decimal _edStudExmptReqId, int start, int pageLength, out int count)
		{
			return GetByEdStudExmptReqId(null, _edStudExmptReqId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptReqId">طلبات الاعفاء</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReq"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudExmptReq GetByEdStudExmptReqId(TransactionManager transactionManager, System.Decimal _edStudExmptReqId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudExmptReq&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudExmptReq&gt;"/></returns>
		public static TList<EdStudExmptReq> Fill(IDataReader reader, TList<EdStudExmptReq> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudExmptReq c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudExmptReq")
					.Append("|").Append((System.Decimal)reader["ED_STUD_EXMPT_REQ_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudExmptReq>(
					key.ToString(), // EntityTrackingKey
					"EdStudExmptReq",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudExmptReq();
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
					c.EdStudExmptReqId = (System.Decimal)reader["ED_STUD_EXMPT_REQ_ID"];
					c.OriginalEdStudExmptReqId = c.EdStudExmptReqId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.GsCodeReqStatusId = (System.Decimal)reader["GS_CODE_REQ_STATUS_ID"];
					c.ReqDate = (System.DateTime)reader["REQ_DATE"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EdCdeExmptId = (System.Int32)reader["ED_CDE_EXMPT_ID"];
					c.DeptApproveDt = Convert.IsDBNull(reader["DEPT_APPROVE_DT"]) ? null : (System.DateTime?)reader["DEPT_APPROVE_DT"];
					c.FacApproveDt = Convert.IsDBNull(reader["FAC_APPROVE_DT"]) ? null : (System.DateTime?)reader["FAC_APPROVE_DT"];
					c.UnivApproveDt = Convert.IsDBNull(reader["UNIV_APPROVE_DT"]) ? null : (System.DateTime?)reader["UNIV_APPROVE_DT"];
					c.ApproveFlg = (System.Decimal)reader["APPROVE_FLG"];
					c.ExmptApproveDt = Convert.IsDBNull(reader["EXMPT_APPROVE_DT"]) ? null : (System.DateTime?)reader["EXMPT_APPROVE_DT"];
					c.ExmptApprvUsrId = Convert.IsDBNull(reader["EXMPT_APPRV_USR_ID"]) ? null : (System.Decimal?)reader["EXMPT_APPRV_USR_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReq"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReq"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudExmptReq entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudExmptReqId = (System.Decimal)reader[((int)EdStudExmptReqColumn.EdStudExmptReqId - 1)];
			entity.OriginalEdStudExmptReqId = (System.Decimal)reader["ED_STUD_EXMPT_REQ_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)EdStudExmptReqColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)EdStudExmptReqColumn.EdCodeSemesterId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)EdStudExmptReqColumn.EdStudId - 1)];
			entity.GsCodeReqStatusId = (System.Decimal)reader[((int)EdStudExmptReqColumn.GsCodeReqStatusId - 1)];
			entity.ReqDate = (System.DateTime)reader[((int)EdStudExmptReqColumn.ReqDate - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdStudExmptReqColumn.Notes - 1)))?null:(System.String)reader[((int)EdStudExmptReqColumn.Notes - 1)];
			entity.EdCdeExmptId = (System.Int32)reader[((int)EdStudExmptReqColumn.EdCdeExmptId - 1)];
			entity.DeptApproveDt = (reader.IsDBNull(((int)EdStudExmptReqColumn.DeptApproveDt - 1)))?null:(System.DateTime?)reader[((int)EdStudExmptReqColumn.DeptApproveDt - 1)];
			entity.FacApproveDt = (reader.IsDBNull(((int)EdStudExmptReqColumn.FacApproveDt - 1)))?null:(System.DateTime?)reader[((int)EdStudExmptReqColumn.FacApproveDt - 1)];
			entity.UnivApproveDt = (reader.IsDBNull(((int)EdStudExmptReqColumn.UnivApproveDt - 1)))?null:(System.DateTime?)reader[((int)EdStudExmptReqColumn.UnivApproveDt - 1)];
			entity.ApproveFlg = (System.Decimal)reader[((int)EdStudExmptReqColumn.ApproveFlg - 1)];
			entity.ExmptApproveDt = (reader.IsDBNull(((int)EdStudExmptReqColumn.ExmptApproveDt - 1)))?null:(System.DateTime?)reader[((int)EdStudExmptReqColumn.ExmptApproveDt - 1)];
			entity.ExmptApprvUsrId = (reader.IsDBNull(((int)EdStudExmptReqColumn.ExmptApprvUsrId - 1)))?null:(System.Decimal?)reader[((int)EdStudExmptReqColumn.ExmptApprvUsrId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReq"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReq"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudExmptReq entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudExmptReqId = (System.Decimal)dataRow["ED_STUD_EXMPT_REQ_ID"];
			entity.OriginalEdStudExmptReqId = (System.Decimal)dataRow["ED_STUD_EXMPT_REQ_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.GsCodeReqStatusId = (System.Decimal)dataRow["GS_CODE_REQ_STATUS_ID"];
			entity.ReqDate = (System.DateTime)dataRow["REQ_DATE"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.EdCdeExmptId = (System.Int32)dataRow["ED_CDE_EXMPT_ID"];
			entity.DeptApproveDt = Convert.IsDBNull(dataRow["DEPT_APPROVE_DT"]) ? null : (System.DateTime?)dataRow["DEPT_APPROVE_DT"];
			entity.FacApproveDt = Convert.IsDBNull(dataRow["FAC_APPROVE_DT"]) ? null : (System.DateTime?)dataRow["FAC_APPROVE_DT"];
			entity.UnivApproveDt = Convert.IsDBNull(dataRow["UNIV_APPROVE_DT"]) ? null : (System.DateTime?)dataRow["UNIV_APPROVE_DT"];
			entity.ApproveFlg = (System.Decimal)dataRow["APPROVE_FLG"];
			entity.ExmptApproveDt = Convert.IsDBNull(dataRow["EXMPT_APPROVE_DT"]) ? null : (System.DateTime?)dataRow["EXMPT_APPROVE_DT"];
			entity.ExmptApprvUsrId = Convert.IsDBNull(dataRow["EXMPT_APPRV_USR_ID"]) ? null : (System.Decimal?)dataRow["EXMPT_APPRV_USR_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudExmptReq"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudExmptReq Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExmptReq entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdCdeExmptIdSource	
			if (CanDeepLoad(entity, "EdCdeExmpt|EdCdeExmptIdSource", deepLoadType, innerList) 
				&& entity.EdCdeExmptIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCdeExmptId;
				EdCdeExmpt tmpEntity = EntityManager.LocateEntity<EdCdeExmpt>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeExmpt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeExmptIdSource = tmpEntity;
				else
					entity.EdCdeExmptIdSource = DataRepository.EdCdeExmptProvider.GetByEdCdeExmptId(transactionManager, entity.EdCdeExmptId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeExmptIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeExmptIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeExmptProvider.DeepLoad(transactionManager, entity.EdCdeExmptIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeExmptIdSource

			#region EdCodeSemesterIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeSemesterId;
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);		
				
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
			// Deep load child collections  - Call GetByEdStudExmptReqId methods when available
			
			#region EdStudExmptReqAttchCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExmptReqAttch>|EdStudExmptReqAttchCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExmptReqAttchCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExmptReqAttchCollection = DataRepository.EdStudExmptReqAttchProvider.GetByEdStudExmptReqId(transactionManager, entity.EdStudExmptReqId);

				if (deep && entity.EdStudExmptReqAttchCollection.Count > 0)
				{
					deepHandles.Add("EdStudExmptReqAttchCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExmptReqAttch>) DataRepository.EdStudExmptReqAttchProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExmptReqAttchCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExmptCrsFromCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExmptCrsFrom>|EdStudExmptCrsFromCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExmptCrsFromCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExmptCrsFromCollection = DataRepository.EdStudExmptCrsFromProvider.GetByEdStudExmptReqId(transactionManager, entity.EdStudExmptReqId);

				if (deep && entity.EdStudExmptCrsFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudExmptCrsFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExmptCrsFrom>) DataRepository.EdStudExmptCrsFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExmptCrsFromCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExmptCrsToCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExmptCrsTo>|EdStudExmptCrsToCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExmptCrsToCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExmptCrsToCollection = DataRepository.EdStudExmptCrsToProvider.GetByEdStudExmptReqId(transactionManager, entity.EdStudExmptReqId);

				if (deep && entity.EdStudExmptCrsToCollection.Count > 0)
				{
					deepHandles.Add("EdStudExmptCrsToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExmptCrsTo>) DataRepository.EdStudExmptCrsToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExmptCrsToCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudExmptReq object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudExmptReq instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudExmptReq Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExmptReq entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCdeExmptIdSource
			if (CanDeepSave(entity, "EdCdeExmpt|EdCdeExmptIdSource", deepSaveType, innerList) 
				&& entity.EdCdeExmptIdSource != null)
			{
				DataRepository.EdCdeExmptProvider.Save(transactionManager, entity.EdCdeExmptIdSource);
				entity.EdCdeExmptId = entity.EdCdeExmptIdSource.EdCdeExmptId;
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
	
			#region List<EdStudExmptReqAttch>
				if (CanDeepSave(entity.EdStudExmptReqAttchCollection, "List<EdStudExmptReqAttch>|EdStudExmptReqAttchCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExmptReqAttch child in entity.EdStudExmptReqAttchCollection)
					{
						if(child.EdStudExmptReqIdSource != null)
						{
							child.EdStudExmptReqId = child.EdStudExmptReqIdSource.EdStudExmptReqId;
						}
						else
						{
							child.EdStudExmptReqId = entity.EdStudExmptReqId;
						}

					}

					if (entity.EdStudExmptReqAttchCollection.Count > 0 || entity.EdStudExmptReqAttchCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExmptReqAttchProvider.Save(transactionManager, entity.EdStudExmptReqAttchCollection);
						
						deepHandles.Add("EdStudExmptReqAttchCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExmptReqAttch >) DataRepository.EdStudExmptReqAttchProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExmptReqAttchCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudExmptCrsFrom>
				if (CanDeepSave(entity.EdStudExmptCrsFromCollection, "List<EdStudExmptCrsFrom>|EdStudExmptCrsFromCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExmptCrsFrom child in entity.EdStudExmptCrsFromCollection)
					{
						if(child.EdStudExmptReqIdSource != null)
						{
							child.EdStudExmptReqId = child.EdStudExmptReqIdSource.EdStudExmptReqId;
						}
						else
						{
							child.EdStudExmptReqId = entity.EdStudExmptReqId;
						}

					}

					if (entity.EdStudExmptCrsFromCollection.Count > 0 || entity.EdStudExmptCrsFromCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExmptCrsFromProvider.Save(transactionManager, entity.EdStudExmptCrsFromCollection);
						
						deepHandles.Add("EdStudExmptCrsFromCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExmptCrsFrom >) DataRepository.EdStudExmptCrsFromProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExmptCrsFromCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudExmptCrsTo>
				if (CanDeepSave(entity.EdStudExmptCrsToCollection, "List<EdStudExmptCrsTo>|EdStudExmptCrsToCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExmptCrsTo child in entity.EdStudExmptCrsToCollection)
					{
						if(child.EdStudExmptReqIdSource != null)
						{
							child.EdStudExmptReqId = child.EdStudExmptReqIdSource.EdStudExmptReqId;
						}
						else
						{
							child.EdStudExmptReqId = entity.EdStudExmptReqId;
						}

					}

					if (entity.EdStudExmptCrsToCollection.Count > 0 || entity.EdStudExmptCrsToCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExmptCrsToProvider.Save(transactionManager, entity.EdStudExmptCrsToCollection);
						
						deepHandles.Add("EdStudExmptCrsToCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExmptCrsTo >) DataRepository.EdStudExmptCrsToProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExmptCrsToCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdStudExmptReqChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudExmptReq</c>
	///</summary>
	public enum EdStudExmptReqChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCdeExmpt</c> at EdCdeExmptIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeExmpt))]
		EdCdeExmpt,
		
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
		///<summary>
		/// Collection of <c>EdStudExmptReq</c> as OneToMany for EdStudExmptReqAttchCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExmptReqAttch>))]
		EdStudExmptReqAttchCollection,
		///<summary>
		/// Collection of <c>EdStudExmptReq</c> as OneToMany for EdStudExmptCrsFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExmptCrsFrom>))]
		EdStudExmptCrsFromCollection,
		///<summary>
		/// Collection of <c>EdStudExmptReq</c> as OneToMany for EdStudExmptCrsToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExmptCrsTo>))]
		EdStudExmptCrsToCollection,
	}
	
	#endregion EdStudExmptReqChildEntityTypes
	
	#region EdStudExmptReqFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudExmptReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudExmptReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudExmptReqFilterBuilder : SqlFilterBuilder<EdStudExmptReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudExmptReqFilterBuilder class.
		/// </summary>
		public EdStudExmptReqFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudExmptReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudExmptReqFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudExmptReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudExmptReqFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudExmptReqFilterBuilder
	
	#region EdStudExmptReqParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudExmptReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudExmptReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudExmptReqParameterBuilder : ParameterizedSqlFilterBuilder<EdStudExmptReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudExmptReqParameterBuilder class.
		/// </summary>
		public EdStudExmptReqParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudExmptReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudExmptReqParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudExmptReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudExmptReqParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudExmptReqParameterBuilder
	
	#region EdStudExmptReqSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudExmptReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudExmptReq"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudExmptReqSortBuilder : SqlSortBuilder<EdStudExmptReqColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudExmptReqSqlSortBuilder class.
		/// </summary>
		public EdStudExmptReqSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudExmptReqSortBuilder
	
} // end namespace
