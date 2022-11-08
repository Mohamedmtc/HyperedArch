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
	/// This class is the base class for any <see cref="AdmCdePlacementExamProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmCdePlacementExamProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmCdePlacementExam, UMIS_VER2.BusinessLyer.AdmCdePlacementExamKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdePlacementExamKey key)
		{
			return Delete(transactionManager, key.AdmCdePlacementExamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admCdePlacementExamId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admCdePlacementExamId)
		{
			return Delete(null, _admCdePlacementExamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="_admCdeExamMinGrdngId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAdmCdeExamMinGrdngId(System.Decimal? _admCdeExamMinGrdngId)
		{
			int count = -1;
			return GetByAdmCdeExamMinGrdngId(_admCdeExamMinGrdngId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamMinGrdngId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCdePlacementExam> GetByAdmCdeExamMinGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamMinGrdngId)
		{
			int count = -1;
			return GetByAdmCdeExamMinGrdngId(transactionManager, _admCdeExamMinGrdngId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamMinGrdngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAdmCdeExamMinGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamMinGrdngId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeExamMinGrdngId(transactionManager, _admCdeExamMinGrdngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG key.
		///		fkAdmCdePlacementExamAdmCdeExamGrdng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeExamMinGrdngId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAdmCdeExamMinGrdngId(System.Decimal? _admCdeExamMinGrdngId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeExamMinGrdngId(null, _admCdeExamMinGrdngId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG key.
		///		fkAdmCdePlacementExamAdmCdeExamGrdng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeExamMinGrdngId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAdmCdeExamMinGrdngId(System.Decimal? _admCdeExamMinGrdngId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeExamMinGrdngId(null, _admCdeExamMinGrdngId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamMinGrdngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public abstract TList<AdmCdePlacementExam> GetByAdmCdeExamMinGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamMinGrdngId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="_admCdePlacExamPrntId">NU:English>TOEFL/IELTS/ENGPLACE>MARK/WRITING or SCORE</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAdmCdePlacExamPrntId(System.Decimal? _admCdePlacExamPrntId)
		{
			int count = -1;
			return GetByAdmCdePlacExamPrntId(_admCdePlacExamPrntId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacExamPrntId">NU:English>TOEFL/IELTS/ENGPLACE>MARK/WRITING or SCORE</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCdePlacementExam> GetByAdmCdePlacExamPrntId(TransactionManager transactionManager, System.Decimal? _admCdePlacExamPrntId)
		{
			int count = -1;
			return GetByAdmCdePlacExamPrntId(transactionManager, _admCdePlacExamPrntId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacExamPrntId">NU:English>TOEFL/IELTS/ENGPLACE>MARK/WRITING or SCORE</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAdmCdePlacExamPrntId(TransactionManager transactionManager, System.Decimal? _admCdePlacExamPrntId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdePlacExamPrntId(transactionManager, _admCdePlacExamPrntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM key.
		///		fkAdmCdePlacementExamAdmCdePlacementExam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdePlacExamPrntId">NU:English>TOEFL/IELTS/ENGPLACE>MARK/WRITING or SCORE</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAdmCdePlacExamPrntId(System.Decimal? _admCdePlacExamPrntId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdePlacExamPrntId(null, _admCdePlacExamPrntId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM key.
		///		fkAdmCdePlacementExamAdmCdePlacementExam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdePlacExamPrntId">NU:English>TOEFL/IELTS/ENGPLACE>MARK/WRITING or SCORE</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAdmCdePlacExamPrntId(System.Decimal? _admCdePlacExamPrntId, int start, int pageLength,out int count)
		{
			return GetByAdmCdePlacExamPrntId(null, _admCdePlacExamPrntId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacExamPrntId">NU:English>TOEFL/IELTS/ENGPLACE>MARK/WRITING or SCORE</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public abstract TList<AdmCdePlacementExam> GetByAdmCdePlacExamPrntId(TransactionManager transactionManager, System.Decimal? _admCdePlacExamPrntId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM1 key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM1 Description: 
		/// </summary>
		/// <param name="_chlangExamId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByChlangExamId(System.Decimal? _chlangExamId)
		{
			int count = -1;
			return GetByChlangExamId(_chlangExamId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM1 key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_chlangExamId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCdePlacementExam> GetByChlangExamId(TransactionManager transactionManager, System.Decimal? _chlangExamId)
		{
			int count = -1;
			return GetByChlangExamId(transactionManager, _chlangExamId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM1 key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_chlangExamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByChlangExamId(TransactionManager transactionManager, System.Decimal? _chlangExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByChlangExamId(transactionManager, _chlangExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM1 key.
		///		fkAdmCdePlacementExamAdmCdePlacementExam1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_chlangExamId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByChlangExamId(System.Decimal? _chlangExamId, int start, int pageLength)
		{
			int count =  -1;
			return GetByChlangExamId(null, _chlangExamId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM1 key.
		///		fkAdmCdePlacementExamAdmCdePlacementExam1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_chlangExamId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByChlangExamId(System.Decimal? _chlangExamId, int start, int pageLength,out int count)
		{
			return GetByChlangExamId(null, _chlangExamId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM1 key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_chlangExamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public abstract TList<AdmCdePlacementExam> GetByChlangExamId(TransactionManager transactionManager, System.Decimal? _chlangExamId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_EXAM_GRDNG_PKG key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_ADM_EXAM_GRDNG_PKG Description: 
		/// </summary>
		/// <param name="_admExamGrdngPkgId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAdmExamGrdngPkgId(System.Decimal? _admExamGrdngPkgId)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgId(_admExamGrdngPkgId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_EXAM_GRDNG_PKG key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_ADM_EXAM_GRDNG_PKG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCdePlacementExam> GetByAdmExamGrdngPkgId(TransactionManager transactionManager, System.Decimal? _admExamGrdngPkgId)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgId(transactionManager, _admExamGrdngPkgId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_EXAM_GRDNG_PKG key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_ADM_EXAM_GRDNG_PKG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAdmExamGrdngPkgId(TransactionManager transactionManager, System.Decimal? _admExamGrdngPkgId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgId(transactionManager, _admExamGrdngPkgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_EXAM_GRDNG_PKG key.
		///		fkAdmCdePlacementExamAdmExamGrdngPkg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admExamGrdngPkgId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAdmExamGrdngPkgId(System.Decimal? _admExamGrdngPkgId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmExamGrdngPkgId(null, _admExamGrdngPkgId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_EXAM_GRDNG_PKG key.
		///		fkAdmCdePlacementExamAdmExamGrdngPkg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admExamGrdngPkgId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAdmExamGrdngPkgId(System.Decimal? _admExamGrdngPkgId, int start, int pageLength,out int count)
		{
			return GetByAdmExamGrdngPkgId(null, _admExamGrdngPkgId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_ADM_EXAM_GRDNG_PKG key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_ADM_EXAM_GRDNG_PKG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public abstract TList<AdmCdePlacementExam> GetByAdmExamGrdngPkgId(TransactionManager transactionManager, System.Decimal? _admExamGrdngPkgId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCdePlacementExam> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE key.
		///		fkAdmCdePlacementExamAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE key.
		///		fkAdmCdePlacementExamAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public abstract TList<AdmCdePlacementExam> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCdePlacementExam> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE_CLASS key.
		///		fkAdmCdePlacementExamAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE_CLASS key.
		///		fkAdmCdePlacementExamAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public TList<AdmCdePlacementExam> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_CDE_PLACEMENT_EXAM_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdePlacementExam objects.</returns>
		public abstract TList<AdmCdePlacementExam> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmCdePlacementExam Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdePlacementExamKey key, int start, int pageLength)
		{
			return GetByAdmCdePlacementExamId(transactionManager, key.AdmCdePlacementExamId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmCdePlacementExam&gt;"/> class.</returns>
		public TList<AdmCdePlacementExam> GetByEntMainId(System.Decimal _entMainId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmCdePlacementExam&gt;"/> class.</returns>
		public TList<AdmCdePlacementExam> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmCdePlacementExam&gt;"/> class.</returns>
		public TList<AdmCdePlacementExam> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmCdePlacementExam&gt;"/> class.</returns>
		public TList<AdmCdePlacementExam> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmCdePlacementExam&gt;"/> class.</returns>
		public TList<AdmCdePlacementExam> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmCdePlacementExam&gt;"/> class.</returns>
		public abstract TList<AdmCdePlacementExam> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_CDE_PLACEMENT_EXAM index.
		/// </summary>
		/// <param name="_admCdePlacementExamId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdePlacementExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdePlacementExam GetByAdmCdePlacementExamId(System.Decimal _admCdePlacementExamId)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(null,_admCdePlacementExamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_PLACEMENT_EXAM index.
		/// </summary>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdePlacementExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdePlacementExam GetByAdmCdePlacementExamId(System.Decimal _admCdePlacementExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(null, _admCdePlacementExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_PLACEMENT_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdePlacementExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdePlacementExam GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(transactionManager, _admCdePlacementExamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_PLACEMENT_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdePlacementExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdePlacementExam GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(transactionManager, _admCdePlacementExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_PLACEMENT_EXAM index.
		/// </summary>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdePlacementExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdePlacementExam GetByAdmCdePlacementExamId(System.Decimal _admCdePlacementExamId, int start, int pageLength, out int count)
		{
			return GetByAdmCdePlacementExamId(null, _admCdePlacementExamId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_PLACEMENT_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdePlacementExam"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCdePlacementExam GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmCdePlacementExam&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmCdePlacementExam&gt;"/></returns>
		public static TList<AdmCdePlacementExam> Fill(IDataReader reader, TList<AdmCdePlacementExam> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmCdePlacementExam c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmCdePlacementExam")
					.Append("|").Append((System.Decimal)reader["ADM_CDE_PLACEMENT_EXAM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmCdePlacementExam>(
					key.ToString(), // EntityTrackingKey
					"AdmCdePlacementExam",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmCdePlacementExam();
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
					c.AdmCdePlacementExamId = (System.Decimal)reader["ADM_CDE_PLACEMENT_EXAM_ID"];
					c.OriginalAdmCdePlacementExamId = c.AdmCdePlacementExamId;
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.DelFlg = Convert.IsDBNull(reader["DEL_FLG"]) ? null : (System.Decimal?)reader["DEL_FLG"];
					c.ExamTypeFlg = (System.Decimal)reader["EXAM_TYPE_FLG"];
					c.GsCdeOperator = Convert.IsDBNull(reader["GS_CDE_OPERATOR"]) ? null : (System.String)reader["GS_CDE_OPERATOR"];
					c.AutoloadFlg = (System.Decimal)reader["AUTOLOAD_FLG"];
					c.MaxMark = Convert.IsDBNull(reader["MAX_MARK"]) ? null : (System.Decimal?)reader["MAX_MARK"];
					c.MinMark = Convert.IsDBNull(reader["MIN_MARK"]) ? null : (System.Decimal?)reader["MIN_MARK"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.CrsFlg = Convert.IsDBNull(reader["CRS_FLG"]) ? null : (System.Decimal?)reader["CRS_FLG"];
					c.AdmExamGrdngPkgId = Convert.IsDBNull(reader["ADM_EXAM_GRDNG_PKG_ID"]) ? null : (System.Decimal?)reader["ADM_EXAM_GRDNG_PKG_ID"];
					c.AdmCdeExamMinGrdngId = Convert.IsDBNull(reader["ADM_CDE_EXAM_MIN_GRDNG_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_EXAM_MIN_GRDNG_ID"];
					c.OutFlg = Convert.IsDBNull(reader["OUT_FLG"]) ? null : (System.Boolean?)reader["OUT_FLG"];
					c.EngFlg = Convert.IsDBNull(reader["ENG_FLG"]) ? null : (System.Boolean?)reader["ENG_FLG"];
					c.MainFlg = Convert.IsDBNull(reader["MAIN_FLG"]) ? null : (System.Boolean?)reader["MAIN_FLG"];
					c.SubFlg = Convert.IsDBNull(reader["SUB_FLG"]) ? null : (System.Boolean?)reader["SUB_FLG"];
					c.AdmCdePlacExamPrntId = Convert.IsDBNull(reader["ADM_CDE_PLAC_EXAM_PRNT_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_PLAC_EXAM_PRNT_ID"];
					c.ExemptFlg = Convert.IsDBNull(reader["EXEMPT_FLG"]) ? null : (System.Boolean?)reader["EXEMPT_FLG"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.ForeignFlg = Convert.IsDBNull(reader["FOREIGN_FLG"]) ? null : (System.Decimal?)reader["FOREIGN_FLG"];
					c.FailRejectFlg = Convert.IsDBNull(reader["FAIL_REJECT_FLG"]) ? null : (System.Boolean?)reader["FAIL_REJECT_FLG"];
					c.ComptativeRateFlg = Convert.IsDBNull(reader["COMPTATIVE_RATE_FLG"]) ? null : (System.Boolean?)reader["COMPTATIVE_RATE_FLG"];
					c.InterviewFlg = Convert.IsDBNull(reader["INTERVIEW_FLG"]) ? null : (System.Boolean?)reader["INTERVIEW_FLG"];
					c.OnlineFlg = Convert.IsDBNull(reader["ONLINE_FLG"]) ? null : (System.Boolean?)reader["ONLINE_FLG"];
					c.PrepayFlg = Convert.IsDBNull(reader["PREPAY_FLG"]) ? null : (System.Int16?)reader["PREPAY_FLG"];
					c.ChalngFlg = Convert.IsDBNull(reader["CHALNG_FLG"]) ? null : (System.Boolean?)reader["CHALNG_FLG"];
					c.LeadToChalng = Convert.IsDBNull(reader["LEAD_TO_CHALNG"]) ? null : (System.Boolean?)reader["LEAD_TO_CHALNG"];
					c.ChlangExamId = Convert.IsDBNull(reader["CHLANG_EXAM_ID"]) ? null : (System.Decimal?)reader["CHLANG_EXAM_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdePlacementExam"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdePlacementExam"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmCdePlacementExam entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmCdePlacementExamId = (System.Decimal)reader[((int)AdmCdePlacementExamColumn.AdmCdePlacementExamId - 1)];
			entity.OriginalAdmCdePlacementExamId = (System.Decimal)reader["ADM_CDE_PLACEMENT_EXAM_ID"];
			entity.EntMainId = (System.Decimal)reader[((int)AdmCdePlacementExamColumn.EntMainId - 1)];
			entity.DescrAr = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.DescrAr - 1)))?null:(System.String)reader[((int)AdmCdePlacementExamColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.DescrEn - 1)))?null:(System.String)reader[((int)AdmCdePlacementExamColumn.DescrEn - 1)];
			entity.DelFlg = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.DelFlg - 1)))?null:(System.Decimal?)reader[((int)AdmCdePlacementExamColumn.DelFlg - 1)];
			entity.ExamTypeFlg = (System.Decimal)reader[((int)AdmCdePlacementExamColumn.ExamTypeFlg - 1)];
			entity.GsCdeOperator = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.GsCdeOperator - 1)))?null:(System.String)reader[((int)AdmCdePlacementExamColumn.GsCdeOperator - 1)];
			entity.AutoloadFlg = (System.Decimal)reader[((int)AdmCdePlacementExamColumn.AutoloadFlg - 1)];
			entity.MaxMark = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.MaxMark - 1)))?null:(System.Decimal?)reader[((int)AdmCdePlacementExamColumn.MaxMark - 1)];
			entity.MinMark = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.MinMark - 1)))?null:(System.Decimal?)reader[((int)AdmCdePlacementExamColumn.MinMark - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)AdmCdePlacementExamColumn.AsCodeDegreeClassId - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)AdmCdePlacementExamColumn.AsCodeDegreeId - 1)];
			entity.CrsFlg = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.CrsFlg - 1)))?null:(System.Decimal?)reader[((int)AdmCdePlacementExamColumn.CrsFlg - 1)];
			entity.AdmExamGrdngPkgId = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.AdmExamGrdngPkgId - 1)))?null:(System.Decimal?)reader[((int)AdmCdePlacementExamColumn.AdmExamGrdngPkgId - 1)];
			entity.AdmCdeExamMinGrdngId = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.AdmCdeExamMinGrdngId - 1)))?null:(System.Decimal?)reader[((int)AdmCdePlacementExamColumn.AdmCdeExamMinGrdngId - 1)];
			entity.OutFlg = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.OutFlg - 1)))?null:(System.Boolean?)reader[((int)AdmCdePlacementExamColumn.OutFlg - 1)];
			entity.EngFlg = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.EngFlg - 1)))?null:(System.Boolean?)reader[((int)AdmCdePlacementExamColumn.EngFlg - 1)];
			entity.MainFlg = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.MainFlg - 1)))?null:(System.Boolean?)reader[((int)AdmCdePlacementExamColumn.MainFlg - 1)];
			entity.SubFlg = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.SubFlg - 1)))?null:(System.Boolean?)reader[((int)AdmCdePlacementExamColumn.SubFlg - 1)];
			entity.AdmCdePlacExamPrntId = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.AdmCdePlacExamPrntId - 1)))?null:(System.Decimal?)reader[((int)AdmCdePlacementExamColumn.AdmCdePlacExamPrntId - 1)];
			entity.ExemptFlg = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.ExemptFlg - 1)))?null:(System.Boolean?)reader[((int)AdmCdePlacementExamColumn.ExemptFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmCdePlacementExamColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmCdePlacementExamColumn.LastDate - 1)];
			entity.ForeignFlg = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.ForeignFlg - 1)))?null:(System.Decimal?)reader[((int)AdmCdePlacementExamColumn.ForeignFlg - 1)];
			entity.FailRejectFlg = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.FailRejectFlg - 1)))?null:(System.Boolean?)reader[((int)AdmCdePlacementExamColumn.FailRejectFlg - 1)];
			entity.ComptativeRateFlg = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.ComptativeRateFlg - 1)))?null:(System.Boolean?)reader[((int)AdmCdePlacementExamColumn.ComptativeRateFlg - 1)];
			entity.InterviewFlg = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.InterviewFlg - 1)))?null:(System.Boolean?)reader[((int)AdmCdePlacementExamColumn.InterviewFlg - 1)];
			entity.OnlineFlg = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.OnlineFlg - 1)))?null:(System.Boolean?)reader[((int)AdmCdePlacementExamColumn.OnlineFlg - 1)];
			entity.PrepayFlg = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.PrepayFlg - 1)))?null:(System.Int16?)reader[((int)AdmCdePlacementExamColumn.PrepayFlg - 1)];
			entity.ChalngFlg = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.ChalngFlg - 1)))?null:(System.Boolean?)reader[((int)AdmCdePlacementExamColumn.ChalngFlg - 1)];
			entity.LeadToChalng = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.LeadToChalng - 1)))?null:(System.Boolean?)reader[((int)AdmCdePlacementExamColumn.LeadToChalng - 1)];
			entity.ChlangExamId = (reader.IsDBNull(((int)AdmCdePlacementExamColumn.ChlangExamId - 1)))?null:(System.Decimal?)reader[((int)AdmCdePlacementExamColumn.ChlangExamId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdePlacementExam"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdePlacementExam"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmCdePlacementExam entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmCdePlacementExamId = (System.Decimal)dataRow["ADM_CDE_PLACEMENT_EXAM_ID"];
			entity.OriginalAdmCdePlacementExamId = (System.Decimal)dataRow["ADM_CDE_PLACEMENT_EXAM_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.DelFlg = Convert.IsDBNull(dataRow["DEL_FLG"]) ? null : (System.Decimal?)dataRow["DEL_FLG"];
			entity.ExamTypeFlg = (System.Decimal)dataRow["EXAM_TYPE_FLG"];
			entity.GsCdeOperator = Convert.IsDBNull(dataRow["GS_CDE_OPERATOR"]) ? null : (System.String)dataRow["GS_CDE_OPERATOR"];
			entity.AutoloadFlg = (System.Decimal)dataRow["AUTOLOAD_FLG"];
			entity.MaxMark = Convert.IsDBNull(dataRow["MAX_MARK"]) ? null : (System.Decimal?)dataRow["MAX_MARK"];
			entity.MinMark = Convert.IsDBNull(dataRow["MIN_MARK"]) ? null : (System.Decimal?)dataRow["MIN_MARK"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
			entity.CrsFlg = Convert.IsDBNull(dataRow["CRS_FLG"]) ? null : (System.Decimal?)dataRow["CRS_FLG"];
			entity.AdmExamGrdngPkgId = Convert.IsDBNull(dataRow["ADM_EXAM_GRDNG_PKG_ID"]) ? null : (System.Decimal?)dataRow["ADM_EXAM_GRDNG_PKG_ID"];
			entity.AdmCdeExamMinGrdngId = Convert.IsDBNull(dataRow["ADM_CDE_EXAM_MIN_GRDNG_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_EXAM_MIN_GRDNG_ID"];
			entity.OutFlg = Convert.IsDBNull(dataRow["OUT_FLG"]) ? null : (System.Boolean?)dataRow["OUT_FLG"];
			entity.EngFlg = Convert.IsDBNull(dataRow["ENG_FLG"]) ? null : (System.Boolean?)dataRow["ENG_FLG"];
			entity.MainFlg = Convert.IsDBNull(dataRow["MAIN_FLG"]) ? null : (System.Boolean?)dataRow["MAIN_FLG"];
			entity.SubFlg = Convert.IsDBNull(dataRow["SUB_FLG"]) ? null : (System.Boolean?)dataRow["SUB_FLG"];
			entity.AdmCdePlacExamPrntId = Convert.IsDBNull(dataRow["ADM_CDE_PLAC_EXAM_PRNT_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_PLAC_EXAM_PRNT_ID"];
			entity.ExemptFlg = Convert.IsDBNull(dataRow["EXEMPT_FLG"]) ? null : (System.Boolean?)dataRow["EXEMPT_FLG"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.ForeignFlg = Convert.IsDBNull(dataRow["FOREIGN_FLG"]) ? null : (System.Decimal?)dataRow["FOREIGN_FLG"];
			entity.FailRejectFlg = Convert.IsDBNull(dataRow["FAIL_REJECT_FLG"]) ? null : (System.Boolean?)dataRow["FAIL_REJECT_FLG"];
			entity.ComptativeRateFlg = Convert.IsDBNull(dataRow["COMPTATIVE_RATE_FLG"]) ? null : (System.Boolean?)dataRow["COMPTATIVE_RATE_FLG"];
			entity.InterviewFlg = Convert.IsDBNull(dataRow["INTERVIEW_FLG"]) ? null : (System.Boolean?)dataRow["INTERVIEW_FLG"];
			entity.OnlineFlg = Convert.IsDBNull(dataRow["ONLINE_FLG"]) ? null : (System.Boolean?)dataRow["ONLINE_FLG"];
			entity.PrepayFlg = Convert.IsDBNull(dataRow["PREPAY_FLG"]) ? null : (System.Int16?)dataRow["PREPAY_FLG"];
			entity.ChalngFlg = Convert.IsDBNull(dataRow["CHALNG_FLG"]) ? null : (System.Boolean?)dataRow["CHALNG_FLG"];
			entity.LeadToChalng = Convert.IsDBNull(dataRow["LEAD_TO_CHALNG"]) ? null : (System.Boolean?)dataRow["LEAD_TO_CHALNG"];
			entity.ChlangExamId = Convert.IsDBNull(dataRow["CHLANG_EXAM_ID"]) ? null : (System.Decimal?)dataRow["CHLANG_EXAM_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdePlacementExam"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdePlacementExam Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdePlacementExam entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmCdeExamMinGrdngIdSource	
			if (CanDeepLoad(entity, "AdmCdeExamGrdng|AdmCdeExamMinGrdngIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeExamMinGrdngIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeExamMinGrdngId ?? 0.0m);
				AdmCdeExamGrdng tmpEntity = EntityManager.LocateEntity<AdmCdeExamGrdng>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeExamGrdng), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeExamMinGrdngIdSource = tmpEntity;
				else
					entity.AdmCdeExamMinGrdngIdSource = DataRepository.AdmCdeExamGrdngProvider.GetByAdmCdeExamGrdngId(transactionManager, (entity.AdmCdeExamMinGrdngId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeExamMinGrdngIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeExamMinGrdngIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeExamGrdngProvider.DeepLoad(transactionManager, entity.AdmCdeExamMinGrdngIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeExamMinGrdngIdSource

			#region AdmCdePlacExamPrntIdSource	
			if (CanDeepLoad(entity, "AdmCdePlacementExam|AdmCdePlacExamPrntIdSource", deepLoadType, innerList) 
				&& entity.AdmCdePlacExamPrntIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdePlacExamPrntId ?? 0.0m);
				AdmCdePlacementExam tmpEntity = EntityManager.LocateEntity<AdmCdePlacementExam>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdePlacementExam), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdePlacExamPrntIdSource = tmpEntity;
				else
					entity.AdmCdePlacExamPrntIdSource = DataRepository.AdmCdePlacementExamProvider.GetByAdmCdePlacementExamId(transactionManager, (entity.AdmCdePlacExamPrntId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdePlacExamPrntIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdePlacExamPrntIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdePlacementExamProvider.DeepLoad(transactionManager, entity.AdmCdePlacExamPrntIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdePlacExamPrntIdSource

			#region ChlangExamIdSource	
			if (CanDeepLoad(entity, "AdmCdePlacementExam|ChlangExamIdSource", deepLoadType, innerList) 
				&& entity.ChlangExamIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ChlangExamId ?? 0.0m);
				AdmCdePlacementExam tmpEntity = EntityManager.LocateEntity<AdmCdePlacementExam>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdePlacementExam), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ChlangExamIdSource = tmpEntity;
				else
					entity.ChlangExamIdSource = DataRepository.AdmCdePlacementExamProvider.GetByAdmCdePlacementExamId(transactionManager, (entity.ChlangExamId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ChlangExamIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ChlangExamIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdePlacementExamProvider.DeepLoad(transactionManager, entity.ChlangExamIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ChlangExamIdSource

			#region AdmExamGrdngPkgIdSource	
			if (CanDeepLoad(entity, "AdmExamGrdngPkg|AdmExamGrdngPkgIdSource", deepLoadType, innerList) 
				&& entity.AdmExamGrdngPkgIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmExamGrdngPkgId ?? 0.0m);
				AdmExamGrdngPkg tmpEntity = EntityManager.LocateEntity<AdmExamGrdngPkg>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmExamGrdngPkg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmExamGrdngPkgIdSource = tmpEntity;
				else
					entity.AdmExamGrdngPkgIdSource = DataRepository.AdmExamGrdngPkgProvider.GetByAdmExamGrdngPkgId(transactionManager, (entity.AdmExamGrdngPkgId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmExamGrdngPkgIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmExamGrdngPkgIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmExamGrdngPkgProvider.DeepLoad(transactionManager, entity.AdmExamGrdngPkgIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmExamGrdngPkgIdSource

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
			// Deep load child collections  - Call GetByAdmCdePlacementExamId methods when available
			
			#region AdmCdePlacementExamCollectionGetByChlangExamId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCdePlacementExam>|AdmCdePlacementExamCollectionGetByChlangExamId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdePlacementExamCollectionGetByChlangExamId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCdePlacementExamCollectionGetByChlangExamId = DataRepository.AdmCdePlacementExamProvider.GetByChlangExamId(transactionManager, entity.AdmCdePlacementExamId);

				if (deep && entity.AdmCdePlacementExamCollectionGetByChlangExamId.Count > 0)
				{
					deepHandles.Add("AdmCdePlacementExamCollectionGetByChlangExamId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCdePlacementExam>) DataRepository.AdmCdePlacementExamProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCdePlacementExamCollectionGetByChlangExamId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmPlaceExamCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPlaceExamCourse>|AdmPlaceExamCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPlaceExamCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPlaceExamCourseCollection = DataRepository.AdmPlaceExamCourseProvider.GetByAdmCdePlacementExamId(transactionManager, entity.AdmCdePlacementExamId);

				if (deep && entity.AdmPlaceExamCourseCollection.Count > 0)
				{
					deepHandles.Add("AdmPlaceExamCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPlaceExamCourse>) DataRepository.AdmPlaceExamCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPlaceExamCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmPlaceExamDatetimeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPlaceExamDatetime>|AdmPlaceExamDatetimeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPlaceExamDatetimeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPlaceExamDatetimeCollection = DataRepository.AdmPlaceExamDatetimeProvider.GetByAdmCdePlacementExamId(transactionManager, entity.AdmCdePlacementExamId);

				if (deep && entity.AdmPlaceExamDatetimeCollection.Count > 0)
				{
					deepHandles.Add("AdmPlaceExamDatetimeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPlaceExamDatetime>) DataRepository.AdmPlaceExamDatetimeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPlaceExamDatetimeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCompetitiveAvgCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCompetitiveAvg>|AdmCompetitiveAvgCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCompetitiveAvgCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCompetitiveAvgCollection = DataRepository.AdmCompetitiveAvgProvider.GetByAdmCdePlacementExamId(transactionManager, entity.AdmCdePlacementExamId);

				if (deep && entity.AdmCompetitiveAvgCollection.Count > 0)
				{
					deepHandles.Add("AdmCompetitiveAvgCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCompetitiveAvg>) DataRepository.AdmCompetitiveAvgProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCompetitiveAvgCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppInterviewExamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppInterviewExam>|AdmAppInterviewExamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppInterviewExamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppInterviewExamCollection = DataRepository.AdmAppInterviewExamProvider.GetByAdmCdePlacementExamId(transactionManager, entity.AdmCdePlacementExamId);

				if (deep && entity.AdmAppInterviewExamCollection.Count > 0)
				{
					deepHandles.Add("AdmAppInterviewExamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppInterviewExam>) DataRepository.AdmAppInterviewExamProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppInterviewExamCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCodeEngTestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCodeEngTest>|AdmCodeEngTestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCodeEngTestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCodeEngTestCollection = DataRepository.AdmCodeEngTestProvider.GetByAdmCdePlacementExamId(transactionManager, entity.AdmCdePlacementExamId);

				if (deep && entity.AdmCodeEngTestCollection.Count > 0)
				{
					deepHandles.Add("AdmCodeEngTestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCodeEngTest>) DataRepository.AdmCodeEngTestProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCodeEngTestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppPlacementExamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppPlacementExam>|AdmAppPlacementExamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppPlacementExamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppPlacementExamCollection = DataRepository.AdmAppPlacementExamProvider.GetByAdmCdePlacementExamId(transactionManager, entity.AdmCdePlacementExamId);

				if (deep && entity.AdmAppPlacementExamCollection.Count > 0)
				{
					deepHandles.Add("AdmAppPlacementExamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppPlacementExam>) DataRepository.AdmAppPlacementExamProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppPlacementExamCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCdePlacementExamCollectionGetByAdmCdePlacExamPrntId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCdePlacementExam>|AdmCdePlacementExamCollectionGetByAdmCdePlacExamPrntId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdePlacementExamCollectionGetByAdmCdePlacExamPrntId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCdePlacementExamCollectionGetByAdmCdePlacExamPrntId = DataRepository.AdmCdePlacementExamProvider.GetByAdmCdePlacExamPrntId(transactionManager, entity.AdmCdePlacementExamId);

				if (deep && entity.AdmCdePlacementExamCollectionGetByAdmCdePlacExamPrntId.Count > 0)
				{
					deepHandles.Add("AdmCdePlacementExamCollectionGetByAdmCdePlacExamPrntId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCdePlacementExam>) DataRepository.AdmCdePlacementExamProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCdePlacementExamCollectionGetByAdmCdePlacExamPrntId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCdeFeeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCdeFee>|AdmCdeFeeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeFeeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCdeFeeCollection = DataRepository.AdmCdeFeeProvider.GetByAdmCdePlacementExamId(transactionManager, entity.AdmCdePlacementExamId);

				if (deep && entity.AdmCdeFeeCollection.Count > 0)
				{
					deepHandles.Add("AdmCdeFeeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCdeFee>) DataRepository.AdmCdeFeeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCdeFeeCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmCdePlacementExam object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmCdePlacementExam instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdePlacementExam Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdePlacementExam entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCdeExamMinGrdngIdSource
			if (CanDeepSave(entity, "AdmCdeExamGrdng|AdmCdeExamMinGrdngIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeExamMinGrdngIdSource != null)
			{
				DataRepository.AdmCdeExamGrdngProvider.Save(transactionManager, entity.AdmCdeExamMinGrdngIdSource);
				entity.AdmCdeExamMinGrdngId = entity.AdmCdeExamMinGrdngIdSource.AdmCdeExamGrdngId;
			}
			#endregion 
			
			#region AdmCdePlacExamPrntIdSource
			if (CanDeepSave(entity, "AdmCdePlacementExam|AdmCdePlacExamPrntIdSource", deepSaveType, innerList) 
				&& entity.AdmCdePlacExamPrntIdSource != null)
			{
				DataRepository.AdmCdePlacementExamProvider.Save(transactionManager, entity.AdmCdePlacExamPrntIdSource);
				entity.AdmCdePlacExamPrntId = entity.AdmCdePlacExamPrntIdSource.AdmCdePlacementExamId;
			}
			#endregion 
			
			#region ChlangExamIdSource
			if (CanDeepSave(entity, "AdmCdePlacementExam|ChlangExamIdSource", deepSaveType, innerList) 
				&& entity.ChlangExamIdSource != null)
			{
				DataRepository.AdmCdePlacementExamProvider.Save(transactionManager, entity.ChlangExamIdSource);
				entity.ChlangExamId = entity.ChlangExamIdSource.AdmCdePlacementExamId;
			}
			#endregion 
			
			#region AdmExamGrdngPkgIdSource
			if (CanDeepSave(entity, "AdmExamGrdngPkg|AdmExamGrdngPkgIdSource", deepSaveType, innerList) 
				&& entity.AdmExamGrdngPkgIdSource != null)
			{
				DataRepository.AdmExamGrdngPkgProvider.Save(transactionManager, entity.AdmExamGrdngPkgIdSource);
				entity.AdmExamGrdngPkgId = entity.AdmExamGrdngPkgIdSource.AdmExamGrdngPkgId;
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
	
			#region List<AdmCdePlacementExam>
				if (CanDeepSave(entity.AdmCdePlacementExamCollectionGetByChlangExamId, "List<AdmCdePlacementExam>|AdmCdePlacementExamCollectionGetByChlangExamId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCdePlacementExam child in entity.AdmCdePlacementExamCollectionGetByChlangExamId)
					{
						if(child.ChlangExamIdSource != null)
						{
							child.ChlangExamId = child.ChlangExamIdSource.AdmCdePlacementExamId;
						}
						else
						{
							child.ChlangExamId = entity.AdmCdePlacementExamId;
						}

					}

					if (entity.AdmCdePlacementExamCollectionGetByChlangExamId.Count > 0 || entity.AdmCdePlacementExamCollectionGetByChlangExamId.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCdePlacementExamProvider.Save(transactionManager, entity.AdmCdePlacementExamCollectionGetByChlangExamId);
						
						deepHandles.Add("AdmCdePlacementExamCollectionGetByChlangExamId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCdePlacementExam >) DataRepository.AdmCdePlacementExamProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCdePlacementExamCollectionGetByChlangExamId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmPlaceExamCourse>
				if (CanDeepSave(entity.AdmPlaceExamCourseCollection, "List<AdmPlaceExamCourse>|AdmPlaceExamCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPlaceExamCourse child in entity.AdmPlaceExamCourseCollection)
					{
						if(child.AdmCdePlacementExamIdSource != null)
						{
							child.AdmCdePlacementExamId = child.AdmCdePlacementExamIdSource.AdmCdePlacementExamId;
						}
						else
						{
							child.AdmCdePlacementExamId = entity.AdmCdePlacementExamId;
						}

					}

					if (entity.AdmPlaceExamCourseCollection.Count > 0 || entity.AdmPlaceExamCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmPlaceExamCourseProvider.Save(transactionManager, entity.AdmPlaceExamCourseCollection);
						
						deepHandles.Add("AdmPlaceExamCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmPlaceExamCourse >) DataRepository.AdmPlaceExamCourseProvider.DeepSave,
							new object[] { transactionManager, entity.AdmPlaceExamCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmPlaceExamDatetime>
				if (CanDeepSave(entity.AdmPlaceExamDatetimeCollection, "List<AdmPlaceExamDatetime>|AdmPlaceExamDatetimeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPlaceExamDatetime child in entity.AdmPlaceExamDatetimeCollection)
					{
						if(child.AdmCdePlacementExamIdSource != null)
						{
							child.AdmCdePlacementExamId = child.AdmCdePlacementExamIdSource.AdmCdePlacementExamId;
						}
						else
						{
							child.AdmCdePlacementExamId = entity.AdmCdePlacementExamId;
						}

					}

					if (entity.AdmPlaceExamDatetimeCollection.Count > 0 || entity.AdmPlaceExamDatetimeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmPlaceExamDatetimeProvider.Save(transactionManager, entity.AdmPlaceExamDatetimeCollection);
						
						deepHandles.Add("AdmPlaceExamDatetimeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmPlaceExamDatetime >) DataRepository.AdmPlaceExamDatetimeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmPlaceExamDatetimeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCompetitiveAvg>
				if (CanDeepSave(entity.AdmCompetitiveAvgCollection, "List<AdmCompetitiveAvg>|AdmCompetitiveAvgCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCompetitiveAvg child in entity.AdmCompetitiveAvgCollection)
					{
						if(child.AdmCdePlacementExamIdSource != null)
						{
							child.AdmCdePlacementExamId = child.AdmCdePlacementExamIdSource.AdmCdePlacementExamId;
						}
						else
						{
							child.AdmCdePlacementExamId = entity.AdmCdePlacementExamId;
						}

					}

					if (entity.AdmCompetitiveAvgCollection.Count > 0 || entity.AdmCompetitiveAvgCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCompetitiveAvgProvider.Save(transactionManager, entity.AdmCompetitiveAvgCollection);
						
						deepHandles.Add("AdmCompetitiveAvgCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCompetitiveAvg >) DataRepository.AdmCompetitiveAvgProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCompetitiveAvgCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppInterviewExam>
				if (CanDeepSave(entity.AdmAppInterviewExamCollection, "List<AdmAppInterviewExam>|AdmAppInterviewExamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppInterviewExam child in entity.AdmAppInterviewExamCollection)
					{
						if(child.AdmCdePlacementExamIdSource != null)
						{
							child.AdmCdePlacementExamId = child.AdmCdePlacementExamIdSource.AdmCdePlacementExamId;
						}
						else
						{
							child.AdmCdePlacementExamId = entity.AdmCdePlacementExamId;
						}

					}

					if (entity.AdmAppInterviewExamCollection.Count > 0 || entity.AdmAppInterviewExamCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppInterviewExamProvider.Save(transactionManager, entity.AdmAppInterviewExamCollection);
						
						deepHandles.Add("AdmAppInterviewExamCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppInterviewExam >) DataRepository.AdmAppInterviewExamProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppInterviewExamCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCodeEngTest>
				if (CanDeepSave(entity.AdmCodeEngTestCollection, "List<AdmCodeEngTest>|AdmCodeEngTestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCodeEngTest child in entity.AdmCodeEngTestCollection)
					{
						if(child.AdmCdePlacementExamIdSource != null)
						{
							child.AdmCdePlacementExamId = child.AdmCdePlacementExamIdSource.AdmCdePlacementExamId;
						}
						else
						{
							child.AdmCdePlacementExamId = entity.AdmCdePlacementExamId;
						}

					}

					if (entity.AdmCodeEngTestCollection.Count > 0 || entity.AdmCodeEngTestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCodeEngTestProvider.Save(transactionManager, entity.AdmCodeEngTestCollection);
						
						deepHandles.Add("AdmCodeEngTestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCodeEngTest >) DataRepository.AdmCodeEngTestProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCodeEngTestCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppPlacementExam>
				if (CanDeepSave(entity.AdmAppPlacementExamCollection, "List<AdmAppPlacementExam>|AdmAppPlacementExamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppPlacementExam child in entity.AdmAppPlacementExamCollection)
					{
						if(child.AdmCdePlacementExamIdSource != null)
						{
							child.AdmCdePlacementExamId = child.AdmCdePlacementExamIdSource.AdmCdePlacementExamId;
						}
						else
						{
							child.AdmCdePlacementExamId = entity.AdmCdePlacementExamId;
						}

					}

					if (entity.AdmAppPlacementExamCollection.Count > 0 || entity.AdmAppPlacementExamCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppPlacementExamProvider.Save(transactionManager, entity.AdmAppPlacementExamCollection);
						
						deepHandles.Add("AdmAppPlacementExamCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppPlacementExam >) DataRepository.AdmAppPlacementExamProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppPlacementExamCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCdePlacementExam>
				if (CanDeepSave(entity.AdmCdePlacementExamCollectionGetByAdmCdePlacExamPrntId, "List<AdmCdePlacementExam>|AdmCdePlacementExamCollectionGetByAdmCdePlacExamPrntId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCdePlacementExam child in entity.AdmCdePlacementExamCollectionGetByAdmCdePlacExamPrntId)
					{
						if(child.AdmCdePlacExamPrntIdSource != null)
						{
							child.AdmCdePlacExamPrntId = child.AdmCdePlacExamPrntIdSource.AdmCdePlacementExamId;
						}
						else
						{
							child.AdmCdePlacExamPrntId = entity.AdmCdePlacementExamId;
						}

					}

					if (entity.AdmCdePlacementExamCollectionGetByAdmCdePlacExamPrntId.Count > 0 || entity.AdmCdePlacementExamCollectionGetByAdmCdePlacExamPrntId.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCdePlacementExamProvider.Save(transactionManager, entity.AdmCdePlacementExamCollectionGetByAdmCdePlacExamPrntId);
						
						deepHandles.Add("AdmCdePlacementExamCollectionGetByAdmCdePlacExamPrntId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCdePlacementExam >) DataRepository.AdmCdePlacementExamProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCdePlacementExamCollectionGetByAdmCdePlacExamPrntId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCdeFee>
				if (CanDeepSave(entity.AdmCdeFeeCollection, "List<AdmCdeFee>|AdmCdeFeeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCdeFee child in entity.AdmCdeFeeCollection)
					{
						if(child.AdmCdePlacementExamIdSource != null)
						{
							child.AdmCdePlacementExamId = child.AdmCdePlacementExamIdSource.AdmCdePlacementExamId;
						}
						else
						{
							child.AdmCdePlacementExamId = entity.AdmCdePlacementExamId;
						}

					}

					if (entity.AdmCdeFeeCollection.Count > 0 || entity.AdmCdeFeeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCdeFeeProvider.Save(transactionManager, entity.AdmCdeFeeCollection);
						
						deepHandles.Add("AdmCdeFeeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCdeFee >) DataRepository.AdmCdeFeeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCdeFeeCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmCdePlacementExamChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmCdePlacementExam</c>
	///</summary>
	public enum AdmCdePlacementExamChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCdeExamGrdng</c> at AdmCdeExamMinGrdngIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeExamGrdng))]
		AdmCdeExamGrdng,
		
		///<summary>
		/// Composite Property for <c>AdmCdePlacementExam</c> at AdmCdePlacExamPrntIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdePlacementExam))]
		AdmCdePlacementExam,
		
		///<summary>
		/// Composite Property for <c>AdmExamGrdngPkg</c> at AdmExamGrdngPkgIdSource
		///</summary>
		[ChildEntityType(typeof(AdmExamGrdngPkg))]
		AdmExamGrdngPkg,
		
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
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		///<summary>
		/// Collection of <c>AdmCdePlacementExam</c> as OneToMany for AdmCdePlacementExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCdePlacementExam>))]
		AdmCdePlacementExamCollectionGetByChlangExamId,
		///<summary>
		/// Collection of <c>AdmCdePlacementExam</c> as OneToMany for AdmPlaceExamCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPlaceExamCourse>))]
		AdmPlaceExamCourseCollection,
		///<summary>
		/// Collection of <c>AdmCdePlacementExam</c> as OneToMany for AdmPlaceExamDatetimeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPlaceExamDatetime>))]
		AdmPlaceExamDatetimeCollection,
		///<summary>
		/// Collection of <c>AdmCdePlacementExam</c> as OneToMany for AdmCompetitiveAvgCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCompetitiveAvg>))]
		AdmCompetitiveAvgCollection,
		///<summary>
		/// Collection of <c>AdmCdePlacementExam</c> as OneToMany for AdmAppInterviewExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppInterviewExam>))]
		AdmAppInterviewExamCollection,
		///<summary>
		/// Collection of <c>AdmCdePlacementExam</c> as OneToMany for AdmCodeEngTestCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCodeEngTest>))]
		AdmCodeEngTestCollection,
		///<summary>
		/// Collection of <c>AdmCdePlacementExam</c> as OneToMany for AdmAppPlacementExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppPlacementExam>))]
		AdmAppPlacementExamCollection,
		///<summary>
		/// Collection of <c>AdmCdePlacementExam</c> as OneToMany for AdmCdePlacementExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCdePlacementExam>))]
		AdmCdePlacementExamCollectionGetByAdmCdePlacExamPrntId,
		///<summary>
		/// Collection of <c>AdmCdePlacementExam</c> as OneToMany for AdmCdeFeeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCdeFee>))]
		AdmCdeFeeCollection,
	}
	
	#endregion AdmCdePlacementExamChildEntityTypes
	
	#region AdmCdePlacementExamFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmCdePlacementExamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdePlacementExam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdePlacementExamFilterBuilder : SqlFilterBuilder<AdmCdePlacementExamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdePlacementExamFilterBuilder class.
		/// </summary>
		public AdmCdePlacementExamFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdePlacementExamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdePlacementExamFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdePlacementExamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdePlacementExamFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdePlacementExamFilterBuilder
	
	#region AdmCdePlacementExamParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmCdePlacementExamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdePlacementExam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdePlacementExamParameterBuilder : ParameterizedSqlFilterBuilder<AdmCdePlacementExamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdePlacementExamParameterBuilder class.
		/// </summary>
		public AdmCdePlacementExamParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdePlacementExamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdePlacementExamParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdePlacementExamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdePlacementExamParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdePlacementExamParameterBuilder
	
	#region AdmCdePlacementExamSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmCdePlacementExamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdePlacementExam"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmCdePlacementExamSortBuilder : SqlSortBuilder<AdmCdePlacementExamColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdePlacementExamSqlSortBuilder class.
		/// </summary>
		public AdmCdePlacementExamSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmCdePlacementExamSortBuilder
	
} // end namespace
