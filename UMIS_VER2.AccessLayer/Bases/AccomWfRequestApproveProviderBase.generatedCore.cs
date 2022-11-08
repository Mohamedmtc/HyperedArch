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
	/// This class is the base class for any <see cref="AccomWfRequestApproveProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomWfRequestApproveProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomWfRequestApprove, UMIS_VER2.BusinessLyer.AccomWfRequestApproveKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomWfRequestApproveKey key)
		{
			return Delete(transactionManager, key.AccomWfRequestApproveId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomWfRequestApproveId">work flow approve course result/Approve Course Grade Change. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _accomWfRequestApproveId)
		{
			return Delete(null, _accomWfRequestApproveId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomWfRequestApproveId">work flow approve course result/Approve Course Grade Change. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _accomWfRequestApproveId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_LEAVE_REQ key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_LEAVE_REQ Description: 
		/// </summary>
		/// <param name="_accomStudLeaveReqId">طلب خروج من السكن الداخلي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByAccomStudLeaveReqId(System.Decimal? _accomStudLeaveReqId)
		{
			int count = -1;
			return GetByAccomStudLeaveReqId(_accomStudLeaveReqId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_LEAVE_REQ key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_LEAVE_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudLeaveReqId">طلب خروج من السكن الداخلي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		/// <remarks></remarks>
		public TList<AccomWfRequestApprove> GetByAccomStudLeaveReqId(TransactionManager transactionManager, System.Decimal? _accomStudLeaveReqId)
		{
			int count = -1;
			return GetByAccomStudLeaveReqId(transactionManager, _accomStudLeaveReqId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_LEAVE_REQ key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_LEAVE_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudLeaveReqId">طلب خروج من السكن الداخلي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByAccomStudLeaveReqId(TransactionManager transactionManager, System.Decimal? _accomStudLeaveReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudLeaveReqId(transactionManager, _accomStudLeaveReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_LEAVE_REQ key.
		///		fkAccomWfRequestApproveAccomStudLeaveReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudLeaveReqId">طلب خروج من السكن الداخلي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByAccomStudLeaveReqId(System.Decimal? _accomStudLeaveReqId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomStudLeaveReqId(null, _accomStudLeaveReqId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_LEAVE_REQ key.
		///		fkAccomWfRequestApproveAccomStudLeaveReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudLeaveReqId">طلب خروج من السكن الداخلي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByAccomStudLeaveReqId(System.Decimal? _accomStudLeaveReqId, int start, int pageLength,out int count)
		{
			return GetByAccomStudLeaveReqId(null, _accomStudLeaveReqId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_LEAVE_REQ key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_LEAVE_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudLeaveReqId">طلب خروج من السكن الداخلي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public abstract TList<AccomWfRequestApprove> GetByAccomStudLeaveReqId(TransactionManager transactionManager, System.Decimal? _accomStudLeaveReqId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_REQ key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_REQ Description: 
		/// </summary>
		/// <param name="_accomStudReqId">Accomodation  طلب اقامة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByAccomStudReqId(System.Decimal? _accomStudReqId)
		{
			int count = -1;
			return GetByAccomStudReqId(_accomStudReqId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_REQ key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudReqId">Accomodation  طلب اقامة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		/// <remarks></remarks>
		public TList<AccomWfRequestApprove> GetByAccomStudReqId(TransactionManager transactionManager, System.Decimal? _accomStudReqId)
		{
			int count = -1;
			return GetByAccomStudReqId(transactionManager, _accomStudReqId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_REQ key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudReqId">Accomodation  طلب اقامة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByAccomStudReqId(TransactionManager transactionManager, System.Decimal? _accomStudReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudReqId(transactionManager, _accomStudReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_REQ key.
		///		fkAccomWfRequestApproveAccomStudReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudReqId">Accomodation  طلب اقامة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByAccomStudReqId(System.Decimal? _accomStudReqId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomStudReqId(null, _accomStudReqId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_REQ key.
		///		fkAccomWfRequestApproveAccomStudReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudReqId">Accomodation  طلب اقامة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByAccomStudReqId(System.Decimal? _accomStudReqId, int start, int pageLength,out int count)
		{
			return GetByAccomStudReqId(null, _accomStudReqId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_REQ key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_STUD_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudReqId">Accomodation  طلب اقامة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public abstract TList<AccomWfRequestApprove> GetByAccomStudReqId(TransactionManager transactionManager, System.Decimal? _accomStudReqId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_ACTION key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_ACTION Description: 
		/// </summary>
		/// <param name="_accomWfCdeActionId">confirm-reject-approve</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByAccomWfCdeActionId(System.Int32 _accomWfCdeActionId)
		{
			int count = -1;
			return GetByAccomWfCdeActionId(_accomWfCdeActionId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_ACTION key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_ACTION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomWfCdeActionId">confirm-reject-approve</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		/// <remarks></remarks>
		public TList<AccomWfRequestApprove> GetByAccomWfCdeActionId(TransactionManager transactionManager, System.Int32 _accomWfCdeActionId)
		{
			int count = -1;
			return GetByAccomWfCdeActionId(transactionManager, _accomWfCdeActionId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_ACTION key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_ACTION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomWfCdeActionId">confirm-reject-approve</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByAccomWfCdeActionId(TransactionManager transactionManager, System.Int32 _accomWfCdeActionId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomWfCdeActionId(transactionManager, _accomWfCdeActionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_ACTION key.
		///		fkAccomWfRequestApproveAccomWfCdeAction Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomWfCdeActionId">confirm-reject-approve</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByAccomWfCdeActionId(System.Int32 _accomWfCdeActionId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomWfCdeActionId(null, _accomWfCdeActionId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_ACTION key.
		///		fkAccomWfRequestApproveAccomWfCdeAction Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomWfCdeActionId">confirm-reject-approve</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByAccomWfCdeActionId(System.Int32 _accomWfCdeActionId, int start, int pageLength,out int count)
		{
			return GetByAccomWfCdeActionId(null, _accomWfCdeActionId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_ACTION key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_ACTION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomWfCdeActionId">confirm-reject-approve</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public abstract TList<AccomWfRequestApprove> GetByAccomWfCdeActionId(TransactionManager transactionManager, System.Int32 _accomWfCdeActionId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_FUNCTION key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_FUNCTION Description: 
		/// </summary>
		/// <param name="_accomWfCdeFunctionId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByAccomWfCdeFunctionId(System.Int32? _accomWfCdeFunctionId)
		{
			int count = -1;
			return GetByAccomWfCdeFunctionId(_accomWfCdeFunctionId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_FUNCTION key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_FUNCTION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomWfCdeFunctionId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		/// <remarks></remarks>
		public TList<AccomWfRequestApprove> GetByAccomWfCdeFunctionId(TransactionManager transactionManager, System.Int32? _accomWfCdeFunctionId)
		{
			int count = -1;
			return GetByAccomWfCdeFunctionId(transactionManager, _accomWfCdeFunctionId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_FUNCTION key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_FUNCTION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomWfCdeFunctionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByAccomWfCdeFunctionId(TransactionManager transactionManager, System.Int32? _accomWfCdeFunctionId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomWfCdeFunctionId(transactionManager, _accomWfCdeFunctionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_FUNCTION key.
		///		fkAccomWfRequestApproveAccomWfCdeFunction Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomWfCdeFunctionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByAccomWfCdeFunctionId(System.Int32? _accomWfCdeFunctionId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomWfCdeFunctionId(null, _accomWfCdeFunctionId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_FUNCTION key.
		///		fkAccomWfRequestApproveAccomWfCdeFunction Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomWfCdeFunctionId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByAccomWfCdeFunctionId(System.Int32? _accomWfCdeFunctionId, int start, int pageLength,out int count)
		{
			return GetByAccomWfCdeFunctionId(null, _accomWfCdeFunctionId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_FUNCTION key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ACCOM_WF_CDE_FUNCTION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomWfCdeFunctionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public abstract TList<AccomWfRequestApprove> GetByAccomWfCdeFunctionId(TransactionManager transactionManager, System.Int32? _accomWfCdeFunctionId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ED_ACAD_YEAR key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ED_ACAD_YEAR key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		/// <remarks></remarks>
		public TList<AccomWfRequestApprove> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ED_ACAD_YEAR key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ED_ACAD_YEAR key.
		///		fkAccomWfRequestApproveEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ED_ACAD_YEAR key.
		///		fkAccomWfRequestApproveEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ED_ACAD_YEAR key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public abstract TList<AccomWfRequestApprove> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ED_CODE_SEMESTER key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ED_CODE_SEMESTER key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		/// <remarks></remarks>
		public TList<AccomWfRequestApprove> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ED_CODE_SEMESTER key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ED_CODE_SEMESTER key.
		///		fkAccomWfRequestApproveEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ED_CODE_SEMESTER key.
		///		fkAccomWfRequestApproveEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_ED_CODE_SEMESTER key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public abstract TList<AccomWfRequestApprove> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_SE_CODE_USER_TYPE key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="_seCodeUserTypeId">HousingAdmin-Stud-مساعد العميد للشئون الادارية و المالية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetBySeCodeUserTypeId(System.Decimal _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(_seCodeUserTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_SE_CODE_USER_TYPE key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId">HousingAdmin-Stud-مساعد العميد للشئون الادارية و المالية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		/// <remarks></remarks>
		public TList<AccomWfRequestApprove> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_SE_CODE_USER_TYPE key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId">HousingAdmin-Stud-مساعد العميد للشئون الادارية و المالية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_SE_CODE_USER_TYPE key.
		///		fkAccomWfRequestApproveSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId">HousingAdmin-Stud-مساعد العميد للشئون الادارية و المالية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetBySeCodeUserTypeId(System.Decimal _seCodeUserTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_SE_CODE_USER_TYPE key.
		///		fkAccomWfRequestApproveSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId">HousingAdmin-Stud-مساعد العميد للشئون الادارية و المالية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetBySeCodeUserTypeId(System.Decimal _seCodeUserTypeId, int start, int pageLength,out int count)
		{
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_SE_CODE_USER_TYPE key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId">HousingAdmin-Stud-مساعد العميد للشئون الادارية و المالية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public abstract TList<AccomWfRequestApprove> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_SE_USER key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId">HousingAdmin-Stud-مساعد العميد للشئون الادارية و المالية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetBySeUserId(System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_SE_USER key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId">HousingAdmin-Stud-مساعد العميد للشئون الادارية و المالية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		/// <remarks></remarks>
		public TList<AccomWfRequestApprove> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_SE_USER key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId">HousingAdmin-Stud-مساعد العميد للشئون الادارية و المالية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_SE_USER key.
		///		fkAccomWfRequestApproveSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId">HousingAdmin-Stud-مساعد العميد للشئون الادارية و المالية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_SE_USER key.
		///		fkAccomWfRequestApproveSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId">HousingAdmin-Stud-مساعد العميد للشئون الادارية و المالية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public TList<AccomWfRequestApprove> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_WF_REQUEST_APPROVE_SE_USER key.
		///		FK_ACCOM_WF_REQUEST_APPROVE_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId">HousingAdmin-Stud-مساعد العميد للشئون الادارية و المالية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomWfRequestApprove objects.</returns>
		public abstract TList<AccomWfRequestApprove> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomWfRequestApprove Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomWfRequestApproveKey key, int start, int pageLength)
		{
			return GetByAccomWfRequestApproveId(transactionManager, key.AccomWfRequestApproveId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_WF_REQUEST_APPROVE index.
		/// </summary>
		/// <param name="_accomWfRequestApproveId">work flow approve course result/Approve Course Grade Change</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomWfRequestApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomWfRequestApprove GetByAccomWfRequestApproveId(System.Decimal _accomWfRequestApproveId)
		{
			int count = -1;
			return GetByAccomWfRequestApproveId(null,_accomWfRequestApproveId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_WF_REQUEST_APPROVE index.
		/// </summary>
		/// <param name="_accomWfRequestApproveId">work flow approve course result/Approve Course Grade Change</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomWfRequestApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomWfRequestApprove GetByAccomWfRequestApproveId(System.Decimal _accomWfRequestApproveId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomWfRequestApproveId(null, _accomWfRequestApproveId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_WF_REQUEST_APPROVE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomWfRequestApproveId">work flow approve course result/Approve Course Grade Change</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomWfRequestApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomWfRequestApprove GetByAccomWfRequestApproveId(TransactionManager transactionManager, System.Decimal _accomWfRequestApproveId)
		{
			int count = -1;
			return GetByAccomWfRequestApproveId(transactionManager, _accomWfRequestApproveId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_WF_REQUEST_APPROVE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomWfRequestApproveId">work flow approve course result/Approve Course Grade Change</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomWfRequestApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomWfRequestApprove GetByAccomWfRequestApproveId(TransactionManager transactionManager, System.Decimal _accomWfRequestApproveId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomWfRequestApproveId(transactionManager, _accomWfRequestApproveId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_WF_REQUEST_APPROVE index.
		/// </summary>
		/// <param name="_accomWfRequestApproveId">work flow approve course result/Approve Course Grade Change</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomWfRequestApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomWfRequestApprove GetByAccomWfRequestApproveId(System.Decimal _accomWfRequestApproveId, int start, int pageLength, out int count)
		{
			return GetByAccomWfRequestApproveId(null, _accomWfRequestApproveId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_WF_REQUEST_APPROVE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomWfRequestApproveId">work flow approve course result/Approve Course Grade Change</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomWfRequestApprove"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomWfRequestApprove GetByAccomWfRequestApproveId(TransactionManager transactionManager, System.Decimal _accomWfRequestApproveId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomWfRequestApprove&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomWfRequestApprove&gt;"/></returns>
		public static TList<AccomWfRequestApprove> Fill(IDataReader reader, TList<AccomWfRequestApprove> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomWfRequestApprove c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomWfRequestApprove")
					.Append("|").Append((System.Decimal)reader["ACCOM_WF_REQUEST_APPROVE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomWfRequestApprove>(
					key.ToString(), // EntityTrackingKey
					"AccomWfRequestApprove",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomWfRequestApprove();
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
					c.AccomWfRequestApproveId = (System.Decimal)reader["ACCOM_WF_REQUEST_APPROVE_ID"];
					c.OriginalAccomWfRequestApproveId = c.AccomWfRequestApproveId;
					c.AccomWfCdeFunctionId = Convert.IsDBNull(reader["ACCOM_WF_CDE_FUNCTION_ID"]) ? null : (System.Int32?)reader["ACCOM_WF_CDE_FUNCTION_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.SeCodeUserTypeId = (System.Decimal)reader["SE_CODE_USER_TYPE_ID"];
					c.SeUserId = (System.Decimal)reader["SE_USER_ID"];
					c.AccomStudReqId = Convert.IsDBNull(reader["ACCOM_STUD_REQ_ID"]) ? null : (System.Decimal?)reader["ACCOM_STUD_REQ_ID"];
					c.AccomStudLeaveReqId = Convert.IsDBNull(reader["ACCOM_STUD_LEAVE_REQ_ID"]) ? null : (System.Decimal?)reader["ACCOM_STUD_LEAVE_REQ_ID"];
					c.AccomWfCdeActionId = (System.Int32)reader["ACCOM_WF_CDE_ACTION_ID"];
					c.ActionNote = Convert.IsDBNull(reader["ACTION_NOTE"]) ? null : (System.String)reader["ACTION_NOTE"];
					c.IsLast = Convert.IsDBNull(reader["IS_LAST"]) ? null : (System.Boolean?)reader["IS_LAST"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomWfRequestApprove"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomWfRequestApprove"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomWfRequestApprove entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomWfRequestApproveId = (System.Decimal)reader[((int)AccomWfRequestApproveColumn.AccomWfRequestApproveId - 1)];
			entity.OriginalAccomWfRequestApproveId = (System.Decimal)reader["ACCOM_WF_REQUEST_APPROVE_ID"];
			entity.AccomWfCdeFunctionId = (reader.IsDBNull(((int)AccomWfRequestApproveColumn.AccomWfCdeFunctionId - 1)))?null:(System.Int32?)reader[((int)AccomWfRequestApproveColumn.AccomWfCdeFunctionId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)AccomWfRequestApproveColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)AccomWfRequestApproveColumn.EdCodeSemesterId - 1)];
			entity.SeCodeUserTypeId = (System.Decimal)reader[((int)AccomWfRequestApproveColumn.SeCodeUserTypeId - 1)];
			entity.SeUserId = (System.Decimal)reader[((int)AccomWfRequestApproveColumn.SeUserId - 1)];
			entity.AccomStudReqId = (reader.IsDBNull(((int)AccomWfRequestApproveColumn.AccomStudReqId - 1)))?null:(System.Decimal?)reader[((int)AccomWfRequestApproveColumn.AccomStudReqId - 1)];
			entity.AccomStudLeaveReqId = (reader.IsDBNull(((int)AccomWfRequestApproveColumn.AccomStudLeaveReqId - 1)))?null:(System.Decimal?)reader[((int)AccomWfRequestApproveColumn.AccomStudLeaveReqId - 1)];
			entity.AccomWfCdeActionId = (System.Int32)reader[((int)AccomWfRequestApproveColumn.AccomWfCdeActionId - 1)];
			entity.ActionNote = (reader.IsDBNull(((int)AccomWfRequestApproveColumn.ActionNote - 1)))?null:(System.String)reader[((int)AccomWfRequestApproveColumn.ActionNote - 1)];
			entity.IsLast = (reader.IsDBNull(((int)AccomWfRequestApproveColumn.IsLast - 1)))?null:(System.Boolean?)reader[((int)AccomWfRequestApproveColumn.IsLast - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AccomWfRequestApproveColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AccomWfRequestApproveColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomWfRequestApprove"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomWfRequestApprove"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomWfRequestApprove entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomWfRequestApproveId = (System.Decimal)dataRow["ACCOM_WF_REQUEST_APPROVE_ID"];
			entity.OriginalAccomWfRequestApproveId = (System.Decimal)dataRow["ACCOM_WF_REQUEST_APPROVE_ID"];
			entity.AccomWfCdeFunctionId = Convert.IsDBNull(dataRow["ACCOM_WF_CDE_FUNCTION_ID"]) ? null : (System.Int32?)dataRow["ACCOM_WF_CDE_FUNCTION_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.SeCodeUserTypeId = (System.Decimal)dataRow["SE_CODE_USER_TYPE_ID"];
			entity.SeUserId = (System.Decimal)dataRow["SE_USER_ID"];
			entity.AccomStudReqId = Convert.IsDBNull(dataRow["ACCOM_STUD_REQ_ID"]) ? null : (System.Decimal?)dataRow["ACCOM_STUD_REQ_ID"];
			entity.AccomStudLeaveReqId = Convert.IsDBNull(dataRow["ACCOM_STUD_LEAVE_REQ_ID"]) ? null : (System.Decimal?)dataRow["ACCOM_STUD_LEAVE_REQ_ID"];
			entity.AccomWfCdeActionId = (System.Int32)dataRow["ACCOM_WF_CDE_ACTION_ID"];
			entity.ActionNote = Convert.IsDBNull(dataRow["ACTION_NOTE"]) ? null : (System.String)dataRow["ACTION_NOTE"];
			entity.IsLast = Convert.IsDBNull(dataRow["IS_LAST"]) ? null : (System.Boolean?)dataRow["IS_LAST"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomWfRequestApprove"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomWfRequestApprove Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomWfRequestApprove entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AccomStudLeaveReqIdSource	
			if (CanDeepLoad(entity, "AccomStudLeaveReq|AccomStudLeaveReqIdSource", deepLoadType, innerList) 
				&& entity.AccomStudLeaveReqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AccomStudLeaveReqId ?? 0.0m);
				AccomStudLeaveReq tmpEntity = EntityManager.LocateEntity<AccomStudLeaveReq>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomStudLeaveReq), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomStudLeaveReqIdSource = tmpEntity;
				else
					entity.AccomStudLeaveReqIdSource = DataRepository.AccomStudLeaveReqProvider.GetByAccomStudLeaveReqId(transactionManager, (entity.AccomStudLeaveReqId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudLeaveReqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomStudLeaveReqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomStudLeaveReqProvider.DeepLoad(transactionManager, entity.AccomStudLeaveReqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomStudLeaveReqIdSource

			#region AccomStudReqIdSource	
			if (CanDeepLoad(entity, "AccomStudReq|AccomStudReqIdSource", deepLoadType, innerList) 
				&& entity.AccomStudReqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AccomStudReqId ?? 0.0m);
				AccomStudReq tmpEntity = EntityManager.LocateEntity<AccomStudReq>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomStudReq), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomStudReqIdSource = tmpEntity;
				else
					entity.AccomStudReqIdSource = DataRepository.AccomStudReqProvider.GetByAccomStudReqId(transactionManager, (entity.AccomStudReqId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudReqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomStudReqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomStudReqProvider.DeepLoad(transactionManager, entity.AccomStudReqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomStudReqIdSource

			#region AccomWfCdeActionIdSource	
			if (CanDeepLoad(entity, "AccomWfCdeAction|AccomWfCdeActionIdSource", deepLoadType, innerList) 
				&& entity.AccomWfCdeActionIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AccomWfCdeActionId;
				AccomWfCdeAction tmpEntity = EntityManager.LocateEntity<AccomWfCdeAction>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomWfCdeAction), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomWfCdeActionIdSource = tmpEntity;
				else
					entity.AccomWfCdeActionIdSource = DataRepository.AccomWfCdeActionProvider.GetByAccomWfCdeActionId(transactionManager, entity.AccomWfCdeActionId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomWfCdeActionIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomWfCdeActionIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomWfCdeActionProvider.DeepLoad(transactionManager, entity.AccomWfCdeActionIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomWfCdeActionIdSource

			#region AccomWfCdeFunctionIdSource	
			if (CanDeepLoad(entity, "AccomWfCdeFunction|AccomWfCdeFunctionIdSource", deepLoadType, innerList) 
				&& entity.AccomWfCdeFunctionIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AccomWfCdeFunctionId ?? (int)0);
				AccomWfCdeFunction tmpEntity = EntityManager.LocateEntity<AccomWfCdeFunction>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomWfCdeFunction), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomWfCdeFunctionIdSource = tmpEntity;
				else
					entity.AccomWfCdeFunctionIdSource = DataRepository.AccomWfCdeFunctionProvider.GetByAccomWfCdeFunctionId(transactionManager, (entity.AccomWfCdeFunctionId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomWfCdeFunctionIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomWfCdeFunctionIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomWfCdeFunctionProvider.DeepLoad(transactionManager, entity.AccomWfCdeFunctionIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomWfCdeFunctionIdSource

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

			#region SeCodeUserTypeIdSource	
			if (CanDeepLoad(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepLoadType, innerList) 
				&& entity.SeCodeUserTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeCodeUserTypeId;
				SeCodeUserType tmpEntity = EntityManager.LocateEntity<SeCodeUserType>(EntityLocator.ConstructKeyFromPkItems(typeof(SeCodeUserType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeCodeUserTypeIdSource = tmpEntity;
				else
					entity.SeCodeUserTypeIdSource = DataRepository.SeCodeUserTypeProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeId);		
				
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

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeUserId;
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, entity.SeUserId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomWfRequestApprove object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomWfRequestApprove instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomWfRequestApprove Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomWfRequestApprove entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AccomStudLeaveReqIdSource
			if (CanDeepSave(entity, "AccomStudLeaveReq|AccomStudLeaveReqIdSource", deepSaveType, innerList) 
				&& entity.AccomStudLeaveReqIdSource != null)
			{
				DataRepository.AccomStudLeaveReqProvider.Save(transactionManager, entity.AccomStudLeaveReqIdSource);
				entity.AccomStudLeaveReqId = entity.AccomStudLeaveReqIdSource.AccomStudLeaveReqId;
			}
			#endregion 
			
			#region AccomStudReqIdSource
			if (CanDeepSave(entity, "AccomStudReq|AccomStudReqIdSource", deepSaveType, innerList) 
				&& entity.AccomStudReqIdSource != null)
			{
				DataRepository.AccomStudReqProvider.Save(transactionManager, entity.AccomStudReqIdSource);
				entity.AccomStudReqId = entity.AccomStudReqIdSource.AccomStudReqId;
			}
			#endregion 
			
			#region AccomWfCdeActionIdSource
			if (CanDeepSave(entity, "AccomWfCdeAction|AccomWfCdeActionIdSource", deepSaveType, innerList) 
				&& entity.AccomWfCdeActionIdSource != null)
			{
				DataRepository.AccomWfCdeActionProvider.Save(transactionManager, entity.AccomWfCdeActionIdSource);
				entity.AccomWfCdeActionId = entity.AccomWfCdeActionIdSource.AccomWfCdeActionId;
			}
			#endregion 
			
			#region AccomWfCdeFunctionIdSource
			if (CanDeepSave(entity, "AccomWfCdeFunction|AccomWfCdeFunctionIdSource", deepSaveType, innerList) 
				&& entity.AccomWfCdeFunctionIdSource != null)
			{
				DataRepository.AccomWfCdeFunctionProvider.Save(transactionManager, entity.AccomWfCdeFunctionIdSource);
				entity.AccomWfCdeFunctionId = entity.AccomWfCdeFunctionIdSource.AccomWfCdeFunctionId;
			}
			#endregion 
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
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
			
			#region SeCodeUserTypeIdSource
			if (CanDeepSave(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepSaveType, innerList) 
				&& entity.SeCodeUserTypeIdSource != null)
			{
				DataRepository.SeCodeUserTypeProvider.Save(transactionManager, entity.SeCodeUserTypeIdSource);
				entity.SeCodeUserTypeId = entity.SeCodeUserTypeIdSource.SeCodeUserTypeId;
			}
			#endregion 
			
			#region SeUserIdSource
			if (CanDeepSave(entity, "SeUser|SeUserIdSource", deepSaveType, innerList) 
				&& entity.SeUserIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserIdSource);
				entity.SeUserId = entity.SeUserIdSource.SeUserId;
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
	
	#region AccomWfRequestApproveChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomWfRequestApprove</c>
	///</summary>
	public enum AccomWfRequestApproveChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AccomStudLeaveReq</c> at AccomStudLeaveReqIdSource
		///</summary>
		[ChildEntityType(typeof(AccomStudLeaveReq))]
		AccomStudLeaveReq,
		
		///<summary>
		/// Composite Property for <c>AccomStudReq</c> at AccomStudReqIdSource
		///</summary>
		[ChildEntityType(typeof(AccomStudReq))]
		AccomStudReq,
		
		///<summary>
		/// Composite Property for <c>AccomWfCdeAction</c> at AccomWfCdeActionIdSource
		///</summary>
		[ChildEntityType(typeof(AccomWfCdeAction))]
		AccomWfCdeAction,
		
		///<summary>
		/// Composite Property for <c>AccomWfCdeFunction</c> at AccomWfCdeFunctionIdSource
		///</summary>
		[ChildEntityType(typeof(AccomWfCdeFunction))]
		AccomWfCdeFunction,
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>SeCodeUserType</c> at SeCodeUserTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SeCodeUserType))]
		SeCodeUserType,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
	}
	
	#endregion AccomWfRequestApproveChildEntityTypes
	
	#region AccomWfRequestApproveFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomWfRequestApproveColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomWfRequestApprove"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomWfRequestApproveFilterBuilder : SqlFilterBuilder<AccomWfRequestApproveColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomWfRequestApproveFilterBuilder class.
		/// </summary>
		public AccomWfRequestApproveFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomWfRequestApproveFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomWfRequestApproveFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomWfRequestApproveFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomWfRequestApproveFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomWfRequestApproveFilterBuilder
	
	#region AccomWfRequestApproveParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomWfRequestApproveColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomWfRequestApprove"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomWfRequestApproveParameterBuilder : ParameterizedSqlFilterBuilder<AccomWfRequestApproveColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomWfRequestApproveParameterBuilder class.
		/// </summary>
		public AccomWfRequestApproveParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomWfRequestApproveParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomWfRequestApproveParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomWfRequestApproveParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomWfRequestApproveParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomWfRequestApproveParameterBuilder
	
	#region AccomWfRequestApproveSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomWfRequestApproveColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomWfRequestApprove"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomWfRequestApproveSortBuilder : SqlSortBuilder<AccomWfRequestApproveColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomWfRequestApproveSqlSortBuilder class.
		/// </summary>
		public AccomWfRequestApproveSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomWfRequestApproveSortBuilder
	
} // end namespace
