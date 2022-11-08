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
	/// This class is the base class for any <see cref="AdmCodeEngTestProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmCodeEngTestProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmCodeEngTest, UMIS_VER2.BusinessLyer.AdmCodeEngTestKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCodeEngTestKey key)
		{
			return Delete(transactionManager, key.AdmCodeEngTestId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admCodeEngTestId">شهادات انجليش دولية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admCodeEngTestId)
		{
			return Delete(null, _admCodeEngTestId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeEngTestId">شهادات انجليش دولية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admCodeEngTestId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_CODE_ENG_TEST_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="_admCdePlacementExamId">اعفاء من امتحان قبول انجليش داخلى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByAdmCdePlacementExamId(System.Decimal? _admCdePlacementExamId)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(_admCdePlacementExamId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_CODE_ENG_TEST_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId">اعفاء من امتحان قبول انجليش داخلى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCodeEngTest> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal? _admCdePlacementExamId)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(transactionManager, _admCdePlacementExamId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_CODE_ENG_TEST_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId">اعفاء من امتحان قبول انجليش داخلى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal? _admCdePlacementExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(transactionManager, _admCdePlacementExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_ADM_CDE_PLACEMENT_EXAM key.
		///		fkAdmCodeEngTestAdmCdePlacementExam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdePlacementExamId">اعفاء من امتحان قبول انجليش داخلى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByAdmCdePlacementExamId(System.Decimal? _admCdePlacementExamId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdePlacementExamId(null, _admCdePlacementExamId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_ADM_CDE_PLACEMENT_EXAM key.
		///		fkAdmCodeEngTestAdmCdePlacementExam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdePlacementExamId">اعفاء من امتحان قبول انجليش داخلى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByAdmCdePlacementExamId(System.Decimal? _admCdePlacementExamId, int start, int pageLength,out int count)
		{
			return GetByAdmCdePlacementExamId(null, _admCdePlacementExamId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_CODE_ENG_TEST_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId">اعفاء من امتحان قبول انجليش داخلى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public abstract TList<AdmCodeEngTest> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal? _admCdePlacementExamId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE key.
		///		FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId">Master/Dr</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE key.
		///		FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">Master/Dr</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCodeEngTest> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE key.
		///		FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">Master/Dr</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE key.
		///		fkAdmCodeEngTestAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">Master/Dr</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE key.
		///		fkAdmCodeEngTestAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">Master/Dr</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE key.
		///		FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">Master/Dr</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public abstract TList<AdmCodeEngTest> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCodeEngTest> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE_CLASS key.
		///		fkAdmCodeEngTestAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE_CLASS key.
		///		fkAdmCodeEngTestAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_CODE_ENG_TEST_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public abstract TList<AdmCodeEngTest> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_AS_FACULTY_INFO key.
		///		FK_ADM_CODE_ENG_TEST_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId">فى حالة الجامعة=null</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_AS_FACULTY_INFO key.
		///		FK_ADM_CODE_ENG_TEST_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">فى حالة الجامعة=null</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCodeEngTest> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_AS_FACULTY_INFO key.
		///		FK_ADM_CODE_ENG_TEST_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">فى حالة الجامعة=null</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_AS_FACULTY_INFO key.
		///		fkAdmCodeEngTestAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">فى حالة الجامعة=null</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_AS_FACULTY_INFO key.
		///		fkAdmCodeEngTestAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">فى حالة الجامعة=null</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_AS_FACULTY_INFO key.
		///		FK_ADM_CODE_ENG_TEST_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">فى حالة الجامعة=null</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public abstract TList<AdmCodeEngTest> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_ED_COURSE key.
		///		FK_ADM_CODE_ENG_TEST_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId">مقرر الاعفاءXXADM_APP_PLACE_EXAM_COURSE</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByEdCourseId(System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_ED_COURSE key.
		///		FK_ADM_CODE_ENG_TEST_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">مقرر الاعفاءXXADM_APP_PLACE_EXAM_COURSE</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCodeEngTest> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_ED_COURSE key.
		///		FK_ADM_CODE_ENG_TEST_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">مقرر الاعفاءXXADM_APP_PLACE_EXAM_COURSE</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_ED_COURSE key.
		///		fkAdmCodeEngTestEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">مقرر الاعفاءXXADM_APP_PLACE_EXAM_COURSE</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_ED_COURSE key.
		///		fkAdmCodeEngTestEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">مقرر الاعفاءXXADM_APP_PLACE_EXAM_COURSE</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public TList<AdmCodeEngTest> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CODE_ENG_TEST_ED_COURSE key.
		///		FK_ADM_CODE_ENG_TEST_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">مقرر الاعفاءXXADM_APP_PLACE_EXAM_COURSE</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCodeEngTest objects.</returns>
		public abstract TList<AdmCodeEngTest> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmCodeEngTest Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCodeEngTestKey key, int start, int pageLength)
		{
			return GetByAdmCodeEngTestId(transactionManager, key.AdmCodeEngTestId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_CODE_ENG_TEST index.
		/// </summary>
		/// <param name="_admCodeEngTestId">شهادات انجليش دولية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCodeEngTest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCodeEngTest GetByAdmCodeEngTestId(System.Decimal _admCodeEngTestId)
		{
			int count = -1;
			return GetByAdmCodeEngTestId(null,_admCodeEngTestId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CODE_ENG_TEST index.
		/// </summary>
		/// <param name="_admCodeEngTestId">شهادات انجليش دولية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCodeEngTest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCodeEngTest GetByAdmCodeEngTestId(System.Decimal _admCodeEngTestId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCodeEngTestId(null, _admCodeEngTestId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CODE_ENG_TEST index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeEngTestId">شهادات انجليش دولية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCodeEngTest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCodeEngTest GetByAdmCodeEngTestId(TransactionManager transactionManager, System.Decimal _admCodeEngTestId)
		{
			int count = -1;
			return GetByAdmCodeEngTestId(transactionManager, _admCodeEngTestId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CODE_ENG_TEST index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeEngTestId">شهادات انجليش دولية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCodeEngTest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCodeEngTest GetByAdmCodeEngTestId(TransactionManager transactionManager, System.Decimal _admCodeEngTestId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCodeEngTestId(transactionManager, _admCodeEngTestId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CODE_ENG_TEST index.
		/// </summary>
		/// <param name="_admCodeEngTestId">شهادات انجليش دولية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCodeEngTest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCodeEngTest GetByAdmCodeEngTestId(System.Decimal _admCodeEngTestId, int start, int pageLength, out int count)
		{
			return GetByAdmCodeEngTestId(null, _admCodeEngTestId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CODE_ENG_TEST index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeEngTestId">شهادات انجليش دولية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCodeEngTest"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCodeEngTest GetByAdmCodeEngTestId(TransactionManager transactionManager, System.Decimal _admCodeEngTestId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmCodeEngTest&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmCodeEngTest&gt;"/></returns>
		public static TList<AdmCodeEngTest> Fill(IDataReader reader, TList<AdmCodeEngTest> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmCodeEngTest c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmCodeEngTest")
					.Append("|").Append((System.Decimal)reader["ADM_CODE_ENG_TEST_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmCodeEngTest>(
					key.ToString(), // EntityTrackingKey
					"AdmCodeEngTest",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmCodeEngTest();
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
					c.AdmCodeEngTestId = (System.Decimal)reader["ADM_CODE_ENG_TEST_ID"];
					c.OriginalAdmCodeEngTestId = c.AdmCodeEngTestId;
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.DescAr = Convert.IsDBNull(reader["DESC_AR"]) ? null : (System.String)reader["DESC_AR"];
					c.DescEn = Convert.IsDBNull(reader["DESC_EN"]) ? null : (System.String)reader["DESC_EN"];
					c.MinMark = Convert.IsDBNull(reader["MIN_MARK"]) ? null : (System.Decimal?)reader["MIN_MARK"];
					c.MaxMark = Convert.IsDBNull(reader["MAX_MARK"]) ? null : (System.Decimal?)reader["MAX_MARK"];
					c.ExmptMark = Convert.IsDBNull(reader["EXMPT_MARK"]) ? null : (System.Decimal?)reader["EXMPT_MARK"];
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.AdmCdePlacementExamId = Convert.IsDBNull(reader["ADM_CDE_PLACEMENT_EXAM_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_PLACEMENT_EXAM_ID"];
					c.ValidPeriod = Convert.IsDBNull(reader["VALID_PERIOD"]) ? null : (System.Int16?)reader["VALID_PERIOD"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCodeEngTest"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCodeEngTest"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmCodeEngTest entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmCodeEngTestId = (System.Decimal)reader[((int)AdmCodeEngTestColumn.AdmCodeEngTestId - 1)];
			entity.OriginalAdmCodeEngTestId = (System.Decimal)reader["ADM_CODE_ENG_TEST_ID"];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)AdmCodeEngTestColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)AdmCodeEngTestColumn.AsFacultyInfoId - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)AdmCodeEngTestColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)AdmCodeEngTestColumn.AsCodeDegreeClassId - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)AdmCodeEngTestColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)AdmCodeEngTestColumn.AsCodeDegreeId - 1)];
			entity.DescAr = (reader.IsDBNull(((int)AdmCodeEngTestColumn.DescAr - 1)))?null:(System.String)reader[((int)AdmCodeEngTestColumn.DescAr - 1)];
			entity.DescEn = (reader.IsDBNull(((int)AdmCodeEngTestColumn.DescEn - 1)))?null:(System.String)reader[((int)AdmCodeEngTestColumn.DescEn - 1)];
			entity.MinMark = (reader.IsDBNull(((int)AdmCodeEngTestColumn.MinMark - 1)))?null:(System.Decimal?)reader[((int)AdmCodeEngTestColumn.MinMark - 1)];
			entity.MaxMark = (reader.IsDBNull(((int)AdmCodeEngTestColumn.MaxMark - 1)))?null:(System.Decimal?)reader[((int)AdmCodeEngTestColumn.MaxMark - 1)];
			entity.ExmptMark = (reader.IsDBNull(((int)AdmCodeEngTestColumn.ExmptMark - 1)))?null:(System.Decimal?)reader[((int)AdmCodeEngTestColumn.ExmptMark - 1)];
			entity.EdCourseId = (reader.IsDBNull(((int)AdmCodeEngTestColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)AdmCodeEngTestColumn.EdCourseId - 1)];
			entity.AdmCdePlacementExamId = (reader.IsDBNull(((int)AdmCodeEngTestColumn.AdmCdePlacementExamId - 1)))?null:(System.Decimal?)reader[((int)AdmCodeEngTestColumn.AdmCdePlacementExamId - 1)];
			entity.ValidPeriod = (reader.IsDBNull(((int)AdmCodeEngTestColumn.ValidPeriod - 1)))?null:(System.Int16?)reader[((int)AdmCodeEngTestColumn.ValidPeriod - 1)];
			entity.ForeignFlg = (reader.IsDBNull(((int)AdmCodeEngTestColumn.ForeignFlg - 1)))?null:(System.Decimal?)reader[((int)AdmCodeEngTestColumn.ForeignFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmCodeEngTestColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmCodeEngTestColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmCodeEngTestColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmCodeEngTestColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCodeEngTest"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCodeEngTest"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmCodeEngTest entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmCodeEngTestId = (System.Decimal)dataRow["ADM_CODE_ENG_TEST_ID"];
			entity.OriginalAdmCodeEngTestId = (System.Decimal)dataRow["ADM_CODE_ENG_TEST_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
			entity.DescAr = Convert.IsDBNull(dataRow["DESC_AR"]) ? null : (System.String)dataRow["DESC_AR"];
			entity.DescEn = Convert.IsDBNull(dataRow["DESC_EN"]) ? null : (System.String)dataRow["DESC_EN"];
			entity.MinMark = Convert.IsDBNull(dataRow["MIN_MARK"]) ? null : (System.Decimal?)dataRow["MIN_MARK"];
			entity.MaxMark = Convert.IsDBNull(dataRow["MAX_MARK"]) ? null : (System.Decimal?)dataRow["MAX_MARK"];
			entity.ExmptMark = Convert.IsDBNull(dataRow["EXMPT_MARK"]) ? null : (System.Decimal?)dataRow["EXMPT_MARK"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.AdmCdePlacementExamId = Convert.IsDBNull(dataRow["ADM_CDE_PLACEMENT_EXAM_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_PLACEMENT_EXAM_ID"];
			entity.ValidPeriod = Convert.IsDBNull(dataRow["VALID_PERIOD"]) ? null : (System.Int16?)dataRow["VALID_PERIOD"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCodeEngTest"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCodeEngTest Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCodeEngTest entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmCodeEngTestId methods when available
			
			#region AdmEnglishProficiencyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmEnglishProficiency>|AdmEnglishProficiencyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmEnglishProficiencyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmEnglishProficiencyCollection = DataRepository.AdmEnglishProficiencyProvider.GetByAdmCodeEngTestId(transactionManager, entity.AdmCodeEngTestId);

				if (deep && entity.AdmEnglishProficiencyCollection.Count > 0)
				{
					deepHandles.Add("AdmEnglishProficiencyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmEnglishProficiency>) DataRepository.AdmEnglishProficiencyProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmEnglishProficiencyCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmCodeEngTest object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmCodeEngTest instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCodeEngTest Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCodeEngTest entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmEnglishProficiency>
				if (CanDeepSave(entity.AdmEnglishProficiencyCollection, "List<AdmEnglishProficiency>|AdmEnglishProficiencyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmEnglishProficiency child in entity.AdmEnglishProficiencyCollection)
					{
						if(child.AdmCodeEngTestIdSource != null)
						{
							child.AdmCodeEngTestId = child.AdmCodeEngTestIdSource.AdmCodeEngTestId;
						}
						else
						{
							child.AdmCodeEngTestId = entity.AdmCodeEngTestId;
						}

					}

					if (entity.AdmEnglishProficiencyCollection.Count > 0 || entity.AdmEnglishProficiencyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmEnglishProficiencyProvider.Save(transactionManager, entity.AdmEnglishProficiencyCollection);
						
						deepHandles.Add("AdmEnglishProficiencyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmEnglishProficiency >) DataRepository.AdmEnglishProficiencyProvider.DeepSave,
							new object[] { transactionManager, entity.AdmEnglishProficiencyCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmCodeEngTestChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmCodeEngTest</c>
	///</summary>
	public enum AdmCodeEngTestChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCdePlacementExam</c> at AdmCdePlacementExamIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdePlacementExam))]
		AdmCdePlacementExam,
		
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
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		///<summary>
		/// Collection of <c>AdmCodeEngTest</c> as OneToMany for AdmEnglishProficiencyCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmEnglishProficiency>))]
		AdmEnglishProficiencyCollection,
	}
	
	#endregion AdmCodeEngTestChildEntityTypes
	
	#region AdmCodeEngTestFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmCodeEngTestColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCodeEngTest"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCodeEngTestFilterBuilder : SqlFilterBuilder<AdmCodeEngTestColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCodeEngTestFilterBuilder class.
		/// </summary>
		public AdmCodeEngTestFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCodeEngTestFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCodeEngTestFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCodeEngTestFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCodeEngTestFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCodeEngTestFilterBuilder
	
	#region AdmCodeEngTestParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmCodeEngTestColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCodeEngTest"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCodeEngTestParameterBuilder : ParameterizedSqlFilterBuilder<AdmCodeEngTestColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCodeEngTestParameterBuilder class.
		/// </summary>
		public AdmCodeEngTestParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCodeEngTestParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCodeEngTestParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCodeEngTestParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCodeEngTestParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCodeEngTestParameterBuilder
	
	#region AdmCodeEngTestSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmCodeEngTestColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCodeEngTest"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmCodeEngTestSortBuilder : SqlSortBuilder<AdmCodeEngTestColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCodeEngTestSqlSortBuilder class.
		/// </summary>
		public AdmCodeEngTestSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmCodeEngTestSortBuilder
	
} // end namespace
