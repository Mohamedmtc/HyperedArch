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
	/// This class is the base class for any <see cref="EdStudAbsenceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudAbsenceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudAbsence, UMIS_VER2.BusinessLyer.EdStudAbsenceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudAbsenceKey key)
		{
			return Delete(transactionManager, key.EdStudAbsenceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudAbsenceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudAbsenceId)
		{
			return Delete(null, _edStudAbsenceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudAbsenceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudAbsenceId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ABSENCE_SC_GROUP_DAY key.
		///		FK_ED_STUD_ABSENCE_SC_GROUP_DAY Description: 
		/// </summary>
		/// <param name="_scGroupDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudAbsence objects.</returns>
		public TList<EdStudAbsence> GetByScGroupDayId(System.Decimal? _scGroupDayId)
		{
			int count = -1;
			return GetByScGroupDayId(_scGroupDayId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ABSENCE_SC_GROUP_DAY key.
		///		FK_ED_STUD_ABSENCE_SC_GROUP_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudAbsence objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudAbsence> GetByScGroupDayId(TransactionManager transactionManager, System.Decimal? _scGroupDayId)
		{
			int count = -1;
			return GetByScGroupDayId(transactionManager, _scGroupDayId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ABSENCE_SC_GROUP_DAY key.
		///		FK_ED_STUD_ABSENCE_SC_GROUP_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudAbsence objects.</returns>
		public TList<EdStudAbsence> GetByScGroupDayId(TransactionManager transactionManager, System.Decimal? _scGroupDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByScGroupDayId(transactionManager, _scGroupDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ABSENCE_SC_GROUP_DAY key.
		///		fkEdStudAbsenceScGroupDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scGroupDayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudAbsence objects.</returns>
		public TList<EdStudAbsence> GetByScGroupDayId(System.Decimal? _scGroupDayId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScGroupDayId(null, _scGroupDayId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ABSENCE_SC_GROUP_DAY key.
		///		fkEdStudAbsenceScGroupDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scGroupDayId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudAbsence objects.</returns>
		public TList<EdStudAbsence> GetByScGroupDayId(System.Decimal? _scGroupDayId, int start, int pageLength,out int count)
		{
			return GetByScGroupDayId(null, _scGroupDayId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ABSENCE_SC_GROUP_DAY key.
		///		FK_ED_STUD_ABSENCE_SC_GROUP_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudAbsence objects.</returns>
		public abstract TList<EdStudAbsence> GetByScGroupDayId(TransactionManager transactionManager, System.Decimal? _scGroupDayId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ABSENCE_SC_SCHDL_SLOT key.
		///		FK_ED_STUD_ABSENCE_SC_SCHDL_SLOT Description: 
		/// </summary>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudAbsence objects.</returns>
		public TList<EdStudAbsence> GetByScSchdlSlotId(System.Decimal? _scSchdlSlotId)
		{
			int count = -1;
			return GetByScSchdlSlotId(_scSchdlSlotId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ABSENCE_SC_SCHDL_SLOT key.
		///		FK_ED_STUD_ABSENCE_SC_SCHDL_SLOT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudAbsence objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudAbsence> GetByScSchdlSlotId(TransactionManager transactionManager, System.Decimal? _scSchdlSlotId)
		{
			int count = -1;
			return GetByScSchdlSlotId(transactionManager, _scSchdlSlotId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ABSENCE_SC_SCHDL_SLOT key.
		///		FK_ED_STUD_ABSENCE_SC_SCHDL_SLOT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudAbsence objects.</returns>
		public TList<EdStudAbsence> GetByScSchdlSlotId(TransactionManager transactionManager, System.Decimal? _scSchdlSlotId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSchdlSlotId(transactionManager, _scSchdlSlotId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ABSENCE_SC_SCHDL_SLOT key.
		///		fkEdStudAbsenceScSchdlSlot Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudAbsence objects.</returns>
		public TList<EdStudAbsence> GetByScSchdlSlotId(System.Decimal? _scSchdlSlotId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScSchdlSlotId(null, _scSchdlSlotId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ABSENCE_SC_SCHDL_SLOT key.
		///		fkEdStudAbsenceScSchdlSlot Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudAbsence objects.</returns>
		public TList<EdStudAbsence> GetByScSchdlSlotId(System.Decimal? _scSchdlSlotId, int start, int pageLength,out int count)
		{
			return GetByScSchdlSlotId(null, _scSchdlSlotId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ABSENCE_SC_SCHDL_SLOT key.
		///		FK_ED_STUD_ABSENCE_SC_SCHDL_SLOT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudAbsence objects.</returns>
		public abstract TList<EdStudAbsence> GetByScSchdlSlotId(TransactionManager transactionManager, System.Decimal? _scSchdlSlotId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ABSENCE_SCHD_DTL_DY key.
		///		FK_ED_STUD_ABSENCE_SCHD_DTL_DY Description: 
		/// </summary>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudAbsence objects.</returns>
		public TList<EdStudAbsence> GetByScScheduleDtlDayId(System.Decimal? _scScheduleDtlDayId)
		{
			int count = -1;
			return GetByScScheduleDtlDayId(_scScheduleDtlDayId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ABSENCE_SCHD_DTL_DY key.
		///		FK_ED_STUD_ABSENCE_SCHD_DTL_DY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudAbsence objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudAbsence> GetByScScheduleDtlDayId(TransactionManager transactionManager, System.Decimal? _scScheduleDtlDayId)
		{
			int count = -1;
			return GetByScScheduleDtlDayId(transactionManager, _scScheduleDtlDayId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ABSENCE_SCHD_DTL_DY key.
		///		FK_ED_STUD_ABSENCE_SCHD_DTL_DY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudAbsence objects.</returns>
		public TList<EdStudAbsence> GetByScScheduleDtlDayId(TransactionManager transactionManager, System.Decimal? _scScheduleDtlDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlDayId(transactionManager, _scScheduleDtlDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ABSENCE_SCHD_DTL_DY key.
		///		fkEdStudAbsenceSchdDtlDy Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudAbsence objects.</returns>
		public TList<EdStudAbsence> GetByScScheduleDtlDayId(System.Decimal? _scScheduleDtlDayId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScScheduleDtlDayId(null, _scScheduleDtlDayId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ABSENCE_SCHD_DTL_DY key.
		///		fkEdStudAbsenceSchdDtlDy Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudAbsence objects.</returns>
		public TList<EdStudAbsence> GetByScScheduleDtlDayId(System.Decimal? _scScheduleDtlDayId, int start, int pageLength,out int count)
		{
			return GetByScScheduleDtlDayId(null, _scScheduleDtlDayId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ABSENCE_SCHD_DTL_DY key.
		///		FK_ED_STUD_ABSENCE_SCHD_DTL_DY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudAbsence objects.</returns>
		public abstract TList<EdStudAbsence> GetByScScheduleDtlDayId(TransactionManager transactionManager, System.Decimal? _scScheduleDtlDayId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudAbsence Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudAbsenceKey key, int start, int pageLength)
		{
			return GetByEdStudAbsenceId(transactionManager, key.EdStudAbsenceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public abstract TList<EdStudAbsence> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(null,_edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public abstract TList<EdStudAbsence> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_COURSE_TEACH_1 index.
		/// </summary>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(null,_edCodeCourseTeachingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_TEACH_1 index.
		/// </summary>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(null, _edCodeCourseTeachingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_TEACH_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(transactionManager, _edCodeCourseTeachingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_TEACH_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(transactionManager, _edCodeCourseTeachingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_TEACH_1 index.
		/// </summary>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId, int start, int pageLength, out int count)
		{
			return GetByEdCodeCourseTeachingId(null, _edCodeCourseTeachingId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_TEACH_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public abstract TList<EdStudAbsence> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(null,_edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public abstract TList<EdStudAbsence> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdCourseId(System.Decimal _edCourseId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public abstract TList<EdStudAbsence> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(null,_edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public TList<EdStudAbsence> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudAbsence&gt;"/> class.</returns>
		public abstract TList<EdStudAbsence> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_ATTEND index.
		/// </summary>
		/// <param name="_edStudAbsenceId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudAbsence GetByEdStudAbsenceId(System.Decimal _edStudAbsenceId)
		{
			int count = -1;
			return GetByEdStudAbsenceId(null,_edStudAbsenceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ATTEND index.
		/// </summary>
		/// <param name="_edStudAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudAbsence GetByEdStudAbsenceId(System.Decimal _edStudAbsenceId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudAbsenceId(null, _edStudAbsenceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ATTEND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudAbsenceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudAbsence GetByEdStudAbsenceId(TransactionManager transactionManager, System.Decimal _edStudAbsenceId)
		{
			int count = -1;
			return GetByEdStudAbsenceId(transactionManager, _edStudAbsenceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ATTEND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudAbsence GetByEdStudAbsenceId(TransactionManager transactionManager, System.Decimal _edStudAbsenceId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudAbsenceId(transactionManager, _edStudAbsenceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ATTEND index.
		/// </summary>
		/// <param name="_edStudAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudAbsence GetByEdStudAbsenceId(System.Decimal _edStudAbsenceId, int start, int pageLength, out int count)
		{
			return GetByEdStudAbsenceId(null, _edStudAbsenceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ATTEND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudAbsence"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudAbsence GetByEdStudAbsenceId(TransactionManager transactionManager, System.Decimal _edStudAbsenceId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_ABSENCE index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_absDate"></param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudAbsence GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdStudIdAbsDateEdCodeCourseTeachingIdScScheduleDtlDayIdScSchdlSlotId(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.Decimal _edStudId, System.DateTime _absDate, System.Decimal? _edCodeCourseTeachingId, System.Decimal? _scScheduleDtlDayId, System.Decimal? _scSchdlSlotId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdStudIdAbsDateEdCodeCourseTeachingIdScScheduleDtlDayIdScSchdlSlotId(null,_edAcadYearId, _edCodeSemesterId, _edCourseId, _edStudId, _absDate, _edCodeCourseTeachingId, _scScheduleDtlDayId, _scSchdlSlotId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_ABSENCE index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_absDate"></param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudAbsence GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdStudIdAbsDateEdCodeCourseTeachingIdScScheduleDtlDayIdScSchdlSlotId(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.Decimal _edStudId, System.DateTime _absDate, System.Decimal? _edCodeCourseTeachingId, System.Decimal? _scScheduleDtlDayId, System.Decimal? _scSchdlSlotId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdStudIdAbsDateEdCodeCourseTeachingIdScScheduleDtlDayIdScSchdlSlotId(null, _edAcadYearId, _edCodeSemesterId, _edCourseId, _edStudId, _absDate, _edCodeCourseTeachingId, _scScheduleDtlDayId, _scSchdlSlotId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_absDate"></param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudAbsence GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdStudIdAbsDateEdCodeCourseTeachingIdScScheduleDtlDayIdScSchdlSlotId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.Decimal _edStudId, System.DateTime _absDate, System.Decimal? _edCodeCourseTeachingId, System.Decimal? _scScheduleDtlDayId, System.Decimal? _scSchdlSlotId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdStudIdAbsDateEdCodeCourseTeachingIdScScheduleDtlDayIdScSchdlSlotId(transactionManager, _edAcadYearId, _edCodeSemesterId, _edCourseId, _edStudId, _absDate, _edCodeCourseTeachingId, _scScheduleDtlDayId, _scSchdlSlotId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_absDate"></param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudAbsence GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdStudIdAbsDateEdCodeCourseTeachingIdScScheduleDtlDayIdScSchdlSlotId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.Decimal _edStudId, System.DateTime _absDate, System.Decimal? _edCodeCourseTeachingId, System.Decimal? _scScheduleDtlDayId, System.Decimal? _scSchdlSlotId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdStudIdAbsDateEdCodeCourseTeachingIdScScheduleDtlDayIdScSchdlSlotId(transactionManager, _edAcadYearId, _edCodeSemesterId, _edCourseId, _edStudId, _absDate, _edCodeCourseTeachingId, _scScheduleDtlDayId, _scSchdlSlotId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_ABSENCE index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_absDate"></param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudAbsence GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdStudIdAbsDateEdCodeCourseTeachingIdScScheduleDtlDayIdScSchdlSlotId(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.Decimal _edStudId, System.DateTime _absDate, System.Decimal? _edCodeCourseTeachingId, System.Decimal? _scScheduleDtlDayId, System.Decimal? _scSchdlSlotId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdStudIdAbsDateEdCodeCourseTeachingIdScScheduleDtlDayIdScSchdlSlotId(null, _edAcadYearId, _edCodeSemesterId, _edCourseId, _edStudId, _absDate, _edCodeCourseTeachingId, _scScheduleDtlDayId, _scSchdlSlotId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_absDate"></param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudAbsence"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudAbsence GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdStudIdAbsDateEdCodeCourseTeachingIdScScheduleDtlDayIdScSchdlSlotId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.Decimal _edStudId, System.DateTime _absDate, System.Decimal? _edCodeCourseTeachingId, System.Decimal? _scScheduleDtlDayId, System.Decimal? _scSchdlSlotId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudAbsence&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudAbsence&gt;"/></returns>
		public static TList<EdStudAbsence> Fill(IDataReader reader, TList<EdStudAbsence> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudAbsence c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudAbsence")
					.Append("|").Append((System.Decimal)reader["ED_STUD_ABSENCE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudAbsence>(
					key.ToString(), // EntityTrackingKey
					"EdStudAbsence",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudAbsence();
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
					c.EdStudAbsenceId = (System.Decimal)reader["ED_STUD_ABSENCE_ID"];
					c.OriginalEdStudAbsenceId = c.EdStudAbsenceId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.EdCodeCourseTeachingId = Convert.IsDBNull(reader["ED_CODE_COURSE_TEACHING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_TEACHING_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.ScScheduleDtlDayId = Convert.IsDBNull(reader["SC_SCHEDULE_DTL_DAY_ID"]) ? null : (System.Decimal?)reader["SC_SCHEDULE_DTL_DAY_ID"];
					c.ScGroupDayId = Convert.IsDBNull(reader["SC_GROUP_DAY_ID"]) ? null : (System.Decimal?)reader["SC_GROUP_DAY_ID"];
					c.AbsDate = (System.DateTime)reader["ABS_DATE"];
					c.AbsenceFlg = (System.Decimal)reader["ABSENCE_FLG"];
					c.ExecuseFlg = (System.Decimal)reader["EXECUSE_FLG"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.ApproveAbsFlg = Convert.IsDBNull(reader["APPROVE_ABS_FLG"]) ? null : (System.Boolean?)reader["APPROVE_ABS_FLG"];
					c.AutoFlg = Convert.IsDBNull(reader["AUTO_FLG"]) ? null : (System.Boolean?)reader["AUTO_FLG"];
					c.ScSchdlSlotId = Convert.IsDBNull(reader["SC_SCHDL_SLOT_ID"]) ? null : (System.Decimal?)reader["SC_SCHDL_SLOT_ID"];
					c.AbsNotes = Convert.IsDBNull(reader["ABS_NOTES"]) ? null : (System.String)reader["ABS_NOTES"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudAbsence"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudAbsence"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudAbsence entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudAbsenceId = (System.Decimal)reader[((int)EdStudAbsenceColumn.EdStudAbsenceId - 1)];
			entity.OriginalEdStudAbsenceId = (System.Decimal)reader["ED_STUD_ABSENCE_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)EdStudAbsenceColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)EdStudAbsenceColumn.EdCodeSemesterId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)EdStudAbsenceColumn.EdCourseId - 1)];
			entity.EdCodeCourseTeachingId = (reader.IsDBNull(((int)EdStudAbsenceColumn.EdCodeCourseTeachingId - 1)))?null:(System.Decimal?)reader[((int)EdStudAbsenceColumn.EdCodeCourseTeachingId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)EdStudAbsenceColumn.EdStudId - 1)];
			entity.ScScheduleDtlDayId = (reader.IsDBNull(((int)EdStudAbsenceColumn.ScScheduleDtlDayId - 1)))?null:(System.Decimal?)reader[((int)EdStudAbsenceColumn.ScScheduleDtlDayId - 1)];
			entity.ScGroupDayId = (reader.IsDBNull(((int)EdStudAbsenceColumn.ScGroupDayId - 1)))?null:(System.Decimal?)reader[((int)EdStudAbsenceColumn.ScGroupDayId - 1)];
			entity.AbsDate = (System.DateTime)reader[((int)EdStudAbsenceColumn.AbsDate - 1)];
			entity.AbsenceFlg = (System.Decimal)reader[((int)EdStudAbsenceColumn.AbsenceFlg - 1)];
			entity.ExecuseFlg = (System.Decimal)reader[((int)EdStudAbsenceColumn.ExecuseFlg - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdStudAbsenceColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdStudAbsenceColumn.AsFacultyInfoId - 1)];
			entity.ApproveAbsFlg = (reader.IsDBNull(((int)EdStudAbsenceColumn.ApproveAbsFlg - 1)))?null:(System.Boolean?)reader[((int)EdStudAbsenceColumn.ApproveAbsFlg - 1)];
			entity.AutoFlg = (reader.IsDBNull(((int)EdStudAbsenceColumn.AutoFlg - 1)))?null:(System.Boolean?)reader[((int)EdStudAbsenceColumn.AutoFlg - 1)];
			entity.ScSchdlSlotId = (reader.IsDBNull(((int)EdStudAbsenceColumn.ScSchdlSlotId - 1)))?null:(System.Decimal?)reader[((int)EdStudAbsenceColumn.ScSchdlSlotId - 1)];
			entity.AbsNotes = (reader.IsDBNull(((int)EdStudAbsenceColumn.AbsNotes - 1)))?null:(System.String)reader[((int)EdStudAbsenceColumn.AbsNotes - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudAbsenceColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudAbsenceColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudAbsenceColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudAbsenceColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudAbsence"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudAbsence"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudAbsence entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudAbsenceId = (System.Decimal)dataRow["ED_STUD_ABSENCE_ID"];
			entity.OriginalEdStudAbsenceId = (System.Decimal)dataRow["ED_STUD_ABSENCE_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.EdCodeCourseTeachingId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_TEACHING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_TEACHING_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.ScScheduleDtlDayId = Convert.IsDBNull(dataRow["SC_SCHEDULE_DTL_DAY_ID"]) ? null : (System.Decimal?)dataRow["SC_SCHEDULE_DTL_DAY_ID"];
			entity.ScGroupDayId = Convert.IsDBNull(dataRow["SC_GROUP_DAY_ID"]) ? null : (System.Decimal?)dataRow["SC_GROUP_DAY_ID"];
			entity.AbsDate = (System.DateTime)dataRow["ABS_DATE"];
			entity.AbsenceFlg = (System.Decimal)dataRow["ABSENCE_FLG"];
			entity.ExecuseFlg = (System.Decimal)dataRow["EXECUSE_FLG"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.ApproveAbsFlg = Convert.IsDBNull(dataRow["APPROVE_ABS_FLG"]) ? null : (System.Boolean?)dataRow["APPROVE_ABS_FLG"];
			entity.AutoFlg = Convert.IsDBNull(dataRow["AUTO_FLG"]) ? null : (System.Boolean?)dataRow["AUTO_FLG"];
			entity.ScSchdlSlotId = Convert.IsDBNull(dataRow["SC_SCHDL_SLOT_ID"]) ? null : (System.Decimal?)dataRow["SC_SCHDL_SLOT_ID"];
			entity.AbsNotes = Convert.IsDBNull(dataRow["ABS_NOTES"]) ? null : (System.String)dataRow["ABS_NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudAbsence"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudAbsence Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudAbsence entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdCodeCourseTeachingIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseTeaching|EdCodeCourseTeachingIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseTeachingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeCourseTeachingId ?? 0.0m);
				EdCodeCourseTeaching tmpEntity = EntityManager.LocateEntity<EdCodeCourseTeaching>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseTeaching), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseTeachingIdSource = tmpEntity;
				else
					entity.EdCodeCourseTeachingIdSource = DataRepository.EdCodeCourseTeachingProvider.GetByEdCodeCourseTeachingId(transactionManager, (entity.EdCodeCourseTeachingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseTeachingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseTeachingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseTeachingProvider.DeepLoad(transactionManager, entity.EdCodeCourseTeachingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseTeachingIdSource

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

			#region ScGroupDayIdSource	
			if (CanDeepLoad(entity, "GsCodeWeekDay|ScGroupDayIdSource", deepLoadType, innerList) 
				&& entity.ScGroupDayIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScGroupDayId ?? 0.0m);
				GsCodeWeekDay tmpEntity = EntityManager.LocateEntity<GsCodeWeekDay>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeWeekDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScGroupDayIdSource = tmpEntity;
				else
					entity.ScGroupDayIdSource = DataRepository.GsCodeWeekDayProvider.GetByGsCodeWeekDayId(transactionManager, (entity.ScGroupDayId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupDayIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScGroupDayIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeWeekDayProvider.DeepLoad(transactionManager, entity.ScGroupDayIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScGroupDayIdSource

			#region ScSchdlSlotIdSource	
			if (CanDeepLoad(entity, "ScSchdlSlot|ScSchdlSlotIdSource", deepLoadType, innerList) 
				&& entity.ScSchdlSlotIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScSchdlSlotId ?? 0.0m);
				ScSchdlSlot tmpEntity = EntityManager.LocateEntity<ScSchdlSlot>(EntityLocator.ConstructKeyFromPkItems(typeof(ScSchdlSlot), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScSchdlSlotIdSource = tmpEntity;
				else
					entity.ScSchdlSlotIdSource = DataRepository.ScSchdlSlotProvider.GetByScSchdlSlotId(transactionManager, (entity.ScSchdlSlotId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlSlotIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScSchdlSlotIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScSchdlSlotProvider.DeepLoad(transactionManager, entity.ScSchdlSlotIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScSchdlSlotIdSource

			#region ScScheduleDtlDayIdSource	
			if (CanDeepLoad(entity, "ScScheduleDtlDay|ScScheduleDtlDayIdSource", deepLoadType, innerList) 
				&& entity.ScScheduleDtlDayIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScScheduleDtlDayId ?? 0.0m);
				ScScheduleDtlDay tmpEntity = EntityManager.LocateEntity<ScScheduleDtlDay>(EntityLocator.ConstructKeyFromPkItems(typeof(ScScheduleDtlDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScScheduleDtlDayIdSource = tmpEntity;
				else
					entity.ScScheduleDtlDayIdSource = DataRepository.ScScheduleDtlDayProvider.GetByScScheduleDtlDayId(transactionManager, (entity.ScScheduleDtlDayId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlDayIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScScheduleDtlDayIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScScheduleDtlDayProvider.DeepLoad(transactionManager, entity.ScScheduleDtlDayIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScScheduleDtlDayIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdStudAbsenceId methods when available
			
			#region MltStudBhvrAttndcCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltStudBhvrAttndc>|MltStudBhvrAttndcCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltStudBhvrAttndcCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltStudBhvrAttndcCollection = DataRepository.MltStudBhvrAttndcProvider.GetByEdStudAbsenceId(transactionManager, entity.EdStudAbsenceId);

				if (deep && entity.MltStudBhvrAttndcCollection.Count > 0)
				{
					deepHandles.Add("MltStudBhvrAttndcCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltStudBhvrAttndc>) DataRepository.MltStudBhvrAttndcProvider.DeepLoad,
						new object[] { transactionManager, entity.MltStudBhvrAttndcCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudAbsence object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudAbsence instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudAbsence Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudAbsence entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EdCodeCourseTeachingIdSource
			if (CanDeepSave(entity, "EdCodeCourseTeaching|EdCodeCourseTeachingIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseTeachingIdSource != null)
			{
				DataRepository.EdCodeCourseTeachingProvider.Save(transactionManager, entity.EdCodeCourseTeachingIdSource);
				entity.EdCodeCourseTeachingId = entity.EdCodeCourseTeachingIdSource.EdCodeCourseTeachingId;
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
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
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
			
			#region ScGroupDayIdSource
			if (CanDeepSave(entity, "GsCodeWeekDay|ScGroupDayIdSource", deepSaveType, innerList) 
				&& entity.ScGroupDayIdSource != null)
			{
				DataRepository.GsCodeWeekDayProvider.Save(transactionManager, entity.ScGroupDayIdSource);
				entity.ScGroupDayId = entity.ScGroupDayIdSource.GsCodeWeekDayId;
			}
			#endregion 
			
			#region ScSchdlSlotIdSource
			if (CanDeepSave(entity, "ScSchdlSlot|ScSchdlSlotIdSource", deepSaveType, innerList) 
				&& entity.ScSchdlSlotIdSource != null)
			{
				DataRepository.ScSchdlSlotProvider.Save(transactionManager, entity.ScSchdlSlotIdSource);
				entity.ScSchdlSlotId = entity.ScSchdlSlotIdSource.ScSchdlSlotId;
			}
			#endregion 
			
			#region ScScheduleDtlDayIdSource
			if (CanDeepSave(entity, "ScScheduleDtlDay|ScScheduleDtlDayIdSource", deepSaveType, innerList) 
				&& entity.ScScheduleDtlDayIdSource != null)
			{
				DataRepository.ScScheduleDtlDayProvider.Save(transactionManager, entity.ScScheduleDtlDayIdSource);
				entity.ScScheduleDtlDayId = entity.ScScheduleDtlDayIdSource.ScScheduleDtlDayId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<MltStudBhvrAttndc>
				if (CanDeepSave(entity.MltStudBhvrAttndcCollection, "List<MltStudBhvrAttndc>|MltStudBhvrAttndcCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltStudBhvrAttndc child in entity.MltStudBhvrAttndcCollection)
					{
						if(child.EdStudAbsenceIdSource != null)
						{
							child.EdStudAbsenceId = child.EdStudAbsenceIdSource.EdStudAbsenceId;
						}
						else
						{
							child.EdStudAbsenceId = entity.EdStudAbsenceId;
						}

					}

					if (entity.MltStudBhvrAttndcCollection.Count > 0 || entity.MltStudBhvrAttndcCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltStudBhvrAttndcProvider.Save(transactionManager, entity.MltStudBhvrAttndcCollection);
						
						deepHandles.Add("MltStudBhvrAttndcCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltStudBhvrAttndc >) DataRepository.MltStudBhvrAttndcProvider.DeepSave,
							new object[] { transactionManager, entity.MltStudBhvrAttndcCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdStudAbsenceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudAbsence</c>
	///</summary>
	public enum EdStudAbsenceChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseTeaching</c> at EdCodeCourseTeachingIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseTeaching))]
		EdCodeCourseTeaching,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>GsCodeWeekDay</c> at ScGroupDayIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeWeekDay))]
		GsCodeWeekDay,
		
		///<summary>
		/// Composite Property for <c>ScSchdlSlot</c> at ScSchdlSlotIdSource
		///</summary>
		[ChildEntityType(typeof(ScSchdlSlot))]
		ScSchdlSlot,
		
		///<summary>
		/// Composite Property for <c>ScScheduleDtlDay</c> at ScScheduleDtlDayIdSource
		///</summary>
		[ChildEntityType(typeof(ScScheduleDtlDay))]
		ScScheduleDtlDay,
		///<summary>
		/// Collection of <c>EdStudAbsence</c> as OneToMany for MltStudBhvrAttndcCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltStudBhvrAttndc>))]
		MltStudBhvrAttndcCollection,
	}
	
	#endregion EdStudAbsenceChildEntityTypes
	
	#region EdStudAbsenceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudAbsenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudAbsence"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudAbsenceFilterBuilder : SqlFilterBuilder<EdStudAbsenceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudAbsenceFilterBuilder class.
		/// </summary>
		public EdStudAbsenceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudAbsenceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudAbsenceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudAbsenceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudAbsenceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudAbsenceFilterBuilder
	
	#region EdStudAbsenceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudAbsenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudAbsence"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudAbsenceParameterBuilder : ParameterizedSqlFilterBuilder<EdStudAbsenceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudAbsenceParameterBuilder class.
		/// </summary>
		public EdStudAbsenceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudAbsenceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudAbsenceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudAbsenceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudAbsenceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudAbsenceParameterBuilder
	
	#region EdStudAbsenceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudAbsenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudAbsence"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudAbsenceSortBuilder : SqlSortBuilder<EdStudAbsenceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudAbsenceSqlSortBuilder class.
		/// </summary>
		public EdStudAbsenceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudAbsenceSortBuilder
	
} // end namespace
