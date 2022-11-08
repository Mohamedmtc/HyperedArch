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
	/// This class is the base class for any <see cref="MltRptDayStudStsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MltRptDayStudStsProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MltRptDayStudSts, UMIS_VER2.BusinessLyer.MltRptDayStudStsKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltRptDayStudStsKey key)
		{
			return Delete(transactionManager, key.MltRptDayStudStsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mltRptDayStudStsId)
		{
			return Delete(null, _mltRptDayStudStsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mltRptDayStudStsId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR key.
		///		FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearJoinId">الدفعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public TList<MltRptDayStudSts> GetByEdAcadYearJoinId(System.Decimal _edAcadYearJoinId)
		{
			int count = -1;
			return GetByEdAcadYearJoinId(_edAcadYearJoinId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR key.
		///		FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearJoinId">الدفعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		/// <remarks></remarks>
		public TList<MltRptDayStudSts> GetByEdAcadYearJoinId(TransactionManager transactionManager, System.Decimal _edAcadYearJoinId)
		{
			int count = -1;
			return GetByEdAcadYearJoinId(transactionManager, _edAcadYearJoinId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR key.
		///		FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearJoinId">الدفعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public TList<MltRptDayStudSts> GetByEdAcadYearJoinId(TransactionManager transactionManager, System.Decimal _edAcadYearJoinId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearJoinId(transactionManager, _edAcadYearJoinId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR key.
		///		fkMltRptDayStudStsEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearJoinId">الدفعة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public TList<MltRptDayStudSts> GetByEdAcadYearJoinId(System.Decimal _edAcadYearJoinId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearJoinId(null, _edAcadYearJoinId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR key.
		///		fkMltRptDayStudStsEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearJoinId">الدفعة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public TList<MltRptDayStudSts> GetByEdAcadYearJoinId(System.Decimal _edAcadYearJoinId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearJoinId(null, _edAcadYearJoinId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR key.
		///		FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearJoinId">الدفعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public abstract TList<MltRptDayStudSts> GetByEdAcadYearJoinId(TransactionManager transactionManager, System.Decimal _edAcadYearJoinId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR1 key.
		///		FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public TList<MltRptDayStudSts> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR1 key.
		///		FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		/// <remarks></remarks>
		public TList<MltRptDayStudSts> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR1 key.
		///		FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public TList<MltRptDayStudSts> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR1 key.
		///		fkMltRptDayStudStsEdAcadYear1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public TList<MltRptDayStudSts> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR1 key.
		///		fkMltRptDayStudStsEdAcadYear1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public TList<MltRptDayStudSts> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR1 key.
		///		FK_MLT_RPT_DAY_STUD_STS_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public abstract TList<MltRptDayStudSts> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_ED_CODE_SEMESTER key.
		///		FK_MLT_RPT_DAY_STUD_STS_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public TList<MltRptDayStudSts> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_ED_CODE_SEMESTER key.
		///		FK_MLT_RPT_DAY_STUD_STS_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		/// <remarks></remarks>
		public TList<MltRptDayStudSts> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_ED_CODE_SEMESTER key.
		///		FK_MLT_RPT_DAY_STUD_STS_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public TList<MltRptDayStudSts> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_ED_CODE_SEMESTER key.
		///		fkMltRptDayStudStsEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public TList<MltRptDayStudSts> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_ED_CODE_SEMESTER key.
		///		fkMltRptDayStudStsEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public TList<MltRptDayStudSts> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_ED_CODE_SEMESTER key.
		///		FK_MLT_RPT_DAY_STUD_STS_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public abstract TList<MltRptDayStudSts> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_MLT_ORG_TREE key.
		///		FK_MLT_RPT_DAY_STUD_STS_MLT_ORG_TREE Description: 
		/// </summary>
		/// <param name="_mltOrgTreeId">الكتيبة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public TList<MltRptDayStudSts> GetByMltOrgTreeId(System.Decimal _mltOrgTreeId)
		{
			int count = -1;
			return GetByMltOrgTreeId(_mltOrgTreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_MLT_ORG_TREE key.
		///		FK_MLT_RPT_DAY_STUD_STS_MLT_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltOrgTreeId">الكتيبة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		/// <remarks></remarks>
		public TList<MltRptDayStudSts> GetByMltOrgTreeId(TransactionManager transactionManager, System.Decimal _mltOrgTreeId)
		{
			int count = -1;
			return GetByMltOrgTreeId(transactionManager, _mltOrgTreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_MLT_ORG_TREE key.
		///		FK_MLT_RPT_DAY_STUD_STS_MLT_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltOrgTreeId">الكتيبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public TList<MltRptDayStudSts> GetByMltOrgTreeId(TransactionManager transactionManager, System.Decimal _mltOrgTreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltOrgTreeId(transactionManager, _mltOrgTreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_MLT_ORG_TREE key.
		///		fkMltRptDayStudStsMltOrgTree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltOrgTreeId">الكتيبة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public TList<MltRptDayStudSts> GetByMltOrgTreeId(System.Decimal _mltOrgTreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMltOrgTreeId(null, _mltOrgTreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_MLT_ORG_TREE key.
		///		fkMltRptDayStudStsMltOrgTree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltOrgTreeId">الكتيبة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public TList<MltRptDayStudSts> GetByMltOrgTreeId(System.Decimal _mltOrgTreeId, int start, int pageLength,out int count)
		{
			return GetByMltOrgTreeId(null, _mltOrgTreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_STUD_STS_MLT_ORG_TREE key.
		///		FK_MLT_RPT_DAY_STUD_STS_MLT_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltOrgTreeId">الكتيبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayStudSts objects.</returns>
		public abstract TList<MltRptDayStudSts> GetByMltOrgTreeId(TransactionManager transactionManager, System.Decimal _mltOrgTreeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.MltRptDayStudSts Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltRptDayStudStsKey key, int start, int pageLength)
		{
			return GetByMltRptDayStudStsId(transactionManager, key.MltRptDayStudStsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MLT_RPT_DAY_STUD_STS index.
		/// </summary>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayStudSts"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayStudSts GetByMltRptDayStudStsId(System.Decimal _mltRptDayStudStsId)
		{
			int count = -1;
			return GetByMltRptDayStudStsId(null,_mltRptDayStudStsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_STUD_STS index.
		/// </summary>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayStudSts"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayStudSts GetByMltRptDayStudStsId(System.Decimal _mltRptDayStudStsId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltRptDayStudStsId(null, _mltRptDayStudStsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_STUD_STS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayStudSts"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayStudSts GetByMltRptDayStudStsId(TransactionManager transactionManager, System.Decimal _mltRptDayStudStsId)
		{
			int count = -1;
			return GetByMltRptDayStudStsId(transactionManager, _mltRptDayStudStsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_STUD_STS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayStudSts"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayStudSts GetByMltRptDayStudStsId(TransactionManager transactionManager, System.Decimal _mltRptDayStudStsId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltRptDayStudStsId(transactionManager, _mltRptDayStudStsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_STUD_STS index.
		/// </summary>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayStudSts"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayStudSts GetByMltRptDayStudStsId(System.Decimal _mltRptDayStudStsId, int start, int pageLength, out int count)
		{
			return GetByMltRptDayStudStsId(null, _mltRptDayStudStsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_STUD_STS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayStudSts"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MltRptDayStudSts GetByMltRptDayStudStsId(TransactionManager transactionManager, System.Decimal _mltRptDayStudStsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MltRptDayStudSts&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MltRptDayStudSts&gt;"/></returns>
		public static TList<MltRptDayStudSts> Fill(IDataReader reader, TList<MltRptDayStudSts> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MltRptDayStudSts c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MltRptDayStudSts")
					.Append("|").Append((System.Decimal)reader["MLT_RPT_DAY_STUD_STS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MltRptDayStudSts>(
					key.ToString(), // EntityTrackingKey
					"MltRptDayStudSts",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MltRptDayStudSts();
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
					c.MltRptDayStudStsId = (System.Decimal)reader["MLT_RPT_DAY_STUD_STS_ID"];
					c.OriginalMltRptDayStudStsId = c.MltRptDayStudStsId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.DayDate = (System.DateTime)reader["DAY_DATE"];
					c.EdAcadYearJoinId = (System.Decimal)reader["ED_ACAD_YEAR_JOIN_ID"];
					c.MltOrgTreeId = (System.Decimal)reader["MLT_ORG_TREE_ID"];
					c.TotCount = Convert.IsDBNull(reader["TOT_COUNT"]) ? null : (System.Decimal?)reader["TOT_COUNT"];
					c.ExistCount = Convert.IsDBNull(reader["EXIST_COUNT"]) ? null : (System.Decimal?)reader["EXIST_COUNT"];
					c.OutCount = Convert.IsDBNull(reader["OUT_COUNT"]) ? null : (System.Decimal?)reader["OUT_COUNT"];
					c.UnderObservCount = Convert.IsDBNull(reader["UNDER_OBSERV_COUNT"]) ? null : (System.Decimal?)reader["UNDER_OBSERV_COUNT"];
					c.InPrisonCount = Convert.IsDBNull(reader["IN_PRISON_COUNT"]) ? null : (System.Decimal?)reader["IN_PRISON_COUNT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltRptDayStudSts"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltRptDayStudSts"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MltRptDayStudSts entity)
		{
			if (!reader.Read()) return;
			
			entity.MltRptDayStudStsId = (System.Decimal)reader[((int)MltRptDayStudStsColumn.MltRptDayStudStsId - 1)];
			entity.OriginalMltRptDayStudStsId = (System.Decimal)reader["MLT_RPT_DAY_STUD_STS_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)MltRptDayStudStsColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)MltRptDayStudStsColumn.EdCodeSemesterId - 1)];
			entity.DayDate = (System.DateTime)reader[((int)MltRptDayStudStsColumn.DayDate - 1)];
			entity.EdAcadYearJoinId = (System.Decimal)reader[((int)MltRptDayStudStsColumn.EdAcadYearJoinId - 1)];
			entity.MltOrgTreeId = (System.Decimal)reader[((int)MltRptDayStudStsColumn.MltOrgTreeId - 1)];
			entity.TotCount = (reader.IsDBNull(((int)MltRptDayStudStsColumn.TotCount - 1)))?null:(System.Decimal?)reader[((int)MltRptDayStudStsColumn.TotCount - 1)];
			entity.ExistCount = (reader.IsDBNull(((int)MltRptDayStudStsColumn.ExistCount - 1)))?null:(System.Decimal?)reader[((int)MltRptDayStudStsColumn.ExistCount - 1)];
			entity.OutCount = (reader.IsDBNull(((int)MltRptDayStudStsColumn.OutCount - 1)))?null:(System.Decimal?)reader[((int)MltRptDayStudStsColumn.OutCount - 1)];
			entity.UnderObservCount = (reader.IsDBNull(((int)MltRptDayStudStsColumn.UnderObservCount - 1)))?null:(System.Decimal?)reader[((int)MltRptDayStudStsColumn.UnderObservCount - 1)];
			entity.InPrisonCount = (reader.IsDBNull(((int)MltRptDayStudStsColumn.InPrisonCount - 1)))?null:(System.Decimal?)reader[((int)MltRptDayStudStsColumn.InPrisonCount - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltRptDayStudSts"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltRptDayStudSts"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MltRptDayStudSts entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MltRptDayStudStsId = (System.Decimal)dataRow["MLT_RPT_DAY_STUD_STS_ID"];
			entity.OriginalMltRptDayStudStsId = (System.Decimal)dataRow["MLT_RPT_DAY_STUD_STS_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.DayDate = (System.DateTime)dataRow["DAY_DATE"];
			entity.EdAcadYearJoinId = (System.Decimal)dataRow["ED_ACAD_YEAR_JOIN_ID"];
			entity.MltOrgTreeId = (System.Decimal)dataRow["MLT_ORG_TREE_ID"];
			entity.TotCount = Convert.IsDBNull(dataRow["TOT_COUNT"]) ? null : (System.Decimal?)dataRow["TOT_COUNT"];
			entity.ExistCount = Convert.IsDBNull(dataRow["EXIST_COUNT"]) ? null : (System.Decimal?)dataRow["EXIST_COUNT"];
			entity.OutCount = Convert.IsDBNull(dataRow["OUT_COUNT"]) ? null : (System.Decimal?)dataRow["OUT_COUNT"];
			entity.UnderObservCount = Convert.IsDBNull(dataRow["UNDER_OBSERV_COUNT"]) ? null : (System.Decimal?)dataRow["UNDER_OBSERV_COUNT"];
			entity.InPrisonCount = Convert.IsDBNull(dataRow["IN_PRISON_COUNT"]) ? null : (System.Decimal?)dataRow["IN_PRISON_COUNT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltRptDayStudSts"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltRptDayStudSts Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltRptDayStudSts entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearJoinIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearJoinIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearJoinIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdAcadYearJoinId;
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearJoinIdSource = tmpEntity;
				else
					entity.EdAcadYearJoinIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearJoinId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearJoinIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearJoinIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearJoinIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearJoinIdSource

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

			#region MltOrgTreeIdSource	
			if (CanDeepLoad(entity, "MltOrgTree|MltOrgTreeIdSource", deepLoadType, innerList) 
				&& entity.MltOrgTreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MltOrgTreeId;
				MltOrgTree tmpEntity = EntityManager.LocateEntity<MltOrgTree>(EntityLocator.ConstructKeyFromPkItems(typeof(MltOrgTree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MltOrgTreeIdSource = tmpEntity;
				else
					entity.MltOrgTreeIdSource = DataRepository.MltOrgTreeProvider.GetByMltOrgTreeId(transactionManager, entity.MltOrgTreeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltOrgTreeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MltOrgTreeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MltOrgTreeProvider.DeepLoad(transactionManager, entity.MltOrgTreeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MltOrgTreeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMltRptDayStudStsId methods when available
			
			#region MltRptDayMissionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltRptDayMission>|MltRptDayMissionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltRptDayMissionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltRptDayMissionCollection = DataRepository.MltRptDayMissionProvider.GetByMltRptDayStudStsId(transactionManager, entity.MltRptDayStudStsId);

				if (deep && entity.MltRptDayMissionCollection.Count > 0)
				{
					deepHandles.Add("MltRptDayMissionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltRptDayMission>) DataRepository.MltRptDayMissionProvider.DeepLoad,
						new object[] { transactionManager, entity.MltRptDayMissionCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MltRptDayOutCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltRptDayOut>|MltRptDayOutCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltRptDayOutCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltRptDayOutCollection = DataRepository.MltRptDayOutProvider.GetByMltRptDayStudStsId(transactionManager, entity.MltRptDayStudStsId);

				if (deep && entity.MltRptDayOutCollection.Count > 0)
				{
					deepHandles.Add("MltRptDayOutCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltRptDayOut>) DataRepository.MltRptDayOutProvider.DeepLoad,
						new object[] { transactionManager, entity.MltRptDayOutCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MltRptDayStudSts object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MltRptDayStudSts instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltRptDayStudSts Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltRptDayStudSts entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdAcadYearJoinIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearJoinIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearJoinIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearJoinIdSource);
				entity.EdAcadYearJoinId = entity.EdAcadYearJoinIdSource.EdAcadYearId;
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
			
			#region MltOrgTreeIdSource
			if (CanDeepSave(entity, "MltOrgTree|MltOrgTreeIdSource", deepSaveType, innerList) 
				&& entity.MltOrgTreeIdSource != null)
			{
				DataRepository.MltOrgTreeProvider.Save(transactionManager, entity.MltOrgTreeIdSource);
				entity.MltOrgTreeId = entity.MltOrgTreeIdSource.MltOrgTreeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<MltRptDayMission>
				if (CanDeepSave(entity.MltRptDayMissionCollection, "List<MltRptDayMission>|MltRptDayMissionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltRptDayMission child in entity.MltRptDayMissionCollection)
					{
						if(child.MltRptDayStudStsIdSource != null)
						{
							child.MltRptDayStudStsId = child.MltRptDayStudStsIdSource.MltRptDayStudStsId;
						}
						else
						{
							child.MltRptDayStudStsId = entity.MltRptDayStudStsId;
						}

					}

					if (entity.MltRptDayMissionCollection.Count > 0 || entity.MltRptDayMissionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltRptDayMissionProvider.Save(transactionManager, entity.MltRptDayMissionCollection);
						
						deepHandles.Add("MltRptDayMissionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltRptDayMission >) DataRepository.MltRptDayMissionProvider.DeepSave,
							new object[] { transactionManager, entity.MltRptDayMissionCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MltRptDayOut>
				if (CanDeepSave(entity.MltRptDayOutCollection, "List<MltRptDayOut>|MltRptDayOutCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltRptDayOut child in entity.MltRptDayOutCollection)
					{
						if(child.MltRptDayStudStsIdSource != null)
						{
							child.MltRptDayStudStsId = child.MltRptDayStudStsIdSource.MltRptDayStudStsId;
						}
						else
						{
							child.MltRptDayStudStsId = entity.MltRptDayStudStsId;
						}

					}

					if (entity.MltRptDayOutCollection.Count > 0 || entity.MltRptDayOutCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltRptDayOutProvider.Save(transactionManager, entity.MltRptDayOutCollection);
						
						deepHandles.Add("MltRptDayOutCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltRptDayOut >) DataRepository.MltRptDayOutProvider.DeepSave,
							new object[] { transactionManager, entity.MltRptDayOutCollection, deepSaveType, childTypes, innerList }
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
	
	#region MltRptDayStudStsChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MltRptDayStudSts</c>
	///</summary>
	public enum MltRptDayStudStsChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearJoinIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>MltOrgTree</c> at MltOrgTreeIdSource
		///</summary>
		[ChildEntityType(typeof(MltOrgTree))]
		MltOrgTree,
		///<summary>
		/// Collection of <c>MltRptDayStudSts</c> as OneToMany for MltRptDayMissionCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltRptDayMission>))]
		MltRptDayMissionCollection,
		///<summary>
		/// Collection of <c>MltRptDayStudSts</c> as OneToMany for MltRptDayOutCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltRptDayOut>))]
		MltRptDayOutCollection,
	}
	
	#endregion MltRptDayStudStsChildEntityTypes
	
	#region MltRptDayStudStsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MltRptDayStudStsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltRptDayStudSts"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltRptDayStudStsFilterBuilder : SqlFilterBuilder<MltRptDayStudStsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltRptDayStudStsFilterBuilder class.
		/// </summary>
		public MltRptDayStudStsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltRptDayStudStsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltRptDayStudStsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltRptDayStudStsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltRptDayStudStsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltRptDayStudStsFilterBuilder
	
	#region MltRptDayStudStsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MltRptDayStudStsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltRptDayStudSts"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltRptDayStudStsParameterBuilder : ParameterizedSqlFilterBuilder<MltRptDayStudStsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltRptDayStudStsParameterBuilder class.
		/// </summary>
		public MltRptDayStudStsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltRptDayStudStsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltRptDayStudStsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltRptDayStudStsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltRptDayStudStsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltRptDayStudStsParameterBuilder
	
	#region MltRptDayStudStsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MltRptDayStudStsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltRptDayStudSts"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MltRptDayStudStsSortBuilder : SqlSortBuilder<MltRptDayStudStsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltRptDayStudStsSqlSortBuilder class.
		/// </summary>
		public MltRptDayStudStsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MltRptDayStudStsSortBuilder
	
} // end namespace
