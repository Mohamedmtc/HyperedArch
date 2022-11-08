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
	/// This class is the base class for any <see cref="EdExamStudAbsenceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdExamStudAbsenceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdExamStudAbsence, UMIS_VER2.BusinessLyer.EdExamStudAbsenceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdExamStudAbsenceKey key)
		{
			return Delete(transactionManager, key.EdExamStudAbsenceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edExamStudAbsenceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edExamStudAbsenceId)
		{
			return Delete(null, _edExamStudAbsenceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamStudAbsenceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edExamStudAbsenceId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXAM_TYPE key.
		///		FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamStudAbsence objects.</returns>
		public TList<EdExamStudAbsence> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(_edCdeExamTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXAM_TYPE key.
		///		FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamStudAbsence objects.</returns>
		/// <remarks></remarks>
		public TList<EdExamStudAbsence> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXAM_TYPE key.
		///		FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamStudAbsence objects.</returns>
		public TList<EdExamStudAbsence> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXAM_TYPE key.
		///		fkEdExamStudAbsenceEdCdeExamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamStudAbsence objects.</returns>
		public TList<EdExamStudAbsence> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXAM_TYPE key.
		///		fkEdExamStudAbsenceEdCdeExamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamStudAbsence objects.</returns>
		public TList<EdExamStudAbsence> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXAM_TYPE key.
		///		FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamStudAbsence objects.</returns>
		public abstract TList<EdExamStudAbsence> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXECUSE_RSN key.
		///		FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXECUSE_RSN Description: 
		/// </summary>
		/// <param name="_edCdeExecuseRsnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamStudAbsence objects.</returns>
		public TList<EdExamStudAbsence> GetByEdCdeExecuseRsnId(System.Int32? _edCdeExecuseRsnId)
		{
			int count = -1;
			return GetByEdCdeExecuseRsnId(_edCdeExecuseRsnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXECUSE_RSN key.
		///		FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXECUSE_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExecuseRsnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamStudAbsence objects.</returns>
		/// <remarks></remarks>
		public TList<EdExamStudAbsence> GetByEdCdeExecuseRsnId(TransactionManager transactionManager, System.Int32? _edCdeExecuseRsnId)
		{
			int count = -1;
			return GetByEdCdeExecuseRsnId(transactionManager, _edCdeExecuseRsnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXECUSE_RSN key.
		///		FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXECUSE_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExecuseRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamStudAbsence objects.</returns>
		public TList<EdExamStudAbsence> GetByEdCdeExecuseRsnId(TransactionManager transactionManager, System.Int32? _edCdeExecuseRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExecuseRsnId(transactionManager, _edCdeExecuseRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXECUSE_RSN key.
		///		fkEdExamStudAbsenceEdCdeExecuseRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExecuseRsnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamStudAbsence objects.</returns>
		public TList<EdExamStudAbsence> GetByEdCdeExecuseRsnId(System.Int32? _edCdeExecuseRsnId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeExecuseRsnId(null, _edCdeExecuseRsnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXECUSE_RSN key.
		///		fkEdExamStudAbsenceEdCdeExecuseRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExecuseRsnId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamStudAbsence objects.</returns>
		public TList<EdExamStudAbsence> GetByEdCdeExecuseRsnId(System.Int32? _edCdeExecuseRsnId, int start, int pageLength,out int count)
		{
			return GetByEdCdeExecuseRsnId(null, _edCdeExecuseRsnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXECUSE_RSN key.
		///		FK_ED_EXAM_STUD_ABSENCE_ED_CDE_EXECUSE_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExecuseRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamStudAbsence objects.</returns>
		public abstract TList<EdExamStudAbsence> GetByEdCdeExecuseRsnId(TransactionManager transactionManager, System.Int32? _edCdeExecuseRsnId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdExamStudAbsence Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdExamStudAbsenceKey key, int start, int pageLength)
		{
			return GetByEdExamStudAbsenceId(transactionManager, key.EdExamStudAbsenceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_EXAM_SCHDL_ID_1 index.
		/// </summary>
		/// <param name="_edExamSchdlId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamStudAbsence&gt;"/> class.</returns>
		public TList<EdExamStudAbsence> GetByEdExamSchdlId(System.Decimal _edExamSchdlId)
		{
			int count = -1;
			return GetByEdExamSchdlId(null,_edExamSchdlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_EXAM_SCHDL_ID_1 index.
		/// </summary>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamStudAbsence&gt;"/> class.</returns>
		public TList<EdExamStudAbsence> GetByEdExamSchdlId(System.Decimal _edExamSchdlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdExamSchdlId(null, _edExamSchdlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_EXAM_SCHDL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSchdlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamStudAbsence&gt;"/> class.</returns>
		public TList<EdExamStudAbsence> GetByEdExamSchdlId(TransactionManager transactionManager, System.Decimal _edExamSchdlId)
		{
			int count = -1;
			return GetByEdExamSchdlId(transactionManager, _edExamSchdlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_EXAM_SCHDL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamStudAbsence&gt;"/> class.</returns>
		public TList<EdExamStudAbsence> GetByEdExamSchdlId(TransactionManager transactionManager, System.Decimal _edExamSchdlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdExamSchdlId(transactionManager, _edExamSchdlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_EXAM_SCHDL_ID_1 index.
		/// </summary>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamStudAbsence&gt;"/> class.</returns>
		public TList<EdExamStudAbsence> GetByEdExamSchdlId(System.Decimal _edExamSchdlId, int start, int pageLength, out int count)
		{
			return GetByEdExamSchdlId(null, _edExamSchdlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_EXAM_SCHDL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamStudAbsence&gt;"/> class.</returns>
		public abstract TList<EdExamStudAbsence> GetByEdExamSchdlId(TransactionManager transactionManager, System.Decimal _edExamSchdlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edStudSemesterId">اعتماد الغياب</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamStudAbsence&gt;"/> class.</returns>
		public TList<EdExamStudAbsence> GetByEdStudSemesterId(System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(null,_edStudSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edStudSemesterId">اعتماد الغياب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamStudAbsence&gt;"/> class.</returns>
		public TList<EdExamStudAbsence> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId">اعتماد الغياب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamStudAbsence&gt;"/> class.</returns>
		public TList<EdExamStudAbsence> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId">اعتماد الغياب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamStudAbsence&gt;"/> class.</returns>
		public TList<EdExamStudAbsence> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edStudSemesterId">اعتماد الغياب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamStudAbsence&gt;"/> class.</returns>
		public TList<EdExamStudAbsence> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId">اعتماد الغياب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamStudAbsence&gt;"/> class.</returns>
		public abstract TList<EdExamStudAbsence> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_EXAM_STUD_ABSENCE index.
		/// </summary>
		/// <param name="_edExamStudAbsenceId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamStudAbsence GetByEdExamStudAbsenceId(System.Decimal _edExamStudAbsenceId)
		{
			int count = -1;
			return GetByEdExamStudAbsenceId(null,_edExamStudAbsenceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM_STUD_ABSENCE index.
		/// </summary>
		/// <param name="_edExamStudAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamStudAbsence GetByEdExamStudAbsenceId(System.Decimal _edExamStudAbsenceId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdExamStudAbsenceId(null, _edExamStudAbsenceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM_STUD_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamStudAbsenceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamStudAbsence GetByEdExamStudAbsenceId(TransactionManager transactionManager, System.Decimal _edExamStudAbsenceId)
		{
			int count = -1;
			return GetByEdExamStudAbsenceId(transactionManager, _edExamStudAbsenceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM_STUD_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamStudAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamStudAbsence GetByEdExamStudAbsenceId(TransactionManager transactionManager, System.Decimal _edExamStudAbsenceId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdExamStudAbsenceId(transactionManager, _edExamStudAbsenceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM_STUD_ABSENCE index.
		/// </summary>
		/// <param name="_edExamStudAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamStudAbsence GetByEdExamStudAbsenceId(System.Decimal _edExamStudAbsenceId, int start, int pageLength, out int count)
		{
			return GetByEdExamStudAbsenceId(null, _edExamStudAbsenceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM_STUD_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamStudAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamStudAbsence"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdExamStudAbsence GetByEdExamStudAbsenceId(TransactionManager transactionManager, System.Decimal _edExamStudAbsenceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdExamStudAbsence&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdExamStudAbsence&gt;"/></returns>
		public static TList<EdExamStudAbsence> Fill(IDataReader reader, TList<EdExamStudAbsence> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdExamStudAbsence c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdExamStudAbsence")
					.Append("|").Append((System.Decimal)reader["ED_EXAM_STUD_ABSENCE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdExamStudAbsence>(
					key.ToString(), // EntityTrackingKey
					"EdExamStudAbsence",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdExamStudAbsence();
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
					c.EdExamStudAbsenceId = (System.Decimal)reader["ED_EXAM_STUD_ABSENCE_ID"];
					c.OriginalEdExamStudAbsenceId = c.EdExamStudAbsenceId;
					c.EdStudSemesterId = (System.Decimal)reader["ED_STUD_SEMESTER_ID"];
					c.EdExamSchdlId = (System.Decimal)reader["ED_EXAM_SCHDL_ID"];
					c.ExecuseFlg = (System.Decimal)reader["EXECUSE_FLG"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EdCdeExecuseRsnId = Convert.IsDBNull(reader["ED_CDE_EXECUSE_RSN_ID"]) ? null : (System.Int32?)reader["ED_CDE_EXECUSE_RSN_ID"];
					c.AbsNotes = Convert.IsDBNull(reader["ABS_NOTES"]) ? null : (System.String)reader["ABS_NOTES"];
					c.EdCdeExamTypeId = Convert.IsDBNull(reader["ED_CDE_EXAM_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CDE_EXAM_TYPE_ID"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Boolean?)reader["APPROVE_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdExamStudAbsence"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdExamStudAbsence"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdExamStudAbsence entity)
		{
			if (!reader.Read()) return;
			
			entity.EdExamStudAbsenceId = (System.Decimal)reader[((int)EdExamStudAbsenceColumn.EdExamStudAbsenceId - 1)];
			entity.OriginalEdExamStudAbsenceId = (System.Decimal)reader["ED_EXAM_STUD_ABSENCE_ID"];
			entity.EdStudSemesterId = (System.Decimal)reader[((int)EdExamStudAbsenceColumn.EdStudSemesterId - 1)];
			entity.EdExamSchdlId = (System.Decimal)reader[((int)EdExamStudAbsenceColumn.EdExamSchdlId - 1)];
			entity.ExecuseFlg = (System.Decimal)reader[((int)EdExamStudAbsenceColumn.ExecuseFlg - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdExamStudAbsenceColumn.Notes - 1)))?null:(System.String)reader[((int)EdExamStudAbsenceColumn.Notes - 1)];
			entity.EdCdeExecuseRsnId = (reader.IsDBNull(((int)EdExamStudAbsenceColumn.EdCdeExecuseRsnId - 1)))?null:(System.Int32?)reader[((int)EdExamStudAbsenceColumn.EdCdeExecuseRsnId - 1)];
			entity.AbsNotes = (reader.IsDBNull(((int)EdExamStudAbsenceColumn.AbsNotes - 1)))?null:(System.String)reader[((int)EdExamStudAbsenceColumn.AbsNotes - 1)];
			entity.EdCdeExamTypeId = (reader.IsDBNull(((int)EdExamStudAbsenceColumn.EdCdeExamTypeId - 1)))?null:(System.Decimal?)reader[((int)EdExamStudAbsenceColumn.EdCdeExamTypeId - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)EdExamStudAbsenceColumn.ApproveFlg - 1)))?null:(System.Boolean?)reader[((int)EdExamStudAbsenceColumn.ApproveFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdExamStudAbsenceColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdExamStudAbsenceColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdExamStudAbsenceColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdExamStudAbsenceColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdExamStudAbsence"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdExamStudAbsence"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdExamStudAbsence entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdExamStudAbsenceId = (System.Decimal)dataRow["ED_EXAM_STUD_ABSENCE_ID"];
			entity.OriginalEdExamStudAbsenceId = (System.Decimal)dataRow["ED_EXAM_STUD_ABSENCE_ID"];
			entity.EdStudSemesterId = (System.Decimal)dataRow["ED_STUD_SEMESTER_ID"];
			entity.EdExamSchdlId = (System.Decimal)dataRow["ED_EXAM_SCHDL_ID"];
			entity.ExecuseFlg = (System.Decimal)dataRow["EXECUSE_FLG"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.EdCdeExecuseRsnId = Convert.IsDBNull(dataRow["ED_CDE_EXECUSE_RSN_ID"]) ? null : (System.Int32?)dataRow["ED_CDE_EXECUSE_RSN_ID"];
			entity.AbsNotes = Convert.IsDBNull(dataRow["ABS_NOTES"]) ? null : (System.String)dataRow["ABS_NOTES"];
			entity.EdCdeExamTypeId = Convert.IsDBNull(dataRow["ED_CDE_EXAM_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_EXAM_TYPE_ID"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Boolean?)dataRow["APPROVE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdExamStudAbsence"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdExamStudAbsence Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdExamStudAbsence entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCdeExamTypeIdSource	
			if (CanDeepLoad(entity, "EdCdeExamType|EdCdeExamTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCdeExamTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeExamTypeId ?? 0.0m);
				EdCdeExamType tmpEntity = EntityManager.LocateEntity<EdCdeExamType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeExamType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeExamTypeIdSource = tmpEntity;
				else
					entity.EdCdeExamTypeIdSource = DataRepository.EdCdeExamTypeProvider.GetByEdCdeExamTypeId(transactionManager, (entity.EdCdeExamTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeExamTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeExamTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeExamTypeProvider.DeepLoad(transactionManager, entity.EdCdeExamTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeExamTypeIdSource

			#region EdCdeExecuseRsnIdSource	
			if (CanDeepLoad(entity, "EdCdeExecuseRsn|EdCdeExecuseRsnIdSource", deepLoadType, innerList) 
				&& entity.EdCdeExecuseRsnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeExecuseRsnId ?? (int)0);
				EdCdeExecuseRsn tmpEntity = EntityManager.LocateEntity<EdCdeExecuseRsn>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeExecuseRsn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeExecuseRsnIdSource = tmpEntity;
				else
					entity.EdCdeExecuseRsnIdSource = DataRepository.EdCdeExecuseRsnProvider.GetByEdCdeExecuseRsnId(transactionManager, (entity.EdCdeExecuseRsnId ?? (int)0));		
				
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

			#region EdExamSchdlIdSource	
			if (CanDeepLoad(entity, "EdExamSchdl|EdExamSchdlIdSource", deepLoadType, innerList) 
				&& entity.EdExamSchdlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdExamSchdlId;
				EdExamSchdl tmpEntity = EntityManager.LocateEntity<EdExamSchdl>(EntityLocator.ConstructKeyFromPkItems(typeof(EdExamSchdl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdExamSchdlIdSource = tmpEntity;
				else
					entity.EdExamSchdlIdSource = DataRepository.EdExamSchdlProvider.GetByEdExamSchdlId(transactionManager, entity.EdExamSchdlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamSchdlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdExamSchdlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdExamSchdlProvider.DeepLoad(transactionManager, entity.EdExamSchdlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdExamSchdlIdSource

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdExamStudAbsenceId methods when available
			
			#region GsAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAttchdDoc>|GsAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAttchdDocCollection = DataRepository.GsAttchdDocProvider.GetByEdExamStudAbsenceId(transactionManager, entity.EdExamStudAbsenceId);

				if (deep && entity.GsAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAttchdDoc>) DataRepository.GsAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdExamStudAbsence object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdExamStudAbsence instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdExamStudAbsence Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdExamStudAbsence entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCdeExamTypeIdSource
			if (CanDeepSave(entity, "EdCdeExamType|EdCdeExamTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCdeExamTypeIdSource != null)
			{
				DataRepository.EdCdeExamTypeProvider.Save(transactionManager, entity.EdCdeExamTypeIdSource);
				entity.EdCdeExamTypeId = entity.EdCdeExamTypeIdSource.EdCdeExamTypeId;
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
			
			#region EdExamSchdlIdSource
			if (CanDeepSave(entity, "EdExamSchdl|EdExamSchdlIdSource", deepSaveType, innerList) 
				&& entity.EdExamSchdlIdSource != null)
			{
				DataRepository.EdExamSchdlProvider.Save(transactionManager, entity.EdExamSchdlIdSource);
				entity.EdExamSchdlId = entity.EdExamSchdlIdSource.EdExamSchdlId;
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<GsAttchdDoc>
				if (CanDeepSave(entity.GsAttchdDocCollection, "List<GsAttchdDoc>|GsAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAttchdDoc child in entity.GsAttchdDocCollection)
					{
						if(child.EdExamStudAbsenceIdSource != null)
						{
							child.EdExamStudAbsenceId = child.EdExamStudAbsenceIdSource.EdExamStudAbsenceId;
						}
						else
						{
							child.EdExamStudAbsenceId = entity.EdExamStudAbsenceId;
						}

					}

					if (entity.GsAttchdDocCollection.Count > 0 || entity.GsAttchdDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsAttchdDocProvider.Save(transactionManager, entity.GsAttchdDocCollection);
						
						deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsAttchdDoc >) DataRepository.GsAttchdDocProvider.DeepSave,
							new object[] { transactionManager, entity.GsAttchdDocCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdExamStudAbsenceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdExamStudAbsence</c>
	///</summary>
	public enum EdExamStudAbsenceChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCdeExamType</c> at EdCdeExamTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeExamType))]
		EdCdeExamType,
		
		///<summary>
		/// Composite Property for <c>EdCdeExecuseRsn</c> at EdCdeExecuseRsnIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeExecuseRsn))]
		EdCdeExecuseRsn,
		
		///<summary>
		/// Composite Property for <c>EdExamSchdl</c> at EdExamSchdlIdSource
		///</summary>
		[ChildEntityType(typeof(EdExamSchdl))]
		EdExamSchdl,
		
		///<summary>
		/// Composite Property for <c>EdStudSemester</c> at EdStudSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudSemester))]
		EdStudSemester,
		///<summary>
		/// Collection of <c>EdExamStudAbsence</c> as OneToMany for GsAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAttchdDoc>))]
		GsAttchdDocCollection,
	}
	
	#endregion EdExamStudAbsenceChildEntityTypes
	
	#region EdExamStudAbsenceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdExamStudAbsenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdExamStudAbsence"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdExamStudAbsenceFilterBuilder : SqlFilterBuilder<EdExamStudAbsenceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdExamStudAbsenceFilterBuilder class.
		/// </summary>
		public EdExamStudAbsenceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdExamStudAbsenceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdExamStudAbsenceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdExamStudAbsenceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdExamStudAbsenceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdExamStudAbsenceFilterBuilder
	
	#region EdExamStudAbsenceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdExamStudAbsenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdExamStudAbsence"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdExamStudAbsenceParameterBuilder : ParameterizedSqlFilterBuilder<EdExamStudAbsenceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdExamStudAbsenceParameterBuilder class.
		/// </summary>
		public EdExamStudAbsenceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdExamStudAbsenceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdExamStudAbsenceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdExamStudAbsenceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdExamStudAbsenceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdExamStudAbsenceParameterBuilder
	
	#region EdExamStudAbsenceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdExamStudAbsenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdExamStudAbsence"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdExamStudAbsenceSortBuilder : SqlSortBuilder<EdExamStudAbsenceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdExamStudAbsenceSqlSortBuilder class.
		/// </summary>
		public EdExamStudAbsenceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdExamStudAbsenceSortBuilder
	
} // end namespace
