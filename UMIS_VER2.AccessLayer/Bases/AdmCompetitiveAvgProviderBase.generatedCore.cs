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
	/// This class is the base class for any <see cref="AdmCompetitiveAvgProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmCompetitiveAvgProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmCompetitiveAvg, UMIS_VER2.BusinessLyer.AdmCompetitiveAvgKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCompetitiveAvgKey key)
		{
			return Delete(transactionManager, key.AdmCompetitiveAvgId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admCompetitiveAvgId">شروط المعدل التنافسي. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admCompetitiveAvgId)
		{
			return Delete(null, _admCompetitiveAvgId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCompetitiveAvgId">شروط المعدل التنافسي. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admCompetitiveAvgId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_COMPETITIVE_AVG_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="_admCdePlacementExamId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAdmCdePlacementExamId(System.Decimal? _admCdePlacementExamId)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(_admCdePlacementExamId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_COMPETITIVE_AVG_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCompetitiveAvg> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal? _admCdePlacementExamId)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(transactionManager, _admCdePlacementExamId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_COMPETITIVE_AVG_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal? _admCdePlacementExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(transactionManager, _admCdePlacementExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_ADM_CDE_PLACEMENT_EXAM key.
		///		fkAdmCompetitiveAvgAdmCdePlacementExam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAdmCdePlacementExamId(System.Decimal? _admCdePlacementExamId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdePlacementExamId(null, _admCdePlacementExamId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_ADM_CDE_PLACEMENT_EXAM key.
		///		fkAdmCompetitiveAvgAdmCdePlacementExam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAdmCdePlacementExamId(System.Decimal? _admCdePlacementExamId, int start, int pageLength,out int count)
		{
			return GetByAdmCdePlacementExamId(null, _admCdePlacementExamId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_COMPETITIVE_AVG_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public abstract TList<AdmCompetitiveAvg> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal? _admCdePlacementExamId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_COMPETITIVE_AVG_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAdmOpenAcadSemesterId(System.Decimal _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(_admOpenAcadSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_COMPETITIVE_AVG_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCompetitiveAvg> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_COMPETITIVE_AVG_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_ADM_OPEN_ACAD_SEMESTER key.
		///		fkAdmCompetitiveAvgAdmOpenAcadSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAdmOpenAcadSemesterId(System.Decimal _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_ADM_OPEN_ACAD_SEMESTER key.
		///		fkAdmCompetitiveAvgAdmOpenAcadSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAdmOpenAcadSemesterId(System.Decimal _admOpenAcadSemesterId, int start, int pageLength,out int count)
		{
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_COMPETITIVE_AVG_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public abstract TList<AdmCompetitiveAvg> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE key.
		///		FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE key.
		///		FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCompetitiveAvg> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE key.
		///		FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE key.
		///		fkAdmCompetitiveAvgAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE key.
		///		fkAdmCompetitiveAvgAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE key.
		///		FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public abstract TList<AdmCompetitiveAvg> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCompetitiveAvg> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE_CLASS key.
		///		fkAdmCompetitiveAvgAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE_CLASS key.
		///		fkAdmCompetitiveAvgAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_COMPETITIVE_AVG_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public abstract TList<AdmCompetitiveAvg> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_AS_FACULTY_INFO key.
		///		FK_ADM_COMPETITIVE_AVG_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId">فى حالة الجامعة=null</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_AS_FACULTY_INFO key.
		///		FK_ADM_COMPETITIVE_AVG_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">فى حالة الجامعة=null</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCompetitiveAvg> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_AS_FACULTY_INFO key.
		///		FK_ADM_COMPETITIVE_AVG_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">فى حالة الجامعة=null</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_AS_FACULTY_INFO key.
		///		fkAdmCompetitiveAvgAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">فى حالة الجامعة=null</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_AS_FACULTY_INFO key.
		///		fkAdmCompetitiveAvgAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">فى حالة الجامعة=null</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public TList<AdmCompetitiveAvg> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_COMPETITIVE_AVG_AS_FACULTY_INFO key.
		///		FK_ADM_COMPETITIVE_AVG_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">فى حالة الجامعة=null</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCompetitiveAvg objects.</returns>
		public abstract TList<AdmCompetitiveAvg> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmCompetitiveAvg Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCompetitiveAvgKey key, int start, int pageLength)
		{
			return GetByAdmCompetitiveAvgId(transactionManager, key.AdmCompetitiveAvgId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_COMPETITIVE_AVG index.
		/// </summary>
		/// <param name="_admCompetitiveAvgId">شروط المعدل التنافسي</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCompetitiveAvg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCompetitiveAvg GetByAdmCompetitiveAvgId(System.Decimal _admCompetitiveAvgId)
		{
			int count = -1;
			return GetByAdmCompetitiveAvgId(null,_admCompetitiveAvgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_COMPETITIVE_AVG index.
		/// </summary>
		/// <param name="_admCompetitiveAvgId">شروط المعدل التنافسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCompetitiveAvg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCompetitiveAvg GetByAdmCompetitiveAvgId(System.Decimal _admCompetitiveAvgId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCompetitiveAvgId(null, _admCompetitiveAvgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_COMPETITIVE_AVG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCompetitiveAvgId">شروط المعدل التنافسي</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCompetitiveAvg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCompetitiveAvg GetByAdmCompetitiveAvgId(TransactionManager transactionManager, System.Decimal _admCompetitiveAvgId)
		{
			int count = -1;
			return GetByAdmCompetitiveAvgId(transactionManager, _admCompetitiveAvgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_COMPETITIVE_AVG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCompetitiveAvgId">شروط المعدل التنافسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCompetitiveAvg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCompetitiveAvg GetByAdmCompetitiveAvgId(TransactionManager transactionManager, System.Decimal _admCompetitiveAvgId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCompetitiveAvgId(transactionManager, _admCompetitiveAvgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_COMPETITIVE_AVG index.
		/// </summary>
		/// <param name="_admCompetitiveAvgId">شروط المعدل التنافسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCompetitiveAvg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCompetitiveAvg GetByAdmCompetitiveAvgId(System.Decimal _admCompetitiveAvgId, int start, int pageLength, out int count)
		{
			return GetByAdmCompetitiveAvgId(null, _admCompetitiveAvgId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_COMPETITIVE_AVG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCompetitiveAvgId">شروط المعدل التنافسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCompetitiveAvg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCompetitiveAvg GetByAdmCompetitiveAvgId(TransactionManager transactionManager, System.Decimal _admCompetitiveAvgId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmCompetitiveAvg&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmCompetitiveAvg&gt;"/></returns>
		public static TList<AdmCompetitiveAvg> Fill(IDataReader reader, TList<AdmCompetitiveAvg> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmCompetitiveAvg c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmCompetitiveAvg")
					.Append("|").Append((System.Decimal)reader["ADM_COMPETITIVE_AVG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmCompetitiveAvg>(
					key.ToString(), // EntityTrackingKey
					"AdmCompetitiveAvg",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmCompetitiveAvg();
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
					c.AdmCompetitiveAvgId = (System.Decimal)reader["ADM_COMPETITIVE_AVG_ID"];
					c.OriginalAdmCompetitiveAvgId = c.AdmCompetitiveAvgId;
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.AsCodeDegreeClassId = (System.Decimal)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.AdmCdePlacementExamId = Convert.IsDBNull(reader["ADM_CDE_PLACEMENT_EXAM_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_PLACEMENT_EXAM_ID"];
					c.Percentage = Convert.IsDBNull(reader["PERCENTAGE"]) ? null : (System.Decimal?)reader["PERCENTAGE"];
					c.CertficateFlg = (System.Decimal)reader["CERTFICATE_FLG"];
					c.AdmOpenAcadSemesterId = (System.Decimal)reader["ADM_OPEN_ACAD_SEMESTER_ID"];
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.ForeignFlg = Convert.IsDBNull(reader["FOREIGN_FLG"]) ? null : (System.Decimal?)reader["FOREIGN_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCompetitiveAvg"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCompetitiveAvg"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmCompetitiveAvg entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmCompetitiveAvgId = (System.Decimal)reader[((int)AdmCompetitiveAvgColumn.AdmCompetitiveAvgId - 1)];
			entity.OriginalAdmCompetitiveAvgId = (System.Decimal)reader["ADM_COMPETITIVE_AVG_ID"];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)AdmCompetitiveAvgColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)AdmCompetitiveAvgColumn.AsFacultyInfoId - 1)];
			entity.AsCodeDegreeClassId = (System.Decimal)reader[((int)AdmCompetitiveAvgColumn.AsCodeDegreeClassId - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)AdmCompetitiveAvgColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)AdmCompetitiveAvgColumn.AsCodeDegreeId - 1)];
			entity.AdmCdePlacementExamId = (reader.IsDBNull(((int)AdmCompetitiveAvgColumn.AdmCdePlacementExamId - 1)))?null:(System.Decimal?)reader[((int)AdmCompetitiveAvgColumn.AdmCdePlacementExamId - 1)];
			entity.Percentage = (reader.IsDBNull(((int)AdmCompetitiveAvgColumn.Percentage - 1)))?null:(System.Decimal?)reader[((int)AdmCompetitiveAvgColumn.Percentage - 1)];
			entity.CertficateFlg = (System.Decimal)reader[((int)AdmCompetitiveAvgColumn.CertficateFlg - 1)];
			entity.AdmOpenAcadSemesterId = (System.Decimal)reader[((int)AdmCompetitiveAvgColumn.AdmOpenAcadSemesterId - 1)];
			entity.DescrAr = (reader.IsDBNull(((int)AdmCompetitiveAvgColumn.DescrAr - 1)))?null:(System.String)reader[((int)AdmCompetitiveAvgColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)AdmCompetitiveAvgColumn.DescrEn - 1)))?null:(System.String)reader[((int)AdmCompetitiveAvgColumn.DescrEn - 1)];
			entity.ForeignFlg = (reader.IsDBNull(((int)AdmCompetitiveAvgColumn.ForeignFlg - 1)))?null:(System.Decimal?)reader[((int)AdmCompetitiveAvgColumn.ForeignFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmCompetitiveAvgColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmCompetitiveAvgColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmCompetitiveAvgColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmCompetitiveAvgColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCompetitiveAvg"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCompetitiveAvg"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmCompetitiveAvg entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmCompetitiveAvgId = (System.Decimal)dataRow["ADM_COMPETITIVE_AVG_ID"];
			entity.OriginalAdmCompetitiveAvgId = (System.Decimal)dataRow["ADM_COMPETITIVE_AVG_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.AsCodeDegreeClassId = (System.Decimal)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
			entity.AdmCdePlacementExamId = Convert.IsDBNull(dataRow["ADM_CDE_PLACEMENT_EXAM_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_PLACEMENT_EXAM_ID"];
			entity.Percentage = Convert.IsDBNull(dataRow["PERCENTAGE"]) ? null : (System.Decimal?)dataRow["PERCENTAGE"];
			entity.CertficateFlg = (System.Decimal)dataRow["CERTFICATE_FLG"];
			entity.AdmOpenAcadSemesterId = (System.Decimal)dataRow["ADM_OPEN_ACAD_SEMESTER_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.ForeignFlg = Convert.IsDBNull(dataRow["FOREIGN_FLG"]) ? null : (System.Decimal?)dataRow["FOREIGN_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCompetitiveAvg"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCompetitiveAvg Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCompetitiveAvg entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmCdePlacementExamIdSource	
			if (CanDeepLoad(entity, "AdmCdePlacementExam|AdmCdePlacementExamIdSource", deepLoadType, innerList) 
				&& entity.AdmCdePlacementExamIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdePlacementExamId ?? 0.0m);
				AdmCdePlacementExam tmpEntity = EntityManager.LocateEntity<AdmCdePlacementExam>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdePlacementExam), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdePlacementExamIdSource = tmpEntity;
				else
					entity.AdmCdePlacementExamIdSource = DataRepository.AdmCdePlacementExamProvider.GetByAdmCdePlacementExamId(transactionManager, (entity.AdmCdePlacementExamId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdePlacementExamIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdePlacementExamIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdePlacementExamProvider.DeepLoad(transactionManager, entity.AdmCdePlacementExamIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdePlacementExamIdSource

			#region AdmOpenAcadSemesterIdSource	
			if (CanDeepLoad(entity, "AdmOpenAcadSemester|AdmOpenAcadSemesterIdSource", deepLoadType, innerList) 
				&& entity.AdmOpenAcadSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmOpenAcadSemesterId;
				AdmOpenAcadSemester tmpEntity = EntityManager.LocateEntity<AdmOpenAcadSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmOpenAcadSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmOpenAcadSemesterIdSource = tmpEntity;
				else
					entity.AdmOpenAcadSemesterIdSource = DataRepository.AdmOpenAcadSemesterProvider.GetByAdmOpenAcadSemesterId(transactionManager, entity.AdmOpenAcadSemesterId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmOpenAcadSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmOpenAcadSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmOpenAcadSemesterProvider.DeepLoad(transactionManager, entity.AdmOpenAcadSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmOpenAcadSemesterIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmCompetitiveAvg object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmCompetitiveAvg instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCompetitiveAvg Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCompetitiveAvg entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCdePlacementExamIdSource
			if (CanDeepSave(entity, "AdmCdePlacementExam|AdmCdePlacementExamIdSource", deepSaveType, innerList) 
				&& entity.AdmCdePlacementExamIdSource != null)
			{
				DataRepository.AdmCdePlacementExamProvider.Save(transactionManager, entity.AdmCdePlacementExamIdSource);
				entity.AdmCdePlacementExamId = entity.AdmCdePlacementExamIdSource.AdmCdePlacementExamId;
			}
			#endregion 
			
			#region AdmOpenAcadSemesterIdSource
			if (CanDeepSave(entity, "AdmOpenAcadSemester|AdmOpenAcadSemesterIdSource", deepSaveType, innerList) 
				&& entity.AdmOpenAcadSemesterIdSource != null)
			{
				DataRepository.AdmOpenAcadSemesterProvider.Save(transactionManager, entity.AdmOpenAcadSemesterIdSource);
				entity.AdmOpenAcadSemesterId = entity.AdmOpenAcadSemesterIdSource.AdmOpenAcadSemesterId;
			}
			#endregion 
			
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
	
	#region AdmCompetitiveAvgChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmCompetitiveAvg</c>
	///</summary>
	public enum AdmCompetitiveAvgChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCdePlacementExam</c> at AdmCdePlacementExamIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdePlacementExam))]
		AdmCdePlacementExam,
		
		///<summary>
		/// Composite Property for <c>AdmOpenAcadSemester</c> at AdmOpenAcadSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(AdmOpenAcadSemester))]
		AdmOpenAcadSemester,
		
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
	}
	
	#endregion AdmCompetitiveAvgChildEntityTypes
	
	#region AdmCompetitiveAvgFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmCompetitiveAvgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCompetitiveAvg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCompetitiveAvgFilterBuilder : SqlFilterBuilder<AdmCompetitiveAvgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCompetitiveAvgFilterBuilder class.
		/// </summary>
		public AdmCompetitiveAvgFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCompetitiveAvgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCompetitiveAvgFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCompetitiveAvgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCompetitiveAvgFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCompetitiveAvgFilterBuilder
	
	#region AdmCompetitiveAvgParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmCompetitiveAvgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCompetitiveAvg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCompetitiveAvgParameterBuilder : ParameterizedSqlFilterBuilder<AdmCompetitiveAvgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCompetitiveAvgParameterBuilder class.
		/// </summary>
		public AdmCompetitiveAvgParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCompetitiveAvgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCompetitiveAvgParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCompetitiveAvgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCompetitiveAvgParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCompetitiveAvgParameterBuilder
	
	#region AdmCompetitiveAvgSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmCompetitiveAvgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCompetitiveAvg"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmCompetitiveAvgSortBuilder : SqlSortBuilder<AdmCompetitiveAvgColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCompetitiveAvgSqlSortBuilder class.
		/// </summary>
		public AdmCompetitiveAvgSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmCompetitiveAvgSortBuilder
	
} // end namespace
