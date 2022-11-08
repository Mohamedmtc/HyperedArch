﻿#region Using directives

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
	/// This class is the base class for any <see cref="CtrStudOutProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrStudOutProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CtrStudOut, UMIS_VER2.BusinessLyer.CtrStudOutKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrStudOutKey key)
		{
			return Delete(transactionManager, key.CtrStudOutId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_ctrStudOutId">اخطار الطلاب الخارجين عن التغذية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _ctrStudOutId)
		{
			return Delete(null, _ctrStudOutId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrStudOutId">اخطار الطلاب الخارجين عن التغذية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _ctrStudOutId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_CTR_CDE_OUT_RSN key.
		///		FK_CTR_STUD_OUT_CTR_CDE_OUT_RSN Description: 
		/// </summary>
		/// <param name="_ctrCdeOutRsnId">سبب خروج من التغذية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetByCtrCdeOutRsnId(System.Decimal _ctrCdeOutRsnId)
		{
			int count = -1;
			return GetByCtrCdeOutRsnId(_ctrCdeOutRsnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_CTR_CDE_OUT_RSN key.
		///		FK_CTR_STUD_OUT_CTR_CDE_OUT_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeOutRsnId">سبب خروج من التغذية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		/// <remarks></remarks>
		public TList<CtrStudOut> GetByCtrCdeOutRsnId(TransactionManager transactionManager, System.Decimal _ctrCdeOutRsnId)
		{
			int count = -1;
			return GetByCtrCdeOutRsnId(transactionManager, _ctrCdeOutRsnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_CTR_CDE_OUT_RSN key.
		///		FK_CTR_STUD_OUT_CTR_CDE_OUT_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeOutRsnId">سبب خروج من التغذية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetByCtrCdeOutRsnId(TransactionManager transactionManager, System.Decimal _ctrCdeOutRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeOutRsnId(transactionManager, _ctrCdeOutRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_CTR_CDE_OUT_RSN key.
		///		fkCtrStudOutCtrCdeOutRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeOutRsnId">سبب خروج من التغذية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetByCtrCdeOutRsnId(System.Decimal _ctrCdeOutRsnId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCtrCdeOutRsnId(null, _ctrCdeOutRsnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_CTR_CDE_OUT_RSN key.
		///		fkCtrStudOutCtrCdeOutRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeOutRsnId">سبب خروج من التغذية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetByCtrCdeOutRsnId(System.Decimal _ctrCdeOutRsnId, int start, int pageLength,out int count)
		{
			return GetByCtrCdeOutRsnId(null, _ctrCdeOutRsnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_CTR_CDE_OUT_RSN key.
		///		FK_CTR_STUD_OUT_CTR_CDE_OUT_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeOutRsnId">سبب خروج من التغذية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public abstract TList<CtrStudOut> GetByCtrCdeOutRsnId(TransactionManager transactionManager, System.Decimal _ctrCdeOutRsnId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_ED_ACAD_YEAR key.
		///		FK_CTR_STUD_OUT_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_ED_ACAD_YEAR key.
		///		FK_CTR_STUD_OUT_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		/// <remarks></remarks>
		public TList<CtrStudOut> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_ED_ACAD_YEAR key.
		///		FK_CTR_STUD_OUT_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_ED_ACAD_YEAR key.
		///		fkCtrStudOutEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_ED_ACAD_YEAR key.
		///		fkCtrStudOutEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_ED_ACAD_YEAR key.
		///		FK_CTR_STUD_OUT_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public abstract TList<CtrStudOut> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_ED_CODE_SEMESTER key.
		///		FK_CTR_STUD_OUT_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_ED_CODE_SEMESTER key.
		///		FK_CTR_STUD_OUT_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		/// <remarks></remarks>
		public TList<CtrStudOut> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_ED_CODE_SEMESTER key.
		///		FK_CTR_STUD_OUT_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_ED_CODE_SEMESTER key.
		///		fkCtrStudOutEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_ED_CODE_SEMESTER key.
		///		fkCtrStudOutEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_ED_CODE_SEMESTER key.
		///		FK_CTR_STUD_OUT_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public abstract TList<CtrStudOut> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_ED_STUD key.
		///		FK_CTR_STUD_OUT_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_ED_STUD key.
		///		FK_CTR_STUD_OUT_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		/// <remarks></remarks>
		public TList<CtrStudOut> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_ED_STUD key.
		///		FK_CTR_STUD_OUT_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_ED_STUD key.
		///		fkCtrStudOutEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_ED_STUD key.
		///		fkCtrStudOutEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_ED_STUD key.
		///		FK_CTR_STUD_OUT_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public abstract TList<CtrStudOut> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_SE_FORM key.
		///		FK_CTR_STUD_OUT_SE_FORM Description: 
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetBySeFormId(System.Decimal? _seFormId)
		{
			int count = -1;
			return GetBySeFormId(_seFormId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_SE_FORM key.
		///		FK_CTR_STUD_OUT_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		/// <remarks></remarks>
		public TList<CtrStudOut> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_SE_FORM key.
		///		FK_CTR_STUD_OUT_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_SE_FORM key.
		///		fkCtrStudOutSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetBySeFormId(System.Decimal? _seFormId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeFormId(null, _seFormId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_SE_FORM key.
		///		fkCtrStudOutSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetBySeFormId(System.Decimal? _seFormId, int start, int pageLength,out int count)
		{
			return GetBySeFormId(null, _seFormId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_SE_FORM key.
		///		FK_CTR_STUD_OUT_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public abstract TList<CtrStudOut> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_SE_USER key.
		///		FK_CTR_STUD_OUT_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_SE_USER key.
		///		FK_CTR_STUD_OUT_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		/// <remarks></remarks>
		public TList<CtrStudOut> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_SE_USER key.
		///		FK_CTR_STUD_OUT_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_SE_USER key.
		///		fkCtrStudOutSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_SE_USER key.
		///		fkCtrStudOutSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public TList<CtrStudOut> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_STUD_OUT_SE_USER key.
		///		FK_CTR_STUD_OUT_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrStudOut objects.</returns>
		public abstract TList<CtrStudOut> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.CtrStudOut Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrStudOutKey key, int start, int pageLength)
		{
			return GetByCtrStudOutId(transactionManager, key.CtrStudOutId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CTR_STUD_OUT index.
		/// </summary>
		/// <param name="_ctrStudOutId">اخطار الطلاب الخارجين عن التغذية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrStudOut"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrStudOut GetByCtrStudOutId(System.Decimal _ctrStudOutId)
		{
			int count = -1;
			return GetByCtrStudOutId(null,_ctrStudOutId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_STUD_OUT index.
		/// </summary>
		/// <param name="_ctrStudOutId">اخطار الطلاب الخارجين عن التغذية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrStudOut"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrStudOut GetByCtrStudOutId(System.Decimal _ctrStudOutId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrStudOutId(null, _ctrStudOutId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_STUD_OUT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrStudOutId">اخطار الطلاب الخارجين عن التغذية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrStudOut"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrStudOut GetByCtrStudOutId(TransactionManager transactionManager, System.Decimal _ctrStudOutId)
		{
			int count = -1;
			return GetByCtrStudOutId(transactionManager, _ctrStudOutId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_STUD_OUT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrStudOutId">اخطار الطلاب الخارجين عن التغذية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrStudOut"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrStudOut GetByCtrStudOutId(TransactionManager transactionManager, System.Decimal _ctrStudOutId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrStudOutId(transactionManager, _ctrStudOutId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_STUD_OUT index.
		/// </summary>
		/// <param name="_ctrStudOutId">اخطار الطلاب الخارجين عن التغذية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrStudOut"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrStudOut GetByCtrStudOutId(System.Decimal _ctrStudOutId, int start, int pageLength, out int count)
		{
			return GetByCtrStudOutId(null, _ctrStudOutId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_STUD_OUT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrStudOutId">اخطار الطلاب الخارجين عن التغذية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrStudOut"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrStudOut GetByCtrStudOutId(TransactionManager transactionManager, System.Decimal _ctrStudOutId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CtrStudOut&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CtrStudOut&gt;"/></returns>
		public static TList<CtrStudOut> Fill(IDataReader reader, TList<CtrStudOut> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CtrStudOut c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CtrStudOut")
					.Append("|").Append((System.Decimal)reader["CTR_STUD_OUT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CtrStudOut>(
					key.ToString(), // EntityTrackingKey
					"CtrStudOut",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CtrStudOut();
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
					c.CtrStudOutId = (System.Decimal)reader["CTR_STUD_OUT_ID"];
					c.OriginalCtrStudOutId = c.CtrStudOutId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.CtrCdeOutRsnId = (System.Decimal)reader["CTR_CDE_OUT_RSN_ID"];
					c.FromDt = (System.DateTime)reader["FROM_DT"];
					c.ToDt = Convert.IsDBNull(reader["TO_DT"]) ? null : (System.DateTime?)reader["TO_DT"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeFormId = Convert.IsDBNull(reader["SE_FORM_ID"]) ? null : (System.Decimal?)reader["SE_FORM_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrStudOut"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrStudOut"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CtrStudOut entity)
		{
			if (!reader.Read()) return;
			
			entity.CtrStudOutId = (System.Decimal)reader[((int)CtrStudOutColumn.CtrStudOutId - 1)];
			entity.OriginalCtrStudOutId = (System.Decimal)reader["CTR_STUD_OUT_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)CtrStudOutColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)CtrStudOutColumn.EdCodeSemesterId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)CtrStudOutColumn.EdStudId - 1)];
			entity.CtrCdeOutRsnId = (System.Decimal)reader[((int)CtrStudOutColumn.CtrCdeOutRsnId - 1)];
			entity.FromDt = (System.DateTime)reader[((int)CtrStudOutColumn.FromDt - 1)];
			entity.ToDt = (reader.IsDBNull(((int)CtrStudOutColumn.ToDt - 1)))?null:(System.DateTime?)reader[((int)CtrStudOutColumn.ToDt - 1)];
			entity.LastDate = (reader.IsDBNull(((int)CtrStudOutColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)CtrStudOutColumn.LastDate - 1)];
			entity.SeFormId = (reader.IsDBNull(((int)CtrStudOutColumn.SeFormId - 1)))?null:(System.Decimal?)reader[((int)CtrStudOutColumn.SeFormId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)CtrStudOutColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)CtrStudOutColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrStudOut"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrStudOut"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CtrStudOut entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CtrStudOutId = (System.Decimal)dataRow["CTR_STUD_OUT_ID"];
			entity.OriginalCtrStudOutId = (System.Decimal)dataRow["CTR_STUD_OUT_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.CtrCdeOutRsnId = (System.Decimal)dataRow["CTR_CDE_OUT_RSN_ID"];
			entity.FromDt = (System.DateTime)dataRow["FROM_DT"];
			entity.ToDt = Convert.IsDBNull(dataRow["TO_DT"]) ? null : (System.DateTime?)dataRow["TO_DT"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeFormId = Convert.IsDBNull(dataRow["SE_FORM_ID"]) ? null : (System.Decimal?)dataRow["SE_FORM_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrStudOut"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrStudOut Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrStudOut entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region CtrCdeOutRsnIdSource	
			if (CanDeepLoad(entity, "CtrCdeOutRsn|CtrCdeOutRsnIdSource", deepLoadType, innerList) 
				&& entity.CtrCdeOutRsnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CtrCdeOutRsnId;
				CtrCdeOutRsn tmpEntity = EntityManager.LocateEntity<CtrCdeOutRsn>(EntityLocator.ConstructKeyFromPkItems(typeof(CtrCdeOutRsn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CtrCdeOutRsnIdSource = tmpEntity;
				else
					entity.CtrCdeOutRsnIdSource = DataRepository.CtrCdeOutRsnProvider.GetByCtrCdeOutRsnId(transactionManager, entity.CtrCdeOutRsnId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrCdeOutRsnIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CtrCdeOutRsnIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CtrCdeOutRsnProvider.DeepLoad(transactionManager, entity.CtrCdeOutRsnIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CtrCdeOutRsnIdSource

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

			#region SeFormIdSource	
			if (CanDeepLoad(entity, "SeForm|SeFormIdSource", deepLoadType, innerList) 
				&& entity.SeFormIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeFormId ?? 0.0m);
				SeForm tmpEntity = EntityManager.LocateEntity<SeForm>(EntityLocator.ConstructKeyFromPkItems(typeof(SeForm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeFormIdSource = tmpEntity;
				else
					entity.SeFormIdSource = DataRepository.SeFormProvider.GetBySeFormId(transactionManager, (entity.SeFormId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeFormIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeFormIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeFormProvider.DeepLoad(transactionManager, entity.SeFormIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeFormIdSource

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserId ?? 0.0m));		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CtrStudOut object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CtrStudOut instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrStudOut Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrStudOut entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region CtrCdeOutRsnIdSource
			if (CanDeepSave(entity, "CtrCdeOutRsn|CtrCdeOutRsnIdSource", deepSaveType, innerList) 
				&& entity.CtrCdeOutRsnIdSource != null)
			{
				DataRepository.CtrCdeOutRsnProvider.Save(transactionManager, entity.CtrCdeOutRsnIdSource);
				entity.CtrCdeOutRsnId = entity.CtrCdeOutRsnIdSource.CtrCdeOutRsnId;
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region SeFormIdSource
			if (CanDeepSave(entity, "SeForm|SeFormIdSource", deepSaveType, innerList) 
				&& entity.SeFormIdSource != null)
			{
				DataRepository.SeFormProvider.Save(transactionManager, entity.SeFormIdSource);
				entity.SeFormId = entity.SeFormIdSource.SeFormId;
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
	
	#region CtrStudOutChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CtrStudOut</c>
	///</summary>
	public enum CtrStudOutChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CtrCdeOutRsn</c> at CtrCdeOutRsnIdSource
		///</summary>
		[ChildEntityType(typeof(CtrCdeOutRsn))]
		CtrCdeOutRsn,
		
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
		/// Composite Property for <c>SeForm</c> at SeFormIdSource
		///</summary>
		[ChildEntityType(typeof(SeForm))]
		SeForm,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
	}
	
	#endregion CtrStudOutChildEntityTypes
	
	#region CtrStudOutFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CtrStudOutColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrStudOut"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrStudOutFilterBuilder : SqlFilterBuilder<CtrStudOutColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrStudOutFilterBuilder class.
		/// </summary>
		public CtrStudOutFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrStudOutFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrStudOutFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrStudOutFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrStudOutFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrStudOutFilterBuilder
	
	#region CtrStudOutParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CtrStudOutColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrStudOut"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrStudOutParameterBuilder : ParameterizedSqlFilterBuilder<CtrStudOutColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrStudOutParameterBuilder class.
		/// </summary>
		public CtrStudOutParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrStudOutParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrStudOutParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrStudOutParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrStudOutParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrStudOutParameterBuilder
	
	#region CtrStudOutSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CtrStudOutColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrStudOut"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CtrStudOutSortBuilder : SqlSortBuilder<CtrStudOutColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrStudOutSqlSortBuilder class.
		/// </summary>
		public CtrStudOutSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CtrStudOutSortBuilder
	
} // end namespace
