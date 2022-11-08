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
	/// This class is the base class for any <see cref="FeeItemTrnsBlncProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeItemTrnsBlncProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc, UMIS_VER2.BusinessLyer.FeeItemTrnsBlncKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeItemTrnsBlncKey key)
		{
			return Delete(transactionManager, key.FeeItemTrnsBlncId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeItemTrnsBlncId">عمليات الحسابات على بنود والرصيد. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeItemTrnsBlncId)
		{
			return Delete(null, _feeItemTrnsBlncId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeItemTrnsBlncId">عمليات الحسابات على بنود والرصيد. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeItemTrnsBlncId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_ACAD_YEAR key.
		///		FK_FEE_ITEM_TRNS_BLNC_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_ACAD_YEAR key.
		///		FK_FEE_ITEM_TRNS_BLNC_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		/// <remarks></remarks>
		public TList<FeeItemTrnsBlnc> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_ACAD_YEAR key.
		///		FK_FEE_ITEM_TRNS_BLNC_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_ACAD_YEAR key.
		///		fkFeeItemTrnsBlncEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_ACAD_YEAR key.
		///		fkFeeItemTrnsBlncEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_ACAD_YEAR key.
		///		FK_FEE_ITEM_TRNS_BLNC_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public abstract TList<FeeItemTrnsBlnc> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_CODE_SEMESTER key.
		///		FK_FEE_ITEM_TRNS_BLNC_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_CODE_SEMESTER key.
		///		FK_FEE_ITEM_TRNS_BLNC_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		/// <remarks></remarks>
		public TList<FeeItemTrnsBlnc> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_CODE_SEMESTER key.
		///		FK_FEE_ITEM_TRNS_BLNC_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_CODE_SEMESTER key.
		///		fkFeeItemTrnsBlncEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_CODE_SEMESTER key.
		///		fkFeeItemTrnsBlncEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_CODE_SEMESTER key.
		///		FK_FEE_ITEM_TRNS_BLNC_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public abstract TList<FeeItemTrnsBlnc> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_STUD key.
		///		FK_FEE_ITEM_TRNS_BLNC_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_STUD key.
		///		FK_FEE_ITEM_TRNS_BLNC_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		/// <remarks></remarks>
		public TList<FeeItemTrnsBlnc> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_STUD key.
		///		FK_FEE_ITEM_TRNS_BLNC_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_STUD key.
		///		fkFeeItemTrnsBlncEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_STUD key.
		///		fkFeeItemTrnsBlncEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_STUD key.
		///		FK_FEE_ITEM_TRNS_BLNC_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public abstract TList<FeeItemTrnsBlnc> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_STUD_COURSE_REG key.
		///		FK_FEE_ITEM_TRNS_BLNC_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByEdStudCourseRegId(System.Decimal? _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(_edStudCourseRegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_STUD_COURSE_REG key.
		///		FK_FEE_ITEM_TRNS_BLNC_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		/// <remarks></remarks>
		public TList<FeeItemTrnsBlnc> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal? _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_STUD_COURSE_REG key.
		///		FK_FEE_ITEM_TRNS_BLNC_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal? _edStudCourseRegId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_STUD_COURSE_REG key.
		///		fkFeeItemTrnsBlncEdStudCourseReg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByEdStudCourseRegId(System.Decimal? _edStudCourseRegId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_STUD_COURSE_REG key.
		///		fkFeeItemTrnsBlncEdStudCourseReg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByEdStudCourseRegId(System.Decimal? _edStudCourseRegId, int start, int pageLength,out int count)
		{
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_ED_STUD_COURSE_REG key.
		///		FK_FEE_ITEM_TRNS_BLNC_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public abstract TList<FeeItemTrnsBlnc> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal? _edStudCourseRegId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_CODE_ITEM key.
		///		FK_FEE_ITEM_TRNS_BLNC_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="_feeCodeItemId">بند حساب -بند رصيد 0</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByFeeCodeItemId(System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(_feeCodeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_CODE_ITEM key.
		///		FK_FEE_ITEM_TRNS_BLNC_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">بند حساب -بند رصيد 0</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		/// <remarks></remarks>
		public TList<FeeItemTrnsBlnc> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_CODE_ITEM key.
		///		FK_FEE_ITEM_TRNS_BLNC_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">بند حساب -بند رصيد 0</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_CODE_ITEM key.
		///		fkFeeItemTrnsBlncFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId">بند حساب -بند رصيد 0</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_CODE_ITEM key.
		///		fkFeeItemTrnsBlncFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId">بند حساب -بند رصيد 0</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_CODE_ITEM key.
		///		FK_FEE_ITEM_TRNS_BLNC_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">بند حساب -بند رصيد 0</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public abstract TList<FeeItemTrnsBlnc> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_DISC key.
		///		FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="_feeStudDiscId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByFeeStudDiscId(System.Decimal? _feeStudDiscId)
		{
			int count = -1;
			return GetByFeeStudDiscId(_feeStudDiscId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_DISC key.
		///		FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		/// <remarks></remarks>
		public TList<FeeItemTrnsBlnc> GetByFeeStudDiscId(TransactionManager transactionManager, System.Decimal? _feeStudDiscId)
		{
			int count = -1;
			return GetByFeeStudDiscId(transactionManager, _feeStudDiscId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_DISC key.
		///		FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByFeeStudDiscId(TransactionManager transactionManager, System.Decimal? _feeStudDiscId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudDiscId(transactionManager, _feeStudDiscId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_DISC key.
		///		fkFeeItemTrnsBlncFeeStudDisc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudDiscId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByFeeStudDiscId(System.Decimal? _feeStudDiscId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudDiscId(null, _feeStudDiscId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_DISC key.
		///		fkFeeItemTrnsBlncFeeStudDisc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudDiscId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByFeeStudDiscId(System.Decimal? _feeStudDiscId, int start, int pageLength,out int count)
		{
			return GetByFeeStudDiscId(null, _feeStudDiscId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_DISC key.
		///		FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public abstract TList<FeeItemTrnsBlnc> GetByFeeStudDiscId(TransactionManager transactionManager, System.Decimal? _feeStudDiscId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByFeeStudFeeItemId(System.Decimal? _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(_feeStudFeeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		/// <remarks></remarks>
		public TList<FeeItemTrnsBlnc> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal? _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal? _feeStudFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_FEE_ITEM key.
		///		fkFeeItemTrnsBlncFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByFeeStudFeeItemId(System.Decimal? _feeStudFeeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_FEE_ITEM key.
		///		fkFeeItemTrnsBlncFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByFeeStudFeeItemId(System.Decimal? _feeStudFeeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public abstract TList<FeeItemTrnsBlnc> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal? _feeStudFeeItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_VOUCHER_ITEM key.
		///		FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_VOUCHER_ITEM Description: 
		/// </summary>
		/// <param name="_feeStudVoucherItemId">اذن دفع/ايصال سداد</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByFeeStudVoucherItemId(System.Decimal? _feeStudVoucherItemId)
		{
			int count = -1;
			return GetByFeeStudVoucherItemId(_feeStudVoucherItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_VOUCHER_ITEM key.
		///		FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_VOUCHER_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherItemId">اذن دفع/ايصال سداد</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		/// <remarks></remarks>
		public TList<FeeItemTrnsBlnc> GetByFeeStudVoucherItemId(TransactionManager transactionManager, System.Decimal? _feeStudVoucherItemId)
		{
			int count = -1;
			return GetByFeeStudVoucherItemId(transactionManager, _feeStudVoucherItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_VOUCHER_ITEM key.
		///		FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_VOUCHER_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherItemId">اذن دفع/ايصال سداد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByFeeStudVoucherItemId(TransactionManager transactionManager, System.Decimal? _feeStudVoucherItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherItemId(transactionManager, _feeStudVoucherItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_VOUCHER_ITEM key.
		///		fkFeeItemTrnsBlncFeeStudVoucherItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudVoucherItemId">اذن دفع/ايصال سداد</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByFeeStudVoucherItemId(System.Decimal? _feeStudVoucherItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudVoucherItemId(null, _feeStudVoucherItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_VOUCHER_ITEM key.
		///		fkFeeItemTrnsBlncFeeStudVoucherItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudVoucherItemId">اذن دفع/ايصال سداد</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetByFeeStudVoucherItemId(System.Decimal? _feeStudVoucherItemId, int start, int pageLength,out int count)
		{
			return GetByFeeStudVoucherItemId(null, _feeStudVoucherItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_VOUCHER_ITEM key.
		///		FK_FEE_ITEM_TRNS_BLNC_FEE_STUD_VOUCHER_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherItemId">اذن دفع/ايصال سداد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public abstract TList<FeeItemTrnsBlnc> GetByFeeStudVoucherItemId(TransactionManager transactionManager, System.Decimal? _feeStudVoucherItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_SE_USER key.
		///		FK_FEE_ITEM_TRNS_BLNC_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserTrnsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetBySeUserTrnsId(System.Decimal? _seUserTrnsId)
		{
			int count = -1;
			return GetBySeUserTrnsId(_seUserTrnsId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_SE_USER key.
		///		FK_FEE_ITEM_TRNS_BLNC_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserTrnsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		/// <remarks></remarks>
		public TList<FeeItemTrnsBlnc> GetBySeUserTrnsId(TransactionManager transactionManager, System.Decimal? _seUserTrnsId)
		{
			int count = -1;
			return GetBySeUserTrnsId(transactionManager, _seUserTrnsId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_SE_USER key.
		///		FK_FEE_ITEM_TRNS_BLNC_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserTrnsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetBySeUserTrnsId(TransactionManager transactionManager, System.Decimal? _seUserTrnsId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserTrnsId(transactionManager, _seUserTrnsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_SE_USER key.
		///		fkFeeItemTrnsBlncSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserTrnsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetBySeUserTrnsId(System.Decimal? _seUserTrnsId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserTrnsId(null, _seUserTrnsId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_SE_USER key.
		///		fkFeeItemTrnsBlncSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserTrnsId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public TList<FeeItemTrnsBlnc> GetBySeUserTrnsId(System.Decimal? _seUserTrnsId, int start, int pageLength,out int count)
		{
			return GetBySeUserTrnsId(null, _seUserTrnsId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_TRNS_BLNC_SE_USER key.
		///		FK_FEE_ITEM_TRNS_BLNC_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserTrnsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc objects.</returns>
		public abstract TList<FeeItemTrnsBlnc> GetBySeUserTrnsId(TransactionManager transactionManager, System.Decimal? _seUserTrnsId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeItemTrnsBlncKey key, int start, int pageLength)
		{
			return GetByFeeItemTrnsBlncId(transactionManager, key.FeeItemTrnsBlncId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_ITEM_TRNS_BLNC index.
		/// </summary>
		/// <param name="_feeItemTrnsBlncId">عمليات الحسابات على بنود والرصيد</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc GetByFeeItemTrnsBlncId(System.Decimal _feeItemTrnsBlncId)
		{
			int count = -1;
			return GetByFeeItemTrnsBlncId(null,_feeItemTrnsBlncId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ITEM_TRNS_BLNC index.
		/// </summary>
		/// <param name="_feeItemTrnsBlncId">عمليات الحسابات على بنود والرصيد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc GetByFeeItemTrnsBlncId(System.Decimal _feeItemTrnsBlncId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeItemTrnsBlncId(null, _feeItemTrnsBlncId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ITEM_TRNS_BLNC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeItemTrnsBlncId">عمليات الحسابات على بنود والرصيد</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc GetByFeeItemTrnsBlncId(TransactionManager transactionManager, System.Decimal _feeItemTrnsBlncId)
		{
			int count = -1;
			return GetByFeeItemTrnsBlncId(transactionManager, _feeItemTrnsBlncId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ITEM_TRNS_BLNC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeItemTrnsBlncId">عمليات الحسابات على بنود والرصيد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc GetByFeeItemTrnsBlncId(TransactionManager transactionManager, System.Decimal _feeItemTrnsBlncId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeItemTrnsBlncId(transactionManager, _feeItemTrnsBlncId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ITEM_TRNS_BLNC index.
		/// </summary>
		/// <param name="_feeItemTrnsBlncId">عمليات الحسابات على بنود والرصيد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc GetByFeeItemTrnsBlncId(System.Decimal _feeItemTrnsBlncId, int start, int pageLength, out int count)
		{
			return GetByFeeItemTrnsBlncId(null, _feeItemTrnsBlncId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ITEM_TRNS_BLNC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeItemTrnsBlncId">عمليات الحسابات على بنود والرصيد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc GetByFeeItemTrnsBlncId(TransactionManager transactionManager, System.Decimal _feeItemTrnsBlncId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeItemTrnsBlnc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeItemTrnsBlnc&gt;"/></returns>
		public static TList<FeeItemTrnsBlnc> Fill(IDataReader reader, TList<FeeItemTrnsBlnc> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeItemTrnsBlnc")
					.Append("|").Append((System.Decimal)reader["FEE_ITEM_TRNS_BLNC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeItemTrnsBlnc>(
					key.ToString(), // EntityTrackingKey
					"FeeItemTrnsBlnc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc();
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
					c.FeeItemTrnsBlncId = (System.Decimal)reader["FEE_ITEM_TRNS_BLNC_ID"];
					c.OriginalFeeItemTrnsBlncId = c.FeeItemTrnsBlncId;
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.FeeCodeItemId = (System.Decimal)reader["FEE_CODE_ITEM_ID"];
					c.DebitAmnt = Convert.IsDBNull(reader["DEBIT_AMNT"]) ? null : (System.Decimal?)reader["DEBIT_AMNT"];
					c.CreditAmnt = Convert.IsDBNull(reader["CREDIT_AMNT"]) ? null : (System.Decimal?)reader["CREDIT_AMNT"];
					c.BalanceAmnt = Convert.IsDBNull(reader["BALANCE_AMNT"]) ? null : (System.Decimal?)reader["BALANCE_AMNT"];
					c.TrnsDate = (System.DateTime)reader["TRNS_DATE"];
					c.TrnsDesc = Convert.IsDBNull(reader["TRNS_DESC"]) ? null : (System.String)reader["TRNS_DESC"];
					c.FeeStudVoucherItemId = Convert.IsDBNull(reader["FEE_STUD_VOUCHER_ITEM_ID"]) ? null : (System.Decimal?)reader["FEE_STUD_VOUCHER_ITEM_ID"];
					c.FeeRefndStdReqId = Convert.IsDBNull(reader["FEE_REFND_STD_REQ_ID"]) ? null : (System.Decimal?)reader["FEE_REFND_STD_REQ_ID"];
					c.EdStudCourseRegId = Convert.IsDBNull(reader["ED_STUD_COURSE_REG_ID"]) ? null : (System.Decimal?)reader["ED_STUD_COURSE_REG_ID"];
					c.FeeStudDiscId = Convert.IsDBNull(reader["FEE_STUD_DISC_ID"]) ? null : (System.Decimal?)reader["FEE_STUD_DISC_ID"];
					c.FeeStudFeeItemId = Convert.IsDBNull(reader["FEE_STUD_FEE_ITEM_ID"]) ? null : (System.Decimal?)reader["FEE_STUD_FEE_ITEM_ID"];
					c.TrnsTypeId = Convert.IsDBNull(reader["TRNS_TYPE_ID"]) ? null : (System.Int32?)reader["TRNS_TYPE_ID"];
					c.SeUserTrnsId = Convert.IsDBNull(reader["SE_USER_TRNS_ID"]) ? null : (System.Decimal?)reader["SE_USER_TRNS_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeItemTrnsBlncId = (System.Decimal)reader[((int)FeeItemTrnsBlncColumn.FeeItemTrnsBlncId - 1)];
			entity.OriginalFeeItemTrnsBlncId = (System.Decimal)reader["FEE_ITEM_TRNS_BLNC_ID"];
			entity.EdStudId = (System.Decimal)reader[((int)FeeItemTrnsBlncColumn.EdStudId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)FeeItemTrnsBlncColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)FeeItemTrnsBlncColumn.EdCodeSemesterId - 1)];
			entity.FeeCodeItemId = (System.Decimal)reader[((int)FeeItemTrnsBlncColumn.FeeCodeItemId - 1)];
			entity.DebitAmnt = (reader.IsDBNull(((int)FeeItemTrnsBlncColumn.DebitAmnt - 1)))?null:(System.Decimal?)reader[((int)FeeItemTrnsBlncColumn.DebitAmnt - 1)];
			entity.CreditAmnt = (reader.IsDBNull(((int)FeeItemTrnsBlncColumn.CreditAmnt - 1)))?null:(System.Decimal?)reader[((int)FeeItemTrnsBlncColumn.CreditAmnt - 1)];
			entity.BalanceAmnt = (reader.IsDBNull(((int)FeeItemTrnsBlncColumn.BalanceAmnt - 1)))?null:(System.Decimal?)reader[((int)FeeItemTrnsBlncColumn.BalanceAmnt - 1)];
			entity.TrnsDate = (System.DateTime)reader[((int)FeeItemTrnsBlncColumn.TrnsDate - 1)];
			entity.TrnsDesc = (reader.IsDBNull(((int)FeeItemTrnsBlncColumn.TrnsDesc - 1)))?null:(System.String)reader[((int)FeeItemTrnsBlncColumn.TrnsDesc - 1)];
			entity.FeeStudVoucherItemId = (reader.IsDBNull(((int)FeeItemTrnsBlncColumn.FeeStudVoucherItemId - 1)))?null:(System.Decimal?)reader[((int)FeeItemTrnsBlncColumn.FeeStudVoucherItemId - 1)];
			entity.FeeRefndStdReqId = (reader.IsDBNull(((int)FeeItemTrnsBlncColumn.FeeRefndStdReqId - 1)))?null:(System.Decimal?)reader[((int)FeeItemTrnsBlncColumn.FeeRefndStdReqId - 1)];
			entity.EdStudCourseRegId = (reader.IsDBNull(((int)FeeItemTrnsBlncColumn.EdStudCourseRegId - 1)))?null:(System.Decimal?)reader[((int)FeeItemTrnsBlncColumn.EdStudCourseRegId - 1)];
			entity.FeeStudDiscId = (reader.IsDBNull(((int)FeeItemTrnsBlncColumn.FeeStudDiscId - 1)))?null:(System.Decimal?)reader[((int)FeeItemTrnsBlncColumn.FeeStudDiscId - 1)];
			entity.FeeStudFeeItemId = (reader.IsDBNull(((int)FeeItemTrnsBlncColumn.FeeStudFeeItemId - 1)))?null:(System.Decimal?)reader[((int)FeeItemTrnsBlncColumn.FeeStudFeeItemId - 1)];
			entity.TrnsTypeId = (reader.IsDBNull(((int)FeeItemTrnsBlncColumn.TrnsTypeId - 1)))?null:(System.Int32?)reader[((int)FeeItemTrnsBlncColumn.TrnsTypeId - 1)];
			entity.SeUserTrnsId = (reader.IsDBNull(((int)FeeItemTrnsBlncColumn.SeUserTrnsId - 1)))?null:(System.Decimal?)reader[((int)FeeItemTrnsBlncColumn.SeUserTrnsId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeItemTrnsBlncId = (System.Decimal)dataRow["FEE_ITEM_TRNS_BLNC_ID"];
			entity.OriginalFeeItemTrnsBlncId = (System.Decimal)dataRow["FEE_ITEM_TRNS_BLNC_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.FeeCodeItemId = (System.Decimal)dataRow["FEE_CODE_ITEM_ID"];
			entity.DebitAmnt = Convert.IsDBNull(dataRow["DEBIT_AMNT"]) ? null : (System.Decimal?)dataRow["DEBIT_AMNT"];
			entity.CreditAmnt = Convert.IsDBNull(dataRow["CREDIT_AMNT"]) ? null : (System.Decimal?)dataRow["CREDIT_AMNT"];
			entity.BalanceAmnt = Convert.IsDBNull(dataRow["BALANCE_AMNT"]) ? null : (System.Decimal?)dataRow["BALANCE_AMNT"];
			entity.TrnsDate = (System.DateTime)dataRow["TRNS_DATE"];
			entity.TrnsDesc = Convert.IsDBNull(dataRow["TRNS_DESC"]) ? null : (System.String)dataRow["TRNS_DESC"];
			entity.FeeStudVoucherItemId = Convert.IsDBNull(dataRow["FEE_STUD_VOUCHER_ITEM_ID"]) ? null : (System.Decimal?)dataRow["FEE_STUD_VOUCHER_ITEM_ID"];
			entity.FeeRefndStdReqId = Convert.IsDBNull(dataRow["FEE_REFND_STD_REQ_ID"]) ? null : (System.Decimal?)dataRow["FEE_REFND_STD_REQ_ID"];
			entity.EdStudCourseRegId = Convert.IsDBNull(dataRow["ED_STUD_COURSE_REG_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_COURSE_REG_ID"];
			entity.FeeStudDiscId = Convert.IsDBNull(dataRow["FEE_STUD_DISC_ID"]) ? null : (System.Decimal?)dataRow["FEE_STUD_DISC_ID"];
			entity.FeeStudFeeItemId = Convert.IsDBNull(dataRow["FEE_STUD_FEE_ITEM_ID"]) ? null : (System.Decimal?)dataRow["FEE_STUD_FEE_ITEM_ID"];
			entity.TrnsTypeId = Convert.IsDBNull(dataRow["TRNS_TYPE_ID"]) ? null : (System.Int32?)dataRow["TRNS_TYPE_ID"];
			entity.SeUserTrnsId = Convert.IsDBNull(dataRow["SE_USER_TRNS_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_TRNS_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdStudCourseRegIdSource	
			if (CanDeepLoad(entity, "EdStudCourseReg|EdStudCourseRegIdSource", deepLoadType, innerList) 
				&& entity.EdStudCourseRegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudCourseRegId ?? 0.0m);
				EdStudCourseReg tmpEntity = EntityManager.LocateEntity<EdStudCourseReg>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudCourseReg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudCourseRegIdSource = tmpEntity;
				else
					entity.EdStudCourseRegIdSource = DataRepository.EdStudCourseRegProvider.GetByEdStudCourseRegId(transactionManager, (entity.EdStudCourseRegId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudCourseRegIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudCourseRegProvider.DeepLoad(transactionManager, entity.EdStudCourseRegIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudCourseRegIdSource

			#region FeeCodeItemIdSource	
			if (CanDeepLoad(entity, "FeeCodeItem|FeeCodeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCodeItemId;
				FeeCodeItem tmpEntity = EntityManager.LocateEntity<FeeCodeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeItemIdSource = tmpEntity;
				else
					entity.FeeCodeItemIdSource = DataRepository.FeeCodeItemProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeItemProvider.DeepLoad(transactionManager, entity.FeeCodeItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeItemIdSource

			#region FeeStudDiscIdSource	
			if (CanDeepLoad(entity, "FeeStudDisc|FeeStudDiscIdSource", deepLoadType, innerList) 
				&& entity.FeeStudDiscIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeStudDiscId ?? 0.0m);
				FeeStudDisc tmpEntity = EntityManager.LocateEntity<FeeStudDisc>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudDisc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudDiscIdSource = tmpEntity;
				else
					entity.FeeStudDiscIdSource = DataRepository.FeeStudDiscProvider.GetByFeeStudDiscId(transactionManager, (entity.FeeStudDiscId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudDiscIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudDiscIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudDiscProvider.DeepLoad(transactionManager, entity.FeeStudDiscIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudDiscIdSource

			#region FeeStudFeeItemIdSource	
			if (CanDeepLoad(entity, "FeeStudFeeItem|FeeStudFeeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeStudFeeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeStudFeeItemId ?? 0.0m);
				FeeStudFeeItem tmpEntity = EntityManager.LocateEntity<FeeStudFeeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudFeeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudFeeItemIdSource = tmpEntity;
				else
					entity.FeeStudFeeItemIdSource = DataRepository.FeeStudFeeItemProvider.GetByFeeStudFeeItemId(transactionManager, (entity.FeeStudFeeItemId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFeeItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudFeeItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudFeeItemProvider.DeepLoad(transactionManager, entity.FeeStudFeeItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudFeeItemIdSource

			#region FeeStudVoucherItemIdSource	
			if (CanDeepLoad(entity, "FeeStudVoucherItem|FeeStudVoucherItemIdSource", deepLoadType, innerList) 
				&& entity.FeeStudVoucherItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeStudVoucherItemId ?? 0.0m);
				FeeStudVoucherItem tmpEntity = EntityManager.LocateEntity<FeeStudVoucherItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudVoucherItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudVoucherItemIdSource = tmpEntity;
				else
					entity.FeeStudVoucherItemIdSource = DataRepository.FeeStudVoucherItemProvider.GetByFeeStudVoucherItemId(transactionManager, (entity.FeeStudVoucherItemId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudVoucherItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudVoucherItemProvider.DeepLoad(transactionManager, entity.FeeStudVoucherItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudVoucherItemIdSource

			#region SeUserTrnsIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserTrnsIdSource", deepLoadType, innerList) 
				&& entity.SeUserTrnsIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserTrnsId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserTrnsIdSource = tmpEntity;
				else
					entity.SeUserTrnsIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserTrnsId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserTrnsIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserTrnsIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserTrnsIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserTrnsIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdStudCourseRegIdSource
			if (CanDeepSave(entity, "EdStudCourseReg|EdStudCourseRegIdSource", deepSaveType, innerList) 
				&& entity.EdStudCourseRegIdSource != null)
			{
				DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegIdSource);
				entity.EdStudCourseRegId = entity.EdStudCourseRegIdSource.EdStudCourseRegId;
			}
			#endregion 
			
			#region FeeCodeItemIdSource
			if (CanDeepSave(entity, "FeeCodeItem|FeeCodeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeItemIdSource != null)
			{
				DataRepository.FeeCodeItemProvider.Save(transactionManager, entity.FeeCodeItemIdSource);
				entity.FeeCodeItemId = entity.FeeCodeItemIdSource.FeeCodeItemId;
			}
			#endregion 
			
			#region FeeStudDiscIdSource
			if (CanDeepSave(entity, "FeeStudDisc|FeeStudDiscIdSource", deepSaveType, innerList) 
				&& entity.FeeStudDiscIdSource != null)
			{
				DataRepository.FeeStudDiscProvider.Save(transactionManager, entity.FeeStudDiscIdSource);
				entity.FeeStudDiscId = entity.FeeStudDiscIdSource.FeeStudDiscId;
			}
			#endregion 
			
			#region FeeStudFeeItemIdSource
			if (CanDeepSave(entity, "FeeStudFeeItem|FeeStudFeeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeStudFeeItemIdSource != null)
			{
				DataRepository.FeeStudFeeItemProvider.Save(transactionManager, entity.FeeStudFeeItemIdSource);
				entity.FeeStudFeeItemId = entity.FeeStudFeeItemIdSource.FeeStudFeeItemId;
			}
			#endregion 
			
			#region FeeStudVoucherItemIdSource
			if (CanDeepSave(entity, "FeeStudVoucherItem|FeeStudVoucherItemIdSource", deepSaveType, innerList) 
				&& entity.FeeStudVoucherItemIdSource != null)
			{
				DataRepository.FeeStudVoucherItemProvider.Save(transactionManager, entity.FeeStudVoucherItemIdSource);
				entity.FeeStudVoucherItemId = entity.FeeStudVoucherItemIdSource.FeeStudVoucherItemId;
			}
			#endregion 
			
			#region SeUserTrnsIdSource
			if (CanDeepSave(entity, "SeUser|SeUserTrnsIdSource", deepSaveType, innerList) 
				&& entity.SeUserTrnsIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserTrnsIdSource);
				entity.SeUserTrnsId = entity.SeUserTrnsIdSource.SeUserId;
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
	
	#region FeeItemTrnsBlncChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeItemTrnsBlnc</c>
	///</summary>
	public enum FeeItemTrnsBlncChildEntityTypes
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
		/// Composite Property for <c>EdStudCourseReg</c> at EdStudCourseRegIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudCourseReg))]
		EdStudCourseReg,
		
		///<summary>
		/// Composite Property for <c>FeeCodeItem</c> at FeeCodeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeItem))]
		FeeCodeItem,
		
		///<summary>
		/// Composite Property for <c>FeeStudDisc</c> at FeeStudDiscIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudDisc))]
		FeeStudDisc,
		
		///<summary>
		/// Composite Property for <c>FeeStudFeeItem</c> at FeeStudFeeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudFeeItem))]
		FeeStudFeeItem,
		
		///<summary>
		/// Composite Property for <c>FeeStudVoucherItem</c> at FeeStudVoucherItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudVoucherItem))]
		FeeStudVoucherItem,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserTrnsIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
	}
	
	#endregion FeeItemTrnsBlncChildEntityTypes
	
	#region FeeItemTrnsBlncFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeItemTrnsBlncColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeItemTrnsBlnc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeItemTrnsBlncFilterBuilder : SqlFilterBuilder<FeeItemTrnsBlncColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeItemTrnsBlncFilterBuilder class.
		/// </summary>
		public FeeItemTrnsBlncFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeItemTrnsBlncFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeItemTrnsBlncFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeItemTrnsBlncFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeItemTrnsBlncFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeItemTrnsBlncFilterBuilder
	
	#region FeeItemTrnsBlncParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeItemTrnsBlncColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeItemTrnsBlnc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeItemTrnsBlncParameterBuilder : ParameterizedSqlFilterBuilder<FeeItemTrnsBlncColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeItemTrnsBlncParameterBuilder class.
		/// </summary>
		public FeeItemTrnsBlncParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeItemTrnsBlncParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeItemTrnsBlncParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeItemTrnsBlncParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeItemTrnsBlncParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeItemTrnsBlncParameterBuilder
	
	#region FeeItemTrnsBlncSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeItemTrnsBlncColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeItemTrnsBlnc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeItemTrnsBlncSortBuilder : SqlSortBuilder<FeeItemTrnsBlncColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeItemTrnsBlncSqlSortBuilder class.
		/// </summary>
		public FeeItemTrnsBlncSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeItemTrnsBlncSortBuilder
	
} // end namespace
