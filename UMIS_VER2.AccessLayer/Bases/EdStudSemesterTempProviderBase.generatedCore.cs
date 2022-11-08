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
	/// This class is the base class for any <see cref="EdStudSemesterTempProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudSemesterTempProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudSemesterTemp, UMIS_VER2.BusinessLyer.EdStudSemesterTempKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSemesterTempKey key)
		{
			return Delete(transactionManager, key.EdStudSemesterId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudSemesterId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudSemesterId)
		{
			return Delete(null, _edStudSemesterId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudSemesterId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_AS_FACULTY_INFO key.
		///		FK_ED_STUD_SEMESTER_OLD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_AS_FACULTY_INFO key.
		///		FK_ED_STUD_SEMESTER_OLD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemesterTemp> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_AS_FACULTY_INFO key.
		///		FK_ED_STUD_SEMESTER_OLD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_AS_FACULTY_INFO key.
		///		fkEdStudSemesterOldAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_AS_FACULTY_INFO key.
		///		fkEdStudSemesterOldAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_AS_FACULTY_INFO key.
		///		FK_ED_STUD_SEMESTER_OLD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public abstract TList<EdStudSemesterTemp> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_ACAD_YEAR key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_ACAD_YEAR key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemesterTemp> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_ACAD_YEAR key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_ACAD_YEAR key.
		///		fkEdStudSemesterOldEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_ACAD_YEAR key.
		///		fkEdStudSemesterOldEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_ACAD_YEAR key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public abstract TList<EdStudSemesterTemp> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CDE_ACAD_WARN_TYPE key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CDE_ACAD_WARN_TYPE Description: 
		/// </summary>
		/// <param name="_edCdeAcadWarnTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCdeAcadWarnTypeId(System.Decimal? _edCdeAcadWarnTypeId)
		{
			int count = -1;
			return GetByEdCdeAcadWarnTypeId(_edCdeAcadWarnTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CDE_ACAD_WARN_TYPE key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CDE_ACAD_WARN_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeAcadWarnTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemesterTemp> GetByEdCdeAcadWarnTypeId(TransactionManager transactionManager, System.Decimal? _edCdeAcadWarnTypeId)
		{
			int count = -1;
			return GetByEdCdeAcadWarnTypeId(transactionManager, _edCdeAcadWarnTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CDE_ACAD_WARN_TYPE key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CDE_ACAD_WARN_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeAcadWarnTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCdeAcadWarnTypeId(TransactionManager transactionManager, System.Decimal? _edCdeAcadWarnTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeAcadWarnTypeId(transactionManager, _edCdeAcadWarnTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CDE_ACAD_WARN_TYPE key.
		///		fkEdStudSemesterOldEdCdeAcadWarnType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeAcadWarnTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCdeAcadWarnTypeId(System.Decimal? _edCdeAcadWarnTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeAcadWarnTypeId(null, _edCdeAcadWarnTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CDE_ACAD_WARN_TYPE key.
		///		fkEdStudSemesterOldEdCdeAcadWarnType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeAcadWarnTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCdeAcadWarnTypeId(System.Decimal? _edCdeAcadWarnTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeAcadWarnTypeId(null, _edCdeAcadWarnTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CDE_ACAD_WARN_TYPE key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CDE_ACAD_WARN_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeAcadWarnTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public abstract TList<EdStudSemesterTemp> GetByEdCdeAcadWarnTypeId(TransactionManager transactionManager, System.Decimal? _edCdeAcadWarnTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_ENROLL_TYPE key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CODE_ENROLL_TYPE Description: 
		/// </summary>
		/// <param name="_edCodeEnrollTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCodeEnrollTypeId(System.Decimal? _edCodeEnrollTypeId)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeId(_edCodeEnrollTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_ENROLL_TYPE key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CODE_ENROLL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemesterTemp> GetByEdCodeEnrollTypeId(TransactionManager transactionManager, System.Decimal? _edCodeEnrollTypeId)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeId(transactionManager, _edCodeEnrollTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_ENROLL_TYPE key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CODE_ENROLL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCodeEnrollTypeId(TransactionManager transactionManager, System.Decimal? _edCodeEnrollTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeId(transactionManager, _edCodeEnrollTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_ENROLL_TYPE key.
		///		fkEdStudSemesterOldEdCodeEnrollType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeEnrollTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCodeEnrollTypeId(System.Decimal? _edCodeEnrollTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeEnrollTypeId(null, _edCodeEnrollTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_ENROLL_TYPE key.
		///		fkEdStudSemesterOldEdCodeEnrollType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeEnrollTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCodeEnrollTypeId(System.Decimal? _edCodeEnrollTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCodeEnrollTypeId(null, _edCodeEnrollTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_ENROLL_TYPE key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CODE_ENROLL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public abstract TList<EdStudSemesterTemp> GetByEdCodeEnrollTypeId(TransactionManager transactionManager, System.Decimal? _edCodeEnrollTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_LEVEL key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(_edCodeLevelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_LEVEL key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemesterTemp> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_LEVEL key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_LEVEL key.
		///		fkEdStudSemesterOldEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_LEVEL key.
		///		fkEdStudSemesterOldEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_LEVEL key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public abstract TList<EdStudSemesterTemp> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_LOAD_TYPE key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CODE_LOAD_TYPE Description: 
		/// </summary>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCodeLoadTypeId(System.Decimal? _edCodeLoadTypeId)
		{
			int count = -1;
			return GetByEdCodeLoadTypeId(_edCodeLoadTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_LOAD_TYPE key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CODE_LOAD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemesterTemp> GetByEdCodeLoadTypeId(TransactionManager transactionManager, System.Decimal? _edCodeLoadTypeId)
		{
			int count = -1;
			return GetByEdCodeLoadTypeId(transactionManager, _edCodeLoadTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_LOAD_TYPE key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CODE_LOAD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCodeLoadTypeId(TransactionManager transactionManager, System.Decimal? _edCodeLoadTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLoadTypeId(transactionManager, _edCodeLoadTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_LOAD_TYPE key.
		///		fkEdStudSemesterOldEdCodeLoadType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCodeLoadTypeId(System.Decimal? _edCodeLoadTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLoadTypeId(null, _edCodeLoadTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_LOAD_TYPE key.
		///		fkEdStudSemesterOldEdCodeLoadType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCodeLoadTypeId(System.Decimal? _edCodeLoadTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLoadTypeId(null, _edCodeLoadTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_LOAD_TYPE key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CODE_LOAD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public abstract TList<EdStudSemesterTemp> GetByEdCodeLoadTypeId(TransactionManager transactionManager, System.Decimal? _edCodeLoadTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemesterTemp> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_SEMESTER key.
		///		fkEdStudSemesterOldEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_SEMESTER key.
		///		fkEdStudSemesterOldEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public abstract TList<EdStudSemesterTemp> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_STUD key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_STUD key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemesterTemp> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_STUD key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_STUD key.
		///		fkEdStudSemesterOldEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_STUD key.
		///		fkEdStudSemesterOldEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_ED_STUD key.
		///		FK_ED_STUD_SEMESTER_OLD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public abstract TList<EdStudSemesterTemp> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_FEE_FACULTY_RULE key.
		///		FK_ED_STUD_SEMESTER_OLD_FEE_FACULTY_RULE Description: 
		/// </summary>
		/// <param name="_feeFacultyRuleId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByFeeFacultyRuleId(System.Decimal? _feeFacultyRuleId)
		{
			int count = -1;
			return GetByFeeFacultyRuleId(_feeFacultyRuleId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_FEE_FACULTY_RULE key.
		///		FK_ED_STUD_SEMESTER_OLD_FEE_FACULTY_RULE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemesterTemp> GetByFeeFacultyRuleId(TransactionManager transactionManager, System.Decimal? _feeFacultyRuleId)
		{
			int count = -1;
			return GetByFeeFacultyRuleId(transactionManager, _feeFacultyRuleId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_FEE_FACULTY_RULE key.
		///		FK_ED_STUD_SEMESTER_OLD_FEE_FACULTY_RULE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByFeeFacultyRuleId(TransactionManager transactionManager, System.Decimal? _feeFacultyRuleId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFacultyRuleId(transactionManager, _feeFacultyRuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_FEE_FACULTY_RULE key.
		///		fkEdStudSemesterOldFeeFacultyRule Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByFeeFacultyRuleId(System.Decimal? _feeFacultyRuleId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeFacultyRuleId(null, _feeFacultyRuleId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_FEE_FACULTY_RULE key.
		///		fkEdStudSemesterOldFeeFacultyRule Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByFeeFacultyRuleId(System.Decimal? _feeFacultyRuleId, int start, int pageLength,out int count)
		{
			return GetByFeeFacultyRuleId(null, _feeFacultyRuleId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_OLD_FEE_FACULTY_RULE key.
		///		FK_ED_STUD_SEMESTER_OLD_FEE_FACULTY_RULE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public abstract TList<EdStudSemesterTemp> GetByFeeFacultyRuleId(TransactionManager transactionManager, System.Decimal? _feeFacultyRuleId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_TEMP_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STUD_SEMESTER_TEMP_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(_edCdeExamTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_TEMP_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STUD_SEMESTER_TEMP_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemesterTemp> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_TEMP_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STUD_SEMESTER_TEMP_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_TEMP_ED_CDE_EXAM_TYPE key.
		///		fkEdStudSemesterTempEdCdeExamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_TEMP_ED_CDE_EXAM_TYPE key.
		///		fkEdStudSemesterTempEdCdeExamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public TList<EdStudSemesterTemp> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_TEMP_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STUD_SEMESTER_TEMP_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterTemp objects.</returns>
		public abstract TList<EdStudSemesterTemp> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudSemesterTemp Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSemesterTempKey key, int start, int pageLength)
		{
			return GetByEdStudSemesterId(transactionManager, key.EdStudSemesterId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_SEMESTER_OLD index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterTemp GetByEdStudSemesterId(System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(null,_edStudSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER_OLD index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterTemp GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER_OLD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterTemp GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER_OLD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterTemp GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER_OLD index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterTemp GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER_OLD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterTemp"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudSemesterTemp GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_SEMESTER_OLD index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterTemp GetByEdStudIdEdAcadYearIdEdCodeSemesterIdAsFacultyInfoId(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdAsFacultyInfoId(null,_edStudId, _edAcadYearId, _edCodeSemesterId, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_SEMESTER_OLD index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterTemp GetByEdStudIdEdAcadYearIdEdCodeSemesterIdAsFacultyInfoId(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdAsFacultyInfoId(null, _edStudId, _edAcadYearId, _edCodeSemesterId, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_SEMESTER_OLD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterTemp GetByEdStudIdEdAcadYearIdEdCodeSemesterIdAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdAsFacultyInfoId(transactionManager, _edStudId, _edAcadYearId, _edCodeSemesterId, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_SEMESTER_OLD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterTemp GetByEdStudIdEdAcadYearIdEdCodeSemesterIdAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdAsFacultyInfoId(transactionManager, _edStudId, _edAcadYearId, _edCodeSemesterId, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_SEMESTER_OLD index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterTemp GetByEdStudIdEdAcadYearIdEdCodeSemesterIdAsFacultyInfoId(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdAsFacultyInfoId(null, _edStudId, _edAcadYearId, _edCodeSemesterId, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_SEMESTER_OLD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterTemp"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudSemesterTemp GetByEdStudIdEdAcadYearIdEdCodeSemesterIdAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudSemesterTemp&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudSemesterTemp&gt;"/></returns>
		public static TList<EdStudSemesterTemp> Fill(IDataReader reader, TList<EdStudSemesterTemp> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudSemesterTemp c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudSemesterTemp")
					.Append("|").Append((System.Decimal)reader["ED_STUD_SEMESTER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudSemesterTemp>(
					key.ToString(), // EntityTrackingKey
					"EdStudSemesterTemp",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudSemesterTemp();
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
					c.EdStudSemesterId = (System.Decimal)reader["ED_STUD_SEMESTER_ID"];
					c.OriginalEdStudSemesterId = c.EdStudSemesterId;
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EdCodeLevelId = Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_ID"];
					c.IsLast = Convert.IsDBNull(reader["IS_LAST"]) ? null : (System.Decimal?)reader["IS_LAST"];
					c.EdCodeLoadTypeId = Convert.IsDBNull(reader["ED_CODE_LOAD_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LOAD_TYPE_ID"];
					c.EdCodeEnrollTypeId = Convert.IsDBNull(reader["ED_CODE_ENROLL_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CODE_ENROLL_TYPE_ID"];
					c.AccumCh = Convert.IsDBNull(reader["ACCUM_CH"]) ? null : (System.Decimal?)reader["ACCUM_CH"];
					c.AccumGpa = Convert.IsDBNull(reader["ACCUM_GPA"]) ? null : (System.Decimal?)reader["ACCUM_GPA"];
					c.IsCourseApproved = Convert.IsDBNull(reader["IS_COURSE_APPROVED"]) ? null : (System.Decimal?)reader["IS_COURSE_APPROVED"];
					c.CourseApproveDate = Convert.IsDBNull(reader["COURSE_APPROVE_DATE"]) ? null : (System.DateTime?)reader["COURSE_APPROVE_DATE"];
					c.AccumPoint = Convert.IsDBNull(reader["ACCUM_POINT"]) ? null : (System.Decimal?)reader["ACCUM_POINT"];
					c.SemCh = Convert.IsDBNull(reader["SEM_CH"]) ? null : (System.Decimal?)reader["SEM_CH"];
					c.SemGpa = Convert.IsDBNull(reader["SEM_GPA"]) ? null : (System.Decimal?)reader["SEM_GPA"];
					c.SemPoint = Convert.IsDBNull(reader["SEM_POINT"]) ? null : (System.Decimal?)reader["SEM_POINT"];
					c.IsClosed = Convert.IsDBNull(reader["IS_CLOSED"]) ? null : (System.Decimal?)reader["IS_CLOSED"];
					c.MajorCgpa = Convert.IsDBNull(reader["MAJOR_CGPA"]) ? null : (System.Decimal?)reader["MAJOR_CGPA"];
					c.MajorGpa = Convert.IsDBNull(reader["MAJOR_GPA"]) ? null : (System.Decimal?)reader["MAJOR_GPA"];
					c.AcdPlnLoadFlg = Convert.IsDBNull(reader["ACD_PLN_LOAD_FLG"]) ? null : (System.Decimal?)reader["ACD_PLN_LOAD_FLG"];
					c.OnlineFlg = Convert.IsDBNull(reader["ONLINE_FLG"]) ? null : (System.Decimal?)reader["ONLINE_FLG"];
					c.ExpForGrad = Convert.IsDBNull(reader["EXP_FOR_GRAD"]) ? null : (System.Decimal?)reader["EXP_FOR_GRAD"];
					c.HoldForGrad = Convert.IsDBNull(reader["HOLD_FOR_GRAD"]) ? null : (System.Decimal?)reader["HOLD_FOR_GRAD"];
					c.OrientFlg = Convert.IsDBNull(reader["ORIENT_FLG"]) ? null : (System.Decimal?)reader["ORIENT_FLG"];
					c.HaveSponsor = Convert.IsDBNull(reader["HAVE_SPONSOR"]) ? null : (System.Decimal?)reader["HAVE_SPONSOR"];
					c.HaveInstallment = Convert.IsDBNull(reader["HAVE_INSTALLMENT"]) ? null : (System.Decimal?)reader["HAVE_INSTALLMENT"];
					c.NationalitySimilarityFlg = Convert.IsDBNull(reader["NATIONALITY_SIMILARITY_FLG"]) ? null : (System.Decimal?)reader["NATIONALITY_SIMILARITY_FLG"];
					c.HaveDiscount = Convert.IsDBNull(reader["HAVE_DISCOUNT"]) ? null : (System.Decimal?)reader["HAVE_DISCOUNT"];
					c.HaveRetrieve = Convert.IsDBNull(reader["HAVE_RETRIEVE"]) ? null : (System.Decimal?)reader["HAVE_RETRIEVE"];
					c.HavePostponement = Convert.IsDBNull(reader["HAVE_POSTPONEMENT"]) ? null : (System.Decimal?)reader["HAVE_POSTPONEMENT"];
					c.HaveRemission = Convert.IsDBNull(reader["HAVE_REMISSION"]) ? null : (System.Decimal?)reader["HAVE_REMISSION"];
					c.FeeFacultyRuleId = Convert.IsDBNull(reader["FEE_FACULTY_RULE_ID"]) ? null : (System.Decimal?)reader["FEE_FACULTY_RULE_ID"];
					c.StudCardStkrFlg = Convert.IsDBNull(reader["STUD_CARD_STKR_FLG"]) ? null : (System.Decimal?)reader["STUD_CARD_STKR_FLG"];
					c.StudCardStkrDate = Convert.IsDBNull(reader["STUD_CARD_STKR_DATE"]) ? null : (System.DateTime?)reader["STUD_CARD_STKR_DATE"];
					c.FeeTotAmnt = Convert.IsDBNull(reader["FEE_TOT_AMNT"]) ? null : (System.Decimal?)reader["FEE_TOT_AMNT"];
					c.FeePayAmnt = Convert.IsDBNull(reader["FEE_PAY_AMNT"]) ? null : (System.Decimal?)reader["FEE_PAY_AMNT"];
					c.FeeRefundAmnt = Convert.IsDBNull(reader["FEE_REFUND_AMNT"]) ? null : (System.Decimal?)reader["FEE_REFUND_AMNT"];
					c.PayFlg = Convert.IsDBNull(reader["PAY_FLG"]) ? null : (System.Decimal?)reader["PAY_FLG"];
					c.FreezeFlg = Convert.IsDBNull(reader["FREEZE_FLG"]) ? null : (System.Decimal?)reader["FREEZE_FLG"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.EdCdeAcadWarnTypeId = Convert.IsDBNull(reader["ED_CDE_ACAD_WARN_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CDE_ACAD_WARN_TYPE_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.SemCount = Convert.IsDBNull(reader["SEM_COUNT"]) ? null : (System.Decimal?)reader["SEM_COUNT"];
					c.EdCdeExamTypeId = Convert.IsDBNull(reader["ED_CDE_EXAM_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CDE_EXAM_TYPE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterTemp"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterTemp"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudSemesterTemp entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudSemesterId = (System.Decimal)reader[((int)EdStudSemesterTempColumn.EdStudSemesterId - 1)];
			entity.OriginalEdStudSemesterId = (System.Decimal)reader["ED_STUD_SEMESTER_ID"];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)EdStudSemesterTempColumn.EdCodeSemesterId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)EdStudSemesterTempColumn.EdStudId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)EdStudSemesterTempColumn.EdAcadYearId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdStudSemesterTempColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.AsFacultyInfoId - 1)];
			entity.EdCodeLevelId = (reader.IsDBNull(((int)EdStudSemesterTempColumn.EdCodeLevelId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.EdCodeLevelId - 1)];
			entity.IsLast = (reader.IsDBNull(((int)EdStudSemesterTempColumn.IsLast - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.IsLast - 1)];
			entity.EdCodeLoadTypeId = (reader.IsDBNull(((int)EdStudSemesterTempColumn.EdCodeLoadTypeId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.EdCodeLoadTypeId - 1)];
			entity.EdCodeEnrollTypeId = (reader.IsDBNull(((int)EdStudSemesterTempColumn.EdCodeEnrollTypeId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.EdCodeEnrollTypeId - 1)];
			entity.AccumCh = (reader.IsDBNull(((int)EdStudSemesterTempColumn.AccumCh - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.AccumCh - 1)];
			entity.AccumGpa = (reader.IsDBNull(((int)EdStudSemesterTempColumn.AccumGpa - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.AccumGpa - 1)];
			entity.IsCourseApproved = (reader.IsDBNull(((int)EdStudSemesterTempColumn.IsCourseApproved - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.IsCourseApproved - 1)];
			entity.CourseApproveDate = (reader.IsDBNull(((int)EdStudSemesterTempColumn.CourseApproveDate - 1)))?null:(System.DateTime?)reader[((int)EdStudSemesterTempColumn.CourseApproveDate - 1)];
			entity.AccumPoint = (reader.IsDBNull(((int)EdStudSemesterTempColumn.AccumPoint - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.AccumPoint - 1)];
			entity.SemCh = (reader.IsDBNull(((int)EdStudSemesterTempColumn.SemCh - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.SemCh - 1)];
			entity.SemGpa = (reader.IsDBNull(((int)EdStudSemesterTempColumn.SemGpa - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.SemGpa - 1)];
			entity.SemPoint = (reader.IsDBNull(((int)EdStudSemesterTempColumn.SemPoint - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.SemPoint - 1)];
			entity.IsClosed = (reader.IsDBNull(((int)EdStudSemesterTempColumn.IsClosed - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.IsClosed - 1)];
			entity.MajorCgpa = (reader.IsDBNull(((int)EdStudSemesterTempColumn.MajorCgpa - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.MajorCgpa - 1)];
			entity.MajorGpa = (reader.IsDBNull(((int)EdStudSemesterTempColumn.MajorGpa - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.MajorGpa - 1)];
			entity.AcdPlnLoadFlg = (reader.IsDBNull(((int)EdStudSemesterTempColumn.AcdPlnLoadFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.AcdPlnLoadFlg - 1)];
			entity.OnlineFlg = (reader.IsDBNull(((int)EdStudSemesterTempColumn.OnlineFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.OnlineFlg - 1)];
			entity.ExpForGrad = (reader.IsDBNull(((int)EdStudSemesterTempColumn.ExpForGrad - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.ExpForGrad - 1)];
			entity.HoldForGrad = (reader.IsDBNull(((int)EdStudSemesterTempColumn.HoldForGrad - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.HoldForGrad - 1)];
			entity.OrientFlg = (reader.IsDBNull(((int)EdStudSemesterTempColumn.OrientFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.OrientFlg - 1)];
			entity.HaveSponsor = (reader.IsDBNull(((int)EdStudSemesterTempColumn.HaveSponsor - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.HaveSponsor - 1)];
			entity.HaveInstallment = (reader.IsDBNull(((int)EdStudSemesterTempColumn.HaveInstallment - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.HaveInstallment - 1)];
			entity.NationalitySimilarityFlg = (reader.IsDBNull(((int)EdStudSemesterTempColumn.NationalitySimilarityFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.NationalitySimilarityFlg - 1)];
			entity.HaveDiscount = (reader.IsDBNull(((int)EdStudSemesterTempColumn.HaveDiscount - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.HaveDiscount - 1)];
			entity.HaveRetrieve = (reader.IsDBNull(((int)EdStudSemesterTempColumn.HaveRetrieve - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.HaveRetrieve - 1)];
			entity.HavePostponement = (reader.IsDBNull(((int)EdStudSemesterTempColumn.HavePostponement - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.HavePostponement - 1)];
			entity.HaveRemission = (reader.IsDBNull(((int)EdStudSemesterTempColumn.HaveRemission - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.HaveRemission - 1)];
			entity.FeeFacultyRuleId = (reader.IsDBNull(((int)EdStudSemesterTempColumn.FeeFacultyRuleId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.FeeFacultyRuleId - 1)];
			entity.StudCardStkrFlg = (reader.IsDBNull(((int)EdStudSemesterTempColumn.StudCardStkrFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.StudCardStkrFlg - 1)];
			entity.StudCardStkrDate = (reader.IsDBNull(((int)EdStudSemesterTempColumn.StudCardStkrDate - 1)))?null:(System.DateTime?)reader[((int)EdStudSemesterTempColumn.StudCardStkrDate - 1)];
			entity.FeeTotAmnt = (reader.IsDBNull(((int)EdStudSemesterTempColumn.FeeTotAmnt - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.FeeTotAmnt - 1)];
			entity.FeePayAmnt = (reader.IsDBNull(((int)EdStudSemesterTempColumn.FeePayAmnt - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.FeePayAmnt - 1)];
			entity.FeeRefundAmnt = (reader.IsDBNull(((int)EdStudSemesterTempColumn.FeeRefundAmnt - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.FeeRefundAmnt - 1)];
			entity.PayFlg = (reader.IsDBNull(((int)EdStudSemesterTempColumn.PayFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.PayFlg - 1)];
			entity.FreezeFlg = (reader.IsDBNull(((int)EdStudSemesterTempColumn.FreezeFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.FreezeFlg - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)EdStudSemesterTempColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.AsCodeDegreeId - 1)];
			entity.EdCdeAcadWarnTypeId = (reader.IsDBNull(((int)EdStudSemesterTempColumn.EdCdeAcadWarnTypeId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.EdCdeAcadWarnTypeId - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdStudSemesterTempColumn.Notes - 1)))?null:(System.String)reader[((int)EdStudSemesterTempColumn.Notes - 1)];
			entity.SemCount = (reader.IsDBNull(((int)EdStudSemesterTempColumn.SemCount - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.SemCount - 1)];
			entity.EdCdeExamTypeId = (reader.IsDBNull(((int)EdStudSemesterTempColumn.EdCdeExamTypeId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterTempColumn.EdCdeExamTypeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterTemp"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterTemp"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudSemesterTemp entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudSemesterId = (System.Decimal)dataRow["ED_STUD_SEMESTER_ID"];
			entity.OriginalEdStudSemesterId = (System.Decimal)dataRow["ED_STUD_SEMESTER_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdCodeLevelId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_ID"];
			entity.IsLast = Convert.IsDBNull(dataRow["IS_LAST"]) ? null : (System.Decimal?)dataRow["IS_LAST"];
			entity.EdCodeLoadTypeId = Convert.IsDBNull(dataRow["ED_CODE_LOAD_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LOAD_TYPE_ID"];
			entity.EdCodeEnrollTypeId = Convert.IsDBNull(dataRow["ED_CODE_ENROLL_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_ENROLL_TYPE_ID"];
			entity.AccumCh = Convert.IsDBNull(dataRow["ACCUM_CH"]) ? null : (System.Decimal?)dataRow["ACCUM_CH"];
			entity.AccumGpa = Convert.IsDBNull(dataRow["ACCUM_GPA"]) ? null : (System.Decimal?)dataRow["ACCUM_GPA"];
			entity.IsCourseApproved = Convert.IsDBNull(dataRow["IS_COURSE_APPROVED"]) ? null : (System.Decimal?)dataRow["IS_COURSE_APPROVED"];
			entity.CourseApproveDate = Convert.IsDBNull(dataRow["COURSE_APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["COURSE_APPROVE_DATE"];
			entity.AccumPoint = Convert.IsDBNull(dataRow["ACCUM_POINT"]) ? null : (System.Decimal?)dataRow["ACCUM_POINT"];
			entity.SemCh = Convert.IsDBNull(dataRow["SEM_CH"]) ? null : (System.Decimal?)dataRow["SEM_CH"];
			entity.SemGpa = Convert.IsDBNull(dataRow["SEM_GPA"]) ? null : (System.Decimal?)dataRow["SEM_GPA"];
			entity.SemPoint = Convert.IsDBNull(dataRow["SEM_POINT"]) ? null : (System.Decimal?)dataRow["SEM_POINT"];
			entity.IsClosed = Convert.IsDBNull(dataRow["IS_CLOSED"]) ? null : (System.Decimal?)dataRow["IS_CLOSED"];
			entity.MajorCgpa = Convert.IsDBNull(dataRow["MAJOR_CGPA"]) ? null : (System.Decimal?)dataRow["MAJOR_CGPA"];
			entity.MajorGpa = Convert.IsDBNull(dataRow["MAJOR_GPA"]) ? null : (System.Decimal?)dataRow["MAJOR_GPA"];
			entity.AcdPlnLoadFlg = Convert.IsDBNull(dataRow["ACD_PLN_LOAD_FLG"]) ? null : (System.Decimal?)dataRow["ACD_PLN_LOAD_FLG"];
			entity.OnlineFlg = Convert.IsDBNull(dataRow["ONLINE_FLG"]) ? null : (System.Decimal?)dataRow["ONLINE_FLG"];
			entity.ExpForGrad = Convert.IsDBNull(dataRow["EXP_FOR_GRAD"]) ? null : (System.Decimal?)dataRow["EXP_FOR_GRAD"];
			entity.HoldForGrad = Convert.IsDBNull(dataRow["HOLD_FOR_GRAD"]) ? null : (System.Decimal?)dataRow["HOLD_FOR_GRAD"];
			entity.OrientFlg = Convert.IsDBNull(dataRow["ORIENT_FLG"]) ? null : (System.Decimal?)dataRow["ORIENT_FLG"];
			entity.HaveSponsor = Convert.IsDBNull(dataRow["HAVE_SPONSOR"]) ? null : (System.Decimal?)dataRow["HAVE_SPONSOR"];
			entity.HaveInstallment = Convert.IsDBNull(dataRow["HAVE_INSTALLMENT"]) ? null : (System.Decimal?)dataRow["HAVE_INSTALLMENT"];
			entity.NationalitySimilarityFlg = Convert.IsDBNull(dataRow["NATIONALITY_SIMILARITY_FLG"]) ? null : (System.Decimal?)dataRow["NATIONALITY_SIMILARITY_FLG"];
			entity.HaveDiscount = Convert.IsDBNull(dataRow["HAVE_DISCOUNT"]) ? null : (System.Decimal?)dataRow["HAVE_DISCOUNT"];
			entity.HaveRetrieve = Convert.IsDBNull(dataRow["HAVE_RETRIEVE"]) ? null : (System.Decimal?)dataRow["HAVE_RETRIEVE"];
			entity.HavePostponement = Convert.IsDBNull(dataRow["HAVE_POSTPONEMENT"]) ? null : (System.Decimal?)dataRow["HAVE_POSTPONEMENT"];
			entity.HaveRemission = Convert.IsDBNull(dataRow["HAVE_REMISSION"]) ? null : (System.Decimal?)dataRow["HAVE_REMISSION"];
			entity.FeeFacultyRuleId = Convert.IsDBNull(dataRow["FEE_FACULTY_RULE_ID"]) ? null : (System.Decimal?)dataRow["FEE_FACULTY_RULE_ID"];
			entity.StudCardStkrFlg = Convert.IsDBNull(dataRow["STUD_CARD_STKR_FLG"]) ? null : (System.Decimal?)dataRow["STUD_CARD_STKR_FLG"];
			entity.StudCardStkrDate = Convert.IsDBNull(dataRow["STUD_CARD_STKR_DATE"]) ? null : (System.DateTime?)dataRow["STUD_CARD_STKR_DATE"];
			entity.FeeTotAmnt = Convert.IsDBNull(dataRow["FEE_TOT_AMNT"]) ? null : (System.Decimal?)dataRow["FEE_TOT_AMNT"];
			entity.FeePayAmnt = Convert.IsDBNull(dataRow["FEE_PAY_AMNT"]) ? null : (System.Decimal?)dataRow["FEE_PAY_AMNT"];
			entity.FeeRefundAmnt = Convert.IsDBNull(dataRow["FEE_REFUND_AMNT"]) ? null : (System.Decimal?)dataRow["FEE_REFUND_AMNT"];
			entity.PayFlg = Convert.IsDBNull(dataRow["PAY_FLG"]) ? null : (System.Decimal?)dataRow["PAY_FLG"];
			entity.FreezeFlg = Convert.IsDBNull(dataRow["FREEZE_FLG"]) ? null : (System.Decimal?)dataRow["FREEZE_FLG"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
			entity.EdCdeAcadWarnTypeId = Convert.IsDBNull(dataRow["ED_CDE_ACAD_WARN_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_ACAD_WARN_TYPE_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.SemCount = Convert.IsDBNull(dataRow["SEM_COUNT"]) ? null : (System.Decimal?)dataRow["SEM_COUNT"];
			entity.EdCdeExamTypeId = Convert.IsDBNull(dataRow["ED_CDE_EXAM_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_EXAM_TYPE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterTemp"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudSemesterTemp Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSemesterTemp entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdCdeAcadWarnTypeIdSource	
			if (CanDeepLoad(entity, "EdCdeAcadWarnType|EdCdeAcadWarnTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCdeAcadWarnTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeAcadWarnTypeId ?? 0.0m);
				EdCdeAcadWarnType tmpEntity = EntityManager.LocateEntity<EdCdeAcadWarnType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeAcadWarnType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeAcadWarnTypeIdSource = tmpEntity;
				else
					entity.EdCdeAcadWarnTypeIdSource = DataRepository.EdCdeAcadWarnTypeProvider.GetByEdCdeAcadWarnTypeId(transactionManager, (entity.EdCdeAcadWarnTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeAcadWarnTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeAcadWarnTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeAcadWarnTypeProvider.DeepLoad(transactionManager, entity.EdCdeAcadWarnTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeAcadWarnTypeIdSource

			#region EdCodeEnrollTypeIdSource	
			if (CanDeepLoad(entity, "EdCodeEnrollType|EdCodeEnrollTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCodeEnrollTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeEnrollTypeId ?? 0.0m);
				EdCodeEnrollType tmpEntity = EntityManager.LocateEntity<EdCodeEnrollType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeEnrollType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeEnrollTypeIdSource = tmpEntity;
				else
					entity.EdCodeEnrollTypeIdSource = DataRepository.EdCodeEnrollTypeProvider.GetByEdCodeEnrollTypeId(transactionManager, (entity.EdCodeEnrollTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeEnrollTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeEnrollTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeEnrollTypeProvider.DeepLoad(transactionManager, entity.EdCodeEnrollTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeEnrollTypeIdSource

			#region EdCodeLevelIdSource	
			if (CanDeepLoad(entity, "EdCodeLevel|EdCodeLevelIdSource", deepLoadType, innerList) 
				&& entity.EdCodeLevelIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeLevelId ?? 0.0m);
				EdCodeLevel tmpEntity = EntityManager.LocateEntity<EdCodeLevel>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeLevel), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeLevelIdSource = tmpEntity;
				else
					entity.EdCodeLevelIdSource = DataRepository.EdCodeLevelProvider.GetByEdCodeLevelId(transactionManager, (entity.EdCodeLevelId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeLevelIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeLevelIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeLevelProvider.DeepLoad(transactionManager, entity.EdCodeLevelIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeLevelIdSource

			#region EdCodeLoadTypeIdSource	
			if (CanDeepLoad(entity, "EdCodeLoadType|EdCodeLoadTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCodeLoadTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeLoadTypeId ?? 0.0m);
				EdCodeLoadType tmpEntity = EntityManager.LocateEntity<EdCodeLoadType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeLoadType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeLoadTypeIdSource = tmpEntity;
				else
					entity.EdCodeLoadTypeIdSource = DataRepository.EdCodeLoadTypeProvider.GetByEdCodeLoadTypeId(transactionManager, (entity.EdCodeLoadTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeLoadTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeLoadTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeLoadTypeProvider.DeepLoad(transactionManager, entity.EdCodeLoadTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeLoadTypeIdSource

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

			#region FeeFacultyRuleIdSource	
			if (CanDeepLoad(entity, "FeeFacultyRule|FeeFacultyRuleIdSource", deepLoadType, innerList) 
				&& entity.FeeFacultyRuleIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeFacultyRuleId ?? 0.0m);
				FeeFacultyRule tmpEntity = EntityManager.LocateEntity<FeeFacultyRule>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeFacultyRule), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeFacultyRuleIdSource = tmpEntity;
				else
					entity.FeeFacultyRuleIdSource = DataRepository.FeeFacultyRuleProvider.GetByFeeFacultyRuleId(transactionManager, (entity.FeeFacultyRuleId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyRuleIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeFacultyRuleIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeFacultyRuleProvider.DeepLoad(transactionManager, entity.FeeFacultyRuleIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeFacultyRuleIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudSemesterTemp object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudSemesterTemp instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudSemesterTemp Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSemesterTemp entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCdeAcadWarnTypeIdSource
			if (CanDeepSave(entity, "EdCdeAcadWarnType|EdCdeAcadWarnTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCdeAcadWarnTypeIdSource != null)
			{
				DataRepository.EdCdeAcadWarnTypeProvider.Save(transactionManager, entity.EdCdeAcadWarnTypeIdSource);
				entity.EdCdeAcadWarnTypeId = entity.EdCdeAcadWarnTypeIdSource.EdCdeAcadWarnTypeId;
			}
			#endregion 
			
			#region EdCodeEnrollTypeIdSource
			if (CanDeepSave(entity, "EdCodeEnrollType|EdCodeEnrollTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCodeEnrollTypeIdSource != null)
			{
				DataRepository.EdCodeEnrollTypeProvider.Save(transactionManager, entity.EdCodeEnrollTypeIdSource);
				entity.EdCodeEnrollTypeId = entity.EdCodeEnrollTypeIdSource.EdCodeEnrollTypeId;
			}
			#endregion 
			
			#region EdCodeLevelIdSource
			if (CanDeepSave(entity, "EdCodeLevel|EdCodeLevelIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLevelIdSource != null)
			{
				DataRepository.EdCodeLevelProvider.Save(transactionManager, entity.EdCodeLevelIdSource);
				entity.EdCodeLevelId = entity.EdCodeLevelIdSource.EdCodeLevelId;
			}
			#endregion 
			
			#region EdCodeLoadTypeIdSource
			if (CanDeepSave(entity, "EdCodeLoadType|EdCodeLoadTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLoadTypeIdSource != null)
			{
				DataRepository.EdCodeLoadTypeProvider.Save(transactionManager, entity.EdCodeLoadTypeIdSource);
				entity.EdCodeLoadTypeId = entity.EdCodeLoadTypeIdSource.EdCodeLoadTypeId;
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
			
			#region FeeFacultyRuleIdSource
			if (CanDeepSave(entity, "FeeFacultyRule|FeeFacultyRuleIdSource", deepSaveType, innerList) 
				&& entity.FeeFacultyRuleIdSource != null)
			{
				DataRepository.FeeFacultyRuleProvider.Save(transactionManager, entity.FeeFacultyRuleIdSource);
				entity.FeeFacultyRuleId = entity.FeeFacultyRuleIdSource.FeeFacultyRuleId;
			}
			#endregion 
			
			#region EdCdeExamTypeIdSource
			if (CanDeepSave(entity, "EdCdeExamType|EdCdeExamTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCdeExamTypeIdSource != null)
			{
				DataRepository.EdCdeExamTypeProvider.Save(transactionManager, entity.EdCdeExamTypeIdSource);
				entity.EdCdeExamTypeId = entity.EdCdeExamTypeIdSource.EdCdeExamTypeId;
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
	
	#region EdStudSemesterTempChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudSemesterTemp</c>
	///</summary>
	public enum EdStudSemesterTempChildEntityTypes
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
		/// Composite Property for <c>EdCdeAcadWarnType</c> at EdCdeAcadWarnTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeAcadWarnType))]
		EdCdeAcadWarnType,
		
		///<summary>
		/// Composite Property for <c>EdCodeEnrollType</c> at EdCodeEnrollTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeEnrollType))]
		EdCodeEnrollType,
		
		///<summary>
		/// Composite Property for <c>EdCodeLevel</c> at EdCodeLevelIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLevel))]
		EdCodeLevel,
		
		///<summary>
		/// Composite Property for <c>EdCodeLoadType</c> at EdCodeLoadTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLoadType))]
		EdCodeLoadType,
		
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
		/// Composite Property for <c>FeeFacultyRule</c> at FeeFacultyRuleIdSource
		///</summary>
		[ChildEntityType(typeof(FeeFacultyRule))]
		FeeFacultyRule,
		
		///<summary>
		/// Composite Property for <c>EdCdeExamType</c> at EdCdeExamTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeExamType))]
		EdCdeExamType,
	}
	
	#endregion EdStudSemesterTempChildEntityTypes
	
	#region EdStudSemesterTempFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudSemesterTempColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudSemesterTemp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudSemesterTempFilterBuilder : SqlFilterBuilder<EdStudSemesterTempColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterTempFilterBuilder class.
		/// </summary>
		public EdStudSemesterTempFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterTempFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudSemesterTempFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterTempFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudSemesterTempFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudSemesterTempFilterBuilder
	
	#region EdStudSemesterTempParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudSemesterTempColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudSemesterTemp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudSemesterTempParameterBuilder : ParameterizedSqlFilterBuilder<EdStudSemesterTempColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterTempParameterBuilder class.
		/// </summary>
		public EdStudSemesterTempParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterTempParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudSemesterTempParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterTempParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudSemesterTempParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudSemesterTempParameterBuilder
	
	#region EdStudSemesterTempSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudSemesterTempColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudSemesterTemp"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudSemesterTempSortBuilder : SqlSortBuilder<EdStudSemesterTempColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterTempSqlSortBuilder class.
		/// </summary>
		public EdStudSemesterTempSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudSemesterTempSortBuilder
	
} // end namespace
