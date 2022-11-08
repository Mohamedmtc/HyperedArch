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
	/// This class is the base class for any <see cref="EdSemesterOpenProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdSemesterOpenProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdSemesterOpen, UMIS_VER2.BusinessLyer.EdSemesterOpenKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemesterOpenKey key)
		{
			return Delete(transactionManager, key.EdSemesterOpenId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edSemesterOpenId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edSemesterOpenId)
		{
			return Delete(null, _edSemesterOpenId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterOpenId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edSemesterOpenId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_OPEN_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_SEMESTER_OPEN_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterOpen objects.</returns>
		public TList<EdSemesterOpen> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_OPEN_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_SEMESTER_OPEN_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterOpen objects.</returns>
		/// <remarks></remarks>
		public TList<EdSemesterOpen> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_OPEN_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_SEMESTER_OPEN_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterOpen objects.</returns>
		public TList<EdSemesterOpen> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_OPEN_AS_CODE_DEGREE_CLASS key.
		///		fkEdSemesterOpenAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterOpen objects.</returns>
		public TList<EdSemesterOpen> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_OPEN_AS_CODE_DEGREE_CLASS key.
		///		fkEdSemesterOpenAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterOpen objects.</returns>
		public TList<EdSemesterOpen> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_OPEN_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_SEMESTER_OPEN_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterOpen objects.</returns>
		public abstract TList<EdSemesterOpen> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_OPEN_ED_CODE_LEVEL key.
		///		FK_ED_SEMESTER_OPEN_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterOpen objects.</returns>
		public TList<EdSemesterOpen> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(_edCodeLevelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_OPEN_ED_CODE_LEVEL key.
		///		FK_ED_SEMESTER_OPEN_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterOpen objects.</returns>
		/// <remarks></remarks>
		public TList<EdSemesterOpen> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_OPEN_ED_CODE_LEVEL key.
		///		FK_ED_SEMESTER_OPEN_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterOpen objects.</returns>
		public TList<EdSemesterOpen> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_OPEN_ED_CODE_LEVEL key.
		///		fkEdSemesterOpenEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterOpen objects.</returns>
		public TList<EdSemesterOpen> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_OPEN_ED_CODE_LEVEL key.
		///		fkEdSemesterOpenEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterOpen objects.</returns>
		public TList<EdSemesterOpen> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_OPEN_ED_CODE_LEVEL key.
		///		FK_ED_SEMESTER_OPEN_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterOpen objects.</returns>
		public abstract TList<EdSemesterOpen> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_OPEN_ED_CODE_STUDY_METHOD key.
		///		FK_ED_SEMESTER_OPEN_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterOpen objects.</returns>
		public TList<EdSemesterOpen> GetByEdCodeStudyMethodId(System.Decimal? _edCodeStudyMethodId)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(_edCodeStudyMethodId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_OPEN_ED_CODE_STUDY_METHOD key.
		///		FK_ED_SEMESTER_OPEN_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterOpen objects.</returns>
		/// <remarks></remarks>
		public TList<EdSemesterOpen> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(transactionManager, _edCodeStudyMethodId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_OPEN_ED_CODE_STUDY_METHOD key.
		///		FK_ED_SEMESTER_OPEN_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterOpen objects.</returns>
		public TList<EdSemesterOpen> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(transactionManager, _edCodeStudyMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_OPEN_ED_CODE_STUDY_METHOD key.
		///		fkEdSemesterOpenEdCodeStudyMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterOpen objects.</returns>
		public TList<EdSemesterOpen> GetByEdCodeStudyMethodId(System.Decimal? _edCodeStudyMethodId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeStudyMethodId(null, _edCodeStudyMethodId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_OPEN_ED_CODE_STUDY_METHOD key.
		///		fkEdSemesterOpenEdCodeStudyMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterOpen objects.</returns>
		public TList<EdSemesterOpen> GetByEdCodeStudyMethodId(System.Decimal? _edCodeStudyMethodId, int start, int pageLength,out int count)
		{
			return GetByEdCodeStudyMethodId(null, _edCodeStudyMethodId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_OPEN_ED_CODE_STUDY_METHOD key.
		///		FK_ED_SEMESTER_OPEN_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterOpen objects.</returns>
		public abstract TList<EdSemesterOpen> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdSemesterOpen Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemesterOpenKey key, int start, int pageLength)
		{
			return GetByEdSemesterOpenId(transactionManager, key.EdSemesterOpenId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEdAcadYearId(System.Decimal _edAcadYearId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public abstract TList<EdSemesterOpen> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public abstract TList<EdSemesterOpen> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_SEMESTER_TYP_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEdCodeSemesterTypeId(System.Decimal _edCodeSemesterTypeId)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(null,_edCodeSemesterTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYP_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEdCodeSemesterTypeId(System.Decimal _edCodeSemesterTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(null, _edCodeSemesterTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYP_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEdCodeSemesterTypeId(TransactionManager transactionManager, System.Decimal _edCodeSemesterTypeId)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(transactionManager, _edCodeSemesterTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYP_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEdCodeSemesterTypeId(TransactionManager transactionManager, System.Decimal _edCodeSemesterTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(transactionManager, _edCodeSemesterTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYP_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEdCodeSemesterTypeId(System.Decimal _edCodeSemesterTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCodeSemesterTypeId(null, _edCodeSemesterTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYP_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public abstract TList<EdSemesterOpen> GetByEdCodeSemesterTypeId(TransactionManager transactionManager, System.Decimal _edCodeSemesterTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(null,_entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public TList<EdSemesterOpen> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength, out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterOpen&gt;"/> class.</returns>
		public abstract TList<EdSemesterOpen> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_SEMESTER_OPEN index.
		/// </summary>
		/// <param name="_edSemesterOpenId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterOpen"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterOpen GetByEdSemesterOpenId(System.Decimal _edSemesterOpenId)
		{
			int count = -1;
			return GetByEdSemesterOpenId(null,_edSemesterOpenId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEMESTER_OPEN index.
		/// </summary>
		/// <param name="_edSemesterOpenId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterOpen"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterOpen GetByEdSemesterOpenId(System.Decimal _edSemesterOpenId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdSemesterOpenId(null, _edSemesterOpenId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEMESTER_OPEN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterOpenId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterOpen"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterOpen GetByEdSemesterOpenId(TransactionManager transactionManager, System.Decimal _edSemesterOpenId)
		{
			int count = -1;
			return GetByEdSemesterOpenId(transactionManager, _edSemesterOpenId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEMESTER_OPEN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterOpenId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterOpen"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterOpen GetByEdSemesterOpenId(TransactionManager transactionManager, System.Decimal _edSemesterOpenId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdSemesterOpenId(transactionManager, _edSemesterOpenId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEMESTER_OPEN index.
		/// </summary>
		/// <param name="_edSemesterOpenId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterOpen"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterOpen GetByEdSemesterOpenId(System.Decimal _edSemesterOpenId, int start, int pageLength, out int count)
		{
			return GetByEdSemesterOpenId(null, _edSemesterOpenId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEMESTER_OPEN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterOpenId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterOpen"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdSemesterOpen GetByEdSemesterOpenId(TransactionManager transactionManager, System.Decimal _edSemesterOpenId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_SEMESTER_OPEN index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterOpen"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterOpen GetByEdAcadYearIdEntMainIdEdCodeSemesterIdAsCodeDegreeClassId(System.Decimal _edAcadYearId, System.Decimal _entMainId, System.Decimal _edCodeSemesterId, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByEdAcadYearIdEntMainIdEdCodeSemesterIdAsCodeDegreeClassId(null,_edAcadYearId, _entMainId, _edCodeSemesterId, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_SEMESTER_OPEN index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterOpen"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterOpen GetByEdAcadYearIdEntMainIdEdCodeSemesterIdAsCodeDegreeClassId(System.Decimal _edAcadYearId, System.Decimal _entMainId, System.Decimal _edCodeSemesterId, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEntMainIdEdCodeSemesterIdAsCodeDegreeClassId(null, _edAcadYearId, _entMainId, _edCodeSemesterId, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_SEMESTER_OPEN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterOpen"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterOpen GetByEdAcadYearIdEntMainIdEdCodeSemesterIdAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _entMainId, System.Decimal _edCodeSemesterId, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByEdAcadYearIdEntMainIdEdCodeSemesterIdAsCodeDegreeClassId(transactionManager, _edAcadYearId, _entMainId, _edCodeSemesterId, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_SEMESTER_OPEN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterOpen"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterOpen GetByEdAcadYearIdEntMainIdEdCodeSemesterIdAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _entMainId, System.Decimal _edCodeSemesterId, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEntMainIdEdCodeSemesterIdAsCodeDegreeClassId(transactionManager, _edAcadYearId, _entMainId, _edCodeSemesterId, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_SEMESTER_OPEN index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterOpen"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterOpen GetByEdAcadYearIdEntMainIdEdCodeSemesterIdAsCodeDegreeClassId(System.Decimal _edAcadYearId, System.Decimal _entMainId, System.Decimal _edCodeSemesterId, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEntMainIdEdCodeSemesterIdAsCodeDegreeClassId(null, _edAcadYearId, _entMainId, _edCodeSemesterId, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_SEMESTER_OPEN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterOpen"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdSemesterOpen GetByEdAcadYearIdEntMainIdEdCodeSemesterIdAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _entMainId, System.Decimal _edCodeSemesterId, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdSemesterOpen&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdSemesterOpen&gt;"/></returns>
		public static TList<EdSemesterOpen> Fill(IDataReader reader, TList<EdSemesterOpen> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdSemesterOpen c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdSemesterOpen")
					.Append("|").Append((System.Decimal)reader["ED_SEMESTER_OPEN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdSemesterOpen>(
					key.ToString(), // EntityTrackingKey
					"EdSemesterOpen",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdSemesterOpen();
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
					c.EdSemesterOpenId = (System.Decimal)reader["ED_SEMESTER_OPEN_ID"];
					c.OriginalEdSemesterOpenId = c.EdSemesterOpenId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.FromDate = (System.DateTime)reader["FROM_DATE"];
					c.ToDate = (System.DateTime)reader["TO_DATE"];
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EdCodeSemesterTypeId = (System.Decimal)reader["ED_CODE_SEMESTER_TYPE_ID"];
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.IsCurrent = (System.Decimal)reader["IS_CURRENT"];
					c.IsClosed = (System.Decimal)reader["IS_CLOSED"];
					c.IsAgendaClosed = (System.Decimal)reader["IS_AGENDA_CLOSED"];
					c.ExamFlg = Convert.IsDBNull(reader["EXAM_FLG"]) ? null : (System.Decimal?)reader["EXAM_FLG"];
					c.RsultFlg = Convert.IsDBNull(reader["RSULT_FLG"]) ? null : (System.Decimal?)reader["RSULT_FLG"];
					c.RegMthdFlg = Convert.IsDBNull(reader["REG_MTHD_FLG"]) ? null : (System.Int16?)reader["REG_MTHD_FLG"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.GroupFlg = Convert.IsDBNull(reader["GROUP_FLG"]) ? null : (System.Decimal?)reader["GROUP_FLG"];
					c.NoWeeks = Convert.IsDBNull(reader["NO_WEEKS"]) ? null : (System.Decimal?)reader["NO_WEEKS"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.EdCodeStudyMethodId = Convert.IsDBNull(reader["ED_CODE_STUDY_METHOD_ID"]) ? null : (System.Decimal?)reader["ED_CODE_STUDY_METHOD_ID"];
					c.EdCodeLevelId = Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdSemesterOpen"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdSemesterOpen"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdSemesterOpen entity)
		{
			if (!reader.Read()) return;
			
			entity.EdSemesterOpenId = (System.Decimal)reader[((int)EdSemesterOpenColumn.EdSemesterOpenId - 1)];
			entity.OriginalEdSemesterOpenId = (System.Decimal)reader["ED_SEMESTER_OPEN_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)EdSemesterOpenColumn.EdAcadYearId - 1)];
			entity.FromDate = (System.DateTime)reader[((int)EdSemesterOpenColumn.FromDate - 1)];
			entity.ToDate = (System.DateTime)reader[((int)EdSemesterOpenColumn.ToDate - 1)];
			entity.DescrAr = (System.String)reader[((int)EdSemesterOpenColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)EdSemesterOpenColumn.DescrEn - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)EdSemesterOpenColumn.EdCodeSemesterId - 1)];
			entity.EdCodeSemesterTypeId = (System.Decimal)reader[((int)EdSemesterOpenColumn.EdCodeSemesterTypeId - 1)];
			entity.EntMainId = (System.Decimal)reader[((int)EdSemesterOpenColumn.EntMainId - 1)];
			entity.IsCurrent = (System.Decimal)reader[((int)EdSemesterOpenColumn.IsCurrent - 1)];
			entity.IsClosed = (System.Decimal)reader[((int)EdSemesterOpenColumn.IsClosed - 1)];
			entity.IsAgendaClosed = (System.Decimal)reader[((int)EdSemesterOpenColumn.IsAgendaClosed - 1)];
			entity.ExamFlg = (reader.IsDBNull(((int)EdSemesterOpenColumn.ExamFlg - 1)))?null:(System.Decimal?)reader[((int)EdSemesterOpenColumn.ExamFlg - 1)];
			entity.RsultFlg = (reader.IsDBNull(((int)EdSemesterOpenColumn.RsultFlg - 1)))?null:(System.Decimal?)reader[((int)EdSemesterOpenColumn.RsultFlg - 1)];
			entity.RegMthdFlg = (reader.IsDBNull(((int)EdSemesterOpenColumn.RegMthdFlg - 1)))?null:(System.Int16?)reader[((int)EdSemesterOpenColumn.RegMthdFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdSemesterOpenColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdSemesterOpenColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdSemesterOpenColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdSemesterOpenColumn.LastDate - 1)];
			entity.GroupFlg = (reader.IsDBNull(((int)EdSemesterOpenColumn.GroupFlg - 1)))?null:(System.Decimal?)reader[((int)EdSemesterOpenColumn.GroupFlg - 1)];
			entity.NoWeeks = (reader.IsDBNull(((int)EdSemesterOpenColumn.NoWeeks - 1)))?null:(System.Decimal?)reader[((int)EdSemesterOpenColumn.NoWeeks - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)EdSemesterOpenColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)EdSemesterOpenColumn.AsCodeDegreeClassId - 1)];
			entity.EdCodeStudyMethodId = (reader.IsDBNull(((int)EdSemesterOpenColumn.EdCodeStudyMethodId - 1)))?null:(System.Decimal?)reader[((int)EdSemesterOpenColumn.EdCodeStudyMethodId - 1)];
			entity.EdCodeLevelId = (reader.IsDBNull(((int)EdSemesterOpenColumn.EdCodeLevelId - 1)))?null:(System.Decimal?)reader[((int)EdSemesterOpenColumn.EdCodeLevelId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdSemesterOpen"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdSemesterOpen"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdSemesterOpen entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdSemesterOpenId = (System.Decimal)dataRow["ED_SEMESTER_OPEN_ID"];
			entity.OriginalEdSemesterOpenId = (System.Decimal)dataRow["ED_SEMESTER_OPEN_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.FromDate = (System.DateTime)dataRow["FROM_DATE"];
			entity.ToDate = (System.DateTime)dataRow["TO_DATE"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdCodeSemesterTypeId = (System.Decimal)dataRow["ED_CODE_SEMESTER_TYPE_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.IsCurrent = (System.Decimal)dataRow["IS_CURRENT"];
			entity.IsClosed = (System.Decimal)dataRow["IS_CLOSED"];
			entity.IsAgendaClosed = (System.Decimal)dataRow["IS_AGENDA_CLOSED"];
			entity.ExamFlg = Convert.IsDBNull(dataRow["EXAM_FLG"]) ? null : (System.Decimal?)dataRow["EXAM_FLG"];
			entity.RsultFlg = Convert.IsDBNull(dataRow["RSULT_FLG"]) ? null : (System.Decimal?)dataRow["RSULT_FLG"];
			entity.RegMthdFlg = Convert.IsDBNull(dataRow["REG_MTHD_FLG"]) ? null : (System.Int16?)dataRow["REG_MTHD_FLG"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.GroupFlg = Convert.IsDBNull(dataRow["GROUP_FLG"]) ? null : (System.Decimal?)dataRow["GROUP_FLG"];
			entity.NoWeeks = Convert.IsDBNull(dataRow["NO_WEEKS"]) ? null : (System.Decimal?)dataRow["NO_WEEKS"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.EdCodeStudyMethodId = Convert.IsDBNull(dataRow["ED_CODE_STUDY_METHOD_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_STUDY_METHOD_ID"];
			entity.EdCodeLevelId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdSemesterOpen"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdSemesterOpen Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemesterOpen entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsCodeDegreeClassIdSource	
			if (CanDeepLoad(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeClassIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeClassId ?? 0.0m);
				AsCodeDegreeClass tmpEntity = EntityManager.LocateEntity<AsCodeDegreeClass>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegreeClass), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeClassIdSource = tmpEntity;
				else
					entity.AsCodeDegreeClassIdSource = DataRepository.AsCodeDegreeClassProvider.GetByAsCodeDegreeClassId(transactionManager, (entity.AsCodeDegreeClassId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeClassIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeClassIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeClassProvider.DeepLoad(transactionManager, entity.AsCodeDegreeClassIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeClassIdSource

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

			#region EdCodeSemesterTypeIdSource	
			if (CanDeepLoad(entity, "EdCodeSemesterType|EdCodeSemesterTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeSemesterTypeId;
				EdCodeSemesterType tmpEntity = EntityManager.LocateEntity<EdCodeSemesterType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemesterType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterTypeIdSource = tmpEntity;
				else
					entity.EdCodeSemesterTypeIdSource = DataRepository.EdCodeSemesterTypeProvider.GetByEdCodeSemesterTypeId(transactionManager, entity.EdCodeSemesterTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterTypeProvider.DeepLoad(transactionManager, entity.EdCodeSemesterTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterTypeIdSource

			#region EdCodeStudyMethodIdSource	
			if (CanDeepLoad(entity, "EdCodeStudyMethod|EdCodeStudyMethodIdSource", deepLoadType, innerList) 
				&& entity.EdCodeStudyMethodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeStudyMethodId ?? 0.0m);
				EdCodeStudyMethod tmpEntity = EntityManager.LocateEntity<EdCodeStudyMethod>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeStudyMethod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeStudyMethodIdSource = tmpEntity;
				else
					entity.EdCodeStudyMethodIdSource = DataRepository.EdCodeStudyMethodProvider.GetByEdCodeStudyMethodId(transactionManager, (entity.EdCodeStudyMethodId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeStudyMethodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeStudyMethodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeStudyMethodProvider.DeepLoad(transactionManager, entity.EdCodeStudyMethodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeStudyMethodIdSource

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
			// Deep load child collections  - Call GetByEdSemesterOpenId methods when available
			
			#region EdSemesterAgendaCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdSemesterAgenda>|EdSemesterAgendaCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemesterAgendaCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdSemesterAgendaCollection = DataRepository.EdSemesterAgendaProvider.GetByEdSemesterOpenId(transactionManager, entity.EdSemesterOpenId);

				if (deep && entity.EdSemesterAgendaCollection.Count > 0)
				{
					deepHandles.Add("EdSemesterAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemesterAgenda>) DataRepository.EdSemesterAgendaProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemesterAgendaCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdSemesterOpen object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdSemesterOpen instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdSemesterOpen Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemesterOpen entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsCodeDegreeClassIdSource
			if (CanDeepSave(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeClassIdSource != null)
			{
				DataRepository.AsCodeDegreeClassProvider.Save(transactionManager, entity.AsCodeDegreeClassIdSource);
				entity.AsCodeDegreeClassId = entity.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
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
			
			#region EdCodeSemesterTypeIdSource
			if (CanDeepSave(entity, "EdCodeSemesterType|EdCodeSemesterTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterTypeIdSource != null)
			{
				DataRepository.EdCodeSemesterTypeProvider.Save(transactionManager, entity.EdCodeSemesterTypeIdSource);
				entity.EdCodeSemesterTypeId = entity.EdCodeSemesterTypeIdSource.EdCodeSemesterTypeId;
			}
			#endregion 
			
			#region EdCodeStudyMethodIdSource
			if (CanDeepSave(entity, "EdCodeStudyMethod|EdCodeStudyMethodIdSource", deepSaveType, innerList) 
				&& entity.EdCodeStudyMethodIdSource != null)
			{
				DataRepository.EdCodeStudyMethodProvider.Save(transactionManager, entity.EdCodeStudyMethodIdSource);
				entity.EdCodeStudyMethodId = entity.EdCodeStudyMethodIdSource.EdCodeStudyMethodId;
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
	
			#region List<EdSemesterAgenda>
				if (CanDeepSave(entity.EdSemesterAgendaCollection, "List<EdSemesterAgenda>|EdSemesterAgendaCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdSemesterAgenda child in entity.EdSemesterAgendaCollection)
					{
						if(child.EdSemesterOpenIdSource != null)
						{
							child.EdSemesterOpenId = child.EdSemesterOpenIdSource.EdSemesterOpenId;
						}
						else
						{
							child.EdSemesterOpenId = entity.EdSemesterOpenId;
						}

					}

					if (entity.EdSemesterAgendaCollection.Count > 0 || entity.EdSemesterAgendaCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdSemesterAgendaProvider.Save(transactionManager, entity.EdSemesterAgendaCollection);
						
						deepHandles.Add("EdSemesterAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdSemesterAgenda >) DataRepository.EdSemesterAgendaProvider.DeepSave,
							new object[] { transactionManager, entity.EdSemesterAgendaCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdSemesterOpenChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdSemesterOpen</c>
	///</summary>
	public enum EdSemesterOpenChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
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
		/// Composite Property for <c>EdCodeSemesterType</c> at EdCodeSemesterTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemesterType))]
		EdCodeSemesterType,
		
		///<summary>
		/// Composite Property for <c>EdCodeStudyMethod</c> at EdCodeStudyMethodIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeStudyMethod))]
		EdCodeStudyMethod,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		///<summary>
		/// Collection of <c>EdSemesterOpen</c> as OneToMany for EdSemesterAgendaCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemesterAgenda>))]
		EdSemesterAgendaCollection,
	}
	
	#endregion EdSemesterOpenChildEntityTypes
	
	#region EdSemesterOpenFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdSemesterOpenColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdSemesterOpen"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdSemesterOpenFilterBuilder : SqlFilterBuilder<EdSemesterOpenColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdSemesterOpenFilterBuilder class.
		/// </summary>
		public EdSemesterOpenFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdSemesterOpenFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdSemesterOpenFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdSemesterOpenFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdSemesterOpenFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdSemesterOpenFilterBuilder
	
	#region EdSemesterOpenParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdSemesterOpenColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdSemesterOpen"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdSemesterOpenParameterBuilder : ParameterizedSqlFilterBuilder<EdSemesterOpenColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdSemesterOpenParameterBuilder class.
		/// </summary>
		public EdSemesterOpenParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdSemesterOpenParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdSemesterOpenParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdSemesterOpenParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdSemesterOpenParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdSemesterOpenParameterBuilder
	
	#region EdSemesterOpenSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdSemesterOpenColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdSemesterOpen"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdSemesterOpenSortBuilder : SqlSortBuilder<EdSemesterOpenColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdSemesterOpenSqlSortBuilder class.
		/// </summary>
		public EdSemesterOpenSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdSemesterOpenSortBuilder
	
} // end namespace
