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
	/// This class is the base class for any <see cref="TrnsStudReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TrnsStudReqProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.TrnsStudReq, UMIS_VER2.BusinessLyer.TrnsStudReqKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsStudReqKey key)
		{
			return Delete(transactionManager, key.TrnsStudReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_trnsStudReqId">طلبات اشتراك الباص. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _trnsStudReqId)
		{
			return Delete(null, _trnsStudReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsStudReqId">طلبات اشتراك الباص. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _trnsStudReqId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_ED_ACAD_YEAR key.
		///		FK_TRNS_LINE_STUD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_ED_ACAD_YEAR key.
		///		FK_TRNS_LINE_STUD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsStudReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_ED_ACAD_YEAR key.
		///		FK_TRNS_LINE_STUD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_ED_ACAD_YEAR key.
		///		fkTrnsLineStudEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_ED_ACAD_YEAR key.
		///		fkTrnsLineStudEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_ED_ACAD_YEAR key.
		///		FK_TRNS_LINE_STUD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public abstract TList<TrnsStudReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_ED_CODE_SEMESTER key.
		///		FK_TRNS_LINE_STUD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_ED_CODE_SEMESTER key.
		///		FK_TRNS_LINE_STUD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsStudReq> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_ED_CODE_SEMESTER key.
		///		FK_TRNS_LINE_STUD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_ED_CODE_SEMESTER key.
		///		fkTrnsLineStudEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_ED_CODE_SEMESTER key.
		///		fkTrnsLineStudEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_ED_CODE_SEMESTER key.
		///		FK_TRNS_LINE_STUD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public abstract TList<TrnsStudReq> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_ED_STUD key.
		///		FK_TRNS_LINE_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_ED_STUD key.
		///		FK_TRNS_LINE_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsStudReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_ED_STUD key.
		///		FK_TRNS_LINE_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_ED_STUD key.
		///		fkTrnsLineStudEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_ED_STUD key.
		///		fkTrnsLineStudEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_ED_STUD key.
		///		FK_TRNS_LINE_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public abstract TList<TrnsStudReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_TRNS_LINE_STOP key.
		///		FK_TRNS_LINE_STUD_TRNS_LINE_STOP Description: 
		/// </summary>
		/// <param name="_trnsCdeStopId">اسم المحطة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByTrnsCdeStopId(System.Decimal? _trnsCdeStopId)
		{
			int count = -1;
			return GetByTrnsCdeStopId(_trnsCdeStopId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_TRNS_LINE_STOP key.
		///		FK_TRNS_LINE_STUD_TRNS_LINE_STOP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeStopId">اسم المحطة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsStudReq> GetByTrnsCdeStopId(TransactionManager transactionManager, System.Decimal? _trnsCdeStopId)
		{
			int count = -1;
			return GetByTrnsCdeStopId(transactionManager, _trnsCdeStopId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_TRNS_LINE_STOP key.
		///		FK_TRNS_LINE_STUD_TRNS_LINE_STOP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeStopId">اسم المحطة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByTrnsCdeStopId(TransactionManager transactionManager, System.Decimal? _trnsCdeStopId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsCdeStopId(transactionManager, _trnsCdeStopId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_TRNS_LINE_STOP key.
		///		fkTrnsLineStudTrnsLineStop Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_trnsCdeStopId">اسم المحطة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByTrnsCdeStopId(System.Decimal? _trnsCdeStopId, int start, int pageLength)
		{
			int count =  -1;
			return GetByTrnsCdeStopId(null, _trnsCdeStopId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_TRNS_LINE_STOP key.
		///		fkTrnsLineStudTrnsLineStop Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_trnsCdeStopId">اسم المحطة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByTrnsCdeStopId(System.Decimal? _trnsCdeStopId, int start, int pageLength,out int count)
		{
			return GetByTrnsCdeStopId(null, _trnsCdeStopId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STUD_TRNS_LINE_STOP key.
		///		FK_TRNS_LINE_STUD_TRNS_LINE_STOP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeStopId">اسم المحطة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public abstract TList<TrnsStudReq> GetByTrnsCdeStopId(TransactionManager transactionManager, System.Decimal? _trnsCdeStopId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_REQ_GS_CDE_CAMPUS key.
		///		FK_TRNS_STUD_REQ_GS_CDE_CAMPUS Description: 
		/// </summary>
		/// <param name="_gsCdeCampusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByGsCdeCampusId(System.Decimal? _gsCdeCampusId)
		{
			int count = -1;
			return GetByGsCdeCampusId(_gsCdeCampusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_REQ_GS_CDE_CAMPUS key.
		///		FK_TRNS_STUD_REQ_GS_CDE_CAMPUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsStudReq> GetByGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _gsCdeCampusId)
		{
			int count = -1;
			return GetByGsCdeCampusId(transactionManager, _gsCdeCampusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_REQ_GS_CDE_CAMPUS key.
		///		FK_TRNS_STUD_REQ_GS_CDE_CAMPUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _gsCdeCampusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeCampusId(transactionManager, _gsCdeCampusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_REQ_GS_CDE_CAMPUS key.
		///		fkTrnsStudReqGsCdeCampus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByGsCdeCampusId(System.Decimal? _gsCdeCampusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeCampusId(null, _gsCdeCampusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_REQ_GS_CDE_CAMPUS key.
		///		fkTrnsStudReqGsCdeCampus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByGsCdeCampusId(System.Decimal? _gsCdeCampusId, int start, int pageLength,out int count)
		{
			return GetByGsCdeCampusId(null, _gsCdeCampusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_REQ_GS_CDE_CAMPUS key.
		///		FK_TRNS_STUD_REQ_GS_CDE_CAMPUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public abstract TList<TrnsStudReq> GetByGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _gsCdeCampusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_REQ_GS_CODE_REQ_STATUS key.
		///		FK_TRNS_STUD_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByGsCodeReqStatusId(System.Decimal? _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(_gsCodeReqStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_REQ_GS_CODE_REQ_STATUS key.
		///		FK_TRNS_STUD_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsStudReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal? _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_REQ_GS_CODE_REQ_STATUS key.
		///		FK_TRNS_STUD_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal? _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_REQ_GS_CODE_REQ_STATUS key.
		///		fkTrnsStudReqGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByGsCodeReqStatusId(System.Decimal? _gsCodeReqStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_REQ_GS_CODE_REQ_STATUS key.
		///		fkTrnsStudReqGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByGsCodeReqStatusId(System.Decimal? _gsCodeReqStatusId, int start, int pageLength,out int count)
		{
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_REQ_GS_CODE_REQ_STATUS key.
		///		FK_TRNS_STUD_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public abstract TList<TrnsStudReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal? _gsCodeReqStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_REQ_TRNS_LINE key.
		///		FK_TRNS_STUD_REQ_TRNS_LINE Description: 
		/// </summary>
		/// <param name="_trnsLineId">اسم الخط</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByTrnsLineId(System.Decimal? _trnsLineId)
		{
			int count = -1;
			return GetByTrnsLineId(_trnsLineId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_REQ_TRNS_LINE key.
		///		FK_TRNS_STUD_REQ_TRNS_LINE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsLineId">اسم الخط</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsStudReq> GetByTrnsLineId(TransactionManager transactionManager, System.Decimal? _trnsLineId)
		{
			int count = -1;
			return GetByTrnsLineId(transactionManager, _trnsLineId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_REQ_TRNS_LINE key.
		///		FK_TRNS_STUD_REQ_TRNS_LINE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsLineId">اسم الخط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByTrnsLineId(TransactionManager transactionManager, System.Decimal? _trnsLineId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsLineId(transactionManager, _trnsLineId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_REQ_TRNS_LINE key.
		///		fkTrnsStudReqTrnsLine Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_trnsLineId">اسم الخط</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByTrnsLineId(System.Decimal? _trnsLineId, int start, int pageLength)
		{
			int count =  -1;
			return GetByTrnsLineId(null, _trnsLineId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_REQ_TRNS_LINE key.
		///		fkTrnsStudReqTrnsLine Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_trnsLineId">اسم الخط</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public TList<TrnsStudReq> GetByTrnsLineId(System.Decimal? _trnsLineId, int start, int pageLength,out int count)
		{
			return GetByTrnsLineId(null, _trnsLineId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_REQ_TRNS_LINE key.
		///		FK_TRNS_STUD_REQ_TRNS_LINE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsLineId">اسم الخط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudReq objects.</returns>
		public abstract TList<TrnsStudReq> GetByTrnsLineId(TransactionManager transactionManager, System.Decimal? _trnsLineId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.TrnsStudReq Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsStudReqKey key, int start, int pageLength)
		{
			return GetByTrnsStudReqId(transactionManager, key.TrnsStudReqId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_TRNS_LINE_STUD index.
		/// </summary>
		/// <param name="_trnsStudReqId">طلبات اشتراك الباص</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudReq GetByTrnsStudReqId(System.Decimal _trnsStudReqId)
		{
			int count = -1;
			return GetByTrnsStudReqId(null,_trnsStudReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_STUD index.
		/// </summary>
		/// <param name="_trnsStudReqId">طلبات اشتراك الباص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudReq GetByTrnsStudReqId(System.Decimal _trnsStudReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsStudReqId(null, _trnsStudReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsStudReqId">طلبات اشتراك الباص</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudReq GetByTrnsStudReqId(TransactionManager transactionManager, System.Decimal _trnsStudReqId)
		{
			int count = -1;
			return GetByTrnsStudReqId(transactionManager, _trnsStudReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsStudReqId">طلبات اشتراك الباص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudReq GetByTrnsStudReqId(TransactionManager transactionManager, System.Decimal _trnsStudReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsStudReqId(transactionManager, _trnsStudReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_STUD index.
		/// </summary>
		/// <param name="_trnsStudReqId">طلبات اشتراك الباص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudReq GetByTrnsStudReqId(System.Decimal _trnsStudReqId, int start, int pageLength, out int count)
		{
			return GetByTrnsStudReqId(null, _trnsStudReqId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsStudReqId">طلبات اشتراك الباص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudReq"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.TrnsStudReq GetByTrnsStudReqId(TransactionManager transactionManager, System.Decimal _trnsStudReqId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_TRNS_STUD_REQ index.
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudReq GetByEdStudIdEdAcadYearIdEdCodeSemesterId(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterId(null,_edStudId, _edAcadYearId, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_STUD_REQ index.
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudReq GetByEdStudIdEdAcadYearIdEdCodeSemesterId(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterId(null, _edStudId, _edAcadYearId, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_STUD_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudReq GetByEdStudIdEdAcadYearIdEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterId(transactionManager, _edStudId, _edAcadYearId, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_STUD_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudReq GetByEdStudIdEdAcadYearIdEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterId(transactionManager, _edStudId, _edAcadYearId, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_STUD_REQ index.
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudReq GetByEdStudIdEdAcadYearIdEdCodeSemesterId(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterId(null, _edStudId, _edAcadYearId, _edCodeSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_STUD_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudReq"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.TrnsStudReq GetByEdStudIdEdAcadYearIdEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TrnsStudReq&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TrnsStudReq&gt;"/></returns>
		public static TList<TrnsStudReq> Fill(IDataReader reader, TList<TrnsStudReq> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.TrnsStudReq c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TrnsStudReq")
					.Append("|").Append((System.Decimal)reader["TRNS_STUD_REQ_ID"]).ToString();
					c = EntityManager.LocateOrCreate<TrnsStudReq>(
					key.ToString(), // EntityTrackingKey
					"TrnsStudReq",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.TrnsStudReq();
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
					c.TrnsStudReqId = (System.Decimal)reader["TRNS_STUD_REQ_ID"];
					c.OriginalTrnsStudReqId = c.TrnsStudReqId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.ReqDate = (System.DateTime)reader["REQ_DATE"];
					c.TrnsCdeStopId = Convert.IsDBNull(reader["TRNS_CDE_STOP_ID"]) ? null : (System.Decimal?)reader["TRNS_CDE_STOP_ID"];
					c.TrnsLineId = Convert.IsDBNull(reader["TRNS_LINE_ID"]) ? null : (System.Decimal?)reader["TRNS_LINE_ID"];
					c.GsCdeCampusId = Convert.IsDBNull(reader["GS_CDE_CAMPUS_ID"]) ? null : (System.Decimal?)reader["GS_CDE_CAMPUS_ID"];
					c.GsCodeReqStatusId = Convert.IsDBNull(reader["GS_CODE_REQ_STATUS_ID"]) ? null : (System.Decimal?)reader["GS_CODE_REQ_STATUS_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Decimal?)reader["APPROVE_FLG"];
					c.ApproveDate = Convert.IsDBNull(reader["APPROVE_DATE"]) ? null : (System.DateTime?)reader["APPROVE_DATE"];
					c.ReqNum = Convert.IsDBNull(reader["REQ_NUM"]) ? null : (System.Decimal?)reader["REQ_NUM"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.TrnsStudReq"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsStudReq"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.TrnsStudReq entity)
		{
			if (!reader.Read()) return;
			
			entity.TrnsStudReqId = (System.Decimal)reader[((int)TrnsStudReqColumn.TrnsStudReqId - 1)];
			entity.OriginalTrnsStudReqId = (System.Decimal)reader["TRNS_STUD_REQ_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)TrnsStudReqColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)TrnsStudReqColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)TrnsStudReqColumn.EdCodeSemesterId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)TrnsStudReqColumn.EdStudId - 1)];
			entity.ReqDate = (System.DateTime)reader[((int)TrnsStudReqColumn.ReqDate - 1)];
			entity.TrnsCdeStopId = (reader.IsDBNull(((int)TrnsStudReqColumn.TrnsCdeStopId - 1)))?null:(System.Decimal?)reader[((int)TrnsStudReqColumn.TrnsCdeStopId - 1)];
			entity.TrnsLineId = (reader.IsDBNull(((int)TrnsStudReqColumn.TrnsLineId - 1)))?null:(System.Decimal?)reader[((int)TrnsStudReqColumn.TrnsLineId - 1)];
			entity.GsCdeCampusId = (reader.IsDBNull(((int)TrnsStudReqColumn.GsCdeCampusId - 1)))?null:(System.Decimal?)reader[((int)TrnsStudReqColumn.GsCdeCampusId - 1)];
			entity.GsCodeReqStatusId = (reader.IsDBNull(((int)TrnsStudReqColumn.GsCodeReqStatusId - 1)))?null:(System.Decimal?)reader[((int)TrnsStudReqColumn.GsCodeReqStatusId - 1)];
			entity.Notes = (reader.IsDBNull(((int)TrnsStudReqColumn.Notes - 1)))?null:(System.String)reader[((int)TrnsStudReqColumn.Notes - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)TrnsStudReqColumn.ApproveFlg - 1)))?null:(System.Decimal?)reader[((int)TrnsStudReqColumn.ApproveFlg - 1)];
			entity.ApproveDate = (reader.IsDBNull(((int)TrnsStudReqColumn.ApproveDate - 1)))?null:(System.DateTime?)reader[((int)TrnsStudReqColumn.ApproveDate - 1)];
			entity.ReqNum = (reader.IsDBNull(((int)TrnsStudReqColumn.ReqNum - 1)))?null:(System.Decimal?)reader[((int)TrnsStudReqColumn.ReqNum - 1)];
			entity.LastDate = (reader.IsDBNull(((int)TrnsStudReqColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)TrnsStudReqColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)TrnsStudReqColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)TrnsStudReqColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.TrnsStudReq"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsStudReq"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.TrnsStudReq entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.TrnsStudReqId = (System.Decimal)dataRow["TRNS_STUD_REQ_ID"];
			entity.OriginalTrnsStudReqId = (System.Decimal)dataRow["TRNS_STUD_REQ_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.ReqDate = (System.DateTime)dataRow["REQ_DATE"];
			entity.TrnsCdeStopId = Convert.IsDBNull(dataRow["TRNS_CDE_STOP_ID"]) ? null : (System.Decimal?)dataRow["TRNS_CDE_STOP_ID"];
			entity.TrnsLineId = Convert.IsDBNull(dataRow["TRNS_LINE_ID"]) ? null : (System.Decimal?)dataRow["TRNS_LINE_ID"];
			entity.GsCdeCampusId = Convert.IsDBNull(dataRow["GS_CDE_CAMPUS_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_CAMPUS_ID"];
			entity.GsCodeReqStatusId = Convert.IsDBNull(dataRow["GS_CODE_REQ_STATUS_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_REQ_STATUS_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Decimal?)dataRow["APPROVE_FLG"];
			entity.ApproveDate = Convert.IsDBNull(dataRow["APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["APPROVE_DATE"];
			entity.ReqNum = Convert.IsDBNull(dataRow["REQ_NUM"]) ? null : (System.Decimal?)dataRow["REQ_NUM"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsStudReq"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.TrnsStudReq Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsStudReq entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region TrnsCdeStopIdSource	
			if (CanDeepLoad(entity, "TrnsCdeStop|TrnsCdeStopIdSource", deepLoadType, innerList) 
				&& entity.TrnsCdeStopIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.TrnsCdeStopId ?? 0.0m);
				TrnsCdeStop tmpEntity = EntityManager.LocateEntity<TrnsCdeStop>(EntityLocator.ConstructKeyFromPkItems(typeof(TrnsCdeStop), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.TrnsCdeStopIdSource = tmpEntity;
				else
					entity.TrnsCdeStopIdSource = DataRepository.TrnsCdeStopProvider.GetByTrnsCdeStopId(transactionManager, (entity.TrnsCdeStopId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsCdeStopIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.TrnsCdeStopIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.TrnsCdeStopProvider.DeepLoad(transactionManager, entity.TrnsCdeStopIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion TrnsCdeStopIdSource

			#region GsCdeCampusIdSource	
			if (CanDeepLoad(entity, "GsCdeCampus|GsCdeCampusIdSource", deepLoadType, innerList) 
				&& entity.GsCdeCampusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeCampusId ?? 0.0m);
				GsCdeCampus tmpEntity = EntityManager.LocateEntity<GsCdeCampus>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeCampus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeCampusIdSource = tmpEntity;
				else
					entity.GsCdeCampusIdSource = DataRepository.GsCdeCampusProvider.GetByGsCdeCampusId(transactionManager, (entity.GsCdeCampusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeCampusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeCampusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeCampusProvider.DeepLoad(transactionManager, entity.GsCdeCampusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeCampusIdSource

			#region GsCodeReqStatusIdSource	
			if (CanDeepLoad(entity, "GsCodeReqStatus|GsCodeReqStatusIdSource", deepLoadType, innerList) 
				&& entity.GsCodeReqStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeReqStatusId ?? 0.0m);
				GsCodeReqStatus tmpEntity = EntityManager.LocateEntity<GsCodeReqStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeReqStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeReqStatusIdSource = tmpEntity;
				else
					entity.GsCodeReqStatusIdSource = DataRepository.GsCodeReqStatusProvider.GetByGsCodeReqStatusId(transactionManager, (entity.GsCodeReqStatusId ?? 0.0m));		
				
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

			#region TrnsLineIdSource	
			if (CanDeepLoad(entity, "TrnsLine|TrnsLineIdSource", deepLoadType, innerList) 
				&& entity.TrnsLineIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.TrnsLineId ?? 0.0m);
				TrnsLine tmpEntity = EntityManager.LocateEntity<TrnsLine>(EntityLocator.ConstructKeyFromPkItems(typeof(TrnsLine), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.TrnsLineIdSource = tmpEntity;
				else
					entity.TrnsLineIdSource = DataRepository.TrnsLineProvider.GetByTrnsLineId(transactionManager, (entity.TrnsLineId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsLineIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.TrnsLineIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.TrnsLineProvider.DeepLoad(transactionManager, entity.TrnsLineIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion TrnsLineIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.TrnsStudReq object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.TrnsStudReq instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.TrnsStudReq Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsStudReq entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region TrnsCdeStopIdSource
			if (CanDeepSave(entity, "TrnsCdeStop|TrnsCdeStopIdSource", deepSaveType, innerList) 
				&& entity.TrnsCdeStopIdSource != null)
			{
				DataRepository.TrnsCdeStopProvider.Save(transactionManager, entity.TrnsCdeStopIdSource);
				entity.TrnsCdeStopId = entity.TrnsCdeStopIdSource.TrnsCdeStopId;
			}
			#endregion 
			
			#region GsCdeCampusIdSource
			if (CanDeepSave(entity, "GsCdeCampus|GsCdeCampusIdSource", deepSaveType, innerList) 
				&& entity.GsCdeCampusIdSource != null)
			{
				DataRepository.GsCdeCampusProvider.Save(transactionManager, entity.GsCdeCampusIdSource);
				entity.GsCdeCampusId = entity.GsCdeCampusIdSource.GsCdeCampusId;
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
			
			#region TrnsLineIdSource
			if (CanDeepSave(entity, "TrnsLine|TrnsLineIdSource", deepSaveType, innerList) 
				&& entity.TrnsLineIdSource != null)
			{
				DataRepository.TrnsLineProvider.Save(transactionManager, entity.TrnsLineIdSource);
				entity.TrnsLineId = entity.TrnsLineIdSource.TrnsLineId;
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
	
	#region TrnsStudReqChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.TrnsStudReq</c>
	///</summary>
	public enum TrnsStudReqChildEntityTypes
	{
		
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
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>TrnsCdeStop</c> at TrnsCdeStopIdSource
		///</summary>
		[ChildEntityType(typeof(TrnsCdeStop))]
		TrnsCdeStop,
		
		///<summary>
		/// Composite Property for <c>GsCdeCampus</c> at GsCdeCampusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeCampus))]
		GsCdeCampus,
		
		///<summary>
		/// Composite Property for <c>GsCodeReqStatus</c> at GsCodeReqStatusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeReqStatus))]
		GsCodeReqStatus,
		
		///<summary>
		/// Composite Property for <c>TrnsLine</c> at TrnsLineIdSource
		///</summary>
		[ChildEntityType(typeof(TrnsLine))]
		TrnsLine,
	}
	
	#endregion TrnsStudReqChildEntityTypes
	
	#region TrnsStudReqFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TrnsStudReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsStudReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrnsStudReqFilterBuilder : SqlFilterBuilder<TrnsStudReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsStudReqFilterBuilder class.
		/// </summary>
		public TrnsStudReqFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrnsStudReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrnsStudReqFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrnsStudReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrnsStudReqFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrnsStudReqFilterBuilder
	
	#region TrnsStudReqParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TrnsStudReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsStudReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrnsStudReqParameterBuilder : ParameterizedSqlFilterBuilder<TrnsStudReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsStudReqParameterBuilder class.
		/// </summary>
		public TrnsStudReqParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrnsStudReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrnsStudReqParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrnsStudReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrnsStudReqParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrnsStudReqParameterBuilder
	
	#region TrnsStudReqSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TrnsStudReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsStudReq"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TrnsStudReqSortBuilder : SqlSortBuilder<TrnsStudReqColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsStudReqSqlSortBuilder class.
		/// </summary>
		public TrnsStudReqSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TrnsStudReqSortBuilder
	
} // end namespace
