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
	/// This class is the base class for any <see cref="AdmPrecondQualProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmPrecondQualProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmPrecondQual, UMIS_VER2.BusinessLyer.AdmPrecondQualKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPrecondQualKey key)
		{
			return Delete(transactionManager, key.AdmPrecondQualId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admPrecondQualId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admPrecondQualId)
		{
			return Delete(null, _admPrecondQualId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPrecondQualId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admPrecondQualId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_PRECOND_QUAL_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="_admCdeExamGrdngId">NU:PG QUAL GRADE</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByAdmCdeExamGrdngId(System.Decimal? _admCdeExamGrdngId)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(_admCdeExamGrdngId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_PRECOND_QUAL_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId">NU:PG QUAL GRADE</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPrecondQual> GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamGrdngId)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(transactionManager, _admCdeExamGrdngId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_PRECOND_QUAL_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId">NU:PG QUAL GRADE</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamGrdngId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(transactionManager, _admCdeExamGrdngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_ADM_CDE_EXAM_GRDNG key.
		///		fkAdmPrecondQualAdmCdeExamGrdng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeExamGrdngId">NU:PG QUAL GRADE</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByAdmCdeExamGrdngId(System.Decimal? _admCdeExamGrdngId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeExamGrdngId(null, _admCdeExamGrdngId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_ADM_CDE_EXAM_GRDNG key.
		///		fkAdmPrecondQualAdmCdeExamGrdng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeExamGrdngId">NU:PG QUAL GRADE</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByAdmCdeExamGrdngId(System.Decimal? _admCdeExamGrdngId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeExamGrdngId(null, _admCdeExamGrdngId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_PRECOND_QUAL_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId">NU:PG QUAL GRADE</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public abstract TList<AdmPrecondQual> GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamGrdngId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE key.
		///		FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE key.
		///		FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPrecondQual> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE key.
		///		FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE key.
		///		fkAdmPrecondQualAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE key.
		///		fkAdmPrecondQualAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE key.
		///		FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public abstract TList<AdmPrecondQual> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPrecondQual> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE_CLASS key.
		///		fkAdmPrecondQualAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE_CLASS key.
		///		fkAdmPrecondQualAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_PRECOND_QUAL_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public abstract TList<AdmPrecondQual> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_AS_FACULTY_INFO key.
		///		FK_ADM_PRECOND_QUAL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_AS_FACULTY_INFO key.
		///		FK_ADM_PRECOND_QUAL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPrecondQual> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_AS_FACULTY_INFO key.
		///		FK_ADM_PRECOND_QUAL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_AS_FACULTY_INFO key.
		///		fkAdmPrecondQualAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_AS_FACULTY_INFO key.
		///		fkAdmPrecondQualAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_AS_FACULTY_INFO key.
		///		FK_ADM_PRECOND_QUAL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public abstract TList<AdmPrecondQual> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_ED_CDE_QUAL_BRN key.
		///		FK_ADM_PRECOND_QUAL_ED_CDE_QUAL_BRN Description: 
		/// </summary>
		/// <param name="_edCdeQualBrnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByEdCdeQualBrnId(System.Decimal? _edCdeQualBrnId)
		{
			int count = -1;
			return GetByEdCdeQualBrnId(_edCdeQualBrnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_ED_CDE_QUAL_BRN key.
		///		FK_ADM_PRECOND_QUAL_ED_CDE_QUAL_BRN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualBrnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPrecondQual> GetByEdCdeQualBrnId(TransactionManager transactionManager, System.Decimal? _edCdeQualBrnId)
		{
			int count = -1;
			return GetByEdCdeQualBrnId(transactionManager, _edCdeQualBrnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_ED_CDE_QUAL_BRN key.
		///		FK_ADM_PRECOND_QUAL_ED_CDE_QUAL_BRN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualBrnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByEdCdeQualBrnId(TransactionManager transactionManager, System.Decimal? _edCdeQualBrnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeQualBrnId(transactionManager, _edCdeQualBrnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_ED_CDE_QUAL_BRN key.
		///		fkAdmPrecondQualEdCdeQualBrn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeQualBrnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByEdCdeQualBrnId(System.Decimal? _edCdeQualBrnId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeQualBrnId(null, _edCdeQualBrnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_ED_CDE_QUAL_BRN key.
		///		fkAdmPrecondQualEdCdeQualBrn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeQualBrnId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByEdCdeQualBrnId(System.Decimal? _edCdeQualBrnId, int start, int pageLength,out int count)
		{
			return GetByEdCdeQualBrnId(null, _edCdeQualBrnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_ED_CDE_QUAL_BRN key.
		///		FK_ADM_PRECOND_QUAL_ED_CDE_QUAL_BRN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualBrnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public abstract TList<AdmPrecondQual> GetByEdCdeQualBrnId(TransactionManager transactionManager, System.Decimal? _edCdeQualBrnId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_ED_CODE_QUAL key.
		///		FK_ADM_PRECOND_QUAL_ED_CODE_QUAL Description: 
		/// </summary>
		/// <param name="_edCodeQualId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByEdCodeQualId(System.Decimal? _edCodeQualId)
		{
			int count = -1;
			return GetByEdCodeQualId(_edCodeQualId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_ED_CODE_QUAL key.
		///		FK_ADM_PRECOND_QUAL_ED_CODE_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPrecondQual> GetByEdCodeQualId(TransactionManager transactionManager, System.Decimal? _edCodeQualId)
		{
			int count = -1;
			return GetByEdCodeQualId(transactionManager, _edCodeQualId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_ED_CODE_QUAL key.
		///		FK_ADM_PRECOND_QUAL_ED_CODE_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByEdCodeQualId(TransactionManager transactionManager, System.Decimal? _edCodeQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeQualId(transactionManager, _edCodeQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_ED_CODE_QUAL key.
		///		fkAdmPrecondQualEdCodeQual Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByEdCodeQualId(System.Decimal? _edCodeQualId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeQualId(null, _edCodeQualId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_ED_CODE_QUAL key.
		///		fkAdmPrecondQualEdCodeQual Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByEdCodeQualId(System.Decimal? _edCodeQualId, int start, int pageLength,out int count)
		{
			return GetByEdCodeQualId(null, _edCodeQualId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_ED_CODE_QUAL key.
		///		FK_ADM_PRECOND_QUAL_ED_CODE_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public abstract TList<AdmPrecondQual> GetByEdCodeQualId(TransactionManager transactionManager, System.Decimal? _edCodeQualId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_GS_COUNTRY_NODE key.
		///		FK_ADM_PRECOND_QUAL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByGsCountryNodeInfoId(System.Decimal? _gsCountryNodeInfoId)
		{
			int count = -1;
			return GetByGsCountryNodeInfoId(_gsCountryNodeInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_GS_COUNTRY_NODE key.
		///		FK_ADM_PRECOND_QUAL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPrecondQual> GetByGsCountryNodeInfoId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeInfoId)
		{
			int count = -1;
			return GetByGsCountryNodeInfoId(transactionManager, _gsCountryNodeInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_GS_COUNTRY_NODE key.
		///		FK_ADM_PRECOND_QUAL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByGsCountryNodeInfoId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeInfoId(transactionManager, _gsCountryNodeInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_GS_COUNTRY_NODE key.
		///		fkAdmPrecondQualGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByGsCountryNodeInfoId(System.Decimal? _gsCountryNodeInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeInfoId(null, _gsCountryNodeInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_GS_COUNTRY_NODE key.
		///		fkAdmPrecondQualGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public TList<AdmPrecondQual> GetByGsCountryNodeInfoId(System.Decimal? _gsCountryNodeInfoId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeInfoId(null, _gsCountryNodeInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PRECOND_QUAL_GS_COUNTRY_NODE key.
		///		FK_ADM_PRECOND_QUAL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPrecondQual objects.</returns>
		public abstract TList<AdmPrecondQual> GetByGsCountryNodeInfoId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeInfoId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmPrecondQual Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPrecondQualKey key, int start, int pageLength)
		{
			return GetByAdmPrecondQualId(transactionManager, key.AdmPrecondQualId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmPrecondQual&gt;"/> class.</returns>
		public TList<AdmPrecondQual> GetByEntMainId(System.Decimal? _entMainId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmPrecondQual&gt;"/> class.</returns>
		public TList<AdmPrecondQual> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmPrecondQual&gt;"/> class.</returns>
		public TList<AdmPrecondQual> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmPrecondQual&gt;"/> class.</returns>
		public TList<AdmPrecondQual> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmPrecondQual&gt;"/> class.</returns>
		public TList<AdmPrecondQual> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmPrecondQual&gt;"/> class.</returns>
		public abstract TList<AdmPrecondQual> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_PRECOND_QUAL index.
		/// </summary>
		/// <param name="_admPrecondQualId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPrecondQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPrecondQual GetByAdmPrecondQualId(System.Decimal _admPrecondQualId)
		{
			int count = -1;
			return GetByAdmPrecondQualId(null,_admPrecondQualId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PRECOND_QUAL index.
		/// </summary>
		/// <param name="_admPrecondQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPrecondQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPrecondQual GetByAdmPrecondQualId(System.Decimal _admPrecondQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmPrecondQualId(null, _admPrecondQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PRECOND_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPrecondQualId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPrecondQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPrecondQual GetByAdmPrecondQualId(TransactionManager transactionManager, System.Decimal _admPrecondQualId)
		{
			int count = -1;
			return GetByAdmPrecondQualId(transactionManager, _admPrecondQualId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PRECOND_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPrecondQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPrecondQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPrecondQual GetByAdmPrecondQualId(TransactionManager transactionManager, System.Decimal _admPrecondQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmPrecondQualId(transactionManager, _admPrecondQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PRECOND_QUAL index.
		/// </summary>
		/// <param name="_admPrecondQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPrecondQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPrecondQual GetByAdmPrecondQualId(System.Decimal _admPrecondQualId, int start, int pageLength, out int count)
		{
			return GetByAdmPrecondQualId(null, _admPrecondQualId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PRECOND_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPrecondQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPrecondQual"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmPrecondQual GetByAdmPrecondQualId(TransactionManager transactionManager, System.Decimal _admPrecondQualId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ADM_PRECOND_QUAL index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="_admPrecondQualId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPrecondQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPrecondQual GetByEntMainIdAdmPrecondQualId(System.Decimal? _entMainId, System.Decimal _admPrecondQualId)
		{
			int count = -1;
			return GetByEntMainIdAdmPrecondQualId(null,_entMainId, _admPrecondQualId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_PRECOND_QUAL index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="_admPrecondQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPrecondQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPrecondQual GetByEntMainIdAdmPrecondQualId(System.Decimal? _entMainId, System.Decimal _admPrecondQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainIdAdmPrecondQualId(null, _entMainId, _admPrecondQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_PRECOND_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="_admPrecondQualId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPrecondQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPrecondQual GetByEntMainIdAdmPrecondQualId(TransactionManager transactionManager, System.Decimal? _entMainId, System.Decimal _admPrecondQualId)
		{
			int count = -1;
			return GetByEntMainIdAdmPrecondQualId(transactionManager, _entMainId, _admPrecondQualId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_PRECOND_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="_admPrecondQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPrecondQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPrecondQual GetByEntMainIdAdmPrecondQualId(TransactionManager transactionManager, System.Decimal? _entMainId, System.Decimal _admPrecondQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainIdAdmPrecondQualId(transactionManager, _entMainId, _admPrecondQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_PRECOND_QUAL index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="_admPrecondQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPrecondQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPrecondQual GetByEntMainIdAdmPrecondQualId(System.Decimal? _entMainId, System.Decimal _admPrecondQualId, int start, int pageLength, out int count)
		{
			return GetByEntMainIdAdmPrecondQualId(null, _entMainId, _admPrecondQualId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_PRECOND_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="_admPrecondQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPrecondQual"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmPrecondQual GetByEntMainIdAdmPrecondQualId(TransactionManager transactionManager, System.Decimal? _entMainId, System.Decimal _admPrecondQualId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmPrecondQual&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmPrecondQual&gt;"/></returns>
		public static TList<AdmPrecondQual> Fill(IDataReader reader, TList<AdmPrecondQual> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmPrecondQual c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmPrecondQual")
					.Append("|").Append((System.Decimal)reader["ADM_PRECOND_QUAL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmPrecondQual>(
					key.ToString(), // EntityTrackingKey
					"AdmPrecondQual",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmPrecondQual();
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
					c.AdmPrecondQualId = (System.Decimal)reader["ADM_PRECOND_QUAL_ID"];
					c.OriginalAdmPrecondQualId = c.AdmPrecondQualId;
					c.AsCodeDegreeClassId = (System.Decimal)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.AsCodeDegreeId = (System.Decimal)reader["AS_CODE_DEGREE_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.QualNatFlg = Convert.IsDBNull(reader["QUAL_NAT_FLG"]) ? null : (System.Boolean?)reader["QUAL_NAT_FLG"];
					c.CitizenFlg = Convert.IsDBNull(reader["CITIZEN_FLG"]) ? null : (System.Boolean?)reader["CITIZEN_FLG"];
					c.ForeignFlg = Convert.IsDBNull(reader["FOREIGN_FLG"]) ? null : (System.Boolean?)reader["FOREIGN_FLG"];
					c.GsCountryNodeInfoId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_INFO_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_INFO_ID"];
					c.EdCodeQualId = Convert.IsDBNull(reader["ED_CODE_QUAL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_QUAL_ID"];
					c.EdCdeQualBrnId = Convert.IsDBNull(reader["ED_CDE_QUAL_BRN_ID"]) ? null : (System.Decimal?)reader["ED_CDE_QUAL_BRN_ID"];
					c.MinPercnt = (System.Decimal)reader["MIN_PERCNT"];
					c.AdmCdeExamGrdngId = Convert.IsDBNull(reader["ADM_CDE_EXAM_GRDNG_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_EXAM_GRDNG_ID"];
					c.MinCgpa = Convert.IsDBNull(reader["MIN_CGPA"]) ? null : (System.Decimal?)reader["MIN_CGPA"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmPrecondQual"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmPrecondQual"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmPrecondQual entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmPrecondQualId = (System.Decimal)reader[((int)AdmPrecondQualColumn.AdmPrecondQualId - 1)];
			entity.OriginalAdmPrecondQualId = (System.Decimal)reader["ADM_PRECOND_QUAL_ID"];
			entity.AsCodeDegreeClassId = (System.Decimal)reader[((int)AdmPrecondQualColumn.AsCodeDegreeClassId - 1)];
			entity.AsCodeDegreeId = (System.Decimal)reader[((int)AdmPrecondQualColumn.AsCodeDegreeId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)AdmPrecondQualColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)AdmPrecondQualColumn.AsFacultyInfoId - 1)];
			entity.EntMainId = (reader.IsDBNull(((int)AdmPrecondQualColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)AdmPrecondQualColumn.EntMainId - 1)];
			entity.QualNatFlg = (reader.IsDBNull(((int)AdmPrecondQualColumn.QualNatFlg - 1)))?null:(System.Boolean?)reader[((int)AdmPrecondQualColumn.QualNatFlg - 1)];
			entity.CitizenFlg = (reader.IsDBNull(((int)AdmPrecondQualColumn.CitizenFlg - 1)))?null:(System.Boolean?)reader[((int)AdmPrecondQualColumn.CitizenFlg - 1)];
			entity.ForeignFlg = (reader.IsDBNull(((int)AdmPrecondQualColumn.ForeignFlg - 1)))?null:(System.Boolean?)reader[((int)AdmPrecondQualColumn.ForeignFlg - 1)];
			entity.GsCountryNodeInfoId = (reader.IsDBNull(((int)AdmPrecondQualColumn.GsCountryNodeInfoId - 1)))?null:(System.Decimal?)reader[((int)AdmPrecondQualColumn.GsCountryNodeInfoId - 1)];
			entity.EdCodeQualId = (reader.IsDBNull(((int)AdmPrecondQualColumn.EdCodeQualId - 1)))?null:(System.Decimal?)reader[((int)AdmPrecondQualColumn.EdCodeQualId - 1)];
			entity.EdCdeQualBrnId = (reader.IsDBNull(((int)AdmPrecondQualColumn.EdCdeQualBrnId - 1)))?null:(System.Decimal?)reader[((int)AdmPrecondQualColumn.EdCdeQualBrnId - 1)];
			entity.MinPercnt = (System.Decimal)reader[((int)AdmPrecondQualColumn.MinPercnt - 1)];
			entity.AdmCdeExamGrdngId = (reader.IsDBNull(((int)AdmPrecondQualColumn.AdmCdeExamGrdngId - 1)))?null:(System.Decimal?)reader[((int)AdmPrecondQualColumn.AdmCdeExamGrdngId - 1)];
			entity.MinCgpa = (reader.IsDBNull(((int)AdmPrecondQualColumn.MinCgpa - 1)))?null:(System.Decimal?)reader[((int)AdmPrecondQualColumn.MinCgpa - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmPrecondQual"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmPrecondQual"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmPrecondQual entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmPrecondQualId = (System.Decimal)dataRow["ADM_PRECOND_QUAL_ID"];
			entity.OriginalAdmPrecondQualId = (System.Decimal)dataRow["ADM_PRECOND_QUAL_ID"];
			entity.AsCodeDegreeClassId = (System.Decimal)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.AsCodeDegreeId = (System.Decimal)dataRow["AS_CODE_DEGREE_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
			entity.QualNatFlg = Convert.IsDBNull(dataRow["QUAL_NAT_FLG"]) ? null : (System.Boolean?)dataRow["QUAL_NAT_FLG"];
			entity.CitizenFlg = Convert.IsDBNull(dataRow["CITIZEN_FLG"]) ? null : (System.Boolean?)dataRow["CITIZEN_FLG"];
			entity.ForeignFlg = Convert.IsDBNull(dataRow["FOREIGN_FLG"]) ? null : (System.Boolean?)dataRow["FOREIGN_FLG"];
			entity.GsCountryNodeInfoId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_INFO_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_INFO_ID"];
			entity.EdCodeQualId = Convert.IsDBNull(dataRow["ED_CODE_QUAL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_QUAL_ID"];
			entity.EdCdeQualBrnId = Convert.IsDBNull(dataRow["ED_CDE_QUAL_BRN_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_QUAL_BRN_ID"];
			entity.MinPercnt = (System.Decimal)dataRow["MIN_PERCNT"];
			entity.AdmCdeExamGrdngId = Convert.IsDBNull(dataRow["ADM_CDE_EXAM_GRDNG_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_EXAM_GRDNG_ID"];
			entity.MinCgpa = Convert.IsDBNull(dataRow["MIN_CGPA"]) ? null : (System.Decimal?)dataRow["MIN_CGPA"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmPrecondQual"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmPrecondQual Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPrecondQual entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmCdeExamGrdngIdSource	
			if (CanDeepLoad(entity, "AdmCdeExamGrdng|AdmCdeExamGrdngIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeExamGrdngIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeExamGrdngId ?? 0.0m);
				AdmCdeExamGrdng tmpEntity = EntityManager.LocateEntity<AdmCdeExamGrdng>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeExamGrdng), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeExamGrdngIdSource = tmpEntity;
				else
					entity.AdmCdeExamGrdngIdSource = DataRepository.AdmCdeExamGrdngProvider.GetByAdmCdeExamGrdngId(transactionManager, (entity.AdmCdeExamGrdngId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeExamGrdngIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeExamGrdngIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeExamGrdngProvider.DeepLoad(transactionManager, entity.AdmCdeExamGrdngIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeExamGrdngIdSource

			#region AsCodeDegreeIdSource	
			if (CanDeepLoad(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsCodeDegreeId;
				AsCodeDegree tmpEntity = EntityManager.LocateEntity<AsCodeDegree>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeIdSource = tmpEntity;
				else
					entity.AsCodeDegreeIdSource = DataRepository.AsCodeDegreeProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);		
				
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

			#region EdCdeQualBrnIdSource	
			if (CanDeepLoad(entity, "EdCdeQualBrn|EdCdeQualBrnIdSource", deepLoadType, innerList) 
				&& entity.EdCdeQualBrnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeQualBrnId ?? 0.0m);
				EdCdeQualBrn tmpEntity = EntityManager.LocateEntity<EdCdeQualBrn>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeQualBrn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeQualBrnIdSource = tmpEntity;
				else
					entity.EdCdeQualBrnIdSource = DataRepository.EdCdeQualBrnProvider.GetByEdCdeQualBrnId(transactionManager, (entity.EdCdeQualBrnId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeQualBrnIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeQualBrnIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeQualBrnProvider.DeepLoad(transactionManager, entity.EdCdeQualBrnIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeQualBrnIdSource

			#region EdCodeQualIdSource	
			if (CanDeepLoad(entity, "EdCodeQual|EdCodeQualIdSource", deepLoadType, innerList) 
				&& entity.EdCodeQualIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeQualId ?? 0.0m);
				EdCodeQual tmpEntity = EntityManager.LocateEntity<EdCodeQual>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeQual), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeQualIdSource = tmpEntity;
				else
					entity.EdCodeQualIdSource = DataRepository.EdCodeQualProvider.GetByEdCodeQualId(transactionManager, (entity.EdCodeQualId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeQualIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeQualIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeQualProvider.DeepLoad(transactionManager, entity.EdCodeQualIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeQualIdSource

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

			#region GsCountryNodeInfoIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|GsCountryNodeInfoIdSource", deepLoadType, innerList) 
				&& entity.GsCountryNodeInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCountryNodeInfoId ?? 0.0m);
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCountryNodeInfoIdSource = tmpEntity;
				else
					entity.GsCountryNodeInfoIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, (entity.GsCountryNodeInfoId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryNodeInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCountryNodeInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCountryNodeProvider.DeepLoad(transactionManager, entity.GsCountryNodeInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCountryNodeInfoIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmPrecondQual object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmPrecondQual instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmPrecondQual Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPrecondQual entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCdeExamGrdngIdSource
			if (CanDeepSave(entity, "AdmCdeExamGrdng|AdmCdeExamGrdngIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeExamGrdngIdSource != null)
			{
				DataRepository.AdmCdeExamGrdngProvider.Save(transactionManager, entity.AdmCdeExamGrdngIdSource);
				entity.AdmCdeExamGrdngId = entity.AdmCdeExamGrdngIdSource.AdmCdeExamGrdngId;
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
			
			#region EdCdeQualBrnIdSource
			if (CanDeepSave(entity, "EdCdeQualBrn|EdCdeQualBrnIdSource", deepSaveType, innerList) 
				&& entity.EdCdeQualBrnIdSource != null)
			{
				DataRepository.EdCdeQualBrnProvider.Save(transactionManager, entity.EdCdeQualBrnIdSource);
				entity.EdCdeQualBrnId = entity.EdCdeQualBrnIdSource.EdCdeQualBrnId;
			}
			#endregion 
			
			#region EdCodeQualIdSource
			if (CanDeepSave(entity, "EdCodeQual|EdCodeQualIdSource", deepSaveType, innerList) 
				&& entity.EdCodeQualIdSource != null)
			{
				DataRepository.EdCodeQualProvider.Save(transactionManager, entity.EdCodeQualIdSource);
				entity.EdCodeQualId = entity.EdCodeQualIdSource.EdCodeQualId;
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
			
			#region GsCountryNodeInfoIdSource
			if (CanDeepSave(entity, "GsCountryNode|GsCountryNodeInfoIdSource", deepSaveType, innerList) 
				&& entity.GsCountryNodeInfoIdSource != null)
			{
				DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryNodeInfoIdSource);
				entity.GsCountryNodeInfoId = entity.GsCountryNodeInfoIdSource.GsCountryNodeId;
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
	
	#region AdmPrecondQualChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmPrecondQual</c>
	///</summary>
	public enum AdmPrecondQualChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCdeExamGrdng</c> at AdmCdeExamGrdngIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeExamGrdng))]
		AdmCdeExamGrdng,
		
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
		/// Composite Property for <c>EdCdeQualBrn</c> at EdCdeQualBrnIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeQualBrn))]
		EdCdeQualBrn,
		
		///<summary>
		/// Composite Property for <c>EdCodeQual</c> at EdCodeQualIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeQual))]
		EdCodeQual,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeInfoIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
	}
	
	#endregion AdmPrecondQualChildEntityTypes
	
	#region AdmPrecondQualFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmPrecondQualColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmPrecondQual"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmPrecondQualFilterBuilder : SqlFilterBuilder<AdmPrecondQualColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmPrecondQualFilterBuilder class.
		/// </summary>
		public AdmPrecondQualFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmPrecondQualFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmPrecondQualFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmPrecondQualFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmPrecondQualFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmPrecondQualFilterBuilder
	
	#region AdmPrecondQualParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmPrecondQualColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmPrecondQual"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmPrecondQualParameterBuilder : ParameterizedSqlFilterBuilder<AdmPrecondQualColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmPrecondQualParameterBuilder class.
		/// </summary>
		public AdmPrecondQualParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmPrecondQualParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmPrecondQualParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmPrecondQualParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmPrecondQualParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmPrecondQualParameterBuilder
	
	#region AdmPrecondQualSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmPrecondQualColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmPrecondQual"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmPrecondQualSortBuilder : SqlSortBuilder<AdmPrecondQualColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmPrecondQualSqlSortBuilder class.
		/// </summary>
		public AdmPrecondQualSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmPrecondQualSortBuilder
	
} // end namespace
