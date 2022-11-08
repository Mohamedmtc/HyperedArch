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
	/// This class is the base class for any <see cref="EdSemAgendaDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdSemAgendaDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdSemAgendaDtl, UMIS_VER2.BusinessLyer.EdSemAgendaDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemAgendaDtlKey key)
		{
			return Delete(transactionManager, key.EdSemAgendaDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edSemAgendaDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edSemAgendaDtlId)
		{
			return Delete(null, _edSemAgendaDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemAgendaDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edSemAgendaDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_AS_FACULTY_INFO key.
		///		FK_ED_SEM_AGENDA_DTL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_AS_FACULTY_INFO key.
		///		FK_ED_SEM_AGENDA_DTL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EdSemAgendaDtl> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_AS_FACULTY_INFO key.
		///		FK_ED_SEM_AGENDA_DTL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_AS_FACULTY_INFO key.
		///		fkEdSemAgendaDtlAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_AS_FACULTY_INFO key.
		///		fkEdSemAgendaDtlAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_AS_FACULTY_INFO key.
		///		FK_ED_SEM_AGENDA_DTL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public abstract TList<EdSemAgendaDtl> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR key.
		///		FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_fAdmAcadYearId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByFAdmAcadYearId(System.Decimal? _fAdmAcadYearId)
		{
			int count = -1;
			return GetByFAdmAcadYearId(_fAdmAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR key.
		///		FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_fAdmAcadYearId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EdSemAgendaDtl> GetByFAdmAcadYearId(TransactionManager transactionManager, System.Decimal? _fAdmAcadYearId)
		{
			int count = -1;
			return GetByFAdmAcadYearId(transactionManager, _fAdmAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR key.
		///		FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_fAdmAcadYearId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByFAdmAcadYearId(TransactionManager transactionManager, System.Decimal? _fAdmAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByFAdmAcadYearId(transactionManager, _fAdmAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR key.
		///		fkEdSemAgendaDtlEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_fAdmAcadYearId">XX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByFAdmAcadYearId(System.Decimal? _fAdmAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFAdmAcadYearId(null, _fAdmAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR key.
		///		fkEdSemAgendaDtlEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_fAdmAcadYearId">XX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByFAdmAcadYearId(System.Decimal? _fAdmAcadYearId, int start, int pageLength,out int count)
		{
			return GetByFAdmAcadYearId(null, _fAdmAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR key.
		///		FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_fAdmAcadYearId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public abstract TList<EdSemAgendaDtl> GetByFAdmAcadYearId(TransactionManager transactionManager, System.Decimal? _fAdmAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR1 key.
		///		FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="_tAdmAcadYearId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByTAdmAcadYearId(System.Decimal? _tAdmAcadYearId)
		{
			int count = -1;
			return GetByTAdmAcadYearId(_tAdmAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR1 key.
		///		FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_tAdmAcadYearId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EdSemAgendaDtl> GetByTAdmAcadYearId(TransactionManager transactionManager, System.Decimal? _tAdmAcadYearId)
		{
			int count = -1;
			return GetByTAdmAcadYearId(transactionManager, _tAdmAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR1 key.
		///		FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_tAdmAcadYearId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByTAdmAcadYearId(TransactionManager transactionManager, System.Decimal? _tAdmAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByTAdmAcadYearId(transactionManager, _tAdmAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR1 key.
		///		fkEdSemAgendaDtlEdAcadYear1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_tAdmAcadYearId">XX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByTAdmAcadYearId(System.Decimal? _tAdmAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByTAdmAcadYearId(null, _tAdmAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR1 key.
		///		fkEdSemAgendaDtlEdAcadYear1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_tAdmAcadYearId">XX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByTAdmAcadYearId(System.Decimal? _tAdmAcadYearId, int start, int pageLength,out int count)
		{
			return GetByTAdmAcadYearId(null, _tAdmAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR1 key.
		///		FK_ED_SEM_AGENDA_DTL_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_tAdmAcadYearId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public abstract TList<EdSemAgendaDtl> GetByTAdmAcadYearId(TransactionManager transactionManager, System.Decimal? _tAdmAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_CODE_LEVEL key.
		///		FK_ED_SEM_AGENDA_DTL_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(_edCodeLevelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_CODE_LEVEL key.
		///		FK_ED_SEM_AGENDA_DTL_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EdSemAgendaDtl> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_CODE_LEVEL key.
		///		FK_ED_SEM_AGENDA_DTL_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_CODE_LEVEL key.
		///		fkEdSemAgendaDtlEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_CODE_LEVEL key.
		///		fkEdSemAgendaDtlEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_CODE_LEVEL key.
		///		FK_ED_SEM_AGENDA_DTL_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public abstract TList<EdSemAgendaDtl> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_SEMESTER_AGENDA key.
		///		FK_ED_SEM_AGENDA_DTL_ED_SEMESTER_AGENDA Description: 
		/// </summary>
		/// <param name="_edSemesterAgendaId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByEdSemesterAgendaId(System.Decimal _edSemesterAgendaId)
		{
			int count = -1;
			return GetByEdSemesterAgendaId(_edSemesterAgendaId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_SEMESTER_AGENDA key.
		///		FK_ED_SEM_AGENDA_DTL_ED_SEMESTER_AGENDA Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterAgendaId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EdSemAgendaDtl> GetByEdSemesterAgendaId(TransactionManager transactionManager, System.Decimal _edSemesterAgendaId)
		{
			int count = -1;
			return GetByEdSemesterAgendaId(transactionManager, _edSemesterAgendaId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_SEMESTER_AGENDA key.
		///		FK_ED_SEM_AGENDA_DTL_ED_SEMESTER_AGENDA Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterAgendaId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByEdSemesterAgendaId(TransactionManager transactionManager, System.Decimal _edSemesterAgendaId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdSemesterAgendaId(transactionManager, _edSemesterAgendaId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_SEMESTER_AGENDA key.
		///		fkEdSemAgendaDtlEdSemesterAgenda Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edSemesterAgendaId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByEdSemesterAgendaId(System.Decimal _edSemesterAgendaId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdSemesterAgendaId(null, _edSemesterAgendaId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_SEMESTER_AGENDA key.
		///		fkEdSemAgendaDtlEdSemesterAgenda Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edSemesterAgendaId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public TList<EdSemAgendaDtl> GetByEdSemesterAgendaId(System.Decimal _edSemesterAgendaId, int start, int pageLength,out int count)
		{
			return GetByEdSemesterAgendaId(null, _edSemesterAgendaId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_DTL_ED_SEMESTER_AGENDA key.
		///		FK_ED_SEM_AGENDA_DTL_ED_SEMESTER_AGENDA Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterAgendaId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaDtl objects.</returns>
		public abstract TList<EdSemAgendaDtl> GetByEdSemesterAgendaId(TransactionManager transactionManager, System.Decimal _edSemesterAgendaId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdSemAgendaDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemAgendaDtlKey key, int start, int pageLength)
		{
			return GetByEdSemAgendaDtlId(transactionManager, key.EdSemAgendaDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_SEM_AGENDA_DTL index.
		/// </summary>
		/// <param name="_edSemAgendaDtlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemAgendaDtl GetByEdSemAgendaDtlId(System.Decimal _edSemAgendaDtlId)
		{
			int count = -1;
			return GetByEdSemAgendaDtlId(null,_edSemAgendaDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_AGENDA_DTL index.
		/// </summary>
		/// <param name="_edSemAgendaDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemAgendaDtl GetByEdSemAgendaDtlId(System.Decimal _edSemAgendaDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdSemAgendaDtlId(null, _edSemAgendaDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_AGENDA_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemAgendaDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemAgendaDtl GetByEdSemAgendaDtlId(TransactionManager transactionManager, System.Decimal _edSemAgendaDtlId)
		{
			int count = -1;
			return GetByEdSemAgendaDtlId(transactionManager, _edSemAgendaDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_AGENDA_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemAgendaDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemAgendaDtl GetByEdSemAgendaDtlId(TransactionManager transactionManager, System.Decimal _edSemAgendaDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdSemAgendaDtlId(transactionManager, _edSemAgendaDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_AGENDA_DTL index.
		/// </summary>
		/// <param name="_edSemAgendaDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemAgendaDtl GetByEdSemAgendaDtlId(System.Decimal _edSemAgendaDtlId, int start, int pageLength, out int count)
		{
			return GetByEdSemAgendaDtlId(null, _edSemAgendaDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_AGENDA_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemAgendaDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdSemAgendaDtl GetByEdSemAgendaDtlId(TransactionManager transactionManager, System.Decimal _edSemAgendaDtlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdSemAgendaDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdSemAgendaDtl&gt;"/></returns>
		public static TList<EdSemAgendaDtl> Fill(IDataReader reader, TList<EdSemAgendaDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdSemAgendaDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdSemAgendaDtl")
					.Append("|").Append((System.Decimal)reader["ED_SEM_AGENDA_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdSemAgendaDtl>(
					key.ToString(), // EntityTrackingKey
					"EdSemAgendaDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdSemAgendaDtl();
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
					c.EdSemAgendaDtlId = (System.Decimal)reader["ED_SEM_AGENDA_DTL_ID"];
					c.OriginalEdSemAgendaDtlId = c.EdSemAgendaDtlId;
					c.EdSemesterAgendaId = (System.Decimal)reader["ED_SEMESTER_AGENDA_ID"];
					c.FChPrcnt = Convert.IsDBNull(reader["F_CH_PRCNT"]) ? null : (System.Decimal?)reader["F_CH_PRCNT"];
					c.TChPrcnt = Convert.IsDBNull(reader["T_CH_PRCNT"]) ? null : (System.Decimal?)reader["T_CH_PRCNT"];
					c.FAdmAcadYearId = Convert.IsDBNull(reader["F_ADM_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["F_ADM_ACAD_YEAR_ID"];
					c.RegDate = Convert.IsDBNull(reader["REG_DATE"]) ? null : (System.DateTime?)reader["REG_DATE"];
					c.TAdmAcadYearId = Convert.IsDBNull(reader["T_ADM_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["T_ADM_ACAD_YEAR_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EdCodeLevelId = Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_ID"];
					c.FGpa = Convert.IsDBNull(reader["F_GPA"]) ? null : (System.Decimal?)reader["F_GPA"];
					c.TGpa = Convert.IsDBNull(reader["T_GPA"]) ? null : (System.Decimal?)reader["T_GPA"];
					c.FromDate = Convert.IsDBNull(reader["FROM_DATE"]) ? null : (System.DateTime?)reader["FROM_DATE"];
					c.ToDate = Convert.IsDBNull(reader["TO_DATE"]) ? null : (System.DateTime?)reader["TO_DATE"];
					c.OnlineFlg = (System.Decimal)reader["ONLINE_FLG"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.AudtNote = Convert.IsDBNull(reader["AUDT_NOTE"]) ? null : (System.String)reader["AUDT_NOTE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdSemAgendaDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.EdSemAgendaDtlId = (System.Decimal)reader[((int)EdSemAgendaDtlColumn.EdSemAgendaDtlId - 1)];
			entity.OriginalEdSemAgendaDtlId = (System.Decimal)reader["ED_SEM_AGENDA_DTL_ID"];
			entity.EdSemesterAgendaId = (System.Decimal)reader[((int)EdSemAgendaDtlColumn.EdSemesterAgendaId - 1)];
			entity.FChPrcnt = (reader.IsDBNull(((int)EdSemAgendaDtlColumn.FChPrcnt - 1)))?null:(System.Decimal?)reader[((int)EdSemAgendaDtlColumn.FChPrcnt - 1)];
			entity.TChPrcnt = (reader.IsDBNull(((int)EdSemAgendaDtlColumn.TChPrcnt - 1)))?null:(System.Decimal?)reader[((int)EdSemAgendaDtlColumn.TChPrcnt - 1)];
			entity.FAdmAcadYearId = (reader.IsDBNull(((int)EdSemAgendaDtlColumn.FAdmAcadYearId - 1)))?null:(System.Decimal?)reader[((int)EdSemAgendaDtlColumn.FAdmAcadYearId - 1)];
			entity.RegDate = (reader.IsDBNull(((int)EdSemAgendaDtlColumn.RegDate - 1)))?null:(System.DateTime?)reader[((int)EdSemAgendaDtlColumn.RegDate - 1)];
			entity.TAdmAcadYearId = (reader.IsDBNull(((int)EdSemAgendaDtlColumn.TAdmAcadYearId - 1)))?null:(System.Decimal?)reader[((int)EdSemAgendaDtlColumn.TAdmAcadYearId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdSemAgendaDtlColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdSemAgendaDtlColumn.AsFacultyInfoId - 1)];
			entity.EdCodeLevelId = (reader.IsDBNull(((int)EdSemAgendaDtlColumn.EdCodeLevelId - 1)))?null:(System.Decimal?)reader[((int)EdSemAgendaDtlColumn.EdCodeLevelId - 1)];
			entity.FGpa = (reader.IsDBNull(((int)EdSemAgendaDtlColumn.FGpa - 1)))?null:(System.Decimal?)reader[((int)EdSemAgendaDtlColumn.FGpa - 1)];
			entity.TGpa = (reader.IsDBNull(((int)EdSemAgendaDtlColumn.TGpa - 1)))?null:(System.Decimal?)reader[((int)EdSemAgendaDtlColumn.TGpa - 1)];
			entity.FromDate = (reader.IsDBNull(((int)EdSemAgendaDtlColumn.FromDate - 1)))?null:(System.DateTime?)reader[((int)EdSemAgendaDtlColumn.FromDate - 1)];
			entity.ToDate = (reader.IsDBNull(((int)EdSemAgendaDtlColumn.ToDate - 1)))?null:(System.DateTime?)reader[((int)EdSemAgendaDtlColumn.ToDate - 1)];
			entity.OnlineFlg = (System.Decimal)reader[((int)EdSemAgendaDtlColumn.OnlineFlg - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdSemAgendaDtlColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdSemAgendaDtlColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdSemAgendaDtlColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdSemAgendaDtlColumn.SeUserId - 1)];
			entity.AudtNote = (reader.IsDBNull(((int)EdSemAgendaDtlColumn.AudtNote - 1)))?null:(System.String)reader[((int)EdSemAgendaDtlColumn.AudtNote - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdSemAgendaDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdSemAgendaDtlId = (System.Decimal)dataRow["ED_SEM_AGENDA_DTL_ID"];
			entity.OriginalEdSemAgendaDtlId = (System.Decimal)dataRow["ED_SEM_AGENDA_DTL_ID"];
			entity.EdSemesterAgendaId = (System.Decimal)dataRow["ED_SEMESTER_AGENDA_ID"];
			entity.FChPrcnt = Convert.IsDBNull(dataRow["F_CH_PRCNT"]) ? null : (System.Decimal?)dataRow["F_CH_PRCNT"];
			entity.TChPrcnt = Convert.IsDBNull(dataRow["T_CH_PRCNT"]) ? null : (System.Decimal?)dataRow["T_CH_PRCNT"];
			entity.FAdmAcadYearId = Convert.IsDBNull(dataRow["F_ADM_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["F_ADM_ACAD_YEAR_ID"];
			entity.RegDate = Convert.IsDBNull(dataRow["REG_DATE"]) ? null : (System.DateTime?)dataRow["REG_DATE"];
			entity.TAdmAcadYearId = Convert.IsDBNull(dataRow["T_ADM_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["T_ADM_ACAD_YEAR_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdCodeLevelId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_ID"];
			entity.FGpa = Convert.IsDBNull(dataRow["F_GPA"]) ? null : (System.Decimal?)dataRow["F_GPA"];
			entity.TGpa = Convert.IsDBNull(dataRow["T_GPA"]) ? null : (System.Decimal?)dataRow["T_GPA"];
			entity.FromDate = Convert.IsDBNull(dataRow["FROM_DATE"]) ? null : (System.DateTime?)dataRow["FROM_DATE"];
			entity.ToDate = Convert.IsDBNull(dataRow["TO_DATE"]) ? null : (System.DateTime?)dataRow["TO_DATE"];
			entity.OnlineFlg = (System.Decimal)dataRow["ONLINE_FLG"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.AudtNote = Convert.IsDBNull(dataRow["AUDT_NOTE"]) ? null : (System.String)dataRow["AUDT_NOTE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdSemAgendaDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemAgendaDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region FAdmAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|FAdmAcadYearIdSource", deepLoadType, innerList) 
				&& entity.FAdmAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FAdmAcadYearId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FAdmAcadYearIdSource = tmpEntity;
				else
					entity.FAdmAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.FAdmAcadYearId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FAdmAcadYearIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FAdmAcadYearIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.FAdmAcadYearIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FAdmAcadYearIdSource

			#region TAdmAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|TAdmAcadYearIdSource", deepLoadType, innerList) 
				&& entity.TAdmAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.TAdmAcadYearId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.TAdmAcadYearIdSource = tmpEntity;
				else
					entity.TAdmAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.TAdmAcadYearId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TAdmAcadYearIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.TAdmAcadYearIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.TAdmAcadYearIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion TAdmAcadYearIdSource

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

			#region EdSemesterAgendaIdSource	
			if (CanDeepLoad(entity, "EdSemesterAgenda|EdSemesterAgendaIdSource", deepLoadType, innerList) 
				&& entity.EdSemesterAgendaIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdSemesterAgendaId;
				EdSemesterAgenda tmpEntity = EntityManager.LocateEntity<EdSemesterAgenda>(EntityLocator.ConstructKeyFromPkItems(typeof(EdSemesterAgenda), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdSemesterAgendaIdSource = tmpEntity;
				else
					entity.EdSemesterAgendaIdSource = DataRepository.EdSemesterAgendaProvider.GetByEdSemesterAgendaId(transactionManager, entity.EdSemesterAgendaId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemesterAgendaIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdSemesterAgendaIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdSemesterAgendaProvider.DeepLoad(transactionManager, entity.EdSemesterAgendaIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdSemesterAgendaIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdSemAgendaDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdSemAgendaDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdSemAgendaDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemAgendaDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region FAdmAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|FAdmAcadYearIdSource", deepSaveType, innerList) 
				&& entity.FAdmAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.FAdmAcadYearIdSource);
				entity.FAdmAcadYearId = entity.FAdmAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region TAdmAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|TAdmAcadYearIdSource", deepSaveType, innerList) 
				&& entity.TAdmAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.TAdmAcadYearIdSource);
				entity.TAdmAcadYearId = entity.TAdmAcadYearIdSource.EdAcadYearId;
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
			
			#region EdSemesterAgendaIdSource
			if (CanDeepSave(entity, "EdSemesterAgenda|EdSemesterAgendaIdSource", deepSaveType, innerList) 
				&& entity.EdSemesterAgendaIdSource != null)
			{
				DataRepository.EdSemesterAgendaProvider.Save(transactionManager, entity.EdSemesterAgendaIdSource);
				entity.EdSemesterAgendaId = entity.EdSemesterAgendaIdSource.EdSemesterAgendaId;
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
	
	#region EdSemAgendaDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdSemAgendaDtl</c>
	///</summary>
	public enum EdSemAgendaDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at FAdmAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCodeLevel</c> at EdCodeLevelIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLevel))]
		EdCodeLevel,
		
		///<summary>
		/// Composite Property for <c>EdSemesterAgenda</c> at EdSemesterAgendaIdSource
		///</summary>
		[ChildEntityType(typeof(EdSemesterAgenda))]
		EdSemesterAgenda,
	}
	
	#endregion EdSemAgendaDtlChildEntityTypes
	
	#region EdSemAgendaDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdSemAgendaDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdSemAgendaDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdSemAgendaDtlFilterBuilder : SqlFilterBuilder<EdSemAgendaDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaDtlFilterBuilder class.
		/// </summary>
		public EdSemAgendaDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdSemAgendaDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdSemAgendaDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdSemAgendaDtlFilterBuilder
	
	#region EdSemAgendaDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdSemAgendaDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdSemAgendaDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdSemAgendaDtlParameterBuilder : ParameterizedSqlFilterBuilder<EdSemAgendaDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaDtlParameterBuilder class.
		/// </summary>
		public EdSemAgendaDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdSemAgendaDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdSemAgendaDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdSemAgendaDtlParameterBuilder
	
	#region EdSemAgendaDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdSemAgendaDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdSemAgendaDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdSemAgendaDtlSortBuilder : SqlSortBuilder<EdSemAgendaDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaDtlSqlSortBuilder class.
		/// </summary>
		public EdSemAgendaDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdSemAgendaDtlSortBuilder
	
} // end namespace
