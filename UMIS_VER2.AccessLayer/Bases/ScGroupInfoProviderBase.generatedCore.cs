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
	/// This class is the base class for any <see cref="ScGroupInfoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScGroupInfoProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScGroupInfo, UMIS_VER2.BusinessLyer.ScGroupInfoKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScGroupInfoKey key)
		{
			return Delete(transactionManager, key.ScGroupInfoId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scGroupInfoId">مجموعات-سكاشن. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scGroupInfoId)
		{
			return Delete(null, _scGroupInfoId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoId">مجموعات-سكاشن. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scGroupInfoId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_AS_FACULTY_INFO key.
		///		FK_SC_GROUP_INFO_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_AS_FACULTY_INFO key.
		///		FK_SC_GROUP_INFO_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupInfo> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_AS_FACULTY_INFO key.
		///		FK_SC_GROUP_INFO_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_AS_FACULTY_INFO key.
		///		fkScGroupInfoAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_AS_FACULTY_INFO key.
		///		fkScGroupInfoAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_AS_FACULTY_INFO key.
		///		FK_SC_GROUP_INFO_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public abstract TList<ScGroupInfo> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_ACAD_YEAR key.
		///		FK_SC_GROUP_INFO_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_ACAD_YEAR key.
		///		FK_SC_GROUP_INFO_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupInfo> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_ACAD_YEAR key.
		///		FK_SC_GROUP_INFO_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_ACAD_YEAR key.
		///		fkScGroupInfoEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_ACAD_YEAR key.
		///		fkScGroupInfoEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_ACAD_YEAR key.
		///		FK_SC_GROUP_INFO_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public abstract TList<ScGroupInfo> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_CDE_TCHNG_MTHD key.
		///		FK_SC_GROUP_INFO_ED_CDE_TCHNG_MTHD Description: 
		/// </summary>
		/// <param name="_edCdeTchngMthdId">طريقة التدريس</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdCdeTchngMthdId(System.Decimal? _edCdeTchngMthdId)
		{
			int count = -1;
			return GetByEdCdeTchngMthdId(_edCdeTchngMthdId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_CDE_TCHNG_MTHD key.
		///		FK_SC_GROUP_INFO_ED_CDE_TCHNG_MTHD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeTchngMthdId">طريقة التدريس</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupInfo> GetByEdCdeTchngMthdId(TransactionManager transactionManager, System.Decimal? _edCdeTchngMthdId)
		{
			int count = -1;
			return GetByEdCdeTchngMthdId(transactionManager, _edCdeTchngMthdId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_CDE_TCHNG_MTHD key.
		///		FK_SC_GROUP_INFO_ED_CDE_TCHNG_MTHD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeTchngMthdId">طريقة التدريس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdCdeTchngMthdId(TransactionManager transactionManager, System.Decimal? _edCdeTchngMthdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeTchngMthdId(transactionManager, _edCdeTchngMthdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_CDE_TCHNG_MTHD key.
		///		fkScGroupInfoEdCdeTchngMthd Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeTchngMthdId">طريقة التدريس</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdCdeTchngMthdId(System.Decimal? _edCdeTchngMthdId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeTchngMthdId(null, _edCdeTchngMthdId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_CDE_TCHNG_MTHD key.
		///		fkScGroupInfoEdCdeTchngMthd Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeTchngMthdId">طريقة التدريس</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdCdeTchngMthdId(System.Decimal? _edCdeTchngMthdId, int start, int pageLength,out int count)
		{
			return GetByEdCdeTchngMthdId(null, _edCdeTchngMthdId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_CDE_TCHNG_MTHD key.
		///		FK_SC_GROUP_INFO_ED_CDE_TCHNG_MTHD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeTchngMthdId">طريقة التدريس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public abstract TList<ScGroupInfo> GetByEdCdeTchngMthdId(TransactionManager transactionManager, System.Decimal? _edCdeTchngMthdId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_CODE_LEVEL key.
		///		FK_SC_GROUP_INFO_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(_edCodeLevelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_CODE_LEVEL key.
		///		FK_SC_GROUP_INFO_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupInfo> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_CODE_LEVEL key.
		///		FK_SC_GROUP_INFO_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_CODE_LEVEL key.
		///		fkScGroupInfoEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_CODE_LEVEL key.
		///		fkScGroupInfoEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_CODE_LEVEL key.
		///		FK_SC_GROUP_INFO_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public abstract TList<ScGroupInfo> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_CODE_SEMESTER key.
		///		FK_SC_GROUP_INFO_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_CODE_SEMESTER key.
		///		FK_SC_GROUP_INFO_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupInfo> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_CODE_SEMESTER key.
		///		FK_SC_GROUP_INFO_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_CODE_SEMESTER key.
		///		fkScGroupInfoEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_CODE_SEMESTER key.
		///		fkScGroupInfoEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_CODE_SEMESTER key.
		///		FK_SC_GROUP_INFO_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public abstract TList<ScGroupInfo> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_COURSE key.
		///		FK_SC_GROUP_INFO_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdCourseId(System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_COURSE key.
		///		FK_SC_GROUP_INFO_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupInfo> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_COURSE key.
		///		FK_SC_GROUP_INFO_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_COURSE key.
		///		fkScGroupInfoEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_COURSE key.
		///		fkScGroupInfoEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ED_COURSE key.
		///		FK_SC_GROUP_INFO_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public abstract TList<ScGroupInfo> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ENTITY_MAIN key.
		///		FK_SC_GROUP_INFO_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId">null  or major</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEntMainId(System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ENTITY_MAIN key.
		///		FK_SC_GROUP_INFO_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">null  or major</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupInfo> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ENTITY_MAIN key.
		///		FK_SC_GROUP_INFO_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ENTITY_MAIN key.
		///		fkScGroupInfoEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">null  or major</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ENTITY_MAIN key.
		///		fkScGroupInfoEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_ENTITY_MAIN key.
		///		FK_SC_GROUP_INFO_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public abstract TList<ScGroupInfo> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_SC_CDE_GRP_TYPE key.
		///		FK_SC_GROUP_INFO_SC_CDE_GRP_TYPE Description: 
		/// </summary>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByScCdeGrpTypeId(System.Decimal _scCdeGrpTypeId)
		{
			int count = -1;
			return GetByScCdeGrpTypeId(_scCdeGrpTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_SC_CDE_GRP_TYPE key.
		///		FK_SC_GROUP_INFO_SC_CDE_GRP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupInfo> GetByScCdeGrpTypeId(TransactionManager transactionManager, System.Decimal _scCdeGrpTypeId)
		{
			int count = -1;
			return GetByScCdeGrpTypeId(transactionManager, _scCdeGrpTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_SC_CDE_GRP_TYPE key.
		///		FK_SC_GROUP_INFO_SC_CDE_GRP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByScCdeGrpTypeId(TransactionManager transactionManager, System.Decimal _scCdeGrpTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByScCdeGrpTypeId(transactionManager, _scCdeGrpTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_SC_CDE_GRP_TYPE key.
		///		fkScGroupInfoScCdeGrpType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByScCdeGrpTypeId(System.Decimal _scCdeGrpTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScCdeGrpTypeId(null, _scCdeGrpTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_SC_CDE_GRP_TYPE key.
		///		fkScGroupInfoScCdeGrpType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByScCdeGrpTypeId(System.Decimal _scCdeGrpTypeId, int start, int pageLength,out int count)
		{
			return GetByScCdeGrpTypeId(null, _scCdeGrpTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_SC_CDE_GRP_TYPE key.
		///		FK_SC_GROUP_INFO_SC_CDE_GRP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public abstract TList<ScGroupInfo> GetByScCdeGrpTypeId(TransactionManager transactionManager, System.Decimal _scCdeGrpTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_SC_GROUP_INFO key.
		///		FK_SC_GROUP_INFO_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByScGroupInfoPrntId(System.Decimal? _scGroupInfoPrntId)
		{
			int count = -1;
			return GetByScGroupInfoPrntId(_scGroupInfoPrntId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_SC_GROUP_INFO key.
		///		FK_SC_GROUP_INFO_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupInfo> GetByScGroupInfoPrntId(TransactionManager transactionManager, System.Decimal? _scGroupInfoPrntId)
		{
			int count = -1;
			return GetByScGroupInfoPrntId(transactionManager, _scGroupInfoPrntId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_SC_GROUP_INFO key.
		///		FK_SC_GROUP_INFO_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByScGroupInfoPrntId(TransactionManager transactionManager, System.Decimal? _scGroupInfoPrntId, int start, int pageLength)
		{
			int count = -1;
			return GetByScGroupInfoPrntId(transactionManager, _scGroupInfoPrntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_SC_GROUP_INFO key.
		///		fkScGroupInfoScGroupInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByScGroupInfoPrntId(System.Decimal? _scGroupInfoPrntId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScGroupInfoPrntId(null, _scGroupInfoPrntId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_SC_GROUP_INFO key.
		///		fkScGroupInfoScGroupInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public TList<ScGroupInfo> GetByScGroupInfoPrntId(System.Decimal? _scGroupInfoPrntId, int start, int pageLength,out int count)
		{
			return GetByScGroupInfoPrntId(null, _scGroupInfoPrntId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_INFO_SC_GROUP_INFO key.
		///		FK_SC_GROUP_INFO_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupInfo objects.</returns>
		public abstract TList<ScGroupInfo> GetByScGroupInfoPrntId(TransactionManager transactionManager, System.Decimal? _scGroupInfoPrntId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScGroupInfo Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScGroupInfoKey key, int start, int pageLength)
		{
			return GetByScGroupInfoId(transactionManager, key.ScGroupInfoId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_GROUP_INFO index.
		/// </summary>
		/// <param name="_scGroupInfoId">مجموعات-سكاشن</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByScGroupInfoId(System.Decimal _scGroupInfoId)
		{
			int count = -1;
			return GetByScGroupInfoId(null,_scGroupInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_GROUP_INFO index.
		/// </summary>
		/// <param name="_scGroupInfoId">مجموعات-سكاشن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByScGroupInfoId(System.Decimal _scGroupInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByScGroupInfoId(null, _scGroupInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_GROUP_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoId">مجموعات-سكاشن</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByScGroupInfoId(TransactionManager transactionManager, System.Decimal _scGroupInfoId)
		{
			int count = -1;
			return GetByScGroupInfoId(transactionManager, _scGroupInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_GROUP_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoId">مجموعات-سكاشن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByScGroupInfoId(TransactionManager transactionManager, System.Decimal _scGroupInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByScGroupInfoId(transactionManager, _scGroupInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_GROUP_INFO index.
		/// </summary>
		/// <param name="_scGroupInfoId">مجموعات-سكاشن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByScGroupInfoId(System.Decimal _scGroupInfoId, int start, int pageLength, out int count)
		{
			return GetByScGroupInfoId(null, _scGroupInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_GROUP_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoId">مجموعات-سكاشن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScGroupInfo GetByScGroupInfoId(TransactionManager transactionManager, System.Decimal _scGroupInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SC_GROUP_INFO_AR index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_grpAr"></param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpArEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _edCodeLevelId, System.String _grpAr, System.Decimal? _entMainId, System.Decimal? _scGroupInfoPrntId, System.Decimal? _edCourseId, System.Decimal _scCdeGrpTypeId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpArEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(null,_edAcadYearId, _edCodeSemesterId, _edCodeLevelId, _grpAr, _entMainId, _scGroupInfoPrntId, _edCourseId, _scCdeGrpTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_GROUP_INFO_AR index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_grpAr"></param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpArEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _edCodeLevelId, System.String _grpAr, System.Decimal? _entMainId, System.Decimal? _scGroupInfoPrntId, System.Decimal? _edCourseId, System.Decimal _scCdeGrpTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpArEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(null, _edAcadYearId, _edCodeSemesterId, _edCodeLevelId, _grpAr, _entMainId, _scGroupInfoPrntId, _edCourseId, _scCdeGrpTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_GROUP_INFO_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_grpAr"></param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpArEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _edCodeLevelId, System.String _grpAr, System.Decimal? _entMainId, System.Decimal? _scGroupInfoPrntId, System.Decimal? _edCourseId, System.Decimal _scCdeGrpTypeId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpArEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(transactionManager, _edAcadYearId, _edCodeSemesterId, _edCodeLevelId, _grpAr, _entMainId, _scGroupInfoPrntId, _edCourseId, _scCdeGrpTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_GROUP_INFO_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_grpAr"></param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpArEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _edCodeLevelId, System.String _grpAr, System.Decimal? _entMainId, System.Decimal? _scGroupInfoPrntId, System.Decimal? _edCourseId, System.Decimal _scCdeGrpTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpArEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(transactionManager, _edAcadYearId, _edCodeSemesterId, _edCodeLevelId, _grpAr, _entMainId, _scGroupInfoPrntId, _edCourseId, _scCdeGrpTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_GROUP_INFO_AR index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_grpAr"></param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpArEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _edCodeLevelId, System.String _grpAr, System.Decimal? _entMainId, System.Decimal? _scGroupInfoPrntId, System.Decimal? _edCourseId, System.Decimal _scCdeGrpTypeId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpArEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(null, _edAcadYearId, _edCodeSemesterId, _edCodeLevelId, _grpAr, _entMainId, _scGroupInfoPrntId, _edCourseId, _scCdeGrpTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_GROUP_INFO_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_grpAr"></param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScGroupInfo GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpArEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _edCodeLevelId, System.String _grpAr, System.Decimal? _entMainId, System.Decimal? _scGroupInfoPrntId, System.Decimal? _edCourseId, System.Decimal _scCdeGrpTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SC_GROUP_INFO_CODE index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_grpCode">كود المجموعة</param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpCodeEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _edCodeLevelId, System.String _grpCode, System.Decimal? _entMainId, System.Decimal? _scGroupInfoPrntId, System.Decimal? _edCourseId, System.Decimal _scCdeGrpTypeId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpCodeEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(null,_edAcadYearId, _edCodeSemesterId, _edCodeLevelId, _grpCode, _entMainId, _scGroupInfoPrntId, _edCourseId, _scCdeGrpTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_GROUP_INFO_CODE index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_grpCode">كود المجموعة</param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpCodeEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _edCodeLevelId, System.String _grpCode, System.Decimal? _entMainId, System.Decimal? _scGroupInfoPrntId, System.Decimal? _edCourseId, System.Decimal _scCdeGrpTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpCodeEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(null, _edAcadYearId, _edCodeSemesterId, _edCodeLevelId, _grpCode, _entMainId, _scGroupInfoPrntId, _edCourseId, _scCdeGrpTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_GROUP_INFO_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_grpCode">كود المجموعة</param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpCodeEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _edCodeLevelId, System.String _grpCode, System.Decimal? _entMainId, System.Decimal? _scGroupInfoPrntId, System.Decimal? _edCourseId, System.Decimal _scCdeGrpTypeId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpCodeEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(transactionManager, _edAcadYearId, _edCodeSemesterId, _edCodeLevelId, _grpCode, _entMainId, _scGroupInfoPrntId, _edCourseId, _scCdeGrpTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_GROUP_INFO_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_grpCode">كود المجموعة</param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpCodeEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _edCodeLevelId, System.String _grpCode, System.Decimal? _entMainId, System.Decimal? _scGroupInfoPrntId, System.Decimal? _edCourseId, System.Decimal _scCdeGrpTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpCodeEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(transactionManager, _edAcadYearId, _edCodeSemesterId, _edCodeLevelId, _grpCode, _entMainId, _scGroupInfoPrntId, _edCourseId, _scCdeGrpTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_GROUP_INFO_CODE index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_grpCode">كود المجموعة</param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpCodeEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _edCodeLevelId, System.String _grpCode, System.Decimal? _entMainId, System.Decimal? _scGroupInfoPrntId, System.Decimal? _edCourseId, System.Decimal _scCdeGrpTypeId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpCodeEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(null, _edAcadYearId, _edCodeSemesterId, _edCodeLevelId, _grpCode, _entMainId, _scGroupInfoPrntId, _edCourseId, _scCdeGrpTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_GROUP_INFO_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_grpCode">كود المجموعة</param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScGroupInfo GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpCodeEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _edCodeLevelId, System.String _grpCode, System.Decimal? _entMainId, System.Decimal? _scGroupInfoPrntId, System.Decimal? _edCourseId, System.Decimal _scCdeGrpTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SC_GROUP_INFO_EN index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_grpEn"></param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpEnEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _edCodeLevelId, System.String _grpEn, System.Decimal? _entMainId, System.Decimal? _scGroupInfoPrntId, System.Decimal? _edCourseId, System.Decimal _scCdeGrpTypeId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpEnEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(null,_edAcadYearId, _edCodeSemesterId, _edCodeLevelId, _grpEn, _entMainId, _scGroupInfoPrntId, _edCourseId, _scCdeGrpTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_GROUP_INFO_EN index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_grpEn"></param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpEnEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _edCodeLevelId, System.String _grpEn, System.Decimal? _entMainId, System.Decimal? _scGroupInfoPrntId, System.Decimal? _edCourseId, System.Decimal _scCdeGrpTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpEnEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(null, _edAcadYearId, _edCodeSemesterId, _edCodeLevelId, _grpEn, _entMainId, _scGroupInfoPrntId, _edCourseId, _scCdeGrpTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_GROUP_INFO_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_grpEn"></param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpEnEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _edCodeLevelId, System.String _grpEn, System.Decimal? _entMainId, System.Decimal? _scGroupInfoPrntId, System.Decimal? _edCourseId, System.Decimal _scCdeGrpTypeId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpEnEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(transactionManager, _edAcadYearId, _edCodeSemesterId, _edCodeLevelId, _grpEn, _entMainId, _scGroupInfoPrntId, _edCourseId, _scCdeGrpTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_GROUP_INFO_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_grpEn"></param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpEnEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _edCodeLevelId, System.String _grpEn, System.Decimal? _entMainId, System.Decimal? _scGroupInfoPrntId, System.Decimal? _edCourseId, System.Decimal _scCdeGrpTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpEnEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(transactionManager, _edAcadYearId, _edCodeSemesterId, _edCodeLevelId, _grpEn, _entMainId, _scGroupInfoPrntId, _edCourseId, _scCdeGrpTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_GROUP_INFO_EN index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_grpEn"></param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupInfo GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpEnEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _edCodeLevelId, System.String _grpEn, System.Decimal? _entMainId, System.Decimal? _scGroupInfoPrntId, System.Decimal? _edCourseId, System.Decimal _scCdeGrpTypeId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpEnEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(null, _edAcadYearId, _edCodeSemesterId, _edCodeLevelId, _grpEn, _entMainId, _scGroupInfoPrntId, _edCourseId, _scCdeGrpTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_GROUP_INFO_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_grpEn"></param>
		/// <param name="_entMainId">null  or major</param>
		/// <param name="_scGroupInfoPrntId"></param>
		/// <param name="_edCourseId">المقرر مجموعة</param>
		/// <param name="_scCdeGrpTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScGroupInfo GetByEdAcadYearIdEdCodeSemesterIdEdCodeLevelIdGrpEnEntMainIdScGroupInfoPrntIdEdCourseIdScCdeGrpTypeId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _edCodeLevelId, System.String _grpEn, System.Decimal? _entMainId, System.Decimal? _scGroupInfoPrntId, System.Decimal? _edCourseId, System.Decimal _scCdeGrpTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScGroupInfo&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScGroupInfo&gt;"/></returns>
		public static TList<ScGroupInfo> Fill(IDataReader reader, TList<ScGroupInfo> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScGroupInfo c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScGroupInfo")
					.Append("|").Append((System.Decimal)reader["SC_GROUP_INFO_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScGroupInfo>(
					key.ToString(), // EntityTrackingKey
					"ScGroupInfo",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScGroupInfo();
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
					c.ScGroupInfoId = (System.Decimal)reader["SC_GROUP_INFO_ID"];
					c.OriginalScGroupInfoId = c.ScGroupInfoId;
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.EdCodeLevelId = Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_ID"];
					c.ScCdeGrpTypeId = (System.Decimal)reader["SC_CDE_GRP_TYPE_ID"];
					c.EdCdeTchngMthdId = Convert.IsDBNull(reader["ED_CDE_TCHNG_MTHD_ID"]) ? null : (System.Decimal?)reader["ED_CDE_TCHNG_MTHD_ID"];
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.GrpCode = (System.String)reader["GRP_CODE"];
					c.GrpAr = (System.String)reader["GRP_AR"];
					c.GrpEn = (System.String)reader["GRP_EN"];
					c.StudCount = Convert.IsDBNull(reader["STUD_COUNT"]) ? null : (System.Int32?)reader["STUD_COUNT"];
					c.ScGroupInfoPrntId = Convert.IsDBNull(reader["SC_GROUP_INFO_PRNT_ID"]) ? null : (System.Decimal?)reader["SC_GROUP_INFO_PRNT_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScGroupInfo entity)
		{
			if (!reader.Read()) return;
			
			entity.ScGroupInfoId = (System.Decimal)reader[((int)ScGroupInfoColumn.ScGroupInfoId - 1)];
			entity.OriginalScGroupInfoId = (System.Decimal)reader["SC_GROUP_INFO_ID"];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)ScGroupInfoColumn.AsFacultyInfoId - 1)];
			entity.EntMainId = (reader.IsDBNull(((int)ScGroupInfoColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)ScGroupInfoColumn.EntMainId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)ScGroupInfoColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)ScGroupInfoColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)ScGroupInfoColumn.EdCodeSemesterId - 1)];
			entity.EdCodeLevelId = (reader.IsDBNull(((int)ScGroupInfoColumn.EdCodeLevelId - 1)))?null:(System.Decimal?)reader[((int)ScGroupInfoColumn.EdCodeLevelId - 1)];
			entity.ScCdeGrpTypeId = (System.Decimal)reader[((int)ScGroupInfoColumn.ScCdeGrpTypeId - 1)];
			entity.EdCdeTchngMthdId = (reader.IsDBNull(((int)ScGroupInfoColumn.EdCdeTchngMthdId - 1)))?null:(System.Decimal?)reader[((int)ScGroupInfoColumn.EdCdeTchngMthdId - 1)];
			entity.EdCourseId = (reader.IsDBNull(((int)ScGroupInfoColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)ScGroupInfoColumn.EdCourseId - 1)];
			entity.GrpCode = (System.String)reader[((int)ScGroupInfoColumn.GrpCode - 1)];
			entity.GrpAr = (System.String)reader[((int)ScGroupInfoColumn.GrpAr - 1)];
			entity.GrpEn = (System.String)reader[((int)ScGroupInfoColumn.GrpEn - 1)];
			entity.StudCount = (reader.IsDBNull(((int)ScGroupInfoColumn.StudCount - 1)))?null:(System.Int32?)reader[((int)ScGroupInfoColumn.StudCount - 1)];
			entity.ScGroupInfoPrntId = (reader.IsDBNull(((int)ScGroupInfoColumn.ScGroupInfoPrntId - 1)))?null:(System.Decimal?)reader[((int)ScGroupInfoColumn.ScGroupInfoPrntId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)ScGroupInfoColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)ScGroupInfoColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)ScGroupInfoColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)ScGroupInfoColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScGroupInfo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScGroupInfoId = (System.Decimal)dataRow["SC_GROUP_INFO_ID"];
			entity.OriginalScGroupInfoId = (System.Decimal)dataRow["SC_GROUP_INFO_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdCodeLevelId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_ID"];
			entity.ScCdeGrpTypeId = (System.Decimal)dataRow["SC_CDE_GRP_TYPE_ID"];
			entity.EdCdeTchngMthdId = Convert.IsDBNull(dataRow["ED_CDE_TCHNG_MTHD_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_TCHNG_MTHD_ID"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.GrpCode = (System.String)dataRow["GRP_CODE"];
			entity.GrpAr = (System.String)dataRow["GRP_AR"];
			entity.GrpEn = (System.String)dataRow["GRP_EN"];
			entity.StudCount = Convert.IsDBNull(dataRow["STUD_COUNT"]) ? null : (System.Int32?)dataRow["STUD_COUNT"];
			entity.ScGroupInfoPrntId = Convert.IsDBNull(dataRow["SC_GROUP_INFO_PRNT_ID"]) ? null : (System.Decimal?)dataRow["SC_GROUP_INFO_PRNT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScGroupInfo"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScGroupInfo Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScGroupInfo entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
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

			#region EdCdeTchngMthdIdSource	
			if (CanDeepLoad(entity, "EdCdeTchngMthd|EdCdeTchngMthdIdSource", deepLoadType, innerList) 
				&& entity.EdCdeTchngMthdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeTchngMthdId ?? 0.0m);
				EdCdeTchngMthd tmpEntity = EntityManager.LocateEntity<EdCdeTchngMthd>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeTchngMthd), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeTchngMthdIdSource = tmpEntity;
				else
					entity.EdCdeTchngMthdIdSource = DataRepository.EdCdeTchngMthdProvider.GetByEdCdeTchngMthdId(transactionManager, (entity.EdCdeTchngMthdId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeTchngMthdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeTchngMthdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeTchngMthdProvider.DeepLoad(transactionManager, entity.EdCdeTchngMthdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeTchngMthdIdSource

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

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCourseId ?? 0.0m);
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, (entity.EdCourseId ?? 0.0m));		
				
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

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainIdSource

			#region ScCdeGrpTypeIdSource	
			if (CanDeepLoad(entity, "ScCdeGrpType|ScCdeGrpTypeIdSource", deepLoadType, innerList) 
				&& entity.ScCdeGrpTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScCdeGrpTypeId;
				ScCdeGrpType tmpEntity = EntityManager.LocateEntity<ScCdeGrpType>(EntityLocator.ConstructKeyFromPkItems(typeof(ScCdeGrpType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScCdeGrpTypeIdSource = tmpEntity;
				else
					entity.ScCdeGrpTypeIdSource = DataRepository.ScCdeGrpTypeProvider.GetByScCdeGrpTypeId(transactionManager, entity.ScCdeGrpTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScCdeGrpTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScCdeGrpTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScCdeGrpTypeProvider.DeepLoad(transactionManager, entity.ScCdeGrpTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScCdeGrpTypeIdSource

			#region ScGroupInfoPrntIdSource	
			if (CanDeepLoad(entity, "ScGroupInfo|ScGroupInfoPrntIdSource", deepLoadType, innerList) 
				&& entity.ScGroupInfoPrntIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScGroupInfoPrntId ?? 0.0m);
				ScGroupInfo tmpEntity = EntityManager.LocateEntity<ScGroupInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(ScGroupInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScGroupInfoPrntIdSource = tmpEntity;
				else
					entity.ScGroupInfoPrntIdSource = DataRepository.ScGroupInfoProvider.GetByScGroupInfoId(transactionManager, (entity.ScGroupInfoPrntId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupInfoPrntIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScGroupInfoPrntIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScGroupInfoProvider.DeepLoad(transactionManager, entity.ScGroupInfoPrntIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScGroupInfoPrntIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByScGroupInfoId methods when available
			
			#region ScGroupDayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScGroupDay>|ScGroupDayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupDayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScGroupDayCollection = DataRepository.ScGroupDayProvider.GetByScGroupInfoId(transactionManager, entity.ScGroupInfoId);

				if (deep && entity.ScGroupDayCollection.Count > 0)
				{
					deepHandles.Add("ScGroupDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupDay>) DataRepository.ScGroupDayProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupDayCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScStudGroupCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScStudGroup>|ScStudGroupCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScStudGroupCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScStudGroupCollection = DataRepository.ScStudGroupProvider.GetByScGroupInfoId(transactionManager, entity.ScGroupInfoId);

				if (deep && entity.ScStudGroupCollection.Count > 0)
				{
					deepHandles.Add("ScStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScStudGroup>) DataRepository.ScStudGroupProvider.DeepLoad,
						new object[] { transactionManager, entity.ScStudGroupCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScGroupInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScGroupInfo>|ScGroupInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScGroupInfoCollection = DataRepository.ScGroupInfoProvider.GetByScGroupInfoPrntId(transactionManager, entity.ScGroupInfoId);

				if (deep && entity.ScGroupInfoCollection.Count > 0)
				{
					deepHandles.Add("ScGroupInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupInfo>) DataRepository.ScGroupInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupInfoCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSchdlHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSchdlHdr>|ScSchdlHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSchdlHdrCollection = DataRepository.ScSchdlHdrProvider.GetByScGroupInfoId(transactionManager, entity.ScGroupInfoId);

				if (deep && entity.ScSchdlHdrCollection.Count > 0)
				{
					deepHandles.Add("ScSchdlHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSchdlHdr>) DataRepository.ScSchdlHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSchdlHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScScheduleRsrvCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleRsrv>|ScScheduleRsrvCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleRsrvCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleRsrvCollection = DataRepository.ScScheduleRsrvProvider.GetByScGroupInfoId(transactionManager, entity.ScGroupInfoId);

				if (deep && entity.ScScheduleRsrvCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleRsrvCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleRsrv>) DataRepository.ScScheduleRsrvProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleRsrvCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScGroupInfo object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScGroupInfo instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScGroupInfo Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScGroupInfo entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCdeTchngMthdIdSource
			if (CanDeepSave(entity, "EdCdeTchngMthd|EdCdeTchngMthdIdSource", deepSaveType, innerList) 
				&& entity.EdCdeTchngMthdIdSource != null)
			{
				DataRepository.EdCdeTchngMthdProvider.Save(transactionManager, entity.EdCdeTchngMthdIdSource);
				entity.EdCdeTchngMthdId = entity.EdCdeTchngMthdIdSource.EdCdeTchngMthdId;
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
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
			}
			#endregion 
			
			#region ScCdeGrpTypeIdSource
			if (CanDeepSave(entity, "ScCdeGrpType|ScCdeGrpTypeIdSource", deepSaveType, innerList) 
				&& entity.ScCdeGrpTypeIdSource != null)
			{
				DataRepository.ScCdeGrpTypeProvider.Save(transactionManager, entity.ScCdeGrpTypeIdSource);
				entity.ScCdeGrpTypeId = entity.ScCdeGrpTypeIdSource.ScCdeGrpTypeId;
			}
			#endregion 
			
			#region ScGroupInfoPrntIdSource
			if (CanDeepSave(entity, "ScGroupInfo|ScGroupInfoPrntIdSource", deepSaveType, innerList) 
				&& entity.ScGroupInfoPrntIdSource != null)
			{
				DataRepository.ScGroupInfoProvider.Save(transactionManager, entity.ScGroupInfoPrntIdSource);
				entity.ScGroupInfoPrntId = entity.ScGroupInfoPrntIdSource.ScGroupInfoId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<ScGroupDay>
				if (CanDeepSave(entity.ScGroupDayCollection, "List<ScGroupDay>|ScGroupDayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScGroupDay child in entity.ScGroupDayCollection)
					{
						if(child.ScGroupInfoIdSource != null)
						{
							child.ScGroupInfoId = child.ScGroupInfoIdSource.ScGroupInfoId;
						}
						else
						{
							child.ScGroupInfoId = entity.ScGroupInfoId;
						}

					}

					if (entity.ScGroupDayCollection.Count > 0 || entity.ScGroupDayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScGroupDayProvider.Save(transactionManager, entity.ScGroupDayCollection);
						
						deepHandles.Add("ScGroupDayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScGroupDay >) DataRepository.ScGroupDayProvider.DeepSave,
							new object[] { transactionManager, entity.ScGroupDayCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScStudGroup>
				if (CanDeepSave(entity.ScStudGroupCollection, "List<ScStudGroup>|ScStudGroupCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScStudGroup child in entity.ScStudGroupCollection)
					{
						if(child.ScGroupInfoIdSource != null)
						{
							child.ScGroupInfoId = child.ScGroupInfoIdSource.ScGroupInfoId;
						}
						else
						{
							child.ScGroupInfoId = entity.ScGroupInfoId;
						}

					}

					if (entity.ScStudGroupCollection.Count > 0 || entity.ScStudGroupCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScStudGroupProvider.Save(transactionManager, entity.ScStudGroupCollection);
						
						deepHandles.Add("ScStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScStudGroup >) DataRepository.ScStudGroupProvider.DeepSave,
							new object[] { transactionManager, entity.ScStudGroupCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScGroupInfo>
				if (CanDeepSave(entity.ScGroupInfoCollection, "List<ScGroupInfo>|ScGroupInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScGroupInfo child in entity.ScGroupInfoCollection)
					{
						if(child.ScGroupInfoPrntIdSource != null)
						{
							child.ScGroupInfoPrntId = child.ScGroupInfoPrntIdSource.ScGroupInfoId;
						}
						else
						{
							child.ScGroupInfoPrntId = entity.ScGroupInfoId;
						}

					}

					if (entity.ScGroupInfoCollection.Count > 0 || entity.ScGroupInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScGroupInfoProvider.Save(transactionManager, entity.ScGroupInfoCollection);
						
						deepHandles.Add("ScGroupInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScGroupInfo >) DataRepository.ScGroupInfoProvider.DeepSave,
							new object[] { transactionManager, entity.ScGroupInfoCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSchdlHdr>
				if (CanDeepSave(entity.ScSchdlHdrCollection, "List<ScSchdlHdr>|ScSchdlHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSchdlHdr child in entity.ScSchdlHdrCollection)
					{
						if(child.ScGroupInfoIdSource != null)
						{
							child.ScGroupInfoId = child.ScGroupInfoIdSource.ScGroupInfoId;
						}
						else
						{
							child.ScGroupInfoId = entity.ScGroupInfoId;
						}

					}

					if (entity.ScSchdlHdrCollection.Count > 0 || entity.ScSchdlHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSchdlHdrProvider.Save(transactionManager, entity.ScSchdlHdrCollection);
						
						deepHandles.Add("ScSchdlHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSchdlHdr >) DataRepository.ScSchdlHdrProvider.DeepSave,
							new object[] { transactionManager, entity.ScSchdlHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScScheduleRsrv>
				if (CanDeepSave(entity.ScScheduleRsrvCollection, "List<ScScheduleRsrv>|ScScheduleRsrvCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleRsrv child in entity.ScScheduleRsrvCollection)
					{
						if(child.ScGroupInfoIdSource != null)
						{
							child.ScGroupInfoId = child.ScGroupInfoIdSource.ScGroupInfoId;
						}
						else
						{
							child.ScGroupInfoId = entity.ScGroupInfoId;
						}

					}

					if (entity.ScScheduleRsrvCollection.Count > 0 || entity.ScScheduleRsrvCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleRsrvProvider.Save(transactionManager, entity.ScScheduleRsrvCollection);
						
						deepHandles.Add("ScScheduleRsrvCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleRsrv >) DataRepository.ScScheduleRsrvProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleRsrvCollection, deepSaveType, childTypes, innerList }
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
	
	#region ScGroupInfoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScGroupInfo</c>
	///</summary>
	public enum ScGroupInfoChildEntityTypes
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
		/// Composite Property for <c>EdCdeTchngMthd</c> at EdCdeTchngMthdIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeTchngMthd))]
		EdCdeTchngMthd,
		
		///<summary>
		/// Composite Property for <c>EdCodeLevel</c> at EdCodeLevelIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLevel))]
		EdCodeLevel,
		
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
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>ScCdeGrpType</c> at ScCdeGrpTypeIdSource
		///</summary>
		[ChildEntityType(typeof(ScCdeGrpType))]
		ScCdeGrpType,
		
		///<summary>
		/// Composite Property for <c>ScGroupInfo</c> at ScGroupInfoPrntIdSource
		///</summary>
		[ChildEntityType(typeof(ScGroupInfo))]
		ScGroupInfo,
		///<summary>
		/// Collection of <c>ScGroupInfo</c> as OneToMany for ScGroupDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupDay>))]
		ScGroupDayCollection,
		///<summary>
		/// Collection of <c>ScGroupInfo</c> as OneToMany for ScStudGroupCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScStudGroup>))]
		ScStudGroupCollection,
		///<summary>
		/// Collection of <c>ScGroupInfo</c> as OneToMany for ScGroupInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupInfo>))]
		ScGroupInfoCollection,
		///<summary>
		/// Collection of <c>ScGroupInfo</c> as OneToMany for ScSchdlHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSchdlHdr>))]
		ScSchdlHdrCollection,
		///<summary>
		/// Collection of <c>ScGroupInfo</c> as OneToMany for ScScheduleRsrvCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleRsrv>))]
		ScScheduleRsrvCollection,
	}
	
	#endregion ScGroupInfoChildEntityTypes
	
	#region ScGroupInfoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScGroupInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScGroupInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScGroupInfoFilterBuilder : SqlFilterBuilder<ScGroupInfoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScGroupInfoFilterBuilder class.
		/// </summary>
		public ScGroupInfoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScGroupInfoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScGroupInfoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScGroupInfoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScGroupInfoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScGroupInfoFilterBuilder
	
	#region ScGroupInfoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScGroupInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScGroupInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScGroupInfoParameterBuilder : ParameterizedSqlFilterBuilder<ScGroupInfoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScGroupInfoParameterBuilder class.
		/// </summary>
		public ScGroupInfoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScGroupInfoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScGroupInfoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScGroupInfoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScGroupInfoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScGroupInfoParameterBuilder
	
	#region ScGroupInfoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScGroupInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScGroupInfo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScGroupInfoSortBuilder : SqlSortBuilder<ScGroupInfoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScGroupInfoSqlSortBuilder class.
		/// </summary>
		public ScGroupInfoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScGroupInfoSortBuilder
	
} // end namespace
