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
	/// This class is the base class for any <see cref="MltStudBhvrAttndcProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MltStudBhvrAttndcProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MltStudBhvrAttndc, UMIS_VER2.BusinessLyer.MltStudBhvrAttndcKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltStudBhvrAttndcKey key)
		{
			return Delete(transactionManager, key.MltStudBhvrAttndcId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mltStudBhvrAttndcId">متابعة خصم درجات سلوك ومواظبة طالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mltStudBhvrAttndcId)
		{
			return Delete(null, _mltStudBhvrAttndcId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltStudBhvrAttndcId">متابعة خصم درجات سلوك ومواظبة طالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mltStudBhvrAttndcId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_ABSENCE key.
		///		FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_ABSENCE Description: 
		/// </summary>
		/// <param name="_edStudAbsenceId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByEdStudAbsenceId(System.Decimal? _edStudAbsenceId)
		{
			int count = -1;
			return GetByEdStudAbsenceId(_edStudAbsenceId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_ABSENCE key.
		///		FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_ABSENCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudAbsenceId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		/// <remarks></remarks>
		public TList<MltStudBhvrAttndc> GetByEdStudAbsenceId(TransactionManager transactionManager, System.Decimal? _edStudAbsenceId)
		{
			int count = -1;
			return GetByEdStudAbsenceId(transactionManager, _edStudAbsenceId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_ABSENCE key.
		///		FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_ABSENCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByEdStudAbsenceId(TransactionManager transactionManager, System.Decimal? _edStudAbsenceId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudAbsenceId(transactionManager, _edStudAbsenceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_ABSENCE key.
		///		fkMltStudBhvrAttndcEdStudAbsence Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudAbsenceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByEdStudAbsenceId(System.Decimal? _edStudAbsenceId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudAbsenceId(null, _edStudAbsenceId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_ABSENCE key.
		///		fkMltStudBhvrAttndcEdStudAbsence Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudAbsenceId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByEdStudAbsenceId(System.Decimal? _edStudAbsenceId, int start, int pageLength,out int count)
		{
			return GetByEdStudAbsenceId(null, _edStudAbsenceId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_ABSENCE key.
		///		FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_ABSENCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public abstract TList<MltStudBhvrAttndc> GetByEdStudAbsenceId(TransactionManager transactionManager, System.Decimal? _edStudAbsenceId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_SEMESTER key.
		///		FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="_edStudSemesterId">مسلسل السجل الدراسي للطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByEdStudSemesterId(System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(_edStudSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_SEMESTER key.
		///		FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId">مسلسل السجل الدراسي للطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		/// <remarks></remarks>
		public TList<MltStudBhvrAttndc> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_SEMESTER key.
		///		FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId">مسلسل السجل الدراسي للطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_SEMESTER key.
		///		fkMltStudBhvrAttndcEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId">مسلسل السجل الدراسي للطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_SEMESTER key.
		///		fkMltStudBhvrAttndcEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId">مسلسل السجل الدراسي للطالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_SEMESTER key.
		///		FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId">مسلسل السجل الدراسي للطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public abstract TList<MltStudBhvrAttndc> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_VIOL key.
		///		FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_VIOL Description: 
		/// </summary>
		/// <param name="_edStudViolId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByEdStudViolId(System.Decimal? _edStudViolId)
		{
			int count = -1;
			return GetByEdStudViolId(_edStudViolId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_VIOL key.
		///		FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_VIOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		/// <remarks></remarks>
		public TList<MltStudBhvrAttndc> GetByEdStudViolId(TransactionManager transactionManager, System.Decimal? _edStudViolId)
		{
			int count = -1;
			return GetByEdStudViolId(transactionManager, _edStudViolId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_VIOL key.
		///		FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_VIOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByEdStudViolId(TransactionManager transactionManager, System.Decimal? _edStudViolId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudViolId(transactionManager, _edStudViolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_VIOL key.
		///		fkMltStudBhvrAttndcEdStudViol Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudViolId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByEdStudViolId(System.Decimal? _edStudViolId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudViolId(null, _edStudViolId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_VIOL key.
		///		fkMltStudBhvrAttndcEdStudViol Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudViolId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByEdStudViolId(System.Decimal? _edStudViolId, int start, int pageLength,out int count)
		{
			return GetByEdStudViolId(null, _edStudViolId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_VIOL key.
		///		FK_MLT_STUD_BHVR_ATTNDC_ED_STUD_VIOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public abstract TList<MltStudBhvrAttndc> GetByEdStudViolId(TransactionManager transactionManager, System.Decimal? _edStudViolId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_GS_CODE_PASS_FAIL key.
		///		FK_MLT_STUD_BHVR_ATTNDC_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="_gsCodePassFailId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(_gsCodePassFailId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_GS_CODE_PASS_FAIL key.
		///		FK_MLT_STUD_BHVR_ATTNDC_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		/// <remarks></remarks>
		public TList<MltStudBhvrAttndc> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_GS_CODE_PASS_FAIL key.
		///		FK_MLT_STUD_BHVR_ATTNDC_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_GS_CODE_PASS_FAIL key.
		///		fkMltStudBhvrAttndcGsCodePassFail Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_GS_CODE_PASS_FAIL key.
		///		fkMltStudBhvrAttndcGsCodePassFail Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId, int start, int pageLength,out int count)
		{
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_GS_CODE_PASS_FAIL key.
		///		FK_MLT_STUD_BHVR_ATTNDC_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public abstract TList<MltStudBhvrAttndc> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_CLNQ key.
		///		FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_CLNQ Description: 
		/// </summary>
		/// <param name="_mdiStudClnqId">بيانات طلب عيادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByMdiStudClnqId(System.Decimal? _mdiStudClnqId)
		{
			int count = -1;
			return GetByMdiStudClnqId(_mdiStudClnqId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_CLNQ key.
		///		FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_CLNQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudClnqId">بيانات طلب عيادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		/// <remarks></remarks>
		public TList<MltStudBhvrAttndc> GetByMdiStudClnqId(TransactionManager transactionManager, System.Decimal? _mdiStudClnqId)
		{
			int count = -1;
			return GetByMdiStudClnqId(transactionManager, _mdiStudClnqId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_CLNQ key.
		///		FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_CLNQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudClnqId">بيانات طلب عيادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByMdiStudClnqId(TransactionManager transactionManager, System.Decimal? _mdiStudClnqId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudClnqId(transactionManager, _mdiStudClnqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_CLNQ key.
		///		fkMltStudBhvrAttndcMdiStudClnq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiStudClnqId">بيانات طلب عيادة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByMdiStudClnqId(System.Decimal? _mdiStudClnqId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMdiStudClnqId(null, _mdiStudClnqId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_CLNQ key.
		///		fkMltStudBhvrAttndcMdiStudClnq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiStudClnqId">بيانات طلب عيادة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByMdiStudClnqId(System.Decimal? _mdiStudClnqId, int start, int pageLength,out int count)
		{
			return GetByMdiStudClnqId(null, _mdiStudClnqId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_CLNQ key.
		///		FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_CLNQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudClnqId">بيانات طلب عيادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public abstract TList<MltStudBhvrAttndc> GetByMdiStudClnqId(TransactionManager transactionManager, System.Decimal? _mdiStudClnqId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_HOSPTL key.
		///		FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_HOSPTL Description: 
		/// </summary>
		/// <param name="_mdiStudHosptlId">بيانات دخول مستشفى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByMdiStudHosptlId(System.Decimal? _mdiStudHosptlId)
		{
			int count = -1;
			return GetByMdiStudHosptlId(_mdiStudHosptlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_HOSPTL key.
		///		FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_HOSPTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudHosptlId">بيانات دخول مستشفى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		/// <remarks></remarks>
		public TList<MltStudBhvrAttndc> GetByMdiStudHosptlId(TransactionManager transactionManager, System.Decimal? _mdiStudHosptlId)
		{
			int count = -1;
			return GetByMdiStudHosptlId(transactionManager, _mdiStudHosptlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_HOSPTL key.
		///		FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_HOSPTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudHosptlId">بيانات دخول مستشفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByMdiStudHosptlId(TransactionManager transactionManager, System.Decimal? _mdiStudHosptlId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudHosptlId(transactionManager, _mdiStudHosptlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_HOSPTL key.
		///		fkMltStudBhvrAttndcMdiStudHosptl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiStudHosptlId">بيانات دخول مستشفى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByMdiStudHosptlId(System.Decimal? _mdiStudHosptlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMdiStudHosptlId(null, _mdiStudHosptlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_HOSPTL key.
		///		fkMltStudBhvrAttndcMdiStudHosptl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiStudHosptlId">بيانات دخول مستشفى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByMdiStudHosptlId(System.Decimal? _mdiStudHosptlId, int start, int pageLength,out int count)
		{
			return GetByMdiStudHosptlId(null, _mdiStudHosptlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_HOSPTL key.
		///		FK_MLT_STUD_BHVR_ATTNDC_MDI_STUD_HOSPTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudHosptlId">بيانات دخول مستشفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public abstract TList<MltStudBhvrAttndc> GetByMdiStudHosptlId(TransactionManager transactionManager, System.Decimal? _mdiStudHosptlId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MLT_CDE_BHVR_ATTNDC_RLTD key.
		///		FK_MLT_STUD_BHVR_ATTNDC_MLT_CDE_BHVR_ATTNDC_RLTD Description: 
		/// </summary>
		/// <param name="_mltCdeBhvrAttndcRltdId">سبب  الخصم من السلوك والمواظبة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByMltCdeBhvrAttndcRltdId(System.Decimal? _mltCdeBhvrAttndcRltdId)
		{
			int count = -1;
			return GetByMltCdeBhvrAttndcRltdId(_mltCdeBhvrAttndcRltdId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MLT_CDE_BHVR_ATTNDC_RLTD key.
		///		FK_MLT_STUD_BHVR_ATTNDC_MLT_CDE_BHVR_ATTNDC_RLTD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeBhvrAttndcRltdId">سبب  الخصم من السلوك والمواظبة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		/// <remarks></remarks>
		public TList<MltStudBhvrAttndc> GetByMltCdeBhvrAttndcRltdId(TransactionManager transactionManager, System.Decimal? _mltCdeBhvrAttndcRltdId)
		{
			int count = -1;
			return GetByMltCdeBhvrAttndcRltdId(transactionManager, _mltCdeBhvrAttndcRltdId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MLT_CDE_BHVR_ATTNDC_RLTD key.
		///		FK_MLT_STUD_BHVR_ATTNDC_MLT_CDE_BHVR_ATTNDC_RLTD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeBhvrAttndcRltdId">سبب  الخصم من السلوك والمواظبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByMltCdeBhvrAttndcRltdId(TransactionManager transactionManager, System.Decimal? _mltCdeBhvrAttndcRltdId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltCdeBhvrAttndcRltdId(transactionManager, _mltCdeBhvrAttndcRltdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MLT_CDE_BHVR_ATTNDC_RLTD key.
		///		fkMltStudBhvrAttndcMltCdeBhvrAttndcRltd Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltCdeBhvrAttndcRltdId">سبب  الخصم من السلوك والمواظبة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByMltCdeBhvrAttndcRltdId(System.Decimal? _mltCdeBhvrAttndcRltdId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMltCdeBhvrAttndcRltdId(null, _mltCdeBhvrAttndcRltdId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MLT_CDE_BHVR_ATTNDC_RLTD key.
		///		fkMltStudBhvrAttndcMltCdeBhvrAttndcRltd Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltCdeBhvrAttndcRltdId">سبب  الخصم من السلوك والمواظبة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByMltCdeBhvrAttndcRltdId(System.Decimal? _mltCdeBhvrAttndcRltdId, int start, int pageLength,out int count)
		{
			return GetByMltCdeBhvrAttndcRltdId(null, _mltCdeBhvrAttndcRltdId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MLT_CDE_BHVR_ATTNDC_RLTD key.
		///		FK_MLT_STUD_BHVR_ATTNDC_MLT_CDE_BHVR_ATTNDC_RLTD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeBhvrAttndcRltdId">سبب  الخصم من السلوك والمواظبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public abstract TList<MltStudBhvrAttndc> GetByMltCdeBhvrAttndcRltdId(TransactionManager transactionManager, System.Decimal? _mltCdeBhvrAttndcRltdId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MLT_LVL_BHVR_ATTNDC key.
		///		FK_MLT_STUD_BHVR_ATTNDC_MLT_LVL_BHVR_ATTNDC Description: 
		/// </summary>
		/// <param name="_mltLvlBhvrAttndcId">درجات السلوك والمواظبة لكل فصل مستوى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByMltLvlBhvrAttndcId(System.Decimal _mltLvlBhvrAttndcId)
		{
			int count = -1;
			return GetByMltLvlBhvrAttndcId(_mltLvlBhvrAttndcId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MLT_LVL_BHVR_ATTNDC key.
		///		FK_MLT_STUD_BHVR_ATTNDC_MLT_LVL_BHVR_ATTNDC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltLvlBhvrAttndcId">درجات السلوك والمواظبة لكل فصل مستوى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		/// <remarks></remarks>
		public TList<MltStudBhvrAttndc> GetByMltLvlBhvrAttndcId(TransactionManager transactionManager, System.Decimal _mltLvlBhvrAttndcId)
		{
			int count = -1;
			return GetByMltLvlBhvrAttndcId(transactionManager, _mltLvlBhvrAttndcId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MLT_LVL_BHVR_ATTNDC key.
		///		FK_MLT_STUD_BHVR_ATTNDC_MLT_LVL_BHVR_ATTNDC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltLvlBhvrAttndcId">درجات السلوك والمواظبة لكل فصل مستوى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByMltLvlBhvrAttndcId(TransactionManager transactionManager, System.Decimal _mltLvlBhvrAttndcId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltLvlBhvrAttndcId(transactionManager, _mltLvlBhvrAttndcId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MLT_LVL_BHVR_ATTNDC key.
		///		fkMltStudBhvrAttndcMltLvlBhvrAttndc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltLvlBhvrAttndcId">درجات السلوك والمواظبة لكل فصل مستوى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByMltLvlBhvrAttndcId(System.Decimal _mltLvlBhvrAttndcId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMltLvlBhvrAttndcId(null, _mltLvlBhvrAttndcId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MLT_LVL_BHVR_ATTNDC key.
		///		fkMltStudBhvrAttndcMltLvlBhvrAttndc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltLvlBhvrAttndcId">درجات السلوك والمواظبة لكل فصل مستوى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public TList<MltStudBhvrAttndc> GetByMltLvlBhvrAttndcId(System.Decimal _mltLvlBhvrAttndcId, int start, int pageLength,out int count)
		{
			return GetByMltLvlBhvrAttndcId(null, _mltLvlBhvrAttndcId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_BHVR_ATTNDC_MLT_LVL_BHVR_ATTNDC key.
		///		FK_MLT_STUD_BHVR_ATTNDC_MLT_LVL_BHVR_ATTNDC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltLvlBhvrAttndcId">درجات السلوك والمواظبة لكل فصل مستوى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudBhvrAttndc objects.</returns>
		public abstract TList<MltStudBhvrAttndc> GetByMltLvlBhvrAttndcId(TransactionManager transactionManager, System.Decimal _mltLvlBhvrAttndcId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.MltStudBhvrAttndc Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltStudBhvrAttndcKey key, int start, int pageLength)
		{
			return GetByMltStudBhvrAttndcId(transactionManager, key.MltStudBhvrAttndcId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MLT_STUD_BHVR_ATTNDC index.
		/// </summary>
		/// <param name="_mltStudBhvrAttndcId">متابعة خصم درجات سلوك ومواظبة طالب</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltStudBhvrAttndc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltStudBhvrAttndc GetByMltStudBhvrAttndcId(System.Decimal _mltStudBhvrAttndcId)
		{
			int count = -1;
			return GetByMltStudBhvrAttndcId(null,_mltStudBhvrAttndcId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_STUD_BHVR_ATTNDC index.
		/// </summary>
		/// <param name="_mltStudBhvrAttndcId">متابعة خصم درجات سلوك ومواظبة طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltStudBhvrAttndc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltStudBhvrAttndc GetByMltStudBhvrAttndcId(System.Decimal _mltStudBhvrAttndcId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltStudBhvrAttndcId(null, _mltStudBhvrAttndcId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_STUD_BHVR_ATTNDC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltStudBhvrAttndcId">متابعة خصم درجات سلوك ومواظبة طالب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltStudBhvrAttndc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltStudBhvrAttndc GetByMltStudBhvrAttndcId(TransactionManager transactionManager, System.Decimal _mltStudBhvrAttndcId)
		{
			int count = -1;
			return GetByMltStudBhvrAttndcId(transactionManager, _mltStudBhvrAttndcId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_STUD_BHVR_ATTNDC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltStudBhvrAttndcId">متابعة خصم درجات سلوك ومواظبة طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltStudBhvrAttndc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltStudBhvrAttndc GetByMltStudBhvrAttndcId(TransactionManager transactionManager, System.Decimal _mltStudBhvrAttndcId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltStudBhvrAttndcId(transactionManager, _mltStudBhvrAttndcId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_STUD_BHVR_ATTNDC index.
		/// </summary>
		/// <param name="_mltStudBhvrAttndcId">متابعة خصم درجات سلوك ومواظبة طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltStudBhvrAttndc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltStudBhvrAttndc GetByMltStudBhvrAttndcId(System.Decimal _mltStudBhvrAttndcId, int start, int pageLength, out int count)
		{
			return GetByMltStudBhvrAttndcId(null, _mltStudBhvrAttndcId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_STUD_BHVR_ATTNDC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltStudBhvrAttndcId">متابعة خصم درجات سلوك ومواظبة طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltStudBhvrAttndc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MltStudBhvrAttndc GetByMltStudBhvrAttndcId(TransactionManager transactionManager, System.Decimal _mltStudBhvrAttndcId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MltStudBhvrAttndc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MltStudBhvrAttndc&gt;"/></returns>
		public static TList<MltStudBhvrAttndc> Fill(IDataReader reader, TList<MltStudBhvrAttndc> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MltStudBhvrAttndc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MltStudBhvrAttndc")
					.Append("|").Append((System.Decimal)reader["MLT_STUD_BHVR_ATTNDC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MltStudBhvrAttndc>(
					key.ToString(), // EntityTrackingKey
					"MltStudBhvrAttndc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MltStudBhvrAttndc();
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
					c.MltStudBhvrAttndcId = (System.Decimal)reader["MLT_STUD_BHVR_ATTNDC_ID"];
					c.OriginalMltStudBhvrAttndcId = c.MltStudBhvrAttndcId;
					c.EdStudSemesterId = (System.Decimal)reader["ED_STUD_SEMESTER_ID"];
					c.BhvrAttndcFlg = Convert.IsDBNull(reader["BHVR_ATTNDC_FLG"]) ? null : (System.Decimal?)reader["BHVR_ATTNDC_FLG"];
					c.MltLvlBhvrAttndcId = (System.Decimal)reader["MLT_LVL_BHVR_ATTNDC_ID"];
					c.NoDays = Convert.IsDBNull(reader["NO_DAYS"]) ? null : (System.Decimal?)reader["NO_DAYS"];
					c.FromDate = Convert.IsDBNull(reader["FROM_DATE"]) ? null : (System.DateTime?)reader["FROM_DATE"];
					c.ToDate = Convert.IsDBNull(reader["TO_DATE"]) ? null : (System.DateTime?)reader["TO_DATE"];
					c.DeductMark = Convert.IsDBNull(reader["DEDUCT_MARK"]) ? null : (System.Decimal?)reader["DEDUCT_MARK"];
					c.MltCdeBhvrAttndcRltdId = Convert.IsDBNull(reader["MLT_CDE_BHVR_ATTNDC_RLTD_ID"]) ? null : (System.Decimal?)reader["MLT_CDE_BHVR_ATTNDC_RLTD_ID"];
					c.DeductDate = Convert.IsDBNull(reader["DEDUCT_DATE"]) ? null : (System.DateTime?)reader["DEDUCT_DATE"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.GsCodePassFailId = Convert.IsDBNull(reader["GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)reader["GS_CODE_PASS_FAIL_ID"];
					c.EdStudViolId = Convert.IsDBNull(reader["ED_STUD_VIOL_ID"]) ? null : (System.Decimal?)reader["ED_STUD_VIOL_ID"];
					c.EdStudAbsenceId = Convert.IsDBNull(reader["ED_STUD_ABSENCE_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ABSENCE_ID"];
					c.MdiStudClnqId = Convert.IsDBNull(reader["MDI_STUD_CLNQ_ID"]) ? null : (System.Decimal?)reader["MDI_STUD_CLNQ_ID"];
					c.MdiStudHosptlId = Convert.IsDBNull(reader["MDI_STUD_HOSPTL_ID"]) ? null : (System.Decimal?)reader["MDI_STUD_HOSPTL_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltStudBhvrAttndc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltStudBhvrAttndc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MltStudBhvrAttndc entity)
		{
			if (!reader.Read()) return;
			
			entity.MltStudBhvrAttndcId = (System.Decimal)reader[((int)MltStudBhvrAttndcColumn.MltStudBhvrAttndcId - 1)];
			entity.OriginalMltStudBhvrAttndcId = (System.Decimal)reader["MLT_STUD_BHVR_ATTNDC_ID"];
			entity.EdStudSemesterId = (System.Decimal)reader[((int)MltStudBhvrAttndcColumn.EdStudSemesterId - 1)];
			entity.BhvrAttndcFlg = (reader.IsDBNull(((int)MltStudBhvrAttndcColumn.BhvrAttndcFlg - 1)))?null:(System.Decimal?)reader[((int)MltStudBhvrAttndcColumn.BhvrAttndcFlg - 1)];
			entity.MltLvlBhvrAttndcId = (System.Decimal)reader[((int)MltStudBhvrAttndcColumn.MltLvlBhvrAttndcId - 1)];
			entity.NoDays = (reader.IsDBNull(((int)MltStudBhvrAttndcColumn.NoDays - 1)))?null:(System.Decimal?)reader[((int)MltStudBhvrAttndcColumn.NoDays - 1)];
			entity.FromDate = (reader.IsDBNull(((int)MltStudBhvrAttndcColumn.FromDate - 1)))?null:(System.DateTime?)reader[((int)MltStudBhvrAttndcColumn.FromDate - 1)];
			entity.ToDate = (reader.IsDBNull(((int)MltStudBhvrAttndcColumn.ToDate - 1)))?null:(System.DateTime?)reader[((int)MltStudBhvrAttndcColumn.ToDate - 1)];
			entity.DeductMark = (reader.IsDBNull(((int)MltStudBhvrAttndcColumn.DeductMark - 1)))?null:(System.Decimal?)reader[((int)MltStudBhvrAttndcColumn.DeductMark - 1)];
			entity.MltCdeBhvrAttndcRltdId = (reader.IsDBNull(((int)MltStudBhvrAttndcColumn.MltCdeBhvrAttndcRltdId - 1)))?null:(System.Decimal?)reader[((int)MltStudBhvrAttndcColumn.MltCdeBhvrAttndcRltdId - 1)];
			entity.DeductDate = (reader.IsDBNull(((int)MltStudBhvrAttndcColumn.DeductDate - 1)))?null:(System.DateTime?)reader[((int)MltStudBhvrAttndcColumn.DeductDate - 1)];
			entity.Notes = (reader.IsDBNull(((int)MltStudBhvrAttndcColumn.Notes - 1)))?null:(System.String)reader[((int)MltStudBhvrAttndcColumn.Notes - 1)];
			entity.GsCodePassFailId = (reader.IsDBNull(((int)MltStudBhvrAttndcColumn.GsCodePassFailId - 1)))?null:(System.Decimal?)reader[((int)MltStudBhvrAttndcColumn.GsCodePassFailId - 1)];
			entity.EdStudViolId = (reader.IsDBNull(((int)MltStudBhvrAttndcColumn.EdStudViolId - 1)))?null:(System.Decimal?)reader[((int)MltStudBhvrAttndcColumn.EdStudViolId - 1)];
			entity.EdStudAbsenceId = (reader.IsDBNull(((int)MltStudBhvrAttndcColumn.EdStudAbsenceId - 1)))?null:(System.Decimal?)reader[((int)MltStudBhvrAttndcColumn.EdStudAbsenceId - 1)];
			entity.MdiStudClnqId = (reader.IsDBNull(((int)MltStudBhvrAttndcColumn.MdiStudClnqId - 1)))?null:(System.Decimal?)reader[((int)MltStudBhvrAttndcColumn.MdiStudClnqId - 1)];
			entity.MdiStudHosptlId = (reader.IsDBNull(((int)MltStudBhvrAttndcColumn.MdiStudHosptlId - 1)))?null:(System.Decimal?)reader[((int)MltStudBhvrAttndcColumn.MdiStudHosptlId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltStudBhvrAttndc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltStudBhvrAttndc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MltStudBhvrAttndc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MltStudBhvrAttndcId = (System.Decimal)dataRow["MLT_STUD_BHVR_ATTNDC_ID"];
			entity.OriginalMltStudBhvrAttndcId = (System.Decimal)dataRow["MLT_STUD_BHVR_ATTNDC_ID"];
			entity.EdStudSemesterId = (System.Decimal)dataRow["ED_STUD_SEMESTER_ID"];
			entity.BhvrAttndcFlg = Convert.IsDBNull(dataRow["BHVR_ATTNDC_FLG"]) ? null : (System.Decimal?)dataRow["BHVR_ATTNDC_FLG"];
			entity.MltLvlBhvrAttndcId = (System.Decimal)dataRow["MLT_LVL_BHVR_ATTNDC_ID"];
			entity.NoDays = Convert.IsDBNull(dataRow["NO_DAYS"]) ? null : (System.Decimal?)dataRow["NO_DAYS"];
			entity.FromDate = Convert.IsDBNull(dataRow["FROM_DATE"]) ? null : (System.DateTime?)dataRow["FROM_DATE"];
			entity.ToDate = Convert.IsDBNull(dataRow["TO_DATE"]) ? null : (System.DateTime?)dataRow["TO_DATE"];
			entity.DeductMark = Convert.IsDBNull(dataRow["DEDUCT_MARK"]) ? null : (System.Decimal?)dataRow["DEDUCT_MARK"];
			entity.MltCdeBhvrAttndcRltdId = Convert.IsDBNull(dataRow["MLT_CDE_BHVR_ATTNDC_RLTD_ID"]) ? null : (System.Decimal?)dataRow["MLT_CDE_BHVR_ATTNDC_RLTD_ID"];
			entity.DeductDate = Convert.IsDBNull(dataRow["DEDUCT_DATE"]) ? null : (System.DateTime?)dataRow["DEDUCT_DATE"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.GsCodePassFailId = Convert.IsDBNull(dataRow["GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_PASS_FAIL_ID"];
			entity.EdStudViolId = Convert.IsDBNull(dataRow["ED_STUD_VIOL_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_VIOL_ID"];
			entity.EdStudAbsenceId = Convert.IsDBNull(dataRow["ED_STUD_ABSENCE_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ABSENCE_ID"];
			entity.MdiStudClnqId = Convert.IsDBNull(dataRow["MDI_STUD_CLNQ_ID"]) ? null : (System.Decimal?)dataRow["MDI_STUD_CLNQ_ID"];
			entity.MdiStudHosptlId = Convert.IsDBNull(dataRow["MDI_STUD_HOSPTL_ID"]) ? null : (System.Decimal?)dataRow["MDI_STUD_HOSPTL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltStudBhvrAttndc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltStudBhvrAttndc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltStudBhvrAttndc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudAbsenceIdSource	
			if (CanDeepLoad(entity, "EdStudAbsence|EdStudAbsenceIdSource", deepLoadType, innerList) 
				&& entity.EdStudAbsenceIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudAbsenceId ?? 0.0m);
				EdStudAbsence tmpEntity = EntityManager.LocateEntity<EdStudAbsence>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudAbsence), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudAbsenceIdSource = tmpEntity;
				else
					entity.EdStudAbsenceIdSource = DataRepository.EdStudAbsenceProvider.GetByEdStudAbsenceId(transactionManager, (entity.EdStudAbsenceId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAbsenceIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudAbsenceIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudAbsenceProvider.DeepLoad(transactionManager, entity.EdStudAbsenceIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudAbsenceIdSource

			#region EdStudSemesterIdSource	
			if (CanDeepLoad(entity, "EdStudSemester|EdStudSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdStudSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudSemesterId;
				EdStudSemester tmpEntity = EntityManager.LocateEntity<EdStudSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudSemesterIdSource = tmpEntity;
				else
					entity.EdStudSemesterIdSource = DataRepository.EdStudSemesterProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudSemesterProvider.DeepLoad(transactionManager, entity.EdStudSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudSemesterIdSource

			#region EdStudViolIdSource	
			if (CanDeepLoad(entity, "EdStudViol|EdStudViolIdSource", deepLoadType, innerList) 
				&& entity.EdStudViolIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudViolId ?? 0.0m);
				EdStudViol tmpEntity = EntityManager.LocateEntity<EdStudViol>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudViol), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudViolIdSource = tmpEntity;
				else
					entity.EdStudViolIdSource = DataRepository.EdStudViolProvider.GetByEdStudViolId(transactionManager, (entity.EdStudViolId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudViolIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudViolProvider.DeepLoad(transactionManager, entity.EdStudViolIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudViolIdSource

			#region GsCodePassFailIdSource	
			if (CanDeepLoad(entity, "GsCodePassFail|GsCodePassFailIdSource", deepLoadType, innerList) 
				&& entity.GsCodePassFailIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodePassFailId ?? 0.0m);
				GsCodePassFail tmpEntity = EntityManager.LocateEntity<GsCodePassFail>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodePassFail), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodePassFailIdSource = tmpEntity;
				else
					entity.GsCodePassFailIdSource = DataRepository.GsCodePassFailProvider.GetByGsCodePassFailId(transactionManager, (entity.GsCodePassFailId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodePassFailIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodePassFailIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodePassFailProvider.DeepLoad(transactionManager, entity.GsCodePassFailIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodePassFailIdSource

			#region MdiStudClnqIdSource	
			if (CanDeepLoad(entity, "MdiStudClnq|MdiStudClnqIdSource", deepLoadType, innerList) 
				&& entity.MdiStudClnqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MdiStudClnqId ?? 0.0m);
				MdiStudClnq tmpEntity = EntityManager.LocateEntity<MdiStudClnq>(EntityLocator.ConstructKeyFromPkItems(typeof(MdiStudClnq), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MdiStudClnqIdSource = tmpEntity;
				else
					entity.MdiStudClnqIdSource = DataRepository.MdiStudClnqProvider.GetByMdiStudClnqId(transactionManager, (entity.MdiStudClnqId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudClnqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MdiStudClnqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MdiStudClnqProvider.DeepLoad(transactionManager, entity.MdiStudClnqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MdiStudClnqIdSource

			#region MdiStudHosptlIdSource	
			if (CanDeepLoad(entity, "MdiStudHosptl|MdiStudHosptlIdSource", deepLoadType, innerList) 
				&& entity.MdiStudHosptlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MdiStudHosptlId ?? 0.0m);
				MdiStudHosptl tmpEntity = EntityManager.LocateEntity<MdiStudHosptl>(EntityLocator.ConstructKeyFromPkItems(typeof(MdiStudHosptl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MdiStudHosptlIdSource = tmpEntity;
				else
					entity.MdiStudHosptlIdSource = DataRepository.MdiStudHosptlProvider.GetByMdiStudHosptlId(transactionManager, (entity.MdiStudHosptlId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudHosptlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MdiStudHosptlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MdiStudHosptlProvider.DeepLoad(transactionManager, entity.MdiStudHosptlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MdiStudHosptlIdSource

			#region MltCdeBhvrAttndcRltdIdSource	
			if (CanDeepLoad(entity, "MltCdeBhvrAttndcRltd|MltCdeBhvrAttndcRltdIdSource", deepLoadType, innerList) 
				&& entity.MltCdeBhvrAttndcRltdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MltCdeBhvrAttndcRltdId ?? 0.0m);
				MltCdeBhvrAttndcRltd tmpEntity = EntityManager.LocateEntity<MltCdeBhvrAttndcRltd>(EntityLocator.ConstructKeyFromPkItems(typeof(MltCdeBhvrAttndcRltd), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MltCdeBhvrAttndcRltdIdSource = tmpEntity;
				else
					entity.MltCdeBhvrAttndcRltdIdSource = DataRepository.MltCdeBhvrAttndcRltdProvider.GetByMltCdeBhvrAttndcRltdId(transactionManager, (entity.MltCdeBhvrAttndcRltdId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltCdeBhvrAttndcRltdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MltCdeBhvrAttndcRltdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MltCdeBhvrAttndcRltdProvider.DeepLoad(transactionManager, entity.MltCdeBhvrAttndcRltdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MltCdeBhvrAttndcRltdIdSource

			#region MltLvlBhvrAttndcIdSource	
			if (CanDeepLoad(entity, "MltLvlBhvrAttndc|MltLvlBhvrAttndcIdSource", deepLoadType, innerList) 
				&& entity.MltLvlBhvrAttndcIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MltLvlBhvrAttndcId;
				MltLvlBhvrAttndc tmpEntity = EntityManager.LocateEntity<MltLvlBhvrAttndc>(EntityLocator.ConstructKeyFromPkItems(typeof(MltLvlBhvrAttndc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MltLvlBhvrAttndcIdSource = tmpEntity;
				else
					entity.MltLvlBhvrAttndcIdSource = DataRepository.MltLvlBhvrAttndcProvider.GetByMltLvlBhvrAttndcId(transactionManager, entity.MltLvlBhvrAttndcId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltLvlBhvrAttndcIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MltLvlBhvrAttndcIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MltLvlBhvrAttndcProvider.DeepLoad(transactionManager, entity.MltLvlBhvrAttndcIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MltLvlBhvrAttndcIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MltStudBhvrAttndc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MltStudBhvrAttndc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltStudBhvrAttndc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltStudBhvrAttndc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudAbsenceIdSource
			if (CanDeepSave(entity, "EdStudAbsence|EdStudAbsenceIdSource", deepSaveType, innerList) 
				&& entity.EdStudAbsenceIdSource != null)
			{
				DataRepository.EdStudAbsenceProvider.Save(transactionManager, entity.EdStudAbsenceIdSource);
				entity.EdStudAbsenceId = entity.EdStudAbsenceIdSource.EdStudAbsenceId;
			}
			#endregion 
			
			#region EdStudSemesterIdSource
			if (CanDeepSave(entity, "EdStudSemester|EdStudSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdStudSemesterIdSource != null)
			{
				DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterIdSource);
				entity.EdStudSemesterId = entity.EdStudSemesterIdSource.EdStudSemesterId;
			}
			#endregion 
			
			#region EdStudViolIdSource
			if (CanDeepSave(entity, "EdStudViol|EdStudViolIdSource", deepSaveType, innerList) 
				&& entity.EdStudViolIdSource != null)
			{
				DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolIdSource);
				entity.EdStudViolId = entity.EdStudViolIdSource.EdStudViolId;
			}
			#endregion 
			
			#region GsCodePassFailIdSource
			if (CanDeepSave(entity, "GsCodePassFail|GsCodePassFailIdSource", deepSaveType, innerList) 
				&& entity.GsCodePassFailIdSource != null)
			{
				DataRepository.GsCodePassFailProvider.Save(transactionManager, entity.GsCodePassFailIdSource);
				entity.GsCodePassFailId = entity.GsCodePassFailIdSource.GsCodePassFailId;
			}
			#endregion 
			
			#region MdiStudClnqIdSource
			if (CanDeepSave(entity, "MdiStudClnq|MdiStudClnqIdSource", deepSaveType, innerList) 
				&& entity.MdiStudClnqIdSource != null)
			{
				DataRepository.MdiStudClnqProvider.Save(transactionManager, entity.MdiStudClnqIdSource);
				entity.MdiStudClnqId = entity.MdiStudClnqIdSource.MdiStudClnqId;
			}
			#endregion 
			
			#region MdiStudHosptlIdSource
			if (CanDeepSave(entity, "MdiStudHosptl|MdiStudHosptlIdSource", deepSaveType, innerList) 
				&& entity.MdiStudHosptlIdSource != null)
			{
				DataRepository.MdiStudHosptlProvider.Save(transactionManager, entity.MdiStudHosptlIdSource);
				entity.MdiStudHosptlId = entity.MdiStudHosptlIdSource.MdiStudHosptlId;
			}
			#endregion 
			
			#region MltCdeBhvrAttndcRltdIdSource
			if (CanDeepSave(entity, "MltCdeBhvrAttndcRltd|MltCdeBhvrAttndcRltdIdSource", deepSaveType, innerList) 
				&& entity.MltCdeBhvrAttndcRltdIdSource != null)
			{
				DataRepository.MltCdeBhvrAttndcRltdProvider.Save(transactionManager, entity.MltCdeBhvrAttndcRltdIdSource);
				entity.MltCdeBhvrAttndcRltdId = entity.MltCdeBhvrAttndcRltdIdSource.MltCdeBhvrAttndcRltdId;
			}
			#endregion 
			
			#region MltLvlBhvrAttndcIdSource
			if (CanDeepSave(entity, "MltLvlBhvrAttndc|MltLvlBhvrAttndcIdSource", deepSaveType, innerList) 
				&& entity.MltLvlBhvrAttndcIdSource != null)
			{
				DataRepository.MltLvlBhvrAttndcProvider.Save(transactionManager, entity.MltLvlBhvrAttndcIdSource);
				entity.MltLvlBhvrAttndcId = entity.MltLvlBhvrAttndcIdSource.MltLvlBhvrAttndcId;
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
	
	#region MltStudBhvrAttndcChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MltStudBhvrAttndc</c>
	///</summary>
	public enum MltStudBhvrAttndcChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStudAbsence</c> at EdStudAbsenceIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudAbsence))]
		EdStudAbsence,
		
		///<summary>
		/// Composite Property for <c>EdStudSemester</c> at EdStudSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudSemester))]
		EdStudSemester,
		
		///<summary>
		/// Composite Property for <c>EdStudViol</c> at EdStudViolIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudViol))]
		EdStudViol,
		
		///<summary>
		/// Composite Property for <c>GsCodePassFail</c> at GsCodePassFailIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodePassFail))]
		GsCodePassFail,
		
		///<summary>
		/// Composite Property for <c>MdiStudClnq</c> at MdiStudClnqIdSource
		///</summary>
		[ChildEntityType(typeof(MdiStudClnq))]
		MdiStudClnq,
		
		///<summary>
		/// Composite Property for <c>MdiStudHosptl</c> at MdiStudHosptlIdSource
		///</summary>
		[ChildEntityType(typeof(MdiStudHosptl))]
		MdiStudHosptl,
		
		///<summary>
		/// Composite Property for <c>MltCdeBhvrAttndcRltd</c> at MltCdeBhvrAttndcRltdIdSource
		///</summary>
		[ChildEntityType(typeof(MltCdeBhvrAttndcRltd))]
		MltCdeBhvrAttndcRltd,
		
		///<summary>
		/// Composite Property for <c>MltLvlBhvrAttndc</c> at MltLvlBhvrAttndcIdSource
		///</summary>
		[ChildEntityType(typeof(MltLvlBhvrAttndc))]
		MltLvlBhvrAttndc,
	}
	
	#endregion MltStudBhvrAttndcChildEntityTypes
	
	#region MltStudBhvrAttndcFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MltStudBhvrAttndcColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltStudBhvrAttndc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltStudBhvrAttndcFilterBuilder : SqlFilterBuilder<MltStudBhvrAttndcColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltStudBhvrAttndcFilterBuilder class.
		/// </summary>
		public MltStudBhvrAttndcFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltStudBhvrAttndcFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltStudBhvrAttndcFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltStudBhvrAttndcFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltStudBhvrAttndcFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltStudBhvrAttndcFilterBuilder
	
	#region MltStudBhvrAttndcParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MltStudBhvrAttndcColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltStudBhvrAttndc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltStudBhvrAttndcParameterBuilder : ParameterizedSqlFilterBuilder<MltStudBhvrAttndcColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltStudBhvrAttndcParameterBuilder class.
		/// </summary>
		public MltStudBhvrAttndcParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltStudBhvrAttndcParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltStudBhvrAttndcParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltStudBhvrAttndcParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltStudBhvrAttndcParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltStudBhvrAttndcParameterBuilder
	
	#region MltStudBhvrAttndcSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MltStudBhvrAttndcColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltStudBhvrAttndc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MltStudBhvrAttndcSortBuilder : SqlSortBuilder<MltStudBhvrAttndcColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltStudBhvrAttndcSqlSortBuilder class.
		/// </summary>
		public MltStudBhvrAttndcSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MltStudBhvrAttndcSortBuilder
	
} // end namespace
