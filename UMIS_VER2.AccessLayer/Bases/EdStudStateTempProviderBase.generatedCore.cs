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
	/// This class is the base class for any <see cref="EdStudStateTempProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudStateTempProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudStateTemp, UMIS_VER2.BusinessLyer.EdStudStateTempKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudStateTempKey key)
		{
			return Delete(transactionManager, key.EdStudStateTempId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudStateTempId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudStateTempId)
		{
			return Delete(null, _edStudStateTempId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudStateTempId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudStateTempId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_AS_FACULTY_INFO key.
		///		FK_ED_STUD_STATE_TEMP_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_AS_FACULTY_INFO key.
		///		FK_ED_STUD_STATE_TEMP_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudStateTemp> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_AS_FACULTY_INFO key.
		///		FK_ED_STUD_STATE_TEMP_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_AS_FACULTY_INFO key.
		///		fkEdStudStateTempAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_AS_FACULTY_INFO key.
		///		fkEdStudStateTempAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_AS_FACULTY_INFO key.
		///		FK_ED_STUD_STATE_TEMP_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public abstract TList<EdStudStateTemp> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_ACAD_YEAR key.
		///		FK_ED_STUD_STATE_TEMP_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearPlnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEdAcadYearPlnId(System.Decimal? _edAcadYearPlnId)
		{
			int count = -1;
			return GetByEdAcadYearPlnId(_edAcadYearPlnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_ACAD_YEAR key.
		///		FK_ED_STUD_STATE_TEMP_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearPlnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudStateTemp> GetByEdAcadYearPlnId(TransactionManager transactionManager, System.Decimal? _edAcadYearPlnId)
		{
			int count = -1;
			return GetByEdAcadYearPlnId(transactionManager, _edAcadYearPlnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_ACAD_YEAR key.
		///		FK_ED_STUD_STATE_TEMP_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearPlnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEdAcadYearPlnId(TransactionManager transactionManager, System.Decimal? _edAcadYearPlnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearPlnId(transactionManager, _edAcadYearPlnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_ACAD_YEAR key.
		///		fkEdStudStateTempEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearPlnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEdAcadYearPlnId(System.Decimal? _edAcadYearPlnId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearPlnId(null, _edAcadYearPlnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_ACAD_YEAR key.
		///		fkEdStudStateTempEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearPlnId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEdAcadYearPlnId(System.Decimal? _edAcadYearPlnId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearPlnId(null, _edAcadYearPlnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_ACAD_YEAR key.
		///		FK_ED_STUD_STATE_TEMP_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearPlnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public abstract TList<EdStudStateTemp> GetByEdAcadYearPlnId(TransactionManager transactionManager, System.Decimal? _edAcadYearPlnId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_CODE_STATE_STATUS key.
		///		FK_ED_STUD_STATE_TEMP_ED_CODE_STATE_STATUS Description: 
		/// </summary>
		/// <param name="_edCodeStateStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEdCodeStateStatusId(System.Decimal? _edCodeStateStatusId)
		{
			int count = -1;
			return GetByEdCodeStateStatusId(_edCodeStateStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_CODE_STATE_STATUS key.
		///		FK_ED_STUD_STATE_TEMP_ED_CODE_STATE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStateStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudStateTemp> GetByEdCodeStateStatusId(TransactionManager transactionManager, System.Decimal? _edCodeStateStatusId)
		{
			int count = -1;
			return GetByEdCodeStateStatusId(transactionManager, _edCodeStateStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_CODE_STATE_STATUS key.
		///		FK_ED_STUD_STATE_TEMP_ED_CODE_STATE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStateStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEdCodeStateStatusId(TransactionManager transactionManager, System.Decimal? _edCodeStateStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStateStatusId(transactionManager, _edCodeStateStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_CODE_STATE_STATUS key.
		///		fkEdStudStateTempEdCodeStateStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeStateStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEdCodeStateStatusId(System.Decimal? _edCodeStateStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeStateStatusId(null, _edCodeStateStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_CODE_STATE_STATUS key.
		///		fkEdStudStateTempEdCodeStateStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeStateStatusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEdCodeStateStatusId(System.Decimal? _edCodeStateStatusId, int start, int pageLength,out int count)
		{
			return GetByEdCodeStateStatusId(null, _edCodeStateStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_CODE_STATE_STATUS key.
		///		FK_ED_STUD_STATE_TEMP_ED_CODE_STATE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStateStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public abstract TList<EdStudStateTemp> GetByEdCodeStateStatusId(TransactionManager transactionManager, System.Decimal? _edCodeStateStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_STUD key.
		///		FK_ED_STUD_STATE_TEMP_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_STUD key.
		///		FK_ED_STUD_STATE_TEMP_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudStateTemp> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_STUD key.
		///		FK_ED_STUD_STATE_TEMP_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_STUD key.
		///		fkEdStudStateTempEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_STUD key.
		///		fkEdStudStateTempEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_STUD key.
		///		FK_ED_STUD_STATE_TEMP_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public abstract TList<EdStudStateTemp> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_STATE_TEMP_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEdStudSemesterId(System.Decimal? _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(_edStudSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_STATE_TEMP_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudStateTemp> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_STATE_TEMP_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_STUD_SEMESTER key.
		///		fkEdStudStateTempEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEdStudSemesterId(System.Decimal? _edStudSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_STUD_SEMESTER key.
		///		fkEdStudStateTempEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEdStudSemesterId(System.Decimal? _edStudSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_STATE_TEMP_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public abstract TList<EdStudStateTemp> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ENT_CODE_ENTITY_TYPE key.
		///		FK_ED_STUD_STATE_TEMP_ENT_CODE_ENTITY_TYPE Description: 
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEntCodeEntityTypeId(System.Decimal? _entCodeEntityTypeId)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(_entCodeEntityTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ENT_CODE_ENTITY_TYPE key.
		///		FK_ED_STUD_STATE_TEMP_ENT_CODE_ENTITY_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudStateTemp> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal? _entCodeEntityTypeId)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(transactionManager, _entCodeEntityTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ENT_CODE_ENTITY_TYPE key.
		///		FK_ED_STUD_STATE_TEMP_ENT_CODE_ENTITY_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal? _entCodeEntityTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(transactionManager, _entCodeEntityTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ENT_CODE_ENTITY_TYPE key.
		///		fkEdStudStateTempEntCodeEntityType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEntCodeEntityTypeId(System.Decimal? _entCodeEntityTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntCodeEntityTypeId(null, _entCodeEntityTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ENT_CODE_ENTITY_TYPE key.
		///		fkEdStudStateTempEntCodeEntityType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEntCodeEntityTypeId(System.Decimal? _entCodeEntityTypeId, int start, int pageLength,out int count)
		{
			return GetByEntCodeEntityTypeId(null, _entCodeEntityTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ENT_CODE_ENTITY_TYPE key.
		///		FK_ED_STUD_STATE_TEMP_ENT_CODE_ENTITY_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public abstract TList<EdStudStateTemp> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal? _entCodeEntityTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ENTITY_MAIN key.
		///		FK_ED_STUD_STATE_TEMP_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ENTITY_MAIN key.
		///		FK_ED_STUD_STATE_TEMP_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudStateTemp> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ENTITY_MAIN key.
		///		FK_ED_STUD_STATE_TEMP_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ENTITY_MAIN key.
		///		fkEdStudStateTempEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ENTITY_MAIN key.
		///		fkEdStudStateTempEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public TList<EdStudStateTemp> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_TEMP_ENTITY_MAIN key.
		///		FK_ED_STUD_STATE_TEMP_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudStateTemp objects.</returns>
		public abstract TList<EdStudStateTemp> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudStateTemp Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudStateTempKey key, int start, int pageLength)
		{
			return GetByEdStudStateTempId(transactionManager, key.EdStudStateTempId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_STUD_STATE_TEMP index.
		/// </summary>
		/// <param name="_edStudStateTempId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudStateTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudStateTemp GetByEdStudStateTempId(System.Decimal _edStudStateTempId)
		{
			int count = -1;
			return GetByEdStudStateTempId(null,_edStudStateTempId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_STATE_TEMP index.
		/// </summary>
		/// <param name="_edStudStateTempId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudStateTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudStateTemp GetByEdStudStateTempId(System.Decimal _edStudStateTempId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudStateTempId(null, _edStudStateTempId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_STATE_TEMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudStateTempId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudStateTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudStateTemp GetByEdStudStateTempId(TransactionManager transactionManager, System.Decimal _edStudStateTempId)
		{
			int count = -1;
			return GetByEdStudStateTempId(transactionManager, _edStudStateTempId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_STATE_TEMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudStateTempId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudStateTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudStateTemp GetByEdStudStateTempId(TransactionManager transactionManager, System.Decimal _edStudStateTempId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudStateTempId(transactionManager, _edStudStateTempId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_STATE_TEMP index.
		/// </summary>
		/// <param name="_edStudStateTempId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudStateTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudStateTemp GetByEdStudStateTempId(System.Decimal _edStudStateTempId, int start, int pageLength, out int count)
		{
			return GetByEdStudStateTempId(null, _edStudStateTempId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_STATE_TEMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudStateTempId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudStateTemp"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudStateTemp GetByEdStudStateTempId(TransactionManager transactionManager, System.Decimal _edStudStateTempId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_STATE_TEMP index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudStateTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudStateTemp GetByEdStudSemesterIdEntMainId(System.Decimal? _edStudSemesterId, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEdStudSemesterIdEntMainId(null,_edStudSemesterId, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_STATE_TEMP index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudStateTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudStateTemp GetByEdStudSemesterIdEntMainId(System.Decimal? _edStudSemesterId, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterIdEntMainId(null, _edStudSemesterId, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_STATE_TEMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudStateTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudStateTemp GetByEdStudSemesterIdEntMainId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEdStudSemesterIdEntMainId(transactionManager, _edStudSemesterId, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_STATE_TEMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudStateTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudStateTemp GetByEdStudSemesterIdEntMainId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterIdEntMainId(transactionManager, _edStudSemesterId, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_STATE_TEMP index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudStateTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudStateTemp GetByEdStudSemesterIdEntMainId(System.Decimal? _edStudSemesterId, System.Decimal _entMainId, int start, int pageLength, out int count)
		{
			return GetByEdStudSemesterIdEntMainId(null, _edStudSemesterId, _entMainId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_STATE_TEMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudStateTemp"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudStateTemp GetByEdStudSemesterIdEntMainId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudStateTemp&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudStateTemp&gt;"/></returns>
		public static TList<EdStudStateTemp> Fill(IDataReader reader, TList<EdStudStateTemp> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudStateTemp c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudStateTemp")
					.Append("|").Append((System.Decimal)reader["ED_STUD_STATE_TEMP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudStateTemp>(
					key.ToString(), // EntityTrackingKey
					"EdStudStateTemp",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudStateTemp();
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
					c.EdStudStateTempId = (System.Decimal)reader["ED_STUD_STATE_TEMP_ID"];
					c.OriginalEdStudStateTempId = c.EdStudStateTempId;
					c.EdStudSemesterId = Convert.IsDBNull(reader["ED_STUD_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_STUD_SEMESTER_ID"];
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.TotCh = Convert.IsDBNull(reader["TOT_CH"]) ? null : (System.Decimal?)reader["TOT_CH"];
					c.FullfilledCh = Convert.IsDBNull(reader["FULLFILLED_CH"]) ? null : (System.Decimal?)reader["FULLFILLED_CH"];
					c.EdCodeStateStatusId = Convert.IsDBNull(reader["ED_CODE_STATE_STATUS_ID"]) ? null : (System.Decimal?)reader["ED_CODE_STATE_STATUS_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.IsDeclared = (System.Decimal)reader["IS_DECLARED"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EntCodeEntityTypeId = Convert.IsDBNull(reader["ENT_CODE_ENTITY_TYPE_ID"]) ? null : (System.Decimal?)reader["ENT_CODE_ENTITY_TYPE_ID"];
					c.EdAcadYearPlnId = Convert.IsDBNull(reader["ED_ACAD_YEAR_PLN_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_PLN_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudStateTemp"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudStateTemp"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudStateTemp entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudStateTempId = (System.Decimal)reader[((int)EdStudStateTempColumn.EdStudStateTempId - 1)];
			entity.OriginalEdStudStateTempId = (System.Decimal)reader["ED_STUD_STATE_TEMP_ID"];
			entity.EdStudSemesterId = (reader.IsDBNull(((int)EdStudStateTempColumn.EdStudSemesterId - 1)))?null:(System.Decimal?)reader[((int)EdStudStateTempColumn.EdStudSemesterId - 1)];
			entity.EntMainId = (System.Decimal)reader[((int)EdStudStateTempColumn.EntMainId - 1)];
			entity.TotCh = (reader.IsDBNull(((int)EdStudStateTempColumn.TotCh - 1)))?null:(System.Decimal?)reader[((int)EdStudStateTempColumn.TotCh - 1)];
			entity.FullfilledCh = (reader.IsDBNull(((int)EdStudStateTempColumn.FullfilledCh - 1)))?null:(System.Decimal?)reader[((int)EdStudStateTempColumn.FullfilledCh - 1)];
			entity.EdCodeStateStatusId = (reader.IsDBNull(((int)EdStudStateTempColumn.EdCodeStateStatusId - 1)))?null:(System.Decimal?)reader[((int)EdStudStateTempColumn.EdCodeStateStatusId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)EdStudStateTempColumn.AsFacultyInfoId - 1)];
			entity.IsDeclared = (System.Decimal)reader[((int)EdStudStateTempColumn.IsDeclared - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)EdStudStateTempColumn.EdStudId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)EdStudStateTempColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)EdStudStateTempColumn.EdCodeSemesterId - 1)];
			entity.EntCodeEntityTypeId = (reader.IsDBNull(((int)EdStudStateTempColumn.EntCodeEntityTypeId - 1)))?null:(System.Decimal?)reader[((int)EdStudStateTempColumn.EntCodeEntityTypeId - 1)];
			entity.EdAcadYearPlnId = (reader.IsDBNull(((int)EdStudStateTempColumn.EdAcadYearPlnId - 1)))?null:(System.Decimal?)reader[((int)EdStudStateTempColumn.EdAcadYearPlnId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudStateTemp"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudStateTemp"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudStateTemp entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudStateTempId = (System.Decimal)dataRow["ED_STUD_STATE_TEMP_ID"];
			entity.OriginalEdStudStateTempId = (System.Decimal)dataRow["ED_STUD_STATE_TEMP_ID"];
			entity.EdStudSemesterId = Convert.IsDBNull(dataRow["ED_STUD_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_SEMESTER_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.TotCh = Convert.IsDBNull(dataRow["TOT_CH"]) ? null : (System.Decimal?)dataRow["TOT_CH"];
			entity.FullfilledCh = Convert.IsDBNull(dataRow["FULLFILLED_CH"]) ? null : (System.Decimal?)dataRow["FULLFILLED_CH"];
			entity.EdCodeStateStatusId = Convert.IsDBNull(dataRow["ED_CODE_STATE_STATUS_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_STATE_STATUS_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.IsDeclared = (System.Decimal)dataRow["IS_DECLARED"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EntCodeEntityTypeId = Convert.IsDBNull(dataRow["ENT_CODE_ENTITY_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ENT_CODE_ENTITY_TYPE_ID"];
			entity.EdAcadYearPlnId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_PLN_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_PLN_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudStateTemp"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudStateTemp Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudStateTemp entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdAcadYearPlnIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearPlnIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearPlnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearPlnId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearPlnIdSource = tmpEntity;
				else
					entity.EdAcadYearPlnIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearPlnId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearPlnIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearPlnIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearPlnIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearPlnIdSource

			#region EdCodeStateStatusIdSource	
			if (CanDeepLoad(entity, "EdCodeStateStatus|EdCodeStateStatusIdSource", deepLoadType, innerList) 
				&& entity.EdCodeStateStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeStateStatusId ?? 0.0m);
				EdCodeStateStatus tmpEntity = EntityManager.LocateEntity<EdCodeStateStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeStateStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeStateStatusIdSource = tmpEntity;
				else
					entity.EdCodeStateStatusIdSource = DataRepository.EdCodeStateStatusProvider.GetByEdCodeStateStatusId(transactionManager, (entity.EdCodeStateStatusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeStateStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeStateStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeStateStatusProvider.DeepLoad(transactionManager, entity.EdCodeStateStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeStateStatusIdSource

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

			#region EdStudSemesterIdSource	
			if (CanDeepLoad(entity, "EdStudSemester|EdStudSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdStudSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudSemesterId ?? 0.0m);
				EdStudSemester tmpEntity = EntityManager.LocateEntity<EdStudSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudSemesterIdSource = tmpEntity;
				else
					entity.EdStudSemesterIdSource = DataRepository.EdStudSemesterProvider.GetByEdStudSemesterId(transactionManager, (entity.EdStudSemesterId ?? 0.0m));		
				
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

			#region EntCodeEntityTypeIdSource	
			if (CanDeepLoad(entity, "EntCodeEntityType|EntCodeEntityTypeIdSource", deepLoadType, innerList) 
				&& entity.EntCodeEntityTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntCodeEntityTypeId ?? 0.0m);
				EntCodeEntityType tmpEntity = EntityManager.LocateEntity<EntCodeEntityType>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCodeEntityType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCodeEntityTypeIdSource = tmpEntity;
				else
					entity.EntCodeEntityTypeIdSource = DataRepository.EntCodeEntityTypeProvider.GetByEntCodeEntityTypeId(transactionManager, (entity.EntCodeEntityTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodeEntityTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCodeEntityTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCodeEntityTypeProvider.DeepLoad(transactionManager, entity.EntCodeEntityTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCodeEntityTypeIdSource

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntMainId;
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, entity.EntMainId);		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudStateTemp object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudStateTemp instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudStateTemp Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudStateTemp entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdAcadYearPlnIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearPlnIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearPlnIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearPlnIdSource);
				entity.EdAcadYearPlnId = entity.EdAcadYearPlnIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EdCodeStateStatusIdSource
			if (CanDeepSave(entity, "EdCodeStateStatus|EdCodeStateStatusIdSource", deepSaveType, innerList) 
				&& entity.EdCodeStateStatusIdSource != null)
			{
				DataRepository.EdCodeStateStatusProvider.Save(transactionManager, entity.EdCodeStateStatusIdSource);
				entity.EdCodeStateStatusId = entity.EdCodeStateStatusIdSource.EdCodeStateStatusId;
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
			
			#region EdStudSemesterIdSource
			if (CanDeepSave(entity, "EdStudSemester|EdStudSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdStudSemesterIdSource != null)
			{
				DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterIdSource);
				entity.EdStudSemesterId = entity.EdStudSemesterIdSource.EdStudSemesterId;
			}
			#endregion 
			
			#region EntCodeEntityTypeIdSource
			if (CanDeepSave(entity, "EntCodeEntityType|EntCodeEntityTypeIdSource", deepSaveType, innerList) 
				&& entity.EntCodeEntityTypeIdSource != null)
			{
				DataRepository.EntCodeEntityTypeProvider.Save(transactionManager, entity.EntCodeEntityTypeIdSource);
				entity.EntCodeEntityTypeId = entity.EntCodeEntityTypeIdSource.EntCodeEntityTypeId;
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
	
	#region EdStudStateTempChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudStateTemp</c>
	///</summary>
	public enum EdStudStateTempChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearPlnIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCodeStateStatus</c> at EdCodeStateStatusIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeStateStatus))]
		EdCodeStateStatus,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>EdStudSemester</c> at EdStudSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudSemester))]
		EdStudSemester,
		
		///<summary>
		/// Composite Property for <c>EntCodeEntityType</c> at EntCodeEntityTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodeEntityType))]
		EntCodeEntityType,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
	}
	
	#endregion EdStudStateTempChildEntityTypes
	
	#region EdStudStateTempFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudStateTempColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudStateTemp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudStateTempFilterBuilder : SqlFilterBuilder<EdStudStateTempColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudStateTempFilterBuilder class.
		/// </summary>
		public EdStudStateTempFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudStateTempFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudStateTempFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudStateTempFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudStateTempFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudStateTempFilterBuilder
	
	#region EdStudStateTempParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudStateTempColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudStateTemp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudStateTempParameterBuilder : ParameterizedSqlFilterBuilder<EdStudStateTempColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudStateTempParameterBuilder class.
		/// </summary>
		public EdStudStateTempParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudStateTempParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudStateTempParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudStateTempParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudStateTempParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudStateTempParameterBuilder
	
	#region EdStudStateTempSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudStateTempColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudStateTemp"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudStateTempSortBuilder : SqlSortBuilder<EdStudStateTempColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudStateTempSqlSortBuilder class.
		/// </summary>
		public EdStudStateTempSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudStateTempSortBuilder
	
} // end namespace
