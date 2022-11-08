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
	/// This class is the base class for any <see cref="EdBylawProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdBylawProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdBylaw, UMIS_VER2.BusinessLyer.EdBylawKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdBylawKey key)
		{
			return Delete(transactionManager, key.EdBylawId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edBylawId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edBylawId)
		{
			return Delete(null, _edBylawId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edBylawId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_AS_CODE_DEGREE key.
		///		FK_ED_BYLAW_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_AS_CODE_DEGREE key.
		///		FK_ED_BYLAW_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		/// <remarks></remarks>
		public TList<EdBylaw> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_AS_CODE_DEGREE key.
		///		FK_ED_BYLAW_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_AS_CODE_DEGREE key.
		///		fkEdBylawAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_AS_CODE_DEGREE key.
		///		fkEdBylawAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_AS_CODE_DEGREE key.
		///		FK_ED_BYLAW_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public abstract TList<EdBylaw> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_BYLAW_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId">UG  - PG</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_BYLAW_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">UG  - PG</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		/// <remarks></remarks>
		public TList<EdBylaw> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_BYLAW_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">UG  - PG</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_AS_CODE_DEGREE_CLASS key.
		///		fkEdBylawAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId">UG  - PG</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_AS_CODE_DEGREE_CLASS key.
		///		fkEdBylawAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId">UG  - PG</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_BYLAW_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">UG  - PG</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public abstract TList<EdBylaw> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_AS_FACULTY_INFO key.
		///		FK_ED_BYLAW_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_AS_FACULTY_INFO key.
		///		FK_ED_BYLAW_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		/// <remarks></remarks>
		public TList<EdBylaw> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_AS_FACULTY_INFO key.
		///		FK_ED_BYLAW_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_AS_FACULTY_INFO key.
		///		fkEdBylawAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_AS_FACULTY_INFO key.
		///		fkEdBylawAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_AS_FACULTY_INFO key.
		///		FK_ED_BYLAW_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public abstract TList<EdBylaw> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_ED_ACAD_YEAR key.
		///		FK_ED_BYLAW_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_ED_ACAD_YEAR key.
		///		FK_ED_BYLAW_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		/// <remarks></remarks>
		public TList<EdBylaw> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_ED_ACAD_YEAR key.
		///		FK_ED_BYLAW_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_ED_ACAD_YEAR key.
		///		fkEdBylawEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_ED_ACAD_YEAR key.
		///		fkEdBylawEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_ED_ACAD_YEAR key.
		///		FK_ED_BYLAW_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public abstract TList<EdBylaw> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_ED_CODE_STUDY_METHOD key.
		///		FK_ED_BYLAW_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByEdCodeStudyMethodId(System.Decimal? _edCodeStudyMethodId)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(_edCodeStudyMethodId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_ED_CODE_STUDY_METHOD key.
		///		FK_ED_BYLAW_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		/// <remarks></remarks>
		public TList<EdBylaw> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(transactionManager, _edCodeStudyMethodId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_ED_CODE_STUDY_METHOD key.
		///		FK_ED_BYLAW_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(transactionManager, _edCodeStudyMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_ED_CODE_STUDY_METHOD key.
		///		fkEdBylawEdCodeStudyMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByEdCodeStudyMethodId(System.Decimal? _edCodeStudyMethodId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeStudyMethodId(null, _edCodeStudyMethodId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_ED_CODE_STUDY_METHOD key.
		///		fkEdBylawEdCodeStudyMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByEdCodeStudyMethodId(System.Decimal? _edCodeStudyMethodId, int start, int pageLength,out int count)
		{
			return GetByEdCodeStudyMethodId(null, _edCodeStudyMethodId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_ED_CODE_STUDY_METHOD key.
		///		FK_ED_BYLAW_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public abstract TList<EdBylaw> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_ENTITY_MAIN key.
		///		FK_ED_BYLAW_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByEntMainId(System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_ENTITY_MAIN key.
		///		FK_ED_BYLAW_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		/// <remarks></remarks>
		public TList<EdBylaw> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_ENTITY_MAIN key.
		///		FK_ED_BYLAW_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_ENTITY_MAIN key.
		///		fkEdBylawEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_ENTITY_MAIN key.
		///		fkEdBylawEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_ENTITY_MAIN key.
		///		FK_ED_BYLAW_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public abstract TList<EdBylaw> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_SE_USER key.
		///		FK_ED_BYLAW_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_SE_USER key.
		///		FK_ED_BYLAW_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		/// <remarks></remarks>
		public TList<EdBylaw> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_SE_USER key.
		///		FK_ED_BYLAW_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_SE_USER key.
		///		fkEdBylawSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_SE_USER key.
		///		fkEdBylawSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public TList<EdBylaw> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_BYLAW_SE_USER key.
		///		FK_ED_BYLAW_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdBylaw objects.</returns>
		public abstract TList<EdBylaw> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdBylaw Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdBylawKey key, int start, int pageLength)
		{
			return GetByEdBylawId(transactionManager, key.EdBylawId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_BYLAW index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdBylaw"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdBylaw GetByEdBylawId(System.Decimal _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(null,_edBylawId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdBylaw"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdBylaw GetByEdBylawId(System.Decimal _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawId(null, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdBylaw"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdBylaw GetByEdBylawId(TransactionManager transactionManager, System.Decimal _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdBylaw"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdBylaw GetByEdBylawId(TransactionManager transactionManager, System.Decimal _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdBylaw"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdBylaw GetByEdBylawId(System.Decimal _edBylawId, int start, int pageLength, out int count)
		{
			return GetByEdBylawId(null, _edBylawId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdBylaw"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdBylaw GetByEdBylawId(TransactionManager transactionManager, System.Decimal _edBylawId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_BYLAW index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeClassId">UG  - PG</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="_entMainId"></param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdBylaw"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdBylaw GetByAsFacultyInfoIdAsCodeDegreeClassIdEdAcadYearIdAsCodeDegreeIdEntMainIdEdCodeStudyMethodId(System.Decimal? _asFacultyInfoId, System.Decimal _asCodeDegreeClassId, System.Decimal _edAcadYearId, System.Decimal? _asCodeDegreeId, System.Decimal? _entMainId, System.Decimal? _edCodeStudyMethodId)
		{
			int count = -1;
			return GetByAsFacultyInfoIdAsCodeDegreeClassIdEdAcadYearIdAsCodeDegreeIdEntMainIdEdCodeStudyMethodId(null,_asFacultyInfoId, _asCodeDegreeClassId, _edAcadYearId, _asCodeDegreeId, _entMainId, _edCodeStudyMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_BYLAW index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeClassId">UG  - PG</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="_entMainId"></param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdBylaw"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdBylaw GetByAsFacultyInfoIdAsCodeDegreeClassIdEdAcadYearIdAsCodeDegreeIdEntMainIdEdCodeStudyMethodId(System.Decimal? _asFacultyInfoId, System.Decimal _asCodeDegreeClassId, System.Decimal _edAcadYearId, System.Decimal? _asCodeDegreeId, System.Decimal? _entMainId, System.Decimal? _edCodeStudyMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdAsCodeDegreeClassIdEdAcadYearIdAsCodeDegreeIdEntMainIdEdCodeStudyMethodId(null, _asFacultyInfoId, _asCodeDegreeClassId, _edAcadYearId, _asCodeDegreeId, _entMainId, _edCodeStudyMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_BYLAW index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeClassId">UG  - PG</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="_entMainId"></param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdBylaw"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdBylaw GetByAsFacultyInfoIdAsCodeDegreeClassIdEdAcadYearIdAsCodeDegreeIdEntMainIdEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _asCodeDegreeClassId, System.Decimal _edAcadYearId, System.Decimal? _asCodeDegreeId, System.Decimal? _entMainId, System.Decimal? _edCodeStudyMethodId)
		{
			int count = -1;
			return GetByAsFacultyInfoIdAsCodeDegreeClassIdEdAcadYearIdAsCodeDegreeIdEntMainIdEdCodeStudyMethodId(transactionManager, _asFacultyInfoId, _asCodeDegreeClassId, _edAcadYearId, _asCodeDegreeId, _entMainId, _edCodeStudyMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_BYLAW index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeClassId">UG  - PG</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="_entMainId"></param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdBylaw"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdBylaw GetByAsFacultyInfoIdAsCodeDegreeClassIdEdAcadYearIdAsCodeDegreeIdEntMainIdEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _asCodeDegreeClassId, System.Decimal _edAcadYearId, System.Decimal? _asCodeDegreeId, System.Decimal? _entMainId, System.Decimal? _edCodeStudyMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdAsCodeDegreeClassIdEdAcadYearIdAsCodeDegreeIdEntMainIdEdCodeStudyMethodId(transactionManager, _asFacultyInfoId, _asCodeDegreeClassId, _edAcadYearId, _asCodeDegreeId, _entMainId, _edCodeStudyMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_BYLAW index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeClassId">UG  - PG</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="_entMainId"></param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdBylaw"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdBylaw GetByAsFacultyInfoIdAsCodeDegreeClassIdEdAcadYearIdAsCodeDegreeIdEntMainIdEdCodeStudyMethodId(System.Decimal? _asFacultyInfoId, System.Decimal _asCodeDegreeClassId, System.Decimal _edAcadYearId, System.Decimal? _asCodeDegreeId, System.Decimal? _entMainId, System.Decimal? _edCodeStudyMethodId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoIdAsCodeDegreeClassIdEdAcadYearIdAsCodeDegreeIdEntMainIdEdCodeStudyMethodId(null, _asFacultyInfoId, _asCodeDegreeClassId, _edAcadYearId, _asCodeDegreeId, _entMainId, _edCodeStudyMethodId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_BYLAW index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeClassId">UG  - PG</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="_entMainId"></param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdBylaw"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdBylaw GetByAsFacultyInfoIdAsCodeDegreeClassIdEdAcadYearIdAsCodeDegreeIdEntMainIdEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _asCodeDegreeClassId, System.Decimal _edAcadYearId, System.Decimal? _asCodeDegreeId, System.Decimal? _entMainId, System.Decimal? _edCodeStudyMethodId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdBylaw&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdBylaw&gt;"/></returns>
		public static TList<EdBylaw> Fill(IDataReader reader, TList<EdBylaw> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdBylaw c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdBylaw")
					.Append("|").Append((System.Decimal)reader["ED_BYLAW_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdBylaw>(
					key.ToString(), // EntityTrackingKey
					"EdBylaw",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdBylaw();
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
					c.EdBylawId = (System.Decimal)reader["ED_BYLAW_ID"];
					c.OriginalEdBylawId = c.EdBylawId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.CurrentFlg = (System.Decimal)reader["CURRENT_FLG"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.AsCodeDegreeClassId = (System.Decimal)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.ClosedFlg = (System.Decimal)reader["CLOSED_FLG"];
					c.PlcyAbsLvlFlg = Convert.IsDBNull(reader["PLCY_ABS_LVL_FLG"]) ? null : (System.Decimal?)reader["PLCY_ABS_LVL_FLG"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.EdtonNum = Convert.IsDBNull(reader["EDTON_NUM"]) ? null : (System.String)reader["EDTON_NUM"];
					c.AudtNote = Convert.IsDBNull(reader["AUDT_NOTE"]) ? null : (System.String)reader["AUDT_NOTE"];
					c.EdCodeStudyMethodId = Convert.IsDBNull(reader["ED_CODE_STUDY_METHOD_ID"]) ? null : (System.Decimal?)reader["ED_CODE_STUDY_METHOD_ID"];
					c.AccumGrdngTypeFlg = Convert.IsDBNull(reader["ACCUM_GRDNG_TYPE_FLG"]) ? null : (System.Decimal?)reader["ACCUM_GRDNG_TYPE_FLG"];
					c.CrsGrdngTypeFlg = Convert.IsDBNull(reader["CRS_GRDNG_TYPE_FLG"]) ? null : (System.Decimal?)reader["CRS_GRDNG_TYPE_FLG"];
					c.PlcyLoadCalcFlg = Convert.IsDBNull(reader["PLCY_LOAD_CALC_FLG"]) ? null : (System.Int32?)reader["PLCY_LOAD_CALC_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdBylaw"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdBylaw"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdBylaw entity)
		{
			if (!reader.Read()) return;
			
			entity.EdBylawId = (System.Decimal)reader[((int)EdBylawColumn.EdBylawId - 1)];
			entity.OriginalEdBylawId = (System.Decimal)reader["ED_BYLAW_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)EdBylawColumn.EdAcadYearId - 1)];
			entity.CurrentFlg = (System.Decimal)reader[((int)EdBylawColumn.CurrentFlg - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdBylawColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdBylawColumn.AsFacultyInfoId - 1)];
			entity.AsCodeDegreeClassId = (System.Decimal)reader[((int)EdBylawColumn.AsCodeDegreeClassId - 1)];
			entity.ClosedFlg = (System.Decimal)reader[((int)EdBylawColumn.ClosedFlg - 1)];
			entity.PlcyAbsLvlFlg = (reader.IsDBNull(((int)EdBylawColumn.PlcyAbsLvlFlg - 1)))?null:(System.Decimal?)reader[((int)EdBylawColumn.PlcyAbsLvlFlg - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdBylawColumn.Notes - 1)))?null:(System.String)reader[((int)EdBylawColumn.Notes - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)EdBylawColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)EdBylawColumn.AsCodeDegreeId - 1)];
			entity.EntMainId = (reader.IsDBNull(((int)EdBylawColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)EdBylawColumn.EntMainId - 1)];
			entity.EdtonNum = (reader.IsDBNull(((int)EdBylawColumn.EdtonNum - 1)))?null:(System.String)reader[((int)EdBylawColumn.EdtonNum - 1)];
			entity.AudtNote = (reader.IsDBNull(((int)EdBylawColumn.AudtNote - 1)))?null:(System.String)reader[((int)EdBylawColumn.AudtNote - 1)];
			entity.EdCodeStudyMethodId = (reader.IsDBNull(((int)EdBylawColumn.EdCodeStudyMethodId - 1)))?null:(System.Decimal?)reader[((int)EdBylawColumn.EdCodeStudyMethodId - 1)];
			entity.AccumGrdngTypeFlg = (reader.IsDBNull(((int)EdBylawColumn.AccumGrdngTypeFlg - 1)))?null:(System.Decimal?)reader[((int)EdBylawColumn.AccumGrdngTypeFlg - 1)];
			entity.CrsGrdngTypeFlg = (reader.IsDBNull(((int)EdBylawColumn.CrsGrdngTypeFlg - 1)))?null:(System.Decimal?)reader[((int)EdBylawColumn.CrsGrdngTypeFlg - 1)];
			entity.PlcyLoadCalcFlg = (reader.IsDBNull(((int)EdBylawColumn.PlcyLoadCalcFlg - 1)))?null:(System.Int32?)reader[((int)EdBylawColumn.PlcyLoadCalcFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdBylawColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdBylawColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdBylawColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdBylawColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdBylaw"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdBylaw"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdBylaw entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdBylawId = (System.Decimal)dataRow["ED_BYLAW_ID"];
			entity.OriginalEdBylawId = (System.Decimal)dataRow["ED_BYLAW_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.CurrentFlg = (System.Decimal)dataRow["CURRENT_FLG"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.AsCodeDegreeClassId = (System.Decimal)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.ClosedFlg = (System.Decimal)dataRow["CLOSED_FLG"];
			entity.PlcyAbsLvlFlg = Convert.IsDBNull(dataRow["PLCY_ABS_LVL_FLG"]) ? null : (System.Decimal?)dataRow["PLCY_ABS_LVL_FLG"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
			entity.EdtonNum = Convert.IsDBNull(dataRow["EDTON_NUM"]) ? null : (System.String)dataRow["EDTON_NUM"];
			entity.AudtNote = Convert.IsDBNull(dataRow["AUDT_NOTE"]) ? null : (System.String)dataRow["AUDT_NOTE"];
			entity.EdCodeStudyMethodId = Convert.IsDBNull(dataRow["ED_CODE_STUDY_METHOD_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_STUDY_METHOD_ID"];
			entity.AccumGrdngTypeFlg = Convert.IsDBNull(dataRow["ACCUM_GRDNG_TYPE_FLG"]) ? null : (System.Decimal?)dataRow["ACCUM_GRDNG_TYPE_FLG"];
			entity.CrsGrdngTypeFlg = Convert.IsDBNull(dataRow["CRS_GRDNG_TYPE_FLG"]) ? null : (System.Decimal?)dataRow["CRS_GRDNG_TYPE_FLG"];
			entity.PlcyLoadCalcFlg = Convert.IsDBNull(dataRow["PLCY_LOAD_CALC_FLG"]) ? null : (System.Int32?)dataRow["PLCY_LOAD_CALC_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdBylaw"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdBylaw Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdBylaw entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsCodeDegreeIdSource	
			if (CanDeepLoad(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeId ?? 0.0m);
				AsCodeDegree tmpEntity = EntityManager.LocateEntity<AsCodeDegree>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeIdSource = tmpEntity;
				else
					entity.AsCodeDegreeIdSource = DataRepository.AsCodeDegreeProvider.GetByAsCodeDegreeId(transactionManager, (entity.AsCodeDegreeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeProvider.DeepLoad(transactionManager, entity.AsCodeDegreeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeIdSource

			#region AsCodeDegreeClassIdSource	
			if (CanDeepLoad(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeClassIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsCodeDegreeClassId;
				AsCodeDegreeClass tmpEntity = EntityManager.LocateEntity<AsCodeDegreeClass>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegreeClass), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeClassIdSource = tmpEntity;
				else
					entity.AsCodeDegreeClassIdSource = DataRepository.AsCodeDegreeClassProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);		
				
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

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdBylawId methods when available
			
			#region EntPolicyExcuseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyExcuse>|EntPolicyExcuseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyExcuseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyExcuseCollection = DataRepository.EntPolicyExcuseProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);

				if (deep && entity.EntPolicyExcuseCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyExcuse>) DataRepository.EntPolicyExcuseProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyExcuseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyCourseRepeatCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyCourseRepeat>|EntPolicyCourseRepeatCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyCourseRepeatCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyCourseRepeatCollection = DataRepository.EntPolicyCourseRepeatProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);

				if (deep && entity.EntPolicyCourseRepeatCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyCourseRepeatCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyCourseRepeat>) DataRepository.EntPolicyCourseRepeatProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyCourseRepeatCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsStateToCollectionGetByEdBylawIdTo
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsStateTo>|EdStudIntTrnsStateToCollectionGetByEdBylawIdTo", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsStateToCollectionGetByEdBylawIdTo' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsStateToCollectionGetByEdBylawIdTo = DataRepository.EdStudIntTrnsStateToProvider.GetByEdBylawIdTo(transactionManager, entity.EdBylawId);

				if (deep && entity.EdStudIntTrnsStateToCollectionGetByEdBylawIdTo.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsStateToCollectionGetByEdBylawIdTo",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsStateTo>) DataRepository.EdStudIntTrnsStateToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsStateToCollectionGetByEdBylawIdTo, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolcyCrsRetakeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolcyCrsRetake>|EntPolcyCrsRetakeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolcyCrsRetakeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolcyCrsRetakeCollection = DataRepository.EntPolcyCrsRetakeProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);

				if (deep && entity.EntPolcyCrsRetakeCollection.Count > 0)
				{
					deepHandles.Add("EntPolcyCrsRetakeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolcyCrsRetake>) DataRepository.EntPolcyCrsRetakeProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolcyCrsRetakeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicySemHonorCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicySemHonor>|EntPolicySemHonorCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicySemHonorCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicySemHonorCollection = DataRepository.EntPolicySemHonorProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);

				if (deep && entity.EntPolicySemHonorCollection.Count > 0)
				{
					deepHandles.Add("EntPolicySemHonorCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicySemHonor>) DataRepository.EntPolicySemHonorProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicySemHonorCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsStateFromCollectionGetByEdBylawIdFrom
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsStateFrom>|EdStudIntTrnsStateFromCollectionGetByEdBylawIdFrom", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsStateFromCollectionGetByEdBylawIdFrom' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsStateFromCollectionGetByEdBylawIdFrom = DataRepository.EdStudIntTrnsStateFromProvider.GetByEdBylawIdFrom(transactionManager, entity.EdBylawId);

				if (deep && entity.EdStudIntTrnsStateFromCollectionGetByEdBylawIdFrom.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsStateFromCollectionGetByEdBylawIdFrom",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsStateFrom>) DataRepository.EdStudIntTrnsStateFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsStateFromCollectionGetByEdBylawIdFrom, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolcyGrdngHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolcyGrdngHdr>|EntPolcyGrdngHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolcyGrdngHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolcyGrdngHdrCollection = DataRepository.EntPolcyGrdngHdrProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);

				if (deep && entity.EntPolcyGrdngHdrCollection.Count > 0)
				{
					deepHandles.Add("EntPolcyGrdngHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolcyGrdngHdr>) DataRepository.EntPolcyGrdngHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolcyGrdngHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolcyGpaCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolcyGpa>|EntPolcyGpaCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolcyGpaCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolcyGpaCollection = DataRepository.EntPolcyGpaProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);

				if (deep && entity.EntPolcyGpaCollection.Count > 0)
				{
					deepHandles.Add("EntPolcyGpaCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolcyGpa>) DataRepository.EntPolcyGpaProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolcyGpaCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyGradingLevelCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyGradingLevel>|EntPolicyGradingLevelCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyGradingLevelCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyGradingLevelCollection = DataRepository.EntPolicyGradingLevelProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);

				if (deep && entity.EntPolicyGradingLevelCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyGradingLevelCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyGradingLevel>) DataRepository.EntPolicyGradingLevelProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyGradingLevelCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyAbsence>|EntPolicyAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyAbsenceCollection = DataRepository.EntPolicyAbsenceProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);

				if (deep && entity.EntPolicyAbsenceCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyAbsence>) DataRepository.EntPolicyAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyObservedCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyObserved>|EntPolicyObservedCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyObservedCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyObservedCollection = DataRepository.EntPolicyObservedProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);

				if (deep && entity.EntPolicyObservedCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyObservedCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyObserved>) DataRepository.EntPolicyObservedProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyObservedCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudFacultyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudFaculty>|EdStudFacultyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudFacultyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudFacultyCollection = DataRepository.EdStudFacultyProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);

				if (deep && entity.EdStudFacultyCollection.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyLoadCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyLoad>|EntPolicyLoadCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyLoadCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyLoadCollection = DataRepository.EntPolicyLoadProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);

				if (deep && entity.EntPolicyLoadCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyLoadCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyLoad>) DataRepository.EntPolicyLoadProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyLoadCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsStateFromCollectionGetByEdBylawIdTo
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsStateFrom>|EdStudIntTrnsStateFromCollectionGetByEdBylawIdTo", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsStateFromCollectionGetByEdBylawIdTo' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsStateFromCollectionGetByEdBylawIdTo = DataRepository.EdStudIntTrnsStateFromProvider.GetByEdBylawIdTo(transactionManager, entity.EdBylawId);

				if (deep && entity.EdStudIntTrnsStateFromCollectionGetByEdBylawIdTo.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsStateFromCollectionGetByEdBylawIdTo",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsStateFrom>) DataRepository.EdStudIntTrnsStateFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsStateFromCollectionGetByEdBylawIdTo, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyGradingHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyGradingHdr>|EntPolicyGradingHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyGradingHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyGradingHdrCollection = DataRepository.EntPolicyGradingHdrProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);

				if (deep && entity.EntPolicyGradingHdrCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyGradingHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyGradingHdr>) DataRepository.EntPolicyGradingHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyGradingHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPlcyAcadWarnCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPlcyAcadWarn>|EntPlcyAcadWarnCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPlcyAcadWarnCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPlcyAcadWarnCollection = DataRepository.EntPlcyAcadWarnProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);

				if (deep && entity.EntPlcyAcadWarnCollection.Count > 0)
				{
					deepHandles.Add("EntPlcyAcadWarnCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPlcyAcadWarn>) DataRepository.EntPlcyAcadWarnProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPlcyAcadWarnCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyCourseChngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyCourseChng>|EntPolicyCourseChngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyCourseChngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyCourseChngCollection = DataRepository.EntPolicyCourseChngProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);

				if (deep && entity.EntPolicyCourseChngCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyCourseChngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyCourseChng>) DataRepository.EntPolicyCourseChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyCourseChngCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyAssessHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyAssessHdr>|EntPolicyAssessHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAssessHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyAssessHdrCollection = DataRepository.EntPolicyAssessHdrProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);

				if (deep && entity.EntPolicyAssessHdrCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyAssessHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyAssessHdr>) DataRepository.EntPolicyAssessHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyAssessHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsStateToCollectionGetByEdBylawIdFrom
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsStateTo>|EdStudIntTrnsStateToCollectionGetByEdBylawIdFrom", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsStateToCollectionGetByEdBylawIdFrom' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsStateToCollectionGetByEdBylawIdFrom = DataRepository.EdStudIntTrnsStateToProvider.GetByEdBylawIdFrom(transactionManager, entity.EdBylawId);

				if (deep && entity.EdStudIntTrnsStateToCollectionGetByEdBylawIdFrom.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsStateToCollectionGetByEdBylawIdFrom",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsStateTo>) DataRepository.EdStudIntTrnsStateToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsStateToCollectionGetByEdBylawIdFrom, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyAccumHonorCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyAccumHonor>|EntPolicyAccumHonorCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAccumHonorCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyAccumHonorCollection = DataRepository.EntPolicyAccumHonorProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);

				if (deep && entity.EntPolicyAccumHonorCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyAccumHonorCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyAccumHonor>) DataRepository.EntPolicyAccumHonorProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyAccumHonorCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdBylaw object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdBylaw instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdBylaw Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdBylaw entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsCodeDegreeIdSource
			if (CanDeepSave(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeIdSource != null)
			{
				DataRepository.AsCodeDegreeProvider.Save(transactionManager, entity.AsCodeDegreeIdSource);
				entity.AsCodeDegreeId = entity.AsCodeDegreeIdSource.AsCodeDegreeId;
			}
			#endregion 
			
			#region AsCodeDegreeClassIdSource
			if (CanDeepSave(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeClassIdSource != null)
			{
				DataRepository.AsCodeDegreeClassProvider.Save(transactionManager, entity.AsCodeDegreeClassIdSource);
				entity.AsCodeDegreeClassId = entity.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
			}
			#endregion 
			
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
			
			#region SeUserIdSource
			if (CanDeepSave(entity, "SeUser|SeUserIdSource", deepSaveType, innerList) 
				&& entity.SeUserIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserIdSource);
				entity.SeUserId = entity.SeUserIdSource.SeUserId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EntPolicyExcuse>
				if (CanDeepSave(entity.EntPolicyExcuseCollection, "List<EntPolicyExcuse>|EntPolicyExcuseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyExcuse child in entity.EntPolicyExcuseCollection)
					{
						if(child.EdBylawIdSource != null)
						{
							child.EdBylawId = child.EdBylawIdSource.EdBylawId;
						}
						else
						{
							child.EdBylawId = entity.EdBylawId;
						}

					}

					if (entity.EntPolicyExcuseCollection.Count > 0 || entity.EntPolicyExcuseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyExcuseProvider.Save(transactionManager, entity.EntPolicyExcuseCollection);
						
						deepHandles.Add("EntPolicyExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyExcuse >) DataRepository.EntPolicyExcuseProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyExcuseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyCourseRepeat>
				if (CanDeepSave(entity.EntPolicyCourseRepeatCollection, "List<EntPolicyCourseRepeat>|EntPolicyCourseRepeatCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyCourseRepeat child in entity.EntPolicyCourseRepeatCollection)
					{
						if(child.EdBylawIdSource != null)
						{
							child.EdBylawId = child.EdBylawIdSource.EdBylawId;
						}
						else
						{
							child.EdBylawId = entity.EdBylawId;
						}

					}

					if (entity.EntPolicyCourseRepeatCollection.Count > 0 || entity.EntPolicyCourseRepeatCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyCourseRepeatProvider.Save(transactionManager, entity.EntPolicyCourseRepeatCollection);
						
						deepHandles.Add("EntPolicyCourseRepeatCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyCourseRepeat >) DataRepository.EntPolicyCourseRepeatProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyCourseRepeatCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsStateTo>
				if (CanDeepSave(entity.EdStudIntTrnsStateToCollectionGetByEdBylawIdTo, "List<EdStudIntTrnsStateTo>|EdStudIntTrnsStateToCollectionGetByEdBylawIdTo", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsStateTo child in entity.EdStudIntTrnsStateToCollectionGetByEdBylawIdTo)
					{
						if(child.EdBylawIdToSource != null)
						{
							child.EdBylawIdTo = child.EdBylawIdToSource.EdBylawId;
						}
						else
						{
							child.EdBylawIdTo = entity.EdBylawId;
						}

					}

					if (entity.EdStudIntTrnsStateToCollectionGetByEdBylawIdTo.Count > 0 || entity.EdStudIntTrnsStateToCollectionGetByEdBylawIdTo.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsStateToProvider.Save(transactionManager, entity.EdStudIntTrnsStateToCollectionGetByEdBylawIdTo);
						
						deepHandles.Add("EdStudIntTrnsStateToCollectionGetByEdBylawIdTo",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsStateTo >) DataRepository.EdStudIntTrnsStateToProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsStateToCollectionGetByEdBylawIdTo, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolcyCrsRetake>
				if (CanDeepSave(entity.EntPolcyCrsRetakeCollection, "List<EntPolcyCrsRetake>|EntPolcyCrsRetakeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolcyCrsRetake child in entity.EntPolcyCrsRetakeCollection)
					{
						if(child.EdBylawIdSource != null)
						{
							child.EdBylawId = child.EdBylawIdSource.EdBylawId;
						}
						else
						{
							child.EdBylawId = entity.EdBylawId;
						}

					}

					if (entity.EntPolcyCrsRetakeCollection.Count > 0 || entity.EntPolcyCrsRetakeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolcyCrsRetakeProvider.Save(transactionManager, entity.EntPolcyCrsRetakeCollection);
						
						deepHandles.Add("EntPolcyCrsRetakeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolcyCrsRetake >) DataRepository.EntPolcyCrsRetakeProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolcyCrsRetakeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicySemHonor>
				if (CanDeepSave(entity.EntPolicySemHonorCollection, "List<EntPolicySemHonor>|EntPolicySemHonorCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicySemHonor child in entity.EntPolicySemHonorCollection)
					{
						if(child.EdBylawIdSource != null)
						{
							child.EdBylawId = child.EdBylawIdSource.EdBylawId;
						}
						else
						{
							child.EdBylawId = entity.EdBylawId;
						}

					}

					if (entity.EntPolicySemHonorCollection.Count > 0 || entity.EntPolicySemHonorCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicySemHonorProvider.Save(transactionManager, entity.EntPolicySemHonorCollection);
						
						deepHandles.Add("EntPolicySemHonorCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicySemHonor >) DataRepository.EntPolicySemHonorProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicySemHonorCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsStateFrom>
				if (CanDeepSave(entity.EdStudIntTrnsStateFromCollectionGetByEdBylawIdFrom, "List<EdStudIntTrnsStateFrom>|EdStudIntTrnsStateFromCollectionGetByEdBylawIdFrom", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsStateFrom child in entity.EdStudIntTrnsStateFromCollectionGetByEdBylawIdFrom)
					{
						if(child.EdBylawIdFromSource != null)
						{
							child.EdBylawIdFrom = child.EdBylawIdFromSource.EdBylawId;
						}
						else
						{
							child.EdBylawIdFrom = entity.EdBylawId;
						}

					}

					if (entity.EdStudIntTrnsStateFromCollectionGetByEdBylawIdFrom.Count > 0 || entity.EdStudIntTrnsStateFromCollectionGetByEdBylawIdFrom.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsStateFromProvider.Save(transactionManager, entity.EdStudIntTrnsStateFromCollectionGetByEdBylawIdFrom);
						
						deepHandles.Add("EdStudIntTrnsStateFromCollectionGetByEdBylawIdFrom",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsStateFrom >) DataRepository.EdStudIntTrnsStateFromProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsStateFromCollectionGetByEdBylawIdFrom, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolcyGrdngHdr>
				if (CanDeepSave(entity.EntPolcyGrdngHdrCollection, "List<EntPolcyGrdngHdr>|EntPolcyGrdngHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolcyGrdngHdr child in entity.EntPolcyGrdngHdrCollection)
					{
						if(child.EdBylawIdSource != null)
						{
							child.EdBylawId = child.EdBylawIdSource.EdBylawId;
						}
						else
						{
							child.EdBylawId = entity.EdBylawId;
						}

					}

					if (entity.EntPolcyGrdngHdrCollection.Count > 0 || entity.EntPolcyGrdngHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolcyGrdngHdrProvider.Save(transactionManager, entity.EntPolcyGrdngHdrCollection);
						
						deepHandles.Add("EntPolcyGrdngHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolcyGrdngHdr >) DataRepository.EntPolcyGrdngHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolcyGrdngHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolcyGpa>
				if (CanDeepSave(entity.EntPolcyGpaCollection, "List<EntPolcyGpa>|EntPolcyGpaCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolcyGpa child in entity.EntPolcyGpaCollection)
					{
						if(child.EdBylawIdSource != null)
						{
							child.EdBylawId = child.EdBylawIdSource.EdBylawId;
						}
						else
						{
							child.EdBylawId = entity.EdBylawId;
						}

					}

					if (entity.EntPolcyGpaCollection.Count > 0 || entity.EntPolcyGpaCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolcyGpaProvider.Save(transactionManager, entity.EntPolcyGpaCollection);
						
						deepHandles.Add("EntPolcyGpaCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolcyGpa >) DataRepository.EntPolcyGpaProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolcyGpaCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyGradingLevel>
				if (CanDeepSave(entity.EntPolicyGradingLevelCollection, "List<EntPolicyGradingLevel>|EntPolicyGradingLevelCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyGradingLevel child in entity.EntPolicyGradingLevelCollection)
					{
						if(child.EdBylawIdSource != null)
						{
							child.EdBylawId = child.EdBylawIdSource.EdBylawId;
						}
						else
						{
							child.EdBylawId = entity.EdBylawId;
						}

					}

					if (entity.EntPolicyGradingLevelCollection.Count > 0 || entity.EntPolicyGradingLevelCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyGradingLevelProvider.Save(transactionManager, entity.EntPolicyGradingLevelCollection);
						
						deepHandles.Add("EntPolicyGradingLevelCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyGradingLevel >) DataRepository.EntPolicyGradingLevelProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyGradingLevelCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyAbsence>
				if (CanDeepSave(entity.EntPolicyAbsenceCollection, "List<EntPolicyAbsence>|EntPolicyAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyAbsence child in entity.EntPolicyAbsenceCollection)
					{
						if(child.EdBylawIdSource != null)
						{
							child.EdBylawId = child.EdBylawIdSource.EdBylawId;
						}
						else
						{
							child.EdBylawId = entity.EdBylawId;
						}

					}

					if (entity.EntPolicyAbsenceCollection.Count > 0 || entity.EntPolicyAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyAbsenceProvider.Save(transactionManager, entity.EntPolicyAbsenceCollection);
						
						deepHandles.Add("EntPolicyAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyAbsence >) DataRepository.EntPolicyAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyAbsenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyObserved>
				if (CanDeepSave(entity.EntPolicyObservedCollection, "List<EntPolicyObserved>|EntPolicyObservedCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyObserved child in entity.EntPolicyObservedCollection)
					{
						if(child.EdBylawIdSource != null)
						{
							child.EdBylawId = child.EdBylawIdSource.EdBylawId;
						}
						else
						{
							child.EdBylawId = entity.EdBylawId;
						}

					}

					if (entity.EntPolicyObservedCollection.Count > 0 || entity.EntPolicyObservedCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyObservedProvider.Save(transactionManager, entity.EntPolicyObservedCollection);
						
						deepHandles.Add("EntPolicyObservedCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyObserved >) DataRepository.EntPolicyObservedProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyObservedCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudFaculty>
				if (CanDeepSave(entity.EdStudFacultyCollection, "List<EdStudFaculty>|EdStudFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudFaculty child in entity.EdStudFacultyCollection)
					{
						if(child.EdBylawIdSource != null)
						{
							child.EdBylawId = child.EdBylawIdSource.EdBylawId;
						}
						else
						{
							child.EdBylawId = entity.EdBylawId;
						}

					}

					if (entity.EdStudFacultyCollection.Count > 0 || entity.EdStudFacultyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudFacultyProvider.Save(transactionManager, entity.EdStudFacultyCollection);
						
						deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudFaculty >) DataRepository.EdStudFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudFacultyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyLoad>
				if (CanDeepSave(entity.EntPolicyLoadCollection, "List<EntPolicyLoad>|EntPolicyLoadCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyLoad child in entity.EntPolicyLoadCollection)
					{
						if(child.EdBylawIdSource != null)
						{
							child.EdBylawId = child.EdBylawIdSource.EdBylawId;
						}
						else
						{
							child.EdBylawId = entity.EdBylawId;
						}

					}

					if (entity.EntPolicyLoadCollection.Count > 0 || entity.EntPolicyLoadCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyLoadProvider.Save(transactionManager, entity.EntPolicyLoadCollection);
						
						deepHandles.Add("EntPolicyLoadCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyLoad >) DataRepository.EntPolicyLoadProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyLoadCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsStateFrom>
				if (CanDeepSave(entity.EdStudIntTrnsStateFromCollectionGetByEdBylawIdTo, "List<EdStudIntTrnsStateFrom>|EdStudIntTrnsStateFromCollectionGetByEdBylawIdTo", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsStateFrom child in entity.EdStudIntTrnsStateFromCollectionGetByEdBylawIdTo)
					{
						if(child.EdBylawIdToSource != null)
						{
							child.EdBylawIdTo = child.EdBylawIdToSource.EdBylawId;
						}
						else
						{
							child.EdBylawIdTo = entity.EdBylawId;
						}

					}

					if (entity.EdStudIntTrnsStateFromCollectionGetByEdBylawIdTo.Count > 0 || entity.EdStudIntTrnsStateFromCollectionGetByEdBylawIdTo.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsStateFromProvider.Save(transactionManager, entity.EdStudIntTrnsStateFromCollectionGetByEdBylawIdTo);
						
						deepHandles.Add("EdStudIntTrnsStateFromCollectionGetByEdBylawIdTo",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsStateFrom >) DataRepository.EdStudIntTrnsStateFromProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsStateFromCollectionGetByEdBylawIdTo, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyGradingHdr>
				if (CanDeepSave(entity.EntPolicyGradingHdrCollection, "List<EntPolicyGradingHdr>|EntPolicyGradingHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyGradingHdr child in entity.EntPolicyGradingHdrCollection)
					{
						if(child.EdBylawIdSource != null)
						{
							child.EdBylawId = child.EdBylawIdSource.EdBylawId;
						}
						else
						{
							child.EdBylawId = entity.EdBylawId;
						}

					}

					if (entity.EntPolicyGradingHdrCollection.Count > 0 || entity.EntPolicyGradingHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyGradingHdrProvider.Save(transactionManager, entity.EntPolicyGradingHdrCollection);
						
						deepHandles.Add("EntPolicyGradingHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyGradingHdr >) DataRepository.EntPolicyGradingHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyGradingHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPlcyAcadWarn>
				if (CanDeepSave(entity.EntPlcyAcadWarnCollection, "List<EntPlcyAcadWarn>|EntPlcyAcadWarnCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPlcyAcadWarn child in entity.EntPlcyAcadWarnCollection)
					{
						if(child.EdBylawIdSource != null)
						{
							child.EdBylawId = child.EdBylawIdSource.EdBylawId;
						}
						else
						{
							child.EdBylawId = entity.EdBylawId;
						}

					}

					if (entity.EntPlcyAcadWarnCollection.Count > 0 || entity.EntPlcyAcadWarnCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPlcyAcadWarnProvider.Save(transactionManager, entity.EntPlcyAcadWarnCollection);
						
						deepHandles.Add("EntPlcyAcadWarnCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPlcyAcadWarn >) DataRepository.EntPlcyAcadWarnProvider.DeepSave,
							new object[] { transactionManager, entity.EntPlcyAcadWarnCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyCourseChng>
				if (CanDeepSave(entity.EntPolicyCourseChngCollection, "List<EntPolicyCourseChng>|EntPolicyCourseChngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyCourseChng child in entity.EntPolicyCourseChngCollection)
					{
						if(child.EdBylawIdSource != null)
						{
							child.EdBylawId = child.EdBylawIdSource.EdBylawId;
						}
						else
						{
							child.EdBylawId = entity.EdBylawId;
						}

					}

					if (entity.EntPolicyCourseChngCollection.Count > 0 || entity.EntPolicyCourseChngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyCourseChngProvider.Save(transactionManager, entity.EntPolicyCourseChngCollection);
						
						deepHandles.Add("EntPolicyCourseChngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyCourseChng >) DataRepository.EntPolicyCourseChngProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyCourseChngCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyAssessHdr>
				if (CanDeepSave(entity.EntPolicyAssessHdrCollection, "List<EntPolicyAssessHdr>|EntPolicyAssessHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyAssessHdr child in entity.EntPolicyAssessHdrCollection)
					{
						if(child.EdBylawIdSource != null)
						{
							child.EdBylawId = child.EdBylawIdSource.EdBylawId;
						}
						else
						{
							child.EdBylawId = entity.EdBylawId;
						}

					}

					if (entity.EntPolicyAssessHdrCollection.Count > 0 || entity.EntPolicyAssessHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyAssessHdrProvider.Save(transactionManager, entity.EntPolicyAssessHdrCollection);
						
						deepHandles.Add("EntPolicyAssessHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyAssessHdr >) DataRepository.EntPolicyAssessHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyAssessHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsStateTo>
				if (CanDeepSave(entity.EdStudIntTrnsStateToCollectionGetByEdBylawIdFrom, "List<EdStudIntTrnsStateTo>|EdStudIntTrnsStateToCollectionGetByEdBylawIdFrom", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsStateTo child in entity.EdStudIntTrnsStateToCollectionGetByEdBylawIdFrom)
					{
						if(child.EdBylawIdFromSource != null)
						{
							child.EdBylawIdFrom = child.EdBylawIdFromSource.EdBylawId;
						}
						else
						{
							child.EdBylawIdFrom = entity.EdBylawId;
						}

					}

					if (entity.EdStudIntTrnsStateToCollectionGetByEdBylawIdFrom.Count > 0 || entity.EdStudIntTrnsStateToCollectionGetByEdBylawIdFrom.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsStateToProvider.Save(transactionManager, entity.EdStudIntTrnsStateToCollectionGetByEdBylawIdFrom);
						
						deepHandles.Add("EdStudIntTrnsStateToCollectionGetByEdBylawIdFrom",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsStateTo >) DataRepository.EdStudIntTrnsStateToProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsStateToCollectionGetByEdBylawIdFrom, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyAccumHonor>
				if (CanDeepSave(entity.EntPolicyAccumHonorCollection, "List<EntPolicyAccumHonor>|EntPolicyAccumHonorCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyAccumHonor child in entity.EntPolicyAccumHonorCollection)
					{
						if(child.EdBylawIdSource != null)
						{
							child.EdBylawId = child.EdBylawIdSource.EdBylawId;
						}
						else
						{
							child.EdBylawId = entity.EdBylawId;
						}

					}

					if (entity.EntPolicyAccumHonorCollection.Count > 0 || entity.EntPolicyAccumHonorCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyAccumHonorProvider.Save(transactionManager, entity.EntPolicyAccumHonorCollection);
						
						deepHandles.Add("EntPolicyAccumHonorCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyAccumHonor >) DataRepository.EntPolicyAccumHonorProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyAccumHonorCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdBylawChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdBylaw</c>
	///</summary>
	public enum EdBylawChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsCodeDegree</c> at AsCodeDegreeIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegree))]
		AsCodeDegree,
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		
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
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EntPolicyExcuseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyExcuse>))]
		EntPolicyExcuseCollection,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EntPolicyCourseRepeatCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyCourseRepeat>))]
		EntPolicyCourseRepeatCollection,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EdStudIntTrnsStateToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsStateTo>))]
		EdStudIntTrnsStateToCollectionGetByEdBylawIdTo,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EntPolcyCrsRetakeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolcyCrsRetake>))]
		EntPolcyCrsRetakeCollection,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EntPolicySemHonorCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicySemHonor>))]
		EntPolicySemHonorCollection,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EdStudIntTrnsStateFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsStateFrom>))]
		EdStudIntTrnsStateFromCollectionGetByEdBylawIdFrom,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EntPolcyGrdngHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolcyGrdngHdr>))]
		EntPolcyGrdngHdrCollection,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EntPolcyGpaCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolcyGpa>))]
		EntPolcyGpaCollection,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EntPolicyGradingLevelCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyGradingLevel>))]
		EntPolicyGradingLevelCollection,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EntPolicyAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyAbsence>))]
		EntPolicyAbsenceCollection,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EntPolicyObservedCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyObserved>))]
		EntPolicyObservedCollection,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollection,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EntPolicyLoadCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyLoad>))]
		EntPolicyLoadCollection,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EdStudIntTrnsStateFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsStateFrom>))]
		EdStudIntTrnsStateFromCollectionGetByEdBylawIdTo,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EntPolicyGradingHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyGradingHdr>))]
		EntPolicyGradingHdrCollection,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EntPlcyAcadWarnCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPlcyAcadWarn>))]
		EntPlcyAcadWarnCollection,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EntPolicyCourseChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyCourseChng>))]
		EntPolicyCourseChngCollection,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EntPolicyAssessHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyAssessHdr>))]
		EntPolicyAssessHdrCollection,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EdStudIntTrnsStateToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsStateTo>))]
		EdStudIntTrnsStateToCollectionGetByEdBylawIdFrom,
		///<summary>
		/// Collection of <c>EdBylaw</c> as OneToMany for EntPolicyAccumHonorCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyAccumHonor>))]
		EntPolicyAccumHonorCollection,
	}
	
	#endregion EdBylawChildEntityTypes
	
	#region EdBylawFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdBylawColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdBylaw"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdBylawFilterBuilder : SqlFilterBuilder<EdBylawColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdBylawFilterBuilder class.
		/// </summary>
		public EdBylawFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdBylawFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdBylawFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdBylawFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdBylawFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdBylawFilterBuilder
	
	#region EdBylawParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdBylawColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdBylaw"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdBylawParameterBuilder : ParameterizedSqlFilterBuilder<EdBylawColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdBylawParameterBuilder class.
		/// </summary>
		public EdBylawParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdBylawParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdBylawParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdBylawParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdBylawParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdBylawParameterBuilder
	
	#region EdBylawSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdBylawColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdBylaw"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdBylawSortBuilder : SqlSortBuilder<EdBylawColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdBylawSqlSortBuilder class.
		/// </summary>
		public EdBylawSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdBylawSortBuilder
	
} // end namespace
