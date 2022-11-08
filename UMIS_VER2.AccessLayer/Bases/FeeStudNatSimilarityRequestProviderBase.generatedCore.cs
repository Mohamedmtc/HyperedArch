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
	/// This class is the base class for any <see cref="FeeStudNatSimilarityRequestProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudNatSimilarityRequestProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest, UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequestKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequestKey key)
		{
			return Delete(transactionManager, key.FeeStudNatSimilarityRequestId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeStudNatSimilarityRequestId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeStudNatSimilarityRequestId)
		{
			return Delete(null, _feeStudNatSimilarityRequestId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudNatSimilarityRequestId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeStudNatSimilarityRequestId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_AS_FACULTY_INFO key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_AS_FACULTY_INFO key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudNatSimilarityRequest> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_AS_FACULTY_INFO key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_AS_FACULTY_INFO key.
		///		fkFeeStudNatSimilarityRequestAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_AS_FACULTY_INFO key.
		///		fkFeeStudNatSimilarityRequestAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_AS_FACULTY_INFO key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public abstract TList<FeeStudNatSimilarityRequest> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudNatSimilarityRequest> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_ACAD_YEAR key.
		///		fkFeeStudNatSimilarityRequestEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_ACAD_YEAR key.
		///		fkFeeStudNatSimilarityRequestEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public abstract TList<FeeStudNatSimilarityRequest> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudNatSimilarityRequest> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_CODE_SEMESTER key.
		///		fkFeeStudNatSimilarityRequestEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_CODE_SEMESTER key.
		///		fkFeeStudNatSimilarityRequestEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public abstract TList<FeeStudNatSimilarityRequest> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_STUD key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_STUD key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudNatSimilarityRequest> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_STUD key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_STUD key.
		///		fkFeeStudNatSimilarityRequestEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_STUD key.
		///		fkFeeStudNatSimilarityRequestEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_STUD key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public abstract TList<FeeStudNatSimilarityRequest> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_FEE_CODE_REASONS key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_FEE_CODE_REASONS Description: 
		/// </summary>
		/// <param name="_feeCodeReasonsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByFeeCodeReasonsId(System.Decimal _feeCodeReasonsId)
		{
			int count = -1;
			return GetByFeeCodeReasonsId(_feeCodeReasonsId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_FEE_CODE_REASONS key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_FEE_CODE_REASONS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeReasonsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudNatSimilarityRequest> GetByFeeCodeReasonsId(TransactionManager transactionManager, System.Decimal _feeCodeReasonsId)
		{
			int count = -1;
			return GetByFeeCodeReasonsId(transactionManager, _feeCodeReasonsId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_FEE_CODE_REASONS key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_FEE_CODE_REASONS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeReasonsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByFeeCodeReasonsId(TransactionManager transactionManager, System.Decimal _feeCodeReasonsId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeReasonsId(transactionManager, _feeCodeReasonsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_FEE_CODE_REASONS key.
		///		fkFeeStudNatSimilarityRequestFeeCodeReasons Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeReasonsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByFeeCodeReasonsId(System.Decimal _feeCodeReasonsId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeReasonsId(null, _feeCodeReasonsId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_FEE_CODE_REASONS key.
		///		fkFeeStudNatSimilarityRequestFeeCodeReasons Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeReasonsId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public TList<FeeStudNatSimilarityRequest> GetByFeeCodeReasonsId(System.Decimal _feeCodeReasonsId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeReasonsId(null, _feeCodeReasonsId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_NAT_SIMILARITY_REQUEST_FEE_CODE_REASONS key.
		///		FK_FEE_STUD_NAT_SIMILARITY_REQUEST_FEE_CODE_REASONS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeReasonsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest objects.</returns>
		public abstract TList<FeeStudNatSimilarityRequest> GetByFeeCodeReasonsId(TransactionManager transactionManager, System.Decimal _feeCodeReasonsId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequestKey key, int start, int pageLength)
		{
			return GetByFeeStudNatSimilarityRequestId(transactionManager, key.FeeStudNatSimilarityRequestId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_STUD_NAT_SIMILARITY_REQUEST index.
		/// </summary>
		/// <param name="_feeStudNatSimilarityRequestId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest GetByFeeStudNatSimilarityRequestId(System.Decimal _feeStudNatSimilarityRequestId)
		{
			int count = -1;
			return GetByFeeStudNatSimilarityRequestId(null,_feeStudNatSimilarityRequestId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_NAT_SIMILARITY_REQUEST index.
		/// </summary>
		/// <param name="_feeStudNatSimilarityRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest GetByFeeStudNatSimilarityRequestId(System.Decimal _feeStudNatSimilarityRequestId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudNatSimilarityRequestId(null, _feeStudNatSimilarityRequestId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_NAT_SIMILARITY_REQUEST index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudNatSimilarityRequestId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest GetByFeeStudNatSimilarityRequestId(TransactionManager transactionManager, System.Decimal _feeStudNatSimilarityRequestId)
		{
			int count = -1;
			return GetByFeeStudNatSimilarityRequestId(transactionManager, _feeStudNatSimilarityRequestId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_NAT_SIMILARITY_REQUEST index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudNatSimilarityRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest GetByFeeStudNatSimilarityRequestId(TransactionManager transactionManager, System.Decimal _feeStudNatSimilarityRequestId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudNatSimilarityRequestId(transactionManager, _feeStudNatSimilarityRequestId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_NAT_SIMILARITY_REQUEST index.
		/// </summary>
		/// <param name="_feeStudNatSimilarityRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest GetByFeeStudNatSimilarityRequestId(System.Decimal _feeStudNatSimilarityRequestId, int start, int pageLength, out int count)
		{
			return GetByFeeStudNatSimilarityRequestId(null, _feeStudNatSimilarityRequestId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_NAT_SIMILARITY_REQUEST index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudNatSimilarityRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest GetByFeeStudNatSimilarityRequestId(TransactionManager transactionManager, System.Decimal _feeStudNatSimilarityRequestId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeStudNatSimilarityRequest&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeStudNatSimilarityRequest&gt;"/></returns>
		public static TList<FeeStudNatSimilarityRequest> Fill(IDataReader reader, TList<FeeStudNatSimilarityRequest> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeStudNatSimilarityRequest")
					.Append("|").Append((System.Decimal)reader["FEE_STUD_NAT_SIMILARITY_REQUEST_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeStudNatSimilarityRequest>(
					key.ToString(), // EntityTrackingKey
					"FeeStudNatSimilarityRequest",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest();
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
					c.FeeStudNatSimilarityRequestId = (System.Decimal)reader["FEE_STUD_NAT_SIMILARITY_REQUEST_ID"];
					c.OriginalFeeStudNatSimilarityRequestId = c.FeeStudNatSimilarityRequestId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.RequestDate = (System.DateTime)reader["REQUEST_DATE"];
					c.ReasonNote = (System.String)reader["REASON_NOTE"];
					c.RequestStatus = (System.Decimal)reader["REQUEST_STATUS"];
					c.FeeCodeReasonsId = (System.Decimal)reader["FEE_CODE_REASONS_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeStudNatSimilarityRequestId = (System.Decimal)reader[((int)FeeStudNatSimilarityRequestColumn.FeeStudNatSimilarityRequestId - 1)];
			entity.OriginalFeeStudNatSimilarityRequestId = (System.Decimal)reader["FEE_STUD_NAT_SIMILARITY_REQUEST_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)FeeStudNatSimilarityRequestColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)FeeStudNatSimilarityRequestColumn.EdCodeSemesterId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)FeeStudNatSimilarityRequestColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)FeeStudNatSimilarityRequestColumn.AsFacultyInfoId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)FeeStudNatSimilarityRequestColumn.EdStudId - 1)];
			entity.RequestDate = (System.DateTime)reader[((int)FeeStudNatSimilarityRequestColumn.RequestDate - 1)];
			entity.ReasonNote = (System.String)reader[((int)FeeStudNatSimilarityRequestColumn.ReasonNote - 1)];
			entity.RequestStatus = (System.Decimal)reader[((int)FeeStudNatSimilarityRequestColumn.RequestStatus - 1)];
			entity.FeeCodeReasonsId = (System.Decimal)reader[((int)FeeStudNatSimilarityRequestColumn.FeeCodeReasonsId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeStudNatSimilarityRequestId = (System.Decimal)dataRow["FEE_STUD_NAT_SIMILARITY_REQUEST_ID"];
			entity.OriginalFeeStudNatSimilarityRequestId = (System.Decimal)dataRow["FEE_STUD_NAT_SIMILARITY_REQUEST_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.RequestDate = (System.DateTime)dataRow["REQUEST_DATE"];
			entity.ReasonNote = (System.String)dataRow["REASON_NOTE"];
			entity.RequestStatus = (System.Decimal)dataRow["REQUEST_STATUS"];
			entity.FeeCodeReasonsId = (System.Decimal)dataRow["FEE_CODE_REASONS_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region FeeCodeReasonsIdSource	
			if (CanDeepLoad(entity, "FeeCodeReasons|FeeCodeReasonsIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeReasonsIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCodeReasonsId;
				FeeCodeReasons tmpEntity = EntityManager.LocateEntity<FeeCodeReasons>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeReasons), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeReasonsIdSource = tmpEntity;
				else
					entity.FeeCodeReasonsIdSource = DataRepository.FeeCodeReasonsProvider.GetByFeeCodeReasonsId(transactionManager, entity.FeeCodeReasonsId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeReasonsIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeReasonsIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeReasonsProvider.DeepLoad(transactionManager, entity.FeeCodeReasonsIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeReasonsIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region FeeCodeReasonsIdSource
			if (CanDeepSave(entity, "FeeCodeReasons|FeeCodeReasonsIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeReasonsIdSource != null)
			{
				DataRepository.FeeCodeReasonsProvider.Save(transactionManager, entity.FeeCodeReasonsIdSource);
				entity.FeeCodeReasonsId = entity.FeeCodeReasonsIdSource.FeeCodeReasonsId;
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
	
	#region FeeStudNatSimilarityRequestChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeStudNatSimilarityRequest</c>
	///</summary>
	public enum FeeStudNatSimilarityRequestChildEntityTypes
	{
		
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
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>FeeCodeReasons</c> at FeeCodeReasonsIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeReasons))]
		FeeCodeReasons,
	}
	
	#endregion FeeStudNatSimilarityRequestChildEntityTypes
	
	#region FeeStudNatSimilarityRequestFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeStudNatSimilarityRequestColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudNatSimilarityRequest"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudNatSimilarityRequestFilterBuilder : SqlFilterBuilder<FeeStudNatSimilarityRequestColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudNatSimilarityRequestFilterBuilder class.
		/// </summary>
		public FeeStudNatSimilarityRequestFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudNatSimilarityRequestFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudNatSimilarityRequestFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudNatSimilarityRequestFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudNatSimilarityRequestFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudNatSimilarityRequestFilterBuilder
	
	#region FeeStudNatSimilarityRequestParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeStudNatSimilarityRequestColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudNatSimilarityRequest"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudNatSimilarityRequestParameterBuilder : ParameterizedSqlFilterBuilder<FeeStudNatSimilarityRequestColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudNatSimilarityRequestParameterBuilder class.
		/// </summary>
		public FeeStudNatSimilarityRequestParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudNatSimilarityRequestParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudNatSimilarityRequestParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudNatSimilarityRequestParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudNatSimilarityRequestParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudNatSimilarityRequestParameterBuilder
	
	#region FeeStudNatSimilarityRequestSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeStudNatSimilarityRequestColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudNatSimilarityRequest"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeStudNatSimilarityRequestSortBuilder : SqlSortBuilder<FeeStudNatSimilarityRequestColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudNatSimilarityRequestSqlSortBuilder class.
		/// </summary>
		public FeeStudNatSimilarityRequestSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeStudNatSimilarityRequestSortBuilder
	
} // end namespace
