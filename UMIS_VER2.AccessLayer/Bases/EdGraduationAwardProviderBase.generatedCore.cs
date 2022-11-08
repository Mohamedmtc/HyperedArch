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
	/// This class is the base class for any <see cref="EdGraduationAwardProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdGraduationAwardProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdGraduationAward, UMIS_VER2.BusinessLyer.EdGraduationAwardKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdGraduationAwardKey key)
		{
			return Delete(transactionManager, key.EdGraduationAwardId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edGraduationAwardId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edGraduationAwardId)
		{
			return Delete(null, _edGraduationAwardId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGraduationAwardId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edGraduationAwardId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE key.
		///		FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public TList<EdGraduationAward> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE key.
		///		FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		/// <remarks></remarks>
		public TList<EdGraduationAward> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE key.
		///		FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public TList<EdGraduationAward> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE key.
		///		fkEdGraduationAwardAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public TList<EdGraduationAward> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE key.
		///		fkEdGraduationAwardAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public TList<EdGraduationAward> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE key.
		///		FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public abstract TList<EdGraduationAward> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public TList<EdGraduationAward> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		/// <remarks></remarks>
		public TList<EdGraduationAward> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public TList<EdGraduationAward> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE_CLASS key.
		///		fkEdGraduationAwardAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public TList<EdGraduationAward> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE_CLASS key.
		///		fkEdGraduationAwardAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public TList<EdGraduationAward> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_GRADUATION_AWARD_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public abstract TList<EdGraduationAward> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_AS_FACULTY_INFO key.
		///		FK_ED_GRADUATION_AWARD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public TList<EdGraduationAward> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_AS_FACULTY_INFO key.
		///		FK_ED_GRADUATION_AWARD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		/// <remarks></remarks>
		public TList<EdGraduationAward> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_AS_FACULTY_INFO key.
		///		FK_ED_GRADUATION_AWARD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public TList<EdGraduationAward> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_AS_FACULTY_INFO key.
		///		fkEdGraduationAwardAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public TList<EdGraduationAward> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_AS_FACULTY_INFO key.
		///		fkEdGraduationAwardAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public TList<EdGraduationAward> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_AS_FACULTY_INFO key.
		///		FK_ED_GRADUATION_AWARD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public abstract TList<EdGraduationAward> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_ED_CODE_SEMESTER key.
		///		FK_ED_GRADUATION_AWARD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public TList<EdGraduationAward> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_ED_CODE_SEMESTER key.
		///		FK_ED_GRADUATION_AWARD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		/// <remarks></remarks>
		public TList<EdGraduationAward> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_ED_CODE_SEMESTER key.
		///		FK_ED_GRADUATION_AWARD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public TList<EdGraduationAward> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_ED_CODE_SEMESTER key.
		///		fkEdGraduationAwardEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public TList<EdGraduationAward> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_ED_CODE_SEMESTER key.
		///		fkEdGraduationAwardEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public TList<EdGraduationAward> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GRADUATION_AWARD_ED_CODE_SEMESTER key.
		///		FK_ED_GRADUATION_AWARD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGraduationAward objects.</returns>
		public abstract TList<EdGraduationAward> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdGraduationAward Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdGraduationAwardKey key, int start, int pageLength)
		{
			return GetByEdGraduationAwardId(transactionManager, key.EdGraduationAwardId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_ACAD_YEAR_ID_3022 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdGraduationAward&gt;"/> class.</returns>
		public TList<EdGraduationAward> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(null,_edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_3022 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdGraduationAward&gt;"/> class.</returns>
		public TList<EdGraduationAward> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_3022 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdGraduationAward&gt;"/> class.</returns>
		public TList<EdGraduationAward> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_3022 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdGraduationAward&gt;"/> class.</returns>
		public TList<EdGraduationAward> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_3022 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdGraduationAward&gt;"/> class.</returns>
		public TList<EdGraduationAward> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_3022 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdGraduationAward&gt;"/> class.</returns>
		public abstract TList<EdGraduationAward> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_UPRESIDE_DECISION index.
		/// </summary>
		/// <param name="_edGraduationAwardId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdGraduationAward GetByEdGraduationAwardId(System.Decimal _edGraduationAwardId)
		{
			int count = -1;
			return GetByEdGraduationAwardId(null,_edGraduationAwardId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_UPRESIDE_DECISION index.
		/// </summary>
		/// <param name="_edGraduationAwardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdGraduationAward GetByEdGraduationAwardId(System.Decimal _edGraduationAwardId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdGraduationAwardId(null, _edGraduationAwardId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_UPRESIDE_DECISION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGraduationAwardId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdGraduationAward GetByEdGraduationAwardId(TransactionManager transactionManager, System.Decimal _edGraduationAwardId)
		{
			int count = -1;
			return GetByEdGraduationAwardId(transactionManager, _edGraduationAwardId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_UPRESIDE_DECISION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGraduationAwardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdGraduationAward GetByEdGraduationAwardId(TransactionManager transactionManager, System.Decimal _edGraduationAwardId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdGraduationAwardId(transactionManager, _edGraduationAwardId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_UPRESIDE_DECISION index.
		/// </summary>
		/// <param name="_edGraduationAwardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdGraduationAward GetByEdGraduationAwardId(System.Decimal _edGraduationAwardId, int start, int pageLength, out int count)
		{
			return GetByEdGraduationAwardId(null, _edGraduationAwardId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_UPRESIDE_DECISION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGraduationAwardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdGraduationAward"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdGraduationAward GetByEdGraduationAwardId(TransactionManager transactionManager, System.Decimal _edGraduationAwardId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_GRADUATION_AWARD index.
		/// </summary>
		/// <param name="_facultyGraduationAwardDate"></param>
		/// <param name="_facultyGraduationAwardNumber"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_presidentApprovalDate">دور</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdGraduationAward GetByFacultyGraduationAwardDateFacultyGraduationAwardNumberAsFacultyInfoIdEdAcadYearIdEdCodeSemesterIdPresidentApprovalDate(System.DateTime? _facultyGraduationAwardDate, System.String _facultyGraduationAwardNumber, System.Decimal? _asFacultyInfoId, System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.DateTime? _presidentApprovalDate)
		{
			int count = -1;
			return GetByFacultyGraduationAwardDateFacultyGraduationAwardNumberAsFacultyInfoIdEdAcadYearIdEdCodeSemesterIdPresidentApprovalDate(null,_facultyGraduationAwardDate, _facultyGraduationAwardNumber, _asFacultyInfoId, _edAcadYearId, _edCodeSemesterId, _presidentApprovalDate, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_GRADUATION_AWARD index.
		/// </summary>
		/// <param name="_facultyGraduationAwardDate"></param>
		/// <param name="_facultyGraduationAwardNumber"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_presidentApprovalDate">دور</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdGraduationAward GetByFacultyGraduationAwardDateFacultyGraduationAwardNumberAsFacultyInfoIdEdAcadYearIdEdCodeSemesterIdPresidentApprovalDate(System.DateTime? _facultyGraduationAwardDate, System.String _facultyGraduationAwardNumber, System.Decimal? _asFacultyInfoId, System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.DateTime? _presidentApprovalDate, int start, int pageLength)
		{
			int count = -1;
			return GetByFacultyGraduationAwardDateFacultyGraduationAwardNumberAsFacultyInfoIdEdAcadYearIdEdCodeSemesterIdPresidentApprovalDate(null, _facultyGraduationAwardDate, _facultyGraduationAwardNumber, _asFacultyInfoId, _edAcadYearId, _edCodeSemesterId, _presidentApprovalDate, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_GRADUATION_AWARD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_facultyGraduationAwardDate"></param>
		/// <param name="_facultyGraduationAwardNumber"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_presidentApprovalDate">دور</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdGraduationAward GetByFacultyGraduationAwardDateFacultyGraduationAwardNumberAsFacultyInfoIdEdAcadYearIdEdCodeSemesterIdPresidentApprovalDate(TransactionManager transactionManager, System.DateTime? _facultyGraduationAwardDate, System.String _facultyGraduationAwardNumber, System.Decimal? _asFacultyInfoId, System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.DateTime? _presidentApprovalDate)
		{
			int count = -1;
			return GetByFacultyGraduationAwardDateFacultyGraduationAwardNumberAsFacultyInfoIdEdAcadYearIdEdCodeSemesterIdPresidentApprovalDate(transactionManager, _facultyGraduationAwardDate, _facultyGraduationAwardNumber, _asFacultyInfoId, _edAcadYearId, _edCodeSemesterId, _presidentApprovalDate, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_GRADUATION_AWARD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_facultyGraduationAwardDate"></param>
		/// <param name="_facultyGraduationAwardNumber"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_presidentApprovalDate">دور</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdGraduationAward GetByFacultyGraduationAwardDateFacultyGraduationAwardNumberAsFacultyInfoIdEdAcadYearIdEdCodeSemesterIdPresidentApprovalDate(TransactionManager transactionManager, System.DateTime? _facultyGraduationAwardDate, System.String _facultyGraduationAwardNumber, System.Decimal? _asFacultyInfoId, System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.DateTime? _presidentApprovalDate, int start, int pageLength)
		{
			int count = -1;
			return GetByFacultyGraduationAwardDateFacultyGraduationAwardNumberAsFacultyInfoIdEdAcadYearIdEdCodeSemesterIdPresidentApprovalDate(transactionManager, _facultyGraduationAwardDate, _facultyGraduationAwardNumber, _asFacultyInfoId, _edAcadYearId, _edCodeSemesterId, _presidentApprovalDate, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_GRADUATION_AWARD index.
		/// </summary>
		/// <param name="_facultyGraduationAwardDate"></param>
		/// <param name="_facultyGraduationAwardNumber"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_presidentApprovalDate">دور</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdGraduationAward GetByFacultyGraduationAwardDateFacultyGraduationAwardNumberAsFacultyInfoIdEdAcadYearIdEdCodeSemesterIdPresidentApprovalDate(System.DateTime? _facultyGraduationAwardDate, System.String _facultyGraduationAwardNumber, System.Decimal? _asFacultyInfoId, System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.DateTime? _presidentApprovalDate, int start, int pageLength, out int count)
		{
			return GetByFacultyGraduationAwardDateFacultyGraduationAwardNumberAsFacultyInfoIdEdAcadYearIdEdCodeSemesterIdPresidentApprovalDate(null, _facultyGraduationAwardDate, _facultyGraduationAwardNumber, _asFacultyInfoId, _edAcadYearId, _edCodeSemesterId, _presidentApprovalDate, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_GRADUATION_AWARD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_facultyGraduationAwardDate"></param>
		/// <param name="_facultyGraduationAwardNumber"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_presidentApprovalDate">دور</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdGraduationAward"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdGraduationAward GetByFacultyGraduationAwardDateFacultyGraduationAwardNumberAsFacultyInfoIdEdAcadYearIdEdCodeSemesterIdPresidentApprovalDate(TransactionManager transactionManager, System.DateTime? _facultyGraduationAwardDate, System.String _facultyGraduationAwardNumber, System.Decimal? _asFacultyInfoId, System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.DateTime? _presidentApprovalDate, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdGraduationAward&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdGraduationAward&gt;"/></returns>
		public static TList<EdGraduationAward> Fill(IDataReader reader, TList<EdGraduationAward> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdGraduationAward c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdGraduationAward")
					.Append("|").Append((System.Decimal)reader["ED_GRADUATION_AWARD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdGraduationAward>(
					key.ToString(), // EntityTrackingKey
					"EdGraduationAward",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdGraduationAward();
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
					c.EdGraduationAwardId = (System.Decimal)reader["ED_GRADUATION_AWARD_ID"];
					c.OriginalEdGraduationAwardId = c.EdGraduationAwardId;
					c.GraduationAwardDate = (System.DateTime)reader["GRADUATION_AWARD_DATE"];
					c.GraduationAwardNumber = (System.String)reader["GRADUATION_AWARD_NUMBER"];
					c.PresidentApprovalDate = Convert.IsDBNull(reader["PRESIDENT_APPROVAL_DATE"]) ? null : (System.DateTime?)reader["PRESIDENT_APPROVAL_DATE"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.IsApplied = (System.Decimal)reader["IS_APPLIED"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.FacultyGraduationAwardNumber = Convert.IsDBNull(reader["FACULTY_GRADUATION_AWARD_NUMBER"]) ? null : (System.String)reader["FACULTY_GRADUATION_AWARD_NUMBER"];
					c.FacultyGraduationAwardDate = Convert.IsDBNull(reader["FACULTY_GRADUATION_AWARD_DATE"]) ? null : (System.DateTime?)reader["FACULTY_GRADUATION_AWARD_DATE"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdGraduationAward"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdGraduationAward"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdGraduationAward entity)
		{
			if (!reader.Read()) return;
			
			entity.EdGraduationAwardId = (System.Decimal)reader[((int)EdGraduationAwardColumn.EdGraduationAwardId - 1)];
			entity.OriginalEdGraduationAwardId = (System.Decimal)reader["ED_GRADUATION_AWARD_ID"];
			entity.GraduationAwardDate = (System.DateTime)reader[((int)EdGraduationAwardColumn.GraduationAwardDate - 1)];
			entity.GraduationAwardNumber = (System.String)reader[((int)EdGraduationAwardColumn.GraduationAwardNumber - 1)];
			entity.PresidentApprovalDate = (reader.IsDBNull(((int)EdGraduationAwardColumn.PresidentApprovalDate - 1)))?null:(System.DateTime?)reader[((int)EdGraduationAwardColumn.PresidentApprovalDate - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdGraduationAwardColumn.Notes - 1)))?null:(System.String)reader[((int)EdGraduationAwardColumn.Notes - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)EdGraduationAwardColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)EdGraduationAwardColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)EdGraduationAwardColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)EdGraduationAwardColumn.EdCodeSemesterId - 1)];
			entity.IsApplied = (System.Decimal)reader[((int)EdGraduationAwardColumn.IsApplied - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdGraduationAwardColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdGraduationAwardColumn.AsFacultyInfoId - 1)];
			entity.FacultyGraduationAwardNumber = (reader.IsDBNull(((int)EdGraduationAwardColumn.FacultyGraduationAwardNumber - 1)))?null:(System.String)reader[((int)EdGraduationAwardColumn.FacultyGraduationAwardNumber - 1)];
			entity.FacultyGraduationAwardDate = (reader.IsDBNull(((int)EdGraduationAwardColumn.FacultyGraduationAwardDate - 1)))?null:(System.DateTime?)reader[((int)EdGraduationAwardColumn.FacultyGraduationAwardDate - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)EdGraduationAwardColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)EdGraduationAwardColumn.AsCodeDegreeClassId - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)EdGraduationAwardColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)EdGraduationAwardColumn.AsCodeDegreeId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdGraduationAwardColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdGraduationAwardColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdGraduationAwardColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdGraduationAwardColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdGraduationAward"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdGraduationAward"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdGraduationAward entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdGraduationAwardId = (System.Decimal)dataRow["ED_GRADUATION_AWARD_ID"];
			entity.OriginalEdGraduationAwardId = (System.Decimal)dataRow["ED_GRADUATION_AWARD_ID"];
			entity.GraduationAwardDate = (System.DateTime)dataRow["GRADUATION_AWARD_DATE"];
			entity.GraduationAwardNumber = (System.String)dataRow["GRADUATION_AWARD_NUMBER"];
			entity.PresidentApprovalDate = Convert.IsDBNull(dataRow["PRESIDENT_APPROVAL_DATE"]) ? null : (System.DateTime?)dataRow["PRESIDENT_APPROVAL_DATE"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.IsApplied = (System.Decimal)dataRow["IS_APPLIED"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.FacultyGraduationAwardNumber = Convert.IsDBNull(dataRow["FACULTY_GRADUATION_AWARD_NUMBER"]) ? null : (System.String)dataRow["FACULTY_GRADUATION_AWARD_NUMBER"];
			entity.FacultyGraduationAwardDate = Convert.IsDBNull(dataRow["FACULTY_GRADUATION_AWARD_DATE"]) ? null : (System.DateTime?)dataRow["FACULTY_GRADUATION_AWARD_DATE"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdGraduationAward"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdGraduationAward Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdGraduationAward entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
				pkItems[0] = (entity.EdAcadYearId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearId ?? 0.0m));		
				
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdGraduationAwardId methods when available
			
			#region GsAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAttchdDoc>|GsAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAttchdDocCollection = DataRepository.GsAttchdDocProvider.GetByEdGraduationAwardId(transactionManager, entity.EdGraduationAwardId);

				if (deep && entity.GsAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAttchdDoc>) DataRepository.GsAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudGraduationAwardCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudGraduationAward>|EdStudGraduationAwardCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudGraduationAwardCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudGraduationAwardCollection = DataRepository.EdStudGraduationAwardProvider.GetByEdGraduationAwardId(transactionManager, entity.EdGraduationAwardId);

				if (deep && entity.EdStudGraduationAwardCollection.Count > 0)
				{
					deepHandles.Add("EdStudGraduationAwardCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGraduationAward>) DataRepository.EdStudGraduationAwardProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGraduationAwardCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdGraduationAward object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdGraduationAward instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdGraduationAward Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdGraduationAward entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCodeSemesterIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterIdSource);
				entity.EdCodeSemesterId = entity.EdCodeSemesterIdSource.EdCodeSemesterId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<GsAttchdDoc>
				if (CanDeepSave(entity.GsAttchdDocCollection, "List<GsAttchdDoc>|GsAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAttchdDoc child in entity.GsAttchdDocCollection)
					{
						if(child.EdGraduationAwardIdSource != null)
						{
							child.EdGraduationAwardId = child.EdGraduationAwardIdSource.EdGraduationAwardId;
						}
						else
						{
							child.EdGraduationAwardId = entity.EdGraduationAwardId;
						}

					}

					if (entity.GsAttchdDocCollection.Count > 0 || entity.GsAttchdDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsAttchdDocProvider.Save(transactionManager, entity.GsAttchdDocCollection);
						
						deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsAttchdDoc >) DataRepository.GsAttchdDocProvider.DeepSave,
							new object[] { transactionManager, entity.GsAttchdDocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudGraduationAward>
				if (CanDeepSave(entity.EdStudGraduationAwardCollection, "List<EdStudGraduationAward>|EdStudGraduationAwardCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudGraduationAward child in entity.EdStudGraduationAwardCollection)
					{
						if(child.EdGraduationAwardIdSource != null)
						{
							child.EdGraduationAwardId = child.EdGraduationAwardIdSource.EdGraduationAwardId;
						}
						else
						{
							child.EdGraduationAwardId = entity.EdGraduationAwardId;
						}

					}

					if (entity.EdStudGraduationAwardCollection.Count > 0 || entity.EdStudGraduationAwardCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudGraduationAwardProvider.Save(transactionManager, entity.EdStudGraduationAwardCollection);
						
						deepHandles.Add("EdStudGraduationAwardCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudGraduationAward >) DataRepository.EdStudGraduationAwardProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudGraduationAwardCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdGraduationAwardChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdGraduationAward</c>
	///</summary>
	public enum EdGraduationAwardChildEntityTypes
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
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		///<summary>
		/// Collection of <c>EdGraduationAward</c> as OneToMany for GsAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAttchdDoc>))]
		GsAttchdDocCollection,
		///<summary>
		/// Collection of <c>EdGraduationAward</c> as OneToMany for EdStudGraduationAwardCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGraduationAward>))]
		EdStudGraduationAwardCollection,
	}
	
	#endregion EdGraduationAwardChildEntityTypes
	
	#region EdGraduationAwardFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdGraduationAwardColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdGraduationAward"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdGraduationAwardFilterBuilder : SqlFilterBuilder<EdGraduationAwardColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdGraduationAwardFilterBuilder class.
		/// </summary>
		public EdGraduationAwardFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdGraduationAwardFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdGraduationAwardFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdGraduationAwardFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdGraduationAwardFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdGraduationAwardFilterBuilder
	
	#region EdGraduationAwardParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdGraduationAwardColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdGraduationAward"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdGraduationAwardParameterBuilder : ParameterizedSqlFilterBuilder<EdGraduationAwardColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdGraduationAwardParameterBuilder class.
		/// </summary>
		public EdGraduationAwardParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdGraduationAwardParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdGraduationAwardParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdGraduationAwardParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdGraduationAwardParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdGraduationAwardParameterBuilder
	
	#region EdGraduationAwardSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdGraduationAwardColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdGraduationAward"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdGraduationAwardSortBuilder : SqlSortBuilder<EdGraduationAwardColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdGraduationAwardSqlSortBuilder class.
		/// </summary>
		public EdGraduationAwardSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdGraduationAwardSortBuilder
	
} // end namespace
