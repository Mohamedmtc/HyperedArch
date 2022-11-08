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
	/// This class is the base class for any <see cref="EdStudViolProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudViolProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudViol, UMIS_VER2.BusinessLyer.EdStudViolKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudViolKey key)
		{
			return Delete(transactionManager, key.EdStudViolId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudViolId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudViolId)
		{
			return Delete(null, _edStudViolId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudViolId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_ACAD_YEAR key.
		///		FK_ED_STUD_VIOL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_ACAD_YEAR key.
		///		FK_ED_STUD_VIOL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudViol> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_ACAD_YEAR key.
		///		FK_ED_STUD_VIOL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_ACAD_YEAR key.
		///		fkEdStudViolEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_ACAD_YEAR key.
		///		fkEdStudViolEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_ACAD_YEAR key.
		///		FK_ED_STUD_VIOL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public abstract TList<EdStudViol> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_ACAD_YEAR1 key.
		///		FK_ED_STUD_VIOL_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="_edAcadYearStopFromId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdAcadYearStopFromId(System.Decimal? _edAcadYearStopFromId)
		{
			int count = -1;
			return GetByEdAcadYearStopFromId(_edAcadYearStopFromId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_ACAD_YEAR1 key.
		///		FK_ED_STUD_VIOL_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearStopFromId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudViol> GetByEdAcadYearStopFromId(TransactionManager transactionManager, System.Decimal? _edAcadYearStopFromId)
		{
			int count = -1;
			return GetByEdAcadYearStopFromId(transactionManager, _edAcadYearStopFromId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_ACAD_YEAR1 key.
		///		FK_ED_STUD_VIOL_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearStopFromId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdAcadYearStopFromId(TransactionManager transactionManager, System.Decimal? _edAcadYearStopFromId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearStopFromId(transactionManager, _edAcadYearStopFromId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_ACAD_YEAR1 key.
		///		fkEdStudViolEdAcadYear1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearStopFromId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdAcadYearStopFromId(System.Decimal? _edAcadYearStopFromId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearStopFromId(null, _edAcadYearStopFromId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_ACAD_YEAR1 key.
		///		fkEdStudViolEdAcadYear1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearStopFromId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdAcadYearStopFromId(System.Decimal? _edAcadYearStopFromId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearStopFromId(null, _edAcadYearStopFromId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_ACAD_YEAR1 key.
		///		FK_ED_STUD_VIOL_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearStopFromId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public abstract TList<EdStudViol> GetByEdAcadYearStopFromId(TransactionManager transactionManager, System.Decimal? _edAcadYearStopFromId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_ACAD_YEAR2 key.
		///		FK_ED_STUD_VIOL_ED_ACAD_YEAR2 Description: 
		/// </summary>
		/// <param name="_edAcadYearStopToId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdAcadYearStopToId(System.Decimal? _edAcadYearStopToId)
		{
			int count = -1;
			return GetByEdAcadYearStopToId(_edAcadYearStopToId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_ACAD_YEAR2 key.
		///		FK_ED_STUD_VIOL_ED_ACAD_YEAR2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearStopToId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudViol> GetByEdAcadYearStopToId(TransactionManager transactionManager, System.Decimal? _edAcadYearStopToId)
		{
			int count = -1;
			return GetByEdAcadYearStopToId(transactionManager, _edAcadYearStopToId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_ACAD_YEAR2 key.
		///		FK_ED_STUD_VIOL_ED_ACAD_YEAR2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearStopToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdAcadYearStopToId(TransactionManager transactionManager, System.Decimal? _edAcadYearStopToId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearStopToId(transactionManager, _edAcadYearStopToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_ACAD_YEAR2 key.
		///		fkEdStudViolEdAcadYear2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearStopToId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdAcadYearStopToId(System.Decimal? _edAcadYearStopToId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearStopToId(null, _edAcadYearStopToId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_ACAD_YEAR2 key.
		///		fkEdStudViolEdAcadYear2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearStopToId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdAcadYearStopToId(System.Decimal? _edAcadYearStopToId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearStopToId(null, _edAcadYearStopToId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_ACAD_YEAR2 key.
		///		FK_ED_STUD_VIOL_ED_ACAD_YEAR2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearStopToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public abstract TList<EdStudViol> GetByEdAcadYearStopToId(TransactionManager transactionManager, System.Decimal? _edAcadYearStopToId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_VIOL_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_VIOL_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudViol> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_VIOL_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_CODE_SEMESTER key.
		///		fkEdStudViolEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_CODE_SEMESTER key.
		///		fkEdStudViolEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_VIOL_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public abstract TList<EdStudViol> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_CODE_SEMESTER1 key.
		///		FK_ED_STUD_VIOL_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="_edCodeSemesterStopFromId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdCodeSemesterStopFromId(System.Decimal? _edCodeSemesterStopFromId)
		{
			int count = -1;
			return GetByEdCodeSemesterStopFromId(_edCodeSemesterStopFromId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_CODE_SEMESTER1 key.
		///		FK_ED_STUD_VIOL_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterStopFromId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudViol> GetByEdCodeSemesterStopFromId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterStopFromId)
		{
			int count = -1;
			return GetByEdCodeSemesterStopFromId(transactionManager, _edCodeSemesterStopFromId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_CODE_SEMESTER1 key.
		///		FK_ED_STUD_VIOL_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterStopFromId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdCodeSemesterStopFromId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterStopFromId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterStopFromId(transactionManager, _edCodeSemesterStopFromId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_CODE_SEMESTER1 key.
		///		fkEdStudViolEdCodeSemester1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterStopFromId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdCodeSemesterStopFromId(System.Decimal? _edCodeSemesterStopFromId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterStopFromId(null, _edCodeSemesterStopFromId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_CODE_SEMESTER1 key.
		///		fkEdStudViolEdCodeSemester1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterStopFromId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdCodeSemesterStopFromId(System.Decimal? _edCodeSemesterStopFromId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterStopFromId(null, _edCodeSemesterStopFromId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_CODE_SEMESTER1 key.
		///		FK_ED_STUD_VIOL_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterStopFromId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public abstract TList<EdStudViol> GetByEdCodeSemesterStopFromId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterStopFromId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_CODE_SEMESTER2 key.
		///		FK_ED_STUD_VIOL_ED_CODE_SEMESTER2 Description: 
		/// </summary>
		/// <param name="_edCodeSemesterStopToId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdCodeSemesterStopToId(System.Decimal? _edCodeSemesterStopToId)
		{
			int count = -1;
			return GetByEdCodeSemesterStopToId(_edCodeSemesterStopToId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_CODE_SEMESTER2 key.
		///		FK_ED_STUD_VIOL_ED_CODE_SEMESTER2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterStopToId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudViol> GetByEdCodeSemesterStopToId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterStopToId)
		{
			int count = -1;
			return GetByEdCodeSemesterStopToId(transactionManager, _edCodeSemesterStopToId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_CODE_SEMESTER2 key.
		///		FK_ED_STUD_VIOL_ED_CODE_SEMESTER2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterStopToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdCodeSemesterStopToId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterStopToId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterStopToId(transactionManager, _edCodeSemesterStopToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_CODE_SEMESTER2 key.
		///		fkEdStudViolEdCodeSemester2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterStopToId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdCodeSemesterStopToId(System.Decimal? _edCodeSemesterStopToId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterStopToId(null, _edCodeSemesterStopToId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_CODE_SEMESTER2 key.
		///		fkEdStudViolEdCodeSemester2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterStopToId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdCodeSemesterStopToId(System.Decimal? _edCodeSemesterStopToId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterStopToId(null, _edCodeSemesterStopToId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_CODE_SEMESTER2 key.
		///		FK_ED_STUD_VIOL_ED_CODE_SEMESTER2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterStopToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public abstract TList<EdStudViol> GetByEdCodeSemesterStopToId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterStopToId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_STUD key.
		///		FK_ED_STUD_VIOL_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_STUD key.
		///		FK_ED_STUD_VIOL_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudViol> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_STUD key.
		///		FK_ED_STUD_VIOL_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_STUD key.
		///		fkEdStudViolEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_STUD key.
		///		fkEdStudViolEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_STUD key.
		///		FK_ED_STUD_VIOL_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public abstract TList<EdStudViol> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_STUD_CHEAT key.
		///		FK_ED_STUD_VIOL_ED_STUD_CHEAT Description: 
		/// </summary>
		/// <param name="_edStudCheatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdStudCheatId(System.Decimal? _edStudCheatId)
		{
			int count = -1;
			return GetByEdStudCheatId(_edStudCheatId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_STUD_CHEAT key.
		///		FK_ED_STUD_VIOL_ED_STUD_CHEAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCheatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudViol> GetByEdStudCheatId(TransactionManager transactionManager, System.Decimal? _edStudCheatId)
		{
			int count = -1;
			return GetByEdStudCheatId(transactionManager, _edStudCheatId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_STUD_CHEAT key.
		///		FK_ED_STUD_VIOL_ED_STUD_CHEAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCheatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdStudCheatId(TransactionManager transactionManager, System.Decimal? _edStudCheatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCheatId(transactionManager, _edStudCheatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_STUD_CHEAT key.
		///		fkEdStudViolEdStudCheat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCheatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdStudCheatId(System.Decimal? _edStudCheatId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudCheatId(null, _edStudCheatId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_STUD_CHEAT key.
		///		fkEdStudViolEdStudCheat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCheatId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByEdStudCheatId(System.Decimal? _edStudCheatId, int start, int pageLength,out int count)
		{
			return GetByEdStudCheatId(null, _edStudCheatId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ED_STUD_CHEAT key.
		///		FK_ED_STUD_VIOL_ED_STUD_CHEAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCheatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public abstract TList<EdStudViol> GetByEdStudCheatId(TransactionManager transactionManager, System.Decimal? _edStudCheatId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ERP_ORG_TREE key.
		///		FK_ED_STUD_VIOL_ERP_ORG_TREE Description: 
		/// </summary>
		/// <param name="_erpOrgTreeToId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByErpOrgTreeToId(System.Decimal? _erpOrgTreeToId)
		{
			int count = -1;
			return GetByErpOrgTreeToId(_erpOrgTreeToId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ERP_ORG_TREE key.
		///		FK_ED_STUD_VIOL_ERP_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeToId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudViol> GetByErpOrgTreeToId(TransactionManager transactionManager, System.Decimal? _erpOrgTreeToId)
		{
			int count = -1;
			return GetByErpOrgTreeToId(transactionManager, _erpOrgTreeToId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ERP_ORG_TREE key.
		///		FK_ED_STUD_VIOL_ERP_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByErpOrgTreeToId(TransactionManager transactionManager, System.Decimal? _erpOrgTreeToId, int start, int pageLength)
		{
			int count = -1;
			return GetByErpOrgTreeToId(transactionManager, _erpOrgTreeToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ERP_ORG_TREE key.
		///		fkEdStudViolErpOrgTree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_erpOrgTreeToId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByErpOrgTreeToId(System.Decimal? _erpOrgTreeToId, int start, int pageLength)
		{
			int count =  -1;
			return GetByErpOrgTreeToId(null, _erpOrgTreeToId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ERP_ORG_TREE key.
		///		fkEdStudViolErpOrgTree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_erpOrgTreeToId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByErpOrgTreeToId(System.Decimal? _erpOrgTreeToId, int start, int pageLength,out int count)
		{
			return GetByErpOrgTreeToId(null, _erpOrgTreeToId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ERP_ORG_TREE key.
		///		FK_ED_STUD_VIOL_ERP_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public abstract TList<EdStudViol> GetByErpOrgTreeToId(TransactionManager transactionManager, System.Decimal? _erpOrgTreeToId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ERP_ORG_TREE1 key.
		///		FK_ED_STUD_VIOL_ERP_ORG_TREE1 Description: 
		/// </summary>
		/// <param name="_erpOrgTreeFromId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByErpOrgTreeFromId(System.Decimal? _erpOrgTreeFromId)
		{
			int count = -1;
			return GetByErpOrgTreeFromId(_erpOrgTreeFromId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ERP_ORG_TREE1 key.
		///		FK_ED_STUD_VIOL_ERP_ORG_TREE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeFromId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudViol> GetByErpOrgTreeFromId(TransactionManager transactionManager, System.Decimal? _erpOrgTreeFromId)
		{
			int count = -1;
			return GetByErpOrgTreeFromId(transactionManager, _erpOrgTreeFromId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ERP_ORG_TREE1 key.
		///		FK_ED_STUD_VIOL_ERP_ORG_TREE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeFromId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByErpOrgTreeFromId(TransactionManager transactionManager, System.Decimal? _erpOrgTreeFromId, int start, int pageLength)
		{
			int count = -1;
			return GetByErpOrgTreeFromId(transactionManager, _erpOrgTreeFromId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ERP_ORG_TREE1 key.
		///		fkEdStudViolErpOrgTree1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_erpOrgTreeFromId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByErpOrgTreeFromId(System.Decimal? _erpOrgTreeFromId, int start, int pageLength)
		{
			int count =  -1;
			return GetByErpOrgTreeFromId(null, _erpOrgTreeFromId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ERP_ORG_TREE1 key.
		///		fkEdStudViolErpOrgTree1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_erpOrgTreeFromId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByErpOrgTreeFromId(System.Decimal? _erpOrgTreeFromId, int start, int pageLength,out int count)
		{
			return GetByErpOrgTreeFromId(null, _erpOrgTreeFromId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_ERP_ORG_TREE1 key.
		///		FK_ED_STUD_VIOL_ERP_ORG_TREE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeFromId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public abstract TList<EdStudViol> GetByErpOrgTreeFromId(TransactionManager transactionManager, System.Decimal? _erpOrgTreeFromId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_CAMPUS key.
		///		FK_ED_STUD_VIOL_GS_CDE_CAMPUS Description: 
		/// </summary>
		/// <param name="_gsCdeCampusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCdeCampusId(System.Decimal? _gsCdeCampusId)
		{
			int count = -1;
			return GetByGsCdeCampusId(_gsCdeCampusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_CAMPUS key.
		///		FK_ED_STUD_VIOL_GS_CDE_CAMPUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudViol> GetByGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _gsCdeCampusId)
		{
			int count = -1;
			return GetByGsCdeCampusId(transactionManager, _gsCdeCampusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_CAMPUS key.
		///		FK_ED_STUD_VIOL_GS_CDE_CAMPUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _gsCdeCampusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeCampusId(transactionManager, _gsCdeCampusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_CAMPUS key.
		///		fkEdStudViolGsCdeCampus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCdeCampusId(System.Decimal? _gsCdeCampusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeCampusId(null, _gsCdeCampusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_CAMPUS key.
		///		fkEdStudViolGsCdeCampus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCdeCampusId(System.Decimal? _gsCdeCampusId, int start, int pageLength,out int count)
		{
			return GetByGsCdeCampusId(null, _gsCdeCampusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_CAMPUS key.
		///		FK_ED_STUD_VIOL_GS_CDE_CAMPUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public abstract TList<EdStudViol> GetByGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _gsCdeCampusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_PENALTY key.
		///		FK_ED_STUD_VIOL_GS_CDE_PENALTY Description: 
		/// </summary>
		/// <param name="_gsCdePenaltyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCdePenaltyId(System.Decimal? _gsCdePenaltyId)
		{
			int count = -1;
			return GetByGsCdePenaltyId(_gsCdePenaltyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_PENALTY key.
		///		FK_ED_STUD_VIOL_GS_CDE_PENALTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudViol> GetByGsCdePenaltyId(TransactionManager transactionManager, System.Decimal? _gsCdePenaltyId)
		{
			int count = -1;
			return GetByGsCdePenaltyId(transactionManager, _gsCdePenaltyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_PENALTY key.
		///		FK_ED_STUD_VIOL_GS_CDE_PENALTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCdePenaltyId(TransactionManager transactionManager, System.Decimal? _gsCdePenaltyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdePenaltyId(transactionManager, _gsCdePenaltyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_PENALTY key.
		///		fkEdStudViolGsCdePenalty Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCdePenaltyId(System.Decimal? _gsCdePenaltyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdePenaltyId(null, _gsCdePenaltyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_PENALTY key.
		///		fkEdStudViolGsCdePenalty Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCdePenaltyId(System.Decimal? _gsCdePenaltyId, int start, int pageLength,out int count)
		{
			return GetByGsCdePenaltyId(null, _gsCdePenaltyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_PENALTY key.
		///		FK_ED_STUD_VIOL_GS_CDE_PENALTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public abstract TList<EdStudViol> GetByGsCdePenaltyId(TransactionManager transactionManager, System.Decimal? _gsCdePenaltyId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_VIOL key.
		///		FK_ED_STUD_VIOL_GS_CDE_VIOL Description: 
		/// </summary>
		/// <param name="_gsCdeViolId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCdeViolId(System.Decimal _gsCdeViolId)
		{
			int count = -1;
			return GetByGsCdeViolId(_gsCdeViolId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_VIOL key.
		///		FK_ED_STUD_VIOL_GS_CDE_VIOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudViol> GetByGsCdeViolId(TransactionManager transactionManager, System.Decimal _gsCdeViolId)
		{
			int count = -1;
			return GetByGsCdeViolId(transactionManager, _gsCdeViolId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_VIOL key.
		///		FK_ED_STUD_VIOL_GS_CDE_VIOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCdeViolId(TransactionManager transactionManager, System.Decimal _gsCdeViolId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeViolId(transactionManager, _gsCdeViolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_VIOL key.
		///		fkEdStudViolGsCdeViol Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeViolId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCdeViolId(System.Decimal _gsCdeViolId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeViolId(null, _gsCdeViolId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_VIOL key.
		///		fkEdStudViolGsCdeViol Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCdeViolId(System.Decimal _gsCdeViolId, int start, int pageLength,out int count)
		{
			return GetByGsCdeViolId(null, _gsCdeViolId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_VIOL key.
		///		FK_ED_STUD_VIOL_GS_CDE_VIOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public abstract TList<EdStudViol> GetByGsCdeViolId(TransactionManager transactionManager, System.Decimal _gsCdeViolId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_VIOL_CAT key.
		///		FK_ED_STUD_VIOL_GS_CDE_VIOL_CAT Description: 
		/// </summary>
		/// <param name="_gsCdeViolCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCdeViolCatId(System.Decimal _gsCdeViolCatId)
		{
			int count = -1;
			return GetByGsCdeViolCatId(_gsCdeViolCatId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_VIOL_CAT key.
		///		FK_ED_STUD_VIOL_GS_CDE_VIOL_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudViol> GetByGsCdeViolCatId(TransactionManager transactionManager, System.Decimal _gsCdeViolCatId)
		{
			int count = -1;
			return GetByGsCdeViolCatId(transactionManager, _gsCdeViolCatId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_VIOL_CAT key.
		///		FK_ED_STUD_VIOL_GS_CDE_VIOL_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCdeViolCatId(TransactionManager transactionManager, System.Decimal _gsCdeViolCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeViolCatId(transactionManager, _gsCdeViolCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_VIOL_CAT key.
		///		fkEdStudViolGsCdeViolCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCdeViolCatId(System.Decimal _gsCdeViolCatId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeViolCatId(null, _gsCdeViolCatId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_VIOL_CAT key.
		///		fkEdStudViolGsCdeViolCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCdeViolCatId(System.Decimal _gsCdeViolCatId, int start, int pageLength,out int count)
		{
			return GetByGsCdeViolCatId(null, _gsCdeViolCatId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CDE_VIOL_CAT key.
		///		FK_ED_STUD_VIOL_GS_CDE_VIOL_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public abstract TList<EdStudViol> GetByGsCdeViolCatId(TransactionManager transactionManager, System.Decimal _gsCdeViolCatId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CODE_APPROVAL key.
		///		FK_ED_STUD_VIOL_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="_gsCodeApprovalId">صلاحية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCodeApprovalId(System.Decimal? _gsCodeApprovalId)
		{
			int count = -1;
			return GetByGsCodeApprovalId(_gsCodeApprovalId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CODE_APPROVAL key.
		///		FK_ED_STUD_VIOL_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId">صلاحية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudViol> GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal? _gsCodeApprovalId)
		{
			int count = -1;
			return GetByGsCodeApprovalId(transactionManager, _gsCodeApprovalId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CODE_APPROVAL key.
		///		FK_ED_STUD_VIOL_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId">صلاحية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal? _gsCodeApprovalId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalId(transactionManager, _gsCodeApprovalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CODE_APPROVAL key.
		///		fkEdStudViolGsCodeApproval Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeApprovalId">صلاحية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCodeApprovalId(System.Decimal? _gsCodeApprovalId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeApprovalId(null, _gsCodeApprovalId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CODE_APPROVAL key.
		///		fkEdStudViolGsCodeApproval Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeApprovalId">صلاحية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByGsCodeApprovalId(System.Decimal? _gsCodeApprovalId, int start, int pageLength,out int count)
		{
			return GetByGsCodeApprovalId(null, _gsCodeApprovalId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_GS_CODE_APPROVAL key.
		///		FK_ED_STUD_VIOL_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId">صلاحية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public abstract TList<EdStudViol> GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal? _gsCodeApprovalId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_SC_BUILDING key.
		///		FK_ED_STUD_VIOL_SC_BUILDING Description: 
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByScBuildingId(System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(_scBuildingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_SC_BUILDING key.
		///		FK_ED_STUD_VIOL_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudViol> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_SC_BUILDING key.
		///		FK_ED_STUD_VIOL_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_SC_BUILDING key.
		///		fkEdStudViolScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScBuildingId(null, _scBuildingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_SC_BUILDING key.
		///		fkEdStudViolScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public TList<EdStudViol> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength,out int count)
		{
			return GetByScBuildingId(null, _scBuildingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_VIOL_SC_BUILDING key.
		///		FK_ED_STUD_VIOL_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudViol objects.</returns>
		public abstract TList<EdStudViol> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudViol Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudViolKey key, int start, int pageLength)
		{
			return GetByEdStudViolId(transactionManager, key.EdStudViolId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_VIOL index.
		/// </summary>
		/// <param name="_edStudViolId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViol GetByEdStudViolId(System.Decimal _edStudViolId)
		{
			int count = -1;
			return GetByEdStudViolId(null,_edStudViolId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_VIOL index.
		/// </summary>
		/// <param name="_edStudViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViol GetByEdStudViolId(System.Decimal _edStudViolId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudViolId(null, _edStudViolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_VIOL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViol GetByEdStudViolId(TransactionManager transactionManager, System.Decimal _edStudViolId)
		{
			int count = -1;
			return GetByEdStudViolId(transactionManager, _edStudViolId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_VIOL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViol GetByEdStudViolId(TransactionManager transactionManager, System.Decimal _edStudViolId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudViolId(transactionManager, _edStudViolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_VIOL index.
		/// </summary>
		/// <param name="_edStudViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViol GetByEdStudViolId(System.Decimal _edStudViolId, int start, int pageLength, out int count)
		{
			return GetByEdStudViolId(null, _edStudViolId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_VIOL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViol"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudViol GetByEdStudViolId(TransactionManager transactionManager, System.Decimal _edStudViolId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_VIOL index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_edStudCheatId"></param>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="_violDate"></param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViol GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEdStudCheatIdGsCdeViolIdViolDateGsCdeViolCatId(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edStudId, System.Decimal? _edStudCheatId, System.Decimal _gsCdeViolId, System.DateTime _violDate, System.Decimal _gsCdeViolCatId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEdStudCheatIdGsCdeViolIdViolDateGsCdeViolCatId(null,_edAcadYearId, _edCodeSemesterId, _edStudId, _edStudCheatId, _gsCdeViolId, _violDate, _gsCdeViolCatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_VIOL index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_edStudCheatId"></param>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="_violDate"></param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViol GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEdStudCheatIdGsCdeViolIdViolDateGsCdeViolCatId(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edStudId, System.Decimal? _edStudCheatId, System.Decimal _gsCdeViolId, System.DateTime _violDate, System.Decimal _gsCdeViolCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEdStudCheatIdGsCdeViolIdViolDateGsCdeViolCatId(null, _edAcadYearId, _edCodeSemesterId, _edStudId, _edStudCheatId, _gsCdeViolId, _violDate, _gsCdeViolCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_VIOL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_edStudCheatId"></param>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="_violDate"></param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViol GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEdStudCheatIdGsCdeViolIdViolDateGsCdeViolCatId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edStudId, System.Decimal? _edStudCheatId, System.Decimal _gsCdeViolId, System.DateTime _violDate, System.Decimal _gsCdeViolCatId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEdStudCheatIdGsCdeViolIdViolDateGsCdeViolCatId(transactionManager, _edAcadYearId, _edCodeSemesterId, _edStudId, _edStudCheatId, _gsCdeViolId, _violDate, _gsCdeViolCatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_VIOL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_edStudCheatId"></param>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="_violDate"></param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViol GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEdStudCheatIdGsCdeViolIdViolDateGsCdeViolCatId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edStudId, System.Decimal? _edStudCheatId, System.Decimal _gsCdeViolId, System.DateTime _violDate, System.Decimal _gsCdeViolCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEdStudCheatIdGsCdeViolIdViolDateGsCdeViolCatId(transactionManager, _edAcadYearId, _edCodeSemesterId, _edStudId, _edStudCheatId, _gsCdeViolId, _violDate, _gsCdeViolCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_VIOL index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_edStudCheatId"></param>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="_violDate"></param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudViol GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEdStudCheatIdGsCdeViolIdViolDateGsCdeViolCatId(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edStudId, System.Decimal? _edStudCheatId, System.Decimal _gsCdeViolId, System.DateTime _violDate, System.Decimal _gsCdeViolCatId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEdStudCheatIdGsCdeViolIdViolDateGsCdeViolCatId(null, _edAcadYearId, _edCodeSemesterId, _edStudId, _edStudCheatId, _gsCdeViolId, _violDate, _gsCdeViolCatId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_VIOL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_edStudCheatId"></param>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="_violDate"></param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudViol"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudViol GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEdStudCheatIdGsCdeViolIdViolDateGsCdeViolCatId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edStudId, System.Decimal? _edStudCheatId, System.Decimal _gsCdeViolId, System.DateTime _violDate, System.Decimal _gsCdeViolCatId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudViol&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudViol&gt;"/></returns>
		public static TList<EdStudViol> Fill(IDataReader reader, TList<EdStudViol> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudViol c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudViol")
					.Append("|").Append((System.Decimal)reader["ED_STUD_VIOL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudViol>(
					key.ToString(), // EntityTrackingKey
					"EdStudViol",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudViol();
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
					c.EdStudViolId = (System.Decimal)reader["ED_STUD_VIOL_ID"];
					c.OriginalEdStudViolId = c.EdStudViolId;
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.GsCdeCampusId = Convert.IsDBNull(reader["GS_CDE_CAMPUS_ID"]) ? null : (System.Decimal?)reader["GS_CDE_CAMPUS_ID"];
					c.ScBuildingId = Convert.IsDBNull(reader["SC_BUILDING_ID"]) ? null : (System.Decimal?)reader["SC_BUILDING_ID"];
					c.ViolDate = (System.DateTime)reader["VIOL_DATE"];
					c.GsCdeViolId = (System.Decimal)reader["GS_CDE_VIOL_ID"];
					c.GroupId = Convert.IsDBNull(reader["GROUP_ID"]) ? null : (System.Decimal?)reader["GROUP_ID"];
					c.GsCdePenaltyId = Convert.IsDBNull(reader["GS_CDE_PENALTY_ID"]) ? null : (System.Decimal?)reader["GS_CDE_PENALTY_ID"];
					c.PnltyDate = Convert.IsDBNull(reader["PNLTY_DATE"]) ? null : (System.DateTime?)reader["PNLTY_DATE"];
					c.ViolFrom = Convert.IsDBNull(reader["VIOL_FROM"]) ? null : (System.DateTime?)reader["VIOL_FROM"];
					c.ViolTo = Convert.IsDBNull(reader["VIOL_TO"]) ? null : (System.DateTime?)reader["VIOL_TO"];
					c.PnltyFrom = Convert.IsDBNull(reader["PNLTY_FROM"]) ? null : (System.DateTime?)reader["PNLTY_FROM"];
					c.PnltyTo = Convert.IsDBNull(reader["PNLTY_TO"]) ? null : (System.DateTime?)reader["PNLTY_TO"];
					c.BhvrMark = Convert.IsDBNull(reader["BHVR_MARK"]) ? null : (System.Decimal?)reader["BHVR_MARK"];
					c.AttndMark = Convert.IsDBNull(reader["ATTND_MARK"]) ? null : (System.Decimal?)reader["ATTND_MARK"];
					c.DropDate = Convert.IsDBNull(reader["DROP_DATE"]) ? null : (System.DateTime?)reader["DROP_DATE"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.ErpOrgTreeFromId = Convert.IsDBNull(reader["ERP_ORG_TREE_FROM_ID"]) ? null : (System.Decimal?)reader["ERP_ORG_TREE_FROM_ID"];
					c.ErpOrgTreeToId = Convert.IsDBNull(reader["ERP_ORG_TREE_TO_ID"]) ? null : (System.Decimal?)reader["ERP_ORG_TREE_TO_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.ViolSerial = Convert.IsDBNull(reader["VIOL_SERIAL"]) ? null : (System.Decimal?)reader["VIOL_SERIAL"];
					c.BanFee = Convert.IsDBNull(reader["BAN_FEE"]) ? null : (System.Decimal?)reader["BAN_FEE"];
					c.BanFeePayFlag = Convert.IsDBNull(reader["BAN_FEE_PAY_FLAG"]) ? null : (System.Decimal?)reader["BAN_FEE_PAY_FLAG"];
					c.DropFlg = (System.Decimal)reader["DROP_FLG"];
					c.EdCodeSemesterStopFromId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_STOP_FROM_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_STOP_FROM_ID"];
					c.EdAcadYearStopFromId = Convert.IsDBNull(reader["ED_ACAD_YEAR_STOP_FROM_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_STOP_FROM_ID"];
					c.EdCodeSemesterStopToId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_STOP_TO_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_STOP_TO_ID"];
					c.EdAcadYearStopToId = Convert.IsDBNull(reader["ED_ACAD_YEAR_STOP_TO_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_STOP_TO_ID"];
					c.AppealFlg = (System.Decimal)reader["APPEAL_FLG"];
					c.OtherFlag = Convert.IsDBNull(reader["OTHER_FLAG"]) ? null : (System.Decimal?)reader["OTHER_FLAG"];
					c.OtherSite = Convert.IsDBNull(reader["OTHER_SITE"]) ? null : (System.String)reader["OTHER_SITE"];
					c.GsCdeViolCatId = (System.Decimal)reader["GS_CDE_VIOL_CAT_ID"];
					c.InvestigationCommInOut = Convert.IsDBNull(reader["INVESTIGATION_COMM_IN_OUT"]) ? null : (System.Decimal?)reader["INVESTIGATION_COMM_IN_OUT"];
					c.InvestigationDate = Convert.IsDBNull(reader["INVESTIGATION_DATE"]) ? null : (System.DateTime?)reader["INVESTIGATION_DATE"];
					c.InvestigationEndDate = Convert.IsDBNull(reader["INVESTIGATION_END_DATE"]) ? null : (System.DateTime?)reader["INVESTIGATION_END_DATE"];
					c.InvestigationRecommendation = Convert.IsDBNull(reader["INVESTIGATION_RECOMMENDATION"]) ? null : (System.String)reader["INVESTIGATION_RECOMMENDATION"];
					c.ApprovedBy = Convert.IsDBNull(reader["APPROVED_BY"]) ? null : (System.Decimal?)reader["APPROVED_BY"];
					c.CancelFlg = Convert.IsDBNull(reader["CANCEL_FLG"]) ? null : (System.Decimal?)reader["CANCEL_FLG"];
					c.PunishCommFlg = Convert.IsDBNull(reader["PUNISH_COMM_FLG"]) ? null : (System.Decimal?)reader["PUNISH_COMM_FLG"];
					c.PunishCommDate = Convert.IsDBNull(reader["PUNISH_COMM_DATE"]) ? null : (System.DateTime?)reader["PUNISH_COMM_DATE"];
					c.PunishCommEndDate = Convert.IsDBNull(reader["PUNISH_COMM_END_DATE"]) ? null : (System.DateTime?)reader["PUNISH_COMM_END_DATE"];
					c.PenaltyRelatedFlg = Convert.IsDBNull(reader["PENALTY_RELATED_FLG"]) ? null : (System.Decimal?)reader["PENALTY_RELATED_FLG"];
					c.SemesterNo = Convert.IsDBNull(reader["SEMESTER_NO"]) ? null : (System.Decimal?)reader["SEMESTER_NO"];
					c.AbsenceFlg = Convert.IsDBNull(reader["ABSENCE_FLG"]) ? null : (System.Decimal?)reader["ABSENCE_FLG"];
					c.ExecFlg = Convert.IsDBNull(reader["EXEC_FLG"]) ? null : (System.Decimal?)reader["EXEC_FLG"];
					c.ExeFlgReg = Convert.IsDBNull(reader["EXE_FLG_REG"]) ? null : (System.Decimal?)reader["EXE_FLG_REG"];
					c.WarningNo = (System.Decimal)reader["WARNING_NO"];
					c.EdStudCheatId = Convert.IsDBNull(reader["ED_STUD_CHEAT_ID"]) ? null : (System.Decimal?)reader["ED_STUD_CHEAT_ID"];
					c.Witness = Convert.IsDBNull(reader["WITNESS"]) ? null : (System.String)reader["WITNESS"];
					c.GsCodeApprovalId = Convert.IsDBNull(reader["GS_CODE_APPROVAL_ID"]) ? null : (System.Decimal?)reader["GS_CODE_APPROVAL_ID"];
					c.ApprovedByName = Convert.IsDBNull(reader["APPROVED_BY_NAME"]) ? null : (System.String)reader["APPROVED_BY_NAME"];
					c.AttchdDocPath = Convert.IsDBNull(reader["ATTCHD_DOC_PATH"]) ? null : (System.String)reader["ATTCHD_DOC_PATH"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudViol"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudViol"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudViol entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudViolId = (System.Decimal)reader[((int)EdStudViolColumn.EdStudViolId - 1)];
			entity.OriginalEdStudViolId = (System.Decimal)reader["ED_STUD_VIOL_ID"];
			entity.EdStudId = (System.Decimal)reader[((int)EdStudViolColumn.EdStudId - 1)];
			entity.GsCdeCampusId = (reader.IsDBNull(((int)EdStudViolColumn.GsCdeCampusId - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.GsCdeCampusId - 1)];
			entity.ScBuildingId = (reader.IsDBNull(((int)EdStudViolColumn.ScBuildingId - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.ScBuildingId - 1)];
			entity.ViolDate = (System.DateTime)reader[((int)EdStudViolColumn.ViolDate - 1)];
			entity.GsCdeViolId = (System.Decimal)reader[((int)EdStudViolColumn.GsCdeViolId - 1)];
			entity.GroupId = (reader.IsDBNull(((int)EdStudViolColumn.GroupId - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.GroupId - 1)];
			entity.GsCdePenaltyId = (reader.IsDBNull(((int)EdStudViolColumn.GsCdePenaltyId - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.GsCdePenaltyId - 1)];
			entity.PnltyDate = (reader.IsDBNull(((int)EdStudViolColumn.PnltyDate - 1)))?null:(System.DateTime?)reader[((int)EdStudViolColumn.PnltyDate - 1)];
			entity.ViolFrom = (reader.IsDBNull(((int)EdStudViolColumn.ViolFrom - 1)))?null:(System.DateTime?)reader[((int)EdStudViolColumn.ViolFrom - 1)];
			entity.ViolTo = (reader.IsDBNull(((int)EdStudViolColumn.ViolTo - 1)))?null:(System.DateTime?)reader[((int)EdStudViolColumn.ViolTo - 1)];
			entity.PnltyFrom = (reader.IsDBNull(((int)EdStudViolColumn.PnltyFrom - 1)))?null:(System.DateTime?)reader[((int)EdStudViolColumn.PnltyFrom - 1)];
			entity.PnltyTo = (reader.IsDBNull(((int)EdStudViolColumn.PnltyTo - 1)))?null:(System.DateTime?)reader[((int)EdStudViolColumn.PnltyTo - 1)];
			entity.BhvrMark = (reader.IsDBNull(((int)EdStudViolColumn.BhvrMark - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.BhvrMark - 1)];
			entity.AttndMark = (reader.IsDBNull(((int)EdStudViolColumn.AttndMark - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.AttndMark - 1)];
			entity.DropDate = (reader.IsDBNull(((int)EdStudViolColumn.DropDate - 1)))?null:(System.DateTime?)reader[((int)EdStudViolColumn.DropDate - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdStudViolColumn.Notes - 1)))?null:(System.String)reader[((int)EdStudViolColumn.Notes - 1)];
			entity.ErpOrgTreeFromId = (reader.IsDBNull(((int)EdStudViolColumn.ErpOrgTreeFromId - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.ErpOrgTreeFromId - 1)];
			entity.ErpOrgTreeToId = (reader.IsDBNull(((int)EdStudViolColumn.ErpOrgTreeToId - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.ErpOrgTreeToId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)EdStudViolColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)EdStudViolColumn.EdCodeSemesterId - 1)];
			entity.ViolSerial = (reader.IsDBNull(((int)EdStudViolColumn.ViolSerial - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.ViolSerial - 1)];
			entity.BanFee = (reader.IsDBNull(((int)EdStudViolColumn.BanFee - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.BanFee - 1)];
			entity.BanFeePayFlag = (reader.IsDBNull(((int)EdStudViolColumn.BanFeePayFlag - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.BanFeePayFlag - 1)];
			entity.DropFlg = (System.Decimal)reader[((int)EdStudViolColumn.DropFlg - 1)];
			entity.EdCodeSemesterStopFromId = (reader.IsDBNull(((int)EdStudViolColumn.EdCodeSemesterStopFromId - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.EdCodeSemesterStopFromId - 1)];
			entity.EdAcadYearStopFromId = (reader.IsDBNull(((int)EdStudViolColumn.EdAcadYearStopFromId - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.EdAcadYearStopFromId - 1)];
			entity.EdCodeSemesterStopToId = (reader.IsDBNull(((int)EdStudViolColumn.EdCodeSemesterStopToId - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.EdCodeSemesterStopToId - 1)];
			entity.EdAcadYearStopToId = (reader.IsDBNull(((int)EdStudViolColumn.EdAcadYearStopToId - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.EdAcadYearStopToId - 1)];
			entity.AppealFlg = (System.Decimal)reader[((int)EdStudViolColumn.AppealFlg - 1)];
			entity.OtherFlag = (reader.IsDBNull(((int)EdStudViolColumn.OtherFlag - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.OtherFlag - 1)];
			entity.OtherSite = (reader.IsDBNull(((int)EdStudViolColumn.OtherSite - 1)))?null:(System.String)reader[((int)EdStudViolColumn.OtherSite - 1)];
			entity.GsCdeViolCatId = (System.Decimal)reader[((int)EdStudViolColumn.GsCdeViolCatId - 1)];
			entity.InvestigationCommInOut = (reader.IsDBNull(((int)EdStudViolColumn.InvestigationCommInOut - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.InvestigationCommInOut - 1)];
			entity.InvestigationDate = (reader.IsDBNull(((int)EdStudViolColumn.InvestigationDate - 1)))?null:(System.DateTime?)reader[((int)EdStudViolColumn.InvestigationDate - 1)];
			entity.InvestigationEndDate = (reader.IsDBNull(((int)EdStudViolColumn.InvestigationEndDate - 1)))?null:(System.DateTime?)reader[((int)EdStudViolColumn.InvestigationEndDate - 1)];
			entity.InvestigationRecommendation = (reader.IsDBNull(((int)EdStudViolColumn.InvestigationRecommendation - 1)))?null:(System.String)reader[((int)EdStudViolColumn.InvestigationRecommendation - 1)];
			entity.ApprovedBy = (reader.IsDBNull(((int)EdStudViolColumn.ApprovedBy - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.ApprovedBy - 1)];
			entity.CancelFlg = (reader.IsDBNull(((int)EdStudViolColumn.CancelFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.CancelFlg - 1)];
			entity.PunishCommFlg = (reader.IsDBNull(((int)EdStudViolColumn.PunishCommFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.PunishCommFlg - 1)];
			entity.PunishCommDate = (reader.IsDBNull(((int)EdStudViolColumn.PunishCommDate - 1)))?null:(System.DateTime?)reader[((int)EdStudViolColumn.PunishCommDate - 1)];
			entity.PunishCommEndDate = (reader.IsDBNull(((int)EdStudViolColumn.PunishCommEndDate - 1)))?null:(System.DateTime?)reader[((int)EdStudViolColumn.PunishCommEndDate - 1)];
			entity.PenaltyRelatedFlg = (reader.IsDBNull(((int)EdStudViolColumn.PenaltyRelatedFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.PenaltyRelatedFlg - 1)];
			entity.SemesterNo = (reader.IsDBNull(((int)EdStudViolColumn.SemesterNo - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.SemesterNo - 1)];
			entity.AbsenceFlg = (reader.IsDBNull(((int)EdStudViolColumn.AbsenceFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.AbsenceFlg - 1)];
			entity.ExecFlg = (reader.IsDBNull(((int)EdStudViolColumn.ExecFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.ExecFlg - 1)];
			entity.ExeFlgReg = (reader.IsDBNull(((int)EdStudViolColumn.ExeFlgReg - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.ExeFlgReg - 1)];
			entity.WarningNo = (System.Decimal)reader[((int)EdStudViolColumn.WarningNo - 1)];
			entity.EdStudCheatId = (reader.IsDBNull(((int)EdStudViolColumn.EdStudCheatId - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.EdStudCheatId - 1)];
			entity.Witness = (reader.IsDBNull(((int)EdStudViolColumn.Witness - 1)))?null:(System.String)reader[((int)EdStudViolColumn.Witness - 1)];
			entity.GsCodeApprovalId = (reader.IsDBNull(((int)EdStudViolColumn.GsCodeApprovalId - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.GsCodeApprovalId - 1)];
			entity.ApprovedByName = (reader.IsDBNull(((int)EdStudViolColumn.ApprovedByName - 1)))?null:(System.String)reader[((int)EdStudViolColumn.ApprovedByName - 1)];
			entity.AttchdDocPath = (reader.IsDBNull(((int)EdStudViolColumn.AttchdDocPath - 1)))?null:(System.String)reader[((int)EdStudViolColumn.AttchdDocPath - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudViolColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudViolColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudViolColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudViolColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudViol"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudViol"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudViol entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudViolId = (System.Decimal)dataRow["ED_STUD_VIOL_ID"];
			entity.OriginalEdStudViolId = (System.Decimal)dataRow["ED_STUD_VIOL_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.GsCdeCampusId = Convert.IsDBNull(dataRow["GS_CDE_CAMPUS_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_CAMPUS_ID"];
			entity.ScBuildingId = Convert.IsDBNull(dataRow["SC_BUILDING_ID"]) ? null : (System.Decimal?)dataRow["SC_BUILDING_ID"];
			entity.ViolDate = (System.DateTime)dataRow["VIOL_DATE"];
			entity.GsCdeViolId = (System.Decimal)dataRow["GS_CDE_VIOL_ID"];
			entity.GroupId = Convert.IsDBNull(dataRow["GROUP_ID"]) ? null : (System.Decimal?)dataRow["GROUP_ID"];
			entity.GsCdePenaltyId = Convert.IsDBNull(dataRow["GS_CDE_PENALTY_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_PENALTY_ID"];
			entity.PnltyDate = Convert.IsDBNull(dataRow["PNLTY_DATE"]) ? null : (System.DateTime?)dataRow["PNLTY_DATE"];
			entity.ViolFrom = Convert.IsDBNull(dataRow["VIOL_FROM"]) ? null : (System.DateTime?)dataRow["VIOL_FROM"];
			entity.ViolTo = Convert.IsDBNull(dataRow["VIOL_TO"]) ? null : (System.DateTime?)dataRow["VIOL_TO"];
			entity.PnltyFrom = Convert.IsDBNull(dataRow["PNLTY_FROM"]) ? null : (System.DateTime?)dataRow["PNLTY_FROM"];
			entity.PnltyTo = Convert.IsDBNull(dataRow["PNLTY_TO"]) ? null : (System.DateTime?)dataRow["PNLTY_TO"];
			entity.BhvrMark = Convert.IsDBNull(dataRow["BHVR_MARK"]) ? null : (System.Decimal?)dataRow["BHVR_MARK"];
			entity.AttndMark = Convert.IsDBNull(dataRow["ATTND_MARK"]) ? null : (System.Decimal?)dataRow["ATTND_MARK"];
			entity.DropDate = Convert.IsDBNull(dataRow["DROP_DATE"]) ? null : (System.DateTime?)dataRow["DROP_DATE"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.ErpOrgTreeFromId = Convert.IsDBNull(dataRow["ERP_ORG_TREE_FROM_ID"]) ? null : (System.Decimal?)dataRow["ERP_ORG_TREE_FROM_ID"];
			entity.ErpOrgTreeToId = Convert.IsDBNull(dataRow["ERP_ORG_TREE_TO_ID"]) ? null : (System.Decimal?)dataRow["ERP_ORG_TREE_TO_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.ViolSerial = Convert.IsDBNull(dataRow["VIOL_SERIAL"]) ? null : (System.Decimal?)dataRow["VIOL_SERIAL"];
			entity.BanFee = Convert.IsDBNull(dataRow["BAN_FEE"]) ? null : (System.Decimal?)dataRow["BAN_FEE"];
			entity.BanFeePayFlag = Convert.IsDBNull(dataRow["BAN_FEE_PAY_FLAG"]) ? null : (System.Decimal?)dataRow["BAN_FEE_PAY_FLAG"];
			entity.DropFlg = (System.Decimal)dataRow["DROP_FLG"];
			entity.EdCodeSemesterStopFromId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_STOP_FROM_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_STOP_FROM_ID"];
			entity.EdAcadYearStopFromId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_STOP_FROM_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_STOP_FROM_ID"];
			entity.EdCodeSemesterStopToId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_STOP_TO_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_STOP_TO_ID"];
			entity.EdAcadYearStopToId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_STOP_TO_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_STOP_TO_ID"];
			entity.AppealFlg = (System.Decimal)dataRow["APPEAL_FLG"];
			entity.OtherFlag = Convert.IsDBNull(dataRow["OTHER_FLAG"]) ? null : (System.Decimal?)dataRow["OTHER_FLAG"];
			entity.OtherSite = Convert.IsDBNull(dataRow["OTHER_SITE"]) ? null : (System.String)dataRow["OTHER_SITE"];
			entity.GsCdeViolCatId = (System.Decimal)dataRow["GS_CDE_VIOL_CAT_ID"];
			entity.InvestigationCommInOut = Convert.IsDBNull(dataRow["INVESTIGATION_COMM_IN_OUT"]) ? null : (System.Decimal?)dataRow["INVESTIGATION_COMM_IN_OUT"];
			entity.InvestigationDate = Convert.IsDBNull(dataRow["INVESTIGATION_DATE"]) ? null : (System.DateTime?)dataRow["INVESTIGATION_DATE"];
			entity.InvestigationEndDate = Convert.IsDBNull(dataRow["INVESTIGATION_END_DATE"]) ? null : (System.DateTime?)dataRow["INVESTIGATION_END_DATE"];
			entity.InvestigationRecommendation = Convert.IsDBNull(dataRow["INVESTIGATION_RECOMMENDATION"]) ? null : (System.String)dataRow["INVESTIGATION_RECOMMENDATION"];
			entity.ApprovedBy = Convert.IsDBNull(dataRow["APPROVED_BY"]) ? null : (System.Decimal?)dataRow["APPROVED_BY"];
			entity.CancelFlg = Convert.IsDBNull(dataRow["CANCEL_FLG"]) ? null : (System.Decimal?)dataRow["CANCEL_FLG"];
			entity.PunishCommFlg = Convert.IsDBNull(dataRow["PUNISH_COMM_FLG"]) ? null : (System.Decimal?)dataRow["PUNISH_COMM_FLG"];
			entity.PunishCommDate = Convert.IsDBNull(dataRow["PUNISH_COMM_DATE"]) ? null : (System.DateTime?)dataRow["PUNISH_COMM_DATE"];
			entity.PunishCommEndDate = Convert.IsDBNull(dataRow["PUNISH_COMM_END_DATE"]) ? null : (System.DateTime?)dataRow["PUNISH_COMM_END_DATE"];
			entity.PenaltyRelatedFlg = Convert.IsDBNull(dataRow["PENALTY_RELATED_FLG"]) ? null : (System.Decimal?)dataRow["PENALTY_RELATED_FLG"];
			entity.SemesterNo = Convert.IsDBNull(dataRow["SEMESTER_NO"]) ? null : (System.Decimal?)dataRow["SEMESTER_NO"];
			entity.AbsenceFlg = Convert.IsDBNull(dataRow["ABSENCE_FLG"]) ? null : (System.Decimal?)dataRow["ABSENCE_FLG"];
			entity.ExecFlg = Convert.IsDBNull(dataRow["EXEC_FLG"]) ? null : (System.Decimal?)dataRow["EXEC_FLG"];
			entity.ExeFlgReg = Convert.IsDBNull(dataRow["EXE_FLG_REG"]) ? null : (System.Decimal?)dataRow["EXE_FLG_REG"];
			entity.WarningNo = (System.Decimal)dataRow["WARNING_NO"];
			entity.EdStudCheatId = Convert.IsDBNull(dataRow["ED_STUD_CHEAT_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_CHEAT_ID"];
			entity.Witness = Convert.IsDBNull(dataRow["WITNESS"]) ? null : (System.String)dataRow["WITNESS"];
			entity.GsCodeApprovalId = Convert.IsDBNull(dataRow["GS_CODE_APPROVAL_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_APPROVAL_ID"];
			entity.ApprovedByName = Convert.IsDBNull(dataRow["APPROVED_BY_NAME"]) ? null : (System.String)dataRow["APPROVED_BY_NAME"];
			entity.AttchdDocPath = Convert.IsDBNull(dataRow["ATTCHD_DOC_PATH"]) ? null : (System.String)dataRow["ATTCHD_DOC_PATH"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudViol"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudViol Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudViol entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdAcadYearStopFromIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearStopFromIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearStopFromIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearStopFromId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearStopFromIdSource = tmpEntity;
				else
					entity.EdAcadYearStopFromIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearStopFromId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearStopFromIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearStopFromIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearStopFromIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearStopFromIdSource

			#region EdAcadYearStopToIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearStopToIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearStopToIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearStopToId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearStopToIdSource = tmpEntity;
				else
					entity.EdAcadYearStopToIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearStopToId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearStopToIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearStopToIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearStopToIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearStopToIdSource

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

			#region EdCodeSemesterStopFromIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterStopFromIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterStopFromIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemesterStopFromId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterStopFromIdSource = tmpEntity;
				else
					entity.EdCodeSemesterStopFromIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterStopFromId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterStopFromIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterStopFromIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdCodeSemesterStopFromIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterStopFromIdSource

			#region EdCodeSemesterStopToIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterStopToIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterStopToIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemesterStopToId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterStopToIdSource = tmpEntity;
				else
					entity.EdCodeSemesterStopToIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterStopToId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterStopToIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterStopToIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdCodeSemesterStopToIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterStopToIdSource

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

			#region EdStudCheatIdSource	
			if (CanDeepLoad(entity, "EdStudCheat|EdStudCheatIdSource", deepLoadType, innerList) 
				&& entity.EdStudCheatIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudCheatId ?? 0.0m);
				EdStudCheat tmpEntity = EntityManager.LocateEntity<EdStudCheat>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudCheat), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudCheatIdSource = tmpEntity;
				else
					entity.EdStudCheatIdSource = DataRepository.EdStudCheatProvider.GetByEdStudCheatId(transactionManager, (entity.EdStudCheatId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCheatIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudCheatIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudCheatProvider.DeepLoad(transactionManager, entity.EdStudCheatIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudCheatIdSource

			#region ErpOrgTreeToIdSource	
			if (CanDeepLoad(entity, "ErpOrgTree|ErpOrgTreeToIdSource", deepLoadType, innerList) 
				&& entity.ErpOrgTreeToIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ErpOrgTreeToId ?? 0.0m);
				ErpOrgTree tmpEntity = EntityManager.LocateEntity<ErpOrgTree>(EntityLocator.ConstructKeyFromPkItems(typeof(ErpOrgTree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ErpOrgTreeToIdSource = tmpEntity;
				else
					entity.ErpOrgTreeToIdSource = DataRepository.ErpOrgTreeProvider.GetByErpOrgTreeId(transactionManager, (entity.ErpOrgTreeToId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ErpOrgTreeToIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ErpOrgTreeToIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ErpOrgTreeProvider.DeepLoad(transactionManager, entity.ErpOrgTreeToIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ErpOrgTreeToIdSource

			#region ErpOrgTreeFromIdSource	
			if (CanDeepLoad(entity, "ErpOrgTree|ErpOrgTreeFromIdSource", deepLoadType, innerList) 
				&& entity.ErpOrgTreeFromIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ErpOrgTreeFromId ?? 0.0m);
				ErpOrgTree tmpEntity = EntityManager.LocateEntity<ErpOrgTree>(EntityLocator.ConstructKeyFromPkItems(typeof(ErpOrgTree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ErpOrgTreeFromIdSource = tmpEntity;
				else
					entity.ErpOrgTreeFromIdSource = DataRepository.ErpOrgTreeProvider.GetByErpOrgTreeId(transactionManager, (entity.ErpOrgTreeFromId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ErpOrgTreeFromIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ErpOrgTreeFromIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ErpOrgTreeProvider.DeepLoad(transactionManager, entity.ErpOrgTreeFromIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ErpOrgTreeFromIdSource

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

			#region GsCdePenaltyIdSource	
			if (CanDeepLoad(entity, "GsCdePenalty|GsCdePenaltyIdSource", deepLoadType, innerList) 
				&& entity.GsCdePenaltyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdePenaltyId ?? 0.0m);
				GsCdePenalty tmpEntity = EntityManager.LocateEntity<GsCdePenalty>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdePenalty), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdePenaltyIdSource = tmpEntity;
				else
					entity.GsCdePenaltyIdSource = DataRepository.GsCdePenaltyProvider.GetByGsCdePenaltyId(transactionManager, (entity.GsCdePenaltyId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdePenaltyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdePenaltyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdePenaltyProvider.DeepLoad(transactionManager, entity.GsCdePenaltyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdePenaltyIdSource

			#region GsCdeViolIdSource	
			if (CanDeepLoad(entity, "GsCdeViol|GsCdeViolIdSource", deepLoadType, innerList) 
				&& entity.GsCdeViolIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCdeViolId;
				GsCdeViol tmpEntity = EntityManager.LocateEntity<GsCdeViol>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeViol), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeViolIdSource = tmpEntity;
				else
					entity.GsCdeViolIdSource = DataRepository.GsCdeViolProvider.GetByGsCdeViolId(transactionManager, entity.GsCdeViolId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeViolIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeViolIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeViolProvider.DeepLoad(transactionManager, entity.GsCdeViolIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeViolIdSource

			#region GsCdeViolCatIdSource	
			if (CanDeepLoad(entity, "GsCdeViolCat|GsCdeViolCatIdSource", deepLoadType, innerList) 
				&& entity.GsCdeViolCatIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCdeViolCatId;
				GsCdeViolCat tmpEntity = EntityManager.LocateEntity<GsCdeViolCat>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeViolCat), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeViolCatIdSource = tmpEntity;
				else
					entity.GsCdeViolCatIdSource = DataRepository.GsCdeViolCatProvider.GetByGsCdeViolCatId(transactionManager, entity.GsCdeViolCatId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeViolCatIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeViolCatIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeViolCatProvider.DeepLoad(transactionManager, entity.GsCdeViolCatIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeViolCatIdSource

			#region GsCodeApprovalIdSource	
			if (CanDeepLoad(entity, "GsCodeApproval|GsCodeApprovalIdSource", deepLoadType, innerList) 
				&& entity.GsCodeApprovalIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeApprovalId ?? 0.0m);
				GsCodeApproval tmpEntity = EntityManager.LocateEntity<GsCodeApproval>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeApproval), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeApprovalIdSource = tmpEntity;
				else
					entity.GsCodeApprovalIdSource = DataRepository.GsCodeApprovalProvider.GetByGsCodeApprovalId(transactionManager, (entity.GsCodeApprovalId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeApprovalIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeApprovalProvider.DeepLoad(transactionManager, entity.GsCodeApprovalIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeApprovalIdSource

			#region ScBuildingIdSource	
			if (CanDeepLoad(entity, "ScBuilding|ScBuildingIdSource", deepLoadType, innerList) 
				&& entity.ScBuildingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScBuildingId ?? 0.0m);
				ScBuilding tmpEntity = EntityManager.LocateEntity<ScBuilding>(EntityLocator.ConstructKeyFromPkItems(typeof(ScBuilding), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScBuildingIdSource = tmpEntity;
				else
					entity.ScBuildingIdSource = DataRepository.ScBuildingProvider.GetByScBuildingId(transactionManager, (entity.ScBuildingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScBuildingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScBuildingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScBuildingProvider.DeepLoad(transactionManager, entity.ScBuildingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScBuildingIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdStudViolId methods when available
			
			#region EdStudViolAppeal
			// RelationshipType.OneToOne
			if (CanDeepLoad(entity, "EdStudViolAppeal|EdStudViolAppeal", deepLoadType, innerList))
			{
				entity.EdStudViolAppeal = DataRepository.EdStudViolAppealProvider.GetByEdStudViolId(transactionManager, entity.EdStudViolId);
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolAppeal' loaded. key " + entity.EntityTrackingKey);
				#endif 

				if (deep && entity.EdStudViolAppeal != null)
				{
					deepHandles.Add("EdStudViolAppeal",
						new KeyValuePair<Delegate, object>((DeepLoadSingleHandle< EdStudViolAppeal >) DataRepository.EdStudViolAppealProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudViolAppeal, deep, deepLoadType, childTypes, innerList }
					));
				}
			}
			#endregion 
			
			
			
			#region MltStudBhvrAttndcCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltStudBhvrAttndc>|MltStudBhvrAttndcCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltStudBhvrAttndcCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltStudBhvrAttndcCollection = DataRepository.MltStudBhvrAttndcProvider.GetByEdStudViolId(transactionManager, entity.EdStudViolId);

				if (deep && entity.MltStudBhvrAttndcCollection.Count > 0)
				{
					deepHandles.Add("MltStudBhvrAttndcCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltStudBhvrAttndc>) DataRepository.MltStudBhvrAttndcProvider.DeepLoad,
						new object[] { transactionManager, entity.MltStudBhvrAttndcCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsAttchdDocCollectionGetByEdStudViolId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAttchdDoc>|GsAttchdDocCollectionGetByEdStudViolId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAttchdDocCollectionGetByEdStudViolId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAttchdDocCollectionGetByEdStudViolId = DataRepository.GsAttchdDocProvider.GetByEdStudViolId(transactionManager, entity.EdStudViolId);

				if (deep && entity.GsAttchdDocCollectionGetByEdStudViolId.Count > 0)
				{
					deepHandles.Add("GsAttchdDocCollectionGetByEdStudViolId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAttchdDoc>) DataRepository.GsAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAttchdDocCollectionGetByEdStudViolId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsAttchdDocCollectionGetByEdStudViolInvestId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAttchdDoc>|GsAttchdDocCollectionGetByEdStudViolInvestId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAttchdDocCollectionGetByEdStudViolInvestId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAttchdDocCollectionGetByEdStudViolInvestId = DataRepository.GsAttchdDocProvider.GetByEdStudViolInvestId(transactionManager, entity.EdStudViolId);

				if (deep && entity.GsAttchdDocCollectionGetByEdStudViolInvestId.Count > 0)
				{
					deepHandles.Add("GsAttchdDocCollectionGetByEdStudViolInvestId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAttchdDoc>) DataRepository.GsAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAttchdDocCollectionGetByEdStudViolInvestId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudPnltyCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudPnltyCourse>|EdStudPnltyCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudPnltyCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudPnltyCourseCollection = DataRepository.EdStudPnltyCourseProvider.GetByEdStudViolId(transactionManager, entity.EdStudViolId);

				if (deep && entity.EdStudPnltyCourseCollection.Count > 0)
				{
					deepHandles.Add("EdStudPnltyCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudPnltyCourse>) DataRepository.EdStudPnltyCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudPnltyCourseCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudViol object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudViol instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudViol Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudViol entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdAcadYearStopFromIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearStopFromIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearStopFromIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearStopFromIdSource);
				entity.EdAcadYearStopFromId = entity.EdAcadYearStopFromIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EdAcadYearStopToIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearStopToIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearStopToIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearStopToIdSource);
				entity.EdAcadYearStopToId = entity.EdAcadYearStopToIdSource.EdAcadYearId;
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
			
			#region EdCodeSemesterStopFromIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterStopFromIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterStopFromIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterStopFromIdSource);
				entity.EdCodeSemesterStopFromId = entity.EdCodeSemesterStopFromIdSource.EdCodeSemesterId;
			}
			#endregion 
			
			#region EdCodeSemesterStopToIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterStopToIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterStopToIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterStopToIdSource);
				entity.EdCodeSemesterStopToId = entity.EdCodeSemesterStopToIdSource.EdCodeSemesterId;
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
			
			#region EdStudCheatIdSource
			if (CanDeepSave(entity, "EdStudCheat|EdStudCheatIdSource", deepSaveType, innerList) 
				&& entity.EdStudCheatIdSource != null)
			{
				DataRepository.EdStudCheatProvider.Save(transactionManager, entity.EdStudCheatIdSource);
				entity.EdStudCheatId = entity.EdStudCheatIdSource.EdStudCheatId;
			}
			#endregion 
			
			#region ErpOrgTreeToIdSource
			if (CanDeepSave(entity, "ErpOrgTree|ErpOrgTreeToIdSource", deepSaveType, innerList) 
				&& entity.ErpOrgTreeToIdSource != null)
			{
				DataRepository.ErpOrgTreeProvider.Save(transactionManager, entity.ErpOrgTreeToIdSource);
				entity.ErpOrgTreeToId = entity.ErpOrgTreeToIdSource.ErpOrgTreeId;
			}
			#endregion 
			
			#region ErpOrgTreeFromIdSource
			if (CanDeepSave(entity, "ErpOrgTree|ErpOrgTreeFromIdSource", deepSaveType, innerList) 
				&& entity.ErpOrgTreeFromIdSource != null)
			{
				DataRepository.ErpOrgTreeProvider.Save(transactionManager, entity.ErpOrgTreeFromIdSource);
				entity.ErpOrgTreeFromId = entity.ErpOrgTreeFromIdSource.ErpOrgTreeId;
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
			
			#region GsCdePenaltyIdSource
			if (CanDeepSave(entity, "GsCdePenalty|GsCdePenaltyIdSource", deepSaveType, innerList) 
				&& entity.GsCdePenaltyIdSource != null)
			{
				DataRepository.GsCdePenaltyProvider.Save(transactionManager, entity.GsCdePenaltyIdSource);
				entity.GsCdePenaltyId = entity.GsCdePenaltyIdSource.GsCdePenaltyId;
			}
			#endregion 
			
			#region GsCdeViolIdSource
			if (CanDeepSave(entity, "GsCdeViol|GsCdeViolIdSource", deepSaveType, innerList) 
				&& entity.GsCdeViolIdSource != null)
			{
				DataRepository.GsCdeViolProvider.Save(transactionManager, entity.GsCdeViolIdSource);
				entity.GsCdeViolId = entity.GsCdeViolIdSource.GsCdeViolId;
			}
			#endregion 
			
			#region GsCdeViolCatIdSource
			if (CanDeepSave(entity, "GsCdeViolCat|GsCdeViolCatIdSource", deepSaveType, innerList) 
				&& entity.GsCdeViolCatIdSource != null)
			{
				DataRepository.GsCdeViolCatProvider.Save(transactionManager, entity.GsCdeViolCatIdSource);
				entity.GsCdeViolCatId = entity.GsCdeViolCatIdSource.GsCdeViolCatId;
			}
			#endregion 
			
			#region GsCodeApprovalIdSource
			if (CanDeepSave(entity, "GsCodeApproval|GsCodeApprovalIdSource", deepSaveType, innerList) 
				&& entity.GsCodeApprovalIdSource != null)
			{
				DataRepository.GsCodeApprovalProvider.Save(transactionManager, entity.GsCodeApprovalIdSource);
				entity.GsCodeApprovalId = entity.GsCodeApprovalIdSource.GsCodeApprovalId;
			}
			#endregion 
			
			#region ScBuildingIdSource
			if (CanDeepSave(entity, "ScBuilding|ScBuildingIdSource", deepSaveType, innerList) 
				&& entity.ScBuildingIdSource != null)
			{
				DataRepository.ScBuildingProvider.Save(transactionManager, entity.ScBuildingIdSource);
				entity.ScBuildingId = entity.ScBuildingIdSource.ScBuildingId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();

			#region EdStudViolAppeal
			if (CanDeepSave(entity.EdStudViolAppeal, "EdStudViolAppeal|EdStudViolAppeal", deepSaveType, innerList))
			{

				if (entity.EdStudViolAppeal != null)
				{
					// update each child parent id with the real parent id (mostly used on insert)

					entity.EdStudViolAppeal.EdStudViolId = entity.EdStudViolId;
					//DataRepository.EdStudViolAppealProvider.Save(transactionManager, entity.EdStudViolAppeal);
					deepHandles.Add("EdStudViolAppeal",
						new KeyValuePair<Delegate, object>((DeepSaveSingleHandle< EdStudViolAppeal >) DataRepository.EdStudViolAppealProvider.DeepSave,
						new object[] { transactionManager, entity.EdStudViolAppeal, deepSaveType, childTypes, innerList }
					));
				}
			} 
			#endregion 
	
			#region List<MltStudBhvrAttndc>
				if (CanDeepSave(entity.MltStudBhvrAttndcCollection, "List<MltStudBhvrAttndc>|MltStudBhvrAttndcCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltStudBhvrAttndc child in entity.MltStudBhvrAttndcCollection)
					{
						if(child.EdStudViolIdSource != null)
						{
							child.EdStudViolId = child.EdStudViolIdSource.EdStudViolId;
						}
						else
						{
							child.EdStudViolId = entity.EdStudViolId;
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
				
	
			#region List<GsAttchdDoc>
				if (CanDeepSave(entity.GsAttchdDocCollectionGetByEdStudViolId, "List<GsAttchdDoc>|GsAttchdDocCollectionGetByEdStudViolId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAttchdDoc child in entity.GsAttchdDocCollectionGetByEdStudViolId)
					{
						if(child.EdStudViolIdSource != null)
						{
							child.EdStudViolId = child.EdStudViolIdSource.EdStudViolId;
						}
						else
						{
							child.EdStudViolId = entity.EdStudViolId;
						}

					}

					if (entity.GsAttchdDocCollectionGetByEdStudViolId.Count > 0 || entity.GsAttchdDocCollectionGetByEdStudViolId.DeletedItems.Count > 0)
					{
						//DataRepository.GsAttchdDocProvider.Save(transactionManager, entity.GsAttchdDocCollectionGetByEdStudViolId);
						
						deepHandles.Add("GsAttchdDocCollectionGetByEdStudViolId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsAttchdDoc >) DataRepository.GsAttchdDocProvider.DeepSave,
							new object[] { transactionManager, entity.GsAttchdDocCollectionGetByEdStudViolId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsAttchdDoc>
				if (CanDeepSave(entity.GsAttchdDocCollectionGetByEdStudViolInvestId, "List<GsAttchdDoc>|GsAttchdDocCollectionGetByEdStudViolInvestId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAttchdDoc child in entity.GsAttchdDocCollectionGetByEdStudViolInvestId)
					{
						if(child.EdStudViolInvestIdSource != null)
						{
							child.EdStudViolInvestId = child.EdStudViolInvestIdSource.EdStudViolId;
						}
						else
						{
							child.EdStudViolInvestId = entity.EdStudViolId;
						}

					}

					if (entity.GsAttchdDocCollectionGetByEdStudViolInvestId.Count > 0 || entity.GsAttchdDocCollectionGetByEdStudViolInvestId.DeletedItems.Count > 0)
					{
						//DataRepository.GsAttchdDocProvider.Save(transactionManager, entity.GsAttchdDocCollectionGetByEdStudViolInvestId);
						
						deepHandles.Add("GsAttchdDocCollectionGetByEdStudViolInvestId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsAttchdDoc >) DataRepository.GsAttchdDocProvider.DeepSave,
							new object[] { transactionManager, entity.GsAttchdDocCollectionGetByEdStudViolInvestId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudPnltyCourse>
				if (CanDeepSave(entity.EdStudPnltyCourseCollection, "List<EdStudPnltyCourse>|EdStudPnltyCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudPnltyCourse child in entity.EdStudPnltyCourseCollection)
					{
						if(child.EdStudViolIdSource != null)
						{
							child.EdStudViolId = child.EdStudViolIdSource.EdStudViolId;
						}
						else
						{
							child.EdStudViolId = entity.EdStudViolId;
						}

					}

					if (entity.EdStudPnltyCourseCollection.Count > 0 || entity.EdStudPnltyCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudPnltyCourseProvider.Save(transactionManager, entity.EdStudPnltyCourseCollection);
						
						deepHandles.Add("EdStudPnltyCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudPnltyCourse >) DataRepository.EdStudPnltyCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudPnltyCourseCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdStudViolChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudViol</c>
	///</summary>
	public enum EdStudViolChildEntityTypes
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
		/// Composite Property for <c>EdStudCheat</c> at EdStudCheatIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudCheat))]
		EdStudCheat,
		
		///<summary>
		/// Composite Property for <c>ErpOrgTree</c> at ErpOrgTreeToIdSource
		///</summary>
		[ChildEntityType(typeof(ErpOrgTree))]
		ErpOrgTree,
		
		///<summary>
		/// Composite Property for <c>GsCdeCampus</c> at GsCdeCampusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeCampus))]
		GsCdeCampus,
		
		///<summary>
		/// Composite Property for <c>GsCdePenalty</c> at GsCdePenaltyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdePenalty))]
		GsCdePenalty,
		
		///<summary>
		/// Composite Property for <c>GsCdeViol</c> at GsCdeViolIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeViol))]
		GsCdeViol,
		
		///<summary>
		/// Composite Property for <c>GsCdeViolCat</c> at GsCdeViolCatIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeViolCat))]
		GsCdeViolCat,
		
		///<summary>
		/// Composite Property for <c>GsCodeApproval</c> at GsCodeApprovalIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeApproval))]
		GsCodeApproval,
		
		///<summary>
		/// Composite Property for <c>ScBuilding</c> at ScBuildingIdSource
		///</summary>
		[ChildEntityType(typeof(ScBuilding))]
		ScBuilding,
		///<summary>
		/// Entity <c>EdStudViolAppeal</c> as OneToOne for EdStudViolAppeal
		///</summary>
		[ChildEntityType(typeof(EdStudViolAppeal))]
		EdStudViolAppeal,
		///<summary>
		/// Collection of <c>EdStudViol</c> as OneToMany for MltStudBhvrAttndcCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltStudBhvrAttndc>))]
		MltStudBhvrAttndcCollection,
		///<summary>
		/// Collection of <c>EdStudViol</c> as OneToMany for GsAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAttchdDoc>))]
		GsAttchdDocCollectionGetByEdStudViolId,
		///<summary>
		/// Collection of <c>EdStudViol</c> as OneToMany for GsAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAttchdDoc>))]
		GsAttchdDocCollectionGetByEdStudViolInvestId,
		///<summary>
		/// Collection of <c>EdStudViol</c> as OneToMany for EdStudPnltyCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudPnltyCourse>))]
		EdStudPnltyCourseCollection,
	}
	
	#endregion EdStudViolChildEntityTypes
	
	#region EdStudViolFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudViolColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudViol"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudViolFilterBuilder : SqlFilterBuilder<EdStudViolColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudViolFilterBuilder class.
		/// </summary>
		public EdStudViolFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudViolFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudViolFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudViolFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudViolFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudViolFilterBuilder
	
	#region EdStudViolParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudViolColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudViol"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudViolParameterBuilder : ParameterizedSqlFilterBuilder<EdStudViolColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudViolParameterBuilder class.
		/// </summary>
		public EdStudViolParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudViolParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudViolParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudViolParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudViolParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudViolParameterBuilder
	
	#region EdStudViolSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudViolColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudViol"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudViolSortBuilder : SqlSortBuilder<EdStudViolColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudViolSqlSortBuilder class.
		/// </summary>
		public EdStudViolSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudViolSortBuilder
	
} // end namespace
